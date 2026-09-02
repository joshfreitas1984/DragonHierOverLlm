// ============================================================
// Type  : <AnimateVertexColors>d__11
// Token : 0x200040F
// ============================================================

public class <AnimateVertexColors>d__11
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001F15
    private int <>1__state;

    // Token: 0x4001F16
    private object <>2__current;

    // Token: 0x4001F17
    public VertexShakeA <>4__this;

    // Token: 0x4001F18
    private TMP_TextInfo <textInfo>5__2;

    // Token: 0x4001F19
    private Vector3[][] <copyOfVertices>5__3;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60024BA
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x60024BB
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x60024BC
    // RVA   : 0xB0E210   Offset: 0xB0CA10   Length: 0x11D3
    private virtual bool MoveNext()
    {
        int iVar2;
        uint uVar3;
        uint uVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        long lVar8;
        long lVar9;
        long lVar12;
        long lVar13;
        uint uVar14;
        uint uVar15;
        ulong uVar16;
        ulong uVar17;
        long lVar18;
        long lVar19;
        long lVar20;
        uint uVar21;
        uint uVar22;
        float fVar23;
        float fVar24;
        float fVar25;
        float fVar26;
        uint local_res18;
        uint local_res20;
        long local_388;
        long lStack_380;
        uint local_378;
        int local_374;
        long local_370;
        float local_368;
        float fStack_364;
        float local_360;
        float local_358;
        float fStack_354;
        float local_350;
        float local_348;
        float fStack_344;
        float local_340;
        float local_338;
        float fStack_334;
        float local_330;
        float local_320;
        float local_310;
        float local_300;
        float local_2f0;
        float local_2e0;
        float local_2d0;
        float local_2c0;
        uint64 local_2b8;
        float local_2b0;
        uint64 local_2a8;
        uint32 local_2a0;
        uint64 local_298;
        uint32 local_290;
        uint64 local_288;
        uint32 local_280;
        uint64 local_278;
        uint32 local_270;
        uint64 local_268;
        uint32 local_260;
        float local_250;
        float local_240;
        float local_230;
        float local_220;
        uint64 local_218;
        uint64 uStack_210;
        uint64 local_208;
        uint64 uStack_200;
        uint64 local_1f8;
        uint64 uStack_1f0;
        uint64 local_1e8;
        uint64 uStack_1e0;
        float local_1d0;
        float local_1c0;
        float local_1b0;
        float local_1a0;
        float local_190;
        uint8 local_188 [16];
        uint8 local_178 [16];
        uint8 local_168 [16];
        uint8 local_158 [16];
        uint8 local_148 [16];
        uint8 local_138 [16];
        uint8 local_128 [16];
        uint8 local_118 [224];
        lVar8 = this.<>4__this;
        iVar2 = this.<>1__state;
        local_218 = 0;
        uStack_210 = 0;
        local_208 = 0;
        uStack_200 = 0;
        local_1f8 = 0;
        uStack_1f0 = 0;
        local_1e8 = 0;
        uStack_1e0 = 0;
        local_370 = lVar8;
        if (iVar2 == 0) {
          *piVar1 = -1;
          if ((lVar8 == null) || (plVar10 = *(int64 **)(lVar8 + 40), plVar10 == (int64 *)0))
          throw; // [null/range check failed]
          (**(code **)(*plVar10 + 0x7d8))(plVar10,0,0,*(uint64 *)(*plVar10 + 0x7e0));
          if (*(int64 *)(lVar8 + 40) == 0) throw; // [null/range check failed]
          this.<textInfo>5__2 = *(uint64 *)(*(int64 *)(lVar8 + 40) + 0x368);
          uVar7 = FUN_1800d60b0(DAT_181d7b3a0,0);
          this.<copyOfVertices>5__3 = uVar7;
          *(uint8 *)(lVar8 + 48) = 1;
        }
        else {
          if ((iVar2 != 1) && (iVar2 != 2)) {
            return false;
          }
          *piVar1 = -1;
          if (lVar8 == null) throw; // [null/range check failed]
        }
        uVar14 = 0;
        if (*(char *)(lVar8 + 48) == false) {
        LAB_180b0e4d2:
          lVar9 = this.<textInfo>5__2;
          if (lVar9 != null) {
            if (*(int *)(lVar9 + 24) == 0) {
              uVar7 = new WaitForSeconds(0x3e800000,0);
              this.<>2__current = uVar7;
              this.<>1__state = 1;
              return true;
            }
            local_374 = *(int *)(lVar9 + 44);
            local_res20 = 0;
            if (0 < local_374) {
              do {
                lVar9 = this.<textInfo>5__2;
                if ((lVar9 == null) || (lVar12 = *(int64 *)(lVar9 + 80)) == null)
                throw; // [null/range check failed]
                if (*(uint32 *)(lVar12 + 24) <= local_res20) {
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar7,0);
                }
                lVar9 = *(int64 *)(lVar9 + 56);
                local_res18 = *(uint32 *)((int64)(int)local_res20 * 92 + 52 + lVar12);
                uVar16 = (uint64)(int)local_res18;
                uVar14 = *(uint32 *)((int64)(int)local_res20 * 92 + 60 + lVar12);
                uVar17 = (uint64)(int)uVar14;
                local_378 = uVar14;
                if (lVar9 == null) throw; // [null/range check failed]
                if (*(uint32 *)(lVar9 + 24) <= local_res18) {
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar7,0);
                }
                if (*(uint32 *)(lVar9 + 24) <= uVar14) {
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar7,0);
                }
                uVar7 = *(uint64 *)(uVar16 * 0x178 + 0x11c + lVar9);
                lVar12 = uVar17 * 0x178;
                local_388 = *(int64 *)(lVar12 + 0x128 + lVar9);
                lStack_380 = CONCAT44((int)((uint64)lStack_380 >> 32),
                                      *(uint32 *)(lVar12 + 0x130 + lVar9));
                local_320 = *(float *)(uVar16 * 0x178 + 0x124 + lVar9);
                local_310 = *(float *)(lVar12 + 0x130 + lVar9);
                fVar25 = ((float)local_388 + (float)uVar7) * 0.5;
                fVar24 = ((float)((uint64)uVar7 >> 32) + (float)((uint64)local_388 >> 32)) * 0.5
                ;
                fVar26 = (local_320 + local_310) * 0.5;
                fVar23 = (float)Random.Range(0xbe800000,0x3e800000,0);
                plVar10 = (int64 *)Quaternion.Euler(local_128,0,0,*(float *)(lVar8 + 36) * fVar23,0)
                ;
                lVar9 = *plVar10;
                lVar12 = plVar10[1];
                if ((int)local_res18 <= (int)uVar14) {
                  do {
                    uVar14 = (uint32)uVar16;
                    lVar8 = this.<textInfo>5__2;
                    if ((lVar8 == null) || (lVar18 = *(int64 *)(lVar8 + 56)) == null)
                    throw; // [null/range check failed]
                    if (*(uint32 *)(lVar18 + 24) <= uVar14) {
                      uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar7,0);
                    }
                    lVar13 = (int64)(int)uVar14 * 0x178;
                    if (*(char *)(lVar13 + 0x194 + lVar18) != false) {
                      uVar14 = *(uint32 *)(lVar13 + 108 + lVar18);
                      lVar20 = (int64)(int)uVar14;
                      uVar3 = *(uint32 *)(lVar13 + 88 + lVar18);
                      lVar18 = (int64)(int)uVar3;
                      lVar8 = *(int64 *)(lVar8 + 96);
                      if (lVar8 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar8 + 24) <= uVar3) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      lVar13 = this.<copyOfVertices>5__3;
                      if (lVar13 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar13 + 24) <= uVar3) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      lVar13 = *(int64 *)(lVar13 + 32 + lVar18 * 8);
                      lVar8 = *(int64 *)(lVar8 + 48 + lVar18 * 80);
                      if (lVar8 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar8 + 24) <= uVar14) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      local_388 = *(int64 *)(lVar8 + 32 + lVar20 * 12);
                      local_300 = *(float *)(lVar8 + 40 + lVar20 * 12);
                      local_368 = (float)local_388 - fVar25;
                      fStack_364 = (float)((uint64)local_388 >> 32) - fVar24;
                      uVar4 = (uint32)((uint64)lStack_380 >> 32);
                      lStack_380 = CONCAT44(uVar4,local_300);
                      local_360 = local_300 - fVar26;
                      if (lVar13 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar13 + 24) <= uVar14) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      *(uint64 *)(lVar13 + 32 + lVar20 * 12) = CONCAT44(fStack_364,local_368);
                      *(float *)(lVar13 + 40 + lVar20 * 12) = local_360;
                      lVar13 = this.<copyOfVertices>5__3;
                      if (lVar13 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar13 + 24) <= uVar3) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      lVar5 = *(int64 *)(lVar13 + 32 + lVar18 * 8);
                      lVar13 = lVar20 + 1;
                      uVar22 = (uint32)lVar13;
                      if (*(uint32 *)(lVar8 + 24) <= uVar22) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      local_388 = *(int64 *)(lVar8 + 32 + lVar13 * 12);
                      local_2f0 = *(float *)(lVar8 + 40 + lVar13 * 12);
                      local_358 = (float)local_388 - fVar25;
                      fStack_354 = (float)((uint64)local_388 >> 32) - fVar24;
                      lStack_380 = CONCAT44(uVar4,local_2f0);
                      local_350 = local_2f0 - fVar26;
                      if (lVar5 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar5 + 24) <= uVar22) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      *(uint64 *)(lVar5 + 32 + lVar13 * 12) = CONCAT44(fStack_354,local_358);
                      *(float *)(lVar5 + 40 + lVar13 * 12) = local_350;
                      lVar5 = this.<copyOfVertices>5__3;
                      if (lVar5 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar5 + 24) <= uVar3) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      lVar6 = *(int64 *)(lVar5 + 32 + lVar18 * 8);
                      lVar5 = lVar20 + 2;
                      uVar21 = (uint32)lVar5;
                      if (*(uint32 *)(lVar8 + 24) <= uVar21) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      local_388 = *(int64 *)(lVar8 + 32 + lVar5 * 12);
                      local_2e0 = *(float *)(lVar8 + 40 + lVar5 * 12);
                      local_348 = (float)local_388 - fVar25;
                      fStack_344 = (float)((uint64)local_388 >> 32) - fVar24;
                      lStack_380 = CONCAT44(uVar4,local_2e0);
                      local_340 = local_2e0 - fVar26;
                      if (lVar6 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar6 + 24) <= uVar21) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      *(uint64 *)(lVar6 + 32 + lVar5 * 12) = CONCAT44(fStack_344,local_348);
                      *(float *)(lVar6 + 40 + lVar5 * 12) = local_340;
                      lVar6 = this.<copyOfVertices>5__3;
                      if (lVar6 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar6 + 24) <= uVar3) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      lVar6 = *(int64 *)(lVar6 + 32 + lVar18 * 8);
                      lVar19 = lVar20 + 3;
                      if (*(uint32 *)(lVar8 + 24) <= (uint32)lVar19) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      local_388 = *(int64 *)(lVar8 + 32 + lVar19 * 12);
                      local_2d0 = *(float *)(lVar8 + 40 + lVar19 * 12);
                      local_338 = (float)local_388 - fVar25;
                      fStack_334 = (float)((uint64)local_388 >> 32) - fVar24;
                      lStack_380 = CONCAT44(uVar4,local_2d0);
                      local_330 = local_2d0 - fVar26;
                      if (lVar6 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar6 + 24) <= (uint32)lVar19) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      *(uint64 *)(lVar6 + 32 + lVar19 * 12) = CONCAT44(fStack_334,local_338);
                      *(float *)(lVar6 + 40 + lVar19 * 12) = local_330;
                      fVar23 = *(float *)(local_370 + 32) * 0.001;
                      fVar23 = (float)Random.Range(0.995 - fVar23,fVar23 + 1.005,0);
                      puVar11 = (uint64 *)Vector3.get_one(local_188,0);
                      uVar7 = *puVar11;
                      uVar4 = *(uint32 *)(puVar11 + 1);
                      puVar11 = (uint64 *)Vector3.get_one(local_178,0);
                      local_2c0 = *(float *)(puVar11 + 1);
                      local_2b0 = local_2c0 * fVar23;
                      local_2b8 = CONCAT44((float)((uint64)*puVar11 >> 32) * fVar23,
                                           (float)*puVar11 * fVar23);
                      local_388 = lVar9;
                      lStack_380 = lVar12;
                      local_2a8 = uVar7;
                      local_2a0 = uVar4;
                      local_1d0 = local_2b0;
                      puVar11 = (uint64 *)Matrix4x4.TRS(local_118,&local_2a8,&local_388,&local_2b8,0)
                      ;
                      lVar8 = this.<copyOfVertices>5__3;
                      local_218 = *puVar11;
                      uStack_210 = puVar11[1];
                      local_208 = puVar11[2];
                      uStack_200 = puVar11[3];
                      local_1f8 = puVar11[4];
                      uStack_1f0 = puVar11[5];
                      local_1e8 = puVar11[6];
                      uStack_1e0 = puVar11[7];
                      if (lVar8 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar8 + 24) <= uVar3) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      lVar8 = *(int64 *)(lVar8 + 32 + lVar18 * 8);
                      if (lVar8 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar8 + 24) <= uVar14) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      local_298 = *(uint64 *)(lVar8 + 32 + lVar20 * 12);
                      local_290 = *(uint32 *)(lVar8 + 40 + lVar20 * 12);
                      puVar11 = (uint64 *)
                                Matrix4x4.MultiplyPoint3x4(local_168,&local_218,&local_298,0);
                      if (*(uint32 *)(lVar8 + 24) <= uVar14) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      *(uint64 *)(lVar8 + 32 + lVar20 * 12) = *puVar11;
                      *(uint32 *)(lVar8 + 40 + lVar20 * 12) = *(uint32 *)(puVar11 + 1);
                      lVar8 = this.<copyOfVertices>5__3;
                      if (lVar8 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar8 + 24) <= uVar3) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      lVar8 = *(int64 *)(lVar8 + 32 + lVar18 * 8);
                      if (lVar8 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar8 + 24) <= uVar22) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      local_288 = *(uint64 *)(lVar8 + 32 + lVar13 * 12);
                      local_280 = *(uint32 *)(lVar8 + 40 + lVar13 * 12);
                      puVar11 = (uint64 *)
                                Matrix4x4.MultiplyPoint3x4(local_158,&local_218,&local_288,0);
                      if (*(uint32 *)(lVar8 + 24) <= uVar22) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      *(uint64 *)(lVar8 + 32 + lVar13 * 12) = *puVar11;
                      *(uint32 *)(lVar8 + 40 + lVar13 * 12) = *(uint32 *)(puVar11 + 1);
                      lVar8 = this.<copyOfVertices>5__3;
                      if (lVar8 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar8 + 24) <= uVar3) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      lVar8 = *(int64 *)(lVar8 + 32 + lVar18 * 8);
                      if (lVar8 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar8 + 24) <= uVar21) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      local_278 = *(uint64 *)(lVar8 + 32 + lVar5 * 12);
                      local_270 = *(uint32 *)(lVar8 + 40 + lVar5 * 12);
                      puVar11 = (uint64 *)
                                Matrix4x4.MultiplyPoint3x4(local_148,&local_218,&local_278,0);
                      if (*(uint32 *)(lVar8 + 24) <= uVar21) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      *(uint64 *)(lVar8 + 32 + lVar5 * 12) = *puVar11;
                      *(uint32 *)(lVar8 + 40 + lVar5 * 12) = *(uint32 *)(puVar11 + 1);
                      lVar8 = this.<copyOfVertices>5__3;
                      if (lVar8 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar8 + 24) <= uVar3) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      local_388 = *(int64 *)(lVar8 + 32 + lVar18 * 8);
                      if (local_388 == 0) throw; // [null/range check failed]
                      lVar8 = (int64)(int)uVar14 + 3;
                      uVar15 = (uint32)lVar8;
                      if (*(uint32 *)(local_388 + 24) <= uVar15) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      local_268 = *(uint64 *)(local_388 + 32 + lVar8 * 12);
                      local_260 = *(uint32 *)(local_388 + 40 + lVar8 * 12);
                      puVar11 = (uint64 *)
                                Matrix4x4.MultiplyPoint3x4(local_138,&local_218,&local_268,0);
                      if (*(uint32 *)(local_388 + 24) <= uVar15) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      *(uint64 *)(local_388 + 32 + lVar8 * 12) = *puVar11;
                      *(uint32 *)(local_388 + 40 + lVar8 * 12) = *(uint32 *)(puVar11 + 1);
                      lVar6 = this.<copyOfVertices>5__3;
                      if (lVar6 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar6 + 24) <= uVar3) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      lVar6 = *(int64 *)(lVar6 + 32 + lVar18 * 8);
                      if (lVar6 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar6 + 24) <= uVar14) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      local_250 = *(float *)(lVar6 + 40 + lVar20 * 12);
                      local_388 = *(int64 *)(lVar6 + 32 + lVar20 * 12);
                      local_1c0 = local_250 + fVar26;
                      uVar4 = (uint32)((uint64)lStack_380 >> 32);
                      lStack_380 = CONCAT44(uVar4,local_250);
                      *(uint64 *)(lVar6 + 32 + lVar20 * 12) =
                           CONCAT44((float)((uint64)local_388 >> 32) + fVar24,
                                    (float)local_388 + fVar25);
                      *(float *)(lVar6 + 40 + lVar20 * 12) = local_1c0;
                      lVar20 = this.<copyOfVertices>5__3;
                      if (lVar20 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar20 + 24) <= uVar3) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      lVar20 = *(int64 *)(lVar20 + 32 + lVar18 * 8);
                      if (lVar20 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar20 + 24) <= uVar22) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      local_240 = *(float *)(lVar20 + 40 + lVar13 * 12);
                      local_388 = *(int64 *)(lVar20 + 32 + lVar13 * 12);
                      local_1b0 = local_240 + fVar26;
                      lStack_380 = CONCAT44(uVar4,local_240);
                      *(uint64 *)(lVar20 + 32 + lVar13 * 12) =
                           CONCAT44((float)((uint64)local_388 >> 32) + fVar24,
                                    (float)local_388 + fVar25);
                      *(float *)(lVar20 + 40 + lVar13 * 12) = local_1b0;
                      lVar13 = this.<copyOfVertices>5__3;
                      if (lVar13 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar13 + 24) <= uVar3) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      lVar13 = *(int64 *)(lVar13 + 32 + lVar18 * 8);
                      if (lVar13 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar13 + 24) <= uVar21) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      local_230 = *(float *)(lVar13 + 40 + lVar5 * 12);
                      local_388 = *(int64 *)(lVar13 + 32 + lVar5 * 12);
                      local_1a0 = local_230 + fVar26;
                      lStack_380 = CONCAT44(uVar4,local_230);
                      *(uint64 *)(lVar13 + 32 + lVar5 * 12) =
                           CONCAT44((float)((uint64)local_388 >> 32) + fVar24,
                                    (float)local_388 + fVar25);
                      *(float *)(lVar13 + 40 + lVar5 * 12) = local_1a0;
                      lVar13 = this.<copyOfVertices>5__3;
                      if (lVar13 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar13 + 24) <= uVar3) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      lVar18 = *(int64 *)(lVar13 + 32 + lVar18 * 8);
                      if (lVar18 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar18 + 24) <= uVar15) {
                        uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar7,0);
                      }
                      local_220 = *(float *)(lVar18 + 40 + lVar8 * 12);
                      local_388 = *(int64 *)(lVar18 + 32 + lVar8 * 12);
                      local_190 = local_220 + fVar26;
                      lStack_380 = CONCAT44(uVar4,local_220);
                      uVar17 = (uint64)local_378;
                      *(uint64 *)(lVar18 + 32 + lVar8 * 12) =
                           CONCAT44((float)((uint64)local_388 >> 32) + fVar24,
                                    (float)local_388 + fVar25);
                      *(float *)(lVar18 + 40 + lVar8 * 12) = local_190;
                      uVar14 = local_res18;
                    }
                    local_res18 = uVar14 + 1;
                    uVar16 = (uint64)local_res18;
                    lVar8 = local_370;
                  } while ((int)local_res18 <= (int)uVar17);
                }
                local_res20 = local_res20 + 1;
              } while ((int)local_res20 < local_374);
              lVar9 = this.<textInfo>5__2;
            }
            uVar14 = 0;
            if (lVar9 != null) {
              while (*(int64 *)(lVar9 + 96) != 0) {
                if (*(int *)(*(int64 *)(lVar9 + 96) + 24) <= (int)uVar14) {
                  uVar7 = new WaitForSeconds(0x3dcccccd,0);
                  this.<>2__current = uVar7;
                  this.<>1__state = 2;
                  return true;
                }
                if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 96)) == null) break;
                lVar12 = (int64)(int)uVar14;
                if (*(uint32 *)(lVar9 + 24) <= uVar14) {
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar7,0);
                }
                lVar18 = this.<copyOfVertices>5__3;
                if (lVar18 == null) break;
                if (*(uint32 *)(lVar18 + 24) <= uVar14) {
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar7,0);
                }
                lVar9 = *(int64 *)(lVar9 + 32 + lVar12 * 80);
                if (lVar9 == null) break;
                Mesh.set_vertices(lVar9,*(uint64 *)(lVar18 + 32 + lVar12 * 8),0);
                if ((this.<textInfo>5__2 == 0) ||
                   (lVar9 = *(int64 *)(this.<textInfo>5__2 + 96)) == null) break;
                if (*(uint32 *)(lVar9 + 24) <= uVar14) {
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar7,0);
                }
                plVar10 = *(int64 **)(lVar8 + 40);
                if (plVar10 == (int64 *)0) break;
                (**(code **)(*plVar10 + 0x7e8))
                          (plVar10,*(uint64 *)(lVar9 + 32 + lVar12 * 80),uVar14,
                           *(uint64 *)(*plVar10 + 0x7f0));
                lVar9 = this.<textInfo>5__2;
                uVar14 = uVar14 + 1;
                if (lVar9 == null) break;
              }
            }
          }
        }
        else if (((this.<copyOfVertices>5__3 != 0) &&
                 (lVar8 = this.<textInfo>5__2) != null) &&
                (*(int64 *)(lVar8 + 96) != 0)) {
          if (*(int *)(this.<copyOfVertices>5__3 + 24) <
              *(int *)(*(int64 *)(lVar8 + 96) + 24)) {
            uVar7 = FUN_1800d60b0(DAT_181d7b3a0);
            this.<copyOfVertices>5__3 = uVar7;
            lVar8 = this.<textInfo>5__2;
          }
          if (lVar8 != null) {
            while (*(int64 *)(lVar8 + 96) != 0) {
              if (*(int *)(*(int64 *)(lVar8 + 96) + 24) <= (int)uVar14) {
                *(uint8 *)(local_370 + 48) = 0;
                lVar8 = local_370;
                goto LAB_180b0e4d2;
              }
              if ((lVar8 == null) || (lVar8 = *(int64 *)(lVar8 + 96)) == null) break;
              if (*(uint32 *)(lVar8 + 24) <= uVar14) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              lVar8 = *(int64 *)(lVar8 + 48 + (int64)(int)uVar14 * 80);
              if (lVar8 == null) break;
              plVar10 = this.<copyOfVertices>5__3;
              lVar8 = FUN_1800d60b0(DAT_181d81c40,*(uint32 *)(lVar8 + 24));
              if (plVar10 == (int64 *)0) break;
              if ((lVar8 != null) &&
                 (lVar9 = il2cpp_internal(lVar8,*(uint64 *)(*plVar10 + 64))) == null) {
                uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar7,0);
              }
              FUN_180002fd0(plVar10,(int64)(int)uVar14,lVar8);
              lVar8 = this.<textInfo>5__2;
              uVar14 = uVar14 + 1;
              if (lVar8 == null) break;
            }
          }
        }
    }

    // Token : 0x60024BD
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x60024BE
    // RVA   : 0xB0F430   Offset: 0xB0DC30   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d8efe0);
    }

    // Token : 0x60024BF
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
