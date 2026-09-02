// ============================================================
// Type  : HitCheck
// Token : 0x20000B0
// ============================================================

public class HitCheck
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000560
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

    // Token : 0x6000561
    // RVA   : 0xB06A60   Offset: 0xB05260   Length: 0x3B3
    public virtual bool Invoke(Vector3 worldPos)
    {
        uint uVar1;
        bool cVar4;
        ulong in_RAX;
        ulong uVar5;
        long lVar6;
        long lVar8;
        ushort uVar9;
        ushort uVar10;
        long lVar12;
        ulong uVar13;
        ulong uVar14;
        long local_res8;
        ulong uVar15;
        ulong local_a8;
        uint local_a0;
        ulong local_98;
        uint local_90;
        ulong local_88;
        uint local_80;
        ulong local_78;
        uint local_70;
        ulong local_68;
        uint local_60;
        ulong local_58;
        uint local_50;
        ulong local_48;
        uint local_40;
        local_res8 = this;
        lVar12 = *(int64 *)(this + 104);
        if (lVar12 == null) {
          plVar11 = &local_res8;
          uVar13 = 1;
        }
        else {
          uVar13 = *(uint64 *)(lVar12 + 24);
          plVar11 = (int64 *)(lVar12 + 32);
          if (uVar13 == 0) {
            return in_RAX & 0xffffffffffffff00;
          }
        }
        uVar14 = 0;
        do {
          lVar12 = plVar11[uVar14];
          pcVar2 = *(code **)(lVar12 + 16);
          plVar3 = *(int64 **)(lVar12 + 32);
          lVar12 = *(int64 *)(lVar12 + 40);
          if (*(short *)(lVar12 + 72) == -1) {
            il2cpp_internal(lVar12);
          }
          cVar4 = FUN_1800d6050(lVar12);
          if (!cVar4) {
            if ((((plVar3 == (int64 *)0) || (*(short *)(lVar12 + 72) == -1)) ||
                ((*(uint32 *)(*plVar3 + 0x114) >> 8 & 1) != 0)) || (*(int64 *)(this + 24) == 0)) {
              if (*(char *)(lVar12 + 74) != false) {
                local_48 = *worldPos;
                puVar7 = &local_48;
                local_40 = *(uint32 *)(worldPos + 1);
                goto LAB_180b06dbd;
              }
              uVar5 = (*pcVar2)(worldPos + -2,lVar12);
            }
            else {
              cVar4 = il2cpp_internal(lVar12);
              if (!cVar4) {
                cVar4 = FUN_1800d65c0(lVar12);
                uVar15 = *worldPos;
                if (!cVar4) {
                  local_50 = *(uint32 *)(worldPos + 1);
                  lVar12 = (uint64)*(uint16 *)(lVar12 + 72) * 16 + *plVar3;
                  local_58 = uVar15;
                  uVar5 = (**(code **)(lVar12 + 0x138))(plVar3,&local_58,*(uint64 *)(lVar12 + 0x140));
                }
                else {
                  uVar1 = *(uint32 *)(worldPos + 1);
                  lVar8 = il2cpp_class_get_namespace(lVar12);
                  lVar6 = *plVar3;
                  uVar10 = 0;
                  if (*(uint16 *)(lVar6 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar6 + 176) + (uint64)uVar10 * 16) == lVar8)
                      {
                        puVar7 = (uint64 *)
                                 ((int64)
                                  (int)((uint32)*(uint16 *)(lVar12 + 72) +
                                       *(int *)(*(int64 *)(lVar6 + 176) + 8 + (uint64)uVar10 * 16
                                               )) * 16 + 0x138 + lVar6);
                        goto LAB_180b06d16;
                      }
                      uVar10 = uVar10 + 1;
                    } while (uVar10 < *(uint16 *)(lVar6 + 0x12a));
                  }
                  puVar7 = (uint64 *)FUN_1800914f0(plVar3,lVar8,*(uint16 *)(lVar12 + 72));
        LAB_180b06d16:
                  local_68 = uVar15;
                  local_60 = uVar1;
                  uVar5 = (*(code *)*puVar7)(plVar3,&local_68,puVar7[1]);
                }
              }
              else {
                cVar4 = FUN_1800d65c0(lVar12);
                uVar15 = *worldPos;
                if (!cVar4) {
                  uVar1 = *(uint32 *)(worldPos + 1);
                  puVar7 = (uint64 *)
                           il2cpp_internal(*(uint64 *)
                                                (*plVar3 +
                                                ((uint64)*(uint16 *)(lVar12 + 72) + 20) * 16),
                                               lVar12);
                  local_78 = uVar15;
                  local_70 = uVar1;
                  uVar5 = (*(code *)*puVar7)(plVar3,&local_78,puVar7);
                }
                else {
                  lVar6 = *plVar3;
                  uVar1 = *(uint32 *)(worldPos + 1);
                  uVar9 = 0;
                  uVar10 = *(uint16 *)(lVar6 + 0x12a);
                  if (uVar10 != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar6 + 176) + (uint64)uVar9 * 16) ==
                          *(int64 *)(lVar12 + 24)) {
                        lVar6 = (int64)
                                (int)((uint32)*(uint16 *)(lVar12 + 72) +
                                     *(int *)(*(int64 *)(lVar6 + 176) + 8 + (uint64)uVar9 * 16))
                                * 16 + 0x138 + lVar6;
                        goto LAB_180b06c16;
                      }
                      uVar9 = uVar9 + 1;
                    } while (uVar9 < uVar10);
                  }
                  lVar6 = FUN_1800914f0(plVar3,*(int64 *)(lVar12 + 24),*(uint16 *)(lVar12 + 72),
                                        uVar10,uVar15);
        LAB_180b06c16:
                  puVar7 = (uint64 *)il2cpp_internal(*(uint64 *)(lVar6 + 8),lVar12);
                  local_88 = uVar15;
                  local_80 = uVar1;
                  uVar5 = (*(code *)*puVar7)(plVar3,&local_88,puVar7);
                }
              }
            }
          }
          else if (*(char *)(lVar12 + 74) == true) {
            local_a8 = *worldPos;
            local_a0 = *(uint32 *)(worldPos + 1);
            uVar5 = (*pcVar2)(&local_a8,lVar12);
          }
          else {
            puVar7 = &local_98;
            local_98 = *worldPos;
            local_90 = *(uint32 *)(worldPos + 1);
        LAB_180b06dbd:
            uVar5 = (*pcVar2)(plVar3,puVar7,lVar12);
          }
          uVar14 = uVar14 + 1;
          if (uVar13 <= uVar14) {
            return uVar5;
          }
        } while( true );
    }

    // Token : 0x6000562
    // RVA   : 0xB069D0   Offset: 0xB051D0   Length: 0x81
    public virtual IAsyncResult BeginInvoke(Vector3 worldPos, AsyncCallback callback, object object)
    {
        void HitCheck.BeginInvoke
                     (uint64 this,uint64 worldPos,uint64 callback,uint64 object)
        {
        uint64 local_18;
        uint64 local_10;
        local_10 = 0;
        local_18 = il2cpp_value_box(DAT_181d8e8b8,worldPos);
        il2cpp_internal(this,&local_18,callback,object);
    }

    // Token : 0x6000563
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
