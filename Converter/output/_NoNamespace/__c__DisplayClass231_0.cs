// ============================================================
// Type  : <>c__DisplayClass231_0
// Token : 0x2000169
// ============================================================

public class <>c__DisplayClass231_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000958
    public GameObject newBullet;

    // Token: 0x4000959
    public GridUnitData targetGrid;

    // Token: 0x400095A
    public BattleController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000BC8
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6000BC9
    // RVA   : 0xB28310   Offset: 0xB26B10   Length: 0x8D
    internal void <BattleUnitAttackHappen>b__2()
    {
        long lVar1;
        ulong uVar2;
        uVar2 = this.newBullet;
        Object.Destroy(uVar2,0);
        lVar1 = this.<>4__this;
        if (lVar1 != null) {
          uVar2 = BattleController.BattleUnitAttackHit(lVar1,this.targetGrid,0,0);
          FUN_180d837c0(lVar1,uVar2,0);
          return;
        }
    }

    // Token : 0x6000BCA
    // RVA   : 0xB28280   Offset: 0xB26A80   Length: 0x8D
    internal void <BattleUnitAttackHappen>b__0()
    {
        long lVar1;
        ulong uVar2;
        uVar2 = this.newBullet;
        Object.Destroy(uVar2,0);
        lVar1 = this.<>4__this;
        if (lVar1 != null) {
          uVar2 = BattleController.BattleUnitAttackHit(lVar1,this.targetGrid,0,0);
          FUN_180d837c0(lVar1,uVar2,0);
          return;
        }
    }

}
