// ============================================================
// Type  : LoadFunction
// Token : 0x2000081
// ============================================================

public class LoadFunction
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000341
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

    // Token : 0x6000342
    // RVA   : 0x8C66B0   Offset: 0x8C4EB0   Length: 0x43A
    public virtual byte[] Invoke(string path)
    {
        long lVar1;
        bool cVar4;
        ulong uVar5;
        long lVar6;
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
            return 0;
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
              goto LAB_1808c6aae;
              cVar4 = il2cpp_internal(lVar1);
              if (!cVar4) {
                cVar4 = FUN_1800d65c0(lVar1);
                if (!cVar4) {
                  uVar5 = (**(code **)(*plVar3 + 0x138 + (uint64)*(uint16 *)(lVar1 + 72) * 16))
                                    (plVar3,path,
                                     *(uint64 *)
                                      (*plVar3 + 0x140 + (uint64)*(uint16 *)(lVar1 + 72) * 16));
                }
                else {
                  lVar8 = il2cpp_class_get_namespace(lVar1);
                  lVar6 = *plVar3;
                  uVar10 = 0;
                  if (*(uint16 *)(lVar6 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar6 + 176) + (uint64)uVar10 * 16) == lVar8)
                      {
                        puVar7 = (uint64 *)
                                 ((int64)
                                  (int)((uint32)*(uint16 *)(lVar1 + 72) +
                                       *(int *)(*(int64 *)(lVar6 + 176) + 8 + (uint64)uVar10 * 16
                                               )) * 16 + 0x138 + lVar6);
                        uVar5 = (*(code *)*puVar7)(plVar3,path,puVar7[1]);
                        goto LAB_1808c6ab9;
                      }
                      uVar10 = uVar10 + 1;
                    } while (uVar10 < *(uint16 *)(lVar6 + 0x12a));
                  }
                  puVar7 = (uint64 *)FUN_1800914f0(plVar3,lVar8,*(uint16 *)(lVar1 + 72));
                  uVar5 = (*(code *)*puVar7)(plVar3,path,puVar7[1]);
                }
              }
              else {
                cVar4 = FUN_1800d65c0(lVar1);
                uVar10 = *(uint16 *)(lVar1 + 72);
                if (!cVar4) {
                  puVar7 = (uint64 *)
                           il2cpp_internal(*(uint64 *)
                                                (*plVar3 + ((uint64)uVar10 + 20) * 16),lVar1);
                  uVar5 = (*(code *)*puVar7)(plVar3,path,puVar7);
                }
                else {
                  lVar6 = *plVar3;
                  uVar9 = 0;
                  if (*(uint16 *)(lVar6 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar6 + 176) + (uint64)uVar9 * 16) ==
                          *(int64 *)(lVar1 + 24)) {
                        lVar6 = (int64)
                                (int)((uint32)uVar10 +
                                     *(int *)(*(int64 *)(lVar6 + 176) + 8 + (uint64)uVar9 * 16))
                                * 16 + 0x138 + lVar6;
                        goto LAB_1808c6986;
                      }
                      uVar9 = uVar9 + 1;
                    } while (uVar9 < *(uint16 *)(lVar6 + 0x12a));
                  }
                  lVar6 = FUN_1800914f0(plVar3,*(int64 *)(lVar1 + 24),uVar10);
        LAB_1808c6986:
                  puVar7 = (uint64 *)il2cpp_internal(*(uint64 *)(lVar6 + 8),lVar1);
                  uVar5 = (*(code *)*puVar7)(plVar3,path,puVar7);
                }
              }
            }
            else {
              if ((*(short *)(lVar1 + 72) == -1) || (*(int64 *)(this + 24) == 0))
              goto LAB_1808c6749;
              cVar4 = il2cpp_internal(lVar1);
              if (!cVar4) {
                cVar4 = FUN_1800d65c0(lVar1);
                if (!cVar4) {
                  uVar5 = (**(code **)(*path + 0x138 + (uint64)*(uint16 *)(lVar1 + 72) * 16))
                                    (path,*(uint64 *)
                                              (*path + 0x140 +
                                              (uint64)*(uint16 *)(lVar1 + 72) * 16));
                }
                else {
                  lVar8 = il2cpp_class_get_namespace(lVar1);
                  lVar6 = *path;
                  uVar10 = 0;
                  if (*(uint16 *)(lVar6 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar6 + 176) + (uint64)uVar10 * 16) == lVar8)
                      {
                        puVar7 = (uint64 *)
                                 ((int64)
                                  (int)((uint32)*(uint16 *)(lVar1 + 72) +
                                       *(int *)(*(int64 *)(lVar6 + 176) + 8 + (uint64)uVar10 * 16
                                               )) * 16 + 0x138 + lVar6);
                        uVar5 = (*(code *)*puVar7)(path,puVar7[1]);
                        goto LAB_1808c6ab9;
                      }
                      uVar10 = uVar10 + 1;
                    } while (uVar10 < *(uint16 *)(lVar6 + 0x12a));
                  }
                  puVar7 = (uint64 *)FUN_1800914f0(path,lVar8,*(uint16 *)(lVar1 + 72));
                  uVar5 = (*(code *)*puVar7)(path,puVar7[1]);
                }
              }
              else {
                cVar4 = FUN_1800d65c0(lVar1);
                uVar10 = *(uint16 *)(lVar1 + 72);
                if (!cVar4) {
                  uVar5 = *(uint64 *)(*path + ((uint64)uVar10 + 20) * 16);
                }
                else {
                  lVar6 = *path;
                  uVar9 = 0;
                  if (*(uint16 *)(lVar6 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar6 + 176) + (uint64)uVar9 * 16) ==
                          *(int64 *)(lVar1 + 24)) {
                        uVar5 = *(uint64 *)
                                 ((int64)
                                  (int)((uint32)uVar10 +
                                       *(int *)(*(int64 *)(lVar6 + 176) + 8 + (uint64)uVar9 * 16)
                                       ) * 16 + lVar6 + 0x140);
                        goto LAB_1808c680b;
                      }
                      uVar9 = uVar9 + 1;
                    } while (uVar9 < *(uint16 *)(lVar6 + 0x12a));
                  }
                  lVar6 = FUN_1800914f0(path,*(int64 *)(lVar1 + 24),uVar10);
                  uVar5 = *(uint64 *)(lVar6 + 8);
                }
        LAB_1808c680b:
                puVar7 = (uint64 *)il2cpp_internal(uVar5,lVar1);
                uVar5 = (*(code *)*puVar7)(path,puVar7);
              }
            }
          }
          else if (*(char *)(lVar1 + 74) == true) {
        LAB_1808c6749:
            uVar5 = (*pcVar2)(path,lVar1);
          }
          else {
        LAB_1808c6aae:
            uVar5 = (*pcVar2)(plVar3,path,lVar1);
          }
        LAB_1808c6ab9:
          uVar13 = uVar13 + 1;
          if (uVar11 <= uVar13) {
            return uVar5;
          }
        } while( true );
    }

    // Token : 0x6000343
    // RVA   : 0x216660   Offset: 0x214E60   Length: 0x21
    public virtual IAsyncResult BeginInvoke(string path, AsyncCallback callback, object object)
    {
        ulong local_18;
        ulong local_10;
        local_10 = 0;
        local_18 = path;
        il2cpp_internal(this,&local_18);
    }

    // Token : 0x6000344
    // RVA   : 0x210040   Offset: 0x20E840   Length: 0xA
    public virtual byte[] EndInvoke(IAsyncResult result)
    {
        il2cpp_internal(result,0);
    }

}
