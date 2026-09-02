// ============================================================
// Type  : OnInitializeItem
// Token : 0x2000074
// ============================================================

public class OnInitializeItem
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60002A3
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

    // Token : 0x60002A4
    // RVA   : 0xB08B50   Offset: 0xB07350   Length: 0x124
    public virtual void Invoke(GameObject go, int wrapIndex, int realIndex)
    {
        void OnInitializeItem.Invoke
                     (int64 this,int64 *go,uint32 wrapIndex,uint32 realIndex)
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
              goto LAB_180b08f99;
              cVar3 = il2cpp_internal(lVar11);
              if (!cVar3) {
                cVar3 = FUN_1800d65c0(lVar11);
                if (!cVar3) {
                  lVar11 = (uint64)*(uint16 *)(lVar11 + 72) * 16 + *plVar2;
                  (**(code **)(lVar11 + 0x138))
                            (plVar2,go,wrapIndex,realIndex,*(uint64 *)(lVar11 + 0x140));
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
                        goto LAB_180b08f38;
                      }
                      uVar9 = uVar9 + 1;
                    } while (uVar9 < *(uint16 *)(lVar5 + 0x12a));
                  }
                  puVar6 = (uint64 *)FUN_1800914f0(plVar2,lVar7,*(uint16 *)(lVar11 + 72));
        LAB_180b08f38:
                  (*(code *)*puVar6)(plVar2,go,wrapIndex,realIndex,puVar6[1]);
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
                        goto LAB_180b08e86;
                      }
                      uVar8 = uVar8 + 1;
                    } while (uVar8 < *(uint16 *)(lVar5 + 0x12a));
                  }
                  lVar5 = FUN_1800914f0(plVar2,*(int64 *)(lVar11 + 24),uVar9);
        LAB_180b08e86:
                  uVar10 = *(uint64 *)(lVar5 + 8);
                }
                puVar6 = (uint64 *)il2cpp_internal(uVar10,lVar11);
                (*(code *)*puVar6)(plVar2,go,wrapIndex,realIndex,puVar6);
              }
            }
            else {
              if ((*(short *)(lVar11 + 72) == -1) || (*(int64 *)(this + 24) == 0))
              goto LAB_180b08c07;
              cVar3 = il2cpp_internal(lVar11);
              if (!cVar3) {
                cVar3 = FUN_1800d65c0(lVar11);
                if (!cVar3) {
                  (**(code **)(*go + 0x138 + (uint64)*(uint16 *)(lVar11 + 72) * 16))
                            (go,wrapIndex,realIndex,
                             *(uint64 *)
                              (*go + 0x140 + (uint64)*(uint16 *)(lVar11 + 72) * 16));
                }
                else {
                  lVar7 = il2cpp_class_get_namespace(lVar11);
                  lVar5 = *go;
                  uVar9 = 0;
                  if (*(uint16 *)(lVar5 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar5 + 176) + (uint64)uVar9 * 16) == lVar7) {
                        puVar6 = (uint64 *)
                                 ((int64)
                                  (int)((uint32)*(uint16 *)(lVar11 + 72) +
                                       *(int *)(*(int64 *)(lVar5 + 176) + 8 + (uint64)uVar9 * 16)
                                       ) * 16 + 0x138 + lVar5);
                        (*(code *)*puVar6)(go,wrapIndex,realIndex,puVar6[1]);
                        goto LAB_180b08fac;
                      }
                      uVar9 = uVar9 + 1;
                    } while (uVar9 < *(uint16 *)(lVar5 + 0x12a));
                  }
                  puVar6 = (uint64 *)FUN_1800914f0(go,lVar7,*(uint16 *)(lVar11 + 72));
                  (*(code *)*puVar6)(go,wrapIndex,realIndex,puVar6[1]);
                }
              }
              else {
                cVar3 = FUN_1800d65c0(lVar11);
                uVar9 = *(uint16 *)(lVar11 + 72);
                if (!cVar3) {
                  puVar6 = (uint64 *)
                           il2cpp_internal(*(uint64 *)
                                                (*go + ((uint64)uVar9 + 20) * 16),lVar11);
                  (*(code *)*puVar6)(go,wrapIndex,realIndex,puVar6);
                }
                else {
                  lVar5 = *go;
                  uVar8 = 0;
                  if (*(uint16 *)(lVar5 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar5 + 176) + (uint64)uVar8 * 16) ==
                          *(int64 *)(lVar11 + 24)) {
                        lVar5 = (int64)
                                (int)((uint32)uVar9 +
                                     *(int *)(*(int64 *)(lVar5 + 176) + 8 + (uint64)uVar8 * 16))
                                * 16 + 0x138 + lVar5;
                        goto LAB_180b08ca6;
                      }
                      uVar8 = uVar8 + 1;
                    } while (uVar8 < *(uint16 *)(lVar5 + 0x12a));
                  }
                  lVar5 = FUN_1800914f0(go,*(int64 *)(lVar11 + 24),uVar9);
        LAB_180b08ca6:
                  puVar6 = (uint64 *)il2cpp_internal(*(uint64 *)(lVar5 + 8),lVar11);
                  (*(code *)*puVar6)(go,wrapIndex,realIndex,puVar6);
                }
              }
            }
          }
          else if (*(char *)(lVar11 + 74) == '\x03') {
        LAB_180b08c07:
            (*pcVar1)(go,wrapIndex,realIndex,lVar11);
          }
          else {
        LAB_180b08f99:
            (*pcVar1)(plVar2,go,wrapIndex,realIndex,lVar11);
          }
        LAB_180b08fac:
          uVar12 = uVar12 + 1;
          if (local_38 <= uVar12) {
            return;
          }
        } while( true );
    }

    // Token : 0x60002A5
    // RVA   : 0xB08AB0   Offset: 0xB072B0   Length: 0x92
    public virtual IAsyncResult BeginInvoke(GameObject go, int wrapIndex, int realIndex, AsyncCallback callback, object object)
    {
        void OnInitializeItem.BeginInvoke
                     (uint64 this,uint64 go,uint32 wrapIndex,uint32 realIndex,
                     uint64 callback,uint64 object)
        {
        uint32 local_res18 [2];
        uint32 local_res20 [2];
        uint64 local_28;
        uint64 local_20;
        uint64 local_18;
        uint64 local_10;
        local_res18[0] = wrapIndex;
        local_res20[0] = realIndex;
        local_10 = 0;
        local_28 = go;
        local_20 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
        local_18 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
        il2cpp_internal(this,&local_28,callback,object);
    }

    // Token : 0x60002A6
    // RVA   : 0x210040   Offset: 0x20E840   Length: 0xA
    public virtual void EndInvoke(IAsyncResult result)
    {
        il2cpp_internal(result,0);
    }

}
