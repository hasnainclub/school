#Hasnain Attarwala
#z1697740
#Nov 12th 2019

# All fields are in hex format
# 
# address
# uc_addr_mux[2]    next insn addr = uc_next_addr, flags, IR opcode
# uc_alu_func[2]    0 = add, 1 = xor, 2 = and, 3 = or
# uc_alu_comp_b     1 = compliment b
# uc_alu_ci         1 = carry in
# uc_alu_flags_clk  1 = clock the flag latch
# uc_mar_we         1 = clock a write into MAR
# uc_mem_we         1 = clock a write into the RAM
# uc_mbr_out_we     1 = clock a write into the MBR_out latch
# uc_mbr_in_we      1 = clock a write into the MBR_in latch
# uc_reg_we_clk     1 = clock a write intot he register file
# uc_reg_addr_ir    0 = use reg addr from uc, 1 = use the a field address from IR 
# uc_reg_addr[3]    the uc destination register address if writing 
# uc_alu_reg_a_ir   0 = set alu_reg_a mux using the uc address, 1 = use the a field from the IR
# uc_alu_reg_a[3]   uc address for alu_reg_a
# uc_alu_reg_b_ir   0 = set alu_reg_b mux using the uc address, 1 = use the b field from the IR
# uc_alu_reg_b[3]   uc address for alu_reg_b
# uc_next_addr[16]  uc next instruction

# read a byte from memory and put it into the IR

0000 0  0 0 0  0 0 0 0 0  0 0 0  0 7 0 7 0001   # do nothing

#############################
# fetch an insn from PC address 
0001 0  0 0 0  0 1 0 0 0  0 0 5  0 4 0 7 0002   # put the PC reg value into the MAR
0002 0  0 0 0  0 0 0 0 1  0 0 5  0 4 0 7 0003   # falling edge on uc_mar_we, rising edge on uc_mbr_in_we
0003 0  0 0 0  0 0 0 0 0  0 0 5  0 4 0 7 0004   # falling edge on uc_mbr_in_we
0004 0  0 0 0  0 0 0 0 0  1 0 5  0 7 0 4 0005   # rising edge on uc_reg_we_clk w/ir as target
0005 0  0 0 0  0 0 0 0 0  0 0 5  0 7 0 4 0006   # falling edge on uc_reg_we_clk

# add 1 to PC
0006 0  0 0 1  0 0 0 0 0  1 0 4  0 4 0 7 0007   # add 1 to PC & rising edge on uc_reg_we_clk
0007 0  0 0 1  0 0 0 0 0  0 0 4  0 4 0 7 0010   # falling edge on uc_reg_we_clk

#############################
# instruction decode logic
0010 2  0 0 0  0 0 0 0 0  0 0 0  0 7 0 7 00f0   # branch based on the opcode in the IR!

00f0 0  0 0 0  0 0 0 0 0  0 0 0  0 7 0 7 1000   # opcode 0 NOP
00f1 0  0 0 0  0 0 0 0 0  0 0 0  0 7 0 7 1100   # opcode 1 LD Ra,imm
00f2 0  0 0 0  0 0 0 0 0  0 0 0  0 7 0 7 1200   # opcode 2 ST Ra,imm
00f3 0  0 0 0  0 0 0 0 0  0 0 0  0 7 0 7 1300   # opcode 3 ADD Ra,Rb
00f4 0  0 0 0  0 0 0 0 0  0 0 0  0 7 0 7 1400   # opcode 4 SUB Ra,Rb
00f5 0  0 0 0  0 0 0 0 0  0 0 0  0 7 0 7 1500   # opcode 5 XOR Ra,Rb
00f6 0  0 0 0  0 0 0 0 0  0 0 0  0 7 0 7 1600   # opcode 6 AND Ra,Rb
00f7 0  0 0 0  0 0 0 0 0  0 0 0  0 7 0 7 1700   # opcode 7 OR Ra,Rb
00f8 0  0 0 0  0 0 0 0 0  0 0 0  0 7 0 7 1800   # opcode 8 MOV Ra,Rb
00f9 0  0 0 0  0 0 0 0 0  0 0 0  0 7 0 7 1900   # opcode 9 LD Ra,mem(imm)
00fa 0  0 0 0  0 0 0 0 0  0 0 0  0 7 0 7 1a00   # opcode a B imm (absolute)
00fb 0  0 0 0  0 0 0 0 0  0 0 0  0 7 0 7 1b00   # opcode b BR PC+imm
00fc 0  0 0 0  0 0 0 0 0  0 0 0  0 7 0 7 1c00   # opcode c BZ PC+imm
00fd 0  0 0 0  0 0 0 0 0  0 0 0  0 7 0 7 1d00   # opcode d BNZ PC+imm
00fe 0  0 0 0  0 0 0 0 0  0 0 0  0 7 0 7 ffff   # opcode e
00ff 0  0 0 0  0 0 0 0 0  0 0 0  0 7 0 7 ffff   # opcode f HALT

