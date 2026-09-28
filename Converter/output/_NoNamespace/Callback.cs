// ============================================================
// Type  : Callback
// Token : 0x2000080
// ============================================================

public class Callback
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000335
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

    // Token : 0x6000336
    // RVA   : 0x33B950   Offset: 0x33AD50   Length: 0x282
    public virtual void Invoke()
    {
        long lVar1;
        bool cVar4;
        long lVar5;
        long lVar7;
        ushort uVar8;
        ushort uVar9;
        ulong uVar11;
        ulong uVar12;
        ulong uVar14;
        long local_res8;
        ulong uVar10;
        local_res8 = this;
        lVar5 = *(int64 *)(this + 104);
        if (lVar5 == null) {
          uVar14 = 1;
          plVar13 = &local_res8;
        }
        else {
          uVar14 = *(uint64 *)(lVar5 + 24);
          plVar13 = (int64 *)(lVar5 + 32);
          if (uVar14 == 0) {
            return;
          }
        }
        uVar12 = 0;
        do {
          lVar5 = plVar13[uVar12];
          lVar1 = *(int64 *)(lVar5 + 40);
          pcVar2 = *(code **)(lVar5 + 16);
          plVar3 = *(int64 **)(lVar5 + 32);
          if (*(short *)(lVar1 + 72) == -1) {
            il2cpp_internal(lVar1);
          }
          cVar4 = FUN_1800d6050(lVar1);
          if (!cVar4) {
            if ((((plVar3 == (int64 *)0) || (*(short *)(lVar1 + 72) == -1)) ||
                ((*(uint32 *)(*plVar3 + 0x114) >> 8 & 1) != 0)) || (*(int64 *)(this + 24) == 0))
            goto LAB_18033bb95;
            cVar4 = il2cpp_internal(lVar1);
            if (!cVar4) {
              cVar4 = FUN_1800d65c0(lVar1);
              if (!cVar4) {
                (**(code **)(*plVar3 + 0x138 + (uint64)*(uint16 *)(lVar1 + 72) * 16))
                          (plVar3,*(uint64 *)
                                   (*plVar3 + 0x140 + (uint64)*(uint16 *)(lVar1 + 72) * 16));
              }
              else {
                lVar7 = il2cpp_class_get_namespace(lVar1);
                lVar5 = *plVar3;
                uVar10 = 0;
                if (*(uint16 *)(lVar5 + 0x12a) != 0) {
                  do {
                    if (*(int64 *)(*(int64 *)(lVar5 + 176) + uVar10 * 16) == lVar7) {
                      puVar6 = (uint64 *)
                               ((int64)
                                (int)((uint32)*(uint16 *)(lVar1 + 72) +
                                     *(int *)(*(int64 *)(lVar5 + 176) + 8 + uVar10 * 16)) * 16 +
                                0x138 + lVar5);
                      (*(code *)*puVar6)(plVar3,puVar6[1]);
                      goto LAB_18033bb9d;
                    }
                    uVar9 = (short)uVar10 + 1;
                    uVar10 = (uint64)uVar9;
                  } while (uVar9 < *(uint16 *)(lVar5 + 0x12a));
                }
                puVar6 = (uint64 *)FUN_1800914f0(plVar3,lVar7,*(uint16 *)(lVar1 + 72));
                (*(code *)*puVar6)(plVar3,puVar6[1]);
              }
            }
            else {
              cVar4 = FUN_1800d65c0(lVar1);
              uVar9 = *(uint16 *)(lVar1 + 72);
              if (!cVar4) {
                uVar11 = *(uint64 *)(*plVar3 + ((uint64)uVar9 + 20) * 16);
              }
              else {
                lVar5 = *plVar3;
                uVar10 = 0;
                if (*(uint16 *)(lVar5 + 0x12a) != 0) {
                  do {
                    if (*(int64 *)(*(int64 *)(lVar5 + 176) + uVar10 * 16) ==
                        *(int64 *)(lVar1 + 24)) {
                      lVar5 = (int64)
                              (int)((uint32)uVar9 +
                                   *(int *)(*(int64 *)(lVar5 + 176) + 8 + uVar10 * 16)) * 16 +
                              0x138 + lVar5;
                      goto LAB_18033ba96;
                    }
                    uVar8 = (short)uVar10 + 1;
                    uVar10 = (uint64)uVar8;
                  } while (uVar8 < *(uint16 *)(lVar5 + 0x12a));
                }
                lVar5 = FUN_1800914f0(plVar3,*(int64 *)(lVar1 + 24),uVar9);
        LAB_18033ba96:
                uVar11 = *(uint64 *)(lVar5 + 8);
              }
              puVar6 = (uint64 *)il2cpp_internal(uVar11,lVar1);
              (*(code *)*puVar6)(plVar3,puVar6);
            }
          }
          else if (*(char *)(lVar1 + 74) == false) {
            (*pcVar2)(lVar1);
          }
          else {
        LAB_18033bb95:
            (*pcVar2)(plVar3,lVar1);
          }
        LAB_18033bb9d:
          uVar12 = uVar12 + 1;
          if (uVar14 <= uVar12) {
            return;
          }
        } while( true );
    }

    // Token : 0x6000337
    // RVA   : 0x2F7010   Offset: 0x2F6410   Length: 0x22
    public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object)
    {
        ulong[] local_18 = new ulong[3];
        local_18[0] = 0;
        il2cpp_internal(this,local_18,callback,object);
    }

    // Token : 0x6000338
    // RVA   : 0x210040   Offset: 0x20F440   Length: 0xA
    public virtual void EndInvoke(IAsyncResult result)
    {
        il2cpp_internal(result,0);
    }

}
