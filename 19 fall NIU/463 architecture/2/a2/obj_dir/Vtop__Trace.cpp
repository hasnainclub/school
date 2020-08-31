// Verilated -*- C++ -*-
// DESCRIPTION: Verilator output: Tracing implementation internals
#include "verilated_vcd_c.h"
#include "Vtop__Syms.h"


//======================

void Vtop::traceChg(VerilatedVcd* vcdp, void* userthis, uint32_t code) {
    // Callback from vcd->dump()
    Vtop* t=(Vtop*)userthis;
    Vtop__Syms* __restrict vlSymsp = t->__VlSymsp; // Setup global symbol table
    if (vlSymsp->getClearActivity()) {
	t->traceChgThis (vlSymsp, vcdp, code);
    }
}

//======================


void Vtop::traceChgThis(Vtop__Syms* __restrict vlSymsp, VerilatedVcd* vcdp, uint32_t code) {
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    int c=code;
    if (0 && vcdp && c) {}  // Prevent unused
    // Body
    {
	if (VL_UNLIKELY((1U & (vlTOPp->__Vm_traceActivity 
			       | (vlTOPp->__Vm_traceActivity 
				  >> 2U))))) {
	    vlTOPp->traceChgThis__2(vlSymsp, vcdp, code);
	}
	if (VL_UNLIKELY((1U & (vlTOPp->__Vm_traceActivity 
			       | (vlTOPp->__Vm_traceActivity 
				  >> 5U))))) {
	    vlTOPp->traceChgThis__3(vlSymsp, vcdp, code);
	}
	if (VL_UNLIKELY((1U & ((((vlTOPp->__Vm_traceActivity 
				  | (vlTOPp->__Vm_traceActivity 
				     >> 6U)) | (vlTOPp->__Vm_traceActivity 
						>> 7U)) 
				| (vlTOPp->__Vm_traceActivity 
				   >> 8U)) | (vlTOPp->__Vm_traceActivity 
					      >> 9U))))) {
	    vlTOPp->traceChgThis__4(vlSymsp, vcdp, code);
	}
	if (VL_UNLIKELY((1U & (vlTOPp->__Vm_traceActivity 
			       | (vlTOPp->__Vm_traceActivity 
				  >> 0xaU))))) {
	    vlTOPp->traceChgThis__5(vlSymsp, vcdp, code);
	}
	if (VL_UNLIKELY((2U & vlTOPp->__Vm_traceActivity))) {
	    vlTOPp->traceChgThis__6(vlSymsp, vcdp, code);
	}
	if (VL_UNLIKELY((8U & vlTOPp->__Vm_traceActivity))) {
	    vlTOPp->traceChgThis__7(vlSymsp, vcdp, code);
	}
	if (VL_UNLIKELY((0x10U & vlTOPp->__Vm_traceActivity))) {
	    vlTOPp->traceChgThis__8(vlSymsp, vcdp, code);
	}
	if (VL_UNLIKELY((0x40U & vlTOPp->__Vm_traceActivity))) {
	    vlTOPp->traceChgThis__9(vlSymsp, vcdp, code);
	}
	if (VL_UNLIKELY((0x80U & vlTOPp->__Vm_traceActivity))) {
	    vlTOPp->traceChgThis__10(vlSymsp, vcdp, code);
	}
	if (VL_UNLIKELY((0x100U & vlTOPp->__Vm_traceActivity))) {
	    vlTOPp->traceChgThis__11(vlSymsp, vcdp, code);
	}
	if (VL_UNLIKELY((0x200U & vlTOPp->__Vm_traceActivity))) {
	    vlTOPp->traceChgThis__12(vlSymsp, vcdp, code);
	}
	vlTOPp->traceChgThis__13(vlSymsp, vcdp, code);
    }
    // Final
    vlTOPp->__Vm_traceActivity = 0U;
}

