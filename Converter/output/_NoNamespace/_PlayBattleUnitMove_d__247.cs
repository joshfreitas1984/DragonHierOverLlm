// ============================================================
// Type  : <PlayBattleUnitMove>d__247
// Token : 0x200016F
// ============================================================

public class <PlayBattleUnitMove>d__247
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400096E
    private int <>1__state;

    // Token: 0x400096F
    private object <>2__current;

    // Token: 0x4000970
    public BattleController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000BE5
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000BE6
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000BE7
    // RVA   : 0xB24340   Offset: 0xB22B40   Length: 0x4EC
    private virtual bool MoveNext()
    {
        float fVar2;
        float fVar3;
        long lVar4;
        long lVar5;
        int iVar6;
        ulong uVar8;
        long lVar9;
        iVar6 = this.<>1__state;
        lVar4 = this.<>4__this;
        if (iVar6 == 0) {
          this.<>1__state = 0xffffffff;
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4.monthCoachTime = 1;
          if (((lVar4.monthCatchBadFamePlayerTime == null) ||
              (lVar9 = *(int64 *)(lVar4.monthCatchBadFamePlayerTime + 24)) == null) ||
             (lVar9 = SkeletonAnimation.get_AnimationState(lVar9,0)) == null) throw; // [null/range check failed]
          AnimationState.SetAnimation(lVar9,0,"run",1,0);
          if ((lVar4.monthCatchBadFamePlayerTime == null) ||
             (lVar9 = *(int64 *)(lVar4.monthCatchBadFamePlayerTime + 64)) == null) throw; // [null/range check failed]
          if (*(char *)(lVar9 + 16) != false) {
            plVar7 = (int64 *)Resources.Load("Sound/SoundEffect/WoodenSummon",0);
            plVar10 = (int64 *)0;
            if ((plVar7 != (int64 *)0) && (*plVar7 == DAT_181d8a228)) {
              plVar10 = plVar7;
            }
            NGUITools.PlaySound(plVar10,0);
          }
          lVar9 = GameController.difficultyExtraPoint;
          if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 16)) == null) throw; // [null/range check failed]
          iVar6 = PlayerPrefDictionary.GetInt(lVar9,"FightViewFollow",0);
          if (iVar6 == 1) {
            if (lVar4.monthCatchBadFamePlayerTime == null) throw; // [null/range check failed]
            uVar8 = Component.get_gameObject(lVar4.monthCatchBadFamePlayerTime,0);
            lVar4.cheating = uVar8;
          }
          if (lVar4.monthCatchBadFamePlayerTime == null) throw; // [null/range check failed]
          *(uint32 *)(lVar4.monthCatchBadFamePlayerTime + 188) = 0;
        }
        else {
          if (iVar6 != 1) {
            if (iVar6 != 2) {
              return false;
            }
            this.<>1__state = 0xffffffff;
            return false;
          }
          this.<>1__state = 0xffffffff;
          if ((lVar4 == null) || (lVar4.tempTagDataBase == null)) throw; // [null/range check failed]
          FUN_18182b220(lVar4.tempTagDataBase,0,DAT_181d63978);
        }
        lVar9 = lVar4.tempTagDataBase;
        if (lVar9 != null) {
          if (*(int *)(lVar9 + 24) < 1) {
            lVar4.cheating = 0;
            lVar4.monthCoachTime = 0;
            if (((lVar4.monthCatchBadFamePlayerTime != null) &&
                (lVar9 = *(int64 *)(lVar4.monthCatchBadFamePlayerTime + 24)) != null) &&
               (lVar9 = SkeletonAnimation.get_AnimationState(lVar9,0)) != null) {
              AnimationState.SetAnimation(lVar9,0,"idle",1,0);
              lVar4.monthDoctorTime = 1;
              if (lVar4.monthCatchBadFamePlayerTime != null) {
                lVar4.monthPerformForMoneyTime = (*(char *)(lVar4.monthCatchBadFamePlayerTime + 56) != false) + 1;
                this.<>2__current = 0;
                this.<>1__state = 2;
                return true;
              }
            }
          }
          else {
            lVar5 = lVar4.monthCatchBadFamePlayerTime;
            if (*(int *)(lVar9 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar5 != null) {
              BattleUnit.EnterGrid(lVar5,*(uint64 *)(*(int64 *)(lVar9 + 16) + 32),0,0,0);
              if (lVar4.monthCatchBadFamePlayerTime != null) {
                piVar1 = (int *)(lVar4.monthCatchBadFamePlayerTime + 188);
                *piVar1 = *piVar1 + 1;
                if ((lVar4.monthCatchBadFamePlayerTime != null) &&
                   (lVar4 = *(int64 *)(lVar4.monthCatchBadFamePlayerTime + 64)) != null) {
                  HeroData.ChangeSkillPower(lVar4,1,0x3f000000);
                  fVar2 = BattleUnit.UnitMoveOneGridTime;
                  if ((GameController._instance != null) &&
                     (lVar4 = GameController._instance.worldData,
                     lVar4 != null)) {
                    fVar3 = lVar4.battleTimeScale;
                    uVar8 = new WaitForSeconds(fVar2 / fVar3,0);
                    this.<>2__current = uVar8;
                    this.<>1__state = 1;
                    return true;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000BE8
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000BE9
    // RVA   : 0xB24830   Offset: 0xB23030   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d6eb98);
    }

    // Token : 0x6000BEA
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
