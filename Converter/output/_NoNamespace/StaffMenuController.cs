// ============================================================
// Type  : StaffMenuController
// Token : 0x200037B
// ============================================================

public class StaffMenuController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001CA0
    public GameObject staffMenu;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600225F
    // RVA   : 0xA08480   Offset: 0xA07280   Length: 0x342
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
          if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181e8f4a0)) {
            plVar3 = plVar1;
          }
          NGUITools.PlaySound(plVar3,0);
          if (this.staffMenu != null) {
            lVar2 = GameObject.get_transform(this.staffMenu,0);
            if (lVar2 != null) {
              lVar2 = Transform.Find(lVar2,"BlackBackground",0);
              if (lVar2 != null) {
                plVar1 = (int64 *)Component.GetComponent(lVar2,DAT_181e777b8);
                if (this.staffMenu != null) {
                  lVar2 = GameObject.get_transform(this.staffMenu,0);
                  if (lVar2 != null) {
                    lVar2 = Transform.Find(lVar2,"BlackBackground",0);
                    if (lVar2 != null) {
                      plVar3 = (int64 *)Component.GetComponent(lVar2,DAT_181e777b8);
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
                                uVar5 = Component.GetComponent(lVar2,DAT_181e777b8);
                                uVar5 = DOTweenModuleUI.DOFade(uVar5,0x3f000000,0x3e800000,0);
                                TweenSettingsExtensions.SetUpdate(uVar5,1,DAT_181ea5848);
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
                                          TweenSettingsExtensions.SetUpdate(uVar5,1,DAT_181ea59e0);
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

    // Token : 0x6002260
    // RVA   : 0xA087D0   Offset: 0xA075D0   Length: 0x220
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
        if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181e8f4a0)) {
          plVar5 = plVar1;
        }
        NGUITools.PlaySound(plVar5,0);
        if (this.staffMenu != null) {
          lVar2 = GameObject.get_transform(this.staffMenu,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"BlackBackground",0);
            if (lVar2 != null) {
              uVar3 = Component.GetComponent(lVar2,DAT_181e777b8);
              uVar3 = DOTweenModuleUI.DOFade(uVar3,0,0x3e4ccccd,0);
              TweenSettingsExtensions.SetUpdate(uVar3,1,DAT_181ea5848);
              if (this.staffMenu != null) {
                lVar2 = GameObject.get_transform(this.staffMenu,0);
                if (lVar2 != null) {
                  uVar3 = Transform.Find(lVar2,"StaffRoot",0);
                  local_18 = 0;
                  local_14 = 0x3f800000;
                  local_10 = 0x3f800000;
                  uVar3 = ShortcutExtensions.DOScale(uVar3,&local_18,0x3e4ccccd,0);
                  uVar3 = TweenSettingsExtensions.SetUpdate(uVar3,1,DAT_181ea59e0);
                  uVar4 = new OnTooltipCB(this,DAT_181e95418,0);
                  TweenSettingsExtensions.OnComplete(uVar3,uVar4,DAT_181ea3dc0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6002261
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

    // Token : 0x6002262
    // RVA   : 0x52B140   Offset: 0x529F40   Length: 0x20
    private void <UnshowStaffMenu>b__2_0()
    {
        if (this.staffMenu != null) {
          GameObject.SetActive(this.staffMenu,0,0);
          return;
        }
    }

}
