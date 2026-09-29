// ============================================================
// Type  : GameSaveData
// Token : 0x20001C4
// ============================================================

public class GameSaveData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C43
    public string key;

    // Token: 0x4000C44
    public bool worldDataFinished;

    // Token: 0x4000C45
    public bool heroListFinished;

    // Token: 0x4000C46
    public bool tempHeroListFinished;

    // Token: 0x4000C47
    public WorldData WorldData;

    // Token: 0x4000C48
    public List<HeroData> HeroList;

    // Token: 0x4000C49
    public List<HeroData> TempHeroList;

    // Token: 0x4000C4A
    public float saveTimeCount;

    // Token: 0x4000C4B
    public bool saveFailed;

    // Token: 0x4000C4C
    public bool loading;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E95
    // RVA   : 0xA5D220   Offset: 0xA5C620   Length: 0x14
    public bool CheckAllFinished()
    {
        ulong in_RAX;
        if ((this.worldDataFinished) && (this.heroListFinished)) {
          return (uint64)this.tempHeroListFinished;
        }
        return in_RAX & 0xffffffffffffff00;
    }

    // Token : 0x6000E96
    // RVA   : 0xA5D240   Offset: 0xA5C640   Length: 0x19
    public void SetAllUnfinish(bool _loading)
    {
        this.loading = _loading;
        this.saveTimeCount = 0;
        this.worldDataFinished = 0;
        this.tempHeroListFinished = 0;
        this.saveFailed = 0;
    }

    // Token : 0x6000E97
    // RVA   : 0xA5D260   Offset: 0xA5C660   Length: 0x16
    public void SetSaveFailed()
    {
        this.saveTimeCount = 0;
        this.worldDataFinished = 0x101;
        this.tempHeroListFinished = 1;
        this.saveFailed = 1;
    }

    // Token : 0x6000E98
    // RVA   : 0xA5D280   Offset: 0xA5C680   Length: 0x11
    public void /*ctor*/()
    {
        this.worldDataFinished = 0x101;
        this.tempHeroListFinished = 1;
        ZhSegment.Initialize(this,0);
    }

}
