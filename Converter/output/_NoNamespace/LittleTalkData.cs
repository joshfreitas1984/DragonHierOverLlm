// ============================================================
// Type  : LittleTalkData
// Token : 0x20002D8
// ============================================================

public class LittleTalkData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001790
    public GameObject target;

    // Token: 0x4001791
    public List<GameObject> littleTalks;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600185D
    // RVA   : 0x7C4E90   Offset: 0x7C3C90   Length: 0x92
    public void /*ctor*/(GameObject _target)
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181e72f38);
        FUN_1810f3480(uVar1,DAT_181e6b5f8);
        this.littleTalks = uVar1;
        ZhSegment.Initialize(this,0);
        this.target = _target;
    }

}
