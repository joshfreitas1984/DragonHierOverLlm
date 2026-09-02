// ============================================================
// Type  : <EndFightRound>d__45
// Token : 0x200027C
// ============================================================

public class <EndFightRound>d__45
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001390
    private int <>1__state;

    // Token: 0x4001391
    private object <>2__current;

    // Token: 0x4001392
    public FightMatchController <>4__this;

    // Token: 0x4001393
    public int winTeam;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600143A
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x600143B
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x600143C
    // RVA   : 0x8C9050   Offset: 0x8C7850   Length: 0x9B4
    private virtual bool MoveNext()
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
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
          if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181d8a228)) {
            plVar8 = plVar2;
          }
          NGUITools.PlaySound(plVar8,0);
          if ((lVar1 != null) && (lVar3 = *(int64 *)(lVar1 + 96)) != null) {
            if (*(int *)(lVar3 + 40) != -1) {
        LAB_1808c9937:
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
              plVar2 = (int64 *)Component.GetComponent(lVar3,DAT_181d6bc40);
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
                lVar3 = FUN_18046c0a0(0);
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
                      local_28 = *(uint32 *)(lVar5 + 0x280);
                      uStack_24 = *(uint32 *)(lVar5 + 0x284);
                      uStack_20 = *(uint32 *)(lVar5 + 0x288);
                      uStack_1c = *(uint32 *)(lVar5 + 0x28c);
                      local_38 = uVar7;
                      uStack_30 = uVar9;
                      GameController.ShowTextAtPos(lVar3,"轮空",&local_38,30,&local_28,0);
                      goto LAB_1808c9937;
                    }
                  }
                }
                throw; // [null/range check failed]
              }
              lVar3 = FUN_18046c0a0(0);
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
              local_28 = *(uint32 *)(lVar5 + 0x280);
              uStack_24 = *(uint32 *)(lVar5 + 0x284);
              uStack_20 = *(uint32 *)(lVar5 + 0x288);
              uStack_1c = *(uint32 *)(lVar5 + 0x28c);
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
              plVar2 = (int64 *)Component.GetComponent(lVar3,DAT_181d6bc40);
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
              plVar2 = (int64 *)Component.GetComponent(lVar3,DAT_181d6bc40);
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
              plVar2 = (int64 *)Component.GetComponent(lVar3,DAT_181d6bc40);
              puVar4 = (uint64 *)Color.get_green(&local_28,0);
              if (plVar2 == (int64 *)0) throw; // [null/range check failed]
              local_38 = *puVar4;
              uStack_30 = *(uint32 *)(puVar4 + 1);
              uStack_2c = *(uint32 *)((int64)puVar4 + 12);
              (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_38,*(uint64 *)(*plVar2 + 0x2b0));
              lVar3 = FUN_18046c0a0(0);
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
              local_28 = *(uint32 *)(lVar5 + 0x280);
              uStack_24 = *(uint32 *)(lVar5 + 0x284);
              uStack_20 = *(uint32 *)(lVar5 + 0x288);
              uStack_1c = *(uint32 *)(lVar5 + 0x28c);
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
                FUN_18182ac70(lVar3,0,*(uint64 *)(*(int64 *)(lVar5 + 16) + 32),DAT_181d64078);
                goto LAB_1808c9937;
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
             (lVar3 = GameObject.GetComponent(*(int64 *)(lVar1 + 40),DAT_181d9ee60)) != null) {
            Selectable.set_interactable(lVar3,1,0);
            if (*(int64 *)(lVar1 + 96) != 0) {
              FightMatchController.RefreshNextButton
                        (lVar1,*(int *)(*(int64 *)(lVar1 + 96) + 16) + 1,0);
              return false;
            }
          }
        }
    }

    // Token : 0x600143D
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x600143E
    // RVA   : 0x8C9A10   Offset: 0x8C8210   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d7a808);
    }

    // Token : 0x600143F
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
