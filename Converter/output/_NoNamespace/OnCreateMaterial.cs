// ============================================================
// Type  : OnCreateMaterial
// Token : 0x2000107
// ============================================================

public class OnCreateMaterial
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60008CE
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

    // Token : 0x60008CF
    // RVA   : 0xB07BB0   Offset: 0xB063B0   Length: 0x49B
    public virtual Material Invoke(UIWidget widget, Material mat)
    {
        long lVar1;
        bool cVar4;
        ulong uVar5;
        long lVar6;
        long lVar8;
        ushort uVar9;
        ushort uVar10;
        ulong uVar12;
        ulong uVar13;
        long local_res8;
        local_res8 = this;
        lVar1 = *(int64 *)(this + 104);
        if (lVar1 == null) {
          plVar11 = &local_res8;
          uVar12 = 1;
        }
        else {
          uVar12 = *(uint64 *)(lVar1 + 24);
          plVar11 = (int64 *)(lVar1 + 32);
          if (uVar12 == 0) {
            return 0;
          }
        }
        uVar13 = 0;
        do {
          lVar1 = plVar11[uVar13];
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
              goto LAB_180b08007;
              cVar4 = il2cpp_internal(lVar1);
              if (!cVar4) {
                cVar4 = FUN_1800d65c0(lVar1);
                if (!cVar4) {
                  uVar5 = (**(code **)(*plVar3 + 0x138 + (uint64)*(uint16 *)(lVar1 + 72) * 16))
                                    (plVar3,widget,mat,
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
                        uVar5 = (*(code *)*puVar7)(plVar3,widget,mat,puVar7[1]);
                        goto LAB_180b08015;
                      }
                      uVar10 = uVar10 + 1;
                    } while (uVar10 < *(uint16 *)(lVar6 + 0x12a));
                  }
                  puVar7 = (uint64 *)FUN_1800914f0(plVar3,lVar8,*(uint16 *)(lVar1 + 72));
                  uVar5 = (*(code *)*puVar7)(plVar3,widget,mat,puVar7[1]);
                }
              }
              else {
                cVar4 = FUN_1800d65c0(lVar1);
                uVar10 = *(uint16 *)(lVar1 + 72);
                if (!cVar4) {
                  puVar7 = (uint64 *)
                           il2cpp_internal(*(uint64 *)
                                                (*plVar3 + ((uint64)uVar10 + 20) * 16),lVar1);
                  uVar5 = (*(code *)*puVar7)(plVar3,widget,mat,puVar7);
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
                        goto LAB_180b07ed6;
                      }
                      uVar9 = uVar9 + 1;
                    } while (uVar9 < *(uint16 *)(lVar6 + 0x12a));
                  }
                  lVar6 = FUN_1800914f0(plVar3,*(int64 *)(lVar1 + 24),uVar10);
        LAB_180b07ed6:
                  puVar7 = (uint64 *)il2cpp_internal(*(uint64 *)(lVar6 + 8),lVar1);
                  uVar5 = (*(code *)*puVar7)(plVar3,widget,mat,puVar7);
                }
              }
            }
            else {
              if ((*(short *)(lVar1 + 72) == -1) || (*(int64 *)(this + 24) == 0))
              goto LAB_180b07c57;
              cVar4 = il2cpp_internal(lVar1);
              if (!cVar4) {
                cVar4 = FUN_1800d65c0(lVar1);
                if (!cVar4) {
                  uVar5 = (**(code **)(*widget + 0x138 + (uint64)*(uint16 *)(lVar1 + 72) * 16))
                                    (widget,mat,
                                     *(uint64 *)
                                      (*widget + 0x140 + (uint64)*(uint16 *)(lVar1 + 72) * 16));
                }
                else {
                  lVar8 = il2cpp_class_get_namespace(lVar1);
                  lVar6 = *widget;
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
                        uVar5 = (*(code *)*puVar7)(widget,mat,puVar7[1]);
                        goto LAB_180b08015;
                      }
                      uVar10 = uVar10 + 1;
                    } while (uVar10 < *(uint16 *)(lVar6 + 0x12a));
                  }
                  puVar7 = (uint64 *)FUN_1800914f0(widget,lVar8,*(uint16 *)(lVar1 + 72));
                  uVar5 = (*(code *)*puVar7)(widget,mat,puVar7[1]);
                }
              }
              else {
                cVar4 = FUN_1800d65c0(lVar1);
                uVar10 = *(uint16 *)(lVar1 + 72);
                if (!cVar4) {
                  puVar7 = (uint64 *)
                           il2cpp_internal(*(uint64 *)
                                                (*widget + ((uint64)uVar10 + 20) * 16),lVar1);
                  uVar5 = (*(code *)*puVar7)(widget,mat,puVar7);
                }
                else {
                  lVar6 = *widget;
                  uVar9 = 0;
                  if (*(uint16 *)(lVar6 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar6 + 176) + (uint64)uVar9 * 16) ==
                          *(int64 *)(lVar1 + 24)) {
                        lVar6 = (int64)
                                (int)((uint32)uVar10 +
                                     *(int *)(*(int64 *)(lVar6 + 176) + 8 + (uint64)uVar9 * 16))
                                * 16 + 0x138 + lVar6;
                        goto LAB_180b07cf6;
                      }
                      uVar9 = uVar9 + 1;
                    } while (uVar9 < *(uint16 *)(lVar6 + 0x12a));
                  }
                  lVar6 = FUN_1800914f0(widget,*(int64 *)(lVar1 + 24),uVar10);
        LAB_180b07cf6:
                  puVar7 = (uint64 *)il2cpp_internal(*(uint64 *)(lVar6 + 8),lVar1);
                  uVar5 = (*(code *)*puVar7)(widget,mat,puVar7);
                }
              }
            }
          }
          else if (*(char *)(lVar1 + 74) == '\x02') {
        LAB_180b07c57:
            uVar5 = (*pcVar2)(widget,mat,lVar1);
          }
          else {
        LAB_180b08007:
            uVar5 = (*pcVar2)(plVar3,widget,mat,lVar1);
          }
        LAB_180b08015:
          uVar13 = uVar13 + 1;
          if (uVar12 <= uVar13) {
            return uVar5;
          }
        } while( true );
    }

    // Token : 0x60008D0
    // RVA   : 0x28D3E0   Offset: 0x28BBE0   Length: 0x31
    public virtual IAsyncResult BeginInvoke(UIWidget widget, Material mat, AsyncCallback callback, object object)
    {
        void OnCreateMaterial.BeginInvoke
                     (uint64 this,uint64 widget,uint64 mat,uint64 callback,
                     uint64 object)
        {
        uint64 local_28;
        uint64 local_20;
        uint64 local_18;
        local_18 = 0;
        local_28 = widget;
        local_20 = mat;
        il2cpp_internal(this,&local_28,callback,object);
    }

    // Token : 0x60008D1
    // RVA   : 0x210040   Offset: 0x20E840   Length: 0xA
    public virtual Material EndInvoke(IAsyncResult result)
    {
        il2cpp_internal(result,0);
    }

}
