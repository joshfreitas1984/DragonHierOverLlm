// ============================================================
// Type  : OnRenderCallback
// Token : 0x200009B
// ============================================================

public class OnRenderCallback
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000498
    // RVA   : 0x562E40   Offset: 0x561C40   Length: 0x6A
    public void /*ctor*/(object object, IntPtr method)
    {
        bool cVar1;
        ulong uVar2;
        if (object == null) {
          cVar1 = FUN_1801dfd30(method);
          if (!cVar1) {
            uVar2 = il2cpp_internal(0,"Delegate to an instance method cannot have null \'this\'.");
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar2,0);
          }
        }
        *(uint64 *)(this + 16) = *method;
        *(int64 *)(this + 32) = object;
        *(uint64 **)(this + 40) = method;
    }

    // Token : 0x6000499
    // RVA   : 0x606C80   Offset: 0x605A80   Length: 0x36A
    public virtual void Invoke(Material mat)
    {
        long lVar1;
        bool cVar4;
        ulong uVar6;
        long lVar7;
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
          cVar4 = FUN_1801dfd30(lVar1);
          if (!cVar4) {
            if (*(char *)(lVar1 + 74) == true) {
              if ((((plVar3 == (int64 *)0) || (*(short *)(lVar1 + 72) == -1)) ||
                  ((*(uint32 *)(*plVar3 + 0x114) >> 8 & 1) != 0)) || (*(int64 *)(this + 24) == 0))
              goto LAB_180606fae;
              cVar4 = il2cpp_internal(lVar1);
              if (!cVar4) {
                cVar4 = FUN_1801e02a0(lVar1);
                if (!cVar4) {
                  (**(code **)(*plVar3 + 0x138 + (uint64)*(uint16 *)(lVar1 + 72) * 16))
                            (plVar3,mat,
                             *(uint64 *)
                              (*plVar3 + 0x140 + (uint64)*(uint16 *)(lVar1 + 72) * 16));
                }
                else {
                  lVar8 = il2cpp_class_get_namespace(lVar1);
                  lVar7 = *plVar3;
                  uVar10 = 0;
                  if (*(uint16 *)(lVar7 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar7 + 176) + (uint64)uVar10 * 16) == lVar8)
                      {
                        puVar5 = (uint64 *)
                                 ((int64)
                                  (int)((uint32)*(uint16 *)(lVar1 + 72) +
                                       *(int *)(*(int64 *)(lVar7 + 176) + 8 + (uint64)uVar10 * 16
                                               )) * 16 + 0x138 + lVar7);
                        (*(code *)*puVar5)(plVar3,mat,puVar5[1]);
                        goto LAB_180606fb9;
                      }
                      uVar10 = uVar10 + 1;
                    } while (uVar10 < *(uint16 *)(lVar7 + 0x12a));
                  }
                  puVar5 = (uint64 *)FUN_18019b1f0(plVar3,lVar8,*(uint16 *)(lVar1 + 72));
                  (*(code *)*puVar5)(plVar3,mat,puVar5[1]);
                }
              }
              else {
                cVar4 = FUN_1801e02a0(lVar1);
                uVar10 = *(uint16 *)(lVar1 + 72);
                if (!cVar4) {
                  puVar5 = (uint64 *)
                           il2cpp_internal(*(uint64 *)
                                                (*plVar3 + ((uint64)uVar10 + 20) * 16),lVar1);
                  (*(code *)*puVar5)(plVar3,mat,puVar5);
                }
                else {
                  lVar7 = *plVar3;
                  uVar9 = 0;
                  if (*(uint16 *)(lVar7 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar7 + 176) + (uint64)uVar9 * 16) ==
                          *(int64 *)(lVar1 + 24)) {
                        lVar7 = (int64)
                                (int)((uint32)uVar10 +
                                     *(int *)(*(int64 *)(lVar7 + 176) + 8 + (uint64)uVar9 * 16))
                                * 16 + 0x138 + lVar7;
                        goto LAB_180606e86;
                      }
                      uVar9 = uVar9 + 1;
                    } while (uVar9 < *(uint16 *)(lVar7 + 0x12a));
                  }
                  lVar7 = FUN_18019b1f0(plVar3,*(int64 *)(lVar1 + 24),uVar10);
        LAB_180606e86:
                  puVar5 = (uint64 *)il2cpp_internal(*(uint64 *)(lVar7 + 8),lVar1);
                  (*(code *)*puVar5)(plVar3,mat,puVar5);
                }
              }
            }
            else {
              if ((*(short *)(lVar1 + 72) == -1) || (*(int64 *)(this + 24) == 0))
              goto LAB_180606d18;
              cVar4 = il2cpp_internal(lVar1);
              if (!cVar4) {
                cVar4 = FUN_1801e02a0(lVar1);
                if (!cVar4) {
                  (**(code **)(*mat + 0x138 + (uint64)*(uint16 *)(lVar1 + 72) * 16))
                            (mat,*(uint64 *)
                                      (*mat + 0x140 + (uint64)*(uint16 *)(lVar1 + 72) * 16));
                }
                else {
                  uVar6 = il2cpp_class_get_namespace(lVar1);
                  FUN_180002280(*(uint16 *)(lVar1 + 72),uVar6,mat);
                }
              }
              else {
                cVar4 = FUN_1801e02a0(lVar1);
                if (!cVar4) {
                  puVar5 = (uint64 *)
                           il2cpp_internal(*(uint64 *)
                                                (*mat +
                                                ((uint64)*(uint16 *)(lVar1 + 72) + 20) * 16),
                                               lVar1);
                  (*(code *)*puVar5)(mat,puVar5);
                }
                else {
                  FUN_1800600c0(lVar1,mat);
                }
              }
            }
          }
          else if (*(char *)(lVar1 + 74) == true) {
        LAB_180606d18:
            (*pcVar2)(mat,lVar1);
          }
          else {
        LAB_180606fae:
            (*pcVar2)(plVar3,mat,lVar1);
          }
        LAB_180606fb9:
          uVar13 = uVar13 + 1;
          if (uVar11 <= uVar13) {
            return;
          }
        } while( true );
    }

    // Token : 0x600049A
    // RVA   : 0x604820   Offset: 0x603620   Length: 0x21
    public virtual IAsyncResult BeginInvoke(Material mat, AsyncCallback callback, object object)
    {
        ulong local_18;
        ulong local_10;
        local_10 = 0;
        local_18 = mat;
        il2cpp_internal(this,&local_18);
    }

    // Token : 0x600049B
    // RVA   : 0x562C40   Offset: 0x561A40   Length: 0xA
    public virtual void EndInvoke(IAsyncResult result)
    {
        il2cpp_internal(result,0);
    }

}
