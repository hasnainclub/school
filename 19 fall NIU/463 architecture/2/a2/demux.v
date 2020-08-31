module demux
(
	input wire [1:0]	a,
	input wire			i,
	output wire [N-1:0]	o0,
	output wire [N-1:0]	o1,
	output wire [N-1:0]	o2,
	output wire [N-1:0]	o3
);
	parameter N=1;

	always @(*)
	begin
		o0 = 0;
		o1 = 0;
		o2 = 0;
		o3 = 0;
		case(a)
		0: o0 = i;
		1: o1 = i;
		2: o2 = i;
		3: o3 = i;
		endcase
	end

endmodule
