// ============================================================
// Type  : <BattleUnitAttackHappen>d__231
// Token : 0x200016B
// ============================================================

public class <BattleUnitAttackHappen>d__231
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400095F
    private int <>1__state;

    // Token: 0x4000960
    private object <>2__current;

    // Token: 0x4000961
    public BattleController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000BCD
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000BCE
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000BCF
    // RVA   : 0xB1EFB0   Offset: 0xB1D7B0   Length: 0x190B
    private virtual bool MoveNext()
    {
        var pStatics = *(int64*)(DAT_181d8b128 + 184);
        int iVar2;
        long lVar3;
        uint uVar4;
        uint uVar5;
        int iVar6;
        long lVar7;
        ulong uVar9;
        ulong uVar10;
        long lVar11;
        long lVar12;
        ulong uVar13;
        uint uVar14;
        long lVar15;
        float fVar16;
        float fVar17;
        float fVar18;
        float local_res8;
        float fStackX_c;
        uint64 local_res18;
        uint32 local_res20;
        uint32 uStackX_24;
        uint64 in_stack_fffffffffffffb40;
        float local_488;
        float fStack_484;
        float local_478;
        float fStack_474;
        float local_438;
        float fStack_434;
        float local_418;
        float fStack_414;
        float local_3f8;
        float fStack_3f4;
        float local_3d8;
        float fStack_3d4;
        float local_3a8;
        float fStack_3a4;
        uint64 local_388;
        uint32 local_380;
        float local_370;
        uint64 local_368;
        float local_360;
        float local_350;
        float local_340;
        float local_330;
        uint64 local_328;
        float local_320;
        float local_310;
        uint64 local_308;
        float local_300;
        float local_2f0;
        uint64 local_2e8;
        float local_2e0;
        float local_2d0;
        uint64 local_2c8;
        float local_2c0;
        float local_2b0;
        uint64 local_2a8;
        float local_2a0;
        uint64 local_298;
        uint64 local_288;
        uint64 local_278;
        uint32 local_270;
        float local_260;
        uint64 local_258;
        float local_250;
        uint64 local_248;
        float local_240;
        float local_230;
        uint8 local_228 [8];
        float local_220;
        uint8 local_218 [8];
        float local_210;
        uint8 local_208 [16];
        uint8 local_1f8 [16];
        uint8 local_1e8 [16];
        uint8 local_1d8 [16];
        uint8 local_1c8 [16];
        uint8 local_1b8 [16];
        uint8 local_1a8 [16];
        uint8 local_198 [16];
        uint8 local_188 [16];
        uint8 local_178 [16];
        uint8 local_168 [16];
        uint8 local_158 [16];
        uint8 local_148 [16];
        uint8 local_138 [16];
        uint8 local_128 [16];
        uint8 local_118 [16];
        uint8 local_108 [16];
        uint8 local_f8 [16];
        uint8 local_e8 [176];
        uVar4 = (uint32)((uint64)in_stack_fffffffffffffb40 >> 32);
        uVar14 = 0;
        lVar3 = this.<>4__this;
        local_res18 = 0;
        if (this.<>1__state != 0) {
          if (this.<>1__state == 1) {
            this.<>1__state = 0xffffffff;
          }
          return false;
        }
        this.<>1__state = 0xffffffff;
        if (lVar3 != null) {
          if (*(char *)(lVar3 + 0x2b9) == false) {
            return false;
          }
          if (*(int64 *)(lVar3 + 0x2b0) != 0) {
            FUN_180f56130(*(int64 *)(lVar3 + 0x2b0),DAT_181d637f8);
            if (*(int64 *)(lVar3 + 0x2a8) != 0) {
              FUN_180f56130(*(int64 *)(lVar3 + 0x2a8),DAT_181d58228);
              *(uint8 *)(lVar3 + 0x2b8) = 0;
              if (*(int64 *)(lVar3 + 0x110) != 0) {
                BattleController.ManageSkillSpeEffect
                          (lVar3,1,1,*(uint64 *)(*(int64 *)(lVar3 + 0x110) + 96),1,
                           CONCAT44(uVar4,1),0);
                *(uint32 *)(lVar3 + 700) = 999999;
                *(uint32 *)(lVar3 + 0x2c0) = 0xfff0bdc1;
                lVar15 = 32;
                *(uint32 *)(lVar3 + 0x2c4) = 0x497423f0;
                while (lVar7 = *(int64 *)(lVar3 + 0x208)) != null {
                  if ((int)*(uint32 *)(lVar7 + 24) <= (int)uVar14) {
                    iVar6 = 0;
                    goto LAB_180b1f4a0;
                  }
                  if (*(uint32 *)(lVar7 + 24) <= uVar14) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar7 = *(int64 *)(lVar15 + *(int64 *)(lVar7 + 16));
                  if (((lVar7 == null) || (*(int64 *)(lVar3 + 0x110) == 0)) ||
                     (lVar11 = *(int64 *)(*(int64 *)(lVar3 + 0x110) + 96)) == null) break;
                  uVar4 = Mathf.Abs(*(int *)(lVar7 + 40) - *(int *)(lVar11 + 40),0);
                  lVar7 = *(int64 *)(lVar3 + 0x208);
                  if (lVar7 == null) break;
                  if (*(uint32 *)(lVar7 + 24) <= uVar14) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar7 = *(int64 *)(lVar15 + *(int64 *)(lVar7 + 16));
                  if (((lVar7 == null) || (*(int64 *)(lVar3 + 0x110) == 0)) ||
                     (lVar11 = *(int64 *)(*(int64 *)(lVar3 + 0x110) + 96)) == null) break;
                  uVar5 = Mathf.Abs(*(int *)(lVar7 + 36) - *(int *)(lVar11 + 36),0);
                  iVar6 = Mathf.Max(uVar4,uVar5,0);
                  if (iVar6 < *(int *)(lVar3 + 700)) {
                    *(int *)(lVar3 + 700) = iVar6;
                  }
                  if (*(int *)(lVar3 + 0x2c0) < iVar6) {
                    *(int *)(lVar3 + 0x2c0) = iVar6;
                  }
                  if (((*(int64 *)(lVar3 + 0x208) == 0) ||
                      (lVar7 = FUN_180002f80(*(int64 *)(lVar3 + 0x208),uVar14)) == null) ||
                     ((lVar7 = GridUnitData.get_GridObj(lVar7,0), lVar7 == null ||
                      (lVar7 = GameObject.get_transform(lVar7,0)) == null))) break;
                  puVar8 = (uint64 *)Transform.get_localPosition(local_218,lVar7);
                  uVar9 = *puVar8;
                  if (((*(int64 *)(lVar3 + 0x110) == 0) ||
                      (lVar7 = *(int64 *)(*(int64 *)(lVar3 + 0x110) + 96)) == null) ||
                     ((lVar7 = GridUnitData.get_GridObj(lVar7,0), lVar7 == null ||
                      (lVar7 = GameObject.get_transform(lVar7,0)) == null))) break;
                  Transform.get_localPosition(local_228,lVar7);
                  fVar16 = (float)Vector2.Distance(uVar9);
                  if (fVar16 < *(float *)(lVar3 + 0x2c4)) {
                    *(float *)(lVar3 + 0x2c4) = fVar16;
                  }
                  uVar14 = uVar14 + 1;
                  lVar15 = lVar15 + 8;
                }
              }
            }
          }
        }
        throw; // [null/range check failed]
        LAB_180b1f4a0:
        if (*(int64 *)(lVar3 + 0x208) != 0) {
          lVar15 = *(int64 *)(lVar3 + 0x110);
          if (*(int *)(*(int64 *)(lVar3 + 0x208) + 24) <= iVar6) {
            if ((lVar15 != null) && (*(int64 *)(lVar15 + 64) != 0)) {
              uVar9 = HeroData.GetHeroShoutSound(*(int64 *)(lVar15 + 64),0);
              BattleUnit.PlayHeroSound(lVar15,uVar9,0,1,1,0);
              this.<>2__current = 0;
              this.<>1__state = 1;
              return true;
            }
            throw; // [null/range check failed]
          }
          if ((((lVar15 == null) || (*(int64 *)(lVar15 + 64) == 0)) ||
              (lVar15 = HeroData.GetNowActiveSkill(*(int64 *)(lVar15 + 64),0)) == null) ||
             (lVar15 = KungfuSkillLvData.DataBase(lVar15,0)) == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar15 + 168) == 0) {
            if (*(int64 *)(lVar3 + 0x208) == 0) throw; // [null/range check failed]
            uVar9 = FUN_180002f80(*(int64 *)(lVar3 + 0x208),iVar6,DAT_181d63bf8);
            if (*(int64 *)(lVar3 + 0x208) == 0) throw; // [null/range check failed]
            uVar10 = FUN_180002f80(*(int64 *)(lVar3 + 0x208),iVar6);
            uVar10 = BattleController.GetBattleUnitAttackHitDelay(lVar3,uVar10);
            BattleController.BattleUnitAttackHit(lVar3,uVar9,uVar10);
            FUN_180d837c0(lVar3);
            iVar6 = iVar6 + 1;
          }
          else {
            lVar15 = new ZhSegment(0);
            if (lVar15 == null) throw; // [null/range check failed]
            *(int64 *)(lVar15 + 32) = lVar3;
            if (*(int64 *)(lVar3 + 200) == 0) throw; // [null/range check failed]
            uVar10 = Component.get_gameObject(*(int64 *)(lVar3 + 200),0);
            uVar9 = *(uint64 *)(lVar3 + 0x168);
            lVar7 = GlobalData.AddChild(uVar10,uVar9,0);
            plVar1 = (int64 *)(lVar15 + 16);
            *plVar1 = lVar7;
            il2cpp_internal(plVar1,lVar7);
            if (*plVar1 == 0) throw; // [null/range check failed]
            lVar7 = GameObject.GetComponent(*plVar1,DAT_181da19b0);
            lVar11 = FUN_18046c6c0(0);
            if ((((*(int64 *)(lVar3 + 0x110) == 0) ||
                 (lVar12 = *(int64 *)(*(int64 *)(lVar3 + 0x110) + 64)) == null) ||
                ((lVar12 = HeroData.GetNowActiveSkill(lVar12,0), lVar12 == null ||
                 (((lVar12 = KungfuSkillLvData.DataBase(lVar12,0), lVar12 == null ||
                   (*(int64 *)(lVar12 + 168) == 0)) || (lVar11 == null)))))) ||
               (uVar9 = TextureController.LoadAtlasSprite
                                  (lVar11,"SkillBullet",
                                   *(uint64 *)(*(int64 *)(lVar12 + 168) + 16),0), lVar7 == null))
            throw; // [null/range check failed]
            SpriteRenderer.set_sprite(lVar7,uVar9,0);
            if (*plVar1 == 0) throw; // [null/range check failed]
            lVar7 = GameObject.get_transform(*plVar1,0);
            puVar8 = (uint64 *)Vector3.get_one(local_208,0);
            fVar16 = *(float *)(puVar8 + 1);
            uVar9 = *puVar8;
            if (((*(int64 *)(lVar3 + 0x110) == 0) ||
                (lVar11 = *(int64 *)(*(int64 *)(lVar3 + 0x110) + 64)) == null) ||
               ((lVar11 = HeroData.GetNowActiveSkill(lVar11,0), lVar11 == null ||
                ((lVar11 = KungfuSkillLvData.DataBase(lVar11,0), lVar11 == null ||
                 (*(int64 *)(lVar11 + 168) == 0)))))) throw; // [null/range check failed]
            fVar18 = *(float *)(*(int64 *)(lVar11 + 168) + 40);
            local_478 = (float)uVar9;
            fStack_474 = (float)((uint64)uVar9 >> 32);
            if (lVar7 == null) throw; // [null/range check failed]
            local_248 = CONCAT44(fStack_474 * fVar18,local_478 * fVar18);
            local_240 = fVar16 * fVar18;
            Transform.set_localScale(lVar7,&local_248,0);
            if (*(int64 *)(lVar3 + 0x208) == 0) throw; // [null/range check failed]
            uVar9 = FUN_180002f80(*(int64 *)(lVar3 + 0x208),iVar6,DAT_181d63bf8);
            *(uint64 *)(lVar15 + 24) = uVar9;
            if ((((*(int64 *)(lVar3 + 0x110) == 0) ||
                 (lVar7 = *(int64 *)(*(int64 *)(lVar3 + 0x110) + 64)) == null) ||
                (lVar7 = HeroData.GetNowActiveSkill(lVar7,0)) == null) ||
               ((lVar7 = KungfuSkillLvData.DataBase(lVar7,0), lVar7 == null ||
                (*(int64 *)(lVar7 + 168) == 0)))) throw; // [null/range check failed]
            iVar2 = *(int *)(*(int64 *)(lVar7 + 168) + 24);
            if (iVar2 == 0) {
              if (*plVar1 == 0) throw; // [null/range check failed]
              lVar7 = GameObject.get_transform(*plVar1,0);
              if ((*(int64 *)(lVar3 + 0x110) == 0) ||
                 (lVar11 = Component.get_transform(*(int64 *)(lVar3 + 0x110),0)) == null)
              throw; // [null/range check failed]
              puVar8 = (uint64 *)Transform.get_localPosition(local_198,lVar11,0);
              uVar9 = *puVar8;
              fVar16 = *(float *)(puVar8 + 1);
              if ((*(int64 *)(lVar3 + 0x110) == 0) ||
                 ((lVar11 = *(int64 *)(*(int64 *)(lVar3 + 0x110) + 48), lVar11 == null ||
                  (lVar11 = GameObject.get_transform(lVar11,0)) == null))) throw; // [null/range check failed]
              puVar8 = (uint64 *)Transform.get_localPosition(local_188,lVar11,0);
              local_3f8 = (float)uVar9;
              fStack_3f4 = (float)((uint64)uVar9 >> 32);
              uVar9 = *puVar8;
              local_2d0 = *(float *)(puVar8 + 1);
              fVar16 = fVar16 + local_2d0;
              local_2c8 = CONCAT44(fStack_3f4 + (float)((uint64)uVar9 >> 32),local_3f8 + (float)uVar9
                                  );
              local_2c0 = fVar16;
              puVar8 = (uint64 *)GlobalData.SetZToZero(local_178,&local_2c8,0);
              uVar9 = *puVar8;
              fVar16 = *(float *)(puVar8 + 1);
              local_3d8 = (float)uVar9;
              fStack_3d4 = (float)((uint64)uVar9 >> 32);
              uVar9 = *(uint64 *)(pStatics + 16);
              local_2b0 = *(float *)(pStatics + 24);
              if (lVar7 == null) throw; // [null/range check failed]
              local_2a8 = CONCAT44(fStack_3d4 + (float)((uint64)uVar9 >> 32),local_3d8 + (float)uVar9
                                  );
              puVar8 = &local_2a8;
              local_2a0 = fVar16 + local_2b0;
        LAB_180b1fe9f:
              Transform.set_localPosition(lVar7,puVar8,0);
            }
            else {
              if (iVar2 == 1) {
                if (*plVar1 != 0) {
                  lVar7 = GameObject.get_transform(*plVar1,0);
                  if ((*(int64 *)(lVar3 + 0x110) != 0) &&
                     (lVar11 = Component.get_transform(*(int64 *)(lVar3 + 0x110),0)) != null) {
                    puVar8 = (uint64 *)Transform.get_localPosition(local_1c8,lVar11,0);
                    uVar9 = *puVar8;
                    fVar16 = *(float *)(puVar8 + 1);
                    if ((*(int64 *)(lVar3 + 0x110) != 0) &&
                       ((lVar11 = *(int64 *)(*(int64 *)(lVar3 + 0x110) + 48), lVar11 != null &&
                        (lVar11 = GameObject.get_transform(lVar11,0)) != null))) {
                      puVar8 = (uint64 *)Transform.get_localPosition(local_1b8,lVar11,0);
                      local_438 = (float)uVar9;
                      fStack_434 = (float)((uint64)uVar9 >> 32);
                      uVar9 = *puVar8;
                      local_310 = *(float *)(puVar8 + 1);
                      fVar16 = fVar16 + local_310;
                      local_308 = CONCAT44(fStack_434 + (float)((uint64)uVar9 >> 32),
                                           local_438 + (float)uVar9);
                      local_300 = fVar16;
                      puVar8 = (uint64 *)GlobalData.SetZToZero(local_1a8,&local_308,0);
                      uVar9 = *puVar8;
                      fVar16 = *(float *)(puVar8 + 1);
                      local_488 = (float)uVar9;
                      fStack_484 = (float)((uint64)uVar9 >> 32);
                      uVar9 = *(uint64 *)(pStatics + 16);
                      local_2f0 = *(float *)(pStatics + 24);
                      if (lVar7 != null) {
                        local_2e8 = CONCAT44(fStack_484 + (float)((uint64)uVar9 >> 32),
                                             local_488 + (float)uVar9);
                        puVar8 = &local_2e8;
                        local_2e0 = fVar16 + local_2f0;
                        goto LAB_180b1fe9f;
                      }
                    }
                  }
                }
                throw; // [null/range check failed]
              }
              if (iVar2 == 2) {
                if (*plVar1 != 0) {
                  lVar7 = GameObject.get_transform(*plVar1,0);
                  if ((((*(int64 *)(lVar3 + 0x208) != 0) &&
                       (lVar11 = FUN_180002f80(*(int64 *)(lVar3 + 0x208),iVar6,DAT_181d63bf8),
                       lVar11 != null)) && (lVar11 = GridUnitData.get_GridObj(lVar11,0)) != null) &&
                     (lVar11 = GameObject.get_transform(lVar11,0)) != null) {
                    puVar8 = (uint64 *)Transform.get_localPosition(local_1e8,lVar11,0);
                    uVar9 = *puVar8;
                    local_340 = *(float *)(puVar8 + 1);
                    puVar8 = (uint64 *)Vector3.get_up(local_1d8,0);
                    uVar10 = *puVar8;
                    local_350 = *(float *)(puVar8 + 1);
                    fVar16 = local_350 * 5.0 + local_340;
                    uVar13 = *(uint64 *)(pStatics + 16);
                    local_330 = *(float *)(pStatics + 24);
                    if (lVar7 != null) {
                      local_328 = CONCAT44((float)((uint64)uVar13 >> 32) +
                                           (float)((uint64)uVar10 >> 32) * 5.0 +
                                           (float)((uint64)uVar9 >> 32),
                                           (float)uVar13 + (float)uVar10 * 5.0 + (float)uVar9);
                      puVar8 = &local_328;
                      local_320 = local_330 + fVar16;
                      goto LAB_180b1fe9f;
                    }
                  }
                }
                throw; // [null/range check failed]
              }
              if (iVar2 == 3) {
                if (*plVar1 != 0) {
                  lVar7 = GameObject.get_transform(*plVar1,0);
                  if (((*(int64 *)(lVar3 + 0x208) != 0) &&
                      (lVar11 = FUN_180002f80(*(int64 *)(lVar3 + 0x208),iVar6,DAT_181d63bf8),
                      lVar11 != null)) &&
                     ((lVar11 = GridUnitData.get_GridObj(lVar11,0), lVar11 != null &&
                      (lVar11 = GameObject.get_transform(lVar11,0)) != null))) {
                    puVar8 = (uint64 *)Transform.get_localPosition(local_1f8,lVar11,0);
                    uVar9 = *puVar8;
                    local_230 = *(float *)(puVar8 + 1);
                    local_res18 = Random.get_insideUnitCircle(0);
                    uVar10 = Vector2.get_normalized(&local_res18,0);
                    local_res8 = (float)uVar10;
                    fStackX_c = (float)((uint64)uVar10 >> 32);
                    fVar16 = local_230 + 0.0;
                    uVar10 = *(uint64 *)(pStatics + 16);
                    local_370 = *(float *)(pStatics + 24);
                    if (lVar7 != null) {
                      local_368 = CONCAT44((float)((uint64)uVar10 >> 32) +
                                           (float)((uint64)uVar9 >> 32) + fStackX_c * 5.0,
                                           (float)uVar9 + local_res8 * 5.0 + (float)uVar10);
                      puVar8 = &local_368;
                      local_360 = local_370 + fVar16;
                      goto LAB_180b1fe9f;
                    }
                  }
                }
                throw; // [null/range check failed]
              }
            }
            if ((((*(int64 *)(lVar3 + 0x110) == 0) ||
                 (lVar7 = *(int64 *)(*(int64 *)(lVar3 + 0x110) + 64)) == null) ||
                (lVar7 = HeroData.GetNowActiveSkill(lVar7,0)) == null) ||
               ((lVar7 = KungfuSkillLvData.DataBase(lVar7,0), lVar7 == null ||
                (*(int64 *)(lVar7 + 168) == 0)))) throw; // [null/range check failed]
            iVar2 = *(int *)(*(int64 *)(lVar7 + 168) + 32);
            if (iVar2 == 1) {
              if (*plVar1 == 0) throw; // [null/range check failed]
              lVar7 = GameObject.get_transform(*plVar1,0);
              if ((((*(int64 *)(lVar3 + 0x208) == 0) ||
                   (lVar11 = FUN_180002f80(*(int64 *)(lVar3 + 0x208),iVar6,DAT_181d63bf8)) == null
                   ) || (lVar11 = GridUnitData.get_GridObj(lVar11,0)) == null) ||
                 (lVar11 = GameObject.get_transform(lVar11,0)) == null) throw; // [null/range check failed]
              puVar8 = (uint64 *)Transform.get_localPosition(local_168,lVar11,0);
              local_298 = *puVar8;
              local_288 = local_298;
              if ((*plVar1 == 0) || (lVar11 = GameObject.get_transform(*plVar1,0)) == null)
              throw; // [null/range check failed]
              puVar8 = (uint64 *)Transform.get_localPosition(local_158,lVar11,0);
              if (lVar7 == null) throw; // [null/range check failed]
              local_278 = CONCAT44(local_288._4_4_ - (float)((uint64)*puVar8 >> 32),
                                   (float)local_298 - (float)*puVar8);
              local_270 = 0;
              Transform.set_right(lVar7,&local_278,0);
            }
            else if (iVar2 == 2) {
              if (*plVar1 == 0) throw; // [null/range check failed]
              uVar9 = GameObject.get_transform(*plVar1,0);
              if (((*(int64 *)(lVar3 + 0x110) == 0) ||
                  (lVar7 = *(int64 *)(*(int64 *)(lVar3 + 0x110) + 64)) == null) ||
                 ((lVar7 = HeroData.GetNowActiveSkill(lVar7,0), lVar7 == null ||
                  ((lVar7 = KungfuSkillLvData.DataBase(lVar7,0), lVar7 == null ||
                   (*(int64 *)(lVar7 + 168) == 0)))))) throw; // [null/range check failed]
              local_388 = 0;
              local_380 = 0xc3b40000;
              uVar9 = ShortcutExtensions.DORotate
                                (uVar9,&local_388,*(uint32 *)(*(int64 *)(lVar7 + 168) + 36),1,0)
              ;
              uVar9 = TweenSettingsExtensions.SetLoops(uVar9,0xffffffff);
              TweenSettingsExtensions.SetEase(uVar9,1,DAT_181d97a88);
            }
            fVar16 = 0.0;
            uVar4 = 0;
            if (((*(int64 *)(lVar3 + 0x110) == 0) ||
                (lVar7 = *(int64 *)(*(int64 *)(lVar3 + 0x110) + 64)) == null) ||
               ((lVar7 = HeroData.GetNowActiveSkill(lVar7,0), lVar7 == null ||
                ((lVar7 = KungfuSkillLvData.DataBase(lVar7,0), lVar7 == null ||
                 (*(int64 *)(lVar7 + 168) == 0)))))) throw; // [null/range check failed]
            fVar18 = *(float *)(*(int64 *)(lVar7 + 168) + 28);
            fVar17 = (float)BattleController.GetHalfBattleTimeScale(lVar3,0);
            fVar17 = fVar17 * fVar18;
            if ((*(int64 *)(lVar3 + 0x110) == 0) ||
               (((lVar7 = *(int64 *)(*(int64 *)(lVar3 + 0x110) + 64), lVar7 == null ||
                 (lVar7 = HeroData.GetNowActiveSkill(lVar7,0)) == null) ||
                (lVar7 = KungfuSkillLvData.DataBase(lVar7,0)) == null))) throw; // [null/range check failed]
            iVar2 = *(int *)(lVar7 + 184);
            if (iVar2 == 0) {
              fVar16 = *(float *)(lVar3 + 0x2c4);
              uVar4 = 0;
        LAB_180b20390:
              fVar16 = fVar16 / fVar17;
            }
            else if (iVar2 == 1) {
              fVar16 = *(float *)(lVar3 + 0x2c4);
              uVar4 = 0;
              if (((*(int64 *)(lVar3 + 0x208) == 0) ||
                  (lVar7 = FUN_180002f80(*(int64 *)(lVar3 + 0x208),iVar6,DAT_181d63bf8)) == null)
                 || ((lVar7 = GridUnitData.get_GridObj(lVar7,0), lVar7 == null ||
                     (lVar7 = GameObject.get_transform(lVar7,0)) == null))) throw; // [null/range check failed]
              puVar8 = (uint64 *)Transform.get_localPosition(local_128,lVar7,0);
              uVar9 = *puVar8;
              if ((*plVar1 == 0) || (lVar7 = GameObject.get_transform(*plVar1,0)) == null)
              throw; // [null/range check failed]
              puVar8 = (uint64 *)Transform.get_localPosition(local_118,lVar7,0);
              fVar18 = (float)Vector2.Distance(uVar9,*puVar8,0);
              fVar16 = fVar16 / fVar17 + (fVar18 - *(float *)(lVar3 + 0x2c4)) * 0.2;
            }
            else if (iVar2 == 2) {
              fVar16 = (float)Random.Range(0x3f333333,0x3fa66666,0);
              if ((((*(int64 *)(lVar3 + 0x208) != 0) &&
                   (lVar7 = FUN_180002f80(*(int64 *)(lVar3 + 0x208),iVar6,DAT_181d63bf8)) != null)
                  && (lVar7 = GridUnitData.get_GridObj(lVar7,0)) != null) &&
                 (lVar7 = GameObject.get_transform(lVar7,0)) != null) {
                puVar8 = (uint64 *)Transform.get_localPosition(local_148,lVar7,0);
                local_res20 = (uint32)*puVar8;
                uStackX_24 = (uint32)((uint64)*puVar8 >> 32);
                if ((*plVar1 != 0) && (lVar7 = GameObject.get_transform(*plVar1,0)) != null) {
                  puVar8 = (uint64 *)Transform.get_localPosition(local_138,lVar7,0);
                  uVar9 = Vector2.Distance(CONCAT44(uStackX_24,local_res20),*puVar8,0);
                  uVar4 = (uint32)((uint64)uVar9 >> 32);
                  fVar16 = (float)uVar9 * fVar16;
                  goto LAB_180b20390;
                }
              }
              throw; // [null/range check failed]
            }
            if (((*(int64 *)(lVar3 + 0x110) == 0) ||
                (lVar7 = *(int64 *)(*(int64 *)(lVar3 + 0x110) + 64)) == null) ||
               ((lVar7 = HeroData.GetNowActiveSkill(lVar7,0), lVar7 == null ||
                ((lVar7 = KungfuSkillLvData.DataBase(lVar7,0), lVar7 == null ||
                 (*(int64 *)(lVar7 + 168) == 0)))))) throw; // [null/range check failed]
            if (*(int *)(*(int64 *)(lVar7 + 168) + 24) == 1) {
              lVar7 = new ZhSegment(0);
              if (lVar7 == null) throw; // [null/range check failed]
              *(int64 *)(lVar7 + 48) = lVar15;
              if (((*(int64 *)(lVar7 + 48) == 0) ||
                  (lVar15 = *(int64 *)(*(int64 *)(lVar7 + 48) + 16)) == null) ||
                 (lVar15 = GameObject.get_transform(lVar15,0)) == null) throw; // [null/range check failed]
              puVar8 = (uint64 *)Transform.get_localPosition(local_f8,lVar15,0);
              *(uint64 *)(lVar7 + 16) = *puVar8;
              *(uint32 *)(lVar7 + 24) = *(uint32 *)(puVar8 + 1);
              if (((*(int64 *)(lVar3 + 0x208) == 0) ||
                  (lVar15 = FUN_180002f80(*(int64 *)(lVar3 + 0x208),iVar6,DAT_181d63bf8)) == null)
                 || ((lVar15 = GridUnitData.get_GridObj(lVar15,0), lVar15 == null ||
                     (lVar15 = GameObject.get_transform(lVar15,0)) == null))) throw; // [null/range check failed]
              puVar8 = (uint64 *)Transform.get_localPosition(local_e8,lVar15,0);
              uVar9 = *puVar8;
              fVar18 = *(float *)(puVar8 + 1);
              fStack_3a4 = (float)((uint64)uVar9 >> 32);
              local_3a8 = (float)uVar9;
              uVar9 = *(uint64 *)(pStatics + 16);
              local_3a8 = local_3a8 + (float)uVar9;
              fStack_3a4 = fStack_3a4 + (float)((uint64)uVar9 >> 32);
              local_210 = fVar18 + *(float *)(pStatics + 24);
              *(uint64 *)(lVar7 + 28) = CONCAT44(fStack_3a4,local_3a8);
              *(float *)(lVar7 + 36) = local_210;
              fVar18 = (float)Vector2.Distance(*(uint64 *)(lVar7 + 16),
                                                CONCAT44(fStack_3a4,local_3a8),0);
              *(float *)(lVar7 + 40) = fVar18 * 0.3;
              uVar9 = new OnTooltipCB(lVar7,DAT_181d6e598);
              uVar9 = DOTween.To(uVar9,0,0x3f800000,fVar16,0);
              uVar10 = TweenSettingsExtensions.SetEase(uVar9,1,DAT_181d97db8);
              uVar9 = *(uint64 *)(lVar7 + 48);
              uVar13 = new OnTooltipCB(uVar9,DAT_181d6e518);
              uVar9 = DAT_181d96ff8;
            }
            else {
              if (*plVar1 == 0) throw; // [null/range check failed]
              uVar9 = GameObject.get_transform(*plVar1,0);
              if ((((*(int64 *)(lVar3 + 0x208) == 0) ||
                   (lVar7 = FUN_180002f80(*(int64 *)(lVar3 + 0x208),iVar6,DAT_181d63bf8)) == null)
                  || (lVar7 = GridUnitData.get_GridObj(lVar7,0)) == null) ||
                 (lVar7 = GameObject.get_transform(lVar7,0)) == null) throw; // [null/range check failed]
              puVar8 = (uint64 *)Transform.get_localPosition(local_108,lVar7,0);
              uVar10 = *puVar8;
              fVar18 = *(float *)(puVar8 + 1);
              fStack_414 = (float)((uint64)uVar10 >> 32);
              uVar13 = *(uint64 *)(pStatics + 16);
              local_260 = *(float *)(pStatics + 24);
              local_418 = (float)uVar10;
              local_250 = fVar18 + local_260;
              local_258 = CONCAT44(fStack_414 + (float)((uint64)uVar13 >> 32),
                                   (float)uVar13 + local_418);
              local_220 = local_250;
              uVar9 = ShortcutExtensions.DOLocalMove(uVar9,&local_258,CONCAT44(uVar4,fVar16),0,0);
              uVar10 = TweenSettingsExtensions.SetEase(uVar9,1,DAT_181d97ca8);
              uVar13 = new OnTooltipCB(lVar15,DAT_181d6e498);
              uVar9 = DAT_181d96ee8;
            }
            TweenSettingsExtensions.OnComplete(uVar10,uVar13,uVar9);
            if (*(int64 *)(lVar3 + 248) == 0) throw; // [null/range check failed]
            FUN_181827900();
            iVar6 = iVar6 + 1;
          }
          goto LAB_180b1f4a0;
        }
    }

    // Token : 0x6000BD0
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000BD1
    // RVA   : 0xB208C0   Offset: 0xB1F0C0   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d6e798);
    }

    // Token : 0x6000BD2
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
