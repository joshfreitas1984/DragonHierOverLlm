// ============================================================
// Type  : <FinishParty>d__58
// Token : 0x2000310
// ============================================================

public class <FinishParty>d__58
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001887
    private int <>1__state;

    // Token: 0x4001888
    private object <>2__current;

    // Token: 0x4001889
    public PartyController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600194D
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x600194E
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x600194F
    // RVA   : 0x8CA080   Offset: 0x8C8880   Length: 0xEBE
    private virtual bool MoveNext()
    {
        var plVar11 = *(int64*)(lVar11 + 184);
        var pStatics = *(int64*)(DAT_181d6b060 + 184);
        uint uVar1;
        uint uVar2;
        int iVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        ulong uVar7;
        ulong uVar8;
        long lVar9;
        long lVar10;
        long lVar11;
        float fVar12;
        float[] local_res8 = new float[2];
        ulong in_stack_ffffffffffffff78;
        uint in_stack_ffffffffffffff80;
        lVar11 = this.<>4__this;
        if (this.<>1__state == 0) {
          this.<>1__state = 0xffffffff;
          if ((((lVar11 == null) || (*(int64 *)(lVar11 + 32) == 0)) ||
              (lVar4 = GameObject.get_transform(*(int64 *)(lVar11 + 32),0)) == null) ||
             ((lVar4 = Transform.Find(lVar4,"ProgressBar",0), lVar4 == null ||
              (lVar4 = Component.get_gameObject(lVar4,0)) == null))) throw; // [null/range check failed]
          GameObject.SetActive(lVar4,0,0);
        }
        else {
          if (this.<>1__state != 1) {
            return false;
          }
          this.<>1__state = 0xffffffff;
          lVar4 = FUN_18046c440(0);
          if (lVar4 == null) throw; // [null/range check failed]
          if (*(char *)(lVar4 + 24) == false) {
            Random.Range();
            if (lVar11 == null) throw; // [null/range check failed]
            PartyController.GetMaxHeroLv(lVar11,0);
            lVar4 = plVar11;
            if (lVar4 == null) throw; // [null/range check failed]
            uVar1 = *(uint32 *)(lVar4 + 24);
            if (uVar1 <= uVar1 - 1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(int64 *)(*(int64 *)(lVar4 + 16) + 24 + (int64)(int)uVar1 * 8) == 0)
            throw; // [null/range check failed]
            fVar12 = (float)Mathf.Max();
            fVar12 = fVar12 + 1.0;
            if (*(int64 *)(lVar11 + 168) == 0) throw; // [null/range check failed]
            if (*(int *)(*(int64 *)(lVar11 + 168) + 88) == 0) {
              lVar9 = FUN_18046c440(0);
              lVar4 = plVar11;
              if ((lVar4 == null) ||
                 (uVar5 = FUN_180002f80(lVar4,*(int *)(lVar4 + 24) + -1,DAT_181d643f8), lVar9 == null))
              throw; // [null/range check failed]
              in_stack_ffffffffffffff80 = in_stack_ffffffffffffff80 & 0xffffff00;
              in_stack_ffffffffffffff78 = in_stack_ffffffffffffff78 & 0xffffffff00000000;
              PlotController.PlotChangeHeroFavor
                        (lVar9,uVar5,fVar12,0x42c80000,in_stack_ffffffffffffff78,in_stack_ffffffffffffff80
                         ,0);
            }
            lVar4 = plVar11;
            if (lVar4 == null) throw; // [null/range check failed]
            uVar1 = *(uint32 *)(lVar4 + 24);
            if (uVar1 <= uVar1 - 1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 24 + (int64)(int)uVar1 * 8);
            if (lVar4 == null) throw; // [null/range check failed]
            if (*(int *)(lVar4 + 88) == 0) {
              lVar4 = FUN_18046c440(0);
              if (lVar4 == null) throw; // [null/range check failed]
              PlotController.PlotChangeHeroFavor
                        (lVar4,*(uint64 *)(lVar11 + 168),0x3f800000,0x42c80000,
                         in_stack_ffffffffffffff78 & 0xffffffff00000000,
                         in_stack_ffffffffffffff80 & 0xffffff00,0);
              lVar4 = plVar11;
              if ((lVar4 == null) ||
                 (lVar4 = FUN_180002f80(lVar4,*(int *)(lVar4 + 24) + -1,DAT_181d643f8)) == null)
              throw; // [null/range check failed]
              HeroData.ChangeFame(lVar4,fVar12,1,0);
            }
            if (*(int *)(lVar11 + 24) == 1) {
              lVar4 = plVar11;
              if ((lVar4 == null) ||
                 (lVar4 = FUN_180002f80(lVar4,*(int *)(lVar4 + 24) + -1,DAT_181d643f8)) == null)
              throw; // [null/range check failed]
              HeroData.ChangeLoyal(lVar4,fVar12,1,0);
            }
            lVar4 = plVar11;
            if (lVar4 == null) throw; // [null/range check failed]
            uVar1 = *(uint32 *)(lVar4 + 24);
            if (uVar1 <= uVar1 - 1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 24 + (int64)(int)uVar1 * 8);
            uVar2 = Mathf.RoundToInt();
            lVar9 = *(int64 *)(pStatics + 24);
            if ((lVar9 == null) || (iVar3 = Mathf.Clamp(uVar2,0,*(int *)(lVar9 + 24) + -1,0), lVar4 == null))
            throw; // [null/range check failed]
            HeroData.AddTag(lVar4,iVar3 + 0x14e,0x41200000,0,1,1,0);
            if (*(char *)(lVar11 + 204) == false) {
              if (*(int *)(lVar11 + 24) == 0) {
                if (*(int64 *)(lVar11 + 168) == 0) throw; // [null/range check failed]
                if (*(int *)(*(int64 *)(lVar11 + 168) + 88) != 0) {
                  if (((*(int64 *)(lVar11 + 192) == 0) || (plVar11 == 0)) ||
                     (lVar4 = FUN_180002f80(plVar11,
                                            *(int *)(*(int64 *)(lVar11 + 192) + 24) + -1,
                                            DAT_181d643f8), lVar4 == null)) throw; // [null/range check failed]
                  if (*(int *)(lVar4 + 88) != 0) goto LAB_1808ca7db;
                }
              }
              lVar4 = FUN_18046c440(0);
              lVar9 = *(int64 *)(pStatics + 24);
              uVar2 = Mathf.RoundToInt(pStatics,0);
              lVar10 = *(int64 *)(pStatics + 24);
              if ((lVar10 == null) ||
                 (uVar2 = Mathf.Clamp(uVar2,0,*(int *)(lVar10 + 24) + -1,0), lVar9 == null))
              throw; // [null/range check failed]
              uVar5 = FUN_180002f80(lVar9,uVar2,DAT_181d7c9c0);
              if ((*(int64 *)(lVar11 + 192) == 0) ||
                 ((plVar11 == 0 ||
                  (lVar9 = FUN_180002f80(plVar11,
                                         *(int *)(*(int64 *)(lVar11 + 192) + 24) + -1,DAT_181d643f8)
                  , lVar9 == null)))) throw; // [null/range check failed]
              uVar6 = Int32.ToString(lVar9 + 88,0);
              if (*(int64 *)(lVar11 + 168) == 0) throw; // [null/range check failed]
              uVar8 = Int32.ToString(*(int64 *)(lVar11 + 168) + 88,0);
              uVar7 = new SinglePlotData(uVar5,0,3,uVar6,3,uVar8,0,0,0);
              if (lVar4 == null) throw; // [null/range check failed]
              PlotController.ChangePlot(lVar4,uVar7,0);
            }
        LAB_1808ca7db:
            lVar4 = plVar11;
            if (lVar4 == null) throw; // [null/range check failed]
            FUN_18182b220(lVar4,*(int *)(lVar4 + 24) + -1,DAT_181d641f8);
            lVar4 = *(int64 *)(lVar11 + 192);
            if (lVar4 == null) throw; // [null/range check failed]
            uVar1 = *(uint32 *)(lVar4 + 24);
            if (uVar1 <= uVar1 - 1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar5 = *(uint64 *)(*(int64 *)(lVar4 + 16) + 24 + (int64)(int)uVar1 * 8);
            Object.Destroy(uVar5,0);
            lVar4 = *(int64 *)(lVar11 + 192);
            if (lVar4 == null) throw; // [null/range check failed]
            FUN_18182b220(lVar4,*(int *)(lVar4 + 24) + -1,DAT_181d61ef8);
          }
          else if (lVar11 == null) throw; // [null/range check failed]
        }
        if (plVar11 != 0) {
          if (0 < *(int *)(plVar11 + 24)) {
            uVar5 = new WaitForSeconds(0x3f000000,0);
            this.<>2__current = uVar5;
            this.<>1__state = 1;
            return true;
          }
          PartyController.SetSkippingState(lVar11,0,0);
          if (*(int *)(lVar11 + 24) == 2) {
            lVar4 = new PlotData(0);
            if (lVar4 != null) {
              lVar9 = *(int64 *)(lVar4 + 64);
              uVar5 = FUN_180004500(DAT_181d63120);
              uVar5 = String.Format("宾客皆已离场，婚礼终于结束了。\n能和#TargetInteractName#一路走来，最终结为夫妻，回头看真如同做梦一般。",uVar5,0);
              if (*(int64 *)(lVar11 + 176) != 0) {
                uVar6 = Int32.ToString(*(int64 *)(lVar11 + 176) + 88,0);
                if (*(int64 *)(lVar11 + 168) != 0) {
                  uVar8 = Int32.ToString(*(int64 *)(lVar11 + 168) + 88,0);
                  uVar7 = new SinglePlotData(uVar5,0,3,uVar6,3,uVar8,1,0,0);
                  if (lVar9 != null) {
                    FUN_181827900(lVar9,uVar7,DAT_181d79a58);
                    lVar9 = *(int64 *)(lVar4 + 64);
                    uVar5 = FUN_180004500(DAT_181d63120);
                    uVar5 = String.Format("哈哈......我也是如同做梦一般呢......\n#PlayerName#再喝上一杯吧......哈哈哈哈",uVar5,0);
                    if (*(int64 *)(lVar11 + 176) != 0) {
                      uVar6 = Int32.ToString(*(int64 *)(lVar11 + 176) + 88,0);
                      if (*(int64 *)(lVar11 + 168) != 0) {
                        uVar8 = Int32.ToString(*(int64 *)(lVar11 + 168) + 88,0);
                        uVar7 = new SinglePlotData(uVar5,0,3,uVar6,3,uVar8,0,0,0);
                        if (lVar9 != null) {
                          FUN_181827900(lVar9,uVar7,DAT_181d79a58);
                          lVar9 = *(int64 *)(lVar4 + 64);
                          uVar5 = FUN_180004500(DAT_181d63120);
                          uVar5 = String.Format("哎呀呀，新婚之夜却醉成这个样子，都让你少喝点了。\n来吧我扶你躺着去。",uVar5,0);
                          if (*(int64 *)(lVar11 + 176) != 0) {
                            uVar6 = Int32.ToString(*(int64 *)(lVar11 + 176) + 88,0);
                            if (*(int64 *)(lVar11 + 168) != 0) {
                              uVar8 = Int32.ToString(*(int64 *)(lVar11 + 168) + 88,0);
                              uVar7 = new SinglePlotData(uVar5,0,3,uVar6,3,uVar8,1,0,0);
                              if (lVar9 != null) {
                                FUN_181827900(lVar9,uVar7,DAT_181d79a58);
                                lVar9 = *(int64 *)(lVar4 + 64);
                                uVar5 = FUN_180004500(DAT_181d63120);
                                uVar5 = String.Format("........................",uVar5,0);
                                if (*(int64 *)(lVar11 + 176) != 0) {
                                  uVar6 = Int32.ToString(*(int64 *)(lVar11 + 176) + 88,0);
                                  if (*(int64 *)(lVar11 + 168) != 0) {
                                    uVar8 = Int32.ToString(*(int64 *)(lVar11 + 168) + 88,0);
                                    uVar7 = new SinglePlotData(uVar5,0,3,uVar6,3,uVar8,0,0,0);
                                    if (lVar9 != null) {
                                      FUN_181827900(lVar9,uVar7,DAT_181d79a58);
                                      lVar9 = *(int64 *)(lVar4 + 64);
                                      uVar5 = FUN_180004500(DAT_181d63120);
                                      uVar5 = String.Format("睡着了？好吧好吧，真拿你没办法。",uVar5,0);
                                      lVar10 = il2cpp_internal(DAT_181d72a30);
                                      FUN_180f58a90(lVar10,DAT_181d7c250);
                                      if (lVar10 != null) {
                                        FUN_181827900(lVar10,"结束宴会;EndParty",DAT_181d7c3d0);
                                        if (*(int64 *)(lVar11 + 176) != 0) {
                                          uVar6 = Int32.ToString(*(int64 *)(lVar11 + 176) + 88,0);
                                          if (*(int64 *)(lVar11 + 168) != 0) {
                                            uVar8 = Int32.ToString(*(int64 *)(lVar11 + 168) + 88,0)
                                            ;
                                            uVar7 = il2cpp_internal(DAT_181d7d2b0);
                                            SinglePlotData.ctor(uVar7,uVar5,lVar10,3,uVar6,3,uVar8,1,0,0)
                                            ;
                                            if (lVar9 != null) {
                                              FUN_181827900(lVar9,uVar7,DAT_181d79a58);
                                              lVar11 = FUN_18046c440(0);
                                              if (lVar11 != null) {
                                                PlotController.AddPlot(lVar11,lVar4,0);
                                                return false;
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
            lVar4 = FUN_18046c440(0);
            local_res8[0] = (float)PartyController.GetTotalScore(lVar11,0);
            uVar6 = Single.ToString(local_res8,"f0",0);
            uVar5 = "宾客皆已离场，宴会圆满结束了。\n本次宴会评分为{0}，\n于江湖中传扬一番，想来能使{1}。";
            if (*(int *)(lVar11 + 24) == 1) {
              local_res8[0] = (float)PartyController.GetMaxHeroLv(lVar11,0);
              local_res8[0] = local_res8[0] * 50.0;
              uVar7 = Single.ToString(local_res8,"f0",0);
              uVar8 = "门派威望增加";
            }
            else {
              local_res8[0] = (float)PartyController.GetMaxHeroLv(lVar11,0);
              local_res8[0] = local_res8[0] * 10.0;
              uVar7 = Single.ToString(local_res8,"f0",0);
              uVar8 = "声望增加";
            }
            uVar8 = String.Concat(uVar8,uVar7,0);
            uVar5 = String.Format(uVar5,uVar6,uVar8,0);
            lVar9 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(lVar9,DAT_181d7c250);
            if (lVar9 != null) {
              FUN_181827900(lVar9,"结束宴会;EndParty",DAT_181d7c3d0);
              if (*(int64 *)(lVar11 + 168) != 0) {
                uVar6 = Int32.ToString(*(int64 *)(lVar11 + 168) + 88,0);
                uVar8 = new SinglePlotData(uVar5,lVar9,1,0,3,uVar6,1,0,0);
                if (lVar4 != null) {
                  PlotController.AddPlot(lVar4,uVar8,0);
                  return false;
                }
              }
            }
          }
        }
    }

    // Token : 0x6001950
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6001951
    // RVA   : 0x8CAF40   Offset: 0x8C9740   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d80a28);
    }

    // Token : 0x6001952
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
