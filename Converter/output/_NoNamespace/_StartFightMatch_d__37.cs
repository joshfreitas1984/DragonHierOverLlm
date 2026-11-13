// ============================================================
// Type  : <StartFightMatch>d__37
// Token : 0x2000288
// ============================================================

public class <StartFightMatch>d__37
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400147B
    private int <>1__state;

    // Token: 0x400147C
    private object <>2__current;

    // Token: 0x400147D
    public FightMatchController <>4__this;

    // Token: 0x400147E
    public List<HeroData> heroList;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60014E0
    // RVA   : 0x608BA0   Offset: 0x6079A0   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x60014E1
    // RVA   : 0x51CF50   Offset: 0x51BD50   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x60014E2
    // RVA   : 0x67AD00   Offset: 0x679B00   Length: 0x8B6
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
            if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181e8f4a0)) {
              plVar11 = plVar4;
            }
            NGUITools.PlaySound(plVar11,0);
            if (*(int64 *)(lVar10 + 72) == 0) {
              uVar5 = il2cpp_internal(DAT_181e72bb8);
              FUN_1810f3480(uVar5,DAT_181e69ff8);
              *(uint64 *)(lVar10 + 72) = uVar5;
            }
            else {
              FUN_18115d8f0(*(int64 *)(lVar10 + 72),DAT_181e6a0f8);
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
                  uVar1 = FUN_180af1860(0,this.heroList.Count,0);
                  if (lVar6 == null) break;
                  lVar7 = this.heroList;
                  lVar8 = lVar6.Count;
                  if (lVar7 == null) break;
                  if (lVar7.Count <= uVar1) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  if (lVar8 == null) break;
                  FUN_18175de30(lVar8,*(uint64 *)
                                       (lVar7._items + 32 + (int64)(int)uVar1 * 8),
                                DAT_181e6d770);
                  if (*(char *)(lVar10 + 121) != false) {
                    iVar12 = 0;
                    while( true ) {
                      lVar7 = *(int64 *)(lVar10 + 128);
                      if (lVar7 == null) goto LAB_18067b5b1;
                      if (lVar7.Count <= iVar12) break;
                      lVar7 = FUN_1800024b0(lVar7,iVar12,DAT_181e5a4c8);
                      if (lVar7 == null) goto LAB_18067b5b1;
                      if (lVar7.Count == null) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      iVar13 = *(int *)(lVar7._items + 32);
                      if ((this.heroList == null) ||
                         (lVar7 = FUN_1800024b0(this.heroList,uVar1,DAT_181e6dd70),
                         lVar7 == null)) goto LAB_18067b5b1;
                      if (iVar13 == *(int *)(lVar7 + 88)) {
                        iVar13 = 1;
                        while( true ) {
                          if ((*(int64 *)(lVar10 + 128) == 0) ||
                             (lVar7 = FUN_1800024b0(*(int64 *)(lVar10 + 128),iVar12,DAT_181e5a4c8),
                             lVar7 == null)) goto LAB_18067b5b1;
                          if (lVar7.Count <= iVar13) break;
                          lVar7 = FUN_1802106e0(0);
                          if (lVar7 == null) goto LAB_18067b5b1;
                          lVar7 = *(int64 *)(lVar7 + 32);
                          if (((*(int64 *)(lVar10 + 128) == 0) ||
                              (lVar8 = FUN_1800024b0(*(int64 *)(lVar10 + 128),iVar12,DAT_181e5a4c8),
                              lVar8 == null)) ||
                             (uVar2 = FUN_180002480(lVar8,iVar13,DAT_181e71bf0), lVar7 == null))
                          goto LAB_18067b5b1;
                          lVar7 = WorldData.GetHero(lVar7,uVar2,0);
                          if (lVar7 != null) {
                            lVar7 = lVar6.Count;
                            lVar8 = FUN_1802106e0(0);
                            if (lVar8 == null) goto LAB_18067b5b1;
                            lVar8 = *(int64 *)(lVar8 + 32);
                            if (((*(int64 *)(lVar10 + 128) == 0) ||
                                (lVar9 = FUN_1800024b0(*(int64 *)(lVar10 + 128),iVar12,DAT_181e5a4c8),
                                lVar9 == null)) ||
                               ((uVar2 = FUN_180002480(lVar9,iVar13,DAT_181e71bf0), lVar8 == null ||
                                (uVar5 = WorldData.GetHero(lVar8,uVar2,0), lVar7 == null))))
                            goto LAB_18067b5b1;
                            FUN_18175de30(lVar7,uVar5,DAT_181e6d770);
                          }
                          iVar13 = iVar13 + 1;
                        }
                      }
                      iVar12 = iVar12 + 1;
                    }
                  }
                  if (this.heroList == null) break;
                  FUN_181763390(this.heroList,uVar1,DAT_181e6dbf0);
                  if (this.heroList == null) break;
                  iVar12 = this.heroList.Count;
                  if (0 < iVar12) {
                    uVar2 = FUN_180af1860(0,iVar12,0);
                    lVar7 = *(int64 *)(lVar6 + 32);
                    if ((this.heroList == null) ||
                       (uVar5 = FUN_1800024b0(this.heroList,uVar2,DAT_181e6dd70),
                       lVar7 == null)) break;
                    FUN_18175de30(lVar7,uVar5,DAT_181e6d770);
                    if (*(char *)(lVar10 + 121) != false) {
                      iVar12 = 0;
                      while( true ) {
                        lVar7 = *(int64 *)(lVar10 + 128);
                        if (lVar7 == null) goto LAB_18067b5b1;
                        if (lVar7.Count <= iVar12) break;
                        lVar7 = FUN_1800024b0(lVar7,iVar12,DAT_181e5a4c8);
                        if (lVar7 == null) goto LAB_18067b5b1;
                        if (lVar7.Count == null) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        iVar13 = *(int *)(lVar7._items + 32);
                        if ((this.heroList == null) ||
                           (lVar7 = FUN_1800024b0(this.heroList,uVar2,DAT_181e6dd70),
                           lVar7 == null)) goto LAB_18067b5b1;
                        if (iVar13 == *(int *)(lVar7 + 88)) {
                          iVar13 = 1;
                          while( true ) {
                            if ((*(int64 *)(lVar10 + 128) == 0) ||
                               (lVar7 = FUN_1800024b0(*(int64 *)(lVar10 + 128),iVar12,DAT_181e5a4c8),
                               lVar7 == null)) goto LAB_18067b5b1;
                            if (lVar7.Count <= iVar13) break;
                            lVar7 = FUN_1802106e0(0);
                            if (lVar7 == null) goto LAB_18067b5b1;
                            lVar7 = *(int64 *)(lVar7 + 32);
                            if (((*(int64 *)(lVar10 + 128) == 0) ||
                                (lVar8 = FUN_1800024b0(*(int64 *)(lVar10 + 128),iVar12,DAT_181e5a4c8),
                                lVar8 == null)) ||
                               (uVar3 = FUN_180002480(lVar8,iVar13,DAT_181e71bf0), lVar7 == null))
                            goto LAB_18067b5b1;
                            lVar7 = WorldData.GetHero(lVar7,uVar3,0);
                            if (lVar7 != null) {
                              lVar7 = *(int64 *)(lVar6 + 32);
                              lVar8 = FUN_1802106e0(0);
                              if (lVar8 == null) goto LAB_18067b5b1;
                              lVar8 = *(int64 *)(lVar8 + 32);
                              if (((*(int64 *)(lVar10 + 128) == 0) ||
                                  (lVar9 = FUN_1800024b0(*(int64 *)(lVar10 + 128),iVar12,DAT_181e5a4c8
                                                        ), lVar9 == null)) ||
                                 ((uVar3 = FUN_180002480(lVar9,iVar13,DAT_181e71bf0), lVar8 == null ||
                                  (uVar5 = WorldData.GetHero(lVar8,uVar3,0), lVar7 == null))))
                              goto LAB_18067b5b1;
                              FUN_18175de30(lVar7,uVar5,DAT_181e6d770);
                            }
                            iVar13 = iVar13 + 1;
                          }
                        }
                        iVar12 = iVar12 + 1;
                      }
                    }
                    if (this.heroList == null) break;
                    FUN_181763390(this.heroList,uVar2,DAT_181e6dbf0);
                  }
                  lVar7 = *(int64 *)(lVar10 + 72);
                  if ((lVar7 == null) ||
                     (lVar6._items = lVar7.Count,
                     *(int64 *)(lVar10 + 72) == 0)) break;
                  FUN_18175de30();
                  lVar6 = this.heroList;
                  if (lVar6 == null) break;
                }
              }
            }
          }
        LAB_18067b5b1:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        if (this.<>1__state == 1) {
          this.<>1__state = 0xffffffff;
          if (((lVar10 == null) || (*(int64 *)(lVar10 + 40) == 0)) ||
             (lVar10 = GameObject.GetComponent(*(int64 *)(lVar10 + 40),DAT_181e53cb0)) == null)
          goto LAB_18067b5b1;
          Selectable.set_interactable(lVar10,1,0);
        }
        return false;
    }

    // Token : 0x60014E3
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x60014E4
    // RVA   : 0x67B5C0   Offset: 0x67A3C0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181e6d8e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181e86fa0);
    }

    // Token : 0x60014E5
    // RVA   : 0x608B50   Offset: 0x607950   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
