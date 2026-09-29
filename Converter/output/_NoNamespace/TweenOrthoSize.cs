// ============================================================
// Type  : TweenOrthoSize
// Token : 0x20000C0
// ============================================================

public class TweenOrthoSize
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400049F
    public float from;

    // Token: 0x40004A0
    public float to;

    // Token: 0x40004A1
    private Camera mCam;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60005D2
    // RVA   : 0xAEBFF0   Offset: 0xAEB3F0   Length: 0xAC
    public Camera get_cachedCamera()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = this.mCam;
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          uVar2 = Component.GetComponent(this,DAT_181d937f8);
          this.mCam = uVar2;
        }
        return this.mCam;
    }

    // Token : 0x60005D3
    // RVA   : 0xAEC0A0   Offset: 0xAEB4A0   Length: 0x23
    public float get_orthoSize()
    {
        long lVar1;
        lVar1 = TweenOrthoSize.get_cachedCamera(this,0);
        if (lVar1 != null) {
          Camera.get_orthographicSize(lVar1,0);
          return;
        }
    }

    // Token : 0x60005D4
    // RVA   : 0xAEC0D0   Offset: 0xAEB4D0   Length: 0x34
    public void set_orthoSize(float value)
    {
        long lVar1;
        lVar1 = TweenOrthoSize.get_cachedCamera(this,0);
        if (lVar1 != null) {
          Camera.set_orthographicSize(lVar1,value,0);
          return;
        }
    }

    // Token : 0x60005D5
    // RVA   : 0xAEC0A0   Offset: 0xAEB4A0   Length: 0x23
    public float get_value()
    {
        long lVar1;
        lVar1 = TweenOrthoSize.get_cachedCamera(this,0);
        if (lVar1 != null) {
          Camera.get_orthographicSize(lVar1,0);
          return;
        }
    }

    // Token : 0x60005D6
    // RVA   : 0xAEC0D0   Offset: 0xAEB4D0   Length: 0x34
    public void set_value(float value)
    {
        long lVar1;
        lVar1 = TweenOrthoSize.get_cachedCamera(this,0);
        if (lVar1 != null) {
          Camera.set_orthographicSize(lVar1,value,0);
          return;
        }
    }

    // Token : 0x60005D7
    // RVA   : 0xAEBF20   Offset: 0xAEB320   Length: 0x6B
    protected override void OnUpdate(float factor, bool isFinished)
    {
        float fVar1;
        float fVar2;
        long lVar3;
        fVar1 = this.to;
        fVar2 = this.from;
        lVar3 = TweenOrthoSize.get_cachedCamera(this,0);
        if (lVar3 != null) {
          Camera.set_orthographicSize(lVar3,(1.0 - factor) * fVar2 + fVar1 * factor,0);
          return;
        }
    }

    // Token : 0x60005D8
    // RVA   : 0xAEBE50   Offset: 0xAEB250   Length: 0xC6
    public static TweenOrthoSize Begin(GameObject go, float duration, float to)
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        lVar1 = UITweener.Begin(go,duration,0,DAT_181dc6f00);
        if (lVar1 != null) {
          lVar2 = TweenOrthoSize.get_cachedCamera(lVar1,0);
          if (lVar2 != null) {
            uVar3 = Camera.get_orthographicSize(lVar2,0);
            *(uint32 *)(lVar1 + 120) = uVar3;
            *(uint32 *)(lVar1 + 124) = to;
            if (duration <= 0.0) {
              UITweener.Sample(lVar1,0x3f800000,1,0);
              Behaviour.set_enabled(lVar1,0,0);
            }
            return lVar1;
          }
        }
    }

    // Token : 0x60005D9
    // RVA   : 0xAEBFC0   Offset: 0xAEB3C0   Length: 0x2F
    public override void SetStartToCurrentValue()
    {
        long lVar1;
        uint uVar2;
        lVar1 = TweenOrthoSize.get_cachedCamera(this,0);
        if (lVar1 != null) {
          uVar2 = Camera.get_orthographicSize(lVar1,0);
          this.from = uVar2;
          return;
        }
    }

    // Token : 0x60005DA
    // RVA   : 0xAEBF90   Offset: 0xAEB390   Length: 0x2F
    public override void SetEndToCurrentValue()
    {
        long lVar1;
        uint uVar2;
        lVar1 = TweenOrthoSize.get_cachedCamera(this,0);
        if (lVar1 != null) {
          uVar2 = Camera.get_orthographicSize(lVar1,0);
          this.to = uVar2;
          return;
        }
    }

    // Token : 0x60005DB
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
