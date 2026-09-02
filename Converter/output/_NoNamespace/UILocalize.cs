// ============================================================
// Type  : UILocalize
// Token : 0x2000101
// ============================================================

public class UILocalize
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000650
    public string key;

    // Token: 0x4000651
    private bool mStarted;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600086F
    // RVA   : 0x156FB90   Offset: 0x156E390   Length: 0x368
    public void set_value(string value)
    {
        bool cVar2;
        ulong uVar4;
        long lVar5;
        ulong uVar6;
        cVar2 = FUN_180d6ca90(value,0);
        if (!cVar2) {
          plVar3 = (int64 *)Component.GetComponent(this,DAT_181d6e7c0);
          if (plVar3 == (int64 *)0) {
            plVar7 = (int64 *)0;
            plVar8 = plVar7;
          }
          else {
            plVar7 = plVar3;
            plVar8 = plVar3;
          }
          cVar2 = Object.op_Inequality(plVar7,0,0);
          if (!cVar2) {
            cVar2 = Object.op_Inequality(plVar8,0,0);
            if (cVar2) {
              if (plVar8 == (int64 *)0) goto LAB_18156fef3;
              uVar4 = Component.get_gameObject(plVar8,0);
              lVar5 = NGUITools.FindInParents(uVar4,DAT_181d66600);
              cVar2 = Object.op_Inequality(lVar5,0,0);
              if (cVar2) {
                if (lVar5 == null) goto LAB_18156fef3;
                uVar4 = *(uint64 *)(lVar5 + 24);
                uVar6 = Component.get_gameObject(plVar8,0);
                cVar2 = Object.op_Equality(uVar4,uVar6,0);
                if (cVar2) {
                  UIButton.set_normalSprite(lVar5,value,0);
                }
              }
              UISprite.set_spriteName(plVar8,value,0);
              (**(code **)(*plVar8 + 0x348))(plVar8,*(uint64 *)(*plVar8 + 0x350));
            }
          }
          else {
            if (plVar7 == (int64 *)0) {
        LAB_18156fef3:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar4 = Component.get_gameObject(plVar7,0);
            lVar5 = NGUITools.FindInParents(uVar4,DAT_181d66880);
            cVar2 = Object.op_Inequality(lVar5,0,0);
            if (cVar2) {
              if (lVar5 == null) goto LAB_18156fef3;
              uVar4 = *(uint64 *)(lVar5 + 24);
              cVar2 = Object.op_Equality(uVar4,plVar7,0);
              if (cVar2) {
                UIInput.set_defaultText(lVar5,value,0);
                return;
              }
            }
            UILabel.set_text(plVar7,value,0);
          }
        }
    }

    // Token : 0x6000870
    // RVA   : 0x156FA50   Offset: 0x156E250   Length: 0xE
    private void OnEnable()
    {
        void FUN_18156fa50(int64 this)
        {
        if (this.mStarted) {
          UILocalize.OnLocalize(this,0);
          return;
        }
    }

    // Token : 0x6000871
    // RVA   : 0x156FB80   Offset: 0x156E380   Length: 0xB
    private void Start()
    {
        void FUN_18156fb80(int64 this)
        {
        this.mStarted = 1;
        UILocalize.OnLocalize(this,0);
    }

    // Token : 0x6000872
    // RVA   : 0x156FA60   Offset: 0x156E260   Length: 0x110
    private void OnLocalize()
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        cVar3 = FUN_180d6ca90(this.key,0);
        if (cVar3) {
          lVar2 = Component.GetComponent(this,DAT_181d6e240);
          cVar3 = Object.op_Inequality(lVar2,0,0);
          if (cVar3) {
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            this.key = *(uint64 *)(lVar2 + 0x1a0);
          }
        }
        cVar3 = FUN_180d6ca90(this.key,0);
        if (!cVar3) {
          uVar1 = this.key;
          uVar1 = Localization.Get(uVar1,1,0);
          UILocalize.set_value(this,uVar1,0);
        }
    }

    // Token : 0x6000873
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
