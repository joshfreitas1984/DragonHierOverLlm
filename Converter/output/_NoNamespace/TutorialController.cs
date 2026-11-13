// ============================================================
// Type  : TutorialController
// Token : 0x20003B6
// ============================================================

public class TutorialController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001E55
    public GameObject tutorialPanel;

    // Token: 0x4001E56
    public RectTransform highLightRect;

    // Token: 0x4001E57
    public GameObject arrow;

    // Token: 0x4001E58
    public GameObject tutorialTextUI;

    // Token: 0x4001E59
    public bool inTutorial;

    // Token: 0x4001E5A
    private TutorialData nowTutorial;

    // Token: 0x4001E5B
    public int nowTutorialPlotCount;

    // Token: 0x4001E5C
    public List<TutorialData> tutorialDatas;

    // Token: 0x4001E5D
    public bool textShowing;

    // Token: 0x4001E5E
    public bool tutorialNoLeaveBuilding;

    // Token: 0x4001E5F
    private static TutorialController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60023C7
    // RVA   : 0x83D620   Offset: 0x83C420   Length: 0x36
    public static TutorialController get_Instance()
    {
        return **(uint64 **)(DAT_181e8e150 + 184);
    }

    // Token : 0x60023C8
    // RVA   : 0x8353D0   Offset: 0x8341D0   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181e8e150 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60023C9
    // RVA   : 0x836AE0   Offset: 0x8358E0   Length: 0x4C3
    public void StartTutorial(string tutorialName)
    {
        bool cVar1;
        int iVar2;
        ulong uVar3;
        long lVar4;
        long lVar5;
        uint uVar6;
        if (*(int *)(*(int64 *)(DAT_181e538e8 + 184) + 8) == 1) {
          if (GameController._instance == null) throw; // [null/range check failed]
          cVar1 = GameController.CheckPlayTestEnd(GameController._instance,0);
          if (cVar1) {
            return;
          }
        }

        if ((lVar4 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 8)?._items) != null) {
          iVar2 = PlayerPrefDictionary.GetInt(lVar4,"SkipTutorial",0);
          if (iVar2 == 1) {
            if (((GameController._instance != null) &&
                (lVar4 = GameController._instance.worldData) != null) &&
               (lVar4 = lVar4.tutorialFinished) != null) {
              cVar1 = FUN_18175e190(lVar4,tutorialName,DAT_181e86470);
              if (!cVar1) {
                lVar4 = FUN_1802106e0(0);
                if (((lVar4 == null) || (lVar4.villageAreaID == null)) ||
                   (lVar4 = *(int64 *)(lVar4.villageAreaID + 0x100)) == null)
                throw; // [null/range check failed]
                FUN_18175de30(lVar4,tutorialName,DAT_181e86370);
              }
              return;
            }
          }
          else {
            if (((GameController._instance != null) &&
                (lVar4 = GameController._instance.worldData) != null) &&
               (lVar4 = lVar4.tutorialFinished) != null) {
              cVar1 = FUN_18175e190(lVar4,tutorialName,DAT_181e86470);
              if (cVar1) {
                return;
              }
              if (this.nowTutorial != null) {
                return;
              }
              lVar4 = this.tutorialDatas;
              uVar6 = 0;
              if (lVar4 != null) {
                lVar5 = 32;
                do {
                  if (lVar4.Count <= (int)uVar6) {
        LAB_180836e06:
                    if (this.nowTutorial == null) {
                      uVar3 = String.Concat("Tutorial Not Found: ",tutorialName,0);
                      Debug.Log(uVar3,0);
                      return;
                    }
                    if (this.tutorialPanel != null) {
                      GameObject.SetActive(this.tutorialPanel,1,0);
                      this.nowTutorialPlotCount = 0;
                      lVar4 = FUN_180670040(0);
                      if (lVar4 != null) {
                        lVar4.Count = 1;
                        this.inTutorial = 1;
                        TutorialController.ShowNextTutorialPlot(this,1,0);
                        return;
                      }
                    }
                    break;
                  }
                  if (lVar4 == null) break;
                  if (lVar4.Count <= uVar6) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar4 = *(int64 *)(lVar5 + lVar4._items);
                  if (lVar4 == null) break;
                  cVar1 = FUN_1816387f0(lVar4._items,tutorialName,0);
                  lVar4 = this.tutorialDatas;
                  if (cVar1) {
                    if (lVar4 != null) {
                      uVar3 = FUN_1800024b0(lVar4,uVar6,DAT_181e8a7f0);
                      this.nowTutorial = uVar3;
                      goto LAB_180836e06;
                    }
                    break;
                  }
                  uVar6 = uVar6 + 1;
                  lVar5 = lVar5 + 8;
                } while (lVar4 != null);
              }
            }
          }
        }
    }

    // Token : 0x60023CA
    // RVA   : 0x835980   Offset: 0x834780   Length: 0x338
    public void ShowNextTutorialPlot(bool firstPlot)
    {
        var pStatics = *(int64*)(DAT_181e8c2e8 + 184);
        uint uVar1;
        bool cVar2;
        float fVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar6;
        long lVar7;
        ulong uVar8;
        float extraout_var;
        float *pfVar10;
        int64 *plVar11;
        int64 *plVar12;
        uint32 uVar13;
        uint32 uVar14;
        uint32 uVar15;
        uint64 local_res20;
        uint64 local_68;
        uint32 local_60;
        uint8 local_58 [64];
        if (!firstPlot) {
          if ((this.nowTutorial == null) ||
             (lVar6 = this.nowTutorial.tutorialPlotDatas) == null)
          throw; // [null/range check failed]
          uVar1 = this.nowTutorialPlotCount;
          if (lVar6.noAutoFinish <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar6 = lVar6.tutorialName[uVar1];
          if (lVar6 == null) throw; // [null/range check failed]
          uVar8 = *(uint64 *)(lVar6 + 72);
          cVar2 = Object.op_Inequality(uVar8,0,0);
          if (cVar2) {
            if ((this.nowTutorial == null) ||
               (lVar6 = this.nowTutorial.tutorialPlotDatas) == null)
            throw; // [null/range check failed]
            uVar1 = this.nowTutorialPlotCount;
            if (lVar6.noAutoFinish <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar6 = lVar6.tutorialName[uVar1];
            if (lVar6 == null) throw; // [null/range check failed]
            uVar8 = *(uint64 *)(lVar6 + 72);
            uVar4 = EventSystem.get_current(0);
            uVar5 = new PointerEventData(uVar4,0);
            ExecuteEvents.Execute
                      (uVar8,uVar5,*(uint64 *)(*(int64 *)(DAT_181ea5ef0 + 184) + 32),
                       DAT_181e9c5f0);
          }
          if ((this.nowTutorial == null) ||
             (lVar6 = this.nowTutorial.tutorialPlotDatas) == null)
          throw; // [null/range check failed]
          uVar1 = this.nowTutorialPlotCount;
          if (lVar6.noAutoFinish <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException();
          }
          lVar6 = lVar6.tutorialName[uVar1];
          if (lVar6 == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar6 + 88) != 0) {
            if ((this.nowTutorial == null) ||
               (lVar6 = this.nowTutorial.tutorialPlotDatas) == null)
            throw; // [null/range check failed]
            uVar1 = this.nowTutorialPlotCount;
            if (lVar6.noAutoFinish <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar6 = lVar6.tutorialName[uVar1];
            if (lVar6 == null) throw; // [null/range check failed]
            cVar2 = String.op_Inequality(*(uint64 *)(lVar6 + 88),"",0);
            if (cVar2) {
              if ((this.nowTutorial == null) ||
                 (lVar6 = this.nowTutorial.tutorialPlotDatas) == null)
              throw; // [null/range check failed]
              uVar1 = this.nowTutorialPlotCount;
              if (lVar6.noAutoFinish <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar6 = lVar6.tutorialName[uVar1];
              if (lVar6 == null) throw; // [null/range check failed]
              TutorialController.TutorialCallPlot(this,*(uint64 *)(lVar6 + 88),0);
            }
          }
          this.nowTutorialPlotCount = this.nowTutorialPlotCount + 1;
        }
        lVar6 = this.nowTutorial;
        if ((lVar6 == null) || (lVar7 = lVar6.tutorialPlotDatas) == null) throw; // [null/range check failed]
        uVar1 = this.nowTutorialPlotCount;
        if ((int)*(uint32 *)(lVar7 + 24) <= (int)uVar1) {
          if (!lVar6.noAutoFinish) {
            lVar6 = FUN_1802106e0(0);
            if ((((lVar6 == null) || (lVar6.tutorialPlotDatas == null)) ||
                (this.nowTutorial == null)) ||
               (lVar6 = *(int64 *)(lVar6.tutorialPlotDatas + 0x100)) == null)
            throw; // [null/range check failed]
            FUN_18175de30(lVar6,this.nowTutorial.tutorialName,DAT_181e86370);
          }
          this.nowTutorial = 0;
          if (this.tutorialPanel != null) {
            GameObject.SetActive(this.tutorialPanel,0,0);
            if (*pStatics != 0) {
              *(uint8 *)(*pStatics + 24) = 0;
              this.inTutorial = 0;
              return;
            }
          }
          throw; // [null/range check failed]
        }
        if (*(uint32 *)(lVar7 + 24) <= uVar1) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar6 = lVar7[uVar1];
        if (lVar6 == null) throw; // [null/range check failed]
        if (*(int64 *)(lVar6 + 80) != 0) {
          if ((this.nowTutorial == null) ||
             (lVar6 = this.nowTutorial.tutorialPlotDatas) == null)
          throw; // [null/range check failed]
          uVar1 = this.nowTutorialPlotCount;
          if (lVar6.noAutoFinish <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar6 = lVar6.tutorialName[uVar1];
          if (lVar6 == null) throw; // [null/range check failed]
          cVar2 = String.op_Inequality(*(uint64 *)(lVar6 + 80),"",0);
          if (cVar2) {
            if ((this.nowTutorial == null) ||
               (lVar6 = this.nowTutorial.tutorialPlotDatas) == null)
            throw; // [null/range check failed]
            uVar1 = this.nowTutorialPlotCount;
            if (lVar6.noAutoFinish <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar6 = lVar6.tutorialName[uVar1];
            if (lVar6 == null) throw; // [null/range check failed]
            TutorialController.TutorialCallPlot(this,*(uint64 *)(lVar6 + 80),0);
          }
        }
        if ((this.nowTutorial == null) ||
           (lVar6 = this.nowTutorial.tutorialPlotDatas) == null) throw; // [null/range check failed]
        uVar1 = this.nowTutorialPlotCount;
        if (lVar6.noAutoFinish <= uVar1) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar6 = lVar6.tutorialName[uVar1];
        if (lVar6 == null) throw; // [null/range check failed]
        if (*(char *)(lVar6 + 40) == false) {
          if ((this.nowTutorial == null) ||
             (lVar6 = this.nowTutorial.tutorialPlotDatas) == null)
          throw; // [null/range check failed]
          uVar1 = this.nowTutorialPlotCount;
          if (lVar6.noAutoFinish <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar6 = lVar6.tutorialName[uVar1];
          if (lVar6 == null) throw; // [null/range check failed]
          uVar8 = lVar6.tutorialPlotDatas;
          cVar2 = Object.op_Inequality(uVar8,0,0);
          if (cVar2) {
            if (this.highLightRect == null) throw; // [null/range check failed]
            lVar6 = Component.GetComponent(this.highLightRect,DAT_181e782b8);
            if ((this.nowTutorial == null) ||
               (lVar7 = this.nowTutorial.tutorialPlotDatas) == null)
            throw; // [null/range check failed]
            uVar1 = this.nowTutorialPlotCount;
            if (*(uint32 *)(lVar7 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar7 = lVar7[uVar1];
            if ((((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 32)) == null) ||
                (lVar7 = GameObject.GetComponent(lVar7,DAT_181e55c90)) == null) ||
               (uVar8 = RectTransform.get_pivot(lVar7,0), lVar6 == null)) throw; // [null/range check failed]
            RectTransform.set_pivot(lVar6,uVar8,0);
            if (this.highLightRect == null) throw; // [null/range check failed]
            lVar6 = Component.GetComponent(this.highLightRect,DAT_181e782b8);
            if ((this.nowTutorial == null) ||
               (lVar7 = this.nowTutorial.tutorialPlotDatas) == null)
            throw; // [null/range check failed]
            uVar1 = this.nowTutorialPlotCount;
            if (*(uint32 *)(lVar7 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar7 = lVar7[uVar1];
            if (((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 32)) == null) ||
               ((lVar7 = GameObject.GetComponent(lVar7,DAT_181e55c90), lVar7 == null ||
                (puVar9 = (uint64 *)Transform.get_position(local_58,lVar7,0), lVar6 == null))))
            throw; // [null/range check failed]
            local_68 = *puVar9;
            local_60 = *(uint32 *)(puVar9 + 1);
            Transform.set_position(lVar6,&local_68,0);
            if (this.highLightRect == null) throw; // [null/range check failed]
            lVar6 = Component.GetComponent(this.highLightRect,DAT_181e782b8);
            if ((this.nowTutorial == null) ||
               (lVar7 = this.nowTutorial.tutorialPlotDatas) == null)
            throw; // [null/range check failed]
            uVar1 = this.nowTutorialPlotCount;
            if (*(uint32 *)(lVar7 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar7 = lVar7[uVar1];
            if (((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 32)) == null) ||
               (lVar7 = GameObject.GetComponent(lVar7,DAT_181e55c90)) == null) throw; // [null/range check failed]
            uVar8 = RectTransform.get_sizeDelta(lVar7,0);
            goto joined_r0x00018083626f;
          }
        }
        else {
          if (this.highLightRect == null) throw; // [null/range check failed]
          lVar6 = Component.GetComponent(this.highLightRect,DAT_181e782b8);
          uVar8 = Vector2.get_one(0);
          local_res20._0_4_ = (float)uVar8;
          local_res20._4_4_ = (float)((uint64)uVar8 >> 32);
          local_res20 = CONCAT44(local_res20._4_4_ * 0.5,(float)local_res20 * 0.5);
          if (lVar6 == null) throw; // [null/range check failed]
          RectTransform.set_pivot(lVar6,local_res20,0);
          if (this.highLightRect == null) throw; // [null/range check failed]
          lVar6 = Component.GetComponent(this.highLightRect,DAT_181e782b8);
          if ((this.nowTutorial == null) ||
             (lVar7 = this.nowTutorial.tutorialPlotDatas) == null)
          throw; // [null/range check failed]
          uVar1 = this.nowTutorialPlotCount;
          if (*(uint32 *)(lVar7 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar7 = lVar7[uVar1];
          if ((lVar7 == null) || (lVar6 == null)) throw; // [null/range check failed]
          local_68 = *(uint64 *)(lVar7 + 44);
          local_60 = *(uint32 *)(lVar7 + 52);
          Transform.set_localPosition(lVar6,&local_68,0);
          if (this.highLightRect == null) throw; // [null/range check failed]
          lVar6 = Component.GetComponent(this.highLightRect,DAT_181e782b8);
          if ((this.nowTutorial == null) ||
             (lVar7 = this.nowTutorial.tutorialPlotDatas) == null)
          throw; // [null/range check failed]
          uVar1 = this.nowTutorialPlotCount;
          if (*(uint32 *)(lVar7 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar7 = lVar7[uVar1];
          if (lVar7 == null) throw; // [null/range check failed]
          uVar8 = *(uint64 *)(lVar7 + 56);
          local_60 = *(uint32 *)(lVar7 + 64);
          local_68 = uVar8;
        joined_r0x00018083626f:
          if (lVar6 == null) throw; // [null/range check failed]
          RectTransform.set_sizeDelta(lVar6,uVar8,0);
        }
        if ((this.highLightRect == null) ||
           (lVar6 = Component.GetComponent(this.highLightRect,DAT_181e782b8)) == null)
        throw; // [null/range check failed]
        fVar3 = (float)RectTransform.get_sizeDelta(lVar6,0);
        if (fVar3 == 0.0) {
        LAB_1808362ff:
          if ((this.nowTutorial == null) ||
             (lVar6 = this.nowTutorial.tutorialPlotDatas) == null)
          throw; // [null/range check failed]
          uVar1 = this.nowTutorialPlotCount;
          if (lVar6.noAutoFinish <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar6 = lVar6.tutorialName[uVar1];
          if (lVar6 == null) throw; // [null/range check failed]
          *(uint8 *)(lVar6 + 68) = 0;
        }
        else {
          if ((this.highLightRect == null) ||
             (lVar6 = Component.GetComponent(this.highLightRect,DAT_181e782b8)) == null)
          throw; // [null/range check failed]
          RectTransform.get_sizeDelta(lVar6,0);
          if (extraout_var == 0.0) goto LAB_1808362ff;
        }
        if (this.arrow != null) {
          lVar6 = GameObject.GetComponent(this.arrow,DAT_181e55c90);
          if (((this.highLightRect != null) &&
              (lVar7 = Component.GetComponent(this.highLightRect,DAT_181e782b8)) != null)
             && (puVar9 = (uint64 *)Transform.get_position(local_58,lVar7,0), lVar6 != null)) {
            local_68 = *puVar9;
            local_60 = *(uint32 *)(puVar9 + 1);
            Transform.set_position(lVar6,&local_68,0);
            lVar6 = this.arrow;
            if ((this.nowTutorial != null) &&
               (lVar7 = this.nowTutorial.tutorialPlotDatas) != null) {
              uVar1 = this.nowTutorialPlotCount;
              if (*(uint32 *)(lVar7 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar7 = lVar7[uVar1];
              if ((lVar7 != null) && (lVar6 != null)) {
                GameObject.SetActive(lVar6,*(uint8 *)(lVar7 + 68),0);
                if ((this.tutorialTextUI != null) &&
                   ((lVar6 = GameObject.get_transform(this.tutorialTextUI,0), lVar6 != null &&
                    (lVar6 = Transform.Find(lVar6,"Text",0)) != null))) {
                  uVar8 = Component.GetComponent(lVar6,DAT_181e79538);
                  if ((this.nowTutorial != null) &&
                     (lVar6 = this.nowTutorial.tutorialPlotDatas) != null) {
                    uVar1 = this.nowTutorialPlotCount;
                    if (lVar6.noAutoFinish <= uVar1) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar6 = lVar6.tutorialName[uVar1];
                    if ((lVar6 = lVar6?.tutorialName) != null) {
                      uVar4 = String.Replace(lVar6,"\\n","\n",0);
                      LTLocalization.SetText(uVar8,uVar4,0);
                      if (this.tutorialTextUI != null) {
                        uVar8 = GameObject.GetComponent(this.tutorialTextUI,DAT_181e55c90);
                        LayoutRebuilder.ForceRebuildLayoutImmediate(uVar8,0);
                        lVar6 = FUN_1801dfd90(DAT_181e86eb8,4);
                        if ((this.highLightRect != null) &&
                           (lVar7 = Component.GetComponent(this.highLightRect,DAT_181e782b8),
                           lVar7 != null)) {
                          RectTransform.GetWorldCorners(lVar7,lVar6,0);
                          if ((this.highLightRect != null) &&
                             (lVar7 = Component.GetComponent(this.highLightRect,DAT_181e782b8)
                             , lVar7 != null)) {
                            pfVar10 = (float *)Transform.get_position(local_58,lVar7,0);
                            lVar7 = this.highLightRect;
                            if (0.0 < *pfVar10) {
                              if ((lVar7 == null) ||
                                 (lVar7 = Component.GetComponent(lVar7,DAT_181e782b8)) == null)
                              throw; // [null/range check failed]
                              puVar9 = (uint64 *)Transform.get_position(local_58,lVar7,0);
                              uVar8 = *puVar9;
                              local_60 = *(uint32 *)(puVar9 + 1);
                              local_68 = uVar8;
                              if (lVar6 == null) throw; // [null/range check failed]
                              local_68._4_4_ = (float)((uint64)uVar8 >> 32);
                              if (0.0 < local_68._4_4_) {
                                if (lVar6.noAutoFinish < 4) {
                                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                  FUN_1801e02d0(uVar8,0);
                                }
                                uVar14 = (uint32)*(uint64 *)(lVar6 + 68);
                                uVar15 = (uint32)((uint64)*(uint64 *)(lVar6 + 68) >> 32);
                                uVar13 = *(uint32 *)(lVar6 + 76);
                                uVar8 = Vector2.get_one(0);
                                if ((this.arrow == null) ||
                                   (lVar6 = GameObject.get_transform(this.arrow,0),
                                   lVar6 == null)) throw; // [null/range check failed]
                                local_68 = 0xbf800000bf800000;
                              }
                              else {
                                if (lVar6.noAutoFinish < 3) {
                                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                  FUN_1801e02d0(uVar8,0);
                                }
                                uVar14 = (uint32)*(uint64 *)(lVar6 + 56);
                                uVar15 = (uint32)((uint64)*(uint64 *)(lVar6 + 56) >> 32);
                                uVar13 = *(uint32 *)(lVar6 + 64);
                                uVar8 = Vector2.get_right(0);
                                if ((this.arrow == null) ||
                                   (lVar6 = GameObject.get_transform(this.arrow,0),
                                   lVar6 == null)) throw; // [null/range check failed]
                                local_68 = 0x3f800000bf800000;
                              }
                            }
                            else {
                              if ((lVar7 == null) ||
                                 (lVar7 = Component.GetComponent(lVar7,DAT_181e782b8)) == null)
                              throw; // [null/range check failed]
                              puVar9 = (uint64 *)Transform.get_position(local_58,lVar7,0);
                              uVar8 = *puVar9;
                              local_60 = *(uint32 *)(puVar9 + 1);
                              local_68 = uVar8;
                              if (lVar6 == null) throw; // [null/range check failed]
                              local_68._4_4_ = (float)((uint64)uVar8 >> 32);
                              if (0.0 < local_68._4_4_) {
                                if (lVar6.noAutoFinish == null) {
                                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                  FUN_1801e02d0(uVar8,0);
                                }
                                uVar14 = (uint32)lVar6.tutorialPlotDatas;
                                uVar15 = (uint32)((uint64)lVar6.tutorialPlotDatas >> 32);
                                uVar13 = *(uint32 *)(lVar6 + 40);
                                uVar8 = Vector2.get_up(0);
                                if ((this.arrow == null) ||
                                   (lVar6 = GameObject.get_transform(this.arrow,0),
                                   lVar6 == null)) throw; // [null/range check failed]
                                local_68 = 0xbf8000003f800000;
                              }
                              else {
                                if (lVar6.noAutoFinish < 2) {
                                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                  FUN_1801e02d0(uVar8,0);
                                }
                                uVar14 = (uint32)*(uint64 *)(lVar6 + 44);
                                uVar15 = (uint32)((uint64)*(uint64 *)(lVar6 + 44) >> 32);
                                uVar13 = *(uint32 *)(lVar6 + 52);
                                uVar8 = Vector2.get_zero(0);
                                if ((this.arrow == null) ||
                                   (lVar6 = GameObject.get_transform(this.arrow,0),
                                   lVar6 == null)) throw; // [null/range check failed]
                                local_68 = 0x3f8000003f800000;
                              }
                            }
                            local_60 = 0x3f800000;
                            Transform.set_localScale(lVar6,&local_68,0);
                            if ((this.tutorialTextUI != null) &&
                               (lVar6 = GameObject.GetComponent
                                                  (this.tutorialTextUI,DAT_181e55c90),
                               lVar6 != null)) {
                              RectTransform.set_pivot(lVar6,uVar8,0);
                              if (this.tutorialTextUI != null) {
                                lVar6 = GameObject.GetComponent
                                                  (this.tutorialTextUI,DAT_181e55c90);
                                if ((this.tutorialPanel != null) &&
                                   (lVar7 = GameObject.get_transform(this.tutorialPanel,0),
                                   lVar7 != null)) {
                                  local_68 = CONCAT44(uVar15,uVar14);
                                  local_60 = uVar13;
                                  puVar9 = (uint64 *)
                                           Transform.InverseTransformPoint(local_58,lVar7,&local_68,0);
                                  local_68 = *puVar9;
                                  local_60 = *(uint32 *)(puVar9 + 1);
                                  if (lVar6 != null) {
                                    RectTransform.set_anchoredPosition(lVar6,local_68,0);
                                    this.textShowing = 1;
                                    if (this.tutorialTextUI != null) {
                                      lVar6 = GameObject.GetComponent
                                                        (this.tutorialTextUI,DAT_181e55c90);
                                      puVar9 = (uint64 *)Vector3.get_zero(local_58,0);
                                      if (lVar6 != null) {
                                        local_60 = *(uint32 *)(puVar9 + 1);
                                        local_68 = *puVar9;
                                        Transform.set_localScale(lVar6,&local_68,0);
                                        if (this.tutorialTextUI != null) {
                                          uVar8 = GameObject.GetComponent
                                                            (this.tutorialTextUI,DAT_181e55c90);
                                          uVar8 = ShortcutExtensions.DOScale
                                                            (uVar8,0x3f800000,0x3e99999a,0);
                                          uVar8 = TweenSettingsExtensions.SetUpdate
                                                            (uVar8,1,DAT_181ea59e0);
                                          uVar4 = new OnTooltipCB(this,DAT_181ea3a08,0);
                                          TweenSettingsExtensions.OnComplete(uVar8,uVar4,DAT_181ea3dc0);
                                          plVar11 = (int64 *)Resources.Load("Sound/SoundEffect/NoticeLittle",0);
                                          plVar12 = (int64 *)0;
                                          if ((plVar11 != (int64 *)0) && (*plVar11 == DAT_181e8f4a0))
                                          {
                                            plVar12 = plVar11;
                                          }
                                          NGUITools.PlaySound(plVar12,0x3f19999a,0);
                                          return;
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

    // Token : 0x60023CB
    // RVA   : 0x8375F0   Offset: 0x8363F0   Length: 0xE4
    public void TutorialCallPlot(string fucText)
    {
        uint uVar1;
        long lVar2;
        ulong uVar3;
        lVar2 = FUN_1801dfd90(DAT_181e81128,1);
        if (lVar2 != null) {
          if (*(int *)(lVar2 + 24) == 0) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar3,0);
          }
          *(uint16 *)(lVar2 + 32) = 59;
          if (fucText != null) {
            lVar2 = String.Split(fucText,lVar2,0);
            if (lVar2 != null) {
              uVar1 = *(uint32 *)(lVar2 + 24);
              if ((int)uVar1 < 2) {
                Component.SendMessage(this,fucText,0);
                return;
              }
              if (uVar1 != 0) {
                if (1 < uVar1) {
                  Component.SendMessage
                            (this,*(uint64 *)(lVar2 + 32),*(uint64 *)(lVar2 + 40),0);
                  return;
                }
                uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar3,0);
              }
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar3,0);
            }
          }
        }
    }

    // Token : 0x60023CC
    // RVA   : 0x835800   Offset: 0x834600   Length: 0x11
    public void HightLightRectClicked()
    {
        void FUN_180835800(int64 this)
        {
        if (!this.textShowing) {
          TutorialController.ShowNextTutorialPlot(this,0,0);
          return;
        }
    }

    // Token : 0x60023CD
    // RVA   : 0x835420   Offset: 0x834220   Length: 0x8D
    public void BlackBackClicked()
    {
        uint uVar1;
        long lVar2;
        if (this.textShowing) {
          return;
        }
        if ((this.nowTutorial != null) &&
           (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
          uVar1 = this.nowTutorialPlotCount;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2[uVar1];
          if (lVar2 != null) {
            if (*(char *)(lVar2 + 68) != false) {
              return;
            }
            TutorialController.ShowNextTutorialPlot(this,0,0);
            return;
          }
        }
    }

    // Token : 0x60023CE
    // RVA   : 0x8393D0   Offset: 0x8381D0   Length: 0xB3B
    public void TutorialSkillPowerSpeFuc()
    {
        float fVar1;
        uint uVar2;
        bool cVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        long lVar9;
        float fVar10;
        uint[] local_res18 = new uint[2];
        lVar4 = PlotController.LaBaFestivelResultTalkText;
        if ((lVar4 == null) || (lVar4 = *(int64 *)(lVar4 + 0x110)) == null) throw; // [null/range check failed]
        if (*(char *)(lVar4 + 176) != false) {
          lVar4 = PlotController.LaBaFestivelResultTalkText;
          lVar5 = PlotController.LaBaFestivelResultTalkText;
          if ((lVar5 == null) || (lVar4 == null)) throw; // [null/range check failed]
          cVar3 = BattleController.CanPlayerControl(lVar4,*(uint64 *)(lVar5 + 0x110),0);
          if (cVar3) {
            lVar4 = FUN_1802101c0(0);
            if (lVar4 == null) throw; // [null/range check failed]
            BattleController.AutoButtonClicked(lVar4,0);
          }
        }
        lVar4 = 0;
        local_res18[0] = 0;
        lVar5 = PlotController.LaBaFestivelResultTalkText;
        if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 0x110)) == null) ||
           (lVar5 = *(int64 *)(lVar5 + 64)) == null) throw; // [null/range check failed]
        if (*(int64 *)(lVar5 + 0x270) == 0) {
        LAB_18083984a:
          lVar5 = PlotController.LaBaFestivelResultTalkText;
          if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 0x110)) == null) ||
             (lVar5 = *(int64 *)(lVar5 + 64)) == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar5 + 0x280) != 0) {
            lVar5 = PlotController.LaBaFestivelResultTalkText;
            if ((((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 0x110)) == null) ||
                (lVar5 = *(int64 *)(lVar5 + 64)) == null) ||
               (lVar5 = *(int64 *)(lVar5 + 0x280)) == null) throw; // [null/range check failed]
            fVar1 = *(float *)(lVar5 + 100);
            lVar5 = PlotController.LaBaFestivelResultTalkText;
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 0x110)) == null) ||
               ((lVar5 = *(int64 *)(lVar5 + 64), lVar5 == null ||
                (lVar5 = *(int64 *)(lVar5 + 0x280)) == null))) throw; // [null/range check failed]
            fVar10 = (float)KungfuSkillLvData.MaxPower(lVar5,0);
            if (fVar10 <= fVar1) {
              local_res18[0] = 1;
              lVar4 = FUN_1802101c0(0);
              if (((lVar4 == null) || (*(int64 *)(lVar4 + 0x110) == 0)) ||
                 (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 0x110) + 64)) == null)
              throw; // [null/range check failed]
              lVar4 = *(int64 *)(lVar4 + 0x280);
              goto LAB_180839c19;
            }
          }
          lVar5 = PlotController.LaBaFestivelResultTalkText;
          if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 0x110)) == null) ||
             (lVar5 = *(int64 *)(lVar5 + 64)) == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar5 + 0x290) != 0) {
            lVar5 = FUN_1802101c0(0);
            if (((lVar5 == null) || (*(int64 *)(lVar5 + 0x110) == 0)) ||
               ((lVar5 = *(int64 *)(*(int64 *)(lVar5 + 0x110) + 64), lVar5 == null ||
                (lVar5 = *(int64 *)(lVar5 + 0x290)) == null))) throw; // [null/range check failed]
            fVar1 = *(float *)(lVar5 + 100);
            lVar5 = FUN_1802101c0(0);
            if ((((lVar5 == null) || (*(int64 *)(lVar5 + 0x110) == 0)) ||
                (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 0x110) + 64)) == null) ||
               (lVar5 = *(int64 *)(lVar5 + 0x290)) == null) throw; // [null/range check failed]
            fVar10 = (float)KungfuSkillLvData.MaxPower(lVar5,0);
            if (fVar10 <= fVar1) {
              local_res18[0] = 2;
              lVar4 = FUN_1802101c0(0);
              if (((lVar4 == null) || (*(int64 *)(lVar4 + 0x110) == 0)) ||
                 (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 0x110) + 64)) == null)
              throw; // [null/range check failed]
              lVar4 = *(int64 *)(lVar4 + 0x290);
            }
          }
        }
        else {
          lVar5 = PlotController.LaBaFestivelResultTalkText;
          if ((((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 0x110)) == null) ||
              (lVar5 = *(int64 *)(lVar5 + 64)) == null) ||
             (lVar5 = *(int64 *)(lVar5 + 0x270)) == null) throw; // [null/range check failed]
          fVar1 = *(float *)(lVar5 + 100);
          lVar5 = PlotController.LaBaFestivelResultTalkText;
          if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 0x110)) == null) ||
             ((lVar5 = *(int64 *)(lVar5 + 64), lVar5 == null ||
              (lVar5 = *(int64 *)(lVar5 + 0x270)) == null))) throw; // [null/range check failed]
          fVar10 = (float)KungfuSkillLvData.MaxPower(lVar5,0);
          if (fVar1 < fVar10) goto LAB_18083984a;
          lVar4 = FUN_1802101c0(0);
          if (((lVar4 == null) || (*(int64 *)(lVar4 + 0x110) == 0)) ||
             (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 0x110) + 64)) == null) throw; // [null/range check failed]
          lVar4 = *(int64 *)(lVar4 + 0x270);
        }
        LAB_180839c19:
        lVar5 = PlotController.LaBaFestivelResultTalkText;
        if ((lVar5 != null) && (lVar5 = *(int64 *)(lVar5 + 0x130)) != null) {
          lVar5 = Transform.Find(lVar5,"BaseSkillGrid",0);
          uVar6 = Int32.ToString(local_res18,0);
          uVar6 = String.Concat("Skill",uVar6,0);
          if ((lVar5 != null) &&
             ((lVar5 = Transform.Find(lVar5,uVar6,0), lVar5 != null &&
              (lVar5 = Transform.Find(lVar5,"SkillIcon",0)) != null))) {
            uVar6 = Component.get_gameObject(lVar5,0);
            cVar3 = Object.op_Inequality(uVar6,0,0);
            if (!cVar3) {
              return;
            }
            lVar5 = this.nowTutorial;
            if ((lVar5 != null) && (lVar9 = lVar5.tutorialPlotDatas) != null) {
              uVar2 = *(uint32 *)(lVar9 + 24);
              if (uVar2 - 1 < uVar2) {
                lVar9 = *(int64 *)(*(int64 *)(lVar9 + 16) + 24 + (int64)(int)uVar2 * 8);
              }
              else {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                lVar5 = this.nowTutorial;
                lVar9 = *(int64 *)(*(int64 *)(lVar9 + 16) + 24 + (int64)(int)uVar2 * 8);
                if (lVar5 == null) throw; // [null/range check failed]
              }
              lVar5 = lVar5.tutorialPlotDatas;
              if (lVar5 != null) {
                uVar2 = lVar5.noAutoFinish;
                if (uVar2 <= uVar2 - 1) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar5 = *(int64 *)(lVar5.tutorialName + 24 + (int64)(int)uVar2 * 8);
                if ((((lVar5 != null) && (lVar5 = lVar5.tutorialName, lVar4 != null)) &&
                    (uVar7 = KungfuSkillLvData.Name(lVar4,1,0), lVar5 != null)) &&
                   (uVar7 = String.Replace(lVar5,"#ActiveSkillName#",uVar7,0), lVar9 != null)) {
                  *(uint64 *)(lVar9 + 16) = uVar7;
                  if ((this.nowTutorial != null) &&
                     (lVar4 = this.nowTutorial.tutorialPlotDatas) != null) {
                    uVar2 = *(uint32 *)(lVar4 + 24);
                    if (uVar2 <= uVar2 - 1) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 24 + (int64)(int)uVar2 * 8);
                    if (lVar4 != null) {
                      puVar8 = (uint64 *)(lVar4 + 32);
                      *puVar8 = uVar6;
                      il2cpp_internal(puVar8,uVar6);
                      if ((this.nowTutorial != null) &&
                         (lVar4 = this.nowTutorial.tutorialPlotDatas) != null) {
                        uVar2 = *(uint32 *)(lVar4 + 24);
                        if (uVar2 <= uVar2 - 1) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar4 = *(int64 *)
                                 (*(int64 *)(lVar4 + 16) + 24 + (int64)(int)uVar2 * 8);
                        if (lVar4 != null) {
                          *(uint8 *)(lVar4 + 68) = 1;
                          if ((this.nowTutorial != null) &&
                             (lVar4 = this.nowTutorial.tutorialPlotDatas) != null) {
                            uVar2 = *(uint32 *)(lVar4 + 24);
                            if (uVar2 <= uVar2 - 1) {
                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                            }
                            lVar4 = *(int64 *)
                                     (*(int64 *)(lVar4 + 16) + 24 + (int64)(int)uVar2 * 8);
                            if (lVar4 != null) {
                              puVar8 = (uint64 *)(lVar4 + 72);
                              *puVar8 = uVar6;
                              il2cpp_internal(puVar8,uVar6);
                              return;
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

    // Token : 0x60023CF
    // RVA   : 0x8376E0   Offset: 0x8364E0   Length: 0x2DC
    public GameObject TutorialFindBuildingButton(string targetBuilding)
    {
        bool cVar1;
        int iVar2;
        long lVar3;
        ulong uVar5;
        int iVar6;
        iVar6 = 0;
        while( true ) {
          lVar3 = *(int64 *)(*(int64 *)(DAT_181e8c8b0 + 184) + 56);
          if ((((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 128)) == null) ||
              (lVar3 = GameObject.get_transform(lVar3,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"BuildQuickButtonGrid",0)) == null) throw; // [null/range check failed]
          iVar2 = Transform.get_childCount(lVar3,0);
          if (iVar2 <= iVar6) {
            return 0;
          }
          lVar3 = FUN_180210060(0);
          if (((lVar3 == null) || (*(int64 *)(lVar3 + 128) == 0)) ||
             ((lVar3 = GameObject.get_transform(*(int64 *)(lVar3 + 128),0), lVar3 == null ||
              ((lVar3 = Transform.Find(lVar3,"BuildQuickButtonGrid",0), lVar3 == null ||
               (lVar3 = Transform.GetChild(lVar3,iVar6,0)) == null))))) throw; // [null/range check failed]
          lVar3 = Transform.Find(lVar3,"Text",0);
          if ((lVar3 == null) ||
             (plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181e79538), plVar4 == (int64 *)0
             )) throw; // [null/range check failed]
          uVar5 = (**(code **)(*plVar4 + 0x5d8))(plVar4,*(uint64 *)(*plVar4 + 0x5e0));
          LTLocalization.GetText(targetBuilding,0,1,0);
          cVar1 = FUN_1816387f0(uVar5);
          if (cVar1) break;
          iVar6 = iVar6 + 1;
        }
        lVar3 = FUN_180210060(0);
        if ((((lVar3 != null) && (*(int64 *)(lVar3 + 128) != 0)) &&
            (lVar3 = GameObject.get_transform(*(int64 *)(lVar3 + 128),0)) != null) &&
           ((lVar3 = Transform.Find(lVar3,"BuildQuickButtonGrid",0), lVar3 != null &&
            (lVar3 = Transform.GetChild(lVar3,iVar6,0)) != null))) {
          uVar5 = Component.get_gameObject(lVar3,0);
          return uVar5;
        }
    }

    // Token : 0x60023D0
    // RVA   : 0x8379C0   Offset: 0x8367C0   Length: 0x276
    public GameObject TutorialFindBuildingChoiceButton(string targetBuilding)
    {
        uint64
        TutorialController.TutorialFindBuildingChoiceButton(uint64 this,uint64 targetBuilding)
        {
        char cVar1;
        int iVar2;
        int64 lVar3;
        int64 *plVar4;
        uint64 uVar5;
        int iVar6;
        iVar6 = 0;
        while( true ) {
          lVar3 = *(int64 *)(*(int64 *)(DAT_181e942d8 + 184) + 8);
          if (((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 32)) == null) ||
             (lVar3 = GameObject.get_transform(lVar3,0)) == null) throw; // [null/range check failed]
          iVar2 = Transform.get_childCount(lVar3,0);
          if (iVar2 <= iVar6) {
            return 0;
          }
          lVar3 = FUN_1802102e0(0);
          if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
             ((lVar3 = GameObject.get_transform(*(int64 *)(lVar3 + 32),0), lVar3 == null ||
              (lVar3 = Transform.GetChild(lVar3,iVar6,0)) == null))) throw; // [null/range check failed]
          lVar3 = Transform.Find(lVar3,"Text",0);
          if ((lVar3 == null) ||
             (plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181e79538), plVar4 == (int64 *)0
             )) throw; // [null/range check failed]
          uVar5 = (**(code **)(*plVar4 + 0x5d8))(plVar4,*(uint64 *)(*plVar4 + 0x5e0));
          LTLocalization.GetText(targetBuilding,0,1,0);
          cVar1 = FUN_1816387f0(uVar5);
          if (cVar1) break;
          iVar6 = iVar6 + 1;
        }
        lVar3 = FUN_1802102e0(0);
        if ((((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
            (lVar3 = GameObject.get_transform(*(int64 *)(lVar3 + 32),0)) != null) &&
           (lVar3 = Transform.GetChild(lVar3,iVar6,0)) != null) {
          uVar5 = Component.get_gameObject(lVar3,0);
          return uVar5;
        }
    }

    // Token : 0x60023D1
    // RVA   : 0x835820   Offset: 0x834620   Length: 0x4C
    public void SetTutorialNoLeaveBuilding(string param)
    {
        byte uVar1;
        uVar1 = FUN_1816387f0(param,"true",0);
        this.tutorialNoLeaveBuilding = uVar1;
    }

    // Token : 0x60023D2
    // RVA   : 0x83B990   Offset: 0x83A790   Length: 0x16B
    public void TutorialStartReadBookFindBuilding()
    {
        uint uVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        uVar4 = TutorialController.TutorialFindBuildingButton(this,"藏经阁",0);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          return;
        }
        if ((this.nowTutorial != null) &&
           (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
          uVar1 = this.nowTutorialPlotCount;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2[uVar1];
          if (lVar2 != null) {
            puVar5 = (uint64 *)(lVar2 + 32);
            *puVar5 = uVar4;
            il2cpp_internal(puVar5,uVar4);
            if ((this.nowTutorial != null) &&
               (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
              uVar1 = this.nowTutorialPlotCount;
              if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = lVar2[uVar1];
              if (lVar2 != null) {
                *(uint8 *)(lVar2 + 68) = 1;
                if ((this.nowTutorial != null) &&
                   (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
                  uVar1 = this.nowTutorialPlotCount;
                  if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar2 = lVar2[uVar1];
                  if (lVar2 != null) {
                    puVar5 = (uint64 *)(lVar2 + 72);
                    *puVar5 = uVar4;
                    il2cpp_internal(puVar5,uVar4);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60023D3
    // RVA   : 0x83AF90   Offset: 0x839D90   Length: 0xDE
    public void TutorialStartLeaderFindBuilding()
    {
        uint uVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        uVar4 = TutorialController.TutorialFindBuildingButton(this,"藏经阁",0);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          return;
        }
        if ((this.nowTutorial != null) &&
           (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
          uVar1 = this.nowTutorialPlotCount;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2[uVar1];
          if (lVar2 != null) {
            puVar5 = (uint64 *)(lVar2 + 32);
            *puVar5 = uVar4;
            il2cpp_internal(puVar5,uVar4);
            return;
          }
        }
    }

    // Token : 0x60023D4
    // RVA   : 0x83B820   Offset: 0x83A620   Length: 0x16B
    public void TutorialStartReadBookFindBuildingChoice()
    {
        uint uVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        uVar4 = TutorialController.TutorialFindBuildingChoiceButton(this,"阅读藏书",0);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          return;
        }
        if ((this.nowTutorial != null) &&
           (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
          uVar1 = this.nowTutorialPlotCount;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2[uVar1];
          if (lVar2 != null) {
            puVar5 = (uint64 *)(lVar2 + 32);
            *puVar5 = uVar4;
            il2cpp_internal(puVar5,uVar4);
            if ((this.nowTutorial != null) &&
               (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
              uVar1 = this.nowTutorialPlotCount;
              if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = lVar2[uVar1];
              if (lVar2 != null) {
                *(uint8 *)(lVar2 + 68) = 1;
                if ((this.nowTutorial != null) &&
                   (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
                  uVar1 = this.nowTutorialPlotCount;
                  if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar2 = lVar2[uVar1];
                  if (lVar2 != null) {
                    puVar5 = (uint64 *)(lVar2 + 72);
                    *puVar5 = uVar4;
                    il2cpp_internal(puVar5,uVar4);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60023D5
    // RVA   : 0x83BB00   Offset: 0x83A900   Length: 0x16B
    public void TutorialStartReadSelfBookFindBuildingChoice()
    {
        uint uVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        uVar4 = TutorialController.TutorialFindBuildingChoiceButton(this,"阅读秘籍",0);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          return;
        }
        if ((this.nowTutorial != null) &&
           (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
          uVar1 = this.nowTutorialPlotCount;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2[uVar1];
          if (lVar2 != null) {
            puVar5 = (uint64 *)(lVar2 + 32);
            *puVar5 = uVar4;
            il2cpp_internal(puVar5,uVar4);
            if ((this.nowTutorial != null) &&
               (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
              uVar1 = this.nowTutorialPlotCount;
              if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = lVar2[uVar1];
              if (lVar2 != null) {
                *(uint8 *)(lVar2 + 68) = 1;
                if ((this.nowTutorial != null) &&
                   (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
                  uVar1 = this.nowTutorialPlotCount;
                  if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar2 = lVar2[uVar1];
                  if (lVar2 != null) {
                    puVar5 = (uint64 *)(lVar2 + 72);
                    *puVar5 = uVar4;
                    il2cpp_internal(puVar5,uVar4);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60023D6
    // RVA   : 0x83D390   Offset: 0x83C190   Length: 0x16B
    public void TutorialStartWriteBookFindBuildingChoice()
    {
        uint uVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        uVar4 = TutorialController.TutorialFindBuildingChoiceButton(this,"编纂秘籍",0);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          return;
        }
        if ((this.nowTutorial != null) &&
           (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
          uVar1 = this.nowTutorialPlotCount;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2[uVar1];
          if (lVar2 != null) {
            puVar5 = (uint64 *)(lVar2 + 32);
            *puVar5 = uVar4;
            il2cpp_internal(puVar5,uVar4);
            if ((this.nowTutorial != null) &&
               (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
              uVar1 = this.nowTutorialPlotCount;
              if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = lVar2[uVar1];
              if (lVar2 != null) {
                *(uint8 *)(lVar2 + 68) = 1;
                if ((this.nowTutorial != null) &&
                   (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
                  uVar1 = this.nowTutorialPlotCount;
                  if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar2 = lVar2[uVar1];
                  if (lVar2 != null) {
                    puVar5 = (uint64 *)(lVar2 + 72);
                    *puVar5 = uVar4;
                    il2cpp_internal(puVar5,uVar4);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60023D7
    // RVA   : 0x83B310   Offset: 0x83A110   Length: 0x50A
    public void TutorialStartReadBookFindBook()
    {
        var pStatics = *(int64*)(DAT_181e92b00 + 184);
        uint uVar1;
        bool cVar2;
        int iVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar7;
        uVar5 = 0;
        this.tutorialNoLeaveBuilding = 1;
        uVar7 = uVar5;
        while( true ) {
          if (((((*pStatics == 0) ||
                (lVar4 = *(int64 *)(*pStatics + 40)) == null) ||
               (lVar4 = GameObject.get_transform(lVar4,0)) == null) ||
              ((lVar4 = Transform.Find(lVar4,"Grid",0), lVar4 == null ||
               (lVar4 = Transform.Find(lVar4,"0",0)) == null))) ||
             ((lVar4 = Transform.Find(lVar4,"Scroll View",0), lVar4 == null ||
              ((lVar4 = Transform.Find(lVar4,"Viewport",0), lVar4 == null ||
               (lVar4 = Transform.Find(lVar4,"Content",0)) == null))))) throw; // [null/range check failed]
          iVar3 = Transform.get_childCount(lVar4,0);
          if (iVar3 <= (int)uVar7) goto LAB_18083b70f;
          if ((((((*pStatics == 0) ||
                 (lVar4 = *(int64 *)(*pStatics + 40)) == null) ||
                (lVar4 = GameObject.get_transform(lVar4,0)) == null) ||
               (((lVar4 = Transform.Find(lVar4,"Grid",0), lVar4 == null ||
                 (lVar4 = Transform.Find(lVar4,"0",0)) == null) ||
                ((lVar4 = Transform.Find(lVar4,"Scroll View",0), lVar4 == null ||
                 ((lVar4 = Transform.Find(lVar4,"Viewport",0), lVar4 == null ||
                  (lVar4 = Transform.Find(lVar4,"Content",0)) == null))))))) ||
              ((lVar4 = Transform.GetChild(lVar4,uVar7), lVar4 == null ||
               (((lVar4 = Transform.Find(lVar4,"BookIcon",0), lVar4 == null ||
                 (lVar4 = Transform.GetChild(lVar4,0)) == null) ||
                (lVar4 = Component.GetComponent(lVar4,DAT_181e77938)) == null))))) ||
             (*(int64 *)(lVar4 + 32) == 0)) throw; // [null/range check failed]
          cVar2 = FUN_1816387f0(*(uint64 *)(*(int64 *)(lVar4 + 32) + 32));
          if (cVar2) break;
          uVar7 = (uint64)((int)uVar7 + 1);
        }
        lVar4 = FUN_180830db0(0);
        if (((lVar4 != null) && (*(int64 *)(lVar4 + 40) != 0)) &&
           ((((lVar4 = GameObject.get_transform(*(int64 *)(lVar4 + 40),0), lVar4 != null &&
              ((lVar4 = Transform.Find(lVar4,"Grid",0), lVar4 != null &&
               (lVar4 = Transform.Find(lVar4,"0",0)) != null))) &&
             (lVar4 = Transform.Find(lVar4,"Scroll View",0)) != null) &&
            ((((lVar4 = Transform.Find(lVar4,"Viewport",0), lVar4 != null &&
               (lVar4 = Transform.Find(lVar4,"Content",0)) != null) &&
              (lVar4 = Transform.GetChild(lVar4,uVar7,0)) != null) &&
             ((lVar4 = Transform.Find(lVar4,"BookIcon",0), lVar4 != null &&
              (lVar4 = Transform.GetChild(lVar4,0,0)) != null))))))) {
          uVar5 = Component.get_gameObject(lVar4,0);
        LAB_18083b70f:
          cVar2 = Object.op_Inequality(uVar5,0,0);
          if (!cVar2) {
            return;
          }
          if ((this.nowTutorial != null) &&
             (lVar4 = this.nowTutorial.tutorialPlotDatas) != null) {
            uVar1 = this.nowTutorialPlotCount;
            if (*(uint32 *)(lVar4 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = lVar4[uVar1];
            if (lVar4 != null) {
              puVar6 = (uint64 *)(lVar4 + 32);
              *puVar6 = uVar5;
              il2cpp_internal(puVar6,uVar5);
              if ((this.nowTutorial != null) &&
                 (lVar4 = this.nowTutorial.tutorialPlotDatas) != null) {
                uVar1 = this.nowTutorialPlotCount;
                if (*(uint32 *)(lVar4 + 24) <= uVar1) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar4 = lVar4[uVar1];
                if (lVar4 != null) {
                  *(uint8 *)(lVar4 + 68) = 1;
                  if ((this.nowTutorial != null) &&
                     (lVar4 = this.nowTutorial.tutorialPlotDatas) != null) {
                    uVar1 = this.nowTutorialPlotCount;
                    if (*(uint32 *)(lVar4 + 24) <= uVar1) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar4 = lVar4[uVar1];
                    if (lVar4 != null) {
                      puVar6 = (uint64 *)(lVar4 + 72);
                      *puVar6 = uVar5;
                      il2cpp_internal(puVar6,uVar5);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60023D8
    // RVA   : 0x83C5C0   Offset: 0x83B3C0   Length: 0x16B
    public void TutorialStartStudyFightFindBuilding()
    {
        uint uVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        uVar4 = TutorialController.TutorialFindBuildingButton(this,"练武场",0);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          return;
        }
        if ((this.nowTutorial != null) &&
           (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
          uVar1 = this.nowTutorialPlotCount;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2[uVar1];
          if (lVar2 != null) {
            puVar5 = (uint64 *)(lVar2 + 32);
            *puVar5 = uVar4;
            il2cpp_internal(puVar5,uVar4);
            if ((this.nowTutorial != null) &&
               (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
              uVar1 = this.nowTutorialPlotCount;
              if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = lVar2[uVar1];
              if (lVar2 != null) {
                *(uint8 *)(lVar2 + 68) = 1;
                if ((this.nowTutorial != null) &&
                   (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
                  uVar1 = this.nowTutorialPlotCount;
                  if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar2 = lVar2[uVar1];
                  if (lVar2 != null) {
                    puVar5 = (uint64 *)(lVar2 + 72);
                    *puVar5 = uVar4;
                    il2cpp_internal(puVar5,uVar4);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60023D9
    // RVA   : 0x83C450   Offset: 0x83B250   Length: 0x16F
    public void TutorialStartStudyFightFindBuildingChoice()
    {
        uint uVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        this.tutorialNoLeaveBuilding = 1;
        uVar4 = TutorialController.TutorialFindBuildingChoiceButton(this,"练习",0);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          return;
        }
        if ((this.nowTutorial != null) &&
           (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
          uVar1 = this.nowTutorialPlotCount;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2[uVar1];
          if (lVar2 != null) {
            puVar5 = (uint64 *)(lVar2 + 32);
            *puVar5 = uVar4;
            il2cpp_internal(puVar5,uVar4);
            if ((this.nowTutorial != null) &&
               (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
              uVar1 = this.nowTutorialPlotCount;
              if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = lVar2[uVar1];
              if (lVar2 != null) {
                *(uint8 *)(lVar2 + 68) = 1;
                if ((this.nowTutorial != null) &&
                   (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
                  uVar1 = this.nowTutorialPlotCount;
                  if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar2 = lVar2[uVar1];
                  if (lVar2 != null) {
                    puVar5 = (uint64 *)(lVar2 + 72);
                    *puVar5 = uVar4;
                    il2cpp_internal(puVar5,uVar4);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60023DA
    // RVA   : 0x83C730   Offset: 0x83B530   Length: 0x1AF
    public void TutorialStartStudyFightFindPlotChoice()
    {
        uint uVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        TutorialController.TutorialQuickShowPlot(this,0);
        if ((this.nowTutorial != null) &&
           (lVar3 = this.nowTutorial.tutorialPlotDatas) != null) {
          uVar2 = this.nowTutorialPlotCount;
          if (*(uint32 *)(lVar3 + 24) <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar3 = lVar3[uVar2];
          if (lVar3 != null) {
            *(uint8 *)(lVar3 + 68) = 1;
            if ((this.nowTutorial != null) &&
               (lVar3 = this.nowTutorial.tutorialPlotDatas) != null) {
              uVar2 = this.nowTutorialPlotCount;
              if (*(uint32 *)(lVar3 + 24) <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar3 = lVar3[uVar2];
              lVar4 = *(int64 *)(*(int64 *)(DAT_181e71f68 + 184) + 24);
              if ((lVar4 != null) && (lVar4 = *(int64 *)(lVar4 + 32)) != null) {
                lVar4 = GameObject.get_transform(lVar4,0);
                if (lVar4 != null) {
                  lVar4 = Transform.Find(lVar4,"InteractGrid",0);
                  if (lVar4 != null) {
                    lVar4 = Transform.GetChild(lVar4,0,0);
                    if (lVar4 != null) {
                      uVar5 = Component.get_gameObject(lVar4,0);
                      if (lVar3 != null) {
                        puVar1 = (uint64 *)(lVar3 + 72);
                        *puVar1 = uVar5;
                        il2cpp_internal(puVar1,uVar5);
                        return;
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60023DB
    // RVA   : 0x83C8E0   Offset: 0x83B6E0   Length: 0x43E
    public void TutorialStartStudyFightFindSkillChoice()
    {
        var pStatics = *(int64*)(DAT_181e977e8 + 184);
        uint uVar1;
        bool cVar2;
        int iVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        ulong uVar8;
        if (((*pStatics != 0) &&
            (lVar4 = *(int64 *)(*pStatics + 24)) != null) &&
           (lVar4 = GameObject.get_transform(lVar4,0)) != null) {
          uVar5 = Transform.Find(lVar4,"ChoosePanelRoot",0);
          DOTween.Complete(uVar5,1,0);
          uVar6 = 0;
          uVar8 = uVar6;
          while( true ) {
            if (((*pStatics == 0) ||
                (lVar4 = *(int64 *)(*pStatics + 32)) == null) ||
               ((lVar4 = GameObject.get_transform(lVar4,0), lVar4 == null ||
                ((lVar4 = Transform.Find(lVar4,"Viewport",0), lVar4 == null ||
                 (lVar4 = Transform.Find(lVar4,"Content",0)) == null))))) throw; // [null/range check failed]
            iVar3 = Transform.get_childCount(lVar4,0);
            if (iVar3 <= (int)uVar8) goto LAB_18083cc13;
            if ((((((*pStatics == 0) ||
                   (lVar4 = *(int64 *)(*pStatics + 32)) == null) ||
                  (lVar4 = GameObject.get_transform(lVar4,0)) == null) ||
                 ((lVar4 = Transform.Find(lVar4,"Viewport",0), lVar4 == null ||
                  (lVar4 = Transform.Find(lVar4,"Content",0)) == null))) ||
                ((lVar4 = Transform.GetChild(lVar4,uVar8), lVar4 == null ||
                 ((lVar4 = Component.GetComponent(lVar4,DAT_181e78e38), lVar4 == null ||
                  (*(int64 *)(lVar4 + 32) == 0)))))) ||
               (lVar4 = KungfuSkillLvData.DataBase(*(int64 *)(lVar4 + 32),0)) == null)
            throw; // [null/range check failed]
            cVar2 = FUN_1816387f0(*(uint64 *)(lVar4 + 32));
            if (cVar2) break;
            uVar8 = (uint64)((int)uVar8 + 1);
          }
          lVar4 = FUN_1802103a0(0);
          if (((((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) &&
               (lVar4 = GameObject.get_transform(*(int64 *)(lVar4 + 32),0)) != null) &&
              ((lVar4 = Transform.Find(lVar4,"Viewport",0), lVar4 != null &&
               (lVar4 = Transform.Find(lVar4,"Content",0)) != null))) &&
             (lVar4 = Transform.GetChild(lVar4,uVar8,0)) != null) {
            uVar6 = Component.get_gameObject(lVar4,0);
        LAB_18083cc13:
            cVar2 = Object.op_Inequality(uVar6,0,0);
            if (!cVar2) {
              return;
            }
            if ((this.nowTutorial != null) &&
               (lVar4 = this.nowTutorial.tutorialPlotDatas) != null) {
              uVar1 = this.nowTutorialPlotCount;
              if (*(uint32 *)(lVar4 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar4 = lVar4[uVar1];
              if (lVar4 != null) {
                puVar7 = (uint64 *)(lVar4 + 32);
                *puVar7 = uVar6;
                il2cpp_internal(puVar7,uVar6);
                if ((this.nowTutorial != null) &&
                   (lVar4 = this.nowTutorial.tutorialPlotDatas) != null) {
                  uVar1 = this.nowTutorialPlotCount;
                  if (*(uint32 *)(lVar4 + 24) <= uVar1) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar4 = lVar4[uVar1];
                  if (lVar4 != null) {
                    *(uint8 *)(lVar4 + 68) = 1;
                    if ((this.nowTutorial != null) &&
                       (lVar4 = this.nowTutorial.tutorialPlotDatas) != null) {
                      uVar1 = this.nowTutorialPlotCount;
                      if (*(uint32 *)(lVar4 + 24) <= uVar1) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar4 = lVar4[uVar1]
                      ;
                      if (lVar4 != null) {
                        puVar7 = (uint64 *)(lVar4 + 72);
                        *puVar7 = uVar6;
                        il2cpp_internal(puVar7,uVar6);
                        return;
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60023DC
    // RVA   : 0x838CC0   Offset: 0x837AC0   Length: 0x180
    public void TutorialForceMissionFindBuilding()
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        int iVar5;
        uint uVar6;
        uVar2 = TutorialController.TutorialFindBuildingButton(this,"钱庄",0);
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (!cVar1) {
          return;
        }
        iVar5 = 0;
        while ((this.nowTutorial != null &&
               (lVar3 = this.nowTutorial.tutorialPlotDatas) != null)) {
          uVar6 = this.nowTutorialPlotCount + iVar5;
          if (*(uint32 *)(lVar3 + 24) <= uVar6) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar3 = lVar3[uVar6];
          if (lVar3 == null) break;
          puVar4 = (uint64 *)(lVar3 + 32);
          *puVar4 = uVar2;
          il2cpp_internal(puVar4,uVar2);
          if (iVar5 == 1) {
            if (((this.nowTutorial != null) &&
                (lVar3 = this.nowTutorial.tutorialPlotDatas) != null) &&
               (lVar3 = FUN_1800024b0(lVar3,this.nowTutorialPlotCount + 1,DAT_181e8a8f0)) != null) {
              *(uint8 *)(lVar3 + 68) = 1;
              if (((this.nowTutorial != null) &&
                  (lVar3 = this.nowTutorial.tutorialPlotDatas) != null) &&
                 (lVar3 = FUN_1800024b0(lVar3,this.nowTutorialPlotCount + 1,DAT_181e8a8f0)) != null) {
                *(uint64 *)(lVar3 + 72) = uVar2;
                return;
              }
            }
            break;
          }
          iVar5 = iVar5 + 1;
          if (1 < iVar5) {
            return;
          }
        }
    }

    // Token : 0x60023DD
    // RVA   : 0x838B90   Offset: 0x837990   Length: 0x124
    public void TutorialForceMissionFindBuildingChoice()
    {
        uint uVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        uVar4 = TutorialController.TutorialFindBuildingChoiceButton(this,"经营",0);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          return;
        }
        if ((this.nowTutorial != null) &&
           (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
          uVar1 = this.nowTutorialPlotCount;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2[uVar1];
          if (lVar2 != null) {
            *(uint8 *)(lVar2 + 68) = 1;
            if ((this.nowTutorial != null) &&
               (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
              uVar1 = this.nowTutorialPlotCount;
              if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = lVar2[uVar1];
              if (lVar2 != null) {
                puVar5 = (uint64 *)(lVar2 + 72);
                *puVar5 = uVar4;
                il2cpp_internal(puVar5,uVar4);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60023DE
    // RVA   : 0x83A320   Offset: 0x839120   Length: 0x124
    public void TutorialStartBreakThroughFindBuildingChoice()
    {
        uint uVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        uVar4 = TutorialController.TutorialFindBuildingChoiceButton(this,"突破",0);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          return;
        }
        if ((this.nowTutorial != null) &&
           (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
          uVar1 = this.nowTutorialPlotCount;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2[uVar1];
          if (lVar2 != null) {
            *(uint8 *)(lVar2 + 68) = 1;
            if ((this.nowTutorial != null) &&
               (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
              uVar1 = this.nowTutorialPlotCount;
              if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = lVar2[uVar1];
              if (lVar2 != null) {
                puVar5 = (uint64 *)(lVar2 + 72);
                *puVar5 = uVar4;
                il2cpp_internal(puVar5,uVar4);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60023DF
    // RVA   : 0x83A450   Offset: 0x839250   Length: 0x1AF
    public void TutorialStartBreakThroughFindPlotChoice()
    {
        uint uVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        TutorialController.TutorialQuickShowPlot(this,0);
        if ((this.nowTutorial != null) &&
           (lVar3 = this.nowTutorial.tutorialPlotDatas) != null) {
          uVar2 = this.nowTutorialPlotCount;
          if (*(uint32 *)(lVar3 + 24) <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar3 = lVar3[uVar2];
          if (lVar3 != null) {
            *(uint8 *)(lVar3 + 68) = 1;
            if ((this.nowTutorial != null) &&
               (lVar3 = this.nowTutorial.tutorialPlotDatas) != null) {
              uVar2 = this.nowTutorialPlotCount;
              if (*(uint32 *)(lVar3 + 24) <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar3 = lVar3[uVar2];
              lVar4 = *(int64 *)(*(int64 *)(DAT_181e71f68 + 184) + 24);
              if ((lVar4 != null) && (lVar4 = *(int64 *)(lVar4 + 32)) != null) {
                lVar4 = GameObject.get_transform(lVar4,0);
                if (lVar4 != null) {
                  lVar4 = Transform.Find(lVar4,"InteractGrid",0);
                  if (lVar4 != null) {
                    lVar4 = Transform.GetChild(lVar4,0,0);
                    if (lVar4 != null) {
                      uVar5 = Component.get_gameObject(lVar4,0);
                      if (lVar3 != null) {
                        puVar1 = (uint64 *)(lVar3 + 72);
                        *puVar1 = uVar5;
                        il2cpp_internal(puVar1,uVar5);
                        return;
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60023E0
    // RVA   : 0x83A600   Offset: 0x839400   Length: 0x5CF
    public void TutorialStartBreakThroughFindSkillChoice()
    {
        var pStatics = *(int64*)(DAT_181e977e8 + 184);
        uint uVar1;
        bool cVar2;
        int iVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        ulong uVar8;
        if (((*pStatics != 0) &&
            (lVar4 = *(int64 *)(*pStatics + 24)) != null) &&
           (lVar4 = GameObject.get_transform(lVar4,0)) != null) {
          uVar5 = Transform.Find(lVar4,"ChoosePanelRoot",0);
          DOTween.Complete(uVar5,1,0);
          uVar8 = 0;
          uVar6 = uVar8;
          while( true ) {
            if (((*pStatics == 0) ||
                (lVar4 = *(int64 *)(*pStatics + 32)) == null) ||
               ((lVar4 = GameObject.get_transform(lVar4,0), lVar4 == null ||
                ((lVar4 = Transform.Find(lVar4,"Viewport",0), lVar4 == null ||
                 (lVar4 = Transform.Find(lVar4,"Content",0)) == null))))) throw; // [null/range check failed]
            iVar3 = Transform.get_childCount(lVar4,0);
            if (iVar3 <= (int)uVar8) break;
            if ((((((*pStatics == 0) ||
                   (lVar4 = *(int64 *)(*pStatics + 32)) == null) ||
                  (lVar4 = GameObject.get_transform(lVar4,0)) == null) ||
                 (((lVar4 = Transform.Find(lVar4,"Viewport"), lVar4 == null ||
                   (lVar4 = Transform.Find(lVar4,"Content")) == null) ||
                  ((lVar4 = Transform.GetChild(lVar4,uVar8), lVar4 == null ||
                   ((lVar4 = Component.get_gameObject(lVar4,0), lVar4 == null ||
                    (lVar4 = GameObject.GetComponent(lVar4,DAT_181e568c8)) == null))))))) ||
                (*(int64 *)(lVar4 + 32) == 0)) ||
               (lVar4 = KungfuSkillLvData.DataBase(*(int64 *)(lVar4 + 32),0)) == null)
            throw; // [null/range check failed]
            cVar2 = FUN_1816387f0(*(uint64 *)(lVar4 + 32));
            if (cVar2) {
              lVar4 = FUN_1802103a0(0);
              if (((((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
                   (lVar4 = GameObject.get_transform(*(int64 *)(lVar4 + 32),0)) == null) ||
                  ((lVar4 = Transform.Find(lVar4,"Viewport"), lVar4 == null ||
                   (lVar4 = Transform.Find(lVar4,"Content")) == null))) ||
                 (lVar4 = Transform.GetChild(lVar4)) == null) throw; // [null/range check failed]
              uVar6 = Component.get_gameObject(lVar4);
            }
            uVar8 = (uint64)((int)uVar8 + 1);
          }
          cVar2 = Object.op_Equality(uVar6,0,0);
          if (cVar2) {
            if ((((*pStatics == 0) ||
                 (lVar4 = *(int64 *)(*pStatics + 32)) == null) ||
                (lVar4 = GameObject.get_transform(lVar4,0)) == null) ||
               ((lVar4 = Transform.Find(lVar4,"Viewport",0), lVar4 == null ||
                (lVar4 = Transform.Find(lVar4,"Content",0)) == null))) throw; // [null/range check failed]
            iVar3 = Transform.get_childCount(lVar4,0);
            if (0 < iVar3) {
              if (((*pStatics == 0) ||
                  (lVar4 = *(int64 *)(*pStatics + 32)) == null) ||
                 ((lVar4 = GameObject.get_transform(lVar4,0), lVar4 == null ||
                  (((lVar4 = Transform.Find(lVar4,"Viewport",0), lVar4 == null ||
                    (lVar4 = Transform.Find(lVar4,"Content",0)) == null) ||
                   (lVar4 = Transform.GetChild(lVar4,0,0)) == null))))) throw; // [null/range check failed]
              uVar6 = Component.get_gameObject(lVar4,0);
            }
          }
          cVar2 = Object.op_Inequality(uVar6,0,0);
          if (!cVar2) {
            return;
          }
          if ((this.nowTutorial != null) &&
             (lVar4 = this.nowTutorial.tutorialPlotDatas) != null) {
            uVar1 = this.nowTutorialPlotCount;
            if (*(uint32 *)(lVar4 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = lVar4[uVar1];
            if (lVar4 != null) {
              puVar7 = (uint64 *)(lVar4 + 32);
              *puVar7 = uVar6;
              il2cpp_internal(puVar7,uVar6);
              if ((this.nowTutorial != null) &&
                 (lVar4 = this.nowTutorial.tutorialPlotDatas) != null) {
                uVar1 = this.nowTutorialPlotCount;
                if (*(uint32 *)(lVar4 + 24) <= uVar1) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar4 = lVar4[uVar1];
                if (lVar4 != null) {
                  *(uint8 *)(lVar4 + 68) = 1;
                  if ((this.nowTutorial != null) &&
                     (lVar4 = this.nowTutorial.tutorialPlotDatas) != null) {
                    uVar1 = this.nowTutorialPlotCount;
                    if (*(uint32 *)(lVar4 + 24) <= uVar1) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar4 = lVar4[uVar1];
                    if (lVar4 != null) {
                      puVar7 = (uint64 *)(lVar4 + 72);
                      *puVar7 = uVar6;
                      il2cpp_internal(puVar7,uVar6);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60023E1
    // RVA   : 0x83CE50   Offset: 0x83BC50   Length: 0x16B
    public void TutorialStartStudyInternalFindBuilding()
    {
        uint uVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        uVar4 = TutorialController.TutorialFindBuildingButton(this,"闭关室",0);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          return;
        }
        if ((this.nowTutorial != null) &&
           (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
          uVar1 = this.nowTutorialPlotCount;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2[uVar1];
          if (lVar2 != null) {
            puVar5 = (uint64 *)(lVar2 + 32);
            *puVar5 = uVar4;
            il2cpp_internal(puVar5,uVar4);
            if ((this.nowTutorial != null) &&
               (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
              uVar1 = this.nowTutorialPlotCount;
              if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = lVar2[uVar1];
              if (lVar2 != null) {
                *(uint8 *)(lVar2 + 68) = 1;
                if ((this.nowTutorial != null) &&
                   (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
                  uVar1 = this.nowTutorialPlotCount;
                  if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar2 = lVar2[uVar1];
                  if (lVar2 != null) {
                    puVar5 = (uint64 *)(lVar2 + 72);
                    *puVar5 = uVar4;
                    il2cpp_internal(puVar5,uVar4);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60023E2
    // RVA   : 0x83CD20   Offset: 0x83BB20   Length: 0x124
    public void TutorialStartStudyInternalFindBuildingChoice()
    {
        uint uVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        uVar4 = TutorialController.TutorialFindBuildingChoiceButton(this,"修炼",0);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          return;
        }
        if ((this.nowTutorial != null) &&
           (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
          uVar1 = this.nowTutorialPlotCount;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2[uVar1];
          if (lVar2 != null) {
            *(uint8 *)(lVar2 + 68) = 1;
            if ((this.nowTutorial != null) &&
               (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
              uVar1 = this.nowTutorialPlotCount;
              if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = lVar2[uVar1];
              if (lVar2 != null) {
                puVar5 = (uint64 *)(lVar2 + 72);
                *puVar5 = uVar4;
                il2cpp_internal(puVar5,uVar4);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60023E3
    // RVA   : 0x838EA0   Offset: 0x837CA0   Length: 0x7C
    public void TutorialQuickShowPlot()
    {
        DOTween.Complete("PlotTextDoText",0,0);
        DOTween.Complete("PlotChoiceDoScale",0,0);
    }

    // Token : 0x60023E4
    // RVA   : 0x838960   Offset: 0x837760   Length: 0x10A
    public void TutorialFocusOnMazePlayer()
    {
        long lVar1;
        long lVar2;
        lVar1 = BattleController.AttackAreaTypeStartMovePower;
        lVar2 = BattleController.AttackAreaTypeStartMovePower;
        if ((lVar2 != null) && (lVar1 != null)) {
          ExploreController.FocusOnTarget(lVar1,*(uint64 *)(lVar2 + 144),0);
          return;
        }
    }

    // Token : 0x60023E5
    // RVA   : 0x838850   Offset: 0x837650   Length: 0x10A
    public void TutorialFocusOnMazeEnd()
    {
        long lVar1;
        long lVar2;
        lVar1 = BattleController.AttackAreaTypeStartMovePower;
        lVar2 = BattleController.AttackAreaTypeStartMovePower;
        if ((lVar2 != null) && (lVar1 != null)) {
          ExploreController.FocusOnTarget(lVar1,*(uint64 *)(lVar2 + 160),0);
          return;
        }
    }

    // Token : 0x60023E6
    // RVA   : 0x8380F0   Offset: 0x836EF0   Length: 0x189
    public void TutorialFocusOnAreaCenter()
    {
        long lVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        lVar1 = PlotController.SpringFestivelRewardLvTalkText;
        lVar2 = PlotController.SpringFestivelRewardLvTalkText;
        lVar3 = PlotController.SpringFestivelRewardLvTalkText;
        if ((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 88)) != null) {
          uVar4 = AreaData.GetCenterBuilding(lVar3,0);
          if (lVar2 != null) {
            uVar4 = AreaController.GetBuildingObj(lVar2,uVar4,0);
            if (lVar1 != null) {
              AreaController.FocusOnTarget(lVar1,uVar4,0x3f800000,0);
              return;
            }
          }
        }
    }

    // Token : 0x60023E7
    // RVA   : 0x839110   Offset: 0x837F10   Length: 0xD7
    public void TutorialShowHeroDetailItem()
    {
        var pStatics = *(int64*)(DAT_181e55ae8 + 184);
        long lVar1;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
          lVar1 = GameObject.get_transform(lVar1,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"Tabs",0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"ItemTab",0);
              if (lVar1 != null) {
                lVar1 = Component.GetComponent(lVar1,DAT_181e796b8);
                if (lVar1 != null) {
                  Toggle.set_isOn(lVar1,1,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x60023E8
    // RVA   : 0x8391F0   Offset: 0x837FF0   Length: 0xEB
    public void TutorialShowMission()
    {
        var pStatics = *(int64*)(DAT_181e6af70 + 184);
        long lVar1;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 104)) != null) {
          if (*(int *)(lVar1 + 24) == 0) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar1 = *(int64 *)(*(int64 *)(lVar1 + 16) + 32);
          if (lVar1 != null) {
            lVar1 = GameObject.GetComponent(lVar1,DAT_181e57478);
            if (lVar1 != null) {
              Toggle.set_isOn(lVar1,1,0);
              if (*pStatics != 0) {
                MissionUIController.ShowMissionUI(*pStatics,1,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60023E9
    // RVA   : 0x8392E0   Offset: 0x8380E0   Length: 0xEB
    public void TutorialShowWorldNews()
    {
        var pStatics = *(int64*)(DAT_181e6af70 + 184);
        long lVar1;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 104)) != null) {
          if (*(uint32 *)(lVar1 + 24) < 2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar1 = *(int64 *)(*(int64 *)(lVar1 + 16) + 40);
          if (lVar1 != null) {
            lVar1 = GameObject.GetComponent(lVar1,DAT_181e57478);
            if (lVar1 != null) {
              Toggle.set_isOn(lVar1,1,0);
              if (*pStatics != 0) {
                MissionUIController.ShowMissionUI(*pStatics,1,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60023EA
    // RVA   : 0x838E50   Offset: 0x837C50   Length: 0x49
    public void TutorialHideMission()
    {
        var pStatics = *(int64*)(DAT_181e6af70 + 184);
        if (*pStatics != 0) {
          MissionUIController.ShowMissionUI(*pStatics,0,0);
          return;
        }
    }

    // Token : 0x60023EB
    // RVA   : 0x838280   Offset: 0x837080   Length: 0x298
    public void TutorialFocusOnArea(string _areaName)
    {
        long lVar1;
        long lVar2;
        long lVar3;
        uint local_38;
        uint uStack_24;
        byte[] local_18 = new byte[16];
        if ((GameController._instance != null) &&
           (lVar3 = GameController._instance.worldData) != null) {
          lVar3 = WorldData.GetArea(lVar3,_areaName,0);
          if (lVar3 == null) {
            return;
          }
          lVar1 = GameController.CheckShowSpeHero;
          lVar2 = GameController.CheckShowSpeHero;
          if ((((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 96)) != null) &&
              (lVar3 = FUN_18171b450(lVar2,lVar3.chapter,DAT_181e9b4c0)) != null) &&
             (lVar3 = GameObject.get_transform(lVar3,0)) != null) {
            puVar4 = (uint64 *)Transform.get_localPosition(local_18,lVar3,0);
            if (lVar1 != null) {
              local_38 = (uint32)*puVar4;
              uStack_24 = (uint32)((uint64)*puVar4 >> 32);
              *(uint32 *)(lVar1 + 168) = local_38;
              *(uint32 *)(lVar1 + 172) = uStack_24;
              lVar3 = GameController.CheckShowSpeHero;
              if (lVar3 != null) {
                BigMapController.TweenFocusTarget(lVar3,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60023EC
    // RVA   : 0x838F20   Offset: 0x837D20   Length: 0x1E7
    public void TutorialSetMoveTargetArea(string _areaName)
    {
        long lVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        if ((GameController._instance != null) &&
           (lVar3 = GameController._instance.worldData) != null) {
          lVar3 = WorldData.GetArea(lVar3,_areaName,0);
          if (lVar3 == null) {
            return;
          }
          lVar1 = GameController.CheckShowSpeHero;
          lVar2 = GameController.CheckShowSpeHero;
          if (((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 96)) != null) &&
             (uVar4 = FUN_18171b450(lVar2,lVar3.chapter,DAT_181e9b4c0), lVar1 != null)) {
            BigMapController.SetPlayerMoveTargetArea(lVar1,uVar4,0);
            return;
          }
        }
    }

    // Token : 0x60023ED
    // RVA   : 0x837C40   Offset: 0x836A40   Length: 0x18E
    public GameObject TutorialFindMissionButton(string missionName)
    {
        var pStatics = *(int64*)(DAT_181e6af70 + 184);
        bool cVar1;
        int iVar2;
        long lVar3;
        ulong uVar4;
        int iVar5;
        iVar5 = 0;
        while( true ) {
          if ((*pStatics == 0) ||
             (lVar3 = *(int64 *)(*pStatics + 48)) == null)
          throw; // [null/range check failed]
          lVar3 = GameObject.get_transform(lVar3,0);
          if (lVar3 == null) throw; // [null/range check failed]
          iVar2 = Transform.get_childCount(lVar3,0);
          if (iVar2 <= iVar5) {
            return 0;
          }
          if ((*pStatics == 0) ||
             (lVar3 = *(int64 *)(*pStatics + 48)) == null)
          throw; // [null/range check failed]
          lVar3 = GameObject.get_transform(lVar3,0);
          if (lVar3 == null) throw; // [null/range check failed]
          lVar3 = Transform.GetChild(lVar3,iVar5,0);
          if (lVar3 == null) throw; // [null/range check failed]
          lVar3 = Component.GetComponent(lVar3,DAT_181e77db8);
          if ((lVar3 == null) || (*(int64 *)(lVar3 + 24) == 0)) throw; // [null/range check failed]
          cVar1 = FUN_1816387f0(*(uint64 *)(*(int64 *)(lVar3 + 24) + 24));
          if (cVar1) break;
          iVar5 = iVar5 + 1;
        }
        lVar3 = FUN_1806b8620(0);
        if ((lVar3 != null) && (*(int64 *)(lVar3 + 48) != 0)) {
          lVar3 = GameObject.get_transform(*(int64 *)(lVar3 + 48),0);
          if (lVar3 != null) {
            lVar3 = Transform.GetChild(lVar3,iVar5,0);
            if (lVar3 != null) {
              uVar4 = Component.get_gameObject(lVar3,0);
              return uVar4;
            }
          }
        }
    }

    // Token : 0x60023EE
    // RVA   : 0x83A1F0   Offset: 0x838FF0   Length: 0x124
    public void TutorialStartBigMapFindMission()
    {
        uint uVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        uVar4 = TutorialController.TutorialFindMissionButton(this,"巴陵盗匪",0);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          return;
        }
        if ((this.nowTutorial != null) &&
           (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
          uVar1 = this.nowTutorialPlotCount;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2[uVar1];
          if (lVar2 != null) {
            puVar5 = (uint64 *)(lVar2 + 32);
            *puVar5 = uVar4;
            il2cpp_internal(puVar5,uVar4);
            if ((this.nowTutorial != null) &&
               (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
              uVar1 = this.nowTutorialPlotCount;
              if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = lVar2[uVar1];
              if (lVar2 != null) {
                *(uint8 *)(lVar2 + 68) = 1;
                return;
              }
            }
          }
        }
    }

    // Token : 0x60023EF
    // RVA   : 0x83D220   Offset: 0x83C020   Length: 0x16B
    public void TutorialStartUpgradeForceLvFindBuilding()
    {
        uint uVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        uVar4 = TutorialController.TutorialFindBuildingButton(this,"正厅",0);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          return;
        }
        if ((this.nowTutorial != null) &&
           (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
          uVar1 = this.nowTutorialPlotCount;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2[uVar1];
          if (lVar2 != null) {
            puVar5 = (uint64 *)(lVar2 + 32);
            *puVar5 = uVar4;
            il2cpp_internal(puVar5,uVar4);
            if ((this.nowTutorial != null) &&
               (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
              uVar1 = this.nowTutorialPlotCount;
              if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = lVar2[uVar1];
              if (lVar2 != null) {
                *(uint8 *)(lVar2 + 68) = 1;
                if ((this.nowTutorial != null) &&
                   (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
                  uVar1 = this.nowTutorialPlotCount;
                  if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar2 = lVar2[uVar1];
                  if (lVar2 != null) {
                    puVar5 = (uint64 *)(lVar2 + 72);
                    *puVar5 = uVar4;
                    il2cpp_internal(puVar5,uVar4);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60023F0
    // RVA   : 0x83D0F0   Offset: 0x83BEF0   Length: 0x124
    public void TutorialStartUpgradeForceLvFindBuildingChoice()
    {
        uint uVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        uVar4 = TutorialController.TutorialFindBuildingChoiceButton(this,"门派弟子",0);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          return;
        }
        if ((this.nowTutorial != null) &&
           (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
          uVar1 = this.nowTutorialPlotCount;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2[uVar1];
          if (lVar2 != null) {
            *(uint8 *)(lVar2 + 68) = 1;
            if ((this.nowTutorial != null) &&
               (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
              uVar1 = this.nowTutorialPlotCount;
              if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = lVar2[uVar1];
              if (lVar2 != null) {
                puVar5 = (uint64 *)(lVar2 + 72);
                *puVar5 = uVar4;
                il2cpp_internal(puVar5,uVar4);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60023F1
    // RVA   : 0x83ABD0   Offset: 0x8399D0   Length: 0x16B
    public void TutorialStartCureInjuryFindBuilding()
    {
        uint uVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        uVar4 = TutorialController.TutorialFindBuildingButton(this,"疗伤室",0);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          return;
        }
        if ((this.nowTutorial != null) &&
           (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
          uVar1 = this.nowTutorialPlotCount;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2[uVar1];
          if (lVar2 != null) {
            puVar5 = (uint64 *)(lVar2 + 32);
            *puVar5 = uVar4;
            il2cpp_internal(puVar5,uVar4);
            if ((this.nowTutorial != null) &&
               (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
              uVar1 = this.nowTutorialPlotCount;
              if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = lVar2[uVar1];
              if (lVar2 != null) {
                *(uint8 *)(lVar2 + 68) = 1;
                if ((this.nowTutorial != null) &&
                   (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
                  uVar1 = this.nowTutorialPlotCount;
                  if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar2 = lVar2[uVar1];
                  if (lVar2 != null) {
                    puVar5 = (uint64 *)(lVar2 + 72);
                    *puVar5 = uVar4;
                    il2cpp_internal(puVar5,uVar4);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60023F2
    // RVA   : 0x83BDA0   Offset: 0x83ABA0   Length: 0x16B
    public void TutorialStartRestFindBuilding()
    {
        uint uVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        uVar4 = TutorialController.TutorialFindBuildingButton(this,"宿舍",0);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          return;
        }
        if ((this.nowTutorial != null) &&
           (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
          uVar1 = this.nowTutorialPlotCount;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2[uVar1];
          if (lVar2 != null) {
            puVar5 = (uint64 *)(lVar2 + 32);
            *puVar5 = uVar4;
            il2cpp_internal(puVar5,uVar4);
            if ((this.nowTutorial != null) &&
               (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
              uVar1 = this.nowTutorialPlotCount;
              if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = lVar2[uVar1];
              if (lVar2 != null) {
                *(uint8 *)(lVar2 + 68) = 1;
                if ((this.nowTutorial != null) &&
                   (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
                  uVar1 = this.nowTutorialPlotCount;
                  if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar2 = lVar2[uVar1];
                  if (lVar2 != null) {
                    puVar5 = (uint64 *)(lVar2 + 72);
                    *puVar5 = uVar4;
                    il2cpp_internal(puVar5,uVar4);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60023F3
    // RVA   : 0x83BC70   Offset: 0x83AA70   Length: 0x124
    public void TutorialStartRestFindBuildingChoice()
    {
        uint uVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        uVar4 = TutorialController.TutorialFindBuildingChoiceButton(this,"休息",0);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          return;
        }
        if ((this.nowTutorial != null) &&
           (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
          uVar1 = this.nowTutorialPlotCount;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2[uVar1];
          if (lVar2 != null) {
            *(uint8 *)(lVar2 + 68) = 1;
            if ((this.nowTutorial != null) &&
               (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
              uVar1 = this.nowTutorialPlotCount;
              if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = lVar2[uVar1];
              if (lVar2 != null) {
                puVar5 = (uint64 *)(lVar2 + 72);
                *puVar5 = uVar4;
                il2cpp_internal(puVar5,uVar4);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60023F4
    // RVA   : 0x83BF10   Offset: 0x83AD10   Length: 0x1AF
    public void TutorialStartRestFindPlotChoice()
    {
        uint uVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        TutorialController.TutorialQuickShowPlot(this,0);
        if ((this.nowTutorial != null) &&
           (lVar3 = this.nowTutorial.tutorialPlotDatas) != null) {
          uVar2 = this.nowTutorialPlotCount;
          if (*(uint32 *)(lVar3 + 24) <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar3 = lVar3[uVar2];
          if (lVar3 != null) {
            *(uint8 *)(lVar3 + 68) = 1;
            if ((this.nowTutorial != null) &&
               (lVar3 = this.nowTutorial.tutorialPlotDatas) != null) {
              uVar2 = this.nowTutorialPlotCount;
              if (*(uint32 *)(lVar3 + 24) <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar3 = lVar3[uVar2];
              lVar4 = *(int64 *)(*(int64 *)(DAT_181e71f68 + 184) + 24);
              if ((lVar4 != null) && (lVar4 = *(int64 *)(lVar4 + 32)) != null) {
                lVar4 = GameObject.get_transform(lVar4,0);
                if (lVar4 != null) {
                  lVar4 = Transform.Find(lVar4,"InteractGrid",0);
                  if (lVar4 != null) {
                    lVar4 = Transform.GetChild(lVar4,0,0);
                    if (lVar4 != null) {
                      uVar5 = Component.get_gameObject(lVar4,0);
                      if (lVar3 != null) {
                        puVar1 = (uint64 *)(lVar3 + 72);
                        *puVar1 = uVar5;
                        il2cpp_internal(puVar1,uVar5);
                        return;
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60023F5
    // RVA   : 0x83C0C0   Offset: 0x83AEC0   Length: 0x124
    public void TutorialStartSelfStorageFindBuildingChoice()
    {
        uint uVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        uVar4 = TutorialController.TutorialFindBuildingChoiceButton(this,"私人仓库",0);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          return;
        }
        if ((this.nowTutorial != null) &&
           (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
          uVar1 = this.nowTutorialPlotCount;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2[uVar1];
          if (lVar2 != null) {
            *(uint8 *)(lVar2 + 68) = 1;
            if ((this.nowTutorial != null) &&
               (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
              uVar1 = this.nowTutorialPlotCount;
              if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = lVar2[uVar1];
              if (lVar2 != null) {
                puVar5 = (uint64 *)(lVar2 + 72);
                *puVar5 = uVar4;
                il2cpp_internal(puVar5,uVar4);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60023F6
    // RVA   : 0x83CFC0   Offset: 0x83BDC0   Length: 0x124
    public void TutorialStartStudyPracticeFightFindBuildingChoice()
    {
        uint uVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        uVar4 = TutorialController.TutorialFindBuildingChoiceButton(this,"切磋",0);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          return;
        }
        if ((this.nowTutorial != null) &&
           (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
          uVar1 = this.nowTutorialPlotCount;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2[uVar1];
          if (lVar2 != null) {
            *(uint8 *)(lVar2 + 68) = 1;
            if ((this.nowTutorial != null) &&
               (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
              uVar1 = this.nowTutorialPlotCount;
              if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = lVar2[uVar1];
              if (lVar2 != null) {
                puVar5 = (uint64 *)(lVar2 + 72);
                *puVar5 = uVar4;
                il2cpp_internal(puVar5,uVar4);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60023F7
    // RVA   : 0x836FB0   Offset: 0x835DB0   Length: 0x31A
    public void TutorialAskForItemFindPlotChoice()
    {
        uint uVar2;
        long lVar3;
        uint uVar4;
        long lVar5;
        ulong uVar6;
        if ((this.nowTutorial != null) &&
           (lVar3 = this.nowTutorial.tutorialPlotDatas) != null) {
          uVar2 = this.nowTutorialPlotCount;
          if (*(uint32 *)(lVar3 + 24) <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar3 = lVar3[uVar2];
          lVar5 = BuildingUIController.PartyLvName;
          if ((lVar5 != null) && (lVar5 = *(int64 *)(lVar5 + 32)) != null) {
            lVar5 = GameObject.get_transform(lVar5,0);
            if (lVar5 != null) {
              lVar5 = Transform.Find(lVar5,"InteractGrid",0);
              uVar4 = TutorialController.FindPlotChoiceIncludeText(this,"友善",0);
              if (lVar5 != null) {
                lVar5 = Transform.GetChild(lVar5,uVar4,0);
                if (lVar5 != null) {
                  uVar6 = Component.get_gameObject(lVar5,0);
                  if (lVar3 != null) {
                    puVar1 = (uint64 *)(lVar3 + 32);
                    *puVar1 = uVar6;
                    il2cpp_internal(puVar1,uVar6);
                    if ((this.nowTutorial != null) &&
                       (lVar3 = this.nowTutorial.tutorialPlotDatas) != null) {
                      uVar2 = this.nowTutorialPlotCount;
                      if (*(uint32 *)(lVar3 + 24) <= uVar2) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar3 = lVar3[uVar2]
                      ;
                      if (lVar3 != null) {
                        *(uint8 *)(lVar3 + 40) = 0;
                        if ((this.nowTutorial != null) &&
                           (lVar3 = this.nowTutorial.tutorialPlotDatas) != null) {
                          uVar2 = this.nowTutorialPlotCount;
                          if (*(uint32 *)(lVar3 + 24) <= uVar2) {
                            ThrowHelper.ThrowArgumentOutOfRangeException(0);
                          }
                          lVar3 = *(int64 *)
                                   (*(int64 *)(lVar3 + 16) + 32 + (int64)(int)uVar2 * 8);
                          if (lVar3 != null) {
                            *(uint8 *)(lVar3 + 68) = 1;
                            if ((this.nowTutorial != null) &&
                               (lVar3 = this.nowTutorial.tutorialPlotDatas) != null)
                            {
                              uVar2 = this.nowTutorialPlotCount;
                              if (*(uint32 *)(lVar3 + 24) <= uVar2) {
                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                              }
                              lVar3 = *(int64 *)
                                       (*(int64 *)(lVar3 + 16) + 32 + (int64)(int)uVar2 * 8);
                              lVar5 = BuildingUIController.PartyLvName;
                              if ((lVar5 != null) && (lVar5 = *(int64 *)(lVar5 + 32)) != null) {
                                lVar5 = GameObject.get_transform(lVar5,0);
                                if (lVar5 != null) {
                                  lVar5 = Transform.Find(lVar5,"InteractGrid",0);
                                  uVar4 = TutorialController.FindPlotChoiceIncludeText
                                                    (this,"友善",0);
                                  if (lVar5 != null) {
                                    lVar5 = Transform.GetChild(lVar5,uVar4,0);
                                    if (lVar5 != null) {
                                      uVar6 = Component.get_gameObject(lVar5,0);
                                      if (lVar3 != null) {
                                        puVar1 = (uint64 *)(lVar3 + 72);
                                        *puVar1 = uVar6;
                                        il2cpp_internal(puVar1,uVar6);
                                        return;
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

    // Token : 0x60023F8
    // RVA   : 0x8372D0   Offset: 0x8360D0   Length: 0x31A
    public void TutorialAskForSkillFindPlotChoice()
    {
        uint uVar2;
        long lVar3;
        uint uVar4;
        long lVar5;
        ulong uVar6;
        if ((this.nowTutorial != null) &&
           (lVar3 = this.nowTutorial.tutorialPlotDatas) != null) {
          uVar2 = this.nowTutorialPlotCount;
          if (*(uint32 *)(lVar3 + 24) <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar3 = lVar3[uVar2];
          lVar5 = BuildingUIController.PartyLvName;
          if ((lVar5 != null) && (lVar5 = *(int64 *)(lVar5 + 32)) != null) {
            lVar5 = GameObject.get_transform(lVar5,0);
            if (lVar5 != null) {
              lVar5 = Transform.Find(lVar5,"InteractGrid",0);
              uVar4 = TutorialController.FindPlotChoiceIncludeText(this,"修行",0);
              if (lVar5 != null) {
                lVar5 = Transform.GetChild(lVar5,uVar4,0);
                if (lVar5 != null) {
                  uVar6 = Component.get_gameObject(lVar5,0);
                  if (lVar3 != null) {
                    puVar1 = (uint64 *)(lVar3 + 32);
                    *puVar1 = uVar6;
                    il2cpp_internal(puVar1,uVar6);
                    if ((this.nowTutorial != null) &&
                       (lVar3 = this.nowTutorial.tutorialPlotDatas) != null) {
                      uVar2 = this.nowTutorialPlotCount;
                      if (*(uint32 *)(lVar3 + 24) <= uVar2) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar3 = lVar3[uVar2]
                      ;
                      if (lVar3 != null) {
                        *(uint8 *)(lVar3 + 40) = 0;
                        if ((this.nowTutorial != null) &&
                           (lVar3 = this.nowTutorial.tutorialPlotDatas) != null) {
                          uVar2 = this.nowTutorialPlotCount;
                          if (*(uint32 *)(lVar3 + 24) <= uVar2) {
                            ThrowHelper.ThrowArgumentOutOfRangeException(0);
                          }
                          lVar3 = *(int64 *)
                                   (*(int64 *)(lVar3 + 16) + 32 + (int64)(int)uVar2 * 8);
                          if (lVar3 != null) {
                            *(uint8 *)(lVar3 + 68) = 1;
                            if ((this.nowTutorial != null) &&
                               (lVar3 = this.nowTutorial.tutorialPlotDatas) != null)
                            {
                              uVar2 = this.nowTutorialPlotCount;
                              if (*(uint32 *)(lVar3 + 24) <= uVar2) {
                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                              }
                              lVar3 = *(int64 *)
                                       (*(int64 *)(lVar3 + 16) + 32 + (int64)(int)uVar2 * 8);
                              lVar5 = BuildingUIController.PartyLvName;
                              if ((lVar5 != null) && (lVar5 = *(int64 *)(lVar5 + 32)) != null) {
                                lVar5 = GameObject.get_transform(lVar5,0);
                                if (lVar5 != null) {
                                  lVar5 = Transform.Find(lVar5,"InteractGrid",0);
                                  uVar4 = TutorialController.FindPlotChoiceIncludeText
                                                    (this,"修行",0);
                                  if (lVar5 != null) {
                                    lVar5 = Transform.GetChild(lVar5,uVar4,0);
                                    if (lVar5 != null) {
                                      uVar6 = Component.get_gameObject(lVar5,0);
                                      if (lVar3 != null) {
                                        puVar1 = (uint64 *)(lVar3 + 72);
                                        *puVar1 = uVar6;
                                        il2cpp_internal(puVar1,uVar6);
                                        return;
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

    // Token : 0x60023F9
    // RVA   : 0x837DD0   Offset: 0x836BD0   Length: 0x313
    public void TutorialFindPlotChoice(string choiceString)
    {
        uint uVar2;
        long lVar3;
        uint uVar4;
        long lVar5;
        ulong uVar6;
        if ((this.nowTutorial != null) &&
           (lVar3 = this.nowTutorial.tutorialPlotDatas) != null) {
          uVar2 = this.nowTutorialPlotCount;
          if (*(uint32 *)(lVar3 + 24) <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar3 = lVar3[uVar2];
          lVar5 = BuildingUIController.PartyLvName;
          if ((lVar5 != null) && (lVar5 = *(int64 *)(lVar5 + 32)) != null) {
            lVar5 = GameObject.get_transform(lVar5,0);
            if (lVar5 != null) {
              lVar5 = Transform.Find(lVar5,"InteractGrid",0);
              uVar4 = TutorialController.FindPlotChoiceIncludeText(this,choiceString,0);
              if (lVar5 != null) {
                lVar5 = Transform.GetChild(lVar5,uVar4,0);
                if (lVar5 != null) {
                  uVar6 = Component.get_gameObject(lVar5,0);
                  if (lVar3 != null) {
                    puVar1 = (uint64 *)(lVar3 + 32);
                    *puVar1 = uVar6;
                    il2cpp_internal(puVar1,uVar6);
                    if ((this.nowTutorial != null) &&
                       (lVar3 = this.nowTutorial.tutorialPlotDatas) != null) {
                      uVar2 = this.nowTutorialPlotCount;
                      if (*(uint32 *)(lVar3 + 24) <= uVar2) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar3 = lVar3[uVar2]
                      ;
                      if (lVar3 != null) {
                        *(uint8 *)(lVar3 + 40) = 0;
                        if ((this.nowTutorial != null) &&
                           (lVar3 = this.nowTutorial.tutorialPlotDatas) != null) {
                          uVar2 = this.nowTutorialPlotCount;
                          if (*(uint32 *)(lVar3 + 24) <= uVar2) {
                            ThrowHelper.ThrowArgumentOutOfRangeException(0);
                          }
                          lVar3 = *(int64 *)
                                   (*(int64 *)(lVar3 + 16) + 32 + (int64)(int)uVar2 * 8);
                          if (lVar3 != null) {
                            *(uint8 *)(lVar3 + 68) = 1;
                            if ((this.nowTutorial != null) &&
                               (lVar3 = this.nowTutorial.tutorialPlotDatas) != null)
                            {
                              uVar2 = this.nowTutorialPlotCount;
                              if (*(uint32 *)(lVar3 + 24) <= uVar2) {
                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                              }
                              lVar3 = *(int64 *)
                                       (*(int64 *)(lVar3 + 16) + 32 + (int64)(int)uVar2 * 8);
                              lVar5 = BuildingUIController.PartyLvName;
                              if ((lVar5 != null) && (lVar5 = *(int64 *)(lVar5 + 32)) != null) {
                                lVar5 = GameObject.get_transform(lVar5,0);
                                if (lVar5 != null) {
                                  lVar5 = Transform.Find(lVar5,"InteractGrid",0);
                                  uVar4 = TutorialController.FindPlotChoiceIncludeText(this,choiceString,0)
                                  ;
                                  if (lVar5 != null) {
                                    lVar5 = Transform.GetChild(lVar5,uVar4,0);
                                    if (lVar5 != null) {
                                      uVar6 = Component.get_gameObject(lVar5,0);
                                      if (lVar3 != null) {
                                        puVar1 = (uint64 *)(lVar3 + 72);
                                        *puVar1 = uVar6;
                                        il2cpp_internal(puVar1,uVar6);
                                        return;
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

    // Token : 0x60023FA
    // RVA   : 0x835630   Offset: 0x834430   Length: 0x1C4
    public void HighLightPlotChoiceIncludeText(string targetString)
    {
        uint uVar2;
        long lVar3;
        uint uVar4;
        long lVar5;
        ulong uVar6;
        if ((this.nowTutorial != null) &&
           (lVar3 = this.nowTutorial.tutorialPlotDatas) != null) {
          uVar2 = this.nowTutorialPlotCount;
          if (*(uint32 *)(lVar3 + 24) <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar3 = lVar3[uVar2];
          lVar5 = *(int64 *)(*(int64 *)(DAT_181e71f68 + 184) + 24);
          if ((lVar5 != null) && (lVar5 = *(int64 *)(lVar5 + 32)) != null) {
            lVar5 = GameObject.get_transform(lVar5,0);
            if (lVar5 != null) {
              lVar5 = Transform.Find(lVar5,"InteractGrid",0);
              uVar4 = TutorialController.FindPlotChoiceIncludeText(this,targetString,0);
              if (lVar5 != null) {
                lVar5 = Transform.GetChild(lVar5,uVar4,0);
                if (lVar5 != null) {
                  uVar6 = Component.get_gameObject(lVar5,0);
                  if (lVar3 != null) {
                    puVar1 = (uint64 *)(lVar3 + 32);
                    *puVar1 = uVar6;
                    il2cpp_internal(puVar1,uVar6);
                    if ((this.nowTutorial != null) &&
                       (lVar3 = this.nowTutorial.tutorialPlotDatas) != null) {
                      uVar2 = this.nowTutorialPlotCount;
                      if (*(uint32 *)(lVar3 + 24) <= uVar2) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar3 = lVar3[uVar2]
                      ;
                      if (lVar3 != null) {
                        *(uint8 *)(lVar3 + 40) = 0;
                        return;
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60023FB
    // RVA   : 0x8354B0   Offset: 0x8342B0   Length: 0x175
    public int FindPlotChoiceIncludeText(string targetString)
    {
        bool cVar1;
        long lVar2;
        int iVar3;
        iVar3 = 0;
        while( true ) {
          lVar2 = *(int64 *)(*(int64 *)(DAT_181e71f68 + 184) + 24);
          if (((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 168)) == null) ||
             (lVar2 = *(int64 *)(lVar2 + 56)) == null) break;
          if (*(int *)(lVar2 + 24) <= iVar3) {
            return 0;
          }
          lVar2 = FUN_180210a70(0);
          if (((lVar2 == null) || (*(int64 *)(lVar2 + 168) == 0)) ||
             (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 168) + 56)) == null) break;
          lVar2 = FUN_1800024b0(lVar2,iVar3,DAT_181e83830);
          if ((lVar2 == null) || (*(int64 *)(lVar2 + 16) == 0)) break;
          cVar1 = String.Contains(*(int64 *)(lVar2 + 16),targetString,0);
          if (cVar1) {
            return iVar3;
          }
          iVar3 = iVar3 + 1;
        }
    }

    // Token : 0x60023FC
    // RVA   : 0x83B1A0   Offset: 0x839FA0   Length: 0x16B
    public void TutorialStartManageForceFindBuilding()
    {
        uint uVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        uVar4 = TutorialController.TutorialFindBuildingButton(this,"正厅",0);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          return;
        }
        if ((this.nowTutorial != null) &&
           (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
          uVar1 = this.nowTutorialPlotCount;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2[uVar1];
          if (lVar2 != null) {
            puVar5 = (uint64 *)(lVar2 + 32);
            *puVar5 = uVar4;
            il2cpp_internal(puVar5,uVar4);
            if ((this.nowTutorial != null) &&
               (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
              uVar1 = this.nowTutorialPlotCount;
              if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = lVar2[uVar1];
              if (lVar2 != null) {
                *(uint8 *)(lVar2 + 68) = 1;
                if ((this.nowTutorial != null) &&
                   (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
                  uVar1 = this.nowTutorialPlotCount;
                  if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar2 = lVar2[uVar1];
                  if (lVar2 != null) {
                    puVar5 = (uint64 *)(lVar2 + 72);
                    *puVar5 = uVar4;
                    il2cpp_internal(puVar5,uVar4);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60023FD
    // RVA   : 0x83B070   Offset: 0x839E70   Length: 0x124
    public void TutorialStartManageForceFindBuildingChoice()
    {
        uint uVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        uVar4 = TutorialController.TutorialFindBuildingChoiceButton(this,"弟子方针",0);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          return;
        }
        if ((this.nowTutorial != null) &&
           (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
          uVar1 = this.nowTutorialPlotCount;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2[uVar1];
          if (lVar2 != null) {
            *(uint8 *)(lVar2 + 68) = 1;
            if ((this.nowTutorial != null) &&
               (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
              uVar1 = this.nowTutorialPlotCount;
              if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = lVar2[uVar1];
              if (lVar2 != null) {
                puVar5 = (uint64 *)(lVar2 + 72);
                *puVar5 = uVar4;
                il2cpp_internal(puVar5,uVar4);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60023FE
    // RVA   : 0x839F10   Offset: 0x838D10   Length: 0x2D9
    public void TutorialStartAttackForceFindBuildingChoice()
    {
        var pStatics = *(int64*)(DAT_181e52a90 + 184);
        uint uVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        if (((((*pStatics != 0) &&
              (lVar3 = *(int64 *)(*pStatics + 72)) != null) &&
             (lVar3 = GameObject.get_transform(lVar3,0)) != null) &&
            ((lVar3 = Transform.Find(lVar3,"BuildingUI",0), lVar3 != null &&
             (lVar3 = Transform.Find(lVar3,"BuildingButtonScrollView",0)) != null))) &&
           (lVar3 = Component.GetComponent(lVar3,DAT_181e78538)) != null) {
          Behaviour.set_enabled(lVar3,1,0);
          if ((((*pStatics != 0) &&
               (lVar3 = *(int64 *)(*pStatics + 72)) != null) &&
              ((lVar3 = GameObject.get_transform(lVar3,0), lVar3 != null &&
               (((lVar3 = Transform.Find(lVar3,"BuildingUI",0), lVar3 != null &&
                 (lVar3 = Transform.Find(lVar3,"BuildingButtonScrollView",0)) != null) &&
                (lVar3 = Transform.Find(lVar3,"Scrollbar Vertical",0)) != null))))) &&
             (lVar3 = Component.GetComponent(lVar3,DAT_181e785b8)) != null) {
            Scrollbar.set_value(lVar3,0,0);
            uVar4 = TutorialController.TutorialFindBuildingChoiceButton(this,"挥师出征",0);
            cVar2 = Object.op_Inequality(uVar4,0,0);
            if (!cVar2) {
              return;
            }
            if ((this.nowTutorial != null) &&
               (lVar3 = this.nowTutorial.tutorialPlotDatas) != null) {
              uVar1 = this.nowTutorialPlotCount;
              if (*(uint32 *)(lVar3 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar3 = lVar3[uVar1];
              if (lVar3 != null) {
                *(uint8 *)(lVar3 + 68) = 1;
                if ((this.nowTutorial != null) &&
                   (lVar3 = this.nowTutorial.tutorialPlotDatas) != null) {
                  uVar1 = this.nowTutorialPlotCount;
                  if (*(uint32 *)(lVar3 + 24) <= uVar1) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar3 = lVar3[uVar1];
                  if (lVar3 != null) {
                    puVar5 = (uint64 *)(lVar3 + 72);
                    *puVar5 = uVar4;
                    il2cpp_internal(puVar5,uVar4);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60023FF
    // RVA   : 0x83C320   Offset: 0x83B120   Length: 0x124
    public void TutorialStartServantForceFindBuildingChoice()
    {
        uint uVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        uVar4 = TutorialController.TutorialFindBuildingChoiceButton(this,"门派外交",0);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          return;
        }
        if ((this.nowTutorial != null) &&
           (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
          uVar1 = this.nowTutorialPlotCount;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2[uVar1];
          if (lVar2 != null) {
            *(uint8 *)(lVar2 + 68) = 1;
            if ((this.nowTutorial != null) &&
               (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
              uVar1 = this.nowTutorialPlotCount;
              if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = lVar2[uVar1];
              if (lVar2 != null) {
                puVar5 = (uint64 *)(lVar2 + 72);
                *puVar5 = uVar4;
                il2cpp_internal(puVar5,uVar4);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6002400
    // RVA   : 0x83C1F0   Offset: 0x83AFF0   Length: 0x124
    public void TutorialStartServantForceExchangeFindBuildingChoice()
    {
        uint uVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        uVar4 = TutorialController.TutorialFindBuildingChoiceButton(this,"功绩兑换",0);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          return;
        }
        if ((this.nowTutorial != null) &&
           (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
          uVar1 = this.nowTutorialPlotCount;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2[uVar1];
          if (lVar2 != null) {
            *(uint8 *)(lVar2 + 68) = 1;
            if ((this.nowTutorial != null) &&
               (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
              uVar1 = this.nowTutorialPlotCount;
              if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = lVar2[uVar1];
              if (lVar2 != null) {
                puVar5 = (uint64 *)(lVar2 + 72);
                *puVar5 = uVar4;
                il2cpp_internal(puVar5,uVar4);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6002401
    // RVA   : 0x83AD40   Offset: 0x839B40   Length: 0xDE
    public void TutorialStartFreeModeFindBuilding()
    {
        uint uVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        uVar4 = TutorialController.TutorialFindBuildingButton(this,"武馆",0);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          return;
        }
        if ((this.nowTutorial != null) &&
           (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
          uVar1 = this.nowTutorialPlotCount;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2[uVar1];
          if (lVar2 != null) {
            puVar5 = (uint64 *)(lVar2 + 32);
            *puVar5 = uVar4;
            il2cpp_internal(puVar5,uVar4);
            return;
          }
        }
    }

    // Token : 0x6002402
    // RVA   : 0x838520   Offset: 0x837320   Length: 0x324
    public void TutorialFocusOnBattleUnit(string _targetName)
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        int iVar4;
        int iVar5;
        uVar3 = 0;
        iVar5 = 0;
        while( true ) {
          lVar2 = *(int64 *)(*(int64 *)(DAT_181e90420 + 184) + 80);
          if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 112)) == null) goto LAB_18083883f;
          if (*(int *)(lVar2 + 24) <= iVar5) break;
          iVar4 = 0;
          while( true ) {
            lVar2 = FUN_1802101c0(0);
            if ((lVar2 == null) || (*(int64 *)(lVar2 + 112) == 0)) goto LAB_18083883f;
            lVar2 = FUN_1800024b0();
            if ((lVar2 == null) || (*(int64 *)(lVar2 + 24) == 0)) goto LAB_18083883f;
            if (*(int *)(*(int64 *)(lVar2 + 24) + 24) <= iVar4) goto LAB_1808387bc;
            lVar2 = FUN_1802101c0(0);
            if ((lVar2 == null) || (*(int64 *)(lVar2 + 112) == 0)) goto LAB_18083883f;
            lVar2 = FUN_1800024b0(*(int64 *)(lVar2 + 112),iVar5,DAT_181e61878);
            if ((lVar2 == null) || (*(int64 *)(lVar2 + 24) == 0)) goto LAB_18083883f;
            lVar2 = FUN_1800024b0(*(int64 *)(lVar2 + 24),iVar4,DAT_181e61c78);
            if (((lVar2 == null) || (*(int64 *)(lVar2 + 64) == 0)) ||
               (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 64) + 104)) == null)
            goto LAB_18083883f;
            cVar1 = String.Contains(lVar2,_targetName,0);
            if (cVar1) break;
            iVar4 = iVar4 + 1;
          }
          lVar2 = FUN_1802101c0(0);
          if ((lVar2 == null) || (*(int64 *)(lVar2 + 112) == 0)) goto LAB_18083883f;
          lVar2 = FUN_1800024b0(*(int64 *)(lVar2 + 112),iVar5,DAT_181e61878);
          if ((lVar2 == null) || (*(int64 *)(lVar2 + 24) == 0)) goto LAB_18083883f;
          lVar2 = FUN_1800024b0();
          if (lVar2 == null) goto LAB_18083883f;
          uVar3 = Component.get_gameObject(lVar2);
        LAB_1808387bc:
          iVar5 = iVar5 + 1;
        }
        cVar1 = Object.op_Inequality(uVar3,0,0);
        if (cVar1) {
          lVar2 = FUN_1802101c0(0);
          if (lVar2 == null) {
        LAB_18083883f:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          BattleController.FocusOnTarget(lVar2,uVar3,0);
        }
    }

    // Token : 0x6002403
    // RVA   : 0x838A70   Offset: 0x837870   Length: 0x119
    public void TutorialFocusOnNowActive()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        lVar1 = PlotController.LaBaFestivelResultTalkText;
        lVar2 = PlotController.LaBaFestivelResultTalkText;
        if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 0x110)) != null) {
          uVar3 = Component.get_gameObject(lVar2,0);
          if (lVar1 != null) {
            BattleController.FocusOnTarget(lVar1,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x6002404
    // RVA   : 0x835870   Offset: 0x834670   Length: 0x103
    public void ShowComboUI()
    {
        long lVar1;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        if ((StudySkillController._instance != null) &&
           (lVar1 = StudySkillController._instance.comboText) != null) {
          lVar1 = Component.get_transform(lVar1,0);
          if (lVar1 != null) {
            lVar1 = FUN_180b05920(lVar1,0);
            puVar2 = (uint64 *)Vector3.get_one(local_18,0);
            if (lVar1 != null) {
              local_20 = *(uint32 *)(puVar2 + 1);
              local_28 = *puVar2;
              Transform.set_localScale(lVar1,&local_28,0);
              return;
            }
          }
        }
    }

    // Token : 0x6002405
    // RVA   : 0x83D510   Offset: 0x83C310   Length: 0x103
    public void UnshowComboUI()
    {
        long lVar1;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        if ((StudySkillController._instance != null) &&
           (lVar1 = StudySkillController._instance.comboText) != null) {
          lVar1 = Component.get_transform(lVar1,0);
          if (lVar1 != null) {
            lVar1 = FUN_180b05920(lVar1,0);
            puVar2 = (uint64 *)Vector3.get_zero(local_18,0);
            if (lVar1 != null) {
              local_20 = *(uint32 *)(puVar2 + 1);
              local_28 = *puVar2;
              Transform.set_localScale(lVar1,&local_28,0);
              return;
            }
          }
        }
    }

    // Token : 0x6002406
    // RVA   : 0x83AE20   Offset: 0x839C20   Length: 0x16B
    public void TutorialStartGovernFindBuilding()
    {
        uint uVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        uVar4 = TutorialController.TutorialFindBuildingButton(this,"官府",0);
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          return;
        }
        if ((this.nowTutorial != null) &&
           (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
          uVar1 = this.nowTutorialPlotCount;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2[uVar1];
          if (lVar2 != null) {
            puVar5 = (uint64 *)(lVar2 + 32);
            *puVar5 = uVar4;
            il2cpp_internal(puVar5,uVar4);
            if ((this.nowTutorial != null) &&
               (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
              uVar1 = this.nowTutorialPlotCount;
              if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = lVar2[uVar1];
              if (lVar2 != null) {
                *(uint8 *)(lVar2 + 68) = 1;
                if ((this.nowTutorial != null) &&
                   (lVar2 = this.nowTutorial.tutorialPlotDatas) != null) {
                  uVar1 = this.nowTutorialPlotCount;
                  if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar2 = lVar2[uVar1];
                  if (lVar2 != null) {
                    puVar5 = (uint64 *)(lVar2 + 72);
                    *puVar5 = uVar4;
                    il2cpp_internal(puVar5,uVar4);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6002407
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

    // Token : 0x6002408
    // RVA   : 0x83D500   Offset: 0x83C300   Length: 0x5
    private void <ShowNextTutorialPlot>b__15_0()
    {
        void FUN_18083d500(int64 this)
        {
        this.textShowing = 0;
    }

}
