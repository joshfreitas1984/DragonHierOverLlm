// ============================================================
// Type  : TweenFill
// Token : 0x20000B9
// ============================================================

public class TweenFill
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000461
    public float from;

    // Token: 0x4000462
    public float to;

    // Token: 0x4000463
    private bool mCached;

    // Token: 0x4000464
    private UIBasicSprite mSprite;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000599
    // RVA   : 0xA6FEC0   Offset: 0xA6E6C0   Length: 0x52
    private void Cache()
    {
        ulong uVar1;
        this.mCached = 1;
        uVar1 = Component.GetComponent(this,DAT_181d6e640);
        this.mSprite = uVar1;
    }

    // Token : 0x600059A
    // RVA   : 0xA70090   Offset: 0xA6E890   Length: 0xDE
    public float get_value()
    {
        bool cVar1;
        ulong uVar2;
        if (!this.mCached) {
          this.mCached = 1;
          uVar2 = Component.GetComponent(this,DAT_181d6e640);
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

    // Token : 0x600059B
    // RVA   : 0xA70170   Offset: 0xA6E970   Length: 0xFA
    public void set_value(float value)
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        float fVar4;
        if (!this.mCached) {
          this.mCached = 1;
          uVar3 = Component.GetComponent(this,DAT_181d6e640);
          this.mSprite = uVar3;
        }
        uVar3 = this.mSprite;
        cVar2 = Object.op_Inequality(uVar3,0,0);
        if (cVar2) {
          lVar1 = this.mSprite;
          if (lVar1 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          fVar4 = (float)Mathf.Clamp01(value,0);
          if (lVar1.mFillAmount != fVar4) {
            lVar1.mFillAmount = fVar4;
            *(uint8 *)(lVar1 + 88) = 1;
          }
        }
    }

    // Token : 0x600059C
    // RVA   : 0xA6FF20   Offset: 0xA6E720   Length: 0x10F
    protected override void OnUpdate(float factor, bool isFinished)
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        uint uVar4;
        float fVar5;
        uVar4 = Mathf.Lerp(this.from,this.to,factor,0);
        if (!this.mCached) {
          this.mCached = 1;
          uVar3 = Component.GetComponent(this,DAT_181d6e640);
          this.mSprite = uVar3;
        }
        uVar3 = this.mSprite;
        cVar2 = Object.op_Inequality(uVar3,0,0);
        if (cVar2) {
          lVar1 = this.mSprite;
          if (lVar1 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          fVar5 = (float)Mathf.Clamp01(uVar4,0);
          if (lVar1.mFillAmount != fVar5) {
            lVar1.mFillAmount = fVar5;
            *(uint8 *)(lVar1 + 88) = 1;
          }
        }
    }

    // Token : 0x600059D
    // RVA   : 0xA6FE00   Offset: 0xA6E600   Length: 0xB7
    public static TweenFill Begin(GameObject go, float duration, float fill)
    {
        long lVar1;
        uint uVar2;
        lVar1 = UITweener.Begin(go,duration,0,DAT_181d9d950);
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

    // Token : 0x600059E
    // RVA   : 0xA70050   Offset: 0xA6E850   Length: 0x1B
    public override void SetStartToCurrentValue()
    {
        uint uVar1;
        uVar1 = TweenFill.get_value(this,0);
        this.from = uVar1;
    }

    // Token : 0x600059F
    // RVA   : 0xA70030   Offset: 0xA6E830   Length: 0x1B
    public override void SetEndToCurrentValue()
    {
        uint uVar1;
        uVar1 = TweenFill.get_value(this,0);
        this.to = uVar1;
    }

    // Token : 0x60005A0
    // RVA   : 0xA70070   Offset: 0xA6E870   Length: 0x15
    public void /*ctor*/()
    {
        void FUN_180a70070(int64 this)
        {
        this.from = 0x3f800000;
        this.to = 0x3f800000;
        UITweener.ctor(this,0);
    }

}
