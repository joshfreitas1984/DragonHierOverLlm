// ============================================================
// Type  : InvBaseItem
// Token : 0x200000B
// ============================================================

public class InvBaseItem
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000022
    public int id16;

    // Token: 0x4000023
    public string name;

    // Token: 0x4000024
    public string description;

    // Token: 0x4000025
    public Slot slot;

    // Token: 0x4000026
    public int minItemLevel;

    // Token: 0x4000027
    public int maxItemLevel;

    // Token: 0x4000028
    public List<InvStat> stats;

    // Token: 0x4000029
    public GameObject attachment;

    // Token: 0x400002A
    public Color color;

    // Token: 0x400002B
    public object iconAtlas;

    // Token: 0x400002C
    public string iconName;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000025
    // RVA   : 0xA1D7E0   Offset: 0xA1C5E0   Length: 0xB6
    public void /*ctor*/()
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        ulong uVar4;
        byte[] local_18 = new byte[16];
        this.minItemLevel = 1;
        this.maxItemLevel = 50;
        uVar4 = il2cpp_internal(DAT_181e74038);
        FUN_1810f3480(uVar4,DAT_181e728f0);
        this.stats = uVar4;
        puVar5 = (uint32 *)FUN_180f24d00(local_18,0);
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
