// ============================================================
// Type  : ChatController
// Token : 0x20003D4
// ============================================================

public class ChatController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001DDB
    public TMP_InputField ChatInputField;

    // Token: 0x4001DDC
    public TMP_Text ChatDisplayOutput;

    // Token: 0x4001DDD
    public Scrollbar ChatScrollbar;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60023CD
    // RVA   : 0x9F3730   Offset: 0x9F1F30   Length: 0xB6
    private void OnEnable()
    {
        long lVar1;
        ulong uVar2;
        if (this.ChatInputField != null) {
          lVar1 = *(int64 *)(this.ChatInputField + 0x1b0);
          uVar2 = new OnTooltipCB(this,DAT_181d68048,DAT_181d54488);
          if (lVar1 != null) {
            FUN_181436660(lVar1,uVar2,DAT_181d55208);
            return;
          }
        }
    }

    // Token : 0x60023CE
    // RVA   : 0x9F3670   Offset: 0x9F1E70   Length: 0xB6
    private void OnDisable()
    {
        long lVar1;
        ulong uVar2;
        if (this.ChatInputField != null) {
          lVar1 = *(int64 *)(this.ChatInputField + 0x1b0);
          uVar2 = new OnTooltipCB(this,DAT_181d68048,DAT_181d54488);
          if (lVar1 != null) {
            FUN_181438210(lVar1,uVar2,DAT_181d55308);
            return;
          }
        }
    }

    // Token : 0x60023CF
    // RVA   : 0x9F30E0   Offset: 0x9F18E0   Length: 0x581
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
                    (this.ChatInputField,**(uint64 **)(DAT_181d82470 + 184),0);
          local_res20 = DateTime.get_Now(0);
          plVar2 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,8);
          if (plVar2 != (int64 *)0) {
            if (("[<#FFFF80>" != 0) &&
               (lVar3 = il2cpp_internal("[<#FFFF80>",*(uint64 *)(*plVar2 + 64))) == null) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            lVar3 = "[<#FFFF80>";
            if ((int)plVar2[3] == 0) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            plVar2[4] = "[<#FFFF80>";
            il2cpp_internal(plVar2 + 4,lVar3);
            local_res8[0] = DateTime.get_Hour(&local_res20,0);
            lVar3 = Int32.ToString(local_res8,"d2",0);
            if ((lVar3 != null) &&
               (lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar2 + 64))) == null) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            if (*(uint32 *)(plVar2 + 3) < 2) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            plVar2[5] = lVar3;
            il2cpp_internal(plVar2 + 5,lVar3);
            if ((":" != 0) &&
               (lVar3 = il2cpp_internal(":",*(uint64 *)(*plVar2 + 64))) == null) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            lVar3 = ":";
            if (*(uint32 *)(plVar2 + 3) < 3) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            plVar2[6] = ":";
            il2cpp_internal(plVar2 + 6,lVar3);
            local_res8[0] = DateTime.get_Minute(&local_res20,0);
            lVar3 = Int32.ToString(local_res8,"d2",0);
            if ((lVar3 != null) &&
               (lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar2 + 64))) == null) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            if (*(uint32 *)(plVar2 + 3) < 4) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            plVar2[7] = lVar3;
            il2cpp_internal(plVar2 + 7,lVar3);
            if ((":" != 0) &&
               (lVar3 = il2cpp_internal(":",*(uint64 *)(*plVar2 + 64))) == null) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            lVar3 = ":";
            if (*(uint32 *)(plVar2 + 3) < 5) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            plVar2[8] = ":";
            il2cpp_internal(plVar2 + 8,lVar3);
            local_res8[0] = DateTime.get_Second(&local_res20,0);
            lVar3 = Int32.ToString(local_res8,"d2",0);
            if ((lVar3 != null) &&
               (lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar2 + 64))) == null) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            if (*(uint32 *)(plVar2 + 3) < 6) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            plVar2[9] = lVar3;
            il2cpp_internal(plVar2 + 9,lVar3);
            if (("</color>] " != 0) &&
               (lVar3 = il2cpp_internal("</color>] ",*(uint64 *)(*plVar2 + 64))) == null) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            lVar3 = "</color>] ";
            if (*(uint32 *)(plVar2 + 3) < 7) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            plVar2[10] = "</color>] ";
            il2cpp_internal(plVar2 + 10,lVar3);
            if ((newText != null) &&
               (lVar3 = il2cpp_internal(newText,*(uint64 *)(*plVar2 + 64))) == null) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
            }
            if (*(uint32 *)(plVar2 + 3) < 8) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar6,0);
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
              cVar1 = FUN_1816fd990(uVar6,**(uint64 **)(DAT_181d82470 + 184),0);
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

    // Token : 0x60023D0
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
