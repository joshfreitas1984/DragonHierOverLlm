// ============================================================
// Type  : AIController
// Token : 0x2000135
// ============================================================

public class AIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000798
    public static List<string> AIStuffTypeName;

    // Token: 0x4000799
    public static List<AIStuffType> InteractOtherHeroAiStuffType;

    // Token: 0x400079A
    public static List<AIStuffType> NeedBigMapMoveAiStuffType;

    // Token: 0x400079B
    public static List<AIStuffType> FightHeroAiStuffType;

    // Token: 0x400079C
    public static List<AISettingType> ExtraFocusAISettingType;

    // Token: 0x400079D
    public List<HeroData> needLeaveHero;

    // Token: 0x400079E
    private static AIController _instance;

    // Token: 0x400079F
    private readonly List<int> speSkillIDList;

    // Token: 0x40007A0
    private static List<ItemType> availablePoisonItemType;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60009E2
    // RVA   : 0x13EC8E0   Offset: 0x13EBCE0   Length: 0x58
    public static AIController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181da9de0 + 184) + 40);
    }

    // Token : 0x60009E3
    // RVA   : 0x13DD3D0   Offset: 0x13DC7D0   Length: 0x11E
    private void Awake()
    {
        var pStatics = *(int64*)(DAT_181da9de0 + 184);
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

    // Token : 0x60009E4
    // RVA   : 0x13EBDA0   Offset: 0x13EB1A0   Length: 0x323
    private void Update()
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        long lVar4;
        ulong uVar6;
        uint uVar7;
        long lVar10;
        lVar2 = this.needLeaveHero;
        if (lVar2 != null) {
          if (lVar2.Count < 1) {
            return;
          }
          lVar10 = 32;
          plVar9 = (int64 *)0;
          do {
            uVar7 = (uint32)plVar9;
            if (lVar2.Count <= (int)uVar7) {
              FUN_1812f9a10(lVar2,DAT_181d8b618);
              return;
            }
            if (lVar2 == null) break;
            if (lVar2.Count <= uVar7) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(int64 *)(lVar10 + lVar2._items) != 0) {
              if (((this.needLeaveHero == null) ||
                  (lVar2 = FUN_180002f80(this.needLeaveHero,plVar9,DAT_181d8bb98)) == null)
                 || (*(int64 *)(lVar2 + 64) == 0)) break;
              if (*(int *)(*(int64 *)(lVar2 + 64) + 16) == 1) {
                if ((this.needLeaveHero == null) ||
                   (lVar2 = FUN_180002f80(this.needLeaveHero,plVar9,DAT_181d8bb98)) == null
                   ) break;
                cVar1 = HeroData.HaveArea(lVar2,0);
                if (cVar1) {
                  if (this.needLeaveHero == null) break;
                  lVar2 = FUN_180002f80(this.needLeaveHero,plVar9,DAT_181d8bb98);
                  lVar3 = FUN_18046c0a0(0);
                  if (lVar3 == null) break;
                  lVar3 = *(int64 *)(lVar3 + 32);
                  if (((((this.needLeaveHero == null) ||
                        (lVar4 = FUN_180002f80(this.needLeaveHero,plVar9,DAT_181d8bb98),
                        lVar4 == null)) || (lVar3 == null)) ||
                      ((lVar3 = WorldData.GetArea(lVar3,*(uint32 *)(lVar4 + 192),0), lVar3 == null ||
                       (*(int64 *)(lVar3 + 64) == 0)))) ||
                     (plVar5 = (int64 *)BigMapPos.Clone(*(int64 *)(lVar3 + 64),0), lVar2 == null))
                  break;
                  plVar8 = (int64 *)0;
                  if (plVar5 != (int64 *)0) {
                  }
                  *(int64 **)(lVar2 + 200) = plVar8;
                  lVar2 = FUN_18046c0a0(0);
                  if ((this.needLeaveHero == null) ||
                     (uVar6 = FUN_180002f80(this.needLeaveHero,plVar9,DAT_181d8bb98),
                     lVar2 == null)) break;
                  GameController.HeroLeaveArea(lVar2,uVar6,0);
                  lVar2 = FUN_18046bbe0(0);
                  if ((this.needLeaveHero == null) ||
                     (uVar6 = FUN_180002f80(this.needLeaveHero,plVar9,DAT_181d8bb98),
                     lVar2 == null)) break;
                  BigMapController.CreateBigMapNpc(lVar2,uVar6,0);
                }
              }
            }
            lVar2 = this.needLeaveHero;
            plVar9 = (int64 *)(uint64)(uVar7 + 1);
            lVar10 = lVar10 + 8;
          } while (lVar2 != null);
        }
    }

    // Token : 0x60009E5
    // RVA   : 0x13DC3C0   Offset: 0x13DB7C0   Length: 0x415
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
                    if (((lVar1 == null) || (lVar1 = FUN_180002f80(lVar1,uVar3,DAT_181d90f18)) == null)
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
                    uVar2 = FUN_180002f80(lVar1,uVar3,DAT_181d90f18);
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
                            (lVar1 = FUN_180002f80(lVar1,uVar3,DAT_181d90f18)) == null) ||
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
                        uVar2 = FUN_180002f80(lVar1,uVar3,DAT_181d90f18);
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

    // Token : 0x60009E6
    // RVA   : 0x13DA290   Offset: 0x13D9690   Length: 0xD19
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
              goto LAB_1813dacd0;
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
            if (*(char *)(lVar4 + 48) != false) goto LAB_1813dacaa;
            if ((*(int64 *)(hero + 0x220) == 0) ||
               (lVar4 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null) break;
            if (*(int *)(lVar4 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 32);
            if ((lVar4 == null) || (lVar4 = FUN_180002f80(lVar4,uVar12,DAT_181d90f18)) == null) break;
            iVar1 = *(int *)(lVar4 + 24);
            uVar7 = uVar10;
            if (iVar1 == 0) {
              while( true ) {
                if ((*(int64 *)(hero + 0x1f8) == 0) ||
                   (lVar4 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 32)) == null)
                goto LAB_1813dafa4;
                if (*(int *)(lVar4 + 24) <= (int)uVar7) goto LAB_1813dacaa;
                lVar4 = FUN_180002f80(lVar4,uVar7,DAT_181d90f18);
                if (lVar4 == null) break;
                if (((*(int64 *)(hero + 0x1f8) == 0) ||
                    (lVar4 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 32)) == null) ||
                   (lVar4 = FUN_180002f80(lVar4,uVar7,DAT_181d90f18)) == null) goto LAB_1813dafa4;
                iVar1 = *(int *)(lVar4 + 56);
                lVar4 = *(int64 *)(hero + 0x108);
                if (((*(int64 *)(hero + 0x1f8) == 0) ||
                    (lVar6 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 32)) == null) ||
                   ((lVar6 = FUN_180002f80(lVar6,uVar7,DAT_181d90f18), lVar6 == null ||
                    ((*(int64 *)(lVar6 + 96) == 0 || (lVar4 == null)))))) goto LAB_1813dafa4;
                cVar3 = FUN_18182a3a0(lVar4,*(int *)(*(int64 *)(lVar6 + 96) + 20) + 3,DAT_181d8f398
                                     );
                if (!cVar3) {
                  fVar14 = 1.0;
                }
                else {
                  fVar14 = 8.0;
                }
                if ((*(int64 *)(hero + 0x220) == 0) ||
                   (lVar4 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null)
                goto LAB_1813dafa4;
                if (*(int *)(lVar4 + 24) == 0) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 32);
                if ((lVar4 == null) || (lVar4 = FUN_180002f80(lVar4,uVar12,DAT_181d90f18)) == null)
                goto LAB_1813dafa4;
                iVar2 = *(int *)(lVar4 + 56);
                lVar4 = *(int64 *)(hero + 0x108);
                if ((*(int64 *)(hero + 0x220) == 0) ||
                   (lVar6 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null)
                goto LAB_1813dafa4;
                if (*(int *)(lVar6 + 24) == 0) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar6 = *(int64 *)(*(int64 *)(lVar6 + 16) + 32);
                if ((((lVar6 == null) || (lVar6 = FUN_180002f80(lVar6,uVar12,DAT_181d90f18)) == null) ||
                    (*(int64 *)(lVar6 + 96) == 0)) || (lVar4 == null)) goto LAB_1813dafa4;
                cVar3 = FUN_18182a3a0(lVar4,*(int *)(*(int64 *)(lVar6 + 96) + 20) + 3,DAT_181d8f398
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
        LAB_1813dac28:
              uVar5 = FUN_180002f80(lVar4,uVar7,DAT_181d90f18);
              HeroData.UnequipItem(hero,uVar5,0,0,0);
              if ((*(int64 *)(hero + 0x220) == 0) ||
                 (lVar4 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null) break;
              if (*(int *)(lVar4 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 32);
              if (lVar4 == null) break;
              uVar5 = FUN_180002f80(lVar4,uVar12,DAT_181d90f18);
              HeroData.EquipItem(hero,uVar5,0,0,0);
            }
            else {
              if (iVar1 == 1) {
                while( true ) {
                  if ((*(int64 *)(hero + 0x1f8) == 0) ||
                     (lVar4 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 56)) == null)
                  goto LAB_1813dafa4;
                  if (*(int *)(lVar4 + 24) <= (int)uVar7) goto LAB_1813dacaa;
                  lVar4 = FUN_180002f80(lVar4,uVar7,DAT_181d90f18);
                  if (lVar4 == null) break;
                  if (((*(int64 *)(hero + 0x1f8) == 0) ||
                      (lVar4 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 56)) == null) ||
                     (lVar4 = FUN_180002f80(lVar4,uVar7,DAT_181d90f18)) == null) goto LAB_1813dafa4;
                  iVar1 = *(int *)(lVar4 + 56);
                  if ((*(int64 *)(hero + 0x220) == 0) ||
                     (lVar4 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null)
                  goto LAB_1813dafa4;
                  if (*(int *)(lVar4 + 24) == 0) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 32);
                  if ((lVar4 == null) || (lVar4 = FUN_180002f80(lVar4,uVar12,DAT_181d90f18)) == null)
                  goto LAB_1813dafa4;
                  if (iVar1 < *(int *)(lVar4 + 56)) break;
                  uVar7 = (uint64)((int)uVar7 + 1);
                }
                if (*(int64 *)(hero + 0x1f8) != 0) {
                  lVar4 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 56);
        joined_r0x0001813da9fa:
                  if (lVar4 != null) goto LAB_1813dac28;
                }
                break;
              }
              if (iVar1 == 2) {
                while( true ) {
                  if ((*(int64 *)(hero + 0x1f8) == 0) ||
                     (lVar4 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 80)) == null)
                  goto LAB_1813dafa4;
                  if (*(int *)(lVar4 + 24) <= (int)uVar7) goto LAB_1813dacaa;
                  lVar4 = FUN_180002f80(lVar4,uVar7,DAT_181d90f18);
                  if (lVar4 == null) break;
                  if (((*(int64 *)(hero + 0x1f8) == 0) ||
                      (lVar4 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 80)) == null) ||
                     (lVar4 = FUN_180002f80(lVar4,uVar7,DAT_181d90f18)) == null) goto LAB_1813dafa4;
                  iVar1 = *(int *)(lVar4 + 56);
                  if ((*(int64 *)(hero + 0x220) == 0) ||
                     (lVar4 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null)
                  goto LAB_1813dafa4;
                  if (*(int *)(lVar4 + 24) == 0) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 32);
                  if ((lVar4 == null) || (lVar4 = FUN_180002f80(lVar4,uVar12,DAT_181d90f18)) == null)
                  goto LAB_1813dafa4;
                  if (iVar1 < *(int *)(lVar4 + 56)) break;
                  uVar7 = (uint64)((int)uVar7 + 1);
                }
                if (*(int64 *)(hero + 0x1f8) != 0) {
                  lVar4 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 80);
                  goto joined_r0x0001813da9fa;
                }
                break;
              }
              if (iVar1 == 3) {
                while( true ) {
                  if ((*(int64 *)(hero + 0x1f8) == 0) ||
                     (lVar4 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 104)) == null)
                  goto LAB_1813dafa4;
                  if (*(int *)(lVar4 + 24) <= (int)uVar7) goto LAB_1813dacaa;
                  lVar4 = FUN_180002f80(lVar4,uVar7,DAT_181d90f18);
                  if (lVar4 == null) break;
                  if (((*(int64 *)(hero + 0x1f8) == 0) ||
                      (lVar4 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 104)) == null) ||
                     (lVar4 = FUN_180002f80(lVar4,uVar7,DAT_181d90f18)) == null) goto LAB_1813dafa4;
                  iVar1 = *(int *)(lVar4 + 56);
                  if ((*(int64 *)(hero + 0x220) == 0) ||
                     (lVar4 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null)
                  goto LAB_1813dafa4;
                  if (*(int *)(lVar4 + 24) == 0) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 32);
                  if ((lVar4 == null) || (lVar4 = FUN_180002f80(lVar4,uVar12,DAT_181d90f18)) == null)
                  goto LAB_1813dafa4;
                  if (iVar1 < *(int *)(lVar4 + 56)) break;
                  uVar7 = (uint64)((int)uVar7 + 1);
                }
                if (*(int64 *)(hero + 0x1f8) != 0) {
                  lVar4 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 104);
                  goto joined_r0x0001813da9fa;
                }
                break;
              }
              if (iVar1 == 4) {
                uVar7 = 0xffffffff;
                uVar9 = uVar10;
                while( true ) {
                  if ((*(int64 *)(hero + 0x1f8) == 0) ||
                     (lVar4 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 128)) == null)
                  goto LAB_1813dafa4;
                  if (*(int *)(lVar4 + 24) <= (int)uVar9) goto LAB_1813da66d;
                  lVar4 = FUN_180002f80(lVar4,uVar9,DAT_181d90f18);
                  if (lVar4 == null) break;
                  if (((*(int64 *)(hero + 0x1f8) == 0) ||
                      (lVar4 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 128)) == null) ||
                     (lVar4 = FUN_180002f80(lVar4,uVar9,DAT_181d90f18)) == null) goto LAB_1813dafa4;
                  iVar1 = *(int *)(lVar4 + 56);
                  if ((*(int64 *)(hero + 0x220) == 0) ||
                     (lVar4 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null)
                  goto LAB_1813dafa4;
                  if (*(int *)(lVar4 + 24) == 0) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 32);
                  if ((lVar4 == null) || (lVar4 = FUN_180002f80(lVar4,uVar12,DAT_181d90f18)) == null)
                  goto LAB_1813dafa4;
                  if (iVar1 < *(int *)(lVar4 + 56)) {
                    if ((int)uVar7 != -1) {
                      if (((*(int64 *)(hero + 0x1f8) == 0) ||
                          (lVar4 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 128)) == null) ||
                         (lVar4 = FUN_180002f80(lVar4,uVar9,DAT_181d90f18)) == null)
                      goto LAB_1813dafa4;
                      iVar1 = *(int *)(lVar4 + 56);
                      if (((*(int64 *)(hero + 0x1f8) == 0) ||
                          (lVar4 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 128)) == null) ||
                         (lVar4 = FUN_180002f80(lVar4,uVar7,DAT_181d90f18)) == null)
                      goto LAB_1813dafa4;
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
                uVar5 = FUN_180002f80(lVar4,uVar12,DAT_181d90f18);
                HeroData.EquipItem(hero,uVar5,0,0,0);
        LAB_1813da66d:
                if ((*(int64 *)(hero + 0x220) == 0) ||
                   (lVar4 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null) break;
                if (*(int *)(lVar4 + 24) == 0) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 32);
                if (((lVar4 == null) || (lVar4 = FUN_180002f80(lVar4,uVar12,DAT_181d90f18)) == null) ||
                   (*(int64 *)(lVar4 + 96) == 0)) break;
                if ((*(char *)(*(int64 *)(lVar4 + 96) + 48) == false) && (-1 < (int)uVar7)) {
                  if (*(int64 *)(hero + 0x1f8) != 0) {
                    lVar4 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 128);
                    goto joined_r0x0001813da9fa;
                  }
                  break;
                }
              }
            }
        LAB_1813dacaa:
            uVar12 = (uint64)(uVar8 + 1);
            uVar11 = uVar11 + 1;
          }
        }
        LAB_1813dafa4:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_1813dacd0:
        if ((*(int64 *)(hero + 0x220) == 0) ||
           (lVar6 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null) goto LAB_1813dafa4;
        if (*(uint32 *)(lVar6 + 24) < 7) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar6 = *(int64 *)(*(int64 *)(lVar6 + 16) + 80);
        if (lVar6 == null) goto LAB_1813dafa4;
        uVar8 = (uint32)uVar10;
        if (*(int *)(lVar6 + 24) <= (int)uVar8) {
          return;
        }
        if ((*(int64 *)(hero + 0x220) == 0) ||
           (lVar6 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null) goto LAB_1813dafa4;
        if (*(uint32 *)(lVar6 + 24) < 7) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar6 = *(int64 *)(*(int64 *)(lVar6 + 16) + 80);
        if (lVar6 == null) goto LAB_1813dafa4;
        if (*(uint32 *)(lVar6 + 24) <= uVar8) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar6 = *(int64 *)(lVar4 + *(int64 *)(lVar6 + 16));
        if ((lVar6 == null) || (lVar6 = *(int64 *)(lVar6 + 136)) == null) goto LAB_1813dafa4;
        if (*(char *)(lVar6 + 16) == false) {
          if ((*(int64 *)(hero + 0x220) == 0) ||
             (lVar6 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null)
          goto LAB_1813dafa4;
          if (*(uint32 *)(lVar6 + 24) < 7) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar6 = *(int64 *)(*(int64 *)(lVar6 + 16) + 80);
          if ((lVar6 == null) || (lVar6 = FUN_180002f80(lVar6,uVar10,DAT_181d90f18)) == null)
          goto LAB_1813dafa4;
          if (*(int *)(lVar6 + 24) == 0) {
            if (*(int64 *)(hero + 0x208) != 0) {
              iVar1 = *(int *)(*(int64 *)(hero + 0x208) + 56);
              if ((*(int64 *)(hero + 0x220) == 0) ||
                 (lVar6 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null)
              goto LAB_1813dafa4;
              if (*(uint32 *)(lVar6 + 24) < 7) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar6 = *(int64 *)(*(int64 *)(lVar6 + 16) + 80);
              if ((lVar6 == null) || (lVar6 = FUN_180002f80(lVar6,uVar10,DAT_181d90f18)) == null)
              goto LAB_1813dafa4;
              if (*(int *)(lVar6 + 56) <= iVar1) goto LAB_1813daf3a;
            }
            uVar5 = *(uint64 *)(hero + 0x208);
          }
          else {
            if (*(int *)(lVar6 + 24) != 1) goto LAB_1813daf3a;
            if (*(int64 *)(hero + 0x218) != 0) {
              iVar1 = *(int *)(*(int64 *)(hero + 0x218) + 56);
              if ((*(int64 *)(hero + 0x220) == 0) ||
                 (lVar6 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null)
              goto LAB_1813dafa4;
              if (*(uint32 *)(lVar6 + 24) < 7) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar6 = *(int64 *)(*(int64 *)(lVar6 + 16) + 80);
              if ((lVar6 == null) || (lVar6 = FUN_180002f80(lVar6,uVar10,DAT_181d90f18)) == null)
              goto LAB_1813dafa4;
              if (*(int *)(lVar6 + 56) <= iVar1) goto LAB_1813daf3a;
            }
            uVar5 = *(uint64 *)(hero + 0x218);
          }
          HeroData.UnequipItem(hero,uVar5,0,0,0);
          if ((*(int64 *)(hero + 0x220) == 0) ||
             (lVar6 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null)
          goto LAB_1813dafa4;
          if (*(uint32 *)(lVar6 + 24) < 7) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar6 = *(int64 *)(*(int64 *)(lVar6 + 16) + 80);
          if (lVar6 == null) goto LAB_1813dafa4;
          uVar5 = FUN_180002f80(lVar6,uVar10,DAT_181d90f18);
          HeroData.EquipItem(hero,uVar5,0,0,0);
        }
        LAB_1813daf3a:
        uVar10 = (uint64)(uVar8 + 1);
        lVar4 = lVar4 + 8;
        goto LAB_1813dacd0;
    }

    // Token : 0x60009E7
    // RVA   : 0x13E5B90   Offset: 0x13E4F90   Length: 0x1C0
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
            cVar2 = FUN_18182a3a0(this.speSkillIDList,*(uint32 *)(targetSkill + 16),
                                  DAT_181d8f398);
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
                cVar2 = FUN_18181e400(lVar5,uVar6,DAT_181da3e58);
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
                  cVar2 = FUN_18182a3a0(lVar5,uVar4,DAT_181d8f398);
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

    // Token : 0x60009E8
    // RVA   : 0x13DBA20   Offset: 0x13DAE20   Length: 0x997
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
          lVar4 = il2cpp_internal(DAT_181d93cd0);
          FUN_18132faf0(lVar4,DAT_181d8f098);
          fVar20 = -999999.0;
          lVar5 = il2cpp_internal(DAT_181d93cd0);
          FUN_18132faf0(lVar5,DAT_181d8f098);
          fVar21 = -999999.0;
          lVar6 = il2cpp_internal(DAT_181d93cd0);
          FUN_18132faf0(lVar6,DAT_181d8f098);
          fVar22 = -999999.0;
          lVar7 = il2cpp_internal(DAT_181d945d0);
          FUN_18132faf0(lVar7,DAT_181d92110);
          lVar8 = il2cpp_internal(DAT_181d945d0);
          FUN_18132faf0(lVar8,DAT_181d92110);
          lVar9 = il2cpp_internal(DAT_181d96ed0);
          FUN_18132faf0(lVar9,DAT_181da0cf8);
          uVar17 = 0;
          local_res10 = 0;
          uVar14 = uVar17;
          uVar15 = uVar17;
          while (*(int64 *)(hero + 0x2a0) != 0) {
            if (*(int *)(*(int64 *)(hero + 0x2a0) + 24) <= (int)uVar14) {
              local_res20 = 32;
              uVar14 = uVar17;
              goto LAB_1813dbcd0;
            }
            cVar2 = HeroData.AttackSkillSlotUnlocked(hero,uVar14,0);
            if (cVar2) {
              local_res10 = (int)uVar15 + 1;
              uVar15 = (uint64)local_res10;
            }
            uVar14 = (uint64)((int)uVar14 + 1);
          }
        }
        LAB_1813dc3b2:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_1813dbcd0:
        lVar10 = *(int64 *)(hero + 0x260);
        if (lVar10 != null) {
          uVar3 = (uint32)uVar14;
          if ((int)*(uint32 *)(lVar10 + 24) <= (int)uVar3) {
            if ((*(int64 *)(hero + 0x270) == 0) ||
               (fVar18 = (float)AIController.GetSkillScore
                                          (this,hero,*(int64 *)(hero + 0x270),0),
               fVar18 < fVar20)) {
              if (lVar4 == null) goto LAB_1813dc3b2;
              if (0 < *(int *)(lVar4 + 24)) {
                HeroData.UnequipSkill(hero,*(uint64 *)(hero + 0x270),0,0);
                lVar9 = *(int64 *)(hero + 0x260);
                uVar1 = *(uint32 *)(lVar4 + 24);
                uVar3 = GlobalData.RandomRange(0,uVar1,0,0);
                if (*(uint32 *)(lVar4 + 24) <= uVar3) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                if (lVar9 == null) goto LAB_1813dc3b2;
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
              if (lVar5 == null) goto LAB_1813dc3b2;
              if (0 < *(int *)(lVar5 + 24)) {
                HeroData.UnequipSkill(hero,*(uint64 *)(hero + 0x280),0,0);
                lVar4 = *(int64 *)(hero + 0x260);
                uVar1 = *(uint32 *)(lVar5 + 24);
                uVar3 = GlobalData.RandomRange(0,uVar1,0,0);
                if (*(uint32 *)(lVar5 + 24) <= uVar3) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                if (lVar4 == null) goto LAB_1813dc3b2;
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
              if (lVar6 == null) goto LAB_1813dc3b2;
              if (0 < *(int *)(lVar6 + 24)) {
                HeroData.UnequipSkill(hero,*(uint64 *)(hero + 0x290),0,0);
                lVar4 = *(int64 *)(hero + 0x260);
                uVar1 = *(uint32 *)(lVar6 + 24);
                uVar3 = GlobalData.RandomRange(0,uVar1,0,0);
                if (*(uint32 *)(lVar6 + 24) <= uVar3) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                if (lVar4 == null) goto LAB_1813dc3b2;
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
            if ((int)local_res10 < 1) goto LAB_1813dc230;
            lVar4 = 32;
            uVar15 = uVar17;
            uVar16 = uVar17;
            goto LAB_1813dc1e0;
          }
          if (*(uint32 *)(lVar10 + 24) <= uVar3) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          fVar18 = (float)AIController.GetSkillScore
                                    (this,hero,
                                     *(uint64 *)(local_res20 + *(int64 *)(lVar10 + 16)));
          lVar10 = *(int64 *)(hero + 0x260);
          if (lVar10 == null) goto LAB_1813dc3b2;
          if (*(uint32 *)(lVar10 + 24) <= uVar3) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar10 = *(int64 *)(local_res20 + *(int64 *)(lVar10 + 16));
          if ((lVar10 == null) || (lVar10 = KungfuSkillLvData.DataBase(lVar10,0)) == null)
          goto LAB_1813dc3b2;
          iVar12 = *(int *)(lVar10 + 48);
          if (iVar12 == 0) {
            lVar10 = lVar4;
            if (fVar20 < fVar18) {
              if (lVar4 == null) goto LAB_1813dc3b2;
              FUN_1812f9a10(lVar4,DAT_181d8f318);
              fVar20 = fVar18;
            }
            else {
              if (fVar18 != fVar20) goto LAB_1813dbf40;
        joined_r0x0001813dbf0c:
              if (lVar10 == null) goto LAB_1813dc3b2;
            }
        LAB_1813dbf32:
            FUN_18182a0b0(lVar10,uVar14,DAT_181d8f218);
            goto LAB_1813dbf40;
          }
          if (iVar12 == 1) {
            lVar10 = lVar5;
            fVar19 = fVar18;
            fVar23 = fVar22;
            if (fVar18 <= fVar21) {
              if (fVar18 == fVar21) goto joined_r0x0001813dbf0c;
              goto LAB_1813dbf40;
            }
        LAB_1813dbeb4:
            if (lVar10 != null) {
              FUN_1812f9a10(lVar10,DAT_181d8f318);
              fVar21 = fVar19;
              fVar22 = fVar23;
              goto LAB_1813dbf32;
            }
            goto LAB_1813dc3b2;
          }
          if (iVar12 == 2) {
            lVar10 = lVar6;
            fVar19 = fVar21;
            fVar23 = fVar18;
            if (fVar22 < fVar18) goto LAB_1813dbeb4;
            if (fVar18 != fVar22) goto LAB_1813dbf40;
            if (lVar6 != null) goto LAB_1813dbf32;
            goto LAB_1813dc3b2;
          }
          if (lVar9 == null) goto LAB_1813dc3b2;
          iVar12 = *(int *)(lVar9 + 24);
          uVar15 = uVar17;
          if (iVar12 != 0) goto LAB_1813dbd95;
        LAB_1813dbe22:
          if ((*(int64 *)(hero + 0x260) == 0) ||
             (uVar11 = FUN_180002f80(*(int64 *)(hero + 0x260),uVar14,DAT_181d92590), lVar7 == null))
          goto LAB_1813dc3b2;
          FUN_18181e0a0(lVar7,uVar11,DAT_181d92190);
          FUN_18181de10(lVar9,fVar18,DAT_181da0df8);
          uVar14 = (uint64)(uVar3 + 1);
          local_res20 = local_res20 + 8;
          goto LAB_1813dbcd0;
        }
        goto LAB_1813dc3b2;
        while( true ) {
          if (*(uint32 *)(lVar7 + 24) <= uVar3) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (lVar8 == null) goto LAB_1813dc3b2;
          FUN_18181e0a0(lVar8,*(uint64 *)(*(int64 *)(lVar7 + 16) + lVar4),DAT_181d92190);
          uVar15 = (uint64)(uVar3 + 1);
          uVar16 = uVar16 + 1;
          lVar4 = lVar4 + 8;
          if ((int64)(int)local_res10 <= (int64)uVar16) break;
        LAB_1813dc1e0:
          if (lVar7 == null) goto LAB_1813dc3b2;
          uVar3 = (uint32)uVar15;
          if ((int)*(uint32 *)(lVar7 + 24) <= (int)uVar3) break;
        }
        LAB_1813dc230:
        do {
          if (*(int64 *)(hero + 0x2a0) == 0) goto LAB_1813dc3b2;
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
                  uVar11 = FUN_180002f80(lVar8,uVar17,DAT_181d92590);
                  HeroData.EquipSkill(hero,uVar11,0,0);
                }
                uVar17 = (uint64)(uVar3 + 1);
                lVar4 = lVar4 + 8;
              }
            }
            goto LAB_1813dc3b2;
          }
          cVar2 = HeroData.AttackSkillSlotUnlocked(hero,uVar14,0);
          if (cVar2) {
            if (*(int64 *)(hero + 0x2a0) == 0) goto LAB_1813dc3b2;
            lVar4 = FUN_180002f80(*(int64 *)(hero + 0x2a0),uVar14);
            if (lVar4 != null) {
              if ((*(int64 *)(hero + 0x2a0) == 0) ||
                 (uVar11 = FUN_180002f80(*(int64 *)(hero + 0x2a0),uVar14,DAT_181d92590), lVar8 == null)
                 ) goto LAB_1813dc3b2;
              cVar2 = FUN_18181e400(lVar8,uVar11);
              if (!cVar2) {
                if (*(int64 *)(hero + 0x2a0) == 0) goto LAB_1813dc3b2;
                uVar11 = FUN_180002f80(*(int64 *)(hero + 0x2a0),uVar14);
                HeroData.UnequipSkill(hero,uVar11);
              }
            }
          }
          uVar14 = (uint64)((int)uVar14 + 1);
        } while( true );
        LAB_1813dbd95:
        while (iVar13 = (int)uVar15, iVar13 < iVar12) {
          fVar19 = (float)FUN_1800d6790(lVar9,uVar15,DAT_181da1078);
          if (fVar19 <= fVar18) {
            if ((*(int64 *)(hero + 0x260) == 0) ||
               (uVar11 = FUN_180002f80(*(int64 *)(hero + 0x260),uVar14,DAT_181d92590), lVar7 == null))
            goto LAB_1813dc3b2;
            FUN_181822520(lVar7,uVar15,uVar11,DAT_181d92390);
            FUN_181822250(lVar9,uVar15,fVar18);
            uVar14 = (uint64)(uVar3 + 1);
            local_res20 = local_res20 + 8;
            goto LAB_1813dbcd0;
          }
          iVar12 = *(int *)(lVar9 + 24);
          if (iVar13 == iVar12 + -1) goto LAB_1813dbe22;
          uVar15 = (uint64)(iVar13 + 1);
        }
        LAB_1813dbf40:
        uVar14 = (uint64)(uVar3 + 1);
        local_res20 = local_res20 + 8;
        goto LAB_1813dbcd0;
    }

    // Token : 0x60009E9
    // RVA   : 0x13E6940   Offset: 0x13E5D40   Length: 0x78A
    public void ManageAIOneDay(HeroData hero)
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
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
          cVar3 = HeroData.HaveForce(hero,0);
          if (!cVar3) {
        LAB_1813e6a12:
            if (*(int64 *)(hero + 64) == 0) throw; // [null/range check failed]
            *(uint32 *)(*(int64 *)(hero + 64) + 40) = 0;
          }
          else {
            iVar2 = *(int *)(hero + 192);
            lVar5 = HeroData.GetForce(hero,0,0);
            if (lVar5 == null) throw; // [null/range check failed]
            if (iVar2 == *(int *)(lVar5 + 56)) goto LAB_1813e6a12;
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
        LAB_1813e6a9c:
                  if (*(int64 *)(hero + 64) == 0) throw; // [null/range check failed]
                  *(uint32 *)(*(int64 *)(hero + 64) + 32) = 0;
                }
              }
              else if ((((iVar2 == 4) &&
                        (HeroData.AutoCureSelfInjury(hero,0), *(float *)(hero + 0x1a8) <= 0.0)) &&
                       (*(float *)(hero + 0x1a4) <= 0.0)) && (*(float *)(hero + 0x1a0) <= 0.0))
              goto LAB_1813e6a9c;
              cVar3 = HeroData.HaveArea(hero,0);
              if (!cVar3) {
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
                    goto LAB_1813e6f19;
                  }
                  uVar6 = new HeroAIData(1,"-1",99,0);
                  goto LAB_1813e6ec8;
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
                          goto LAB_1813e6f19;
                        }
                      }
                      if (*(int64 *)(hero + 64) == 0) throw; // [null/range check failed]
                      if ((*(int *)(*(int64 *)(hero + 64) + 32) < 1) &&
                         (cVar3 = AIController.FinishAIStuff(this,hero,0), !cVar3)) {
                        cVar3 = HeroData.HaveForce(hero,0);
                        if (!cVar3) {
        LAB_1813e6d46:
                          cVar3 = AIController.CanLeaveArea(this,0);
                          if (cVar3) {
                            dVar9 = (double)GlobalData.RandomRangeDouble(0,0);
                            if (dVar9 <= 0.05000000074505806) {
                              cVar3 = HeroData.HaveForce(hero,0);
                              if (cVar3) {
                                iVar2 = *(int *)(hero + 192);
                                lVar5 = HeroData.GetForce(hero,0,0);
                                if (lVar5 == null) throw; // [null/range check failed]
                                if (iVar2 != *(int *)(lVar5 + 56)) {
                                  dVar9 = (double)GlobalData.RandomRangeDouble(0,0);
                                  if (dVar9 < 0.20000000298023224) goto LAB_1813e6d19;
                                }
                              }
                              uVar4 = AIController.GetRandomMoveTargetArea(this,hero,0);
                              AIController.StartMoveToAnotherArea(this,hero,uVar4,0);
                              goto LAB_1813e6f73;
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
                          if (iVar2 == *(int *)(lVar5 + 56)) goto LAB_1813e6d46;
                          dVar9 = (double)GlobalData.RandomRangeDouble(0,0);
                          if (*(char *)(hero + 180) != false) {
                            fVar10 = 0.005;
                          }
                          if (*(int64 *)(hero + 64) == 0) throw; // [null/range check failed]
                          if ((double)(((float)*(int *)(hero + 184) * 0.001 + 0.02 + fVar10) *
                                      *(float *)(*(int64 *)(hero + 64) + 40)) < dVar9)
                          goto LAB_1813e6d46;
        LAB_1813e6d19:
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
        LAB_1813e6f19:
                      AIController.SetAIStuff(this,hero,uVar6,0,0);
                    }
                  }
                  else {
                    uVar6 = new HeroAIData(4,99);
        LAB_1813e6ec8:
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
        LAB_1813e6f73:
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

    // Token : 0x60009EA
    // RVA   : 0x13DD960   Offset: 0x13DCD60   Length: 0x1FF
    public void CheckInteractTarget(HeroData hero)
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        bool cVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        lVar3 = *(int64 *)(*(int64 *)(DAT_181da9de0 + 184) + 8);
        if (((hero != null) && (*(int64 *)(hero + 64) != 0)) && (lVar3 != null)) {
          cVar1 = FUN_18182a3a0(lVar3,*(uint32 *)(*(int64 *)(hero + 64) + 16),DAT_181d7ae88)
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
        LAB_1813ddb40:
                HeroData.ResetAI(hero,0);
                return;
              }
              if ((*(int64 *)(lVar3 + 64) != 0) && (*(int64 *)(hero + 64) != 0)) {
                if (*(int *)(*(int64 *)(lVar3 + 64) + 16) !=
                    *(int *)(*(int64 *)(hero + 64) + 16)) goto LAB_1813ddb40;
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
                    goto LAB_1813ddb40;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60009EB
    // RVA   : 0x13E55F0   Offset: 0x13E49F0   Length: 0x59F
    public int GetRandomMoveTargetArea(HeroData hero)
    {
        var pStatics_2cc8 = *(int64*)(DAT_181d72cc8 + 184);
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
        bool cVar1;
        uint uVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        long lVar6;
        int iVar7;
        if (*(int *)(pStatics_3d40 + 8) == 1) {
          lVar4 = il2cpp_internal(DAT_181d93cd0);
          FUN_18132faf0(lVar4,DAT_181d8f098);
          iVar7 = 0;
          while( true ) {
            if ((((*pStatics_2cc8 == 0) || (hero == null)) ||
                (lVar5 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
               ((lVar5 = WorldData.GetArea(lVar5,*(uint32 *)(hero + 192),0), lVar5 == null ||
                (*(int64 *)(lVar5 + 160) == 0)))) throw; // [null/range check failed]
            if (*(int *)(*(int64 *)(lVar5 + 160) + 24) <= iVar7) break;
            lVar5 = *(int64 *)(pStatics_3d40 + 24);
            if ((((*pStatics_2cc8 == 0) ||
                 (lVar6 = *(int64 *)(*pStatics_2cc8 + 32)) == null) ||
                (lVar6 = WorldData.GetArea(lVar6,*(uint32 *)(hero + 192),0)) == null) ||
               ((*(int64 *)(lVar6 + 160) == 0 ||
                (uVar3 = FUN_1800d6760(*(int64 *)(lVar6 + 160),iVar7,DAT_181d8fa18), lVar5 == null))))
            throw; // [null/range check failed]
            cVar1 = FUN_18182a3a0(lVar5,uVar3);
            if (cVar1) {
              lVar5 = FUN_18046c0a0(0);
              if ((((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                  (lVar5 = WorldData.GetArea(*(int64 *)(lVar5 + 32),*(uint32 *)(hero + 192),
                                              0), lVar5 == null)) ||
                 ((*(int64 *)(lVar5 + 160) == 0 ||
                  (uVar3 = FUN_1800d6760(*(int64 *)(lVar5 + 160),iVar7,DAT_181d8fa18), lVar4 == null))))
              throw; // [null/range check failed]
              FUN_18182a0b0(lVar4,uVar3);
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
            lVar4 = *(int64 *)(pStatics_3d40 + 24);
            if (lVar4 != null) {
              uVar2 = GlobalData.RandomRange(0,*(uint32 *)(lVar4 + 24),0,0);
              goto LAB_1813e5b1b;
            }
          }
        }
        else {
          if ((((*pStatics_2cc8 != 0) && (hero != null)) &&
              (lVar4 = *(int64 *)(*pStatics_2cc8 + 32)) != null) &&
             (lVar4 = WorldData.GetArea(lVar4,*(uint32 *)(hero + 192),0)) != null) {
            lVar4 = *(int64 *)(lVar4 + 160);
            if (((*pStatics_2cc8 != 0) &&
                (lVar5 = *(int64 *)(*pStatics_2cc8 + 32)) != null) &&
               ((lVar5 = WorldData.GetArea(lVar5,*(uint32 *)(hero + 192),0), lVar5 != null &&
                (*(int64 *)(lVar5 + 160) != 0)))) {
              uVar3 = *(uint32 *)(*(int64 *)(lVar5 + 160) + 24);
              uVar2 = GlobalData.RandomRange(0,uVar3,0,0);
              if (lVar4 != null) {
        LAB_1813e5b1b:
                if (*(uint32 *)(lVar4 + 24) <= uVar2) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                return lVar4[uVar2];
              }
            }
          }
        }
    }

    // Token : 0x60009EC
    // RVA   : 0x13DD4F0   Offset: 0x13DC8F0   Length: 0x157
    public bool CanLeaveArea()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
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

    // Token : 0x60009ED
    // RVA   : 0x13EAC80   Offset: 0x13EA080   Length: 0x908
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
          lVar5 = il2cpp_internal(DAT_181d940d0);
          FUN_18132faf0(lVar5,DAT_181d90998);
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
              goto LAB_1813eaed0;
            }
            if (*(uint32 *)(lVar6 + 24) <= uVar9) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(int64 *)(*(int64 *)(lVar6 + 16) + lVar8) == 0) {
        LAB_1813eaeaf:
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
                goto LAB_1813eaeaf;
              }
              if (((*(int64 *)(hero + 0x1f8) == 0) ||
                  (lVar6 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 32)) == null) ||
                 (uVar7 = FUN_180002f80(lVar6,uVar9,DAT_181d90f18), lVar5 == null)) break;
              FUN_18181e0a0(lVar5,uVar7);
              uVar9 = uVar9 + 1;
              lVar8 = lVar8 + 8;
            }
          }
        }
        LAB_1813eb583:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_1813eaed0:
        if ((*(int64 *)(hero + 0x1f8) == 0) ||
           (lVar6 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 56)) == null) goto LAB_1813eb583;
        if ((int)*(uint32 *)(lVar6 + 24) <= (int)uVar9) {
          lVar8 = 32;
          uVar9 = uVar10;
          goto LAB_1813eafe0;
        }
        if (*(uint32 *)(lVar6 + 24) <= uVar9) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (*(int64 *)(*(int64 *)(lVar6 + 16) + lVar8) == 0) {
        LAB_1813eafbf:
          uVar9 = uVar9 + 1;
          lVar8 = lVar8 + 8;
        }
        else {
          if ((((*(int64 *)(hero + 0x1f8) == 0) ||
               (lVar6 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 56)) == null) ||
              (lVar6 = FUN_180002f80(lVar6,uVar9)) == null) ||
             ((*(int64 *)(lVar6 + 96) == 0 ||
              (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 96) + 64)) == null)))
          goto LAB_1813eb583;
          if (0.0 < *(float *)(lVar6 + 16)) {
            uVar12 = uVar12 + 1;
            goto LAB_1813eafbf;
          }
          if (((*(int64 *)(hero + 0x1f8) == 0) ||
              (lVar6 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 56)) == null) ||
             (uVar7 = FUN_180002f80(lVar6,uVar9,DAT_181d90f18), lVar5 == null)) goto LAB_1813eb583;
          FUN_18181e0a0(lVar5,uVar7);
          uVar9 = uVar9 + 1;
          lVar8 = lVar8 + 8;
        }
        goto LAB_1813eaed0;
        LAB_1813eafe0:
        if ((*(int64 *)(hero + 0x1f8) == 0) ||
           (lVar6 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 80)) == null) goto LAB_1813eb583;
        if ((int)*(uint32 *)(lVar6 + 24) <= (int)uVar9) {
          lVar8 = 32;
          uVar9 = uVar10;
          goto LAB_1813eb0f0;
        }
        if (*(uint32 *)(lVar6 + 24) <= uVar9) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (*(int64 *)(*(int64 *)(lVar6 + 16) + lVar8) == 0) {
        LAB_1813eb0cf:
          uVar9 = uVar9 + 1;
          lVar8 = lVar8 + 8;
        }
        else {
          if ((((*(int64 *)(hero + 0x1f8) == 0) ||
               (lVar6 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 80)) == null) ||
              (lVar6 = FUN_180002f80(lVar6,uVar9)) == null) ||
             ((*(int64 *)(lVar6 + 96) == 0 ||
              (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 96) + 64)) == null)))
          goto LAB_1813eb583;
          if (0.0 < *(float *)(lVar6 + 16)) {
            uVar12 = uVar12 + 1;
            goto LAB_1813eb0cf;
          }
          if (((*(int64 *)(hero + 0x1f8) == 0) ||
              (lVar6 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 80)) == null) ||
             (uVar7 = FUN_180002f80(lVar6,uVar9,DAT_181d90f18), lVar5 == null)) goto LAB_1813eb583;
          FUN_18181e0a0(lVar5,uVar7);
          uVar9 = uVar9 + 1;
          lVar8 = lVar8 + 8;
        }
        goto LAB_1813eafe0;
        LAB_1813eb0f0:
        if ((*(int64 *)(hero + 0x1f8) == 0) ||
           (lVar6 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 104)) == null) goto LAB_1813eb583;
        if ((int)*(uint32 *)(lVar6 + 24) <= (int)uVar9) goto LAB_1813eb200;
        if (*(uint32 *)(lVar6 + 24) <= uVar9) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (*(int64 *)(*(int64 *)(lVar6 + 16) + lVar8) == 0) {
        LAB_1813eb1df:
          uVar9 = uVar9 + 1;
          lVar8 = lVar8 + 8;
        }
        else {
          if ((((*(int64 *)(hero + 0x1f8) == 0) ||
               (lVar6 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 104)) == null) ||
              (lVar6 = FUN_180002f80(lVar6,uVar9)) == null) ||
             ((*(int64 *)(lVar6 + 96) == 0 ||
              (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 96) + 64)) == null)))
          goto LAB_1813eb583;
          if (0.0 < *(float *)(lVar6 + 16)) {
            uVar12 = uVar12 + 1;
            goto LAB_1813eb1df;
          }
          if (((*(int64 *)(hero + 0x1f8) == 0) ||
              (lVar6 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 104)) == null) ||
             (uVar7 = FUN_180002f80(lVar6,uVar9,DAT_181d90f18), lVar5 == null)) goto LAB_1813eb583;
          FUN_18181e0a0(lVar5,uVar7);
          uVar9 = uVar9 + 1;
          lVar8 = lVar8 + 8;
        }
        goto LAB_1813eb0f0;
        LAB_1813eb200:
        if ((*(int64 *)(hero + 0x1f8) == 0) ||
           (lVar8 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 128)) == null) goto LAB_1813eb583;
        if ((int)*(uint32 *)(lVar8 + 24) <= (int)uVar10) {
          if ((int)uVar12 <= *(int *)(hero + 184)) {
            if (lVar5 == null) goto LAB_1813eb583;
            iVar3 = *(int *)(lVar5 + 24);
            if (0 < iVar3) {
              uVar9 = GlobalData.RandomRange(0,iVar3,0,0);
              if (*(uint32 *)(lVar5 + 24) <= uVar9) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar5 = lVar5[uVar9];
              goto LAB_1813eb36c;
            }
          }
          lVar5 = *(int64 *)(*(int64 *)(DAT_181da9de0 + 184) + 48);
          if (lVar5 == null) goto LAB_1813eb583;
          uVar4 = *(uint32 *)(lVar5 + 24);
          uVar9 = GlobalData.RandomRange(0,uVar4,0,0);
          if (*(uint32 *)(lVar5 + 24) <= uVar9) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (*(int64 *)(hero + 0x220) == 0) goto LAB_1813eb583;
          lVar8 = *(int64 *)(*(int64 *)(hero + 0x220) + 48);
          uVar9 = lVar5[uVar9];
          lVar5 = (int64)(int)uVar9;
          if (lVar8 == null) goto LAB_1813eb583;
          if (*(uint32 *)(lVar8 + 24) <= uVar9) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar8 = *(int64 *)(*(int64 *)(lVar8 + 16) + 32 + lVar5 * 8);
          if (lVar8 == null) goto LAB_1813eb583;
          if (*(int *)(lVar8 + 24) < 1) {
            return;
          }
          lVar8 = *(int64 *)(hero + 0x220);
          if ((lVar8 == null) || (lVar11 = *(int64 *)(lVar8 + 48)) == null) goto LAB_1813eb583;
          if (*(uint32 *)(lVar11 + 24) <= uVar9) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
            lVar8 = *(int64 *)(hero + 0x220);
          }
          lVar11 = *(int64 *)(*(int64 *)(lVar11 + 16) + 32 + lVar5 * 8);
          if ((lVar8 == null) || (lVar8 = *(int64 *)(lVar8 + 48)) == null) goto LAB_1813eb583;
          if (*(uint32 *)(lVar8 + 24) <= uVar9) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar5 = *(int64 *)(*(int64 *)(lVar8 + 16) + 32 + lVar5 * 8);
          if (lVar5 == null) goto LAB_1813eb583;
          uVar4 = *(uint32 *)(lVar5 + 24);
          uVar9 = GlobalData.RandomRange(0,uVar4,0,0);
          if (lVar11 == null) goto LAB_1813eb583;
          if (*(uint32 *)(lVar11 + 24) <= uVar9) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar5 = lVar11[uVar9];
          if (lVar5 == null) goto LAB_1813eb583;
          if (*(int *)(lVar5 + 20) == 0) {
            lVar8 = *(int64 *)(lVar5 + 96);
            if ((lVar8 == null) || (*(int64 *)(lVar8 + 64) == 0)) goto LAB_1813eb583;
            pfVar1 = (float *)(*(int64 *)(lVar8 + 64) + 16);
            if (*pfVar1 <= 0.0 && *pfVar1 != 0.0) {
        LAB_1813eb36c:
              HeroData.ManagePoisonEquipment(hero,lVar5,0);
              return;
            }
            cVar2 = *(char *)(lVar8 + 48);
          }
          else {
            if (*(int *)(lVar5 + 20) == 6)
            {
              if (*(int64 *)(lVar5 + 136) == 0) goto LAB_1813eb583;
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
        LAB_1813eb2f8:
          uVar10 = uVar10 + 1;
          lVar11 = lVar11 + 8;
        }
        else {
          if ((((*(int64 *)(hero + 0x1f8) == 0) ||
               (lVar8 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 128)) == null) ||
              (lVar8 = FUN_180002f80(lVar8,uVar10)) == null) ||
             ((*(int64 *)(lVar8 + 96) == 0 ||
              (lVar8 = *(int64 *)(*(int64 *)(lVar8 + 96) + 64)) == null)))
          goto LAB_1813eb583;
          if (0.0 < *(float *)(lVar8 + 16)) {
            uVar12 = uVar12 + 1;
            goto LAB_1813eb2f8;
          }
          if (((*(int64 *)(hero + 0x1f8) == 0) ||
              (lVar8 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 128)) == null) ||
             (uVar7 = FUN_180002f80(lVar8,uVar10,DAT_181d90f18), lVar5 == null)) goto LAB_1813eb583;
          FUN_18181e0a0(lVar5,uVar7);
          uVar10 = uVar10 + 1;
          lVar11 = lVar11 + 8;
        }
        goto LAB_1813eb200;
    }

    // Token : 0x60009EE
    // RVA   : 0x13DD870   Offset: 0x13DCC70   Length: 0xE3
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

    // Token : 0x60009EF
    // RVA   : 0x13E5360   Offset: 0x13E4760   Length: 0x143
    public bool ForceHaveResourceRateLessThan(HeroData hero, float rate)
    {
        uint64 AIController.ForceHaveResourceRateLessThan
                          (uint64 this,int64 hero,float rate)
        {
        float fVar1;
        uint64 uVar2;
        int64 lVar3;
        uint32 uVar4;
        int64 lVar5;
        if (hero != null) {
          uVar2 = HeroData.HaveForce(hero,0);
          if ((char)!uVar2) {
        LAB_1813e549a:
            return uVar2 & 0xffffffffffffff00;
          }
          uVar4 = 0;
          lVar5 = 32;
          while ((lVar3 = HeroData.GetForce(hero,0,0), lVar3 != null &&
                 (uVar2 = *(uint64 *)(lVar3 + 136)) != null)) {
            if (*(int *)(uVar2 + 24) <= (int)uVar4) goto LAB_1813e549a;
            lVar3 = HeroData.GetForce(hero,0,0);
            if ((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 136)) == null) break;
            if (*(uint32 *)(lVar3 + 24) <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            fVar1 = *(float *)(lVar5 + *(int64 *)(lVar3 + 16));
            lVar3 = HeroData.GetForce(hero,0,0);
            if ((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 144)) == null) break;
            if (*(uint32 *)(lVar3 + 24) <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (fVar1 / *(float *)(*(int64 *)(lVar3 + 16) + lVar5) <= rate) {
              return CONCAT71((int7)((uint64)*(int64 *)(lVar3 + 16) >> 8),1);
            }
            uVar4 = uVar4 + 1;
            lVar5 = lVar5 + 4;
          }
        }
    }

    // Token : 0x60009F0
    // RVA   : 0x13E70D0   Offset: 0x13E64D0   Length: 0x14E8
    public void ManageAIStuff(HeroData hero)
    {
        var plVar13 = *(int64*)(lVar13 + 184);
        var pStatics = *(int64*)(DAT_181dc0c50 + 184);
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
        lVar9 = il2cpp_internal(DAT_181d90960);
        local_e8 = lVar9;
        FUN_18132faf0(lVar9,DAT_181d7ad88);
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
                  FUN_18182a0b0(lVar9,2,DAT_181d7ae08);
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
                  FUN_18182a0b0(lVar9,2,DAT_181d7ae08);
                  uVar18 = uVar18 + 1;
                } while ((int)uVar18 < iVar4);
              }
            }
          }
          else {
            uVar18 = uVar19;
            do {
              if (lVar9 == null) throw; // [null/range check failed]
              FUN_18182a0b0(lVar9,2,DAT_181d7ae08);
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
                FUN_18182a0b0(lVar9,3,DAT_181d7ae08);
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
                FUN_18182a0b0(lVar9,4,DAT_181d7ae08);
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
                if (iVar5 < 1) goto LAB_1813e78b8;
                iVar4 = 0;
                goto LAB_1813e7895;
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
          FUN_18182a0b0(lVar9,5,DAT_181d7ae08);
          iVar4 = iVar4 + 1;
          if (iVar5 <= iVar4) break;
        LAB_1813e7895:
          if (lVar9 == null) throw; // [null/range check failed]
        }
        LAB_1813e78b8:
        iVar5 = HeroData.GetAISettingPriorityLv(hero,1);
        iVar5 = Mathf.RoundToInt((2.0 - fVar26) * (float)iVar5,0);
        if (0 < iVar5) {
          iVar4 = 0;
          do {
            if (lVar9 == null) throw; // [null/range check failed]
            FUN_18182a0b0(lVar9,18,DAT_181d7ae08);
            iVar4 = iVar4 + 1;
          } while (iVar4 < iVar5);
        }
        iVar5 = HeroData.GetAISettingPriorityLv(hero,2);
        if (0 < iVar5) {
          iVar4 = 0;
          do {
            if (lVar9 == null) throw; // [null/range check failed]
            FUN_18182a0b0(lVar9,6,DAT_181d7ae08);
            iVar4 = iVar4 + 1;
          } while (iVar4 < iVar5);
        }
        iVar5 = HeroData.GetAISettingPriorityLv(hero,6);
        if (*(int64 *)(hero + 0x220) == 0) throw; // [null/range check failed]
        iVar4 = *(int *)(*(int64 *)(hero + 0x220) + 24);
        fVar26 = (float)FUN_1801f8ab0();
        iVar5 = ((fVar26 * 200.0 <= (float)iVar4 ^ 1) + 1) * iVar5;
        if (0 < iVar5) {
          iVar4 = 0;
          do {
            if (lVar9 == null) throw; // [null/range check failed]
            FUN_18182a0b0(lVar9,8,DAT_181d7ae08);
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
          fVar26 = (float)FUN_1801f8ab0();
          iVar4 = Mathf.Max((int)((float)*(int *)(lVar11 + 24) / (fVar26 * 400.0)) * 2,1);
          if (0 < iVar4 * iVar5) {
            iVar20 = 0;
            do {
              if (lVar9 == null) throw; // [null/range check failed]
              FUN_18182a0b0(lVar9,9,DAT_181d7ae08);
              iVar20 = iVar20 + 1;
            } while (iVar20 < iVar4 * iVar5);
          }
          iVar5 = HeroData.GetAISettingPriorityLv(hero,6);
          if (0 < iVar5) {
            iVar4 = 0;
            do {
              if (lVar9 == null) throw; // [null/range check failed]
              FUN_18182a0b0(lVar9,10,DAT_181d7ae08);
              iVar4 = iVar4 + 1;
            } while (iVar4 < iVar5);
          }
          iVar5 = HeroData.GetAISettingPriorityLv(hero,7);
          if (0 < iVar5) {
            iVar4 = 0;
            do {
              if (lVar9 == null) throw; // [null/range check failed]
              FUN_18182a0b0(lVar9,11,DAT_181d7ae08);
              iVar4 = iVar4 + 1;
            } while (iVar4 < iVar5);
          }
          iVar5 = HeroData.GetAISettingPriorityLv(hero,7);
          if (0 < iVar5) {
            iVar4 = 0;
            do {
              if (lVar9 == null) throw; // [null/range check failed]
              FUN_18182a0b0(lVar9,12,DAT_181d7ae08);
              iVar4 = iVar4 + 1;
            } while (iVar4 < iVar5);
          }
          iVar5 = HeroData.GetAISettingPriorityLv(hero,8);
          if (0 < iVar5) {
            iVar4 = 0;
            do {
              if (lVar9 == null) throw; // [null/range check failed]
              FUN_18182a0b0(lVar9,14,DAT_181d7ae08);
              iVar4 = iVar4 + 1;
            } while (iVar4 < iVar5);
          }
          iVar5 = HeroData.GetAISettingPriorityLv(hero,8);
          if (0 < iVar5) {
            iVar4 = 0;
            do {
              if (lVar9 == null) throw; // [null/range check failed]
              FUN_18182a0b0(lVar9,15,DAT_181d7ae08);
              iVar4 = iVar4 + 1;
            } while (iVar4 < iVar5);
          }
          if (*(int64 *)(hero + 0x220) == 0) throw; // [null/range check failed]
          iVar5 = *(int *)(*(int64 *)(hero + 0x220) + 24);
          fVar26 = (float)FUN_1801f8ab0();
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
              FUN_18182a0b0(lVar9,17,DAT_181d7ae08);
              iVar4 = iVar4 + 1;
            } while (iVar4 < iVar5);
          }
          cVar3 = HeroData.HaveForce(hero,0);
          if (cVar3) {
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
                FUN_18182a0b0(lVar9,7,DAT_181d7ae08);
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
                  FUN_18182a0b0(lVar9,19,DAT_181d7ae08);
                  iVar4 = iVar4 + 1;
                } while (iVar4 < iVar5);
              }
              iVar5 = HeroData.GetAISettingPriorityLv(hero,5);
              if (0 < iVar5) {
                iVar4 = 0;
                do {
                  if (lVar9 == null) throw; // [null/range check failed]
                  FUN_18182a0b0(lVar9,20,DAT_181d7ae08);
                  iVar4 = iVar4 + 1;
                } while (iVar4 < iVar5);
              }
            }
          }
          if (lVar10 == null) {
            if (*(int64 *)(hero + 0x220) == 0) throw; // [null/range check failed]
            iVar5 = *(int *)(*(int64 *)(hero + 0x220) + 24);
            fVar26 = (float)FUN_1801f8ab0();
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
              FUN_18182a3a0(*(int64 *)(lVar10 + 248),8,DAT_181d8f398);
            }
            iVar5 = Mathf.RoundToInt();
            if (0 < iVar5) {
              iVar4 = 0;
              do {
                if (lVar9 == null) throw; // [null/range check failed]
                FUN_18182a0b0(lVar9,21,DAT_181d7ae08);
                iVar4 = iVar4 + 1;
              } while (iVar4 < iVar5);
            }
          }
          if (lVar10 == null) {
            if (*(int64 *)(hero + 0x220) == 0) throw; // [null/range check failed]
            iVar5 = *(int *)(*(int64 *)(hero + 0x220) + 24);
            fVar26 = (float)FUN_1801f8ab0();
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
              FUN_18182a3a0(*(int64 *)(lVar10 + 248),7,DAT_181d8f398);
            }
            iVar5 = Mathf.RoundToInt();
            if (0 < iVar5) {
              iVar4 = 0;
              do {
                if (lVar9 == null) throw; // [null/range check failed]
                FUN_18182a0b0(lVar9,22,DAT_181d7ae08);
                iVar4 = iVar4 + 1;
              } while (iVar4 < iVar5);
            }
          }
          if (lVar10 == null) {
            if (*(int64 *)(hero + 0x220) == 0) throw; // [null/range check failed]
            iVar5 = *(int *)(*(int64 *)(hero + 0x220) + 24);
            fVar26 = (float)FUN_1801f8ab0();
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
            if (fVar26 / *(float *)(*(int64 *)(lVar12 + 16) + 40) < 0.5) goto LAB_1813e84b9;
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
              FUN_18182a3a0(*(int64 *)(lVar10 + 248),6,DAT_181d8f398);
            }
            iVar5 = Mathf.RoundToInt();
            if (0 < iVar5) {
              iVar4 = 0;
              do {
                if (lVar9 == null) throw; // [null/range check failed]
                FUN_18182a0b0(lVar9,23,DAT_181d7ae08);
                iVar4 = iVar4 + 1;
              } while (iVar4 < iVar5);
            }
          }
        LAB_1813e84b9:
          local_100 = 0;
          lVar11 = il2cpp_internal(DAT_181d97750);
          local_f8 = lVar11;
          FUN_18132faf0(lVar11,DAT_181da3bd8);
          do {
            lVar12 = il2cpp_internal(DAT_181dc0cd8);
            local_f0 = lVar12;
            c__DisplayClass9_0.ctor(lVar12,0);
            if (lVar9 == null) throw; // [null/range check failed]
            uVar6 = *(uint32 *)(lVar9 + 24);
            uVar6 = GlobalData.RandomRange(0,uVar6,0);
            uVar6 = FUN_1800d6760(lVar9,uVar6);
            if ((lVar12 == null) || (*(uint32 *)(lVar12 + 16) = uVar6, lVar11 == null))
            throw; // [null/range check failed]
            FUN_1812f9a10(lVar11);
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
        LAB_1813e8779:
                iVar5 = 0;
                while( true ) {
                  lVar12 = *(int64 *)(hero + 0x260);
                  if (lVar12 == null) throw; // [null/range check failed]
                  if (*(int *)(lVar12 + 24) <= iVar5) break;
                  lVar12 = FUN_180002f80(lVar12,iVar5);
                  if (lVar12 == null) throw; // [null/range check failed]
                  if (*(int *)(lVar12 + 20) < 10) {
                    lVar12 = *(int64 *)(hero + 0x108);
                    if (((*(int64 *)(hero + 0x260) == 0) ||
                        (lVar13 = FUN_180002f80(*(int64 *)(hero + 0x260),iVar5,DAT_181d92590),
                        lVar13 == null)) || (uVar6 = KungfuSkillLvData.Type(lVar13,0), lVar12 == null))
                    throw; // [null/range check failed]
                    cVar3 = FUN_18182a3a0(lVar12,uVar6,DAT_181d8f398);
                    if ((!cVar3) && (lVar12 = HeroData.GetForce(hero,0,0)) != null) {
                      lVar12 = HeroData.GetForce(hero,0,0);
                      if (lVar12 == null) throw; // [null/range check failed]
                      lVar12 = *(int64 *)(lVar12 + 240);
                      if (((*(int64 *)(hero + 0x260) == 0) ||
                          (lVar13 = FUN_180002f80(*(int64 *)(hero + 0x260),iVar5,DAT_181d92590),
                          lVar13 == null)) || (uVar6 = KungfuSkillLvData.Type(lVar13,0), lVar12 == null))
                      throw; // [null/range check failed]
                      FUN_18182a3a0(lVar12,uVar6,DAT_181d8f398);
                    }
                    if (((((*(int64 *)(hero + 0x260) == 0) ||
                          (lVar12 = FUN_180002f80(*(int64 *)(hero + 0x260),iVar5,DAT_181d92590),
                          lVar12 == null)) || (lVar12 = KungfuSkillLvData.DataBase(lVar12,0)) == null)
                        || ((*(int *)(lVar12 + 52) != *(int *)(hero + 184) &&
                            (((*(int64 *)(hero + 0x260) == 0 ||
                              (lVar12 = FUN_180002f80(*(int64 *)(hero + 0x260),iVar5,DAT_181d92590),
                              lVar12 == null)) ||
                             (lVar12 = KungfuSkillLvData.DataBase(lVar12,0)) == null))))) ||
                       (((cVar3 = HeroData.HaveSkillForce(hero,0), cVar3 &&
                         (((*(int64 *)(hero + 0x260) == 0 ||
                           (lVar12 = FUN_180002f80(*(int64 *)(hero + 0x260),iVar5,DAT_181d92590),
                           lVar12 == null)) || (lVar12 = KungfuSkillLvData.DataBase(lVar12,0)) == null)
                         )) || (((((*(int64 *)(hero + 0x260) == 0 ||
                                   (lVar12 = FUN_180002f80(*(int64 *)(hero + 0x260),iVar5,
                                                           DAT_181d92590), lVar12 == null)) ||
                                  (*(int64 *)(hero + 0x260) == 0)) ||
                                 ((lVar12 = FUN_180002f80(*(int64 *)(hero + 0x260),iVar5,
                                                          DAT_181d92590), lVar12 == null ||
                                  (*(int64 *)(hero + 0x260) == 0)))) ||
                                (lVar12 = FUN_180002f80(*(int64 *)(hero + 0x260),iVar5,DAT_181d92590
                                                       ), lVar12 == null)))))) throw; // [null/range check failed]
                    Mathf.Max(0,4 - *(int *)(lVar12 + 20),0);
                    lVar12 = *(int64 *)(hero + 0x118);
                    if (((*(int64 *)(hero + 0x260) == 0) ||
                        (lVar13 = FUN_180002f80(*(int64 *)(hero + 0x260),iVar5,DAT_181d92590),
                        lVar13 == null)) ||
                       ((lVar13 = KungfuSkillLvData.DataBase(lVar13,0), lVar13 == null || (lVar12 == null))))
                    throw; // [null/range check failed]
                    FUN_18181e400(lVar12,*(uint64 *)(lVar13 + 32),DAT_181da3e58);
                    if ((*(int64 *)(hero + 0x260) == 0) ||
                       (lVar12 = FUN_180002f80(*(int64 *)(hero + 0x260),iVar5,DAT_181d92590),
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
                           (lVar12 = FUN_180002f80(*(int64 *)(hero + 0x260),iVar5,DAT_181d92590),
                           lVar12 == null)) throw; // [null/range check failed]
                        uVar8 = Int32.ToString(lVar12 + 16,0);
                        FUN_18181e0a0(lVar11,uVar8);
                        iVar4 = iVar4 + 1;
                      } while ((float)iVar4 < fVar26);
                    }
                  }
                  iVar5 = iVar5 + 1;
                }
                iVar5 = *(int *)(lVar11 + 24);
                if (iVar5 < 1) {
                  uVar17 = il2cpp_internal(DAT_181d9b7d0);
                  lVar12 = local_f0;
                  uVar8 = DAT_181d949b8;
                  goto LAB_1813e8be8;
                }
                uVar6 = GlobalData.RandomRange(0,iVar5,0,0);
                uVar8 = FUN_180002f80(lVar11,uVar6,DAT_181da4358);
              }
              else {
                uVar6 = HeroData.GetAISettingFocus(hero,1);
                lVar12 = HeroData.FindSkill(hero,uVar6,0);
                if (lVar12 == null) throw; // [null/range check failed]
                if (9 < *(int *)(lVar12 + 20)) goto LAB_1813e8779;
                local_res10[0] = HeroData.GetAISettingFocus(hero,1);
                uVar8 = Int32.ToString(local_res10,0);
              }
              uVar6 = GlobalData.RandomRange(4,7,0);
              local_100 = il2cpp_internal(DAT_181d75da8);
              uVar17 = 5;
              goto LAB_1813e875e;
            case 6:
              iVar5 = HeroData.GetAISettingFocus(hero,2);
              if (iVar5 < 0) {
        LAB_1813e8d2a:
                local_108[0] = 0;
                while( true ) {
                  lVar13 = *(int64 *)(hero + 0x158);
                  if (lVar13 == null) throw; // [null/range check failed]
                  if (*(int *)(lVar13 + 24) <= local_108[0]) break;
                  fVar26 = (float)FUN_1800d6790(lVar13,local_108[0]);
                  fVar24 = (float)HeroData.GetMaxLivingSkill(hero,local_108[0]);
                  if (fVar26 < fVar24) {
                    HeroData.GetMaxLivingSkill(hero,local_108[0],0);
                    if (*(int64 *)(hero + 0x158) == 0) throw; // [null/range check failed]
                    FUN_1800d6790(*(int64 *)(hero + 0x158),local_108[0]);
                    uVar19 = Mathf.CeilToInt();
                    uVar21 = (uint64)uVar19;
                    if (lVar10 != null) {
                      if (*(int64 *)(lVar10 + 248) == 0) throw; // [null/range check failed]
                      cVar3 = FUN_18182a3a0(*(int64 *)(lVar10 + 248),local_108[0]);
                      if (cVar3) {
                        uVar21 = (uint64)(uVar19 + 3);
                      }
                    }
                    if (0 < (int)uVar21) {
                      do {
                        Int32.ToString(local_108,0);
                        FUN_18181e0a0(lVar11);
                        uVar21 = uVar21 - 1;
                      } while (uVar21 != 0);
                    }
                  }
                  local_108[0] = local_108[0] + 1;
                }
                iVar5 = *(int *)(lVar11 + 24);
                if (iVar5 < 1) {
                  uVar17 = il2cpp_internal(DAT_181d9b7d0);
                  uVar8 = DAT_181d94ab8;
                  goto LAB_1813e8be8;
                }
                uVar6 = GlobalData.RandomRange(0,iVar5,0,0);
                uVar8 = FUN_180002f80(lVar11,uVar6,DAT_181da4358);
              }
              else {
                lVar13 = *(int64 *)(hero + 0x158);
                uVar6 = HeroData.GetAISettingFocus(hero,2);
                if (lVar13 == null) throw; // [null/range check failed]
                fVar26 = (float)FUN_1800d6790(lVar13,uVar6,DAT_181da1078);
                uVar6 = HeroData.GetAISettingFocus(hero,2);
                fVar24 = (float)HeroData.GetMaxLivingSkill(hero,uVar6,0);
                if (fVar24 <= fVar26) goto LAB_1813e8d2a;
                local_res10[0] = HeroData.GetAISettingFocus(hero,2);
                uVar8 = Int32.ToString(local_res10,0);
              }
              uVar6 = GlobalData.RandomRange(4,7,0);
              local_100 = il2cpp_internal(DAT_181d75da8);
              uVar17 = 6;
              goto LAB_1813e875e;
            case 7:
              iVar5 = HeroData.GetAISettingFocus(hero,3,0);
              if (iVar5 < 0) {
        LAB_1813e8f8e:
                local_res20[0] = 0;
                while( true ) {
                  if ((lVar10 == null) || (lVar13 = *(int64 *)(lVar10 + 136)) == null)
                  throw; // [null/range check failed]
                  if (*(int *)(lVar13 + 24) <= local_res20[0]) break;
                  fVar26 = (float)FUN_1800d6790(lVar13,local_res20[0],DAT_181da1078);
                  if (*(int64 *)(lVar10 + 144) == 0) throw; // [null/range check failed]
                  fVar24 = (float)FUN_1800d6790(*(int64 *)(lVar10 + 144),local_res20[0]);
                  if (fVar26 / fVar24 < 0.95) {
                    uVar8 = Int32.ToString(local_res20,0);
                    FUN_18181e0a0(lVar11,uVar8,DAT_181da3d58);
                    if (*(int64 *)(lVar10 + 136) == 0) throw; // [null/range check failed]
                    fVar26 = (float)FUN_1800d6790(*(int64 *)(lVar10 + 136),local_res20[0],
                                                  DAT_181da1078);
                    if (*(int64 *)(lVar10 + 144) == 0) throw; // [null/range check failed]
                    fVar24 = (float)FUN_1800d6790(*(int64 *)(lVar10 + 144),local_res20[0],
                                                  DAT_181da1078);
                    if (fVar26 / fVar24 <= 0.15) {
                      lVar13 = 5;
                      do {
                        uVar8 = Int32.ToString(local_res20,0);
                        FUN_18181e0a0(lVar11,uVar8,DAT_181da3d58);
                        lVar13 = lVar13 + -1;
                      } while (lVar13 != null);
                    }
                    if (*(int64 *)(lVar10 + 136) == 0) throw; // [null/range check failed]
                    fVar26 = (float)FUN_1800d6790(*(int64 *)(lVar10 + 136),local_res20[0],
                                                  DAT_181da1078);
                    if (*(int64 *)(lVar10 + 152) == 0) throw; // [null/range check failed]
                    fVar24 = (float)FUN_1800d6790(*(int64 *)(lVar10 + 152),local_res20[0]);
                    if (fVar24 + fVar26 < 0.0) {
                      lVar13 = 5;
                      do {
                        Int32.ToString(local_res20,0);
                        FUN_18181e0a0(lVar11);
                        lVar13 = lVar13 + -1;
                      } while (lVar13 != null);
                    }
                  }
                  local_res20[0] = local_res20[0] + 1;
                }
                iVar5 = *(int *)(lVar11 + 24);
                if (iVar5 < 1) {
                  uVar17 = il2cpp_internal(DAT_181d9b7d0);
                  uVar8 = DAT_181d94b38;
                  goto LAB_1813e8be8;
                }
                uVar6 = GlobalData.RandomRange(0,iVar5,0,0);
                uVar8 = FUN_180002f80(lVar11,uVar6,DAT_181da4358);
              }
              else {
                if (lVar10 == null) throw; // [null/range check failed]
                lVar13 = *(int64 *)(lVar10 + 136);
                uVar6 = HeroData.GetAISettingFocus(hero,3,0);
                if (lVar13 == null) throw; // [null/range check failed]
                fVar26 = (float)FUN_1800d6790(lVar13,uVar6,DAT_181da1078);
                lVar13 = *(int64 *)(lVar10 + 144);
                uVar6 = HeroData.GetAISettingFocus(hero,3,0);
                if (lVar13 == null) throw; // [null/range check failed]
                fVar24 = (float)FUN_1800d6790(lVar13,uVar6,DAT_181da1078);
                if (0.95 <= fVar26 / fVar24) goto LAB_1813e8f8e;
                local_res10[0] = HeroData.GetAISettingFocus(hero,3,0);
                uVar8 = Int32.ToString(local_res10,0);
              }
              uVar6 = GlobalData.RandomRange(4,7,0);
              local_100 = il2cpp_internal(DAT_181d75da8);
              uVar17 = 7;
        LAB_1813e875e:
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
              lVar12 = il2cpp_internal(DAT_181d93350);
              FUN_18132faf0(lVar12,DAT_181d8b418);
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
                iVar4 = FUN_1800d6760(*(int64 *)(lVar13 + 120),iVar5);
                if (iVar4 != 0) {
                  lVar13 = FUN_18046c0a0(0);
                  if (((lVar13 == null) || (*(int64 *)(lVar13 + 32) == 0)) ||
                     ((lVar13 = WorldData.GetArea(*(int64 *)(lVar13 + 32),
                                                   *(uint32 *)(hero + 192),0), lVar13 == null ||
                      (*(int64 *)(lVar13 + 120) == 0)))) throw; // [null/range check failed]
                  iVar4 = FUN_1800d6760(*(int64 *)(lVar13 + 120),iVar5);
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
                      FUN_18181e0a0(lVar12,uVar8);
                    }
                  }
                }
                iVar5 = iVar5 + 1;
              }
              if (lVar12 == null) throw; // [null/range check failed]
              if (*(int *)(lVar12 + 24) < 1) {
                lVar12 = *(int64 *)(pStatics + 8);
                if (lVar12 == null) {
                  uVar8 = **(uint64 **)(DAT_181dc0c50 + 184);
                  lVar12 = new OnTooltipCB(uVar8,DAT_181d94838);
                  plVar16 = (int64 *)(pStatics + 8);
                  *plVar16 = lVar12;
                  il2cpp_internal(plVar16,lVar12);
                }
                FUN_18182e030(lVar9,lVar12,DAT_181d7af08);
                if (*(int64 *)(pStatics + 16) == 0) {
                  uVar8 = **(uint64 **)(DAT_181dc0c50 + 184);
                  uVar17 = new OnTooltipCB(uVar8,DAT_181d948b8);
                  puVar15 = (uint64 *)(pStatics + 16);
                  *puVar15 = uVar17;
                  il2cpp_internal(puVar15,uVar17);
                }
                FUN_18182e030(lVar9);
              }
              else {
                lVar9 = il2cpp_internal(DAT_181d93cd0);
                FUN_18132faf0(lVar9,DAT_181d8f098);
                for (iVar5 = 0; iVar5 < *(int *)(lVar12 + 24); iVar5 = iVar5 + 1) {
                  uVar8 = FUN_180002f80(lVar12,iVar5,DAT_181d8bb98);
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
                    lVar11 = FUN_180002f80(lVar12,iVar5,DAT_181d8bb98);
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
                    fVar27 = ABS(fVar26) * fVar24 * fVar27;
                    iVar4 = 0;
                    if (0.0 < fVar27) {
                      do {
                        if (lVar9 == null) throw; // [null/range check failed]
                        FUN_18182a0b0(lVar9,iVar5);
                        iVar4 = iVar4 + 1;
                      } while ((float)iVar4 < fVar27);
                    }
                  }
                }
                if (lVar9 == null) throw; // [null/range check failed]
                iVar5 = *(int *)(lVar9 + 24);
                if (0 < iVar5) {
                  uVar6 = GlobalData.RandomRange(0,iVar5,0,0);
                  uVar6 = FUN_1800d6760(lVar9,uVar6,DAT_181d8fa18);
                  lVar9 = FUN_180002f80(lVar12,uVar6,DAT_181d8bb98);
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
                if (local_100 != 0) goto LAB_1813eab8d;
                uVar6 = *(uint32 *)(lVar12 + 24);
                uVar7 = *(uint32 *)(local_f0 + 16);
                uVar6 = GlobalData.RandomRange(0,uVar6,0,0);
                lVar9 = FUN_180002f80(lVar12,uVar6,DAT_181d8bb98);
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
              cVar3 = HeroData.HaveForce(hero,0);
              if (!cVar3) {
                cVar3 = HeroData.HaveSkillForce(hero,0);
                if (!cVar3) {
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
                lVar14 = il2cpp_internal(DAT_181d917d8);
                FUN_18132faf0(lVar14,DAT_181d804a0);
                if (lVar14 == null) throw; // [null/range check failed]
                FUN_1817e98e0(lVar14,1,DAT_181d80520);
                FUN_1817e98e0(lVar14,1,DAT_181d80520);
                FUN_1817e98e0(lVar14,1,DAT_181d80520);
                FUN_1817e98e0(lVar14,1,DAT_181d80520);
                FUN_1817e98e0(lVar14,1,DAT_181d80520);
                FUN_1817e98e0(lVar14,1,DAT_181d80520);
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
                    FUN_1817f42f0(lVar14);
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
                        cVar3 = FUN_180133a50(lVar14,iVar4,DAT_181d806a0);
                        if (!cVar3) {
                          dVar25 = (double)GlobalData.RandomRangeDouble(0,0);
                          if (*(int64 *)(hero + 600) == 0) throw; // [null/range check failed]
                          iVar20 = FUN_1800d6760(*(int64 *)(hero + 600),iVar4);
                          fVar26 = (float)HeroData.GetMaxSkillNum(hero,iVar4);
                          fVar24 = (float)HeroData.GetMaxSkillNum(hero);
                          if (dVar25 <= (double)((((float)iVar20 - fVar26) + ((float)iVar20 - fVar26)) /
                                                fVar24)) goto LAB_1813e9eb5;
                        }
                        if ((((plVar13 == 0) ||
                             (lVar9 = *(int64 *)(plVar13 + 40)) == null) ||
                            (lVar9 = FUN_180002f80(lVar9,iVar5,DAT_181d90f18)) == null) ||
                           (*(int64 *)(lVar9 + 112) == 0)) throw; // [null/range check failed]
                        Int32.ToString(*(int64 *)(lVar9 + 112) + 16,0);
                        FUN_18181e0a0(local_f8);
                      }
                    }
        LAB_1813e9eb5:
                    iVar5 = iVar5 + 1;
                  }
                }
                cVar3 = HeroData.IsPlayerSameForce(hero,0);
                if ((!cVar3) || (lVar9 = local_e8, *(int *)(hero + 0x374) != 1)) {
                  iVar5 = 0;
                  while( true ) {
                    if (((*(int64 *)(hero + 0x220) == 0) ||
                        (lVar9 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null) ||
                       (lVar13 = FUN_180002f80(lVar9,3,DAT_181d78ba8)) == null) throw; // [null/range check failed]
                    lVar11 = local_f8;
                    lVar12 = local_f0;
                    lVar9 = local_e8;
                    if (*(int *)(lVar13 + 24) <= iVar5) break;
                    if ((((*(int64 *)(hero + 0x220) == 0) ||
                         (lVar9 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null) ||
                        (lVar9 = FUN_180002f80(lVar9,3,DAT_181d78ba8)) == null) ||
                       ((lVar9 = FUN_180002f80(lVar9,iVar5,DAT_181d90f18), lVar9 == null ||
                        (*(int64 *)(lVar9 + 112) == 0)))) throw; // [null/range check failed]
                    lVar9 = HeroData.FindSkill(hero,*(uint32 *)
                                                         (*(int64 *)(lVar9 + 112) + 16),0);
                    if (lVar9 == null) {
                      if (((*(int64 *)(hero + 0x220) == 0) ||
                          (lVar9 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null) ||
                         ((lVar9 = FUN_180002f80(lVar9,3,DAT_181d78ba8), lVar9 == null ||
                          (((lVar9 = FUN_180002f80(lVar9,iVar5,DAT_181d90f18), lVar9 == null ||
                            (*(int64 *)(lVar9 + 112) == 0)) ||
                           (lVar9 = BookData.DataBase(*(int64 *)(lVar9 + 112),0)) == null)))))
                      throw; // [null/range check failed]
                      uVar6 = *(uint32 *)(lVar9 + 52);
                      dVar25 = (double)GlobalData.RandomRangeDouble(0,0);
                      fVar26 = (float)Mathf.Max();
                      if (dVar25 <= (double)(1.0 / (fVar26 + fVar26))) {
                        cVar3 = FUN_180133a50(lVar14,uVar6,DAT_181d806a0);
                        if (!cVar3) {
                          dVar25 = (double)GlobalData.RandomRangeDouble(0,0);
                          if (*(int64 *)(hero + 600) == 0) throw; // [null/range check failed]
                          iVar4 = FUN_1800d6760(*(int64 *)(hero + 600),uVar6,DAT_181d8fa18);
                          fVar26 = (float)HeroData.GetMaxSkillNum(hero,uVar6,0);
                          fVar24 = (float)HeroData.GetMaxSkillNum(hero,uVar6,0);
                          if (dVar25 <= (double)((((float)iVar4 - fVar26) + ((float)iVar4 - fVar26)) /
                                                fVar24)) goto LAB_1813ea17e;
                        }
                        if ((((*(int64 *)(hero + 0x220) == 0) ||
                             (lVar9 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null)
                            || (lVar9 = FUN_180002f80(lVar9,3,DAT_181d78ba8)) == null) ||
                           ((lVar9 = FUN_180002f80(lVar9,iVar5,DAT_181d90f18), lVar9 == null ||
                            (*(int64 *)(lVar9 + 112) == 0)))) throw; // [null/range check failed]
                        uVar8 = Int32.ToString(*(int64 *)(lVar9 + 112) + 16,0);
                        FUN_18181e0a0(local_f8,uVar8,DAT_181da3d58);
                      }
                    }
        LAB_1813ea17e:
                    iVar5 = iVar5 + 1;
                  }
                }
              }
              uVar6 = 3;
              iVar5 = *(int *)(lVar11 + 24);
              if (0 < iVar5) {
                uVar7 = GlobalData.RandomRange(0,iVar5,0,0);
                uVar8 = FUN_180002f80(lVar11,uVar7,DAT_181da4358);
                local_100 = il2cpp_internal(DAT_181d75da8);
                uVar17 = 18;
                goto LAB_1813e875e;
              }
              uVar17 = il2cpp_internal(DAT_181d9b7d0);
              uVar8 = DAT_181d94a38;
        LAB_1813e8be8:
              OnTooltipCB.ctor(uVar17,lVar12,uVar8);
              FUN_18182e030(lVar9);
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
                  local_100 = il2cpp_internal(DAT_181d75da8);
                  uVar17 = 19;
                  goto LAB_1813e875e;
                }
              }
              lVar11 = il2cpp_internal(DAT_181d93cd0);
              FUN_18132faf0(lVar11,DAT_181d8f098);
              iVar5 = 0;
              while( true ) {
                if ((lVar10 == null) || (*(int64 *)(lVar10 + 96) == 0)) throw; // [null/range check failed]
                if (*(int *)(*(int64 *)(lVar10 + 96) + 24) <= iVar5) break;
                lVar12 = FUN_18046c0a0(0);
                if (lVar12 == null) throw; // [null/range check failed]
                lVar12 = *(int64 *)(lVar12 + 32);
                if (((*(int64 *)(lVar10 + 96) == 0) ||
                    (uVar6 = FUN_1800d6760(*(int64 *)(lVar10 + 96),iVar5,DAT_181d8fa18), lVar12 == null)
                    ) || (lVar12 = WorldData.GetArea(lVar12,uVar6,0)) == null) throw; // [null/range check failed]
                if (*(int *)(lVar12 + 72) != 2) {
                  lVar12 = FUN_18046c0a0(0);
                  if (lVar12 == null) throw; // [null/range check failed]
                  lVar12 = *(int64 *)(lVar12 + 32);
                  if (((*(int64 *)(lVar10 + 96) == 0) ||
                      (uVar6 = FUN_1800d6760(*(int64 *)(lVar10 + 96),iVar5,DAT_181d8fa18),
                      lVar12 == null)) || (lVar12 = WorldData.GetArea(lVar12,uVar6,0)) == null)
                  throw; // [null/range check failed]
                  cVar3 = AreaData.CanAddState(lVar12,0);
                  if (cVar3) {
                    if ((*(int64 *)(lVar10 + 96) == 0) ||
                       (uVar6 = FUN_1800d6760(*(int64 *)(lVar10 + 96),iVar5,DAT_181d8fa18),
                       lVar11 == null)) throw; // [null/range check failed]
                    FUN_18182a0b0(lVar11,uVar6,DAT_181d8f218);
                  }
                }
                iVar5 = iVar5 + 1;
              }
              if (lVar11 == null) throw; // [null/range check failed]
              if (*(int *)(lVar11 + 24) < 1) {
                uVar8 = new OnTooltipCB(local_f0,DAT_181d94bb8);
                FUN_18182e030(lVar9);
                lVar11 = local_f8;
              }
              else {
                lVar9 = *(int64 *)(pStatics + 24);
                if (lVar9 == null) {
                  uVar8 = **(uint64 **)(DAT_181dc0c50 + 184);
                  lVar9 = new OnTooltipCB(uVar8,DAT_181d94938,DAT_181dab3b8);
                  plVar16 = (int64 *)(pStatics + 24);
                  *plVar16 = lVar9;
                  il2cpp_internal(plVar16,lVar9);
                }
                List_1.Sort(lVar11,lVar9,DAT_181d8f818);
                local_res10[0] = FUN_1800d6760(lVar11,0,DAT_181d8fa18);
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
                  local_100 = il2cpp_internal(DAT_181d75da8);
                  uVar17 = 20;
                  goto LAB_1813e875e;
                }
              }
              lVar9 = il2cpp_internal(DAT_181d93cd0);
              FUN_18132faf0(lVar9);
              iVar5 = 0;
              while( true ) {
                if ((lVar10 == null) || (*(int64 *)(lVar10 + 96) == 0)) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar11 = local_f8;
                if (*(int *)(*(int64 *)(lVar10 + 96) + 24) <= iVar5) break;
                iVar4 = 0;
                while( true ) {
                  lVar11 = FUN_18046c0a0(0);
                  if (lVar11 == null) throw; // [null/range check failed]
                  lVar11 = *(int64 *)(lVar11 + 32);
                  if ((((*(int64 *)(lVar10 + 96) == 0) ||
                       (uVar6 = FUN_1800d6760(*(int64 *)(lVar10 + 96),iVar5,DAT_181d8fa18),
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
                       (uVar6 = FUN_1800d6760(*(int64 *)(lVar10 + 96),iVar5,DAT_181d8fa18),
                       lVar12 == null)) || (lVar12 = WorldData.GetArea(lVar12,uVar6,0)) == null) ||
                     (((*(int64 *)(lVar12 + 152) == 0 ||
                       (uVar6 = FUN_1800d6760(*(int64 *)(lVar12 + 152),iVar4,DAT_181d8fa18),
                       lVar11 == null)) || (lVar11 = WorldData.GetArea(lVar11,uVar6,0)) == null)))
                  throw; // [null/range check failed]
                  if (((*(int *)(lVar11 + 72) != 2) &&
                      (cVar3 = AreaData.HaveForce(lVar11,0), cVar3)) &&
                     (*(int *)(lVar11 + 112) != *(int *)(hero + 132))) {
                    lVar12 = AreaData.GetForce(lVar11,0);
                    if (lVar12 == null) throw; // [null/range check failed]
                    fVar26 = (float)ForceData.GetForceFavor(lVar12,*(uint32 *)(hero + 132),0);
                    dVar25 = (double)GlobalData.RandomRangeDouble(0,0);
                    if (((double)((fVar26 - 30.0) / 50.0) < dVar25) &&
                       (cVar3 = AreaData.CanReduceState(lVar11,0), cVar3)) {
                      if (lVar9 == null) throw; // [null/range check failed]
                      FUN_18182a0b0(lVar9,*(uint32 *)(lVar11 + 16),DAT_181d8f218);
                    }
                  }
                  iVar4 = iVar4 + 1;
                }
                if (lVar9 == null) throw; // [null/range check failed]
                iVar4 = *(int *)(lVar9 + 24);
                if (iVar4 < 1) {
                  if (*(int64 *)(local_f0 + 24) == 0) {
                    uVar8 = new OnTooltipCB(lVar11,DAT_181d94c38);
                    *(uint64 *)(lVar11 + 24) = uVar8;
                  }
                  FUN_18182e030(local_e8);
                  iVar5 = iVar5 + 1;
                }
                else {
                  uVar6 = GlobalData.RandomRange(0,iVar4,0,0);
                  local_res10[0] = FUN_1800d6760(lVar9,uVar6,DAT_181d8fa18);
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
        LAB_1813eab8d:
          AIController.SetAIStuff(this,hero,local_100,0,0);
          return;
        }
    }

    // Token : 0x60009F1
    // RVA   : 0x13DC7E0   Offset: 0x13DBBE0   Length: 0x76
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
            FUN_18182a0b0(availableStuffType,newAIStuffType,DAT_181d7ae08);
            iVar1 = iVar1 + 1;
          } while (iVar1 < num);
        }
    }

    // Token : 0x60009F2
    // RVA   : 0x13EB7D0   Offset: 0x13EABD0   Length: 0x4F1
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
          if (aiData == null) goto LAB_1813ebcbc;
          if (*(int *)(aiData + 16) == 13) {
            if (hero == null) goto LAB_1813ebcbc;
            fVar12 = (float)HeroData.Favor(hero,0,0);
            if (40.0 <= fVar12) {
              iVar3 = *(int *)(hero + 184);
              lVar5 = FUN_18046c0a0(0);
              if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
                 (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null)
              goto LAB_1813ebcbc;
              iVar3 = Mathf.Abs(iVar3 - *(int *)(lVar5 + 184),0);
              if (iVar3 < 3) {
                lVar5 = HeroData.GetBigMapPos(hero,0);
                lVar6 = FUN_18046c0a0(0);
                if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                   ((lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0), lVar6 == null ||
                    (uVar7 = HeroData.GetBigMapPos(lVar6,0), lVar5 == null)))) {
        LAB_1813ebcbc:
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                fVar12 = (float)BigMapPos.Distance(lVar5,uVar7,0);
                if (fVar12 <= *(float *)(*(int64 *)(DAT_181d73d40 + 184) + 0x114) * 200.0 *
                              (float)(*(int *)(aiData + 32) + -1)) {
                  lVar5 = FUN_18046c2c0(0);
                  uVar7 = *(uint64 *)(hero + 104);
                  uVar8 = HeroData.AtAreaName(hero,0);
                  uVar10 = "我在{0}{1}，若#PlayerName#能在{2}日内赶来助阵，必当感激不尽！";
                  uVar11 = "遭到贼人袭击";
                  if (!setInteractTarget) {
                    uVar11 = "寻得仇家踪迹";
                  }
                  local_res10[0] = *(int *)(aiData + 32) + -1;
                  uVar9 = il2cpp_value_box(DAT_181d80418,local_res10);
                  uVar13 = 0;
                  uVar10 = String.Format(uVar10,uVar8,uVar11,uVar9,0);
                  uVar11 = il2cpp_internal(DAT_181d87918);
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
          if (hero == null) goto LAB_1813ebcbc;
          HeroData.SetHeroAIData(hero,aiData,0);
          if (setInteractTarget) {
            return;
          }
          lVar5 = *(int64 *)(*(int64 *)(DAT_181da9de0 + 184) + 8);
          if ((*(int64 *)(hero + 64) == 0) || (lVar5 == null)) goto LAB_1813ebcbc;
          cVar2 = FUN_18182a3a0(lVar5,*(uint32 *)(*(int64 *)(hero + 64) + 16),DAT_181d7ae88)
          ;
          if (!cVar2) {
            return;
          }
          lVar5 = FUN_18046c0a0(0);
          if (lVar5 == null) goto LAB_1813ebcbc;
          lVar5 = *(int64 *)(lVar5 + 32);
          uVar4 = Int32.Parse(*(uint64 *)(aiData + 24),0);
          if (lVar5 == null) goto LAB_1813ebcbc;
          lVar5 = WorldData.GetHero(lVar5,uVar4,0);
          if (lVar5 == null) {
            return;
          }
          lVar5 = FUN_18046c0a0(0);
          if (lVar5 == null) goto LAB_1813ebcbc;
          lVar5 = *(int64 *)(lVar5 + 32);
          uVar4 = Int32.Parse(*(uint64 *)(aiData + 24),0);
          if (lVar5 == null) goto LAB_1813ebcbc;
          lVar5 = WorldData.GetHero(lVar5,uVar4,0);
          uVar4 = *(uint32 *)(aiData + 16);
          uVar7 = Int32.ToString(hero + 88,0);
          uVar1 = *(uint32 *)(aiData + 32);
          aiData = il2cpp_internal(DAT_181d75da8);
          in_stack_ffffffffffffff80 = 0;
          HeroAIData.ctor(aiData,uVar4,uVar7,uVar1,1,0);
          setInteractTarget = true;
          hero = lVar5;
        } while( true );
    }

    // Token : 0x60009F3
    // RVA   : 0x13DC860   Offset: 0x13DBC60   Length: 0xB63
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
          lVar10 = il2cpp_internal(DAT_181d93cd0);
          FUN_18132faf0(lVar10,DAT_181d8f098);
          lVar11 = il2cpp_internal(DAT_181d93cd0);
          FUN_18132faf0(lVar11,DAT_181d8f098);
          lVar12 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
          if (((lVar12 != null) && (lVar12 = *(int64 *)(lVar12 + 0x198)) != null) &&
             (lVar12 = FUN_1808ae5b0(lVar12,DAT_181dba4a8)) != null) {
            ValueCollection.GetEnumerator(&local_50,lVar12,DAT_181d7e7e8);
            local_68 = local_50;
            uStack_64 = uStack_4c;
            uStack_60 = uStack_48;
            uStack_5c = uStack_44;
            local_58 = local_40;
        LAB_1813dcb21:
            cVar3 = FUN_1811c3f80(&local_68,DAT_181d988d8);
            lVar12 = local_58;
            if (cVar3) {
              lVar13 = *(int64 *)(*(int64 *)(DAT_181d87a18 + 184) + 8);
              if (lVar12 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if (lVar13 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              cVar3 = FUN_18181e400(lVar13,*(uint64 *)(lVar12 + 80));
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
                  if (iVar4 < 1) goto LAB_1813dcb21;
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
                  if (iVar5 == *(int *)(lVar13 + 16)) goto LAB_1813dcb21;
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
                    cVar3 = FUN_18171e540(*(uint64 *)(lVar13 + 48),*(uint64 *)(lVar12 + 40));
                    if (cVar3) goto LAB_1813dcb21;
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
                    cVar3 = FUN_18171e540(*(uint64 *)(lVar13 + 40),*(uint64 *)(lVar12 + 40));
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
                      if (iVar6 <= iVar5) goto LAB_1813dcb21;
                    }
                  }
                  iVar4 = iVar4 + 1;
                }
                if (bVar1) {
                  lVar13 = FUN_18046c300(0);
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
                      FUN_18182a0b0(lVar11);
                    }
                    else {
                      if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620(extraout_XMM0_Da,*(uint32 *)(lVar12 + 16));
                      }
                      FUN_18182a0b0(lVar10);
                    }
                  }
                }
              }
              goto LAB_1813dcb21;
            }
            ZhSegment.Initialize(&local_68,DAT_181d98858);
            if (lVar10 != null) {
              iVar4 = *(int *)(lVar10 + 24);
              if (iVar4 < 1) {
                if (lVar11 == null) throw; // [null/range check failed]
                if (*(int *)(lVar11 + 24) < 1) {
                  return;
                }
                lVar10 = il2cpp_internal(DAT_181d93cd0);
                FUN_18132faf0(lVar10,DAT_181d8f098);
                for (iVar4 = 0; iVar4 < *(int *)(lVar11 + 24); iVar4 = iVar4 + 1) {
                  lVar12 = FUN_18046c100(0);
                  if (lVar12 == null) throw; // [null/range check failed]
                  lVar12 = *(int64 *)(lVar12 + 0x198);
                  uVar7 = FUN_1800d6760(lVar11,iVar4,DAT_181d8fa18);
                  if (lVar12 == null) throw; // [null/range check failed]
                  lVar12 = FUN_1817d9e10(lVar12,uVar7);
                  iVar5 = 1;
                  if ((lVar12 == null) || (*(int64 *)(lVar12 + 88) == 0)) throw; // [null/range check failed]
                  fVar16 = (float)HeroSpeAddData.Get(*(int64 *)(lVar12 + 88),208);
                  if (0.0 < fVar16) {
        LAB_1813dd186:
                    lVar13 = *(int64 *)(lVar9 + 16);
                    if (lVar13 == null) throw; // [null/range check failed]
                    if ((*(int *)(lVar13 + 132) == 16) || (*(int *)(lVar13 + 136) == 16)) {
                      iVar6 = 40;
        LAB_1813dd1aa:
                      iVar5 = 0;
                      do {
                        if (lVar10 == null) throw; // [null/range check failed]
                        FUN_18182a0b0(lVar10,*(uint32 *)(lVar12 + 16));
                        iVar5 = iVar5 + 1;
                      } while (iVar5 < iVar6);
                    }
                  }
                  else {
                    if (*(int64 *)(lVar12 + 88) == 0) throw; // [null/range check failed]
                    fVar16 = (float)HeroSpeAddData.Get(*(int64 *)(lVar12 + 88),210);
                    if (0.0 < fVar16) goto LAB_1813dd186;
                    if (*(int64 *)(lVar12 + 88) == 0) throw; // [null/range check failed]
                    fVar16 = (float)HeroSpeAddData.Get(*(int64 *)(lVar12 + 88),209);
                    if (0.0 < fVar16) goto LAB_1813dd186;
                    lVar13 = il2cpp_internal(DAT_181d93cd0);
                    FUN_18132faf0(lVar13,DAT_181d8f098);
                    if (lVar13 == null) throw; // [null/range check failed]
                    FUN_18182a0b0(lVar13,0,DAT_181d8f218);
                    FUN_18182a0b0(lVar13,1,DAT_181d8f218);
                    FUN_18182a0b0(lVar13,2,DAT_181d8f218);
                    FUN_18182a0b0(lVar13,3,DAT_181d8f218);
                    FUN_18182a0b0(lVar13,4,DAT_181d8f218);
                    FUN_18182a0b0(lVar13,5,DAT_181d8f218);
                    lVar14 = *(int64 *)(lVar9 + 24);
                    if (lVar14 == null) {
                      lVar14 = new OnTooltipCB(lVar9,DAT_181d94cb8);
                      *(int64 *)(lVar9 + 24) = lVar14;
                    }
                    List_1.Sort(lVar13,lVar14,DAT_181d8f818);
                    iVar15 = 0;
                    iVar6 = 10;
                    do {
                      lVar14 = *(int64 *)(lVar12 + 88);
                      uVar7 = FUN_1800d6760(lVar13,iVar15);
                      if (lVar14 == null) throw; // [null/range check failed]
                      fVar16 = (float)HeroSpeAddData.Get(lVar14,uVar7);
                      if ((0.0 < fVar16) &&
                         (cVar3 = FUN_18171e540(*(uint64 *)(lVar12 + 80),"战法"),
                         !cVar3)) {
                        cVar3 = FUN_18171e540(*(uint64 *)(lVar12 + 80),"天生");
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
                      iVar5 = FUN_1800d6760(lVar13,iVar15);
                      if (lVar14 == null) throw; // [null/range check failed]
                      iVar15 = iVar15 + 1;
                      fVar16 = (float)HeroSpeAddData.Get(lVar14,iVar5 + 6);
                      iVar5 = iVar6 + 20;
                      if (fVar16 <= 0.0) {
                        iVar5 = iVar6;
                      }
                    }
                    if (0 < iVar6) goto LAB_1813dd1aa;
                  }
                }
                if (lVar10 == null) throw; // [null/range check failed]
                uVar7 = *(uint32 *)(lVar10 + 24);
                uVar7 = GlobalData.RandomRange(0,uVar7,0,0);
                iVar4 = FUN_1800d6760(lVar10,uVar7,DAT_181d8fa18);
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
                  (lVar11 = FUN_1817d9e10(*(int64 *)(lVar11 + 0x198),iVar4,DAT_181dba420)) != null
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

    // Token : 0x60009F4
    // RVA   : 0x13DDB60   Offset: 0x13DCF60   Length: 0x779C
    public bool FinishAIStuff(HeroData hero)
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
        int iVar1;
        bool cVar3;
        uint uVar4;
        uint uVar5;
        ulong uVar6;
        ulong uVar7;
        long lVar8;
        ulong uVar9;
        ulong uVar11;
        ulong uVar12;
        long lVar13;
        long lVar14;
        long lVar15;
        long lVar16;
        ulong uVar17;
        uint uVar18;
        int iVar19;
        ulong uVar20;
        int iVar21;
        uint uVar23;
        float fVar24;
        float fVar25;
        float fVar26;
        float fVar27;
        float fVar28;
        float fVar29;
        double dVar30;
        byte[] auVar31 = new byte[16];
        byte[] auVar32 = new byte[16];
        byte[] auVar33 = new byte[16];
        byte[] auVar34 = new byte[16];
        byte[] auVar35 = new byte[16];
        byte[] auVar36 = new byte[16];
        float fVar37;
        ulong local_res10;
        ulong in_stack_fffffffffffffe78;
        ulong in_stack_fffffffffffffe80;
        ulong in_stack_fffffffffffffe88;
        ulong in_stack_fffffffffffffe90;
        uint uVar41;
        ulong uVar40;
        ulong in_stack_fffffffffffffe98;
        uint uVar43;
        ulong uVar42;
        uint local_158;
        byte local_154;
        bool local_153;
        ulong local_150;
        int local_148;
        uint local_144;
        float local_140;
        uint32 local_13c;
        int64 local_138;
        uint32 local_130;
        uint32 local_12c;
        int local_128;
        int local_124;
        uint32 local_120;
        uint32 local_11c;
        uint32 local_118;
        uint32 local_114;
        uint32 local_110;
        uint32 local_10c;
        int local_108;
        int local_104;
        int local_100;
        int local_fc;
        int local_f8;
        int local_f4;
        int local_f0;
        int local_ec;
        int local_e8 [40];
        uint64 extraout_XMM0_Qb;
        uint64 extraout_XMM0_Qb_00;
        uint64 extraout_XMM0_Qb_01;
        uVar17 = 0;
        local_144 = 0;
        local_13c = 0;
        local_148 = 0;
        local_140 = 0.0;
        if ((hero == null) || (lVar14 = *(int64 *)(hero + 64)) == null) goto LAB_1813e5276;
        if (*(int *)(lVar14 + 16) == 16) {
          HeroData.GoOutPrison(hero,0);
          uVar6 = HeroData.Name(hero,1,0);
          uVar7 = HeroData.AtAreaName(hero,0);
          uVar6 = String.Format("{0}在{1}结束关押，恢复了自由之身。",uVar6,uVar7);
          HeroData.AddLog(hero,uVar6,0);
          lVar14 = *(int64 *)(hero + 64);
        }
        uVar12 = "";
        fVar29 = 0.0;
        local_154 = 0;
        bVar2 = false;
        local_158 = 0;
        if (lVar14 == null) goto LAB_1813e5276;
        if (*(int *)(lVar14 + 36) < 1) goto switchD_1813de14e_caseD_0;
        lVar8 = new c.DisplayClass9_0(0);
        uVar9 = "";
        uVar4 = (uint32)((uint64)in_stack_fffffffffffffe88 >> 32);
        uVar5 = (uint32)((uint64)in_stack_fffffffffffffe90 >> 32);
        uVar41 = (uint32)((uint64)in_stack_fffffffffffffe98 >> 32);
        lVar14 = *(int64 *)(hero + 64);
        if (lVar14 == null) goto LAB_1813e5276;
        switch(*(uint32 *)(lVar14 + 16)) {
        default:
          goto switchD_1813de14e_caseD_0;
        case 2:
          dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
          if (dVar30 < 0.5) {
            dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
            fVar29 = (float)FUN_1801f8ab0();
            if (*(int64 *)(hero + 64) == 0) goto LAB_1813e5276;
            uVar4 = Mathf.RoundToInt(((float)dVar30 + (float)dVar30 + 1.0) * fVar29 *
                                      (float)*(int *)(*(int64 *)(hero + 64) + 36),0);
            local_158 = Mathf.Max(1,uVar4);
            HeroData.ChangeMoney(hero,local_158,0,0);
            uVar7 = HeroData.Name(hero,1,0);
            uVar40 = HeroData.AtAreaName(hero,0);
            local_130 = local_158;
            uVar42 = il2cpp_value_box(DAT_181d80418,&local_130);
            uVar6 = "{0}在{1}闲逛之时，意外获取了{2}两银钱。";
          }
          else {
            lVar8 = FUN_18046c0a0(0);
            lVar14 = *(int64 *)(hero + 64);
            if (lVar14 == null) goto LAB_1813e5276;
            Mathf.Min(lVar14,(float)*(int *)(lVar14 + 36) * 0.2,0);
            GlobalData.RandomRange();
            HeroData.GetHeroItemLv(hero,0,0);
            if (lVar8 == null) goto LAB_1813e5276;
            uVar6 = 0;
            lVar14 = hero;
            lVar8 = GameController.GenerateRandomItem(lVar8);
            HeroData.GetItem(hero,lVar8,0,0,lVar14,uVar6);
            uVar7 = HeroData.Name(hero,1,0);
            uVar40 = HeroData.AtAreaName(hero,0);
            if (lVar8 == null) goto LAB_1813e5276;
            uVar42 = ItemData.Name(lVar8,1,0);
            uVar6 = "{0}在{1}闲逛之时，意外获取了一件{2}。";
          }
          uVar6 = String.Format(uVar6,uVar7,uVar40,uVar42,0);
          HeroData.AddLog(hero,uVar6,0);
          fVar29 = 0.25;
          break;
        case 5:
          uVar4 = Int32.Parse(*(uint64 *)(lVar14 + 24),0);
          lVar14 = HeroData.FindSkill(hero,uVar4,0);
          if (lVar14 != null) {
            GlobalData.RandomRange(15,26,0);
            if (*(int64 *)(hero + 64) == 0) goto LAB_1813e5276;
            KungfuSkillLvData.FightExpFull(lVar14,0);
            HeroData.GetLoyalExpRate(hero,0);
            uVar6 = 0;
            HeroData.AddSkillBookExp(hero);
            GlobalData.RandomRange(15,26,0,0,uVar6);
            if (*(int64 *)(hero + 64) == 0) goto LAB_1813e5276;
            KungfuSkillLvData.BookExpFull(lVar14,0);
            HeroData.GetLoyalExpRate(hero,0);
            HeroData.AddSkillFightExp(hero);
            uVar6 = HeroData.Name(hero,1,0);
            uVar7 = HeroData.AtAreaName(hero,0);
            uVar40 = KungfuSkillLvData.Name(lVar14,1,0);
            uVar6 = String.Format("{0}在{1}修习了武功{2}。",uVar6,uVar7,uVar40,0);
            HeroData.AddLog(hero,uVar6,0);
            fVar29 = 1.0;
          }
          lVar14 = FUN_18046c0a0(0);
          if (((lVar14 == null) || (*(int64 *)(lVar14 + 32) == 0)) ||
             (lVar14 = *(int64 *)(*(int64 *)(lVar14 + 32) + 168)) == null)
          goto LAB_1813e5276;
          if (((3 < *(int *)(lVar14 + 16)) &&
              (cVar3 = HeroData.IsPlayerSameForce(hero,0), !cVar3)) &&
             (4.0 <= *(float *)(hero + 0x364))) {
            dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
            lVar14 = FUN_18046c0a0(0);
            if ((lVar14 == null) || (*(int64 *)(lVar14 + 32) == 0)) goto LAB_1813e5276;
            fVar28 = (float)WorldData.GetAIForceDevelopSpeed(*(int64 *)(lVar14 + 32),0);
            if (dVar30 < (double)((fVar28 * 0.05 + 1.0) * 0.1)) {
              AIController.AutoManageTag(this,hero,0);
            }
          }
          goto LAB_1813e515f;
        case 6:
          uVar4 = Int32.Parse(*(uint64 *)(lVar14 + 24),0);
          iVar21 = GlobalData.RandomRange(30,41,0);
          if (*(int64 *)(hero + 64) == 0) goto LAB_1813e5276;
          iVar19 = *(int *)(*(int64 *)(hero + 64) + 36);
          iVar1 = *(int *)(hero + 184);
          fVar29 = (float)HeroData.GetLoyalExpRate(hero,0);
          HeroData.ChangeLivingSkillExp
                    (hero,uVar4,((float)iVar1 * 0.25 + 1.0) * (float)(iVar21 * iVar19) * fVar29,0,0);
          uVar6 = HeroData.Name(hero,1,0);
          uVar7 = HeroData.AtAreaName(hero,0);
          lVar14 = *(int64 *)(pStatics + 0x4b0);
          if ((*(int64 *)(hero + 64) == 0) ||
             (uVar4 = Int32.Parse(*(uint64 *)(*(int64 *)(hero + 64) + 24),0), lVar14 == null))
          goto LAB_1813e5276;
          uVar40 = FUN_180002f80(lVar14,uVar4,DAT_181da4358);
          uVar6 = String.Format("{0}在{1}修习了{2}技艺。",uVar6,uVar7,uVar40,0);
          goto LAB_1813de7d8;
        case 7:
          cVar3 = HeroData.HaveForce(hero,0);
          if (cVar3) {
            if (*(int64 *)(hero + 64) == 0) goto LAB_1813e5276;
            uVar4 = Int32.Parse(*(uint64 *)(*(int64 *)(hero + 64) + 24),0);
            lVar14 = *(int64 *)(pStatics + 0x440);
            if (lVar14 == null) goto LAB_1813e5276;
            uVar5 = FUN_1800d6760(lVar14,uVar4,DAT_181d93190);
            lVar14 = *(int64 *)(pStatics + 0x448);
            if (lVar14 == null) goto LAB_1813e5276;
            fVar28 = (float)FUN_1800d6790(lVar14,uVar4,DAT_181da1078);
            if (*(int64 *)(hero + 0x168) == 0) goto LAB_1813e5276;
            FUN_1800d6790(*(int64 *)(hero + 0x168),uVar5,DAT_181da1078);
            HeroData.GetLoyalWorkRate(hero,0);
            if (*(int64 *)(hero + 64) == 0) goto LAB_1813e5276;
            fVar29 = 1.0;
            fVar26 = (float)Mathf.Max();
            lVar14 = HeroData.GetForce(hero,0,0);
            if (lVar14 == null) goto LAB_1813e5276;
            uVar6 = 0;
            ForceData.ChangeResource(lVar14,uVar4);
            HeroData.ChangeLivingSkillExp
                      (hero,uVar5,
                       ((float)*(int *)(hero + 184) * 0.25 + 1.0) * (fVar26 / (10.0 / fVar28)) * 10.0,
                       0,0,uVar6);
            uVar6 = HeroData.Name(hero,1,0);
            uVar7 = HeroData.AtAreaName(hero,0);
            lVar14 = new PlotChoiceRequirement(uVar4);
            if (lVar14 == null) goto LAB_1813e5276;
            uVar40 = ResourceData.GetDescribe(lVar14,0);
            uVar6 = String.Format("{0}在{1}辛勤劳作，为门派收获了{2}。",uVar6,uVar7,uVar40,0);
            HeroData.AddLog(hero,uVar6,0);
            iVar21 = *(int *)(hero + 132);
            lVar14 = FUN_18046c0a0(0);
            if (((lVar14 == null) || (*(int64 *)(lVar14 + 32) == 0)) ||
               (lVar14 = WorldData.Player(*(int64 *)(lVar14 + 32),0)) == null)
            goto LAB_1813e5276;
            if (iVar21 == *(int *)(lVar14 + 132)) {
              lVar14 = FUN_18046c2c0(0);
              uVar7 = new InfoData(1,uVar6);
              if (lVar14 == null) goto LAB_1813e5276;
              InfoController.AddInfo(lVar14,uVar7,0);
            }
            break;
          }
          goto switchD_1813de14e_caseD_0;
        case 8:
          dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
          fVar29 = (float)FUN_1801f8ab0();
          if (*(int64 *)(hero + 64) == 0) goto LAB_1813e5276;
          local_158 = Mathf.RoundToInt(((float)dVar30 + (float)dVar30 + 4.0) * fVar29 *
                                        (float)*(int *)(*(int64 *)(hero + 64) + 36),0);
          HeroData.ChangeMoney(hero,local_158,0,0);
          uVar6 = HeroData.Name(hero,1,0);
          uVar7 = HeroData.AtAreaName(hero,0);
          local_12c = local_158;
          uVar40 = il2cpp_value_box(DAT_181d80418,&local_12c);
          uVar6 = String.Format("{0}在{1}打工赚钱，获取了{2}两银钱。",uVar6,uVar7,uVar40,0);
          goto LAB_1813deb88;
        case 9:
          local_res10 = "";
          local_150 = "";
          fVar29 = 0.0;
          lVar14 = HeroData.GetArea(hero,0);
          uVar12 = uVar17;
          if (lVar14 != null) {
            lVar14 = HeroData.GetArea(hero,0);
            if (lVar14 == null) goto LAB_1813e5276;
            if (*(int *)(lVar14 + 72) == 2) {
              lVar14 = HeroData.GetArea(hero,0);
              if ((lVar14 == null) || (lVar14 = AreaData.GetForce(lVar14,0)) == null)
              goto LAB_1813e5276;
              uVar12 = *(uint64 *)(lVar14 + 160);
            }
          }
          iVar21 = 1;
          fVar28 = 0.75;
        LAB_1813dec60:
          lVar14 = *(int64 *)(hero + 0x220);
          if (lVar14 != null) {
            if (*(float *)(lVar14 + 28) / *(float *)(lVar14 + 32) <= 0.7) {
              GlobalData.RandomRange();
              cVar3 = AIController.CheckHeroItemNumBiggerThanMax(this,hero);
              if (cVar3) goto LAB_1813ded06;
              dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
              if (dVar30 < (double)fVar28) goto LAB_1813ded06;
        LAB_1813df224:
              cVar3 = HeroData.HaveForce(hero,0);
              if (!cVar3) {
        LAB_1813df24e:
                if (*(int64 *)(hero + 0x1f8) == 0) goto LAB_1813e5276;
                cVar3 = HeroEquipmentData.HaveEmptyEquipment(*(int64 *)(hero + 0x1f8),0);
                if (!cVar3) {
                  dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
                  uVar17 = local_150;
                  if (0.20000000298023224 <= dVar30) goto LAB_1813df70a;
                }
              }
              else {
                lVar14 = HeroData.GetForce(hero,0,0);
                if (lVar14 == null) goto LAB_1813e5276;
                if (*(int *)(lVar14 + 88) != 0) goto LAB_1813df24e;
              }
              uVar18 = 0;
              uVar17 = local_150;
              goto LAB_1813df2b0;
            }
        LAB_1813ded06:
            uVar4 = (uint32)(in_stack_fffffffffffffe78 >> 32);
            if (5 < (int)uVar17) goto LAB_1813df224;
            dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
            if (0.4000000059604645 < dVar30) {
              dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
              if (0.5 < dVar30) {
                iVar19 = 1;
              }
              else {
                iVar19 = Mathf.Clamp(*(int *)(hero + 184) + -1,1,3);
              }
            }
            else {
              iVar19 = 5;
            }
            in_stack_fffffffffffffe80 = 0;
            in_stack_fffffffffffffe78 = CONCAT44(uVar4,0xffffffff);
            lVar14 = HeroData.FindRandomItem
                               (hero,uVar17,iVar19 + (int)uVar17,0,in_stack_fffffffffffffe78,0);
            while (lVar14 == null) {
              if (5 < (int)uVar17) goto LAB_1813dec60;
              uVar18 = (int)uVar17 + 1;
              uVar17 = (uint64)uVar18;
              in_stack_fffffffffffffe80 = 0;
              in_stack_fffffffffffffe78 = CONCAT44((int)(in_stack_fffffffffffffe78 >> 32),0xffffffff);
              lVar14 = HeroData.FindRandomItem
                                 (hero,uVar17,uVar18 + iVar19,0,in_stack_fffffffffffffe78,0);
            }
            cVar3 = FUN_18171e540(uVar9,"",0);
            uVar20 = "/";
            if (cVar3) {
              uVar20 = "";
            }
            if (lVar14 == null) goto LAB_1813e5276;
            uVar6 = ItemData.Name(lVar14,1,0);
            uVar9 = String.Concat(uVar9,uVar20,uVar6);
            local_res10 = uVar9;
            if ((((uVar12 == 0) || (*(int *)(uVar12 + 20) != *(int *)(hero + 132))) ||
                (0.9 <= *(float *)(uVar12 + 28) / *(float *)(uVar12 + 32))) ||
               ((*(int *)(hero + 184) < 5 &&
                (fVar26 = *(float *)(hero + 0x1c0),
                iVar19 = HeroData.GetUpgradeForceLvNeedContribution(hero), (float)iVar19 <= fVar26))))
            {
              fVar29 = fVar29 + (float)*(int *)(lVar14 + 56);
              AIController.HeroSellItem(this);
              lVar14 = HeroData.GetArea(hero);
              if (lVar14 != null) {
                lVar14 = HeroData.GetArea(hero);
                if (lVar14 == null) goto LAB_1813e5276;
                if (*(int *)(lVar14 + 72) != 2) {
                  lVar14 = il2cpp_internal(DAT_181d90ce0);
                  FUN_18132faf0(lVar14);
                  iVar19 = 0;
                  while( true ) {
                    lVar8 = HeroData.GetArea(hero);
                    if ((lVar8 == null) || (*(int64 *)(lVar8 + 192) == 0)) goto LAB_1813e5276;
                    if (*(int *)(*(int64 *)(lVar8 + 192) + 24) <= iVar19) break;
                    lVar8 = HeroData.GetArea(hero,0);
                    if ((lVar8 == null) || (*(int64 *)(lVar8 + 192) == 0)) goto LAB_1813e5276;
                    lVar8 = FUN_180002f80();
                    if (lVar8 != null) {
                      lVar8 = HeroData.GetArea(hero,0);
                      if (((lVar8 == null) || (*(int64 *)(lVar8 + 192) == 0)) ||
                         (lVar8 = FUN_180002f80()) == null) goto LAB_1813e5276;
                      if (*(int64 *)(lVar8 + 40) != 0) {
                        lVar8 = HeroData.GetArea(hero,0);
                        if (((lVar8 == null) || (*(int64 *)(lVar8 + 192) == 0)) ||
                           ((lVar8 = FUN_180002f80(), lVar8 == null || (*(int64 *)(lVar8 + 40) == 0))))
                        goto LAB_1813e5276;
                        lVar8 = AreaBuildingData.DataBase();
                        if (lVar8 != null) {
                          lVar8 = HeroData.GetArea(hero,0);
                          if (((lVar8 == null) || (*(int64 *)(lVar8 + 192) == 0)) ||
                             ((lVar8 = FUN_180002f80(), lVar8 == null ||
                              ((*(int64 *)(lVar8 + 40) == 0 ||
                               (lVar8 = AreaBuildingData.DataBase()) == null))))) goto LAB_1813e5276;
                          if (*(int64 *)(lVar8 + 136) != 0) {
                            lVar8 = HeroData.GetArea(hero,0);
                            if ((((((lVar8 == null) || (*(int64 *)(lVar8 + 192) == 0)) ||
                                  (lVar8 = FUN_180002f80(*(int64 *)(lVar8 + 192),iVar19,DAT_181d7ca60)
                                  , lVar8 == null)) ||
                                 ((*(int64 *)(lVar8 + 40) == 0 ||
                                  (lVar8 = AreaBuildingData.DataBase(*(int64 *)(lVar8 + 40),0),
                                  lVar8 == null)))) || (*(int64 *)(lVar8 + 136) == 0)) ||
                               (*(int64 *)(*(int64 *)(lVar8 + 136) + 32) == 0))
                            goto LAB_1813e5276;
                            cVar3 = FUN_18182a3a0();
                            if (cVar3) {
                              lVar8 = HeroData.GetArea(hero,0);
                              if (((lVar8 == null) || (*(int64 *)(lVar8 + 192) == 0)) ||
                                 ((lVar8 = FUN_180002f80(*(int64 *)(lVar8 + 192),iVar19,DAT_181d7ca60)
                                  , lVar8 == null || (lVar14 == null)))) goto LAB_1813e5276;
                              FUN_18181e0a0(lVar14);
                            }
                          }
                        }
                      }
                    }
                    iVar19 = iVar19 + 1;
                  }
                  if (lVar14 == null) goto LAB_1813e5276;
                  iVar19 = *(int *)(lVar14 + 24);
                  if (0 < iVar19) {
                    uVar4 = GlobalData.RandomRange(0,iVar19,0);
                    lVar14 = FUN_180002f80(lVar14,uVar4);
                    if ((lVar14 == null) || (*(int64 *)(lVar14 + 40) == 0)) goto LAB_1813e5276;
                    ItemListData.GetItem();
                  }
                }
              }
              fVar28 = fVar28 * 0.75;
            }
            else {
              in_stack_fffffffffffffe78 = 0;
              AIController.HeroDonateItemToForceStorage(this,hero,lVar14,uVar12,0);
              fVar28 = fVar28 * 0.75;
            }
            goto LAB_1813dec60;
          }
          goto LAB_1813e5276;
        case 10:
          lVar8 = FUN_18046c0a0(0);
          lVar14 = *(int64 *)(hero + 64);
          if (lVar14 == null) goto LAB_1813e5276;
          Mathf.Min(lVar14,(float)*(int *)(lVar14 + 36) * 0.25,0);
          GlobalData.RandomRange();
          HeroData.GetHeroItemLv(hero,0,0);
          if (lVar8 == null) goto LAB_1813e5276;
          uVar6 = 0;
          lVar14 = hero;
          lVar8 = GameController.GenerateRandomItem(lVar8);
          HeroData.GetItem(hero,lVar8,0,0,lVar14,uVar6);
          uVar6 = HeroData.Name(hero,1,0);
          uVar7 = HeroData.AtAreaName(hero,0);
          if (lVar8 == null) goto LAB_1813e5276;
          uVar40 = ItemData.Name(lVar8,1,0);
          uVar6 = String.Format("{0}在{1}四下探索之时，意外发现了{2}。",uVar6,uVar7,uVar40,0);
          HeroData.AddLog(hero,uVar6,0);
          fVar29 = 0.75;
          break;
        case 11:
          lVar14 = FUN_18046c0a0(0);
          if (lVar14 == null) goto LAB_1813e5276;
          lVar14 = *(int64 *)(lVar14 + 32);
          if ((*(int64 *)(hero + 64) == 0) ||
             (uVar4 = Int32.Parse(*(uint64 *)(*(int64 *)(hero + 64) + 24),0), lVar14 == null))
          goto LAB_1813e5276;
          lVar14 = WorldData.GetHero(lVar14,uVar4,0);
          if (lVar14 == null) goto switchD_1813de14e_caseD_0;
          HeroData.ResetAI(lVar14,0);
          if (*(int64 *)(hero + 0x2b8) == 0) goto LAB_1813e5276;
          fVar29 = (float)HeroSpeAddData.Get(*(int64 *)(hero + 0x2b8),212,0);
          if (*(int64 *)(lVar14 + 0x2b8) == 0) goto LAB_1813e5276;
          fVar28 = (float)HeroSpeAddData.Get(*(int64 *)(lVar14 + 0x2b8),212,0);
          fVar26 = 1.0;
          fVar28 = fVar28 + fVar29 + 1.0;
          cVar3 = HeroData.HaveRelationBetterThanFriend(hero,*(uint32 *)(lVar14 + 88),0,1,0);
          if ((!cVar3) &&
             ((*(char *)(hero + 92) == false || (*(char *)(lVar14 + 92) == false)))) {
            dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
            fVar29 = (float)HeroData.GetStartFavor(hero,lVar14,0);
            if (dVar30 < (double)((fVar29 * 0.005 + 0.15) * fVar28)) {
              cVar3 = HeroData.HaveFriend(hero,*(uint32 *)(lVar14 + 88),0);
              if (!cVar3) {
                dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
                fVar29 = (float)HeroData.GetStartFavor(hero,lVar14,0);
                if (dVar30 < (double)((fVar29 * 0.005 + 0.1) * fVar28)) goto LAB_1813e0b60;
                AIController.AICheckRemoveFriend(this,hero,0);
                AIController.AICheckRemoveFriend(this,lVar14,0);
                HeroData.AddFriend(hero,*(uint32 *)(lVar14 + 88),0,0);
                uVar7 = HeroData.GetHeroName(hero,0,0);
                uVar40 = HeroData.AtAreaName(hero,0);
                uVar42 = HeroData.GetHeroName(lVar14,0,0);
                uVar6 = "{0}在{1}与{2}相谈甚欢，一见如故，结为知己好友。";
              }
              else {
        LAB_1813e0b60:
                AIController.AICheckRemoveBrother(this,hero,0);
                AIController.AICheckRemoveBrother(this,lVar14,0);
                HeroData.AddBrother(hero,*(uint32 *)(lVar14 + 88),0,0);
                uVar7 = HeroData.GetHeroName(hero,0,0);
                uVar40 = HeroData.AtAreaName(hero,0);
                uVar42 = HeroData.GetHeroName(lVar14,0,0);
                uVar6 = "{0}在{1}与{2}志同道合，相见恨晚，约定义结金兰。";
              }
              uVar6 = String.Format(uVar6,uVar7,uVar40,uVar42,0);
              HeroData.AddLog(hero,uVar6,0);
              HeroData.AddLog(lVar14,uVar6,0);
              fVar29 = 0.4;
              break;
            }
          }
          dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
          fVar29 = (float)HeroData.GetStartFavor(hero,lVar14,0);
          cVar3 = HeroData.HaveHater(hero,*(uint32 *)(lVar14 + 88),0);
          if (!cVar3) {
            fVar27 = 1.0;
          }
          else {
            fVar27 = 4.0;
          }
          cVar3 = HeroData.SameForce(hero,lVar14,0);
          if (!cVar3) {
            fVar24 = 1.0;
          }
          else {
            fVar24 = 0.5;
          }
          cVar3 = HeroData.HaveFriend(hero,*(uint32 *)(lVar14 + 88),0);
          if (!cVar3) {
            fVar37 = 1.0;
          }
          else {
            fVar37 = 0.5;
          }
          uVar6 = 0;
          cVar3 = HeroData.HaveRelationBetterThanFriend(hero,*(uint32 *)(lVar14 + 88),0,1,0);
          if (!cVar3) {
            fVar25 = 1.0;
          }
          else {
            fVar25 = 0.25;
          }
          if (dVar30 < (double)(fVar25 * (0.15 - fVar29 * 0.005) * (1.0 / fVar28) * fVar27 * fVar24 *
                                         fVar37)) {
            dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
            lVar8 = lVar14;
            lVar16 = hero;
            if ((double)(*(float *)(hero + 0x1d0) /
                        (*(float *)(hero + 0x1d0) + *(float *)(lVar14 + 0x1d0))) < dVar30) {
              lVar8 = hero;
              lVar16 = lVar14;
            }
            if (**(int **)(DAT_181d73d40 + 184) != 2) {
              dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
              fVar29 = (float)HeroData.GetFightScore(lVar16,1,0);
              fVar26 = (float)HeroData.GetFightScore(lVar16,1);
              fVar27 = (float)HeroData.GetFightScore(lVar8,1);
              bVar22 = dVar30 <= (double)(fVar29 / (fVar27 + fVar26));
              cVar3 = HeroData.IsPlayerSameForce(lVar16,0);
              if ((!cVar3) || (uVar7 = 3, *(int *)(lVar16 + 0x374) == 0)) {
                uVar7 = 4;
              }
              iVar21 = GlobalData.RandomRange(0,uVar7,0,0);
              if (iVar21 == 0) {
                if (bVar22) {
                  HeroData.ChangeBadFame(lVar16);
                  if (*(int64 *)(lVar16 + 0x168) == 0) goto LAB_1813e5276;
                  FUN_1800d6790(*(int64 *)(lVar16 + 0x168),1,DAT_181da1078);
                  if (*(int64 *)(lVar8 + 0x168) == 0) goto LAB_1813e5276;
                  FUN_1800d6790(*(int64 *)(lVar8 + 0x168),1,DAT_181da1078);
                  fVar29 = (float)FUN_1810e36c0();
                  uVar6 = 0;
                  HeroData.ChangePoisonInjury(lVar8);
                  HeroData.ChangeLivingSkillExp
                            (lVar16,1,((float)*(int *)(hero + 184) * 0.25 + 1.0) * fVar29 * 50.0,0,0,
                             uVar6);
                }
                else {
                  HeroData.ChangeBadFame(lVar16);
                }
                lVar15 = FUN_1800d60b0(DAT_181da4120,4);
                uVar6 = HeroData.GetHeroName(lVar16,0,0);
                if (lVar15 == null) goto LAB_1813e5276;
                FUN_180002070(lVar15,uVar6);
                FUN_180002fd0(lVar15,0,uVar6);
                uVar6 = HeroData.AtAreaName(lVar16,0);
                FUN_180002070(lVar15,uVar6);
                FUN_180002fd0(lVar15,1,uVar6);
                uVar6 = HeroData.GetHeroName(lVar8,0,0);
                FUN_180002070(lVar15,uVar6);
                FUN_180002fd0(lVar15,2,uVar6);
                uVar6 = "{0}在{1}下毒暗害{2}，{3}。";
                uVar7 = "最终未能得逞";
                if (bVar22) {
                  local_118 = Mathf.RoundToInt();
                  uVar7 = il2cpp_value_box(DAT_181d80418,&local_118);
                  uVar7 = String.Format("使其中毒加深{0}点",uVar7,0);
                }
                FUN_180002070(lVar15,uVar7);
                uVar40 = 3;
              }
              else if ((iVar21 == 1) || (iVar21 == 2)) {
                dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
                local_153 = dVar30 <= 0.5;
                lVar15 = 0;
                local_138 = 0;
                dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
                if (dVar30 <= 0.75) {
                  uVar5 = (uint32)((uint64)uVar6 >> 32);
                  dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
                  uVar4 = 999999;
                  if (0.05000000074505806 <= dVar30) {
                    uVar4 = *(uint32 *)(lVar16 + 184);
                  }
                  uVar6 = CONCAT44(uVar5,0xffffffff);
                  lVar15 = HeroData.FindRandomItem(lVar8,0xffffffff,uVar4,0,uVar6,0);
                  local_138 = lVar15;
                }
                if (*(int64 *)(lVar8 + 0x220) == 0) goto LAB_1813e5276;
                local_150 = CONCAT44(local_150._4_4_,*(uint32 *)(*(int64 *)(lVar8 + 0x220) + 24))
                ;
                fVar29 = (float)GlobalData.RandomRange();
                auVar33._0_8_ = FUN_1801f8ab0();
                auVar33._8_8_ = extraout_XMM0_Qb_00;
                auVar34._4_12_ = auVar33._4_12_;
                auVar34._0_4_ = (float)auVar33._0_8_ * fVar29 * 50.0;
                uVar4 = Mathf.RoundToInt(auVar34._0_8_,0);
                local_158 = Mathf.Min(local_150 & 0xffffffff,uVar4,0);
                uVar38 = (uint7)((uint64)uVar6 >> 8);
                if (bVar22) {
                  if (lVar15 == null) {
                    lVar13 = (uint64)uVar38 << 8;
                    HeroData.ChangeBadFame(lVar16);
                    HeroData.ChangeMoney(lVar8,-local_158,0,0,lVar13,lVar15);
                    HeroData.ChangeMoney(lVar16,local_158,0,0);
                  }
                  else {
                    uVar6 = 0;
                    lVar13 = (uint64)uVar38 << 8;
                    HeroData.ChangeBadFame(lVar16);
                    HeroData.LoseItem(lVar8,lVar15,0,0,lVar13,uVar6);
                    HeroData.GetItem(lVar16,lVar15,0,0);
                  }
                }
                else {
                  HeroData.ChangeBadFame(lVar16);
                }
                lVar15 = FUN_1800d60b0(DAT_181da4120,6);
                uVar6 = HeroData.GetHeroName(lVar16,0,0);
                if (lVar15 == null) goto LAB_1813e5276;
                FUN_180002070(lVar15,uVar6);
                FUN_180002fd0(lVar15,0,uVar6);
                uVar6 = HeroData.AtAreaName(lVar16,0);
                FUN_180002070(lVar15,uVar6);
                FUN_180002fd0(lVar15,1,uVar6);
                uVar6 = HeroData.GetHeroName(lVar8,0,0);
                FUN_180002070(lVar15,uVar6);
                FUN_180002fd0(lVar15,2,uVar6);
                uVar6 = "{0}在{1}欲{5}{2}的{3}，{4}。";
                if (local_138 == 0) {
                  local_11c = local_158;
                  uVar7 = il2cpp_value_box(DAT_181d80418,&local_11c);
                  uVar7 = String.Format("{0}银两",uVar7,0);
                }
                else {
                  uVar7 = ItemData.Name(local_138,1,0);
                }
                FUN_180002070(lVar15,uVar7);
                FUN_180002fd0(lVar15,3,uVar7);
                uVar7 = "最终未能得逞";
                if (bVar22) {
                  uVar7 = "最终成功得手";
                }
                FUN_180002070(lVar15,uVar7);
                FUN_180002fd0(lVar15,4,uVar7);
                uVar7 = "抢夺";
                if (local_153) {
                  uVar7 = "窃取";
                }
                FUN_180002070(lVar15,uVar7);
                uVar40 = 5;
              }
              else {
                if (iVar21 != 3) goto LAB_1813e19c6;
                dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
                uVar4 = 999999;
                if (0.05000000074505806 <= dVar30) {
                  uVar4 = *(uint32 *)(lVar16 + 184);
                }
                lVar15 = HeroData.FindRandomSkill(lVar8,uVar4,lVar16,0);
                local_138 = lVar15;
                if ((bVar22) && (lVar15 != null)) {
                  lVar13 = KungfuSkillLvData.DataBase(lVar15,0);
                  if (lVar13 == null) goto LAB_1813e5276;
                  uVar7 = 0;
                  HeroData.ChangeBadFame(lVar16);
                  uVar4 = *(uint32 *)(lVar15 + 16);
                  uVar6 = new KungfuSkillLvData(uVar4,0);
                  HeroData.GetSkill(lVar16,uVar6,0,0,0,uVar7);
                }
                else {
                  bVar22 = false;
                  HeroData.ChangeBadFame(lVar16);
                }
                lVar15 = FUN_1800d60b0(DAT_181da4120,5);
                uVar6 = HeroData.GetHeroName(lVar16,0,0);
                if (lVar15 == null) goto LAB_1813e5276;
                FUN_180002070(lVar15,uVar6);
                FUN_180002fd0(lVar15,0,uVar6);
                uVar6 = HeroData.AtAreaName(lVar16,0);
                FUN_180002070(lVar15,uVar6);
                FUN_180002fd0(lVar15,1,uVar6);
                uVar6 = HeroData.GetHeroName(lVar8,0,0);
                FUN_180002070(lVar15,uVar6);
                FUN_180002fd0(lVar15,2,uVar6);
                uVar6 = "{0}在{1}欲偷师{2}的{3}，{4}。";
                uVar7 = "武学";
                if (local_138 != 0) {
                  uVar7 = KungfuSkillLvData.Name(local_138,1,0);
                }
                FUN_180002070(lVar15,uVar7);
                FUN_180002fd0(lVar15,3,uVar7);
                uVar7 = "最终未能得逞";
                if (bVar22) {
                  uVar7 = "最终成功得手";
                }
                FUN_180002070(lVar15,uVar7);
                uVar40 = 4;
              }
              FUN_180002fd0(lVar15,uVar40,uVar7);
              uVar12 = String.Format(uVar6,lVar15,0);
            }
        LAB_1813e19c6:
            cVar3 = HeroData.HaveHater(hero,*(uint32 *)(lVar14 + 88),0);
            if ((!cVar3) &&
               ((*(char *)(hero + 92) == false || (*(char *)(lVar14 + 92) == false)))) {
              dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
              fVar29 = (float)HeroData.GetStartFavor(hero,lVar14,0);
              if (dVar30 < (double)((0.3 - fVar29 * 0.01) * (1.0 / fVar28))) {
                AIController.AICheckRemoveHater(this,hero,0);
                AIController.AICheckRemoveHater(this,lVar14,0);
                HeroData.AddHater(hero,*(uint32 *)(lVar14 + 88),0,0);
                if (**(int **)(DAT_181d73d40 + 184) == 2) {
                  uVar6 = HeroData.GetHeroName(hero,0);
                  uVar7 = HeroData.AtAreaName(hero,0);
                  uVar40 = HeroData.GetHeroName(lVar14,0,0);
                  uVar12 = String.Format("{0}在{1}与{2}心生嫌隙，结下了深仇大恨。",uVar6,uVar7,uVar40,0);
                }
                else {
                  uVar12 = String.Concat(uVar12,"两人因此结下了深仇大恨。",0);
                }
              }
            }
            HeroData.AddLog(lVar16,uVar12,0);
            HeroData.AddLog(lVar8,uVar12,0);
            lVar14 = FUN_18046c2c0(0);
            uVar6 = String.Format("传闻{0}",uVar12,0);
            uVar7 = new InfoData(3,uVar6);
            if (lVar14 == null) goto LAB_1813e5276;
            InfoController.AddInfo(lVar14,uVar7,0);
            fVar29 = 0.4;
          }
          else {
            uVar6 = HeroData.GetHeroName(hero,0,0);
            uVar7 = HeroData.AtAreaName(hero,0);
            uVar40 = HeroData.GetHeroName(lVar14,0,0);
            uVar6 = String.Format("{0}在{1}与{2}闲聊一阵。",uVar6,uVar7,uVar40,0);
            dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
            fVar29 = (float)HeroData.GetStartFavor(hero,lVar14,0);
            cVar3 = HeroData.HaveHater(hero,*(uint32 *)(lVar14 + 88),0);
            if (!cVar3) {
              fVar27 = 1.0;
            }
            else {
              fVar27 = 0.1;
            }
            cVar3 = HeroData.SameForce(hero,lVar14,0);
            if (!cVar3) {
              fVar24 = 1.0;
            }
            else {
              fVar24 = 1.25;
            }
            cVar3 = HeroData.HaveFriend(hero,*(uint32 *)(lVar14 + 88),0);
            if (!cVar3) {
              fVar37 = 1.0;
            }
            else {
              fVar37 = 1.5;
            }
            uVar4 = 0;
            cVar3 = HeroData.HaveRelationBetterThanFriend(hero,*(uint32 *)(lVar14 + 88),0,1,0);
            if (cVar3) {
              fVar26 = 2.0;
            }
            if (dVar30 < (double)(fVar26 * fVar37 * fVar24 * fVar28 * (fVar29 * 0.005 + 0.15) * fVar27)) {
              dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
              lVar8 = hero;
              lVar16 = lVar14;
              if (0.5 <= dVar30) {
                lVar8 = lVar14;
                lVar16 = hero;
              }
              dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
              if (dVar30 <= 0.75) {
                dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
                uVar5 = 999999;
                if (0.05000000074505806 <= dVar30) {
                  uVar5 = *(uint32 *)(lVar8 + 184);
                }
                uVar17 = HeroData.FindRandomItem(lVar8,0xffffffff,uVar5,0,CONCAT44(uVar4,0xffffffff),0);
              }
              if (*(int64 *)(lVar8 + 0x220) == 0) goto LAB_1813e5276;
              uVar4 = *(uint32 *)(*(int64 *)(lVar8 + 0x220) + 24);
              fVar29 = (float)GlobalData.RandomRange();
              auVar31._0_8_ = FUN_1801f8ab0();
              auVar31._8_8_ = extraout_XMM0_Qb;
              auVar32._4_12_ = auVar31._4_12_;
              auVar32._0_4_ = (float)auVar31._0_8_ * fVar29 * 50.0;
              uVar5 = Mathf.RoundToInt(auVar32._0_8_,0);
              local_158 = Mathf.Min(uVar4,uVar5,0);
              if (uVar17 == 0) {
                HeroData.ChangeMoney(lVar8,-local_158);
                HeroData.ChangeMoney(lVar16,local_158,0,0);
              }
              else {
                HeroData.LoseItem(lVar8,uVar17,0,0);
                HeroData.GetItem(lVar16,uVar17,0,0);
              }
              uVar40 = HeroData.Name(lVar8,1,0);
              uVar42 = HeroData.Name(lVar16,1,0);
              uVar7 = "二人相谈甚欢，离别之际{0}向{1}赠送了{2}。";
              if (uVar17 == 0) {
                local_120 = local_158;
                uVar11 = il2cpp_value_box(DAT_181d80418,&local_120);
                uVar11 = String.Format("{0}银两",uVar11,0);
              }
              else {
                uVar11 = ItemData.Name(uVar17,1,0);
              }
              uVar7 = String.Format(uVar7,uVar40,uVar42,uVar11,0);
              uVar6 = String.Concat(uVar6,uVar7,0);
            }
            HeroData.AddLog(hero,uVar6,0);
            HeroData.AddLog(lVar14,uVar6,0);
            fVar29 = 0.4;
          }
          break;
        case 12:
          lVar14 = FUN_18046c0a0(0);
          if (lVar14 == null) goto LAB_1813e5276;
          lVar14 = *(int64 *)(lVar14 + 32);
          if ((*(int64 *)(hero + 64) == 0) ||
             (uVar4 = Int32.Parse(*(uint64 *)(*(int64 *)(hero + 64) + 24),0), lVar14 == null))
          goto LAB_1813e5276;
          lVar14 = WorldData.GetHero(lVar14,uVar4,0);
          if (lVar14 == null) goto switchD_1813de14e_caseD_0;
          HeroData.ResetAI(lVar14,0);
          if (*(int64 *)(hero + 0x2b8) == 0) goto LAB_1813e5276;
          fVar29 = (float)HeroSpeAddData.Get(*(int64 *)(hero + 0x2b8),212,0);
          if (*(int64 *)(lVar14 + 0x2b8) == 0) goto LAB_1813e5276;
          fVar28 = (float)HeroSpeAddData.Get(*(int64 *)(lVar14 + 0x2b8),212,0);
          fVar28 = fVar28 + fVar29 + 1.0;
          uVar6 = new FightMatchCouple(hero,lVar14,0);
          iVar21 = GlobalData.ManageHeroAutoFight(uVar6,0);
          lVar8 = FUN_1800d60b0(DAT_181da4120,4);
          uVar6 = HeroData.GetHeroName(hero,0,0);
          if (lVar8 == null) goto LAB_1813e5276;
          FUN_180002070(lVar8,uVar6);
          FUN_180002fd0(lVar8,0,uVar6);
          uVar6 = HeroData.AtAreaName(hero,0);
          FUN_180002070(lVar8,uVar6);
          FUN_180002fd0(lVar8,1,uVar6);
          uVar6 = HeroData.GetHeroName(lVar14,0,0);
          FUN_180002070(lVar8,uVar6);
          FUN_180002fd0(lVar8,2,uVar6);
          uVar6 = "{0}在{1}与{2}切磋武艺，最终{3}技高一筹。";
          lVar16 = lVar14;
          if (iVar21 == 0) {
            lVar16 = hero;
          }
          uVar7 = HeroData.Name(lVar16,1,0);
          FUN_180002070(lVar8,uVar7);
          FUN_180002fd0(lVar8,3,uVar7);
          uVar17 = String.Format(uVar6,lVar8,0);
          local_150 = uVar17;
          cVar3 = HeroData.HaveRelationBetterThanFriend(hero,*(uint32 *)(lVar14 + 88),0,1,0);
          fVar29 = 0.15;
          if ((!cVar3) &&
             ((*(char *)(hero + 92) == false || (*(char *)(lVar14 + 92) == false)))) {
            dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
            fVar26 = (float)HeroData.GetStartFavor(hero,lVar14,0);
            if ((double)((fVar26 * 0.005 + 0.15) * fVar28) <= dVar30) goto LAB_1813e1f8e;
            cVar3 = HeroData.HaveFriend(hero,*(uint32 *)(lVar14 + 88),0);
            if (!cVar3) {
              dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
              fVar26 = (float)HeroData.GetStartFavor(hero,lVar14,0);
              if (dVar30 >= (double)((fVar26 * 0.005 + 0.1) * fVar28))
              {
                AIController.AICheckRemoveFriend(this,hero,0);
                AIController.AICheckRemoveFriend(this,lVar14,0);
                HeroData.AddFriend(hero,*(uint32 *)(lVar14 + 88),0,0);
                uVar6 = String.Concat(uVar17,"两人因此一见如故，结为知己好友。",0);
                HeroData.AddLog(hero,uVar6,0);
                HeroData.AddLog(lVar14,uVar6,0);
                }
                else {
              }
              AIController.AICheckRemoveBrother(this,hero,0);
              AIController.AICheckRemoveBrother(this,lVar14,0);
              HeroData.AddBrother(hero,*(uint32 *)(lVar14 + 88),0,0);
              uVar6 = String.Concat(uVar17,"两人深感相见恨晚，约定义结金兰。",0);
              HeroData.AddLog(hero,uVar6,0);
              HeroData.AddLog(lVar14,uVar6,0);
            }
          }
          else {
        LAB_1813e1f8e:
            dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
            fVar26 = (float)HeroData.GetStartFavor(hero,lVar14,0);
            cVar3 = HeroData.HaveHater(hero,*(uint32 *)(lVar14 + 88),0);
            if (!cVar3) {
              fVar27 = 1.0;
            }
            else {
              fVar27 = 0.1;
            }
            cVar3 = HeroData.SameForce(hero,lVar14,0);
            if (!cVar3) {
              fVar24 = 1.0;
            }
            else {
              fVar24 = 1.25;
            }
            cVar3 = HeroData.HaveFriend(hero,*(uint32 *)(lVar14 + 88),0);
            if (!cVar3) {
              fVar37 = 1.0;
            }
            else {
              fVar37 = 1.5;
            }
            cVar3 = HeroData.HaveRelationBetterThanFriend(hero,*(uint32 *)(lVar14 + 88),0,1,0);
            if (!cVar3) {
              fVar25 = 1.0;
            }
            else {
              fVar25 = 2.0;
            }
            if (dVar30 < (double)(fVar25 * fVar37 * (fVar26 * 0.005 + 0.15) * fVar28 * fVar27 * fVar24)) {
              lVar8 = il2cpp_internal(DAT_181d93cd0);
              FUN_18132faf0(lVar8,DAT_181d8f098);
              dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
              fVar26 = (float)HeroData.GetStartFavor(hero,lVar14,0);
              if (dVar30 < (double)((fVar26 * 0.005 + 0.15) * fVar28)) {
                dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
                lVar16 = hero;
                lVar15 = lVar14;
                if ((double)((float)(*(int *)(hero + 184) - *(int *)(lVar14 + 184)) * 0.08 + 0.5) <=
                    dVar30) {
                  lVar16 = lVar14;
                  lVar15 = hero;
                }
                cVar3 = HeroData.IsPlayerSameForce(lVar15,0);
                if ((!cVar3) || (*(int *)(lVar15 + 0x374) == 0)) {
                  uVar18 = 0;
                  if (lVar16 != null) {
                    while (lVar13 = *(int64 *)(lVar16 + 0x260)) != null {
                      if ((int)*(uint32 *)(lVar13 + 24) <= (int)uVar18) {
                        if (lVar8 != null) {
                          iVar19 = *(int *)(lVar8 + 24);
                          if (iVar19 < 1) goto LAB_1813e2494;
                          uVar4 = GlobalData.RandomRange(0,iVar19,0,0);
                          uVar4 = FUN_1800d6760(lVar8,uVar4,DAT_181d8fa18);
                          lVar8 = new KungfuSkillLvData(uVar4,0);
                          HeroData.GetSkill(lVar15,lVar8,0,0,0);
                          uVar6 = HeroData.Name(lVar16,1,0);
                          uVar7 = HeroData.Name(lVar15,1,0);
                          if (lVar8 != null) {
                            uVar40 = KungfuSkillLvData.Name(lVar8,1,0);
                            uVar6 = String.Format("二人颇为投缘，{0}向{1}传授了{2}的心法口诀。",uVar6,uVar7,uVar40,0);
                            uVar6 = String.Concat(local_150,uVar6,0);
                            HeroData.AddLog(hero,uVar6,0);
                            HeroData.AddLog(lVar14,uVar6,0);
                            lVar14 = FUN_18046c2c0(0);
                            uVar6 = String.Format("传闻{0}",uVar6,0);
                            uVar7 = new InfoData(3,uVar6,0);
                            if (lVar14 != null) {
                              InfoController.AddInfo(lVar14,uVar7,0);
                              goto LAB_1813e26e2;
                            }
                          }
                        }
                        break;
                      }
                      if (*(uint32 *)(lVar13 + 24) <= uVar18) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      if (lVar13[uVar18]
                          == 0) break;
                      lVar13 = HeroData.FindSkill(lVar15);
                      if (lVar13 == null) {
                        if (((*(int64 *)(lVar16 + 0x260) == 0) ||
                            (lVar13 = FUN_180002f80(*(int64 *)(lVar16 + 0x260),uVar18)) == null)
                           || (lVar13 = KungfuSkillLvData.DataBase(lVar13,0)) == null) break;
                        if ((*(int *)(lVar13 + 52) < 5) ||
                           (cVar3 = HeroData.HaveRelationBetterThanFriend
                                              (lVar16,*(uint32 *)(lVar15 + 88),0,1,0), cVar3
                           )) {
                          dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
                          if (((*(int64 *)(lVar16 + 0x260) == 0) ||
                              (lVar13 = FUN_180002f80()) == null) ||
                             (lVar13 = KungfuSkillLvData.DataBase(lVar13)) == null) break;
                          if (dVar30 < (double)(1.0 - (float)(*(int *)(lVar13 + 52) -
                                                             *(int *)(lVar15 + 184)) * 0.3)) {
                            if (((*(int64 *)(lVar16 + 0x260) == 0) ||
                                (lVar13 = FUN_180002f80(*(int64 *)(lVar16 + 0x260),uVar18,DAT_181d92590
                                                       ), lVar13 == null)) || (lVar8 == null)) break;
                            FUN_18182a0b0(lVar8);
                          }
                        }
                      }
                      uVar18 = uVar18 + 1;
                    }
                  }
                  goto LAB_1813e5276;
                }
              }
        LAB_1813e2494:
              dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
              lVar16 = hero;
              lVar15 = lVar14;
              if ((double)((float)(*(int *)(hero + 184) - *(int *)(lVar14 + 184)) * 0.1 + 0.5) <=
                  dVar30) {
                lVar16 = lVar14;
                lVar15 = hero;
              }
              iVar19 = 0;
              while (lVar13 = *(int64 *)(lVar15 + 0x260)) != null {
                if (*(int *)(lVar13 + 24) <= iVar19) {
                  if (lVar8 != null) {
                    iVar19 = *(int *)(lVar8 + 24);
                    uVar17 = local_150;
                    if (iVar19 < 1) goto LAB_1813e26c5;
                    uVar4 = GlobalData.RandomRange(0,iVar19,0,0);
                    uVar4 = FUN_1800d6760(lVar8,uVar4,DAT_181d8fa18);
                    lVar8 = FUN_180002f80(lVar13,uVar4,DAT_181d92590);
                    if ((((lVar8 != null) && (lVar13 = KungfuSkillLvData.DataBase(lVar8,0)) != null) &&
                        (lVar16 != null)) && (lVar13 = KungfuSkillLvData.DataBase(lVar8,0)) != null) {
                      Mathf.Max();
                      HeroData.AddSkillBookExp(lVar15);
                      HeroData.AddSkillFightExp(lVar15);
                      uVar6 = HeroData.Name(lVar16,1,0);
                      uVar7 = HeroData.Name(lVar15,1,0);
                      uVar40 = KungfuSkillLvData.Name(lVar8,1,0);
                      uVar6 = String.Format("二人颇为投缘，{0}指点了{1}一些{2}的运用法门。",uVar6,uVar7,uVar40,0);
                      uVar17 = String.Concat(local_150,uVar6,0);
                      goto LAB_1813e26c5;
                    }
                  }
                  break;
                }
                lVar13 = FUN_180002f80(lVar13,iVar19);
                if (lVar13 == null) break;
                if (*(int *)(lVar13 + 20) < 10) {
                  if (lVar8 == null) break;
                  FUN_18182a0b0(lVar8,iVar19);
                }
                iVar19 = iVar19 + 1;
              }
              goto LAB_1813e5276;
            }
        LAB_1813e26c5:
            HeroData.AddLog(hero,uVar17,0);
            HeroData.AddLog(lVar14,uVar17,0);
          }
        LAB_1813e26e2:
          if (iVar21 == 0) {
            fVar29 = 0.75;
          }
          goto LAB_1813e515f;
        case 13:
          lVar14 = FUN_18046c0a0(0);
          if (lVar14 == null) goto LAB_1813e5276;
          lVar14 = *(int64 *)(lVar14 + 32);
          if ((*(int64 *)(hero + 64) == 0) ||
             (uVar4 = Int32.Parse(*(uint64 *)(*(int64 *)(hero + 64) + 24),0), lVar14 == null))
          goto LAB_1813e5276;
          lVar14 = WorldData.GetHero(lVar14,uVar4,0);
          if (lVar14 == null) goto switchD_1813de14e_caseD_0;
          if (*(int64 *)(hero + 64) == 0) goto LAB_1813e5276;
          lVar8 = hero;
          lVar16 = lVar14;
          if (*(char *)(*(int64 *)(hero + 64) + 20) == false) {
            lVar8 = lVar14;
            lVar16 = hero;
          }
          local_138 = lVar8;
          HeroData.ResetAI(lVar14,0);
          if (*(int64 *)(hero + 0x2b8) == 0) goto LAB_1813e5276;
          fVar28 = (float)HeroSpeAddData.Get(*(int64 *)(hero + 0x2b8),212,0);
          if (*(int64 *)(lVar14 + 0x2b8) == 0) goto LAB_1813e5276;
          fVar26 = (float)HeroSpeAddData.Get(*(int64 *)(lVar14 + 0x2b8),212,0);
          fVar29 = 1.0;
          uVar6 = new FightMatchCouple(hero,lVar14,0);
          uVar4 = 0;
          iVar21 = GlobalData.ManageHeroAutoFight(uVar6,2);
          bVar22 = iVar21 == 0;
          lVar15 = FUN_1800d60b0(DAT_181da4120,4);
          uVar6 = HeroData.GetHeroName(lVar16,0,0);
          if (lVar15 == null) goto LAB_1813e5276;
          FUN_180002070(lVar15,uVar6);
          FUN_180002fd0(lVar15,0,uVar6);
          uVar6 = HeroData.AtAreaName(lVar16,0);
          FUN_180002070(lVar15,uVar6);
          FUN_180002fd0(lVar15,1,uVar6);
          uVar6 = HeroData.GetHeroName(lVar8,0,0);
          FUN_180002070(lVar15,uVar6);
          FUN_180002fd0(lVar15,2,uVar6);
          uVar6 = "{0}在{1}袭击了{2}，血战一场最终{3}取得胜利。";
          lVar8 = lVar14;
          if (bVar22) {
            lVar8 = hero;
          }
          uVar7 = HeroData.Name(lVar8,1,0);
          FUN_180002070(lVar15,uVar7);
          FUN_180002fd0(lVar15,3,uVar7);
          uVar6 = String.Format(uVar6,lVar15,0);
          if ((((*(char *)(hero + 0x3cc) == false) && (*(char *)(lVar14 + 0x3cc) == false)) &&
              (cVar3 = HeroData.HaveHater(hero,*(uint32 *)(lVar14 + 88),0), !cVar3)) &&
             ((*(char *)(hero + 92) == false || (*(char *)(lVar14 + 92) == false)))) {
            dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
            fVar27 = (float)HeroData.GetStartFavor(hero,lVar14,0);
            if ((double)((0.6 - fVar27 * 0.02) * (1.0 / (fVar26 + fVar28 + 1.0))) <= dVar30)
            goto LAB_1813e2a31;
            AIController.AICheckRemoveHater(this,hero,0);
            AIController.AICheckRemoveHater(this,lVar14,0);
            HeroData.AddHater(hero,*(uint32 *)(lVar14 + 88),0,0);
            uVar6 = String.Concat(uVar6,"两人因此结下了深仇大恨。",0);
          }
          else {
        LAB_1813e2a31:
            lVar8 = hero;
            lVar15 = lVar14;
            if (!bVar22) {
              lVar8 = lVar14;
              lVar15 = hero;
            }
            dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
            if (dVar30 < (double)(*(float *)(lVar8 + 0x1d4) * 0.005 + *(float *)(lVar8 + 0x1d0) * 0.005))
            {
              dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
              if (0.75 < dVar30) {
                lVar13 = 0;
              }
              else {
                dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
                uVar5 = 999999;
                if (0.05000000074505806 <= dVar30) {
                  uVar5 = *(uint32 *)(lVar8 + 184);
                }
                lVar13 = HeroData.FindRandomItem(lVar15,0xffffffff,uVar5,0,CONCAT44(uVar4,0xffffffff),0);
              }
              if (*(int64 *)(lVar15 + 0x220) == 0) goto LAB_1813e5276;
              local_150 = CONCAT44(local_150._4_4_,*(uint32 *)(*(int64 *)(lVar15 + 0x220) + 24));
              fVar28 = (float)GlobalData.RandomRange();
              auVar35._0_8_ = FUN_1801f8ab0();
              auVar35._8_8_ = extraout_XMM0_Qb_01;
              auVar36._4_12_ = auVar35._4_12_;
              auVar36._0_4_ = (float)auVar35._0_8_ * fVar28 * 50.0;
              uVar4 = Mathf.RoundToInt(auVar36._0_8_,0);
              local_158 = Mathf.Min(local_150 & 0xffffffff,uVar4,0);
              if (lVar13 == null) {
                HeroData.ChangeMoney(lVar15,-local_158);
                HeroData.ChangeMoney(lVar8,local_158,0,0);
              }
              else {
                HeroData.LoseItem(lVar15,lVar13,0,0);
                HeroData.GetItem(lVar8,lVar13,0,0);
              }
              HeroData.ChangeBadFame(lVar8);
              local_150 = HeroData.Name(lVar8,1,0);
              uVar40 = HeroData.Name(lVar15,1,0);
              uVar7 = "{0}乘机抢夺了{1}的{2}。";
              if (lVar13 == null) {
                local_114 = local_158;
                uVar42 = il2cpp_value_box(DAT_181d80418,&local_114);
                uVar42 = String.Format("{0}银两",uVar42,0);
              }
              else {
                uVar42 = ItemData.Name(lVar13,1,0);
              }
              uVar7 = String.Format(uVar7,local_150,uVar40,uVar42,0);
              uVar6 = String.Concat(uVar6,uVar7,0);
            }
          }
          if (bVar22) {
            HeroData.ChangeFame(hero);
            HeroData.ChangeFame(lVar14);
            AIController.HeroLoseFightOnBigMap(this,lVar14,0);
            if ((*(char *)(hero + 0x3cd) == false) &&
               (iVar21 = HeroData.GetBountyPirce(lVar14,0), 0 < iVar21)) {
              uVar4 = HeroData.GetBountyPirce(lVar14,0);
              HeroData.GetBounty(hero,uVar4,lVar14,0,0);
              AIController.NPCGoInPrison(this,lVar14,hero,0);
            }
          }
          else {
            HeroData.ChangeFame(hero);
            HeroData.ChangeFame(lVar14);
            AIController.HeroLoseFightOnBigMap(this,hero,0);
            local_154 = 1;
            if ((*(char *)(lVar14 + 0x3cd) == false) &&
               (iVar21 = HeroData.GetBountyPirce(hero,0), 0 < iVar21)) {
              uVar4 = HeroData.GetBountyPirce(hero,0);
              HeroData.GetBounty(lVar14,uVar4,hero,0,0);
              AIController.NPCGoInPrison(this,hero,lVar14,0);
              bVar2 = true;
            }
            fVar29 = 0.1;
          }
          iVar21 = HeroData.GetBountyPirce(local_138,0);
          if (iVar21 < 1) {
            HeroData.ChangeBadFame(lVar16);
          }
          HeroData.AddLog(hero,uVar6,0);
          HeroData.AddLog(lVar14,uVar6,0);
          lVar14 = FUN_18046c2c0(0);
          uVar6 = String.Format("传闻{0}",uVar6,0);
          uVar7 = new InfoData(3,uVar6);
          if (lVar14 == null) goto LAB_1813e5276;
          InfoController.AddInfo(lVar14,uVar7,0);
          goto LAB_1813e515f;
        case 14:
          GlobalData.RandomRangeDouble(0,0);
          local_144 = Mathf.RoundToInt();
          HeroData.ChangeFame(hero);
          dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
          fVar29 = (float)FUN_1801f8ab0();
          if (*(int64 *)(hero + 64) == 0) goto LAB_1813e5276;
          local_158 = Mathf.RoundToInt(((float)dVar30 + (float)dVar30 + 2.0) * fVar29 *
                                        (float)*(int *)(*(int64 *)(hero + 64) + 36),0);
          HeroData.ChangeMoney(hero,local_158,0,0);
          lVar8 = FUN_18046c0a0(0);
          lVar14 = *(int64 *)(hero + 64);
          if (lVar14 == null) goto LAB_1813e5276;
          Mathf.Min(lVar14,(float)*(int *)(lVar14 + 36) * 0.3,0);
          GlobalData.RandomRange();
          HeroData.GetHeroItemLv(hero,0,0);
          if (lVar8 == null) goto LAB_1813e5276;
          uVar6 = 0;
          lVar14 = hero;
          lVar8 = GameController.GenerateRandomItem(lVar8);
          HeroData.GetItem(hero,lVar8,0,0,lVar14,uVar6);
          lVar14 = FUN_1800d60b0(DAT_181da4120,5);
          uVar6 = HeroData.Name(hero,1,0);
          if (lVar14 == null) goto LAB_1813e5276;
          FUN_180002070(lVar14,uVar6);
          FUN_180002fd0(lVar14,0,uVar6);
          uVar6 = HeroData.AtAreaName(hero,0);
          FUN_180002070(lVar14,uVar6);
          FUN_180002fd0(lVar14,1,uVar6);
          uVar6 = Int32.ToString(&local_144,"+0;-0;+0",0);
          FUN_180002070(lVar14,uVar6);
          FUN_180002fd0(lVar14,2,uVar6);
          uVar6 = Int32.ToString(&local_158,"+0;-0;+0",0);
          FUN_180002070(lVar14,uVar6);
          FUN_180002fd0(lVar14,3,uVar6);
          if (lVar8 == null) goto LAB_1813e5276;
          uVar6 = ItemData.Name(lVar8,1,0);
          FUN_180002070(lVar14,uVar6);
          FUN_180002fd0(lVar14,4,uVar6);
          uVar6 = String.Format("{0}在{1}完成了重要委托，名望{2}，银两{3}，并获得了{4}。",lVar14,0);
        LAB_1813de7d8:
          HeroData.AddLog(hero,uVar6,0);
          fVar29 = 0.5;
          break;
        case 15:
          lVar14 = FUN_18046c0a0(0);
          if (lVar14 == null) goto LAB_1813e5276;
          iVar21 = GameController.RandomRareLvByBossLv(lVar14,(float)*(int *)(hero + 184) * 0.06,0,0)
          ;
          fVar29 = (float)GlobalData.RandomRange();
          GlobalData.RandomRangeDouble(0,0);
          local_144 = Mathf.RoundToInt();
          HeroData.ChangeFame(hero);
          dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
          fVar28 = (float)FUN_1801f8ab0();
          if (*(int64 *)(hero + 64) == 0) goto LAB_1813e5276;
          local_158 = Mathf.RoundToInt((float)dVar30 * 8.0 * (fVar29 + (float)iVar21 * 0.25) * fVar28 *
                                        (float)*(int *)(*(int64 *)(hero + 64) + 36),0);
          HeroData.ChangeMoney(hero,local_158,0,0);
          if (*(int64 *)(hero + 64) == 0) goto LAB_1813e5276;
          Mathf.Min();
          GlobalData.RandomRange();
          HeroData.GetHeroItemLv(hero,0,0);
          Mathf.Min();
          lVar14 = FUN_18046c0a0(0);
          if (lVar14 == null) goto LAB_1813e5276;
          uVar6 = 0;
          lVar8 = hero;
          lVar14 = GameController.GenerateRandomItem(lVar14);
          HeroData.GetItem(hero,lVar14,0,0,lVar8,uVar6);
          lVar8 = FUN_1800d60b0(DAT_181da4120,6);
          uVar6 = HeroData.Name(hero,1,0);
          if (lVar8 == null) goto LAB_1813e5276;
          FUN_180002070(lVar8,uVar6);
          FUN_180002fd0(lVar8,0,uVar6);
          uVar6 = HeroData.AtAreaName(hero,0);
          FUN_180002070(lVar8,uVar6);
          FUN_180002fd0(lVar8,1,uVar6);
          uVar6 = Int32.ToString(&local_144,"+0;-0;+0",0);
          FUN_180002070(lVar8,uVar6);
          FUN_180002fd0(lVar8,2,uVar6);
          uVar6 = Int32.ToString(&local_158,"+0;-0;+0",0);
          FUN_180002070(lVar8,uVar6);
          FUN_180002fd0(lVar8,3,uVar6);
          if (lVar14 == null) goto LAB_1813e5276;
          uVar6 = ItemData.Name(lVar14,1,0);
          FUN_180002070(lVar8,uVar6);
          FUN_180002fd0(lVar8,4,uVar6);
          lVar14 = *(int64 *)(pStatics + 0x4f8);
          if (lVar14 == null) goto LAB_1813e5276;
          uVar6 = FUN_180002f80(lVar14,iVar21,DAT_181da4358);
          uVar6 = GlobalData.GenerateRareLvColorText(uVar6,iVar21,0);
          FUN_180002070(lVar8,uVar6);
          FUN_180002fd0(lVar8,5,uVar6);
          uVar6 = String.Format("{0}在{1}遭逢{5}奇遇，名望{2}，银两{3}，并获得了{4}。",lVar8,0);
          HeroData.AddLog(hero,uVar6,0);
          fVar29 = 0.2;
          break;
        case 17:
          iVar21 = Mathf.Max(1,*(uint32 *)(lVar14 + 36),0);
          if (*(int64 *)(hero + 0x220) == 0) goto LAB_1813e5276;
          uVar4 = Mathf.FloorToInt((float)*(int *)(*(int64 *)(hero + 0x220) + 24) * 0.02,0);
          iVar21 = Mathf.Min(iVar21 * 4,uVar4,0);
          uVar4 = Mathf.RoundToInt((float)-iVar21 * 50.0,0);
          uVar6 = 0;
          in_stack_fffffffffffffe78 = in_stack_fffffffffffffe78 & 0xffffffffffffff00;
          HeroData.ChangeBadFame(hero);
          HeroData.ChangeMoney(hero,uVar4,0,0,in_stack_fffffffffffffe78,uVar6);
          lVar14 = FUN_1800d60b0(DAT_181da4120,4);
          uVar6 = HeroData.Name(hero,1,0);
          if (lVar14 == null) goto LAB_1813e5276;
          FUN_180002070(lVar14,uVar6);
          FUN_180002fd0(lVar14,0,uVar6);
          uVar6 = HeroData.AtAreaName(hero,0);
          FUN_180002070(lVar14,uVar6);
          FUN_180002fd0(lVar14,1,uVar6);
          local_110 = Mathf.Abs(-iVar21,0);
          uVar6 = il2cpp_value_box(DAT_181d80418,&local_110);
          FUN_180002070(lVar14,uVar6);
          FUN_180002fd0(lVar14,2,uVar6);
          local_10c = Mathf.Abs(uVar4,0);
          uVar6 = il2cpp_value_box(DAT_181d80418,&local_10c);
          FUN_180002070(lVar14,uVar6);
          FUN_180002fd0(lVar14,3,uVar6);
          uVar6 = String.Format("{0}在{1}上下打点，花费{3}银两降低了{2}点恶名。",lVar14,0);
        LAB_1813deb88:
          HeroData.AddLog(hero,uVar6,0);
          fVar29 = 0.1;
          break;
        case 18:
          uVar4 = Int32.Parse(*(uint64 *)(lVar14 + 24),0);
          uVar6 = new KungfuSkillLvData(uVar4,0);
          lVar14 = HeroData.GetSkill(hero,uVar6,0,0,0);
          uVar6 = HeroData.Name(hero,1,0);
          uVar7 = HeroData.AtAreaName(hero,0);
          if (lVar14 == null) goto LAB_1813e5276;
          uVar40 = KungfuSkillLvData.Name(lVar14,1,0);
          uVar6 = String.Format("{0}在{1}习得了新武功{2}。",uVar6,uVar7,uVar40,0);
          HeroData.AddLog(hero,uVar6,0);
          fVar29 = 1.5;
          break;
        case 19:
          lVar14 = FUN_18046c0a0(0);
          if (lVar14 == null) goto LAB_1813e5276;
          lVar14 = *(int64 *)(lVar14 + 32);
          if (((*(int64 *)(hero + 64) == 0) ||
              (uVar4 = Int32.Parse(*(uint64 *)(*(int64 *)(hero + 64) + 24),0), lVar14 == null)
              ) || (lVar14 = WorldData.GetArea(lVar14,uVar4,0), lVar8 == null)) goto LAB_1813e5276;
          plVar10 = (int64 *)(lVar8 + 16);
          *plVar10 = lVar14;
          il2cpp_internal(plVar10,lVar14);
          lVar14 = il2cpp_internal(DAT_181d93cd0);
          FUN_18132faf0(lVar14,DAT_181d8f098);
          if (lVar14 == null) goto LAB_1813e5276;
          FUN_18182a0b0(lVar14,0,DAT_181d8f218);
          FUN_18182a0b0(lVar14,1,DAT_181d8f218);
          FUN_18182a0b0(lVar14,2,DAT_181d8f218);
          FUN_18182a0b0(lVar14,3,DAT_181d8f218);
          uVar6 = new OnTooltipCB(lVar8,DAT_181d94d38,DAT_181dab3b8);
          List_1.Sort(lVar14,uVar6,DAT_181d8f818);
          uVar4 = FUN_1800d6760(lVar14,0,DAT_181d8fa18);
          lVar14 = *(int64 *)(pStatics + 0x610);
          if (lVar14 == null) goto LAB_1813e5276;
          uVar5 = FUN_1800d6760(lVar14,uVar4,DAT_181d93190);
          if (*(int64 *)(hero + 0x168) == 0) goto LAB_1813e5276;
          FUN_1800d6790(*(int64 *)(hero + 0x168),uVar5,DAT_181da1078);
          HeroData.GetLoyalWorkRate(hero,0);
          if (*(int64 *)(hero + 64) == 0) goto LAB_1813e5276;
          fVar29 = (float)Mathf.Max();
          if (*plVar10 == 0) goto LAB_1813e5276;
          AreaData.ChangeAreaState(*plVar10,uVar4);
          HeroData.ChangeLivingSkillExp
                    (hero,uVar5,((float)*(int *)(hero + 184) * 0.25 + 1.0) * fVar29 * 20.0,0,0);
          lVar14 = FUN_1800d60b0(DAT_181da4120,4);
          uVar6 = HeroData.Name(hero,1,0);
          if (lVar14 == null) goto LAB_1813e5276;
          FUN_180002070(lVar14,uVar6);
          FUN_180002fd0(lVar14,0,uVar6);
          if (*plVar10 == 0) goto LAB_1813e5276;
          uVar6 = AreaData.GetAreaName(*plVar10,0);
          FUN_180002070(lVar14,uVar6);
          FUN_180002fd0(lVar14,1,uVar6);
          lVar16 = *(int64 *)(pStatics + 0x608);
          if (lVar16 == null) goto LAB_1813e5276;
          uVar6 = FUN_180002f80(lVar16,uVar4,DAT_181da4358);
          FUN_180002070(lVar14,uVar6);
          FUN_180002fd0(lVar14,2,uVar6);
          local_140 = ABS(fVar29);
          uVar6 = Single.ToString(&local_140,"f0",0);
          FUN_180002070(lVar14,uVar6);
          FUN_180002fd0(lVar14,3,uVar6);
          uVar6 = "{0}在{1}加强管理，使该地{2}提升{3}点。";
          goto LAB_1813e3b58;
        case 20:
          lVar14 = FUN_18046c0a0(0);
          if (lVar14 == null) goto LAB_1813e5276;
          lVar14 = *(int64 *)(lVar14 + 32);
          if (((*(int64 *)(hero + 64) == 0) ||
              (uVar4 = Int32.Parse(*(uint64 *)(*(int64 *)(hero + 64) + 24),0), lVar14 == null)
              ) || (lVar14 = WorldData.GetArea(lVar14,uVar4,0), lVar8 == null)) goto LAB_1813e5276;
          plVar10 = (int64 *)(lVar8 + 16);
          *plVar10 = lVar14;
          il2cpp_internal(plVar10,lVar14);
          lVar14 = il2cpp_internal(DAT_181d93cd0);
          FUN_18132faf0(lVar14,DAT_181d8f098);
          if (lVar14 == null) goto LAB_1813e5276;
          FUN_18182a0b0(lVar14,0,DAT_181d8f218);
          FUN_18182a0b0(lVar14,1,DAT_181d8f218);
          FUN_18182a0b0(lVar14,2,DAT_181d8f218);
          FUN_18182a0b0(lVar14,3,DAT_181d8f218);
          uVar6 = new OnTooltipCB(lVar8,DAT_181d94db8,DAT_181dab3b8);
          List_1.Sort(lVar14,uVar6,DAT_181d8f818);
          uVar4 = FUN_1800d6760(lVar14,0,DAT_181d8fa18);
          lVar14 = *(int64 *)(pStatics + 0x618);
          if (lVar14 == null) goto LAB_1813e5276;
          uVar5 = FUN_1800d6760(lVar14,uVar4,DAT_181d93190);
          if (*(int64 *)(hero + 0x168) == 0) goto LAB_1813e5276;
          FUN_1800d6790(*(int64 *)(hero + 0x168),uVar5,DAT_181da1078);
          HeroData.GetLoyalWorkRate(hero,0);
          if (*(int64 *)(hero + 64) == 0) goto LAB_1813e5276;
          fVar29 = (float)Mathf.Max();
          if (*plVar10 == 0) goto LAB_1813e5276;
          AreaData.ChangeAreaState(*plVar10,uVar4);
          HeroData.ChangeLivingSkillExp
                    (hero,uVar5,((float)*(int *)(hero + 184) * 0.25 + 1.0) * -fVar29 * 20.0,0,0);
          lVar14 = FUN_1800d60b0(DAT_181da4120,4);
          uVar6 = HeroData.Name(hero,1,0);
          if (lVar14 == null) goto LAB_1813e5276;
          FUN_180002070(lVar14,uVar6);
          FUN_180002fd0(lVar14,0,uVar6);
          if (*plVar10 == 0) goto LAB_1813e5276;
          uVar6 = AreaData.GetAreaName(*plVar10,0);
          FUN_180002070(lVar14,uVar6);
          FUN_180002fd0(lVar14,1,uVar6);
          lVar16 = *(int64 *)(pStatics + 0x608);
          if (lVar16 == null) goto LAB_1813e5276;
          uVar6 = FUN_180002f80(lVar16,uVar4,DAT_181da4358);
          FUN_180002070(lVar14,uVar6);
          FUN_180002fd0(lVar14,2,uVar6);
          local_140 = ABS(-fVar29);
          uVar6 = Single.ToString(&local_140,"f0",0);
          FUN_180002070(lVar14,uVar6);
          FUN_180002fd0(lVar14,3,uVar6);
          uVar6 = "{0}在{1}暗中破坏，使该地{2}降低{3}点。";
        LAB_1813e3b58:
          uVar6 = String.Format(uVar6,lVar14,0);
          HeroData.AddLog(hero,uVar6,0);
          if (*(int64 *)(lVar8 + 16) == 0) {
        LAB_1813e5276:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          AreaData.AddLog(*(int64 *)(lVar8 + 16),uVar6,0);
          iVar21 = *(int *)(hero + 132);
          lVar14 = FUN_18046c0a0(0);
          if (((lVar14 == null) || (*(int64 *)(lVar14 + 32) == 0)) ||
             (lVar14 = WorldData.Player(*(int64 *)(lVar14 + 32),0)) == null)
          goto LAB_1813e5276;
          if (iVar21 == *(int *)(lVar14 + 132)) {
            lVar14 = FUN_18046c2c0(0);
            uVar7 = new InfoData(1,uVar6,0);
            if (lVar14 == null) goto LAB_1813e5276;
            InfoController.AddInfo(lVar14,uVar7,0);
          }
          fVar29 = 2.0;
          break;
        case 21:
          if (*(int64 *)(hero + 0x168) == 0) goto LAB_1813e5276;
          FUN_1800d6790(*(int64 *)(hero + 0x168),8,DAT_181da1078);
          uVar43 = (uint32)(in_stack_fffffffffffffe78 >> 32);
          lVar14 = *(int64 *)(hero + 0x220);
          lVar8 = il2cpp_internal(DAT_181d93cd0);
          FUN_18132faf0(lVar8,DAT_181d8f098);
          if ((lVar8 == null) || (FUN_18182a0b0(lVar8,3,DAT_181d8f218), lVar14 == null)) goto LAB_1813e5276;
          lVar14 = ItemListData.FindRandomItem
                             (lVar14,0,5,0,CONCAT44(uVar43,5),lVar8,CONCAT44(uVar4,0xffffffff),
                              CONCAT44(uVar5,0xbf800000),CONCAT44(uVar41,0xbf800000),0);
          uVar4 = (uint32)((uint64)lVar8 >> 32);
          HeroData.GetLoyalWorkRate(hero,0);
          if (lVar14 != null) {
            HeroData.LoseItem(hero,lVar14,0);
            ItemData.GetMaterialExtraCraftRate(lVar14,0);
          }
          lVar8 = FUN_18046c0a0(0);
          GlobalData.RandomRange();
          if (lVar8 == null) goto LAB_1813e5276;
          uVar42 = 0;
          uVar40 = 0;
          uVar7 = CONCAT44(uVar4,0xffffffff);
          uVar6 = 1;
          lVar16 = hero;
          lVar8 = GameController.GenerateRandomItem(lVar8,2);
          if (lVar8 == null) goto LAB_1813e5276;
          fVar28 = 2.0;
          fVar29 = (float)FUN_1801f8ab0();
          iVar21 = (int)(fVar29 * 25.0);
          lVar15 = HeroData.GetForce(hero,0,0);
          if (lVar15 == null) {
            HeroData.ChangeMoney(hero,-iVar21,0,0,uVar6,uVar7,lVar16,uVar40,uVar42);
            HeroData.GetItem(hero,lVar8,0);
            lVar16 = FUN_1800d60b0(DAT_181da4120,4);
            uVar6 = HeroData.Name(hero,1,0);
            if (lVar16 == null) goto LAB_1813e5276;
            FUN_180002070(lVar16,uVar6);
            FUN_180002fd0(lVar16,0,uVar6);
            uVar6 = ItemData.Name(lVar8,1,0);
            FUN_180002070(lVar16,uVar6);
            FUN_180002fd0(lVar16,1,uVar6);
            local_100 = iVar21;
            uVar6 = il2cpp_value_box(DAT_181d80418,&local_100);
            FUN_180002070(lVar16,uVar6);
            FUN_180002fd0(lVar16,2,uVar6);
            uVar6 = "{0}烹饪了{1}并放入行囊(消耗{2}银钱{3})";
          }
          else {
            lVar16 = HeroData.GetForce(hero,0,0);
            if (lVar16 == null) goto LAB_1813e5276;
            uVar7 = 0;
            uVar6 = 1;
            ForceData.ChangeResource(lVar16,1);
            lVar16 = HeroData.GetForce(hero,0,0);
            if ((lVar16 == null) || (*(int64 *)(lVar16 + 160) == 0)) goto LAB_1813e5276;
            fVar29 = *(float *)(*(int64 *)(lVar16 + 160) + 28);
            lVar16 = HeroData.GetForce(hero,0,0);
            if ((lVar16 == null) || (*(int64 *)(lVar16 + 160) == 0)) goto LAB_1813e5276;
            if (fVar29 < *(float *)(*(int64 *)(lVar16 + 160) + 32)) {
              lVar16 = HeroData.GetForce(hero,0,0);
              if ((lVar16 == null) || (*(int64 *)(lVar16 + 160) == 0)) goto LAB_1813e5276;
              ItemListData.GetItem(*(int64 *)(lVar16 + 160),lVar8,0,0,uVar6,uVar7);
              lVar16 = FUN_1800d60b0(DAT_181da4120,4);
              uVar6 = HeroData.Name(hero,1,0);
              if (lVar16 == null) goto LAB_1813e5276;
              FUN_180002070(lVar16,uVar6);
              FUN_180002fd0(lVar16,0,uVar6);
              uVar6 = ItemData.Name(lVar8,1,0);
              FUN_180002070(lVar16,uVar6);
              FUN_180002fd0(lVar16,1,uVar6);
              local_104 = iVar21;
              uVar6 = il2cpp_value_box(DAT_181d80418,&local_104);
              FUN_180002070(lVar16,uVar6);
              FUN_180002fd0(lVar16,2,uVar6);
              uVar6 = "{0}烹饪了{1}并放入门派仓库(消耗{2}粮食{3})";
            }
            else {
              HeroData.GetItem(hero,lVar8,0);
              lVar16 = FUN_1800d60b0(DAT_181da4120,4);
              uVar6 = HeroData.Name(hero,1,0);
              if (lVar16 == null) goto LAB_1813e5276;
              FUN_180002070(lVar16,uVar6);
              FUN_180002fd0(lVar16,0,uVar6);
              uVar6 = ItemData.Name(lVar8,1,0);
              FUN_180002070(lVar16,uVar6);
              FUN_180002fd0(lVar16,1,uVar6);
              local_108 = iVar21;
              uVar6 = il2cpp_value_box(DAT_181d80418,&local_108);
              FUN_180002070(lVar16,uVar6);
              FUN_180002fd0(lVar16,2,uVar6);
              uVar6 = "{0}烹饪了{1}，由于门派仓库已满只得放入行囊(消耗{2}粮食{3})";
            }
          }
          uVar17 = "";
          if (lVar14 != null) {
            uVar7 = ItemData.Name(lVar14,1,0);
            uVar17 = String.Format("和{0}",uVar7,0);
          }
          FUN_180002070(lVar16,uVar17);
          FUN_180002fd0(lVar16,3,uVar17);
          uVar6 = String.Format(uVar6,lVar16,0);
          HeroData.AddLog(hero,uVar6,0);
          cVar3 = HeroData.IsPlayerSameForce(hero,0);
          if (cVar3) {
            lVar16 = FUN_18046c2c0(0);
            uVar7 = new InfoData(1,uVar6);
            if (lVar16 == null) goto LAB_1813e5276;
            InfoController.AddInfo(lVar16,uVar7,0);
          }
          iVar21 = *(int *)(lVar8 + 56);
          if (lVar14 == null) {
            fVar28 = 1.0;
          }
          uVar6 = 8;
          goto LAB_1813e453b;
        case 22:
          if (*(int64 *)(hero + 0x168) == 0) goto LAB_1813e5276;
          FUN_1800d6790(*(int64 *)(hero + 0x168),7,DAT_181da1078);
          uVar43 = (uint32)(in_stack_fffffffffffffe78 >> 32);
          lVar14 = *(int64 *)(hero + 0x220);
          lVar8 = il2cpp_internal(DAT_181d93cd0);
          FUN_18132faf0(lVar8,DAT_181d8f098);
          if ((lVar8 == null) || (FUN_18182a0b0(lVar8,2,DAT_181d8f218), lVar14 == null)) goto LAB_1813e5276;
          lVar14 = ItemListData.FindRandomItem
                             (lVar14,0,5,0,CONCAT44(uVar43,5),lVar8,CONCAT44(uVar4,0xffffffff),
                              CONCAT44(uVar5,0xbf800000),CONCAT44(uVar41,0xbf800000),0);
          uVar4 = (uint32)((uint64)lVar8 >> 32);
          HeroData.GetLoyalWorkRate(hero,0);
          if (lVar14 != null) {
            HeroData.LoseItem(hero,lVar14,0);
            ItemData.GetMaterialExtraCraftRate(lVar14,0);
          }
          lVar8 = FUN_18046c0a0(0);
          GlobalData.RandomRange();
          if (lVar8 == null) goto LAB_1813e5276;
          uVar42 = 0;
          uVar40 = 0;
          uVar7 = CONCAT44(uVar4,0xffffffff);
          uVar6 = 1;
          lVar16 = hero;
          lVar8 = GameController.GenerateRandomItem(lVar8,1);
          if (lVar8 == null) goto LAB_1813e5276;
          fVar28 = 2.0;
          fVar29 = (float)FUN_1801f8ab0();
          iVar21 = (int)(fVar29 * 25.0);
          lVar15 = HeroData.GetForce(hero,0,0);
          if (lVar15 == null) {
            HeroData.ChangeMoney(hero,-iVar21,0,0,uVar6,uVar7,lVar16,uVar40,uVar42);
            HeroData.GetItem(hero,lVar8,0);
            lVar16 = FUN_1800d60b0(DAT_181da4120,4);
            uVar6 = HeroData.Name(hero,1,0);
            if (lVar16 == null) goto LAB_1813e5276;
            FUN_180002070(lVar16,uVar6);
            FUN_180002fd0(lVar16,0,uVar6);
            uVar6 = ItemData.Name(lVar8,1,0);
            FUN_180002070(lVar16,uVar6);
            FUN_180002fd0(lVar16,1,uVar6);
            local_f4 = iVar21;
            uVar6 = il2cpp_value_box(DAT_181d80418,&local_f4);
            FUN_180002070(lVar16,uVar6);
            FUN_180002fd0(lVar16,2,uVar6);
            uVar6 = "{0}炼制了{1}并放入行囊(消耗{2}银钱{3})";
          }
          else {
            lVar16 = HeroData.GetForce(hero,0,0);
            if (lVar16 == null) goto LAB_1813e5276;
            uVar7 = 0;
            uVar6 = 1;
            ForceData.ChangeResource(lVar16,4);
            lVar16 = HeroData.GetForce(hero,0,0);
            if ((lVar16 == null) || (*(int64 *)(lVar16 + 160) == 0)) goto LAB_1813e5276;
            fVar29 = *(float *)(*(int64 *)(lVar16 + 160) + 28);
            lVar16 = HeroData.GetForce(hero,0,0);
            if ((lVar16 == null) || (*(int64 *)(lVar16 + 160) == 0)) goto LAB_1813e5276;
            if (fVar29 < *(float *)(*(int64 *)(lVar16 + 160) + 32)) {
              lVar16 = HeroData.GetForce(hero,0,0);
              if ((lVar16 == null) || (*(int64 *)(lVar16 + 160) == 0)) goto LAB_1813e5276;
              ItemListData.GetItem(*(int64 *)(lVar16 + 160),lVar8,0,0,uVar6,uVar7);
              lVar16 = FUN_1800d60b0(DAT_181da4120,4);
              uVar6 = HeroData.Name(hero,1,0);
              if (lVar16 == null) goto LAB_1813e5276;
              FUN_180002070(lVar16,uVar6);
              FUN_180002fd0(lVar16,0,uVar6);
              uVar6 = ItemData.Name(lVar8,1,0);
              FUN_180002070(lVar16,uVar6);
              FUN_180002fd0(lVar16,1,uVar6);
              local_f8 = iVar21;
              uVar6 = il2cpp_value_box(DAT_181d80418,&local_f8);
              FUN_180002070(lVar16,uVar6);
              FUN_180002fd0(lVar16,2,uVar6);
              uVar6 = "{0}炼制了{1}并放入门派仓库(消耗{2}药材{3})";
            }
            else {
              HeroData.GetItem(hero,lVar8,0);
              lVar16 = FUN_1800d60b0(DAT_181da4120,4);
              uVar6 = HeroData.Name(hero,1,0);
              if (lVar16 == null) goto LAB_1813e5276;
              FUN_180002070(lVar16,uVar6);
              FUN_180002fd0(lVar16,0,uVar6);
              uVar6 = ItemData.Name(lVar8,1,0);
              FUN_180002070(lVar16,uVar6);
              FUN_180002fd0(lVar16,1,uVar6);
              local_fc = iVar21;
              uVar6 = il2cpp_value_box(DAT_181d80418,&local_fc);
              FUN_180002070(lVar16,uVar6);
              FUN_180002fd0(lVar16,2,uVar6);
              uVar6 = "{0}炼制了{1}，由于门派仓库已满只得放入行囊(消耗{2}药材{3})";
            }
          }
          uVar17 = "";
          if (lVar14 != null) {
            uVar7 = ItemData.Name(lVar14,1,0);
            uVar17 = String.Format("和{0}",uVar7,0);
          }
          FUN_180002070(lVar16,uVar17);
          FUN_180002fd0(lVar16,3,uVar17);
          uVar6 = String.Format(uVar6,lVar16,0);
          HeroData.AddLog(hero,uVar6,0);
          cVar3 = HeroData.IsPlayerSameForce(hero,0);
          if (cVar3) {
            lVar16 = FUN_18046c2c0(0);
            uVar7 = new InfoData(1,uVar6);
            if (lVar16 == null) goto LAB_1813e5276;
            InfoController.AddInfo(lVar16,uVar7,0);
          }
          iVar21 = *(int *)(lVar8 + 56);
          if (lVar14 == null) {
            fVar28 = 1.0;
          }
          uVar6 = 7;
        LAB_1813e453b:
          HeroData.ChangeLivingSkillExp(hero,uVar6,((float)iVar21 + (float)iVar21) * fVar28,0,0);
          fVar29 = (float)*(int *)(lVar8 + 60) * 0.5 + 0.5;
          goto LAB_1813e515f;
        case 23:
          if (*(int64 *)(hero + 0x168) == 0) goto LAB_1813e5276;
          FUN_1800d6790(*(int64 *)(hero + 0x168),6,DAT_181da1078);
          uVar43 = (uint32)(in_stack_fffffffffffffe78 >> 32);
          lVar14 = *(int64 *)(hero + 0x220);
          lVar8 = il2cpp_internal(DAT_181d93cd0);
          FUN_18132faf0(lVar8,DAT_181d8f098);
          if (lVar8 == null) goto LAB_1813e5276;
          FUN_18182a0b0(lVar8,0,DAT_181d8f218);
          FUN_18182a0b0(lVar8,1,DAT_181d8f218);
          if (lVar14 == null) goto LAB_1813e5276;
          uVar6 = CONCAT44(uVar43,5);
          lVar14 = ItemListData.FindRandomItem
                             (lVar14,0,5,0,uVar6,lVar8,CONCAT44(uVar4,0xffffffff),
                              CONCAT44(uVar5,0xbf800000),CONCAT44(uVar41,0xbf800000),0);
          uVar4 = (uint32)((uint64)lVar8 >> 32);
          HeroData.GetLoyalWorkRate(hero,0);
          if (lVar14 != null) {
            HeroData.LoseItem(hero,lVar14,0,0);
            ItemData.GetMaterialExtraCraftRate(lVar14,0);
          }
          lVar8 = FUN_18046c0a0(0);
          GlobalData.RandomRange();
          if (lVar8 == null) goto LAB_1813e5276;
          uVar42 = 0;
          uVar40 = 0;
          uVar7 = CONCAT44(uVar4,0xffffffff);
          uVar6 = CONCAT71((int7)((uint64)uVar6 >> 8),1);
          lVar16 = hero;
          lVar8 = GameController.GenerateRandomItem(lVar8,0);
          if (lVar8 == null) goto LAB_1813e5276;
          fVar29 = (float)FUN_1801f8ab0();
          iVar21 = (int)(fVar29 * 25.0);
          lVar15 = HeroData.GetForce(hero,0,0);
          if (lVar15 == null) {
            HeroData.ChangeMoney(hero,iVar21 * -2,0,0,uVar6,uVar7,lVar16,uVar40,uVar42);
            HeroData.GetItem(hero,lVar8,0,0);
            lVar16 = FUN_1800d60b0(DAT_181da4120,4);
            uVar6 = HeroData.Name(hero,1,0);
            if (lVar16 == null) goto LAB_1813e5276;
            FUN_180002070(lVar16,uVar6);
            FUN_180002fd0(lVar16,0,uVar6);
            uVar6 = ItemData.Name(lVar8,1,0);
            FUN_180002070(lVar16,uVar6);
            FUN_180002fd0(lVar16,1,uVar6);
            local_e8[0] = iVar21;
            uVar6 = il2cpp_value_box(DAT_181d80418,local_e8);
            FUN_180002070(lVar16,uVar6);
            FUN_180002fd0(lVar16,2,uVar6);
            uVar6 = "{0}制造了{1}并放入行囊(消耗{2}银钱{3})";
          }
          else {
            lVar16 = HeroData.GetForce(hero,0,0);
            if (lVar16 == null) goto LAB_1813e5276;
            uVar39 = (undefined7)((uint64)uVar6 >> 8);
            ForceData.ChangeResource(lVar16,2);
            lVar16 = HeroData.GetForce(hero,0,0);
            if (lVar16 == null) goto LAB_1813e5276;
            uVar7 = 0;
            uVar6 = CONCAT71(uVar39,1);
            ForceData.ChangeResource(lVar16,3);
            lVar16 = HeroData.GetForce(hero,0,0);
            if ((lVar16 == null) || (*(int64 *)(lVar16 + 160) == 0)) goto LAB_1813e5276;
            fVar29 = *(float *)(*(int64 *)(lVar16 + 160) + 28);
            lVar16 = HeroData.GetForce(hero,0,0);
            if ((lVar16 == null) || (*(int64 *)(lVar16 + 160) == 0)) goto LAB_1813e5276;
            if (fVar29 < *(float *)(*(int64 *)(lVar16 + 160) + 32)) {
              lVar16 = HeroData.GetForce(hero,0,0);
              if ((lVar16 == null) || (*(int64 *)(lVar16 + 160) == 0)) goto LAB_1813e5276;
              ItemListData.GetItem(*(int64 *)(lVar16 + 160),lVar8,0,0,uVar6,uVar7);
              lVar16 = FUN_1800d60b0(DAT_181da4120,4);
              uVar6 = HeroData.Name(hero,1,0);
              if (lVar16 == null) goto LAB_1813e5276;
              FUN_180002070(lVar16,uVar6);
              FUN_180002fd0(lVar16,0,uVar6);
              uVar6 = ItemData.Name(lVar8,1,0);
              FUN_180002070(lVar16,uVar6);
              FUN_180002fd0(lVar16,1,uVar6);
              local_ec = iVar21;
              uVar6 = il2cpp_value_box(DAT_181d80418,&local_ec);
              FUN_180002070(lVar16,uVar6);
              FUN_180002fd0(lVar16,2,uVar6);
              uVar6 = "{0}制造了{1}并放入门派仓库(消耗{2}木料矿石{3})";
            }
            else {
              HeroData.GetItem(hero,lVar8,0,0);
              lVar16 = FUN_1800d60b0(DAT_181da4120,4);
              uVar6 = HeroData.Name(hero,1,0);
              if (lVar16 == null) goto LAB_1813e5276;
              FUN_180002070(lVar16,uVar6);
              FUN_180002fd0(lVar16,0,uVar6);
              uVar6 = ItemData.Name(lVar8,1,0);
              FUN_180002070(lVar16,uVar6);
              FUN_180002fd0(lVar16,1,uVar6);
              local_f0 = iVar21;
              uVar6 = il2cpp_value_box(DAT_181d80418,&local_f0);
              FUN_180002070(lVar16,uVar6);
              FUN_180002fd0(lVar16,2,uVar6);
              uVar6 = "{0}制造了{1}，由于门派仓库已满只得放入行囊(消耗{2}木料矿石{3})";
            }
          }
          uVar17 = "";
          if (lVar14 != null) {
            uVar7 = ItemData.Name(lVar14,1,0);
            uVar17 = String.Format("和{0}",uVar7,0);
          }
          FUN_180002070(lVar16,uVar17);
          FUN_180002fd0(lVar16,3,uVar17);
          uVar6 = String.Format(uVar6,lVar16,0);
          HeroData.AddLog(hero,uVar6,0);
          cVar3 = HeroData.IsPlayerSameForce(hero,0);
          if (cVar3) {
            lVar14 = FUN_18046c2c0(0);
            uVar7 = new InfoData(1,uVar6,0);
            if (lVar14 == null) goto LAB_1813e5276;
            InfoController.AddInfo(lVar14,uVar7,0);
          }
          HeroData.ChangeLivingSkillExp(hero,6);
          fVar29 = (float)*(int *)(lVar8 + 60) + 1.0;
        LAB_1813e515f:
          if (0.0 < fVar29) break;
          goto LAB_1813e51d8;
        }
        cVar3 = HeroData.HaveForce(hero,0);
        if (cVar3) {
          dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
          HeroData.ChangeForceContribution
                    (hero,((float)dVar30 * 4.0 + 4.0 + (float)*(int *)(hero + 184)) * fVar29,0,
                     0xffffffff,0);
        }
        LAB_1813e51d8:
        if (!bVar2) {
        switchD_1813de14e_caseD_0:
          HeroData.ResetAI(hero,0);
        }
        return local_154;
        LAB_1813df2b0:
        uVar4 = (uint32)((uint64)in_stack_fffffffffffffe80 >> 32);
        if ((*(int64 *)(hero + 0x1f8) == 0) ||
           (lVar14 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 32)) == null)
        goto LAB_1813e5276;
        if ((int)*(uint32 *)(lVar14 + 24) <= (int)uVar18) {
          uVar18 = 0;
          goto LAB_1813df390;
        }
        if (*(uint32 *)(lVar14 + 24) <= uVar18) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        uVar6 = lVar14[uVar18];
        uVar5 = HeroData.GetPreferWeaponType(hero,0);
        in_stack_fffffffffffffe88 = 0;
        in_stack_fffffffffffffe80 = CONCAT44(uVar4,uVar5);
        in_stack_fffffffffffffe78 = in_stack_fffffffffffffe78 & 0xffffffff00000000;
        lVar14 = AIController.HeroManageEquipmentTrade
                           (this,hero,uVar12,uVar6,in_stack_fffffffffffffe78,
                            in_stack_fffffffffffffe80,0);
        if (lVar14 != null) {
          FUN_18171e540(uVar17,"",0);
          ItemData.Name(lVar14,1,0);
          uVar17 = String.Concat(uVar17);
          fVar29 = fVar29 + (float)*(int *)(lVar14 + 56);
        }
        uVar18 = uVar18 + 1;
        goto LAB_1813df2b0;
        LAB_1813df390:
        uVar4 = (uint32)(in_stack_fffffffffffffe78 >> 32);
        uVar5 = (uint32)((uint64)in_stack_fffffffffffffe80 >> 32);
        if ((*(int64 *)(hero + 0x1f8) == 0) ||
           (lVar14 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 56)) == null)
        goto LAB_1813e5276;
        if ((int)*(uint32 *)(lVar14 + 24) <= (int)uVar18) {
          uVar18 = 0;
          goto LAB_1813df470;
        }
        if (*(uint32 *)(lVar14 + 24) <= uVar18) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        in_stack_fffffffffffffe88 = 0;
        in_stack_fffffffffffffe80 = CONCAT44(uVar5,0xffffffff);
        in_stack_fffffffffffffe78 = CONCAT44(uVar4,1);
        lVar14 = AIController.HeroManageEquipmentTrade
                           (this,hero,uVar12,
                            *(uint64 *)
                             (*(int64 *)(lVar14 + 16) + 32 + (int64)(int)uVar18 * 8),
                            in_stack_fffffffffffffe78,in_stack_fffffffffffffe80,0);
        if (lVar14 != null) {
          FUN_18171e540(uVar17,"",0);
          ItemData.Name(lVar14,1,0);
          uVar17 = String.Concat(uVar17);
          fVar29 = fVar29 + (float)*(int *)(lVar14 + 56);
        }
        uVar18 = uVar18 + 1;
        goto LAB_1813df390;
        LAB_1813df470:
        uVar4 = (uint32)(in_stack_fffffffffffffe78 >> 32);
        uVar5 = (uint32)((uint64)in_stack_fffffffffffffe80 >> 32);
        if ((*(int64 *)(hero + 0x1f8) == 0) ||
           (lVar14 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 80)) == null)
        goto LAB_1813e5276;
        if ((int)*(uint32 *)(lVar14 + 24) <= (int)uVar18) {
          uVar18 = 0;
          goto LAB_1813df550;
        }
        if (*(uint32 *)(lVar14 + 24) <= uVar18) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        in_stack_fffffffffffffe88 = 0;
        in_stack_fffffffffffffe80 = CONCAT44(uVar5,0xffffffff);
        in_stack_fffffffffffffe78 = CONCAT44(uVar4,2);
        lVar14 = AIController.HeroManageEquipmentTrade
                           (this,hero,uVar12,
                            *(uint64 *)
                             (*(int64 *)(lVar14 + 16) + 32 + (int64)(int)uVar18 * 8),
                            in_stack_fffffffffffffe78,in_stack_fffffffffffffe80,0);
        if (lVar14 != null) {
          FUN_18171e540(uVar17,"",0);
          ItemData.Name(lVar14,1,0);
          uVar17 = String.Concat(uVar17);
          fVar29 = fVar29 + (float)*(int *)(lVar14 + 56);
        }
        uVar18 = uVar18 + 1;
        goto LAB_1813df470;
        LAB_1813df550:
        uVar4 = (uint32)(in_stack_fffffffffffffe78 >> 32);
        uVar5 = (uint32)((uint64)in_stack_fffffffffffffe80 >> 32);
        if ((*(int64 *)(hero + 0x1f8) == 0) ||
           (lVar14 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 104)) == null)
        goto LAB_1813e5276;
        if ((int)*(uint32 *)(lVar14 + 24) <= (int)uVar18) {
          uVar18 = 0;
          goto LAB_1813df630;
        }
        if (*(uint32 *)(lVar14 + 24) <= uVar18) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        in_stack_fffffffffffffe88 = 0;
        in_stack_fffffffffffffe80 = CONCAT44(uVar5,0xffffffff);
        in_stack_fffffffffffffe78 = CONCAT44(uVar4,3);
        lVar14 = AIController.HeroManageEquipmentTrade
                           (this,hero,uVar12,
                            *(uint64 *)
                             (*(int64 *)(lVar14 + 16) + 32 + (int64)(int)uVar18 * 8),
                            in_stack_fffffffffffffe78,in_stack_fffffffffffffe80,0);
        if (lVar14 != null) {
          FUN_18171e540(uVar17,"",0);
          ItemData.Name(lVar14,1,0);
          uVar17 = String.Concat(uVar17);
          fVar29 = fVar29 + (float)*(int *)(lVar14 + 56);
        }
        uVar18 = uVar18 + 1;
        goto LAB_1813df550;
        LAB_1813df630:
        uVar4 = (uint32)(in_stack_fffffffffffffe78 >> 32);
        uVar5 = (uint32)((uint64)in_stack_fffffffffffffe80 >> 32);
        if ((*(int64 *)(hero + 0x1f8) == 0) ||
           (lVar14 = *(int64 *)(*(int64 *)(hero + 0x1f8) + 128)) == null)
        goto LAB_1813e5276;
        if ((int)*(uint32 *)(lVar14 + 24) <= (int)uVar18) goto LAB_1813df70a;
        if (*(uint32 *)(lVar14 + 24) <= uVar18) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        in_stack_fffffffffffffe88 = 0;
        in_stack_fffffffffffffe80 = CONCAT44(uVar5,0xffffffff);
        in_stack_fffffffffffffe78 = CONCAT44(uVar4,4);
        lVar14 = AIController.HeroManageEquipmentTrade
                           (this,hero,uVar12,
                            *(uint64 *)
                             (*(int64 *)(lVar14 + 16) + 32 + (int64)(int)uVar18 * 8),
                            in_stack_fffffffffffffe78,in_stack_fffffffffffffe80,0);
        if (lVar14 != null) {
          FUN_18171e540(uVar17,"",0);
          ItemData.Name(lVar14,1,0);
          uVar17 = String.Concat(uVar17);
          fVar29 = fVar29 + (float)*(int *)(lVar14 + 56);
        }
        uVar18 = uVar18 + 1;
        goto LAB_1813df630;
        LAB_1813df70a:
        if ((*(int64 *)(hero + 0x220) == 0) ||
           (lVar14 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null)
        goto LAB_1813e5276;
        if (*(uint32 *)(lVar14 + 24) < 2) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        uVar4 = (uint32)(in_stack_fffffffffffffe78 >> 32);
        uVar5 = (uint32)((uint64)in_stack_fffffffffffffe88 >> 32);
        uVar41 = (uint32)((uint64)in_stack_fffffffffffffe90 >> 32);
        uVar43 = (uint32)((uint64)in_stack_fffffffffffffe98 >> 32);
        lVar14 = *(int64 *)(*(int64 *)(lVar14 + 16) + 40);
        if (lVar14 == null) goto LAB_1813e5276;
        if ((float)*(int *)(lVar14 + 24) < (float)*(int *)(hero + 184) * 0.5 + 1.5) {
          if (uVar12 == 0) {
        LAB_1813df811:
            lVar14 = FUN_18046c0a0(0);
            HeroData.GetMaxBuyValue(hero);
            if (lVar14 == null) goto LAB_1813e5276;
            in_stack_fffffffffffffe78 = 0;
            lVar14 = GameController.GenerateMedData(lVar14);
            if (lVar14 == null) goto LAB_1813e5276;
            iVar19 = *(int *)(lVar14 + 56);
            fVar28 = (float)HeroData.GetTradeValueRate(hero,1,0);
            HeroData.ChangeMoney(hero,-(int)((float)iVar19 * fVar28),0,0,in_stack_fffffffffffffe78);
            HeroData.GetItem(hero,lVar14,0,0);
          }
          else {
            HeroData.GetForceStorageDiscount(hero,uVar12,0);
            uVar23 = HeroData.GetMaxBuyValue(hero);
            in_stack_fffffffffffffe98 = CONCAT44(uVar43,uVar23);
            in_stack_fffffffffffffe90 = CONCAT44(uVar41,0xbf800000);
            in_stack_fffffffffffffe88 = CONCAT44(uVar5,0xffffffff);
            lVar14 = ItemListData.FindRandomItem
                               (uVar12,0xffffffff,999999,0,CONCAT44(uVar4,1),0,in_stack_fffffffffffffe88,
                                in_stack_fffffffffffffe90,in_stack_fffffffffffffe98,0);
            if (lVar14 == null) goto LAB_1813df811;
            in_stack_fffffffffffffe78 = 0;
            AIController.HeroBuyItemFromForceStorage(this,hero,lVar14,uVar12,0);
          }
          cVar3 = FUN_18171e540(uVar17,"",0);
          uVar9 = "/";
          if (cVar3) {
            uVar9 = "";
          }
          uVar6 = ItemData.Name(lVar14,1,0);
          uVar17 = String.Concat(uVar17,uVar9,uVar6,0);
          fVar29 = fVar29 + (float)*(int *)(lVar14 + 56);
        }
        if ((*(int64 *)(hero + 0x220) == 0) ||
           (lVar14 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null)
        goto LAB_1813e5276;
        if (*(uint32 *)(lVar14 + 24) < 6) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        uVar4 = (uint32)(in_stack_fffffffffffffe78 >> 32);
        uVar5 = (uint32)((uint64)in_stack_fffffffffffffe88 >> 32);
        uVar41 = (uint32)((uint64)in_stack_fffffffffffffe90 >> 32);
        uVar43 = (uint32)((uint64)in_stack_fffffffffffffe98 >> 32);
        lVar14 = *(int64 *)(*(int64 *)(lVar14 + 16) + 72);
        if (lVar14 == null) goto LAB_1813e5276;
        if ((float)*(int *)(lVar14 + 24) < (float)*(int *)(hero + 184) * 0.5) {
          if (uVar12 == 0) {
        LAB_1813df9f8:
            lVar14 = FUN_18046c0a0(0);
            iVar19 = *(int *)(hero + 184);
            uVar6 = GlobalData.RandomRange((float)iVar19 - 1.5);
            uVar4 = Mathf.RoundToInt(uVar6,0);
            if ((lVar14 == null) ||
               (lVar14 = GameController.GenerateMaterial
                                   (lVar14,uVar4,(float)*(int *)(hero + 184) * 0.3,0), lVar14 == null))
            goto LAB_1813e5276;
            iVar19 = *(int *)(lVar14 + 56);
            fVar28 = (float)HeroData.GetTradeValueRate(hero,1,0);
            HeroData.ChangeMoney(hero,-(int)((float)iVar19 * fVar28),0,0);
            HeroData.GetItem(hero,lVar14,0,0);
          }
          else {
            HeroData.GetForceStorageDiscount(hero,uVar12,0);
            uVar23 = HeroData.GetMaxBuyValue(hero);
            in_stack_fffffffffffffe98 = CONCAT44(uVar43,uVar23);
            in_stack_fffffffffffffe90 = CONCAT44(uVar41,0xbf800000);
            in_stack_fffffffffffffe88 = CONCAT44(uVar5,0xffffffff);
            in_stack_fffffffffffffe78 = CONCAT44(uVar4,5);
            lVar14 = ItemListData.FindRandomItem
                               (uVar12,0xffffffff,999999,0,in_stack_fffffffffffffe78,0,
                                in_stack_fffffffffffffe88,in_stack_fffffffffffffe90,
                                in_stack_fffffffffffffe98,0);
            if (lVar14 == null) goto LAB_1813df9f8;
            in_stack_fffffffffffffe78 = 0;
            AIController.HeroBuyItemFromForceStorage(this,hero,lVar14,uVar12,0);
          }
          cVar3 = FUN_18171e540(uVar17,"",0);
          uVar9 = "/";
          if (cVar3) {
            uVar9 = "";
          }
          uVar6 = ItemData.Name(lVar14,1,0);
          uVar17 = String.Concat(uVar17,uVar9,uVar6,0);
          fVar29 = fVar29 + (float)*(int *)(lVar14 + 56);
        }
        if ((*(int64 *)(hero + 0x220) == 0) ||
           (lVar14 = *(int64 *)(*(int64 *)(hero + 0x220) + 48)) == null)
        goto LAB_1813e5276;
        if (*(uint32 *)(lVar14 + 24) < 3) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        uVar4 = (uint32)(in_stack_fffffffffffffe78 >> 32);
        uVar5 = (uint32)((uint64)in_stack_fffffffffffffe88 >> 32);
        uVar41 = (uint32)((uint64)in_stack_fffffffffffffe90 >> 32);
        uVar43 = (uint32)((uint64)in_stack_fffffffffffffe98 >> 32);
        lVar14 = *(int64 *)(*(int64 *)(lVar14 + 16) + 48);
        if (lVar14 == null) goto LAB_1813e5276;
        if ((float)*(int *)(lVar14 + 24) < (float)*(int *)(hero + 184) * 0.5 - 0.5) {
          if (uVar12 == 0) {
        LAB_1813dfc11:
            lVar14 = FUN_18046c0a0(0);
            HeroData.GetMaxBuyValue(hero);
            if (lVar14 == null) goto LAB_1813e5276;
            uVar6 = 0;
            in_stack_fffffffffffffe78 = CONCAT44(uVar4,0xffffffff);
            lVar14 = GameController.GenerateFoodData(lVar14);
            if (lVar14 == null) goto LAB_1813e5276;
            iVar19 = *(int *)(lVar14 + 56);
            fVar28 = (float)HeroData.GetTradeValueRate(hero,1,0);
            HeroData.ChangeMoney
                      (hero,-(int)((float)iVar19 * fVar28),0,0,in_stack_fffffffffffffe78,uVar6);
            HeroData.GetItem(hero,lVar14,0,0);
          }
          else {
            HeroData.GetForceStorageDiscount(hero,uVar12,0);
            uVar23 = HeroData.GetMaxBuyValue(hero);
            in_stack_fffffffffffffe98 = CONCAT44(uVar43,uVar23);
            in_stack_fffffffffffffe90 = CONCAT44(uVar41,0xbf800000);
            in_stack_fffffffffffffe88 = CONCAT44(uVar5,0xffffffff);
            uVar6 = CONCAT44(uVar4,2);
            lVar14 = ItemListData.FindRandomItem
                               (uVar12,0xffffffff,999999,0,uVar6,0,in_stack_fffffffffffffe88,
                                in_stack_fffffffffffffe90,in_stack_fffffffffffffe98,0);
            uVar4 = (uint32)((uint64)uVar6 >> 32);
            if (lVar14 == null) goto LAB_1813dfc11;
            in_stack_fffffffffffffe78 = 0;
            AIController.HeroBuyItemFromForceStorage(this,hero,lVar14,uVar12,0);
          }
          cVar3 = FUN_18171e540(uVar17,"",0);
          uVar9 = "/";
          if (cVar3) {
            uVar9 = "";
          }
          uVar6 = ItemData.Name(lVar14,1,0);
          uVar17 = String.Concat(uVar17,uVar9,uVar6,0);
          fVar29 = fVar29 + (float)*(int *)(lVar14 + 56);
        }
        fVar28 = 0.7;
        while( true ) {
          uVar4 = (uint32)(in_stack_fffffffffffffe78 >> 32);
          lVar14 = *(int64 *)(hero + 0x220);
          if (lVar14 == null) break;
          if (0.7 < *(float *)(lVar14 + 28) / *(float *)(lVar14 + 32)) {
        LAB_1813dff9f:
            plVar10 = (int64 *)FUN_1800d60b0(DAT_181da4120,4);
            lVar14 = HeroData.Name(hero,1,0);
            if (plVar10 != (int64 *)0) {
              if ((lVar14 != null) &&
                 (lVar8 = il2cpp_internal(lVar14,*(uint64 *)(*plVar10 + 64))) == null) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              if ((int)plVar10[3] == 0) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              plVar10[4] = lVar14;
              il2cpp_internal(plVar10 + 4,lVar14);
              lVar14 = HeroData.AtAreaName(hero,0);
              if ((lVar14 != null) &&
                 (lVar8 = il2cpp_internal(lVar14,*(uint64 *)(*plVar10 + 64))) == null) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              if (*(uint32 *)(plVar10 + 3) < 2) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              plVar10[5] = lVar14;
              il2cpp_internal(plVar10 + 5,lVar14);
              if ((local_res10 != 0) &&
                 (lVar14 = il2cpp_internal(local_res10,*(uint64 *)(*plVar10 + 64))) == null
                 ) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              if (*(uint32 *)(plVar10 + 3) < 3) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              plVar10[6] = local_res10;
              il2cpp_internal(plVar10 + 6,local_res10);
              cVar3 = FUN_18171e540(uVar17,"",0);
              uVar6 = "{0}在{1}买卖交易，出售了闲置物品{2}{3}。";
              uVar12 = "";
              if (!cVar3) {
                uVar12 = String.Format("，并购买了{0}",uVar17,0);
              }
              if ((uVar12 != 0) &&
                 (lVar14 = il2cpp_internal(uVar12,*(uint64 *)(*plVar10 + 64))) == null) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              if (*(uint32 *)(plVar10 + 3) < 4) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              plVar10[7] = uVar12;
              il2cpp_internal(plVar10 + 7,uVar12);
              uVar6 = String.Format(uVar6,plVar10,0);
              HeroData.AddLog(hero,uVar6,0);
              uVar17 = 0;
              HeroData.ChangeLivingSkillExp
                        (hero,3,((float)*(int *)(hero + 184) * 0.25 + 1.0) * (fVar29 + fVar29),0,0)
              ;
              if (*(char *)(hero + 180) == false) goto switchD_1813de14e_caseD_0;
              lVar14 = HeroData.GetForce(hero,0,0);
              if (lVar14 != null) {
                fVar29 = (float)ForceData.GetResourcePercent(lVar14,0,0);
                if (0.9 < fVar29) {
                  lVar14 = il2cpp_internal(DAT_181d93cd0);
                  FUN_18132faf0(lVar14,DAT_181d8f098);
                  goto LAB_1813e0510;
                }
                lVar14 = HeroData.GetForce(hero,0,0);
                if (lVar14 != null) {
                  fVar29 = (float)ForceData.GetResourcePercent(lVar14,0,0);
                  if (0.3 <= fVar29) goto switchD_1813de14e_caseD_0;
                  lVar14 = il2cpp_internal(DAT_181d93cd0);
                  FUN_18132faf0(lVar14,DAT_181d8f098);
                  goto LAB_1813e01e0;
                }
              }
            }
            break;
          }
          GlobalData.RandomRange();
          cVar3 = AIController.CheckHeroItemNumBiggerThanMax(this,hero);
          if (cVar3) goto LAB_1813dff9f;
          if (*(int64 *)(hero + 0x220) == 0) break;
          iVar19 = *(int *)(*(int64 *)(hero + 0x220) + 24);
          fVar26 = (float)FUN_1801f8ab0();
          if ((float)iVar19 < fVar26 * 200.0) goto LAB_1813dff9f;
          dVar30 = (double)GlobalData.RandomRangeDouble(0,0);
          uVar5 = (uint32)((uint64)in_stack_fffffffffffffe88 >> 32);
          uVar41 = (uint32)((uint64)in_stack_fffffffffffffe90 >> 32);
          uVar43 = (uint32)((uint64)in_stack_fffffffffffffe98 >> 32);
          if ((double)fVar28 <= dVar30) goto LAB_1813dff9f;
          if (uVar12 == 0) {
        LAB_1813dfeb6:
            lVar14 = FUN_18046c0a0(0);
            HeroData.GetMaxBuyValue(hero);
            if (lVar14 == null) break;
            in_stack_fffffffffffffe78 = 0;
            lVar14 = GameController.GenerateRandomItemValue(lVar14);
            AIController.HeroBuyItem(this,hero,lVar14,0,in_stack_fffffffffffffe78);
          }
          else {
            HeroData.GetForceStorageDiscount(hero,uVar12,0);
            uVar23 = HeroData.GetMaxBuyValue(hero);
            in_stack_fffffffffffffe98 = CONCAT44(uVar43,uVar23);
            in_stack_fffffffffffffe90 = CONCAT44(uVar41,0xbf800000);
            in_stack_fffffffffffffe88 = CONCAT44(uVar5,0xffffffff);
            lVar14 = ItemListData.FindRandomItem
                               (uVar12,0xffffffff,999999,0,CONCAT44(uVar4,0xffffffff),0,
                                in_stack_fffffffffffffe88,in_stack_fffffffffffffe90,
                                in_stack_fffffffffffffe98,0);
            if (lVar14 == null) goto LAB_1813dfeb6;
            in_stack_fffffffffffffe78 = 0;
            AIController.HeroBuyItemFromForceStorage(this,hero,lVar14,uVar12,0);
          }
          cVar3 = FUN_18171e540(uVar17,"",0);
          uVar9 = "/";
          if (cVar3) {
            uVar9 = "";
          }
          if (lVar14 == null) break;
          ItemData.Name(lVar14,1,0);
          uVar17 = String.Concat(uVar17,uVar9);
          fVar28 = fVar28 * 0.7;
          fVar29 = fVar29 + (float)*(int *)(lVar14 + 56);
        }
        goto LAB_1813e5276;
        while( true ) {
          fVar29 = (float)ForceData.GetResourcePercent(lVar8);
          if (fVar29 < 0.3) {
            if (lVar14 == null) goto LAB_1813e5276;
            FUN_18182a0b0(lVar14);
          }
          iVar21 = iVar21 + 1;
          if (4 < iVar21) break;
        LAB_1813e0510:
          lVar8 = HeroData.GetForce(hero,0,0);
          if (lVar8 == null) goto LAB_1813e5276;
        }
        if (lVar14 == null) goto LAB_1813e5276;
        if (0 < *(int *)(lVar14 + 24)) {
          lVar8 = HeroData.GetForce(hero,0,0);
          if ((lVar8 == null) || (*(int64 *)(lVar8 + 136) == 0)) goto LAB_1813e5276;
          if (*(int *)(*(int64 *)(lVar8 + 136) + 24) == 0) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar8 = HeroData.GetForce(hero,0,0);
          if (lVar8 == null) goto LAB_1813e5276;
          ForceData.GetResourcePercent(lVar8,0,0);
          GlobalData.RandomRange();
          iVar21 = Mathf.RoundToInt();
          lVar8 = HeroData.GetForce(hero,0,0);
          if (lVar8 == null) goto LAB_1813e5276;
          uVar6 = 0;
          ForceData.ChangeResource(lVar8,0);
          local_13c = Mathf.RoundToInt(((float)iVar21 * 0.9) / (float)*(int *)(lVar14 + 24),0);
          uVar12 = "";
          while (iVar19 = (int)uVar17, iVar19 < *(int *)(lVar14 + 24)) {
            uVar9 = "/";
            if (iVar19 == 0) {
              uVar9 = "";
            }
            lVar8 = *(int64 *)(pStatics + 0x438);
            uVar4 = FUN_1800d6760(lVar14,uVar17,DAT_181d8fa18);
            if (lVar8 == null) goto LAB_1813e5276;
            uVar6 = FUN_180002f80(lVar8,uVar4,DAT_181da4358);
            uVar7 = Int32.ToString(&local_13c,0);
            uVar12 = String.Concat(uVar12,uVar9,uVar6,uVar7,0);
            lVar8 = HeroData.GetForce(hero,0,0);
            uVar4 = FUN_1800d6760(lVar14,uVar17);
            if (lVar8 == null) goto LAB_1813e5276;
            uVar6 = 0;
            ForceData.ChangeResource(lVar8,uVar4);
            uVar17 = (uint64)(iVar19 + 1);
          }
          uVar40 = HeroData.Name(hero,CONCAT71((int7)(uVar17 >> 8),1),0);
          local_124 = iVar21;
          uVar9 = il2cpp_value_box(DAT_181d80418,&local_124);
          uVar7 = "{0}使用门派银钱{1}两，购买{2}。";
          goto LAB_1813e04cf;
        }
        goto switchD_1813de14e_caseD_0;
        while( true ) {
          fVar29 = (float)ForceData.GetResourcePercent(lVar8);
          if (0.8 < fVar29) {
            if (lVar14 == null) goto LAB_1813e5276;
            FUN_18182a0b0(lVar14);
          }
          iVar21 = iVar21 + 1;
          if (4 < iVar21) break;
        LAB_1813e01e0:
          lVar8 = HeroData.GetForce(hero,0,0);
          if (lVar8 == null) goto LAB_1813e5276;
        }
        if (lVar14 == null) goto LAB_1813e5276;
        if (0 < *(int *)(lVar14 + 24)) {
          uVar9 = "";
          for (uVar18 = 0; (int)uVar18 < *(int *)(lVar14 + 24); uVar18 = uVar18 + 1) {
            lVar8 = HeroData.GetForce(hero);
            if (lVar8 == null) goto LAB_1813e5276;
            lVar8 = *(int64 *)(lVar8 + 136);
            if (*(uint32 *)(lVar14 + 24) <= uVar18) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar8 == null) goto LAB_1813e5276;
            if (*(uint32 *)(lVar8 + 24) <=
                lVar14[uVar18]) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar8 = HeroData.GetForce(hero,0,0);
            if (*(uint32 *)(lVar14 + 24) <= uVar18) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar8 == null) goto LAB_1813e5276;
            ForceData.GetResourcePercent
                      (lVar8,*(uint32 *)
                              (*(int64 *)(lVar14 + 16) + 32 + (int64)(int)uVar18 * 4),0);
            GlobalData.RandomRange();
            local_148 = Mathf.RoundToInt();
            uVar12 = "/";
            if (uVar18 == 0) {
              uVar12 = "";
            }
            lVar8 = *(int64 *)(pStatics + 0x438);
            uVar4 = FUN_1800d6760(lVar14,uVar18,DAT_181d8fa18);
            if (lVar8 == null) goto LAB_1813e5276;
            uVar6 = FUN_180002f80(lVar8,uVar4,DAT_181da4358);
            uVar7 = Int32.ToString(&local_148,0);
            uVar9 = String.Concat(uVar9,uVar12,uVar6,uVar7,0);
            iVar21 = Mathf.RoundToInt((float)local_148 * 0.9,0);
            uVar17 = (uint64)(uint32)((int)uVar17 + iVar21);
            lVar8 = HeroData.GetForce(hero,0,0);
            FUN_1800d6760(lVar14,uVar18);
            if (lVar8 == null) goto LAB_1813e5276;
            ForceData.ChangeResource(lVar8);
          }
          lVar14 = HeroData.GetForce(hero,0,0);
          if (lVar14 == null) goto LAB_1813e5276;
          uVar6 = 0;
          ForceData.ChangeResource(lVar14,0);
          uVar40 = HeroData.Name(hero,1,0);
          local_128 = (int)uVar17;
          uVar12 = il2cpp_value_box(DAT_181d80418,&local_128);
          uVar7 = "{0}出售门派{1}，换取门派银钱{2}两。";
        LAB_1813e04cf:
          uVar6 = String.Format(uVar7,uVar40,uVar9,uVar12,0,uVar6);
          HeroData.AddLog(hero,uVar6,0);
        }
        goto switchD_1813de14e_caseD_0;
    }

    // Token : 0x60009F5
    // RVA   : 0x13DAFB0   Offset: 0x13DA3B0   Length: 0x38C
    public void AICheckRemoveBrother(HeroData hero)
    {
        bool cVar1;
        int iVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        uint uVar8;
        long lVar9;
        double dVar10;
        dVar10 = (double)GlobalData.RandomRangeDouble(0,0);
        if (hero != null) {
          cVar1 = HeroData.HaveBrother(hero,0,0);
          lVar4 = *(int64 *)(hero + 0x340);
          if (!cVar1) {
            if (lVar4 == null) throw; // [null/range check failed]
            iVar2 = *(int *)(lVar4 + 24);
          }
          else {
            if (lVar4 == null) throw; // [null/range check failed]
            iVar2 = *(int *)(lVar4 + 24) + -1;
          }
          if ((double)((float)iVar2 * 0.35) < dVar10) {
            return;
          }
          lVar4 = il2cpp_internal(DAT_181d93cd0);
          FUN_18132faf0(lVar4,DAT_181d8f098);
          uVar8 = 0;
          lVar9 = 32;
          while (lVar5 = *(int64 *)(hero + 0x340)) != null {
            if ((int)*(uint32 *)(lVar5 + 24) <= (int)uVar8) {
              if (lVar4 != null) {
                iVar2 = *(int *)(lVar4 + 24);
                if (iVar2 < 1) {
                  return;
                }
                uVar8 = GlobalData.RandomRange(0,iVar2,0,0);
                if (*(uint32 *)(lVar4 + 24) <= uVar8) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                iVar2 = lVar4[uVar8];
                if (iVar2 == -1) {
                  return;
                }
                HeroData.RemoveBrother(hero,iVar2,0,0);
                uVar6 = HeroData.Name(hero,1,0);
                lVar4 = FUN_18046c0a0(0);
                if ((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) {
                  lVar4 = WorldData.GetHero(*(int64 *)(lVar4 + 32),iVar2,0);
                  if (lVar4 != null) {
                    uVar7 = HeroData.Name(lVar4,1,0);
                    uVar6 = String.Format("{0}与{1}割袍断席，结束了结义关系。",uVar6,uVar7,0);
                    HeroData.AddLog(hero,uVar6,0);
                    lVar4 = FUN_18046c0a0(0);
                    if (((lVar4 != null) && (*(int64 *)(lVar4 + 32) != 0)) &&
                       (lVar4 = WorldData.GetHero(*(int64 *)(lVar4 + 32),iVar2,0)) != null) {
                      HeroData.AddLog(lVar4,uVar6,0);
                      return;
                    }
                  }
                }
              }
              break;
            }
            if (*(uint32 *)(lVar5 + 24) <= uVar8) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(int *)(*(int64 *)(lVar5 + 16) + lVar9) != 0) {
              if (*(char *)(hero + 92) != false) {
                lVar5 = FUN_18046c0a0(0);
                if (lVar5 == null) break;
                lVar5 = *(int64 *)(lVar5 + 32);
                if (((*(int64 *)(hero + 0x340) == 0) ||
                    (uVar3 = FUN_1800d6760(*(int64 *)(hero + 0x340),uVar8), lVar5 == null)) ||
                   (lVar5 = WorldData.GetHero(lVar5,uVar3)) == null) break;
                if (*(char *)(lVar5 + 92) == false)
                {
                  }
                  if ((*(int64 *)(hero + 0x340) == 0) ||
                  (uVar3 = FUN_1800d6760(*(int64 *)(hero + 0x340),uVar8,DAT_181d8fa18), lVar4 == null))
                  break;
                  FUN_18182a0b0(lVar4,uVar3);
                  }
                }
            uVar8 = uVar8 + 1;
            lVar9 = lVar9 + 4;
          }
        }
    }

    // Token : 0x60009F6
    // RVA   : 0x13DB340   Offset: 0x13DA740   Length: 0x367
    public void AICheckRemoveFriend(HeroData hero)
    {
        int iVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        uint uVar7;
        long lVar8;
        double dVar9;
        dVar9 = (double)GlobalData.RandomRangeDouble(0,0);
        if ((hero != null) && (*(int64 *)(hero + 0x348) != 0)) {
          if ((double)((float)(*(int *)(*(int64 *)(hero + 0x348) + 24) + -2) * 0.2) < dVar9) {
            return;
          }
          lVar3 = il2cpp_internal(DAT_181d93cd0);
          FUN_18132faf0(lVar3,DAT_181d8f098);
          uVar7 = 0;
          lVar8 = 32;
          while (lVar4 = *(int64 *)(hero + 0x348)) != null {
            if ((int)*(uint32 *)(lVar4 + 24) <= (int)uVar7) {
              if (lVar3 != null) {
                iVar1 = *(int *)(lVar3 + 24);
                if (iVar1 < 1) {
                  return;
                }
                uVar7 = GlobalData.RandomRange(0,iVar1,0,0);
                if (*(uint32 *)(lVar3 + 24) <= uVar7) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                iVar1 = lVar3[uVar7];
                if (iVar1 == -1) {
                  return;
                }
                HeroData.RemoveFriend(hero,iVar1,0,0);
                uVar5 = HeroData.Name(hero,1,0);
                lVar3 = FUN_18046c0a0(0);
                if ((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) {
                  lVar3 = WorldData.GetHero(*(int64 *)(lVar3 + 32),iVar1,0);
                  if (lVar3 != null) {
                    uVar6 = HeroData.Name(lVar3,1,0);
                    uVar5 = String.Format("{0}与{1}情谊渐浅，结束了好友关系。",uVar5,uVar6,0);
                    HeroData.AddLog(hero,uVar5,0);
                    lVar3 = FUN_18046c0a0(0);
                    if (((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
                       (lVar3 = WorldData.GetHero(*(int64 *)(lVar3 + 32),iVar1,0)) != null) {
                      HeroData.AddLog(lVar3,uVar5,0);
                      return;
                    }
                  }
                }
              }
              break;
            }
            if (*(uint32 *)(lVar4 + 24) <= uVar7) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(int *)(*(int64 *)(lVar4 + 16) + lVar8) != 0) {
              if (*(char *)(hero + 92) != false) {
                lVar4 = FUN_18046c0a0(0);
                if (lVar4 == null) break;
                lVar4 = *(int64 *)(lVar4 + 32);
                if (((*(int64 *)(hero + 0x348) == 0) ||
                    (uVar2 = FUN_1800d6760(*(int64 *)(hero + 0x348),uVar7), lVar4 == null)) ||
                   (lVar4 = WorldData.GetHero(lVar4,uVar2)) == null) break;
                if (*(char *)(lVar4 + 92) == false)
                {
                  }
                  if ((*(int64 *)(hero + 0x348) == 0) ||
                  (uVar2 = FUN_1800d6760(*(int64 *)(hero + 0x348),uVar7,DAT_181d8fa18), lVar3 == null))
                  break;
                  FUN_18182a0b0(lVar3,uVar2);
                  }
                }
            uVar7 = uVar7 + 1;
            lVar8 = lVar8 + 4;
          }
        }
    }

    // Token : 0x60009F7
    // RVA   : 0x13DB6B0   Offset: 0x13DAAB0   Length: 0x36E
    public void AICheckRemoveHater(HeroData hero)
    {
        uint uVar1;
        int iVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        uint uVar7;
        long lVar8;
        double dVar9;
        if ((hero != null) && (*(int64 *)(hero + 0x350) != 0)) {
          if (*(int *)(*(int64 *)(hero + 0x350) + 24) < 1) {
            return;
          }
          dVar9 = (double)GlobalData.RandomRangeDouble(0,0);
          if (*(int64 *)(hero + 0x350) != 0) {
            if ((double)((float)*(int *)(*(int64 *)(hero + 0x350) + 24) * 0.25) < dVar9) {
              return;
            }
            lVar3 = il2cpp_internal(DAT_181d93cd0);
            FUN_18132faf0(lVar3,DAT_181d8f098);
            uVar7 = 0;
            lVar8 = 32;
            while (lVar4 = *(int64 *)(hero + 0x350)) != null {
              if ((int)*(uint32 *)(lVar4 + 24) <= (int)uVar7) {
                if (lVar3 != null) {
                  iVar2 = *(int *)(lVar3 + 24);
                  if (iVar2 < 1) {
                    return;
                  }
                  uVar1 = GlobalData.RandomRange(0,iVar2,0,0);
                  iVar2 = FUN_1800d6760(lVar3,uVar1,DAT_181d8fa18);
                  if (iVar2 == -1) {
                    return;
                  }
                  HeroData.RemoveHater(hero,iVar2,0,0);
                  uVar5 = HeroData.Name(hero,1,0);
                  lVar3 = FUN_18046c0a0(0);
                  if (((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
                     (lVar3 = WorldData.GetHero(*(int64 *)(lVar3 + 32),iVar2,0)) != null) {
                    uVar6 = HeroData.Name(lVar3,1,0);
                    uVar5 = String.Format("{0}与{1}冰释前嫌，化解了二人间的仇恨。",uVar5,uVar6,0);
                    HeroData.AddLog(hero,uVar5,0);
                    lVar3 = FUN_18046c0a0(0);
                    if (((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
                       (lVar3 = WorldData.GetHero(*(int64 *)(lVar3 + 32),iVar2,0)) != null) {
                      HeroData.AddLog(lVar3,uVar5,0);
                      return;
                    }
                  }
                }
                break;
              }
              if (*(uint32 *)(lVar4 + 24) <= uVar7) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (*(int *)(*(int64 *)(lVar4 + 16) + lVar8) != 0) {
                if (*(char *)(hero + 92) != false) {
                  lVar4 = FUN_18046c0a0(0);
                  if (lVar4 == null) break;
                  lVar4 = *(int64 *)(lVar4 + 32);
                  if (((*(int64 *)(hero + 0x350) == 0) ||
                      (uVar1 = FUN_1800d6760(*(int64 *)(hero + 0x350),uVar7), lVar4 == null)) ||
                     (lVar4 = WorldData.GetHero(lVar4,uVar1)) == null) break;
                  if (*(char *)(lVar4 + 92) == false)
                  {
                    }
                    if ((*(int64 *)(hero + 0x350) == 0) ||
                    (uVar1 = FUN_1800d6760(*(int64 *)(hero + 0x350),uVar7,DAT_181d8fa18), lVar3 == null)
                    ) break;
                    FUN_18182a0b0(lVar3,uVar1);
                    }
                  }
              uVar7 = uVar7 + 1;
              lVar8 = lVar8 + 4;
            }
          }
        }
    }

    // Token : 0x60009F8
    // RVA   : 0x13EB590   Offset: 0x13EA990   Length: 0x231
    public void NPCGoInPrison(HeroData targetHero, HeroData sourceHero)
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        ulong uVar4;
        float fVar5;
        ulong uVar6;
        if (**(int **)(DAT_181d73d40 + 184) == 2) {
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
              lVar1 = **(int64 **)(DAT_181d7f6a8 + 184);
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

    // Token : 0x60009F9
    // RVA   : 0x13E6440   Offset: 0x13E5840   Length: 0x1F9
    public void HeroLoseFightOnBigMap(HeroData hero)
    {
        bool cVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        if (hero == null) goto LAB_1813e6634;
        cVar1 = HeroData.HaveArea(hero,0);
        if (!cVar1) {
          if (*(char *)(hero + 0x3cc) == false) {
            if (*(int64 *)(hero + 64) == 0) goto LAB_1813e6634;
            if (*(int *)(*(int64 *)(hero + 64) + 48) < 0) {
              lVar3 = FUN_18046c0a0(0);
              lVar4 = FUN_18046bbe0(0);
              if (lVar4 == null) goto LAB_1813e6634;
              uVar2 = BigMapController.GetNearAreaID(lVar4,*(uint64 *)(hero + 200),0);
              if (lVar3 == null) goto LAB_1813e6634;
              GameController.HeroEnterArea(lVar3,hero,uVar2,0);
            }
            else {
              lVar3 = FUN_18046c0a0(0);
              if ((*(int64 *)(hero + 64) == 0) || (lVar3 == null)) goto LAB_1813e6634;
              GameController.HeroEnterArea
                        (lVar3,hero,*(uint32 *)(*(int64 *)(hero + 64) + 48),0);
            }
          }
          else {
            HeroData.SetNeedRemove(hero,0);
          }
          lVar3 = *(int64 *)(*(int64 *)(DAT_181db0bc8 + 184) + 16);
          if ((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 152)) == null) {
        LAB_1813e6634:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          FUN_18181e0a0(lVar3,hero,DAT_181d8b518);
        }
    }

    // Token : 0x60009FA
    // RVA   : 0x13DD800   Offset: 0x13DCC00   Length: 0x68
    public bool CheckHeroMoneyBiggerThanMin(HeroData hero, float rate)
    {
        int iVar1;
        float extraout_XMM0_Da;
        if ((hero != null) && (*(int64 *)(hero + 0x220) != 0)) {
          iVar1 = *(int *)(*(int64 *)(hero + 0x220) + 24);
          FUN_1801f8ab0(0x40000000);
          return extraout_XMM0_Da * rate * 200.0 <= (float)iVar1;
        }
    }

    // Token : 0x60009FB
    // RVA   : 0x13E5590   Offset: 0x13E4990   Length: 0x58
    public float GetHeroMoneyRate(HeroData hero)
    {
        int iVar1;
        float fVar2;
        if ((hero != null) && (*(int64 *)(hero + 0x220) != 0)) {
          iVar1 = *(int *)(*(int64 *)(hero + 0x220) + 24);
          fVar2 = (float)FUN_1801f8ab0(0x40000000);
          return (float)iVar1 / (fVar2 * 400.0);
        }
    }

    // Token : 0x60009FC
    // RVA   : 0x13DD7C0   Offset: 0x13DCBC0   Length: 0x33
    public bool CheckHeroItemWeightBiggerThanMax(HeroData hero)
    {
        long lVar1;
        if ((hero != null) && (lVar1 = *(int64 *)(hero + 0x220)) != null) {
          return CONCAT71((int7)((uint64)lVar1 >> 8),
                          0.7 < *(float *)(lVar1 + 28) / *(float *)(lVar1 + 32));
        }
    }

    // Token : 0x60009FD
    // RVA   : 0x13DD650   Offset: 0x13DCA50   Length: 0x167
    public bool CheckHeroItemNumBiggerThanMax(HeroData hero, float rate)
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        int iVar1;
        long lVar2;
        int iVar3;
        if (((hero != null) && (*(int64 *)(hero + 0x220) != 0)) &&
           (lVar2 = *(int64 *)(*(int64 *)(hero + 0x220) + 40)) != null) {
          iVar1 = *(int *)(lVar2 + 24);
          if (((*pStatics != 0) &&
              (lVar2 = *(int64 *)(*pStatics + 32)) != null) &&
             (lVar2 = *(int64 *)(lVar2 + 168)) != null) {
            iVar3 = Mathf.Clamp(*(int *)(lVar2 + 16) + -1,0,10);
            return (float)(*(int *)(hero + 184) * 2 + 20) * rate + (float)iVar3 * -0.5 <
                   (float)iVar1;
          }
        }
    }

    // Token : 0x60009FE
    // RVA   : 0x13E54B0   Offset: 0x13E48B0   Length: 0xDC
    public float GetHeroItemNumTimeChange()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        long lVar1;
        int iVar2;
        if (((*pStatics != 0) &&
            (lVar1 = *(int64 *)(*pStatics + 32)) != null) &&
           (lVar1 = *(int64 *)(lVar1 + 168)) != null) {
          iVar2 = Mathf.Clamp(*(int *)(lVar1 + 16) + -1,0,10);
          return (float)iVar2 * -0.5;
        }
    }

    // Token : 0x60009FF
    // RVA   : 0x13E6130   Offset: 0x13E5530   Length: 0x30A
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
                plVar2 = (int64 *)FUN_1800d60b0(DAT_181da4120,4);
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
                  lVar3 = il2cpp_value_box(DAT_181d80418,local_res10);
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
                    lVar3 = ForceData.GetForceName(lVar3,1,0);
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

    // Token : 0x6000A00
    // RVA   : 0x13E5D60   Offset: 0x13E5160   Length: 0x34B
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
                plVar2 = (int64 *)FUN_1800d60b0(DAT_181da4120,4);
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
                  lVar3 = il2cpp_value_box(DAT_181d80418,local_res18);
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
                    lVar3 = ForceData.GetForceName(lVar3,1,0);
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

    // Token : 0x6000A01
    // RVA   : 0x13E60B0   Offset: 0x13E54B0   Length: 0x74
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

    // Token : 0x6000A02
    // RVA   : 0x13E68C0   Offset: 0x13E5CC0   Length: 0x72
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

    // Token : 0x6000A03
    // RVA   : 0x13E6640   Offset: 0x13E5A40   Length: 0x27B
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
            lVar2 = il2cpp_internal(DAT_181d93cd0);
            FUN_18132faf0(lVar2,DAT_181d8f098);
            if (lVar2 == null) throw; // [null/range check failed]
            FUN_18182a0b0(lVar2,subType,DAT_181d8f218);
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

    // Token : 0x6000A04
    // RVA   : 0x13EBCD0   Offset: 0x13EB0D0   Length: 0xCF
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
          FUN_18181e0a0(this.needLeaveHero,hero,DAT_181d8b518);
          return;
        }
    }

    // Token : 0x6000A05
    // RVA   : 0x13EC7B0   Offset: 0x13EBBB0   Length: 0x121
    public void /*ctor*/()
    {
        ulong uVar1;
        long lVar2;
        uVar1 = il2cpp_internal(DAT_181d93350);
        FUN_18132faf0(uVar1,DAT_181d8b418);
        this.needLeaveHero = uVar1;
        lVar2 = il2cpp_internal(DAT_181d93cd0);
        FUN_18132faf0(lVar2,DAT_181d8f098);
        if (lVar2 != null) {
          FUN_18182a0b0(lVar2,0x3e0,DAT_181d8f218);
          FUN_18182a0b0(lVar2,0x3e1,DAT_181d8f218);
          FUN_18182a0b0(lVar2,0x3e2,DAT_181d8f218);
          FUN_18182a0b0(lVar2,0x3e3,DAT_181d8f218);
          this.speSkillIDList = lVar2;
          FUN_18044ef50(this,0);
          return;
        }
    }

    // Token : 0x6000A06
    // RVA   : 0x13EC0D0   Offset: 0x13EB4D0   Length: 0x6D1
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181da9de0 + 184);
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d97750);
        FUN_18132faf0(lVar1,DAT_181da3bd8);
        if (lVar1 != null) {
          FUN_18181e0a0(lVar1,"无所事事",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"前往",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"闲逛",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"休息",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"治疗",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"修炼",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"学习",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"获取",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"赚钱",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"交易",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"探索",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"交友",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"切磋",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"战斗",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"完成委托",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"经历奇遇",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"被囚禁",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"降低恶名",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"初习",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"加强管理",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"暗中破坏",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"烹饪",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"炼药",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"锻造",DAT_181da3d58);
          plVar2 = pStatics;
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          lVar1 = il2cpp_internal(DAT_181d90960);
          FUN_18132faf0(lVar1,DAT_181d7ad88);
          if (lVar1 != null) {
            FUN_18182a0b0(lVar1,11,DAT_181d7ae08);
            FUN_18182a0b0(lVar1,12,DAT_181d7ae08);
            FUN_18182a0b0(lVar1,13,DAT_181d7ae08);
            plVar2 = (int64 *)(pStatics + 8);
            *plVar2 = lVar1;
            il2cpp_internal(plVar2,lVar1);
            lVar1 = il2cpp_internal(DAT_181d90960);
            FUN_18132faf0(lVar1,DAT_181d7ad88);
            if (lVar1 != null) {
              FUN_18182a0b0(lVar1,1,DAT_181d7ae08);
              FUN_18182a0b0(lVar1,19,DAT_181d7ae08);
              FUN_18182a0b0(lVar1,20,DAT_181d7ae08);
              plVar2 = (int64 *)(pStatics + 16);
              *plVar2 = lVar1;
              il2cpp_internal(plVar2,lVar1);
              lVar1 = il2cpp_internal(DAT_181d90960);
              FUN_18132faf0(lVar1,DAT_181d7ad88);
              if (lVar1 != null) {
                FUN_18182a0b0(lVar1,12,DAT_181d7ae08);
                FUN_18182a0b0(lVar1,13,DAT_181d7ae08);
                plVar2 = (int64 *)(pStatics + 24);
                *plVar2 = lVar1;
                il2cpp_internal(plVar2,lVar1);
                lVar1 = il2cpp_internal(DAT_181d908e0);
                FUN_18132faf0(lVar1,DAT_181d7ac08);
                if (lVar1 != null) {
                  FUN_18182a0b0(lVar1,1,DAT_181d7ac88);
                  FUN_18182a0b0(lVar1,2,DAT_181d7ac88);
                  FUN_18182a0b0(lVar1,3,DAT_181d7ac88);
                  FUN_18182a0b0(lVar1,4,DAT_181d7ac88);
                  FUN_18182a0b0(lVar1,5,DAT_181d7ac88);
                  plVar2 = (int64 *)(pStatics + 32);
                  *plVar2 = lVar1;
                  il2cpp_internal(plVar2,lVar1);
                  lVar1 = il2cpp_internal(DAT_181d941d0);
                  FUN_18132faf0(lVar1,DAT_181d91218);
                  if (lVar1 != null) {
                    FUN_18182a0b0(lVar1,0,DAT_181d91298);
                    FUN_18182a0b0(lVar1,3,DAT_181d91298);
                    FUN_18182a0b0(lVar1,4,DAT_181d91298);
                    FUN_18182a0b0(lVar1,5,DAT_181d91298);
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
