// ============================================================
// Type  : TweenVolume
// Token : 0x20000C4
// ============================================================

public class TweenVolume
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400049B
    public float from;

    // Token: 0x400049C
    public float to;

    // Token: 0x400049D
    private AudioSource mSource;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60005EE
    // RVA   : 0xA73B30   Offset: 0xA72330   Length: 0x181
    public AudioSource get_audioSource()
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = this.mSource;
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (cVar2) {
          uVar3 = Component.GetComponent(this,DAT_181d6ab40);
          *puVar1 = uVar3;
          il2cpp_internal(puVar1,uVar3);
          uVar3 = *puVar1;
          cVar2 = Object.op_Equality(uVar3,0,0);
          if (cVar2) {
            uVar3 = Component.GetComponent(this,DAT_181d6ab40);
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

    // Token : 0x60005EF
    // RVA   : 0xA73D60   Offset: 0xA72560   Length: 0x7
    public float get_volume()
    {
        void FUN_180a73d60(uint64 this)
        {
        TweenVolume.get_value(this,0);
    }

    // Token : 0x60005F0
    // RVA   : 0xA73E10   Offset: 0xA72610   Length: 0x8
    public void set_volume(float value)
    {
        void FUN_180a73e10(uint64 this,uint64 value)
        {
        TweenVolume.set_value(this,value,0);
    }

    // Token : 0x60005F1
    // RVA   : 0xA73CC0   Offset: 0xA724C0   Length: 0x95
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

    // Token : 0x60005F2
    // RVA   : 0xA73D70   Offset: 0xA72570   Length: 0x99
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

    // Token : 0x60005F3
    // RVA   : 0xA73A80   Offset: 0xA72280   Length: 0x63
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

    // Token : 0x60005F4
    // RVA   : 0xA739B0   Offset: 0xA721B0   Length: 0xC7
    public static TweenVolume Begin(GameObject go, float duration, float targetVolume)
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        lVar1 = UITweener.Begin(go,duration,0,DAT_181d9dd08);
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

    // Token : 0x60005F5
    // RVA   : 0xA73B10   Offset: 0xA72310   Length: 0x1B
    public override void SetStartToCurrentValue()
    {
        uint uVar1;
        uVar1 = TweenVolume.get_value(this,0);
        this.from = uVar1;
    }

    // Token : 0x60005F6
    // RVA   : 0xA73AF0   Offset: 0xA722F0   Length: 0x1B
    public override void SetEndToCurrentValue()
    {
        uint uVar1;
        uVar1 = TweenVolume.get_value(this,0);
        this.to = uVar1;
    }

    // Token : 0x60005F7
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
