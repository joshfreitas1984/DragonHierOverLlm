// ============================================================
// Type  : <NpcInteractTutorial>d__957
// Token : 0x200032F
// ============================================================

public class <NpcInteractTutorial>d__957
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001AAC
    private int <>1__state;

    // Token: 0x4001AAD
    private object <>2__current;

    // Token: 0x4001AAE
    public PlotController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002066
    // RVA   : 0x608BA0   Offset: 0x6079A0   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6002067
    // RVA   : 0x51CF50   Offset: 0x51BD50   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6002068
    // RVA   : 0x610990   Offset: 0x60F790   Length: 0x3C7
    private virtual bool MoveNext()
    {
        var pStatics = *(int64*)(DAT_181e8e150 + 184);
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
          uVar3 = il2cpp_value_box(DAT_181e60808,local_res8);
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
                lVar4 = FUN_180210da0(0);
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
                lVar4 = FUN_1802106e0(0);
                if (((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) &&
                   (lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0)) != null) {
                  if (iVar2 <= *(int *)(lVar4 + 184)) {
                    if (*(int64 *)(lVar5 + 112) == 0) throw; // [null/range check failed]
                    fVar6 = (float)HeroData.Favor(*(int64 *)(lVar5 + 112),0,0);
                    if (*(int64 *)(lVar5 + 112) == 0) throw; // [null/range check failed]
                    iVar2 = HeroData.GetAskJoinTeamNeedFavor(*(int64 *)(lVar5 + 112),0);
                    if ((float)iVar2 <= fVar6) {
                      lVar4 = FUN_180210da0(0);
                      if (lVar4 == null) throw; // [null/range check failed]
                      TutorialController.StartTutorial(lVar4,"邀请入队",0);
                    }
                  }
                  if (*(int64 *)(lVar5 + 112) != 0) {
                    lVar5 = HeroData.GetForceLeader(*(int64 *)(lVar5 + 112),0);
                    lVar4 = FUN_1802106e0(0);
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

    // Token : 0x6002069
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x600206A
    // RVA   : 0x610D60   Offset: 0x60FB60   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181e6d8e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181e8dd08);
    }

    // Token : 0x600206B
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
