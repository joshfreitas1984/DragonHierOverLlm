// ============================================================
// Type  : <PlayBattleUnitMove>d__275
// Token : 0x2000170
// ============================================================

public class <PlayBattleUnitMove>d__275
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40009CC
    private int <>1__state;

    // Token: 0x40009CD
    private object <>2__current;

    // Token: 0x40009CE
    public BattleController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000BF2
    // RVA   : 0x608BA0   Offset: 0x6079A0   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000BF3
    // RVA   : 0x51CF50   Offset: 0x51BD50   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000BF4
    // RVA   : 0x676E40   Offset: 0x675C40   Length: 0x4EC
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
            if ((plVar7 != (int64 *)0) && (*plVar7 == DAT_181e8f4a0)) {
              plVar10 = plVar7;
            }
            NGUITools.PlaySound(plVar10,0);
          }
          lVar9 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 8);
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
          FUN_181763390(lVar4.tempTagDataBase,0,DAT_181e6d470);
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
                  fVar2 = *(float *)(*(int64 *)(DAT_181e90a20 + 184) + 24);
                  if ((GameController._instance != null) &&
                     (lVar4 = GameController._instance.worldData) != null) {
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

    // Token : 0x6000BF5
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000BF6
    // RVA   : 0x677330   Offset: 0x676130   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181e6d8e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181e7b290);
    }

    // Token : 0x6000BF7
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
