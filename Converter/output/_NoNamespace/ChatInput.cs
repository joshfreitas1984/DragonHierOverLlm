// ============================================================
// Type  : ChatInput
// Token : 0x2000014
// ============================================================

public class ChatInput
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000061
    public UITextList textList;

    // Token: 0x4000062
    public bool fillWithDummyData;

    // Token: 0x4000063
    private UIInput mInput;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000046
    // RVA   : 0x6F4FA0   Offset: 0x6F3DA0   Length: 0x17B
    private void Start()
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        ulong uVar4;
        uint[] local_res8 = new uint[2];
        uVar3 = Component.GetComponent(this,DAT_181e79db8);
        this.mInput = uVar3;
        if ((this.mInput != null) &&
           (lVar1 = this.mInput.label) != null) {
          UILabel.set_maxLineCount(lVar1,1);
          if (this.fillWithDummyData) {
            uVar3 = this.textList;
            cVar2 = Object.op_Inequality(uVar3,0,0);
            if (cVar2) {
              local_res8[0] = 0;
              do {
                lVar1 = this.textList;
                uVar3 = "[AAAAAA]";
                if ((local_res8[0] & 1) == 0) {
                  uVar3 = "[FFFFFF]";
                }
                uVar4 = Int32.ToString(local_res8,0);
                uVar3 = String.Concat(uVar3,"This is an example paragraph for the text list, testing line ",uVar4,"[-]",0);
                if (lVar1 == null) throw; // [null/range check failed]
                UITextList.Add(lVar1,uVar3,0);
                local_res8[0] = local_res8[0] + 1;
              } while ((int)local_res8[0] < 30);
            }
          }
          return;
        }
    }

    // Token : 0x6000047
    // RVA   : 0x6F4E80   Offset: 0x6F3C80   Length: 0x117
    public void OnSubmit()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = this.textList;
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (!cVar1) {
          return;
        }
        if (this.mInput != null) {
          uVar2 = UIInput.get_value(this.mInput,0);
          uVar2 = NGUIText.StripSymbols(uVar2,0);
          cVar1 = FUN_180ad1200(uVar2,0);
          if (cVar1) {
            return;
          }
          if (this.textList != null) {
            UITextList.Add(this.textList,uVar2,0);
            if (this.mInput != null) {
              UIInput.set_value(this.mInput,"",0);
              if (this.mInput != null) {
                UIInput.set_isSelected(this.mInput,0,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000048
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