void Vtop::traceChgThis__2(Vtop__Syms* __restrict vlSymsp, VerilatedVcd* vcdp, uint32_t code) {
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    int c=code;
    if (0 && vcdp && c) {}  // Prevent unused
    // Body
    {
	vcdp->chgBus  (c+1,(vlTOPp->top__DOT__regwe),4);
	vcdp->chgBus  (c+2,(vlTOPp->top__DOT__alu_a),8);
	vcdp->chgBus  (c+3,(vlTOPp->top__DOT__alu_b),8);
	vcdp->chgBus  (c+4,(vlTOPp->top__DOT__alu_q),8);
	vcdp->chgBus  (c+5,(vlTOPp->top__DOT__reg_in),8);
	vcdp->chgBus  (c+6,(vlTOPp->top__DOT____Vcellout__demux_inst__o0),1);
	vcdp->chgBus  (c+7,(vlTOPp->top__DOT____Vcellout__demux_inst__o1),1);
	vcdp->chgBus  (c+8,(vlTOPp->top__DOT____Vcellout__demux_inst__o2),1);
	vcdp->chgBus  (c+9,(vlTOPp->top__DOT____Vcellout__demux_inst__o3),1);
	vcdp->chgBus  (c+10,(vlTOPp->top__DOT__alu_inst__DOT__cc),9);
	vcdp->chgBit  (c+11,((1U & (IData)(vlTOPp->top__DOT__alu_inst__DOT__cc))));
	vcdp->chgBit  (c+12,((1U & (IData)(vlTOPp->top__DOT__alu_a))));
	vcdp->chgBit  (c+13,((1U & (IData)(vlTOPp->top__DOT__alu_b))));
	vcdp->chgBit  (c+14,(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q));
	vcdp->chgBit  (c+15,((1U & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				    >> 1U))));
	vcdp->chgBit  (c+16,((1U & ((IData)(vlTOPp->top__DOT__alu_a) 
				    >> 1U))));
	vcdp->chgBit  (c+17,((1U & ((IData)(vlTOPp->top__DOT__alu_b) 
				    >> 1U))));
	vcdp->chgBit  (c+18,(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q));
	vcdp->chgBit  (c+19,((1U & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				    >> 2U))));
	vcdp->chgBit  (c+20,((1U & ((IData)(vlTOPp->top__DOT__alu_a) 
				    >> 2U))));
	vcdp->chgBit  (c+21,((1U & ((IData)(vlTOPp->top__DOT__alu_b) 
				    >> 2U))));
	vcdp->chgBit  (c+22,(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q));
	vcdp->chgBit  (c+23,((1U & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				    >> 3U))));
	vcdp->chgBit  (c+24,((1U & ((IData)(vlTOPp->top__DOT__alu_a) 
				    >> 3U))));
	vcdp->chgBit  (c+25,((1U & ((IData)(vlTOPp->top__DOT__alu_b) 
				    >> 3U))));
	vcdp->chgBit  (c+26,(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q));
	vcdp->chgBit  (c+27,((1U & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				    >> 4U))));
	vcdp->chgBit  (c+28,((1U & ((IData)(vlTOPp->top__DOT__alu_a) 
				    >> 4U))));
	vcdp->chgBit  (c+29,((1U & ((IData)(vlTOPp->top__DOT__alu_b) 
				    >> 4U))));
	vcdp->chgBit  (c+30,(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q));
	vcdp->chgBit  (c+31,((1U & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				    >> 5U))));
	vcdp->chgBit  (c+32,((1U & ((IData)(vlTOPp->top__DOT__alu_a) 
				    >> 5U))));
	vcdp->chgBit  (c+33,((1U & ((IData)(vlTOPp->top__DOT__alu_b) 
				    >> 5U))));
	vcdp->chgBit  (c+34,(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q));
	vcdp->chgBit  (c+35,((1U & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				    >> 6U))));
	vcdp->chgBit  (c+36,((1U & ((IData)(vlTOPp->top__DOT__alu_a) 
				    >> 6U))));
	vcdp->chgBit  (c+37,((1U & ((IData)(vlTOPp->top__DOT__alu_b) 
				    >> 6U))));
	vcdp->chgBit  (c+38,(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q));
	vcdp->chgBit  (c+39,((1U & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				    >> 7U))));
	vcdp->chgBit  (c+40,((1U & ((IData)(vlTOPp->top__DOT__alu_a) 
				    >> 7U))));
	vcdp->chgBit  (c+41,((1U & ((IData)(vlTOPp->top__DOT__alu_b) 
				    >> 7U))));
	vcdp->chgBit  (c+42,(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q));
	vcdp->chgBit  (c+43,(vlTOPp->top__DOT__register_file__BRA__0__KET____DOT____Vcellinp__register_inst__we));
	vcdp->chgBit  (c+44,(vlTOPp->top__DOT__register_file__BRA__1__KET____DOT____Vcellinp__register_inst__we));
	vcdp->chgBit  (c+45,(vlTOPp->top__DOT__register_file__BRA__2__KET____DOT____Vcellinp__register_inst__we));
	vcdp->chgBit  (c+46,(vlTOPp->top__DOT__register_file__BRA__3__KET____DOT____Vcellinp__register_inst__we));
    }
}

