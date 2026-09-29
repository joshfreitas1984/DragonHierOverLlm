// ============================================================
// Type  : <NpcInteractTutorial>d__950
// Token : 0x2000325
// ============================================================

public class <NpcInteractTutorial>d__950
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001A32
    private int <>1__state;

    // Token: 0x4001A33
    private object <>2__current;

    // Token: 0x4001A34
    public PlotController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001FC7
    // RVA   : 0x219070   Offset: 0x218470   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6001FC8
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6001FC9
    // RVA   : 0x923300   Offset: 0x922700   Length: 0x3C7
    private virtual bool MoveNext()
    {
        var pStatics = *(int64*)(DAT_181dadd10 + 184);
        bool cVar1;
        int iVar2;
        ulong uVar3;
        long lVar4;
        long lVar5;
        float fVar6;
        uint[] local_res8 = new uint[2];
        lVar5 = this.<>4__this;
        if (this.<>1__state == 0) {
          this.<>1__state = 0xffffffff;
          local_res8[0] = 1;
          uVar3 = il2cpp_value_box(DAT_181d80430,local_res8);
          this.<>2__current = uVar3;
          this.<>1__state = 1;
          return true;
        }
        if (this.<>1__state != 1) {
          return false;
        }
        this.<>1__state = 0xffffffff;
        if (((*pStatics != 0) &&
            (TutorialController.StartTutorial(*pStatics,"角色交互",0),
            lVar5 != null)) && (*(int64 *)(lVar5 + 112) != 0)) {
          fVar6 = (float)HeroData.Favor(*(int64 *)(lVar5 + 112),0,0);
          if (30.0 <= fVar6) {
            if (*pStatics == 0) throw; // [null/range check failed]
            TutorialController.StartTutorial(*pStatics,"索取物品",0);
          }
          if (*(int64 *)(lVar5 + 112) != 0) {
            cVar1 = HeroData.HaveForce(*(int64 *)(lVar5 + 112),0);
            if (!cVar1) {
              lVar4 = *(int64 *)(lVar5 + 112);
              if (lVar4 == null) throw; // [null/range check failed]
              if ((*(char *)(lVar4 + 92) == false) &&
                 (fVar6 = (float)HeroData.Favor(lVar4,0,0), 40.0 <= fVar6)) {
                lVar4 = FUN_18046c720(0);
                if (lVar4 == null) throw; // [null/range check failed]
                TutorialController.StartTutorial(lVar4,"雇佣帮手",0);
              }
            }
            if (*(int64 *)(lVar5 + 112) != 0) {
              fVar6 = (float)HeroData.Favor(*(int64 *)(lVar5 + 112),0,0);
              if (50.0 <= fVar6) {
                if (*pStatics == 0) throw; // [null/range check failed]
                TutorialController.StartTutorial(*pStatics,"学人武功",0);
              }
              if (*(int64 *)(lVar5 + 112) != 0) {
                iVar2 = *(int *)(*(int64 *)(lVar5 + 112) + 184);
                lVar4 = FUN_18046c0a0(0);
                if (((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) &&
                   (lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0)) != null) {
                  if (iVar2 <= *(int *)(lVar4 + 184)) {
                    if (*(int64 *)(lVar5 + 112) == 0) throw; // [null/range check failed]
                    fVar6 = (float)HeroData.Favor(*(int64 *)(lVar5 + 112),0,0);
                    if (*(int64 *)(lVar5 + 112) == 0) throw; // [null/range check failed]
                    iVar2 = HeroData.GetAskJoinTeamNeedFavor(*(int64 *)(lVar5 + 112),0);
                    if ((float)iVar2 <= fVar6) {
                      lVar4 = FUN_18046c720(0);
                      if (lVar4 == null) throw; // [null/range check failed]
                      TutorialController.StartTutorial(lVar4,"邀请入队",0);
                    }
                  }
                  if (*(int64 *)(lVar5 + 112) != 0) {
                    lVar5 = HeroData.GetForceLeader(*(int64 *)(lVar5 + 112),0);
                    lVar4 = FUN_18046c0a0(0);
                    if ((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) {
                      lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0);
                      if (lVar5 == lVar4) {
                        if (*pStatics == 0) throw; // [null/range check failed]
                        TutorialController.StartTutorial
                                  (*pStatics,"门派交互",0);
                      }
                      return false;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001FCA
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6001FCB
    // RVA   : 0x9236D0   Offset: 0x922AD0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d8d528);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181daa360);
    }

    // Token : 0x6001FCC
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
