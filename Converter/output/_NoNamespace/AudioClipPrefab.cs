// ============================================================
// Type  : AudioClipPrefab
// Token : 0x2000150
// ============================================================

public class AudioClipPrefab
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000872
    public string audioClip;

    // Token: 0x4000873
    public float volume;

    // Token: 0x4000874
    public bool BigMapBGM;

    // Token: 0x4000875
    public bool AreaBGM;

    // Token: 0x4000876
    public int areaTypeID;

    // Token: 0x4000877
    public int areaID;

    // Token: 0x4000878
    public bool FightBGM;

    // Token: 0x4000879
    public bool BossBGM;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000AE0
    // RVA   : 0x7F4660   Offset: 0x7F3A60   Length: 0xF
    public void /*ctor*/()
    {
        void FUN_1807f4660(int64 this)
        {
        this.areaTypeID = 0xffffffffffffffff;
        ZhSegment.Initialize(this,0);
    }

}
