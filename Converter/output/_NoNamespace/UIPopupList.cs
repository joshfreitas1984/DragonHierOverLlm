// ============================================================
// Type  : UIPopupList
// Token : 0x2000054
// ============================================================

public class UIPopupList
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40001E3
    public static UIPopupList current;

    // Token: 0x40001E4
    protected static GameObject mChild;

    // Token: 0x40001E5
    protected static float mFadeOutComplete;

    // Token: 0x40001E6
    private const float animSpeed;

    // Token: 0x40001E7
    public object atlas;

    // Token: 0x40001E8
    public object bitmapFont;

    // Token: 0x40001E9
    public Font trueTypeFont;

    // Token: 0x40001EA
    public int fontSize;

    // Token: 0x40001EB
    public FontStyle fontStyle;

    // Token: 0x40001EC
    public string backgroundSprite;

    // Token: 0x40001ED
    public string highlightSprite;

    // Token: 0x40001EE
    public Sprite background2DSprite;

    // Token: 0x40001EF
    public Sprite highlight2DSprite;

    // Token: 0x40001F0
    public Position position;

    // Token: 0x40001F1
    public Selection selection;

    // Token: 0x40001F2
    public Alignment alignment;

    // Token: 0x40001F3
    public List<string> items;

    // Token: 0x40001F4
    public List<object> itemData;

    // Token: 0x40001F5
    public List<Action> itemCallbacks;

    // Token: 0x40001F6
    public Vector2 padding;

    // Token: 0x40001F7
    public Color textColor;

    // Token: 0x40001F8
    public Color backgroundColor;

    // Token: 0x40001F9
    public Color highlightColor;

    // Token: 0x40001FA
    public bool isAnimated;

    // Token: 0x40001FB
    public bool isLocalized;

    // Token: 0x40001FC
    public Modifier textModifier;

    // Token: 0x40001FD
    public bool separatePanel;

    // Token: 0x40001FE
    public int overlap;

    // Token: 0x40001FF
    public OpenOn openOn;

    // Token: 0x4000200
    public List<EventDelegate> onChange;

    // Token: 0x4000201
    protected string mSelectedItem;

    // Token: 0x4000202
    protected UIPanel mPanel;

    // Token: 0x4000203
    protected UIBasicSprite mBackground;

    // Token: 0x4000204
    protected UIBasicSprite mHighlight;

    // Token: 0x4000205
    protected UILabel mHighlightedLabel;

    // Token: 0x4000206
    protected List<UILabel> mLabelList;

    // Token: 0x4000207
    protected float mBgBorder;

    // Token: 0x4000208
    public bool keepValue;

    // Token: 0x4000209
    protected GameObject mSelection;

    // Token: 0x400020A
    protected int mOpenFrame;

    // Token: 0x400020B
    private GameObject eventReceiver;

    // Token: 0x400020C
    private string functionName;

    // Token: 0x400020D
    private float textScale;

    // Token: 0x400020E
    private UILabel textLabel;

    // Token: 0x400020F
    public Vector3 startingPosition;

    // Token: 0x4000210
    private LegacyEvent mLegacyEvent;

    // Token: 0x4000211
    protected bool mExecuting;

    // Token: 0x4000212
    protected bool mStarted;

    // Token: 0x4000213
    protected bool mTweening;

    // Token: 0x4000214
    public GameObject source;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60001C5
    // RVA   : 0x157FC40   Offset: 0x157E440   Length: 0xF2
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
          if (*plVar1 == DAT_181d4e110) {
            plVar3 = plVar1;
          }
          if (plVar3 != (int64 *)0) {
            plVar3 = (int64 *)0;
            if (*plVar1 == DAT_181d4e110) {
              plVar3 = plVar1;
            }
            if (plVar3 != (int64 *)0) {
              uVar4 = GameObject.GetComponent(plVar3,DAT_181da25b0);
              return uVar4;
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        uVar4 = il2cpp_internal(plVar1,DAT_181d556d0);
        return uVar4;
    }

    // Token : 0x60001C6
    // RVA   : 0x15801E0   Offset: 0x157E9E0   Length: 0x92
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

    // Token : 0x60001C7
    // RVA   : 0x157F7C0   Offset: 0x157DFC0   Length: 0x115
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
            if (*plVar4 == DAT_181d4e110) {
              plVar3 = plVar4;
            }
            if (plVar3 != (int64 *)0) {
              plVar3 = (int64 *)0;
              if (*plVar4 == DAT_181d4e110) {
                plVar3 = plVar4;
              }
              plVar4 = (int64 *)GameObject.GetComponent(plVar3,DAT_181da25b0);
              return plVar4;
            }
          }
          return plVar4;
        }
        return this.trueTypeFont;
    }

    // Token : 0x60001C8
    // RVA   : 0x15800F0   Offset: 0x157E8F0   Length: 0xEE
    public void set_ambigiousFont(object value)
    {
        long lVar1;
        if (value != (int64 *)0) {
          plVar2 = (int64 *)0;
          if (*value == DAT_181da26a0) {
            plVar2 = value;
          }
          if (plVar2 != (int64 *)0) {
            this.trueTypeFont = plVar2;
            puVar3 = &this.bitmapFont;
            goto LAB_1815801c5;
          }
        }
        lVar1 = il2cpp_internal(value,DAT_181d556d0);
        if (lVar1 == null) {
          if (value == (int64 *)0) {
            return;
          }
          plVar2 = (int64 *)0;
          if (*value == DAT_181d4e110) {
            plVar2 = value;
          }
          if (plVar2 == (int64 *)0) {
            return;
          }
          value = (int64 *)GameObject.GetComponent(plVar2,DAT_181da25b0);
          this.bitmapFont = value;
        }
        else {
          this.bitmapFont = value;
        }
        il2cpp_internal(this + 32,value);
        puVar3 = &this.trueTypeFont;
        LAB_1815801c5:
        this.trueTypeFont = 0;
        il2cpp_internal(puVar3,0);
    }

    // Token : 0x60001C9
    // RVA   : 0x12036A0   Offset: 0x1201EA0   Length: 0x8
    public LegacyEvent get_onSelectionChange()
    {
        uint64 FUN_1812036a0(int64 this)
        {
        return this.mLegacyEvent;
    }

    // Token : 0x60001CA
    // RVA   : 0x15803A0   Offset: 0x157EBA0   Length: 0xF
    public void set_onSelectionChange(LegacyEvent value)
    {
        void FUN_1815803a0(int64 this,uint64 value)
        {
        this.mLegacyEvent = value;
    }

    // Token : 0x60001CB
    // RVA   : 0x157FE50   Offset: 0x157E650   Length: 0x150
    public static bool get_isOpen()
    {
        var pStatics = *(int64*)(DAT_181d8add8 + 184);
        float fVar1;
        ulong uVar2;
        bool cVar3;
        float extraout_XMM0_Da;
        uVar2 = **(uint64 **)(DAT_181d8add8 + 184);
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

    // Token : 0x60001CC
    // RVA   : 0x2A3030   Offset: 0x2A1830   Length: 0x8
    public virtual string get_value()
    {
        return this.mSelectedItem;
    }

    // Token : 0x60001CD
    // RVA   : 0x15803B0   Offset: 0x157EBB0   Length: 0x73
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

    // Token : 0x60001CE
    // RVA   : 0x157F990   Offset: 0x157E190   Length: 0xA3
    public virtual object get_data()
    {
        long lVar1;
        uint uVar2;
        if (this.items != null) {
          uVar2 = FUN_1817ff280(this.items,this.mSelectedItem,
                                DAT_181d7c648);
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

    // Token : 0x60001CF
    // RVA   : 0x157F8E0   Offset: 0x157E0E0   Length: 0xA3
    public Action get_callback()
    {
        long lVar1;
        uint uVar2;
        if (this.items != null) {
          uVar2 = FUN_1817ff280(this.items,this.mSelectedItem,
                                DAT_181d7c648);
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

    // Token : 0x60001D0
    // RVA   : 0x157FD40   Offset: 0x157E540   Length: 0x105
    public bool get_isColliderEnabled()
    {
        long lVar1;
        bool cVar2;
        lVar1 = Component.GetComponent(this,DAT_181d6b340);
        cVar2 = Object.op_Inequality(lVar1,0,0);
        if (!cVar2) {
          lVar1 = Component.GetComponent(this,DAT_181d6b3c0);
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

    // Token : 0x60001D1
    // RVA   : 0x1580280   Offset: 0x157EA80   Length: 0x117
    public void set_isColliderEnabled(bool value)
    {
        long lVar1;
        bool cVar2;
        lVar1 = Component.GetComponent(this,DAT_181d6b340);
        cVar2 = Object.op_Inequality(lVar1,0,0);
        if (!cVar2) {
          lVar1 = Component.GetComponent(this,DAT_181d6b3c0);
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

    // Token : 0x60001D2
    // RVA   : 0x157FFA0   Offset: 0x157E7A0   Length: 0x143
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
              if (*plVar4 == DAT_181d4e110) {
                plVar3 = plVar4;
              }
              if (plVar3 != (int64 *)0) {
                plVar3 = (int64 *)0;
                if (*plVar4 == DAT_181d4e110) {
                  plVar3 = plVar4;
                }
                plVar4 = (int64 *)GameObject.GetComponent(plVar3,DAT_181da25b0);
              }
            }
          }
        }
        else {
          plVar4 = this.trueTypeFont;
        }
        Object.op_Inequality(plVar4,0,0);
    }

    // Token : 0x60001D3
    // RVA   : 0x157F700   Offset: 0x157DF00   Length: 0xB5
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
          uVar4 = FUN_180002970(22,DAT_181d556d0,lVar3);
          return uVar4;
        }
        return (uint64)this.fontSize;
    }

    // Token : 0x60001D4
    // RVA   : 0x157F620   Offset: 0x157DE20   Length: 0xD6
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
          iVar5 = FUN_180002970(22,DAT_181d556d0,lVar3);
          return (float)iVar1 / (float)iVar5;
        }
        return 1.0;
    }

    // Token : 0x60001D5
    // RVA   : 0x157FA40   Offset: 0x157E240   Length: 0x1F8
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
                    goto LAB_18157fba5;
                  }
                }
              }
            }
        LAB_18157fc33:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        else {
          if (this.items == null) goto LAB_18157fc33;
          fVar5 = ((float)this.fontSize + *(float *)(this + 132)) *
                  (float)this.items.Count + *(float *)(this + 132);
          NGUITools.get_screenSize(0);
          fVar1 = extraout_var_00;
          if (extraout_var_00 < fVar5) {
        LAB_18157fba5:
            return fVar1 / fVar5;
          }
        }
        return 1.0;
    }

    // Token : 0x60001D6
    // RVA   : 0x157C960   Offset: 0x157B160   Length: 0x86
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

    // Token : 0x60001D7
    // RVA   : 0x157B090   Offset: 0x1579890   Length: 0x86
    public virtual void Clear()
    {
        if (this.items != null) {
          FUN_180f56130(this.items,DAT_181d7c450);
          if (this.itemData != null) {
            FUN_180f56130(this.itemData,DAT_181d6e168);
            if (this.itemCallbacks != null) {
              FUN_180f56130(this.itemCallbacks,DAT_181d53d78);
              return;
            }
          }
        }
    }

    // Token : 0x60001D8
    // RVA   : 0x157AA20   Offset: 0x1579220   Length: 0x9A
    public virtual void AddItem(string text)
    {
        if (this.items != null) {
          FUN_181827900(this.items,text,DAT_181d7c3d0);
          if (this.itemData != null) {
            FUN_181827900(this.itemData,param_3,DAT_181d6e0e8);
            if (this.itemCallbacks != null) {
              FUN_181827900(this.itemCallbacks,param_4,DAT_181d53cf8);
              return;
            }
          }
        }
    }

    // Token : 0x60001D9
    // RVA   : 0x157AAC0   Offset: 0x15792C0   Length: 0x84
    public virtual void AddItem(string text, Action del)
    {
        if (this.items != null) {
          FUN_181827900(this.items,text,DAT_181d7c3d0);
          if (this.itemData != null) {
            FUN_181827900(this.itemData,del,DAT_181d6e0e8);
            if (this.itemCallbacks != null) {
              FUN_181827900(this.itemCallbacks,param_4,DAT_181d53cf8);
              return;
            }
          }
        }
    }

    // Token : 0x60001DA
    // RVA   : 0x157AB50   Offset: 0x1579350   Length: 0xB5
    public virtual void AddItem(string text, object data, Action del)
    {
        if (this.items != null) {
          FUN_181827900(this.items,text,DAT_181d7c3d0);
          if (this.itemData != null) {
            FUN_181827900(this.itemData,data,DAT_181d6e0e8);
            if (this.itemCallbacks != null) {
              FUN_181827900(this.itemCallbacks,del,DAT_181d53cf8);
              return;
            }
          }
        }
    }

    // Token : 0x60001DB
    // RVA   : 0x157C860   Offset: 0x157B060   Length: 0xD5
    public virtual void RemoveItem(string text)
    {
        long lVar1;
        int iVar2;
        if (this.items != null) {
          iVar2 = FUN_1817ff280(this.items,text,DAT_181d7c648);
          if (iVar2 == -1) {
            return;
          }
          if (this.items != null) {
            FUN_18182b220(this.items,iVar2,DAT_181d7c7c8);
            if (this.itemData != null) {
              FUN_18182b220(this.itemData,iVar2,DAT_181d6e4e8);
              lVar1 = this.itemCallbacks;
              if (lVar1 != null) {
                if (lVar1.Count <= iVar2) {
                  return;
                }
                FUN_18182b220(lVar1,iVar2,DAT_181d53df8);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60001DC
    // RVA   : 0x157C780   Offset: 0x157AF80   Length: 0xD5
    public virtual void RemoveItemByData(object data)
    {
        long lVar1;
        int iVar2;
        if (this.itemData != null) {
          iVar2 = FUN_1817ff280(this.itemData,data,DAT_181d6e368);
          if (iVar2 == -1) {
            return;
          }
          if (this.items != null) {
            FUN_18182b220(this.items,iVar2,DAT_181d7c7c8);
            if (this.itemData != null) {
              FUN_18182b220(this.itemData,iVar2,DAT_181d6e4e8);
              lVar1 = this.itemCallbacks;
              if (lVar1 != null) {
                if (lVar1.Count <= iVar2) {
                  return;
                }
                FUN_18182b220(lVar1,iVar2,DAT_181d53df8);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60001DD
    // RVA   : 0x157F0D0   Offset: 0x157D8D0   Length: 0x273
    protected void TriggerCallbacks()
    {
        var pStatics = *(int64*)(DAT_181d8add8 + 184);
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
              cVar5 = FUN_180d6ca90(this.functionName,0);
              if (!cVar5) {
                if (this.eventReceiver == null) goto LAB_18157f33e;
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
        LAB_18157f33e:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar6 = FUN_1817ff280(this.items,this.mSelectedItem,
                                DAT_181d7c648);
          if (-1 < (int)uVar6) {
            lVar4 = this.itemCallbacks;
            if (lVar4 == null) goto LAB_18157f33e;
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

    // Token : 0x60001DE
    // RVA   : 0x157BCA0   Offset: 0x157A4A0   Length: 0x2EC
    protected virtual void OnEnable()
    {
        bool cVar1;
        int iVar2;
        uint uVar3;
        long lVar6;
        ulong uVar7;
        ushort uVar8;
        ushort uVar9;
        uVar7 = this.onChange;
        cVar1 = EventDelegate.IsValid(uVar7,0);
        if (cVar1) {
          this.eventReceiver = 0;
          this.functionName = 0;
        }
        plVar4 = (int64 *)UIPopupList.get_font(this,0);
        if (this.textScale != null.0) {
          if (plVar4 == (int64 *)0) {
            uVar3 = 16;
          }
          else {
            iVar2 = FUN_180002970(22,DAT_181d556d0,plVar4);
            uVar3 = Mathf.RoundToInt((float)iVar2 * this.textScale,0);
          }
          this.fontSize = uVar3;
          this.textScale = 0;
        }
        uVar7 = this.trueTypeFont;
        cVar1 = Object.op_Equality(uVar7,0,0);
        if ((cVar1) && (plVar4 != (int64 *)0)) {
          lVar6 = *plVar4;
          uVar9 = 0;
          if (*(uint16 *)(lVar6 + 0x12a) != 0) {
            uVar8 = uVar9;
            do {
              if (*(int64 *)(*(int64 *)(lVar6 + 176) + (uint64)uVar8 * 16) == DAT_181d556d0) {
                puVar5 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar6 + 176) + 8 + (uint64)uVar8 * 16) *
                          16 + 0x2f8 + lVar6);
                goto LAB_18157be3c;
              }
              uVar8 = uVar8 + 1;
            } while (uVar8 < *(uint16 *)(lVar6 + 0x12a));
          }
          puVar5 = (uint64 *)FUN_1800914f0(plVar4,DAT_181d556d0,28);
        LAB_18157be3c:
          cVar1 = (*(code *)*puVar5)(plVar4,puVar5[1]);
          if (cVar1) {
            lVar6 = *plVar4;
            if (*(uint16 *)(lVar6 + 0x12a) != 0) {
              uVar8 = uVar9;
              do {
                if (*(int64 *)(*(int64 *)(lVar6 + 176) + (uint64)uVar8 * 16) == DAT_181d556d0)
                {
                  puVar5 = (uint64 *)
                           ((int64)*(int *)(*(int64 *)(lVar6 + 176) + 8 + (uint64)uVar8 * 16)
                            * 16 + 0x2c8 + lVar6);
                  goto LAB_18157be9c;
                }
                uVar8 = uVar8 + 1;
              } while (uVar8 < *(uint16 *)(lVar6 + 0x12a));
            }
            puVar5 = (uint64 *)FUN_1800914f0(plVar4,DAT_181d556d0,25);
        LAB_18157be9c:
            lVar6 = (*(code *)*puVar5)(plVar4,puVar5[1]);
            if (lVar6 == null) {
              lVar6 = *plVar4;
              if (*(uint16 *)(lVar6 + 0x12a) != 0) {
                do {
                  if (*(int64 *)(*(int64 *)(lVar6 + 176) + (uint64)uVar9 * 16) ==
                      DAT_181d556d0) {
                    puVar5 = (uint64 *)
                             ((int64)
                              *(int *)(*(int64 *)(lVar6 + 176) + 8 + (uint64)uVar9 * 16) * 16 +
                              0x308 + lVar6);
                    goto LAB_18157befc;
                  }
                  uVar9 = uVar9 + 1;
                } while (uVar9 < *(uint16 *)(lVar6 + 0x12a));
              }
              puVar5 = (uint64 *)FUN_1800914f0(plVar4,DAT_181d556d0,29);
        LAB_18157befc:
              uVar7 = (*(code *)*puVar5)(plVar4,puVar5[1]);
              this.trueTypeFont = uVar7;
              this.bitmapFont = 0;
            }
          }
        }
    }

    // Token : 0x60001DF
    // RVA   : 0x157EF60   Offset: 0x157D760   Length: 0x165
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
            uVar5 = new OnTooltipCB(lVar2,DAT_181d9cc08,0);
            EventDelegate.Add(lVar3,uVar5,0);
            *plVar1 = 0;
            il2cpp_internal(plVar1,0);
          }
        }
    }

    // Token : 0x60001E0
    // RVA   : 0x157C370   Offset: 0x157AB70   Length: 0x11
    protected virtual void OnLocalize()
    {
        void FUN_18157c370(int64 this)
        {
        if (this.isLocalized) {
          UIPopupList.TriggerCallbacks(this,0);
          return;
        }
    }

    // Token : 0x60001E1
    // RVA   : 0x157B950   Offset: 0x157A150   Length: 0x186
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

    // Token : 0x60001E2
    // RVA   : 0x157B750   Offset: 0x1579F50   Length: 0x1F7
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
              lVar7 = il2cpp_internal(*(uint64 *)(param_2 + 24),DAT_181d55650);
              if (lVar7 != null) {
                fVar9 = (float)FUN_180149d90(5,DAT_181d55650,lVar7);
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

    // Token : 0x60001E3
    // RVA   : 0x157F350   Offset: 0x157DB50   Length: 0x6C
    protected virtual IEnumerator UpdateTweenPosition()
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          return lVar1;
        }
    }

    // Token : 0x60001E4
    // RVA   : 0x157C160   Offset: 0x157A960   Length: 0x7D
    protected virtual void OnItemHover(GameObject go, bool isOver)
    {
        ulong uVar1;
        if (isOver) {
          if (go == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar1 = GameObject.GetComponent(go,DAT_181da27b0);
          (**(code **)(*this + 0x238))(this,uVar1,0,*(uint64 *)(*this + 0x240));
        }
    }

    // Token : 0x60001E5
    // RVA   : 0x157C1E0   Offset: 0x157A9E0   Length: 0x1D
    protected virtual void OnItemPress(GameObject go, bool isPressed)
    {
        void FUN_18157c1e0(int64 *this,uint64 go,char isPressed)
        {
        if ((isPressed) && (*(int *)((int64)this + 92) == 0)) {
                          // WARNING: Could not recover jumptable at 0x00018157c1f5. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*this + 0x288))(this,go,*(uint64 *)(*this + 0x290));
          return;
        }
    }

    // Token : 0x60001E6
    // RVA   : 0x157BF90   Offset: 0x157A790   Length: 0x1CB
    protected virtual void OnItemClick(GameObject go)
    {
        uint uVar1;
        int iVar2;
        long lVar4;
        ulong uVar5;
        long lVar6;
        uint uVar8;
        if (go != null) {
          uVar5 = GameObject.GetComponent(go,DAT_181da27b0);
          (**(code **)(*this + 0x238))(this,uVar5,1,*(uint64 *)(*this + 0x240));
          lVar6 = GameObject.GetComponent(go,DAT_181da2530);
          if (lVar6 != null) {
            plVar3 = *(int64 **)(lVar6 + 24);
            plVar9 = (int64 *)0;
            plVar7 = plVar9;
            if ((plVar3 != (int64 *)0) && (plVar7 = (int64 *)0, *plVar3 == DAT_181d82470)) {
              plVar7 = plVar3;
            }
            (**(code **)(*this + 0x188))(this,plVar7,*(uint64 *)(*this + 400));
            lVar6 = Component.GetComponents(this,DAT_181d6f840);
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
                          // WARNING: Could not recover jumptable at 0x00018157c13f. Too many branches
                          // WARNING: Treating indirect jump as call
              (**(code **)(*this + 0x2d8))(this,*(uint64 *)(*this + 0x2e0));
              return;
            }
          }
        }
    }

    // Token : 0x60001E7
    // RVA   : 0x157C940   Offset: 0x157B140   Length: 0x11
    private void Select(UILabel lbl, bool instant)
    {
        void FUN_18157c940(int64 *this)
        {
                          // WARNING: Could not recover jumptable at 0x00018157c94a. Too many branches
                          // WARNING: Treating indirect jump as call
        (**(code **)(*this + 0x238))();
    }

    // Token : 0x60001E8
    // RVA   : 0x157C390   Offset: 0x157AB90   Length: 0x173
    protected virtual void OnNavigate(KeyCode key)
    {
        bool cVar1;
        int iVar2;
        ulong uVar3;
        long lVar4;
        cVar1 = Behaviour.get_enabled(this,0);
        if (cVar1) {
          uVar3 = **(uint64 **)(DAT_181d8add8 + 184);
          cVar1 = Object.op_Equality(uVar3,this,0);
          if (cVar1) {
            if (this[32] == 0) {
        LAB_18157c4fe:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            iVar2 = FUN_1817ff280(this[32],this[31],DAT_181d823f8);
            if (iVar2 == -1) {
              iVar2 = 0;
            }
            if (key == 0x111) {
              if (iVar2 < 1) {
                return;
              }
              lVar4 = this[32];
              if (lVar4 == null) goto LAB_18157c4fe;
              iVar2 = iVar2 + -1;
            }
            else {
              if (key != 0x112) {
                return;
              }
              lVar4 = this[32];
              if (lVar4 == null) goto LAB_18157c4fe;
              iVar2 = iVar2 + 1;
              if (*(int *)(lVar4 + 24) <= iVar2) {
                return;
              }
            }
            uVar3 = FUN_180002f80(lVar4,iVar2,DAT_181d824f8);
            (**(code **)(*this + 0x238))(this,uVar3,0,*(uint64 *)(*this + 0x240));
          }
        }
    }

    // Token : 0x60001E9
    // RVA   : 0x157C200   Offset: 0x157AA00   Length: 0x163
    protected virtual void OnKey(KeyCode key)
    {
        var pStatics = *(int64*)(DAT_181d8a458 + 184);
        ulong uVar1;
        long lVar2;
        bool cVar3;
        cVar3 = Behaviour.get_enabled(this,0);
        if (cVar3) {
          uVar1 = **(uint64 **)(DAT_181d8add8 + 184);
          cVar3 = Object.op_Equality(uVar1,this,0);
          if (cVar3) {
            lVar2 = *(int64 *)(pStatics + 184);
            if (lVar2 == null) {
        LAB_18157c35e:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (key != *(int *)(lVar2 + 132)) {
              lVar2 = *(int64 *)(pStatics + 184);
              if (lVar2 == null) goto LAB_18157c35e;
              if (key != *(int *)(lVar2 + 136)) {
                return;
              }
            }
            (**(code **)(*this + 0x2c8))(this,0,*(uint64 *)(*this + 0x2d0));
          }
        }
    }

    // Token : 0x60001EA
    // RVA   : 0xFC5B60   Offset: 0xFC4360   Length: 0x11
    protected virtual void OnDisable()
    {
        void FUN_180fc5b60(int64 *this)
        {
                          // WARNING: Could not recover jumptable at 0x000180fc5b6a. Too many branches
                          // WARNING: Treating indirect jump as call
        (**(code **)(*this + 0x2d8))(this,*(uint64 *)(*this + 0x2e0));
    }

    // Token : 0x60001EB
    // RVA   : 0x157C510   Offset: 0x157AD10   Length: 0x264
    protected virtual void OnSelect(bool isSelected)
    {
        var pStatics = *(int64*)(DAT_181d8add8 + 184);
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

    // Token : 0x60001EC
    // RVA   : 0x157B640   Offset: 0x1579E40   Length: 0x102
    public static void Close()
    {
        ulong uVar1;
        bool cVar4;
        uVar1 = **(uint64 **)(DAT_181d8add8 + 184);
        cVar4 = Object.op_Inequality(uVar1,0,0);
        if (cVar4) {
          plVar2 = (int64 *)**(int64 **)(DAT_181d8add8 + 184);
          if (plVar2 != (int64 *)0) {
            (**(code **)(*plVar2 + 0x2d8))(plVar2,*(uint64 *)(*plVar2 + 0x2e0));
            puVar3 = *(uint64 **)(DAT_181d8add8 + 184);
            *puVar3 = 0;
            il2cpp_internal(puVar3,0);
            return;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x60001ED
    // RVA   : 0x157B190   Offset: 0x1579990   Length: 0x4A6
    public virtual void CloseSelf()
    {
        var pStatics = *(int64*)(DAT_181d8add8 + 184);
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
          uVar4 = **(uint64 **)(DAT_181d8add8 + 184);
          cVar2 = Object.op_Equality(uVar4,this,0);
          if (cVar2) {
            MonoBehaviour.StopCoroutine(this,"CloseIfUnselected",0);
            uVar8 = 0;
            this.mSelection = 0;
            if (this.mLabelList == null) goto LAB_18157b611;
            FUN_180f56130(this.mLabelList,DAT_181d82378);
            if (!this.isAnimated) {
              uVar4 = *(uint64 *)(pStatics + 8);
              Object.Destroy(uVar4,0);
              fVar9 = (float)Time.get_unscaledTime(0);
              fVar9 = fVar9 + 0.1;
            }
            else {
              lVar3 = *(int64 *)(pStatics + 8);
              if (lVar3 == null) {
        LAB_18157b611:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar3 = FUN_180956bf0(lVar3,DAT_181da3230);
              if (lVar3 == null) goto LAB_18157b611;
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
                  if (lVar5 == null) goto LAB_18157b611;
                  local_38 = *(uint32 *)(lVar5 + 144);
                  uStack_34 = *(uint32 *)(lVar5 + 148);
                  uStack_30 = *(uint32 *)(lVar5 + 152);
                  uStack_2c = 0;
                  uVar4 = Component.get_gameObject();
                  lVar5 = TweenColor.Begin(uVar4,0x3e19999a,&local_38,0);
                  if (lVar5 == null) goto LAB_18157b611;
                  uVar7 = uVar7 + 1;
                  *(uint32 *)(lVar5 + 24) = 2;
                } while ((int)uVar7 < iVar1);
              }
              lVar3 = *(int64 *)(pStatics + 8);
              if (lVar3 == null) goto LAB_18157b611;
              lVar3 = FUN_180956bf0(lVar3,DAT_181da2db0);
              if (lVar3 == null) goto LAB_18157b611;
              iVar1 = *(int *)(lVar3 + 24);
              if (0 < iVar1) {
                do {
                  if (*(uint32 *)(lVar3 + 24) <= uVar8) {
                    uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar4,0);
                  }
                  lVar5 = lVar3[uVar8];
                  if (lVar5 == null) goto LAB_18157b611;
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
            puVar6 = *(uint64 **)(DAT_181d8add8 + 184);
            *puVar6 = 0;
            il2cpp_internal(puVar6,0);
          }
        }
    }

    // Token : 0x60001EE
    // RVA   : 0x157AC10   Offset: 0x1579410   Length: 0xEE
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
          FUN_1809981e0(&local_48,uVar1,uVar2,uVar3,0,0);
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

    // Token : 0x60001EF
    // RVA   : 0x157AD00   Offset: 0x1579500   Length: 0x111
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

    // Token : 0x60001F0
    // RVA   : 0x157AE20   Offset: 0x1579620   Length: 0x1FA
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

    // Token : 0x60001F1
    // RVA   : 0x157B020   Offset: 0x1579820   Length: 0x68
    protected void Animate(UIWidget widget, bool placeAbove, float bottom)
    {
        void UIPopupList.Animate
                     (int64 *this,uint64 widget,uint8 placeAbove,uint32 bottom)
        {
        (**(code **)(*this + 0x2e8))(this,widget,*(uint64 *)(*this + 0x2f0));
                          // WARNING: Could not recover jumptable at 0x00018157b081. Too many branches
                          // WARNING: Treating indirect jump as call
        (**(code **)(*this + 0x2f8))(this,widget,placeAbove,bottom);
    }

    // Token : 0x60001F2
    // RVA   : 0x157BAE0   Offset: 0x157A2E0   Length: 0x19B
    protected virtual void OnClick()
    {
        long lVar1;
        bool cVar2;
        int iVar3;
        ulong uVar4;
        lVar1 = this[35];
        iVar3 = Time.get_frameCount(0);
        if ((int)lVar1 != iVar3) {
          uVar4 = *(uint64 *)(*(int64 *)(DAT_181d8add8 + 184) + 8);
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
                          // WARNING: Could not recover jumptable at 0x00018157bc06. Too many branches
                          // WARNING: Treating indirect jump as call
              (**(code **)(*this + 0x278))(this,uVar4,1,*(uint64 *)(*this + 0x280));
              return;
            }
          }
          else if (1 < (int)this[25] - 2U) {
            if ((int)this[25] == 1) {
              if (*(int *)(*(int64 *)(DAT_181d8a458 + 184) + 212) != -2) {
                return;
              }
            }
            (**(code **)(*this + 0x338))(this,*(uint64 *)(*this + 0x340));
          }
        }
    }

    // Token : 0x60001F3
    // RVA   : 0x157BC80   Offset: 0x157A480   Length: 0x1B
    protected virtual void OnDoubleClick()
    {
        void FUN_18157bc80(int64 *this)
        {
        if ((int)this[25] == 2) {
                          // WARNING: Could not recover jumptable at 0x00018157bc93. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*this + 0x338))(this,*(uint64 *)(*this + 0x340));
          return;
        }
    }

    // Token : 0x60001F4
    // RVA   : 0x157B120   Offset: 0x1579920   Length: 0x6C
    private IEnumerator CloseIfUnselected()
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          return lVar1;
        }
    }

    // Token : 0x60001F5
    // RVA   : 0x157C9F0   Offset: 0x157B1F0   Length: 0x2563
    public virtual void Show()
    {
        var pStatics_ac58 = *(int64*)(DAT_181d8ac58 + 184);
        var pStatics_add8 = *(int64*)(DAT_181d8add8 + 184);
        var pStatics_af58 = *(int64*)(DAT_181d8af58 + 184);
        ulong uVar1;
        byte[] auVar2 = new byte[12];
        ulong uVar3;
        bool cVar4;
        uint uVar5;
        int iVar6;
        ulong uVar7;
        long lVar8;
        long lVar10;
        long lVar11;
        ulong uVar14;
        long lVar17;
        uint uVar19;
        ulong uVar20;
        ulong uVar21;
        float fVar23;
        uint uVar24;
        float fVar25;
        float fVar26;
        float fVar27;
        float fVar28;
        float fVar29;
        ulong local_res18;
        uint[] local_res20 = new uint[2];
        ulong in_stack_fffffffffffffdb8;
        ulong local_238;
        float local_230;
        ulong local_228;
        uint local_220;
        ulong local_218;
        uint local_210;
        ulong local_208;
        uint local_200;
        uint64 local_1f8;
        uint64 local_1e8;
        float local_1e0;
        float local_1d8;
        float local_1d0;
        float fStack_1cc;
        float local_1c8;
        float local_1c4;
        float local_1c0;
        uint32 local_1bc;
        uint32 local_1b8;
        uint32 local_1b4;
        int64 local_1a8;
        int64 lStack_1a0;
        uint64 local_198;
        uint32 local_190;
        uint64 local_188;
        uint32 local_180;
        uint64 local_178;
        float local_170;
        uint64 local_168;
        float local_160;
        uint64 local_158;
        uint64 uStack_150;
        uint64 local_138;
        float local_130;
        int64 local_128;
        int64 local_120;
        float local_118;
        float fStack_114;
        float fStack_110;
        float fStack_10c;
        uint64 local_108;
        int64 lStack_100;
        uint64 local_f8;
        uint64 uStack_f0;
        uint64 local_e8;
        plVar13 = (int64 *)0;
        local_208 = 0;
        local_200 = 0;
        local_198 = 0;
        local_190 = 0;
        local_188 = 0;
        local_180 = 0;
        local_138 = 0;
        local_130 = 0.0;
        local_f8 = 0;
        uStack_f0 = 0;
        local_e8 = 0;
        local_res20[0] = 0;
        cVar4 = Behaviour.get_enabled(this,0);
        if (!cVar4) {
        LAB_18157eead:
          (**(code **)(*this + 0x2c8))(this,0,*(uint64 *)(*this + 0x2d0));
          return;
        }
        uVar7 = Component.get_gameObject(this,0);
        cVar4 = NGUITools.GetActive(uVar7,0);
        if (!cVar4) goto LAB_18157eead;
        uVar7 = *(uint64 *)(pStatics_add8 + 8);
        cVar4 = Object.op_Equality(uVar7,0,0);
        if (!cVar4) goto LAB_18157eead;
        lVar8 = this[5];
        cVar4 = Object.op_Inequality(lVar8,0,0);
        if (!cVar4) {
          lVar8 = this[4];
          cVar4 = Object.op_Inequality(lVar8,0,0);
          plVar16 = plVar13;
          if ((cVar4) && (plVar16 = (int64 *)this[4], plVar16 != (int64 *)0)) {
            plVar9 = plVar13;
            if (*plVar16 == DAT_181d4e110) {
              plVar9 = plVar16;
            }
            if (plVar9 != (int64 *)0) {
              plVar9 = plVar13;
              if (*plVar16 == DAT_181d4e110) {
                plVar9 = plVar16;
              }
              plVar16 = (int64 *)GameObject.GetComponent(plVar9,DAT_181da25b0);
            }
          }
        }
        else {
          plVar16 = (int64 *)this[5];
        }
        cVar4 = Object.op_Inequality(plVar16,0,0);
        if (!cVar4) goto LAB_18157eead;
        if (this[13] == 0) throw; // [null/range check failed]
        if (*(int *)(this[13] + 24) < 1) goto LAB_18157eead;
        if (this[32] == 0) throw; // [null/range check failed]
        FUN_180f56130(this[32],DAT_181d82378);
        MonoBehaviour.StopCoroutine(this,"CloseIfUnselected",0);
        lVar8 = UICamera.get_hoveredObject(0);
        if (lVar8 == null) {
          lVar8 = Component.get_gameObject(this,0);
        }
        UICamera.set_selectedObject(lVar8,0);
        lVar8 = UICamera.get_selectedObject(0);
        this[34] = lVar8;
        il2cpp_internal(this + 34,lVar8);
        this[44] = this[34];
        il2cpp_internal(this + 44);
        lVar8 = this[44];
        cVar4 = Object.op_Equality(lVar8,0,0);
        if (cVar4) {
          Debug.LogError("Popup list needs a source object...",0);
          return;
        }
        uVar5 = Time.get_frameCount(0);
        *(uint32 *)(this + 35) = uVar5;
        plVar16 = this + 28;
        lVar8 = *plVar16;
        cVar4 = Object.op_Equality(lVar8,0,0);
        if (cVar4) {
          lVar8 = Component.get_transform(this,0);
          plVar9 = (int64 *)NGUITools.FindInParents(lVar8,DAT_181d66980);
          cVar4 = Object.op_Inequality(plVar9,0,0);
          if (!cVar4) {
            for (; lVar8 != null; lVar8 = FUN_180da0f00(lVar8,0)) {
              uVar7 = FUN_180da0f00(lVar8,0);
              cVar4 = Object.op_Inequality(uVar7,0,0);
              plVar9 = plVar13;
              if (!(!cVar4))
              {
                if (lVar8 == null) break;
                }
                throw; // [null/range check failed]
                }
              }
          *plVar16 = (int64)plVar9;
          il2cpp_internal(plVar16,plVar9);
          lVar8 = *plVar16;
          cVar4 = Object.op_Equality(lVar8,0,0);
          if (cVar4) {
            return;
          }
        }
        uVar7 = new GameObject("Drop-down List",0);
        puVar18 = (uint64 *)(pStatics_add8 + 8);
        *puVar18 = uVar7;
        il2cpp_internal(puVar18,uVar7);
        lVar8 = *(int64 *)(pStatics_add8 + 8);
        lVar10 = Component.get_gameObject(this,0);
        if ((lVar10 == null) || (uVar5 = GameObject.get_layer(lVar10,0), lVar8 == null)) throw; // [null/range check failed]
        GameObject.set_layer(lVar8,uVar5,0);
        if ((char)this[24] != false) {
          uVar7 = Component.GetComponent(this,DAT_181d6b340);
          cVar4 = Object.op_Inequality(uVar7,0,0);
          if (!cVar4) {
            uVar7 = Component.GetComponent(this,DAT_181d6b3c0);
            cVar4 = Object.op_Inequality(uVar7,0,0);
            if (cVar4) {
              lVar8 = *(int64 *)(pStatics_add8 + 8);
              if ((lVar8 == null) || (lVar8 = GameObject.AddComponent(lVar8,DAT_181d9cdf8)) == null)
              throw; // [null/range check failed]
              Rigidbody2D.set_isKinematic(lVar8,1,0);
            }
          }
          else {
            lVar8 = *(int64 *)(pStatics_add8 + 8);
            if ((lVar8 == null) || (lVar8 = GameObject.AddComponent(lVar8,DAT_181d9cd70)) == null)
            throw; // [null/range check failed]
            Rigidbody.set_isKinematic(lVar8,1,0);
          }
          lVar8 = *(int64 *)(pStatics_add8 + 8);
          if ((lVar8 == null) || (lVar8 = GameObject.AddComponent(lVar8,DAT_181d9de70)) == null)
          throw; // [null/range check failed]
          if (*(int *)(lVar8 + 0x150) != 1000000) {
            *(uint32 *)(lVar8 + 0x150) = 1000000;
            lVar10 = *pStatics_ac58;
            uVar7 = new OnTooltipCB(0,DAT_181d9cc90,DAT_181d86518);
            if (lVar10 == null) throw; // [null/range check failed]
            List_1.Sort(lVar10,uVar7,DAT_181d82878);
          }
          if (*plVar16 == 0) throw; // [null/range check failed]
          iVar6 = *(int *)(*plVar16 + 0x154);
          if (*(int *)(lVar8 + 0x154) != iVar6) {
            *(int *)(lVar8 + 0x154) = iVar6;
            if (*pStatics_ac58 == 0) throw; // [null/range check failed]
            uVar5 = FUN_1817ff280(*pStatics_ac58,lVar8,DAT_181d82778);
            UIPanel.UpdateDrawCalls(lVar8,uVar5,0);
          }
        }
        puVar18 = *(uint64 **)(DAT_181d8add8 + 184);
        *puVar18 = this;
        il2cpp_internal(puVar18,this);
        if (*plVar16 == 0) throw; // [null/range check failed]
        lVar10 = UIRect.get_cachedTransform(*plVar16,0);
        lVar8 = *(int64 *)(pStatics_add8 + 8);
        local_120 = lVar10;
        if ((lVar8 == null) || (lVar8 = GameObject.get_transform(lVar8,0), local_1f8 = lVar8) == null)
        throw; // [null/range check failed]
        Transform.set_parent(lVar8,lVar10,0);
        local_128 = lVar10;
        if ((char)this[24] != false) {
          if (*plVar16 == 0) throw; // [null/range check failed]
          lVar11 = Component.GetComponentInParent(*plVar16,DAT_181d6f540);
          cVar4 = Object.op_Equality(lVar11,0,0);
          if (cVar4) {
            if (*pStatics_af58 == 0) throw; // [null/range check failed]
            if (*(int *)(*pStatics_af58 + 24) != 0) {
              lVar11 = *pStatics_af58;
              if (lVar11 == null) throw; // [null/range check failed]
              if (*(int *)(lVar11 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar11 = *(int64 *)(*(int64 *)(lVar11 + 16) + 32);
            }
          }
          cVar4 = Object.op_Inequality(lVar11,0,0);
          if (cVar4) {
            if (lVar11 == null) throw; // [null/range check failed]
            local_128 = Component.get_transform(lVar11,0);
          }
        }
        if ((int)this[25] == 3) {
          lVar8 = this[34];
          uVar7 = Component.get_gameObject(this,0);
          cVar4 = Object.op_Inequality(lVar8,uVar7,0);
          lVar8 = local_1f8;
          if (!cVar4) goto LAB_18157d8f7;
          lVar8 = UICamera.get_lastEventPosition(0);
          local_230 = 0.0;
          this[40] = lVar8;
          *(uint32 *)(this + 41) = 0;
          if ((*plVar16 == 0) || (lVar8 = UIRect.get_anchorCamera(*plVar16,0)) == null)
          throw; // [null/range check failed]
          local_220 = (uint32)this[41];
          local_228 = this[40];
          puVar18 = (uint64 *)Camera.ScreenToWorldPoint(&local_238,lVar8,&local_228,0);
          if (lVar10 == null) throw; // [null/range check failed]
          local_228 = *puVar18;
          local_220 = *(uint32 *)(puVar18 + 1);
          puVar12 = (uint64 *)Transform.InverseTransformPoint(&local_238,lVar10,&local_228,0);
          lVar8 = local_1f8;
          local_228 = *puVar12;
          local_220 = (uint32)puVar12[1];
          local_218._4_4_ = (float)(local_228 >> 32);
          local_1c8 = local_218._4_4_;
          local_1c0 = local_218._4_4_;
          local_218 = local_228;
          local_210 = local_220;
          local_200 = local_220;
          local_1bc = local_220;
          local_1b8 = local_220;
          local_168 = local_228;
          Transform.set_localPosition(local_1f8,&local_228,0);
          plVar13 = (int64 *)Transform.get_position(&local_238,lVar8,0);
          local_1b4 = local_200;
          this[40] = *plVar13;
        }
        else {
        LAB_18157d8f7:
          uVar7 = Component.get_transform(this,0);
          puVar18 = (uint64 *)
                    NGUIMath.CalculateRelativeWidgetBounds
                              (&local_158,lVar10,uVar7,0,in_stack_fffffffffffffdb8 & 0xffffffffffffff00,0)
          ;
          local_f8 = *puVar18;
          uStack_f0 = puVar18[1];
          local_e8 = puVar18[2];
          puVar12 = (uint64 *)Bounds.get_min(&local_238,&local_f8,0);
          uVar5 = (uint32)puVar12[1];
          uVar1 = *puVar12;
          local_218 = uVar1;
          local_210 = uVar5;
          local_1b8 = uVar5;
          puVar12 = (uint64 *)Bounds.get_max(&local_238,&local_f8,0);
          uVar20 = *puVar12;
          local_1b4 = (uint32)puVar12[1];
          local_228 = uVar1;
          local_220 = uVar5;
          Transform.set_localPosition(lVar8,&local_228,0);
          plVar13 = (int64 *)Transform.get_position(&local_238,lVar8,0);
          this[40] = *plVar13;
          local_1bc = local_210;
          local_1c8 = local_218._4_4_;
          local_168 = local_218 & 0xffffffff;
          local_208 = uVar20;
          local_1c0 = (float)(uVar20 >> 32);
        }
        *(int *)(this + 41) = (int)plVar13[1];
        MonoBehaviour.StartCoroutine(this,"CloseIfUnselected",0);
        fVar23 = (float)UIPopupList.get_fitScale(this,0);
        local_1c4 = fVar23;
        puVar12 = (uint64 *)Quaternion.get_identity(&local_158,0);
        local_158 = *puVar12;
        uStack_150 = puVar12[1];
        Transform.set_localRotation(lVar8,&local_158,0);
        local_1e8 = CONCAT44(fVar23,fVar23);
        local_1e0 = fVar23;
        Transform.set_localScale(lVar8,&local_1e8,0);
        if ((char)this[24] == false) {
          if (*plVar16 == 0) throw; // [null/range check failed]
          uVar7 = Component.get_gameObject(*plVar16,0);
          iVar6 = NGUITools.CalculateNextDepth(uVar7,0);
        }
        else {
          iVar6 = 0;
        }
        lVar8 = this[9];
        cVar4 = Object.op_Inequality(lVar8,0,0);
        if (!cVar4) {
          lVar8 = this[3];
          cVar4 = Object.op_Inequality(lVar8,0,0);
          if (!cVar4) {
            return;
          }
          lVar8 = this[3];
          lVar10 = this[7];
          uVar7 = *(uint64 *)(pStatics_add8 + 8);
          uVar14 = il2cpp_internal(lVar8,DAT_181d55650);
          lVar8 = NGUITools.AddSprite(uVar7,uVar14,lVar10,iVar6,0);
        }
        else {
          uVar7 = *(uint64 *)(pStatics_add8 + 8);
          lVar8 = NGUITools.AddWidget(uVar7,iVar6,DAT_181d65f80);
          if (lVar8 == null) throw; // [null/range check failed]
          UI2DSprite.set_sprite2D(lVar8,this[9],0);
        }
        plVar13 = this + 29;
        *plVar13 = lVar8;
        il2cpp_internal(plVar13,lVar8);
        bVar22 = (int)this[11] == 1;
        if ((int)this[11] == 0) {
          if (this[34] == 0) throw; // [null/range check failed]
          uVar5 = GameObject.get_layer(this[34],0);
          lVar8 = UICamera.FindCameraForLayer(uVar5,0);
          cVar4 = Object.op_Inequality(lVar8,0,0);
          if (cVar4) {
            if ((lVar8 == null) || (lVar8 = UICamera.get_cachedCamera(lVar8,0)) == null)
            throw; // [null/range check failed]
            local_220 = (uint32)this[41];
            local_228 = this[40];
            puVar12 = (uint64 *)Camera.WorldToViewportPoint(&local_238,lVar8,&local_228,0);
            local_238 = *puVar12;
            local_230 = (float)puVar12[1];
            bVar22 = (float)(local_238 >> 32) < 0.5;
          }
        }
        if (*plVar13 != 0) {
          UIWidget.set_pivot(*plVar13,0,0);
          if (*plVar13 != 0) {
            local_158 = this[19];
            uStack_150 = this[20];
            UIWidget.set_color(*plVar13,&local_158,0);
            plVar16 = (int64 *)*plVar13;
            if (plVar16 != (int64 *)0) {
              pfVar15 = (float *)(**(code **)(*plVar16 + 0x378))
                                           (&local_158,plVar16,*(uint64 *)(*plVar16 + 0x380));
              local_118 = *pfVar15;
              fVar23 = pfVar15[1];
              fStack_110 = pfVar15[2];
              fStack_10c = pfVar15[3];
              *(float *)(this + 33) = fVar23;
              fStack_114 = fVar23;
              if (*plVar13 != 0) {
                lVar8 = UIRect.get_cachedTransform(*plVar13,0);
                fVar25 = (float)*(int *)((int64)this + 196);
                if (bVar22) {
                  fVar25 = fVar23 * 2.0 - fVar25;
                }
                if (lVar8 != null) {
                  local_1e8 = (uint64)(uint32)fVar25 << 32;
                  local_1e0 = 0.0;
                  Transform.set_localPosition(lVar8,&local_1e8,0);
                  lVar8 = this[10];
                  cVar4 = Object.op_Inequality(lVar8,0,0);
                  if (!cVar4) {
                    lVar8 = this[3];
                    cVar4 = Object.op_Inequality(lVar8,0,0);
                    if (!cVar4) {
                      return;
                    }
                    lVar8 = this[3];
                    lVar10 = this[8];
                    uVar7 = *(uint64 *)(pStatics_add8 + 8);
                    uVar14 = il2cpp_internal(lVar8,DAT_181d55650);
                    lVar8 = NGUITools.AddSprite(uVar7,uVar14,lVar10,iVar6 + 1,0);
                  }
                  else {
                    uVar7 = *(uint64 *)(pStatics_add8 + 8);
                    lVar8 = NGUITools.AddWidget(uVar7,iVar6 + 1,DAT_181d65f80);
                    if (lVar8 == null) throw; // [null/range check failed]
                    UI2DSprite.set_sprite2D(lVar8,this[10],0);
                  }
                  uVar19 = 0;
                  plVar13 = this + 30;
                  *plVar13 = lVar8;
                  il2cpp_internal(plVar13,lVar8);
                  local_158 = local_158 & 0xffffffff00000000;
                  local_108 = (uint64)local_108._4_4_ << 32;
                  if (*plVar13 != 0) {
                    cVar4 = UIBasicSprite.get_hasBorder(*plVar13,0);
                    if (cVar4) {
                      plVar16 = (int64 *)*plVar13;
                      if (plVar16 == (int64 *)0) throw; // [null/range check failed]
                      lVar8 = (**(code **)(*plVar16 + 0x378))
                                        (&local_158,plVar16,*(uint64 *)(*plVar16 + 0x380));
                      plVar16 = (int64 *)*plVar13;
                      uVar5 = *(uint32 *)(lVar8 + 12);
                      local_158 = CONCAT44(uVar5,uVar5);
                      uStack_150 = CONCAT44(uVar5,uVar5);
                      if (plVar16 == (int64 *)0) throw; // [null/range check failed]
                      plVar16 = (int64 *)
                                (**(code **)(*plVar16 + 0x378))
                                          (&local_108,plVar16,*(uint64 *)(*plVar16 + 0x380));
                      local_108 = *plVar16;
                      lStack_100 = plVar16[1];
                    }
                    if (*plVar13 != 0) {
                      UIWidget.set_pivot(*plVar13,0,0);
                      if (*plVar13 != 0) {
                        local_1a8 = this[21];
                        lStack_1a0 = this[22];
                        UIWidget.set_color(*plVar13,&local_1a8,0);
                        iVar6 = UIPopupList.get_activeFontSize(this,0);
                        local_1d8 = (float)UIPopupList.get_activeFontScale(this,0);
                        fVar25 = *(float *)((int64)this + 132);
                        local_1d8 = local_1d8 * (float)iVar6;
                        fVar26 = fVar25 + local_1d8;
                        if (bVar22) {
                          fVar25 = (fVar23 - fVar25) - (float)*(int *)((int64)this + 196);
                        }
                        else {
                          fVar25 = (-fVar25 - fVar23) + (float)*(int *)((int64)this + 196);
                        }
                        local_160 = fVar23 * 2.0;
                        lVar8 = il2cpp_internal(DAT_181d739b0);
                        FUN_180f58a90(lVar8,DAT_181d82278);
                        if (this[13] != 0) {
                          cVar4 = FUN_1818279a0(this[13],this[27],DAT_181d7c4d0);
                          if (!cVar4) {
                            this[27] = 0;
                            il2cpp_internal(this + 27,0);
                          }
                          if (this[13] != 0) {
                            local_1d0 = *(float *)(this[13] + 24);
                            if (0 < (int)local_1d0) {
                              do {
                                lVar10 = this[13];
                                if (lVar10 == null) throw; // [null/range check failed]
                                if (*(uint32 *)(lVar10 + 24) <= uVar19) {
                                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                }
                                uVar7 = *(uint64 *)
                                         (*(int64 *)(lVar10 + 16) + 32 + (int64)(int)uVar19 * 8)
                                ;
                                uVar14 = *(uint64 *)(pStatics_add8 + 8);
                                if (this[29] == 0) throw; // [null/range check failed]
                                iVar6 = *(int *)(this[29] + 172);
                                lVar10 = NGUITools.AddWidget(uVar14,iVar6 + 2,DAT_181d66000);
                                uVar14 = Int32.ToString(local_res20,0);
                                if (lVar10 == null) throw; // [null/range check failed]
                                Object.set_name(lVar10,uVar14,0);
                                UIWidget.set_pivot(lVar10,0,0);
                                uVar14 = il2cpp_internal(this[4],DAT_181d556d0);
                                UILabel.set_bitmapFont(lVar10,uVar14,0);
                                UILabel.set_trueTypeFont(lVar10,this[5],0);
                                UILabel.set_fontSize(lVar10,(int)this[6],0);
                                UILabel.set_fontStyle(lVar10,*(uint32 *)((int64)this + 52),0)
                                ;
                                uVar14 = uVar7;
                                if (*(char *)((int64)this + 185) != false) {
                                  uVar14 = Localization.Get(uVar7,1,0);
                                }
                                UILabel.set_text(lVar10,uVar14,0);
                                UILabel.set_modifier(lVar10,*(uint32 *)((int64)this + 188),0);
                                local_1a8 = this[17];
                                lStack_1a0 = this[18];
                                UIWidget.set_color(lVar10,&local_1a8,0);
                                lVar11 = UIRect.get_cachedTransform(lVar10,0);
                                fVar29 = *(float *)(this + 16);
                                local_1e8 = UIWidget.get_pivotOffset(lVar10,0);
                                if (lVar11 == null) throw; // [null/range check failed]
                                local_228 = CONCAT44(fVar25,(fVar29 + local_118) - (float)local_1e8);
                                local_220 = 0xbf800000;
                                Transform.set_localPosition(lVar11,&local_228,0);
                                UILabel.set_overflowMethod(lVar10,2);
                                UILabel.set_alignment(lVar10,(int)this[12],0);
                                UILabel.set_symbolStyle(lVar10,2);
                                if (lVar8 == null) throw; // [null/range check failed]
                                FUN_181827900(lVar8,lVar10,DAT_181d822f8);
                                fVar25 = fVar25 - fVar26;
                                local_1e8 = UILabel.get_printedSize(lVar10,0);
                                Mathf.Max();
                                uVar14 = Component.get_gameObject(lVar10,0);
                                lVar11 = UIEventListener.Get(uVar14,0);
                                uVar14 = new OnTooltipCB(this,*(uint64 *)(*this + 0x270),0);
                                if (lVar11 == null) throw; // [null/range check failed]
                                *(uint64 *)(lVar11 + 56) = uVar14;
                                uVar14 = new OnTooltipCB(this,*(uint64 *)(*this + 0x280),0);
                                *(uint64 *)(lVar11 + 64) = uVar14;
                                uVar14 = new OnTooltipCB(this,*(uint64 *)(*this + 0x290));
                                *(uint64 *)(lVar11 + 40) = uVar14;
                                *(uint64 *)(lVar11 + 24) = uVar7;
                                cVar4 = FUN_1816fd990(this[27],uVar7,0);
                                if ((cVar4) ||
                                   ((local_res20[0] == 0 &&
                                    (cVar4 = FUN_180d6ca90(this[27],0), cVar4)))) {
                                  (**(code **)(*this + 0x238))(this,lVar10,1);
                                }
                                if (this[32] == 0) throw; // [null/range check failed]
                                FUN_181827900(this[32],lVar10,DAT_181d822f8);
                                local_res20[0] = local_res20[0] + 1;
                                uVar19 = local_res20[0];
                              } while ((int)local_res20[0] < (int)local_1d0);
                            }
                            fVar26 = (float)Mathf.Max();
                            uVar20 = 0;
                            fVar29 = 1.0;
                            fVar27 = -local_1d8 * 0.5;
                            local_180 = 0x3f800000;
                            fVar28 = fVar26 * 0.5;
                            local_198 = CONCAT44(fVar27,fVar28);
                            uVar7 = local_198;
                            local_188 = CONCAT44(local_1d8 + *(float *)((int64)this + 132),fVar26);
                            uVar1 = local_188;
                            if (lVar8 != null) {
                              lVar11 = 32;
                              uVar21 = uVar20;
                              lVar10 = (int64)*(int *)(lVar8 + 24);
                              if (0 < *(int *)(lVar8 + 24)) {
                                do {
                                  local_1e8 = lVar10;
                                  if (*(uint32 *)(lVar8 + 24) <= (uint32)uVar21) {
                                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                  }
                                  lVar10 = *(int64 *)(lVar11 + *(int64 *)(lVar8 + 16));
                                  if (lVar10 == null) throw; // [null/range check failed]
                                  uVar14 = Component.get_gameObject(lVar10,0);
                                  NGUITools.AddWidgetCollider(uVar14,0);
                                  *(uint8 *)(lVar10 + 208) = 0;
                                  lVar17 = Component.GetComponent(lVar10,DAT_181d6adc0);
                                  cVar4 = Object.op_Inequality(lVar17,0,0);
                                  if (!cVar4) {
                                    lVar10 = Component.GetComponent(lVar10,DAT_181d6ae40);
                                    local_1d0 = fVar28;
                                    fStack_1cc = fVar27;
                                    if (lVar10 == null) throw; // [null/range check failed]
                                    Collider2D.set_offset(lVar10,CONCAT44(fVar27,fVar28));
                                    BoxCollider2D.set_size();
                                  }
                                  else {
                                    if (lVar17 == null) throw; // [null/range check failed]
                                    lVar10 = BoxCollider.get_center(&local_1a8,lVar17);
                                    local_178 = uVar7;
                                    local_220 = *(uint32 *)(lVar10 + 8);
                                    local_190 = local_220;
                                    local_170 = (float)local_220;
                                    BoxCollider.set_center(lVar17,&local_178);
                                    local_230 = (float)local_180;
                                    local_238 = uVar1;
                                    BoxCollider.set_size();
                                  }
                                  uVar20 = uVar20 + 1;
                                  lVar11 = lVar11 + 8;
                                  uVar21 = (uint64)((uint32)uVar21 + 1);
                                  lVar10 = local_1e8;
                                } while ((int64)uVar20 < local_1e8);
                              }
                              fVar26 = local_1d8;
                              lVar11 = 32;
                              uVar19 = 0;
                              local_1d0 = (float)Mathf.RoundToInt();
                              lVar10 = this[29];
                              uVar5 = Mathf.RoundToInt();
                              if (lVar10 != null) {
                                UIWidget.set_width(lVar10,uVar5,0);
                                lVar10 = this[29];
                                uVar5 = Mathf.RoundToInt();
                                if (lVar10 != null) {
                                  UIWidget.set_height(lVar10,uVar5,0);
                                  iVar6 = *(int *)(lVar8 + 24);
                                  if (0 < iVar6) {
                                    lVar10 = 0;
                                    do {
                                      if (*(uint32 *)(lVar8 + 24) <= uVar19) {
                                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                      }
                                      lVar17 = *(int64 *)(lVar11 + *(int64 *)(lVar8 + 16));
                                      if (lVar17 == null) throw; // [null/range check failed]
                                      UILabel.set_overflowMethod(lVar17,0,0);
                                      UIWidget.set_width();
                                      uVar19 = uVar19 + 1;
                                      lVar10 = lVar10 + 1;
                                      lVar11 = lVar11 + 8;
                                    } while (lVar10 < iVar6);
                                  }
                                  uVar19 = 0;
                                  lVar10 = il2cpp_internal(this[3],DAT_181d55650);
                                  if (lVar10 != null) {
                                    FUN_180149d90(5,DAT_181d55650,lVar10);
                                  }
                                  lVar10 = this[30];
                                  uVar5 = Mathf.RoundToInt();
                                  if (lVar10 != null) {
                                    UIWidget.set_width(lVar10,uVar5,0);
                                    lVar10 = this[30];
                                    uVar5 = Mathf.RoundToInt();
                                    if (lVar10 != null) {
                                      UIWidget.set_height(lVar10,uVar5,0);
                                      if ((char)this[23] != false) {
                                        (**(code **)(*this + 0x2e8))
                                                  (this,this[29],*(uint64 *)(*this + 0x2f0)
                                                  );
                                        fVar27 = (float)Time.get_timeScale(0);
                                        if ((fVar27 == 0.0) ||
                                           (fVar27 = (float)Time.get_timeScale(0), 0.1 <= fVar27)) {
                                          fVar26 = (fVar25 - fVar23) + fVar26;
                                          UIPopupList.Animate(this,this[30],bVar22,fVar26,0);
                                          lVar10 = (int64)*(int *)(lVar8 + 24);
                                          if (0 < *(int *)(lVar8 + 24)) {
                                            lVar11 = 32;
                                            do {
                                              if (*(uint32 *)(lVar8 + 24) <= uVar19) {
                                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                              }
                                              uVar7 = *(uint64 *)
                                                       (lVar11 + *(int64 *)(lVar8 + 16));
                                              (**(code **)(*this + 0x2e8))
                                                        (this,uVar7,*(uint64 *)(*this + 0x2f0));
                                              (**(code **)(*this + 0x2f8))
                                                        (this,uVar7,bVar22,fVar26,
                                                         *(uint64 *)(*this + 0x300));
                                              uVar19 = uVar19 + 1;
                                              lVar11 = lVar11 + 8;
                                              lVar10 = lVar10 + -1;
                                            } while (lVar10 != null);
                                          }
                                          (**(code **)(*this + 0x308))
                                                    (this,this[29],bVar22,fVar26,
                                                     *(uint64 *)(*this + 0x310));
                                        }
                                      }
                                      lVar10 = local_1f8;
                                      lVar8 = this[29];
                                      fVar23 = fVar23 * local_1c4;
                                      fVar25 = (float)local_168;
                                      if (!bVar22) {
                                        fVar27 = fVar23 + local_1c8;
                                        local_208 = CONCAT44(fVar27,(float)local_208);
                                        if (lVar8 == null) throw; // [null/range check failed]
                                        fVar28 = (float)*(int *)(lVar8 + 164) * local_1c4 + fVar25;
                                        fVar26 = fVar27 - (float)*(int *)(lVar8 + 168) * local_1c4;
                                        local_208 = CONCAT44(fVar27,fVar28);
                                        local_218 = CONCAT44(fVar26,(float)local_218);
                                      }
                                      else {
                                        fVar26 = local_1c0 - fVar23;
                                        local_218 = CONCAT44(fVar26,(float)local_218);
                                        if (lVar8 == null) throw; // [null/range check failed]
                                        fVar28 = (float)*(int *)(lVar8 + 164) * local_1c4 + fVar25;
                                        local_170 = (float)local_1bc;
                                        fVar27 = ((float)*(int *)(lVar8 + 168) - local_160) * local_1c4 +
                                                 fVar26;
                                        local_230 = (float)local_1bc;
                                        local_208 = CONCAT44(fVar27,fVar28);
                                        local_238 = CONCAT44(fVar27 - fVar23,fVar25);
                                        Transform.set_localPosition(local_1f8,&local_238,0);
                                      }
                                      plVar13 = (int64 *)this[28];
                                      do {
                                        plVar16 = plVar13;
                                        if (plVar16 == (int64 *)0) throw; // [null/range check failed]
                                        lVar8 = UIRect.get_parent(plVar16,0);
                                        cVar4 = Object.op_Equality(lVar8,0,0);
                                        if (cVar4) break;
                                        if (lVar8 == null) throw; // [null/range check failed]
                                        plVar13 = (int64 *)Component.GetComponentInParent(lVar8);
                                        cVar4 = Object.op_Equality(plVar13,0,0);
                                      } while (!cVar4);
                                      lVar8 = local_120;
                                      cVar4 = Object.op_Inequality(local_120,0,0);
                                      if (!cVar4) {
                                        local_1f8 = CONCAT44(fVar26,fVar25);
                                        local_res18 = CONCAT44(fVar27,fVar28);
                                        if (plVar16 != (int64 *)0) {
        LAB_18157edbf:
                                          puVar12 = (uint64 *)
                                                    (**(code **)(*plVar16 + 0x2a8))
                                                              (&local_1a8,plVar16,local_1f8,local_res18,
                                                               *(uint64 *)(*plVar16 + 0x2b0));
                                          uVar1 = *puVar12;
                                          local_170 = *(float *)(puVar12 + 1);
                                          puVar12 = (uint64 *)
                                                    Transform.get_localPosition(&local_1a8,lVar10,0);
                                          local_238 = *puVar12;
                                          local_230 = *(float *)(puVar12 + 1);
                                          auVar2._4_8_ = uVar1 >> 32;
                                          auVar2._0_4_ = (float)uVar1 + (float)local_238;
                                          local_130 = local_230 + local_170;
                                          uVar5 = FUN_18000d7c0(auVar2._0_8_);
                                          uVar24 = FUN_18000d7c0();
                                          local_230 = local_130;
                                          local_238 = CONCAT44(uVar24,uVar5);
                                          Transform.set_localPosition(lVar10,&local_238,0);
                                          Transform.set_parent(lVar10,local_128,0);
                                          return;
                                        }
                                      }
                                      else if (lVar8 != null) {
                                        local_238 = local_218;
                                        local_230 = (float)local_1b8;
                                        puVar12 = (uint64 *)
                                                  Transform.TransformPoint(&local_1a8,lVar8,&local_238,0)
                                        ;
                                        local_238 = local_208;
                                        uVar1 = *puVar12;
                                        uVar21 = puVar12[1];
                                        local_230 = (float)local_1b4;
                                        puVar12 = (uint64 *)
                                                  Transform.TransformPoint(&local_1a8,lVar8,&local_238,0)
                                        ;
                                        uVar20 = *puVar12;
                                        uVar3 = puVar12[1];
                                        if ((plVar16 != (int64 *)0) &&
                                           (lVar8 = UIRect.get_cachedTransform(plVar16,0)) != null) {
                                          local_238 = uVar1;
                                          local_230 = (float)(int)uVar21;
                                          puVar12 = (uint64 *)
                                                    Transform.InverseTransformPoint
                                                              (&local_1a8,lVar8,&local_238,0);
                                          local_218 = *puVar12;
                                          lVar8 = UIRect.get_cachedTransform(plVar16,0);
                                          if (lVar8 != null) {
                                            local_238 = uVar20;
                                            local_230 = (float)(int)uVar3;
                                            puVar12 = (uint64 *)
                                                      Transform.InverseTransformPoint
                                                                (&local_1a8,lVar8,&local_238,0);
                                            local_208 = *puVar12;
                                            uVar7 = Component.get_gameObject(this,0);
                                            lVar8 = NGUITools.FindInParents(uVar7,DAT_181d66b00);
                                            cVar4 = Object.op_Inequality(lVar8,0,0);
                                            if (cVar4) {
                                              if (lVar8 == null) throw; // [null/range check failed]
                                              fVar29 = (float)UIRoot.get_pixelSizeAdjustment(lVar8,0);
                                            }
                                            local_1f8 = CONCAT44(local_218._4_4_ / fVar29,
                                                                 (float)local_218 / fVar29);
                                            local_res18 = CONCAT44(local_208._4_4_ / fVar29,
                                                                   (float)local_208 / fVar29);
                                            goto LAB_18157edbf;
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

    // Token : 0x60001F6
    // RVA   : 0x157F3C0   Offset: 0x157DBC0   Length: 0x260
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
        uVar4 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(uVar4,DAT_181d7c250);
        this.items = uVar4;
        uVar4 = il2cpp_internal(DAT_181d701b0);
        FUN_180f58a90(uVar4,DAT_181d6dfe8);
        this.itemData = uVar4;
        uVar4 = il2cpp_internal(DAT_181d6bdb0);
        FUN_180f58a90(uVar4,DAT_181d53c78);
        this.itemCallbacks = uVar4;
        this.padding = 0x40800000;
        *(uint32 *)(this + 132) = 0x40800000;
        puVar5 = (uint32 *)FUN_181098a50(local_18,0);
        uVar1 = puVar5[1];
        uVar2 = puVar5[2];
        uVar3 = puVar5[3];
        this.textColor = *puVar5;
        *(uint32 *)(this + 140) = uVar1;
        *(uint32 *)(this + 144) = uVar2;
        *(uint32 *)(this + 148) = uVar3;
        puVar6 = (uint64 *)FUN_181098a50(local_18,0);
        uVar4 = puVar6[1];
        local_28 = 0;
        uStack_20 = 0;
        this.backgroundColor = *puVar6;
        *(uint64 *)(this + 160) = uVar4;
        FUN_1809981e0(&local_28,0x3f61e1e2,0x3f48c8c9,0x3f169697,0x3f800000,0);
        this.isAnimated = 1;
        this.separatePanel = 1;
        this.highlightColor = (uint32)local_28;
        *(uint32 *)(this + 172) = local_28._4_4_;
        *(uint32 *)(this + 176) = (uint32)uStack_20;
        *(uint32 *)(this + 180) = uStack_20._4_4_;
        uVar4 = il2cpp_internal(DAT_181d6d9b0);
        FUN_180f58a90(uVar4,DAT_181d5e700);
        this.onChange = uVar4;
        uVar4 = il2cpp_internal(DAT_181d739b0);
        FUN_180f58a90(uVar4,DAT_181d82278);
        this.mLabelList = uVar4;
        this.functionName = "OnSelectionChange";
        TrailRenderer_Base.ctor(this,0);
    }

    // Token : 0x60001F7
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private static void /*cctor*/()
    {
    }

}
