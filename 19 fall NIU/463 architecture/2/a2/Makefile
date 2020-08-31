all:
	verilator -Wall --cc --trace top.v --exe sim_main.cpp
	cd obj_dir
	make -j -C obj_dir -f Vtop.mk Vtop

run: all
	./obj_dir/Vtop

clean:
	rm -rf obj_dir *.pdf *.vcd

world: clean all
