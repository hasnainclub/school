module alu
(
	input wire			ci,
	input wire [N-1:0]	a,
	input wire [N-1:0]	b,
	input wire			comp,
	input wire [1:0]	f,
	output wire 		uo,
	output wire 		so,
	output wire [N-1:0]	q
);
	parameter N=8;

	/* verilator lint_off UNOPTFLAT */
	wire[N:0] cc;
	/* verilator lint_on UNOPTFLAT */
	assign cc[0] = ci;
	assign uo = cc[N]^(comp&ci& ~f[0] & ~f[1]);
	assign so = cc[N]^cc[N-1];

	genvar i;
	for (i=0; i<N; i=i+1)
	begin
		alu1 a_inst(.ci(cc[i]), .a(a[i]), .b(b[i]), .comp(comp), .f(f), .co(cc[i+1]), .q(q[i]));
	end

endmodule
