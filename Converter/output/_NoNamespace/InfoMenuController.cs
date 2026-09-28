// ============================================================
// Type  : InfoMenuController
// Token : 0x20002E7
// ============================================================

public class InfoMenuController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40017F0
    public GameObject infoMenu;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001860
    // RVA   : 0xC98530   Offset: 0xC97930   Length: 0x342
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
          if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181daf348)) {
            plVar3 = plVar1;
          }
          NGUITools.PlaySound(plVar3,0);
          if (this.infoMenu != null) {
            lVar2 = GameObject.get_transform(this.infoMenu,0);
            if (lVar2 != null) {
              lVar2 = Transform.Find(lVar2,"BlackBackground",0);
              if (lVar2 != null) {
                plVar1 = (int64 *)Component.GetComponent(lVar2,DAT_181d94460);
                if (this.infoMenu != null) {
                  lVar2 = GameObject.get_transform(this.infoMenu,0);
                  if (lVar2 != null) {
                    lVar2 = Transform.Find(lVar2,"BlackBackground",0);
                    if (lVar2 != null) {
                      plVar3 = (int64 *)Component.GetComponent(lVar2,DAT_181d94460);
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
                                uVar5 = Component.GetComponent(lVar2,DAT_181d94460);
                                uVar5 = DOTweenModuleUI.DOFade(uVar5,0x3f000000,0x3e800000,0);
                                TweenSettingsExtensions.SetUpdate(uVar5,1,DAT_181dc1c20);
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
                                          TweenSettingsExtensions.SetUpdate(uVar5,1,DAT_181dc1db0);
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

    // Token : 0x6001861
    // RVA   : 0xC98880   Offset: 0xC97C80   Length: 0x220
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
        if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181daf348)) {
          plVar5 = plVar1;
        }
        NGUITools.PlaySound(plVar5,0);
        if (this.infoMenu != null) {
          lVar2 = GameObject.get_transform(this.infoMenu,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"BlackBackground",0);
            if (lVar2 != null) {
              uVar3 = Component.GetComponent(lVar2,DAT_181d94460);
              uVar3 = DOTweenModuleUI.DOFade(uVar3,0,0x3e4ccccd,0);
              TweenSettingsExtensions.SetUpdate(uVar3,1,DAT_181dc1c20);
              if (this.infoMenu != null) {
                lVar2 = GameObject.get_transform(this.infoMenu,0);
                if (lVar2 != null) {
                  uVar3 = Transform.Find(lVar2,"InfoRoot",0);
                  local_18 = 0;
                  local_14 = 0x3f800000;
                  local_10 = 0x3f800000;
                  uVar3 = ShortcutExtensions.DOScale(uVar3,&local_18,0x3e4ccccd,0);
                  uVar3 = TweenSettingsExtensions.SetUpdate(uVar3,1,DAT_181dc1db0);
                  uVar4 = new OnTooltipCB(this,DAT_181d7bbf8,0);
                  TweenSettingsExtensions.OnComplete(uVar3,uVar4,DAT_181dc01d0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6001862
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6001863
    // RVA   : 0x78D070   Offset: 0x78C470   Length: 0x20
    private void <UnshowInfoMenu>b__2_0()
    {
        if (this.infoMenu != null) {
          GameObject.SetActive(this.infoMenu,0,0);
          return;
        }
    }

}
