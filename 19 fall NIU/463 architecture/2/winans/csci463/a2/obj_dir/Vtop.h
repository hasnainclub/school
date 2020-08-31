// Verilated -*- C++ -*-
// DESCRIPTION: Verilator output: Primary design header
//
// This header should be included by all source files instantiating the design.
// The class here is then constructed to instantiate the design.
// See the Verilator manual for examples.

#ifndef _Vtop_H_
#define _Vtop_H_

#include "verilated.h"
class Vtop__Syms;
class VerilatedVcd;

//----------

VL_MODULE(Vtop) {
  public:
    // CELLS
    // Public to allow access to /*verilator_public*/ items;
    // otherwise the application code can consider these internals.
    
    // PORTS
    // The application code writes and reads these signals to
    // propagate new values into/out from the Verilated model.
    VL_IN8(reset,0,0);
    VL_IN8(mar_we,0,0);
    VL_IN8(mbr_out_we,0,0);
    VL_IN8(mbr_in_we,0,0);
    VL_IN8(mem_we,0,0);
    VL_IN8(reg_addr_we,1,0);
    VL_IN8(reg_we,0,0);
    VL_IN8(mbr_alu,0,0);
    VL_IN8(alu_func,1,0);
    VL_IN8(alu_comp_b,0,0);
    VL_IN8(alu_ci,0,0);
    VL_IN8(alu_reg_a,1,0);
    VL_IN8(alu_reg_b,1,0);
    VL_OUT8(alu_so,0,0);
    VL_OUT8(alu_uo,0,0);
    //char	__VpadToAlign15[1];
    
    // LOCAL SIGNALS
    // Internals; generally not touched by application code
    VL_SIG8(top__DOT__regwe,3,0);
    VL_SIG8(top__DOT__alu_a,7,0);
    VL_SIG8(top__DOT__alu_b,7,0);
    VL_SIG8(top__DOT__alu_q,7,0);
    VL_SIG8(top__DOT__reg_in,7,0);
    VL_SIG8(top__DOT__d_in,7,0);
    VL_SIG8(top__DOT__umar__DOT__do_r,7,0);
    VL_SIG8(top__DOT__umbr_out__DOT__do_r,7,0);
    VL_SIG8(top__DOT__umbr_in__DOT__do_r,7,0);
    VL_SIG8(top__DOT__register_file__BRA__0__KET____DOT__register_inst__DOT__do_r,7,0);
    VL_SIG8(top__DOT__register_file__BRA__1__KET____DOT__register_inst__DOT__do_r,7,0);
    VL_SIG8(top__DOT__register_file__BRA__2__KET____DOT__register_inst__DOT__do_r,7,0);
    VL_SIG8(top__DOT__register_file__BRA__3__KET____DOT__register_inst__DOT__do_r,7,0);
    //char	__VpadToAlign33[1];
    VL_SIG16(top__DOT__alu_inst__DOT__cc,8,0);
    VL_SIG8(top__DOT__regout[4],7,0);
    VL_SIG8(top__DOT__umem__DOT__do_r[256],7,0);
    
    // LOCAL VARIABLES
    // Internals; generally not touched by application code
    static VL_ST_SIG8(__Vtable1_top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q[64],0,0);
    static VL_ST_SIG8(__Vtable2_top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q[64],0,0);
    static VL_ST_SIG8(__Vtable3_top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q[64],0,0);
    static VL_ST_SIG8(__Vtable4_top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q[64],0,0);
    static VL_ST_SIG8(__Vtable5_top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q[64],0,0);
    static VL_ST_SIG8(__Vtable6_top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q[64],0,0);
    static VL_ST_SIG8(__Vtable7_top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q[64],0,0);
    static VL_ST_SIG8(__Vtable8_top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q[64],0,0);
    VL_SIG8(top__DOT__register_file__BRA__0__KET____DOT____Vcellinp__register_inst__we,0,0);
    VL_SIG8(top__DOT__register_file__BRA__1__KET____DOT____Vcellinp__register_inst__we,0,0);
    VL_SIG8(top__DOT__register_file__BRA__2__KET____DOT____Vcellinp__register_inst__we,0,0);
    VL_SIG8(top__DOT__register_file__BRA__3__KET____DOT____Vcellinp__register_inst__we,0,0);
    VL_SIG8(top__DOT____Vcellinp__amux_inst__i3,7,0);
    VL_SIG8(top__DOT____Vcellinp__amux_inst__i2,7,0);
    VL_SIG8(top__DOT____Vcellinp__amux_inst__i1,7,0);
    VL_SIG8(top__DOT____Vcellinp__amux_inst__i0,7,0);
    VL_SIG8(top__DOT____Vcellinp__bmux_inst__i3,7,0);
    VL_SIG8(top__DOT____Vcellinp__bmux_inst__i2,7,0);
    VL_SIG8(top__DOT____Vcellinp__bmux_inst__i1,7,0);
    VL_SIG8(top__DOT____Vcellinp__bmux_inst__i0,7,0);
    VL_SIG8(top__DOT____Vcellout__demux_inst__o3,0,0);
    VL_SIG8(top__DOT____Vcellout__demux_inst__o2,0,0);
    VL_SIG8(top__DOT____Vcellout__demux_inst__o1,0,0);
    VL_SIG8(top__DOT____Vcellout__demux_inst__o0,0,0);
    VL_SIG8(top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__q,0,0);
    VL_SIG8(top__DOT__alu_inst__DOT__genblk1__BRA__0__KET____DOT____Vcellout__a_inst__co,0,0);
    VL_SIG8(top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__q,0,0);
    VL_SIG8(top__DOT__alu_inst__DOT__genblk1__BRA__1__KET____DOT____Vcellout__a_inst__co,0,0);
    VL_SIG8(top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__q,0,0);
    VL_SIG8(top__DOT__alu_inst__DOT__genblk1__BRA__2__KET____DOT____Vcellout__a_inst__co,0,0);
    VL_SIG8(top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__q,0,0);
    VL_SIG8(top__DOT__alu_inst__DOT__genblk1__BRA__3__KET____DOT____Vcellout__a_inst__co,0,0);
    VL_SIG8(top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__q,0,0);
    VL_SIG8(top__DOT__alu_inst__DOT__genblk1__BRA__4__KET____DOT____Vcellout__a_inst__co,0,0);
    VL_SIG8(top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__q,0,0);
    VL_SIG8(top__DOT__alu_inst__DOT__genblk1__BRA__5__KET____DOT____Vcellout__a_inst__co,0,0);
    VL_SIG8(top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__q,0,0);
    VL_SIG8(top__DOT__alu_inst__DOT__genblk1__BRA__6__KET____DOT____Vcellout__a_inst__co,0,0);
    VL_SIG8(top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__q,0,0);
    VL_SIG8(top__DOT__alu_inst__DOT__genblk1__BRA__7__KET____DOT____Vcellout__a_inst__co,0,0);
    VL_SIG8(__Vtableidx1,5,0);
    VL_SIG8(__Vtableidx2,5,0);
    VL_SIG8(__Vtableidx3,5,0);
    VL_SIG8(__Vtableidx4,5,0);
    VL_SIG8(__Vtableidx5,5,0);
    VL_SIG8(__Vtableidx6,5,0);
    VL_SIG8(__Vtableidx7,5,0);
    VL_SIG8(__Vtableidx8,5,0);
    VL_SIG8(__Vclklast__TOP__mbr_in_we,0,0);
    VL_SIG8(__Vclklast__TOP__reset,0,0);
    VL_SIG8(__Vclklast__TOP__mbr_out_we,0,0);
    VL_SIG8(__Vclklast__TOP__mar_we,0,0);
    VL_SIG8(__Vclklast__TOP__mem_we,0,0);
    VL_SIG8(__Vclklast__TOP__top__DOT__register_file__BRA__0__KET____DOT____Vcellinp__register_inst__we,0,0);
    VL_SIG8(__Vclklast__TOP__top__DOT__register_file__BRA__1__KET____DOT____Vcellinp__register_inst__we,0,0);
    VL_SIG8(__Vclklast__TOP__top__DOT__register_file__BRA__2__KET____DOT____Vcellinp__register_inst__we,0,0);
    VL_SIG8(__Vclklast__TOP__top__DOT__register_file__BRA__3__KET____DOT____Vcellinp__register_inst__we,0,0);
    //char	__VpadToAlign349[1];
    VL_SIG16(__Vchglast__TOP__top__DOT__alu_inst__DOT__cc,8,0);
    VL_SIG(__Vm_traceActivity,31,0);
    
    // INTERNAL VARIABLES
    // Internals; generally not touched by application code
    Vtop__Syms*	__VlSymsp;		// Symbol table
    
    // PARAMETERS
    // Parameters marked /*verilator public*/ for use by application code
    
    // CONSTRUCTORS
  private:
    Vtop& operator= (const Vtop&);	///< Copying not allowed
    Vtop(const Vtop&);	///< Copying not allowed
  public:
    /// Construct the model; called by application code
    /// The special name  may be used to make a wrapper with a
    /// single model invisible WRT DPI scope names.
    Vtop(const char* name="TOP");
    /// Destroy the model; called (often implicitly) by application code
    ~Vtop();
    /// Trace signals in the model; called by application code
    void trace (VerilatedVcdC* tfp, int levels, int options=0);
    
    // USER METHODS
    
    // API METHODS
    /// Evaluate the model.  Application must call when inputs change.
    void eval();
    /// Simulation complete, run final blocks.  Application must call on completion.
    void final();
    
    // INTERNAL METHODS
  private:
    static void _eval_initial_loop(Vtop__Syms* __restrict vlSymsp);
  public:
    void __Vconfigure(Vtop__Syms* symsp, bool first);
  private:
    static QData	_change_request(Vtop__Syms* __restrict vlSymsp);
  public:
    static void	_combo__TOP__18(Vtop__Syms* __restrict vlSymsp);
    static void	_combo__TOP__20(Vtop__Syms* __restrict vlSymsp);
    static void	_combo__TOP__22(Vtop__Syms* __restrict vlSymsp);
    static void	_combo__TOP__5(Vtop__Syms* __restrict vlSymsp);
    static void	_combo__TOP__9(Vtop__Syms* __restrict vlSymsp);
  private:
    void	_configure_coverage(Vtop__Syms* __restrict vlSymsp, bool first);
    void	_ctor_var_reset();
  public:
    static void	_eval(Vtop__Syms* __restrict vlSymsp);
    static void	_eval_initial(Vtop__Syms* __restrict vlSymsp);
    static void	_eval_settle(Vtop__Syms* __restrict vlSymsp);
    static void	_multiclk__TOP__10(Vtop__Syms* __restrict vlSymsp);
    static void	_multiclk__TOP__17(Vtop__Syms* __restrict vlSymsp);
    static void	_sequent__TOP__1(Vtop__Syms* __restrict vlSymsp);
    static void	_sequent__TOP__12(Vtop__Syms* __restrict vlSymsp);
    static void	_sequent__TOP__13(Vtop__Syms* __restrict vlSymsp);
    static void	_sequent__TOP__14(Vtop__Syms* __restrict vlSymsp);
    static void	_sequent__TOP__15(Vtop__Syms* __restrict vlSymsp);
    static void	_sequent__TOP__4(Vtop__Syms* __restrict vlSymsp);
    static void	_sequent__TOP__7(Vtop__Syms* __restrict vlSymsp);
    static void	_sequent__TOP__8(Vtop__Syms* __restrict vlSymsp);
    static void	_settle__TOP__11(Vtop__Syms* __restrict vlSymsp);
    static void	_settle__TOP__16(Vtop__Syms* __restrict vlSymsp);
    static void	_settle__TOP__19(Vtop__Syms* __restrict vlSymsp);
    static void	_settle__TOP__21(Vtop__Syms* __restrict vlSymsp);
    static void	_settle__TOP__6(Vtop__Syms* __restrict vlSymsp);
    static void	traceChgThis(Vtop__Syms* __restrict vlSymsp, VerilatedVcd* vcdp, uint32_t code);
    static void	traceChgThis__10(Vtop__Syms* __restrict vlSymsp, VerilatedVcd* vcdp, uint32_t code);
    static void	traceChgThis__11(Vtop__Syms* __restrict vlSymsp, VerilatedVcd* vcdp, uint32_t code);
    static void	traceChgThis__12(Vtop__Syms* __restrict vlSymsp, VerilatedVcd* vcdp, uint32_t code);
    static void	traceChgThis__13(Vtop__Syms* __restrict vlSymsp, VerilatedVcd* vcdp, uint32_t code);
    static void	traceChgThis__2(Vtop__Syms* __restrict vlSymsp, VerilatedVcd* vcdp, uint32_t code);
    static void	traceChgThis__3(Vtop__Syms* __restrict vlSymsp, VerilatedVcd* vcdp, uint32_t code);
    static void	traceChgThis__4(Vtop__Syms* __restrict vlSymsp, VerilatedVcd* vcdp, uint32_t code);
    static void	traceChgThis__5(Vtop__Syms* __restrict vlSymsp, VerilatedVcd* vcdp, uint32_t code);
    static void	traceChgThis__6(Vtop__Syms* __restrict vlSymsp, VerilatedVcd* vcdp, uint32_t code);
    static void	traceChgThis__7(Vtop__Syms* __restrict vlSymsp, VerilatedVcd* vcdp, uint32_t code);
    static void	traceChgThis__8(Vtop__Syms* __restrict vlSymsp, VerilatedVcd* vcdp, uint32_t code);
    static void	traceChgThis__9(Vtop__Syms* __restrict vlSymsp, VerilatedVcd* vcdp, uint32_t code);
    static void	traceFullThis(Vtop__Syms* __restrict vlSymsp, VerilatedVcd* vcdp, uint32_t code);
    static void	traceFullThis__1(Vtop__Syms* __restrict vlSymsp, VerilatedVcd* vcdp, uint32_t code);
    static void	traceInitThis(Vtop__Syms* __restrict vlSymsp, VerilatedVcd* vcdp, uint32_t code);
    static void	traceInitThis__1(Vtop__Syms* __restrict vlSymsp, VerilatedVcd* vcdp, uint32_t code);
    static void traceInit (VerilatedVcd* vcdp, void* userthis, uint32_t code);
    static void traceFull (VerilatedVcd* vcdp, void* userthis, uint32_t code);
    static void traceChg  (VerilatedVcd* vcdp, void* userthis, uint32_t code);
} VL_ATTR_ALIGNED(128);

#endif  /*guard*/
