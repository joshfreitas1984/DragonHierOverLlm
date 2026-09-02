// ============================================================
// Type  : FloatDelegate
// Token : 0x20000E9
// ============================================================

public class FloatDelegate
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000756
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

    // Token : 0x6000757
    // RVA   : 0xB05640   Offset: 0xB03E40   Length: 0x2A6
    public virtual void Invoke(GameObject go, float delta)
    {
        long lVar1;
        long lVar2;
        bool cVar5;
        ulong uVar7;
        ulong uVar8;
        ulong uVar10;
        long local_res8;
        local_res8 = this;
        lVar1 = *(int64 *)(this + 104);
        if (lVar1 == null) {
          uVar8 = 1;
          plVar9 = &local_res8;
        }
        else {
          uVar8 = *(uint64 *)(lVar1 + 24);
          plVar9 = (int64 *)(lVar1 + 32);
          if (uVar8 == 0) {
            return;
          }
        }
        uVar10 = 0;
        do {
          lVar1 = plVar9[uVar10];
          lVar2 = *(int64 *)(lVar1 + 40);
          pcVar3 = *(code **)(lVar1 + 16);
          plVar4 = *(int64 **)(lVar1 + 32);
          if (*(short *)(lVar2 + 72) == -1) {
            il2cpp_internal(lVar2);
          }
          cVar5 = FUN_1800d6050(lVar2);
          if (!cVar5) {
            if (*(char *)(lVar2 + 74) == '\x02') {
              if ((((plVar4 == (int64 *)0) || (*(short *)(lVar2 + 72) == -1)) ||
                  ((*(uint32 *)(*plVar4 + 0x114) >> 8 & 1) != 0)) || (*(int64 *)(this + 24) == 0))
              goto LAB_180b0589c;
              cVar5 = il2cpp_internal(lVar2);
              if (!cVar5) {
                cVar5 = FUN_1800d65c0(lVar2);
                if (!cVar5) {
                  (**(code **)(*plVar4 + 0x138 + (uint64)*(uint16 *)(lVar2 + 72) * 16))
                            (plVar4,go,delta,
                             *(uint64 *)
                              (*plVar4 + 0x140 + (uint64)*(uint16 *)(lVar2 + 72) * 16));
                }
                else {
                  uVar7 = il2cpp_class_get_namespace(lVar2);
                  FUN_18014a910(*(uint16 *)(lVar2 + 72),uVar7,plVar4,go,delta);
                }
              }
              else {
                cVar5 = FUN_1800d65c0(lVar2);
                if (!cVar5) {
                  puVar6 = (uint64 *)
                           il2cpp_internal(*(uint64 *)
                                                (*plVar4 +
                                                ((uint64)*(uint16 *)(lVar2 + 72) + 20) * 16),
                                               lVar2);
                  (*(code *)*puVar6)(plVar4,go,delta,puVar6);
                }
                else {
                  FUN_18014a620(lVar2,plVar4,go,delta);
                }
              }
            }
            else {
              if ((*(short *)(lVar2 + 72) == -1) || (*(int64 *)(this + 24) == 0))
              goto LAB_180b056e8;
              cVar5 = il2cpp_internal(lVar2);
              if (!cVar5) {
                cVar5 = FUN_1800d65c0(lVar2);
                if (!cVar5) {
                  (**(code **)(*go + 0x138 + (uint64)*(uint16 *)(lVar2 + 72) * 16))
                            (go,delta,
                             *(uint64 *)
                              (*go + 0x140 + (uint64)*(uint16 *)(lVar2 + 72) * 16));
                }
                else {
                  uVar7 = il2cpp_class_get_namespace(lVar2);
                  FUN_180149cf0(*(uint16 *)(lVar2 + 72),uVar7,go,delta);
                }
              }
              else {
                cVar5 = FUN_1800d65c0(lVar2);
                if (!cVar5) {
                  puVar6 = (uint64 *)
                           il2cpp_internal(*(uint64 *)
                                                (*go +
                                                ((uint64)*(uint16 *)(lVar2 + 72) + 20) * 16),
                                               lVar2);
                  (*(code *)*puVar6)(go,delta,puVar6);
                }
                else {
                  FUN_18014a3f0(lVar2,go,delta);
                }
              }
            }
          }
          else if (*(char *)(lVar2 + 74) == '\x02') {
        LAB_180b056e8:
            (*pcVar3)(go,delta,lVar2);
          }
          else {
        LAB_180b0589c:
            (*pcVar3)(plVar4,go,delta,lVar2);
          }
          uVar10 = uVar10 + 1;
          if (uVar8 <= uVar10) {
            return;
          }
        } while( true );
    }

    // Token : 0x6000758
    // RVA   : 0xB05520   Offset: 0xB03D20   Length: 0x83
    public virtual IAsyncResult BeginInvoke(GameObject go, float delta, AsyncCallback callback, object object)
    {
        void FloatDelegate.BeginInvoke
                     (uint64 this,uint64 go,uint32 delta,uint64 callback,
                     uint64 object)
        {
        uint32 local_res18 [4];
        uint64 local_28;
        uint64 local_20;
        uint64 local_18;
        local_res18[0] = delta;
        local_18 = 0;
        local_28 = go;
        local_20 = il2cpp_value_box(DAT_181d7d0b8,local_res18);
        il2cpp_internal(this,&local_28,callback,object);
    }

    // Token : 0x6000759
    // RVA   : 0x210040   Offset: 0x20E840   Length: 0xA
    public virtual void EndInvoke(IAsyncResult result)
    {
        il2cpp_internal(result,0);
    }

}
