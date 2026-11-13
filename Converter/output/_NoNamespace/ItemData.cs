// ============================================================
// Type  : ItemData
// Token : 0x2000240
// ============================================================

public class ItemData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001203
    public int itemID;

    // Token: 0x4001204
    public ItemType type;

    // Token: 0x4001205
    public int subType;

    // Token: 0x4001206
    public string name;

    // Token: 0x4001207
    public string checkName;

    // Token: 0x4001208
    public string describe;

    // Token: 0x4001209
    public int value;

    // Token: 0x400120A
    public int itemLv;

    // Token: 0x400120B
    public int rareLv;

    // Token: 0x400120C
    public float weight;

    // Token: 0x400120D
    public bool isNew;

    // Token: 0x400120E
    public float poisonNum;

    // Token: 0x400120F
    public bool poisonNumDetected;

    // Token: 0x4001210
    public string setName;

    // Token: 0x4001211
    public EquipmentData equipmentData;

    // Token: 0x4001212
    public MedFoodData medFoodData;

    // Token: 0x4001213
    public BookData bookData;

    // Token: 0x4001214
    public TreasureData treasureData;

    // Token: 0x4001215
    public MaterialData materialData;

    // Token: 0x4001216
    public HorseData horseData;

    // Token: 0x4001217
    private static int itemFixupErrorCount;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60012DA
    // RVA   : 0xA24950   Offset: 0xA23750   Length: 0xE
    public void /*ctor*/()
    {
        ulong uVar1;
        this.weight = 0x3f800000;
        ZhSegment.Initialize(this,0);
        this.type = param_2;
        switch(param_2) {
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
          goto switchD_180a24856_default;
        }
        this.horseData = uVar1;
        il2cpp_internal(puVar2,uVar1);
        switchD_180a24856_default:
    }

    // Token : 0x60012DB
    // RVA   : 0xA247C0   Offset: 0xA235C0   Length: 0x174
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
          goto switchD_180a24856_default;
        }
        this.horseData = uVar1;
        il2cpp_internal(puVar2,uVar1);
        switchD_180a24856_default:
    }

    // Token : 0x60012DC
    // RVA   : 0xA20E40   Offset: 0xA1FC40   Length: 0x30
    public float GetHorseMaxWeightAdd()
    {
        if (this.subType != null) {
          return;
        }
    }

    // Token : 0x60012DD
    // RVA   : 0xA22080   Offset: 0xA20E80   Length: 0x22
    public int GetWeaponResearchExp()
    {
        float fVar1;
        fVar1 = (float)FUN_1801e6830(0x40000000);
        return (int)fVar1;
    }

    // Token : 0x60012DE
    // RVA   : 0xA220B0   Offset: 0xA20EB0   Length: 0x2A8
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
                if ((int)uVar2 <= (int)uVar5) goto LAB_180a22337;
                if (uVar2 <= uVar5) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar4 = *(int64 *)(lVar4 + 16);
                if (*(int64 *)(lVar6 + lVar4) == this) goto LAB_180a22300;
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
                if ((int)uVar2 <= (int)uVar5) goto LAB_180a22337;
                if (uVar2 <= uVar5) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar4 = *(int64 *)(lVar4 + 16);
                if (*(int64 *)(lVar6 + lVar4) == this) goto LAB_180a22300;
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
                if ((int)uVar2 <= (int)uVar5) goto LAB_180a22337;
                if (uVar2 <= uVar5) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar4 = *(int64 *)(lVar4 + 16);
                if (*(int64 *)(lVar6 + lVar4) == this) goto LAB_180a22300;
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
                if ((int)uVar2 <= (int)uVar5) goto LAB_180a22337;
                if (uVar2 <= uVar5) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar4 = *(int64 *)(lVar4 + 16);
                if (*(int64 *)(lVar6 + lVar4) == this) goto LAB_180a22300;
                uVar5 = uVar5 + 1;
                lVar6 = lVar6 + 8;
              }
            }
          }
          else {
            if (iVar1 != 4) goto LAB_180a22337;
            uVar5 = 0;
            if (targetHero != null) {
              lVar6 = 32;
              while ((*(int64 *)(targetHero + 0x1f8) != 0 &&
                     (lVar4 = *(int64 *)(*(int64 *)(targetHero + 0x1f8) + 128)) != null)) {
                uVar2 = *(uint32 *)(lVar4 + 24);
                uVar3 = (uint64)uVar2;
                if ((int)uVar2 <= (int)uVar5) goto LAB_180a22337;
                if (uVar2 <= uVar5) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar4 = *(int64 *)(lVar4 + 16);
                if (*(int64 *)(lVar6 + lVar4) == this) {
        LAB_180a22300:
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
        LAB_180a22337:
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
            if (uVar5 != 1) goto LAB_180a22337;
            if (targetHero != null) {
              return (uint64)(*(int64 *)(targetHero + 0x218) == this);
            }
          }
        }
    }

    // Token : 0x60012DF
    // RVA   : 0xA20ED0   Offset: 0xA1FCD0   Length: 0x668
    public string GetItemIconName()
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
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
            plVar2 = (int64 *)FUN_1801dfd90(DAT_181e84278,4);
            local_res18[0] = this.subType;
            lVar6 = il2cpp_value_box(DAT_181e60808,local_res18);
            if (plVar2 != (int64 *)0) {
              if ((lVar6 != null) &&
                 (lVar3 = il2cpp_internal(lVar6,*(uint64 *)(*plVar2 + 64))) == null) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar8,0);
              }
              if ((int)plVar2[3] == 0) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar8,0);
              }
              plVar2[4] = lVar6;
              il2cpp_internal(plVar2 + 4,lVar6);
              if (this.equipmentData != null) {
                local_res20[0] = this.equipmentData.littleType;
                lVar6 = il2cpp_value_box(DAT_181e60808,local_res20);
                if ((lVar6 != null) &&
                   (lVar3 = il2cpp_internal(lVar6,*(uint64 *)(*plVar2 + 64))) == null) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar8,0);
                }
                if (*(uint32 *)(plVar2 + 3) < 2) {
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar8,0);
                }
                plVar2[5] = lVar6;
                il2cpp_internal(plVar2 + 5,lVar6);
                if (this.equipmentData != null) {
                  local_38 = this.equipmentData.attriType;
                  lVar6 = il2cpp_value_box(DAT_181e60808,&local_38);
                  if ((lVar6 != null) &&
                     (lVar3 = il2cpp_internal(lVar6,*(uint64 *)(*plVar2 + 64))) == null) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar8,0);
                  }
                  if (*(uint32 *)(plVar2 + 3) < 3) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar8,0);
                  }
                  plVar2[6] = lVar6;
                  il2cpp_internal(plVar2 + 6,lVar6);
                  local_34[0] = this.itemLv;
                  lVar6 = il2cpp_value_box(DAT_181e60808,local_34);
                  if ((lVar6 != null) &&
                     (lVar3 = il2cpp_internal(lVar6,*(uint64 *)(*plVar2 + 64))) == null) {
                    uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar8,0);
                  }
                  if (3 < *(uint32 *)(plVar2 + 3)) {
                    plVar2[7] = lVar6;
                    il2cpp_internal(plVar2 + 7,lVar6);
                    uVar8 = String.Format("{0}_{1}_{2}_{3}",plVar2,0);
                    return uVar8;
                  }
                  uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar8,0);
                }
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          if (local_res8[0] - 1U < 4) {
            local_res18[0] = local_res8[0];
            uVar8 = il2cpp_value_box(DAT_181e60808,local_res18);
            if (this.equipmentData == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            local_res20[0] = this.equipmentData.littleType;
            uVar7 = il2cpp_value_box(DAT_181e60808,local_res20);
            local_34[0] = this.itemLv;
            uVar4 = il2cpp_value_box(DAT_181e60808,local_34);
            uVar8 = String.Format("{0}_{1}_{2}",uVar8,uVar7,uVar4,0);
          }
          break;
        case 3:
          if ((this.bookData != null) &&
             (lVar6 = BookData.DataBase(this.bookData,0)) != null) {
            local_res18[0] = *(int *)(lVar6 + 24);
            uVar8 = il2cpp_value_box(DAT_181e60808,local_res18);
            if ((this.bookData != null) &&
               (lVar6 = BookData.DataBase(this.bookData,0)) != null) {
              cVar1 = KungfuSkillData.HaveForce(lVar6,0);
              uVar7 = "book_{0}_{1}";
              if (!cVar1) {
                if ((this.bookData == null) ||
                   (lVar6 = BookData.DataBase(this.bookData,0)) == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                local_res20[0] = *(uint32 *)(lVar6 + 48);
                uVar4 = il2cpp_value_box(DAT_181e60808,local_res20);
                local_34[0] = (int)((float)this.itemLv * 0.5);
                uVar5 = il2cpp_value_box(DAT_181e60808,local_34);
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
          FUN_1801e0300();
        case 4:
          if (**(int **)(DAT_181e538e8 + 184) == 2) {
            lVar6 = *(int64 *)(pStatics + 0x538);
            if ((lVar6 == null) ||
               (lVar6 = FUN_1800540b0(lVar6,(int64)this.subType,
                                      (int64)this.itemLv), lVar6 == null))
            goto LAB_180a21531;
            cVar1 = String.Contains(lVar6,"呕血谱",0);
            if (cVar1) {
              return "玄玄谱";
            }
          }
          local_res18[0] = this.subType;
          uVar8 = il2cpp_value_box(DAT_181e60808,local_res18);
          local_res20[0] = this.itemLv;
          uVar7 = il2cpp_value_box(DAT_181e60808,local_res20);
          uVar8 = String.Format("珍宝{0}_{1}",uVar8,uVar7,0);
          break;
        case 5:
          lVar6 = *(int64 *)(pStatics + 0x558);
          if (lVar6 == null) {
        LAB_180a21531:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          uVar8 = FUN_1800024b0(lVar6,this.subType,DAT_181e86970);
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

    // Token : 0x60012E0
    // RVA   : 0xA1F380   Offset: 0xA1E180   Length: 0x15C
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

    // Token : 0x60012E1
    // RVA   : 0xA20570   Offset: 0xA1F370   Length: 0x117
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

    // Token : 0x60012E2
    // RVA   : 0xA21560   Offset: 0xA20360   Length: 0xC4
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
        switchD_180a2162b_caseD_3:
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
            goto switchD_180a2162b_caseD_3;
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

    // Token : 0x60012E3
    // RVA   : 0xA22CC0   Offset: 0xA21AC0   Length: 0x2A4
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
          goto joined_r0x000180a22efa;
        case 3:
        switchD_180a22dc9_caseD_3:
          plVar4 = "OpenBook";
          break;
        case 4:
          switch(this.subType) {
          case 0:
          case 4:
        switchD_180a22e39_caseD_0:
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
        switchD_180a22e39_caseD_6:
            plVar4 = "Rock";
            break;
          case 8:
          case 9:
            goto switchD_180a22dc9_caseD_3;
          default:
            goto switchD_180a22dc9_default;
          }
          break;
        case 5:
          iVar1 = this.subType;
          if (iVar1 == 0) goto switchD_180a22e39_caseD_0;
          if (iVar1 == 1) goto switchD_180a22e39_caseD_6;
          if (iVar1 != 2) {
            if ((iVar1 == 3) || (iVar1 == 4)) break;
            goto switchD_180a22dc9_default;
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
        joined_r0x000180a22efa:
          plVar4 = plVar2;
          if (iVar1 != 1) {
        switchD_180a22dc9_default:
            plVar4 = plVar5;
          }
          break;
        default:
          goto switchD_180a22dc9_default;
        }
        uVar3 = String.Concat("Sound/SoundEffect/",plVar4,0);
        plVar4 = (int64 *)Resources.Load(uVar3,0);
        if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181e8f4a0)) {
          plVar5 = plVar4;
        }
        NGUITools.PlaySound(plVar5,0);
    }

    // Token : 0x60012E4
    // RVA   : 0xA20A60   Offset: 0xA1F860   Length: 0x3B7
    public string GetEquipmentBaseTypeName()
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        int iVar1;
        int iVar2;
        bool cVar3;
        ulong uVar4;
        long lVar5;
        long local_res8;
        long[] local_res18 = new long[2];
        local_res18[0] = 0;
        local_res8 = 0;
        if (this.equipmentData == null) {
          return "";
        }
        uVar4 = *(uint64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32);
        cVar3 = Object.op_Equality(uVar4,0,0);
        if (cVar3) {
          return "";
        }
        iVar1 = this.subType;
        if (iVar1 == 0) {
          lVar5 = this.equipmentData;
          if (lVar5 != null) {
            iVar1 = lVar5.littleType;
            iVar2 = lVar5.attriType;
            lVar5 = FUN_180210740(0);
            if (lVar5 != null) {
              if (*(int64 *)(lVar5 + 240) == 0) {
                return "";
              }
              lVar5 = FUN_180210740(0);
              if ((lVar5 != null) && (*(int64 *)(lVar5 + 240) != 0)) {
                cVar3 = FUN_1806e3f90(*(int64 *)(lVar5 + 240),iVar2 + iVar1 * 6,local_res18,
                                      DAT_181e9d7b0);
                if (!cVar3) {
                  return "";
                }
                if (local_res18[0] != 0) {
                  return *(uint64 *)(local_res18[0] + 32);
                }
              }
            }
          }
        }
        else if (((iVar1 == 1) || (iVar1 == 2)) || (iVar1 == 3)) {
          if (iVar1 == 1) {
            lVar5 = FUN_180210740(0);
            if (lVar5 == null) throw; // [null/range check failed]
            lVar5 = *(int64 *)(lVar5 + 0x100);
          }
          else if (iVar1 == 2) {
            lVar5 = FUN_180210740(0);
            if (lVar5 == null) throw; // [null/range check failed]
            lVar5 = *(int64 *)(lVar5 + 0x108);
          }
          else {
            lVar5 = FUN_180210740(0);
            if (lVar5 == null) throw; // [null/range check failed]
            lVar5 = *(int64 *)(lVar5 + 0x110);
          }
          if (lVar5 == null) {
            return "";
          }
          if (this.equipmentData != null) {
            cVar3 = FUN_1806e3f90(lVar5,this.equipmentData.littleType,&local_res8,
                                  DAT_181e9d7b0);
            if (!cVar3) {
              return "";
            }
            if (local_res8 != 0) {
              return *(uint64 *)(local_res8 + 32);
            }
          }
        }
        else {
          if (iVar1 != 4) {
            return "";
          }
          if (this.equipmentData != null) {
            iVar1 = this.equipmentData.littleType;
            if (iVar1 < 0) {
              return "";
            }
            lVar5 = *(int64 *)(pStatics + 0x4e8);
            if (lVar5 != null) {
              if (lVar5.attriType <= iVar1) {
                return "";
              }
              lVar5 = *(int64 *)(pStatics + 0x4e8);
              if (lVar5 != null) {
                uVar4 = FUN_1800024b0(lVar5,iVar1,DAT_181e86970);
                return uVar4;
              }
            }
          }
        }
    }

    // Token : 0x60012E5
    // RVA   : 0xA217C0   Offset: 0xA205C0   Length: 0x80
    public string GetItemTypeDescribe(bool italic)
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        uint uVar1;
        uint uVar2;
        bool cVar3;
        ulong uVar4;
        long lVar5;
        ulong uVar6;
        uint uVar7;
        long lVar8;
        uVar4 = "";
        switch(this.type) {
        case 0:
          uVar4 = ItemData.GetEquipmentBaseTypeName(this,0);
          cVar3 = FUN_180ad1200(uVar4,0);
          if (cVar3) {
            uVar1 = this.type;
            uVar2 = this.subType;
            uVar4 = GlobalData.GetItemTypeString(uVar1,uVar2,0);
          }
          lVar5 = *(int64 *)(pStatics + 0x510);
          if (lVar5 == null) goto LAB_180a21b6b;
          uVar6 = FUN_1800024b0(lVar5,this.itemLv,DAT_181e86970);
          uVar4 = String.Concat(uVar6,uVar4,0);
          uVar4 = GlobalData.GenerateRareLvColorText(uVar4,this.itemLv,0);
          lVar5 = *(int64 *)(pStatics + 0x528);
          if (lVar5 == null) goto LAB_180a21b6b;
          uVar6 = FUN_1800024b0(lVar5,this.rareLv,DAT_181e86970);
          uVar6 = GlobalData.GenerateRareLvColorText(uVar6,this.rareLv,0);
          goto LAB_180a21948;
        case 1:
        case 2:
        case 5:
        case 6:
          lVar5 = *(int64 *)(pStatics + 0x510);
          if (lVar5 == null) goto LAB_180a21b6b;
          uVar7 = this.itemLv;
          if (*(uint32 *)(lVar5 + 24) <= uVar7) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar4 = lVar5[uVar7];
          uVar6 = GlobalData.GetItemTypeString
                            (this.type,this.subType,0);
          uVar4 = String.Concat(uVar4,uVar6,0);
          uVar4 = GlobalData.GenerateRareLvColorText(uVar4,this.itemLv,0);
          lVar5 = *(int64 *)(pStatics + 0x528);
          break;
        case 3:
          if ((this.bookData == null) ||
             (lVar5 = BookData.DataBase(this.bookData,0)) == null)
          goto LAB_180a21b6b;
          uVar4 = KungfuSkillData.TypeDescribe(lVar5,0);
          lVar5 = *(int64 *)(pStatics + 0x520);
          break;
        case 4:
          lVar5 = *(int64 *)(pStatics + 0x510);
          if (lVar5 == null) goto LAB_180a21b6b;
          uVar4 = FUN_1800024b0(lVar5,this.itemLv,DAT_181e86970);
          uVar6 = GlobalData.GetItemTypeString
                            (this.type,this.subType,0);
          uVar4 = String.Concat(uVar4,uVar6,0);
          uVar4 = GlobalData.GenerateRareLvColorText(uVar4,this.itemLv,0);
        default:
          goto switchD_180a21847_default;
        }
        uVar7 = this.rareLv;
        lVar8 = (int64)(int)uVar7;
        if (lVar5 == null) {
        LAB_180a21b6b:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        if (*(uint32 *)(lVar5 + 24) <= uVar7) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0,uVar7);
          uVar7 = this.rareLv;
        }
        uVar6 = GlobalData.GenerateRareLvColorText
                          (*(uint64 *)(*(int64 *)(lVar5 + 16) + 32 + lVar8 * 8),uVar7,0);
        LAB_180a21948:
        uVar4 = String.Concat(uVar4,uVar6,0);
        switchD_180a21847_default:
        if (italic) {
          uVar4 = String.Format("<i>{0}</i>",uVar4,0);
        }
        return uVar4;
    }

    // Token : 0x60012E6
    // RVA   : 0xA208B0   Offset: 0xA1F6B0   Length: 0xAF
    public string GetBookRareLvName()
    {
        long lVar1;
        uint uVar2;
        long lVar3;
        uVar2 = this.rareLv;
        lVar3 = (int64)(int)uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e538e8 + 184) + 0x520);
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

    // Token : 0x60012E7
    // RVA   : 0xA1F4E0   Offset: 0xA1E2E0   Length: 0xD
    public float BadFame(float rate)
    {
        return (float)this.value * rate;
    }

    // Token : 0x60012E8
    // RVA   : 0xA21D00   Offset: 0xA20B00   Length: 0x30
    public float GetShowRoomFameChange(float rate)
    {
        if (this.type == 4) {
          return (float)this.value * 0.01 * rate;
        }
        return (float)this.value * 0.0025 * rate;
    }

    // Token : 0x60012E9
    // RVA   : 0xA20720   Offset: 0xA1F520   Length: 0x47
    public bool Equiped()
    {
        uint uVar1;
        ulong uVar2;
        uVar1 = this.type;
        uVar2 = (uint64)uVar1;
        if (uVar1 == 0) {
          uVar2 = this.equipmentData;
          if (uVar2 == 0) {
        LAB_180a20762:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          if (uVar2.equiped) {
            return CONCAT71((int7)(uVar2 >> 8),1);
          }
        }
        else if (uVar1 == 6) {
          if (this.horseData != null) {
            return (uint64)this.horseData.equiped;
          }
          goto LAB_180a20762;
        }
        return uVar2 & 0xffffffffffffff00;
    }

    // Token : 0x60012EA
    // RVA   : 0xA23C70   Offset: 0xA22A70   Length: 0x115
    public ItemData SetMaterialData(int _subType, int _itemLv, int _rareLv)
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        long lVar1;
        ulong uVar2;
        this.subType = _subType;
        this.itemLv = _itemLv;
        this.rareLv = _rareLv;
        lVar1 = *(int64 *)(pStatics + 0x510);
        if (lVar1 != null) {
          if (*(uint32 *)(lVar1 + 24) <= _itemLv) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar2 = lVar1[_itemLv];
          lVar1 = *(int64 *)(pStatics + 0x558);
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

    // Token : 0x60012EB
    // RVA   : 0xA21B90   Offset: 0xA20990   Length: 0x5A
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

    // Token : 0x60012EC
    // RVA   : 0xA23B60   Offset: 0xA22960   Length: 0x102
    public ItemData SetBookData(int _skillID, int _rareLv)
    {
        uint uVar1;
        long lVar2;
        if (this.bookData != null) {
          this.bookData.skillID = _skillID;
          lVar2 = *(int64 *)(*(int64 *)(DAT_181e538e8 + 184) + 0x520);
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

    // Token : 0x60012ED
    // RVA   : 0xA23D90   Offset: 0xA22B90   Length: 0x752
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
        lVar8 = *(int64 *)(*(int64 *)(DAT_181e538e8 + 184) + 0x538);
        if (lVar8 != null) {
          if (*lVar8.fullIdentified <= _subType) {
            uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar9,0);
          }
          lVar2 = *(int64 *)(lVar8.fullIdentified + 4);
          if ((uint32)lVar2 <= uVar3) {
            uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar9,0);
          }
          this.name =
               *(uint64 *)(lVar8 + 32 + ((int)_subType * lVar2 + (int64)(int)uVar3) * 8);
          il2cpp_internal();
          GlobalData.RandomRangeDouble(0,0);
          uVar4 = Mathf.RoundToInt();
          iVar5 = Mathf.Min(20,uVar4);
          uVar4 = Mathf.RoundToInt((float)iVar5 * 0.25,0);
          this.rareLv = uVar4;
          lVar8 = il2cpp_internal(DAT_181e73cb8);
          FUN_1810f3480(lVar8,DAT_181e71270);
          if (lVar8 != null) {
            FUN_181769fe0(lVar8,0,DAT_181e713f0);
            FUN_181769fe0(lVar8,1,DAT_181e713f0);
            FUN_181769fe0(lVar8,2,DAT_181e713f0);
            FUN_181769fe0(lVar8,3,DAT_181e713f0);
            for (; 0 < iVar5; iVar5 = iVar5 + -1) {
              uVar4 = lVar8.treasureLv;
              uVar4 = GlobalData.RandomRange(0,uVar4,0,0);
              if (this.treasureData == null) throw; // [null/range check failed]
              lVar2 = this.treasureData.treasureLv;
              uVar6 = FUN_180002480(lVar8,uVar4,DAT_181e71bf0);
              if (lVar2 == null) throw; // [null/range check failed]
              iVar7 = FUN_180002480(lVar2,uVar6,DAT_181e71bf0);
              FUN_181774110(lVar2,uVar6,iVar7 + 1);
              if (this.treasureData == null) throw; // [null/range check failed]
              lVar2 = this.treasureData.treasureLv;
              uVar6 = FUN_180002480(lVar8,uVar4,DAT_181e71bf0);
              if (lVar2 == null) throw; // [null/range check failed]
              iVar7 = FUN_180002480(lVar2,uVar6);
              if (4 < iVar7) {
                FUN_1817634d0(lVar8,uVar4);
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
              FUN_181769c70(lVar8,uVar10);
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
              FUN_181769c70(lVar8,uVar3,(float)(this.itemLv + iVar5) + fVar1,DAT_181e835b0);
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
                  FUN_181769c70(lVar8,uVar3);
                  lVar8 = il2cpp_internal(DAT_181e73cb8);
                  FUN_1810f3480(lVar8,DAT_181e71270);
                  if (lVar8 != null) {
                    FUN_181769fe0(lVar8,0,DAT_181e713f0);
                    FUN_181769fe0(lVar8,1,DAT_181e713f0);
                    FUN_181769fe0(lVar8,2,DAT_181e713f0);
                    FUN_181769fe0(lVar8,3,DAT_181e713f0);
                    iVar5 = GlobalData.RandomRange(~this.rareLv,3,0);
                    uVar10 = uVar11;
                    if (iVar5 < 1) goto LAB_180a243dd;
                    goto LAB_180a24350;
                  }
                }
              }
            }
          }
        }
        throw; // [null/range check failed]
        while( true ) {
          FUN_18166b1c0(lVar2,uVar4,1);
          FUN_181665e90(lVar8,uVar4);
          uVar3 = (int)uVar10 + 1;
          uVar10 = (uint64)uVar3;
          if (iVar5 <= (int)uVar3) break;
        LAB_180a24350:
          uVar4 = lVar8.treasureLv;
          uVar4 = GlobalData.RandomRange(0,uVar4,0,0);
          uVar4 = FUN_180002480(lVar8,uVar4,DAT_181e71bf0);
          if ((this.treasureData == null) ||
             (lVar2 = this.treasureData.identified) == null)
          throw; // [null/range check failed]
        }
        LAB_180a243dd:
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
              FUN_1800024e0(lVar2,uVar11,DAT_181e83530);
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

    // Token : 0x60012EE
    // RVA   : 0xA230E0   Offset: 0xA21EE0   Length: 0x233
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
        LAB_180a23173:
          if (lVar3 == null) throw; // [null/range check failed]
          fVar4 = (float)HeroSpeAddData.GetValue(lVar3,0);
        }
        else if (this.type == 5) {
          if (this.materialData == null) throw; // [null/range check failed]
          lVar3 = this.materialData.extraAddData;
          goto LAB_180a23173;
        }
        lVar3 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32);
        if ((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 56)) != null) {
          iVar1 = *(int *)(lVar3 + 24);
          while( true ) {
            iVar1 = iVar1 + -1;
            if (iVar1 < 0) {
              return;
            }
            lVar3 = FUN_180210740(0);
            if ((((lVar3 == null) || (*(int64 *)(lVar3 + 56) == 0)) ||
                (lVar3 = FUN_1800024b0(*(int64 *)(lVar3 + 56),this.itemLv,
                                       DAT_181e80560), lVar3 == null)) ||
               (lVar3 = *(int64 *)(lVar3 + 48)) == null) break;
            if (*(int *)(lVar3 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            iVar2 = *(int *)(*(int64 *)(lVar3 + 16) + 32);
            lVar3 = FUN_180210740(0);
            if (((lVar3 == null) || (*(int64 *)(lVar3 + 56) == 0)) ||
               ((lVar3 = FUN_1800024b0(*(int64 *)(lVar3 + 56),iVar1,DAT_181e80560), lVar3 == null ||
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

    // Token : 0x60012EF
    // RVA   : 0xA20080   Offset: 0xA1EE80   Length: 0x4CC
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
          goto LAB_180a20545;
          HeroSpeAddData.GetValue(lVar3,0);
          if (this.subType == null) {
            fVar6 = 200.0;
          }
          else {
            fVar6 = 100.0;
          }
          fVar4 = (float)FUN_1801e6830();
          fVar7 = 1.0;
          fVar5 = (float)Mathf.Max();
          lVar3 = this.equipmentData;
          if (lVar3 == null) goto LAB_180a20545;
          uVar2 = Mathf.RoundToInt(((float)lVar3.enhanceLv * 0.2 + 1.0) * fVar4 * fVar6 * fVar5 *
                                    ((float)lVar3.speEnhanceLv * 0.1 + 1.0),0);
          this.value = uVar2;
          lVar3 = *(int64 *)(*(int64 *)(DAT_181e538e8 + 184) + 0x5f8);
          if (lVar3 == null) goto LAB_180a20545;
          fVar4 = (float)FUN_1800024e0(lVar3,this.subType,DAT_181e83530);
          iVar1 = this.itemLv;
          lVar3 = this.equipmentData;
          if ((this.subType & 0xfffffffb) == 0) {
            if (lVar3 == null) goto LAB_180a20545;
          }
          else {
            if (lVar3 == null) goto LAB_180a20545;
            fVar7 = (float)lVar3.littleType * 0.1 + 0.5;
          }
          fVar6 = (float)FUN_1801e6830();
          fVar6 = fVar6 * (float)(iVar1 + 1) * fVar4 * fVar7;
          goto LAB_180a2051c;
        case 1:
          lVar3 = FUN_180210740(0);
          if (lVar3 == null) goto LAB_180a20545;
          lVar3 = *(int64 *)(lVar3 + 0x120);
          goto LAB_180a202cc;
        case 2:
          lVar3 = FUN_180210740(0);
          if (lVar3 == null) goto LAB_180a20545;
          lVar3 = *(int64 *)(lVar3 + 0x128);
        LAB_180a202cc:
          if ((lVar3 == null) ||
             (lVar3 = FUN_18171b450(lVar3,this.itemID,DAT_181e9d8c0)) == null) {
        LAB_180a20545:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          if (this.medFoodData == null) goto LAB_180a20545;
          uVar2 = Mathf.RoundToInt(((float)this.rareLv * 0.2 + 1.0) *
                                    (float)lVar3.animName *
                                    ((float)this.medFoodData.enhanceLv * 0.2 + 1.0),0)
          ;
          this.value = uVar2;
          fVar6 = (float)(int)((float)this.itemLv * 0.5 + 1.0);
          goto LAB_180a2051c;
        case 3:
          FUN_1801e6830();
          goto LAB_180a203c1;
        case 4:
          uVar2 = ItemData.GetTreasureValue(this,0,0);
          this.value = uVar2;
          iVar1 = this.itemLv * 2 + 2;
          break;
        case 5:
          FUN_1801e6830();
        LAB_180a203c1:
          uVar2 = Mathf.RoundToInt();
          this.value = uVar2;
          iVar1 = this.itemLv + 1;
          break;
        case 6:
          if (this.subType == null) {
            lVar3 = FUN_180210740(0);
            if (((lVar3 == null) || (*(int64 *)(lVar3 + 0x130) == 0)) ||
               (lVar3 = FUN_18171b450(*(int64 *)(lVar3 + 0x130),this.itemID,
                                      DAT_181e9d8c0), lVar3 == null)) goto LAB_180a20545;
            fVar6 = (float)lVar3.animName;
          }
          else {
            fVar6 = (float)FUN_1801e6830();
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
          goto switchD_180a200fd_default;
        }
        fVar6 = (float)iVar1;
        LAB_180a2051c:
        this.weight = fVar6;
        switchD_180a200fd_default:
    }

    // Token : 0x60012F0
    // RVA   : 0xA23320   Offset: 0xA22120   Length: 0x820
    public void RecountStaticData()
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        uint uVar1;
        bool cVar2;
        ulong uVar3;
        long lVar4;
        ulong uVar5;
        int iVar6;
        long lVar8;
        float fVar9;
        iVar6 = 0;
        if (this.type != null) {
          this.equipmentData = 0;
          iVar6 = this.type;
        }
        if ((iVar6 != 1) && (iVar6 != 2)) {
          this.medFoodData = 0;
          iVar6 = this.type;
        }
        if (iVar6 != 3) {
          this.bookData = 0;
          iVar6 = this.type;
        }
        if (iVar6 != 4) {
          this.treasureData = 0;
          iVar6 = this.type;
        }
        if (iVar6 != 5) {
          this.materialData = 0;
          iVar6 = this.type;
        }
        if (iVar6 != 6) {
          this.horseData = 0;
          iVar6 = this.type;
        }
        switch(iVar6) {
        case 0:
          cVar2 = FUN_180ad1200(this.name,0);
          if (!cVar2) goto switchD_180a23434_default;
          iVar6 = this.subType;
          if (iVar6 == 0) {
            lVar4 = *(int64 *)(pStatics + 0x510);
            if (lVar4 == null) goto LAB_180a23b3a;
            uVar5 = FUN_1800024b0(lVar4,this.itemLv,DAT_181e86970);
            lVar4 = FUN_180210740(0);
            if (((lVar4 == null) || (lVar8 = this.equipmentData) == null) ||
               (lVar4 = *(int64 *)(lVar4 + 240)) == null) goto LAB_180a23b3a;
            iVar6 = lVar8.changeHeroState + *(int *)(lVar8 + 20) * 6;
          }
          else {
            if (iVar6 == 1) {
              lVar4 = *(int64 *)(pStatics + 0x510);
              if (lVar4 == null) goto LAB_180a23b3a;
              uVar5 = FUN_1800024b0(lVar4,this.itemLv,DAT_181e86970);
              lVar4 = FUN_180210740(0);
              if ((lVar4 == null) || (lVar8 = this.equipmentData) == null) goto LAB_180a23b3a;
              lVar4 = *(int64 *)(lVar4 + 0x100);
            }
            else if (iVar6 == 2) {
              lVar4 = *(int64 *)(pStatics + 0x510);
              if (lVar4 == null) goto LAB_180a23b3a;
              uVar5 = FUN_1800024b0(lVar4,this.itemLv,DAT_181e86970);
              lVar4 = FUN_180210740(0);
              if ((lVar4 == null) || (lVar8 = this.equipmentData) == null) goto LAB_180a23b3a;
              lVar4 = *(int64 *)(lVar4 + 0x108);
            }
            else {
              if (iVar6 != 3) {
                if (iVar6 != 4) goto switchD_180a23434_default;
                lVar4 = *(int64 *)(pStatics + 0x510);
                if (lVar4 == null) goto LAB_180a23b3a;
                uVar5 = FUN_1800024b0(lVar4,this.itemLv,DAT_181e86970);
                lVar4 = *(int64 *)(pStatics + 0x4e8);
                if ((this.equipmentData == null) || (lVar4 == null)) goto LAB_180a23b3a;
                uVar1 = this.equipmentData.littleType;
                goto LAB_180a239f5;
              }
              lVar4 = *(int64 *)(pStatics + 0x510);
              if (lVar4 == null) goto LAB_180a23b3a;
              uVar5 = FUN_1800024b0(lVar4,this.itemLv,DAT_181e86970);
              lVar4 = FUN_180210740(0);
              if ((lVar4 == null) || (lVar8 = this.equipmentData) == null) goto LAB_180a23b3a;
              lVar4 = *(int64 *)(lVar4 + 0x110);
            }
            if (lVar4 == null) goto LAB_180a23b3a;
            iVar6 = *(int *)(lVar8 + 20);
          }
          lVar4 = FUN_18171b450(lVar4,iVar6,DAT_181e9d8c0);
          if (lVar4 == null) goto LAB_180a23b3a;
          uVar3 = *(uint64 *)(lVar4 + 32);
          break;
        case 1:
          lVar4 = FUN_180210740(0);
          if (lVar4 == null) goto LAB_180a23b3a;
          lVar4 = *(int64 *)(lVar4 + 0x120);
          goto LAB_180a237c1;
        case 2:
          lVar4 = FUN_180210740(0);
          if (lVar4 == null) goto LAB_180a23b3a;
          lVar4 = *(int64 *)(lVar4 + 0x128);
        LAB_180a237c1:
          if (lVar4 == null) {
        LAB_180a23b3a:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar4 = FUN_18171b450(lVar4,this.itemID,DAT_181e9d8c0);
          cVar2 = FUN_180ad1200(this.name,0);
          if (lVar4 == null) goto LAB_180a23b3a;
          if (cVar2) {
            this.name = *(uint64 *)(lVar4 + 32);
          }
          this.checkName = *(uint64 *)(lVar4 + 40);
          this.describe = *(uint64 *)(lVar4 + 48);
          lVar8 = this.medFoodData;
          if (*(int64 *)(lVar4 + 104) == 0) goto LAB_180a23b3a;
          iVar6 = this.rareLv;
          uVar3 = *(uint64 *)(*(int64 *)(lVar4 + 104) + 24);
          fVar9 = (float)FUN_180f34e60((float)this.itemLv * 5.0,0x40a00000,0x41a00000,0);
          uVar3 = ChangeHeroStateData.op_Multiply(uVar3,(float)iVar6 / fVar9 + 1.0,0);
          if (lVar8 == null) goto LAB_180a23b3a;
          lVar8.changeHeroState = uVar3;
          goto LAB_180a23a1a;
        case 3:
          cVar2 = FUN_180ad1200(this.name,0);
          if (!cVar2) goto switchD_180a23434_default;
          if ((this.bookData == null) ||
             (lVar4 = BookData.DataBase(this.bookData,0)) == null)
          goto LAB_180a23b3a;
          uVar3 = *(uint64 *)(lVar4 + 32);
          this.name = uVar3;
          goto LAB_180a23a16;
        case 4:
          cVar2 = FUN_180ad1200(this.name,0);
          if (!cVar2) goto switchD_180a23434_default;
          lVar4 = *(int64 *)(pStatics + 0x538);
          if (lVar4 == null) goto LAB_180a23b3a;
          uVar3 = FUN_1800540b0(lVar4,(int64)this.subType,
                                (int64)this.itemLv);
          goto LAB_180a23a0f;
        case 5:
          cVar2 = FUN_180ad1200(this.name,0);
          if (!cVar2) goto switchD_180a23434_default;
          lVar4 = *(int64 *)(pStatics + 0x510);
          if (lVar4 == null) goto LAB_180a23b3a;
          uVar5 = FUN_1800024b0(lVar4,this.itemLv,DAT_181e86970);
          lVar4 = *(int64 *)(pStatics + 0x558);
          if (lVar4 == null) goto LAB_180a23b3a;
          uVar1 = this.subType;
        LAB_180a239f5:
          uVar3 = FUN_1800024b0(lVar4,uVar1,DAT_181e86970);
          break;
        case 6:
          if (this.subType == 1) {
            cVar2 = FUN_180ad1200(this.name,0);
            if (!cVar2) goto switchD_180a23434_default;
            lVar4 = *(int64 *)(pStatics + 0x510);
            if (lVar4 == null) goto LAB_180a23b3a;
            uVar5 = FUN_1800024b0(lVar4,this.itemLv,DAT_181e86970);
            uVar3 = "鞍具";
            break;
          }
          lVar4 = FUN_180210740(0);
          if ((lVar4 == null) || (*(int64 *)(lVar4 + 0x130) == 0)) goto LAB_180a23b3a;
          lVar4 = FUN_18171b450(*(int64 *)(lVar4 + 0x130),this.itemID,DAT_181e9d8c0
                               );
          cVar2 = FUN_180ad1200(this.name,0);
          if (lVar4 == null) goto LAB_180a23b3a;
          if (cVar2) {
            this.name = *(uint64 *)(lVar4 + 32);
          }
          uVar3 = *(uint64 *)(lVar4 + 48);
          this.describe = uVar3;
          goto LAB_180a23a1a;
        default:
          goto switchD_180a23434_default;
        }
        uVar3 = String.Concat(uVar5,uVar3,0);
        LAB_180a23a0f:
        this.name = uVar3;
        LAB_180a23a16:
        puVar7 = &this.name;
        LAB_180a23a1a:
        il2cpp_internal(puVar7,uVar3);
        switchD_180a23434_default:
        ItemData.CountValueAndWeight(this,0);
    }

    // Token : 0x60012F1
    // RVA   : 0xA227E0   Offset: 0xA215E0   Length: 0x4D4
    internal void OnDeserializedMethod(StreamingContext context)
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        uVar1 = GameController.ChangeAllAreaStateIDs;
        cVar3 = Object.op_Equality(uVar1,0,0);
        if (!cVar3) {
          lVar2 = GameController.ChangeAllAreaStateIDs;
          if (lVar2 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          if (*(int64 *)(lVar2 + 0x120) != 0) {
            ItemData.RecountStaticData(this,0);
          }
        }
    }

    // Token : 0x60012F2
    // RVA   : 0xA21E70   Offset: 0xA20C70   Length: 0x201
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
              auVar8._0_8_ = FUN_1801e6830();
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
                uVar3 = FUN_1800024b0(lVar2,uVar6,DAT_181e5a4c8);
                fVar7 = (float)GlobalData.ListAverage(uVar3,0);
                fVar7 = fVar7 * 0.1;
              }
            }
            else {
              if ((this.treasureData == null) ||
                 (lVar2 = this.treasureData.treasureLv) == null) break;
              iVar1 = FUN_180002480(lVar2,uVar6,DAT_181e71bf0);
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

    // Token : 0x60012F3
    // RVA   : 0xA21D30   Offset: 0xA20B30   Length: 0x139
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
              auVar6._0_8_ = FUN_1801e6830();
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

    // Token : 0x60012F4
    // RVA   : 0xA20960   Offset: 0xA1F760   Length: 0xFA
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

    // Token : 0x60012F5
    // RVA   : 0xA20E20   Offset: 0xA1FC20   Length: 0x17
    public int GetGovernContributionCost()
    {
        Mathf.RoundToInt((float)this.value * 0.1,0);
    }

    // Token : 0x60012F6
    // RVA   : 0xA21BF0   Offset: 0xA209F0   Length: 0x107
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
            fVar3 = (float)FUN_1801e6830(0x40000000);
            uVar2 = Mathf.RoundToInt(fVar3 * 20.0,0);
            return uVar2;
          }
        }
    }

    // Token : 0x60012F7
    // RVA   : 0xA20E70   Offset: 0xA1FC70   Length: 0x25
    public float GetHorseSeeRange()
    {
        return (float)this.rareLv * 0.02 + (float)this.itemLv * 0.1;
    }

    // Token : 0x60012F8
    // RVA   : 0xA20EA0   Offset: 0xA1FCA0   Length: 0x25
    public float GetHorseStepAddRate()
    {
        return (float)this.rareLv * 0.01 + (float)this.itemLv * 0.05;
    }

    // Token : 0x60012F9
    // RVA   : 0xA244F0   Offset: 0xA232F0   Length: 0xC3
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

    // Token : 0x60012FA
    // RVA   : 0xA245C0   Offset: 0xA233C0   Length: 0x1FD
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
                FUN_1800024e0(lVar3,uVar6,DAT_181e83530);
                cVar2 = ItemData.TryIdentifyOneResult();
                if (cVar2) {
                  bVar1 = true;
                  if ((this.treasureData == null) ||
                     (lVar3 = this.treasureData.identified) == null) break;
                  FUN_18166b1c0(lVar3,uVar6,1,DAT_181e627f8);
                }
              }
              if ((this.treasureData == null) ||
                 (lVar3 = this.treasureData.identified) == null) break;
              cVar2 = FUN_180060680(lVar3,uVar6,DAT_181e62778);
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

    // Token : 0x60012FB
    // RVA   : 0xA20770   Offset: 0xA1F570   Length: 0x134
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
              FUN_18166b1c0(lVar1,uVar3,1,DAT_181e627f8);
            }
            lVar1 = this.treasureData;
            uVar3 = uVar3 + 1;
            lVar2 = lVar2 + 1;
            if (lVar1 == null) break;
          }
        }
    }

    // Token : 0x60012FC
    // RVA   : 0xA22360   Offset: 0xA21160   Length: 0x3E2
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
        lVar5 = il2cpp_internal(DAT_181e73cb8);
        FUN_1810f3480(lVar5);
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
                 (lVar6 = FUN_1800024b0(lVar6,uVar8,DAT_181e5a4c8)) == null) throw; // [null/range check failed]
              if (lVar6.treasureLv <= iVar10) break;
              if (lVar5 == null) throw; // [null/range check failed]
              FUN_18115d8f0(lVar5,DAT_181e714f0);
              iVar7 = 0;
              while( true ) {
                if (((this.treasureData == null) ||
                    (lVar6 = this.treasureData.playerGuessTreasureLv) == null) ||
                   (lVar6 = FUN_1800024b0(lVar6,uVar8,DAT_181e5a4c8)) == null) throw; // [null/range check failed]
                lVar1 = this.treasureData;
                if (lVar6.treasureLv <= iVar7) break;
                if (((lVar1 == null) || (lVar1.playerGuessTreasureLv == null)) ||
                   (lVar6 = FUN_1800024b0(lVar1.playerGuessTreasureLv,uVar8,DAT_181e5a4c8)) == null)
                throw; // [null/range check failed]
                iVar2 = FUN_180002480(lVar6,iVar7,DAT_181e71bf0);
                if ((this.treasureData == null) ||
                   (lVar6 = this.treasureData.treasureLv) == null)
                throw; // [null/range check failed]
                iVar3 = FUN_180002480(lVar6,uVar8,DAT_181e71bf0);
                if (iVar2 != iVar3) {
                  FUN_181769fe0(lVar5,iVar7,DAT_181e713f0);
                }
                iVar7 = iVar7 + 1;
              }
              if ((lVar1 == null) || (lVar1.playerGuessTreasureLv == null)) throw; // [null/range check failed]
              lVar6 = FUN_1800024b0(lVar1.playerGuessTreasureLv,uVar8,DAT_181e5a4c8);
              uVar4 = *(uint32 *)(lVar5 + 24);
              uVar4 = GlobalData.RandomRange(0,uVar4,0,0);
              uVar4 = FUN_180002480(lVar5,uVar4,DAT_181e71bf0);
              if (lVar6 == null) throw; // [null/range check failed]
              FUN_1817634d0(lVar6,uVar4,DAT_181e718f0);
            }
            lVar6 = this.treasureData;
            uVar8 = uVar8 + 1;
            lVar9 = lVar9 + 4;
            if (lVar6 == null) break;
          }
        }
    }

    // Token : 0x60012FD
    // RVA   : 0xA22750   Offset: 0xA21550   Length: 0x81
    public string Name(bool colored)
    {
        uint uVar1;
        ulong uVar2;
        uVar2 = ItemData.BuildDisplayName(this,0);
        if (colored) {
          uVar1 = this.itemLv;
          GlobalData.GenerateRareLvColorText(uVar2,uVar1,0);
        }
    }

    // Token : 0x60012FE
    // RVA   : 0xA22FB0   Offset: 0xA21DB0   Length: 0x12F
    public string RawName(bool colored)
    {
        uint uVar1;
        bool cVar2;
        ulong uVar3;
        if (**(int **)(DAT_181e538e8 + 184) == 2) {
        LAB_180a2304a:
          cVar2 = FUN_180ad1200(this.checkName,0);
          if (!cVar2) {
            cVar2 = String.op_Inequality(this.checkName,"无",0);
            if (cVar2) {
              uVar3 = this.checkName;
              goto LAB_180a2308f;
            }
          }
        }
        else {
          if (*(char *)(*(int64 *)(DAT_181e538e8 + 184) + 4) != false) goto LAB_180a2304a;
        }
        cVar2 = FUN_180ad1200(this.setName,0);
        if (!cVar2) {
          uVar3 = this.setName;
        }
        else {
          uVar3 = this.name;
        }
        LAB_180a2308f:
        if (colored) {
          uVar1 = this.itemLv;
          uVar3 = GlobalData.GenerateRareLvColorText(uVar3,uVar1,0);
          return uVar3;
        }
        return uVar3;
    }

    // Token : 0x60012FF
    // RVA   : 0xA20690   Offset: 0xA1F490   Length: 0x81
    public string DisplayName(bool colored)
    {
        uint uVar1;
        ulong uVar2;
        uVar2 = ItemData.BuildDisplayName(this,0);
        if (colored) {
          uVar1 = this.itemLv;
          GlobalData.GenerateRareLvColorText(uVar2,uVar1,0);
        }
    }

    // Token : 0x6001300
    // RVA   : 0xA1F4F0   Offset: 0xA1E2F0   Length: 0x272
    private string BuildDisplayName()
    {
        bool cVar1;
        ulong uVar2;
        ulong uVar3;
        long lVar4;
        cVar1 = FUN_180ad1200(this.setName,0);
        if (!cVar1) goto LAB_180a1f74b;
        if (**(int **)(DAT_181e538e8 + 184) == 2) {
        LAB_180a1f5b4:
          cVar1 = FUN_180ad1200(this.checkName,0);
          if ((!cVar1) &&
             (cVar1 = String.op_Inequality(this.checkName,"无",0),
             cVar1)) {
        LAB_180a1f74b:
            uVar2 = ItemData.RawName(this,0,0);
            return uVar2;
          }
        }
        else {
          if (*(char *)(*(int64 *)(DAT_181e538e8 + 184) + 4) != false) goto LAB_180a1f5b4;
        }
        uVar2 = "";
        if (this.equipmentData != null) {
          uVar2 = EquipmentData.GetExtraAddName(this.equipmentData,0);
        }
        if ((this.type == null) && (this.equipmentData != null)) {
          cVar1 = FUN_180ad1200(uVar2,0);
          if (cVar1) goto LAB_180a1f72f;
          uVar3 = FUN_180210740(0);
          cVar1 = Object.op_Inequality(uVar3,0,0);
          uVar3 = "";
          if (cVar1) {
            lVar4 = FUN_180210740(0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            uVar3 = GameDataController.GetEquipmentSingleName(lVar4,this,0);
          }
          cVar1 = FUN_180ad1200(uVar3,0);
          if (!cVar1) {
            uVar2 = String.Concat(uVar2,uVar3,0);
            return uVar2;
          }
        }
        if ((this.type == 6) && (this.subType == 1)) {
          uVar2 = ItemData.BuildHorseArmorDisplayName(this,0);
          cVar1 = FUN_180ad1200(uVar2,0);
          if (!cVar1) {
            return uVar2;
          }
        }
        LAB_180a1f72f:
        uVar2 = ItemData.RawName(this,0,0);
        return uVar2;
    }

    // Token : 0x6001301
    // RVA   : 0xA1F770   Offset: 0xA1E570   Length: 0x539
    private string BuildHorseArmorDisplayName()
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        float fVar2;
        long lVar3;
        bool cVar4;
        int iVar5;
        long lVar6;
        long lVar7;
        long lVar8;
        ulong uVar9;
        uint uVar10;
        ulong uVar11;
        ulong uVar12;
        long lVar13;
        float fVar14;
        ulong local_res18;
        lVar6 = new c.DisplayClass9_0(0);
        if (this.horseData == null) {
          return "";
        }
        lVar7 = FUN_1801dfd90(DAT_181e854f8,4);
        if ((this.horseData != null) && (lVar7 != null)) {
          uVar10 = *(uint32 *)(lVar7 + 24);
          if (uVar10 == 0) {
            uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar9,0);
          }
          *(uint32 *)(lVar7 + 32) = this.horseData.speed;
          if (this.horseData != null) {
            if (uVar10 < 2) {
              uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar9,0);
            }
            *(uint32 *)(lVar7 + 36) = this.horseData.sprint;
            if (this.horseData != null) {
              if (uVar10 < 3) {
                uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar9,0);
              }
              *(uint32 *)(lVar7 + 40) = this.horseData.power;
              if (this.horseData != null) {
                if (uVar10 < 4) {
                  uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar9,0);
                }
                *(uint32 *)(lVar7 + 44) = this.horseData.resist;
                if (lVar6 != null) {
                  plVar1 = (int64 *)(lVar6 + 16);
                  *plVar1 = lVar7;
                  il2cpp_internal(plVar1,lVar7);
                  fVar14 = 0.0;
                  lVar7 = il2cpp_internal(DAT_181e73cb8);
                  FUN_1810f3480(lVar7,DAT_181e71270);
                  uVar12 = 0;
                  uVar11 = uVar12;
                  while (lVar13 = *plVar1) != null {
                    uVar10 = (uint32)uVar11;
                    if ((int)*(uint32 *)(lVar13 + 24) <= (int)uVar10) {
                      if (lVar7 == null) break;
                      if (*(int *)(lVar7 + 24) == 0) {
                        return "";
                      }
                      if (fVar14 <= 0.0) {
                        return "";
                      }
                      uVar9 = new OnTooltipCB(lVar6,DAT_181e89c20,DAT_181e8bd90);
                      List_1.Sort(lVar7,uVar9,DAT_181e719f0);
                      if ((int)*(uint32 *)(lVar7 + 24) < 3) {
        LAB_180a1fa80:
                        lVar13 = 1;
                      }
                      else {
                        lVar6 = *plVar1;
                        if (*(uint32 *)(lVar7 + 24) < 2) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        if (lVar6 == null) break;
                        uVar10 = *(uint32 *)(*(int64 *)(lVar7 + 16) + 36);
                        if (*(uint32 *)(lVar6 + 24) <= uVar10) {
                          uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1801e02d0(uVar9,0);
                        }
                        lVar13 = 2;
                        if (lVar6[uVar10] < fVar14 * 0.35)
                        goto LAB_180a1fa80;
                      }
                      local_res18 = "";
                      lVar6 = 32;
                      uVar11 = uVar12;
                      goto LAB_180a1faa0;
                    }
                    if (*(uint32 *)(lVar13 + 24) <= uVar10) {
                      uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar9,0);
                    }
                    fVar2 = lVar13[uVar10];
                    fVar14 = fVar14 + fVar2;
                    if (0.0 < fVar2) {
                      if (lVar7 == null) break;
                      FUN_181769fe0(lVar7,uVar11,DAT_181e713f0);
                    }
                    uVar11 = (uint64)(uVar10 + 1);
                  }
                }
              }
            }
          }
        }
        LAB_180a1fca4:
                          // WARNING: Subroutine does not return
        FUN_1801e0300();
        LAB_180a1faa0:
        if (*(uint32 *)(lVar7 + 24) <= (uint32)uVar11) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        uVar10 = *(uint32 *)(lVar6 + *(int64 *)(lVar7 + 16));
        lVar8 = *(int64 *)(pStatics + 0x4f8);
        if (lVar8 == null) goto LAB_180a1fca4;
        lVar8 = FUN_1800024b0(lVar8,uVar10,DAT_181e5af68);
        if ((lVar8 != null) && (*(int *)(lVar8 + 24) != 0)) {
          lVar3 = *plVar1;
          if (lVar3 == null) goto LAB_180a1fca4;
          if (*(uint32 *)(lVar3 + 24) <= uVar10) {
            uVar9 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar9,0);
          }
          iVar5 = Mathf.RoundToInt(lVar3[uVar10],0);
          iVar5 = Mathf.Abs(iVar5 * 31 +
                             this.itemLv * 7 + uVar10 + this.rareLv * 13,0);
          uVar9 = FUN_1800024b0(lVar8,(int64)iVar5 % (int64)*(int *)(lVar8 + 24) & 0xffffffff,
                                DAT_181e86970);
          local_res18 = String.Concat(local_res18,uVar9,0);
        }
        uVar11 = (uint64)((uint32)uVar11 + 1);
        uVar12 = uVar12 + 1;
        lVar6 = lVar6 + 4;
        if (lVar13 <= (int64)uVar12) {
          cVar4 = FUN_180ad1200(local_res18,0);
          if (cVar4) {
            return "";
          }
          uVar9 = String.Concat(local_res18,*(uint64 *)(pStatics + 0x500),
                                 0);
          return uVar9;
        }
        goto LAB_180a1faa0;
    }

    // Token : 0x6001302
    // RVA   : 0xA1FCB0   Offset: 0xA1EAB0   Length: 0x3C0
    public virtual object Clone()
    {
        uint uVar1;
        long lVar2;
        uVar1 = this.type;
        lVar2 = new ItemData(uVar1,0);
        if (lVar2 != null) {
          *(uint32 *)(lVar2 + 16) = this.itemID;
          *(uint32 *)(lVar2 + 24) = this.subType;
          *(uint64 *)(lVar2 + 32) = this.name;
          *(uint64 *)(lVar2 + 40) = this.checkName;
          *(uint64 *)(lVar2 + 48) = this.describe;
          *(uint32 *)(lVar2 + 56) = this.value;
          *(uint32 *)(lVar2 + 60) = this.itemLv;
          *(uint32 *)(lVar2 + 64) = this.rareLv;
          *(uint32 *)(lVar2 + 68) = this.weight;
          *(uint8 *)(lVar2 + 72) = this.isNew;
          *(uint32 *)(lVar2 + 76) = this.poisonNum;
          *(uint8 *)(lVar2 + 80) = this.poisonNumDetected;
          *(uint64 *)(lVar2 + 88) = this.setName;
          if (this.equipmentData == null) {
            plVar4 = (int64 *)0;
          }
          else {
            plVar4 = (int64 *)EquipmentData.Clone(this.equipmentData,0);
          }
          plVar5 = (int64 *)0;
          *(int64 **)(lVar2 + 96) = plVar4;
          plVar4 = plVar5;
          if ((this.medFoodData != null) &&
             (plVar3 = (int64 *)MedFoodData.Clone(this.medFoodData,0),
             plVar3 != (int64 *)0)) {
          }
          *(int64 **)(lVar2 + 104) = plVar4;
          plVar4 = plVar5;
          if ((this.bookData != null) &&
             (plVar3 = (int64 *)BookData.Clone(this.bookData,0),
             plVar3 != (int64 *)0)) {
          }
          *(int64 **)(lVar2 + 112) = plVar4;
          plVar4 = plVar5;
          if ((this.treasureData != null) &&
             (plVar3 = (int64 *)TreasureData.Clone(this.treasureData,0),
             plVar3 != (int64 *)0)) {
          }
          *(int64 **)(lVar2 + 120) = plVar4;
          plVar4 = plVar5;
          if ((this.materialData != null) &&
             (plVar3 = (int64 *)MaterialData.Clone(this.materialData,0),
             plVar3 != (int64 *)0)) {
          }
          *(int64 **)(lVar2 + 128) = plVar4;
          if ((this.horseData != null) &&
             (plVar4 = (int64 *)HorseData.Clone(this.horseData,0),
             plVar4 != (int64 *)0)) {
          }
          *(uint64 *)(lVar2 + 136) = plVar5;
          return lVar2;
        }
    }

}
