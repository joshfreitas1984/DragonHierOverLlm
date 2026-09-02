// ============================================================
// Type  : VoidDelegate
// Token : 0x20000E7
// ============================================================

public class VoidDelegate
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600074E
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

    // Token : 0x600074F
    // RVA   : 0xB07940   Offset: 0xB06140   Length: 0x26A
    public virtual void Invoke(GameObject go)
    {
        long lVar1;
        bool cVar4;
        ulong uVar6;
        ulong uVar7;
        ulong uVar9;
        long local_res8;
        local_res8 = this;
        lVar1 = *(int64 *)(this + 104);
        if (lVar1 == null) {
          uVar7 = 1;
          plVar8 = &local_res8;
        }
        else {
          uVar7 = *(uint64 *)(lVar1 + 24);
          plVar8 = (int64 *)(lVar1 + 32);
          if (uVar7 == 0) {
            return;
          }
        }
        uVar9 = 0;
        do {
          lVar1 = plVar8[uVar9];
          pcVar2 = *(code **)(lVar1 + 16);
          plVar3 = *(int64 **)(lVar1 + 32);
          lVar1 = *(int64 *)(lVar1 + 40);
          if (*(short *)(lVar1 + 72) == -1) {
            il2cpp_internal(lVar1);
          }
          cVar4 = FUN_1800d6050(lVar1);
          if (!cVar4) {
            if (*(char *)(lVar1 + 74) == true) {
              if ((((plVar3 == (int64 *)0) || (*(short *)(lVar1 + 72) == -1)) ||
                  ((*(uint32 *)(*plVar3 + 0x114) >> 8 & 1) != 0)) || (*(int64 *)(this + 24) == 0))
              goto LAB_180b07b6e;
              cVar4 = il2cpp_internal(lVar1);
              if (!cVar4) {
                cVar4 = FUN_1800d65c0(lVar1);
                if (!cVar4) {
                  (**(code **)(*plVar3 + 0x138 + (uint64)*(uint16 *)(lVar1 + 72) * 16))
                            (plVar3,go,
                             *(uint64 *)
                              (*plVar3 + 0x140 + (uint64)*(uint16 *)(lVar1 + 72) * 16));
                }
                else {
                  uVar6 = il2cpp_class_get_namespace(lVar1);
                  FUN_180004720(*(uint16 *)(lVar1 + 72),uVar6,plVar3,go);
                }
              }
              else {
                cVar4 = FUN_1800d65c0(lVar1);
                if (!cVar4) {
                  puVar5 = (uint64 *)
                           il2cpp_internal(*(uint64 *)
                                                (*plVar3 +
                                                ((uint64)*(uint16 *)(lVar1 + 72) + 20) * 16),
                                               lVar1);
                  (*(code *)*puVar5)(plVar3,go,puVar5);
                }
                else {
                  FUN_180005a80(lVar1,plVar3,go);
                }
              }
            }
            else {
              if ((*(short *)(lVar1 + 72) == -1) || (*(int64 *)(this + 24) == 0))
              goto LAB_180b079d8;
              cVar4 = il2cpp_internal(lVar1);
              if (!cVar4) {
                cVar4 = FUN_1800d65c0(lVar1);
                if (!cVar4) {
                  (**(code **)(*go + 0x138 + (uint64)*(uint16 *)(lVar1 + 72) * 16))
                            (go,*(uint64 *)
                                      (*go + 0x140 + (uint64)*(uint16 *)(lVar1 + 72) * 16));
                }
                else {
                  uVar6 = il2cpp_class_get_namespace(lVar1);
                  FUN_180002970(*(uint16 *)(lVar1 + 72),uVar6,go);
                }
              }
              else {
                cVar4 = FUN_1800d65c0(lVar1);
                if (!cVar4) {
                  puVar5 = (uint64 *)
                           il2cpp_internal(*(uint64 *)
                                                (*go +
                                                ((uint64)*(uint16 *)(lVar1 + 72) + 20) * 16),
                                               lVar1);
                  (*(code *)*puVar5)(go,puVar5);
                }
                else {
                  FUN_180005c70(lVar1,go);
                }
              }
            }
          }
          else if (*(char *)(lVar1 + 74) == true) {
        LAB_180b079d8:
            (*pcVar2)(go,lVar1);
          }
          else {
        LAB_180b07b6e:
            (*pcVar2)(plVar3,go,lVar1);
          }
          uVar9 = uVar9 + 1;
          if (uVar7 <= uVar9) {
            return;
          }
        } while( true );
    }

    // Token : 0x6000750
    // RVA   : 0x216660   Offset: 0x214E60   Length: 0x21
    public virtual IAsyncResult BeginInvoke(GameObject go, AsyncCallback callback, object object)
    {
        ulong local_18;
        ulong local_10;
        local_10 = 0;
        local_18 = go;
        il2cpp_internal(this,&local_18);
    }

    // Token : 0x6000751
    // RVA   : 0x210040   Offset: 0x20E840   Length: 0xA
    public virtual void EndInvoke(IAsyncResult result)
    {
        il2cpp_internal(result,0);
    }

}
