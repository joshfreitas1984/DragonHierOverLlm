// ============================================================
// Type  : OnInitFunc`1
// Token : 0x200008C
// ============================================================

public class OnInitFunc`1
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600041F
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

    // Token : 0x6000420
    // RVA   : 0x8AF540   Offset: 0x8ADD40   Length: 0x3CA
    public virtual void Invoke(T w)
    {
        long lVar1;
        bool cVar4;
        long lVar5;
        ulong uVar7;
        long lVar8;
        ushort uVar9;
        ushort uVar10;
        ulong uVar11;
        ulong uVar13;
        long local_res8;
        local_res8 = this;
        lVar1 = *(int64 *)(this + 104);
        if (lVar1 == null) {
          uVar11 = 1;
          plVar12 = &local_res8;
        }
        else {
          uVar11 = *(uint64 *)(lVar1 + 24);
          plVar12 = (int64 *)(lVar1 + 32);
          if (uVar11 == 0) {
            return;
          }
        }
        uVar13 = 0;
        do {
          lVar1 = plVar12[uVar13];
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
              goto LAB_1808af8ce;
              cVar4 = il2cpp_internal(lVar1);
              if (!cVar4) {
                cVar4 = FUN_1800d65c0(lVar1);
                if (!cVar4) {
                  (**(code **)(*plVar3 + 0x138 + (uint64)*(uint16 *)(lVar1 + 72) * 16))
                            (plVar3,w,
                             *(uint64 *)
                              (*plVar3 + 0x140 + (uint64)*(uint16 *)(lVar1 + 72) * 16));
                }
                else {
                  lVar8 = il2cpp_class_get_namespace(lVar1);
                  lVar5 = *plVar3;
                  uVar10 = 0;
                  if (*(uint16 *)(lVar5 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar5 + 176) + (uint64)uVar10 * 16) == lVar8)
                      {
                        puVar6 = (uint64 *)
                                 ((int64)
                                  (int)((uint32)*(uint16 *)(lVar1 + 72) +
                                       *(int *)(*(int64 *)(lVar5 + 176) + 8 + (uint64)uVar10 * 16
                                               )) * 16 + 0x138 + lVar5);
                        (*(code *)*puVar6)(plVar3,w,puVar6[1]);
                        goto LAB_1808af8d9;
                      }
                      uVar10 = uVar10 + 1;
                    } while (uVar10 < *(uint16 *)(lVar5 + 0x12a));
                  }
                  puVar6 = (uint64 *)FUN_1800914f0(plVar3,lVar8,*(uint16 *)(lVar1 + 72));
                  (*(code *)*puVar6)(plVar3,w,puVar6[1]);
                }
              }
              else {
                cVar4 = FUN_1800d65c0(lVar1);
                uVar10 = *(uint16 *)(lVar1 + 72);
                if (!cVar4) {
                  puVar6 = (uint64 *)
                           il2cpp_internal(*(uint64 *)
                                                (*plVar3 + ((uint64)uVar10 + 20) * 16),lVar1);
                  (*(code *)*puVar6)(plVar3,w,puVar6);
                }
                else {
                  lVar5 = *plVar3;
                  uVar9 = 0;
                  if (*(uint16 *)(lVar5 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar5 + 176) + (uint64)uVar9 * 16) ==
                          *(int64 *)(lVar1 + 24)) {
                        lVar5 = (int64)
                                (int)((uint32)uVar10 +
                                     *(int *)(*(int64 *)(lVar5 + 176) + 8 + (uint64)uVar9 * 16))
                                * 16 + 0x138 + lVar5;
                        goto LAB_1808af7a6;
                      }
                      uVar9 = uVar9 + 1;
                    } while (uVar9 < *(uint16 *)(lVar5 + 0x12a));
                  }
                  lVar5 = FUN_1800914f0(plVar3,*(int64 *)(lVar1 + 24),uVar10);
        LAB_1808af7a6:
                  puVar6 = (uint64 *)il2cpp_internal(*(uint64 *)(lVar5 + 8),lVar1);
                  (*(code *)*puVar6)(plVar3,w,puVar6);
                }
              }
            }
            else {
              if ((*(short *)(lVar1 + 72) == -1) || (*(int64 *)(this + 24) == 0))
              goto LAB_1808af5d8;
              cVar4 = il2cpp_internal(lVar1);
              if (!cVar4) {
                cVar4 = FUN_1800d65c0(lVar1);
                if (!cVar4) {
                  (**(code **)(*w + 0x138 + (uint64)*(uint16 *)(lVar1 + 72) * 16))
                            (w,*(uint64 *)
                                      (*w + 0x140 + (uint64)*(uint16 *)(lVar1 + 72) * 16));
                }
                else {
                  uVar7 = il2cpp_class_get_namespace(lVar1);
                  FUN_180002970(*(uint16 *)(lVar1 + 72),uVar7,w);
                }
              }
              else {
                cVar4 = FUN_1800d65c0(lVar1);
                uVar10 = *(uint16 *)(lVar1 + 72);
                if (!cVar4) {
                  uVar7 = *(uint64 *)(*w + ((uint64)uVar10 + 20) * 16);
                }
                else {
                  lVar5 = *w;
                  uVar9 = 0;
                  if (*(uint16 *)(lVar5 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar5 + 176) + (uint64)uVar9 * 16) ==
                          *(int64 *)(lVar1 + 24)) {
                        uVar7 = *(uint64 *)
                                 ((int64)
                                  (int)((uint32)uVar10 +
                                       *(int *)(*(int64 *)(lVar5 + 176) + 8 + (uint64)uVar9 * 16)
                                       ) * 16 + lVar5 + 0x140);
                        goto LAB_1808af69a;
                      }
                      uVar9 = uVar9 + 1;
                    } while (uVar9 < *(uint16 *)(lVar5 + 0x12a));
                  }
                  lVar5 = FUN_1800914f0(w,*(int64 *)(lVar1 + 24),uVar10);
                  uVar7 = *(uint64 *)(lVar5 + 8);
                }
        LAB_1808af69a:
                puVar6 = (uint64 *)il2cpp_internal(uVar7,lVar1);
                (*(code *)*puVar6)(w,puVar6);
              }
            }
          }
          else if (*(char *)(lVar1 + 74) == true) {
        LAB_1808af5d8:
            (*pcVar2)(w,lVar1);
          }
          else {
        LAB_1808af8ce:
            (*pcVar2)(plVar3,w,lVar1);
          }
        LAB_1808af8d9:
          uVar13 = uVar13 + 1;
          if (uVar11 <= uVar13) {
            return;
          }
        } while( true );
    }

    // Token : 0x6000421
    // RVA   : 0x216660   Offset: 0x214E60   Length: 0x21
    public virtual IAsyncResult BeginInvoke(T w, AsyncCallback callback, object object)
    {
        ulong local_18;
        ulong local_10;
        local_10 = 0;
        local_18 = w;
        il2cpp_internal(this,&local_18);
    }

    // Token : 0x6000422
    // RVA   : 0x210040   Offset: 0x20E840   Length: 0xA
    public virtual void EndInvoke(IAsyncResult result)
    {
        il2cpp_internal(result,0);
    }

}
