// ============================================================
// Type  : OnPostFillCallback
// Token : 0x20000AE
// ============================================================

public class OnPostFillCallback
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600055C
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

    // Token : 0x600055D
    // RVA   : 0xB090A0   Offset: 0xB078A0   Length: 0x507
    public virtual void Invoke(UIWidget widget, int bufferOffset, List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
    {
        void OnPostFillCallback.Invoke
                     (int64 this,int64 *widget,uint32 bufferOffset,uint64 verts,
                     uint64 uvs,uint64 cols)
        {
        code *pcVar1;
        int64 *plVar2;
        char cVar3;
        int64 lVar4;
        uint64 *puVar5;
        int64 lVar6;
        uint16 uVar7;
        uint16 uVar8;
        uint64 uVar9;
        int64 *plVar10;
        int64 lVar11;
        int64 local_res8;
        uint64 local_48;
        uint64 local_40;
        local_res8 = this;
        lVar11 = *(int64 *)(this + 104);
        if (lVar11 == null) {
          plVar10 = &local_res8;
          local_40 = 1;
        }
        else {
          local_40 = *(uint64 *)(lVar11 + 24);
          plVar10 = (int64 *)(lVar11 + 32);
          if (local_40 == 0) {
            return;
          }
        }
        local_48 = 0;
        do {
          lVar11 = plVar10[local_48];
          pcVar1 = *(code **)(lVar11 + 16);
          plVar2 = *(int64 **)(lVar11 + 32);
          lVar11 = *(int64 *)(lVar11 + 40);
          if (*(short *)(lVar11 + 72) == -1) {
            il2cpp_internal(lVar11);
          }
          cVar3 = FUN_1800d6050(lVar11);
          if (!cVar3) {
            if (*(char *)(lVar11 + 74) == '\x05') {
              if ((((plVar2 == (int64 *)0) || (*(short *)(lVar11 + 72) == -1)) ||
                  ((*(uint32 *)(*plVar2 + 0x114) >> 8 & 1) != 0)) || (*(int64 *)(local_res8 + 24) == 0)
                 ) goto LAB_180b0953b;
              cVar3 = il2cpp_internal(lVar11);
              if (!cVar3) {
                cVar3 = FUN_1800d65c0(lVar11);
                if (!cVar3) {
                  lVar11 = (uint64)*(uint16 *)(lVar11 + 72) * 16 + *plVar2;
                  (**(code **)(lVar11 + 0x138))
                            (plVar2,widget,bufferOffset,verts,uvs,cols,
                             *(uint64 *)(lVar11 + 0x140));
                }
                else {
                  lVar6 = il2cpp_class_get_namespace(lVar11);
                  lVar4 = *plVar2;
                  uVar8 = 0;
                  if (*(uint16 *)(lVar4 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar4 + 176) + (uint64)uVar8 * 16) == lVar6) {
                        puVar5 = (uint64 *)
                                 ((int64)
                                  (int)((uint32)*(uint16 *)(lVar11 + 72) +
                                       *(int *)(*(int64 *)(lVar4 + 176) + 8 + (uint64)uVar8 * 16)
                                       ) * 16 + 0x138 + lVar4);
                        goto LAB_180b094c6;
                      }
                      uVar8 = uVar8 + 1;
                    } while (uVar8 < *(uint16 *)(lVar4 + 0x12a));
                  }
                  puVar5 = (uint64 *)FUN_1800914f0(plVar2,lVar6,*(uint16 *)(lVar11 + 72));
        LAB_180b094c6:
                  (*(code *)*puVar5)(plVar2,widget,bufferOffset,verts,uvs,cols,puVar5[1]);
                }
              }
              else {
                cVar3 = FUN_1800d65c0(lVar11);
                uVar8 = *(uint16 *)(lVar11 + 72);
                if (!cVar3) {
                  uVar9 = *(uint64 *)(*plVar2 + ((uint64)uVar8 + 20) * 16);
                }
                else {
                  lVar4 = *plVar2;
                  uVar7 = 0;
                  if (*(uint16 *)(lVar4 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar4 + 176) + (uint64)uVar7 * 16) ==
                          *(int64 *)(lVar11 + 24)) {
                        lVar4 = (int64)
                                (int)((uint32)uVar8 +
                                     *(int *)(*(int64 *)(lVar4 + 176) + 8 + (uint64)uVar7 * 16))
                                * 16 + 0x138 + lVar4;
                        goto LAB_180b09406;
                      }
                      uVar7 = uVar7 + 1;
                    } while (uVar7 < *(uint16 *)(lVar4 + 0x12a));
                  }
                  lVar4 = FUN_1800914f0(plVar2,*(int64 *)(lVar11 + 24),uVar8);
        LAB_180b09406:
                  uVar9 = *(uint64 *)(lVar4 + 8);
                }
                puVar5 = (uint64 *)il2cpp_internal(uVar9,lVar11);
                (*(code *)*puVar5)(plVar2,widget,bufferOffset,verts,uvs,cols,puVar5);
              }
            }
            else {
              if ((*(short *)(lVar11 + 72) == -1) || (*(int64 *)(local_res8 + 24) == 0))
              goto LAB_180b09177;
              cVar3 = il2cpp_internal(lVar11);
              if (!cVar3) {
                cVar3 = FUN_1800d65c0(lVar11);
                if (!cVar3) {
                  lVar11 = (uint64)*(uint16 *)(lVar11 + 72) * 16 + *widget;
                  (**(code **)(lVar11 + 0x138))
                            (widget,bufferOffset,verts,uvs,cols,*(uint64 *)(lVar11 + 0x140));
                }
                else {
                  lVar6 = il2cpp_class_get_namespace(lVar11);
                  lVar4 = *widget;
                  uVar8 = 0;
                  if (*(uint16 *)(lVar4 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar4 + 176) + (uint64)uVar8 * 16) == lVar6) {
                        puVar5 = (uint64 *)
                                 ((int64)
                                  (int)((uint32)*(uint16 *)(lVar11 + 72) +
                                       *(int *)(*(int64 *)(lVar4 + 176) + 8 + (uint64)uVar8 * 16)
                                       ) * 16 + 0x138 + lVar4);
                        goto LAB_180b092e6;
                      }
                      uVar8 = uVar8 + 1;
                    } while (uVar8 < *(uint16 *)(lVar4 + 0x12a));
                  }
                  puVar5 = (uint64 *)FUN_1800914f0(widget,lVar6,*(uint16 *)(lVar11 + 72));
        LAB_180b092e6:
                  (*(code *)*puVar5)(widget,bufferOffset,verts,uvs,cols,puVar5[1]);
                }
              }
              else {
                cVar3 = FUN_1800d65c0(lVar11);
                uVar8 = *(uint16 *)(lVar11 + 72);
                if (!cVar3) {
                  uVar9 = *(uint64 *)(*widget + ((uint64)uVar8 + 20) * 16);
                }
                else {
                  lVar4 = *widget;
                  uVar7 = 0;
                  if (*(uint16 *)(lVar4 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar4 + 176) + (uint64)uVar7 * 16) ==
                          *(int64 *)(lVar11 + 24)) {
                        uVar9 = *(uint64 *)
                                 ((int64)
                                  (int)((uint32)uVar8 +
                                       *(int *)(*(int64 *)(lVar4 + 176) + 8 + (uint64)uVar7 * 16)
                                       ) * 16 + lVar4 + 0x140);
                        goto LAB_180b09259;
                      }
                      uVar7 = uVar7 + 1;
                    } while (uVar7 < *(uint16 *)(lVar4 + 0x12a));
                  }
                  lVar4 = FUN_1800914f0(widget,*(int64 *)(lVar11 + 24),uVar8);
                  uVar9 = *(uint64 *)(lVar4 + 8);
                }
        LAB_180b09259:
                puVar5 = (uint64 *)il2cpp_internal(uVar9,lVar11);
                (*(code *)*puVar5)(widget,bufferOffset,verts,uvs,cols,puVar5);
              }
            }
          }
          else if (*(char *)(lVar11 + 74) == '\x05') {
        LAB_180b09177:
            (*pcVar1)(widget,bufferOffset,verts,uvs,cols,lVar11);
          }
          else {
        LAB_180b0953b:
            (*pcVar1)(plVar2,widget,bufferOffset,verts,uvs,cols,lVar11);
          }
          local_48 = local_48 + 1;
          if (local_40 <= local_48) {
            return;
          }
        } while( true );
    }

    // Token : 0x600055E
    // RVA   : 0xB08FF0   Offset: 0xB077F0   Length: 0xA9
    public virtual IAsyncResult BeginInvoke(UIWidget widget, int bufferOffset, List<Vector3> verts, List<Vector2> uvs, List<Color> cols, AsyncCallback callback, object object)
    {
        void OnPostFillCallback.BeginInvoke
                     (uint64 this,uint64 widget,uint32 bufferOffset,uint64 verts,
                     uint64 uvs,uint64 cols,uint64 callback,uint64 object)
        {
        uint32 local_res18 [4];
        uint64 local_38;
        uint64 local_30;
        uint64 local_28;
        uint64 local_20;
        uint64 local_18;
        uint64 local_10;
        local_res18[0] = bufferOffset;
        local_10 = 0;
        local_38 = widget;
        local_30 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
        local_20 = uvs;
        local_18 = cols;
        local_28 = verts;
        il2cpp_internal(this,&local_38,callback,object);
    }

    // Token : 0x600055F
    // RVA   : 0x210040   Offset: 0x20E840   Length: 0xA
    public virtual void EndInvoke(IAsyncResult result)
    {
        il2cpp_internal(result,0);
    }

}
