// ============================================================
// Type  : <StartFightMatch>d__37
// Token : 0x200027B
// ============================================================

public class <StartFightMatch>d__37
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400138C
    private int <>1__state;

    // Token: 0x400138D
    private object <>2__current;

    // Token: 0x400138E
    public FightMatchController <>4__this;

    // Token: 0x400138F
    public List<HeroData> heroList;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001434
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6001435
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6001436
    // RVA   : 0x8D0CD0   Offset: 0x8CF4D0   Length: 0x8B6
    private virtual bool MoveNext()
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        ulong uVar5;
        long lVar6;
        long lVar7;
        long lVar8;
        long lVar9;
        long lVar10;
        int iVar12;
        int iVar13;
        lVar10 = this.<>4__this;
        if (this.<>1__state == 0) {
          this.<>1__state = 0xffffffff;
          if ((lVar10 != null) && (*(int64 *)(lVar10 + 32) != 0)) {
            GameObject.SetActive(*(int64 *)(lVar10 + 32),1,0);
            plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/开场锣",0);
            plVar11 = (int64 *)0;
            if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
              plVar11 = plVar4;
            }
            NGUITools.PlaySound(plVar11,0);
            if (*(int64 *)(lVar10 + 72) == 0) {
              uVar5 = il2cpp_internal(DAT_181d6df30);
              FUN_180f58a90(uVar5,DAT_181d604f8);
              *(uint64 *)(lVar10 + 72) = uVar5;
            }
            else {
              FUN_180f56130(*(int64 *)(lVar10 + 72),DAT_181d605f8);
            }
            if (((*(int64 *)(lVar10 + 32) != 0) &&
                (lVar6 = GameObject.get_transform(*(int64 *)(lVar10 + 32),0)) != null) &&
               (lVar6 = Transform.Find(lVar6,"FightCoupleGrid",0)) != null) {
              uVar5 = Component.get_gameObject(lVar6,0);
              GlobalData.DeleteAllChild(uVar5,0);
              lVar6 = this.heroList;
              if (lVar6 != null) {
                while( true ) {
                  if (lVar6.Count < 1) {
                    FightMatchController.RegenerateFightMatchCouples(lVar10,0);
                    FightMatchController.RefreshNextButton(lVar10,0,0);
                    uVar5 = new WaitForSecondsRealtime(0x3f000000,0);
                    this.<>2__current = uVar5;
                    this.<>1__state = 1;
                    return true;
                  }
                  lVar6 = new FightMatchCouple(0);
                  if (this.heroList == null) break;
                  uVar1 = FUN_180d8cf10(0,this.heroList.Count,0);
                  if (lVar6 == null) break;
                  lVar7 = this.heroList;
                  lVar8 = lVar6.Count;
                  if (lVar7 == null) break;
                  if (lVar7.Count <= uVar1) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  if (lVar8 == null) break;
                  FUN_181827900(lVar8,*(uint64 *)
                                       (lVar7._items + 32 + (int64)(int)uVar1 * 8),
                                DAT_181d63d78);
                  if (*(char *)(lVar10 + 121) != false) {
                    iVar12 = 0;
                    while( true ) {
                      lVar7 = *(int64 *)(lVar10 + 128);
                      if (lVar7 == null) goto LAB_1808d1581;
                      if (lVar7.Count <= iVar12) break;
                      lVar7 = FUN_180002f80(lVar7,iVar12,DAT_181d51688);
                      if (lVar7 == null) goto LAB_1808d1581;
                      if (lVar7.Count == null) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      iVar13 = *(int *)(lVar7._items + 32);
                      if ((this.heroList == null) ||
                         (lVar7 = FUN_180002f80(this.heroList,uVar1,DAT_181d643f8),
                         lVar7 == null)) goto LAB_1808d1581;
                      if (iVar13 == *(int *)(lVar7 + 88)) {
                        iVar13 = 1;
                        while( true ) {
                          if ((*(int64 *)(lVar10 + 128) == 0) ||
                             (lVar7 = FUN_180002f80(*(int64 *)(lVar10 + 128),iVar12,DAT_181d51688),
                             lVar7 == null)) goto LAB_1808d1581;
                          if (lVar7.Count <= iVar13) break;
                          lVar7 = FUN_18046c0a0(0);
                          if (lVar7 == null) goto LAB_1808d1581;
                          lVar7 = *(int64 *)(lVar7 + 32);
                          if (((*(int64 *)(lVar10 + 128) == 0) ||
                              (lVar8 = FUN_180002f80(*(int64 *)(lVar10 + 128),iVar12,DAT_181d51688),
                              lVar8 == null)) ||
                             (uVar2 = FUN_1800d6750(lVar8,iVar13,DAT_181d68270), lVar7 == null))
                          goto LAB_1808d1581;
                          lVar7 = WorldData.GetHero(lVar7,uVar2,0);
                          if (lVar7 != null) {
                            lVar7 = lVar6.Count;
                            lVar8 = FUN_18046c0a0(0);
                            if (lVar8 == null) goto LAB_1808d1581;
                            lVar8 = *(int64 *)(lVar8 + 32);
                            if (((*(int64 *)(lVar10 + 128) == 0) ||
                                (lVar9 = FUN_180002f80(*(int64 *)(lVar10 + 128),iVar12,DAT_181d51688),
                                lVar9 == null)) ||
                               ((uVar2 = FUN_1800d6750(lVar9,iVar13,DAT_181d68270), lVar8 == null ||
                                (uVar5 = WorldData.GetHero(lVar8,uVar2,0), lVar7 == null))))
                            goto LAB_1808d1581;
                            FUN_181827900(lVar7,uVar5,DAT_181d63d78);
                          }
                          iVar13 = iVar13 + 1;
                        }
                      }
                      iVar12 = iVar12 + 1;
                    }
                  }
                  if (this.heroList == null) break;
                  FUN_18182b220(this.heroList,uVar1,DAT_181d641f8);
                  if (this.heroList == null) break;
                  iVar12 = this.heroList.Count;
                  if (0 < iVar12) {
                    uVar2 = FUN_180d8cf10(0,iVar12,0);
                    lVar7 = *(int64 *)(lVar6 + 32);
                    if ((this.heroList == null) ||
                       (uVar5 = FUN_180002f80(this.heroList,uVar2,DAT_181d643f8),
                       lVar7 == null)) break;
                    FUN_181827900(lVar7,uVar5,DAT_181d63d78);
                    if (*(char *)(lVar10 + 121) != false) {
                      iVar12 = 0;
                      while( true ) {
                        lVar7 = *(int64 *)(lVar10 + 128);
                        if (lVar7 == null) goto LAB_1808d1581;
                        if (lVar7.Count <= iVar12) break;
                        lVar7 = FUN_180002f80(lVar7,iVar12,DAT_181d51688);
                        if (lVar7 == null) goto LAB_1808d1581;
                        if (lVar7.Count == null) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        iVar13 = *(int *)(lVar7._items + 32);
                        if ((this.heroList == null) ||
                           (lVar7 = FUN_180002f80(this.heroList,uVar2,DAT_181d643f8),
                           lVar7 == null)) goto LAB_1808d1581;
                        if (iVar13 == *(int *)(lVar7 + 88)) {
                          iVar13 = 1;
                          while( true ) {
                            if ((*(int64 *)(lVar10 + 128) == 0) ||
                               (lVar7 = FUN_180002f80(*(int64 *)(lVar10 + 128),iVar12,DAT_181d51688),
                               lVar7 == null)) goto LAB_1808d1581;
                            if (lVar7.Count <= iVar13) break;
                            lVar7 = FUN_18046c0a0(0);
                            if (lVar7 == null) goto LAB_1808d1581;
                            lVar7 = *(int64 *)(lVar7 + 32);
                            if (((*(int64 *)(lVar10 + 128) == 0) ||
                                (lVar8 = FUN_180002f80(*(int64 *)(lVar10 + 128),iVar12,DAT_181d51688),
                                lVar8 == null)) ||
                               (uVar3 = FUN_1800d6750(lVar8,iVar13,DAT_181d68270), lVar7 == null))
                            goto LAB_1808d1581;
                            lVar7 = WorldData.GetHero(lVar7,uVar3,0);
                            if (lVar7 != null) {
                              lVar7 = *(int64 *)(lVar6 + 32);
                              lVar8 = FUN_18046c0a0(0);
                              if (lVar8 == null) goto LAB_1808d1581;
                              lVar8 = *(int64 *)(lVar8 + 32);
                              if (((*(int64 *)(lVar10 + 128) == 0) ||
                                  (lVar9 = FUN_180002f80(*(int64 *)(lVar10 + 128),iVar12,DAT_181d51688
                                                        ), lVar9 == null)) ||
                                 ((uVar3 = FUN_1800d6750(lVar9,iVar13,DAT_181d68270), lVar8 == null ||
                                  (uVar5 = WorldData.GetHero(lVar8,uVar3,0), lVar7 == null))))
                              goto LAB_1808d1581;
                              FUN_181827900(lVar7,uVar5,DAT_181d63d78);
                            }
                            iVar13 = iVar13 + 1;
                          }
                        }
                        iVar12 = iVar12 + 1;
                      }
                    }
                    if (this.heroList == null) break;
                    FUN_18182b220(this.heroList,uVar2,DAT_181d641f8);
                  }
                  lVar7 = *(int64 *)(lVar10 + 72);
                  if ((lVar7 == null) ||
                     (lVar6._items = lVar7.Count,
                     *(int64 *)(lVar10 + 72) == 0)) break;
                  FUN_181827900();
                  lVar6 = this.heroList;
                  if (lVar6 == null) break;
                }
              }
            }
          }
        LAB_1808d1581:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (this.<>1__state == 1) {
          this.<>1__state = 0xffffffff;
          if (((lVar10 == null) || (*(int64 *)(lVar10 + 40) == 0)) ||
             (lVar10 = GameObject.GetComponent(*(int64 *)(lVar10 + 40),DAT_181d9ee60)) == null)
          goto LAB_1808d1581;
          Selectable.set_interactable(lVar10,1,0);
        }
        return false;
    }

    // Token : 0x6001437
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6001438
    // RVA   : 0x8D1590   Offset: 0x8CFD90   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d7a888);
    }

    // Token : 0x6001439
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
