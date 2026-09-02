// ============================================================
// Type  : StaffMenuController
// Token : 0x2000367
// ============================================================

public class StaffMenuController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B0C
    public GameObject staffMenu;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002134
    // RVA   : 0xC6F630   Offset: 0xC6DE30   Length: 0x342
    public void ShowStaffMenu()
    {
        long lVar2;
        ulong uVar5;
        ulong local_38;
        ulong uStack_30;
        byte[] local_28 = new byte[32];
        if (this.staffMenu != null) {
          GameObject.SetActive(this.staffMenu,1,0);
          plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/Paper",0);
          plVar3 = (int64 *)0;
          if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181d8a228)) {
            plVar3 = plVar1;
          }
          NGUITools.PlaySound(plVar3,0);
          if (this.staffMenu != null) {
            lVar2 = GameObject.get_transform(this.staffMenu,0);
            if (lVar2 != null) {
              lVar2 = Transform.Find(lVar2,"BlackBackground",0);
              if (lVar2 != null) {
                plVar1 = (int64 *)Component.GetComponent(lVar2,DAT_181d6bc40);
                if (this.staffMenu != null) {
                  lVar2 = GameObject.get_transform(this.staffMenu,0);
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
                          if (this.staffMenu != null) {
                            lVar2 = GameObject.get_transform(this.staffMenu,0);
                            if (lVar2 != null) {
                              lVar2 = Transform.Find(lVar2,"BlackBackground",0);
                              if (lVar2 != null) {
                                uVar5 = Component.GetComponent(lVar2,DAT_181d6bc40);
                                uVar5 = DOTweenModuleUI.DOFade(uVar5,0x3f000000,0x3e800000,0);
                                TweenSettingsExtensions.SetUpdate(uVar5,1,DAT_181d98958);
                                if (this.staffMenu != null) {
                                  lVar2 = GameObject.get_transform(this.staffMenu,0);
                                  if (lVar2 != null) {
                                    lVar2 = Transform.Find(lVar2,"StaffRoot",0);
                                    if (lVar2 != null) {
                                      local_38 = 0x3f80000000000000;
                                      uStack_30 = CONCAT44(uStack_30._4_4_,0x3f800000);
                                      Transform.set_localScale(lVar2,&local_38,0);
                                      if (this.staffMenu != null) {
                                        lVar2 = GameObject.get_transform(this.staffMenu,0)
                                        ;
                                        if (lVar2 != null) {
                                          uVar5 = Transform.Find(lVar2,"StaffRoot",0);
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

    // Token : 0x6002135
    // RVA   : 0xC6F980   Offset: 0xC6E180   Length: 0x220
    public void UnshowStaffMenu()
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
        if (this.staffMenu != null) {
          lVar2 = GameObject.get_transform(this.staffMenu,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"BlackBackground",0);
            if (lVar2 != null) {
              uVar3 = Component.GetComponent(lVar2,DAT_181d6bc40);
              uVar3 = DOTweenModuleUI.DOFade(uVar3,0,0x3e4ccccd,0);
              TweenSettingsExtensions.SetUpdate(uVar3,1,DAT_181d98958);
              if (this.staffMenu != null) {
                lVar2 = GameObject.get_transform(this.staffMenu,0);
                if (lVar2 != null) {
                  uVar3 = Transform.Find(lVar2,"StaffRoot",0);
                  local_18 = 0;
                  local_14 = 0x3f800000;
                  local_10 = 0x3f800000;
                  uVar3 = ShortcutExtensions.DOScale(uVar3,&local_18,0x3e4ccccd,0);
                  uVar3 = TweenSettingsExtensions.SetUpdate(uVar3,1,DAT_181d98af0);
                  uVar4 = new OnTooltipCB(this,DAT_181d889e8,0);
                  TweenSettingsExtensions.OnComplete(uVar3,uVar4,DAT_181d96ee8);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6002136
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6002137
    // RVA   : 0x790570   Offset: 0x78ED70   Length: 0x20
    private void <UnshowStaffMenu>b__2_0()
    {
        if (this.staffMenu != null) {
          GameObject.SetActive(this.staffMenu,0,0);
          return;
        }
    }

}