void Vtop::traceChgThis__3(Vtop__Syms* __restrict vlSymsp, VerilatedVcd* vcdp, uint32_t code) {
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    int c=code;
    if (0 && vcdp && c) {}  // Prevent unused
    // Body
    {
	vcdp->chgBus  (c+47,(vlTOPp->top__DOT__d_in),8);
    }
}

void Vtop::traceChgThis__4(Vtop__Syms* __restrict vlSymsp, VerilatedVcd* vcdp, uint32_t code) {
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    int c=code;
    if (0 && vcdp && c) {}  // Prevent unused
    // Body
    {
	vcdp->chgBus  (c+48,(vlTOPp->top__DOT__regout[0]),8);
	vcdp->chgBus  (c+49,(vlTOPp->top__DOT__regout[1]),8);
	vcdp->chgBus  (c+50,(vlTOPp->top__DOT__regout[2]),8);
	vcdp->chgBus  (c+51,(vlTOPp->top__DOT__regout[3]),8);
    }
}

void Vtop::traceChgThis__5(Vtop__Syms* __restrict vlSymsp, VerilatedVcd* vcdp, uint32_t code) {
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    int c=code;
    if (0 && vcdp && c) {}  // Prevent unused
    // Body
    {
	vcdp->chgBus  (c+52,(vlTOPp->top__DOT____Vcellinp__amux_inst__i0),8);
	vcdp->chgBus  (c+53,(vlTOPp->top__DOT____Vcellinp__amux_inst__i1),8);
	vcdp->chgBus  (c+54,(vlTOPp->top__DOT____Vcellinp__amux_inst__i2),8);
	vcdp->chgBus  (c+55,(vlTOPp->top__DOT____Vcellinp__amux_inst__i3),8);
	vcdp->chgBus  (c+56,(vlTOPp->top__DOT____Vcellinp__bmux_inst__i0),8);
	vcdp->chgBus  (c+57,(vlTOPp->top__DOT____Vcellinp__bmux_inst__i1),8);
	vcdp->chgBus  (c+58,(vlTOPp->top__DOT____Vcellinp__bmux_inst__i2),8);
	vcdp->chgBus  (c+59,(vlTOPp->top__DOT____Vcellinp__bmux_inst__i3),8);
    }
}

void Vtop::traceChgThis__6(Vtop__Syms* __restrict vlSymsp, VerilatedVcd* vcdp, uint32_t code) {
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    int c=code;
    if (0 && vcdp && c) {}  // Prevent unused
    // Body
    {
	vcdp->chgBus  (c+60,(vlTOPp->top__DOT__umbr_in__DOT__do_r),8);
    }
}

void Vtop::traceChgThis__7(Vtop__Syms* __restrict vlSymsp, VerilatedVcd* vcdp, uint32_t code) {
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    int c=code;
    if (0 && vcdp && c) {}  // Prevent unused
    // Body
    {
	vcdp->chgBus  (c+61,(vlTOPp->top__DOT__umbr_out__DOT__do_r),8);
    }
}

