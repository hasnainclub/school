# Hasnain Attarwala
# csci463 NIU, Due Oct 17th 2019
# John Winans prof
#DIAGRAM OF SCHEMANTIC ORDER!
# alu_func[1:0] alu_comp_b alu_ci reg_we mbr_alu mar_we mem_we mbr_out_we mbr_in_we reg_addr_we[1:0] alu_reg_a[1:0] alu_reg_b[1:0]

### C code -- to understand whats going on
## Assembly -- actually wahts happening
# micoocode -- what we intend to actually do
# (uncommented is opcodes) -- 0's and 1's baby!  

## l 0, r1
# mar load into memory adress, in this case0


# read from memory into mbr_in 
00 0 0 0 0 0 0 0 1 00 00 00
00 0 0 0 0 0 0 0 0 00 00 00
# mov mbr_in to r1
00 0 0 1 1 0 0 0 0 01 00 00
00 0 0 0 1 0 0 0 0 01 00 00

## l 1, r2
# mar load into memory adress, in this case1
00 0 1 0 0 1 0 0 0 00 00 00
00 0 1 0 0 0 0 0 0 00 00 00
# read from memory into mbr_in
00 0 0 0 0 0 0 0 1 00 00 00
00 0 0 0 0 0 0 0 0 00 00 00
# mov mbr_in to r1
00 0 0 1 1 0 0 0 0 10 00 00
00 0 0 0 1 0 0 0 0 10 00 00


### mem[0x80]=0x41
# r1 is 80
# r2 is 41
## st r1 r2
# mov r1 mar
00 0 0 0 0 1 0 0 0 00 01 00
00 0 0 0 0 0 0 0 0 00 01 00
# mov r2 mbr_out
00 0 0 0 0 0 0 1 0 00 10 00
00 0 0 0 0 0 0 0 0 00 10 00
# write mem 
00 0 0 0 0 0 1 0 0 00 00 00
00 0 0 0 0 0 0 0 0 00 00 00

### mem[0x81]=0x42
## add r1 1
# r1 = r1 + r0 + 1
00 0 1 1 0 0 0 0 0 01 01 00
00 0 1 0 0 0 0 0 0 01 01 00
## add r2 1
# r2 = r2 + r0 + 1
00 0 1 1 0 0 0 0 0 10 10 00
00 0 1 0 0 0 0 0 0 10 10 00
## st r1 r2
# mov r1 mar
00 0 0 0 0 1 0 0 0 00 01 00
00 0 0 0 0 0 0 0 0 00 01 00
# mov r2 mbr_out
00 0 0 0 0 0 0 1 0 00 10 00
00 0 0 0 0 0 0 0 0 00 10 00
# write mem 
00 0 0 0 0 0 1 0 0 00 00 00
00 0 0 0 0 0 0 0 0 00 00 00


### mem[0x82]=0x43
## add r1 1
# r1 = r1 + r0 + 1
00 0 1 1 0 0 0 0 0 01 01 00
00 0 1 0 0 0 0 0 0 01 01 00
## add r2 1
# r2 = r2 + r0 + 1
00 0 1 1 0 0 0 0 0 10 10 00
00 0 1 0 0 0 0 0 0 10 10 00
## st r1 r2
# mov r1 mar
00 0 0 0 0 1 0 0 0 00 01 00
00 0 0 0 0 0 0 0 0 00 01 00
# mov r2 mbr_out
00 0 0 0 0 0 0 1 0 00 10 00
00 0 0 0 0 0 0 0 0 00 10 00
# write mem 
00 0 0 0 0 0 1 0 0 00 00 00
00 0 0 0 0 0 0 0 0 00 00 00


