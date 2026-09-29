// ============================================================
// Type  : CFX_LightIntensityFade
// Token : 0x20003C3
// ============================================================

public class CFX_LightIntensityFade
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001E43
    public float duration;

    // Token: 0x4001E44
    public float delay;

    // Token: 0x4001E45
    public float finalIntensity;

    // Token: 0x4001E46
    private float baseIntensity;

    // Token: 0x4001E47
    public bool autodestruct;

    // Token: 0x4001E48
    private float p_lifetime;

    // Token: 0x4001E49
    private float p_delay;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60023EE
    // RVA   : 0xB80770   Offset: 0xB7FB70   Length: 0x53
    private void Start()
    {
        long lVar1;
        uint uVar2;
        lVar1 = Component.GetComponent(this,DAT_181d947f8);
        if (lVar1 != null) {
          uVar2 = Light.get_intensity(lVar1,0);
          this.baseIntensity = uVar2;
          return;
        }
    }

    // Token : 0x60023EF
    // RVA   : 0xB80700   Offset: 0xB7FB00   Length: 0x6F
    private void OnEnable()
    {
        long lVar1;
        this.p_lifetime = 0;
        this.p_delay = this.delay;
        if (0.0 < this.delay) {
          lVar1 = Component.GetComponent(this,DAT_181d947f8);
          if (lVar1 != null) {
            Behaviour.set_enabled(lVar1,0,0);
            return;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x60023F0
    // RVA   : 0xB807D0   Offset: 0xB7FBD0   Length: 0x154
    private void Update()
    {
        ulong uVar1;
        long lVar2;
        uint uVar3;
        float fVar4;
        float fVar5;
        fVar5 = this.p_delay;
        if (0.0 < fVar5) {
          fVar4 = (float)Time.get_deltaTime(0);
          fVar5 = fVar5 - fVar4;
          this.p_delay = fVar5;
          if (fVar5 <= 0.0) {
            lVar2 = Component.GetComponent(this,DAT_181d947f8);
            if (lVar2 != null)
            {
              Behaviour.set_enabled(lVar2,1,0);
              }
              }
              else if (this.p_lifetime / this.duration < 1.0) {
              lVar2 = Component.GetComponent(this,DAT_181d947f8);
              uVar3 = Mathf.Lerp(this.baseIntensity,this.finalIntensity,
              this.p_lifetime / this.duration,0);
              if (lVar2 == null) {
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          Light.set_intensity(lVar2,uVar3,0);
          fVar5 = this.p_lifetime;
          fVar4 = (float)Time.get_deltaTime(0);
          this.p_lifetime = fVar4 + fVar5;
        }
        else if (this.autodestruct) {
          uVar1 = Component.get_gameObject(this,0);
          Object.Destroy(uVar1,0);
        }
    }

    // Token : 0x60023F1
    // RVA   : 0xA1F070   Offset: 0xA1E470   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_180a1f070(int64 this)
        {
        this.duration = 0x3f800000;
        FUN_18044ef50(this,0);
    }

}
