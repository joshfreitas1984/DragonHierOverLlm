// ============================================================
// Type  : ScaleFactorApplyToMaterial
// Token : 0x20003D6
// ============================================================

public class ScaleFactorApplyToMaterial
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001EC2
    private ParticleSystemRenderer ps;

    // Token: 0x4001EC3
    private float value;

    // Token: 0x4001EC4
    private float m_scaleFactor;

    // Token: 0x4001EC5
    private float m_changedFactor;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600243B
    // RVA   : 0x97B5B0   Offset: 0x97A9B0   Length: 0x97
    private void Awake()
    {
        ulong uVar1;
        long lVar2;
        uint uVar3;
        uVar1 = Component.GetComponent(this,DAT_181d94bf8);
        this.ps = uVar1;
        if (this.ps != null) {
          lVar2 = FUN_180d9dd10(this.ps,0);
          if (lVar2 != null) {
            uVar3 = Material.GetFloat(lVar2,"_NoiseScale",0);
            this.value = uVar3;
            this.m_scaleFactor = 0x3f800000;
            return;
          }
        }
    }

    // Token : 0x600243C
    // RVA   : 0x97B650   Offset: 0x97AA50   Length: 0xF5
    private void Update()
    {
        long lVar1;
        float fVar2;
        fVar2 = **(float **)(DAT_181db38e0 + 184);
        this.m_changedFactor = fVar2;
        if ((this.m_scaleFactor == fVar2) || (1.0 < fVar2)) {
          return;
        }
        lVar1 = this.ps;
        this.m_scaleFactor = fVar2;
        if (fVar2 <= 0.5) {
          if ((lVar1 != null) && (lVar1 = FUN_180d9dd10(lVar1,0)) != null) {
            fVar2 = this.value * 0.25;
            goto LAB_18097b703;
          }
        }
        else if ((lVar1 != null) && (lVar1 = FUN_180d9dd10(lVar1,0)) != null) {
          fVar2 = this.value * this.m_scaleFactor;
        LAB_18097b703:
          Material.SetFloat(lVar1,"_NoiseScale",fVar2,0);
          return;
        }
    }

    // Token : 0x600243D
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
