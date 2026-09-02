// ============================================================
// Type  : FightMatchCouple
// Token : 0x2000276
// ============================================================

public class FightMatchCouple
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001363
    public int id;

    // Token: 0x4001364
    public List<HeroData> heroList0;

    // Token: 0x4001365
    public List<HeroData> heroList1;

    // Token: 0x4001366
    public int winTeam;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001417
    // RVA   : 0xBA4C00   Offset: 0xBA3400   Length: 0xAA
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d6e6b0);
        FUN_180f58a90(uVar1,DAT_181d63c78);
        this.heroList0 = uVar1;
        uVar1 = il2cpp_internal(DAT_181d6e6b0);
        FUN_180f58a90(uVar1,DAT_181d63c78);
        this.heroList1 = uVar1;
        this.winTeam = 0xffffffff;
        ZhSegment.Initialize(this,0);
        this.heroList0 = param_2;
        this.heroList1 = param_3;
    }

    // Token : 0x6001418
    // RVA   : 0xBA4CB0   Offset: 0xBA34B0   Length: 0x10F
    public void /*ctor*/(HeroData hero0, HeroData hero1)
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d6e6b0);
        FUN_180f58a90(uVar1,DAT_181d63c78);
        this.heroList0 = uVar1;
        uVar1 = il2cpp_internal(DAT_181d6e6b0);
        FUN_180f58a90(uVar1,DAT_181d63c78);
        this.heroList1 = uVar1;
        this.winTeam = 0xffffffff;
        ZhSegment.Initialize(this,0);
        this.heroList0 = hero0;
        this.heroList1 = hero1;
    }

    // Token : 0x6001419
    // RVA   : 0xBA4B10   Offset: 0xBA3310   Length: 0xEE
    public void /*ctor*/(List<HeroData> _heroLise0, List<HeroData> _heroLise1)
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d6e6b0);
        FUN_180f58a90(uVar1,DAT_181d63c78);
        this.heroList0 = uVar1;
        uVar1 = il2cpp_internal(DAT_181d6e6b0);
        FUN_180f58a90(uVar1,DAT_181d63c78);
        this.heroList1 = uVar1;
        this.winTeam = 0xffffffff;
        ZhSegment.Initialize(this,0);
        this.heroList0 = _heroLise0;
        this.heroList1 = _heroLise1;
    }

}
