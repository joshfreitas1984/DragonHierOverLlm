// ============================================================
// Type  : WaitUIController
// Token : 0x20003AF
// ============================================================

public class WaitUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001DD6
    public GameObject waitUIPanel;

    // Token: 0x4001DD7
    public Text waitTimeText;

    // Token: 0x4001DD8
    public Slider waitTimeSlider;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600236A
    // RVA   : 0xC126F0   Offset: 0xC11AF0   Length: 0x1F3
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
                plVar2 = (int64 *)Component.GetComponent(lVar1,DAT_181d94460);
                puVar3 = (uint32 *)FUN_180d98fe0(&local_18,0);
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
                        uVar4 = Component.GetComponent(lVar1,DAT_181d94460);
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

    // Token : 0x600236B
    // RVA   : 0xC12CD0   Offset: 0xC120D0   Length: 0x174
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
              uVar2 = Component.GetComponent(lVar1,DAT_181d94460);
              DOTweenModuleUI.DOFade(uVar2,0,0x3e800000,0);
              if (this.waitUIPanel != null) {
                lVar1 = GameObject.get_transform(this.waitUIPanel,0);
                if (lVar1 != null) {
                  uVar2 = Transform.Find(lVar1,"WaitUIRoot",0);
                  local_18 = 0;
                  local_14 = 0x3f800000;
                  local_10 = 0x3f800000;
                  uVar2 = ShortcutExtensions.DOScale(uVar2,&local_18,0x3e800000,0);
                  uVar3 = new OnTooltipCB(this,DAT_181d77568,0);
                  TweenSettingsExtensions.OnComplete(uVar2,uVar3,DAT_181dc01d0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x600236C
    // RVA   : 0xC128F0   Offset: 0xC11CF0   Length: 0xF9
    public void SliderValueChanged()
    {
        long lVar1;
        ulong uVar2;
        WaitUIController.RefreshWaitUI(this,0);
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
        if (lVar1 != null) {
          uVar2 = *(uint64 *)(lVar1 + 0x1f0);
          NGUITools.PlaySound(uVar2,0x3e4ccccd,0);
          return;
        }
    }

    // Token : 0x600236D
    // RVA   : 0xC12600   Offset: 0xC11A00   Length: 0xE8
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

    // Token : 0x600236E
    // RVA   : 0xC129F0   Offset: 0xC11DF0   Length: 0x2DD
    public void SureButtonClicked()
    {
        long lVar2;
        int iVar3;
        int iVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        float fVar8;
        uint local_28;
        uint local_24;
        uint local_20;
        if (this.waitUIPanel != null) {
          lVar5 = GameObject.get_transform(this.waitUIPanel,0);
          if (lVar5 != null) {
            lVar5 = Transform.Find(lVar5,"BlackBack",0);
            if (lVar5 != null) {
              uVar6 = Component.GetComponent(lVar5,DAT_181d94460);
              DOTweenModuleUI.DOFade(uVar6,0,0x3e800000,0);
              if (this.waitUIPanel != null) {
                lVar5 = GameObject.get_transform(this.waitUIPanel,0);
                if (lVar5 != null) {
                  uVar6 = Transform.Find(lVar5,"WaitUIRoot",0);
                  local_28 = 0;
                  local_24 = 0x3f800000;
                  local_20 = 0x3f800000;
                  uVar6 = ShortcutExtensions.DOScale(uVar6,&local_28,0x3e800000,0);
                  uVar7 = new OnTooltipCB(this,DAT_181d77568,0);
                  TweenSettingsExtensions.OnComplete(uVar6,uVar7,DAT_181dc01d0);
                  plVar1 = this.waitTimeSlider;
                  lVar5 = *(int64 *)(*(int64 *)(DAT_181db5de8 + 184) + 8);
                  if (plVar1 != (int64 *)0) {
                    fVar8 = (float)(**(code **)(*plVar1 + 0x418))(plVar1,*(uint64 *)(*plVar1 + 0x420))
                    ;
                    lVar2 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 8);
                    if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 16)) != null) {
                      iVar3 = PlayerPrefDictionary.GetInt(lVar2,"TestMode",0);
                      iVar4 = 100;
                      if (iVar3 != 1) {
                        iVar4 = 1;
                      }
                      if (lVar5 != null) {
                        WorkingUIController.StartWorking(lVar5,"等待",(int)fVar8 * iVar4,0,0);
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

    // Token : 0x600236F
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6002370
    // RVA   : 0x78D070   Offset: 0x78C470   Length: 0x20
    private void <UnshowWaitUI>b__4_0()
    {
        if (this.waitUIPanel != null) {
          GameObject.SetActive(this.waitUIPanel,0,0);
          return;
        }
    }

}
