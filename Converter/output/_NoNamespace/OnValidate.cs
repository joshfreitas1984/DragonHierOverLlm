// ============================================================
// Type  : OnValidate
// Token : 0x20000F9
// ============================================================

public class OnValidate
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60007E5
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

    // Token : 0x60007E6
    // RVA   : 0xB097A0   Offset: 0xB07FA0   Length: 0x4A8
    public virtual char Invoke(string text, int charIndex, char addedChar)
    {
        uint64
        OnValidate.Invoke(int64 this,int64 *text,uint32 charIndex,uint16 addedChar)
        {
        code *pcVar1;
        int64 *plVar2;
        char cVar3;
        uint64 uVar4;
        int64 lVar5;
        uint64 *puVar6;
        int64 lVar7;
        uint16 uVar8;
        uint16 uVar9;
        int64 *plVar10;
        int64 lVar11;
        uint64 uVar12;
        int64 local_res8;
        uint64 local_38;
        local_res8 = this;
        uVar12 = 0;
        lVar11 = *(int64 *)(this + 104);
        if (lVar11 == null) {
          plVar10 = &local_res8;
          local_38 = 1;
        }
        else {
          local_38 = *(uint64 *)(lVar11 + 24);
          plVar10 = (int64 *)(lVar11 + 32);
          if (local_38 == 0) {
            return 0;
          }
        }
        do {
          lVar11 = plVar10[uVar12];
          pcVar1 = *(code **)(lVar11 + 16);
          plVar2 = *(int64 **)(lVar11 + 32);
          lVar11 = *(int64 *)(lVar11 + 40);
          if (*(short *)(lVar11 + 72) == -1) {
            il2cpp_internal(lVar11);
          }
          cVar3 = FUN_1800d6050(lVar11);
          if (!cVar3) {
            if (*(char *)(lVar11 + 74) == '\x03') {
              if ((((plVar2 == (int64 *)0) || (*(short *)(lVar11 + 72) == -1)) ||
                  ((*(uint32 *)(*plVar2 + 0x114) >> 8 & 1) != 0)) || (*(int64 *)(this + 24) == 0))
              goto LAB_180b09bf9;
              cVar3 = il2cpp_internal(lVar11);
              if (!cVar3) {
                cVar3 = FUN_1800d65c0(lVar11);
                if (!cVar3) {
                  lVar11 = (uint64)*(uint16 *)(lVar11 + 72) * 16 + *plVar2;
                  uVar4 = (**(code **)(lVar11 + 0x138))
                                    (plVar2,text,charIndex,addedChar,*(uint64 *)(lVar11 + 0x140));
                }
                else {
                  lVar7 = il2cpp_class_get_namespace(lVar11);
                  lVar5 = *plVar2;
                  uVar9 = 0;
                  if (*(uint16 *)(lVar5 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar5 + 176) + (uint64)uVar9 * 16) == lVar7) {
                        puVar6 = (uint64 *)
                                 ((int64)
                                  (int)((uint32)*(uint16 *)(lVar11 + 72) +
                                       *(int *)(*(int64 *)(lVar5 + 176) + 8 + (uint64)uVar9 * 16)
                                       ) * 16 + 0x138 + lVar5);
                        goto LAB_180b09b96;
                      }
                      uVar9 = uVar9 + 1;
                    } while (uVar9 < *(uint16 *)(lVar5 + 0x12a));
                  }
                  puVar6 = (uint64 *)FUN_1800914f0(plVar2,lVar7,*(uint16 *)(lVar11 + 72));
        LAB_180b09b96:
                  uVar4 = (*(code *)*puVar6)(plVar2,text,charIndex,addedChar,puVar6[1]);
                }
              }
              else {
                cVar3 = FUN_1800d65c0(lVar11);
                uVar9 = *(uint16 *)(lVar11 + 72);
                if (!cVar3) {
                  puVar6 = (uint64 *)
                           il2cpp_internal(*(uint64 *)(*plVar2 + ((uint64)uVar9 + 20) * 16)
                                               ,lVar11);
                  uVar4 = (*(code *)*puVar6)(plVar2,text,charIndex,addedChar,puVar6);
                }
                else {
                  lVar5 = *plVar2;
                  uVar8 = 0;
                  if (*(uint16 *)(lVar5 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar5 + 176) + (uint64)uVar8 * 16) ==
                          *(int64 *)(lVar11 + 24)) {
                        lVar5 = (int64)
                                (int)((uint32)uVar9 +
                                     *(int *)(*(int64 *)(lVar5 + 176) + 8 + (uint64)uVar8 * 16))
                                * 16 + 0x138 + lVar5;
                        goto LAB_180b09ab6;
                      }
                      uVar8 = uVar8 + 1;
                    } while (uVar8 < *(uint16 *)(lVar5 + 0x12a));
                  }
                  lVar5 = FUN_1800914f0(plVar2,*(int64 *)(lVar11 + 24),uVar9);
        LAB_180b09ab6:
                  puVar6 = (uint64 *)il2cpp_internal(*(uint64 *)(lVar5 + 8),lVar11);
                  uVar4 = (*(code *)*puVar6)(plVar2,text,charIndex,addedChar,puVar6);
                }
              }
            }
            else {
              if ((*(short *)(lVar11 + 72) == -1) || (*(int64 *)(this + 24) == 0))
              goto LAB_180b09867;
              cVar3 = il2cpp_internal(lVar11);
              if (!cVar3) {
                cVar3 = FUN_1800d65c0(lVar11);
                if (!cVar3) {
                  uVar4 = (**(code **)(*text + 0x138 + (uint64)*(uint16 *)(lVar11 + 72) * 16))
                                    (text,charIndex,addedChar,
                                     *(uint64 *)
                                      (*text + 0x140 + (uint64)*(uint16 *)(lVar11 + 72) * 16));
                }
                else {
                  lVar7 = il2cpp_class_get_namespace(lVar11);
                  lVar5 = *text;
                  uVar9 = 0;
                  if (*(uint16 *)(lVar5 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar5 + 176) + (uint64)uVar9 * 16) == lVar7) {
                        puVar6 = (uint64 *)
                                 ((int64)
                                  (int)((uint32)*(uint16 *)(lVar11 + 72) +
                                       *(int *)(*(int64 *)(lVar5 + 176) + 8 + (uint64)uVar9 * 16)
                                       ) * 16 + 0x138 + lVar5);
                        goto LAB_180b099b8;
                      }
                      uVar9 = uVar9 + 1;
                    } while (uVar9 < *(uint16 *)(lVar5 + 0x12a));
                  }
                  puVar6 = (uint64 *)FUN_1800914f0(text,lVar7,*(uint16 *)(lVar11 + 72));
        LAB_180b099b8:
                  uVar4 = (*(code *)*puVar6)(text,charIndex,addedChar,puVar6[1]);
                }
              }
              else {
                cVar3 = FUN_1800d65c0(lVar11);
                uVar9 = *(uint16 *)(lVar11 + 72);
                if (!cVar3) {
                  uVar4 = *(uint64 *)(*text + ((uint64)uVar9 + 20) * 16);
                }
                else {
                  lVar5 = *text;
                  uVar8 = 0;
                  if (*(uint16 *)(lVar5 + 0x12a) != 0) {
                    do {
                      if (*(int64 *)(*(int64 *)(lVar5 + 176) + (uint64)uVar8 * 16) ==
                          *(int64 *)(lVar11 + 24)) {
                        uVar4 = *(uint64 *)
                                 ((int64)
                                  (int)((uint32)uVar9 +
                                       *(int *)(*(int64 *)(lVar5 + 176) + 8 + (uint64)uVar8 * 16)
                                       ) * 16 + lVar5 + 0x140);
                        goto LAB_180b09939;
                      }
                      uVar8 = uVar8 + 1;
                    } while (uVar8 < *(uint16 *)(lVar5 + 0x12a));
                  }
                  lVar5 = FUN_1800914f0(text,*(int64 *)(lVar11 + 24),uVar9);
                  uVar4 = *(uint64 *)(lVar5 + 8);
                }
        LAB_180b09939:
                puVar6 = (uint64 *)il2cpp_internal(uVar4,lVar11);
                uVar4 = (*(code *)*puVar6)(text,charIndex,addedChar,puVar6);
              }
            }
          }
          else if (*(char *)(lVar11 + 74) == '\x03') {
        LAB_180b09867:
            uVar4 = (*pcVar1)(text,charIndex,addedChar,lVar11);
          }
          else {
        LAB_180b09bf9:
            uVar4 = (*pcVar1)(plVar2,text,charIndex,addedChar,lVar11);
          }
          uVar12 = uVar12 + 1;
          if (local_38 <= uVar12) {
            return uVar4;
          }
        } while( true );
    }

    // Token : 0x60007E7
    // RVA   : 0xB096D0   Offset: 0xB07ED0   Length: 0x9F
    public virtual IAsyncResult BeginInvoke(string text, int charIndex, char addedChar, AsyncCallback callback, object object)
    {
        void OnValidate.BeginInvoke
                     (uint64 this,uint64 text,uint32 charIndex,uint16 addedChar,
                     uint64 callback,uint64 object)
        {
        uint32 local_res18 [2];
        uint16 local_res20 [4];
        uint64 local_28;
        uint64 local_20;
        uint64 local_18;
        uint64 local_10;
        local_res18[0] = charIndex;
        local_res20[0] = addedChar;
        local_10 = 0;
        local_28 = text;
        local_20 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
        local_18 = il2cpp_value_box(DAT_181d91d10,local_res20);
        il2cpp_internal(this,&local_28,callback,object);
    }

    // Token : 0x60007E8
    // RVA   : 0xB09770   Offset: 0xB07F70   Length: 0x28
    public virtual char EndInvoke(IAsyncResult result)
    {
        long lVar1;
        lVar1 = il2cpp_internal(result,0);
        if (lVar1 != null) {
          puVar2 = (uint16 *)il2cpp_object_unbox(lVar1);
          return *puVar2;
        }
    }

}
