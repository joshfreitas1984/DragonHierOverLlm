// ============================================================
// Type  : <BattleUnitAttackHit>d__233
// Token : 0x200016C
// ============================================================

public class <BattleUnitAttackHit>d__233
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000962
    private int <>1__state;

    // Token: 0x4000963
    private object <>2__current;

    // Token: 0x4000964
    public float startDelay;

    // Token: 0x4000965
    public BattleController <>4__this;

    // Token: 0x4000966
    public GridUnitData targetGridUnit;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000BD3
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000BD4
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000BD5
    // RVA   : 0xB20900   Offset: 0xB1F100   Length: 0x1959
    private virtual bool MoveNext()
    {
        var pStatics_b128 = *(int64*)(DAT_181d8b128 + 184);
        var pStatics_c9b8 = *(int64*)(DAT_181d7c9b8 + 184);
        long lVar1;
        bool cVar3;
        int iVar4;
        int iVar5;
        uint uVar6;
        int iVar7;
        uint uVar8;
        ulong uVar9;
        long lVar10;
        long lVar11;
        ulong uVar12;
        ulong uVar15;
        long lVar17;
        long lVar18;
        float fVar19;
        float fVar20;
        float[] local_res18 = new float[2];
        int local_res20;
        ulong in_stack_ffffffffffffff38;
        ulong in_stack_ffffffffffffff40;
        ulong uVar21;
        ulong local_98;
        ulong local_88;
        float local_80;
        ulong local_78;
        float local_70;
        ulong local_68;
        float fStack_60;
        uint32 uStack_5c;
        uVar6 = (uint32)((uint64)in_stack_ffffffffffffff40 >> 32);
        lVar1 = this.<>4__this;
        local_res18[0] = 0.0;
        if (this.<>1__state == 0) {
          this.<>1__state = 0xffffffff;
          uVar9 = new WaitForSeconds();
          this.<>2__current = uVar9;
          this.<>1__state = 1;
          return true;
        }
        if (this.<>1__state != 1) {
          return false;
        }
        this.<>1__state = 0xffffffff;
        bVar2 = false;
        local_res8 = false;
        lVar10 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 8);
        if ((lVar10 == null) || (lVar10 = *(int64 *)(lVar10 + 16)) == null) throw; // [null/range check failed]
        iVar4 = PlayerPrefDictionary.GetInt(lVar10,"FightScreenShake",0);
        if (iVar4 == 1) {
          if (*pStatics_c9b8 == 0) throw; // [null/range check failed]
          ShakeCam.StartShake(*pStatics_c9b8,2,0);
        }
        if (((lVar1 == null) || (this.targetGridUnit == null)) || (*(int64 *)(lVar1 + 0x2a8) == 0))
        throw; // [null/range check failed]
        cVar3 = FUN_1818279a0(*(int64 *)(lVar1 + 0x2a8),
                              this.targetGridUnit.battleUnit,DAT_181d582a8);
        iVar4 = 0;
        if (!cVar3) {
          if (*(int64 *)(lVar1 + 0x110) == 0) throw; // [null/range check failed]
          iVar5 = BattleUnit.GetSkillTargetType(*(int64 *)(lVar1 + 0x110),0);
          if (iVar5 == 0) {
            cVar3 = BattleController.HaveAvailableEnemyUnit(lVar1,this.targetGridUnit,0);
            if (cVar3) {
              if ((this.targetGridUnit == null) || (*(int64 *)(lVar1 + 0x2a8) == 0))
              throw; // [null/range check failed]
              FUN_181827900(*(int64 *)(lVar1 + 0x2a8),
                            this.targetGridUnit.battleUnit,DAT_181d581a8);
              if ((this.targetGridUnit == null) ||
                 ((lVar10 = this.targetGridUnit.battleUnit, lVar10 == null ||
                  (lVar10 = *(int64 *)(lVar10 + 64)) == null))) throw; // [null/range check failed]
              if (*(char *)(lVar10 + 16) == false) {
                fVar19 = (float)Random.get_value(0);
                if ((((this.targetGridUnit == null) ||
                     (lVar10 = this.targetGridUnit.battleUnit) == null) ||
                    (lVar10 = *(int64 *)(lVar10 + 64)) == null) ||
                   (lVar10 = *(int64 *)(lVar10 + 0x2b8)) == null) throw; // [null/range check failed]
                fVar20 = (float)HeroSpeAddData.Get(lVar10,171,0);
                if (fVar19 <= fVar20) {
                  lVar10 = *(int64 *)(lVar1 + 0x110);
                  if ((lVar10 == null) || (*(int64 *)(lVar10 + 64) == 0)) throw; // [null/range check failed]
                  uVar9 = HeroData.GetNowActiveSkill(*(int64 *)(lVar10 + 64),0);
                  if (this.targetGridUnit == null) throw; // [null/range check failed]
                  uVar12 = 0;
                  in_stack_ffffffffffffff38 = in_stack_ffffffffffffff38 & 0xffffffffffffff00;
                  local_res18[0] =
                       (float)BattleController.CountBaseDamage
                                        (lVar1,lVar10,uVar9,
                                         this.targetGridUnit.battleUnit,
                                         in_stack_ffffffffffffff38,0);
                  uVar6 = (uint32)((uint64)uVar12 >> 32);
                  if (((this.targetGridUnit == null) ||
                      (lVar10 = this.targetGridUnit.battleUnit) == null) ||
                     (lVar10 = *(int64 *)(lVar10 + 64)) == null) throw; // [null/range check failed]
                  if (local_res18[0] <= *(float *)(lVar10 + 400)) {
                    local_res20 = 3;
                    lVar10 = il2cpp_internal(DAT_181d6c930);
                    FUN_180f58a90(lVar10,DAT_181d58128);
                    while( true ) {
                      uVar6 = (uint32)((uint64)uVar12 >> 32);
                      uVar8 = (uint32)(in_stack_ffffffffffffff38 >> 32);
                      plVar16 = (int64 *)0;
                      if (*(int64 *)(lVar1 + 112) == 0) break;
                      if (*(int *)(*(int64 *)(lVar1 + 112) + 24) <= iVar4) {
                        if (lVar10 != null) {
                          if (*(int *)(lVar10 + 24) < 1) goto LAB_180b22008;
                          plVar14 = (int64 *)Resources.Load("Sound/SoundEffect/HitMetal",0);
                          if ((plVar14 != (int64 *)0) && (*plVar14 == DAT_181d8a228)) {
                            plVar16 = plVar14;
                          }
                          NGUITools.PlaySound(plVar16);
                          if (this.targetGridUnit != null) {
                            lVar11 = this.targetGridUnit.battleUnit;
                            puVar13 = (uint64 *)Color.get_magenta(&local_68,0);
                            if (lVar11 != null) {
                              local_68 = *puVar13;
                              fStack_60 = *(float *)(puVar13 + 1);
                              uStack_5c = *(uint32 *)((int64)puVar13 + 12);
                              uVar9 = "UIAtlas";
                              BattleUnit.ShowTextOnHead
                                        (lVar11,"斗转",&local_68,18,CONCAT44(uVar8,24),
                                         "UIAtlas",0,0,0);
                              uVar6 = (uint32)((uint64)uVar9 >> 32);
                              if ((this.targetGridUnit != null) &&
                                 (this.targetGridUnit.battleUnit != null)) {
                                BattleUnit.ChangeMana();
                                uVar8 = FUN_180d8cf10(0,*(uint32 *)(lVar10 + 24),0);
                                lVar10 = FUN_180002f80(lVar10,uVar8,DAT_181d584a0);
                                if (lVar10 != null) {
                                  lVar10 = *(int64 *)(lVar10 + 96);
                                  if ((((this.targetGridUnit != null) &&
                                       (lVar11 = this.targetGridUnit.battleUnit,
                                       lVar11 != null)) &&
                                      (lVar11 = *(int64 *)(lVar11 + 64)) != null) &&
                                     (((uVar9 = HeroData.Name(lVar11,1,0), lVar10 != null &&
                                       (*(int64 *)(lVar10 + 24) != 0)) &&
                                      (lVar11 = *(int64 *)(*(int64 *)(lVar10 + 24) + 64),
                                      lVar11 != null)))) {
                                    uVar12 = HeroData.Name(lVar11,1,0);
                                    uVar15 = Single.ToString(local_res18,"f0",0);
                                    uVar9 = String.Format("{0}将伤害斗转给{1}(耗内{2})。",uVar9,uVar12,uVar15,0);
                                    BattleController.AddInfoText(lVar1,uVar9,1,0);
                                    if (*(int64 *)(lVar1 + 200) != 0) {
                                      uVar9 = Component.get_gameObject(*(int64 *)(lVar1 + 200),0);
                                      plVar16 = (int64 *)Resources.Load("SpeEffect/斗转",0);
                                      plVar14 = (int64 *)0;
                                      if ((plVar16 != (int64 *)0) && (*plVar16 == DAT_181d4e110)) {
                                        plVar14 = plVar16;
                                      }
                                      lVar11 = GlobalData.AddChild(uVar9,plVar14,0);
                                      if (lVar11 != null) {
                                        lVar17 = GameObject.get_transform(lVar11,0);
                                        if ((((this.targetGridUnit != null) &&
                                             (lVar18 = this.targetGridUnit.battleUnit
                                             , lVar18 != null)) &&
                                            (lVar18 = *(int64 *)(lVar18 + 32)) != null) &&
                                           (lVar18 = GameObject.get_transform(lVar18,0)) != null) {
                                          puVar13 = (uint64 *)
                                                    Transform.get_position(&local_68,lVar18,0);
                                          local_88 = *puVar13;
                                          local_80 = *(float *)(puVar13 + 1);
                                          puVar13 = (uint64 *)
                                                    GlobalData.SetZToZero(&local_68,&local_88,0);
                                          uVar9 = *puVar13;
                                          fVar19 = *(float *)(puVar13 + 1);
                                          local_98._0_4_ = (float)uVar9;
                                          local_98._4_4_ = (float)((uint64)uVar9 >> 32);
                                          local_68 = *(uint64 *)
                                                      (pStatics_b128 + 16);
                                          fStack_60 = *(float *)(pStatics_b128 +
                                                                24);
                                          local_80 = fVar19 + fStack_60;
                                          local_88 = CONCAT44(local_98._4_4_ +
                                                              (float)((uint64)local_68 >> 32),
                                                              (float)local_98 + (float)local_68);
                                          local_78 = local_68;
                                          local_70 = fStack_60;
                                          if (lVar17 != null) {
                                            local_78 = local_88;
                                            local_70 = local_80;
                                            Transform.set_position(lVar17,&local_78,0);
                                            lVar17 = GameObject.GetComponent(lVar11,DAT_181da0648);
                                            if ((*(int64 *)(lVar10 + 24) != 0) && (lVar17 != null)) {
                                              *(uint64 *)(lVar17 + 24) =
                                                   *(uint64 *)(*(int64 *)(lVar10 + 24) + 32);
                                              il2cpp_internal();
                                              lVar11 = GameObject.GetComponent(lVar11,DAT_181da0648);
                                              if (lVar11 != null) {
                                                *(uint32 *)(lVar11 + 32) = 0x3e99999a;
                                                this.targetGridUnit = lVar10;
                                                goto LAB_180b22008;
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
                          }
                        }
                        break;
                      }
                      while( true ) {
                        if (((*(int64 *)(lVar1 + 112) == 0) ||
                            (lVar11 = FUN_180002f80(*(int64 *)(lVar1 + 112),iVar4)) == null) ||
                           (*(int64 *)(lVar11 + 24) == 0)) throw; // [null/range check failed]
                        if (*(int *)(*(int64 *)(lVar11 + 24) + 24) <= (int)plVar16) break;
                        if (((*(int64 *)(lVar1 + 112) == 0) ||
                            (lVar11 = FUN_180002f80(*(int64 *)(lVar1 + 112),iVar4,DAT_181d580a8),
                            lVar11 == null)) || (*(int64 *)(lVar11 + 24) == 0)) throw; // [null/range check failed]
                        uVar9 = FUN_180002f80(*(int64 *)(lVar11 + 24),plVar16,DAT_181d584a0);
                        if (this.targetGridUnit == null) throw; // [null/range check failed]
                        uVar15 = this.targetGridUnit.battleUnit;
                        cVar3 = Object.op_Inequality(uVar9,uVar15,0);
                        if (cVar3) {
                          if ((((*(int64 *)(lVar1 + 112) == 0) ||
                               (lVar11 = FUN_180002f80(*(int64 *)(lVar1 + 112),iVar4,DAT_181d580a8),
                               lVar11 == null)) || (*(int64 *)(lVar11 + 24) == 0)) ||
                             (lVar11 = FUN_180002f80(*(int64 *)(lVar11 + 24),plVar16,DAT_181d584a0),
                             lVar11 == null)) throw; // [null/range check failed]
                          if (*(int64 *)(lVar11 + 96) != 0) {
                            if (((*(int64 *)(lVar1 + 112) == 0) ||
                                (lVar11 = FUN_180002f80(*(int64 *)(lVar1 + 112),iVar4,DAT_181d580a8),
                                lVar11 == null)) ||
                               ((((*(int64 *)(lVar11 + 24) == 0 ||
                                  ((lVar11 = FUN_180002f80(*(int64 *)(lVar11 + 24),plVar16,
                                                           DAT_181d584a0), lVar11 == null ||
                                   (this.targetGridUnit == null)))) ||
                                 (lVar17 = this.targetGridUnit.battleUnit,
                                 lVar17 == null)) || (*(int64 *)(lVar11 + 96) == 0))))
                            throw; // [null/range check failed]
                            iVar7 = GridUnitData.Distance
                                              (*(int64 *)(lVar11 + 96),*(uint64 *)(lVar17 + 96)
                                               ,0);
                            iVar5 = local_res20;
                            lVar11 = *(int64 *)(lVar1 + 112);
                            if (iVar7 < local_res20) {
                              if ((((lVar11 == null) ||
                                   (lVar11 = FUN_180002f80(lVar11,iVar4,DAT_181d580a8)) == null) ||
                                  (*(int64 *)(lVar11 + 24) == 0)) ||
                                 (((lVar11 = FUN_180002f80(*(int64 *)(lVar11 + 24),plVar16,
                                                           DAT_181d584a0), lVar11 == null ||
                                   (this.targetGridUnit == null)) ||
                                  ((lVar17 = this.targetGridUnit.battleUnit,
                                   lVar17 == null ||
                                   ((*(int64 *)(lVar11 + 96) == 0 ||
                                    (local_res20 = GridUnitData.Distance
                                                             (*(int64 *)(lVar11 + 96),
                                                              *(uint64 *)(lVar17 + 96),0),
                                    lVar10 == null)))))))) throw; // [null/range check failed]
                              FUN_180f56130(lVar10,DAT_181d58228);
                              if ((*(int64 *)(lVar1 + 112) == 0) ||
                                 ((lVar11 = FUN_180002f80(*(int64 *)(lVar1 + 112),iVar4,DAT_181d580a8)
                                  , lVar11 == null || (*(int64 *)(lVar11 + 24) == 0))))
                              throw; // [null/range check failed]
                              uVar9 = FUN_180002f80(*(int64 *)(lVar11 + 24),plVar16,DAT_181d584a0);
                            }
                            else {
                              if ((((lVar11 == null) ||
                                   (lVar11 = FUN_180002f80(lVar11,iVar4,DAT_181d580a8)) == null) ||
                                  (*(int64 *)(lVar11 + 24) == 0)) ||
                                 (((lVar11 = FUN_180002f80(*(int64 *)(lVar11 + 24),plVar16,
                                                           DAT_181d584a0), lVar11 == null ||
                                   (this.targetGridUnit == null)) ||
                                  ((lVar17 = this.targetGridUnit.battleUnit,
                                   lVar17 == null || (*(int64 *)(lVar11 + 96) == 0))))))
                              throw; // [null/range check failed]
                              iVar7 = GridUnitData.Distance
                                                (*(int64 *)(lVar11 + 96),
                                                 *(uint64 *)(lVar17 + 96),0);
                              if (iVar7 != iVar5) goto LAB_180b21c04;
                              if (((*(int64 *)(lVar1 + 112) == 0) ||
                                  (lVar11 = FUN_180002f80(*(int64 *)(lVar1 + 112),iVar4,DAT_181d580a8)
                                  , lVar11 == null)) ||
                                 ((*(int64 *)(lVar11 + 24) == 0 ||
                                  (uVar9 = FUN_180002f80(*(int64 *)(lVar11 + 24),plVar16,
                                                         DAT_181d584a0), lVar10 == null))))
                              throw; // [null/range check failed]
                            }
                            FUN_181827900(lVar10,uVar9,DAT_181d581a8);
                          }
                        }
        LAB_180b21c04:
                        plVar16 = (int64 *)(uint64)((int)plVar16 + 1);
                      }
                      iVar4 = iVar4 + 1;
                    }
                    throw; // [null/range check failed]
                  }
                }
              }
        LAB_180b22008:
              bVar2 = false;
              if (this.targetGridUnit == null) throw; // [null/range check failed]
              lVar10 = this.targetGridUnit.battleUnit;
              cVar3 = BattleController.ManageDamage(lVar1,*(uint64 *)(lVar1 + 0x110),lVar10,0,0);
              local_res8 = cVar3;
              if (local_res8) {
                *(uint8 *)(lVar1 + 0x2b8) = 1;
              }
              if (lVar10 == null) throw; // [null/range check failed]
              cVar3 = BattleUnit.get_IsAlive(lVar10,0);
              if (!cVar3) {
                bVar2 = true;
                if ((*(int64 *)(lVar1 + 0x110) == 0) ||
                   (lVar10 = Component.GetComponent(*(int64 *)(lVar1 + 0x110),DAT_181d6acc0),
                   lVar10 == null)) throw; // [null/range check failed]
                if (*(char *)(lVar10 + 224) == false) {
                  if ((*(int64 *)(lVar1 + 0x110) == 0) ||
                     (lVar10 = Component.GetComponent(*(int64 *)(lVar1 + 0x110),DAT_181d6acc0),
                     lVar10 == null)) throw; // [null/range check failed]
                  *(uint8 *)(lVar10 + 224) = 1;
                  if (*(int64 *)(lVar1 + 0x110) == 0) throw; // [null/range check failed]
                  lVar10 = Component.GetComponent(*(int64 *)(lVar1 + 0x110),DAT_181d6acc0);
                  lVar11 = *(int64 *)(*(int64 *)(DAT_181d8b6a8 + 184) + 40);
                  if (lVar11 == null) throw; // [null/range check failed]
                  uVar8 = FUN_180d8cf10(0,*(uint32 *)(lVar11 + 24),0);
                  uVar9 = FUN_180002f80(lVar11,uVar8,DAT_181d7c9c0);
                  if (lVar10 == null) throw; // [null/range check failed]
                  BattleUnit.Talk(lVar10,uVar9);
                }
              }
            }
          }
          else if (iVar5 == 1) {
            if (this.targetGridUnit == null) throw; // [null/range check failed]
            uVar9 = this.targetGridUnit.battleUnit;
            cVar3 = Object.op_Inequality(uVar9,0,0);
            if (cVar3) {
              if (((this.targetGridUnit == null) ||
                  (lVar10 = this.targetGridUnit.battleUnit) == null) ||
                 (*(int64 *)(lVar10 + 64) == 0)) throw; // [null/range check failed]
              if (*(char *)(*(int64 *)(lVar10 + 64) + 16) == false) {
                lVar11 = *(int64 *)(lVar1 + 0x110);
                if (lVar11 == null) throw; // [null/range check failed]
                if (*(int64 *)(lVar10 + 88) != *(int64 *)(lVar11 + 88)) {
                  if (*(int64 *)(lVar11 + 64) == 0) throw; // [null/range check failed]
                  cVar3 = HeroData.AttackSelfTeam(*(int64 *)(lVar11 + 64),0);
                  if (!cVar3) goto LAB_180b20f66;
                }
                if ((this.targetGridUnit == null) || (*(int64 *)(lVar1 + 0x2a8) == 0))
                throw; // [null/range check failed]
                FUN_181827900(*(int64 *)(lVar1 + 0x2a8),
                              this.targetGridUnit.battleUnit,DAT_181d581a8);
                if (this.targetGridUnit == null) throw; // [null/range check failed]
                cVar3 = BattleController.ManageRecover
                                  (lVar1,*(uint64 *)(lVar1 + 0x110),
                                   this.targetGridUnit.battleUnit,0);
                if (cVar3) {
                  *(uint8 *)(lVar1 + 0x2b8) = 1;
                  local_res8 = true;
                }
              }
            }
          }
          else if (iVar5 == 2) {
            if (this.targetGridUnit == null) throw; // [null/range check failed]
            uVar9 = this.targetGridUnit.battleUnit;
            cVar3 = Object.op_Inequality(uVar9,0,0);
            if (cVar3) {
              if (((this.targetGridUnit == null) ||
                  (lVar10 = this.targetGridUnit.battleUnit) == null) ||
                 (*(int64 *)(lVar10 + 64) == 0)) throw; // [null/range check failed]
              if (*(char *)(*(int64 *)(lVar10 + 64) + 16) == false) {
                uVar9 = *(uint64 *)(lVar1 + 0x110);
                cVar3 = Object.op_Equality(lVar10,uVar9,0);
        LAB_180b2156e:
                if (cVar3) {
        LAB_180b21576:
                  if ((this.targetGridUnit == null) || (*(int64 *)(lVar1 + 0x2a8) == 0))
                  throw; // [null/range check failed]
                  FUN_181827900(*(int64 *)(lVar1 + 0x2a8),
                                this.targetGridUnit.battleUnit,DAT_181d581a8);
                  if (this.targetGridUnit == null) throw; // [null/range check failed]
                  cVar3 = BattleController.ManageRecover
                                    (lVar1,*(uint64 *)(lVar1 + 0x110),
                                     this.targetGridUnit.battleUnit,0);
                  if (cVar3) {
                    *(uint8 *)(lVar1 + 0x2b8) = 1;
                    local_res8 = true;
                  }
                }
              }
            }
          }
          else if (iVar5 == 3) {
            if (this.targetGridUnit == null) throw; // [null/range check failed]
            uVar9 = this.targetGridUnit.battleUnit;
            cVar3 = Object.op_Inequality(uVar9,0,0);
            if (cVar3) {
              if (((this.targetGridUnit == null) ||
                  (lVar10 = this.targetGridUnit.battleUnit) == null) ||
                 (*(int64 *)(lVar10 + 64) == 0)) throw; // [null/range check failed]
              if (*(char *)(*(int64 *)(lVar10 + 64) + 16) == false) {
                uVar9 = *(uint64 *)(lVar1 + 0x110);
                cVar3 = Object.op_Inequality(lVar10,uVar9,0);
                if (cVar3) {
                  if (((this.targetGridUnit == null) ||
                      (lVar10 = this.targetGridUnit.battleUnit) == null) ||
                     (lVar11 = *(int64 *)(lVar1 + 0x110)) == null) throw; // [null/range check failed]
                  if (*(int64 *)(lVar10 + 88) != *(int64 *)(lVar11 + 88)) {
                    if (*(int64 *)(lVar11 + 64) == 0) throw; // [null/range check failed]
                    cVar3 = HeroData.AttackSelfTeam(*(int64 *)(lVar11 + 64),0);
                    goto LAB_180b2156e;
                  }
                  goto LAB_180b21576;
                }
              }
            }
          }
          else if (iVar5 == 4) {
            if (this.targetGridUnit == null) throw; // [null/range check failed]
            cVar3 = GridUnitData.isEmpty(this.targetGridUnit,0);
            if (cVar3) {
              lVar10 = FUN_18046c0a0(0);
              if ((((*(int64 *)(lVar1 + 0x110) == 0) ||
                   (lVar11 = *(int64 *)(*(int64 *)(lVar1 + 0x110) + 64)) == null) ||
                  (lVar11 = HeroData.GetNowActiveSkill(lVar11,0)) == null) ||
                 (lVar11 = KungfuSkillLvData.DataBase(lVar11,0)) == null) throw; // [null/range check failed]
              uVar6 = *(uint32 *)(lVar11 + 128);
              if (((*(int64 *)(lVar1 + 0x110) == 0) ||
                  (lVar11 = *(int64 *)(*(int64 *)(lVar1 + 0x110) + 64)) == null) ||
                 (lVar11 = HeroData.GetNowActiveSkill(lVar11,0)) == null) throw; // [null/range check failed]
              BattleController.BattleUnitControlable(lVar1,*(uint64 *)(lVar1 + 0x110),0);
              if ((*(int64 *)(lVar1 + 0x110) == 0) || (lVar10 == null)) throw; // [null/range check failed]
              uVar21 = *(uint64 *)(*(int64 *)(lVar1 + 0x110) + 64);
              in_stack_ffffffffffffff38 = in_stack_ffffffffffffff38 & 0xffffffffffffff00;
              uVar9 = GameController.GenerateSummonData(lVar10,uVar6);
              if (*(int64 *)(lVar1 + 0x110) == 0) throw; // [null/range check failed]
              uVar21 = uVar21 & 0xffffffff00000000;
              lVar10 = BattleController.HeroEnterBattleField
                                 (lVar1,uVar9,*(uint64 *)(*(int64 *)(lVar1 + 0x110) + 88),
                                  this.targetGridUnit,
                                  in_stack_ffffffffffffff38 & 0xffffffff00000000,uVar21,0);
              uVar6 = (uint32)(uVar21 >> 32);
              plVar16 = (int64 *)(lVar1 + 0x280);
              *plVar16 = lVar10;
              il2cpp_internal(plVar16,lVar10);
              if (*plVar16 == 0) throw; // [null/range check failed]
              lVar10 = GameObject.GetComponent(*plVar16,DAT_181d9e778);
              if (lVar10 == null) throw; // [null/range check failed]
              *(uint64 *)(lVar10 + 72) = *(uint64 *)(lVar1 + 0x110);
              if (*plVar16 == 0) throw; // [null/range check failed]
              lVar10 = GameObject.GetComponent(*plVar16,DAT_181d9e778);
              if (((*(int64 *)(lVar1 + 0x110) == 0) ||
                  (lVar11 = *(int64 *)(*(int64 *)(lVar1 + 0x110) + 64)) == null) ||
                 (uVar9 = HeroData.GetNowActiveSkill(lVar11,0), lVar10 == null)) throw; // [null/range check failed]
              *(uint64 *)(lVar10 + 80) = uVar9;
              *(uint8 *)(lVar1 + 0x2a0) = 0;
              if ((*(int64 *)(lVar1 + 0x110) == 0) ||
                 (lVar10 = *(int64 *)(*(int64 *)(lVar1 + 0x110) + 64)) == null)
              throw; // [null/range check failed]
              uVar9 = HeroData.Name(lVar10,1,0);
              if ((*plVar16 == 0) ||
                 ((lVar10 = GameObject.GetComponent(*plVar16,DAT_181d9e778), lVar10 == null ||
                  (*(int64 *)(lVar10 + 64) == 0)))) throw; // [null/range check failed]
              uVar12 = HeroData.Name(*(int64 *)(lVar10 + 64),1,0);
              uVar9 = String.Format("{0}召唤了{1}。",uVar9,uVar12,0);
              BattleController.AddInfoText(lVar1,uVar9,1,0);
              if (*plVar16 == 0) throw; // [null/range check failed]
              lVar10 = GameObject.GetComponent(*plVar16,DAT_181d9e778);
              if ((*(int64 *)(lVar1 + 0x110) == 0) || (lVar10 == null)) throw; // [null/range check failed]
              *(uint8 *)(lVar10 + 176) = *(uint8 *)(*(int64 *)(lVar1 + 0x110) + 176);
            }
          }
        }
        LAB_180b20f66:
        if (((this.targetGridUnit == null) ||
            (lVar10 = GridUnitData.get_GridObj(this.targetGridUnit,0)) == null) ||
           (lVar10 = GameObject.GetComponent(lVar10,DAT_181d9f7f0)) == null) throw; // [null/range check failed]
        GridUnitController.OnHit(lVar10,*(uint64 *)(lVar1 + 0x110),0);
        if (*(int64 *)(lVar1 + 0x208) == 0) throw; // [null/range check failed]
        BattleController.ManageSkillSpeEffect
                  (lVar1,1,0,this.targetGridUnit,local_res8,
                   CONCAT44(uVar6,*(uint32 *)(*(int64 *)(lVar1 + 0x208) + 24)),0);
        if (local_res8) {
          if (this.targetGridUnit == null) throw; // [null/range check failed]
          uVar9 = this.targetGridUnit.battleUnit;
          cVar3 = Object.op_Inequality(uVar9,0,0);
          if (cVar3) {
            if (((this.targetGridUnit == null) ||
                (lVar10 = this.targetGridUnit.battleUnit) == null) ||
               (lVar10 = *(int64 *)(lVar10 + 64)) == null) throw; // [null/range check failed]
            if (*(char *)(lVar10 + 16) == false) {
              if (((*(int64 *)(lVar1 + 0x110) == 0) ||
                  (lVar10 = *(int64 *)(*(int64 *)(lVar1 + 0x110) + 64)) == null) ||
                 (lVar10 = *(int64 *)(lVar10 + 0x2b8)) == null) throw; // [null/range check failed]
              fVar19 = (float)HeroSpeAddData.Get(lVar10,133,0);
              if (fVar19 <= 0.0) {
                if (((*(int64 *)(lVar1 + 0x110) == 0) ||
                    (lVar10 = *(int64 *)(*(int64 *)(lVar1 + 0x110) + 64)) == null) ||
                   (lVar10 = *(int64 *)(lVar10 + 0x2b8)) == null) throw; // [null/range check failed]
                fVar19 = (float)HeroSpeAddData.Get(lVar10,134,0);
                if (fVar19 <= 0.0) goto LAB_180b21147;
              }
              if (this.targetGridUnit == null) throw; // [null/range check failed]
              lVar10 = this.targetGridUnit.battleUnit;
              lVar11 = *(int64 *)(lVar1 + 0x110);
              if (lVar11 == null) throw; // [null/range check failed]
              uVar9 = *(uint64 *)(lVar11 + 96);
              if ((*(int64 *)(lVar11 + 64) == 0) ||
                 (uVar6 = HeroData.GetHitMoveRange(*(int64 *)(lVar11 + 64),0), lVar10 == null))
              throw; // [null/range check failed]
              uVar9 = BattleUnit.MoveFromTarget(lVar10,uVar9,uVar6,0);
              FUN_180d837c0(lVar1,uVar9,0);
            }
          }
        }
        LAB_180b21147:
        if ((((*(int64 *)(lVar1 + 0x110) == 0) ||
             (lVar10 = *(int64 *)(*(int64 *)(lVar1 + 0x110) + 64)) == null) ||
            (lVar10 = HeroData.GetNowActiveSkill(lVar10,0)) == null) ||
           (lVar10 = KungfuSkillLvData.DataBase(lVar10,0)) == null) throw; // [null/range check failed]
        if (*(char *)(lVar10 + 188) != false) {
          if (*(int64 *)(lVar1 + 0x110) == 0) throw; // [null/range check failed]
          uVar9 = Component.get_transform(*(int64 *)(lVar1 + 0x110),0);
          if (((this.targetGridUnit == null) ||
              (lVar10 = GridUnitData.get_GridObj(this.targetGridUnit,0)) == null) ||
             (lVar10 = GameObject.get_transform(lVar10,0)) == null) throw; // [null/range check failed]
          puVar13 = (uint64 *)Transform.get_localPosition(&local_68,lVar10,0);
          local_88 = *puVar13;
          local_80 = *(float *)(puVar13 + 1);
          local_78 = *(uint64 *)(pStatics_b128 + 16);
          local_70 = *(float *)(pStatics_b128 + 24);
          fVar19 = local_80 + local_70;
          local_98 = CONCAT44(local_88._4_4_ + (float)((uint64)local_78 >> 32),
                              (float)local_88 + (float)local_78);
          lVar10 = FUN_18046c0a0(0);
          if ((lVar10 == null) || (*(int64 *)(lVar10 + 32) == 0)) throw; // [null/range check failed]
          local_78 = local_98;
          local_70 = fVar19;
          ShortcutExtensions.DOLocalMove
                    (uVar9,&local_78,0.1 / *(float *)(*(int64 *)(lVar10 + 32) + 0x1d8),0,0);
          if (*(int64 *)(lVar1 + 0x110) == 0) throw; // [null/range check failed]
          uVar9 = Component.get_transform(*(int64 *)(lVar1 + 0x110),0);
          lVar10 = FUN_18046c0a0(0);
          if ((lVar10 == null) || (*(int64 *)(lVar10 + 32) == 0)) throw; // [null/range check failed]
          ShortcutExtensions.DOScale(uVar9);
        }
        if (local_res8) {
          lVar10 = FUN_180a65300(0);
          if (bVar2) {
            if (lVar10 == null) throw; // [null/range check failed]
            TimeScaleController.SetSlowTime(lVar10);
            if ((*(int64 *)(lVar1 + 0x110) == 0) ||
               (lVar10 = *(int64 *)(*(int64 *)(lVar1 + 0x110) + 64)) == null)
            throw; // [null/range check failed]
            HeroData.ChangeSkillPower(lVar10,3);
          }
          else {
            if ((((*(int64 *)(lVar1 + 0x110) == 0) ||
                 (lVar11 = *(int64 *)(*(int64 *)(lVar1 + 0x110) + 64)) == null) ||
                (lVar11 = HeroData.GetNowActiveSkill(lVar11,0)) == null) ||
               ((lVar11 = KungfuSkillLvData.DataBase(lVar11,0), lVar11 == null || (lVar10 == null))))
            throw; // [null/range check failed]
            TimeScaleController.SetSlowTime(lVar10,(float)*(int *)(lVar11 + 52) * 0.01 + 0.05);
          }
        }
        if (*(int64 *)(lVar1 + 0x2b0) != 0) {
          FUN_181827900(*(int64 *)(lVar1 + 0x2b0),this.targetGridUnit,DAT_181d63778);
          if ((*(int64 *)(lVar1 + 0x2b0) != 0) && (*(int64 *)(lVar1 + 0x208) != 0)) {
            if (*(int *)(*(int64 *)(lVar1 + 0x2b0) + 24) ==
                *(int *)(*(int64 *)(lVar1 + 0x208) + 24)) {
              uVar9 = BattleController.BattleUnitAttackFinish(lVar1,0);
              FUN_180d837c0(lVar1,uVar9,0);
            }
            return false;
          }
        }
    }

    // Token : 0x6000BD6
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000BD7
    // RVA   : 0xB22260   Offset: 0xB20A60   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d6e818);
    }

    // Token : 0x6000BD8
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
