// ============================================================
// Type  : GameResultController
// Token : 0x20002B3
// ============================================================

public class GameResultController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40015D4
    public int nowResultID;

    // Token: 0x40015D5
    public int nowTextID;

    // Token: 0x40015D6
    public GameObject gameEndPanel;

    // Token: 0x40015D7
    public GameObject gameResultCreditPanel;

    // Token: 0x40015D8
    public string extraInfo;

    // Token: 0x40015D9
    public static List<string> gameResultName;

    // Token: 0x40015DA
    public List<GameEndPlotData> gameEndPlotDatas;

    // Token: 0x40015DB
    private static GameResultController _instance;

    // Token: 0x40015DC
    private bool textShowing;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600171F
    // RVA   : 0x6BEF60   Offset: 0x6BDD60   Length: 0x58
    public static GameResultController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181e52b18 + 184) + 8);
    }

    // Token : 0x6001720
    // RVA   : 0x6BA990   Offset: 0x6B9790   Length: 0x68
    private void Awake()
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181e52b18 + 184) + 8);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6001721
    // RVA   : 0x6BAC40   Offset: 0x6B9A40   Length: 0x7
    public void ContinueButtonClicked()
    {
        void FUN_1806bac40(uint64 this)
        {
        GameResultController.HideResultCredit(this,0);
    }

    // Token : 0x6001722
    // RVA   : 0x6BB040   Offset: 0x6B9E40   Length: 0x91
    public void QuitButtonClicked()
    {
        if (**(int64 **)(DAT_181e52980 + 184) != 0) {
          SceneManager.LoadScene("TitleScene",0);
          return;
        }
    }

    // Token : 0x6001723
    // RVA   : 0x6BAC50   Offset: 0x6B9A50   Length: 0x217
    public void HideResultCredit()
    {
        var pStatics = *(int64*)(DAT_181e6af70 + 184);
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
          GameObject.SetActive(lVar1,1,0);
          if (this.gameResultCreditPanel != null) {
            lVar1 = GameObject.get_transform(this.gameResultCreditPanel,0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"Continue",0);
              if (lVar1 != null) {
                lVar1 = Component.GetComponent(lVar1,DAT_181e76ab8);
                if (lVar1 != null) {
                  Selectable.set_interactable(lVar1,0,0);
                  if (this.gameResultCreditPanel != null) {
                    lVar1 = GameObject.get_transform(this.gameResultCreditPanel,0);
                    if (lVar1 != null) {
                      lVar1 = Transform.Find(lVar1,"Quit",0);
                      if (lVar1 != null) {
                        lVar1 = Component.GetComponent(lVar1,DAT_181e76ab8);
                        if (lVar1 != null) {
                          Selectable.set_interactable(lVar1,0,0);
                          if (this.gameResultCreditPanel != null) {
                            uVar2 = GameObject.GetComponent(this.gameResultCreditPanel,DAT_181e53ed0);
                            uVar2 = DOTweenModuleUI.DOFade(uVar2,0,0x3f800000,0);
                            uVar2 = TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181ea58d0);
                            uVar3 = new OnTooltipCB(this,DAT_181e58bd8,0);
                            TweenSettingsExtensions.OnComplete(uVar2,uVar3,DAT_181ea3c28);
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

    // Token : 0x6001724
    // RVA   : 0x6BB0E0   Offset: 0x6B9EE0   Length: 0x1C32
    public void ShowResultCredit()
    {
        int iVar1;
        uint uVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        long lVar8;
        ulong uVar9;
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        ulong local_c8;
        ulong uStack_c0;
        ulong local_b8;
        uint local_b0;
        uint local_a8;
        uint local_a4;
        uint local_a0;
        uint32 local_9c;
        uint64 local_98;
        uint64 uStack_90;
        uint64 local_88;
        uint64 uStack_80;
        uint64 local_78;
        uint64 uStack_70;
        uint64 local_68;
        uint64 uStack_60;
        lVar4 = il2cpp_internal(DAT_181e77728);
        FUN_1810f3480(lVar4,DAT_181e861f0);
        if (lVar4 != null) {
          FUN_18175de30(lVar4,"至圣",DAT_181e86370);
          FUN_18175de30(lVar4,"大侠",DAT_181e86370);
          FUN_18175de30(lVar4,"义士",DAT_181e86370);
          FUN_18175de30(lVar4,"中庸",DAT_181e86370);
          FUN_18175de30(lVar4,"叛逆",DAT_181e86370);
          FUN_18175de30(lVar4,"枭雄",DAT_181e86370);
          FUN_18175de30(lVar4,"魔首",DAT_181e86370);
          if ((((this.gameResultCreditPanel != null) &&
               (lVar5 = GameObject.get_transform(this.gameResultCreditPanel,0)) != null) &&
              (lVar5 = Transform.Find(lVar5,"Continue",0)) != null) &&
             (lVar5 = Component.GetComponent(lVar5,DAT_181e76ab8)) != null) {
            Selectable.set_interactable(lVar5,1,0);
            if (((this.gameResultCreditPanel != null) &&
                (lVar5 = GameObject.get_transform(this.gameResultCreditPanel,0)) != null) &&
               ((lVar5 = Transform.Find(lVar5,"Quit",0), lVar5 != null &&
                (lVar5 = Component.GetComponent(lVar5,DAT_181e76ab8)) != null))) {
              Selectable.set_interactable(lVar5,1,0);
              if (this.gameResultCreditPanel != null) {
                GameObject.SetActive(this.gameResultCreditPanel,1,0);
                if ((this.gameResultCreditPanel != null) &&
                   (lVar5 = GameObject.GetComponent(this.gameResultCreditPanel,DAT_181e53ed0),
                   lVar5 != null)) {
                  CanvasGroup.set_alpha(lVar5);
                  if ((this.gameResultCreditPanel != null) &&
                     ((lVar5 = GameObject.get_transform(this.gameResultCreditPanel,0), lVar5 != null &&
                      (lVar5 = Transform.Find(lVar5,"Count",0)) != null))) {
                    uVar6 = Component.GetComponent(lVar5,DAT_181e79538);
                    plVar7 = (int64 *)FUN_1801dfd90(DAT_181e84278,12);
                    lVar5 = PlotController.attriIndexCache;
                    if (lVar5 != null) {
                      uVar3 = this.nowResultID;
                      if (lVar5.cityAreaID <= uVar3) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar5 = String.Concat(*(uint64 *)
                                              (lVar5.chapter + 32 +
                                              (int64)(int)uVar3 * 8),this.extraInfo,0)
                      ;
                      if (plVar7 != (int64 *)0) {
                        if ((lVar5 != null) &&
                           (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64)), lVar8 == null
                           )) {
                          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1801e02d0(uVar6,0);
                        }
                        if ((int)plVar7[3] == 0) {
                          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1801e02d0(uVar6,0);
                        }
                        plVar7[4] = lVar5;
                        il2cpp_internal(plVar7 + 4,lVar5);
                        if ((GameController._instance != null) &&
                           (lVar5 = GameController._instance.worldData,
                           lVar5 != null)) {
                          lVar5 = WorldData.GetDifficlutyName(lVar5,0);
                          if ((lVar5 != null) &&
                             (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64)),
                             lVar8 == null)) {
                            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1801e02d0(uVar6,0);
                          }
                          if (*(uint32 *)(plVar7 + 3) < 2) {
                            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1801e02d0(uVar6,0);
                          }
                          plVar7[5] = lVar5;
                          il2cpp_internal(plVar7 + 5,lVar5);
                          if ((GameController._instance != null) &&
                             (lVar5 = GameController._instance.worldData,
                             lVar5 != null)) {
                            local_res18[0] = lVar5.totalFightCount;
                            lVar5 = il2cpp_value_box(DAT_181e60808,local_res18);
                            if ((lVar5 != null) &&
                               (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64)),
                               lVar8 == null)) {
                              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1801e02d0(uVar6,0);
                            }
                            if (*(uint32 *)(plVar7 + 3) < 3) {
                              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1801e02d0(uVar6,0);
                            }
                            plVar7[6] = lVar5;
                            il2cpp_internal(plVar7 + 6,lVar5);
                            if ((GameController._instance != null) &&
                               (lVar5 = GameController._instance.worldData,
                               lVar5 != null)) {
                              local_res20[0] = lVar5.totalWinFightCount;
                              lVar5 = il2cpp_value_box(DAT_181e60808,local_res20);
                              if ((lVar5 != null) &&
                                 (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64)),
                                 lVar8 == null)) {
                                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1801e02d0(uVar6,0);
                              }
                              if (*(uint32 *)(plVar7 + 3) < 4) {
                                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1801e02d0(uVar6,0);
                              }
                              plVar7[7] = lVar5;
                              il2cpp_internal(plVar7 + 7,lVar5);
                              uVar9 = "达成结局: {0}\n游戏模式: {11}\n游戏难度: {1}\n最终金钱: {8}\n最终声望: {9}\n战斗场数: {2} (胜场{3} 胜率{4}%)\n击败人数: {5}\n结识人数: {6}\n总计恶名: {7} ({10})";
                              if ((GameController._instance != null) &&
                                 (lVar5 = GameController._instance.worldData,
                                 lVar5 != null)) {
                                local_a8 = 0;
                                if (lVar5.totalFightCount == null) {
        LAB_1806bb9cf:
                                  lVar5 = il2cpp_value_box(DAT_181e60808,&local_a8);
                                  if ((lVar5 != null) &&
                                     (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64)),
                                     lVar8 == null)) {
                                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1801e02d0(uVar6,0);
                                  }
                                  if (*(uint32 *)(plVar7 + 3) < 5) {
                                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1801e02d0(uVar6,0);
                                  }
                                  plVar7[8] = lVar5;
                                  il2cpp_internal(plVar7 + 8,lVar5);
                                  if ((GameController._instance != null) &&
                                     (lVar5 = GameController._instance.worldData,
                                     lVar5 != null)) {
                                    local_a4 = lVar5.totalEnemyKilled;
                                    lVar5 = il2cpp_value_box(DAT_181e60808,&local_a4);
                                    if ((lVar5 != null) &&
                                       (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64))
                                       , lVar8 == null)) {
                                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1801e02d0(uVar6,0);
                                    }
                                    if (*(uint32 *)(plVar7 + 3) < 6) {
                                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1801e02d0(uVar6,0);
                                    }
                                    plVar7[9] = lVar5;
                                    il2cpp_internal(plVar7 + 9,lVar5);
                                    if ((GameController._instance != null) &&
                                       (lVar5 = *(int64 *)
                                                 (GameController._instance + 32),
                                       lVar5 != null)) {
                                      local_a0 = lVar5.totalHeroMeet;
                                      lVar5 = il2cpp_value_box(DAT_181e60808,&local_a0);
                                      if ((lVar5 != null) &&
                                         (lVar8 = il2cpp_internal(lVar5,*(uint64 *)
                                                                             (*plVar7 + 64)), lVar8 == null
                                         )) {
                                        uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                        FUN_1801e02d0(uVar6,0);
                                      }
                                      if (*(uint32 *)(plVar7 + 3) < 7) {
                                        uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                        FUN_1801e02d0(uVar6,0);
                                      }
                                      plVar7[10] = lVar5;
                                      il2cpp_internal(plVar7 + 10,lVar5);
                                      if ((GameController._instance != null) &&
                                         (lVar5 = *(int64 *)
                                                   (GameController._instance + 32),
                                         lVar5 != null)) {
                                        lVar5 = Single.ToString(lVar5 + 0x198,"f0",0);
                                        if ((lVar5 != null) &&
                                           (lVar8 = il2cpp_internal(lVar5,*(uint64 *)
                                                                               (*plVar7 + 64)),
                                           lVar8 == null)) {
                                          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                          FUN_1801e02d0(uVar6,0);
                                        }
                                        if (*(uint32 *)(plVar7 + 3) < 8) {
                                          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                          FUN_1801e02d0(uVar6,0);
                                        }
                                        plVar7[11] = lVar5;
                                        il2cpp_internal(plVar7 + 11,lVar5);
                                        if ((((GameController._instance != null) &&
                                             (lVar5 = *(int64 *)
                                                       (GameController._instance + 32),
                                             lVar5 != null)) &&
                                            (lVar5 = WorldData.Player(lVar5,0)) != null) &&
                                           (lVar5.speBookStorageSpeAdd != null)) {
                                          local_9c = *(uint32 *)(lVar5.speBookStorageSpeAdd + 24);
                                          lVar5 = il2cpp_value_box(DAT_181e60808,&local_9c);
                                          if ((lVar5 != null) &&
                                             (lVar8 = il2cpp_internal(lVar5,*(uint64 *)
                                                                                 (*plVar7 + 64)),
                                             lVar8 == null)) {
                                            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                            FUN_1801e02d0(uVar6,0);
                                          }
                                          if (*(uint32 *)(plVar7 + 3) < 9) {
                                            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                            FUN_1801e02d0(uVar6,0);
                                          }
                                          plVar7[12] = lVar5;
                                          il2cpp_internal(plVar7 + 12,lVar5);
                                          if (((GameController._instance != null) &&
                                              (lVar5 = *(int64 *)
                                                        (GameController._instance + 32),
                                              lVar5 != null)) &&
                                             (lVar5 = WorldData.Player(lVar5,0)) != null) {
                                            lVar5 = Single.ToString(lVar5 + 0x1c4,"f0",0);
                                            if ((lVar5 != null) &&
                                               (lVar8 = il2cpp_internal(lVar5,*(uint64 *)
                                                                                   (*plVar7 + 64)),
                                               lVar8 == null)) {
                                              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                              FUN_1801e02d0(uVar6,0);
                                            }
                                            if (*(uint32 *)(plVar7 + 3) < 10) {
                                              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                              FUN_1801e02d0(uVar6,0);
                                            }
                                            plVar7[13] = lVar5;
                                            il2cpp_internal(plVar7 + 13,lVar5);
                                            if ((GameController._instance != null) &&
                                               (lVar5 = *(int64 *)
                                                         (GameController._instance + 32),
                                               lVar5 != null)) {
                                              uVar2 = Mathf.CeilToInt(lVar5.totalBadFame / 200.0,0
                                                                      );
                                              uVar3 = Mathf.Clamp(uVar2,0,*(int *)(lVar4 + 24) + -1,0);
                                              if (*(uint32 *)(lVar4 + 24) <= uVar3) {
                                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                              }
                                              lVar4 = *(int64 *)
                                                       (*(int64 *)(lVar4 + 16) + 32 +
                                                       (int64)(int)uVar3 * 8);
                                              if ((lVar4 != null) &&
                                                 (lVar5 = il2cpp_internal(lVar4,*(uint64 *)
                                                                                     (*plVar7 + 64)),
                                                 lVar5 == null)) {
                                                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                FUN_1801e02d0(uVar6,0);
                                              }
                                              if (*(uint32 *)(plVar7 + 3) < 11) {
                                                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                FUN_1801e02d0(uVar6,0);
                                              }
                                              plVar7[14] = lVar4;
                                              il2cpp_internal(plVar7 + 14,lVar4);
                                              lVar4 = *(int64 *)
                                                       (*(int64 *)(DAT_181e538e8 + 184) + 184);
                                              if (((GameController._instance != null) &&
                                                  (lVar5 = *(int64 *)
                                                            (GameController._instance + 32)
                                                  , lVar5 != null)) && (lVar4 != null)) {
                                                uVar3 = lVar5.gameMode;
                                                if (*(uint32 *)(lVar4 + 24) <= uVar3) {
                                                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                                }
                                                lVar4 = *(int64 *)
                                                         (*(int64 *)(lVar4 + 16) + 32 +
                                                         (int64)(int)uVar3 * 8);
                                                if ((lVar4 != null) &&
                                                   (lVar5 = il2cpp_internal(lVar4,*(uint64 *)
                                                                                       (*plVar7 + 64)),
                                                   lVar5 == null)) {
                                                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                  FUN_1801e02d0(uVar6,0);
                                                }
                                                if (*(uint32 *)(plVar7 + 3) < 12) {
                                                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                  FUN_1801e02d0(uVar6,0);
                                                }
                                                plVar7[15] = lVar4;
                                                il2cpp_internal(plVar7 + 15,lVar4);
                                                uVar9 = String.Format(uVar9,plVar7,0);
                                                LTLocalization.SetText(uVar6,uVar9,0);
                                                if (((this.gameResultCreditPanel != null) &&
                                                    (lVar4 = GameObject.get_transform
                                                                       (this.gameResultCreditPanel,0),
                                                    lVar4 != null)) &&
                                                   (lVar4 = Transform.Find(lVar4,"Back",0),
                                                   lVar4 != null)) {
                                                  plVar7 = (int64 *)
                                                           Component.GetComponent(lVar4,DAT_181e777b8);
                                                  puVar10 = (uint64 *)FUN_180af4e90(&local_c8,0);
                                                  if (plVar7 != (int64 *)0) {
                                                    local_c8 = *puVar10;
                                                    uStack_c0 = puVar10[1];
                                                    (**(code **)(*plVar7 + 0x2a8))
                                                              (plVar7,&local_c8,
                                                               *(uint64 *)(*plVar7 + 0x2b0));
                                                    if (((this.gameResultCreditPanel != null) &&
                                                        (lVar4 = GameObject.get_transform
                                                                           (this.gameResultCreditPanel,
                                                                            0), lVar4 != null)) &&
                                                       (lVar4 = Transform.Find(lVar4,"Back",0),
                                                       lVar4 != null)) {
                                                      uVar6 = Component.GetComponent(lVar4,DAT_181e777b8)
                                                      ;
                                                      uVar6 = DOTweenModuleUI.DOFade(uVar6);
                                                      uVar6 = TweenSettingsExtensions.SetUpdate
                                                                        (uVar6,1,DAT_181ea5848);
                                                      uVar9 = new OnTooltipCB(this,DAT_181e58c60,0);
                                                      TweenSettingsExtensions.OnComplete
                                                                (uVar6,uVar9,DAT_181ea3ba0);
                                                      if (((this.gameResultCreditPanel != null) &&
                                                          (lVar4 = GameObject.get_transform
                                                                             (*(int64 *)
                                                                               (this + 40),0),
                                                          lVar4 != null)) &&
                                                         (lVar4 = Transform.Find(lVar4,"CustomDifficulty",0),
                                                         lVar4 != null)) {
                                                        plVar7 = (int64 *)
                                                                 Component.GetComponent
                                                                           (lVar4,DAT_181e79538);
                                                        if (((GameController._instance != null)
                                                            && (lVar4 = *(int64 *)
                                                                         (**(int64 **)
                                                                            (DAT_181e52870 + 184) + 32)
                                                               , lVar4 != null)) &&
                                                           (lVar4 = *(int64 *)(lVar4 + 0x260),
                                                           lVar4 != null)) {
                                                          uVar6 = 
                                                        CustomDifficultyData.GetCustomDifficultyFullDescribe
                                                                  (lVar4,0);
                                                        uVar6 = String.Concat("自定义难度：\n",uVar6,0);
                                                        if (plVar7 != (int64 *)0) {
                                                          (**(code **)(*plVar7 + 0x5e8))
                                                                    (plVar7,uVar6,
                                                                     *(uint64 *)(*plVar7 + 0x5f0));
                                                          if (((this.gameResultCreditPanel != null) &&
                                                              (lVar4 = GameObject.get_transform
                                                                                 (*(int64 *)
                                                                                   (this + 40),0),
                                                              lVar4 != null)) &&
                                                             (lVar4 = Transform.Find(lVar4,"CustomDifficulty",
                                                                                      0), lVar4 != null)) {
                                                            local_b8 = 0x3f800000;
                                                            local_b0 = 0x3f800000;
                                                            Transform.set_localScale(lVar4,&local_b8,0);
                                                            if ((this.gameResultCreditPanel != null) &&
                                                               (lVar4 = GameObject.get_transform
                                                                                  (*(int64 *)
                                                                                    (this + 40),0),
                                                               lVar4 != null)) {
                                                              uVar6 = Transform.Find(lVar4,"CustomDifficulty",
                                                                                      0);
                                                              uVar6 = ShortcutExtensions.DOScaleY(uVar6);
                                                              uVar6 = TweenSettingsExtensions.SetUpdate
                                                                                (uVar6,1,DAT_181ea59e0);
                                                              TweenSettingsExtensions.SetDelay(uVar6);
                                                              if ((this.gameResultCreditPanel != null) &&
                                                                 ((lVar4 = GameObject.get_transform
                                                                                     (*(int64 *)
                                                                                       (this + 40),0)
                                                                  , lVar4 != null &&
                                                                  (lVar4 = Transform.Find(lVar4,
                                                        "TitleBack",0), lVar4 != null)))) {
                                                          plVar7 = (int64 *)
                                                                   Component.GetComponent
                                                                             (lVar4,DAT_181e777b8);
                                                          uVar6 = 0;
                                                          uVar2 = 0;
                                                          local_88 = 0;
                                                          uStack_80 = 0;
                                                          FUN_1807282e0(&local_88);
                                                          if (plVar7 != (int64 *)0) {
                                                            lVar4 = *plVar7;
                                                            local_c8 = local_88;
                                                            uStack_c0 = uStack_80;
                                                            (**(code **)(lVar4 + 0x2a8))
                                                                      (plVar7,&local_c8,
                                                                       *(uint64 *)(lVar4 + 0x2b0),
                                                                       lVar4,uVar2,uVar6);
                                                            if (((this.gameResultCreditPanel != null) &&
                                                                (lVar4 = GameObject.get_transform
                                                                                   (*(int64 *)
                                                                                     (this + 40),0),
                                                                lVar4 != null)) &&
                                                               (lVar4 = Transform.Find(lVar4,
                                                        "TitleBack",0), lVar4 != null)) {
                                                          uVar6 = Component.GetComponent
                                                                            (lVar4,DAT_181e777b8);
                                                          uVar6 = DOTweenModuleUI.DOFade(uVar6);
                                                          uVar6 = TweenSettingsExtensions.SetUpdate
                                                                            (uVar6,1,DAT_181ea5848);
                                                          TweenSettingsExtensions.SetDelay(uVar6);
                                                          if (((this.gameResultCreditPanel != null) &&
                                                              (lVar4 = GameObject.get_transform
                                                                                 (*(int64 *)
                                                                                   (this + 40),0),
                                                              lVar4 != null)) &&
                                                             (lVar4 = Transform.Find(lVar4,"Title",
                                                                                      0), lVar4 != null)) {
                                                            plVar7 = (int64 *)
                                                                     Component.GetComponent
                                                                               (lVar4,DAT_181e777b8);
                                                            uVar6 = 0;
                                                            uVar2 = 0;
                                                            local_78 = 0;
                                                            uStack_70 = 0;
                                                            FUN_1807282e0(&local_78);
                                                            if (plVar7 != (int64 *)0) {
                                                              lVar4 = *plVar7;
                                                              local_c8 = local_78;
                                                              uStack_c0 = uStack_70;
                                                              (**(code **)(lVar4 + 0x2a8))
                                                                        (plVar7,&local_c8,
                                                                         *(uint64 *)(lVar4 + 0x2b0),
                                                                         lVar4,uVar2,uVar6);
                                                              if (((this.gameResultCreditPanel != null) &&
                                                                  (lVar4 = GameObject.get_transform
                                                                                     (*(int64 *)
                                                                                       (this + 40),0)
                                                                  , lVar4 != null)) &&
                                                                 (lVar4 = Transform.Find(lVar4,
                                                        "Title",0), lVar4 != null)) {
                                                          uVar6 = Component.GetComponent
                                                                            (lVar4,DAT_181e777b8);
                                                          uVar6 = DOTweenModuleUI.DOFade(uVar6);
                                                          uVar6 = TweenSettingsExtensions.SetUpdate
                                                                            (uVar6,1,DAT_181ea5848);
                                                          TweenSettingsExtensions.SetDelay(uVar6);
                                                          if (((this.gameResultCreditPanel != null) &&
                                                              (lVar4 = GameObject.get_transform
                                                                                 (*(int64 *)
                                                                                   (this + 40),0),
                                                              lVar4 != null)) &&
                                                             (lVar4 = Transform.Find(lVar4,"Count",
                                                                                      0), lVar4 != null)) {
                                                            plVar7 = (int64 *)
                                                                     Component.GetComponent
                                                                               (lVar4,DAT_181e79538);
                                                            uVar6 = 0;
                                                            local_68 = 0;
                                                            uStack_60 = 0;
                                                            uVar2 = 0;
                                                            FUN_1807282e0(&local_68);
                                                            if (plVar7 != (int64 *)0) {
                                                              lVar4 = *plVar7;
                                                              local_c8 = local_68;
                                                              uStack_c0 = uStack_60;
                                                              (**(code **)(lVar4 + 0x2a8))
                                                                        (plVar7,&local_c8,
                                                                         *(uint64 *)(lVar4 + 0x2b0),
                                                                         lVar4,uVar2,uVar6);
                                                              if (((this.gameResultCreditPanel != null) &&
                                                                  (lVar4 = GameObject.get_transform
                                                                                     (*(int64 *)
                                                                                       (this + 40),0)
                                                                  , lVar4 != null)) &&
                                                                 (lVar4 = Transform.Find(lVar4,
                                                        "Count",0), lVar4 != null)) {
                                                          uVar6 = Component.GetComponent
                                                                            (lVar4,DAT_181e79538);
                                                          uVar6 = DOTweenModuleUI.DOFade(uVar6);
                                                          uVar6 = TweenSettingsExtensions.SetUpdate
                                                                            (uVar6,1,DAT_181ea5848);
                                                          TweenSettingsExtensions.SetDelay(uVar6);
                                                          if (((this.gameResultCreditPanel != null) &&
                                                              (lVar4 = GameObject.get_transform
                                                                                 (*(int64 *)
                                                                                   (this + 40),0),
                                                              lVar4 != null)) &&
                                                             (lVar4 = Transform.Find(lVar4,"Credit",
                                                                                      0), lVar4 != null)) {
                                                            plVar7 = (int64 *)
                                                                     Component.GetComponent
                                                                               (lVar4,DAT_181e79538);
                                                            uVar6 = 0;
                                                            uVar2 = 0;
                                                            local_98 = 0;
                                                            uStack_90 = 0;
                                                            FUN_1807282e0(&local_98);
                                                            if (plVar7 != (int64 *)0) {
                                                              lVar4 = *plVar7;
                                                              local_c8 = local_98;
                                                              uStack_c0 = uStack_90;
                                                              (**(code **)(lVar4 + 0x2a8))
                                                                        (plVar7,&local_c8,
                                                                         *(uint64 *)(lVar4 + 0x2b0),
                                                                         lVar4,uVar2,uVar6);
                                                              if (((this.gameResultCreditPanel != null) &&
                                                                  (lVar4 = GameObject.get_transform
                                                                                     (*(int64 *)
                                                                                       (this + 40),0)
                                                                  , lVar4 != null)) &&
                                                                 (lVar4 = Transform.Find(lVar4,
                                                        "Credit",0), lVar4 != null)) {
                                                          uVar6 = Component.GetComponent
                                                                            (lVar4,DAT_181e79538);
                                                          uVar6 = DOTweenModuleUI.DOFade(uVar6);
                                                          uVar6 = TweenSettingsExtensions.SetUpdate
                                                                            (uVar6,1,DAT_181ea5848);
                                                          TweenSettingsExtensions.SetDelay(uVar6);
                                                          if ((this.gameResultCreditPanel != null) &&
                                                             (lVar4 = GameObject.get_transform
                                                                                (*(int64 *)
                                                                                  (this + 40),0),
                                                             lVar4 != null)) {
                                                            lVar4 = Transform.Find(lVar4,"Continue",0)
                                                            ;
                                                            puVar10 = (uint64 *)
                                                                      Vector3.get_zero(&local_c8,0);
                                                            if (lVar4 != null) {
                                                              local_b0 = *(uint32 *)(puVar10 + 1);
                                                              local_b8 = *puVar10;
                                                              Transform.set_localScale(lVar4,&local_b8,0)
                                                              ;
                                                              if ((this.gameResultCreditPanel != null) &&
                                                                 (lVar4 = GameObject.get_transform
                                                                                    (*(int64 *)
                                                                                      (this + 40),0),
                                                                 lVar4 != null)) {
                                                                uVar6 = Transform.Find(lVar4,
                                                        "Continue",0);
                                                        uVar6 = ShortcutExtensions.DOScale(uVar6);
                                                        uVar6 = TweenSettingsExtensions.SetUpdate
                                                                          (uVar6,1,DAT_181ea59e0);
                                                        TweenSettingsExtensions.SetDelay(uVar6);
                                                        if ((this.gameResultCreditPanel != null) &&
                                                           (lVar4 = GameObject.get_transform
                                                                              (*(int64 *)
                                                                                (this + 40),0),
                                                           lVar4 != null)) {
                                                          lVar4 = Transform.Find(lVar4,"Quit",0);
                                                          puVar10 = (uint64 *)
                                                                    Vector3.get_zero(&local_c8,0);
                                                          if (lVar4 != null) {
                                                            local_b0 = *(uint32 *)(puVar10 + 1);
                                                            local_b8 = *puVar10;
                                                            Transform.set_localScale(lVar4,&local_b8,0);
                                                            if ((this.gameResultCreditPanel != null) &&
                                                               (lVar4 = GameObject.get_transform
                                                                                  (*(int64 *)
                                                                                    (this + 40),0),
                                                               lVar4 != null)) {
                                                              uVar6 = Transform.Find(lVar4,"Quit",
                                                                                      0);
                                                              uVar6 = ShortcutExtensions.DOScale(uVar6);
                                                              uVar6 = TweenSettingsExtensions.SetUpdate
                                                                                (uVar6,1,DAT_181ea59e0);
                                                              TweenSettingsExtensions.SetDelay(uVar6);
                                                              if ((this.gameResultCreditPanel != null) &&
                                                                 ((lVar4 = GameObject.get_transform
                                                                                     (*(int64 *)
                                                                                       (this + 40),0)
                                                                  , lVar4 != null &&
                                                                  (lVar4 = Transform.Find(lVar4,
                                                        "Unlock",0), lVar4 != null)))) {
                                                          uVar6 = Component.GetComponent
                                                                            (lVar4,DAT_181e79538);
                                                          if (((GameController._instance != null
                                                               ) && (lVar4 = *(int64 *)
                                                                              (**(int64 **)
                                                                                 (DAT_181e52870 + 184) +
                                                                              32), lVar4 != null)) &&
                                                             (lVar4 = WorldData.GetHero(lVar4,
                                                        "金龙生",0), lVar4 != null)) {
                                                          uVar9 = "郭淮";
                                                          if (*(char *)(lVar4 + 97) == false) {
                                                            uVar9 = "金龙生";
                                                          }
                                                          uVar9 = String.Format("{0}处已解锁藏宝阁功能",uVar9,0);
                                                          LTLocalization.SetText(uVar6,uVar9,0);
                                                          if (((this.gameResultCreditPanel != null) &&
                                                              (lVar4 = GameObject.get_transform
                                                                                 (*(int64 *)
                                                                                   (this + 40),0),
                                                              lVar4 != null)) &&
                                                             (lVar4 = Transform.Find(lVar4,"Unlock",
                                                                                      0), lVar4 != null)) {
                                                            plVar7 = (int64 *)
                                                                     Component.GetComponent
                                                                               (lVar4,DAT_181e79538);
                                                            uVar6 = 0;
                                                            uVar2 = 0;
                                                            local_c8 = 0;
                                                            uStack_c0 = 0;
                                                            FUN_1807282e0(&local_c8);
                                                            if (plVar7 != (int64 *)0) {
                                                              lVar4 = *plVar7;
                                                              local_98 = local_c8;
                                                              uStack_90 = uStack_c0;
                                                              (**(code **)(lVar4 + 0x2a8))
                                                                        (plVar7,&local_98,
                                                                         *(uint64 *)(lVar4 + 0x2b0),
                                                                         lVar4,uVar2,uVar6);
                                                              if (((this.gameResultCreditPanel != null) &&
                                                                  (lVar4 = GameObject.get_transform
                                                                                     (*(int64 *)
                                                                                       (this + 40),0)
                                                                  , lVar4 != null)) &&
                                                                 (lVar4 = Transform.Find(lVar4,
                                                        "Unlock",0), lVar4 != null)) {
                                                          uVar6 = Component.GetComponent
                                                                            (lVar4,DAT_181e79538);
                                                          uVar6 = DOTweenModuleUI.DOFade(uVar6);
                                                          uVar6 = TweenSettingsExtensions.SetUpdate
                                                                            (uVar6,1,DAT_181ea5848);
                                                          TweenSettingsExtensions.SetDelay(uVar6);
                                                          return;
                                                        }
                                                        }
                                                        }
                          // WARNING: Subroutine does not return
                                                        FUN_1801e0300();
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
                                  FUN_1801e0300();
                                }
                                if ((GameController._instance != null) &&
                                   (lVar5 = GameController._instance.worldData,
                                   lVar5 != null)) {
                                  iVar1 = lVar5.totalWinFightCount;
                                  if ((GameController._instance != null) &&
                                     (lVar5 = GameController._instance.worldData,
                                     lVar5 != null)) {
                                    local_a8 = Mathf.RoundToInt(((float)iVar1 * 100.0) /
                                                                 (float)lVar5.totalFightCount,0);
                                    goto LAB_1806bb9cf;
                                  }
                                }
                          // WARNING: Subroutine does not return
                                FUN_1801e0300();
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

    // Token : 0x6001725
    // RVA   : 0x6BAE70   Offset: 0x6B9C70   Length: 0x1C6
    public void HideText()
    {
        long lVar1;
        ulong local_58;
        ulong uStack_50;
        ulong local_48;
        ulong uStack_40;
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        if (this.gameEndPanel != null) {
          lVar1 = GameObject.get_transform(this.gameEndPanel,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"NextButton",0);
            if (lVar1 != null) {
              plVar2 = (int64 *)Component.GetComponent(lVar1,DAT_181e777b8);
              local_58 = 0;
              uStack_50 = 0;
              FUN_1807282e0(&local_58,0x3f800000,0x3f800000,0x3f800000,0,0);
              if (plVar2 != (int64 *)0) {
                local_38 = (uint32)local_58;
                uStack_34 = local_58._4_4_;
                uStack_30 = (uint32)uStack_50;
                uStack_2c = uStack_50._4_4_;
                (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_38,*(uint64 *)(*plVar2 + 0x2b0));
                if (this.gameEndPanel != null) {
                  lVar1 = GameObject.get_transform(this.gameEndPanel,0);
                  if (lVar1 != null) {
                    lVar1 = Transform.Find(lVar1,"Text",0);
                    if (lVar1 != null) {
                      plVar2 = (int64 *)Component.GetComponent(lVar1,DAT_181e79538);
                      local_48 = 0;
                      uStack_40 = 0;
                      FUN_1807282e0(&local_48,0x3f800000,0x3f800000,0x3f800000,0,0);
                      if (plVar2 != (int64 *)0) {
                        local_38 = (uint32)local_48;
                        uStack_34 = local_48._4_4_;
                        uStack_30 = (uint32)uStack_40;
                        uStack_2c = uStack_40._4_4_;
                        (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_38,*(uint64 *)(*plVar2 + 0x2b0));
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

    // Token : 0x6001726
    // RVA   : 0x6BCD20   Offset: 0x6BBB20   Length: 0x223
    public void ShowText(string text)
    {
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/Paper",0);
        plVar5 = (int64 *)0;
        if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181e8f4a0)) {
          plVar5 = plVar1;
        }
        NGUITools.PlaySound(plVar5,0);
        GameResultController.HideText(this,0);
        this.textShowing = 1;
        if (this.gameEndPanel != null) {
          lVar2 = GameObject.get_transform(this.gameEndPanel,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"Text",0);
            if (lVar2 != null) {
              uVar3 = Component.GetComponent(lVar2,DAT_181e79538);
              LTLocalization.SetText(uVar3,text,0);
              if (this.gameEndPanel != null) {
                lVar2 = GameObject.get_transform(this.gameEndPanel,0);
                if (lVar2 != null) {
                  lVar2 = Transform.Find(lVar2,"Text",0);
                  if (lVar2 != null) {
                    uVar3 = Component.GetComponent(lVar2,DAT_181e79538);
                    uVar3 = DOTweenModuleUI.DOFade(uVar3,0x3f800000,0x3f800000,0);
                    uVar3 = TweenSettingsExtensions.SetUpdate(uVar3,1,DAT_181ea5848);
                    uVar4 = new OnTooltipCB(this,DAT_181e58ce8,0);
                    TweenSettingsExtensions.OnComplete(uVar3,uVar4,DAT_181ea3ba0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001727
    // RVA   : 0x6BAA00   Offset: 0x6B9800   Length: 0x235
    public void BackgroundClicked()
    {
        uint uVar1;
        int iVar2;
        long lVar3;
        bool cVar4;
        ulong uVar5;
        if (this.textShowing) {
          return;
        }
        lVar3 = this.gameEndPlotDatas;
        if (lVar3 != null) {
          uVar1 = this.nowResultID;
          if (lVar3.Count <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar3 = lVar3._items[uVar1];
          if ((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 40)) != null) {
            uVar1 = this.nowTextID;
            if (lVar3.Count <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar3 = lVar3._items[uVar1];
            if (lVar3 != null) {
              cVar4 = FUN_180ad1200(lVar3.Count,0);
              lVar3 = this.gameEndPlotDatas;
              uVar1 = this.nowResultID;
              if (!cVar4) {
                if (lVar3 != null) {
                  if (lVar3.Count <= uVar1) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar3 = lVar3._items[uVar1];
                  if ((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 40)) != null) {
                    uVar1 = this.nowTextID;
                    if (lVar3.Count <= uVar1) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar3 = lVar3._items[uVar1];
                    if (lVar3 != null) {
                      Component.SendMessage(this,lVar3.Count,0);
                      return;
                    }
                  }
                }
              }
              else {
                this.nowTextID = this.nowTextID + 1;
                iVar2 = this.nowTextID;
                if (lVar3 != null) {
                  if (lVar3.Count <= uVar1) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar3 = lVar3._items[uVar1];
                  if ((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 40)) != null) {
                    if (lVar3.Count <= iVar2) {
                      GameResultController.ShowResultCredit(this,0);
                      return;
                    }
                    lVar3 = this.gameEndPlotDatas;
                    if (lVar3 != null) {
                      uVar1 = this.nowResultID;
                      if (lVar3.Count <= uVar1) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar3 = lVar3._items[uVar1]
                      ;
                      if ((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 40)) != null) {
                        uVar1 = this.nowTextID;
                        if (lVar3.Count <= uVar1) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar3 = *(int64 *)
                                 (lVar3._items + 32 + (int64)(int)uVar1 * 8);
                        if (lVar3 != null) {
                          uVar5 = lVar3._items;
                          uVar5 = GlobalData.ReplaceSpeString(uVar5,0,0);
                          GameResultController.ShowText(this,uVar5,0);
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

    // Token : 0x6001728
    // RVA   : 0x6BE000   Offset: 0x6BCE00   Length: 0x98B
    public void StartSpeFinalPlot()
    {
        long lVar1;
        long lVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        uint uVar7;
        ulong uVar8;
        ulong in_stack_ffffffffffffffb0;
        lVar2 = new PlotData(0);
        uVar7 = 0;
        if ((GameController._instance != null) &&
           (lVar3 = GameController._instance.worldData) != null) {
          if (lVar3.totalBadFame == null.0) {
            uVar7 = 3;
          }
          else {
            if ((GameController._instance == null) ||
               (lVar3 = GameController._instance.worldData) == null)
            throw; // [null/range check failed]
            if (lVar3.totalBadFame <= 200.0) {
              uVar7 = 2;
            }
            else {
              lVar3 = FUN_1802106e0(0);
              if ((lVar3 == null) || (lVar3.villageAreaID == null)) throw; // [null/range check failed]
              if (*(float *)(lVar3.villageAreaID + 0x198) <= 400.0) {
                uVar7 = 1;
              }
            }
          }
          lVar3 = il2cpp_internal(DAT_181e77728);
          FUN_1810f3480(lVar3,DAT_181e861f0);
          if (lVar3 != null) {
            FUN_18175de30(lVar3,"五十年，\n后人认为这段时期，已不输贞观之治和开元盛世。",DAT_181e86370);
            FUN_18175de30(lVar3,"一百年，\n后人认为这段时期，已远在贞观之治和开元盛世之上。",DAT_181e86370);
            FUN_18175de30(lVar3,"三百年，\n后人认为这段时期，便是秦皇汉武之统治也难以望其项背。",DAT_181e86370);
            FUN_18175de30(lVar3,"五百年，\n后人认为其文治武功与得国之正，堪称古今第一帝王。",DAT_181e86370);
            lVar4 = il2cpp_internal(DAT_181e77728);
            FUN_1810f3480(lVar4,DAT_181e861f0);
            if (lVar4 != null) {
              FUN_18175de30(lVar4,"·盛世五十年",DAT_181e86370);
              FUN_18175de30(lVar4,"·盛世一百年",DAT_181e86370);
              FUN_18175de30(lVar4,"·盛世三百年",DAT_181e86370);
              FUN_18175de30(lVar4,"·盛世五百年",DAT_181e86370);
              if (lVar4.cityAreaID <= uVar7) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar8 = (uint64)uVar7;
              this.extraInfo =
                   *(uint64 *)(lVar4.chapter + 32 + uVar8 * 8);
              il2cpp_internal();
              if (((GameController._instance != null) &&
                  (lVar4 = GameController._instance.worldData) != null) &&
                 (lVar2 != null)) {
                lVar1 = *(int64 *)(lVar2 + 64);
                if (lVar4.gameMode == 1) {
                  if (lVar3.cityAreaID <= uVar7) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  uVar6 = String.Format("这一盛世在#$PlayerName#故去之后仍持续了{0}\n而此后历朝历代，百姓万民，也无不称颂怀念#$PlayerName#所开创的这一黄金时代。",
                                         *(uint64 *)(lVar3.chapter + 32 + uVar8 * 8),0
                                        );
                  uVar5 = new SinglePlotData(uVar6,0,0);
                }
                else {
                  if (lVar3.cityAreaID <= uVar7) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  uVar5 = String.Format("这一盛世在#$PlayerName#故去之后仍持续了{0}\n而此后历朝历代，百姓万民，也无不称颂怀念#$PlayerName#所开创的这一黄金时代。",
                                         *(uint64 *)(lVar3.chapter + 32 + uVar8 * 8),0
                                        );
                  uVar6 = il2cpp_internal(DAT_181e82930);
                  SinglePlotData.ctor
                            (uVar6,uVar5,0,1,0,1,0,3,"ScreenBlack",
                             in_stack_ffffffffffffffb0 & 0xffffffffffffff00,0,0,0,0,0);
                  if (lVar1 == null) throw; // [null/range check failed]
                  FUN_18175de30(lVar1,uVar6,DAT_181e839b0);
                  lVar3 = *(int64 *)(lVar2 + 64);
                  uVar5 = FUN_1800020e0(DAT_181e6dc98);
                  uVar5 = String.Format("多年以后一个炎热的下午，你正坐在大殿中思考国策。\n突然一阵强烈的眩晕袭来，使你天旋地转，如坠云里雾里。",uVar5,0);
                  uVar6 = new SinglePlotData(uVar5,0,1,0,1,0,3,0,0);
                  if (lVar3 == null) throw; // [null/range check failed]
                  FUN_18175de30(lVar3,uVar6,DAT_181e839b0);
                  lVar3 = *(int64 *)(lVar2 + 64);
                  uVar5 = FUN_1800020e0(DAT_181e6dc98);
                  uVar5 = String.Format("在宫女的惊叫和师兄妹们的呼唤声中，\n你又仿佛回到了许多年前的那个清晨。\n仙霞山上的虫鸣鸟语，开始在宫殿之中回响。",uVar5,0);
                  uVar6 = new SinglePlotData(uVar5,0,1,0,1,0,3,0,0);
                  if (lVar3 == null) throw; // [null/range check failed]
                  FUN_18175de30(lVar3,uVar6,DAT_181e839b0);
                  lVar3 = *(int64 *)(lVar2 + 64);
                  uVar5 = FUN_1800020e0(DAT_181e6dc98);
                  uVar5 = String.Format("#PlayerName#！#PlayerName#！都日上三竿了，怎么还在睡大觉呢！\n嘴里还一直念叨着什么“看招”，“承让”，\n怕不是又在梦里行侠仗义了。",uVar5,0);
                  uVar6 = new SinglePlotData(uVar5,0,5,"杨思迟",3,"0",0,0,0);
                  if (lVar3 == null) throw; // [null/range check failed]
                  FUN_18175de30(lVar3,uVar6,DAT_181e839b0);
                  lVar1 = *(int64 *)(lVar2 + 64);
                  uVar5 = FUN_1800020e0(DAT_181e6dc98);
                  uVar6 = String.Format("别吵吵，我正在泰岳大典施展拳脚，大杀四方，\n眼看就要将各大门派打个落花流水......没想到被你搅了好事！",uVar5,0);
                  uVar5 = il2cpp_internal(DAT_181e82930);
                  in_stack_ffffffffffffffb0 = 0;
                  SinglePlotData.ctor(uVar5,uVar6,0,5,"杨思迟",3,"0",1,0,0);
                }
                if (lVar1 != null) {
                  FUN_18175de30(lVar1,uVar5,DAT_181e839b0);
                  lVar3 = *(int64 *)(lVar2 + 64);
                  uVar5 = FUN_1800020e0(DAT_181e6dc98);
                  uVar5 = String.Format("后人将此段历史整理成册，抄写影印，使之流传千古直至现在。\n这一故事，便被称作————————",uVar5,0);
                  uVar6 = il2cpp_internal(DAT_181e82930);
                  SinglePlotData.ctor
                            (uVar6,uVar5,0,1,0,1,0,3,"ShowResultCredit",
                             in_stack_ffffffffffffffb0 & 0xffffffffffffff00,0,0,0,0,0);
                  if (lVar3 != null) {
                    FUN_18175de30(lVar3,uVar6,DAT_181e839b0);
                    lVar3 = *(int64 *)(*(int64 *)(DAT_181e71f68 + 184) + 24);
                    if (lVar3 != null) {
                      PlotController.ChangePlot(lVar3,lVar2,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001729
    // RVA   : 0x6BCF50   Offset: 0x6BBD50   Length: 0x10A3
    public void StartGameResult(int _resultID)
    {
        var pStatics_af70 = *(int64*)(DAT_181e6af70 + 184);
        uint uVar2;
        bool cVar3;
        int iVar4;
        uint uVar5;
        ulong uVar6;
        long lVar7;
        ulong uVar8;
        long lVar9;
        ulong uVar13;
        uint[] local_res20 = new uint[2];
        ulong local_48;
        ulong uStack_40;
        lVar7 = *(int64 *)(*(int64 *)(DAT_181e71f68 + 184) + 24);
        if (lVar7 == null) throw; // [null/range check failed]
        PlotController.HideInteractUI(lVar7,0);
        if ((*pStatics_af70 == 0) ||
           (lVar7 = *(int64 *)(*pStatics_af70 + 32)) == null)
        throw; // [null/range check failed]
        GameObject.SetActive(lVar7,0,0);
        this.extraInfo = "";
        plVar12 = (int64 *)0;
        this.nowResultID = _resultID;
        this.nowTextID = 0;
        if ((GameController._instance == null) ||
           (lVar7 = GameController._instance.worldData) == null)
        throw; // [null/range check failed]
        WorldData.AddGameResultTriggered(lVar7,this.nowResultID,0);
        lVar7 = **(int64 **)(DAT_181e5fa68 + 184);
        lVar9 = PlotController.attriIndexCache;
        if (lVar9 == null) throw; // [null/range check failed]
        uVar2 = this.nowResultID;
        if (lVar9.Count <= uVar2) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        uVar6 = String.Format("进入结局：{0}",
                               *(uint64 *)
                                (lVar9._items + 32 + (int64)(int)uVar2 * 8),0);
        if (lVar7 == null) throw; // [null/range check failed]
        local_48 = 0;
        uStack_40 = 0;
        InfoController.AddInfoTab
                  (lVar7,uVar6,"UIAtlas","任务_完成","终场锣",0x3f800000,0x40a00000,&local_48,0
                  );
        if ((GameController._instance == null) ||
           (lVar7 = GameController._instance.worldData) == null)
        throw; // [null/range check failed]
        iVar4 = lVar7.gameDifficulty;
        lVar7 = *(int64 *)(*(int64 *)(DAT_181e538e8 + 184) + 192);
        if (lVar7 == null) throw; // [null/range check failed]
        if (iVar4 == lVar7.Count + -1) {
          lVar7 = GameController.ChangeAllAreaStateIDs;
          if (lVar7 == null) throw; // [null/range check failed]
          GameDataController.ChangeAchStats(lVar7,39,0x3f800000);
          if ((this.nowResultID == null) || (this.nowResultID == 7)) {
            lVar7 = GameController.ChangeAllAreaStateIDs;
            if (lVar7 == null) throw; // [null/range check failed]
            GameDataController.ChangeAchStats(lVar7,49,0x3f800000);
          }
        }
        lVar7 = this.gameEndPlotDatas;
        lVar9 = GameController.ChangeAllAreaStateIDs;
        if (lVar7 == null) throw; // [null/range check failed]
        uVar2 = this.nowResultID;
        if (lVar7.Count <= uVar2) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar7 = lVar7._items[uVar2];
        if ((lVar7 == null) || (lVar9 == null)) throw; // [null/range check failed]
        GameDataController.ChangeAchStats(lVar9,lVar7.villageAreaID,0x3f800000,0);
        if ((GameController._instance == null) ||
           (lVar7 = GameController._instance.worldData) == null)
        throw; // [null/range check failed]
        lVar7 = WorldData.Player(lVar7,0);
        if (lVar7 == null) throw; // [null/range check failed]
        cVar3 = HeroData.HaveForce(lVar7,0);
        if (cVar3) {
          if ((GameController._instance == null) ||
             (lVar7 = GameController._instance.worldData) == null)
          throw; // [null/range check failed]
          lVar7 = WorldData.Player(lVar7,0);
          if (lVar7 == null) throw; // [null/range check failed]
          lVar7 = HeroData.GetForce(lVar7,0,0);
          if (lVar7 == null) throw; // [null/range check failed]
          if ((lVar7.totalWinFightCount != false) && (this.nowResultID - 6U < 2)) {
            lVar7 = FUN_180210740(0);
            if (lVar7 == null) throw; // [null/range check failed]
            GameDataController.ChangeAchStats(lVar7,44,0x3f800000);
          }
        }
        if (this.gameEndPanel == null) {
        LAB_1806bdfee:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        GameObject.SetActive(this.gameEndPanel,1,0);
        if (this.gameEndPanel == null) goto LAB_1806bdfee;
        lVar7 = GameObject.GetComponent(this.gameEndPanel,DAT_181e53ed0);
        if (lVar7 == null) goto LAB_1806bdfee;
        CanvasGroup.set_alpha(lVar7,0,0);
        if (this.gameEndPanel == null) goto LAB_1806bdfee;
        uVar6 = GameObject.GetComponent(this.gameEndPanel,DAT_181e53ed0);
        uVar6 = DOTweenModuleUI.DOFade(uVar6,0x3f800000,0x40800000,0);
        uVar6 = TweenSettingsExtensions.SetUpdate(uVar6,1,DAT_181ea58d0);
        uVar8 = new OnTooltipCB(this,DAT_181e58d70,0);
        TweenSettingsExtensions.OnComplete(uVar6,uVar8,DAT_181ea3c28);
        if (this.gameEndPanel == null) goto LAB_1806bdfee;
        lVar7 = GameObject.get_transform(this.gameEndPanel,0);
        if (lVar7 == null) goto LAB_1806bdfee;
        lVar7 = Transform.Find(lVar7,"BackgroundImage",0);
        if (lVar7 == null) goto LAB_1806bdfee;
        lVar7 = Component.GetComponent(lVar7,DAT_181e777b8);
        local_res20[0] = this.nowResultID;
        uVar8 = il2cpp_value_box(DAT_181e60808,local_res20);
        uVar6 = "Textures/Ending/{0}{1}";
        if (this.nowResultID == 1) {
        LAB_1806bd9eb:
          uVar13 = "";
        }
        else {
          if ((GameController._instance == null) ||
             (lVar9 = GameController._instance.worldData) == null)
          throw; // [null/range check failed]
          lVar9 = WorldData.Player(lVar9,0);
          if (lVar9 == null) throw; // [null/range check failed]
          uVar13 = "f";
          if (!lVar9.WorldEventDatas) goto LAB_1806bd9eb;
        }
        uVar8 = String.Format(uVar6,uVar8,uVar13,0);
        uVar6 = DAT_181ea1420;
        uVar6 = Type.GetTypeFromHandle(uVar6,0);
        plVar10 = (int64 *)Resources.Load(uVar8,uVar6,0);
        if (lVar7 != null) {
          plVar11 = plVar12;
          if ((plVar10 != (int64 *)0) && (*plVar10 == DAT_181e85028)) {
            plVar11 = plVar10;
          }
          Image.set_sprite(lVar7,plVar11,0);
          this.textShowing = 1;
          GameResultController.HideText(this,0);
          uVar6 = "";
          if (this.nowResultID == 9) {
            if ((GameController._instance != null) &&
               (lVar7 = GameController._instance.worldData) != null) {
              lVar7 = WorldData.Player(lVar7,0);
              if (lVar7 != null) {
                if (0 < *(int *)(lVar7 + 0x328)) {
                  lVar7 = FUN_1802106e0(0);
                  if (lVar7 == null) throw; // [null/range check failed]
                  lVar7 = lVar7.villageAreaID;
                  lVar9 = FUN_1802106e0(0);
                  if ((lVar9 == null) || (lVar9.villageAreaID == null)) throw; // [null/range check failed]
                  lVar9 = WorldData.Player(lVar9.villageAreaID,0);
                  if ((lVar9 == null) || (lVar7 == null)) throw; // [null/range check failed]
                  lVar7 = WorldData.GetHero(lVar7,*(uint32 *)(lVar9 + 0x328),0);
                  if (lVar7 == null) throw; // [null/range check failed]
                  uVar8 = HeroData.Name(lVar7,1,0);
                  uVar6 = String.Concat(uVar6,uVar8,"，",0);
                }
                while( true ) {
                  if ((GameController._instance == null) ||
                     (lVar7 = GameController._instance.worldData) == null)
                  throw; // [null/range check failed]
                  lVar7 = WorldData.Player(lVar7,0);
                  if ((lVar7 == null) || (*(int64 *)(lVar7 + 0x330) == 0)) throw; // [null/range check failed]
                  if (*(int *)(*(int64 *)(lVar7 + 0x330) + 24) <= (int)plVar12) break;
                  lVar7 = FUN_1802106e0(0);
                  if ((lVar7 == null) || (lVar7.villageAreaID == null)) throw; // [null/range check failed]
                  lVar7 = WorldData.Player(lVar7.villageAreaID,0);
                  if ((lVar7 == null) || (*(int64 *)(lVar7 + 0x330) == 0)) throw; // [null/range check failed]
                  iVar4 = FUN_180002480();
                  if (0 < iVar4) {
                    lVar7 = FUN_1802106e0(0);
                    if (lVar7 == null) throw; // [null/range check failed]
                    lVar7 = lVar7.villageAreaID;
                    lVar9 = FUN_1802106e0(0);
                    if ((lVar9 == null) || (lVar9.villageAreaID == null)) throw; // [null/range check failed]
                    lVar9 = WorldData.Player(lVar9.villageAreaID,0);
                    if ((lVar9 == null) || (*(int64 *)(lVar9 + 0x330) == 0)) throw; // [null/range check failed]
                    uVar5 = FUN_180002480(*(int64 *)(lVar9 + 0x330),plVar12,DAT_181e71bf0);
                    if (lVar7 == null) throw; // [null/range check failed]
                    lVar7 = WorldData.GetHero(lVar7,uVar5,0);
                    if (lVar7 == null) throw; // [null/range check failed]
                    HeroData.Name(lVar7,1,0);
                    uVar6 = String.Concat(uVar6);
                  }
                  plVar12 = (int64 *)(uint64)((int)plVar12 + 1);
                }
                cVar3 = FUN_180ad1200(uVar6,0);
                if (cVar3) goto LAB_1806bdec1;
                lVar7 = this.gameEndPlotDatas;
                if (lVar7 != null) {
                  uVar2 = this.nowResultID;
                  if (lVar7.Count <= uVar2) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar7 = lVar7._items[uVar2];
                  if ((lVar7 = lVar7?.forceAreaID) != null) {
                    uVar2 = this.nowTextID;
                    if (lVar7.Count <= uVar2) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar9 = this.gameEndPlotDatas;
                    lVar7 = lVar7._items[uVar2];
                    if (lVar9 != null) {
                      uVar2 = this.nowResultID;
                      if (lVar9.Count <= uVar2) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar9 = lVar9._items[uVar2]
                      ;
                      if ((lVar9 = lVar9?.forceAreaID) != null) {
                        uVar2 = this.nowTextID;
                        if (lVar9.Count <= uVar2) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar9 = *(int64 *)
                                 (lVar9._items + 32 + (int64)(int)uVar2 * 8);
                        if (lVar9 != null) {
                          uVar6 = String.Concat(lVar9._items,"\n",uVar6,0);
                          if (lVar7 != null) {
                            lVar7._items = uVar6;
                            goto LAB_1806bdec1;
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
        LAB_1806bdec1:
            if (this.gameEndPanel != null) {
              lVar7 = GameObject.get_transform(this.gameEndPanel,0);
              if (lVar7 != null) {
                lVar7 = Transform.Find(lVar7,"TextBack",0);
                if (lVar7 != null) {
                  local_48 = 0x3f80000000000000;
                  uStack_40 = CONCAT44(uStack_40._4_4_,0x3f800000);
                  Transform.set_localScale(lVar7,&local_48,0);
                  if (this.gameEndPanel != null) {
                    lVar7 = GameObject.get_transform(this.gameEndPanel,0);
                    if (lVar7 != null) {
                      uVar6 = Transform.Find(lVar7,"TextBack",0);
                      uVar6 = ShortcutExtensions.DOScale(uVar6,0x3f800000,0x3f800000,0);
                      uVar6 = TweenSettingsExtensions.SetUpdate(uVar6,1,DAT_181ea59e0);
                      uVar6 = TweenSettingsExtensions.SetDelay(uVar6,0x40a00000,DAT_181ea4858);
                      uVar8 = new OnTooltipCB(this,DAT_181e58df8,0);
                      TweenSettingsExtensions.OnComplete(uVar6,uVar8,DAT_181ea3dc0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600172A
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

    // Token : 0x600172B
    // RVA   : 0x6BED50   Offset: 0x6BDB50   Length: 0x20A
    private static void /*cctor*/()
    {
        long lVar2;
        lVar2 = il2cpp_internal(DAT_181e77728);
        FUN_1810f3480(lVar2,DAT_181e861f0);
        if (lVar2 != null) {
          FUN_18175de30(lVar2,"天下第一",DAT_181e86370);
          FUN_18175de30(lVar2,"归隐田园",DAT_181e86370);
          FUN_18175de30(lVar2,"豪商巨贾",DAT_181e86370);
          FUN_18175de30(lVar2,"功成名就",DAT_181e86370);
          FUN_18175de30(lVar2,"禁军统领",DAT_181e86370);
          FUN_18175de30(lVar2,"权势滔天",DAT_181e86370);
          FUN_18175de30(lVar2,"名门大派",DAT_181e86370);
          FUN_18175de30(lVar2,"武林盟主",DAT_181e86370);
          FUN_18175de30(lVar2,"终归一统",DAT_181e86370);
          FUN_18175de30(lVar2,"鸾凤和鸣",DAT_181e86370);
          FUN_18175de30(lVar2,"终生监禁",DAT_181e86370);
          plVar1 = *(int64 **)(DAT_181e52b18 + 184);
          *plVar1 = lVar2;
          il2cpp_internal(plVar1,lVar2);
          return;
        }
    }

    // Token : 0x600172C
    // RVA   : 0x6BE990   Offset: 0x6BD790   Length: 0x20
    private void <HideResultCredit>b__13_0()
    {
        if (this.gameResultCreditPanel != null) {
          GameObject.SetActive(this.gameResultCreditPanel,0,0);
          return;
        }
    }

    // Token : 0x600172D
    // RVA   : 0x6BE9C0   Offset: 0x6BD7C0   Length: 0xC5
    private void <ShowResultCredit>b__14_0()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e71f68 + 184) + 24);
        if (lVar1 != null) {
          PlotController.HideInteractUI(lVar1,0);
          if (this.gameEndPanel != null) {
            GameObject.SetActive(this.gameEndPanel,0,0);
            return;
          }
        }
    }

    // Token : 0x600172E
    // RVA   : 0x6BEA90   Offset: 0x6BD890   Length: 0xB2
    private void <ShowText>b__17_0()
    {
        long lVar1;
        ulong uVar2;
        this.textShowing = 0;
        if (this.gameEndPanel != null) {
          lVar1 = GameObject.get_transform(this.gameEndPanel,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"NextButton",0);
            if (lVar1 != null) {
              uVar2 = Component.GetComponent(lVar1,DAT_181e777b8);
              uVar2 = DOTweenModuleUI.DOFade(uVar2,0x3f800000,0x3e4ccccd,0);
              TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181ea5848);
              return;
            }
          }
        }
    }

    // Token : 0x600172F
    // RVA   : 0x6BEB50   Offset: 0x6BD950   Length: 0x100
    private void <StartGameResult>b__20_0()
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        lVar2 = this.gameEndPlotDatas;
        lVar3 = *(int64 *)(*(int64 *)(DAT_181e8fc20 + 184) + 8);
        if (lVar2 != null) {
          uVar1 = this.nowResultID;
          if (lVar2.Count <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2._items[uVar1];
          if ((lVar2 != null) && (lVar3 != null)) {
            BGMController.SetPlotBgm(lVar3,lVar2.Count,0);
            return;
          }
        }
    }

    // Token : 0x6001730
    // RVA   : 0x6BEC60   Offset: 0x6BDA60   Length: 0xE9
    private void <StartGameResult>b__20_1()
    {
        uint uVar1;
        long lVar2;
        ulong uVar3;
        lVar2 = this.gameEndPlotDatas;
        if (lVar2 != null) {
          uVar1 = this.nowResultID;
          if (lVar2.Count <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2._items[uVar1];
          if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 40)) != null) {
            uVar1 = this.nowTextID;
            if (lVar2.Count <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = lVar2._items[uVar1];
            if (lVar2 != null) {
              uVar3 = lVar2._items;
              uVar3 = GlobalData.ReplaceSpeString(uVar3,0,0);
              GameResultController.ShowText(this,uVar3,0);
              return;
            }
          }
        }
    }

}
