// ============================================================
// Type  : UILabel
// Token : 0x20000FB
// ============================================================

public class UILabel
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400060D
    public Crispness keepCrispWhenShrunk;

    // Token: 0x400060E
    private Font mTrueTypeFont;

    // Token: 0x400060F
    private object mFont;

    // Token: 0x4000610
    private string mText;

    // Token: 0x4000611
    private int mFontSize;

    // Token: 0x4000612
    private FontStyle mFontStyle;

    // Token: 0x4000613
    private Alignment mAlignment;

    // Token: 0x4000614
    private bool mEncoding;

    // Token: 0x4000615
    private int mMaxLineCount;

    // Token: 0x4000616
    private Effect mEffectStyle;

    // Token: 0x4000617
    private Color mEffectColor;

    // Token: 0x4000618
    private SymbolStyle mSymbols;

    // Token: 0x4000619
    private Vector2 mEffectDistance;

    // Token: 0x400061A
    private Overflow mOverflow;

    // Token: 0x400061B
    private bool mApplyGradient;

    // Token: 0x400061C
    private Color mGradientTop;

    // Token: 0x400061D
    private Color mGradientBottom;

    // Token: 0x400061E
    private int mSpacingX;

    // Token: 0x400061F
    private int mSpacingY;

    // Token: 0x4000620
    private bool mUseFloatSpacing;

    // Token: 0x4000621
    private float mFloatSpacingX;

    // Token: 0x4000622
    private float mFloatSpacingY;

    // Token: 0x4000623
    private bool mOverflowEllipsis;

    // Token: 0x4000624
    private int mOverflowWidth;

    // Token: 0x4000625
    private int mOverflowHeight;

    // Token: 0x4000626
    private Modifier mModifier;

    // Token: 0x4000627
    private bool mShrinkToFit;

    // Token: 0x4000628
    private int mMaxLineWidth;

    // Token: 0x4000629
    private int mMaxLineHeight;

    // Token: 0x400062A
    private float mLineWidth;

    // Token: 0x400062B
    private bool mMultiline;

    // Token: 0x400062C
    private Font mActiveTTF;

    // Token: 0x400062D
    private float mDensity;

    // Token: 0x400062E
    private bool mShouldBeProcessed;

    // Token: 0x400062F
    private string mProcessedText;

    // Token: 0x4000630
    private bool mPremultiply;

    // Token: 0x4000631
    private Vector2 mCalculatedSize;

    // Token: 0x4000632
    private float mScale;

    // Token: 0x4000633
    private int mFinalFontSize;

    // Token: 0x4000634
    private int mLastWidth;

    // Token: 0x4000635
    private int mLastHeight;

    // Token: 0x4000636
    public ModifierFunc customModifier;

    // Token: 0x4000637
    private static BetterList<UILabel> mList;

    // Token: 0x4000638
    private static Dictionary<Font, int> mFontUsage;

    // Token: 0x4000639
    private static BetterList<UIDrawCall> mTempDrawcalls;

    // Token: 0x400063A
    private static bool mTexRebuildAdded;

    // Token: 0x400063B
    private static List<Vector3> mTempVerts;

    // Token: 0x400063C
    private static List<int> mTempIndices;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60007EC
    // RVA   : 0x10FBD00   Offset: 0x10FA500   Length: 0x90
    public int get_finalFontSize()
    {
        int iVar1;
        ulong uVar2;
        bool cVar3;
        uVar2 = UILabel.get_trueTypeFont(this,0);
        cVar3 = Object.op_Implicit(uVar2,0);
        if (!cVar3) {
          iVar1 = this.mFontSize;
        }
        else {
          iVar1 = this.mFinalFontSize;
        }
        Mathf.RoundToInt((float)iVar1 * this.mScale,0);
    }

    // Token : 0x60007ED
    // RVA   : 0x10FC600   Offset: 0x10FAE00   Length: 0x8
    private bool get_shouldBeProcessed()
    {
        uint8 FUN_1810fc600(int64 this)
        {
        return this.mShouldBeProcessed;
    }

    // Token : 0x60007EE
    // RVA   : 0x10FD000   Offset: 0x10FB800   Length: 0x17
    private void set_shouldBeProcessed(bool value)
    {
        void FUN_1810fd000(int64 this,char value)
        {
        if (!value) {
          this.mShouldBeProcessed = 0;
          return;
        }
        *(uint8 *)(this + 88) = 1;
        this.mShouldBeProcessed = 1;
    }

    // Token : 0x60007EF
    // RVA   : 0x10FBEA0   Offset: 0x10FA6A0   Length: 0x2C
    public override bool get_isAnchoredHorizontally()
    {
        bool cVar1;
        cVar1 = UIRect.get_isAnchoredHorizontally(this,0);
        if (cVar1) {
          return true;
        }
        return this.mOverflow == 2;
    }

    // Token : 0x60007F0
    // RVA   : 0x10FBED0   Offset: 0x10FA6D0   Length: 0x33
    public override bool get_isAnchoredVertically()
    {
        bool cVar1;
        cVar1 = UIRect.get_isAnchoredVertically(this,0);
        if (!cVar1) {
          if (this.mOverflow != 2) {
            return this.mOverflow == 3;
          }
        }
        return true;
    }

    // Token : 0x60007F1
    // RVA   : 0x10FC1E0   Offset: 0x10FA9E0   Length: 0x136
    public override Material get_material()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uVar3 = *(uint64 *)(this + 176);
        cVar1 = Object.op_Inequality(uVar3,0,0);
        if (cVar1) {
          return *(uint64 *)(this + 176);
        }
        lVar2 = il2cpp_internal(this.mFont,DAT_181d556d0);
        if (lVar2 != null) {
          uVar3 = FUN_180002970(12,DAT_181d556d0,lVar2);
          return uVar3;
        }
        uVar3 = *(uint64 *)(this + 400);
        cVar1 = Object.op_Inequality(uVar3,0,0);
        if (!cVar1) {
          return 0;
        }
        if (*(int64 *)(this + 400) != 0) {
          uVar3 = Font.get_material(*(int64 *)(this + 400),0);
          return uVar3;
        }
    }

    // Token : 0x60007F2
    // RVA   : 0x10FCE80   Offset: 0x10FB680   Length: 0x8
    public override void set_material(Material value)
    {
        void FUN_1810fce80(uint64 this,uint64 value)
        {
        UIWidget.set_material(this,value,0);
    }

    // Token : 0x60007F3
    // RVA   : 0x10FC0B0   Offset: 0x10FA8B0   Length: 0x127
    public override Texture get_mainTexture()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        lVar2 = il2cpp_internal(this.mFont,DAT_181d556d0);
        if (lVar2 == null) {
          uVar3 = *(uint64 *)(this + 400);
          cVar1 = Object.op_Inequality(uVar3,0,0);
          if (!cVar1) {
            return 0;
          }
          if (*(int64 *)(this + 400) != 0) {
            lVar2 = Font.get_material(*(int64 *)(this + 400),0);
            cVar1 = Object.op_Inequality(lVar2,0,0);
            if (!cVar1) {
              return 0;
            }
            if (lVar2 != null) {
              uVar3 = Material.get_mainTexture(lVar2,0);
              return uVar3;
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        uVar3 = FUN_180002970(16,DAT_181d556d0,lVar2);
        return uVar3;
    }

    // Token : 0x60007F4
    // RVA   : 0x10FCE70   Offset: 0x10FB670   Length: 0x8
    public override void set_mainTexture(Texture value)
    {
        void FUN_1810fce70(uint64 this,uint64 value)
        {
        UIWidget.set_mainTexture(this,value,0);
    }

    // Token : 0x60007F5
    // RVA   : 0x10FBDD0   Offset: 0x10FA5D0   Length: 0xAA
    public object get_font()
    {
        plVar1 = (int64 *)il2cpp_internal(this.mFont,DAT_181d556d0);
        if (plVar1 != (int64 *)0) {
          if ((*(byte *)(DAT_181d68fe8 + 300) <= *(byte *)(*plVar1 + 300)) &&
             (*(int64 *)
               (*(int64 *)(*plVar1 + 200) + -8 + (uint64)*(byte *)(DAT_181d68fe8 + 300) * 8) ==
              DAT_181d68fe8)) {
            return plVar1;
          }
          return (int64 *)0;
        }
        return (int64 *)0;
    }

    // Token : 0x60007F6
    // RVA   : 0x10FCD10   Offset: 0x10FB510   Length: 0x53
    public void set_font(object value)
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(value,DAT_181d556d0);
        UILabel.set_bitmapFont(this,uVar1,0);
    }

    // Token : 0x60007F7
    // RVA   : 0x10FBB00   Offset: 0x10FA300   Length: 0x3D
    public INGUIFont get_bitmapFont()
    {
        il2cpp_internal(this.mFont,DAT_181d556d0);
    }

    // Token : 0x60007F8
    // RVA   : 0x10FCA10   Offset: 0x10FB210   Length: 0xEC
    public void set_bitmapFont(INGUIFont value)
    {
        plVar2 = (int64 *)il2cpp_internal(this[51]);
        if (plVar2 != value) {
          UIWidget.RemoveFromPanel(this);
          if (value == (int64 *)0) {
            plVar2 = (int64 *)0;
          }
          else {
            plVar2 = value;
          }
          this[51] = (int64)plVar2;
          il2cpp_internal(this + 51);
          this[50] = 0;
          il2cpp_internal(this + 50,0);
          (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
        }
    }

    // Token : 0x60007F9
    // RVA   : 0x10FBA80   Offset: 0x10FA280   Length: 0x78
    public INGUIAtlas get_atlas()
    {
        long lVar1;
        lVar1 = il2cpp_internal(this.mFont,DAT_181d556d0);
        if (lVar1 == null) {
          return;
        }
        FUN_180002970(9,DAT_181d556d0,lVar1);
    }

    // Token : 0x60007FA
    // RVA   : 0x10FC980   Offset: 0x10FB180   Length: 0x82
    public void set_atlas(INGUIAtlas value)
    {
        long lVar1;
        lVar1 = il2cpp_internal(this.mFont,DAT_181d556d0);
        if (lVar1 != null) {
          FUN_180004720(10,DAT_181d556d0,lVar1,value);
        }
    }

    // Token : 0x60007FB
    // RVA   : 0x10FC670   Offset: 0x10FAE70   Length: 0xD9
    public Font get_trueTypeFont()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uVar3 = *(uint64 *)(this + 400);
        cVar1 = Object.op_Inequality(uVar3,0,0);
        if (cVar1) {
          return *(uint64 *)(this + 400);
        }
        lVar2 = il2cpp_internal(this.mFont,DAT_181d556d0);
        if (lVar2 == null) {
          return 0;
        }
        uVar3 = FUN_180002970(29,DAT_181d556d0,lVar2);
        return uVar3;
    }

    // Token : 0x60007FC
    // RVA   : 0x10FD1A0   Offset: 0x10FB9A0   Length: 0x12B
    public void set_trueTypeFont(Font value)
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = *(uint64 *)(this + 400);
        cVar2 = Object.op_Inequality(uVar1,value,0);
        if (cVar2) {
          UILabel.SetActiveFont(this,0,0);
          UIWidget.RemoveFromPanel(this,0);
          *(uint64 *)(this + 400) = value;
          *(uint8 *)(this + 88) = 1;
          this.mShouldBeProcessed = 1;
          this.mFont = 0;
          UILabel.SetActiveFont(this,value,0);
          UILabel.ProcessAndRequest(this,0);
          uVar1 = this.mActiveTTF;
          cVar2 = Object.op_Inequality(uVar1,0,0);
          if (cVar2) {
            UIWidget.MarkAsChanged(this,0);
          }
        }
    }

    // Token : 0x60007FD
    // RVA   : 0x10FB9E0   Offset: 0x10FA1E0   Length: 0x83
    public object get_ambigiousFont()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.mFont;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          return this.mFont;
        }
        return *(uint64 *)(this + 400);
    }

    // Token : 0x60007FE
    // RVA   : 0x10FC7C0   Offset: 0x10FAFC0   Length: 0x198
    public void set_ambigiousFont(object value)
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        lVar3 = il2cpp_internal(value,DAT_181d556d0);
        if (lVar3 == null) {
          plVar4 = (int64 *)0;
          if ((value != (int64 *)0) && (*value == DAT_181da26a0)) {
            plVar4 = value;
          }
          uVar1 = *(uint64 *)(this + 400);
          cVar2 = Object.op_Inequality(uVar1,plVar4,0);
          if (cVar2) {
            UILabel.SetActiveFont(this,0,0);
            UIWidget.RemoveFromPanel(this,0);
            *(int64 **)(this + 400) = plVar4;
            *(uint8 *)(this + 88) = 1;
            this.mShouldBeProcessed = 1;
            this.mFont = 0;
            UILabel.SetActiveFont(this,plVar4,0);
            UILabel.ProcessAndRequest(this,0);
            uVar1 = this.mActiveTTF;
            cVar2 = Object.op_Inequality(uVar1,0,0);
            if (cVar2) {
              UIWidget.MarkAsChanged(this,0);
            }
          }
          return;
        }
        UILabel.set_bitmapFont(this,lVar3,0);
    }

    // Token : 0x60007FF
    // RVA   : 0x10FC660   Offset: 0x10FAE60   Length: 0x8
    public string get_text()
    {
        uint64 FUN_1810fc660(int64 this)
        {
        return this.mText;
    }

    // Token : 0x6000800
    // RVA   : 0x10FD0D0   Offset: 0x10FB8D0   Length: 0xCF
    public void set_text(string value)
    {
        bool cVar2;
        plVar1 = this + 52;
        cVar2 = FUN_1816fd990(*plVar1,value,0);
        if (!cVar2) {
          cVar2 = FUN_180d6ca90(value,0);
          if (!cVar2) {
            cVar2 = String.op_Inequality(*plVar1,value,0);
            if (!cVar2) {
              return;
            }
            *plVar1 = value;
          }
          else {
            cVar2 = FUN_180d6ca90(*plVar1,0);
            value = "";
            if (cVar2) {
              return;
            }
            *plVar1 = "";
          }
          il2cpp_internal(plVar1,value);
          (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
          UILabel.ProcessAndRequest(this,0);
          if ((char)this[26] != false) {
            UIWidget.ResizeCollider(this,0);
          }
        }
    }

    // Token : 0x6000801
    // RVA   : 0x10FBB40   Offset: 0x10FA340   Length: 0xE3
    public int get_defaultFontSize()
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        uVar2 = UILabel.get_trueTypeFont(this,0);
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (cVar1) {
          return (uint64)this.mFontSize;
        }
        lVar3 = il2cpp_internal(this.mFont,DAT_181d556d0);
        if (lVar3 == null) {
          return 16;
        }
        uVar4 = FUN_180002970(22,DAT_181d556d0,lVar3);
        return uVar4;
    }

    // Token : 0x6000802
    // RVA   : 0x10FBDB0   Offset: 0x10FA5B0   Length: 0x7
    public int get_fontSize()
    {
        uint32 FUN_1810fbdb0(int64 this)
        {
        return this.mFontSize;
    }

    // Token : 0x6000803
    // RVA   : 0x10FCC90   Offset: 0x10FB490   Length: 0x4B
    public void set_fontSize(int value)
    {
        int iVar1;
        iVar1 = Mathf.Clamp(value,0,0x100,0);
        if (this.mFontSize != iVar1) {
          this.mFontSize = iVar1;
          *(uint8 *)(this + 88) = 1;
          this.mShouldBeProcessed = 1;
          UILabel.ProcessAndRequest(this,0);
          return;
        }
    }

    // Token : 0x6000804
    // RVA   : 0x10FBDC0   Offset: 0x10FA5C0   Length: 0x7
    public FontStyle get_fontStyle()
    {
        uint32 FUN_1810fbdc0(int64 this)
        {
        return this.mFontStyle;
    }

    // Token : 0x6000805
    // RVA   : 0x10FCCE0   Offset: 0x10FB4E0   Length: 0x21
    public void set_fontStyle(FontStyle value)
    {
        if (this.mFontStyle != value) {
          this.mFontStyle = value;
          *(uint8 *)(this + 88) = 1;
          this.mShouldBeProcessed = 1;
          UILabel.ProcessAndRequest(this,0);
          return;
        }
    }

    // Token : 0x6000806
    // RVA   : 0x10FB9D0   Offset: 0x10FA1D0   Length: 0x7
    public Alignment get_alignment()
    {
        uint32 FUN_1810fb9d0(int64 this)
        {
        return this.mAlignment;
    }

    // Token : 0x6000807
    // RVA   : 0x10FC790   Offset: 0x10FAF90   Length: 0x21
    public void set_alignment(Alignment value)
    {
        if (this.mAlignment != value) {
          this.mAlignment = value;
          *(uint8 *)(this + 88) = 1;
          this.mShouldBeProcessed = 1;
          UILabel.ProcessAndRequest(this,0);
          return;
        }
    }

    // Token : 0x6000808
    // RVA   : 0x10FBA70   Offset: 0x10FA270   Length: 0x8
    public bool get_applyGradient()
    {
        uint8 FUN_1810fba70(int64 this)
        {
        return this.mApplyGradient;
    }

    // Token : 0x6000809
    // RVA   : 0x10FC960   Offset: 0x10FB160   Length: 0x20
    public void set_applyGradient(bool value)
    {
        void FUN_1810fc960(int64 *this,char value)
        {
        if ((char)this[60] != value) {
          *(char *)(this + 60) = value;
                          // WARNING: Could not recover jumptable at 0x0001810fc978. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
          return;
        }
    }

    // Token : 0x600080A
    // RVA   : 0x10FBE90   Offset: 0x10FA690   Length: 0xE
    public Color get_gradientTop()
    {
        uint64 * FUN_1810fbe90(uint64 *this,int64 param_2)
        {
        uint64 uVar1;
        uVar1 = *(uint64 *)(param_2 + 0x1ec);
        *this = *(uint64 *)(param_2 + 0x1e4);
        this[1] = uVar1;
        return this;
    }

    // Token : 0x600080B
    // RVA   : 0x10FCDE0   Offset: 0x10FB5E0   Length: 0x6B
    public void set_gradientTop(Color value)
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        bool cVar4;
        ulong local_28;
        ulong uStack_20;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        local_28 = *value;
        uStack_20 = value[1];
        local_18 = *(uint32 *)((int64)this + 0x1e4);
        uStack_14 = (uint32)this[61];
        uStack_10 = *(uint32 *)((int64)this + 0x1ec);
        uStack_c = (uint32)this[62];
        cVar4 = Color.op_Inequality(&local_18,&local_28,0);
        if (cVar4) {
          uVar1 = *(uint32 *)((int64)value + 4);
          uVar2 = *(uint32 *)(value + 1);
          uVar3 = *(uint32 *)((int64)value + 12);
          *(uint32 *)((int64)this + 0x1e4) = *(uint32 *)value;
          *(uint32 *)(this + 61) = uVar1;
          *(uint32 *)((int64)this + 0x1ec) = uVar2;
          *(uint32 *)(this + 62) = uVar3;
          if ((char)this[60] != false) {
            (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
          }
        }
    }

    // Token : 0x600080C
    // RVA   : 0x10FBE80   Offset: 0x10FA680   Length: 0xE
    public Color get_gradientBottom()
    {
        uint64 * FUN_1810fbe80(uint64 *this,int64 param_2)
        {
        uint64 uVar1;
        uVar1 = *(uint64 *)(param_2 + 0x1fc);
        *this = *(uint64 *)(param_2 + 500);
        this[1] = uVar1;
        return this;
    }

    // Token : 0x600080D
    // RVA   : 0x10FCD70   Offset: 0x10FB570   Length: 0x6B
    public void set_gradientBottom(Color value)
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        bool cVar4;
        ulong local_28;
        ulong uStack_20;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        local_28 = *value;
        uStack_20 = value[1];
        local_18 = *(uint32 *)((int64)this + 500);
        uStack_14 = (uint32)this[63];
        uStack_10 = *(uint32 *)((int64)this + 0x1fc);
        uStack_c = (uint32)this[64];
        cVar4 = Color.op_Inequality(&local_18,&local_28,0);
        if (cVar4) {
          uVar1 = *(uint32 *)((int64)value + 4);
          uVar2 = *(uint32 *)(value + 1);
          uVar3 = *(uint32 *)((int64)value + 12);
          *(uint32 *)((int64)this + 500) = *(uint32 *)value;
          *(uint32 *)(this + 63) = uVar1;
          *(uint32 *)((int64)this + 0x1fc) = uVar2;
          *(uint32 *)(this + 64) = uVar3;
          if ((char)this[60] != false) {
            (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
          }
        }
    }

    // Token : 0x600080E
    // RVA   : 0x10FC620   Offset: 0x10FAE20   Length: 0x7
    public int get_spacingX()
    {
        uint32 FUN_1810fc620(int64 this)
        {
        return this.mSpacingX;
    }

    // Token : 0x600080F
    // RVA   : 0x10FD050   Offset: 0x10FB850   Length: 0x20
    public void set_spacingX(int value)
    {
        void FUN_1810fd050(int64 *this,int value)
        {
        if (*(int *)((int64)this + 0x204) != value) {
          *(int *)((int64)this + 0x204) = value;
                          // WARNING: Could not recover jumptable at 0x0001810fd068. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
          return;
        }
    }

    // Token : 0x6000810
    // RVA   : 0x10FC630   Offset: 0x10FAE30   Length: 0x7
    public int get_spacingY()
    {
        uint32 FUN_1810fc630(int64 this)
        {
        return this.mSpacingY;
    }

    // Token : 0x6000811
    // RVA   : 0x10FD070   Offset: 0x10FB870   Length: 0x20
    public void set_spacingY(int value)
    {
        void FUN_1810fd070(int64 *this,int value)
        {
        if ((int)this[65] != value) {
          *(int *)(this + 65) = value;
                          // WARNING: Could not recover jumptable at 0x0001810fd088. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
          return;
        }
    }

    // Token : 0x6000812
    // RVA   : 0x10FC750   Offset: 0x10FAF50   Length: 0x8
    public bool get_useFloatSpacing()
    {
        uint8 FUN_1810fc750(int64 this)
        {
        return this.mUseFloatSpacing;
    }

    // Token : 0x6000813
    // RVA   : 0x10FD2D0   Offset: 0x10FBAD0   Length: 0x1A
    public void set_useFloatSpacing(bool value)
    {
        void FUN_1810fd2d0(int64 this,char value)
        {
        if (this.mUseFloatSpacing != value) {
          this.mUseFloatSpacing = value;
          *(uint8 *)(this + 88) = 1;
          this.mShouldBeProcessed = 1;
        }
    }

    // Token : 0x6000814
    // RVA   : 0x10FBD90   Offset: 0x10FA590   Length: 0x9
    public float get_floatSpacingX()
    {
        uint32 FUN_1810fbd90(int64 this)
        {
        return this.mFloatSpacingX;
    }

    // Token : 0x6000815
    // RVA   : 0x10FCBF0   Offset: 0x10FB3F0   Length: 0x4B
    public void set_floatSpacingX(float value)
    {
        bool cVar1;
        uint in_XMM1_Da;
        cVar1 = Mathf.Approximately((int)this[66],value,0);
        if (!cVar1) {
          *(uint32 *)(this + 66) = in_XMM1_Da;
          (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
        }
    }

    // Token : 0x6000816
    // RVA   : 0x10FBDA0   Offset: 0x10FA5A0   Length: 0x9
    public float get_floatSpacingY()
    {
        uint32 FUN_1810fbda0(int64 this)
        {
        return this.mFloatSpacingY;
    }

    // Token : 0x6000817
    // RVA   : 0x10FCC40   Offset: 0x10FB440   Length: 0x4B
    public void set_floatSpacingY(float value)
    {
        bool cVar1;
        uint in_XMM1_Da;
        cVar1 = Mathf.Approximately(*(uint32 *)((int64)this + 0x214),value,0);
        if (!cVar1) {
          *(uint32 *)((int64)this + 0x214) = in_XMM1_Da;
          (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
        }
    }

    // Token : 0x6000818
    // RVA   : 0x10FBCE0   Offset: 0x10FA4E0   Length: 0x1E
    public float get_effectiveSpacingY()
    {
        if (this.mUseFloatSpacing) {
          return;
        }
    }

    // Token : 0x6000819
    // RVA   : 0x10FBCC0   Offset: 0x10FA4C0   Length: 0x1E
    public float get_effectiveSpacingX()
    {
        void FUN_1810fbcc0(int64 this)
        {
        if (this.mUseFloatSpacing) {
          return;
        }
    }

    // Token : 0x600081A
    // RVA   : 0xA76B40   Offset: 0xA75340   Length: 0x8
    public bool get_overflowEllipsis()
    {
        uint8 FUN_180a76b40(int64 this)
        {
        return this.mOverflowEllipsis;
    }

    // Token : 0x600081B
    // RVA   : 0x10FCF60   Offset: 0x10FB760   Length: 0x20
    public void set_overflowEllipsis(bool value)
    {
        void FUN_1810fcf60(int64 *this,char value)
        {
        if ((char)this[67] != value) {
          *(char *)(this + 67) = value;
                          // WARNING: Could not recover jumptable at 0x0001810fcf78. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
          return;
        }
    }

    // Token : 0x600081C
    // RVA   : 0x10FC360   Offset: 0x10FAB60   Length: 0x7
    public int get_overflowWidth()
    {
        uint32 FUN_1810fc360(int64 this)
        {
        return this.mOverflowWidth;
    }

    // Token : 0x600081D
    // RVA   : 0x10FCFD0   Offset: 0x10FB7D0   Length: 0x29
    public void set_overflowWidth(int value)
    {
        void FUN_1810fcfd0(int64 *this,int value)
        {
        int iVar1;
        iVar1 = 0;
        if (-1 < value) {
          iVar1 = value;
        }
        if (*(int *)((int64)this + 0x21c) != iVar1) {
          *(int *)((int64)this + 0x21c) = iVar1;
                          // WARNING: Could not recover jumptable at 0x0001810fcff1. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
          return;
        }
    }

    // Token : 0x600081E
    // RVA   : 0xF020F0   Offset: 0xF008F0   Length: 0x7
    public int get_overflowHeight()
    {
        uint32 FUN_180f020f0(int64 this)
        {
        return this.mOverflowHeight;
    }

    // Token : 0x600081F
    // RVA   : 0x10FCF80   Offset: 0x10FB780   Length: 0x29
    public void set_overflowHeight(int value)
    {
        void FUN_1810fcf80(int64 *this,int value)
        {
        int iVar1;
        iVar1 = 0;
        if (-1 < value) {
          iVar1 = value;
        }
        if ((int)this[68] != iVar1) {
          *(int *)(this + 68) = iVar1;
                          // WARNING: Could not recover jumptable at 0x0001810fcfa1. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
          return;
        }
    }

    // Token : 0x6000820
    // RVA   : 0x10FBFC0   Offset: 0x10FA7C0   Length: 0x88
    private bool get_keepCrisp()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = UILabel.get_trueTypeFont(this,0);
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if ((cVar2) && (this.keepCrispWhenShrunk != null)) {
          return true;
        }
        return false;
    }

    // Token : 0x6000821
    // RVA   : 0x10FC640   Offset: 0x10FAE40   Length: 0x8
    public bool get_supportEncoding()
    {
        uint8 FUN_1810fc640(int64 this)
        {
        return this.mEncoding;
    }

    // Token : 0x6000822
    // RVA   : 0x10FD090   Offset: 0x10FB890   Length: 0x1A
    public void set_supportEncoding(bool value)
    {
        void FUN_1810fd090(int64 this,char value)
        {
        if (this.mEncoding != value) {
          this.mEncoding = value;
          *(uint8 *)(this + 88) = 1;
          this.mShouldBeProcessed = 1;
        }
    }

    // Token : 0x6000823
    // RVA   : 0x10FC650   Offset: 0x10FAE50   Length: 0x7
    public SymbolStyle get_symbolStyle()
    {
        uint32 FUN_1810fc650(int64 this)
        {
        return this.mSymbols;
    }

    // Token : 0x6000824
    // RVA   : 0x10FD0B0   Offset: 0x10FB8B0   Length: 0x1A
    public void set_symbolStyle(SymbolStyle value)
    {
        if (this.mSymbols != value) {
          this.mSymbols = value;
          *(uint8 *)(this + 88) = 1;
          this.mShouldBeProcessed = 1;
        }
    }

    // Token : 0x6000825
    // RVA   : 0x10FC350   Offset: 0x10FAB50   Length: 0x7
    public Overflow get_overflowMethod()
    {
        uint32 FUN_1810fc350(int64 this)
        {
        return this.mOverflow;
    }

    // Token : 0x6000826
    // RVA   : 0x10FCFB0   Offset: 0x10FB7B0   Length: 0x1A
    public void set_overflowMethod(Overflow value)
    {
        if (this.mOverflow != value) {
          this.mOverflow = value;
          *(uint8 *)(this + 88) = 1;
          this.mShouldBeProcessed = 1;
        }
    }

    // Token : 0x6000827
    // RVA   : 0x9D9CB0   Offset: 0x9D84B0   Length: 0x7
    public int get_lineWidth()
    {
        uint32 FUN_1809d9cb0(int64 this)
        {
        return *(uint32 *)(this + 164);
    }

    // Token : 0x6000828
    // RVA   : 0x10FCE60   Offset: 0x10FB660   Length: 0x8
    public void set_lineWidth(int value)
    {
        void FUN_1810fce60(uint64 this,uint64 value)
        {
        UIWidget.set_width(this,value,0);
    }

    // Token : 0x6000829
    // RVA   : 0x9D96C0   Offset: 0x9D7EC0   Length: 0x7
    public int get_lineHeight()
    {
        uint32 FUN_1809d96c0(int64 this)
        {
        return *(uint32 *)(this + 168);
    }

    // Token : 0x600082A
    // RVA   : 0x10FCE50   Offset: 0x10FB650   Length: 0x8
    public void set_lineHeight(int value)
    {
        void FUN_1810fce50(uint64 this,uint64 value)
        {
        UIWidget.set_height(this,value,0);
    }

    // Token : 0x600082B
    // RVA   : 0x10FC340   Offset: 0x10FAB40   Length: 0xB
    public bool get_multiLine()
    {
        bool FUN_1810fc340(int64 this)
        {
        return this.mMaxLineCount != 1;
    }

    // Token : 0x600082C
    // RVA   : 0x10FCF30   Offset: 0x10FB730   Length: 0x2C
    public void set_multiLine(bool value)
    {
        void FUN_1810fcf30(int64 this,byte value)
        {
        if ((uint32)(this.mMaxLineCount != 1) != (uint32)value) {
          *(uint8 *)(this + 88) = 1;
          this.mMaxLineCount = value ^ 1;
          this.mShouldBeProcessed = 1;
        }
    }

    // Token : 0x600082D
    // RVA   : 0x10FC050   Offset: 0x10FA850   Length: 0x2E
    public override Vector3[] get_localCorners()
    {
        if (this.mShouldBeProcessed) {
          UILabel.ProcessText(this,0,1,0);
        }
        UIWidget.get_localCorners(this,0);
    }

    // Token : 0x600082E
    // RVA   : 0x10FC760   Offset: 0x10FAF60   Length: 0x2E
    public override Vector3[] get_worldCorners()
    {
        if (this.mShouldBeProcessed) {
          UILabel.ProcessText(this,0,1,0);
        }
        UIWidget.get_worldCorners(this,0);
    }

    // Token : 0x600082F
    // RVA   : 0x10FBC30   Offset: 0x10FA430   Length: 0x4D
    public override Vector4 get_drawingDimensions()
    {
        ulong uVar1;
        byte[] local_18 = new byte[16];
        if (*(char *)(param_2 + 0x24c) != false) {
          UILabel.ProcessText(param_2,0,1,0);
        }
        puVar2 = (uint64 *)UIWidget.get_drawingDimensions(local_18,param_2,0);
        uVar1 = puVar2[1];
        *this = *puVar2;
        this[1] = uVar1;
        return this;
    }

    // Token : 0x6000830
    // RVA   : 0x10FC320   Offset: 0x10FAB20   Length: 0x7
    public int get_maxLineCount()
    {
        uint32 FUN_1810fc320(int64 this)
        {
        return this.mMaxLineCount;
    }

    // Token : 0x6000831
    // RVA   : 0x10FCE90   Offset: 0x10FB690   Length: 0x58
    public void set_maxLineCount(int value)
    {
        uint uVar1;
        if ((int)this[55] != value) {
          uVar1 = Mathf.Max(value,0,0);
          *(uint32 *)(this + 55) = uVar1;
          *(uint8 *)(this + 11) = 1;
          *(uint8 *)((int64)this + 0x24c) = 1;
          if (*(int *)((int64)this + 0x1dc) == 0) {
                          // WARNING: Could not recover jumptable at 0x0001810fcedb. Too many branches
                          // WARNING: Treating indirect jump as call
            (**(code **)(*this + 0x348))(this,*(uint64 *)(*this + 0x350));
            return;
          }
        }
    }

    // Token : 0x6000832
    // RVA   : 0x10FBCB0   Offset: 0x10FA4B0   Length: 0x7
    public Effect get_effectStyle()
    {
        uint32 FUN_1810fbcb0(int64 this)
        {
        return this.mEffectStyle;
    }

    // Token : 0x6000833
    // RVA   : 0x10FCBD0   Offset: 0x10FB3D0   Length: 0x1A
    public void set_effectStyle(Effect value)
    {
        void FUN_1810fcbd0(int64 this,int value)
        {
        if (this.mEffectStyle != value) {
          this.mEffectStyle = value;
          *(uint8 *)(this + 88) = 1;
          this.mShouldBeProcessed = 1;
        }
    }

    // Token : 0x6000834
    // RVA   : 0x10FBC80   Offset: 0x10FA480   Length: 0xE
    public Color get_effectColor()
    {
        uint64 * FUN_1810fbc80(uint64 *this,int64 param_2)
        {
        uint64 uVar1;
        uVar1 = *(uint64 *)(param_2 + 0x1c8);
        *this = *(uint64 *)(param_2 + 0x1c0);
        this[1] = uVar1;
        return this;
    }

    // Token : 0x6000835
    // RVA   : 0x10FCB00   Offset: 0x10FB300   Length: 0x63
    public void set_effectColor(Color value)
    {
        ulong uVar1;
        bool cVar2;
        ulong local_28;
        ulong uStack_20;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        local_28 = *value;
        uStack_20 = value[1];
        local_18 = this.mEffectColor;
        uStack_14 = *(uint32 *)(this + 0x1c4);
        uStack_10 = *(uint32 *)(this + 0x1c8);
        uStack_c = *(uint32 *)(this + 0x1cc);
        cVar2 = Color.op_Inequality(&local_18,&local_28,0);
        if (cVar2) {
          uVar1 = value[1];
          this.mEffectColor = *value;
          *(uint64 *)(this + 0x1c8) = uVar1;
          if (this.mEffectStyle != null) {
            *(uint8 *)(this + 88) = 1;
            this.mShouldBeProcessed = 1;
          }
        }
    }

    // Token : 0x6000836
    // RVA   : 0x10FBC90   Offset: 0x10FA490   Length: 0x19
    public Vector2 get_effectDistance()
    {
        uint64 FUN_1810fbc90(int64 this)
        {
        return this.mEffectDistance;
    }

    // Token : 0x6000837
    // RVA   : 0x10FCB70   Offset: 0x10FB370   Length: 0x51
    public void set_effectDistance(Vector2 value)
    {
        void FUN_1810fcb70(int64 this,uint64 value)
        {
        float fVar1;
        float fVar2;
        fVar1 = this.mEffectDistance - (float)value;
        fVar2 = *(float *)(this + 0x1d8) - (float)((uint64)value >> 32);
        if (9.9999994e-11 <= fVar2 * fVar2 + fVar1 * fVar1) {
          this.mEffectDistance = value;
          *(uint8 *)(this + 88) = 1;
          this.mShouldBeProcessed = 1;
        }
    }

    // Token : 0x6000838
    // RVA   : 0x10FC5D0   Offset: 0x10FADD0   Length: 0x2D
    public int get_quadsPerCharacter()
    {
        int iVar1;
        ulong uVar2;
        iVar1 = this.mEffectStyle;
        if (iVar1 == 1) {
          return 2;
        }
        if (iVar1 != 2) {
          uVar2 = 9;
          if (iVar1 != 3) {
            uVar2 = 1;
          }
          return uVar2;
        }
        return 5;
    }

    // Token : 0x6000839
    // RVA   : 0x10FC610   Offset: 0x10FAE10   Length: 0xB
    public bool get_shrinkToFit()
    {
        bool FUN_1810fc610(int64 this)
        {
        return this.mOverflow == null;
    }

    // Token : 0x600083A
    // RVA   : 0x10FD020   Offset: 0x10FB820   Length: 0x23
    public void set_shrinkToFit(bool value)
    {
        void FUN_1810fd020(int64 this,char value)
        {
        if ((value) && (this.mOverflow != null)) {
          this.mOverflow = 0;
          *(uint8 *)(this + 88) = 1;
          this.mShouldBeProcessed = 1;
        }
    }

    // Token : 0x600083B
    // RVA   : 0x10FC550   Offset: 0x10FAD50   Length: 0x71
    public string get_processedText()
    {
        if ((this.mLastWidth == *(int *)(this + 164)) &&
           (this.mLastHeight == *(int *)(this + 168))) {
          if (!this.mShouldBeProcessed) {
            return this.mProcessedText;
          }
        }
        else {
          this.mLastHeight = *(uint32 *)(this + 168);
          this.mLastWidth = *(int *)(this + 164);
          this.mShouldBeProcessed = 1;
        }
        UILabel.ProcessText(this,0,1,0);
        return this.mProcessedText;
    }

    // Token : 0x600083C
    // RVA   : 0x10FC470   Offset: 0x10FAC70   Length: 0x3D
    public Vector2 get_printedSize()
    {
        if (this.mShouldBeProcessed) {
          UILabel.ProcessText(this,0,1,0);
        }
        return this.mCalculatedSize;
    }

    // Token : 0x600083D
    // RVA   : 0x10FC080   Offset: 0x10FA880   Length: 0x2E
    public override Vector2 get_localSize()
    {
        if (this.mShouldBeProcessed) {
          UILabel.ProcessText(this,0,1,0);
        }
        UIWidget.get_localSize(this,0);
    }

    // Token : 0x600083E
    // RVA   : 0x10FBF10   Offset: 0x10FA710   Length: 0xA8
    private bool get_isValid()
    {
        ulong uVar1;
        bool cVar2;
        byte uVar3;
        uVar1 = this.mFont;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          return true;
        }
        uVar1 = *(uint64 *)(this + 400);
        uVar3 = Object.op_Inequality(uVar1,0,0);
        return uVar3;
    }

    // Token : 0x600083F
    // RVA   : 0x10FC330   Offset: 0x10FAB30   Length: 0x7
    public Modifier get_modifier()
    {
        uint32 FUN_1810fc330(int64 this)
        {
        return this.mModifier;
    }

    // Token : 0x6000840
    // RVA   : 0x10FCEF0   Offset: 0x10FB6F0   Length: 0x3C
    public void set_modifier(Modifier value)
    {
        if (*(int *)((int64)this + 0x224) != value) {
          *(int *)((int64)this + 0x224) = value;
          (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
          UILabel.ProcessAndRequest(this,0);
          return;
        }
    }

    // Token : 0x6000841
    // RVA   : 0x10F91E0   Offset: 0x10F79E0   Length: 0xA3
    protected override void OnInit()
    {
        var pStatics = *(int64*)(DAT_181d8ab58 + 184);
        ulong uVar1;
        UIWidget.OnInit(this,0);
        if (*pStatics != 0) {
          FUN_18154cb60(*pStatics,this,DAT_181d81a98);
          uVar1 = UILabel.get_trueTypeFont(this,0);
          UILabel.SetActiveFont(this,uVar1,0);
          return;
        }
    }

    // Token : 0x6000842
    // RVA   : 0x10F8620   Offset: 0x10F6E20   Length: 0x98
    protected override void OnDisable()
    {
        var pStatics = *(int64*)(DAT_181d8ab58 + 184);
        UILabel.SetActiveFont(this,0,0);
        if (*pStatics != 0) {
          FUN_18154eb70(*pStatics,this,DAT_181d81b18);
          UIWidget.OnDisable(this,0);
          return;
        }
    }

    // Token : 0x6000843
    // RVA   : 0x10FA4B0   Offset: 0x10F8CB0   Length: 0x292
    protected void SetActiveFont(Font fnt)
    {
        var pStatics = *(int64*)(DAT_181d8ab58 + 184);
        ulong uVar1;
        long lVar2;
        bool cVar3;
        int[] local_res8 = new int[2];
        uVar1 = this.mActiveTTF;
        local_res8[0] = 0;
        cVar3 = Object.op_Inequality(uVar1,fnt,0);
        if (cVar3) {
          uVar1 = this.mActiveTTF;
          cVar3 = Object.op_Inequality(uVar1,0,0);
          if (cVar3) {
            lVar2 = *(int64 *)(pStatics + 8);
            if (lVar2 == null) goto LAB_1810fa73d;
            cVar3 = FUN_181783810(lVar2,uVar1,local_res8,DAT_181d8ffc0);
            if (cVar3) {
              local_res8[0] = local_res8[0] + -1;
              local_res8[0] = Mathf.Max(0,local_res8[0],0);
              if (local_res8[0] == 0) {
                lVar2 = *(int64 *)(pStatics + 8);
                if (lVar2 == null) goto LAB_1810fa73d;
                FUN_181779c50(lVar2,uVar1,DAT_181d8ff38);
              }
              else {
                lVar2 = *(int64 *)(pStatics + 8);
                if (lVar2 == null) goto LAB_1810fa73d;
                FUN_1808aec90(lVar2,uVar1,local_res8[0],DAT_181d90048);
              }
            }
          }
          this.mActiveTTF = fnt;
          cVar3 = Object.op_Inequality(fnt,0,0);
          if (cVar3) {
            lVar2 = *(int64 *)(pStatics + 8);
            if (lVar2 == null) {
        LAB_1810fa73d:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            FUN_1808aec90(lVar2,fnt,1,DAT_181d90048);
          }
        }
    }

    // Token : 0x6000844
    // RVA   : 0x10FC4B0   Offset: 0x10FACB0   Length: 0x98
    public string get_printedText()
    {
        int iVar1;
        bool cVar2;
        ulong uVar3;
        cVar2 = FUN_180d6ca90(this.mText,0);
        if ((!cVar2) && (iVar1 = this.mModifier) != null) {
          if (iVar1 == 2) {
            if (this.mText != null) {
              uVar3 = String.ToLower(this.mText,0);
              return uVar3;
            }
          }
          else {
            if (iVar1 != 1) {
              if ((iVar1 == 255) && (this.customModifier != null)) {
                uVar3 = ModifierFunc.Invoke
                                  (this.customModifier,this.mText,0);
                return uVar3;
              }
              goto LAB_1810fc536;
            }
            if (this.mText != null) {
              uVar3 = String.ToUpper(this.mText,0);
              return uVar3;
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        LAB_1810fc536:
        return this.mText;
    }

    // Token : 0x6000845
    // RVA   : 0x10F8CC0   Offset: 0x10F74C0   Length: 0x51B
    private static void OnFontChanged(Font font)
    {
        var pStatics = *(int64*)(DAT_181d8ab58 + 184);
        int iVar1;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        uint uVar7;
        uint uVar8;
        uVar8 = 0;
        uVar7 = uVar8;
        while( true ) {
          if (*pStatics == 0) throw; // [null/range check failed]
          if (*(int *)(*pStatics + 24) <= (int)uVar7) break;
          if ((*pStatics == 0) ||
             (lVar4 = *(int64 *)(*pStatics + 16)) == null)
          throw; // [null/range check failed]
          if (*(uint32 *)(lVar4 + 24) <= uVar7) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          plVar2 = lVar4[uVar7];
          cVar3 = Object.op_Inequality(plVar2,0,0);
          if (cVar3) {
            if (plVar2 == (int64 *)0) throw; // [null/range check failed]
            lVar4 = UILabel.get_trueTypeFont(plVar2,0);
            cVar3 = Object.op_Equality(lVar4,font);
            if (cVar3) {
              if (lVar4 == null) throw; // [null/range check failed]
              Font.RequestCharactersInTexture
                        (lVar4,plVar2[52],(int)plVar2[77],*(uint32 *)((int64)plVar2 + 0x1ac),0)
              ;
              (**(code **)(*plVar2 + 0x328))(plVar2,*(uint64 *)(*plVar2 + 0x330));
              lVar4 = plVar2[29];
              cVar3 = Object.op_Equality(lVar4,0);
              if (cVar3) {
                UIWidget.CreatePanel(plVar2,0);
              }
              if (*(int64 *)(pStatics + 16) == 0) {
                uVar5 = new BetterList_1(DAT_181d81518);
                puVar6 = (uint64 *)(pStatics + 16);
                *puVar6 = uVar5;
                il2cpp_internal(puVar6,uVar5);
              }
              lVar4 = plVar2[43];
              cVar3 = Object.op_Inequality(lVar4,0,0);
              if (cVar3) {
                lVar4 = *(int64 *)(pStatics + 16);
                if (lVar4 == null) throw; // [null/range check failed]
                cVar3 = FUN_18154d3d0(lVar4,plVar2[43]);
                if (!cVar3) {
                  lVar4 = *(int64 *)(pStatics + 16);
                  if (lVar4 == null) throw; // [null/range check failed]
                  FUN_18154cb60(lVar4,plVar2[43]);
                }
              }
            }
          }
          uVar7 = uVar7 + 1;
        }
        if (*(int64 *)(pStatics + 16) == 0) {
          return;
        }
        lVar4 = *(int64 *)(pStatics + 16);
        if (lVar4 != null) {
          iVar1 = *(int *)(lVar4 + 24);
          if (iVar1 < 1) goto LAB_1810f9161;
          goto LAB_1810f90b0;
        }
        throw; // [null/range check failed]
        while( true ) {
          if (*(uint32 *)(lVar4 + 24) <= uVar8) {
            uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar5,0);
          }
          lVar4 = lVar4[uVar8];
          if (lVar4 == null) throw; // [null/range check failed]
          uVar5 = *(uint64 *)(lVar4 + 48);
          cVar3 = Object.op_Inequality(uVar5,0,0);
          if (cVar3) {
            if (*(int64 *)(lVar4 + 48) == 0) throw; // [null/range check failed]
            UIPanel.FillDrawCall();
          }
          uVar8 = uVar8 + 1;
          if (iVar1 <= (int)uVar8) break;
        LAB_1810f90b0:
          lVar4 = *(int64 *)(pStatics + 16);
          if ((lVar4 == null) || (lVar4 = *(int64 *)(lVar4 + 16)) == null) throw; // [null/range check failed]
        }
        LAB_1810f9161:
        lVar4 = *(int64 *)(pStatics + 16);
        if (lVar4 != null) {
          BetterList_1.Clear(lVar4,DAT_181d81618);
          return;
        }
    }

    // Token : 0x6000846
    // RVA   : 0x10F7C50   Offset: 0x10F6450   Length: 0x3E
    public override Vector3[] GetSides(Transform relativeTo)
    {
        if (this.mShouldBeProcessed) {
          UILabel.ProcessText(this,0,1,0);
        }
        UIWidget.GetSides(this,relativeTo,0);
    }

    // Token : 0x6000847
    // RVA   : 0x10FB350   Offset: 0x10F9B50   Length: 0x1BB
    protected override void UpgradeFrom265()
    {
        bool cVar1;
        int iVar2;
        ulong uVar3;
        UILabel.ProcessText(this,1,1,0);
        if (this.mShrinkToFit) {
          if (this.mOverflow != null) {
            this.mOverflow = 0;
            *(uint8 *)(this + 88) = 1;
            this.mShouldBeProcessed = 1;
          }
          this.mMaxLineCount = 0;
        }
        if (this.mMaxLineWidth == null) {
          if (this.mOverflow == 2) goto LAB_1810fb417;
          this.mOverflow = 2;
        }
        else {
          UIWidget.set_width(this,this.mMaxLineWidth,0);
          iVar2 = 3;
          if (this.mMaxLineCount < 1) {
            iVar2 = 0;
          }
          if (this.mOverflow == iVar2) goto LAB_1810fb417;
          this.mOverflow = iVar2;
        }
        this.mShouldBeProcessed = 1;
        *(uint8 *)(this + 88) = 1;
        LAB_1810fb417:
        if (this.mMaxLineHeight != null) {
          UIWidget.set_height(this,this.mMaxLineHeight,0);
        }
        uVar3 = this.mFont;
        cVar1 = Object.op_Inequality(uVar3,0,0);
        if (cVar1) {
          iVar2 = UILabel.get_defaultFontSize(this,0);
          if (*(int *)(this + 168) < iVar2) {
            UIWidget.set_height(this,iVar2,0);
          }
          iVar2 = Mathf.Clamp(iVar2,0,0x100,0);
          if (this.mFontSize != iVar2) {
            this.mFontSize = iVar2;
            *(uint8 *)(this + 88) = 1;
            this.mShouldBeProcessed = 1;
            UILabel.ProcessAndRequest(this,0);
          }
        }
        this.mMaxLineWidth = 0;
        this.mShrinkToFit = 0;
        uVar3 = Component.get_gameObject(this,0);
        NGUITools.UpdateWidgetCollider(uVar3,1,0);
    }

    // Token : 0x6000848
    // RVA   : 0x10F84A0   Offset: 0x10F6CA0   Length: 0xED
    protected override void OnAnchor()
    {
        ulong uVar1;
        bool cVar2;
        if (this.mOverflow == 2) {
          cVar2 = UIRect.get_isFullyAnchored(this,0);
        }
        else {
          if (this.mOverflow != 3) goto LAB_1810f8574;
          if (*(int64 *)(this + 48) == 0) {
        LAB_1810f8588:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar1 = *(uint64 *)(*(int64 *)(this + 48) + 16);
          cVar2 = Object.op_Inequality(uVar1,0,0);
          if (!cVar2) goto LAB_1810f8574;
          if (*(int64 *)(this + 40) == 0) goto LAB_1810f8588;
          uVar1 = *(uint64 *)(*(int64 *)(this + 40) + 16);
          cVar2 = Object.op_Inequality(uVar1,0,0);
        }
        if (cVar2) {
          this.mOverflow = 0;
        }
        LAB_1810f8574:
        UIWidget.OnAnchor(this,0);
    }

    // Token : 0x6000849
    // RVA   : 0x10F9800   Offset: 0x10F8000   Length: 0x80
    private void ProcessAndRequest()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = UILabel.get_ambigiousFont(this,0);
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          UILabel.ProcessText(this,0,1,0);
        }
    }

    // Token : 0x600084A
    // RVA   : 0x10F86C0   Offset: 0x10F6EC0   Length: 0xEA
    protected override void OnEnable()
    {
        var pStatics = *(int64*)(DAT_181d8ab58 + 184);
        ulong uVar1;
        UIRect.OnEnable(this,0);
        if (*(char *)(pStatics + 24) == false) {
          *(uint8 *)(pStatics + 24) = 1;
          uVar1 = new OnTooltipCB(0,DAT_181d9cb80,DAT_181d72588);
          Font.add_textureRebuilt(uVar1,0);
          return;
        }
    }

    // Token : 0x600084B
    // RVA   : 0x10F9290   Offset: 0x10F7A90   Length: 0x18C
    protected override void OnStart()
    {
        bool cVar1;
        byte uVar2;
        uint uVar3;
        ulong uVar4;
        long lVar5;
        UIWidget.OnStart(this,0);
        if (0.0 < *(float *)((int64)this + 0x234)) {
          uVar3 = Mathf.RoundToInt(*(float *)((int64)this + 0x234),0);
          *(uint32 *)((int64)this + 0x22c) = uVar3;
          *(uint32 *)((int64)this + 0x234) = 0;
        }
        if ((char)this[71] == false) {
          *(uint32 *)(this + 55) = 1;
          *(uint8 *)(this + 71) = 1;
        }
        uVar4 = (**(code **)(*this + 0x2c8))(this,*(uint64 *)(*this + 0x2d0));
        cVar1 = Object.op_Inequality(uVar4,0,0);
        if (cVar1) {
          lVar5 = (**(code **)(*this + 0x2c8))(this,*(uint64 *)(*this + 0x2d0));
          if (lVar5 == null) goto LAB_1810f9417;
          uVar4 = Material.get_shader(lVar5,0);
          cVar1 = Object.op_Inequality(uVar4,0,0);
          if (cVar1) {
            lVar5 = (**(code **)(*this + 0x2c8))(this,*(uint64 *)(*this + 0x2d0));
            if (lVar5 == null) {
        LAB_1810f9417:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar5 = Material.get_shader(lVar5,0);
            if (lVar5 == null) goto LAB_1810f9417;
            lVar5 = Object.get_name(lVar5,0);
            if (lVar5 == null) goto LAB_1810f9417;
            uVar2 = String.Contains(lVar5,"Premultiplied",0);
            goto LAB_1810f93fd;
          }
        }
        uVar2 = 0;
        LAB_1810f93fd:
        *(uint8 *)(this + 75) = uVar2;
        UILabel.ProcessAndRequest(this,0);
    }

    // Token : 0x600084C
    // RVA   : 0x10F8480   Offset: 0x10F6C80   Length: 0x12
    public override void MarkAsChanged()
    {
        void FUN_1810f8480(int64 this)
        {
        *(uint8 *)(this + 88) = 1;
        this.mShouldBeProcessed = 1;
        UIWidget.MarkAsChanged(this,0);
    }

    // Token : 0x600084D
    // RVA   : 0x10F9880   Offset: 0x10F8080   Length: 0xC29
    public void ProcessText(bool legacyMode, bool full)
    {
        var pStatics = *(int64*)(DAT_181d66a70 + 184);
        float fVar1;
        bool cVar2;
        bool cVar3;
        uint uVar4;
        int iVar5;
        uint uVar6;
        uint uVar7;
        uint uVar8;
        long lVar9;
        ulong uVar10;
        int iVar12;
        float fVar13;
        float fVar14;
        ulong local_88;
        uint local_80;
        byte[] local_78 = new byte[80];
        cVar2 = UILabel.get_isValid(this);
        if (!cVar2) {
          return;
        }
        *(uint8 *)(this + 11) = 1;
        *(uint8 *)((int64)this + 0x24c) = 0;
        fVar14 = *(float *)((int64)this + 0x104) - *(float *)((int64)this + 252);
        fVar13 = *(float *)(this + 33) - *(float *)(this + 32);
        if (!legacyMode) {
          iVar12 = *(int *)((int64)this + 164);
        }
        else {
          iVar12 = 1000000;
          if (*(int *)((int64)this + 0x22c) != 0) {
            iVar12 = *(int *)((int64)this + 0x22c);
          }
        }
        *(int *)(pStatics + 60) = iVar12;
        if (!legacyMode) {
          iVar12 = (int)this[21];
        }
        else {
          iVar12 = 1000000;
          if ((int)this[70] != 0) {
            iVar12 = (int)this[70];
          }
        }
        *(int *)(pStatics + 64) = iVar12;
        if (fVar14 == 1.0) {
          uVar4 = *(uint32 *)(pStatics + 60);
        }
        else {
          uVar4 = Mathf.RoundToInt((float)*(int *)(pStatics + 60) * fVar14);
        }
        *(uint32 *)(pStatics + 68) = uVar4;
        if (fVar13 == 1.0) {
          uVar4 = *(uint32 *)(pStatics + 64);
        }
        else {
          uVar4 = Mathf.RoundToInt((float)*(int *)(pStatics + 64) * fVar13);
        }
        *(uint32 *)(pStatics + 72) = uVar4;
        if (!legacyMode) {
          uVar4 = UILabel.get_defaultFontSize(this);
        }
        else {
          lVar9 = UIRect.get_cachedTransform();
          if (lVar9 == null) goto LAB_1810fa4a4;
          Transform.get_localScale(&local_88,lVar9,0);
          uVar4 = Mathf.RoundToInt();
        }
        uVar4 = Mathf.Abs(uVar4);
        *(uint32 *)(this + 77) = uVar4;
        *(uint32 *)((int64)this + 0x264) = 0x3f800000;
        if (0 < *(int *)(pStatics + 68)) {
          if (-1 < *(int *)(pStatics + 72)) {
            uVar10 = UILabel.get_trueTypeFont(this);
            cVar2 = Object.op_Inequality(uVar10,0,0);
            if ((!cVar2) || (cVar2 = UILabel.get_keepCrisp(this), !cVar2)) {
              *(uint32 *)(this + 73) = 0x3f800000;
            }
            else {
              lVar9 = UIRect.get_root(this);
              cVar2 = Object.op_Inequality(lVar9,0,0);
              if (cVar2) {
                cVar2 = Object.op_Inequality(lVar9,0,0);
                if (!cVar2) {
                  *(uint32 *)(this + 73) = 0x3f800000;
                }
                else {
                  if (lVar9 == null) goto LAB_1810fa4a4;
                  uVar4 = UIRoot.get_pixelSizeAdjustment(lVar9);
                  *(uint32 *)(this + 73) = uVar4;
                }
              }
            }
            if (full) {
              UILabel.UpdateNGUIText(this);
            }
            if (*(int *)((int64)this + 0x1dc) == 2) {
              iVar12 = *(int *)((int64)this + 0x21c);
              if (iVar12 < 1) {
                *(uint32 *)(pStatics + 60) = 1000000;
                *(uint32 *)(pStatics + 68) = 1000000;
              }
              else {
                *(int *)(pStatics + 60) = iVar12;
                *(uint32 *)(pStatics + 68) =
                     *(uint32 *)((int64)this + 0x21c);
              }
              lVar9 = this[68];
              if ((int)lVar9 < 1) {
                if (((*(byte *)(DAT_181d66a70 + 0x133) & 4) == 0) || (*(int *)(DAT_181d66a70 + 224) != 0)
                   ) goto LAB_1810f9d41;
                il2cpp_runtime_class_init(DAT_181d66a70);
                *(uint32 *)(pStatics + 64) = 1000000;
                *(uint32 *)(pStatics + 72) = 1000000;
              }
              else {
                *(int *)(pStatics + 64) = (int)lVar9;
                *(int *)(pStatics + 72) = (int)this[68];
              }
            }
            else if (*(int *)((int64)this + 0x1dc) == 3) {
        LAB_1810f9d41:
              *(uint32 *)(pStatics + 64) = 1000000;
              *(uint32 *)(pStatics + 72) = 1000000;
            }
            if ((int)this[77] < 1) {
              lVar9 = UIRect.get_cachedTransform();
              puVar11 = (uint64 *)Vector3.get_one(local_78,0);
              if (lVar9 == null) {
        LAB_1810fa4a4:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              local_80 = *(uint32 *)(puVar11 + 1);
              local_88 = *puVar11;
              Transform.set_localScale(lVar9,&local_88,0);
              this[74] = "";
              il2cpp_internal();
              *(uint32 *)((int64)this + 0x264) = 0x3f800000;
            }
            else {
              cVar2 = UILabel.get_keepCrisp(this);
              iVar12 = (int)this[77];
              if (0 < iVar12) {
                while( true ) {
                  if (!cVar2) {
                    *(float *)((int64)this + 0x264) = (float)iVar12 / (float)(int)this[77];
                    lVar9 = UILabel.get_bitmapFont(this,0);
                    if (lVar9 == null) {
                      uVar4 = *(uint32 *)((int64)this + 0x264);
                      *(uint32 *)(pStatics + 28) = uVar4;
                    }
                    else {
                      lVar9 = this[53];
                      iVar5 = UILabel.get_defaultFontSize(this,0);
                      fVar1 = *(float *)((int64)this + 0x264);
                      *(float *)(pStatics + 28) =
                           ((float)(int)lVar9 / (float)iVar5) * fVar1;
                    }
                  }
                  else {
                    *(int *)(this + 77) = iVar12;
                    *(int *)(pStatics + 24) = iVar12;
                  }
                  NGUIText.Update(0,0);
                  uVar10 = UILabel.get_printedText(this,0);
                  if (*(int *)((int64)this + 0x1dc) == 1) {
                    cVar3 = (char)this[67];
                  }
                  else {
                    cVar3 = false;
                  }
                  cVar3 = NGUIText.WrapText(uVar10,this + 74,0,0,cVar3,0);
                  iVar5 = *(int *)((int64)this + 0x1dc);
                  if (iVar5 != 0) break;
                  if (cVar3) {
                    lVar9 = this[74];
        LAB_1810fa2a7:
                    uVar10 = NGUIText.CalculatePrintedSize(lVar9,0);
                    local_88._0_4_ = (uint32)uVar10;
                    local_88._4_4_ = (uint32)((uint64)uVar10 >> 32);
                    *(uint32 *)((int64)this + 0x25c) = (uint32)local_88;
                    *(uint32 *)(this + 76) = local_88._4_4_;
                    local_88 = uVar10;
                    goto LAB_1810fa3ba;
                  }
        LAB_1810fa1b6:
                  if ((iVar12 + -1 < 2) || (iVar12 = iVar12 + -2, iVar12 < 1)) goto LAB_1810f9f12;
                }
                if (iVar5 == 2) {
                  lVar9 = this[74];
                  uVar10 = NGUIText.CalculatePrintedSize(lVar9);
                  local_88._0_4_ = (uint32)uVar10;
                  local_88._4_4_ = (uint32)((uint64)uVar10 >> 32);
                  *(uint32 *)((int64)this + 0x25c) = (uint32)local_88;
                  *(uint32 *)(this + 76) = local_88._4_4_;
                  local_88 = uVar10;
                  if ((!cVar3) && (0 < *(int *)((int64)this + 0x21c))) goto LAB_1810fa1b6;
                  uVar4 = (**(code **)(*this + 0x358))(this,*(uint64 *)(*this + 0x360));
                  uVar6 = Mathf.RoundToInt();
                  uVar7 = Mathf.Max(uVar4,uVar6,0);
                  if (fVar14 != 1.0) {
                    uVar7 = Mathf.RoundToInt((float)(int)uVar7 / fVar14,0);
                  }
                  uVar4 = (**(code **)(*this + 0x368))(this,*(uint64 *)(*this + 0x370));
                  uVar6 = Mathf.RoundToInt();
                  uVar8 = Mathf.Max(uVar4,uVar6,0);
                  if (fVar13 != 1.0) {
                    uVar8 = Mathf.RoundToInt((float)(int)uVar8 / fVar13,0);
                  }
                  if ((uVar7 & 1) != 0) {
                    uVar7 = uVar7 + 1;
                  }
                  if ((uVar8 & 1) != 0) {
                    uVar8 = uVar8 + 1;
                  }
                  if ((*(uint32 *)((int64)this + 164) != uVar7) ||
                     (*(uint32 *)(this + 21) != uVar8)) {
                    *(uint32 *)((int64)this + 164) = uVar7;
        LAB_1810fa3a1:
                    *(uint32 *)(this + 21) = uVar8;
                    if (this[23] != 0) {
                      OnGeometryUpdated.Invoke(this[23],0);
                    }
                  }
                }
                else {
                  lVar9 = this[74];
                  if (iVar5 != 3) goto LAB_1810fa2a7;
                  uVar10 = NGUIText.CalculatePrintedSize(lVar9,0);
                  local_88._0_4_ = (uint32)uVar10;
                  local_88._4_4_ = (uint32)((uint64)uVar10 >> 32);
                  *(uint32 *)((int64)this + 0x25c) = (uint32)local_88;
                  *(uint32 *)(this + 76) = local_88._4_4_;
                  local_88 = uVar10;
                  uVar4 = (**(code **)(*this + 0x368))(this,*(uint64 *)(*this + 0x370));
                  uVar6 = Mathf.RoundToInt();
                  uVar7 = Mathf.Max(uVar4,uVar6,0);
                  if (fVar13 != 1.0) {
                    uVar7 = Mathf.RoundToInt((float)(int)uVar7 / fVar13,0);
                  }
                  uVar8 = uVar7 + 1;
                  if ((uVar7 & 1) == 0) {
                    uVar8 = uVar7;
                  }
                  if (*(uint32 *)(this + 21) != uVar8) goto LAB_1810fa3a1;
                }
        LAB_1810fa3ba:
                if (legacyMode) {
                  uVar4 = Mathf.RoundToInt();
                  UIWidget.set_width(this,uVar4,0);
                  uVar4 = Mathf.RoundToInt();
                  UIWidget.set_height(this,uVar4,0);
                  lVar9 = UIRect.get_cachedTransform(this,0);
                  puVar11 = (uint64 *)Vector3.get_one(local_78,0);
                  if (lVar9 == null) goto LAB_1810fa4a4;
                  local_80 = *(uint32 *)(puVar11 + 1);
                  local_88 = *puVar11;
                  Transform.set_localScale(lVar9,&local_88,0);
                }
              }
            }
        LAB_1810f9f12:
            if (!full) {
              return;
            }
            puVar11 = *(uint64 **)(DAT_181d66a70 + 184);
            *puVar11 = 0;
            il2cpp_internal(puVar11,0);
            this = (int64 *)(pStatics + 8);
            lVar9 = 0;
            *this = 0;
            goto LAB_1810fa451;
          }
        }
        lVar9 = "";
        this = this + 74;
        *this = "";
        LAB_1810fa451:
        il2cpp_internal(this,lVar9);
    }

    // Token : 0x600084E
    // RVA   : 0x10F8110   Offset: 0x10F6910   Length: 0x36E
    public override void MakePixelPerfect()
    {
        bool cVar1;
        int iVar2;
        uint uVar3;
        uint uVar4;
        uint uVar5;
        uint uVar6;
        uint uVar7;
        uint uVar8;
        ulong uVar9;
        long lVar10;
        ulong local_38;
        float local_30;
        ulong local_28;
        float local_20;
        uVar9 = UILabel.get_ambigiousFont(this,0);
        cVar1 = Object.op_Inequality(uVar9,0,0);
        if (!cVar1) {
          UIWidget.MakePixelPerfect();
          return;
        }
        lVar10 = UIRect.get_cachedTransform(this,0);
        if (lVar10 != null) {
          puVar11 = (uint64 *)Transform.get_localPosition(&local_28,lVar10,0);
          local_38 = *puVar11;
          local_30 = *(float *)(puVar11 + 1);
          iVar2 = Mathf.RoundToInt();
          local_38 = CONCAT44(local_38._4_4_,(float)iVar2);
          iVar2 = Mathf.RoundToInt();
          local_38 = CONCAT44((float)iVar2,(uint32)local_38);
          iVar2 = Mathf.RoundToInt();
          local_30 = (float)iVar2;
          lVar10 = UIRect.get_cachedTransform(this,0);
          if (lVar10 != null) {
            local_20 = local_30;
            local_28 = local_38;
            Transform.set_localPosition(lVar10,&local_28,0);
            lVar10 = UIRect.get_cachedTransform(this,0);
            puVar11 = (uint64 *)Vector3.get_one(&local_38,0);
            if (lVar10 != null) {
              local_20 = *(float *)(puVar11 + 1);
              local_28 = *puVar11;
              Transform.set_localScale(lVar10,&local_28,0);
              iVar2 = *(int *)((int64)this + 0x1dc);
              if (iVar2 != 2) {
                uVar8 = *(uint32 *)((int64)this + 164);
                lVar10 = this[21];
                if (iVar2 != 3) {
                  *(uint32 *)((int64)this + 164) = 100000;
                }
                *(uint32 *)(this + 21) = 100000;
                *(uint32 *)((int64)this + 0x1dc) = 0;
                UILabel.ProcessText(this,0,1,0);
                *(int *)((int64)this + 0x1dc) = iVar2;
                uVar3 = Mathf.RoundToInt();
                uVar4 = Mathf.RoundToInt();
                uVar5 = UIWidget.get_minHeight(this,0);
                uVar6 = Mathf.Max(uVar3,uVar5,0);
                uVar3 = UIWidget.get_minHeight(this,0);
                uVar7 = Mathf.Max(uVar4,uVar3,0);
                if ((uVar6 & 1) != 0) {
                  uVar6 = uVar6 + 1;
                }
                if ((uVar7 & 1) != 0) {
                  uVar7 = uVar7 + 1;
                }
                uVar8 = Mathf.Max(uVar8,uVar6,0);
                *(uint32 *)((int64)this + 164) = uVar8;
                uVar8 = Mathf.Max((int)lVar10,uVar7,0);
                *(uint32 *)(this + 21) = uVar8;
                          // WARNING: Could not recover jumptable at 0x0001810f838f. Too many branches
                          // WARNING: Treating indirect jump as call
                (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
                return;
              }
              uVar9 = UILabel.get_ambigiousFont(this,0);
              cVar1 = Object.op_Inequality(uVar9,0,0);
              if (!cVar1) {
                return;
              }
              *(uint32 *)((int64)this + 164) = 100000;
              *(uint32 *)(this + 21) = 100000;
              UILabel.ProcessText(this,0,1,0);
              uVar8 = Mathf.RoundToInt();
              *(uint32 *)((int64)this + 164) = uVar8;
              uVar6 = Mathf.RoundToInt();
              *(uint32 *)(this + 21) = uVar6;
              if ((*(uint32 *)((int64)this + 164) & 1) != 0) {
                *(uint32 *)((int64)this + 164) = *(uint32 *)((int64)this + 164) + 1;
              }
              if ((uVar6 & 1) != 0) {
                *(uint32 *)(this + 21) = uVar6 + 1;
              }
                          // WARNING: Could not recover jumptable at 0x0001810f8472. Too many branches
                          // WARNING: Treating indirect jump as call
              (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
              return;
            }
          }
        }
    }

    // Token : 0x600084F
    // RVA   : 0x10F6FE0   Offset: 0x10F57E0   Length: 0xF4
    public void AssumeNaturalSize()
    {
        bool cVar1;
        uint uVar2;
        uint uVar3;
        ulong uVar4;
        uVar4 = UILabel.get_ambigiousFont(this,0);
        cVar1 = Object.op_Inequality(uVar4,0,0);
        if (cVar1) {
          *(uint32 *)((int64)this + 164) = 100000;
          *(uint32 *)(this + 21) = 100000;
          UILabel.ProcessText(this,0,1,0);
          uVar2 = Mathf.RoundToInt(*(uint32 *)((int64)this + 0x25c),0);
          *(uint32 *)((int64)this + 164) = uVar2;
          uVar3 = Mathf.RoundToInt((int)this[76],0);
          *(uint32 *)(this + 21) = uVar3;
          if ((*(uint32 *)((int64)this + 164) & 1) != 0) {
            *(uint32 *)((int64)this + 164) = *(uint32 *)((int64)this + 164) + 1;
          }
          if ((uVar3 & 1) != 0) {
            *(uint32 *)(this + 21) = uVar3 + 1;
          }
          (**(code **)(*this + 0x328))(this,*(uint64 *)(*this + 0x330));
        }
    }

    // Token : 0x6000850
    // RVA   : 0x10F7670   Offset: 0x10F5E70   Length: 0x75
    public int GetCharacterIndex(Vector3 worldPos)
    {
        var pStatics = *(int64*)(DAT_181d8ab58 + 184);
        int iVar1;
        ulong uVar2;
        ulong uVar3;
        long lVar4;
        bool cVar5;
        int iVar6;
        int iVar7;
        long lVar8;
        uint uVar10;
        float fVar11;
        float fVar12;
        float fVar13;
        ulong local_48;
        cVar5 = UILabel.get_isValid(this,0);
        if (cVar5) {
          lVar8 = UILabel.get_processedText(this,0);
          cVar5 = FUN_180d6ca90(lVar8,0);
          if (!cVar5) {
            iVar6 = UILabel.get_defaultFontSize(this,0);
            UILabel.UpdateNGUIText(this,0);
            uVar2 = *(uint64 *)(pStatics + 32);
            uVar3 = *(uint64 *)(pStatics + 40);
            NGUIText.PrintApproximateCharacterPositions(lVar8,uVar2,uVar3,0);
            lVar4 = *(int64 *)(pStatics + 32);
            if (lVar4 == null) goto LAB_1810f7c3d;
            if (0 < *(int *)(lVar4 + 24)) {
              UILabel.ApplyOffset
                        (this,*(uint64 *)(pStatics + 32),0,0);
              uVar10 = 0;
              lVar4 = *(int64 *)(pStatics + 40);
              if (lVar4 == null) goto LAB_1810f7c3d;
              iVar1 = *(int *)(lVar4 + 24);
              if (0 < iVar1) {
                do {
                  lVar4 = *(int64 *)(pStatics + 40);
                  if (lVar4 == null) goto LAB_1810f7c3d;
                  iVar7 = FUN_1800d6750(lVar4,uVar10,DAT_181d68270);
                  if (iVar7 == worldPos) {
                    lVar4 = *(int64 *)(pStatics + 32);
                    if (lVar4 == null) goto LAB_1810f7c3d;
                    if (*(uint32 *)(lVar4 + 24) <= uVar10) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    uVar2 = *(uint64 *)
                             (*(int64 *)(lVar4 + 16) + 32 + (int64)(int)uVar10 * 12);
                    fVar12 = (float)uVar2;
                    fVar13 = (float)((uint64)uVar2 >> 32);
                    if (param_3 == 0x111) {
                      if (!this.mUseFloatSpacing) {
                        fVar11 = (float)this.mSpacingY;
                      }
                      else {
                        fVar11 = this.mFloatSpacingY;
                      }
                      fVar13 = (float)iVar6 + fVar11 + fVar13;
                    }
                    else if (param_3 == 0x112) {
                      if (!this.mUseFloatSpacing) {
                        fVar11 = (float)this.mSpacingY;
                      }
                      else {
                        fVar11 = this.mFloatSpacingY;
                      }
                      fVar13 = fVar13 - ((float)iVar6 + fVar11);
                    }
                    else if (param_3 == 0x116) {
                      fVar12 = fVar12 - 1000.0;
                    }
                    else if (param_3 == 0x117) {
                      fVar12 = fVar12 + 1000.0;
                    }
                    uVar2 = *(uint64 *)(pStatics + 32);
                    uVar3 = *(uint64 *)(pStatics + 40);
                    local_48 = CONCAT44(fVar13,fVar12);
                    iVar6 = NGUIText.GetApproximateCharacterIndex(uVar2,uVar3,local_48,0);
                    if (iVar6 != worldPos) {
                      lVar8 = *(int64 *)(pStatics + 32);
                      if (lVar8 != null) {
                        FUN_180f56130(lVar8,DAT_181d84378);
                        lVar8 = *(int64 *)(pStatics + 40);
                        if (lVar8 != null) {
                          FUN_180f56130(lVar8,DAT_181d67b78);
                          return iVar6;
                        }
                      }
                      goto LAB_1810f7c3d;
                    }
                    break;
                  }
                  uVar10 = uVar10 + 1;
                } while ((int)uVar10 < iVar1);
              }
              lVar4 = *(int64 *)(pStatics + 32);
              if (lVar4 == null) goto LAB_1810f7c3d;
              FUN_180f56130(lVar4,DAT_181d84378);
              lVar4 = *(int64 *)(pStatics + 40);
              if (lVar4 == null) goto LAB_1810f7c3d;
              FUN_180f56130(lVar4,DAT_181d67b78);
            }
            puVar9 = *(uint64 **)(DAT_181d66a70 + 184);
            *puVar9 = 0;
            il2cpp_internal(puVar9,0);
            puVar9 = (uint64 *)(*(int64 *)(DAT_181d66a70 + 184) + 8);
            *puVar9 = 0;
            il2cpp_internal(puVar9,0);
            if ((param_3 != 0x111) && (param_3 != 0x116)) {
              if ((param_3 != 0x112) && (param_3 != 0x117)) {
                return worldPos;
              }
              if (lVar8 != null) {
                return *(int *)(lVar8 + 16);
              }
        LAB_1810f7c3d:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
          }
          worldPos = 0;
        }
        return worldPos;
    }

    // Token : 0x6000851
    // RVA   : 0x10F7660   Offset: 0x10F5E60   Length: 0xB
    public int GetCharacterIndex(Vector2 localPos)
    {
        var pStatics = *(int64*)(DAT_181d8ab58 + 184);
        int iVar1;
        ulong uVar2;
        ulong uVar3;
        long lVar4;
        bool cVar5;
        int iVar6;
        int iVar7;
        long lVar8;
        uint uVar10;
        float fVar11;
        float fVar12;
        float fVar13;
        ulong local_48;
        cVar5 = UILabel.get_isValid(this,0);
        if (cVar5) {
          lVar8 = UILabel.get_processedText(this,0);
          cVar5 = FUN_180d6ca90(lVar8,0);
          if (!cVar5) {
            iVar6 = UILabel.get_defaultFontSize(this,0);
            UILabel.UpdateNGUIText(this,0);
            uVar2 = *(uint64 *)(pStatics + 32);
            uVar3 = *(uint64 *)(pStatics + 40);
            NGUIText.PrintApproximateCharacterPositions(lVar8,uVar2,uVar3,0);
            lVar4 = *(int64 *)(pStatics + 32);
            if (lVar4 == null) goto LAB_1810f7c3d;
            if (0 < *(int *)(lVar4 + 24)) {
              UILabel.ApplyOffset
                        (this,*(uint64 *)(pStatics + 32),0,0);
              uVar10 = 0;
              lVar4 = *(int64 *)(pStatics + 40);
              if (lVar4 == null) goto LAB_1810f7c3d;
              iVar1 = *(int *)(lVar4 + 24);
              if (0 < iVar1) {
                do {
                  lVar4 = *(int64 *)(pStatics + 40);
                  if (lVar4 == null) goto LAB_1810f7c3d;
                  iVar7 = FUN_1800d6750(lVar4,uVar10,DAT_181d68270);
                  if (iVar7 == localPos) {
                    lVar4 = *(int64 *)(pStatics + 32);
                    if (lVar4 == null) goto LAB_1810f7c3d;
                    if (*(uint32 *)(lVar4 + 24) <= uVar10) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    uVar2 = *(uint64 *)
                             (*(int64 *)(lVar4 + 16) + 32 + (int64)(int)uVar10 * 12);
                    fVar12 = (float)uVar2;
                    fVar13 = (float)((uint64)uVar2 >> 32);
                    if (param_3 == 0x111) {
                      if (!this.mUseFloatSpacing) {
                        fVar11 = (float)this.mSpacingY;
                      }
                      else {
                        fVar11 = this.mFloatSpacingY;
                      }
                      fVar13 = (float)iVar6 + fVar11 + fVar13;
                    }
                    else if (param_3 == 0x112) {
                      if (!this.mUseFloatSpacing) {
                        fVar11 = (float)this.mSpacingY;
                      }
                      else {
                        fVar11 = this.mFloatSpacingY;
                      }
                      fVar13 = fVar13 - ((float)iVar6 + fVar11);
                    }
                    else if (param_3 == 0x116) {
                      fVar12 = fVar12 - 1000.0;
                    }
                    else if (param_3 == 0x117) {
                      fVar12 = fVar12 + 1000.0;
                    }
                    uVar2 = *(uint64 *)(pStatics + 32);
                    uVar3 = *(uint64 *)(pStatics + 40);
                    local_48 = CONCAT44(fVar13,fVar12);
                    iVar6 = NGUIText.GetApproximateCharacterIndex(uVar2,uVar3,local_48,0);
                    if (iVar6 != localPos) {
                      lVar8 = *(int64 *)(pStatics + 32);
                      if (lVar8 != null) {
                        FUN_180f56130(lVar8,DAT_181d84378);
                        lVar8 = *(int64 *)(pStatics + 40);
                        if (lVar8 != null) {
                          FUN_180f56130(lVar8,DAT_181d67b78);
                          return iVar6;
                        }
                      }
                      goto LAB_1810f7c3d;
                    }
                    break;
                  }
                  uVar10 = uVar10 + 1;
                } while ((int)uVar10 < iVar1);
              }
              lVar4 = *(int64 *)(pStatics + 32);
              if (lVar4 == null) goto LAB_1810f7c3d;
              FUN_180f56130(lVar4,DAT_181d84378);
              lVar4 = *(int64 *)(pStatics + 40);
              if (lVar4 == null) goto LAB_1810f7c3d;
              FUN_180f56130(lVar4,DAT_181d67b78);
            }
            puVar9 = *(uint64 **)(DAT_181d66a70 + 184);
            *puVar9 = 0;
            il2cpp_internal(puVar9,0);
            puVar9 = (uint64 *)(*(int64 *)(DAT_181d66a70 + 184) + 8);
            *puVar9 = 0;
            il2cpp_internal(puVar9,0);
            if ((param_3 != 0x111) && (param_3 != 0x116)) {
              if ((param_3 != 0x112) && (param_3 != 0x117)) {
                return localPos;
              }
              if (lVar8 != null) {
                return *(int *)(lVar8 + 16);
              }
        LAB_1810f7c3d:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
          }
          localPos = 0;
        }
        return localPos;
    }

    // Token : 0x6000852
    // RVA   : 0x10F71C0   Offset: 0x10F59C0   Length: 0x84
    public int GetCharacterIndexAtPosition(Vector3 worldPos, bool precise)
    {
        var pStatics_6a70 = *(int64*)(DAT_181d66a70 + 184);
        var pStatics_ab58 = *(int64*)(DAT_181d8ab58 + 184);
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        bool cVar4;
        uint uVar5;
        ulong uVar6;
        cVar4 = UILabel.get_isValid(this,0);
        if (cVar4) {
          uVar6 = UILabel.get_processedText(this,0);
          cVar4 = FUN_180d6ca90(uVar6,0);
          if (!cVar4) {
            UILabel.UpdateNGUIText(this,0);
            if (!precise) {
              uVar1 = *(uint64 *)(pStatics_ab58 + 32);
              uVar2 = *(uint64 *)(pStatics_ab58 + 40);
              NGUIText.PrintApproximateCharacterPositions(uVar6,uVar1,uVar2,0);
            }
            else {
              uVar1 = *(uint64 *)(pStatics_ab58 + 32);
              uVar2 = *(uint64 *)(pStatics_ab58 + 40);
              NGUIText.PrintExactCharacterPositions(uVar6,uVar1,uVar2,0);
            }
            lVar3 = *(int64 *)(pStatics_ab58 + 32);
            if (lVar3 != null) {
              if (*(int *)(lVar3 + 24) < 1) {
                puVar7 = *(uint64 **)(DAT_181d66a70 + 184);
                *puVar7 = 0;
                il2cpp_internal(puVar7,0);
                puVar7 = (uint64 *)(pStatics_6a70 + 8);
                *puVar7 = 0;
                il2cpp_internal(puVar7,0);
                return false;
              }
              UILabel.ApplyOffset
                        (this,*(uint64 *)(pStatics_ab58 + 32),0,0);
              if (!precise) {
                uVar6 = *(uint64 *)(pStatics_ab58 + 32);
                uVar1 = *(uint64 *)(pStatics_ab58 + 40);
                uVar5 = NGUIText.GetApproximateCharacterIndex(uVar6,uVar1,worldPos,0);
              }
              else {
                uVar6 = *(uint64 *)(pStatics_ab58 + 32);
                uVar1 = *(uint64 *)(pStatics_ab58 + 40);
                uVar5 = NGUIText.GetExactCharacterIndex(uVar6,uVar1,worldPos,0);
              }
              lVar3 = *(int64 *)(pStatics_ab58 + 32);
              if (lVar3 != null) {
                FUN_180f56130(lVar3,DAT_181d84378);
                lVar3 = *(int64 *)(pStatics_ab58 + 40);
                if (lVar3 != null) {
                  FUN_180f56130(lVar3,DAT_181d67b78);
                  puVar7 = *(uint64 **)(DAT_181d66a70 + 184);
                  *puVar7 = 0;
                  il2cpp_internal(puVar7,0);
                  puVar7 = (uint64 *)(pStatics_6a70 + 8);
                  *puVar7 = 0;
                  il2cpp_internal(puVar7,0);
                  return uVar5;
                }
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        return false;
    }

    // Token : 0x6000853
    // RVA   : 0x10F7250   Offset: 0x10F5A50   Length: 0x40D
    public int GetCharacterIndexAtPosition(Vector2 localPos, bool precise)
    {
        var pStatics_6a70 = *(int64*)(DAT_181d66a70 + 184);
        var pStatics_ab58 = *(int64*)(DAT_181d8ab58 + 184);
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        bool cVar4;
        uint uVar5;
        ulong uVar6;
        cVar4 = UILabel.get_isValid(this,0);
        if (cVar4) {
          uVar6 = UILabel.get_processedText(this,0);
          cVar4 = FUN_180d6ca90(uVar6,0);
          if (!cVar4) {
            UILabel.UpdateNGUIText(this,0);
            if (!precise) {
              uVar1 = *(uint64 *)(pStatics_ab58 + 32);
              uVar2 = *(uint64 *)(pStatics_ab58 + 40);
              NGUIText.PrintApproximateCharacterPositions(uVar6,uVar1,uVar2,0);
            }
            else {
              uVar1 = *(uint64 *)(pStatics_ab58 + 32);
              uVar2 = *(uint64 *)(pStatics_ab58 + 40);
              NGUIText.PrintExactCharacterPositions(uVar6,uVar1,uVar2,0);
            }
            lVar3 = *(int64 *)(pStatics_ab58 + 32);
            if (lVar3 != null) {
              if (*(int *)(lVar3 + 24) < 1) {
                puVar7 = *(uint64 **)(DAT_181d66a70 + 184);
                *puVar7 = 0;
                il2cpp_internal(puVar7,0);
                puVar7 = (uint64 *)(pStatics_6a70 + 8);
                *puVar7 = 0;
                il2cpp_internal(puVar7,0);
                return false;
              }
              UILabel.ApplyOffset
                        (this,*(uint64 *)(pStatics_ab58 + 32),0,0);
              if (!precise) {
                uVar6 = *(uint64 *)(pStatics_ab58 + 32);
                uVar1 = *(uint64 *)(pStatics_ab58 + 40);
                uVar5 = NGUIText.GetApproximateCharacterIndex(uVar6,uVar1,localPos,0);
              }
              else {
                uVar6 = *(uint64 *)(pStatics_ab58 + 32);
                uVar1 = *(uint64 *)(pStatics_ab58 + 40);
                uVar5 = NGUIText.GetExactCharacterIndex(uVar6,uVar1,localPos,0);
              }
              lVar3 = *(int64 *)(pStatics_ab58 + 32);
              if (lVar3 != null) {
                FUN_180f56130(lVar3,DAT_181d84378);
                lVar3 = *(int64 *)(pStatics_ab58 + 40);
                if (lVar3 != null) {
                  FUN_180f56130(lVar3,DAT_181d67b78);
                  puVar7 = *(uint64 **)(DAT_181d66a70 + 184);
                  *puVar7 = 0;
                  il2cpp_internal(puVar7,0);
                  puVar7 = (uint64 *)(pStatics_6a70 + 8);
                  *puVar7 = 0;
                  il2cpp_internal(puVar7,0);
                  return uVar5;
                }
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        return false;
    }

    // Token : 0x6000854
    // RVA   : 0x10F8050   Offset: 0x10F6850   Length: 0x82
    public string GetWordAtPosition(Vector3 worldPos)
    {
        uint uVar1;
        uVar1 = UILabel.GetCharacterIndexAtPosition(this,worldPos,1,0);
        UILabel.GetWordAtCharacterIndex(this,uVar1,0);
    }

    // Token : 0x6000855
    // RVA   : 0x10F80E0   Offset: 0x10F68E0   Length: 0x26
    public string GetWordAtPosition(Vector2 localPos)
    {
        uint uVar1;
        uVar1 = UILabel.GetCharacterIndexAtPosition(this,localPos,1,0);
        UILabel.GetWordAtCharacterIndex(this,uVar1,0);
    }

    // Token : 0x6000856
    // RVA   : 0x10F7EC0   Offset: 0x10F66C0   Length: 0x18B
    public string GetWordAtCharacterIndex(int characterIndex)
    {
        int iVar1;
        int iVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        lVar3 = UILabel.get_printedText(this,0);
        if (characterIndex != -1) {
          if (lVar3 == null) {
        LAB_1810f8046:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (characterIndex < *(int *)(lVar3 + 16)) {
            lVar4 = FUN_1800d60b0(DAT_181d7c118,2);
            if (lVar4 == null) goto LAB_1810f8046;
            if (*(uint32 *)(lVar4 + 24) == 0) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            *(uint16 *)(lVar4 + 32) = 32;
            if (*(uint32 *)(lVar4 + 24) < 2) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            *(uint16 *)(lVar4 + 34) = 10;
            iVar1 = String.LastIndexOfAny(lVar3,lVar4,characterIndex,0);
            iVar1 = iVar1 + 1;
            uVar5 = FUN_1800d60b0(DAT_181d7c118,4);
            RuntimeHelpers.InitializeArray(uVar5,DAT_181d91d80,0);
            iVar2 = String.IndexOfAny(lVar3,uVar5,characterIndex,0);
            if (iVar2 == -1) {
              iVar2 = *(int *)(lVar3 + 16);
            }
            if ((iVar1 != iVar2) && (0 < iVar2 - iVar1)) {
              uVar5 = String.Substring(lVar3,iVar1,iVar2 - iVar1,0);
              uVar5 = NGUIText.StripSymbols(uVar5,0);
              return uVar5;
            }
          }
        }
        return 0;
    }

    // Token : 0x6000857
    // RVA   : 0x10F7E00   Offset: 0x10F6600   Length: 0x82
    public string GetUrlAtPosition(Vector3 worldPos)
    {
        uint uVar1;
        uVar1 = UILabel.GetCharacterIndexAtPosition(this,worldPos,1,0);
        UILabel.GetUrlAtCharacterIndex(this,uVar1,0);
    }

    // Token : 0x6000858
    // RVA   : 0x10F7E90   Offset: 0x10F6690   Length: 0x26
    public string GetUrlAtPosition(Vector2 localPos)
    {
        uint uVar1;
        uVar1 = UILabel.GetCharacterIndexAtPosition(this,localPos,1,0);
        UILabel.GetUrlAtCharacterIndex(this,uVar1,0);
    }

    // Token : 0x6000859
    // RVA   : 0x10F7C90   Offset: 0x10F6490   Length: 0x16A
    public string GetUrlAtCharacterIndex(int characterIndex)
    {
        int iVar2;
        int iVar3;
        long lVar4;
        ulong uVar5;
        int iVar6;
        lVar4 = UILabel.get_printedText(this,0);
        if (characterIndex != -1) {
          if (lVar4 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if ((characterIndex < *(int *)(lVar4 + 16) + -6) &&
             (((((sVar1 = String.get_Chars(lVar4,characterIndex,0), sVar1 == 91 &&
                 (sVar1 = String.get_Chars(lVar4,characterIndex + 1,0), sVar1 == 117)) &&
                (sVar1 = String.get_Chars(lVar4,characterIndex + 2,0), sVar1 == 114)) &&
               ((sVar1 = String.get_Chars(lVar4,characterIndex + 3,0), sVar1 == 108 &&
                (sVar1 = String.get_Chars(lVar4,characterIndex + 4,0), iVar6 = characterIndex, sVar1 == 61)))) ||
              (iVar6 = String.LastIndexOf(lVar4,"[url=",characterIndex,0), iVar6 != -1)))) {
            iVar6 = iVar6 + 5;
            iVar2 = String.IndexOf(lVar4,"]",iVar6,0);
            if ((iVar2 != -1) &&
               ((iVar3 = String.IndexOf(lVar4,"[/url]",iVar2,0), iVar3 == -1 || (characterIndex <= iVar3)))
               ) {
              uVar5 = String.Substring(lVar4,iVar6,iVar2 - iVar6,0);
              return uVar5;
            }
          }
        }
        return 0;
    }

    // Token : 0x600085A
    // RVA   : 0x10F76F0   Offset: 0x10F5EF0   Length: 0x552
    public int GetCharacterIndex(int currentIndex, KeyCode key)
    {
        var pStatics = *(int64*)(DAT_181d8ab58 + 184);
        int iVar1;
        ulong uVar2;
        ulong uVar3;
        long lVar4;
        bool cVar5;
        int iVar6;
        int iVar7;
        long lVar8;
        uint uVar10;
        float fVar11;
        float fVar12;
        float fVar13;
        ulong local_48;
        cVar5 = UILabel.get_isValid(this,0);
        if (cVar5) {
          lVar8 = UILabel.get_processedText(this,0);
          cVar5 = FUN_180d6ca90(lVar8,0);
          if (!cVar5) {
            iVar6 = UILabel.get_defaultFontSize(this,0);
            UILabel.UpdateNGUIText(this,0);
            uVar2 = *(uint64 *)(pStatics + 32);
            uVar3 = *(uint64 *)(pStatics + 40);
            NGUIText.PrintApproximateCharacterPositions(lVar8,uVar2,uVar3,0);
            lVar4 = *(int64 *)(pStatics + 32);
            if (lVar4 == null) goto LAB_1810f7c3d;
            if (0 < *(int *)(lVar4 + 24)) {
              UILabel.ApplyOffset
                        (this,*(uint64 *)(pStatics + 32),0,0);
              uVar10 = 0;
              lVar4 = *(int64 *)(pStatics + 40);
              if (lVar4 == null) goto LAB_1810f7c3d;
              iVar1 = *(int *)(lVar4 + 24);
              if (0 < iVar1) {
                do {
                  lVar4 = *(int64 *)(pStatics + 40);
                  if (lVar4 == null) goto LAB_1810f7c3d;
                  iVar7 = FUN_1800d6750(lVar4,uVar10,DAT_181d68270);
                  if (iVar7 == currentIndex) {
                    lVar4 = *(int64 *)(pStatics + 32);
                    if (lVar4 == null) goto LAB_1810f7c3d;
                    if (*(uint32 *)(lVar4 + 24) <= uVar10) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    uVar2 = *(uint64 *)
                             (*(int64 *)(lVar4 + 16) + 32 + (int64)(int)uVar10 * 12);
                    fVar12 = (float)uVar2;
                    fVar13 = (float)((uint64)uVar2 >> 32);
                    if (key == 0x111) {
                      if (!this.mUseFloatSpacing) {
                        fVar11 = (float)this.mSpacingY;
                      }
                      else {
                        fVar11 = this.mFloatSpacingY;
                      }
                      fVar13 = (float)iVar6 + fVar11 + fVar13;
                    }
                    else if (key == 0x112) {
                      if (!this.mUseFloatSpacing) {
                        fVar11 = (float)this.mSpacingY;
                      }
                      else {
                        fVar11 = this.mFloatSpacingY;
                      }
                      fVar13 = fVar13 - ((float)iVar6 + fVar11);
                    }
                    else if (key == 0x116) {
                      fVar12 = fVar12 - 1000.0;
                    }
                    else if (key == 0x117) {
                      fVar12 = fVar12 + 1000.0;
                    }
                    uVar2 = *(uint64 *)(pStatics + 32);
                    uVar3 = *(uint64 *)(pStatics + 40);
                    local_48 = CONCAT44(fVar13,fVar12);
                    iVar6 = NGUIText.GetApproximateCharacterIndex(uVar2,uVar3,local_48,0);
                    if (iVar6 != currentIndex) {
                      lVar8 = *(int64 *)(pStatics + 32);
                      if (lVar8 != null) {
                        FUN_180f56130(lVar8,DAT_181d84378);
                        lVar8 = *(int64 *)(pStatics + 40);
                        if (lVar8 != null) {
                          FUN_180f56130(lVar8,DAT_181d67b78);
                          return iVar6;
                        }
                      }
                      goto LAB_1810f7c3d;
                    }
                    break;
                  }
                  uVar10 = uVar10 + 1;
                } while ((int)uVar10 < iVar1);
              }
              lVar4 = *(int64 *)(pStatics + 32);
              if (lVar4 == null) goto LAB_1810f7c3d;
              FUN_180f56130(lVar4,DAT_181d84378);
              lVar4 = *(int64 *)(pStatics + 40);
              if (lVar4 == null) goto LAB_1810f7c3d;
              FUN_180f56130(lVar4,DAT_181d67b78);
            }
            puVar9 = *(uint64 **)(DAT_181d66a70 + 184);
            *puVar9 = 0;
            il2cpp_internal(puVar9,0);
            puVar9 = (uint64 *)(*(int64 *)(DAT_181d66a70 + 184) + 8);
            *puVar9 = 0;
            il2cpp_internal(puVar9,0);
            if ((key != 0x111) && (key != 0x116)) {
              if ((key != 0x112) && (key != 0x117)) {
                return currentIndex;
              }
              if (lVar8 != null) {
                return *(int *)(lVar8 + 16);
              }
        LAB_1810f7c3d:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
          }
          currentIndex = 0;
        }
        return currentIndex;
    }

    // Token : 0x600085B
    // RVA   : 0x10F9420   Offset: 0x10F7C20   Length: 0x3D5
    public void PrintOverlay(int start, int end, UIGeometry caret, UIGeometry highlight, Color caretColor, Color highlightColor)
    {
        void UILabel.PrintOverlay
                     (int64 this,int start,int end,int64 caret,int64 highlight,
                     uint32 *caretColor,uint32 *highlightColor)
        {
        float fVar1;
        int iVar2;
        int64 lVar3;
        char cVar4;
        uint64 *puVar5;
        int iVar6;
        int iVar7;
        int64 lVar8;
        uint64 uVar9;
        uint64 local_88;
        uint32 uStack_80;
        uint32 uStack_7c;
        uint64 local_78;
        uint64 uStack_70;
        uint64 local_68;
        uint64 uStack_60;
        uint32 uVar10;
        local_68 = 0;
        uStack_60 = 0;
        local_78 = 0;
        uStack_70 = 0;
        if (caret != null) {
          UIGeometry.Clear(caret,0);
        }
        if (highlight != null) {
          UIGeometry.Clear(highlight,0);
        }
        cVar4 = UILabel.get_isValid(this,0);
        if (cVar4) {
          local_88 = UILabel.get_processedText(this,0);
          UILabel.UpdateNGUIText(this,0);
          if ((caret == null) || (lVar3 = *(int64 *)(caret + 16)) == null) goto LAB_1810f97f0;
          iVar7 = *(int *)(lVar3 + 24);
          fVar1 = *(float *)(this + 140);
          if ((highlight == null) || (start == end)) {
            uVar10 = 0;
            NGUIText.PrintCaretAndSelection(local_88,start,end,lVar3,0,0);
          }
          else {
            lVar8 = *(int64 *)(highlight + 16);
            if (lVar8 == null) goto LAB_1810f97f0;
            iVar6 = *(int *)(lVar8 + 24);
            NGUIText.PrintCaretAndSelection(local_88,start,end,lVar3,lVar8,0);
            uVar10 = (uint32)((uint64)lVar8 >> 32);
            lVar3 = *(int64 *)(highlight + 16);
            if (lVar3 == null) goto LAB_1810f97f0;
            if (iVar6 < *(int *)(lVar3 + 24)) {
              UILabel.ApplyOffset(this,lVar3,iVar6,0);
              uVar9 = CONCAT44(uVar10,(float)highlightColor[3] * fVar1);
              FUN_1809981e0(&local_78,*highlightColor,highlightColor[1],highlightColor[2],uVar9,0);
              uVar10 = (uint32)((uint64)uVar9 >> 32);
              if (*(int64 *)(highlight + 16) == 0) goto LAB_1810f97f0;
              iVar2 = *(int *)(*(int64 *)(highlight + 16) + 24);
              for (; iVar6 < iVar2; iVar6 = iVar6 + 1) {
                if (*(int64 *)(highlight + 24) == 0) goto LAB_1810f97f0;
                FUN_181814e80(*(int64 *)(highlight + 24),0x3f0000003f000000,DAT_181d83f78);
                if (*(int64 *)(highlight + 32) == 0) goto LAB_1810f97f0;
                local_88 = local_78;
                uStack_80 = (uint32)uStack_70;
                uStack_7c = uStack_70._4_4_;
                FUN_1818059b0(*(int64 *)(highlight + 32),&local_88,DAT_181d5b680);
                uVar10 = (uint32)((uint64)uVar9 >> 32);
              }
            }
          }
          UILabel.ApplyOffset(this,*(uint64 *)(caret + 16),iVar7,0);
          FUN_1809981e0(&local_68,*caretColor,caretColor[1],caretColor[2],
                        CONCAT44(uVar10,(float)caretColor[3] * fVar1),0);
          if (*(int64 *)(caret + 16) == 0) {
        LAB_1810f97f0:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          iVar6 = *(int *)(*(int64 *)(caret + 16) + 24);
          for (; iVar7 < iVar6; iVar7 = iVar7 + 1) {
            if (*(int64 *)(caret + 24) == 0) goto LAB_1810f97f0;
            FUN_181814e80(*(int64 *)(caret + 24),0x3f0000003f000000,DAT_181d83f78);
            if (*(int64 *)(caret + 32) == 0) goto LAB_1810f97f0;
            local_88 = local_68;
            uStack_80 = (uint32)uStack_60;
            uStack_7c = uStack_60._4_4_;
            FUN_1818059b0(*(int64 *)(caret + 32),&local_88,DAT_181d5b680);
          }
          puVar5 = *(uint64 **)(DAT_181d66a70 + 184);
          *puVar5 = 0;
          il2cpp_internal(puVar5,0);
          puVar5 = (uint64 *)(*(int64 *)(DAT_181d66a70 + 184) + 8);
          *puVar5 = 0;
          il2cpp_internal(puVar5,0);
        }
    }

    // Token : 0x600085C
    // RVA   : 0x10FC3F0   Offset: 0x10FABF0   Length: 0x78
    private bool get_premultipliedAlphaShader()
    {
        long lVar1;
        lVar1 = il2cpp_internal(this.mFont,DAT_181d556d0);
        if (lVar1 == null) {
          return;
        }
        FUN_180002970(14,DAT_181d556d0,lVar1);
    }

    // Token : 0x600085D
    // RVA   : 0x10FC370   Offset: 0x10FAB70   Length: 0x78
    private bool get_packedFontShader()
    {
        long lVar1;
        lVar1 = il2cpp_internal(this.mFont,DAT_181d556d0);
        if (lVar1 == null) {
          return;
        }
        FUN_180002970(15,DAT_181d556d0,lVar1);
    }

    // Token : 0x600085E
    // RVA   : 0x10F87B0   Offset: 0x10F6FB0   Length: 0x50B
    public override void OnFill(List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
    {
        var pStatics = *(int64*)(DAT_181d66a70 + 184);
        uint uVar1;
        uint uVar2;
        bool cVar3;
        ulong uVar5;
        long lVar6;
        uint uVar8;
        long lVar9;
        uint uVar10;
        uint uVar11;
        uint uVar12;
        uint uVar13;
        uint uVar14;
        uint uVar15;
        uint uVar16;
        ulong in_stack_ffffffffffffff40;
        uint uVar17;
        ulong in_stack_ffffffffffffff48;
        uint uVar19;
        ulong uVar18;
        uint local_98;
        uint uStack_94;
        uint uStack_90;
        uint32 uStack_8c;
        uint8 local_88 [96];
        uVar17 = (uint32)((uint64)in_stack_ffffffffffffff40 >> 32);
        uVar19 = (uint32)((uint64)in_stack_ffffffffffffff48 >> 32);
        cVar3 = UILabel.get_isValid(this,0);
        if (cVar3) {
          if (verts == null) {
        LAB_1810f8cb6:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          local_98 = *(uint32 *)(this + 144);
          uStack_94 = *(uint32 *)(this + 148);
          uStack_90 = *(uint32 *)(this + 152);
          uVar10 = *(uint32 *)(verts + 24);
          uStack_8c = *(uint32 *)(this + 140);
          cVar3 = UILabel.get_premultipliedAlphaShader(this,0);
          uVar11 = local_98;
          uVar12 = uStack_94;
          uVar13 = uStack_90;
          uVar14 = uStack_8c;
          if (cVar3) {
            puVar4 = (uint32 *)NGUITools.ApplyPMA(local_88,&local_98,0);
            uVar11 = *puVar4;
            uVar12 = puVar4[1];
            uVar13 = puVar4[2];
            uVar14 = puVar4[3];
          }
          uVar5 = UILabel.get_processedText(this,0);
          uVar2 = *(uint32 *)(verts + 24);
          UILabel.UpdateNGUIText(this,0);
          lVar6 = pStatics;
          uVar8 = 0;
          uVar16 = 0;
          *(uint32 *)(lVar6 + 44) = uVar11;
          *(uint32 *)(lVar6 + 48) = uVar12;
          *(uint32 *)(lVar6 + 52) = uVar13;
          *(uint32 *)(lVar6 + 56) = uVar14;
          NGUIText.Print(uVar5,verts,uvs,cols,0);
          puVar7 = *(uint64 **)(DAT_181d66a70 + 184);
          *puVar7 = 0;
          il2cpp_internal(puVar7,0);
          puVar7 = (uint64 *)(pStatics + 8);
          *puVar7 = 0;
          il2cpp_internal(puVar7,0);
          UILabel.ApplyOffset(this,verts,uVar2,0);
          cVar3 = UILabel.get_packedFontShader(this,0);
          if (!cVar3) {
            if (this.mEffectStyle != null) {
              uVar12 = *(uint32 *)(verts + 24);
              uVar11 = this.mEffectDistance;
              uVar1 = *(uint32 *)(this + 0x1d8);
              uVar15 = uVar1 ^ 0x80000000;
              uVar5 = CONCAT44(uVar19,uVar11);
              UILabel.ApplyShadow
                        (this,verts,uvs,cols,CONCAT44(uVar16,uVar10),CONCAT44(uVar17,uVar12),
                         uVar5,uVar15,0);
              if (this.mEffectStyle - 2U < 2) {
                uVar17 = *(uint32 *)(verts + 24);
                uVar18 = CONCAT44((int)((uint64)uVar5 >> 32),uVar11) ^ 0x80000000;
                UILabel.ApplyShadow(this,verts,uvs,cols,uVar12,uVar17,uVar18,uVar1,0);
                uVar10 = *(uint32 *)(verts + 24);
                uVar5 = CONCAT44((int)(uVar18 >> 32),uVar11);
                UILabel.ApplyShadow(this,verts,uvs,cols,uVar17,uVar10,uVar5,uVar1,0);
                uVar17 = *(uint32 *)(verts + 24);
                uVar18 = CONCAT44((int)((uint64)uVar5 >> 32),uVar11) ^ 0x80000000;
                UILabel.ApplyShadow(this,verts,uvs,cols,uVar10,uVar17,uVar18,uVar15,0);
                if (this.mEffectStyle == 3) {
                  uVar19 = *(uint32 *)(verts + 24);
                  uVar18 = CONCAT44((int)(uVar18 >> 32),uVar11) ^ 0x80000000;
                  UILabel.ApplyShadow(this,verts,uvs,cols,uVar17,uVar19,uVar18,0,0);
                  uVar17 = *(uint32 *)(verts + 24);
                  uVar18 = CONCAT44((int)(uVar18 >> 32),uVar11);
                  UILabel.ApplyShadow(this,verts,uvs,cols,uVar19,uVar17,uVar18,0,0);
                  uVar10 = *(uint32 *)(verts + 24);
                  uVar18 = uVar18 & 0xffffffff00000000;
                  UILabel.ApplyShadow(this,verts,uvs,cols,uVar17,uVar10,uVar18,uVar1,0);
                  UILabel.ApplyShadow
                            (this,verts,uvs,cols,uVar10,*(uint32 *)(verts + 24),
                             uVar18 & 0xffffffff00000000,uVar15,0);
                }
              }
            }
            if (*(int *)(pStatics + 132) == 3) {
              if (cols == null) goto LAB_1810f8cb6;
              lVar6 = (int64)*(int *)(cols + 24);
              if (0 < *(int *)(cols + 24)) {
                lVar9 = 32;
                do {
                  if (*(uint32 *)(cols + 24) <= uVar8) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  if (*(float *)(*(int64 *)(cols + 16) + lVar9) == -1.0) {
                    puVar4 = (uint32 *)FUN_181098a50(local_88,0);
                    local_98 = *puVar4;
                    uStack_94 = puVar4[1];
                    uStack_90 = puVar4[2];
                    uStack_8c = puVar4[3];
                    FUN_181814c20(cols,uVar8,&local_98,DAT_181d5b880);
                  }
                  uVar8 = uVar8 + 1;
                  lVar9 = lVar9 + 16;
                  lVar6 = lVar6 + -1;
                } while (lVar6 != null);
              }
            }
            if (*(int64 *)(this + 192) != 0) {
              OnPostFillCallback.Invoke
                        (*(int64 *)(this + 192),this,uVar10,verts,uvs,cols,0);
            }
          }
        }
    }

    // Token : 0x600085F
    // RVA   : 0x10F6A90   Offset: 0x10F5290   Length: 0x1C3
    public Vector2 ApplyOffset(List<Vector3> verts, int start)
    {
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        long lVar4;
        float fVar5;
        float fVar6;
        ulong local_58;
        uint local_50;
        ulong local_48;
        uVar2 = (uint64)start;
        UIWidget.get_pivotOffset(this,0);
        Mathf.Lerp();
        Mathf.Lerp();
        Mathf.Lerp(*(float *)(this + 0x260) - (float)*(int *)(this + 168));
        fVar5 = (float)FUN_18000d7c0();
        fVar6 = (float)FUN_18000d7c0();
        if (verts == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (start < *(int *)(verts + 24)) {
          lVar4 = uVar2 * 12;
          lVar3 = (int64)*(int *)(verts + 24) - uVar2;
          do {
            if (*(uint32 *)(verts + 24) <= (uint32)uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar1 = *(uint64 *)(*(int64 *)(verts + 16) + 32 + lVar4);
            local_50 = *(uint32 *)(*(int64 *)(verts + 16) + 40 + lVar4);
            local_48._4_4_ = (float)((uint64)uVar1 >> 32);
            local_58 = CONCAT44(local_48._4_4_ + fVar6,(float)uVar1 + fVar5);
            local_48 = uVar1;
            FUN_181814c90(verts,uVar2 & 0xffffffff,&local_58,DAT_181d844f8);
            uVar2 = (uint64)((uint32)uVar2 + 1);
            lVar4 = lVar4 + 12;
            lVar3 = lVar3 + -1;
          } while (lVar3 != null);
        }
        return CONCAT44(fVar6,fVar5);
    }

    // Token : 0x6000860
    // RVA   : 0x10F6C60   Offset: 0x10F5460   Length: 0x375
    public void ApplyShadow(List<Vector3> verts, List<Vector2> uvs, List<Color> cols, int start, int end, float x, float y)
    {
        void UILabel.ApplyShadow
                     (int64 this,int64 verts,int64 uvs,int64 cols,int start,
                     int end,float x,float y)
        {
        uint32 *puVar1;
        uint64 uVar2;
        uint32 uVar3;
        float fVar4;
        char cVar5;
        uint64 *puVar6;
        uint32 uVar7;
        uint64 uVar8;
        int64 lVar9;
        int64 lVar10;
        int64 lVar11;
        uint32 uVar12;
        uint32 uVar13;
        float fVar14;
        uint64 local_b8;
        uint32 local_b0;
        uint64 local_a8;
        uint32 local_a0;
        uint64 local_98;
        uint32 uStack_90;
        float fStack_8c;
        uint32 local_88;
        uint32 uStack_84;
        uint32 uStack_80;
        float fStack_7c;
        local_98 = this.mEffectColor;
        uStack_90 = *(uint32 *)(this + 0x1c8);
        fVar14 = *(float *)(this + 0x1cc) * *(float *)(this + 140);
        fStack_8c = fVar14;
        cVar5 = UILabel.get_premultipliedAlphaShader(this,0);
        if (!cVar5) {
          uVar12 = (uint32)local_98;
          uVar13 = local_98._4_4_;
        }
        else {
          puVar6 = (uint64 *)NGUITools.ApplyPMA(&local_88,&local_98,0);
          local_98 = *puVar6;
          uStack_90 = *(uint32 *)(puVar6 + 1);
          fVar14 = *(float *)((int64)puVar6 + 12);
          uVar12 = *(uint32 *)puVar6;
          uVar13 = *(uint32 *)((int64)puVar6 + 4);
          fStack_8c = fVar14;
        }
        fVar4 = fStack_8c;
        uVar3 = uStack_90;
        uVar8 = (uint64)start;
        if (start < end) {
          lVar11 = uVar8 * 8 + 32;
          lVar10 = uVar8 * 12;
          lVar9 = (uVar8 + 2) * 16;
          do {
            if (verts == null) {
        LAB_1810f6fd0:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar7 = (uint32)uVar8;
            if (*(uint32 *)(verts + 24) <= uVar7) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            local_b8 = *(uint64 *)(lVar10 + 32 + *(int64 *)(verts + 16));
            local_b0 = *(uint32 *)(lVar10 + 40 + *(int64 *)(verts + 16));
            FUN_181805a40(verts,&local_b8,DAT_181d84278);
            if (uvs == null) goto LAB_1810f6fd0;
            if (*(uint32 *)(uvs + 24) <= uVar7) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            FUN_181814e80(uvs,CONCAT44(*(uint32 *)(*(int64 *)(uvs + 16) + 4 + lVar11),
                                           *(uint32 *)(*(int64 *)(uvs + 16) + lVar11)),
                          DAT_181d83f78);
            if (cols == null) goto LAB_1810f6fd0;
            if (*(uint32 *)(cols + 24) <= uVar7) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            puVar1 = (uint32 *)(*(int64 *)(cols + 16) + lVar9);
            local_88 = *puVar1;
            uStack_84 = puVar1[1];
            uStack_80 = puVar1[2];
            fStack_7c = (float)puVar1[3];
            FUN_1818059b0(cols,&local_88,DAT_181d5b680);
            if (*(uint32 *)(verts + 24) <= uVar7) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar2 = *(uint64 *)(lVar10 + 32 + *(int64 *)(verts + 16));
            local_a0 = *(uint32 *)(lVar10 + 40 + *(int64 *)(verts + 16));
            local_98._4_4_ = (float)((uint64)uVar2 >> 32);
            local_a8 = CONCAT44(local_98._4_4_ + y,(float)uVar2 + x);
            local_98 = uVar2;
            FUN_181814c90(verts,uVar8 & 0xffffffff,&local_a8,DAT_181d844f8);
            if (*(uint32 *)(cols + 24) <= uVar7) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            fStack_7c = fVar4;
            if (*(float *)(*(int64 *)(cols + 16) + 12 + lVar9) != 1.0) {
              fStack_7c = fVar14 * *(float *)(*(int64 *)(cols + 16) + 12 + lVar9);
            }
            local_88 = uVar12;
            uStack_84 = uVar13;
            uStack_80 = uVar3;
            FUN_181814c20(cols,uVar8 & 0xffffffff,&local_88,DAT_181d5b880);
            uVar8 = (uint64)(uVar7 + 1);
            lVar11 = lVar11 + 8;
            lVar9 = lVar9 + 16;
            lVar10 = lVar10 + 12;
          } while ((int)(uVar7 + 1) < end);
        }
    }

    // Token : 0x6000861
    // RVA   : 0x10F70E0   Offset: 0x10F58E0   Length: 0xD6
    public int CalculateOffsetToFit(string text)
    {
        var pStatics = *(int64*)(DAT_181d66a70 + 184);
        uint uVar1;
        UILabel.UpdateNGUIText(this,0);
        *(uint8 *)(pStatics + 116) = 0;
        *(uint32 *)(pStatics + 132) = 0;
        uVar1 = NGUIText.CalculateOffsetToFit(text,0);
        puVar2 = *(uint64 **)(DAT_181d66a70 + 184);
        *puVar2 = 0;
        il2cpp_internal(puVar2,0);
        puVar2 = (uint64 *)(pStatics + 8);
        *puVar2 = 0;
        il2cpp_internal(puVar2,0);
        return uVar1;
    }

    // Token : 0x6000862
    // RVA   : 0x10FA840   Offset: 0x10F9040   Length: 0xD6
    public void SetCurrentProgress()
    {
        var pStatics = *(int64*)(DAT_181d8ae58 + 184);
        bool cVar1;
        ulong uVar2;
        uint[] local_res18 = new uint[4];
        uVar2 = **(uint64 **)(DAT_181d8ae58 + 184);
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (cVar1) {
          if (*pStatics == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          local_res18[0] = UIProgressBar.get_value(*pStatics,0);
          uVar2 = Single.ToString(local_res18,"F",0);
          UILabel.set_text(this,uVar2,0);
        }
    }

    // Token : 0x6000863
    // RVA   : 0x10FA750   Offset: 0x10F8F50   Length: 0xED
    public void SetCurrentPercent()
    {
        var pStatics = *(int64*)(DAT_181d8ae58 + 184);
        bool cVar1;
        ulong uVar2;
        float fVar3;
        uint[] local_res18 = new uint[4];
        uVar2 = **(uint64 **)(DAT_181d8ae58 + 184);
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (cVar1) {
          if (*pStatics == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          fVar3 = (float)UIProgressBar.get_value(*pStatics,0);
          local_res18[0] = Mathf.RoundToInt(fVar3 * 100.0,0);
          uVar2 = Int32.ToString(local_res18,0);
          uVar2 = String.Concat(uVar2,"%",0);
          UILabel.set_text(this,uVar2,0);
        }
    }

    // Token : 0x6000864
    // RVA   : 0x10FA920   Offset: 0x10F9120   Length: 0x1B8
    public void SetCurrentSelection()
    {
        var pStatics = *(int64*)(DAT_181d8add8 + 184);
        bool cVar2;
        ulong uVar3;
        uVar3 = **(uint64 **)(DAT_181d8add8 + 184);
        cVar2 = Object.op_Inequality(uVar3,0,0);
        if (!cVar2) {
          return;
        }
        if (*pStatics != 0) {
          if (*(char *)(*pStatics + 185) == false) {
            plVar1 = (int64 *)*pStatics;
            if (plVar1 == (int64 *)0) throw; // [null/range check failed]
            uVar3 = (**(code **)(*plVar1 + 0x178))(plVar1,*(uint64 *)(*plVar1 + 0x180));
          }
          else {
            plVar1 = (int64 *)*pStatics;
            if (plVar1 == (int64 *)0) throw; // [null/range check failed]
            uVar3 = (**(code **)(*plVar1 + 0x178))(plVar1,*(uint64 *)(*plVar1 + 0x180));
            uVar3 = Localization.Get(uVar3,1,0);
          }
          if (this != 0) {
            UILabel.set_text(this,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x6000865
    // RVA   : 0x10FB600   Offset: 0x10F9E00   Length: 0xE6
    public bool Wrap(string text, ref string final)
    {
        var pStatics = *(int64*)(DAT_181d66a70 + 184);
        uint8
        UILabel.Wrap(uint64 this,uint64 text,uint64 final,uint32 param_4)
        {
        uint8 uVar1;
        uint64 *puVar2;
        UILabel.UpdateNGUIText(this,0);
        *(uint32 *)(pStatics + 64) = param_4;
        *(uint32 *)(pStatics + 72) = param_4;
        uVar1 = NGUIText.WrapText(text,final,0,0);
        puVar2 = *(uint64 **)(DAT_181d66a70 + 184);
        *puVar2 = 0;
        il2cpp_internal(puVar2,0);
        puVar2 = (uint64 *)(pStatics + 8);
        *puVar2 = 0;
        il2cpp_internal(puVar2,0);
        return uVar1;
    }

    // Token : 0x6000866
    // RVA   : 0x10FB510   Offset: 0x10F9D10   Length: 0xEB
    public bool Wrap(string text, ref string final, int height)
    {
        var pStatics = *(int64*)(DAT_181d66a70 + 184);
        uint8
        UILabel.Wrap(uint64 this,uint64 text,uint64 final,uint32 height)
        {
        uint8 uVar1;
        uint64 *puVar2;
        UILabel.UpdateNGUIText(this,0);
        *(uint32 *)(pStatics + 64) = height;
        *(uint32 *)(pStatics + 72) = height;
        uVar1 = NGUIText.WrapText(text,final,0,0);
        puVar2 = *(uint64 **)(DAT_181d66a70 + 184);
        *puVar2 = 0;
        il2cpp_internal(puVar2,0);
        puVar2 = (uint64 *)(pStatics + 8);
        *puVar2 = 0;
        il2cpp_internal(puVar2,0);
        return uVar1;
    }

    // Token : 0x6000867
    // RVA   : 0x10FAAE0   Offset: 0x10F92E0   Length: 0x861
    public void UpdateNGUIText()
    {
        var pStatics = *(int64*)(DAT_181d66a70 + 184);
        int iVar1;
        ulong uVar2;
        bool cVar3;
        bool cVar4;
        uint uVar5;
        int iVar6;
        ulong uVar7;
        long lVar8;
        float fVar12;
        uVar7 = UILabel.get_trueTypeFont(this,0);
        cVar3 = Object.op_Inequality(uVar7,0,0);
        uVar5 = this.mFinalFontSize;
        *(uint32 *)(pStatics + 24) = uVar5;
        *(uint32 *)(pStatics + 36) = this.mFontStyle;
        *(uint32 *)(pStatics + 60) = *(uint32 *)(this + 164);
        *(uint32 *)(pStatics + 64) = *(uint32 *)(this + 168);
        uVar5 = Mathf.RoundToInt((*(float *)(this + 0x104) - *(float *)(this + 252)) *
                                  (float)*(int *)(this + 164),0);
        *(uint32 *)(pStatics + 68) = uVar5;
        uVar5 = Mathf.RoundToInt((*(float *)(this + 0x108) - *(float *)(this + 0x100)) *
                                  (float)*(int *)(this + 168),0);
        *(uint32 *)(pStatics + 72) = uVar5;
        if (!this.mApplyGradient) {
          bVar11 = false;
        }
        else {
          cVar4 = UILabel.get_packedFontShader(this,0);
          bVar11 = !cVar4;
        }
        *(bool *)(pStatics + 80) = bVar11;
        uVar2 = *(uint64 *)(this + 0x1ec);
        lVar8 = pStatics;
        *(uint64 *)(lVar8 + 100) = this.mGradientTop;
        *(uint64 *)(lVar8 + 108) = uVar2;
        uVar2 = *(uint64 *)(this + 0x1fc);
        lVar8 = pStatics;
        *(uint64 *)(lVar8 + 84) = *(uint64 *)(this + 500);
        *(uint64 *)(lVar8 + 92) = uVar2;
        *(uint8 *)(pStatics + 116) = this.mEncoding;
        *(uint8 *)(pStatics + 128) = *(uint8 *)(this + 600);
        *(uint32 *)(pStatics + 132) = this.mSymbols;
        *(uint32 *)(pStatics + 76) = this.mMaxLineCount;
        if (!this.mUseFloatSpacing) {
          fVar12 = (float)this.mSpacingX;
        }
        else {
          fVar12 = this.mFloatSpacingX;
        }
        *(float *)(pStatics + 120) = fVar12;
        if (!this.mUseFloatSpacing) {
          fVar12 = (float)this.mSpacingY;
        }
        else {
          fVar12 = this.mFloatSpacingY;
        }
        bVar11 = !DAT_181e7c338;
        *(float *)(pStatics + 124) = fVar12;
        if (bVar11) {
          il2cpp_runtime_class_init(&DAT_181d556d0);
          DAT_181e7c338 = true;
        }
        lVar8 = il2cpp_internal(this.mFont,DAT_181d556d0);
        if (!cVar3) {
          if (lVar8 == null) {
            uVar5 = this.mScale;
            *(uint32 *)(pStatics + 28) = uVar5;
            goto LAB_1810fae25;
          }
          lVar8 = FUN_180002970(27,DAT_181d556d0,lVar8);
          iVar1 = this.mFontSize;
          if (lVar8 == null) goto LAB_1810fb33c;
          iVar6 = FUN_180002970(22,DAT_181d556d0,lVar8);
          fVar12 = this.mScale;
          *(float *)(pStatics + 28) = ((float)iVar1 / (float)iVar6) * fVar12;
        LAB_1810fb008:
          cVar4 = Object.op_Inequality(uVar7,0,0);
          if (cVar4) goto LAB_1810fae25;
          puVar9 = (uint64 *)(pStatics + 8);
          *puVar9 = 0;
          il2cpp_internal(puVar9,0);
          plVar10 = pStatics;
          *plVar10 = lVar8;
        }
        else {
          uVar5 = this.mScale;
          *(uint32 *)(pStatics + 28) = uVar5;
          if (lVar8 != null) goto LAB_1810fb008;
        LAB_1810fae25:
          puVar9 = (uint64 *)(pStatics + 8);
          *puVar9 = uVar7;
          il2cpp_internal(puVar9,uVar7);
          plVar10 = pStatics;
          *plVar10 = 0;
          lVar8 = 0;
        }
        il2cpp_internal(plVar10,lVar8);
        if ((!cVar3) || (cVar3 = UILabel.get_keepCrisp(this,0), !cVar3)) {
          *(uint32 *)(pStatics + 32) = 0x3f800000;
        }
        else {
          lVar8 = UIRect.get_root(this,0);
          cVar3 = Object.op_Inequality(lVar8,0,0);
          if (cVar3) {
            cVar3 = Object.op_Inequality(lVar8,0,0);
            if (!cVar3) {
              uVar5 = 0x3f800000;
            }
            else {
              if (lVar8 == null) {
        LAB_1810fb33c:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar5 = UIRoot.get_pixelSizeAdjustment(lVar8,0);
            }
            *(uint32 *)(pStatics + 32) = uVar5;
          }
        }
        fVar12 = this.mDensity;
        if (fVar12 != *(float *)(pStatics + 32)) {
          UILabel.ProcessText(this,0,0,0);
          uVar5 = *(uint32 *)(this + 164);
          *(uint32 *)(pStatics + 60) = uVar5;
          *(uint32 *)(pStatics + 64) = *(uint32 *)(this + 168);
          uVar5 = Mathf.RoundToInt((*(float *)(this + 0x104) - *(float *)(this + 252)) *
                                    (float)*(int *)(this + 164),0);
          *(uint32 *)(pStatics + 68) = uVar5;
          uVar5 = Mathf.RoundToInt((*(float *)(this + 0x108) - *(float *)(this + 0x100)) *
                                    (float)*(int *)(this + 168),0);
          *(uint32 *)(pStatics + 72) = uVar5;
        }
        iVar1 = this.mAlignment;
        if (iVar1 == 0) {
          iVar1 = *(int *)(this + 160);
          if (((iVar1 == 3) || (iVar1 == 0)) || (iVar1 == 6)) {
            *(uint32 *)(pStatics + 40) = 1;
          }
          else if (((iVar1 == 5) || (iVar1 == 2)) || (iVar1 == 8)) {
            *(uint32 *)(pStatics + 40) = 3;
          }
          else {
            *(uint32 *)(pStatics + 40) = 2;
          }
        }
        else {
          *(int *)(pStatics + 40) = iVar1;
        }
        NGUIText.Update(0);
    }

    // Token : 0x6000868
    // RVA   : 0x10F8590   Offset: 0x10F6D90   Length: 0x87
    private void OnApplicationPause(bool paused)
    {
        long lVar1;
        bool cVar2;
        if (!paused) {
          lVar1 = this[50];
          cVar2 = Object.op_Inequality(lVar1,0,0);
          if (cVar2) {
            (**(code **)(*this + 0x1f8))(this,0,*(uint64 *)(*this + 0x200));
          }
        }
    }

    // Token : 0x6000869
    // RVA   : 0x10FB880   Offset: 0x10FA080   Length: 0x143
    public void /*ctor*/()
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        uint uVar4;
        ulong uVar6;
        uint local_res8;
        uint32 uStackX_c;
        uint64 local_28;
        uint64 uStack_20;
        uint8 local_18 [16];
        this.keepCrispWhenShrunk = 1;
        this.mText = "";
        this.mFontSize = 16;
        this.mEncoding = 1;
        puVar5 = (uint32 *)Color.get_black(local_18,0);
        uVar1 = *puVar5;
        uVar2 = puVar5[1];
        uVar3 = puVar5[2];
        uVar4 = puVar5[3];
        this.mSymbols = 1;
        this.mEffectColor = uVar1;
        *(uint32 *)(this + 0x1c4) = uVar2;
        *(uint32 *)(this + 0x1c8) = uVar3;
        *(uint32 *)(this + 0x1cc) = uVar4;
        uVar6 = Vector2.get_one(0);
        local_res8 = (uint32)uVar6;
        uStackX_c = (uint32)((uint64)uVar6 >> 32);
        this.mEffectDistance = local_res8;
        *(uint32 *)(this + 0x1d8) = uStackX_c;
        puVar5 = (uint32 *)FUN_181098a50(local_18,0);
        uVar1 = puVar5[1];
        uVar2 = puVar5[2];
        uVar3 = puVar5[3];
        local_28 = 0;
        uStack_20 = 0;
        this.mGradientTop = *puVar5;
        *(uint32 *)(this + 0x1e8) = uVar1;
        *(uint32 *)(this + 0x1ec) = uVar2;
        *(uint32 *)(this + 0x1f0) = uVar3;
        Color.ctor(&local_28,0x3f333333,0x3f333333,0x3f333333,0);
        this.mMultiline = 1;
        this.mDensity = 0x3f800000;
        *(uint32 *)(this + 500) = (uint32)local_28;
        *(uint32 *)(this + 0x1f8) = local_28._4_4_;
        *(uint32 *)(this + 0x1fc) = (uint32)uStack_20;
        *(uint32 *)(this + 0x200) = uStack_20._4_4_;
        this.mShouldBeProcessed = 1;
        uVar6 = Vector2.get_zero(0);
        local_res8 = (uint32)uVar6;
        uStackX_c = (uint32)((uint64)uVar6 >> 32);
        this.mCalculatedSize = local_res8;
        *(uint32 *)(this + 0x260) = uStackX_c;
        this.mScale = 0x3f800000;
        UIWidget.ctor(this,0);
    }

    // Token : 0x600086A
    // RVA   : 0x10FB6F0   Offset: 0x10F9EF0   Length: 0x181
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d8ab58 + 184);
        ulong uVar1;
        uVar1 = new BetterList_1(DAT_181d81a18);
        puVar2 = *(uint64 **)(DAT_181d8ab58 + 184);
        *puVar2 = uVar1;
        il2cpp_internal(puVar2,uVar1);
        uVar1 = il2cpp_internal(DAT_181d5b848);
        FUN_1808ae540(uVar1,DAT_181d8feb0);
        puVar2 = (uint64 *)(pStatics + 8);
        *puVar2 = uVar1;
        il2cpp_internal(puVar2,uVar1);
        *(uint8 *)(pStatics + 24) = 0;
        uVar1 = il2cpp_internal(DAT_181d73eb0);
        FUN_180f58a90(uVar1,DAT_181d841f8);
        puVar2 = (uint64 *)(pStatics + 32);
        *puVar2 = uVar1;
        il2cpp_internal(puVar2,uVar1);
        uVar1 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(uVar1,DAT_181d678f8);
        puVar2 = (uint64 *)(pStatics + 40);
        *puVar2 = uVar1;
        il2cpp_internal(puVar2,uVar1);
    }

}
