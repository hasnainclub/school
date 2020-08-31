// Verilated -*- C++ -*-
// DESCRIPTION: Verilator output: Design implementation internals
// See Vtop.h for the primary calling header

#include "Vtop.h"              // For This
#include "Vtop__Syms.h"

//--------------------
// STATIC VARIABLES

VL_ST_SIG8(Vtop::__Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[64],0,0);
VL_ST_SIG8(Vtop::__Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[64],0,0);
VL_ST_SIG8(Vtop::__Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[64],0,0);
VL_ST_SIG8(Vtop::__Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[64],0,0);
VL_ST_SIG8(Vtop::__Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[64],0,0);
VL_ST_SIG8(Vtop::__Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[64],0,0);
VL_ST_SIG8(Vtop::__Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[64],0,0);
VL_ST_SIG8(Vtop::__Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[64],0,0);

//--------------------

VL_CTOR_IMP(Vtop) {
    Vtop__Syms* __restrict vlSymsp = __VlSymsp = new Vtop__Syms(this, name());
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    // Reset internal values
    
    // Reset structure values
    _ctor_var_reset();
}

void Vtop::__Vconfigure(Vtop__Syms* vlSymsp, bool first) {
    if (0 && first) {}  // Prevent unused
    this->__VlSymsp = vlSymsp;
}

Vtop::~Vtop() {
    delete __VlSymsp; __VlSymsp=NULL;
}

//--------------------


void Vtop::eval() {
    Vtop__Syms* __restrict vlSymsp = this->__VlSymsp; // Setup global symbol table
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    // Initialize
    if (VL_UNLIKELY(!vlSymsp->__Vm_didInit)) _eval_initial_loop(vlSymsp);
    // Evaluate till stable
    VL_DEBUG_IF(VL_PRINTF("\n----TOP Evaluate Vtop::eval\n"); );
    int __VclockLoop = 0;
    QData __Vchange=1;
    while (VL_LIKELY(__Vchange)) {
	VL_DEBUG_IF(VL_PRINTF(" Clock loop\n"););
	vlSymsp->__Vm_activity = true;
	_eval(vlSymsp);
	__Vchange = _change_request(vlSymsp);
	if (++__VclockLoop > 100) vl_fatal(__FILE__,__LINE__,__FILE__,"Verilated model didn't converge");
    }
}

void Vtop::_eval_initial_loop(Vtop__Syms* __restrict vlSymsp) {
    vlSymsp->__Vm_didInit = true;
    _eval_initial(vlSymsp);
    vlSymsp->__Vm_activity = true;
    int __VclockLoop = 0;
    QData __Vchange=1;
    while (VL_LIKELY(__Vchange)) {
	_eval_settle(vlSymsp);
	_eval(vlSymsp);
	__Vchange = _change_request(vlSymsp);
	if (++__VclockLoop > 100) vl_fatal(__FILE__,__LINE__,__FILE__,"Verilated model didn't DC converge");
    }
}

//--------------------
// Internal Methods

VL_INLINE_OPT void Vtop::_sequent__TOP__1(Vtop__Syms* __restrict vlSymsp) {
    VL_DEBUG_IF(VL_PRINTF("    Vtop::_sequent__TOP__1\n"); );
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    // Body
    // ALWAYS at register.v:13
    vlTOPp->top__DOT__umbr_in__DOT__do_r = ((IData)(vlTOPp->reset)
					     ? 0U : (IData)(vlTOPp->top__DOT__d_in));
}

VL_INLINE_OPT void Vtop::_sequent__TOP__4(Vtop__Syms* __restrict vlSymsp) {
    VL_DEBUG_IF(VL_PRINTF("    Vtop::_sequent__TOP__4\n"); );
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    // Variables
    VL_SIG8(__Vdlyvdim0__top__DOT__umem__DOT__do_r__v0,7,0);
    VL_SIG8(__Vdlyvval__top__DOT__umem__DOT__do_r__v0,7,0);
    //char	__VpadToAlign26[2];
    // Body
    // ALWAYS at memory.v:13
    __Vdlyvval__top__DOT__umem__DOT__do_r__v0 = vlTOPp->top__DOT__umbr_out__DOT__do_r;
    __Vdlyvdim0__top__DOT__umem__DOT__do_r__v0 = vlTOPp->top__DOT__umar__DOT__do_r;
    // ALWAYSPOST at memory.v:15
    vlTOPp->top__DOT__umem__DOT__do_r[__Vdlyvdim0__top__DOT__umem__DOT__do_r__v0] 
	= __Vdlyvval__top__DOT__umem__DOT__do_r__v0;
}

VL_INLINE_OPT void Vtop::_combo__TOP__5(Vtop__Syms* __restrict vlSymsp) {
    VL_DEBUG_IF(VL_PRINTF("    Vtop::_combo__TOP__5\n"); );
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    // Body
    vlTOPp->top__DOT__alu_inst__DOT__cc = ((0x1feU 
					    & (IData)(vlTOPp->top__DOT__alu_inst__DOT__cc)) 
					   | (IData)(vlTOPp->alu_ci));
    // ALWAYS at demux.v:12
    vlTOPp->top__DOT____Vcellout__demux_inst__o0 = 0U;
    vlTOPp->top__DOT____Vcellout__demux_inst__o1 = 0U;
    vlTOPp->top__DOT____Vcellout__demux_inst__o2 = 0U;
    vlTOPp->top__DOT____Vcellout__demux_inst__o3 = 0U;
    if ((0U == (IData)(vlTOPp->reg_addr_we))) {
	vlTOPp->top__DOT____Vcellout__demux_inst__o0 
	    = vlTOPp->reg_we;
    } else {
	if ((1U == (IData)(vlTOPp->reg_addr_we))) {
	    vlTOPp->top__DOT____Vcellout__demux_inst__o1 
		= vlTOPp->reg_we;
	} else {
	    if ((2U == (IData)(vlTOPp->reg_addr_we))) {
		vlTOPp->top__DOT____Vcellout__demux_inst__o2 
		    = vlTOPp->reg_we;
	    } else {
		if ((3U == (IData)(vlTOPp->reg_addr_we))) {
		    vlTOPp->top__DOT____Vcellout__demux_inst__o3 
			= vlTOPp->reg_we;
		}
	    }
	}
    }
}

