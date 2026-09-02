// ============================================================
// Type  : <BattleUnitAttackEnd>d__241
// Token : 0x200016E
// ============================================================

public class <BattleUnitAttackEnd>d__241
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400096A
    private int <>1__state;

    // Token: 0x400096B
    private object <>2__current;

    // Token: 0x400096C
    public BattleController <>4__this;

    // Token: 0x400096D
    public float delayTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000BDF
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000BE0
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000BE1
    // RVA   : 0xB1DA50   Offset: 0xB1C250   Length: 0x2E9
    private virtual bool MoveNext()
    {
        float fVar1;
        int iVar2;
        long lVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        uint uVar7;
        iVar2 = this.<>1__state;
        lVar5 = this.<>4__this;
        if (iVar2 == 0) {
          this.<>1__state = 0xffffffff;
          if ((lVar5 != null) && (*(int64 *)(lVar5 + 0x110) != 0)) {
            BattleUnit.SetWeaponTrail(*(int64 *)(lVar5 + 0x110),0,0,0);
            uVar7 = this.delayTime;
            uVar6 = new WaitForSeconds(uVar7,0);
            this.<>2__current = uVar6;
            this.<>1__state = 1;
            return true;
          }
        }
        else if (iVar2 == 1) {
          this.<>1__state = 0xffffffff;
          if ((((lVar5 != null) && (*(int64 *)(lVar5 + 0x110) != 0)) &&
              (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 0x110) + 64)) != null) &&
             (lVar5 = HeroData.GetNowActiveSkill(lVar5,0)) != null) {
            *(int *)(lVar5 + 92) = *(int *)(lVar5 + 92) + 1;
            lVar5 = FUN_18046c0a0(0);
            if ((lVar5 != null) && (*(int64 *)(lVar5 + 32) != 0)) {
              fVar1 = *(float *)(*(int64 *)(lVar5 + 32) + 0x1d8);
              uVar6 = new WaitForSeconds(0.25 / fVar1,0);
              this.<>2__current = uVar6;
              this.<>1__state = 2;
              return true;
            }
          }
        }
        else {
          if (iVar2 != 2) {
            if (iVar2 == 3) {
              this.<>1__state = 0xffffffff;
              return false;
            }
            return false;
          }
          this.<>1__state = 0xffffffff;
          if (((lVar5 != null) && (*(int64 *)(lVar5 + 0x110) != 0)) &&
             (lVar3 = *(int64 *)(*(int64 *)(lVar5 + 0x110) + 64)) != null) {
            lVar3 = HeroData.GetNowActiveSkill(lVar3,0);
            if (((*(int64 *)(lVar5 + 0x110) != 0) &&
                (lVar4 = *(int64 *)(*(int64 *)(lVar5 + 0x110) + 64)) != null) &&
               ((lVar4 = HeroData.GetNowActiveSkill(lVar4,0), lVar4 != null &&
                (uVar7 = KungfuSkillLvData.CDTimeTotal(lVar4,0), lVar3 != null)))) {
              *(uint32 *)(lVar3 + 88) = uVar7;
              BattleController.ResetGridUnitsToNormal(lVar5,*(uint64 *)(lVar5 + 0x208),0);
              if (*(int64 *)(lVar5 + 0x208) != 0) {
                FUN_180f56130(*(int64 *)(lVar5 + 0x208),DAT_181d637f8);
                *(uint8 *)(lVar5 + 0x128) = 0;
                *(uint8 *)(lVar5 + 0x121) = 1;
                *(uint32 *)(lVar5 + 0x124) = 12;
                lVar3 = FUN_18046c0a0(0);
                if ((*(int64 *)(lVar5 + 0x110) != 0) && (lVar3 != null)) {
                  GameController.CountHeroData
                            (lVar3,*(uint64 *)(*(int64 *)(lVar5 + 0x110) + 64),0);
                  this.<>2__current = 0;
                  this.<>1__state = 3;
                  return true;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000BE2
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000BE3
    // RVA   : 0xB1DD40   Offset: 0xB1C540   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d6e698);
    }

    // Token : 0x6000BE4
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
