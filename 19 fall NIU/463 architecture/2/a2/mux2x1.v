module mux2x1
(
	input wire [N-1:0]	i0,
	input wire [N-1:0]	i1,
	input wire 			a,
	output wire [N-1:0]	o
);
	parameter N=8;

	always
	begin
		case(a)
		0: o = i0;
		1: o = i1;
		endcase
	end

endmodule
