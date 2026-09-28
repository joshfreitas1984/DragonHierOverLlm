// ============================================================
// Type  : ForceJobSettingDataBase
// Token : 0x2000213
// ============================================================

public class ForceJobSettingDataBase
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000EF0
    public int minForceLv;

    // Token: 0x4000EF1
    public int maxForceLv;

    // Token: 0x4000EF2
    public List<ForceJobSettingIDDataBase> jobIDSetting;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600100A
    // RVA   : 0x77B160   Offset: 0x77A560   Length: 0xF
    public void /*ctor*/()
    {
        void FUN_18077b160(int64 this)
        {
        this.minForceLv = 0xffffffffffffffff;
        ZhSegment.Initialize(this,0);
    }

}
