// ============================================================
// Type  : Validate
// Token : 0x200006F
// ============================================================

public class Validate
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600028D
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

    // Token : 0x600028E
    // RVA   : 0xB18270   Offset: 0xB16A70   Length: 0x2BE
    public virtual bool Invoke(bool choice)
    {
        long lVar1;
        bool cVar4;
        ulong in_RAX;
        ulong uVar5;
        long lVar6;
        long lVar8;
        ushort uVar9;
        ushort uVar10;
        ulong uVar12;
        ulong uVar13;
        long local_res8;
        local_res8 = this;
        lVar6 = *(int64 *)(this + 104);
        if (lVar6 == null) {
          uVar13 = 1;
          plVar11 = &local_res8;
        }
        else {
          uVar13 = *(uint64 *)(lVar6 + 24);
          plVar11 = (int64 *)(lVar6 + 32);
          if (uVar13 == 0) {
            return in_RAX & 0xffffffffffffff00;
          }
        }
        uVar12 = 0;
        do {
          lVar6 = plVar11[uVar12];
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
            goto LAB_180b184f1;
            cVar4 = il2cpp_internal(lVar1);
            if (!cVar4) {
              cVar4 = FUN_1800d65c0(lVar1);
              if (!cVar4) {
                uVar5 = (**(code **)(*plVar3 + 0x138 + (uint64)*(uint16 *)(lVar1 + 72) * 16))
                                  (plVar3,choice,
                                   *(uint64 *)
                                    (*plVar3 + 0x140 + (uint64)*(uint16 *)(lVar1 + 72) * 16));
              }
              else {
                lVar8 = il2cpp_class_get_namespace(lVar1);
                lVar6 = *plVar3;
                uVar10 = 0;
                if (*(uint16 *)(lVar6 + 0x12a) != 0) {
                  do {
                    if (*(int64 *)(*(int64 *)(lVar6 + 176) + (uint64)uVar10 * 16) == lVar8) {
                      puVar7 = (uint64 *)
                               ((int64)
                                (int)((uint32)*(uint16 *)(lVar1 + 72) +
                                     *(int *)(*(int64 *)(lVar6 + 176) + 8 + (uint64)uVar10 * 16))
                                * 16 + 0x138 + lVar6);
                      uVar5 = (*(code *)*puVar7)(plVar3,choice,puVar7[1]);
                      goto LAB_180b184fd;
                    }
                    uVar10 = uVar10 + 1;
                  } while (uVar10 < *(uint16 *)(lVar6 + 0x12a));
                }
                puVar7 = (uint64 *)FUN_1800914f0(plVar3,lVar8,*(uint16 *)(lVar1 + 72));
                uVar5 = (*(code *)*puVar7)(plVar3,choice,puVar7[1]);
              }
            }
            else {
              cVar4 = FUN_1800d65c0(lVar1);
              uVar10 = *(uint16 *)(lVar1 + 72);
              if (!cVar4) {
                puVar7 = (uint64 *)
                         il2cpp_internal(*(uint64 *)(*plVar3 + ((uint64)uVar10 + 20) * 16),
                                             lVar1);
                uVar5 = (*(code *)*puVar7)(plVar3,choice,puVar7);
              }
              else {
                lVar6 = *plVar3;
                uVar9 = 0;
                if (*(uint16 *)(lVar6 + 0x12a) != 0) {
                  do {
                    if (*(int64 *)(*(int64 *)(lVar6 + 176) + (uint64)uVar9 * 16) ==
                        *(int64 *)(lVar1 + 24)) {
                      lVar6 = (int64)
                              (int)((uint32)uVar10 +
                                   *(int *)(*(int64 *)(lVar6 + 176) + 8 + (uint64)uVar9 * 16)) *
                              16 + 0x138 + lVar6;
                      goto LAB_180b183c6;
                    }
                    uVar9 = uVar9 + 1;
                  } while (uVar9 < *(uint16 *)(lVar6 + 0x12a));
                }
                lVar6 = FUN_1800914f0(plVar3,*(int64 *)(lVar1 + 24),uVar10);
        LAB_180b183c6:
                puVar7 = (uint64 *)il2cpp_internal(*(uint64 *)(lVar6 + 8),lVar1);
                uVar5 = (*(code *)*puVar7)(plVar3,choice,puVar7);
              }
            }
          }
          else if (*(char *)(lVar1 + 74) == true) {
            uVar5 = (*pcVar2)(choice,lVar1);
          }
          else {
        LAB_180b184f1:
            uVar5 = (*pcVar2)(plVar3,choice,lVar1);
          }
        LAB_180b184fd:
          uVar12 = uVar12 + 1;
          if (uVar13 <= uVar12) {
            return uVar5;
          }
        } while( true );
    }

    // Token : 0x600028F
    // RVA   : 0xB181F0   Offset: 0xB169F0   Length: 0x7A
    public virtual IAsyncResult BeginInvoke(bool choice, AsyncCallback callback, object object)
    {
        void Validate.BeginInvoke
                     (uint64 this,uint8 choice,uint64 callback,uint64 object)
        {
        uint8 local_res10 [8];
        uint64 local_18;
        uint64 local_10;
        local_res10[0] = choice;
        local_10 = 0;
        local_18 = il2cpp_value_box(DAT_181d8d920,local_res10);
        il2cpp_internal(this,&local_18,callback,object);
    }

    // Token : 0x6000290
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
