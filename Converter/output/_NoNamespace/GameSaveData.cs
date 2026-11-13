// ============================================================
// Type  : GameSaveData
// Token : 0x20001C6
// ============================================================

public class GameSaveData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C55
    public string key;

    // Token: 0x4000C56
    public bool worldDataFinished;

    // Token: 0x4000C57
    public bool heroListFinished;

    // Token: 0x4000C58
    public bool tempHeroListFinished;

    // Token: 0x4000C59
    public WorldData WorldData;

    // Token: 0x4000C5A
    public List<HeroData> HeroList;

    // Token: 0x4000C5B
    public List<HeroData> TempHeroList;

    // Token: 0x4000C5C
    public float saveTimeCount;

    // Token: 0x4000C5D
    public bool saveFailed;

    // Token: 0x4000C5E
    public bool loading;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E99
    // RVA   : 0x6BEFC0   Offset: 0x6BDDC0   Length: 0x14
    public bool CheckAllFinished()
    {
        ulong in_RAX;
        if ((this.worldDataFinished) && (this.heroListFinished)) {
          return (uint64)this.tempHeroListFinished;
        }
        return in_RAX & 0xffffffffffffff00;
    }

    // Token : 0x6000E9A
    // RVA   : 0x6BEFE0   Offset: 0x6BDDE0   Length: 0x19
    public void SetAllUnfinish(bool _loading)
    {
        this.loading = _loading;
        this.saveTimeCount = 0;
        this.worldDataFinished = 0;
        this.tempHeroListFinished = 0;
        this.saveFailed = 0;
    }

    // Token : 0x6000E9B
    // RVA   : 0x6BF000   Offset: 0x6BDE00   Length: 0x16
    public void SetSaveFailed()
    {
        this.saveTimeCount = 0;
        this.worldDataFinished = 0x101;
        this.tempHeroListFinished = 1;
        this.saveFailed = 1;
    }

    // Token : 0x6000E9C
    // RVA   : 0x6BF020   Offset: 0x6BDE20   Length: 0x11
    public void /*ctor*/()
    {
        this.worldDataFinished = 0x101;
        this.tempHeroListFinished = 1;
        ZhSegment.Initialize(this,0);
    }

}
