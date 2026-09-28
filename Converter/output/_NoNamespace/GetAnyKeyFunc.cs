// ============================================================
// Type  : GetAnyKeyFunc
// Token : 0x20000DF
// ============================================================

public class GetAnyKeyFunc
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000746
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

    // Token : 0x6000747
    // RVA   : 0x8E4D90   Offset: 0x8E4190   Length: 0x292
    public virtual bool Invoke()
    {
        long lVar1;
        bool cVar4;
        ulong in_RAX;
        ulong uVar5;
        long lVar6;
        long lVar8;
        ushort uVar9;
        ushort uVar10;
        ulong uVar11;
        ulong uVar12;
        ulong uVar14;
        long local_res8;
        local_res8 = this;
        lVar6 = *(int64 *)(this + 104);
        if (lVar6 == null) {
          uVar14 = 1;
          plVar13 = &local_res8;
        }
        else {
          uVar14 = *(uint64 *)(lVar6 + 24);
          plVar13 = (int64 *)(lVar6 + 32);
          if (uVar14 == 0) {
            return in_RAX & 0xffffffffffffff00;
          }
        }
        uVar12 = 0;
        do {
          lVar6 = plVar13[uVar12];
          lVar1 = *(int64 *)(lVar6 + 40);
          pcVar2 = *(code **)(lVar6 + 16);
          plVar3 = *(int64 **)(lVar6 + 32);
          if (*(short *)(lVar1 + 72) == -1) {
            il2cpp_internal(lVar1);
          }
          cVar4 = FUN_1800d6050(lVar1);
          if (!cVar4) {
            if ((((plVar3 == (int64 *)0) || (*(short *)(lVar1 + 72) == -1)) ||
                ((*(uint32 *)(*plVar3 + 0x114) >> 8 & 1) != 0)) || (*(int64 *)(this + 24) == 0))
            goto LAB_1808e4fe5;
            cVar4 = il2cpp_internal(lVar1);
            if (!cVar4) {
              cVar4 = FUN_1800d65c0(lVar1);
              if (!cVar4) {
                uVar5 = (**(code **)(*plVar3 + 0x138 + (uint64)*(uint16 *)(lVar1 + 72) * 16))
                                  (plVar3,*(uint64 *)
                                           (*plVar3 + 0x140 + (uint64)*(uint16 *)(lVar1 + 72) * 16)
                                  );
              }
              else {
                lVar8 = il2cpp_class_get_namespace(lVar1);
                lVar6 = *plVar3;
                uVar5 = 0;
                if (*(uint16 *)(lVar6 + 0x12a) != 0) {
                  do {
                    if (*(int64 *)(*(int64 *)(lVar6 + 176) + uVar5 * 16) == lVar8) {
                      puVar7 = (uint64 *)
                               ((int64)
                                (int)((uint32)*(uint16 *)(lVar1 + 72) +
                                     *(int *)(*(int64 *)(lVar6 + 176) + 8 + uVar5 * 16)) * 16 +
                                0x138 + lVar6);
                      uVar5 = (*(code *)*puVar7)(plVar3,puVar7[1]);
                      goto LAB_1808e4fed;
                    }
                    uVar10 = (short)uVar5 + 1;
                    uVar5 = (uint64)uVar10;
                  } while (uVar10 < *(uint16 *)(lVar6 + 0x12a));
                }
                puVar7 = (uint64 *)FUN_1800914f0(plVar3,lVar8,*(uint16 *)(lVar1 + 72));
                uVar5 = (*(code *)*puVar7)(plVar3,puVar7[1]);
              }
            }
            else {
              cVar4 = FUN_1800d65c0(lVar1);
              uVar10 = *(uint16 *)(lVar1 + 72);
              if (!cVar4) {
                uVar11 = *(uint64 *)(*plVar3 + ((uint64)uVar10 + 20) * 16);
              }
              else {
                lVar6 = *plVar3;
                uVar5 = 0;
                if (*(uint16 *)(lVar6 + 0x12a) != 0) {
                  do {
                    if (*(int64 *)(*(int64 *)(lVar6 + 176) + uVar5 * 16) ==
                        *(int64 *)(lVar1 + 24)) {
                      lVar6 = (int64)
                              (int)((uint32)uVar10 +
                                   *(int *)(*(int64 *)(lVar6 + 176) + 8 + uVar5 * 16)) * 16 +
                              0x138 + lVar6;
                      goto LAB_1808e4ee6;
                    }
                    uVar9 = (short)uVar5 + 1;
                    uVar5 = (uint64)uVar9;
                  } while (uVar9 < *(uint16 *)(lVar6 + 0x12a));
                }
                lVar6 = FUN_1800914f0(plVar3,*(int64 *)(lVar1 + 24),uVar10);
        LAB_1808e4ee6:
                uVar11 = *(uint64 *)(lVar6 + 8);
              }
              puVar7 = (uint64 *)il2cpp_internal(uVar11,lVar1);
              uVar5 = (*(code *)*puVar7)(plVar3,puVar7);
            }
          }
          else if (*(char *)(lVar1 + 74) == false) {
            uVar5 = (*pcVar2)(lVar1);
          }
          else {
        LAB_1808e4fe5:
            uVar5 = (*pcVar2)(plVar3,lVar1);
          }
        LAB_1808e4fed:
          uVar12 = uVar12 + 1;
          if (uVar14 <= uVar12) {
            return uVar5;
          }
        } while( true );
    }

    // Token : 0x6000748
    // RVA   : 0x2F7010   Offset: 0x2F6410   Length: 0x22
    public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object)
    {
        ulong[] local_18 = new ulong[3];
        local_18[0] = 0;
        il2cpp_internal(this,local_18,callback,object);
    }

    // Token : 0x6000749
    // RVA   : 0x28D420   Offset: 0x28C820   Length: 0x28
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
