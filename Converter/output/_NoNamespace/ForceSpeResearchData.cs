// ============================================================
// Type  : ForceSpeResearchData
// Token : 0x20001E0
// ============================================================

public class ForceSpeResearchData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000CBD
    public float researchRate;

    // Token: 0x4000CBE
    public List<ItemData> material;

    // Token: 0x4000CBF
    public float addDamageRate;

    // Token: 0x4000CC0
    public HeroSpeAddData researchBuff;

    // Token: 0x4000CC1
    public int leftTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000EDA
    // RVA   : 0x1855860   Offset: 0x1854660   Length: 0xE2
    public void /*ctor*/()
    {
        long lVar1;
        ulong uVar2;
        ZhSegment.Initialize(this,0);
        lVar1 = il2cpp_internal(DAT_181e740b8);
        FUN_1810f3480(lVar1,DAT_181e72b70);
        if (lVar1 != null) {
          FUN_18175de30(lVar1,0,DAT_181e72cf0);
          FUN_18175de30(lVar1,0,DAT_181e72cf0);
          this.material = lVar1;
          this.researchBuff = new HeroSpeAddData(0);
          return;
        }
    }

    // Token : 0x6000EDB
    // RVA   : 0x1855770   Offset: 0x1854570   Length: 0xEE
    public void Reset()
    {
        long lVar1;
        ulong uVar2;
        this.researchRate = 0;
        lVar1 = il2cpp_internal(DAT_181e740b8);
        FUN_1810f3480(lVar1,DAT_181e72b70);
        if (lVar1 != null) {
          FUN_18175de30(lVar1,0,DAT_181e72cf0);
          FUN_18175de30(lVar1,0,DAT_181e72cf0);
          this.material = lVar1;
          this.addDamageRate = 0;
          this.researchBuff = new HeroSpeAddData(0);
          this.leftTime = 0;
          return;
        }
    }

    // Token : 0x6000EDC
    // RVA   : 0x1855700   Offset: 0x1854500   Length: 0x67
    public void ChangeResearchRate(float changeNum)
    {
        float fVar1;
        float fVar2;
        uint uVar3;
        fVar1 = this.researchRate;
        fVar2 = (float)Mathf.Max(0x3dcccccd,1.0 - fVar1,0);
        uVar3 = FUN_180f34e60(fVar2 * changeNum + fVar1,0,0x3f800000,0);
        this.researchRate = uVar3;
    }

}
