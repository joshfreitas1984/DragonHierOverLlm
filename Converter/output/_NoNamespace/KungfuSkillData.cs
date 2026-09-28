// ============================================================
// Type  : KungfuSkillData
// Token : 0x2000232
// ============================================================

public class KungfuSkillData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001189
    public bool summonSkill;

    // Token: 0x400118A
    public int skillID;

    // Token: 0x400118B
    public int belongForceID;

    // Token: 0x400118C
    public SkillTargetType targetType;

    // Token: 0x400118D
    public string name;

    // Token: 0x400118E
    public string describe;

    // Token: 0x400118F
    public int type;

    // Token: 0x4001190
    public int rareLv;

    // Token: 0x4001191
    public float manaCost;

    // Token: 0x4001192
    public float baseDamage;

    // Token: 0x4001193
    public float expRatio;

    // Token: 0x4001194
    public AttriNumData addDamageRatio;

    // Token: 0x4001195
    public AttriNumData skillNeeds;

    // Token: 0x4001196
    public HeroSpeAddData upgradeAddData;

    // Token: 0x4001197
    public HeroSpeAddData equipAddData;

    // Token: 0x4001198
    public HeroSpeAddData useAddData;

    // Token: 0x4001199
    public List<SkillAttackRangeData> attackRangeData;

    // Token: 0x400119A
    public SkillDamageRangeData damageRangeData;

    // Token: 0x400119B
    public int summonID;

    // Token: 0x400119C
    public int battleMaxUseTime;

    // Token: 0x400119D
    public PartPostureData atkPartPosture;

    // Token: 0x400119E
    public PartPostureData defPartPosture;

    // Token: 0x400119F
    public string weaponName;

    // Token: 0x40011A0
    public string animationName;

    // Token: 0x40011A1
    public SkillBulletData skillBullet;

    // Token: 0x40011A2
    public List<SkillSpeEffectData> skillSpeEffects;

    // Token: 0x40011A3
    public SkillDamageOrder skillDamageOrder;

    // Token: 0x40011A4
    public bool autoHeroMove;

    // Token: 0x40011A5
    public int trailID;

    // Token: 0x40011A6
    public int maxAttackRange;

    // Token: 0x40011A7
    public bool hide;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600129A
    // RVA   : 0xCABE40   Offset: 0xCAB240   Length: 0x8
    public bool HaveForce()
    {
        return this.belongForceID != -1;
    }

    // Token : 0x600129B
    // RVA   : 0xCABBE0   Offset: 0xCAAFE0   Length: 0x23
    public int GetDodgeRange()
    {
        int iVar1;
        iVar1 = Mathf.FloorToInt((float)this.rareLv * 0.5,0);
        return iVar1 + 2;
    }

    // Token : 0x600129C
    // RVA   : 0xCAB630   Offset: 0xCAAA30   Length: 0x359
    public string GetAttackRangeDescribe()
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
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
          if ((lVar3 == null) || (lVar3 = FUN_180002f80(lVar3,iVar9,DAT_181da2958)) == null) break;
          if (lVar3._items == 4) {
            lVar3 = *(int64 *)(pStatics + 0x470);
            if (((this.attackRangeData == null) ||
                (lVar4 = FUN_180002f80(this.attackRangeData,iVar9,DAT_181da2958)) == null) ||
               (lVar3 == null)) break;
            uVar5 = FUN_180002f80(lVar3,lVar4._items,DAT_181da4358);
          }
          else {
            lVar3 = *(int64 *)(pStatics + 0x470);
            if (((this.attackRangeData == null) ||
                (lVar4 = FUN_180002f80(this.attackRangeData,iVar9,DAT_181da2958)) == null) ||
               (lVar3 == null)) break;
            uVar5 = FUN_180002f80(lVar3,lVar4._items,DAT_181da4358);
            if ((this.attackRangeData == null) ||
               (lVar3 = FUN_180002f80(this.attackRangeData,iVar9,DAT_181da2958)) == null)
            break;
            iVar1 = *(int *)(lVar3 + 20);
            if ((this.attackRangeData == null) ||
               (lVar3 = FUN_180002f80(this.attackRangeData,iVar9,DAT_181da2958),
               uVar2 = "{0}{1}格", lVar3 == null)) break;
            lVar4 = this.attackRangeData;
            if (iVar1 == lVar3.Count) {
              if ((lVar4 == null) || (lVar3 = FUN_180002f80(lVar4,iVar9,DAT_181da2958)) == null) break;
              uVar6 = Int32.ToString(lVar3 + 20,0);
            }
            else {
              if ((lVar4 == null) || (lVar3 = FUN_180002f80(lVar4,iVar9,DAT_181da2958)) == null) {
        LAB_180cab984:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              local_res8[0] = *(uint32 *)(lVar3 + 20);
              uVar6 = il2cpp_value_box(DAT_181d80418,local_res8);
              if ((this.attackRangeData == null) ||
                 (lVar3 = FUN_180002f80(this.attackRangeData,iVar9,DAT_181da2958)) == null)
              goto LAB_180cab984;
              local_res18[0] = lVar3.Count;
              uVar7 = il2cpp_value_box(DAT_181d80418,local_res18);
              uVar6 = String.Format("{0}~{1}",uVar6,uVar7,0);
            }
            uVar5 = String.Format(uVar2,uVar5,uVar6,0);
          }
          uVar8 = String.Concat(uVar8,uVar10,uVar5);
          iVar9 = iVar9 + 1;
          lVar3 = this.attackRangeData;
        }
    }

    // Token : 0x600129D
    // RVA   : 0xCAB9B0   Offset: 0xCAADB0   Length: 0x228
    public string GetDamageRangeDescribe()
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
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
        if (lVar7 == null) goto LAB_180cabbcd;
        if (lVar7.rangeType == 7) {
          if (((*(byte *)(DAT_181d73d40 + 0x133) & 4) != 0) && (*(int *)(DAT_181d73d40 + 224) == 0)) {
            il2cpp_runtime_class_init(DAT_181d73d40);
            lVar7 = this.damageRangeData;
          }
          lVar3 = *(int64 *)(pStatics + 0x478);
          if ((lVar7 == null) || (lVar3 == null)) goto LAB_180cabbcd;
          uVar1 = lVar7.rangeType;
          if (*(uint32 *)(lVar3 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar6 = lVar3[uVar1];
        }
        else {
          uVar8 = "";
          if (lVar7.maxRange != null) {
            if (((*(byte *)(DAT_181d73d40 + 0x133) & 4) != 0) && (*(int *)(DAT_181d73d40 + 224) == 0)) {
              il2cpp_runtime_class_init(DAT_181d73d40);
              lVar7 = this.damageRangeData;
            }
            lVar3 = *(int64 *)(pStatics + 0x478);
            if ((lVar7 == null) || (lVar3 == null)) {
        LAB_180cabbcd:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar1 = lVar7.rangeType;
            if (*(uint32 *)(lVar3 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              lVar7 = this.damageRangeData;
            }
            uVar8 = lVar3[uVar1];
            if (lVar7 == null) goto LAB_180cabbcd;
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
            uVar4 = il2cpp_value_box(DAT_181d80418,local_res8);
            if (this.damageRangeData == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_res18[0] = this.damageRangeData.maxRange;
            uVar5 = il2cpp_value_box(DAT_181d80418,local_res18);
            uVar4 = String.Format("{0}~{1}",uVar4,uVar5,0);
          }
          uVar6 = String.Format(uVar6,uVar8,uVar4,0);
        }
        return uVar6;
    }

    // Token : 0x600129E
    // RVA   : 0xCABCA0   Offset: 0xCAB0A0   Length: 0x76
    public string GetSkillIcon()
    {
        ulong uVar1;
        uint[] local_res8 = new uint[8];
        if (this.summonSkill) {
          local_res8[0] = this.skillID;
          uVar1 = il2cpp_value_box(DAT_181d80418,local_res8);
          String.Format("summonskill{0}",uVar1,0);
          return;
        }
        Int32.ToString((uint32 *)(this + 20),0);
    }

    // Token : 0x600129F
    // RVA   : 0xCAB480   Offset: 0xCAA880   Length: 0x26
    public float BadFame()
    {
        float fVar1;
        fVar1 = (float)FUN_1801f8ab0(0x40000000);
        return fVar1 * 5.0;
    }

    // Token : 0x60012A0
    // RVA   : 0xCABE50   Offset: 0xCAB250   Length: 0x8A
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

    // Token : 0x60012A1
    // RVA   : 0xCABEE0   Offset: 0xCAB2E0   Length: 0x203
    public string TypeDescribe()
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
        uint uVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        uVar3 = "江湖";
        if (this.belongForceID != -1) {
          lVar2 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
          if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 208)) == null) throw; // [null/range check failed]
          lVar2 = FUN_1817d9e10(lVar2,this.belongForceID,DAT_181db9760);
          if (lVar2 == null) throw; // [null/range check failed]
          uVar3 = ForceData.GetForceName(lVar2,1,0);
        }
        lVar2 = *(int64 *)(pStatics + 0x4f8);
        if (lVar2 != null) {
          uVar1 = this.rareLv;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar4 = lVar2[uVar1];
          lVar2 = *(int64 *)(pStatics + 0x4a0);
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

    // Token : 0x60012A2
    // RVA   : 0xCABC90   Offset: 0xCAB090   Length: 0x10
    public float GetRealUpgradeRatio(int targetLv)
    {
        float FUN_180cabc90(uint64 this,int targetLv)
        {
        return (float)targetLv * 0.1;
    }

    // Token : 0x60012A3
    // RVA   : 0xCAB990   Offset: 0xCAAD90   Length: 0x1D
    public float GetBaseDamage(int targetLv)
    {
        return ((float)targetLv * 0.1 + 1.0) * this.baseDamage;
    }

    // Token : 0x60012A4
    // RVA   : 0xCABC10   Offset: 0xCAB010   Length: 0x1D
    public float GetManaCost(int targetLv)
    {
        return ((float)targetLv * 0.1 + 1.0) * this.manaCost;
    }

    // Token : 0x60012A5
    // RVA   : 0xCABD20   Offset: 0xCAB120   Length: 0x84
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

    // Token : 0x60012A6
    // RVA   : 0xCABDB0   Offset: 0xCAB1B0   Length: 0x84
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

    // Token : 0x60012A7
    // RVA   : 0xCABC30   Offset: 0xCAB030   Length: 0x5B
    public float GetMaxExp(int targetLv, int expType)
    {
        FUN_1801f8ab0();
        Mathf.RoundToInt();
    }

    // Token : 0x60012A8
    // RVA   : 0x21B010   Offset: 0x21A410   Length: 0x8
    public PartPostureData GetAtkPartPosture(int targetLv)
    {
        uint64 FUN_18021b010(int64 this)
        {
        return this.atkPartPosture;
    }

    // Token : 0x60012A9
    // RVA   : 0x21B0B0   Offset: 0x21A4B0   Length: 0x8
    public PartPostureData GetDefPartPosture(int targetLv)
    {
        return this.defPartPosture;
    }

    // Token : 0x60012AA
    // RVA   : 0xCAC0F0   Offset: 0xCAB4F0   Length: 0xB7
    public void /*ctor*/()
    {
        ulong uVar1;
        this.summonID = 0xffffffff;
        ZhSegment.Initialize(this,0);
        this.addDamageRatio = new AttriNumData(0);
        uVar1 = il2cpp_internal(DAT_181d974d0);
        FUN_18132faf0(uVar1,DAT_181da2c58);
        this.skillSpeEffects = uVar1;
    }

    // Token : 0x60012AB
    // RVA   : 0xCAB4B0   Offset: 0xCAA8B0   Length: 0x175
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
