// ============================================================
// Type  : OnCreateDrawCall
// Token : 0x200009C
// ============================================================

public class OnCreateDrawCall
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600049D
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

    // Token : 0x600049E
    // RVA   : 0x2BD600   Offset: 0x2BBE00   Length: 0x49A
    public virtual void Invoke(UIDrawCall dc, MeshFilter filter, MeshRenderer ren)
    {
        void OnCreateDrawCall.Invoke
                     (int64 this,int64 *dc,uint64 filter,uint64 ren)
        {
        code *pcVar1;
        int64 *plVar2;
        char cVar3;
        int64 *plVar4;
        int64 lVar5;
        uint64 *puVar6;
        int64 lVar7;
        uint16 uVar8;
        uint16 uVar9;
        uint64 uVar10;
        int64 lVar11;
        uint64 uVar12;
        int64 local_res8;
        uint64 local_38;
        local_res8 = this;
        lVar11 = *(int64 *)(this + 104);
        if (lVar11 == null) {
          plVar4 = &local_res8;
          local_38 = 1;
        }
        else {
          local_38 = *(uint64 *)(lVar11 + 24);
          plVar4 = (int64 *)(lVar11 + 32);
          if (local_38 == 0) {
            return;
          }
        }
        uVar12 = 0;
        do {
          lVar11 = plVar4[uVar12];
          pcVar1 = *(code **)(lVar11 + 16);
          plVar2 = *(int64 **)(lVar11 + 32);
          lVar11 = *(int64 *)(lVar11 + 40);
          if (*(short *)(lVar11 + 72) == -1) {
            il2cpp_internal(lVar11);
          }
          cVar3 = FUN_1800d6050(lVar11);
          if (!cVar3) {
            if (*(char *)(lVar11 + 74) == '\x03') {
              if ((((plVar2 == (int64 *)0) || (*(short *)(lVar11 + 72) == -1)) ||
                  ((*(uint32 *)(*plVar2 + 0x114) >> 8 & 1) != 0)) || (*(int64 *)(this + 24) == 0))
              goto LAB_1802bda49;
              cVar3 = il2cpp_internal(lVar11);
              if (!cVar3) {
                cVar3 = FUN_1800d65c0(lVar11);
                if (!cVar3) {
                  lVar11 = (uint64)*(uint16 *)(lVar11 + 72) * 16 + *plVar2;
                  (**(code **)(lVar11 + 0x138))
                            (plVar2,dc,filter,ren,*(uint64 *)(lVar11 + 0x140));
                }
                else {
                  lVar7 = il2cpp_class_get_namespace(lVar11);
                  lVar5 = *plVar2;
                  uVar9 = 0;
                  if (*(uint16 *)(lVar5 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar5 + 176) + (uint64)uVar9 * 16) == lVar7) {
                        puVar6 = (uint64 *)
                                 ((int64)
                                  (int)((uint32)*(uint16 *)(lVar11 + 72) +
                                       *(int *)(*(int64 *)(lVar5 + 176) + 8 + (uint64)uVar9 * 16)
                                       ) * 16 + 0x138 + lVar5);
                        goto LAB_1802bd9e8;
                      }
                      uVar9 = uVar9 + 1;
                    } while (uVar9 < *(uint16 *)(lVar5 + 0x12a));
                  }
                  puVar6 = (uint64 *)FUN_1800914f0(plVar2,lVar7,*(uint16 *)(lVar11 + 72));
        LAB_1802bd9e8:
                  (*(code *)*puVar6)(plVar2,dc,filter,ren,puVar6[1]);
                }
              }
              else {
                cVar3 = FUN_1800d65c0(lVar11);
                uVar9 = *(uint16 *)(lVar11 + 72);
                if (!cVar3) {
                  uVar10 = *(uint64 *)(*plVar2 + ((uint64)uVar9 + 20) * 16);
                }
                else {
                  lVar5 = *plVar2;
                  uVar8 = 0;
                  if (*(uint16 *)(lVar5 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar5 + 176) + (uint64)uVar8 * 16) ==
                          *(int64 *)(lVar11 + 24)) {
                        lVar5 = (int64)
                                (int)((uint32)uVar9 +
                                     *(int *)(*(int64 *)(lVar5 + 176) + 8 + (uint64)uVar8 * 16))
                                * 16 + 0x138 + lVar5;
                        goto LAB_1802bd936;
                      }
                      uVar8 = uVar8 + 1;
                    } while (uVar8 < *(uint16 *)(lVar5 + 0x12a));
                  }
                  lVar5 = FUN_1800914f0(plVar2,*(int64 *)(lVar11 + 24),uVar9);
        LAB_1802bd936:
                  uVar10 = *(uint64 *)(lVar5 + 8);
                }
                puVar6 = (uint64 *)il2cpp_internal(uVar10,lVar11);
                (*(code *)*puVar6)(plVar2,dc,filter,ren,puVar6);
              }
            }
            else {
              if ((*(short *)(lVar11 + 72) == -1) || (*(int64 *)(this + 24) == 0))
              goto LAB_1802bd6b7;
              cVar3 = il2cpp_internal(lVar11);
              if (!cVar3) {
                cVar3 = FUN_1800d65c0(lVar11);
                if (!cVar3) {
                  (**(code **)(*dc + 0x138 + (uint64)*(uint16 *)(lVar11 + 72) * 16))
                            (dc,filter,ren,
                             *(uint64 *)
                              (*dc + 0x140 + (uint64)*(uint16 *)(lVar11 + 72) * 16));
                }
                else {
                  lVar7 = il2cpp_class_get_namespace(lVar11);
                  lVar5 = *dc;
                  uVar9 = 0;
                  if (*(uint16 *)(lVar5 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar5 + 176) + (uint64)uVar9 * 16) == lVar7) {
                        puVar6 = (uint64 *)
                                 ((int64)
                                  (int)((uint32)*(uint16 *)(lVar11 + 72) +
                                       *(int *)(*(int64 *)(lVar5 + 176) + 8 + (uint64)uVar9 * 16)
                                       ) * 16 + 0x138 + lVar5);
                        (*(code *)*puVar6)(dc,filter,ren,puVar6[1]);
                        goto LAB_1802bda5c;
                      }
                      uVar9 = uVar9 + 1;
                    } while (uVar9 < *(uint16 *)(lVar5 + 0x12a));
                  }
                  puVar6 = (uint64 *)FUN_1800914f0(dc,lVar7,*(uint16 *)(lVar11 + 72));
                  (*(code *)*puVar6)(dc,filter,ren,puVar6[1]);
                }
              }
              else {
                cVar3 = FUN_1800d65c0(lVar11);
                uVar9 = *(uint16 *)(lVar11 + 72);
                if (!cVar3) {
                  puVar6 = (uint64 *)
                           il2cpp_internal(*(uint64 *)
                                                (*dc + ((uint64)uVar9 + 20) * 16),lVar11);
                  (*(code *)*puVar6)(dc,filter,ren,puVar6);
                }
                else {
                  lVar5 = *dc;
                  uVar8 = 0;
                  if (*(uint16 *)(lVar5 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar5 + 176) + (uint64)uVar8 * 16) ==
                          *(int64 *)(lVar11 + 24)) {
                        lVar5 = (int64)
                                (int)((uint32)uVar9 +
                                     *(int *)(*(int64 *)(lVar5 + 176) + 8 + (uint64)uVar8 * 16))
                                * 16 + 0x138 + lVar5;
                        goto LAB_1802bd756;
                      }
                      uVar8 = uVar8 + 1;
                    } while (uVar8 < *(uint16 *)(lVar5 + 0x12a));
                  }
                  lVar5 = FUN_1800914f0(dc,*(int64 *)(lVar11 + 24),uVar9);
        LAB_1802bd756:
                  puVar6 = (uint64 *)il2cpp_internal(*(uint64 *)(lVar5 + 8),lVar11);
                  (*(code *)*puVar6)(dc,filter,ren,puVar6);
                }
              }
            }
          }
          else if (*(char *)(lVar11 + 74) == '\x03') {
        LAB_1802bd6b7:
            (*pcVar1)(dc,filter,ren,lVar11);
          }
          else {
        LAB_1802bda49:
            (*pcVar1)(plVar2,dc,filter,ren,lVar11);
          }
        LAB_1802bda5c:
          uVar12 = uVar12 + 1;
          if (local_38 <= uVar12) {
            return;
          }
        } while( true );
    }

    // Token : 0x600049F
    // RVA   : 0x2BD5C0   Offset: 0x2BBDC0   Length: 0x35
    public virtual IAsyncResult BeginInvoke(UIDrawCall dc, MeshFilter filter, MeshRenderer ren, AsyncCallback callback, object object)
    {
        void OnCreateDrawCall.BeginInvoke
                     (uint64 this,uint64 dc,uint64 filter,uint64 ren,
                     uint64 callback,uint64 object)
        {
        uint64 local_28;
        uint64 local_20;
        uint64 local_18;
        uint64 local_10;
        local_10 = 0;
        local_28 = dc;
        local_20 = filter;
        local_18 = ren;
        il2cpp_internal(this,&local_28,callback,object);
    }

    // Token : 0x60004A0
    // RVA   : 0x210040   Offset: 0x20E840   Length: 0xA
    public virtual void EndInvoke(IAsyncResult result)
    {
        il2cpp_internal(result,0);
    }

}
