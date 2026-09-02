// ============================================================
// Type  : RemoveTouchDelegate
// Token : 0x20000E1
// ============================================================

public class RemoveTouchDelegate
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600073A
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

    // Token : 0x600073B
    // RVA   : 0xB09CD0   Offset: 0xB084D0   Length: 0x1AE
    public virtual void Invoke(int id)
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
            goto LAB_180b09e42;
            cVar4 = il2cpp_internal(lVar1);
            if (!cVar4) {
              cVar4 = FUN_1800d65c0(lVar1);
              if (!cVar4) {
                (**(code **)(*plVar3 + 0x138 + (uint64)*(uint16 *)(lVar1 + 72) * 16))
                          (plVar3,id,
                           *(uint64 *)(*plVar3 + 0x140 + (uint64)*(uint16 *)(lVar1 + 72) * 16))
                ;
              }
              else {
                uVar6 = il2cpp_class_get_namespace(lVar1);
                FUN_180004670(*(uint16 *)(lVar1 + 72),uVar6,plVar3,id);
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
                (*(code *)*puVar5)(plVar3,id,puVar5);
              }
              else {
                FUN_180008740(lVar1,plVar3,id);
              }
            }
          }
          else if (*(char *)(lVar1 + 74) == true) {
            (*pcVar2)(id,lVar1);
          }
          else {
        LAB_180b09e42:
            (*pcVar2)(plVar3,id,lVar1);
          }
          uVar7 = uVar7 + 1;
          if (uVar9 <= uVar7) {
            return;
          }
        } while( true );
    }

    // Token : 0x600073C
    // RVA   : 0xB09C50   Offset: 0xB08450   Length: 0x7A
    public virtual IAsyncResult BeginInvoke(int id, AsyncCallback callback, object object)
    {
        void RemoveTouchDelegate.BeginInvoke
                     (uint64 this,uint32 id,uint64 callback,uint64 object)
        {
        uint32 local_res10 [2];
        uint64 local_18;
        uint64 local_10;
        local_res10[0] = id;
        local_10 = 0;
        local_18 = il2cpp_value_box(DAT_181d5b2f8,local_res10);
        il2cpp_internal(this,&local_18,callback,object);
    }

    // Token : 0x600073D
    // RVA   : 0x210040   Offset: 0x20E840   Length: 0xA
    public virtual void EndInvoke(IAsyncResult result)
    {
        il2cpp_internal(result,0);
    }

}
