// ============================================================
// Type  : <WarpText>d__8
// Token : 0x2000416
// ============================================================

public class <WarpText>d__8
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001F37
    private int <>1__state;

    // Token: 0x4001F38
    private object <>2__current;

    // Token: 0x4001F39
    public WarpTextExample <>4__this;

    // Token: 0x4001F3A
    private float <old_CurveScale>5__2;

    // Token: 0x4001F3B
    private AnimationCurve <old_curve>5__3;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60024E1
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x60024E2
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x60024E3
    // RVA   : 0xB17420   Offset: 0xB15C20   Length: 0xD8D
    private virtual bool MoveNext()
    {
        long lVar1;
        float fVar2;
        uint uVar3;
        long lVar4;
        ulong uVar6;
        long lVar7;
        ulong uVar8;
        long lVar11;
        int iVar12;
        long lVar13;
        uint uVar14;
        long lVar15;
        uint uVar16;
        long lVar17;
        uint uVar18;
        float fVar19;
        float fVar20;
        float fVar21;
        float fVar22;
        float fVar23;
        uint uVar24;
        float fVar25;
        uint local_res18;
        ulong local_408;
        ulong uStack_400;
        uint64 local_3f8;
        uint32 local_3f0;
        int local_3e8;
        uint32 local_3d8;
        float local_3d4;
        uint32 local_3d0;
        uint8 local_3c8 [8];
        float local_3c0;
        uint64 local_3b8;
        uint64 uStack_3b0;
        uint64 local_3a8;
        float local_398;
        float local_388;
        float local_378;
        float local_368;
        uint64 local_358;
        uint32 local_350;
        uint64 local_348;
        uint32 local_340;
        float local_330;
        uint64 local_328;
        uint32 local_320;
        uint64 local_318;
        uint32 local_310;
        uint64 local_308;
        uint32 local_300;
        uint64 local_2f8;
        uint32 local_2f0;
        float local_2e0;
        float local_2d0;
        float local_2c0;
        float local_2b0;
        uint64 local_2a8;
        uint32 local_2a0;
        int64 local_298;
        float local_288;
        uint64 local_278;
        uint64 uStack_270;
        uint64 local_268;
        uint64 uStack_260;
        uint64 local_258;
        uint64 uStack_250;
        uint64 local_248;
        uint64 uStack_240;
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
        iVar12 = this.<>1__state;
        lVar4 = this.<>4__this;
        local_3a8 = 0;
        local_3f8 = 0;
        local_3f0 = 0;
        local_278 = 0;
        uStack_270 = 0;
        local_268 = 0;
        uStack_260 = 0;
        local_258 = 0;
        uStack_250 = 0;
        local_248 = 0;
        uStack_240 = 0;
        local_3b8 = 0;
        uStack_3b0 = 0;
        if (iVar12 == 0) {
          this.<>1__state = 0xffffffff;
          if ((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) throw; // [null/range check failed]
          AnimationCurve.set_preWrapMode(*(int64 *)(lVar4 + 32),1);
          if (*(int64 *)(lVar4 + 32) == 0) throw; // [null/range check failed]
          AnimationCurve.set_postWrapMode(*(int64 *)(lVar4 + 32),1);
          if (*(int64 *)(lVar4 + 24) == 0) throw; // [null/range check failed]
          TMP_Text.set_havePropertiesChanged(*(int64 *)(lVar4 + 24),1,0);
          fVar19 = *(float *)(lVar4 + 48) * 10.0;
          *(float *)(lVar4 + 48) = fVar19;
          this.<old_CurveScale>5__2 = fVar19;
          uVar8 = WarpTextExample.CopyAnimationCurve(lVar4,*(uint64 *)(lVar4 + 32),0);
          this.<old_curve>5__3 = uVar8;
        }
        else {
          if ((iVar12 != 1) && (iVar12 != 2)) {
            return false;
          }
          this.<>1__state = 0xffffffff;
        }
        do {
          if ((lVar4 == null) || (*(int64 *)(lVar4 + 24) == 0)) throw; // [null/range check failed]
          if ((*(char *)(*(int64 *)(lVar4 + 24) + 0x370) == false) &&
             (this.<old_CurveScale>5__2 == *(float *)(lVar4 + 48))) {
            if ((this.<old_curve>5__3 == 0) ||
               (lVar7 = FUN_181092110(this.<old_curve>5__3,0)) == null) throw; // [null/range check failed]
            if (*(uint32 *)(lVar7 + 24) < 2) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            fVar19 = (float)FUN_18044df60(lVar7 + 60,0);
            if ((*(int64 *)(lVar4 + 32) == 0) ||
               (lVar7 = FUN_181092110(*(int64 *)(lVar4 + 32),0)) == null) throw; // [null/range check failed]
            if (*(uint32 *)(lVar7 + 24) < 2) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            fVar20 = (float)FUN_18044df60(lVar7 + 60,0);
            if (fVar19 == fVar20) {
              this.<>2__current = 0;
              this.<>1__state = 1;
              return true;
            }
          }
          this.<old_CurveScale>5__2 = *(uint32 *)(lVar4 + 48);
          uVar8 = WarpTextExample.CopyAnimationCurve(lVar4,*(uint64 *)(lVar4 + 32),0);
          this.<old_curve>5__3 = uVar8;
          plVar5 = *(int64 **)(lVar4 + 24);
          if (plVar5 == (int64 *)0) throw; // [null/range check failed]
          (**(code **)(*plVar5 + 0x7d8))(plVar5,0,0,*(uint64 *)(*plVar5 + 0x7e0));
          lVar7 = *(int64 *)(lVar4 + 24);
          if ((lVar7 == null) || (lVar11 = *(int64 *)(lVar7 + 0x368), local_298 = lVar11) == null)
          throw; // [null/range check failed]
          iVar12 = *(int *)(lVar11 + 24);
          local_3e8 = iVar12;
        } while (iVar12 == 0);
        puVar9 = (uint64 *)TMP_Text.get_bounds(local_1a8,lVar7,0);
        local_3b8 = *puVar9;
        uStack_3b0 = puVar9[1];
        local_3a8 = puVar9[2];
        pfVar10 = (float *)Bounds.get_min(local_3c8,&local_3b8,0);
        fVar19 = *pfVar10;
        if (*(int64 *)(lVar4 + 24) != 0) {
          puVar9 = (uint64 *)TMP_Text.get_bounds(local_1a8,*(int64 *)(lVar4 + 24),0);
          local_3b8 = *puVar9;
          uStack_3b0 = puVar9[1];
          local_3a8 = puVar9[2];
          pfVar10 = (float *)Bounds.get_max(local_3c8,&local_3b8,0);
          fVar20 = *pfVar10;
          local_res18 = 0;
          if (0 < iVar12) {
            do {
              lVar7 = *(int64 *)(lVar11 + 56);
              if (lVar7 == null) throw; // [null/range check failed]
              if (*(uint32 *)(lVar7 + 24) <= local_res18) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              lVar13 = (int64)(int)local_res18 * 0x178;
              if (*(char *)(lVar13 + 0x194 + lVar7) != false) {
                lVar11 = *(int64 *)(lVar11 + 96);
                uVar3 = *(uint32 *)(lVar13 + 108 + lVar7);
                lVar15 = (int64)(int)uVar3;
                if (lVar11 == null) throw; // [null/range check failed]
                uVar14 = *(uint32 *)(lVar13 + 88 + lVar7);
                if (*(uint32 *)(lVar11 + 24) <= uVar14) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                lVar11 = *(int64 *)(lVar11 + 48 + (int64)(int)uVar14 * 80);
                if (lVar11 == null) throw; // [null/range check failed]
                if (*(uint32 *)(lVar11 + 24) <= uVar3) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                uVar14 = (uint32)(lVar15 + 2);
                if (*(uint32 *)(lVar11 + 24) <= uVar14) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                fVar2 = *(float *)(lVar13 + 0x14c + lVar7);
                fVar25 = (*(float *)(lVar11 + 32 + (lVar15 + 2) * 12) +
                         *(float *)(lVar11 + 32 + lVar15 * 12)) * 0.5;
                fVar23 = -fVar25;
                fVar22 = -fVar2;
                local_408 = *(uint64 *)(lVar11 + 32 + lVar15 * 12);
                local_288 = *(float *)(lVar11 + 40 + lVar15 * 12);
                uVar24 = (uint32)((uint64)uStack_400 >> 32);
                local_1c0 = local_288 + -0.0;
                uStack_400 = CONCAT44(uVar24,local_288);
                lVar13 = lVar15 + 1;
                *(uint64 *)(lVar11 + 32 + lVar15 * 12) =
                     CONCAT44(fVar22 + (float)((uint64)local_408 >> 32),fVar23 + (float)local_408);
                *(float *)(lVar11 + 40 + lVar15 * 12) = local_1c0;
                uVar18 = (uint32)lVar13;
                if (*(uint32 *)(lVar11 + 24) <= uVar18) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                local_408 = *(uint64 *)(lVar11 + 32 + lVar13 * 12);
                local_398 = *(float *)(lVar11 + 40 + lVar13 * 12);
                local_1b0 = local_398 + -0.0;
                uStack_400 = CONCAT44(uVar24,local_398);
                lVar1 = lVar15 + 2;
                *(uint64 *)(lVar11 + 32 + lVar13 * 12) =
                     CONCAT44(fVar22 + (float)((uint64)local_408 >> 32),(float)local_408 + fVar23);
                *(float *)(lVar11 + 40 + lVar13 * 12) = local_1b0;
                if (*(uint32 *)(lVar11 + 24) <= uVar14) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                local_408 = *(uint64 *)(lVar11 + 32 + lVar1 * 12);
                local_388 = *(float *)(lVar11 + 40 + lVar1 * 12);
                local_230 = local_388 + -0.0;
                uStack_400 = CONCAT44(uVar24,local_388);
                lVar17 = lVar15 + 3;
                *(uint64 *)(lVar11 + 32 + lVar1 * 12) =
                     CONCAT44(fVar22 + (float)((uint64)local_408 >> 32),(float)local_408 + fVar23);
                *(float *)(lVar11 + 40 + lVar1 * 12) = local_230;
                uVar14 = (uint32)lVar17;
                if (*(uint32 *)(lVar11 + 24) <= uVar14) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                local_408 = *(uint64 *)(lVar11 + 32 + lVar17 * 12);
                local_378 = *(float *)(lVar11 + 40 + lVar17 * 12);
                local_220 = local_378 + -0.0;
                uStack_400 = CONCAT44(uVar24,local_378);
                *(uint64 *)(lVar11 + 32 + lVar17 * 12) =
                     CONCAT44(fVar22 + (float)((uint64)local_408 >> 32),(float)local_408 + fVar23);
                *(float *)(lVar11 + 40 + lVar17 * 12) = local_220;
                fVar22 = (fVar25 - fVar19) / (fVar20 - fVar19) + 0.0001;
                if (*(int64 *)(lVar4 + 32) == 0) throw; // [null/range check failed]
                fVar23 = (float)AnimationCurve.Evaluate(*(int64 *)(lVar4 + 32),lVar7,0);
                fVar23 = fVar23 * *(float *)(lVar4 + 48);
                if (*(int64 *)(lVar4 + 32) == 0) throw; // [null/range check failed]
                fVar21 = (float)AnimationCurve.Evaluate(*(int64 *)(lVar4 + 32),fVar22,0);
                local_200 = 0;
                local_210 = 0;
                local_3f0 = 0;
                local_3f8 = CONCAT44(fVar21 * *(float *)(lVar4 + 48) - fVar23,
                                     ((fVar20 - fVar19) * fVar22 + fVar19) - fVar25);
                puVar9 = (uint64 *)Vector3.get_normalized(local_190,&local_3f8,0);
                local_368 = *(float *)(puVar9 + 1);
                local_408 = *puVar9;
                uStack_400 = CONCAT44((int)((uint64)uStack_400 >> 32),local_368);
                uVar8 = FUN_1801f98e8((float)((uint64)local_408 >> 32) * 0.0 + (float)local_408 +
                                      local_368 * 0.0);
                uVar24 = (uint32)((uint64)uVar8 >> 32);
                local_350 = local_3f0;
                fVar22 = (float)uVar8 * 57.29578;
                local_340 = local_200;
                local_358 = local_3f8;
                local_348 = 0x3f800000;
                lVar7 = Vector3.Cross(local_180,&local_348,&local_358,0);
                local_330 = *(float *)(lVar7 + 8);
                if (local_330 <= 0.0) {
                  fVar22 = 360.0 - fVar22;
                  uVar24 = 0;
                }
                puVar9 = (uint64 *)Quaternion.Euler(local_1a8,0,0,CONCAT44(uVar24,fVar22),0);
                uVar8 = *puVar9;
                uVar6 = puVar9[1];
                puVar9 = (uint64 *)Vector3.get_one(local_170,0);
                local_3d8 = 0;
                local_328 = *puVar9;
                local_320 = *(uint32 *)(puVar9 + 1);
                local_3d0 = 0;
                local_408 = uVar8;
                uStack_400 = uVar6;
                local_3d4 = fVar23;
                puVar9 = (uint64 *)Matrix4x4.TRS(local_120,&local_3d8,&local_408,&local_328,0);
                local_278 = *puVar9;
                uStack_270 = puVar9[1];
                local_268 = puVar9[2];
                uStack_260 = puVar9[3];
                local_258 = puVar9[4];
                uStack_250 = puVar9[5];
                local_248 = puVar9[6];
                uStack_240 = puVar9[7];
                if (*(uint32 *)(lVar11 + 24) <= uVar3) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                local_318 = *(uint64 *)(lVar11 + 32 + lVar15 * 12);
                local_310 = *(uint32 *)(lVar11 + 40 + lVar15 * 12);
                puVar9 = (uint64 *)Matrix4x4.MultiplyPoint3x4(local_160,&local_278,&local_318,0);
                if (*(uint32 *)(lVar11 + 24) <= uVar3) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                *(uint64 *)(lVar11 + 32 + lVar15 * 12) = *puVar9;
                *(uint32 *)(lVar11 + 40 + lVar15 * 12) = *(uint32 *)(puVar9 + 1);
                if (*(uint32 *)(lVar11 + 24) <= uVar18) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                local_308 = *(uint64 *)(lVar11 + 32 + lVar13 * 12);
                local_300 = *(uint32 *)(lVar11 + 40 + lVar13 * 12);
                puVar9 = (uint64 *)Matrix4x4.MultiplyPoint3x4(local_150,&local_278,&local_308,0);
                if (*(uint32 *)(lVar11 + 24) <= uVar18) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                *(uint64 *)(lVar11 + 32 + lVar13 * 12) = *puVar9;
                *(uint32 *)(lVar11 + 40 + lVar13 * 12) = *(uint32 *)(puVar9 + 1);
                uVar16 = (uint32)lVar1;
                if (*(uint32 *)(lVar11 + 24) <= uVar16) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                local_2f8 = *(uint64 *)(lVar11 + 32 + lVar1 * 12);
                local_2f0 = *(uint32 *)(lVar11 + 40 + lVar1 * 12);
                puVar9 = (uint64 *)Matrix4x4.MultiplyPoint3x4(local_140,&local_278,&local_2f8,0);
                if (*(uint32 *)(lVar11 + 24) <= uVar16) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                *(uint64 *)(lVar11 + 32 + lVar1 * 12) = *puVar9;
                *(uint32 *)(lVar11 + 40 + lVar1 * 12) = *(uint32 *)(puVar9 + 1);
                if (*(uint32 *)(lVar11 + 24) <= uVar14) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                local_2a8 = *(uint64 *)(lVar11 + 32 + lVar17 * 12);
                local_2a0 = *(uint32 *)(lVar11 + 40 + lVar17 * 12);
                puVar9 = (uint64 *)Matrix4x4.MultiplyPoint3x4(local_130,&local_278,&local_2a8,0);
                if (*(uint32 *)(lVar11 + 24) <= uVar14) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                *(uint64 *)(lVar11 + 32 + lVar17 * 12) = *puVar9;
                *(uint32 *)(lVar11 + 40 + lVar17 * 12) = *(uint32 *)(puVar9 + 1);
                if (*(uint32 *)(lVar11 + 24) <= uVar3) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                local_408 = *(uint64 *)(lVar11 + 32 + lVar15 * 12);
                local_2e0 = *(float *)(lVar11 + 40 + lVar15 * 12);
                local_1f0 = local_2e0 + 0.0;
                uVar24 = (uint32)((uint64)uStack_400 >> 32);
                uStack_400 = CONCAT44(uVar24,local_2e0);
                *(uint64 *)(lVar11 + 32 + lVar15 * 12) =
                     CONCAT44(fVar2 + (float)((uint64)local_408 >> 32),(float)local_408 + fVar25);
                *(float *)(lVar11 + 40 + lVar15 * 12) = local_1f0;
                if (*(uint32 *)(lVar11 + 24) <= uVar18) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                local_408 = *(uint64 *)(lVar11 + 32 + lVar13 * 12);
                local_2d0 = *(float *)(lVar11 + 40 + lVar13 * 12);
                local_1e0 = local_2d0 + 0.0;
                uStack_400 = CONCAT44(uVar24,local_2d0);
                *(uint64 *)(lVar11 + 32 + lVar13 * 12) =
                     CONCAT44(fVar2 + (float)((uint64)local_408 >> 32),(float)local_408 + fVar25);
                *(float *)(lVar11 + 40 + lVar13 * 12) = local_1e0;
                if (*(uint32 *)(lVar11 + 24) <= uVar16) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                local_408 = *(uint64 *)(lVar11 + 32 + lVar1 * 12);
                local_2c0 = *(float *)(lVar11 + 40 + lVar1 * 12);
                local_1d0 = local_2c0 + 0.0;
                uStack_400 = CONCAT44(uVar24,local_2c0);
                *(uint64 *)(lVar11 + 32 + lVar1 * 12) =
                     CONCAT44(fVar2 + (float)((uint64)local_408 >> 32),(float)local_408 + fVar25);
                *(float *)(lVar11 + 40 + lVar1 * 12) = local_1d0;
                if (*(uint32 *)(lVar11 + 24) <= uVar14) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                local_408 = *(uint64 *)(lVar11 + 32 + lVar17 * 12);
                local_2b0 = *(float *)(lVar11 + 40 + lVar17 * 12);
                local_3c0 = local_2b0 + 0.0;
                uStack_400 = CONCAT44(uVar24,local_2b0);
                *(uint64 *)(lVar11 + 32 + lVar17 * 12) =
                     CONCAT44(fVar2 + (float)((uint64)local_408 >> 32),(float)local_408 + fVar25);
                *(float *)(lVar11 + 40 + lVar17 * 12) = local_3c0;
                lVar11 = local_298;
                iVar12 = local_3e8;
              }
              local_res18 = local_res18 + 1;
            } while ((int)local_res18 < iVar12);
          }
          plVar5 = *(int64 **)(lVar4 + 24);
          if (plVar5 != (int64 *)0) {
            (**(code **)(*plVar5 + 0x808))(plVar5,*(uint64 *)(*plVar5 + 0x810));
            uVar8 = new WaitForSeconds(0x3ccccccd,0);
            this.<>2__current = uVar8;
            this.<>1__state = 2;
            return true;
          }
        }
    }

    // Token : 0x60024E4
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x60024E5
    // RVA   : 0xB181B0   Offset: 0xB169B0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d8f200);
    }

    // Token : 0x60024E6
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