void Vtop::traceChgThis__8(Vtop__Syms* __restrict vlSymsp, VerilatedVcd* vcdp, uint32_t code) {
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    int c=code;
    if (0 && vcdp && c) {}  // Prevent unused
    // Body
    {
	vcdp->chgBus  (c+62,(vlTOPp->top__DOT__umar__DOT__do_r),8);
    }
}

void Vtop::traceChgThis__9(Vtop__Syms* __restrict vlSymsp, VerilatedVcd* vcdp, uint32_t code) {
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    int c=code;
    if (0 && vcdp && c) {}  // Prevent unused
    // Body
    {
	vcdp->chgBus  (c+63,(vlTOPp->top__DOT__register_file__BRA__0__KET____DOT__register_inst__DOT__do_r),8);
    }
}

void Vtop::traceChgThis__10(Vtop__Syms* __restrict vlSymsp, VerilatedVcd* vcdp, uint32_t code) {
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    int c=code;
    if (0 && vcdp && c) {}  // Prevent unused
    // Body
    {
	vcdp->chgBus  (c+64,(vlTOPp->top__DOT__register_file__BRA__1__KET____DOT__register_inst__DOT__do_r),8);
    }
}

void Vtop::traceChgThis__11(Vtop__Syms* __restrict vlSymsp, VerilatedVcd* vcdp, uint32_t code) {
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    int c=code;
    if (0 && vcdp && c) {}  // Prevent unused
    // Body
    {
	vcdp->chgBus  (c+65,(vlTOPp->top__DOT__register_file__BRA__2__KET____DOT__register_inst__DOT__do_r),8);
    }
}

void Vtop::traceChgThis__12(Vtop__Syms* __restrict vlSymsp, VerilatedVcd* vcdp, uint32_t code) {
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    int c=code;
    if (0 && vcdp && c) {}  // Prevent unused
    // Body
    {
	vcdp->chgBus  (c+66,(vlTOPp->top__DOT__register_file__BRA__3__KET____DOT__register_inst__DOT__do_r),8);
    }
}

