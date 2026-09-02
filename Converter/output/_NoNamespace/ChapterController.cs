// ============================================================
// Type  : ChapterController
// Token : 0x20001B0
// ============================================================

public class ChapterController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000B4D
    public GameObject chapterUIPanel;

    // Token: 0x4000B4E
    public bool showFinished;

    // Token: 0x4000B4F
    public static List<string> chapterTitles;

    // Token: 0x4000B50
    private static ChapterController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E41
    // RVA   : 0x9F3080   Offset: 0x9F1880   Length: 0x58
    public static ChapterController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d91c88 + 184) + 8);
    }

    // Token : 0x6000E42
    // RVA   : 0x9F1240   Offset: 0x9EFA40   Length: 0x68
    private void Awake()
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d91c88 + 184) + 8);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6000E43
    // RVA   : 0x9F12B0   Offset: 0x9EFAB0   Length: 0xD78
    public void ChangeChapter(int targetChapter)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
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
        if (**(int **)(DAT_181d4ef00 + 184) == 2) {
          if ((*pStatics != 0) &&
             (lVar3 = *(int64 *)(*pStatics + 32)) != null) {
            *(uint8 *)(lVar3 + 0x10a) = 1;
            if ((*pStatics != 0) &&
               (lVar3 = *(int64 *)(*pStatics + 32)) != null) {
              *(uint8 *)(lVar3 + 0x10b) = 1;
              if ((*pStatics != 0) &&
                 (lVar3 = *(int64 *)(*pStatics + 32)) != null) {
                *(uint8 *)(lVar3 + 0x10c) = 1;
                return;
              }
            }
          }
          throw; // [null/range check failed]
        }
        uVar1 = Mathf.Clamp(targetChapter,0,3);
        if ((*pStatics == 0) ||
           (lVar3 = *(int64 *)(*pStatics + 32)) == null)
        throw; // [null/range check failed]
        *(uint32 *)(lVar3 + 16) = uVar1;
        if ((*pStatics == 0) ||
           (lVar3 = *(int64 *)(*pStatics + 32)) == null)
        throw; // [null/range check failed]
        *(uint8 *)(lVar3 + 0x109) = 1;
        if (uVar1 == 0) {
          lVar3 = FUN_18046c0a0(0);
          if ((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) throw; // [null/range check failed]
          *(uint8 *)(*(int64 *)(lVar3 + 32) + 0x10a) = 0;
        LAB_1809f16ee:
          lVar3 = FUN_18046c0a0(0);
          if ((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) throw; // [null/range check failed]
          *(uint8 *)(*(int64 *)(lVar3 + 32) + 0x10b) = 0;
        }
        else {
          if (uVar1 == 1) {
            lVar3 = FUN_18046c0a0(0);
            if ((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) throw; // [null/range check failed]
            *(uint8 *)(*(int64 *)(lVar3 + 32) + 0x10a) = 1;
            goto LAB_1809f16ee;
          }
          if (uVar1 != 2) {
            if (uVar1 == 3) {
              lVar3 = FUN_18046c0a0(0);
              if ((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) {
                *(uint8 *)(*(int64 *)(lVar3 + 32) + 0x10a) = 1;
                lVar3 = FUN_18046c0a0(0);
                if ((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) {
                  *(uint8 *)(*(int64 *)(lVar3 + 32) + 0x10b) = 1;
                  lVar3 = FUN_18046c0a0(0);
                  if (lVar3 != null) {
                    lVar3 = *(int64 *)(lVar3 + 32);
                    lVar4 = FUN_18046c0a0(0);
                    if ((((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) &&
                        (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 32) + 232)) != null) &&
                       (iVar2 = PlotEventLogData.GetInt(lVar4,"FinalChapterPlotEnd",0), lVar3 != null)) {
                      *(bool *)(lVar3 + 0x10c) = iVar2 == 1;
                      goto LAB_1809f1736;
                    }
                  }
                }
              }
              throw; // [null/range check failed]
            }
            goto LAB_1809f1736;
          }
          lVar3 = FUN_18046c0a0(0);
          if ((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) throw; // [null/range check failed]
          *(uint8 *)(*(int64 *)(lVar3 + 32) + 0x10a) = 1;
          lVar3 = FUN_18046c0a0(0);
          if ((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) throw; // [null/range check failed]
          *(uint8 *)(*(int64 *)(lVar3 + 32) + 0x10b) = 1;
        }
        lVar3 = FUN_18046c0a0(0);
        if ((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) {
          *(uint8 *)(*(int64 *)(lVar3 + 32) + 0x10c) = 0;
        LAB_1809f1736:
          if (this.chapterUIPanel != null) {
            GameObject.SetActive(this.chapterUIPanel,1,0);
            if (((this.chapterUIPanel != null) &&
                (lVar3 = GameObject.get_transform(this.chapterUIPanel,0)) != null) &&
               (lVar3 = Transform.Find(lVar3,"BlackBackground",0)) != null) {
              plVar5 = (int64 *)Component.GetComponent(lVar3,DAT_181d6bc40);
              puVar6 = (uint32 *)FUN_180d904c0(&local_68,0);
              if (plVar5 != (int64 *)0) {
                local_68 = *puVar6;
                uStack_64 = puVar6[1];
                uStack_60 = puVar6[2];
                uStack_5c = puVar6[3];
                (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_68,*(uint64 *)(*plVar5 + 0x2b0));
                if (((this.chapterUIPanel != null) &&
                    (lVar3 = GameObject.get_transform(this.chapterUIPanel,0)) != null) &&
                   (lVar3 = Transform.Find(lVar3,"BlackBackground",0)) != null) {
                  uVar7 = Component.GetComponent(lVar3,DAT_181d6bc40);
                  uVar7 = DOTweenModuleUI.DOFade(uVar7,0x3f733333,0x40000000,0);
                  uVar8 = new OnTooltipCB(this,DAT_181d673d0,0);
                  TweenSettingsExtensions.OnComplete(uVar7,uVar8,DAT_181d96cc8);
                  if (((this.chapterUIPanel != null) &&
                      (lVar3 = GameObject.get_transform(this.chapterUIPanel,0)) != null) &&
                     (lVar3 = Transform.Find(lVar3,"Back",0)) != null) {
                    plVar5 = (int64 *)Component.GetComponent(lVar3,DAT_181d6bc40);
                    local_58 = 0;
                    uStack_50 = 0;
                    FUN_1809981e0(&local_58,0x3f800000,0x3f800000,0x3f800000,0,0);
                    if (plVar5 != (int64 *)0) {
                      local_68 = (uint32)local_58;
                      uStack_64 = local_58._4_4_;
                      uStack_60 = (uint32)uStack_50;
                      uStack_5c = uStack_50._4_4_;
                      (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_68,*(uint64 *)(*plVar5 + 0x2b0));
                      if (((this.chapterUIPanel != null) &&
                          (lVar3 = GameObject.get_transform(this.chapterUIPanel,0)) != null
                          ) && (lVar3 = Transform.Find(lVar3,"TitleBack",0)) != null) {
                        plVar5 = (int64 *)Component.GetComponent(lVar3,DAT_181d6bc40);
                        local_48 = 0;
                        uStack_40 = 0;
                        FUN_1809981e0(&local_48,0x3f800000,0x3f800000,0x3f800000,0,0);
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
                              uVar7 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                              uVar8 = GlobalData.GetNumText(uVar1 + 1,0);
                              uVar8 = String.Format("第{0}章",uVar8,0);
                              LTLocalization.SetText(uVar7,uVar8,0);
                              if (((this.chapterUIPanel != null) &&
                                  (lVar3 = GameObject.get_transform(this.chapterUIPanel,0),
                                  lVar3 != null)) &&
                                 (lVar3 = Transform.Find(lVar3,"Chapter",0)) != null) {
                                plVar5 = (int64 *)Component.GetComponent(lVar3,DAT_181d6d8c0);
                                if ((((this.chapterUIPanel != null) &&
                                     (lVar3 = GameObject.get_transform(this.chapterUIPanel,0),
                                     lVar3 != null)) &&
                                    (lVar3 = Transform.Find(lVar3,"Chapter",0)) != null) &&
                                   (plVar9 = (int64 *)Component.GetComponent(lVar3,DAT_181d6d8c0),
                                   plVar9 != (int64 *)0)) {
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
                                      uVar7 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                                      lVar3 = **(int64 **)(DAT_181d91c88 + 184);
                                      if (lVar3 != null) {
                                        if (*(uint32 *)(lVar3 + 24) <= uVar1) {
                                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                        }
                                        LTLocalization.SetText
                                                  (uVar7,*(uint64 *)
                                                          (*(int64 *)(lVar3 + 16) + 32 +
                                                          (int64)(int)uVar1 * 8),0);
                                        if (((this.chapterUIPanel != null) &&
                                            (lVar3 = GameObject.get_transform
                                                               (this.chapterUIPanel,0),
                                            lVar3 != null)) &&
                                           (lVar3 = Transform.Find(lVar3,"Title",0)) != null) {
                                          plVar5 = (int64 *)
                                                   Component.GetComponent(lVar3,DAT_181d6d8c0);
                                          if (((this.chapterUIPanel != null) &&
                                              (lVar3 = GameObject.get_transform
                                                                 (this.chapterUIPanel,0),
                                              lVar3 != null)) &&
                                             ((lVar3 = Transform.Find(lVar3,"Title",0), lVar3 != null
                                              && (plVar9 = (int64 *)
                                                           Component.GetComponent(lVar3,DAT_181d6d8c0),
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
                                                uVar7 = Component.GetComponent(lVar3,DAT_181d6d8c0);
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
                                                           Component.GetComponent(lVar3,DAT_181d6d8c0);
                                                  if (((this.chapterUIPanel != null) &&
                                                      (lVar3 = GameObject.get_transform
                                                                         (this.chapterUIPanel,0)
                                                      , lVar3 != null)) &&
                                                     ((lVar3 = Transform.Find(lVar3,"Describe",0),
                                                      lVar3 != null &&
                                                      (plVar9 = (int64 *)
                                                                Component.GetComponent
                                                                          (lVar3,DAT_181d6d8c0),
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

    // Token : 0x6000E44
    // RVA   : 0x9F2030   Offset: 0x9F0830   Length: 0x5D4
    public string GetChapterDescribe(string newLine)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        ulong uVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        float fVar6;
        float[] local_res20 = new float[2];
        local_res20[0] = 0.0;
        plVar1 = (int64 *)FUN_1800d60b0(DAT_181d7f180,5);
        uVar5 = "天下大势：{4}{0}门派 {1}攻击资源{4}门派 {2}攻击城镇{4}门派 {3}攻击京城/总舵";
        if ((*pStatics != 0) &&
           (lVar4 = *(int64 *)(*pStatics + 32)) != null) {
          lVar3 = "";
          if (*(int *)(lVar4 + 156) == 0) {
            if ((*pStatics == 0) ||
               (lVar4 = *(int64 *)(*pStatics + 32)) == null)
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
            if ((*pStatics != 0) &&
               (lVar4 = *(int64 *)(*pStatics + 32)) != null) {
              lVar3 = "不可";
              if (*(char *)(lVar4 + 0x10a) != false) {
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
              if ((*pStatics != 0) &&
                 (lVar4 = *(int64 *)(*pStatics + 32)) != null) {
                lVar3 = "不可";
                if (*(char *)(lVar4 + 0x10b) != false) {
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
                if ((*pStatics != 0) &&
                   (lVar4 = *(int64 *)(*pStatics + 32)) != null) {
                  lVar3 = "不可";
                  if (*(char *)(lVar4 + 0x10c) != false) {
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

    // Token : 0x6000E45
    // RVA   : 0x9F2F20   Offset: 0x9F1720   Length: 0x35
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

    // Token : 0x6000E46
    // RVA   : 0x9F26E0   Offset: 0x9F0EE0   Length: 0x45F
    public void ShowChaperUI()
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d8a9a8 + 184) + 8);
        if (lVar1 != null) {
          BGMController.SetPlotBgm(lVar1,"MainTheme",0);
          if (this.chapterUIPanel != null) {
            lVar1 = GameObject.get_transform(this.chapterUIPanel,0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"Chapter",0);
              if (lVar1 != null) {
                uVar2 = Component.GetComponent(lVar1,DAT_181d6d8c0);
                DOTweenModuleUI.DOFade(uVar2,0x3f800000,0x40400000,0);
                if (this.chapterUIPanel != null) {
                  lVar1 = GameObject.get_transform(this.chapterUIPanel,0);
                  if (lVar1 != null) {
                    lVar1 = Transform.Find(lVar1,"Title",0);
                    if (lVar1 != null) {
                      uVar2 = Component.GetComponent(lVar1,DAT_181d6d8c0);
                      uVar2 = DOTweenModuleUI.DOFade(uVar2,0x3f800000,0x40400000,0);
                      TweenSettingsExtensions.SetDelay(uVar2,0x40800000,DAT_181d977e0);
                      if (this.chapterUIPanel != null) {
                        lVar1 = GameObject.get_transform(this.chapterUIPanel,0);
                        if (lVar1 != null) {
                          lVar1 = Transform.Find(lVar1,"Back",0);
                          if (lVar1 != null) {
                            uVar2 = Component.GetComponent(lVar1,DAT_181d6bc40);
                            uVar2 = DOTweenModuleUI.DOFade(uVar2,0x3f800000,0x40400000,0);
                            TweenSettingsExtensions.SetDelay(uVar2,0x40800000,DAT_181d977e0);
                            if (this.chapterUIPanel != null) {
                              lVar1 = GameObject.get_transform(this.chapterUIPanel,0);
                              if (lVar1 != null) {
                                lVar1 = Transform.Find(lVar1,"TitleBack",0);
                                if (lVar1 != null) {
                                  uVar2 = Component.GetComponent(lVar1,DAT_181d6bc40);
                                  uVar2 = DOTweenModuleUI.DOFade(uVar2,0x3f800000,0x40400000,0);
                                  TweenSettingsExtensions.SetDelay(uVar2,0x40800000,DAT_181d977e0);
                                  if (this.chapterUIPanel != null) {
                                    lVar1 = GameObject.get_transform(this.chapterUIPanel,0);
                                    if (lVar1 != null) {
                                      uVar2 = Transform.Find(lVar1,"TitleBack",0);
                                      uVar2 = ShortcutExtensions.DOScaleX(uVar2,0x3f800000,0x40400000,0);
                                      uVar2 = TweenSettingsExtensions.SetDelay
                                                        (uVar2,0x40800000,DAT_181d97978);
                                      TweenSettingsExtensions.SetEase(uVar2,9,DAT_181d97ca8);
                                      if (this.chapterUIPanel != null) {
                                        lVar1 = GameObject.get_transform(this.chapterUIPanel,0)
                                        ;
                                        if (lVar1 != null) {
                                          lVar1 = Transform.Find(lVar1,"Describe",0);
                                          if (lVar1 != null) {
                                            uVar2 = Component.GetComponent(lVar1,DAT_181d6d8c0);
                                            uVar2 = DOTweenModuleUI.DOFade(uVar2,0x3f800000,0x40400000,0)
                                            ;
                                            uVar2 = TweenSettingsExtensions.SetDelay
                                                              (uVar2,0x41100000,DAT_181d977e0);
                                            uVar3 = new OnTooltipCB(this,DAT_181d672d0,0);
                                            TweenSettingsExtensions.OnComplete(uVar2,uVar3,DAT_181d96cc8)
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

    // Token : 0x6000E47
    // RVA   : 0x9F2B50   Offset: 0x9F1350   Length: 0x3C0
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
              uVar2 = Component.GetComponent(lVar1,DAT_181d6d8c0);
              DOTweenModuleUI.DOFade(uVar2,0,0x40400000,0);
              if (this.chapterUIPanel != null) {
                lVar1 = GameObject.get_transform(this.chapterUIPanel,0);
                if (lVar1 != null) {
                  lVar1 = Transform.Find(lVar1,"Title",0);
                  if (lVar1 != null) {
                    uVar2 = Component.GetComponent(lVar1,DAT_181d6d8c0);
                    DOTweenModuleUI.DOFade(uVar2,0,0x40400000,0);
                    if (this.chapterUIPanel != null) {
                      lVar1 = GameObject.get_transform(this.chapterUIPanel,0);
                      if (lVar1 != null) {
                        lVar1 = Transform.Find(lVar1,"Back",0);
                        if (lVar1 != null) {
                          uVar2 = Component.GetComponent(lVar1,DAT_181d6bc40);
                          DOTweenModuleUI.DOFade(uVar2,0,0x40400000,0);
                          if (this.chapterUIPanel != null) {
                            lVar1 = GameObject.get_transform(this.chapterUIPanel,0);
                            if (lVar1 != null) {
                              lVar1 = Transform.Find(lVar1,"TitleBack",0);
                              if (lVar1 != null) {
                                uVar2 = Component.GetComponent(lVar1,DAT_181d6bc40);
                                DOTweenModuleUI.DOFade(uVar2,0,0x40400000,0);
                                if (this.chapterUIPanel != null) {
                                  lVar1 = GameObject.get_transform(this.chapterUIPanel,0);
                                  if (lVar1 != null) {
                                    uVar2 = Transform.Find(lVar1,"TitleBack",0);
                                    uVar2 = ShortcutExtensions.DOScaleX(uVar2,0,0x40400000,0);
                                    TweenSettingsExtensions.SetEase(uVar2,9,DAT_181d97ca8);
                                    if (this.chapterUIPanel != null) {
                                      lVar1 = GameObject.get_transform(this.chapterUIPanel,0);
                                      if (lVar1 != null) {
                                        lVar1 = Transform.Find(lVar1,"Describe",0);
                                        if (lVar1 != null) {
                                          uVar2 = Component.GetComponent(lVar1,DAT_181d6d8c0);
                                          DOTweenModuleUI.DOFade(uVar2,0,0x40400000,0);
                                          if (this.chapterUIPanel != null) {
                                            lVar1 = GameObject.get_transform
                                                              (this.chapterUIPanel,0);
                                            if (lVar1 != null) {
                                              lVar1 = Transform.Find(lVar1,"BlackBackground",0);
                                              if (lVar1 != null) {
                                                uVar2 = Component.GetComponent(lVar1,DAT_181d6bc40);
                                                uVar2 = DOTweenModuleUI.DOFade(uVar2,0,0x40000000,0);
                                                uVar2 = TweenSettingsExtensions.SetDelay
                                                                  (uVar2,0x40000000,DAT_181d977e0);
                                                uVar3 = new OnTooltipCB(this,DAT_181d67350,0);
                                                uVar2 = TweenSettingsExtensions.OnComplete
                                                                  (uVar2,uVar3,DAT_181d96cc8);
                                                TweenSettingsExtensions.SetEase(uVar2,8,DAT_181d97a00);
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

    // Token : 0x6000E48
    // RVA   : 0x9F2610   Offset: 0x9F0E10   Length: 0xCA
    public void HideChapterUI()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d8a9a8 + 184) + 8);
        if (lVar1 != null) {
          BGMController.SetPlotBgm(lVar1,0xffffffff);
          if (this.chapterUIPanel != null) {
            GameObject.SetActive(this.chapterUIPanel,0,0);
            return;
          }
        }
    }

    // Token : 0x6000E49
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6000E4A
    // RVA   : 0x9F2F60   Offset: 0x9F1760   Length: 0x114
    private static void /*cctor*/()
    {
        long lVar2;
        lVar2 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar2,DAT_181d7c250);
        if (lVar2 != null) {
          FUN_181827900(lVar2,"蜀中仙云映霞光",DAT_181d7c3d0);
          FUN_181827900(lVar2,"峨眉夜雨打苍茫",DAT_181d7c3d0);
          FUN_181827900(lVar2,"江湖翻沸壮士死",DAT_181d7c3d0);
          FUN_181827900(lVar2,"山河泣血战未央",DAT_181d7c3d0);
          plVar1 = *(int64 **)(DAT_181d91c88 + 184);
          *plVar1 = lVar2;
          il2cpp_internal(plVar1,lVar2);
          return;
        }
    }

    // Token : 0x6000E4B
    // RVA   : 0x9F2B40   Offset: 0x9F1340   Length: 0x5
    private void <ShowChaperUI>b__10_0()
    {
        void FUN_1809f2b40(int64 this)
        {
        this.showFinished = 1;
    }

}
