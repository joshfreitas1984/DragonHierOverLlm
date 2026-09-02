// ============================================================
// Type  : TweenOrthoSize
// Token : 0x20000BF
// ============================================================

public class TweenOrthoSize
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000483
    public float from;

    // Token: 0x4000484
    public float to;

    // Token: 0x4000485
    private Camera mCam;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60005BA
    // RVA   : 0xA71C60   Offset: 0xA70460   Length: 0xAC
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

    // Token : 0x60005BB
    // RVA   : 0xA71D10   Offset: 0xA70510   Length: 0x23
    public float get_orthoSize()
    {
        long lVar1;
        lVar1 = TweenOrthoSize.get_cachedCamera(this,0);
        if (lVar1 != null) {
          Camera.get_orthographicSize(lVar1,0);
          return;
        }
    }

    // Token : 0x60005BC
    // RVA   : 0xA71D40   Offset: 0xA70540   Length: 0x34
    public void set_orthoSize(float value)
    {
        long lVar1;
        lVar1 = TweenOrthoSize.get_cachedCamera(this,0);
        if (lVar1 != null) {
          Camera.set_orthographicSize(lVar1,value,0);
          return;
        }
    }

    // Token : 0x60005BD
    // RVA   : 0xA71D10   Offset: 0xA70510   Length: 0x23
    public float get_value()
    {
        long lVar1;
        lVar1 = TweenOrthoSize.get_cachedCamera(this,0);
        if (lVar1 != null) {
          Camera.get_orthographicSize(lVar1,0);
          return;
        }
    }

    // Token : 0x60005BE
    // RVA   : 0xA71D40   Offset: 0xA70540   Length: 0x34
    public void set_value(float value)
    {
        long lVar1;
        lVar1 = TweenOrthoSize.get_cachedCamera(this,0);
        if (lVar1 != null) {
          Camera.set_orthographicSize(lVar1,value,0);
          return;
        }
    }

    // Token : 0x60005BF
    // RVA   : 0xA71B90   Offset: 0xA70390   Length: 0x6B
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

    // Token : 0x60005C0
    // RVA   : 0xA71AC0   Offset: 0xA702C0   Length: 0xC6
    public static TweenOrthoSize Begin(GameObject go, float duration, float to)
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        lVar1 = UITweener.Begin(go,duration,0,DAT_181d9da60);
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

    // Token : 0x60005C1
    // RVA   : 0xA71C30   Offset: 0xA70430   Length: 0x2F
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

    // Token : 0x60005C2
    // RVA   : 0xA71C00   Offset: 0xA70400   Length: 0x2F
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

    // Token : 0x60005C3
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
