// ============================================================
// Type  : <NpcInteractTutorial>d__932
// Token : 0x200031E
// ============================================================

public class <NpcInteractTutorial>d__932
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400193A
    private int <>1__state;

    // Token: 0x400193B
    private object <>2__current;

    // Token: 0x400193C
    public PlotController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001F47
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6001F48
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6001F49
    // RVA   : 0x8CE300   Offset: 0x8CCB00   Length: 0x3B9
    private virtual bool MoveNext()
    {
        var pStatics = *(int64*)(DAT_181d88ad8 + 184);
        int iVar1;
        ulong uVar2;
        long lVar3;
        long lVar4;
        float fVar5;
        uint[] local_res8 = new uint[2];
        lVar4 = this.<>4__this;
        if (this.<>1__state == 0) {
          this.<>1__state = 0xffffffff;
          local_res8[0] = 1;
          uVar2 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
          this.<>2__current = uVar2;
          this.<>1__state = 1;
          return true;
        }
        if (this.<>1__state != 1) {
          return false;
        }
        this.<>1__state = 0xffffffff;
        if (((*pStatics != 0) &&
            (TutorialController.StartTutorial(*pStatics,"角色交互",0),
            lVar4 != null)) && (*(int64 *)(lVar4 + 112) != 0)) {
          fVar5 = (float)HeroData.Favor(*(int64 *)(lVar4 + 112),0,0);
          if (30.0 <= fVar5) {
            if (*pStatics == 0) throw; // [null/range check failed]
            TutorialController.StartTutorial(*pStatics,"索取物品",0);
          }
          lVar3 = *(int64 *)(lVar4 + 112);
          if (lVar3 != null) {
            if (((*(int *)(lVar3 + 132) < 0) && (*(char *)(lVar3 + 92) == false)) &&
               (fVar5 = (float)HeroData.Favor(lVar3,0,0), 40.0 <= fVar5)) {
              lVar3 = FUN_18046c760(0);
              if (lVar3 == null) throw; // [null/range check failed]
              TutorialController.StartTutorial(lVar3,"雇佣帮手",0);
            }
            if (*(int64 *)(lVar4 + 112) != 0) {
              fVar5 = (float)HeroData.Favor(*(int64 *)(lVar4 + 112),0,0);
              if (50.0 <= fVar5) {
                if (*pStatics == 0) throw; // [null/range check failed]
                TutorialController.StartTutorial(*pStatics,"学人武功",0);
              }
              if (*(int64 *)(lVar4 + 112) != 0) {
                iVar1 = *(int *)(*(int64 *)(lVar4 + 112) + 184);
                lVar3 = FUN_18046c0a0(0);
                if (((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
                   (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) != null) {
                  if (iVar1 <= *(int *)(lVar3 + 184)) {
                    if (*(int64 *)(lVar4 + 112) == 0) throw; // [null/range check failed]
                    fVar5 = (float)HeroData.Favor(*(int64 *)(lVar4 + 112),0,0);
                    if (*(int64 *)(lVar4 + 112) == 0) throw; // [null/range check failed]
                    iVar1 = HeroData.GetAskJoinTeamNeedFavor(*(int64 *)(lVar4 + 112),0);
                    if ((float)iVar1 <= fVar5) {
                      lVar3 = FUN_18046c760(0);
                      if (lVar3 == null) throw; // [null/range check failed]
                      TutorialController.StartTutorial(lVar3,"邀请入队",0);
                    }
                  }
                  if (*(int64 *)(lVar4 + 112) != 0) {
                    lVar4 = HeroData.GetForceLeader(*(int64 *)(lVar4 + 112),0);
                    lVar3 = FUN_18046c0a0(0);
                    if ((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) {
                      lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0);
                      if (lVar4 == lVar3) {
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

    // Token : 0x6001F4A
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6001F4B
    // RVA   : 0x8CE6C0   Offset: 0x8CCEC0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d812a8);
    }

    // Token : 0x6001F4C
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
