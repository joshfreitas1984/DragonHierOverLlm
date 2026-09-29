// ============================================================
// Type  : <>c__DisplayClass257_0
// Token : 0x200016E
// ============================================================

public class <>c__DisplayClass257_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40009D3
    public GameObject newBullet;

    // Token: 0x40009D4
    public GridUnitData targetGrid;

    // Token: 0x40009D5
    public BattleController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000BF2
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6000BF3
    // RVA   : 0x9C6E70   Offset: 0x9C6270   Length: 0x8D
    internal void <BattleUnitAttackHappen>b__2()
    {
        long lVar1;
        ulong uVar2;
        uVar2 = this.newBullet;
        Object.Destroy(uVar2,0);
        lVar1 = this.<>4__this;
        if (lVar1 != null) {
          uVar2 = BattleController.BattleUnitAttackHit(lVar1,this.targetGrid,0,0);
          FUN_180d8c8f0(lVar1,uVar2,0);
          return;
        }
    }

    // Token : 0x6000BF4
    // RVA   : 0x9C6DE0   Offset: 0x9C61E0   Length: 0x8D
    internal void <BattleUnitAttackHappen>b__0()
    {
        long lVar1;
        ulong uVar2;
        uVar2 = this.newBullet;
        Object.Destroy(uVar2,0);
        lVar1 = this.<>4__this;
        if (lVar1 != null) {
          uVar2 = BattleController.BattleUnitAttackHit(lVar1,this.targetGrid,0,0);
          FUN_180d8c8f0(lVar1,uVar2,0);
          return;
        }
    }

}
