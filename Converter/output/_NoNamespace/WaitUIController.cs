// ============================================================
// Type  : WaitUIController
// Token : 0x20003A8
// ============================================================

public class WaitUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001CD1
    public GameObject waitUIPanel;

    // Token: 0x4001CD2
    public Text waitTimeText;

    // Token: 0x4001CD3
    public Slider waitTimeSlider;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60022E8
    // RVA   : 0x9DE700   Offset: 0x9DCF00   Length: 0x1F3
    public void ShowWaitUI()
    {
        long lVar1;
        ulong uVar4;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        if (this.waitUIPanel != null) {
          GameObject.SetActive(this.waitUIPanel,1,0);
          if (this.waitUIPanel != null) {
            lVar1 = GameObject.get_transform(this.waitUIPanel,0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"BlackBack",0);
              if (lVar1 != null) {
                plVar2 = (int64 *)Component.GetComponent(lVar1,DAT_181d6bc40);
                puVar3 = (uint32 *)FUN_180d904c0(&local_18,0);
                if (plVar2 != (int64 *)0) {
                  local_18 = *puVar3;
                  uStack_14 = puVar3[1];
                  uStack_10 = puVar3[2];
                  uStack_c = puVar3[3];
                  (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_18,*(uint64 *)(*plVar2 + 0x2b0));
                  if (this.waitUIPanel != null) {
                    lVar1 = GameObject.get_transform(this.waitUIPanel,0);
                    if (lVar1 != null) {
                      lVar1 = Transform.Find(lVar1,"BlackBack",0);
                      if (lVar1 != null) {
                        uVar4 = Component.GetComponent(lVar1,DAT_181d6bc40);
                        DOTweenModuleUI.DOFade(uVar4,0x3f000000,0x3e800000,0);
                        if (this.waitUIPanel != null) {
                          lVar1 = GameObject.get_transform(this.waitUIPanel,0);
                          if (lVar1 != null) {
                            lVar1 = Transform.Find(lVar1,"WaitUIRoot",0);
                            if (lVar1 != null) {
                              uStack_14 = 0x3f800000;
                              local_18 = 0;
                              uStack_10 = 0x3f800000;
                              Transform.set_localScale(lVar1,&local_18,0);
                              if (this.waitUIPanel != null) {
                                lVar1 = GameObject.get_transform(this.waitUIPanel,0);
                                if (lVar1 != null) {
                                  uVar4 = Transform.Find(lVar1,"WaitUIRoot",0);
                                  ShortcutExtensions.DOScale(uVar4,0x3f800000,0x3e800000,0);
                                  WaitUIController.RefreshWaitUI(this,0);
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

    // Token : 0x60022E9
    // RVA   : 0x9DED30   Offset: 0x9DD530   Length: 0x174
    public void UnshowWaitUI()
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        uint local_18;
        uint local_14;
        uint local_10;
        if (this.waitUIPanel != null) {
          lVar1 = GameObject.get_transform(this.waitUIPanel,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"BlackBack",0);
            if (lVar1 != null) {
              uVar2 = Component.GetComponent(lVar1,DAT_181d6bc40);
              DOTweenModuleUI.DOFade(uVar2,0,0x3e800000,0);
              if (this.waitUIPanel != null) {
                lVar1 = GameObject.get_transform(this.waitUIPanel,0);
                if (lVar1 != null) {
                  uVar2 = Transform.Find(lVar1,"WaitUIRoot",0);
                  local_18 = 0;
                  local_14 = 0x3f800000;
                  local_10 = 0x3f800000;
                  uVar2 = ShortcutExtensions.DOScale(uVar2,&local_18,0x3e800000,0);
                  uVar3 = new OnTooltipCB(this,DAT_181d4e6c0,0);
                  TweenSettingsExtensions.OnComplete(uVar2,uVar3,DAT_181d96ee8);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x60022EA
    // RVA   : 0x9DE900   Offset: 0x9DD100   Length: 0xF9
    public void SliderValueChanged()
    {
        long lVar1;
        ulong uVar2;
        WaitUIController.RefreshWaitUI(this,0);
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
        if (lVar1 != null) {
          uVar2 = *(uint64 *)(lVar1 + 0x1f0);
          NGUITools.PlaySound(uVar2,0x3e4ccccd,0);
          return;
        }
    }

    // Token : 0x60022EB
    // RVA   : 0x9DE640   Offset: 0x9DCE40   Length: 0xB8
    public void RefreshWaitUI()
    {
        ulong uVar2;
        ulong uVar3;
        float fVar4;
        plVar1 = this.waitTimeSlider;
        uVar2 = this.waitTimeText;
        if (plVar1 != (int64 *)0) {
          fVar4 = (float)(**(code **)(*plVar1 + 0x418))(plVar1,*(uint64 *)(*plVar1 + 0x420));
          uVar3 = GlobalData.GetNumText((int)fVar4,0);
          uVar3 = String.Concat(uVar3,"天",0);
          LTLocalization.SetText(uVar2,uVar3,0);
          return;
        }
    }

    // Token : 0x60022EC
    // RVA   : 0x9DEA00   Offset: 0x9DD200   Length: 0x32A
    public void SureButtonClicked()
    {
        long lVar2;
        int iVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        int iVar7;
        float fVar8;
        uint local_28;
        uint local_24;
        uint local_20;
        if (this.waitUIPanel != null) {
          lVar4 = GameObject.get_transform(this.waitUIPanel,0);
          if (lVar4 != null) {
            lVar4 = Transform.Find(lVar4,"BlackBack",0);
            if (lVar4 != null) {
              uVar5 = Component.GetComponent(lVar4,DAT_181d6bc40);
              DOTweenModuleUI.DOFade(uVar5,0,0x3e800000,0);
              if (this.waitUIPanel != null) {
                lVar4 = GameObject.get_transform(this.waitUIPanel,0);
                if (lVar4 != null) {
                  uVar5 = Transform.Find(lVar4,"WaitUIRoot",0);
                  local_28 = 0;
                  local_24 = 0x3f800000;
                  local_20 = 0x3f800000;
                  uVar5 = ShortcutExtensions.DOScale(uVar5,&local_28,0x3e800000,0);
                  uVar6 = new OnTooltipCB(this,DAT_181d4e6c0,0);
                  TweenSettingsExtensions.OnComplete(uVar5,uVar6,DAT_181d96ee8);
                  plVar1 = this.waitTimeSlider;
                  lVar4 = *(int64 *)(*(int64 *)(DAT_181d90b30 + 184) + 8);
                  if (plVar1 != (int64 *)0) {
                    fVar8 = (float)(**(code **)(*plVar1 + 0x418))(plVar1,*(uint64 *)(*plVar1 + 0x420))
                    ;
                    lVar2 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 8);
                    if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 16)) != null) {
                      iVar3 = PlayerPrefDictionary.GetInt(lVar2,"TestMode",0);
                      uVar5 = "等待";
                      iVar7 = 100;
                      if (iVar3 != 1) {
                        iVar7 = 1;
                      }
                      if (lVar4 != null) {
                        WorkingUIController.StartWorking
                                  (lVar4,uVar5,(int)fVar8 * iVar7,0,"","",
                                   "",0);
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

    // Token : 0x60022ED
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x60022EE
    // RVA   : 0x790570   Offset: 0x78ED70   Length: 0x20
    private void <UnshowWaitUI>b__4_0()
    {
        if (this.waitUIPanel != null) {
          GameObject.SetActive(this.waitUIPanel,0,0);
          return;
        }
    }

}
