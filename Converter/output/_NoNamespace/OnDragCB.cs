// ============================================================
// Type  : OnDragCB
// Token : 0x2000113
// ============================================================

public class OnDragCB
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600095A
    // RVA   : 0x210320   Offset: 0x20F720   Length: 0x6A
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

    // Token : 0x600095B
    // RVA   : 0x183D220   Offset: 0x183C620   Length: 0x442
    public virtual void Invoke(object obj, Vector2 delta)
    {
        long lVar1;
        bool cVar4;
        long lVar5;
        long lVar7;
        ushort uVar8;
        ushort uVar9;
        ulong uVar10;
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
              goto LAB_18183d61c;
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
                        goto LAB_18183d5c6;
                      }
                      uVar9 = uVar9 + 1;
                    } while (uVar9 < *(uint16 *)(lVar5 + 0x12a));
                  }
                  puVar6 = (uint64 *)FUN_1800914f0(plVar3,lVar7,*(uint16 *)(lVar1 + 72));
        LAB_18183d5c6:
                  (*(code *)*puVar6)(plVar3,obj,delta,puVar6[1]);
                }
              }
              else {
                cVar4 = FUN_1800d65c0(lVar1);
                uVar9 = *(uint16 *)(lVar1 + 72);
                if (!cVar4) {
                  uVar10 = *(uint64 *)(*plVar3 + ((uint64)uVar9 + 20) * 16);
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
                        goto LAB_18183d516;
                      }
                      uVar8 = uVar8 + 1;
                    } while (uVar8 < *(uint16 *)(lVar5 + 0x12a));
                  }
                  lVar5 = FUN_1800914f0(plVar3,*(int64 *)(lVar1 + 24),uVar9);
        LAB_18183d516:
                  uVar10 = *(uint64 *)(lVar5 + 8);
                }
                puVar6 = (uint64 *)il2cpp_internal(uVar10,lVar1);
                (*(code *)*puVar6)(plVar3,obj,delta,puVar6);
              }
            }
            else {
              if ((*(short *)(lVar1 + 72) == -1) || (*(int64 *)(this + 24) == 0))
              goto LAB_18183d2bb;
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
                  lVar7 = il2cpp_class_get_namespace(lVar1);
                  lVar5 = *obj;
                  uVar9 = 0;
                  if (*(uint16 *)(lVar5 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar5 + 176) + (uint64)uVar9 * 16) == lVar7) {
                        puVar6 = (uint64 *)
                                 ((int64)
                                  (int)((uint32)*(uint16 *)(lVar1 + 72) +
                                       *(int *)(*(int64 *)(lVar5 + 176) + 8 + (uint64)uVar9 * 16)
                                       ) * 16 + 0x138 + lVar5);
                        (*(code *)*puVar6)(obj,delta,puVar6[1]);
                        goto LAB_18183d62c;
                      }
                      uVar9 = uVar9 + 1;
                    } while (uVar9 < *(uint16 *)(lVar5 + 0x12a));
                  }
                  puVar6 = (uint64 *)FUN_1800914f0(obj,lVar7,*(uint16 *)(lVar1 + 72));
                  (*(code *)*puVar6)(obj,delta,puVar6[1]);
                }
              }
              else {
                cVar4 = FUN_1800d65c0(lVar1);
                uVar9 = *(uint16 *)(lVar1 + 72);
                if (!cVar4) {
                  uVar10 = *(uint64 *)(*obj + ((uint64)uVar9 + 20) * 16);
                }
                else {
                  lVar5 = *obj;
                  uVar8 = 0;
                  if (*(uint16 *)(lVar5 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar5 + 176) + (uint64)uVar8 * 16) ==
                          *(int64 *)(lVar1 + 24)) {
                        uVar10 = *(uint64 *)
                                  ((int64)
                                   (int)((uint32)uVar9 +
                                        *(int *)(*(int64 *)(lVar5 + 176) + 8 + (uint64)uVar8 * 16
                                                )) * 16 + lVar5 + 0x140);
                        goto LAB_18183d389;
                      }
                      uVar8 = uVar8 + 1;
                    } while (uVar8 < *(uint16 *)(lVar5 + 0x12a));
                  }
                  lVar5 = FUN_1800914f0(obj,*(int64 *)(lVar1 + 24),uVar9);
                  uVar10 = *(uint64 *)(lVar5 + 8);
                }
        LAB_18183d389:
                puVar6 = (uint64 *)il2cpp_internal(uVar10,lVar1);
                (*(code *)*puVar6)(obj,delta,puVar6);
              }
            }
          }
          else if (*(char *)(lVar1 + 74) == '\x02') {
        LAB_18183d2bb:
            (*pcVar2)(obj,delta,lVar1);
          }
          else {
        LAB_18183d61c:
            (*pcVar2)(plVar3,obj,delta,lVar1);
          }
        LAB_18183d62c:
          uVar13 = uVar13 + 1;
          if (uVar11 <= uVar13) {
            return;
          }
        } while( true );
    }

    // Token : 0x600095C
    // RVA   : 0x183D190   Offset: 0x183C590   Length: 0x82
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
        local_18 = il2cpp_value_box(DAT_181db3950,&local_28);
        il2cpp_internal(this,&local_20,callback,object);
    }

    // Token : 0x600095D
    // RVA   : 0x210040   Offset: 0x20F440   Length: 0xA
    public virtual void EndInvoke(IAsyncResult result)
    {
        il2cpp_internal(result,0);
    }

}
