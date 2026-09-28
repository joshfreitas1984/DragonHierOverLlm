// ============================================================
// Type  : ItemData
// Token : 0x200023D
// ============================================================

public class ItemData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40011E9
    public int itemID;

    // Token: 0x40011EA
    public ItemType type;

    // Token: 0x40011EB
    public int subType;

    // Token: 0x40011EC
    public string name;

    // Token: 0x40011ED
    public string checkName;

    // Token: 0x40011EE
    public string describe;

    // Token: 0x40011EF
    public int value;

    // Token: 0x40011F0
    public int itemLv;

    // Token: 0x40011F1
    public int rareLv;

    // Token: 0x40011F2
    public float weight;

    // Token: 0x40011F3
    public bool isNew;

    // Token: 0x40011F4
    public float poisonNum;

    // Token: 0x40011F5
    public bool poisonNumDetected;

    // Token: 0x40011F6
    public string setName;

    // Token: 0x40011F7
    public EquipmentData equipmentData;

    // Token: 0x40011F8
    public MedFoodData medFoodData;

    // Token: 0x40011F9
    public BookData bookData;

    // Token: 0x40011FA
    public TreasureData treasureData;

    // Token: 0x40011FB
    public MaterialData materialData;

    // Token: 0x40011FC
    public HorseData horseData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60012C7
    // RVA   : 0xCA0830   Offset: 0xC9FC30   Length: 0x174
    public void /*ctor*/(ItemType _type)
    {
        ulong uVar1;
        this.weight = 0x3f800000;
        ZhSegment.Initialize(this,0);
        this.type = _type;
        switch(_type) {
        case 0:
          uVar1 = new EquipmentData(0);
          puVar2 = &this.equipmentData;
          break;
        case 1:
        case 2:
          uVar1 = new MedFoodData(0);
          puVar2 = &this.medFoodData;
          break;
        case 3:
          uVar1 = new c.DisplayClass9_0(0);
          puVar2 = &this.bookData;
          break;
        case 4:
          uVar1 = new TreasureData(0);
          puVar2 = &this.treasureData;
          break;
        case 5:
          uVar1 = new MaterialData(0);
          puVar2 = &this.materialData;
          break;
        case 6:
          uVar1 = new c.DisplayClass9_0(0);
          puVar2 = &this.horseData;
          break;
        default:
          goto switchD_180ca08c6_default;
        }
        this.horseData = uVar1;
        il2cpp_internal(puVar2,uVar1);
        switchD_180ca08c6_default:
    }

    // Token : 0x60012C8
    // RVA   : 0xC9DD70   Offset: 0xC9D170   Length: 0x30
    public float GetHorseMaxWeightAdd()
    {
        if (this.subType != null) {
          return;
        }
    }

    // Token : 0x60012C9
    // RVA   : 0xC9EEA0   Offset: 0xC9E2A0   Length: 0x22
    public int GetWeaponResearchExp()
    {
        float fVar1;
        fVar1 = (float)FUN_1801f8ab0(0x40000000);
        return (int)fVar1;
    }

    // Token : 0x60012CA
    // RVA   : 0xC9EED0   Offset: 0xC9E2D0   Length: 0x2A8
    public bool IsHeroEquip(HeroData targetHero)
    {
        int iVar1;
        uint uVar2;
        ulong uVar3;
        long lVar4;
        uint uVar5;
        long lVar6;
        uVar5 = this.type;
        uVar3 = (uint64)uVar5;
        if (uVar5 == 0) {
          iVar1 = this.subType;
          if (iVar1 == 0) {
            uVar5 = 0;
            if (targetHero != null) {
              lVar6 = 32;
              while ((*(int64 *)(targetHero + 0x1f8) != 0 &&
                     (lVar4 = *(int64 *)(*(int64 *)(targetHero + 0x1f8) + 32)) != null)) {
                uVar2 = *(uint32 *)(lVar4 + 24);
                uVar3 = (uint64)uVar2;
                if ((int)uVar2 <= (int)uVar5) goto LAB_180c9f157;
                if (uVar2 <= uVar5) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar4 = *(int64 *)(lVar4 + 16);
                if (*(int64 *)(lVar6 + lVar4) == this) goto LAB_180c9f120;
                uVar5 = uVar5 + 1;
                lVar6 = lVar6 + 8;
              }
            }
          }
          else if (iVar1 == 1) {
            uVar5 = 0;
            if (targetHero != null) {
              lVar6 = 32;
              while ((*(int64 *)(targetHero + 0x1f8) != 0 &&
                     (lVar4 = *(int64 *)(*(int64 *)(targetHero + 0x1f8) + 56)) != null)) {
                uVar2 = *(uint32 *)(lVar4 + 24);
                uVar3 = (uint64)uVar2;
                if ((int)uVar2 <= (int)uVar5) goto LAB_180c9f157;
                if (uVar2 <= uVar5) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar4 = *(int64 *)(lVar4 + 16);
                if (*(int64 *)(lVar6 + lVar4) == this) goto LAB_180c9f120;
                uVar5 = uVar5 + 1;
                lVar6 = lVar6 + 8;
              }
            }
          }
          else if (iVar1 == 2) {
            uVar5 = 0;
            if (targetHero != null) {
              lVar6 = 32;
              while ((*(int64 *)(targetHero + 0x1f8) != 0 &&
                     (lVar4 = *(int64 *)(*(int64 *)(targetHero + 0x1f8) + 80)) != null)) {
                uVar2 = *(uint32 *)(lVar4 + 24);
                uVar3 = (uint64)uVar2;
                if ((int)uVar2 <= (int)uVar5) goto LAB_180c9f157;
                if (uVar2 <= uVar5) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar4 = *(int64 *)(lVar4 + 16);
                if (*(int64 *)(lVar6 + lVar4) == this) goto LAB_180c9f120;
                uVar5 = uVar5 + 1;
                lVar6 = lVar6 + 8;
              }
            }
          }
          else if (iVar1 == 3) {
            uVar5 = 0;
            if (targetHero != null) {
              lVar6 = 32;
              while ((*(int64 *)(targetHero + 0x1f8) != 0 &&
                     (lVar4 = *(int64 *)(*(int64 *)(targetHero + 0x1f8) + 104)) != null)) {
                uVar2 = *(uint32 *)(lVar4 + 24);
                uVar3 = (uint64)uVar2;
                if ((int)uVar2 <= (int)uVar5) goto LAB_180c9f157;
                if (uVar2 <= uVar5) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar4 = *(int64 *)(lVar4 + 16);
                if (*(int64 *)(lVar6 + lVar4) == this) goto LAB_180c9f120;
                uVar5 = uVar5 + 1;
                lVar6 = lVar6 + 8;
              }
            }
          }
          else {
            if (iVar1 != 4) goto LAB_180c9f157;
            uVar5 = 0;
            if (targetHero != null) {
              lVar6 = 32;
              while ((*(int64 *)(targetHero + 0x1f8) != 0 &&
                     (lVar4 = *(int64 *)(*(int64 *)(targetHero + 0x1f8) + 128)) != null)) {
                uVar2 = *(uint32 *)(lVar4 + 24);
                uVar3 = (uint64)uVar2;
                if ((int)uVar2 <= (int)uVar5) goto LAB_180c9f157;
                if (uVar2 <= uVar5) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar4 = *(int64 *)(lVar4 + 16);
                if (*(int64 *)(lVar6 + lVar4) == this) {
        LAB_180c9f120:
                  return CONCAT71((int7)((uint64)lVar4 >> 8),1);
                }
                uVar5 = uVar5 + 1;
                lVar6 = lVar6 + 8;
              }
            }
          }
        }
        else {
          if (uVar5 != 6) {
        LAB_180c9f157:
            return uVar3 & 0xffffffffffffff00;
          }
          uVar5 = this.subType;
          uVar3 = (uint64)uVar5;
          if (uVar5 == 0) {
            if (targetHero != null) {
              return (uint64)(*(int64 *)(targetHero + 0x208) == this);
            }
          }
          else {
            if (uVar5 != 1) goto LAB_180c9f157;
            if (targetHero != null) {
              return (uint64)(*(int64 *)(targetHero + 0x218) == this);
            }
          }
        }
    }

    // Token : 0x60012CB
    // RVA   : 0xC9DE00   Offset: 0xC9D200   Length: 0x660
    public string GetItemIconName()
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
        bool cVar1;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar6;
        ulong uVar7;
        ulong uVar8;
        int[] local_res8 = new int[4];
        int[] local_res18 = new int[2];
        uint[] local_res20 = new uint[2];
        uint local_38;
        int[] local_34 = new int[3];
        local_res8[0] = 0;
        uVar8 = "";
        switch(this.type) {
        case 0:
          local_res8[0] = this.subType;
          if (local_res8[0] == 0) {
            plVar2 = (int64 *)FUN_1800d60b0(DAT_181da4120,4);
            local_res18[0] = this.subType;
            lVar6 = il2cpp_value_box(DAT_181d80418,local_res18);
            if (plVar2 != (int64 *)0) {
              if ((lVar6 != null) &&
                 (lVar3 = il2cpp_internal(lVar6,*(uint64 *)(*plVar2 + 64))) == null) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              if ((int)plVar2[3] == 0) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              plVar2[4] = lVar6;
              il2cpp_internal(plVar2 + 4,lVar6);
              if (this.equipmentData != null) {
                local_res20[0] = this.equipmentData.littleType;
                lVar6 = il2cpp_value_box(DAT_181d80418,local_res20);
                if ((lVar6 != null) &&
                   (lVar3 = il2cpp_internal(lVar6,*(uint64 *)(*plVar2 + 64))) == null) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                if (*(uint32 *)(plVar2 + 3) < 2) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
                plVar2[5] = lVar6;
                il2cpp_internal(plVar2 + 5,lVar6);
                if (this.equipmentData != null) {
                  local_38 = this.equipmentData.attriType;
                  lVar6 = il2cpp_value_box(DAT_181d80418,&local_38);
                  if ((lVar6 != null) &&
                     (lVar3 = il2cpp_internal(lVar6,*(uint64 *)(*plVar2 + 64))) == null) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  if (*(uint32 *)(plVar2 + 3) < 3) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  plVar2[6] = lVar6;
                  il2cpp_internal(plVar2 + 6,lVar6);
                  local_34[0] = this.itemLv;
                  lVar6 = il2cpp_value_box(DAT_181d80418,local_34);
                  if ((lVar6 != null) &&
                     (lVar3 = il2cpp_internal(lVar6,*(uint64 *)(*plVar2 + 64))) == null) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar8,0);
                  }
                  if (3 < *(uint32 *)(plVar2 + 3)) {
                    plVar2[7] = lVar6;
                    il2cpp_internal(plVar2 + 7,lVar6);
                    uVar8 = String.Format("{0}_{1}_{2}_{3}",plVar2,0);
                    return uVar8;
                  }
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar8,0);
                }
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (local_res8[0] - 1U < 4) {
            local_res18[0] = local_res8[0];
            uVar8 = il2cpp_value_box(DAT_181d80418,local_res18);
            if (this.equipmentData == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_res20[0] = this.equipmentData.littleType;
            uVar7 = il2cpp_value_box(DAT_181d80418,local_res20);
            local_34[0] = this.itemLv;
            uVar4 = il2cpp_value_box(DAT_181d80418,local_34);
            uVar8 = String.Format("{0}_{1}_{2}",uVar8,uVar7,uVar4,0);
          }
          break;
        case 3:
          if ((this.bookData != null) &&
             (lVar6 = BookData.DataBase(this.bookData,0)) != null) {
            local_res18[0] = *(int *)(lVar6 + 24);
            uVar8 = il2cpp_value_box(DAT_181d80418,local_res18);
            if ((this.bookData != null) &&
               (lVar6 = BookData.DataBase(this.bookData,0), uVar7 = "book_{0}_{1}",
               lVar6 != null)) {
              if (*(int *)(lVar6 + 24) == -1) {
                if ((this.bookData == null) ||
                   (lVar6 = BookData.DataBase(this.bookData,0)) == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                local_res20[0] = *(uint32 *)(lVar6 + 48);
                uVar4 = il2cpp_value_box(DAT_181d80418,local_res20);
                local_34[0] = (int)((float)this.itemLv * 0.5);
                uVar5 = il2cpp_value_box(DAT_181d80418,local_34);
                uVar4 = String.Format("{0}_{1}",uVar4,uVar5,0);
              }
              else {
                local_res8[0] = (int)((float)this.itemLv * 0.5);
                uVar4 = Int32.ToString(local_res8,0);
              }
              uVar8 = String.Format(uVar7,uVar8,uVar4,0);
              return uVar8;
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        case 4:
          if (**(int **)(DAT_181d73d40 + 184) == 2) {
            lVar6 = *(int64 *)(pStatics + 0x518);
            if ((lVar6 == null) ||
               (lVar6 = FUN_180127f90(lVar6,(int64)this.subType,
                                      (int64)this.itemLv), lVar6 == null))
            goto LAB_180c9e459;
            cVar1 = String.Contains(lVar6,"呕血谱",0);
            if (cVar1) {
              return "玄玄谱";
            }
          }
          local_res18[0] = this.subType;
          uVar8 = il2cpp_value_box(DAT_181d80418,local_res18);
          local_res20[0] = this.itemLv;
          uVar7 = il2cpp_value_box(DAT_181d80418,local_res20);
          uVar8 = String.Format("珍宝{0}_{1}",uVar8,uVar7,0);
          break;
        case 5:
          lVar6 = *(int64 *)(pStatics + 0x538);
          if (lVar6 == null) {
        LAB_180c9e459:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar8 = FUN_180002f80(lVar6,this.subType,DAT_181da4358);
          uVar7 = Int32.ToString(this + 60,0);
          uVar8 = String.Concat(uVar8,"_",uVar7,0);
          break;
        case 6:
          if (this.subType == 1) {
            uVar8 = Int32.ToString(this + 60,0);
            uVar8 = String.Concat("鞍具",uVar8,0);
            return uVar8;
          }
        case 1:
        case 2:
          uVar8 = this.name;
        }
        return uVar8;
    }

    // Token : 0x60012CC
    // RVA   : 0xC9D110   Offset: 0xC9C510   Length: 0x15C
    public void AutoManageEquipPoison(int heroLv)
    {
        long lVar1;
        float fVar2;
        float fVar3;
        fVar3 = this.poisonNum;
        if (0.0 < fVar3) {
          fVar2 = (float)GlobalData.RandomRange();
          fVar2 = fVar2 * fVar3;
          this.poisonNum = fVar2;
          if (fVar2 < (float)(heroLv * 5 + 6)) {
            this.poisonNum = 0;
          }
        }
        if ((this.equipmentData != null) &&
           (lVar1 = this.equipmentData.equipPoisonData) != null) {
          fVar3 = *(float *)(lVar1 + 16);
          if (0.0 < fVar3) {
            fVar2 = (float)GlobalData.RandomRange();
            *(float *)(lVar1 + 16) = fVar2 * fVar3;
            if ((this.equipmentData == null) ||
               (lVar1 = this.equipmentData.equipPoisonData) == null)
            throw; // [null/range check failed]
            fVar3 = (float)(heroLv * 5 + 6);
            if (*(float *)(lVar1 + 16) <= fVar3 && fVar3 != *(float *)(lVar1 + 16)) {
              *(uint32 *)(lVar1 + 16) = 0;
            }
          }
          return;
        }
    }

    // Token : 0x60012CD
    // RVA   : 0xC9D8F0   Offset: 0xC9CCF0   Length: 0x117
    public bool DetectPoisonNum()
    {
        long lVar1;
        if (this.poisonNumDetected) {
          return true;
        }
        if ((((GameController._instance != null) &&
             (lVar1 = GameController._instance.worldData) != null) &&
            (lVar1 = WorldData.Player(lVar1,0)) != null) &&
           (lVar1 = lVar1.showRoomChangeFame) != null) {
          if (lVar1.cityAreaID < 2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (this.poisonNum <= *(float *)(lVar1.chapter + 36)) {
            return true;
          }
          return false;
        }
    }

    // Token : 0x60012CE
    // RVA   : 0xC9E480   Offset: 0xC9D880   Length: 0xC4
    public string GetItemSoundName()
    {
        int iVar1;
        ulong uVar2;
        uint[] local_res8 = new uint[8];
        switch(this.type) {
        case 0:
          uVar2 = "WeaponSharp";
          if (this.subType != null) {
            uVar2 = "Armor";
          }
          return uVar2;
        case 1:
          return "Med";
        case 2:
          if (this.subType == null) {
            return "Food";
          }
          if (this.subType == 1) {
            return "Wine";
          }
          break;
        case 3:
        switchD_180c9e54b_caseD_3:
          return "OpenBook";
        case 4:
          switch(this.subType) {
          case 0:
          case 4:
            return "Wood";
          case 1:
          case 5:
            return "Bag";
          case 2:
          case 3:
            return "Paper";
          case 6:
          case 7:
            return "Rock";
          case 8:
          case 9:
            goto switchD_180c9e54b_caseD_3;
          }
          break;
        case 5:
          iVar1 = this.subType;
          if (iVar1 == 0) {
            return "Wood";
          }
          if (iVar1 == 1) {
            return "Rock";
          }
          if (iVar1 == 2) {
            return "Med";
          }
          if (iVar1 != 3) {
            if (iVar1 != 4) {
              return 0;
            }
            return "Food";
          }
          return "Food";
        case 6:
          if (this.subType == null) {
            local_res8[0] = GlobalData.RandomRange(0,4,0);
            uVar2 = Int32.ToString(local_res8,0);
            uVar2 = String.Concat("Horse/Horse",uVar2,0);
            return uVar2;
          }
          if (this.subType == 1) {
            return "Armor";
          }
        }
        return 0;
    }

    // Token : 0x60012CF
    // RVA   : 0xC9F6A0   Offset: 0xC9EAA0   Length: 0x2A4
    public void PlayItemSound()
    {
        int iVar1;
        ulong uVar3;
        uint[] local_res8 = new uint[2];
        plVar5 = (int64 *)0;
        local_res8[0] = 0;
        plVar4 = "Food";
        switch(this.type) {
        case 0:
          plVar4 = "WeaponSharp";
          if (this.subType != null) {
            plVar4 = "Armor";
          }
          break;
        case 2:
          iVar1 = this.subType;
          plVar2 = "Wine";
          if (iVar1 == 0) break;
          goto joined_r0x000180c9f8da;
        case 3:
        switchD_180c9f7a9_caseD_3:
          plVar4 = "OpenBook";
          break;
        case 4:
          switch(this.subType) {
          case 0:
          case 4:
        switchD_180c9f819_caseD_0:
            plVar4 = "Wood";
            break;
          case 1:
          case 5:
            plVar4 = "Bag";
            break;
          case 2:
          case 3:
            plVar4 = "Paper";
            break;
          case 6:
          case 7:
        switchD_180c9f819_caseD_6:
            plVar4 = "Rock";
            break;
          case 8:
          case 9:
            goto switchD_180c9f7a9_caseD_3;
          default:
            goto switchD_180c9f7a9_default;
          }
          break;
        case 5:
          iVar1 = this.subType;
          if (iVar1 == 0) goto switchD_180c9f819_caseD_0;
          if (iVar1 == 1) goto switchD_180c9f819_caseD_6;
          if (iVar1 != 2) {
            if ((iVar1 == 3) || (iVar1 == 4)) break;
            goto switchD_180c9f7a9_default;
          }
        case 1:
          plVar4 = "Med";
          break;
        case 6:
          iVar1 = this.subType;
          plVar2 = "Armor";
          if (iVar1 == 0) {
            local_res8[0] = GlobalData.RandomRange(0,4,0);
            uVar3 = Int32.ToString(local_res8,0);
            plVar4 = (int64 *)String.Concat("Horse/Horse",uVar3,0);
            break;
          }
        joined_r0x000180c9f8da:
          plVar4 = plVar2;
          if (iVar1 != 1) {
        switchD_180c9f7a9_default:
            plVar4 = plVar5;
          }
          break;
        default:
          goto switchD_180c9f7a9_default;
        }
        uVar3 = String.Concat("Sound/SoundEffect/",plVar4,0);
        plVar4 = (int64 *)Resources.Load(uVar3,0);
        if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181daf348)) {
          plVar5 = plVar4;
        }
        NGUITools.PlaySound(plVar5,0);
    }

    // Token : 0x60012D0
    // RVA   : 0xC9E6E0   Offset: 0xC9DAE0   Length: 0x80
    public string GetItemTypeDescribe(bool italic)
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        uint uVar4;
        long lVar5;
        uVar2 = "";
        switch(this.type) {
        case 0:
        case 1:
        case 2:
        case 5:
        case 6:
          lVar1 = *(int64 *)(pStatics + 0x4f0);
          if (lVar1 == null) goto LAB_180c9e987;
          uVar4 = this.itemLv;
          if (*(uint32 *)(lVar1 + 24) <= uVar4) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar2 = lVar1[uVar4];
          uVar3 = GlobalData.GetItemTypeString
                            (this.type,this.subType,0);
          uVar2 = String.Concat(uVar2,uVar3,0);
          uVar2 = GlobalData.GenerateRareLvColorText(uVar2,this.itemLv,0);
          lVar1 = *(int64 *)(pStatics + 0x508);
          break;
        case 3:
          if ((this.bookData == null) ||
             (lVar1 = BookData.DataBase(this.bookData,0)) == null)
          goto LAB_180c9e987;
          uVar2 = KungfuSkillData.TypeDescribe(lVar1,0);
          lVar1 = *(int64 *)(pStatics + 0x500);
          break;
        case 4:
          lVar1 = *(int64 *)(pStatics + 0x4f0);
          if (lVar1 == null) goto LAB_180c9e987;
          uVar2 = FUN_180002f80(lVar1,this.itemLv,DAT_181da4358);
          uVar3 = GlobalData.GetItemTypeString
                            (this.type,this.subType,0);
          uVar2 = String.Concat(uVar2,uVar3,0);
          uVar2 = GlobalData.GenerateRareLvColorText(uVar2,this.itemLv,0);
        default:
          goto switchD_180c9e767_default;
        }
        uVar4 = this.rareLv;
        lVar5 = (int64)(int)uVar4;
        if (lVar1 == null) {
        LAB_180c9e987:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (*(uint32 *)(lVar1 + 24) <= uVar4) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0,uVar4);
          uVar4 = this.rareLv;
        }
        uVar3 = GlobalData.GenerateRareLvColorText
                          (*(uint64 *)(*(int64 *)(lVar1 + 16) + 32 + lVar5 * 8),uVar4,0);
        uVar2 = String.Concat(uVar2,uVar3,0);
        switchD_180c9e767_default:
        if (italic) {
          uVar2 = String.Format("<i>{0}</i>",uVar2,0);
        }
        return uVar2;
    }

    // Token : 0x60012D1
    // RVA   : 0xC9DBA0   Offset: 0xC9CFA0   Length: 0xAF
    public string GetBookRareLvName()
    {
        long lVar1;
        uint uVar2;
        long lVar3;
        uVar2 = this.rareLv;
        lVar3 = (int64)(int)uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x500);
        if (lVar1 != null) {
          if (*(uint32 *)(lVar1 + 24) <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0,uVar2);
            uVar2 = this.rareLv;
          }
          GlobalData.GenerateRareLvColorText
                    (*(uint64 *)(*(int64 *)(lVar1 + 16) + 32 + lVar3 * 8),uVar2,0);
          return;
        }
    }

    // Token : 0x60012D2
    // RVA   : 0xC9D270   Offset: 0xC9C670   Length: 0xD
    public float BadFame(float rate)
    {
        return (float)this.value * rate;
    }

    // Token : 0x60012D3
    // RVA   : 0xC9EB20   Offset: 0xC9DF20   Length: 0x30
    public float GetShowRoomFameChange(float rate)
    {
        if (this.type == 4) {
          return (float)this.value * 0.01 * rate;
        }
        return (float)this.value * 0.0025 * rate;
    }

    // Token : 0x60012D4
    // RVA   : 0xC9DA10   Offset: 0xC9CE10   Length: 0x47
    public bool Equiped()
    {
        uint uVar1;
        ulong uVar2;
        uVar1 = this.type;
        uVar2 = (uint64)uVar1;
        if (uVar1 == 0) {
          uVar2 = this.equipmentData;
          if (uVar2 == 0) {
        LAB_180c9da52:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (uVar2.equiped) {
            return CONCAT71((int7)(uVar2 >> 8),1);
          }
        }
        else if (uVar1 == 6) {
          if (this.horseData != null) {
            return (uint64)this.horseData.equiped;
          }
          goto LAB_180c9da52;
        }
        return uVar2 & 0xffffffffffffff00;
    }

    // Token : 0x60012D5
    // RVA   : 0xC9FCE0   Offset: 0xC9F0E0   Length: 0x115
    public ItemData SetMaterialData(int _subType, int _itemLv, int _rareLv)
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
        long lVar1;
        ulong uVar2;
        this.subType = _subType;
        this.itemLv = _itemLv;
        this.rareLv = _rareLv;
        lVar1 = *(int64 *)(pStatics + 0x4f0);
        if (lVar1 != null) {
          if (*(uint32 *)(lVar1 + 24) <= _itemLv) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar2 = lVar1[_itemLv];
          lVar1 = *(int64 *)(pStatics + 0x538);
          if (lVar1 != null) {
            if (*(uint32 *)(lVar1 + 24) <= _subType) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar2 = String.Concat(uVar2,*(uint64 *)
                                          (*(int64 *)(lVar1 + 16) + 32 + (int64)(int)_subType * 8
                                          ),0);
            this.name = uVar2;
            ItemData.CountValueAndWeight(this,0);
            return this;
          }
        }
    }

    // Token : 0x60012D6
    // RVA   : 0xC9E9B0   Offset: 0xC9DDB0   Length: 0x5A
    public float GetMaterialExtraCraftRate()
    {
        float fVar1;
        float fVar2;
        fVar1 = (float)Mathf.Max(this,(float)this.itemLv * 0.2,0);
        if (this.itemLv == null) {
          fVar2 = 0.02;
        }
        else {
          fVar2 = 0.04;
        }
        return (float)this.rareLv * fVar2 + fVar1;
    }

    // Token : 0x60012D7
    // RVA   : 0xC9FBD0   Offset: 0xC9EFD0   Length: 0x102
    public ItemData SetBookData(int _skillID, int _rareLv)
    {
        uint uVar1;
        long lVar2;
        if (this.bookData != null) {
          this.bookData.skillID = _skillID;
          lVar2 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x500);
          if (lVar2 != null) {
            uVar1 = Mathf.Clamp(_rareLv,0,*(int *)(lVar2 + 24) + -1,0);
            this.rareLv = uVar1;
            if (this.bookData != null) {
              lVar2 = BookData.DataBase(this.bookData,0);
              if (lVar2 != null) {
                this.name = *(uint64 *)(lVar2 + 32);
                if (this.bookData != null) {
                  lVar2 = BookData.DataBase(this.bookData,0);
                  if (lVar2 != null) {
                    this.itemLv = *(uint32 *)(lVar2 + 52);
                    ItemData.CountValueAndWeight(this,0);
                    return this;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60012D8
    // RVA   : 0xC9FE00   Offset: 0xC9F200   Length: 0x752
    public ItemData SetTreasureData(int _subType, int _itemLv, int _rareLv)
    {
        float fVar1;
        long lVar2;
        uint uVar3;
        uint uVar4;
        int iVar5;
        uint uVar6;
        int iVar7;
        long lVar8;
        ulong uVar9;
        ulong uVar10;
        ulong uVar11;
        uVar3 = Mathf.Clamp(_itemLv,0,5);
        this.itemLv = uVar3;
        this.subType = _subType;
        lVar8 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x518);
        if (lVar8 != null) {
          if (*lVar8.fullIdentified <= _subType) {
            uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar9,0);
          }
          lVar2 = *(int64 *)(lVar8.fullIdentified + 4);
          if ((uint32)lVar2 <= uVar3) {
            uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar9,0);
          }
          this.name =
               *(uint64 *)(lVar8 + 32 + ((int)_subType * lVar2 + (int64)(int)uVar3) * 8);
          il2cpp_internal();
          GlobalData.RandomRangeDouble(0,0);
          uVar4 = Mathf.RoundToInt();
          iVar5 = Mathf.Min(20,uVar4);
          uVar4 = Mathf.RoundToInt((float)iVar5 * 0.25,0);
          this.rareLv = uVar4;
          lVar8 = il2cpp_internal(DAT_181d93cd0);
          FUN_18132faf0(lVar8,DAT_181d8f098);
          if (lVar8 != null) {
            FUN_18182a0b0(lVar8,0,DAT_181d8f218);
            FUN_18182a0b0(lVar8,1,DAT_181d8f218);
            FUN_18182a0b0(lVar8,2,DAT_181d8f218);
            FUN_18182a0b0(lVar8,3,DAT_181d8f218);
            for (; 0 < iVar5; iVar5 = iVar5 + -1) {
              uVar4 = lVar8.treasureLv;
              uVar4 = GlobalData.RandomRange(0,uVar4,0,0);
              if (this.treasureData == null) throw; // [null/range check failed]
              lVar2 = this.treasureData.treasureLv;
              uVar6 = FUN_1800d6760(lVar8,uVar4,DAT_181d8fa18);
              if (lVar2 == null) throw; // [null/range check failed]
              iVar7 = FUN_1800d6760(lVar2,uVar6,DAT_181d8fa18);
              FUN_181833d40(lVar2,uVar6,iVar7 + 1);
              if (this.treasureData == null) throw; // [null/range check failed]
              lVar2 = this.treasureData.treasureLv;
              uVar6 = FUN_1800d6760(lVar8,uVar4,DAT_181d8fa18);
              if (lVar2 == null) throw; // [null/range check failed]
              iVar7 = FUN_1800d6760(lVar2,uVar6);
              if (4 < iVar7) {
                FUN_1817eed70(lVar8,uVar4);
              }
            }
            lVar8 = this.treasureData;
            uVar11 = 0;
            uVar10 = uVar11;
            while( true ) {
              if (((lVar8 == null) || (lVar8.treasureLv == null)) || (lVar8 == null))
              throw; // [null/range check failed]
              if (*(int *)(lVar8.treasureLv + 24) <= (int)uVar10) break;
              lVar8 = lVar8.identifyDifficulty;
              GlobalData.RandomRange(10,26,0);
              if (lVar8 == null) throw; // [null/range check failed]
              FUN_181829d40(lVar8,uVar10);
              lVar8 = this.treasureData;
              uVar10 = (uint64)((int)uVar10 + 1);
            }
            lVar8 = lVar8.identifyDifficulty;
            if (lVar8 != null) {
              uVar4 = lVar8.treasureLv;
              uVar3 = GlobalData.RandomRange(0,uVar4,0,0);
              if (lVar8.treasureLv <= uVar3) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              fVar1 = lVar8.fullIdentified[uVar3];
              iVar5 = GlobalData.RandomRange(0,5,0);
              FUN_181829d40(lVar8,uVar3,(float)(this.itemLv + iVar5) + fVar1,DAT_181da10f8);
              if ((this.treasureData != null) &&
                 (lVar8 = this.treasureData.identifyDifficulty) != null) {
                uVar3 = GlobalData.RandomRange(0,lVar8.treasureLv,0,0);
                if ((this.treasureData != null) &&
                   (lVar8 = this.treasureData.identifyDifficulty) != null) {
                  if (lVar8.treasureLv <= uVar3) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  GlobalData.RandomRange(0,5,0);
                  Mathf.Max();
                  FUN_181829d40(lVar8,uVar3);
                  lVar8 = il2cpp_internal(DAT_181d93cd0);
                  FUN_18132faf0(lVar8,DAT_181d8f098);
                  if (lVar8 != null) {
                    FUN_18182a0b0(lVar8,0,DAT_181d8f218);
                    FUN_18182a0b0(lVar8,1,DAT_181d8f218);
                    FUN_18182a0b0(lVar8,2,DAT_181d8f218);
                    FUN_18182a0b0(lVar8,3,DAT_181d8f218);
                    iVar5 = GlobalData.RandomRange(~this.rareLv,3,0);
                    uVar10 = uVar11;
                    if (iVar5 < 1) goto LAB_180ca044d;
                    goto LAB_180ca03c0;
                  }
                }
              }
            }
          }
        }
        throw; // [null/range check failed]
        while( true ) {
          FUN_1817f42f0(lVar2,uVar4,1);
          FUN_1817eee00(lVar8,uVar4);
          uVar3 = (int)uVar10 + 1;
          uVar10 = (uint64)uVar3;
          if (iVar5 <= (int)uVar3) break;
        LAB_180ca03c0:
          uVar4 = lVar8.treasureLv;
          uVar4 = GlobalData.RandomRange(0,uVar4,0,0);
          uVar4 = FUN_1800d6760(lVar8,uVar4,DAT_181d8fa18);
          if ((this.treasureData == null) ||
             (lVar2 = this.treasureData.identified) == null)
          throw; // [null/range check failed]
        }
        LAB_180ca044d:
        lVar8 = this.treasureData;
        uVar10 = uVar11;
        if (lVar8 != null) {
          while (lVar8.identifyDifficulty != null) {
            uVar3 = (uint32)uVar11;
            if (*(int *)(lVar8.identifyDifficulty + 24) <= (int)uVar3) {
              ItemData.CountValueAndWeight(this,0);
              return this;
            }
            if ((lVar8 == null) || (lVar2 = lVar8.identified) == null) break;
            if (*(uint32 *)(lVar2 + 24) <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(char *)(*(int64 *)(lVar2 + 16) + 32 + uVar10) == false) {
              if ((this.treasureData == null) ||
                 (lVar2 = this.treasureData.identifyDifficulty) == null) break;
              FUN_1800d6790(lVar2,uVar11,DAT_181da1078);
            }
            uVar4 = Mathf.Max();
            lVar8.identifyKnowledgeNeed = uVar4;
            uVar11 = (uint64)(uVar3 + 1);
            lVar8 = this.treasureData;
            uVar10 = uVar10 + 1;
            if (lVar8 == null) break;
          }
        }
    }

    // Token : 0x60012D9
    // RVA   : 0xC9F990   Offset: 0xC9ED90   Length: 0x233
    public void RecountRareLv()
    {
        int iVar1;
        int iVar2;
        long lVar3;
        float fVar4;
        fVar4 = 0.0;
        if (this.type == null) {
          if (this.equipmentData == null) throw; // [null/range check failed]
          lVar3 = this.equipmentData.extraAddData;
        LAB_180c9fa23:
          if (lVar3 == null) throw; // [null/range check failed]
          fVar4 = (float)HeroSpeAddData.GetValue(lVar3,0);
        }
        else if (this.type == 5) {
          if (this.materialData == null) throw; // [null/range check failed]
          lVar3 = this.materialData.extraAddData;
          goto LAB_180c9fa23;
        }
        lVar3 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
        if ((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 56)) != null) {
          iVar1 = *(int *)(lVar3 + 24);
          while( true ) {
            iVar1 = iVar1 + -1;
            if (iVar1 < 0) {
              return;
            }
            lVar3 = FUN_18046c100(0);
            if ((((lVar3 == null) || (*(int64 *)(lVar3 + 56) == 0)) ||
                (lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 56),this.itemLv,
                                       DAT_181d9e108), lVar3 == null)) ||
               (lVar3 = *(int64 *)(lVar3 + 48)) == null) break;
            if (*(int *)(lVar3 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            iVar2 = *(int *)(*(int64 *)(lVar3 + 16) + 32);
            lVar3 = FUN_18046c100(0);
            if (((lVar3 == null) || (*(int64 *)(lVar3 + 56) == 0)) ||
               ((lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 56),iVar1,DAT_181d9e108), lVar3 == null ||
                (lVar3 = *(int64 *)(lVar3 + 48)) == null))) break;
            if (*(int *)(lVar3 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if ((float)(*(int *)(*(int64 *)(lVar3 + 16) + 32) + iVar2) <= fVar4) {
              this.rareLv = iVar1;
              return;
            }
          }
        }
    }

    // Token : 0x60012DA
    // RVA   : 0xC9D400   Offset: 0xC9C800   Length: 0x4CC
    public float CountValueAndWeight()
    {
        int iVar1;
        uint uVar2;
        long lVar3;
        float fVar4;
        float fVar5;
        float fVar6;
        float fVar7;
        switch(this.type) {
        case 0:
          if ((this.equipmentData == null) ||
             (lVar3 = this.equipmentData.extraAddData) == null)
          goto LAB_180c9d8c5;
          HeroSpeAddData.GetValue(lVar3,0);
          if (this.subType == null) {
            fVar6 = 200.0;
          }
          else {
            fVar6 = 100.0;
          }
          fVar4 = (float)FUN_1801f8ab0();
          fVar7 = 1.0;
          fVar5 = (float)Mathf.Max();
          lVar3 = this.equipmentData;
          if (lVar3 == null) goto LAB_180c9d8c5;
          uVar2 = Mathf.RoundToInt(((float)lVar3.enhanceLv * 0.2 + 1.0) * fVar4 * fVar6 * fVar5 *
                                    ((float)lVar3.speEnhanceLv * 0.1 + 1.0),0);
          this.value = uVar2;
          lVar3 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x5d8);
          if (lVar3 == null) goto LAB_180c9d8c5;
          fVar4 = (float)FUN_1800d6790(lVar3,this.subType,DAT_181da1078);
          iVar1 = this.itemLv;
          lVar3 = this.equipmentData;
          if ((this.subType & 0xfffffffb) == 0) {
            if (lVar3 == null) goto LAB_180c9d8c5;
          }
          else {
            if (lVar3 == null) goto LAB_180c9d8c5;
            fVar7 = (float)lVar3.littleType * 0.1 + 0.5;
          }
          fVar6 = (float)FUN_1801f8ab0();
          fVar6 = fVar6 * (float)(iVar1 + 1) * fVar4 * fVar7;
          goto LAB_180c9d89c;
        case 1:
          lVar3 = FUN_18046c100(0);
          if (lVar3 == null) goto LAB_180c9d8c5;
          lVar3 = *(int64 *)(lVar3 + 0x110);
          goto LAB_180c9d64c;
        case 2:
          lVar3 = FUN_18046c100(0);
          if (lVar3 == null) goto LAB_180c9d8c5;
          lVar3 = *(int64 *)(lVar3 + 0x118);
        LAB_180c9d64c:
          if ((lVar3 == null) ||
             (lVar3 = FUN_1817d9e10(lVar3,this.itemID,DAT_181dbc1c0)) == null) {
        LAB_180c9d8c5:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (this.medFoodData == null) goto LAB_180c9d8c5;
          uVar2 = Mathf.RoundToInt(((float)this.rareLv * 0.2 + 1.0) *
                                    (float)lVar3.animName *
                                    ((float)this.medFoodData.enhanceLv * 0.2 + 1.0),0)
          ;
          this.value = uVar2;
          fVar6 = (float)(int)((float)this.itemLv * 0.5 + 1.0);
          goto LAB_180c9d89c;
        case 3:
          FUN_1801f8ab0();
          goto LAB_180c9d741;
        case 4:
          uVar2 = ItemData.GetTreasureValue(this,0,0);
          this.value = uVar2;
          iVar1 = this.itemLv * 2 + 2;
          break;
        case 5:
          FUN_1801f8ab0();
        LAB_180c9d741:
          uVar2 = Mathf.RoundToInt();
          this.value = uVar2;
          iVar1 = this.itemLv + 1;
          break;
        case 6:
          if (this.subType == null) {
            lVar3 = FUN_18046c100(0);
            if (((lVar3 == null) || (*(int64 *)(lVar3 + 0x120) == 0)) ||
               (lVar3 = FUN_1817d9e10(*(int64 *)(lVar3 + 0x120),this.itemID,
                                      DAT_181dbc1c0), lVar3 == null)) goto LAB_180c9d8c5;
            fVar6 = (float)lVar3.animName;
          }
          else {
            fVar6 = (float)FUN_1801f8ab0();
            fVar6 = fVar6 * 100.0;
          }
          uVar2 = Mathf.RoundToInt(((float)this.rareLv * 0.2 + 1.0) * fVar6,0);
          this.value = uVar2;
          if (this.subType == null) {
            iVar1 = (this.itemLv + 1) * 5;
          }
          else {
            iVar1 = this.itemLv * 2 + 2;
          }
          break;
        default:
          goto switchD_180c9d47d_default;
        }
        fVar6 = (float)iVar1;
        LAB_180c9d89c:
        this.weight = fVar6;
        switchD_180c9d47d_default:
    }

    // Token : 0x60012DB
    // RVA   : 0xC9EC90   Offset: 0xC9E090   Length: 0x201
    public int GetTreasureValue(bool guess)
    {
        int iVar1;
        long lVar2;
        ulong uVar3;
        uint uVar4;
        ulong uVar5;
        ulong uVar6;
        float fVar7;
        byte[] auVar8 = new byte[16];
        byte[] auVar9 = new byte[16];
        float fVar10;
        uint64 extraout_XMM0_Qb;
        lVar2 = this.treasureData;
        uVar5 = 0;
        fVar10 = 1.0;
        uVar6 = uVar5;
        if (lVar2 != null) {
          while (lVar2.treasureLv != null) {
            uVar4 = (uint32)uVar6;
            if (*(int *)(lVar2.treasureLv + 24) <= (int)uVar4) {
              auVar8._0_8_ = FUN_1801f8ab0();
              auVar8._8_8_ = extraout_XMM0_Qb;
              auVar9._4_12_ = auVar8._4_12_;
              auVar9._0_4_ = (float)auVar8._0_8_ * 100.0 * fVar10;
              Mathf.RoundToInt(auVar9._0_8_,0);
              return;
            }
            if ((lVar2 = lVar2?.identified) == null) break;
            if (lVar2.treasureLv <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(char *)(lVar2.fullIdentified + 32 + uVar5) == false) {
              if (!guess) {
                fVar7 = 0.0;
              }
              else {
                if ((this.treasureData == null) ||
                   (lVar2 = this.treasureData.playerGuessTreasureLv) == null) break;
                uVar3 = FUN_180002f80(lVar2,uVar6,DAT_181d789a8);
                fVar7 = (float)GlobalData.ListAverage(uVar3,0);
                fVar7 = fVar7 * 0.1;
              }
            }
            else {
              if ((this.treasureData == null) ||
                 (lVar2 = this.treasureData.treasureLv) == null) break;
              iVar1 = FUN_1800d6760(lVar2,uVar6,DAT_181d8fa18);
              fVar7 = (float)iVar1 * 0.1;
            }
            lVar2 = this.treasureData;
            uVar6 = (uint64)(uVar4 + 1);
            uVar5 = uVar5 + 1;
            fVar10 = fVar10 * (fVar7 + 0.8);
            if (lVar2 == null) break;
          }
        }
    }

    // Token : 0x60012DC
    // RVA   : 0xC9EB50   Offset: 0xC9DF50   Length: 0x139
    public int GetTreasureRealValue()
    {
        long lVar2;
        long lVar3;
        long lVar4;
        uint uVar5;
        byte[] auVar6 = new byte[16];
        byte[] auVar7 = new byte[16];
        float fVar8;
        uint64 extraout_XMM0_Qb;
        lVar3 = this.treasureData;
        fVar8 = 1.0;
        uVar5 = 0;
        if (lVar3 != null) {
          lVar4 = 32;
          while (lVar3.treasureLv != null) {
            if (*(int *)(lVar3.treasureLv + 24) <= (int)uVar5) {
              auVar6._0_8_ = FUN_1801f8ab0();
              auVar6._8_8_ = extraout_XMM0_Qb;
              auVar7._4_12_ = auVar6._4_12_;
              auVar7._0_4_ = (float)auVar6._0_8_ * 100.0 * fVar8;
              Mathf.RoundToInt(auVar7._0_8_,0);
              return;
            }
            if ((lVar3 == null) || (lVar2 = lVar3.treasureLv) == null) break;
            if (*(uint32 *)(lVar2 + 24) <= uVar5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              lVar3 = this.treasureData;
            }
            uVar5 = uVar5 + 1;
            piVar1 = (int *)(*(int64 *)(lVar2 + 16) + lVar4);
            lVar4 = lVar4 + 4;
            fVar8 = fVar8 * ((float)*piVar1 * 0.1 + 0.8);
            if (lVar3 == null) break;
          }
        }
    }

    // Token : 0x60012DD
    // RVA   : 0xC9DC50   Offset: 0xC9D050   Length: 0xFA
    public int GetContributionCost(int heroID)
    {
        long lVar1;
        ulong uVar2;
        if ((GameController._instance != null) &&
           (lVar1 = GameController._instance.worldData) != null) {
          lVar1 = WorldData.GetHero(lVar1,heroID,0);
          if (lVar1 != null) {
            if (lVar1.hour) {
              return 0;
            }
            uVar2 = Mathf.RoundToInt((float)this.value * 0.1,0);
            return uVar2;
          }
        }
    }

    // Token : 0x60012DE
    // RVA   : 0xC9DD50   Offset: 0xC9D150   Length: 0x17
    public int GetGovernContributionCost()
    {
        Mathf.RoundToInt((float)this.value * 0.1,0);
    }

    // Token : 0x60012DF
    // RVA   : 0xC9EA10   Offset: 0xC9DE10   Length: 0x107
    public int GetReadBookContributionCost(int heroID)
    {
        long lVar1;
        ulong uVar2;
        float fVar3;
        if ((GameController._instance != null) &&
           (lVar1 = GameController._instance.worldData) != null) {
          lVar1 = WorldData.GetHero(lVar1,heroID,0);
          if (lVar1 != null) {
            if (lVar1.hour) {
              return 0;
            }
            fVar3 = (float)FUN_1801f8ab0(0x40000000);
            uVar2 = Mathf.RoundToInt(fVar3 * 20.0,0);
            return uVar2;
          }
        }
    }

    // Token : 0x60012E0
    // RVA   : 0xC9DDA0   Offset: 0xC9D1A0   Length: 0x25
    public float GetHorseSeeRange()
    {
        return (float)this.rareLv * 0.02 + (float)this.itemLv * 0.1;
    }

    // Token : 0x60012E1
    // RVA   : 0xC9DDD0   Offset: 0xC9D1D0   Length: 0x25
    public float GetHorseStepAddRate()
    {
        return (float)this.rareLv * 0.01 + (float)this.itemLv * 0.05;
    }

    // Token : 0x60012E2
    // RVA   : 0xCA0560   Offset: 0xC9F960   Length: 0xC3
    public static bool TryIdentifyOneResult(float identifyKnowledge, float identifyDifficulty)
    {
        double dVar1;
        float fVar2;
        fVar2 = 0.0;
        identifyKnowledge = identifyKnowledge / identifyDifficulty;
        if (1.0 <= identifyKnowledge) {
          fVar2 = (identifyKnowledge + 0.1) - 1.0;
        }
        else if (0.9 < identifyKnowledge) {
          fVar2 = (identifyKnowledge - 0.9) * 0.5;
        }
        dVar1 = (double)GlobalData.RandomRangeDouble(0,0);
        return dVar1 <= (double)fVar2;
    }

    // Token : 0x60012E3
    // RVA   : 0xCA0630   Offset: 0xC9FA30   Length: 0x1FD
    public float TryIdentify(float identifyKnowledge)
    {
        bool cVar2;
        long lVar3;
        uint uVar4;
        ulong uVar5;
        ulong uVar6;
        lVar3 = this.treasureData;
        if (lVar3 != null) {
          if (lVar3.fullIdentified) {
            return;
          }
          uVar5 = 0;
          lVar3.fullIdentified = 1;
          lVar3 = this.treasureData;
          bVar1 = false;
          uVar6 = uVar5;
          if (lVar3 != null) {
            while (lVar3.treasureLv != null) {
              uVar4 = (uint32)uVar6;
              if (*(int *)(lVar3.treasureLv + 24) <= (int)uVar4) {
                if (!bVar1) {
                  return;
                }
                ItemData.CountValueAndWeight(this,0);
                return;
              }
              if ((lVar3 = lVar3?.identified) == null) break;
              if (lVar3.treasureLv <= uVar4) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (*(char *)(lVar3.fullIdentified + 32 + uVar5) == false) {
                if ((this.treasureData == null) ||
                   (lVar3 = this.treasureData.identifyDifficulty) == null) break;
                FUN_1800d6790(lVar3,uVar6,DAT_181da1078);
                cVar2 = ItemData.TryIdentifyOneResult();
                if (cVar2) {
                  bVar1 = true;
                  if ((this.treasureData == null) ||
                     (lVar3 = this.treasureData.identified) == null) break;
                  FUN_1817f42f0(lVar3,uVar6,1,DAT_181d80720);
                }
              }
              if ((this.treasureData == null) ||
                 (lVar3 = this.treasureData.identified) == null) break;
              cVar2 = FUN_180133a50(lVar3,uVar6,DAT_181d806a0);
              if (!cVar2) {
                if (this.treasureData == null) break;
                this.treasureData.fullIdentified = 0;
              }
              lVar3 = this.treasureData;
              uVar6 = (uint64)(uVar4 + 1);
              uVar5 = uVar5 + 1;
              if (lVar3 == null) break;
            }
          }
        }
    }

    // Token : 0x60012E4
    // RVA   : 0xC9DA60   Offset: 0xC9CE60   Length: 0x134
    public float FullIdentify()
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        lVar1 = this.treasureData;
        uVar3 = 0;
        if (lVar1 != null) {
          lVar2 = 0;
          while ((lVar1.treasureLv != null && (lVar1 != null))) {
            if (*(int *)(lVar1.treasureLv + 24) <= (int)uVar3) {
              lVar1.fullIdentified = 1;
              ItemData.CountValueAndWeight(this,0);
              return;
            }
            lVar1 = lVar1.identified;
            if (lVar1 == null) break;
            if (lVar1.treasureLv <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(char *)(lVar1.fullIdentified + 32 + lVar2) == false) {
              if ((this.treasureData == null) ||
                 (lVar1 = this.treasureData.identified) == null) break;
              FUN_1817f42f0(lVar1,uVar3,1,DAT_181d80720);
            }
            lVar1 = this.treasureData;
            uVar3 = uVar3 + 1;
            lVar2 = lVar2 + 1;
            if (lVar1 == null) break;
          }
        }
    }

    // Token : 0x60012E5
    // RVA   : 0xC9F180   Offset: 0xC9E580   Length: 0x3E2
    public void ManagePlayerGuessTreasureLv(float playerKnowledgeLv)
    {
        long lVar1;
        int iVar2;
        int iVar3;
        uint uVar4;
        long lVar5;
        long lVar6;
        int iVar7;
        uint uVar8;
        long lVar9;
        int iVar10;
        float fVar11;
        lVar5 = il2cpp_internal(DAT_181d93cd0);
        FUN_18132faf0(lVar5);
        lVar6 = this.treasureData;
        uVar8 = 0;
        if (lVar6 != null) {
          lVar9 = 32;
          while (lVar6.treasureLv != null) {
            if (*(int *)(lVar6.treasureLv + 24) <= (int)uVar8) {
              return;
            }
            if ((lVar6 = lVar6?.identifyDifficulty) == null) break;
            if (lVar6.treasureLv <= uVar8) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            fVar11 = playerKnowledgeLv / *(float *)(lVar6.fullIdentified + lVar9);
            if (1.0 <= fVar11) {
              iVar10 = 1;
            }
            else if (0.9 <= fVar11) {
              iVar10 = 2;
            }
            else if (0.8 <= fVar11) {
              iVar10 = 3;
            }
            else if (0.7 <= fVar11) {
              iVar10 = 4;
            }
            else {
              iVar10 = (fVar11 < 0.6) + 5;
            }
            while( true ) {
              if (((this.treasureData == null) ||
                  (lVar6 = this.treasureData.playerGuessTreasureLv) == null) ||
                 (lVar6 = FUN_180002f80(lVar6,uVar8,DAT_181d789a8)) == null) throw; // [null/range check failed]
              if (lVar6.treasureLv <= iVar10) break;
              if (lVar5 == null) throw; // [null/range check failed]
              FUN_1812f9a10(lVar5,DAT_181d8f318);
              iVar7 = 0;
              while( true ) {
                if (((this.treasureData == null) ||
                    (lVar6 = this.treasureData.playerGuessTreasureLv) == null) ||
                   (lVar6 = FUN_180002f80(lVar6,uVar8,DAT_181d789a8)) == null) throw; // [null/range check failed]
                lVar1 = this.treasureData;
                if (lVar6.treasureLv <= iVar7) break;
                if (((lVar1 == null) || (lVar1.playerGuessTreasureLv == null)) ||
                   (lVar6 = FUN_180002f80(lVar1.playerGuessTreasureLv,uVar8,DAT_181d789a8)) == null)
                throw; // [null/range check failed]
                iVar2 = FUN_1800d6760(lVar6,iVar7,DAT_181d8fa18);
                if ((this.treasureData == null) ||
                   (lVar6 = this.treasureData.treasureLv) == null)
                throw; // [null/range check failed]
                iVar3 = FUN_1800d6760(lVar6,uVar8,DAT_181d8fa18);
                if (iVar2 != iVar3) {
                  FUN_18182a0b0(lVar5,iVar7,DAT_181d8f218);
                }
                iVar7 = iVar7 + 1;
              }
              if ((lVar1 == null) || (lVar1.playerGuessTreasureLv == null)) throw; // [null/range check failed]
              lVar6 = FUN_180002f80(lVar1.playerGuessTreasureLv,uVar8,DAT_181d789a8);
              uVar4 = *(uint32 *)(lVar5 + 24);
              uVar4 = GlobalData.RandomRange(0,uVar4,0,0);
              uVar4 = FUN_1800d6760(lVar5,uVar4,DAT_181d8fa18);
              if (lVar6 == null) throw; // [null/range check failed]
              FUN_1817eed70(lVar6,uVar4,DAT_181d8f718);
            }
            lVar6 = this.treasureData;
            uVar8 = uVar8 + 1;
            lVar9 = lVar9 + 4;
            if (lVar6 == null) break;
          }
        }
    }

    // Token : 0x60012E6
    // RVA   : 0xC9F570   Offset: 0xC9E970   Length: 0x12F
    public string Name(bool colored)
    {
        uint uVar1;
        bool cVar2;
        ulong uVar3;
        if (**(int **)(DAT_181d73d40 + 184) == 2) {
        LAB_180c9f60a:
          cVar2 = FUN_180d755b0(this.checkName,0);
          if (!cVar2) {
            cVar2 = String.op_Inequality(this.checkName,"无",0);
            if (cVar2) {
              uVar3 = this.checkName;
              goto LAB_180c9f64f;
            }
          }
        }
        else {
          if (*(char *)(*(int64 *)(DAT_181d73d40 + 184) + 4) != false) goto LAB_180c9f60a;
        }
        cVar2 = FUN_180d755b0(this.setName,0);
        if (!cVar2) {
          uVar3 = this.setName;
        }
        else {
          uVar3 = this.name;
        }
        LAB_180c9f64f:
        if (colored) {
          uVar1 = this.itemLv;
          uVar3 = GlobalData.GenerateRareLvColorText(uVar3,uVar1,0);
          return uVar3;
        }
        return uVar3;
    }

    // Token : 0x60012E7
    // RVA   : 0xC9D280   Offset: 0xC9C680   Length: 0x175
    public virtual object Clone()
    {
        long lVar2;
        ulong uVar3;
        ulong local_38;
        ulong uStack_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        plVar1 = (int64 *)il2cpp_internal(DAT_181d89210);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181db1730);
        local_28 = (uint32)local_38;
        uStack_24 = local_38._4_4_;
        uStack_20 = (uint32)uStack_30;
        uStack_1c = uStack_30._4_4_;
        BinaryFormatter.ctor(lVar2,0,&local_28,0,plVar4);
        if (lVar2 != null) {
          BinaryFormatter.Serialize(lVar2,plVar1,this,0);
          if (plVar1 != (int64 *)0) {
            (**(code **)(*plVar1 + 0x2c8))(plVar1,0,0,*(uint64 *)(*plVar1 + 0x2d0));
            uVar3 = BinaryFormatter.Deserialize(lVar2,plVar1,0);
            (**(code **)(*plVar1 + 0x238))(plVar1,*(uint64 *)(*plVar1 + 0x240));
            FUN_180002970(0,DAT_181d78da0,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

}
