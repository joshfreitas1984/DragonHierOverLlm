// ============================================================
// Type  : AudioClipPrefab
// Token : 0x200014C
// ============================================================

public class AudioClipPrefab
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400084B
    public string audioClip;

    // Token: 0x400084C
    public float volume;

    // Token: 0x400084D
    public bool BigMapBGM;

    // Token: 0x400084E
    public bool AreaBGM;

    // Token: 0x400084F
    public int areaTypeID;

    // Token: 0x4000850
    public int areaID;

    // Token: 0x4000851
    public bool FightBGM;

    // Token: 0x4000852
    public bool BossBGM;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000ABD
    // RVA   : 0x7F6230   Offset: 0x7F4A30   Length: 0xF
    public void /*ctor*/()
    {
        void FUN_1807f6230(int64 this)
        {
        this.areaTypeID = 0xffffffffffffffff;
        ZhSegment.Initialize(this,0);
    }

}
