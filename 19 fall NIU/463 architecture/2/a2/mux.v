module mux
(
	input wire [N-1:0]	i0,
	input wire [N-1:0]	i1,
	input wire [N-1:0]	i2,
	input wire [N-1:0]	i3,
	input wire [1:0]	a,
	output wire [N-1:0]	o
);
	parameter N=8;

	always
	begin
		case(a)
		0: o = i0;
		1: o = i1;
		2: o = i2;
		3: o = i3;
		endcase
	end

endmodule
