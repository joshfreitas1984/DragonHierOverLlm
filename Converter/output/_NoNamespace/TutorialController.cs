// ============================================================
// Type  : TutorialController
// Token : 0x20003A2
// ============================================================

public class TutorialController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001CBD
    public GameObject tutorialPanel;

    // Token: 0x4001CBE
    public RectTransform highLightRect;

    // Token: 0x4001CBF
    public GameObject arrow;

    // Token: 0x4001CC0
    public GameObject tutorialTextUI;

    // Token: 0x4001CC1
    public bool inTutorial;

    // Token: 0x4001CC2
    private TutorialData nowTutorial;

    // Token: 0x4001CC3
    public int nowTutorialPlotCount;

    // Token: 0x4001CC4
    public List<TutorialData> tutorialDatas;

    // Token: 0x4001CC5
    public bool textShowing;

    // Token: 0x4001CC6
    public bool tutorialNoLeaveBuilding;

    // Token: 0x4001CC7
    private static TutorialController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600229B
    // RVA   : 0xA6E4F0   Offset: 0xA6CCF0   Length: 0x36
    public static TutorialController get_Instance()
    {
        return **(uint64 **)(DAT_181d88ad8 + 184);
    }

    // Token : 0x600229C
    // RVA   : 0xA66330   Offset: 0xA64B30   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181d88ad8 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x600229D
    // RVA   : 0xA67A10   Offset: 0xA66210   Length: 0x4C3
    public void StartTutorial(string tutorialName)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        bool cVar1;
        int iVar2;
        ulong uVar3;
        long lVar4;
        long lVar5;
        uint uVar6;
        if (*(int *)(*(int64 *)(DAT_181d4ef00 + 184) + 8) == 1) {
          if (*pStatics == 0) throw; // [null/range check failed]
          cVar1 = GameController.CheckPlayTestEnd(*pStatics,0);
          if (cVar1) {
            return;
          }
        }

        if ((lVar4 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 8)?._items) != null) {
          iVar2 = PlayerPrefDictionary.GetInt(lVar4,"SkipTutorial",0);
          if (iVar2 == 1) {
            if (((*pStatics != 0) &&
                (lVar4 = *(int64 *)(*pStatics + 32)) != null) &&
               (lVar4 = *(int64 *)(lVar4 + 0x100)) != null) {
              cVar1 = FUN_1818279a0(lVar4,tutorialName,DAT_181d7c4d0);
              if (!cVar1) {
                lVar4 = FUN_18046c0a0(0);
                if (((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
                   (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 32) + 0x100)) == null)
                throw; // [null/range check failed]
                FUN_181827900(lVar4,tutorialName,DAT_181d7c3d0);
              }
              return;
            }
          }
          else {
            if (((*pStatics != 0) &&
                (lVar4 = *(int64 *)(*pStatics + 32)) != null) &&
               (lVar4 = *(int64 *)(lVar4 + 0x100)) != null) {
              cVar1 = FUN_1818279a0(lVar4,tutorialName,DAT_181d7c4d0);
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
        LAB_180a67d36:
                    if (this.nowTutorial == null) {
                      uVar3 = String.Concat("Tutorial Not Found: ",tutorialName,0);
                      Debug.Log(uVar3,0);
                      return;
                    }
                    if (this.tutorialPanel != null) {
                      GameObject.SetActive(this.tutorialPanel,1,0);
                      this.nowTutorialPlotCount = 0;
                      lVar4 = FUN_180a65300(0);
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
                  cVar1 = FUN_1816fd990(lVar4._items,tutorialName,0);
                  lVar4 = this.tutorialDatas;
                  if (cVar1) {
                    if (lVar4 != null) {
                      uVar3 = FUN_180002f80(lVar4,uVar6,DAT_181d807f8);
                      this.nowTutorial = uVar3;
                      goto LAB_180a67d36;
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

    // Token : 0x600229E
    // RVA   : 0xA668E0   Offset: 0xA650E0   Length: 0x1123
    public void ShowNextTutorialPlot(bool firstPlot)
    {
        var pStatics = *(int64*)(DAT_181d86c68 + 184);
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
                      (uVar8,uVar5,*(uint64 *)(*(int64 *)(DAT_181da0858 + 184) + 32),
                       DAT_181d90080);
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
            lVar6 = FUN_18046c0a0(0);
            if ((((lVar6 == null) || (lVar6.tutorialPlotDatas == null)) ||
                (this.nowTutorial == null)) ||
               (lVar6 = *(int64 *)(lVar6.tutorialPlotDatas + 0x100)) == null)
            throw; // [null/range check failed]
            FUN_181827900(lVar6,this.nowTutorial.tutorialName,DAT_181d7c3d0);
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
            lVar6 = Component.GetComponent(this.highLightRect,DAT_181d6c740);
            if ((this.nowTutorial == null) ||
               (lVar7 = this.nowTutorial.tutorialPlotDatas) == null)
            throw; // [null/range check failed]
            uVar1 = this.nowTutorialPlotCount;
            if (*(uint32 *)(lVar7 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar7 = lVar7[uVar1];
            if ((((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 32)) == null) ||
                (lVar7 = GameObject.GetComponent(lVar7,DAT_181da0b98)) == null) ||
               (uVar8 = RectTransform.get_pivot(lVar7,0), lVar6 == null)) throw; // [null/range check failed]
            RectTransform.set_pivot(lVar6,uVar8,0);
            if (this.highLightRect == null) throw; // [null/range check failed]
            lVar6 = Component.GetComponent(this.highLightRect,DAT_181d6c740);
            if ((this.nowTutorial == null) ||
               (lVar7 = this.nowTutorial.tutorialPlotDatas) == null)
            throw; // [null/range check failed]
            uVar1 = this.nowTutorialPlotCount;
            if (*(uint32 *)(lVar7 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar7 = lVar7[uVar1];
            if (((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 32)) == null) ||
               ((lVar7 = GameObject.GetComponent(lVar7,DAT_181da0b98), lVar7 == null ||
                (puVar9 = (uint64 *)Transform.get_position(local_58,lVar7,0), lVar6 == null))))
            throw; // [null/range check failed]
            local_68 = *puVar9;
            local_60 = *(uint32 *)(puVar9 + 1);
            Transform.set_position(lVar6,&local_68,0);
            if (this.highLightRect == null) throw; // [null/range check failed]
            lVar6 = Component.GetComponent(this.highLightRect,DAT_181d6c740);
            if ((this.nowTutorial == null) ||
               (lVar7 = this.nowTutorial.tutorialPlotDatas) == null)
            throw; // [null/range check failed]
            uVar1 = this.nowTutorialPlotCount;
            if (*(uint32 *)(lVar7 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar7 = lVar7[uVar1];
            if (((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 32)) == null) ||
               (lVar7 = GameObject.GetComponent(lVar7,DAT_181da0b98)) == null) throw; // [null/range check failed]
            uVar8 = RectTransform.get_sizeDelta(lVar7,0);
            goto joined_r0x000180a671c3;
          }
        }
        else {
          if (this.highLightRect == null) throw; // [null/range check failed]
          lVar6 = Component.GetComponent(this.highLightRect,DAT_181d6c740);
          uVar8 = Vector2.get_one(0);
          local_res20._0_4_ = (float)uVar8;
          local_res20._4_4_ = (float)((uint64)uVar8 >> 32);
          local_res20 = CONCAT44(local_res20._4_4_ * 0.5,(float)local_res20 * 0.5);
          if (lVar6 == null) throw; // [null/range check failed]
          RectTransform.set_pivot(lVar6,local_res20,0);
          if (this.highLightRect == null) throw; // [null/range check failed]
          lVar6 = Component.GetComponent(this.highLightRect,DAT_181d6c740);
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
          lVar6 = Component.GetComponent(this.highLightRect,DAT_181d6c740);
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
        joined_r0x000180a671c3:
          if (lVar6 == null) throw; // [null/range check failed]
          RectTransform.set_sizeDelta(lVar6,uVar8,0);
        }
        if ((this.highLightRect == null) ||
           (lVar6 = Component.GetComponent(this.highLightRect,DAT_181d6c740)) == null)
        throw; // [null/range check failed]
        fVar3 = (float)RectTransform.get_sizeDelta(lVar6,0);
        if (fVar3 == 0.0) {
        LAB_180a67253:
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
             (lVar6 = Component.GetComponent(this.highLightRect,DAT_181d6c740)) == null)
          throw; // [null/range check failed]
          RectTransform.get_sizeDelta(lVar6,0);
          if (extraout_var == 0.0) goto LAB_180a67253;
        }
        if (this.arrow != null) {
          lVar6 = GameObject.GetComponent(this.arrow,DAT_181da0b98);
          if (((this.highLightRect != null) &&
              (lVar7 = Component.GetComponent(this.highLightRect,DAT_181d6c740)) != null)
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
                  uVar8 = Component.GetComponent(lVar6,DAT_181d6d8c0);
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
                        uVar8 = GameObject.GetComponent(this.tutorialTextUI,DAT_181da0b98);
                        LayoutRebuilder.ForceRebuildLayoutImmediate(uVar8,0);
                        lVar6 = FUN_1800d60b0(DAT_181d81c40,4);
                        if ((this.highLightRect != null) &&
                           (lVar7 = Component.GetComponent(this.highLightRect,DAT_181d6c740),
                           lVar7 != null)) {
                          RectTransform.GetWorldCorners(lVar7,lVar6,0);
                          if ((this.highLightRect != null) &&
                             (lVar7 = Component.GetComponent(this.highLightRect,DAT_181d6c740)
                             , lVar7 != null)) {
                            pfVar10 = (float *)Transform.get_position(local_58,lVar7,0);
                            lVar7 = this.highLightRect;
                            if (0.0 < *pfVar10) {
                              if ((lVar7 == null) ||
                                 (lVar7 = Component.GetComponent(lVar7,DAT_181d6c740)) == null)
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
                                  FUN_1800d65f0(uVar8,0);
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
                                  FUN_1800d65f0(uVar8,0);
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
                                 (lVar7 = Component.GetComponent(lVar7,DAT_181d6c740)) == null)
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
                                  FUN_1800d65f0(uVar8,0);
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
                                  FUN_1800d65f0(uVar8,0);
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
                                                  (this.tutorialTextUI,DAT_181da0b98),
                               lVar6 != null)) {
                              RectTransform.set_pivot(lVar6,uVar8,0);
                              if (this.tutorialTextUI != null) {
                                lVar6 = GameObject.GetComponent
                                                  (this.tutorialTextUI,DAT_181da0b98);
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
                                                        (this.tutorialTextUI,DAT_181da0b98);
                                      puVar9 = (uint64 *)Vector3.get_zero(local_58,0);
                                      if (lVar6 != null) {
                                        local_60 = *(uint32 *)(puVar9 + 1);
                                        local_68 = *puVar9;
                                        Transform.set_localScale(lVar6,&local_68,0);
                                        if (this.tutorialTextUI != null) {
                                          uVar8 = GameObject.GetComponent
                                                            (this.tutorialTextUI,DAT_181da0b98);
                                          uVar8 = ShortcutExtensions.DOScale
                                                            (uVar8,0x3f800000,0x3e99999a,0);
                                          uVar8 = TweenSettingsExtensions.SetUpdate
                                                            (uVar8,1,DAT_181d98af0);
                                          uVar4 = new OnTooltipCB(this,DAT_181d96b30,0);
                                          TweenSettingsExtensions.OnComplete(uVar8,uVar4,DAT_181d96ee8);
                                          plVar11 = (int64 *)Resources.Load("Sound/SoundEffect/NoticeLittle",0);
                                          plVar12 = (int64 *)0;
                                          if ((plVar11 != (int64 *)0) && (*plVar11 == DAT_181d8a228))
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

    // Token : 0x600229F
    // RVA   : 0xA68520   Offset: 0xA66D20   Length: 0xE4
    public void TutorialCallPlot(string fucText)
    {
        uint uVar1;
        long lVar2;
        ulong uVar3;
        lVar2 = FUN_1800d60b0(DAT_181d7c118,1);
        if (lVar2 != null) {
          if (*(int *)(lVar2 + 24) == 0) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
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
                FUN_1800d65f0(uVar3,0);
              }
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
          }
        }
    }

    // Token : 0x60022A0
    // RVA   : 0xA66760   Offset: 0xA64F60   Length: 0x11
    public void HightLightRectClicked()
    {
        void FUN_180a66760(int64 this)
        {
        if (!this.textShowing) {
          TutorialController.ShowNextTutorialPlot(this,0,0);
          return;
        }
    }

    // Token : 0x60022A1
    // RVA   : 0xA66380   Offset: 0xA64B80   Length: 0x8D
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

    // Token : 0x60022A2
    // RVA   : 0xA6A2A0   Offset: 0xA68AA0   Length: 0xB3B
    public void TutorialSkillPowerSpeFuc()
    {
        var pStatics = *(int64*)(DAT_181d8b128 + 184);
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
        lVar4 = *(int64 *)(pStatics + 80);
        if ((lVar4 == null) || (lVar4 = *(int64 *)(lVar4 + 0x110)) == null) throw; // [null/range check failed]
        if (*(char *)(lVar4 + 176) != false) {
          lVar4 = *(int64 *)(pStatics + 80);
          lVar5 = *(int64 *)(pStatics + 80);
          if ((lVar5 == null) || (lVar4 == null)) throw; // [null/range check failed]
          cVar3 = BattleController.CanPlayerControl(lVar4,*(uint64 *)(lVar5 + 0x110),0);
          if (cVar3) {
            lVar4 = FUN_18046bb80(0);
            if (lVar4 == null) throw; // [null/range check failed]
            BattleController.AutoButtonClicked(lVar4,0);
          }
        }
        lVar4 = 0;
        local_res18[0] = 0;
        lVar5 = *(int64 *)(pStatics + 80);
        if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 0x110)) == null) ||
           (lVar5 = *(int64 *)(lVar5 + 64)) == null) throw; // [null/range check failed]
        if (*(int64 *)(lVar5 + 0x270) == 0) {
        LAB_180a6a71a:
          lVar5 = *(int64 *)(pStatics + 80);
          if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 0x110)) == null) ||
             (lVar5 = *(int64 *)(lVar5 + 64)) == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar5 + 0x280) != 0) {
            lVar5 = *(int64 *)(pStatics + 80);
            if ((((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 0x110)) == null) ||
                (lVar5 = *(int64 *)(lVar5 + 64)) == null) ||
               (lVar5 = *(int64 *)(lVar5 + 0x280)) == null) throw; // [null/range check failed]
            fVar1 = *(float *)(lVar5 + 100);
            lVar5 = *(int64 *)(pStatics + 80);
            if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 0x110)) == null) ||
               ((lVar5 = *(int64 *)(lVar5 + 64), lVar5 == null ||
                (lVar5 = *(int64 *)(lVar5 + 0x280)) == null))) throw; // [null/range check failed]
            fVar10 = (float)KungfuSkillLvData.MaxPower(lVar5,0);
            if (fVar10 <= fVar1) {
              local_res18[0] = 1;
              lVar4 = FUN_18046bb80(0);
              if (((lVar4 == null) || (*(int64 *)(lVar4 + 0x110) == 0)) ||
                 (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 0x110) + 64)) == null)
              throw; // [null/range check failed]
              lVar4 = *(int64 *)(lVar4 + 0x280);
              goto LAB_180a6aae9;
            }
          }
          lVar5 = *(int64 *)(pStatics + 80);
          if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 0x110)) == null) ||
             (lVar5 = *(int64 *)(lVar5 + 64)) == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar5 + 0x290) != 0) {
            lVar5 = FUN_18046bb80(0);
            if (((lVar5 == null) || (*(int64 *)(lVar5 + 0x110) == 0)) ||
               ((lVar5 = *(int64 *)(*(int64 *)(lVar5 + 0x110) + 64), lVar5 == null ||
                (lVar5 = *(int64 *)(lVar5 + 0x290)) == null))) throw; // [null/range check failed]
            fVar1 = *(float *)(lVar5 + 100);
            lVar5 = FUN_18046bb80(0);
            if ((((lVar5 == null) || (*(int64 *)(lVar5 + 0x110) == 0)) ||
                (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 0x110) + 64)) == null) ||
               (lVar5 = *(int64 *)(lVar5 + 0x290)) == null) throw; // [null/range check failed]
            fVar10 = (float)KungfuSkillLvData.MaxPower(lVar5,0);
            if (fVar10 <= fVar1) {
              local_res18[0] = 2;
              lVar4 = FUN_18046bb80(0);
              if (((lVar4 == null) || (*(int64 *)(lVar4 + 0x110) == 0)) ||
                 (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 0x110) + 64)) == null)
              throw; // [null/range check failed]
              lVar4 = *(int64 *)(lVar4 + 0x290);
            }
          }
        }
        else {
          lVar5 = *(int64 *)(pStatics + 80);
          if ((((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 0x110)) == null) ||
              (lVar5 = *(int64 *)(lVar5 + 64)) == null) ||
             (lVar5 = *(int64 *)(lVar5 + 0x270)) == null) throw; // [null/range check failed]
          fVar1 = *(float *)(lVar5 + 100);
          lVar5 = *(int64 *)(pStatics + 80);
          if (((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 0x110)) == null) ||
             ((lVar5 = *(int64 *)(lVar5 + 64), lVar5 == null ||
              (lVar5 = *(int64 *)(lVar5 + 0x270)) == null))) throw; // [null/range check failed]
          fVar10 = (float)KungfuSkillLvData.MaxPower(lVar5,0);
          if (fVar1 < fVar10) goto LAB_180a6a71a;
          lVar4 = FUN_18046bb80(0);
          if (((lVar4 == null) || (*(int64 *)(lVar4 + 0x110) == 0)) ||
             (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 0x110) + 64)) == null) throw; // [null/range check failed]
          lVar4 = *(int64 *)(lVar4 + 0x270);
        }
        LAB_180a6aae9:
        lVar5 = *(int64 *)(pStatics + 80);
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

    // Token : 0x60022A3
    // RVA   : 0xA68610   Offset: 0xA66E10   Length: 0x2AF
    public GameObject TutorialFindBuildingButton(string targetBuilding)
    {
        bool cVar1;
        int iVar2;
        long lVar3;
        ulong uVar5;
        int iVar6;
        iVar6 = 0;
        while( true ) {
          lVar3 = *(int64 *)(*(int64 *)(DAT_181d87630 + 184) + 56);
          if ((((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 128)) == null) ||
              (lVar3 = GameObject.get_transform(lVar3,0)) == null) ||
             (lVar3 = Transform.Find(lVar3,"BuildQuickButtonGrid",0)) == null) throw; // [null/range check failed]
          iVar2 = Transform.get_childCount(lVar3,0);
          if (iVar2 <= iVar6) {
            return 0;
          }
          lVar3 = FUN_18046bac0(0);
          if (((lVar3 == null) || (*(int64 *)(lVar3 + 128) == 0)) ||
             ((lVar3 = GameObject.get_transform(*(int64 *)(lVar3 + 128),0), lVar3 == null ||
              ((lVar3 = Transform.Find(lVar3,"BuildQuickButtonGrid",0), lVar3 == null ||
               (lVar3 = Transform.GetChild(lVar3,iVar6,0)) == null))))) throw; // [null/range check failed]
          lVar3 = Transform.Find(lVar3,"Text",0);
          if ((lVar3 == null) ||
             (plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181d6d8c0), plVar4 == (int64 *)0
             )) throw; // [null/range check failed]
          uVar5 = (**(code **)(*plVar4 + 0x5d8))(plVar4,*(uint64 *)(*plVar4 + 0x5e0));
          LTLocalization.GetText(targetBuilding,0,1,0);
          cVar1 = FUN_1816fd990(uVar5);
          if (cVar1) break;
          iVar6 = iVar6 + 1;
        }
        lVar3 = FUN_18046bac0(0);
        if ((((lVar3 != null) && (*(int64 *)(lVar3 + 128) != 0)) &&
            (lVar3 = GameObject.get_transform(*(int64 *)(lVar3 + 128),0)) != null) &&
           ((lVar3 = Transform.Find(lVar3,"BuildQuickButtonGrid",0), lVar3 != null &&
            (lVar3 = Transform.GetChild(lVar3,iVar6,0)) != null))) {
          uVar5 = Component.get_gameObject(lVar3,0);
          return uVar5;
        }
    }

    // Token : 0x60022A4
    // RVA   : 0xA688C0   Offset: 0xA670C0   Length: 0x249
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
          lVar3 = *(int64 *)(*(int64 *)(DAT_181d8ee60 + 184) + 8);
          if (((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 32)) == null) ||
             (lVar3 = GameObject.get_transform(lVar3,0)) == null) throw; // [null/range check failed]
          iVar2 = Transform.get_childCount(lVar3,0);
          if (iVar2 <= iVar6) {
            return 0;
          }
          lVar3 = FUN_18046bca0(0);
          if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
             ((lVar3 = GameObject.get_transform(*(int64 *)(lVar3 + 32),0), lVar3 == null ||
              (lVar3 = Transform.GetChild(lVar3,iVar6,0)) == null))) throw; // [null/range check failed]
          lVar3 = Transform.Find(lVar3,"Text",0);
          if ((lVar3 == null) ||
             (plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181d6d8c0), plVar4 == (int64 *)0
             )) throw; // [null/range check failed]
          uVar5 = (**(code **)(*plVar4 + 0x5d8))(plVar4,*(uint64 *)(*plVar4 + 0x5e0));
          LTLocalization.GetText(targetBuilding,0,1,0);
          cVar1 = FUN_1816fd990(uVar5);
          if (cVar1) break;
          iVar6 = iVar6 + 1;
        }
        lVar3 = FUN_18046bca0(0);
        if ((((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
            (lVar3 = GameObject.get_transform(*(int64 *)(lVar3 + 32),0)) != null) &&
           (lVar3 = Transform.GetChild(lVar3,iVar6,0)) != null) {
          uVar5 = Component.get_gameObject(lVar3,0);
          return uVar5;
        }
    }

    // Token : 0x60022A5
    // RVA   : 0xA66780   Offset: 0xA64F80   Length: 0x4C
    public void SetTutorialNoLeaveBuilding(string param)
    {
        byte uVar1;
        uVar1 = FUN_1816fd990(param,"true",0);
        this.tutorialNoLeaveBuilding = uVar1;
    }

    // Token : 0x60022A6
    // RVA   : 0xA6C860   Offset: 0xA6B060   Length: 0x16B
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

    // Token : 0x60022A7
    // RVA   : 0xA6BE60   Offset: 0xA6A660   Length: 0xDE
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

    // Token : 0x60022A8
    // RVA   : 0xA6C6F0   Offset: 0xA6AEF0   Length: 0x16B
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

    // Token : 0x60022A9
    // RVA   : 0xA6C9D0   Offset: 0xA6B1D0   Length: 0x16B
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

    // Token : 0x60022AA
    // RVA   : 0xA6E260   Offset: 0xA6CA60   Length: 0x16B
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

    // Token : 0x60022AB
    // RVA   : 0xA6C1E0   Offset: 0xA6A9E0   Length: 0x50A
    public void TutorialStartReadBookFindBook()
    {
        var pStatics = *(int64*)(DAT_181d8d678 + 184);
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
          if (iVar3 <= (int)uVar7) goto LAB_180a6c5df;
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
                (lVar4 = Component.GetComponent(lVar4,DAT_181d6bdc0)) == null))))) ||
             (*(int64 *)(lVar4 + 32) == 0)) throw; // [null/range check failed]
          cVar2 = FUN_1816fd990(*(uint64 *)(*(int64 *)(lVar4 + 32) + 32));
          if (cVar2) break;
          uVar7 = (uint64)((int)uVar7 + 1);
        }
        lVar4 = FUN_180a652c0(0);
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
        LAB_180a6c5df:
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

    // Token : 0x60022AC
    // RVA   : 0xA6D490   Offset: 0xA6BC90   Length: 0x16B
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

    // Token : 0x60022AD
    // RVA   : 0xA6D320   Offset: 0xA6BB20   Length: 0x16F
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

    // Token : 0x60022AE
    // RVA   : 0xA6D600   Offset: 0xA6BE00   Length: 0x1AE
    public void TutorialStartStudyFightFindPlotChoice()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
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
              if ((*pStatics != 0) &&
                 (lVar4 = *(int64 *)(*pStatics + 32)) != null) {
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

    // Token : 0x60022AF
    // RVA   : 0xA6D7B0   Offset: 0xA6BFB0   Length: 0x43E
    public void TutorialStartStudyFightFindSkillChoice()
    {
        var pStatics = *(int64*)(DAT_181d92370 + 184);
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
            if (iVar3 <= (int)uVar8) goto LAB_180a6dae3;
            if ((((((*pStatics == 0) ||
                   (lVar4 = *(int64 *)(*pStatics + 32)) == null) ||
                  (lVar4 = GameObject.get_transform(lVar4,0)) == null) ||
                 ((lVar4 = Transform.Find(lVar4,"Viewport",0), lVar4 == null ||
                  (lVar4 = Transform.Find(lVar4,"Content",0)) == null))) ||
                ((lVar4 = Transform.GetChild(lVar4,uVar8), lVar4 == null ||
                 ((lVar4 = Component.GetComponent(lVar4,DAT_181d6d240), lVar4 == null ||
                  (*(int64 *)(lVar4 + 32) == 0)))))) ||
               (lVar4 = KungfuSkillLvData.DataBase(*(int64 *)(lVar4 + 32),0)) == null)
            throw; // [null/range check failed]
            cVar2 = FUN_1816fd990(*(uint64 *)(lVar4 + 32));
            if (cVar2) break;
            uVar8 = (uint64)((int)uVar8 + 1);
          }
          lVar4 = FUN_18046bd60(0);
          if (((((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) &&
               (lVar4 = GameObject.get_transform(*(int64 *)(lVar4 + 32),0)) != null) &&
              ((lVar4 = Transform.Find(lVar4,"Viewport",0), lVar4 != null &&
               (lVar4 = Transform.Find(lVar4,"Content",0)) != null))) &&
             (lVar4 = Transform.GetChild(lVar4,uVar8,0)) != null) {
            uVar6 = Component.get_gameObject(lVar4,0);
        LAB_180a6dae3:
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

    // Token : 0x60022B0
    // RVA   : 0xA69B90   Offset: 0xA68390   Length: 0x180
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
               (lVar3 = FUN_180002f80(lVar3,this.nowTutorialPlotCount + 1,DAT_181d808f8)) != null) {
              *(uint8 *)(lVar3 + 68) = 1;
              if (((this.nowTutorial != null) &&
                  (lVar3 = this.nowTutorial.tutorialPlotDatas) != null) &&
                 (lVar3 = FUN_180002f80(lVar3,this.nowTutorialPlotCount + 1,DAT_181d808f8)) != null) {
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

    // Token : 0x60022B1
    // RVA   : 0xA69A60   Offset: 0xA68260   Length: 0x124
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

    // Token : 0x60022B2
    // RVA   : 0xA6B1F0   Offset: 0xA699F0   Length: 0x124
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

    // Token : 0x60022B3
    // RVA   : 0xA6B320   Offset: 0xA69B20   Length: 0x1AE
    public void TutorialStartBreakThroughFindPlotChoice()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
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
              if ((*pStatics != 0) &&
                 (lVar4 = *(int64 *)(*pStatics + 32)) != null) {
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

    // Token : 0x60022B4
    // RVA   : 0xA6B4D0   Offset: 0xA69CD0   Length: 0x5CF
    public void TutorialStartBreakThroughFindSkillChoice()
    {
        var pStatics = *(int64*)(DAT_181d92370 + 184);
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
                    (lVar4 = GameObject.GetComponent(lVar4,DAT_181da1630)) == null))))))) ||
                (*(int64 *)(lVar4 + 32) == 0)) ||
               (lVar4 = KungfuSkillLvData.DataBase(*(int64 *)(lVar4 + 32),0)) == null)
            throw; // [null/range check failed]
            cVar2 = FUN_1816fd990(*(uint64 *)(lVar4 + 32));
            if (cVar2) {
              lVar4 = FUN_18046bd60(0);
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

    // Token : 0x60022B5
    // RVA   : 0xA6DD20   Offset: 0xA6C520   Length: 0x16B
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

    // Token : 0x60022B6
    // RVA   : 0xA6DBF0   Offset: 0xA6C3F0   Length: 0x124
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

    // Token : 0x60022B7
    // RVA   : 0xA69D70   Offset: 0xA68570   Length: 0x7C
    public void TutorialQuickShowPlot()
    {
        DOTween.Complete("PlotTextDoText",0,0);
        DOTween.Complete("PlotChoiceDoScale",0,0);
    }

    // Token : 0x60022B8
    // RVA   : 0xA69830   Offset: 0xA68030   Length: 0x10A
    public void TutorialFocusOnMazePlayer()
    {
        var pStatics = *(int64*)(DAT_181da0c98 + 184);
        long lVar1;
        long lVar2;
        lVar1 = *(int64 *)(pStatics + 8);
        lVar2 = *(int64 *)(pStatics + 8);
        if ((lVar2 != null) && (lVar1 != null)) {
          ExploreController.FocusOnTarget(lVar1,*(uint64 *)(lVar2 + 144),0);
          return;
        }
    }

    // Token : 0x60022B9
    // RVA   : 0xA69720   Offset: 0xA67F20   Length: 0x10A
    public void TutorialFocusOnMazeEnd()
    {
        var pStatics = *(int64*)(DAT_181da0c98 + 184);
        long lVar1;
        long lVar2;
        lVar1 = *(int64 *)(pStatics + 8);
        lVar2 = *(int64 *)(pStatics + 8);
        if ((lVar2 != null) && (lVar1 != null)) {
          ExploreController.FocusOnTarget(lVar1,*(uint64 *)(lVar2 + 160),0);
          return;
        }
    }

    // Token : 0x60022BA
    // RVA   : 0xA68FC0   Offset: 0xA677C0   Length: 0x189
    public void TutorialFocusOnAreaCenter()
    {
        var pStatics = *(int64*)(DAT_181d87630 + 184);
        long lVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        lVar1 = *(int64 *)(pStatics + 56);
        lVar2 = *(int64 *)(pStatics + 56);
        lVar3 = *(int64 *)(pStatics + 56);
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

    // Token : 0x60022BB
    // RVA   : 0xA69FE0   Offset: 0xA687E0   Length: 0xD7
    public void TutorialShowHeroDetailItem()
    {
        var pStatics = *(int64*)(DAT_181d50f00 + 184);
        long lVar1;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
          lVar1 = GameObject.get_transform(lVar1,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"Tabs",0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"ItemTab",0);
              if (lVar1 != null) {
                lVar1 = Component.GetComponent(lVar1,DAT_181d6da40);
                if (lVar1 != null) {
                  Toggle.set_isOn(lVar1,1,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x60022BC
    // RVA   : 0xA6A0C0   Offset: 0xA688C0   Length: 0xEB
    public void TutorialShowMission()
    {
        var pStatics = *(int64*)(DAT_181d65970 + 184);
        long lVar1;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 104)) != null) {
          if (*(int *)(lVar1 + 24) == 0) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar1 = *(int64 *)(*(int64 *)(lVar1 + 16) + 32);
          if (lVar1 != null) {
            lVar1 = GameObject.GetComponent(lVar1,DAT_181da2130);
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

    // Token : 0x60022BD
    // RVA   : 0xA6A1B0   Offset: 0xA689B0   Length: 0xEB
    public void TutorialShowWorldNews()
    {
        var pStatics = *(int64*)(DAT_181d65970 + 184);
        long lVar1;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 104)) != null) {
          if (*(uint32 *)(lVar1 + 24) < 2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar1 = *(int64 *)(*(int64 *)(lVar1 + 16) + 40);
          if (lVar1 != null) {
            lVar1 = GameObject.GetComponent(lVar1,DAT_181da2130);
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

    // Token : 0x60022BE
    // RVA   : 0xA69D20   Offset: 0xA68520   Length: 0x49
    public void TutorialHideMission()
    {
        var pStatics = *(int64*)(DAT_181d65970 + 184);
        if (*pStatics != 0) {
          MissionUIController.ShowMissionUI(*pStatics,0,0);
          return;
        }
    }

    // Token : 0x60022BF
    // RVA   : 0xA69150   Offset: 0xA67950   Length: 0x298
    public void TutorialFocusOnArea(string _areaName)
    {
        var pStatics_baa8 = *(int64*)(DAT_181d8baa8 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        long lVar2;
        long lVar3;
        uint local_38;
        uint uStack_24;
        byte[] local_18 = new byte[16];
        if ((*pStatics_df90 != 0) &&
           (lVar3 = *(int64 *)(*pStatics_df90 + 32)) != null) {
          lVar3 = WorldData.GetArea(lVar3,_areaName,0);
          if (lVar3 == null) {
            return;
          }
          lVar1 = *(int64 *)(pStatics_baa8 + 16);
          lVar2 = *(int64 *)(pStatics_baa8 + 16);
          if ((((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 96)) != null) &&
              (lVar3 = FUN_1817cc780(lVar2,*(uint32 *)(lVar3 + 16),DAT_181d946c8)) != null) &&
             (lVar3 = GameObject.get_transform(lVar3,0)) != null) {
            puVar4 = (uint64 *)Transform.get_localPosition(local_18,lVar3,0);
            if (lVar1 != null) {
              local_38 = (uint32)*puVar4;
              uStack_24 = (uint32)((uint64)*puVar4 >> 32);
              *(uint32 *)(lVar1 + 160) = local_38;
              *(uint32 *)(lVar1 + 164) = uStack_24;
              lVar3 = *(int64 *)(pStatics_baa8 + 16);
              if (lVar3 != null) {
                BigMapController.TweenFocusTarget(lVar3,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60022C0
    // RVA   : 0xA69DF0   Offset: 0xA685F0   Length: 0x1E7
    public void TutorialSetMoveTargetArea(string _areaName)
    {
        var pStatics_baa8 = *(int64*)(DAT_181d8baa8 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        if ((*pStatics_df90 != 0) &&
           (lVar3 = *(int64 *)(*pStatics_df90 + 32)) != null) {
          lVar3 = WorldData.GetArea(lVar3,_areaName,0);
          if (lVar3 == null) {
            return;
          }
          lVar1 = *(int64 *)(pStatics_baa8 + 16);
          lVar2 = *(int64 *)(pStatics_baa8 + 16);
          if (((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 96)) != null) &&
             (uVar4 = FUN_1817cc780(lVar2,*(uint32 *)(lVar3 + 16),DAT_181d946c8), lVar1 != null)) {
            BigMapController.SetPlayerMoveTargetArea(lVar1,uVar4,0);
            return;
          }
        }
    }

    // Token : 0x60022C1
    // RVA   : 0xA68B10   Offset: 0xA67310   Length: 0x18E
    public GameObject TutorialFindMissionButton(string missionName)
    {
        var pStatics = *(int64*)(DAT_181d65970 + 184);
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
          lVar3 = Component.GetComponent(lVar3,DAT_181d6c240);
          if ((lVar3 == null) || (*(int64 *)(lVar3 + 24) == 0)) throw; // [null/range check failed]
          cVar1 = FUN_1816fd990(*(uint64 *)(*(int64 *)(lVar3 + 24) + 24));
          if (cVar1) break;
          iVar5 = iVar5 + 1;
        }
        lVar3 = FUN_18077c240(0);
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

    // Token : 0x60022C2
    // RVA   : 0xA6B0C0   Offset: 0xA698C0   Length: 0x124
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

    // Token : 0x60022C3
    // RVA   : 0xA6E0F0   Offset: 0xA6C8F0   Length: 0x16B
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

    // Token : 0x60022C4
    // RVA   : 0xA6DFC0   Offset: 0xA6C7C0   Length: 0x124
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

    // Token : 0x60022C5
    // RVA   : 0xA6BAA0   Offset: 0xA6A2A0   Length: 0x16B
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

    // Token : 0x60022C6
    // RVA   : 0xA6CC70   Offset: 0xA6B470   Length: 0x16B
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

    // Token : 0x60022C7
    // RVA   : 0xA6CB40   Offset: 0xA6B340   Length: 0x124
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

    // Token : 0x60022C8
    // RVA   : 0xA6CDE0   Offset: 0xA6B5E0   Length: 0x1AE
    public void TutorialStartRestFindPlotChoice()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
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
              if ((*pStatics != 0) &&
                 (lVar4 = *(int64 *)(*pStatics + 32)) != null) {
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

    // Token : 0x60022C9
    // RVA   : 0xA6CF90   Offset: 0xA6B790   Length: 0x124
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

    // Token : 0x60022CA
    // RVA   : 0xA6DE90   Offset: 0xA6C690   Length: 0x124
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

    // Token : 0x60022CB
    // RVA   : 0xA67EE0   Offset: 0xA666E0   Length: 0x318
    public void TutorialAskForItemFindPlotChoice()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
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
          if ((*pStatics != 0) &&
             (lVar5 = *(int64 *)(*pStatics + 32)) != null) {
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
                              if ((*pStatics != 0) &&
                                 (lVar5 = *(int64 *)(*pStatics + 32),
                                 lVar5 != null)) {
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

    // Token : 0x60022CC
    // RVA   : 0xA68200   Offset: 0xA66A00   Length: 0x318
    public void TutorialAskForSkillFindPlotChoice()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
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
          if ((*pStatics != 0) &&
             (lVar5 = *(int64 *)(*pStatics + 32)) != null) {
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
                              if ((*pStatics != 0) &&
                                 (lVar5 = *(int64 *)(*pStatics + 32),
                                 lVar5 != null)) {
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

    // Token : 0x60022CD
    // RVA   : 0xA68CA0   Offset: 0xA674A0   Length: 0x311
    public void TutorialFindPlotChoice(string choiceString)
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
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
          if ((*pStatics != 0) &&
             (lVar5 = *(int64 *)(*pStatics + 32)) != null) {
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
                              if ((*pStatics != 0) &&
                                 (lVar5 = *(int64 *)(*pStatics + 32),
                                 lVar5 != null)) {
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

    // Token : 0x60022CE
    // RVA   : 0xA66590   Offset: 0xA64D90   Length: 0x1C3
    public void HighLightPlotChoiceIncludeText(string targetString)
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
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
          if ((*pStatics != 0) &&
             (lVar5 = *(int64 *)(*pStatics + 32)) != null) {
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

    // Token : 0x60022CF
    // RVA   : 0xA66410   Offset: 0xA64C10   Length: 0x174
    public int FindPlotChoiceIncludeText(string targetString)
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        bool cVar1;
        long lVar2;
        int iVar3;
        iVar3 = 0;
        while( true ) {
          if (((*pStatics == 0) ||
              (lVar2 = *(int64 *)(*pStatics + 168)) == null) ||
             (lVar2 = *(int64 *)(lVar2 + 56)) == null) break;
          if (*(int *)(lVar2 + 24) <= iVar3) {
            return 0;
          }
          lVar2 = FUN_18046c440(0);
          if (((lVar2 == null) || (*(int64 *)(lVar2 + 168) == 0)) ||
             (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 168) + 56)) == null) break;
          lVar2 = FUN_180002f80(lVar2,iVar3,DAT_181d79958);
          if ((lVar2 == null) || (*(int64 *)(lVar2 + 16) == 0)) break;
          cVar1 = String.Contains(*(int64 *)(lVar2 + 16),targetString,0);
          if (cVar1) {
            return iVar3;
          }
          iVar3 = iVar3 + 1;
        }
    }

    // Token : 0x60022D0
    // RVA   : 0xA6C070   Offset: 0xA6A870   Length: 0x16B
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

    // Token : 0x60022D1
    // RVA   : 0xA6BF40   Offset: 0xA6A740   Length: 0x124
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

    // Token : 0x60022D2
    // RVA   : 0xA6ADE0   Offset: 0xA695E0   Length: 0x2D9
    public void TutorialStartAttackForceFindBuildingChoice()
    {
        var pStatics = *(int64*)(DAT_181d4e188 + 184);
        uint uVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        if (((((*pStatics != 0) &&
              (lVar3 = *(int64 *)(*pStatics + 72)) != null) &&
             (lVar3 = GameObject.get_transform(lVar3,0)) != null) &&
            ((lVar3 = Transform.Find(lVar3,"BuildingUI",0), lVar3 != null &&
             (lVar3 = Transform.Find(lVar3,"BuildingButtonScrollView",0)) != null))) &&
           (lVar3 = Component.GetComponent(lVar3,DAT_181d6c940)) != null) {
          Behaviour.set_enabled(lVar3,1,0);
          if ((((*pStatics != 0) &&
               (lVar3 = *(int64 *)(*pStatics + 72)) != null) &&
              ((lVar3 = GameObject.get_transform(lVar3,0), lVar3 != null &&
               (((lVar3 = Transform.Find(lVar3,"BuildingUI",0), lVar3 != null &&
                 (lVar3 = Transform.Find(lVar3,"BuildingButtonScrollView",0)) != null) &&
                (lVar3 = Transform.Find(lVar3,"Scrollbar Vertical",0)) != null))))) &&
             (lVar3 = Component.GetComponent(lVar3,DAT_181d6c9c0)) != null) {
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

    // Token : 0x60022D3
    // RVA   : 0xA6D1F0   Offset: 0xA6B9F0   Length: 0x124
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

    // Token : 0x60022D4
    // RVA   : 0xA6D0C0   Offset: 0xA6B8C0   Length: 0x124
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

    // Token : 0x60022D5
    // RVA   : 0xA6BC10   Offset: 0xA6A410   Length: 0xDE
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

    // Token : 0x60022D6
    // RVA   : 0xA693F0   Offset: 0xA67BF0   Length: 0x324
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
          lVar2 = *(int64 *)(*(int64 *)(DAT_181d8b128 + 184) + 80);
          if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 112)) == null) goto LAB_180a6970f;
          if (*(int *)(lVar2 + 24) <= iVar5) break;
          iVar4 = 0;
          while( true ) {
            lVar2 = FUN_18046bb80(0);
            if ((lVar2 == null) || (*(int64 *)(lVar2 + 112) == 0)) goto LAB_180a6970f;
            lVar2 = FUN_180002f80();
            if ((lVar2 == null) || (*(int64 *)(lVar2 + 24) == 0)) goto LAB_180a6970f;
            if (*(int *)(*(int64 *)(lVar2 + 24) + 24) <= iVar4) goto LAB_180a6968c;
            lVar2 = FUN_18046bb80(0);
            if ((lVar2 == null) || (*(int64 *)(lVar2 + 112) == 0)) goto LAB_180a6970f;
            lVar2 = FUN_180002f80(*(int64 *)(lVar2 + 112),iVar5,DAT_181d580a8);
            if ((lVar2 == null) || (*(int64 *)(lVar2 + 24) == 0)) goto LAB_180a6970f;
            lVar2 = FUN_180002f80(*(int64 *)(lVar2 + 24),iVar4,DAT_181d584a0);
            if (((lVar2 == null) || (*(int64 *)(lVar2 + 64) == 0)) ||
               (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 64) + 104)) == null)
            goto LAB_180a6970f;
            cVar1 = String.Contains(lVar2,_targetName,0);
            if (cVar1) break;
            iVar4 = iVar4 + 1;
          }
          lVar2 = FUN_18046bb80(0);
          if ((lVar2 == null) || (*(int64 *)(lVar2 + 112) == 0)) goto LAB_180a6970f;
          lVar2 = FUN_180002f80(*(int64 *)(lVar2 + 112),iVar5,DAT_181d580a8);
          if ((lVar2 == null) || (*(int64 *)(lVar2 + 24) == 0)) goto LAB_180a6970f;
          lVar2 = FUN_180002f80();
          if (lVar2 == null) goto LAB_180a6970f;
          uVar3 = Component.get_gameObject(lVar2);
        LAB_180a6968c:
          iVar5 = iVar5 + 1;
        }
        cVar1 = Object.op_Inequality(uVar3,0,0);
        if (cVar1) {
          lVar2 = FUN_18046bb80(0);
          if (lVar2 == null) {
        LAB_180a6970f:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          BattleController.FocusOnTarget(lVar2,uVar3,0);
        }
    }

    // Token : 0x60022D7
    // RVA   : 0xA69940   Offset: 0xA68140   Length: 0x119
    public void TutorialFocusOnNowActive()
    {
        var pStatics = *(int64*)(DAT_181d8b128 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        lVar1 = *(int64 *)(pStatics + 80);
        lVar2 = *(int64 *)(pStatics + 80);
        if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 0x110)) != null) {
          uVar3 = Component.get_gameObject(lVar2,0);
          if (lVar1 != null) {
            BattleController.FocusOnTarget(lVar1,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x60022D8
    // RVA   : 0xA667D0   Offset: 0xA64FD0   Length: 0x103
    public void ShowComboUI()
    {
        var pStatics = *(int64*)(DAT_181d82f70 + 184);
        long lVar1;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 88)) != null) {
          lVar1 = Component.get_transform(lVar1,0);
          if (lVar1 != null) {
            lVar1 = FUN_180da0f00(lVar1,0);
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

    // Token : 0x60022D9
    // RVA   : 0xA6E3E0   Offset: 0xA6CBE0   Length: 0x103
    public void UnshowComboUI()
    {
        var pStatics = *(int64*)(DAT_181d82f70 + 184);
        long lVar1;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 88)) != null) {
          lVar1 = Component.get_transform(lVar1,0);
          if (lVar1 != null) {
            lVar1 = FUN_180da0f00(lVar1,0);
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

    // Token : 0x60022DA
    // RVA   : 0xA6BCF0   Offset: 0xA6A4F0   Length: 0x16B
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

    // Token : 0x60022DB
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x60022DC
    // RVA   : 0xA6E3D0   Offset: 0xA6CBD0   Length: 0x5
    private void <ShowNextTutorialPlot>b__15_0()
    {
        void FUN_180a6e3d0(int64 this)
        {
        this.textShowing = 0;
    }

}
