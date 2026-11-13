// ============================================================
// Type  : FightMatchCouple
// Token : 0x2000283
// ============================================================

public class FightMatchCouple
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001452
    public int id;

    // Token: 0x4001453
    public List<HeroData> heroList0;

    // Token: 0x4001454
    public List<HeroData> heroList1;

    // Token: 0x4001455
    public int winTeam;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60014C3
    // RVA   : 0x8EF680   Offset: 0x8EE480   Length: 0xAA
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181e73338);
        FUN_1810f3480(uVar1,DAT_181e6d6f0);
        this.heroList0 = uVar1;
        uVar1 = il2cpp_internal(DAT_181e73338);
        FUN_1810f3480(uVar1,DAT_181e6d6f0);
        this.heroList1 = uVar1;
        this.winTeam = 0xffffffff;
        ZhSegment.Initialize(this,0);
        this.heroList0 = param_2;
        this.heroList1 = param_3;
    }

    // Token : 0x60014C4
    // RVA   : 0x8EF730   Offset: 0x8EE530   Length: 0x10F
    public void /*ctor*/(HeroData hero0, HeroData hero1)
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181e73338);
        FUN_1810f3480(uVar1,DAT_181e6d6f0);
        this.heroList0 = uVar1;
        uVar1 = il2cpp_internal(DAT_181e73338);
        FUN_1810f3480(uVar1,DAT_181e6d6f0);
        this.heroList1 = uVar1;
        this.winTeam = 0xffffffff;
        ZhSegment.Initialize(this,0);
        this.heroList0 = hero0;
        this.heroList1 = hero1;
    }

    // Token : 0x60014C5
    // RVA   : 0x8EF590   Offset: 0x8EE390   Length: 0xEE
    public void /*ctor*/(List<HeroData> _heroLise0, List<HeroData> _heroLise1)
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181e73338);
        FUN_1810f3480(uVar1,DAT_181e6d6f0);
        this.heroList0 = uVar1;
        uVar1 = il2cpp_internal(DAT_181e73338);
        FUN_1810f3480(uVar1,DAT_181e6d6f0);
        this.heroList1 = uVar1;
        this.winTeam = 0xffffffff;
        ZhSegment.Initialize(this,0);
        this.heroList0 = _heroLise0;
        this.heroList1 = _heroLise1;
    }

}
