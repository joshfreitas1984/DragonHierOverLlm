// ============================================================
// Type  : TweenLetters
// Token : 0x20000BB
// ============================================================

public class TweenLetters
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400046C
    public AnimationProperties hoverOver;

    // Token: 0x400046D
    public AnimationProperties hoverOut;

    // Token: 0x400046E
    private UILabel mLabel;

    // Token: 0x400046F
    private int mVertexCount;

    // Token: 0x4000470
    private int[] mLetterOrder;

    // Token: 0x4000471
    private LetterProperties[] mLetter;

    // Token: 0x4000472
    private AnimationProperties mCurrent;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60005AD
    // RVA   : 0xA70CA0   Offset: 0xA6F4A0   Length: 0xE0
    private void OnEnable()
    {
        ulong uVar2;
        ulong uVar3;
        this.mVertexCount = 0xffffffff;
        if (this.mLabel == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        puVar1 = (uint64 *)(this.mLabel + 192);
        uVar2 = *puVar1;
        uVar3 = new OnTooltipCB(this,DAT_181d96c40,0);
        plVar4 = (int64 *)Delegate.Combine(uVar2,uVar3,0);
        plVar5 = (int64 *)0;
        if (plVar4 != (int64 *)0) {
          if (*plVar4 == DAT_181d68b10) {
            plVar5 = plVar4;
          }
          if (plVar5 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar4,DAT_181d68b10);
          }
        }
        *puVar1 = plVar5;
        il2cpp_internal(puVar1);
    }

    // Token : 0x60005AE
    // RVA   : 0xA70BC0   Offset: 0xA6F3C0   Length: 0xD6
    private void OnDisable()
    {
        ulong uVar2;
        ulong uVar3;
        if (this.mLabel == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        puVar1 = (uint64 *)(this.mLabel + 192);
        uVar2 = *puVar1;
        uVar3 = new OnTooltipCB(this,DAT_181d96c40,0);
        plVar4 = (int64 *)Delegate.Remove(uVar2,uVar3,0);
        plVar5 = (int64 *)0;
        if (plVar4 != (int64 *)0) {
          if (*plVar4 == DAT_181d68b10) {
            plVar5 = plVar4;
          }
          if (plVar5 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar4,DAT_181d68b10);
          }
        }
        *puVar1 = plVar5;
        il2cpp_internal(puVar1);
    }

    // Token : 0x60005AF
    // RVA   : 0xA70770   Offset: 0xA6EF70   Length: 0x5E
    private void Awake()
    {
        ulong uVar1;
        uVar1 = Component.GetComponent(this,DAT_181d6e240);
        this.mLabel = uVar1;
        this.mCurrent = this.hoverOver;
    }

    // Token : 0x60005B0
    // RVA   : 0xA716B0   Offset: 0xA6FEB0   Length: 0x49
    public override void Play(bool forward)
    {
        ulong uVar1;
        if (!forward) {
          uVar1 = this.hoverOut;
        }
        else {
          uVar1 = this.hoverOver;
        }
        this.mCurrent = uVar1;
        UITweener.Play(this,forward,0);
    }

    // Token : 0x60005B1
    // RVA   : 0xA70D90   Offset: 0xA6F590   Length: 0x8E3
    private void OnPostFill(UIWidget widget, int bufferOffset, List<Vector3> verts, List<Vector2> uvs, List<Color> cols)
    {
        void TweenLetters.OnPostFill
                     (int64 this,uint64 widget,uint64 bufferOffset,int64 verts,
                     uint64 uvs,int64 cols)
        {
        float fVar1;
        float fVar2;
        int64 lVar3;
        uint64 uVar4;
        uint64 uVar5;
        char cVar6;
        int iVar7;
        uint64 *puVar8;
        uint64 uVar9;
        int iVar10;
        uint32 uVar11;
        int64 lVar12;
        uint32 uVar13;
        uint32 uVar14;
        int iVar15;
        float fVar16;
        uint64 uVar17;
        float fVar18;
        float fVar19;
        float fVar20;
        uint64 local_2c8;
        float fStack_2c0;
        float fStack_2bc;
        uint64 local_2b8;
        float local_2b0;
        uint64 local_2a8;
        uint64 uStack_2a0;
        int local_298;
        int local_294;
        int local_290;
        uint8 local_288 [8];
        float local_280;
        uint64 local_278;
        float local_270;
        float local_268;
        float fStack_264;
        float local_260;
        float local_258;
        float fStack_254;
        float local_250;
        float local_238;
        float local_228;
        float local_218;
        uint64 local_208;
        float local_200;
        uint64 local_1f8;
        float local_1f0;
        float local_1e0;
        uint64 local_1d8;
        float local_1d0;
        float local_1c0;
        uint64 local_1b8;
        float local_1b0;
        float local_1a0;
        uint64 local_198;
        uint64 uStack_190;
        uint64 local_188;
        uint64 uStack_180;
        uint64 local_178;
        uint64 uStack_170;
        uint64 local_168;
        uint64 uStack_160;
        uint8 local_150 [16];
        uint8 local_140 [16];
        uint8 local_130 [16];
        uint8 local_120 [16];
        uint8 local_110 [16];
        uint8 local_100 [16];
        uint8 local_f0 [200];
        local_198 = 0;
        uStack_190 = 0;
        local_188 = 0;
        uStack_180 = 0;
        local_178 = 0;
        uStack_170 = 0;
        local_168 = 0;
        uStack_160 = 0;
        if ((verts != null) && (iVar10 = *(int *)(verts + 24)) != null) {
          uVar9 = this.mLabel;
          local_298 = iVar10;
          cVar6 = Object.op_Equality(uVar9,0,0);
          if (!cVar6) {
            if (this.mLabel == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            iVar7 = UILabel.get_quadsPerCharacter(this.mLabel,0);
            iVar15 = (int)((iVar10 / iVar7 >> 31 & 3U) + iVar10 / iVar7) >> 2;
            local_294 = iVar15;
            local_290 = iVar7;
            if (this.mLabel == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            UILabel.get_printedText(this.mLabel,0);
            if (this.mVertexCount != iVar10) {
              this.mVertexCount = iVar10;
              TweenLetters.SetLetterOrder(this,iVar15,0);
              TweenLetters.GetLetterDuration(this,iVar15,0);
            }
            puVar8 = (uint64 *)Matrix4x4.get_identity(local_f0,0);
            local_198 = *puVar8;
            uStack_190 = puVar8[1];
            local_188 = puVar8[2];
            uStack_180 = puVar8[3];
            local_178 = puVar8[4];
            uStack_170 = puVar8[5];
            local_168 = puVar8[6];
            uStack_160 = puVar8[7];
            Vector3.get_zero(local_288,0);
            Quaternion.get_identity(&local_2a8,0);
            Vector3.get_one(local_288,0);
            Vector3.get_zero(local_288,0);
            lVar12 = this.mCurrent;
            if (lVar12 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_2b8 = lVar12.rot;
            local_2b0 = *(float *)(lVar12 + 64);
            puVar8 = (uint64 *)Quaternion.Euler(&local_2a8,&local_2b8,0);
            uVar9 = *puVar8;
            uVar4 = puVar8[1];
            Vector3.get_zero(local_288);
            FUN_180d904c0(&local_2a8);
            fVar1 = *(float *)(this + 48);
            fVar2 = *(float *)(this + 108);
            for (iVar10 = 0; iVar10 < iVar7; iVar10 = iVar10 + 1) {
              for (uVar14 = 0; (int)uVar14 < iVar15; uVar14 = uVar14 + 1) {
                lVar12 = this.mLetterOrder;
                if (lVar12 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (lVar12.randomDurations <= uVar14) {
                  uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar9,0);
                }
                uVar11 = lVar12[uVar14];
                lVar12 = (int64)(int)uVar11;
                uVar13 = (iVar10 * iVar15 + uVar11) * 4;
                if ((int)uVar13 < local_298) {
                  lVar3 = this.mLetter;
                  if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  if (lVar3.randomDurations <= uVar11) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  lVar3 = *(int64 *)(lVar3 + 32 + lVar12 * 8);
                  if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  fVar16 = (float)FUN_1810a8ba0(fVar1 * fVar2 - lVar3.animationOrder,0,
                                                lVar3.overlap,0);
                  lVar3 = this.mLetter;
                  if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  if (lVar3.randomDurations <= uVar11) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  lVar3 = *(int64 *)(lVar3 + 32 + lVar12 * 8);
                  if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  if (*(int64 *)(this + 32) == 0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  uVar17 = AnimationCurve.Evaluate
                                     (*(int64 *)(this + 32),fVar16 / lVar3.overlap,0);
                  fVar16 = (float)uVar17;
                  puVar8 = (uint64 *)TweenLetters.GetCenter(local_150,verts,uVar13,4,0);
                  local_2b8 = *puVar8;
                  local_2b0 = *(float *)(puVar8 + 1);
                  lVar3 = this.mLetter;
                  if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  if (lVar3.randomDurations <= uVar11) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  lVar12 = *(int64 *)(lVar3 + 32 + lVar12 * 8);
                  if (lVar12 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  lVar3 = this.mCurrent;
                  if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  local_2c8 = lVar3.pos;
                  fStack_2c0 = *(float *)(lVar3 + 52);
                  fVar19 = (float)local_2c8 + lVar12.randomDurations;
                  fVar18 = (float)((uint64)local_2c8 >> 32) + lVar12.randomness;
                  fVar20 = fStack_2c0 + 0.0;
                  local_238 = fStack_2c0;
                  puVar8 = (uint64 *)Vector3.get_zero(local_140,0);
                  local_2c8 = *puVar8;
                  fStack_2c0 = *(float *)(puVar8 + 1);
                  local_258 = ((float)local_2c8 - fVar19) * fVar16 + fVar19;
                  fStack_254 = ((float)((uint64)local_2c8 >> 32) - fVar18) * fVar16 + fVar18;
                  local_250 = (fStack_2c0 - fVar20) * fVar16 + fVar20;
                  local_228 = fStack_2c0;
                  puVar8 = (uint64 *)Quaternion.get_identity(local_110,0);
                  local_2c8 = *puVar8;
                  fStack_2c0 = *(float *)(puVar8 + 1);
                  fStack_2bc = *(float *)((int64)puVar8 + 12);
                  local_2a8 = uVar9;
                  uStack_2a0 = uVar4;
                  puVar8 = (uint64 *)
                           Quaternion.SlerpUnclamped(local_100,&local_2a8,&local_2c8,uVar17,0);
                  uVar17 = *puVar8;
                  uVar5 = puVar8[1];
                  lVar12 = this.mCurrent;
                  if (lVar12 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  local_278 = lVar12.scale;
                  local_270 = *(float *)(lVar12 + 76);
                  puVar8 = (uint64 *)Vector3.get_one(local_130,0);
                  local_2c8 = *puVar8;
                  fStack_2c0 = *(float *)(puVar8 + 1);
                  local_268 = ((float)local_2c8 - (float)local_278) * fVar16 + (float)local_278;
                  fStack_264 = ((float)((uint64)local_2c8 >> 32) - local_278._4_4_) * fVar16 +
                               local_278._4_4_;
                  local_260 = (fStack_2c0 - local_270) * fVar16 + local_270;
                  local_218 = fStack_2c0;
                  if (this.mCurrent == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  fVar20 = (float)Mathf.LerpUnclamped
                                            (this.mCurrent.alpha,
                                             0x3f800000,fVar16,0);
                  local_208 = CONCAT44(fStack_264,local_268);
                  local_200 = local_260;
                  local_1f8 = CONCAT44(fStack_254,local_258);
                  local_1f0 = local_250;
                  local_2a8 = uVar17;
                  uStack_2a0 = uVar5;
                  Matrix4x4.SetTRS(&local_198,&local_1f8,&local_2a8,&local_208,0);
                  fVar19 = local_2b0;
                  fVar18 = local_2b8._4_4_;
                  fVar16 = (float)local_2b8;
                  for (uVar11 = uVar13; iVar15 = local_294, (int)uVar11 < (int)(uVar13 + 4);
                      uVar11 = uVar11 + 1) {
                    if (*(uint32 *)(verts + 24) <= uVar11) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar12 = (int64)(int)uVar11;
                    local_2c8 = *(uint64 *)(*(int64 *)(verts + 16) + 32 + lVar12 * 12);
                    fStack_2c0 = *(float *)(*(int64 *)(verts + 16) + 40 + lVar12 * 12);
                    local_1d0 = fStack_2c0 - fVar19;
                    local_1d8 = CONCAT44((float)((uint64)local_2c8 >> 32) - fVar18,
                                         (float)local_2c8 - fVar16);
                    local_1e0 = fStack_2c0;
                    local_1a0 = local_1d0;
                    puVar8 = (uint64 *)Matrix4x4.MultiplyPoint3x4(local_120,&local_198,&local_1d8,0);
                    local_2c8 = *puVar8;
                    fStack_2c0 = *(float *)(puVar8 + 1);
                    local_280 = fVar19 + fStack_2c0;
                    local_1b8 = CONCAT44(fVar18 + (float)((uint64)local_2c8 >> 32),
                                         (float)local_2c8 + fVar16);
                    local_1c0 = fStack_2c0;
                    local_1b0 = local_280;
                    FUN_181814c90(verts,uVar11,&local_1b8,DAT_181d844f8);
                    if (cols == null) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    if (*(uint32 *)(cols + 24) <= uVar11) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    puVar8 = (uint64 *)(*(int64 *)(cols + 16) + (lVar12 + 2) * 16);
                    local_2a8 = *puVar8;
                    local_2c8 = *puVar8;
                    fStack_2c0 = *(float *)(puVar8 + 1);
                    fStack_2bc = *(float *)((int64)puVar8 + 12) * fVar20;
                    uStack_2a0 = CONCAT44(fStack_2bc,fStack_2c0);
                    FUN_181814c20(cols,uVar11);
                  }
                }
              }
              iVar7 = local_290;
            }
          }
        }
    }

    // Token : 0x60005B2
    // RVA   : 0xA71680   Offset: 0xA6FE80   Length: 0x2A
    protected override void OnUpdate(float factor, bool isFinished)
    {
        plVar1 = this.mLabel;
        if (plVar1 != (int64 *)0) {
                          // WARNING: Could not recover jumptable at 0x000180a7169e. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*plVar1 + 0x328))(plVar1,*(uint64 *)(*plVar1 + 0x330));
          return;
        }
    }

    // Token : 0x60005B3
    // RVA   : 0xA71710   Offset: 0xA6FF10   Length: 0x38F
    private void SetLetterOrder(int letterCount)
    {
        ulong uVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        uint uVar8;
        uint uVar9;
        uint uVar10;
        uint uVar11;
        uint uVar12;
        puVar1 = &this.mLetter;
        plVar2 = &this.mLetterOrder;
        if (letterCount == null) {
          this.mLetter = 0;
          il2cpp_internal(puVar1,0);
          this.mLetterOrder = 0;
          il2cpp_internal(plVar2,0);
          return;
        }
        lVar4 = FUN_1800d60b0(DAT_181d7e600,(uint64)letterCount);
        this.mLetterOrder = lVar4;
        il2cpp_internal(plVar2,lVar4);
        uVar5 = FUN_1800d60b0(DAT_181d83740,letterCount);
        this.mLetter = uVar5;
        il2cpp_internal(puVar1,uVar5);
        uVar10 = 0;
        uVar8 = letterCount;
        if (0 < (int)letterCount) {
          do {
            uVar8 = uVar8 - 1;
            lVar4 = this.mLetterOrder;
            if (this.mCurrent == null) goto LAB_180a71a9a;
            uVar9 = uVar8;
            if (this.mCurrent.animationOrder != 1) {
              uVar9 = uVar10;
            }
            if (lVar4 == null) goto LAB_180a71a9a;
            if (*(uint32 *)(lVar4 + 24) <= uVar10) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            lVar4[uVar10] = uVar9;
            lVar4 = this.mLetterOrder;
            if (lVar4 == null) goto LAB_180a71a9a;
            if (*(uint32 *)(lVar4 + 24) <= uVar10) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            uVar9 = lVar4[uVar10];
            plVar7 = this.mLetter;
            lVar4 = new c.DisplayClass9_0(0);
            if (plVar7 == (int64 *)0) goto LAB_180a71a9a;
            if ((lVar4 != null) &&
               (lVar6 = il2cpp_internal(lVar4,*(uint64 *)(*plVar7 + 64))) == null) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            FUN_180002fd0(plVar7,(int64)(int)uVar9,lVar4);
            lVar4 = this.mLetter;
            if (lVar4 == null) goto LAB_180a71a9a;
            if (*(uint32 *)(lVar4 + 24) <= uVar9) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            lVar4 = lVar4[uVar9];
            if (this.mCurrent == null) goto LAB_180a71a9a;
            uVar9 = this.mCurrent.offsetRange;
            uVar11 = Random.Range(uVar9 ^ 0x80000000,uVar9,0);
            if ((this.mCurrent == null) ||
               (uVar9 = *(uint32 *)(this.mCurrent + 40),
               uVar12 = Random.Range(uVar9 ^ 0x80000000,uVar9,0), lVar4 == null)) goto LAB_180a71a9a;
            uVar10 = uVar10 + 1;
            *(uint32 *)(lVar4 + 24) = uVar11;
            *(uint32 *)(lVar4 + 28) = uVar12;
          } while ((int)uVar10 < (int)letterCount);
        }
        if (this.mCurrent == null) {
        LAB_180a71a9a:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (this.mCurrent.animationOrder == 2) {
          plVar7 = (int64 *)il2cpp_internal(DAT_181d74460);
          Random.ctor(plVar7,0);
          uVar3 = (uint64)letterCount;
          while (1 < (int)letterCount) {
            letterCount = (int)uVar3 - 1;
            if (plVar7 == (int64 *)0) goto LAB_180a71a9a;
            uVar8 = (**(code **)(*plVar7 + 0x198))(plVar7,uVar3,*(uint64 *)(*plVar7 + 0x1a0));
            lVar4 = this.mLetterOrder;
            if (lVar4 == null) goto LAB_180a71a9a;
            if (*(uint32 *)(lVar4 + 24) <= uVar8) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            uVar11 = lVar4[uVar8];
            if (*(uint32 *)(lVar4 + 24) <= letterCount) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            lVar4[uVar8] =
                 *(uint32 *)(lVar4 + 28 + uVar3 * 4);
            lVar4 = this.mLetterOrder;
            if (lVar4 == null) goto LAB_180a71a9a;
            if (*(uint32 *)(lVar4 + 24) <= letterCount) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
            *(uint32 *)(lVar4 + 28 + uVar3 * 4) = uVar11;
            uVar3 = (uint64)letterCount;
          }
        }
    }

    // Token : 0x60005B4
    // RVA   : 0xA70930   Offset: 0xA6F130   Length: 0x28C
    private void GetLetterDuration(int letterCount)
    {
        float fVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        uint uVar6;
        float fVar7;
        uint uVar8;
        float fVar9;
        float fVar10;
        float fVar11;
        lVar3 = this.mCurrent;
        if (lVar3 != null) {
          uVar6 = 0;
          if (!lVar3.randomDurations) {
            fVar9 = *(float *)(this + 48);
            fVar1 = lVar3.overlap;
            lVar3 = this.mLetter;
            fVar11 = 1.0 - fVar1;
            fVar7 = fVar9 / (float)letterCount;
            fVar10 = 0.0;
            if (lVar3 != null) {
              while( true ) {
                if (lVar3.randomDurations <= (int)uVar6) {
                  return;
                }
                lVar5 = this.mLetterOrder;
                if (lVar5 == null) break;
                if (*(uint32 *)(lVar5 + 24) <= uVar6) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                uVar2 = lVar5[uVar6];
                lVar5 = (int64)(int)uVar2;
                if (lVar3 == null) break;
                if (lVar3.randomDurations <= uVar2) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                lVar3 = *(int64 *)(lVar3 + 32 + lVar5 * 8);
                if (lVar3 == null) break;
                lVar3.animationOrder = fVar10;
                lVar3 = this.mLetter;
                if (lVar3 == null) break;
                if (lVar3.randomDurations <= uVar2) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                lVar3 = *(int64 *)(lVar3 + 32 + lVar5 * 8);
                if (lVar3 == null) break;
                lVar3.overlap =
                     (fVar9 * fVar7) / ((float)letterCount * fVar7 * fVar11 + fVar1 * fVar7);
                lVar3 = this.mLetter;
                if (lVar3 == null) break;
                if (lVar3.randomDurations <= uVar2) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                lVar5 = *(int64 *)(lVar3 + 32 + lVar5 * 8);
                if (lVar5 == null) break;
                uVar6 = uVar6 + 1;
                fVar10 = fVar10 + fVar11 * *(float *)(lVar5 + 20);
              }
            }
          }
          else {
            lVar3 = this.mLetter;
            if (lVar3 != null) {
              while( true ) {
                if (lVar3.randomDurations <= (int)uVar6) {
                  return;
                }
                if (lVar3 == null) break;
                if (lVar3.randomDurations <= uVar6) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                lVar3 = lVar3[uVar6];
                if ((this.mCurrent == null) ||
                   (uVar8 = Random.Range(0,*(float *)(this + 48) *
                                            this.mCurrent.randomness,0),
                   lVar3 == null)) break;
                lVar3.animationOrder = uVar8;
                if (this.mCurrent == null) break;
                fVar9 = (float)Random.Range(*(float *)(this + 48) *
                                             *(float *)(this.mCurrent + 32),
                                             *(float *)(this + 48),0);
                lVar3 = this.mLetter;
                if (lVar3 == null) break;
                if (lVar3.randomDurations <= uVar6) {
                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar4,0);
                }
                lVar3 = lVar3[uVar6];
                if (lVar3 == null) break;
                uVar6 = uVar6 + 1;
                lVar3.overlap = fVar9 - lVar3.animationOrder;
                lVar3 = this.mLetter;
                if (lVar3 == null) break;
              }
            }
          }
        }
    }

    // Token : 0x60005B5
    // RVA   : 0xA71700   Offset: 0xA6FF00   Length: 0xC
    private float ScaleRange(float value, float baseMax, float limitMax)
    {
        float FUN_180a71700(uint64 this,float value,float baseMax,float limitMax)
        {
        return (value * limitMax) / baseMax;
    }

    // Token : 0x60005B6
    // RVA   : 0xA707D0   Offset: 0xA6EFD0   Length: 0x15E
    private static Vector3 GetCenter(List<Vector3> verts, int firstVert, int length)
    {
        ulong uVar1;
        long lVar2;
        uint uVar3;
        float fVar4;
        float fVar5;
        float local_68;
        float fStack_64;
        if (firstVert != null) {
          if (*(uint32 *)(firstVert + 24) <= length) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar3 = length + 1;
          uVar1 = firstVert[length];
          fVar5 = *(float *)(*(int64 *)(firstVert + 16) + 40 + (int64)(int)length * 12);
          fStack_64 = (float)((uint64)uVar1 >> 32);
          local_68 = (float)uVar1;
          if ((int)uVar3 < (int)(length + param_4)) {
            lVar2 = (int64)(int)uVar3 * 12;
            do {
              if (*(uint32 *)(firstVert + 24) <= uVar3) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar1 = *(uint64 *)(*(int64 *)(firstVert + 16) + 32 + lVar2);
              fVar5 = fVar5 + *(float *)(*(int64 *)(firstVert + 16) + 40 + lVar2);
              local_68 = local_68 + (float)uVar1;
              uVar3 = uVar3 + 1;
              lVar2 = lVar2 + 12;
              fStack_64 = fStack_64 + (float)((uint64)uVar1 >> 32);
            } while ((int)uVar3 < (int)(length + param_4));
          }
          fVar4 = (float)param_4;
          *verts = CONCAT44(fStack_64 / fVar4,local_68 / fVar4);
          *(float *)(verts + 1) = fVar5 / fVar4;
          return verts;
        }
    }

    // Token : 0x60005B7
    // RVA   : 0xA71AA0   Offset: 0xA702A0   Length: 0x11
    public void /*ctor*/()
    {
        void FUN_180a71aa0(int64 this)
        {
        this.mVertexCount = 0xffffffff;
        UITweener.ctor(this,0);
    }

}
