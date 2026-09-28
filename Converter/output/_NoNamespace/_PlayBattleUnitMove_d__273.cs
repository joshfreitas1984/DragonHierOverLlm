// ============================================================
// Type  : <PlayBattleUnitMove>d__273
// Token : 0x2000174
// ============================================================

public class <PlayBattleUnitMove>d__273
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40009E9
    private int <>1__state;

    // Token: 0x40009EA
    private object <>2__current;

    // Token: 0x40009EB
    public BattleController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000C0F
    // RVA   : 0x219070   Offset: 0x218470   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000C10
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000C11
    // RVA   : 0x930EF0   Offset: 0x9302F0   Length: 0x4EC
    private virtual bool MoveNext()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
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
          *(uint8 *)(lVar4 + 0x128) = 1;
          if (((*(int64 *)(lVar4 + 0x110) == 0) ||
              (lVar9 = *(int64 *)(*(int64 *)(lVar4 + 0x110) + 24)) == null) ||
             (lVar9 = SkeletonAnimation.get_AnimationState(lVar9,0)) == null) throw; // [null/range check failed]
          AnimationState.SetAnimation(lVar9,0,"run",1,0);
          if ((*(int64 *)(lVar4 + 0x110) == 0) ||
             (lVar9 = *(int64 *)(*(int64 *)(lVar4 + 0x110) + 64)) == null) throw; // [null/range check failed]
          if (*(char *)(lVar9 + 16) != false) {
            plVar7 = (int64 *)Resources.Load("Sound/SoundEffect/WoodenSummon",0);
            plVar10 = (int64 *)0;
            if ((plVar7 != (int64 *)0) && (*plVar7 == DAT_181daf348)) {
              plVar10 = plVar7;
            }
            NGUITools.PlaySound(plVar10,0);
          }
          lVar9 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 8);
          if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 16)) == null) throw; // [null/range check failed]
          iVar6 = PlayerPrefDictionary.GetInt(lVar9,"FightViewFollow",0);
          if (iVar6 == 1) {
            if (*(int64 *)(lVar4 + 0x110) == 0) throw; // [null/range check failed]
            uVar8 = Component.get_gameObject(*(int64 *)(lVar4 + 0x110),0);
            *(uint64 *)(lVar4 + 152) = uVar8;
          }
          if (*(int64 *)(lVar4 + 0x110) == 0) throw; // [null/range check failed]
          *(uint32 *)(*(int64 *)(lVar4 + 0x110) + 188) = 0;
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
          if ((lVar4 == null) || (*(int64 *)(lVar4 + 0x1e0) == 0)) throw; // [null/range check failed]
          FUN_181823590(*(int64 *)(lVar4 + 0x1e0),0,DAT_181d8b118);
        }
        lVar9 = *(int64 *)(lVar4 + 0x1e0);
        if (lVar9 != null) {
          if (*(int *)(lVar9 + 24) < 1) {
            *(uint64 *)(lVar4 + 152) = 0;
            *(uint8 *)(lVar4 + 0x128) = 0;
            if (((*(int64 *)(lVar4 + 0x110) != 0) &&
                (lVar9 = *(int64 *)(*(int64 *)(lVar4 + 0x110) + 24)) != null) &&
               (lVar9 = SkeletonAnimation.get_AnimationState(lVar9,0)) != null) {
              AnimationState.SetAnimation(lVar9,0,"idle",1,0);
              *(uint8 *)(lVar4 + 0x120) = 1;
              if (*(int64 *)(lVar4 + 0x110) != 0) {
                *(uint32 *)(lVar4 + 0x124) = (*(char *)(*(int64 *)(lVar4 + 0x110) + 56) != false) + 1;
                this.<>2__current = 0;
                this.<>1__state = 2;
                return true;
              }
            }
          }
          else {
            lVar5 = *(int64 *)(lVar4 + 0x110);
            if (*(int *)(lVar9 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar5 != null) {
              BattleUnit.EnterGrid(lVar5,*(uint64 *)(*(int64 *)(lVar9 + 16) + 32),0,0,0);
              if (*(int64 *)(lVar4 + 0x110) != 0) {
                piVar1 = (int *)(*(int64 *)(lVar4 + 0x110) + 188);
                *piVar1 = *piVar1 + 1;
                if ((*(int64 *)(lVar4 + 0x110) != 0) &&
                   (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 0x110) + 64)) != null) {
                  HeroData.ChangeSkillPower(lVar4,1,0x3f000000);
                  fVar2 = *(float *)(*(int64 *)(DAT_181db07c8 + 184) + 24);
                  if ((*pStatics != 0) &&
                     (lVar4 = *(int64 *)(*pStatics + 32)) != null) {
                    fVar3 = *(float *)(lVar4 + 0x1d8);
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

    // Token : 0x6000C12
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000C13
    // RVA   : 0x9313E0   Offset: 0x9307E0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d8d510);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d97a38);
    }

    // Token : 0x6000C14
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
