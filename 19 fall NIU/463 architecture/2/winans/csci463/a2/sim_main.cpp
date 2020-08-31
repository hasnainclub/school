#include <unistd.h>
#include <getopt.h>

#include <verilated.h>          // Defines common routines
#include <verilated_vcd_c.h>
#include <iostream>             // Need std::cout
#include <string>
#include <ctype.h>
#include <iostream>
#include <fstream>
#include "Vtop.h"               // From Verilating "top.v"

using namespace std;

static Vtop *top;                      // Instantiation of module

static vluint64_t main_time = 0;       // Current simulation time
static VerilatedVcdC* tfp;

#define PERIOD	(5)

/**
* Called by $time in Verilog
****************************************************************************/
double sc_time_stamp () 
{       
	return main_time;		// converts to double, to match
							// what SystemC does
}

/**
****************************************************************************/
static void tick(int count)
{
	for (;count > 0; --count)
	{
		//tfp->dump(main_time);	// dump traces (inputs stable before outputs change)
		top->eval();            // Evaluate model
		main_time++;            // Time passes...
		tfp->dump(main_time);	// inputs and outputs all updated at same time
	}
}

/**
****************************************************************************/
static void reset()
{
	top->mar_we = 0;
	top->mbr_out_we = 0;
	top->mbr_in_we = 0;
	top->mem_we = 0;
	top->mbr_alu = 0;

	top->reset = 0;
	tick(PERIOD-1);		// moronic GTK wave starts at 1???
	top->reset = 1;
	tick(PERIOD);
	top->reset = 0;
	tick(PERIOD);
}

/**
****************************************************************************/
static void dumpMemory()
{
	int i;
	for (i=0; i<256; ++i)
	{
		if (i%16==0)
			printf("%s%04X: ", i==0?"":"\n", i);
		printf("%02X%s", top->top__DOT__umem__DOT__do_r[i], (i%16==7)?"  ":" ");
	}
	printf("\n");
}

/**
****************************************************************************/
static void loadMemory(std::istream &in)
{
	cout << "loading memory..." << std::endl;

	std::string s;
	for (int i=0; i<256 && in>>s; ++i)
	{
		top->top__DOT__umem__DOT__do_r[i] = strtoul(s.c_str(), 0, 16);
	}
}

/**
****************************************************************************/
void dumpRegs()
{
	for (int i=0; i<4; ++i)
	{
		printf("       reg(%d) = 0x%02X\n", i, top->top__DOT__regout[i]);
	}
}

