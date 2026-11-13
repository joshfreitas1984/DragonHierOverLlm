// ============================================================
// Type  : KungfuSkillData
// Token : 0x2000234
// ============================================================

public class KungfuSkillData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400119F
    public bool summonSkill;

    // Token: 0x40011A0
    public int skillID;

    // Token: 0x40011A1
    public int belongForceID;

    // Token: 0x40011A2
    public SkillTargetType targetType;

    // Token: 0x40011A3
    public string name;

    // Token: 0x40011A4
    public string describe;

    // Token: 0x40011A5
    public int type;

    // Token: 0x40011A6
    public int rareLv;

    // Token: 0x40011A7
    public float manaCost;

    // Token: 0x40011A8
    public float baseDamage;

    // Token: 0x40011A9
    public float expRatio;

    // Token: 0x40011AA
    public AttriNumData addDamageRatio;

    // Token: 0x40011AB
    public AttriNumData skillNeeds;

    // Token: 0x40011AC
    public HeroSpeAddData upgradeAddData;

    // Token: 0x40011AD
    public HeroSpeAddData equipAddData;

    // Token: 0x40011AE
    public HeroSpeAddData useAddData;

    // Token: 0x40011AF
    public List<SkillAttackRangeData> attackRangeData;

    // Token: 0x40011B0
    public SkillDamageRangeData damageRangeData;

    // Token: 0x40011B1
    public int summonID;

    // Token: 0x40011B2
    public int battleMaxUseTime;

    // Token: 0x40011B3
    public PartPostureData atkPartPosture;

    // Token: 0x40011B4
    public PartPostureData defPartPosture;

    // Token: 0x40011B5
    public string weaponName;

    // Token: 0x40011B6
    public string animationName;

    // Token: 0x40011B7
    public SkillBulletData skillBullet;

    // Token: 0x40011B8
    public List<SkillSpeEffectData> skillSpeEffects;

    // Token: 0x40011B9
    public SkillDamageOrder skillDamageOrder;

    // Token: 0x40011BA
    public bool autoHeroMove;

    // Token: 0x40011BB
    public int trailID;

    // Token: 0x40011BC
    public int maxAttackRange;

    // Token: 0x40011BD
    public bool hide;

    // Token: 0x40011BE
    public string iconName;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60012AB
    // RVA   : 0x7BAD90   Offset: 0x7B9B90   Length: 0x17C
    public void RefreshMaxAttackRange()
    {
        uint uVar1;
        int iVar2;
        long lVar3;
        uint uVar4;
        long lVar5;
        lVar3 = this.attackRangeData;
        uVar4 = 0;
        this.maxAttackRange = 0;
        if (lVar3 != null) {
          lVar5 = 32;
          while( true ) {
            if (lVar3.maxRange <= (int)uVar4) goto LAB_1807baeb9;
            if (lVar3 == null) break;
            if (lVar3.maxRange <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar3 = *(int64 *)(lVar5 + lVar3.rangeType);
            if (lVar3 == null) break;
            iVar2 = lVar3.rangeType;
            if (iVar2 == 0) {
        LAB_1807bae3a:
              uVar1 = this.maxAttackRange;
              if ((this.attackRangeData == null) ||
                 (lVar3 = FUN_1800024b0(this.attackRangeData,uVar4,DAT_181e84fb0)) == null)
              break;
              iVar2 = lVar3.maxRange;
        LAB_1807bae67:
              uVar1 = Mathf.Max(uVar1,iVar2,0);
              this.maxAttackRange = uVar1;
            }
            else {
              if (iVar2 == 1) {
        LAB_1807bae90:
                uVar1 = this.maxAttackRange;
                if ((this.attackRangeData != null) &&
                   (lVar3 = FUN_1800024b0(this.attackRangeData,uVar4,DAT_181e84fb0)) != null)
                {
                  iVar2 = lVar3.maxRange * 2;
                  goto LAB_1807bae67;
                }
                break;
              }
              if (iVar2 == 2) goto LAB_1807bae3a;
              if (iVar2 == 3) goto LAB_1807bae90;
              if (iVar2 == 4) goto LAB_1807bae3a;
            }
            lVar3 = this.attackRangeData;
            uVar4 = uVar4 + 1;
            lVar5 = lVar5 + 8;
            if (lVar3 == null) break;
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        LAB_1807baeb9:
        lVar3 = this.damageRangeData;
        if (lVar3 != null) {
          switch(lVar3.rangeType) {
          case 0:
          case 2:
          case 4:
          case 5:
          case 8:
            iVar2 = lVar3.maxRange;
            break;
          case 1:
          case 3:
          case 6:
            iVar2 = lVar3.maxRange * 2;
            break;
          default:
            goto switchD_1807baedd_caseD_7;
          }
          this.maxAttackRange = this.maxAttackRange + iVar2;
        }
        switchD_1807baedd_caseD_7:
    }

    // Token : 0x60012AC
    // RVA   : 0x7BACF0   Offset: 0x7B9AF0   Length: 0x8
    public bool HaveForce()
    {
        return this.belongForceID != -1;
    }

    // Token : 0x60012AD
    // RVA   : 0x7BAA70   Offset: 0x7B9870   Length: 0x23
    public int GetDodgeRange()
    {
        int iVar1;
        iVar1 = Mathf.FloorToInt((float)this.rareLv * 0.5,0);
        return iVar1 + 2;
    }

    // Token : 0x60012AE
    // RVA   : 0x7BA4B0   Offset: 0x7B92B0   Length: 0x359
    public string GetAttackRangeDescribe()
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        int iVar1;
        ulong uVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        ulong uVar7;
        ulong uVar8;
        int iVar9;
        ulong uVar10;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[2];
        iVar9 = 0;
        lVar3 = this.attackRangeData;
        uVar8 = "";
        while (lVar3 != null) {
          if (lVar3.Count <= iVar9) {
            return uVar8;
          }
          uVar10 = "";
          if (0 < iVar9) {
            uVar10 = "|";
          }
          if ((lVar3 == null) || (lVar3 = FUN_1800024b0(lVar3,iVar9,DAT_181e84fb0)) == null) break;
          if (lVar3._items == 4) {
            lVar3 = *(int64 *)(pStatics + 0x478);
            if (((this.attackRangeData == null) ||
                (lVar4 = FUN_1800024b0(this.attackRangeData,iVar9,DAT_181e84fb0)) == null) ||
               (lVar3 == null)) break;
            uVar5 = FUN_1800024b0(lVar3,lVar4._items,DAT_181e86970);
          }
          else {
            lVar3 = *(int64 *)(pStatics + 0x478);
            if (((this.attackRangeData == null) ||
                (lVar4 = FUN_1800024b0(this.attackRangeData,iVar9,DAT_181e84fb0)) == null) ||
               (lVar3 == null)) break;
            uVar5 = FUN_1800024b0(lVar3,lVar4._items,DAT_181e86970);
            if ((this.attackRangeData == null) ||
               (lVar3 = FUN_1800024b0(this.attackRangeData,iVar9,DAT_181e84fb0)) == null)
            break;
            iVar1 = *(int *)(lVar3 + 20);
            if ((this.attackRangeData == null) ||
               (lVar3 = FUN_1800024b0(this.attackRangeData,iVar9,DAT_181e84fb0),
               uVar2 = "{0}{1}格", lVar3 == null)) break;
            lVar4 = this.attackRangeData;
            if (iVar1 == lVar3.Count) {
              if ((lVar4 == null) || (lVar3 = FUN_1800024b0(lVar4,iVar9,DAT_181e84fb0)) == null) break;
              uVar6 = Int32.ToString(lVar3 + 20,0);
            }
            else {
              if ((lVar4 == null) || (lVar3 = FUN_1800024b0(lVar4,iVar9,DAT_181e84fb0)) == null) {
        LAB_1807ba804:
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              local_res8[0] = *(uint32 *)(lVar3 + 20);
              uVar6 = il2cpp_value_box(DAT_181e60808,local_res8);
              if ((this.attackRangeData == null) ||
                 (lVar3 = FUN_1800024b0(this.attackRangeData,iVar9,DAT_181e84fb0)) == null)
              goto LAB_1807ba804;
              local_res18[0] = lVar3.Count;
              uVar7 = il2cpp_value_box(DAT_181e60808,local_res18);
              uVar6 = String.Format("{0}~{1}",uVar6,uVar7,0);
            }
            uVar5 = String.Format(uVar2,uVar5,uVar6,0);
          }
          uVar8 = String.Concat(uVar8,uVar10,uVar5);
          iVar9 = iVar9 + 1;
          lVar3 = this.attackRangeData;
        }
    }

    // Token : 0x60012AF
    // RVA   : 0x7BA830   Offset: 0x7B9630   Length: 0x228
    public string GetDamageRangeDescribe()
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        uint uVar1;
        int iVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        ulong uVar6;
        long lVar7;
        ulong uVar8;
        int[] local_res8 = new int[2];
        uint[] local_res18 = new uint[4];
        uVar6 = "{0}{1}格";
        lVar7 = this.damageRangeData;
        if (lVar7 == null) goto LAB_1807baa4d;
        if (lVar7.rangeType == 7) {
          if (((*(byte *)(DAT_181e538e8 + 0x133) & 4) != 0) && (*(int *)(DAT_181e538e8 + 224) == 0)) {
            il2cpp_runtime_class_init(DAT_181e538e8);
            lVar7 = this.damageRangeData;
          }
          lVar3 = *(int64 *)(pStatics + 0x480);
          if ((lVar7 == null) || (lVar3 == null)) goto LAB_1807baa4d;
          uVar1 = lVar7.rangeType;
          if (*(uint32 *)(lVar3 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar6 = lVar3[uVar1];
        }
        else {
          uVar8 = "";
          if (lVar7.maxRange != null) {
            if (((*(byte *)(DAT_181e538e8 + 0x133) & 4) != 0) && (*(int *)(DAT_181e538e8 + 224) == 0)) {
              il2cpp_runtime_class_init(DAT_181e538e8);
              lVar7 = this.damageRangeData;
            }
            lVar3 = *(int64 *)(pStatics + 0x480);
            if ((lVar7 == null) || (lVar3 == null)) {
        LAB_1807baa4d:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            uVar1 = lVar7.rangeType;
            if (*(uint32 *)(lVar3 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              lVar7 = this.damageRangeData;
            }
            uVar8 = lVar3[uVar1];
            if (lVar7 == null) goto LAB_1807baa4d;
          }
          iVar2 = lVar7.minRange;
          if (iVar2 == lVar7.maxRange) {
            uVar4 = "1";
            if (iVar2 != 0) {
              uVar4 = Int32.ToString(lVar7 + 20,0);
            }
          }
          else {
            local_res8[0] = iVar2;
            uVar4 = il2cpp_value_box(DAT_181e60808,local_res8);
            if (this.damageRangeData == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            local_res18[0] = this.damageRangeData.maxRange;
            uVar5 = il2cpp_value_box(DAT_181e60808,local_res18);
            uVar4 = String.Format("{0}~{1}",uVar4,uVar5,0);
          }
          uVar6 = String.Format(uVar6,uVar8,uVar4,0);
        }
        return uVar6;
    }

    // Token : 0x60012B0
    // RVA   : 0x7BAB30   Offset: 0x7B9930   Length: 0x96
    public string GetSkillIcon()
    {
        bool cVar1;
        ulong uVar2;
        uint[] local_res8 = new uint[8];
        if (!this.summonSkill) {
          cVar1 = FUN_180ad1200(this.iconName,0);
          if (cVar1) {
            uVar2 = Int32.ToString(this + 20,0);
            return uVar2;
          }
          return this.iconName;
        }
        local_res8[0] = this.skillID;
        uVar2 = il2cpp_value_box(DAT_181e60808,local_res8);
        uVar2 = String.Format("summonskill{0}",uVar2,0);
        return uVar2;
    }

    // Token : 0x60012B1
    // RVA   : 0x7BA2F0   Offset: 0x7B90F0   Length: 0x26
    public float BadFame()
    {
        float fVar1;
        fVar1 = (float)FUN_1801e6830(0x40000000);
        return fVar1 * 5.0;
    }

    // Token : 0x60012B2
    // RVA   : 0x7BAD00   Offset: 0x7B9B00   Length: 0x8A
    public string Name(bool colored)
    {
        uint uVar1;
        ulong uVar2;
        uVar2 = this.name;
        if (colored) {
          uVar1 = this.rareLv;
          uVar2 = GlobalData.GenerateRareLvColorText(uVar2,uVar1,0);
          return uVar2;
        }
        return uVar2;
    }

    // Token : 0x60012B3
    // RVA   : 0x7BAF30   Offset: 0x7B9D30   Length: 0x203
    public string TypeDescribe()
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        uint uVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        uVar3 = "江湖";
        if (this.belongForceID != -1) {
          lVar2 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32);
          if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 208)) == null) throw; // [null/range check failed]
          lVar2 = FUN_18171b450(lVar2,this.belongForceID,DAT_181e9ad50);
          if (lVar2 == null) throw; // [null/range check failed]
          uVar3 = ForceData.GetForceName(lVar2,1,0);
        }
        lVar2 = *(int64 *)(pStatics + 0x518);
        if (lVar2 != null) {
          uVar1 = this.rareLv;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar4 = lVar2[uVar1];
          lVar2 = *(int64 *)(pStatics + 0x4a8);
          if (lVar2 != null) {
            uVar1 = this.type;
            if (*(uint32 *)(lVar2 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar4 = String.Concat(uVar4,*(uint64 *)
                                          (*(int64 *)(lVar2 + 16) + 32 + (int64)(int)uVar1 * 8),
                                   0);
            uVar4 = GlobalData.GenerateRareLvColorText(uVar4,this.rareLv,0);
            String.Concat(uVar3,uVar4,0);
            return;
          }
        }
    }

    // Token : 0x60012B4
    // RVA   : 0x7BAB20   Offset: 0x7B9920   Length: 0x10
    public float GetRealUpgradeRatio(int targetLv)
    {
        float FUN_1807bab20(uint64 this,int targetLv)
        {
        return (float)targetLv * 0.1;
    }

    // Token : 0x60012B5
    // RVA   : 0x7BA810   Offset: 0x7B9610   Length: 0x1D
    public float GetBaseDamage(int targetLv)
    {
        float FUN_1807ba810(int64 this,int targetLv)
        {
        return ((float)targetLv * 0.1 + 1.0) * this.baseDamage;
    }

    // Token : 0x60012B6
    // RVA   : 0x7BAAA0   Offset: 0x7B98A0   Length: 0x1D
    public float GetManaCost(int targetLv)
    {
        float FUN_1807baaa0(int64 this,int targetLv)
        {
        return ((float)targetLv * 0.1 + 1.0) * this.manaCost;
    }

    // Token : 0x60012B7
    // RVA   : 0x7BABD0   Offset: 0x7B99D0   Length: 0x84
    public HeroSpeAddData GetSpeEquipData(int targetLv)
    {
        ulong uVar1;
        if (this.equipAddData == null) {
          uVar1 = new HeroSpeAddData(0);
          return uVar1;
        }
        uVar1 = HeroSpeAddData.op_Multiply(this.equipAddData,(float)targetLv * 0.1 + 1.0,0);
        return uVar1;
    }

    // Token : 0x60012B8
    // RVA   : 0x7BAC60   Offset: 0x7B9A60   Length: 0x84
    public HeroSpeAddData GetSpeUseData(int targetLv)
    {
        ulong uVar1;
        if (this.useAddData == null) {
          uVar1 = new HeroSpeAddData(0);
          return uVar1;
        }
        uVar1 = HeroSpeAddData.op_Multiply(this.useAddData,(float)targetLv * 0.1 + 1.0,0);
        return uVar1;
    }

    // Token : 0x60012B9
    // RVA   : 0x7BAAC0   Offset: 0x7B98C0   Length: 0x5B
    public float GetMaxExp(int targetLv, int expType)
    {
        FUN_1801e6830();
        Mathf.RoundToInt();
    }

    // Token : 0x60012BA
    // RVA   : 0x7BA4A0   Offset: 0x7B92A0   Length: 0x8
    public PartPostureData GetAtkPartPosture(int targetLv)
    {
        uint64 FUN_1807ba4a0(int64 this)
        {
        return this.atkPartPosture;
    }

    // Token : 0x60012BB
    // RVA   : 0x7BAA60   Offset: 0x7B9860   Length: 0x8
    public PartPostureData GetDefPartPosture(int targetLv)
    {
        return this.defPartPosture;
    }

    // Token : 0x60012BC
    // RVA   : 0x7BB140   Offset: 0x7B9F40   Length: 0xB7
    public void /*ctor*/()
    {
        ulong uVar1;
        this.summonID = 0xffffffff;
        ZhSegment.Initialize(this,0);
        this.addDamageRatio = new AttriNumData(0);
        uVar1 = il2cpp_internal(DAT_181e774a8);
        FUN_1810f3480(uVar1,DAT_181e852b0);
        this.skillSpeEffects = uVar1;
    }

    // Token : 0x60012BD
    // RVA   : 0x7BA320   Offset: 0x7B9120   Length: 0x175
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
