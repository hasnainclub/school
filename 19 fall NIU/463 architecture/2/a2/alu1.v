module alu1
(
	input wire			ci,
	input wire			a,
	input wire			b,
	input wire			comp,
	input wire [1:0]	f,
	output wire 		co,
	output wire 		q
);
	assign co = (((b^comp)^a)&ci)|((b^comp)&a);

	always @(*)
	begin
		case (f)
		2'b00: q = ((b^comp)^a)^ci;	// adder
		2'b01: q = (b^comp)^a;		// a XOR b
		2'b10: q = a&(b^comp);		// a AND b
		2'b11: q = a|(b^comp);		// a OR b
		endcase
	end

endmodule
