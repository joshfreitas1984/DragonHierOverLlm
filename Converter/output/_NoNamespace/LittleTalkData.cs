// ============================================================
// Type  : LittleTalkData
// Token : 0x20002C9
// ============================================================

public class LittleTalkData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001687
    public GameObject target;

    // Token: 0x4001688
    public List<GameObject> littleTalks;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600179D
    // RVA   : 0xA854B0   Offset: 0xA83CB0   Length: 0x92
    public void /*ctor*/(GameObject _target)
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d6e2b0);
        FUN_180f58a90(uVar1,DAT_181d61af8);
        this.littleTalks = uVar1;
        ZhSegment.Initialize(this,0);
        this.target = _target;
    }

}