#############################
# NOP no operation
1000 0  0 0 0  0 0 0 0 0  0 0 0  0 7 0 7 0001   # go to insn fetch

#2.2##########################
# LDI Ra,imm
# fetch the byte in memory that the PC is pointing to now
1100 0  0 0 0  0 1 0 0 0  0 0 7  0 4 0 7 1101   # MAR <- PC
1101 0  0 0 0  0 0 0 0 0  0 0 7  0 4 0 7 1102   #
1102 0  0 0 0  0 0 0 0 1  0 0 7  0 7 0 7 1103   # MBR_IN <- d_in
1103 0  0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1104   #
1104 0  0 0 0  0 0 0 0 0  1 1 7  0 7 0 4 1105   # Ra <- MBR_IN
1105 0  0 0 0  0 0 0 0 0  0 1 7  0 7 0 4 1106   #
1106 0  0 0 1  0 0 0 0 0  1 0 4  0 4 0 7 1107   # PC <- PC+1
1107 0  0 0 1  0 0 0 0 0  0 0 4  0 4 0 7 1108   # 

1108 0  0 0 0  0 0 0 0 0  0 0 0  0 7 0 7 0001   # go to insn fetch


#2.3#########################
# ST Ra,imm
# Store the contents of register Ra into memory at the absolute address that appears in the instruction stream
# immediately after the instruction opcode.
1200 0  0 0 0  0 1 0 0 0  0 0 7  0 4 0 7 1201   # MAR <- PC
1201 0  0 0 0  0 0 0 0 0  0 0 7  0 4 0 7 1202   #
1202 0  0 0 0  0 0 0 0 1  0 0 7  0 4 0 7 1203   # MBR IN ← mem
1203 0  0 0 0  0 0 0 0 0  0 0 7  0 4 0 7 1204   # 
1204 0  0 0 0  0 1 0 0 0  0 0 7  0 7 0 4 1205   # MAR ← MBR IN
1205 0  0 0 0  0 0 0 0 0  0 0 7  0 7 0 4 1206   #
1206 0  0 0 0  0 0 0 1 0  0 0 7  1 7 0 7 1207   # MBR OUT ← Ra
1207 0  0 0 0  0 0 0 0 0  0 0 7  1 7 0 7 1208   #
1208 0  0 0 0  0 0 1 0 0  0 0 7  0 7 0 7 1209   # mem(MAR) ← MBR OUT
1209 0  0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1210   #
1210 0  0 0 1  0 0 0 0 0  1 0 4  0 4 0 7 1211   # PC <- PC+1
1211 0  0 0 1  0 0 0 0 0  0 0 4  0 4 0 7 1212   # 

1212 0  0 0 0  0 0 0 0 0  0 0 0  0 7 0 7 0001   # go to insn fetch

#2.4#########################
# Add the contents of Rb to Ra.