void Vtop::_settle__TOP__6(Vtop__Syms* __restrict vlSymsp) {
    VL_DEBUG_IF(VL_PRINTF("    Vtop::_settle__TOP__6\n"); );
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    // Body
    vlTOPp->top__DOT__alu_inst__DOT__cc = ((0x1feU 
					    & (IData)(vlTOPp->top__DOT__alu_inst__DOT__cc)) 
					   | (IData)(vlTOPp->alu_ci));
    // ALWAYS at demux.v:12
    vlTOPp->top__DOT____Vcellout__demux_inst__o0 = 0U;
    vlTOPp->top__DOT____Vcellout__demux_inst__o1 = 0U;
    vlTOPp->top__DOT____Vcellout__demux_inst__o2 = 0U;
    vlTOPp->top__DOT____Vcellout__demux_inst__o3 = 0U;
    if ((0U == (IData)(vlTOPp->reg_addr_we))) {
	vlTOPp->top__DOT____Vcellout__demux_inst__o0 
	    = vlTOPp->reg_we;
    } else {
	if ((1U == (IData)(vlTOPp->reg_addr_we))) {
	    vlTOPp->top__DOT____Vcellout__demux_inst__o1 
		= vlTOPp->reg_we;
	} else {
	    if ((2U == (IData)(vlTOPp->reg_addr_we))) {
		vlTOPp->top__DOT____Vcellout__demux_inst__o2 
		    = vlTOPp->reg_we;
	    } else {
		if ((3U == (IData)(vlTOPp->reg_addr_we))) {
		    vlTOPp->top__DOT____Vcellout__demux_inst__o3 
			= vlTOPp->reg_we;
		}
	    }
	}
    }
    vlTOPp->alu_so = (1U & (((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
			     >> 8U) ^ ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				       >> 7U)));
    vlTOPp->alu_uo = (1U & (((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
			     >> 8U) ^ ((((IData)(vlTOPp->alu_comp_b) 
					 & (IData)(vlTOPp->alu_ci)) 
					& (~ (IData)(vlTOPp->alu_func))) 
				       & (~ ((IData)(vlTOPp->alu_func) 
					     >> 1U)))));
    vlTOPp->top__DOT__regwe = (((IData)(vlTOPp->top__DOT____Vcellout__demux_inst__o3) 
				<< 3U) | (((IData)(vlTOPp->top__DOT____Vcellout__demux_inst__o2) 
					   << 2U) | 
					  (((IData)(vlTOPp->top__DOT____Vcellout__demux_inst__o1) 
					    << 1U) 
					   | (IData)(vlTOPp->top__DOT____Vcellout__demux_inst__o0))));
}

VL_INLINE_OPT void Vtop::_sequent__TOP__7(Vtop__Syms* __restrict vlSymsp) {
    VL_DEBUG_IF(VL_PRINTF("    Vtop::_sequent__TOP__7\n"); );
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    // Body
    // ALWAYS at register.v:13
    vlTOPp->top__DOT__umbr_out__DOT__do_r = ((IData)(vlTOPp->reset)
					      ? 0U : (IData)(vlTOPp->top__DOT__alu_q));
}

VL_INLINE_OPT void Vtop::_sequent__TOP__8(Vtop__Syms* __restrict vlSymsp) {
    VL_DEBUG_IF(VL_PRINTF("    Vtop::_sequent__TOP__8\n"); );
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    // Body
    // ALWAYS at register.v:13
    vlTOPp->top__DOT__umar__DOT__do_r = ((IData)(vlTOPp->reset)
					  ? 0U : (IData)(vlTOPp->top__DOT__alu_q));
}

VL_INLINE_OPT void Vtop::_combo__TOP__9(Vtop__Syms* __restrict vlSymsp) {
    VL_DEBUG_IF(VL_PRINTF("    Vtop::_combo__TOP__9\n"); );
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    // Body
    vlTOPp->alu_so = (1U & (((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
			     >> 8U) ^ ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				       >> 7U)));
    vlTOPp->alu_uo = (1U & (((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
			     >> 8U) ^ ((((IData)(vlTOPp->alu_comp_b) 
					 & (IData)(vlTOPp->alu_ci)) 
					& (~ (IData)(vlTOPp->alu_func))) 
				       & (~ ((IData)(vlTOPp->alu_func) 
					     >> 1U)))));
    vlTOPp->top__DOT__regwe = (((IData)(vlTOPp->top__DOT____Vcellout__demux_inst__o3) 
				<< 3U) | (((IData)(vlTOPp->top__DOT____Vcellout__demux_inst__o2) 
					   << 2U) | 
					  (((IData)(vlTOPp->top__DOT____Vcellout__demux_inst__o1) 
					    << 1U) 
					   | (IData)(vlTOPp->top__DOT____Vcellout__demux_inst__o0))));
    vlTOPp->top__DOT__register_file__BRA__0__KET____DOT____Vcellinp__register_inst__we 
	= (1U & (IData)(vlTOPp->top__DOT__regwe));
    vlTOPp->top__DOT__register_file__BRA__1__KET____DOT____Vcellinp__register_inst__we 
	= (1U & ((IData)(vlTOPp->top__DOT__regwe) >> 1U));
    vlTOPp->top__DOT__register_file__BRA__2__KET____DOT____Vcellinp__register_inst__we 
	= (1U & ((IData)(vlTOPp->top__DOT__regwe) >> 2U));
    vlTOPp->top__DOT__register_file__BRA__3__KET____DOT____Vcellinp__register_inst__we 
	= (1U & ((IData)(vlTOPp->top__DOT__regwe) >> 3U));
}

VL_INLINE_OPT void Vtop::_multiclk__TOP__10(Vtop__Syms* __restrict vlSymsp) {
    VL_DEBUG_IF(VL_PRINTF("    Vtop::_multiclk__TOP__10\n"); );
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    // Body
    vlTOPp->top__DOT__d_in = vlTOPp->top__DOT__umem__DOT__do_r
	[vlTOPp->top__DOT__umar__DOT__do_r];
}

void Vtop::_settle__TOP__11(Vtop__Syms* __restrict vlSymsp) {
    VL_DEBUG_IF(VL_PRINTF("    Vtop::_settle__TOP__11\n"); );
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    // Body
    vlTOPp->top__DOT__d_in = vlTOPp->top__DOT__umem__DOT__do_r
	[vlTOPp->top__DOT__umar__DOT__do_r];
    vlTOPp->top__DOT__register_file__BRA__0__KET____DOT____Vcellinp__register_inst__we 
	= (1U & (IData)(vlTOPp->top__DOT__regwe));
    vlTOPp->top__DOT__register_file__BRA__1__KET____DOT____Vcellinp__register_inst__we 
	= (1U & ((IData)(vlTOPp->top__DOT__regwe) >> 1U));
    vlTOPp->top__DOT__register_file__BRA__2__KET____DOT____Vcellinp__register_inst__we 
	= (1U & ((IData)(vlTOPp->top__DOT__regwe) >> 2U));
    vlTOPp->top__DOT__register_file__BRA__3__KET____DOT____Vcellinp__register_inst__we 
	= (1U & ((IData)(vlTOPp->top__DOT__regwe) >> 3U));
}

VL_INLINE_OPT void Vtop::_sequent__TOP__12(Vtop__Syms* __restrict vlSymsp) {
    VL_DEBUG_IF(VL_PRINTF("    Vtop::_sequent__TOP__12\n"); );
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    // Body
    // ALWAYS at register.v:13
    vlTOPp->top__DOT__register_file__BRA__0__KET____DOT__register_inst__DOT__do_r 
	= ((IData)(vlTOPp->reset) ? 0U : (IData)(vlTOPp->top__DOT__reg_in));
    vlTOPp->top__DOT__regout[0U] = vlTOPp->top__DOT__register_file__BRA__0__KET____DOT__register_inst__DOT__do_r;
}

VL_INLINE_OPT void Vtop::_sequent__TOP__13(Vtop__Syms* __restrict vlSymsp) {
    VL_DEBUG_IF(VL_PRINTF("    Vtop::_sequent__TOP__13\n"); );
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    // Body
    // ALWAYS at register.v:13
    vlTOPp->top__DOT__register_file__BRA__1__KET____DOT__register_inst__DOT__do_r 
	= ((IData)(vlTOPp->reset) ? 0U : (IData)(vlTOPp->top__DOT__reg_in));
    vlTOPp->top__DOT__regout[1U] = vlTOPp->top__DOT__register_file__BRA__1__KET____DOT__register_inst__DOT__do_r;
}

VL_INLINE_OPT void Vtop::_sequent__TOP__14(Vtop__Syms* __restrict vlSymsp) {
    VL_DEBUG_IF(VL_PRINTF("    Vtop::_sequent__TOP__14\n"); );
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    // Body
    // ALWAYS at register.v:13
    vlTOPp->top__DOT__register_file__BRA__2__KET____DOT__register_inst__DOT__do_r 
	= ((IData)(vlTOPp->reset) ? 0U : (IData)(vlTOPp->top__DOT__reg_in));
    vlTOPp->top__DOT__regout[2U] = vlTOPp->top__DOT__register_file__BRA__2__KET____DOT__register_inst__DOT__do_r;
}

VL_INLINE_OPT void Vtop::_sequent__TOP__15(Vtop__Syms* __restrict vlSymsp) {
    VL_DEBUG_IF(VL_PRINTF("    Vtop::_sequent__TOP__15\n"); );
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    // Body
    // ALWAYS at register.v:13
    vlTOPp->top__DOT__register_file__BRA__3__KET____DOT__register_inst__DOT__do_r 
	= ((IData)(vlTOPp->reset) ? 0U : (IData)(vlTOPp->top__DOT__reg_in));
    vlTOPp->top__DOT__regout[3U] = vlTOPp->top__DOT__register_file__BRA__3__KET____DOT__register_inst__DOT__do_r;
}

void Vtop::_settle__TOP__16(Vtop__Syms* __restrict vlSymsp) {
    VL_DEBUG_IF(VL_PRINTF("    Vtop::_settle__TOP__16\n"); );
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    // Body
    vlTOPp->top__DOT__regout[0U] = vlTOPp->top__DOT__register_file__BRA__0__KET____DOT__register_inst__DOT__do_r;
    vlTOPp->top__DOT__regout[1U] = vlTOPp->top__DOT__register_file__BRA__1__KET____DOT__register_inst__DOT__do_r;
    vlTOPp->top__DOT__regout[2U] = vlTOPp->top__DOT__register_file__BRA__2__KET____DOT__register_inst__DOT__do_r;
    vlTOPp->top__DOT__regout[3U] = vlTOPp->top__DOT__register_file__BRA__3__KET____DOT__register_inst__DOT__do_r;
    vlTOPp->top__DOT____Vcellinp__amux_inst__i3 = vlTOPp->top__DOT__regout
	[3U];
    vlTOPp->top__DOT____Vcellinp__amux_inst__i2 = vlTOPp->top__DOT__regout
	[2U];
    vlTOPp->top__DOT____Vcellinp__amux_inst__i1 = vlTOPp->top__DOT__regout
	[1U];
    vlTOPp->top__DOT____Vcellinp__amux_inst__i0 = vlTOPp->top__DOT__regout
	[0U];
    vlTOPp->top__DOT____Vcellinp__bmux_inst__i3 = vlTOPp->top__DOT__regout
	[3U];
    vlTOPp->top__DOT____Vcellinp__bmux_inst__i2 = vlTOPp->top__DOT__regout
	[2U];
    vlTOPp->top__DOT____Vcellinp__bmux_inst__i1 = vlTOPp->top__DOT__regout
	[1U];
    vlTOPp->top__DOT____Vcellinp__bmux_inst__i0 = vlTOPp->top__DOT__regout
	[0U];
}

VL_INLINE_OPT void Vtop::_multiclk__TOP__17(Vtop__Syms* __restrict vlSymsp) {
    VL_DEBUG_IF(VL_PRINTF("    Vtop::_multiclk__TOP__17\n"); );
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    // Body
    vlTOPp->top__DOT____Vcellinp__amux_inst__i3 = vlTOPp->top__DOT__regout
	[3U];
    vlTOPp->top__DOT____Vcellinp__amux_inst__i2 = vlTOPp->top__DOT__regout
	[2U];
    vlTOPp->top__DOT____Vcellinp__amux_inst__i1 = vlTOPp->top__DOT__regout
	[1U];
    vlTOPp->top__DOT____Vcellinp__amux_inst__i0 = vlTOPp->top__DOT__regout
	[0U];
    vlTOPp->top__DOT____Vcellinp__bmux_inst__i3 = vlTOPp->top__DOT__regout
	[3U];
    vlTOPp->top__DOT____Vcellinp__bmux_inst__i2 = vlTOPp->top__DOT__regout
	[2U];
    vlTOPp->top__DOT____Vcellinp__bmux_inst__i1 = vlTOPp->top__DOT__regout
	[1U];
    vlTOPp->top__DOT____Vcellinp__bmux_inst__i0 = vlTOPp->top__DOT__regout
	[0U];
}

VL_INLINE_OPT void Vtop::_combo__TOP__18(Vtop__Syms* __restrict vlSymsp) {
    VL_DEBUG_IF(VL_PRINTF("    Vtop::_combo__TOP__18\n"); );
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    // Body
    // ALWAYS at mux.v:12
    if ((0U == (IData)(vlTOPp->alu_reg_a))) {
	vlTOPp->top__DOT__alu_a = vlTOPp->top__DOT____Vcellinp__amux_inst__i0;
    } else {
	if ((1U == (IData)(vlTOPp->alu_reg_a))) {
	    vlTOPp->top__DOT__alu_a = vlTOPp->top__DOT____Vcellinp__amux_inst__i1;
	} else {
	    if ((2U == (IData)(vlTOPp->alu_reg_a))) {
		vlTOPp->top__DOT__alu_a = vlTOPp->top__DOT____Vcellinp__amux_inst__i2;
	    } else {
		if ((3U == (IData)(vlTOPp->alu_reg_a))) {
		    vlTOPp->top__DOT__alu_a = vlTOPp->top__DOT____Vcellinp__amux_inst__i3;
		}
	    }
	}
    }
    // ALWAYS at mux.v:12
    if ((0U == (IData)(vlTOPp->alu_reg_b))) {
	vlTOPp->top__DOT__alu_b = vlTOPp->top__DOT____Vcellinp__bmux_inst__i0;
    } else {
	if ((1U == (IData)(vlTOPp->alu_reg_b))) {
	    vlTOPp->top__DOT__alu_b = vlTOPp->top__DOT____Vcellinp__bmux_inst__i1;
	} else {
	    if ((2U == (IData)(vlTOPp->alu_reg_b))) {
		vlTOPp->top__DOT__alu_b = vlTOPp->top__DOT____Vcellinp__bmux_inst__i2;
	    } else {
		if ((3U == (IData)(vlTOPp->alu_reg_b))) {
		    vlTOPp->top__DOT__alu_b = vlTOPp->top__DOT____Vcellinp__bmux_inst__i3;
		}
	    }
	}
    }
}

void Vtop::_settle__TOP__19(Vtop__Syms* __restrict vlSymsp) {
    VL_DEBUG_IF(VL_PRINTF("    Vtop::_settle__TOP__19\n"); );
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    // Body
    // ALWAYS at mux.v:12
    if ((0U == (IData)(vlTOPp->alu_reg_a))) {
	vlTOPp->top__DOT__alu_a = vlTOPp->top__DOT____Vcellinp__amux_inst__i0;
    } else {
	if ((1U == (IData)(vlTOPp->alu_reg_a))) {
	    vlTOPp->top__DOT__alu_a = vlTOPp->top__DOT____Vcellinp__amux_inst__i1;
	} else {
	    if ((2U == (IData)(vlTOPp->alu_reg_a))) {
		vlTOPp->top__DOT__alu_a = vlTOPp->top__DOT____Vcellinp__amux_inst__i2;
	    } else {
		if ((3U == (IData)(vlTOPp->alu_reg_a))) {
		    vlTOPp->top__DOT__alu_a = vlTOPp->top__DOT____Vcellinp__amux_inst__i3;
		}
	    }
	}
    }
    // ALWAYS at mux.v:12
    if ((0U == (IData)(vlTOPp->alu_reg_b))) {
	vlTOPp->top__DOT__alu_b = vlTOPp->top__DOT____Vcellinp__bmux_inst__i0;
    } else {
	if ((1U == (IData)(vlTOPp->alu_reg_b))) {
	    vlTOPp->top__DOT__alu_b = vlTOPp->top__DOT____Vcellinp__bmux_inst__i1;
	} else {
	    if ((2U == (IData)(vlTOPp->alu_reg_b))) {
		vlTOPp->top__DOT__alu_b = vlTOPp->top__DOT____Vcellinp__bmux_inst__i2;
	    } else {
		if ((3U == (IData)(vlTOPp->alu_reg_b))) {
		    vlTOPp->top__DOT__alu_b = vlTOPp->top__DOT____Vcellinp__bmux_inst__i3;
		}
	    }
	}
    }
    vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__co 
	= (1U & (((((IData)(vlTOPp->top__DOT__alu_b) 
		    ^ (IData)(vlTOPp->alu_comp_b)) 
		   ^ (IData)(vlTOPp->top__DOT__alu_a)) 
		  & (IData)(vlTOPp->top__DOT__alu_inst__DOT__cc)) 
		 | (((IData)(vlTOPp->top__DOT__alu_b) 
		     ^ (IData)(vlTOPp->alu_comp_b)) 
		    & (IData)(vlTOPp->top__DOT__alu_a))));
    vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__co 
	= (1U & ((((((IData)(vlTOPp->top__DOT__alu_b) 
		     >> 1U) ^ (IData)(vlTOPp->alu_comp_b)) 
		   ^ ((IData)(vlTOPp->top__DOT__alu_a) 
		      >> 1U)) & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				 >> 1U)) | ((((IData)(vlTOPp->top__DOT__alu_b) 
					      >> 1U) 
					     ^ (IData)(vlTOPp->alu_comp_b)) 
					    & ((IData)(vlTOPp->top__DOT__alu_a) 
					       >> 1U))));
    vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__co 
	= (1U & ((((((IData)(vlTOPp->top__DOT__alu_b) 
		     >> 2U) ^ (IData)(vlTOPp->alu_comp_b)) 
		   ^ ((IData)(vlTOPp->top__DOT__alu_a) 
		      >> 2U)) & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				 >> 2U)) | ((((IData)(vlTOPp->top__DOT__alu_b) 
					      >> 2U) 
					     ^ (IData)(vlTOPp->alu_comp_b)) 
					    & ((IData)(vlTOPp->top__DOT__alu_a) 
					       >> 2U))));
    vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__co 
	= (1U & ((((((IData)(vlTOPp->top__DOT__alu_b) 
		     >> 3U) ^ (IData)(vlTOPp->alu_comp_b)) 
		   ^ ((IData)(vlTOPp->top__DOT__alu_a) 
		      >> 3U)) & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				 >> 3U)) | ((((IData)(vlTOPp->top__DOT__alu_b) 
					      >> 3U) 
					     ^ (IData)(vlTOPp->alu_comp_b)) 
					    & ((IData)(vlTOPp->top__DOT__alu_a) 
					       >> 3U))));
    vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__co 
	= (1U & ((((((IData)(vlTOPp->top__DOT__alu_b) 
		     >> 4U) ^ (IData)(vlTOPp->alu_comp_b)) 
		   ^ ((IData)(vlTOPp->top__DOT__alu_a) 
		      >> 4U)) & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				 >> 4U)) | ((((IData)(vlTOPp->top__DOT__alu_b) 
					      >> 4U) 
					     ^ (IData)(vlTOPp->alu_comp_b)) 
					    & ((IData)(vlTOPp->top__DOT__alu_a) 
					       >> 4U))));
    vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__co 
	= (1U & ((((((IData)(vlTOPp->top__DOT__alu_b) 
		     >> 5U) ^ (IData)(vlTOPp->alu_comp_b)) 
		   ^ ((IData)(vlTOPp->top__DOT__alu_a) 
		      >> 5U)) & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				 >> 5U)) | ((((IData)(vlTOPp->top__DOT__alu_b) 
					      >> 5U) 
					     ^ (IData)(vlTOPp->alu_comp_b)) 
					    & ((IData)(vlTOPp->top__DOT__alu_a) 
					       >> 5U))));
    vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__co 
	= (1U & ((((((IData)(vlTOPp->top__DOT__alu_b) 
		     >> 6U) ^ (IData)(vlTOPp->alu_comp_b)) 
		   ^ ((IData)(vlTOPp->top__DOT__alu_a) 
		      >> 6U)) & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				 >> 6U)) | ((((IData)(vlTOPp->top__DOT__alu_b) 
					      >> 6U) 
					     ^ (IData)(vlTOPp->alu_comp_b)) 
					    & ((IData)(vlTOPp->top__DOT__alu_a) 
					       >> 6U))));
    vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__co 
	= (1U & ((((((IData)(vlTOPp->top__DOT__alu_b) 
		     >> 7U) ^ (IData)(vlTOPp->alu_comp_b)) 
		   ^ ((IData)(vlTOPp->top__DOT__alu_a) 
		      >> 7U)) & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				 >> 7U)) | ((((IData)(vlTOPp->top__DOT__alu_b) 
					      >> 7U) 
					     ^ (IData)(vlTOPp->alu_comp_b)) 
					    & ((IData)(vlTOPp->top__DOT__alu_a) 
					       >> 7U))));
    // ALWAYS at alu1.v:13
    vlTOPp->__Vtableidx1 = ((0x20U & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				      << 5U)) | (((IData)(vlTOPp->alu_comp_b) 
						  << 4U) 
						 | ((8U 
						     & ((IData)(vlTOPp->top__DOT__alu_b) 
							<< 3U)) 
						    | ((4U 
							& ((IData)(vlTOPp->top__DOT__alu_a) 
							   << 2U)) 
						       | (IData)(vlTOPp->alu_func)))));
    vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q 
	= vlTOPp->__Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q
	[vlTOPp->__Vtableidx1];
    // ALWAYS at alu1.v:13
    vlTOPp->__Vtableidx2 = ((0x20U & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				      << 4U)) | (((IData)(vlTOPp->alu_comp_b) 
						  << 4U) 
						 | ((8U 
						     & ((IData)(vlTOPp->top__DOT__alu_b) 
							<< 2U)) 
						    | ((4U 
							& ((IData)(vlTOPp->top__DOT__alu_a) 
							   << 1U)) 
						       | (IData)(vlTOPp->alu_func)))));
    vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q 
	= vlTOPp->__Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q
	[vlTOPp->__Vtableidx2];
    // ALWAYS at alu1.v:13
    vlTOPp->__Vtableidx3 = ((0x20U & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				      << 3U)) | (((IData)(vlTOPp->alu_comp_b) 
						  << 4U) 
						 | ((8U 
						     & ((IData)(vlTOPp->top__DOT__alu_b) 
							<< 1U)) 
						    | ((4U 
							& (IData)(vlTOPp->top__DOT__alu_a)) 
						       | (IData)(vlTOPp->alu_func)))));
    vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q 
	= vlTOPp->__Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q
	[vlTOPp->__Vtableidx3];
    // ALWAYS at alu1.v:13
    vlTOPp->__Vtableidx4 = ((0x20U & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				      << 2U)) | (((IData)(vlTOPp->alu_comp_b) 
						  << 4U) 
						 | ((8U 
						     & (IData)(vlTOPp->top__DOT__alu_b)) 
						    | ((4U 
							& ((IData)(vlTOPp->top__DOT__alu_a) 
							   >> 1U)) 
						       | (IData)(vlTOPp->alu_func)))));
    vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q 
	= vlTOPp->__Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q
	[vlTOPp->__Vtableidx4];
    // ALWAYS at alu1.v:13
    vlTOPp->__Vtableidx5 = ((0x20U & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				      << 1U)) | (((IData)(vlTOPp->alu_comp_b) 
						  << 4U) 
						 | ((8U 
						     & ((IData)(vlTOPp->top__DOT__alu_b) 
							>> 1U)) 
						    | ((4U 
							& ((IData)(vlTOPp->top__DOT__alu_a) 
							   >> 2U)) 
						       | (IData)(vlTOPp->alu_func)))));
    vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q 
	= vlTOPp->__Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q
	[vlTOPp->__Vtableidx5];
    // ALWAYS at alu1.v:13
    vlTOPp->__Vtableidx6 = ((0x20U & (IData)(vlTOPp->top__DOT__alu_inst__DOT__cc)) 
			    | (((IData)(vlTOPp->alu_comp_b) 
				<< 4U) | ((8U & ((IData)(vlTOPp->top__DOT__alu_b) 
						 >> 2U)) 
					  | ((4U & 
					      ((IData)(vlTOPp->top__DOT__alu_a) 
					       >> 3U)) 
					     | (IData)(vlTOPp->alu_func)))));
    vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q 
	= vlTOPp->__Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q
	[vlTOPp->__Vtableidx6];
    // ALWAYS at alu1.v:13
    vlTOPp->__Vtableidx7 = ((0x20U & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				      >> 1U)) | (((IData)(vlTOPp->alu_comp_b) 
						  << 4U) 
						 | ((8U 
						     & ((IData)(vlTOPp->top__DOT__alu_b) 
							>> 3U)) 
						    | ((4U 
							& ((IData)(vlTOPp->top__DOT__alu_a) 
							   >> 4U)) 
						       | (IData)(vlTOPp->alu_func)))));
    vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q 
	= vlTOPp->__Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q
	[vlTOPp->__Vtableidx7];
    // ALWAYS at alu1.v:13
    vlTOPp->__Vtableidx8 = ((0x20U & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				      >> 2U)) | (((IData)(vlTOPp->alu_comp_b) 
						  << 4U) 
						 | ((8U 
						     & ((IData)(vlTOPp->top__DOT__alu_b) 
							>> 4U)) 
						    | ((4U 
							& ((IData)(vlTOPp->top__DOT__alu_a) 
							   >> 5U)) 
						       | (IData)(vlTOPp->alu_func)))));
    vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q 
	= vlTOPp->__Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q
	[vlTOPp->__Vtableidx8];
}

