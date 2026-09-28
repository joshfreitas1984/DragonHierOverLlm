// ============================================================
// Type  : UIPopupList
// Token : 0x2000055
// ============================================================

public class UIPopupList
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40001FF
    public static UIPopupList current;

    // Token: 0x4000200
    protected static GameObject mChild;

    // Token: 0x4000201
    protected static float mFadeOutComplete;

    // Token: 0x4000202
    private const float animSpeed;

    // Token: 0x4000203
    public object atlas;

    // Token: 0x4000204
    public object bitmapFont;

    // Token: 0x4000205
    public Font trueTypeFont;

    // Token: 0x4000206
    public int fontSize;

    // Token: 0x4000207
    public FontStyle fontStyle;

    // Token: 0x4000208
    public string backgroundSprite;

    // Token: 0x4000209
    public string highlightSprite;

    // Token: 0x400020A
    public Sprite background2DSprite;

    // Token: 0x400020B
    public Sprite highlight2DSprite;

    // Token: 0x400020C
    public Position position;

    // Token: 0x400020D
    public Selection selection;

    // Token: 0x400020E
    public Alignment alignment;

    // Token: 0x400020F
    public List<string> items;

    // Token: 0x4000210
    public List<object> itemData;

    // Token: 0x4000211
    public List<Action> itemCallbacks;

    // Token: 0x4000212
    public Vector2 padding;

    // Token: 0x4000213
    public Color textColor;

    // Token: 0x4000214
    public Color backgroundColor;

    // Token: 0x4000215
    public Color highlightColor;

    // Token: 0x4000216
    public bool isAnimated;

    // Token: 0x4000217
    public bool isLocalized;

    // Token: 0x4000218
    public Modifier textModifier;

    // Token: 0x4000219
    public bool separatePanel;

    // Token: 0x400021A
    public int overlap;

    // Token: 0x400021B
    public OpenOn openOn;

    // Token: 0x400021C
    public List<EventDelegate> onChange;

    // Token: 0x400021D
    protected string mSelectedItem;

    // Token: 0x400021E
    protected UIPanel mPanel;

    // Token: 0x400021F
    protected UIBasicSprite mBackground;

    // Token: 0x4000220
    protected UIBasicSprite mHighlight;

    // Token: 0x4000221
    protected UILabel mHighlightedLabel;

    // Token: 0x4000222
    protected List<UILabel> mLabelList;

    // Token: 0x4000223
    protected float mBgBorder;

    // Token: 0x4000224
    public bool keepValue;

    // Token: 0x4000225
    protected GameObject mSelection;

    // Token: 0x4000226
    protected int mOpenFrame;

    // Token: 0x4000227
    private GameObject eventReceiver;

    // Token: 0x4000228
    private string functionName;

    // Token: 0x4000229
    private float textScale;

    // Token: 0x400022A
    private UILabel textLabel;

    // Token: 0x400022B
    public Vector3 startingPosition;

    // Token: 0x400022C
    private LegacyEvent mLegacyEvent;

    // Token: 0x400022D
    protected bool mExecuting;

    // Token: 0x400022E
    protected bool mStarted;

    // Token: 0x400022F
    protected bool mTweening;

    // Token: 0x4000230
    public GameObject source;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60001DD
    // RVA   : 0x11A5D00   Offset: 0x11A5100   Length: 0xF2
    public INGUIFont get_font()
    {
        bool cVar2;
        ulong uVar4;
        uVar4 = this.bitmapFont;
        cVar2 = Object.op_Inequality(uVar4,0);
        if (!cVar2) {
          return 0;
        }
        plVar1 = this.bitmapFont;
        if (plVar1 != (int64 *)0) {
          plVar3 = (int64 *)0;
          if (*plVar1 == DAT_181d72e60) {
            plVar3 = plVar1;
          }
          if (plVar3 != (int64 *)0) {
            plVar3 = (int64 *)0;
            if (*plVar1 == DAT_181d72e60) {
              plVar3 = plVar1;
            }
            if (plVar3 != (int64 *)0) {
              uVar4 = GameObject.GetComponent(plVar3,DAT_181d74878);
              return uVar4;
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        uVar4 = il2cpp_internal(plVar1,DAT_181d7a800);
        return uVar4;
    }

    // Token : 0x60001DE
    // RVA   : 0x11A62B0   Offset: 0x11A56B0   Length: 0x92
    public void set_font(INGUIFont value)
    {
        if (value == (int64 *)0) {
          plVar2 = (int64 *)0;
        }
        else {
          plVar2 = value;
        }
        this.bitmapFont = plVar2;
        this.trueTypeFont = 0;
    }

    // Token : 0x60001DF
    // RVA   : 0x11A5880   Offset: 0x11A4C80   Length: 0x115
    public object get_ambigiousFont()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.trueTypeFont;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (!cVar2) {
          uVar1 = this.bitmapFont;
          cVar2 = Object.op_Inequality(uVar1,0,0);
          if (!cVar2) {
            return (int64 *)0;
          }
          plVar4 = this.bitmapFont;
          if (plVar4 != (int64 *)0) {
            plVar3 = (int64 *)0;
            if (*plVar4 == DAT_181d72e60) {
              plVar3 = plVar4;
            }
            if (plVar3 != (int64 *)0) {
              plVar3 = (int64 *)0;
              if (*plVar4 == DAT_181d72e60) {
                plVar3 = plVar4;
              }
              plVar4 = (int64 *)GameObject.GetComponent(plVar3,DAT_181d74878);
              return plVar4;
            }
          }
          return plVar4;
        }
        return this.trueTypeFont;
    }

    // Token : 0x60001E0
    // RVA   : 0x11A61C0   Offset: 0x11A55C0   Length: 0xEE
    public void set_ambigiousFont(object value)
    {
        long lVar1;
        if (value != (int64 *)0) {
          plVar2 = (int64 *)0;
          if (*value == DAT_181dc79d0) {
            plVar2 = value;
          }
          if (plVar2 != (int64 *)0) {
            this.trueTypeFont = plVar2;
            puVar3 = &this.bitmapFont;
            goto LAB_1811a6295;
          }
        }
        lVar1 = il2cpp_internal(value,DAT_181d7a800);
        if (lVar1 == null) {
          if (value == (int64 *)0) {
            return;
          }
          plVar2 = (int64 *)0;
          if (*value == DAT_181d72e60) {
            plVar2 = value;
          }
          if (plVar2 == (int64 *)0) {
            return;
          }
          value = (int64 *)GameObject.GetComponent(plVar2,DAT_181d74878);
          this.bitmapFont = value;
        }
        else {
          this.bitmapFont = value;
        }
        il2cpp_internal(this + 32,value);
        puVar3 = &this.trueTypeFont;
        LAB_1811a6295:
        this.trueTypeFont = 0;
        il2cpp_internal(puVar3,0);
    }

    // Token : 0x60001E1
    // RVA   : 0x11A61B0   Offset: 0x11A55B0   Length: 0x8
    public LegacyEvent get_onSelectionChange()
    {
        uint64 FUN_1811a61b0(int64 this)
        {
        return this.mLegacyEvent;
    }

    // Token : 0x60001E2
    // RVA   : 0x11A6470   Offset: 0x11A5870   Length: 0xF
    public void set_onSelectionChange(LegacyEvent value)
    {
        void FUN_1811a6470(int64 this,uint64 value)
        {
        this.mLegacyEvent = value;
    }

    // Token : 0x60001E3
    // RVA   : 0x11A5F10   Offset: 0x11A5310   Length: 0x150
    public static bool get_isOpen()
    {
        var pStatics = *(int64*)(DAT_181dafff8 + 184);
        float fVar1;
        ulong uVar2;
        bool cVar3;
        float extraout_XMM0_Da;
        uVar2 = **(uint64 **)(DAT_181dafff8 + 184);
        cVar3 = Object.op_Inequality(uVar2,0,0);
        if (!cVar3) {
          return false;
        }
        uVar2 = *(uint64 *)(pStatics + 8);
        cVar3 = Object.op_Inequality(uVar2,0,0);
        if (cVar3) {
          return true;
        }
        fVar1 = *(float *)(pStatics + 16);
        Time.get_unscaledTime(0);
        return extraout_XMM0_Da < fVar1;
    }

    // Token : 0x60001E4
    // RVA   : 0x2A3030   Offset: 0x2A2430   Length: 0x8
    public virtual string get_value()
    {
        return this.mSelectedItem;
    }

    // Token : 0x60001E5
    // RVA   : 0x11A6480   Offset: 0x11A5880   Length: 0x73
    public virtual void set_value(string value)
    {
        bool cVar2;
        plVar1 = &this.mSelectedItem;
        cVar2 = String.op_Inequality(this.mSelectedItem,value,0);
        if (cVar2) {
          this.mSelectedItem = value;
          il2cpp_internal(plVar1,value);
          if (this.mSelectedItem != null) {
            UIPopupList.TriggerCallbacks(this,0);
            if (!this.keepValue) {
              this.mSelectedItem = 0;
              il2cpp_internal(plVar1,0);
            }
          }
        }
    }

    // Token : 0x60001E6
    // RVA   : 0x11A5A50   Offset: 0x11A4E50   Length: 0xA3
    public virtual object get_data()
    {
        long lVar1;
        uint uVar2;
        if (this.items != null) {
          uVar2 = FUN_1817eb4e0(this.items,this.mSelectedItem,
                                DAT_181da3fd8);
          if (-1 < (int)uVar2) {
            lVar1 = this.itemData;
            if (lVar1 == null) throw; // [null/range check failed]
            if ((int)uVar2 < (int)lVar1.Count) {
              if (lVar1.Count <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              return lVar1._items[uVar2];
            }
          }
          return 0;
        }
    }

    // Token : 0x60001E7
    // RVA   : 0x11A59A0   Offset: 0x11A4DA0   Length: 0xA3
    public Action get_callback()
    {
        long lVar1;
        uint uVar2;
        if (this.items != null) {
          uVar2 = FUN_1817eb4e0(this.items,this.mSelectedItem,
                                DAT_181da3fd8);
          if (-1 < (int)uVar2) {
            lVar1 = this.itemCallbacks;
            if (lVar1 == null) throw; // [null/range check failed]
            if ((int)uVar2 < (int)lVar1.Count) {
              if (lVar1.Count <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              return lVar1._items[uVar2];
            }
          }
          return 0;
        }
    }

    // Token : 0x60001E8
    // RVA   : 0x11A5E00   Offset: 0x11A5200   Length: 0x105
    public bool get_isColliderEnabled()
    {
        long lVar1;
        bool cVar2;
        lVar1 = Component.GetComponent(this,DAT_181d93b60);
        cVar2 = Object.op_Inequality(lVar1,0,0);
        if (!cVar2) {
          lVar1 = Component.GetComponent(this,DAT_181d93be0);
          cVar2 = Object.op_Inequality(lVar1,0,0);
          if (!cVar2) {
            return;
          }
          if (lVar1 != null) {
            Behaviour.get_enabled(lVar1,0);
            return;
          }
        }
        else if (lVar1 != null) {
          Collider.get_enabled(lVar1,0);
          return;
        }
    }

    // Token : 0x60001E9
    // RVA   : 0x11A6350   Offset: 0x11A5750   Length: 0x117
    public void set_isColliderEnabled(bool value)
    {
        long lVar1;
        bool cVar2;
        lVar1 = Component.GetComponent(this,DAT_181d93b60);
        cVar2 = Object.op_Inequality(lVar1,0,0);
        if (!cVar2) {
          lVar1 = Component.GetComponent(this,DAT_181d93be0);
          cVar2 = Object.op_Inequality(lVar1,0,0);
          if (cVar2) {
            if (lVar1 == null) throw; // [null/range check failed]
            Behaviour.set_enabled(lVar1,value,0);
          }
          return;
        }
        if (lVar1 != null) {
          Collider.set_enabled(lVar1,value,0);
          return;
        }
    }

    // Token : 0x60001EA
    // RVA   : 0x11A6060   Offset: 0x11A5460   Length: 0x143
    protected bool get_isValid()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.trueTypeFont;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (!cVar2) {
          uVar1 = this.bitmapFont;
          cVar2 = Object.op_Inequality(uVar1,0,0);
          if (!cVar2) {
            plVar4 = (int64 *)0;
          }
          else {
            plVar4 = this.bitmapFont;
            if (plVar4 != (int64 *)0) {
              plVar3 = (int64 *)0;
              if (*plVar4 == DAT_181d72e60) {
                plVar3 = plVar4;
              }
              if (plVar3 != (int64 *)0) {
                plVar3 = (int64 *)0;
                if (*plVar4 == DAT_181d72e60) {
                  plVar3 = plVar4;
                }
                plVar4 = (int64 *)GameObject.GetComponent(plVar3,DAT_181d74878);
              }
            }
          }
        }
        else {
          plVar4 = this.trueTypeFont;
        }
        Object.op_Inequality(plVar4,0,0);
    }

    // Token : 0x60001EB
    // RVA   : 0x11A57C0   Offset: 0x11A4BC0   Length: 0xB5
    protected int get_activeFontSize()
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        lVar3 = UIPopupList.get_font(this,0);
        uVar1 = this.trueTypeFont;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if ((!cVar2) && (lVar3 != null)) {
          uVar4 = FUN_180002970(22,DAT_181d7a800,lVar3);
          return uVar4;
        }
        return (uint64)this.fontSize;
    }

    // Token : 0x60001EC
    // RVA   : 0x11A56E0   Offset: 0x11A4AE0   Length: 0xD6
    protected float get_activeFontScale()
    {
        int iVar1;
        ulong uVar2;
        long lVar3;
        bool cVar4;
        int iVar5;
        lVar3 = UIPopupList.get_font(this,0);
        uVar2 = this.trueTypeFont;
        cVar4 = Object.op_Inequality(uVar2,0,0);
        if ((!cVar4) && (lVar3 != null)) {
          iVar1 = this.fontSize;
          iVar5 = FUN_180002970(22,DAT_181d7a800,lVar3);
          return (float)iVar1 / (float)iVar5;
        }
        return 1.0;
    }

    // Token : 0x60001ED
    // RVA   : 0x11A5B00   Offset: 0x11A4F00   Length: 0x1F8
    protected float get_fitScale()
    {
        float fVar1;
        bool cVar2;
        ulong uVar3;
        long lVar4;
        float extraout_var;
        float extraout_var_00;
        float fVar5;
        if (!this.separatePanel) {
          uVar3 = this.mPanel;
          cVar2 = Object.op_Inequality(uVar3,0,0);
          if (cVar2) {
            if (this.mPanel != null) {
              uVar3 = UIRect.get_anchorCamera(this.mPanel,0);
              cVar2 = Object.op_Inequality(uVar3,0,0);
              if (!cVar2) {
                return 1.0;
              }
              if ((this.mPanel != null) &&
                 (lVar4 = UIRect.get_anchorCamera(this.mPanel,0)) != null) {
                cVar2 = Camera.get_orthographic(lVar4,0);
                if (!cVar2) {
                  return 1.0;
                }
                if (this.items != null) {
                  fVar5 = ((float)this.fontSize + *(float *)(this + 132)) *
                          (float)this.items.Count +
                          *(float *)(this + 132);
                  if (this.mPanel != null) {
                    UIPanel.GetViewSize(this.mPanel,0);
                    fVar1 = extraout_var;
                    if (fVar5 <= extraout_var) {
                      return 1.0;
                    }
                    goto LAB_1811a5c65;
                  }
                }
              }
            }
        LAB_1811a5cf3:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        else {
          if (this.items == null) goto LAB_1811a5cf3;
          fVar5 = ((float)this.fontSize + *(float *)(this + 132)) *
                  (float)this.items.Count + *(float *)(this + 132);
          NGUITools.get_screenSize(0);
          fVar1 = extraout_var_00;
          if (extraout_var_00 < fVar5) {
        LAB_1811a5c65:
            return fVar1 / fVar5;
          }
        }
        return 1.0;
    }

    // Token : 0x60001EE
    // RVA   : 0x11A2A90   Offset: 0x11A1E90   Length: 0x86
    public void Set(string value, bool notify)
    {
        bool cVar2;
        plVar1 = &this.mSelectedItem;
        cVar2 = String.op_Inequality(this.mSelectedItem,value,0);
        if (cVar2) {
          this.mSelectedItem = value;
          il2cpp_internal(plVar1,value);
          if (this.mSelectedItem != null) {
            if (notify) {
              UIPopupList.TriggerCallbacks(this,0);
            }
            if (!this.keepValue) {
              this.mSelectedItem = 0;
              il2cpp_internal(plVar1,0);
            }
          }
        }
    }

    // Token : 0x60001EF
    // RVA   : 0x11A12F0   Offset: 0x11A06F0   Length: 0x86
    public virtual void Clear()
    {
        if (this.items != null) {
          FUN_1812f9a10(this.items,DAT_181da3dd8);
          if (this.itemData != null) {
            FUN_1812f9a10(this.itemData,DAT_181d95908);
            if (this.itemCallbacks != null) {
              FUN_1812f9a10(this.itemCallbacks,DAT_181d7b308);
              return;
            }
          }
        }
    }

    // Token : 0x60001F0
    // RVA   : 0x11A0C80   Offset: 0x11A0080   Length: 0x9A
    public virtual void AddItem(string text)
    {
        if (this.items != null) {
          FUN_18181e0a0(this.items,text,DAT_181da3d58);
          if (this.itemData != null) {
            FUN_18181e0a0(this.itemData,param_3,DAT_181d95888);
            if (this.itemCallbacks != null) {
              FUN_18181e0a0(this.itemCallbacks,param_4,DAT_181d7b288);
              return;
            }
          }
        }
    }

    // Token : 0x60001F1
    // RVA   : 0x11A0D20   Offset: 0x11A0120   Length: 0x84
    public virtual void AddItem(string text, Action del)
    {
        if (this.items != null) {
          FUN_18181e0a0(this.items,text,DAT_181da3d58);
          if (this.itemData != null) {
            FUN_18181e0a0(this.itemData,del,DAT_181d95888);
            if (this.itemCallbacks != null) {
              FUN_18181e0a0(this.itemCallbacks,param_4,DAT_181d7b288);
              return;
            }
          }
        }
    }

    // Token : 0x60001F2
    // RVA   : 0x11A0DB0   Offset: 0x11A01B0   Length: 0xB5
    public virtual void AddItem(string text, object data, Action del)
    {
        if (this.items != null) {
          FUN_18181e0a0(this.items,text,DAT_181da3d58);
          if (this.itemData != null) {
            FUN_18181e0a0(this.itemData,data,DAT_181d95888);
            if (this.itemCallbacks != null) {
              FUN_18181e0a0(this.itemCallbacks,del,DAT_181d7b288);
              return;
            }
          }
        }
    }

    // Token : 0x60001F3
    // RVA   : 0x11A2990   Offset: 0x11A1D90   Length: 0xD5
    public virtual void RemoveItem(string text)
    {
        long lVar1;
        int iVar2;
        if (this.items != null) {
          iVar2 = FUN_1817eb4e0(this.items,text,DAT_181da3fd8);
          if (iVar2 == -1) {
            return;
          }
          if (this.items != null) {
            FUN_181823590(this.items,iVar2,DAT_181da4158);
            if (this.itemData != null) {
              FUN_181823590(this.itemData,iVar2,DAT_181d95c88);
              lVar1 = this.itemCallbacks;
              if (lVar1 != null) {
                if (lVar1.Count <= iVar2) {
                  return;
                }
                FUN_181823590(lVar1,iVar2,DAT_181d7b388);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60001F4
    // RVA   : 0x11A28B0   Offset: 0x11A1CB0   Length: 0xD5
    public virtual void RemoveItemByData(object data)
    {
        long lVar1;
        int iVar2;
        if (this.itemData != null) {
          iVar2 = FUN_1817eb4e0(this.itemData,data,DAT_181d95b08);
          if (iVar2 == -1) {
            return;
          }
          if (this.items != null) {
            FUN_181823590(this.items,iVar2,DAT_181da4158);
            if (this.itemData != null) {
              FUN_181823590(this.itemData,iVar2,DAT_181d95c88);
              lVar1 = this.itemCallbacks;
              if (lVar1 != null) {
                if (lVar1.Count <= iVar2) {
                  return;
                }
                FUN_181823590(lVar1,iVar2,DAT_181d7b388);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60001F5
    // RVA   : 0x11A5190   Offset: 0x11A4590   Length: 0x273
    protected void TriggerCallbacks()
    {
        var pStatics = *(int64*)(DAT_181dafff8 + 184);
        long lVar2;
        ulong uVar3;
        long lVar4;
        bool cVar5;
        uint uVar6;
        if (!this.mExecuting) {
          this.mExecuting = 1;
          plVar1 = pStatics;
          lVar2 = *plVar1;
          *plVar1 = this;
          il2cpp_internal(plVar1,this);
          if (this.mLegacyEvent != null) {
            OnClickCB.Invoke(this.mLegacyEvent,this.mSelectedItem,0);
          }
          uVar3 = this.onChange;
          cVar5 = EventDelegate.IsValid(uVar3,0);
          if (!cVar5) {
            uVar3 = this.eventReceiver;
            cVar5 = Object.op_Inequality(uVar3,0,0);
            if (cVar5) {
              cVar5 = FUN_180d755b0(this.functionName,0);
              if (!cVar5) {
                if (this.eventReceiver == null) goto LAB_1811a53fe;
                GameObject.SendMessage
                          (this.eventReceiver,this.functionName,
                           this.mSelectedItem,1,0);
              }
            }
          }
          else {
            uVar3 = this.onChange;
            EventDelegate.Execute(uVar3,0);
          }
          if (this.items == null) {
        LAB_1811a53fe:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar6 = FUN_1817eb4e0(this.items,this.mSelectedItem,
                                DAT_181da3fd8);
          if (-1 < (int)uVar6) {
            lVar4 = this.itemCallbacks;
            if (lVar4 == null) goto LAB_1811a53fe;
            if ((int)uVar6 < (int)lVar4.Count) {
              if (lVar4.Count <= uVar6) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar4 = lVar4._items[uVar6];
              if (lVar4 != null) {
                FUN_18043cbb0(lVar4,0);
              }
            }
          }
          plVar1 = pStatics;
          *plVar1 = lVar2;
          il2cpp_internal(plVar1,lVar2);
          this.mExecuting = 0;
        }
    }

    // Token : 0x60001F6
    // RVA   : 0x11A1F00   Offset: 0x11A1300   Length: 0x1BC
    protected virtual void OnEnable()
    {
        bool cVar1;
        int iVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        uVar6 = this.onChange;
        cVar1 = EventDelegate.IsValid(uVar6,0);
        if (cVar1) {
          this.eventReceiver = 0;
          this.functionName = 0;
        }
        lVar4 = UIPopupList.get_font(this,0);
        if (this.textScale != null.0) {
          if (lVar4 == null) {
            uVar3 = 16;
          }
          else {
            iVar2 = FUN_180002970(22,DAT_181d7a800,lVar4);
            uVar3 = Mathf.RoundToInt((float)iVar2 * this.textScale,0);
          }
          this.fontSize = uVar3;
          this.textScale = 0;
        }
        uVar6 = this.trueTypeFont;
        cVar1 = Object.op_Equality(uVar6,0,0);
        if ((((cVar1) && (lVar4 != null)) &&
            (cVar1 = FUN_180002970(28,DAT_181d7a800,lVar4), cVar1)) &&
           (lVar5 = FUN_180002970(25,DAT_181d7a800,lVar4)) == null) {
          uVar6 = FUN_180002970(29,DAT_181d7a800,lVar4);
          this.trueTypeFont = uVar6;
          this.bitmapFont = 0;
        }
    }

    // Token : 0x60001F7
    // RVA   : 0x11A5020   Offset: 0x11A4420   Length: 0x165
    public virtual void Start()
    {
        long lVar2;
        long lVar3;
        bool cVar4;
        ulong uVar5;
        if (*(char *)((int64)this + 0x159) == false) {
          *(uint8 *)((int64)this + 0x159) = 1;
          plVar1 = this + 27;
          if (*(char *)((int64)this + 0x10c) == false) {
            *plVar1 = 0;
            il2cpp_internal();
          }
          else {
            lVar2 = *plVar1;
            *plVar1 = 0;
            il2cpp_internal();
            (**(code **)(*this + 0x188))(this,lVar2,*(uint64 *)(*this + 400));
          }
          plVar1 = this + 39;
          lVar2 = *plVar1;
          cVar4 = Object.op_Inequality(lVar2,0,0);
          if (cVar4) {
            lVar2 = *plVar1;
            lVar3 = this[26];
            uVar5 = new OnTooltipCB(lVar2,DAT_181dc5ef8,0);
            EventDelegate.Add(lVar3,uVar5,0);
            *plVar1 = 0;
            il2cpp_internal(plVar1,0);
          }
        }
    }

    // Token : 0x60001F8
    // RVA   : 0x11A24A0   Offset: 0x11A18A0   Length: 0x11
    protected virtual void OnLocalize()
    {
        void FUN_1811a24a0(int64 this)
        {
        if (this.isLocalized) {
          UIPopupList.TriggerCallbacks(this,0);
          return;
        }
    }

    // Token : 0x60001F9
    // RVA   : 0x11A1BB0   Offset: 0x11A0FB0   Length: 0x186
    protected virtual void Highlight(UILabel lbl, bool instant)
    {
        ulong uVar1;
        uint uVar2;
        bool cVar3;
        ulong uVar5;
        long lVar6;
        ulong local_28;
        uint local_20;
        lVar6 = this[30];
        cVar3 = Object.op_Inequality(lVar6,0,0);
        if (cVar3) {
          this[31] = lbl;
          il2cpp_internal(this + 31,lbl);
          puVar4 = (uint64 *)
                   (**(code **)(*this + 0x248))(&local_28,this,*(uint64 *)(*this + 0x250));
          uVar1 = *puVar4;
          uVar2 = *(uint32 *)(puVar4 + 1);
          if ((!instant) && ((char)this[23] != false)) {
            if (this[30] != 0) {
              uVar5 = Component.get_gameObject(this[30],0);
              local_28 = uVar1;
              local_20 = uVar2;
              lVar6 = TweenPosition.Begin(uVar5,0x3dcccccd,&local_28,0);
              if (lVar6 != null) {
                *(uint32 *)(lVar6 + 24) = 2;
                if (*(char *)((int64)this + 0x15a) != false) {
                  return;
                }
                *(uint8 *)((int64)this + 0x15a) = 1;
                MonoBehaviour.StartCoroutine(this,"UpdateTweenPosition",0);
                return;
              }
            }
          }
          else if ((this[30] != 0) &&
                  (lVar6 = UIRect.get_cachedTransform(this[30],0)) != null) {
            local_28 = uVar1;
            local_20 = uVar2;
            Transform.set_localPosition(lVar6,&local_28,0);
            return;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x60001FA
    // RVA   : 0x11A19B0   Offset: 0x11A0DB0   Length: 0x1F7
    protected virtual Vector3 GetHighlightPosition()
    {
        float fVar1;
        uint uVar2;
        ulong uVar3;
        bool cVar5;
        long lVar7;
        float fVar9;
        byte[] local_38 = new byte[16];
        float local_28;
        float fStack_24;
        float fStack_20;
        float fStack_1c;
        uVar3 = *(uint64 *)(param_2 + 248);
        cVar5 = Object.op_Equality(uVar3,0,0);
        if (!cVar5) {
          uVar3 = *(uint64 *)(param_2 + 240);
          cVar5 = Object.op_Equality(uVar3,0,0);
          if (!cVar5) {
            plVar4 = *(int64 **)(param_2 + 240);
            if (plVar4 != (int64 *)0) {
              pfVar6 = (float *)(**(code **)(*plVar4 + 0x378))
                                          (&local_28,plVar4,*(uint64 *)(*plVar4 + 0x380));
              fVar9 = 1.0;
              local_28 = *pfVar6;
              fStack_24 = pfVar6[1];
              fStack_20 = pfVar6[2];
              fStack_1c = pfVar6[3];
              lVar7 = il2cpp_internal(*(uint64 *)(param_2 + 24),DAT_181d7a788);
              if (lVar7 != null) {
                fVar9 = (float)FUN_180133520(5,DAT_181d7a788,lVar7);
              }
              if (*(int64 *)(param_2 + 248) != 0) {
                lVar7 = UIRect.get_cachedTransform(*(int64 *)(param_2 + 248),0);
                if (lVar7 != null) {
                  puVar8 = (uint64 *)Transform.get_localPosition(local_38,lVar7,0);
                  fVar1 = *(float *)(puVar8 + 1);
                  *this = CONCAT44(fStack_1c * fVar9 + (float)((uint64)*puVar8 >> 32),
                                      -(local_28 * fVar9) + (float)*puVar8);
                  *(float *)(this + 1) = fVar1 + 1.0;
                  return this;
                }
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        puVar8 = (uint64 *)Vector3.get_zero(local_38,0);
        uVar2 = *(uint32 *)(puVar8 + 1);
        *this = *puVar8;
        *(uint32 *)(this + 1) = uVar2;
        return this;
    }

    // Token : 0x60001FB
    // RVA   : 0x11A5410   Offset: 0x11A4810   Length: 0x6C
    protected virtual IEnumerator UpdateTweenPosition()
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          return lVar1;
        }
    }

    // Token : 0x60001FC
    // RVA   : 0x11A2290   Offset: 0x11A1690   Length: 0x7D
    protected virtual void OnItemHover(GameObject go, bool isOver)
    {
        ulong uVar1;
        if (isOver) {
          if (go == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar1 = GameObject.GetComponent(go,DAT_181d74a98);
          (**(code **)(*this + 0x238))(this,uVar1,0,*(uint64 *)(*this + 0x240));
        }
    }

    // Token : 0x60001FD
    // RVA   : 0x11A2310   Offset: 0x11A1710   Length: 0x1D
    protected virtual void OnItemPress(GameObject go, bool isPressed)
    {
        void FUN_1811a2310(int64 *this,uint64 go,char isPressed)
        {
        if ((isPressed) && (*(int *)((int64)this + 92) == 0)) {
                          // WARNING: Could not recover jumptable at 0x0001811a2325. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*this + 0x288))(this,go,*(uint64 *)(*this + 0x290));
          return;
        }
    }

    // Token : 0x60001FE
    // RVA   : 0x11A20C0   Offset: 0x11A14C0   Length: 0x1CB
    protected virtual void OnItemClick(GameObject go)
    {
        uint uVar1;
        int iVar2;
        long lVar4;
        ulong uVar5;
        long lVar6;
        uint uVar8;
        if (go != null) {
          uVar5 = GameObject.GetComponent(go,DAT_181d74a98);
          (**(code **)(*this + 0x238))(this,uVar5,1,*(uint64 *)(*this + 0x240));
          lVar6 = GameObject.GetComponent(go,DAT_181d747f0);
          if (lVar6 != null) {
            plVar3 = *(int64 **)(lVar6 + 24);
            plVar9 = (int64 *)0;
            plVar7 = plVar9;
            if ((plVar3 != (int64 *)0) && (plVar7 = (int64 *)0, *plVar3 == DAT_181da7690)) {
              plVar7 = plVar3;
            }
            (**(code **)(*this + 0x188))(this,plVar7,*(uint64 *)(*this + 400));
            lVar6 = Component.GetComponents(this,DAT_181d98160);
            if (lVar6 != null) {
              iVar2 = *(int *)(lVar6 + 24);
              if (0 < iVar2) {
                do {
                  uVar8 = (uint32)plVar9;
                  if (*(uint32 *)(lVar6 + 24) <= uVar8) {
                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar5,0);
                  }
                  lVar4 = lVar6[uVar8];
                  if (lVar4 == null) throw; // [null/range check failed]
                  if (*(int *)(lVar4 + 32) == 0) {
                    uVar5 = *(uint64 *)(lVar4 + 24);
                    uVar1 = *(uint32 *)(lVar4 + 36);
                    NGUITools.PlaySound(uVar5,uVar1,0x3f800000,0);
                  }
                  plVar9 = (int64 *)(uint64)(uVar8 + 1);
                } while ((int)(uVar8 + 1) < iVar2);
              }
                          // WARNING: Could not recover jumptable at 0x0001811a226f. Too many branches
                          // WARNING: Treating indirect jump as call
              (**(code **)(*this + 0x2d8))(this,*(uint64 *)(*this + 0x2e0));
              return;
            }
          }
        }
    }

    // Token : 0x60001FF
    // RVA   : 0x11A2A70   Offset: 0x11A1E70   Length: 0x11
    private void Select(UILabel lbl, bool instant)
    {
        void FUN_1811a2a70(int64 *this)
        {
                          // WARNING: Could not recover jumptable at 0x0001811a2a7a. Too many branches
                          // WARNING: Treating indirect jump as call
        (**(code **)(*this + 0x238))();
    }

    // Token : 0x6000200
    // RVA   : 0x11A24C0   Offset: 0x11A18C0   Length: 0x173
    protected virtual void OnNavigate(KeyCode key)
    {
        bool cVar1;
        int iVar2;
        ulong uVar3;
        long lVar4;
        cVar1 = Behaviour.get_enabled(this,0);
        if (cVar1) {
          uVar3 = **(uint64 **)(DAT_181dafff8 + 184);
          cVar1 = Object.op_Equality(uVar3,this,0);
          if (cVar1) {
            if (this[32] == 0) {
        LAB_1811a262e:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            iVar2 = FUN_1817eb4e0(this[32],this[31],DAT_181da9d98);
            if (iVar2 == -1) {
              iVar2 = 0;
            }
            if (key == 0x111) {
              if (iVar2 < 1) {
                return;
              }
              lVar4 = this[32];
              if (lVar4 == null) goto LAB_1811a262e;
              iVar2 = iVar2 + -1;
            }
            else {
              if (key != 0x112) {
                return;
              }
              lVar4 = this[32];
              if (lVar4 == null) goto LAB_1811a262e;
              iVar2 = iVar2 + 1;
              if (*(int *)(lVar4 + 24) <= iVar2) {
                return;
              }
            }
            uVar3 = FUN_180002f80(lVar4,iVar2,DAT_181da9e98);
            (**(code **)(*this + 0x238))(this,uVar3,0,*(uint64 *)(*this + 0x240));
          }
        }
    }

    // Token : 0x6000201
    // RVA   : 0x11A2330   Offset: 0x11A1730   Length: 0x163
    protected virtual void OnKey(KeyCode key)
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        ulong uVar1;
        long lVar2;
        bool cVar3;
        cVar3 = Behaviour.get_enabled(this,0);
        if (cVar3) {
          uVar1 = **(uint64 **)(DAT_181dafff8 + 184);
          cVar3 = Object.op_Equality(uVar1,this,0);
          if (cVar3) {
            lVar2 = *(int64 *)(pStatics + 184);
            if (lVar2 == null) {
        LAB_1811a248e:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (key != *(int *)(lVar2 + 132)) {
              lVar2 = *(int64 *)(pStatics + 184);
              if (lVar2 == null) goto LAB_1811a248e;
              if (key != *(int *)(lVar2 + 136)) {
                return;
              }
            }
            (**(code **)(*this + 0x2c8))(this,0,*(uint64 *)(*this + 0x2d0));
          }
        }
    }

    // Token : 0x6000202
    // RVA   : 0xFCDA30   Offset: 0xFCCE30   Length: 0x11
    protected virtual void OnDisable()
    {
        void FUN_180fcda30(int64 *this)
        {
                          // WARNING: Could not recover jumptable at 0x000180fcda3a. Too many branches
                          // WARNING: Treating indirect jump as call
        (**(code **)(*this + 0x2d8))(this,*(uint64 *)(*this + 0x2e0));
    }

    // Token : 0x6000203
    // RVA   : 0x11A2640   Offset: 0x11A1A40   Length: 0x264
    protected virtual void OnSelect(bool isSelected)
    {
        var pStatics = *(int64*)(DAT_181dafff8 + 184);
        long lVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        if (!isSelected) {
          lVar3 = UICamera.get_selectedObject(0);
          cVar2 = Object.op_Equality(lVar3,0,0);
          if (!cVar2) {
            uVar4 = *(uint64 *)(pStatics + 8);
            cVar2 = Object.op_Equality(lVar3,uVar4,0);
            if (cVar2) {
              return;
            }
            uVar4 = *(uint64 *)(pStatics + 8);
            cVar2 = Object.op_Inequality(uVar4,0,0);
            if (cVar2) {
              cVar2 = Object.op_Inequality(lVar3,0,0);
              if (cVar2) {
                lVar1 = *(int64 *)(pStatics + 8);
                if ((lVar1 == null) || (uVar4 = GameObject.get_transform(lVar1,0), lVar3 == null)) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                uVar5 = GameObject.get_transform(lVar3,0);
                cVar2 = NGUITools.IsChild(uVar4,uVar5,0);
                if (cVar2) {
                  return;
                }
              }
            }
          }
          (**(code **)(*this + 0x2d8))(this,*(uint64 *)(*this + 0x2e0));
        }
    }

    // Token : 0x6000204
    // RVA   : 0x11A18A0   Offset: 0x11A0CA0   Length: 0x102
    public static void Close()
    {
        ulong uVar1;
        bool cVar4;
        uVar1 = **(uint64 **)(DAT_181dafff8 + 184);
        cVar4 = Object.op_Inequality(uVar1,0,0);
        if (cVar4) {
          plVar2 = (int64 *)**(int64 **)(DAT_181dafff8 + 184);
          if (plVar2 != (int64 *)0) {
            (**(code **)(*plVar2 + 0x2d8))(plVar2,*(uint64 *)(*plVar2 + 0x2e0));
            puVar3 = *(uint64 **)(DAT_181dafff8 + 184);
            *puVar3 = 0;
            il2cpp_internal(puVar3,0);
            return;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x6000205
    // RVA   : 0x11A13F0   Offset: 0x11A07F0   Length: 0x4A6
    public virtual void CloseSelf()
    {
        var pStatics = *(int64*)(DAT_181dafff8 + 184);
        int iVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        uint uVar7;
        uint uVar8;
        float fVar9;
        float fVar10;
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        uVar4 = *(uint64 *)(pStatics + 8);
        cVar2 = Object.op_Inequality(uVar4,0,0);
        if (cVar2) {
          uVar4 = **(uint64 **)(DAT_181dafff8 + 184);
          cVar2 = Object.op_Equality(uVar4,this,0);
          if (cVar2) {
            MonoBehaviour.StopCoroutine(this,"CloseIfUnselected",0);
            uVar8 = 0;
            this.mSelection = 0;
            if (this.mLabelList == null) goto LAB_1811a1871;
            FUN_1812f9a10(this.mLabelList,DAT_181da9d18);
            if (!this.isAnimated) {
              uVar4 = *(uint64 *)(pStatics + 8);
              Object.Destroy(uVar4,0);
              fVar9 = (float)Time.get_unscaledTime(0);
              fVar9 = fVar9 + 0.1;
            }
            else {
              lVar3 = *(int64 *)(pStatics + 8);
              if (lVar3 == null) {
        LAB_1811a1871:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar3 = FUN_1809674e0(lVar3,DAT_181d755c0);
              if (lVar3 == null) goto LAB_1811a1871;
              iVar1 = *(int *)(lVar3 + 24);
              uVar7 = uVar8;
              if (0 < iVar1) {
                do {
                  if (*(uint32 *)(lVar3 + 24) <= uVar7) {
                    uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar4,0);
                  }
                  lVar5 = lVar3[uVar7];
                  if (lVar5 == null) goto LAB_1811a1871;
                  local_38 = *(uint32 *)(lVar5 + 144);
                  uStack_34 = *(uint32 *)(lVar5 + 148);
                  uStack_30 = *(uint32 *)(lVar5 + 152);
                  uStack_2c = 0;
                  uVar4 = Component.get_gameObject();
                  lVar5 = TweenColor.Begin(uVar4,0x3e19999a,&local_38,0);
                  if (lVar5 == null) goto LAB_1811a1871;
                  uVar7 = uVar7 + 1;
                  *(uint32 *)(lVar5 + 24) = 2;
                } while ((int)uVar7 < iVar1);
              }
              lVar3 = *(int64 *)(pStatics + 8);
              if (lVar3 == null) goto LAB_1811a1871;
              lVar3 = FUN_1809674e0(lVar3,DAT_181d750f8);
              if (lVar3 == null) goto LAB_1811a1871;
              iVar1 = *(int *)(lVar3 + 24);
              if (0 < iVar1) {
                do {
                  if (*(uint32 *)(lVar3 + 24) <= uVar8) {
                    uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar4,0);
                  }
                  lVar5 = lVar3[uVar8];
                  if (lVar5 == null) goto LAB_1811a1871;
                  Collider.set_enabled(lVar5,0,0);
                  uVar8 = uVar8 + 1;
                } while ((int)uVar8 < iVar1);
              }
              uVar4 = *(uint64 *)(pStatics + 8);
              Object.Destroy(uVar4,0x3e19999a,0);
              fVar10 = (float)Time.get_unscaledTime(0);
              fVar9 = (float)Mathf.Max(0x3dcccccd,0x3e19999a,0);
              fVar9 = fVar9 + fVar10;
            }
            *(float *)(pStatics + 16) = fVar9;
            this.mBackground = 0;
            this.mHighlight = 0;
            puVar6 = (uint64 *)(pStatics + 8);
            *puVar6 = 0;
            il2cpp_internal(puVar6,0);
            puVar6 = *(uint64 **)(DAT_181dafff8 + 184);
            *puVar6 = 0;
            il2cpp_internal(puVar6,0);
          }
        }
    }

    // Token : 0x6000206
    // RVA   : 0x11A0E70   Offset: 0x11A0270   Length: 0xEE
    protected virtual void AnimateColor(UIWidget widget)
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        uint uVar4;
        ulong uVar5;
        long lVar6;
        uint local_58;
        uint uStack_54;
        uint uStack_50;
        uint32 uStack_4c;
        uint64 local_48;
        uint64 uStack_40;
        if (widget != null) {
          uVar1 = *(uint32 *)(widget + 144);
          uVar2 = *(uint32 *)(widget + 148);
          uVar3 = *(uint32 *)(widget + 152);
          uVar4 = *(uint32 *)(widget + 156);
          local_48 = 0;
          uStack_40 = 0;
          FUN_1809dc910(&local_48,uVar1,uVar2,uVar3,0,0);
          local_58 = (uint32)local_48;
          uStack_54 = local_48._4_4_;
          uStack_50 = (uint32)uStack_40;
          uStack_4c = uStack_40._4_4_;
          UIWidget.set_color(widget,&local_58,0);
          uVar5 = Component.get_gameObject(widget,0);
          local_58 = uVar1;
          uStack_54 = uVar2;
          uStack_50 = uVar3;
          uStack_4c = uVar4;
          lVar6 = TweenColor.Begin(uVar5,0x3e19999a,&local_58,0);
          if (lVar6 != null) {
            *(uint32 *)(lVar6 + 24) = 2;
            return;
          }
        }
    }

    // Token : 0x6000207
    // RVA   : 0x11A0F60   Offset: 0x11A0360   Length: 0x111
    protected virtual void AnimatePosition(UIWidget widget, bool placeAbove, float bottom)
    {
        void UIPopupList.AnimatePosition
                     (uint64 this,int64 widget,char placeAbove,uint32 bottom)
        {
        uint64 uVar1;
        uint32 uVar2;
        uint32 uVar3;
        int64 lVar4;
        uint64 *puVar5;
        uint64 uVar6;
        uint64 local_48;
        uint32 local_40;
        uint8 local_38 [48];
        if ((widget != null) && (lVar4 = UIRect.get_cachedTransform(widget,0)) != null) {
          puVar5 = (uint64 *)Transform.get_localPosition(local_38,lVar4,0);
          uVar1 = *puVar5;
          uVar2 = *(uint32 *)(puVar5 + 1);
          local_48._0_4_ = (uint32)uVar1;
          uVar3 = (uint32)local_48;
          if (!placeAbove) {
            bottom = 0;
          }
          local_48 = uVar1;
          lVar4 = UIRect.get_cachedTransform(widget,0);
          if (lVar4 != null) {
            local_48 = CONCAT44(bottom,uVar3);
            local_40 = uVar2;
            Transform.set_localPosition(lVar4,&local_48,0);
            uVar6 = Component.get_gameObject(widget,0);
            local_48 = uVar1;
            local_40 = uVar2;
            lVar4 = TweenPosition.Begin(uVar6,0x3e19999a,&local_48,0);
            if (lVar4 != null) {
              *(uint32 *)(lVar4 + 24) = 2;
              return;
            }
          }
        }
    }

    // Token : 0x6000208
    // RVA   : 0x11A1080   Offset: 0x11A0480   Length: 0x1FA
    protected virtual void AnimateScale(UIWidget widget, bool placeAbove, float bottom)
    {
        ulong uVar1;
        uint uVar2;
        int iVar3;
        ulong uVar4;
        long lVar5;
        long lVar7;
        float fVar8;
        float fVar9;
        ulong local_78;
        float local_70;
        byte[] local_68 = new byte[8];
        uint local_60;
        byte[] local_58 = new byte[64];
        if (widget != null) {
          uVar4 = Component.get_gameObject(widget,0);
          lVar5 = UIRect.get_cachedTransform(widget,0);
          fVar8 = (float)UIPopupList.get_fitScale(this,0);
          iVar3 = UIPopupList.get_activeFontSize(this,0);
          fVar9 = (float)UIPopupList.get_activeFontScale(this,0);
          fVar9 = ((float)iVar3 * fVar9 + this.mBgBorder + this.mBgBorder) *
                  fVar8;
          if (lVar5 != null) {
            local_78 = CONCAT44(fVar9 / (float)*(int *)(widget + 168),fVar8);
            local_70 = fVar8;
            Transform.set_localScale(lVar5,&local_78,0);
            puVar6 = (uint64 *)Vector3.get_one(local_68,0);
            local_78 = *puVar6;
            local_70 = *(float *)(puVar6 + 1);
            lVar7 = TweenScale.Begin(uVar4,0x3e19999a,&local_78,0);
            if (lVar7 != null) {
              *(uint32 *)(lVar7 + 24) = 2;
              if (placeAbove) {
                puVar6 = (uint64 *)Transform.get_localPosition(local_58,lVar5,0);
                uVar2 = *(uint32 *)(puVar6 + 1);
                uVar1 = *puVar6;
                local_78 = CONCAT44(((float)((uint64)uVar1 >> 32) -
                                    (float)*(int *)(widget + 168) * fVar8) + fVar9,(int)uVar1);
                local_70 = (float)uVar2;
                local_60 = uVar2;
                Transform.set_localPosition(lVar5,&local_78,0);
                local_78 = uVar1;
                local_70 = (float)uVar2;
                lVar5 = TweenPosition.Begin(uVar4,0x3e19999a,&local_78,0);
                if (lVar5 == null) throw; // [null/range check failed]
                *(uint32 *)(lVar5 + 24) = 2;
              }
              return;
            }
          }
        }
    }

    // Token : 0x6000209
    // RVA   : 0x11A1280   Offset: 0x11A0680   Length: 0x68
    protected void Animate(UIWidget widget, bool placeAbove, float bottom)
    {
        void UIPopupList.Animate
                     (int64 *this,uint64 widget,uint8 placeAbove,uint32 bottom)
        {
        (**(code **)(*this + 0x2e8))(this,widget,*(uint64 *)(*this + 0x2f0));
                          // WARNING: Could not recover jumptable at 0x0001811a12e1. Too many branches
                          // WARNING: Treating indirect jump as call
        (**(code **)(*this + 0x2f8))(this,widget,placeAbove,bottom);
    }

    // Token : 0x600020A
    // RVA   : 0x11A1D40   Offset: 0x11A1140   Length: 0x19B
    protected virtual void OnClick()
    {
        long lVar1;
        bool cVar2;
        int iVar3;
        ulong uVar4;
        lVar1 = this[35];
        iVar3 = Time.get_frameCount(0);
        if ((int)lVar1 != iVar3) {
          uVar4 = *(uint64 *)(*(int64 *)(DAT_181dafff8 + 184) + 8);
          cVar2 = Object.op_Equality(uVar4,0,0);
          if (!cVar2) {
            lVar1 = this[31];
            cVar2 = Object.op_Inequality(lVar1,0,0);
            if (cVar2) {
              if (this[31] == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar4 = Component.get_gameObject(this[31],0);
                          // WARNING: Could not recover jumptable at 0x0001811a1e66. Too many branches
                          // WARNING: Treating indirect jump as call
              (**(code **)(*this + 0x278))(this,uVar4,1,*(uint64 *)(*this + 0x280));
              return;
            }
          }
          else if (1 < (int)this[25] - 2U) {
            if ((int)this[25] == 1) {
              if (*(int *)(*(int64 *)(DAT_181daf678 + 184) + 212) != -2) {
                return;
              }
            }
            (**(code **)(*this + 0x338))(this,*(uint64 *)(*this + 0x340));
          }
        }
    }

    // Token : 0x600020B
    // RVA   : 0x11A1EE0   Offset: 0x11A12E0   Length: 0x1B
    protected virtual void OnDoubleClick()
    {
        void FUN_1811a1ee0(int64 *this)
        {
        if ((int)this[25] == 2) {
                          // WARNING: Could not recover jumptable at 0x0001811a1ef3. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*this + 0x338))(this,*(uint64 *)(*this + 0x340));
          return;
        }
    }

    // Token : 0x600020C
    // RVA   : 0x11A1380   Offset: 0x11A0780   Length: 0x6C
    private IEnumerator CloseIfUnselected()
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          return lVar1;
        }
    }

    // Token : 0x600020D
    // RVA   : 0x11A2B20   Offset: 0x11A1F20   Length: 0x24FC
    public virtual void Show()
    {
        var pStatics_0178 = *(int64*)(DAT_181db0178 + 184);
        var pStatics_fe78 = *(int64*)(DAT_181dafe78 + 184);
        var pStatics_fff8 = *(int64*)(DAT_181dafff8 + 184);
        ulong uVar1;
        ulong uVar2;
        byte[] auVar4 = new byte[12];
        float fVar5;
        ulong uVar6;
        ulong uVar7;
        bool cVar8;
        uint uVar9;
        int iVar10;
        uint uVar11;
        ulong uVar12;
        long lVar13;
        long lVar15;
        long lVar16;
        ulong uVar18;
        long lVar20;
        uint uVar23;
        float fVar26;
        float fVar27;
        float fVar28;
        float fVar29;
        ulong local_res18;
        uint[] local_res20 = new uint[2];
        ulong in_stack_fffffffffffffdd8;
        ulong local_218;
        float local_210;
        ulong local_208;
        uint local_200;
        uint64 local_1f8;
        uint32 local_1f0;
        uint64 local_1e8;
        uint32 local_1e0;
        uint64 local_1d8;
        uint64 local_1c8;
        float local_1c0;
        float local_1b8;
        float local_1b4;
        float local_1b0;
        float local_1ac;
        uint32 local_1a8;
        uint32 local_1a4;
        uint32 local_1a0;
        int64 local_198;
        int64 lStack_190;
        uint64 local_188;
        uint32 local_180;
        uint64 local_178;
        uint32 local_170;
        uint64 local_168;
        float local_160;
        float local_158;
        float fStack_154;
        uint64 local_150;
        uint64 local_148;
        uint64 uStack_140;
        uint64 local_128;
        float local_120;
        int64 local_118;
        int64 local_110;
        uint64 local_108;
        int64 lStack_100;
        uint64 local_f8;
        uint64 uStack_f0;
        uint64 local_e8;
        plVar21 = (int64 *)0;
        local_1e8 = 0;
        local_1e0 = 0;
        local_188 = 0;
        local_180 = 0;
        local_178 = 0;
        local_170 = 0;
        local_128 = 0;
        local_120 = 0.0;
        local_f8 = 0;
        uStack_f0 = 0;
        local_e8 = 0;
        local_res20[0] = 0;
        cVar8 = Behaviour.get_enabled(this,0);
        if (!cVar8) {
        LAB_1811a4f76:
          (**(code **)(*this + 0x2c8))(this,0,*(uint64 *)(*this + 0x2d0));
          return;
        }
        uVar12 = Component.get_gameObject(this,0);
        cVar8 = NGUITools.GetActive(uVar12,0);
        if (!cVar8) goto LAB_1811a4f76;
        uVar12 = *(uint64 *)(pStatics_fff8 + 8);
        cVar8 = Object.op_Equality(uVar12,0,0);
        if (!cVar8) goto LAB_1811a4f76;
        lVar13 = this[5];
        cVar8 = Object.op_Inequality(lVar13,0,0);
        if (!cVar8) {
          lVar13 = this[4];
          cVar8 = Object.op_Inequality(lVar13,0,0);
          plVar24 = plVar21;
          if ((cVar8) && (plVar24 = (int64 *)this[4], plVar24 != (int64 *)0)) {
            plVar14 = plVar21;
            if (*plVar24 == DAT_181d72e60) {
              plVar14 = plVar24;
            }
            if (plVar14 != (int64 *)0) {
              plVar14 = plVar21;
              if (*plVar24 == DAT_181d72e60) {
                plVar14 = plVar24;
              }
              plVar24 = (int64 *)GameObject.GetComponent(plVar14,DAT_181d74878);
            }
          }
        }
        else {
          plVar24 = (int64 *)this[5];
        }
        cVar8 = Object.op_Inequality(plVar24,0,0);
        if (!cVar8) goto LAB_1811a4f76;
        if (this[13] == 0) throw; // [null/range check failed]
        if (*(int *)(this[13] + 24) < 1) goto LAB_1811a4f76;
        if (this[32] == 0) throw; // [null/range check failed]
        FUN_1812f9a10(this[32],DAT_181da9d18);
        MonoBehaviour.StopCoroutine(this,"CloseIfUnselected",0);
        lVar13 = UICamera.get_hoveredObject(0);
        if (lVar13 == null) {
          lVar13 = Component.get_gameObject(this,0);
        }
        UICamera.set_selectedObject(lVar13,0);
        lVar13 = UICamera.get_selectedObject(0);
        this[34] = lVar13;
        il2cpp_internal(this + 34,lVar13);
        this[44] = this[34];
        il2cpp_internal(this + 44);
        lVar13 = this[44];
        cVar8 = Object.op_Equality(lVar13,0,0);
        if (cVar8) {
          Debug.LogError("Popup list needs a source object...",0);
          return;
        }
        uVar9 = Time.get_frameCount(0);
        *(uint32 *)(this + 35) = uVar9;
        plVar24 = this + 28;
        lVar13 = *plVar24;
        cVar8 = Object.op_Equality(lVar13,0,0);
        if (cVar8) {
          lVar13 = Component.get_transform(this,0);
          plVar14 = (int64 *)NGUITools.FindInParents(lVar13,DAT_181d8f6a0);
          cVar8 = Object.op_Inequality(plVar14,0,0);
          if (!cVar8) {
            for (; lVar13 != null; lVar13 = FUN_180da9a20(lVar13,0)) {
              uVar12 = FUN_180da9a20(lVar13,0);
              cVar8 = Object.op_Inequality(uVar12,0,0);
              plVar14 = plVar21;
              if (!(!cVar8))
              {
                if (lVar13 == null) break;
                }
                throw; // [null/range check failed]
                }
              }
          *plVar24 = (int64)plVar14;
          il2cpp_internal(plVar24,plVar14);
          lVar13 = *plVar24;
          cVar8 = Object.op_Equality(lVar13,0,0);
          if (cVar8) {
            return;
          }
        }
        uVar12 = new GameObject("Drop-down List",0);
        puVar22 = (uint64 *)(pStatics_fff8 + 8);
        *puVar22 = uVar12;
        il2cpp_internal(puVar22,uVar12);
        lVar13 = *(int64 *)(pStatics_fff8 + 8);
        lVar15 = Component.get_gameObject(this,0);
        if ((lVar15 == null) || (uVar9 = GameObject.get_layer(lVar15,0), lVar13 == null)) throw; // [null/range check failed]
        GameObject.set_layer(lVar13,uVar9,0);
        if ((char)this[24] != false) {
          uVar12 = Component.GetComponent(this,DAT_181d93b60);
          cVar8 = Object.op_Inequality(uVar12,0,0);
          if (!cVar8) {
            uVar12 = Component.GetComponent(this,DAT_181d93be0);
            cVar8 = Object.op_Inequality(uVar12,0,0);
            if (cVar8) {
              lVar13 = *(int64 *)(pStatics_fff8 + 8);
              if ((lVar13 == null) || (lVar13 = GameObject.AddComponent(lVar13,DAT_181dc5b98)) == null)
              throw; // [null/range check failed]
              Rigidbody2D.set_isKinematic(lVar13,1,0);
            }
          }
          else {
            lVar13 = *(int64 *)(pStatics_fff8 + 8);
            if ((lVar13 == null) || (lVar13 = GameObject.AddComponent(lVar13,DAT_181dc5b10)) == null)
            throw; // [null/range check failed]
            Rigidbody.set_isKinematic(lVar13,1,0);
          }
          lVar13 = *(int64 *)(pStatics_fff8 + 8);
          if ((lVar13 == null) || (lVar13 = GameObject.AddComponent(lVar13,DAT_181dc6c10)) == null)
          throw; // [null/range check failed]
          if (*(int *)(lVar13 + 0x150) != 1000000) {
            *(uint32 *)(lVar13 + 0x150) = 1000000;
            lVar15 = *pStatics_fe78;
            uVar12 = new OnTooltipCB(0,DAT_181dc5f80,DAT_181dab8b8);
            if (lVar15 == null) throw; // [null/range check failed]
            List_1.Sort(lVar15,uVar12,DAT_181daa218);
          }
          if (*plVar24 == 0) throw; // [null/range check failed]
          iVar10 = *(int *)(*plVar24 + 0x154);
          if (*(int *)(lVar13 + 0x154) != iVar10) {
            *(int *)(lVar13 + 0x154) = iVar10;
            if (*pStatics_fe78 == 0) throw; // [null/range check failed]
            uVar9 = FUN_1817eb4e0(*pStatics_fe78,lVar13,DAT_181daa118);
            UIPanel.UpdateDrawCalls(lVar13,uVar9,0);
          }
        }
        puVar22 = *(uint64 **)(DAT_181dafff8 + 184);
        *puVar22 = this;
        il2cpp_internal(puVar22,this);
        if (*plVar24 == 0) throw; // [null/range check failed]
        lVar15 = UIRect.get_cachedTransform(*plVar24,0);
        lVar13 = *(int64 *)(pStatics_fff8 + 8);
        local_110 = lVar15;
        if ((lVar13 == null) ||
           (lVar13 = GameObject.get_transform(lVar13,0), local_1d8 = lVar13) == null)
        throw; // [null/range check failed]
        Transform.set_parent(lVar13,lVar15,0);
        local_118 = lVar15;
        if ((char)this[24] != false) {
          if (*plVar24 == 0) throw; // [null/range check failed]
          lVar16 = Component.GetComponentInParent(*plVar24,DAT_181d97e60);
          cVar8 = Object.op_Equality(lVar16,0,0);
          if (cVar8) {
            if (*pStatics_0178 == 0) throw; // [null/range check failed]
            if (*(int *)(*pStatics_0178 + 24) != 0) {
              lVar16 = *pStatics_0178;
              if (lVar16 == null) throw; // [null/range check failed]
              if (*(int *)(lVar16 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar16 = *(int64 *)(*(int64 *)(lVar16 + 16) + 32);
            }
          }
          cVar8 = Object.op_Inequality(lVar16,0,0);
          if (cVar8) {
            if (lVar16 == null) throw; // [null/range check failed]
            local_118 = Component.get_transform(lVar16,0);
          }
        }
        if ((int)this[25] == 3) {
          lVar13 = this[34];
          uVar12 = Component.get_gameObject(this,0);
          cVar8 = Object.op_Inequality(lVar13,uVar12,0);
          lVar13 = local_1d8;
          if (!cVar8) goto LAB_1811a3a20;
          lVar13 = UICamera.get_lastEventPosition(0);
          local_210 = 0.0;
          this[40] = lVar13;
          *(uint32 *)(this + 41) = 0;
          if ((*plVar24 == 0) || (lVar13 = UIRect.get_anchorCamera(*plVar24,0)) == null)
          throw; // [null/range check failed]
          local_200 = (uint32)this[41];
          local_208 = this[40];
          puVar22 = (uint64 *)Camera.ScreenToWorldPoint(&local_218,lVar13,&local_208,0);
          if (lVar15 == null) throw; // [null/range check failed]
          local_208 = *puVar22;
          local_200 = *(uint32 *)(puVar22 + 1);
          puVar17 = (uint64 *)Transform.InverseTransformPoint(&local_218,lVar15,&local_208,0);
          lVar13 = local_1d8;
          local_208 = *puVar17;
          local_200 = (uint32)puVar17[1];
          local_1f8._4_4_ = (float)(local_208 >> 32);
          local_1b4 = local_1f8._4_4_;
          local_1ac = local_1f8._4_4_;
          local_1f8 = local_208;
          local_1f0 = local_200;
          local_1e0 = local_200;
          local_1a8 = local_200;
          local_1a4 = local_200;
          local_150 = local_208;
          Transform.set_localPosition(local_1d8,&local_208,0);
          plVar14 = (int64 *)Transform.get_position(&local_218,lVar13,0);
          local_1a0 = local_1e0;
          this[40] = *plVar14;
        }
        else {
        LAB_1811a3a20:
          uVar12 = Component.get_transform(this,0);
          puVar22 = (uint64 *)
                    NGUIMath.CalculateRelativeWidgetBounds
                              (&local_148,lVar15,uVar12,0,in_stack_fffffffffffffdd8 & 0xffffffffffffff00,0
                              );
          local_f8 = *puVar22;
          uStack_f0 = puVar22[1];
          local_e8 = puVar22[2];
          puVar17 = (uint64 *)Bounds.get_min(&local_218,&local_f8,0);
          uVar9 = (uint32)puVar17[1];
          uVar1 = *puVar17;
          local_1f8 = uVar1;
          local_1f0 = uVar9;
          local_1a4 = uVar9;
          puVar17 = (uint64 *)Bounds.get_max(&local_218,&local_f8,0);
          uVar2 = *puVar17;
          local_1a0 = (uint32)puVar17[1];
          local_208 = uVar1;
          local_200 = uVar9;
          Transform.set_localPosition(lVar13,&local_208,0);
          plVar14 = (int64 *)Transform.get_position(&local_218,lVar13,0);
          this[40] = *plVar14;
          local_1a8 = local_1f0;
          local_1b4 = local_1f8._4_4_;
          local_150 = local_1f8 & 0xffffffff;
          local_1e8 = uVar2;
          local_1ac = (float)(uVar2 >> 32);
        }
        *(int *)(this + 41) = (int)plVar14[1];
        MonoBehaviour.StartCoroutine(this,"CloseIfUnselected",0);
        fVar26 = (float)UIPopupList.get_fitScale(this,0);
        local_1b0 = fVar26;
        puVar17 = (uint64 *)Quaternion.get_identity(&local_148,0);
        local_148 = *puVar17;
        uStack_140 = puVar17[1];
        Transform.set_localRotation(lVar13,&local_148,0);
        local_1c8 = CONCAT44(fVar26,fVar26);
        local_1c0 = fVar26;
        Transform.set_localScale(lVar13,&local_1c8,0);
        plVar14 = plVar21;
        if ((char)this[24] == false) {
          if (*plVar24 == 0) throw; // [null/range check failed]
          uVar12 = Component.get_gameObject(*plVar24,0);
          uVar23 = NGUITools.CalculateNextDepth(uVar12,0);
          plVar14 = (int64 *)(uint64)uVar23;
        }
        lVar13 = this[9];
        cVar8 = Object.op_Inequality(lVar13,0,0);
        if (!cVar8) {
          lVar13 = this[3];
          cVar8 = Object.op_Inequality(lVar13,0,0);
          if (!cVar8) {
            return;
          }
          lVar13 = this[3];
          lVar15 = this[7];
          uVar12 = *(uint64 *)(pStatics_fff8 + 8);
          uVar18 = il2cpp_internal(lVar13,DAT_181d7a788);
          lVar13 = NGUITools.AddSprite(uVar12,uVar18,lVar15,plVar14,0);
        }
        else {
          uVar12 = *(uint64 *)(pStatics_fff8 + 8);
          lVar13 = NGUITools.AddWidget(uVar12,plVar14,DAT_181d8eca0);
          if (lVar13 == null) throw; // [null/range check failed]
          UI2DSprite.set_sprite2D(lVar13,this[9],0);
        }
        plVar24 = this + 29;
        *plVar24 = lVar13;
        il2cpp_internal(plVar24,lVar13);
        bVar25 = (int)this[11] == 1;
        if ((int)this[11] == 0) {
          if (this[34] == 0) throw; // [null/range check failed]
          uVar9 = GameObject.get_layer(this[34],0);
          lVar13 = UICamera.FindCameraForLayer(uVar9,0);
          cVar8 = Object.op_Inequality(lVar13,0,0);
          if (cVar8) {
            if ((lVar13 == null) || (lVar13 = UICamera.get_cachedCamera(lVar13,0)) == null)
            throw; // [null/range check failed]
            local_200 = (uint32)this[41];
            local_208 = this[40];
            puVar17 = (uint64 *)Camera.WorldToViewportPoint(&local_218,lVar13,&local_208,0);
            local_218 = *puVar17;
            local_210 = (float)puVar17[1];
            bVar25 = (float)(local_218 >> 32) < 0.5;
          }
        }
        if (*plVar24 != 0) {
          UIWidget.set_pivot(*plVar24,0,0);
          if (*plVar24 != 0) {
            local_148 = this[19];
            uStack_140 = this[20];
            UIWidget.set_color(*plVar24,&local_148,0);
            plVar3 = (int64 *)*plVar24;
            if (plVar3 != (int64 *)0) {
              pfVar19 = (float *)(**(code **)(*plVar3 + 0x378))
                                           (&local_148,plVar3,*(uint64 *)(*plVar3 + 0x380));
              fVar26 = *pfVar19;
              fVar5 = pfVar19[1];
              *(float *)(this + 33) = fVar5;
              if (*plVar24 != 0) {
                lVar13 = UIRect.get_cachedTransform(*plVar24,0);
                fVar27 = (float)*(int *)((int64)this + 196);
                if (bVar25) {
                  fVar27 = fVar5 * 2.0 - fVar27;
                }
                if (lVar13 != null) {
                  local_1c8 = (uint64)(uint32)fVar27 << 32;
                  local_1c0 = 0.0;
                  Transform.set_localPosition(lVar13,&local_1c8,0);
                  lVar13 = this[10];
                  cVar8 = Object.op_Inequality(lVar13,0,0);
                  if (!cVar8) {
                    lVar13 = this[3];
                    cVar8 = Object.op_Inequality(lVar13,0,0);
                    if (!cVar8) {
                      return;
                    }
                    lVar13 = this[3];
                    lVar15 = this[8];
                    uVar12 = *(uint64 *)(pStatics_fff8 + 8);
                    uVar18 = il2cpp_internal(lVar13,DAT_181d7a788);
                    lVar13 = NGUITools.AddSprite(uVar12,uVar18,lVar15,(int)plVar14 + 1,0);
                  }
                  else {
                    uVar12 = *(uint64 *)(pStatics_fff8 + 8);
                    lVar13 = NGUITools.AddWidget(uVar12,(int)plVar14 + 1,DAT_181d8eca0);
                    if (lVar13 == null) throw; // [null/range check failed]
                    UI2DSprite.set_sprite2D(lVar13,this[10],0);
                  }
                  plVar24 = this + 30;
                  *plVar24 = lVar13;
                  il2cpp_internal(plVar24,lVar13);
                  local_148 = local_148 & 0xffffffff00000000;
                  local_108 = (uint64)local_108._4_4_ << 32;
                  if (*plVar24 != 0) {
                    cVar8 = UIBasicSprite.get_hasBorder(*plVar24,0);
                    if (cVar8) {
                      plVar14 = (int64 *)*plVar24;
                      if (plVar14 == (int64 *)0) throw; // [null/range check failed]
                      lVar13 = (**(code **)(*plVar14 + 0x378))
                                         (&local_148,plVar14,*(uint64 *)(*plVar14 + 0x380));
                      plVar14 = (int64 *)*plVar24;
                      uVar9 = *(uint32 *)(lVar13 + 12);
                      local_148 = CONCAT44(uVar9,uVar9);
                      uStack_140 = CONCAT44(uVar9,uVar9);
                      if (plVar14 == (int64 *)0) throw; // [null/range check failed]
                      plVar14 = (int64 *)
                                (**(code **)(*plVar14 + 0x378))
                                          (&local_108,plVar14,*(uint64 *)(*plVar14 + 0x380));
                      local_108 = *plVar14;
                      lStack_100 = plVar14[1];
                    }
                    if (*plVar24 != 0) {
                      UIWidget.set_pivot(*plVar24,0,0);
                      if (*plVar24 != 0) {
                        local_198 = this[21];
                        lStack_190 = this[22];
                        UIWidget.set_color(*plVar24,&local_198,0);
                        iVar10 = UIPopupList.get_activeFontSize(this,0);
                        local_1b8 = (float)UIPopupList.get_activeFontScale(this,0);
                        local_1b8 = local_1b8 * (float)iVar10;
                        fVar27 = *(float *)((int64)this + 132);
                        fVar28 = fVar27 + local_1b8;
                        if (!bVar25) {
                          fVar27 = (-fVar27 - fVar5) + (float)*(int *)((int64)this + 196);
                        }
                        else {
                          fVar27 = (fVar5 - fVar27) - (float)*(int *)((int64)this + 196);
                        }
                        lVar13 = il2cpp_internal(DAT_181d986d0);
                        FUN_18132faf0(lVar13,DAT_181da9c18);
                        if (this[13] != 0) {
                          cVar8 = FUN_18181e400(this[13],this[27],DAT_181da3e58);
                          if (!cVar8) {
                            this[27] = 0;
                            il2cpp_internal(this + 27,0);
                          }
                          if (this[13] != 0) {
                            local_158 = *(float *)(this[13] + 24);
                            plVar24 = plVar21;
                            if (0 < (int)local_158) {
                              do {
                                lVar15 = this[13];
                                if (lVar15 == null) throw; // [null/range check failed]
                                if (*(uint32 *)(lVar15 + 24) <= (uint32)plVar24) {
                                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                }
                                uVar12 = *(uint64 *)
                                          (*(int64 *)(lVar15 + 16) + 32 +
                                          (int64)(int)(uint32)plVar24 * 8);
                                uVar18 = *(uint64 *)(pStatics_fff8 + 8);
                                if (this[29] == 0) throw; // [null/range check failed]
                                iVar10 = *(int *)(this[29] + 172);
                                lVar15 = NGUITools.AddWidget(uVar18,iVar10 + 2,DAT_181d8ed20);
                                uVar18 = Int32.ToString(local_res20,0);
                                if (lVar15 == null) throw; // [null/range check failed]
                                Object.set_name(lVar15,uVar18,0);
                                UIWidget.set_pivot(lVar15,0,0);
                                uVar18 = il2cpp_internal(this[4],DAT_181d7a800);
                                UILabel.set_bitmapFont(lVar15,uVar18,0);
                                UILabel.set_trueTypeFont(lVar15,this[5],0);
                                UILabel.set_fontSize(lVar15,(int)this[6],0);
                                if (*(int *)(lVar15 + 0x1ac) != *(int *)((int64)this + 52)) {
                                  *(int *)(lVar15 + 0x1ac) = *(int *)((int64)this + 52);
                                  *(uint8 *)(lVar15 + 88) = 1;
                                  *(uint8 *)(lVar15 + 0x24c) = 1;
                                  UILabel.ProcessAndRequest(lVar15,0);
                                }
                                uVar18 = uVar12;
                                if (*(char *)((int64)this + 185) != false) {
                                  uVar18 = Localization.Get(uVar12,1,0);
                                }
                                UILabel.set_text(lVar15,uVar18,0);
                                UILabel.set_modifier(lVar15,*(uint32 *)((int64)this + 188),0);
                                local_198 = this[17];
                                lStack_190 = this[18];
                                UIWidget.set_color(lVar15,&local_198,0);
                                lVar16 = UIRect.get_cachedTransform(lVar15,0);
                                fVar29 = *(float *)(this + 16);
                                local_1c8 = UIWidget.get_pivotOffset(lVar15,0);
                                if (lVar16 == null) throw; // [null/range check failed]
                                local_208 = CONCAT44(fVar27,(fVar29 + fVar26) - (float)local_1c8);
                                local_200 = 0xbf800000;
                                Transform.set_localPosition(lVar16,&local_208,0);
                                if (*(int *)(lVar15 + 0x1dc) != 2) {
                                  *(uint32 *)(lVar15 + 0x1dc) = 2;
                                  *(uint8 *)(lVar15 + 88) = 1;
                                  *(uint8 *)(lVar15 + 0x24c) = 1;
                                }
                                if (*(int *)(lVar15 + 0x1b0) != (int)this[12]) {
                                  *(int *)(lVar15 + 0x1b0) = (int)this[12];
                                  *(uint8 *)(lVar15 + 88) = 1;
                                  *(uint8 *)(lVar15 + 0x24c) = 1;
                                  UILabel.ProcessAndRequest(lVar15,0);
                                }
                                if (*(int *)(lVar15 + 0x1d0) != 2) {
                                  *(uint32 *)(lVar15 + 0x1d0) = 2;
                                  *(uint8 *)(lVar15 + 88) = 1;
                                  *(uint8 *)(lVar15 + 0x24c) = 1;
                                }
                                if (lVar13 == null) throw; // [null/range check failed]
                                FUN_18181e0a0(lVar13,lVar15,DAT_181da9c98);
                                fVar27 = fVar27 - fVar28;
                                local_1c8 = UILabel.get_printedSize(lVar15,0);
                                Mathf.Max();
                                uVar18 = Component.get_gameObject(lVar15,0);
                                lVar16 = UIEventListener.Get(uVar18,0);
                                uVar18 = new OnTooltipCB(this,*(uint64 *)(*this + 0x270),0);
                                if (lVar16 == null) throw; // [null/range check failed]
                                *(uint64 *)(lVar16 + 56) = uVar18;
                                uVar18 = new OnTooltipCB(this,*(uint64 *)(*this + 0x280),0);
                                *(uint64 *)(lVar16 + 64) = uVar18;
                                uVar18 = new OnTooltipCB(this,*(uint64 *)(*this + 0x290));
                                *(uint64 *)(lVar16 + 40) = uVar18;
                                *(uint64 *)(lVar16 + 24) = uVar12;
                                cVar8 = FUN_18171e540(this[27],uVar12,0);
                                if ((cVar8) ||
                                   ((local_res20[0] == 0 &&
                                    (cVar8 = FUN_180d755b0(this[27],0), cVar8)))) {
                                  (**(code **)(*this + 0x238))(this,lVar15,1);
                                }
                                if (this[32] == 0) throw; // [null/range check failed]
                                FUN_18181e0a0(this[32],lVar15,DAT_181da9c98);
                                local_res20[0] = local_res20[0] + 1;
                                plVar24 = (int64 *)(uint64)local_res20[0];
                              } while ((int)local_res20[0] < (int)local_158);
                            }
                            fVar26 = (float)Mathf.Max();
                            fVar29 = fVar26 * 0.5;
                            fVar28 = -local_1b8 * 0.5;
                            local_170 = 0x3f800000;
                            local_188 = CONCAT44(fVar28,fVar29);
                            uVar12 = local_188;
                            local_178 = CONCAT44(local_1b8 + *(float *)((int64)this + 132),fVar26);
                            uVar1 = local_178;
                            if (lVar13 != null) {
                              if (0 < *(int *)(lVar13 + 24)) {
                                lVar15 = 32;
                                plVar24 = plVar21;
                                local_1c8 = (int64)*(int *)(lVar13 + 24);
                                do {
                                  if (*(uint32 *)(lVar13 + 24) <= (uint32)plVar21) {
                                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                  }
                                  lVar16 = *(int64 *)(lVar15 + *(int64 *)(lVar13 + 16));
                                  if (lVar16 == null) throw; // [null/range check failed]
                                  uVar18 = Component.get_gameObject(lVar16,0);
                                  NGUITools.AddWidgetCollider(uVar18,0);
                                  *(uint8 *)(lVar16 + 208) = 0;
                                  lVar20 = Component.GetComponent(lVar16,DAT_181d935e0);
                                  cVar8 = Object.op_Inequality(lVar20,0,0);
                                  if (!cVar8) {
                                    lVar16 = Component.GetComponent(lVar16,DAT_181d93660);
                                    local_158 = fVar29;
                                    fStack_154 = fVar28;
                                    if (lVar16 == null) throw; // [null/range check failed]
                                    Collider2D.set_offset(lVar16,CONCAT44(fVar28,fVar29));
                                    BoxCollider2D.set_size();
                                  }
                                  else {
                                    if (lVar20 == null) throw; // [null/range check failed]
                                    lVar16 = BoxCollider.get_center(&local_198,lVar20);
                                    local_168 = uVar12;
                                    local_200 = *(uint32 *)(lVar16 + 8);
                                    local_180 = local_200;
                                    local_160 = (float)local_200;
                                    BoxCollider.set_center(lVar20,&local_168);
                                    local_210 = (float)local_170;
                                    local_218 = uVar1;
                                    BoxCollider.set_size();
                                  }
                                  plVar21 = (int64 *)(uint64)((uint32)plVar21 + 1);
                                  plVar24 = (int64 *)((int64)plVar24 + 1);
                                  lVar15 = lVar15 + 8;
                                } while ((int64)plVar24 < local_1c8);
                              }
                              fVar26 = local_1b8;
                              lVar16 = 32;
                              uVar9 = Mathf.RoundToInt();
                              lVar15 = this[29];
                              uVar11 = Mathf.RoundToInt();
                              if (lVar15 != null) {
                                UIWidget.set_width(lVar15,uVar11,0);
                                lVar15 = this[29];
                                uVar11 = Mathf.RoundToInt();
                                if (lVar15 != null) {
                                  UIWidget.set_height(lVar15,uVar11,0);
                                  iVar10 = *(int *)(lVar13 + 24);
                                  uVar23 = 0;
                                  if (0 < iVar10) {
                                    lVar15 = 0;
                                    do {
                                      if (*(uint32 *)(lVar13 + 24) <= uVar23) {
                                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                      }
                                      lVar20 = *(int64 *)(lVar16 + *(int64 *)(lVar13 + 16));
                                      if (lVar20 == null) throw; // [null/range check failed]
                                      if (*(int *)(lVar20 + 0x1dc) != 0) {
                                        *(uint32 *)(lVar20 + 0x1dc) = 0;
                                        *(uint8 *)(lVar20 + 88) = 1;
                                        *(uint8 *)(lVar20 + 0x24c) = 1;
                                      }
                                      UIWidget.set_width(lVar20,uVar9,0);
                                      uVar23 = uVar23 + 1;
                                      lVar15 = lVar15 + 1;
                                      lVar16 = lVar16 + 8;
                                    } while (lVar15 < iVar10);
                                  }
                                  uVar23 = 0;
                                  lVar15 = il2cpp_internal(this[3],DAT_181d7a788);
                                  if (lVar15 != null) {
                                    FUN_180133520(5,DAT_181d7a788,lVar15);
                                  }
                                  lVar15 = this[30];
                                  uVar9 = Mathf.RoundToInt();
                                  if (lVar15 != null) {
                                    UIWidget.set_width(lVar15,uVar9,0);
                                    lVar15 = this[30];
                                    uVar9 = Mathf.RoundToInt();
                                    if (lVar15 != null) {
                                      UIWidget.set_height(lVar15,uVar9,0);
                                      if ((char)this[23] != false) {
                                        (**(code **)(*this + 0x2e8))
                                                  (this,this[29],*(uint64 *)(*this + 0x2f0)
                                                  );
                                        fVar28 = (float)Time.get_timeScale(0);
                                        if ((fVar28 == 0.0) ||
                                           (fVar28 = (float)Time.get_timeScale(0), 0.1 <= fVar28)) {
                                          fVar26 = (fVar27 - fVar5) + fVar26;
                                          UIPopupList.Animate(this,this[30],bVar25,fVar26,0);
                                          lVar15 = (int64)*(int *)(lVar13 + 24);
                                          if (0 < *(int *)(lVar13 + 24)) {
                                            lVar16 = 32;
                                            do {
                                              if (*(uint32 *)(lVar13 + 24) <= uVar23) {
                                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                              }
                                              uVar12 = *(uint64 *)
                                                        (lVar16 + *(int64 *)(lVar13 + 16));
                                              (**(code **)(*this + 0x2e8))
                                                        (this,uVar12,*(uint64 *)(*this + 0x2f0))
                                              ;
                                              (**(code **)(*this + 0x2f8))
                                                        (this,uVar12,bVar25,fVar26,
                                                         *(uint64 *)(*this + 0x300));
                                              uVar23 = uVar23 + 1;
                                              lVar16 = lVar16 + 8;
                                              lVar15 = lVar15 + -1;
                                            } while (lVar15 != null);
                                          }
                                          (**(code **)(*this + 0x308))
                                                    (this,this[29],bVar25,fVar26,
                                                     *(uint64 *)(*this + 0x310));
                                        }
                                      }
                                      lVar15 = local_1d8;
                                      lVar13 = this[29];
                                      fVar26 = (float)local_150;
                                      if (!bVar25) {
                                        fVar28 = fVar5 * local_1b0 + local_1b4;
                                        local_1e8 = CONCAT44(fVar28,(float)local_1e8);
                                        if (lVar13 == null) throw; // [null/range check failed]
                                        fVar29 = (float)*(int *)(lVar13 + 164) * local_1b0 + fVar26;
                                        fVar27 = fVar28 - (float)*(int *)(lVar13 + 168) * local_1b0;
                                        local_1e8 = CONCAT44(fVar28,fVar29);
                                        local_1f8 = CONCAT44(fVar27,(float)local_1f8);
                                      }
                                      else {
                                        fVar27 = local_1ac - fVar5 * local_1b0;
                                        local_1f8 = CONCAT44(fVar27,(float)local_1f8);
                                        if (lVar13 == null) throw; // [null/range check failed]
                                        fVar29 = (float)*(int *)(lVar13 + 164) * local_1b0 + fVar26;
                                        local_160 = (float)local_1a8;
                                        fVar28 = ((float)*(int *)(lVar13 + 168) - fVar5 * 2.0) *
                                                 local_1b0 + fVar27;
                                        local_210 = (float)local_1a8;
                                        local_1e8 = CONCAT44(fVar28,fVar29);
                                        local_218 = CONCAT44(fVar28 - fVar5 * local_1b0,fVar26);
                                        Transform.set_localPosition(local_1d8,&local_218,0);
                                      }
                                      plVar21 = (int64 *)this[28];
                                      do {
                                        plVar24 = plVar21;
                                        if (plVar24 == (int64 *)0) throw; // [null/range check failed]
                                        lVar13 = UIRect.get_parent(plVar24,0);
                                        cVar8 = Object.op_Equality(lVar13,0,0);
                                        if (cVar8) break;
                                        if (lVar13 == null) throw; // [null/range check failed]
                                        plVar21 = (int64 *)Component.GetComponentInParent(lVar13);
                                        cVar8 = Object.op_Equality(plVar21,0,0);
                                      } while (!cVar8);
                                      lVar13 = local_110;
                                      cVar8 = Object.op_Inequality(local_110,0,0);
                                      if (!cVar8) {
                                        local_1d8 = CONCAT44(fVar27,fVar26);
                                        local_res18 = CONCAT44(fVar28,fVar29);
                                        if (plVar24 != (int64 *)0) {
        LAB_1811a4e88:
                                          puVar17 = (uint64 *)
                                                    (**(code **)(*plVar24 + 0x2a8))
                                                              (&local_198,plVar24,local_1d8,local_res18,
                                                               *(uint64 *)(*plVar24 + 0x2b0));
                                          uVar1 = *puVar17;
                                          local_160 = *(float *)(puVar17 + 1);
                                          puVar17 = (uint64 *)
                                                    Transform.get_localPosition(&local_198,lVar15,0);
                                          local_218 = *puVar17;
                                          local_210 = *(float *)(puVar17 + 1);
                                          auVar4._4_8_ = uVar1 >> 32;
                                          auVar4._0_4_ = (float)uVar1 + (float)local_218;
                                          local_120 = local_210 + local_160;
                                          uVar9 = FUN_18000d7c0(auVar4._0_8_);
                                          uVar11 = FUN_18000d7c0();
                                          local_210 = local_120;
                                          local_218 = CONCAT44(uVar11,uVar9);
                                          Transform.set_localPosition(lVar15,&local_218,0);
                                          Transform.set_parent(lVar15,local_118,0);
                                          return;
                                        }
                                      }
                                      else if (lVar13 != null) {
                                        local_218 = local_1f8;
                                        local_210 = (float)local_1a4;
                                        puVar17 = (uint64 *)
                                                  Transform.TransformPoint
                                                            (&local_198,lVar13,&local_218,0);
                                        local_218 = local_1e8;
                                        uVar1 = *puVar17;
                                        uVar6 = puVar17[1];
                                        local_210 = (float)local_1a0;
                                        puVar17 = (uint64 *)
                                                  Transform.TransformPoint
                                                            (&local_198,lVar13,&local_218,0);
                                        uVar2 = *puVar17;
                                        uVar7 = puVar17[1];
                                        if ((plVar24 != (int64 *)0) &&
                                           (lVar13 = UIRect.get_cachedTransform(plVar24,0)) != null)
                                        {
                                          local_218 = uVar1;
                                          local_210 = (float)(int)uVar6;
                                          puVar17 = (uint64 *)
                                                    Transform.InverseTransformPoint
                                                              (&local_198,lVar13,&local_218,0);
                                          local_1f8 = *puVar17;
                                          lVar13 = UIRect.get_cachedTransform(plVar24,0);
                                          if (lVar13 != null) {
                                            local_218 = uVar2;
                                            local_210 = (float)(int)uVar7;
                                            puVar17 = (uint64 *)
                                                      Transform.InverseTransformPoint
                                                                (&local_198,lVar13,&local_218,0);
                                            local_1e8 = *puVar17;
                                            uVar12 = Component.get_gameObject(this,0);
                                            fVar26 = (float)UIRoot.GetPixelSizeAdjustment(uVar12,0);
                                            local_1d8 = CONCAT44(local_1f8._4_4_ / fVar26,
                                                                 (float)local_1f8 / fVar26);
                                            local_res18 = CONCAT44(local_1e8._4_4_ / fVar26,
                                                                   (float)local_1e8 / fVar26);
                                            goto LAB_1811a4e88;
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
    }

    // Token : 0x600020E
    // RVA   : 0x11A5480   Offset: 0x11A4880   Length: 0x260
    public void /*ctor*/()
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        ulong uVar4;
        ulong local_28;
        ulong uStack_20;
        byte[] local_18 = new byte[16];
        this.fontSize = 16;
        this.alignment = 1;
        uVar4 = il2cpp_internal(DAT_181d97750);
        FUN_18132faf0(uVar4,DAT_181da3bd8);
        this.items = uVar4;
        uVar4 = il2cpp_internal(DAT_181d94e50);
        FUN_18132faf0(uVar4,DAT_181d95788);
        this.itemData = uVar4;
        uVar4 = il2cpp_internal(DAT_181d909e0);
        FUN_18132faf0(uVar4,DAT_181d7b208);
        this.itemCallbacks = uVar4;
        this.padding = 0x40800000;
        *(uint32 *)(this + 132) = 0x40800000;
        puVar5 = (uint32 *)FUN_1810d3570(local_18,0);
        uVar1 = puVar5[1];
        uVar2 = puVar5[2];
        uVar3 = puVar5[3];
        this.textColor = *puVar5;
        *(uint32 *)(this + 140) = uVar1;
        *(uint32 *)(this + 144) = uVar2;
        *(uint32 *)(this + 148) = uVar3;
        puVar6 = (uint64 *)FUN_1810d3570(local_18,0);
        uVar4 = puVar6[1];
        local_28 = 0;
        uStack_20 = 0;
        this.backgroundColor = *puVar6;
        *(uint64 *)(this + 160) = uVar4;
        FUN_1809dc910(&local_28,0x3f61e1e2,0x3f48c8c9,0x3f169697,0x3f800000,0);
        this.isAnimated = 1;
        this.separatePanel = 1;
        this.highlightColor = (uint32)local_28;
        *(uint32 *)(this + 172) = local_28._4_4_;
        *(uint32 *)(this + 176) = (uint32)uStack_20;
        *(uint32 *)(this + 180) = uStack_20._4_4_;
        uVar4 = il2cpp_internal(DAT_181d92658);
        FUN_18132faf0(uVar4,DAT_181d85ea0);
        this.onChange = uVar4;
        uVar4 = il2cpp_internal(DAT_181d986d0);
        FUN_18132faf0(uVar4,DAT_181da9c18);
        this.mLabelList = uVar4;
        this.functionName = "OnSelectionChange";
        TrailRenderer_Base.ctor(this,0);
    }

    // Token : 0x600020F
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    private static void /*cctor*/()
    {
    }

}