1300 0  0 0 0  1 0 0 0 0  0 1 7  1 7 1 7  1301  # FLAGS ← ALU status
1301 0  0 0 0  0 0 0 0 0  0 1 7  1 7 1 7  1302
1302 0  0 0 0  0 0 0 0 0  1 1 7  1 7 1 7  1303  # Ra ← Ra + Rb
1303 0  0 0 0  0 0 0 0 0  0 1 7  1 7 1 7  1304 

1304 0  0 0 0  0 0 0 0 0  0 0 0  0 7 0 7  0001   # go to insn fetch

#2.5#########################
# Sub the contents of Rb from Ra.
1400 0  0 1 1  1 0 0 0 0  0 1 7  1 7 1 7  1401   # FLAGS ← ALU status
1401 0  0 1 1  0 0 0 0 0  0 1 7  1 7 1 7  1402  
#weird      1 should be below but different answer, mistake in prog?
1402 0  0 1 1  0 0 0 0 0  1 1 7  1 7 1 7  1403   # Ra ← Ra - Rb
1403 0  0 1 1  0 0 0 0 0  0 1 7  1 7 1 7  1404

1404 0  0 0 0  0 0 0 0 0  0 0 0  0 7 0 7  0001   # go to insn fetch


#2.6#########################
#Exclusive–or the contents of Ra with Rb.
1500 0  1 0 0  1 0 0 0 0  0 1 7  1 7 1 7  1501   # FLAGS ← ALU status
1501 0  1 0 0  0 0 0 0 0  0 1 7  1 7 1 7  1502   # 
1502 0  1 0 0  0 0 0 0 0  1 1 7  1 7 1 7  1503   # Ra ← Ra xor Rb
1503 0  1 0 0  0 0 0 0 0  0 1 7  1 7 1 7  1504   

1504 0  0 0 0  0 0 0 0 0  0 0 0  0 7 0 7  0001   # go to insn fetch

#2.7#########################
# Add the contents of Ra with Rb
1600 0  2 0 0  1 0 0 0 0  0 1 7  1 7 1 7  1601   # FLAGS ← ALU status
1601 0  2 0 0  0 0 0 0 0  0 1 7  1 7 1 7  1602   #
1602 0  2 0 0  0 0 0 0 0  1 1 7  1 7 1 7  1603   # Ra ← Ra and Rb
1603 0  2 0 0  0 0 0 0 0  0 1 7  1 7 1 7  1604

1604 0  0 0 0  0 0 0 0 0  0 0 0  0 7 0 7  0001   # go to insn fetch


#2.8#########################
# OR the contents of Ra with Rb.
1700 0  3 0 0  1 0 0 0 0  0 1 7  1 7 1 7  1701   # FLAGS ← ALU status
1701 0  3 0 0  0 0 0 0 0  0 1 7  1 7 1 7  1702   #
1702 0  3 0 0  0 0 0 0 0  1 1 7  1 7 1 7  1703   # Ra ← Ra and Rb
1703 0  3 0 0  0 0 0 0 0  0 1 7  1 7 1 7  1704

1704 0  0 0 0  0 0 0 0 0  0 0 0  0 7 0 7  0001   # go to insn fetch


#2.9#########################
# MOV Ra,Rb
# Copy the contents of Rb into Ra.

1800 0  0 0 0  0 0 0 0 0  1 1 7  0 7 1 7  1801   # Ra ← Rb
1801 0  0 0 0  0 0 0 0 0  0 1 7  0 7 1 7  1802

1802 0  0 0 0  0 0 0 0 0  0 0 0  0 7 0 7  0001   # go to insn fetch


