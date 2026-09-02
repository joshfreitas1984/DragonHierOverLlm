// ============================================================
// Type  : <AnimateVertexColors>d__10
// Token : 0x2000414
// ============================================================

public class <AnimateVertexColors>d__10
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001F2B
    private int <>1__state;

    // Token: 0x4001F2C
    private object <>2__current;

    // Token: 0x4001F2D
    public VertexZoom <>4__this;

    // Token: 0x4001F2E
    private <>c__DisplayClass10_0 <>8__1;

    // Token: 0x4001F2F
    private TMP_TextInfo <textInfo>5__2;

    // Token: 0x4001F30
    private TMP_MeshInfo[] <cachedMeshInfoVertexData>5__3;

    // Token: 0x4001F31
    private List<int> <scaleSortingOrder>5__4;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60024D6
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x60024D7
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x60024D8
    // RVA   : 0xB0BFA0   Offset: 0xB0A7A0   Length: 0x131B
    private virtual bool MoveNext()
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        int iVar4;
        uint uVar5;
        ulong uVar7;
        ulong uVar8;
        long lVar9;
        long lVar11;
        uint uVar12;
        uint uVar13;
        long lVar14;
        long lVar15;
        uint uVar16;
        uint uVar17;
        float fVar18;
        float fVar19;
        float fVar20;
        uint local_res18;
        uint64 local_4d8;
        uint64 uStack_4d0;
        int local_4c8;
        float local_4c0;
        float fStack_4bc;
        float local_4b8;
        float local_4b0;
        float fStack_4ac;
        float local_4a8;
        float local_4a0;
        float fStack_49c;
        float local_498;
        float local_490;
        float fStack_48c;
        float local_488;
        uint64 local_478;
        uint32 local_470;
        int64 local_468;
        float local_458;
        float local_448;
        float local_438;
        float local_428;
        float local_418;
        uint64 local_408;
        float local_400;
        uint64 local_3f8;
        uint32 local_3f0;
        uint64 local_3e8;
        uint32 local_3e0;
        uint64 local_3d8;
        uint32 local_3d0;
        uint64 local_3c8;
        uint32 local_3c0;
        float local_3b0;
        float local_3a0;
        float local_390;
        float local_380;
        int64 local_378;
        uint64 local_368;
        uint64 uStack_360;
        uint64 local_358;
        uint64 uStack_350;
        uint64 local_348;
        uint64 uStack_340;
        uint64 local_338;
        uint64 uStack_330;
        float local_320;
        float local_310;
        float local_300;
        float local_2f0;
        float local_2e0;
        uint8 local_2d8 [16];
        uint8 local_2c8 [16];
        uint8 local_2b8 [16];
        uint8 local_2a8 [16];
        uint8 local_298 [16];
        uint8 local_288 [16];
        uint8 local_278 [64];
        uint8 local_238 [372];
        char local_c4;
        lVar15 = this.<>4__this;
        iVar4 = this.<>1__state;
        local_368 = 0;
        uStack_360 = 0;
        local_358 = 0;
        uStack_350 = 0;
        local_348 = 0;
        uStack_340 = 0;
        local_338 = 0;
        uStack_330 = 0;
        local_468 = lVar15;
        if (iVar4 == 0) {
          this.<>1__state = 0xffffffff;
          uVar8 = new ZhSegment(0);
          this.<>8__1 = uVar8;
          if ((lVar15 == null) || (plVar6 = *(int64 **)(lVar15 + 40), plVar6 == (int64 *)0))
          throw; // [null/range check failed]
          (**(code **)(*plVar6 + 0x7d8))(plVar6,0,0,*(uint64 *)(*plVar6 + 0x7e0));
          if (*(int64 *)(lVar15 + 40) == 0) throw; // [null/range check failed]
          this.<textInfo>5__2 = *(uint64 *)(*(int64 *)(lVar15 + 40) + 0x368);
          if (this.<textInfo>5__2 == 0) throw; // [null/range check failed]
          uVar8 = TMP_TextInfo.CopyMeshInfoVertexData(this.<textInfo>5__2,0);
          this.<cachedMeshInfoVertexData>5__3 = uVar8;
          lVar14 = this.<>8__1;
          uVar8 = il2cpp_internal(DAT_181d721b0);
          FUN_180f58a90(uVar8,DAT_181d79358);
          if (lVar14 == null) throw; // [null/range check failed]
          puVar10 = (uint64 *)(lVar14 + 16);
          *puVar10 = uVar8;
          il2cpp_internal(puVar10,uVar8);
          uVar8 = il2cpp_internal(DAT_181d6f030);
          FUN_180f58a90(uVar8,DAT_181d678f8);
          this.<scaleSortingOrder>5__4 = uVar8;
          *(uint8 *)(lVar15 + 48) = 1;
        }
        else {
          if ((iVar4 != 1) && (iVar4 != 2)) {
            return false;
          }
          this.<>1__state = 0xffffffff;
          if (lVar15 == null) throw; // [null/range check failed]
        }
        if (*(char *)(lVar15 + 48) != false) {
          if (this.<textInfo>5__2 == 0) throw; // [null/range check failed]
          uVar8 = TMP_TextInfo.CopyMeshInfoVertexData(this.<textInfo>5__2,0);
          this.<cachedMeshInfoVertexData>5__3 = uVar8;
          *(uint8 *)(lVar15 + 48) = 0;
        }
        if (this.<textInfo>5__2 != 0) {
          iVar4 = *(int *)(this.<textInfo>5__2 + 24);
          local_4c8 = iVar4;
          if (iVar4 == 0) {
            uVar8 = new WaitForSeconds(0x3e800000,0);
            this.<>2__current = uVar8;
            this.<>1__state = 1;
            return true;
          }
          if ((this.<>8__1 != 0) &&
             (lVar14 = *(int64 *)(this.<>8__1 + 16)) != null) {
            FUN_180f56130(lVar14,DAT_181d794d8);
            if (this.<scaleSortingOrder>5__4 != 0) {
              FUN_180f56130(this.<scaleSortingOrder>5__4,DAT_181d67b78);
              local_res18 = 0;
              if (0 < iVar4) {
                do {
                  if ((this.<textInfo>5__2 == 0) ||
                     (lVar15 = *(int64 *)(this.<textInfo>5__2 + 56)) == null)
                  throw; // [null/range check failed]
                  FUN_18014a310(lVar15,local_238,(int64)(int)local_res18);
                  if (local_c4) {
                    lVar15 = this.<textInfo>5__2;
                    if ((lVar15 == null) || (lVar14 = *(int64 *)(lVar15 + 56)) == null)
                    throw; // [null/range check failed]
                    if (*(uint32 *)(lVar14 + 24) <= local_res18) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    lVar11 = this.<cachedMeshInfoVertexData>5__3;
                    lVar9 = (int64)(int)local_res18 * 0x178;
                    uVar13 = *(uint32 *)(lVar9 + 88 + lVar14);
                    uVar5 = *(uint32 *)(lVar9 + 108 + lVar14);
                    lVar14 = (int64)(int)uVar5;
                    if (lVar11 == null) throw; // [null/range check failed]
                    if (*(uint32 *)(lVar11 + 24) <= uVar13) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    local_378 = (int64)(int)uVar13 * 80;
                    lVar11 = *(int64 *)(local_378 + 48 + lVar11);
                    if (lVar11 == null) throw; // [null/range check failed]
                    if (*(uint32 *)(lVar11 + 24) <= uVar5) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    lVar9 = lVar14 + 2;
                    uVar12 = (uint32)lVar9;
                    if (*(uint32 *)(lVar11 + 24) <= uVar12) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    uVar8 = *(uint64 *)(lVar11 + 32 + lVar14 * 12);
                    fVar18 = (float)((uint64)uVar8 >> 32);
                    local_4d8 = *(uint64 *)(lVar11 + 32 + lVar9 * 12);
                    uVar3 = (uint32)((uint64)uStack_4d0 >> 32);
                    uStack_4d0 = CONCAT44(uVar3,*(uint32 *)(lVar11 + 40 + lVar9 * 12));
                    fVar20 = ((float)local_4d8 + (float)uVar8) * 0.5;
                    fVar19 = (fVar18 + (float)((uint64)local_4d8 >> 32)) * 0.5;
                    lVar15 = *(int64 *)(lVar15 + 96);
                    if (lVar15 == null) throw; // [null/range check failed]
                    if (*(uint32 *)(lVar15 + 24) <= uVar13) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    local_458 = *(float *)(lVar11 + 40 + lVar14 * 12);
                    lVar15 = *(int64 *)(local_378 + 48 + lVar15);
                    fStack_4ac = fVar18 - fVar19;
                    local_4b0 = (float)uVar8 - fVar20;
                    uStack_4d0 = CONCAT44(uVar3,local_458);
                    local_4a8 = local_458 - 0.0;
                    local_4d8 = uVar8;
                    if (lVar15 == null) throw; // [null/range check failed]
                    if (*(uint32 *)(lVar15 + 24) <= uVar5) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    lVar9 = lVar14 + 1;
                    *(uint64 *)(lVar15 + 32 + lVar14 * 12) = CONCAT44(fStack_4ac,local_4b0);
                    *(float *)(lVar15 + 40 + lVar14 * 12) = local_4a8;
                    uVar16 = (uint32)lVar9;
                    if (*(uint32 *)(lVar11 + 24) <= uVar16) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    local_4d8 = *(uint64 *)(lVar11 + 32 + lVar9 * 12);
                    local_448 = *(float *)(lVar11 + 40 + lVar9 * 12);
                    local_4a0 = (float)local_4d8 - fVar20;
                    fStack_49c = (float)((uint64)local_4d8 >> 32) - fVar19;
                    uStack_4d0 = CONCAT44(uVar3,local_448);
                    local_498 = local_448 - 0.0;
                    if (*(uint32 *)(lVar15 + 24) <= uVar16) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    lVar1 = lVar14 + 2;
                    *(uint64 *)(lVar15 + 32 + lVar9 * 12) = CONCAT44(fStack_49c,local_4a0);
                    *(float *)(lVar15 + 40 + lVar9 * 12) = local_498;
                    if (*(uint32 *)(lVar11 + 24) <= uVar12) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    local_4d8 = *(uint64 *)(lVar11 + 32 + lVar1 * 12);
                    local_438 = *(float *)(lVar11 + 40 + lVar1 * 12);
                    local_490 = (float)local_4d8 - fVar20;
                    fStack_48c = (float)((uint64)local_4d8 >> 32) - fVar19;
                    uStack_4d0 = CONCAT44(uVar3,local_438);
                    local_488 = local_438 - 0.0;
                    if (*(uint32 *)(lVar15 + 24) <= uVar12) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    lVar2 = lVar14 + 3;
                    *(uint64 *)(lVar15 + 32 + lVar1 * 12) = CONCAT44(fStack_48c,local_490);
                    *(float *)(lVar15 + 40 + lVar1 * 12) = local_488;
                    uVar12 = (uint32)lVar2;
                    if (*(uint32 *)(lVar11 + 24) <= uVar12) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    local_4d8 = *(uint64 *)(lVar11 + 32 + lVar2 * 12);
                    local_428 = *(float *)(lVar11 + 40 + lVar2 * 12);
                    local_4c0 = (float)local_4d8 - fVar20;
                    fStack_4bc = (float)((uint64)local_4d8 >> 32) - fVar19;
                    uStack_4d0 = CONCAT44(uVar3,local_428);
                    local_4b8 = local_428 - 0.0;
                    if (*(uint32 *)(lVar15 + 24) <= uVar12) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    *(uint64 *)(lVar15 + 32 + lVar2 * 12) = CONCAT44(fStack_4bc,local_4c0);
                    *(float *)(lVar15 + 40 + lVar2 * 12) = local_4b8;
                    fVar18 = (float)Random.Range(0x3f800000,0x3fc00000,0);
                    if ((this.<>8__1 == 0) ||
                       (lVar11 = *(int64 *)(this.<>8__1 + 16)) == null)
                    throw; // [null/range check failed]
                    FUN_181805690(lVar11,fVar18,DAT_181d79458);
                    if ((this.<>8__1 == 0) ||
                       ((lVar11 = *(int64 *)(this.<>8__1 + 16), lVar11 == null ||
                        (this.<scaleSortingOrder>5__4 == 0)))) throw; // [null/range check failed]
                    FUN_181814fa0(this.<scaleSortingOrder>5__4,*(int *)(lVar11 + 24) + -1,DAT_181d67a78
                                 );
                    puVar10 = (uint64 *)Quaternion.get_identity(local_288,0);
                    uVar8 = *puVar10;
                    uVar7 = puVar10[1];
                    puVar10 = (uint64 *)Vector3.get_one(local_2d8,0);
                    local_418 = *(float *)(puVar10 + 1);
                    local_400 = local_418 * fVar18;
                    local_408 = CONCAT44((float)((uint64)*puVar10 >> 32) * fVar18,
                                         (float)*puVar10 * fVar18);
                    local_478 = 0;
                    local_470 = 0;
                    local_4d8 = uVar8;
                    uStack_4d0 = uVar7;
                    local_320 = local_400;
                    puVar10 = (uint64 *)Matrix4x4.TRS(local_278,&local_478,&local_4d8,&local_408,0);
                    local_368 = *puVar10;
                    uStack_360 = puVar10[1];
                    local_358 = puVar10[2];
                    uStack_350 = puVar10[3];
                    local_348 = puVar10[4];
                    uStack_340 = puVar10[5];
                    local_338 = puVar10[6];
                    uStack_330 = puVar10[7];
                    if (*(uint32 *)(lVar15 + 24) <= uVar5) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    local_3f8 = *(uint64 *)(lVar15 + 32 + lVar14 * 12);
                    local_3f0 = *(uint32 *)(lVar15 + 40 + lVar14 * 12);
                    puVar10 = (uint64 *)Matrix4x4.MultiplyPoint3x4(local_2c8,&local_368,&local_3f8,0)
                    ;
                    if (*(uint32 *)(lVar15 + 24) <= uVar5) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    *(uint64 *)(lVar15 + 32 + lVar14 * 12) = *puVar10;
                    *(uint32 *)(lVar15 + 40 + lVar14 * 12) = *(uint32 *)(puVar10 + 1);
                    if (*(uint32 *)(lVar15 + 24) <= uVar16) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    local_3e8 = *(uint64 *)(lVar15 + 32 + lVar9 * 12);
                    local_3e0 = *(uint32 *)(lVar15 + 40 + lVar9 * 12);
                    puVar10 = (uint64 *)Matrix4x4.MultiplyPoint3x4(local_2b8,&local_368,&local_3e8,0)
                    ;
                    if (*(uint32 *)(lVar15 + 24) <= uVar16) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    *(uint64 *)(lVar15 + 32 + lVar9 * 12) = *puVar10;
                    *(uint32 *)(lVar15 + 40 + lVar9 * 12) = *(uint32 *)(puVar10 + 1);
                    uVar17 = (uint32)lVar1;
                    if (*(uint32 *)(lVar15 + 24) <= uVar17) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    local_3d8 = *(uint64 *)(lVar15 + 32 + lVar1 * 12);
                    local_3d0 = *(uint32 *)(lVar15 + 40 + lVar1 * 12);
                    puVar10 = (uint64 *)Matrix4x4.MultiplyPoint3x4(local_2a8,&local_368,&local_3d8,0)
                    ;
                    if (*(uint32 *)(lVar15 + 24) <= uVar17) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    *(uint64 *)(lVar15 + 32 + lVar1 * 12) = *puVar10;
                    *(uint32 *)(lVar15 + 40 + lVar1 * 12) = *(uint32 *)(puVar10 + 1);
                    if (*(uint32 *)(lVar15 + 24) <= uVar12) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    local_3c8 = *(uint64 *)(lVar15 + 32 + lVar2 * 12);
                    local_3c0 = *(uint32 *)(lVar15 + 40 + lVar2 * 12);
                    puVar10 = (uint64 *)Matrix4x4.MultiplyPoint3x4(local_298,&local_368,&local_3c8,0)
                    ;
                    if (*(uint32 *)(lVar15 + 24) <= uVar12) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    *(uint64 *)(lVar15 + 32 + lVar2 * 12) = *puVar10;
                    *(uint32 *)(lVar15 + 40 + lVar2 * 12) = *(uint32 *)(puVar10 + 1);
                    if (*(uint32 *)(lVar15 + 24) <= uVar5) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    local_3b0 = *(float *)(lVar15 + 40 + lVar14 * 12);
                    local_4d8 = *(uint64 *)(lVar15 + 32 + lVar14 * 12);
                    local_310 = local_3b0 + 0.0;
                    uVar3 = (uint32)((uint64)uStack_4d0 >> 32);
                    uStack_4d0 = CONCAT44(uVar3,local_3b0);
                    *(uint64 *)(lVar15 + 32 + lVar14 * 12) =
                         CONCAT44((float)((uint64)local_4d8 >> 32) + fVar19,(float)local_4d8 + fVar20
                                 );
                    *(float *)(lVar15 + 40 + lVar14 * 12) = local_310;
                    if (*(uint32 *)(lVar15 + 24) <= uVar16) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    local_3a0 = *(float *)(lVar15 + 40 + lVar9 * 12);
                    local_4d8 = *(uint64 *)(lVar15 + 32 + lVar9 * 12);
                    local_300 = local_3a0 + 0.0;
                    uStack_4d0 = CONCAT44(uVar3,local_3a0);
                    *(uint64 *)(lVar15 + 32 + lVar9 * 12) =
                         CONCAT44((float)((uint64)local_4d8 >> 32) + fVar19,(float)local_4d8 + fVar20
                                 );
                    *(float *)(lVar15 + 40 + lVar9 * 12) = local_300;
                    if (*(uint32 *)(lVar15 + 24) <= uVar17) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    local_390 = *(float *)(lVar15 + 40 + lVar1 * 12);
                    local_4d8 = *(uint64 *)(lVar15 + 32 + lVar1 * 12);
                    local_2f0 = local_390 + 0.0;
                    uStack_4d0 = CONCAT44(uVar3,local_390);
                    *(uint64 *)(lVar15 + 32 + lVar1 * 12) =
                         CONCAT44((float)((uint64)local_4d8 >> 32) + fVar19,(float)local_4d8 + fVar20
                                 );
                    *(float *)(lVar15 + 40 + lVar1 * 12) = local_2f0;
                    if (*(uint32 *)(lVar15 + 24) <= uVar12) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    local_380 = *(float *)(lVar15 + 40 + lVar2 * 12);
                    local_4d8 = *(uint64 *)(lVar15 + 32 + lVar2 * 12);
                    local_2e0 = local_380 + 0.0;
                    uStack_4d0 = CONCAT44(uVar3,local_380);
                    *(uint64 *)(lVar15 + 32 + lVar2 * 12) =
                         CONCAT44((float)((uint64)local_4d8 >> 32) + fVar19,(float)local_4d8 + fVar20
                                 );
                    *(float *)(lVar15 + 40 + lVar2 * 12) = local_2e0;
                    lVar15 = this.<cachedMeshInfoVertexData>5__3;
                    if (lVar15 == null) throw; // [null/range check failed]
                    if (*(uint32 *)(lVar15 + 24) <= uVar13) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    if ((this.<textInfo>5__2 == 0) ||
                       (lVar11 = *(int64 *)(this.<textInfo>5__2 + 96)) == null)
                    throw; // [null/range check failed]
                    if (*(uint32 *)(lVar11 + 24) <= uVar13) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    lVar15 = *(int64 *)(local_378 + 72 + lVar15);
                    if (lVar15 == null) throw; // [null/range check failed]
                    if (*(uint32 *)(lVar15 + 24) <= uVar5) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    lVar11 = *(int64 *)(local_378 + 72 + lVar11);
                    uVar3 = *(uint32 *)(lVar15 + 36 + lVar14 * 8);
                    if (lVar11 == null) throw; // [null/range check failed]
                    if (*(uint32 *)(lVar11 + 24) <= uVar5) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    *(uint32 *)(lVar11 + 32 + lVar14 * 8) =
                         *(uint32 *)(lVar15 + 32 + lVar14 * 8);
                    *(uint32 *)(lVar11 + 36 + lVar14 * 8) = uVar3;
                    if (*(uint32 *)(lVar15 + 24) <= uVar16) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    uVar3 = *(uint32 *)(lVar15 + 36 + lVar9 * 8);
                    if (*(uint32 *)(lVar11 + 24) <= uVar16) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    *(uint32 *)(lVar11 + 32 + lVar9 * 8) =
                         *(uint32 *)(lVar15 + 32 + lVar9 * 8);
                    *(uint32 *)(lVar11 + 36 + lVar9 * 8) = uVar3;
                    if (*(uint32 *)(lVar15 + 24) <= uVar17) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    uVar3 = *(uint32 *)(lVar15 + 36 + lVar1 * 8);
                    if (*(uint32 *)(lVar11 + 24) <= uVar17) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    *(uint32 *)(lVar11 + 32 + lVar1 * 8) =
                         *(uint32 *)(lVar15 + 32 + lVar1 * 8);
                    *(uint32 *)(lVar11 + 36 + lVar1 * 8) = uVar3;
                    if (*(uint32 *)(lVar15 + 24) <= uVar12) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    uVar3 = *(uint32 *)(lVar15 + 36 + lVar2 * 8);
                    if (*(uint32 *)(lVar11 + 24) <= uVar12) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    *(uint32 *)(lVar11 + 32 + lVar2 * 8) =
                         *(uint32 *)(lVar15 + 32 + lVar2 * 8);
                    *(uint32 *)(lVar11 + 36 + lVar2 * 8) = uVar3;
                    lVar15 = this.<cachedMeshInfoVertexData>5__3;
                    if (lVar15 == null) throw; // [null/range check failed]
                    if (*(uint32 *)(lVar15 + 24) <= uVar13) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    if ((this.<textInfo>5__2 == 0) ||
                       (lVar11 = *(int64 *)(this.<textInfo>5__2 + 96)) == null)
                    throw; // [null/range check failed]
                    if (*(uint32 *)(lVar11 + 24) <= uVar13) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    lVar15 = *(int64 *)(local_378 + 88 + lVar15);
                    if (lVar15 == null) throw; // [null/range check failed]
                    if (*(uint32 *)(lVar15 + 24) <= uVar5) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    lVar11 = *(int64 *)(local_378 + 88 + lVar11);
                    if (lVar11 == null) throw; // [null/range check failed]
                    if (*(uint32 *)(lVar11 + 24) <= uVar5) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    *(uint32 *)(lVar11 + 32 + lVar14 * 4) =
                         *(uint32 *)(lVar15 + 32 + lVar14 * 4);
                    if (*(uint32 *)(lVar15 + 24) <= uVar16) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    if (*(uint32 *)(lVar11 + 24) <= uVar16) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    *(uint32 *)(lVar11 + 32 + lVar9 * 4) =
                         *(uint32 *)(lVar15 + 32 + lVar9 * 4);
                    if (*(uint32 *)(lVar15 + 24) <= uVar17) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    if (*(uint32 *)(lVar11 + 24) <= uVar17) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    *(uint32 *)(lVar11 + 32 + lVar1 * 4) =
                         *(uint32 *)(lVar15 + 32 + lVar1 * 4);
                    if (*(uint32 *)(lVar15 + 24) <= uVar12) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    if (*(uint32 *)(lVar11 + 24) <= uVar12) {
                      uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar8,0);
                    }
                    *(uint32 *)(lVar11 + 32 + lVar2 * 4) =
                         *(uint32 *)(lVar15 + 32 + lVar2 * 4);
                  }
                  local_res18 = local_res18 + 1;
                  lVar15 = local_468;
                } while ((int)local_res18 < local_4c8);
              }
              uVar13 = 0;
              lVar14 = this.<textInfo>5__2;
              if (lVar14 != null) {
                while (*(int64 *)(lVar14 + 96) != 0) {
                  if (*(int *)(*(int64 *)(lVar14 + 96) + 24) <= (int)uVar13) {
                    uVar8 = new WaitForSeconds(0x3dcccccd,0);
                    this.<>2__current = uVar8;
                    this.<>1__state = 2;
                    return true;
                  }
                  lVar14 = this.<>8__1;
                  lVar11 = this.<scaleSortingOrder>5__4;
                  if (lVar14 == null) break;
                  lVar9 = *(int64 *)(lVar14 + 24);
                  if (lVar9 == null) {
                    lVar9 = new OnTooltipCB(lVar14,DAT_181d8f0f0,DAT_181d86018);
                    *(int64 *)(lVar14 + 24) = lVar9;
                  }
                  if (lVar11 == null) break;
                  List_1.Sort(lVar11,lVar9,DAT_181d68070);
                  if ((this.<textInfo>5__2 == 0) ||
                     (lVar14 = *(int64 *)(this.<textInfo>5__2 + 96)) == null) break;
                  if (*(uint32 *)(lVar14 + 24) <= uVar13) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  lVar11 = (int64)(int)uVar13 * 80;
                  TMP_MeshInfo.SortGeometry(lVar14 + 32 + lVar11,this.<scaleSortingOrder>5__4,0);
                  if ((this.<textInfo>5__2 == 0) ||
                     (lVar14 = *(int64 *)(this.<textInfo>5__2 + 96)) == null) break;
                  if (*(uint32 *)(lVar14 + 24) <= uVar13) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  lVar9 = *(int64 *)(lVar11 + 32 + lVar14);
                  if (lVar9 == null) break;
                  Mesh.set_vertices(lVar9,*(uint64 *)(lVar11 + 48 + lVar14),0);
                  if ((this.<textInfo>5__2 == 0) ||
                     (lVar14 = *(int64 *)(this.<textInfo>5__2 + 96)) == null) break;
                  if (*(uint32 *)(lVar14 + 24) <= uVar13) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  lVar9 = *(int64 *)(lVar11 + 32 + lVar14);
                  if (lVar9 == null) break;
                  Mesh.set_uv(lVar9,*(uint64 *)(lVar11 + 72 + lVar14),0);
                  if ((this.<textInfo>5__2 == 0) ||
                     (lVar14 = *(int64 *)(this.<textInfo>5__2 + 96)) == null) break;
                  if (*(uint32 *)(lVar14 + 24) <= uVar13) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  lVar9 = *(int64 *)(lVar11 + 32 + lVar14);
                  if (lVar9 == null) break;
                  Mesh.set_colors32(lVar9,*(uint64 *)(lVar11 + 88 + lVar14),0);
                  if ((this.<textInfo>5__2 == 0) ||
                     (lVar14 = *(int64 *)(this.<textInfo>5__2 + 96)) == null) break;
                  if (*(uint32 *)(lVar14 + 24) <= uVar13) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  plVar6 = *(int64 **)(lVar15 + 40);
                  if (plVar6 == (int64 *)0) break;
                  (**(code **)(*plVar6 + 0x7e8))
                            (plVar6,*(uint64 *)(lVar14 + 32 + lVar11),uVar13,
                             *(uint64 *)(*plVar6 + 0x7f0));
                  lVar14 = this.<textInfo>5__2;
                  uVar13 = uVar13 + 1;
                  if (lVar14 == null) break;
                }
              }
            }
          }
        }
    }

    // Token : 0x60024D9
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x60024DA
    // RVA   : 0xB0D300   Offset: 0xB0BB00   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d8f178);
    }

    // Token : 0x60024DB
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
