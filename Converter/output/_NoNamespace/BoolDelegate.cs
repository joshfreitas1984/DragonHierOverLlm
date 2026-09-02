// ============================================================
// Type  : BoolDelegate
// Token : 0x20000E8
// ============================================================

public class BoolDelegate
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000752
    // RVA   : 0x210320   Offset: 0x20EB20   Length: 0x6A
    public void /*ctor*/(object object, IntPtr method)
    {
        bool cVar1;
        ulong uVar2;
        if (object == null) {
          cVar1 = FUN_1800d6050(method);
          if (!cVar1) {
            uVar2 = il2cpp_internal(0,"Delegate to an instance method cannot have null \'this\'.");
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar2,0);
          }
        }
        *(uint64 *)(this + 16) = *method;
        *(int64 *)(this + 32) = object;
        *(uint64 **)(this + 40) = method;
    }

    // Token : 0x6000753
    // RVA   : 0xB05230   Offset: 0xB03A30   Length: 0x2AF
    public virtual void Invoke(GameObject go, bool state)
    {
        long lVar1;
        bool cVar4;
        ulong uVar7;
        ulong uVar8;
        ulong uVar9;
        long local_res8;
        local_res8 = this;
        lVar1 = *(int64 *)(this + 104);
        if (lVar1 == null) {
          plVar5 = &local_res8;
          uVar8 = 1;
        }
        else {
          uVar8 = *(uint64 *)(lVar1 + 24);
          plVar5 = (int64 *)(lVar1 + 32);
          if (uVar8 == 0) {
            return;
          }
        }
        uVar9 = 0;
        do {
          lVar1 = plVar5[uVar9];
          pcVar2 = *(code **)(lVar1 + 16);
          plVar3 = *(int64 **)(lVar1 + 32);
          lVar1 = *(int64 *)(lVar1 + 40);
          if (*(short *)(lVar1 + 72) == -1) {
            il2cpp_internal(lVar1);
          }
          cVar4 = FUN_1800d6050(lVar1);
          if (!cVar4) {
            if (*(char *)(lVar1 + 74) == '\x02') {
              if ((((plVar3 == (int64 *)0) || (*(short *)(lVar1 + 72) == -1)) ||
                  ((*(uint32 *)(*plVar3 + 0x114) >> 8 & 1) != 0)) || (*(int64 *)(this + 24) == 0))
              goto LAB_180b05495;
              cVar4 = il2cpp_internal(lVar1);
              if (!cVar4) {
                cVar4 = FUN_1800d65c0(lVar1);
                if (!cVar4) {
                  (**(code **)(*plVar3 + 0x138 + (uint64)*(uint16 *)(lVar1 + 72) * 16))
                            (plVar3,go,state,
                             *(uint64 *)
                              (*plVar3 + 0x140 + (uint64)*(uint16 *)(lVar1 + 72) * 16));
                }
                else {
                  uVar7 = il2cpp_class_get_namespace(lVar1);
                  FUN_18014a9c0(*(uint16 *)(lVar1 + 72),uVar7,plVar3,go,state);
                }
              }
              else {
                cVar4 = FUN_1800d65c0(lVar1);
                if (!cVar4) {
                  puVar6 = (uint64 *)
                           il2cpp_internal(*(uint64 *)
                                                (*plVar3 +
                                                ((uint64)*(uint16 *)(lVar1 + 72) + 20) * 16),
                                               lVar1);
                  (*(code *)*puVar6)(plVar3,go,state,puVar6);
                }
                else {
                  FUN_18014a7a0(lVar1,plVar3,go,state);
                }
              }
            }
            else {
              if ((*(short *)(lVar1 + 72) == -1) || (*(int64 *)(this + 24) == 0))
              goto LAB_180b052d7;
              cVar4 = il2cpp_internal(lVar1);
              if (!cVar4) {
                cVar4 = FUN_1800d65c0(lVar1);
                if (!cVar4) {
                  (**(code **)(*go + 0x138 + (uint64)*(uint16 *)(lVar1 + 72) * 16))
                            (go,state,
                             *(uint64 *)
                              (*go + 0x140 + (uint64)*(uint16 *)(lVar1 + 72) * 16));
                }
                else {
                  uVar7 = il2cpp_class_get_namespace(lVar1);
                  FUN_1800088a0(*(uint16 *)(lVar1 + 72),uVar7,go,state);
                }
              }
              else {
                cVar4 = FUN_1800d65c0(lVar1);
                if (!cVar4) {
                  puVar6 = (uint64 *)
                           il2cpp_internal(*(uint64 *)
                                                (*go +
                                                ((uint64)*(uint16 *)(lVar1 + 72) + 20) * 16),
                                               lVar1);
                  (*(code *)*puVar6)(go,state,puVar6);
                }
                else {
                  FUN_1800087f0(lVar1,go,state);
                }
              }
            }
          }
          else if (*(char *)(lVar1 + 74) == '\x02') {
        LAB_180b052d7:
            (*pcVar2)(go,state,lVar1);
          }
          else {
        LAB_180b05495:
            (*pcVar2)(plVar3,go,state,lVar1);
          }
          uVar9 = uVar9 + 1;
          if (uVar8 <= uVar9) {
            return;
          }
        } while( true );
    }

    // Token : 0x6000754
    // RVA   : 0xB05110   Offset: 0xB03910   Length: 0x82
    public virtual IAsyncResult BeginInvoke(GameObject go, bool state, AsyncCallback callback, object object)
    {
        void BoolDelegate.BeginInvoke
                     (uint64 this,uint64 go,uint8 state,uint64 callback,
                     uint64 object)
        {
        uint8 local_res18 [16];
        uint64 local_28;
        uint64 local_20;
        uint64 local_18;
        local_res18[0] = state;
        local_18 = 0;
        local_28 = go;
        local_20 = il2cpp_value_box(DAT_181d8d920,local_res18);
        il2cpp_internal(this,&local_28,callback,object);
    }

    // Token : 0x6000755
    // RVA   : 0x210040   Offset: 0x20E840   Length: 0xA
    public virtual void EndInvoke(IAsyncResult result)
    {
        il2cpp_internal(result,0);
    }

}
