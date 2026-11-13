// ============================================================
// Type  : AudioClipPrefab
// Token : 0x200014C
// ============================================================

public class AudioClipPrefab
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000854
    public string audioClip;

    // Token: 0x4000855
    public float volume;

    // Token: 0x4000856
    public bool BigMapBGM;

    // Token: 0x4000857
    public bool AreaBGM;

    // Token: 0x4000858
    public int areaTypeID;

    // Token: 0x4000859
    public int areaID;

    // Token: 0x400085A
    public bool FightBGM;

    // Token: 0x400085B
    public bool BossBGM;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000ABF
    // RVA   : 0x526A10   Offset: 0x525810   Length: 0xF
    public void /*ctor*/()
    {
        void FUN_180526a10(int64 this)
        {
        this.areaTypeID = 0xffffffffffffffff;
        ZhSegment.Initialize(this,0);
    }

}
