# alu_func[1:0] alu_comp_b alu_ci reg_we mbr_alu mar_we mem_we mbr_out_we mbr_in_we reg_addr_we[1:0] alu_reg_a[1:0] alu_reg_b[1:0]

# opcodes                    # micoocode              # Assembly     # C code

                             # r1 is 0                # ldi r1 1     # mem[1]=2
00 0 1 1 0 0 0 0 0 01 01 01  # r1 = r1 + r1 + (ci=1)
00 0 1 0 0 0 0 0 0 01 01 01

                             # r1 is 1                # ldi r2 2
00 0 1 1 0 0 0 0 0 10 01 00  # r2 = r1 + r0 + (ci=1)
00 0 1 0 0 0 0 0 0 10 01 00

00 0 0 0 0 1 0 0 0 00 01 00  # mov r1 to mar          # st r1 r2
00 0 0 0 0 0 0 0 0 00 01 00
00 0 0 0 0 0 0 1 0 00 10 00  # mov r2 to mbr_out
00 0 0 0 0 0 0 0 0 00 10 00
00 0 0 0 0 0 1 0 0 00 00 00  # write mem
00 0 0 0 0 0 0 0 0 00 00 00
