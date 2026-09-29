// ============================================================
// Type  : ChapterController
// Token : 0x20001B6
// ============================================================

public class ChapterController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000BD9
    public GameObject chapterUIPanel;

    // Token: 0x4000BDA
    public bool showFinished;

    // Token: 0x4000BDB
    public static List<string> chapterTitles;

    // Token: 0x4000BDC
    private static ChapterController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E76
    // RVA   : 0x995E40   Offset: 0x995240   Length: 0x58
    public static ChapterController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181db6e48 + 184) + 8);
    }

    // Token : 0x6000E77
    // RVA   : 0x993FD0   Offset: 0x9933D0   Length: 0x68
    private void Awake()
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181db6e48 + 184) + 8);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6000E78
    // RVA   : 0x994040   Offset: 0x993440   Length: 0xDA5
    public void ChangeChapter(int targetChapter)
    {
        uint uVar1;
        int iVar2;
        long lVar3;
        long lVar4;
        ulong uVar7;
        ulong uVar8;
        uint local_68;
        uint uStack_64;
        uint uStack_60;
        uint32 uStack_5c;
        uint64 local_58;
        uint64 uStack_50;
        uint64 local_48;
        uint64 uStack_40;
        uint8 local_38 [48];
        if (**(int **)(DAT_181d73d40 + 184) == 2) {
          if ((GameController._instance != null) &&
             (lVar3 = GameController._instance.worldData) != null) {
            lVar3.openForceAttackResource = 1;
            if ((GameController._instance != null) &&
               (lVar3 = GameController._instance.worldData) != null) {
              lVar3.openForceAttackArea = 1;
              if ((GameController._instance != null) &&
                 (lVar3 = GameController._instance.worldData) != null) {
                lVar3.openForceAttackBasement = 1;
                return;
              }
            }
          }
          throw; // [null/range check failed]
        }
        uVar1 = Mathf.Clamp(targetChapter,0,3);
        if ((GameController._instance == null) ||
           (lVar3 = GameController._instance.worldData) == null)
        throw; // [null/range check failed]
        lVar3.chapter = uVar1;
        if ((GameController._instance == null) ||
           (lVar3 = GameController._instance.worldData) == null)
        throw; // [null/range check failed]
        lVar3.openForceBuilding = 1;
        if (uVar1 == 0) {
          lVar3 = FUN_18046c0a0(0);
          if ((lVar3 == null) || (lVar3.villageAreaID == null)) throw; // [null/range check failed]
          *(uint8 *)(lVar3.villageAreaID + 0x10a) = 0;
        LAB_18099448a:
          lVar3 = FUN_18046c0a0(0);
          if ((lVar3 == null) || (lVar3.villageAreaID == null)) throw; // [null/range check failed]
          *(uint8 *)(lVar3.villageAreaID + 0x10b) = 0;
        }
        else {
          if (uVar1 == 1) {
            lVar3 = FUN_18046c0a0(0);
            if ((lVar3 == null) || (lVar3.villageAreaID == null)) throw; // [null/range check failed]
            *(uint8 *)(lVar3.villageAreaID + 0x10a) = 1;
            goto LAB_18099448a;
          }
          if (uVar1 != 2) {
            if (uVar1 == 3) {
              lVar3 = FUN_18046c0a0(0);
              if ((lVar3 != null) && (lVar3.villageAreaID != null)) {
                *(uint8 *)(lVar3.villageAreaID + 0x10a) = 1;
                lVar3 = FUN_18046c0a0(0);
                if ((lVar3 != null) && (lVar3.villageAreaID != null)) {
                  *(uint8 *)(lVar3.villageAreaID + 0x10b) = 1;
                  lVar3 = FUN_18046c0a0(0);
                  if (lVar3 != null) {
                    lVar3 = lVar3.villageAreaID;
                    lVar4 = FUN_18046c0a0(0);
                    if ((((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) &&
                        (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 32) + 232)) != null) &&
                       (iVar2 = PlotEventLogData.GetInt(lVar4,"FinalChapterPlotEnd",0), lVar3 != null)) {
                      lVar3.openForceAttackBasement = iVar2 == 1;
                      goto LAB_1809944d2;
                    }
                  }
                }
              }
              throw; // [null/range check failed]
            }
            goto LAB_1809944d2;
          }
          lVar3 = FUN_18046c0a0(0);
          if ((lVar3 == null) || (lVar3.villageAreaID == null)) throw; // [null/range check failed]
          *(uint8 *)(lVar3.villageAreaID + 0x10a) = 1;
          lVar3 = FUN_18046c0a0(0);
          if ((lVar3 == null) || (lVar3.villageAreaID == null)) throw; // [null/range check failed]
          *(uint8 *)(lVar3.villageAreaID + 0x10b) = 1;
        }
        lVar3 = FUN_18046c0a0(0);
        if ((lVar3 != null) && (lVar3.villageAreaID != null)) {
          *(uint8 *)(lVar3.villageAreaID + 0x10c) = 0;
        LAB_1809944d2:
          if (this.chapterUIPanel != null) {
            GameObject.SetActive(this.chapterUIPanel,1,0);
            if (((this.chapterUIPanel != null) &&
                (lVar3 = GameObject.get_transform(this.chapterUIPanel,0)) != null) &&
               (lVar3 = Transform.Find(lVar3,"BlackBackground",0)) != null) {
              plVar5 = (int64 *)Component.GetComponent(lVar3,DAT_181d94478);
              puVar6 = (uint32 *)FUN_180d995f0(&local_68,0);
              if (plVar5 != (int64 *)0) {
                local_68 = *puVar6;
                uStack_64 = puVar6[1];
                uStack_60 = puVar6[2];
                uStack_5c = puVar6[3];
                (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_68,*(uint64 *)(*plVar5 + 0x2b0));
                if (((this.chapterUIPanel != null) &&
                    (lVar3 = GameObject.get_transform(this.chapterUIPanel,0)) != null) &&
                   (lVar3 = Transform.Find(lVar3,"BlackBackground",0)) != null) {
                  uVar7 = Component.GetComponent(lVar3,DAT_181d94478);
                  uVar7 = DOTweenModuleUI.DOFade(uVar7,0x3f733333,0x40000000,0);
                  uVar8 = new OnTooltipCB(this,DAT_181d8fc08,0);
                  TweenSettingsExtensions.OnComplete(uVar7,uVar8,DAT_181dc0160);
                  if (((this.chapterUIPanel != null) &&
                      (lVar3 = GameObject.get_transform(this.chapterUIPanel,0)) != null) &&
                     (lVar3 = Transform.Find(lVar3,"Back",0)) != null) {
                    plVar5 = (int64 *)Component.GetComponent(lVar3,DAT_181d94478);
                    local_58 = 0;
                    uStack_50 = 0;
                    FUN_1809dcfa0(&local_58,0x3f800000,0x3f800000,0x3f800000,0,0);
                    if (plVar5 != (int64 *)0) {
                      local_68 = (uint32)local_58;
                      uStack_64 = local_58._4_4_;
                      uStack_60 = (uint32)uStack_50;
                      uStack_5c = uStack_50._4_4_;
                      (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_68,*(uint64 *)(*plVar5 + 0x2b0));
                      if (((this.chapterUIPanel != null) &&
                          (lVar3 = GameObject.get_transform(this.chapterUIPanel,0)) != null
                          ) && (lVar3 = Transform.Find(lVar3,"TitleBack",0)) != null) {
                        plVar5 = (int64 *)Component.GetComponent(lVar3,DAT_181d94478);
                        local_48 = 0;
                        uStack_40 = 0;
                        FUN_1809dcfa0(&local_48,0x3f800000,0x3f800000,0x3f800000,0,0);
                        if (plVar5 != (int64 *)0) {
                          local_68 = (uint32)local_48;
                          uStack_64 = local_48._4_4_;
                          uStack_60 = (uint32)uStack_40;
                          uStack_5c = uStack_40._4_4_;
                          (**(code **)(*plVar5 + 0x2a8))
                                    (plVar5,&local_68,*(uint64 *)(*plVar5 + 0x2b0));
                          if (((this.chapterUIPanel != null) &&
                              (lVar3 = GameObject.get_transform(this.chapterUIPanel,0),
                              lVar3 != null)) && (lVar3 = Transform.Find(lVar3,"TitleBack",0)) != null
                             ) {
                            local_68 = 0;
                            uStack_64 = 0x3f800000;
                            uStack_60 = 0x3f800000;
                            Transform.set_localScale(lVar3,&local_68,0);
                            if (((this.chapterUIPanel != null) &&
                                (lVar3 = GameObject.get_transform(this.chapterUIPanel,0),
                                lVar3 != null)) &&
                               (lVar3 = Transform.Find(lVar3,"Chapter",0)) != null) {
                              uVar7 = Component.GetComponent(lVar3,DAT_181d96178);
                              uVar8 = GlobalData.GetNumText(uVar1 + 1,0);
                              uVar8 = String.Format("第{0}章",uVar8,0);
                              LTLocalization.SetText(uVar7,uVar8,0);
                              if (((this.chapterUIPanel != null) &&
                                  (lVar3 = GameObject.get_transform(this.chapterUIPanel,0),
                                  lVar3 != null)) &&
                                 (lVar3 = Transform.Find(lVar3,"Chapter",0)) != null) {
                                plVar5 = (int64 *)Component.GetComponent(lVar3,DAT_181d96178);
                                if (((this.chapterUIPanel != null) &&
                                    (lVar3 = GameObject.get_transform(this.chapterUIPanel,0),
                                    lVar3 != null)) &&
                                   ((lVar3 = Transform.Find(lVar3,"Chapter",0), lVar3 != null &&
                                    (plVar9 = (int64 *)Component.GetComponent(lVar3,DAT_181d96178),
                                    plVar9 != (int64 *)0)))) {
                                  puVar6 = (uint32 *)
                                           (**(code **)(*plVar9 + 0x298))
                                                     (&local_68,plVar9,*(uint64 *)(*plVar9 + 0x2a0));
                                  local_68 = *puVar6;
                                  uStack_64 = puVar6[1];
                                  uStack_60 = puVar6[2];
                                  uStack_5c = puVar6[3];
                                  puVar6 = (uint32 *)GlobalData.SetColorAlpha(local_38,&local_68,0,0)
                                  ;
                                  if (plVar5 != (int64 *)0) {
                                    local_68 = *puVar6;
                                    uStack_64 = puVar6[1];
                                    uStack_60 = puVar6[2];
                                    uStack_5c = puVar6[3];
                                    (**(code **)(*plVar5 + 0x2a8))
                                              (plVar5,&local_68,*(uint64 *)(*plVar5 + 0x2b0));
                                    if (((this.chapterUIPanel != null) &&
                                        (lVar3 = GameObject.get_transform
                                                           (this.chapterUIPanel,0), lVar3 != null))
                                       && (lVar3 = Transform.Find(lVar3,"Title",0)) != null) {
                                      uVar7 = Component.GetComponent(lVar3,DAT_181d96178);
                                      lVar3 = ChapterController.chapterTitles;
                                      if (lVar3 != null) {
                                        if (lVar3.cityAreaID <= uVar1) {
                                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                        }
                                        LTLocalization.SetText
                                                  (uVar7,*(uint64 *)
                                                          (lVar3.chapter + 32 +
                                                          (int64)(int)uVar1 * 8),0);
                                        if (((this.chapterUIPanel != null) &&
                                            (lVar3 = GameObject.get_transform
                                                               (this.chapterUIPanel,0),
                                            lVar3 != null)) &&
                                           (lVar3 = Transform.Find(lVar3,"Title",0)) != null) {
                                          plVar5 = (int64 *)
                                                   Component.GetComponent(lVar3,DAT_181d96178);
                                          if (((this.chapterUIPanel != null) &&
                                              (lVar3 = GameObject.get_transform
                                                                 (this.chapterUIPanel,0),
                                              lVar3 != null)) &&
                                             ((lVar3 = Transform.Find(lVar3,"Title",0), lVar3 != null
                                              && (plVar9 = (int64 *)
                                                           Component.GetComponent(lVar3,DAT_181d96178),
                                                 plVar9 != (int64 *)0)))) {
                                            puVar6 = (uint32 *)
                                                     (**(code **)(*plVar9 + 0x298))
                                                               (local_38,plVar9,
                                                                *(uint64 *)(*plVar9 + 0x2a0));
                                            local_68 = *puVar6;
                                            uStack_64 = puVar6[1];
                                            uStack_60 = puVar6[2];
                                            uStack_5c = puVar6[3];
                                            puVar6 = (uint32 *)
                                                     GlobalData.SetColorAlpha(local_38,&local_68,0,0);
                                            if (plVar5 != (int64 *)0) {
                                              local_68 = *puVar6;
                                              uStack_64 = puVar6[1];
                                              uStack_60 = puVar6[2];
                                              uStack_5c = puVar6[3];
                                              (**(code **)(*plVar5 + 0x2a8))
                                                        (plVar5,&local_68,*(uint64 *)(*plVar5 + 0x2b0)
                                                        );
                                              if (((this.chapterUIPanel != null) &&
                                                  (lVar3 = GameObject.get_transform
                                                                     (this.chapterUIPanel,0),
                                                  lVar3 != null)) &&
                                                 (lVar3 = Transform.Find(lVar3,"Describe",0),
                                                 lVar3 != null)) {
                                                uVar7 = Component.GetComponent(lVar3,DAT_181d96178);
                                                uVar8 = ChapterController.GetChapterDescribe
                                                                  (this,"\n\n",0);
                                                LTLocalization.SetText(uVar7,uVar8,0);
                                                if (((this.chapterUIPanel != null) &&
                                                    (lVar3 = GameObject.get_transform
                                                                       (this.chapterUIPanel,0),
                                                    lVar3 != null)) &&
                                                   (lVar3 = Transform.Find(lVar3,"Describe",0),
                                                   lVar3 != null)) {
                                                  plVar5 = (int64 *)
                                                           Component.GetComponent(lVar3,DAT_181d96178);
                                                  if (((this.chapterUIPanel != null) &&
                                                      (lVar3 = GameObject.get_transform
                                                                         (this.chapterUIPanel,0)
                                                      , lVar3 != null)) &&
                                                     ((lVar3 = Transform.Find(lVar3,"Describe",0),
                                                      lVar3 != null &&
                                                      (plVar9 = (int64 *)
                                                                Component.GetComponent
                                                                          (lVar3,DAT_181d96178),
                                                      plVar9 != (int64 *)0)))) {
                                                    puVar6 = (uint32 *)
                                                             (**(code **)(*plVar9 + 0x298))
                                                                       (local_38,plVar9,
                                                                        *(uint64 *)(*plVar9 + 0x2a0));
                                                    local_68 = *puVar6;
                                                    uStack_64 = puVar6[1];
                                                    uStack_60 = puVar6[2];
                                                    uStack_5c = puVar6[3];
                                                    puVar6 = (uint32 *)
                                                             GlobalData.SetColorAlpha
                                                                       (local_38,&local_68,0,0);
                                                    if (plVar5 != (int64 *)0) {
                                                      local_68 = *puVar6;
                                                      uStack_64 = puVar6[1];
                                                      uStack_60 = puVar6[2];
                                                      uStack_5c = puVar6[3];
                                                      (**(code **)(*plVar5 + 0x2a8))
                                                                (plVar5,&local_68,
                                                                 *(uint64 *)(*plVar5 + 0x2b0));
                                                      this.showFinished = 0;
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
                }
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x6000E79
    // RVA   : 0x994DF0   Offset: 0x9941F0   Length: 0x5D4
    public string GetChapterDescribe(string newLine)
    {
        ulong uVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        float fVar6;
        float[] local_res20 = new float[2];
        local_res20[0] = 0.0;
        plVar1 = (int64 *)FUN_1800d60b0(DAT_181da4138,5);
        uVar5 = "天下大势：{4}{0}门派 {1}攻击资源{4}门派 {2}攻击城镇{4}门派 {3}攻击京城/总舵";
        if ((GameController._instance != null) &&
           (lVar4 = GameController._instance.worldData) != null) {
          lVar3 = "";
          if (lVar4.gameMode == null) {
            if ((GameController._instance == null) ||
               (lVar4 = GameController._instance.worldData) == null)
            throw; // [null/range check failed]
            fVar6 = (float)WorldData.GetChapterBadFameRate(lVar4,0);
            local_res20[0] = (fVar6 - 1.0) * 100.0;
            uVar2 = Single.ToString(local_res20,"+0;-0;0",0);
            lVar3 = String.Format("全局恶名修正{0}%{1}",uVar2,newLine,0);
          }
          if (plVar1 != (int64 *)0) {
            if ((lVar3 != null) &&
               (lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar1 + 64))) == null) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            if ((int)plVar1[3] == 0) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            plVar1[4] = lVar3;
            il2cpp_internal(plVar1 + 4,lVar3);
            if ((GameController._instance != null) &&
               (lVar4 = GameController._instance.worldData) != null) {
              lVar3 = "不可";
              if (lVar4.openForceAttackResource) {
                lVar3 = "可以";
              }
              if ((lVar3 != null) &&
                 (lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar1 + 64))) == null) {
                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar5,0);
              }
              if (*(uint32 *)(plVar1 + 3) < 2) {
                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar5,0);
              }
              plVar1[5] = lVar3;
              il2cpp_internal(plVar1 + 5,lVar3);
              if ((GameController._instance != null) &&
                 (lVar4 = GameController._instance.worldData) != null) {
                lVar3 = "不可";
                if (lVar4.openForceAttackArea) {
                  lVar3 = "可以";
                }
                if ((lVar3 != null) &&
                   (lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar1 + 64))) == null) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar5,0);
                }
                if (*(uint32 *)(plVar1 + 3) < 3) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar5,0);
                }
                plVar1[6] = lVar3;
                il2cpp_internal(plVar1 + 6,lVar3);
                if ((GameController._instance != null) &&
                   (lVar4 = GameController._instance.worldData) != null) {
                  lVar3 = "不可";
                  if (lVar4.openForceAttackBasement) {
                    lVar3 = "可以";
                  }
                  if ((lVar3 != null) &&
                     (lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar1 + 64))) == null) {
                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar5,0);
                  }
                  if (*(uint32 *)(plVar1 + 3) < 4) {
                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar5,0);
                  }
                  plVar1[7] = lVar3;
                  il2cpp_internal(plVar1 + 7,lVar3);
                  if ((newLine != null) &&
                     (lVar4 = il2cpp_internal(newLine,*(uint64 *)(*plVar1 + 64))) == null) {
                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar5,0);
                  }
                  if (*(uint32 *)(plVar1 + 3) < 5) {
                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar5,0);
                  }
                  plVar1[8] = newLine;
                  il2cpp_internal(plVar1 + 8,newLine);
                  String.Format(uVar5,plVar1,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000E7A
    // RVA   : 0x995CE0   Offset: 0x9950E0   Length: 0x35
    public void Update()
    {
        bool cVar1;
        if (this.showFinished) {
          cVar1 = Input.GetMouseButtonUp(0,0);
          if (cVar1) {
            this.showFinished = 0;
            ChapterController.UnshowChapterUI(this,0);
            return;
          }
        }
    }

    // Token : 0x6000E7B
    // RVA   : 0x9954A0   Offset: 0x9948A0   Length: 0x45F
    public void ShowChaperUI()
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181dafae0 + 184) + 8);
        if (lVar1 != null) {
          BGMController.SetPlotBgm(lVar1,"MainTheme",0);
          if (this.chapterUIPanel != null) {
            lVar1 = GameObject.get_transform(this.chapterUIPanel,0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"Chapter",0);
              if (lVar1 != null) {
                uVar2 = Component.GetComponent(lVar1,DAT_181d96178);
                DOTweenModuleUI.DOFade(uVar2,0x3f800000,0x40400000,0);
                if (this.chapterUIPanel != null) {
                  lVar1 = GameObject.get_transform(this.chapterUIPanel,0);
                  if (lVar1 != null) {
                    lVar1 = Transform.Find(lVar1,"Title",0);
                    if (lVar1 != null) {
                      uVar2 = Component.GetComponent(lVar1,DAT_181d96178);
                      uVar2 = DOTweenModuleUI.DOFade(uVar2,0x3f800000,0x40400000,0);
                      TweenSettingsExtensions.SetDelay(uVar2,0x40800000,DAT_181dc0c78);
                      if (this.chapterUIPanel != null) {
                        lVar1 = GameObject.get_transform(this.chapterUIPanel,0);
                        if (lVar1 != null) {
                          lVar1 = Transform.Find(lVar1,"Back",0);
                          if (lVar1 != null) {
                            uVar2 = Component.GetComponent(lVar1,DAT_181d94478);
                            uVar2 = DOTweenModuleUI.DOFade(uVar2,0x3f800000,0x40400000,0);
                            TweenSettingsExtensions.SetDelay(uVar2,0x40800000,DAT_181dc0c78);
                            if (this.chapterUIPanel != null) {
                              lVar1 = GameObject.get_transform(this.chapterUIPanel,0);
                              if (lVar1 != null) {
                                lVar1 = Transform.Find(lVar1,"TitleBack",0);
                                if (lVar1 != null) {
                                  uVar2 = Component.GetComponent(lVar1,DAT_181d94478);
                                  uVar2 = DOTweenModuleUI.DOFade(uVar2,0x3f800000,0x40400000,0);
                                  TweenSettingsExtensions.SetDelay(uVar2,0x40800000,DAT_181dc0c78);
                                  if (this.chapterUIPanel != null) {
                                    lVar1 = GameObject.get_transform(this.chapterUIPanel,0);
                                    if (lVar1 != null) {
                                      uVar2 = Transform.Find(lVar1,"TitleBack",0);
                                      uVar2 = ShortcutExtensions.DOScaleX(uVar2,0x3f800000,0x40400000,0);
                                      uVar2 = TweenSettingsExtensions.SetDelay
                                                        (uVar2,0x40800000,DAT_181dc0e10);
                                      TweenSettingsExtensions.SetEase(uVar2,9,DAT_181dc1128);
                                      if (this.chapterUIPanel != null) {
                                        lVar1 = GameObject.get_transform(this.chapterUIPanel,0)
                                        ;
                                        if (lVar1 != null) {
                                          lVar1 = Transform.Find(lVar1,"Describe",0);
                                          if (lVar1 != null) {
                                            uVar2 = Component.GetComponent(lVar1,DAT_181d96178);
                                            uVar2 = DOTweenModuleUI.DOFade(uVar2,0x3f800000,0x40400000,0)
                                            ;
                                            uVar2 = TweenSettingsExtensions.SetDelay
                                                              (uVar2,0x41100000,DAT_181dc0c78);
                                            uVar3 = new OnTooltipCB(this,DAT_181d8fb08,0);
                                            TweenSettingsExtensions.OnComplete(uVar2,uVar3,DAT_181dc0160)
                                            ;
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
    }

    // Token : 0x6000E7C
    // RVA   : 0x995910   Offset: 0x994D10   Length: 0x3C0
    public void UnshowChapterUI()
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        if (this.chapterUIPanel != null) {
          lVar1 = GameObject.get_transform(this.chapterUIPanel,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"Chapter",0);
            if (lVar1 != null) {
              uVar2 = Component.GetComponent(lVar1,DAT_181d96178);
              DOTweenModuleUI.DOFade(uVar2,0,0x40400000,0);
              if (this.chapterUIPanel != null) {
                lVar1 = GameObject.get_transform(this.chapterUIPanel,0);
                if (lVar1 != null) {
                  lVar1 = Transform.Find(lVar1,"Title",0);
                  if (lVar1 != null) {
                    uVar2 = Component.GetComponent(lVar1,DAT_181d96178);
                    DOTweenModuleUI.DOFade(uVar2,0,0x40400000,0);
                    if (this.chapterUIPanel != null) {
                      lVar1 = GameObject.get_transform(this.chapterUIPanel,0);
                      if (lVar1 != null) {
                        lVar1 = Transform.Find(lVar1,"Back",0);
                        if (lVar1 != null) {
                          uVar2 = Component.GetComponent(lVar1,DAT_181d94478);
                          DOTweenModuleUI.DOFade(uVar2,0,0x40400000,0);
                          if (this.chapterUIPanel != null) {
                            lVar1 = GameObject.get_transform(this.chapterUIPanel,0);
                            if (lVar1 != null) {
                              lVar1 = Transform.Find(lVar1,"TitleBack",0);
                              if (lVar1 != null) {
                                uVar2 = Component.GetComponent(lVar1,DAT_181d94478);
                                DOTweenModuleUI.DOFade(uVar2,0,0x40400000,0);
                                if (this.chapterUIPanel != null) {
                                  lVar1 = GameObject.get_transform(this.chapterUIPanel,0);
                                  if (lVar1 != null) {
                                    uVar2 = Transform.Find(lVar1,"TitleBack",0);
                                    uVar2 = ShortcutExtensions.DOScaleX(uVar2,0,0x40400000,0);
                                    TweenSettingsExtensions.SetEase(uVar2,9,DAT_181dc1128);
                                    if (this.chapterUIPanel != null) {
                                      lVar1 = GameObject.get_transform(this.chapterUIPanel,0);
                                      if (lVar1 != null) {
                                        lVar1 = Transform.Find(lVar1,"Describe",0);
                                        if (lVar1 != null) {
                                          uVar2 = Component.GetComponent(lVar1,DAT_181d96178);
                                          DOTweenModuleUI.DOFade(uVar2,0,0x40400000,0);
                                          if (this.chapterUIPanel != null) {
                                            lVar1 = GameObject.get_transform
                                                              (this.chapterUIPanel,0);
                                            if (lVar1 != null) {
                                              lVar1 = Transform.Find(lVar1,"BlackBackground",0);
                                              if (lVar1 != null) {
                                                uVar2 = Component.GetComponent(lVar1,DAT_181d94478);
                                                uVar2 = DOTweenModuleUI.DOFade(uVar2,0,0x40000000,0);
                                                uVar2 = TweenSettingsExtensions.SetDelay
                                                                  (uVar2,0x40000000,DAT_181dc0c78);
                                                uVar3 = new OnTooltipCB(this,DAT_181d8fb88,0);
                                                uVar2 = TweenSettingsExtensions.OnComplete
                                                                  (uVar2,uVar3,DAT_181dc0160);
                                                TweenSettingsExtensions.SetEase(uVar2,8,DAT_181dc0e88);
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
          }
        }
    }

    // Token : 0x6000E7D
    // RVA   : 0x9953D0   Offset: 0x9947D0   Length: 0xCA
    public void HideChapterUI()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181dafae0 + 184) + 8);
        if (lVar1 != null) {
          BGMController.SetPlotBgm(lVar1,0xffffffff);
          if (this.chapterUIPanel != null) {
            GameObject.SetActive(this.chapterUIPanel,0,0);
            return;
          }
        }
    }

    // Token : 0x6000E7E
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6000E7F
    // RVA   : 0x995D20   Offset: 0x995120   Length: 0x114
    private static void /*cctor*/()
    {
        long lVar2;
        lVar2 = il2cpp_internal(DAT_181d97768);
        FUN_181330100(lVar2,DAT_181da3bf0);
        if (lVar2 != null) {
          FUN_18181e6b0(lVar2,"蜀中仙云映霞光",DAT_181da3d70);
          FUN_18181e6b0(lVar2,"峨眉夜雨打苍茫",DAT_181da3d70);
          FUN_18181e6b0(lVar2,"江湖翻沸壮士死",DAT_181da3d70);
          FUN_18181e6b0(lVar2,"山河泣血战未央",DAT_181da3d70);
          plVar1 = *(int64 **)(DAT_181db6e48 + 184);
          *plVar1 = lVar2;
          il2cpp_internal(plVar1,lVar2);
          return;
        }
    }

    // Token : 0x6000E80
    // RVA   : 0x995900   Offset: 0x994D00   Length: 0x5
    private void <ShowChaperUI>b__10_0()
    {
        void FUN_180995900(int64 this)
        {
        this.showFinished = 1;
    }

}
