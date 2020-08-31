module memory
(
	input wire [N-1:0]	din,
	input wire [N-1:0]	ain,
	input wire			we,
	output wire [N-1:0]	dout
);
	parameter N=8;
	reg [N-1:0] do_r [255:0];

	assign dout = do_r[ain];

	always @(negedge we)
	begin
		do_r[ain] <= din;
	end

endmodule
