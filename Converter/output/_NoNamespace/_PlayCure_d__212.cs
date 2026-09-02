// ============================================================
// Type  : <PlayCure>d__212
// Token : 0x2000164
// ============================================================

public class <PlayCure>d__212
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000947
    private int <>1__state;

    // Token: 0x4000948
    private object <>2__current;

    // Token: 0x4000949
    public BattleController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000BAA
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000BAB
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000BAC
    // RVA   : 0xB24870   Offset: 0xB23070   Length: 0x46E
    private virtual bool MoveNext()
    {
        float fVar1;
        int iVar2;
        long lVar3;
        ulong uVar5;
        long lVar6;
        long lVar7;
        float fVar8;
        uint uVar9;
        ulong in_stack_ffffffffffffffa8;
        ulong uVar10;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        uVar9 = (uint32)((uint64)in_stack_ffffffffffffffa8 >> 32);
        iVar2 = this.<>1__state;
        lVar7 = this.<>4__this;
        if (iVar2 == 0) {
          this.<>1__state = 0xffffffff;
          if (lVar7 != null) {
            lVar6 = *(int64 *)(lVar7 + 0x110);
            *(uint8 *)(lVar7 + 0x128) = 1;
            puVar4 = (uint32 *)Color.get_green(&local_28,0);
            if (lVar6 != null) {
              local_28 = *puVar4;
              uStack_24 = puVar4[1];
              uStack_20 = puVar4[2];
              uStack_1c = puVar4[3];
              BattleUnit.ShowTextOnHead
                        (lVar6,"调息",&local_28,18,CONCAT44(uVar9,24),"UIAtlas",0,0,0);
              if (*(int64 *)(lVar7 + 0x110) != 0) {
                BattleController.CreateSpeEffect
                          (lVar7,0,*(uint64 *)(*(int64 *)(lVar7 + 0x110) + 32),"真气",0);
                lVar6 = *(int64 *)(lVar7 + 0x110);
                if ((lVar6 != null) && (*(int64 *)(lVar6 + 64) != 0)) {
                  uVar5 = HeroData.GetHeroRecoverSound(*(int64 *)(lVar6 + 64),0);
                  BattleUnit.PlayHeroSound(lVar6,uVar5,0,1,1,0);
                  if ((*(int64 *)(lVar7 + 0x110) != 0) &&
                     ((lVar6 = *(int64 *)(*(int64 *)(lVar7 + 0x110) + 24), lVar6 != null &&
                      (lVar6 = SkeletonAnimation.get_AnimationState(lVar6,0)) != null))) {
                    AnimationState.SetAnimation(lVar6,1,"cure",0,0);
                    if ((*(int64 *)(lVar7 + 0x110) != 0) &&
                       ((lVar6 = *(int64 *)(*(int64 *)(lVar7 + 0x110) + 24), lVar6 != null &&
                        (lVar6 = SkeletonAnimation.get_AnimationState(lVar6,0)) != null))) {
                      uVar10 = 0;
                      AnimationState.AddEmptyAnimation(lVar6,1,0x3e4ccccd,0,0);
                      lVar6 = *(int64 *)(lVar7 + 0x110);
                      if ((lVar6 != null) && (lVar3 = *(int64 *)(lVar6 + 64)) != null) {
                        if (*(char *)(lVar3 + 16) == false) {
                          *(int *)(lVar3 + 0x238) = *(int *)(lVar3 + 0x238) + 1;
                          lVar6 = *(int64 *)(lVar7 + 0x110);
                          if ((lVar6 == null) || (lVar3 = *(int64 *)(lVar6 + 64)) == null)
                          throw; // [null/range check failed]
                          fVar1 = *(float *)(lVar3 + 0x17c);
                          fVar8 = (float)HeroData.GetRestCurePostureRate(lVar3,0);
                          BattleUnit.ChangeHp(lVar6,fVar8 * fVar1,0,1,uVar10 & 0xffffffffffffff00,0);
                          lVar6 = *(int64 *)(lVar7 + 0x110);
                          if ((lVar6 == null) || (lVar3 = *(int64 *)(lVar6 + 64)) == null)
                          throw; // [null/range check failed]
                          fVar1 = *(float *)(lVar3 + 0x194);
                          fVar8 = (float)HeroData.GetRestCurePostureRate(lVar3,0);
                          fVar8 = fVar8 * fVar1;
                          BattleUnit.ChangeMana(lVar6,fVar8 + fVar8,0,1,0);
                          lVar6 = *(int64 *)(lVar7 + 0x110);
                          if ((lVar6 == null) || (*(int64 *)(lVar6 + 64) == 0)) throw; // [null/range check failed]
                          uVar9 = HeroData.GetSelfCurePower(*(int64 *)(lVar6 + 64),0);
                          BattleUnit.ChangePower(lVar6,uVar9,0,0);
                          lVar6 = *(int64 *)(lVar7 + 0x110);
                          if ((lVar6 == null) || (*(int64 *)(lVar6 + 64) == 0)) throw; // [null/range check failed]
                          uVar9 = HeroData.GetSelfCurePostureRate(*(int64 *)(lVar6 + 64),0);
                          BattleUnit.RecoverPartPosture(lVar6,uVar9,0);
                          lVar6 = *(int64 *)(lVar7 + 0x110);
                        }
                        if ((lVar6 != null) && (*(int64 *)(lVar6 + 64) != 0)) {
                          uVar5 = HeroData.Name(*(int64 *)(lVar6 + 64),1,0);
                          uVar5 = String.Format("{0}进行调息。",uVar5,0);
                          BattleController.AddInfoText(lVar7,uVar5,1,0);
                          lVar7 = FUN_18046c0a0(0);
                          if ((lVar7 != null) && (*(int64 *)(lVar7 + 32) != 0)) {
                            fVar1 = *(float *)(*(int64 *)(lVar7 + 32) + 0x1d8);
                            uVar5 = new WaitForSeconds(1.0 / fVar1,0);
                            this.<>2__current = uVar5;
                            this.<>1__state = 1;
                            return true;
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
        else {
          if (iVar2 != 1) {
            if (iVar2 == 2) {
              this.<>1__state = 0xffffffff;
              return false;
            }
            return false;
          }
          this.<>1__state = 0xffffffff;
          if (lVar7 != null) {
            *(uint8 *)(lVar7 + 0x128) = 0;
            *(uint8 *)(lVar7 + 0x121) = 1;
            *(uint32 *)(lVar7 + 0x124) = 12;
            this.<>2__current = 0;
            this.<>1__state = 2;
            return true;
          }
        }
    }

    // Token : 0x6000BAD
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000BAE
    // RVA   : 0xB24CE0   Offset: 0xB234E0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d6ec18);
    }

    // Token : 0x6000BAF
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
