// ============================================================
// Type  : <EndFightRound>d__45
// Token : 0x2000289
// ============================================================

public class <EndFightRound>d__45
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400147F
    private int <>1__state;

    // Token: 0x4001480
    private object <>2__current;

    // Token: 0x4001481
    public FightMatchController <>4__this;

    // Token: 0x4001482
    public int winTeam;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60014E6
    // RVA   : 0x608BA0   Offset: 0x6079A0   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x60014E7
    // RVA   : 0x51CF50   Offset: 0x51BD50   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x60014E8
    // RVA   : 0x6747A0   Offset: 0x6735A0   Length: 0x9B4
    private virtual bool MoveNext()
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        long lVar1;
        long lVar3;
        long lVar5;
        ulong uVar7;
        uint uVar9;
        ulong local_38;
        uint uStack_30;
        uint32 uStack_2c;
        uint32 local_28;
        uint32 uStack_24;
        uint32 uStack_20;
        uint32 uStack_1c;
        lVar1 = this.<>4__this;
        if (this.<>1__state == 0) {
          this.<>1__state = 0xffffffff;
          plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/NoticeLittle",0);
          plVar8 = (int64 *)0;
          if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181e8f4a0)) {
            plVar8 = plVar2;
          }
          NGUITools.PlaySound(plVar8,0);
          if ((lVar1 != null) && (lVar3 = *(int64 *)(lVar1 + 96)) != null) {
            if (*(int *)(lVar3 + 40) != -1) {
        LAB_180675087:
              if (*(char *)(lVar1 + 136) == false) {
                uVar9 = 0x3f000000;
              }
              else {
                uVar9 = 0x3e800000;
              }
              uVar7 = new WaitForSecondsRealtime(uVar9,0);
              this.<>2__current = uVar7;
              this.<>1__state = 1;
              return true;
            }
            *(uint32 *)(lVar3 + 40) = this.winTeam;
            if (*(int64 *)(lVar1 + 96) == 0) throw; // [null/range check failed]
            lVar3 = *(int64 *)(lVar1 + 32);
            if (*(int *)(*(int64 *)(lVar1 + 96) + 40) == 0) {
              if ((lVar3 == null) || (lVar3 = GameObject.get_transform(lVar3,0)) == null)
              throw; // [null/range check failed]
              lVar3 = Transform.Find(lVar3,"FightCoupleGrid",0);
              if ((*(int64 *)(lVar1 + 96) == 0) ||
                 ((((lVar3 == null ||
                    (lVar3 = Transform.GetChild(lVar3,*(uint32 *)(*(int64 *)(lVar1 + 96) + 16)
                                                 ,0), lVar3 == null)) ||
                   (lVar3 = Transform.Find(lVar3,"LeftHeroPos",0)) == null) ||
                  (lVar3 = Transform.GetChild(lVar3,0,0)) == null))) throw; // [null/range check failed]
              plVar2 = (int64 *)Component.GetComponent(lVar3,DAT_181e777b8);
              puVar6 = (uint32 *)Color.get_green(&local_28,0);
              if (plVar2 == (int64 *)0) throw; // [null/range check failed]
              local_28 = *puVar6;
              uStack_24 = puVar6[1];
              uStack_20 = puVar6[2];
              uStack_1c = puVar6[3];
              (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_28,*(uint64 *)(*plVar2 + 0x2b0));
              if ((*(int64 *)(lVar1 + 96) == 0) ||
                 (lVar3 = *(int64 *)(*(int64 *)(lVar1 + 96) + 32)) == null)
              throw; // [null/range check failed]
              if (*(int *)(lVar3 + 24) < 1) {
                lVar3 = FUN_1802106e0(0);
                if ((*(int64 *)(lVar1 + 32) != 0) &&
                   (lVar5 = GameObject.get_transform(*(int64 *)(lVar1 + 32),0)) != null) {
                  lVar5 = Transform.Find(lVar5,"FightCoupleGrid",0);
                  if ((*(int64 *)(lVar1 + 96) != 0) &&
                     (((lVar5 != null &&
                       (lVar5 = Transform.GetChild(lVar5,*(uint32 *)
                                                           (*(int64 *)(lVar1 + 96) + 16),0),
                       lVar5 != null)) && (lVar5 = Transform.Find(lVar5,"LeftHeroPos",0)) != null))) {
                    puVar4 = (uint64 *)Transform.get_position(&local_38,lVar5,0);
                    uVar7 = *puVar4;
                    uVar9 = *(uint32 *)(puVar4 + 1);
                    lVar5 = pStatics;
                    if (lVar3 != null) {
                      local_28 = *(uint32 *)(lVar5 + 0x290);
                      uStack_24 = *(uint32 *)(lVar5 + 0x294);
                      uStack_20 = *(uint32 *)(lVar5 + 0x298);
                      uStack_1c = *(uint32 *)(lVar5 + 0x29c);
                      local_38 = uVar7;
                      uStack_30 = uVar9;
                      GameController.ShowTextAtPos(lVar3,"轮空",&local_38,30,&local_28,0);
                      goto LAB_180675087;
                    }
                  }
                }
                throw; // [null/range check failed]
              }
              lVar3 = FUN_1802106e0(0);
              if ((*(int64 *)(lVar1 + 32) == 0) ||
                 (lVar5 = GameObject.get_transform(*(int64 *)(lVar1 + 32),0)) == null)
              throw; // [null/range check failed]
              lVar5 = Transform.Find(lVar5,"FightCoupleGrid",0);
              if ((*(int64 *)(lVar1 + 96) == 0) ||
                 (((lVar5 == null ||
                   (lVar5 = Transform.GetChild(lVar5,*(uint32 *)(*(int64 *)(lVar1 + 96) + 16),
                                                0), lVar5 == null)) ||
                  (lVar5 = Transform.Find(lVar5,"LeftHeroPos",0)) == null))) throw; // [null/range check failed]
              puVar4 = (uint64 *)Transform.get_position(&local_38,lVar5,0);
              uVar7 = *puVar4;
              uVar9 = *(uint32 *)(puVar4 + 1);
              lVar5 = pStatics;
              if (lVar3 == null) throw; // [null/range check failed]
              local_28 = *(uint32 *)(lVar5 + 0x290);
              uStack_24 = *(uint32 *)(lVar5 + 0x294);
              uStack_20 = *(uint32 *)(lVar5 + 0x298);
              uStack_1c = *(uint32 *)(lVar5 + 0x29c);
              local_38 = uVar7;
              uStack_30 = uVar9;
              GameController.ShowTextAtPos(lVar3,"胜",&local_38,30,&local_28,0);
              if ((*(int64 *)(lVar1 + 32) == 0) ||
                 (lVar3 = GameObject.get_transform(*(int64 *)(lVar1 + 32),0)) == null)
              throw; // [null/range check failed]
              lVar3 = Transform.Find(lVar3,"FightCoupleGrid",0);
              if ((*(int64 *)(lVar1 + 96) == 0) ||
                 ((((lVar3 == null ||
                    (lVar3 = Transform.GetChild(lVar3,*(uint32 *)(*(int64 *)(lVar1 + 96) + 16)
                                                 ,0), lVar3 == null)) ||
                   (lVar3 = Transform.Find(lVar3,"RightHeroPos",0)) == null) ||
                  (lVar3 = Transform.GetChild(lVar3,0,0)) == null))) throw; // [null/range check failed]
              plVar2 = (int64 *)Component.GetComponent(lVar3,DAT_181e777b8);
              puVar6 = (uint32 *)Color.get_red(&local_28,0);
              if (plVar2 == (int64 *)0) throw; // [null/range check failed]
              local_28 = *puVar6;
              uStack_24 = puVar6[1];
              uStack_20 = puVar6[2];
              uStack_1c = puVar6[3];
              (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_28,*(uint64 *)(*plVar2 + 0x2b0));
              lVar3 = *(int64 *)(lVar1 + 80);
              if (*(int64 *)(lVar1 + 96) == 0) throw; // [null/range check failed]
              lVar5 = *(int64 *)(*(int64 *)(lVar1 + 96) + 32);
            }
            else {
              if ((lVar3 == null) || (lVar3 = GameObject.get_transform(lVar3,0)) == null)
              throw; // [null/range check failed]
              lVar3 = Transform.Find(lVar3,"FightCoupleGrid",0);
              if ((((*(int64 *)(lVar1 + 96) == 0) ||
                   ((lVar3 == null ||
                    (lVar3 = Transform.GetChild(lVar3,*(uint32 *)(*(int64 *)(lVar1 + 96) + 16)
                                                 ,0), lVar3 == null)))) ||
                  (lVar3 = Transform.Find(lVar3,"LeftHeroPos",0)) == null) ||
                 (lVar3 = Transform.GetChild(lVar3,0,0)) == null) throw; // [null/range check failed]
              plVar2 = (int64 *)Component.GetComponent(lVar3,DAT_181e777b8);
              puVar4 = (uint64 *)Color.get_red(&local_28,0);
              if (plVar2 == (int64 *)0) throw; // [null/range check failed]
              local_38 = *puVar4;
              uStack_30 = *(uint32 *)(puVar4 + 1);
              uStack_2c = *(uint32 *)((int64)puVar4 + 12);
              (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_38,*(uint64 *)(*plVar2 + 0x2b0));
              if ((*(int64 *)(lVar1 + 32) == 0) ||
                 (lVar3 = GameObject.get_transform(*(int64 *)(lVar1 + 32),0)) == null)
              throw; // [null/range check failed]
              lVar3 = Transform.Find(lVar3,"FightCoupleGrid",0);
              if (((*(int64 *)(lVar1 + 96) == 0) ||
                  (((lVar3 == null ||
                    (lVar3 = Transform.GetChild(lVar3,*(uint32 *)(*(int64 *)(lVar1 + 96) + 16)
                                                 ,0), lVar3 == null)) ||
                   (lVar3 = Transform.Find(lVar3,"RightHeroPos",0)) == null))) ||
                 (lVar3 = Transform.GetChild(lVar3,0,0)) == null) throw; // [null/range check failed]
              plVar2 = (int64 *)Component.GetComponent(lVar3,DAT_181e777b8);
              puVar4 = (uint64 *)Color.get_green(&local_28,0);
              if (plVar2 == (int64 *)0) throw; // [null/range check failed]
              local_38 = *puVar4;
              uStack_30 = *(uint32 *)(puVar4 + 1);
              uStack_2c = *(uint32 *)((int64)puVar4 + 12);
              (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_38,*(uint64 *)(*plVar2 + 0x2b0));
              lVar3 = FUN_1802106e0(0);
              if ((*(int64 *)(lVar1 + 32) == 0) ||
                 (lVar5 = GameObject.get_transform(*(int64 *)(lVar1 + 32),0)) == null)
              throw; // [null/range check failed]
              lVar5 = Transform.Find(lVar5,"FightCoupleGrid",0);
              if ((*(int64 *)(lVar1 + 96) == 0) ||
                 (((lVar5 == null ||
                   (lVar5 = Transform.GetChild(lVar5,*(uint32 *)(*(int64 *)(lVar1 + 96) + 16),
                                                0), lVar5 == null)) ||
                  (lVar5 = Transform.Find(lVar5,"RightHeroPos",0)) == null))) throw; // [null/range check failed]
              puVar4 = (uint64 *)Transform.get_position(&local_38,lVar5,0);
              uVar7 = *puVar4;
              uVar9 = *(uint32 *)(puVar4 + 1);
              lVar5 = pStatics;
              if (lVar3 == null) throw; // [null/range check failed]
              local_28 = *(uint32 *)(lVar5 + 0x290);
              uStack_24 = *(uint32 *)(lVar5 + 0x294);
              uStack_20 = *(uint32 *)(lVar5 + 0x298);
              uStack_1c = *(uint32 *)(lVar5 + 0x29c);
              local_38 = uVar7;
              uStack_30 = uVar9;
              GameController.ShowTextAtPos(lVar3,"胜",&local_38,30,&local_28,0);
              lVar3 = *(int64 *)(lVar1 + 80);
              if (*(int64 *)(lVar1 + 96) == 0) throw; // [null/range check failed]
              lVar5 = *(int64 *)(*(int64 *)(lVar1 + 96) + 24);
            }
            if (lVar5 != null) {
              if (*(int *)(lVar5 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (lVar3 != null) {
                FUN_181762320(lVar3,0,*(uint64 *)(*(int64 *)(lVar5 + 16) + 32),DAT_181e6da70);
                goto LAB_180675087;
              }
            }
          }
        }
        else {
          if (this.<>1__state != 1) {
            return false;
          }
          this.<>1__state = 0xffffffff;
          if (((lVar1 != null) && (*(int64 *)(lVar1 + 40) != 0)) &&
             (lVar3 = GameObject.GetComponent(*(int64 *)(lVar1 + 40),DAT_181e53cb0)) != null) {
            Selectable.set_interactable(lVar3,1,0);
            if (*(int64 *)(lVar1 + 96) != 0) {
              FightMatchController.RefreshNextButton
                        (lVar1,*(int *)(*(int64 *)(lVar1 + 96) + 16) + 1,0);
              return false;
            }
          }
        }
    }

    // Token : 0x60014E9
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x60014EA
    // RVA   : 0x675160   Offset: 0x673F60   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181e6d8e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181e86f20);
    }

    // Token : 0x60014EB
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
