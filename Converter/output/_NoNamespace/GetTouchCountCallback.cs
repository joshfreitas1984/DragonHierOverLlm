// ============================================================
// Type  : GetTouchCountCallback
// Token : 0x20000EF
// ============================================================

public class GetTouchCountCallback
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000767
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

    // Token : 0x6000768
    // RVA   : 0x2F7040   Offset: 0x2F5840   Length: 0x217
    public virtual int Invoke()
    {
        ushort uVar1;
        long lVar2;
        bool cVar5;
        ulong uVar6;
        long lVar7;
        ushort uVar9;
        ulong uVar10;
        ulong uVar12;
        long local_res8;
        local_res8 = this;
        lVar2 = *(int64 *)(this + 104);
        uVar10 = 0;
        if (lVar2 == null) {
          uVar12 = 1;
          plVar11 = &local_res8;
        }
        else {
          uVar12 = *(uint64 *)(lVar2 + 24);
          plVar11 = (int64 *)(lVar2 + 32);
          if (uVar12 == 0) {
            return 0;
          }
        }
        do {
          lVar2 = plVar11[uVar10];
          pcVar3 = *(code **)(lVar2 + 16);
          plVar4 = *(int64 **)(lVar2 + 32);
          lVar2 = *(int64 *)(lVar2 + 40);
          if (*(short *)(lVar2 + 72) == -1) {
            il2cpp_internal(lVar2);
          }
          cVar5 = FUN_1800d6050(lVar2);
          if (!cVar5) {
            if ((((plVar4 == (int64 *)0) || (*(short *)(lVar2 + 72) == -1)) ||
                ((*(uint32 *)(*plVar4 + 0x114) >> 8 & 1) != 0)) || (*(int64 *)(this + 24) == 0))
            goto LAB_1802f721d;
            cVar5 = il2cpp_internal(lVar2);
            if (!cVar5) {
              cVar5 = FUN_1800d65c0(lVar2);
              if (!cVar5) {
                uVar6 = (**(code **)(*plVar4 + 0x138 + (uint64)*(uint16 *)(lVar2 + 72) * 16))
                                  (plVar4,*(uint64 *)
                                           (*plVar4 + 0x140 + (uint64)*(uint16 *)(lVar2 + 72) * 16)
                                  );
              }
              else {
                uVar6 = il2cpp_class_get_namespace(lVar2);
                uVar6 = FUN_180002970(*(uint16 *)(lVar2 + 72),uVar6,plVar4);
              }
            }
            else {
              cVar5 = FUN_1800d65c0(lVar2);
              uVar1 = *(uint16 *)(lVar2 + 72);
              if (!cVar5) {
                uVar6 = *(uint64 *)(*plVar4 + ((uint64)uVar1 + 20) * 16);
              }
              else {
                lVar7 = *plVar4;
                uVar9 = 0;
                if (*(uint16 *)(lVar7 + 0x12a) != 0) {
                  do {
                    if (*(int64 *)(*(int64 *)(lVar7 + 176) + (uint64)uVar9 * 16) ==
                        *(int64 *)(lVar2 + 24)) {
                      lVar7 = (int64)
                              (int)((uint32)uVar1 +
                                   *(int *)(*(int64 *)(lVar7 + 176) + 8 + (uint64)uVar9 * 16)) *
                              16 + 0x138 + lVar7;
                      goto LAB_1802f7196;
                    }
                    uVar9 = uVar9 + 1;
                  } while (uVar9 < *(uint16 *)(lVar7 + 0x12a));
                }
                lVar7 = FUN_1800914f0(plVar4,*(int64 *)(lVar2 + 24),uVar1);
        LAB_1802f7196:
                uVar6 = *(uint64 *)(lVar7 + 8);
              }
              puVar8 = (uint64 *)il2cpp_internal(uVar6,lVar2);
              uVar6 = (*(code *)*puVar8)(plVar4,puVar8);
            }
          }
          else if (*(char *)(lVar2 + 74) == false) {
            uVar6 = (*pcVar3)(lVar2);
          }
          else {
        LAB_1802f721d:
            uVar6 = (*pcVar3)(plVar4,lVar2);
          }
          uVar10 = uVar10 + 1;
          if (uVar12 <= uVar10) {
            return uVar6;
          }
        } while( true );
    }

    // Token : 0x6000769
    // RVA   : 0x2F7010   Offset: 0x2F5810   Length: 0x22
    public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object)
    {
        ulong[] local_18 = new ulong[3];
        local_18[0] = 0;
        il2cpp_internal(this,local_18,callback,object);
    }

    // Token : 0x600076A
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
