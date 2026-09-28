// ============================================================
// Type  : GameTextList
// Token : 0x20002AC
// ============================================================

public class GameTextList
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400158F
    public List<bool> hideInfoType;

    // Token: 0x4001590
    public UILabel textLabel;

    // Token: 0x4001591
    public UIProgressBar scrollBar;

    // Token: 0x4001592
    public Style style;

    // Token: 0x4001593
    public int paragraphHistory;

    // Token: 0x4001594
    protected char[] mSeparator;

    // Token: 0x4001595
    protected float mScroll;

    // Token: 0x4001596
    protected int mTotalLines;

    // Token: 0x4001597
    protected int mLastWidth;

    // Token: 0x4001598
    protected int mLastHeight;

    // Token: 0x4001599
    private BetterList<Paragraph> mParagraphs;

    // Token: 0x400159A
    private static Dictionary<string, BetterList<Paragraph>> mHistory;

    // Token: 0x400159B
    private bool needRebuild;

    // Token: 0x400159C
    private StringBuilder final;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60016B8
    // RVA   : 0xA5E2F0   Offset: 0xA5D6F0   Length: 0x16A
    protected BetterList<Paragraph> get_paragraphs()
    {
        var pStatics = *(int64*)(DAT_181d73438 + 184);
        long lVar1;
        bool cVar2;
        ulong uVar3;
        if (this.mParagraphs == null) {
          lVar1 = *pStatics;
          uVar3 = Object.get_name(this,0);
          if (lVar1 == null) {
        LAB_180a5e455:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          cVar2 = FUN_1808b04c0(lVar1,uVar3,this + 80,DAT_181d715c8);
          if (!cVar2) {
            this.mParagraphs = new BetterList_1(DAT_181da73b8);
            lVar1 = *pStatics;
            uVar3 = Object.get_name(this,0);
            if (lVar1 == null) goto LAB_180a5e455;
            FUN_1808ab370(lVar1,uVar3,this.mParagraphs,DAT_181d71540);
          }
        }
        return this.mParagraphs;
    }

    // Token : 0x60016B9
    // RVA   : 0xA5E2D0   Offset: 0xA5D6D0   Length: 0x1D
    public int get_paragraphCount()
    {
        long lVar1;
        lVar1 = GameTextList.get_paragraphs(this,0);
        if (lVar1 != null) {
          return *(uint32 *)(lVar1 + 24);
        }
    }

    // Token : 0x60016BA
    // RVA   : 0xA5E160   Offset: 0xA5D560   Length: 0xB4
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

    // Token : 0x60016BB
    // RVA   : 0xA5E4D0   Offset: 0xA5D8D0   Length: 0x6
    public float get_scrollValue()
    {
        uint32 FUN_180a5e4d0(int64 this)
        {
        return this.mScroll;
    }

    // Token : 0x60016BC
    // RVA   : 0xA5E4E0   Offset: 0xA5D8E0   Length: 0xCE
    public void set_scrollValue(float value)
    {
        ulong uVar1;
        bool cVar2;
        float fVar3;
        fVar3 = (float)Mathf.Clamp01(value,0);
        cVar2 = GameTextList.get_isValid(this,0);
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
          GameTextList.UpdateVisibleText(this,0);
        }
    }

    // Token : 0x60016BD
    // RVA   : 0xA5E220   Offset: 0xA5D620   Length: 0xA0
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

    // Token : 0x60016BE
    // RVA   : 0xA5E460   Offset: 0xA5D860   Length: 0x6D
    protected int get_scrollHeight()
    {
        bool cVar1;
        int iVar2;
        ulong uVar3;
        float fVar4;
        cVar1 = GameTextList.get_isValid(this,0);
        if (!cVar1) {
          return 0;
        }
        if (this.textLabel != null) {
          iVar2 = *(int *)(this.textLabel + 168);
          fVar4 = (float)GameTextList.get_lineHeight(this,0);
          iVar2 = Mathf.FloorToInt((float)iVar2 / fVar4,0);
          uVar3 = Mathf.Max(0,this.mTotalLines - iVar2,0);
          return uVar3;
        }
    }

    // Token : 0x60016BF
    // RVA   : 0xA5D230   Offset: 0xA5C630   Length: 0x57
    public void Clear()
    {
        long lVar1;
        lVar1 = GameTextList.get_paragraphs(this,0);
        if (lVar1 != null) {
          BetterList_1.Clear(lVar1,DAT_181da74b8);
          GameTextList.UpdateVisibleText(this,0);
          return;
        }
    }

    // Token : 0x60016C0
    // RVA   : 0xA5D960   Offset: 0xA5CD60   Length: 0x1BC
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
          uVar3 = Component.GetComponentInChildren(this,DAT_181d97560);
          this.textLabel = uVar3;
        }
        uVar3 = this.scrollBar;
        cVar2 = Object.op_Inequality(uVar3,0,0);
        if (cVar2) {
          if (this.scrollBar == null) throw; // [null/range check failed]
          uVar3 = this.scrollBar.onChange;
          uVar4 = new OnTooltipCB(this,DAT_181d75db8,0);
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
          GameTextList.set_scrollValue(this,uVar5,0);
          return;
        }
    }

    // Token : 0x60016C1
    // RVA   : 0xA5DFA0   Offset: 0xA5D3A0   Length: 0x61
    private void Update()
    {
        long lVar1;
        bool cVar2;
        if (this.needRebuild) {
          GameTextList.Rebuild(this,0);
          this.needRebuild = 0;
        }
        cVar2 = GameTextList.get_isValid(this,0);
        if (cVar2) {
          lVar1 = this.textLabel;
          if (lVar1 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if ((*(int *)(lVar1 + 164) != this.mLastWidth) ||
             (*(int *)(lVar1 + 168) != this.mLastHeight)) {
            GameTextList.Rebuild(this,0);
            return;
          }
        }
    }

    // Token : 0x60016C2
    // RVA   : 0xA5D3A0   Offset: 0xA5C7A0   Length: 0xA6
    public void OnScroll(float val)
    {
        bool cVar1;
        int iVar2;
        float fVar3;
        cVar1 = GameTextList.get_isValid(this,0);
        if (cVar1) {
          if (this.textLabel == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          iVar2 = *(int *)(this.textLabel + 168);
          fVar3 = (float)GameTextList.get_lineHeight(this,0);
          iVar2 = Mathf.FloorToInt((float)iVar2 / fVar3,0);
          iVar2 = Mathf.Max(0,this.mTotalLines - iVar2,0);
          if (iVar2 != 0) {
            fVar3 = (float)GameTextList.get_lineHeight(this,0);
            GameTextList.set_scrollValue
                      (this,this.mScroll - (fVar3 * val) / (float)iVar2,0);
          }
        }
    }

    // Token : 0x60016C3
    // RVA   : 0xA5D290   Offset: 0xA5C690   Length: 0xA0
    public void OnDrag(Vector2 delta)
    {
        bool cVar1;
        int iVar2;
        float fVar3;
        uint uStack_14;
        cVar1 = GameTextList.get_isValid(this,0);
        if (cVar1) {
          if (this.textLabel == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          iVar2 = *(int *)(this.textLabel + 168);
          fVar3 = (float)GameTextList.get_lineHeight(this,0);
          iVar2 = Mathf.FloorToInt((float)iVar2 / fVar3,0);
          iVar2 = Mathf.Max(0,this.mTotalLines - iVar2,0);
          if (iVar2 != 0) {
            fVar3 = (float)GameTextList.get_lineHeight(this,0);
            uStack_14 = (float)((uint64)delta >> 32);
            GameTextList.set_scrollValue
                      (this,(uStack_14 / fVar3) / (float)iVar2 + this.mScroll,0);
          }
        }
    }

    // Token : 0x60016C4
    // RVA   : 0xA5D340   Offset: 0xA5C740   Length: 0x5B
    private void OnScrollBar()
    {
        var pStatics = *(int64*)(DAT_181db0078 + 184);
        uint uVar1;
        if (*pStatics != 0) {
          uVar1 = UISlider.get_sliderValue(*pStatics,0);
          this.mScroll = uVar1;
          GameTextList.UpdateVisibleText(this,0);
          return;
        }
    }

    // Token : 0x60016C5
    // RVA   : 0xA5D0E0   Offset: 0xA5C4E0   Length: 0x144
    public void Add(int type, string text)
    {
        long lVar1;
        long lVar3;
        long lVar4;
        ulong uVar5;
        lVar1 = GameTextList.get_paragraphs(this,0);
        if (lVar1 != null) {
          if (*(int *)(lVar1 + 24) < this.paragraphHistory) {
            lVar1 = new c.DisplayClass9_0(0);
          }
          else {
            lVar4 = this.mParagraphs;
            if ((lVar4 == null) || (lVar1 = lVar4.buffer) == null) throw; // [null/range check failed]
            if (*(int *)(lVar1 + 24) == 0) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            lVar1 = *(int64 *)(lVar1 + 32);
            FUN_181585670(lVar4,0,DAT_181da7538);
          }
          if (lVar1 != null) {
            *(int64 *)(lVar1 + 40) = text;
            *(uint32 *)(lVar1 + 32) = type;
            plVar2 = (int64 *)FUN_1800d60b0(DAT_181da4120,4);
            lVar4 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x420);
            if (lVar4 != null) {
              if (lVar4.size <= type) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar4 = lVar4.buffer[type];
              if (plVar2 != (int64 *)0) {
                if (lVar4 != null) {
                  lVar3 = il2cpp_internal(lVar4,*(uint64 *)(*plVar2 + 64));
                  if (lVar3 == null) {
                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar5,0);
                  }
                }
                if ((int)plVar2[3] == 0) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar5,0);
                }
                plVar2[4] = lVar4;
                il2cpp_internal(plVar2 + 4,lVar4);
                if (text != null) {
                  lVar4 = Int32.ToString(text + 20,0);
                  if (lVar4 != null) {
                    lVar3 = il2cpp_internal(lVar4,*(uint64 *)(*plVar2 + 64));
                    if (lVar3 == null) {
                      uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar5,0);
                    }
                  }
                  if (*(uint32 *)(plVar2 + 3) < 2) {
                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar5,0);
                  }
                  plVar2[5] = lVar4;
                  il2cpp_internal(plVar2 + 5,lVar4);
                  lVar4 = Int32.ToString(text + 24,0);
                  if (lVar4 != null) {
                    lVar3 = il2cpp_internal(lVar4,*(uint64 *)(*plVar2 + 64));
                    if (lVar3 == null) {
                      uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar5,0);
                    }
                  }
                  if (*(uint32 *)(plVar2 + 3) < 3) {
                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar5,0);
                  }
                  plVar2[6] = lVar4;
                  il2cpp_internal(plVar2 + 6,lVar4);
                  if (param_4 != 0) {
                    lVar4 = il2cpp_internal(param_4,*(uint64 *)(*plVar2 + 64));
                    if (lVar4 == null) {
                      uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar5,0);
                    }
                  }
                  if (*(uint32 *)(plVar2 + 3) < 4) {
                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar5,0);
                  }
                  plVar2[7] = param_4;
                  il2cpp_internal(plVar2 + 7,param_4);
                  uVar5 = String.Format("[A9A9A9][{0}[-][A9A9A9]{1}/{2}][-]{3}",plVar2,0);
                  *(uint64 *)(lVar1 + 16) = uVar5;
                  if (this.mParagraphs != null) {
                    FUN_181583c60(this.mParagraphs,lVar1,DAT_181da7438);
                    this.needRebuild = 1;
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60016C6
    // RVA   : 0xA5D0A0   Offset: 0xA5C4A0   Length: 0x31
    public void Add(InfoData info)
    {
        long lVar1;
        long lVar3;
        long lVar4;
        ulong uVar5;
        lVar1 = GameTextList.get_paragraphs(this,0);
        if (lVar1 != null) {
          if (*(int *)(lVar1 + 24) < this.paragraphHistory) {
            lVar1 = new c.DisplayClass9_0(0);
          }
          else {
            lVar4 = this.mParagraphs;
            if ((lVar4 == null) || (lVar1 = lVar4.buffer) == null) throw; // [null/range check failed]
            if (*(int *)(lVar1 + 24) == 0) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            lVar1 = *(int64 *)(lVar1 + 32);
            FUN_181585670(lVar4,0,DAT_181da7538);
          }
          if (lVar1 != null) {
            *(int64 *)(lVar1 + 40) = param_3;
            *(uint32 *)(lVar1 + 32) = info;
            plVar2 = (int64 *)FUN_1800d60b0(DAT_181da4120,4);
            lVar4 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x420);
            if (lVar4 != null) {
              if (lVar4.size <= info) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar4 = lVar4.buffer[info];
              if (plVar2 != (int64 *)0) {
                if (lVar4 != null) {
                  lVar3 = il2cpp_internal(lVar4,*(uint64 *)(*plVar2 + 64));
                  if (lVar3 == null) {
                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar5,0);
                  }
                }
                if ((int)plVar2[3] == 0) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar5,0);
                }
                plVar2[4] = lVar4;
                il2cpp_internal(plVar2 + 4,lVar4);
                if (param_3 != 0) {
                  lVar4 = Int32.ToString(param_3 + 20,0);
                  if (lVar4 != null) {
                    lVar3 = il2cpp_internal(lVar4,*(uint64 *)(*plVar2 + 64));
                    if (lVar3 == null) {
                      uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar5,0);
                    }
                  }
                  if (*(uint32 *)(plVar2 + 3) < 2) {
                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar5,0);
                  }
                  plVar2[5] = lVar4;
                  il2cpp_internal(plVar2 + 5,lVar4);
                  lVar4 = Int32.ToString(param_3 + 24,0);
                  if (lVar4 != null) {
                    lVar3 = il2cpp_internal(lVar4,*(uint64 *)(*plVar2 + 64));
                    if (lVar3 == null) {
                      uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar5,0);
                    }
                  }
                  if (*(uint32 *)(plVar2 + 3) < 3) {
                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar5,0);
                  }
                  plVar2[6] = lVar4;
                  il2cpp_internal(plVar2 + 6,lVar4);
                  if (param_4 != 0) {
                    lVar4 = il2cpp_internal(param_4,*(uint64 *)(*plVar2 + 64));
                    if (lVar4 == null) {
                      uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar5,0);
                    }
                  }
                  if (*(uint32 *)(plVar2 + 3) < 4) {
                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar5,0);
                  }
                  plVar2[7] = param_4;
                  il2cpp_internal(plVar2 + 7,param_4);
                  uVar5 = String.Format("[A9A9A9][{0}[-][A9A9A9]{1}/{2}][-]{3}",plVar2,0);
                  *(uint64 *)(lVar1 + 16) = uVar5;
                  if (this.mParagraphs != null) {
                    FUN_181583c60(this.mParagraphs,lVar1,DAT_181da7438);
                    this.needRebuild = 1;
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60016C7
    // RVA   : 0xA5CD20   Offset: 0xA5C120   Length: 0x373
    protected void Add(int type, TimeData time, string text, bool updateVisible)
    {
        long lVar1;
        long lVar3;
        long lVar4;
        ulong uVar5;
        lVar1 = GameTextList.get_paragraphs(this,0);
        if (lVar1 != null) {
          if (*(int *)(lVar1 + 24) < this.paragraphHistory) {
            lVar1 = new c.DisplayClass9_0(0);
          }
          else {
            lVar4 = this.mParagraphs;
            if ((lVar4 == null) || (lVar1 = lVar4.buffer) == null) throw; // [null/range check failed]
            if (*(int *)(lVar1 + 24) == 0) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            lVar1 = *(int64 *)(lVar1 + 32);
            FUN_181585670(lVar4,0,DAT_181da7538);
          }
          if (lVar1 != null) {
            *(int64 *)(lVar1 + 40) = time;
            *(uint32 *)(lVar1 + 32) = type;
            plVar2 = (int64 *)FUN_1800d60b0(DAT_181da4120,4);
            lVar4 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x420);
            if (lVar4 != null) {
              if (lVar4.size <= type) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar4 = lVar4.buffer[type];
              if (plVar2 != (int64 *)0) {
                if (lVar4 != null) {
                  lVar3 = il2cpp_internal(lVar4,*(uint64 *)(*plVar2 + 64));
                  if (lVar3 == null) {
                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar5,0);
                  }
                }
                if ((int)plVar2[3] == 0) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar5,0);
                }
                plVar2[4] = lVar4;
                il2cpp_internal(plVar2 + 4,lVar4);
                if (time != null) {
                  lVar4 = Int32.ToString(time + 20,0);
                  if (lVar4 != null) {
                    lVar3 = il2cpp_internal(lVar4,*(uint64 *)(*plVar2 + 64));
                    if (lVar3 == null) {
                      uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar5,0);
                    }
                  }
                  if (*(uint32 *)(plVar2 + 3) < 2) {
                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar5,0);
                  }
                  plVar2[5] = lVar4;
                  il2cpp_internal(plVar2 + 5,lVar4);
                  lVar4 = Int32.ToString(time + 24,0);
                  if (lVar4 != null) {
                    lVar3 = il2cpp_internal(lVar4,*(uint64 *)(*plVar2 + 64));
                    if (lVar3 == null) {
                      uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar5,0);
                    }
                  }
                  if (*(uint32 *)(plVar2 + 3) < 3) {
                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar5,0);
                  }
                  plVar2[6] = lVar4;
                  il2cpp_internal(plVar2 + 6,lVar4);
                  if (text != null) {
                    lVar4 = il2cpp_internal(text,*(uint64 *)(*plVar2 + 64));
                    if (lVar4 == null) {
                      uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar5,0);
                    }
                  }
                  if (*(uint32 *)(plVar2 + 3) < 4) {
                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar5,0);
                  }
                  plVar2[7] = text;
                  il2cpp_internal(plVar2 + 7,text);
                  uVar5 = String.Format("[A9A9A9][{0}[-][A9A9A9]{1}/{2}][-]{3}",plVar2,0);
                  *(uint64 *)(lVar1 + 16) = uVar5;
                  if (this.mParagraphs != null) {
                    FUN_181583c60(this.mParagraphs,lVar1,DAT_181da7438);
                    this.needRebuild = 1;
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60016C8
    // RVA   : 0xA5D450   Offset: 0xA5C850   Length: 0x50C
    protected void Rebuild()
    {
        var pStatics = *(int64*)(DAT_181d8bc90 + 184);
        uint uVar1;
        long lVar2;
        bool cVar4;
        int iVar5;
        long lVar6;
        long lVar7;
        ulong uVar8;
        uint uVar9;
        long[] local_res18 = new long[2];
        plVar11 = (int64 *)0;
        local_res18[0] = 0;
        cVar4 = GameTextList.get_isValid(this,0);
        if (!cVar4) {
          return;
        }
        lVar6 = this.textLabel;
        if (lVar6 != null) {
          this.mLastWidth = *(uint32 *)(lVar6 + 164);
          this.mLastHeight = *(uint32 *)(lVar6 + 168);
          UILabel.UpdateNGUIText(lVar6,0);
          *(uint32 *)(pStatics + 64) = 1000000;
          *(uint32 *)(pStatics + 72) = 1000000;
          this.mTotalLines = 0;
          lVar6 = GameTextList.get_paragraphs(this,0);
          plVar10 = plVar11;
          if (lVar6 != null) {
            while( true ) {
              lVar2 = this.mParagraphs;
              uVar9 = (uint32)plVar10;
              if (*(int *)(lVar6 + 24) <= (int)uVar9) break;
              if ((lVar2 == null) || (lVar6 = lVar2.buffer) == null) goto LAB_180a5d907;
              if (*(uint32 *)(lVar6 + 24) <= uVar9) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              lVar6 = lVar6[uVar9];
              if ((lVar6 == null) || (lVar2 = this.hideInfoType) == null) goto LAB_180a5d907;
              uVar1 = *(uint32 *)(lVar6 + 32);
              if (lVar2.size <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (*(char *)(lVar2.buffer + 32 + (int64)(int)uVar1) == false) {
                if ((this.mParagraphs == null) ||
                   (lVar6 = this.mParagraphs.buffer) == null)
                goto LAB_180a5d907;
                if (*(uint32 *)(lVar6 + 24) <= uVar9) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                lVar6 = lVar6[uVar9];
                if (lVar6 == null) goto LAB_180a5d907;
                uVar8 = *(uint64 *)(lVar6 + 16);
                NGUIText.WrapText(uVar8,local_res18,0,1,0,0);
                lVar2 = local_res18[0];
                lVar7 = FUN_1800d60b0(DAT_181da1040,1);
                if (lVar7 == null) goto LAB_180a5d907;
                if (*(int *)(lVar7 + 24) == 0) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                *(uint16 *)(lVar7 + 32) = 10;
                if (lVar2 == null) goto LAB_180a5d907;
                uVar8 = String.Split(lVar2,lVar7);
                *(uint64 *)(lVar6 + 24) = uVar8;
                if (*(int64 *)(lVar6 + 24) == 0) goto LAB_180a5d907;
                this.mTotalLines =
                     this.mTotalLines + *(int *)(*(int64 *)(lVar6 + 24) + 24);
              }
              plVar10 = (int64 *)(uint64)(uVar9 + 1);
              lVar6 = GameTextList.get_paragraphs(this);
              if (lVar6 == null) goto LAB_180a5d907;
            }
            this.mTotalLines = 0;
            if (lVar2 != null) {
              iVar5 = lVar2.size;
              plVar10 = plVar11;
              if (0 < iVar5) goto LAB_180a5d6f0;
              goto LAB_180a5d79b;
            }
          }
        }
        LAB_180a5d907:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        while( true ) {
          uVar9 = (uint32)plVar10;
          if (*(uint32 *)(lVar6 + 24) <= uVar9) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          lVar6 = lVar6[uVar9];
          if ((lVar6 == null) || (lVar2 = this.hideInfoType) == null) goto LAB_180a5d907;
          uVar1 = *(uint32 *)(lVar6 + 32);
          if (lVar2.size <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (*(char *)(lVar2.buffer + 32 + (int64)(int)uVar1) == false) {
            if ((this.mParagraphs == null) ||
               (lVar6 = this.mParagraphs.buffer) == null)
            goto LAB_180a5d907;
            if (*(uint32 *)(lVar6 + 24) <= uVar9) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            lVar6 = lVar6[uVar9];
            if ((lVar6 == null) || (lVar6 = *(int64 *)(lVar6 + 24)) == null) goto LAB_180a5d907;
            this.mTotalLines = this.mTotalLines + *(int *)(lVar6 + 24);
          }
          plVar10 = (int64 *)(uint64)(uVar9 + 1);
          if (iVar5 <= (int)(uVar9 + 1)) break;
        LAB_180a5d6f0:
          if ((this.mParagraphs == null) ||
             (lVar6 = this.mParagraphs.buffer) == null)
          goto LAB_180a5d907;
        }
        LAB_180a5d79b:
        uVar8 = this.scrollBar;
        cVar4 = Object.op_Inequality(uVar8,0,0);
        if (cVar4) {
          plVar10 = this.scrollBar;
          if (plVar10 != (int64 *)0) {
            if ((*(byte *)(*plVar10 + 300) < *(byte *)(DAT_181db01f8 + 300)) ||
               (*(int64 *)
                 (*(int64 *)(*plVar10 + 200) + -8 + (uint64)*(byte *)(DAT_181db01f8 + 300) * 8) !=
                DAT_181db01f8)) {
              bVar3 = false;
            }
            else {
              bVar3 = true;
            }
            if (bVar3) {
              plVar11 = plVar10;
            }
          }
          cVar4 = Object.op_Inequality(plVar11,0,0);
          if (cVar4) {
            if ((this.mTotalLines != null) &&
               (cVar4 = GameTextList.get_isValid(this,0), cVar4)) {
              if (this.textLabel == null) goto LAB_180a5d907;
              GameTextList.get_lineHeight(this,0);
              iVar5 = Mathf.FloorToInt();
              Mathf.Max(0,this.mTotalLines - iVar5,0);
            }
            if (plVar11 == (int64 *)0) goto LAB_180a5d907;
            UIScrollBar.set_barSize(plVar11);
          }
        }
        GameTextList.UpdateVisibleText(this,0);
    }

    // Token : 0x60016C9
    // RVA   : 0xA5DC90   Offset: 0xA5D090   Length: 0x301
    protected void UpdateVisibleText()
    {
        uint uVar1;
        int iVar2;
        long lVar3;
        bool cVar5;
        int iVar6;
        int iVar7;
        uint uVar8;
        int iVar9;
        long lVar10;
        ulong uVar11;
        uint uVar12;
        uint uVar13;
        cVar5 = GameTextList.get_isValid(this,0);
        if (cVar5) {
          lVar10 = this.textLabel;
          uVar11 = "";
          if (this.mTotalLines != null) {
            if (lVar10 == null) goto LAB_180a5df5c;
            GameTextList.get_lineHeight(this,0);
            iVar6 = Mathf.FloorToInt();
            iVar7 = Mathf.Max(0,this.mTotalLines - iVar6,0);
            uVar8 = Mathf.RoundToInt((float)iVar7 * this.mScroll,0);
            uVar13 = 0;
            if ((int)uVar8 < 0) {
              uVar8 = uVar13;
            }
            if (this.final == null) goto LAB_180a5df5c;
            StringBuilder.Clear(this.final,0);
            lVar10 = GameTextList.get_paragraphs(this,0);
            if (lVar10 == null) goto LAB_180a5df5c;
            iVar7 = *(int *)(lVar10 + 24);
            for (; (0 < iVar6 && (uVar12 = 0, (int)uVar13 < iVar7)); uVar13 = uVar13 + 1) {
              if ((this.mParagraphs == null) ||
                 (lVar10 = this.mParagraphs.buffer) == null)
              goto LAB_180a5df5c;
              if (*(uint32 *)(lVar10 + 24) <= uVar13) {
                uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar11,0);
              }
              lVar10 = lVar10[uVar13];
              if ((lVar10 == null) || (lVar3 = this.hideInfoType) == null)
              goto LAB_180a5df5c;
              uVar1 = *(uint32 *)(lVar10 + 32);
              if (*(uint32 *)(lVar3 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (*(char *)(*(int64 *)(lVar3 + 16) + 32 + (int64)(int)uVar1) == false) {
                if ((this.mParagraphs == null) ||
                   (lVar10 = this.mParagraphs.buffer) == null)
                goto LAB_180a5df5c;
                if (*(uint32 *)(lVar10 + 24) <= uVar13) {
                  uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar11,0);
                }
                lVar10 = lVar10[uVar13];
                if ((lVar10 == null) || (*(int64 *)(lVar10 + 24) == 0)) goto LAB_180a5df5c;
                iVar2 = *(int *)(*(int64 *)(lVar10 + 24) + 24);
                if (iVar6 != 0) {
                  do {
                    if (iVar2 <= (int)uVar12) break;
                    lVar3 = *(int64 *)(lVar10 + 24);
                    if (lVar3 == null) goto LAB_180a5df5c;
                    if (*(uint32 *)(lVar3 + 24) <= uVar12) {
                      uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar11,0);
                    }
                    uVar11 = lVar3[uVar12];
                    if ((int)uVar8 < 1) {
                      if (this.final == null) goto LAB_180a5df5c;
                      iVar9 = FUN_181259800(this.final,0);
                      if (0 < iVar9) {
                        if (this.final == null) goto LAB_180a5df5c;
                        StringBuilder.Append(this.final,"\n",0);
                      }
                      if (this.final == null) goto LAB_180a5df5c;
                      StringBuilder.Append(this.final,uVar11,0);
                      iVar6 = iVar6 + -1;
                    }
                    else {
                      uVar8 = uVar8 - 1;
                    }
                    uVar12 = uVar12 + 1;
                  } while (0 < iVar6);
                }
              }
            }
            plVar4 = this.final;
            lVar10 = this.textLabel;
            if (plVar4 == (int64 *)0) goto LAB_180a5df5c;
            uVar11 = (**(code **)(*plVar4 + 0x168))(plVar4,*(uint64 *)(*plVar4 + 0x170));
          }
          if (lVar10 == null) {
        LAB_180a5df5c:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          UILabel.set_text(lVar10,uVar11,0);
        }
    }

    // Token : 0x60016CA
    // RVA   : 0xA5DB20   Offset: 0xA5CF20   Length: 0x16D
    public void TypeTabClicked(GameObject tab)
    {
        long lVar1;
        uint uVar2;
        uint uVar3;
        ulong uVar4;
        long lVar5;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        lVar1 = this.hideInfoType;
        if (tab != null) {
          uVar4 = Object.get_name(tab,0);
          uVar2 = Int32.Parse(uVar4,0);
          lVar5 = this.hideInfoType;
          uVar4 = Object.get_name(tab,0);
          uVar3 = Int32.Parse(uVar4,0);
          if (lVar5 != null) {
            if (lVar5.Count <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar1 != null) {
              FUN_1817f42f0(lVar1,uVar2,
                            *(char *)(lVar5._items + 32 + (int64)(int)uVar3) == false,
                            DAT_181d80720);
              lVar5 = GameObject.GetComponent(tab);
              lVar1 = this.hideInfoType;
              uVar4 = Object.get_name(tab);
              uVar3 = Int32.Parse(uVar4);
              if (lVar1 != null) {
                if (lVar1.Count <= uVar3) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                if (*(char *)(lVar1._items + 32 + (int64)(int)uVar3) == false) {
                  puVar6 = (uint32 *)FUN_1810d3570(&local_28);
                }
                else {
                  puVar6 = (uint32 *)FUN_1810d33f0();
                }
                local_28 = *puVar6;
                uStack_24 = puVar6[1];
                uStack_20 = puVar6[2];
                uStack_1c = puVar6[3];
                if (lVar5 != null) {
                  UIButtonColor.set_defaultColor(lVar5,&local_28,0);
                  GameTextList.Rebuild(this,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x60016CB
    // RVA   : 0xA5E090   Offset: 0xA5D490   Length: 0xC2
    public void /*ctor*/()
    {
        long lVar1;
        ulong uVar2;
        this.paragraphHistory = 100;
        lVar1 = FUN_1800d60b0(DAT_181da1040,1);
        if (lVar1 != null) {
          if (*(int *)(lVar1 + 24) != 0) {
            *(uint16 *)(lVar1 + 32) = 10;
            this.mSeparator = lVar1;
            this.final = new StringBuilder(0);
            FUN_18044ef50(this,0);
            return;
          }
          uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar2,0);
        }
    }

    // Token : 0x60016CC
    // RVA   : 0xA5E010   Offset: 0xA5D410   Length: 0x76
    private static void /*cctor*/()
    {
        ulong uVar2;
        uVar2 = il2cpp_internal(DAT_181d82568);
        FUN_1808b1370(uVar2,DAT_181dc8338);
        puVar1 = *(uint64 **)(DAT_181d73438 + 184);
        *puVar1 = uVar2;
        il2cpp_internal(puVar1,uVar2);
    }

}
