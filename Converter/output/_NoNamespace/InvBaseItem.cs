// ============================================================
// Type  : InvBaseItem
// Token : 0x200000C
// ============================================================

public class InvBaseItem
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000042
    public int id16;

    // Token: 0x4000043
    public string name;

    // Token: 0x4000044
    public string description;

    // Token: 0x4000045
    public Slot slot;

    // Token: 0x4000046
    public int minItemLevel;

    // Token: 0x4000047
    public int maxItemLevel;

    // Token: 0x4000048
    public List<InvStat> stats;

    // Token: 0x4000049
    public GameObject attachment;

    // Token: 0x400004A
    public Color color;

    // Token: 0x400004B
    public object iconAtlas;

    // Token: 0x400004C
    public string iconName;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600003E
    // RVA   : 0xC9BB80   Offset: 0xC9AF80   Length: 0xB6
    public void /*ctor*/()
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        ulong uVar4;
        byte[] local_18 = new byte[16];
        this.minItemLevel = 1;
        this.maxItemLevel = 50;
        uVar4 = il2cpp_internal(DAT_181d94068);
        FUN_181330100(uVar4,DAT_181d90730);
        this.stats = uVar4;
        puVar5 = (uint32 *)FUN_1810d3b80(local_18,0);
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
