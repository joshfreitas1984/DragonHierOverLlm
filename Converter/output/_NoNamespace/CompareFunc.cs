// ============================================================
// Type  : CompareFunc
// Token : 0x200007A
// ============================================================

public class CompareFunc
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60002E4
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

    // Token : 0x60002E5
    // RVA   : 0x10D5720   Offset: 0x10D3F20   Length: 0x347
    public virtual int Invoke(T left, T right)
    {
        long lVar1;
        ulong uVar4;
        bool cVar5;
        ulong uVar6;
        long lVar7;
        long lVar9;
        ushort uVar10;
        ulong uVar12;
        ulong uVar13;
        ulong uVar14;
        uint uVar15;
        uint uVar16;
        uint uVar17;
        uint uVar18;
        long local_res8;
        ulong local_58;
        ulong uStack_50;
        uint local_48;
        uint uStack_44;
        uint uStack_40;
        uint32 uStack_3c;
        local_res8 = this;
        lVar7 = *(int64 *)(this + 104);
        if (lVar7 == null) {
          plVar11 = &local_res8;
          uVar14 = 1;
        }
        else {
          uVar14 = *(uint64 *)(lVar7 + 24);
          plVar11 = (int64 *)(lVar7 + 32);
          if (uVar14 == 0) {
            return 0;
          }
        }
        uVar13 = 0;
        do {
          lVar7 = plVar11[uVar13];
          lVar1 = *(int64 *)(lVar7 + 40);
          pcVar2 = *(code **)(lVar7 + 16);
          plVar3 = *(int64 **)(lVar7 + 32);
          if (*(short *)(lVar1 + 72) == -1) {
            il2cpp_internal(lVar1);
          }
          cVar5 = FUN_1800d6050(lVar1);
          if (!cVar5) {
            if ((((plVar3 == (int64 *)0) || (*(short *)(lVar1 + 72) == -1)) ||
                ((*(uint32 *)(*plVar3 + 0x114) >> 8 & 1) != 0)) || (*(int64 *)(local_res8 + 24) == 0))
            {
              local_48 = *(uint32 *)right;
              uStack_44 = *(uint32 *)((int64)right + 4);
              uStack_40 = *(uint32 *)(right + 1);
              uStack_3c = *(uint32 *)((int64)right + 12);
              if (*(char *)(lVar1 + 74) != true) {
                uVar15 = *(uint32 *)left;
                uVar16 = *(uint32 *)((int64)left + 4);
                uVar17 = *(uint32 *)(left + 1);
                uVar18 = *(uint32 *)((int64)left + 12);
                goto LAB_1810d5a10;
              }
              uVar6 = (*pcVar2)(left + -2,&local_48,lVar1);
            }
            else {
              cVar5 = il2cpp_internal(lVar1);
              if (!cVar5) {
                cVar5 = FUN_1800d65c0(lVar1);
                if (!cVar5) {
                  local_48 = *(uint32 *)right;
                  uStack_44 = *(uint32 *)((int64)right + 4);
                  uStack_40 = *(uint32 *)(right + 1);
                  uStack_3c = *(uint32 *)((int64)right + 12);
                  local_58 = *left;
                  uStack_50 = left[1];
                  uVar6 = (**(code **)(*plVar3 + 0x138 + (uint64)*(uint16 *)(lVar1 + 72) * 16))
                                    (plVar3,&local_58,&local_48,
                                     *(uint64 *)
                                      (*plVar3 + 0x140 + (uint64)*(uint16 *)(lVar1 + 72) * 16));
                }
                else {
                  uVar6 = *left;
                  uVar4 = left[1];
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
                        goto LAB_1810d5976;
                      }
                      uVar10 = uVar10 + 1;
                    } while (uVar10 < *(uint16 *)(lVar7 + 0x12a));
                  }
                  puVar8 = (uint64 *)FUN_1800914f0(plVar3,lVar9,*(uint16 *)(lVar1 + 72));
        LAB_1810d5976:
                  local_48 = *(uint32 *)right;
                  uStack_44 = *(uint32 *)((int64)right + 4);
                  uStack_40 = *(uint32 *)(right + 1);
                  uStack_3c = *(uint32 *)((int64)right + 12);
                  local_58 = uVar6;
                  uStack_50 = uVar4;
                  uVar6 = (*(code *)*puVar8)(plVar3,&local_58,&local_48,puVar8[1]);
                }
              }
              else {
                cVar5 = FUN_1800d65c0(lVar1);
                uVar6 = *left;
                uVar4 = left[1];
                if (!cVar5) {
                  uVar12 = *(uint64 *)(*plVar3 + ((uint64)*(uint16 *)(lVar1 + 72) + 20) * 16)
                  ;
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
                        goto LAB_1810d58a6;
                      }
                      uVar10 = uVar10 + 1;
                    } while (uVar10 < *(uint16 *)(lVar7 + 0x12a));
                  }
                  lVar7 = FUN_1800914f0(plVar3,*(int64 *)(lVar1 + 24),*(uint16 *)(lVar1 + 72));
        LAB_1810d58a6:
                  uVar12 = *(uint64 *)(lVar7 + 8);
                }
                puVar8 = (uint64 *)il2cpp_internal(uVar12,lVar1);
                local_48 = *(uint32 *)right;
                uStack_44 = *(uint32 *)((int64)right + 4);
                uStack_40 = *(uint32 *)(right + 1);
                uStack_3c = *(uint32 *)((int64)right + 12);
                local_58 = uVar6;
                uStack_50 = uVar4;
                uVar6 = (*(code *)*puVar8)(plVar3,&local_58,&local_48,puVar8);
              }
            }
          }
          else {
            local_48 = *(uint32 *)right;
            uStack_44 = *(uint32 *)((int64)right + 4);
            local_58 = *right;
            uStack_40 = *(uint32 *)(right + 1);
            uStack_3c = *(uint32 *)((int64)right + 12);
            uStack_50 = right[1];
            uVar15 = *(uint32 *)left;
            uVar16 = *(uint32 *)((int64)left + 4);
            uVar17 = *(uint32 *)(left + 1);
            uVar18 = *(uint32 *)((int64)left + 12);
            if (*(char *)(lVar1 + 74) == '\x02') {
              local_48 = uVar15;
              uStack_44 = uVar16;
              uStack_40 = uVar17;
              uStack_3c = uVar18;
              uVar6 = (*pcVar2)(&local_48,&local_58,lVar1);
            }
            else {
        LAB_1810d5a10:
              local_58 = CONCAT44(uVar16,uVar15);
              uStack_50 = CONCAT44(uVar18,uVar17);
              uVar6 = (*pcVar2)(plVar3,&local_58,&local_48,lVar1);
            }
          }
          uVar13 = uVar13 + 1;
          if (uVar14 <= uVar13) {
            return uVar6;
          }
        } while( true );
    }

    // Token : 0x60002E6
    // RVA   : 0x10D4D30   Offset: 0x10D3530   Length: 0x97
    public virtual IAsyncResult BeginInvoke(T left, T right, AsyncCallback callback, object object)
    {
        void CompareFunc.BeginInvoke
                     (uint64 this,uint64 left,uint64 right,uint64 callback,
                     uint64 object)
        {
        uint64 local_28;
        uint64 local_20;
        uint64 local_18;
        local_18 = 0;
        local_28 = il2cpp_value_box(DAT_181d931c0,left);
        local_20 = il2cpp_value_box(DAT_181d931c0,right);
        il2cpp_internal(this,&local_28,callback,object);
    }

    // Token : 0x60002E7
    // RVA   : 0x219140   Offset: 0x217940   Length: 0x27
    public virtual int EndInvoke(IAsyncResult result)
    {
        long lVar1;
        lVar1 = il2cpp_internal(result,0);
        if (lVar1 != null) {
          puVar2 = (uint32 *)il2cpp_object_unbox(lVar1);
          return *puVar2;
        }
    }

}
