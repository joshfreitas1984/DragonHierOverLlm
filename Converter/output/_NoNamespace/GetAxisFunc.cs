// ============================================================
// Type  : GetAxisFunc
// Token : 0x20000DD
// ============================================================

public class GetAxisFunc
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600072A
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

    // Token : 0x600072B
    // RVA   : 0xB05B10   Offset: 0xB04310   Length: 0x44A
    public virtual float Invoke(string name)
    {
        long lVar1;
        bool cVar4;
        long lVar5;
        long lVar7;
        ushort uVar8;
        ushort uVar9;
        ulong uVar10;
        ulong uVar12;
        ulong uVar13;
        long local_res8;
        local_res8 = this;
        lVar5 = *(int64 *)(this + 104);
        if (lVar5 == null) {
          uVar10 = 1;
          plVar11 = &local_res8;
        }
        else {
          uVar10 = *(uint64 *)(lVar5 + 24);
          plVar11 = (int64 *)(lVar5 + 32);
          if (uVar10 == 0) {
            return 0;
          }
        }
        uVar12 = 0;
        do {
          lVar5 = plVar11[uVar12];
          lVar1 = *(int64 *)(lVar5 + 40);
          pcVar2 = *(code **)(lVar5 + 16);
          plVar3 = *(int64 **)(lVar5 + 32);
          if (*(short *)(lVar1 + 72) == -1) {
            il2cpp_internal(lVar1);
          }
          cVar4 = FUN_1800d6050(lVar1);
          if (!cVar4) {
            if (*(char *)(lVar1 + 74) == true) {
              if ((((plVar3 == (int64 *)0) || (*(short *)(lVar1 + 72) == -1)) ||
                  ((*(uint32 *)(*plVar3 + 0x114) >> 8 & 1) != 0)) || (*(int64 *)(this + 24) == 0))
              goto LAB_180b05f1e;
              cVar4 = il2cpp_internal(lVar1);
              if (!cVar4) {
                cVar4 = FUN_1800d65c0(lVar1);
                if (!cVar4) {
                  uVar13 = (**(code **)(*plVar3 + 0x138 + (uint64)*(uint16 *)(lVar1 + 72) * 16))
                                     (plVar3,name,
                                      *(uint64 *)
                                       (*plVar3 + 0x140 + (uint64)*(uint16 *)(lVar1 + 72) * 16));
                }
                else {
                  lVar7 = il2cpp_class_get_namespace(lVar1);
                  lVar5 = *plVar3;
                  uVar9 = 0;
                  if (*(uint16 *)(lVar5 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar5 + 176) + (uint64)uVar9 * 16) == lVar7) {
                        puVar6 = (uint64 *)
                                 ((int64)
                                  (int)((uint32)*(uint16 *)(lVar1 + 72) +
                                       *(int *)(*(int64 *)(lVar5 + 176) + 8 + (uint64)uVar9 * 16)
                                       ) * 16 + 0x138 + lVar5);
                        uVar13 = (*(code *)*puVar6)(plVar3,name,puVar6[1]);
                        goto LAB_180b05f29;
                      }
                      uVar9 = uVar9 + 1;
                    } while (uVar9 < *(uint16 *)(lVar5 + 0x12a));
                  }
                  puVar6 = (uint64 *)FUN_1800914f0(plVar3,lVar7,*(uint16 *)(lVar1 + 72));
                  uVar13 = (*(code *)*puVar6)(plVar3,name,puVar6[1]);
                }
              }
              else {
                cVar4 = FUN_1800d65c0(lVar1);
                uVar9 = *(uint16 *)(lVar1 + 72);
                if (!cVar4) {
                  puVar6 = (uint64 *)
                           il2cpp_internal(*(uint64 *)(*plVar3 + ((uint64)uVar9 + 20) * 16)
                                               ,lVar1);
                  uVar13 = (*(code *)*puVar6)(plVar3,name,puVar6);
                }
                else {
                  lVar5 = *plVar3;
                  uVar8 = 0;
                  if (*(uint16 *)(lVar5 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar5 + 176) + (uint64)uVar8 * 16) ==
                          *(int64 *)(lVar1 + 24)) {
                        lVar5 = (int64)
                                (int)((uint32)uVar9 +
                                     *(int *)(*(int64 *)(lVar5 + 176) + 8 + (uint64)uVar8 * 16))
                                * 16 + 0x138 + lVar5;
                        goto LAB_180b05df6;
                      }
                      uVar8 = uVar8 + 1;
                    } while (uVar8 < *(uint16 *)(lVar5 + 0x12a));
                  }
                  lVar5 = FUN_1800914f0(plVar3,*(int64 *)(lVar1 + 24),uVar9);
        LAB_180b05df6:
                  puVar6 = (uint64 *)il2cpp_internal(*(uint64 *)(lVar5 + 8),lVar1);
                  uVar13 = (*(code *)*puVar6)(plVar3,name,puVar6);
                }
              }
            }
            else {
              if ((*(short *)(lVar1 + 72) == -1) || (*(int64 *)(this + 24) == 0))
              goto LAB_180b05baa;
              cVar4 = il2cpp_internal(lVar1);
              if (!cVar4) {
                cVar4 = FUN_1800d65c0(lVar1);
                if (!cVar4) {
                  uVar13 = (**(code **)(*name + 0x138 + (uint64)*(uint16 *)(lVar1 + 72) * 16))
                                     (name,*(uint64 *)
                                               (*name + 0x140 +
                                               (uint64)*(uint16 *)(lVar1 + 72) * 16));
                }
                else {
                  lVar7 = il2cpp_class_get_namespace(lVar1);
                  lVar5 = *name;
                  uVar9 = 0;
                  if (*(uint16 *)(lVar5 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar5 + 176) + (uint64)uVar9 * 16) == lVar7) {
                        puVar6 = (uint64 *)
                                 ((int64)
                                  (int)((uint32)*(uint16 *)(lVar1 + 72) +
                                       *(int *)(*(int64 *)(lVar5 + 176) + 8 + (uint64)uVar9 * 16)
                                       ) * 16 + 0x138 + lVar5);
                        uVar13 = (*(code *)*puVar6)(name,puVar6[1]);
                        goto LAB_180b05f29;
                      }
                      uVar9 = uVar9 + 1;
                    } while (uVar9 < *(uint16 *)(lVar5 + 0x12a));
                  }
                  puVar6 = (uint64 *)FUN_1800914f0(name,lVar7,*(uint16 *)(lVar1 + 72));
                  uVar13 = (*(code *)*puVar6)(name,puVar6[1]);
                }
              }
              else {
                cVar4 = FUN_1800d65c0(lVar1);
                uVar9 = *(uint16 *)(lVar1 + 72);
                if (!cVar4) {
                  uVar13 = *(uint64 *)(*name + ((uint64)uVar9 + 20) * 16);
                }
                else {
                  lVar5 = *name;
                  uVar8 = 0;
                  if (*(uint16 *)(lVar5 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar5 + 176) + (uint64)uVar8 * 16) ==
                          *(int64 *)(lVar1 + 24)) {
                        uVar13 = *(uint64 *)
                                  ((int64)
                                   (int)((uint32)uVar9 +
                                        *(int *)(*(int64 *)(lVar5 + 176) + 8 + (uint64)uVar8 * 16
                                                )) * 16 + lVar5 + 0x140);
                        goto LAB_180b05c79;
                      }
                      uVar8 = uVar8 + 1;
                    } while (uVar8 < *(uint16 *)(lVar5 + 0x12a));
                  }
                  lVar5 = FUN_1800914f0(name,*(int64 *)(lVar1 + 24),uVar9);
                  uVar13 = *(uint64 *)(lVar5 + 8);
                }
        LAB_180b05c79:
                puVar6 = (uint64 *)il2cpp_internal(uVar13,lVar1);
                uVar13 = (*(code *)*puVar6)(name,puVar6);
              }
            }
          }
          else if (*(char *)(lVar1 + 74) == true) {
        LAB_180b05baa:
            uVar13 = (*pcVar2)(name,lVar1);
          }
          else {
        LAB_180b05f1e:
            uVar13 = (*pcVar2)(plVar3,name,lVar1);
          }
        LAB_180b05f29:
          uVar12 = uVar12 + 1;
          if (uVar10 <= uVar12) {
            return uVar13;
          }
        } while( true );
    }

    // Token : 0x600072C
    // RVA   : 0x216660   Offset: 0x214E60   Length: 0x21
    public virtual IAsyncResult BeginInvoke(string name, AsyncCallback callback, object object)
    {
        ulong local_18;
        ulong local_10;
        local_10 = 0;
        local_18 = name;
        il2cpp_internal(this,&local_18);
    }

    // Token : 0x600072D
    // RVA   : 0x3A9D90   Offset: 0x3A8590   Length: 0x29
    public virtual float EndInvoke(IAsyncResult result)
    {
        long lVar1;
        lVar1 = il2cpp_internal(result,0);
        if (lVar1 != null) {
          puVar2 = (uint32 *)il2cpp_object_unbox(lVar1);
          return *puVar2;
        }
    }

}
