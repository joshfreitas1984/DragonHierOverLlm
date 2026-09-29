// ============================================================
// Type  : TweenFill
// Token : 0x20000BA
// ============================================================

public class TweenFill
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400047D
    public float from;

    // Token: 0x400047E
    public float to;

    // Token: 0x400047F
    private bool mCached;

    // Token: 0x4000480
    private UIBasicSprite mSprite;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60005B1
    // RVA   : 0xAEA270   Offset: 0xAE9670   Length: 0x52
    private void Cache()
    {
        ulong uVar1;
        this.mCached = 1;
        uVar1 = Component.GetComponent(this,DAT_181d96ef8);
        this.mSprite = uVar1;
    }

    // Token : 0x60005B2
    // RVA   : 0xAEA430   Offset: 0xAE9830   Length: 0xDE
    public float get_value()
    {
        bool cVar1;
        ulong uVar2;
        if (!this.mCached) {
          this.mCached = 1;
          uVar2 = Component.GetComponent(this,DAT_181d96ef8);
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

    // Token : 0x60005B3
    // RVA   : 0xAEA510   Offset: 0xAE9910   Length: 0xE0
    public void set_value(float value)
    {
        bool cVar1;
        ulong uVar2;
        if (!this.mCached) {
          this.mCached = 1;
          uVar2 = Component.GetComponent(this,DAT_181d96ef8);
          this.mSprite = uVar2;
        }
        uVar2 = this.mSprite;
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (cVar1) {
          if (this.mSprite == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          UIBasicSprite.set_fillAmount(this.mSprite,value,0);
        }
    }

    // Token : 0x60005B4
    // RVA   : 0xAEA2D0   Offset: 0xAE96D0   Length: 0xF5
    protected override void OnUpdate(float factor, bool isFinished)
    {
        bool cVar1;
        ulong uVar2;
        uint uVar3;
        uVar3 = Mathf.Lerp(this.from,this.to,factor,0);
        if (!this.mCached) {
          this.mCached = 1;
          uVar2 = Component.GetComponent(this,DAT_181d96ef8);
          this.mSprite = uVar2;
        }
        uVar2 = this.mSprite;
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (cVar1) {
          if (this.mSprite == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          UIBasicSprite.set_fillAmount(this.mSprite,uVar3,0);
        }
    }

    // Token : 0x60005B5
    // RVA   : 0xAEA1B0   Offset: 0xAE95B0   Length: 0xB7
    public static TweenFill Begin(GameObject go, float duration, float fill)
    {
        long lVar1;
        uint uVar2;
        lVar1 = UITweener.Begin(go,duration,0,DAT_181dc6df0);
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

    // Token : 0x60005B6
    // RVA   : 0xAEA3F0   Offset: 0xAE97F0   Length: 0x1B
    public override void SetStartToCurrentValue()
    {
        uint uVar1;
        uVar1 = TweenFill.get_value(this,0);
        this.from = uVar1;
    }

    // Token : 0x60005B7
    // RVA   : 0xAEA3D0   Offset: 0xAE97D0   Length: 0x1B
    public override void SetEndToCurrentValue()
    {
        uint uVar1;
        uVar1 = TweenFill.get_value(this,0);
        this.to = uVar1;
    }

    // Token : 0x60005B8
    // RVA   : 0xAEA410   Offset: 0xAE9810   Length: 0x15
    public void /*ctor*/()
    {
        void FUN_180aea410(int64 this)
        {
        this.from = 0x3f800000;
        this.to = 0x3f800000;
        UITweener.ctor(this,0);
    }

}
