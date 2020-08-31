#Hasnain Attarwala, csci 463, z1697740, John Winans, Due Oct 17 2019
##################################   HEADER FOR EASIER ON MY EYES ####################################################################
#alu_ func[1:0] alu_ comp_b alu_ci reg_we mbr_alu mar_we mem_we mbr_out_we mbr_in_ we reg_addr_we[1:0] alu_ reg_a[1:0] alu_ reg_b[1:0]

# in C, we would just do mem[1] = 2; and be done with it. 

#now what happens in assembler is in comments, then i'll write the op codes which match the header on top

#00 0 0 0 0 0 0 0 0 00 00 00
#L r1, 1
# so now r1 = r1+r1+(ci, which is 1) that's what happens 

00 0 1 1 0 0 0 0 0 01 01 01
00 0 1 0 0 0 0 0 0 01 01 01

#l r2, 2
#so now r2 = r1 + r0 +(ci = 1)
00 0 1 1 0 0 0 0 0 10 01 00
00 0 1 0 0 0 0 0 0 10 01 00

#st r1, r2
#in micro means mov r1 to mar,
00 0 0 0 0 1 0 0 0 00 01 00
00 0 0 0 0 0 0 0 0 00 01 00

#in micro means move r2 to mbr out
00 0 0 0 0 0 0 1 0 00 10 00
00 0 0 0 0 0 0 0 0 00 10 00

#write to  memory, save the above two changes
00 0 0 0 0 0 1 0 0 00 00 00
00 0 0 0 0 0 0 0 0 00 00 00
