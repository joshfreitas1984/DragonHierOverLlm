// ============================================================
// Type  : TweenFOV
// Token : 0x20000B8
// ============================================================

public class TweenFOV
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400045E
    public float from;

    // Token: 0x400045F
    public float to;

    // Token: 0x4000460
    private Camera mCam;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600058D
    // RVA   : 0xA6FCE0   Offset: 0xA6E4E0   Length: 0xAC
    public Camera get_cachedCamera()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = this.mCam;
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          uVar2 = Component.GetComponent(this,DAT_181d6afc0);
          this.mCam = uVar2;
        }
        return this.mCam;
    }

    // Token : 0x600058E
    // RVA   : 0xA6FD90   Offset: 0xA6E590   Length: 0x23
    public float get_fov()
    {
        long lVar1;
        lVar1 = TweenFOV.get_cachedCamera(this,0);
        if (lVar1 != null) {
          Camera.get_fieldOfView(lVar1,0);
          return;
        }
    }

    // Token : 0x600058F
    // RVA   : 0xA6FDC0   Offset: 0xA6E5C0   Length: 0x34
    public void set_fov(float value)
    {
        long lVar1;
        lVar1 = TweenFOV.get_cachedCamera(this,0);
        if (lVar1 != null) {
          Camera.set_fieldOfView(lVar1,value,0);
          return;
        }
    }

    // Token : 0x6000590
    // RVA   : 0xA6FD90   Offset: 0xA6E590   Length: 0x23
    public float get_value()
    {
        long lVar1;
        lVar1 = TweenFOV.get_cachedCamera(this,0);
        if (lVar1 != null) {
          Camera.get_fieldOfView(lVar1,0);
          return;
        }
    }

    // Token : 0x6000591
    // RVA   : 0xA6FDC0   Offset: 0xA6E5C0   Length: 0x34
    public void set_value(float value)
    {
        long lVar1;
        lVar1 = TweenFOV.get_cachedCamera(this,0);
        if (lVar1 != null) {
          Camera.set_fieldOfView(lVar1,value,0);
          return;
        }
    }

    // Token : 0x6000592
    // RVA   : 0xA6FB70   Offset: 0xA6E370   Length: 0x6B
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

    // Token : 0x6000593
    // RVA   : 0xA6FAA0   Offset: 0xA6E2A0   Length: 0xC6
    public static TweenFOV Begin(GameObject go, float duration, float to)
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        lVar1 = UITweener.Begin(go,duration,0,DAT_181d9d8c8);
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

    // Token : 0x6000594
    // RVA   : 0xA6FC90   Offset: 0xA6E490   Length: 0x2F
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

    // Token : 0x6000595
    // RVA   : 0xA6FC60   Offset: 0xA6E460   Length: 0x2F
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

    // Token : 0x6000596
    // RVA   : 0xA6FC20   Offset: 0xA6E420   Length: 0x36
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

    // Token : 0x6000597
    // RVA   : 0xA6FBE0   Offset: 0xA6E3E0   Length: 0x36
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

    // Token : 0x6000598
    // RVA   : 0xA6FCC0   Offset: 0xA6E4C0   Length: 0x15
    public void /*ctor*/()
    {
        void FUN_180a6fcc0(int64 this)
        {
        this.from = 0x42340000;
        this.to = 0x42340000;
        UITweener.ctor(this,0);
    }

}
