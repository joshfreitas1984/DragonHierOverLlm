// ============================================================
// Type  : TypewriterEffect
// Token : 0x200002C
// ============================================================

public class TypewriterEffect
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40000C8
    public static TypewriterEffect current;

    // Token: 0x40000C9
    public int charsPerSecond;

    // Token: 0x40000CA
    public float fadeInTime;

    // Token: 0x40000CB
    public float delayOnPeriod;

    // Token: 0x40000CC
    public float delayOnNewLine;

    // Token: 0x40000CD
    public UIScrollView scrollView;

    // Token: 0x40000CE
    public bool keepFullDimensions;

    // Token: 0x40000CF
    public List<EventDelegate> onFinished;

    // Token: 0x40000D0
    private UILabel mLabel;

    // Token: 0x40000D1
    private string mFullText;

    // Token: 0x40000D2
    private int mCurrentOffset;

    // Token: 0x40000D3
    private float mNextChar;

    // Token: 0x40000D4
    private bool mReset;

    // Token: 0x40000D5
    private bool mActive;

    // Token: 0x40000D6
    private BetterList<FadeEntry> mFade;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60000AD
    // RVA   : 0xAEF290   Offset: 0xAEE690   Length: 0x5
    public bool get_isActive()
    {
        uint8 FUN_180aef290(int64 this)
        {
        return this.mActive;
    }

    // Token : 0x60000AE
    // RVA   : 0xAEE820   Offset: 0xAEDC20   Length: 0x2B
    public void ResetToBeginning()
    {
        TypewriterEffect.Finish(this,0);
        this.mReset = 0x101;
        this.mCurrentOffset = 0;
        TypewriterEffect.Update(this,0);
    }

    // Token : 0x60000AF
    // RVA   : 0xAEE690   Offset: 0xAEDA90   Length: 0x166
    public void Finish()
    {
        ulong uVar1;
        bool cVar4;
        if (!this.mActive) {
          return;
        }
        this.mActive = 0;
        if (!this.mReset) {
          if (this.mFullText == null) goto LAB_180aee7f1;
          this.mCurrentOffset = *(uint32 *)(this.mFullText + 16);
          if (this.mFade == null) goto LAB_180aee7f1;
          BetterList_1.Clear(this.mFade,DAT_181da78d0);
          if (this.mLabel == null) goto LAB_180aee7f1;
          UILabel.set_text(this.mLabel,this.mFullText,0);
        }
        if (this.keepFullDimensions) {
          uVar1 = this.scrollView;
          cVar4 = Object.op_Inequality(uVar1,0,0);
          if (cVar4) {
            if (this.scrollView == null) {
        LAB_180aee7f1:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            UIScrollView.UpdatePosition(this.scrollView,0);
          }
        }
        plVar2 = *(int64 **)(DAT_181daf210 + 184);
        *plVar2 = this;
        il2cpp_internal(plVar2,this);
        uVar1 = this.onFinished;
        EventDelegate.Execute(uVar1,0);
        puVar3 = *(uint64 **)(DAT_181daf210 + 184);
        *puVar3 = 0;
        il2cpp_internal(puVar3,0);
    }

    // Token : 0x60000B0
    // RVA   : 0xAEE810   Offset: 0xAEDC10   Length: 0x7
    private void OnEnable()
    {
        void FUN_180aee810(int64 this)
        {
        this.mReset = 0x101;
    }

    // Token : 0x60000B1
    // RVA   : 0xAEE800   Offset: 0xAEDC00   Length: 0x7
    private void OnDisable()
    {
        void FUN_180aee800(uint64 this)
        {
        TypewriterEffect.Finish(this,0);
    }

    // Token : 0x60000B2
    // RVA   : 0xAEE850   Offset: 0xAEDC50   Length: 0x948
    private void Update()
    {
        int iVar2;
        int iVar3;
        ulong uVar5;
        bool cVar6;
        ushort uVar8;
        uint uVar9;
        ulong uVar10;
        long lVar12;
        ulong uVar13;
        long lVar14;
        uint uVar15;
        uint uVar16;
        uint uVar17;
        float fVar18;
        float fVar19;
        ulong uVar20;
        ulong uStack_b0;
        ulong local_a8;
        ulong local_98;
        ulong uStack_90;
        ulong local_88;
        ulong local_78;
        ulong uStack_70;
        uStack_b0 = 0;
        local_a8 = 0;
        if (this.mActive) {
          uVar17 = 0;
          if (this.mReset) {
            this.mCurrentOffset = 0;
            this.mReset = 0;
            uVar10 = Component.GetComponent(this,DAT_181d96af8);
            this.mLabel = uVar10;
            if (this.mLabel == null) goto LAB_180aef163;
            uVar10 = UILabel.get_processedText(this.mLabel,0);
            this.mFullText = uVar10;
            if (this.mFade == null) goto LAB_180aef163;
            BetterList_1.Clear(this.mFade,DAT_181da78d0);
            if (this.keepFullDimensions) {
              uVar10 = this.scrollView;
              cVar6 = Object.op_Inequality(uVar10,0,0);
              if (cVar6) {
                if (this.scrollView == null) goto LAB_180aef163;
                UIScrollView.UpdatePosition(this.scrollView,0);
              }
            }
          }
          cVar6 = FUN_180d75bc0(this.mFullText,0);
          if (!cVar6) {
            if (this.mFullText != null) {
              iVar2 = *(int *)(this.mFullText + 16);
              iVar3 = this.mCurrentOffset;
              while (uVar15 = uVar17, iVar3 < iVar2) {
                fVar19 = this.mNextChar;
                fVar18 = (float)RealTime.get_time(0);
                if (fVar18 < fVar19) {
                  if (this.mCurrentOffset < iVar2) {
                    lVar12 = this.mFade;
                    if (lVar12 == null) goto LAB_180aef163;
                    if (*(int *)(lVar12 + 24) == 0) {
                      return;
                    }
                    goto LAB_180aeee43;
                  }
                  break;
                }
                uVar16 = this.mCurrentOffset;
                uVar9 = Mathf.Max(1,this.charsPerSecond);
                this.charsPerSecond = uVar9;
                if (this.mLabel == null) goto LAB_180aef163;
                cVar6 = this.mLabel.mEncoding;
                while (cVar6) {
                  uVar10 = this.mFullText;
                  cVar6 = NGUIText.ParseSymbol(uVar10,this + 80,0);
                }
                this.mCurrentOffset = this.mCurrentOffset + 1;
                if (iVar2 < this.mCurrentOffset) break;
                fVar19 = 1.0 / (float)this.charsPerSecond;
                if ((int)uVar16 < iVar2) {
                  if (this.mFullText == null) goto LAB_180aef163;
                  sVar7 = String.get_Chars(this.mFullText,uVar16,0);
                  if (sVar7 == 10) goto LAB_180aeeba1;
                  iVar3 = uVar16 + 1;
                  if (iVar3 == iVar2) {
        LAB_180aeeb34:
                    if (sVar7 == 46) {
                      uVar15 = uVar16 + 2;
                      if ((int)uVar15 < iVar2) {
                        if (this.mFullText == null) goto LAB_180aef163;
                        sVar7 = String.get_Chars(this.mFullText,iVar3,0);
                        if (sVar7 == 46) {
                          if (this.mFullText == null) goto LAB_180aef163;
                          sVar7 = String.get_Chars(this.mFullText,uVar15,0);
                          if (sVar7 == 46) {
                            fVar19 = fVar19 + this.delayOnPeriod * 3.0;
                            uVar16 = uVar15;
                            goto LAB_180aeeba6;
                          }
                        }
                      }
                    }
                    else if ((sVar7 != 33) && (sVar7 != 63)) goto LAB_180aeeba6;
                    fVar19 = fVar19 + this.delayOnPeriod;
                  }
                  else {
                    if (this.mFullText == null) goto LAB_180aef163;
                    uVar8 = String.get_Chars(this.mFullText,iVar3,0);
                    if (uVar8 < 33) goto LAB_180aeeb34;
                  }
                }
                else {
        LAB_180aeeba1:
                  fVar19 = fVar19 + this.delayOnNewLine;
                }
        LAB_180aeeba6:
                fVar18 = this.mNextChar;
                if (fVar18 == 0.0) {
                  fVar18 = (float)RealTime.get_time(0);
                }
                this.mNextChar = fVar18 + fVar19;
                lVar12 = this.mFullText;
                if (this.fadeInTime == null.0) {
                  lVar14 = this.mLabel;
                  if (!this.keepFullDimensions) {
                    if (lVar12 == null) goto LAB_180aef163;
                    uVar10 = String.Substring(lVar12,0,this.mCurrentOffset,0);
                  }
                  else {
                    if (lVar12 == null) goto LAB_180aef163;
                    uVar10 = String.Substring(lVar12,0,this.mCurrentOffset,0);
                    if (this.mFullText == null) goto LAB_180aef163;
                    String.Substring(this.mFullText,this.mCurrentOffset,0);
                    uVar10 = String.Concat(uVar10,"[00]");
                  }
                  if (lVar14 == null) goto LAB_180aef163;
                  UILabel.set_text(lVar14,uVar10);
                  if (!this.keepFullDimensions) {
                    uVar10 = this.scrollView;
                    cVar6 = Object.op_Inequality(uVar10,0);
                    if (cVar6) {
                      if (this.scrollView == null) goto LAB_180aef163;
                      UIScrollView.UpdatePosition(this.scrollView,0);
                    }
                  }
                }
                else {
                  local_a8 = 0;
                  uStack_b0 = 0;
                  uVar20 = (uint64)uVar16;
                  if (lVar12 == null) goto LAB_180aef163;
                  uStack_b0 = String.Substring(lVar12,uVar16,this.mCurrentOffset - uVar16,0,uVar20);
                  il2cpp_internal(&uStack_b0,uStack_b0);
                  if (this.mFade == null) goto LAB_180aef163;
                  uStack_90 = uStack_b0;
                  local_88 = local_a8;
                  local_98 = uVar20;
                  FUN_181584480(this.mFade,&local_98);
                }
                iVar3 = this.mCurrentOffset;
              }
              lVar12 = this.mFade;
              if (lVar12 != null) {
                if (*(int *)(lVar12 + 24) != 0) {
        LAB_180aeee43:
                  do {
                    if (*(int *)(lVar12 + 24) <= (int)uVar15) {
                      if (*(int *)(lVar12 + 24) != 0) {
                        plVar11 = (int64 *)il2cpp_internal(DAT_181da7728);
                        StringBuilder.ctor(plVar11,0);
                        lVar12 = this.mFade;
                        if (lVar12 != null) goto LAB_180aeef50;
                        goto LAB_180aef163;
                      }
                      lVar12 = this.mLabel;
                      lVar14 = this.mFullText;
                      if (!this.keepFullDimensions) {
                        if (lVar14 == null) goto LAB_180aef163;
                        uVar10 = String.Substring(lVar14,0,this.mCurrentOffset,0);
                      }
                      else {
                        if (lVar14 == null) goto LAB_180aef163;
                        uVar10 = String.Substring(lVar14,0,this.mCurrentOffset,0);
                        if (this.mFullText == null) goto LAB_180aef163;
                        uVar13 = String.Substring(this.mFullText,
                                                   this.mCurrentOffset,0);
                        uVar10 = String.Concat(uVar10,"[00]",uVar13,0);
                      }
                      if (lVar12 != null) {
                        UILabel.set_text(lVar12,uVar10,0);
                        return;
                      }
                      goto LAB_180aef163;
                    }
                    if ((lVar12 == null) || (lVar12 = *(int64 *)(lVar12 + 16)) == null)
                    goto LAB_180aef163;
                    lVar14 = (int64)(int)uVar15;
                    if (*(uint32 *)(lVar12 + 24) <= uVar15) {
                      uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar10,0);
                    }
                    puVar4 = (uint64 *)(lVar12 + 32 + lVar14 * 24);
                    uVar13 = *puVar4;
                    uVar5 = puVar4[1];
                    uVar10 = *(uint64 *)(lVar12 + 48 + lVar14 * 24);
                    fVar19 = (float)RealTime.get_deltaTime(0);
                    lVar12 = this.mFade;
                    fVar19 = (float)uVar10 + fVar19 / this.fadeInTime;
                    local_88 = CONCAT44((int)((uint64)uVar10 >> 32),fVar19);
                    if (fVar19 < 1.0) {
                      if ((lVar12 == null) || (lVar12 = *(int64 *)(lVar12 + 16)) == null)
                      goto LAB_180aef163;
                      if (*(uint32 *)(lVar12 + 24) <= uVar15) {
                        uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar10,0);
                      }
                      puVar4 = (uint64 *)(lVar12 + 32 + lVar14 * 24);
                      *puVar4 = uVar13;
                      puVar4[1] = uVar5;
                      *(uint64 *)(lVar12 + 48 + lVar14 * 24) = local_88;
                      uVar15 = uVar15 + 1;
                    }
                    else {
                      if (lVar12 == null) goto LAB_180aef163;
                      FUN_181585e70(lVar12,uVar15);
                    }
                    lVar12 = this.mFade;
                    if (lVar12 == null) goto LAB_180aef163;
                  } while( true );
                }
                if (this.mLabel != null) {
                  UILabel.set_text(this.mLabel,this.mFullText,0);
                  plVar11 = *(int64 **)(DAT_181daf210 + 184);
                  *plVar11 = this;
                  il2cpp_internal(plVar11,this);
                  uVar10 = this.onFinished;
                  EventDelegate.Execute(uVar10,0);
                  puVar4 = *(uint64 **)(DAT_181daf210 + 184);
                  *puVar4 = 0;
                  il2cpp_internal(puVar4,0);
                  this.mActive = 0;
                  return;
                }
              }
            }
        LAB_180aef163:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        return;
        LAB_180aeef50:
        if (*(int *)(lVar12 + 24) <= (int)uVar17) {
          if (!this.keepFullDimensions) {
            lVar12 = this.mLabel;
            if (plVar11 == (int64 *)0) goto LAB_180aef163;
          }
          else {
            if (plVar11 == (int64 *)0) goto LAB_180aef163;
            StringBuilder.Append(plVar11,"[00]",0);
            if (this.mFullText == null) goto LAB_180aef163;
            uVar10 = String.Substring(this.mFullText,this.mCurrentOffset,0);
            StringBuilder.Append(plVar11,uVar10,0);
            lVar12 = this.mLabel;
          }
          uVar10 = (**(code **)(*plVar11 + 0x168))(plVar11,*(uint64 *)(*plVar11 + 0x170));
          if (lVar12 != null) {
            UILabel.set_text(lVar12,uVar10,0);
            return;
          }
          goto LAB_180aef163;
        }
        if ((lVar12 == null) || (lVar12 = *(int64 *)(lVar12 + 16)) == null) goto LAB_180aef163;
        if (*(uint32 *)(lVar12 + 24) <= uVar17) {
          uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar10,0);
        }
        local_88 = *(uint64 *)(lVar12 + 48 + (int64)(int)uVar17 * 24);
        puVar1 = (uint64 *)(lVar12 + 32 + (int64)(int)uVar17 * 24);
        local_98 = *puVar1;
        uStack_90 = puVar1[1];
        if (uVar17 == 0) {
          local_78 = local_98;
          uStack_70 = uStack_90;
          if ((this.mFullText == null) ||
             (uVar10 = String.Substring(this.mFullText,0,local_98 & 0xffffffff,0),
             plVar11 == (int64 *)0)) goto LAB_180aef163;
          StringBuilder.Append(plVar11,uVar10);
        }
        else if (plVar11 == (int64 *)0) goto LAB_180aef163;
        StringBuilder.Append(plVar11,91);
        uVar10 = NGUIText.EncodeAlpha();
        StringBuilder.Append(plVar11,uVar10);
        StringBuilder.Append(plVar11,93);
        StringBuilder.Append(plVar11,uStack_90);
        lVar12 = this.mFade;
        uVar17 = uVar17 + 1;
        if (lVar12 == null) goto LAB_180aef163;
        goto LAB_180aeef50;
    }

    // Token : 0x60000B3
    // RVA   : 0xAEF1A0   Offset: 0xAEE5A0   Length: 0xE5
    public void /*ctor*/()
    {
        ulong uVar1;
        this.charsPerSecond = 20;
        uVar1 = il2cpp_internal(DAT_181d92670);
        FUN_181330100(uVar1,DAT_181d85eb8);
        this.onFinished = uVar1;
        this.mFullText = "";
        this.mReset = 1;
        this.mFade = new BetterList_1(DAT_181da77d0);
        FUN_18044ef50(this,0);
    }

}