### mem[0x83]=0x44
## add r1 1
# r1 = r1 + r0 + 1
00 0 1 1 0 0 0 0 0 01 01 00
00 0 1 0 0 0 0 0 0 01 01 00
## add r2 1
# r2 = r2 + r0 + 1
00 0 1 1 0 0 0 0 0 10 10 00
00 0 1 0 0 0 0 0 0 10 10 00
## st r1 r2
# mov r1 mar
00 0 0 0 0 1 0 0 0 00 01 00
00 0 0 0 0 0 0 0 0 00 01 00
# mov r2 mbr_out
00 0 0 0 0 0 0 1 0 00 10 00
00 0 0 0 0 0 0 0 0 00 10 00
# write mem 
00 0 0 0 0 0 1 0 0 00 00 00
00 0 0 0 0 0 0 0 0 00 00 00


### mem[0x84]=0x45
## add r1 1
# r1 = r1 + r0 + 1
00 0 1 1 0 0 0 0 0 01 01 00
00 0 1 0 0 0 0 0 0 01 01 00
## add r2 1
# r2 = r2 + r0 + 1
00 0 1 1 0 0 0 0 0 10 10 00
00 0 1 0 0 0 0 0 0 10 10 00
## st r1 r2
# mov r1 mar
00 0 0 0 0 1 0 0 0 00 01 00
00 0 0 0 0 0 0 0 0 00 01 00
# mov r2 mbr_out
00 0 0 0 0 0 0 1 0 00 10 00
00 0 0 0 0 0 0 0 0 00 10 00
# write mem 
00 0 0 0 0 0 1 0 0 00 00 00
00 0 0 0 0 0 0 0 0 00 00 00


### mem[0x85]=0x46
## add r1 1
# r1 = r1 + r0 + 1
00 0 1 1 0 0 0 0 0 01 01 00
00 0 1 0 0 0 0 0 0 01 01 00
## add r2 1
# r2 = r2 + r0 + 1
00 0 1 1 0 0 0 0 0 10 10 00
00 0 1 0 0 0 0 0 0 10 10 00
## st r1 r2
# mov r1 mar
00 0 0 0 0 1 0 0 0 00 01 00
00 0 0 0 0 0 0 0 0 00 01 00
# mov r2 mbr_out
00 0 0 0 0 0 0 1 0 00 10 00
00 0 0 0 0 0 0 0 0 00 10 00
# write mem 
00 0 0 0 0 0 1 0 0 00 00 00
00 0 0 0 0 0 0 0 0 00 00 00


### mem[0x86]=0x47
## add r1 1
# r1 = r1 + r0 + 1
00 0 1 1 0 0 0 0 0 01 01 00
00 0 1 0 0 0 0 0 0 01 01 00
## add r2 1
# r2 = r2 + r0 + 1
00 0 1 1 0 0 0 0 0 10 10 00
00 0 1 0 0 0 0 0 0 10 10 00
## st r1 r2
# mov r1 mar
00 0 0 0 0 1 0 0 0 00 01 00
00 0 0 0 0 0 0 0 0 00 01 00
# mov r2 mbr_out
00 0 0 0 0 0 0 1 0 00 10 00
00 0 0 0 0 0 0 0 0 00 10 00
# write mem 
00 0 0 0 0 0 1 0 0 00 00 00
00 0 0 0 0 0 0 0 0 00 00 00


### mem[0x87]=0x48
## add r1 1
# r1 = r1 + r0 + 1
00 0 1 1 0 0 0 0 0 01 01 00
00 0 1 0 0 0 0 0 0 01 01 00
## add r2 1
# r2 = r2 + r0 + 1
00 0 1 1 0 0 0 0 0 10 10 00
00 0 1 0 0 0 0 0 0 10 10 00
## st r1 r2
# mov r1 mar
00 0 0 0 0 1 0 0 0 00 01 00
00 0 0 0 0 0 0 0 0 00 01 00
# mov r2 mbr_out
00 0 0 0 0 0 0 1 0 00 10 00
00 0 0 0 0 0 0 0 0 00 10 00
# write mem 
00 0 0 0 0 0 1 0 0 00 00 00
00 0 0 0 0 0 0 0 0 00 00 00