#2.10#########################
# LD Ra,mem(imm)
# Load the contents of a memory byte from the address that appears in the instruction stream immediately
# after the opcode into register Ra 
1900 0  0 0 0  0 1 0 0 0  0 0 7  0 4 0 7 1901   # MAR <- PC
1901 0  0 0 0  0 0 0 0 0  0 0 7  0 4 0 7 1902   #
1902 0  0 0 0  0 0 0 0 1  0 0 7  0 4 0 7 1903   # MBR IN ← mem
1903 0  0 0 0  0 0 0 0 0  0 0 7  0 4 0 7 1904   #
1904 0  0 0 0  0 1 0 0 0  0 0 7  0 7 0 4 1905   # MAR ← MBR IN
1905 0  0 0 0  0 0 0 0 0  0 0 7  0 7 0 4 1906   #
1906 0  0 0 0  0 0 0 0 1  0 0 7  0 4 0 7 1907   # MBR IN ← mem
1907 0  0 0 0  0 0 0 0 0  0 0 7  0 4 0 7 1908   #
1908 0  0 0 0  0 0 0 0 0  1 1 7  0 7 0 4 1909   # Ra <- MBR_IN
1909 0  0 0 0  0 0 0 0 0  0 1 7  0 7 0 4 1910   #
1910 0  0 0 1  0 0 0 0 0  1 0 4  0 4 0 7 1911   # PC <- PC+1
1911 0  0 0 1  0 0 0 0 0  0 0 4  0 4 0 7 1912   #

1912 0  0 0 0  0 0 0 0 0  0 0 0  0 7 0 7  0001   # go to insn fetch


#2.11#########################
#  B imm
# Branch to the absolute address in the byte that appears in the instruction stream immediately after the
# instruction opcode. (Note that this is similar to the LDI Ra,imm instruction except that it will store the
# fetched address byte into the into the PC register (rather than Ra.)

1a00 0  0 0 0  0 1 0 0 0  0 0 7  0 4 0 7 1a01   # MAR <- PC
1a01 0  0 0 0  0 0 0 0 0  0 0 7  0 4 0 7 1a02   #
1a02 0  0 0 0  0 0 0 0 1  0 0 7  0 4 0 7 1a03   # MBR IN ← mem
1a03 0  0 0 0  0 0 0 0 0  0 0 7  0 4 0 7 1a04   #
1a04 0  0 0 0  0 0 0 0 0  1 0 4  0 7 0 4 1a05   # PC ← MBR IN
1a05 0  0 0 0  0 0 0 0 0  1 0 4  0 7 0 4 1a06 

1a06 0  0 0 0  0 0 0 0 0  0 0 0  0 7 0 7  0001   # go to insn fetch


#2.11.5#############################
# BR
# Branche to relative adress
1b00 0  0 0 0  0 1 0 0 0  0 0 7  0 4 0 7 1b01   # MAR <- PC
1b01 0  0 0 0  0 0 0 0 0  0 0 7  0 4 0 7 1b02   #
1b02 0  0 0 1  0 0 0 0 0  1 0 4  0 4 0 7 1b03   # PC <- PC+1
1b03 0  0 0 1  0 0 0 0 0  0 0 4  0 4 0 7 1b04   #
1b04 0  0 0 0  0 0 0 0 1  0 0 7  0 4 0 7 1b05   # MBR IN ← mem
1b05 0  0 0 0  0 0 0 0 0  0 0 7  0 4 0 7 1b06   #
1b06 0  0 0 0  0 0 0 0 0  1 0 4  0 4 0 4 1b07   #PC ← PC + MBR IN
1b07 0  0 0 0  0 0 0 0 0  0 0 4  0 4 0 4 1b08

1b08 0  0 0 0  0 0 0 0 0  0 0 0  0 7 0 7  0001   # go to insn fetch


#2.12########################
# If the Z flag is set then branch to the relative address that appears in the instruction stream immediately
# after the opcode.
1c00 1 0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1c1f
#in the diag, 3rd mux..  One with zero flag, so see binary to check if 3rd value is 0 or 1
1c10 0 0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1c30 #zero flag not set 
1c11 0 0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1c30 #zero flag not set
1c12 0 0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1c20 #zero flag was set 
1c13 0 0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1c20 #set
1c14 0 0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1c30 #not
1c15 0 0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1c30 #n
1c16 0 0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1c20 #s
1c17 0 0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1c20 #s
1c18 0 0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1c30 #n
1c19 0 0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1c30 #n
1c1a 0 0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1c20 #s
1c1b 0 0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1c20 #s
1c1c 0 0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1c30 #n
1c1d 0 0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1c30 #n
1c1e 0 0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1c20 #s
1c1f 0 0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1c20 #s

