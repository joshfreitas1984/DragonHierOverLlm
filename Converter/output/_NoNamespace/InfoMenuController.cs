// ============================================================
// Type  : InfoMenuController
// Token : 0x20002E1
// ============================================================

public class InfoMenuController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400173C
    public GameObject infoMenu;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600181C
    // RVA   : 0xB6E730   Offset: 0xB6CF30   Length: 0x342
    public void ShowInfoMenu()
    {
        long lVar2;
        ulong uVar5;
        ulong local_38;
        ulong uStack_30;
        byte[] local_28 = new byte[32];
        if (this.infoMenu != null) {
          GameObject.SetActive(this.infoMenu,1,0);
          plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/Paper",0);
          plVar3 = (int64 *)0;
          if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181d8a228)) {
            plVar3 = plVar1;
          }
          NGUITools.PlaySound(plVar3,0);
          if (this.infoMenu != null) {
            lVar2 = GameObject.get_transform(this.infoMenu,0);
            if (lVar2 != null) {
              lVar2 = Transform.Find(lVar2,"BlackBackground",0);
              if (lVar2 != null) {
                plVar1 = (int64 *)Component.GetComponent(lVar2,DAT_181d6bc40);
                if (this.infoMenu != null) {
                  lVar2 = GameObject.get_transform(this.infoMenu,0);
                  if (lVar2 != null) {
                    lVar2 = Transform.Find(lVar2,"BlackBackground",0);
                    if (lVar2 != null) {
                      plVar3 = (int64 *)Component.GetComponent(lVar2,DAT_181d6bc40);
                      if (plVar3 != (int64 *)0) {
                        puVar4 = (uint64 *)
                                 (**(code **)(*plVar3 + 0x298))
                                           (&local_38,plVar3,*(uint64 *)(*plVar3 + 0x2a0));
                        local_38 = *puVar4;
                        uStack_30 = puVar4[1];
                        puVar4 = (uint64 *)GlobalData.SetColorAlpha(local_28,&local_38,0,0);
                        if (plVar1 != (int64 *)0) {
                          local_38 = *puVar4;
                          uStack_30 = puVar4[1];
                          (**(code **)(*plVar1 + 0x2a8))
                                    (plVar1,&local_38,*(uint64 *)(*plVar1 + 0x2b0));
                          if (this.infoMenu != null) {
                            lVar2 = GameObject.get_transform(this.infoMenu,0);
                            if (lVar2 != null) {
                              lVar2 = Transform.Find(lVar2,"BlackBackground",0);
                              if (lVar2 != null) {
                                uVar5 = Component.GetComponent(lVar2,DAT_181d6bc40);
                                uVar5 = DOTweenModuleUI.DOFade(uVar5,0x3f000000,0x3e800000,0);
                                TweenSettingsExtensions.SetUpdate(uVar5,1,DAT_181d98958);
                                if (this.infoMenu != null) {
                                  lVar2 = GameObject.get_transform(this.infoMenu,0);
                                  if (lVar2 != null) {
                                    lVar2 = Transform.Find(lVar2,"InfoRoot",0);
                                    if (lVar2 != null) {
                                      local_38 = 0x3f80000000000000;
                                      uStack_30 = CONCAT44(uStack_30._4_4_,0x3f800000);
                                      Transform.set_localScale(lVar2,&local_38,0);
                                      if (this.infoMenu != null) {
                                        lVar2 = GameObject.get_transform(this.infoMenu,0)
                                        ;
                                        if (lVar2 != null) {
                                          uVar5 = Transform.Find(lVar2,"InfoRoot",0);
                                          uVar5 = ShortcutExtensions.DOScale
                                                            (uVar5,0x3f800000,0x3e800000,0);
                                          TweenSettingsExtensions.SetUpdate(uVar5,1,DAT_181d98af0);
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

    // Token : 0x600181D
    // RVA   : 0xB6EA80   Offset: 0xB6D280   Length: 0x220
    public void UnshowInfoMenu()
    {
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        uint local_18;
        uint local_14;
        uint local_10;
        plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/PaperQuick",0);
        plVar5 = (int64 *)0;
        if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181d8a228)) {
          plVar5 = plVar1;
        }
        NGUITools.PlaySound(plVar5,0);
        if (this.infoMenu != null) {
          lVar2 = GameObject.get_transform(this.infoMenu,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"BlackBackground",0);
            if (lVar2 != null) {
              uVar3 = Component.GetComponent(lVar2,DAT_181d6bc40);
              uVar3 = DOTweenModuleUI.DOFade(uVar3,0,0x3e4ccccd,0);
              TweenSettingsExtensions.SetUpdate(uVar3,1,DAT_181d98958);
              if (this.infoMenu != null) {
                lVar2 = GameObject.get_transform(this.infoMenu,0);
                if (lVar2 != null) {
                  uVar3 = Transform.Find(lVar2,"InfoRoot",0);
                  local_18 = 0;
                  local_14 = 0x3f800000;
                  local_10 = 0x3f800000;
                  uVar3 = ShortcutExtensions.DOScale(uVar3,&local_18,0x3e4ccccd,0);
                  uVar3 = TweenSettingsExtensions.SetUpdate(uVar3,1,DAT_181d98af0);
                  uVar4 = new OnTooltipCB(this,DAT_181d53008,0);
                  TweenSettingsExtensions.OnComplete(uVar3,uVar4,DAT_181d96ee8);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x600181E
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x600181F
    // RVA   : 0x790570   Offset: 0x78ED70   Length: 0x20
    private void <UnshowInfoMenu>b__2_0()
    {
        if (this.infoMenu != null) {
          GameObject.SetActive(this.infoMenu,0,0);
          return;
        }
    }

}
