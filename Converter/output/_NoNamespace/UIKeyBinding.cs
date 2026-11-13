// ============================================================
// Type  : UIKeyBinding
// Token : 0x200004B
// ============================================================

public class UIKeyBinding
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400018F
    public static List<UIKeyBinding> list;

    // Token: 0x4000190
    public KeyCode keyCode;

    // Token: 0x4000191
    public Modifier modifier;

    // Token: 0x4000192
    public Action action;

    // Token: 0x4000193
    private bool mIgnoreUp;

    // Token: 0x4000194
    private bool mIsInput;

    // Token: 0x4000195
    private bool mPress;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000170
    // RVA   : 0xF8B960   Offset: 0xF8A760   Length: 0xEE
    public string get_captionText()
    {
        uint uVar1;
        ulong uVar2;
        ulong uVar4;
        uVar1 = this.keyCode;
        uVar2 = NGUITools.KeyToCaption(uVar1,0);
        if ((this.modifier & 0xfffffffb) != 0) {
          plVar3 = (int64 *)il2cpp_value_box(DAT_181e6e290,(uint32 *)(this + 28));
          if (plVar3 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          uVar4 = (**(code **)(*plVar3 + 0x168))(plVar3,*(uint64 *)(*plVar3 + 0x170));
          puVar5 = (uint32 *)il2cpp_object_unbox(plVar3);
          this.modifier = *puVar5;
          String.Concat(uVar4,"+",uVar2,0);
        }
    }

    // Token : 0x6000171
    // RVA   : 0xF8AAA0   Offset: 0xF898A0   Length: 0x149
    public static bool IsBound(KeyCode key)
    {
        var pStatics = *(int64*)(DAT_181e900d0 + 184);
        int iVar1;
        bool cVar2;
        long lVar3;
        int iVar4;
        iVar4 = 0;
        if (*pStatics != 0) {
          iVar1 = *(int *)(*pStatics + 24);
          if (0 < iVar1) {
            do {
              if (*pStatics == 0) throw; // [null/range check failed]
              lVar3 = FUN_1800024b0(*pStatics,iVar4,DAT_181e8c1f0);
              cVar2 = Object.op_Inequality(lVar3,0,0);
              if (cVar2) {
                if (lVar3 == null) throw; // [null/range check failed]
                if (*(int *)(lVar3 + 24) == key) {
                  return true;
                }
              }
              iVar4 = iVar4 + 1;
            } while (iVar4 < iVar1);
          }
          return false;
        }
    }

    // Token : 0x6000172
    // RVA   : 0xF8A340   Offset: 0xF89140   Length: 0x16E
    public static UIKeyBinding Find(string name)
    {
        var pStatics = *(int64*)(DAT_181e900d0 + 184);
        int iVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        int iVar5;
        iVar5 = 0;
        if (*pStatics == 0) {
        LAB_180f8a4a9:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        iVar1 = *(int *)(*pStatics + 24);
        if (0 < iVar1) {
          do {
            if ((*pStatics == 0) ||
               (lVar3 = FUN_1800024b0(*pStatics,iVar5,DAT_181e8c1f0),
               lVar3 == null)) goto LAB_180f8a4a9;
            uVar4 = Object.get_name(lVar3,0);
            cVar2 = FUN_1816387f0(uVar4,name,0);
            if (cVar2) {
              if (*pStatics != 0) {
                uVar4 = FUN_1800024b0(*pStatics,iVar5,DAT_181e8c1f0);
                return uVar4;
              }
              goto LAB_180f8a4a9;
            }
            iVar5 = iVar5 + 1;
          } while (iVar5 < iVar1);
        }
        return 0;
    }

    // Token : 0x6000173
    // RVA   : 0xF8B230   Offset: 0xF8A030   Length: 0x81
    protected virtual void OnEnable()
    {
        var pStatics = *(int64*)(DAT_181e900d0 + 184);
        if (*pStatics != 0) {
          FUN_18175de30(*pStatics,this,DAT_181e8c070);
          return;
        }
    }

    // Token : 0x6000174
    // RVA   : 0xF8B1A0   Offset: 0xF89FA0   Length: 0x81
    protected virtual void OnDisable()
    {
        var pStatics = *(int64*)(DAT_181e900d0 + 184);
        if (*pStatics != 0) {
          FUN_181665e90(*pStatics,this,DAT_181e8c0f0);
          return;
        }
    }

    // Token : 0x6000175
    // RVA   : 0xF8B380   Offset: 0xF8A180   Length: 0x114
    protected virtual void Start()
    {
        ulong uVar1;
        long lVar2;
        byte uVar3;
        bool cVar4;
        ulong uVar5;
        lVar2 = Component.GetComponent(this,DAT_181e79db8);
        uVar3 = Object.op_Inequality(lVar2,0,0);
        *(uint8 *)((int64)this + 37) = uVar3;
        cVar4 = Object.op_Inequality(lVar2,0,0);
        if (cVar4) {
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          uVar1 = *(uint64 *)(lVar2 + 120);
          uVar5 = new OnTooltipCB(this,*(uint64 *)(*this + 0x1b0),0);
          EventDelegate.Add(uVar1,uVar5,0);
        }
    }

    // Token : 0x6000176
    // RVA   : 0xF8B2C0   Offset: 0xF8A0C0   Length: 0xBE
    protected virtual void OnSubmit()
    {
        bool cVar1;
        if (*(int *)(*(int64 *)(DAT_181e8fad0 + 184) + 216) == (int)this[3]) {
          cVar1 = (**(code **)(*this + 0x1b8))(this,*(uint64 *)(*this + 0x1c0));
          if (cVar1) {
            *(uint8 *)((int64)this + 36) = 1;
          }
        }
    }

    // Token : 0x6000177
    // RVA   : 0xF8B010   Offset: 0xF89E10   Length: 0x54
    protected virtual bool IsModifierActive()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        if (this != 0) {
          if (this == 3) {
            lVar2 = UICamera.GetKey;
            if (lVar2 == null) {
        LAB_180f8b006:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            cVar1 = GetKeyStateFunc.Invoke(lVar2,0x134,0);
            if (cVar1) {
              return true;
            }
            lVar2 = UICamera.GetKey;
            if (lVar2 == null) goto LAB_180f8b006;
            cVar1 = GetKeyStateFunc.Invoke(lVar2,0x133,0);
          }
          else {
            if (this == 2) {
              lVar2 = UICamera.GetKey;
              if (lVar2 == null) goto LAB_180f8b006;
              cVar1 = GetKeyStateFunc.Invoke(lVar2,0x132,0);
              if (cVar1) {
                return true;
              }
              lVar2 = UICamera.GetKey;
              if (lVar2 == null) goto LAB_180f8b006;
              uVar3 = 0x131;
            }
            else {
              if (this != 1) {
                if (this != 4) {
                  return false;
                }
                lVar2 = UICamera.GetKey;
                if (lVar2 != null) {
                  cVar1 = GetKeyStateFunc.Invoke(lVar2,0x134,0);
                  if (cVar1) {
                    return false;
                  }
                  lVar2 = UICamera.GetKey;
                  if (lVar2 != null) {
                    cVar1 = GetKeyStateFunc.Invoke(lVar2,0x133,0);
                    if (cVar1) {
                      return false;
                    }
                    lVar2 = UICamera.GetKey;
                    if (lVar2 != null) {
                      cVar1 = GetKeyStateFunc.Invoke(lVar2,0x132,0);
                      if (cVar1) {
                        return false;
                      }
                      lVar2 = UICamera.GetKey;
                      if (lVar2 != null) {
                        cVar1 = GetKeyStateFunc.Invoke(lVar2,0x131,0);
                        if (cVar1) {
                          return false;
                        }
                        lVar2 = UICamera.GetKey;
                        if (lVar2 != null) {
                          cVar1 = GetKeyStateFunc.Invoke(lVar2,0x130,0);
                          if (cVar1) {
                            return false;
                          }
                          lVar2 = UICamera.GetKey;
                          if (lVar2 != null) {
                            cVar1 = GetKeyStateFunc.Invoke(lVar2,0x12f,0);
                            return !cVar1;
                          }
                        }
                      }
                    }
                  }
                }
                goto LAB_180f8b006;
              }
              lVar2 = UICamera.GetKey;
              if (lVar2 == null) goto LAB_180f8b006;
              cVar1 = GetKeyStateFunc.Invoke(lVar2,0x130,0);
              if (cVar1) {
                return true;
              }
              lVar2 = UICamera.GetKey;
              if (lVar2 == null) goto LAB_180f8b006;
              uVar3 = 0x12f;
            }
            cVar1 = GetKeyStateFunc.Invoke(lVar2,uVar3,0);
          }
          if (!cVar1) {
            return false;
          }
        }
        return true;
    }

    // Token : 0x6000178
    // RVA   : 0xF8ABF0   Offset: 0xF899F0   Length: 0x41B
    public static bool IsModifierActive(Modifier modifier)
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        if (modifier != null) {
          if (modifier == 3) {
            lVar2 = UICamera.GetKey;
            if (lVar2 == null) {
        LAB_180f8b006:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            cVar1 = GetKeyStateFunc.Invoke(lVar2,0x134,0);
            if (cVar1) {
              return true;
            }
            lVar2 = UICamera.GetKey;
            if (lVar2 == null) goto LAB_180f8b006;
            cVar1 = GetKeyStateFunc.Invoke(lVar2,0x133,0);
          }
          else {
            if (modifier == 2) {
              lVar2 = UICamera.GetKey;
              if (lVar2 == null) goto LAB_180f8b006;
              cVar1 = GetKeyStateFunc.Invoke(lVar2,0x132,0);
              if (cVar1) {
                return true;
              }
              lVar2 = UICamera.GetKey;
              if (lVar2 == null) goto LAB_180f8b006;
              uVar3 = 0x131;
            }
            else {
              if (modifier != 1) {
                if (modifier != 4) {
                  return false;
                }
                lVar2 = UICamera.GetKey;
                if (lVar2 != null) {
                  cVar1 = GetKeyStateFunc.Invoke(lVar2,0x134,0);
                  if (cVar1) {
                    return false;
                  }
                  lVar2 = UICamera.GetKey;
                  if (lVar2 != null) {
                    cVar1 = GetKeyStateFunc.Invoke(lVar2,0x133,0);
                    if (cVar1) {
                      return false;
                    }
                    lVar2 = UICamera.GetKey;
                    if (lVar2 != null) {
                      cVar1 = GetKeyStateFunc.Invoke(lVar2,0x132,0);
                      if (cVar1) {
                        return false;
                      }
                      lVar2 = UICamera.GetKey;
                      if (lVar2 != null) {
                        cVar1 = GetKeyStateFunc.Invoke(lVar2,0x131,0);
                        if (cVar1) {
                          return false;
                        }
                        lVar2 = UICamera.GetKey;
                        if (lVar2 != null) {
                          cVar1 = GetKeyStateFunc.Invoke(lVar2,0x130,0);
                          if (cVar1) {
                            return false;
                          }
                          lVar2 = UICamera.GetKey;
                          if (lVar2 != null) {
                            cVar1 = GetKeyStateFunc.Invoke(lVar2,0x12f,0);
                            return !cVar1;
                          }
                        }
                      }
                    }
                  }
                }
                goto LAB_180f8b006;
              }
              lVar2 = UICamera.GetKey;
              if (lVar2 == null) goto LAB_180f8b006;
              cVar1 = GetKeyStateFunc.Invoke(lVar2,0x130,0);
              if (cVar1) {
                return true;
              }
              lVar2 = UICamera.GetKey;
              if (lVar2 == null) goto LAB_180f8b006;
              uVar3 = 0x12f;
            }
            cVar1 = GetKeyStateFunc.Invoke(lVar2,uVar3,0);
          }
          if (!cVar1) {
            return false;
          }
        }
        return true;
    }

    // Token : 0x6000179
    // RVA   : 0xF8B600   Offset: 0xF8A400   Length: 0x2D6
    protected virtual void Update()
    {
        long lVar1;
        bool cVar2;
        ulong uVar4;
        if ((int)this[3] != 300) {
          cVar2 = UICamera.get_inputHasFocus(0);
          if (cVar2) {
            return;
          }
        }
        if ((int)this[3] == 0) {
          return;
        }
        cVar2 = (**(code **)(*this + 0x1b8))(this,*(uint64 *)(*this + 0x1c0));
        if (!cVar2) {
          return;
        }
        lVar1 = UICamera.GetKeyDown;
        if (lVar1 == null) {
        LAB_180f8b8d1:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        cVar2 = GetKeyStateFunc.Invoke(lVar1,(int)this[3],0);
        lVar1 = UICamera.GetKeyUp;
        if (lVar1 == null) goto LAB_180f8b8d1;
        bVar3 = GetKeyStateFunc.Invoke(lVar1,(int)this[3],0);
        if (cVar2) {
          *(uint8 *)((int64)this + 38) = 1;
        }
        if ((*(uint32 *)(this + 4) & 0xfffffffd) == 0) {
          if (cVar2) {
            UICamera.currentTouchID = 0xffffffff;
            UICamera.set_currentKey((int)this[3],0);
            (**(code **)(*this + 0x1d8))(this,1,*(uint64 *)(*this + 0x1e0));
          }
          if ((*(byte *)((int64)this + 38) & bVar3) != 0) {
            UICamera.currentTouchID = 0xffffffff;
            UICamera.set_currentKey((int)this[3],0);
            (**(code **)(*this + 0x1d8))(this,0,*(uint64 *)(*this + 0x1e0));
            (**(code **)(*this + 0x1e8))(this,*(uint64 *)(*this + 0x1f0));
          }
        }
        if (1 < (int)this[4] - 1U) {
          if (bVar3 == 0) {
            return;
          }
          goto LAB_180f8b8bd;
        }
        if (bVar3 == 0) {
          return;
        }
        if (*(char *)((int64)this + 37) == false) {
          if (*(char *)((int64)this + 38) != false) {
            uVar4 = Component.get_gameObject(this,0);
            UICamera.set_hoveredObject(uVar4,0);
          }
          goto LAB_180f8b8bd;
        }
        if (*(char *)((int64)this + 36) == false) {
          if ((int)this[3] != 300) {
            cVar2 = UICamera.get_inputHasFocus(0);
            if (!(cVar2))
            {
              }
              if (*(char *)((int64)this + 38) != false) {
              uVar4 = Component.get_gameObject(this,0);
              UICamera.set_selectedObject(uVar4,0);
              }
              }
            }
        *(uint8 *)((int64)this + 36) = 0;
        LAB_180f8b8bd:
        *(uint8 *)((int64)this + 38) = 0;
    }

    // Token : 0x600017A
    // RVA   : 0xF8B0F0   Offset: 0xF89EF0   Length: 0xA7
    protected virtual void OnBindingPress(bool pressed)
    {
        ulong uVar1;
        ulong uVar2;
        byte[] local_res10 = new byte[24];
        uVar1 = Component.get_gameObject(this,0);
        local_res10[0] = pressed;
        uVar2 = il2cpp_value_box(DAT_181e92da8,local_res10);
        UICamera.Notify(uVar1,"OnPress",uVar2,0);
    }

    // Token : 0x600017B
    // RVA   : 0xF8B070   Offset: 0xF89E70   Length: 0x76
    protected virtual void OnBindingClick()
    {
        ulong uVar1;
        uVar1 = Component.get_gameObject(this,0);
        UICamera.Notify(uVar1,"OnClick",0,0);
    }

    // Token : 0x600017C
    // RVA   : 0xF8B4A0   Offset: 0xF8A2A0   Length: 0x15C
    public override string ToString()
    {
        uint uVar1;
        int iVar2;
        ulong uVar4;
        ulong uVar6;
        int[] local_res8 = new int[2];
        uVar1 = this.keyCode;
        iVar2 = this.modifier;
        local_res8[0] = iVar2;
        if (local_res8[0] != 4) {
          plVar3 = (int64 *)il2cpp_value_box(DAT_181e6e290,local_res8);
          if (plVar3 != (int64 *)0) {
            uVar4 = (**(code **)(*plVar3 + 0x168))(plVar3,*(uint64 *)(*plVar3 + 0x170));
            piVar5 = (int *)il2cpp_object_unbox(plVar3);
            local_res8[0] = *piVar5;
            uVar6 = NGUITools.KeyToCaption(uVar1,0);
            String.Concat(uVar4,"+",uVar6,0);
            return;
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        NGUITools.KeyToCaption(uVar1,0);
    }

    // Token : 0x600017D
    // RVA   : 0xF8A980   Offset: 0xF89780   Length: 0x116
    public static string GetString(KeyCode keyCode, Modifier modifier)
    {
        ulong uVar2;
        ulong uVar4;
        int[] local_res10 = new int[2];
        local_res10[0] = modifier;
        if (local_res10[0] != 4) {
          plVar1 = (int64 *)il2cpp_value_box(DAT_181e6e290,local_res10);
          if (plVar1 != (int64 *)0) {
            uVar2 = (**(code **)(*plVar1 + 0x168))(plVar1,*(uint64 *)(*plVar1 + 0x170));
            piVar3 = (int *)il2cpp_object_unbox(plVar1);
            local_res10[0] = *piVar3;
            uVar4 = NGUITools.KeyToCaption(keyCode,0);
            String.Concat(uVar2,"+",uVar4,0);
            return;
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        NGUITools.KeyToCaption(keyCode,0);
    }

    // Token : 0x600017E
    // RVA   : 0xF8A6E0   Offset: 0xF894E0   Length: 0x297
    public static bool GetKeyCode(string text, ref KeyCode key, ref Modifier modifier)
    {
        ulong uVar1;
        bool cVar2;
        uint uVar4;
        long lVar5;
        ulong uVar6;
        *key = 0;
        *modifier = 4;
        cVar2 = FUN_180ad1200(text,0);
        if (cVar2) {
          return true;
        }
        if (text != null) {
          if (((*(int *)(text + 16) < 3) ||
              (cVar2 = String.Contains(text,"+",0), !cVar2)) ||
             (sVar3 = String.get_Chars(text,*(int *)(text + 16) + -1,0), sVar3 == 43)) {
            *modifier = 4;
            uVar4 = NGUITools.CaptionToKey(text,0);
            *key = uVar4;
            return true;
          }
          lVar5 = FUN_1801dfd90(DAT_181e81128,1);
          if (lVar5 != null) {
            if (*(int *)(lVar5 + 24) == 0) {
              uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar6,0);
            }
            *(uint16 *)(lVar5 + 32) = 43;
            lVar5 = String.Split(text,lVar5,2,0);
            if (lVar5 != null) {
              if (*(uint32 *)(lVar5 + 24) < 2) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar6,0);
              }
              uVar6 = *(uint64 *)(lVar5 + 40);
              uVar4 = NGUITools.CaptionToKey(uVar6,0);
              *key = uVar4;
              uVar6 = DAT_181e57dc8;
              uVar6 = Type.GetTypeFromHandle(uVar6,0);
              if (*(int *)(lVar5 + 24) == 0) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar6,0);
              }
              uVar1 = *(uint64 *)(lVar5 + 32);
              plVar7 = (int64 *)Enum.Parse(uVar6,uVar1,0);
              if (plVar7 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300(0);
              }
              if (*(int64 *)(*plVar7 + 64) != *(int64 *)(DAT_181e6e290 + 64)) {
                          // WARNING: Subroutine does not return
                FUN_1801dfd50(plVar7,DAT_181e6e290);
              }
              puVar8 = (uint32 *)il2cpp_object_unbox();
              *modifier = *puVar8;
              return true;
            }
          }
        }
    }

    // Token : 0x600017F
    // RVA   : 0xF8A4B0   Offset: 0xF892B0   Length: 0x227
    public static Modifier GetActiveModifier()
    {
        long lVar1;
        bool cVar2;
        lVar1 = UICamera.GetKey;
        if (lVar1 != null) {
          cVar2 = GetKeyStateFunc.Invoke(lVar1,0x134,0);
          if (cVar2) {
            return 3;
          }
          lVar1 = UICamera.GetKey;
          if (lVar1 != null) {
            cVar2 = GetKeyStateFunc.Invoke(lVar1,0x133,0);
            if (cVar2) {
              return 3;
            }
            lVar1 = UICamera.GetKey;
            if (lVar1 != null) {
              cVar2 = GetKeyStateFunc.Invoke(lVar1,0x130,0);
              if (cVar2) {
                return 1;
              }
              lVar1 = UICamera.GetKey;
              if (lVar1 != null) {
                cVar2 = GetKeyStateFunc.Invoke(lVar1,0x12f,0);
                if (cVar2) {
                  return 1;
                }
                lVar1 = UICamera.GetKey;
                if (lVar1 != null) {
                  cVar2 = GetKeyStateFunc.Invoke(lVar1,0x132,0);
                  if (cVar2) {
                    return 2;
                  }
                  lVar1 = UICamera.GetKey;
                  if (lVar1 != null) {
                    cVar2 = GetKeyStateFunc.Invoke(lVar1,0x131,0);
                    if (cVar2) {
                      return 2;
                    }
                    return 4;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000180
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

    // Token : 0x6000181
    // RVA   : 0xF8B8E0   Offset: 0xF8A6E0   Length: 0x76
    private static void /*cctor*/()
    {
        ulong uVar2;
        uVar2 = il2cpp_internal(DAT_181e78628);
        FUN_1810f3480(uVar2,DAT_181e8bff0);
        puVar1 = *(uint64 **)(DAT_181e900d0 + 184);
        *puVar1 = uVar2;
        il2cpp_internal(puVar1,uVar2);
    }

}
