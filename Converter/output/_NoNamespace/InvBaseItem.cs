// ============================================================
// Type  : InvBaseItem
// Token : 0x200000B
// ============================================================

public class InvBaseItem
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000026
    public int id16;

    // Token: 0x4000027
    public string name;

    // Token: 0x4000028
    public string description;

    // Token: 0x4000029
    public Slot slot;

    // Token: 0x400002A
    public int minItemLevel;

    // Token: 0x400002B
    public int maxItemLevel;

    // Token: 0x400002C
    public List<InvStat> stats;

    // Token: 0x400002D
    public GameObject attachment;

    // Token: 0x400002E
    public Color color;

    // Token: 0x400002F
    public object iconAtlas;

    // Token: 0x4000030
    public string iconName;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000026
    // RVA   : 0xB71610   Offset: 0xB6FE10   Length: 0xB6
    public void /*ctor*/()
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        ulong uVar4;
        byte[] local_18 = new byte[16];
        this.minItemLevel = 1;
        this.maxItemLevel = 50;
        uVar4 = il2cpp_internal(DAT_181d6f3b0);
        FUN_180f58a90(uVar4,DAT_181d68f70);
        this.stats = uVar4;
        puVar5 = (uint32 *)FUN_181098a50(local_18,0);
        uVar1 = puVar5[1];
        uVar2 = puVar5[2];
        uVar3 = puVar5[3];
        this.color = *puVar5;
        *(uint32 *)(this + 76) = uVar1;
        *(uint32 *)(this + 80) = uVar2;
        *(uint32 *)(this + 84) = uVar3;
        this.iconName = "";
        ZhSegment.Initialize(this,0);
    }

}
