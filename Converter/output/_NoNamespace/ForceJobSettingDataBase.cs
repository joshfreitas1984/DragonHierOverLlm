// ============================================================
// Type  : ForceJobSettingDataBase
// Token : 0x2000215
// ============================================================

public class ForceJobSettingDataBase
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000F04
    public int minForceLv;

    // Token: 0x4000F05
    public int maxForceLv;

    // Token: 0x4000F06
    public List<ForceJobSettingIDDataBase> jobIDSetting;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001013
    // RVA   : 0x1850640   Offset: 0x184F440   Length: 0xF
    public void /*ctor*/()
    {
        void FUN_181850640(int64 this)
        {
        this.minForceLv = 0xffffffffffffffff;
        ZhSegment.Initialize(this,0);
    }

}
