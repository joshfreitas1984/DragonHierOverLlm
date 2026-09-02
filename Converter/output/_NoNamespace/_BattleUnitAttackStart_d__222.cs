// ============================================================
// Type  : <BattleUnitAttackStart>d__222
// Token : 0x2000167
// ============================================================

public class <BattleUnitAttackStart>d__222
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000950
    private int <>1__state;

    // Token: 0x4000951
    private object <>2__current;

    // Token: 0x4000952
    public BattleController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000BBC
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000BBD
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000BBE
    // RVA   : 0xB222A0   Offset: 0xB20AA0   Length: 0xCEC
    private virtual bool MoveNext()
    {
        int iVar1;
        int iVar2;
        ulong uVar3;
        uint uVar4;
        long lVar5;
        long lVar6;
        long lVar7;
        ulong uVar8;
        long lVar10;
        float fVar12;
        float fVar13;
        uint uVar14;
        int[] local_res8 = new int[2];
        ulong uVar15;
        ulong in_stack_ffffffffffffff80;
        ulong local_68;
        ulong uStack_60;
        uVar14 = (uint32)((uint64)in_stack_ffffffffffffff80 >> 32);
        plVar11 = (int64 *)0;
        lVar10 = this.<>4__this;
        local_res8[0] = 0;
        if (this.<>1__state != 0) {
          if (this.<>1__state == 1) {
            this.<>1__state = 0xffffffff;
          }
          return false;
        }
        this.<>1__state = 0xffffffff;
        if ((lVar10 != null) && (lVar5 = *(int64 *)(lVar10 + 0x110)) != null) {
          lVar6 = *(int64 *)(lVar5 + 64);
          uVar8 = *(uint64 *)(lVar5 + 24);
          if ((lVar6 != null) &&
             ((lVar5 = HeroData.GetNowActiveSkill(lVar6,0), lVar5 != null &&
              (lVar5 = KungfuSkillLvData.DataBase(lVar5,0)) != null))) {
            HeroData.SetSkillWeapon(lVar6,uVar8,*(uint64 *)(lVar5 + 152),0);
            if ((*(int64 *)(lVar10 + 0x110) != 0) &&
               (lVar5 = *(int64 *)(*(int64 *)(lVar10 + 0x110) + 24)) != null) {
              lVar5 = SkeletonAnimation.get_AnimationState(lVar5,0);
              if ((*(int64 *)(lVar10 + 0x110) != 0) &&
                 (lVar6 = *(int64 *)(*(int64 *)(lVar10 + 0x110) + 64)) != null) {
                uVar8 = "attack";
                if (*(char *)(lVar6 + 16) == false) {
                  lVar6 = HeroData.GetNowActiveSkill(lVar6,0);
                  if ((lVar6 == null) || (lVar6 = KungfuSkillLvData.DataBase(lVar6,0)) == null)
                  throw; // [null/range check failed]
                  uVar8 = *(uint64 *)(lVar6 + 160);
                }
                if (lVar5 != null) {
                  AnimationState.SetAnimation(lVar5,1,uVar8,0,0);
                  lVar5 = *(int64 *)(lVar10 + 0x110);
                  if (((lVar5 != null) && (*(int64 *)(lVar5 + 64) != 0)) &&
                     (lVar6 = HeroData.GetNowActiveSkill(*(int64 *)(lVar5 + 64),0)) != null) {
                    KungfuSkillLvData.GetManaCost(lVar6,0);
                    BattleUnit.ChangeMana(lVar5);
                    fVar12 = (float)Random.get_value(0);
                    if (((*(int64 *)(lVar10 + 0x110) != 0) &&
                        (lVar5 = *(int64 *)(*(int64 *)(lVar10 + 0x110) + 64)) != null) &&
                       ((lVar5 = HeroData.GetNowActiveSkill(lVar5,0), lVar5 != null &&
                        (lVar5 = KungfuSkillLvData.DataBase(lVar5,0)) != null))) {
                      if (fVar12 <= (float)*(int *)(lVar5 + 52) * 0.05) {
                        lVar5 = *(int64 *)(lVar10 + 0x110);
                        lVar6 = *(int64 *)(*(int64 *)(DAT_181d8b6a8 + 184) + 80);
                        if (lVar6 == null) throw; // [null/range check failed]
                        uVar4 = FUN_180d8cf10(0,*(uint32 *)(lVar6 + 24),0);
                        if (*(uint32 *)(lVar6 + 24) <= uVar4) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar6 = *(int64 *)
                                 (*(int64 *)(lVar6 + 16) + 32 + (int64)(int)uVar4 * 8);
                        if ((*(int64 *)(lVar10 + 0x110) == 0) ||
                           (lVar7 = *(int64 *)(*(int64 *)(lVar10 + 0x110) + 64)) == null)
                        throw; // [null/range check failed]
                        lVar7 = HeroData.GetNowActiveSkill(lVar7,0);
                        if ((lVar7 == null) ||
                           ((uVar8 = KungfuSkillLvData.Name(lVar7,1,0), lVar6 == null ||
                            (uVar8 = String.Replace(lVar6,"#SkillName#",uVar8,0), lVar5 == null))))
                        throw; // [null/range check failed]
                        BattleUnit.Talk(lVar5,uVar8);
                      }
                      if (*(int64 *)(lVar10 + 0x110) != 0) {
                        uVar8 = CONCAT44(uVar14,1);
                        BattleController.ManageSkillSpeEffect
                                  (lVar10,0,1,*(uint64 *)(*(int64 *)(lVar10 + 0x110) + 96),1,
                                   uVar8,0);
                        lVar5 = 32;
                        plVar9 = plVar11;
                        while( true ) {
                          uVar14 = (uint32)((uint64)uVar8 >> 32);
                          lVar6 = *(int64 *)(lVar10 + 0x208);
                          if (lVar6 == null) break;
                          uVar4 = (uint32)plVar9;
                          if ((int)*(uint32 *)(lVar6 + 24) <= (int)uVar4) {
                            if ((((*(int64 *)(lVar10 + 0x110) == 0) ||
                                 (lVar5 = *(int64 *)(*(int64 *)(lVar10 + 0x110) + 64)) == null
                                 ) || (lVar5 = HeroData.GetNowActiveSkill(lVar5,0)) == null) ||
                               (lVar5 = KungfuSkillLvData.DataBase(lVar5,0)) == null) break;
                            lVar6 = *(int64 *)(lVar10 + 0x110);
                            if (*(int *)(lVar5 + 48) < 3) {
                              if (((lVar6 == null) || (*(int64 *)(lVar6 + 24) == 0)) ||
                                 (lVar5 = SkeletonAnimation.get_AnimationState
                                                    (*(int64 *)(lVar6 + 24),0), lVar5 == null)) break;
                              uVar15 = 0;
                              AnimationState.AddEmptyAnimation(lVar5,1);
                              *(uint8 *)(lVar10 + 0x2b9) = 0;
                              *(uint8 *)(lVar10 + 0x2a0) = 0;
                              if (((*(int64 *)(lVar10 + 0x110) == 0) ||
                                  (lVar5 = *(int64 *)(*(int64 *)(lVar10 + 0x110) + 64), lVar5 == null
                                  )) || (lVar5 = HeroData.GetNowActiveSkill(lVar5,0)) == null) break;
                              *(uint32 *)(lVar5 + 100) = 0;
                              if ((*(int64 *)(lVar10 + 0x110) == 0) ||
                                 (lVar5 = *(int64 *)(*(int64 *)(lVar10 + 0x110) + 64)) == null
                                 ) break;
                              lVar5 = HeroData.GetNowActiveSkill(lVar5,0);
                              if ((*(int64 *)(lVar10 + 0x110) == 0) ||
                                 (((lVar6 = *(int64 *)(*(int64 *)(lVar10 + 0x110) + 64),
                                   lVar6 == null ||
                                   (lVar6 = HeroData.GetNowActiveSkill(lVar6,0)) == null) ||
                                  (uVar14 = KungfuSkillLvData.GetActiveTime(lVar6,0), lVar5 == null))))
                              break;
                              *(uint32 *)(lVar5 + 96) = uVar14;
                              if ((((*(int64 *)(lVar10 + 0x110) == 0) ||
                                   (lVar5 = *(int64 *)(*(int64 *)(lVar10 + 0x110) + 64),
                                   lVar5 == null)) ||
                                  (lVar5 = HeroData.GetNowActiveSkill(lVar5,0)) == null) ||
                                 (lVar5 = KungfuSkillLvData.DataBase(lVar5,0)) == null) break;
                              lVar6 = *(int64 *)(lVar10 + 0x110);
                              if (*(int *)(lVar5 + 48) == 0) {
                                if ((lVar6 == null) || (lVar5 = *(int64 *)(lVar6 + 64)) == null)
                                break;
                                fVar12 = *(float *)(lVar5 + 0x198);
                                fVar13 = *(float *)(lVar5 + 400);
                                lVar5 = HeroData.GetNowActiveSkill(lVar5,0);
                                if ((lVar5 == null) ||
                                   (lVar5 = KungfuSkillLvData.DataBase(lVar5,0)) == null) break;
                                BattleUnit.ChangeMana
                                          (lVar6,(0.2 - (float)*(int *)(lVar5 + 52) * 0.02) *
                                                 (fVar12 - fVar13),1,1,0);
                              }
                              else {
                                if ((((lVar6 == null) || (*(int64 *)(lVar6 + 64) == 0)) ||
                                    (lVar5 = HeroData.GetNowActiveSkill(*(int64 *)(lVar6 + 64),0),
                                    lVar5 == null)) ||
                                   (lVar5 = KungfuSkillLvData.DataBase(lVar5,0)) == null) break;
                                lVar6 = *(int64 *)(lVar10 + 0x110);
                                if (*(int *)(lVar5 + 48) == 1) {
                                  if ((lVar6 == null) || (lVar5 = *(int64 *)(lVar6 + 64)) == null)
                                  break;
                                  fVar12 = *(float *)(lVar5 + 0x18c);
                                  fVar13 = *(float *)(lVar5 + 0x184);
                                  lVar5 = HeroData.GetNowActiveSkill(lVar5,0);
                                  if ((lVar5 == null) ||
                                     (lVar5 = KungfuSkillLvData.DataBase(lVar5,0)) == null) break;
                                  BattleUnit.ChangePower
                                            (lVar6,(0.3 - (float)*(int *)(lVar5 + 52) * 0.03) *
                                                   (fVar12 - fVar13),1,0);
                                }
                                else {
                                  if (((lVar6 == null) || (*(int64 *)(lVar6 + 64) == 0)) ||
                                     ((lVar5 = HeroData.GetNowActiveSkill(*(int64 *)(lVar6 + 64),0),
                                      lVar5 == null ||
                                      (lVar5 = KungfuSkillLvData.DataBase(lVar5,0)) == null))) break;
                                  if (*(int *)(lVar5 + 48) == 2) {
                                    lVar5 = *(int64 *)(lVar10 + 0x110);
                                    if ((lVar5 == null) || (lVar6 = *(int64 *)(lVar5 + 64)) == null)
                                    break;
                                    fVar12 = *(float *)(lVar6 + 0x180);
                                    fVar13 = *(float *)(lVar6 + 0x178);
                                    lVar6 = HeroData.GetNowActiveSkill(lVar6,0);
                                    if ((lVar6 == null) ||
                                       (lVar6 = KungfuSkillLvData.DataBase(lVar6,0)) == null) break;
                                    BattleUnit.ChangeHp
                                              (lVar5,(0.1 - (float)*(int *)(lVar6 + 52) * 0.01) *
                                                     (fVar12 - fVar13),0,1,uVar15 & 0xffffffffffffff00,0);
                                  }
                                }
                              }
                              if ((((*(int64 *)(lVar10 + 0x110) == 0) ||
                                   (lVar5 = *(int64 *)(*(int64 *)(lVar10 + 0x110) + 64),
                                   lVar5 == null)) ||
                                  (lVar5 = HeroData.GetNowActiveSkill(lVar5,0)) == null) ||
                                 (lVar5 = KungfuSkillLvData.DataBase(lVar5,0)) == null) break;
                              if (*(int *)(lVar5 + 28) == 5) {
                                lVar5 = *(int64 *)(lVar10 + 0x208);
                                uVar8 = *(uint64 *)(lVar10 + 0x110);
                                if (lVar5 == null) break;
                                if (*(int *)(lVar5 + 24) == 0) {
                                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                }
                                uVar3 = *(uint64 *)(*(int64 *)(lVar5 + 16) + 32);
                                fVar12 = (float)BattleController.GetHalfBattleTimeScale(lVar10,0);
                                uVar8 = BattleController.HeroEnterGridDelay
                                                  (lVar10,uVar8,uVar3,0.6 / fVar12,0);
                                FUN_180d837c0(lVar10,uVar8,0);
                              }
                              uVar8 = BattleController.BattleUnitAttackEnd(lVar10);
                              FUN_180d837c0(lVar10,uVar8,0);
                            }
                            else {
                              if (lVar6 == null) break;
                              BattleUnit.ChangePower();
                              lVar5 = *(int64 *)(lVar10 + 0x110);
                              if (((lVar5 == null) || (*(int64 *)(lVar5 + 64) == 0)) ||
                                 (lVar6 = HeroData.GetNowActiveSkill(*(int64 *)(lVar5 + 64),0),
                                 lVar6 == null)) break;
                              lVar6 = KungfuSkillLvData.DataBase(lVar6,0);
                              if (lVar6 == null) break;
                              BattleUnit.SetWeaponTrail(lVar5,1,*(uint32 *)(lVar6 + 192),0);
                              lVar5 = *(int64 *)(lVar10 + 0x110);
                              if (((lVar5 == null) || (*(int64 *)(lVar5 + 64) == 0)) ||
                                 ((lVar6 = HeroData.GetNowActiveSkill(*(int64 *)(lVar5 + 64),0),
                                  lVar6 == null || (lVar6 = KungfuSkillLvData.DataBase(lVar6,0)) == null
                                  ))) break;
                              iVar1 = *(int *)(lVar6 + 52);
                              if ((((*(int64 *)(lVar10 + 0x110) == 0) ||
                                   (lVar6 = *(int64 *)(*(int64 *)(lVar10 + 0x110) + 64),
                                   lVar6 == null)) ||
                                  (lVar6 = HeroData.GetNowActiveSkill(lVar6,0)) == null) ||
                                 (lVar6 = KungfuSkillLvData.DataBase(lVar6,0)) == null) break;
                              iVar2 = *(int *)(lVar6 + 52);
                              lVar6 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
                              if (lVar6 == null) break;
                              lVar6 = *(int64 *)(lVar6 + 56);
                              if ((((*(int64 *)(lVar10 + 0x110) == 0) ||
                                   (lVar7 = *(int64 *)(*(int64 *)(lVar10 + 0x110) + 64),
                                   lVar7 == null)) ||
                                  (lVar7 = HeroData.GetNowActiveSkill(lVar7,0)) == null) ||
                                 ((lVar7 = KungfuSkillLvData.DataBase(lVar7,0), lVar7 == null ||
                                  (lVar6 == null)))) break;
                              uVar4 = *(uint32 *)(lVar7 + 52);
                              if (*(uint32 *)(lVar6 + 24) <= uVar4) {
                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                              }
                              lVar6 = *(int64 *)
                                       (*(int64 *)(lVar6 + 16) + 32 + (int64)(int)uVar4 * 8);
                              if (lVar6 == null) break;
                              local_68 = *(uint64 *)(lVar6 + 24);
                              uStack_60 = *(uint64 *)(lVar6 + 32);
                              BattleUnit.ShowWeaponLight
                                        (lVar5,(float)iVar1 * 0.1 + 0.5,(float)iVar2 * 0.1 + 0.5,&local_68
                                         ,0);
                              *(uint8 *)(lVar10 + 0x2b9) = 1;
                              fVar12 = (float)Random.get_value(0);
                              fVar13 = (float)BattleController.GetNowActiveUnitComboRate(lVar10,0);
                              if (fVar12 <= fVar13) {
                                *(int *)(lVar10 + 0x2a4) = *(int *)(lVar10 + 0x2a4) + 1;
                              }
                              else {
                                *(uint8 *)(lVar10 + 0x2a0) = 0;
                              }
                            }
                            if (((*(int64 *)(lVar10 + 0x110) != 0) &&
                                (lVar5 = *(int64 *)(*(int64 *)(lVar10 + 0x110) + 64)) != null)
                               && ((lVar5 = HeroData.GetNowActiveSkill(lVar5,0), lVar5 != null &&
                                   (lVar5 = KungfuSkillLvData.DataBase(lVar5,0)) != null))) {
                              local_res8[0] = (int)((float)*(int *)(lVar5 + 52) / 3.0);
                              uVar8 = Int32.ToString(local_res8,0);
                              uVar8 = String.Concat("Sound/SoundEffect/BigSkill",uVar8,0);
                              plVar9 = (int64 *)Resources.Load(uVar8,0);
                              if ((((*(int64 *)(lVar10 + 0x110) != 0) &&
                                   (lVar10 = *(int64 *)(*(int64 *)(lVar10 + 0x110) + 64),
                                   lVar10 != null)) &&
                                  (lVar10 = HeroData.GetNowActiveSkill(lVar10,0)) != null) &&
                                 (lVar10 = KungfuSkillLvData.DataBase(lVar10,0)) != null) {
                                iVar1 = *(int *)(lVar10 + 52);
                                if ((plVar9 != (int64 *)0) && (*plVar9 == DAT_181d8a228)) {
                                  plVar11 = plVar9;
                                }
                                NGUITools.PlaySound
                                          (plVar11,(float)(iVar1 + (iVar1 / 3 + (iVar1 >> 31) +
                                                                   (int)(((int64)iVar1 / 3 +
                                                                          ((int64)iVar1 >> 63) &
                                                                         0xffffffffU) >> 31)) * -3) *
                                                   0.1 + 0.2,0);
                                this.<>2__current = 0;
                                this.<>1__state = 1;
                                return true;
                              }
                            }
                            break;
                          }
                          lVar7 = lVar6;
                          if (*(uint32 *)(lVar6 + 24) <= uVar4) {
                            ThrowHelper.ThrowArgumentOutOfRangeException(0);
                            lVar7 = *(int64 *)(lVar10 + 0x208);
                          }
                          if (lVar7 == null) break;
                          uVar8 = CONCAT44(uVar14,*(uint32 *)(lVar7 + 24));
                          BattleController.ManageSkillSpeEffect
                                    (lVar10,0,0,*(uint64 *)(*(int64 *)(lVar6 + 16) + lVar5),1,
                                     uVar8,0);
                          plVar9 = (int64 *)(uint64)(uVar4 + 1);
                          lVar5 = lVar5 + 8;
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000BBF
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000BC0
    // RVA   : 0xB22F90   Offset: 0xB21790   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d6e898);
    }

    // Token : 0x6000BC1
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
