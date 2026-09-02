// ============================================================
// Type  : OnDimensionsChanged
// Token : 0x20000AD
// ============================================================

public class OnDimensionsChanged
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000558
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

    // Token : 0x6000559
    // RVA   : 0x46A840   Offset: 0x469040   Length: 0x19A
    public virtual void Invoke()
    {
        long lVar1;
        bool cVar4;
        ulong uVar6;
        ulong uVar7;
        ulong uVar9;
        long local_res8;
        local_res8 = this;
        lVar1 = *(int64 *)(this + 104);
        if (lVar1 == null) {
          uVar9 = 1;
          plVar8 = &local_res8;
        }
        else {
          uVar9 = *(uint64 *)(lVar1 + 24);
          plVar8 = (int64 *)(lVar1 + 32);
          if (uVar9 == 0) {
            return;
          }
        }
        uVar7 = 0;
        do {
          lVar1 = plVar8[uVar7];
          pcVar2 = *(code **)(lVar1 + 16);
          plVar3 = *(int64 **)(lVar1 + 32);
          lVar1 = *(int64 *)(lVar1 + 40);
          if (*(short *)(lVar1 + 72) == -1) {
            il2cpp_internal(lVar1);
          }
          cVar4 = FUN_1800d6050(lVar1);
          if (!cVar4) {
            if ((((plVar3 == (int64 *)0) || (*(short *)(lVar1 + 72) == -1)) ||
                ((*(uint32 *)(*plVar3 + 0x114) >> 8 & 1) != 0)) || (*(int64 *)(this + 24) == 0))
            goto LAB_18046a9a2;
            cVar4 = il2cpp_internal(lVar1);
            if (!cVar4) {
              cVar4 = FUN_1800d65c0(lVar1);
              if (!cVar4) {
                (**(code **)(*plVar3 + 0x138 + (uint64)*(uint16 *)(lVar1 + 72) * 16))
                          (plVar3,*(uint64 *)
                                   (*plVar3 + 0x140 + (uint64)*(uint16 *)(lVar1 + 72) * 16));
              }
              else {
                uVar6 = il2cpp_class_get_namespace(lVar1);
                FUN_180002970(*(uint16 *)(lVar1 + 72),uVar6,plVar3);
              }
            }
            else {
              cVar4 = FUN_1800d65c0(lVar1);
              if (!cVar4) {
                puVar5 = (uint64 *)
                         il2cpp_internal(*(uint64 *)
                                              (*plVar3 +
                                              ((uint64)*(uint16 *)(lVar1 + 72) + 20) * 16),lVar1)
                ;
                (*(code *)*puVar5)(plVar3,puVar5);
              }
              else {
                FUN_180005c70(lVar1,plVar3);
              }
            }
          }
          else if (*(char *)(lVar1 + 74) == false) {
            (*pcVar2)(lVar1);
          }
          else {
        LAB_18046a9a2:
            (*pcVar2)(plVar3,lVar1);
          }
          uVar7 = uVar7 + 1;
          if (uVar9 <= uVar7) {
            return;
          }
        } while( true );
    }

    // Token : 0x600055A
    // RVA   : 0x2F7010   Offset: 0x2F5810   Length: 0x22
    public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object)
    {
        ulong[] local_18 = new ulong[3];
        local_18[0] = 0;
        il2cpp_internal(this,local_18,callback,object);
    }

    // Token : 0x600055B
    // RVA   : 0x210040   Offset: 0x20E840   Length: 0xA
    public virtual void EndInvoke(IAsyncResult result)
    {
        il2cpp_internal(result,0);
    }

}
