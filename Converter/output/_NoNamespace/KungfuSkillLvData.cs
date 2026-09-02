// ============================================================
// Type  : KungfuSkillLvData
// Token : 0x2000221
// ============================================================

public class KungfuSkillLvData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40010A9
    public int skillID;

    // Token: 0x40010AA
    public int lv;

    // Token: 0x40010AB
    public float fightExp;

    // Token: 0x40010AC
    public float bookExp;

    // Token: 0x40010AD
    public bool equiped;

    // Token: 0x40010AE
    public bool isNew;

    // Token: 0x40010AF
    public int belongHeroID;

    // Token: 0x40010B0
    public HeroSpeAddData speEquipData;

    // Token: 0x40010B1
    public float equipUseSpeAddValue;

    // Token: 0x40010B2
    public HeroSpeAddData speUseData;

    // Token: 0x40010B3
    public float damageUseSpeAddValue;

    // Token: 0x40010B4
    public float selfUseSpeAddValue;

    // Token: 0x40010B5
    public float enemyUseSpeAddValue;

    // Token: 0x40010B6
    public HeroSpeAddData extraAddData;

    // Token: 0x40010B7
    public float cdTimeLeft;

    // Token: 0x40010B8
    public int useTime;

    // Token: 0x40010B9
    public float activeTimeLeft;

    // Token: 0x40010BA
    public float power;

    // Token: 0x40010BB
    public float battleDamageCount;

    // Token: 0x40010BC
    public bool skillIconDirty;

    // Token: 0x40010BD
    public bool maxManaChanged;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600121B
    // RVA   : 0xB848D0   Offset: 0xB830D0   Length: 0x1A6
    public void /*ctor*/(int _skillID)
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        this.skillID = _skillID;
        this.speEquipData = new HeroSpeAddData(0);
        this.speUseData = new HeroSpeAddData(0);
        this.extraAddData = new HeroSpeAddData(0);
        KungfuSkillLvData.ResetSpeEquipData(this,0);
        KungfuSkillLvData.ResetSpeUseData(this,0);
    }

    // Token : 0x600121C
    // RVA   : 0xB845E0   Offset: 0xB82DE0   Length: 0xD1
    public bool SkillMeetObstacleLv()
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x638);
        lVar3 = KungfuSkillLvData.DataBase(this,0);
        if ((lVar3 != null) && (lVar2 != null)) {
          uVar1 = *(uint32 *)(lVar3 + 52);
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2[uVar1];
          if (lVar2 != null) {
            FUN_181815240(lVar2,this.lv,DAT_181d67bf8);
            return;
          }
        }
    }

    // Token : 0x600121D
    // RVA   : 0xB83B70   Offset: 0xB82370   Length: 0x87
    public string GetSkillIcon()
    {
        long lVar1;
        ulong uVar2;
        uint[] local_res18 = new uint[4];
        lVar1 = KungfuSkillLvData.DataBase(this,0);
        if (lVar1 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (*(char *)(lVar1 + 16) != false) {
          local_res18[0] = *(uint32 *)(lVar1 + 20);
          uVar2 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
          String.Format("summonskill{0}",uVar2,0);
          return;
        }
        Int32.ToString((uint32 *)(lVar1 + 20),0);
    }

    // Token : 0x600121E
    // RVA   : 0xB83620   Offset: 0xB81E20   Length: 0x45
    public float GetSkillExpExchangeRate()
    {
        long lVar1;
        lVar1 = KungfuSkillLvData.DataBase(this,0);
        if (lVar1 != null) {
          Mathf.Max(0.5 - (float)*(int *)(lVar1 + 52) * 0.1);
          return;
        }
    }

    // Token : 0x600121F
    // RVA   : 0xB847A0   Offset: 0xB82FA0   Length: 0xDB
    public int StudyMoneyCost()
    {
        int iVar1;
        long lVar2;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
        if (lVar2 != null) {
          lVar2 = GameDataController.GetSkillDataBase(lVar2,this.skillID,0);
          if (lVar2 != null) {
            iVar1 = Mathf.FloorToInt((float)*(int *)(lVar2 + 52) * 0.5,0);
            return (iVar1 + 1) * 20;
          }
        }
    }

    // Token : 0x6001220
    // RVA   : 0xB846C0   Offset: 0xB82EC0   Length: 0xD5
    public int StudyDayCost()
    {
        int iVar1;
        long lVar2;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
        if (lVar2 != null) {
          lVar2 = GameDataController.GetSkillDataBase(lVar2,this.skillID,0);
          if (lVar2 != null) {
            iVar1 = Mathf.FloorToInt((float)*(int *)(lVar2 + 52) * 0.5,0);
            return iVar1 + 1;
          }
        }
    }

    // Token : 0x6001221
    // RVA   : 0xB802C0   Offset: 0xB7EAC0   Length: 0xA7
    public int BreakThroughDayCost()
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x630);
        lVar3 = KungfuSkillLvData.DataBase(this,0);
        if ((lVar3 != null) && (lVar2 != null)) {
          uVar1 = *(uint32 *)(lVar3 + 52);
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          return lVar2[uVar1];
        }
    }

    // Token : 0x6001222
    // RVA   : 0xB80550   Offset: 0xB7ED50   Length: 0xA3
    public void ChangePower(float deltaPower)
    {
        float fVar1;
        long lVar2;
        uint uVar3;
        uVar3 = 0;
        if (this.activeTimeLeft <= 0.0) {
          fVar1 = *(float *)(this + 100);
          lVar2 = KungfuSkillLvData.DataBase(this.activeTimeLeft,0);
          if ((lVar2 == null) ||
             ((*(int *)(lVar2 + 48) < 3 && (lVar2 = KungfuSkillLvData.DataBase(this,0)) == null)
             )) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar3 = FUN_1810a8ba0(fVar1 + deltaPower,0);
        }
        *(uint32 *)(this + 100) = uVar3;
    }

    // Token : 0x6001223
    // RVA   : 0xB83D00   Offset: 0xB82500   Length: 0x56
    public float MaxPower()
    {
        long lVar1;
        lVar1 = KungfuSkillLvData.DataBase(this,0);
        if (lVar1 != null) {
          if (2 < *(int *)(lVar1 + 48)) {
            return 0.0;
          }
          lVar1 = KungfuSkillLvData.DataBase(this,0);
          if (lVar1 != null) {
            return (float)*(int *)(lVar1 + 52) * 15.0 + 75.0;
          }
        }
    }

    // Token : 0x6001224
    // RVA   : 0xB804F0   Offset: 0xB7ECF0   Length: 0x5B
    public void ChangeExtraAddData(HeroSpeAddData deltaAddData, bool needReset)
    {
        ulong uVar1;
        uVar1 = HeroSpeAddData.op_Addition(this.extraAddData,deltaAddData,0);
        this.extraAddData = uVar1;
        if (needReset) {
          KungfuSkillLvData.ResetSpeEquipData(this,0);
          KungfuSkillLvData.ResetSpeUseData(this,0);
        }
    }

    // Token : 0x6001225
    // RVA   : 0xB83CA0   Offset: 0xB824A0   Length: 0x51
    public void ManageCdTimeLeft(float deltaTime)
    {
        uint uVar1;
        if (0.0 < this.activeTimeLeft) {
          uVar1 = Mathf.Max(0,this.activeTimeLeft + deltaTime,0);
          this.activeTimeLeft = uVar1;
        }
        else if (0.0 < this.cdTimeLeft) {
          uVar1 = Mathf.Max(0,this.cdTimeLeft + deltaTime,0);
          this.cdTimeLeft = uVar1;
          return;
        }
    }

    // Token : 0x6001226
    // RVA   : 0xB808E0   Offset: 0xB7F0E0   Length: 0xE
    public void FightReset()
    {
        this.cdTimeLeft = 0;
        *(uint64 *)(this + 100) = 0;
        this.activeTimeLeft = 0;
    }

    // Token : 0x6001227
    // RVA   : 0xB83C00   Offset: 0xB82400   Length: 0x68
    public float GetSkillNeedExpRate(HeroData targetHero)
    {
        long lVar1;
        ulong uVar2;
        lVar1 = KungfuSkillLvData.DataBase(this,0);
        if (lVar1 != null) {
          if (*(int64 *)(lVar1 + 80) == 0) {
            return 0x3f800000;
          }
          lVar1 = KungfuSkillLvData.DataBase(this,0);
          if ((lVar1 != null) && (*(int64 *)(lVar1 + 80) != 0)) {
            uVar2 = AttriNumData.GetSkillNeedExpRate(*(int64 *)(lVar1 + 80),targetHero,0);
            return uVar2;
          }
        }
    }

    // Token : 0x6001228
    // RVA   : 0xB80370   Offset: 0xB7EB70   Length: 0x60
    public float CDTimeTotal()
    {
        long lVar1;
        lVar1 = KungfuSkillLvData.DataBase(this,0);
        if (lVar1 != null) {
          if (*(int *)(lVar1 + 48) < 3) {
            return;
          }
          lVar1 = KungfuSkillLvData.DataBase(this,0);
          if (lVar1 != null) {
            return;
          }
        }
    }

    // Token : 0x6001229
    // RVA   : 0x890B30   Offset: 0x88F330   Length: 0x9
    public float GetActiveTime()
    {
        return 0x40a00000;
    }

    // Token : 0x600122A
    // RVA   : 0xB83D60   Offset: 0xB82560   Length: 0x8F
    public string Name(bool colored)
    {
        uint uVar1;
        long lVar2;
        ulong uVar3;
        lVar2 = KungfuSkillLvData.DataBase(this,0);
        if (lVar2 != null) {
          uVar3 = *(uint64 *)(lVar2 + 32);
          if (colored) {
            uVar1 = *(uint32 *)(lVar2 + 52);
            uVar3 = GlobalData.GenerateRareLvColorText(uVar3,uVar1,0);
          }
          return uVar3;
        }
    }

    // Token : 0x600122B
    // RVA   : 0xB84880   Offset: 0xB83080   Length: 0x1D
    public int Type()
    {
        long lVar1;
        lVar1 = KungfuSkillLvData.DataBase(this,0);
        if (lVar1 != null) {
          return *(uint32 *)(lVar1 + 48);
        }
    }

    // Token : 0x600122C
    // RVA   : 0xB80790   Offset: 0xB7EF90   Length: 0xB6
    public KungfuSkillData DataBase()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
        if (lVar1 != null) {
          GameDataController.GetSkillDataBase(lVar1,this.skillID,0);
          return;
        }
    }

    // Token : 0x600122D
    // RVA   : 0xB809D0   Offset: 0xB7F1D0   Length: 0x21
    public PartPostureData GetAtkPartPosture()
    {
        long lVar1;
        lVar1 = KungfuSkillLvData.DataBase(this,0);
        if (lVar1 != null) {
          return *(uint64 *)(lVar1 + 136);
        }
    }

    // Token : 0x600122E
    // RVA   : 0xB81C50   Offset: 0xB80450   Length: 0x21
    public PartPostureData GetDefPartPosture()
    {
        long lVar1;
        lVar1 = KungfuSkillLvData.DataBase(this,0);
        if (lVar1 != null) {
          return *(uint64 *)(lVar1 + 144);
        }
    }

    // Token : 0x600122F
    // RVA   : 0xB81F50   Offset: 0xB80750   Length: 0x31
    public float GetLvSpeDamageChange()
    {
        FUN_1810a8ba0((float)(this.lv + -4) * 0.25 + 1.0,0x3dcccccd,0x3f800000,0);
    }

    // Token : 0x6001230
    // RVA   : 0xB80A00   Offset: 0xB7F200   Length: 0x3D
    public float GetBaseDamage()
    {
        long lVar1;
        lVar1 = KungfuSkillLvData.DataBase(this,0);
        if (lVar1 != null) {
          return ((float)this.lv * 0.1 + 1.0) * *(float *)(lVar1 + 60);
        }
    }

    // Token : 0x6001231
    // RVA   : 0xB81F90   Offset: 0xB80790   Length: 0x3D
    public float GetManaCost()
    {
        long lVar1;
        lVar1 = KungfuSkillLvData.DataBase(this,0);
        if (lVar1 != null) {
          return ((float)this.lv * 0.1 + 1.0) * *(float *)(lVar1 + 56);
        }
    }

    // Token : 0x6001232
    // RVA   : 0xB848A0   Offset: 0xB830A0   Length: 0x27
    public void Upgrade(int upgradeLv)
    {
        this.lv = this.lv + upgradeLv;
        KungfuSkillLvData.ResetSpeEquipData(this,0);
        KungfuSkillLvData.ResetSpeUseData(this,0);
        this.skillIconDirty = 1;
    }

    // Token : 0x6001233
    // RVA   : 0xB83C70   Offset: 0xB82470   Length: 0x21
    public HeroSpeAddData GetSpeEquipData()
    {
        if (0.0 < this.activeTimeLeft) {
          HeroSpeAddData.op_Multiply(this.speEquipData,2);
          return;
        }
    }

    // Token : 0x6001234
    // RVA   : 0xB81F20   Offset: 0xB80720   Length: 0x21
    public HeroSpeAddData GetExtraAddData()
    {
        if (0.0 < this.activeTimeLeft) {
          HeroSpeAddData.op_Multiply(this.extraAddData,2);
          return;
        }
    }

    // Token : 0x6001235
    // RVA   : 0xB83DF0   Offset: 0xB825F0   Length: 0x2BC
    public void ResetSpeEquipData()
    {
        float fVar1;
        int iVar2;
        ulong uVar3;
        bool cVar4;
        long lVar5;
        ulong uVar6;
        long lVar7;
        float fVar8;
        uint local_60;
        uint32 uStack_5c;
        uint32 uStack_58;
        uint32 uStack_54;
        uint64 local_50;
        uint32 local_48;
        uint32 uStack_44;
        uint32 uStack_40;
        uint32 uStack_3c;
        uint64 local_38;
        lVar5 = KungfuSkillLvData.DataBase(this,0);
        iVar2 = this.lv;
        if (lVar5 != null) {
          if (*(int64 *)(lVar5 + 96) == 0) {
            uVar6 = new HeroSpeAddData(0);
          }
          else {
            uVar6 = HeroSpeAddData.op_Multiply(*(int64 *)(lVar5 + 96),(float)iVar2 * 0.1 + 1.0,0);
          }
          this.speEquipData = uVar6;
          if ((this.speEquipData == null) ||
             (cVar4 = HeroSpeAddData.isEmpty(this.speEquipData,0), cVar4)) {
            return;
          }
          this.equipUseSpeAddValue = 0;
          lVar5 = KungfuSkillLvData.DataBase(this,0);
          if (lVar5 != null) {
            lVar7 = this.speEquipData;
            if (*(int *)(lVar5 + 48) < 3) {
              lVar7 = HeroSpeAddData.op_Addition(lVar7,this.extraAddData,0);
            }
            if (((lVar7 != null) && (lVar7.heroSpeAddData != null)) &&
               (lVar5 = Dictionary_2.get_Keys(lVar7.heroSpeAddData,DAT_181d98b10)) != null) {
              FUN_180ed4d30(&local_48,lVar5,DAT_181d9c570);
              local_60 = local_48;
              uStack_5c = uStack_44;
              uStack_58 = uStack_40;
              uStack_54 = uStack_3c;
              local_50 = local_38;
              while( true ) {
                cVar4 = FUN_1811d8280(&local_60,DAT_181d74c38);
                uVar3 = local_50;
                if (!cVar4) {
                  ZhSegment.Initialize(&local_60,DAT_181d74bb8);
                  return;
                }
                fVar1 = this.equipUseSpeAddValue;
                fVar8 = (float)HeroSpeAddData.Get(lVar7,local_50 & 0xffffffff,0);
                lVar5 = FUN_18046c100(0);
                if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (*(int64 *)(lVar5 + 144) == 0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar5 = FUN_180002f80(*(int64 *)(lVar5 + 144),uVar3 & 0xffffffff);
                if (lVar5 == null) break;
                this.equipUseSpeAddValue = fVar8 / *(float *)(lVar5 + 32) + fVar1;
              }
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
          }
        }
    }

    // Token : 0x6001236
    // RVA   : 0xB840B0   Offset: 0xB828B0   Length: 0x4B3
    public void ResetSpeUseData()
    {
        float fVar1;
        int iVar2;
        ulong uVar3;
        bool cVar4;
        long lVar5;
        ulong uVar6;
        long lVar7;
        float fVar8;
        uint local_60;
        uint32 uStack_5c;
        uint32 uStack_58;
        uint32 uStack_54;
        uint64 local_50;
        uint32 local_48;
        uint32 uStack_44;
        uint32 uStack_40;
        uint32 uStack_3c;
        uint64 local_38;
        lVar5 = KungfuSkillLvData.DataBase(this,0);
        iVar2 = this.lv;
        if (lVar5 != null) {
          if (*(int64 *)(lVar5 + 104) == 0) {
            uVar6 = new HeroSpeAddData(0);
          }
          else {
            uVar6 = HeroSpeAddData.op_Multiply(*(int64 *)(lVar5 + 104),(float)iVar2 * 0.1 + 1.0,0);
          }
          this.speUseData = uVar6;
          if ((this.speUseData == null) ||
             (cVar4 = HeroSpeAddData.isEmpty(this.speUseData,0), cVar4)) {
            return;
          }
          this.damageUseSpeAddValue = 0;
          this.enemyUseSpeAddValue = 0;
          lVar5 = KungfuSkillLvData.DataBase(this,0);
          if (lVar5 != null) {
            lVar7 = this.speUseData;
            if (2 < *(int *)(lVar5 + 48)) {
              lVar7 = HeroSpeAddData.op_Addition(lVar7,this.extraAddData,0);
            }
            if (((lVar7 != null) && (lVar7.heroSpeAddData != null)) &&
               (lVar5 = Dictionary_2.get_Keys(lVar7.heroSpeAddData,DAT_181d98b10)) != null) {
              FUN_180ed4d30(&local_48,lVar5,DAT_181d9c570);
              local_60 = local_48;
              uStack_5c = uStack_44;
              uStack_58 = uStack_40;
              uStack_54 = uStack_3c;
              local_50 = local_38;
              while( true ) {
                cVar4 = FUN_1811d8280(&local_60,DAT_181d74c38);
                uVar3 = local_50;
                if (!cVar4) {
                  ZhSegment.Initialize(&local_60,DAT_181d74bb8);
                  return;
                }
                lVar5 = FUN_18046c100(0);
                if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (*(int64 *)(lVar5 + 144) == 0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar5 = FUN_180002f80(*(int64 *)(lVar5 + 144),uVar3 & 0xffffffff,DAT_181d64878);
                if (lVar5 == null) break;
                lVar5 = *(int64 *)(lVar5 + 72);
                if (lVar5 != null) {
                  cVar4 = FUN_1816fd990(lVar5,"伤害",0);
                  if (!cVar4) {
                    cVar4 = FUN_1816fd990(lVar5,"我方",0);
                    if (!cVar4) {
                      cVar4 = FUN_1816fd990(lVar5,"敌方",0);
                      if (cVar4) {
                        fVar1 = this.enemyUseSpeAddValue;
                        fVar8 = (float)HeroSpeAddData.Get(lVar7,uVar3 & 0xffffffff,0);
                        lVar5 = FUN_18046c100(0);
                        if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                          FUN_1800d6620();
                        }
                        if (*(int64 *)(lVar5 + 144) == 0) {
                          // WARNING: Subroutine does not return
                          FUN_1800d6620();
                        }
                        lVar5 = FUN_180002f80(*(int64 *)(lVar5 + 144),uVar3 & 0xffffffff,DAT_181d64878
                                             );
                        if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                          FUN_1800d6620();
                        }
                        this.enemyUseSpeAddValue = fVar8 / *(float *)(lVar5 + 32) + fVar1;
                      }
                    }
                    else {
                      fVar1 = this.selfUseSpeAddValue;
                      fVar8 = (float)HeroSpeAddData.Get(lVar7,uVar3 & 0xffffffff);
                      lVar5 = FUN_18046c100(0);
                      if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      if (*(int64 *)(lVar5 + 144) == 0) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      lVar5 = FUN_180002f80(*(int64 *)(lVar5 + 144),uVar3 & 0xffffffff,DAT_181d64878);
                      if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      this.selfUseSpeAddValue = fVar8 / *(float *)(lVar5 + 32) + fVar1;
                    }
                  }
                  else {
                    fVar1 = this.damageUseSpeAddValue;
                    fVar8 = (float)HeroSpeAddData.Get(lVar7,uVar3 & 0xffffffff);
                    lVar5 = FUN_18046c100(0);
                    if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    if (*(int64 *)(lVar5 + 144) == 0) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    lVar5 = FUN_180002f80(*(int64 *)(lVar5 + 144),uVar3 & 0xffffffff,DAT_181d64878);
                    if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    this.damageUseSpeAddValue = fVar8 / *(float *)(lVar5 + 32) + fVar1;
                  }
                }
              }
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
          }
        }
    }

    // Token : 0x6001237
    // RVA   : 0x21B660   Offset: 0x219E60   Length: 0x5
    public HeroSpeAddData GetSpeUseData()
    {
        return this.speUseData;
    }

    // Token : 0x6001238
    // RVA   : 0xB84570   Offset: 0xB82D70   Length: 0x6F
    public float SkillGetMaxExp(int expType)
    {
        long lVar1;
        lVar1 = KungfuSkillLvData.DataBase(this,0);
        if (lVar1 != null) {
          FUN_1801f7f00();
          Mathf.RoundToInt();
          return;
        }
    }

    // Token : 0x6001239
    // RVA   : 0xB803E0   Offset: 0xB7EBE0   Length: 0x103
    public bool CanUpgrade()
    {
        float fVar1;
        int iVar2;
        long lVar3;
        if (9 < this.lv) {
          return false;
        }
        fVar1 = this.bookExp;
        lVar3 = KungfuSkillLvData.DataBase(this,0);
        if (lVar3 != null) {
          FUN_1801f7f00();
          iVar2 = Mathf.RoundToInt();
          if (fVar1 < (float)iVar2) {
            return false;
          }
          fVar1 = this.fightExp;
          lVar3 = KungfuSkillLvData.DataBase(this,0);
          if (lVar3 != null) {
            FUN_1801f7f00();
            iVar2 = Mathf.RoundToInt();
            return (float)iVar2 <= fVar1;
          }
        }
    }

    // Token : 0x600123A
    // RVA   : 0xB80230   Offset: 0xB7EA30   Length: 0x84
    public bool BookExpFull()
    {
        float fVar1;
        int iVar2;
        long lVar3;
        fVar1 = this.bookExp;
        lVar3 = KungfuSkillLvData.DataBase(this,0);
        if (lVar3 != null) {
          FUN_1801f7f00();
          iVar2 = Mathf.RoundToInt();
          return (float)iVar2 <= fVar1;
        }
    }

    // Token : 0x600123B
    // RVA   : 0xB80850   Offset: 0xB7F050   Length: 0x84
    public bool FightExpFull()
    {
        float fVar1;
        int iVar2;
        long lVar3;
        fVar1 = this.fightExp;
        lVar3 = KungfuSkillLvData.DataBase(this,0);
        if (lVar3 != null) {
          FUN_1801f7f00();
          iVar2 = Mathf.RoundToInt();
          return (float)iVar2 <= fVar1;
        }
    }

    // Token : 0x600123C
    // RVA   : 0xB808F0   Offset: 0xB7F0F0   Length: 0xD6
    public void FullFillExp()
    {
        int iVar1;
        long lVar2;
        float fVar3;
        lVar2 = KungfuSkillLvData.DataBase(this,0);
        if (lVar2 != null) {
          fVar3 = (float)FUN_1801f7f00();
          iVar1 = Mathf.RoundToInt((float)(this.lv + 1) * fVar3 * 25.0 *
                                    *(float *)(lVar2 + 64),0);
          this.bookExp = (float)iVar1;
          lVar2 = KungfuSkillLvData.DataBase(this,0);
          if (lVar2 != null) {
            FUN_1801f7f00();
            iVar1 = Mathf.RoundToInt();
            this.skillIconDirty = 1;
            this.fightExp = (float)iVar1;
            return;
          }
        }
    }

    // Token : 0x600123D
    // RVA   : 0xB81C80   Offset: 0xB80480   Length: 0x29C
    public string GetExpDescribe()
    {
        long lVar2;
        long lVar3;
        ulong uVar4;
        int[] local_res8 = new int[4];
        uint[] local_res18 = new uint[2];
        int[] local_res20 = new int[2];
        uint[] local_28 = new uint[4];
        if (9 < this.lv) {
          return "登峰造极";
        }
        plVar1 = (int64 *)FUN_1800d60b0(DAT_181d7f180,4);
        local_res8[0] = (int)this.bookExp;
        lVar2 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
        if (plVar1 == (int64 *)0) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (lVar2 != null) {
          lVar3 = il2cpp_internal(lVar2,*(uint64 *)(*plVar1 + 64));
          if (lVar3 == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
        }
        if ((int)plVar1[3] == 0) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        plVar1[4] = lVar2;
        il2cpp_internal(plVar1 + 4,lVar2);
        local_res18[0] = KungfuSkillLvData.SkillGetMaxExp(this,0,0);
        lVar2 = il2cpp_value_box(DAT_181d7d0b8,local_res18);
        if (lVar2 != null) {
          lVar3 = il2cpp_internal(lVar2,*(uint64 *)(*plVar1 + 64));
          if (lVar3 == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
        }
        if (*(uint32 *)(plVar1 + 3) < 2) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        plVar1[5] = lVar2;
        il2cpp_internal(plVar1 + 5,lVar2);
        local_res20[0] = (int)this.fightExp;
        lVar2 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
        if (lVar2 != null) {
          lVar3 = il2cpp_internal(lVar2,*(uint64 *)(*plVar1 + 64));
          if (lVar3 == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
        }
        if (2 < *(uint32 *)(plVar1 + 3)) {
          plVar1[6] = lVar2;
          il2cpp_internal(plVar1 + 6,lVar2);
          local_28[0] = KungfuSkillLvData.SkillGetMaxExp(this,1);
          lVar2 = il2cpp_value_box(DAT_181d7d0b8,local_28);
          if (lVar2 != null) {
            lVar3 = il2cpp_internal(lVar2,*(uint64 *)(*plVar1 + 64));
            if (lVar3 == null) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
          }
          if (3 < *(uint32 *)(plVar1 + 3)) {
            plVar1[7] = lVar2;
            il2cpp_internal(plVar1 + 7,lVar2);
            uVar4 = String.Format("<color=#00B9FF>[理论{0}/{1}]</color>\n<color=#E07A18>[实战{2}/{3}]</color>",plVar1,0);
            return uVar4;
          }
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar4,0);
        }
        uVar4 = il2cpp_internal();
    }

    // Token : 0x600123E
    // RVA   : 0xB81210   Offset: 0xB7FA10   Length: 0xA3A
    public List<int> GetBreakThroughAvailableChoice()
    {
        var pStatics_6660 = *(int64*)(DAT_181d56660 + 184);
        var pStatics_e338 = *(int64*)(DAT_181d8e338 + 184);
        uint uVar1;
        long lVar2;
        ulong uVar3;
        bool cVar4;
        long lVar5;
        long lVar6;
        long lVar7;
        ulong uVar8;
        ulong uVar10;
        uint uVar11;
        uint uVar12;
        long lVar13;
        float fVar14;
        ulong local_a8;
        ulong uStack_a0;
        ulong local_98;
        long local_90;
        uint local_88;
        uint uStack_84;
        uint uStack_80;
        uint32 uStack_7c;
        uint64 local_78;
        int64 local_70;
        int64 local_68;
        local_70 = this;
        local_a8 = 0;
        uStack_a0 = 0;
        local_98 = 0;
        uVar12 = 0;
        if (*pStatics_e338 == 0) goto LAB_180b81c02;
        cVar4 = FUN_1808ab750(*pStatics_e338,this.skillID,
                              DAT_181d91b50);
        if (cVar4) {
          if ((*pStatics_e338 != 0) &&
             (lVar5 = FUN_1817cc780(*pStatics_e338,this.skillID,
                                    DAT_181d91bd8), lVar5 != null)) {
            uVar10 = FUN_180f582c0(lVar5,DAT_181d680f0);
            lVar5 = il2cpp_internal(DAT_181d6f030);
            FUN_18182e120(lVar5,uVar10,DAT_181d67978);
            return lVar5;
          }
          goto LAB_180b81c02;
        }
        lVar5 = KungfuSkillLvData.DataBase(this,0);
        local_90 = lVar5;
        lVar6 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(lVar6,DAT_181d678f8);
        if (lVar5 == null) goto LAB_180b81c02;
        if (*(int *)(lVar5 + 48) < 3) {
          if (lVar6 == null) goto LAB_180b81c02;
          FUN_181814fa0(lVar6,*(int *)(lVar5 + 48) + 6,DAT_181d67a78);
          lVar7 = il2cpp_internal(DAT_181d6f030);
          FUN_180f58a90(lVar7,DAT_181d678f8);
          if (lVar7 == null) goto LAB_180b81c02;
          FUN_181814fa0(lVar7,57,DAT_181d67a78);
          uVar10 = 59;
        LAB_180b815a2:
          FUN_181814fa0(lVar7,uVar10,DAT_181d67a78);
        }
        else {
          if (*(int *)(lVar5 + 28) == 4) {
            lVar7 = il2cpp_internal(DAT_181d6f030);
            FUN_180f58a90(lVar7,DAT_181d678f8);
            if (lVar7 == null) goto LAB_180b81c02;
            FUN_181814fa0(lVar7,208,DAT_181d67a78);
            FUN_181814fa0(lVar7,209,DAT_181d67a78);
            uVar10 = 210;
            goto LAB_180b815a2;
          }
          if (0.0 < *(float *)(lVar5 + 60)) {
            lVar7 = il2cpp_internal(DAT_181d6f030);
            FUN_180f58a90(lVar7,DAT_181d678f8);
            if (lVar7 == null) goto LAB_180b81c02;
            FUN_181814fa0(lVar7,60,DAT_181d67a78);
            FUN_181814fa0(lVar7,64,DAT_181d67a78);
            FUN_181814fa0(lVar7,66,DAT_181d67a78);
            FUN_181814fa0(lVar7,69,DAT_181d67a78);
            FUN_181814fa0(lVar7,70,DAT_181d67a78);
          }
          else {
            lVar7 = il2cpp_internal(DAT_181d6f030);
            FUN_180f58a90(lVar7,DAT_181d678f8);
            if (lVar7 == null) goto LAB_180b81c02;
            FUN_181814fa0(lVar7,66,DAT_181d67a78);
            FUN_181814fa0(lVar7,70,DAT_181d67a78);
          }
        }
        uVar10 = Enumerable.Concat(lVar6,lVar7,DAT_181d89db8);
        lVar6 = FUN_180961530(uVar10,DAT_181d8c638);
        local_68 = lVar6;
        if (*(int64 *)(lVar5 + 72) == 0) {
        LAB_180b81743:
          if ((*(int *)(lVar5 + 48) < 3) && (*(int64 *)(lVar5 + 88) != 0)) {
            lVar7 = *(int64 *)(*(int64 *)(lVar5 + 88) + 16);
            if ((lVar7 == null) || (lVar7 = Dictionary_2.get_Keys(lVar7,DAT_181d98b10)) == null)
            goto LAB_180b81c02;
            FUN_180ed4d30(&local_88,lVar7,DAT_181d9c570);
            local_a8 = CONCAT44(uStack_84,local_88);
            uStack_a0 = CONCAT44(uStack_7c,uStack_80);
            local_98 = local_78;
            while (cVar4 = FUN_1811d8280(&local_a8,DAT_181d74c38), uVar3 = local_98, cVar4) {
              if (*(int64 *)(lVar5 + 88) == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              fVar14 = (float)HeroSpeAddData.Get(*(int64 *)(lVar5 + 88),local_98 & 0xffffffff,0);
              if (fVar14 != 0.0) {
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                FUN_181814fa0(lVar6,uVar3 & 0xffffffff);
              }
            }
            ZhSegment.Initialize(&local_a8,DAT_181d74bb8);
          }
          if (*(int64 *)(lVar5 + 96) != 0) {
            lVar7 = *(int64 *)(*(int64 *)(lVar5 + 96) + 16);
            if ((lVar7 == null) || (lVar7 = Dictionary_2.get_Keys(lVar7,DAT_181d98b10)) == null)
            goto LAB_180b81c02;
            FUN_180ed4d30(&local_88,lVar7,DAT_181d9c570);
            local_a8 = CONCAT44(uStack_84,local_88);
            uStack_a0 = CONCAT44(uStack_7c,uStack_80);
            local_98 = local_78;
            while (cVar4 = FUN_1811d8280(&local_a8,DAT_181d74c38), uVar3 = local_98, cVar4) {
              if (*(int64 *)(lVar5 + 96) == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              fVar14 = (float)HeroSpeAddData.Get(*(int64 *)(lVar5 + 96),local_98 & 0xffffffff,0);
              if (fVar14 != 0.0) {
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                FUN_181814fa0(lVar6,uVar3 & 0xffffffff);
              }
            }
            ZhSegment.Initialize(&local_a8,DAT_181d74bb8);
          }
          if (*(int64 *)(lVar5 + 104) != 0) {
            lVar7 = *(int64 *)(*(int64 *)(lVar5 + 104) + 16);
            if ((lVar7 == null) || (lVar7 = Dictionary_2.get_Keys(lVar7,DAT_181d98b10)) == null)
            goto LAB_180b81c02;
            FUN_180ed4d30(&local_88,lVar7,DAT_181d9c570);
            local_a8 = CONCAT44(uStack_84,local_88);
            uStack_a0 = CONCAT44(uStack_7c,uStack_80);
            local_98 = local_78;
            while (cVar4 = FUN_1811d8280(&local_a8,DAT_181d74c38), uVar3 = local_98, cVar4) {
              if (*(int64 *)(lVar5 + 104) == 0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              fVar14 = (float)HeroSpeAddData.Get(*(int64 *)(lVar5 + 104),local_98 & 0xffffffff,0);
              if (fVar14 != 0.0) {
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                FUN_181814fa0(lVar6,uVar3 & 0xffffffff);
              }
            }
            ZhSegment.Initialize(&local_a8,DAT_181d74bb8);
          }
          lVar5 = *(int64 *)(pStatics_6660 + 8);
          if (lVar5 == null) {
            uVar10 = **(uint64 **)(DAT_181d56660 + 184);
            lVar5 = new OnTooltipCB(uVar10,DAT_181d7db68,DAT_181d95e70);
            plVar9 = (int64 *)(pStatics_6660 + 8);
            *plVar9 = lVar5;
            il2cpp_internal(plVar9,lVar5);
          }
          if (lVar6 != null) {
            FUN_181818fa0(lVar6,lVar5,DAT_181d67ef0);
            if (((*(byte *)(DAT_181d8e338 + 0x133) & 4) == 0) || (*(int *)(DAT_181d8e338 + 224) != 0)) {
              lVar5 = *pStatics_e338;
              lVar7 = lVar6;
            }
            else {
              il2cpp_runtime_class_init(DAT_181d8e338);
              lVar5 = *pStatics_e338;
              this = local_70;
              lVar7 = local_68;
            }
            uVar1 = this.skillID;
            uVar10 = FUN_180f582c0(lVar7,DAT_181d680f0);
            uVar8 = il2cpp_internal(DAT_181d6f030);
            FUN_18182e120(uVar8,uVar10,DAT_181d67978);
            if (lVar5 != null) {
              FUN_1808ab680(lVar5,uVar1,uVar8,DAT_181d91ac8);
              return lVar6;
            }
          }
        }
        else {
          lVar7 = 32;
          lVar13 = 32;
          uVar11 = uVar12;
          while ((*(int64 *)(lVar5 + 72) != 0 &&
                 (lVar2 = *(int64 *)(*(int64 *)(lVar5 + 72) + 16)) != null)) {
            if ((int)*(uint32 *)(lVar2 + 24) <= (int)uVar11) {
              lVar13 = 32;
              uVar11 = uVar12;
              goto LAB_180b81670;
            }
            if (*(uint32 *)(lVar2 + 24) <= uVar11) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(float *)(lVar13 + *(int64 *)(lVar2 + 16)) != 0.0) {
              if (lVar6 == null) break;
              FUN_181814fa0(lVar6,uVar11,DAT_181d67a78);
            }
            uVar11 = uVar11 + 1;
            lVar13 = lVar13 + 4;
          }
        }
        LAB_180b81c02:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180b81670:
        if ((*(int64 *)(lVar5 + 72) == 0) ||
           (lVar2 = *(int64 *)(*(int64 *)(lVar5 + 72) + 24)) == null) goto LAB_180b81c02;
        if ((int)*(uint32 *)(lVar2 + 24) <= (int)uVar11) goto LAB_180b816e0;
        if (*(uint32 *)(lVar2 + 24) <= uVar11) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (*(float *)(lVar13 + *(int64 *)(lVar2 + 16)) != 0.0) {
          if (lVar6 == null) goto LAB_180b81c02;
          FUN_181814fa0(lVar6,uVar11 + 6,DAT_181d67a78);
        }
        uVar11 = uVar11 + 1;
        lVar13 = lVar13 + 4;
        goto LAB_180b81670;
        LAB_180b816e0:
        if ((*(int64 *)(lVar5 + 72) == 0) ||
           (lVar13 = *(int64 *)(*(int64 *)(lVar5 + 72) + 32)) == null) goto LAB_180b81c02;
        if ((int)*(uint32 *)(lVar13 + 24) <= (int)uVar12) goto LAB_180b81743;
        if (*(uint32 *)(lVar13 + 24) <= uVar12) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (*(float *)(lVar7 + *(int64 *)(lVar13 + 16)) != 0.0) {
          if (lVar6 == null) goto LAB_180b81c02;
          FUN_181814fa0(lVar6,uVar12 + 24,DAT_181d67a78);
        }
        uVar12 = uVar12 + 1;
        lVar7 = lVar7 + 4;
        goto LAB_180b816e0;
    }

    // Token : 0x600123F
    // RVA   : 0xB80010   Offset: 0xB7E810   Length: 0x214
    public void AutoManageBreakThrough(int rareLv)
    {
        uint uVar1;
        long lVar2;
        uint uVar3;
        long lVar4;
        ulong uVar5;
        float fVar6;
        lVar4 = KungfuSkillLvData.GetBreakThroughAvailableChoice(this,0);
        if (lVar4 != null) {
          uVar1 = *(uint32 *)(lVar4 + 24);
          uVar3 = GlobalData.RandomRange(0,uVar1,0,0);
          if (*(uint32 *)(lVar4 + 24) <= uVar3) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar3 = lVar4[uVar3];
          lVar4 = new HeroSpeAddData(0);
          fVar6 = (float)Mathf.Max(0x3f000000);
          lVar2 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
          if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 144)) != null) {
            if (*(uint32 *)(lVar2 + 24) <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = lVar2[uVar3];
            if ((lVar2 != null) && (lVar4 != null)) {
              uVar5 = HeroSpeAddData.Set(lVar4,uVar3,*(float *)(lVar2 + 32) * fVar6,0);
              uVar5 = HeroSpeAddData.op_Addition(this.extraAddData,uVar5,0);
              this.extraAddData = uVar5;
              return;
            }
          }
        }
    }

    // Token : 0x6001240
    // RVA   : 0xB80780   Offset: 0xB7EF80   Length: 0xD
    public static float CountDamageRatio(float sourceNum, float addRatio)
    {
        float FUN_180b80780(float sourceNum,float addRatio)
        {
        return sourceNum * 0.01 * addRatio;
    }

    // Token : 0x6001241
    // RVA   : 0xB80A40   Offset: 0xB7F240   Length: 0x7C3
    public HeroData GetBelongHero()
    {
        var pStatics_b128 = *(int64*)(DAT_181d8b128 + 184);
        var pStatics_c960 = *(int64*)(DAT_181d6c960 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        bool cVar1;
        ulong uVar2;
        long lVar3;
        int iVar4;
        int iVar5;
        if (this.belongHeroID < 0) {
          lVar3 = *(int64 *)(pStatics_b128 + 80);
          if (lVar3 != null) {
            iVar4 = 0;
            if (*(int *)(lVar3 + 36) == 0) {
        LAB_180b81060:
              do {
                if ((*pStatics_c960 == 0) ||
                   (lVar3 = *(int64 *)(*pStatics_c960 + 0x100)) == null)
                goto LAB_180b811fe;
                if (*(int *)(lVar3 + 24) <= iVar4) {
                  return 0;
                }
                lVar3 = FUN_18046c440(0);
                if ((lVar3 == null) || (*(int64 *)(lVar3 + 0x100) == 0)) goto LAB_180b811fe;
                lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 0x100),iVar4,DAT_181d643f8);
                if (lVar3 != null) {
                  lVar3 = FUN_18046c440(0);
                  if ((((lVar3 == null) || (*(int64 *)(lVar3 + 0x100) == 0)) ||
                      (lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 0x100),iVar4,DAT_181d643f8), lVar3 == null
                      )) || (*(int64 *)(lVar3 + 0x260) == 0)) goto LAB_180b811fe;
                  cVar1 = FUN_1818279a0(*(int64 *)(lVar3 + 0x260),this,DAT_181d6aa68);
                  if (cVar1) goto LAB_180b811b3;
                }
                iVar4 = iVar4 + 1;
              } while( true );
            }
            iVar5 = 0;
            while( true ) {
              lVar3 = *(int64 *)(pStatics_b128 + 80);
              if ((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 64)) == null) break;
              if (*(int *)(lVar3 + 24) <= iVar5) {
                iVar5 = 0;
                goto LAB_180b80e30;
              }
              iVar4 = 0;
              while( true ) {
                lVar3 = FUN_18046bb80(0);
                if (((lVar3 == null) || (*(int64 *)(lVar3 + 64) == 0)) ||
                   (lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 64),iVar5,DAT_181d51208)) == null)
                goto LAB_180b811fe;
                if (*(int *)(lVar3 + 24) <= iVar4) break;
                lVar3 = FUN_18046bb80(0);
                if (((lVar3 == null) || (*(int64 *)(lVar3 + 64) == 0)) ||
                   ((lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 64),iVar5,DAT_181d51208), lVar3 == null ||
                    ((lVar3 = FUN_180002f80(lVar3,iVar4,DAT_181d643f8), lVar3 == null ||
                     (*(int64 *)(lVar3 + 0x260) == 0)))))) goto LAB_180b811fe;
                cVar1 = FUN_1818279a0(*(int64 *)(lVar3 + 0x260),this,DAT_181d6aa68);
                if (cVar1) {
                  lVar3 = FUN_18046bb80(0);
                  if (((lVar3 == null) || (*(int64 *)(lVar3 + 64) == 0)) ||
                     (lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 64),iVar5,DAT_181d51208)) == null)
                  goto LAB_180b811fe;
                  goto LAB_180b80e0c;
                }
                iVar4 = iVar4 + 1;
              }
              iVar5 = iVar5 + 1;
            }
          }
        }
        else {
          if ((*pStatics_df90 != 0) &&
             (lVar3 = *(int64 *)(*pStatics_df90 + 32)) != null) {
            uVar2 = WorldData.GetHero(lVar3,this.belongHeroID,0);
            return uVar2;
          }
        }
        LAB_180b811fe:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180b80e30:
        lVar3 = *(int64 *)(pStatics_b128 + 80);
        if ((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 112)) == null) goto LAB_180b811fe;
        iVar4 = 0;
        if (*(int *)(lVar3 + 24) <= iVar5) goto LAB_180b81060;
        iVar4 = 0;
        while( true ) {
          lVar3 = FUN_18046bb80(0);
          if ((((lVar3 == null) || (*(int64 *)(lVar3 + 112) == 0)) ||
              (lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 112),iVar5,DAT_181d580a8)) == null) ||
             (*(int64 *)(lVar3 + 24) == 0)) goto LAB_180b811fe;
          if (*(int *)(*(int64 *)(lVar3 + 24) + 24) <= iVar4) break;
          lVar3 = FUN_18046bb80(0);
          if ((((lVar3 == null) || (*(int64 *)(lVar3 + 112) == 0)) ||
              ((lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 112),iVar5,DAT_181d580a8), lVar3 == null ||
               (((*(int64 *)(lVar3 + 24) == 0 ||
                 (lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 24),iVar4,DAT_181d584a0)) == null) ||
                (*(int64 *)(lVar3 + 64) == 0)))))) ||
             (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 64) + 0x260)) == null) goto LAB_180b811fe;
          cVar1 = FUN_1818279a0(lVar3,this,DAT_181d6aa68);
          if (cVar1) {
            lVar3 = FUN_18046bb80(0);
            if (((lVar3 != null) && (*(int64 *)(lVar3 + 112) != 0)) &&
               ((lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 112),iVar5,DAT_181d580a8), lVar3 != null &&
                ((*(int64 *)(lVar3 + 24) != 0 &&
                 (lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 24),iVar4,DAT_181d584a0)) != null)))))
            {
              return *(uint64 *)(lVar3 + 64);
            }
            goto LAB_180b811fe;
          }
          iVar4 = iVar4 + 1;
        }
        iVar5 = iVar5 + 1;
        goto LAB_180b80e30;
        LAB_180b811b3:
        lVar3 = FUN_18046c440(0);
        if ((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 0x100)) != null) {
        LAB_180b80e0c:
          uVar2 = FUN_180002f80(lVar3,iVar4,DAT_181d643f8);
          return uVar2;
        }
        goto LAB_180b811fe;
    }

    // Token : 0x6001242
    // RVA   : 0xB83670   Offset: 0xB81E70   Length: 0x4FE
    public float GetSkillFightScore()
    {
        int iVar1;
        long lVar2;
        long lVar3;
        long lVar4;
        uint uVar5;
        long lVar6;
        uint uVar7;
        long lVar8;
        float fVar9;
        float fVar10;
        lVar3 = KungfuSkillLvData.DataBase(this,0);
        if (lVar3 != null) {
          iVar1 = this.lv;
          fVar10 = *(float *)(lVar3 + 60);
          fVar9 = (float)FUN_1810a8ba0((float)(iVar1 + -4) * 0.25 + 1.0,0x3dcccccd,0x3f800000,0);
          fVar9 = fVar9 * ((float)iVar1 * 0.1 + 1.0) * fVar10;
          lVar3 = KungfuSkillLvData.GetBelongHero(this,0);
          if (lVar3 == null) {
            return;
          }
          if (-1 < *(int *)(lVar3 + 132)) {
            lVar4 = KungfuSkillLvData.DataBase(this,0);
            if (lVar4 == null) goto LAB_180b83b69;
            if (*(int *)(lVar4 + 24) == *(int *)(lVar3 + 132)) {
              if (*(int64 *)(lVar3 + 0x2b8) == 0) goto LAB_180b83b69;
              fVar10 = (float)HeroSpeAddData.Get(*(int64 *)(lVar3 + 0x2b8),213,0);
              fVar9 = fVar9 * (fVar10 + 1.0);
            }
          }
          lVar4 = KungfuSkillLvData.DataBase(this,0);
          uVar7 = 0;
          uVar5 = 0;
          if (lVar4 != null) {
            lVar8 = 32;
            lVar6 = 32;
            do {
              if ((*(int64 *)(lVar4 + 72) == 0) ||
                 (lVar2 = *(int64 *)(*(int64 *)(lVar4 + 72) + 16)) == null) break;
              if ((int)*(uint32 *)(lVar2 + 24) <= (int)uVar5) {
                uVar5 = 0;
                lVar6 = 32;
                goto LAB_180b838c0;
              }
              if (*(uint32 *)(lVar2 + 24) <= uVar5) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (*(float *)(*(int64 *)(lVar2 + 16) + lVar6) != 0.0) {
                if (*(int64 *)(lVar3 + 0x138) == 0) break;
                FUN_1800d6780(*(int64 *)(lVar3 + 0x138),uVar5,DAT_181d796d8);
                if ((*(int64 *)(lVar4 + 72) == 0) ||
                   (lVar2 = *(int64 *)(*(int64 *)(lVar4 + 72) + 16)) == null) break;
                FUN_1800d6780(lVar2,uVar5);
              }
              uVar5 = uVar5 + 1;
              lVar6 = lVar6 + 4;
            } while( true );
          }
        }
        LAB_180b83b69:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180b838c0:
        if ((*(int64 *)(lVar4 + 72) == 0) ||
           (lVar2 = *(int64 *)(*(int64 *)(lVar4 + 72) + 24)) == null) goto LAB_180b83b69;
        if ((int)*(uint32 *)(lVar2 + 24) <= (int)uVar5) goto LAB_180b83960;
        if (*(uint32 *)(lVar2 + 24) <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (*(float *)(*(int64 *)(lVar2 + 16) + lVar6) != 0.0) {
          if (*(int64 *)(lVar3 + 0x150) == 0) goto LAB_180b83b69;
          FUN_1800d6780(*(int64 *)(lVar3 + 0x150),uVar5,DAT_181d796d8);
          if ((*(int64 *)(lVar4 + 72) == 0) ||
             (lVar2 = *(int64 *)(*(int64 *)(lVar4 + 72) + 24)) == null) goto LAB_180b83b69;
          FUN_1800d6780(lVar2,uVar5);
        }
        uVar5 = uVar5 + 1;
        lVar6 = lVar6 + 4;
        goto LAB_180b838c0;
        LAB_180b83960:
        if ((*(int64 *)(lVar4 + 72) == 0) ||
           (lVar6 = *(int64 *)(*(int64 *)(lVar4 + 72) + 32)) == null) goto LAB_180b83b69;
        if ((int)*(uint32 *)(lVar6 + 24) <= (int)uVar7) {
          BattleController.LimitDamageRatio();
          if (*(int64 *)(lVar3 + 0x2b8) == 0) goto LAB_180b83b69;
          HeroSpeAddData.Get(*(int64 *)(lVar3 + 0x2b8),*(int *)(lVar4 + 48) + 15,0);
          if (0.0 < fVar9) {
            if (*(int64 *)(lVar3 + 0x2b8) == 0) goto LAB_180b83b69;
            HeroSpeAddData.Get(*(int64 *)(lVar3 + 0x2b8),60);
          }
          Mathf.Max();
          return;
        }
        if (*(uint32 *)(lVar6 + 24) <= uVar7) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (*(float *)(lVar8 + *(int64 *)(lVar6 + 16)) != 0.0) {
          if (*(int64 *)(lVar3 + 0x168) == 0) goto LAB_180b83b69;
          FUN_1800d6780(*(int64 *)(lVar3 + 0x168),uVar7,DAT_181d796d8);
          if ((*(int64 *)(lVar4 + 72) == 0) ||
             (lVar6 = *(int64 *)(*(int64 *)(lVar4 + 72) + 32)) == null) goto LAB_180b83b69;
          FUN_1800d6780(lVar6,uVar7);
        }
        uVar7 = uVar7 + 1;
        lVar8 = lVar8 + 4;
        goto LAB_180b83960;
    }

    // Token : 0x6001243
    // RVA   : 0xB81FD0   Offset: 0xB807D0   Length: 0x216
    public string GetSkillBattleCountDescribe()
    {
        uint uVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        ulong uVar6;
        ulong uVar7;
        ulong uVar8;
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        local_res18[0] = 0;
        lVar3 = KungfuSkillLvData.DataBase(this,0);
        if (lVar3 != null) {
          uVar2 = *(uint64 *)(lVar3 + 32);
          uVar1 = *(uint32 *)(lVar3 + 52);
          uVar4 = GlobalData.GenerateRareLvColorText(uVar2,uVar1,0);
          local_res20[0] = this.useTime;
          uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
          lVar3 = KungfuSkillLvData.DataBase(this,0);
          uVar2 = "{0}\n使用次数 {1}{2}";
          if (lVar3 != null) {
            uVar7 = "";
            if (2 < *(int *)(lVar3 + 48)) {
              lVar3 = KungfuSkillLvData.DataBase(this,0);
              uVar7 = "\n造成{0} {1}";
              if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar8 = "伤害";
              if (((float)this.lv * 0.1 + 1.0) * *(float *)(lVar3 + 60) < 0.0) {
                uVar8 = "治疗";
              }
              local_res18[0] = this.battleDamageCount & 0x7fffffff;
              uVar6 = Single.ToString(local_res18,"f0",0);
              uVar7 = String.Format(uVar7,uVar8,uVar6,0);
            }
            String.Format(uVar2,uVar4,uVar5,uVar7,0);
            return;
          }
        }
    }

    // Token : 0x6001244
    // RVA   : 0xB821F0   Offset: 0xB809F0   Length: 0x1426
    public string GetSkillDescribe(bool fullDetail, bool showDamage, bool bookDescribe)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int64 KungfuSkillLvData.GetSkillDescribe
                         (int64 this,char fullDetail,char showDamage,char bookDescribe)
        {
        int iVar1;
        char cVar2;
        int64 lVar3;
        int64 lVar4;
        int64 lVar5;
        int64 *plVar6;
        uint64 uVar7;
        uint64 uVar8;
        int64 lVar9;
        uint64 uVar10;
        uint64 uVar11;
        uint64 uVar12;
        char cVar13;
        bool bVar14;
        float fVar15;
        uint32 uVar16;
        float fVar17;
        uint64 in_stack_ffffffffffffff78;
        float local_78;
        float local_74;
        int local_70;
        int local_6c;
        int local_68 [16];
        local_78 = 0.0;
        lVar3 = KungfuSkillLvData.GetBelongHero(this,0);
        if (lVar3 == null) {
          if ((*pStatics == 0) ||
             (lVar3 = *(int64 *)(*pStatics + 32)) == null)
          throw; // [null/range check failed]
          lVar3 = WorldData.Player(lVar3,0);
        }
        lVar5 = "";
        lVar4 = KungfuSkillLvData.DataBase(this,0);
        if (lVar4 == null) throw; // [null/range check failed]
        cVar13 = true;
        if (*(char *)(lVar4 + 16) == false) {
          cVar13 = fullDetail;
        }
        lVar4 = KungfuSkillLvData.DataBase(this,0);
        if (lVar4 == null) throw; // [null/range check failed]
        if (2 < *(int *)(lVar4 + 48)) {
          lVar5 = String.Concat(lVar5,"\n",0);
          lVar4 = KungfuSkillLvData.DataBase(this,0);
          if (lVar4 == null) throw; // [null/range check failed]
          if (*(float *)(lVar4 + 60) != 0.0) {
            lVar4 = KungfuSkillLvData.DataBase(this,0);
            if (lVar4 == null) throw; // [null/range check failed]
            cVar2 = false;
            if (*(char *)(lVar4 + 16) == false) {
              cVar2 = showDamage;
            }
            if (!cVar2) {
              bVar14 = false;
            }
            else {
              lVar4 = KungfuSkillLvData.GetBelongHero(this,0);
              bVar14 = lVar4 != null;
            }
            uVar8 = "\n<b>{2}{0}{1}</color></b>";
            if (bVar14) {
              plVar6 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,5);
              if (plVar6 == (int64 *)0) throw; // [null/range check failed]
              if ((lVar5 != null) &&
                 (lVar4 = il2cpp_internal(lVar5,*(uint64 *)(*plVar6 + 64))) == null) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              if ((int)plVar6[3] == 0) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              plVar6[4] = lVar5;
              il2cpp_internal(plVar6 + 4,lVar5);
              if (("\n<size=18><b>" != 0) &&
                 (lVar5 = il2cpp_internal("\n<size=18><b>",*(uint64 *)(*plVar6 + 64))) == null)
              {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              lVar5 = "\n<size=18><b>";
              if (*(uint32 *)(plVar6 + 3) < 2) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              plVar6[5] = "\n<size=18><b>";
              il2cpp_internal(plVar6 + 5,lVar5);
              lVar5 = KungfuSkillLvData.DataBase(this,0);
              if (lVar5 == null) throw; // [null/range check failed]
              lVar4 = "<color=#008B8B>治疗 ";
              if (0.0 < *(float *)(lVar5 + 60)) {
                lVar4 = "<color=#D2691E>伤害 ";
              }
              if ((lVar4 != null) &&
                 (lVar5 = il2cpp_internal(lVar4,*(uint64 *)(*plVar6 + 64))) == null) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              if (*(uint32 *)(plVar6 + 3) < 3) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              plVar6[6] = lVar4;
              il2cpp_internal(plVar6 + 6,lVar4);
              local_78 = (float)KungfuSkillLvData.GetSkillFightScore(this,0);
              lVar5 = Single.ToString(&local_78,"f0",0);
              if ((lVar5 != null) &&
                 (lVar4 = il2cpp_internal(lVar5,*(uint64 *)(*plVar6 + 64))) == null) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              if (*(uint32 *)(plVar6 + 3) < 4) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              plVar6[7] = lVar5;
              il2cpp_internal(plVar6 + 7,lVar5);
              if (("</color></b></size>" != 0) &&
                 (lVar5 = il2cpp_internal("</color></b></size>",*(uint64 *)(*plVar6 + 64))) == null)
              {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              lVar5 = "</color></b></size>";
              if (*(uint32 *)(plVar6 + 3) < 5) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              plVar6[8] = "</color></b></size>";
              il2cpp_internal(plVar6 + 8,lVar5);
              lVar5 = String.Concat(plVar6,0);
              uVar8 = "\n<size=15><color=grey>{0}{1}</color></size>";
            }
            lVar4 = KungfuSkillLvData.DataBase(this,0);
            if (lVar4 == null) throw; // [null/range check failed]
            uVar10 = "基础治疗 ";
            if (0.0 < *(float *)(lVar4 + 60)) {
              uVar10 = "基础伤害 ";
            }
            lVar4 = KungfuSkillLvData.DataBase(this,0);
            if (lVar4 == null) {
        LAB_180b835ff:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_74 = ABS(((float)this.lv * 0.1 + 1.0) * *(float *)(lVar4 + 60));
            uVar7 = il2cpp_value_box(DAT_181d7d0b8,&local_74);
            lVar4 = KungfuSkillLvData.DataBase(this,0);
            if (lVar4 == null) goto LAB_180b835ff;
            uVar11 = "<color=#008B8B>";
            if (0.0 < *(float *)(lVar4 + 60)) {
              uVar11 = "<color=#D2691E>";
            }
            in_stack_ffffffffffffff78 = 0;
            uVar8 = String.Format(uVar8,uVar10,uVar7,uVar11,0);
            lVar5 = String.Concat(lVar5,uVar8,0);
          }
          lVar4 = KungfuSkillLvData.DataBase(this,0);
          if (lVar4 == null) throw; // [null/range check failed]
          if (((float)this.lv * 0.1 + 1.0) * *(float *)(lVar4 + 56) != 0.0) {
            lVar4 = KungfuSkillLvData.DataBase(this,0);
            if (lVar4 == null) throw; // [null/range check failed]
            local_78 = ((float)this.lv * 0.1 + 1.0) * *(float *)(lVar4 + 56);
            uVar8 = Single.ToString(&local_78,"f0",0);
            uVar8 = String.Format("内力消耗 {0}",uVar8,0);
            in_stack_ffffffffffffff78 = 0;
            lVar5 = String.Concat(lVar5,"\n<size=15><color=#0066FF>",uVar8,"</color></size>",0);
          }
          lVar4 = KungfuSkillLvData.DataBase(this,0);
          if (lVar4 == null) throw; // [null/range check failed]
          if (-1 < *(int *)(lVar4 + 128)) {
            lVar4 = FUN_18046c100(0);
            if (lVar4 == null) throw; // [null/range check failed]
            lVar4 = *(int64 *)(lVar4 + 0x180);
            lVar9 = KungfuSkillLvData.DataBase(this,0);
            if (((lVar9 == null) || (lVar4 == null)) ||
               (lVar4 = FUN_1817cc780(lVar4,*(uint32 *)(lVar9 + 128),DAT_181d99060)) == null)
            throw; // [null/range check failed]
            lVar5 = String.Concat(lVar5,"\n召唤 ",*(uint64 *)(lVar4 + 24),0);
          }
          lVar4 = KungfuSkillLvData.DataBase(this,0);
          if (lVar4 == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar4 + 104) != 0) {
            lVar4 = KungfuSkillLvData.DataBase(this,0);
            if ((lVar4 == null) || (*(int64 *)(lVar4 + 104) == 0)) throw; // [null/range check failed]
            cVar2 = HeroSpeAddData.isEmpty(*(int64 *)(lVar4 + 104),0);
            if (!cVar2) {
              if (this.speUseData == null) throw; // [null/range check failed]
              in_stack_ffffffffffffff78 = in_stack_ffffffffffffff78 & 0xffffffffffffff00;
              uVar8 = HeroSpeAddData.GetDescribe
                                (this.speUseData,1,1,1,in_stack_ffffffffffffff78,0);
              lVar5 = String.Concat(lVar5,"\n",uVar8,0);
            }
          }
          lVar4 = KungfuSkillLvData.DataBase(this,0);
          if (lVar4 == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar4 + 72) != 0) {
            lVar4 = KungfuSkillLvData.DataBase(this,0);
            if (lVar4 == null) throw; // [null/range check failed]
            uVar8 = "\n\n治疗加成 \n";
            if (0.0 < *(float *)(lVar4 + 60)) {
              uVar8 = "\n\n伤害加成 \n";
            }
            lVar4 = KungfuSkillLvData.DataBase(this,0);
            if (lVar4 == null) throw; // [null/range check failed]
            lVar4 = *(int64 *)(lVar4 + 72);
            lVar9 = KungfuSkillLvData.DataBase(this,0);
            if (lVar9 == null) throw; // [null/range check failed]
            if (*(float *)(lVar9 + 60) <= 0.0) {
              uVar16 = 0x41200000;
            }
            else {
              uVar16 = 0x3f800000;
            }
            if (lVar4 == null) throw; // [null/range check failed]
            uVar10 = AttriNumData.GetDamageRatioDescribe(lVar4,uVar16,0);
            lVar5 = String.Concat(lVar5,uVar8,uVar10,0);
          }
          lVar4 = KungfuSkillLvData.DataBase(this,0);
          if (lVar4 == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar4 + 136) != 0) {
            lVar4 = KungfuSkillLvData.DataBase(this,0);
            if ((lVar4 == null) || (*(int64 *)(lVar4 + 136) == 0)) throw; // [null/range check failed]
            cVar2 = PartPostureData.IsEmpty(*(int64 *)(lVar4 + 136),0);
            if ((!cVar2) && (!bookDescribe || cVar13)) {
              lVar4 = KungfuSkillLvData.DataBase(this,0);
              if ((lVar4 == null) || (*(int64 *)(lVar4 + 136) == 0)) throw; // [null/range check failed]
              uVar8 = PartPostureData.GetSkillDescribe(*(int64 *)(lVar4 + 136),0);
              lVar5 = String.Concat(lVar5,"\n\n进攻架势 \n",uVar8,0);
            }
          }
          lVar4 = KungfuSkillLvData.DataBase(this,0);
          if (lVar4 == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar4 + 144) != 0) {
            lVar4 = KungfuSkillLvData.DataBase(this,0);
            if ((lVar4 == null) || (*(int64 *)(lVar4 + 144) == 0)) throw; // [null/range check failed]
            cVar2 = PartPostureData.IsEmpty(*(int64 *)(lVar4 + 144),0);
            if ((!cVar2) && (!bookDescribe || cVar13)) {
              lVar4 = KungfuSkillLvData.DataBase(this,0);
              if ((lVar4 == null) || (*(int64 *)(lVar4 + 144) == 0)) throw; // [null/range check failed]
              uVar8 = PartPostureData.GetSkillDescribe(*(int64 *)(lVar4 + 144),0);
              lVar5 = String.Concat(lVar5,"\n防御架势 \n",uVar8,0);
            }
          }
          lVar4 = KungfuSkillLvData.DataBase(this,0);
          if (lVar4 == null) throw; // [null/range check failed]
          if (0 < *(int *)(lVar4 + 132)) {
            plVar6 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,5);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            if ((lVar5 != null) &&
               (lVar4 = il2cpp_internal(lVar5,*(uint64 *)(*plVar6 + 64))) == null) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            if ((int)plVar6[3] == 0) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            plVar6[4] = lVar5;
            il2cpp_internal(plVar6 + 4,lVar5);
            if (("\n\n每场战斗使用次数 " != 0) &&
               (lVar5 = il2cpp_internal("\n\n每场战斗使用次数 ",*(uint64 *)(*plVar6 + 64))) == null) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            lVar5 = "\n\n每场战斗使用次数 ";
            if (*(uint32 *)(plVar6 + 3) < 2) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            plVar6[5] = "\n\n每场战斗使用次数 ";
            il2cpp_internal(plVar6 + 5,lVar5);
            lVar5 = Int32.ToString(this + 92,0);
            if ((lVar5 != null) &&
               (lVar4 = il2cpp_internal(lVar5,*(uint64 *)(*plVar6 + 64))) == null) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            if (*(uint32 *)(plVar6 + 3) < 3) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            plVar6[6] = lVar5;
            il2cpp_internal(plVar6 + 6,lVar5);
            if (("/" != 0) &&
               (lVar5 = il2cpp_internal("/",*(uint64 *)(*plVar6 + 64))) == null) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            lVar5 = "/";
            if (*(uint32 *)(plVar6 + 3) < 4) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            plVar6[7] = "/";
            il2cpp_internal(plVar6 + 7,lVar5);
            lVar5 = KungfuSkillLvData.DataBase(this,0);
            if (lVar5 == null) throw; // [null/range check failed]
            lVar5 = Int32.ToString(lVar5 + 132,0);
            if ((lVar5 != null) &&
               (lVar4 = il2cpp_internal(lVar5,*(uint64 *)(*plVar6 + 64))) == null) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            if (*(uint32 *)(plVar6 + 3) < 5) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            plVar6[8] = lVar5;
            il2cpp_internal(plVar6 + 8,lVar5);
            lVar5 = String.Concat(plVar6,0);
          }
        }
        lVar4 = KungfuSkillLvData.DataBase(this,0);
        if (lVar4 == null) throw; // [null/range check failed]
        if (*(int *)(lVar4 + 48) < 3) {
          fVar17 = *(float *)(this + 100);
          lVar4 = KungfuSkillLvData.DataBase(this,0);
          if (lVar4 == null) throw; // [null/range check failed]
          if (*(int *)(lVar4 + 48) < 3) {
            lVar4 = KungfuSkillLvData.DataBase(this,0);
            if (lVar4 == null) throw; // [null/range check failed]
            fVar15 = (float)*(int *)(lVar4 + 52) * 15.0 + 75.0;
          }
          else {
            fVar15 = 0.0;
          }
          if (fVar17 < fVar15) goto LAB_180b8304c;
          uVar8 = String.Concat(lVar5,"\n\n激活效果\n<color=#FF8C00>",0);
          lVar5 = KungfuSkillLvData.DataBase(this,0);
          if (lVar5 == null) throw; // [null/range check failed]
          iVar1 = *(int *)(lVar5 + 48);
          if (iVar1 == 0) {
            lVar5 = KungfuSkillLvData.DataBase(this,0);
            if (lVar5 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_68[0] = (10 - *(int *)(lVar5 + 52)) * 2;
            uVar7 = il2cpp_value_box(DAT_181d5b2f8,local_68);
            uVar10 = "恢复{0}%已损失内力";
        LAB_180b8301b:
            uVar10 = String.Format(uVar10,uVar7,0);
        LAB_180b83026:
            uVar8 = String.Concat(uVar8,uVar10,0);
          }
          else {
            if (iVar1 == 1) {
              lVar5 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x468);
              lVar4 = KungfuSkillLvData.DataBase(this,0);
              uVar10 = "{0}{1}格内跳跃\n恢复{2}%已损失体力";
              if (lVar4 == null) throw; // [null/range check failed]
              if (lVar5 == null) {
        LAB_180b8360b:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar7 = FUN_180002f80(lVar5,*(uint32 *)(lVar4 + 52) & 1,DAT_181d7c9c0);
              lVar5 = KungfuSkillLvData.DataBase(this,0);
              if (lVar5 == null) goto LAB_180b8360b;
              local_70 = Mathf.FloorToInt((float)*(int *)(lVar5 + 52) * 0.5,0);
              local_70 = local_70 + 2;
              uVar11 = il2cpp_value_box(DAT_181d5b2f8,&local_70);
              lVar5 = KungfuSkillLvData.DataBase(this,0);
              if (lVar5 == null) goto LAB_180b8360b;
              local_6c = (10 - *(int *)(lVar5 + 52)) * 3;
              uVar12 = il2cpp_value_box(DAT_181d5b2f8,&local_6c);
              in_stack_ffffffffffffff78 = 0;
              uVar10 = String.Format(uVar10,uVar7,uVar11,uVar12,0);
              goto LAB_180b83026;
            }
            if (iVar1 == 2) {
              lVar5 = KungfuSkillLvData.DataBase(this,0);
              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              local_74 = (float)(10 - *(int *)(lVar5 + 52));
              uVar7 = il2cpp_value_box(DAT_181d5b2f8,&local_74);
              uVar10 = "恢复{0}%已损失生命";
              goto LAB_180b8301b;
            }
          }
          lVar5 = String.Concat(uVar8,"\n功法效果翻倍(5回合)</color>",0);
        }
        LAB_180b8304c:
        lVar4 = KungfuSkillLvData.DataBase(this,0);
        if (lVar4 != null) {
          if (*(int64 *)(lVar4 + 96) != 0) {
            lVar4 = KungfuSkillLvData.DataBase(this,0);
            if ((lVar4 == null) || (*(int64 *)(lVar4 + 96) == 0)) throw; // [null/range check failed]
            cVar2 = HeroSpeAddData.isEmpty(*(int64 *)(lVar4 + 96),0);
            uVar8 = "\n\n装备效果\n";
            if (!cVar2) {
              lVar4 = "<i><color=grey>(激活中效果加倍)</color></i>\n";
              if (this.activeTimeLeft <= 0.0) {
                lVar4 = "";
              }
              lVar9 = this.speEquipData;
              if (0.0 < this.activeTimeLeft) {
                lVar9 = HeroSpeAddData.op_Multiply(lVar9,2);
              }
              if (lVar9 == null) throw; // [null/range check failed]
              uVar10 = HeroSpeAddData.GetDescribe
                                 (lVar9,1,1,1,in_stack_ffffffffffffff78 & 0xffffffffffffff00,0);
              in_stack_ffffffffffffff78 = 0;
              lVar5 = String.Concat(lVar5,uVar8,lVar4,uVar10,0);
            }
          }
          if (this.extraAddData != null) {
            cVar2 = HeroSpeAddData.isEmpty(this.extraAddData,0);
            uVar8 = "\n\n突破效果{0}\n{1}";
            if (!cVar2) {
              lVar4 = "\n<i><color=grey>(激活中效果加倍)</color></i>";
              if ((this.activeTimeLeft <= 0.0) && (lVar4 = "", cVar13)) {
                lVar9 = KungfuSkillLvData.DataBase(this,0);
                if (lVar9 == null) throw; // [null/range check failed]
                lVar4 = "\n<i><color=grey>(使用时生效)</color></i>";
                if (*(int *)(lVar9 + 48) < 3) {
                  lVar4 = "\n<i><color=grey>(装备时生效)</color></i>";
                }
              }
              lVar9 = this.extraAddData;
              if (0.0 < this.activeTimeLeft) {
                lVar9 = HeroSpeAddData.op_Multiply(lVar9,2);
              }
              if (lVar9 == null) throw; // [null/range check failed]
              in_stack_ffffffffffffff78 = in_stack_ffffffffffffff78 & 0xffffffffffffff00;
              uVar10 = HeroSpeAddData.GetDescribe(lVar9,1,1,1,in_stack_ffffffffffffff78,0);
              uVar8 = String.Format(uVar8,lVar4,uVar10,0);
              lVar5 = String.Concat(lVar5,uVar8,0);
            }
            lVar4 = KungfuSkillLvData.DataBase(this,0);
            if (lVar4 != null) {
              if (*(int64 *)(lVar4 + 88) != 0) {
                lVar4 = KungfuSkillLvData.DataBase(this,0);
                if ((lVar4 == null) || (*(int64 *)(lVar4 + 88) == 0)) throw; // [null/range check failed]
                cVar2 = HeroSpeAddData.isEmpty(*(int64 *)(lVar4 + 88),0);
                if (!cVar2) {
                  cVar2 = cVar13;
                  if (this.lv < 10) {
                    cVar2 = true;
                  }
                  if (cVar2) {
                    lVar4 = KungfuSkillLvData.DataBase(this,0);
                    if ((lVar4 == null) || (*(int64 *)(lVar4 + 88) == 0)) throw; // [null/range check failed]
                    uVar8 = HeroSpeAddData.GetDescribe
                                      (*(int64 *)(lVar4 + 88),1,1,1,
                                       in_stack_ffffffffffffff78 & 0xffffffffffffff00,0);
                    lVar5 = String.Concat(lVar5,"\n\n升级效果\n",uVar8,0);
                  }
                }
              }
              lVar4 = KungfuSkillLvData.DataBase(this,0);
              if (lVar4 != null) {
                if (*(int64 *)(lVar4 + 80) != 0) {
                  lVar4 = KungfuSkillLvData.DataBase(this,0);
                  if (lVar4 == null) throw; // [null/range check failed]
                  if (*(int64 *)(lVar4 + 80) == 0) {
                    fVar17 = 1.0;
                  }
                  else {
                    lVar4 = KungfuSkillLvData.DataBase(this,0);
                    if ((lVar4 == null) || (*(int64 *)(lVar4 + 80) == 0)) throw; // [null/range check failed]
                    fVar17 = (float)AttriNumData.GetSkillNeedExpRate(*(int64 *)(lVar4 + 80),lVar3,0)
                    ;
                  }
                  if ((cVar13 || bookDescribe) ||
                     ((this.lv < 10 && (fVar17 < 1.0)))) {
                    lVar4 = KungfuSkillLvData.DataBase(this,0);
                    if ((lVar4 == null) || (*(int64 *)(lVar4 + 80) == 0)) throw; // [null/range check failed]
                    uVar10 = AttriNumData.GetSkillNeedsDescribe(*(int64 *)(lVar4 + 80),lVar3,0);
                    uVar8 = "\n\n修炼需求{1}\n{0}";
                    lVar3 = "";
                    if (fVar17 < 1.0) {
                      local_78 = fVar17 * 100.0;
                      uVar7 = Single.ToString(&local_78,"f0",0);
                      lVar3 = String.Format("<size=14>(经验{0}%)</size>",uVar7,0);
                    }
                    uVar8 = String.Format(uVar8,uVar10,lVar3,0);
                    lVar5 = String.Concat(lVar5,uVar8,0);
                  }
                }
                cVar2 = false;
                if (**(int **)(DAT_181d4ef00 + 184) != 2) {
                  cVar2 = cVar13;
                }
                if (cVar2) {
                  lVar3 = KungfuSkillLvData.DataBase(this,0);
                  if (lVar3 == null) throw; // [null/range check failed]
                  lVar5 = String.Concat(lVar5,"\n\n<color=grey><i>",*(uint64 *)(lVar3 + 40),"</i></color>",0
                                        );
                }
                if ((**(int **)(DAT_181d4ef00 + 184) != 2) && (!cVar13)) {
                  lVar5 = String.Concat(lVar5,"\n<i><color=grey>左Shift查看详情</color></i>",0);
                }
                return lVar5;
              }
            }
          }
        }
    }

    // Token : 0x6001245
    // RVA   : 0xB80600   Offset: 0xB7EE00   Length: 0x175
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
        plVar1 = (int64 *)il2cpp_internal(DAT_181d63ff0);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181d8c5a8);
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
            FUN_180002970(0,DAT_181d53c70,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

}
