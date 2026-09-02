// ============================================================
// Type  : OnDragCB
// Token : 0x2000112
// ============================================================

public class OnDragCB
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000942
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

    // Token : 0x6000943
    // RVA   : 0xB086A0   Offset: 0xB06EA0   Length: 0x372
    public virtual void Invoke(object obj, Vector2 delta)
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
          cVar4 = FUN_1800d6050(lVar1);
          if (!cVar4) {
            if (*(char *)(lVar1 + 74) == '\x02') {
              if ((((plVar3 == (int64 *)0) || (*(short *)(lVar1 + 72) == -1)) ||
                  ((*(uint32 *)(*plVar3 + 0x114) >> 8 & 1) != 0)) || (*(int64 *)(this + 24) == 0))
              goto LAB_180b089cc;
              cVar4 = il2cpp_internal(lVar1);
              if (!cVar4) {
                cVar4 = FUN_1800d65c0(lVar1);
                if (!cVar4) {
                  (**(code **)(*plVar3 + 0x138 + (uint64)*(uint16 *)(lVar1 + 72) * 16))
                            (plVar3,obj,delta,
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
                        goto LAB_180b08976;
                      }
                      uVar10 = uVar10 + 1;
                    } while (uVar10 < *(uint16 *)(lVar7 + 0x12a));
                  }
                  puVar5 = (uint64 *)FUN_1800914f0(plVar3,lVar8,*(uint16 *)(lVar1 + 72));
        LAB_180b08976:
                  (*(code *)*puVar5)(plVar3,obj,delta,puVar5[1]);
                }
              }
              else {
                cVar4 = FUN_1800d65c0(lVar1);
                uVar10 = *(uint16 *)(lVar1 + 72);
                if (!cVar4) {
                  uVar6 = *(uint64 *)(*plVar3 + ((uint64)uVar10 + 20) * 16);
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
                        goto LAB_180b088c6;
                      }
                      uVar9 = uVar9 + 1;
                    } while (uVar9 < *(uint16 *)(lVar7 + 0x12a));
                  }
                  lVar7 = FUN_1800914f0(plVar3,*(int64 *)(lVar1 + 24),uVar10);
        LAB_180b088c6:
                  uVar6 = *(uint64 *)(lVar7 + 8);
                }
                puVar5 = (uint64 *)il2cpp_internal(uVar6,lVar1);
                (*(code *)*puVar5)(plVar3,obj,delta,puVar5);
              }
            }
            else {
              if ((*(short *)(lVar1 + 72) == -1) || (*(int64 *)(this + 24) == 0))
              goto LAB_180b0873b;
              cVar4 = il2cpp_internal(lVar1);
              if (!cVar4) {
                cVar4 = FUN_1800d65c0(lVar1);
                if (!cVar4) {
                  (**(code **)(*obj + 0x138 + (uint64)*(uint16 *)(lVar1 + 72) * 16))
                            (obj,delta,
                             *(uint64 *)
                              (*obj + 0x140 + (uint64)*(uint16 *)(lVar1 + 72) * 16));
                }
                else {
                  uVar6 = il2cpp_class_get_namespace(lVar1);
                  FUN_18014a870(*(uint16 *)(lVar1 + 72),uVar6,obj,delta);
                }
              }
              else {
                cVar4 = FUN_1800d65c0(lVar1);
                if (!cVar4) {
                  puVar5 = (uint64 *)
                           il2cpp_internal(*(uint64 *)
                                                (*obj +
                                                ((uint64)*(uint16 *)(lVar1 + 72) + 20) * 16),
                                               lVar1);
                  (*(code *)*puVar5)(obj,delta,puVar5);
                }
                else {
                  FUN_18014a4a0(lVar1,obj,delta);
                }
              }
            }
          }
          else if (*(char *)(lVar1 + 74) == '\x02') {
        LAB_180b0873b:
            (*pcVar2)(obj,delta,lVar1);
          }
          else {
        LAB_180b089cc:
            (*pcVar2)(plVar3,obj,delta,lVar1);
          }
          uVar13 = uVar13 + 1;
          if (uVar11 <= uVar13) {
            return;
          }
        } while( true );
    }

    // Token : 0x6000944
    // RVA   : 0xB08610   Offset: 0xB06E10   Length: 0x82
    public virtual IAsyncResult BeginInvoke(object obj, Vector2 delta, AsyncCallback callback, object object)
    {
        void OnDragCB.BeginInvoke
                     (uint64 this,uint64 obj,uint64 delta,uint64 callback,
                     uint64 object)
        {
        uint64 local_28;
        uint64 local_20;
        uint64 local_18;
        uint64 local_10;
        local_28 = delta;
        local_10 = 0;
        local_20 = obj;
        local_18 = il2cpp_value_box(DAT_181d8e698,&local_28);
        il2cpp_internal(this,&local_20,callback,object);
    }

    // Token : 0x6000945
    // RVA   : 0x210040   Offset: 0x20E840   Length: 0xA
    public virtual void EndInvoke(IAsyncResult result)
    {
        il2cpp_internal(result,0);
    }

}
