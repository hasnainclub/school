module register
(
	input wire [N-1:0]	din,
	input wire			we,
	input wire			reset,
	output wire [N-1:0]	dout
);
	parameter N=8;
	reg [N-1:0] do_r;

	assign dout = do_r;

	always @(posedge reset, negedge we)
	begin
		if(reset)
			do_r <= 0;
		else
			do_r <= din;
	end

endmodule
