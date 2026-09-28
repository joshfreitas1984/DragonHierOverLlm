// ============================================================
// Type  : ForceSpeResearchData
// Token : 0x20001DE
// ============================================================

public class ForceSpeResearchData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000CAA
    public float researchRate;

    // Token: 0x4000CAB
    public List<ItemData> material;

    // Token: 0x4000CAC
    public float addDamageRate;

    // Token: 0x4000CAD
    public HeroSpeAddData researchBuff;

    // Token: 0x4000CAE
    public int leftTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000ED4
    // RVA   : 0x780470   Offset: 0x77F870   Length: 0xE2
    public void /*ctor*/()
    {
        long lVar1;
        ulong uVar2;
        ZhSegment.Initialize(this,0);
        lVar1 = il2cpp_internal(DAT_181d940d0);
        FUN_18132faf0(lVar1,DAT_181d90998);
        if (lVar1 != null) {
          FUN_18181e0a0(lVar1,0,DAT_181d90a98);
          FUN_18181e0a0(lVar1,0,DAT_181d90a98);
          this.material = lVar1;
          this.researchBuff = new HeroSpeAddData(0);
          return;
        }
    }

    // Token : 0x6000ED5
    // RVA   : 0x780380   Offset: 0x77F780   Length: 0xEE
    public void Reset()
    {
        long lVar1;
        ulong uVar2;
        this.researchRate = 0;
        lVar1 = il2cpp_internal(DAT_181d940d0);
        FUN_18132faf0(lVar1,DAT_181d90998);
        if (lVar1 != null) {
          FUN_18181e0a0(lVar1,0,DAT_181d90a98);
          FUN_18181e0a0(lVar1,0,DAT_181d90a98);
          this.material = lVar1;
          this.addDamageRate = 0;
          this.researchBuff = new HeroSpeAddData(0);
          this.leftTime = 0;
          return;
        }
    }

    // Token : 0x6000ED6
    // RVA   : 0x780310   Offset: 0x77F710   Length: 0x67
    public void ChangeResearchRate(float changeNum)
    {
        float fVar1;
        float fVar2;
        uint uVar3;
        fVar1 = this.researchRate;
        fVar2 = (float)Mathf.Max(0x3dcccccd,1.0 - fVar1,0);
        uVar3 = FUN_1810e36c0(fVar2 * changeNum + fVar1,0,0x3f800000,0);
        this.researchRate = uVar3;
    }

}
