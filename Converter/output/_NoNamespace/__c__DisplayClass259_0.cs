// ============================================================
// Type  : <>c__DisplayClass259_0
// Token : 0x200016A
// ============================================================

public class <>c__DisplayClass259_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40009B6
    public GameObject newBullet;

    // Token: 0x40009B7
    public GridUnitData targetGrid;

    // Token: 0x40009B8
    public BattleController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000BD5
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6000BD6
    // RVA   : 0x711960   Offset: 0x710760   Length: 0x8D
    internal void <BattleUnitAttackHappen>b__2()
    {
        long lVar1;
        ulong uVar2;
        uVar2 = this.newBullet;
        Object.Destroy(uVar2,0);
        lVar1 = this.<>4__this;
        if (lVar1 != null) {
          uVar2 = BattleController.BattleUnitAttackHit(lVar1,this.targetGrid,0,0);
          FUN_180ae80b0(lVar1,uVar2,0);
          return;
        }
    }

    // Token : 0x6000BD7
    // RVA   : 0x7118D0   Offset: 0x7106D0   Length: 0x8D
    internal void <BattleUnitAttackHappen>b__0()
    {
        long lVar1;
        ulong uVar2;
        uVar2 = this.newBullet;
        Object.Destroy(uVar2,0);
        lVar1 = this.<>4__this;
        if (lVar1 != null) {
          uVar2 = BattleController.BattleUnitAttackHit(lVar1,this.targetGrid,0,0);
          FUN_180ae80b0(lVar1,uVar2,0);
          return;
        }
    }

}
