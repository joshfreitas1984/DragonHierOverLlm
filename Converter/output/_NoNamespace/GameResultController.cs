// ============================================================
// Type  : GameResultController
// Token : 0x20002A4
// ============================================================

public class GameResultController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40014D2
    public int nowResultID;

    // Token: 0x40014D3
    public int nowTextID;

    // Token: 0x40014D4
    public GameObject gameEndPanel;

    // Token: 0x40014D5
    public GameObject gameResultCreditPanel;

    // Token: 0x40014D6
    public string extraInfo;

    // Token: 0x40014D7
    public static List<string> gameResultName;

    // Token: 0x40014D8
    public List<GameEndPlotData> gameEndPlotDatas;

    // Token: 0x40014D9
    private static GameResultController _instance;

    // Token: 0x40014DA
    private bool textShowing;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600165F
    // RVA   : 0xA2DEB0   Offset: 0xA2C6B0   Length: 0x58
    public static GameResultController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d4e208 + 184) + 8);
    }

    // Token : 0x6001660
    // RVA   : 0xA29C00   Offset: 0xA28400   Length: 0x68
    private void Awake()
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d4e208 + 184) + 8);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6001661
    // RVA   : 0xA29EB0   Offset: 0xA286B0   Length: 0x7
    public void ContinueButtonClicked()
    {
        void FUN_180a29eb0(uint64 this)
        {
        GameResultController.HideResultCredit(this,0);
    }

    // Token : 0x6001662
    // RVA   : 0xA2A2B0   Offset: 0xA28AB0   Length: 0x46
    public void QuitButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d4e090 + 184);
        if (*pStatics != 0) {
          GameMenuController.SureQuitGame(*pStatics,0);
          return;
        }
    }

    // Token : 0x6001663
    // RVA   : 0xA29EC0   Offset: 0xA286C0   Length: 0x217
    public void HideResultCredit()
    {
        var pStatics = *(int64*)(DAT_181d65970 + 184);
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
                lVar1 = Component.GetComponent(lVar1,DAT_181d6af40);
                if (lVar1 != null) {
                  Selectable.set_interactable(lVar1,0,0);
                  if (this.gameResultCreditPanel != null) {
                    lVar1 = GameObject.get_transform(this.gameResultCreditPanel,0);
                    if (lVar1 != null) {
                      lVar1 = Transform.Find(lVar1,"Quit",0);
                      if (lVar1 != null) {
                        lVar1 = Component.GetComponent(lVar1,DAT_181d6af40);
                        if (lVar1 != null) {
                          Selectable.set_interactable(lVar1,0,0);
                          if (this.gameResultCreditPanel != null) {
                            uVar2 = GameObject.GetComponent(this.gameResultCreditPanel,DAT_181d9f080);
                            uVar2 = DOTweenModuleUI.DOFade(uVar2,0,0x3f800000,0);
                            uVar2 = TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181d989e0);
                            uVar3 = new OnTooltipCB(this,DAT_181da36b0,0);
                            TweenSettingsExtensions.OnComplete(uVar2,uVar3,DAT_181d96d50);
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

    // Token : 0x6001664
    // RVA   : 0xA2A300   Offset: 0xA28B00   Length: 0x1BE4
    public void ShowResultCredit()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
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
        lVar4 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar4,DAT_181d7c250);
        if (lVar4 != null) {
          FUN_181827900(lVar4,"至圣",DAT_181d7c3d0);
          FUN_181827900(lVar4,"大侠",DAT_181d7c3d0);
          FUN_181827900(lVar4,"义士",DAT_181d7c3d0);
          FUN_181827900(lVar4,"中庸",DAT_181d7c3d0);
          FUN_181827900(lVar4,"叛逆",DAT_181d7c3d0);
          FUN_181827900(lVar4,"枭雄",DAT_181d7c3d0);
          FUN_181827900(lVar4,"魔首",DAT_181d7c3d0);
          if ((((this.gameResultCreditPanel != null) &&
               (lVar5 = GameObject.get_transform(this.gameResultCreditPanel,0)) != null) &&
              (lVar5 = Transform.Find(lVar5,"Continue",0)) != null) &&
             (lVar5 = Component.GetComponent(lVar5,DAT_181d6af40)) != null) {
            Selectable.set_interactable(lVar5,1,0);
            if (((this.gameResultCreditPanel != null) &&
                (lVar5 = GameObject.get_transform(this.gameResultCreditPanel,0)) != null) &&
               ((lVar5 = Transform.Find(lVar5,"Quit",0), lVar5 != null &&
                (lVar5 = Component.GetComponent(lVar5,DAT_181d6af40)) != null))) {
              Selectable.set_interactable(lVar5,1,0);
              if (this.gameResultCreditPanel != null) {
                GameObject.SetActive(this.gameResultCreditPanel,1,0);
                if ((this.gameResultCreditPanel != null) &&
                   (lVar5 = GameObject.GetComponent(this.gameResultCreditPanel,DAT_181d9f080),
                   lVar5 != null)) {
                  CanvasGroup.set_alpha(lVar5);
                  if ((this.gameResultCreditPanel != null) &&
                     ((lVar5 = GameObject.get_transform(this.gameResultCreditPanel,0), lVar5 != null &&
                      (lVar5 = Transform.Find(lVar5,"Count",0)) != null))) {
                    uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
                    plVar7 = (int64 *)FUN_1800d60b0(DAT_181d7f180,12);
                    lVar5 = **(int64 **)(DAT_181d4e208 + 184);
                    if (lVar5 != null) {
                      uVar3 = this.nowResultID;
                      if (*(uint32 *)(lVar5 + 24) <= uVar3) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar5 = String.Concat(*(uint64 *)
                                              (*(int64 *)(lVar5 + 16) + 32 +
                                              (int64)(int)uVar3 * 8),this.extraInfo,0)
                      ;
                      if (plVar7 != (int64 *)0) {
                        if ((lVar5 != null) &&
                           (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64)), lVar8 == null
                           )) {
                          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar6,0);
                        }
                        if ((int)plVar7[3] == 0) {
                          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar6,0);
                        }
                        plVar7[4] = lVar5;
                        il2cpp_internal(plVar7 + 4,lVar5);
                        if ((*pStatics != 0) &&
                           (lVar5 = *(int64 *)(*pStatics + 32),
                           lVar5 != null)) {
                          lVar5 = WorldData.GetDifficlutyName(lVar5,0);
                          if ((lVar5 != null) &&
                             (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64)),
                             lVar8 == null)) {
                            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar6,0);
                          }
                          if (*(uint32 *)(plVar7 + 3) < 2) {
                            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar6,0);
                          }
                          plVar7[5] = lVar5;
                          il2cpp_internal(plVar7 + 5,lVar5);
                          if ((*pStatics != 0) &&
                             (lVar5 = *(int64 *)(*pStatics + 32),
                             lVar5 != null)) {
                            local_res18[0] = *(uint32 *)(lVar5 + 0x18c);
                            lVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
                            if ((lVar5 != null) &&
                               (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64)),
                               lVar8 == null)) {
                              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar6,0);
                            }
                            if (*(uint32 *)(plVar7 + 3) < 3) {
                              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar6,0);
                            }
                            plVar7[6] = lVar5;
                            il2cpp_internal(plVar7 + 6,lVar5);
                            if ((*pStatics != 0) &&
                               (lVar5 = *(int64 *)(*pStatics + 32),
                               lVar5 != null)) {
                              local_res20[0] = *(uint32 *)(lVar5 + 400);
                              lVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
                              if ((lVar5 != null) &&
                                 (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64)),
                                 lVar8 == null)) {
                                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar6,0);
                              }
                              if (*(uint32 *)(plVar7 + 3) < 4) {
                                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar6,0);
                              }
                              plVar7[7] = lVar5;
                              il2cpp_internal(plVar7 + 7,lVar5);
                              uVar9 = "达成结局: {0}\n游戏模式: {11}\n游戏难度: {1}\n最终金钱: {8}\n最终声望: {9}\n战斗场数: {2} (胜场{3} 胜率{4}%)\n击败人数: {5}\n结识人数: {6}\n总计恶名: {7} ({10})";
                              if ((*pStatics != 0) &&
                                 (lVar5 = *(int64 *)(*pStatics + 32),
                                 lVar5 != null)) {
                                local_a8 = 0;
                                if (*(int *)(lVar5 + 0x18c) == 0) {
        LAB_180a2abe3:
                                  lVar5 = il2cpp_value_box(DAT_181d5b2f8,&local_a8);
                                  if ((lVar5 != null) &&
                                     (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64)),
                                     lVar8 == null)) {
                                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar6,0);
                                  }
                                  if (*(uint32 *)(plVar7 + 3) < 5) {
                                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar6,0);
                                  }
                                  plVar7[8] = lVar5;
                                  il2cpp_internal(plVar7 + 8,lVar5);
                                  if ((*pStatics != 0) &&
                                     (lVar5 = *(int64 *)(*pStatics + 32),
                                     lVar5 != null)) {
                                    local_a4 = *(uint32 *)(lVar5 + 0x194);
                                    lVar5 = il2cpp_value_box(DAT_181d5b2f8,&local_a4);
                                    if ((lVar5 != null) &&
                                       (lVar8 = il2cpp_internal(lVar5,*(uint64 *)(*plVar7 + 64))
                                       , lVar8 == null)) {
                                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar6,0);
                                    }
                                    if (*(uint32 *)(plVar7 + 3) < 6) {
                                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar6,0);
                                    }
                                    plVar7[9] = lVar5;
                                    il2cpp_internal(plVar7 + 9,lVar5);
                                    if ((*pStatics != 0) &&
                                       (lVar5 = *(int64 *)
                                                 (*pStatics + 32),
                                       lVar5 != null)) {
                                      local_a0 = *(uint32 *)(lVar5 + 0x1a8);
                                      lVar5 = il2cpp_value_box(DAT_181d5b2f8,&local_a0);
                                      if ((lVar5 != null) &&
                                         (lVar8 = il2cpp_internal(lVar5,*(uint64 *)
                                                                             (*plVar7 + 64)), lVar8 == null
                                         )) {
                                        uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                        FUN_1800d65f0(uVar6,0);
                                      }
                                      if (*(uint32 *)(plVar7 + 3) < 7) {
                                        uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                        FUN_1800d65f0(uVar6,0);
                                      }
                                      plVar7[10] = lVar5;
                                      il2cpp_internal(plVar7 + 10,lVar5);
                                      if ((*pStatics != 0) &&
                                         (lVar5 = *(int64 *)
                                                   (*pStatics + 32),
                                         lVar5 != null)) {
                                        lVar5 = Single.ToString(lVar5 + 0x198,"f0",0);
                                        if ((lVar5 != null) &&
                                           (lVar8 = il2cpp_internal(lVar5,*(uint64 *)
                                                                               (*plVar7 + 64)),
                                           lVar8 == null)) {
                                          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                          FUN_1800d65f0(uVar6,0);
                                        }
                                        if (*(uint32 *)(plVar7 + 3) < 8) {
                                          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                          FUN_1800d65f0(uVar6,0);
                                        }
                                        plVar7[11] = lVar5;
                                        il2cpp_internal(plVar7 + 11,lVar5);
                                        if ((((*pStatics != 0) &&
                                             (lVar5 = *(int64 *)
                                                       (*pStatics + 32),
                                             lVar5 != null)) &&
                                            (lVar5 = WorldData.Player(lVar5,0)) != null) &&
                                           (*(int64 *)(lVar5 + 0x220) != 0)) {
                                          local_9c = *(uint32 *)(*(int64 *)(lVar5 + 0x220) + 24);
                                          lVar5 = il2cpp_value_box(DAT_181d5b2f8,&local_9c);
                                          if ((lVar5 != null) &&
                                             (lVar8 = il2cpp_internal(lVar5,*(uint64 *)
                                                                                 (*plVar7 + 64)),
                                             lVar8 == null)) {
                                            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                            FUN_1800d65f0(uVar6,0);
                                          }
                                          if (*(uint32 *)(plVar7 + 3) < 9) {
                                            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                            FUN_1800d65f0(uVar6,0);
                                          }
                                          plVar7[12] = lVar5;
                                          il2cpp_internal(plVar7 + 12,lVar5);
                                          if (((*pStatics != 0) &&
                                              (lVar5 = *(int64 *)
                                                        (*pStatics + 32),
                                              lVar5 != null)) &&
                                             (lVar5 = WorldData.Player(lVar5,0)) != null) {
                                            lVar5 = Single.ToString(lVar5 + 0x1c4,"f0",0);
                                            if ((lVar5 != null) &&
                                               (lVar8 = il2cpp_internal(lVar5,*(uint64 *)
                                                                                   (*plVar7 + 64)),
                                               lVar8 == null)) {
                                              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                              FUN_1800d65f0(uVar6,0);
                                            }
                                            if (*(uint32 *)(plVar7 + 3) < 10) {
                                              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                              FUN_1800d65f0(uVar6,0);
                                            }
                                            plVar7[13] = lVar5;
                                            il2cpp_internal(plVar7 + 13,lVar5);
                                            if ((*pStatics != 0) &&
                                               (lVar5 = *(int64 *)
                                                         (*pStatics + 32),
                                               lVar5 != null)) {
                                              uVar2 = Mathf.CeilToInt(*(float *)(lVar5 + 0x198) / 200.0,0
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
                                                FUN_1800d65f0(uVar6,0);
                                              }
                                              if (*(uint32 *)(plVar7 + 3) < 11) {
                                                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                FUN_1800d65f0(uVar6,0);
                                              }
                                              plVar7[14] = lVar4;
                                              il2cpp_internal(plVar7 + 14,lVar4);
                                              lVar4 = *(int64 *)
                                                       (*(int64 *)(DAT_181d4ef00 + 184) + 184);
                                              if (((*pStatics != 0) &&
                                                  (lVar5 = *(int64 *)
                                                            (*pStatics + 32)
                                                  , lVar5 != null)) && (lVar4 != null)) {
                                                uVar3 = *(uint32 *)(lVar5 + 156);
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
                                                  FUN_1800d65f0(uVar6,0);
                                                }
                                                if (*(uint32 *)(plVar7 + 3) < 12) {
                                                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                  FUN_1800d65f0(uVar6,0);
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
                                                           Component.GetComponent(lVar4,DAT_181d6bc40);
                                                  puVar10 = (uint64 *)FUN_180d904c0(&local_c8,0);
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
                                                      uVar6 = Component.GetComponent(lVar4,DAT_181d6bc40)
                                                      ;
                                                      uVar6 = DOTweenModuleUI.DOFade(uVar6);
                                                      uVar6 = TweenSettingsExtensions.SetUpdate
                                                                        (uVar6,1,DAT_181d98958);
                                                      uVar9 = new OnTooltipCB(this,DAT_181da3730,0);
                                                      TweenSettingsExtensions.OnComplete
                                                                (uVar6,uVar9,DAT_181d96cc8);
                                                      if (((this.gameResultCreditPanel != null) &&
                                                          (lVar4 = GameObject.get_transform
                                                                             (*(int64 *)
                                                                               (this + 40),0),
                                                          lVar4 != null)) &&
                                                         (lVar4 = Transform.Find(lVar4,"CustomDifficulty",0),
                                                         lVar4 != null)) {
                                                        plVar7 = (int64 *)
                                                                 Component.GetComponent
                                                                           (lVar4,DAT_181d6d8c0);
                                                        if (((*pStatics != 0)
                                                            && (lVar4 = *(int64 *)
                                                                         (**(int64 **)
                                                                            (DAT_181d4df90 + 184) + 32)
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
                                                                                (uVar6,1,DAT_181d98af0);
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
                                                                             (lVar4,DAT_181d6bc40);
                                                          uVar6 = 0;
                                                          uVar2 = 0;
                                                          local_88 = 0;
                                                          uStack_80 = 0;
                                                          FUN_1809981e0(&local_88);
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
                                                                            (lVar4,DAT_181d6bc40);
                                                          uVar6 = DOTweenModuleUI.DOFade(uVar6);
                                                          uVar6 = TweenSettingsExtensions.SetUpdate
                                                                            (uVar6,1,DAT_181d98958);
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
                                                                               (lVar4,DAT_181d6bc40);
                                                            uVar6 = 0;
                                                            uVar2 = 0;
                                                            local_78 = 0;
                                                            uStack_70 = 0;
                                                            FUN_1809981e0(&local_78);
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
                                                                            (lVar4,DAT_181d6bc40);
                                                          uVar6 = DOTweenModuleUI.DOFade(uVar6);
                                                          uVar6 = TweenSettingsExtensions.SetUpdate
                                                                            (uVar6,1,DAT_181d98958);
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
                                                                               (lVar4,DAT_181d6d8c0);
                                                            uVar6 = 0;
                                                            local_68 = 0;
                                                            uStack_60 = 0;
                                                            uVar2 = 0;
                                                            FUN_1809981e0(&local_68);
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
                                                                            (lVar4,DAT_181d6d8c0);
                                                          uVar6 = DOTweenModuleUI.DOFade(uVar6);
                                                          uVar6 = TweenSettingsExtensions.SetUpdate
                                                                            (uVar6,1,DAT_181d98958);
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
                                                                               (lVar4,DAT_181d6d8c0);
                                                            uVar6 = 0;
                                                            uVar2 = 0;
                                                            local_98 = 0;
                                                            uStack_90 = 0;
                                                            FUN_1809981e0(&local_98);
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
                                                                            (lVar4,DAT_181d6d8c0);
                                                          uVar6 = DOTweenModuleUI.DOFade(uVar6);
                                                          uVar6 = TweenSettingsExtensions.SetUpdate
                                                                            (uVar6,1,DAT_181d98958);
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
                                                                          (uVar6,1,DAT_181d98af0);
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
                                                                                (uVar6,1,DAT_181d98af0);
                                                              TweenSettingsExtensions.SetDelay(uVar6);
                                                              if ((this.gameResultCreditPanel != null) &&
                                                                 ((lVar4 = GameObject.get_transform
                                                                                     (*(int64 *)
                                                                                       (this + 40),0)
                                                                  , lVar4 != null &&
                                                                  (lVar4 = Transform.Find(lVar4,
                                                        "Unlock",0), lVar4 != null)))) {
                                                          uVar6 = Component.GetComponent
                                                                            (lVar4,DAT_181d6d8c0);
                                                          if (((*pStatics != 0
                                                               ) && (lVar4 = *(int64 *)
                                                                              (**(int64 **)
                                                                                 (DAT_181d4df90 + 184) +
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
                                                                               (lVar4,DAT_181d6d8c0);
                                                            uVar6 = 0;
                                                            uVar2 = 0;
                                                            local_c8 = 0;
                                                            uStack_c0 = 0;
                                                            FUN_1809981e0(&local_c8);
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
                                                                            (lVar4,DAT_181d6d8c0);
                                                          uVar6 = DOTweenModuleUI.DOFade(uVar6);
                                                          uVar6 = TweenSettingsExtensions.SetUpdate
                                                                            (uVar6,1,DAT_181d98958);
                                                          TweenSettingsExtensions.SetDelay(uVar6);
                                                          return;
                                                        }
                                                        }
                                                        }
                          // WARNING: Subroutine does not return
                                                        FUN_1800d6620();
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
                                  FUN_1800d6620();
                                }
                                if ((*pStatics != 0) &&
                                   (lVar5 = *(int64 *)(*pStatics + 32),
                                   lVar5 != null)) {
                                  iVar1 = *(int *)(lVar5 + 400);
                                  if ((*pStatics != 0) &&
                                     (lVar5 = *(int64 *)(*pStatics + 32),
                                     lVar5 != null)) {
                                    local_a8 = Mathf.RoundToInt(((float)iVar1 * 100.0) /
                                                                 (float)*(int *)(lVar5 + 0x18c),0);
                                    goto LAB_180a2abe3;
                                  }
                                }
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
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

    // Token : 0x6001665
    // RVA   : 0xA2A0E0   Offset: 0xA288E0   Length: 0x1C6
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
              plVar2 = (int64 *)Component.GetComponent(lVar1,DAT_181d6bc40);
              local_58 = 0;
              uStack_50 = 0;
              FUN_1809981e0(&local_58,0x3f800000,0x3f800000,0x3f800000,0,0);
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
                      plVar2 = (int64 *)Component.GetComponent(lVar1,DAT_181d6d8c0);
                      local_48 = 0;
                      uStack_40 = 0;
                      FUN_1809981e0(&local_48,0x3f800000,0x3f800000,0x3f800000,0,0);
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

    // Token : 0x6001666
    // RVA   : 0xA2BEF0   Offset: 0xA2A6F0   Length: 0x1F6
    public void ShowText(string text)
    {
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/Paper",0);
        plVar5 = (int64 *)0;
        if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181d8a228)) {
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
              uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
              LTLocalization.SetText(uVar3,text,0);
              if (this.gameEndPanel != null) {
                lVar2 = GameObject.get_transform(this.gameEndPanel,0);
                if (lVar2 != null) {
                  lVar2 = Transform.Find(lVar2,"Text",0);
                  if (lVar2 != null) {
                    uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
                    uVar3 = DOTweenModuleUI.DOFade(uVar3,0x3f800000,0x3f800000,0);
                    uVar3 = TweenSettingsExtensions.SetUpdate(uVar3,1,DAT_181d98958);
                    uVar4 = new OnTooltipCB(this,DAT_181da37b0,0);
                    TweenSettingsExtensions.OnComplete(uVar3,uVar4,DAT_181d96cc8);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001667
    // RVA   : 0xA29C70   Offset: 0xA28470   Length: 0x235
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
              cVar4 = FUN_180d6ca90(lVar3.Count,0);
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

    // Token : 0x6001668
    // RVA   : 0xA2CF50   Offset: 0xA2B750   Length: 0x98A
    public void StartSpeFinalPlot()
    {
        var pStatics_c960 = *(int64*)(DAT_181d6c960 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
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
        if ((*pStatics_df90 != 0) &&
           (lVar3 = *(int64 *)(*pStatics_df90 + 32)) != null) {
          if (*(float *)(lVar3 + 0x198) == 0.0) {
            uVar7 = 3;
          }
          else {
            if ((*pStatics_df90 == 0) ||
               (lVar3 = *(int64 *)(*pStatics_df90 + 32)) == null)
            throw; // [null/range check failed]
            if (*(float *)(lVar3 + 0x198) <= 200.0) {
              uVar7 = 2;
            }
            else {
              lVar3 = FUN_18046c0a0(0);
              if ((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) throw; // [null/range check failed]
              if (*(float *)(*(int64 *)(lVar3 + 32) + 0x198) <= 400.0) {
                uVar7 = 1;
              }
            }
          }
          lVar3 = il2cpp_internal(DAT_181d72a30);
          FUN_180f58a90(lVar3,DAT_181d7c250);
          if (lVar3 != null) {
            FUN_181827900(lVar3,"五十年，\n后人认为这段时期，已不输贞观之治和开元盛世。",DAT_181d7c3d0);
            FUN_181827900(lVar3,"一百年，\n后人认为这段时期，已远在贞观之治和开元盛世之上。",DAT_181d7c3d0);
            FUN_181827900(lVar3,"三百年，\n后人认为这段时期，便是秦皇汉武之统治也难以望其项背。",DAT_181d7c3d0);
            FUN_181827900(lVar3,"五百年，\n后人认为其文治武功与得国之正，堪称古今第一帝王。",DAT_181d7c3d0);
            lVar4 = il2cpp_internal(DAT_181d72a30);
            FUN_180f58a90(lVar4,DAT_181d7c250);
            if (lVar4 != null) {
              FUN_181827900(lVar4,"·盛世五十年",DAT_181d7c3d0);
              FUN_181827900(lVar4,"·盛世一百年",DAT_181d7c3d0);
              FUN_181827900(lVar4,"·盛世三百年",DAT_181d7c3d0);
              FUN_181827900(lVar4,"·盛世五百年",DAT_181d7c3d0);
              if (*(uint32 *)(lVar4 + 24) <= uVar7) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar8 = (uint64)uVar7;
              this.extraInfo =
                   *(uint64 *)(*(int64 *)(lVar4 + 16) + 32 + uVar8 * 8);
              il2cpp_internal();
              if (((*pStatics_df90 != 0) &&
                  (lVar4 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
                 (lVar2 != null)) {
                lVar1 = *(int64 *)(lVar2 + 64);
                if (*(int *)(lVar4 + 156) == 1) {
                  if (*(uint32 *)(lVar3 + 24) <= uVar7) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  uVar6 = String.Format("这一盛世在#$PlayerName#故去之后仍持续了{0}\n而此后历朝历代，百姓万民，也无不称颂怀念#$PlayerName#所开创的这一黄金时代。",
                                         *(uint64 *)(*(int64 *)(lVar3 + 16) + 32 + uVar8 * 8),0
                                        );
                  uVar5 = new SinglePlotData(uVar6,0,0);
                }
                else {
                  if (*(uint32 *)(lVar3 + 24) <= uVar7) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  uVar5 = String.Format("这一盛世在#$PlayerName#故去之后仍持续了{0}\n而此后历朝历代，百姓万民，也无不称颂怀念#$PlayerName#所开创的这一黄金时代。",
                                         *(uint64 *)(*(int64 *)(lVar3 + 16) + 32 + uVar8 * 8),0
                                        );
                  uVar6 = il2cpp_internal(DAT_181d7d2b0);
                  SinglePlotData.ctor
                            (uVar6,uVar5,0,1,0,1,0,3,"ScreenBlack",
                             in_stack_ffffffffffffffb0 & 0xffffffffffffff00,0,0,0,0,0);
                  if (lVar1 == null) throw; // [null/range check failed]
                  FUN_181827900(lVar1,uVar6,DAT_181d79a58);
                  lVar3 = *(int64 *)(lVar2 + 64);
                  uVar5 = FUN_180004500(DAT_181d63120);
                  uVar5 = String.Format("多年以后一个炎热的下午，你正坐在大殿中思考国策。\n突然一阵强烈的眩晕袭来，使你天旋地转，如坠云里雾里。",uVar5,0);
                  uVar6 = new SinglePlotData(uVar5,0,1,0,1,0,3,0,0);
                  if (lVar3 == null) throw; // [null/range check failed]
                  FUN_181827900(lVar3,uVar6,DAT_181d79a58);
                  lVar3 = *(int64 *)(lVar2 + 64);
                  uVar5 = FUN_180004500(DAT_181d63120);
                  uVar5 = String.Format("在宫女的惊叫和师兄妹们的呼唤声中，\n你又仿佛回到了许多年前的那个清晨。\n仙霞山上的虫鸣鸟语，开始在宫殿之中回响。",uVar5,0);
                  uVar6 = new SinglePlotData(uVar5,0,1,0,1,0,3,0,0);
                  if (lVar3 == null) throw; // [null/range check failed]
                  FUN_181827900(lVar3,uVar6,DAT_181d79a58);
                  lVar3 = *(int64 *)(lVar2 + 64);
                  uVar5 = FUN_180004500(DAT_181d63120);
                  uVar5 = String.Format("#PlayerName#！#PlayerName#！都日上三竿了，怎么还在睡大觉呢！\n嘴里还一直念叨着什么“看招”，“承让”，\n怕不是又在梦里行侠仗义了。",uVar5,0);
                  uVar6 = new SinglePlotData(uVar5,0,5,"杨思迟",3,"0",0,0,0);
                  if (lVar3 == null) throw; // [null/range check failed]
                  FUN_181827900(lVar3,uVar6,DAT_181d79a58);
                  lVar1 = *(int64 *)(lVar2 + 64);
                  uVar5 = FUN_180004500(DAT_181d63120);
                  uVar6 = String.Format("别吵吵，我正在泰岳大典施展拳脚，大杀四方，\n眼看就要将各大门派打个落花流水......没想到被你搅了好事！",uVar5,0);
                  uVar5 = il2cpp_internal(DAT_181d7d2b0);
                  in_stack_ffffffffffffffb0 = 0;
                  SinglePlotData.ctor(uVar5,uVar6,0,5,"杨思迟",3,"0",1,0,0);
                }
                if (lVar1 != null) {
                  FUN_181827900(lVar1,uVar5,DAT_181d79a58);
                  lVar3 = *(int64 *)(lVar2 + 64);
                  uVar5 = FUN_180004500(DAT_181d63120);
                  uVar5 = String.Format("后人将此段历史整理成册，抄写影印，使之流传千古直至现在。\n这一故事，便被称作————————",uVar5,0);
                  uVar6 = il2cpp_internal(DAT_181d7d2b0);
                  SinglePlotData.ctor
                            (uVar6,uVar5,0,1,0,1,0,3,"ShowResultCredit",
                             in_stack_ffffffffffffffb0 & 0xffffffffffffff00,0,0,0,0,0);
                  if (lVar3 != null) {
                    FUN_181827900(lVar3,uVar6,DAT_181d79a58);
                    if (*pStatics_c960 != 0) {
                      PlotController.ChangePlot(*pStatics_c960,lVar2,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001669
    // RVA   : 0xA2C0F0   Offset: 0xA2A8F0   Length: 0xE53
    public void StartGameResult(int _resultID)
    {
        var pStatics_5970 = *(int64*)(DAT_181d65970 + 184);
        var pStatics_c960 = *(int64*)(DAT_181d6c960 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_e010 = *(int64*)(DAT_181d4e010 + 184);
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
        if (*pStatics_c960 == 0) throw; // [null/range check failed]
        PlotController.HideInteractUI(*pStatics_c960,0);
        if ((*pStatics_5970 == 0) ||
           (lVar7 = *(int64 *)(*pStatics_5970 + 32)) == null)
        throw; // [null/range check failed]
        GameObject.SetActive(lVar7,0,0);
        this.extraInfo = "";
        plVar12 = (int64 *)0;
        this.nowResultID = _resultID;
        this.nowTextID = 0;
        if ((*pStatics_df90 == 0) ||
           (lVar7 = *(int64 *)(*pStatics_df90 + 32)) == null)
        throw; // [null/range check failed]
        WorldData.AddGameResultTriggered(lVar7,this.nowResultID,0);
        lVar7 = **(int64 **)(DAT_181d5a578 + 184);
        lVar9 = **(int64 **)(DAT_181d4e208 + 184);
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
        if ((*pStatics_df90 == 0) ||
           (lVar7 = *(int64 *)(*pStatics_df90 + 32)) == null)
        throw; // [null/range check failed]
        iVar4 = *(int *)(lVar7 + 160);
        lVar7 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 192);
        if (lVar7 == null) throw; // [null/range check failed]
        if (iVar4 == lVar7.Count + -1) {
          lVar7 = *(int64 *)(pStatics_e010 + 32);
          if (lVar7 == null) throw; // [null/range check failed]
          GameDataController.ChangeAchStats(lVar7,39,0x3f800000);
        }
        lVar7 = this.gameEndPlotDatas;
        lVar9 = *(int64 *)(pStatics_e010 + 32);
        if (lVar7 == null) {
        LAB_180a2cf3e:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        uVar2 = this.nowResultID;
        if (lVar7.Count <= uVar2) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar7 = lVar7._items[uVar2];
        if ((lVar7 == null) || (lVar9 == null)) goto LAB_180a2cf3e;
        GameDataController.ChangeAchStats(lVar9,*(uint32 *)(lVar7 + 32),0x3f800000,0);
        if (this.gameEndPanel == null) goto LAB_180a2cf3e;
        GameObject.SetActive(this.gameEndPanel,1,0);
        if (this.gameEndPanel == null) goto LAB_180a2cf3e;
        lVar7 = GameObject.GetComponent(this.gameEndPanel,DAT_181d9f080);
        if (lVar7 == null) goto LAB_180a2cf3e;
        CanvasGroup.set_alpha(lVar7,0,0);
        if (this.gameEndPanel == null) goto LAB_180a2cf3e;
        uVar6 = GameObject.GetComponent(this.gameEndPanel,DAT_181d9f080);
        uVar6 = DOTweenModuleUI.DOFade(uVar6,0x3f800000,0x40800000,0);
        uVar6 = TweenSettingsExtensions.SetUpdate(uVar6,1,DAT_181d989e0);
        uVar8 = new OnTooltipCB(this,DAT_181da3830,0);
        TweenSettingsExtensions.OnComplete(uVar6,uVar8,DAT_181d96d50);
        if (this.gameEndPanel == null) goto LAB_180a2cf3e;
        lVar7 = GameObject.get_transform(this.gameEndPanel,0);
        if (lVar7 == null) goto LAB_180a2cf3e;
        lVar7 = Transform.Find(lVar7,"BackgroundImage",0);
        if (lVar7 == null) goto LAB_180a2cf3e;
        lVar7 = Component.GetComponent(lVar7,DAT_181d6bc40);
        local_res20[0] = this.nowResultID;
        uVar8 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
        uVar6 = "Textures/Ending/{0}{1}";
        if (this.nowResultID == 1) {
        LAB_180a2c93e:
          uVar13 = "";
        }
        else {
          if ((*pStatics_df90 == 0) ||
             (lVar9 = *(int64 *)(*pStatics_df90 + 32)) == null)
          throw; // [null/range check failed]
          lVar9 = WorldData.Player(lVar9,0);
          if (lVar9 == null) throw; // [null/range check failed]
          uVar13 = "f";
          if (*(char *)(lVar9 + 128) == false) goto LAB_180a2c93e;
        }
        uVar8 = String.Format(uVar6,uVar8,uVar13,0);
        uVar6 = DAT_181d9d060;
        uVar6 = Type.GetTypeFromHandle(uVar6,0);
        plVar10 = (int64 *)Resources.Load(uVar8,uVar6,0);
        if (lVar7 != null) {
          plVar11 = plVar12;
          if ((plVar10 != (int64 *)0) && (*plVar10 == DAT_181d7f9b0)) {
            plVar11 = plVar10;
          }
          Image.set_sprite(lVar7,plVar11,0);
          this.textShowing = 1;
          GameResultController.HideText(this,0);
          uVar6 = "";
          if (this.nowResultID == 9) {
            if ((*pStatics_df90 != 0) &&
               (lVar7 = *(int64 *)(*pStatics_df90 + 32)) != null) {
              lVar7 = WorldData.Player(lVar7,0);
              if (lVar7 != null) {
                if (0 < *(int *)(lVar7 + 0x328)) {
                  lVar7 = FUN_18046c0a0(0);
                  if (lVar7 == null) throw; // [null/range check failed]
                  lVar7 = *(int64 *)(lVar7 + 32);
                  lVar9 = FUN_18046c0a0(0);
                  if ((lVar9 == null) || (*(int64 *)(lVar9 + 32) == 0)) throw; // [null/range check failed]
                  lVar9 = WorldData.Player(*(int64 *)(lVar9 + 32),0);
                  if ((lVar9 == null) || (lVar7 == null)) throw; // [null/range check failed]
                  lVar7 = WorldData.GetHero(lVar7,*(uint32 *)(lVar9 + 0x328),0);
                  if (lVar7 == null) throw; // [null/range check failed]
                  uVar8 = HeroData.Name(lVar7,1,0);
                  uVar6 = String.Concat(uVar6,uVar8,"，",0);
                }
                while( true ) {
                  if ((*pStatics_df90 == 0) ||
                     (lVar7 = *(int64 *)(*pStatics_df90 + 32)) == null)
                  throw; // [null/range check failed]
                  lVar7 = WorldData.Player(lVar7,0);
                  if ((lVar7 == null) || (*(int64 *)(lVar7 + 0x330) == 0)) throw; // [null/range check failed]
                  if (*(int *)(*(int64 *)(lVar7 + 0x330) + 24) <= (int)plVar12) break;
                  lVar7 = FUN_18046c0a0(0);
                  if ((lVar7 == null) || (*(int64 *)(lVar7 + 32) == 0)) throw; // [null/range check failed]
                  lVar7 = WorldData.Player(*(int64 *)(lVar7 + 32),0);
                  if ((lVar7 == null) || (*(int64 *)(lVar7 + 0x330) == 0)) throw; // [null/range check failed]
                  iVar4 = FUN_1800d6750();
                  if (0 < iVar4) {
                    lVar7 = FUN_18046c0a0(0);
                    if (lVar7 == null) throw; // [null/range check failed]
                    lVar7 = *(int64 *)(lVar7 + 32);
                    lVar9 = FUN_18046c0a0(0);
                    if ((lVar9 == null) || (*(int64 *)(lVar9 + 32) == 0)) throw; // [null/range check failed]
                    lVar9 = WorldData.Player(*(int64 *)(lVar9 + 32),0);
                    if ((lVar9 == null) || (*(int64 *)(lVar9 + 0x330) == 0)) throw; // [null/range check failed]
                    uVar5 = FUN_1800d6750(*(int64 *)(lVar9 + 0x330),plVar12,DAT_181d68270);
                    if (lVar7 == null) throw; // [null/range check failed]
                    lVar7 = WorldData.GetHero(lVar7,uVar5,0);
                    if (lVar7 == null) throw; // [null/range check failed]
                    HeroData.Name(lVar7,1,0);
                    uVar6 = String.Concat(uVar6);
                  }
                  plVar12 = (int64 *)(uint64)((int)plVar12 + 1);
                }
                cVar3 = FUN_180d6ca90(uVar6,0);
                if (cVar3) goto LAB_180a2ce11;
                lVar7 = this.gameEndPlotDatas;
                if (lVar7 != null) {
                  uVar2 = this.nowResultID;
                  if (lVar7.Count <= uVar2) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar7 = lVar7._items[uVar2];
                  if ((lVar7 != null) && (lVar7 = *(int64 *)(lVar7 + 40)) != null) {
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
                      if ((lVar9 != null) && (lVar9 = *(int64 *)(lVar9 + 40)) != null) {
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
                            goto LAB_180a2ce11;
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
        LAB_180a2ce11:
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
                      uVar6 = TweenSettingsExtensions.SetUpdate(uVar6,1,DAT_181d98af0);
                      uVar6 = TweenSettingsExtensions.SetDelay(uVar6,0x40a00000,DAT_181d97978);
                      uVar8 = new OnTooltipCB(this,DAT_181d4d220,0);
                      TweenSettingsExtensions.OnComplete(uVar6,uVar8,DAT_181d96ee8);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600166A
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x600166B
    // RVA   : 0xA2DCA0   Offset: 0xA2C4A0   Length: 0x20A
    private static void /*cctor*/()
    {
        long lVar2;
        lVar2 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar2,DAT_181d7c250);
        if (lVar2 != null) {
          FUN_181827900(lVar2,"天下第一",DAT_181d7c3d0);
          FUN_181827900(lVar2,"归隐田园",DAT_181d7c3d0);
          FUN_181827900(lVar2,"豪商巨贾",DAT_181d7c3d0);
          FUN_181827900(lVar2,"功成名就",DAT_181d7c3d0);
          FUN_181827900(lVar2,"禁军统领",DAT_181d7c3d0);
          FUN_181827900(lVar2,"权势滔天",DAT_181d7c3d0);
          FUN_181827900(lVar2,"名门大派",DAT_181d7c3d0);
          FUN_181827900(lVar2,"武林盟主",DAT_181d7c3d0);
          FUN_181827900(lVar2,"终归一统",DAT_181d7c3d0);
          FUN_181827900(lVar2,"鸾凤和鸣",DAT_181d7c3d0);
          FUN_181827900(lVar2,"终生监禁",DAT_181d7c3d0);
          plVar1 = *(int64 **)(DAT_181d4e208 + 184);
          *plVar1 = lVar2;
          il2cpp_internal(plVar1,lVar2);
          return;
        }
    }

    // Token : 0x600166C
    // RVA   : 0xA2D8E0   Offset: 0xA2C0E0   Length: 0x20
    private void <HideResultCredit>b__13_0()
    {
        if (this.gameResultCreditPanel != null) {
          GameObject.SetActive(this.gameResultCreditPanel,0,0);
          return;
        }
    }

    // Token : 0x600166D
    // RVA   : 0xA2D910   Offset: 0xA2C110   Length: 0xC4
    private void <ShowResultCredit>b__14_0()
    {
        var pStatics = *(int64*)(DAT_181d6c960 + 184);
        if (*pStatics != 0) {
          PlotController.HideInteractUI(*pStatics,0);
          if (this.gameEndPanel != null) {
            GameObject.SetActive(this.gameEndPanel,0,0);
            return;
          }
        }
    }

    // Token : 0x600166E
    // RVA   : 0xA2D9E0   Offset: 0xA2C1E0   Length: 0xB2
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
              uVar2 = Component.GetComponent(lVar1,DAT_181d6bc40);
              uVar2 = DOTweenModuleUI.DOFade(uVar2,0x3f800000,0x3e4ccccd,0);
              TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181d98958);
              return;
            }
          }
        }
    }

    // Token : 0x600166F
    // RVA   : 0xA2DAA0   Offset: 0xA2C2A0   Length: 0x100
    private void <StartGameResult>b__20_0()
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        lVar2 = this.gameEndPlotDatas;
        lVar3 = *(int64 *)(*(int64 *)(DAT_181d8a9a8 + 184) + 8);
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

    // Token : 0x6001670
    // RVA   : 0xA2DBB0   Offset: 0xA2C3B0   Length: 0xE9
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
