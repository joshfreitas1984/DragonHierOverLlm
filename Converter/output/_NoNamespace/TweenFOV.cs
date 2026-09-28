// ============================================================
// Type  : TweenFOV
// Token : 0x20000B9
// ============================================================

public class TweenFOV
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400047A
    public float from;

    // Token: 0x400047B
    public float to;

    // Token: 0x400047C
    private Camera mCam;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60005A5
    // RVA   : 0xAE99D0   Offset: 0xAE8DD0   Length: 0xAC
    public Camera get_cachedCamera()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = this.mCam;
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          uVar2 = Component.GetComponent(this,DAT_181d937e0);
          this.mCam = uVar2;
        }
        return this.mCam;
    }

    // Token : 0x60005A6
    // RVA   : 0xAE9A80   Offset: 0xAE8E80   Length: 0x23
    public float get_fov()
    {
        long lVar1;
        lVar1 = TweenFOV.get_cachedCamera(this,0);
        if (lVar1 != null) {
          Camera.get_fieldOfView(lVar1,0);
          return;
        }
    }

    // Token : 0x60005A7
    // RVA   : 0xAE9AB0   Offset: 0xAE8EB0   Length: 0x34
    public void set_fov(float value)
    {
        long lVar1;
        lVar1 = TweenFOV.get_cachedCamera(this,0);
        if (lVar1 != null) {
          Camera.set_fieldOfView(lVar1,value,0);
          return;
        }
    }

    // Token : 0x60005A8
    // RVA   : 0xAE9A80   Offset: 0xAE8E80   Length: 0x23
    public float get_value()
    {
        long lVar1;
        lVar1 = TweenFOV.get_cachedCamera(this,0);
        if (lVar1 != null) {
          Camera.get_fieldOfView(lVar1,0);
          return;
        }
    }

    // Token : 0x60005A9
    // RVA   : 0xAE9AB0   Offset: 0xAE8EB0   Length: 0x34
    public void set_value(float value)
    {
        long lVar1;
        lVar1 = TweenFOV.get_cachedCamera(this,0);
        if (lVar1 != null) {
          Camera.set_fieldOfView(lVar1,value,0);
          return;
        }
    }

    // Token : 0x60005AA
    // RVA   : 0xAE9860   Offset: 0xAE8C60   Length: 0x6B
    protected override void OnUpdate(float factor, bool isFinished)
    {
        float fVar1;
        float fVar2;
        long lVar3;
        fVar1 = this.to;
        fVar2 = this.from;
        lVar3 = TweenFOV.get_cachedCamera(this,0);
        if (lVar3 != null) {
          Camera.set_fieldOfView(lVar3,(1.0 - factor) * fVar2 + fVar1 * factor,0);
          return;
        }
    }

    // Token : 0x60005AB
    // RVA   : 0xAE9790   Offset: 0xAE8B90   Length: 0xC6
    public static TweenFOV Begin(GameObject go, float duration, float to)
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        lVar1 = UITweener.Begin(go,duration,0,DAT_181dc6bb8);
        if (lVar1 != null) {
          lVar2 = TweenFOV.get_cachedCamera(lVar1,0);
          if (lVar2 != null) {
            uVar3 = Camera.get_fieldOfView(lVar2,0);
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

    // Token : 0x60005AC
    // RVA   : 0xAE9980   Offset: 0xAE8D80   Length: 0x2F
    public override void SetStartToCurrentValue()
    {
        long lVar1;
        uint uVar2;
        lVar1 = TweenFOV.get_cachedCamera(this,0);
        if (lVar1 != null) {
          uVar2 = Camera.get_fieldOfView(lVar1,0);
          this.from = uVar2;
          return;
        }
    }

    // Token : 0x60005AD
    // RVA   : 0xAE9950   Offset: 0xAE8D50   Length: 0x2F
    public override void SetEndToCurrentValue()
    {
        long lVar1;
        uint uVar2;
        lVar1 = TweenFOV.get_cachedCamera(this,0);
        if (lVar1 != null) {
          uVar2 = Camera.get_fieldOfView(lVar1,0);
          this.to = uVar2;
          return;
        }
    }

    // Token : 0x60005AE
    // RVA   : 0xAE9910   Offset: 0xAE8D10   Length: 0x36
    private void SetCurrentValueToStart()
    {
        uint uVar1;
        long lVar2;
        uVar1 = this.from;
        lVar2 = TweenFOV.get_cachedCamera(this,0);
        if (lVar2 != null) {
          Camera.set_fieldOfView(lVar2,uVar1,0);
          return;
        }
    }

    // Token : 0x60005AF
    // RVA   : 0xAE98D0   Offset: 0xAE8CD0   Length: 0x36
    private void SetCurrentValueToEnd()
    {
        uint uVar1;
        long lVar2;
        uVar1 = this.to;
        lVar2 = TweenFOV.get_cachedCamera(this,0);
        if (lVar2 != null) {
          Camera.set_fieldOfView(lVar2,uVar1,0);
          return;
        }
    }

    // Token : 0x60005B0
    // RVA   : 0xAE99B0   Offset: 0xAE8DB0   Length: 0x15
    public void /*ctor*/()
    {
        void FUN_180ae99b0(int64 this)
        {
        this.from = 0x42340000;
        this.to = 0x42340000;
        UITweener.ctor(this,0);
    }

}
