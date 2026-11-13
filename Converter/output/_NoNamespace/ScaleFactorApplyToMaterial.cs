// ============================================================
// Type  : ScaleFactorApplyToMaterial
// Token : 0x20003E3
// ============================================================

public class ScaleFactorApplyToMaterial
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001F54
    private ParticleSystemRenderer ps;

    // Token: 0x4001F55
    private float value;

    // Token: 0x4001F56
    private float m_scaleFactor;

    // Token: 0x4001F57
    private float m_changedFactor;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60024E5
    // RVA   : 0x6A2BB0   Offset: 0x6A19B0   Length: 0x97
    private void Awake()
    {
        ulong uVar1;
        long lVar2;
        uint uVar3;
        uVar1 = Component.GetComponent(this,DAT_181e77f38);
        this.ps = uVar1;
        if (this.ps != null) {
          lVar2 = FUN_180af95e0(this.ps,0);
          if (lVar2 != null) {
            uVar3 = Material.GetFloat(lVar2,"_NoiseScale",0);
            this.value = uVar3;
            this.m_scaleFactor = 0x3f800000;
            return;
          }
        }
    }

    // Token : 0x60024E6
    // RVA   : 0x6A2C50   Offset: 0x6A1A50   Length: 0xF5
    private void Update()
    {
        long lVar1;
        float fVar2;
        fVar2 = **(float **)(DAT_181e93db8 + 184);
        this.m_changedFactor = fVar2;
        if ((this.m_scaleFactor == fVar2) || (1.0 < fVar2)) {
          return;
        }
        lVar1 = this.ps;
        this.m_scaleFactor = fVar2;
        if (fVar2 <= 0.5) {
          if ((lVar1 != null) && (lVar1 = FUN_180af95e0(lVar1,0)) != null) {
            fVar2 = this.value * 0.25;
            goto LAB_1806a2d03;
          }
        }
        else if ((lVar1 != null) && (lVar1 = FUN_180af95e0(lVar1,0)) != null) {
          fVar2 = this.value * this.m_scaleFactor;
        LAB_1806a2d03:
          Material.SetFloat(lVar1,"_NoiseScale",fVar2,0);
          return;
        }
    }

    // Token : 0x60024E7
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
