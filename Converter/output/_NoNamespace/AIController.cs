// ============================================================
// Type  : AIController
// Token : 0x2000131
// ============================================================

public class AIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000779
    public static List<string> AIStuffTypeName;

    // Token: 0x400077A
    public static List<AIStuffType> InteractOtherHeroAiStuffType;

    // Token: 0x400077B
    public static List<AIStuffType> NeedBigMapMoveAiStuffType;

    // Token: 0x400077C
    public static List<AIStuffType> FightHeroAiStuffType;

    // Token: 0x400077D
    public static List<AISettingType> ExtraFocusAISettingType;

    // Token: 0x400077E
    public List<HeroData> needLeaveHero;

    // Token: 0x400077F
    private static AIController _instance;

    // Token: 0x4000780
    private readonly List<int> speSkillIDList;

    // Token: 0x4000781
    private static List<ItemType> availablePoisonItemType;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60009C2
    // RVA   : 0x14B20B0   Offset: 0x14B08B0   Length: 0x58
    public static AIController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d84cc0 + 184) + 40);
    }

    // Token : 0x60009C3
    // RVA   : 0x14A3CA0   Offset: 0x14A24A0   Length: 0x11E
    private void Awake()
    {
        var pStatics = *(int64*)(DAT_181d84cc0 + 184);
        bool cVar1;
        ulong uVar2;
        uVar2 = *(uint64 *)(pStatics + 40);
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (!cVar1) {
          uVar2 = Component.get_gameObject(this,0);
          Object.Destroy(uVar2,0);
          return;
        }
        puVar3 = (uint64 *)(pStatics + 40);
        *puVar3 = this;
        il2cpp_internal(puVar3,this);
    }

    // Token : 0x60009C4
    // RVA   : 0x14B1580   Offset: 0x14AFD80   Length: 0x31E
    private void Update()
    {
        long lVar1;
        long lVar2;
        long lVar3;
        ulong uVar5;
        uint uVar6;
        long lVar9;
        lVar1 = this.needLeaveHero;
        if (lVar1 != null) {
          if (lVar1.Count < 1) {
            return;
          }
          lVar9 = 32;
          plVar8 = (int64 *)0;
          do {
            uVar6 = (uint32)plVar8;
            if (lVar1.Count <= (int)uVar6) {
              FUN_180f56130(lVar1,DAT_181d63e78);
              return;
            }
            if (lVar1 == null) break;
            if (lVar1.Count <= uVar6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(int64 *)(lVar9 + lVar1._items) != 0) {
              if (((this.needLeaveHero == null) ||
                  (lVar1 = FUN_180002f80(this.needLeaveHero,plVar8,DAT_181d643f8)) == null)
                 || (*(int64 *)(lVar1 + 64) == 0)) break;
              if (*(int *)(*(int64 *)(lVar1 + 64) + 16) == 1) {
                if ((this.needLeaveHero == null) ||
                   (lVar1 = FUN_180002f80(this.needLeaveHero,plVar8,DAT_181d643f8)) == null
                   ) break;
                if (-1 < *(int *)(lVar1 + 192)) {
                  if (this.needLeaveHero == null) break;
                  lVar1 = FUN_180002f80(this.needLeaveHero,plVar8,DAT_181d643f8);
                  lVar2 = FUN_18046c0a0(0);
                  if (lVar2 == null) break;
                  lVar2 = *(int64 *)(lVar2 + 32);
                  if (((((this.needLeaveHero == null) ||
                        (lVar3 = FUN_180002f80(this.needLeaveHero,plVar8,DAT_181d643f8),
                        lVar3 == null)) || (lVar2 == null)) ||
                      ((lVar2 = WorldData.GetArea(lVar2,*(uint32 *)(lVar3 + 192),0), lVar2 == null ||
                       (*(int64 *)(lVar2 + 64) == 0)))) ||
                     (plVar4 = (int64 *)BigMapPos.Clone(*(int64 *)(lVar2 + 64),0), lVar1 == null))
                  break;
                  plVar7 = (int64 *)0;
                  if (plVar4 != (int64 *)0) {
                  }
                  *(int64 **)(lVar1 + 200) = plVar7;
                  lVar1 = FUN_18046c0a0(0);
                  if ((this.needLeaveHero == null) ||
                     (uVar5 = FUN_180002f80(this.needLeaveHero,plVar8,DAT_181d643f8),
                     lVar1 == null)) break;
                  GameController.HeroLeaveArea(lVar1,uVar5,0);
                  lVar1 = FUN_18046bbe0(0);
                  if ((this.needLeaveHero == null) ||
                     (uVar5 = FUN_180002f80(this.needLeaveHero,plVar8,DAT_181d643f8),
                     lVar1 == null)) break;
                  BigMapController.CreateBigMapNpc(lVar1,uVar5,0);
                }
              }
            }
            lVar1 = this.needLeaveHero;
            plVar8 = (int64 *)(uint64)(uVar6 + 1);
            lVar9 = lVar9 + 8;
          } while (lVar1 != null);
        }
    }

    // Token : 0x60009C5
    // RVA   : 0x14A2C90   Offset: 0x14A1490   Length: 0x415
    public void AICheckSpeMed(HeroData hero)
    {
        long lVar1;
        ulong uVar2;
        uint uVar3;
        long lVar4;
        if ((hero != null) && (*(int64 *)(hero + 64) != 0)) {
          *(uint8 *)(*(int64 *)(hero + 64) + 46) = 0;
          if ((*(int64 *)(hero + 0x220) != 0) &&
             (lVar4 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) != null) {
            if (*(uint32 *)(lVar4 + 24) < 2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 40);
            if (lVar4 != null) {
              uVar3 = *(int *)(lVar4 + 24) - 1;
              if (-1 < (int)uVar3) {
                lVar4 = (int64)(int)uVar3 * 8 + 32;
                do {
                  if ((*(int64 *)(hero + 0x220) == 0) ||
                     (lVar1 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null)
                  throw; // [null/range check failed]
                  if (*(uint32 *)(lVar1 + 24) < 2) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar1 = *(int64 *)(*(int64 *)(lVar1 + 16) + 40);
                  if (lVar1 == null) throw; // [null/range check failed]
                  if (*(uint32 *)(lVar1 + 24) <= uVar3) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar1 = *(int64 *)(lVar4 + *(int64 *)(lVar1 + 16));
                  if (((lVar1 == null) || (lVar1 = *(int64 *)(lVar1 + 104)) == null) ||
                     (lVar1 = MedFoodData.GetChangeHeroStateData(lVar1,0)) == null)
                  throw; // [null/range check failed]
                  if (*(float *)(lVar1 + 20) == 0.0) {
                    if ((*(int64 *)(hero + 0x220) == 0) ||
                       (lVar1 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null)
                    throw; // [null/range check failed]
                    if (*(uint32 *)(lVar1 + 24) < 2) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar1 = *(int64 *)(*(int64 *)(lVar1 + 16) + 40);
                    if (((lVar1 == null) || (lVar1 = FUN_180002f80(lVar1,uVar3,DAT_181d69770)) == null)
                       || ((*(int64 *)(lVar1 + 104) == 0 ||
                           (lVar1 = MedFoodData.GetChangeHeroStateData(*(int64 *)(lVar1 + 104),0),
                           lVar1 == null)))) throw; // [null/range check failed]
                    if (*(float *)(lVar1 + 28) == 0.0)
                    {
                      }
                      else {
                    }
                    if ((*(int64 *)(hero + 0x220) == 0) ||
                       (lVar1 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null)
                    throw; // [null/range check failed]
                    if (*(uint32 *)(lVar1 + 24) < 2) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar1 = *(int64 *)(*(int64 *)(lVar1 + 16) + 40);
                    if (lVar1 == null) throw; // [null/range check failed]
                    uVar2 = FUN_180002f80(lVar1,uVar3,DAT_181d69770);
                    HeroData.UseMedFood(hero,uVar2,0,0,0,0);
                  }
                  lVar4 = lVar4 + -8;
                  uVar3 = uVar3 - 1;
                } while (-1 < (int)uVar3);
              }
              if ((*(int64 *)(hero + 0x220) != 0) &&
                 (lVar4 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) != null) {
                if (*(uint32 *)(lVar4 + 24) < 3) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 48);
                if (lVar4 != null) {
                  uVar3 = *(int *)(lVar4 + 24) - 1;
                  if (-1 < (int)uVar3) {
                    lVar4 = (int64)(int)uVar3 * 8 + 32;
                    do {
                      if ((*(int64 *)(hero + 0x220) == 0) ||
                         (lVar1 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null)
                      throw; // [null/range check failed]
                      if (*(uint32 *)(lVar1 + 24) < 3) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar1 = *(int64 *)(*(int64 *)(lVar1 + 16) + 48);
                      if (lVar1 == null) throw; // [null/range check failed]
                      if (*(uint32 *)(lVar1 + 24) <= uVar3) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar1 = *(int64 *)(lVar4 + *(int64 *)(lVar1 + 16));
                      if (((lVar1 == null) || (lVar1 = *(int64 *)(lVar1 + 104)) == null) ||
                         (lVar1 = MedFoodData.GetChangeHeroStateData(lVar1,0)) == null)
                      throw; // [null/range check failed]
                      if (*(float *)(lVar1 + 20) == 0.0) {
                        if ((*(int64 *)(hero + 0x220) == 0) ||
                           (lVar1 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null)
                        throw; // [null/range check failed]
                        if (*(uint32 *)(lVar1 + 24) < 3) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar1 = *(int64 *)(*(int64 *)(lVar1 + 16) + 48);
                        if (((lVar1 == null) ||
                            (lVar1 = FUN_180002f80(lVar1,uVar3,DAT_181d69770)) == null) ||
                           ((*(int64 *)(lVar1 + 104) == 0 ||
                            (lVar1 = MedFoodData.GetChangeHeroStateData(*(int64 *)(lVar1 + 104),0),
                            lVar1 == null)))) throw; // [null/range check failed]
                        if (*(float *)(lVar1 + 28) == 0.0)
                        {
                          }
                          else {
                        }
                        if ((*(int64 *)(hero + 0x220) == 0) ||
                           (lVar1 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null)
                        throw; // [null/range check failed]
                        if (*(uint32 *)(lVar1 + 24) < 3) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar1 = *(int64 *)(*(int64 *)(lVar1 + 16) + 48);
                        if (lVar1 == null) throw; // [null/range check failed]
                        uVar2 = FUN_180002f80(lVar1,uVar3,DAT_181d69770);
                        HeroData.UseMedFood(hero,uVar2,0,0,0,0);
                      }
                      lVar4 = lVar4 + -8;
                      uVar3 = uVar3 - 1;
                    } while (-1 < (int)uVar3);
                  }
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x60009C6
    // RVA   : 0x14A0E60   Offset: 0x149F660   Length: 0xD19
    public void AICheckEquipment(HeroData hero)
    {
        int iVar1;
        int iVar2;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        ulong uVar7;
        uint uVar8;
        ulong uVar9;
        ulong uVar10;
        ulong uVar11;
        ulong uVar12;
        float fVar13;
        float fVar14;
        if ((hero != null) && (*(int64 *)(hero + 64) != 0)) {
          uVar10 = 0;
          *(uint8 *)(*(int64 *)(hero + 64) + 44) = 0;
          uVar11 = uVar10;
          uVar12 = uVar10;
          while ((*(int64 *)(hero + 0x220) != 0 &&
                 (lVar4 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) != null)) {
            if (*(int *)(lVar4 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 32);
            if (lVar4 == null) break;
            uVar8 = (uint32)uVar12;
            if (*(int *)(lVar4 + 24) <= (int)uVar8) {
              lVar4 = 32;
              goto LAB_1814a18a0;
            }
            if ((*(int64 *)(hero + 0x220) == 0) ||
               (lVar4 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null) break;
            if (*(int *)(lVar4 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 32);
            if (lVar4 == null) break;
            if (*(uint32 *)(lVar4 + 24) <= uVar8) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 32 + uVar11 * 8);
            if ((lVar4 == null) || (lVar4 = *(int64 *)(lVar4 + 96)) == null) break;
            if (*(char *)(lVar4 + 48) != false) goto LAB_1814a187a;
            if ((*(int64 *)(hero + 0x220) == 0) ||
               (lVar4 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null) break;
            if (*(int *)(lVar4 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 32);
            if ((lVar4 == null) || (lVar4 = FUN_180002f80(lVar4,uVar12,DAT_181d69770)) == null) break;
            iVar1 = *(int *)(lVar4 + 24);
            uVar7 = uVar10;
            if (iVar1 == 0) {
              while( true ) {
                if ((*(int64 *)(hero + 0x1f8) == 0) ||
                   (lVar4 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 32)) == null)
                goto LAB_1814a1b74;
                if (*(int *)(lVar4 + 24) <= (int)uVar7) goto LAB_1814a187a;
                lVar4 = FUN_180002f80(lVar4,uVar7,DAT_181d69770);
                if (lVar4 == null) break;
                if (((*(int64 *)(hero + 0x1f8) == 0) ||
                    (lVar4 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 32)) == null) ||
                   (lVar4 = FUN_180002f80(lVar4,uVar7,DAT_181d69770)) == null) goto LAB_1814a1b74;
                iVar1 = *(int *)(lVar4 + 56);
                lVar4 = *(int64 *)(hero + 0x108);
                if (((*(int64 *)(hero + 0x1f8) == 0) ||
                    (lVar6 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 32)) == null) ||
                   ((lVar6 = FUN_180002f80(lVar6,uVar7,DAT_181d69770), lVar6 == null ||
                    ((*(int64 *)(lVar6 + 96) == 0 || (lVar4 == null)))))) goto LAB_1814a1b74;
                cVar3 = FUN_181815240(lVar4,*(int *)(*(int64 *)(lVar6 + 96) + 20) + 3,DAT_181d67bf8
                                     );
                if (!cVar3) {
                  fVar14 = 1.0;
                }
                else {
                  fVar14 = 8.0;
                }
                if ((*(int64 *)(hero + 0x220) == 0) ||
                   (lVar4 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null)
                goto LAB_1814a1b74;
                if (*(int *)(lVar4 + 24) == 0) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 32);
                if ((lVar4 == null) || (lVar4 = FUN_180002f80(lVar4,uVar12,DAT_181d69770)) == null)
                goto LAB_1814a1b74;
                iVar2 = *(int *)(lVar4 + 56);
                lVar4 = *(int64 *)(hero + 0x108);
                if ((*(int64 *)(hero + 0x220) == 0) ||
                   (lVar6 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null)
                goto LAB_1814a1b74;
                if (*(int *)(lVar6 + 24) == 0) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar6 = *(int64 *)(*(int64 *)(lVar6 + 16) + 32);
                if ((((lVar6 == null) || (lVar6 = FUN_180002f80(lVar6,uVar12,DAT_181d69770)) == null) ||
                    (*(int64 *)(lVar6 + 96) == 0)) || (lVar4 == null)) goto LAB_1814a1b74;
                cVar3 = FUN_181815240(lVar4,*(int *)(*(int64 *)(lVar6 + 96) + 20) + 3,DAT_181d67bf8
                                     );
                if (!cVar3) {
                  fVar13 = 1.0;
                }
                else {
                  fVar13 = 8.0;
                }
                if ((float)iVar1 * fVar14 < (float)iVar2 * fVar13) break;
                uVar7 = (uint64)((int)uVar7 + 1);
              }
              if ((*(int64 *)(hero + 0x1f8) == 0) ||
                 (lVar4 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 32)) == null) break;
        LAB_1814a17f8:
              uVar5 = FUN_180002f80(lVar4,uVar7,DAT_181d69770);
              HeroData.UnequipItem(hero,uVar5,0,0,0);
              if ((*(int64 *)(hero + 0x220) == 0) ||
                 (lVar4 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null) break;
              if (*(int *)(lVar4 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 32);
              if (lVar4 == null) break;
              uVar5 = FUN_180002f80(lVar4,uVar12,DAT_181d69770);
              HeroData.EquipItem(hero,uVar5,0,0,0);
            }
            else {
              if (iVar1 == 1) {
                while( true ) {
                  if ((*(int64 *)(hero + 0x1f8) == 0) ||
                     (lVar4 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 56)) == null)
                  goto LAB_1814a1b74;
                  if (*(int *)(lVar4 + 24) <= (int)uVar7) goto LAB_1814a187a;
                  lVar4 = FUN_180002f80(lVar4,uVar7,DAT_181d69770);
                  if (lVar4 == null) break;
                  if (((*(int64 *)(hero + 0x1f8) == 0) ||
                      (lVar4 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 56)) == null) ||
                     (lVar4 = FUN_180002f80(lVar4,uVar7,DAT_181d69770)) == null) goto LAB_1814a1b74;
                  iVar1 = *(int *)(lVar4 + 56);
                  if ((*(int64 *)(hero + 0x220) == 0) ||
                     (lVar4 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null)
                  goto LAB_1814a1b74;
                  if (*(int *)(lVar4 + 24) == 0) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 32);
                  if ((lVar4 == null) || (lVar4 = FUN_180002f80(lVar4,uVar12,DAT_181d69770)) == null)
                  goto LAB_1814a1b74;
                  if (iVar1 < *(int *)(lVar4 + 56)) break;
                  uVar7 = (uint64)((int)uVar7 + 1);
                }
                if (*(int64 *)(hero + 0x1f8) != 0) {
                  lVar4 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 56);
        joined_r0x0001814a15ca:
                  if (lVar4 != null) goto LAB_1814a17f8;
                }
                break;
              }
              if (iVar1 == 2) {
                while( true ) {
                  if ((*(int64 *)(hero + 0x1f8) == 0) ||
                     (lVar4 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 80)) == null)
                  goto LAB_1814a1b74;
                  if (*(int *)(lVar4 + 24) <= (int)uVar7) goto LAB_1814a187a;
                  lVar4 = FUN_180002f80(lVar4,uVar7,DAT_181d69770);
                  if (lVar4 == null) break;
                  if (((*(int64 *)(hero + 0x1f8) == 0) ||
                      (lVar4 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 80)) == null) ||
                     (lVar4 = FUN_180002f80(lVar4,uVar7,DAT_181d69770)) == null) goto LAB_1814a1b74;
                  iVar1 = *(int *)(lVar4 + 56);
                  if ((*(int64 *)(hero + 0x220) == 0) ||
                     (lVar4 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null)
                  goto LAB_1814a1b74;
                  if (*(int *)(lVar4 + 24) == 0) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 32);
                  if ((lVar4 == null) || (lVar4 = FUN_180002f80(lVar4,uVar12,DAT_181d69770)) == null)
                  goto LAB_1814a1b74;
                  if (iVar1 < *(int *)(lVar4 + 56)) break;
                  uVar7 = (uint64)((int)uVar7 + 1);
                }
                if (*(int64 *)(hero + 0x1f8) != 0) {
                  lVar4 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 80);
                  goto joined_r0x0001814a15ca;
                }
                break;
              }
              if (iVar1 == 3) {
                while( true ) {
                  if ((*(int64 *)(hero + 0x1f8) == 0) ||
                     (lVar4 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 104)) == null)
                  goto LAB_1814a1b74;
                  if (*(int *)(lVar4 + 24) <= (int)uVar7) goto LAB_1814a187a;
                  lVar4 = FUN_180002f80(lVar4,uVar7,DAT_181d69770);
                  if (lVar4 == null) break;
                  if (((*(int64 *)(hero + 0x1f8) == 0) ||
                      (lVar4 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 104)) == null) ||
                     (lVar4 = FUN_180002f80(lVar4,uVar7,DAT_181d69770)) == null) goto LAB_1814a1b74;
                  iVar1 = *(int *)(lVar4 + 56);
                  if ((*(int64 *)(hero + 0x220) == 0) ||
                     (lVar4 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null)
                  goto LAB_1814a1b74;
                  if (*(int *)(lVar4 + 24) == 0) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 32);
                  if ((lVar4 == null) || (lVar4 = FUN_180002f80(lVar4,uVar12,DAT_181d69770)) == null)
                  goto LAB_1814a1b74;
                  if (iVar1 < *(int *)(lVar4 + 56)) break;
                  uVar7 = (uint64)((int)uVar7 + 1);
                }
                if (*(int64 *)(hero + 0x1f8) != 0) {
                  lVar4 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 104);
                  goto joined_r0x0001814a15ca;
                }
                break;
              }
              if (iVar1 == 4) {
                uVar7 = 0xffffffff;
                uVar9 = uVar10;
                while( true ) {
                  if ((*(int64 *)(hero + 0x1f8) == 0) ||
                     (lVar4 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 128)) == null)
                  goto LAB_1814a1b74;
                  if (*(int *)(lVar4 + 24) <= (int)uVar9) goto LAB_1814a123d;
                  lVar4 = FUN_180002f80(lVar4,uVar9,DAT_181d69770);
                  if (lVar4 == null) break;
                  if (((*(int64 *)(hero + 0x1f8) == 0) ||
                      (lVar4 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 128)) == null) ||
                     (lVar4 = FUN_180002f80(lVar4,uVar9,DAT_181d69770)) == null) goto LAB_1814a1b74;
                  iVar1 = *(int *)(lVar4 + 56);
                  if ((*(int64 *)(hero + 0x220) == 0) ||
                     (lVar4 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null)
                  goto LAB_1814a1b74;
                  if (*(int *)(lVar4 + 24) == 0) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 32);
                  if ((lVar4 == null) || (lVar4 = FUN_180002f80(lVar4,uVar12,DAT_181d69770)) == null)
                  goto LAB_1814a1b74;
                  if (iVar1 < *(int *)(lVar4 + 56)) {
                    if ((int)uVar7 != -1) {
                      if (((*(int64 *)(hero + 0x1f8) == 0) ||
                          (lVar4 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 128)) == null) ||
                         (lVar4 = FUN_180002f80(lVar4,uVar9,DAT_181d69770)) == null)
                      goto LAB_1814a1b74;
                      iVar1 = *(int *)(lVar4 + 56);
                      if (((*(int64 *)(hero + 0x1f8) == 0) ||
                          (lVar4 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 128)) == null) ||
                         (lVar4 = FUN_180002f80(lVar4,uVar7,DAT_181d69770)) == null)
                      goto LAB_1814a1b74;
                      if (*(int *)(lVar4 + 56) > iVar1)
                      {
                        }
                        uVar7 = uVar9;
                        }
                      }
                  uVar9 = (uint64)((int)uVar9 + 1);
                }
                if ((*(int64 *)(hero + 0x220) == 0) ||
                   (lVar4 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null) break;
                if (*(int *)(lVar4 + 24) == 0) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 32);
                if (lVar4 == null) break;
                uVar5 = FUN_180002f80(lVar4,uVar12,DAT_181d69770);
                HeroData.EquipItem(hero,uVar5,0,0,0);
        LAB_1814a123d:
                if ((*(int64 *)(hero + 0x220) == 0) ||
                   (lVar4 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null) break;
                if (*(int *)(lVar4 + 24) == 0) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 32);
                if (((lVar4 == null) || (lVar4 = FUN_180002f80(lVar4,uVar12,DAT_181d69770)) == null) ||
                   (*(int64 *)(lVar4 + 96) == 0)) break;
                if ((*(char *)(*(int64 *)(lVar4 + 96) + 48) == false) && (-1 < (int)uVar7)) {
                  if (*(int64 *)(hero + 0x1f8) != 0) {
                    lVar4 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 128);
                    goto joined_r0x0001814a15ca;
                  }
                  break;
                }
              }
            }
        LAB_1814a187a:
            uVar12 = (uint64)(uVar8 + 1);
            uVar11 = uVar11 + 1;
          }
        }
        LAB_1814a1b74:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_1814a18a0:
        if ((*(int64 *)(hero + 0x220) == 0) ||
           (lVar6 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null) goto LAB_1814a1b74;
        if (*(uint32 *)(lVar6 + 24) < 7) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar6 = *(int64 *)(*(int64 *)(lVar6 + 16) + 80);
        if (lVar6 == null) goto LAB_1814a1b74;
        uVar8 = (uint32)uVar10;
        if (*(int *)(lVar6 + 24) <= (int)uVar8) {
          return;
        }
        if ((*(int64 *)(hero + 0x220) == 0) ||
           (lVar6 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null) goto LAB_1814a1b74;
        if (*(uint32 *)(lVar6 + 24) < 7) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar6 = *(int64 *)(*(int64 *)(lVar6 + 16) + 80);
        if (lVar6 == null) goto LAB_1814a1b74;
        if (*(uint32 *)(lVar6 + 24) <= uVar8) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar6 = *(int64 *)(lVar4 + *(int64 *)(lVar6 + 16));
        if ((lVar6 == null) || (lVar6 = *(int64 *)(lVar6 + 136)) == null) goto LAB_1814a1b74;
        if (*(char *)(lVar6 + 16) == false) {
          if ((*(int64 *)(hero + 0x220) == 0) ||
             (lVar6 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null)
          goto LAB_1814a1b74;
          if (*(uint32 *)(lVar6 + 24) < 7) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar6 = *(int64 *)(*(int64 *)(lVar6 + 16) + 80);
          if ((lVar6 == null) || (lVar6 = FUN_180002f80(lVar6,uVar10,DAT_181d69770)) == null)
          goto LAB_1814a1b74;
          if (*(int *)(lVar6 + 24) == 0) {
            if (*(int64 *)(hero + 0x208) != 0) {
              iVar1 = *(int *)(*(int64 *)(hero + 0x208) + 56);
              if ((*(int64 *)(hero + 0x220) == 0) ||
                 (lVar6 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null)
              goto LAB_1814a1b74;
              if (*(uint32 *)(lVar6 + 24) < 7) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar6 = *(int64 *)(*(int64 *)(lVar6 + 16) + 80);
              if ((lVar6 == null) || (lVar6 = FUN_180002f80(lVar6,uVar10,DAT_181d69770)) == null)
              goto LAB_1814a1b74;
              if (*(int *)(lVar6 + 56) <= iVar1) goto LAB_1814a1b0a;
            }
            uVar5 = *(uint64 *)(hero + 0x208);
          }
          else {
            if (*(int *)(lVar6 + 24) != 1) goto LAB_1814a1b0a;
            if (*(int64 *)(hero + 0x218) != 0) {
              iVar1 = *(int *)(*(int64 *)(hero + 0x218) + 56);
              if ((*(int64 *)(hero + 0x220) == 0) ||
                 (lVar6 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null)
              goto LAB_1814a1b74;
              if (*(uint32 *)(lVar6 + 24) < 7) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar6 = *(int64 *)(*(int64 *)(lVar6 + 16) + 80);
              if ((lVar6 == null) || (lVar6 = FUN_180002f80(lVar6,uVar10,DAT_181d69770)) == null)
              goto LAB_1814a1b74;
              if (*(int *)(lVar6 + 56) <= iVar1) goto LAB_1814a1b0a;
            }
            uVar5 = *(uint64 *)(hero + 0x218);
          }
          HeroData.UnequipItem(hero,uVar5,0,0,0);
          if ((*(int64 *)(hero + 0x220) == 0) ||
             (lVar6 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null)
          goto LAB_1814a1b74;
          if (*(uint32 *)(lVar6 + 24) < 7) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar6 = *(int64 *)(*(int64 *)(lVar6 + 16) + 80);
          if (lVar6 == null) goto LAB_1814a1b74;
          uVar5 = FUN_180002f80(lVar6,uVar10,DAT_181d69770);
          HeroData.EquipItem(hero,uVar5,0,0,0);
        }
        LAB_1814a1b0a:
        uVar10 = (uint64)(uVar8 + 1);
        lVar4 = lVar4 + 8;
        goto LAB_1814a18a0;
    }

    // Token : 0x60009C7
    // RVA   : 0x14AB490   Offset: 0x14A9C90   Length: 0x1C0
    public float GetSkillScore(HeroData targetHero, KungfuSkillLvData targetSkill)
    {
        int iVar1;
        bool cVar2;
        int iVar3;
        uint uVar4;
        long lVar5;
        ulong uVar6;
        float fVar7;
        float fVar8;
        if (targetSkill != null) {
          lVar5 = KungfuSkillLvData.DataBase(targetSkill,0);
          if ((lVar5 != null) && (this.speSkillIDList != null)) {
            iVar3 = *(int *)(lVar5 + 52);
            cVar2 = FUN_181815240(this.speSkillIDList,*(uint32 *)(targetSkill + 16),
                                  DAT_181d67bf8);
            if (!cVar2) {
              fVar8 = 1.0;
            }
            else {
              fVar8 = 1.5;
            }
            iVar1 = *(int *)(targetSkill + 20);
            if (targetHero != null) {
              lVar5 = *(int64 *)(targetHero + 0x118);
              uVar6 = KungfuSkillLvData.Name(targetSkill,0,0);
              if (lVar5 != null) {
                cVar2 = FUN_1818279a0(lVar5,uVar6,DAT_181d7c4d0);
                if (!cVar2) {
                  fVar7 = 0.0;
                }
                else {
                  fVar7 = 0.15;
                }
                fVar8 = ((float)iVar1 * 0.1 + 1.0 + fVar7) * ((float)iVar3 + 1.0) * fVar8;
                iVar3 = KungfuSkillLvData.Type(targetSkill,0);
                if (2 < iVar3) {
                  if (*(int *)(targetSkill + 20) < 4) {
                    fVar7 = (float)Mathf.Max(0x3dcccccd,(float)*(int *)(targetSkill + 20) * 0.25,0);
                    fVar8 = fVar8 * fVar7;
                  }
                  lVar5 = *(int64 *)(targetHero + 0x108);
                  uVar4 = KungfuSkillLvData.Type(targetSkill,0);
                  if (lVar5 == null) throw; // [null/range check failed]
                  cVar2 = FUN_181815240(lVar5,uVar4,DAT_181d67bf8);
                  if (cVar2) {
                    fVar8 = fVar8 * 1.5;
                  }
                }
                return fVar8;
              }
            }
          }
        }
    }

    // Token : 0x60009C8
    // RVA   : 0x14A22F0   Offset: 0x14A0AF0   Length: 0x997
    public void AICheckSkill(HeroData hero)
    {
        uint uVar1;
        bool cVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        long lVar6;
        long lVar7;
        long lVar8;
        long lVar9;
        long lVar10;
        ulong uVar11;
        int iVar12;
        int iVar13;
        ulong uVar14;
        ulong uVar15;
        ulong uVar16;
        ulong uVar17;
        float fVar18;
        float fVar19;
        float fVar20;
        float fVar21;
        float fVar22;
        float fVar23;
        uint local_res10;
        long local_res20;
        if ((hero != null) && (*(int64 *)(hero + 64) != 0)) {
          *(uint8 *)(*(int64 *)(hero + 64) + 45) = 0;
          lVar4 = il2cpp_internal(DAT_181d6f030);
          FUN_180f58a90(lVar4,DAT_181d678f8);
          fVar20 = -999999.0;
          lVar5 = il2cpp_internal(DAT_181d6f030);
          FUN_180f58a90(lVar5,DAT_181d678f8);
          fVar21 = -999999.0;
          lVar6 = il2cpp_internal(DAT_181d6f030);
          FUN_180f58a90(lVar6,DAT_181d678f8);
          fVar22 = -999999.0;
          lVar7 = il2cpp_internal(DAT_181d6f930);
          FUN_180f58a90(lVar7,DAT_181d6a968);
          lVar8 = il2cpp_internal(DAT_181d6f930);
          FUN_180f58a90(lVar8,DAT_181d6a968);
          lVar9 = il2cpp_internal(DAT_181d721b0);
          FUN_180f58a90(lVar9,DAT_181d79358);
          uVar17 = 0;
          local_res10 = 0;
          uVar14 = uVar17;
          uVar15 = uVar17;
          while (*(int64 *)(hero + 0x2a0) != 0) {
            if (*(int *)(*(int64 *)(hero + 0x2a0) + 24) <= (int)uVar14) {
              local_res20 = 32;
              uVar14 = uVar17;
              goto LAB_1814a25a0;
            }
            cVar2 = HeroData.AttackSkillSlotUnlocked(hero,uVar14,0);
            if (cVar2) {
              local_res10 = (int)uVar15 + 1;
              uVar15 = (uint64)local_res10;
            }
            uVar14 = (uint64)((int)uVar14 + 1);
          }
        }
        LAB_1814a2c82:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_1814a25a0:
        lVar10 = *(int64 *)(hero + 0x260);
        if (lVar10 != null) {
          uVar3 = (uint32)uVar14;
          if ((int)*(uint32 *)(lVar10 + 24) <= (int)uVar3) {
            if ((*(int64 *)(hero + 0x270) == 0) ||
               (fVar18 = (float)AIController.GetSkillScore
                                          (this,hero,*(int64 *)(hero + 0x270),0),
               fVar18 < fVar20)) {
              if (lVar4 == null) goto LAB_1814a2c82;
              if (0 < *(int *)(lVar4 + 24)) {
                HeroData.UnequipSkill(hero,*(uint64 *)(hero + 0x270),0,0);
                lVar9 = *(int64 *)(hero + 0x260);
                uVar1 = *(uint32 *)(lVar4 + 24);
                uVar3 = GlobalData.RandomRange(0,uVar1,0,0);
                if (*(uint32 *)(lVar4 + 24) <= uVar3) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                if (lVar9 == null) goto LAB_1814a2c82;
                uVar3 = lVar4[uVar3];
                if (*(uint32 *)(lVar9 + 24) <= uVar3) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                HeroData.EquipSkill
                          (hero,*(uint64 *)
                                    (*(int64 *)(lVar9 + 16) + 32 + (int64)(int)uVar3 * 8),0,0);
              }
            }
            if ((*(int64 *)(hero + 0x280) == 0) ||
               (fVar20 = (float)AIController.GetSkillScore
                                          (this,hero,*(int64 *)(hero + 0x280),0),
               fVar20 < fVar21)) {
              if (lVar5 == null) goto LAB_1814a2c82;
              if (0 < *(int *)(lVar5 + 24)) {
                HeroData.UnequipSkill(hero,*(uint64 *)(hero + 0x280),0,0);
                lVar4 = *(int64 *)(hero + 0x260);
                uVar1 = *(uint32 *)(lVar5 + 24);
                uVar3 = GlobalData.RandomRange(0,uVar1,0,0);
                if (*(uint32 *)(lVar5 + 24) <= uVar3) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                if (lVar4 == null) goto LAB_1814a2c82;
                uVar3 = lVar5[uVar3];
                if (*(uint32 *)(lVar4 + 24) <= uVar3) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                HeroData.EquipSkill
                          (hero,*(uint64 *)
                                    (*(int64 *)(lVar4 + 16) + 32 + (int64)(int)uVar3 * 8),0,0);
              }
            }
            if ((*(int64 *)(hero + 0x290) == 0) ||
               (fVar20 = (float)AIController.GetSkillScore
                                          (this,hero,*(int64 *)(hero + 0x290),0),
               fVar20 < fVar22)) {
              if (lVar6 == null) goto LAB_1814a2c82;
              if (0 < *(int *)(lVar6 + 24)) {
                HeroData.UnequipSkill(hero,*(uint64 *)(hero + 0x290),0,0);
                lVar4 = *(int64 *)(hero + 0x260);
                uVar1 = *(uint32 *)(lVar6 + 24);
                uVar3 = GlobalData.RandomRange(0,uVar1,0,0);
                if (*(uint32 *)(lVar6 + 24) <= uVar3) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                if (lVar4 == null) goto LAB_1814a2c82;
                uVar3 = lVar6[uVar3];
                if (*(uint32 *)(lVar4 + 24) <= uVar3) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                HeroData.EquipSkill
                          (hero,*(uint64 *)
                                    (*(int64 *)(lVar4 + 16) + 32 + (int64)(int)uVar3 * 8),0,0);
              }
            }
            uVar14 = uVar17;
            if ((int)local_res10 < 1) goto LAB_1814a2b00;
            lVar4 = 32;
            uVar15 = uVar17;
            uVar16 = uVar17;
            goto LAB_1814a2ab0;
          }
          if (*(uint32 *)(lVar10 + 24) <= uVar3) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          fVar18 = (float)AIController.GetSkillScore
                                    (this,hero,
                                     *(uint64 *)(local_res20 + *(int64 *)(lVar10 + 16)));
          lVar10 = *(int64 *)(hero + 0x260);
          if (lVar10 == null) goto LAB_1814a2c82;
          if (*(uint32 *)(lVar10 + 24) <= uVar3) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar10 = *(int64 *)(local_res20 + *(int64 *)(lVar10 + 16));
          if ((lVar10 == null) || (lVar10 = KungfuSkillLvData.DataBase(lVar10,0)) == null)
          goto LAB_1814a2c82;
          iVar12 = *(int *)(lVar10 + 48);
          if (iVar12 == 0) {
            lVar10 = lVar4;
            if (fVar20 < fVar18) {
              if (lVar4 == null) goto LAB_1814a2c82;
              FUN_180f56130(lVar4,DAT_181d67b78);
              fVar20 = fVar18;
            }
            else {
              if (fVar18 != fVar20) goto LAB_1814a2810;
        joined_r0x0001814a27dc:
              if (lVar10 == null) goto LAB_1814a2c82;
            }
        LAB_1814a2802:
            FUN_181814fa0(lVar10,uVar14,DAT_181d67a78);
            goto LAB_1814a2810;
          }
          if (iVar12 == 1) {
            lVar10 = lVar5;
            fVar19 = fVar18;
            fVar23 = fVar22;
            if (fVar18 <= fVar21) {
              if (fVar18 == fVar21) goto joined_r0x0001814a27dc;
              goto LAB_1814a2810;
            }
        LAB_1814a2784:
            if (lVar10 != null) {
              FUN_180f56130(lVar10,DAT_181d67b78);
              fVar21 = fVar19;
              fVar22 = fVar23;
              goto LAB_1814a2802;
            }
            goto LAB_1814a2c82;
          }
          if (iVar12 == 2) {
            lVar10 = lVar6;
            fVar19 = fVar21;
            fVar23 = fVar18;
            if (fVar22 < fVar18) goto LAB_1814a2784;
            if (fVar18 != fVar22) goto LAB_1814a2810;
            if (lVar6 != null) goto LAB_1814a2802;
            goto LAB_1814a2c82;
          }
          if (lVar9 == null) goto LAB_1814a2c82;
          iVar12 = *(int *)(lVar9 + 24);
          uVar15 = uVar17;
          if (iVar12 != 0) goto LAB_1814a2665;
        LAB_1814a26f2:
          if ((*(int64 *)(hero + 0x260) == 0) ||
             (uVar11 = FUN_180002f80(*(int64 *)(hero + 0x260),uVar14,DAT_181d6ade8), lVar7 == null))
          goto LAB_1814a2c82;
          FUN_181827900(lVar7,uVar11,DAT_181d6a9e8);
          FUN_181805690(lVar9,fVar18,DAT_181d79458);
          uVar14 = (uint64)(uVar3 + 1);
          local_res20 = local_res20 + 8;
          goto LAB_1814a25a0;
        }
        goto LAB_1814a2c82;
        while( true ) {
          if (*(uint32 *)(lVar7 + 24) <= uVar3) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (lVar8 == null) goto LAB_1814a2c82;
          FUN_181827900(lVar8,*(uint64 *)(*(int64 *)(lVar7 + 16) + lVar4),DAT_181d6a9e8);
          uVar15 = (uint64)(uVar3 + 1);
          uVar16 = uVar16 + 1;
          lVar4 = lVar4 + 8;
          if ((int64)(int)local_res10 <= (int64)uVar16) break;
        LAB_1814a2ab0:
          if (lVar7 == null) goto LAB_1814a2c82;
          uVar3 = (uint32)uVar15;
          if ((int)*(uint32 *)(lVar7 + 24) <= (int)uVar3) break;
        }
        LAB_1814a2b00:
        do {
          if (*(int64 *)(hero + 0x2a0) == 0) goto LAB_1814a2c82;
          if (*(int *)(*(int64 *)(hero + 0x2a0) + 24) <= (int)uVar14) {
            if (lVar8 != null) {
              lVar4 = 32;
              while( true ) {
                uVar3 = (uint32)uVar17;
                if ((int)*(uint32 *)(lVar8 + 24) <= (int)uVar3) {
                  return;
                }
                if (*(uint32 *)(lVar8 + 24) <= uVar3) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar5 = *(int64 *)(lVar4 + *(int64 *)(lVar8 + 16));
                if (lVar5 == null) break;
                if (*(char *)(lVar5 + 32) == false) {
                  uVar11 = FUN_180002f80(lVar8,uVar17,DAT_181d6ade8);
                  HeroData.EquipSkill(hero,uVar11,0,0);
                }
                uVar17 = (uint64)(uVar3 + 1);
                lVar4 = lVar4 + 8;
              }
            }
            goto LAB_1814a2c82;
          }
          cVar2 = HeroData.AttackSkillSlotUnlocked(hero,uVar14,0);
          if (cVar2) {
            if (*(int64 *)(hero + 0x2a0) == 0) goto LAB_1814a2c82;
            lVar4 = FUN_180002f80(*(int64 *)(hero + 0x2a0),uVar14);
            if (lVar4 != null) {
              if ((*(int64 *)(hero + 0x2a0) == 0) ||
                 (uVar11 = FUN_180002f80(*(int64 *)(hero + 0x2a0),uVar14,DAT_181d6ade8), lVar8 == null)
                 ) goto LAB_1814a2c82;
              cVar2 = FUN_1818279a0(lVar8,uVar11);
              if (!cVar2) {
                if (*(int64 *)(hero + 0x2a0) == 0) goto LAB_1814a2c82;
                uVar11 = FUN_180002f80(*(int64 *)(hero + 0x2a0),uVar14);
                HeroData.UnequipSkill(hero,uVar11);
              }
            }
          }
          uVar14 = (uint64)((int)uVar14 + 1);
        } while( true );
        LAB_1814a2665:
        while (iVar13 = (int)uVar15, iVar13 < iVar12) {
          fVar19 = (float)FUN_1800d6780(lVar9,uVar15,DAT_181d796d8);
          if (fVar19 <= fVar18) {
            if ((*(int64 *)(hero + 0x260) == 0) ||
               (uVar11 = FUN_180002f80(*(int64 *)(hero + 0x260),uVar14,DAT_181d6ade8), lVar7 == null))
            goto LAB_1814a2c82;
            FUN_18182ac70(lVar7,uVar15,uVar11,DAT_181d6abe8);
            FUN_18180a790(lVar9,uVar15,fVar18);
            uVar14 = (uint64)(uVar3 + 1);
            local_res20 = local_res20 + 8;
            goto LAB_1814a25a0;
          }
          iVar12 = *(int *)(lVar9 + 24);
          if (iVar13 == iVar12 + -1) goto LAB_1814a26f2;
          uVar15 = (uint64)(iVar13 + 1);
        }
        LAB_1814a2810:
        uVar14 = (uint64)(uVar3 + 1);
        local_res20 = local_res20 + 8;
        goto LAB_1814a25a0;
    }

    // Token : 0x60009C9
    // RVA   : 0x14AC220   Offset: 0x14AAA20   Length: 0x776
    public void ManageAIOneDay(HeroData hero)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar2;
        bool cVar3;
        uint uVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        float fVar8;
        double dVar9;
        float fVar10;
        if (hero == null) {
          return;
        }
        if (*(char *)(hero + 0x2f0) == false) {
          if (*(int *)(hero + 132) < 0) {
        LAB_1814ac2ed:
            if (*(int64 *)(hero + 64) == 0) throw; // [null/range check failed]
            *(uint32 *)(*(int64 *)(hero + 64) + 40) = 0;
          }
          else {
            iVar2 = *(int *)(hero + 192);
            lVar5 = HeroData.GetForce(hero,0,0);
            if (lVar5 == null) throw; // [null/range check failed]
            if (iVar2 == *(int *)(lVar5 + 56)) goto LAB_1814ac2ed;
            lVar5 = *(int64 *)(hero + 64);
            if (lVar5 == null) throw; // [null/range check failed]
            *(float *)(lVar5 + 40) = *(float *)(lVar5 + 40) + 1.0;
          }
          lVar5 = *(int64 *)(hero + 64);
          if (lVar5 == null) throw; // [null/range check failed]
          iVar2 = *(int *)(lVar5 + 16);
          if ((iVar2 != 1) && (*(char *)(hero + 96) == false)) {
            if (*(char *)(hero + 209) == false) {
              fVar10 = 0.0;
              if (iVar2 == 3) {
                *(uint8 *)(hero + 0x1e8) = 1;
                cVar3 = HeroData.FullState(hero,0);
                if (cVar3) {
        LAB_1814ac377:
                  if (*(int64 *)(hero + 64) == 0) throw; // [null/range check failed]
                  *(uint32 *)(*(int64 *)(hero + 64) + 32) = 0;
                }
              }
              else if ((((iVar2 == 4) &&
                        (HeroData.AutoCureSelfInjury(hero,0), *(float *)(hero + 0x1a8) <= 0.0)) &&
                       (*(float *)(hero + 0x1a4) <= 0.0)) && (*(float *)(hero + 0x1a0) <= 0.0))
              goto LAB_1814ac377;
              if (*(int *)(hero + 192) < 0) {
                if (*(int64 *)(hero + 64) == 0) throw; // [null/range check failed]
                piVar1 = (int *)(*(int64 *)(hero + 64) + 32);
                *piVar1 = *piVar1 + -1;
                if (*(int64 *)(hero + 64) == 0) throw; // [null/range check failed]
                piVar1 = (int *)(*(int64 *)(hero + 64) + 36);
                *piVar1 = *piVar1 + 1;
                AIController.CheckInteractTarget(this,hero,0);
                lVar5 = *(int64 *)(hero + 64);
                if (lVar5 == null) throw; // [null/range check failed]
                if (*(int *)(lVar5 + 32) < 1) {
                  if (-1 < *(int *)(lVar5 + 48)) {
                    uVar7 = Int32.ToString(lVar5 + 48,0);
                    uVar6 = new HeroAIData(1,uVar7,99,0);
                    goto LAB_1814ac7e5;
                  }
                  uVar6 = new HeroAIData(1,"-1",99,0);
                  goto LAB_1814ac794;
                }
              }
              else {
                cVar3 = AIController.CheckHeroNeedMove(this,hero,0);
                if (!cVar3) {
                  if (*(int64 *)(hero + 64) == 0) throw; // [null/range check failed]
                  piVar1 = (int *)(*(int64 *)(hero + 64) + 32);
                  *piVar1 = *piVar1 + -1;
                  if (*(int64 *)(hero + 64) == 0) throw; // [null/range check failed]
                  piVar1 = (int *)(*(int64 *)(hero + 64) + 36);
                  *piVar1 = *piVar1 + 1;
                  AIController.CheckInteractTarget(this,hero,0);
                  cVar3 = HeroData.StuffStoppable(hero,0);
                  if ((!cVar3) ||
                     (fVar8 = (float)HeroData.GetTotalInjury(hero,0), fVar8 <= 50.0)) {
                    cVar3 = HeroData.StuffStoppable(hero,0);
                    if ((!cVar3) ||
                       ((fVar8 = (float)HeroData.GetHpPercent(hero,0), 0.5 <= fVar8 &&
                        (fVar8 = (float)HeroData.GetManaPercent(hero,0), 0.5 <= fVar8)))) {
                      cVar3 = HeroData.StuffStoppable(hero,0);
                      if (cVar3) {
                        lVar5 = *(int64 *)(hero + 0x220);
                        if (lVar5 == null) throw; // [null/range check failed]
                        if (*(float *)(lVar5 + 32) <= *(float *)(lVar5 + 28) &&
                            *(float *)(lVar5 + 28) != *(float *)(lVar5 + 32)) {
                          uVar6 = new HeroAIData(9,1);
                          goto LAB_1814ac7e5;
                        }
                      }
                      if (*(int64 *)(hero + 64) == 0) throw; // [null/range check failed]
                      if ((*(int *)(*(int64 *)(hero + 64) + 32) < 1) &&
                         (cVar3 = AIController.FinishAIStuff(this,hero,0), !cVar3)) {
                        if (*(int *)(hero + 132) < 0) {
        LAB_1814ac617:
                          cVar3 = AIController.CanLeaveArea(this,0);
                          if (cVar3) {
                            dVar9 = (double)GlobalData.RandomRangeDouble(0,0);
                            if (dVar9 <= 0.05000000074505806) {
                              if (-1 < *(int *)(hero + 132)) {
                                iVar2 = *(int *)(hero + 192);
                                lVar5 = HeroData.GetForce(hero,0,0);
                                if (lVar5 == null) throw; // [null/range check failed]
                                if (iVar2 != *(int *)(lVar5 + 56)) {
                                  dVar9 = (double)GlobalData.RandomRangeDouble(0,0);
                                  if (dVar9 < 0.20000000298023224) goto LAB_1814ac5ea;
                                }
                              }
                              uVar4 = AIController.GetRandomMoveTargetArea(this,hero,0);
                              AIController.StartMoveToAnotherArea(this,hero,uVar4,0);
                              goto LAB_1814ac83f;
                            }
                          }
                          AIController.ManageAIUsePoison(this,hero,0);
                          AIController.ManageAIStuff(this,hero,0);
                          AIController.CheckHeroNeedMove(this,hero,0);
                        }
                        else {
                          iVar2 = *(int *)(hero + 192);
                          lVar5 = HeroData.GetForce(hero,0,0);
                          if (lVar5 == null) throw; // [null/range check failed]
                          if (iVar2 == *(int *)(lVar5 + 56)) goto LAB_1814ac617;
                          dVar9 = (double)GlobalData.RandomRangeDouble(0,0);
                          if (*(char *)(hero + 180) != false) {
                            fVar10 = 0.005;
                          }
                          if (*(int64 *)(hero + 64) == 0) throw; // [null/range check failed]
                          if ((double)(((float)*(int *)(hero + 184) * 0.001 + 0.02 + fVar10) *
                                      *(float *)(*(int64 *)(hero + 64) + 40)) < dVar9)
                          goto LAB_1814ac617;
        LAB_1814ac5ea:
                          lVar5 = HeroData.GetForce(hero,0,0);
                          if (lVar5 == null) throw; // [null/range check failed]
                          AIController.StartMoveToAnotherArea
                                    (this,hero,*(uint32 *)(lVar5 + 56),0);
                        }
                      }
                    }
                    else {
                      uVar4 = HeroData.GetFullRecoverTime(hero);
                      uVar6 = new HeroAIData(3,uVar4);
        LAB_1814ac7e5:
                      AIController.SetAIStuff(this,hero,uVar6,0,0);
                    }
                  }
                  else {
                    uVar6 = new HeroAIData(4,99);
        LAB_1814ac794:
                    AIController.SetAIStuff(this,hero,uVar6,0,0);
                  }
                }
              }
            }
            else {
              if (iVar2 != 16) {
                uVar6 = new HeroAIData(16,99);
                HeroData.SetHeroAIData(hero,uVar6,0);
                lVar5 = *(int64 *)(hero + 64);
              }
              if (lVar5 == null) throw; // [null/range check failed]
              *(int *)(lVar5 + 36) = *(int *)(lVar5 + 36) + 1;
            }
          }
        LAB_1814ac83f:
          lVar5 = *(int64 *)(hero + 64);
          if (lVar5 == null) throw; // [null/range check failed]
          if (*(char *)(lVar5 + 46) != false) {
            AIController.AICheckSpeMed(this,hero,0);
            lVar5 = *(int64 *)(hero + 64);
          }
          if (lVar5 == null) throw; // [null/range check failed]
          if ((*(char *)(lVar5 + 44) != false) &&
             ((cVar3 = HeroData.ItemLockable(hero,0), !cVar3 ||
              (*(char *)(hero + 0x372) == false)))) {
            AIController.AICheckEquipment(this,hero,0);
          }
          if (*(int64 *)(hero + 64) == 0) throw; // [null/range check failed]
          if ((*(char *)(*(int64 *)(hero + 64) + 45) != false) &&
             ((cVar3 = HeroData.ItemLockable(hero,0), !cVar3 ||
              (*(char *)(hero + 0x373) == false)))) {
            AIController.AICheckSkill(this,hero,0);
          }
        }
        else if (0 < *(int *)(hero + 0x300)) {
          *(int *)(hero + 0x300) = *(int *)(hero + 0x300) + -1;
        }
        if (*pStatics != 0) {
          GameController.ManageHeroAutoRecoverAndInjury
                    (*pStatics,hero,0,0);
          return;
        }
    }

    // Token : 0x60009CA
    // RVA   : 0x14A41F0   Offset: 0x14A29F0   Length: 0x1FF
    public void CheckInteractTarget(HeroData hero)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        bool cVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        lVar3 = *(int64 *)(*(int64 *)(DAT_181d84cc0 + 184) + 8);
        if (((hero != null) && (*(int64 *)(hero + 64) != 0)) && (lVar3 != null)) {
          cVar1 = FUN_181815240(lVar3,*(uint32 *)(*(int64 *)(hero + 64) + 16),DAT_181d53900)
          ;
          if (!cVar1) {
            return;
          }
          if (*pStatics != 0) {
            lVar3 = *(int64 *)(*pStatics + 32);
            if ((*(int64 *)(hero + 64) != 0) &&
               (uVar2 = Int32.Parse(*(uint64 *)(*(int64 *)(hero + 64) + 24),0), lVar3 != null)
               ) {
              lVar3 = WorldData.GetHero(lVar3,uVar2,0);
              if (lVar3 == null) {
        LAB_1814a43d0:
                HeroData.ResetAI(hero,0);
                return;
              }
              if ((*(int64 *)(lVar3 + 64) != 0) && (*(int64 *)(hero + 64) != 0)) {
                if (*(int *)(*(int64 *)(lVar3 + 64) + 16) !=
                    *(int *)(*(int64 *)(hero + 64) + 16)) goto LAB_1814a43d0;
                lVar4 = FUN_18046c0a0(0);
                if (lVar4 != null) {
                  lVar4 = *(int64 *)(lVar4 + 32);
                  if ((*(int64 *)(lVar3 + 64) != 0) &&
                     (uVar2 = Int32.Parse(*(uint64 *)(*(int64 *)(lVar3 + 64) + 24),0),
                     lVar4 != null)) {
                    lVar3 = WorldData.GetHero(lVar4,uVar2,0);
                    if (lVar3 == hero) {
                      return;
                    }
                    goto LAB_1814a43d0;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60009CB
    // RVA   : 0x14AAEF0   Offset: 0x14A96F0   Length: 0x59F
    public int GetRandomMoveTargetArea(HeroData hero)
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        bool cVar1;
        uint uVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        long lVar6;
        int iVar7;
        if (*(int *)(pStatics_ef00 + 8) == 1) {
          lVar4 = il2cpp_internal(DAT_181d6f030);
          FUN_180f58a90(lVar4,DAT_181d678f8);
          iVar7 = 0;
          while( true ) {
            if ((((*pStatics_df90 == 0) || (hero == null)) ||
                (lVar5 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
               ((lVar5 = WorldData.GetArea(lVar5,*(uint32 *)(hero + 192),0), lVar5 == null ||
                (*(int64 *)(lVar5 + 160) == 0)))) throw; // [null/range check failed]
            if (*(int *)(*(int64 *)(lVar5 + 160) + 24) <= iVar7) break;
            lVar5 = *(int64 *)(pStatics_ef00 + 24);
            if ((((*pStatics_df90 == 0) ||
                 (lVar6 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
                (lVar6 = WorldData.GetArea(lVar6,*(uint32 *)(hero + 192),0)) == null) ||
               ((*(int64 *)(lVar6 + 160) == 0 ||
                (uVar3 = FUN_1800d6750(*(int64 *)(lVar6 + 160),iVar7,DAT_181d68270), lVar5 == null))))
            throw; // [null/range check failed]
            cVar1 = FUN_181815240(lVar5,uVar3);
            if (cVar1) {
              lVar5 = FUN_18046c0a0(0);
              if ((((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                  (lVar5 = WorldData.GetArea(*(int64 *)(lVar5 + 32),*(uint32 *)(hero + 192),
                                              0), lVar5 == null)) ||
                 ((*(int64 *)(lVar5 + 160) == 0 ||
                  (uVar3 = FUN_1800d6750(*(int64 *)(lVar5 + 160),iVar7,DAT_181d68270), lVar4 == null))))
              throw; // [null/range check failed]
              FUN_181814fa0(lVar4,uVar3);
            }
            iVar7 = iVar7 + 1;
          }
          if (lVar4 != null) {
            iVar7 = *(int *)(lVar4 + 24);
            if (0 < iVar7) {
              uVar2 = GlobalData.RandomRange(0,iVar7,0,0);
              if (*(uint32 *)(lVar4 + 24) <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              return lVar4[uVar2];
            }
            lVar4 = *(int64 *)(pStatics_ef00 + 24);
            if (lVar4 != null) {
              uVar2 = GlobalData.RandomRange(0,*(uint32 *)(lVar4 + 24),0,0);
              goto LAB_1814ab41b;
            }
          }
        }
        else {
          if ((((*pStatics_df90 != 0) && (hero != null)) &&
              (lVar4 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
             (lVar4 = WorldData.GetArea(lVar4,*(uint32 *)(hero + 192),0)) != null) {
            lVar4 = *(int64 *)(lVar4 + 160);
            if (((*pStatics_df90 != 0) &&
                (lVar5 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
               ((lVar5 = WorldData.GetArea(lVar5,*(uint32 *)(hero + 192),0), lVar5 != null &&
                (*(int64 *)(lVar5 + 160) != 0)))) {
              uVar3 = *(uint32 *)(*(int64 *)(lVar5 + 160) + 24);
              uVar2 = GlobalData.RandomRange(0,uVar3,0,0);
              if (lVar4 != null) {
        LAB_1814ab41b:
                if (*(uint32 *)(lVar4 + 24) <= uVar2) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                return lVar4[uVar2];
              }
            }
          }
        }
    }

    // Token : 0x60009CC
    // RVA   : 0x14A3DC0   Offset: 0x14A25C0   Length: 0x157
    public bool CanLeaveArea()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        if (((*pStatics != 0) &&
            (lVar1 = *(int64 *)(*pStatics + 32)) != null) &&
           (lVar1 = *(int64 *)(lVar1 + 168)) != null) {
          if (*(int *)(lVar1 + 16) != 1) {
            return CONCAT71((int7)((uint64)lVar1 >> 8),1);
          }
          if (((*pStatics != 0) &&
              (lVar1 = *(int64 *)(*pStatics + 32)) != null) &&
             (*(int64 *)(lVar1 + 168) != 0)) {
            return CONCAT71((int7)((uint64)lVar1 >> 8),
                            *(int *)(*(int64 *)(lVar1 + 168) + 20) != 1);
          }
        }
    }

    // Token : 0x60009CD
    // RVA   : 0x14B0460   Offset: 0x14AEC60   Length: 0x908
    public void ManageAIUsePoison(HeroData hero)
    {
        bool cVar2;
        int iVar3;
        uint uVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        long lVar8;
        uint uVar9;
        uint uVar10;
        long lVar11;
        uint uVar12;
        float fVar13;
        double dVar14;
        dVar14 = (double)GlobalData.RandomRangeDouble(0,0);
        if (hero != null) {
          fVar13 = (float)HeroData.UsePoisonRate(hero,0);
          if ((double)fVar13 <= dVar14) {
            return;
          }
          lVar5 = il2cpp_internal(DAT_181d6f430);
          FUN_180f58a90(lVar5,DAT_181d691f0);
          uVar10 = 0;
          lVar11 = 32;
          lVar8 = 32;
          uVar9 = uVar10;
          uVar12 = uVar10;
          while ((*(int64 *)(hero + 0x1f8) != 0 &&
                 (lVar6 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 32)) != null)) {
            if ((int)*(uint32 *)(lVar6 + 24) <= (int)uVar9) {
              lVar8 = 32;
              uVar9 = uVar10;
              goto LAB_1814b06b0;
            }
            if (*(uint32 *)(lVar6 + 24) <= uVar9) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(int64 *)(*(int64 *)(lVar6 + 16) + lVar8) == 0) {
        LAB_1814b068f:
              uVar9 = uVar9 + 1;
              lVar8 = lVar8 + 8;
            }
            else {
              if ((((*(int64 *)(hero + 0x1f8) == 0) ||
                   (lVar6 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 32)) == null) ||
                  (lVar6 = FUN_180002f80(lVar6,uVar9)) == null) ||
                 ((*(int64 *)(lVar6 + 96) == 0 ||
                  (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 96) + 64)) == null))) break;
              if (0.0 < *(float *)(lVar6 + 16)) {
                uVar12 = uVar12 + 1;
                goto LAB_1814b068f;
              }
              if (((*(int64 *)(hero + 0x1f8) == 0) ||
                  (lVar6 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 32)) == null) ||
                 (uVar7 = FUN_180002f80(lVar6,uVar9,DAT_181d69770), lVar5 == null)) break;
              FUN_181827900(lVar5,uVar7);
              uVar9 = uVar9 + 1;
              lVar8 = lVar8 + 8;
            }
          }
        }
        LAB_1814b0d63:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_1814b06b0:
        if ((*(int64 *)(hero + 0x1f8) == 0) ||
           (lVar6 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 56)) == null) goto LAB_1814b0d63;
        if ((int)*(uint32 *)(lVar6 + 24) <= (int)uVar9) {
          lVar8 = 32;
          uVar9 = uVar10;
          goto LAB_1814b07c0;
        }
        if (*(uint32 *)(lVar6 + 24) <= uVar9) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (*(int64 *)(*(int64 *)(lVar6 + 16) + lVar8) == 0) {
        LAB_1814b079f:
          uVar9 = uVar9 + 1;
          lVar8 = lVar8 + 8;
        }
        else {
          if ((((*(int64 *)(hero + 0x1f8) == 0) ||
               (lVar6 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 56)) == null) ||
              (lVar6 = FUN_180002f80(lVar6,uVar9)) == null) ||
             ((*(int64 *)(lVar6 + 96) == 0 ||
              (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 96) + 64)) == null)))
          goto LAB_1814b0d63;
          if (0.0 < *(float *)(lVar6 + 16)) {
            uVar12 = uVar12 + 1;
            goto LAB_1814b079f;
          }
          if (((*(int64 *)(hero + 0x1f8) == 0) ||
              (lVar6 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 56)) == null) ||
             (uVar7 = FUN_180002f80(lVar6,uVar9,DAT_181d69770), lVar5 == null)) goto LAB_1814b0d63;
          FUN_181827900(lVar5,uVar7);
          uVar9 = uVar9 + 1;
          lVar8 = lVar8 + 8;
        }
        goto LAB_1814b06b0;
        LAB_1814b07c0:
        if ((*(int64 *)(hero + 0x1f8) == 0) ||
           (lVar6 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 80)) == null) goto LAB_1814b0d63;
        if ((int)*(uint32 *)(lVar6 + 24) <= (int)uVar9) {
          lVar8 = 32;
          uVar9 = uVar10;
          goto LAB_1814b08d0;
        }
        if (*(uint32 *)(lVar6 + 24) <= uVar9) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (*(int64 *)(*(int64 *)(lVar6 + 16) + lVar8) == 0) {
        LAB_1814b08af:
          uVar9 = uVar9 + 1;
          lVar8 = lVar8 + 8;
        }
        else {
          if ((((*(int64 *)(hero + 0x1f8) == 0) ||
               (lVar6 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 80)) == null) ||
              (lVar6 = FUN_180002f80(lVar6,uVar9)) == null) ||
             ((*(int64 *)(lVar6 + 96) == 0 ||
              (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 96) + 64)) == null)))
          goto LAB_1814b0d63;
          if (0.0 < *(float *)(lVar6 + 16)) {
            uVar12 = uVar12 + 1;
            goto LAB_1814b08af;
          }
          if (((*(int64 *)(hero + 0x1f8) == 0) ||
              (lVar6 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 80)) == null) ||
             (uVar7 = FUN_180002f80(lVar6,uVar9,DAT_181d69770), lVar5 == null)) goto LAB_1814b0d63;
          FUN_181827900(lVar5,uVar7);
          uVar9 = uVar9 + 1;
          lVar8 = lVar8 + 8;
        }
        goto LAB_1814b07c0;
        LAB_1814b08d0:
        if ((*(int64 *)(hero + 0x1f8) == 0) ||
           (lVar6 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 104)) == null) goto LAB_1814b0d63;
        if ((int)*(uint32 *)(lVar6 + 24) <= (int)uVar9) goto LAB_1814b09e0;
        if (*(uint32 *)(lVar6 + 24) <= uVar9) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (*(int64 *)(*(int64 *)(lVar6 + 16) + lVar8) == 0) {
        LAB_1814b09bf:
          uVar9 = uVar9 + 1;
          lVar8 = lVar8 + 8;
        }
        else {
          if ((((*(int64 *)(hero + 0x1f8) == 0) ||
               (lVar6 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 104)) == null) ||
              (lVar6 = FUN_180002f80(lVar6,uVar9)) == null) ||
             ((*(int64 *)(lVar6 + 96) == 0 ||
              (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 96) + 64)) == null)))
          goto LAB_1814b0d63;
          if (0.0 < *(float *)(lVar6 + 16)) {
            uVar12 = uVar12 + 1;
            goto LAB_1814b09bf;
          }
          if (((*(int64 *)(hero + 0x1f8) == 0) ||
              (lVar6 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 104)) == null) ||
             (uVar7 = FUN_180002f80(lVar6,uVar9,DAT_181d69770), lVar5 == null)) goto LAB_1814b0d63;
          FUN_181827900(lVar5,uVar7);
          uVar9 = uVar9 + 1;
          lVar8 = lVar8 + 8;
        }
        goto LAB_1814b08d0;
        LAB_1814b09e0:
        if ((*(int64 *)(hero + 0x1f8) == 0) ||
           (lVar8 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 128)) == null) goto LAB_1814b0d63;
        if ((int)*(uint32 *)(lVar8 + 24) <= (int)uVar10) {
          if ((int)uVar12 <= *(int *)(hero + 184)) {
            if (lVar5 == null) goto LAB_1814b0d63;
            iVar3 = *(int *)(lVar5 + 24);
            if (0 < iVar3) {
              uVar9 = GlobalData.RandomRange(0,iVar3,0,0);
              if (*(uint32 *)(lVar5 + 24) <= uVar9) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar5 = lVar5[uVar9];
              goto LAB_1814b0b4c;
            }
          }
          lVar5 = *(int64 *)(*(int64 *)(DAT_181d84cc0 + 184) + 48);
          if (lVar5 == null) goto LAB_1814b0d63;
          uVar4 = *(uint32 *)(lVar5 + 24);
          uVar9 = GlobalData.RandomRange(0,uVar4,0,0);
          if (*(uint32 *)(lVar5 + 24) <= uVar9) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (*(int64 *)(hero + 0x220) == 0) goto LAB_1814b0d63;
          lVar8 = *(int64 *)(*(int64 *)(hero + 0x220) + 48);
          uVar9 = lVar5[uVar9];
          lVar5 = (int64)(int)uVar9;
          if (lVar8 == null) goto LAB_1814b0d63;
          if (*(uint32 *)(lVar8 + 24) <= uVar9) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar8 = *(int64 *)(*(int64 *)(lVar8 + 16) + 32 + lVar5 * 8);
          if (lVar8 == null) goto LAB_1814b0d63;
          if (*(int *)(lVar8 + 24) < 1) {
            return;
          }
          lVar8 = *(int64 *)(hero + 0x220);
          if ((lVar8 == null) || (lVar11 = *(int64 *)(lVar8 + 48)) == null) goto LAB_1814b0d63;
          if (*(uint32 *)(lVar11 + 24) <= uVar9) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
            lVar8 = *(int64 *)(hero + 0x220);
          }
          lVar11 = *(int64 *)(*(int64 *)(lVar11 + 16) + 32 + lVar5 * 8);
          if ((lVar8 == null) || (lVar8 = *(int64 *)(lVar8 + 48)) == null) goto LAB_1814b0d63;
          if (*(uint32 *)(lVar8 + 24) <= uVar9) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar5 = *(int64 *)(*(int64 *)(lVar8 + 16) + 32 + lVar5 * 8);
          if (lVar5 == null) goto LAB_1814b0d63;
          uVar4 = *(uint32 *)(lVar5 + 24);
          uVar9 = GlobalData.RandomRange(0,uVar4,0,0);
          if (lVar11 == null) goto LAB_1814b0d63;
          if (*(uint32 *)(lVar11 + 24) <= uVar9) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar5 = lVar11[uVar9];
          if (lVar5 == null) goto LAB_1814b0d63;
          if (*(int *)(lVar5 + 20) == 0) {
            lVar8 = *(int64 *)(lVar5 + 96);
            if ((lVar8 == null) || (*(int64 *)(lVar8 + 64) == 0)) goto LAB_1814b0d63;
            pfVar1 = (float *)(*(int64 *)(lVar8 + 64) + 16);
            if (*pfVar1 <= 0.0 && *pfVar1 != 0.0) {
        LAB_1814b0b4c:
              HeroData.ManagePoisonEquipment(hero,lVar5,0);
              return;
            }
            cVar2 = *(char *)(lVar8 + 48);
          }
          else {
            if (*(int *)(lVar5 + 20) == 6)
            {
              if (*(int64 *)(lVar5 + 136) == 0) goto LAB_1814b0d63;
              cVar2 = *(char *)(*(int64 *)(lVar5 + 136) + 16);
              }
              if (cVar2) {
              return;
              }
            }
          HeroData.ManagePoisonItem(hero,lVar5,0);
          return;
        }
        if (*(uint32 *)(lVar8 + 24) <= uVar10) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (*(int64 *)(lVar11 + *(int64 *)(lVar8 + 16)) == 0) {
        LAB_1814b0ad8:
          uVar10 = uVar10 + 1;
          lVar11 = lVar11 + 8;
        }
        else {
          if ((((*(int64 *)(hero + 0x1f8) == 0) ||
               (lVar8 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 128)) == null) ||
              (lVar8 = FUN_180002f80(lVar8,uVar10)) == null) ||
             ((*(int64 *)(lVar8 + 96) == 0 ||
              (lVar8 = *(int64 *)(*(int64 *)(lVar8 + 96) + 64)) == null)))
          goto LAB_1814b0d63;
          if (0.0 < *(float *)(lVar8 + 16)) {
            uVar12 = uVar12 + 1;
            goto LAB_1814b0ad8;
          }
          if (((*(int64 *)(hero + 0x1f8) == 0) ||
              (lVar8 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 128)) == null) ||
             (uVar7 = FUN_180002f80(lVar8,uVar10,DAT_181d69770), lVar5 == null)) goto LAB_1814b0d63;
          FUN_181827900(lVar5,uVar7);
          uVar10 = uVar10 + 1;
          lVar11 = lVar11 + 8;
        }
        goto LAB_1814b09e0;
    }

    // Token : 0x60009CE
    // RVA   : 0x14A4100   Offset: 0x14A2900   Length: 0xE3
    public bool CheckHeroNeedMove(HeroData hero)
    {
        long lVar1;
        if ((hero != null) && (lVar1 = *(int64 *)(hero + 64)) != null) {
          if ((*(int *)(lVar1 + 48) < 0) || (*(int *)(lVar1 + 48) == *(int *)(hero + 192))) {
            return false;
          }
          plVar2 = (int64 *)0;
          if (*(int *)(lVar1 + 16) != 1) {
            plVar2 = (int64 *)HeroAIData.Clone();
          }
          *(int64 **)(hero + 72) = plVar2;
          if (*(int64 *)(hero + 64) != 0) {
            AIController.StartMoveToAnotherArea
                      (this,hero,*(uint32 *)(*(int64 *)(hero + 64) + 48),0);
            return true;
          }
        }
    }

    // Token : 0x60009CF
    // RVA   : 0x14AAD40   Offset: 0x14A9540   Length: 0x143
    public bool ForceHaveResourceRateLessThan(HeroData hero, float rate)
    {
        uint64 AIController.ForceHaveResourceRateLessThan
                          (uint64 this,int64 hero,float rate)
        {
        float fVar1;
        uint64 in_RAX;
        int64 lVar2;
        uint32 uVar3;
        int64 lVar4;
        if (hero != null) {
          if (*(int *)(hero + 132) < 0) {
        LAB_1814aae7a:
            return in_RAX & 0xffffffffffffff00;
          }
          uVar3 = 0;
          lVar4 = 32;
          while ((lVar2 = HeroData.GetForce(hero,0,0), lVar2 != null &&
                 (in_RAX = *(uint64 *)(lVar2 + 136)) != null)) {
            if (*(int *)(in_RAX + 24) <= (int)uVar3) goto LAB_1814aae7a;
            lVar2 = HeroData.GetForce(hero,0,0);
            if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 136)) == null) break;
            if (*(uint32 *)(lVar2 + 24) <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            fVar1 = *(float *)(lVar4 + *(int64 *)(lVar2 + 16));
            lVar2 = HeroData.GetForce(hero,0,0);
            if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 144)) == null) break;
            if (*(uint32 *)(lVar2 + 24) <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (fVar1 / *(float *)(*(int64 *)(lVar2 + 16) + lVar4) <= rate) {
              return CONCAT71((int7)((uint64)*(int64 *)(lVar2 + 16) >> 8),1);
            }
            uVar3 = uVar3 + 1;
            lVar4 = lVar4 + 4;
          }
        }
    }

    // Token : 0x60009D0
    // RVA   : 0x14AC9A0   Offset: 0x14AB1A0   Length: 0x14E8
    public void ManageAIStuff(HeroData hero)
    {
        var plVar13 = *(int64*)(lVar13 + 184);
        var pStatics = *(int64*)(DAT_181d9b970 + 184);
        byte[] auVar1 = new byte[12];
        byte[] auVar2 = new byte[12];
        bool cVar3;
        int iVar4;
        int iVar5;
        uint uVar6;
        uint uVar7;
        ulong uVar8;
        long lVar9;
        long lVar10;
        long lVar11;
        long lVar12;
        long lVar13;
        long lVar14;
        ulong uVar17;
        uint uVar18;
        uint uVar19;
        int iVar20;
        ulong uVar21;
        uint uVar22;
        float fVar24;
        double dVar25;
        float fVar26;
        float fVar27;
        byte[] auVar28 = new byte[12];
        uint[] local_res10 = new uint[2];
        int[] local_res20 = new int[2];
        int[] local_108 = new int[2];
        long local_100;
        long local_f8;
        long local_f0;
        long local_e8;
        uVar19 = 0;
        iVar5 = 0;
        local_res10[0] = 0;
        local_108[0] = 0;
        local_res20[0] = 0;
        uVar8 = new HeroAIData(0,0,0);
        AIController.SetAIStuff(this,hero,uVar8,0,0);
        lVar9 = il2cpp_internal(DAT_181d6bd30);
        local_e8 = lVar9;
        FUN_180f58a90(lVar9,DAT_181d53800);
        if (hero != null) {
          lVar10 = HeroData.GetForce(hero,0,0);
          cVar3 = HeroData.NoLoyal(hero,0);
          if (!cVar3) {
            fVar26 = *(float *)(hero + 0x1cc);
            if (50.0 <= fVar26) {
              dVar25 = (double)GlobalData.RandomRangeDouble(0,0);
              if ((double)((fVar26 - 50.0) * 0.02) <= dVar25) {
                uVar18 = uVar19;
                do {
                  if (lVar9 == null) throw; // [null/range check failed]
                  FUN_181814fa0(lVar9,2,DAT_181d53880);
                  uVar18 = uVar18 + 1;
                } while ((int)uVar18 < 1);
              }
            }
            else {
              iVar4 = Mathf.CeilToInt(5.0 - fVar26 * 0.1,0);
              uVar18 = uVar19;
              if (0 < iVar4) {
                do {
                  if (lVar9 == null) throw; // [null/range check failed]
                  FUN_181814fa0(lVar9,2,DAT_181d53880);
                  uVar18 = uVar18 + 1;
                } while ((int)uVar18 < iVar4);
              }
            }
          }
          else {
            uVar18 = uVar19;
            do {
              if (lVar9 == null) throw; // [null/range check failed]
              FUN_181814fa0(lVar9,2,DAT_181d53880);
              uVar18 = uVar18 + 1;
            } while ((int)uVar18 < 1);
          }
          cVar3 = HeroData.FullState(hero,0);
          if (!cVar3) {
            iVar5 = HeroData.GetAISettingPriorityLv(hero,0,0);
          }
          if (this != 0) {
            uVar18 = uVar19;
            if (0 < iVar5) {
              do {
                if (lVar9 == null) throw; // [null/range check failed]
                FUN_181814fa0(lVar9,3,DAT_181d53880);
                uVar18 = uVar18 + 1;
              } while ((int)uVar18 < iVar5);
            }
            if (((0.0 < *(float *)(hero + 0x1a0)) || (0.0 < *(float *)(hero + 0x1a4))) ||
               (0.0 < *(float *)(hero + 0x1a8))) {
              HeroData.GetTotalInjury(hero,0);
              HeroData.GetAISettingPriorityLv(hero,0,0);
              iVar5 = Mathf.CeilToInt();
            }
            else {
              iVar5 = 0;
            }
            uVar18 = uVar19;
            if (0 < iVar5) {
              do {
                if (lVar9 == null) throw; // [null/range check failed]
                FUN_181814fa0(lVar9,4,DAT_181d53880);
                uVar18 = uVar18 + 1;
              } while ((int)uVar18 < iVar5);
            }
            bVar23 = *(int64 *)(hero + 0x270) != 0;
            uVar18 = uVar19;
            if (bVar23) {
              uVar18 = Mathf.Max(0,8 - *(int *)(*(int64 *)(hero + 0x270) + 20),0);
            }
            uVar22 = (uint32)bVar23;
            if (*(int64 *)(hero + 0x280) != 0) {
              iVar5 = Mathf.Max(0,8 - *(int *)(*(int64 *)(hero + 0x280) + 20),0);
              uVar18 = uVar18 + iVar5;
              uVar22 = bVar23 + 1;
            }
            if (*(int64 *)(hero + 0x290) != 0) {
              iVar5 = Mathf.Max(0,8 - *(int *)(*(int64 *)(hero + 0x290) + 20),0);
              uVar18 = uVar18 + iVar5;
              uVar22 = uVar22 + 1;
            }
            lVar9 = 32;
            while (lVar11 = *(int64 *)(hero + 0x2a0)) != null {
              if ((int)*(uint32 *)(lVar11 + 24) <= (int)uVar19) {
                if (uVar22 == 0) {
                  auVar28 = ZEXT812(0);
                }
                else {
                  auVar28._4_8_ = 0;
                  auVar28._0_4_ = (float)(int)uVar18 / (float)(int)uVar22;
                }
                iVar5 = HeroData.GetAISettingPriorityLv(hero,1);
                fVar26 = auVar28._0_4_ * 0.25;
                auVar2._4_8_ = 0;
                auVar2._0_4_ = auVar28._8_4_;
                auVar1._4_8_ = SUB128(auVar2 << 64,4);
                auVar1._0_4_ = (fVar26 + 1.0) * (float)iVar5;
                iVar5 = Mathf.RoundToInt(auVar1._0_8_,0);
                lVar9 = local_e8;
                if (iVar5 < 1) goto LAB_1814ad188;
                iVar4 = 0;
                goto LAB_1814ad165;
              }
              if (*(uint32 *)(lVar11 + 24) <= uVar19) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (*(int64 *)(lVar9 + *(int64 *)(lVar11 + 16)) != 0) {
                if ((*(int64 *)(hero + 0x2a0) == 0) ||
                   (lVar11 = FUN_180002f80(*(int64 *)(hero + 0x2a0),uVar19)) == null) break;
                iVar5 = Mathf.Max(0,8 - *(int *)(lVar11 + 20));
                uVar18 = uVar18 + iVar5;
                uVar22 = uVar22 + 1;
              }
              uVar19 = uVar19 + 1;
              lVar9 = lVar9 + 8;
            }
          }
        }
        throw; // [null/range check failed]
        while( true ) {
          FUN_181814fa0(lVar9,5,DAT_181d53880);
          iVar4 = iVar4 + 1;
          if (iVar5 <= iVar4) break;
        LAB_1814ad165:
          if (lVar9 == null) throw; // [null/range check failed]
        }
        LAB_1814ad188:
        iVar5 = HeroData.GetAISettingPriorityLv(hero,1);
        iVar5 = Mathf.RoundToInt((2.0 - fVar26) * (float)iVar5,0);
        if (0 < iVar5) {
          iVar4 = 0;
          do {
            if (lVar9 == null) throw; // [null/range check failed]
            FUN_181814fa0(lVar9,18,DAT_181d53880);
            iVar4 = iVar4 + 1;
          } while (iVar4 < iVar5);
        }
        iVar5 = HeroData.GetAISettingPriorityLv(hero,2);
        if (0 < iVar5) {
          iVar4 = 0;
          do {
            if (lVar9 == null) throw; // [null/range check failed]
            FUN_181814fa0(lVar9,6,DAT_181d53880);
            iVar4 = iVar4 + 1;
          } while (iVar4 < iVar5);
        }
        iVar5 = HeroData.GetAISettingPriorityLv(hero,6);
        if (*(int64 *)(hero + 0x220) == 0) throw; // [null/range check failed]
        iVar4 = *(int *)(*(int64 *)(hero + 0x220) + 24);
        fVar26 = (float)FUN_1801f7f00();
        iVar5 = ((fVar26 * 200.0 <= (float)iVar4 ^ 1) + 1) * iVar5;
        if (0 < iVar5) {
          iVar4 = 0;
          do {
            if (lVar9 == null) throw; // [null/range check failed]
            FUN_181814fa0(lVar9,8,DAT_181d53880);
            iVar4 = iVar4 + 1;
          } while (iVar4 < iVar5);
        }
        if (*(int64 *)(hero + 0x1f8) == 0) throw; // [null/range check failed]
        cVar3 = HeroEquipmentData.HaveEmptyEquipment(*(int64 *)(hero + 0x1f8),0);
        if (!cVar3) {
          lVar11 = *(int64 *)(hero + 0x220);
          if (lVar11 == null) throw; // [null/range check failed]
          if (0.7 >= *(float *)(lVar11 + 28) / *(float *)(lVar11 + 32))
          {
            cVar3 = AIController.CheckHeroItemNumBiggerThanMax(this,hero,0x3f99999a,0);
            iVar5 = 1;
            if (cVar3) {
            iVar5 = 3;
            }
            }
            else {
          }
          iVar5 = 5;
        }
        lVar11 = *(int64 *)(hero + 0x220);
        if (lVar11 != null) {
          fVar26 = (float)FUN_1801f7f00();
          iVar4 = Mathf.Max((int)((float)*(int *)(lVar11 + 24) / (fVar26 * 400.0)) * 2,1);
          if (0 < iVar4 * iVar5) {
            iVar20 = 0;
            do {
              if (lVar9 == null) throw; // [null/range check failed]
              FUN_181814fa0(lVar9,9,DAT_181d53880);
              iVar20 = iVar20 + 1;
            } while (iVar20 < iVar4 * iVar5);
          }
          iVar5 = HeroData.GetAISettingPriorityLv(hero,6);
          if (0 < iVar5) {
            iVar4 = 0;
            do {
              if (lVar9 == null) throw; // [null/range check failed]
              FUN_181814fa0(lVar9,10,DAT_181d53880);
              iVar4 = iVar4 + 1;
            } while (iVar4 < iVar5);
          }
          iVar5 = HeroData.GetAISettingPriorityLv(hero,7);
          if (0 < iVar5) {
            iVar4 = 0;
            do {
              if (lVar9 == null) throw; // [null/range check failed]
              FUN_181814fa0(lVar9,11,DAT_181d53880);
              iVar4 = iVar4 + 1;
            } while (iVar4 < iVar5);
          }
          iVar5 = HeroData.GetAISettingPriorityLv(hero,7);
          if (0 < iVar5) {
            iVar4 = 0;
            do {
              if (lVar9 == null) throw; // [null/range check failed]
              FUN_181814fa0(lVar9,12,DAT_181d53880);
              iVar4 = iVar4 + 1;
            } while (iVar4 < iVar5);
          }
          iVar5 = HeroData.GetAISettingPriorityLv(hero,8);
          if (0 < iVar5) {
            iVar4 = 0;
            do {
              if (lVar9 == null) throw; // [null/range check failed]
              FUN_181814fa0(lVar9,14,DAT_181d53880);
              iVar4 = iVar4 + 1;
            } while (iVar4 < iVar5);
          }
          iVar5 = HeroData.GetAISettingPriorityLv(hero,8);
          if (0 < iVar5) {
            iVar4 = 0;
            do {
              if (lVar9 == null) throw; // [null/range check failed]
              FUN_181814fa0(lVar9,15,DAT_181d53880);
              iVar4 = iVar4 + 1;
            } while (iVar4 < iVar5);
          }
          if (*(int64 *)(hero + 0x220) == 0) throw; // [null/range check failed]
          iVar5 = *(int *)(*(int64 *)(hero + 0x220) + 24);
          fVar26 = (float)FUN_1801f7f00();
          if ((float)iVar5 < fVar26 * 100.0) {
            iVar5 = 0;
          }
          else {
            iVar5 = Mathf.FloorToInt(*(float *)(hero + 0x1c8) * 0.1 - 4.0,0);
          }
          if (0 < iVar5) {
            iVar4 = 0;
            do {
              if (lVar9 == null) throw; // [null/range check failed]
              FUN_181814fa0(lVar9,17,DAT_181d53880);
              iVar4 = iVar4 + 1;
            } while (iVar4 < iVar5);
          }
          if (-1 < *(int *)(hero + 132)) {
            iVar5 = HeroData.GetAISettingPriorityLv(hero,3,0);
            cVar3 = AIController.ForceHaveResourceRateLessThan(this,hero,0,0);
            if (!cVar3) {
              cVar3 = AIController.ForceHaveResourceRateLessThan(this,hero,0x3e19999a,0);
              iVar4 = 1;
              if (cVar3) {
                iVar4 = 4;
              }
            }
            else {
              iVar4 = 8;
            }
            if (0 < iVar5 * iVar4) {
              iVar20 = 0;
              do {
                if (lVar9 == null) throw; // [null/range check failed]
                FUN_181814fa0(lVar9,7,DAT_181d53880);
                iVar20 = iVar20 + 1;
              } while (iVar20 < iVar5 * iVar4);
            }
            cVar3 = AIController.CanLeaveArea(this,0);
            if (cVar3) {
              iVar5 = HeroData.GetAISettingPriorityLv(hero,4);
              if (0 < iVar5) {
                iVar4 = 0;
                do {
                  if (lVar9 == null) throw; // [null/range check failed]
                  FUN_181814fa0(lVar9,19,DAT_181d53880);
                  iVar4 = iVar4 + 1;
                } while (iVar4 < iVar5);
              }
              iVar5 = HeroData.GetAISettingPriorityLv(hero,5);
              if (0 < iVar5) {
                iVar4 = 0;
                do {
                  if (lVar9 == null) throw; // [null/range check failed]
                  FUN_181814fa0(lVar9,20,DAT_181d53880);
                  iVar4 = iVar4 + 1;
                } while (iVar4 < iVar5);
              }
            }
          }
          if (lVar10 == null) {
            if (*(int64 *)(hero + 0x220) == 0) throw; // [null/range check failed]
            iVar5 = *(int *)(*(int64 *)(hero + 0x220) + 24);
            fVar26 = (float)FUN_1801f7f00();
            bVar23 = (float)iVar5 < fVar26 * 200.0;
          }
          else {
            lVar11 = *(int64 *)(lVar10 + 136);
            if (lVar11 == null) throw; // [null/range check failed]
            if (*(uint32 *)(lVar11 + 24) < 2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar12 = *(int64 *)(lVar10 + 144);
            fVar26 = *(float *)(*(int64 *)(lVar11 + 16) + 36);
            if (lVar12 == null) throw; // [null/range check failed]
            if (*(uint32 *)(lVar12 + 24) < 2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            bVar23 = fVar26 / *(float *)(*(int64 *)(lVar12 + 16) + 36) < 0.5;
          }
          if ((!bVar23) && (iVar5 = HeroData.GetAISettingPriorityLv(hero,9), 0 < iVar5)) {
            HeroData.GetAISettingPriorityLv(hero,9);
            lVar11 = *(int64 *)(hero + 0x168);
            if (lVar11 == null) throw; // [null/range check failed]
            if (*(uint32 *)(lVar11 + 24) < 9) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            Mathf.FloorToInt((*(float *)(*(int64 *)(lVar11 + 16) + 64) -
                              ((float)*(int *)(hero + 184) * 10.0 + 10.0)) * 0.02,0);
            Mathf.Max();
            if (lVar10 != null) {
              if (*(int64 *)(lVar10 + 248) == 0) throw; // [null/range check failed]
              FUN_181815240(*(int64 *)(lVar10 + 248),8,DAT_181d67bf8);
            }
            iVar5 = Mathf.RoundToInt();
            if (0 < iVar5) {
              iVar4 = 0;
              do {
                if (lVar9 == null) throw; // [null/range check failed]
                FUN_181814fa0(lVar9,21,DAT_181d53880);
                iVar4 = iVar4 + 1;
              } while (iVar4 < iVar5);
            }
          }
          if (lVar10 == null) {
            if (*(int64 *)(hero + 0x220) == 0) throw; // [null/range check failed]
            iVar5 = *(int *)(*(int64 *)(hero + 0x220) + 24);
            fVar26 = (float)FUN_1801f7f00();
            bVar23 = (float)iVar5 < fVar26 * 200.0;
          }
          else {
            lVar11 = *(int64 *)(lVar10 + 136);
            if (lVar11 == null) throw; // [null/range check failed]
            if (*(uint32 *)(lVar11 + 24) < 5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar12 = *(int64 *)(lVar10 + 144);
            fVar26 = *(float *)(*(int64 *)(lVar11 + 16) + 48);
            if (lVar12 == null) throw; // [null/range check failed]
            if (*(uint32 *)(lVar12 + 24) < 5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            bVar23 = fVar26 / *(float *)(*(int64 *)(lVar12 + 16) + 48) < 0.5;
          }
          if ((!bVar23) && (iVar5 = HeroData.GetAISettingPriorityLv(hero,10), 0 < iVar5)) {
            HeroData.GetAISettingPriorityLv(hero,10);
            lVar11 = *(int64 *)(hero + 0x168);
            if (lVar11 == null) throw; // [null/range check failed]
            if (*(uint32 *)(lVar11 + 24) < 8) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            Mathf.FloorToInt((*(float *)(*(int64 *)(lVar11 + 16) + 60) -
                              ((float)*(int *)(hero + 184) * 10.0 + 10.0)) * 0.02,0);
            Mathf.Max();
            if (lVar10 != null) {
              if (*(int64 *)(lVar10 + 248) == 0) throw; // [null/range check failed]
              FUN_181815240(*(int64 *)(lVar10 + 248),7,DAT_181d67bf8);
            }
            iVar5 = Mathf.RoundToInt();
            if (0 < iVar5) {
              iVar4 = 0;
              do {
                if (lVar9 == null) throw; // [null/range check failed]
                FUN_181814fa0(lVar9,22,DAT_181d53880);
                iVar4 = iVar4 + 1;
              } while (iVar4 < iVar5);
            }
          }
          if (lVar10 == null) {
            if (*(int64 *)(hero + 0x220) == 0) throw; // [null/range check failed]
            iVar5 = *(int *)(*(int64 *)(hero + 0x220) + 24);
            fVar26 = (float)FUN_1801f7f00();
            bVar23 = (float)iVar5 < fVar26 * 200.0;
          }
          else {
            lVar11 = *(int64 *)(lVar10 + 136);
            if (lVar11 == null) throw; // [null/range check failed]
            if (*(uint32 *)(lVar11 + 24) < 3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar12 = *(int64 *)(lVar10 + 144);
            fVar26 = *(float *)(*(int64 *)(lVar11 + 16) + 40);
            if (lVar12 == null) throw; // [null/range check failed]
            if (*(uint32 *)(lVar12 + 24) < 3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (fVar26 / *(float *)(*(int64 *)(lVar12 + 16) + 40) < 0.5) goto LAB_1814add89;
            lVar11 = *(int64 *)(lVar10 + 136);
            if (lVar11 == null) throw; // [null/range check failed]
            if (*(uint32 *)(lVar11 + 24) < 4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar12 = *(int64 *)(lVar10 + 144);
            fVar26 = *(float *)(*(int64 *)(lVar11 + 16) + 44);
            if (lVar12 == null) throw; // [null/range check failed]
            if (*(uint32 *)(lVar12 + 24) < 4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            bVar23 = fVar26 / *(float *)(*(int64 *)(lVar12 + 16) + 44) < 0.5;
          }
          if ((!bVar23) && (iVar5 = HeroData.GetAISettingPriorityLv(hero,11), 0 < iVar5)) {
            HeroData.GetAISettingPriorityLv(hero,11);
            lVar11 = *(int64 *)(hero + 0x168);
            if (lVar11 == null) throw; // [null/range check failed]
            if (*(uint32 *)(lVar11 + 24) < 7) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            Mathf.FloorToInt((*(float *)(*(int64 *)(lVar11 + 16) + 56) -
                              ((float)*(int *)(hero + 184) * 10.0 + 10.0)) * 0.02,0);
            Mathf.Max();
            if (lVar10 != null) {
              if (*(int64 *)(lVar10 + 248) == 0) throw; // [null/range check failed]
              FUN_181815240(*(int64 *)(lVar10 + 248),6,DAT_181d67bf8);
            }
            iVar5 = Mathf.RoundToInt();
            if (0 < iVar5) {
              iVar4 = 0;
              do {
                if (lVar9 == null) throw; // [null/range check failed]
                FUN_181814fa0(lVar9,23,DAT_181d53880);
                iVar4 = iVar4 + 1;
              } while (iVar4 < iVar5);
            }
          }
        LAB_1814add89:
          local_100 = 0;
          lVar11 = il2cpp_internal(DAT_181d72a30);
          local_f8 = lVar11;
          FUN_180f58a90(lVar11,DAT_181d7c250);
          do {
            lVar12 = il2cpp_internal(DAT_181d9b9f8);
            local_f0 = lVar12;
            c__DisplayClass9_0.ctor(lVar12,0);
            if (lVar9 == null) throw; // [null/range check failed]
            uVar6 = *(uint32 *)(lVar9 + 24);
            uVar6 = GlobalData.RandomRange(0,uVar6,0);
            uVar6 = FUN_1800d6750(lVar9,uVar6);
            if ((lVar12 == null) || (*(uint32 *)(lVar12 + 16) = uVar6, lVar11 == null))
            throw; // [null/range check failed]
            FUN_180f56130(lVar11);
            switch(*(uint32 *)(lVar12 + 16)) {
            case 2:
              GlobalData.RandomRange(2,5,0);
              local_100 = new HeroAIData();
              break;
            case 3:
              HeroData.GetFullRecoverTime(hero);
              local_100 = new HeroAIData();
              break;
            case 4:
              local_100 = new HeroAIData();
              break;
            case 5:
              iVar5 = HeroData.GetAISettingFocus(hero,1);
              if (iVar5 < 0) {
        LAB_1814ae049:
                iVar5 = 0;
                while( true ) {
                  lVar12 = *(int64 *)(hero + 0x260);
                  if (lVar12 == null) throw; // [null/range check failed]
                  if (*(int *)(lVar12 + 24) <= iVar5) break;
                  lVar12 = FUN_180002f80(lVar12,iVar5);
                  if (lVar12 == null) throw; // [null/range check failed]
                  if (*(int *)(lVar12 + 20) < 10) {
                    if ((((*(int64 *)(hero + 0x260) == 0) ||
                         (lVar12 = FUN_180002f80(*(int64 *)(hero + 0x260),iVar5,DAT_181d6ade8),
                         lVar12 == null)) || (lVar12 = KungfuSkillLvData.DataBase(lVar12,0)) == null)
                       || ((((*(int *)(lVar12 + 52) != *(int *)(hero + 184) &&
                             (((*(int64 *)(hero + 0x260) == 0 ||
                               (lVar12 = FUN_180002f80(*(int64 *)(hero + 0x260),iVar5,DAT_181d6ade8)
                               , lVar12 == null)) ||
                              (lVar12 = KungfuSkillLvData.DataBase(lVar12,0)) == null))) ||
                            ((*(int *)(hero + 136) != -1 &&
                             (((*(int64 *)(hero + 0x260) == 0 ||
                               (lVar12 = FUN_180002f80(*(int64 *)(hero + 0x260),iVar5,DAT_181d6ade8)
                               , lVar12 == null)) ||
                              (lVar12 = KungfuSkillLvData.DataBase(lVar12,0)) == null))))) ||
                           (((((*(int64 *)(hero + 0x260) == 0 ||
                               (lVar12 = FUN_180002f80(*(int64 *)(hero + 0x260),iVar5,DAT_181d6ade8)
                               , lVar12 == null)) || (*(int64 *)(hero + 0x260) == 0)) ||
                             ((lVar12 = FUN_180002f80(*(int64 *)(hero + 0x260),iVar5,DAT_181d6ade8),
                              lVar12 == null || (*(int64 *)(hero + 0x260) == 0)))) ||
                            (lVar12 = FUN_180002f80(*(int64 *)(hero + 0x260),iVar5,DAT_181d6ade8),
                            lVar12 == null)))))) throw; // [null/range check failed]
                    Mathf.Max(0,4 - *(int *)(lVar12 + 20),0);
                    lVar12 = *(int64 *)(hero + 0x118);
                    if (((*(int64 *)(hero + 0x260) == 0) ||
                        (lVar13 = FUN_180002f80(*(int64 *)(hero + 0x260),iVar5,DAT_181d6ade8),
                        lVar13 == null)) ||
                       ((lVar13 = KungfuSkillLvData.DataBase(lVar13,0), lVar13 == null || (lVar12 == null))))
                    throw; // [null/range check failed]
                    FUN_1818279a0(lVar12,*(uint64 *)(lVar13 + 32),DAT_181d7c4d0);
                    if ((*(int64 *)(hero + 0x260) == 0) ||
                       (lVar12 = FUN_180002f80(*(int64 *)(hero + 0x260),iVar5,DAT_181d6ade8),
                       lVar12 == null)) throw; // [null/range check failed]
                    KungfuSkillLvData.GetSkillNeedExpRate(lVar12,hero,0);
                    if ((*(int64 *)(hero + 0x260) == 0) ||
                       ((lVar12 = FUN_180002f80(*(int64 *)(hero + 0x260),iVar5), lVar12 == null ||
                        (lVar12 = KungfuSkillLvData.DataBase(lVar12,0)) == null)))
                    throw; // [null/range check failed]
                    HeroData.GetSkillRareLvExpRate(hero,*(uint32 *)(lVar12 + 52));
                    iVar4 = 0;
                    fVar26 = (float)Mathf.Max();
                    if (0.0 < fVar26) {
                      do {
                        if ((*(int64 *)(hero + 0x260) == 0) ||
                           (lVar12 = FUN_180002f80(*(int64 *)(hero + 0x260),iVar5,DAT_181d6ade8),
                           lVar12 == null)) throw; // [null/range check failed]
                        uVar8 = Int32.ToString(lVar12 + 16,0);
                        FUN_181827900(lVar11,uVar8);
                        iVar4 = iVar4 + 1;
                      } while ((float)iVar4 < fVar26);
                    }
                  }
                  iVar5 = iVar5 + 1;
                }
                iVar5 = *(int *)(lVar11 + 24);
                if (iVar5 < 1) {
                  uVar17 = il2cpp_internal(DAT_181d76aa0);
                  lVar12 = local_f0;
                  uVar8 = DAT_181d6bb18;
                  goto LAB_1814ae3d8;
                }
                uVar6 = GlobalData.RandomRange(0,iVar5,0,0);
                uVar8 = FUN_180002f80(lVar11,uVar6,DAT_181d7c9c0);
              }
              else {
                uVar6 = HeroData.GetAISettingFocus(hero,1);
                lVar12 = HeroData.FindSkill(hero,uVar6,0);
                if (lVar12 == null) throw; // [null/range check failed]
                if (9 < *(int *)(lVar12 + 20)) goto LAB_1814ae049;
                local_res10[0] = HeroData.GetAISettingFocus(hero,1);
                uVar8 = Int32.ToString(local_res10,0);
              }
              uVar6 = GlobalData.RandomRange(4,7,0);
              local_100 = il2cpp_internal(DAT_181d50d80);
              uVar17 = 5;
              goto LAB_1814ae02e;
            case 6:
              iVar5 = HeroData.GetAISettingFocus(hero,2);
              if (iVar5 < 0) {
        LAB_1814ae51a:
                local_108[0] = 0;
                while( true ) {
                  lVar13 = *(int64 *)(hero + 0x158);
                  if (lVar13 == null) throw; // [null/range check failed]
                  if (*(int *)(lVar13 + 24) <= local_108[0]) break;
                  fVar26 = (float)FUN_1800d6780(lVar13,local_108[0]);
                  fVar24 = (float)HeroData.GetMaxLivingSkill(hero,local_108[0]);
                  if (fVar26 < fVar24) {
                    HeroData.GetMaxLivingSkill(hero,local_108[0],0);
                    if (*(int64 *)(hero + 0x158) == 0) throw; // [null/range check failed]
                    FUN_1800d6780(*(int64 *)(hero + 0x158),local_108[0]);
                    uVar19 = Mathf.CeilToInt();
                    uVar21 = (uint64)uVar19;
                    if (lVar10 != null) {
                      if (*(int64 *)(lVar10 + 248) == 0) throw; // [null/range check failed]
                      cVar3 = FUN_181815240(*(int64 *)(lVar10 + 248),local_108[0]);
                      if (cVar3) {
                        uVar21 = (uint64)(uVar19 + 3);
                      }
                    }
                    if (0 < (int)uVar21) {
                      do {
                        Int32.ToString(local_108,0);
                        FUN_181827900(lVar11);
                        uVar21 = uVar21 - 1;
                      } while (uVar21 != 0);
                    }
                  }
                  local_108[0] = local_108[0] + 1;
                }
                iVar5 = *(int *)(lVar11 + 24);
                if (iVar5 < 1) {
                  uVar17 = il2cpp_internal(DAT_181d76aa0);
                  uVar8 = DAT_181d6bc18;
                  goto LAB_1814ae3d8;
                }
                uVar6 = GlobalData.RandomRange(0,iVar5,0,0);
                uVar8 = FUN_180002f80(lVar11,uVar6,DAT_181d7c9c0);
              }
              else {
                lVar13 = *(int64 *)(hero + 0x158);
                uVar6 = HeroData.GetAISettingFocus(hero,2);
                if (lVar13 == null) throw; // [null/range check failed]
                fVar26 = (float)FUN_1800d6780(lVar13,uVar6,DAT_181d796d8);
                uVar6 = HeroData.GetAISettingFocus(hero,2);
                fVar24 = (float)HeroData.GetMaxLivingSkill(hero,uVar6,0);
                if (fVar24 <= fVar26) goto LAB_1814ae51a;
                local_res10[0] = HeroData.GetAISettingFocus(hero,2);
                uVar8 = Int32.ToString(local_res10,0);
              }
              uVar6 = GlobalData.RandomRange(4,7,0);
              local_100 = il2cpp_internal(DAT_181d50d80);
              uVar17 = 6;
              goto LAB_1814ae02e;
            case 7:
              iVar5 = HeroData.GetAISettingFocus(hero,3,0);
              if (iVar5 < 0) {
        LAB_1814ae77e:
                local_res20[0] = 0;
                while( true ) {
                  if ((lVar10 == null) || (lVar13 = *(int64 *)(lVar10 + 136)) == null)
                  throw; // [null/range check failed]
                  if (*(int *)(lVar13 + 24) <= local_res20[0]) break;
                  fVar26 = (float)FUN_1800d6780(lVar13,local_res20[0],DAT_181d796d8);
                  if (*(int64 *)(lVar10 + 144) == 0) throw; // [null/range check failed]
                  fVar24 = (float)FUN_1800d6780(*(int64 *)(lVar10 + 144),local_res20[0]);
                  if (fVar26 / fVar24 < 0.95) {
                    uVar8 = Int32.ToString(local_res20,0);
                    FUN_181827900(lVar11,uVar8,DAT_181d7c3d0);
                    if (*(int64 *)(lVar10 + 136) == 0) throw; // [null/range check failed]
                    fVar26 = (float)FUN_1800d6780(*(int64 *)(lVar10 + 136),local_res20[0],
                                                  DAT_181d796d8);
                    if (*(int64 *)(lVar10 + 144) == 0) throw; // [null/range check failed]
                    fVar24 = (float)FUN_1800d6780(*(int64 *)(lVar10 + 144),local_res20[0],
                                                  DAT_181d796d8);
                    if (fVar26 / fVar24 <= 0.15) {
                      lVar13 = 5;
                      do {
                        uVar8 = Int32.ToString(local_res20,0);
                        FUN_181827900(lVar11,uVar8,DAT_181d7c3d0);
                        lVar13 = lVar13 + -1;
                      } while (lVar13 != null);
                    }
                    if (*(int64 *)(lVar10 + 136) == 0) throw; // [null/range check failed]
                    fVar26 = (float)FUN_1800d6780(*(int64 *)(lVar10 + 136),local_res20[0],
                                                  DAT_181d796d8);
                    if (*(int64 *)(lVar10 + 152) == 0) throw; // [null/range check failed]
                    fVar24 = (float)FUN_1800d6780(*(int64 *)(lVar10 + 152),local_res20[0]);
                    if (fVar24 + fVar26 < 0.0) {
                      lVar13 = 5;
                      do {
                        Int32.ToString(local_res20,0);
                        FUN_181827900(lVar11);
                        lVar13 = lVar13 + -1;
                      } while (lVar13 != null);
                    }
                  }
                  local_res20[0] = local_res20[0] + 1;
                }
                iVar5 = *(int *)(lVar11 + 24);
                if (iVar5 < 1) {
                  uVar17 = il2cpp_internal(DAT_181d76aa0);
                  uVar8 = DAT_181d6bc98;
                  goto LAB_1814ae3d8;
                }
                uVar6 = GlobalData.RandomRange(0,iVar5,0,0);
                uVar8 = FUN_180002f80(lVar11,uVar6,DAT_181d7c9c0);
              }
              else {
                if (lVar10 == null) throw; // [null/range check failed]
                lVar13 = *(int64 *)(lVar10 + 136);
                uVar6 = HeroData.GetAISettingFocus(hero,3,0);
                if (lVar13 == null) throw; // [null/range check failed]
                fVar26 = (float)FUN_1800d6780(lVar13,uVar6,DAT_181d796d8);
                lVar13 = *(int64 *)(lVar10 + 144);
                uVar6 = HeroData.GetAISettingFocus(hero,3,0);
                if (lVar13 == null) throw; // [null/range check failed]
                fVar24 = (float)FUN_1800d6780(lVar13,uVar6,DAT_181d796d8);
                if (0.95 <= fVar26 / fVar24) goto LAB_1814ae77e;
                local_res10[0] = HeroData.GetAISettingFocus(hero,3,0);
                uVar8 = Int32.ToString(local_res10,0);
              }
              uVar6 = GlobalData.RandomRange(4,7,0);
              local_100 = il2cpp_internal(DAT_181d50d80);
              uVar17 = 7;
        LAB_1814ae02e:
              HeroAIData.ctor(local_100,uVar17,uVar8,uVar6,0);
              break;
            case 8:
              GlobalData.RandomRange(4,7,0);
              local_100 = new HeroAIData();
              break;
            case 9:
              GlobalData.RandomRange(2,5,0);
              local_100 = new HeroAIData();
              break;
            case 10:
              GlobalData.RandomRange(4,7,0);
              local_100 = new HeroAIData();
              break;
            case 11:
            case 12:
              lVar12 = il2cpp_internal(DAT_181d6e6b0);
              FUN_180f58a90(lVar12,DAT_181d63c78);
              iVar5 = 0;
              while( true ) {
                lVar13 = FUN_18046c0a0(0);
                if ((((lVar13 == null) || (*(int64 *)(lVar13 + 32) == 0)) ||
                    (lVar13 = WorldData.GetArea(*(int64 *)(lVar13 + 32),
                                                 *(uint32 *)(hero + 192),0), lVar13 == null)) ||
                   (*(int64 *)(lVar13 + 120) == 0)) throw; // [null/range check failed]
                if (*(int *)(*(int64 *)(lVar13 + 120) + 24) <= iVar5) break;
                lVar13 = FUN_18046c0a0(0);
                if ((((lVar13 == null) || (*(int64 *)(lVar13 + 32) == 0)) ||
                    (lVar13 = WorldData.GetArea(*(int64 *)(lVar13 + 32),
                                                 *(uint32 *)(hero + 192),0), lVar13 == null)) ||
                   (*(int64 *)(lVar13 + 120) == 0)) throw; // [null/range check failed]
                iVar4 = FUN_1800d6750(*(int64 *)(lVar13 + 120),iVar5);
                if (iVar4 != 0) {
                  lVar13 = FUN_18046c0a0(0);
                  if (((lVar13 == null) || (*(int64 *)(lVar13 + 32) == 0)) ||
                     ((lVar13 = WorldData.GetArea(*(int64 *)(lVar13 + 32),
                                                   *(uint32 *)(hero + 192),0), lVar13 == null ||
                      (*(int64 *)(lVar13 + 120) == 0)))) throw; // [null/range check failed]
                  iVar4 = FUN_1800d6750(*(int64 *)(lVar13 + 120),iVar5);
                  if (iVar4 != *(int *)(hero + 88)) {
                    lVar13 = FUN_18046c0a0(0);
                    if ((((lVar13 == null) || (*(int64 *)(lVar13 + 32) == 0)) ||
                        (lVar13 = WorldData.GetArea(*(int64 *)(lVar13 + 32),
                                                     *(uint32 *)(hero + 192)), lVar13 == null)) ||
                       (lVar13 = AreaData.GetInsideHero(lVar13,iVar5)) == null) throw; // [null/range check failed]
                    cVar3 = HeroData.StuffStoppable(lVar13,0);
                    if (cVar3) {
                      lVar13 = FUN_18046c0a0(0);
                      if (((lVar13 == null) || (*(int64 *)(lVar13 + 32) == 0)) ||
                         ((lVar13 = WorldData.GetArea(*(int64 *)(lVar13 + 32),
                                                       *(uint32 *)(hero + 192),0), lVar13 == null ||
                          (uVar8 = AreaData.GetInsideHero(lVar13,iVar5,0), lVar12 == null))))
                      throw; // [null/range check failed]
                      FUN_181827900(lVar12,uVar8);
                    }
                  }
                }
                iVar5 = iVar5 + 1;
              }
              if (lVar12 == null) throw; // [null/range check failed]
              if (*(int *)(lVar12 + 24) < 1) {
                lVar12 = *(int64 *)(pStatics + 8);
                if (lVar12 == null) {
                  uVar8 = **(uint64 **)(DAT_181d9b970 + 184);
                  lVar12 = new OnTooltipCB(uVar8,DAT_181d6b998);
                  plVar16 = (int64 *)(pStatics + 8);
                  *plVar16 = lVar12;
                  il2cpp_internal(plVar16,lVar12);
                }
                FUN_181818fa0(lVar9,lVar12,DAT_181d53980);
                if (*(int64 *)(pStatics + 16) == 0) {
                  uVar8 = **(uint64 **)(DAT_181d9b970 + 184);
                  uVar17 = new OnTooltipCB(uVar8,DAT_181d6ba18);
                  puVar15 = (uint64 *)(pStatics + 16);
                  *puVar15 = uVar17;
                  il2cpp_internal(puVar15,uVar17);
                }
                FUN_181818fa0(lVar9);
              }
              else {
                lVar9 = il2cpp_internal(DAT_181d6f030);
                FUN_180f58a90(lVar9,DAT_181d678f8);
                for (iVar5 = 0; iVar5 < *(int *)(lVar12 + 24); iVar5 = iVar5 + 1) {
                  uVar8 = FUN_180002f80(lVar12,iVar5,DAT_181d643f8);
                  fVar26 = (float)HeroData.GetStartFavor(hero,uVar8,0);
                  lVar11 = FUN_180002f80(lVar12,iVar5);
                  if (lVar11 == null) throw; // [null/range check failed]
                  cVar3 = HeroData.HaveHater(hero,*(uint32 *)(lVar11 + 88));
                  if (!cVar3) {
                    if (fVar26 < 0.0) {
                      lVar11 = FUN_180002f80(lVar12,iVar5);
                      if (lVar11 == null) throw; // [null/range check failed]
                      cVar3 = HeroData.HaveRelationBetterThanFriend
                                        (hero,*(uint32 *)(lVar11 + 88),0,1,0);
                      if (!(!cVar3))
                      {
                        }
                        }
                        else {
                      }
                    fVar26 = (float)Mathf.Min();
                    lVar11 = FUN_180002f80(lVar12,iVar5,DAT_181d643f8);
                    if (lVar11 == null) throw; // [null/range check failed]
                    cVar3 = HeroData.HaveHater(hero,*(uint32 *)(lVar11 + 88),0);
                    if (!cVar3) {
                      fVar24 = 1.0;
                    }
                    else {
                      fVar24 = 10.0;
                    }
                    lVar11 = FUN_180002f80(lVar12,iVar5);
                    if (lVar11 == null) throw; // [null/range check failed]
                    cVar3 = HeroData.HaveFriend(hero,*(uint32 *)(lVar11 + 88));
                    if (!cVar3) {
                      fVar27 = 1.0;
                    }
                    else {
                      fVar27 = 0.5;
                    }
                    fVar27 = fVar24 * ABS(fVar26) * fVar27;
                    iVar4 = 0;
                    if (0.0 < fVar27) {
                      do {
                        if (lVar9 == null) throw; // [null/range check failed]
                        FUN_181814fa0(lVar9,iVar5);
                        iVar4 = iVar4 + 1;
                      } while ((float)iVar4 < fVar27);
                    }
                  }
                }
                if (lVar9 == null) throw; // [null/range check failed]
                iVar5 = *(int *)(lVar9 + 24);
                if (0 < iVar5) {
                  uVar6 = GlobalData.RandomRange(0,iVar5,0,0);
                  uVar6 = FUN_1800d6750(lVar9,uVar6,DAT_181d68270);
                  lVar9 = FUN_180002f80(lVar12,uVar6,DAT_181d643f8);
                  HeroData.GetStartFavor(hero,lVar9,0);
                  dVar25 = (double)GlobalData.RandomRangeDouble(0,0);
                  fVar26 = (float)Mathf.Min();
                  if (lVar9 == null) throw; // [null/range check failed]
                  cVar3 = HeroData.HaveHater(hero,*(uint32 *)(lVar9 + 88),0);
                  if (!cVar3) {
                    fVar24 = 1.0;
                  }
                  else {
                    fVar24 = 10.0;
                  }
                  cVar3 = HeroData.HaveFriend(hero,*(uint32 *)(lVar9 + 88),0);
                  if (!cVar3) {
                    fVar27 = 1.0;
                  }
                  else {
                    fVar27 = 0.5;
                  }
                  if (dVar25 < (double)(((*(float *)(hero + 0x1d4) + *(float *)(hero + 0x1d0)) /
                                         50.0 + 1.0) * ABS(fVar26) * 0.002 * fVar24 * fVar27)) {
                    uVar8 = Int32.ToString(lVar9 + 88,0);
                    uVar6 = HeroData.GetFightTime(hero,lVar9,0);
                    local_100 = new HeroAIData(13,uVar8,uVar6,0);
                  }
                }
                if (local_100 != 0) goto LAB_1814b0372;
                uVar6 = *(uint32 *)(lVar12 + 24);
                uVar7 = *(uint32 *)(local_f0 + 16);
                uVar6 = GlobalData.RandomRange(0,uVar6,0,0);
                lVar9 = FUN_180002f80(lVar12,uVar6,DAT_181d643f8);
                if (lVar9 == null) throw; // [null/range check failed]
                uVar8 = Int32.ToString(lVar9 + 88,0);
                uVar6 = GlobalData.RandomRange(3,5,0);
                local_100 = new HeroAIData(uVar7,uVar8,uVar6,0);
                lVar11 = local_f8;
              }
              break;
            case 14:
              GlobalData.RandomRange(4,7,0);
              local_100 = new HeroAIData();
              break;
            case 15:
              GlobalData.RandomRange(4,7,0);
              local_100 = new HeroAIData();
              break;
            case 17:
              GlobalData.RandomRange(4,7,0);
              local_100 = new HeroAIData();
              break;
            case 18:
              if (*(int *)(hero + 132) < 0) {
                if (*(int *)(hero + 136) < 0) {
                  lVar13 = 0;
                }
                else {
                  lVar13 = FUN_18046c0a0(0);
                  if ((lVar13 == null) || (*(int64 *)(lVar13 + 32) == 0)) throw; // [null/range check failed]
                  lVar13 = WorldData.GetForce(*(int64 *)(lVar13 + 32),
                                               *(uint32 *)(hero + 136),0);
                }
              }
              else {
                lVar13 = HeroData.GetForce(hero,0,0);
              }
              cVar3 = HeroData.IsPlayerSameForce(hero,0);
              if ((!cVar3) || (*(int *)(hero + 0x374) != 2)) {
                lVar14 = il2cpp_internal(DAT_181d6cb30);
                FUN_180f58a90(lVar14,DAT_181d58d10);
                if (lVar14 == null) throw; // [null/range check failed]
                FUN_181805880(lVar14,1,DAT_181d58d90);
                FUN_181805880(lVar14,1,DAT_181d58d90);
                FUN_181805880(lVar14,1,DAT_181d58d90);
                FUN_181805880(lVar14,1,DAT_181d58d90);
                FUN_181805880(lVar14,1,DAT_181d58d90);
                FUN_181805880(lVar14,1,DAT_181d58d90);
                iVar5 = 0;
                while( true ) {
                  if (*(int64 *)(hero + 0x260) == 0) throw; // [null/range check failed]
                  if (*(int *)(*(int64 *)(hero + 0x260) + 24) <= iVar5) break;
                  lVar9 = FUN_180002f80();
                  if (lVar9 == null) throw; // [null/range check failed]
                  if (*(int *)(lVar9 + 20) < 8) {
                    if (((*(int64 *)(hero + 0x260) == 0) ||
                        (lVar9 = FUN_180002f80(*(int64 *)(hero + 0x260),iVar5)) == null) ||
                       (lVar9 = KungfuSkillLvData.DataBase(lVar9,0)) == null) throw; // [null/range check failed]
                    FUN_181814bb0(lVar14);
                  }
                  iVar5 = iVar5 + 1;
                }
                if (lVar13 != null) {
                  iVar5 = 0;
                  while( true ) {
                    if ((plVar13 == 0) ||
                       (lVar9 = *(int64 *)(plVar13 + 40)) == null)
                    throw; // [null/range check failed]
                    lVar11 = local_f8;
                    lVar12 = local_f0;
                    if (*(int *)(lVar9 + 24) <= iVar5) break;
                    lVar9 = FUN_180002f80();
                    if (((lVar9 == null) || (*(int64 *)(lVar9 + 112) == 0)) ||
                       (lVar9 = BookData.DataBase()) == null) throw; // [null/range check failed]
                    iVar4 = *(int *)(lVar9 + 52);
                    if (iVar4 <= *(int *)(hero + 184)) {
                      if (((plVar13 == 0) ||
                          (lVar9 = *(int64 *)(plVar13 + 40)) == null) ||
                         ((lVar9 = FUN_180002f80(lVar9,iVar5), lVar9 == null ||
                          (*(int64 *)(lVar9 + 112) == 0)))) throw; // [null/range check failed]
                      lVar9 = HeroData.FindSkill(hero);
                      if (lVar9 == null) {
                        cVar3 = FUN_180132d10(lVar14,iVar4,DAT_181d58f10);
                        if (!cVar3) {
                          dVar25 = (double)GlobalData.RandomRangeDouble(0,0);
                          if (*(int64 *)(hero + 600) == 0) throw; // [null/range check failed]
                          iVar20 = FUN_1800d6750(*(int64 *)(hero + 600),iVar4);
                          fVar26 = (float)HeroData.GetMaxSkillNum(hero,iVar4);
                          fVar24 = (float)HeroData.GetMaxSkillNum(hero);
                          if (dVar25 <= (double)((((float)iVar20 - fVar26) + ((float)iVar20 - fVar26)) /
                                                fVar24)) goto LAB_1814af6a5;
                        }
                        if ((((plVar13 == 0) ||
                             (lVar9 = *(int64 *)(plVar13 + 40)) == null) ||
                            (lVar9 = FUN_180002f80(lVar9,iVar5,DAT_181d69770)) == null) ||
                           (*(int64 *)(lVar9 + 112) == 0)) throw; // [null/range check failed]
                        Int32.ToString(*(int64 *)(lVar9 + 112) + 16,0);
                        FUN_181827900(local_f8);
                      }
                    }
        LAB_1814af6a5:
                    iVar5 = iVar5 + 1;
                  }
                }
                cVar3 = HeroData.IsPlayerSameForce(hero,0);
                if ((!cVar3) || (lVar9 = local_e8, *(int *)(hero + 0x374) != 1)) {
                  iVar5 = 0;
                  while( true ) {
                    if (((*(int64 *)(hero + 0x220) == 0) ||
                        (lVar9 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null) ||
                       (lVar13 = FUN_180002f80(lVar9,3,DAT_181d51888)) == null) throw; // [null/range check failed]
                    lVar11 = local_f8;
                    lVar12 = local_f0;
                    lVar9 = local_e8;
                    if (*(int *)(lVar13 + 24) <= iVar5) break;
                    if ((((*(int64 *)(hero + 0x220) == 0) ||
                         (lVar9 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null) ||
                        (lVar9 = FUN_180002f80(lVar9,3,DAT_181d51888)) == null) ||
                       ((lVar9 = FUN_180002f80(lVar9,iVar5,DAT_181d69770), lVar9 == null ||
                        (*(int64 *)(lVar9 + 112) == 0)))) throw; // [null/range check failed]
                    lVar9 = HeroData.FindSkill(hero,*(uint32 *)
                                                         (*(int64 *)(lVar9 + 112) + 16),0);
                    if (lVar9 == null) {
                      if (((*(int64 *)(hero + 0x220) == 0) ||
                          (lVar9 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null) ||
                         ((lVar9 = FUN_180002f80(lVar9,3,DAT_181d51888), lVar9 == null ||
                          (((lVar9 = FUN_180002f80(lVar9,iVar5,DAT_181d69770), lVar9 == null ||
                            (*(int64 *)(lVar9 + 112) == 0)) ||
                           (lVar9 = BookData.DataBase(*(int64 *)(lVar9 + 112),0)) == null)))))
                      throw; // [null/range check failed]
                      uVar6 = *(uint32 *)(lVar9 + 52);
                      dVar25 = (double)GlobalData.RandomRangeDouble(0,0);
                      fVar26 = (float)Mathf.Max();
                      if (dVar25 <= (double)(1.0 / (fVar26 + fVar26))) {
                        cVar3 = FUN_180132d10(lVar14,uVar6,DAT_181d58f10);
                        if (!cVar3) {
                          dVar25 = (double)GlobalData.RandomRangeDouble(0,0);
                          if (*(int64 *)(hero + 600) == 0) throw; // [null/range check failed]
                          iVar4 = FUN_1800d6750(*(int64 *)(hero + 600),uVar6,DAT_181d68270);
                          fVar26 = (float)HeroData.GetMaxSkillNum(hero,uVar6,0);
                          fVar24 = (float)HeroData.GetMaxSkillNum(hero,uVar6,0);
                          if (dVar25 <= (double)((((float)iVar4 - fVar26) + ((float)iVar4 - fVar26)) /
                                                fVar24)) goto LAB_1814af96e;
                        }
                        if ((((*(int64 *)(hero + 0x220) == 0) ||
                             (lVar9 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null)
                            || (lVar9 = FUN_180002f80(lVar9,3,DAT_181d51888)) == null) ||
                           ((lVar9 = FUN_180002f80(lVar9,iVar5,DAT_181d69770), lVar9 == null ||
                            (*(int64 *)(lVar9 + 112) == 0)))) throw; // [null/range check failed]
                        uVar8 = Int32.ToString(*(int64 *)(lVar9 + 112) + 16,0);
                        FUN_181827900(local_f8,uVar8,DAT_181d7c3d0);
                      }
                    }
        LAB_1814af96e:
                    iVar5 = iVar5 + 1;
                  }
                }
              }
              uVar6 = 3;
              iVar5 = *(int *)(lVar11 + 24);
              if (0 < iVar5) {
                uVar7 = GlobalData.RandomRange(0,iVar5,0,0);
                uVar8 = FUN_180002f80(lVar11,uVar7,DAT_181d7c9c0);
                local_100 = il2cpp_internal(DAT_181d50d80);
                uVar17 = 18;
                goto LAB_1814ae02e;
              }
              uVar17 = il2cpp_internal(DAT_181d76aa0);
              uVar8 = DAT_181d6bb98;
        LAB_1814ae3d8:
              OnTooltipCB.ctor(uVar17,lVar12,uVar8);
              FUN_181818fa0(lVar9);
              break;
            case 19:
              iVar5 = HeroData.GetAISettingFocus(hero,4,0);
              if (-1 < iVar5) {
                lVar12 = FUN_18046c0a0(0);
                if (lVar12 == null) throw; // [null/range check failed]
                lVar12 = *(int64 *)(lVar12 + 32);
                uVar6 = HeroData.GetAISettingFocus(hero,4,0);
                if ((lVar12 == null) || (lVar12 = WorldData.GetArea(lVar12,uVar6,0)) == null)
                throw; // [null/range check failed]
                cVar3 = AreaData.CanAddState(lVar12,0);
                if (cVar3) {
                  local_res10[0] = HeroData.GetAISettingFocus(hero,4,0);
                  uVar8 = Int32.ToString(local_res10,0);
                  uVar6 = GlobalData.RandomRange(4,7,0);
                  local_100 = il2cpp_internal(DAT_181d50d80);
                  uVar17 = 19;
                  goto LAB_1814ae02e;
                }
              }
              lVar11 = il2cpp_internal(DAT_181d6f030);
              FUN_180f58a90(lVar11,DAT_181d678f8);
              iVar5 = 0;
              while( true ) {
                if ((lVar10 == null) || (*(int64 *)(lVar10 + 96) == 0)) throw; // [null/range check failed]
                if (*(int *)(*(int64 *)(lVar10 + 96) + 24) <= iVar5) break;
                lVar12 = FUN_18046c0a0(0);
                if (lVar12 == null) throw; // [null/range check failed]
                lVar12 = *(int64 *)(lVar12 + 32);
                if (((*(int64 *)(lVar10 + 96) == 0) ||
                    (uVar6 = FUN_1800d6750(*(int64 *)(lVar10 + 96),iVar5,DAT_181d68270), lVar12 == null)
                    ) || (lVar12 = WorldData.GetArea(lVar12,uVar6,0)) == null) throw; // [null/range check failed]
                if (*(int *)(lVar12 + 72) != 2) {
                  lVar12 = FUN_18046c0a0(0);
                  if (lVar12 == null) throw; // [null/range check failed]
                  lVar12 = *(int64 *)(lVar12 + 32);
                  if (((*(int64 *)(lVar10 + 96) == 0) ||
                      (uVar6 = FUN_1800d6750(*(int64 *)(lVar10 + 96),iVar5,DAT_181d68270),
                      lVar12 == null)) || (lVar12 = WorldData.GetArea(lVar12,uVar6,0)) == null)
                  throw; // [null/range check failed]
                  cVar3 = AreaData.CanAddState(lVar12,0);
                  if (cVar3) {
                    if ((*(int64 *)(lVar10 + 96) == 0) ||
                       (uVar6 = FUN_1800d6750(*(int64 *)(lVar10 + 96),iVar5,DAT_181d68270),
                       lVar11 == null)) throw; // [null/range check failed]
                    FUN_181814fa0(lVar11,uVar6,DAT_181d67a78);
                  }
                }
                iVar5 = iVar5 + 1;
              }
              if (lVar11 == null) throw; // [null/range check failed]
              if (*(int *)(lVar11 + 24) < 1) {
                uVar8 = new OnTooltipCB(local_f0,DAT_181d6bd18);
                FUN_181818fa0(lVar9);
                lVar11 = local_f8;
              }
              else {
                lVar9 = *(int64 *)(pStatics + 24);
                if (lVar9 == null) {
                  uVar8 = **(uint64 **)(DAT_181d9b970 + 184);
                  lVar9 = new OnTooltipCB(uVar8,DAT_181d6ba98,DAT_181d86018);
                  plVar16 = (int64 *)(pStatics + 24);
                  *plVar16 = lVar9;
                  il2cpp_internal(plVar16,lVar9);
                }
                List_1.Sort(lVar11,lVar9,DAT_181d68070);
                local_res10[0] = FUN_1800d6750(lVar11,0,DAT_181d68270);
                uVar8 = Int32.ToString(local_res10,0);
                uVar6 = GlobalData.RandomRange(4,7,0);
                local_100 = new HeroAIData(19,uVar8,uVar6,0);
                lVar11 = local_f8;
              }
              break;
            case 20:
              iVar5 = HeroData.GetAISettingFocus(hero,5);
              if (-1 < iVar5) {
                lVar9 = FUN_18046c0a0(0);
                if (lVar9 == null) throw; // [null/range check failed]
                lVar9 = *(int64 *)(lVar9 + 32);
                uVar6 = HeroData.GetAISettingFocus(hero,5);
                if ((lVar9 == null) || (lVar9 = WorldData.GetArea(lVar9,uVar6)) == null)
                throw; // [null/range check failed]
                cVar3 = AreaData.CanReduceState(lVar9,0);
                if (cVar3) {
                  local_res10[0] = HeroData.GetAISettingFocus(hero,5);
                  uVar8 = Int32.ToString(local_res10,0);
                  uVar6 = GlobalData.RandomRange(4,7,0);
                  local_100 = il2cpp_internal(DAT_181d50d80);
                  uVar17 = 20;
                  goto LAB_1814ae02e;
                }
              }
              lVar9 = il2cpp_internal(DAT_181d6f030);
              FUN_180f58a90(lVar9);
              iVar5 = 0;
              while( true ) {
                if ((lVar10 == null) || (*(int64 *)(lVar10 + 96) == 0)) throw; // [null/range check failed]
                lVar11 = local_f8;
                if (*(int *)(*(int64 *)(lVar10 + 96) + 24) <= iVar5) break;
                iVar4 = 0;
                while( true ) {
                  lVar11 = FUN_18046c0a0(0);
                  if (lVar11 == null) throw; // [null/range check failed]
                  lVar11 = *(int64 *)(lVar11 + 32);
                  if ((((*(int64 *)(lVar10 + 96) == 0) ||
                       (uVar6 = FUN_1800d6750(*(int64 *)(lVar10 + 96),iVar5,DAT_181d68270),
                       lVar11 == null)) ||
                      (lVar12 = WorldData.GetArea(lVar11,uVar6,0), lVar11 = local_f0) == null) ||
                     (*(int64 *)(lVar12 + 152) == 0)) throw; // [null/range check failed]
                  if (*(int *)(*(int64 *)(lVar12 + 152) + 24) <= iVar4) break;
                  lVar11 = FUN_18046c0a0(0);
                  if (lVar11 == null) throw; // [null/range check failed]
                  lVar11 = *(int64 *)(lVar11 + 32);
                  lVar12 = FUN_18046c0a0(0);
                  if (lVar12 == null) throw; // [null/range check failed]
                  lVar12 = *(int64 *)(lVar12 + 32);
                  if ((((*(int64 *)(lVar10 + 96) == 0) ||
                       (uVar6 = FUN_1800d6750(*(int64 *)(lVar10 + 96),iVar5,DAT_181d68270),
                       lVar12 == null)) || (lVar12 = WorldData.GetArea(lVar12,uVar6,0)) == null) ||
                     (((*(int64 *)(lVar12 + 152) == 0 ||
                       (uVar6 = FUN_1800d6750(*(int64 *)(lVar12 + 152),iVar4,DAT_181d68270),
                       lVar11 == null)) || (lVar11 = WorldData.GetArea(lVar11,uVar6,0)) == null)))
                  throw; // [null/range check failed]
                  if (((*(int *)(lVar11 + 72) != 2) && (-1 < *(int *)(lVar11 + 112))) &&
                     (*(int *)(lVar11 + 112) != *(int *)(hero + 132))) {
                    lVar12 = AreaData.GetForce(lVar11,0);
                    if (lVar12 == null) throw; // [null/range check failed]
                    fVar26 = (float)ForceData.GetForceFavor(lVar12,*(uint32 *)(hero + 132),0);
                    dVar25 = (double)GlobalData.RandomRangeDouble(0,0);
                    if (((double)((fVar26 - 30.0) / 50.0) < dVar25) &&
                       (cVar3 = AreaData.CanReduceState(lVar11,0), cVar3)) {
                      if (lVar9 == null) throw; // [null/range check failed]
                      FUN_181814fa0(lVar9,*(uint32 *)(lVar11 + 16),DAT_181d67a78);
                    }
                  }
                  iVar4 = iVar4 + 1;
                }
                if (lVar9 == null) throw; // [null/range check failed]
                iVar4 = *(int *)(lVar9 + 24);
                if (iVar4 < 1) {
                  if (*(int64 *)(local_f0 + 24) == 0) {
                    uVar8 = new OnTooltipCB(lVar11,DAT_181d6bd98);
                    *(uint64 *)(lVar11 + 24) = uVar8;
                  }
                  FUN_181818fa0(local_e8);
                  iVar5 = iVar5 + 1;
                }
                else {
                  uVar6 = GlobalData.RandomRange(0,iVar4,0,0);
                  local_res10[0] = FUN_1800d6750(lVar9,uVar6,DAT_181d68270);
                  uVar8 = Int32.ToString(local_res10,0);
                  uVar6 = GlobalData.RandomRange(4,7,0);
                  local_100 = new HeroAIData(20,uVar8,uVar6,0);
                  iVar5 = iVar5 + 1;
                }
              }
              break;
            case 21:
              GlobalData.RandomRange(4,7,0);
              local_100 = new HeroAIData();
              break;
            case 22:
              GlobalData.RandomRange(4,7,0);
              local_100 = new HeroAIData();
              break;
            case 23:
              GlobalData.RandomRange(4,7,0);
              local_100 = new HeroAIData();
            }
            lVar9 = local_e8;
          } while (local_100 == 0);
        LAB_1814b0372:
          AIController.SetAIStuff(this,hero,local_100,0,0);
          return;
        }
    }

    // Token : 0x60009D1
    // RVA   : 0x14A30B0   Offset: 0x14A18B0   Length: 0x76
    public void AddAvailableStuffType(List<AIStuffType> availableStuffType, AIStuffType newAIStuffType, int num)
    {
        void AIController.AddAvailableStuffType
                     (uint64 this,int64 availableStuffType,uint32 newAIStuffType,int num)
        {
        int iVar1;
        if (0 < num) {
          iVar1 = 0;
          do {
            if (availableStuffType == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            FUN_181814fa0(availableStuffType,newAIStuffType,DAT_181d53880);
            iVar1 = iVar1 + 1;
          } while (iVar1 < num);
        }
    }

    // Token : 0x60009D2
    // RVA   : 0x14B0FB0   Offset: 0x14AF7B0   Length: 0x4F1
    public void SetAIStuff(HeroData hero, HeroAIData aiData, bool setInteractTarget)
    {
        uint uVar1;
        bool cVar2;
        int iVar3;
        uint uVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        ulong uVar8;
        ulong uVar9;
        ulong uVar10;
        ulong uVar11;
        float fVar12;
        int[] local_res10 = new int[2];
        ulong uVar13;
        ulong in_stack_ffffffffffffff80;
        do {
          cVar2 = AIController.FinishAIStuff(this,hero,0);
          if (cVar2) {
            return;
          }
          if (aiData == null) goto LAB_1814b149c;
          if (*(int *)(aiData + 16) == 13) {
            if (hero == null) goto LAB_1814b149c;
            fVar12 = (float)HeroData.Favor(hero,0,0);
            if (40.0 <= fVar12) {
              iVar3 = *(int *)(hero + 184);
              lVar5 = FUN_18046c0a0(0);
              if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                 (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null)
              goto LAB_1814b149c;
              iVar3 = Mathf.Abs(iVar3 - *(int *)(lVar5 + 184),0);
              if (iVar3 < 3) {
                lVar5 = HeroData.GetBigMapPos(hero,0);
                lVar6 = FUN_18046c0a0(0);
                if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                   ((lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0), lVar6 == null ||
                    (uVar7 = HeroData.GetBigMapPos(lVar6,0), lVar5 == null)))) {
        LAB_1814b149c:
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                fVar12 = (float)BigMapPos.Distance(lVar5,uVar7,0);
                if (fVar12 <= *(float *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x114) * 200.0 *
                              (float)(*(int *)(aiData + 32) + -1)) {
                  lVar5 = FUN_18046c300(0);
                  uVar7 = *(uint64 *)(hero + 104);
                  uVar8 = HeroData.AtAreaName(hero,0);
                  uVar10 = "我在{0}{1}，若#PlayerName#能在{2}日内赶来助阵，必当感激不尽！";
                  uVar11 = "遭到贼人袭击";
                  if (!setInteractTarget) {
                    uVar11 = "寻得仇家踪迹";
                  }
                  local_res10[0] = *(int *)(aiData + 32) + -1;
                  uVar9 = il2cpp_value_box(DAT_181d5b2f8,local_res10);
                  uVar13 = 0;
                  uVar10 = String.Format(uVar10,uVar8,uVar11,uVar9,0);
                  uVar11 = il2cpp_internal(DAT_181d62770);
                  MailData.ctor(uVar11,uVar7,uVar10,0,uVar13 & 0xffffffffffffff00,
                                 in_stack_ffffffffffffff80 & 0xffffffffffffff00,0);
                  if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  InfoController.AddMail(lVar5,uVar11,0);
                }
              }
            }
          }
          if (setInteractTarget) {
            *(uint32 *)(aiData + 32) = 99;
          }
          if (hero == null) goto LAB_1814b149c;
          HeroData.SetHeroAIData(hero,aiData,0);
          if (setInteractTarget) {
            return;
          }
          lVar5 = *(int64 *)(*(int64 *)(DAT_181d84cc0 + 184) + 8);
          if ((*(int64 *)(hero + 64) == 0) || (lVar5 == null)) goto LAB_1814b149c;
          cVar2 = FUN_181815240(lVar5,*(uint32 *)(*(int64 *)(hero + 64) + 16),DAT_181d53900)
          ;
          if (!cVar2) {
            return;
          }
          lVar5 = FUN_18046c0a0(0);
          if (lVar5 == null) goto LAB_1814b149c;
          lVar5 = *(int64 *)(lVar5 + 32);
          uVar4 = Int32.Parse(*(uint64 *)(aiData + 24),0);
          if (lVar5 == null) goto LAB_1814b149c;
          lVar5 = WorldData.GetHero(lVar5,uVar4,0);
          if (lVar5 == null) {
            return;
          }
          lVar5 = FUN_18046c0a0(0);
          if (lVar5 == null) goto LAB_1814b149c;
          lVar5 = *(int64 *)(lVar5 + 32);
          uVar4 = Int32.Parse(*(uint64 *)(aiData + 24),0);
          if (lVar5 == null) goto LAB_1814b149c;
          lVar5 = WorldData.GetHero(lVar5,uVar4,0);
          uVar4 = *(uint32 *)(aiData + 16);
          uVar7 = Int32.ToString(hero + 88,0);
          uVar1 = *(uint32 *)(aiData + 32);
          aiData = il2cpp_internal(DAT_181d50d80);
          in_stack_ffffffffffffff80 = 0;
          HeroAIData.ctor(aiData,uVar4,uVar7,uVar1,1,0);
          setInteractTarget = true;
          hero = lVar5;
        } while( true );
    }

    // Token : 0x60009D3
    // RVA   : 0x14A3130   Offset: 0x14A1930   Length: 0xB63
    public void AutoManageTag(HeroData targetHero)
    {
        ulong uVar2;
        bool cVar3;
        int iVar4;
        int iVar5;
        int iVar6;
        uint uVar7;
        uint uVar8;
        long lVar9;
        long lVar10;
        long lVar11;
        long lVar12;
        long lVar13;
        long lVar14;
        int iVar15;
        uint32 extraout_XMM0_Da;
        float fVar16;
        uint32 local_68;
        uint32 uStack_64;
        uint32 uStack_60;
        uint32 uStack_5c;
        int64 local_58;
        uint32 local_50;
        uint32 uStack_4c;
        uint32 uStack_48;
        uint32 uStack_44;
        int64 local_40;
        lVar9 = new c.DisplayClass9_0(0);
        if (lVar9 != null) {
          *(uint64 *)(lVar9 + 16) = targetHero;
          lVar10 = il2cpp_internal(DAT_181d6f030);
          FUN_180f58a90(lVar10,DAT_181d678f8);
          lVar11 = il2cpp_internal(DAT_181d6f030);
          FUN_180f58a90(lVar11,DAT_181d678f8);
          lVar12 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
          if (((lVar12 != null) && (lVar12 = *(int64 *)(lVar12 + 0x198)) != null) &&
             (lVar12 = FUN_1808acf30(lVar12,DAT_181d94d28)) != null) {
            ValueCollection.GetEnumerator(&local_50,lVar12,DAT_181d56b68);
            local_68 = local_50;
            uStack_64 = uStack_4c;
            uStack_60 = uStack_48;
            uStack_5c = uStack_44;
            local_58 = local_40;
        LAB_1814a33f1:
            cVar3 = FUN_1811d7520(&local_68,DAT_181d72438);
            lVar12 = local_58;
            if (cVar3) {
              lVar13 = *(int64 *)(*(int64 *)(DAT_181d627f0 + 184) + 8);
              if (lVar12 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if (lVar13 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              cVar3 = FUN_1818279a0(lVar13,*(uint64 *)(lVar12 + 80));
              if ((cVar3) && (0 < *(int *)(lVar12 + 32))) {
                bVar1 = true;
                if (*(int64 *)(lVar9 + 16) == 0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                iVar4 = HeroData.GetHeroPermanentTagNum(*(int64 *)(lVar9 + 16),0);
                if (*(int64 *)(lVar9 + 16) == 0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                iVar5 = HeroData.GetMaxTagNum(*(int64 *)(lVar9 + 16),0);
                if (iVar5 <= iVar4) {
                  if (*(int64 *)(lVar12 + 72) == 0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  iVar4 = *(int *)(*(int64 *)(lVar12 + 72) + 24);
                  bVar1 = 0 < iVar4;
                  if (iVar4 < 1) goto LAB_1814a33f1;
                }
                iVar4 = 0;
                while( true ) {
                  if (*(int64 *)(lVar9 + 16) == 0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  lVar13 = *(int64 *)(*(int64 *)(lVar9 + 16) + 0x368);
                  if (lVar13 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  if (*(int *)(lVar13 + 24) <= iVar4) break;
                  iVar5 = *(int *)(lVar12 + 16);
                  lVar13 = FUN_180002f80(lVar13,iVar4);
                  if (lVar13 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  if (iVar5 == *(int *)(lVar13 + 16)) goto LAB_1814a33f1;
                  cVar3 = String.op_Inequality(*(uint64 *)(lVar12 + 40),"");
                  if (cVar3) {
                    if (*(int64 *)(lVar9 + 16) == 0) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    lVar13 = *(int64 *)(*(int64 *)(lVar9 + 16) + 0x368);
                    if (lVar13 == null) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    lVar13 = FUN_180002f80(lVar13,iVar4);
                    if (lVar13 == null) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    lVar13 = HeroTagData.DataBase(lVar13,0);
                    if (lVar13 == null) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    cVar3 = FUN_1816fd990(*(uint64 *)(lVar13 + 48),*(uint64 *)(lVar12 + 40));
                    if (cVar3) goto LAB_1814a33f1;
                    if (*(int64 *)(lVar9 + 16) == 0) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    lVar13 = *(int64 *)(*(int64 *)(lVar9 + 16) + 0x368);
                    if (lVar13 == null) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    lVar13 = FUN_180002f80(lVar13,iVar4);
                    if (lVar13 == null) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    lVar13 = HeroTagData.DataBase(lVar13,0);
                    if (lVar13 == null) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    cVar3 = FUN_1816fd990(*(uint64 *)(lVar13 + 40),*(uint64 *)(lVar12 + 40));
                    if (cVar3) {
                      if (*(int64 *)(lVar9 + 16) == 0) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      lVar13 = *(int64 *)(*(int64 *)(lVar9 + 16) + 0x368);
                      if (lVar13 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      lVar13 = FUN_180002f80(lVar13,iVar4);
                      if (lVar13 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      lVar13 = HeroTagData.DataBase(lVar13,0);
                      if (lVar13 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      iVar5 = Mathf.Abs(*(uint32 *)(lVar13 + 32),0);
                      iVar6 = Mathf.Abs(*(uint32 *)(lVar12 + 32),0);
                      if (iVar6 <= iVar5) goto LAB_1814a33f1;
                    }
                  }
                  iVar4 = iVar4 + 1;
                }
                if (bVar1) {
                  lVar13 = FUN_18046c340(0);
                  if (lVar13 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  cVar3 = ManageTagController.CheckMeetCondition(lVar13,*(uint64 *)(lVar9 + 16));
                  if (cVar3) {
                    if (*(int64 *)(lVar12 + 72) == 0) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    if (*(int *)(*(int64 *)(lVar12 + 72) + 24) < 1) {
                      if (lVar11 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620(extraout_XMM0_Da,*(uint32 *)(lVar12 + 16));
                      }
                      FUN_181814fa0(lVar11);
                    }
                    else {
                      if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620(extraout_XMM0_Da,*(uint32 *)(lVar12 + 16));
                      }
                      FUN_181814fa0(lVar10);
                    }
                  }
                }
              }
              goto LAB_1814a33f1;
            }
            ZhSegment.Initialize(&local_68,DAT_181d723b8);
            if (lVar10 != null) {
              iVar4 = *(int *)(lVar10 + 24);
              if (iVar4 < 1) {
                if (lVar11 == null) throw; // [null/range check failed]
                if (*(int *)(lVar11 + 24) < 1) {
                  return;
                }
                lVar10 = il2cpp_internal(DAT_181d6f030);
                FUN_180f58a90(lVar10,DAT_181d678f8);
                for (iVar4 = 0; iVar4 < *(int *)(lVar11 + 24); iVar4 = iVar4 + 1) {
                  lVar12 = FUN_18046c100(0);
                  if (lVar12 == null) throw; // [null/range check failed]
                  lVar12 = *(int64 *)(lVar12 + 0x198);
                  uVar7 = FUN_1800d6750(lVar11,iVar4,DAT_181d68270);
                  if (lVar12 == null) throw; // [null/range check failed]
                  lVar12 = FUN_1817cc780(lVar12,uVar7);
                  iVar5 = 1;
                  if ((lVar12 == null) || (*(int64 *)(lVar12 + 88) == 0)) throw; // [null/range check failed]
                  fVar16 = (float)HeroSpeAddData.Get(*(int64 *)(lVar12 + 88),208);
                  if (0.0 < fVar16) {
        LAB_1814a3a56:
                    lVar13 = *(int64 *)(lVar9 + 16);
                    if (lVar13 == null) throw; // [null/range check failed]
                    if ((*(int *)(lVar13 + 132) == 16) || (*(int *)(lVar13 + 136) == 16)) {
                      iVar6 = 40;
        LAB_1814a3a7a:
                      iVar5 = 0;
                      do {
                        if (lVar10 == null) throw; // [null/range check failed]
                        FUN_181814fa0(lVar10,*(uint32 *)(lVar12 + 16));
                        iVar5 = iVar5 + 1;
                      } while (iVar5 < iVar6);
                    }
                  }
                  else {
                    if (*(int64 *)(lVar12 + 88) == 0) throw; // [null/range check failed]
                    fVar16 = (float)HeroSpeAddData.Get(*(int64 *)(lVar12 + 88),210);
                    if (0.0 < fVar16) goto LAB_1814a3a56;
                    if (*(int64 *)(lVar12 + 88) == 0) throw; // [null/range check failed]
                    fVar16 = (float)HeroSpeAddData.Get(*(int64 *)(lVar12 + 88),209);
                    if (0.0 < fVar16) goto LAB_1814a3a56;
                    lVar13 = il2cpp_internal(DAT_181d6f030);
                    FUN_180f58a90(lVar13,DAT_181d678f8);
                    if (lVar13 == null) throw; // [null/range check failed]
                    FUN_181814fa0(lVar13,0,DAT_181d67a78);
                    FUN_181814fa0(lVar13,1,DAT_181d67a78);
                    FUN_181814fa0(lVar13,2,DAT_181d67a78);
                    FUN_181814fa0(lVar13,3,DAT_181d67a78);
                    FUN_181814fa0(lVar13,4,DAT_181d67a78);
                    FUN_181814fa0(lVar13,5,DAT_181d67a78);
                    lVar14 = *(int64 *)(lVar9 + 24);
                    if (lVar14 == null) {
                      lVar14 = new OnTooltipCB(lVar9,DAT_181d6be18);
                      *(int64 *)(lVar9 + 24) = lVar14;
                    }
                    List_1.Sort(lVar13,lVar14,DAT_181d68070);
                    iVar15 = 0;
                    iVar6 = 10;
                    do {
                      lVar14 = *(int64 *)(lVar12 + 88);
                      uVar7 = FUN_1800d6750(lVar13,iVar15);
                      if (lVar14 == null) throw; // [null/range check failed]
                      fVar16 = (float)HeroSpeAddData.Get(lVar14,uVar7);
                      if ((0.0 < fVar16) &&
                         (cVar3 = FUN_1816fd990(*(uint64 *)(lVar12 + 80),"战法"),
                         !cVar3)) {
                        cVar3 = FUN_1816fd990(*(uint64 *)(lVar12 + 80),"天生");
                        if (!cVar3) {
                          iVar5 = iVar5 + 15;
                        }
                        iVar5 = iVar5 + iVar6;
                      }
                      iVar15 = iVar15 + 1;
                      iVar6 = iVar6 + -5;
                    } while (-5 < iVar6);
                    iVar15 = 0;
                    while( true ) {
                      iVar6 = iVar5;
                      if ((*(int64 *)(lVar9 + 16) == 0) ||
                         (lVar13 = *(int64 *)(*(int64 *)(lVar9 + 16) + 0x108)) == null)
                      throw; // [null/range check failed]
                      if (*(int *)(lVar13 + 24) <= iVar15) break;
                      lVar14 = *(int64 *)(lVar12 + 88);
                      iVar5 = FUN_1800d6750(lVar13,iVar15);
                      if (lVar14 == null) throw; // [null/range check failed]
                      iVar15 = iVar15 + 1;
                      fVar16 = (float)HeroSpeAddData.Get(lVar14,iVar5 + 6);
                      iVar5 = iVar6 + 20;
                      if (fVar16 <= 0.0) {
                        iVar5 = iVar6;
                      }
                    }
                    if (0 < iVar6) goto LAB_1814a3a7a;
                  }
                }
                if (lVar10 == null) throw; // [null/range check failed]
                uVar7 = *(uint32 *)(lVar10 + 24);
                uVar7 = GlobalData.RandomRange(0,uVar7,0,0);
                iVar4 = FUN_1800d6750(lVar10,uVar7,DAT_181d68270);
              }
              else {
                uVar8 = GlobalData.RandomRange(0,iVar4,0,0);
                if (*(uint32 *)(lVar10 + 24) <= uVar8) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                iVar4 = lVar10[uVar8];
              }
              if (iVar4 < 0) {
                return;
              }
              lVar10 = *(int64 *)(lVar9 + 16);
              lVar11 = FUN_18046c100(0);
              if ((((lVar11 != null) && (*(int64 *)(lVar11 + 0x198) != 0)) &&
                  (lVar11 = FUN_1817cc780(*(int64 *)(lVar11 + 0x198),iVar4,DAT_181d94ca0)) != null
                  ) && (uVar2 = HeroTagDataBase.GetCostValue(lVar11,0,0), lVar10 != null)) {
                HeroData.ChangeTagPoint(lVar10,uVar2 ^ 0x8000000080000000,0,0);
                if (*(int64 *)(lVar9 + 16) != 0) {
                  HeroData.UnderstandTag(*(int64 *)(lVar9 + 16),iVar4,0,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x60009D4
    // RVA   : 0x14A43F0   Offset: 0x14A2BF0   Length: 0x68EC
    public bool FinishAIStuff(HeroData hero)
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        int iVar1;
        bool cVar4;
        int iVar5;
        uint uVar6;
        uint uVar7;
        ulong uVar8;
        ulong uVar9;
        long lVar10;
        ulong uVar11;
        long lVar13;
        ulong uVar14;
        long lVar15;
        long lVar16;
        long lVar17;
        ulong uVar18;
        uint uVar19;
        int iVar20;
        ulong uVar21;
        uint uVar22;
        float fVar23;
        float fVar24;
        float fVar25;
        double dVar26;
        byte[] auVar27 = new byte[16];
        byte[] auVar28 = new byte[16];
        float fVar29;
        float fVar30;
        float fVar31;
        ulong local_res10;
        ulong in_stack_fffffffffffffe88;
        ulong in_stack_fffffffffffffe90;
        ulong in_stack_fffffffffffffe98;
        ulong in_stack_fffffffffffffea0;
        uint uVar35;
        ulong uVar34;
        ulong in_stack_fffffffffffffea8;
        uint uVar37;
        ulong uVar36;
        uint local_148;
        bool local_144;
        int local_140;
        uint32 local_13c;
        float local_138;
        uint32 local_134;
        uint64 local_130;
        int64 local_128;
        uint32 local_120;
        uint32 local_11c;
        int local_118;
        int local_114;
        uint32 local_110;
        uint32 local_10c;
        uint32 local_108;
        uint32 local_104;
        int local_100;
        int local_fc;
        int local_f8;
        int local_f4;
        int local_f0;
        int local_ec;
        int local_e8;
        int local_e4;
        int local_e0 [38];
        uint64 extraout_XMM0_Qb;
        uVar18 = 0;
        uVar21 = 0;
        fVar31 = 0.0;
        local_13c = 0;
        local_134 = 0;
        local_140 = 0;
        local_138 = 0.0;
        if ((hero == null) || (lVar15 = *(int64 *)(hero + 64)) == null) goto LAB_1814aac56;
        if (*(int *)(lVar15 + 16) == 16) {
          HeroData.GoOutPrison(hero,0);
          uVar8 = HeroData.Name(hero,1,0);
          uVar9 = HeroData.AtAreaName(hero,0);
          uVar8 = String.Format("{0}在{1}结束关押，恢复了自由之身。",uVar8,uVar9,0);
          HeroData.AddLog(hero,uVar8,0);
          lVar15 = *(int64 *)(hero + 64);
        }
        uVar14 = "";
        fVar30 = 0.0;
        bVar3 = false;
        local_148 = 0;
        if (lVar15 == null) goto LAB_1814aac56;
        if (*(int *)(lVar15 + 36) < 1) goto switchD_1814a4990_caseD_0;
        lVar10 = new c.DisplayClass9_0(0);
        uVar11 = "";
        uVar6 = (uint32)((uint64)in_stack_fffffffffffffe98 >> 32);
        uVar7 = (uint32)((uint64)in_stack_fffffffffffffea0 >> 32);
        uVar35 = (uint32)((uint64)in_stack_fffffffffffffea8 >> 32);
        lVar15 = *(int64 *)(hero + 64);
        if (lVar15 == null) goto LAB_1814aac56;
        switch(*(uint32 *)(lVar15 + 16)) {
        default:
          goto switchD_1814a4990_caseD_0;
        case 2:
          dVar26 = (double)GlobalData.RandomRangeDouble(0,0);
          if (dVar26 < 0.5) {
            dVar26 = (double)GlobalData.RandomRangeDouble(0,0);
            fVar31 = (float)FUN_1801f7f00();
            if (*(int64 *)(hero + 64) == 0) goto LAB_1814aac56;
            uVar6 = Mathf.RoundToInt(((float)dVar26 + (float)dVar26 + 1.0) * fVar31 *
                                      (float)*(int *)(*(int64 *)(hero + 64) + 36),0);
            local_148 = Mathf.Max(1,uVar6);
            HeroData.ChangeMoney(hero,local_148,0,0);
            uVar9 = HeroData.Name(hero,1,0);
            uVar34 = HeroData.AtAreaName(hero,0);
            local_120 = local_148;
            uVar36 = il2cpp_value_box(DAT_181d5b2f8,&local_120);
            uVar8 = "{0}在{1}闲逛之时，意外获取了{2}两银钱。";
          }
          else {
            lVar10 = FUN_18046c0a0(0);
            lVar15 = *(int64 *)(hero + 64);
            if (lVar15 == null) goto LAB_1814aac56;
            Mathf.Min(lVar15,(float)*(int *)(lVar15 + 36) * 0.2,0);
            GlobalData.RandomRange();
            HeroData.GetHeroItemLv(hero,0,0);
            if (lVar10 == null) goto LAB_1814aac56;
            uVar8 = 0;
            lVar15 = hero;
            lVar10 = GameController.GenerateRandomItem(lVar10);
            HeroData.GetItem(hero,lVar10,0,0,lVar15,uVar8);
            uVar9 = HeroData.Name(hero,1,0);
            uVar34 = HeroData.AtAreaName(hero,0);
            if (lVar10 == null) goto LAB_1814aac56;
            uVar36 = ItemData.Name(lVar10,1,0);
            uVar8 = "{0}在{1}闲逛之时，意外获取了一件{2}。";
          }
          uVar8 = String.Format(uVar8,uVar9,uVar34,uVar36,0);
          HeroData.AddLog(hero,uVar8,0);
          fVar30 = 0.25;
          break;
        case 5:
          uVar6 = Int32.Parse(*(uint64 *)(lVar15 + 24),0);
          lVar15 = HeroData.FindSkill(hero,uVar6,0);
          if (lVar15 != null) {
            GlobalData.RandomRange(15,26,0);
            if (*(int64 *)(hero + 64) == 0) goto LAB_1814aac56;
            KungfuSkillLvData.FightExpFull(lVar15,0);
            HeroData.GetLoyalExpRate(hero,0);
            uVar8 = 0;
            HeroData.AddSkillBookExp(hero);
            GlobalData.RandomRange(15,26,0,0,uVar8);
            if (*(int64 *)(hero + 64) == 0) goto LAB_1814aac56;
            KungfuSkillLvData.BookExpFull(lVar15,0);
            HeroData.GetLoyalExpRate(hero,0);
            HeroData.AddSkillFightExp(hero);
            uVar8 = HeroData.Name(hero,1,0);
            uVar9 = HeroData.AtAreaName(hero,0);
            uVar34 = KungfuSkillLvData.Name(lVar15,1,0);
            uVar8 = String.Format("{0}在{1}修习了武功{2}。",uVar8,uVar9,uVar34,0);
            HeroData.AddLog(hero,uVar8,0);
            fVar30 = 1.0;
          }
          lVar15 = FUN_18046c0a0(0);
          if (((lVar15 == null) || (*(int64 *)(lVar15 + 32) == 0)) ||
             (lVar15 = *(int64 *)(*(int64 *)(lVar15 + 32) + 168)) == null)
          goto LAB_1814aac56;
          if (((3 < *(int *)(lVar15 + 16)) &&
              (cVar4 = HeroData.IsPlayerSameForce(hero,0), !cVar4)) &&
             (4.0 <= *(float *)(hero + 0x364))) {
            dVar26 = (double)GlobalData.RandomRangeDouble(0,0);
            lVar15 = FUN_18046c0a0(0);
            if ((lVar15 == null) || (*(int64 *)(lVar15 + 32) == 0)) goto LAB_1814aac56;
            fVar31 = (float)WorldData.GetAIForceDevelopSpeed(*(int64 *)(lVar15 + 32),0);
            uVar18 = uVar21;
            if (dVar26 < (double)((fVar31 * 0.05 + 1.0) * 0.1)) {
              AIController.AutoManageTag(this,hero,0);
            }
          }
          goto LAB_1814aabd0;
        case 6:
          uVar6 = Int32.Parse(*(uint64 *)(lVar15 + 24),0);
          iVar20 = GlobalData.RandomRange(30,41,0);
          if (*(int64 *)(hero + 64) == 0) goto LAB_1814aac56;
          iVar5 = *(int *)(*(int64 *)(hero + 64) + 36);
          iVar1 = *(int *)(hero + 184);
          fVar31 = (float)HeroData.GetLoyalExpRate(hero,0);
          HeroData.ChangeLivingSkillExp
                    (hero,uVar6,((float)iVar1 * 0.25 + 1.0) * (float)(iVar5 * iVar20) * fVar31,0,0);
          uVar8 = HeroData.Name(hero,1,0);
          uVar9 = HeroData.AtAreaName(hero,0);
          lVar15 = *(int64 *)(pStatics + 0x4a8);
          if ((*(int64 *)(hero + 64) == 0) ||
             (uVar6 = Int32.Parse(*(uint64 *)(*(int64 *)(hero + 64) + 24),0), lVar15 == null))
          goto LAB_1814aac56;
          uVar34 = FUN_180002f80(lVar15,uVar6,DAT_181d7c9c0);
          uVar8 = String.Format("{0}在{1}修习了{2}技艺。",uVar8,uVar9,uVar34,0);
          HeroData.AddLog(hero,uVar8,0);
          fVar30 = 0.5;
          uVar21 = 0;
          break;
        case 7:
          uVar18 = uVar21;
          if (-1 < *(int *)(hero + 132)) {
            uVar6 = Int32.Parse(*(uint64 *)(lVar15 + 24),0);
            lVar15 = *(int64 *)(pStatics + 0x438);
            if (lVar15 == null) goto LAB_1814aac56;
            uVar7 = FUN_1800d6750(lVar15,uVar6,DAT_181d6b9e8);
            lVar15 = *(int64 *)(pStatics + 0x440);
            if (lVar15 == null) goto LAB_1814aac56;
            fVar31 = (float)FUN_1800d6780(lVar15,uVar6,DAT_181d796d8);
            if (*(int64 *)(hero + 0x168) == 0) goto LAB_1814aac56;
            FUN_1800d6780(*(int64 *)(hero + 0x168),uVar7,DAT_181d796d8);
            HeroData.GetLoyalWorkRate(hero,0);
            if (*(int64 *)(hero + 64) == 0) goto LAB_1814aac56;
            fVar30 = 1.0;
            fVar24 = (float)Mathf.Max();
            lVar15 = HeroData.GetForce(hero,0,0);
            if (lVar15 == null) goto LAB_1814aac56;
            uVar8 = 0;
            ForceData.ChangeResource(lVar15,uVar6);
            HeroData.ChangeLivingSkillExp
                      (hero,uVar7,
                       ((float)*(int *)(hero + 184) * 0.25 + 1.0) * (fVar24 / (10.0 / fVar31)) * 10.0,
                       0,0,uVar8);
            uVar8 = HeroData.Name(hero,1,0);
            uVar9 = HeroData.AtAreaName(hero,0);
            lVar15 = new PlotChoiceRequirement(uVar6);
            if (lVar15 == null) goto LAB_1814aac56;
            uVar34 = ResourceData.GetDescribe(lVar15,0);
            uVar8 = String.Format("{0}在{1}辛勤劳作，为门派收获了{2}。",uVar8,uVar9,uVar34,0);
            HeroData.AddLog(hero,uVar8,0);
            iVar20 = *(int *)(hero + 132);
            lVar15 = FUN_18046c0a0(0);
            if (((lVar15 == null) || (*(int64 *)(lVar15 + 32) == 0)) ||
               (lVar15 = WorldData.Player(*(int64 *)(lVar15 + 32),0)) == null)
            goto LAB_1814aac56;
            if (iVar20 == *(int *)(lVar15 + 132)) {
              lVar15 = FUN_18046c300(0);
              uVar9 = new InfoData(1,uVar8);
              if (lVar15 == null) goto LAB_1814aac56;
              InfoController.AddInfo(lVar15,uVar9,0);
            }
            uVar21 = 0;
            break;
          }
          goto switchD_1814a4990_caseD_0;
        case 8:
          dVar26 = (double)GlobalData.RandomRangeDouble(0,0);
          fVar31 = (float)FUN_1801f7f00();
          if (*(int64 *)(hero + 64) == 0) goto LAB_1814aac56;
          local_148 = Mathf.RoundToInt(((float)dVar26 + (float)dVar26 + 4.0) * fVar31 *
                                        (float)*(int *)(*(int64 *)(hero + 64) + 36),0);
          HeroData.ChangeMoney(hero,local_148,0,0);
          uVar8 = HeroData.Name(hero,1,0);
          uVar9 = HeroData.AtAreaName(hero,0);
          local_11c = local_148;
          uVar34 = il2cpp_value_box(DAT_181d5b2f8,&local_11c);
          uVar8 = String.Format("{0}在{1}打工赚钱，获取了{2}两银钱。",uVar8,uVar9,uVar34,0);
          HeroData.AddLog(hero,uVar8,0);
          fVar30 = 0.1;
          break;
        case 9:
          local_res10 = "";
          local_130 = "";
          lVar15 = HeroData.GetArea(hero,0);
          uVar21 = uVar18;
          if (lVar15 != null) {
            lVar15 = HeroData.GetArea(hero,0);
            if (lVar15 == null) goto LAB_1814aac56;
            if (*(int *)(lVar15 + 72) == 2) {
              lVar15 = HeroData.GetArea(hero,0);
              if ((lVar15 == null) || (lVar15 = AreaData.GetForce(lVar15,0)) == null)
              goto LAB_1814aac56;
              uVar21 = *(uint64 *)(lVar15 + 160);
            }
          }
          iVar20 = 1;
          fVar30 = 0.75;
        LAB_1814a54a0:
          lVar15 = *(int64 *)(hero + 0x220);
          if (lVar15 != null) {
            if (*(float *)(lVar15 + 28) / *(float *)(lVar15 + 32) <= 0.7) {
              GlobalData.RandomRange();
              cVar4 = AIController.CheckHeroItemNumBiggerThanMax(this,hero);
              if (cVar4) goto LAB_1814a5546;
              dVar26 = (double)GlobalData.RandomRangeDouble(0,0);
              if (dVar26 < (double)fVar30) goto LAB_1814a5546;
        LAB_1814a5a67:
              if (*(int *)(hero + 132) < 0) {
        LAB_1814a5a8c:
                if (*(int64 *)(hero + 0x1f8) == 0) goto LAB_1814aac56;
                cVar4 = HeroEquipmentData.HaveEmptyEquipment(*(int64 *)(hero + 0x1f8),0);
                if (!cVar4) {
                  dVar26 = (double)GlobalData.RandomRangeDouble(0,0);
                  uVar18 = local_130;
                  if (0.20000000298023224 <= dVar26) goto LAB_1814a5f4a;
                }
              }
              else {
                lVar15 = HeroData.GetForce(hero,0,0);
                if (lVar15 == null) goto LAB_1814aac56;
                if (*(int *)(lVar15 + 88) != 0) goto LAB_1814a5a8c;
              }
              uVar19 = 0;
              uVar18 = local_130;
              goto LAB_1814a5af0;
            }
        LAB_1814a5546:
            uVar6 = (uint32)(in_stack_fffffffffffffe88 >> 32);
            if (5 < (int)uVar18) goto LAB_1814a5a67;
            dVar26 = (double)GlobalData.RandomRangeDouble(0,0);
            if (0.4000000059604645 < dVar26) {
              dVar26 = (double)GlobalData.RandomRangeDouble(0,0);
              if (0.5 < dVar26) {
                iVar5 = 1;
              }
              else {
                iVar5 = Mathf.Clamp(*(int *)(hero + 184) + -1,1,3);
              }
            }
            else {
              iVar5 = 5;
            }
            in_stack_fffffffffffffe90 = 0;
            in_stack_fffffffffffffe88 = CONCAT44(uVar6,0xffffffff);
            lVar15 = HeroData.FindRandomItem
                               (hero,uVar18,iVar5 + (int)uVar18,0,in_stack_fffffffffffffe88,0);
            while (lVar15 == null) {
              if (5 < (int)uVar18) goto LAB_1814a54a0;
              uVar19 = (int)uVar18 + 1;
              uVar18 = (uint64)uVar19;
              in_stack_fffffffffffffe90 = 0;
              in_stack_fffffffffffffe88 = CONCAT44((int)(in_stack_fffffffffffffe88 >> 32),0xffffffff);
              lVar15 = HeroData.FindRandomItem
                                 (hero,uVar18,uVar19 + iVar5,0,in_stack_fffffffffffffe88,0);
            }
            cVar4 = FUN_1816fd990(uVar11,"",0);
            uVar14 = "/";
            if (cVar4) {
              uVar14 = "";
            }
            if (lVar15 == null) goto LAB_1814aac56;
            uVar8 = ItemData.Name(lVar15,1,0);
            uVar11 = String.Concat(uVar11,uVar14,uVar8);
            local_res10 = uVar11;
            if ((((uVar21 == 0) || (*(int *)(uVar21 + 20) != *(int *)(hero + 132))) ||
                (0.9 <= *(float *)(uVar21 + 28) / *(float *)(uVar21 + 32))) ||
               ((*(int *)(hero + 184) < 5 &&
                (fVar24 = *(float *)(hero + 0x1c0),
                iVar5 = HeroData.GetUpgradeForceLvNeedContribution(hero), (float)iVar5 <= fVar24)))) {
              fVar31 = fVar31 + (float)*(int *)(lVar15 + 56);
              AIController.HeroSellItem(this);
              lVar15 = HeroData.GetArea(hero);
              if (lVar15 != null) {
                lVar15 = HeroData.GetArea(hero);
                if (lVar15 == null) goto LAB_1814aac56;
                if (*(int *)(lVar15 + 72) != 2) {
                  lVar15 = il2cpp_internal(DAT_181d6c0b0);
                  FUN_180f58a90(lVar15);
                  iVar5 = 0;
                  while( true ) {
                    lVar10 = HeroData.GetArea(hero);
                    if ((lVar10 == null) || (*(int64 *)(lVar10 + 192) == 0)) goto LAB_1814aac56;
                    if (*(int *)(*(int64 *)(lVar10 + 192) + 24) <= iVar5) break;
                    lVar10 = HeroData.GetArea(hero,0);
                    if ((lVar10 == null) || (*(int64 *)(lVar10 + 192) == 0)) goto LAB_1814aac56;
                    lVar10 = FUN_180002f80();
                    if (lVar10 != null) {
                      lVar10 = HeroData.GetArea(hero,0);
                      if (((lVar10 == null) || (*(int64 *)(lVar10 + 192) == 0)) ||
                         (lVar10 = FUN_180002f80()) == null) goto LAB_1814aac56;
                      if (*(int64 *)(lVar10 + 40) != 0) {
                        lVar10 = HeroData.GetArea(hero,0);
                        if (((lVar10 == null) || (*(int64 *)(lVar10 + 192) == 0)) ||
                           ((lVar10 = FUN_180002f80(), lVar10 == null || (*(int64 *)(lVar10 + 40) == 0))
                           )) goto LAB_1814aac56;
                        lVar10 = AreaBuildingData.DataBase();
                        if (lVar10 != null) {
                          lVar10 = HeroData.GetArea(hero,0);
                          if (((lVar10 == null) || (*(int64 *)(lVar10 + 192) == 0)) ||
                             ((lVar10 = FUN_180002f80(), lVar10 == null ||
                              ((*(int64 *)(lVar10 + 40) == 0 ||
                               (lVar10 = AreaBuildingData.DataBase()) == null)))))
                          goto LAB_1814aac56;
                          if (*(int64 *)(lVar10 + 136) != 0) {
                            lVar10 = HeroData.GetArea(hero,0);
                            if ((((((lVar10 == null) || (*(int64 *)(lVar10 + 192) == 0)) ||
                                  (lVar10 = FUN_180002f80(*(int64 *)(lVar10 + 192),iVar5,DAT_181d554e0
                                                         ), lVar10 == null)) ||
                                 ((*(int64 *)(lVar10 + 40) == 0 ||
                                  (lVar10 = AreaBuildingData.DataBase(*(int64 *)(lVar10 + 40),0),
                                  lVar10 == null)))) || (*(int64 *)(lVar10 + 136) == 0)) ||
                               (*(int64 *)(*(int64 *)(lVar10 + 136) + 32) == 0))
                            goto LAB_1814aac56;
                            cVar4 = FUN_181815240();
                            if (cVar4) {
                              lVar10 = HeroData.GetArea(hero,0);
                              if (((lVar10 == null) || (*(int64 *)(lVar10 + 192) == 0)) ||
                                 ((lVar10 = FUN_180002f80(*(int64 *)(lVar10 + 192),iVar5,DAT_181d554e0
                                                         ), lVar10 == null || (lVar15 == null))))
                              goto LAB_1814aac56;
                              FUN_181827900(lVar15);
                            }
                          }
                        }
                      }
                    }
                    iVar5 = iVar5 + 1;
                  }
                  if (lVar15 == null) goto LAB_1814aac56;
                  iVar5 = *(int *)(lVar15 + 24);
                  if (0 < iVar5) {
                    uVar6 = GlobalData.RandomRange(0,iVar5,0);
                    lVar15 = FUN_180002f80(lVar15,uVar6);
                    if ((lVar15 == null) || (*(int64 *)(lVar15 + 40) == 0)) goto LAB_1814aac56;
                    ItemListData.GetItem();
                  }
                }
              }
              fVar30 = fVar30 * 0.75;
            }
            else {
              in_stack_fffffffffffffe88 = 0;
              AIController.HeroDonateItemToForceStorage(this,hero,lVar15,uVar21,0);
              fVar30 = fVar30 * 0.75;
            }
            goto LAB_1814a54a0;
          }
          goto LAB_1814aac56;
        case 10:
          lVar10 = FUN_18046c0a0(0);
          lVar15 = *(int64 *)(hero + 64);
          if (lVar15 == null) goto LAB_1814aac56;
          Mathf.Min(lVar15,(float)*(int *)(lVar15 + 36) * 0.25,0);
          GlobalData.RandomRange();
          HeroData.GetHeroItemLv(hero,0,0);
          if (lVar10 == null) goto LAB_1814aac56;
          uVar8 = 0;
          lVar15 = hero;
          lVar10 = GameController.GenerateRandomItem(lVar10);
          HeroData.GetItem(hero,lVar10,0,0,lVar15,uVar8);
          uVar8 = HeroData.Name(hero,1,0);
          uVar9 = HeroData.AtAreaName(hero,0);
          if (lVar10 == null) goto LAB_1814aac56;
          uVar34 = ItemData.Name(lVar10,1,0);
          uVar8 = String.Format("{0}在{1}四下探索之时，意外发现了{2}。",uVar8,uVar9,uVar34,0);
          HeroData.AddLog(hero,uVar8,0);
          fVar30 = 0.75;
          break;
        case 11:
          lVar15 = FUN_18046c0a0(0);
          if (lVar15 == null) goto LAB_1814aac56;
          lVar15 = *(int64 *)(lVar15 + 32);
          if ((*(int64 *)(hero + 64) == 0) ||
             (uVar6 = Int32.Parse(*(uint64 *)(*(int64 *)(hero + 64) + 24),0), lVar15 == null))
          goto LAB_1814aac56;
          lVar15 = WorldData.GetHero(lVar15,uVar6,0);
          uVar18 = uVar21;
          if (lVar15 == null) goto switchD_1814a4990_caseD_0;
          HeroData.ResetAI(lVar15,0);
          if (*(int64 *)(hero + 0x2b8) == 0) goto LAB_1814aac56;
          fVar31 = (float)HeroSpeAddData.Get(*(int64 *)(hero + 0x2b8),212,0);
          if (*(int64 *)(lVar15 + 0x2b8) == 0) goto LAB_1814aac56;
          fVar30 = (float)HeroSpeAddData.Get(*(int64 *)(lVar15 + 0x2b8),212,0);
          fVar30 = fVar30 + fVar31 + 1.0;
          cVar4 = HeroData.HaveFriend(hero,*(uint32 *)(lVar15 + 88),0);
          if ((!cVar4) &&
             ((*(char *)(hero + 92) == false || (*(char *)(lVar15 + 92) == false)))) {
            dVar26 = (double)GlobalData.RandomRangeDouble(0,0);
            fVar31 = (float)HeroData.GetStartFavor(hero,lVar15,0);
            if ((double)((fVar31 * 0.005 + 0.15) * fVar30) <= dVar26) goto LAB_1814a73a6;
            AIController.AICheckRemoveFriend(this,hero,0);
            AIController.AICheckRemoveFriend(this,lVar15,0);
            HeroData.AddFriend(hero,*(uint32 *)(lVar15 + 88),0,0);
            uVar9 = HeroData.GetHeroName(hero,0,0);
            uVar34 = HeroData.AtAreaName(hero,0);
            uVar36 = HeroData.GetHeroName(lVar15,0,0);
            uVar8 = "{0}在{1}与{2}相谈盛欢，一见如故，结为知己好友。";
          }
          else {
        LAB_1814a73a6:
            dVar26 = (double)GlobalData.RandomRangeDouble(0,0);
            fVar31 = (float)HeroData.GetStartFavor(hero,lVar15,0);
            fVar30 = 1.0 / fVar30;
            cVar4 = HeroData.HaveHater(hero,*(uint32 *)(lVar15 + 88),0);
            if (!cVar4) {
              fVar24 = 1.0;
            }
            else {
              fVar24 = 4.0;
            }
            fVar25 = 0.5;
            if ((*(int *)(hero + 132) < 0) || (*(int *)(hero + 132) != *(int *)(lVar15 + 132))) {
              fVar29 = 1.0;
            }
            else {
              fVar29 = 0.5;
            }
            cVar4 = HeroData.HaveFriend(hero,*(uint32 *)(lVar15 + 88),0);
            if (!cVar4) {
              fVar25 = 1.0;
            }
            uVar8 = 0;
            cVar4 = HeroData.HaveRelationBetterThanFriend(hero,*(uint32 *)(lVar15 + 88),0,1,0);
            if (!cVar4) {
              fVar23 = 1.0;
            }
            else {
              fVar23 = 0.25;
            }
            if (dVar26 < (double)(fVar23 * fVar24 * (0.15 - fVar31 * 0.005) * fVar30 * fVar29 * fVar25)) {
              dVar26 = (double)GlobalData.RandomRangeDouble(0,0);
              lVar10 = lVar15;
              lVar17 = hero;
              if ((double)(*(float *)(hero + 0x1d0) /
                          (*(float *)(hero + 0x1d0) + *(float *)(lVar15 + 0x1d0))) < dVar26) {
                lVar10 = hero;
                lVar17 = lVar15;
              }
              if (**(int **)(DAT_181d4ef00 + 184) != 2) {
                dVar26 = (double)GlobalData.RandomRangeDouble(0,0);
                fVar31 = (float)HeroData.GetFightScore(lVar17,1,0);
                fVar24 = (float)HeroData.GetFightScore(lVar17,1);
                fVar25 = (float)HeroData.GetFightScore(lVar10,1);
                bVar2 = dVar26 <= (double)(fVar31 / (fVar25 + fVar24));
                cVar4 = HeroData.IsPlayerSameForce(lVar17,0);
                if ((!cVar4) || (uVar9 = 3, *(int *)(lVar17 + 0x374) == 0)) {
                  uVar9 = 4;
                }
                iVar20 = GlobalData.RandomRange(0,uVar9,0,0);
                if (iVar20 == 0) {
                  if (bVar2) {
                    HeroData.ChangeBadFame(lVar17);
                    if (*(int64 *)(lVar17 + 0x168) == 0) goto LAB_1814aac56;
                    FUN_1800d6780(*(int64 *)(lVar17 + 0x168),1,DAT_181d796d8);
                    if (*(int64 *)(lVar10 + 0x168) == 0) goto LAB_1814aac56;
                    FUN_1800d6780(*(int64 *)(lVar10 + 0x168),1,DAT_181d796d8);
                    fVar31 = (float)FUN_1810a8ba0();
                    uVar8 = 0;
                    HeroData.ChangePoisonInjury(lVar10);
                    HeroData.ChangeLivingSkillExp
                              (lVar17,1,((float)*(int *)(hero + 184) * 0.25 + 1.0) * fVar31 * 50.0,0,0
                               ,uVar8);
                  }
                  else {
                    HeroData.ChangeBadFame(lVar17);
                  }
                  lVar16 = FUN_1800d60b0(DAT_181d7f180,4);
                  uVar8 = HeroData.GetHeroName(lVar17,0,0);
                  if (lVar16 == null) goto LAB_1814aac56;
                  FUN_180002070(lVar16,uVar8);
                  FUN_180002fd0(lVar16,0,uVar8);
                  uVar8 = HeroData.AtAreaName(lVar17,0);
                  FUN_180002070(lVar16,uVar8);
                  FUN_180002fd0(lVar16,1,uVar8);
                  uVar8 = HeroData.GetHeroName(lVar10,0,0);
                  FUN_180002070(lVar16,uVar8);
                  FUN_180002fd0(lVar16,2,uVar8);
                  uVar8 = "{0}在{1}欲下毒暗害{2}，{3}。";
                  uVar9 = "最终未能得逞";
                  if (bVar2) {
                    local_10c = Mathf.RoundToInt();
                    uVar9 = il2cpp_value_box(DAT_181d5b2f8,&local_10c);
                    uVar9 = String.Format("使其中毒加深{0}点",uVar9,0);
                  }
                  FUN_180002070(lVar16,uVar9);
                  uVar34 = 3;
                }
                else if ((iVar20 == 1) || (iVar20 == 2)) {
                  dVar26 = (double)GlobalData.RandomRangeDouble(0,0);
                  local_144 = dVar26 <= 0.5;
                  lVar16 = 0;
                  local_128 = 0;
                  dVar26 = (double)GlobalData.RandomRangeDouble(0,0);
                  if (dVar26 <= 0.75) {
                    uVar7 = (uint32)((uint64)uVar8 >> 32);
                    dVar26 = (double)GlobalData.RandomRangeDouble(0,0);
                    uVar6 = 999999;
                    if (0.05000000074505806 <= dVar26) {
                      uVar6 = *(uint32 *)(lVar17 + 184);
                    }
                    uVar8 = CONCAT44(uVar7,0xffffffff);
                    lVar16 = HeroData.FindRandomItem(lVar10,0xffffffff,uVar6,0,uVar8,0);
                    local_128 = lVar16;
                  }
                  if (*(int64 *)(lVar10 + 0x220) == 0) goto LAB_1814aac56;
                  local_130 = CONCAT44(local_130._4_4_,
                                       *(uint32 *)(*(int64 *)(lVar10 + 0x220) + 24));
                  fVar31 = (float)GlobalData.RandomRange();
                  auVar27._0_8_ = FUN_1801f7f00();
                  auVar27._8_8_ = extraout_XMM0_Qb;
                  auVar28._4_12_ = auVar27._4_12_;
                  auVar28._0_4_ = (float)auVar27._0_8_ * fVar31 * 50.0;
                  uVar6 = Mathf.RoundToInt(auVar28._0_8_,0);
                  local_148 = Mathf.Min(local_130 & 0xffffffff,uVar6,0);
                  uVar32 = (uint7)((uint64)uVar8 >> 8);
                  if (bVar2) {
                    if (lVar16 == null) {
                      lVar13 = (uint64)uVar32 << 8;
                      HeroData.ChangeBadFame(lVar17);
                      HeroData.ChangeMoney(lVar10,-local_148,0,0,lVar13,lVar16);
                      HeroData.ChangeMoney(lVar17,local_148,0,0);
                    }
                    else {
                      uVar8 = 0;
                      lVar13 = (uint64)uVar32 << 8;
                      HeroData.ChangeBadFame(lVar17);
                      HeroData.LoseItem(lVar10,lVar16,0,0,lVar13,uVar8);
                      HeroData.GetItem(lVar17,lVar16,0,0);
                    }
                  }
                  else {
                    HeroData.ChangeBadFame(lVar17);
                  }
                  lVar16 = FUN_1800d60b0(DAT_181d7f180,6);
                  uVar8 = HeroData.GetHeroName(lVar17,0,0);
                  if (lVar16 == null) goto LAB_1814aac56;
                  FUN_180002070(lVar16,uVar8);
                  FUN_180002fd0(lVar16,0,uVar8);
                  uVar8 = HeroData.AtAreaName(lVar17,0);
                  FUN_180002070(lVar16,uVar8);
                  FUN_180002fd0(lVar16,1,uVar8);
                  uVar8 = HeroData.GetHeroName(lVar10,0,0);
                  FUN_180002070(lVar16,uVar8);
                  FUN_180002fd0(lVar16,2,uVar8);
                  uVar8 = "{0}在{1}欲{5}{2}的{3}，{4}。";
                  if (local_128 == 0) {
                    local_110 = local_148;
                    uVar9 = il2cpp_value_box(DAT_181d5b2f8,&local_110);
                    uVar9 = String.Format("{0}银两",uVar9,0);
                  }
                  else {
                    uVar9 = ItemData.Name(local_128,1,0);
                  }
                  FUN_180002070(lVar16,uVar9);
                  FUN_180002fd0(lVar16,3,uVar9);
                  uVar9 = "最终未能得逞";
                  if (bVar2) {
                    uVar9 = "最终成功得手";
                  }
                  FUN_180002070(lVar16,uVar9);
                  FUN_180002fd0(lVar16,4,uVar9);
                  uVar9 = "抢夺";
                  if (local_144) {
                    uVar9 = "窃取";
                  }
                  FUN_180002070(lVar16,uVar9);
                  uVar34 = 5;
                }
                else {
                  if (iVar20 != 3) goto LAB_1814a7e37;
                  dVar26 = (double)GlobalData.RandomRangeDouble(0,0);
                  uVar6 = 999999;
                  if (0.05000000074505806 <= dVar26) {
                    uVar6 = *(uint32 *)(lVar17 + 184);
                  }
                  lVar16 = HeroData.FindRandomSkill(lVar10,uVar6,lVar17,0);
                  local_128 = lVar16;
                  if ((bVar2) && (lVar16 != null)) {
                    lVar13 = KungfuSkillLvData.DataBase(lVar16,0);
                    if (lVar13 == null) goto LAB_1814aac56;
                    uVar9 = 0;
                    HeroData.ChangeBadFame(lVar17);
                    uVar6 = *(uint32 *)(lVar16 + 16);
                    uVar8 = new KungfuSkillLvData(uVar6,0);
                    HeroData.GetSkill(lVar17,uVar8,0,0,0,uVar9);
                  }
                  else {
                    bVar2 = false;
                    HeroData.ChangeBadFame(lVar17);
                  }
                  lVar16 = FUN_1800d60b0(DAT_181d7f180,5);
                  uVar8 = HeroData.GetHeroName(lVar17,0,0);
                  if (lVar16 == null) goto LAB_1814aac56;
                  FUN_180002070(lVar16,uVar8);
                  FUN_180002fd0(lVar16,0,uVar8);
                  uVar8 = HeroData.AtAreaName(lVar17,0);
                  FUN_180002070(lVar16,uVar8);
                  FUN_180002fd0(lVar16,1,uVar8);
                  uVar8 = HeroData.GetHeroName(lVar10,0,0);
                  FUN_180002070(lVar16,uVar8);
                  FUN_180002fd0(lVar16,2,uVar8);
                  uVar8 = "{0}在{1}欲偷师{2}的{3}，{4}。";
                  uVar9 = "武学";
                  if (local_128 != 0) {
                    uVar9 = KungfuSkillLvData.Name(local_128,1,0);
                  }
                  FUN_180002070(lVar16,uVar9);
                  FUN_180002fd0(lVar16,3,uVar9);
                  uVar9 = "最终未能得逞";
                  if (bVar2) {
                    uVar9 = "最终成功得手";
                  }
                  FUN_180002070(lVar16,uVar9);
                  uVar34 = 4;
                }
                FUN_180002fd0(lVar16,uVar34,uVar9);
                uVar14 = String.Format(uVar8,lVar16,0);
              }
        LAB_1814a7e37:
              cVar4 = HeroData.HaveHater(hero,*(uint32 *)(lVar15 + 88),0);
              if ((!cVar4) &&
                 ((*(char *)(hero + 92) == false || (*(char *)(lVar15 + 92) == false)))) {
                dVar26 = (double)GlobalData.RandomRangeDouble(0,0);
                fVar31 = (float)HeroData.GetStartFavor(hero,lVar15,0);
                if (dVar26 < (double)((0.3 - fVar31 * 0.01) * fVar30)) {
                  AIController.AICheckRemoveHater(this,hero,0);
                  AIController.AICheckRemoveHater(this,lVar15,0);
                  HeroData.AddHater(hero,*(uint32 *)(lVar15 + 88),0,0);
                  if (**(int **)(DAT_181d4ef00 + 184) == 2) {
                    uVar8 = HeroData.GetHeroName(hero,0);
                    uVar9 = HeroData.AtAreaName(hero,0);
                    uVar34 = HeroData.GetHeroName(lVar15,0,0);
                    uVar14 = String.Format("{0}在{1}与{2}心生嫌隙，结下了深仇大恨。",uVar8,uVar9,uVar34,0);
                  }
                  else {
                    uVar14 = String.Concat(uVar14,"两人因此结下了深仇大恨。",0);
                  }
                }
              }
              HeroData.AddLog(lVar17,uVar14,0);
              HeroData.AddLog(lVar10,uVar14,0);
              lVar15 = FUN_18046c300(0);
              uVar8 = String.Format("传闻{0}",uVar14,0);
              uVar9 = new InfoData(3,uVar8);
              if (lVar15 == null) goto LAB_1814aac56;
              InfoController.AddInfo(lVar15,uVar9,0);
              fVar30 = 0.4;
              uVar21 = 0;
              break;
            }
            uVar9 = HeroData.GetHeroName(hero,0,0);
            uVar34 = HeroData.AtAreaName(hero,0);
            uVar36 = HeroData.GetHeroName(lVar15,0,0);
            uVar8 = "{0}在{1}与{2}闲聊一阵。";
          }
          uVar8 = String.Format(uVar8,uVar9,uVar34,uVar36,0);
          HeroData.AddLog(hero,uVar8,0);
          HeroData.AddLog(lVar15,uVar8,0);
          fVar30 = 0.4;
          uVar21 = 0;
          break;
        case 12:
          lVar15 = FUN_18046c0a0(0);
          if (lVar15 == null) goto LAB_1814aac56;
          lVar15 = *(int64 *)(lVar15 + 32);
          if ((*(int64 *)(hero + 64) == 0) ||
             (uVar6 = Int32.Parse(*(uint64 *)(*(int64 *)(hero + 64) + 24),0), lVar15 == null))
          goto LAB_1814aac56;
          lVar15 = WorldData.GetHero(lVar15,uVar6,0);
          uVar18 = uVar21;
          if (lVar15 != null) {
            HeroData.ResetAI(lVar15,0);
            if (*(int64 *)(hero + 0x2b8) == 0) goto LAB_1814aac56;
            fVar31 = (float)HeroSpeAddData.Get(*(int64 *)(hero + 0x2b8),212,0);
            if (*(int64 *)(lVar15 + 0x2b8) == 0) goto LAB_1814aac56;
            fVar24 = (float)HeroSpeAddData.Get(*(int64 *)(lVar15 + 0x2b8),212,0);
            uVar8 = new FightMatchCouple(hero,lVar15,0);
            iVar20 = GlobalData.ManageHeroAutoFight(uVar8,0);
            lVar10 = FUN_1800d60b0(DAT_181d7f180,4);
            uVar8 = HeroData.GetHeroName(hero,0,0);
            if (lVar10 == null) goto LAB_1814aac56;
            FUN_180002070(lVar10,uVar8);
            FUN_180002fd0(lVar10,0,uVar8);
            uVar8 = HeroData.AtAreaName(hero,0);
            FUN_180002070(lVar10,uVar8);
            FUN_180002fd0(lVar10,1,uVar8);
            uVar8 = HeroData.GetHeroName(lVar15,0,0);
            FUN_180002070(lVar10,uVar8);
            FUN_180002fd0(lVar10,2,uVar8);
            uVar8 = "{0}在{1}与{2}交流心得，切磋武艺，最终{3}。";
            uVar9 = "得胜而归";
            if (iVar20 != 0) {
              uVar9 = "铩羽而归";
            }
            FUN_180002070(lVar10,uVar9);
            FUN_180002fd0(lVar10,3,uVar9);
            uVar8 = String.Format(uVar8,lVar10,0);
            cVar4 = HeroData.HaveFriend(hero,*(uint32 *)(lVar15 + 88),0);
            fVar30 = 0.15;
            if ((!cVar4) &&
               ((*(char *)(hero + 92) == false || (*(char *)(lVar15 + 92) == false)))) {
              dVar26 = (double)GlobalData.RandomRangeDouble(0,0);
              fVar25 = (float)HeroData.GetStartFavor(hero,lVar15,0);
              if (dVar26 < (double)((fVar25 * 0.005 + 0.15) * (fVar24 + fVar31 + 1.0))) {
                AIController.AICheckRemoveFriend(this,hero,0);
                AIController.AICheckRemoveFriend(this,lVar15,0);
                HeroData.AddFriend(hero,*(uint32 *)(lVar15 + 88),0,0);
                uVar8 = String.Concat(uVar8,"两人因此一见如故，结为知己好友。",0);
              }
            }
            HeroData.AddLog(hero,uVar8,0);
            HeroData.AddLog(lVar15,uVar8,0);
            if (iVar20 == 0) {
              fVar30 = 0.75;
            }
            goto LAB_1814aabcd;
          }
          goto switchD_1814a4990_caseD_0;
        case 13:
          lVar15 = FUN_18046c0a0(0);
          if (lVar15 == null) goto LAB_1814aac56;
          lVar15 = *(int64 *)(lVar15 + 32);
          if ((*(int64 *)(hero + 64) == 0) ||
             (uVar6 = Int32.Parse(*(uint64 *)(*(int64 *)(hero + 64) + 24),0), lVar15 == null))
          goto LAB_1814aac56;
          lVar15 = WorldData.GetHero(lVar15,uVar6,0);
          uVar18 = uVar21;
          if (lVar15 != null) {
            if (*(int64 *)(hero + 64) == 0) goto LAB_1814aac56;
            lVar10 = lVar15;
            lVar17 = hero;
            if (*(char *)(*(int64 *)(hero + 64) + 20) == false) {
              lVar10 = hero;
              lVar17 = lVar15;
            }
            HeroData.ResetAI(lVar15,0);
            if (*(int64 *)(hero + 0x2b8) == 0) goto LAB_1814aac56;
            fVar31 = (float)HeroSpeAddData.Get(*(int64 *)(hero + 0x2b8),212,0);
            if (*(int64 *)(lVar15 + 0x2b8) == 0) goto LAB_1814aac56;
            fVar24 = (float)HeroSpeAddData.Get(*(int64 *)(lVar15 + 0x2b8),212,0);
            fVar30 = 1.0;
            uVar8 = new FightMatchCouple(hero,lVar15,0);
            iVar20 = GlobalData.ManageHeroAutoFight(uVar8,2);
            lVar16 = FUN_1800d60b0(DAT_181d7f180,4);
            uVar8 = HeroData.GetHeroName(lVar10,0,0);
            if (lVar16 == null) goto LAB_1814aac56;
            FUN_180002070(lVar16,uVar8);
            FUN_180002fd0(lVar16,0,uVar8);
            uVar8 = HeroData.AtAreaName(lVar10,0);
            FUN_180002070(lVar16,uVar8);
            FUN_180002fd0(lVar16,1,uVar8);
            uVar8 = HeroData.GetHeroName(lVar17,0,0);
            FUN_180002070(lVar16,uVar8);
            FUN_180002fd0(lVar16,2,uVar8);
            uVar8 = "{0}在{1}袭击了{2}，血战一场最终{3}。";
            uVar9 = "得胜而归";
            if (iVar20 != 0) {
              uVar9 = "铩羽而归";
            }
            FUN_180002070(lVar16,uVar9);
            FUN_180002fd0(lVar16,3);
            uVar8 = String.Format(uVar8,lVar16);
            if ((((*(char *)(hero + 0x385) == false) && (*(char *)(lVar15 + 0x385) == false)) &&
                (cVar4 = HeroData.HaveHater(hero,*(uint32 *)(lVar15 + 88)), !cVar4)) &&
               ((*(char *)(hero + 92) == false || (*(char *)(lVar15 + 92) == false)))) {
              dVar26 = (double)GlobalData.RandomRangeDouble(0,0);
              fVar25 = (float)HeroData.GetStartFavor(hero,lVar15);
              if (dVar26 < (double)((0.6 - fVar25 * 0.02) * (1.0 / (fVar24 + fVar31 + 1.0)))) {
                AIController.AICheckRemoveHater(this,hero);
                AIController.AICheckRemoveHater(this,lVar15);
                HeroData.AddHater(hero,*(uint32 *)(lVar15 + 88),0,0);
                uVar8 = String.Concat(uVar8,"两人因此结下了深仇大恨。");
              }
            }
            if (iVar20 == 0) {
              HeroData.ChangeFame(hero);
              HeroData.ChangeFame(lVar15);
              AIController.HeroLoseFightOnBigMap(this,lVar15,0);
              if ((*(char *)(hero + 0x386) == false) &&
                 (iVar20 = HeroData.GetBountyPirce(lVar15,0), 0 < iVar20)) {
                uVar6 = HeroData.GetBountyPirce(lVar15,0);
                HeroData.GetBounty(hero,uVar6,lVar15,0,0);
                AIController.NPCGoInPrison(this,lVar15,hero,0);
              }
              uVar18 = 0;
            }
            else {
              HeroData.ChangeFame(hero);
              HeroData.ChangeFame(lVar15);
              AIController.HeroLoseFightOnBigMap(this,hero,0);
              uVar18 = 1;
              if ((*(char *)(lVar15 + 0x386) == false) &&
                 (iVar20 = HeroData.GetBountyPirce(hero,0), 0 < iVar20)) {
                uVar6 = HeroData.GetBountyPirce(hero,0);
                HeroData.GetBounty(lVar15,uVar6,hero,0,0);
                AIController.NPCGoInPrison(this,hero,lVar15,0);
                bVar3 = true;
              }
              fVar30 = 0.1;
            }
            iVar20 = HeroData.GetBountyPirce(lVar17,0);
            if (iVar20 < 1) {
              HeroData.ChangeBadFame(lVar10);
            }
            HeroData.AddLog(hero,uVar8,0);
            HeroData.AddLog(lVar15,uVar8,0);
            lVar15 = FUN_18046c300(0);
            uVar8 = String.Format("传闻{0}",uVar8,0);
            uVar9 = new InfoData(3,uVar8);
            if (lVar15 == null) goto LAB_1814aac56;
            InfoController.AddInfo(lVar15,uVar9,0);
            goto LAB_1814aabd0;
          }
          goto switchD_1814a4990_caseD_0;
        case 14:
          GlobalData.RandomRangeDouble(0,0);
          local_13c = Mathf.RoundToInt();
          HeroData.ChangeFame(hero);
          dVar26 = (double)GlobalData.RandomRangeDouble(0,0);
          fVar31 = (float)FUN_1801f7f00();
          if (*(int64 *)(hero + 64) == 0) goto LAB_1814aac56;
          local_148 = Mathf.RoundToInt(((float)dVar26 + (float)dVar26 + 2.0) * fVar31 *
                                        (float)*(int *)(*(int64 *)(hero + 64) + 36),0);
          HeroData.ChangeMoney(hero,local_148,0,0);
          lVar10 = FUN_18046c0a0(0);
          lVar15 = *(int64 *)(hero + 64);
          if (lVar15 == null) goto LAB_1814aac56;
          Mathf.Min(lVar15,(float)*(int *)(lVar15 + 36) * 0.3,0);
          GlobalData.RandomRange();
          HeroData.GetHeroItemLv(hero,0,0);
          if (lVar10 == null) goto LAB_1814aac56;
          uVar8 = 0;
          lVar15 = hero;
          lVar10 = GameController.GenerateRandomItem(lVar10);
          HeroData.GetItem(hero,lVar10,0,0,lVar15,uVar8);
          lVar15 = FUN_1800d60b0(DAT_181d7f180,5);
          uVar8 = HeroData.Name(hero,1,0);
          if (lVar15 == null) goto LAB_1814aac56;
          FUN_180002070(lVar15,uVar8);
          FUN_180002fd0(lVar15,0,uVar8);
          uVar8 = HeroData.AtAreaName(hero,0);
          FUN_180002070(lVar15,uVar8);
          FUN_180002fd0(lVar15,1,uVar8);
          uVar8 = Int32.ToString(&local_13c,"+0;-0;+0",0);
          FUN_180002070(lVar15,uVar8);
          FUN_180002fd0(lVar15,2,uVar8);
          uVar8 = Int32.ToString(&local_148,"+0;-0;+0",0);
          FUN_180002070(lVar15,uVar8);
          FUN_180002fd0(lVar15,3,uVar8);
          if (lVar10 == null) goto LAB_1814aac56;
          uVar8 = ItemData.Name(lVar10,1,0);
          FUN_180002070(lVar15,uVar8);
          FUN_180002fd0(lVar15,4,uVar8);
          uVar8 = String.Format("{0}在{1}完成了重要委托，名望{2}，银两{3}，并获得了{4}。",lVar15,0);
          HeroData.AddLog(hero,uVar8,0);
          fVar30 = 0.5;
          uVar21 = uVar18;
          break;
        case 15:
          lVar15 = FUN_18046c0a0(0);
          if (lVar15 == null) goto LAB_1814aac56;
          iVar20 = GameController.RandomRareLvByBossLv(lVar15,(float)*(int *)(hero + 184) * 0.06,0,0)
          ;
          fVar31 = (float)GlobalData.RandomRange();
          GlobalData.RandomRangeDouble(0,0);
          local_13c = Mathf.RoundToInt();
          HeroData.ChangeFame(hero);
          dVar26 = (double)GlobalData.RandomRangeDouble(0,0);
          fVar30 = (float)FUN_1801f7f00();
          if (*(int64 *)(hero + 64) == 0) goto LAB_1814aac56;
          local_148 = Mathf.RoundToInt((float)dVar26 * 8.0 * (fVar31 + (float)iVar20 * 0.25) * fVar30 *
                                        (float)*(int *)(*(int64 *)(hero + 64) + 36),0);
          HeroData.ChangeMoney(hero,local_148,0,0);
          if (*(int64 *)(hero + 64) == 0) goto LAB_1814aac56;
          Mathf.Min();
          GlobalData.RandomRange();
          HeroData.GetHeroItemLv(hero,0,0);
          Mathf.Min();
          lVar15 = FUN_18046c0a0(0);
          if (lVar15 == null) goto LAB_1814aac56;
          uVar8 = 0;
          lVar10 = hero;
          lVar15 = GameController.GenerateRandomItem(lVar15);
          HeroData.GetItem(hero,lVar15,0,0,lVar10,uVar8);
          lVar10 = FUN_1800d60b0(DAT_181d7f180,6);
          uVar8 = HeroData.Name(hero,1,0);
          if (lVar10 == null) goto LAB_1814aac56;
          FUN_180002070(lVar10,uVar8);
          FUN_180002fd0(lVar10,0,uVar8);
          uVar8 = HeroData.AtAreaName(hero,0);
          FUN_180002070(lVar10,uVar8);
          FUN_180002fd0(lVar10,1,uVar8);
          uVar8 = Int32.ToString(&local_13c,"+0;-0;+0",0);
          FUN_180002070(lVar10,uVar8);
          FUN_180002fd0(lVar10,2,uVar8);
          uVar8 = Int32.ToString(&local_148,"+0;-0;+0",0);
          FUN_180002070(lVar10,uVar8);
          FUN_180002fd0(lVar10,3,uVar8);
          if (lVar15 == null) goto LAB_1814aac56;
          uVar8 = ItemData.Name(lVar15,1,0);
          FUN_180002070(lVar10,uVar8);
          FUN_180002fd0(lVar10,4,uVar8);
          lVar15 = *(int64 *)(pStatics + 0x4f0);
          if (lVar15 == null) goto LAB_1814aac56;
          uVar8 = FUN_180002f80(lVar15,iVar20,DAT_181d7c9c0);
          uVar8 = GlobalData.GenerateRareLvColorText(uVar8,iVar20,0);
          FUN_180002070(lVar10,uVar8);
          FUN_180002fd0(lVar10,5,uVar8);
          uVar8 = String.Format("{0}在{1}遭逢{5}奇遇，名望{2}，银两{3}，并获得了{4}。",lVar10,0);
          HeroData.AddLog(hero,uVar8,0);
          fVar30 = 0.2;
          uVar21 = uVar18;
          break;
        case 17:
          iVar20 = Mathf.Max(1,*(uint32 *)(lVar15 + 36),0);
          if (*(int64 *)(hero + 0x220) == 0) goto LAB_1814aac56;
          uVar6 = Mathf.FloorToInt((float)*(int *)(*(int64 *)(hero + 0x220) + 24) * 0.02,0);
          iVar20 = Mathf.Min(iVar20 * 4,uVar6,0);
          uVar6 = Mathf.RoundToInt((float)-iVar20 * 50.0,0);
          uVar8 = 0;
          in_stack_fffffffffffffe88 = in_stack_fffffffffffffe88 & 0xffffffffffffff00;
          HeroData.ChangeBadFame(hero);
          HeroData.ChangeMoney(hero,uVar6,0,0,in_stack_fffffffffffffe88,uVar8);
          lVar15 = FUN_1800d60b0(DAT_181d7f180,4);
          uVar8 = HeroData.Name(hero,1,0);
          if (lVar15 == null) goto LAB_1814aac56;
          FUN_180002070(lVar15,uVar8);
          FUN_180002fd0(lVar15,0,uVar8);
          uVar8 = HeroData.AtAreaName(hero,0);
          FUN_180002070(lVar15,uVar8);
          FUN_180002fd0(lVar15,1,uVar8);
          local_108 = Mathf.Abs(-iVar20,0);
          uVar8 = il2cpp_value_box(DAT_181d5b2f8,&local_108);
          FUN_180002070(lVar15,uVar8);
          FUN_180002fd0(lVar15,2,uVar8);
          local_104 = Mathf.Abs(uVar6,0);
          uVar8 = il2cpp_value_box(DAT_181d5b2f8,&local_104);
          FUN_180002070(lVar15,uVar8);
          FUN_180002fd0(lVar15,3,uVar8);
          uVar8 = String.Format("{0}在{1}上下打点，花费{3}银两降低了{2}点恶名。",lVar15,0);
          HeroData.AddLog(hero,uVar8,0);
          fVar30 = 0.1;
          uVar21 = 0;
          break;
        case 18:
          uVar6 = Int32.Parse(*(uint64 *)(lVar15 + 24),0);
          uVar8 = new KungfuSkillLvData(uVar6,0);
          lVar15 = HeroData.GetSkill(hero,uVar8,0,0,0);
          uVar8 = HeroData.Name(hero,1,0);
          uVar9 = HeroData.AtAreaName(hero,0);
          if (lVar15 == null) goto LAB_1814aac56;
          uVar34 = KungfuSkillLvData.Name(lVar15,1,0);
          uVar8 = String.Format("{0}在{1}习得了新武功{2}。",uVar8,uVar9,uVar34,0);
          HeroData.AddLog(hero,uVar8,0);
          fVar30 = 1.5;
          uVar21 = uVar18;
          break;
        case 19:
          lVar15 = FUN_18046c0a0(0);
          if (lVar15 == null) goto LAB_1814aac56;
          lVar15 = *(int64 *)(lVar15 + 32);
          if (((*(int64 *)(hero + 64) == 0) ||
              (uVar6 = Int32.Parse(*(uint64 *)(*(int64 *)(hero + 64) + 24),0), lVar15 == null)
              ) || (lVar15 = WorldData.GetArea(lVar15,uVar6,0), lVar10 == null)) goto LAB_1814aac56;
          plVar12 = (int64 *)(lVar10 + 16);
          *plVar12 = lVar15;
          il2cpp_internal(plVar12,lVar15);
          lVar15 = il2cpp_internal(DAT_181d6f030);
          FUN_180f58a90(lVar15,DAT_181d678f8);
          if (lVar15 == null) goto LAB_1814aac56;
          FUN_181814fa0(lVar15,0,DAT_181d67a78);
          FUN_181814fa0(lVar15,1,DAT_181d67a78);
          FUN_181814fa0(lVar15,2,DAT_181d67a78);
          FUN_181814fa0(lVar15,3,DAT_181d67a78);
          uVar8 = new OnTooltipCB(lVar10,DAT_181d6be98,DAT_181d86018);
          List_1.Sort(lVar15,uVar8,DAT_181d68070);
          uVar6 = FUN_1800d6750(lVar15,0,DAT_181d68270);
          lVar15 = *(int64 *)(pStatics + 0x608);
          if (lVar15 == null) goto LAB_1814aac56;
          uVar7 = FUN_1800d6750(lVar15,uVar6,DAT_181d6b9e8);
          if (*(int64 *)(hero + 0x168) == 0) goto LAB_1814aac56;
          FUN_1800d6780(*(int64 *)(hero + 0x168),uVar7,DAT_181d796d8);
          HeroData.GetLoyalWorkRate(hero,0);
          if (*(int64 *)(hero + 64) == 0) goto LAB_1814aac56;
          fVar31 = (float)Mathf.Max();
          if (*plVar12 == 0) goto LAB_1814aac56;
          AreaData.ChangeAreaState(*plVar12,uVar6);
          HeroData.ChangeLivingSkillExp
                    (hero,uVar7,((float)*(int *)(hero + 184) * 0.25 + 1.0) * fVar31 * 20.0,0,0);
          lVar15 = FUN_1800d60b0(DAT_181d7f180,4);
          uVar8 = HeroData.Name(hero,1,0);
          if (lVar15 == null) goto LAB_1814aac56;
          FUN_180002070(lVar15,uVar8);
          FUN_180002fd0(lVar15,0,uVar8);
          if (*plVar12 == 0) goto LAB_1814aac56;
          uVar8 = *(uint64 *)(*plVar12 + 24);
          FUN_180002070(lVar15,uVar8);
          FUN_180002fd0(lVar15,1,uVar8);
          lVar17 = *(int64 *)(pStatics + 0x600);
          if (lVar17 == null) goto LAB_1814aac56;
          uVar8 = FUN_180002f80(lVar17,uVar6,DAT_181d7c9c0);
          FUN_180002070(lVar15,uVar8);
          FUN_180002fd0(lVar15,2,uVar8);
          local_138 = ABS(fVar31);
          uVar8 = Single.ToString(&local_138,"f0",0);
          FUN_180002070(lVar15,uVar8);
          FUN_180002fd0(lVar15,3,uVar8);
          uVar8 = "{0}在{1}加强管理，使该地{2}提升{3}点。";
          goto LAB_1814a94ce;
        case 20:
          lVar15 = FUN_18046c0a0(0);
          if (lVar15 == null) goto LAB_1814aac56;
          lVar15 = *(int64 *)(lVar15 + 32);
          if (((*(int64 *)(hero + 64) == 0) ||
              (uVar6 = Int32.Parse(*(uint64 *)(*(int64 *)(hero + 64) + 24),0), lVar15 == null)
              ) || (lVar15 = WorldData.GetArea(lVar15,uVar6,0), lVar10 == null)) goto LAB_1814aac56;
          plVar12 = (int64 *)(lVar10 + 16);
          *plVar12 = lVar15;
          il2cpp_internal(plVar12,lVar15);
          lVar15 = il2cpp_internal(DAT_181d6f030);
          FUN_180f58a90(lVar15,DAT_181d678f8);
          if (lVar15 == null) goto LAB_1814aac56;
          FUN_181814fa0(lVar15,0,DAT_181d67a78);
          FUN_181814fa0(lVar15,1,DAT_181d67a78);
          FUN_181814fa0(lVar15,2,DAT_181d67a78);
          FUN_181814fa0(lVar15,3,DAT_181d67a78);
          uVar8 = new OnTooltipCB(lVar10,DAT_181d6bf18,DAT_181d86018);
          List_1.Sort(lVar15,uVar8,DAT_181d68070);
          uVar6 = FUN_1800d6750(lVar15,0,DAT_181d68270);
          lVar15 = *(int64 *)(pStatics + 0x610);
          if (lVar15 == null) goto LAB_1814aac56;
          uVar7 = FUN_1800d6750(lVar15,uVar6,DAT_181d6b9e8);
          if (*(int64 *)(hero + 0x168) == 0) goto LAB_1814aac56;
          FUN_1800d6780(*(int64 *)(hero + 0x168),uVar7,DAT_181d796d8);
          HeroData.GetLoyalWorkRate(hero,0);
          if (*(int64 *)(hero + 64) == 0) goto LAB_1814aac56;
          fVar31 = (float)Mathf.Max();
          if (*plVar12 == 0) goto LAB_1814aac56;
          AreaData.ChangeAreaState(*plVar12,uVar6);
          HeroData.ChangeLivingSkillExp
                    (hero,uVar7,((float)*(int *)(hero + 184) * 0.25 + 1.0) * -fVar31 * 20.0,0,0);
          lVar15 = FUN_1800d60b0(DAT_181d7f180,4);
          uVar8 = HeroData.Name(hero,1,0);
          if (lVar15 == null) goto LAB_1814aac56;
          FUN_180002070(lVar15,uVar8);
          FUN_180002fd0(lVar15,0,uVar8);
          if (*plVar12 == 0) goto LAB_1814aac56;
          uVar8 = *(uint64 *)(*plVar12 + 24);
          FUN_180002070(lVar15,uVar8);
          FUN_180002fd0(lVar15,1,uVar8);
          lVar17 = *(int64 *)(pStatics + 0x600);
          if (lVar17 == null) goto LAB_1814aac56;
          uVar8 = FUN_180002f80(lVar17,uVar6,DAT_181d7c9c0);
          FUN_180002070(lVar15,uVar8);
          FUN_180002fd0(lVar15,2,uVar8);
          local_138 = ABS(-fVar31);
          uVar8 = Single.ToString(&local_138,"f0",0);
          FUN_180002070(lVar15,uVar8);
          FUN_180002fd0(lVar15,3,uVar8);
          uVar8 = "{0}在{1}暗中破坏，使该地{2}降低{3}点。";
        LAB_1814a94ce:
          uVar8 = String.Format(uVar8,lVar15,0);
          HeroData.AddLog(hero,uVar8,0);
          if (*(int64 *)(lVar10 + 16) == 0) {
        LAB_1814aac56:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          AreaData.AddLog(*(int64 *)(lVar10 + 16),uVar8,0);
          iVar20 = *(int *)(hero + 132);
          lVar15 = FUN_18046c0a0(0);
          if (((lVar15 == null) || (*(int64 *)(lVar15 + 32) == 0)) ||
             (lVar15 = WorldData.Player(*(int64 *)(lVar15 + 32),0)) == null)
          goto LAB_1814aac56;
          if (iVar20 == *(int *)(lVar15 + 132)) {
            lVar15 = FUN_18046c300(0);
            uVar9 = new InfoData(1,uVar8,0);
            if (lVar15 == null) goto LAB_1814aac56;
            InfoController.AddInfo(lVar15,uVar9,0);
          }
          fVar30 = 2.0;
          uVar21 = 0;
          break;
        case 21:
          if (*(int64 *)(hero + 0x168) == 0) goto LAB_1814aac56;
          FUN_1800d6780(*(int64 *)(hero + 0x168),8,DAT_181d796d8);
          uVar37 = (uint32)(in_stack_fffffffffffffe88 >> 32);
          lVar15 = *(int64 *)(hero + 0x220);
          lVar10 = il2cpp_internal(DAT_181d6f030);
          FUN_180f58a90(lVar10,DAT_181d678f8);
          if ((lVar10 == null) || (FUN_181814fa0(lVar10,3,DAT_181d67a78), lVar15 == null)) goto LAB_1814aac56;
          lVar15 = ItemListData.FindRandomItem
                             (lVar15,0,5,0,CONCAT44(uVar37,5),lVar10,CONCAT44(uVar6,0xffffffff),
                              CONCAT44(uVar7,0xbf800000),CONCAT44(uVar35,0xbf800000),0);
          uVar6 = (uint32)((uint64)lVar10 >> 32);
          HeroData.GetLoyalWorkRate(hero,0);
          if (lVar15 != null) {
            HeroData.LoseItem(hero,lVar15,0);
            ItemData.GetMaterialExtraCraftRate(lVar15,0);
          }
          lVar10 = FUN_18046c0a0(0);
          GlobalData.RandomRange();
          if (lVar10 == null) goto LAB_1814aac56;
          uVar36 = 0;
          uVar34 = 0;
          uVar9 = CONCAT44(uVar6,0xffffffff);
          uVar8 = 1;
          lVar17 = hero;
          lVar10 = GameController.GenerateRandomItem(lVar10,2);
          if (lVar10 == null) goto LAB_1814aac56;
          fVar30 = 2.0;
          fVar31 = (float)FUN_1801f7f00();
          iVar20 = (int)(fVar31 * 25.0);
          lVar16 = HeroData.GetForce(hero,0,0);
          if (lVar16 == null) {
            HeroData.ChangeMoney(hero,-iVar20,0,0,uVar8,uVar9,lVar17,uVar34,uVar36);
            HeroData.GetItem(hero,lVar10,0);
            lVar17 = FUN_1800d60b0(DAT_181d7f180,4);
            uVar8 = HeroData.Name(hero,1,0);
            if (lVar17 == null) goto LAB_1814aac56;
            FUN_180002070(lVar17,uVar8);
            FUN_180002fd0(lVar17,0,uVar8);
            uVar8 = ItemData.Name(lVar10,1,0);
            FUN_180002070(lVar17,uVar8);
            FUN_180002fd0(lVar17,1,uVar8);
            local_f8 = iVar20;
            uVar8 = il2cpp_value_box(DAT_181d5b2f8,&local_f8);
            FUN_180002070(lVar17,uVar8);
            FUN_180002fd0(lVar17,2,uVar8);
            uVar8 = "{0}烹饪了{1}并放入行囊(消耗{2}银钱{3})";
          }
          else {
            lVar17 = HeroData.GetForce(hero,0,0);
            if (lVar17 == null) goto LAB_1814aac56;
            uVar9 = 0;
            uVar8 = 1;
            ForceData.ChangeResource(lVar17,1);
            lVar17 = HeroData.GetForce(hero,0,0);
            if ((lVar17 == null) || (*(int64 *)(lVar17 + 160) == 0)) goto LAB_1814aac56;
            fVar31 = *(float *)(*(int64 *)(lVar17 + 160) + 28);
            lVar17 = HeroData.GetForce(hero,0,0);
            if ((lVar17 == null) || (*(int64 *)(lVar17 + 160) == 0)) goto LAB_1814aac56;
            if (fVar31 < *(float *)(*(int64 *)(lVar17 + 160) + 32)) {
              lVar17 = HeroData.GetForce(hero,0,0);
              if ((lVar17 == null) || (*(int64 *)(lVar17 + 160) == 0)) goto LAB_1814aac56;
              ItemListData.GetItem(*(int64 *)(lVar17 + 160),lVar10,0,0,uVar8,uVar9);
              lVar17 = FUN_1800d60b0(DAT_181d7f180,4);
              uVar8 = HeroData.Name(hero,1,0);
              if (lVar17 == null) goto LAB_1814aac56;
              FUN_180002070(lVar17,uVar8);
              FUN_180002fd0(lVar17,0,uVar8);
              uVar8 = ItemData.Name(lVar10,1,0);
              FUN_180002070(lVar17,uVar8);
              FUN_180002fd0(lVar17,1,uVar8);
              local_fc = iVar20;
              uVar8 = il2cpp_value_box(DAT_181d5b2f8,&local_fc);
              FUN_180002070(lVar17,uVar8);
              FUN_180002fd0(lVar17,2,uVar8);
              uVar8 = "{0}烹饪了{1}并放入门派仓库(消耗{2}粮食{3})";
            }
            else {
              HeroData.GetItem(hero,lVar10,0);
              lVar17 = FUN_1800d60b0(DAT_181d7f180,4);
              uVar8 = HeroData.Name(hero,1,0);
              if (lVar17 == null) goto LAB_1814aac56;
              FUN_180002070(lVar17,uVar8);
              FUN_180002fd0(lVar17,0,uVar8);
              uVar8 = ItemData.Name(lVar10,1,0);
              FUN_180002070(lVar17,uVar8);
              FUN_180002fd0(lVar17,1,uVar8);
              local_100 = iVar20;
              uVar8 = il2cpp_value_box(DAT_181d5b2f8,&local_100);
              FUN_180002070(lVar17,uVar8);
              FUN_180002fd0(lVar17,2,uVar8);
              uVar8 = "{0}烹饪了{1}，由于门派仓库已满只得放入行囊(消耗{2}粮食{3})";
            }
          }
          uVar18 = "";
          if (lVar15 != null) {
            uVar9 = ItemData.Name(lVar15,1,0);
            uVar18 = String.Format("和{0}",uVar9,0);
          }
          FUN_180002070(lVar17,uVar18);
          FUN_180002fd0(lVar17,3,uVar18);
          uVar8 = String.Format(uVar8,lVar17,0);
          HeroData.AddLog(hero,uVar8,0);
          iVar20 = *(int *)(hero + 132);
          if (-1 < iVar20) {
            lVar17 = FUN_18046c0a0(0);
            if (((lVar17 == null) || (*(int64 *)(lVar17 + 32) == 0)) ||
               (lVar17 = WorldData.Player(*(int64 *)(lVar17 + 32),0)) == null)
            goto LAB_1814aac56;
            if (iVar20 == *(int *)(lVar17 + 132)) {
              lVar17 = FUN_18046c300(0);
              uVar9 = new InfoData(1,uVar8);
              if (lVar17 == null) goto LAB_1814aac56;
              InfoController.AddInfo(lVar17,uVar9,0);
            }
          }
          iVar20 = *(int *)(lVar10 + 56);
          if (lVar15 == null) {
            fVar30 = 1.0;
          }
          uVar8 = 8;
          goto LAB_1814a9f05;
        case 22:
          if (*(int64 *)(hero + 0x168) == 0) goto LAB_1814aac56;
          FUN_1800d6780(*(int64 *)(hero + 0x168),7,DAT_181d796d8);
          uVar37 = (uint32)(in_stack_fffffffffffffe88 >> 32);
          lVar15 = *(int64 *)(hero + 0x220);
          lVar10 = il2cpp_internal(DAT_181d6f030);
          FUN_180f58a90(lVar10,DAT_181d678f8);
          if ((lVar10 == null) || (FUN_181814fa0(lVar10,2,DAT_181d67a78), lVar15 == null)) goto LAB_1814aac56;
          lVar15 = ItemListData.FindRandomItem
                             (lVar15,0,5,0,CONCAT44(uVar37,5),lVar10,CONCAT44(uVar6,0xffffffff),
                              CONCAT44(uVar7,0xbf800000),CONCAT44(uVar35,0xbf800000),0);
          uVar6 = (uint32)((uint64)lVar10 >> 32);
          HeroData.GetLoyalWorkRate(hero,0);
          if (lVar15 != null) {
            HeroData.LoseItem(hero,lVar15,0);
            ItemData.GetMaterialExtraCraftRate(lVar15,0);
          }
          lVar10 = FUN_18046c0a0(0);
          GlobalData.RandomRange();
          if (lVar10 == null) goto LAB_1814aac56;
          uVar36 = 0;
          uVar34 = 0;
          uVar9 = CONCAT44(uVar6,0xffffffff);
          uVar8 = 1;
          lVar17 = hero;
          lVar10 = GameController.GenerateRandomItem(lVar10,1);
          if (lVar10 == null) goto LAB_1814aac56;
          fVar30 = 2.0;
          fVar31 = (float)FUN_1801f7f00();
          iVar20 = (int)(fVar31 * 25.0);
          lVar16 = HeroData.GetForce(hero,0,0);
          if (lVar16 == null) {
            HeroData.ChangeMoney(hero,-iVar20,0,0,uVar8,uVar9,lVar17,uVar34,uVar36);
            HeroData.GetItem(hero,lVar10,0);
            lVar17 = FUN_1800d60b0(DAT_181d7f180,4);
            uVar8 = HeroData.Name(hero,1,0);
            if (lVar17 == null) goto LAB_1814aac56;
            FUN_180002070(lVar17,uVar8);
            FUN_180002fd0(lVar17,0,uVar8);
            uVar8 = ItemData.Name(lVar10,1,0);
            FUN_180002070(lVar17,uVar8);
            FUN_180002fd0(lVar17,1,uVar8);
            local_ec = iVar20;
            uVar8 = il2cpp_value_box(DAT_181d5b2f8,&local_ec);
            FUN_180002070(lVar17,uVar8);
            FUN_180002fd0(lVar17,2,uVar8);
            uVar8 = "{0}炼制了{1}并放入行囊(消耗{2}银钱{3})";
          }
          else {
            lVar17 = HeroData.GetForce(hero,0,0);
            if (lVar17 == null) goto LAB_1814aac56;
            uVar9 = 0;
            uVar8 = 1;
            ForceData.ChangeResource(lVar17,4);
            lVar17 = HeroData.GetForce(hero,0,0);
            if ((lVar17 == null) || (*(int64 *)(lVar17 + 160) == 0)) goto LAB_1814aac56;
            fVar31 = *(float *)(*(int64 *)(lVar17 + 160) + 28);
            lVar17 = HeroData.GetForce(hero,0,0);
            if ((lVar17 == null) || (*(int64 *)(lVar17 + 160) == 0)) goto LAB_1814aac56;
            if (fVar31 < *(float *)(*(int64 *)(lVar17 + 160) + 32)) {
              lVar17 = HeroData.GetForce(hero,0,0);
              if ((lVar17 == null) || (*(int64 *)(lVar17 + 160) == 0)) goto LAB_1814aac56;
              ItemListData.GetItem(*(int64 *)(lVar17 + 160),lVar10,0,0,uVar8,uVar9);
              lVar17 = FUN_1800d60b0(DAT_181d7f180,4);
              uVar8 = HeroData.Name(hero,1,0);
              if (lVar17 == null) goto LAB_1814aac56;
              FUN_180002070(lVar17,uVar8);
              FUN_180002fd0(lVar17,0,uVar8);
              uVar8 = ItemData.Name(lVar10,1,0);
              FUN_180002070(lVar17,uVar8);
              FUN_180002fd0(lVar17,1,uVar8);
              local_f0 = iVar20;
              uVar8 = il2cpp_value_box(DAT_181d5b2f8,&local_f0);
              FUN_180002070(lVar17,uVar8);
              FUN_180002fd0(lVar17,2,uVar8);
              uVar8 = "{0}炼制了{1}并放入门派仓库(消耗{2}药材{3})";
            }
            else {
              HeroData.GetItem(hero,lVar10,0);
              lVar17 = FUN_1800d60b0(DAT_181d7f180,4);
              uVar8 = HeroData.Name(hero,1,0);
              if (lVar17 == null) goto LAB_1814aac56;
              FUN_180002070(lVar17,uVar8);
              FUN_180002fd0(lVar17,0,uVar8);
              uVar8 = ItemData.Name(lVar10,1,0);
              FUN_180002070(lVar17,uVar8);
              FUN_180002fd0(lVar17,1,uVar8);
              local_f4 = iVar20;
              uVar8 = il2cpp_value_box(DAT_181d5b2f8,&local_f4);
              FUN_180002070(lVar17,uVar8);
              FUN_180002fd0(lVar17,2,uVar8);
              uVar8 = "{0}炼制了{1}，由于门派仓库已满只得放入行囊(消耗{2}药材{3})";
            }
          }
          uVar18 = "";
          if (lVar15 != null) {
            uVar9 = ItemData.Name(lVar15,1,0);
            uVar18 = String.Format("和{0}",uVar9,0);
          }
          FUN_180002070(lVar17,uVar18);
          FUN_180002fd0(lVar17,3,uVar18);
          uVar8 = String.Format(uVar8,lVar17,0);
          HeroData.AddLog(hero,uVar8,0);
          iVar20 = *(int *)(hero + 132);
          if (-1 < iVar20) {
            lVar17 = FUN_18046c0a0(0);
            if (((lVar17 == null) || (*(int64 *)(lVar17 + 32) == 0)) ||
               (lVar17 = WorldData.Player(*(int64 *)(lVar17 + 32),0)) == null)
            goto LAB_1814aac56;
            if (iVar20 == *(int *)(lVar17 + 132)) {
              lVar17 = FUN_18046c300(0);
              uVar9 = new InfoData(1,uVar8);
              if (lVar17 == null) goto LAB_1814aac56;
              InfoController.AddInfo(lVar17,uVar9,0);
            }
          }
          iVar20 = *(int *)(lVar10 + 56);
          if (lVar15 == null) {
            fVar30 = 1.0;
          }
          uVar8 = 7;
        LAB_1814a9f05:
          HeroData.ChangeLivingSkillExp(hero,uVar8,((float)iVar20 + (float)iVar20) * fVar30,0,0);
          fVar30 = (float)*(int *)(lVar10 + 60) * 0.5 + 0.5;
        LAB_1814aabcd:
          uVar18 = 0;
        LAB_1814aabd0:
          uVar21 = uVar18;
          if (0.0 < fVar30) break;
          goto LAB_1814aac44;
        case 23:
          if (*(int64 *)(hero + 0x168) == 0) goto LAB_1814aac56;
          FUN_1800d6780(*(int64 *)(hero + 0x168),6,DAT_181d796d8);
          uVar37 = (uint32)(in_stack_fffffffffffffe88 >> 32);
          lVar15 = *(int64 *)(hero + 0x220);
          lVar10 = il2cpp_internal(DAT_181d6f030);
          FUN_180f58a90(lVar10,DAT_181d678f8);
          if (lVar10 == null) goto LAB_1814aac56;
          FUN_181814fa0(lVar10,0,DAT_181d67a78);
          FUN_181814fa0(lVar10,1,DAT_181d67a78);
          if (lVar15 == null) goto LAB_1814aac56;
          uVar8 = CONCAT44(uVar37,5);
          lVar15 = ItemListData.FindRandomItem
                             (lVar15,0,5,0,uVar8,lVar10,CONCAT44(uVar6,0xffffffff),
                              CONCAT44(uVar7,0xbf800000),CONCAT44(uVar35,0xbf800000),0);
          uVar6 = (uint32)((uint64)lVar10 >> 32);
          HeroData.GetLoyalWorkRate(hero,0);
          if (lVar15 != null) {
            HeroData.LoseItem(hero,lVar15,0,0);
            ItemData.GetMaterialExtraCraftRate(lVar15,0);
          }
          lVar10 = FUN_18046c0a0(0);
          GlobalData.RandomRange();
          if (lVar10 == null) goto LAB_1814aac56;
          uVar36 = 0;
          uVar34 = 0;
          uVar9 = CONCAT44(uVar6,0xffffffff);
          uVar8 = CONCAT71((int7)((uint64)uVar8 >> 8),1);
          lVar17 = hero;
          lVar10 = GameController.GenerateRandomItem(lVar10,0);
          if (lVar10 == null) goto LAB_1814aac56;
          fVar30 = 2.0;
          fVar31 = (float)FUN_1801f7f00();
          iVar20 = (int)(fVar31 * 25.0);
          lVar16 = HeroData.GetForce(hero,0,0);
          if (lVar16 == null) {
            HeroData.ChangeMoney(hero,iVar20 * -2,0,0,uVar8,uVar9,lVar17,uVar34,uVar36);
            HeroData.GetItem(hero,lVar10,0,0);
            lVar17 = FUN_1800d60b0(DAT_181d7f180,4);
            uVar8 = HeroData.Name(hero,1,0);
            if (lVar17 == null) goto LAB_1814aac56;
            FUN_180002070(lVar17,uVar8);
            FUN_180002fd0(lVar17,0,uVar8);
            uVar8 = ItemData.Name(lVar10,1,0);
            FUN_180002070(lVar17,uVar8);
            FUN_180002fd0(lVar17,1,uVar8);
            local_e0[0] = iVar20;
            uVar8 = il2cpp_value_box(DAT_181d5b2f8,local_e0);
            FUN_180002070(lVar17,uVar8);
            FUN_180002fd0(lVar17,2,uVar8);
            uVar8 = "{0}制造了{1}并放入行囊(消耗{2}银钱{3})";
          }
          else {
            lVar17 = HeroData.GetForce(hero,0,0);
            if (lVar17 == null) goto LAB_1814aac56;
            uVar33 = (undefined7)((uint64)uVar8 >> 8);
            ForceData.ChangeResource(lVar17,2);
            lVar17 = HeroData.GetForce(hero,0,0);
            if (lVar17 == null) goto LAB_1814aac56;
            uVar9 = 0;
            uVar8 = CONCAT71(uVar33,1);
            ForceData.ChangeResource(lVar17,3);
            lVar17 = HeroData.GetForce(hero,0,0);
            if ((lVar17 == null) || (*(int64 *)(lVar17 + 160) == 0)) goto LAB_1814aac56;
            fVar31 = *(float *)(*(int64 *)(lVar17 + 160) + 28);
            lVar17 = HeroData.GetForce(hero,0,0);
            if ((lVar17 == null) || (*(int64 *)(lVar17 + 160) == 0)) goto LAB_1814aac56;
            if (fVar31 < *(float *)(*(int64 *)(lVar17 + 160) + 32)) {
              lVar17 = HeroData.GetForce(hero,0,0);
              if ((lVar17 == null) || (*(int64 *)(lVar17 + 160) == 0)) goto LAB_1814aac56;
              ItemListData.GetItem(*(int64 *)(lVar17 + 160),lVar10,0,0,uVar8,uVar9);
              lVar17 = FUN_1800d60b0(DAT_181d7f180,4);
              uVar8 = HeroData.Name(hero,1,0);
              if (lVar17 == null) goto LAB_1814aac56;
              FUN_180002070(lVar17,uVar8);
              FUN_180002fd0(lVar17,0,uVar8);
              uVar8 = ItemData.Name(lVar10,1,0);
              FUN_180002070(lVar17,uVar8);
              FUN_180002fd0(lVar17,1,uVar8);
              local_e4 = iVar20;
              uVar8 = il2cpp_value_box(DAT_181d5b2f8,&local_e4);
              FUN_180002070(lVar17,uVar8);
              FUN_180002fd0(lVar17,2,uVar8);
              uVar8 = "{0}制造了{1}并放入门派仓库(消耗{2}木料矿石{3})";
            }
            else {
              HeroData.GetItem(hero,lVar10,0,0);
              lVar17 = FUN_1800d60b0(DAT_181d7f180,4);
              uVar8 = HeroData.Name(hero,1,0);
              if (lVar17 == null) goto LAB_1814aac56;
              FUN_180002070(lVar17,uVar8);
              FUN_180002fd0(lVar17,0,uVar8);
              uVar8 = ItemData.Name(lVar10,1,0);
              FUN_180002070(lVar17,uVar8);
              FUN_180002fd0(lVar17,1,uVar8);
              local_e8 = iVar20;
              uVar8 = il2cpp_value_box(DAT_181d5b2f8,&local_e8);
              FUN_180002070(lVar17,uVar8);
              FUN_180002fd0(lVar17,2,uVar8);
              uVar8 = "{0}制造了{1}，由于门派仓库已满只得放入行囊(消耗{2}木料矿石{3})";
            }
          }
          uVar18 = "";
          if (lVar15 != null) {
            uVar9 = ItemData.Name(lVar15,1,0);
            uVar18 = String.Format("和{0}",uVar9,0);
          }
          FUN_180002070(lVar17,uVar18);
          FUN_180002fd0(lVar17,3,uVar18);
          uVar8 = String.Format(uVar8,lVar17,0);
          HeroData.AddLog(hero,uVar8,0);
          iVar20 = *(int *)(hero + 132);
          if (-1 < iVar20) {
            lVar17 = FUN_18046c0a0(0);
            if (((lVar17 == null) || (*(int64 *)(lVar17 + 32) == 0)) ||
               (lVar17 = WorldData.Player(*(int64 *)(lVar17 + 32),0)) == null)
            goto LAB_1814aac56;
            if (iVar20 == *(int *)(lVar17 + 132)) {
              lVar17 = FUN_18046c300(0);
              uVar9 = new InfoData(1,uVar8,0);
              if (lVar17 == null) goto LAB_1814aac56;
              InfoController.AddInfo(lVar17,uVar9,0);
            }
          }
          if (lVar15 == null) {
            fVar30 = 1.0;
          }
          HeroData.ChangeLivingSkillExp(hero,6,(float)*(int *)(lVar10 + 56) * fVar30,0,0);
          fVar30 = (float)*(int *)(lVar10 + 60) + 1.0;
          goto LAB_1814aabcd;
        }
        uVar18 = uVar21;
        if (-1 < *(int *)(hero + 132)) {
          dVar26 = (double)GlobalData.RandomRangeDouble(0,0);
          HeroData.ChangeForceContribution
                    (hero,((float)dVar26 * 4.0 + 4.0 + (float)*(int *)(hero + 184)) * fVar30,0,
                     0xffffffff,0);
        }
        LAB_1814aac44:
        if (!bVar3) {
        switchD_1814a4990_caseD_0:
          HeroData.ResetAI(hero,0);
        }
        return uVar18;
        LAB_1814a5af0:
        uVar6 = (uint32)((uint64)in_stack_fffffffffffffe90 >> 32);
        if ((*(int64 *)(hero + 0x1f8) == 0) ||
           (lVar15 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 32)) == null)
        goto LAB_1814aac56;
        if ((int)*(uint32 *)(lVar15 + 24) <= (int)uVar19) {
          uVar19 = 0;
          goto LAB_1814a5bd0;
        }
        if (*(uint32 *)(lVar15 + 24) <= uVar19) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        uVar8 = lVar15[uVar19];
        uVar7 = HeroData.GetPreferWeaponType(hero,0);
        in_stack_fffffffffffffe98 = 0;
        in_stack_fffffffffffffe90 = CONCAT44(uVar6,uVar7);
        in_stack_fffffffffffffe88 = in_stack_fffffffffffffe88 & 0xffffffff00000000;
        lVar15 = AIController.HeroManageEquipmentTrade
                           (this,hero,uVar21,uVar8,in_stack_fffffffffffffe88,
                            in_stack_fffffffffffffe90,0);
        if (lVar15 != null) {
          FUN_1816fd990(uVar18,"",0);
          ItemData.Name(lVar15,1,0);
          uVar18 = String.Concat(uVar18);
          fVar31 = fVar31 + (float)*(int *)(lVar15 + 56);
        }
        uVar19 = uVar19 + 1;
        goto LAB_1814a5af0;
        LAB_1814a5bd0:
        uVar6 = (uint32)(in_stack_fffffffffffffe88 >> 32);
        uVar7 = (uint32)((uint64)in_stack_fffffffffffffe90 >> 32);
        if ((*(int64 *)(hero + 0x1f8) == 0) ||
           (lVar15 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 56)) == null)
        goto LAB_1814aac56;
        if ((int)*(uint32 *)(lVar15 + 24) <= (int)uVar19) {
          uVar19 = 0;
          goto LAB_1814a5cb0;
        }
        if (*(uint32 *)(lVar15 + 24) <= uVar19) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        in_stack_fffffffffffffe98 = 0;
        in_stack_fffffffffffffe90 = CONCAT44(uVar7,0xffffffff);
        in_stack_fffffffffffffe88 = CONCAT44(uVar6,1);
        lVar15 = AIController.HeroManageEquipmentTrade
                           (this,hero,uVar21,
                            *(uint64 *)
                             (*(int64 *)(lVar15 + 16) + 32 + (int64)(int)uVar19 * 8),
                            in_stack_fffffffffffffe88,in_stack_fffffffffffffe90,0);
        if (lVar15 != null) {
          FUN_1816fd990(uVar18,"",0);
          ItemData.Name(lVar15,1,0);
          uVar18 = String.Concat(uVar18);
          fVar31 = fVar31 + (float)*(int *)(lVar15 + 56);
        }
        uVar19 = uVar19 + 1;
        goto LAB_1814a5bd0;
        LAB_1814a5cb0:
        uVar6 = (uint32)(in_stack_fffffffffffffe88 >> 32);
        uVar7 = (uint32)((uint64)in_stack_fffffffffffffe90 >> 32);
        if ((*(int64 *)(hero + 0x1f8) == 0) ||
           (lVar15 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 80)) == null)
        goto LAB_1814aac56;
        if ((int)*(uint32 *)(lVar15 + 24) <= (int)uVar19) {
          uVar19 = 0;
          goto LAB_1814a5d90;
        }
        if (*(uint32 *)(lVar15 + 24) <= uVar19) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        in_stack_fffffffffffffe98 = 0;
        in_stack_fffffffffffffe90 = CONCAT44(uVar7,0xffffffff);
        in_stack_fffffffffffffe88 = CONCAT44(uVar6,2);
        lVar15 = AIController.HeroManageEquipmentTrade
                           (this,hero,uVar21,
                            *(uint64 *)
                             (*(int64 *)(lVar15 + 16) + 32 + (int64)(int)uVar19 * 8),
                            in_stack_fffffffffffffe88,in_stack_fffffffffffffe90,0);
        if (lVar15 != null) {
          FUN_1816fd990(uVar18,"",0);
          ItemData.Name(lVar15,1,0);
          uVar18 = String.Concat(uVar18);
          fVar31 = fVar31 + (float)*(int *)(lVar15 + 56);
        }
        uVar19 = uVar19 + 1;
        goto LAB_1814a5cb0;
        LAB_1814a5d90:
        uVar6 = (uint32)(in_stack_fffffffffffffe88 >> 32);
        uVar7 = (uint32)((uint64)in_stack_fffffffffffffe90 >> 32);
        if ((*(int64 *)(hero + 0x1f8) == 0) ||
           (lVar15 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 104)) == null)
        goto LAB_1814aac56;
        if ((int)*(uint32 *)(lVar15 + 24) <= (int)uVar19) {
          uVar19 = 0;
          goto LAB_1814a5e70;
        }
        if (*(uint32 *)(lVar15 + 24) <= uVar19) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        in_stack_fffffffffffffe98 = 0;
        in_stack_fffffffffffffe90 = CONCAT44(uVar7,0xffffffff);
        in_stack_fffffffffffffe88 = CONCAT44(uVar6,3);
        lVar15 = AIController.HeroManageEquipmentTrade
                           (this,hero,uVar21,
                            *(uint64 *)
                             (*(int64 *)(lVar15 + 16) + 32 + (int64)(int)uVar19 * 8),
                            in_stack_fffffffffffffe88,in_stack_fffffffffffffe90,0);
        if (lVar15 != null) {
          FUN_1816fd990(uVar18,"",0);
          ItemData.Name(lVar15,1,0);
          uVar18 = String.Concat(uVar18);
          fVar31 = fVar31 + (float)*(int *)(lVar15 + 56);
        }
        uVar19 = uVar19 + 1;
        goto LAB_1814a5d90;
        LAB_1814a5e70:
        uVar6 = (uint32)(in_stack_fffffffffffffe88 >> 32);
        uVar7 = (uint32)((uint64)in_stack_fffffffffffffe90 >> 32);
        if ((*(int64 *)(hero + 0x1f8) == 0) ||
           (lVar15 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 128)) == null)
        goto LAB_1814aac56;
        if ((int)*(uint32 *)(lVar15 + 24) <= (int)uVar19) goto LAB_1814a5f4a;
        if (*(uint32 *)(lVar15 + 24) <= uVar19) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        in_stack_fffffffffffffe98 = 0;
        in_stack_fffffffffffffe90 = CONCAT44(uVar7,0xffffffff);
        in_stack_fffffffffffffe88 = CONCAT44(uVar6,4);
        lVar15 = AIController.HeroManageEquipmentTrade
                           (this,hero,uVar21,
                            *(uint64 *)
                             (*(int64 *)(lVar15 + 16) + 32 + (int64)(int)uVar19 * 8),
                            in_stack_fffffffffffffe88,in_stack_fffffffffffffe90,0);
        if (lVar15 != null) {
          FUN_1816fd990(uVar18,"",0);
          ItemData.Name(lVar15,1,0);
          uVar18 = String.Concat(uVar18);
          fVar31 = fVar31 + (float)*(int *)(lVar15 + 56);
        }
        uVar19 = uVar19 + 1;
        goto LAB_1814a5e70;
        LAB_1814a5f4a:
        if ((*(int64 *)(hero + 0x220) == 0) ||
           (lVar15 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null)
        goto LAB_1814aac56;
        if (*(uint32 *)(lVar15 + 24) < 2) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        uVar6 = (uint32)(in_stack_fffffffffffffe88 >> 32);
        uVar7 = (uint32)((uint64)in_stack_fffffffffffffe98 >> 32);
        uVar35 = (uint32)((uint64)in_stack_fffffffffffffea0 >> 32);
        uVar37 = (uint32)((uint64)in_stack_fffffffffffffea8 >> 32);
        lVar15 = *(int64 *)(*(int64 *)(lVar15 + 16) + 40);
        if (lVar15 == null) goto LAB_1814aac56;
        if ((float)*(int *)(lVar15 + 24) < (float)*(int *)(hero + 184) * 0.5 + 1.5) {
          if (uVar21 == 0) {
        LAB_1814a6052:
            lVar15 = FUN_18046c0a0(0);
            HeroData.GetMaxBuyValue(hero);
            if (lVar15 == null) goto LAB_1814aac56;
            in_stack_fffffffffffffe88 = 0;
            lVar15 = GameController.GenerateMedData(lVar15);
            if (lVar15 == null) goto LAB_1814aac56;
            iVar5 = *(int *)(lVar15 + 56);
            fVar30 = (float)HeroData.GetTradeValueRate(hero,1,0);
            HeroData.ChangeMoney(hero,-(int)((float)iVar5 * fVar30),0,0,in_stack_fffffffffffffe88);
            HeroData.GetItem(hero,lVar15,0,0);
          }
          else {
            HeroData.GetForceStorageDiscount(hero,uVar21,0);
            uVar22 = HeroData.GetMaxBuyValue(hero);
            in_stack_fffffffffffffea8 = CONCAT44(uVar37,uVar22);
            in_stack_fffffffffffffea0 = CONCAT44(uVar35,0xbf800000);
            in_stack_fffffffffffffe98 = CONCAT44(uVar7,0xffffffff);
            lVar15 = ItemListData.FindRandomItem
                               (uVar21,0xffffffff,999999,0,CONCAT44(uVar6,1),0,in_stack_fffffffffffffe98,
                                in_stack_fffffffffffffea0,in_stack_fffffffffffffea8,0);
            if (lVar15 == null) goto LAB_1814a6052;
            in_stack_fffffffffffffe88 = 0;
            AIController.HeroBuyItemFromForceStorage(this,hero,lVar15,uVar21,0);
          }
          cVar4 = FUN_1816fd990(uVar18,"",0);
          uVar14 = "/";
          if (cVar4) {
            uVar14 = "";
          }
          uVar8 = ItemData.Name(lVar15,1,0);
          uVar18 = String.Concat(uVar18,uVar14,uVar8,0);
          fVar31 = fVar31 + (float)*(int *)(lVar15 + 56);
        }
        if ((*(int64 *)(hero + 0x220) == 0) ||
           (lVar15 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null)
        goto LAB_1814aac56;
        if (*(uint32 *)(lVar15 + 24) < 6) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        uVar6 = (uint32)(in_stack_fffffffffffffe88 >> 32);
        uVar7 = (uint32)((uint64)in_stack_fffffffffffffe98 >> 32);
        uVar35 = (uint32)((uint64)in_stack_fffffffffffffea0 >> 32);
        uVar37 = (uint32)((uint64)in_stack_fffffffffffffea8 >> 32);
        lVar15 = *(int64 *)(*(int64 *)(lVar15 + 16) + 72);
        if (lVar15 == null) goto LAB_1814aac56;
        if ((float)*(int *)(lVar15 + 24) < (float)*(int *)(hero + 184) * 0.5) {
          if (uVar21 == 0) {
        LAB_1814a6238:
            lVar15 = FUN_18046c0a0(0);
            iVar5 = *(int *)(hero + 184);
            uVar8 = GlobalData.RandomRange((float)iVar5 - 1.5);
            uVar6 = Mathf.RoundToInt(uVar8,0);
            if ((lVar15 == null) ||
               (lVar15 = GameController.GenerateMaterial
                                   (lVar15,uVar6,(float)*(int *)(hero + 184) * 0.3,0), lVar15 == null))
            goto LAB_1814aac56;
            iVar5 = *(int *)(lVar15 + 56);
            fVar30 = (float)HeroData.GetTradeValueRate(hero,1,0);
            HeroData.ChangeMoney(hero,-(int)((float)iVar5 * fVar30),0,0);
            HeroData.GetItem(hero,lVar15,0,0);
          }
          else {
            HeroData.GetForceStorageDiscount(hero,uVar21,0);
            uVar22 = HeroData.GetMaxBuyValue(hero);
            in_stack_fffffffffffffea8 = CONCAT44(uVar37,uVar22);
            in_stack_fffffffffffffea0 = CONCAT44(uVar35,0xbf800000);
            in_stack_fffffffffffffe98 = CONCAT44(uVar7,0xffffffff);
            in_stack_fffffffffffffe88 = CONCAT44(uVar6,5);
            lVar15 = ItemListData.FindRandomItem
                               (uVar21,0xffffffff,999999,0,in_stack_fffffffffffffe88,0,
                                in_stack_fffffffffffffe98,in_stack_fffffffffffffea0,
                                in_stack_fffffffffffffea8,0);
            if (lVar15 == null) goto LAB_1814a6238;
            in_stack_fffffffffffffe88 = 0;
            AIController.HeroBuyItemFromForceStorage(this,hero,lVar15,uVar21,0);
          }
          cVar4 = FUN_1816fd990(uVar18,"",0);
          uVar14 = "/";
          if (cVar4) {
            uVar14 = "";
          }
          uVar8 = ItemData.Name(lVar15,1,0);
          uVar18 = String.Concat(uVar18,uVar14,uVar8,0);
          fVar31 = fVar31 + (float)*(int *)(lVar15 + 56);
        }
        if ((*(int64 *)(hero + 0x220) == 0) ||
           (lVar15 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null)
        goto LAB_1814aac56;
        if (*(uint32 *)(lVar15 + 24) < 3) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        uVar6 = (uint32)(in_stack_fffffffffffffe88 >> 32);
        uVar7 = (uint32)((uint64)in_stack_fffffffffffffe98 >> 32);
        uVar35 = (uint32)((uint64)in_stack_fffffffffffffea0 >> 32);
        uVar37 = (uint32)((uint64)in_stack_fffffffffffffea8 >> 32);
        lVar15 = *(int64 *)(*(int64 *)(lVar15 + 16) + 48);
        if (lVar15 == null) goto LAB_1814aac56;
        if ((float)*(int *)(lVar15 + 24) < (float)*(int *)(hero + 184) * 0.5 - 0.5) {
          if (uVar21 == 0) {
        LAB_1814a644e:
            lVar15 = FUN_18046c0a0(0);
            HeroData.GetMaxBuyValue(hero);
            if (lVar15 == null) goto LAB_1814aac56;
            uVar8 = 0;
            in_stack_fffffffffffffe88 = CONCAT44(uVar6,0xffffffff);
            lVar15 = GameController.GenerateFoodData(lVar15);
            if (lVar15 == null) goto LAB_1814aac56;
            iVar5 = *(int *)(lVar15 + 56);
            fVar30 = (float)HeroData.GetTradeValueRate(hero,1,0);
            HeroData.ChangeMoney
                      (hero,-(int)((float)iVar5 * fVar30),0,0,in_stack_fffffffffffffe88,uVar8);
            HeroData.GetItem(hero,lVar15,0,0);
          }
          else {
            HeroData.GetForceStorageDiscount(hero,uVar21,0);
            uVar22 = HeroData.GetMaxBuyValue(hero);
            in_stack_fffffffffffffea8 = CONCAT44(uVar37,uVar22);
            in_stack_fffffffffffffea0 = CONCAT44(uVar35,0xbf800000);
            in_stack_fffffffffffffe98 = CONCAT44(uVar7,0xffffffff);
            uVar8 = CONCAT44(uVar6,2);
            lVar15 = ItemListData.FindRandomItem
                               (uVar21,0xffffffff,999999,0,uVar8,0,in_stack_fffffffffffffe98,
                                in_stack_fffffffffffffea0,in_stack_fffffffffffffea8,0);
            uVar6 = (uint32)((uint64)uVar8 >> 32);
            if (lVar15 == null) goto LAB_1814a644e;
            in_stack_fffffffffffffe88 = 0;
            AIController.HeroBuyItemFromForceStorage(this,hero,lVar15,uVar21,0);
          }
          cVar4 = FUN_1816fd990(uVar18,"",0);
          uVar14 = "/";
          if (cVar4) {
            uVar14 = "";
          }
          uVar8 = ItemData.Name(lVar15,1,0);
          uVar18 = String.Concat(uVar18,uVar14,uVar8,0);
          fVar31 = fVar31 + (float)*(int *)(lVar15 + 56);
        }
        fVar30 = 0.7;
        while( true ) {
          uVar6 = (uint32)(in_stack_fffffffffffffe88 >> 32);
          lVar15 = *(int64 *)(hero + 0x220);
          if (lVar15 == null) break;
          if (0.7 < *(float *)(lVar15 + 28) / *(float *)(lVar15 + 32)) {
        LAB_1814a67d1:
            plVar12 = (int64 *)FUN_1800d60b0(DAT_181d7f180,4);
            lVar15 = HeroData.Name(hero,1,0);
            if (plVar12 != (int64 *)0) {
              if ((lVar15 != null) &&
                 (lVar10 = il2cpp_internal(lVar15,*(uint64 *)(*plVar12 + 64))) == null) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              if ((int)plVar12[3] == 0) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              plVar12[4] = lVar15;
              il2cpp_internal(plVar12 + 4,lVar15);
              lVar15 = HeroData.AtAreaName(hero,0);
              if ((lVar15 != null) &&
                 (lVar10 = il2cpp_internal(lVar15,*(uint64 *)(*plVar12 + 64))) == null) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              if (*(uint32 *)(plVar12 + 3) < 2) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              plVar12[5] = lVar15;
              il2cpp_internal(plVar12 + 5,lVar15);
              if ((local_res10 != 0) &&
                 (lVar15 = il2cpp_internal(local_res10,*(uint64 *)(*plVar12 + 64))) == null
                 ) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              if (*(uint32 *)(plVar12 + 3) < 3) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              plVar12[6] = local_res10;
              il2cpp_internal(plVar12 + 6,local_res10);
              cVar4 = FUN_1816fd990(uVar18,"",0);
              uVar8 = "{0}在{1}买卖交易，出售了闲置物品{2}{3}。";
              uVar21 = "";
              if (!cVar4) {
                uVar21 = String.Format("，并购买了{0}",uVar18,0);
              }
              if ((uVar21 != 0) &&
                 (lVar15 = il2cpp_internal(uVar21,*(uint64 *)(*plVar12 + 64))) == null) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              if (*(uint32 *)(plVar12 + 3) < 4) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              plVar12[7] = uVar21;
              il2cpp_internal(plVar12 + 7,uVar21);
              uVar8 = String.Format(uVar8,plVar12,0);
              HeroData.AddLog(hero,uVar8,0);
              HeroData.ChangeLivingSkillExp
                        (hero,3,((float)*(int *)(hero + 184) * 0.25 + 1.0) * (fVar31 + fVar31),0,0)
              ;
              if (*(char *)(hero + 180) == false) goto LAB_1814a6d18;
              lVar15 = HeroData.GetForce(hero,0,0);
              if (lVar15 != null) {
                fVar31 = (float)ForceData.GetResourcePercent(lVar15,0,0);
                if (0.9 < fVar31) {
                  lVar15 = il2cpp_internal(DAT_181d6f030);
                  FUN_180f58a90(lVar15,DAT_181d678f8);
                  goto LAB_1814a6dd0;
                }
                lVar15 = HeroData.GetForce(hero,0,0);
                if (lVar15 != null) {
                  fVar31 = (float)ForceData.GetResourcePercent(lVar15,0,0);
                  if (0.3 <= fVar31) goto LAB_1814a6d18;
                  lVar15 = il2cpp_internal(DAT_181d6f030);
                  FUN_180f58a90(lVar15,DAT_181d678f8);
                  goto LAB_1814a6a13;
                }
              }
            }
            break;
          }
          GlobalData.RandomRange();
          cVar4 = AIController.CheckHeroItemNumBiggerThanMax(this,hero);
          if (cVar4) goto LAB_1814a67d1;
          if (*(int64 *)(hero + 0x220) == 0) break;
          iVar5 = *(int *)(*(int64 *)(hero + 0x220) + 24);
          fVar24 = (float)FUN_1801f7f00();
          if ((float)iVar5 < fVar24 * 200.0) goto LAB_1814a67d1;
          dVar26 = (double)GlobalData.RandomRangeDouble(0,0);
          uVar7 = (uint32)((uint64)in_stack_fffffffffffffe98 >> 32);
          uVar35 = (uint32)((uint64)in_stack_fffffffffffffea0 >> 32);
          uVar37 = (uint32)((uint64)in_stack_fffffffffffffea8 >> 32);
          if ((double)fVar30 <= dVar26) goto LAB_1814a67d1;
          if (uVar21 == 0) {
        LAB_1814a66ed:
            lVar15 = FUN_18046c0a0(0);
            HeroData.GetMaxBuyValue(hero);
            if (lVar15 == null) break;
            in_stack_fffffffffffffe88 = 0;
            lVar15 = GameController.GenerateRandomItemValue(lVar15);
            AIController.HeroBuyItem(this,hero,lVar15,0,in_stack_fffffffffffffe88);
          }
          else {
            HeroData.GetForceStorageDiscount(hero,uVar21,0);
            uVar22 = HeroData.GetMaxBuyValue(hero);
            in_stack_fffffffffffffea8 = CONCAT44(uVar37,uVar22);
            in_stack_fffffffffffffea0 = CONCAT44(uVar35,0xbf800000);
            in_stack_fffffffffffffe98 = CONCAT44(uVar7,0xffffffff);
            lVar15 = ItemListData.FindRandomItem
                               (uVar21,0xffffffff,999999,0,CONCAT44(uVar6,0xffffffff),0,
                                in_stack_fffffffffffffe98,in_stack_fffffffffffffea0,
                                in_stack_fffffffffffffea8,0);
            if (lVar15 == null) goto LAB_1814a66ed;
            in_stack_fffffffffffffe88 = 0;
            AIController.HeroBuyItemFromForceStorage(this,hero,lVar15,uVar21,0);
          }
          cVar4 = FUN_1816fd990(uVar18,"",0);
          uVar14 = "/";
          if (cVar4) {
            uVar14 = "";
          }
          if (lVar15 == null) break;
          ItemData.Name(lVar15,1,0);
          uVar18 = String.Concat(uVar18,uVar14);
          fVar30 = fVar30 * 0.7;
          fVar31 = fVar31 + (float)*(int *)(lVar15 + 56);
        }
        goto LAB_1814aac56;
        while( true ) {
          fVar31 = (float)ForceData.GetResourcePercent(lVar10);
          if (fVar31 < 0.3) {
            if (lVar15 == null) goto LAB_1814aac56;
            FUN_181814fa0(lVar15);
          }
          iVar20 = iVar20 + 1;
          if (4 < iVar20) break;
        LAB_1814a6dd0:
          lVar10 = HeroData.GetForce(hero,0,0);
          if (lVar10 == null) goto LAB_1814aac56;
        }
        if (lVar15 == null) goto LAB_1814aac56;
        if (0 < *(int *)(lVar15 + 24)) {
          lVar10 = HeroData.GetForce(hero,0,0);
          if ((lVar10 == null) || (*(int64 *)(lVar10 + 136) == 0)) goto LAB_1814aac56;
          if (*(int *)(*(int64 *)(lVar10 + 136) + 24) == 0) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar10 = HeroData.GetForce(hero,0,0);
          if (lVar10 == null) goto LAB_1814aac56;
          ForceData.GetResourcePercent(lVar10,0,0);
          GlobalData.RandomRange();
          iVar20 = Mathf.RoundToInt();
          lVar10 = HeroData.GetForce(hero,0,0);
          if (lVar10 == null) goto LAB_1814aac56;
          uVar19 = 0;
          uVar21 = 0;
          uVar8 = 0;
          ForceData.ChangeResource(lVar10,0);
          local_134 = Mathf.RoundToInt(((float)iVar20 * 0.9) / (float)*(int *)(lVar15 + 24),0);
          uVar18 = "";
          while ((int)uVar19 < *(int *)(lVar15 + 24)) {
            uVar14 = "/";
            if ((int)uVar21 == 0) {
              uVar14 = "";
            }
            lVar10 = *(int64 *)(pStatics + 0x430);
            uVar6 = FUN_1800d6750(lVar15,uVar21,DAT_181d68270);
            if (lVar10 == null) goto LAB_1814aac56;
            uVar8 = FUN_180002f80(lVar10,uVar6,DAT_181d7c9c0);
            uVar9 = Int32.ToString(&local_134,0);
            uVar18 = String.Concat(uVar18,uVar14,uVar8,uVar9,0);
            lVar10 = HeroData.GetForce(hero,0,0);
            uVar6 = FUN_1800d6750(lVar15,uVar21);
            if (lVar10 == null) goto LAB_1814aac56;
            uVar8 = 0;
            ForceData.ChangeResource(lVar10,uVar6);
            uVar19 = (int)uVar21 + 1;
            uVar21 = (uint64)uVar19;
          }
          uVar34 = HeroData.Name(hero,CONCAT71((int7)(uVar21 >> 8),1),0);
          local_114 = iVar20;
          uVar21 = il2cpp_value_box(DAT_181d5b2f8,&local_114);
          uVar9 = "{0}使用门派银钱{1}两，购买{2}。";
          goto LAB_1814a6d02;
        }
        goto LAB_1814a6d18;
        while( true ) {
          fVar31 = (float)ForceData.GetResourcePercent(lVar10);
          if (0.8 < fVar31) {
            if (lVar15 == null) goto LAB_1814aac56;
            FUN_181814fa0(lVar15);
          }
          iVar20 = iVar20 + 1;
          if (4 < iVar20) break;
        LAB_1814a6a13:
          lVar10 = HeroData.GetForce(hero,0,0);
          if (lVar10 == null) goto LAB_1814aac56;
        }
        if (lVar15 == null) goto LAB_1814aac56;
        if (0 < *(int *)(lVar15 + 24)) {
          iVar20 = 0;
          uVar21 = "";
          for (uVar19 = 0; (int)uVar19 < *(int *)(lVar15 + 24); uVar19 = uVar19 + 1) {
            lVar10 = HeroData.GetForce(hero);
            if (lVar10 == null) goto LAB_1814aac56;
            lVar10 = *(int64 *)(lVar10 + 136);
            if (*(uint32 *)(lVar15 + 24) <= uVar19) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar10 == null) goto LAB_1814aac56;
            if (*(uint32 *)(lVar10 + 24) <=
                lVar15[uVar19]) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar10 = HeroData.GetForce(hero,0,0);
            if (*(uint32 *)(lVar15 + 24) <= uVar19) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar10 == null) goto LAB_1814aac56;
            ForceData.GetResourcePercent
                      (lVar10,*(uint32 *)
                               (*(int64 *)(lVar15 + 16) + 32 + (int64)(int)uVar19 * 4),0);
            GlobalData.RandomRange();
            local_140 = Mathf.RoundToInt();
            uVar18 = "/";
            if (uVar19 == 0) {
              uVar18 = "";
            }
            lVar10 = *(int64 *)(pStatics + 0x430);
            uVar6 = FUN_1800d6750(lVar15,uVar19,DAT_181d68270);
            if (lVar10 == null) goto LAB_1814aac56;
            uVar8 = FUN_180002f80(lVar10,uVar6,DAT_181d7c9c0);
            uVar9 = Int32.ToString(&local_140,0);
            uVar21 = String.Concat(uVar21,uVar18,uVar8,uVar9,0);
            iVar5 = Mathf.RoundToInt((float)local_140 * 0.9,0);
            iVar20 = iVar20 + iVar5;
            lVar10 = HeroData.GetForce(hero,0,0);
            FUN_1800d6750(lVar15,uVar19);
            if (lVar10 == null) goto LAB_1814aac56;
            ForceData.ChangeResource(lVar10);
          }
          lVar15 = HeroData.GetForce(hero,0,0);
          if (lVar15 == null) goto LAB_1814aac56;
          uVar8 = 0;
          ForceData.ChangeResource(lVar15,0);
          uVar34 = HeroData.Name(hero,1,0);
          local_118 = iVar20;
          uVar18 = il2cpp_value_box(DAT_181d5b2f8,&local_118);
          uVar9 = "{0}出售门派{1}，换取门派银钱{2}两。";
        LAB_1814a6d02:
          uVar8 = String.Format(uVar9,uVar34,uVar21,uVar18,0,uVar8);
          HeroData.AddLog(hero,uVar8,0);
        }
        LAB_1814a6d18:
        uVar18 = 0;
        goto switchD_1814a4990_caseD_0;
    }

    // Token : 0x60009D5
    // RVA   : 0x14A1B80   Offset: 0x14A0380   Length: 0x3A8
    public void AICheckRemoveFriend(HeroData hero)
    {
        uint uVar1;
        uint uVar2;
        int iVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        ulong uVar7;
        long lVar8;
        double dVar9;
        dVar9 = (double)GlobalData.RandomRangeDouble(0,0);
        if ((hero != null) && (lVar6 = *(int64 *)(hero + 0x348)) != null) {
          iVar3 = *(int *)(lVar6 + 24);
          if ((double)((float)(iVar3 + -2) * 0.2) < dVar9) {
            return;
          }
          if (*(char *)(hero + 92) == false) {
            uVar1 = GlobalData.RandomRange(0,iVar3,0,0);
            if (*(uint32 *)(lVar6 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            iVar3 = lVar6[uVar1];
        LAB_1814a1e31:
            if (iVar3 == -1) {
              return;
            }
            HeroData.RemoveFriend(hero,iVar3,0,0);
            uVar5 = HeroData.Name(hero,1,0);
            lVar6 = FUN_18046c0a0(0);
            if ((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) {
              lVar6 = WorldData.GetHero(*(int64 *)(lVar6 + 32),iVar3,0);
              if (lVar6 != null) {
                uVar7 = HeroData.Name(lVar6,1,0);
                uVar5 = String.Format("{0}与{1}情谊渐浅，断绝了好友关系。",uVar5,uVar7,0);
                HeroData.AddLog(hero,uVar5,0);
                lVar6 = FUN_18046c0a0(0);
                if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                   (lVar6 = WorldData.GetHero(*(int64 *)(lVar6 + 32),iVar3,0)) != null) {
                  HeroData.AddLog(lVar6,uVar5,0);
                  return;
                }
              }
            }
          }
          else {
            lVar6 = il2cpp_internal(DAT_181d6f030);
            FUN_180f58a90(lVar6,DAT_181d678f8);
            uVar1 = 0;
            lVar8 = 32;
            while (lVar4 = *(int64 *)(hero + 0x348)) != null {
              if ((int)*(uint32 *)(lVar4 + 24) <= (int)uVar1) {
                if (lVar6 != null) {
                  iVar3 = *(int *)(lVar6 + 24);
                  if (iVar3 < 1) {
                    return;
                  }
                  uVar2 = GlobalData.RandomRange(0,iVar3,0,0);
                  iVar3 = FUN_1800d6750(lVar6,uVar2,DAT_181d68270);
                  goto LAB_1814a1e31;
                }
                break;
              }
              if (*(uint32 *)(lVar4 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (*(int *)(*(int64 *)(lVar4 + 16) + lVar8) != 0) {
                lVar4 = FUN_18046c0a0(0);
                if (lVar4 == null) break;
                lVar4 = *(int64 *)(lVar4 + 32);
                if (((*(int64 *)(hero + 0x348) == 0) ||
                    (uVar2 = FUN_1800d6750(*(int64 *)(hero + 0x348),uVar1), lVar4 == null)) ||
                   (lVar4 = WorldData.GetHero(lVar4,uVar2)) == null) break;
                if (*(char *)(lVar4 + 92) == false) {
                  if ((*(int64 *)(hero + 0x348) == 0) ||
                     (uVar2 = FUN_1800d6750(*(int64 *)(hero + 0x348),uVar1,DAT_181d68270),
                     lVar6 == null)) break;
                  FUN_181814fa0(lVar6,uVar2);
                }
              }
              uVar1 = uVar1 + 1;
              lVar8 = lVar8 + 4;
            }
          }
        }
    }

    // Token : 0x60009D6
    // RVA   : 0x14A1F30   Offset: 0x14A0730   Length: 0x3B8
    public void AICheckRemoveHater(HeroData hero)
    {
        uint uVar1;
        uint uVar2;
        int iVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        ulong uVar7;
        long lVar8;
        double dVar9;
        if ((hero != null) && (*(int64 *)(hero + 0x350) != 0)) {
          if (*(int *)(*(int64 *)(hero + 0x350) + 24) < 1) {
            return;
          }
          dVar9 = (double)GlobalData.RandomRangeDouble(0,0);
          lVar6 = *(int64 *)(hero + 0x350);
          if (lVar6 != null) {
            iVar3 = *(int *)(lVar6 + 24);
            if ((double)((float)iVar3 * 0.25) < dVar9) {
              return;
            }
            if (*(char *)(hero + 92) == false) {
              uVar1 = GlobalData.RandomRange(0,iVar3,0,0);
              if (*(uint32 *)(lVar6 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              iVar3 = lVar6[uVar1];
        LAB_1814a21f1:
              if (iVar3 == -1) {
                return;
              }
              HeroData.RemoveHater(hero,iVar3,0,0);
              uVar5 = HeroData.Name(hero,1,0);
              lVar6 = FUN_18046c0a0(0);
              if ((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) {
                lVar6 = WorldData.GetHero(*(int64 *)(lVar6 + 32),iVar3,0);
                if (lVar6 != null) {
                  uVar7 = HeroData.Name(lVar6,1,0);
                  uVar5 = String.Format("{0}与{1}冰释前嫌，化解了二人间的仇恨。",uVar5,uVar7,0);
                  HeroData.AddLog(hero,uVar5,0);
                  lVar6 = FUN_18046c0a0(0);
                  if (((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) &&
                     (lVar6 = WorldData.GetHero(*(int64 *)(lVar6 + 32),iVar3,0)) != null) {
                    HeroData.AddLog(lVar6,uVar5,0);
                    return;
                  }
                }
              }
            }
            else {
              lVar6 = il2cpp_internal(DAT_181d6f030);
              FUN_180f58a90(lVar6,DAT_181d678f8);
              uVar1 = 0;
              lVar8 = 32;
              while (lVar4 = *(int64 *)(hero + 0x350)) != null {
                if ((int)*(uint32 *)(lVar4 + 24) <= (int)uVar1) {
                  if (lVar6 != null) {
                    iVar3 = *(int *)(lVar6 + 24);
                    if (iVar3 < 1) {
                      return;
                    }
                    uVar2 = GlobalData.RandomRange(0,iVar3,0,0);
                    iVar3 = FUN_1800d6750(lVar6,uVar2,DAT_181d68270);
                    goto LAB_1814a21f1;
                  }
                  break;
                }
                if (*(uint32 *)(lVar4 + 24) <= uVar1) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                if (*(int *)(*(int64 *)(lVar4 + 16) + lVar8) != 0) {
                  lVar4 = FUN_18046c0a0(0);
                  if (lVar4 == null) break;
                  lVar4 = *(int64 *)(lVar4 + 32);
                  if (((*(int64 *)(hero + 0x350) == 0) ||
                      (uVar2 = FUN_1800d6750(*(int64 *)(hero + 0x350),uVar1), lVar4 == null)) ||
                     (lVar4 = WorldData.GetHero(lVar4,uVar2)) == null) break;
                  if (*(char *)(lVar4 + 92) == false) {
                    if ((*(int64 *)(hero + 0x350) == 0) ||
                       (uVar2 = FUN_1800d6750(*(int64 *)(hero + 0x350),uVar1,DAT_181d68270),
                       lVar6 == null)) break;
                    FUN_181814fa0(lVar6,uVar2);
                  }
                }
                uVar1 = uVar1 + 1;
                lVar8 = lVar8 + 4;
              }
            }
          }
        }
    }

    // Token : 0x60009D7
    // RVA   : 0x14B0D70   Offset: 0x14AF570   Length: 0x231
    public void NPCGoInPrison(HeroData targetHero, HeroData sourceHero)
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        ulong uVar4;
        float fVar5;
        ulong uVar6;
        if (**(int **)(DAT_181d4ef00 + 184) == 2) {
          return;
        }
        if (targetHero != null) {
          uVar2 = HeroData.Name(targetHero,1,0);
          if (sourceHero != null) {
            uVar3 = HeroData.Name(sourceHero,1,0);
            uVar4 = HeroData.AtAreaName(targetHero,0);
            uVar6 = 0;
            uVar2 = String.Format("{0}被{1}抓捕入狱，关押在{2}之中。",uVar2,uVar3,uVar4,0);
            HeroData.AddLog(targetHero,uVar2,0);
            fVar5 = (float)HeroData.Favor(targetHero,0,0);
            if ((50.0 <= fVar5) && (*(int *)(sourceHero + 88) != 0)) {
              uVar2 = *(uint64 *)(targetHero + 104);
              lVar1 = **(int64 **)(DAT_181d5a578 + 184);
              uVar3 = HeroData.Name(sourceHero,1,0);
              uVar4 = HeroData.AtAreaName(targetHero,0);
              uVar3 = String.Format("#PlayerName#，说来惭愧。近日我一时失手，被{0}抓入狱中，眼下正关押在{1}。\n你若得空不妨来探望一番，也好一解我困坐囹圄之苦。",uVar3,uVar4,0);
              uVar4 = new MailData(uVar2,uVar3,0,uVar6 & 0xffffffffffffff00,0,0);
              if (lVar1 == null) throw; // [null/range check failed]
              InfoController.AddMail(lVar1,uVar4,0);
            }
            uVar2 = new HeroAIData(16,99);
            HeroData.SetHeroAIData(targetHero,uVar2,0);
            HeroData.GoInPrison(targetHero,0);
            return;
          }
        }
    }

    // Token : 0x60009D8
    // RVA   : 0x14ABD20   Offset: 0x14AA520   Length: 0x1F5
    public void HeroLoseFightOnBigMap(HeroData hero)
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        if (hero == null) goto LAB_1814abf10;
        if (*(int *)(hero + 192) < 0) {
          if (*(char *)(hero + 0x385) == false) {
            if (*(int64 *)(hero + 64) == 0) goto LAB_1814abf10;
            if (*(int *)(*(int64 *)(hero + 64) + 48) < 0) {
              lVar2 = FUN_18046c0a0(0);
              lVar3 = FUN_18046bbe0(0);
              if (lVar3 == null) goto LAB_1814abf10;
              uVar1 = BigMapController.GetNearAreaID(lVar3,*(uint64 *)(hero + 200),0);
              if (lVar2 == null) goto LAB_1814abf10;
              GameController.HeroEnterArea(lVar2,hero,uVar1,0);
            }
            else {
              lVar2 = FUN_18046c0a0(0);
              if ((*(int64 *)(hero + 64) == 0) || (lVar2 == null)) goto LAB_1814abf10;
              GameController.HeroEnterArea
                        (lVar2,hero,*(uint32 *)(*(int64 *)(hero + 64) + 48),0);
            }
          }
          else {
            HeroData.SetNeedRemove(hero,0);
          }
          lVar2 = *(int64 *)(*(int64 *)(DAT_181d8baa8 + 184) + 16);
          if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 144)) == null) {
        LAB_1814abf10:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          FUN_181827900(lVar2,hero,DAT_181d63d78);
        }
    }

    // Token : 0x60009D9
    // RVA   : 0x14A4090   Offset: 0x14A2890   Length: 0x68
    public bool CheckHeroMoneyBiggerThanMin(HeroData hero, float rate)
    {
        int iVar1;
        float extraout_XMM0_Da;
        if ((hero != null) && (*(int64 *)(hero + 0x220) != 0)) {
          iVar1 = *(int *)(*(int64 *)(hero + 0x220) + 24);
          FUN_1801f7f00(0x40000000);
          return extraout_XMM0_Da * rate * 200.0 <= (float)iVar1;
        }
    }

    // Token : 0x60009DA
    // RVA   : 0x14AAE90   Offset: 0x14A9690   Length: 0x58
    public float GetHeroMoneyRate(HeroData hero)
    {
        int iVar1;
        float fVar2;
        if ((hero != null) && (*(int64 *)(hero + 0x220) != 0)) {
          iVar1 = *(int *)(*(int64 *)(hero + 0x220) + 24);
          fVar2 = (float)FUN_1801f7f00(0x40000000);
          return (float)iVar1 / (fVar2 * 400.0);
        }
    }

    // Token : 0x60009DB
    // RVA   : 0x14A4050   Offset: 0x14A2850   Length: 0x33
    public bool CheckHeroItemWeightBiggerThanMax(HeroData hero)
    {
        long lVar1;
        if ((hero != null) && (lVar1 = *(int64 *)(hero + 0x220)) != null) {
          return CONCAT71((int7)((uint64)lVar1 >> 8),
                          0.7 < *(float *)(lVar1 + 28) / *(float *)(lVar1 + 32));
        }
    }

    // Token : 0x60009DC
    // RVA   : 0x14A3F20   Offset: 0x14A2720   Length: 0x12F
    public bool CheckHeroItemNumBiggerThanMax(HeroData hero, float rate)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        uint32
        AIController.CheckHeroItemNumBiggerThanMax(uint64 this,int64 hero,float rate)
        {
        int iVar1;
        int iVar2;
        int64 lVar3;
        float fVar4;
        if (((hero != null) && (*(int64 *)(hero + 0x220) != 0)) &&
           (lVar3 = *(int64 *)(*(int64 *)(hero + 0x220) + 40)) != null) {
          iVar2 = *(int *)(lVar3 + 24);
          if (*pStatics != 0) {
            fVar4 = (float)GameController.GetTimeDifficulty(*pStatics,0);
            iVar1 = *(int *)(hero + 184) * 2 + 20;
            return CONCAT31((int3)((uint32)iVar1 >> 8),(float)iVar1 * rate + fVar4 * 0.5 < (float)iVar2);
          }
        }
    }

    // Token : 0x60009DD
    // RVA   : 0x14ABA20   Offset: 0x14AA220   Length: 0x2FA
    public void HeroDonateItemToForceStorage(HeroData hero, ItemData targetItem, ItemListData targetStorage)
    {
        void AIController.HeroDonateItemToForceStorage
                     (uint64 this,int64 hero,int64 targetItem,int64 targetStorage)
        {
        int64 lVar1;
        int64 *plVar2;
        int64 lVar3;
        int64 lVar4;
        uint64 uVar5;
        float fVar6;
        int local_res10 [2];
        if (hero != null) {
          HeroData.LoseItem(hero,targetItem,0,0);
          if (targetStorage != null) {
            ItemListData.GetItem(targetStorage,targetItem,0,0);
            if (targetItem != null) {
              fVar6 = (float)Mathf.Max(0x3f800000,(float)*(int *)(targetItem + 56) * 0.02,0);
              HeroData.ChangeForceContribution(hero);
              lVar1 = ItemListData.GetForce(targetStorage,0);
              if (lVar1 != null) {
                lVar1 = ForceData.MainArea(lVar1,0);
                plVar2 = (int64 *)FUN_1800d60b0(DAT_181d7f180,4);
                lVar3 = HeroData.GetHeroName(hero,1,0);
                if (plVar2 != (int64 *)0) {
                  if (lVar3 != null) {
                    lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar2 + 64));
                    if (lVar4 == null) {
                      uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar5,0);
                    }
                  }
                  if ((int)plVar2[3] == 0) {
                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar5,0);
                  }
                  plVar2[4] = lVar3;
                  il2cpp_internal(plVar2 + 4,lVar3);
                  lVar3 = ItemData.Name(targetItem,1,0);
                  if (lVar3 != null) {
                    lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar2 + 64));
                    if (lVar4 == null) {
                      uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar5,0);
                    }
                  }
                  if (*(uint32 *)(plVar2 + 3) < 2) {
                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar5,0);
                  }
                  plVar2[5] = lVar3;
                  il2cpp_internal(plVar2 + 5,lVar3);
                  local_res10[0] = (int)fVar6;
                  lVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res10);
                  if (lVar3 != null) {
                    lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar2 + 64));
                    if (lVar4 == null) {
                      uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar5,0);
                    }
                  }
                  if (*(uint32 *)(plVar2 + 3) < 3) {
                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar5,0);
                  }
                  plVar2[6] = lVar3;
                  il2cpp_internal(plVar2 + 6,lVar3);
                  lVar3 = ItemListData.GetForce(targetStorage,0);
                  if (lVar3 != null) {
                    lVar3 = *(int64 *)(lVar3 + 24);
                    if (lVar3 != null) {
                      lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar2 + 64));
                      if (lVar4 == null) {
                        uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar5,0);
                      }
                    }
                    if (*(uint32 *)(plVar2 + 3) < 4) {
                      uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar5,0);
                    }
                    plVar2[7] = lVar3;
                    il2cpp_internal(plVar2 + 7,lVar3);
                    uVar5 = String.Format("{0}向{3}仓库捐赠了{1}，获取功绩{2}",plVar2,0);
                    if (lVar1 != null) {
                      AreaData.AddLog(lVar1,uVar5,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60009DE
    // RVA   : 0x14AB660   Offset: 0x14A9E60   Length: 0x33B
    public void HeroBuyItemFromForceStorage(HeroData hero, ItemData targetItem, ItemListData targetStorage)
    {
        void AIController.HeroBuyItemFromForceStorage
                     (uint64 this,int64 hero,int64 targetItem,int64 targetStorage)
        {
        int64 lVar1;
        int64 *plVar2;
        int64 lVar3;
        int64 lVar4;
        int iVar5;
        float fVar6;
        float fVar7;
        int local_res18 [2];
        uint8 uVar8;
        uint64 uVar9;
        if ((targetItem != null) && (iVar5 = *(int *)(targetItem + 56), hero != null)) {
          fVar6 = (float)HeroData.GetTradeValueRate(hero,1,0);
          fVar7 = (float)HeroData.GetForceStorageDiscount(hero,targetStorage,0);
          iVar5 = (int)(fVar7 * (float)iVar5 * fVar6);
          HeroData.ChangeMoney(hero,-iVar5,0,0);
          if (targetStorage != null) {
            lVar1 = ItemListData.GetForce(targetStorage,0);
            if (lVar1 != null) {
              uVar9 = 0;
              uVar8 = 1;
              ForceData.ChangeResource(lVar1,0);
              ItemListData.LoseItem(targetStorage,targetItem,0,0,uVar8,uVar9);
              HeroData.GetItem(hero,targetItem,0,0);
              lVar1 = ItemListData.GetForce(targetStorage,0);
              if (lVar1 != null) {
                lVar1 = ForceData.MainArea(lVar1,0);
                plVar2 = (int64 *)FUN_1800d60b0(DAT_181d7f180,4);
                lVar3 = HeroData.GetHeroName(hero,1,0);
                if (plVar2 != (int64 *)0) {
                  if (lVar3 != null) {
                    lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar2 + 64));
                    if (lVar4 == null) {
                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar9,0);
                    }
                  }
                  if ((int)plVar2[3] == 0) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  plVar2[4] = lVar3;
                  il2cpp_internal(plVar2 + 4,lVar3);
                  lVar3 = ItemData.Name(targetItem,1,0);
                  if (lVar3 != null) {
                    lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar2 + 64));
                    if (lVar4 == null) {
                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar9,0);
                    }
                  }
                  if (*(uint32 *)(plVar2 + 3) < 2) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  plVar2[5] = lVar3;
                  il2cpp_internal(plVar2 + 5,lVar3);
                  local_res18[0] = iVar5;
                  lVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
                  if (lVar3 != null) {
                    lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar2 + 64));
                    if (lVar4 == null) {
                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar9,0);
                    }
                  }
                  if (*(uint32 *)(plVar2 + 3) < 3) {
                    uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar9,0);
                  }
                  plVar2[6] = lVar3;
                  il2cpp_internal(plVar2 + 6,lVar3);
                  lVar3 = ItemListData.GetForce(targetStorage,0);
                  if (lVar3 != null) {
                    lVar3 = *(int64 *)(lVar3 + 24);
                    if (lVar3 != null) {
                      lVar4 = il2cpp_internal(lVar3,*(uint64 *)(*plVar2 + 64));
                      if (lVar4 == null) {
                        uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar9,0);
                      }
                    }
                    if (*(uint32 *)(plVar2 + 3) < 4) {
                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar9,0);
                    }
                    plVar2[7] = lVar3;
                    il2cpp_internal(plVar2 + 7,lVar3);
                    uVar9 = String.Format("{0}从{3}仓库购买了{1}，花费银两{2}",plVar2,0);
                    if (lVar1 != null) {
                      AreaData.AddLog(lVar1,uVar9,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60009DF
    // RVA   : 0x14AB9A0   Offset: 0x14AA1A0   Length: 0x74
    public void HeroBuyItem(HeroData hero, ItemData targetItem)
    {
        int iVar1;
        float fVar2;
        if ((targetItem != null) && (iVar1 = *(int *)(targetItem + 56), hero != null)) {
          fVar2 = (float)HeroData.GetTradeValueRate(hero,1,0);
          HeroData.ChangeMoney(hero,-(int)((float)iVar1 * fVar2),0,0);
          HeroData.GetItem(hero,targetItem,0,0);
          return;
        }
    }

    // Token : 0x60009E0
    // RVA   : 0x14AC1A0   Offset: 0x14AA9A0   Length: 0x72
    public void HeroSellItem(HeroData hero, ItemData targetItem)
    {
        int iVar1;
        float fVar2;
        if ((targetItem != null) && (iVar1 = *(int *)(targetItem + 56), hero != null)) {
          fVar2 = (float)HeroData.GetTradeValueRate(hero,0,0);
          HeroData.ChangeMoney(hero,(int)((float)iVar1 * fVar2),0,0);
          HeroData.LoseItem(hero,targetItem,0,0);
          return;
        }
    }

    // Token : 0x60009E1
    // RVA   : 0x14ABF20   Offset: 0x14AA720   Length: 0x27B
    public ItemData HeroManageEquipmentTrade(HeroData hero, ItemListData targetForceStorage, ItemData nowEquip, int subType, int littleType)
    {
        int64 AIController.HeroManageEquipmentTrade
                         (uint64 this,int64 hero,int64 targetForceStorage,int64 nowEquip,
                         uint32 subType,uint32 littleType)
        {
        int iVar1;
        int64 lVar2;
        int64 lVar3;
        float fVar4;
        uint32 uVar5;
        float fVar6;
        uint64 in_stack_ffffffffffffff98;
        uint32 uVar9;
        int64 lVar7;
        uint64 uVar8;
        uint64 in_stack_ffffffffffffffa0;
        uint64 uVar10;
        uint64 in_stack_ffffffffffffffa8;
        uint32 uVar11;
        uint64 in_stack_ffffffffffffffb8;
        uint32 uVar13;
        uint64 uVar12;
        uVar9 = (uint32)((uint64)in_stack_ffffffffffffff98 >> 32);
        uVar5 = (uint32)((uint64)in_stack_ffffffffffffffa0 >> 32);
        uVar11 = (uint32)((uint64)in_stack_ffffffffffffffa8 >> 32);
        uVar13 = (uint32)((uint64)in_stack_ffffffffffffffb8 >> 32);
        if (targetForceStorage != null) {
          if (nowEquip == null) {
            fVar6 = 0.0;
          }
          else {
            fVar6 = (float)*(int *)(nowEquip + 56);
          }
          if (hero == null) throw; // [null/range check failed]
          HeroData.GetForceStorageDiscount(hero,targetForceStorage,0);
          fVar4 = (float)HeroData.GetMaxBuyValue(hero);
          if (fVar6 < fVar4) {
            lVar2 = il2cpp_internal(DAT_181d6f030);
            FUN_180f58a90(lVar2,DAT_181d678f8);
            if (lVar2 == null) throw; // [null/range check failed]
            FUN_181814fa0(lVar2,subType,DAT_181d67a78);
            HeroData.GetForceStorageDiscount(hero,targetForceStorage,0);
            uVar5 = HeroData.GetMaxBuyValue(hero);
            lVar7 = (uint64)uVar9 << 32;
            lVar3 = ItemListData.FindRandomItem
                              (targetForceStorage,0xffffffff,999999,0,lVar7,lVar2,CONCAT44(uVar11,littleType),fVar6,
                               CONCAT44(uVar13,uVar5),0);
            uVar9 = (uint32)((uint64)lVar7 >> 32);
            uVar5 = (uint32)((uint64)lVar2 >> 32);
            if (lVar3 != null) {
              AIController.HeroBuyItemFromForceStorage(this,hero,lVar3,targetForceStorage,0);
              return lVar3;
            }
          }
        }
        if (nowEquip != null) {
          return 0;
        }
        lVar2 = FUN_18046c0a0(0);
        if ((hero != null) && (HeroData.GetMaxBuyValue(hero), lVar2 != null)) {
          uVar12 = 0;
          uVar11 = 0xffffffff;
          uVar10 = CONCAT44(uVar5,littleType);
          uVar8 = CONCAT44(uVar9,subType);
          lVar3 = hero;
          lVar2 = GameController.GenerateRandomItemValue(lVar2);
          if (lVar2 != null) {
            iVar1 = *(int *)(lVar2 + 56);
            fVar6 = (float)HeroData.GetTradeValueRate(hero,1,0);
            HeroData.ChangeMoney
                      (hero,-(int)((float)iVar1 * fVar6),0,0,uVar8,uVar10,lVar3,uVar11,uVar12);
            HeroData.GetItem(hero,lVar2,0,0);
            return lVar2;
          }
        }
    }

    // Token : 0x60009E2
    // RVA   : 0x14B14B0   Offset: 0x14AFCB0   Length: 0xCF
    public void StartMoveToAnotherArea(HeroData hero, int targetID)
    {
        ulong uVar1;
        ulong uVar2;
        uint[] local_res18 = new uint[2];
        local_res18[0] = targetID;
        uVar1 = Int32.ToString(local_res18,0);
        uVar2 = new HeroAIData(1,uVar1,99,0);
        AIController.SetAIStuff(this,hero,uVar2,0,0);
        if (this.needLeaveHero != null) {
          FUN_181827900(this.needLeaveHero,hero,DAT_181d63d78);
          return;
        }
    }

    // Token : 0x60009E3
    // RVA   : 0x14B1F80   Offset: 0x14B0780   Length: 0x121
    public void /*ctor*/()
    {
        ulong uVar1;
        long lVar2;
        uVar1 = il2cpp_internal(DAT_181d6e6b0);
        FUN_180f58a90(uVar1,DAT_181d63c78);
        this.needLeaveHero = uVar1;
        lVar2 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(lVar2,DAT_181d678f8);
        if (lVar2 != null) {
          FUN_181814fa0(lVar2,0x3e0,DAT_181d67a78);
          FUN_181814fa0(lVar2,0x3e1,DAT_181d67a78);
          FUN_181814fa0(lVar2,0x3e2,DAT_181d67a78);
          FUN_181814fa0(lVar2,0x3e3,DAT_181d67a78);
          this.speSkillIDList = lVar2;
          FUN_18044ef50(this,0);
          return;
        }
    }

    // Token : 0x60009E4
    // RVA   : 0x14B18A0   Offset: 0x14B00A0   Length: 0x6D1
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d84cc0 + 184);
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar1,DAT_181d7c250);
        if (lVar1 != null) {
          FUN_181827900(lVar1,"无所事事",DAT_181d7c3d0);
          FUN_181827900(lVar1,"前往",DAT_181d7c3d0);
          FUN_181827900(lVar1,"闲逛",DAT_181d7c3d0);
          FUN_181827900(lVar1,"休息",DAT_181d7c3d0);
          FUN_181827900(lVar1,"治疗",DAT_181d7c3d0);
          FUN_181827900(lVar1,"修炼",DAT_181d7c3d0);
          FUN_181827900(lVar1,"学习",DAT_181d7c3d0);
          FUN_181827900(lVar1,"获取",DAT_181d7c3d0);
          FUN_181827900(lVar1,"赚钱",DAT_181d7c3d0);
          FUN_181827900(lVar1,"交易",DAT_181d7c3d0);
          FUN_181827900(lVar1,"探索",DAT_181d7c3d0);
          FUN_181827900(lVar1,"交友",DAT_181d7c3d0);
          FUN_181827900(lVar1,"切磋",DAT_181d7c3d0);
          FUN_181827900(lVar1,"战斗",DAT_181d7c3d0);
          FUN_181827900(lVar1,"完成委托",DAT_181d7c3d0);
          FUN_181827900(lVar1,"经历奇遇",DAT_181d7c3d0);
          FUN_181827900(lVar1,"被囚禁",DAT_181d7c3d0);
          FUN_181827900(lVar1,"降低恶名",DAT_181d7c3d0);
          FUN_181827900(lVar1,"初习",DAT_181d7c3d0);
          FUN_181827900(lVar1,"加强管理",DAT_181d7c3d0);
          FUN_181827900(lVar1,"暗中破坏",DAT_181d7c3d0);
          FUN_181827900(lVar1,"烹饪",DAT_181d7c3d0);
          FUN_181827900(lVar1,"炼药",DAT_181d7c3d0);
          FUN_181827900(lVar1,"锻造",DAT_181d7c3d0);
          plVar2 = pStatics;
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          lVar1 = il2cpp_internal(DAT_181d6bd30);
          FUN_180f58a90(lVar1,DAT_181d53800);
          if (lVar1 != null) {
            FUN_181814fa0(lVar1,11,DAT_181d53880);
            FUN_181814fa0(lVar1,12,DAT_181d53880);
            FUN_181814fa0(lVar1,13,DAT_181d53880);
            plVar2 = (int64 *)(pStatics + 8);
            *plVar2 = lVar1;
            il2cpp_internal(plVar2,lVar1);
            lVar1 = il2cpp_internal(DAT_181d6bd30);
            FUN_180f58a90(lVar1,DAT_181d53800);
            if (lVar1 != null) {
              FUN_181814fa0(lVar1,1,DAT_181d53880);
              FUN_181814fa0(lVar1,19,DAT_181d53880);
              FUN_181814fa0(lVar1,20,DAT_181d53880);
              plVar2 = (int64 *)(pStatics + 16);
              *plVar2 = lVar1;
              il2cpp_internal(plVar2,lVar1);
              lVar1 = il2cpp_internal(DAT_181d6bd30);
              FUN_180f58a90(lVar1,DAT_181d53800);
              if (lVar1 != null) {
                FUN_181814fa0(lVar1,12,DAT_181d53880);
                FUN_181814fa0(lVar1,13,DAT_181d53880);
                plVar2 = (int64 *)(pStatics + 24);
                *plVar2 = lVar1;
                il2cpp_internal(plVar2,lVar1);
                lVar1 = il2cpp_internal(DAT_181d6bcb0);
                FUN_180f58a90(lVar1,DAT_181d53680);
                if (lVar1 != null) {
                  FUN_181814fa0(lVar1,1,DAT_181d53700);
                  FUN_181814fa0(lVar1,2,DAT_181d53700);
                  FUN_181814fa0(lVar1,3,DAT_181d53700);
                  FUN_181814fa0(lVar1,4,DAT_181d53700);
                  FUN_181814fa0(lVar1,5,DAT_181d53700);
                  plVar2 = (int64 *)(pStatics + 32);
                  *plVar2 = lVar1;
                  il2cpp_internal(plVar2,lVar1);
                  lVar1 = il2cpp_internal(DAT_181d6f530);
                  FUN_180f58a90(lVar1,DAT_181d69a70);
                  if (lVar1 != null) {
                    FUN_181814fa0(lVar1,0,DAT_181d69af0);
                    FUN_181814fa0(lVar1,3,DAT_181d69af0);
                    FUN_181814fa0(lVar1,4,DAT_181d69af0);
                    FUN_181814fa0(lVar1,5,DAT_181d69af0);
                    plVar2 = (int64 *)(pStatics + 48);
                    *plVar2 = lVar1;
                    il2cpp_internal(plVar2,lVar1);
                    return;
                  }
                }
              }
            }
          }
        }
    }

}
