// Verilated -*- C++ -*-
// DESCRIPTION: Verilator output: Tracing implementation internals
#include "verilated_vcd_c.h"
#include "Vtop__Syms.h"


//======================

void Vtop::trace (VerilatedVcdC* tfp, int, int) {
    tfp->spTrace()->addCallback (&Vtop::traceInit, &Vtop::traceFull, &Vtop::traceChg, this);
}
void Vtop::traceInit(VerilatedVcd* vcdp, void* userthis, uint32_t code) {
    // Callback from vcd->open()
    Vtop* t=(Vtop*)userthis;
    Vtop__Syms* __restrict vlSymsp = t->__VlSymsp; // Setup global symbol table
    if (!Verilated::calcUnusedSigs()) vl_fatal(__FILE__,__LINE__,__FILE__,"Turning on wave traces requires Verilated::traceEverOn(true) call before time 0.");
    vcdp->scopeEscape(' ');
    t->traceInitThis (vlSymsp, vcdp, code);
    vcdp->scopeEscape('.');
}
void Vtop::traceFull(VerilatedVcd* vcdp, void* userthis, uint32_t code) {
    // Callback from vcd->dump()
    Vtop* t=(Vtop*)userthis;
    Vtop__Syms* __restrict vlSymsp = t->__VlSymsp; // Setup global symbol table
    t->traceFullThis (vlSymsp, vcdp, code);
}

//======================


void Vtop::traceInitThis(Vtop__Syms* __restrict vlSymsp, VerilatedVcd* vcdp, uint32_t code) {
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    int c=code;
    if (0 && vcdp && c) {}  // Prevent unused
    vcdp->module(vlSymsp->name()); // Setup signal names
    // Body
    {
	vlTOPp->traceInitThis__1(vlSymsp, vcdp, code);
    }
}

void Vtop::traceFullThis(Vtop__Syms* __restrict vlSymsp, VerilatedVcd* vcdp, uint32_t code) {
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    int c=code;
    if (0 && vcdp && c) {}  // Prevent unused
    // Body
    {
	vlTOPp->traceFullThis__1(vlSymsp, vcdp, code);
    }
    // Final
    vlTOPp->__Vm_traceActivity = 0U;
}

