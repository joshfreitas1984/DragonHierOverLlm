// ============================================================
// Type  : ChatController
// Token : 0x20003E8
// ============================================================

public class ChatController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001F78
    public TMP_InputField ChatInputField;

    // Token: 0x4001F79
    public TMP_Text ChatDisplayOutput;

    // Token: 0x4001F7A
    public Scrollbar ChatScrollbar;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60024FA
    // RVA   : 0x6F4DC0   Offset: 0x6F3BC0   Length: 0xB6
    private void OnEnable()
    {
        long lVar1;
        ulong uVar2;
        if (this.ChatInputField != null) {
          lVar1 = *(int64 *)(this.ChatInputField + 0x1b0);
          uVar2 = new OnTooltipCB(this,DAT_181e73bc8,DAT_181e5e9b8);
          if (lVar1 != null) {
            FUN_180c8e5c0(lVar1,uVar2,DAT_181e5f880);
            return;
          }
        }
    }

    // Token : 0x60024FB
    // RVA   : 0x6F4D00   Offset: 0x6F3B00   Length: 0xB6
    private void OnDisable()
    {
        long lVar1;
        ulong uVar2;
        if (this.ChatInputField != null) {
          lVar1 = *(int64 *)(this.ChatInputField + 0x1b0);
          uVar2 = new OnTooltipCB(this,DAT_181e73bc8,DAT_181e5e9b8);
          if (lVar1 != null) {
            FUN_180c90170(lVar1,uVar2,DAT_181e5f990);
            return;
          }
        }
    }

    // Token : 0x60024FC
    // RVA   : 0x6F4770   Offset: 0x6F3570   Length: 0x581
    private void AddToChatOutput(string newText)
    {
        bool cVar1;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        uint[] local_res8 = new uint[2];
        ulong local_res20;
        if (this.ChatInputField != null) {
          TMP_InputField.set_text
                    (this.ChatInputField,**(uint64 **)(DAT_181e87ae8 + 184),0);
          local_res20 = DateTime.get_Now(0);
          plVar2 = (int64 *)FUN_1801dfd90(DAT_181e85e38,8);
          if (plVar2 != (int64 *)0) {
            if (("[<#FFFF80>" != 0) &&
               (lVar3 = il2cpp_internal("[<#FFFF80>",*(uint64 *)(*plVar2 + 64))) == null) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            lVar3 = "[<#FFFF80>";
            if ((int)plVar2[3] == 0) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            plVar2[4] = "[<#FFFF80>";
            il2cpp_internal(plVar2 + 4,lVar3);
            local_res8[0] = DateTime.get_Hour(&local_res20,0);
            lVar3 = Int32.ToString(local_res8,"d2",0);
            if ((lVar3 != null) &&
               (lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar2 + 64))) == null) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            if (*(uint32 *)(plVar2 + 3) < 2) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            plVar2[5] = lVar3;
            il2cpp_internal(plVar2 + 5,lVar3);
            if ((":" != 0) &&
               (lVar3 = il2cpp_internal(":",*(uint64 *)(*plVar2 + 64))) == null) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            lVar3 = ":";
            if (*(uint32 *)(plVar2 + 3) < 3) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            plVar2[6] = ":";
            il2cpp_internal(plVar2 + 6,lVar3);
            local_res8[0] = DateTime.get_Minute(&local_res20,0);
            lVar3 = Int32.ToString(local_res8,"d2",0);
            if ((lVar3 != null) &&
               (lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar2 + 64))) == null) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            if (*(uint32 *)(plVar2 + 3) < 4) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            plVar2[7] = lVar3;
            il2cpp_internal(plVar2 + 7,lVar3);
            if ((":" != 0) &&
               (lVar3 = il2cpp_internal(":",*(uint64 *)(*plVar2 + 64))) == null) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            lVar3 = ":";
            if (*(uint32 *)(plVar2 + 3) < 5) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            plVar2[8] = ":";
            il2cpp_internal(plVar2 + 8,lVar3);
            local_res8[0] = DateTime.get_Second(&local_res20,0);
            lVar3 = Int32.ToString(local_res8,"d2",0);
            if ((lVar3 != null) &&
               (lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar2 + 64))) == null) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            if (*(uint32 *)(plVar2 + 3) < 6) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            plVar2[9] = lVar3;
            il2cpp_internal(plVar2 + 9,lVar3);
            if (("</color>] " != 0) &&
               (lVar3 = il2cpp_internal("</color>] ",*(uint64 *)(*plVar2 + 64))) == null) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            lVar3 = "</color>] ";
            if (*(uint32 *)(plVar2 + 3) < 7) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            plVar2[10] = "</color>] ";
            il2cpp_internal(plVar2 + 10,lVar3);
            if ((newText != null) &&
               (lVar3 = il2cpp_internal(newText,*(uint64 *)(*plVar2 + 64))) == null) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            if (*(uint32 *)(plVar2 + 3) < 8) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            plVar2[11] = newText;
            il2cpp_internal(plVar2 + 11,newText);
            uVar5 = String.Concat(plVar2,0);
            uVar6 = this.ChatDisplayOutput;
            cVar1 = Object.op_Inequality(uVar6,0,0);
            if (cVar1) {
              plVar2 = this.ChatDisplayOutput;
              if (plVar2 == (int64 *)0) throw; // [null/range check failed]
              uVar6 = (**(code **)(*plVar2 + 0x548))(plVar2,*(uint64 *)(*plVar2 + 0x550));
              cVar1 = FUN_1816387f0(uVar6,**(uint64 **)(DAT_181e87ae8 + 184),0);
              plVar2 = this.ChatDisplayOutput;
              if (!cVar1) {
                if (plVar2 == (int64 *)0) throw; // [null/range check failed]
                uVar6 = (**(code **)(*plVar2 + 0x548))(plVar2,*(uint64 *)(*plVar2 + 0x550));
                uVar6 = String.Concat(uVar6,"\n",uVar5,0);
                (**(code **)(*plVar2 + 0x558))(plVar2,uVar6,*(uint64 *)(*plVar2 + 0x560));
              }
              else {
                if (plVar2 == (int64 *)0) throw; // [null/range check failed]
                (**(code **)(*plVar2 + 0x558))(plVar2,uVar5,*(uint64 *)(*plVar2 + 0x560));
              }
            }
            if (this.ChatInputField != null) {
              TMP_InputField.ActivateInputField(this.ChatInputField,0);
              if (this.ChatScrollbar != null) {
                Scrollbar.set_value(this.ChatScrollbar,0,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60024FD
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
