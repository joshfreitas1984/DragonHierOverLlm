// ============================================================
// Type  : AISettingTabController
// Token : 0x200013A
// ============================================================

public class AISettingTabController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40007AA
    public HeroAISettingTabController sourceHero;

    // Token: 0x40007AB
    public GameObject focusButton;

    // Token: 0x40007AC
    public int AISettingID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000A18
    // RVA   : 0xA1A5A0   Offset: 0xA199A0   Length: 0x4FA
    public void Refresh()
    {
        uint uVar1;
        int iVar2;
        bool cVar3;
        uint uVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        long lVar9;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        lVar5 = Component.get_transform(this,0);
        if ((lVar5 != null) && (lVar5 = Transform.Find(lVar5,"Text",0)) != null) {
          uVar6 = Component.GetComponent(lVar5,DAT_181d96178);
          if ((this.sourceHero != null) &&
             ((((lVar5 = this.sourceHero.targetHero, lVar5 != null &&
                (lVar5 = *(int64 *)(lVar5 + 80)) != null) &&
               (lVar5 = *(int64 *)(lVar5 + 16)) != null) &&
              (lVar5 = FUN_1817da060(lVar5,this.AISettingID,DAT_181db29a8)) != null)))
          {
            uVar7 = Int32.ToString(lVar5 + 16,0);
            LTLocalization.SetText(uVar6,uVar7,0);
            lVar5 = Component.get_transform(this,0);
            if ((lVar5 != null) && (lVar5 = Transform.Find(lVar5,"Text",0)) != null) {
              plVar8 = (int64 *)Component.GetComponent(lVar5,DAT_181d96178);
              lVar5 = GameController.lockObj;
              if (lVar5 != null) {
                lVar5 = *(int64 *)(lVar5 + 56);
                if ((((this.sourceHero != null) &&
                     (lVar9 = this.sourceHero.targetHero) != null) &&
                    (lVar9 = *(int64 *)(lVar9 + 80)) != null) &&
                   ((lVar9 = *(int64 *)(lVar9 + 16), lVar9 != null &&
                    (lVar9 = FUN_1817da060(lVar9,this.AISettingID,DAT_181db29a8),
                    lVar9 != null)))) {
                  uVar1 = *(uint32 *)(lVar9 + 16);
                  lVar9 = GameController.lockObj;
                  if ((lVar9 != null) && (lVar9 = *(int64 *)(lVar9 + 56)) != null) {
                    uVar4 = Mathf.Clamp(uVar1,0,*(int *)(lVar9 + 24) + -1,0);
                    if (lVar5 != null) {
                      if (*(uint32 *)(lVar5 + 24) <= uVar4) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar5 = lVar5[uVar4]
                      ;
                      if ((lVar5 != null) && (plVar8 != (int64 *)0)) {
                        local_18 = *(uint32 *)(lVar5 + 24);
                        uStack_14 = *(uint32 *)(lVar5 + 28);
                        uStack_10 = *(uint32 *)(lVar5 + 32);
                        uStack_c = *(uint32 *)(lVar5 + 36);
                        (**(code **)(*plVar8 + 0x2a8))(plVar8,&local_18,*(uint64 *)(*plVar8 + 0x2b0));
                        lVar5 = *(int64 *)(*(int64 *)(DAT_181da9df8 + 184) + 32);
                        if (lVar5 != null) {
                          cVar3 = FUN_18182a9b0(lVar5,this.AISettingID,DAT_181d7ad20);
                          lVar5 = this.focusButton;
                          if (!cVar3) {
                            if (lVar5 != null) {
                              GameObject.SetActive(lVar5,0,0);
                              return;
                            }
                          }
                          else if (lVar5 != null) {
                            GameObject.SetActive(lVar5,1,0);
                            if ((((this.sourceHero != null) &&
                                 (lVar5 = this.sourceHero.targetHero) != null
                                 ) && (lVar5 = *(int64 *)(lVar5 + 80)) != null) &&
                               ((lVar5 = *(int64 *)(lVar5 + 16), lVar5 != null &&
                                (lVar5 = FUN_1817da060(lVar5,this.AISettingID,DAT_181db29a8
                                                      ), lVar5 != null)))) {
                              iVar2 = *(int *)(lVar5 + 20);
                              if ((this.focusButton != null) &&
                                 (lVar5 = GameObject.get_transform(this.focusButton,0),
                                 lVar5 != null)) {
                                plVar8 = (int64 *)Component.GetComponent(lVar5,DAT_181d94478);
                                if (iVar2 < 0) {
                                  puVar10 = (uint32 *)FUN_1810d3b80();
                                }
                                else {
                                  puVar10 = (uint32 *)Color.get_yellow(&local_18,0);
                                }
                                if (plVar8 != (int64 *)0) {
                                  local_18 = *puVar10;
                                  uStack_14 = puVar10[1];
                                  uStack_10 = puVar10[2];
                                  uStack_c = puVar10[3];
                                  (**(code **)(*plVar8 + 0x2a8))
                                            (plVar8,&local_18,*(uint64 *)(*plVar8 + 0x2b0));
                                  if (this.focusButton != null) {
                                    lVar5 = GameObject.GetComponent
                                                      (this.focusButton,DAT_181d73448);
                                    if (((this.sourceHero != null) &&
                                        (lVar9 = this.sourceHero.targetHero,
                                        lVar9 != null)) &&
                                       ((lVar9 = *(int64 *)(lVar9 + 80), lVar9 != null &&
                                        (uVar6 = HeroAISettingData.GetFocusText
                                                           (lVar9,this.AISettingID,0),
                                        lVar5 != null)))) {
                                      *(uint64 *)(lVar5 + 24) = uVar6;
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

    // Token : 0x6000A19
    // RVA   : 0xA1A300   Offset: 0xA19700   Length: 0x158
    public void OnClick()
    {
        bool cVar1;
        uint uVar2;
        long lVar3;
        if ((((this.sourceHero != null) &&
             (lVar3 = this.sourceHero.targetHero) != null) &&
            (lVar3 = *(int64 *)(lVar3 + 80)) != null) &&
           (lVar3 = *(int64 *)(lVar3 + 16)) != null) {
          lVar3 = FUN_1817da060(lVar3,this.AISettingID,DAT_181db29a8);
          cVar1 = FUN_1804625f0(0x130,0);
          uVar2 = 0;
          if (!cVar1) {
            cVar1 = FUN_1804625f0(0x132,0);
            if (lVar3 != null) {
              if ((!cVar1) && (*(int *)(lVar3 + 16) != 5)) {
                uVar2 = Mathf.Clamp(*(int *)(lVar3 + 16) + 1,0,5);
              }
        LAB_180a1a3ec:
              *(uint32 *)(lVar3 + 16) = uVar2;
              AISettingTabController.Refresh(this,0);
              plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
              plVar5 = (int64 *)0;
              if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181daf360)) {
                plVar5 = plVar4;
              }
              NGUITools.PlaySound(plVar5,0);
              return;
            }
          }
          else if (lVar3 != null) {
            uVar2 = 5;
            goto LAB_180a1a3ec;
          }
        }
    }

    // Token : 0x6000A1A
    // RVA   : 0xA1A460   Offset: 0xA19860   Length: 0x133
    public void OnRightClick()
    {
        bool cVar1;
        uint uVar2;
        long lVar3;
        if ((((this.sourceHero != null) &&
             (lVar3 = this.sourceHero.targetHero) != null) &&
            (lVar3 = *(int64 *)(lVar3 + 80)) != null) &&
           (lVar3 = *(int64 *)(lVar3 + 16)) != null) {
          lVar3 = FUN_1817da060(lVar3,this.AISettingID,DAT_181db29a8);
          cVar1 = FUN_1804625f0(0x130,0);
          if (lVar3 != null) {
            uVar2 = 0;
            if (!cVar1) {
              uVar2 = Mathf.Max(0,*(int *)(lVar3 + 16) + -1,0);
            }
            *(uint32 *)(lVar3 + 16) = uVar2;
            AISettingTabController.Refresh(this,0);
            plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/Woosh",0);
            plVar5 = (int64 *)0;
            if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181daf360)) {
              plVar5 = plVar4;
            }
            NGUITools.PlaySound(plVar5,0);
            return;
          }
        }
    }

    // Token : 0x6000A1B
    // RVA   : 0xA19DE0   Offset: 0xA191E0   Length: 0x515
    public void FocusButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d94018 + 184);
        int iVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        uint local_28;
        uint local_24;
        uint[] local_20 = new uint[2];
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d91ba0 + 184) + 24);
        if (lVar2 != null) {
          plVar6 = (int64 *)(lVar2 + 0x1e0);
          *plVar6 = this;
          il2cpp_internal(plVar6,this);
          if ((((this.sourceHero != null) &&
               (lVar2 = this.sourceHero.targetHero) != null) &&
              (lVar2 = *(int64 *)(lVar2 + 80)) != null) &&
             (lVar2 = *(int64 *)(lVar2 + 16)) != null) {
            lVar2 = FUN_1817da060(lVar2,this.AISettingID,DAT_181db29a8);
            if (lVar2 != null) {
              *(uint32 *)(lVar2 + 20) = 0xffffffff;
              AISettingTabController.Refresh(this,0);
              iVar1 = this.AISettingID;
              if (iVar1 == 1) {
                lVar2 = **(int64 **)(DAT_181db7530 + 184);
                lVar3 = il2cpp_internal(DAT_181d94e68);
                FUN_181330100(lVar3,DAT_181d957a0);
                if ((this.sourceHero != null) &&
                   (lVar5 = this.sourceHero.targetHero) != null) {
                  local_res18[0] = *(uint32 *)(lVar5 + 88);
                  uVar4 = il2cpp_value_box(DAT_181d80430,local_res18);
                  if (lVar3 != null) {
                    FUN_18181e6b0(lVar3,uVar4,DAT_181d958a0);
                    FUN_18181e6b0(lVar3,0,DAT_181d958a0);
                    local_res20[0] = 0xffffffff;
                    uVar4 = il2cpp_value_box(DAT_181d80430,local_res20);
                    FUN_18181e6b0(lVar3,uVar4,DAT_181d958a0);
                    local_28 = 0xffffffff;
                    uVar4 = il2cpp_value_box(DAT_181d80430,&local_28);
                    FUN_18181e6b0(lVar3,uVar4,DAT_181d958a0);
                    local_24 = 0xffffffff;
                    uVar4 = il2cpp_value_box(DAT_181d80430,&local_24);
                    FUN_18181e6b0(lVar3,uVar4,DAT_181d958a0);
                    local_20[0] = 9;
                    uVar4 = il2cpp_value_box(DAT_181d80430,local_20);
                    FUN_18181e6b0(lVar3,uVar4,DAT_181d958a0);
                    lVar5 = FUN_18046c400(0);
                    if (lVar5 != null) {
                      uVar4 = Component.get_gameObject(lVar5,0);
                      if (lVar2 != null) {
                        ChooseController.ShowChoosePanel(lVar2,0,lVar3,uVar4,"AIStudyFightSkillFocusChoosen",0,0,0,0,0);
                        goto LAB_180a1a288;
                      }
                    }
                  }
                }
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if (iVar1 == 2) {
                lVar2 = FUN_18046c400(0);
                if (lVar2 == null) throw; // [null/range check failed]
                PlotController.AIStudyLivingSkillFocusChoose(lVar2,0);
              }
              else if (iVar1 == 3) {
                lVar2 = FUN_18046c400(0);
                if (lVar2 == null) throw; // [null/range check failed]
                PlotController.AICollectResourceFocusChoose(lVar2,0);
              }
              else if (iVar1 == 4) {
                if (*pStatics == 0) throw; // [null/range check failed]
                QuickTravelUIController.ShowQuickTravelUI(*pStatics,4);
              }
              else if (iVar1 == 5) {
                if (*pStatics == 0) throw; // [null/range check failed]
                QuickTravelUIController.ShowQuickTravelUI(*pStatics,5);
              }
        LAB_180a1a288:
              plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
              plVar7 = (int64 *)0;
              if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181daf360)) {
                plVar7 = plVar6;
              }
              NGUITools.PlaySound(plVar7,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000A1C
    // RVA   : 0xA1AAA0   Offset: 0xA19EA0   Length: 0x7F
    public void SetFocus(int focusID)
    {
        long lVar1;
        if ((((this.sourceHero != null) &&
             (lVar1 = this.sourceHero.targetHero) != null) &&
            (lVar1 = *(int64 *)(lVar1 + 80)) != null) &&
           (lVar1 = *(int64 *)(lVar1 + 16)) != null) {
          lVar1 = FUN_1817da060(lVar1,this.AISettingID,DAT_181db29a8);
          if (lVar1 != null) {
            *(uint32 *)(lVar1 + 20) = focusID;
            AISettingTabController.Refresh(this,0);
            return;
          }
        }
    }

    // Token : 0x6000A1D
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
