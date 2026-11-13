// ============================================================
// Type  : <BattleUnitAttackEnd>d__269
// Token : 0x200016F
// ============================================================

public class <BattleUnitAttackEnd>d__269
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40009C8
    private int <>1__state;

    // Token: 0x40009C9
    private object <>2__current;

    // Token: 0x40009CA
    public BattleController <>4__this;

    // Token: 0x40009CB
    public float delayTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000BEC
    // RVA   : 0x608BA0   Offset: 0x6079A0   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000BED
    // RVA   : 0x51CF50   Offset: 0x51BD50   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000BEE
    // RVA   : 0x70D340   Offset: 0x70C140   Length: 0x2EC
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
            lVar5 = FUN_1802106e0(0);
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
                FUN_18115d8f0(*(int64 *)(lVar5 + 0x208),DAT_181e6d2f0);
                *(uint8 *)(lVar5 + 0x128) = 0;
                *(uint8 *)(lVar5 + 0x121) = 1;
                *(uint32 *)(lVar5 + 0x124) = 12;
                lVar3 = FUN_1802106e0(0);
                if ((*(int64 *)(lVar5 + 0x110) != 0) && (lVar3 != null)) {
                  GameController.CountHeroData
                            (lVar3,*(uint64 *)(*(int64 *)(lVar5 + 0x110) + 64),1,0);
                  this.<>2__current = 0;
                  this.<>1__state = 3;
                  return true;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000BEF
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000BF0
    // RVA   : 0x70D630   Offset: 0x70C430   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181e6d8e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181e7ad90);
    }

    // Token : 0x6000BF1
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