1c20 0  0 0 0  0 1 0 0 0  0 0 7  0 4 0 7 1c21   # MAR <- PC
1c21 0  0 0 0  0 0 0 0 0  0 0 7  0 4 0 7 1c22   # 
1c22 0  0 0 1  0 0 0 0 0  1 0 4  0 4 0 7 1c23   # PC <- PC+1
1c23 0  0 0 1  0 0 0 0 0  0 0 4  0 4 0 7 1c24   #
1c24 0  0 0 0  0 0 0 0 1  0 0 7  0 4 0 7 1c25   # MBR IN ← mem
1c25 0  0 0 0  0 0 0 0 0  0 0 7  0 4 0 7 1c26   #
1c26 0  0 0 0  0 0 0 0 0  1 0 4  0 4 0 4 1c27   #PC ← PC + MBR IN
1c27 0  0 0 0  0 0 0 0 0  0 0 4  0 4 0 4 1c28
 
1c28 0  0 0 0  0 0 0 0 0  0 0 0  0 7 0 7 0001   # go to insn fetch

1c30 0  0 0 1  0 0 0 0 0  1 0 4  0 4 0 7 1c31   # PC <- PC+1
1c31 0  0 0 1  0 0 0 0 0  0 0 4  0 4 0 7 1c32   #for else case

1c32 0  0 0 0  0 0 0 0 0  0 0 0  0 7 0 7 0001   # go to insn fetch


#2.13 BNZ PC+imm  ############################################3
#opp of guy above, change 20's to 30's vice versa
1d00 1 0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1d1f
#in the diag, 3rd mux..  One with zero flag, so see binary to check if 3rd value is 0 or 1
1d10 0 0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1d20 #zero flag not set
1d11 0 0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1d20 #zero flag not set
1d12 0 0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1d30 #zero flag was set
1d13 0 0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1d30 #set
1d14 0 0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1d20 #not
1d15 0 0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1d20 #n
1d16 0 0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1d30 #s
1d17 0 0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1d30 #s
1d18 0 0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1d20 #n
1d19 0 0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1d20 #n
1d1a 0 0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1d30 #s
1d1b 0 0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1d30 #s
1d1c 0 0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1d20 #n
1d1d 0 0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1d20 #n
1d1e 0 0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1d30 #s
1d1f 0 0 0 0  0 0 0 0 0  0 0 7  0 7 0 7 1d30 #s

1d20 0  0 0 0  0 1 0 0 0  0 0 7  0 4 0 7 1d21   # MAR <- PC
1d21 0  0 0 0  0 0 0 0 0  0 0 7  0 4 0 7 1d22   #
1d22 0  0 0 1  0 0 0 0 0  1 0 4  0 4 0 7 1d23   # PC <- PC+1
1d23 0  0 0 1  0 0 0 0 0  0 0 4  0 4 0 7 1d24   #
1d24 0  0 0 0  0 0 0 0 1  0 0 7  0 4 0 7 1d25   # MBR IN ← mem
1d25 0  0 0 0  0 0 0 0 0  0 0 7  0 4 0 7 1d26   #
1d26 0  0 0 0  0 0 0 0 0  1 0 4  0 4 0 4 1d27   #PC ← PC + MBR IN
1d27 0  0 0 0  0 0 0 0 0  0 0 4  0 4 0 4 1d28

1d28 0  0 0 0  0 0 0 0 0  0 0 0  0 7 0 7 0001   # go to insn fetch

1d30 0  0 0 1  0 0 0 0 0  1 0 4  0 4 0 7 1d31   # PC <- PC+1
1d31 0  0 0 1  0 0 0 0 0  0 0 4  0 4 0 7 1d32   #for else case

1d32 0  0 0 0  0 0 0 0 0  0 0 0  0 7 0 7 0001   # go to insn fetch
