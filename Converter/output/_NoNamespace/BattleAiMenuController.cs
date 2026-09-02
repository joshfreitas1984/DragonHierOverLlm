// ============================================================
// Type  : BattleAiMenuController
// Token : 0x200018A
// ============================================================

public class BattleAiMenuController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000A57
    public GameObject battleAiMenuPanel;

    // Token: 0x4000A58
    public GameObject battleAiGrid;

    // Token: 0x4000A59
    public GameObject battleAiSettingPrefab;

    // Token: 0x4000A5A
    private static BattleAiMenuController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000C99
    // RVA   : 0x7FAA00   Offset: 0x7F9200   Length: 0x36
    public static BattleAiMenuController get_Instance()
    {
        return **(uint64 **)(DAT_181d8b0a8 + 184);
    }

    // Token : 0x6000C9A
    // RVA   : 0x7FA340   Offset: 0x7F8B40   Length: 0x99
    private void Awake()
    {
        ulong uVar1;
        bool cVar3;
        uVar1 = **(uint64 **)(DAT_181d8b0a8 + 184);
        cVar3 = Object.op_Equality(uVar1,0,0);
        if (cVar3) {
          puVar2 = *(uint64 **)(DAT_181d8b0a8 + 184);
          *puVar2 = this;
          il2cpp_internal(puVar2,this);
        }
    }

    // Token : 0x6000C9B
    // RVA   : 0x7FA3E0   Offset: 0x7F8BE0   Length: 0x475
    public void ShowBattleAiMenu()
    {
        ulong uVar1;
        bool cVar2;
        uint uVar3;
        long lVar4;
        ulong uVar7;
        long lVar8;
        long lVar9;
        long lVar10;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        if (this.battleAiMenuPanel != null) {
          GameObject.SetActive(this.battleAiMenuPanel,1,0);
          if (this.battleAiMenuPanel != null) {
            lVar4 = GameObject.get_transform(this.battleAiMenuPanel,0);
            if (lVar4 != null) {
              lVar4 = Transform.Find(lVar4,"BlackBackground",0);
              if (lVar4 != null) {
                plVar5 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40);
                puVar6 = (uint32 *)FUN_180d904c0(&local_28,0);
                if (plVar5 != (int64 *)0) {
                  local_28 = *puVar6;
                  uStack_24 = puVar6[1];
                  uStack_20 = puVar6[2];
                  uStack_1c = puVar6[3];
                  (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_28,*(uint64 *)(*plVar5 + 0x2b0));
                  if (this.battleAiMenuPanel != null) {
                    lVar4 = GameObject.get_transform(this.battleAiMenuPanel,0);
                    if (lVar4 != null) {
                      lVar4 = Transform.Find(lVar4,"BlackBackground",0);
                      if (lVar4 != null) {
                        uVar7 = Component.GetComponent(lVar4,DAT_181d6bc40);
                        DOTweenModuleUI.DOFade(uVar7,0x3f400000,0x3e4ccccd,0);
                        if (this.battleAiMenuPanel != null) {
                          lVar4 = GameObject.get_transform(this.battleAiMenuPanel,0);
                          if (lVar4 != null) {
                            lVar4 = Transform.Find(lVar4,"BattleAIMenuRoot",0);
                            if (lVar4 != null) {
                              uStack_24 = 0x3f800000;
                              local_28 = 0;
                              uStack_20 = 0x3f800000;
                              Transform.set_localScale(lVar4,&local_28,0);
                              if (this.battleAiMenuPanel != null) {
                                lVar4 = GameObject.get_transform(this.battleAiMenuPanel,0);
                                if (lVar4 != null) {
                                  uVar7 = Transform.Find(lVar4,"BattleAIMenuRoot",0);
                                  ShortcutExtensions.DOScaleX(uVar7,0x3f800000,0x3e4ccccd,0);
                                  lVar4 = *(int64 *)(*(int64 *)(DAT_181d8b128 + 184) + 80);
                                  if (lVar4 != null) {
                                    lVar10 = *(int64 *)(lVar4 + 112);
                                    uVar3 = BattleController.GetPlayerControlTeamID(lVar4,0);
                                    if (lVar10 != null) {
                                      if (*(uint32 *)(lVar10 + 24) <= uVar3) {
                                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                      }
                                      lVar4 = *(int64 *)
                                               (*(int64 *)(lVar10 + 16) + 32 +
                                               (int64)(int)uVar3 * 8);
                                      uVar3 = 0;
                                      if (lVar4 != null) {
                                        lVar10 = 32;
                                        while (lVar8 = *(int64 *)(lVar4 + 24)) != null {
                                          if ((int)*(uint32 *)(lVar8 + 24) <= (int)uVar3) {
                                            return;
                                          }
                                          if (*(uint32 *)(lVar8 + 24) <= uVar3) {
                                            ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                          }
                                          lVar8 = *(int64 *)(lVar10 + *(int64 *)(lVar8 + 16));
                                          if (lVar8 == null) break;
                                          cVar2 = BattleUnit.get_IsAlive(lVar8,0);
                                          if (cVar2) {
                                            uVar7 = this.battleAiGrid;
                                            uVar1 = this.battleAiSettingPrefab;
                                            lVar8 = GlobalData.AddChild(uVar7,uVar1,0);
                                            if (*(int64 *)(lVar4 + 24) == 0) break;
                                            lVar9 = FUN_180002f80(*(int64 *)(lVar4 + 24),uVar3,
                                                                  DAT_181d584a0);
                                            if (((lVar9 == null) || (*(int64 *)(lVar9 + 64) == 0)) ||
                                               (lVar8 == null)) break;
                                            if (*(int *)(*(int64 *)(lVar9 + 64) + 88) == 0) {
                                              lVar9 = GameObject.get_transform(lVar8,0);
                                              if (lVar9 == null) break;
                                              Transform.SetAsFirstSibling(lVar9,0);
                                            }
                                            lVar9 = GameObject.GetComponent(lVar8,DAT_181d9e5e0);
                                            if (*(int64 *)(lVar4 + 24) == 0) break;
                                            uVar7 = FUN_180002f80(*(int64 *)(lVar4 + 24),uVar3);
                                            if (lVar9 == null) break;
                                            *(uint64 *)(lVar9 + 24) = uVar7;
                                            lVar8 = GameObject.GetComponent(lVar8);
                                            if (lVar8 == null) break;
                                            BattleAISettingController.Init(lVar8);
                                          }
                                          uVar3 = uVar3 + 1;
                                          lVar10 = lVar10 + 8;
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

    // Token : 0x6000C9C
    // RVA   : 0x7FA860   Offset: 0x7F9060   Length: 0x192
    public void UnShowBattleAiMenu()
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        if (this.battleAiMenuPanel != null) {
          lVar1 = GameObject.get_transform(this.battleAiMenuPanel,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"BlackBackground",0);
            if (lVar1 != null) {
              uVar2 = Component.GetComponent(lVar1,DAT_181d6bc40);
              DOTweenModuleUI.DOFade(uVar2,0,0x3e4ccccd,0);
              if (this.battleAiMenuPanel != null) {
                lVar1 = GameObject.get_transform(this.battleAiMenuPanel,0);
                if (lVar1 != null) {
                  uVar2 = Transform.Find(lVar1,"BattleAIMenuRoot",0);
                  uVar2 = ShortcutExtensions.DOScaleX(uVar2,0,0x3e4ccccd,0);
                  uVar3 = new OnTooltipCB(this,DAT_181d60a50,0);
                  TweenSettingsExtensions.OnComplete(uVar2,uVar3,DAT_181d96ee8);
                  uVar2 = this.battleAiGrid;
                  GlobalData.DeleteAllChild(uVar2,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000C9D
    // RVA   : 0x7F9F00   Offset: 0x7F8700   Length: 0x21A
    public void AllAutoButtonClicked()
    {
        int iVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        ulong uVar5;
        int iVar6;
        lVar2 = this.battleAiGrid;
        iVar6 = 0;
        if (lVar2 != null) {
          while (lVar2 = GameObject.get_transform(lVar2,0)) != null {
            iVar1 = Transform.get_childCount(lVar2,0);
            if (iVar1 <= iVar6) {
              return;
            }
            if ((((this.battleAiGrid == null) ||
                 (lVar2 = GameObject.get_transform(this.battleAiGrid,0)) == null) ||
                (lVar2 = Transform.GetChild(lVar2,iVar6,0)) == null) ||
               ((lVar2 = Component.GetComponent(lVar2), lVar2 == null || (*(int64 *)(lVar2 + 24) == 0))
               )) break;
            if (*(char *)(*(int64 *)(lVar2 + 24) + 176) == false) {
              if (((this.battleAiGrid == null) ||
                  (lVar2 = GameObject.get_transform(this.battleAiGrid,0)) == null) ||
                 ((lVar2 = Transform.GetChild(lVar2,iVar6,0), lVar2 == null ||
                  (lVar2 = Transform.Find(lVar2,"Auto",0)) == null))) break;
              uVar3 = Component.get_gameObject(lVar2,0);
              uVar4 = EventSystem.get_current(0);
              uVar5 = new PointerEventData(uVar4,0);
              uVar4 = FUN_1807e8680(0);
              ExecuteEvents.Execute(uVar3,uVar5,uVar4,DAT_181d90080);
            }
            lVar2 = this.battleAiGrid;
            iVar6 = iVar6 + 1;
            if (lVar2 == null) break;
          }
        }
    }

    // Token : 0x6000C9E
    // RVA   : 0x7FA120   Offset: 0x7F8920   Length: 0x21A
    public void AllHandButtonClicked()
    {
        int iVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        ulong uVar5;
        int iVar6;
        lVar2 = this.battleAiGrid;
        iVar6 = 0;
        if (lVar2 != null) {
          while (lVar2 = GameObject.get_transform(lVar2,0)) != null {
            iVar1 = Transform.get_childCount(lVar2,0);
            if (iVar1 <= iVar6) {
              return;
            }
            if ((((this.battleAiGrid == null) ||
                 (lVar2 = GameObject.get_transform(this.battleAiGrid,0)) == null) ||
                (lVar2 = Transform.GetChild(lVar2,iVar6,0)) == null) ||
               ((lVar2 = Component.GetComponent(lVar2), lVar2 == null || (*(int64 *)(lVar2 + 24) == 0))
               )) break;
            if (*(char *)(*(int64 *)(lVar2 + 24) + 176) != false) {
              if (((this.battleAiGrid == null) ||
                  (lVar2 = GameObject.get_transform(this.battleAiGrid,0)) == null) ||
                 ((lVar2 = Transform.GetChild(lVar2,iVar6,0), lVar2 == null ||
                  (lVar2 = Transform.Find(lVar2,"Auto",0)) == null))) break;
              uVar3 = Component.get_gameObject(lVar2,0);
              uVar4 = EventSystem.get_current(0);
              uVar5 = new PointerEventData(uVar4,0);
              uVar4 = FUN_1807e8680(0);
              ExecuteEvents.Execute(uVar3,uVar5,uVar4,DAT_181d90080);
            }
            lVar2 = this.battleAiGrid;
            iVar6 = iVar6 + 1;
            if (lVar2 == null) break;
          }
        }
    }

    // Token : 0x6000C9F
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6000CA0
    // RVA   : 0x790570   Offset: 0x78ED70   Length: 0x20
    private void <UnShowBattleAiMenu>b__8_0()
    {
        if (this.battleAiMenuPanel != null) {
          GameObject.SetActive(this.battleAiMenuPanel,0,0);
          return;
        }
    }

}
