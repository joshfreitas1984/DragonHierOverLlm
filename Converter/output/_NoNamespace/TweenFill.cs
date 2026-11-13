// ============================================================
// Type  : TweenFill
// Token : 0x20000B9
// ============================================================

public class TweenFill
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400045D
    public float from;

    // Token: 0x400045E
    public float to;

    // Token: 0x400045F
    private bool mCached;

    // Token: 0x4000460
    private UIBasicSprite mSprite;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000598
    // RVA   : 0x83EFF0   Offset: 0x83DDF0   Length: 0x52
    private void Cache()
    {
        ulong uVar1;
        this.mCached = 1;
        uVar1 = Component.GetComponent(this,DAT_181e7a2b8);
        this.mSprite = uVar1;
    }

    // Token : 0x6000599
    // RVA   : 0x83F1B0   Offset: 0x83DFB0   Length: 0xDE
    public float get_value()
    {
        bool cVar1;
        ulong uVar2;
        if (!this.mCached) {
          this.mCached = 1;
          uVar2 = Component.GetComponent(this,DAT_181e7a2b8);
          this.mSprite = uVar2;
        }
        uVar2 = this.mSprite;
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (!cVar1) {
          return 0;
        }
        if (this.mSprite != null) {
          return this.mSprite.mFillAmount;
        }
    }

    // Token : 0x600059A
    // RVA   : 0x83F290   Offset: 0x83E090   Length: 0xE0
    public void set_value(float value)
    {
        bool cVar1;
        ulong uVar2;
        if (!this.mCached) {
          this.mCached = 1;
          uVar2 = Component.GetComponent(this,DAT_181e7a2b8);
          this.mSprite = uVar2;
        }
        uVar2 = this.mSprite;
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (cVar1) {
          if (this.mSprite == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          UIBasicSprite.set_fillAmount(this.mSprite,value,0);
        }
    }

    // Token : 0x600059B
    // RVA   : 0x83F050   Offset: 0x83DE50   Length: 0xF5
    protected override void OnUpdate(float factor, bool isFinished)
    {
        bool cVar1;
        ulong uVar2;
        uint uVar3;
        uVar3 = Mathf.Lerp(this.from,this.to,factor,0);
        if (!this.mCached) {
          this.mCached = 1;
          uVar2 = Component.GetComponent(this,DAT_181e7a2b8);
          this.mSprite = uVar2;
        }
        uVar2 = this.mSprite;
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (cVar1) {
          if (this.mSprite == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          UIBasicSprite.set_fillAmount(this.mSprite,uVar3,0);
        }
    }

    // Token : 0x600059C
    // RVA   : 0x83EF30   Offset: 0x83DD30   Length: 0xB7
    public static TweenFill Begin(GameObject go, float duration, float fill)
    {
        long lVar1;
        uint uVar2;
        lVar1 = UITweener.Begin(go,duration,0,DAT_181e530a8);
        if (lVar1 != null) {
          uVar2 = TweenFill.get_value(lVar1,0);
          *(uint32 *)(lVar1 + 120) = uVar2;
          *(uint32 *)(lVar1 + 124) = fill;
          if (duration <= 0.0) {
            UITweener.Sample(lVar1,0x3f800000,1,0);
            Behaviour.set_enabled(lVar1,0,0);
          }
          return lVar1;
        }
    }

    // Token : 0x600059D
    // RVA   : 0x83F170   Offset: 0x83DF70   Length: 0x1B
    public override void SetStartToCurrentValue()
    {
        uint uVar1;
        uVar1 = TweenFill.get_value(this,0);
        this.from = uVar1;
    }

    // Token : 0x600059E
    // RVA   : 0x83F150   Offset: 0x83DF50   Length: 0x1B
    public override void SetEndToCurrentValue()
    {
        uint uVar1;
        uVar1 = TweenFill.get_value(this,0);
        this.to = uVar1;
    }

    // Token : 0x600059F
    // RVA   : 0x83F190   Offset: 0x83DF90   Length: 0x15
    public void /*ctor*/()
    {
        void FUN_18083f190(int64 this)
        {
        this.from = 0x3f800000;
        this.to = 0x3f800000;
        UITweener.ctor(this,0);
    }

}
