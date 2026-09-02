// ============================================================
// Type  : UIInput
// Token : 0x20000F4
// ============================================================

public class UIInput
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40005C6
    public static UIInput current;

    // Token: 0x40005C7
    public static UIInput selection;

    // Token: 0x40005C8
    public UILabel label;

    // Token: 0x40005C9
    public InputType inputType;

    // Token: 0x40005CA
    public OnReturnKey onReturnKey;

    // Token: 0x40005CB
    public KeyboardType keyboardType;

    // Token: 0x40005CC
    public bool hideInput;

    // Token: 0x40005CD
    public bool selectAllTextOnFocus;

    // Token: 0x40005CE
    public bool submitOnUnselect;

    // Token: 0x40005CF
    public Validation validation;

    // Token: 0x40005D0
    public int characterLimit;

    // Token: 0x40005D1
    public string savedAs;

    // Token: 0x40005D2
    private GameObject selectOnTab;

    // Token: 0x40005D3
    public Color activeTextColor;

    // Token: 0x40005D4
    public Color caretColor;

    // Token: 0x40005D5
    public Color selectionColor;

    // Token: 0x40005D6
    public List<EventDelegate> onSubmit;

    // Token: 0x40005D7
    public List<EventDelegate> onChange;

    // Token: 0x40005D8
    public OnValidate onValidate;

    // Token: 0x40005D9
    protected string mValue;

    // Token: 0x40005DA
    protected string mDefaultText;

    // Token: 0x40005DB
    protected Color mDefaultColor;

    // Token: 0x40005DC
    protected float mPosition;

    // Token: 0x40005DD
    protected bool mDoInit;

    // Token: 0x40005DE
    protected Alignment mAlignment;

    // Token: 0x40005DF
    protected bool mLoadSavedValue;

    // Token: 0x40005E0
    protected static int mDrawStart;

    // Token: 0x40005E1
    protected static string mLastIME;

    // Token: 0x40005E2
    protected int mSelectionStart;

    // Token: 0x40005E3
    protected int mSelectionEnd;

    // Token: 0x40005E4
    protected UITexture mHighlight;

    // Token: 0x40005E5
    protected UITexture mCaret;

    // Token: 0x40005E6
    protected Texture2D mBlankTex;

    // Token: 0x40005E7
    protected float mNextBlink;

    // Token: 0x40005E8
    protected float mLastAlpha;

    // Token: 0x40005E9
    protected string mCached;

    // Token: 0x40005EA
    protected int mSelectMe;

    // Token: 0x40005EB
    protected int mSelectTime;

    // Token: 0x40005EC
    protected bool mStarted;

    // Token: 0x40005ED
    private UIInputOnGUI mOnGUI;

    // Token: 0x40005EE
    private UICamera mCam;

    // Token: 0x40005EF
    private bool mEllipsis;

    // Token: 0x40005F0
    private static int mIgnoreKey;

    // Token: 0x40005F1
    public Action onUpArrow;

    // Token: 0x40005F2
    public Action onDownArrow;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60007B3
    // RVA   : 0x10F2040   Offset: 0x10F0840   Length: 0x33
    public string get_defaultText()
    {
        if (this.mDoInit) {
          UIInput.Init(this,0);
          return this.mDefaultText;
        }
        return this.mDefaultText;
    }

    // Token : 0x60007B4
    // RVA   : 0x10F2300   Offset: 0x10F0B00   Length: 0x46
    public void set_defaultText(string value)
    {
        if (this.mDoInit) {
          UIInput.Init(this,0);
        }
        this.mDefaultText = value;
        UIInput.UpdateLabel(this,0);
    }

    // Token : 0x60007B5
    // RVA   : 0x10F2000   Offset: 0x10F0800   Length: 0x3B
    public Color get_defaultColor()
    {
        ulong uVar1;
        if (*(char *)(param_2 + 180) != false) {
          UIInput.Init(param_2,0);
        }
        uVar1 = *(uint64 *)(param_2 + 168);
        *this = *(uint64 *)(param_2 + 160);
        this[1] = uVar1;
        return this;
    }

    // Token : 0x60007B6
    // RVA   : 0x10F22A0   Offset: 0x10F0AA0   Length: 0x53
    public void set_defaultColor(Color value)
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        uint uVar4;
        bool cVar5;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        uVar1 = *value;
        uVar2 = value[1];
        uVar3 = value[2];
        uVar4 = value[3];
        this.mDefaultColor = uVar1;
        *(uint32 *)(this + 164) = uVar2;
        *(uint32 *)(this + 168) = uVar3;
        *(uint32 *)(this + 172) = uVar4;
        cVar5 = UIInput.get_isSelected(uVar1,0);
        if (!cVar5) {
          if (this.label == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          local_18 = *value;
          uStack_14 = value[1];
          uStack_10 = value[2];
          uStack_c = value[3];
          UIWidget.set_color(this.label,&local_18,0);
        }
    }

    // Token : 0x60007B7
    // RVA   : 0x10F2080   Offset: 0x10F0880   Length: 0x94
    public bool get_inputShouldBeHidden()
    {
        ulong uVar1;
        ulong in_RAX;
        if (this.hideInput) {
          uVar1 = this.label;
          in_RAX = Object.op_Inequality(uVar1,0,0);
          if ((char)in_RAX) {
            in_RAX = this.label;
            if (in_RAX == 0) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (in_RAX.mMaxLineCount == 1) {
              return CONCAT71((int7)(in_RAX >> 8),this.inputType != 2);
            }
          }
        }
        return in_RAX & 0xffffffffffffff00;
    }

    // Token : 0x60007B8
    // RVA   : 0x10F2220   Offset: 0x10F0A20   Length: 0x33
    public string get_text()
    {
        if (this.mDoInit) {
          UIInput.Init(this,0);
          return this.mValue;
        }
        return this.mValue;
    }

    // Token : 0x60007B9
    // RVA   : 0x10F2450   Offset: 0x10F0C50   Length: 0x8
    public void set_text(string value)
    {
        void FUN_1810f2450(uint64 this,uint64 value)
        {
        UIInput.set_value(this,value,0);
    }

    // Token : 0x60007BA
    // RVA   : 0x10F2220   Offset: 0x10F0A20   Length: 0x33
    public string get_value()
    {
        if (this.mDoInit) {
          UIInput.Init(this,0);
          return this.mValue;
        }
        return this.mValue;
    }

    // Token : 0x60007BB
    // RVA   : 0x10F2460   Offset: 0x10F0C60   Length: 0x171
    public void set_value(string value)
    {
        uint uVar1;
        bool cVar2;
        long lVar3;
        if (this.mDoInit) {
          UIInput.Init(this,0);
          if (this.mDoInit) {
            UIInput.Init(this,0);
          }
        }
        cVar2 = FUN_1816fd990(value,this.mValue,0);
        if (!cVar2) {
          *(uint32 *)(*(int64 *)(DAT_181d8a958 + 184) + 16) = 0;
          lVar3 = UIInput.Validate(this,value,0);
          cVar2 = String.op_Inequality(this.mValue,lVar3,0);
          if (cVar2) {
            this.mValue = lVar3;
            this.mLoadSavedValue = 0;
            cVar2 = UIInput.get_isSelected(this,0);
            if (!cVar2) {
              if (this.mStarted) {
                UIInput.SaveToPlayerPrefs(this,lVar3,0);
              }
            }
            else {
              cVar2 = FUN_180d6ca90(lVar3,0);
              if (!cVar2) {
                if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                uVar1 = *(uint32 *)(lVar3 + 16);
                this.mSelectionStart = uVar1;
                this.mSelectionEnd = uVar1;
              }
              else {
                this.mSelectionStart = 0;
              }
            }
            UIInput.UpdateLabel(this,0);
            UIInput.ExecuteOnChange(this,0);
          }
        }
    }

    // Token : 0x60007BC
    // RVA   : 0x10EF8C0   Offset: 0x10EE0C0   Length: 0x184
    public void Set(string value, bool notify)
    {
        uint uVar1;
        bool cVar2;
        long lVar3;
        if (this.mDoInit) {
          UIInput.Init(this,0);
          if (this.mDoInit) {
            UIInput.Init(this,0);
          }
        }
        cVar2 = FUN_1816fd990(value,this.mValue,0);
        if (!cVar2) {
          *(uint32 *)(*(int64 *)(DAT_181d8a958 + 184) + 16) = 0;
          lVar3 = UIInput.Validate(this,value,0);
          cVar2 = String.op_Inequality(this.mValue,lVar3,0);
          if (cVar2) {
            this.mValue = lVar3;
            this.mLoadSavedValue = 0;
            cVar2 = UIInput.get_isSelected(this,0);
            if (!cVar2) {
              if (this.mStarted) {
                UIInput.SaveToPlayerPrefs(this,lVar3,0);
              }
            }
            else {
              cVar2 = FUN_180d6ca90(lVar3,0);
              if (!cVar2) {
                if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                uVar1 = *(uint32 *)(lVar3 + 16);
                this.mSelectionStart = uVar1;
                this.mSelectionEnd = uVar1;
              }
              else {
                this.mSelectionStart = 0;
              }
            }
            UIInput.UpdateLabel(this,0);
            if (notify) {
              UIInput.ExecuteOnChange(this,0);
            }
          }
        }
    }

    // Token : 0x60007BD
    // RVA   : 0x10F21C0   Offset: 0x10F09C0   Length: 0x7
    public bool get_selected()
    {
        void FUN_1810f21c0(uint64 this)
        {
        UIInput.get_isSelected(this,0);
    }

    // Token : 0x60007BE
    // RVA   : 0x10F2400   Offset: 0x10F0C00   Length: 0x8
    public void set_selected(bool value)
    {
        void FUN_1810f2400(uint64 this,uint64 value)
        {
        UIInput.set_isSelected(this,value,0);
    }

    // Token : 0x60007BF
    // RVA   : 0x10F2120   Offset: 0x10F0920   Length: 0x9E
    public bool get_isSelected()
    {
        ulong uVar1;
        uVar1 = *(uint64 *)(*(int64 *)(DAT_181d8a958 + 184) + 8);
        Object.op_Equality(uVar1,this,0);
    }

    // Token : 0x60007C0
    // RVA   : 0x10F2350   Offset: 0x10F0B50   Length: 0xAB
    public void set_isSelected(bool value)
    {
        ulong uVar1;
        bool cVar2;
        if (value) {
          uVar1 = Component.get_gameObject();
          UICamera.set_selectedObject(uVar1,0);
          return;
        }
        cVar2 = UIInput.get_isSelected(this,0);
        if (cVar2) {
          UICamera.set_selectedObject(0,0);
        }
    }

    // Token : 0x60007C1
    // RVA   : 0x10F1FB0   Offset: 0x10F07B0   Length: 0x4D
    public int get_cursorPosition()
    {
        bool cVar1;
        cVar1 = UIInput.get_isSelected(this,0);
        if (cVar1) {
          return this.mSelectionEnd;
        }
        if (this.mDoInit) {
          UIInput.Init(this,0);
        }
        if (this.mValue != null) {
          return *(uint32 *)(this.mValue + 16);
        }
    }

    // Token : 0x60007C2
    // RVA   : 0x10F2260   Offset: 0x10F0A60   Length: 0x35
    public void set_cursorPosition(int value)
    {
        bool cVar1;
        cVar1 = UIInput.get_isSelected(this,0);
        if (cVar1) {
          this.mSelectionEnd = value;
          UIInput.UpdateLabel(this,0);
        }
    }

    // Token : 0x60007C3
    // RVA   : 0x10F21D0   Offset: 0x10F09D0   Length: 0x4D
    public int get_selectionStart()
    {
        bool cVar1;
        cVar1 = UIInput.get_isSelected(this,0);
        if (cVar1) {
          return this.mSelectionStart;
        }
        if (this.mDoInit) {
          UIInput.Init(this,0);
        }
        if (this.mValue != null) {
          return *(uint32 *)(this.mValue + 16);
        }
    }

    // Token : 0x60007C4
    // RVA   : 0x10F2410   Offset: 0x10F0C10   Length: 0x35
    public void set_selectionStart(int value)
    {
        bool cVar1;
        cVar1 = UIInput.get_isSelected(this,0);
        if (cVar1) {
          this.mSelectionStart = value;
          UIInput.UpdateLabel(this,0);
        }
    }

    // Token : 0x60007C5
    // RVA   : 0x10F1FB0   Offset: 0x10F07B0   Length: 0x4D
    public int get_selectionEnd()
    {
        bool cVar1;
        cVar1 = UIInput.get_isSelected(this,0);
        if (cVar1) {
          return this.mSelectionEnd;
        }
        if (this.mDoInit) {
          UIInput.Init(this,0);
        }
        if (this.mValue != null) {
          return *(uint32 *)(this.mValue + 16);
        }
    }

    // Token : 0x60007C6
    // RVA   : 0x10F2260   Offset: 0x10F0A60   Length: 0x35
    public void set_selectionEnd(int value)
    {
        bool cVar1;
        cVar1 = UIInput.get_isSelected(this,0);
        if (cVar1) {
          this.mSelectionEnd = value;
          UIInput.UpdateLabel(this,0);
        }
    }

    // Token : 0x60007C7
    // RVA   : 0x2A2F90   Offset: 0x2A1790   Length: 0x8
    public UITexture get_caret()
    {
        uint64 FUN_1802a2f90(int64 this)
        {
        return this.mCaret;
    }

    // Token : 0x60007C8
    // RVA   : 0x10F1880   Offset: 0x10F0080   Length: 0x1FC
    public string Validate(string val)
    {
        int iVar1;
        bool cVar2;
        uint uVar5;
        uint uVar6;
        uVar6 = (uint32)param_4;
        if (this.validation == null) {
          return uVar6;
        }
        cVar2 = Behaviour.get_enabled(this,0);
        if (!cVar2) {
          return uVar6;
        }
        iVar1 = this.validation;
        if (iVar1 == 1) {
          if ((uint16)(param_4 - 48) < 10) {
            return uVar6;
          }
          if (param_4 != 45) {
            return 0;
          }
          if (param_3 != 0) {
            return 0;
          }
          if (val != null) {
            cVar2 = String.Contains(val,"-",0);
            if (cVar2) {
              return 0;
            }
            return 45;
          }
        LAB_1810f1d5d:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (iVar1 == 2) {
          if ((uint16)(param_4 - 48) < 10) {
            return uVar6;
          }
          if (param_4 == 45) {
            if (param_3 != 0) {
              return 0;
            }
            if (val != null) {
              cVar2 = String.Contains(val,"-",0);
              if (!cVar2) {
                return 45;
              }
              return 0;
            }
          }
          else {
            if (param_4 != 46) {
              return 0;
            }
            if (val != null) {
              cVar2 = String.Contains(val,".",0);
              if (cVar2) {
                return 0;
              }
              return 46;
            }
          }
          goto LAB_1810f1d5d;
        }
        if (iVar1 == 3) {
          if ((uint16)(param_4 - 65) < 26) {
            return uVar6;
          }
        LAB_1810f1c95:
          if ((uint16)(param_4 - 97) < 26) {
            return uVar6;
          }
          if (9 < (uint16)(param_4 - 48)) {
            return 0;
          }
          return uVar6;
        }
        if (iVar1 == 4) {
          if (25 < (uint16)(param_4 - 65)) goto LAB_1810f1c95;
          goto LAB_1810f1c87;
        }
        if (iVar1 == 6) {
          if (((uint16)(uVar6 - 34) < 63) &&
             ((0x5400000017002101U >> ((uint64)(uVar6 - 34) & 63) & 1) != 0)) {
            return 0;
          }
          if (param_4 == 124) {
            return 0;
          }
          if ((uint16)(param_4 - 9) < 2) {
            return 0;
          }
          return uVar6;
        }
        if (iVar1 != 5) {
          return 0;
        }
        if (val == null) goto LAB_1810f1d5d;
        sVar3 = 32;
        if (*(int *)(val + 16) < 1) {
        LAB_1810f1b92:
          sVar4 = 10;
        }
        else {
          uVar5 = Mathf.Clamp(param_3,0,*(int *)(val + 16) + -1,0);
          sVar3 = String.get_Chars(val,uVar5,0);
          if (*(int *)(val + 16) < 1) goto LAB_1810f1b92;
          uVar5 = Mathf.Clamp(param_3 + 1,0,*(int *)(val + 16) + -1,0);
          sVar4 = String.get_Chars(val,uVar5,0);
        }
        if ((uint16)(param_4 - 97) < 26) {
          if (sVar3 == 32) {
            return uVar6 - 32;
          }
          return uVar6;
        }
        if (25 < (uint16)(param_4 - 65)) {
          if (param_4 == 39) {
            if (sVar3 == 32) {
              return 0;
            }
            if (sVar3 == 39) {
              return 0;
            }
            if (sVar4 == 39) {
              return 0;
            }
            cVar2 = String.Contains(val,"'",0);
            if (cVar2) {
              return 0;
            }
            return 39;
          }
          if (param_4 != 32) {
            return 0;
          }
          if (sVar3 == 32) {
            return 0;
          }
          if (sVar3 == 39) {
            return 0;
          }
          if (sVar4 == 32) {
            return 0;
          }
          if (sVar4 == 39) {
            return 0;
          }
          return 32;
        }
        if (sVar3 == 32) {
          return uVar6;
        }
        if (sVar3 == 39) {
          return uVar6;
        }
        LAB_1810f1c87:
        return uVar6 + 32;
    }

    // Token : 0x60007C9
    // RVA   : 0x10EFA50   Offset: 0x10EE250   Length: 0x291
    public void Start()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        if (this.mStarted) {
          return;
        }
        uVar3 = this.selectOnTab;
        cVar1 = Object.op_Inequality(uVar3,0,0);
        if (cVar1) {
          uVar3 = Component.GetComponent(this,DAT_181d6e1c0);
          cVar1 = Object.op_Equality(uVar3,0,0);
          if (cVar1) {
            lVar2 = Component.get_gameObject(this,0);
            if (lVar2 == null) goto LAB_1810efcdc;
            lVar2 = GameObject.AddComponent(lVar2,DAT_181d9dde8);
            if (lVar2 == null) goto LAB_1810efcdc;
            *(uint64 *)(lVar2 + 40) = this.selectOnTab;
          }
          this.selectOnTab = 0;
          ZhSegment.Initialize(this,"last change",0);
        }
        if ((!this.mLoadSavedValue) ||
           (cVar1 = FUN_180d6ca90(this.savedAs,0), cVar1)) {
          if (this.mValue == null) {
        LAB_1810efcdc:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar3 = String.Replace(this.mValue,"\\n","\n",0);
        }
        else {
          cVar1 = FUN_180d6ca90(this.savedAs,0);
          if (cVar1) goto LAB_1810efcc5;
          if (this.mValue == null) goto LAB_1810efcdc;
          uVar3 = String.Replace(this.mValue,"\\n","\n",0);
          this.mValue = "";
          cVar1 = PlayerPrefs.HasKey(this.savedAs,0);
          if (cVar1) {
            uVar3 = PlayerPrefs.GetString(this.savedAs,0);
          }
        }
        UIInput.set_value(this,uVar3,0);
        LAB_1810efcc5:
        this.mStarted = 1;
    }

    // Token : 0x60007CA
    // RVA   : 0x10EDDD0   Offset: 0x10EC5D0   Length: 0x185
    protected void Init()
    {
        ulong uVar1;
        uint uVar2;
        uint uVar3;
        uint uVar4;
        bool cVar5;
        long lVar6;
        byte[] local_18 = new byte[16];
        if (this.mDoInit) {
          uVar1 = this.label;
          cVar5 = Object.op_Inequality(uVar1,0,0);
          if (cVar5) {
            this.mDoInit = 0;
            if (this.label != null) {
              this.mDefaultText = this.label.mText;
              lVar6 = this.label;
              if (lVar6 != null) {
                uVar2 = *(uint32 *)(lVar6 + 148);
                uVar3 = *(uint32 *)(lVar6 + 152);
                uVar4 = *(uint32 *)(lVar6 + 156);
                this.mDefaultColor = *(uint32 *)(lVar6 + 144);
                *(uint32 *)(this + 164) = uVar2;
                *(uint32 *)(this + 168) = uVar3;
                *(uint32 *)(this + 172) = uVar4;
                this.mEllipsis = lVar6.mOverflowEllipsis;
                if (lVar6.mAlignment == 4) {
                  lVar6.mAlignment = 1;
                  *(uint8 *)(lVar6 + 88) = 1;
                  lVar6.mShouldBeProcessed = 1;
                  UILabel.ProcessAndRequest(lVar6,0);
                  Debug.LogWarning("Input fields using labels with justified alignment are not supported at this time",this,0);
                  lVar6 = this.label;
                }
                if (lVar6 != null) {
                  this.mAlignment = lVar6.mAlignment;
                  lVar6 = UIRect.get_cachedTransform(lVar6,0);
                  if (lVar6 != null) {
                    puVar7 = (uint32 *)Transform.get_localPosition(local_18,lVar6,0);
                    this.mPosition = *puVar7;
                    UIInput.UpdateLabel(this,0);
                    return;
                  }
                }
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x60007CB
    // RVA   : 0x10EF800   Offset: 0x10EE000   Length: 0x58
    protected void SaveToPlayerPrefs(string val)
    {
        bool cVar1;
        cVar1 = FUN_180d6ca90(this.savedAs,0);
        if (!cVar1) {
          cVar1 = FUN_180d6ca90(val,0);
          if (!cVar1) {
            PlayerPrefs.SetString(this.savedAs,val,0);
            return;
          }
          PlayerPrefs.DeleteKey(this.savedAs,0);
        }
    }

    // Token : 0x60007CC
    // RVA   : 0x10EEDA0   Offset: 0x10ED5A0   Length: 0x31F
    protected virtual void OnSelect(bool isSelected)
    {
        bool cVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        if (!isSelected) {
          uVar4 = this.mOnGUI;
          cVar1 = Object.op_Inequality(uVar4,0,0);
          if (cVar1) {
            uVar4 = this.mOnGUI;
            Object.Destroy(uVar4,0);
            this.mOnGUI = 0;
          }
          UIInput.OnDeselectEvent(this,0);
          return;
        }
        uVar4 = this.label;
        cVar1 = Object.op_Inequality(uVar4,0,0);
        if (cVar1) {
          lVar3 = this.label;
          if (lVar3 == null) goto LAB_1810ef0ba;
          if (lVar3.mEncoding) {
            lVar3.mEncoding = 0;
            *(uint8 *)(lVar3 + 88) = 1;
            lVar3.mShouldBeProcessed = 1;
          }
        }
        uVar4 = this.mOnGUI;
        cVar1 = Object.op_Equality(uVar4,0,0);
        if (cVar1) {
          lVar3 = Component.get_gameObject(this,0);
          if (lVar3 == null) goto LAB_1810ef0ba;
          uVar4 = GameObject.AddComponent(lVar3,DAT_181d9dd60);
          this.mOnGUI = uVar4;
        }
        uVar2 = Time.get_frameCount(0);
        this.mSelectTime = uVar2;
        plVar5 = (int64 *)(*(int64 *)(DAT_181d8a958 + 184) + 8);
        *plVar5 = this;
        il2cpp_internal(plVar5,this);
        if (this.mDoInit) {
          UIInput.Init(this,0);
        }
        uVar4 = this.label;
        cVar1 = Object.op_Inequality(uVar4,0,0);
        if (cVar1) {
          plVar5 = this.label;
          if (plVar5 == (int64 *)0) {
        LAB_1810ef0ba:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          this.mEllipsis = (char)plVar5[67];
          if ((char)plVar5[67] != false) {
            *(uint8 *)(plVar5 + 67) = 0;
            (**(code **)(*plVar5 + 0x328))(plVar5,*(uint64 *)(*plVar5 + 0x330));
          }
        }
        uVar4 = this.label;
        cVar1 = Object.op_Inequality(uVar4,0,0);
        if (cVar1) {
          cVar1 = NGUITools.GetActive(this,0);
          if (cVar1) {
            uVar2 = Time.get_frameCount(0);
            this.mSelectMe = uVar2;
          }
        }
    }

    // Token : 0x60007CD
    // RVA   : 0x10EEC10   Offset: 0x10ED410   Length: 0x188
    protected void OnSelectEvent()
    {
        ulong uVar1;
        bool cVar2;
        uint uVar3;
        uVar3 = Time.get_frameCount(0);
        this.mSelectTime = uVar3;
        plVar4 = (int64 *)(*(int64 *)(DAT_181d8a958 + 184) + 8);
        *plVar4 = this;
        il2cpp_internal(plVar4,this);
        if (this.mDoInit) {
          UIInput.Init(this,0);
        }
        uVar1 = this.label;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          plVar4 = this.label;
          if (plVar4 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          this.mEllipsis = (char)plVar4[67];
          if ((char)plVar4[67] != false) {
            *(uint8 *)(plVar4 + 67) = 0;
            (**(code **)(*plVar4 + 0x328))(plVar4,*(uint64 *)(*plVar4 + 0x330));
          }
        }
        uVar1 = this.label;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          cVar2 = NGUITools.GetActive(this,0);
          if (cVar2) {
            uVar3 = Time.get_frameCount(0);
            this.mSelectMe = uVar3;
          }
        }
    }

    // Token : 0x60007CE
    // RVA   : 0x10EE4D0   Offset: 0x10ECCD0   Length: 0x25B
    protected void OnDeselectEvent()
    {
        ulong uVar1;
        long lVar3;
        bool cVar4;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        if (this.mDoInit) {
          UIInput.Init(this,0);
        }
        uVar1 = this.label;
        cVar4 = Object.op_Inequality(uVar1,0,0);
        if (cVar4) {
          plVar2 = this.label;
          if (plVar2 == (int64 *)0) goto LAB_1810ee726;
          if ((char)plVar2[67] != this.mEllipsis) {
            *(char *)(plVar2 + 67) = this.mEllipsis;
            (**(code **)(*plVar2 + 0x328))(plVar2,*(uint64 *)(*plVar2 + 0x330));
          }
        }
        uVar1 = this.label;
        cVar4 = Object.op_Inequality(uVar1,0,0);
        if (cVar4) {
          cVar4 = NGUITools.GetActive(this,0);
          if (!cVar4) goto LAB_1810ee6c0;
          if (this.mDoInit) {
            UIInput.Init(this,0);
          }
          il2cpp_internal(this + 144,this.mValue);
          cVar4 = FUN_180d6ca90(this.mValue,0);
          lVar3 = this.label;
          if (!cVar4) {
            if (lVar3 == null) goto LAB_1810ee726;
            UILabel.set_text(lVar3,this.mValue,0);
          }
          else {
            if (lVar3 == null) goto LAB_1810ee726;
            UILabel.set_text(lVar3,this.mDefaultText,0);
            if (this.label == null) goto LAB_1810ee726;
            local_18 = this.mDefaultColor;
            uStack_14 = *(uint32 *)(this + 164);
            uStack_10 = *(uint32 *)(this + 168);
            uStack_c = *(uint32 *)(this + 172);
            UIWidget.set_color(this.label,&local_18,0);
          }
          Input.set_imeCompositionMode(0,0);
          lVar3 = this.label;
          if (lVar3 == null) {
        LAB_1810ee726:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (lVar3.mAlignment != this.mAlignment) {
            lVar3.mAlignment = this.mAlignment;
            *(uint8 *)(lVar3 + 88) = 1;
            lVar3.mShouldBeProcessed = 1;
            UILabel.ProcessAndRequest(lVar3,0);
          }
        }
        LAB_1810ee6c0:
        puVar5 = (uint64 *)(*(int64 *)(DAT_181d8a958 + 184) + 8);
        *puVar5 = 0;
        il2cpp_internal(puVar5,0);
        UIInput.UpdateLabel(this,0);
        if (this.submitOnUnselect) {
          UIInput.Submit(this,0);
        }
    }

    // Token : 0x60007CF
    // RVA   : 0x10F0D10   Offset: 0x10EF510   Length: 0xB63
    protected virtual void Update()
    {
        var pStatics_a458 = *(int64*)(DAT_181d8a458 + 184);
        var pStatics_a958 = *(int64*)(DAT_181d8a958 + 184);
        bool cVar1;
        int iVar2;
        int iVar3;
        uint uVar4;
        ulong uVar5;
        long lVar6;
        long lVar7;
        float fVar11;
        uint uVar12;
        float fVar13;
        ushort[] local_res18 = new ushort[8];
        ulong local_58;
        uint local_50;
        uint local_48;
        uint uStack_44;
        uint uStack_40;
        uint32 uStack_3c;
        local_res18[0] = 0;
        cVar1 = UIInput.get_isSelected(this,0);
        if (!cVar1) {
          return;
        }
        iVar3 = *(int *)((int64)this + 244);
        iVar2 = Time.get_frameCount(0);
        if (iVar3 == iVar2) {
          return;
        }
        if (*(char *)((int64)this + 180) != false) {
          UIInput.Init(this,0);
        }
        lVar6 = this[30];
        if (((int)lVar6 != -1) && (iVar3 = Time.get_frameCount(0), (int)lVar6 != iVar3)) {
          *(uint32 *)(this + 30) = 0xffffffff;
          cVar1 = FUN_180d6ca90(this[18],0);
          if (!cVar1) {
            if (this[18] == 0) goto LAB_1810f184e;
            uVar4 = *(uint32 *)(this[18] + 16);
          }
          else {
            uVar4 = 0;
          }
          *(uint32 *)((int64)this + 196) = uVar4;
          *(uint32 *)(pStatics_a958 + 16) = 0;
          uVar4 = 0;
          if (*(char *)((int64)this + 45) == false) {
            uVar4 = *(uint32 *)((int64)this + 196);
          }
          this.label = uVar4;
          if (this[3] == 0) goto LAB_1810f184e;
          local_48 = (uint32)this[9];
          uStack_44 = *(uint32 *)((int64)this + 76);
          uStack_40 = (uint32)this[10];
          uStack_3c = *(uint32 *)((int64)this + 84);
          UIWidget.set_color(this[3],&local_48,0);
          uVar5 = *(uint64 *)(pStatics_a458 + 184);
          cVar1 = Object.op_Inequality(uVar5,0,0);
          if (!cVar1) {
        LAB_1810f1013:
            plVar9 = (int64 *)this[3];
            if ((plVar9 == (int64 *)0) ||
               (lVar6 = (**(code **)(*plVar9 + 0x1e8))(plVar9,*(uint64 *)(*plVar9 + 0x1f0)),
               lVar6 == null)) goto LAB_1810f184e;
            if (*(int *)(lVar6 + 24) == 0) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            uVar4 = (uint32)*(uint64 *)(lVar6 + 32);
            uVar12 = (uint32)((uint64)*(uint64 *)(lVar6 + 32) >> 32);
          }
          else {
            lVar6 = *(int64 *)(pStatics_a458 + 184);
            if (lVar6 == null) goto LAB_1810f184e;
            uVar5 = UICamera.get_cachedCamera(lVar6,0);
            cVar1 = Object.op_Inequality(uVar5,0,0);
            if (!cVar1) goto LAB_1810f1013;
            lVar6 = *(int64 *)(pStatics_a458 + 184);
            if (lVar6 == null) goto LAB_1810f184e;
            lVar6 = UICamera.get_cachedCamera(lVar6,0);
            plVar9 = (int64 *)this[3];
            if ((plVar9 == (int64 *)0) ||
               (lVar7 = (**(code **)(*plVar9 + 0x1e8))(plVar9,*(uint64 *)(*plVar9 + 0x1f0)),
               lVar7 == null)) goto LAB_1810f184e;
            if (*(int *)(lVar7 + 24) == 0) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            if (lVar6 == null) goto LAB_1810f184e;
            local_58 = *(uint64 *)(lVar7 + 32);
            local_50 = *(uint32 *)(lVar7 + 40);
            puVar8 = (uint64 *)Camera.WorldToScreenPoint(&local_48,lVar6,&local_58,0);
            uVar4 = (uint32)*puVar8;
            uVar12 = (uint32)((uint64)*puVar8 >> 32);
          }
          local_58 = CONCAT44(uVar12,uVar4);
          iVar3 = Screen.get_height(0);
          fVar13 = (float)iVar3 - local_58._4_4_;
          Input.set_imeCompositionMode(1);
          Input.set_compositionCursorPos(CONCAT44(fVar13,(uint32)local_58),0);
          UIInput.UpdateLabel(this,0);
          uVar5 = Input.get_inputString(0);
          cVar1 = FUN_180d6ca90(uVar5,0);
          if (cVar1) {
            return;
          }
        }
        lVar6 = Input.get_compositionString(0);
        cVar1 = FUN_180d6ca90(lVar6,0);
        if (cVar1) {
          uVar5 = Input.get_inputString(0);
          cVar1 = FUN_180d6ca90(uVar5,0);
          if (!cVar1) {
            lVar7 = Input.get_inputString(0);
            iVar3 = 0;
            if (lVar7 == null) goto LAB_1810f184e;
            for (; iVar3 < *(int *)(lVar7 + 16); iVar3 = iVar3 + 1) {
              local_res18[0] = String.get_Chars(lVar7,iVar3);
              if (((31 < local_res18[0]) && (3 < (uint16)(local_res18[0] + 0x900))) &&
                 (local_res18[0] != 0xf728)) {
                uVar5 = Char.ToString(local_res18,0);
                (**(code **)(*this + 0x1a8))(this,uVar5);
              }
            }
          }
        }
        cVar1 = String.op_Inequality(*(uint64 *)(pStatics_a958 + 24),lVar6,0)
        ;
        if (cVar1) {
          cVar1 = FUN_180d6ca90(lVar6,0);
          if (!cVar1) {
            if ((this[18] == 0) || (lVar6 == null)) goto LAB_1810f184e;
            iVar3 = *(int *)(this[18] + 16) + *(int *)(lVar6 + 16);
          }
          else {
            iVar3 = (int)this[24];
          }
          *(int *)((int64)this + 196) = iVar3;
          plVar9 = (int64 *)(pStatics_a958 + 24);
          *plVar9 = lVar6;
          il2cpp_internal(plVar9,lVar6);
          UIInput.UpdateLabel(this,0);
          UIInput.ExecuteOnChange(this,0);
        }
        lVar6 = this[26];
        cVar1 = Object.op_Inequality(lVar6,0,0);
        if ((cVar1) &&
           (fVar13 = *(float *)(this + 28), fVar11 = (float)RealTime.get_time(0), fVar13 < fVar11))
        {
          fVar13 = (float)RealTime.get_time(0);
          lVar6 = this[26];
          *(float *)(this + 28) = fVar13 + 0.5;
          if (lVar6 == null) goto LAB_1810f184e;
          cVar1 = Behaviour.get_enabled(lVar6,0);
          Behaviour.set_enabled(lVar6,!cVar1,0);
        }
        cVar1 = UIInput.get_isSelected(this,0);
        if (cVar1) {
          if (this[3] == 0) goto LAB_1810f184e;
          if (*(float *)((int64)this + 228) != *(float *)(this[3] + 140)) {
            UIInput.UpdateLabel(this,0);
          }
        }
        plVar9 = this + 33;
        lVar6 = *plVar9;
        cVar1 = Object.op_Equality(lVar6,0,0);
        if (cVar1) {
          lVar6 = Component.get_gameObject(this,0);
          if (lVar6 == null) goto LAB_1810f184e;
          uVar4 = GameObject.get_layer(lVar6,0);
          lVar6 = UICamera.FindCameraForLayer(uVar4,0);
          *plVar9 = lVar6;
          il2cpp_internal(plVar9,lVar6);
        }
        lVar6 = *plVar9;
        cVar1 = Object.op_Inequality(lVar6,0,0);
        if (!cVar1) {
          return;
        }
        bVar10 = 0;
        if (this[3] == 0) goto LAB_1810f184e;
        if (*(int *)(this[3] + 0x1b8) != 1) {
          cVar1 = FUN_1804625f0(0x132,0);
          if (!cVar1) {
            bVar10 = FUN_1804625f0(0x131,0);
          }
          else {
            bVar10 = 1;
          }
          if (*(int *)((int64)this + 36) != 1) {
            bVar10 = bVar10 ^ 1;
          }
        }
        lVar6 = *(int64 *)(pStatics_a458 + 8);
        if ((*plVar9 == 0) || (lVar6 == null)) goto LAB_1810f184e;
        cVar1 = GetKeyStateFunc.Invoke(lVar6,*(uint32 *)(*plVar9 + 124),0);
        if (!cVar1) {
          if (*plVar9 == 0) goto LAB_1810f184e;
          if (*(int *)(*plVar9 + 124) == 13) {
            lVar6 = *(int64 *)(pStatics_a458 + 8);
            if (lVar6 == null) goto LAB_1810f184e;
            cVar1 = GetKeyStateFunc.Invoke(lVar6,0x10f,0);
            if (!(cVar1))
            {
              }
              }
              else {
            }
          if (bVar10 == 0) {
            lVar6 = *(int64 *)(pStatics_a458 + 400);
            if (lVar6 == null) goto LAB_1810f184e;
            uVar5 = *(uint64 *)(lVar6 + 72);
            cVar1 = Object.op_Inequality(uVar5,0,0);
            if (cVar1) {
              lVar6 = *(int64 *)(pStatics_a458 + 400);
              if (lVar6 == null) goto LAB_1810f184e;
              *(uint32 *)(lVar6 + 112) = 0;
            }
            if (*plVar9 == 0) goto LAB_1810f184e;
            uVar4 = *(uint32 *)(*plVar9 + 124);
            UICamera.set_currentKey(uVar4,0);
            UIInput.Submit(this,0);
          }
          else {
            (**(code **)(*this + 0x1a8))(this,"\n",*(uint64 *)(*this + 0x1b0));
          }
        }
        lVar6 = *(int64 *)(pStatics_a458 + 8);
        if ((*plVar9 == 0) || (lVar6 == null)) goto LAB_1810f184e;
        cVar1 = GetKeyStateFunc.Invoke(lVar6,*(uint32 *)(*plVar9 + 128),0);
        if (!cVar1) {
          if (*plVar9 == 0) goto LAB_1810f184e;
          if (*(int *)(*plVar9 + 128) == 13) {
            lVar6 = *(int64 *)(pStatics_a458 + 8);
            if (lVar6 == null) goto LAB_1810f184e;
            cVar1 = GetKeyStateFunc.Invoke(lVar6,0x10f,0);
            if (!(cVar1))
            {
              }
              }
              else {
            }
          if (bVar10 == 0) {
            lVar6 = *(int64 *)(pStatics_a458 + 400);
            if (lVar6 == null) goto LAB_1810f184e;
            uVar5 = *(uint64 *)(lVar6 + 72);
            cVar1 = Object.op_Inequality(uVar5,0,0);
            if (cVar1) {
              lVar6 = *(int64 *)(pStatics_a458 + 400);
              if (lVar6 == null) goto LAB_1810f184e;
              *(uint32 *)(lVar6 + 112) = 0;
            }
            if (*plVar9 == 0) goto LAB_1810f184e;
            uVar4 = *(uint32 *)(*plVar9 + 128);
            UICamera.set_currentKey(uVar4,0);
            UIInput.Submit(this,0);
          }
          else {
            (**(code **)(*this + 0x1a8))(this,"\n",*(uint64 *)(*this + 0x1b0));
          }
        }
        if (*plVar9 == 0) {
        LAB_1810f184e:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (*(char *)(*plVar9 + 44) == false) {
          lVar6 = *(int64 *)(pStatics_a458 + 16);
          if (lVar6 == null) goto LAB_1810f184e;
          cVar1 = GetKeyStateFunc.Invoke(lVar6,9);
          if (cVar1) {
            UIInput.OnKey(this,9);
          }
        }
    }

    // Token : 0x60007D0
    // RVA   : 0x10EE820   Offset: 0x10ED020   Length: 0x280
    private void OnKey(KeyCode key)
    {
        var pStatics = *(int64*)(DAT_181d8a958 + 184);
        ulong uVar1;
        long lVar2;
        bool cVar3;
        int iVar4;
        iVar4 = Time.get_frameCount(0);
        if (*(int *)(pStatics + 32) != iVar4) {
          uVar1 = this.mCam;
          cVar3 = Object.op_Inequality(uVar1,0,0);
          if (cVar3) {
            lVar2 = this.mCam;
            if (lVar2 == null) goto LAB_1810eea9b;
            if ((key == lVar2.cancelKey0) || (key == lVar2.cancelKey1)) {
              bVar6 = !DAT_181e7c2eb;
              *(int *)(pStatics + 32) = iVar4;
              if (bVar6) {
                il2cpp_runtime_class_init(&DAT_181d8a458);
                DAT_181e7c2eb = true;
              }
              cVar3 = UIInput.get_isSelected(this,0);
              if (!cVar3) {
                return;
              }
              UICamera.set_selectedObject(0,0);
              return;
            }
          }
          if (key == 9) {
            bVar6 = !DAT_181e7c2eb;
            *(int *)(pStatics + 32) = iVar4;
            if (bVar6) {
              il2cpp_runtime_class_init(&DAT_181d8a458);
              DAT_181e7c2eb = true;
            }
            cVar3 = UIInput.get_isSelected(this,0);
            if (cVar3) {
              UICamera.set_selectedObject(0,0);
            }
            plVar5 = (int64 *)Component.GetComponent(this,DAT_181d6e1c0);
            cVar3 = Object.op_Inequality(plVar5,0,0);
            if (cVar3) {
              if (plVar5 != (int64 *)0) {
                          // WARNING: Could not recover jumptable at 0x0001810eea94. Too many branches
                          // WARNING: Treating indirect jump as call
                (**(code **)(*plVar5 + 0x1a8))(plVar5,9,*(uint64 *)(*plVar5 + 0x1b0));
                return;
              }
        LAB_1810eea9b:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
          }
        }
    }

    // Token : 0x60007D1
    // RVA   : 0x10ED710   Offset: 0x10EBF10   Length: 0x7B
    protected void DoBackspace()
    {
        bool cVar1;
        cVar1 = FUN_180d6ca90(this[18],0);
        if (cVar1) {
          return;
        }
        if ((int)this[24] == *(int *)((int64)this + 196)) {
          if ((int)this[24] < 1) {
            return;
          }
          *(int *)((int64)this + 196) = *(int *)((int64)this + 196) + -1;
        }
                          // WARNING: Could not recover jumptable at 0x0001810ed77e. Too many branches
                          // WARNING: Treating indirect jump as call
        (**(code **)(*this + 0x1a8))(this,"",*(uint64 *)(*this + 0x1b0));
    }

    // Token : 0x60007D2
    // RVA   : 0x10EF0C0   Offset: 0x10ED8C0   Length: 0x6A8
    public virtual bool ProcessEvent(Event ev)
    {
        var pStatics = *(int64*)(DAT_181d8a958 + 184);
        bool cVar1;
        int iVar2;
        uint uVar3;
        uint uVar4;
        ulong uVar5;
        long lVar6;
        ulong uVar7;
        lVar6 = this[3];
        cVar1 = Object.op_Equality(lVar6,0,0);
        if (cVar1) {
        switchD_1810ef275_caseD_4:
          return false;
        }
        iVar2 = Application.get_platform(0);
        if ((iVar2 == 0) || (iVar2 == 1)) {
          if (ev == null) goto LAB_1810ef761;
          uVar5 = Event.get_modifiers(ev,0);
          uVar5 = uVar5 & 8;
        }
        else {
          if (ev == null) goto LAB_1810ef761;
          uVar5 = Event.get_modifiers(ev,0);
          uVar5 = uVar5 & 2;
        }
        bVar8 = uVar5 == 0;
        uVar4 = 0;
        uVar5 = Event.get_modifiers(ev,0);
        bVar9 = (uVar5 & 4) != 0;
        uVar3 = Event.get_modifiers(ev,0);
        uVar3 = uVar3 & 1;
        iVar2 = Event.get_keyCode(ev,0);
        if (iVar2 < 100) {
          if (iVar2 == 8) {
            Event.Use(ev,0);
            UIInput.DoBackspace(this,0);
            return true;
          }
          if (iVar2 != 97) {
            if (iVar2 != 99) {
              return false;
            }
            if (bVar9 || bVar8) {
              return true;
            }
            Event.Use(ev,0);
            uVar7 = UIInput.GetSelection(this,0);
            NGUITools.set_clipboard(uVar7,0);
            return true;
          }
          if (bVar9 || bVar8) {
            return true;
          }
          Event.Use(ev,0);
          this.label = 0;
          if (this[18] != 0) {
            *(uint32 *)((int64)this + 196) = *(uint32 *)(this[18] + 16);
            UIInput.UpdateLabel(this,0);
            return true;
          }
          goto LAB_1810ef761;
        }
        if (iVar2 < 121) {
          if (iVar2 == 118) {
            if (bVar9 || bVar8) {
              return true;
            }
            Event.Use(ev,0);
            uVar7 = NGUITools.get_clipboard(0);
            (**(code **)(*this + 0x1a8))(this,uVar7,*(uint64 *)(*this + 0x1b0));
            return true;
          }
          if (iVar2 != 120) {
            return false;
          }
          if (bVar9 || bVar8) {
            return true;
          }
          Event.Use(ev,0);
          uVar7 = UIInput.GetSelection(this,0);
          NGUITools.set_clipboard(uVar7,0);
          (**(code **)(*this + 0x1a8))(this,"",*(uint64 *)(*this + 0x1b0));
          return true;
        }
        if (iVar2 == 127) {
          Event.Use(ev,0);
          cVar1 = FUN_180d6ca90(this[18],0);
          if (cVar1) {
            return true;
          }
          if ((int)this[24] == *(int *)((int64)this + 196)) {
            if (this[18] == 0) goto LAB_1810ef761;
            if (*(int *)(this[18] + 16) <= (int)this[24]) {
              return true;
            }
            *(int *)((int64)this + 196) = *(int *)((int64)this + 196) + 1;
          }
          (**(code **)(*this + 0x1a8))(this,"",*(uint64 *)(*this + 0x1b0));
          return true;
        }
        switch(iVar2 + -0x111) {
        case 0:
          Event.Use(ev,0);
          lVar6 = this[35];
          if (lVar6 != null) {
        LAB_1810ef3e9:
            FUN_18043cbb0(lVar6,0);
            return true;
          }
          cVar1 = FUN_180d6ca90(this[18]);
          if (cVar1) {
            return true;
          }
          if (this[3] != 0) {
            iVar2 = UILabel.GetCharacterIndex
                              (this[3],*(uint32 *)((int64)this + 196),0x111,0);
            *(int *)((int64)this + 196) = iVar2;
            if (iVar2 != 0) {
              iVar2 = iVar2 + *(int *)(pStatics + 16);
              *(int *)((int64)this + 196) = iVar2;
            }
            if (uVar3 == 0) {
              this.label = iVar2;
              UIInput.UpdateLabel(this,0);
              return true;
            }
            goto LAB_1810ef5b5;
          }
          goto LAB_1810ef761;
        case 1:
          Event.Use(ev,0);
          lVar6 = this[36];
          if (lVar6 != null) goto LAB_1810ef3e9;
          cVar1 = FUN_180d6ca90(this[18],0);
          if (cVar1) {
            return true;
          }
          if (this[3] == 0) goto LAB_1810ef761;
          iVar2 = UILabel.GetCharacterIndex(this[3],*(uint32 *)((int64)this + 196),0x112,0)
          ;
          *(int *)((int64)this + 196) = iVar2;
          if ((this[3] == 0) || (lVar6 = UILabel.get_processedText(this[3],0)) == null)
          goto LAB_1810ef761;
          if (iVar2 == *(int *)(lVar6 + 16)) goto LAB_1810ef592;
          iVar2 = *(int *)((int64)this + 196);
          iVar2 = *(int *)(pStatics + 16) + iVar2;
          break;
        case 2:
          Event.Use(ev,0);
          cVar1 = FUN_180d6ca90(this[18],0);
          if (cVar1) {
            return true;
          }
          if (this[18] == 0) goto LAB_1810ef761;
          iVar2 = Mathf.Min(*(int *)((int64)this + 196) + 1,*(uint32 *)(this[18] + 16),
                             0);
          break;
        case 3:
          Event.Use(ev,0);
          cVar1 = FUN_180d6ca90(this[18],0);
          if (cVar1) {
            return true;
          }
          iVar2 = Mathf.Max(*(int *)((int64)this + 196) + -1,0,0);
          break;
        default:
          goto switchD_1810ef275_caseD_4;
        case 5:
          Event.Use(ev,0);
          cVar1 = FUN_180d6ca90(this[18],0);
          if (cVar1) {
            return true;
          }
          lVar6 = this[3];
          if (lVar6 == null) goto LAB_1810ef761;
          if (*(int *)(lVar6 + 0x1b8) != 1) {
            uVar4 = UILabel.GetCharacterIndex(lVar6,*(uint32 *)((int64)this + 196),0x116,0);
          }
          *(uint32 *)((int64)this + 196) = uVar4;
          if (uVar3 == 0) {
            this.label = uVar4;
            UIInput.UpdateLabel(this,0);
            return true;
          }
          goto LAB_1810ef5b5;
        case 6:
          Event.Use(ev,0);
          cVar1 = FUN_180d6ca90(this[18],0);
          if (cVar1) {
            return true;
          }
          lVar6 = this[3];
          if (lVar6 == null) goto LAB_1810ef761;
          if (*(int *)(lVar6 + 0x1b8) == 1) goto LAB_1810ef592;
          iVar2 = UILabel.GetCharacterIndex(lVar6,*(uint32 *)((int64)this + 196),0x117,0);
          break;
        case 7:
          Event.Use(ev,0);
          cVar1 = FUN_180d6ca90(this[18],0);
          if (cVar1) {
            return true;
          }
          *(uint32 *)((int64)this + 196) = 0;
          if (uVar3 == 0) {
            this.label = 0;
          }
          UIInput.UpdateLabel(this,0);
          return true;
        case 8:
          Event.Use(ev,0);
          cVar1 = FUN_180d6ca90(this[18],0);
          if (cVar1) {
            return true;
          }
        LAB_1810ef592:
          if (this[18] == 0) {
        LAB_1810ef761:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          iVar2 = *(int *)(this[18] + 16);
        }
        *(int *)((int64)this + 196) = iVar2;
        if (uVar3 == 0) {
          this.label = iVar2;
        }
        LAB_1810ef5b5:
        UIInput.UpdateLabel(this,0);
        return true;
    }

    // Token : 0x60007D3
    // RVA   : 0x10EDF60   Offset: 0x10EC760   Length: 0x482
    protected virtual void Insert(string text)
    {
        uint uVar1;
        long lVar2;
        bool cVar3;
        int iVar5;
        int iVar6;
        uint uVar7;
        long lVar8;
        long lVar9;
        ulong uVar11;
        int iVar12;
        int iVar13;
        lVar8 = FUN_1800d60b0(DAT_181d7e600,3);
        if (lVar8 != null) {
          uVar1 = *(uint32 *)(lVar8 + 24);
          if (uVar1 == 0) {
            uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar11,0);
          }
          *(uint32 *)(lVar8 + 32) = this.mSelectionStart;
          if (uVar1 < 2) {
            uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar11,0);
          }
          *(uint32 *)(lVar8 + 36) = this.mSelectionEnd;
          if (this.mValue != null) {
            if (uVar1 < 3) {
              uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar11,0);
            }
            *(uint32 *)(lVar8 + 40) = *(uint32 *)(this.mValue + 16);
            iVar5 = Mathf.Min(lVar8,0);
            cVar3 = FUN_180d6ca90(this.mValue,0);
            lVar8 = "";
            if ((!cVar3) && (-1 < iVar5)) {
              if (this.mValue == null) throw; // [null/range check failed]
              lVar8 = String.Substring(this.mValue,0,iVar5,0);
            }
            iVar5 = Mathf.Max(this.mSelectionStart,this.mSelectionEnd,0);
            cVar3 = FUN_180d6ca90(this.mValue,0);
            lVar9 = "";
            if (!cVar3) {
              lVar2 = this.mValue;
              if (lVar2 == null) throw; // [null/range check failed]
              if (iVar5 < *(int *)(lVar2 + 16)) {
                lVar9 = String.Substring(lVar2,iVar5,0);
              }
            }
            if (((lVar9 != null) && (iVar5 = *(int *)(lVar9 + 16), lVar8 != null)) &&
               (iVar13 = *(int *)(lVar8 + 16), text != null)) {
              iVar12 = *(int *)(text + 16);
              plVar10 = (int64 *)il2cpp_internal(DAT_181d824f0);
              StringBuilder.ctor(plVar10,iVar5 + iVar12 + iVar13,0);
              if (plVar10 != (int64 *)0) {
                StringBuilder.Append(plVar10,lVar8,0);
                iVar13 = *(int *)(text + 16);
                iVar12 = 0;
                if (0 < iVar13) {
                  do {
                    sVar4 = String.get_Chars(text,iVar12,0);
                    if (sVar4 == 8) {
                      UIInput.DoBackspace(this,0);
                    }
                    else {
                      if ((0 < this.characterLimit) &&
                         (iVar6 = FUN_18123bdd0(plVar10,0), this.characterLimit <= iVar6 + iVar5))
                      break;
                      lVar8 = this.onValidate;
                      if (lVar8 == null) {
                        if (this.validation != null) {
                          uVar11 = (**(code **)(*plVar10 + 0x168))
                                             (plVar10,*(uint64 *)(*plVar10 + 0x170));
                          uVar7 = FUN_18123bdd0(plVar10,0);
                          sVar4 = UIInput.Validate(this,uVar11,uVar7,sVar4,0);
                        }
                      }
                      else {
                        uVar11 = (**(code **)(*plVar10 + 0x168))
                                           (plVar10,*(uint64 *)(*plVar10 + 0x170));
                        uVar7 = FUN_18123bdd0(plVar10,0);
                        sVar4 = OnValidate.Invoke(lVar8,uVar11,uVar7,sVar4,0);
                      }
                      if (sVar4 != 0) {
                        StringBuilder.Append(plVar10,sVar4);
                      }
                    }
                    iVar12 = iVar12 + 1;
                  } while (iVar12 < iVar13);
                }
                uVar7 = FUN_18123bdd0(plVar10,0);
                this.mSelectionStart = uVar7;
                iVar13 = 0;
                this.mSelectionEnd = uVar7;
                iVar5 = *(int *)(lVar9 + 16);
                if (0 < iVar5) {
                  do {
                    sVar4 = String.get_Chars(lVar9,iVar13,0);
                    lVar8 = this.onValidate;
                    if (lVar8 == null) {
                      if (this.validation != null) {
                        uVar11 = (**(code **)(*plVar10 + 0x168))
                                           (plVar10,*(uint64 *)(*plVar10 + 0x170));
                        uVar7 = FUN_18123bdd0(plVar10,0);
                        sVar4 = UIInput.Validate(this,uVar11,uVar7,sVar4,0);
                      }
                    }
                    else {
                      uVar11 = (**(code **)(*plVar10 + 0x168))(plVar10,*(uint64 *)(*plVar10 + 0x170));
                      uVar7 = FUN_18123bdd0(plVar10,0);
                      sVar4 = OnValidate.Invoke(lVar8,uVar11,uVar7,sVar4,0);
                    }
                    if (sVar4 != 0) {
                      StringBuilder.Append(plVar10,sVar4);
                    }
                    iVar13 = iVar13 + 1;
                  } while (iVar13 < iVar5);
                }
                uVar11 = (**(code **)(*plVar10 + 0x168))(plVar10,*(uint64 *)(*plVar10 + 0x170));
                this.mValue = uVar11;
                UIInput.UpdateLabel(this,0);
                UIInput.ExecuteOnChange(this,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60007D4
    // RVA   : 0x10EDB70   Offset: 0x10EC370   Length: 0x11F
    protected string GetLeftText()
    {
        uint uVar1;
        bool cVar2;
        int iVar3;
        long lVar4;
        ulong uVar5;
        lVar4 = FUN_1800d60b0(DAT_181d7e600,3);
        if (lVar4 != null) {
          uVar1 = *(uint32 *)(lVar4 + 24);
          if (uVar1 == 0) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          *(uint32 *)(lVar4 + 32) = this.mSelectionStart;
          if (uVar1 < 2) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          *(uint32 *)(lVar4 + 36) = this.mSelectionEnd;
          if (this.mValue != null) {
            if (uVar1 < 3) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            *(uint32 *)(lVar4 + 40) = *(uint32 *)(this.mValue + 16);
            iVar3 = Mathf.Min(lVar4,0);
            cVar2 = FUN_180d6ca90(this.mValue,0);
            if ((cVar2) || (iVar3 < 0)) {
              return "";
            }
            if (this.mValue != null) {
              uVar5 = String.Substring(this.mValue,0,iVar3,0);
              return uVar5;
            }
          }
        }
    }

    // Token : 0x60007D5
    // RVA   : 0x10EDC90   Offset: 0x10EC490   Length: 0x8D
    protected string GetRightText()
    {
        long lVar1;
        bool cVar2;
        int iVar3;
        ulong uVar4;
        iVar3 = Mathf.Max(this.mSelectionStart,this.mSelectionEnd,0);
        cVar2 = FUN_180d6ca90(this.mValue,0);
        if (!cVar2) {
          lVar1 = this.mValue;
          if (lVar1 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (iVar3 < *(int *)(lVar1 + 16)) {
            uVar4 = String.Substring(lVar1,iVar3,0);
            return uVar4;
          }
        }
        return "";
    }

    // Token : 0x60007D6
    // RVA   : 0x10EDD20   Offset: 0x10EC520   Length: 0xA1
    protected string GetSelection()
    {
        bool cVar1;
        int iVar2;
        int iVar3;
        ulong uVar4;
        cVar1 = FUN_180d6ca90(this.mValue,0);
        if (!cVar1) {
          if (this.mSelectionStart != this.mSelectionEnd) {
            iVar2 = Mathf.Min(this.mSelectionStart,this.mSelectionEnd,0);
            iVar3 = Mathf.Max(this.mSelectionStart,this.mSelectionEnd,0);
            if (this.mValue != null) {
              uVar4 = String.Substring(this.mValue,iVar2,iVar3 - iVar2,0);
              return uVar4;
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        return "";
    }

    // Token : 0x60007D7
    // RVA   : 0x10ED900   Offset: 0x10EC100   Length: 0x26D
    protected int GetCharUnderMouse()
    {
        uint uVar1;
        int iVar2;
        uint uVar3;
        bool cVar5;
        int iVar6;
        long lVar7;
        long lVar10;
        ulong uVar11;
        uint[] local_res8 = new uint[2];
        ulong local_88;
        uint local_80;
        ulong local_78;
        uint local_70;
        ulong local_68;
        uint uStack_60;
        uint32 uStack_5c;
        uint64 local_58;
        uint64 local_48;
        uint64 uStack_40;
        uint32 local_38;
        uint32 uStack_34;
        uint32 uStack_30;
        uint32 uStack_2c;
        uint64 local_28;
        plVar4 = this.label;
        local_res8[0] = 0;
        local_48 = 0;
        uStack_40 = 0;
        if (plVar4 != (int64 *)0) {
          lVar7 = (**(code **)(*plVar4 + 0x1e8))(plVar4,*(uint64 *)(*plVar4 + 0x1f0));
          puVar8 = (uint32 *)UICamera.get_currentRay(&local_68,0);
          local_38 = *puVar8;
          uStack_34 = puVar8[1];
          uStack_30 = puVar8[2];
          uStack_2c = puVar8[3];
          local_28 = *(uint64 *)(puVar8 + 4);
          if (lVar7 != null) {
            uVar1 = *(uint32 *)(lVar7 + 24);
            if (uVar1 == 0) {
              uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar11,0);
            }
            if (uVar1 < 2) {
              uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar11,0);
            }
            if (uVar1 < 3) {
              uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar11,0);
            }
            local_88 = *(uint64 *)(lVar7 + 56);
            local_80 = *(uint32 *)(lVar7 + 64);
            local_78 = *(uint64 *)(lVar7 + 44);
            local_70 = *(uint32 *)(lVar7 + 52);
            local_68 = *(uint64 *)(lVar7 + 32);
            uStack_60 = *(uint32 *)(lVar7 + 40);
            Plane.ctor(&local_48,&local_68,&local_78,&local_88,0);
            local_68 = CONCAT44(uStack_34,local_38);
            uStack_60 = uStack_30;
            uStack_5c = uStack_2c;
            local_58 = local_28;
            cVar5 = Plane.Raycast(&local_48,&local_68,local_res8,0);
            if (!cVar5) {
              return 0;
            }
            lVar7 = this.label;
            iVar2 = *(int *)(*(int64 *)(DAT_181d8a958 + 184) + 16);
            puVar9 = (uint64 *)Ray.GetPoint(&local_68,&local_38,local_res8[0],0);
            if (lVar7 != null) {
              uVar11 = *puVar9;
              uVar3 = *(uint32 *)(puVar9 + 1);
              lVar10 = UIRect.get_cachedTransform(lVar7,0);
              if (lVar10 != null) {
                local_68 = uVar11;
                uStack_60 = uVar3;
                puVar9 = (uint64 *)Transform.InverseTransformPoint(&local_78,lVar10,&local_68,0);
                iVar6 = UILabel.GetCharacterIndexAtPosition(lVar7,*puVar9,0,0);
                return iVar6 + iVar2;
              }
            }
          }
        }
    }

    // Token : 0x60007D8
    // RVA   : 0x10EEAB0   Offset: 0x10ED2B0   Length: 0x156
    protected virtual void OnPress(bool isPressed)
    {
        ulong uVar1;
        bool cVar2;
        int iVar3;
        uint uVar4;
        if ((isPressed) && (cVar2 = UIInput.get_isSelected(this,0), cVar2)) {
          uVar1 = this.label;
          cVar2 = Object.op_Inequality(uVar1,0,0);
          if (cVar2) {
            iVar3 = UICamera.get_currentScheme(0);
            if (iVar3 != 0) {
              iVar3 = UICamera.get_currentScheme(0);
              if (iVar3 != 1) {
                return;
              }
            }
            uVar4 = UIInput.GetCharUnderMouse(this,0);
            cVar2 = UIInput.get_isSelected(this,0);
            if (cVar2) {
              this.mSelectionEnd = uVar4;
              UIInput.UpdateLabel(this,0);
            }
            cVar2 = FUN_1804625f0(0x130,0);
            if ((!cVar2) && (cVar2 = FUN_1804625f0(0x12f,0), !cVar2)) {
              uVar4 = this.mSelectionEnd;
              cVar2 = UIInput.get_isSelected(this,0);
              if (cVar2) {
                this.mSelectionStart = uVar4;
                UIInput.UpdateLabel(this,0);
              }
            }
          }
        }
    }

    // Token : 0x60007D9
    // RVA   : 0x10EE730   Offset: 0x10ECF30   Length: 0xF0
    protected virtual void OnDrag(Vector2 delta)
    {
        ulong uVar1;
        bool cVar2;
        int iVar3;
        uint uVar4;
        uVar1 = this.label;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          iVar3 = UICamera.get_currentScheme(0);
          if (iVar3 != 0) {
            iVar3 = UICamera.get_currentScheme(0);
            if (iVar3 != 1) {
              return;
            }
          }
          uVar4 = UIInput.GetCharUnderMouse(this,0);
          cVar2 = UIInput.get_isSelected(this,0);
          if (cVar2) {
            this.mSelectionEnd = uVar4;
            UIInput.UpdateLabel(this,0);
          }
        }
    }

    // Token : 0x60007DA
    // RVA   : 0xEDF830   Offset: 0xEDE030   Length: 0x11
    private void OnDisable()
    {
                          // WARNING: Could not recover jumptable at 0x000180edf83a. Too many branches
                          // WARNING: Treating indirect jump as call
        (**(code **)(*this + 0x1d8))(this,*(uint64 *)(*this + 0x1e0));
    }

    // Token : 0x60007DB
    // RVA   : 0x10ED5B0   Offset: 0x10EBDB0   Length: 0x15A
    protected virtual void Cleanup()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = *(uint64 *)(this + 200);
        cVar2 = Object.op_Implicit(uVar1,0);
        if (cVar2) {
          if (*(int64 *)(this + 200) != 0)
          {
            Behaviour.set_enabled(*(int64 *)(this + 200),0,0);
            }
            uVar1 = this.mCaret;
            cVar2 = Object.op_Implicit(uVar1,0);
            if (cVar2) {
            if (this.mCaret == null) {
          }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          Behaviour.set_enabled(this.mCaret,0,0);
        }
        uVar1 = this.mBlankTex;
        cVar2 = Object.op_Implicit(uVar1,0);
        if (cVar2) {
          uVar1 = this.mBlankTex;
          NGUITools.Destroy(uVar1,0);
          this.mBlankTex = 0;
        }
    }

    // Token : 0x60007DC
    // RVA   : 0x10EFCF0   Offset: 0x10EE4F0   Length: 0x1DD
    public void Submit()
    {
        ulong uVar1;
        bool cVar4;
        cVar4 = NGUITools.GetActive(this,0);
        if (cVar4) {
          if (this.mDoInit) {
            UIInput.Init(this,0);
          }
          il2cpp_internal(this + 144,this.mValue);
          uVar1 = **(uint64 **)(DAT_181d8a958 + 184);
          cVar4 = Object.op_Equality(uVar1,0,0);
          if (cVar4) {
            plVar2 = *(int64 **)(DAT_181d8a958 + 184);
            *plVar2 = this;
            il2cpp_internal(plVar2,this);
            uVar1 = this.onSubmit;
            EventDelegate.Execute(uVar1,0);
            puVar3 = *(uint64 **)(DAT_181d8a958 + 184);
            *puVar3 = 0;
            il2cpp_internal(puVar3,0);
          }
          uVar1 = this.mValue;
          cVar4 = FUN_180d6ca90(this.savedAs,0);
          if (!cVar4) {
            cVar4 = FUN_180d6ca90(uVar1,0);
            if (!cVar4) {
              PlayerPrefs.SetString(this.savedAs,uVar1,0);
              return;
            }
            PlayerPrefs.DeleteKey(this.savedAs,0);
          }
        }
    }

    // Token : 0x60007DD
    // RVA   : 0x10EFED0   Offset: 0x10EE6D0   Length: 0xE32
    public void UpdateLabel()
    {
        var pStatics = *(int64*)(DAT_181d8a958 + 184);
        bool cVar5;
        bool cVar6;
        int iVar7;
        int iVar8;
        long lVar9;
        long lVar10;
        ulong uVar11;
        ulong uVar12;
        long lVar13;
        long lVar15;
        int iVar17;
        ulong uVar18;
        int iVar19;
        int iVar20;
        uint uVar21;
        float fVar22;
        uint uVar23;
        uint uVar24;
        uint uVar25;
        ulong in_stack_ffffffffffffff98;
        uint local_48;
        uint uStack_44;
        uint uStack_40;
        uint32 uStack_3c;
        uint32 local_38;
        uint32 uStack_34;
        uint32 uStack_30;
        uint32 uStack_2c;
        lVar13 = this[3];
        cVar5 = Object.op_Inequality(lVar13,0,0);
        if (!cVar5) {
          return;
        }
        if (*(char *)((int64)this + 180) != false) {
          UIInput.Init(this,0);
        }
        cVar5 = UIInput.get_isSelected(this,0);
        if (*(char *)((int64)this + 180) != false) {
          UIInput.Init(this,0);
        }
        lVar13 = this[18];
        cVar6 = FUN_180d6ca90(lVar13,0);
        if (!cVar6) {
          lVar15 = this[3];
          cVar6 = false;
        LAB_1810f0002:
          uVar21 = (uint32)this[9];
          uVar23 = *(uint32 *)((int64)this + 76);
          uVar24 = (uint32)this[10];
          uVar25 = *(uint32 *)((int64)this + 84);
        }
        else {
          uVar11 = Input.get_compositionString(0);
          cVar6 = FUN_180d6ca90(uVar11,0);
          lVar15 = this[3];
          if ((!cVar6) || (cVar5)) goto LAB_1810f0002;
          uVar21 = (uint32)this[20];
          uVar23 = *(uint32 *)((int64)this + 164);
          uVar24 = (uint32)this[21];
          uVar25 = *(uint32 *)((int64)this + 172);
        }
        if (lVar15 == null) throw; // [null/range check failed]
        local_48 = uVar21;
        uStack_44 = uVar23;
        uStack_40 = uVar24;
        uStack_3c = uVar25;
        UIWidget.set_color(lVar15,&local_48,0);
        lVar15 = "";
        uVar11 = "*";
        iVar20 = 0;
        iVar7 = 0;
        if (!cVar6) {
          if ((int)this[4] == 2) {
            lVar9 = this[3];
            if (lVar9 == null) throw; // [null/range check failed]
            lVar9 = il2cpp_internal(*(uint64 *)(lVar9 + 0x198),DAT_181d556d0);
            if ((lVar9 != null) && (lVar10 = FUN_180002970(0,DAT_181d556d0,lVar9)) != null) {
              lVar9 = FUN_180002970(0,DAT_181d556d0,lVar9);
              if (lVar9 == null) throw; // [null/range check failed]
              lVar9 = BMFont.GetGlyph(lVar9,42);
              if (lVar9 == null) {
                uVar11 = "x";
              }
            }
            if (lVar13 == null) throw; // [null/range check failed]
            puVar1 = (uint32 *)(lVar13 + 16);
            lVar13 = lVar15;
            if (0 < (int)*puVar1) {
              uVar18 = (uint64)*puVar1;
              do {
                lVar13 = String.Concat(lVar13,uVar11,0);
                uVar18 = uVar18 - 1;
              } while (uVar18 != 0);
            }
          }
          if (!cVar5) {
            if (lVar13 == null) throw; // [null/range check failed]
            uVar11 = String.Substring(lVar13,0,0,0);
          }
          else {
            if (lVar13 == null) throw; // [null/range check failed]
            uVar21 = *(uint32 *)(lVar13 + 16);
            cVar6 = UIInput.get_isSelected(this,0);
            if (!cVar6) {
              if (*(char *)((int64)this + 180) != false) {
                UIInput.Init(this,0);
              }
              if (this[18] == 0) throw; // [null/range check failed]
              uVar23 = *(uint32 *)(this[18] + 16);
            }
            else {
              uVar23 = *(uint32 *)((int64)this + 196);
            }
            iVar7 = Mathf.Min(uVar21,uVar23,0);
            uVar11 = String.Substring(lVar13,0,iVar7,0);
            uVar12 = Input.get_compositionString(0);
            uVar11 = String.Concat(uVar11,uVar12,0);
          }
          uVar12 = String.Substring(lVar13,iVar7,*(int *)(lVar13 + 16) - iVar7,0);
          lVar13 = String.Concat(uVar11,uVar12,0);
          if (cVar5) {
            lVar15 = this[3];
            if (lVar15 == null) throw; // [null/range check failed]
            if ((*(int *)(lVar15 + 0x1dc) == 1) && (*(int *)(lVar15 + 0x1b8) == 1)) {
              iVar8 = UILabel.CalculateOffsetToFit(lVar15,lVar13,0);
              if (iVar8 == 0) {
                *(uint32 *)(pStatics + 16) = 0;
                lVar15 = this[3];
                if (lVar15 == null) throw; // [null/range check failed]
                if (*(int *)(lVar15 + 0x1b0) != (int)this[23]) {
                  *(int *)(lVar15 + 0x1b0) = (int)this[23];
        LAB_1810f0468:
                  *(uint8 *)(lVar15 + 88) = 1;
                  *(uint8 *)(lVar15 + 0x24c) = 1;
                  UILabel.ProcessAndRequest(lVar15,0);
                }
              }
              else {
                if (iVar7 < *(int *)(pStatics + 16)) {
                  *(int *)(pStatics + 16) = iVar7;
                  lVar15 = this[3];
                  if (lVar15 == null) throw; // [null/range check failed]
                  if (*(int *)(lVar15 + 0x1b0) != 1) {
                    *(uint32 *)(lVar15 + 0x1b0) = 1;
                    goto LAB_1810f0468;
                  }
                }
                else {
                  if (iVar8 < *(int *)(pStatics + 16)) {
                    *(int *)(pStatics + 16) = iVar8;
                    lVar15 = this[3];
                    if (lVar15 == null) throw; // [null/range check failed]
                    if (*(int *)(lVar15 + 0x1b0) != 1) {
                      *(uint32 *)(lVar15 + 0x1b0) = 1;
                      goto LAB_1810f0468;
                    }
                  }
                  else {
                    lVar15 = this[3];
                    if ((lVar13 == null) || (uVar11 = String.Substring(lVar13,0,iVar7,0), lVar15 == null))
                    throw; // [null/range check failed]
                    iVar7 = UILabel.CalculateOffsetToFit(lVar15,uVar11,0);
                    if (*(int *)(pStatics + 16) < iVar7) {
                      *(int *)(pStatics + 16) = iVar7;
                      lVar15 = this[3];
                      if (lVar15 == null) throw; // [null/range check failed]
                      if (*(int *)(lVar15 + 0x1b0) != 3) {
                        *(uint32 *)(lVar15 + 0x1b0) = 3;
                        goto LAB_1810f0468;
                      }
                    }
                  }
                }
              }
              if (*(int *)(pStatics + 16) != 0) {
                iVar7 = *(int *)(pStatics + 16);
                if (lVar13 == null) throw; // [null/range check failed]
                lVar13 = String.Substring(lVar13,iVar7,*(int *)(lVar13 + 16) - iVar7,0);
              }
              goto LAB_1810f0669;
            }
          }
          *(uint32 *)(pStatics + 16) = 0;
          lVar15 = this[3];
          if (lVar15 == null) throw; // [null/range check failed]
          if (*(int *)(lVar15 + 0x1b0) != (int)this[23]) {
            *(int *)(lVar15 + 0x1b0) = (int)this[23];
            *(uint8 *)(lVar15 + 88) = 1;
            *(uint8 *)(lVar15 + 0x24c) = 1;
            uVar11 = *(uint64 *)(lVar15 + 0x198);
            cVar6 = Object.op_Inequality(uVar11,0,0);
            if (!cVar6) {
              uVar11 = *(uint64 *)(lVar15 + 400);
            }
            else {
              uVar11 = *(uint64 *)(lVar15 + 0x198);
            }
            cVar6 = Object.op_Inequality(uVar11,0,0);
            if (cVar6) {
              UILabel.ProcessText(lVar15,0,1,0);
            }
          }
        }
        else {
          lVar13 = "";
          if (!cVar5) {
            lVar13 = this[19];
          }
          lVar15 = this[3];
          if (lVar15 == null) throw; // [null/range check failed]
          if (*(int *)(lVar15 + 0x1b0) != (int)this[23]) {
            *(int *)(lVar15 + 0x1b0) = (int)this[23];
            *(uint8 *)(lVar15 + 88) = 1;
            *(uint8 *)(lVar15 + 0x24c) = 1;
            UILabel.ProcessAndRequest(lVar15,0);
          }
        }
        LAB_1810f0669:
        if (this[3] == 0) throw; // [null/range check failed]
        UILabel.set_text(this[3],lVar13,0);
        if (!cVar5) {
          (**(code **)(*this + 0x1d8))(this,*(uint64 *)(*this + 0x1e0));
          return;
        }
        lVar13 = this[24];
        plVar4 = this + 27;
        lVar15 = *plVar4;
        iVar8 = (int)lVar13 - *(int *)(pStatics + 16);
        iVar7 = *(int *)((int64)this + 196) - *(int *)(pStatics + 16);
        cVar5 = Object.op_Equality(lVar15,0,0);
        if (cVar5) {
          lVar13 = new Texture2D(2,2,5,in_stack_ffffffffffffff98 & 0xffffffffffffff00,0);
          *plVar4 = lVar13;
          il2cpp_internal(plVar4,lVar13);
          iVar17 = iVar20;
          iVar19 = iVar20;
          do {
            lVar13 = *plVar4;
            puVar14 = (uint32 *)FUN_181098a50(&local_38,0);
            if (lVar13 == null) throw; // [null/range check failed]
            local_48 = *puVar14;
            uStack_44 = puVar14[1];
            uStack_40 = puVar14[2];
            uStack_3c = puVar14[3];
            Texture2D.SetPixel(lVar13,iVar17,iVar19,&local_48,0);
            iVar17 = iVar17 + 1;
          } while ((iVar17 < 2) || (iVar19 = iVar19 + 1, iVar17 = iVar20, iVar19 < 2));
          if (*plVar4 == 0) throw; // [null/range check failed]
          Texture2D.Apply(*plVar4,0);
        }
        if (iVar8 != iVar7) {
          plVar2 = this + 25;
          lVar13 = *plVar2;
          cVar5 = Object.op_Equality(lVar13,0,0);
          lVar13 = this[3];
          if (!cVar5) {
            if ((lVar13 == null) || (*plVar2 == 0)) throw; // [null/range check failed]
            UIWidget.set_pivot(*plVar2,*(uint32 *)(lVar13 + 160),0);
            plVar3 = (int64 *)*plVar2;
            if (plVar3 == (int64 *)0) throw; // [null/range check failed]
            (**(code **)(*plVar3 + 0x2f8))(plVar3,*plVar4,*(uint64 *)(*plVar3 + 0x300));
            plVar3 = (int64 *)*plVar2;
            if (plVar3 == (int64 *)0) throw; // [null/range check failed]
            (**(code **)(*plVar3 + 0x328))(plVar3,*(uint64 *)(*plVar3 + 0x330));
            if (*plVar2 == 0) throw; // [null/range check failed]
            Behaviour.set_enabled(*plVar2,1,0);
          }
          else {
            if (lVar13 == null) throw; // [null/range check failed]
            uVar11 = UIRect.get_cachedGameObject(lVar13,0);
            lVar13 = NGUITools.AddWidget(uVar11,0x7fffffff,DAT_181d66100);
            *plVar2 = lVar13;
            il2cpp_internal(plVar2,lVar13);
            if (*plVar2 == 0) throw; // [null/range check failed]
            Object.set_name(*plVar2,"Input Highlight",0);
            plVar3 = (int64 *)*plVar2;
            if (plVar3 == (int64 *)0) throw; // [null/range check failed]
            (**(code **)(*plVar3 + 0x2f8))(plVar3,*plVar4,*(uint64 *)(*plVar3 + 0x300));
            if (*plVar2 == 0) throw; // [null/range check failed]
            *(uint8 *)(*plVar2 + 248) = 0;
            if ((this[3] == 0) || (*plVar2 == 0)) throw; // [null/range check failed]
            UIWidget.set_pivot(*plVar2,*(uint32 *)(this[3] + 160),0);
            lVar13 = *plVar2;
            if ((this[3] == 0) || (uVar11 = UIRect.get_cachedTransform(this[3],0), lVar13 == null))
            throw; // [null/range check failed]
            UIRect.SetAnchor(lVar13,uVar11,0);
          }
        }
        plVar2 = this + 26;
        lVar13 = *plVar2;
        cVar5 = Object.op_Equality(lVar13,0,0);
        lVar13 = this[3];
        if (!cVar5) {
          if ((lVar13 == null) || (*plVar2 == 0)) throw; // [null/range check failed]
          UIWidget.set_pivot(*plVar2,*(uint32 *)(lVar13 + 160),0);
          plVar3 = (int64 *)*plVar2;
          if (plVar3 == (int64 *)0) throw; // [null/range check failed]
          (**(code **)(*plVar3 + 0x2f8))(plVar3,*plVar4,*(uint64 *)(*plVar3 + 0x300));
          plVar4 = (int64 *)*plVar2;
          if (plVar4 == (int64 *)0) throw; // [null/range check failed]
          (**(code **)(*plVar4 + 0x328))(plVar4,*(uint64 *)(*plVar4 + 0x330));
          if (*plVar2 == 0) throw; // [null/range check failed]
          Behaviour.set_enabled(*plVar2,1,0);
        }
        else {
          if (lVar13 == null) throw; // [null/range check failed]
          uVar11 = UIRect.get_cachedGameObject(lVar13,0);
          lVar13 = NGUITools.AddWidget(uVar11,0x7fffffff,DAT_181d66100);
          *plVar2 = lVar13;
          il2cpp_internal(plVar2,lVar13);
          if (*plVar2 == 0) throw; // [null/range check failed]
          Object.set_name(*plVar2,"Input Caret",0);
          plVar3 = (int64 *)*plVar2;
          if (plVar3 == (int64 *)0) throw; // [null/range check failed]
          (**(code **)(*plVar3 + 0x2f8))(plVar3,*plVar4,*(uint64 *)(*plVar3 + 0x300));
          if (*plVar2 == 0) throw; // [null/range check failed]
          *(uint8 *)(*plVar2 + 248) = 0;
          if ((this[3] == 0) || (*plVar2 == 0)) throw; // [null/range check failed]
          UIWidget.set_pivot(*plVar2,*(uint32 *)(this[3] + 160),0);
          lVar13 = *plVar2;
          if ((this[3] == 0) || (uVar11 = UIRect.get_cachedTransform(this[3],0), lVar13 == null))
          throw; // [null/range check failed]
          UIRect.SetAnchor(lVar13,uVar11,0);
        }
        lVar13 = this[3];
        lVar15 = *plVar2;
        if (iVar8 == iVar7) {
          if ((lVar15 == null) || (lVar13 == null)) throw; // [null/range check failed]
          local_48 = (uint32)this[13];
          uStack_44 = *(uint32 *)((int64)this + 108);
          uStack_40 = (uint32)this[14];
          uStack_3c = *(uint32 *)((int64)this + 116);
          local_38 = (uint32)this[11];
          uStack_34 = *(uint32 *)((int64)this + 92);
          uStack_30 = (uint32)this[12];
          uStack_2c = *(uint32 *)((int64)this + 100);
          UILabel.PrintOverlay(lVar13,iVar8,iVar7,*(uint64 *)(lVar15 + 240),0,&local_38,&local_48,0)
          ;
          lVar13 = this[25];
          cVar5 = Object.op_Inequality(lVar13,0,0);
          if (cVar5) {
            lVar13 = this[25];
            if (lVar13 == null) throw; // [null/range check failed]
            bVar16 = false;
            goto LAB_1810f0cc4;
          }
        }
        else {
          if (((lVar15 == null) || (this[25] == 0)) || (lVar13 == null)) throw; // [null/range check failed]
          local_38 = (uint32)this[13];
          uStack_34 = *(uint32 *)((int64)this + 108);
          uStack_30 = (uint32)this[14];
          uStack_2c = *(uint32 *)((int64)this + 116);
          local_48 = (uint32)this[11];
          uStack_44 = *(uint32 *)((int64)this + 92);
          uStack_40 = (uint32)this[12];
          uStack_3c = *(uint32 *)((int64)this + 100);
          UILabel.PrintOverlay
                    (lVar13,iVar8,iVar7,*(uint64 *)(lVar15 + 240),
                     *(uint64 *)(this[25] + 240),&local_48,&local_38,0);
          lVar13 = this[25];
          if ((lVar13 == null) || (lVar15 = *(int64 *)(lVar13 + 240)) == null) throw; // [null/range check failed]
          lVar15 = *(int64 *)(lVar15 + 16);
          if (lVar15 == null) throw; // [null/range check failed]
          bVar16 = 0 < *(int *)(lVar15 + 24);
        LAB_1810f0cc4:
          Behaviour.set_enabled(lVar13,bVar16,0);
        }
        fVar22 = (float)RealTime.get_time(0);
        *(float *)(this + 28) = fVar22 + 0.5;
        if (this[3] != 0) {
          *(uint32 *)((int64)this + 228) = *(uint32 *)(this[3] + 140);
          return;
        }
    }

    // Token : 0x60007DE
    // RVA   : 0x10F1A80   Offset: 0x10F0280   Length: 0x2E2
    protected char Validate(string text, int pos, char ch)
    {
        int iVar1;
        bool cVar2;
        uint uVar5;
        uint uVar6;
        uVar6 = (uint32)ch;
        if (this.validation == null) {
          return uVar6;
        }
        cVar2 = Behaviour.get_enabled(this,0);
        if (!cVar2) {
          return uVar6;
        }
        iVar1 = this.validation;
        if (iVar1 == 1) {
          if ((uint16)(ch - 48) < 10) {
            return uVar6;
          }
          if (ch != 45) {
            return 0;
          }
          if (pos != null) {
            return 0;
          }
          if (text != null) {
            cVar2 = String.Contains(text,"-",0);
            if (cVar2) {
              return 0;
            }
            return 45;
          }
        LAB_1810f1d5d:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (iVar1 == 2) {
          if ((uint16)(ch - 48) < 10) {
            return uVar6;
          }
          if (ch == 45) {
            if (pos != null) {
              return 0;
            }
            if (text != null) {
              cVar2 = String.Contains(text,"-",0);
              if (!cVar2) {
                return 45;
              }
              return 0;
            }
          }
          else {
            if (ch != 46) {
              return 0;
            }
            if (text != null) {
              cVar2 = String.Contains(text,".",0);
              if (cVar2) {
                return 0;
              }
              return 46;
            }
          }
          goto LAB_1810f1d5d;
        }
        if (iVar1 == 3) {
          if ((uint16)(ch - 65) < 26) {
            return uVar6;
          }
        LAB_1810f1c95:
          if ((uint16)(ch - 97) < 26) {
            return uVar6;
          }
          if (9 < (uint16)(ch - 48)) {
            return 0;
          }
          return uVar6;
        }
        if (iVar1 == 4) {
          if (25 < (uint16)(ch - 65)) goto LAB_1810f1c95;
          goto LAB_1810f1c87;
        }
        if (iVar1 == 6) {
          if (((uint16)(uVar6 - 34) < 63) &&
             ((0x5400000017002101U >> ((uint64)(uVar6 - 34) & 63) & 1) != 0)) {
            return 0;
          }
          if (ch == 124) {
            return 0;
          }
          if ((uint16)(ch - 9) < 2) {
            return 0;
          }
          return uVar6;
        }
        if (iVar1 != 5) {
          return 0;
        }
        if (text == null) goto LAB_1810f1d5d;
        sVar3 = 32;
        if (*(int *)(text + 16) < 1) {
        LAB_1810f1b92:
          sVar4 = 10;
        }
        else {
          uVar5 = Mathf.Clamp(pos,0,*(int *)(text + 16) + -1,0);
          sVar3 = String.get_Chars(text,uVar5,0);
          if (*(int *)(text + 16) < 1) goto LAB_1810f1b92;
          uVar5 = Mathf.Clamp(pos + 1,0,*(int *)(text + 16) + -1,0);
          sVar4 = String.get_Chars(text,uVar5,0);
        }
        if ((uint16)(ch - 97) < 26) {
          if (sVar3 == 32) {
            return uVar6 - 32;
          }
          return uVar6;
        }
        if (25 < (uint16)(ch - 65)) {
          if (ch == 39) {
            if (sVar3 == 32) {
              return 0;
            }
            if (sVar3 == 39) {
              return 0;
            }
            if (sVar4 == 39) {
              return 0;
            }
            cVar2 = String.Contains(text,"'",0);
            if (cVar2) {
              return 0;
            }
            return 39;
          }
          if (ch != 32) {
            return 0;
          }
          if (sVar3 == 32) {
            return 0;
          }
          if (sVar3 == 39) {
            return 0;
          }
          if (sVar4 == 32) {
            return 0;
          }
          if (sVar4 == 39) {
            return 0;
          }
          return 32;
        }
        if (sVar3 == 32) {
          return uVar6;
        }
        if (sVar3 == 39) {
          return uVar6;
        }
        LAB_1810f1c87:
        return uVar6 + 32;
    }

    // Token : 0x60007DF
    // RVA   : 0x10ED790   Offset: 0x10EBF90   Length: 0x16A
    protected void ExecuteOnChange()
    {
        ulong uVar1;
        bool cVar4;
        uVar1 = **(uint64 **)(DAT_181d8a958 + 184);
        cVar4 = Object.op_Equality(uVar1,0,0);
        if (cVar4) {
          uVar1 = this.onChange;
          cVar4 = EventDelegate.IsValid(uVar1,0);
          if (cVar4) {
            plVar2 = *(int64 **)(DAT_181d8a958 + 184);
            *plVar2 = this;
            il2cpp_internal(plVar2,this);
            uVar1 = this.onChange;
            EventDelegate.Execute(uVar1,0);
            puVar3 = *(uint64 **)(DAT_181d8a958 + 184);
            *puVar3 = 0;
            il2cpp_internal(puVar3,0);
          }
        }
    }

    // Token : 0x60007E0
    // RVA   : 0x10EF790   Offset: 0x10EDF90   Length: 0x65
    public void RemoveFocus()
    {
        bool cVar1;
        cVar1 = UIInput.get_isSelected(this,0);
        if (cVar1) {
          UICamera.set_selectedObject(0,0);
          return;
        }
    }

    // Token : 0x60007E1
    // RVA   : 0x10EF860   Offset: 0x10EE060   Length: 0x5C
    public void SaveValue()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.mValue;
        cVar2 = FUN_180d6ca90(this.savedAs,0);
        if (!cVar2) {
          cVar2 = FUN_180d6ca90(uVar1,0);
          if (!cVar2) {
            PlayerPrefs.SetString(this.savedAs,uVar1,0);
            return;
          }
          PlayerPrefs.DeleteKey(this.savedAs,0);
        }
    }

    // Token : 0x60007E2
    // RVA   : 0x10EE3F0   Offset: 0x10ECBF0   Length: 0xD5
    public void LoadValue()
    {
        bool cVar1;
        ulong uVar2;
        cVar1 = FUN_180d6ca90(this.savedAs,0);
        if (!cVar1) {
          if (this.mValue == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar2 = String.Replace(this.mValue,"\\n","\n",0);
          this.mValue = "";
          cVar1 = PlayerPrefs.HasKey(this.savedAs,0);
          if (cVar1) {
            uVar2 = PlayerPrefs.GetString(this.savedAs,0);
          }
          UIInput.set_value(this,uVar2,0);
        }
    }

    // Token : 0x60007E3
    // RVA   : 0x10F1DF0   Offset: 0x10F05F0   Length: 0x1BE
    public void /*ctor*/()
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        uint uVar4;
        ulong uVar6;
        ulong local_48;
        ulong uStack_40;
        ulong local_38;
        ulong uStack_30;
        byte[] local_28 = new byte[32];
        this.selectAllTextOnFocus = 1;
        puVar5 = (uint64 *)FUN_181098a50(local_28,0);
        uVar6 = puVar5[1];
        local_48 = 0;
        uStack_40 = 0;
        this.activeTextColor = *puVar5;
        *(uint64 *)(this + 80) = uVar6;
        FUN_1809981e0(&local_48,0x3f800000,0x3f800000,0x3f800000,0x3f4ccccd,0);
        this.caretColor = local_48;
        *(uint64 *)(this + 96) = uStack_40;
        local_38 = 0;
        uStack_30 = 0;
        FUN_1809981e0(&local_38,0x3f800000,0x3f5fdfe0,0x3f0d8d8e,0x3f000000,0);
        this.selectionColor = (uint32)local_38;
        *(uint32 *)(this + 108) = local_38._4_4_;
        *(uint32 *)(this + 112) = (uint32)uStack_30;
        *(uint32 *)(this + 116) = uStack_30._4_4_;
        uVar6 = il2cpp_internal(DAT_181d6d9b0);
        FUN_180f58a90(uVar6,DAT_181d5e700);
        this.onSubmit = uVar6;
        uVar6 = il2cpp_internal(DAT_181d6d9b0);
        FUN_180f58a90(uVar6,DAT_181d5e700);
        this.onChange = uVar6;
        this.mDefaultText = "";
        puVar7 = (uint32 *)FUN_181098a50(local_28,0);
        uVar1 = *puVar7;
        uVar2 = puVar7[1];
        uVar3 = puVar7[2];
        uVar4 = puVar7[3];
        this.mDoInit = 1;
        this.mAlignment = 1;
        this.mDefaultColor = uVar1;
        *(uint32 *)(this + 164) = uVar2;
        *(uint32 *)(this + 168) = uVar3;
        *(uint32 *)(this + 172) = uVar4;
        this.mLoadSavedValue = 1;
        this.mCached = "";
        this.mSelectMe = 0xffffffffffffffff;
        FUN_18044ef50(this,0);
    }

    // Token : 0x60007E4
    // RVA   : 0x10F1D70   Offset: 0x10F0570   Length: 0x7C
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d8a958 + 184);
        *(uint32 *)(pStatics + 16) = 0;
        *(uint64 *)(pStatics + 24) = "";
        *(uint32 *)(pStatics + 32) = 0;
    }

}
