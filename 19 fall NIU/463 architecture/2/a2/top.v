module top
(
	input				reset,			// reset registers to 0 on rising edge
	input [1:0]			reg_addr_we,	// register address to write (on falling edge of reg_we)
	input				reg_we,			// write enable line for the register file
	input				mar_we,			// the write-enable line for the MAR
	input				mbr_out_we,		// the write-enable line for MBR_out
	input				mbr_in_we,		// the write-enable line for MBR_in
	input				mem_we,			// the write-enable line for the memory
	input				mbr_alu,		// select line for MBR/ALU mux to register input bus
	input [1:0]			alu_func,		// ALU function select
	input				alu_comp_b,		// ALU compliment b control
	input				alu_ci,			// ALU LSB carry-in
	input [1:0]			alu_reg_a,		// register address for ALU bus a
	input [1:0]			alu_reg_b,		// register address for ALU bus b
	output				alu_so,			// ALU signed overflow status
	output				alu_uo			// ALU unsigned overflow status
);
	parameter N=8;

	wire [N-1:0]	regout [3:0];		// register output busses
	wire [3:0]		regwe;				// register write-enable lines

	wire [N-1:0] alu_a;					// ALU input bus A
	wire [N-1:0] alu_b;					// ALU input bus B
	wire [N-1:0] alu_q;					// ALU output bus
	wire [N-1:0] mbr_in;				// MBR input bus
	wire [N-1:0] reg_in;				// register input bus

	wire [N-1:0] d_out;
	wire [N-1:0] d_in;
	wire [N-1:0] addr_out;

	generate
		genvar i;
		for (i=0; i<4; ++i)
		begin : register_file
			register register_inst(.din(reg_in), .we(regwe[i]), .reset(reset), .dout(regout[i]));
		end
	endgenerate

	mux amux_inst(.i0(regout[0]), .i1(regout[1]), .i2(regout[2]), .i3(regout[3]), .a(alu_reg_a), .o(alu_a));
	mux bmux_inst(.i0(regout[0]), .i1(regout[1]), .i2(regout[2]), .i3(regout[3]), .a(alu_reg_b), .o(alu_b));

	demux demux_inst(.o0(regwe[0]), .o1(regwe[1]), .o2(regwe[2]), .o3(regwe[3]), .a(reg_addr_we), .i(reg_we));

	alu alu_inst(.f(alu_func), .comp(alu_comp_b), .ci(alu_ci), .a(alu_a), .b(alu_b), .uo(alu_uo), .so(alu_so), .q(alu_q));
	mux2x1 reg_mux(.i0(alu_q), .i1(mbr_in), .a(mbr_alu), .o(reg_in));

	register umar(.din(alu_q), .we(mar_we), .reset(reset), .dout(addr_out));
	register umbr_out(.din(alu_q), .we(mbr_out_we), .reset(reset), .dout(d_out));
	register umbr_in(.din(d_in), .we(mbr_in_we), .reset(reset), .dout(mbr_in));

	memory umem(.ain(addr_out), .we(mem_we), .din(d_out), .dout(d_in));

endmodule
