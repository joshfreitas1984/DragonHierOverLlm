// ============================================================
// Type  : <BattleUnitAttackFinish>d__234
// Token : 0x200016D
// ============================================================

public class <BattleUnitAttackFinish>d__234
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000967
    private int <>1__state;

    // Token: 0x4000968
    private object <>2__current;

    // Token: 0x4000969
    public BattleController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000BD9
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000BDA
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000BDB
    // RVA   : 0xB1DD80   Offset: 0xB1C580   Length: 0x11E4
    private virtual bool MoveNext()
    {
        var pStatics_b128 = *(int64*)(DAT_181d8b128 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        bool cVar5;
        int iVar6;
        long lVar7;
        long lVar8;
        float fVar11;
        float fVar12;
        float fVar13;
        ulong uVar14;
        uint uVar15;
        float local_c8;
        float fStack_c4;
        ulong local_b8;
        ulong local_a8;
        float local_a0;
        uint local_98;
        uint uStack_94;
        uint uStack_90;
        uint32 uStack_8c;
        uint64 local_88;
        uint64 local_78;
        uint64 uStack_70;
        uint64 local_68;
        local_78 = 0;
        uStack_70 = 0;
        local_68 = 0;
        lVar3 = this.<>4__this;
        if (this.<>1__state == 0) {
          this.<>1__state = 0xffffffff;
          if (lVar3 != null) {
            plVar1 = (int64 *)(lVar3 + 0x110);
            if ((*plVar1 != 0) && (lVar7 = Component.GetComponent(*plVar1,DAT_181d6acc0)) != null) {
              *(uint8 *)(lVar7 + 224) = 0;
              if ((*plVar1 != 0) &&
                 ((lVar7 = *(int64 *)(*plVar1 + 24), lVar7 != null &&
                  (lVar7 = SkeletonAnimation.get_AnimationState(lVar7,0)) != null))) {
                uVar14 = 0;
                AnimationState.AddEmptyAnimation(lVar7,1);
                uVar15 = (uint32)((uint64)uVar14 >> 32);
                if (*(char *)(lVar3 + 0x2b8) != false) {
                  if (*plVar1 == 0) goto LAB_180b1eeb0;
                  iVar6 = BattleUnit.GetSkillTargetType(*plVar1,0);
                  uVar15 = (uint32)((uint64)uVar14 >> 32);
                  if (iVar6 == 0) {
                    fVar11 = (float)Random.get_value(0);
                    if (((*plVar1 == 0) || (lVar7 = *(int64 *)(*plVar1 + 64)) == null) ||
                       (lVar7 = *(int64 *)(lVar7 + 0x2b8)) == null) goto LAB_180b1eeb0;
                    fVar12 = (float)HeroSpeAddData.Get(lVar7,79,0);
                    uVar15 = (uint32)((uint64)uVar14 >> 32);
                    if (fVar11 <= fVar12) {
                      lVar7 = *plVar1;
                      lVar8 = FUN_18046c100(0);
                      if ((lVar8 == null) || (lVar8 = *(int64 *)(lVar8 + 144)) == null)
                      goto LAB_180b1eeb0;
                      if (*(uint32 *)(lVar8 + 24) < 80) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar8 = *(int64 *)(*(int64 *)(lVar8 + 16) + 0x298);
                      if (lVar8 == null) goto LAB_180b1eeb0;
                      uVar14 = *(uint64 *)(lVar8 + 16);
                      puVar9 = (uint32 *)Color.get_green(&local_98,0);
                      if (lVar7 == null) goto LAB_180b1eeb0;
                      local_98 = *puVar9;
                      uStack_94 = puVar9[1];
                      uStack_90 = puVar9[2];
                      uStack_8c = puVar9[3];
                      BattleUnit.ShowTextOnHead
                                (lVar7,uVar14,&local_98,18,CONCAT44(uVar15,24),"UIAtlas",0,0,0);
                      if (*plVar1 == 0) goto LAB_180b1eeb0;
                      uVar14 = 0;
                      BattleUnit.ChangeBattleMove(*plVar1,0x41f00000,0,0,0);
                      if (*plVar1 == 0) goto LAB_180b1eeb0;
                      BattleUnit.ChangePower(*plVar1,0x41a00000,0,0);
                    }
                    fVar11 = (float)Random.get_value(0);
                    if ((((*plVar1 == 0) || (lVar7 = *(int64 *)(*plVar1 + 64)) == null) ||
                        (lVar7 = HeroData.GetNowActiveSkill(lVar7,0)) == null) ||
                       (*(int64 *)(lVar7 + 56) == 0)) goto LAB_180b1eeb0;
                    fVar12 = (float)HeroSpeAddData.Get(*(int64 *)(lVar7 + 56),95);
                    if (((*plVar1 == 0) || (lVar7 = *(int64 *)(*plVar1 + 64)) == null) ||
                       ((lVar7 = HeroData.GetNowActiveSkill(lVar7,0), lVar7 == null ||
                        (*(int64 *)(lVar7 + 80) == 0)))) goto LAB_180b1eeb0;
                    fVar13 = (float)HeroSpeAddData.Get(*(int64 *)(lVar7 + 80),95);
                    if (fVar11 <= fVar13 + fVar12) {
                      if (*plVar1 == 0) goto LAB_180b1eeb0;
                      BattleUnit.AddBuff(*plVar1,95);
                      if (*plVar1 == 0) goto LAB_180b1eeb0;
                      BattleUnit.CheckInvincibleEffect(*plVar1,0);
                    }
                    if (((*plVar1 == 0) || (lVar7 = *(int64 *)(*plVar1 + 64)) == null) ||
                       ((lVar7 = *(int64 *)(lVar7 + 0x2b8), lVar7 == null ||
                        ((lVar7 = *(int64 *)(lVar7 + 16), lVar7 == null ||
                         (lVar7 = Dictionary_2.get_Keys(lVar7,DAT_181d98b10)) == null)))))
                    goto LAB_180b1eeb0;
                    FUN_180ed4d30(&local_98,lVar7,DAT_181d9c570);
                    local_78 = CONCAT44(uStack_94,local_98);
                    uStack_70 = CONCAT44(uStack_8c,uStack_90);
                    local_68 = local_88;
        LAB_180b1e220:
                    cVar5 = FUN_1811d8280(&local_78,DAT_181d74c38);
                    uVar4 = local_68;
                    uVar15 = (uint32)((uint64)uVar14 >> 32);
                    if (cVar5) {
                      lVar7 = FUN_18046c100(0);
                      if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      if (*(int64 *)(lVar7 + 144) == 0) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      lVar7 = FUN_180002f80(*(int64 *)(lVar7 + 144),uVar4 & 0xffffffff);
                      if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      if (*(int *)(lVar7 + 60) != 0) {
                        lVar7 = FUN_18046c100(0);
                        if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                          FUN_1800d6620();
                        }
                        if (*(int64 *)(lVar7 + 144) == 0) {
                          // WARNING: Subroutine does not return
                          FUN_1800d6620();
                        }
                        lVar7 = FUN_180002f80(*(int64 *)(lVar7 + 144),uVar4 & 0xffffffff);
                        if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                          FUN_1800d6620();
                        }
                        if (*(char *)(lVar7 + 64) != false) {
                          if (*(int64 *)(lVar3 + 0x110) == 0) {
                          // WARNING: Subroutine does not return
                            FUN_1800d6620();
                          }
                          lVar7 = *(int64 *)(*(int64 *)(lVar3 + 0x110) + 64);
                          if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                            FUN_1800d6620();
                          }
                          lVar7 = *(int64 *)(lVar7 + 0x2b8);
                          if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                            FUN_1800d6620();
                          }
                          fVar11 = (float)HeroSpeAddData.Get(lVar7,uVar4 & 0xffffffff);
                          if (0.0 < fVar11) {
                            fVar11 = (float)Random.get_value(0);
                            if (*(int64 *)(lVar3 + 0x110) == 0) {
                          // WARNING: Subroutine does not return
                              FUN_1800d6620();
                            }
                            lVar7 = *(int64 *)(*(int64 *)(lVar3 + 0x110) + 64);
                            if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                              FUN_1800d6620();
                            }
                            lVar7 = *(int64 *)(lVar7 + 0x2b8);
                            if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                              FUN_1800d6620();
                            }
                            fVar12 = (float)HeroSpeAddData.Get(lVar7,uVar4 & 0xffffffff);
                            if (fVar11 <= fVar12) {
                              lVar7 = FUN_18046c100(0);
                              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              if (*(int64 *)(lVar7 + 144) == 0) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              lVar7 = FUN_180002f80(*(int64 *)(lVar7 + 144),uVar4 & 0xffffffff,
                                                    DAT_181d64878);
                              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              if (*(int *)(lVar7 + 84) != 1) {
                                lVar7 = FUN_18046c100(0);
                                if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                                  FUN_1800d6620();
                                }
                                if (*(int64 *)(lVar7 + 144) == 0) {
                          // WARNING: Subroutine does not return
                                  FUN_1800d6620();
                                }
                                lVar7 = FUN_180002f80(*(int64 *)(lVar7 + 144),uVar4 & 0xffffffff);
                                if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                                  FUN_1800d6620();
                                }
                                if (*(int *)(lVar7 + 84) != 2) goto LAB_180b1e220;
                                if (*(int64 *)(lVar3 + 0x110) == 0) {
                          // WARNING: Subroutine does not return
                                  FUN_1800d6620();
                                }
                                lVar7 = *(int64 *)(*(int64 *)(lVar3 + 0x110) + 64);
                                if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                                  FUN_1800d6620();
                                }
                                lVar7 = HeroData.GetNowActiveSkill(lVar7,0);
                                if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                                  FUN_1800d6620();
                                }
                                if (*(int64 *)(lVar7 + 56) == 0) {
                          // WARNING: Subroutine does not return
                                  FUN_1800d6620();
                                }
                                fVar11 = (float)HeroSpeAddData.Get(*(int64 *)(lVar7 + 56),
                                                                    uVar4 & 0xffffffff);
                                if (fVar11 <= 0.0) {
                                  if (*(int64 *)(lVar3 + 0x110) == 0) {
                          // WARNING: Subroutine does not return
                                    FUN_1800d6620();
                                  }
                                  lVar7 = *(int64 *)(*(int64 *)(lVar3 + 0x110) + 64);
                                  if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                                    FUN_1800d6620();
                                  }
                                  lVar7 = HeroData.GetNowActiveSkill(lVar7,0);
                                  if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                                    FUN_1800d6620();
                                  }
                                  if (*(int64 *)(lVar7 + 80) == 0) {
                          // WARNING: Subroutine does not return
                                    FUN_1800d6620();
                                  }
                                  fVar11 = (float)HeroSpeAddData.Get(*(int64 *)(lVar7 + 80),
                                                                      uVar4 & 0xffffffff);
                                  if (fVar11 <= 0.0) goto LAB_180b1e220;
                                }
                              }
                              lVar7 = FUN_18046c100(0);
                              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              if (*(int64 *)(lVar7 + 144) == 0) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              lVar7 = FUN_180002f80(*(int64 *)(lVar7 + 144),uVar4 & 0xffffffff);
                              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              if (*(int *)(lVar7 + 60) == -1) {
                                Debug.LogError("错误！自身buff无法根据内力差值调整时间",0);
                              }
                              else {
                                lVar7 = *(int64 *)(lVar3 + 0x110);
                                lVar8 = FUN_18046c100(0);
                                if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                                  FUN_1800d6620();
                                }
                                if (*(int64 *)(lVar8 + 144) == 0) {
                          // WARNING: Subroutine does not return
                                  FUN_1800d6620();
                                }
                                lVar8 = FUN_180002f80(*(int64 *)(lVar8 + 144),uVar4 & 0xffffffff);
                                if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                                  FUN_1800d6620();
                                }
                                if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                                  FUN_1800d6620();
                                }
                                BattleUnit.AddBuff(lVar7,uVar4 & 0xffffffff);
                              }
                            }
                          }
                        }
                      }
                      goto LAB_180b1e220;
                    }
                    ZhSegment.Initialize(&local_78,DAT_181d74bb8);
                    if ((*(int64 *)(lVar3 + 0x110) == 0) ||
                       (lVar7 = *(int64 *)(*(int64 *)(lVar3 + 0x110) + 64)) == null)
                    goto LAB_180b1eeb0;
                    HeroData.ChangeSkillPower(lVar7,0);
                  }
                }
                if (*(char *)(lVar3 + 0x2a0) != false) {
                  if (*plVar1 == 0) goto LAB_180b1eeb0;
                  cVar5 = BattleUnit.get_IsAlive(*plVar1,0);
                  if (cVar5) {
                    if ((((*plVar1 == 0) || (lVar7 = *(int64 *)(*plVar1 + 64)) == null) ||
                        (lVar7 = HeroData.GetNowActiveSkill(lVar7,0)) == null) ||
                       (lVar7 = KungfuSkillLvData.DataBase(lVar7,0)) == null) goto LAB_180b1eeb0;
                    cVar5 = BattleController.DamageRangeHaveTarget(lVar3,*(uint32 *)(lVar7 + 28),0)
                    ;
                    if (cVar5) {
                      lVar7 = *plVar1;
                      lVar8 = FUN_18046c100(0);
                      if ((lVar8 == null) || (lVar8 = *(int64 *)(lVar8 + 144)) == null)
                      goto LAB_180b1eeb0;
                      if (*(uint32 *)(lVar8 + 24) < 71) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar8 = *(int64 *)(*(int64 *)(lVar8 + 16) + 0x250);
                      if (lVar8 == null) goto LAB_180b1eeb0;
                      uVar14 = *(uint64 *)(lVar8 + 16);
                      puVar9 = (uint32 *)Color.get_green(&local_98,0);
                      if (lVar7 == null) goto LAB_180b1eeb0;
                      local_98 = *puVar9;
                      uStack_94 = puVar9[1];
                      uStack_90 = puVar9[2];
                      uStack_8c = puVar9[3];
                      BattleUnit.ShowTextOnHead
                                (lVar7,uVar14,&local_98,18,CONCAT44(uVar15,24),"UIAtlas",0,0,0);
                    }
                  }
                }
                BattleController.CheckAllDead(lVar3,0);
                if ((*pStatics_df90 != 0) &&
                   (lVar3 = *(int64 *)(*pStatics_df90 + 32)) != null) {
                  fVar11 = *(float *)(lVar3 + 0x1d8);
                  uVar14 = new WaitForSeconds(1.0 / fVar11,0);
                  this.<>2__current = uVar14;
                  this.<>1__state = 1;
                  return true;
                }
              }
            }
          }
          goto LAB_180b1eeb0;
        }
        if (this.<>1__state != 1) {
          return false;
        }
        this.<>1__state = 0xffffffff;
        if ((lVar3 == null) || (*(int64 *)(lVar3 + 0x110) == 0)) goto LAB_180b1eeb0;
        cVar5 = BattleUnit.get_IsAlive(*(int64 *)(lVar3 + 0x110),0);
        if (cVar5) {
          if ((((*(int64 *)(lVar3 + 0x110) == 0) ||
               (lVar7 = *(int64 *)(*(int64 *)(lVar3 + 0x110) + 64)) == null) ||
              (lVar7 = HeroData.GetNowActiveSkill(lVar7,0)) == null) ||
             (lVar7 = KungfuSkillLvData.DataBase(lVar7,0)) == null) goto LAB_180b1eeb0;
          if (*(char *)(lVar7 + 188) != false) {
            if (*(int64 *)(lVar3 + 0x110) == 0) goto LAB_180b1eeb0;
            uVar14 = Component.get_transform(*(int64 *)(lVar3 + 0x110),0);
            if (((*(int64 *)(lVar3 + 0x110) == 0) ||
                (lVar7 = *(int64 *)(*(int64 *)(lVar3 + 0x110) + 96)) == null) ||
               ((lVar7 = GridUnitData.get_GridObj(lVar7,0), lVar7 == null ||
                (lVar7 = GameObject.get_transform(lVar7,0)) == null))) goto LAB_180b1eeb0;
            puVar10 = (uint64 *)Transform.get_localPosition(&local_98,lVar7,0);
            uVar2 = *puVar10;
            fVar11 = *(float *)(puVar10 + 1);
            local_a8 = *(uint64 *)(pStatics_b128 + 28);
            local_a0 = *(float *)(pStatics_b128 + 36);
            local_c8 = (float)uVar2;
            fStack_c4 = (float)((uint64)uVar2 >> 32);
            local_b8 = CONCAT44(fStack_c4 + (float)((uint64)local_a8 >> 32),
                                local_c8 + (float)local_a8);
            fVar11 = fVar11 + local_a0;
            if ((*pStatics_df90 == 0) ||
               (*(int64 *)(*pStatics_df90 + 32) == 0)) goto LAB_180b1eeb0;
            local_a8 = local_b8;
            local_a0 = fVar11;
            uVar14 = ShortcutExtensions.DOLocalMove(uVar14,&local_a8);
            TweenSettingsExtensions.SetEase(uVar14,1,DAT_181d97ca8);
            lVar7 = *(int64 *)(lVar3 + 0x110);
            if ((lVar7 == null) || (*(int64 *)(lVar7 + 64) == 0)) goto LAB_180b1eeb0;
            if (*(char *)(*(int64 *)(lVar7 + 64) + 16) == false) {
              if ((*(int64 *)(lVar7 + 24) == 0) ||
                 (lVar7 = SkeletonAnimation.get_AnimationState(*(int64 *)(lVar7 + 24),0), lVar7 == null
                 )) goto LAB_180b1eeb0;
              lVar7 = AnimationState.SetAnimation(lVar7,1,"jump_small",0,0);
              if (((*(int64 *)(lVar3 + 0x110) == 0) ||
                  (((lVar8 = *(int64 *)(*(int64 *)(lVar3 + 0x110) + 24), lVar8 == null ||
                    (lVar8 = *(int64 *)(lVar8 + 24)) == null) ||
                   (lVar8 = SkeletonDataAsset.GetSkeletonData(lVar8,1,0)) == null))) ||
                 (lVar8 = SkeletonData.FindAnimation(lVar8,"jump_small",0)) == null)
              goto LAB_180b1eeb0;
              fVar11 = *(float *)(lVar8 + 40);
              fVar12 = *(float *)(*(int64 *)(DAT_181d8b6a8 + 184) + 24);
              if (((*pStatics_df90 == 0) ||
                  (lVar8 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
                 (lVar7 == null)) goto LAB_180b1eeb0;
              *(float *)(lVar7 + 160) = fVar11 / (fVar12 / *(float *)(lVar8 + 0x1d8));
              lVar7 = *(int64 *)(lVar3 + 0x110);
            }
            if (((lVar7 == null) || (*(int64 *)(lVar7 + 24) == 0)) ||
               (lVar7 = SkeletonAnimation.get_AnimationState(*(int64 *)(lVar7 + 24),0)) == null)
            goto LAB_180b1eeb0;
            AnimationState.AddEmptyAnimation(lVar7,1);
            if (*(int64 *)(lVar3 + 0x110) == 0) goto LAB_180b1eeb0;
            uVar14 = Component.get_transform(*(int64 *)(lVar3 + 0x110),0);
            if ((*pStatics_df90 == 0) ||
               (*(int64 *)(*pStatics_df90 + 32) == 0)) goto LAB_180b1eeb0;
            ShortcutExtensions.DOScale(uVar14,0x3f800000);
          }
        }
        if (*(char *)(lVar3 + 0x2a0) != false) {
          if (*(int64 *)(lVar3 + 0x110) == 0) {
        LAB_180b1eeb0:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          cVar5 = BattleUnit.get_IsAlive(*(int64 *)(lVar3 + 0x110),0);
          if (cVar5) {
            if ((((*(int64 *)(lVar3 + 0x110) == 0) ||
                 (lVar7 = *(int64 *)(*(int64 *)(lVar3 + 0x110) + 64)) == null) ||
                (lVar7 = HeroData.GetNowActiveSkill(lVar7,0)) == null) ||
               (lVar7 = KungfuSkillLvData.DataBase(lVar7,0)) == null) goto LAB_180b1eeb0;
            cVar5 = BattleController.DamageRangeHaveTarget(lVar3,*(uint32 *)(lVar7 + 28),0);
            if (cVar5) {
              uVar14 = BattleController.BattleUnitAttackStart(lVar3,0);
              goto LAB_180b1ee79;
            }
          }
        }
        uVar14 = BattleController.BattleUnitAttackEnd(lVar3,0,0);
        LAB_180b1ee79:
        FUN_180d837c0(lVar3,uVar14,0);
        return false;
    }

    // Token : 0x6000BDC
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000BDD
    // RVA   : 0xB1EF70   Offset: 0xB1D770   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d6e718);
    }

    // Token : 0x6000BDE
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