void Vtop::traceChgThis__13(Vtop__Syms* __restrict vlSymsp, VerilatedVcd* vcdp, uint32_t code) {
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    int c=code;
    if (0 && vcdp && c) {}  // Prevent unused
    // Body
    {
	vcdp->chgBit  (c+67,(vlTOPp->reset));
	vcdp->chgBus  (c+68,(vlTOPp->reg_addr_we),2);
	vcdp->chgBit  (c+69,(vlTOPp->reg_we));
	vcdp->chgBit  (c+70,(vlTOPp->mar_we));
	vcdp->chgBit  (c+71,(vlTOPp->mbr_out_we));
	vcdp->chgBit  (c+72,(vlTOPp->mbr_in_we));
	vcdp->chgBit  (c+73,(vlTOPp->mem_we));
	vcdp->chgBit  (c+74,(vlTOPp->mbr_alu));
	vcdp->chgBus  (c+75,(vlTOPp->alu_func),2);
	vcdp->chgBit  (c+76,(vlTOPp->alu_comp_b));
	vcdp->chgBit  (c+77,(vlTOPp->alu_ci));
	vcdp->chgBus  (c+78,(vlTOPp->alu_reg_a),2);
	vcdp->chgBus  (c+79,(vlTOPp->alu_reg_b),2);
	vcdp->chgBit  (c+80,(vlTOPp->alu_so));
	vcdp->chgBit  (c+81,(vlTOPp->alu_uo));
	vcdp->chgBit  (c+82,((1U & (((((IData)(vlTOPp->top__DOT__alu_b) 
				       ^ (IData)(vlTOPp->alu_comp_b)) 
				      ^ (IData)(vlTOPp->top__DOT__alu_a)) 
				     & (IData)(vlTOPp->top__DOT__alu_inst__DOT__cc)) 
				    | (((IData)(vlTOPp->top__DOT__alu_b) 
					^ (IData)(vlTOPp->alu_comp_b)) 
				       & (IData)(vlTOPp->top__DOT__alu_a))))));
	vcdp->chgBit  (c+83,((1U & ((((((IData)(vlTOPp->top__DOT__alu_b) 
					>> 1U) ^ (IData)(vlTOPp->alu_comp_b)) 
				      ^ ((IData)(vlTOPp->top__DOT__alu_a) 
					 >> 1U)) & 
				     ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				      >> 1U)) | ((((IData)(vlTOPp->top__DOT__alu_b) 
						   >> 1U) 
						  ^ (IData)(vlTOPp->alu_comp_b)) 
						 & ((IData)(vlTOPp->top__DOT__alu_a) 
						    >> 1U))))));
	vcdp->chgBit  (c+84,((1U & ((((((IData)(vlTOPp->top__DOT__alu_b) 
					>> 2U) ^ (IData)(vlTOPp->alu_comp_b)) 
				      ^ ((IData)(vlTOPp->top__DOT__alu_a) 
					 >> 2U)) & 
				     ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				      >> 2U)) | ((((IData)(vlTOPp->top__DOT__alu_b) 
						   >> 2U) 
						  ^ (IData)(vlTOPp->alu_comp_b)) 
						 & ((IData)(vlTOPp->top__DOT__alu_a) 
						    >> 2U))))));
	vcdp->chgBit  (c+85,((1U & ((((((IData)(vlTOPp->top__DOT__alu_b) 
					>> 3U) ^ (IData)(vlTOPp->alu_comp_b)) 
				      ^ ((IData)(vlTOPp->top__DOT__alu_a) 
					 >> 3U)) & 
				     ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				      >> 3U)) | ((((IData)(vlTOPp->top__DOT__alu_b) 
						   >> 3U) 
						  ^ (IData)(vlTOPp->alu_comp_b)) 
						 & ((IData)(vlTOPp->top__DOT__alu_a) 
						    >> 3U))))));
	vcdp->chgBit  (c+86,((1U & ((((((IData)(vlTOPp->top__DOT__alu_b) 
					>> 4U) ^ (IData)(vlTOPp->alu_comp_b)) 
				      ^ ((IData)(vlTOPp->top__DOT__alu_a) 
					 >> 4U)) & 
				     ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				      >> 4U)) | ((((IData)(vlTOPp->top__DOT__alu_b) 
						   >> 4U) 
						  ^ (IData)(vlTOPp->alu_comp_b)) 
						 & ((IData)(vlTOPp->top__DOT__alu_a) 
						    >> 4U))))));
	vcdp->chgBit  (c+87,((1U & ((((((IData)(vlTOPp->top__DOT__alu_b) 
					>> 5U) ^ (IData)(vlTOPp->alu_comp_b)) 
				      ^ ((IData)(vlTOPp->top__DOT__alu_a) 
					 >> 5U)) & 
				     ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				      >> 5U)) | ((((IData)(vlTOPp->top__DOT__alu_b) 
						   >> 5U) 
						  ^ (IData)(vlTOPp->alu_comp_b)) 
						 & ((IData)(vlTOPp->top__DOT__alu_a) 
						    >> 5U))))));
	vcdp->chgBit  (c+88,((1U & ((((((IData)(vlTOPp->top__DOT__alu_b) 
					>> 6U) ^ (IData)(vlTOPp->alu_comp_b)) 
				      ^ ((IData)(vlTOPp->top__DOT__alu_a) 
					 >> 6U)) & 
				     ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				      >> 6U)) | ((((IData)(vlTOPp->top__DOT__alu_b) 
						   >> 6U) 
						  ^ (IData)(vlTOPp->alu_comp_b)) 
						 & ((IData)(vlTOPp->top__DOT__alu_a) 
						    >> 6U))))));
	vcdp->chgBit  (c+89,((1U & ((((((IData)(vlTOPp->top__DOT__alu_b) 
					>> 7U) ^ (IData)(vlTOPp->alu_comp_b)) 
				      ^ ((IData)(vlTOPp->top__DOT__alu_a) 
					 >> 7U)) & 
				     ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				      >> 7U)) | ((((IData)(vlTOPp->top__DOT__alu_b) 
						   >> 7U) 
						  ^ (IData)(vlTOPp->alu_comp_b)) 
						 & ((IData)(vlTOPp->top__DOT__alu_a) 
						    >> 7U))))));
    }
}
