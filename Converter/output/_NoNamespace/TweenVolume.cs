// ============================================================
// Type  : TweenVolume
// Token : 0x20000C5
// ============================================================

public class TweenVolume
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40004B7
    public float from;

    // Token: 0x40004B8
    public float to;

    // Token: 0x40004B9
    private AudioSource mSource;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000606
    // RVA   : 0xAEDEC0   Offset: 0xAED2C0   Length: 0x181
    public AudioSource get_audioSource()
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = this.mSource;
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (cVar2) {
          uVar3 = Component.GetComponent(this,DAT_181d93378);
          *puVar1 = uVar3;
          il2cpp_internal(puVar1,uVar3);
          uVar3 = *puVar1;
          cVar2 = Object.op_Equality(uVar3,0,0);
          if (cVar2) {
            uVar3 = Component.GetComponent(this,DAT_181d93378);
            *puVar1 = uVar3;
            il2cpp_internal(puVar1,uVar3);
            uVar3 = *puVar1;
            cVar2 = Object.op_Equality(uVar3,0,0);
            if (cVar2) {
              Debug.LogError("TweenVolume needs an AudioSource to work with",this,0);
              Behaviour.set_enabled(this,0,0);
            }
          }
        }
        return *puVar1;
    }

    // Token : 0x6000607
    // RVA   : 0xAEE0F0   Offset: 0xAED4F0   Length: 0x7
    public float get_volume()
    {
        void FUN_180aee0f0(uint64 this)
        {
        TweenVolume.get_value(this,0);
    }

    // Token : 0x6000608
    // RVA   : 0xAEE1A0   Offset: 0xAED5A0   Length: 0x8
    public void set_volume(float value)
    {
        void FUN_180aee1a0(uint64 this,uint64 value)
        {
        TweenVolume.set_value(this,value,0);
    }

    // Token : 0x6000609
    // RVA   : 0xAEE050   Offset: 0xAED450   Length: 0x95
    public float get_value()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = TweenVolume.get_audioSource(this,0);
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (cVar1) {
          if (this.mSource != null) {
            uVar2 = AudioSource.get_volume(this.mSource,0);
            return uVar2;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        return 0;
    }

    // Token : 0x600060A
    // RVA   : 0xAEE100   Offset: 0xAED500   Length: 0x99
    public void set_value(float value)
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = TweenVolume.get_audioSource(this,0);
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          if (this.mSource == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          AudioSource.set_volume(this.mSource,value,0);
        }
    }

    // Token : 0x600060B
    // RVA   : 0xAEDE10   Offset: 0xAED210   Length: 0x63
    protected override void OnUpdate(float factor, bool isFinished)
    {
        long lVar1;
        float fVar2;
        fVar2 = factor * this.to;
        TweenVolume.set_value(fVar2,(1.0 - factor) * this.from + fVar2,0);
        lVar1 = this.mSource;
        if (lVar1 != null) {
          fVar2 = (float)AudioSource.get_volume(lVar1,0);
          Behaviour.set_enabled(lVar1,0.01 < fVar2,0);
          return;
        }
    }

    // Token : 0x600060C
    // RVA   : 0xAEDD40   Offset: 0xAED140   Length: 0xC7
    public static TweenVolume Begin(GameObject go, float duration, float targetVolume)
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        lVar1 = UITweener.Begin(go,duration,0,DAT_181dc71a8);
        if (lVar1 != null) {
          uVar3 = TweenVolume.get_value(lVar1,0);
          *(uint32 *)(lVar1 + 120) = uVar3;
          *(float *)(lVar1 + 124) = targetVolume;
          if (0.0 < targetVolume) {
            lVar2 = TweenVolume.get_audioSource(lVar1,0);
            if (lVar2 == null) throw; // [null/range check failed]
            Behaviour.set_enabled(lVar2,1,0);
            AudioSource.Play(lVar2,0);
          }
          return lVar1;
        }
    }

    // Token : 0x600060D
    // RVA   : 0xAEDEA0   Offset: 0xAED2A0   Length: 0x1B
    public override void SetStartToCurrentValue()
    {
        uint uVar1;
        uVar1 = TweenVolume.get_value(this,0);
        this.from = uVar1;
    }

    // Token : 0x600060E
    // RVA   : 0xAEDE80   Offset: 0xAED280   Length: 0x1B
    public override void SetEndToCurrentValue()
    {
        uint uVar1;
        uVar1 = TweenVolume.get_value(this,0);
        this.to = uVar1;
    }

    // Token : 0x600060F
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