void Vtop::traceInitThis__1(Vtop__Syms* __restrict vlSymsp, VerilatedVcd* vcdp, uint32_t code) {
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    int c=code;
    if (0 && vcdp && c) {}  // Prevent unused
    // Body
    {
	vcdp->declBit  (c+67,"reset",-1);
	vcdp->declBus  (c+68,"reg_addr_we",-1,1,0);
	vcdp->declBit  (c+69,"reg_we",-1);
	vcdp->declBit  (c+70,"mar_we",-1);
	vcdp->declBit  (c+71,"mbr_out_we",-1);
	vcdp->declBit  (c+72,"mbr_in_we",-1);
	vcdp->declBit  (c+73,"mem_we",-1);
	vcdp->declBit  (c+74,"mbr_alu",-1);
	vcdp->declBus  (c+75,"alu_func",-1,1,0);
	vcdp->declBit  (c+76,"alu_comp_b",-1);
	vcdp->declBit  (c+77,"alu_ci",-1);
	vcdp->declBus  (c+78,"alu_reg_a",-1,1,0);
	vcdp->declBus  (c+79,"alu_reg_b",-1,1,0);
	vcdp->declBit  (c+80,"alu_so",-1);
	vcdp->declBit  (c+81,"alu_uo",-1);
	vcdp->declBit  (c+67,"top reset",-1);
	vcdp->declBus  (c+68,"top reg_addr_we",-1,1,0);
	vcdp->declBit  (c+69,"top reg_we",-1);
	vcdp->declBit  (c+70,"top mar_we",-1);
	vcdp->declBit  (c+71,"top mbr_out_we",-1);
	vcdp->declBit  (c+72,"top mbr_in_we",-1);
	vcdp->declBit  (c+73,"top mem_we",-1);
	vcdp->declBit  (c+74,"top mbr_alu",-1);
	vcdp->declBus  (c+75,"top alu_func",-1,1,0);
	vcdp->declBit  (c+76,"top alu_comp_b",-1);
	vcdp->declBit  (c+77,"top alu_ci",-1);
	vcdp->declBus  (c+78,"top alu_reg_a",-1,1,0);
	vcdp->declBus  (c+79,"top alu_reg_b",-1,1,0);
	vcdp->declBit  (c+80,"top alu_so",-1);
	vcdp->declBit  (c+81,"top alu_uo",-1);
	vcdp->declBus  (c+90,"top N",-1,31,0);
	{int i; for (i=0; i<4; i++) {
		vcdp->declBus  (c+48+i*1,"top regout",(i+0),7,0);}}
	vcdp->declBus  (c+1,"top regwe",-1,3,0);
	vcdp->declBus  (c+2,"top alu_a",-1,7,0);
	vcdp->declBus  (c+3,"top alu_b",-1,7,0);
	vcdp->declBus  (c+4,"top alu_q",-1,7,0);
	vcdp->declBus  (c+60,"top mbr_in",-1,7,0);
	vcdp->declBus  (c+5,"top reg_in",-1,7,0);
	vcdp->declBus  (c+61,"top d_out",-1,7,0);
	vcdp->declBus  (c+47,"top d_in",-1,7,0);
	vcdp->declBus  (c+62,"top addr_out",-1,7,0);
	// Tracing: top i // Ignored: Verilator trace_off at top.v:35
	vcdp->declBus  (c+52,"top amux_inst i0",-1,7,0);
	vcdp->declBus  (c+53,"top amux_inst i1",-1,7,0);
	vcdp->declBus  (c+54,"top amux_inst i2",-1,7,0);
	vcdp->declBus  (c+55,"top amux_inst i3",-1,7,0);
	vcdp->declBus  (c+78,"top amux_inst a",-1,1,0);
	vcdp->declBus  (c+2,"top amux_inst o",-1,7,0);
	vcdp->declBus  (c+90,"top amux_inst N",-1,31,0);
	vcdp->declBus  (c+56,"top bmux_inst i0",-1,7,0);
	vcdp->declBus  (c+57,"top bmux_inst i1",-1,7,0);
	vcdp->declBus  (c+58,"top bmux_inst i2",-1,7,0);
	vcdp->declBus  (c+59,"top bmux_inst i3",-1,7,0);
	vcdp->declBus  (c+79,"top bmux_inst a",-1,1,0);
	vcdp->declBus  (c+3,"top bmux_inst o",-1,7,0);
	vcdp->declBus  (c+90,"top bmux_inst N",-1,31,0);
	vcdp->declBus  (c+68,"top demux_inst a",-1,1,0);
	vcdp->declBit  (c+69,"top demux_inst i",-1);
	vcdp->declBus  (c+6,"top demux_inst o0",-1,0,0);
	vcdp->declBus  (c+7,"top demux_inst o1",-1,0,0);
	vcdp->declBus  (c+8,"top demux_inst o2",-1,0,0);
	vcdp->declBus  (c+9,"top demux_inst o3",-1,0,0);
	vcdp->declBus  (c+91,"top demux_inst N",-1,31,0);
	vcdp->declBit  (c+77,"top alu_inst ci",-1);
	vcdp->declBus  (c+2,"top alu_inst a",-1,7,0);
	vcdp->declBus  (c+3,"top alu_inst b",-1,7,0);
	vcdp->declBit  (c+76,"top alu_inst comp",-1);
	vcdp->declBus  (c+75,"top alu_inst f",-1,1,0);
	vcdp->declBit  (c+81,"top alu_inst uo",-1);
	vcdp->declBit  (c+80,"top alu_inst so",-1);
	vcdp->declBus  (c+4,"top alu_inst q",-1,7,0);
	vcdp->declBus  (c+90,"top alu_inst N",-1,31,0);
	vcdp->declBus  (c+10,"top alu_inst cc",-1,8,0);
	// Tracing: top alu_inst i // Ignored: Verilator trace_off at alu.v:21
	vcdp->declBit  (c+11,"top alu_inst genblk1[0] a_inst ci",-1);
	vcdp->declBit  (c+12,"top alu_inst genblk1[0] a_inst a",-1);
	vcdp->declBit  (c+13,"top alu_inst genblk1[0] a_inst b",-1);
	vcdp->declBit  (c+76,"top alu_inst genblk1[0] a_inst comp",-1);
	vcdp->declBus  (c+75,"top alu_inst genblk1[0] a_inst f",-1,1,0);
	vcdp->declBit  (c+82,"top alu_inst genblk1[0] a_inst co",-1);
	vcdp->declBit  (c+14,"top alu_inst genblk1[0] a_inst q",-1);
	vcdp->declBit  (c+15,"top alu_inst genblk1[1] a_inst ci",-1);
	vcdp->declBit  (c+16,"top alu_inst genblk1[1] a_inst a",-1);
	vcdp->declBit  (c+17,"top alu_inst genblk1[1] a_inst b",-1);
	vcdp->declBit  (c+76,"top alu_inst genblk1[1] a_inst comp",-1);
	vcdp->declBus  (c+75,"top alu_inst genblk1[1] a_inst f",-1,1,0);
	vcdp->declBit  (c+83,"top alu_inst genblk1[1] a_inst co",-1);
	vcdp->declBit  (c+18,"top alu_inst genblk1[1] a_inst q",-1);
	vcdp->declBit  (c+19,"top alu_inst genblk1[2] a_inst ci",-1);
	vcdp->declBit  (c+20,"top alu_inst genblk1[2] a_inst a",-1);
	vcdp->declBit  (c+21,"top alu_inst genblk1[2] a_inst b",-1);
	vcdp->declBit  (c+76,"top alu_inst genblk1[2] a_inst comp",-1);
	vcdp->declBus  (c+75,"top alu_inst genblk1[2] a_inst f",-1,1,0);
	vcdp->declBit  (c+84,"top alu_inst genblk1[2] a_inst co",-1);
	vcdp->declBit  (c+22,"top alu_inst genblk1[2] a_inst q",-1);
	vcdp->declBit  (c+23,"top alu_inst genblk1[3] a_inst ci",-1);
	vcdp->declBit  (c+24,"top alu_inst genblk1[3] a_inst a",-1);
	vcdp->declBit  (c+25,"top alu_inst genblk1[3] a_inst b",-1);
	vcdp->declBit  (c+76,"top alu_inst genblk1[3] a_inst comp",-1);
	vcdp->declBus  (c+75,"top alu_inst genblk1[3] a_inst f",-1,1,0);
	vcdp->declBit  (c+85,"top alu_inst genblk1[3] a_inst co",-1);
	vcdp->declBit  (c+26,"top alu_inst genblk1[3] a_inst q",-1);
	vcdp->declBit  (c+27,"top alu_inst genblk1[4] a_inst ci",-1);
	vcdp->declBit  (c+28,"top alu_inst genblk1[4] a_inst a",-1);
	vcdp->declBit  (c+29,"top alu_inst genblk1[4] a_inst b",-1);
	vcdp->declBit  (c+76,"top alu_inst genblk1[4] a_inst comp",-1);
	vcdp->declBus  (c+75,"top alu_inst genblk1[4] a_inst f",-1,1,0);
	vcdp->declBit  (c+86,"top alu_inst genblk1[4] a_inst co",-1);
	vcdp->declBit  (c+30,"top alu_inst genblk1[4] a_inst q",-1);
	vcdp->declBit  (c+31,"top alu_inst genblk1[5] a_inst ci",-1);
	vcdp->declBit  (c+32,"top alu_inst genblk1[5] a_inst a",-1);
	vcdp->declBit  (c+33,"top alu_inst genblk1[5] a_inst b",-1);
	vcdp->declBit  (c+76,"top alu_inst genblk1[5] a_inst comp",-1);
	vcdp->declBus  (c+75,"top alu_inst genblk1[5] a_inst f",-1,1,0);
	vcdp->declBit  (c+87,"top alu_inst genblk1[5] a_inst co",-1);
	vcdp->declBit  (c+34,"top alu_inst genblk1[5] a_inst q",-1);
	vcdp->declBit  (c+35,"top alu_inst genblk1[6] a_inst ci",-1);
	vcdp->declBit  (c+36,"top alu_inst genblk1[6] a_inst a",-1);
	vcdp->declBit  (c+37,"top alu_inst genblk1[6] a_inst b",-1);
	vcdp->declBit  (c+76,"top alu_inst genblk1[6] a_inst comp",-1);
	vcdp->declBus  (c+75,"top alu_inst genblk1[6] a_inst f",-1,1,0);
	vcdp->declBit  (c+88,"top alu_inst genblk1[6] a_inst co",-1);
	vcdp->declBit  (c+38,"top alu_inst genblk1[6] a_inst q",-1);
	vcdp->declBit  (c+39,"top alu_inst genblk1[7] a_inst ci",-1);
	vcdp->declBit  (c+40,"top alu_inst genblk1[7] a_inst a",-1);
	vcdp->declBit  (c+41,"top alu_inst genblk1[7] a_inst b",-1);
	vcdp->declBit  (c+76,"top alu_inst genblk1[7] a_inst comp",-1);
	vcdp->declBus  (c+75,"top alu_inst genblk1[7] a_inst f",-1,1,0);
	vcdp->declBit  (c+89,"top alu_inst genblk1[7] a_inst co",-1);
	vcdp->declBit  (c+42,"top alu_inst genblk1[7] a_inst q",-1);
	vcdp->declBus  (c+4,"top reg_mux i0",-1,7,0);
	vcdp->declBus  (c+60,"top reg_mux i1",-1,7,0);
	vcdp->declBit  (c+74,"top reg_mux a",-1);
	vcdp->declBus  (c+5,"top reg_mux o",-1,7,0);
	vcdp->declBus  (c+90,"top reg_mux N",-1,31,0);
	vcdp->declBus  (c+4,"top umar din",-1,7,0);
	vcdp->declBit  (c+70,"top umar we",-1);
	vcdp->declBit  (c+67,"top umar reset",-1);
	vcdp->declBus  (c+62,"top umar dout",-1,7,0);
	vcdp->declBus  (c+90,"top umar N",-1,31,0);
	vcdp->declBus  (c+62,"top umar do_r",-1,7,0);
	vcdp->declBus  (c+4,"top umbr_out din",-1,7,0);
	vcdp->declBit  (c+71,"top umbr_out we",-1);
	vcdp->declBit  (c+67,"top umbr_out reset",-1);
	vcdp->declBus  (c+61,"top umbr_out dout",-1,7,0);
	vcdp->declBus  (c+90,"top umbr_out N",-1,31,0);
	vcdp->declBus  (c+61,"top umbr_out do_r",-1,7,0);
	vcdp->declBus  (c+47,"top umbr_in din",-1,7,0);
	vcdp->declBit  (c+72,"top umbr_in we",-1);
	vcdp->declBit  (c+67,"top umbr_in reset",-1);
	vcdp->declBus  (c+60,"top umbr_in dout",-1,7,0);
	vcdp->declBus  (c+90,"top umbr_in N",-1,31,0);
	vcdp->declBus  (c+60,"top umbr_in do_r",-1,7,0);
	vcdp->declBus  (c+61,"top umem din",-1,7,0);
	vcdp->declBus  (c+62,"top umem ain",-1,7,0);
	vcdp->declBit  (c+73,"top umem we",-1);
	vcdp->declBus  (c+47,"top umem dout",-1,7,0);
	vcdp->declBus  (c+90,"top umem N",-1,31,0);
	// Tracing: top umem do_r // Ignored: Wide memory > --trace-max-array ents at memory.v:9
	vcdp->declBus  (c+5,"top register_file[0] register_inst din",-1,7,0);
	vcdp->declBit  (c+43,"top register_file[0] register_inst we",-1);
	vcdp->declBit  (c+67,"top register_file[0] register_inst reset",-1);
	vcdp->declBus  (c+63,"top register_file[0] register_inst dout",-1,7,0);
	vcdp->declBus  (c+90,"top register_file[0] register_inst N",-1,31,0);
	vcdp->declBus  (c+63,"top register_file[0] register_inst do_r",-1,7,0);
	vcdp->declBus  (c+5,"top register_file[1] register_inst din",-1,7,0);
	vcdp->declBit  (c+44,"top register_file[1] register_inst we",-1);
	vcdp->declBit  (c+67,"top register_file[1] register_inst reset",-1);
	vcdp->declBus  (c+64,"top register_file[1] register_inst dout",-1,7,0);
	vcdp->declBus  (c+90,"top register_file[1] register_inst N",-1,31,0);
	vcdp->declBus  (c+64,"top register_file[1] register_inst do_r",-1,7,0);
	vcdp->declBus  (c+5,"top register_file[2] register_inst din",-1,7,0);
	vcdp->declBit  (c+45,"top register_file[2] register_inst we",-1);
	vcdp->declBit  (c+67,"top register_file[2] register_inst reset",-1);
	vcdp->declBus  (c+65,"top register_file[2] register_inst dout",-1,7,0);
	vcdp->declBus  (c+90,"top register_file[2] register_inst N",-1,31,0);
	vcdp->declBus  (c+65,"top register_file[2] register_inst do_r",-1,7,0);
	vcdp->declBus  (c+5,"top register_file[3] register_inst din",-1,7,0);
	vcdp->declBit  (c+46,"top register_file[3] register_inst we",-1);
	vcdp->declBit  (c+67,"top register_file[3] register_inst reset",-1);
	vcdp->declBus  (c+66,"top register_file[3] register_inst dout",-1,7,0);
	vcdp->declBus  (c+90,"top register_file[3] register_inst N",-1,31,0);
	vcdp->declBus  (c+66,"top register_file[3] register_inst do_r",-1,7,0);
    }
}

