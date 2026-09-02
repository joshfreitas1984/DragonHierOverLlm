// ============================================================
// Type  : ScaleFactorApplyToMaterial
// Token : 0x20003CF
// ============================================================

public class ScaleFactorApplyToMaterial
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001DB7
    private ParticleSystemRenderer ps;

    // Token: 0x4001DB8
    private float value;

    // Token: 0x4001DB9
    private float m_scaleFactor;

    // Token: 0x4001DBA
    private float m_changedFactor;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60023B8
    // RVA   : 0x9685D0   Offset: 0x966DD0   Length: 0x97
    private void Awake()
    {
        ulong uVar1;
        long lVar2;
        uint uVar3;
        uVar1 = Component.GetComponent(this,DAT_181d6c3c0);
        this.ps = uVar1;
        if (this.ps != null) {
          lVar2 = FUN_180d94be0(this.ps,0);
          if (lVar2 != null) {
            uVar3 = Material.GetFloat(lVar2,"_NoiseScale",0);
            this.value = uVar3;
            this.m_scaleFactor = 0x3f800000;
            return;
          }
        }
    }

    // Token : 0x60023B9
    // RVA   : 0x968670   Offset: 0x966E70   Length: 0xF5
    private void Update()
    {
        long lVar1;
        float fVar2;
        fVar2 = **(float **)(DAT_181d8e610 + 184);
        this.m_changedFactor = fVar2;
        if ((this.m_scaleFactor == fVar2) || (1.0 < fVar2)) {
          return;
        }
        lVar1 = this.ps;
        this.m_scaleFactor = fVar2;
        if (fVar2 <= 0.5) {
          if ((lVar1 != null) && (lVar1 = FUN_180d94be0(lVar1,0)) != null) {
            fVar2 = this.value * 0.25;
            goto LAB_180968723;
          }
        }
        else if ((lVar1 != null) && (lVar1 = FUN_180d94be0(lVar1,0)) != null) {
          fVar2 = this.value * this.m_scaleFactor;
        LAB_180968723:
          Material.SetFloat(lVar1,"_NoiseScale",fVar2,0);
          return;
        }
    }

    // Token : 0x60023BA
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
