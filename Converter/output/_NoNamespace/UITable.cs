// ============================================================
// Type  : UITable
// Token : 0x200006A
// ============================================================

public class UITable
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000285
    public int columns;

    // Token: 0x4000286
    public Direction direction;

    // Token: 0x4000287
    public Sorting sorting;

    // Token: 0x4000288
    public Pivot pivot;

    // Token: 0x4000289
    public Pivot cellAlignment;

    // Token: 0x400028A
    public bool hideInactive;

    // Token: 0x400028B
    public bool keepWithinPanel;

    // Token: 0x400028C
    public Vector2 padding;

    // Token: 0x400028D
    public OnReposition onReposition;

    // Token: 0x400028E
    public Comparison<Transform> onCustomSort;

    // Token: 0x400028F
    protected UIPanel mPanel;

    // Token: 0x4000290
    protected bool mInitDone;

    // Token: 0x4000291
    protected bool mReposition;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000272
    // RVA   : 0x16960B0   Offset: 0x16948B0   Length: 0x13
    public void set_repositionNow(bool value)
    {
        if (value) {
          this.mReposition = 1;
          Behaviour.set_enabled(this,1,0);
          return;
        }
    }

    // Token : 0x6000273
    // RVA   : 0x1694D90   Offset: 0x1693590   Length: 0x27E
    public List<Transform> GetChildList()
    {
        bool cVar1;
        int iVar2;
        long lVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        int iVar7;
        lVar3 = Component.get_transform(this,0);
        lVar4 = il2cpp_internal(DAT_181d734b0);
        FUN_180f58a90(lVar4,DAT_181d80278);
        iVar7 = 0;
        if (lVar3 == null) throw; // [null/range check failed]
        for (; iVar2 = Transform.get_childCount(lVar3,0), iVar7 < iVar2; iVar7 = iVar7 + 1) {
          lVar5 = Transform.GetChild(lVar3,iVar7,0);
          if (*(char *)((int64)this + 44) == false) {
        LAB_181694f17:
            if (lVar4 == null) throw; // [null/range check failed]
            FUN_181827900(lVar4);
          }
          else {
            cVar1 = Object.op_Implicit(lVar5);
            if (cVar1) {
              if (lVar5 == null) throw; // [null/range check failed]
              uVar6 = Component.get_gameObject(lVar5);
              cVar1 = NGUITools.GetActive(uVar6);
              if (cVar1) goto LAB_181694f17;
            }
          }
        }
        iVar7 = (int)this[4];
        if (iVar7 == 0) {
          return lVar4;
        }
        if (iVar7 == 1) {
          lVar3 = il2cpp_internal(DAT_181d59ac8);
          uVar6 = DAT_181d9c9e8;
        LAB_181694fc2:
          OnTooltipCB.ctor(lVar3,0,uVar6,DAT_181d86498);
        }
        else {
          if (iVar7 == 2) {
            lVar3 = il2cpp_internal(DAT_181d59ac8);
            uVar6 = DAT_181d9ca70;
            goto LAB_181694fc2;
          }
          if (iVar7 == 3) {
            lVar3 = il2cpp_internal(DAT_181d59ac8);
            uVar6 = DAT_181d9caf8;
            goto LAB_181694fc2;
          }
          lVar3 = this[8];
          if (lVar3 == null) {
            (**(code **)(*this + 0x178))(this,lVar4,*(uint64 *)(*this + 0x180));
            return lVar4;
          }
        }
        if (lVar4 != null) {
          List_1.Sort(lVar4,lVar3,DAT_181d805f8);
          return lVar4;
        }
    }

    // Token : 0x6000274
    // RVA   : 0x1695F90   Offset: 0x1694790   Length: 0x9A
    protected virtual void Sort(List<Transform> list)
    {
        ulong uVar1;
        uVar1 = new OnTooltipCB(0,DAT_181d9c9e8,DAT_181d86498);
        if (list != null) {
          List_1.Sort(list,uVar1,DAT_181d805f8);
          return;
        }
    }

    // Token : 0x6000275
    // RVA   : 0x1696030   Offset: 0x1694830   Length: 0x3E
    protected virtual void Start()
    {
        (**(code **)(*this + 0x198))(this,*(uint64 *)(*this + 0x1a0));
        (**(code **)(*this + 0x1b8))(this,*(uint64 *)(*this + 0x1c0));
        Behaviour.set_enabled(this,0,0);
    }

    // Token : 0x6000276
    // RVA   : 0x1695010   Offset: 0x1693810   Length: 0x8C
    protected virtual void Init()
    {
        ulong uVar1;
        this.mInitDone = 1;
        uVar1 = Component.get_gameObject(this,0);
        uVar1 = NGUITools.FindInParents(uVar1,DAT_181d66900);
        this.mPanel = uVar1;
    }

    // Token : 0x6000277
    // RVA   : 0x16950A0   Offset: 0x16938A0   Length: 0x31
    protected virtual void LateUpdate()
    {
        if (*(char *)((int64)this + 81) != false) {
          (**(code **)(*this + 0x1b8))(this,*(uint64 *)(*this + 0x1c0));
        }
        Behaviour.set_enabled(this,0,0);
    }

    // Token : 0x6000278
    // RVA   : 0x16950E0   Offset: 0x16938E0   Length: 0x7B
    private void OnValidate()
    {
        bool cVar1;
        cVar1 = Application.get_isPlaying(0);
        if (!cVar1) {
          cVar1 = NGUITools.GetActive(this,0);
          if (cVar1) {
                          // WARNING: Could not recover jumptable at 0x00018169514e. Too many branches
                          // WARNING: Treating indirect jump as call
            (**(code **)(*this + 0x1b8))(this,*(uint64 *)(*this + 0x1c0));
            return;
          }
        }
    }

    // Token : 0x6000279
    // RVA   : 0x1695160   Offset: 0x1693960   Length: 0xC64
    protected void RepositionVariableSize(List<Transform> children)
    {
        float fVar1;
        float fVar2;
        float fVar3;
        ulong uVar4;
        ulong uVar5;
        ulong uVar6;
        ulong uVar7;
        float fVar8;
        bool cVar9;
        int iVar10;
        long lVar11;
        long lVar12;
        long lVar13;
        long lVar17;
        ulong uVar18;
        long lVar19;
        ulong uVar21;
        uint uVar22;
        long lVar23;
        uint uVar24;
        int iVar25;
        uint uVar26;
        uint uVar27;
        uint uVar28;
        float fVar29;
        float fVar30;
        float fVar31;
        float fVar32;
        uint32 uStackX_c;
        int64 local_res20;
        int64 local_348;
        uint64 local_338;
        uint64 local_328;
        float local_320;
        uint64 local_318;
        float local_310;
        uint64 local_308;
        uint64 uStack_300;
        uint64 local_2f8;
        uint32 local_2f0;
        uint32 uStack_2ec;
        uint32 uStack_2e8;
        uint32 uStack_2e4;
        uint64 local_2e0;
        int64 local_2d8;
        int64 local_2d0;
        int64 local_2c8;
        float local_2c0;
        uint64 local_2b8;
        uint64 uStack_2b0;
        uint64 local_2a8;
        uint64 local_298;
        float local_290;
        uint64 local_288;
        float local_280;
        int64 local_278;
        float local_270;
        uint32 local_268;
        uint32 uStack_264;
        uint32 uStack_260;
        uint32 uStack_25c;
        uint64 local_258;
        uint64 local_248;
        uint64 uStack_240;
        uint64 local_238;
        uint8 local_230 [8];
        float local_228;
        uint64 local_220;
        uint64 uStack_218;
        uint64 local_210;
        uint32 local_208;
        uint32 uStack_204;
        uint32 uStack_200;
        uint32 uStack_1fc;
        uint64 local_1f8;
        int64 local_1e8;
        int64 local_1e0;
        uint8 local_1d0 [16];
        uint8 local_1c0 [16];
        uint8 local_1b0 [16];
        uint8 local_1a0 [16];
        uint8 local_190 [16];
        uint8 local_180 [16];
        uint8 local_170 [16];
        uint8 local_160 [16];
        uint8 local_150 [16];
        uint8 local_140 [16];
        uint8 local_130 [16];
        uint8 local_120 [24];
        uint8 local_108 [16];
        uint8 local_f8 [16];
        uint8 local_e8 [176];
        iVar10 = this.columns;
        fVar31 = 0.0;
        fVar32 = 0.0;
        local_2e0 = 0;
        local_2f8 = 0;
        local_238 = 0;
        local_2a8 = 0;
        local_210 = 0;
        local_2f0 = 0;
        uStack_2ec = 0;
        uStack_2e8 = 0;
        uStack_2e4 = 0;
        local_308 = 0;
        uStack_300 = 0;
        local_248 = 0;
        uStack_240 = 0;
        local_2b8 = 0;
        uStack_2b0 = 0;
        local_220 = 0;
        uStack_218 = 0;
        if (iVar10 < 1) {
          iVar25 = 1;
          if (children == null) goto LAB_181695dbf;
          iVar10 = *(int *)(children + 24);
        }
        else {
          if (children == null) goto LAB_181695dbf;
          iVar25 = *(int *)(children + 24) / iVar10 + 1;
        }
        local_1e8 = (int64)iVar25;
        local_1e0 = (int64)iVar10;
        lVar11 = FUN_1800d6020(DAT_181d847c0,&local_1e8);
        lVar12 = FUN_1800d60b0(DAT_181d7bd20,iVar10);
        lVar13 = FUN_1800d60b0(DAT_181d7bd20,iVar25);
        uVar26 = 0;
        uVar27 = 0;
        if (children == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        local_2d8 = 32;
        if (0 < *(int *)(children + 24)) {
          local_338 = 0;
          local_res20 = 32;
          uVar24 = uVar26;
          uVar28 = uVar26;
          local_2d0 = (int64)*(int *)(children + 24);
          uVar22 = uVar27;
          do {
            if (*(uint32 *)(children + 24) <= uVar22) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar17 = *(int64 *)(local_res20 + *(int64 *)(children + 16));
            puVar14 = (uint32 *)
                      NGUIMath.CalculateRelativeWidgetBounds
                                (local_120,lVar17,
                                 CONCAT71((int7)((uint64)local_res20 >> 8),
                                          !this.hideInactive),0);
            local_2f0 = *puVar14;
            uStack_2ec = puVar14[1];
            uStack_2e8 = puVar14[2];
            uStack_2e4 = puVar14[3];
            local_2e0 = *(uint64 *)(puVar14 + 4);
            if (lVar17 == null) goto LAB_181695dbf;
            plVar15 = (int64 *)Transform.get_localScale(local_1b0,lVar17,0);
            local_2c0 = *(float *)(plVar15 + 1);
            lVar17 = *plVar15;
            fVar30 = (float)((uint64)lVar17 >> 32);
            local_270 = local_2c0;
            puVar16 = (uint64 *)Bounds.get_min(local_1c0,&local_2f0,0);
            local_318 = *puVar16;
            local_310 = *(float *)(puVar16 + 1);
            local_290 = local_310 * local_2c0;
            local_298 = CONCAT44((float)((uint64)local_318 >> 32) * fVar30,
                                 (float)local_318 * (float)lVar17);
            local_2c8 = lVar17;
            local_228 = local_290;
            Bounds.set_min(&local_2f0,&local_298,0);
            puVar16 = (uint64 *)Bounds.get_max(local_1d0,&local_2f0,0);
            local_288 = *puVar16;
            local_280 = *(float *)(puVar16 + 1);
            local_320 = local_280 * local_270;
            local_328 = CONCAT44(fVar30 * (float)((uint64)local_288 >> 32),
                                 (float)local_288 * (float)lVar17);
            local_278 = lVar17;
            Bounds.set_max(&local_2f0,&local_328,0);
            if (lVar11 == null) goto LAB_181695dbf;
            if (**(uint32 **)(lVar11 + 16) <= uVar28) {
              uVar21 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar21,0);
            }
            lVar17 = *(int64 *)(*(uint32 **)(lVar11 + 16) + 4);
            if ((uint32)lVar17 <= uVar24) {
              uVar21 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar21,0);
            }
            lVar17 = lVar17 * (int)uVar28 + (int64)(int)uVar24;
            puVar14 = (uint32 *)(lVar11 + 32 + lVar17 * 24);
            *puVar14 = local_2f0;
            puVar14[1] = uStack_2ec;
            puVar14[2] = uStack_2e8;
            puVar14[3] = uStack_2e4;
            *(uint64 *)(lVar11 + 48 + lVar17 * 24) = local_2e0;
            if (lVar12 == null) goto LAB_181695dbf;
            local_268 = local_2f0;
            uStack_264 = uStack_2ec;
            uStack_260 = uStack_2e8;
            uStack_25c = uStack_2e4;
            local_258 = local_2e0;
            if (*(uint32 *)(lVar12 + 24) <= uVar24) {
              uVar21 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar21,0);
            }
            Bounds.Encapsulate(lVar12 + (int64)(int)uVar24 * 24 + 32,&local_268,0);
            if (lVar13 == null) goto LAB_181695dbf;
            local_208 = local_2f0;
            uStack_204 = uStack_2ec;
            uStack_200 = uStack_2e8;
            uStack_1fc = uStack_2e4;
            local_1f8 = local_2e0;
            if (*(uint32 *)(lVar13 + 24) <= uVar28) {
              uVar21 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar21,0);
            }
            Bounds.Encapsulate(lVar13 + ((int64)(int)uVar28 * 3 + 4) * 8,&local_208,0);
            uVar24 = uVar24 + 1;
            if ((this.columns <= (int)uVar24) && (0 < this.columns)) {
              uVar24 = 0;
              uVar28 = uVar28 + 1;
            }
            uVar22 = uVar22 + 1;
            local_338 = local_338 + 1;
            local_res20 = local_res20 + 8;
          } while (local_338 < local_2d0);
        }
        uVar24 = 0;
        uVar18 = NGUIMath.GetPivotOffset(this.cellAlignment,0);
        if (0 < *(int *)(children + 24)) {
          local_338._4_4_ = (uint32)(uVar18 >> 32);
          lVar17 = 32;
          local_348 = 0;
          local_2c8 = (int64)*(int *)(children + 24);
          uVar28 = uVar27;
          do {
            if (*(uint32 *)(children + 24) <= uVar28) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              lVar17 = local_2d8;
            }
            local_2d0 = *(int64 *)(lVar17 + *(int64 *)(children + 16));
            if (lVar11 == null) goto LAB_181695dbf;
            lVar17 = (int64)(int)uVar24;
            lVar23 = (int64)(int)uVar26;
            if (**(uint32 **)(lVar11 + 16) <= uVar24) {
              uVar21 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar21,0);
            }
            lVar19 = *(int64 *)(*(uint32 **)(lVar11 + 16) + 4);
            if ((uint32)lVar19 <= uVar26) {
              uVar21 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar21,0);
            }
            lVar19 = lVar19 * lVar17 + lVar23;
            puVar16 = (uint64 *)(lVar11 + 32 + lVar19 * 24);
            local_308 = *puVar16;
            uStack_300 = puVar16[1];
            local_2f8 = *(uint64 *)(lVar11 + 48 + lVar19 * 24);
            if (lVar12 == null) goto LAB_181695dbf;
            if (*(uint32 *)(lVar12 + 24) <= uVar26) {
              uVar21 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar21,0);
            }
            puVar16 = (uint64 *)(lVar12 + 32 + lVar23 * 24);
            local_248 = *puVar16;
            uStack_240 = puVar16[1];
            local_238 = *(uint64 *)(lVar12 + 48 + lVar23 * 24);
            if (lVar13 == null) goto LAB_181695dbf;
            if (*(uint32 *)(lVar13 + 24) <= uVar24) {
              uVar21 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar21,0);
            }
            puVar16 = (uint64 *)(lVar13 + 32 + lVar17 * 24);
            local_2b8 = *puVar16;
            uStack_2b0 = puVar16[1];
            local_2a8 = *(uint64 *)(lVar13 + 48 + lVar17 * 24);
            if (local_2d0 == 0) goto LAB_181695dbf;
            puVar16 = (uint64 *)Transform.get_localPosition(local_1d0,local_2d0,0);
            local_318 = *puVar16;
            fVar8 = *(float *)(puVar16 + 1);
            pfVar20 = (float *)FUN_18045e080(local_1c0,&local_308,0);
            fVar30 = *pfVar20;
            pfVar20 = (float *)FUN_18045e0a0(local_1b0,&local_308,0);
            fVar1 = *pfVar20;
            pfVar20 = (float *)Bounds.get_max(local_230,&local_308,0);
            fVar29 = *pfVar20;
            pfVar20 = (float *)Bounds.get_min(&local_278,&local_308,0);
            fVar2 = *pfVar20;
            pfVar20 = (float *)Bounds.get_max(&local_288,&local_248,0);
            fVar3 = *pfVar20;
            pfVar20 = (float *)Bounds.get_min(&local_298,&local_248,0);
            fVar29 = (float)Mathf.Lerp(0,((fVar29 - fVar2) - fVar3) + *pfVar20,uVar18 & 0xffffffff,0);
            local_318 = CONCAT44(local_318._4_4_,
                                 ((fVar30 + fVar31) - fVar1) - (fVar29 - this.padding));
            if (this.direction == null) {
              puVar16 = (uint64 *)FUN_18045e080(local_170,&local_308,0);
              uVar21 = *puVar16;
              puVar16 = (uint64 *)FUN_18045e0a0(local_160,&local_308,0);
              uVar4 = *puVar16;
              puVar16 = (uint64 *)Bounds.get_max(local_150,&local_308,0);
              uVar5 = *puVar16;
              puVar16 = (uint64 *)Bounds.get_min(local_140,&local_308,0);
              uVar6 = *puVar16;
              puVar16 = (uint64 *)Bounds.get_max(local_130,&local_2b8,0);
              uVar7 = *puVar16;
              puVar16 = (uint64 *)Bounds.get_min(local_120,&local_2b8,0);
              fVar30 = (float)Mathf.Lerp((((float)((uint64)uVar5 >> 32) -
                                           (float)((uint64)uVar6 >> 32)) -
                                          (float)((uint64)uVar7 >> 32)) +
                                          (float)((uint64)*puVar16 >> 32),0,local_338._4_4_,0,
                                          *puVar16);
              local_318 = CONCAT44(((-fVar32 - (float)((uint64)uVar21 >> 32)) -
                                   (float)((uint64)uVar4 >> 32)) +
                                   (fVar30 - *(float *)(this + 52)),(uint32)local_318);
            }
            else {
              puVar16 = (uint64 *)FUN_18045e080(local_f8,&local_308);
              uVar21 = *puVar16;
              puVar16 = (uint64 *)FUN_18045e0a0(local_108,&local_308,0);
              uVar4 = *puVar16;
              puVar16 = (uint64 *)Bounds.get_max(local_e8,&local_308,0);
              uVar5 = *puVar16;
              puVar16 = (uint64 *)Bounds.get_min(local_1a0,&local_308,0);
              uVar6 = *puVar16;
              puVar16 = (uint64 *)Bounds.get_max(local_190,&local_2b8,0);
              uVar7 = *puVar16;
              puVar16 = (uint64 *)Bounds.get_min(local_180,&local_2b8,0);
              fVar30 = (float)Mathf.Lerp(0,(((float)((uint64)uVar5 >> 32) -
                                             (float)((uint64)uVar6 >> 32)) -
                                            (float)((uint64)uVar7 >> 32)) +
                                            (float)((uint64)*puVar16 >> 32),local_338._4_4_,0,
                                          *puVar16);
              local_318 = CONCAT44((((float)((uint64)uVar21 >> 32) + fVar32) -
                                   (float)((uint64)uVar4 >> 32)) -
                                   (fVar30 - *(float *)(this + 52)),(uint32)local_318);
            }
            pfVar20 = (float *)Bounds.get_size(&local_208,&local_248,0);
            fVar31 = fVar31 + this.padding + this.padding + *pfVar20;
            local_328 = local_318;
            local_320 = fVar8;
            Transform.set_localPosition(local_2d0,&local_328,0);
            uVar26 = uVar26 + 1;
            if ((this.columns <= (int)uVar26) && (0 < this.columns)) {
              uVar24 = uVar24 + 1;
              uVar26 = 0;
              fVar31 = 0.0;
              puVar16 = (uint64 *)Bounds.get_size(&local_268,&local_2b8,0);
              fVar32 = fVar32 + *(float *)(this + 52) + *(float *)(this + 52) +
                                (float)((uint64)*puVar16 >> 32);
            }
            uVar28 = uVar28 + 1;
            local_348 = local_348 + 1;
            lVar17 = local_2d8 + 8;
            local_2d8 = lVar17;
          } while (local_348 < local_2c8);
        }
        if (this.pivot != null) {
          uVar18 = NGUIMath.GetPivotOffset(this.pivot,0);
          uVar21 = Component.get_transform(this,0);
          puVar16 = (uint64 *)NGUIMath.CalculateRelativeWidgetBounds(&local_1e8,uVar21,0);
          local_220 = *puVar16;
          uStack_218 = puVar16[1];
          local_210 = puVar16[2];
          puVar14 = (uint32 *)Bounds.get_size(&local_268,&local_220,0);
          fVar31 = (float)Mathf.Lerp(0,*puVar14,uVar18 & 0xffffffff,0);
          puVar16 = (uint64 *)Bounds.get_size(&local_268,&local_220,0);
          uStackX_c = (uint32)(uVar18 >> 32);
          fVar32 = (float)Mathf.Lerp((uint32)((uint64)*puVar16 >> 32) ^ 0x80000000,0,uStackX_c,0,
                                      *puVar16);
          lVar11 = Component.get_transform(this,0);
          if (lVar11 == null) {
        LAB_181695dbf:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          while (iVar10 = Transform.get_childCount(lVar11,0), (int)uVar27 < iVar10) {
            lVar12 = Transform.GetChild(lVar11,uVar27,0);
            if (lVar12 == null) goto LAB_181695dbf;
            lVar13 = Component.GetComponent(lVar12,DAT_181d6d4c0);
            cVar9 = Object.op_Inequality(lVar13,0);
            if (!cVar9) {
              puVar16 = (uint64 *)Transform.get_localPosition(&local_268,lVar12);
              local_320 = *(float *)(puVar16 + 1);
              local_328 = CONCAT44((float)((uint64)*puVar16 >> 32) - fVar32,(float)*puVar16 - fVar31)
              ;
              Transform.set_localPosition(lVar12);
              uVar27 = uVar27 + 1;
            }
            else {
              if (lVar13 == null) goto LAB_181695dbf;
              Behaviour.set_enabled(lVar13,0);
              *(float *)(lVar13 + 24) = *(float *)(lVar13 + 24) - fVar31;
              *(float *)(lVar13 + 28) = *(float *)(lVar13 + 28) - fVar32;
              Behaviour.set_enabled(lVar13);
              uVar27 = uVar27 + 1;
            }
          }
        }
    }

    // Token : 0x600027A
    // RVA   : 0x1695DD0   Offset: 0x16945D0   Length: 0x1B8
    public virtual void Reposition()
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        cVar1 = Application.get_isPlaying(0);
        if ((cVar1) && ((char)this[10] == false)) {
          cVar1 = NGUITools.GetActive(this,0);
          if (cVar1) {
            (**(code **)(*this + 0x198))(this,*(uint64 *)(*this + 0x1a0));
          }
        }
        *(uint8 *)((int64)this + 81) = 0;
        uVar2 = Component.get_transform(this,0);
        lVar3 = UITable.GetChildList(this,0);
        if (lVar3 == null) goto LAB_181695f83;
        if (0 < *(int *)(lVar3 + 24)) {
          UITable.RepositionVariableSize(this,lVar3,0);
        }
        if (*(char *)((int64)this + 45) != false) {
          lVar3 = this[9];
          cVar1 = Object.op_Inequality(lVar3,0,0);
          if (cVar1) {
            if (this[9] != 0) {
              UIPanel.ConstrainTargetToBounds(this[9],uVar2,1,0);
              if (this[9] != 0) {
                plVar4 = (int64 *)Component.GetComponent(this[9],DAT_181d6e540);
                cVar1 = Object.op_Inequality(plVar4,0,0);
                if (cVar1) {
                  if (plVar4 == (int64 *)0) goto LAB_181695f83;
                  (**(code **)(*plVar4 + 0x1b8))(plVar4,1,*(uint64 *)(*plVar4 + 0x1c0));
                }
                goto LAB_181695f63;
              }
            }
        LAB_181695f83:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        LAB_181695f63:
        if (this[7] != 0) {
          OnGeometryUpdated.Invoke(this[7],0);
        }
    }

    // Token : 0x600027B
    // RVA   : 0x1696070   Offset: 0x1694870   Length: 0x3E
    public void /*ctor*/()
    {
        ulong uVar1;
        uint local_res8;
        uint32 uStackX_c;
        this.hideInactive = 1;
        uVar1 = Vector2.get_zero(0);
        local_res8 = (uint32)uVar1;
        uStackX_c = (uint32)((uint64)uVar1 >> 32);
        this.padding = local_res8;
        *(uint32 *)(this + 52) = uStackX_c;
        TrailRenderer_Base.ctor(this,0);
    }

}