void Vtop::traceFullThis__1(Vtop__Syms* __restrict vlSymsp, VerilatedVcd* vcdp, uint32_t code) {
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    int c=code;
    if (0 && vcdp && c) {}  // Prevent unused
    // Body
    {
	vcdp->fullBus  (c+1,(vlTOPp->top__DOT__regwe),4);
	vcdp->fullBus  (c+2,(vlTOPp->top__DOT__alu_a),8);
	vcdp->fullBus  (c+3,(vlTOPp->top__DOT__alu_b),8);
	vcdp->fullBus  (c+4,(vlTOPp->top__DOT__alu_q),8);
	vcdp->fullBus  (c+5,(vlTOPp->top__DOT__reg_in),8);
	vcdp->fullBus  (c+6,(vlTOPp->top__DOT____Vcellout__demux_inst__o0),1);
	vcdp->fullBus  (c+7,(vlTOPp->top__DOT____Vcellout__demux_inst__o1),1);
	vcdp->fullBus  (c+8,(vlTOPp->top__DOT____Vcellout__demux_inst__o2),1);
	vcdp->fullBus  (c+9,(vlTOPp->top__DOT____Vcellout__demux_inst__o3),1);
	vcdp->fullBus  (c+10,(vlTOPp->top__DOT__alu_inst__DOT__cc),9);
	vcdp->fullBit  (c+11,((1U & (IData)(vlTOPp->top__DOT__alu_inst__DOT__cc))));
	vcdp->fullBit  (c+12,((1U & (IData)(vlTOPp->top__DOT__alu_a))));
	vcdp->fullBit  (c+13,((1U & (IData)(vlTOPp->top__DOT__alu_b))));
	vcdp->fullBit  (c+14,(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q));
	vcdp->fullBit  (c+15,((1U & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				     >> 1U))));
	vcdp->fullBit  (c+16,((1U & ((IData)(vlTOPp->top__DOT__alu_a) 
				     >> 1U))));
	vcdp->fullBit  (c+17,((1U & ((IData)(vlTOPp->top__DOT__alu_b) 
				     >> 1U))));
	vcdp->fullBit  (c+18,(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q));
	vcdp->fullBit  (c+19,((1U & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				     >> 2U))));
	vcdp->fullBit  (c+20,((1U & ((IData)(vlTOPp->top__DOT__alu_a) 
				     >> 2U))));
	vcdp->fullBit  (c+21,((1U & ((IData)(vlTOPp->top__DOT__alu_b) 
				     >> 2U))));
	vcdp->fullBit  (c+22,(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q));
	vcdp->fullBit  (c+23,((1U & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				     >> 3U))));
	vcdp->fullBit  (c+24,((1U & ((IData)(vlTOPp->top__DOT__alu_a) 
				     >> 3U))));
	vcdp->fullBit  (c+25,((1U & ((IData)(vlTOPp->top__DOT__alu_b) 
				     >> 3U))));
	vcdp->fullBit  (c+26,(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q));
	vcdp->fullBit  (c+27,((1U & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				     >> 4U))));
	vcdp->fullBit  (c+28,((1U & ((IData)(vlTOPp->top__DOT__alu_a) 
				     >> 4U))));
	vcdp->fullBit  (c+29,((1U & ((IData)(vlTOPp->top__DOT__alu_b) 
				     >> 4U))));
	vcdp->fullBit  (c+30,(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q));
	vcdp->fullBit  (c+31,((1U & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				     >> 5U))));
	vcdp->fullBit  (c+32,((1U & ((IData)(vlTOPp->top__DOT__alu_a) 
				     >> 5U))));
	vcdp->fullBit  (c+33,((1U & ((IData)(vlTOPp->top__DOT__alu_b) 
				     >> 5U))));
	vcdp->fullBit  (c+34,(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q));
	vcdp->fullBit  (c+35,((1U & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				     >> 6U))));
	vcdp->fullBit  (c+36,((1U & ((IData)(vlTOPp->top__DOT__alu_a) 
				     >> 6U))));
	vcdp->fullBit  (c+37,((1U & ((IData)(vlTOPp->top__DOT__alu_b) 
				     >> 6U))));
	vcdp->fullBit  (c+38,(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q));
	vcdp->fullBit  (c+39,((1U & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				     >> 7U))));
	vcdp->fullBit  (c+40,((1U & ((IData)(vlTOPp->top__DOT__alu_a) 
				     >> 7U))));
	vcdp->fullBit  (c+41,((1U & ((IData)(vlTOPp->top__DOT__alu_b) 
				     >> 7U))));
	vcdp->fullBit  (c+42,(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q));
	vcdp->fullBit  (c+43,(vlTOPp->top__DOT__register_file__BRA__0__KET____DOT____Vcellinp__register_inst__we));
	vcdp->fullBit  (c+44,(vlTOPp->top__DOT__register_file__BRA__1__KET____DOT____Vcellinp__register_inst__we));
	vcdp->fullBit  (c+45,(vlTOPp->top__DOT__register_file__BRA__2__KET____DOT____Vcellinp__register_inst__we));
	vcdp->fullBit  (c+46,(vlTOPp->top__DOT__register_file__BRA__3__KET____DOT____Vcellinp__register_inst__we));
	vcdp->fullBus  (c+47,(vlTOPp->top__DOT__d_in),8);
	vcdp->fullBus  (c+48,(vlTOPp->top__DOT__regout[0]),8);
	vcdp->fullBus  (c+49,(vlTOPp->top__DOT__regout[1]),8);
	vcdp->fullBus  (c+50,(vlTOPp->top__DOT__regout[2]),8);
	vcdp->fullBus  (c+51,(vlTOPp->top__DOT__regout[3]),8);
	vcdp->fullBus  (c+52,(vlTOPp->top__DOT____Vcellinp__amux_inst__i0),8);
	vcdp->fullBus  (c+53,(vlTOPp->top__DOT____Vcellinp__amux_inst__i1),8);
	vcdp->fullBus  (c+54,(vlTOPp->top__DOT____Vcellinp__amux_inst__i2),8);
	vcdp->fullBus  (c+55,(vlTOPp->top__DOT____Vcellinp__amux_inst__i3),8);
	vcdp->fullBus  (c+56,(vlTOPp->top__DOT____Vcellinp__bmux_inst__i0),8);
	vcdp->fullBus  (c+57,(vlTOPp->top__DOT____Vcellinp__bmux_inst__i1),8);
	vcdp->fullBus  (c+58,(vlTOPp->top__DOT____Vcellinp__bmux_inst__i2),8);
	vcdp->fullBus  (c+59,(vlTOPp->top__DOT____Vcellinp__bmux_inst__i3),8);
	vcdp->fullBus  (c+60,(vlTOPp->top__DOT__umbr_in__DOT__do_r),8);
	vcdp->fullBus  (c+61,(vlTOPp->top__DOT__umbr_out__DOT__do_r),8);
	vcdp->fullBus  (c+62,(vlTOPp->top__DOT__umar__DOT__do_r),8);
	vcdp->fullBus  (c+63,(vlTOPp->top__DOT__register_file__BRA__0__KET____DOT__register_inst__DOT__do_r),8);
	vcdp->fullBus  (c+64,(vlTOPp->top__DOT__register_file__BRA__1__KET____DOT__register_inst__DOT__do_r),8);
	vcdp->fullBus  (c+65,(vlTOPp->top__DOT__register_file__BRA__2__KET____DOT__register_inst__DOT__do_r),8);
	vcdp->fullBus  (c+66,(vlTOPp->top__DOT__register_file__BRA__3__KET____DOT__register_inst__DOT__do_r),8);
	vcdp->fullBit  (c+67,(vlTOPp->reset));
	vcdp->fullBus  (c+68,(vlTOPp->reg_addr_we),2);
	vcdp->fullBit  (c+69,(vlTOPp->reg_we));
	vcdp->fullBit  (c+70,(vlTOPp->mar_we));
	vcdp->fullBit  (c+71,(vlTOPp->mbr_out_we));
	vcdp->fullBit  (c+72,(vlTOPp->mbr_in_we));
	vcdp->fullBit  (c+73,(vlTOPp->mem_we));
	vcdp->fullBit  (c+74,(vlTOPp->mbr_alu));
	vcdp->fullBus  (c+75,(vlTOPp->alu_func),2);
	vcdp->fullBit  (c+76,(vlTOPp->alu_comp_b));
	vcdp->fullBit  (c+77,(vlTOPp->alu_ci));
	vcdp->fullBus  (c+78,(vlTOPp->alu_reg_a),2);
	vcdp->fullBus  (c+79,(vlTOPp->alu_reg_b),2);
	vcdp->fullBit  (c+80,(vlTOPp->alu_so));
	vcdp->fullBit  (c+81,(vlTOPp->alu_uo));
	vcdp->fullBit  (c+82,((1U & (((((IData)(vlTOPp->top__DOT__alu_b) 
					^ (IData)(vlTOPp->alu_comp_b)) 
				       ^ (IData)(vlTOPp->top__DOT__alu_a)) 
				      & (IData)(vlTOPp->top__DOT__alu_inst__DOT__cc)) 
				     | (((IData)(vlTOPp->top__DOT__alu_b) 
					 ^ (IData)(vlTOPp->alu_comp_b)) 
					& (IData)(vlTOPp->top__DOT__alu_a))))));
	vcdp->fullBit  (c+83,((1U & ((((((IData)(vlTOPp->top__DOT__alu_b) 
					 >> 1U) ^ (IData)(vlTOPp->alu_comp_b)) 
				       ^ ((IData)(vlTOPp->top__DOT__alu_a) 
					  >> 1U)) & 
				      ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				       >> 1U)) | ((
						   ((IData)(vlTOPp->top__DOT__alu_b) 
						    >> 1U) 
						   ^ (IData)(vlTOPp->alu_comp_b)) 
						  & ((IData)(vlTOPp->top__DOT__alu_a) 
						     >> 1U))))));
	vcdp->fullBit  (c+84,((1U & ((((((IData)(vlTOPp->top__DOT__alu_b) 
					 >> 2U) ^ (IData)(vlTOPp->alu_comp_b)) 
				       ^ ((IData)(vlTOPp->top__DOT__alu_a) 
					  >> 2U)) & 
				      ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				       >> 2U)) | ((
						   ((IData)(vlTOPp->top__DOT__alu_b) 
						    >> 2U) 
						   ^ (IData)(vlTOPp->alu_comp_b)) 
						  & ((IData)(vlTOPp->top__DOT__alu_a) 
						     >> 2U))))));
	vcdp->fullBit  (c+85,((1U & ((((((IData)(vlTOPp->top__DOT__alu_b) 
					 >> 3U) ^ (IData)(vlTOPp->alu_comp_b)) 
				       ^ ((IData)(vlTOPp->top__DOT__alu_a) 
					  >> 3U)) & 
				      ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				       >> 3U)) | ((
						   ((IData)(vlTOPp->top__DOT__alu_b) 
						    >> 3U) 
						   ^ (IData)(vlTOPp->alu_comp_b)) 
						  & ((IData)(vlTOPp->top__DOT__alu_a) 
						     >> 3U))))));
	vcdp->fullBit  (c+86,((1U & ((((((IData)(vlTOPp->top__DOT__alu_b) 
					 >> 4U) ^ (IData)(vlTOPp->alu_comp_b)) 
				       ^ ((IData)(vlTOPp->top__DOT__alu_a) 
					  >> 4U)) & 
				      ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				       >> 4U)) | ((
						   ((IData)(vlTOPp->top__DOT__alu_b) 
						    >> 4U) 
						   ^ (IData)(vlTOPp->alu_comp_b)) 
						  & ((IData)(vlTOPp->top__DOT__alu_a) 
						     >> 4U))))));
	vcdp->fullBit  (c+87,((1U & ((((((IData)(vlTOPp->top__DOT__alu_b) 
					 >> 5U) ^ (IData)(vlTOPp->alu_comp_b)) 
				       ^ ((IData)(vlTOPp->top__DOT__alu_a) 
					  >> 5U)) & 
				      ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				       >> 5U)) | ((
						   ((IData)(vlTOPp->top__DOT__alu_b) 
						    >> 5U) 
						   ^ (IData)(vlTOPp->alu_comp_b)) 
						  & ((IData)(vlTOPp->top__DOT__alu_a) 
						     >> 5U))))));
	vcdp->fullBit  (c+88,((1U & ((((((IData)(vlTOPp->top__DOT__alu_b) 
					 >> 6U) ^ (IData)(vlTOPp->alu_comp_b)) 
				       ^ ((IData)(vlTOPp->top__DOT__alu_a) 
					  >> 6U)) & 
				      ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				       >> 6U)) | ((
						   ((IData)(vlTOPp->top__DOT__alu_b) 
						    >> 6U) 
						   ^ (IData)(vlTOPp->alu_comp_b)) 
						  & ((IData)(vlTOPp->top__DOT__alu_a) 
						     >> 6U))))));
	vcdp->fullBit  (c+89,((1U & ((((((IData)(vlTOPp->top__DOT__alu_b) 
					 >> 7U) ^ (IData)(vlTOPp->alu_comp_b)) 
				       ^ ((IData)(vlTOPp->top__DOT__alu_a) 
					  >> 7U)) & 
				      ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				       >> 7U)) | ((
						   ((IData)(vlTOPp->top__DOT__alu_b) 
						    >> 7U) 
						   ^ (IData)(vlTOPp->alu_comp_b)) 
						  & ((IData)(vlTOPp->top__DOT__alu_a) 
						     >> 7U))))));
	vcdp->fullBus  (c+90,(8U),32);
	vcdp->fullBus  (c+91,(1U),32);
    }
}
