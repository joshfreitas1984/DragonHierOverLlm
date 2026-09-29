// ============================================================
// Type  : UILocalize
// Token : 0x2000102
// ============================================================

public class UILocalize
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400066C
    public string key;

    // Token: 0x400066D
    private bool mStarted;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000887
    // RVA   : 0x1196790   Offset: 0x1195B90   Length: 0x368
    public void set_value(string value)
    {
        bool cVar2;
        ulong uVar4;
        long lVar5;
        ulong uVar6;
        cVar2 = FUN_180d75bc0(value,0);
        if (!cVar2) {
          plVar3 = (int64 *)Component.GetComponent(this,DAT_181d97078);
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
              if (plVar8 == (int64 *)0) goto LAB_181196af3;
              uVar4 = Component.get_gameObject(plVar8,0);
              lVar5 = NGUITools.FindInParents(uVar4,DAT_181d8f1b8);
              cVar2 = Object.op_Inequality(lVar5,0,0);
              if (cVar2) {
                if (lVar5 == null) goto LAB_181196af3;
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
        LAB_181196af3:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar4 = Component.get_gameObject(plVar7,0);
            lVar5 = NGUITools.FindInParents(uVar4,DAT_181d8f438);
            cVar2 = Object.op_Inequality(lVar5,0,0);
            if (cVar2) {
              if (lVar5 == null) goto LAB_181196af3;
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

    // Token : 0x6000888
    // RVA   : 0x1196650   Offset: 0x1195A50   Length: 0xE
    private void OnEnable()
    {
        void FUN_181196650(int64 this)
        {
        if (this.mStarted) {
          UILocalize.OnLocalize(this,0);
          return;
        }
    }

    // Token : 0x6000889
    // RVA   : 0x1196780   Offset: 0x1195B80   Length: 0xB
    private void Start()
    {
        void FUN_181196780(int64 this)
        {
        this.mStarted = 1;
        UILocalize.OnLocalize(this,0);
    }

    // Token : 0x600088A
    // RVA   : 0x1196660   Offset: 0x1195A60   Length: 0x110
    private void OnLocalize()
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        cVar3 = FUN_180d75bc0(this.key,0);
        if (cVar3) {
          lVar2 = Component.GetComponent(this,DAT_181d96af8);
          cVar3 = Object.op_Inequality(lVar2,0,0);
          if (cVar3) {
            if (lVar2 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            this.key = *(uint64 *)(lVar2 + 0x1a0);
          }
        }
        cVar3 = FUN_180d75bc0(this.key,0);
        if (!cVar3) {
          uVar1 = this.key;
          uVar1 = Localization.Get(uVar1,1,0);
          UILocalize.set_value(this,uVar1,0);
        }
    }

    // Token : 0x600088B
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