VL_INLINE_OPT void Vtop::_combo__TOP__20(Vtop__Syms* __restrict vlSymsp) {
    VL_DEBUG_IF(VL_PRINTF("    Vtop::_combo__TOP__20\n"); );
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    // Body
    vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__co 
	= (1U & (((((IData)(vlTOPp->top__DOT__alu_b) 
		    ^ (IData)(vlTOPp->alu_comp_b)) 
		   ^ (IData)(vlTOPp->top__DOT__alu_a)) 
		  & (IData)(vlTOPp->top__DOT__alu_inst__DOT__cc)) 
		 | (((IData)(vlTOPp->top__DOT__alu_b) 
		     ^ (IData)(vlTOPp->alu_comp_b)) 
		    & (IData)(vlTOPp->top__DOT__alu_a))));
    vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__co 
	= (1U & ((((((IData)(vlTOPp->top__DOT__alu_b) 
		     >> 1U) ^ (IData)(vlTOPp->alu_comp_b)) 
		   ^ ((IData)(vlTOPp->top__DOT__alu_a) 
		      >> 1U)) & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				 >> 1U)) | ((((IData)(vlTOPp->top__DOT__alu_b) 
					      >> 1U) 
					     ^ (IData)(vlTOPp->alu_comp_b)) 
					    & ((IData)(vlTOPp->top__DOT__alu_a) 
					       >> 1U))));
    vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__co 
	= (1U & ((((((IData)(vlTOPp->top__DOT__alu_b) 
		     >> 2U) ^ (IData)(vlTOPp->alu_comp_b)) 
		   ^ ((IData)(vlTOPp->top__DOT__alu_a) 
		      >> 2U)) & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				 >> 2U)) | ((((IData)(vlTOPp->top__DOT__alu_b) 
					      >> 2U) 
					     ^ (IData)(vlTOPp->alu_comp_b)) 
					    & ((IData)(vlTOPp->top__DOT__alu_a) 
					       >> 2U))));
    vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__co 
	= (1U & ((((((IData)(vlTOPp->top__DOT__alu_b) 
		     >> 3U) ^ (IData)(vlTOPp->alu_comp_b)) 
		   ^ ((IData)(vlTOPp->top__DOT__alu_a) 
		      >> 3U)) & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				 >> 3U)) | ((((IData)(vlTOPp->top__DOT__alu_b) 
					      >> 3U) 
					     ^ (IData)(vlTOPp->alu_comp_b)) 
					    & ((IData)(vlTOPp->top__DOT__alu_a) 
					       >> 3U))));
    vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__co 
	= (1U & ((((((IData)(vlTOPp->top__DOT__alu_b) 
		     >> 4U) ^ (IData)(vlTOPp->alu_comp_b)) 
		   ^ ((IData)(vlTOPp->top__DOT__alu_a) 
		      >> 4U)) & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				 >> 4U)) | ((((IData)(vlTOPp->top__DOT__alu_b) 
					      >> 4U) 
					     ^ (IData)(vlTOPp->alu_comp_b)) 
					    & ((IData)(vlTOPp->top__DOT__alu_a) 
					       >> 4U))));
    vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__co 
	= (1U & ((((((IData)(vlTOPp->top__DOT__alu_b) 
		     >> 5U) ^ (IData)(vlTOPp->alu_comp_b)) 
		   ^ ((IData)(vlTOPp->top__DOT__alu_a) 
		      >> 5U)) & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				 >> 5U)) | ((((IData)(vlTOPp->top__DOT__alu_b) 
					      >> 5U) 
					     ^ (IData)(vlTOPp->alu_comp_b)) 
					    & ((IData)(vlTOPp->top__DOT__alu_a) 
					       >> 5U))));
    vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__co 
	= (1U & ((((((IData)(vlTOPp->top__DOT__alu_b) 
		     >> 6U) ^ (IData)(vlTOPp->alu_comp_b)) 
		   ^ ((IData)(vlTOPp->top__DOT__alu_a) 
		      >> 6U)) & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				 >> 6U)) | ((((IData)(vlTOPp->top__DOT__alu_b) 
					      >> 6U) 
					     ^ (IData)(vlTOPp->alu_comp_b)) 
					    & ((IData)(vlTOPp->top__DOT__alu_a) 
					       >> 6U))));
    vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__co 
	= (1U & ((((((IData)(vlTOPp->top__DOT__alu_b) 
		     >> 7U) ^ (IData)(vlTOPp->alu_comp_b)) 
		   ^ ((IData)(vlTOPp->top__DOT__alu_a) 
		      >> 7U)) & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				 >> 7U)) | ((((IData)(vlTOPp->top__DOT__alu_b) 
					      >> 7U) 
					     ^ (IData)(vlTOPp->alu_comp_b)) 
					    & ((IData)(vlTOPp->top__DOT__alu_a) 
					       >> 7U))));
    // ALWAYS at alu1.v:13
    vlTOPp->__Vtableidx1 = ((0x20U & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				      << 5U)) | (((IData)(vlTOPp->alu_comp_b) 
						  << 4U) 
						 | ((8U 
						     & ((IData)(vlTOPp->top__DOT__alu_b) 
							<< 3U)) 
						    | ((4U 
							& ((IData)(vlTOPp->top__DOT__alu_a) 
							   << 2U)) 
						       | (IData)(vlTOPp->alu_func)))));
    vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q 
	= vlTOPp->__Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q
	[vlTOPp->__Vtableidx1];
    // ALWAYS at alu1.v:13
    vlTOPp->__Vtableidx2 = ((0x20U & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				      << 4U)) | (((IData)(vlTOPp->alu_comp_b) 
						  << 4U) 
						 | ((8U 
						     & ((IData)(vlTOPp->top__DOT__alu_b) 
							<< 2U)) 
						    | ((4U 
							& ((IData)(vlTOPp->top__DOT__alu_a) 
							   << 1U)) 
						       | (IData)(vlTOPp->alu_func)))));
    vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q 
	= vlTOPp->__Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q
	[vlTOPp->__Vtableidx2];
    // ALWAYS at alu1.v:13
    vlTOPp->__Vtableidx3 = ((0x20U & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				      << 3U)) | (((IData)(vlTOPp->alu_comp_b) 
						  << 4U) 
						 | ((8U 
						     & ((IData)(vlTOPp->top__DOT__alu_b) 
							<< 1U)) 
						    | ((4U 
							& (IData)(vlTOPp->top__DOT__alu_a)) 
						       | (IData)(vlTOPp->alu_func)))));
    vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q 
	= vlTOPp->__Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q
	[vlTOPp->__Vtableidx3];
    // ALWAYS at alu1.v:13
    vlTOPp->__Vtableidx4 = ((0x20U & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				      << 2U)) | (((IData)(vlTOPp->alu_comp_b) 
						  << 4U) 
						 | ((8U 
						     & (IData)(vlTOPp->top__DOT__alu_b)) 
						    | ((4U 
							& ((IData)(vlTOPp->top__DOT__alu_a) 
							   >> 1U)) 
						       | (IData)(vlTOPp->alu_func)))));
    vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q 
	= vlTOPp->__Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q
	[vlTOPp->__Vtableidx4];
    // ALWAYS at alu1.v:13
    vlTOPp->__Vtableidx5 = ((0x20U & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				      << 1U)) | (((IData)(vlTOPp->alu_comp_b) 
						  << 4U) 
						 | ((8U 
						     & ((IData)(vlTOPp->top__DOT__alu_b) 
							>> 1U)) 
						    | ((4U 
							& ((IData)(vlTOPp->top__DOT__alu_a) 
							   >> 2U)) 
						       | (IData)(vlTOPp->alu_func)))));
    vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q 
	= vlTOPp->__Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q
	[vlTOPp->__Vtableidx5];
    // ALWAYS at alu1.v:13
    vlTOPp->__Vtableidx6 = ((0x20U & (IData)(vlTOPp->top__DOT__alu_inst__DOT__cc)) 
			    | (((IData)(vlTOPp->alu_comp_b) 
				<< 4U) | ((8U & ((IData)(vlTOPp->top__DOT__alu_b) 
						 >> 2U)) 
					  | ((4U & 
					      ((IData)(vlTOPp->top__DOT__alu_a) 
					       >> 3U)) 
					     | (IData)(vlTOPp->alu_func)))));
    vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q 
	= vlTOPp->__Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q
	[vlTOPp->__Vtableidx6];
    // ALWAYS at alu1.v:13
    vlTOPp->__Vtableidx7 = ((0x20U & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				      >> 1U)) | (((IData)(vlTOPp->alu_comp_b) 
						  << 4U) 
						 | ((8U 
						     & ((IData)(vlTOPp->top__DOT__alu_b) 
							>> 3U)) 
						    | ((4U 
							& ((IData)(vlTOPp->top__DOT__alu_a) 
							   >> 4U)) 
						       | (IData)(vlTOPp->alu_func)))));
    vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q 
	= vlTOPp->__Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q
	[vlTOPp->__Vtableidx7];
    // ALWAYS at alu1.v:13
    vlTOPp->__Vtableidx8 = ((0x20U & ((IData)(vlTOPp->top__DOT__alu_inst__DOT__cc) 
				      >> 2U)) | (((IData)(vlTOPp->alu_comp_b) 
						  << 4U) 
						 | ((8U 
						     & ((IData)(vlTOPp->top__DOT__alu_b) 
							>> 4U)) 
						    | ((4U 
							& ((IData)(vlTOPp->top__DOT__alu_a) 
							   >> 5U)) 
						       | (IData)(vlTOPp->alu_func)))));
    vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q 
	= vlTOPp->__Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q
	[vlTOPp->__Vtableidx8];
    vlTOPp->top__DOT__alu_inst__DOT__cc = ((0x1fdU 
					    & (IData)(vlTOPp->top__DOT__alu_inst__DOT__cc)) 
					   | ((IData)(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__co) 
					      << 1U));
    vlTOPp->top__DOT__alu_inst__DOT__cc = ((0x1fbU 
					    & (IData)(vlTOPp->top__DOT__alu_inst__DOT__cc)) 
					   | ((IData)(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__co) 
					      << 2U));
    vlTOPp->top__DOT__alu_inst__DOT__cc = ((0x1f7U 
					    & (IData)(vlTOPp->top__DOT__alu_inst__DOT__cc)) 
					   | ((IData)(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__co) 
					      << 3U));
    vlTOPp->top__DOT__alu_inst__DOT__cc = ((0x1efU 
					    & (IData)(vlTOPp->top__DOT__alu_inst__DOT__cc)) 
					   | ((IData)(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__co) 
					      << 4U));
    vlTOPp->top__DOT__alu_inst__DOT__cc = ((0x1dfU 
					    & (IData)(vlTOPp->top__DOT__alu_inst__DOT__cc)) 
					   | ((IData)(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__co) 
					      << 5U));
    vlTOPp->top__DOT__alu_inst__DOT__cc = ((0x1bfU 
					    & (IData)(vlTOPp->top__DOT__alu_inst__DOT__cc)) 
					   | ((IData)(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__co) 
					      << 6U));
    vlTOPp->top__DOT__alu_inst__DOT__cc = ((0x17fU 
					    & (IData)(vlTOPp->top__DOT__alu_inst__DOT__cc)) 
					   | ((IData)(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__co) 
					      << 7U));
    vlTOPp->top__DOT__alu_inst__DOT__cc = ((0xffU & (IData)(vlTOPp->top__DOT__alu_inst__DOT__cc)) 
					   | ((IData)(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__co) 
					      << 8U));
    vlTOPp->top__DOT__alu_q = ((0xfeU & (IData)(vlTOPp->top__DOT__alu_q)) 
			       | (IData)(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q));
    vlTOPp->top__DOT__alu_q = ((0xfdU & (IData)(vlTOPp->top__DOT__alu_q)) 
			       | ((IData)(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q) 
				  << 1U));
    vlTOPp->top__DOT__alu_q = ((0xfbU & (IData)(vlTOPp->top__DOT__alu_q)) 
			       | ((IData)(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q) 
				  << 2U));
    vlTOPp->top__DOT__alu_q = ((0xf7U & (IData)(vlTOPp->top__DOT__alu_q)) 
			       | ((IData)(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q) 
				  << 3U));
    vlTOPp->top__DOT__alu_q = ((0xefU & (IData)(vlTOPp->top__DOT__alu_q)) 
			       | ((IData)(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q) 
				  << 4U));
    vlTOPp->top__DOT__alu_q = ((0xdfU & (IData)(vlTOPp->top__DOT__alu_q)) 
			       | ((IData)(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q) 
				  << 5U));
    vlTOPp->top__DOT__alu_q = ((0xbfU & (IData)(vlTOPp->top__DOT__alu_q)) 
			       | ((IData)(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q) 
				  << 6U));
    vlTOPp->top__DOT__alu_q = ((0x7fU & (IData)(vlTOPp->top__DOT__alu_q)) 
			       | ((IData)(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q) 
				  << 7U));
}

