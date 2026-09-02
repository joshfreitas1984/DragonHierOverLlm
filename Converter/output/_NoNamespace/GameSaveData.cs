// ============================================================
// Type  : GameSaveData
// Token : 0x20001BE
// ============================================================

public class GameSaveData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000BB6
    public string key;

    // Token: 0x4000BB7
    public bool worldDataFinished;

    // Token: 0x4000BB8
    public bool heroListFinished;

    // Token: 0x4000BB9
    public bool tempHeroListFinished;

    // Token: 0x4000BBA
    public WorldData WorldData;

    // Token: 0x4000BBB
    public List<HeroData> HeroList;

    // Token: 0x4000BBC
    public List<HeroData> TempHeroList;

    // Token: 0x4000BBD
    public float saveTimeCount;

    // Token: 0x4000BBE
    public bool saveFailed;

    // Token: 0x4000BBF
    public bool loading;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E60
    // RVA   : 0xA2DF10   Offset: 0xA2C710   Length: 0x14
    public bool CheckAllFinished()
    {
        ulong in_RAX;
        if ((this.worldDataFinished) && (this.heroListFinished)) {
          return (uint64)this.tempHeroListFinished;
        }
        return in_RAX & 0xffffffffffffff00;
    }

    // Token : 0x6000E61
    // RVA   : 0xA2DF30   Offset: 0xA2C730   Length: 0x19
    public void SetAllUnfinish(bool _loading)
    {
        this.loading = _loading;
        this.saveTimeCount = 0;
        this.worldDataFinished = 0;
        this.tempHeroListFinished = 0;
        this.saveFailed = 0;
    }

    // Token : 0x6000E62
    // RVA   : 0xA2DF50   Offset: 0xA2C750   Length: 0x16
    public void SetSaveFailed()
    {
        this.saveTimeCount = 0;
        this.worldDataFinished = 0x101;
        this.tempHeroListFinished = 1;
        this.saveFailed = 1;
    }

    // Token : 0x6000E63
    // RVA   : 0xA2DF70   Offset: 0xA2C770   Length: 0x11
    public void /*ctor*/()
    {
        this.worldDataFinished = 0x101;
        this.tempHeroListFinished = 1;
        ZhSegment.Initialize(this,0);
    }

}
