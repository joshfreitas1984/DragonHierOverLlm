// ============================================================
// Type  : KungfuSkillLvData
// Token : 0x2000227
// ============================================================

public class KungfuSkillLvData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400114C
    public int skillID;

    // Token: 0x400114D
    public int lv;

    // Token: 0x400114E
    public float fightExp;

    // Token: 0x400114F
    public float bookExp;

    // Token: 0x4001150
    public bool equiped;

    // Token: 0x4001151
    public bool isNew;

    // Token: 0x4001152
    public int belongHeroID;

    // Token: 0x4001153
    public HeroSpeAddData speEquipData;

    // Token: 0x4001154
    public float equipUseSpeAddValue;

    // Token: 0x4001155
    public HeroSpeAddData speUseData;

    // Token: 0x4001156
    public float damageUseSpeAddValue;

    // Token: 0x4001157
    public float selfUseSpeAddValue;

    // Token: 0x4001158
    public float enemyUseSpeAddValue;

    // Token: 0x4001159
    public HeroSpeAddData extraAddData;

    // Token: 0x400115A
    public float cdTimeLeft;

    // Token: 0x400115B
    public int useTime;

    // Token: 0x400115C
    public float activeTimeLeft;

    // Token: 0x400115D
    public float power;

    // Token: 0x400115E
    public float battleDamageCount;

    // Token: 0x400115F
    public bool skillIconDirty;

    // Token: 0x4001160
    public bool maxManaChanged;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600125B
    // RVA   : 0xA7BBF0   Offset: 0xA7AFF0   Length: 0xCE
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

    // Token : 0x600125C
    // RVA   : 0xA7B900   Offset: 0xA7AD00   Length: 0xD1
    public bool SkillMeetObstacleLv()
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x640);
        lVar3 = KungfuSkillLvData.DataBase(this,0);
        if ((lVar3 != null) && (lVar2 != null)) {
          uVar1 = *(uint32 *)(lVar3 + 52);
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2[uVar1];
          if (lVar2 != null) {
            FUN_18182a3a0(lVar2,this.lv,DAT_181d8f398);
            return;
          }
        }
    }

    // Token : 0x600125D
    // RVA   : 0xA7B030   Offset: 0xA7A430   Length: 0x23
    public string GetSkillIcon()
    {
        long lVar1;
        lVar1 = KungfuSkillLvData.DataBase(this,0);
        if (lVar1 != null) {
          KungfuSkillData.GetSkillIcon(lVar1,0);
          return;
        }
    }

    // Token : 0x600125E
    // RVA   : 0xA7AAE0   Offset: 0xA79EE0   Length: 0x45
    public float GetSkillExpExchangeRate()
    {
        long lVar1;
        lVar1 = KungfuSkillLvData.DataBase(this,0);
        if (lVar1 != null) {
          Mathf.Max(0.5 - (float)*(int *)(lVar1 + 52) * 0.1);
          return;
        }
    }

    // Token : 0x600125F
    // RVA   : 0xA7BAC0   Offset: 0xA7AEC0   Length: 0xDB
    public int StudyMoneyCost()
    {
        int iVar1;
        long lVar2;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
        if (lVar2 != null) {
          lVar2 = GameDataController.GetSkillDataBase(lVar2,this.skillID,0);
          if (lVar2 != null) {
            iVar1 = Mathf.FloorToInt((float)*(int *)(lVar2 + 52) * 0.5,0);
            return (iVar1 + 1) * 20;
          }
        }
    }

    // Token : 0x6001260
    // RVA   : 0xA7B9E0   Offset: 0xA7ADE0   Length: 0xD5
    public int StudyDayCost()
    {
        int iVar1;
        long lVar2;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
        if (lVar2 != null) {
          lVar2 = GameDataController.GetSkillDataBase(lVar2,this.skillID,0);
          if (lVar2 != null) {
            iVar1 = Mathf.FloorToInt((float)*(int *)(lVar2 + 52) * 0.5,0);
            return iVar1 + 1;
          }
        }
    }

    // Token : 0x6001261
    // RVA   : 0xA77920   Offset: 0xA76D20   Length: 0xA7
    public int BreakThroughDayCost()
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x638);
        lVar3 = KungfuSkillLvData.DataBase(this,0);
        if ((lVar3 != null) && (lVar2 != null)) {
          uVar1 = *(uint32 *)(lVar3 + 52);
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          return lVar2[uVar1];
        }
    }

    // Token : 0x6001262
    // RVA   : 0xA77B30   Offset: 0xA76F30   Length: 0xA3
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
          uVar3 = FUN_1810e36c0(fVar1 + deltaPower,0);
        }
        *(uint32 *)(this + 100) = uVar3;
    }

    // Token : 0x6001263
    // RVA   : 0xA7B160   Offset: 0xA7A560   Length: 0x56
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

    // Token : 0x6001264
    // RVA   : 0xA77AD0   Offset: 0xA76ED0   Length: 0x5B
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

    // Token : 0x6001265
    // RVA   : 0xA7B100   Offset: 0xA7A500   Length: 0x51
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

    // Token : 0x6001266
    // RVA   : 0xA77E80   Offset: 0xA77280   Length: 0xE
    public void FightReset()
    {
        this.cdTimeLeft = 0;
        *(uint64 *)(this + 100) = 0;
        this.activeTimeLeft = 0;
    }

    // Token : 0x6001267
    // RVA   : 0xA7B060   Offset: 0xA7A460   Length: 0x68
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

    // Token : 0x6001268
    // RVA   : 0xA779D0   Offset: 0xA76DD0   Length: 0x60
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

    // Token : 0x6001269
    // RVA   : 0x8901D0   Offset: 0x88F5D0   Length: 0x9
    public float GetActiveTime()
    {
        return 0x40a00000;
    }

    // Token : 0x600126A
    // RVA   : 0xA7B1C0   Offset: 0xA7A5C0   Length: 0x2D
    public string Name(bool colored)
    {
        long lVar1;
        lVar1 = KungfuSkillLvData.DataBase(this,0);
        if (lVar1 != null) {
          KungfuSkillData.Name(lVar1,colored,0);
          return;
        }
    }

    // Token : 0x600126B
    // RVA   : 0xA7BBA0   Offset: 0xA7AFA0   Length: 0x1D
    public int Type()
    {
        long lVar1;
        lVar1 = KungfuSkillLvData.DataBase(this,0);
        if (lVar1 != null) {
          return *(uint32 *)(lVar1 + 48);
        }
    }

    // Token : 0x600126C
    // RVA   : 0xA77D70   Offset: 0xA77170   Length: 0xB6
    public KungfuSkillData DataBase()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
        if (lVar1 != null) {
          GameDataController.GetSkillDataBase(lVar1,this.skillID,0);
          return;
        }
    }

    // Token : 0x600126D
    // RVA   : 0xA77F00   Offset: 0xA77300   Length: 0x21
    public PartPostureData GetAtkPartPosture()
    {
        long lVar1;
        lVar1 = KungfuSkillLvData.DataBase(this,0);
        if (lVar1 != null) {
          return *(uint64 *)(lVar1 + 136);
        }
    }

    // Token : 0x600126E
    // RVA   : 0xA79170   Offset: 0xA78570   Length: 0x21
    public PartPostureData GetDefPartPosture()
    {
        long lVar1;
        lVar1 = KungfuSkillLvData.DataBase(this,0);
        if (lVar1 != null) {
          return *(uint64 *)(lVar1 + 144);
        }
    }

    // Token : 0x600126F
    // RVA   : 0xA794A0   Offset: 0xA788A0   Length: 0x31
    public float GetLvSpeDamageChange()
    {
        FUN_1810e36c0((float)(this.lv + -4) * 0.25 + 1.0,0x3dcccccd,0x3f800000,0);
    }

    // Token : 0x6001270
    // RVA   : 0xA77F30   Offset: 0xA77330   Length: 0x2D
    public float GetBaseDamage()
    {
        long lVar1;
        lVar1 = KungfuSkillLvData.DataBase(this,0);
        if (lVar1 != null) {
          KungfuSkillData.GetBaseDamage(lVar1,this.lv,0);
          return;
        }
    }

    // Token : 0x6001271
    // RVA   : 0xA794E0   Offset: 0xA788E0   Length: 0x2D
    public float GetManaCost()
    {
        long lVar1;
        lVar1 = KungfuSkillLvData.DataBase(this,0);
        if (lVar1 != null) {
          KungfuSkillData.GetManaCost(lVar1,this.lv,0);
          return;
        }
    }

    // Token : 0x6001272
    // RVA   : 0xA7BBC0   Offset: 0xA7AFC0   Length: 0x27
    public void Upgrade(int upgradeLv)
    {
        this.lv = this.lv + upgradeLv;
        KungfuSkillLvData.ResetSpeEquipData(this,0);
        KungfuSkillLvData.ResetSpeUseData(this,0);
        this.skillIconDirty = 1;
    }

    // Token : 0x6001273
    // RVA   : 0xA7B0D0   Offset: 0xA7A4D0   Length: 0x21
    public HeroSpeAddData GetSpeEquipData()
    {
        if (0.0 < this.activeTimeLeft) {
          HeroSpeAddData.op_Multiply(this.speEquipData,2);
          return;
        }
    }

    // Token : 0x6001274
    // RVA   : 0xA79470   Offset: 0xA78870   Length: 0x21
    public HeroSpeAddData GetExtraAddData()
    {
        if (0.0 < this.activeTimeLeft) {
          HeroSpeAddData.op_Multiply(this.extraAddData,2);
          return;
        }
    }

    // Token : 0x6001275
    // RVA   : 0xA7B1F0   Offset: 0xA7A5F0   Length: 0x25C
    public void ResetSpeEquipData()
    {
        float fVar1;
        ulong uVar2;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        float fVar7;
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
        lVar4 = KungfuSkillLvData.DataBase(this,0);
        if (lVar4 != null) {
          uVar5 = KungfuSkillData.GetSpeEquipData(lVar4,this.lv,0);
          this.speEquipData = uVar5;
          if ((this.speEquipData == null) ||
             (cVar3 = HeroSpeAddData.isEmpty(this.speEquipData,0), cVar3)) {
            return;
          }
          this.equipUseSpeAddValue = 0;
          lVar4 = KungfuSkillLvData.DataBase(this,0);
          if (lVar4 != null) {
            lVar6 = this.speEquipData;
            if (*(int *)(lVar4 + 48) < 3) {
              lVar6 = HeroSpeAddData.op_Addition(lVar6,this.extraAddData,0);
            }
            if (((lVar6 != null) && (lVar6.heroSpeAddData != null)) &&
               (lVar4 = Dictionary_2.get_Keys(lVar6.heroSpeAddData,DAT_181dbe4b8)) != null) {
              FUN_180ecbf30(&local_48,lVar4,DAT_181dc36f0);
              local_60 = local_48;
              uStack_5c = uStack_44;
              uStack_58 = uStack_40;
              uStack_54 = uStack_3c;
              local_50 = local_38;
              while( true ) {
                cVar3 = FUN_1811c4f60(&local_60,DAT_181d9b258);
                uVar2 = local_50;
                if (!cVar3) {
                  ZhSegment.Initialize(&local_60,DAT_181d9b1d8);
                  return;
                }
                fVar1 = this.equipUseSpeAddValue;
                fVar7 = (float)HeroSpeAddData.Get(lVar6,local_50 & 0xffffffff,0);
                lVar4 = FUN_18046c100(0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (*(int64 *)(lVar4 + 144) == 0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 144),uVar2 & 0xffffffff);
                if (lVar4 == null) break;
                this.equipUseSpeAddValue = fVar7 / *(float *)(lVar4 + 32) + fVar1;
              }
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
          }
        }
    }

    // Token : 0x6001276
    // RVA   : 0xA7B450   Offset: 0xA7A850   Length: 0x462
    public void ResetSpeUseData()
    {
        float fVar1;
        ulong uVar2;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        float fVar7;
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
        lVar4 = KungfuSkillLvData.DataBase(this,0);
        if (lVar4 != null) {
          uVar5 = KungfuSkillData.GetSpeUseData(lVar4,this.lv,0);
          this.speUseData = uVar5;
          if ((this.speUseData == null) ||
             (cVar3 = HeroSpeAddData.isEmpty(this.speUseData,0), cVar3)) {
            return;
          }
          this.damageUseSpeAddValue = 0;
          this.enemyUseSpeAddValue = 0;
          lVar4 = KungfuSkillLvData.DataBase(this,0);
          if (lVar4 != null) {
            lVar6 = this.speUseData;
            if (2 < *(int *)(lVar4 + 48)) {
              lVar6 = HeroSpeAddData.op_Addition(lVar6,this.extraAddData,0);
            }
            if (((lVar6 != null) && (lVar6.heroSpeAddData != null)) &&
               (lVar4 = Dictionary_2.get_Keys(lVar6.heroSpeAddData,DAT_181dbe4b8)) != null) {
              FUN_180ecbf30(&local_48,lVar4,DAT_181dc36f0);
              local_60 = local_48;
              uStack_5c = uStack_44;
              uStack_58 = uStack_40;
              uStack_54 = uStack_3c;
              local_50 = local_38;
              while( true ) {
                cVar3 = FUN_1811c4f60(&local_60,DAT_181d9b258);
                uVar2 = local_50;
                if (!cVar3) {
                  ZhSegment.Initialize(&local_60,DAT_181d9b1d8);
                  return;
                }
                lVar4 = FUN_18046c100(0);
                if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (*(int64 *)(lVar4 + 144) == 0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 144),uVar2 & 0xffffffff,DAT_181d8c018);
                if (lVar4 == null) break;
                lVar4 = *(int64 *)(lVar4 + 72);
                if (lVar4 != null) {
                  cVar3 = FUN_18171e540(lVar4,"伤害",0);
                  if (!cVar3) {
                    cVar3 = FUN_18171e540(lVar4,"我方",0);
                    if (!cVar3) {
                      cVar3 = FUN_18171e540(lVar4,"敌方",0);
                      if (cVar3) {
                        fVar1 = this.enemyUseSpeAddValue;
                        fVar7 = (float)HeroSpeAddData.Get(lVar6,uVar2 & 0xffffffff,0);
                        lVar4 = FUN_18046c100(0);
                        if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                          FUN_1800d6620();
                        }
                        if (*(int64 *)(lVar4 + 144) == 0) {
                          // WARNING: Subroutine does not return
                          FUN_1800d6620();
                        }
                        lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 144),uVar2 & 0xffffffff,DAT_181d8c018
                                             );
                        if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                          FUN_1800d6620();
                        }
                        this.enemyUseSpeAddValue = fVar7 / *(float *)(lVar4 + 32) + fVar1;
                      }
                    }
                    else {
                      fVar1 = this.selfUseSpeAddValue;
                      fVar7 = (float)HeroSpeAddData.Get(lVar6,uVar2 & 0xffffffff);
                      lVar4 = FUN_18046c100(0);
                      if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      if (*(int64 *)(lVar4 + 144) == 0) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 144),uVar2 & 0xffffffff,DAT_181d8c018);
                      if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      this.selfUseSpeAddValue = fVar7 / *(float *)(lVar4 + 32) + fVar1;
                    }
                  }
                  else {
                    fVar1 = this.damageUseSpeAddValue;
                    fVar7 = (float)HeroSpeAddData.Get(lVar6,uVar2 & 0xffffffff);
                    lVar4 = FUN_18046c100(0);
                    if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    if (*(int64 *)(lVar4 + 144) == 0) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 144),uVar2 & 0xffffffff,DAT_181d8c018);
                    if (lVar4 == null) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    this.damageUseSpeAddValue = fVar7 / *(float *)(lVar4 + 32) + fVar1;
                  }
                }
              }
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
          }
        }
    }

    // Token : 0x6001277
    // RVA   : 0x21B660   Offset: 0x21AA60   Length: 0x5
    public HeroSpeAddData GetSpeUseData()
    {
        return this.speUseData;
    }

    // Token : 0x6001278
    // RVA   : 0xA7B8C0   Offset: 0xA7ACC0   Length: 0x3B
    public float SkillGetMaxExp(int expType)
    {
        long lVar1;
        lVar1 = KungfuSkillLvData.DataBase(this,0);
        if (lVar1 != null) {
          KungfuSkillData.GetMaxExp(lVar1,this.lv,expType,0);
          return;
        }
    }

    // Token : 0x6001279
    // RVA   : 0xA77A40   Offset: 0xA76E40   Length: 0x84
    public bool CanUpgrade()
    {
        float fVar1;
        long lVar2;
        float fVar3;
        if (9 < this.lv) {
          return false;
        }
        fVar1 = this.bookExp;
        lVar2 = KungfuSkillLvData.DataBase(this,0);
        if (lVar2 != null) {
          fVar3 = (float)KungfuSkillData.GetMaxExp(lVar2,this.lv,0,0);
          if (fVar1 < fVar3) {
            return false;
          }
          fVar1 = this.fightExp;
          lVar2 = KungfuSkillLvData.DataBase(this,0);
          if (lVar2 != null) {
            fVar3 = (float)KungfuSkillData.GetMaxExp(lVar2,this.lv,1);
            return fVar3 <= fVar1;
          }
        }
    }

    // Token : 0x600127A
    // RVA   : 0xA778D0   Offset: 0xA76CD0   Length: 0x46
    public bool BookExpFull()
    {
        float fVar1;
        long lVar2;
        float fVar3;
        fVar1 = this.bookExp;
        lVar2 = KungfuSkillLvData.DataBase(this,0);
        if (lVar2 != null) {
          fVar3 = (float)KungfuSkillData.GetMaxExp(lVar2,this.lv,0,0);
          return fVar3 <= fVar1;
        }
    }

    // Token : 0x600127B
    // RVA   : 0xA77E30   Offset: 0xA77230   Length: 0x47
    public bool FightExpFull()
    {
        float fVar1;
        long lVar2;
        float fVar3;
        fVar1 = this.fightExp;
        lVar2 = KungfuSkillLvData.DataBase(this,0);
        if (lVar2 != null) {
          fVar3 = (float)KungfuSkillData.GetMaxExp(lVar2,this.lv,1);
          return fVar3 <= fVar1;
        }
    }

    // Token : 0x600127C
    // RVA   : 0xA77E90   Offset: 0xA77290   Length: 0x60
    public void FullFillExp()
    {
        long lVar1;
        uint uVar2;
        lVar1 = KungfuSkillLvData.DataBase(this,0);
        if (lVar1 != null) {
          uVar2 = KungfuSkillData.GetMaxExp(lVar1,this.lv,0,0);
          this.bookExp = uVar2;
          lVar1 = KungfuSkillLvData.DataBase(this,0);
          if (lVar1 != null) {
            uVar2 = KungfuSkillData.GetMaxExp(lVar1,this.lv,1);
            this.fightExp = uVar2;
            this.skillIconDirty = 1;
            return;
          }
        }
    }

    // Token : 0x600127D
    // RVA   : 0xA791A0   Offset: 0xA785A0   Length: 0x2C9
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
        plVar1 = (int64 *)FUN_1800d60b0(DAT_181da4120,4);
        local_res8[0] = (int)this.bookExp;
        lVar2 = il2cpp_value_box(DAT_181d80418,local_res8);
        if (plVar1 != (int64 *)0) {
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
          lVar2 = KungfuSkillLvData.DataBase(this,0);
          if (lVar2 != null) {
            local_res18[0] = KungfuSkillData.GetMaxExp(lVar2,this.lv,0,0);
            lVar2 = il2cpp_value_box(DAT_181da22d8,local_res18);
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
            lVar2 = il2cpp_value_box(DAT_181d80418,local_res20);
            if (lVar2 != null) {
              lVar3 = il2cpp_internal(lVar2,*(uint64 *)(*plVar1 + 64));
              if (lVar3 == null) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
            }
            if (*(uint32 *)(plVar1 + 3) < 3) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            plVar1[6] = lVar2;
            il2cpp_internal(plVar1 + 6,lVar2);
            lVar2 = KungfuSkillLvData.DataBase(this,0);
            if (lVar2 != null) {
              local_28[0] = KungfuSkillData.GetMaxExp(lVar2,this.lv,1);
              lVar2 = il2cpp_value_box(DAT_181da22d8,local_28);
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
          }
        }
    }

    // Token : 0x600127E
    // RVA   : 0xA78730   Offset: 0xA77B30   Length: 0xA3A
    public List<int> GetBreakThroughAvailableChoice()
    {
        var pStatics_34e0 = *(int64*)(DAT_181db34e0 + 184);
        var pStatics_ba20 = *(int64*)(DAT_181d7ba20 + 184);
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
        if (*pStatics_34e0 == 0) goto LAB_180a79122;
        cVar4 = FUN_1808ab490(*pStatics_34e0,this.skillID,
                              DAT_181db7138);
        if (cVar4) {
          if ((*pStatics_34e0 != 0) &&
             (lVar5 = FUN_1817d9e10(*pStatics_34e0,this.skillID,
                                    DAT_181db71c0), lVar5 != null)) {
            uVar10 = FUN_181655b90(lVar5,DAT_181d8f898);
            lVar5 = il2cpp_internal(DAT_181d93cd0);
            FUN_1818399e0(lVar5,uVar10,DAT_181d8f118);
            return lVar5;
          }
          goto LAB_180a79122;
        }
        lVar5 = KungfuSkillLvData.DataBase(this,0);
        local_90 = lVar5;
        lVar6 = il2cpp_internal(DAT_181d93cd0);
        FUN_18132faf0(lVar6,DAT_181d8f098);
        if (lVar5 == null) goto LAB_180a79122;
        if (*(int *)(lVar5 + 48) < 3) {
          if (lVar6 == null) goto LAB_180a79122;
          FUN_18182a0b0(lVar6,*(int *)(lVar5 + 48) + 6,DAT_181d8f218);
          lVar7 = il2cpp_internal(DAT_181d93cd0);
          FUN_18132faf0(lVar7,DAT_181d8f098);
          if (lVar7 == null) goto LAB_180a79122;
          FUN_18182a0b0(lVar7,57,DAT_181d8f218);
          uVar10 = 59;
        LAB_180a78ac2:
          FUN_18182a0b0(lVar7,uVar10,DAT_181d8f218);
        }
        else {
          if (*(int *)(lVar5 + 28) == 4) {
            lVar7 = il2cpp_internal(DAT_181d93cd0);
            FUN_18132faf0(lVar7,DAT_181d8f098);
            if (lVar7 == null) goto LAB_180a79122;
            FUN_18182a0b0(lVar7,208,DAT_181d8f218);
            FUN_18182a0b0(lVar7,209,DAT_181d8f218);
            uVar10 = 210;
            goto LAB_180a78ac2;
          }
          if (0.0 < *(float *)(lVar5 + 60)) {
            lVar7 = il2cpp_internal(DAT_181d93cd0);
            FUN_18132faf0(lVar7,DAT_181d8f098);
            if (lVar7 == null) goto LAB_180a79122;
            FUN_18182a0b0(lVar7,60,DAT_181d8f218);
            FUN_18182a0b0(lVar7,64,DAT_181d8f218);
            FUN_18182a0b0(lVar7,66,DAT_181d8f218);
            FUN_18182a0b0(lVar7,69,DAT_181d8f218);
            FUN_18182a0b0(lVar7,70,DAT_181d8f218);
          }
          else {
            lVar7 = il2cpp_internal(DAT_181d93cd0);
            FUN_18132faf0(lVar7,DAT_181d8f098);
            if (lVar7 == null) goto LAB_180a79122;
            FUN_18182a0b0(lVar7,66,DAT_181d8f218);
            FUN_18182a0b0(lVar7,70,DAT_181d8f218);
          }
        }
        uVar10 = Enumerable.Concat(lVar6,lVar7,DAT_181db28b8);
        lVar6 = FUN_180971e70(uVar10,DAT_181db53c0);
        local_68 = lVar6;
        if (*(int64 *)(lVar5 + 72) == 0) {
        LAB_180a78c63:
          if ((*(int *)(lVar5 + 48) < 3) && (*(int64 *)(lVar5 + 88) != 0)) {
            lVar7 = *(int64 *)(*(int64 *)(lVar5 + 88) + 16);
            if ((lVar7 == null) || (lVar7 = Dictionary_2.get_Keys(lVar7,DAT_181dbe4b8)) == null)
            goto LAB_180a79122;
            FUN_180ecbf30(&local_88,lVar7,DAT_181dc36f0);
            local_a8 = CONCAT44(uStack_84,local_88);
            uStack_a0 = CONCAT44(uStack_7c,uStack_80);
            local_98 = local_78;
            while (cVar4 = FUN_1811c4f60(&local_a8,DAT_181d9b258), uVar3 = local_98, cVar4) {
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
                FUN_18182a0b0(lVar6,uVar3 & 0xffffffff);
              }
            }
            ZhSegment.Initialize(&local_a8,DAT_181d9b1d8);
          }
          if (*(int64 *)(lVar5 + 96) != 0) {
            lVar7 = *(int64 *)(*(int64 *)(lVar5 + 96) + 16);
            if ((lVar7 == null) || (lVar7 = Dictionary_2.get_Keys(lVar7,DAT_181dbe4b8)) == null)
            goto LAB_180a79122;
            FUN_180ecbf30(&local_88,lVar7,DAT_181dc36f0);
            local_a8 = CONCAT44(uStack_84,local_88);
            uStack_a0 = CONCAT44(uStack_7c,uStack_80);
            local_98 = local_78;
            while (cVar4 = FUN_1811c4f60(&local_a8,DAT_181d9b258), uVar3 = local_98, cVar4) {
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
                FUN_18182a0b0(lVar6,uVar3 & 0xffffffff);
              }
            }
            ZhSegment.Initialize(&local_a8,DAT_181d9b1d8);
          }
          if (*(int64 *)(lVar5 + 104) != 0) {
            lVar7 = *(int64 *)(*(int64 *)(lVar5 + 104) + 16);
            if ((lVar7 == null) || (lVar7 = Dictionary_2.get_Keys(lVar7,DAT_181dbe4b8)) == null)
            goto LAB_180a79122;
            FUN_180ecbf30(&local_88,lVar7,DAT_181dc36f0);
            local_a8 = CONCAT44(uStack_84,local_88);
            uStack_a0 = CONCAT44(uStack_7c,uStack_80);
            local_98 = local_78;
            while (cVar4 = FUN_1811c4f60(&local_a8,DAT_181d9b258), uVar3 = local_98, cVar4) {
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
                FUN_18182a0b0(lVar6,uVar3 & 0xffffffff);
              }
            }
            ZhSegment.Initialize(&local_a8,DAT_181d9b1d8);
          }
          lVar5 = *(int64 *)(pStatics_ba20 + 8);
          if (lVar5 == null) {
            uVar10 = **(uint64 **)(DAT_181d7ba20 + 184);
            lVar5 = new OnTooltipCB(uVar10,DAT_181da6a48,DAT_181dbdb08);
            plVar9 = (int64 *)(pStatics_ba20 + 8);
            *plVar9 = lVar5;
            il2cpp_internal(plVar9,lVar5);
          }
          if (lVar6 != null) {
            FUN_18182e030(lVar6,lVar5,DAT_181d8f698);
            if (((*(byte *)(DAT_181db34e0 + 0x133) & 4) == 0) || (*(int *)(DAT_181db34e0 + 224) != 0)) {
              lVar5 = *pStatics_34e0;
              lVar7 = lVar6;
            }
            else {
              il2cpp_runtime_class_init(DAT_181db34e0);
              lVar5 = *pStatics_34e0;
              this = local_70;
              lVar7 = local_68;
            }
            uVar1 = this.skillID;
            uVar10 = FUN_181655b90(lVar7,DAT_181d8f898);
            uVar8 = il2cpp_internal(DAT_181d93cd0);
            FUN_1818399e0(uVar8,uVar10,DAT_181d8f118);
            if (lVar5 != null) {
              FUN_1808ab370(lVar5,uVar1,uVar8,DAT_181db70b0);
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
              goto LAB_180a78b90;
            }
            if (*(uint32 *)(lVar2 + 24) <= uVar11) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(float *)(lVar13 + *(int64 *)(lVar2 + 16)) != 0.0) {
              if (lVar6 == null) break;
              FUN_18182a0b0(lVar6,uVar11,DAT_181d8f218);
            }
            uVar11 = uVar11 + 1;
            lVar13 = lVar13 + 4;
          }
        }
        LAB_180a79122:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180a78b90:
        if ((*(int64 *)(lVar5 + 72) == 0) ||
           (lVar2 = *(int64 *)(*(int64 *)(lVar5 + 72) + 24)) == null) goto LAB_180a79122;
        if ((int)*(uint32 *)(lVar2 + 24) <= (int)uVar11) goto LAB_180a78c00;
        if (*(uint32 *)(lVar2 + 24) <= uVar11) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (*(float *)(lVar13 + *(int64 *)(lVar2 + 16)) != 0.0) {
          if (lVar6 == null) goto LAB_180a79122;
          FUN_18182a0b0(lVar6,uVar11 + 6,DAT_181d8f218);
        }
        uVar11 = uVar11 + 1;
        lVar13 = lVar13 + 4;
        goto LAB_180a78b90;
        LAB_180a78c00:
        if ((*(int64 *)(lVar5 + 72) == 0) ||
           (lVar13 = *(int64 *)(*(int64 *)(lVar5 + 72) + 32)) == null) goto LAB_180a79122;
        if ((int)*(uint32 *)(lVar13 + 24) <= (int)uVar12) goto LAB_180a78c63;
        if (*(uint32 *)(lVar13 + 24) <= uVar12) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (*(float *)(lVar7 + *(int64 *)(lVar13 + 16)) != 0.0) {
          if (lVar6 == null) goto LAB_180a79122;
          FUN_18182a0b0(lVar6,uVar12 + 24,DAT_181d8f218);
        }
        uVar12 = uVar12 + 1;
        lVar7 = lVar7 + 4;
        goto LAB_180a78c00;
    }

    // Token : 0x600127F
    // RVA   : 0xA776B0   Offset: 0xA76AB0   Length: 0x214
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
          lVar2 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
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

    // Token : 0x6001280
    // RVA   : 0xA77D60   Offset: 0xA77160   Length: 0xD
    public static float CountDamageRatio(float sourceNum, float addRatio)
    {
        float FUN_180a77d60(float sourceNum,float addRatio)
        {
        return sourceNum * 0.01 * addRatio;
    }

    // Token : 0x6001281
    // RVA   : 0xA77F60   Offset: 0xA77360   Length: 0x7C4
    public HeroData GetBelongHero()
    {
        var pStatics_0248 = *(int64*)(DAT_181db0248 + 184);
        var pStatics_2cc8 = *(int64*)(DAT_181d72cc8 + 184);
        bool cVar1;
        ulong uVar2;
        long lVar3;
        int iVar4;
        int iVar5;
        if (this.belongHeroID < 0) {
          lVar3 = *(int64 *)(pStatics_0248 + 80);
          if (lVar3 != null) {
            iVar4 = 0;
            if (*(int *)(lVar3 + 36) == 0) {
        LAB_180a78580:
              do {
                lVar3 = *(int64 *)(*(int64 *)(DAT_181d91b88 + 184) + 24);
                if ((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 0x100)) == null)
                goto LAB_180a7871f;
                if (*(int *)(lVar3 + 24) <= iVar4) {
                  return 0;
                }
                lVar3 = FUN_18046c400(0);
                if ((lVar3 == null) || (*(int64 *)(lVar3 + 0x100) == 0)) goto LAB_180a7871f;
                lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 0x100),iVar4,DAT_181d8bb98);
                if (lVar3 != null) {
                  lVar3 = FUN_18046c400(0);
                  if ((((lVar3 == null) || (*(int64 *)(lVar3 + 0x100) == 0)) ||
                      (lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 0x100),iVar4,DAT_181d8bb98), lVar3 == null
                      )) || (*(int64 *)(lVar3 + 0x260) == 0)) goto LAB_180a7871f;
                  cVar1 = FUN_18181e400(*(int64 *)(lVar3 + 0x260),this,DAT_181d92210);
                  if (cVar1) goto LAB_180a786d4;
                }
                iVar4 = iVar4 + 1;
              } while( true );
            }
            iVar5 = 0;
            while( true ) {
              lVar3 = *(int64 *)(pStatics_0248 + 80);
              if ((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 64)) == null) break;
              if (*(int *)(lVar3 + 24) <= iVar5) {
                iVar5 = 0;
                goto LAB_180a78350;
              }
              iVar4 = 0;
              while( true ) {
                lVar3 = FUN_18046bb80(0);
                if (((lVar3 == null) || (*(int64 *)(lVar3 + 64) == 0)) ||
                   (lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 64),iVar5,DAT_181d78528)) == null)
                goto LAB_180a7871f;
                if (*(int *)(lVar3 + 24) <= iVar4) break;
                lVar3 = FUN_18046bb80(0);
                if (((lVar3 == null) || (*(int64 *)(lVar3 + 64) == 0)) ||
                   ((lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 64),iVar5,DAT_181d78528), lVar3 == null ||
                    ((lVar3 = FUN_180002f80(lVar3,iVar4,DAT_181d8bb98), lVar3 == null ||
                     (*(int64 *)(lVar3 + 0x260) == 0)))))) goto LAB_180a7871f;
                cVar1 = FUN_18181e400(*(int64 *)(lVar3 + 0x260),this,DAT_181d92210);
                if (cVar1) {
                  lVar3 = FUN_18046bb80(0);
                  if (((lVar3 == null) || (*(int64 *)(lVar3 + 64) == 0)) ||
                     (lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 64),iVar5,DAT_181d78528)) == null)
                  goto LAB_180a7871f;
                  goto LAB_180a7832c;
                }
                iVar4 = iVar4 + 1;
              }
              iVar5 = iVar5 + 1;
            }
          }
        }
        else {
          if ((*pStatics_2cc8 != 0) &&
             (lVar3 = *(int64 *)(*pStatics_2cc8 + 32)) != null) {
            uVar2 = WorldData.GetHero(lVar3,this.belongHeroID,0);
            return uVar2;
          }
        }
        LAB_180a7871f:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180a78350:
        lVar3 = *(int64 *)(pStatics_0248 + 80);
        if ((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 112)) == null) goto LAB_180a7871f;
        iVar4 = 0;
        if (*(int *)(lVar3 + 24) <= iVar5) goto LAB_180a78580;
        iVar4 = 0;
        while( true ) {
          lVar3 = FUN_18046bb80(0);
          if ((((lVar3 == null) || (*(int64 *)(lVar3 + 112) == 0)) ||
              (lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 112),iVar5,DAT_181d7f830)) == null) ||
             (*(int64 *)(lVar3 + 24) == 0)) goto LAB_180a7871f;
          if (*(int *)(*(int64 *)(lVar3 + 24) + 24) <= iVar4) break;
          lVar3 = FUN_18046bb80(0);
          if ((((lVar3 == null) || (*(int64 *)(lVar3 + 112) == 0)) ||
              ((lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 112),iVar5,DAT_181d7f830), lVar3 == null ||
               (((*(int64 *)(lVar3 + 24) == 0 ||
                 (lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 24),iVar4,DAT_181d7fc20)) == null) ||
                (*(int64 *)(lVar3 + 64) == 0)))))) ||
             (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 64) + 0x260)) == null) goto LAB_180a7871f;
          cVar1 = FUN_18181e400(lVar3,this,DAT_181d92210);
          if (cVar1) {
            lVar3 = FUN_18046bb80(0);
            if (((lVar3 != null) && (*(int64 *)(lVar3 + 112) != 0)) &&
               ((lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 112),iVar5,DAT_181d7f830), lVar3 != null &&
                ((*(int64 *)(lVar3 + 24) != 0 &&
                 (lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 24),iVar4,DAT_181d7fc20)) != null)))))
            {
              return *(uint64 *)(lVar3 + 64);
            }
            goto LAB_180a7871f;
          }
          iVar4 = iVar4 + 1;
        }
        iVar5 = iVar5 + 1;
        goto LAB_180a78350;
        LAB_180a786d4:
        lVar3 = FUN_18046c400(0);
        if ((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 0x100)) != null) {
        LAB_180a7832c:
          uVar2 = FUN_180002f80(lVar3,iVar4,DAT_181d8bb98);
          return uVar2;
        }
        goto LAB_180a7871f;
    }

    // Token : 0x6001282
    // RVA   : 0xA7AB30   Offset: 0xA79F30   Length: 0x4FE
    public float GetSkillFightScore()
    {
        long lVar1;
        bool cVar2;
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
          fVar9 = (float)KungfuSkillData.GetBaseDamage(lVar3,this.lv,0);
          fVar10 = (float)FUN_1810e36c0((float)(this.lv + -4) * 0.25 + 1.0,0x3dcccccd,
                                        0x3f800000,0);
          fVar10 = fVar10 * fVar9;
          lVar3 = KungfuSkillLvData.GetBelongHero(this,0);
          if (lVar3 == null) {
            return;
          }
          cVar2 = HeroData.HaveForce(lVar3,0);
          if (cVar2) {
            lVar4 = KungfuSkillLvData.DataBase(this,0);
            if (lVar4 == null) goto LAB_180a7b029;
            if (*(int *)(lVar4 + 24) == *(int *)(lVar3 + 132)) {
              if (*(int64 *)(lVar3 + 0x2b8) == 0) goto LAB_180a7b029;
              fVar9 = (float)HeroSpeAddData.Get(*(int64 *)(lVar3 + 0x2b8),213,0);
              fVar10 = fVar10 * (fVar9 + 1.0);
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
                 (lVar1 = *(int64 *)(*(int64 *)(lVar4 + 72) + 16)) == null) break;
              if ((int)*(uint32 *)(lVar1 + 24) <= (int)uVar5) {
                uVar5 = 0;
                lVar6 = 32;
                goto LAB_180a7ad80;
              }
              if (*(uint32 *)(lVar1 + 24) <= uVar5) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (*(float *)(*(int64 *)(lVar1 + 16) + lVar6) != 0.0) {
                if (*(int64 *)(lVar3 + 0x138) == 0) break;
                FUN_1800d6790(*(int64 *)(lVar3 + 0x138),uVar5,DAT_181da1078);
                if ((*(int64 *)(lVar4 + 72) == 0) ||
                   (lVar1 = *(int64 *)(*(int64 *)(lVar4 + 72) + 16)) == null) break;
                FUN_1800d6790(lVar1,uVar5);
              }
              uVar5 = uVar5 + 1;
              lVar6 = lVar6 + 4;
            } while( true );
          }
        }
        LAB_180a7b029:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180a7ad80:
        if ((*(int64 *)(lVar4 + 72) == 0) ||
           (lVar1 = *(int64 *)(*(int64 *)(lVar4 + 72) + 24)) == null) goto LAB_180a7b029;
        if ((int)*(uint32 *)(lVar1 + 24) <= (int)uVar5) goto LAB_180a7ae20;
        if (*(uint32 *)(lVar1 + 24) <= uVar5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (*(float *)(*(int64 *)(lVar1 + 16) + lVar6) != 0.0) {
          if (*(int64 *)(lVar3 + 0x150) == 0) goto LAB_180a7b029;
          FUN_1800d6790(*(int64 *)(lVar3 + 0x150),uVar5,DAT_181da1078);
          if ((*(int64 *)(lVar4 + 72) == 0) ||
             (lVar1 = *(int64 *)(*(int64 *)(lVar4 + 72) + 24)) == null) goto LAB_180a7b029;
          FUN_1800d6790(lVar1,uVar5);
        }
        uVar5 = uVar5 + 1;
        lVar6 = lVar6 + 4;
        goto LAB_180a7ad80;
        LAB_180a7ae20:
        if ((*(int64 *)(lVar4 + 72) == 0) ||
           (lVar6 = *(int64 *)(*(int64 *)(lVar4 + 72) + 32)) == null) goto LAB_180a7b029;
        if ((int)*(uint32 *)(lVar6 + 24) <= (int)uVar7) {
          BattleController.LimitDamageRatio();
          if (*(int64 *)(lVar3 + 0x2b8) == 0) goto LAB_180a7b029;
          HeroSpeAddData.Get(*(int64 *)(lVar3 + 0x2b8),*(int *)(lVar4 + 48) + 15,0);
          if (0.0 < fVar10) {
            if (*(int64 *)(lVar3 + 0x2b8) == 0) goto LAB_180a7b029;
            HeroSpeAddData.Get(*(int64 *)(lVar3 + 0x2b8),60);
          }
          Mathf.Max();
          return;
        }
        if (*(uint32 *)(lVar6 + 24) <= uVar7) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (*(float *)(lVar8 + *(int64 *)(lVar6 + 16)) != 0.0) {
          if (*(int64 *)(lVar3 + 0x168) == 0) goto LAB_180a7b029;
          FUN_1800d6790(*(int64 *)(lVar3 + 0x168),uVar7,DAT_181da1078);
          if ((*(int64 *)(lVar4 + 72) == 0) ||
             (lVar6 = *(int64 *)(*(int64 *)(lVar4 + 72) + 32)) == null) goto LAB_180a7b029;
          FUN_1800d6790(lVar6,uVar7);
        }
        uVar7 = uVar7 + 1;
        lVar8 = lVar8 + 4;
        goto LAB_180a7ae20;
    }

    // Token : 0x6001283
    // RVA   : 0xA79510   Offset: 0xA78910   Length: 0x1CB
    public string GetSkillBattleCountDescribe()
    {
        ulong uVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        ulong uVar5;
        ulong uVar6;
        ulong uVar7;
        float fVar8;
        uint[] local_res18 = new uint[2];
        uint[] local_res20 = new uint[2];
        local_res18[0] = 0;
        lVar2 = KungfuSkillLvData.DataBase(this,0);
        if (lVar2 != null) {
          uVar3 = KungfuSkillData.Name(lVar2,1,0);
          local_res20[0] = this.useTime;
          uVar4 = il2cpp_value_box(DAT_181d80418,local_res20);
          lVar2 = KungfuSkillLvData.DataBase(this,0);
          uVar1 = "{0}\n使用次数 {1}{2}";
          if (lVar2 != null) {
            uVar6 = "";
            if (2 < *(int *)(lVar2 + 48)) {
              lVar2 = KungfuSkillLvData.DataBase(this,0);
              if (lVar2 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              fVar8 = (float)KungfuSkillData.GetBaseDamage(lVar2,this.lv,0);
              uVar6 = "\n造成{0} {1}";
              uVar7 = "伤害";
              if (fVar8 < 0.0) {
                uVar7 = "治疗";
              }
              local_res18[0] = this.battleDamageCount & 0x7fffffff;
              uVar5 = Single.ToString(local_res18,"f0",0);
              uVar6 = String.Format(uVar6,uVar7,uVar5,0);
            }
            String.Format(uVar1,uVar3,uVar4,uVar6,0);
            return;
          }
        }
    }

    // Token : 0x6001284
    // RVA   : 0xA796E0   Offset: 0xA78AE0   Length: 0x13F6
    public string GetSkillDescribe(bool fullDetail, bool showDamage, bool bookDescribe)
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
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
        float fVar16;
        uint32 uVar17;
        uint64 in_stack_ffffffffffffff78;
        float local_78;
        uint32 local_74;
        uint32 local_70;
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
              plVar6 = (int64 *)FUN_1800d60b0(DAT_181da5ce0,5);
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
        LAB_180a7aabf:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_74 = KungfuSkillData.GetBaseDamage(lVar4,this.lv,0);
            local_74 = local_74 & 0x7fffffff;
            uVar7 = il2cpp_value_box(DAT_181da22d8,&local_74);
            lVar4 = KungfuSkillLvData.DataBase(this,0);
            if (lVar4 == null) goto LAB_180a7aabf;
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
          fVar15 = (float)KungfuSkillData.GetManaCost(lVar4,this.lv,0);
          if (fVar15 != 0.0) {
            lVar4 = KungfuSkillLvData.DataBase(this,0);
            if (lVar4 == null) throw; // [null/range check failed]
            local_78 = (float)KungfuSkillData.GetManaCost(lVar4,this.lv,0);
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
               (lVar4 = FUN_1817d9e10(lVar4,*(uint32 *)(lVar9 + 128),DAT_181dbea08)) == null)
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
              uVar17 = 0x41200000;
            }
            else {
              uVar17 = 0x3f800000;
            }
            if (lVar4 == null) throw; // [null/range check failed]
            uVar10 = AttriNumData.GetDamageRatioDescribe(lVar4,uVar17,0);
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
            plVar6 = (int64 *)FUN_1800d60b0(DAT_181da5ce0,5);
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
          fVar15 = *(float *)(this + 100);
          lVar4 = KungfuSkillLvData.DataBase(this,0);
          if (lVar4 == null) throw; // [null/range check failed]
          if (*(int *)(lVar4 + 48) < 3) {
            lVar4 = KungfuSkillLvData.DataBase(this,0);
            if (lVar4 == null) throw; // [null/range check failed]
            fVar16 = (float)*(int *)(lVar4 + 52) * 15.0 + 75.0;
          }
          else {
            fVar16 = 0.0;
          }
          if (fVar15 < fVar16) goto LAB_180a7a50c;
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
            uVar7 = il2cpp_value_box(DAT_181d80418,local_68);
            uVar10 = "恢复{0}%已损失内力";
        LAB_180a7a4db:
            uVar10 = String.Format(uVar10,uVar7,0);
        LAB_180a7a4e6:
            uVar8 = String.Concat(uVar8,uVar10,0);
          }
          else {
            if (iVar1 == 1) {
              lVar5 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x470);
              lVar4 = KungfuSkillLvData.DataBase(this,0);
              uVar10 = "{0}{1}格内跳跃\n恢复{2}%已损失体力";
              if (lVar4 == null) throw; // [null/range check failed]
              if (lVar5 == null) {
        LAB_180a7aacb:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar7 = FUN_180002f80(lVar5,*(uint32 *)(lVar4 + 52) & 1,DAT_181da4358);
              lVar5 = KungfuSkillLvData.DataBase(this,0);
              if (lVar5 == null) goto LAB_180a7aacb;
              local_70 = KungfuSkillData.GetDodgeRange(lVar5,0);
              uVar11 = il2cpp_value_box(DAT_181d80418,&local_70);
              lVar5 = KungfuSkillLvData.DataBase(this,0);
              if (lVar5 == null) goto LAB_180a7aacb;
              local_6c = (10 - *(int *)(lVar5 + 52)) * 3;
              uVar12 = il2cpp_value_box(DAT_181d80418,&local_6c);
              in_stack_ffffffffffffff78 = 0;
              uVar10 = String.Format(uVar10,uVar7,uVar11,uVar12,0);
              goto LAB_180a7a4e6;
            }
            if (iVar1 == 2) {
              lVar5 = KungfuSkillLvData.DataBase(this,0);
              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              local_74 = 10 - *(int *)(lVar5 + 52);
              uVar7 = il2cpp_value_box(DAT_181d80418,&local_74);
              uVar10 = "恢复{0}%已损失生命";
              goto LAB_180a7a4db;
            }
          }
          lVar5 = String.Concat(uVar8,"\n功法效果翻倍(5回合)</color>",0);
        }
        LAB_180a7a50c:
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
                    fVar15 = 1.0;
                  }
                  else {
                    lVar4 = KungfuSkillLvData.DataBase(this,0);
                    if ((lVar4 == null) || (*(int64 *)(lVar4 + 80) == 0)) throw; // [null/range check failed]
                    fVar15 = (float)AttriNumData.GetSkillNeedExpRate(*(int64 *)(lVar4 + 80),lVar3,0)
                    ;
                  }
                  if ((cVar13 || bookDescribe) ||
                     ((this.lv < 10 && (fVar15 < 1.0)))) {
                    lVar4 = KungfuSkillLvData.DataBase(this,0);
                    if ((lVar4 == null) || (*(int64 *)(lVar4 + 80) == 0)) throw; // [null/range check failed]
                    uVar10 = AttriNumData.GetSkillNeedsDescribe(*(int64 *)(lVar4 + 80),lVar3,0);
                    uVar8 = "\n\n修炼需求{1}\n{0}";
                    lVar3 = "";
                    if (fVar15 < 1.0) {
                      local_78 = fVar15 * 100.0;
                      uVar7 = Single.ToString(&local_78,"f0",0);
                      lVar3 = String.Format("<size=14>(经验{0}%)</size>",uVar7,0);
                    }
                    uVar8 = String.Format(uVar8,uVar10,lVar3,0);
                    lVar5 = String.Concat(lVar5,uVar8,0);
                  }
                }
                cVar2 = false;
                if (**(int **)(DAT_181d73d40 + 184) != 2) {
                  cVar2 = cVar13;
                }
                if (cVar2) {
                  lVar3 = KungfuSkillLvData.DataBase(this,0);
                  if (lVar3 == null) throw; // [null/range check failed]
                  lVar5 = String.Concat(lVar5,"\n\n<color=grey><i>",*(uint64 *)(lVar3 + 40),"</i></color>",0
                                        );
                }
                if ((**(int **)(DAT_181d73d40 + 184) != 2) && (!cVar13)) {
                  lVar5 = String.Concat(lVar5,"\n<i><color=grey>左Shift查看详情</color></i>",0);
                }
                return lVar5;
              }
            }
          }
        }
    }

    // Token : 0x6001285
    // RVA   : 0xA77BE0   Offset: 0xA76FE0   Length: 0x175
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