void Vtop::_settle__TOP__21(Vtop__Syms* __restrict vlSymsp) {
    VL_DEBUG_IF(VL_PRINTF("    Vtop::_settle__TOP__21\n"); );
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    // Body
    vlTOPp->top__DOT__alu_inst__DOT__cc = ((0x1fdU 
					    & (IData)(vlTOPp->top__DOT__alu_inst__DOT__cc)) 
					   | ((IData)(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__co) 
					      << 1U));
    vlTOPp->top__DOT__alu_inst__DOT__cc = ((0x1fbU 
					    & (IData)(vlTOPp->top__DOT__alu_inst__DOT__cc)) 
					   | ((IData)(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__co) 
					      << 2U));
    vlTOPp->top__DOT__alu_inst__DOT__cc = ((0x1f7U 
					    & (IData)(vlTOPp->top__DOT__alu_inst__DOT__cc)) 
					   | ((IData)(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__co) 
					      << 3U));
    vlTOPp->top__DOT__alu_inst__DOT__cc = ((0x1efU 
					    & (IData)(vlTOPp->top__DOT__alu_inst__DOT__cc)) 
					   | ((IData)(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__co) 
					      << 4U));
    vlTOPp->top__DOT__alu_inst__DOT__cc = ((0x1dfU 
					    & (IData)(vlTOPp->top__DOT__alu_inst__DOT__cc)) 
					   | ((IData)(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__co) 
					      << 5U));
    vlTOPp->top__DOT__alu_inst__DOT__cc = ((0x1bfU 
					    & (IData)(vlTOPp->top__DOT__alu_inst__DOT__cc)) 
					   | ((IData)(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__co) 
					      << 6U));
    vlTOPp->top__DOT__alu_inst__DOT__cc = ((0x17fU 
					    & (IData)(vlTOPp->top__DOT__alu_inst__DOT__cc)) 
					   | ((IData)(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__co) 
					      << 7U));
    vlTOPp->top__DOT__alu_inst__DOT__cc = ((0xffU & (IData)(vlTOPp->top__DOT__alu_inst__DOT__cc)) 
					   | ((IData)(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__co) 
					      << 8U));
    vlTOPp->top__DOT__alu_q = ((0xfeU & (IData)(vlTOPp->top__DOT__alu_q)) 
			       | (IData)(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q));
    vlTOPp->top__DOT__alu_q = ((0xfdU & (IData)(vlTOPp->top__DOT__alu_q)) 
			       | ((IData)(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q) 
				  << 1U));
    vlTOPp->top__DOT__alu_q = ((0xfbU & (IData)(vlTOPp->top__DOT__alu_q)) 
			       | ((IData)(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q) 
				  << 2U));
    vlTOPp->top__DOT__alu_q = ((0xf7U & (IData)(vlTOPp->top__DOT__alu_q)) 
			       | ((IData)(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q) 
				  << 3U));
    vlTOPp->top__DOT__alu_q = ((0xefU & (IData)(vlTOPp->top__DOT__alu_q)) 
			       | ((IData)(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q) 
				  << 4U));
    vlTOPp->top__DOT__alu_q = ((0xdfU & (IData)(vlTOPp->top__DOT__alu_q)) 
			       | ((IData)(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q) 
				  << 5U));
    vlTOPp->top__DOT__alu_q = ((0xbfU & (IData)(vlTOPp->top__DOT__alu_q)) 
			       | ((IData)(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q) 
				  << 6U));
    vlTOPp->top__DOT__alu_q = ((0x7fU & (IData)(vlTOPp->top__DOT__alu_q)) 
			       | ((IData)(vlTOPp->top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q) 
				  << 7U));
    // ALWAYS at mux2x1.v:10
    if (vlTOPp->mbr_alu) {
	if (vlTOPp->mbr_alu) {
	    vlTOPp->top__DOT__reg_in = vlTOPp->top__DOT__umbr_in__DOT__do_r;
	}
    } else {
	vlTOPp->top__DOT__reg_in = vlTOPp->top__DOT__alu_q;
    }
}