/**
****************************************************************************/
void dumpState(int verbose)
{
	if (!verbose)
		return;

	printf("*    alu_func = 0x%d\n", top->alu_func);
	printf("*  alu_comp_b = 0x%d\n", top->alu_comp_b);
	printf("*      alu_ci = 0x%d\n", top->alu_ci);
	printf("*      reg_we = 0x%d\n", top->reg_we);
	printf("*     mbr_alu = 0x%d\n", top->mbr_alu);
	printf("*      mar_we = 0x%d\n", top->mar_we);
	printf("*      mem_we = 0x%d\n", top->mem_we);
	printf("*  mbr_out_we = 0x%d\n", top->mbr_out_we);
	printf("*   mbr_in_we = 0x%d\n", top->mbr_in_we);
	printf("* reg_addr_we = 0x%d\n", top->reg_addr_we);
	printf("*   alu_reg_a = 0x%d\n", top->alu_reg_a);
	printf("*   alu_reg_b = 0x%d\n", top->alu_reg_b);

	printf("       alu_so = 0x%d\n", top->alu_so);
	printf("       alu_uo = 0x%d\n", top->alu_uo);


#if 0
    VL_SIG8(top__DOT__alu_a,7,0);
    VL_SIG8(top__DOT__alu_b,7,0);
    VL_SIG8(top__DOT__alu_q,7,0);
    VL_SIG8(top__DOT__reg_in,7,0);
    VL_SIG8(top__DOT__umar__DOT__do_r,7,0);
    VL_SIG8(top__DOT__umbr_out__DOT__do_r,7,0);
    VL_SIG8(top__DOT__umbr_in__DOT__do_r,7,0);
    VL_SIG8(top__DOT__register_file__BRA__0__KET____DOT__register_inst__DOT__do_r,7,0);
    VL_SIG8(top__DOT__register_file__BRA__1__KET____DOT__register_inst__DOT__do_r,7,0);
    VL_SIG8(top__DOT__register_file__BRA__2__KET____DOT__register_inst__DOT__do_r,7,0);
    VL_SIG8(top__DOT__register_file__BRA__3__KET____DOT__register_inst__DOT__do_r,7,0);
    VL_SIG16(top__DOT__alu_inst__DOT__cc,8,0);
    VL_SIG8(top__DOT__regout[4],7,0);
    VL_SIG8(top__DOT__umem__DOT__do_r
#endif

	printf("        alu_a = 0x%02X\n", top->top__DOT__alu_a);
	printf("        alu_b = 0x%02X\n", top->top__DOT__alu_b);
	printf("        alu_q = 0x%02X\n", top->top__DOT__alu_q);
	printf("       reg_in = 0x%02X\n", top->top__DOT__reg_in);
	//printf("  mar_out = 0x%02X\n", top->top__DOT__umar__DOT__do_r);
	printf("       mbr_in = 0x%02X\n", top->top__DOT__umbr_in__DOT__do_r);
	printf("        d_out = 0x%02X\n", top->top__DOT__umbr_out__DOT__do_r);
	printf("         d_in = 0x%02X\n", top->top__DOT__umbr_in__DOT__do_r);
	printf("     addr_out = 0x%02X\n", top->top__DOT__umar__DOT__do_r);

	dumpRegs();

	if (verbose > 1)
		dumpMemory();
}

/**
* Read stdin for 16-bits per line & use as microcode.
****************************************************************************/
static void processMicrocode(std::istream &in, int verbose)
{
	std::string s;
	int line = 0;		// input line number

	while (std::getline(in, s))
	{
		uint32_t insn = 0;	// the collected bits
		int count = 0;		// how many bits we have collected
		int i = 0;			// input string character position

		++line;
		//printf("%4d: '%s'\n", line, s.c_str());
	
		// remove leading space
		while(isspace(s[i]))
			++i;
	
		// if found '#' then skip (comment)
		while(i<s.length())
		{
			switch(s[i])
			{
			case '0':
				++count;
				insn <<= 1;	// shift in a zero
				break;
			case '1':
				++count;
				insn <<= 1;	// shift in a...
				insn |= 1;	// one
				break;
			case '#':
				i = s.length()-1;	// skip to end of line
				break;
			default:
				if (!isspace(s[i]))
				{
					printf("syntax error on line %d, character character %d: '%s'\n", line, i+1, s.c_str());
					exit(1);
				}
			}
			++i;
		}
		if (count == 16)
		{
			printf("insn: %04X '%s'\n", insn, s.c_str());
			
			top->alu_func = (insn>>14) & 0x03;
			top->alu_comp_b = (insn>>13) & 0x01;
			top->alu_ci = (insn>>12) & 0x01;
			top->reg_we = (insn>>11) & 0x01;
			top->mbr_alu = (insn>>10) & 0x01;
			top->mar_we = (insn>>9) & 0x01;
			top->mem_we = (insn>>8) & 0x01;
			top->mbr_out_we = (insn>>7) & 0x01;
			top->mbr_in_we = (insn>>6) & 0x01;
			top->reg_addr_we = (insn>>4) & 0x03;
			top->alu_reg_a = (insn>>2) & 0x03;
			top->alu_reg_b = insn & 0x03;

			tick(PERIOD);
			
			dumpState(verbose);
		}
		else if (count != 0)
			printf("syntax error on line %d, want 16 bits, got %d: '%s'\n", line, count, s.c_str());
	}
}

/**
* sim ucfile [memfile]
****************************************************************************/
int main(int argc, char** argv) 
{
	Verilated::commandArgs(argc, argv);
	top = new Vtop;             // Create instance

    // init trace dump
    Verilated::traceEverOn(true);
    tfp = new VerilatedVcdC;
    top->trace(tfp, 99);
    tfp->open("wave.vcd");

	const char *ucFilename = 0;
	const char *memFilename = 0;
	int verbose = 0;

	int opt;
	while ((opt = getopt(argc, argv, "v:")) != -1) 
	{
		switch (opt) 
		{
		case 'v':
			verbose=atoi(optarg);
			break;
		}
	}

	// cout << "verbosity is " << verbose << endl;

	ifstream ucfile;
	istream *ucin;
	if (optind < argc)
	{
		ucfile.open(argv[optind]);
		if (!ucfile.is_open())
		{
			cerr << "Can't open file '" << argv[optind] << "' for reading" << std::endl;
			exit(1);
		}
		ucin = &ucfile;
		++optind;
	}
	else
	{
		ucin = &std::cin;
	}

	if (optind < argc)
	{
		ifstream memfile(argv[optind]);
		if (!memfile.is_open())
		{
			cerr << "Can't open file '" << argv[optind] << "' for reading" << std::endl;
			exit(1);
		}
		loadMemory(memfile);
		memfile.close();
	}

    // start things going
	reset();

	cout << "Memory before execution begins:\n";
	dumpMemory();
	cout << "\n";

	processMicrocode(*ucin, verbose);

	cout << "\nMemory after execution ends:\n";
	dumpMemory();

	if (ucfile.is_open())
		ucfile.close();

	tfp->close();
	top->final();               // Done simulating
	// (Though this example doesn't get here)
	delete tfp;
	delete top;
}
