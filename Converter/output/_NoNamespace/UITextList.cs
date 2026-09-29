// ============================================================
// Type  : UITextList
// Token : 0x2000118
// ============================================================

public class UITextList
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40006FF
    public UILabel textLabel;

    // Token: 0x4000700
    public UIProgressBar scrollBar;

    // Token: 0x4000701
    public Style style;

    // Token: 0x4000702
    public int paragraphHistory;

    // Token: 0x4000703
    protected char[] mSeparator;

    // Token: 0x4000704
    protected float mScroll;

    // Token: 0x4000705
    protected int mTotalLines;

    // Token: 0x4000706
    protected int mLastWidth;

    // Token: 0x4000707
    protected int mLastHeight;

    // Token: 0x4000708
    private BetterList<Paragraph> mParagraphs;

    // Token: 0x4000709
    private static Dictionary<string, BetterList<Paragraph>> mHistory;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000970
    // RVA   : 0xC04E10   Offset: 0xC04210   Length: 0x16A
    protected BetterList<Paragraph> get_paragraphs()
    {
        var pStatics = *(int64*)(DAT_181db0490 + 184);
        long lVar1;
        bool cVar2;
        ulong uVar3;
        if (this.mParagraphs == null) {
          lVar1 = *pStatics;
          uVar3 = Object.get_name(this,0);
          if (lVar1 == null) {
        LAB_180c04f75:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          cVar2 = FUN_1808b04c0(lVar1,uVar3,this + 72,DAT_181d718f8);
          if (!cVar2) {
            this.mParagraphs = new BetterList_1(DAT_181da7bd0);
            lVar1 = *pStatics;
            uVar3 = Object.get_name(this,0);
            if (lVar1 == null) goto LAB_180c04f75;
            FUN_1808ab370(lVar1,uVar3,this.mParagraphs,DAT_181d71870);
          }
        }
        return this.mParagraphs;
    }

    // Token : 0x6000971
    // RVA   : 0xC04DF0   Offset: 0xC041F0   Length: 0x1D
    public int get_paragraphCount()
    {
        long lVar1;
        lVar1 = UITextList.get_paragraphs(this,0);
        if (lVar1 != null) {
          return *(uint32 *)(lVar1 + 24);
        }
    }

    // Token : 0x6000972
    // RVA   : 0xC04C80   Offset: 0xC04080   Length: 0xB4
    public bool get_isValid()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.textLabel;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (!cVar2) {
          return;
        }
        if (this.textLabel != null) {
          uVar1 = UILabel.get_ambigiousFont(this.textLabel,0);
          Object.op_Inequality(uVar1,0,0);
          return;
        }
    }

    // Token : 0x6000973
    // RVA   : 0xC04FF0   Offset: 0xC043F0   Length: 0x6
    public float get_scrollValue()
    {
        uint32 FUN_180c04ff0(int64 this)
        {
        return this.mScroll;
    }

    // Token : 0x6000974
    // RVA   : 0xC05000   Offset: 0xC04400   Length: 0xCE
    public void set_scrollValue(float value)
    {
        ulong uVar1;
        bool cVar2;
        float fVar3;
        fVar3 = (float)Mathf.Clamp01(value,0);
        cVar2 = UITextList.get_isValid(this,0);
        if ((cVar2) && (this.mScroll != fVar3)) {
          uVar1 = this.scrollBar;
          cVar2 = Object.op_Inequality(uVar1,0,0);
          if (cVar2) {
            if (this.scrollBar == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            UISlider.set_sliderValue(this.scrollBar,fVar3,0);
            return;
          }
          this.mScroll = fVar3;
          UITextList.UpdateVisibleText(this,0);
        }
    }

    // Token : 0x6000975
    // RVA   : 0xC04D40   Offset: 0xC04140   Length: 0xA0
    protected float get_lineHeight()
    {
        int iVar1;
        ulong uVar2;
        long lVar3;
        bool cVar4;
        float fVar5;
        uVar2 = this.textLabel;
        cVar4 = Object.op_Inequality(uVar2,0,0);
        if (cVar4) {
          lVar3 = this.textLabel;
          if (lVar3 != null) {
            iVar1 = lVar3.mFontSize;
            fVar5 = (float)UILabel.get_effectiveSpacingY(lVar3,0);
            return fVar5 + (float)iVar1;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        return 20.0;
    }

    // Token : 0x6000976
    // RVA   : 0xC04F80   Offset: 0xC04380   Length: 0x6D
    protected int get_scrollHeight()
    {
        bool cVar1;
        int iVar2;
        ulong uVar3;
        float fVar4;
        cVar1 = UITextList.get_isValid(this,0);
        if (!cVar1) {
          return 0;
        }
        if (this.textLabel != null) {
          iVar2 = *(int *)(this.textLabel + 168);
          fVar4 = (float)UITextList.get_lineHeight(this,0);
          iVar2 = Mathf.FloorToInt((float)iVar2 / fVar4,0);
          uVar3 = Mathf.Max(0,this.mTotalLines - iVar2,0);
          return uVar3;
        }
    }

    // Token : 0x6000977
    // RVA   : 0xC040A0   Offset: 0xC034A0   Length: 0x57
    public void Clear()
    {
        long lVar1;
        lVar1 = UITextList.get_paragraphs(this,0);
        if (lVar1 != null) {
          BetterList_1.Clear(lVar1,DAT_181da7cd0);
          UITextList.UpdateVisibleText(this,0);
          return;
        }
    }

    // Token : 0x6000978
    // RVA   : 0xC046D0   Offset: 0xC03AD0   Length: 0x1BC
    private void Start()
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        ulong uVar4;
        uint uVar5;
        uVar3 = this.textLabel;
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (cVar2) {
          uVar3 = Component.GetComponentInChildren(this,DAT_181d97578);
          this.textLabel = uVar3;
        }
        uVar3 = this.scrollBar;
        cVar2 = Object.op_Inequality(uVar3,0,0);
        if (cVar2) {
          if (this.scrollBar == null) throw; // [null/range check failed]
          uVar3 = this.scrollBar.onChange;
          uVar4 = new OnTooltipCB(this,DAT_181dc6ac0,0);
          EventDelegate.Add(uVar3,uVar4,0);
        }
        if (this.textLabel != null) {
          UILabel.set_overflowMethod(this.textLabel,1);
          lVar1 = this.textLabel;
          if (this.style == 1) {
            if (lVar1 == null) throw; // [null/range check failed]
            UIWidget.set_pivot(lVar1,6);
            uVar5 = 0x3f800000;
          }
          else {
            if (lVar1 == null) throw; // [null/range check failed]
            UIWidget.set_pivot(lVar1,0,0);
            uVar5 = 0;
          }
          UITextList.set_scrollValue(this,uVar5,0);
          return;
        }
    }

    // Token : 0x6000979
    // RVA   : 0xC04B20   Offset: 0xC03F20   Length: 0x4D
    private void Update()
    {
        long lVar1;
        bool cVar2;
        cVar2 = UITextList.get_isValid(this,0);
        if (cVar2) {
          lVar1 = this.textLabel;
          if (lVar1 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if ((*(int *)(lVar1 + 164) != this.mLastWidth) ||
             (*(int *)(lVar1 + 168) != this.mLastHeight)) {
            UITextList.Rebuild(this,0);
            return;
          }
        }
    }

    // Token : 0x600097A
    // RVA   : 0xC04210   Offset: 0xC03610   Length: 0xA6
    public void OnScroll(float val)
    {
        bool cVar1;
        int iVar2;
        float fVar3;
        cVar1 = UITextList.get_isValid(this,0);
        if (cVar1) {
          if (this.textLabel == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          iVar2 = *(int *)(this.textLabel + 168);
          fVar3 = (float)UITextList.get_lineHeight(this,0);
          iVar2 = Mathf.FloorToInt((float)iVar2 / fVar3,0);
          iVar2 = Mathf.Max(0,this.mTotalLines - iVar2,0);
          if (iVar2 != 0) {
            fVar3 = (float)UITextList.get_lineHeight(this,0);
            UITextList.set_scrollValue
                      (this,this.mScroll - (fVar3 * val) / (float)iVar2,0);
          }
        }
    }

    // Token : 0x600097B
    // RVA   : 0xC04100   Offset: 0xC03500   Length: 0xA0
    public void OnDrag(Vector2 delta)
    {
        bool cVar1;
        int iVar2;
        float fVar3;
        uint uStack_14;
        cVar1 = UITextList.get_isValid(this,0);
        if (cVar1) {
          if (this.textLabel == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          iVar2 = *(int *)(this.textLabel + 168);
          fVar3 = (float)UITextList.get_lineHeight(this,0);
          iVar2 = Mathf.FloorToInt((float)iVar2 / fVar3,0);
          iVar2 = Mathf.Max(0,this.mTotalLines - iVar2,0);
          if (iVar2 != 0) {
            fVar3 = (float)UITextList.get_lineHeight(this,0);
            uStack_14 = (float)((uint64)delta >> 32);
            UITextList.set_scrollValue
                      (this,(uStack_14 / fVar3) / (float)iVar2 + this.mScroll,0);
          }
        }
    }

    // Token : 0x600097C
    // RVA   : 0xC041B0   Offset: 0xC035B0   Length: 0x5B
    private void OnScrollBar()
    {
        var pStatics = *(int64*)(DAT_181db0090 + 184);
        uint uVar1;
        if (*pStatics != 0) {
          uVar1 = UISlider.get_sliderValue(*pStatics,0);
          this.mScroll = uVar1;
          UITextList.UpdateVisibleText(this,0);
          return;
        }
    }

    // Token : 0x600097D
    // RVA   : 0xC03F90   Offset: 0xC03390   Length: 0x107
    public void Add(string text)
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        lVar2 = UITextList.get_paragraphs(this,0);
        if (lVar2 != null) {
          if (*(int *)(lVar2 + 24) < this.paragraphHistory) {
            lVar2 = new c.DisplayClass9_0(0);
          }
          else {
            lVar1 = this.mParagraphs;
            if ((lVar1 == null) || (lVar2 = lVar1.buffer) == null) throw; // [null/range check failed]
            if (*(int *)(lVar2 + 24) == 0) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = *(int64 *)(lVar2 + 32);
            FUN_181585c80(lVar1,0,DAT_181da7d50);
          }
          if (lVar2 != null) {
            *(uint64 *)(lVar2 + 16) = text;
            if (this.mParagraphs != null) {
              FUN_181584270(this.mParagraphs,lVar2,DAT_181da7c50);
              UITextList.Rebuild(this,0);
              return;
            }
          }
        }
    }

    // Token : 0x600097E
    // RVA   : 0xC03F90   Offset: 0xC03390   Length: 0x107
    protected void Add(string text, bool updateVisible)
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        lVar2 = UITextList.get_paragraphs(this,0);
        if (lVar2 != null) {
          if (*(int *)(lVar2 + 24) < this.paragraphHistory) {
            lVar2 = new c.DisplayClass9_0(0);
          }
          else {
            lVar1 = this.mParagraphs;
            if ((lVar1 == null) || (lVar2 = lVar1.buffer) == null) throw; // [null/range check failed]
            if (*(int *)(lVar2 + 24) == 0) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar2 = *(int64 *)(lVar2 + 32);
            FUN_181585c80(lVar1,0,DAT_181da7d50);
          }
          if (lVar2 != null) {
            *(uint64 *)(lVar2 + 16) = text;
            if (this.mParagraphs != null) {
              FUN_181584270(this.mParagraphs,lVar2,DAT_181da7c50);
              UITextList.Rebuild(this,0);
              return;
            }
          }
        }
    }

    // Token : 0x600097F
    // RVA   : 0xC042C0   Offset: 0xC036C0   Length: 0x40D
    protected void Rebuild()
    {
        long lVar1;
        bool cVar3;
        int iVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        uint uVar8;
        long local_res18;
        plVar10 = (int64 *)0;
        local_res18 = 0;
        cVar3 = UITextList.get_isValid(this,0);
        if (!cVar3) {
          return;
        }
        lVar5 = this.textLabel;
        if (lVar5 != null) {
          this.mLastWidth = *(uint32 *)(lVar5 + 164);
          this.mLastHeight = *(uint32 *)(lVar5 + 168);
          UILabel.UpdateNGUIText(lVar5,0);
          NGUIText.rectHeight = 1000000;
          NGUIText.regionHeight = 1000000;
          this.mTotalLines = 0;
          lVar5 = UITextList.get_paragraphs(this,0);
          plVar9 = plVar10;
          if (lVar5 != null) {
            while( true ) {
              lVar1 = this.mParagraphs;
              uVar8 = (uint32)plVar9;
              if (*(int *)(lVar5 + 24) <= (int)uVar8) break;
              if ((lVar1 == null) || (lVar5 = lVar1.buffer) == null) goto LAB_180c04698;
              if (*(uint32 *)(lVar5 + 24) <= uVar8) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              lVar5 = lVar5[uVar8];
              if (lVar5 == null) goto LAB_180c04698;
              uVar7 = *(uint64 *)(lVar5 + 16);
              NGUIText.WrapText(uVar7,&local_res18,0,1,0,0);
              lVar1 = local_res18;
              lVar6 = FUN_1800d60b0(DAT_181da1058,1);
              if (lVar6 == null) goto LAB_180c04698;
              if (*(int *)(lVar6 + 24) == 0) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              *(uint16 *)(lVar6 + 32) = 10;
              if (lVar1 == null) goto LAB_180c04698;
              uVar7 = String.Split(lVar1,lVar6,0);
              *(uint64 *)(lVar5 + 24) = uVar7;
              if (*(int64 *)(lVar5 + 24) == 0) goto LAB_180c04698;
              plVar9 = (int64 *)(uint64)(uVar8 + 1);
              this.mTotalLines =
                   this.mTotalLines + *(int *)(*(int64 *)(lVar5 + 24) + 24);
              lVar5 = UITextList.get_paragraphs(this);
              if (lVar5 == null) goto LAB_180c04698;
            }
            this.mTotalLines = 0;
            if (lVar1 != null) {
              iVar4 = lVar1.size;
              plVar9 = plVar10;
              if (0 < iVar4) goto LAB_180c044f0;
              goto LAB_180c04531;
            }
          }
        }
        LAB_180c04698:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        while( true ) {
          uVar8 = (uint32)plVar9;
          if (*(uint32 *)(lVar5 + 24) <= uVar8) {
            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar7,0);
          }
          lVar5 = lVar5[uVar8];
          if ((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 24)) == null) goto LAB_180c04698;
          plVar9 = (int64 *)(uint64)(uVar8 + 1);
          this.mTotalLines = this.mTotalLines + *(int *)(lVar5 + 24);
          if (iVar4 <= (int)(uVar8 + 1)) break;
        LAB_180c044f0:
          lVar5 = lVar1.buffer;
          if (lVar5 == null) goto LAB_180c04698;
        }
        LAB_180c04531:
        uVar7 = this.scrollBar;
        cVar3 = Object.op_Inequality(uVar7,0,0);
        if (cVar3) {
          plVar9 = this.scrollBar;
          if (plVar9 != (int64 *)0) {
            if ((*(byte *)(*plVar9 + 300) < *(byte *)(DAT_181db0210 + 300)) ||
               (*(int64 *)
                 (*(int64 *)(*plVar9 + 200) + -8 + (uint64)*(byte *)(DAT_181db0210 + 300) * 8) !=
                DAT_181db0210)) {
              bVar2 = false;
            }
            else {
              bVar2 = true;
            }
            if (bVar2) {
              plVar10 = plVar9;
            }
          }
          cVar3 = Object.op_Inequality(plVar10,0,0);
          if (cVar3) {
            if ((this.mTotalLines != null) &&
               (cVar3 = UITextList.get_isValid(this,0), cVar3)) {
              if (this.textLabel == null) goto LAB_180c04698;
              UITextList.get_lineHeight(this,0);
              iVar4 = Mathf.FloorToInt();
              Mathf.Max(0,this.mTotalLines - iVar4,0);
            }
            if (plVar10 == (int64 *)0) goto LAB_180c04698;
            UIScrollBar.set_barSize(plVar10);
          }
        }
        UITextList.UpdateVisibleText(this,0);
    }

    // Token : 0x6000980
    // RVA   : 0xC04890   Offset: 0xC03C90   Length: 0x284
    protected void UpdateVisibleText()
    {
        int iVar1;
        long lVar2;
        bool cVar3;
        int iVar4;
        int iVar5;
        uint uVar6;
        int iVar7;
        long lVar9;
        ulong uVar10;
        uint uVar11;
        uint uVar12;
        cVar3 = UITextList.get_isValid(this,0);
        if (cVar3) {
          lVar9 = this.textLabel;
          uVar10 = "";
          if (this.mTotalLines != null) {
            if (lVar9 == null) goto LAB_180c04aef;
            UITextList.get_lineHeight(this,0);
            iVar4 = Mathf.FloorToInt();
            iVar5 = Mathf.Max(0,this.mTotalLines - iVar4,0);
            uVar6 = Mathf.RoundToInt((float)iVar5 * this.mScroll,0);
            uVar11 = 0;
            if ((int)uVar6 < 0) {
              uVar6 = uVar11;
            }
            plVar8 = (int64 *)il2cpp_internal(DAT_181da7728);
            StringBuilder.ctor(plVar8,0);
            lVar9 = UITextList.get_paragraphs(this,0);
            if (lVar9 == null) goto LAB_180c04aef;
            iVar5 = *(int *)(lVar9 + 24);
            for (; (0 < iVar4 && (uVar12 = 0, (int)uVar11 < iVar5)); uVar11 = uVar11 + 1) {
              if ((this.mParagraphs == null) ||
                 (lVar9 = this.mParagraphs.buffer) == null)
              goto LAB_180c04aef;
              if (*(uint32 *)(lVar9 + 24) <= uVar11) {
                uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar10,0);
              }
              lVar9 = lVar9[uVar11];
              if ((lVar9 == null) || (*(int64 *)(lVar9 + 24) == 0)) goto LAB_180c04aef;
              iVar1 = *(int *)(*(int64 *)(lVar9 + 24) + 24);
              if (iVar4 != 0) {
                do {
                  if (iVar1 <= (int)uVar12) break;
                  lVar2 = *(int64 *)(lVar9 + 24);
                  if (lVar2 == null) goto LAB_180c04aef;
                  if (*(uint32 *)(lVar2 + 24) <= uVar12) {
                    uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar10,0);
                  }
                  uVar10 = lVar2[uVar12];
                  if ((int)uVar6 < 1) {
                    if (plVar8 == (int64 *)0) goto LAB_180c04aef;
                    iVar7 = FUN_181259e10(plVar8,0);
                    if (0 < iVar7) {
                      StringBuilder.Append(plVar8,"\n",0);
                    }
                    StringBuilder.Append(plVar8,uVar10,0);
                    iVar4 = iVar4 + -1;
                  }
                  else {
                    uVar6 = uVar6 - 1;
                  }
                  uVar12 = uVar12 + 1;
                } while (0 < iVar4);
              }
            }
            lVar9 = this.textLabel;
            if (plVar8 == (int64 *)0) goto LAB_180c04aef;
            uVar10 = (**(code **)(*plVar8 + 0x168))(plVar8,*(uint64 *)(*plVar8 + 0x170));
          }
          if (lVar9 == null) {
        LAB_180c04aef:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          UILabel.set_text(lVar9,uVar10,0);
        }
    }

    // Token : 0x6000981
    // RVA   : 0xC04BF0   Offset: 0xC03FF0   Length: 0x84
    public void /*ctor*/()
    {
        long lVar1;
        ulong uVar2;
        this.paragraphHistory = 100;
        lVar1 = FUN_1800d60b0(DAT_181da1058,1);
        if (lVar1 != null) {
          if (*(int *)(lVar1 + 24) != 0) {
            *(uint16 *)(lVar1 + 32) = 10;
            this.mSeparator = lVar1;
            FUN_18044ef50(this,0);
            return;
          }
          uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar2,0);
        }
    }

    // Token : 0x6000982
    // RVA   : 0xC04B70   Offset: 0xC03F70   Length: 0x76
    private static void /*cctor*/()
    {
        ulong uVar2;
        uVar2 = il2cpp_internal(DAT_181d82680);
        FUN_1808b1370(uVar2,DAT_181d717e8);
        puVar1 = *(uint64 **)(DAT_181db0490 + 184);
        *puVar1 = uVar2;
        il2cpp_internal(puVar1,uVar2);
    }

}