VL_INLINE_OPT void Vtop::_combo__TOP__22(Vtop__Syms* __restrict vlSymsp) {
    VL_DEBUG_IF(VL_PRINTF("    Vtop::_combo__TOP__22\n"); );
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    // Body
    // ALWAYS at mux2x1.v:10
    if (vlTOPp->mbr_alu) {
	if (vlTOPp->mbr_alu) {
	    vlTOPp->top__DOT__reg_in = vlTOPp->top__DOT__umbr_in__DOT__do_r;
	}
    } else {
	vlTOPp->top__DOT__reg_in = vlTOPp->top__DOT__alu_q;
    }
}

void Vtop::_eval(Vtop__Syms* __restrict vlSymsp) {
    VL_DEBUG_IF(VL_PRINTF("    Vtop::_eval\n"); );
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    // Body
    if ((((~ (IData)(vlTOPp->mbr_in_we)) & (IData)(vlTOPp->__Vclklast__TOP__mbr_in_we)) 
	 | ((IData)(vlTOPp->reset) & (~ (IData)(vlTOPp->__Vclklast__TOP__reset))))) {
	vlTOPp->_sequent__TOP__1(vlSymsp);
	vlTOPp->__Vm_traceActivity = (2U | vlTOPp->__Vm_traceActivity);
    }
    if (((~ (IData)(vlTOPp->mem_we)) & (IData)(vlTOPp->__Vclklast__TOP__mem_we))) {
	vlTOPp->_sequent__TOP__4(vlSymsp);
    }
    vlTOPp->_combo__TOP__5(vlSymsp);
    vlTOPp->__Vm_traceActivity = (4U | vlTOPp->__Vm_traceActivity);
    if ((((~ (IData)(vlTOPp->mbr_out_we)) & (IData)(vlTOPp->__Vclklast__TOP__mbr_out_we)) 
	 | ((IData)(vlTOPp->reset) & (~ (IData)(vlTOPp->__Vclklast__TOP__reset))))) {
	vlTOPp->_sequent__TOP__7(vlSymsp);
	vlTOPp->__Vm_traceActivity = (8U | vlTOPp->__Vm_traceActivity);
    }
    if ((((~ (IData)(vlTOPp->mar_we)) & (IData)(vlTOPp->__Vclklast__TOP__mar_we)) 
	 | ((IData)(vlTOPp->reset) & (~ (IData)(vlTOPp->__Vclklast__TOP__reset))))) {
	vlTOPp->_sequent__TOP__8(vlSymsp);
	vlTOPp->__Vm_traceActivity = (0x10U | vlTOPp->__Vm_traceActivity);
    }
    vlTOPp->_combo__TOP__9(vlSymsp);
    if (((((~ (IData)(vlTOPp->mar_we)) & (IData)(vlTOPp->__Vclklast__TOP__mar_we)) 
	  | ((~ (IData)(vlTOPp->mem_we)) & (IData)(vlTOPp->__Vclklast__TOP__mem_we))) 
	 | ((IData)(vlTOPp->reset) & (~ (IData)(vlTOPp->__Vclklast__TOP__reset))))) {
	vlTOPp->_multiclk__TOP__10(vlSymsp);
	vlTOPp->__Vm_traceActivity = (0x20U | vlTOPp->__Vm_traceActivity);
    }
    if ((((IData)(vlTOPp->reset) & (~ (IData)(vlTOPp->__Vclklast__TOP__reset))) 
	 | ((~ (IData)(vlTOPp->top__DOT__register_file__BRA__0__KET____DOT____Vcellinp__register_inst__we)) 
	    & (IData)(vlTOPp->__Vclklast__TOP__top__DOT__register_file__BRA__0__KET____DOT____Vcellinp__register_inst__we)))) {
	vlTOPp->_sequent__TOP__12(vlSymsp);
	vlTOPp->__Vm_traceActivity = (0x40U | vlTOPp->__Vm_traceActivity);
    }
    if ((((IData)(vlTOPp->reset) & (~ (IData)(vlTOPp->__Vclklast__TOP__reset))) 
	 | ((~ (IData)(vlTOPp->top__DOT__register_file__BRA__1__KET____DOT____Vcellinp__register_inst__we)) 
	    & (IData)(vlTOPp->__Vclklast__TOP__top__DOT__register_file__BRA__1__KET____DOT____Vcellinp__register_inst__we)))) {
	vlTOPp->_sequent__TOP__13(vlSymsp);
	vlTOPp->__Vm_traceActivity = (0x80U | vlTOPp->__Vm_traceActivity);
    }
    if ((((IData)(vlTOPp->reset) & (~ (IData)(vlTOPp->__Vclklast__TOP__reset))) 
	 | ((~ (IData)(vlTOPp->top__DOT__register_file__BRA__2__KET____DOT____Vcellinp__register_inst__we)) 
	    & (IData)(vlTOPp->__Vclklast__TOP__top__DOT__register_file__BRA__2__KET____DOT____Vcellinp__register_inst__we)))) {
	vlTOPp->_sequent__TOP__14(vlSymsp);
	vlTOPp->__Vm_traceActivity = (0x100U | vlTOPp->__Vm_traceActivity);
    }
    if ((((IData)(vlTOPp->reset) & (~ (IData)(vlTOPp->__Vclklast__TOP__reset))) 
	 | ((~ (IData)(vlTOPp->top__DOT__register_file__BRA__3__KET____DOT____Vcellinp__register_inst__we)) 
	    & (IData)(vlTOPp->__Vclklast__TOP__top__DOT__register_file__BRA__3__KET____DOT____Vcellinp__register_inst__we)))) {
	vlTOPp->_sequent__TOP__15(vlSymsp);
	vlTOPp->__Vm_traceActivity = (0x200U | vlTOPp->__Vm_traceActivity);
    }
    if (((((((IData)(vlTOPp->reset) & (~ (IData)(vlTOPp->__Vclklast__TOP__reset))) 
	    | ((~ (IData)(vlTOPp->top__DOT__register_file__BRA__0__KET____DOT____Vcellinp__register_inst__we)) 
	       & (IData)(vlTOPp->__Vclklast__TOP__top__DOT__register_file__BRA__0__KET____DOT____Vcellinp__register_inst__we))) 
	   | ((~ (IData)(vlTOPp->top__DOT__register_file__BRA__1__KET____DOT____Vcellinp__register_inst__we)) 
	      & (IData)(vlTOPp->__Vclklast__TOP__top__DOT__register_file__BRA__1__KET____DOT____Vcellinp__register_inst__we))) 
	  | ((~ (IData)(vlTOPp->top__DOT__register_file__BRA__2__KET____DOT____Vcellinp__register_inst__we)) 
	     & (IData)(vlTOPp->__Vclklast__TOP__top__DOT__register_file__BRA__2__KET____DOT____Vcellinp__register_inst__we))) 
	 | ((~ (IData)(vlTOPp->top__DOT__register_file__BRA__3__KET____DOT____Vcellinp__register_inst__we)) 
	    & (IData)(vlTOPp->__Vclklast__TOP__top__DOT__register_file__BRA__3__KET____DOT____Vcellinp__register_inst__we)))) {
	vlTOPp->_multiclk__TOP__17(vlSymsp);
	vlTOPp->__Vm_traceActivity = (0x400U | vlTOPp->__Vm_traceActivity);
    }
    vlTOPp->_combo__TOP__18(vlSymsp);
    vlTOPp->_combo__TOP__20(vlSymsp);
    vlTOPp->_combo__TOP__22(vlSymsp);
    // Final
    vlTOPp->__Vclklast__TOP__mbr_in_we = vlTOPp->mbr_in_we;
    vlTOPp->__Vclklast__TOP__reset = vlTOPp->reset;
    vlTOPp->__Vclklast__TOP__mbr_out_we = vlTOPp->mbr_out_we;
    vlTOPp->__Vclklast__TOP__mar_we = vlTOPp->mar_we;
    vlTOPp->__Vclklast__TOP__mem_we = vlTOPp->mem_we;
    vlTOPp->__Vclklast__TOP__top__DOT__register_file__BRA__0__KET____DOT____Vcellinp__register_inst__we 
	= vlTOPp->top__DOT__register_file__BRA__0__KET____DOT____Vcellinp__register_inst__we;
    vlTOPp->__Vclklast__TOP__top__DOT__register_file__BRA__1__KET____DOT____Vcellinp__register_inst__we 
	= vlTOPp->top__DOT__register_file__BRA__1__KET____DOT____Vcellinp__register_inst__we;
    vlTOPp->__Vclklast__TOP__top__DOT__register_file__BRA__2__KET____DOT____Vcellinp__register_inst__we 
	= vlTOPp->top__DOT__register_file__BRA__2__KET____DOT____Vcellinp__register_inst__we;
    vlTOPp->__Vclklast__TOP__top__DOT__register_file__BRA__3__KET____DOT____Vcellinp__register_inst__we 
	= vlTOPp->top__DOT__register_file__BRA__3__KET____DOT____Vcellinp__register_inst__we;
}

