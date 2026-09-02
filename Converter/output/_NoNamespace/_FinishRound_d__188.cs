// ============================================================
// Type  : <FinishRound>d__188
// Token : 0x2000161
// ============================================================

public class <FinishRound>d__188
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400093C
    private int <>1__state;

    // Token: 0x400093D
    private object <>2__current;

    // Token: 0x400093E
    public BattleController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000B98
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000B99
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000B9A
    // RVA   : 0xB23400   Offset: 0xB21C00   Length: 0x49E
    private virtual bool MoveNext()
    {
        var pStatics = *(int64*)(DAT_181da1d20 + 184);
        float fVar2;
        int iVar3;
        long lVar4;
        bool cVar5;
        long lVar6;
        long lVar7;
        ulong uVar8;
        uint uVar9;
        uint uVar10;
        uint uVar11;
        float fVar12;
        iVar3 = this.<>1__state;
        lVar7 = this.<>4__this;
        if (iVar3 == 0) {
          this.<>1__state = 0xffffffff;
          if (lVar7 != null) {
            uVar8 = *(uint64 *)(lVar7 + 248);
            GlobalData.DeleteAllNull(uVar8,0);
            BattleController.ManageUnitStaySpeGrid(lVar7,*(uint64 *)(lVar7 + 0x110),0);
            fVar12 = *(float *)(lVar7 + 0x1a8);
            lVar7 = FUN_18046c0a0(0);
            if ((lVar7 != null) && (*(int64 *)(lVar7 + 32) != 0)) {
              fVar2 = *(float *)(*(int64 *)(lVar7 + 32) + 0x1d8);
              uVar8 = new WaitForSeconds(fVar12 / fVar2,0);
              this.<>2__current = uVar8;
              this.<>1__state = 1;
              return true;
            }
          }
        }
        else {
          if (iVar3 != 1) {
            if (iVar3 == 2) {
              this.<>1__state = 0xffffffff;
              return false;
            }
            return false;
          }
          this.<>1__state = 0xffffffff;
          if (lVar7 != null) {
            uVar9 = 0;
            plVar1 = (int64 *)(lVar7 + 0x110);
            lVar6 = *plVar1;
            *(uint32 *)(lVar7 + 0x1a8) = 0;
            cVar5 = Object.op_Inequality(lVar6,0,0);
            if (cVar5) {
              lVar6 = *plVar1;
              if ((lVar6 == null) || (*(int64 *)(lVar6 + 88) == 0)) throw; // [null/range check failed]
              uVar9 = *(uint32 *)(*(int64 *)(lVar6 + 88) + 16);
              BattleUnit.ChangeBattleMove
                        (lVar6,*(uint32 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x228) ^ 0x80000000,1,0,0);
              if ((*plVar1 == 0) || (lVar6 = *(int64 *)(*plVar1 + 64)) == null)
              throw; // [null/range check failed]
              uVar10 = Mathf.Max(0,*(float *)(lVar6 + 0x240) - 0.05,0);
              *(uint32 *)(lVar6 + 0x240) = uVar10;
              if ((*plVar1 == 0) || (lVar6 = *(int64 *)(*plVar1 + 64)) == null)
              throw; // [null/range check failed]
              HeroData.ChangeSkillPower(lVar6,4,0);
              lVar6 = *plVar1;
              if ((lVar6 == null) || (lVar4 = *(int64 *)(lVar6 + 64)) == null) throw; // [null/range check failed]
              if (*(float *)(lVar4 + 0x18c) < *(float *)(lVar4 + 0x184)) {
                fVar12 = *(float *)(lVar4 + 0x184) - *(float *)(lVar4 + 0x18c);
                uVar10 = Mathf.Max(0x40a00000,fVar12 * 0.5,0);
                uVar11 = Mathf.Min(fVar12,uVar10,0);
                BattleUnit.ChangePower(lVar6,uVar11 ^ 0x80000000,0,0);
                lVar6 = *plVar1;
              }
              cVar5 = BattleController.CanPlayerControl(lVar7,lVar6,0);
              if (cVar5) {
                if (((*plVar1 == 0) || (lVar6 = *(int64 *)(*plVar1 + 64)) == null) ||
                   (lVar6 = *(int64 *)(lVar6 + 0x2d0)) == null) throw; // [null/range check failed]
                if (*(uint32 *)(lVar6 + 24) < 6) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                if (*(int *)(*(int64 *)(lVar6 + 16) + 52) == 1) {
                  lVar6 = *plVar1;
                  if (lVar6 == null) throw; // [null/range check failed]
                  if (*(char *)(lVar6 + 176) != false) {
                    BattleUnit.ChangeAutoType(lVar6,0,0);
                  }
                }
              }
              if (*plVar1 == 0) throw; // [null/range check failed]
              BattleUnit.SetHighLightAnim(*plVar1,0,0);
              if ((*plVar1 == 0) || (lVar6 = *(int64 *)(*plVar1 + 64)) == null)
              throw; // [null/range check failed]
              HeroData.SetNowActiveSkill(lVar6,0,0);
              *plVar1 = 0;
              il2cpp_internal(plVar1,0);
            }
            BattleController.SetPauseButtonInteractable(lVar7,1,0);
            if ((*(int64 *)(lVar7 + 0x130) != 0) &&
               (lVar6 = Component.get_gameObject(*(int64 *)(lVar7 + 0x130),0)) != null) {
              GameObject.SetActive(lVar6,0,0);
              if (*pStatics != 0) {
                FightScoreBarController.RefreshFightScoreBar(*pStatics,0,0);
                BattleController.CheckBattleEnd(lVar7,uVar9,0);
                *(uint32 *)(lVar7 + 0x124) = 0;
                this.<>2__current = 0;
                this.<>1__state = 2;
                return true;
              }
            }
          }
        }
    }

    // Token : 0x6000B9B
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000B9C
    // RVA   : 0xB238A0   Offset: 0xB220A0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d6e998);
    }

    // Token : 0x6000B9D
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
