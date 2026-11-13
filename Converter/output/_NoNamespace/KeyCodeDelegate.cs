// ============================================================
// Type  : KeyCodeDelegate
// Token : 0x20000EC
// ============================================================

public class KeyCodeDelegate
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000761
    // RVA   : 0x562E40   Offset: 0x561C40   Length: 0x6A
    public void /*ctor*/(object object, IntPtr method)
    {
        bool cVar1;
        ulong uVar2;
        if (object == null) {
          cVar1 = FUN_1801dfd30(method);
          if (!cVar1) {
            uVar2 = il2cpp_internal(0,"Delegate to an instance method cannot have null \'this\'.");
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar2,0);
          }
        }
        *(uint64 *)(this + 16) = *method;
        *(int64 *)(this + 32) = object;
        *(uint64 **)(this + 40) = method;
    }

    // Token : 0x6000762
    // RVA   : 0x605AB0   Offset: 0x6048B0   Length: 0x2A2
    public virtual void Invoke(GameObject go, KeyCode key)
    {
        long lVar1;
        bool cVar4;
        ulong uVar7;
        ulong uVar8;
        ulong uVar9;
        long local_res8;
        local_res8 = this;
        lVar1 = *(int64 *)(this + 104);
        if (lVar1 == null) {
          plVar5 = &local_res8;
          uVar8 = 1;
        }
        else {
          uVar8 = *(uint64 *)(lVar1 + 24);
          plVar5 = (int64 *)(lVar1 + 32);
          if (uVar8 == 0) {
            return;
          }
        }
        uVar9 = 0;
        do {
          lVar1 = plVar5[uVar9];
          pcVar2 = *(code **)(lVar1 + 16);
          plVar3 = *(int64 **)(lVar1 + 32);
          lVar1 = *(int64 *)(lVar1 + 40);
          if (*(short *)(lVar1 + 72) == -1) {
            il2cpp_internal(lVar1);
          }
          cVar4 = FUN_1801dfd30(lVar1);
          if (!cVar4) {
            if (*(char *)(lVar1 + 74) == '\x02') {
              if ((((plVar3 == (int64 *)0) || (*(short *)(lVar1 + 72) == -1)) ||
                  ((*(uint32 *)(*plVar3 + 0x114) >> 8 & 1) != 0)) || (*(int64 *)(this + 24) == 0))
              goto LAB_180605d09;
              cVar4 = il2cpp_internal(lVar1);
              if (!cVar4) {
                cVar4 = FUN_1801e02a0(lVar1);
                if (!cVar4) {
                  (**(code **)(*plVar3 + 0x138 + (uint64)*(uint16 *)(lVar1 + 72) * 16))
                            (plVar3,go,key,
                             *(uint64 *)
                              (*plVar3 + 0x140 + (uint64)*(uint16 *)(lVar1 + 72) * 16));
                }
                else {
                  uVar7 = il2cpp_class_get_namespace(lVar1);
                  FUN_18005fc20(*(uint16 *)(lVar1 + 72),uVar7,plVar3,go,key);
                }
              }
              else {
                cVar4 = FUN_1801e02a0(lVar1);
                if (!cVar4) {
                  puVar6 = (uint64 *)
                           il2cpp_internal(*(uint64 *)
                                                (*plVar3 +
                                                ((uint64)*(uint16 *)(lVar1 + 72) + 20) * 16),
                                               lVar1);
                  (*(code *)*puVar6)(plVar3,go,key,puVar6);
                }
                else {
                  FUN_18005f4f0(lVar1,plVar3,go,key);
                }
              }
            }
            else {
              if ((*(short *)(lVar1 + 72) == -1) || (*(int64 *)(this + 24) == 0))
              goto LAB_180605b57;
              cVar4 = il2cpp_internal(lVar1);
              if (!cVar4) {
                cVar4 = FUN_1801e02a0(lVar1);
                if (!cVar4) {
                  (**(code **)(*go + 0x138 + (uint64)*(uint16 *)(lVar1 + 72) * 16))
                            (go,key,
                             *(uint64 *)
                              (*go + 0x140 + (uint64)*(uint16 *)(lVar1 + 72) * 16));
                }
                else {
                  uVar7 = il2cpp_class_get_namespace(lVar1);
                  FUN_180054430(*(uint16 *)(lVar1 + 72),uVar7,go,key);
                }
              }
              else {
                cVar4 = FUN_1801e02a0(lVar1);
                if (!cVar4) {
                  puVar6 = (uint64 *)
                           il2cpp_internal(*(uint64 *)
                                                (*go +
                                                ((uint64)*(uint16 *)(lVar1 + 72) + 20) * 16),
                                               lVar1);
                  (*(code *)*puVar6)(go,key,puVar6);
                }
                else {
                  FUN_1800542b0(lVar1,go,key);
                }
              }
            }
          }
          else if (*(char *)(lVar1 + 74) == '\x02') {
        LAB_180605b57:
            (*pcVar2)(go,key,lVar1);
          }
          else {
        LAB_180605d09:
            (*pcVar2)(plVar3,go,key,lVar1);
          }
          uVar9 = uVar9 + 1;
          if (uVar8 <= uVar9) {
            return;
          }
        } while( true );
    }

    // Token : 0x6000763
    // RVA   : 0x605990   Offset: 0x604790   Length: 0x82
    public virtual IAsyncResult BeginInvoke(GameObject go, KeyCode key, AsyncCallback callback, object object)
    {
        void KeyCodeDelegate.BeginInvoke
                     (uint64 this,uint64 go,uint32 key,uint64 callback,
                     uint64 object)
        {
        uint32 local_res18 [4];
        uint64 local_28;
        uint64 local_20;
        uint64 local_18;
        local_res18[0] = key;
        local_18 = 0;
        local_28 = go;
        local_20 = il2cpp_value_box(DAT_181e64670,local_res18);
        il2cpp_internal(this,&local_28,callback,object);
    }

    // Token : 0x6000764
    // RVA   : 0x562C40   Offset: 0x561A40   Length: 0xA
    public virtual void EndInvoke(IAsyncResult result)
    {
        il2cpp_internal(result,0);
    }

}
