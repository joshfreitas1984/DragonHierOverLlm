// ============================================================
// Type  : LittleTalkData
// Token : 0x20002CF
// ============================================================

public class LittleTalkData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400173B
    public GameObject target;

    // Token: 0x400173C
    public List<GameObject> littleTalks;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60017E1
    // RVA   : 0xA808A0   Offset: 0xA7FCA0   Length: 0x92
    public void /*ctor*/(GameObject _target)
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d92f58);
        FUN_18132faf0(uVar1,DAT_181d89298);
        this.littleTalks = uVar1;
        ZhSegment.Initialize(this,0);
        this.target = _target;
    }

}
