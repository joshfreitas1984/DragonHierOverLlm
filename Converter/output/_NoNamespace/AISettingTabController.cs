// ============================================================
// Type  : AISettingTabController
// Token : 0x2000136
// ============================================================

public class AISettingTabController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400078B
    public HeroAISettingTabController sourceHero;

    // Token: 0x400078C
    public GameObject focusButton;

    // Token: 0x400078D
    public int AISettingID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60009F6
    // RVA   : 0xA08770   Offset: 0xA06F70   Length: 0x443
    public void Refresh()
    {
        uint uVar1;
        int iVar2;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        long lVar8;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        lVar4 = Component.get_transform(this,0);
        if ((lVar4 != null) && (lVar4 = Transform.Find(lVar4,"Text",0)) != null) {
          uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
          if ((this.sourceHero != null) &&
             ((((lVar4 = this.sourceHero.targetHero, lVar4 != null &&
                (lVar4 = *(int64 *)(lVar4 + 80)) != null) &&
               (lVar4 = *(int64 *)(lVar4 + 16)) != null) &&
              (lVar4 = FUN_1817cc3c0(lVar4,this.AISettingID,DAT_181d8d540)) != null)))
          {
            uVar6 = Int32.ToString(lVar4 + 16,0);
            LTLocalization.SetText(uVar5,uVar6,0);
            lVar4 = Component.get_transform(this,0);
            if ((lVar4 != null) && (lVar4 = Transform.Find(lVar4,"Text",0)) != null) {
              plVar7 = (int64 *)Component.GetComponent(lVar4,DAT_181d6d8c0);
              lVar4 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
              if (lVar4 != null) {
                lVar4 = *(int64 *)(lVar4 + 56);
                if ((((this.sourceHero != null) &&
                     (lVar8 = this.sourceHero.targetHero) != null) &&
                    (lVar8 = *(int64 *)(lVar8 + 80)) != null) &&
                   (((lVar8 = *(int64 *)(lVar8 + 16), lVar8 != null &&
                     (lVar8 = FUN_1817cc3c0(lVar8,this.AISettingID,DAT_181d8d540),
                     lVar8 != null)) && (lVar4 != null)))) {
                  uVar1 = *(uint32 *)(lVar8 + 16);
                  if (*(uint32 *)(lVar4 + 24) <= uVar1) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar4 = lVar4[uVar1];
                  if ((lVar4 != null) && (plVar7 != (int64 *)0)) {
                    local_18 = *(uint32 *)(lVar4 + 24);
                    uStack_14 = *(uint32 *)(lVar4 + 28);
                    uStack_10 = *(uint32 *)(lVar4 + 32);
                    uStack_c = *(uint32 *)(lVar4 + 36);
                    (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_18,*(uint64 *)(*plVar7 + 0x2b0));
                    lVar4 = *(int64 *)(*(int64 *)(DAT_181d84cc0 + 184) + 32);
                    if (lVar4 != null) {
                      cVar3 = FUN_181815240(lVar4,this.AISettingID,DAT_181d53780);
                      lVar4 = this.focusButton;
                      if (!cVar3) {
                        if (lVar4 != null) {
                          GameObject.SetActive(lVar4,0,0);
                          return;
                        }
                      }
                      else if (lVar4 != null) {
                        GameObject.SetActive(lVar4,1,0);
                        if ((((this.sourceHero != null) &&
                             (lVar4 = this.sourceHero.targetHero) != null) &&
                            (lVar4 = *(int64 *)(lVar4 + 80)) != null) &&
                           ((lVar4 = *(int64 *)(lVar4 + 16), lVar4 != null &&
                            (lVar4 = FUN_1817cc3c0(lVar4,this.AISettingID,DAT_181d8d540),
                            lVar4 != null)))) {
                          iVar2 = *(int *)(lVar4 + 20);
                          if ((this.focusButton != null) &&
                             (lVar4 = GameObject.get_transform(this.focusButton,0),
                             lVar4 != null)) {
                            plVar7 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40);
                            if (iVar2 < 0) {
                              puVar9 = (uint32 *)FUN_181098a50();
                            }
                            else {
                              puVar9 = (uint32 *)Color.get_yellow(&local_18,0);
                            }
                            if (plVar7 != (int64 *)0) {
                              local_18 = *puVar9;
                              uStack_14 = puVar9[1];
                              uStack_10 = puVar9[2];
                              uStack_c = puVar9[3];
                              (**(code **)(*plVar7 + 0x2a8))
                                        (plVar7,&local_18,*(uint64 *)(*plVar7 + 0x2b0));
                              if (this.focusButton != null) {
                                lVar4 = GameObject.GetComponent
                                                  (this.focusButton,DAT_181da12b0);
                                if (((this.sourceHero != null) &&
                                    (lVar8 = this.sourceHero.targetHero,
                                    lVar8 != null)) &&
                                   ((lVar8 = *(int64 *)(lVar8 + 80), lVar8 != null &&
                                    (uVar5 = HeroAISettingData.GetFocusText
                                                       (lVar8,this.AISettingID,0),
                                    lVar4 != null)))) {
                                  *(uint64 *)(lVar4 + 24) = uVar5;
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

    // Token : 0x60009F7
    // RVA   : 0xA084D0   Offset: 0xA06CD0   Length: 0x158
    public void OnClick()
    {
        bool cVar1;
        uint uVar2;
        long lVar3;
        if ((((this.sourceHero != null) &&
             (lVar3 = this.sourceHero.targetHero) != null) &&
            (lVar3 = *(int64 *)(lVar3 + 80)) != null) &&
           (lVar3 = *(int64 *)(lVar3 + 16)) != null) {
          lVar3 = FUN_1817cc3c0(lVar3,this.AISettingID,DAT_181d8d540);
          cVar1 = FUN_1804625f0(0x130,0);
          uVar2 = 0;
          if (!cVar1) {
            cVar1 = FUN_1804625f0(0x132,0);
            if (lVar3 != null) {
              if ((!cVar1) && (*(int *)(lVar3 + 16) != 5)) {
                uVar2 = Mathf.Clamp(*(int *)(lVar3 + 16) + 1,0,5);
              }
        LAB_180a085bc:
              *(uint32 *)(lVar3 + 16) = uVar2;
              AISettingTabController.Refresh(this,0);
              plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
              plVar5 = (int64 *)0;
              if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
                plVar5 = plVar4;
              }
              NGUITools.PlaySound(plVar5,0);
              return;
            }
          }
          else if (lVar3 != null) {
            uVar2 = 5;
            goto LAB_180a085bc;
          }
        }
    }

    // Token : 0x60009F8
    // RVA   : 0xA08630   Offset: 0xA06E30   Length: 0x133
    public void OnRightClick()
    {
        bool cVar1;
        uint uVar2;
        long lVar3;
        if ((((this.sourceHero != null) &&
             (lVar3 = this.sourceHero.targetHero) != null) &&
            (lVar3 = *(int64 *)(lVar3 + 80)) != null) &&
           (lVar3 = *(int64 *)(lVar3 + 16)) != null) {
          lVar3 = FUN_1817cc3c0(lVar3,this.AISettingID,DAT_181d8d540);
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
            if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
              plVar5 = plVar4;
            }
            NGUITools.PlaySound(plVar5,0);
            return;
          }
        }
    }

    // Token : 0x60009F9
    // RVA   : 0xA07FB0   Offset: 0xA067B0   Length: 0x514
    public void FocusButtonClicked()
    {
        var pStatics_c960 = *(int64*)(DAT_181d6c960 + 184);
        var pStatics_ede0 = *(int64*)(DAT_181d6ede0 + 184);
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
        if (*pStatics_c960 != 0) {
          plVar6 = (int64 *)(*pStatics_c960 + 0x1d8);
          *plVar6 = this;
          il2cpp_internal(plVar6,this);
          if ((((this.sourceHero != null) &&
               (lVar2 = this.sourceHero.targetHero) != null) &&
              (lVar2 = *(int64 *)(lVar2 + 80)) != null) &&
             (lVar2 = *(int64 *)(lVar2 + 16)) != null) {
            lVar2 = FUN_1817cc3c0(lVar2,this.AISettingID,DAT_181d8d540);
            if (lVar2 != null) {
              *(uint32 *)(lVar2 + 20) = 0xffffffff;
              AISettingTabController.Refresh(this,0);
              iVar1 = this.AISettingID;
              if (iVar1 == 1) {
                lVar2 = **(int64 **)(DAT_181d92370 + 184);
                lVar3 = il2cpp_internal(DAT_181d701b0);
                FUN_180f58a90(lVar3,DAT_181d6dfe8);
                if ((this.sourceHero != null) &&
                   (lVar5 = this.sourceHero.targetHero) != null) {
                  local_res18[0] = *(uint32 *)(lVar5 + 88);
                  uVar4 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
                  if (lVar3 != null) {
                    FUN_181827900(lVar3,uVar4,DAT_181d6e0e8);
                    FUN_181827900(lVar3,0,DAT_181d6e0e8);
                    local_res20[0] = 0xffffffff;
                    uVar4 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
                    FUN_181827900(lVar3,uVar4,DAT_181d6e0e8);
                    local_28 = 0xffffffff;
                    uVar4 = il2cpp_value_box(DAT_181d5b2f8,&local_28);
                    FUN_181827900(lVar3,uVar4,DAT_181d6e0e8);
                    local_24 = 0xffffffff;
                    uVar4 = il2cpp_value_box(DAT_181d5b2f8,&local_24);
                    FUN_181827900(lVar3,uVar4,DAT_181d6e0e8);
                    local_20[0] = 9;
                    uVar4 = il2cpp_value_box(DAT_181d5b2f8,local_20);
                    FUN_181827900(lVar3,uVar4,DAT_181d6e0e8);
                    lVar5 = FUN_18046c440(0);
                    if (lVar5 != null) {
                      uVar4 = Component.get_gameObject(lVar5,0);
                      if (lVar2 != null) {
                        ChooseController.ShowChoosePanel(lVar2,0,lVar3,uVar4,"AIStudyFightSkillFocusChoosen",0,0,0,0,0);
                        goto LAB_180a08457;
                      }
                    }
                  }
                }
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if (iVar1 == 2) {
                lVar2 = FUN_18046c440(0);
                if (lVar2 == null) throw; // [null/range check failed]
                PlotController.AIStudyLivingSkillFocusChoose(lVar2,0);
              }
              else if (iVar1 == 3) {
                lVar2 = FUN_18046c440(0);
                if (lVar2 == null) throw; // [null/range check failed]
                PlotController.AICollectResourceFocusChoose(lVar2,0);
              }
              else if (iVar1 == 4) {
                if (*pStatics_ede0 == 0) throw; // [null/range check failed]
                QuickTravelUIController.ShowQuickTravelUI(*pStatics_ede0,4);
              }
              else if (iVar1 == 5) {
                if (*pStatics_ede0 == 0) throw; // [null/range check failed]
                QuickTravelUIController.ShowQuickTravelUI(*pStatics_ede0,5);
              }
        LAB_180a08457:
              plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
              plVar7 = (int64 *)0;
              if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181d8a228)) {
                plVar7 = plVar6;
              }
              NGUITools.PlaySound(plVar7,0);
              return;
            }
          }
        }
    }

    // Token : 0x60009FA
    // RVA   : 0xA08BC0   Offset: 0xA073C0   Length: 0x7F
    public void SetFocus(int focusID)
    {
        long lVar1;
        if ((((this.sourceHero != null) &&
             (lVar1 = this.sourceHero.targetHero) != null) &&
            (lVar1 = *(int64 *)(lVar1 + 80)) != null) &&
           (lVar1 = *(int64 *)(lVar1 + 16)) != null) {
          lVar1 = FUN_1817cc3c0(lVar1,this.AISettingID,DAT_181d8d540);
          if (lVar1 != null) {
            *(uint32 *)(lVar1 + 20) = focusID;
            AISettingTabController.Refresh(this,0);
            return;
          }
        }
    }

    // Token : 0x60009FB
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
