// ============================================================
// Type  : GetAnyKeyFunc
// Token : 0x20000DE
// ============================================================

public class GetAnyKeyFunc
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600072E
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

    // Token : 0x600072F
    // RVA   : 0xB058F0   Offset: 0xB040F0   Length: 0x215
    public virtual bool Invoke()
    {
        ushort uVar1;
        long lVar2;
        bool cVar5;
        ulong in_RAX;
        ulong uVar6;
        long lVar7;
        ulong uVar9;
        ushort uVar10;
        ulong uVar11;
        ulong uVar13;
        long local_res8;
        local_res8 = this;
        lVar2 = *(int64 *)(this + 104);
        if (lVar2 == null) {
          uVar13 = 1;
          plVar12 = &local_res8;
        }
        else {
          uVar13 = *(uint64 *)(lVar2 + 24);
          plVar12 = (int64 *)(lVar2 + 32);
          if (uVar13 == 0) {
            return in_RAX & 0xffffffffffffff00;
          }
        }
        uVar11 = 0;
        do {
          lVar2 = plVar12[uVar11];
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
            goto LAB_180b05acd;
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
                uVar9 = il2cpp_class_get_namespace(lVar2);
                uVar6 = FUN_180002970(*(uint16 *)(lVar2 + 72),uVar9,plVar4);
              }
            }
            else {
              cVar5 = FUN_1800d65c0(lVar2);
              uVar1 = *(uint16 *)(lVar2 + 72);
              if (!cVar5) {
                uVar9 = *(uint64 *)(*plVar4 + ((uint64)uVar1 + 20) * 16);
              }
              else {
                lVar7 = *plVar4;
                uVar10 = 0;
                if (*(uint16 *)(lVar7 + 0x12a) != 0) {
                  do {
                    if (*(int64 *)(*(int64 *)(lVar7 + 176) + (uint64)uVar10 * 16) ==
                        *(int64 *)(lVar2 + 24)) {
                      lVar7 = (int64)
                              (int)((uint32)uVar1 +
                                   *(int *)(*(int64 *)(lVar7 + 176) + 8 + (uint64)uVar10 * 16)) *
                              16 + 0x138 + lVar7;
                      goto LAB_180b05a46;
                    }
                    uVar10 = uVar10 + 1;
                  } while (uVar10 < *(uint16 *)(lVar7 + 0x12a));
                }
                lVar7 = FUN_1800914f0(plVar4,*(int64 *)(lVar2 + 24),uVar1);
        LAB_180b05a46:
                uVar9 = *(uint64 *)(lVar7 + 8);
              }
              puVar8 = (uint64 *)il2cpp_internal(uVar9,lVar2);
              uVar6 = (*(code *)*puVar8)(plVar4,puVar8);
            }
          }
          else if (*(char *)(lVar2 + 74) == false) {
            uVar6 = (*pcVar3)(lVar2);
          }
          else {
        LAB_180b05acd:
            uVar6 = (*pcVar3)(plVar4,lVar2);
          }
          uVar11 = uVar11 + 1;
          if (uVar13 <= uVar11) {
            return uVar6;
          }
        } while( true );
    }

    // Token : 0x6000730
    // RVA   : 0x2F7010   Offset: 0x2F5810   Length: 0x22
    public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object)
    {
        ulong[] local_18 = new ulong[3];
        local_18[0] = 0;
        il2cpp_internal(this,local_18,callback,object);
    }

    // Token : 0x6000731
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
