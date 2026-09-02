// ============================================================
// Type  : ForceJobSettingDataBase
// Token : 0x200020D
// ============================================================

public class ForceJobSettingDataBase
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000E60
    public int minForceLv;

    // Token: 0x4000E61
    public int maxForceLv;

    // Token: 0x4000E62
    public List<ForceJobSettingIDDataBase> jobIDSetting;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000FD2
    // RVA   : 0x77E850   Offset: 0x77D050   Length: 0xF
    public void /*ctor*/()
    {
        void FUN_18077e850(int64 this)
        {
        this.minForceLv = 0xffffffffffffffff;
        ZhSegment.Initialize(this,0);
    }

}
