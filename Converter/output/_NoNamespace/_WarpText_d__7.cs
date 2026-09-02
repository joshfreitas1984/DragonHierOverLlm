// ============================================================
// Type  : <WarpText>d__7
// Token : 0x20003F3
// ============================================================

public class <WarpText>d__7
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001E71
    private int <>1__state;

    // Token: 0x4001E72
    private object <>2__current;

    // Token: 0x4001E73
    public SkewTextExample <>4__this;

    // Token: 0x4001E74
    private float <old_CurveScale>5__2;

    // Token: 0x4001E75
    private float <old_ShearValue>5__3;

    // Token: 0x4001E76
    private AnimationCurve <old_curve>5__4;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600243C
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x600243D
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x600243E
    // RVA   : 0xB16480   Offset: 0xB14C80   Length: 0xF5E
    private virtual bool MoveNext()
    {
        long lVar1;
        long lVar2;
        float fVar3;
        uint uVar4;
        long lVar5;
        long lVar7;
        ulong uVar8;
        long lVar9;
        ulong uVar10;
        long lVar13;
        int iVar14;
        long lVar15;
        long lVar16;
        uint uVar17;
        uint uVar18;
        long lVar19;
        uint uVar20;
        float fVar21;
        float fVar22;
        float fVar23;
        float fVar24;
        float fVar25;
        uint uVar26;
        float fVar27;
        uint local_res18;
        ulong local_478;
        ulong uStack_470;
        ulong local_468;
        uint local_460;
        int local_458;
        long local_450;
        uint local_448;
        float local_444;
        uint local_440;
        byte[] local_438 = new byte[8];
        float local_430;
        ulong local_428;
        ulong uStack_420;
        ulong local_418;
        float local_408;
        float local_3f8;
        float local_3e8;
        float local_3d8;
        float local_3c8;
        float local_3b8;
        float local_3a8;
        uint64 local_398;
        uint32 local_390;
        uint64 local_388;
        uint32 local_380;
        float local_370;
        uint64 local_368;
        uint32 local_360;
        uint64 local_358;
        uint32 local_350;
        uint64 local_348;
        uint32 local_340;
        uint64 local_338;
        uint32 local_330;
        float local_320;
        float local_310;
        float local_300;
        float local_2f0;
        uint64 local_2e8;
        uint32 local_2e0;
        float local_2d0;
        float local_2c0;
        uint64 local_2b8;
        uint64 uStack_2b0;
        uint64 local_2a8;
        uint64 uStack_2a0;
        uint64 local_298;
        uint64 uStack_290;
        uint64 local_288;
        uint64 uStack_280;
        float local_270;
        float local_260;
        float local_250;
        float local_240;
        float local_230;
        float local_220;
        uint32 local_210;
        uint32 local_200;
        float local_1f0;
        float local_1e0;
        float local_1d0;
        float local_1c0;
        float local_1b0;
        uint8 local_1a8 [24];
        uint8 local_190 [16];
        uint8 local_180 [16];
        uint8 local_170 [16];
        uint8 local_160 [16];
        uint8 local_150 [16];
        uint8 local_140 [16];
        uint8 local_130 [16];
        uint8 local_120 [232];
        lVar5 = this.<>4__this;
        iVar14 = this.<>1__state;
        local_418 = 0;
        local_468 = 0;
        local_460 = 0;
        local_2b8 = 0;
        uStack_2b0 = 0;
        local_2a8 = 0;
        uStack_2a0 = 0;
        local_298 = 0;
        uStack_290 = 0;
        local_288 = 0;
        uStack_280 = 0;
        local_428 = 0;
        uStack_420 = 0;
        if (iVar14 == 0) {
          this.<>1__state = 0xffffffff;
          if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
          AnimationCurve.set_preWrapMode(*(int64 *)(lVar5 + 32),1);
          if (*(int64 *)(lVar5 + 32) == 0) throw; // [null/range check failed]
          AnimationCurve.set_postWrapMode(*(int64 *)(lVar5 + 32),1);
          if (*(int64 *)(lVar5 + 24) == 0) throw; // [null/range check failed]
          TMP_Text.set_havePropertiesChanged(*(int64 *)(lVar5 + 24),1,0);
          fVar21 = *(float *)(lVar5 + 40) * 10.0;
          *(float *)(lVar5 + 40) = fVar21;
          this.<old_CurveScale>5__2 = fVar21;
          this.<old_ShearValue>5__3 = *(uint32 *)(lVar5 + 44);
          uVar10 = SkewTextExample.CopyAnimationCurve(lVar5,*(uint64 *)(lVar5 + 32),0);
          this.<old_curve>5__4 = uVar10;
        }
        else {
          if ((iVar14 != 1) && (iVar14 != 2)) {
            return false;
          }
          this.<>1__state = 0xffffffff;
        }
        do {
          if ((lVar5 == null) || (*(int64 *)(lVar5 + 24) == 0)) throw; // [null/range check failed]
          if ((*(char *)(*(int64 *)(lVar5 + 24) + 0x370) == false) &&
             (this.<old_CurveScale>5__2 == *(float *)(lVar5 + 40))) {
            if ((this.<old_curve>5__4 == 0) ||
               (lVar9 = FUN_181092110(this.<old_curve>5__4,0)) == null) throw; // [null/range check failed]
            if (*(uint32 *)(lVar9 + 24) < 2) {
              uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar10,0);
            }
            fVar21 = (float)FUN_18044df60(lVar9 + 60,0);
            if ((*(int64 *)(lVar5 + 32) == 0) ||
               (lVar9 = FUN_181092110(*(int64 *)(lVar5 + 32),0)) == null) throw; // [null/range check failed]
            if (*(uint32 *)(lVar9 + 24) < 2) {
              uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar10,0);
            }
            fVar22 = (float)FUN_18044df60(lVar9 + 60,0);
            if ((fVar21 == fVar22) && (this.<old_ShearValue>5__3 == *(float *)(lVar5 + 44))) {
              this.<>2__current = 0;
              this.<>1__state = 1;
              return true;
            }
          }
          this.<old_CurveScale>5__2 = *(uint32 *)(lVar5 + 40);
          uVar10 = SkewTextExample.CopyAnimationCurve(lVar5,*(uint64 *)(lVar5 + 32),0);
          this.<old_curve>5__4 = uVar10;
          this.<old_ShearValue>5__3 = *(uint32 *)(lVar5 + 44);
          plVar6 = *(int64 **)(lVar5 + 24);
          if (plVar6 == (int64 *)0) throw; // [null/range check failed]
          (**(code **)(*plVar6 + 0x7d8))(plVar6,0,0,*(uint64 *)(*plVar6 + 0x7e0));
          lVar9 = *(int64 *)(lVar5 + 24);
          if ((lVar9 == null) || (lVar13 = *(int64 *)(lVar9 + 0x368), local_450 = lVar13) == null)
          throw; // [null/range check failed]
          iVar14 = *(int *)(lVar13 + 24);
          local_458 = iVar14;
        } while (iVar14 == 0);
        puVar11 = (uint64 *)TMP_Text.get_bounds(local_1a8,lVar9,0);
        local_428 = *puVar11;
        uStack_420 = puVar11[1];
        local_418 = puVar11[2];
        pfVar12 = (float *)Bounds.get_min(local_438,&local_428,0);
        fVar21 = *pfVar12;
        if (*(int64 *)(lVar5 + 24) != 0) {
          puVar11 = (uint64 *)TMP_Text.get_bounds(local_1a8,*(int64 *)(lVar5 + 24),0);
          local_428 = *puVar11;
          uStack_420 = puVar11[1];
          local_418 = puVar11[2];
          pfVar12 = (float *)Bounds.get_max(local_438,&local_428,0);
          local_res18 = 0;
          fVar22 = *pfVar12;
          if (0 < iVar14) {
            do {
              lVar9 = *(int64 *)(lVar13 + 56);
              if (lVar9 == null) throw; // [null/range check failed]
              if (*(uint32 *)(lVar9 + 24) <= local_res18) {
                uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar10,0);
              }
              lVar15 = (int64)(int)local_res18 * 0x178;
              if (*(char *)(lVar15 + 0x194 + lVar9) != false) {
                lVar13 = *(int64 *)(lVar13 + 96);
                uVar4 = *(uint32 *)(lVar15 + 108 + lVar9);
                lVar16 = (int64)(int)uVar4;
                if (lVar13 == null) throw; // [null/range check failed]
                uVar17 = *(uint32 *)(lVar15 + 88 + lVar9);
                if (*(uint32 *)(lVar13 + 24) <= uVar17) {
                  uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar10,0);
                }
                lVar13 = *(int64 *)(lVar13 + 48 + (int64)(int)uVar17 * 80);
                if (lVar13 == null) throw; // [null/range check failed]
                if (*(uint32 *)(lVar13 + 24) <= uVar4) {
                  uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar10,0);
                }
                uVar17 = (uint32)(lVar16 + 2);
                if (*(uint32 *)(lVar13 + 24) <= uVar17) {
                  uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar10,0);
                }
                fVar3 = *(float *)(lVar15 + 0x14c + lVar9);
                fVar27 = (*(float *)(lVar13 + 32 + (lVar16 + 2) * 12) +
                         *(float *)(lVar13 + 32 + lVar16 * 12)) * 0.5;
                fVar24 = -fVar27;
                fVar23 = -fVar3;
                local_478 = *(uint64 *)(lVar13 + 32 + lVar16 * 12);
                local_2d0 = *(float *)(lVar13 + 40 + lVar16 * 12);
                local_1c0 = local_2d0 + -0.0;
                uVar26 = (uint32)((uint64)uStack_470 >> 32);
                uStack_470 = CONCAT44(uVar26,local_2d0);
                lVar1 = lVar16 + 1;
                *(uint64 *)(lVar13 + 32 + lVar16 * 12) =
                     CONCAT44(fVar23 + (float)((uint64)local_478 >> 32),(float)local_478 + fVar24);
                *(float *)(lVar13 + 40 + lVar16 * 12) = local_1c0;
                uVar20 = (uint32)lVar1;
                if (*(uint32 *)(lVar13 + 24) <= uVar20) {
                  uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar10,0);
                }
                local_478 = *(uint64 *)(lVar13 + 32 + lVar1 * 12);
                local_2c0 = *(float *)(lVar13 + 40 + lVar1 * 12);
                local_1b0 = local_2c0 + -0.0;
                uStack_470 = CONCAT44(uVar26,local_2c0);
                lVar2 = lVar16 + 2;
                *(uint64 *)(lVar13 + 32 + lVar1 * 12) =
                     CONCAT44(fVar23 + (float)((uint64)local_478 >> 32),(float)local_478 + fVar24);
                *(float *)(lVar13 + 40 + lVar1 * 12) = local_1b0;
                if (*(uint32 *)(lVar13 + 24) <= uVar17) {
                  uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar10,0);
                }
                local_478 = *(uint64 *)(lVar13 + 32 + lVar2 * 12);
                local_408 = *(float *)(lVar13 + 40 + lVar2 * 12);
                local_270 = local_408 + -0.0;
                uStack_470 = CONCAT44(uVar26,local_408);
                lVar19 = lVar16 + 3;
                *(uint64 *)(lVar13 + 32 + lVar2 * 12) =
                     CONCAT44(fVar23 + (float)((uint64)local_478 >> 32),(float)local_478 + fVar24);
                *(float *)(lVar13 + 40 + lVar2 * 12) = local_270;
                uVar17 = (uint32)lVar19;
                if (*(uint32 *)(lVar13 + 24) <= uVar17) {
                  uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar10,0);
                }
                local_478 = *(uint64 *)(lVar13 + 32 + lVar19 * 12);
                local_3f8 = *(float *)(lVar13 + 40 + lVar19 * 12);
                local_260 = local_3f8 + -0.0;
                uStack_470 = CONCAT44(uVar26,local_3f8);
                *(uint64 *)(lVar13 + 32 + lVar19 * 12) =
                     CONCAT44(fVar23 + (float)((uint64)local_478 >> 32),(float)local_478 + fVar24);
                *(float *)(lVar13 + 40 + lVar19 * 12) = local_260;
                lVar7 = *(int64 *)(local_450 + 56);
                if (lVar7 == null) throw; // [null/range check failed]
                if (*(uint32 *)(lVar7 + 24) <= local_res18) {
                  uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar10,0);
                }
                fVar23 = *(float *)(lVar15 + 0x14c + lVar7);
                fVar24 = *(float *)(lVar5 + 44) * 0.01;
                fVar25 = (*(float *)(lVar15 + 300 + lVar7) - fVar23) * fVar24;
                if (*(uint32 *)(lVar13 + 24) <= uVar4) {
                  uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar10,0);
                }
                fVar23 = -((fVar23 - *(float *)(lVar15 + 0x138 + lVar7)) * fVar24);
                local_478 = *(uint64 *)(lVar13 + 32 + lVar16 * 12);
                local_3e8 = *(float *)(lVar13 + 40 + lVar16 * 12);
                local_250 = local_3e8 + -0.0;
                uStack_470 = CONCAT44(uVar26,local_3e8);
                *(uint64 *)(lVar13 + 32 + lVar16 * 12) =
                     CONCAT44((float)((uint64)local_478 >> 32) + -0.0,(float)local_478 + fVar23);
                *(float *)(lVar13 + 40 + lVar16 * 12) = local_250;
                if (*(uint32 *)(lVar13 + 24) <= uVar20) {
                  uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar10,0);
                }
                local_478 = *(uint64 *)(lVar13 + 32 + lVar1 * 12);
                local_3d8 = *(float *)(lVar13 + 40 + lVar1 * 12);
                local_240 = local_3d8 + 0.0;
                uStack_470 = CONCAT44(uVar26,local_3d8);
                *(uint64 *)(lVar13 + 32 + lVar1 * 12) =
                     CONCAT44((float)((uint64)local_478 >> 32) + 0.0,fVar25 + (float)local_478);
                *(float *)(lVar13 + 40 + lVar1 * 12) = local_240;
                uVar18 = (uint32)lVar2;
                if (*(uint32 *)(lVar13 + 24) <= uVar18) {
                  uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar10,0);
                }
                local_478 = *(uint64 *)(lVar13 + 32 + lVar2 * 12);
                local_3c8 = *(float *)(lVar13 + 40 + lVar2 * 12);
                local_230 = local_3c8 + 0.0;
                uStack_470 = CONCAT44(uVar26,local_3c8);
                *(uint64 *)(lVar13 + 32 + lVar2 * 12) =
                     CONCAT44((float)((uint64)local_478 >> 32) + 0.0,fVar25 + (float)local_478);
                *(float *)(lVar13 + 40 + lVar2 * 12) = local_230;
                if (*(uint32 *)(lVar13 + 24) <= uVar17) {
                  uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar10,0);
                }
                local_478 = *(uint64 *)(lVar13 + 32 + lVar19 * 12);
                local_3b8 = *(float *)(lVar13 + 40 + lVar19 * 12);
                uStack_470 = CONCAT44(uVar26,local_3b8);
                local_220 = local_3b8 + -0.0;
                *(uint64 *)(lVar13 + 32 + lVar19 * 12) =
                     CONCAT44((float)((uint64)local_478 >> 32) + -0.0,fVar23 + (float)local_478);
                *(float *)(lVar13 + 40 + lVar19 * 12) = local_220;
                fVar23 = (fVar27 - fVar21) / (fVar22 - fVar21) + 0.0001;
                if (*(int64 *)(lVar5 + 32) == 0) throw; // [null/range check failed]
                fVar24 = (float)AnimationCurve.Evaluate(*(int64 *)(lVar5 + 32),lVar9,0);
                fVar24 = fVar24 * *(float *)(lVar5 + 40);
                if (*(int64 *)(lVar5 + 32) == 0) throw; // [null/range check failed]
                fVar25 = (float)AnimationCurve.Evaluate(*(int64 *)(lVar5 + 32),fVar23,0);
                local_200 = 0;
                local_210 = 0;
                local_460 = 0;
                local_468 = CONCAT44(fVar25 * *(float *)(lVar5 + 40) - fVar24,
                                     ((fVar22 - fVar21) * fVar23 + fVar21) - fVar27);
                puVar11 = (uint64 *)Vector3.get_normalized(local_190,&local_468,0);
                local_3a8 = *(float *)(puVar11 + 1);
                local_478 = *puVar11;
                uStack_470 = CONCAT44((int)((uint64)uStack_470 >> 32),local_3a8);
                uVar10 = FUN_1801f98e8((float)((uint64)local_478 >> 32) * 0.0 + (float)local_478 +
                                       local_3a8 * 0.0);
                uVar26 = (uint32)((uint64)uVar10 >> 32);
                local_390 = local_460;
                fVar23 = (float)uVar10 * 57.29578;
                local_380 = local_200;
                local_398 = local_468;
                local_388 = 0x3f800000;
                lVar9 = Vector3.Cross(local_180,&local_388,&local_398,0);
                local_370 = *(float *)(lVar9 + 8);
                if (local_370 <= 0.0) {
                  fVar23 = 360.0 - fVar23;
                  uVar26 = 0;
                }
                puVar11 = (uint64 *)Quaternion.Euler(local_1a8,0,0,CONCAT44(uVar26,fVar23),0);
                uVar10 = *puVar11;
                uVar8 = puVar11[1];
                puVar11 = (uint64 *)Vector3.get_one(local_170,0);
                local_448 = 0;
                local_368 = *puVar11;
                local_360 = *(uint32 *)(puVar11 + 1);
                local_440 = 0;
                local_478 = uVar10;
                uStack_470 = uVar8;
                local_444 = fVar24;
                puVar11 = (uint64 *)Matrix4x4.TRS(local_120,&local_448,&local_478,&local_368,0);
                local_2b8 = *puVar11;
                uStack_2b0 = puVar11[1];
                local_2a8 = puVar11[2];
                uStack_2a0 = puVar11[3];
                local_298 = puVar11[4];
                uStack_290 = puVar11[5];
                local_288 = puVar11[6];
                uStack_280 = puVar11[7];
                if (*(uint32 *)(lVar13 + 24) <= uVar4) {
                  uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar10,0);
                }
                local_358 = *(uint64 *)(lVar13 + 32 + lVar16 * 12);
                local_350 = *(uint32 *)(lVar13 + 40 + lVar16 * 12);
                puVar11 = (uint64 *)Matrix4x4.MultiplyPoint3x4(local_160,&local_2b8,&local_358,0);
                if (*(uint32 *)(lVar13 + 24) <= uVar4) {
                  uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar10,0);
                }
                *(uint64 *)(lVar13 + 32 + lVar16 * 12) = *puVar11;
                *(uint32 *)(lVar13 + 40 + lVar16 * 12) = *(uint32 *)(puVar11 + 1);
                if (*(uint32 *)(lVar13 + 24) <= uVar20) {
                  uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar10,0);
                }
                local_348 = *(uint64 *)(lVar13 + 32 + lVar1 * 12);
                local_340 = *(uint32 *)(lVar13 + 40 + lVar1 * 12);
                puVar11 = (uint64 *)Matrix4x4.MultiplyPoint3x4(local_150,&local_2b8,&local_348,0);
                if (*(uint32 *)(lVar13 + 24) <= uVar20) {
                  uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar10,0);
                }
                *(uint64 *)(lVar13 + 32 + lVar1 * 12) = *puVar11;
                *(uint32 *)(lVar13 + 40 + lVar1 * 12) = *(uint32 *)(puVar11 + 1);
                if (*(uint32 *)(lVar13 + 24) <= uVar18) {
                  uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar10,0);
                }
                local_2e8 = *(uint64 *)(lVar13 + 32 + lVar2 * 12);
                local_2e0 = *(uint32 *)(lVar13 + 40 + lVar2 * 12);
                puVar11 = (uint64 *)Matrix4x4.MultiplyPoint3x4(local_140,&local_2b8,&local_2e8,0);
                if (*(uint32 *)(lVar13 + 24) <= uVar18) {
                  uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar10,0);
                }
                *(uint64 *)(lVar13 + 32 + lVar2 * 12) = *puVar11;
                *(uint32 *)(lVar13 + 40 + lVar2 * 12) = *(uint32 *)(puVar11 + 1);
                if (*(uint32 *)(lVar13 + 24) <= uVar17) {
                  uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar10,0);
                }
                local_338 = *(uint64 *)(lVar13 + 32 + lVar19 * 12);
                local_330 = *(uint32 *)(lVar13 + 40 + lVar19 * 12);
                puVar11 = (uint64 *)Matrix4x4.MultiplyPoint3x4(local_130,&local_2b8,&local_338,0);
                if (*(uint32 *)(lVar13 + 24) <= uVar17) {
                  uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar10,0);
                }
                *(uint64 *)(lVar13 + 32 + lVar19 * 12) = *puVar11;
                *(uint32 *)(lVar13 + 40 + lVar19 * 12) = *(uint32 *)(puVar11 + 1);
                if (*(uint32 *)(lVar13 + 24) <= uVar4) {
                  uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar10,0);
                }
                local_320 = *(float *)(lVar13 + 40 + lVar16 * 12);
                local_478 = *(uint64 *)(lVar13 + 32 + lVar16 * 12);
                local_1f0 = local_320 + 0.0;
                uVar26 = (uint32)((uint64)uStack_470 >> 32);
                uStack_470 = CONCAT44(uVar26,local_320);
                *(uint64 *)(lVar13 + 32 + lVar16 * 12) =
                     CONCAT44((float)((uint64)local_478 >> 32) + fVar3,(float)local_478 + fVar27);
                *(float *)(lVar13 + 40 + lVar16 * 12) = local_1f0;
                if (*(uint32 *)(lVar13 + 24) <= uVar20) {
                  uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar10,0);
                }
                local_310 = *(float *)(lVar13 + 40 + lVar1 * 12);
                local_478 = *(uint64 *)(lVar13 + 32 + lVar1 * 12);
                local_1e0 = local_310 + 0.0;
                uStack_470 = CONCAT44(uVar26,local_310);
                *(uint64 *)(lVar13 + 32 + lVar1 * 12) =
                     CONCAT44((float)((uint64)local_478 >> 32) + fVar3,(float)local_478 + fVar27);
                *(float *)(lVar13 + 40 + lVar1 * 12) = local_1e0;
                if (*(uint32 *)(lVar13 + 24) <= uVar18) {
                  uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar10,0);
                }
                local_300 = *(float *)(lVar13 + 40 + lVar2 * 12);
                local_478 = *(uint64 *)(lVar13 + 32 + lVar2 * 12);
                local_1d0 = local_300 + 0.0;
                uStack_470 = CONCAT44(uVar26,local_300);
                *(uint64 *)(lVar13 + 32 + lVar2 * 12) =
                     CONCAT44((float)((uint64)local_478 >> 32) + fVar3,(float)local_478 + fVar27);
                *(float *)(lVar13 + 40 + lVar2 * 12) = local_1d0;
                if (*(uint32 *)(lVar13 + 24) <= uVar17) {
                  uVar10 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar10,0);
                }
                local_2f0 = *(float *)(lVar13 + 40 + lVar19 * 12);
                local_478 = *(uint64 *)(lVar13 + 32 + lVar19 * 12);
                local_430 = local_2f0 + 0.0;
                uStack_470 = CONCAT44(uVar26,local_2f0);
                *(uint64 *)(lVar13 + 32 + lVar19 * 12) =
                     CONCAT44((float)((uint64)local_478 >> 32) + fVar3,(float)local_478 + fVar27);
                *(float *)(lVar13 + 40 + lVar19 * 12) = local_430;
                lVar13 = local_450;
                iVar14 = local_458;
              }
              local_res18 = local_res18 + 1;
            } while ((int)local_res18 < iVar14);
          }
          plVar6 = *(int64 **)(lVar5 + 24);
          if (plVar6 != (int64 *)0) {
            (**(code **)(*plVar6 + 0x808))(plVar6,*(uint64 *)(*plVar6 + 0x810));
            this.<>2__current = 0;
            this.<>1__state = 2;
            return true;
          }
        }
    }

    // Token : 0x600243F
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6002440
    // RVA   : 0xB173E0   Offset: 0xB15BE0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d89490);
    }

    // Token : 0x6002441
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
