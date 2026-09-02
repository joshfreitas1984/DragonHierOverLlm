// ============================================================
// Type  : <PlayPosture>d__213
// Token : 0x2000165
// ============================================================

public class <PlayPosture>d__213
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400094A
    private int <>1__state;

    // Token: 0x400094B
    private object <>2__current;

    // Token: 0x400094C
    public BattleController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000BB0
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000BB1
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000BB2
    // RVA   : 0xB24D20   Offset: 0xB23520   Length: 0x3A9
    private virtual bool MoveNext()
    {
        float fVar1;
        int iVar2;
        long lVar3;
        long lVar6;
        ulong uVar7;
        long lVar8;
        uint uVar10;
        ulong in_stack_ffffffffffffffa8;
        ulong uVar11;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        uVar10 = (uint32)((uint64)in_stack_ffffffffffffffa8 >> 32);
        iVar2 = this.<>1__state;
        lVar8 = this.<>4__this;
        if (iVar2 != 0) {
          if (iVar2 == 1) {
            this.<>1__state = 0xffffffff;
            if (lVar8 == null) throw; // [null/range check failed]
            *(uint8 *)(lVar8 + 0x128) = 0;
            *(uint8 *)(lVar8 + 0x121) = 1;
            *(uint32 *)(lVar8 + 0x124) = 12;
            this.<>2__current = 0;
            uVar7 = 1;
            this.<>1__state = 2;
          }
          else {
            uVar7 = 0;
            if (iVar2 == 2) {
              this.<>1__state = 0xffffffff;
            }
          }
          return uVar7;
        }
        this.<>1__state = 0xffffffff;
        if (lVar8 != null) {
          lVar6 = *(int64 *)(lVar8 + 0x110);
          *(uint8 *)(lVar8 + 0x128) = 1;
          puVar4 = (uint32 *)Color.get_yellow(&local_28,0);
          if (lVar6 != null) {
            local_28 = *puVar4;
            uStack_24 = puVar4[1];
            uStack_20 = puVar4[2];
            uStack_1c = puVar4[3];
            uVar11 = CONCAT44(uVar10,24);
            BattleUnit.ShowTextOnHead(lVar6,"招架",&local_28,18,uVar11,"UIAtlas",0,0,0);
            lVar6 = *(int64 *)(lVar8 + 0x110);
            plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/Defence",0);
            if (lVar6 != null) {
              plVar9 = (int64 *)0;
              if ((plVar5 != (int64 *)0) && (plVar9 = (int64 *)0, *plVar5 == DAT_181d8a228)) {
                plVar9 = plVar5;
              }
              BattleUnit.PlayHeroSound(lVar6,plVar9,1,0,uVar11 & 0xffffffffffffff00,0);
              if (((*(int64 *)(lVar8 + 0x110) != 0) &&
                  (lVar6 = *(int64 *)(*(int64 *)(lVar8 + 0x110) + 24)) != null) &&
                 (lVar6 = SkeletonAnimation.get_AnimationState(lVar6,0)) != null) {
                AnimationState.SetAnimation(lVar6,1,"defence",0,0);
                if (((*(int64 *)(lVar8 + 0x110) != 0) &&
                    (lVar6 = *(int64 *)(*(int64 *)(lVar8 + 0x110) + 24)) != null) &&
                   (lVar6 = SkeletonAnimation.get_AnimationState(lVar6,0)) != null) {
                  AnimationState.AddEmptyAnimation(lVar6,1,0x3e4ccccd,0,0);
                  lVar6 = *(int64 *)(lVar8 + 0x110);
                  if ((lVar6 != null) && (lVar3 = *(int64 *)(lVar6 + 64)) != null) {
                    if (*(char *)(lVar3 + 16) == false) {
                      uVar10 = KungfuSkillLvData.GetActiveTime(lVar3,0);
                      BattleUnit.ChangePower(lVar6,uVar10,0,0);
                      lVar6 = *(int64 *)(lVar8 + 0x110);
                      if ((lVar6 == null) || (*(int64 *)(lVar6 + 64) == 0)) throw; // [null/range check failed]
                      uVar10 = HeroData.GetPostureCurePostureRate(*(int64 *)(lVar6 + 64),0);
                      BattleUnit.RecoverPartPosture(lVar6,uVar10,0);
                      lVar6 = *(int64 *)(lVar8 + 0x110);
                    }
                    if ((lVar6 != null) && (*(int64 *)(lVar6 + 64) != 0)) {
                      uVar7 = HeroData.Name(*(int64 *)(lVar6 + 64),1,0);
                      uVar7 = String.Format("{0}进行招架。",uVar7,0);
                      BattleController.AddInfoText(lVar8,uVar7,1,0);
                      lVar8 = FUN_18046c0a0(0);
                      if ((lVar8 != null) && (*(int64 *)(lVar8 + 32) != 0)) {
                        fVar1 = *(float *)(*(int64 *)(lVar8 + 32) + 0x1d8);
                        uVar7 = new WaitForSeconds(1.0 / fVar1,0);
                        this.<>2__current = uVar7;
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

    // Token : 0x6000BB3
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000BB4
    // RVA   : 0xB250D0   Offset: 0xB238D0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d6ec98);
    }

    // Token : 0x6000BB5
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
