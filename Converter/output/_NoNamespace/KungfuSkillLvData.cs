// ============================================================
// Type  : KungfuSkillLvData
// Token : 0x2000229
// ============================================================

public class KungfuSkillLvData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001162
    public int skillID;

    // Token: 0x4001163
    public int lv;

    // Token: 0x4001164
    public float fightExp;

    // Token: 0x4001165
    public float bookExp;

    // Token: 0x4001166
    public bool equiped;

    // Token: 0x4001167
    public bool isNew;

    // Token: 0x4001168
    public int belongHeroID;

    // Token: 0x4001169
    public HeroSpeAddData speEquipData;

    // Token: 0x400116A
    public float equipUseSpeAddValue;

    // Token: 0x400116B
    public HeroSpeAddData speUseData;

    // Token: 0x400116C
    public float damageUseSpeAddValue;

    // Token: 0x400116D
    public float selfUseSpeAddValue;

    // Token: 0x400116E
    public float enemyUseSpeAddValue;

    // Token: 0x400116F
    public HeroSpeAddData extraAddData;

    // Token: 0x4001170
    public float cdTimeLeft;

    // Token: 0x4001171
    public int useTime;

    // Token: 0x4001172
    public float activeTimeLeft;

    // Token: 0x4001173
    public float power;

    // Token: 0x4001174
    public float battleDamageCount;

    // Token: 0x4001175
    public bool skillIconDirty;

    // Token: 0x4001176
    public bool maxManaChanged;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001269
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        this.skillID = param_2;
        this.speEquipData = new HeroSpeAddData(0);
        this.speUseData = new HeroSpeAddData(0);
        this.extraAddData = new HeroSpeAddData(0);
        KungfuSkillLvData.ResetSpeEquipData(this,0);
        KungfuSkillLvData.ResetSpeUseData(this,0);
    }

    // Token : 0x600126A
    // RVA   : 0x7C01E0   Offset: 0x7BEFE0   Length: 0xCE
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

    // Token : 0x600126B
    // RVA   : 0x7BD3E0   Offset: 0x7BC1E0   Length: 0x2E
    public float GetFullUpgradeTagPoint()
    {
        long lVar1;
        lVar1 = KungfuSkillLvData.DataBase(this,0);
        if (lVar1 != null) {
          FUN_1801e6830(0x40000000);
          return;
        }
    }

    // Token : 0x600126C
    // RVA   : 0x7BFEF0   Offset: 0x7BECF0   Length: 0xD1
    public bool SkillMeetObstacleLv()
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181e538e8 + 184) + 0x660);
        lVar3 = KungfuSkillLvData.DataBase(this,0);
        if ((lVar3 != null) && (lVar2 != null)) {
          uVar1 = *(uint32 *)(lVar3 + 52);
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2[uVar1];
          if (lVar2 != null) {
            FUN_18176a2d0(lVar2,this.lv,DAT_181e71570);
            return;
          }
        }
    }

    // Token : 0x600126D
    // RVA   : 0x7BF030   Offset: 0x7BDE30   Length: 0xAB
    public string GetSkillIcon()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uint[] local_res18 = new uint[4];
        lVar2 = KungfuSkillLvData.DataBase(this,0);
        if (lVar2 == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        if (*(char *)(lVar2 + 16) == false) {
          cVar1 = FUN_180ad1200(*(uint64 *)(lVar2 + 208),0);
          if (cVar1) {
            uVar3 = Int32.ToString(lVar2 + 20,0);
            return uVar3;
          }
          return *(uint64 *)(lVar2 + 208);
        }
        local_res18[0] = *(uint32 *)(lVar2 + 20);
        uVar3 = il2cpp_value_box(DAT_181e60808,local_res18);
        uVar3 = String.Format("summonskill{0}",uVar3,0);
        return uVar3;
    }

    // Token : 0x600126E
    // RVA   : 0x7BEAE0   Offset: 0x7BD8E0   Length: 0x45
    public float GetSkillExpExchangeRate()
    {
        long lVar1;
        lVar1 = KungfuSkillLvData.DataBase(this,0);
        if (lVar1 != null) {
          Mathf.Max(0.5 - (float)*(int *)(lVar1 + 52) * 0.1);
          return;
        }
    }

    // Token : 0x600126F
    // RVA   : 0x7C00B0   Offset: 0x7BEEB0   Length: 0xDB
    public int StudyMoneyCost()
    {
        int iVar1;
        long lVar2;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32);
        if (lVar2 != null) {
          lVar2 = GameDataController.GetSkillDataBase(lVar2,this.skillID,0);
          if (lVar2 != null) {
            iVar1 = Mathf.FloorToInt((float)*(int *)(lVar2 + 52) * 0.5,0);
            return (iVar1 + 1) * 20;
          }
        }
    }

    // Token : 0x6001270
    // RVA   : 0x7BFFD0   Offset: 0x7BEDD0   Length: 0xD5
    public int StudyDayCost()
    {
        int iVar1;
        long lVar2;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32);
        if (lVar2 != null) {
          lVar2 = GameDataController.GetSkillDataBase(lVar2,this.skillID,0);
          if (lVar2 != null) {
            iVar1 = Mathf.FloorToInt((float)*(int *)(lVar2 + 52) * 0.5,0);
            return iVar1 + 1;
          }
        }
    }

    // Token : 0x6001271
    // RVA   : 0x7BB7A0   Offset: 0x7BA5A0   Length: 0xA7
    public int BreakThroughDayCost()
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181e538e8 + 184) + 0x658);
        lVar3 = KungfuSkillLvData.DataBase(this,0);
        if ((lVar3 != null) && (lVar2 != null)) {
          uVar1 = *(uint32 *)(lVar3 + 52);
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          return lVar2[uVar1];
        }
    }

    // Token : 0x6001272
    // RVA   : 0x7BBA30   Offset: 0x7BA830   Length: 0xA3
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
            FUN_1801e0300();
          }
          uVar3 = FUN_180f34e60(fVar1 + deltaPower,0);
        }
        *(uint32 *)(this + 100) = uVar3;
    }

    // Token : 0x6001273
    // RVA   : 0x7BF1E0   Offset: 0x7BDFE0   Length: 0x56
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

    // Token : 0x6001274
    // RVA   : 0x7BB9D0   Offset: 0x7BA7D0   Length: 0x5B
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

    // Token : 0x6001275
    // RVA   : 0x7BF180   Offset: 0x7BDF80   Length: 0x51
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

    // Token : 0x6001276
    // RVA   : 0x7BBDC0   Offset: 0x7BABC0   Length: 0xE
    public void FightReset()
    {
        this.cdTimeLeft = 0;
        *(uint64 *)(this + 100) = 0;
        this.activeTimeLeft = 0;
    }

    // Token : 0x6001277
    // RVA   : 0x7BF0E0   Offset: 0x7BDEE0   Length: 0x68
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

    // Token : 0x6001278
    // RVA   : 0x7BB850   Offset: 0x7BA650   Length: 0x60
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

    // Token : 0x6001279
    // RVA   : 0x5C85A0   Offset: 0x5C73A0   Length: 0x9
    public float GetActiveTime()
    {
        return 0x40a00000;
    }

    // Token : 0x600127A
    // RVA   : 0x7BF240   Offset: 0x7BE040   Length: 0x8F
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

    // Token : 0x600127B
    // RVA   : 0x7C0190   Offset: 0x7BEF90   Length: 0x1D
    public int Type()
    {
        long lVar1;
        lVar1 = KungfuSkillLvData.DataBase(this,0);
        if (lVar1 != null) {
          return *(uint32 *)(lVar1 + 48);
        }
    }

    // Token : 0x600127C
    // RVA   : 0x7BBC70   Offset: 0x7BAA70   Length: 0xB6
    public KungfuSkillData DataBase()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32);
        if (lVar1 != null) {
          GameDataController.GetSkillDataBase(lVar1,this.skillID,0);
          return;
        }
    }

    // Token : 0x600127D
    // RVA   : 0x7BBEB0   Offset: 0x7BACB0   Length: 0x21
    public PartPostureData GetAtkPartPosture()
    {
        long lVar1;
        lVar1 = KungfuSkillLvData.DataBase(this,0);
        if (lVar1 != null) {
          return *(uint64 *)(lVar1 + 136);
        }
    }

    // Token : 0x600127E
    // RVA   : 0x7BD0E0   Offset: 0x7BBEE0   Length: 0x21
    public PartPostureData GetDefPartPosture()
    {
        long lVar1;
        lVar1 = KungfuSkillLvData.DataBase(this,0);
        if (lVar1 != null) {
          return *(uint64 *)(lVar1 + 144);
        }
    }

    // Token : 0x600127F
    // RVA   : 0x7BD410   Offset: 0x7BC210   Length: 0x31
    public float GetLvSpeDamageChange()
    {
        FUN_180f34e60((float)(this.lv + -4) * 0.25 + 1.0,0x3dcccccd,0x3f800000,0);
    }

    // Token : 0x6001280
    // RVA   : 0x7BBEE0   Offset: 0x7BACE0   Length: 0x3D
    public float GetBaseDamage()
    {
        long lVar1;
        lVar1 = KungfuSkillLvData.DataBase(this,0);
        if (lVar1 != null) {
          return ((float)this.lv * 0.1 + 1.0) * *(float *)(lVar1 + 60);
        }
    }

    // Token : 0x6001281
    // RVA   : 0x7BD450   Offset: 0x7BC250   Length: 0x3D
    public float GetManaCost()
    {
        long lVar1;
        lVar1 = KungfuSkillLvData.DataBase(this,0);
        if (lVar1 != null) {
          return ((float)this.lv * 0.1 + 1.0) * *(float *)(lVar1 + 56);
        }
    }

    // Token : 0x6001282
    // RVA   : 0x7C01B0   Offset: 0x7BEFB0   Length: 0x27
    public void Upgrade(int upgradeLv)
    {
        this.lv = this.lv + upgradeLv;
        KungfuSkillLvData.ResetSpeEquipData(this,0);
        KungfuSkillLvData.ResetSpeUseData(this,0);
        this.skillIconDirty = 1;
    }

    // Token : 0x6001283
    // RVA   : 0x7BF150   Offset: 0x7BDF50   Length: 0x21
    public HeroSpeAddData GetSpeEquipData()
    {
        if (0.0 < this.activeTimeLeft) {
          HeroSpeAddData.op_Multiply(this.speEquipData,2);
          return;
        }
    }

    // Token : 0x6001284
    // RVA   : 0x7BD3B0   Offset: 0x7BC1B0   Length: 0x21
    public HeroSpeAddData GetExtraAddData()
    {
        if (0.0 < this.activeTimeLeft) {
          HeroSpeAddData.op_Multiply(this.extraAddData,2);
          return;
        }
    }

    // Token : 0x6001285
    // RVA   : 0x7BF2D0   Offset: 0x7BE0D0   Length: 0x6A9
    public void ResetSpeEquipData()
    {
        float fVar1;
        ulong uVar2;
        bool cVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        int iVar7;
        int iVar8;
        float fVar9;
        float fStackX_c;
        float local_res18 [2];
        uint64 local_res20;
        int aiStack_cc [4];
        int local_bc;
        uint64 local_b8;
        uint64 uStack_b0;
        uint64 local_a8;
        uint64 uStack_a0;
        uint32 local_98;
        uint32 uStack_94;
        uint32 uStack_90;
        uint32 uStack_8c;
        uint64 local_88;
        uint64 uStack_80;
        int64 local_78;
        local_b8 = 0;
        uStack_b0 = 0;
        local_a8 = 0;
        uStack_a0 = 0;
        local_res18[0] = 0.0;
        local_bc = 0;
        if (this.extraAddData == null) {
          this.extraAddData = new HeroSpeAddData(0);
        }
        lVar5 = KungfuSkillLvData.DataBase(this,0);
        iVar7 = this.lv;
        if (lVar5 != null) {
          if (*(int64 *)(lVar5 + 96) == 0) {
            uVar4 = new HeroSpeAddData(0);
          }
          else {
            uVar4 = HeroSpeAddData.op_Multiply(*(int64 *)(lVar5 + 96),(float)iVar7 * 0.1 + 1.0,0);
          }
          this.speEquipData = uVar4;
          if (this.speEquipData == null) {
            return;
          }
          cVar3 = HeroSpeAddData.isEmpty(this.speEquipData,0);
          if (cVar3) {
            return;
          }
          this.equipUseSpeAddValue = 0;
          if (this.extraAddData != null) {
            lVar5 = this.extraAddData.heroSpeAddData;
            local_78 = lVar5;
            lVar6 = KungfuSkillLvData.DataBase(this,0);
            if (lVar6 != null) {
              if (*(int *)(lVar6 + 48) < 3) {
                if ((this.speEquipData == null) ||
                   (lVar6 = this.speEquipData.heroSpeAddData) == null)
                throw; // [null/range check failed]
                FUN_18125c400(&local_98,lVar6,DAT_181e9f778);
                local_b8 = CONCAT44(uStack_94,local_98);
                uStack_b0 = CONCAT44(uStack_8c,uStack_90);
                local_a8 = local_88;
                uStack_a0 = uStack_80;
                while (cVar3 = FUN_180dd5b00(&local_b8,DAT_181e7cd30), uVar2 = local_a8, iVar7 = local_bc,
                      cVar3) {
                  local_res20 = local_a8;
                  local_res20._4_4_ = (float)(local_a8 >> 32);
                  fVar9 = local_res20._4_4_;
                  local_res20 = uVar2;
                  if (lVar5 != null) {
                    if (this.extraAddData == null) {
                          // WARNING: Subroutine does not return
                      FUN_1801e0300();
                    }
                    lVar6 = this.extraAddData.heroSpeAddData;
                    if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                      FUN_1801e0300();
                    }
                    cVar3 = FUN_181691540(lVar6,local_a8 & 0xffffffff,local_res18,DAT_181e9fb30);
                    if (cVar3) {
                      fVar9 = fVar9 + local_res18[0];
                    }
                  }
                  if (fVar9 != 0.0) {
                    fVar1 = this.equipUseSpeAddValue;
                    lVar6 = FUN_180210740(0);
                    if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                      FUN_1801e0300();
                    }
                    if (*(int64 *)(lVar6 + 144) == 0) {
                          // WARNING: Subroutine does not return
                      FUN_1801e0300();
                    }
                    lVar6 = FUN_1800024b0(*(int64 *)(lVar6 + 144),uVar2 & 0xffffffff,DAT_181e6e1f0);
                    if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                      FUN_1801e0300();
                    }
                    this.equipUseSpeAddValue = fVar9 / *(float *)(lVar6 + 32) + fVar1;
                  }
                }
                aiStack_cc[1] = 0x101;
                iVar8 = local_bc + 1;
                local_bc = iVar8;
                ZhSegment.Initialize(&local_b8,DAT_181e7ccb0);
                if ((iVar8 != 0) && (local_bc = iVar8, aiStack_cc[iVar8] == 0x101)) {
                  iVar8 = iVar7;
                  local_bc = iVar7;
                }
                if (lVar5 == null) {
                  return;
                }
                if ((this.extraAddData == null) ||
                   (lVar5 = this.extraAddData.heroSpeAddData) == null)
                throw; // [null/range check failed]
                FUN_18125c400(&local_98,lVar5,DAT_181e9f778);
                local_b8 = CONCAT44(uStack_94,local_98);
                uStack_b0 = CONCAT44(uStack_8c,uStack_90);
                local_a8 = local_88;
                uStack_a0 = uStack_80;
                while (cVar3 = FUN_180dd5b00(&local_b8,DAT_181e7cd30), uVar2 = local_a8, cVar3) {
                  local_res20 = local_a8;
                  if (this.speEquipData == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  lVar5 = this.speEquipData.heroSpeAddData;
                  if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  cVar3 = FUN_1806da450(lVar5,local_a8 & 0xffffffff,DAT_181e9f5e8);
                  if ((!cVar3) && (fVar9 = local_res20._4_4_, local_res20._4_4_ != null.0)) {
                    fVar1 = this.equipUseSpeAddValue;
                    lVar5 = FUN_180210740(0);
                    if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                      FUN_1801e0300();
                    }
                    if (*(int64 *)(lVar5 + 144) == 0) {
                          // WARNING: Subroutine does not return
                      FUN_1801e0300();
                    }
                    lVar5 = FUN_1800024b0(*(int64 *)(lVar5 + 144),uVar2 & 0xffffffff,DAT_181e6e1f0);
                    if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                      FUN_1801e0300();
                    }
                    this.equipUseSpeAddValue = fVar9 / *(float *)(lVar5 + 32) + fVar1;
                  }
                }
                aiStack_cc[(int64)iVar8 + 1] = 0x1f8;
                iVar7 = local_bc + 1;
                local_bc = iVar7;
                ZhSegment.Initialize(&local_b8,DAT_181e7ccb0);
                if ((iVar7 != 0) && (aiStack_cc[iVar7] == 0x1f8)) {
                  return;
                }
              }
              if ((this.speEquipData != null) &&
                 (lVar5 = this.speEquipData.heroSpeAddData) != null) {
                FUN_18125c400(&local_98,lVar5,DAT_181e9f778);
                local_a8 = local_88;
                uStack_a0 = uStack_80;
                while( true ) {
                  cVar3 = FUN_180dd5b00(&local_b8,DAT_181e7cd30);
                  uVar2 = local_a8;
                  if (!cVar3) {
                    ZhSegment.Initialize(&local_b8,DAT_181e7ccb0);
                    return;
                  }
                  fVar9 = this.equipUseSpeAddValue;
                  lVar5 = FUN_180210740(0);
                  if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  if (*(int64 *)(lVar5 + 144) == 0) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  lVar5 = FUN_1800024b0(*(int64 *)(lVar5 + 144),uVar2 & 0xffffffff,DAT_181e6e1f0);
                  if (lVar5 == null) break;
                  fStackX_c = (float)(uVar2 >> 32);
                  this.equipUseSpeAddValue = fStackX_c / *(float *)(lVar5 + 32) + fVar9;
                }
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
            }
          }
        }
    }

    // Token : 0x6001286
    // RVA   : 0x7BF980   Offset: 0x7BE780   Length: 0x4F7
    public void ResetSpeUseData()
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        int iVar5;
        int iVar6;
        uint32 uStackX_c;
        float fStackX_1c;
        float local_res20 [2];
        float fStack_b4;
        int aiStack_b0 [4];
        uint64 local_a0;
        uint64 uStack_98;
        uint64 local_90;
        uint64 uStack_88;
        uint32 local_80;
        uint32 uStack_7c;
        uint32 uStack_78;
        uint32 uStack_74;
        uint64 local_70;
        uint64 uStack_68;
        local_a0 = 0;
        uStack_98 = 0;
        local_90 = 0;
        uStack_88 = 0;
        local_res20[0] = 0.0;
        aiStack_b0[3] = 0;
        lVar3 = KungfuSkillLvData.DataBase(this,0);
        iVar5 = this.lv;
        if (lVar3 != null) {
          bVar7 = false;
          if (*(int64 *)(lVar3 + 104) == 0) {
            uVar4 = new HeroSpeAddData(0);
          }
          else {
            uVar4 = HeroSpeAddData.op_Multiply(*(int64 *)(lVar3 + 104),(float)iVar5 * 0.1 + 1.0,0);
          }
          this.speUseData = uVar4;
          if (this.speUseData == null) {
            return;
          }
          cVar2 = HeroSpeAddData.isEmpty(this.speUseData,0);
          if (cVar2) {
            return;
          }
          this.damageUseSpeAddValue = 0;
          this.enemyUseSpeAddValue = 0;
          if (this.extraAddData != null) {
            bVar7 = this.extraAddData.heroSpeAddData != null;
          }
          lVar3 = KungfuSkillLvData.DataBase(this,0);
          if (lVar3 != null) {
            if (2 < *(int *)(lVar3 + 48)) {
              if ((this.speUseData == null) ||
                 (lVar3 = this.speUseData.heroSpeAddData) == null)
              throw; // [null/range check failed]
              FUN_18125c400(&local_80,lVar3,DAT_181e9f778);
              local_a0 = CONCAT44(uStack_7c,local_80);
              uStack_98 = CONCAT44(uStack_74,uStack_78);
              local_90 = local_70;
              uStack_88 = uStack_68;
              while (cVar2 = FUN_180dd5b00(&local_a0,DAT_181e7cd30), uVar1 = local_90,
                    iVar5 = aiStack_b0[3], cVar2) {
                fStack_b4 = (float)(local_90 >> 32);
                if (bVar7) {
                  if (this.extraAddData == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  lVar3 = this.extraAddData.heroSpeAddData;
                  if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  cVar2 = FUN_181691540(lVar3,local_90 & 0xffffffff,local_res20);
                  if (cVar2) {
                    fStack_b4 = fStack_b4 + local_res20[0];
                  }
                }
                if (fStack_b4 != 0.0) {
                  KungfuSkillLvData.AddUseSpeAddValue(this,uVar1 & 0xffffffff,fStack_b4,0);
                }
              }
              aiStack_b0[0] = 243;
              iVar6 = aiStack_b0[3] + 1;
              aiStack_b0[3] = iVar6;
              ZhSegment.Initialize(&local_a0,DAT_181e7ccb0);
              if ((iVar6 != 0) && (aiStack_b0[3] = iVar6, aiStack_b0[(int64)iVar6 + -1] == 243)) {
                iVar6 = iVar5;
                aiStack_b0[3] = iVar5;
              }
              if (!bVar7) {
                return;
              }
              if ((this.extraAddData == null) ||
                 (lVar3 = this.extraAddData.heroSpeAddData) == null)
              throw; // [null/range check failed]
              FUN_18125c400(&local_80,lVar3,DAT_181e9f778);
              local_a0 = CONCAT44(uStack_7c,local_80);
              uStack_98 = CONCAT44(uStack_74,uStack_78);
              local_90 = local_70;
              uStack_88 = uStack_68;
              while (cVar2 = FUN_180dd5b00(&local_a0,DAT_181e7cd30), uVar1 = local_90, cVar2) {
                if (this.speUseData == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                lVar3 = this.speUseData.heroSpeAddData;
                if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                cVar2 = FUN_1806da450(lVar3,local_90 & 0xffffffff,DAT_181e9f5e8);
                if ((!cVar2) && (fStackX_1c = (float)(uVar1 >> 32), fStackX_1c != 0.0)) {
                  KungfuSkillLvData.AddUseSpeAddValue(this,uVar1 & 0xffffffff,fStackX_1c,0);
                }
              }
              aiStack_b0[iVar6] = 0x1b2;
              iVar5 = aiStack_b0[3] + 1;
              aiStack_b0[3] = iVar5;
              ZhSegment.Initialize(&local_a0,DAT_181e7ccb0);
              if ((iVar5 != 0) && (aiStack_b0[(int64)iVar5 + -1] == 0x1b2)) {
                return;
              }
            }
            if ((this.speUseData != null) &&
               (lVar3 = this.speUseData.heroSpeAddData) != null) {
              FUN_18125c400(&local_80,lVar3,DAT_181e9f778);
              local_90 = local_70;
              uStack_88 = uStack_68;
              while (cVar2 = FUN_180dd5b00(&local_a0,DAT_181e7cd30), cVar2) {
                uStackX_c = (uint32)(local_90 >> 32);
                KungfuSkillLvData.AddUseSpeAddValue(this,local_90 & 0xffffffff,uStackX_c,0);
              }
              ZhSegment.Initialize(&local_a0,DAT_181e7ccb0);
              return;
            }
          }
        }
    }

    // Token : 0x6001287
    // RVA   : 0x7BB200   Offset: 0x7BA000   Length: 0x2E0
    private void AddUseSpeAddValue(int key, float value)
    {
        float fVar1;
        bool cVar2;
        long lVar3;
        long lVar4;
        lVar4 = (int64)(int)key;
        lVar3 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32);
        if ((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 144)) != null) {
          if (*(uint32 *)(lVar3 + 24) <= key) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar3 = *(int64 *)(*(int64 *)(lVar3 + 16) + 32 + lVar4 * 8);
          if (lVar3 != null) {
            lVar3 = *(int64 *)(lVar3 + 72);
            if (lVar3 == null) {
              return;
            }
            cVar2 = FUN_1816387f0(lVar3,"伤害",0);
            if (!cVar2) {
              cVar2 = FUN_1816387f0(lVar3,"我方",0);
              if (!cVar2) {
                cVar2 = FUN_1816387f0(lVar3,"敌方",0);
                if (!cVar2) {
                  return;
                }
                fVar1 = this.enemyUseSpeAddValue;
                lVar4 = FUN_180210740(0);
                if (((lVar4 != null) && (*(int64 *)(lVar4 + 144) != 0)) &&
                   (lVar4 = FUN_1800024b0(*(int64 *)(lVar4 + 144),key,DAT_181e6e1f0)) != null)
                {
                  this.enemyUseSpeAddValue = value / *(float *)(lVar4 + 32) + fVar1;
                  return;
                }
              }
              else {
                fVar1 = this.selfUseSpeAddValue;
                lVar3 = FUN_180210740(0);
                if ((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 144)) != null) {
                  if (*(uint32 *)(lVar3 + 24) <= key) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar4 = *(int64 *)(*(int64 *)(lVar3 + 16) + 32 + lVar4 * 8);
                  if (lVar4 != null) {
                    this.selfUseSpeAddValue = value / *(float *)(lVar4 + 32) + fVar1;
                    return;
                  }
                }
              }
            }
            else {
              fVar1 = this.damageUseSpeAddValue;
              lVar3 = FUN_180210740(0);
              if ((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 144)) != null) {
                if (*(uint32 *)(lVar3 + 24) <= key) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar4 = *(int64 *)(*(int64 *)(lVar3 + 16) + 32 + lVar4 * 8);
                if (lVar4 != null) {
                  this.damageUseSpeAddValue = value / *(float *)(lVar4 + 32) + fVar1;
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6001288
    // RVA   : 0x72CC40   Offset: 0x72BA40   Length: 0x5
    public HeroSpeAddData GetSpeUseData()
    {
        return this.speUseData;
    }

    // Token : 0x6001289
    // RVA   : 0x7BFE80   Offset: 0x7BEC80   Length: 0x6F
    public float SkillGetMaxExp(int expType)
    {
        long lVar1;
        lVar1 = KungfuSkillLvData.DataBase(this,0);
        if (lVar1 != null) {
          FUN_1801e6830();
          Mathf.RoundToInt();
          return;
        }
    }

    // Token : 0x600128A
    // RVA   : 0x7BB8C0   Offset: 0x7BA6C0   Length: 0x103
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
          FUN_1801e6830();
          iVar2 = Mathf.RoundToInt();
          if (fVar1 < (float)iVar2) {
            return false;
          }
          fVar1 = this.fightExp;
          lVar3 = KungfuSkillLvData.DataBase(this,0);
          if (lVar3 != null) {
            FUN_1801e6830();
            iVar2 = Mathf.RoundToInt();
            return (float)iVar2 <= fVar1;
          }
        }
    }

    // Token : 0x600128B
    // RVA   : 0x7BB710   Offset: 0x7BA510   Length: 0x84
    public bool BookExpFull()
    {
        float fVar1;
        int iVar2;
        long lVar3;
        fVar1 = this.bookExp;
        lVar3 = KungfuSkillLvData.DataBase(this,0);
        if (lVar3 != null) {
          FUN_1801e6830();
          iVar2 = Mathf.RoundToInt();
          return (float)iVar2 <= fVar1;
        }
    }

    // Token : 0x600128C
    // RVA   : 0x7BBD30   Offset: 0x7BAB30   Length: 0x84
    public bool FightExpFull()
    {
        float fVar1;
        int iVar2;
        long lVar3;
        fVar1 = this.fightExp;
        lVar3 = KungfuSkillLvData.DataBase(this,0);
        if (lVar3 != null) {
          FUN_1801e6830();
          iVar2 = Mathf.RoundToInt();
          return (float)iVar2 <= fVar1;
        }
    }

    // Token : 0x600128D
    // RVA   : 0x7BBDD0   Offset: 0x7BABD0   Length: 0xD6
    public void FullFillExp()
    {
        int iVar1;
        long lVar2;
        float fVar3;
        lVar2 = KungfuSkillLvData.DataBase(this,0);
        if (lVar2 != null) {
          fVar3 = (float)FUN_1801e6830();
          iVar1 = Mathf.RoundToInt((float)(this.lv + 1) * fVar3 * 25.0 *
                                    *(float *)(lVar2 + 64),0);
          this.bookExp = (float)iVar1;
          lVar2 = KungfuSkillLvData.DataBase(this,0);
          if (lVar2 != null) {
            FUN_1801e6830();
            iVar1 = Mathf.RoundToInt();
            this.skillIconDirty = 1;
            this.fightExp = (float)iVar1;
            return;
          }
        }
    }

    // Token : 0x600128E
    // RVA   : 0x7BD110   Offset: 0x7BBF10   Length: 0x29C
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
        plVar1 = (int64 *)FUN_1801dfd90(DAT_181e84278,4);
        local_res8[0] = (int)this.bookExp;
        lVar2 = il2cpp_value_box(DAT_181e60808,local_res8);
        if (plVar1 == (int64 *)0) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        if (lVar2 != null) {
          lVar3 = il2cpp_internal(lVar2,*(uint64 *)(*plVar1 + 64));
          if (lVar3 == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar4,0);
          }
        }
        if ((int)plVar1[3] == 0) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar4,0);
        }
        plVar1[4] = lVar2;
        il2cpp_internal(plVar1 + 4,lVar2);
        local_res18[0] = KungfuSkillLvData.SkillGetMaxExp(this,0,0);
        lVar2 = il2cpp_value_box(DAT_181e82730,local_res18);
        if (lVar2 != null) {
          lVar3 = il2cpp_internal(lVar2,*(uint64 *)(*plVar1 + 64));
          if (lVar3 == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar4,0);
          }
        }
        if (*(uint32 *)(plVar1 + 3) < 2) {
          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar4,0);
        }
        plVar1[5] = lVar2;
        il2cpp_internal(plVar1 + 5,lVar2);
        local_res20[0] = (int)this.fightExp;
        lVar2 = il2cpp_value_box(DAT_181e60808,local_res20);
        if (lVar2 != null) {
          lVar3 = il2cpp_internal(lVar2,*(uint64 *)(*plVar1 + 64));
          if (lVar3 == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar4,0);
          }
        }
        if (2 < *(uint32 *)(plVar1 + 3)) {
          plVar1[6] = lVar2;
          il2cpp_internal(plVar1 + 6,lVar2);
          local_28[0] = KungfuSkillLvData.SkillGetMaxExp(this,1);
          lVar2 = il2cpp_value_box(DAT_181e82730,local_28);
          if (lVar2 != null) {
            lVar3 = il2cpp_internal(lVar2,*(uint64 *)(*plVar1 + 64));
            if (lVar3 == null) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar4,0);
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
          FUN_1801e02d0(uVar4,0);
        }
        uVar4 = il2cpp_internal();
    }

    // Token : 0x600128F
    // RVA   : 0x7BC6F0   Offset: 0x7BB4F0   Length: 0x9EB
    public List<int> GetBreakThroughAvailableChoice()
    {
        var pStatics_bdc8 = *(int64*)(DAT_181e5bdc8 + 184);
        uint uVar1;
        long lVar2;
        ulong uVar3;
        bool cVar4;
        long lVar5;
        long lVar6;
        long lVar7;
        ulong uVar9;
        uint uVar10;
        uint uVar11;
        long lVar12;
        float fVar13;
        ulong local_78;
        ulong uStack_70;
        ulong local_68;
        uint local_60;
        uint32 uStack_5c;
        uint32 uStack_58;
        uint32 uStack_54;
        uint64 local_50;
        local_78 = 0;
        uStack_70 = 0;
        local_68 = 0;
        uVar11 = 0;
        if (PlotController.attriIndexCache == null) goto LAB_1807bd093;
        cVar4 = FUN_1806da450(PlotController.attriIndexCache,this.skillID,
                              DAT_181e981d8);
        if (cVar4) {
          if (PlotController.attriIndexCache != null) {
            uVar9 = FUN_18171b450(PlotController.attriIndexCache,this.skillID,
                                  DAT_181e98260);
            lVar5 = il2cpp_internal(DAT_181e73cb8);
            FUN_18177a7d0(lVar5,uVar9,DAT_181e712f0);
            return lVar5;
          }
          goto LAB_1807bd093;
        }
        lVar5 = KungfuSkillLvData.DataBase(this,0);
        lVar6 = il2cpp_internal(DAT_181e73cb8);
        FUN_1810f3480(lVar6,DAT_181e71270);
        if (lVar5 == null) goto LAB_1807bd093;
        if (*(int *)(lVar5 + 48) < 3) {
          if (lVar6 == null) goto LAB_1807bd093;
          FUN_181769fe0(lVar6,*(int *)(lVar5 + 48) + 6,DAT_181e713f0);
          lVar7 = il2cpp_internal(DAT_181e73cb8);
          FUN_1810f3480(lVar7,DAT_181e71270);
          if (lVar7 == null) goto LAB_1807bd093;
          FUN_181769fe0(lVar7,57,DAT_181e713f0);
          uVar9 = 59;
        LAB_1807bca6e:
          FUN_181769fe0(lVar7,uVar9,DAT_181e713f0);
        }
        else {
          if (*(int *)(lVar5 + 28) == 4) {
            lVar7 = il2cpp_internal(DAT_181e73cb8);
            FUN_1810f3480(lVar7,DAT_181e71270);
            if (lVar7 == null) goto LAB_1807bd093;
            FUN_181769fe0(lVar7,208,DAT_181e713f0);
            FUN_181769fe0(lVar7,209,DAT_181e713f0);
            uVar9 = 210;
            goto LAB_1807bca6e;
          }
          if (0.0 < *(float *)(lVar5 + 60)) {
            lVar7 = il2cpp_internal(DAT_181e73cb8);
            FUN_1810f3480(lVar7,DAT_181e71270);
            if (lVar7 == null) goto LAB_1807bd093;
            FUN_181769fe0(lVar7,60,DAT_181e713f0);
            FUN_181769fe0(lVar7,64,DAT_181e713f0);
            FUN_181769fe0(lVar7,66,DAT_181e713f0);
            FUN_181769fe0(lVar7,69,DAT_181e713f0);
            FUN_181769fe0(lVar7,70,DAT_181e713f0);
          }
          else {
            lVar7 = il2cpp_internal(DAT_181e73cb8);
            FUN_1810f3480(lVar7,DAT_181e71270);
            if (lVar7 == null) goto LAB_1807bd093;
            FUN_181769fe0(lVar7,66,DAT_181e713f0);
            FUN_181769fe0(lVar7,70,DAT_181e713f0);
          }
        }
        uVar9 = Enumerable.Concat(lVar6,lVar7,DAT_181e960a8);
        lVar6 = FUN_18077cf20(uVar9,DAT_181e98ba0);
        if (*(int64 *)(lVar5 + 72) == 0) {
        LAB_1807bcc13:
          if ((*(int *)(lVar5 + 48) < 3) && (*(int64 *)(lVar5 + 88) != 0)) {
            lVar7 = *(int64 *)(*(int64 *)(lVar5 + 88) + 16);
            if ((lVar7 == null) || (lVar7 = Dictionary_2.get_Keys(lVar7,DAT_181e9fd50)) == null)
            goto LAB_1807bd093;
            FUN_180b274e0(&local_60,lVar7,DAT_181ea5920);
            local_78 = CONCAT44(uStack_5c,local_60);
            uStack_70 = CONCAT44(uStack_54,uStack_58);
            local_68 = local_50;
            while (cVar4 = FUN_180dd6f80(&local_78,DAT_181e7d130), uVar3 = local_68, cVar4) {
              if (*(int64 *)(lVar5 + 88) == 0) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              fVar13 = (float)HeroSpeAddData.Get(*(int64 *)(lVar5 + 88),local_68 & 0xffffffff,0);
              if (fVar13 != 0.0) {
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                FUN_181769fe0(lVar6,uVar3 & 0xffffffff);
              }
            }
            ZhSegment.Initialize(&local_78,DAT_181e7d0b0);
          }
          if (*(int64 *)(lVar5 + 96) != 0) {
            lVar7 = *(int64 *)(*(int64 *)(lVar5 + 96) + 16);
            if ((lVar7 == null) || (lVar7 = Dictionary_2.get_Keys(lVar7,DAT_181e9fd50)) == null)
            goto LAB_1807bd093;
            FUN_180b274e0(&local_60,lVar7,DAT_181ea5920);
            local_78 = CONCAT44(uStack_5c,local_60);
            uStack_70 = CONCAT44(uStack_54,uStack_58);
            local_68 = local_50;
            while (cVar4 = FUN_180dd6f80(&local_78,DAT_181e7d130), uVar3 = local_68, cVar4) {
              if (*(int64 *)(lVar5 + 96) == 0) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              fVar13 = (float)HeroSpeAddData.Get(*(int64 *)(lVar5 + 96),local_68 & 0xffffffff,0);
              if (fVar13 != 0.0) {
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                FUN_181769fe0(lVar6,uVar3 & 0xffffffff);
              }
            }
            ZhSegment.Initialize(&local_78,DAT_181e7d0b0);
          }
          if (*(int64 *)(lVar5 + 104) != 0) {
            lVar7 = *(int64 *)(*(int64 *)(lVar5 + 104) + 16);
            if ((lVar7 == null) || (lVar7 = Dictionary_2.get_Keys(lVar7,DAT_181e9fd50)) == null)
            goto LAB_1807bd093;
            FUN_180b274e0(&local_60,lVar7,DAT_181ea5920);
            local_78 = CONCAT44(uStack_5c,local_60);
            uStack_70 = CONCAT44(uStack_54,uStack_58);
            local_68 = local_50;
            while (cVar4 = FUN_180dd6f80(&local_78,DAT_181e7d130), uVar3 = local_68, cVar4) {
              if (*(int64 *)(lVar5 + 104) == 0) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              fVar13 = (float)HeroSpeAddData.Get(*(int64 *)(lVar5 + 104),local_68 & 0xffffffff,0);
              if (fVar13 != 0.0) {
                if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                  FUN_1801e0300();
                }
                FUN_181769fe0(lVar6,uVar3 & 0xffffffff);
              }
            }
            ZhSegment.Initialize(&local_78,DAT_181e7d0b0);
          }
          lVar5 = *(int64 *)(pStatics_bdc8 + 8);
          if (lVar5 == null) {
            uVar9 = **(uint64 **)(DAT_181e5bdc8 + 184);
            lVar5 = new OnTooltipCB(uVar9,DAT_181e8a5a0,DAT_181ea08d8);
            plVar8 = (int64 *)(pStatics_bdc8 + 8);
            *plVar8 = lVar5;
            il2cpp_internal(plVar8,lVar5);
          }
          if (lVar6 != null) {
            FUN_18176e100(lVar6,lVar5,DAT_181e71870);
            lVar5 = PlotController.attriIndexCache;
            uVar1 = this.skillID;
            uVar9 = il2cpp_internal(DAT_181e73cb8);
            FUN_18177a7d0(uVar9,lVar6,DAT_181e712f0);
            if (lVar5 != null) {
              FUN_1806da2f0(lVar5,uVar1,uVar9,DAT_181e98150);
              return lVar6;
            }
          }
        }
        else {
          lVar7 = 32;
          lVar12 = 32;
          uVar10 = uVar11;
          while ((*(int64 *)(lVar5 + 72) != 0 &&
                 (lVar2 = *(int64 *)(*(int64 *)(lVar5 + 72) + 16)) != null)) {
            if ((int)*(uint32 *)(lVar2 + 24) <= (int)uVar10) {
              lVar12 = 32;
              uVar10 = uVar11;
              goto LAB_1807bcb40;
            }
            if (*(uint32 *)(lVar2 + 24) <= uVar10) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(float *)(lVar12 + *(int64 *)(lVar2 + 16)) != 0.0) {
              if (lVar6 == null) break;
              FUN_181769fe0(lVar6,uVar10,DAT_181e713f0);
            }
            uVar10 = uVar10 + 1;
            lVar12 = lVar12 + 4;
          }
        }
        LAB_1807bd093:
                          // WARNING: Subroutine does not return
        FUN_1801e0300();
        LAB_1807bcb40:
        if ((*(int64 *)(lVar5 + 72) == 0) ||
           (lVar2 = *(int64 *)(*(int64 *)(lVar5 + 72) + 24)) == null) goto LAB_1807bd093;
        if ((int)*(uint32 *)(lVar2 + 24) <= (int)uVar10) goto LAB_1807bcbb0;
        if (*(uint32 *)(lVar2 + 24) <= uVar10) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (*(float *)(lVar12 + *(int64 *)(lVar2 + 16)) != 0.0) {
          if (lVar6 == null) goto LAB_1807bd093;
          FUN_181769fe0(lVar6,uVar10 + 6,DAT_181e713f0);
        }
        uVar10 = uVar10 + 1;
        lVar12 = lVar12 + 4;
        goto LAB_1807bcb40;
        LAB_1807bcbb0:
        if ((*(int64 *)(lVar5 + 72) == 0) ||
           (lVar12 = *(int64 *)(*(int64 *)(lVar5 + 72) + 32)) == null) goto LAB_1807bd093;
        if ((int)*(uint32 *)(lVar12 + 24) <= (int)uVar11) goto LAB_1807bcc13;
        if (*(uint32 *)(lVar12 + 24) <= uVar11) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (*(float *)(lVar7 + *(int64 *)(lVar12 + 16)) != 0.0) {
          if (lVar6 == null) goto LAB_1807bd093;
          FUN_181769fe0(lVar6,uVar11 + 24,DAT_181e713f0);
        }
        uVar11 = uVar11 + 1;
        lVar7 = lVar7 + 4;
        goto LAB_1807bcbb0;
    }

    // Token : 0x6001290
    // RVA   : 0x7BB4F0   Offset: 0x7BA2F0   Length: 0x214
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
          lVar2 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32);
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

    // Token : 0x6001291
    // RVA   : 0x7BBC60   Offset: 0x7BAA60   Length: 0xD
    public static float CountDamageRatio(float sourceNum, float addRatio)
    {
        float FUN_1807bbc60(float sourceNum,float addRatio)
        {
        return sourceNum * 0.01 * addRatio;
    }

    // Token : 0x6001292
    // RVA   : 0x7BBF20   Offset: 0x7BAD20   Length: 0x7C4
    public HeroData GetBelongHero()
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        int iVar4;
        int iVar5;
        if (this.belongHeroID < 0) {
          lVar3 = PlotController.LaBaFestivelResultTalkText;
          if (lVar3 != null) {
            iVar4 = 0;
            if (*(int *)(lVar3 + 36) == 0) {
        LAB_1807bc540:
              do {

                if ((lVar3 = *(int64 *)(*(int64 *)(DAT_181e71f68 + 184) + 24)?.tutorialFinished) == null)
                goto LAB_1807bc6df;
                if (lVar3.cityAreaID <= iVar4) {
                  return 0;
                }
                lVar3 = FUN_180210a70(0);
                if ((lVar3 == null) || (lVar3.tutorialFinished == null)) goto LAB_1807bc6df;
                lVar3 = FUN_1800024b0(lVar3.tutorialFinished,iVar4,DAT_181e6dd70);
                if (lVar3 != null) {
                  lVar3 = FUN_180210a70(0);
                  if ((((lVar3 == null) || (lVar3.tutorialFinished == null)) ||
                      (lVar3 = FUN_1800024b0(lVar3.tutorialFinished,iVar4,DAT_181e6dd70), lVar3 == null
                      )) || (lVar3.customDifficultyData == null)) goto LAB_1807bc6df;
                  cVar1 = FUN_18175e190(lVar3.customDifficultyData,this,DAT_181e74470);
                  if (cVar1) goto LAB_1807bc694;
                }
                iVar4 = iVar4 + 1;
              } while( true );
            }
            iVar5 = 0;
            while( true ) {

              if ((lVar3 = PlotController.LaBaFestivelResultTalkText?.ResourcePoints) == null) break;
              if (lVar3.cityAreaID <= iVar5) {
                iVar5 = 0;
                goto LAB_1807bc310;
              }
              iVar4 = 0;
              while( true ) {
                lVar3 = FUN_1802101c0(0);
                if (((lVar3 == null) || (lVar3.ResourcePoints == null)) ||
                   (lVar3 = FUN_1800024b0(lVar3.ResourcePoints,iVar5,DAT_181e59f78)) == null)
                goto LAB_1807bc6df;
                if (lVar3.cityAreaID <= iVar4) break;
                lVar3 = FUN_1802101c0(0);
                if (((lVar3 == null) || (lVar3.ResourcePoints == null)) ||
                   ((lVar3 = FUN_1800024b0(lVar3.ResourcePoints,iVar5,DAT_181e59f78), lVar3 == null ||
                    ((lVar3 = FUN_1800024b0(lVar3,iVar4,DAT_181e6dd70), lVar3 == null ||
                     (lVar3.customDifficultyData == null)))))) goto LAB_1807bc6df;
                cVar1 = FUN_18175e190(lVar3.customDifficultyData,this,DAT_181e74470);
                if (cVar1) {
                  lVar3 = FUN_1802101c0(0);
                  if (((lVar3 == null) || (lVar3.ResourcePoints == null)) ||
                     (lVar3 = FUN_1800024b0(lVar3.ResourcePoints,iVar5,DAT_181e59f78)) == null)
                  goto LAB_1807bc6df;
                  goto LAB_1807bc2ec;
                }
                iVar4 = iVar4 + 1;
              }
              iVar5 = iVar5 + 1;
            }
          }
        }
        else {
          if ((GameController._instance != null) &&
             (lVar3 = GameController._instance.worldData) != null) {
            uVar2 = WorldData.GetHero(lVar3,this.belongHeroID,0);
            return uVar2;
          }
        }
        LAB_1807bc6df:
                          // WARNING: Subroutine does not return
        FUN_1801e0300();
        LAB_1807bc310:

        if ((lVar3 = PlotController.LaBaFestivelResultTalkText?.lastRandomWorldEventDay) == null) goto LAB_1807bc6df;
        iVar4 = 0;
        if (lVar3.cityAreaID <= iVar5) goto LAB_1807bc540;
        iVar4 = 0;
        while( true ) {
          lVar3 = FUN_1802101c0(0);
          if ((((lVar3 == null) || (lVar3.lastRandomWorldEventDay == null)) ||
              (lVar3 = FUN_1800024b0(lVar3.lastRandomWorldEventDay,iVar5,DAT_181e61878)) == null) ||
             (lVar3.cityAreaID == null)) goto LAB_1807bc6df;
          if (*(int *)(lVar3.cityAreaID + 24) <= iVar4) break;
          lVar3 = FUN_1802101c0(0);
          if ((((lVar3 == null) || (lVar3.lastRandomWorldEventDay == null)) ||
              ((lVar3 = FUN_1800024b0(lVar3.lastRandomWorldEventDay,iVar5,DAT_181e61878), lVar3 == null ||
               (((lVar3.cityAreaID == null ||
                 (lVar3 = FUN_1800024b0(lVar3.cityAreaID,iVar4,DAT_181e61c78)) == null) ||
                (lVar3.ResourcePoints == null)))))) ||
             (lVar3 = *(int64 *)(lVar3.ResourcePoints + 0x260)) == null) goto LAB_1807bc6df;
          cVar1 = FUN_18175e190(lVar3,this,DAT_181e74470);
          if (cVar1) {
            lVar3 = FUN_1802101c0(0);
            if (((lVar3 != null) && (lVar3.lastRandomWorldEventDay != null)) &&
               ((lVar3 = FUN_1800024b0(lVar3.lastRandomWorldEventDay,iVar5,DAT_181e61878), lVar3 != null &&
                ((lVar3.cityAreaID != null &&
                 (lVar3 = FUN_1800024b0(lVar3.cityAreaID,iVar4,DAT_181e61c78)) != null)))))
            {
              return lVar3.ResourcePoints;
            }
            goto LAB_1807bc6df;
          }
          iVar4 = iVar4 + 1;
        }
        iVar5 = iVar5 + 1;
        goto LAB_1807bc310;
        LAB_1807bc694:

        if ((lVar3 = FUN_180210a70(0)?.tutorialFinished) != null) {
        LAB_1807bc2ec:
          uVar2 = FUN_1800024b0(lVar3,iVar4,DAT_181e6dd70);
          return uVar2;
        }
        goto LAB_1807bc6df;
    }

    // Token : 0x6001293
    // RVA   : 0x7BEB30   Offset: 0x7BD930   Length: 0x4FE
    public float GetSkillFightScore()
    {
        int iVar1;
        long lVar2;
        bool cVar3;
        long lVar4;
        long lVar5;
        uint uVar6;
        long lVar7;
        uint uVar8;
        long lVar9;
        float fVar10;
        float fVar11;
        lVar4 = KungfuSkillLvData.DataBase(this,0);
        if (lVar4 != null) {
          iVar1 = this.lv;
          fVar11 = *(float *)(lVar4 + 60);
          fVar10 = (float)FUN_180f34e60((float)(iVar1 + -4) * 0.25 + 1.0,0x3dcccccd,0x3f800000,0);
          fVar10 = fVar10 * ((float)iVar1 * 0.1 + 1.0) * fVar11;
          lVar4 = KungfuSkillLvData.GetBelongHero(this,0);
          if (lVar4 == null) {
            return;
          }
          cVar3 = HeroData.HaveForce(lVar4,0);
          if (cVar3) {
            lVar5 = KungfuSkillLvData.DataBase(this,0);
            if (lVar5 == null) goto LAB_1807bf029;
            if (*(int *)(lVar5 + 24) == *(int *)(lVar4 + 132)) {
              if (*(int64 *)(lVar4 + 0x2b8) == 0) goto LAB_1807bf029;
              fVar11 = (float)HeroSpeAddData.Get(*(int64 *)(lVar4 + 0x2b8),213,0);
              fVar10 = fVar10 * (fVar11 + 1.0);
            }
          }
          lVar5 = KungfuSkillLvData.DataBase(this,0);
          uVar8 = 0;
          uVar6 = 0;
          if (lVar5 != null) {
            lVar9 = 32;
            lVar7 = 32;
            do {
              if ((*(int64 *)(lVar5 + 72) == 0) ||
                 (lVar2 = *(int64 *)(*(int64 *)(lVar5 + 72) + 16)) == null) break;
              if ((int)*(uint32 *)(lVar2 + 24) <= (int)uVar6) {
                uVar6 = 0;
                lVar7 = 32;
                goto LAB_1807bed80;
              }
              if (*(uint32 *)(lVar2 + 24) <= uVar6) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (*(float *)(*(int64 *)(lVar2 + 16) + lVar7) != 0.0) {
                if (*(int64 *)(lVar4 + 0x138) == 0) break;
                FUN_1800024e0(*(int64 *)(lVar4 + 0x138),uVar6,DAT_181e83530);
                if ((*(int64 *)(lVar5 + 72) == 0) ||
                   (lVar2 = *(int64 *)(*(int64 *)(lVar5 + 72) + 16)) == null) break;
                FUN_1800024e0(lVar2,uVar6);
              }
              uVar6 = uVar6 + 1;
              lVar7 = lVar7 + 4;
            } while( true );
          }
        }
        LAB_1807bf029:
                          // WARNING: Subroutine does not return
        FUN_1801e0300();
        LAB_1807bed80:
        if ((*(int64 *)(lVar5 + 72) == 0) ||
           (lVar2 = *(int64 *)(*(int64 *)(lVar5 + 72) + 24)) == null) goto LAB_1807bf029;
        if ((int)*(uint32 *)(lVar2 + 24) <= (int)uVar6) goto LAB_1807bee20;
        if (*(uint32 *)(lVar2 + 24) <= uVar6) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (*(float *)(*(int64 *)(lVar2 + 16) + lVar7) != 0.0) {
          if (*(int64 *)(lVar4 + 0x150) == 0) goto LAB_1807bf029;
          FUN_1800024e0(*(int64 *)(lVar4 + 0x150),uVar6,DAT_181e83530);
          if ((*(int64 *)(lVar5 + 72) == 0) ||
             (lVar2 = *(int64 *)(*(int64 *)(lVar5 + 72) + 24)) == null) goto LAB_1807bf029;
          FUN_1800024e0(lVar2,uVar6);
        }
        uVar6 = uVar6 + 1;
        lVar7 = lVar7 + 4;
        goto LAB_1807bed80;
        LAB_1807bee20:
        if ((*(int64 *)(lVar5 + 72) == 0) ||
           (lVar7 = *(int64 *)(*(int64 *)(lVar5 + 72) + 32)) == null) goto LAB_1807bf029;
        if ((int)*(uint32 *)(lVar7 + 24) <= (int)uVar8) {
          BattleController.LimitDamageRatio();
          if (*(int64 *)(lVar4 + 0x2b8) == 0) goto LAB_1807bf029;
          HeroSpeAddData.Get(*(int64 *)(lVar4 + 0x2b8),*(int *)(lVar5 + 48) + 15,0);
          if (0.0 < fVar10) {
            if (*(int64 *)(lVar4 + 0x2b8) == 0) goto LAB_1807bf029;
            HeroSpeAddData.Get(*(int64 *)(lVar4 + 0x2b8),60);
          }
          Mathf.Max();
          return;
        }
        if (*(uint32 *)(lVar7 + 24) <= uVar8) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (*(float *)(lVar9 + *(int64 *)(lVar7 + 16)) != 0.0) {
          if (*(int64 *)(lVar4 + 0x168) == 0) goto LAB_1807bf029;
          FUN_1800024e0(*(int64 *)(lVar4 + 0x168),uVar8,DAT_181e83530);
          if ((*(int64 *)(lVar5 + 72) == 0) ||
             (lVar7 = *(int64 *)(*(int64 *)(lVar5 + 72) + 32)) == null) goto LAB_1807bf029;
          FUN_1800024e0(lVar7,uVar8);
        }
        uVar8 = uVar8 + 1;
        lVar9 = lVar9 + 4;
        goto LAB_1807bee20;
    }

    // Token : 0x6001294
    // RVA   : 0x7BD490   Offset: 0x7BC290   Length: 0x216
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
          uVar5 = il2cpp_value_box(DAT_181e60808,local_res20);
          lVar3 = KungfuSkillLvData.DataBase(this,0);
          uVar2 = "{0}\n使用次数 {1}{2}";
          if (lVar3 != null) {
            uVar7 = "";
            if (2 < *(int *)(lVar3 + 48)) {
              lVar3 = KungfuSkillLvData.DataBase(this,0);
              uVar7 = "\n造成{0} {1}";
              if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
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

    // Token : 0x6001295
    // RVA   : 0x7BD6B0   Offset: 0x7BC4B0   Length: 0x1426
    public string GetSkillDescribe(bool fullDetail, bool showDamage, bool bookDescribe)
    {
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
          if ((GameController._instance == null) ||
             (lVar3 = GameController._instance.worldData) == null)
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
              plVar6 = (int64 *)FUN_1801dfd90(DAT_181e85e38,5);
              if (plVar6 == (int64 *)0) throw; // [null/range check failed]
              if ((lVar5 != null) &&
                 (lVar4 = il2cpp_internal(lVar5,*(uint64 *)(*plVar6 + 64))) == null) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar8,0);
              }
              if ((int)plVar6[3] == 0) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar8,0);
              }
              plVar6[4] = lVar5;
              il2cpp_internal(plVar6 + 4,lVar5);
              if (("\n<size=18><b>" != 0) &&
                 (lVar5 = il2cpp_internal("\n<size=18><b>",*(uint64 *)(*plVar6 + 64))) == null)
              {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar8,0);
              }
              lVar5 = "\n<size=18><b>";
              if (*(uint32 *)(plVar6 + 3) < 2) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar8,0);
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
                FUN_1801e02d0(uVar8,0);
              }
              if (*(uint32 *)(plVar6 + 3) < 3) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar8,0);
              }
              plVar6[6] = lVar4;
              il2cpp_internal(plVar6 + 6,lVar4);
              local_78 = (float)KungfuSkillLvData.GetSkillFightScore(this,0);
              lVar5 = Single.ToString(&local_78,"f0",0);
              if ((lVar5 != null) &&
                 (lVar4 = il2cpp_internal(lVar5,*(uint64 *)(*plVar6 + 64))) == null) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar8,0);
              }
              if (*(uint32 *)(plVar6 + 3) < 4) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar8,0);
              }
              plVar6[7] = lVar5;
              il2cpp_internal(plVar6 + 7,lVar5);
              if (("</color></b></size>" != 0) &&
                 (lVar5 = il2cpp_internal("</color></b></size>",*(uint64 *)(*plVar6 + 64))) == null)
              {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar8,0);
              }
              lVar5 = "</color></b></size>";
              if (*(uint32 *)(plVar6 + 3) < 5) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar8,0);
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
        LAB_1807beabf:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            local_74 = ABS(((float)this.lv * 0.1 + 1.0) * *(float *)(lVar4 + 60));
            uVar7 = il2cpp_value_box(DAT_181e82730,&local_74);
            lVar4 = KungfuSkillLvData.DataBase(this,0);
            if (lVar4 == null) goto LAB_1807beabf;
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
            lVar4 = FUN_180210740(0);
            if (lVar4 == null) throw; // [null/range check failed]
            lVar4 = *(int64 *)(lVar4 + 400);
            lVar9 = KungfuSkillLvData.DataBase(this,0);
            if (((lVar9 == null) || (lVar4 == null)) ||
               (lVar4 = FUN_18171b450(lVar4,*(uint32 *)(lVar9 + 128),DAT_181ea02a0)) == null)
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
            plVar6 = (int64 *)FUN_1801dfd90(DAT_181e85e38,5);
            if (plVar6 == (int64 *)0) throw; // [null/range check failed]
            if ((lVar5 != null) &&
               (lVar4 = il2cpp_internal(lVar5,*(uint64 *)(*plVar6 + 64))) == null) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar8,0);
            }
            if ((int)plVar6[3] == 0) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar8,0);
            }
            plVar6[4] = lVar5;
            il2cpp_internal(plVar6 + 4,lVar5);
            if (("\n\n每场战斗使用次数 " != 0) &&
               (lVar5 = il2cpp_internal("\n\n每场战斗使用次数 ",*(uint64 *)(*plVar6 + 64))) == null) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar8,0);
            }
            lVar5 = "\n\n每场战斗使用次数 ";
            if (*(uint32 *)(plVar6 + 3) < 2) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar8,0);
            }
            plVar6[5] = "\n\n每场战斗使用次数 ";
            il2cpp_internal(plVar6 + 5,lVar5);
            lVar5 = Int32.ToString(this + 92,0);
            if ((lVar5 != null) &&
               (lVar4 = il2cpp_internal(lVar5,*(uint64 *)(*plVar6 + 64))) == null) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar8,0);
            }
            if (*(uint32 *)(plVar6 + 3) < 3) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar8,0);
            }
            plVar6[6] = lVar5;
            il2cpp_internal(plVar6 + 6,lVar5);
            if (("/" != 0) &&
               (lVar5 = il2cpp_internal("/",*(uint64 *)(*plVar6 + 64))) == null) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar8,0);
            }
            lVar5 = "/";
            if (*(uint32 *)(plVar6 + 3) < 4) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar8,0);
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
              FUN_1801e02d0(uVar8,0);
            }
            if (*(uint32 *)(plVar6 + 3) < 5) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar8,0);
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
          if (fVar17 < fVar15) goto LAB_1807be50c;
          uVar8 = String.Concat(lVar5,"\n\n激活效果\n<color=#FF8C00>",0);
          lVar5 = KungfuSkillLvData.DataBase(this,0);
          if (lVar5 == null) throw; // [null/range check failed]
          iVar1 = *(int *)(lVar5 + 48);
          if (iVar1 == 0) {
            lVar5 = KungfuSkillLvData.DataBase(this,0);
            if (lVar5 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            local_68[0] = (10 - *(int *)(lVar5 + 52)) * 2;
            uVar7 = il2cpp_value_box(DAT_181e60808,local_68);
            uVar10 = "恢复{0}%已损失内力";
        LAB_1807be4db:
            uVar10 = String.Format(uVar10,uVar7,0);
        LAB_1807be4e6:
            uVar8 = String.Concat(uVar8,uVar10,0);
          }
          else {
            if (iVar1 == 1) {
              lVar5 = *(int64 *)(*(int64 *)(DAT_181e538e8 + 184) + 0x478);
              lVar4 = KungfuSkillLvData.DataBase(this,0);
              uVar10 = "{0}{1}格内跳跃\n恢复{2}%已损失体力";
              if (lVar4 == null) throw; // [null/range check failed]
              if (lVar5 == null) {
        LAB_1807beacb:
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              uVar7 = FUN_1800024b0(lVar5,*(uint32 *)(lVar4 + 52) & 1,DAT_181e86970);
              lVar5 = KungfuSkillLvData.DataBase(this,0);
              if (lVar5 == null) goto LAB_1807beacb;
              local_70 = Mathf.FloorToInt((float)*(int *)(lVar5 + 52) * 0.5,0);
              local_70 = local_70 + 2;
              uVar11 = il2cpp_value_box(DAT_181e60808,&local_70);
              lVar5 = KungfuSkillLvData.DataBase(this,0);
              if (lVar5 == null) goto LAB_1807beacb;
              local_6c = (10 - *(int *)(lVar5 + 52)) * 3;
              uVar12 = il2cpp_value_box(DAT_181e60808,&local_6c);
              in_stack_ffffffffffffff78 = 0;
              uVar10 = String.Format(uVar10,uVar7,uVar11,uVar12,0);
              goto LAB_1807be4e6;
            }
            if (iVar1 == 2) {
              lVar5 = KungfuSkillLvData.DataBase(this,0);
              if (lVar5 == null) {
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              local_74 = (float)(10 - *(int *)(lVar5 + 52));
              uVar7 = il2cpp_value_box(DAT_181e60808,&local_74);
              uVar10 = "恢复{0}%已损失生命";
              goto LAB_1807be4db;
            }
          }
          lVar5 = String.Concat(uVar8,"\n功法效果翻倍(5回合)</color>",0);
        }
        LAB_1807be50c:
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
                if (**(int **)(DAT_181e538e8 + 184) != 2) {
                  cVar2 = cVar13;
                }
                if (cVar2) {
                  lVar3 = KungfuSkillLvData.DataBase(this,0);
                  if (lVar3 == null) throw; // [null/range check failed]
                  lVar5 = String.Concat(lVar5,"\n\n<color=grey><i>",lVar3.forceAreaID,"</i></color>",0
                                        );
                }
                if ((**(int **)(DAT_181e538e8 + 184) != 2) && (!cVar13)) {
                  lVar5 = String.Concat(lVar5,"\n<i><color=grey>左Shift查看详情</color></i>",0);
                }
                return lVar5;
              }
            }
          }
        }
    }

    // Token : 0x6001296
    // RVA   : 0x7BBAE0   Offset: 0x7BA8E0   Length: 0x175
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
        plVar1 = (int64 *)il2cpp_internal(DAT_181e695f0);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181e91a00);
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
            FUN_180002280(0,DAT_181e58ab8,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
    }

}
