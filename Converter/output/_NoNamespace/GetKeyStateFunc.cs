// ============================================================
// Type  : GetKeyStateFunc
// Token : 0x20000DC
// ============================================================

public class GetKeyStateFunc
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000726
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

    // Token : 0x6000727
    // RVA   : 0xB05FE0   Offset: 0xB047E0   Length: 0x2E3
    public virtual bool Invoke(KeyCode key)
    {
        long lVar1;
        uint uVar4;
        bool cVar5;
        ulong in_RAX;
        ulong uVar6;
        long lVar7;
        long lVar9;
        ushort uVar10;
        ulong uVar11;
        ulong uVar13;
        long local_res8;
        uint local_res10;
        local_res10 = key;
        local_res8 = this;
        lVar1 = *(int64 *)(this + 104);
        if (lVar1 == null) {
          uVar13 = 1;
          plVar12 = &local_res8;
        }
        else {
          uVar13 = *(uint64 *)(lVar1 + 24);
          plVar12 = (int64 *)(lVar1 + 32);
          if (uVar13 == 0) {
            return in_RAX & 0xffffffffffffff00;
          }
        }
        uVar11 = 0;
        do {
          lVar1 = plVar12[uVar11];
          pcVar2 = *(code **)(lVar1 + 16);
          plVar3 = *(int64 **)(lVar1 + 32);
          lVar1 = *(int64 *)(lVar1 + 40);
          if (*(short *)(lVar1 + 72) == -1) {
            il2cpp_internal(lVar1);
          }
          cVar5 = FUN_1800d6050(lVar1);
          if (!cVar5) {
            if ((((plVar3 == (int64 *)0) || (*(short *)(lVar1 + 72) == -1)) ||
                ((*(uint32 *)(*plVar3 + 0x114) >> 8 & 1) != 0)) || (*(int64 *)(this + 24) == 0)) {
              if (*(char *)(lVar1 + 74) != false) goto LAB_180b06282;
              uVar6 = (*pcVar2)(&stack0x00000000,lVar1);
            }
            else {
              cVar5 = il2cpp_internal(lVar1);
              if (!cVar5) {
                cVar5 = FUN_1800d65c0(lVar1);
                uVar4 = local_res10;
                if (!cVar5) {
                  uVar6 = (**(code **)(*plVar3 + 0x138 + (uint64)*(uint16 *)(lVar1 + 72) * 16))
                                    (plVar3,local_res10,
                                     *(uint64 *)
                                      (*plVar3 + 0x140 + (uint64)*(uint16 *)(lVar1 + 72) * 16));
                }
                else {
                  lVar9 = il2cpp_class_get_namespace(lVar1);
                  lVar7 = *plVar3;
                  uVar10 = 0;
                  if (*(uint16 *)(lVar7 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar7 + 176) + (uint64)uVar10 * 16) == lVar9)
                      {
                        puVar8 = (uint64 *)
                                 ((int64)
                                  (int)((uint32)*(uint16 *)(lVar1 + 72) +
                                       *(int *)(*(int64 *)(lVar7 + 176) + 8 + (uint64)uVar10 * 16
                                               )) * 16 + 0x138 + lVar7);
                        uVar6 = (*(code *)*puVar8)(plVar3,uVar4,puVar8[1]);
                        goto LAB_180b0628e;
                      }
                      uVar10 = uVar10 + 1;
                    } while (uVar10 < *(uint16 *)(lVar7 + 0x12a));
                  }
                  puVar8 = (uint64 *)FUN_1800914f0(plVar3,lVar9,*(uint16 *)(lVar1 + 72));
                  uVar6 = (*(code *)*puVar8)(plVar3,uVar4,puVar8[1]);
                }
              }
              else {
                cVar5 = FUN_1800d65c0(lVar1);
                uVar4 = local_res10;
                if (!cVar5) {
                  puVar8 = (uint64 *)
                           il2cpp_internal(*(uint64 *)
                                                (*plVar3 +
                                                ((uint64)*(uint16 *)(lVar1 + 72) + 20) * 16),
                                               lVar1);
                  uVar6 = (*(code *)*puVar8)(plVar3,uVar4,puVar8);
                }
                else {
                  lVar7 = *plVar3;
                  uVar10 = 0;
                  if (*(uint16 *)(lVar7 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar7 + 176) + (uint64)uVar10 * 16) ==
                          *(int64 *)(lVar1 + 24)) {
                        lVar7 = (int64)
                                (int)((uint32)*(uint16 *)(lVar1 + 72) +
                                     *(int *)(*(int64 *)(lVar7 + 176) + 8 + (uint64)uVar10 * 16))
                                * 16 + 0x138 + lVar7;
                        goto LAB_180b06146;
                      }
                      uVar10 = uVar10 + 1;
                    } while (uVar10 < *(uint16 *)(lVar7 + 0x12a));
                  }
                  lVar7 = FUN_1800914f0(plVar3,*(int64 *)(lVar1 + 24),*(uint16 *)(lVar1 + 72));
        LAB_180b06146:
                  puVar8 = (uint64 *)il2cpp_internal(*(uint64 *)(lVar7 + 8),lVar1);
                  uVar6 = (*(code *)*puVar8)(plVar3,uVar4,puVar8);
                }
              }
            }
          }
          else if (*(char *)(lVar1 + 74) == true) {
            uVar6 = (*pcVar2)(local_res10,lVar1);
          }
          else {
        LAB_180b06282:
            uVar6 = (*pcVar2)(plVar3,local_res10,lVar1);
          }
        LAB_180b0628e:
          uVar11 = uVar11 + 1;
          if (uVar13 <= uVar11) {
            return uVar6;
          }
        } while( true );
    }

    // Token : 0x6000728
    // RVA   : 0xB05F60   Offset: 0xB04760   Length: 0x7A
    public virtual IAsyncResult BeginInvoke(KeyCode key, AsyncCallback callback, object object)
    {
        void GetKeyStateFunc.BeginInvoke
                     (uint64 this,uint32 key,uint64 callback,uint64 object)
        {
        uint32 local_res10 [2];
        uint64 local_18;
        uint64 local_10;
        local_res10[0] = key;
        local_10 = 0;
        local_18 = il2cpp_value_box(DAT_181d5f0f8,local_res10);
        il2cpp_internal(this,&local_18,callback,object);
    }

    // Token : 0x6000729
    // RVA   : 0x28D420   Offset: 0x28BC20   Length: 0x28
    public virtual bool EndInvoke(IAsyncResult result)
    {
        long lVar1;
        lVar1 = il2cpp_internal(result,0);
        if (lVar1 != null) {
          puVar2 = (uint8 *)il2cpp_object_unbox(lVar1);
          return *puVar2;
        }
    }

}
