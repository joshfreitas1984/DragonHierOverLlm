// ============================================================
// Type  : ForceSpeResearchData
// Token : 0x20001D8
// ============================================================

public class ForceSpeResearchData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C1D
    public float researchRate;

    // Token: 0x4000C1E
    public List<ItemData> material;

    // Token: 0x4000C1F
    public float addDamageRate;

    // Token: 0x4000C20
    public HeroSpeAddData researchBuff;

    // Token: 0x4000C21
    public int leftTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E9F
    // RVA   : 0x783B30   Offset: 0x782330   Length: 0xE2
    public void /*ctor*/()
    {
        long lVar1;
        ulong uVar2;
        ZhSegment.Initialize(this,0);
        lVar1 = il2cpp_internal(DAT_181d6f430);
        FUN_180f58a90(lVar1,DAT_181d691f0);
        if (lVar1 != null) {
          FUN_181827900(lVar1,0,DAT_181d692f0);
          FUN_181827900(lVar1,0,DAT_181d692f0);
          this.material = lVar1;
          this.researchBuff = new HeroSpeAddData(0);
          return;
        }
    }

    // Token : 0x6000EA0
    // RVA   : 0x783A40   Offset: 0x782240   Length: 0xEE
    public void Reset()
    {
        long lVar1;
        ulong uVar2;
        this.researchRate = 0;
        lVar1 = il2cpp_internal(DAT_181d6f430);
        FUN_180f58a90(lVar1,DAT_181d691f0);
        if (lVar1 != null) {
          FUN_181827900(lVar1,0,DAT_181d692f0);
          FUN_181827900(lVar1,0,DAT_181d692f0);
          this.material = lVar1;
          this.addDamageRate = 0;
          this.researchBuff = new HeroSpeAddData(0);
          this.leftTime = 0;
          return;
        }
    }

    // Token : 0x6000EA1
    // RVA   : 0x7839D0   Offset: 0x7821D0   Length: 0x67
    public void ChangeResearchRate(float changeNum)
    {
        float fVar1;
        float fVar2;
        uint uVar3;
        fVar1 = this.researchRate;
        fVar2 = (float)Mathf.Max(0x3dcccccd,1.0 - fVar1,0);
        uVar3 = FUN_1810a8ba0(fVar2 * changeNum + fVar1,0,0x3f800000,0);
        this.researchRate = uVar3;
    }

}
