// ============================================================
// Type  : FightMatchCouple
// Token : 0x200027C
// ============================================================

public class FightMatchCouple
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001414
    public int id;

    // Token: 0x4001415
    public List<HeroData> heroList0;

    // Token: 0x4001416
    public List<HeroData> heroList1;

    // Token: 0x4001417
    public int winTeam;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600145B
    // RVA   : 0xB2DCC0   Offset: 0xB2D0C0   Length: 0xAA
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d93368);
        FUN_181330100(uVar1,DAT_181d8b430);
        this.heroList0 = uVar1;
        uVar1 = il2cpp_internal(DAT_181d93368);
        FUN_181330100(uVar1,DAT_181d8b430);
        this.heroList1 = uVar1;
        this.winTeam = 0xffffffff;
        ZhSegment.Initialize(this,0);
        this.heroList0 = param_2;
        this.heroList1 = param_3;
    }

    // Token : 0x600145C
    // RVA   : 0xB2DD70   Offset: 0xB2D170   Length: 0x10F
    public void /*ctor*/(HeroData hero0, HeroData hero1)
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d93368);
        FUN_181330100(uVar1,DAT_181d8b430);
        this.heroList0 = uVar1;
        uVar1 = il2cpp_internal(DAT_181d93368);
        FUN_181330100(uVar1,DAT_181d8b430);
        this.heroList1 = uVar1;
        this.winTeam = 0xffffffff;
        ZhSegment.Initialize(this,0);
        this.heroList0 = hero0;
        this.heroList1 = hero1;
    }

    // Token : 0x600145D
    // RVA   : 0xB2DBD0   Offset: 0xB2CFD0   Length: 0xEE
    public void /*ctor*/(List<HeroData> _heroLise0, List<HeroData> _heroLise1)
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d93368);
        FUN_181330100(uVar1,DAT_181d8b430);
        this.heroList0 = uVar1;
        uVar1 = il2cpp_internal(DAT_181d93368);
        FUN_181330100(uVar1,DAT_181d8b430);
        this.heroList1 = uVar1;
        this.winTeam = 0xffffffff;
        ZhSegment.Initialize(this,0);
        this.heroList0 = _heroLise0;
        this.heroList1 = _heroLise1;
    }

}