void Vtop::_eval_initial(Vtop__Syms* __restrict vlSymsp) {
    VL_DEBUG_IF(VL_PRINTF("    Vtop::_eval_initial\n"); );
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
}

void Vtop::final() {
    VL_DEBUG_IF(VL_PRINTF("    Vtop::final\n"); );
    // Variables
    Vtop__Syms* __restrict vlSymsp = this->__VlSymsp;
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
}

void Vtop::_eval_settle(Vtop__Syms* __restrict vlSymsp) {
    VL_DEBUG_IF(VL_PRINTF("    Vtop::_eval_settle\n"); );
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    // Body
    vlTOPp->_settle__TOP__6(vlSymsp);
    vlTOPp->__Vm_traceActivity = (1U | vlTOPp->__Vm_traceActivity);
    vlTOPp->_settle__TOP__11(vlSymsp);
    vlTOPp->_settle__TOP__16(vlSymsp);
    vlTOPp->_settle__TOP__19(vlSymsp);
    vlTOPp->_settle__TOP__21(vlSymsp);
}

VL_INLINE_OPT QData Vtop::_change_request(Vtop__Syms* __restrict vlSymsp) {
    VL_DEBUG_IF(VL_PRINTF("    Vtop::_change_request\n"); );
    Vtop* __restrict vlTOPp VL_ATTR_UNUSED = vlSymsp->TOPp;
    // Body
    // Change detection
    QData __req = false;  // Logically a bool
    __req |= ((vlTOPp->top__DOT__alu_inst__DOT__cc ^ vlTOPp->__Vchglast__TOP__top__DOT__alu_inst__DOT__cc));
    VL_DEBUG_IF( if(__req && ((vlTOPp->top__DOT__alu_inst__DOT__cc ^ vlTOPp->__Vchglast__TOP__top__DOT__alu_inst__DOT__cc))) VL_PRINTF("	CHANGE: alu.v:15: top.alu_inst.cc\n"); );
    // Final
    vlTOPp->__Vchglast__TOP__top__DOT__alu_inst__DOT__cc 
	= vlTOPp->top__DOT__alu_inst__DOT__cc;
    return __req;
}

