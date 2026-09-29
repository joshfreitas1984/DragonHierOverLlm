// ============================================================
// Type  : SureMenu
// Token : 0x2000397
// ============================================================

public class SureMenu
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001D5E
    public GameObject sureMenu;

    // Token: 0x4001D5F
    public Image blackBackground;

    // Token: 0x4001D60
    public bool pause;

    // Token: 0x4001D61
    public string fucName;

    // Token: 0x4001D62
    public string fucParam;

    // Token: 0x4001D63
    public string cancelFucName;

    // Token: 0x4001D64
    public string cancelFucParam;

    // Token: 0x4001D65
    public GameObject objToSendMessage;

    // Token: 0x4001D66
    private static SureMenu _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60022CC
    // RVA   : 0xA953D0   Offset: 0xA947D0   Length: 0x36
    public static SureMenu get_Instance()
    {
        return **(uint64 **)(DAT_181da8728 + 184);
    }

    // Token : 0x60022CD
    // RVA   : 0xA94090   Offset: 0xA93490   Length: 0x99
    private void Awake()
    {
        ulong uVar1;
        bool cVar3;
        uVar1 = **(uint64 **)(DAT_181da8728 + 184);
        cVar3 = Object.op_Equality(uVar1,0,0);
        if (cVar3) {
          puVar2 = *(uint64 **)(DAT_181da8728 + 184);
          *puVar2 = this;
          il2cpp_internal(puVar2,this);
        }
    }

    // Token : 0x60022CE
    // RVA   : 0xA951A0   Offset: 0xA945A0   Length: 0x22B
    private void Update()
    {
        ulong uVar1;
        ulong uVar2;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        if (this.sureMenu == null) goto LAB_180a953c6;
        cVar3 = GameObject.get_activeSelf(this.sureMenu,0);
        if (cVar3) {
          cVar3 = GlobalData.GetKeyDown(32);
          if (!cVar3) {
            cVar3 = GlobalData.GetKeyDown(27);
            if (!cVar3) {
              return;
            }
            if ((this.sureMenu == null) ||
               (lVar4 = GameObject.get_transform(this.sureMenu,0)) == null)
            goto LAB_180a953c6;
            lVar4 = Transform.Find(lVar4,"ButtonGrid",0);
            uVar1 = "Cancel";
          }
          else {
            if ((this.sureMenu == null) ||
               (lVar4 = GameObject.get_transform(this.sureMenu,0)) == null)
            goto LAB_180a953c6;
            lVar4 = Transform.Find(lVar4,"ButtonGrid",0);
            uVar1 = "Sure";
          }
          if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,uVar1,0)) == null) {
        LAB_180a953c6:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar1 = Component.get_gameObject(lVar4,0);
          uVar2 = EventSystem.get_current(0);
          uVar5 = new PointerEventData(uVar2,0);
          uVar2 = FUN_1807e6470(0);
          ExecuteEvents.Execute(uVar1,uVar5,uVar2,DAT_181db8e30);
        }
    }

    // Token : 0x60022CF
    // RVA   : 0xA94E30   Offset: 0xA94230   Length: 0xE3
    public void SetExtraButton(bool active)
    {
        long lVar1;
        if (this.sureMenu != null) {
          lVar1 = GameObject.get_transform(this.sureMenu,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"WishListButton",0);
            if (lVar1 != null) {
              lVar1 = Component.get_gameObject(lVar1,0);
              if (lVar1 != null) {
                GameObject.SetActive(lVar1,active,0);
                if (this.sureMenu != null) {
                  lVar1 = GameObject.get_transform(this.sureMenu,0);
                  if (lVar1 != null) {
                    lVar1 = Transform.Find(lVar1,"QuestionButton",0);
                    if (lVar1 != null) {
                      lVar1 = Component.get_gameObject(lVar1,0);
                      if (lVar1 != null) {
                        GameObject.SetActive(lVar1,active,0);
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

    // Token : 0x60022D0
    // RVA   : 0xA94CF0   Offset: 0xA940F0   Length: 0x13B
    public void SetButtonState(bool state)
    {
        long lVar1;
        if (this.sureMenu != null) {
          lVar1 = GameObject.get_transform(this.sureMenu,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"ButtonGrid",0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"Sure",0);
              if (lVar1 != null) {
                lVar1 = Component.GetComponent(lVar1,DAT_181d93778);
                if (lVar1 != null) {
                  Selectable.set_interactable(lVar1,state,0);
                  if (this.sureMenu != null) {
                    lVar1 = GameObject.get_transform(this.sureMenu,0);
                    if (lVar1 != null) {
                      lVar1 = Transform.Find(lVar1,"ButtonGrid",0);
                      if (lVar1 != null) {
                        lVar1 = Transform.Find(lVar1,"Cancel",0);
                        if (lVar1 != null) {
                          lVar1 = Component.GetComponent(lVar1,DAT_181d93778);
                          if (lVar1 != null) {
                            Selectable.set_interactable(lVar1,state,0);
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

    // Token : 0x60022D1
    // RVA   : 0xA94F20   Offset: 0xA94320   Length: 0x116
    public void SureButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181dabea0 + 184);
        long lVar1;
        if (this.sureMenu != null) {
          lVar1 = GameObject.get_transform(this.sureMenu,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"ButtonGrid",0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"Sure",0);
              if (lVar1 != null) {
                lVar1 = Component.GetComponent(lVar1,DAT_181d93778);
                if (lVar1 != null) {
                  if (*(char *)(lVar1 + 208) == false) {
                    return;
                  }
                  SureMenu.HideSelf(this,0);
                  if (this.pause) {
                    if (*pStatics == 0) throw; // [null/range check failed]
                    *(uint8 *)(*pStatics + 24) = 0;
                  }
                  SureMenu.TryCallFuc
                            (this,this.fucName,this.fucParam,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x60022D2
    // RVA   : 0xA949F0   Offset: 0xA93DF0   Length: 0x116
    public void CancelButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181dabea0 + 184);
        long lVar1;
        if (this.sureMenu != null) {
          lVar1 = GameObject.get_transform(this.sureMenu,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"ButtonGrid",0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"Cancel",0);
              if (lVar1 != null) {
                lVar1 = Component.GetComponent(lVar1,DAT_181d93778);
                if (lVar1 != null) {
                  if (*(char *)(lVar1 + 208) == false) {
                    return;
                  }
                  SureMenu.HideSelf(this,0);
                  if (this.pause) {
                    if (*pStatics == 0) throw; // [null/range check failed]
                    *(uint8 *)(*pStatics + 24) = 0;
                  }
                  SureMenu.TryCallFuc
                            (this,this.cancelFucName,this.cancelFucParam,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x60022D3
    // RVA   : 0xA95040   Offset: 0xA94440   Length: 0x15A
    public void TryCallFuc(string targetFucName, string targetFucParam)
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        if (targetFucName == null) {
          return;
        }
        cVar1 = String.op_Inequality(targetFucName,"",0);
        if (!cVar1) {
          return;
        }
        uVar3 = this.objToSendMessage;
        cVar1 = Object.op_Equality(uVar3,0,0);
        if (cVar1) {
          lVar2 = FUN_18046c0a0(0);
          if (lVar2 == null) throw; // [null/range check failed]
          uVar3 = Component.get_gameObject(lVar2,0);
          this.objToSendMessage = uVar3;
        }
        if ((targetFucParam == null) || (cVar1 = String.op_Inequality(targetFucParam,"",0), !cVar1)) {
          if (this.objToSendMessage != null) {
            GameObject.SendMessage(this.objToSendMessage,targetFucName,0);
            return;
          }
        }
        else if (this.objToSendMessage != null) {
          GameObject.SendMessage(this.objToSendMessage,targetFucName,targetFucParam,0);
          return;
        }
    }

    // Token : 0x60022D4
    // RVA   : 0xA94B10   Offset: 0xA93F10   Length: 0x1DE
    private void HideSelf()
    {
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        SureMenu.SetButtonState(this,0,0);
        if (this.sureMenu != null) {
          uVar1 = GameObject.get_transform(this.sureMenu,0);
          uVar1 = ShortcutExtensions.DOScale(uVar1,0,0x3e4ccccd,0);
          uVar1 = TweenSettingsExtensions.SetEase(uVar1,8,DAT_181dc1128);
          uVar1 = TweenSettingsExtensions.SetUpdate(uVar1,1,DAT_181dc1f60);
          uVar2 = new OnTooltipCB(this,DAT_181db73d8,0);
          TweenSettingsExtensions.OnComplete(uVar1,uVar2,DAT_181dc0380);
          if (this.blackBackground != null) {
            lVar3 = Component.get_gameObject(this.blackBackground,0);
            if (lVar3 != null) {
              GameObject.SetActive(lVar3,0,0);
              uVar1 = DOTweenModuleUI.DOFade(this.blackBackground,0,0x3e4ccccd,0);
              TweenSettingsExtensions.SetUpdate(uVar1,1,DAT_181dc1dc8);
              plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/Woosh",0);
              plVar5 = (int64 *)0;
              if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181daf360)) {
                plVar5 = plVar4;
              }
              NGUITools.PlaySound(plVar5,0x3f000000,0);
              return;
            }
          }
        }
    }

    // Token : 0x60022D5
    // RVA   : 0xA946D0   Offset: 0xA93AD0   Length: 0x9A
    public void CallSureMenu(string text, string fuc)
    {
        var pStatics = *(int64*)(DAT_181dabea0 + 184);
        void SureMenu.CallSureMenu
                     (int64 this,uint64 text,uint64 fuc,uint64 param_4,
                     uint64 param_5,uint8 param_6,char param_7,uint64 param_8,
                     uint64 param_9)
        {
        uint64 uVar1;
        int64 lVar2;
        int64 *plVar3;
        int64 *plVar4;
        if (param_7) {
          if (*pStatics == 0) throw; // [null/range check failed]
          *(uint8 *)(*pStatics + 24) = 1;
        }
        if (this.sureMenu != null) {
          GameObject.SetActive(this.sureMenu,1,0);
          if (this.sureMenu != null) {
            uVar1 = GameObject.get_transform(this.sureMenu,0);
            uVar1 = ShortcutExtensions.DOScale(uVar1,0x3f800000,0x3e4ccccd,0);
            uVar1 = TweenSettingsExtensions.SetEase(uVar1,8,DAT_181dc1128);
            TweenSettingsExtensions.SetUpdate(uVar1,1,DAT_181dc1f60);
            if (this.blackBackground != null) {
              lVar2 = Component.get_gameObject(this.blackBackground,0);
              if (lVar2 != null) {
                GameObject.SetActive(lVar2,1,0);
                uVar1 = DOTweenModuleUI.DOFade(this.blackBackground,0x3f400000,0x3e4ccccd,0);
                TweenSettingsExtensions.SetUpdate(uVar1,1,DAT_181dc1dc8);
                this.fucName = fuc;
                this.pause = param_7;
                this.fucParam = param_4;
                this.cancelFucName = param_8;
                this.cancelFucParam = param_9;
                this.objToSendMessage = param_5;
                SureMenu.SetButtonState(this,1,0);
                if (this.sureMenu != null) {
                  lVar2 = GameObject.get_transform(this.sureMenu,0);
                  if (lVar2 != null) {
                    lVar2 = Transform.Find(lVar2,"Text",0);
                    if (lVar2 != null) {
                      uVar1 = Component.GetComponent(lVar2,DAT_181d96178);
                      LTLocalization.SetText(uVar1,text,0);
                      if (this.sureMenu != null) {
                        lVar2 = GameObject.get_transform(this.sureMenu,0);
                        if (lVar2 != null) {
                          lVar2 = Transform.Find(lVar2,"ButtonGrid",0);
                          if (lVar2 != null) {
                            lVar2 = Transform.Find(lVar2,"Cancel",0);
                            if (lVar2 != null) {
                              lVar2 = Component.get_gameObject(lVar2,0);
                              if (lVar2 != null) {
                                GameObject.SetActive(lVar2,param_6,0);
                                plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/Woosh",0);
                                plVar4 = (int64 *)0;
                                if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181daf360)) {
                                  plVar4 = plVar3;
                                }
                                NGUITools.PlaySound(plVar4,0x3f000000,0);
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

    // Token : 0x60022D6
    // RVA   : 0xA94860   Offset: 0xA93C60   Length: 0x77
    public void CallSureMenu(string text, string fuc, string param)
    {
        var pStatics = *(int64*)(DAT_181dabea0 + 184);
        void SureMenu.CallSureMenu
                     (int64 this,uint64 text,uint64 fuc,uint64 param,
                     uint64 param_5,uint8 param_6,char param_7,uint64 param_8,
                     uint64 param_9)
        {
        uint64 uVar1;
        int64 lVar2;
        int64 *plVar3;
        int64 *plVar4;
        if (param_7) {
          if (*pStatics == 0) throw; // [null/range check failed]
          *(uint8 *)(*pStatics + 24) = 1;
        }
        if (this.sureMenu != null) {
          GameObject.SetActive(this.sureMenu,1,0);
          if (this.sureMenu != null) {
            uVar1 = GameObject.get_transform(this.sureMenu,0);
            uVar1 = ShortcutExtensions.DOScale(uVar1,0x3f800000,0x3e4ccccd,0);
            uVar1 = TweenSettingsExtensions.SetEase(uVar1,8,DAT_181dc1128);
            TweenSettingsExtensions.SetUpdate(uVar1,1,DAT_181dc1f60);
            if (this.blackBackground != null) {
              lVar2 = Component.get_gameObject(this.blackBackground,0);
              if (lVar2 != null) {
                GameObject.SetActive(lVar2,1,0);
                uVar1 = DOTweenModuleUI.DOFade(this.blackBackground,0x3f400000,0x3e4ccccd,0);
                TweenSettingsExtensions.SetUpdate(uVar1,1,DAT_181dc1dc8);
                this.fucName = fuc;
                this.pause = param_7;
                this.fucParam = param;
                this.cancelFucName = param_8;
                this.cancelFucParam = param_9;
                this.objToSendMessage = param_5;
                SureMenu.SetButtonState(this,1,0);
                if (this.sureMenu != null) {
                  lVar2 = GameObject.get_transform(this.sureMenu,0);
                  if (lVar2 != null) {
                    lVar2 = Transform.Find(lVar2,"Text",0);
                    if (lVar2 != null) {
                      uVar1 = Component.GetComponent(lVar2,DAT_181d96178);
                      LTLocalization.SetText(uVar1,text,0);
                      if (this.sureMenu != null) {
                        lVar2 = GameObject.get_transform(this.sureMenu,0);
                        if (lVar2 != null) {
                          lVar2 = Transform.Find(lVar2,"ButtonGrid",0);
                          if (lVar2 != null) {
                            lVar2 = Transform.Find(lVar2,"Cancel",0);
                            if (lVar2 != null) {
                              lVar2 = Component.get_gameObject(lVar2,0);
                              if (lVar2 != null) {
                                GameObject.SetActive(lVar2,param_6,0);
                                plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/Woosh",0);
                                plVar4 = (int64 *)0;
                                if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181daf360)) {
                                  plVar4 = plVar3;
                                }
                                NGUITools.PlaySound(plVar4,0x3f000000,0);
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

    // Token : 0x60022D7
    // RVA   : 0xA945D0   Offset: 0xA939D0   Length: 0xFF
    public void CallSureMenu(string text, string fuc, string param, string tagToSendMessage)
    {
        var pStatics = *(int64*)(DAT_181dabea0 + 184);
        void SureMenu.CallSureMenu
                     (int64 this,uint64 text,uint64 fuc,uint64 param,
                     uint64 tagToSendMessage,uint8 param_6,char param_7,uint64 param_8,
                     uint64 param_9)
        {
        uint64 uVar1;
        int64 lVar2;
        int64 *plVar3;
        int64 *plVar4;
        if (param_7) {
          if (*pStatics == 0) throw; // [null/range check failed]
          *(uint8 *)(*pStatics + 24) = 1;
        }
        if (this.sureMenu != null) {
          GameObject.SetActive(this.sureMenu,1,0);
          if (this.sureMenu != null) {
            uVar1 = GameObject.get_transform(this.sureMenu,0);
            uVar1 = ShortcutExtensions.DOScale(uVar1,0x3f800000,0x3e4ccccd,0);
            uVar1 = TweenSettingsExtensions.SetEase(uVar1,8,DAT_181dc1128);
            TweenSettingsExtensions.SetUpdate(uVar1,1,DAT_181dc1f60);
            if (this.blackBackground != null) {
              lVar2 = Component.get_gameObject(this.blackBackground,0);
              if (lVar2 != null) {
                GameObject.SetActive(lVar2,1,0);
                uVar1 = DOTweenModuleUI.DOFade(this.blackBackground,0x3f400000,0x3e4ccccd,0);
                TweenSettingsExtensions.SetUpdate(uVar1,1,DAT_181dc1dc8);
                this.fucName = fuc;
                this.pause = param_7;
                this.fucParam = param;
                this.cancelFucName = param_8;
                this.cancelFucParam = param_9;
                this.objToSendMessage = tagToSendMessage;
                SureMenu.SetButtonState(this,1,0);
                if (this.sureMenu != null) {
                  lVar2 = GameObject.get_transform(this.sureMenu,0);
                  if (lVar2 != null) {
                    lVar2 = Transform.Find(lVar2,"Text",0);
                    if (lVar2 != null) {
                      uVar1 = Component.GetComponent(lVar2,DAT_181d96178);
                      LTLocalization.SetText(uVar1,text,0);
                      if (this.sureMenu != null) {
                        lVar2 = GameObject.get_transform(this.sureMenu,0);
                        if (lVar2 != null) {
                          lVar2 = Transform.Find(lVar2,"ButtonGrid",0);
                          if (lVar2 != null) {
                            lVar2 = Transform.Find(lVar2,"Cancel",0);
                            if (lVar2 != null) {
                              lVar2 = Component.get_gameObject(lVar2,0);
                              if (lVar2 != null) {
                                GameObject.SetActive(lVar2,param_6,0);
                                plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/Woosh",0);
                                plVar4 = (int64 *)0;
                                if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181daf360)) {
                                  plVar4 = plVar3;
                                }
                                NGUITools.PlaySound(plVar4,0x3f000000,0);
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

    // Token : 0x60022D8
    // RVA   : 0xA944C0   Offset: 0xA938C0   Length: 0x106
    public void CallSureMenu(string text, string fuc, string param, string tagToSendMessage, bool canCancel)
    {
        var pStatics = *(int64*)(DAT_181dabea0 + 184);
        void SureMenu.CallSureMenu
                     (int64 this,uint64 text,uint64 fuc,uint64 param,
                     uint64 tagToSendMessage,uint8 canCancel,char param_7,uint64 param_8,
                     uint64 param_9)
        {
        uint64 uVar1;
        int64 lVar2;
        int64 *plVar3;
        int64 *plVar4;
        if (param_7) {
          if (*pStatics == 0) throw; // [null/range check failed]
          *(uint8 *)(*pStatics + 24) = 1;
        }
        if (this.sureMenu != null) {
          GameObject.SetActive(this.sureMenu,1,0);
          if (this.sureMenu != null) {
            uVar1 = GameObject.get_transform(this.sureMenu,0);
            uVar1 = ShortcutExtensions.DOScale(uVar1,0x3f800000,0x3e4ccccd,0);
            uVar1 = TweenSettingsExtensions.SetEase(uVar1,8,DAT_181dc1128);
            TweenSettingsExtensions.SetUpdate(uVar1,1,DAT_181dc1f60);
            if (this.blackBackground != null) {
              lVar2 = Component.get_gameObject(this.blackBackground,0);
              if (lVar2 != null) {
                GameObject.SetActive(lVar2,1,0);
                uVar1 = DOTweenModuleUI.DOFade(this.blackBackground,0x3f400000,0x3e4ccccd,0);
                TweenSettingsExtensions.SetUpdate(uVar1,1,DAT_181dc1dc8);
                this.fucName = fuc;
                this.pause = param_7;
                this.fucParam = param;
                this.cancelFucName = param_8;
                this.cancelFucParam = param_9;
                this.objToSendMessage = tagToSendMessage;
                SureMenu.SetButtonState(this,1,0);
                if (this.sureMenu != null) {
                  lVar2 = GameObject.get_transform(this.sureMenu,0);
                  if (lVar2 != null) {
                    lVar2 = Transform.Find(lVar2,"Text",0);
                    if (lVar2 != null) {
                      uVar1 = Component.GetComponent(lVar2,DAT_181d96178);
                      LTLocalization.SetText(uVar1,text,0);
                      if (this.sureMenu != null) {
                        lVar2 = GameObject.get_transform(this.sureMenu,0);
                        if (lVar2 != null) {
                          lVar2 = Transform.Find(lVar2,"ButtonGrid",0);
                          if (lVar2 != null) {
                            lVar2 = Transform.Find(lVar2,"Cancel",0);
                            if (lVar2 != null) {
                              lVar2 = Component.get_gameObject(lVar2,0);
                              if (lVar2 != null) {
                                GameObject.SetActive(lVar2,canCancel,0);
                                plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/Woosh",0);
                                plVar4 = (int64 *)0;
                                if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181daf360)) {
                                  plVar4 = plVar3;
                                }
                                NGUITools.PlaySound(plVar4,0x3f000000,0);
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

    // Token : 0x60022D9
    // RVA   : 0xA948E0   Offset: 0xA93CE0   Length: 0x10D
    public void CallSureMenu(string text, string fuc, string param, string tagToSendMessage, bool canCancel, bool pause)
    {
        var pStatics = *(int64*)(DAT_181dabea0 + 184);
        void SureMenu.CallSureMenu
                     (int64 this,uint64 text,uint64 fuc,uint64 param,
                     uint64 tagToSendMessage,uint8 canCancel,char pause,uint64 param_8,
                     uint64 param_9)
        {
        uint64 uVar1;
        int64 lVar2;
        int64 *plVar3;
        int64 *plVar4;
        if (pause) {
          if (*pStatics == 0) throw; // [null/range check failed]
          *(uint8 *)(*pStatics + 24) = 1;
        }
        if (this.sureMenu != null) {
          GameObject.SetActive(this.sureMenu,1,0);
          if (this.sureMenu != null) {
            uVar1 = GameObject.get_transform(this.sureMenu,0);
            uVar1 = ShortcutExtensions.DOScale(uVar1,0x3f800000,0x3e4ccccd,0);
            uVar1 = TweenSettingsExtensions.SetEase(uVar1,8,DAT_181dc1128);
            TweenSettingsExtensions.SetUpdate(uVar1,1,DAT_181dc1f60);
            if (this.blackBackground != null) {
              lVar2 = Component.get_gameObject(this.blackBackground,0);
              if (lVar2 != null) {
                GameObject.SetActive(lVar2,1,0);
                uVar1 = DOTweenModuleUI.DOFade(this.blackBackground,0x3f400000,0x3e4ccccd,0);
                TweenSettingsExtensions.SetUpdate(uVar1,1,DAT_181dc1dc8);
                this.fucName = fuc;
                this.pause = pause;
                this.fucParam = param;
                this.cancelFucName = param_8;
                this.cancelFucParam = param_9;
                this.objToSendMessage = tagToSendMessage;
                SureMenu.SetButtonState(this,1,0);
                if (this.sureMenu != null) {
                  lVar2 = GameObject.get_transform(this.sureMenu,0);
                  if (lVar2 != null) {
                    lVar2 = Transform.Find(lVar2,"Text",0);
                    if (lVar2 != null) {
                      uVar1 = Component.GetComponent(lVar2,DAT_181d96178);
                      LTLocalization.SetText(uVar1,text,0);
                      if (this.sureMenu != null) {
                        lVar2 = GameObject.get_transform(this.sureMenu,0);
                        if (lVar2 != null) {
                          lVar2 = Transform.Find(lVar2,"ButtonGrid",0);
                          if (lVar2 != null) {
                            lVar2 = Transform.Find(lVar2,"Cancel",0);
                            if (lVar2 != null) {
                              lVar2 = Component.get_gameObject(lVar2,0);
                              if (lVar2 != null) {
                                GameObject.SetActive(lVar2,canCancel,0);
                                plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/Woosh",0);
                                plVar4 = (int64 *)0;
                                if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181daf360)) {
                                  plVar4 = plVar3;
                                }
                                NGUITools.PlaySound(plVar4,0x3f000000,0);
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

    // Token : 0x60022DA
    // RVA   : 0xA94770   Offset: 0xA93B70   Length: 0xE9
    public void CallSureMenu(string text, string fuc, string param, string tagToSendMessage, bool canCancel, bool pause, string cancelCallFuc, string cancelCallParam)
    {
        var pStatics = *(int64*)(DAT_181dabea0 + 184);
        void SureMenu.CallSureMenu
                     (int64 this,uint64 text,uint64 fuc,uint64 param,
                     uint64 tagToSendMessage,uint8 canCancel,char pause,uint64 cancelCallFuc,
                     uint64 cancelCallParam)
        {
        uint64 uVar1;
        int64 lVar2;
        int64 *plVar3;
        int64 *plVar4;
        if (pause) {
          if (*pStatics == 0) throw; // [null/range check failed]
          *(uint8 *)(*pStatics + 24) = 1;
        }
        if (this.sureMenu != null) {
          GameObject.SetActive(this.sureMenu,1,0);
          if (this.sureMenu != null) {
            uVar1 = GameObject.get_transform(this.sureMenu,0);
            uVar1 = ShortcutExtensions.DOScale(uVar1,0x3f800000,0x3e4ccccd,0);
            uVar1 = TweenSettingsExtensions.SetEase(uVar1,8,DAT_181dc1128);
            TweenSettingsExtensions.SetUpdate(uVar1,1,DAT_181dc1f60);
            if (this.blackBackground != null) {
              lVar2 = Component.get_gameObject(this.blackBackground,0);
              if (lVar2 != null) {
                GameObject.SetActive(lVar2,1,0);
                uVar1 = DOTweenModuleUI.DOFade(this.blackBackground,0x3f400000,0x3e4ccccd,0);
                TweenSettingsExtensions.SetUpdate(uVar1,1,DAT_181dc1dc8);
                this.fucName = fuc;
                this.pause = pause;
                this.fucParam = param;
                this.cancelFucName = cancelCallFuc;
                this.cancelFucParam = cancelCallParam;
                this.objToSendMessage = tagToSendMessage;
                SureMenu.SetButtonState(this,1,0);
                if (this.sureMenu != null) {
                  lVar2 = GameObject.get_transform(this.sureMenu,0);
                  if (lVar2 != null) {
                    lVar2 = Transform.Find(lVar2,"Text",0);
                    if (lVar2 != null) {
                      uVar1 = Component.GetComponent(lVar2,DAT_181d96178);
                      LTLocalization.SetText(uVar1,text,0);
                      if (this.sureMenu != null) {
                        lVar2 = GameObject.get_transform(this.sureMenu,0);
                        if (lVar2 != null) {
                          lVar2 = Transform.Find(lVar2,"ButtonGrid",0);
                          if (lVar2 != null) {
                            lVar2 = Transform.Find(lVar2,"Cancel",0);
                            if (lVar2 != null) {
                              lVar2 = Component.get_gameObject(lVar2,0);
                              if (lVar2 != null) {
                                GameObject.SetActive(lVar2,canCancel,0);
                                plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/Woosh",0);
                                plVar4 = (int64 *)0;
                                if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181daf360)) {
                                  plVar4 = plVar3;
                                }
                                NGUITools.PlaySound(plVar4,0x3f000000,0);
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

    // Token : 0x60022DB
    // RVA   : 0xA94130   Offset: 0xA93530   Length: 0x381
    public void CallSureMenu(string text, string fuc, string param, GameObject objToSendMessage, bool canCancel, bool pause, string cancelCallFuc, string cancelCallParam)
    {
        var pStatics = *(int64*)(DAT_181dabea0 + 184);
        void SureMenu.CallSureMenu
                     (int64 this,uint64 text,uint64 fuc,uint64 param,
                     uint64 objToSendMessage,uint8 canCancel,char pause,uint64 cancelCallFuc,
                     uint64 cancelCallParam)
        {
        uint64 uVar1;
        int64 lVar2;
        int64 *plVar3;
        int64 *plVar4;
        if (pause) {
          if (*pStatics == 0) throw; // [null/range check failed]
          *(uint8 *)(*pStatics + 24) = 1;
        }
        if (this.sureMenu != null) {
          GameObject.SetActive(this.sureMenu,1,0);
          if (this.sureMenu != null) {
            uVar1 = GameObject.get_transform(this.sureMenu,0);
            uVar1 = ShortcutExtensions.DOScale(uVar1,0x3f800000,0x3e4ccccd,0);
            uVar1 = TweenSettingsExtensions.SetEase(uVar1,8,DAT_181dc1128);
            TweenSettingsExtensions.SetUpdate(uVar1,1,DAT_181dc1f60);
            if (this.blackBackground != null) {
              lVar2 = Component.get_gameObject(this.blackBackground,0);
              if (lVar2 != null) {
                GameObject.SetActive(lVar2,1,0);
                uVar1 = DOTweenModuleUI.DOFade(this.blackBackground,0x3f400000,0x3e4ccccd,0);
                TweenSettingsExtensions.SetUpdate(uVar1,1,DAT_181dc1dc8);
                this.fucName = fuc;
                this.pause = pause;
                this.fucParam = param;
                this.cancelFucName = cancelCallFuc;
                this.cancelFucParam = cancelCallParam;
                this.objToSendMessage = objToSendMessage;
                SureMenu.SetButtonState(this,1,0);
                if (this.sureMenu != null) {
                  lVar2 = GameObject.get_transform(this.sureMenu,0);
                  if (lVar2 != null) {
                    lVar2 = Transform.Find(lVar2,"Text",0);
                    if (lVar2 != null) {
                      uVar1 = Component.GetComponent(lVar2,DAT_181d96178);
                      LTLocalization.SetText(uVar1,text,0);
                      if (this.sureMenu != null) {
                        lVar2 = GameObject.get_transform(this.sureMenu,0);
                        if (lVar2 != null) {
                          lVar2 = Transform.Find(lVar2,"ButtonGrid",0);
                          if (lVar2 != null) {
                            lVar2 = Transform.Find(lVar2,"Cancel",0);
                            if (lVar2 != null) {
                              lVar2 = Component.get_gameObject(lVar2,0);
                              if (lVar2 != null) {
                                GameObject.SetActive(lVar2,canCancel,0);
                                plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/Woosh",0);
                                plVar4 = (int64 *)0;
                                if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181daf360)) {
                                  plVar4 = plVar3;
                                }
                                NGUITools.PlaySound(plVar4,0x3f000000,0);
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

    // Token : 0x60022DC
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x60022DD
    // RVA   : 0x78D070   Offset: 0x78C470   Length: 0x20
    private void <HideSelf>b__18_0()
    {
        if (this.sureMenu != null) {
          GameObject.SetActive(this.sureMenu,0,0);
          return;
        }
    }

}