void Vtop::_ctor_var_reset() {
    VL_DEBUG_IF(VL_PRINTF("    Vtop::_ctor_var_reset\n"); );
    // Body
    reset = VL_RAND_RESET_I(1);
    reg_addr_we = VL_RAND_RESET_I(2);
    reg_we = VL_RAND_RESET_I(1);
    mar_we = VL_RAND_RESET_I(1);
    mbr_out_we = VL_RAND_RESET_I(1);
    mbr_in_we = VL_RAND_RESET_I(1);
    mem_we = VL_RAND_RESET_I(1);
    mbr_alu = VL_RAND_RESET_I(1);
    alu_func = VL_RAND_RESET_I(2);
    alu_comp_b = VL_RAND_RESET_I(1);
    alu_ci = VL_RAND_RESET_I(1);
    alu_reg_a = VL_RAND_RESET_I(2);
    alu_reg_b = VL_RAND_RESET_I(2);
    alu_so = VL_RAND_RESET_I(1);
    alu_uo = VL_RAND_RESET_I(1);
    { int __Vi0=0; for (; __Vi0<4; ++__Vi0) {
	    top__DOT__regout[__Vi0] = VL_RAND_RESET_I(8);
    }}
    top__DOT__regwe = VL_RAND_RESET_I(4);
    top__DOT__alu_a = VL_RAND_RESET_I(8);
    top__DOT__alu_b = VL_RAND_RESET_I(8);
    top__DOT__alu_q = VL_RAND_RESET_I(8);
    top__DOT__reg_in = VL_RAND_RESET_I(8);
    top__DOT__d_in = VL_RAND_RESET_I(8);
    top__DOT____Vcellinp__amux_inst__i3 = VL_RAND_RESET_I(8);
    top__DOT____Vcellinp__amux_inst__i2 = VL_RAND_RESET_I(8);
    top__DOT____Vcellinp__amux_inst__i1 = VL_RAND_RESET_I(8);
    top__DOT____Vcellinp__amux_inst__i0 = VL_RAND_RESET_I(8);
    top__DOT____Vcellinp__bmux_inst__i3 = VL_RAND_RESET_I(8);
    top__DOT____Vcellinp__bmux_inst__i2 = VL_RAND_RESET_I(8);
    top__DOT____Vcellinp__bmux_inst__i1 = VL_RAND_RESET_I(8);
    top__DOT____Vcellinp__bmux_inst__i0 = VL_RAND_RESET_I(8);
    top__DOT____Vcellout__demux_inst__o3 = VL_RAND_RESET_I(1);
    top__DOT____Vcellout__demux_inst__o2 = VL_RAND_RESET_I(1);
    top__DOT____Vcellout__demux_inst__o1 = VL_RAND_RESET_I(1);
    top__DOT____Vcellout__demux_inst__o0 = VL_RAND_RESET_I(1);
    top__DOT__register_file__BRA__0__KET____DOT____Vcellinp__register_inst__we = VL_RAND_RESET_I(1);
    top__DOT__register_file__BRA__1__KET____DOT____Vcellinp__register_inst__we = VL_RAND_RESET_I(1);
    top__DOT__register_file__BRA__2__KET____DOT____Vcellinp__register_inst__we = VL_RAND_RESET_I(1);
    top__DOT__register_file__BRA__3__KET____DOT____Vcellinp__register_inst__we = VL_RAND_RESET_I(1);
    top__DOT__alu_inst__DOT__cc = VL_RAND_RESET_I(9);
    top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q = VL_RAND_RESET_I(1);
    top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__co = VL_RAND_RESET_I(1);
    top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q = VL_RAND_RESET_I(1);
    top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__co = VL_RAND_RESET_I(1);
    top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q = VL_RAND_RESET_I(1);
    top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__co = VL_RAND_RESET_I(1);
    top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q = VL_RAND_RESET_I(1);
    top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__co = VL_RAND_RESET_I(1);
    top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q = VL_RAND_RESET_I(1);
    top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__co = VL_RAND_RESET_I(1);
    top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q = VL_RAND_RESET_I(1);
    top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__co = VL_RAND_RESET_I(1);
    top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q = VL_RAND_RESET_I(1);
    top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__co = VL_RAND_RESET_I(1);
    top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q = VL_RAND_RESET_I(1);
    top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__co = VL_RAND_RESET_I(1);
    top__DOT__umar__DOT__do_r = VL_RAND_RESET_I(8);
    top__DOT__umbr_out__DOT__do_r = VL_RAND_RESET_I(8);
    top__DOT__umbr_in__DOT__do_r = VL_RAND_RESET_I(8);
    { int __Vi0=0; for (; __Vi0<256; ++__Vi0) {
	    top__DOT__umem__DOT__do_r[__Vi0] = VL_RAND_RESET_I(8);
    }}
    top__DOT__register_file__BRA__0__KET____DOT__register_inst__DOT__do_r = VL_RAND_RESET_I(8);
    top__DOT__register_file__BRA__1__KET____DOT__register_inst__DOT__do_r = VL_RAND_RESET_I(8);
    top__DOT__register_file__BRA__2__KET____DOT__register_inst__DOT__do_r = VL_RAND_RESET_I(8);
    top__DOT__register_file__BRA__3__KET____DOT__register_inst__DOT__do_r = VL_RAND_RESET_I(8);
    __Vtableidx1 = VL_RAND_RESET_I(6);
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[0] = 0U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[1] = 0U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[2] = 0U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[3] = 0U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[4] = 1U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[5] = 1U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[6] = 0U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[7] = 1U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[8] = 1U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[9] = 1U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[10] = 0U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[11] = 1U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[12] = 0U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[13] = 0U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[14] = 1U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[15] = 1U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[16] = 1U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[17] = 1U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[18] = 0U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[19] = 1U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[20] = 0U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[21] = 0U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[22] = 1U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[23] = 1U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[24] = 0U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[25] = 0U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[26] = 0U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[27] = 0U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[28] = 1U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[29] = 1U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[30] = 0U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[31] = 1U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[32] = 1U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[33] = 0U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[34] = 0U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[35] = 0U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[36] = 0U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[37] = 1U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[38] = 0U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[39] = 1U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[40] = 0U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[41] = 1U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[42] = 0U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[43] = 1U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[44] = 1U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[45] = 0U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[46] = 1U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[47] = 1U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[48] = 0U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[49] = 1U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[50] = 0U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[51] = 1U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[52] = 1U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[53] = 0U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[54] = 1U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[55] = 1U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[56] = 1U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[57] = 0U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[58] = 0U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[59] = 0U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[60] = 0U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[61] = 1U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[62] = 0U;
    __Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[63] = 1U;
    __Vtableidx2 = VL_RAND_RESET_I(6);
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[0] = 0U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[1] = 0U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[2] = 0U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[3] = 0U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[4] = 1U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[5] = 1U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[6] = 0U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[7] = 1U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[8] = 1U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[9] = 1U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[10] = 0U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[11] = 1U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[12] = 0U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[13] = 0U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[14] = 1U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[15] = 1U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[16] = 1U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[17] = 1U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[18] = 0U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[19] = 1U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[20] = 0U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[21] = 0U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[22] = 1U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[23] = 1U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[24] = 0U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[25] = 0U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[26] = 0U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[27] = 0U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[28] = 1U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[29] = 1U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[30] = 0U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[31] = 1U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[32] = 1U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[33] = 0U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[34] = 0U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[35] = 0U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[36] = 0U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[37] = 1U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[38] = 0U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[39] = 1U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[40] = 0U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[41] = 1U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[42] = 0U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[43] = 1U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[44] = 1U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[45] = 0U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[46] = 1U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[47] = 1U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[48] = 0U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[49] = 1U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[50] = 0U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[51] = 1U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[52] = 1U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[53] = 0U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[54] = 1U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[55] = 1U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[56] = 1U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[57] = 0U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[58] = 0U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[59] = 0U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[60] = 0U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[61] = 1U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[62] = 0U;
    __Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[63] = 1U;
    __Vtableidx3 = VL_RAND_RESET_I(6);
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[0] = 0U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[1] = 0U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[2] = 0U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[3] = 0U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[4] = 1U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[5] = 1U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[6] = 0U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[7] = 1U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[8] = 1U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[9] = 1U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[10] = 0U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[11] = 1U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[12] = 0U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[13] = 0U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[14] = 1U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[15] = 1U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[16] = 1U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[17] = 1U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[18] = 0U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[19] = 1U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[20] = 0U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[21] = 0U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[22] = 1U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[23] = 1U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[24] = 0U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[25] = 0U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[26] = 0U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[27] = 0U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[28] = 1U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[29] = 1U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[30] = 0U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[31] = 1U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[32] = 1U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[33] = 0U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[34] = 0U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[35] = 0U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[36] = 0U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[37] = 1U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[38] = 0U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[39] = 1U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[40] = 0U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[41] = 1U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[42] = 0U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[43] = 1U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[44] = 1U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[45] = 0U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[46] = 1U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[47] = 1U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[48] = 0U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[49] = 1U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[50] = 0U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[51] = 1U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[52] = 1U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[53] = 0U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[54] = 1U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[55] = 1U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[56] = 1U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[57] = 0U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[58] = 0U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[59] = 0U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[60] = 0U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[61] = 1U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[62] = 0U;
    __Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[63] = 1U;
    __Vtableidx4 = VL_RAND_RESET_I(6);
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[0] = 0U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[1] = 0U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[2] = 0U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[3] = 0U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[4] = 1U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[5] = 1U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[6] = 0U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[7] = 1U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[8] = 1U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[9] = 1U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[10] = 0U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[11] = 1U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[12] = 0U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[13] = 0U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[14] = 1U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[15] = 1U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[16] = 1U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[17] = 1U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[18] = 0U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[19] = 1U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[20] = 0U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[21] = 0U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[22] = 1U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[23] = 1U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[24] = 0U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[25] = 0U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[26] = 0U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[27] = 0U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[28] = 1U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[29] = 1U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[30] = 0U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[31] = 1U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[32] = 1U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[33] = 0U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[34] = 0U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[35] = 0U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[36] = 0U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[37] = 1U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[38] = 0U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[39] = 1U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[40] = 0U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[41] = 1U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[42] = 0U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[43] = 1U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[44] = 1U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[45] = 0U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[46] = 1U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[47] = 1U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[48] = 0U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[49] = 1U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[50] = 0U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[51] = 1U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[52] = 1U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[53] = 0U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[54] = 1U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[55] = 1U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[56] = 1U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[57] = 0U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[58] = 0U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[59] = 0U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[60] = 0U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[61] = 1U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[62] = 0U;
    __Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[63] = 1U;
    __Vtableidx5 = VL_RAND_RESET_I(6);
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[0] = 0U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[1] = 0U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[2] = 0U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[3] = 0U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[4] = 1U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[5] = 1U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[6] = 0U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[7] = 1U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[8] = 1U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[9] = 1U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[10] = 0U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[11] = 1U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[12] = 0U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[13] = 0U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[14] = 1U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[15] = 1U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[16] = 1U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[17] = 1U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[18] = 0U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[19] = 1U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[20] = 0U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[21] = 0U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[22] = 1U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[23] = 1U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[24] = 0U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[25] = 0U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[26] = 0U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[27] = 0U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[28] = 1U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[29] = 1U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[30] = 0U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[31] = 1U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[32] = 1U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[33] = 0U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[34] = 0U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[35] = 0U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[36] = 0U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[37] = 1U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[38] = 0U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[39] = 1U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[40] = 0U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[41] = 1U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[42] = 0U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[43] = 1U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[44] = 1U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[45] = 0U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[46] = 1U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[47] = 1U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[48] = 0U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[49] = 1U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[50] = 0U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[51] = 1U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[52] = 1U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[53] = 0U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[54] = 1U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[55] = 1U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[56] = 1U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[57] = 0U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[58] = 0U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[59] = 0U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[60] = 0U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[61] = 1U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[62] = 0U;
    __Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[63] = 1U;
    __Vtableidx6 = VL_RAND_RESET_I(6);
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[0] = 0U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[1] = 0U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[2] = 0U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[3] = 0U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[4] = 1U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[5] = 1U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[6] = 0U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[7] = 1U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[8] = 1U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[9] = 1U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[10] = 0U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[11] = 1U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[12] = 0U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[13] = 0U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[14] = 1U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[15] = 1U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[16] = 1U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[17] = 1U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[18] = 0U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[19] = 1U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[20] = 0U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[21] = 0U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[22] = 1U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[23] = 1U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[24] = 0U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[25] = 0U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[26] = 0U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[27] = 0U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[28] = 1U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[29] = 1U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[30] = 0U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[31] = 1U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[32] = 1U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[33] = 0U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[34] = 0U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[35] = 0U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[36] = 0U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[37] = 1U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[38] = 0U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[39] = 1U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[40] = 0U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[41] = 1U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[42] = 0U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[43] = 1U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[44] = 1U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[45] = 0U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[46] = 1U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[47] = 1U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[48] = 0U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[49] = 1U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[50] = 0U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[51] = 1U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[52] = 1U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[53] = 0U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[54] = 1U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[55] = 1U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[56] = 1U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[57] = 0U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[58] = 0U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[59] = 0U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[60] = 0U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[61] = 1U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[62] = 0U;
    __Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[63] = 1U;
    __Vtableidx7 = VL_RAND_RESET_I(6);
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[0] = 0U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[1] = 0U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[2] = 0U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[3] = 0U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[4] = 1U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[5] = 1U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[6] = 0U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[7] = 1U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[8] = 1U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[9] = 1U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[10] = 0U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[11] = 1U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[12] = 0U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[13] = 0U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[14] = 1U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[15] = 1U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[16] = 1U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[17] = 1U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[18] = 0U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[19] = 1U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[20] = 0U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[21] = 0U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[22] = 1U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[23] = 1U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[24] = 0U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[25] = 0U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[26] = 0U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[27] = 0U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[28] = 1U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[29] = 1U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[30] = 0U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[31] = 1U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[32] = 1U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[33] = 0U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[34] = 0U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[35] = 0U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[36] = 0U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[37] = 1U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[38] = 0U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[39] = 1U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[40] = 0U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[41] = 1U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[42] = 0U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[43] = 1U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[44] = 1U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[45] = 0U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[46] = 1U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[47] = 1U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[48] = 0U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[49] = 1U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[50] = 0U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[51] = 1U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[52] = 1U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[53] = 0U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[54] = 1U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[55] = 1U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[56] = 1U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[57] = 0U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[58] = 0U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[59] = 0U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[60] = 0U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[61] = 1U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[62] = 0U;
    __Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[63] = 1U;
    __Vtableidx8 = VL_RAND_RESET_I(6);
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[0] = 0U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[1] = 0U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[2] = 0U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[3] = 0U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[4] = 1U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[5] = 1U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[6] = 0U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[7] = 1U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[8] = 1U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[9] = 1U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[10] = 0U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[11] = 1U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[12] = 0U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[13] = 0U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[14] = 1U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[15] = 1U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[16] = 1U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[17] = 1U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[18] = 0U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[19] = 1U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[20] = 0U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[21] = 0U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[22] = 1U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[23] = 1U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[24] = 0U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[25] = 0U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[26] = 0U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[27] = 0U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[28] = 1U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[29] = 1U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[30] = 0U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[31] = 1U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[32] = 1U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[33] = 0U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[34] = 0U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[35] = 0U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[36] = 0U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[37] = 1U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[38] = 0U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[39] = 1U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[40] = 0U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[41] = 1U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[42] = 0U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[43] = 1U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[44] = 1U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[45] = 0U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[46] = 1U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[47] = 1U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[48] = 0U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[49] = 1U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[50] = 0U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[51] = 1U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[52] = 1U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[53] = 0U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[54] = 1U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[55] = 1U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[56] = 1U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[57] = 0U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[58] = 0U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[59] = 0U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[60] = 0U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[61] = 1U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[62] = 0U;
    __Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[63] = 1U;
    __Vclklast__TOP__mbr_in_we = VL_RAND_RESET_I(1);
    __Vclklast__TOP__reset = VL_RAND_RESET_I(1);
    __Vclklast__TOP__mbr_out_we = VL_RAND_RESET_I(1);
    __Vclklast__TOP__mar_we = VL_RAND_RESET_I(1);
    __Vclklast__TOP__mem_we = VL_RAND_RESET_I(1);
    __Vclklast__TOP__top__DOT__register_file__BRA__0__KET____DOT____Vcellinp__register_inst__we = VL_RAND_RESET_I(1);
    __Vclklast__TOP__top__DOT__register_file__BRA__1__KET____DOT____Vcellinp__register_inst__we = VL_RAND_RESET_I(1);
    __Vclklast__TOP__top__DOT__register_file__BRA__2__KET____DOT____Vcellinp__register_inst__we = VL_RAND_RESET_I(1);
    __Vclklast__TOP__top__DOT__register_file__BRA__3__KET____DOT____Vcellinp__register_inst__we = VL_RAND_RESET_I(1);
    __Vchglast__TOP__top__DOT__alu_inst__DOT__cc = VL_RAND_RESET_I(9);
    __Vm_traceActivity = VL_RAND_RESET_I(32);
}

void Vtop::_configure_coverage(Vtop__Syms* __restrict vlSymsp, bool first) {
    VL_DEBUG_IF(VL_PRINTF("    Vtop::_configure_coverage\n"); );
}
