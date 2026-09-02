// ============================================================
// Type  : KungfuSkillData
// Token : 0x200022C
// ============================================================

public class KungfuSkillData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40010E6
    public bool summonSkill;

    // Token: 0x40010E7
    public int skillID;

    // Token: 0x40010E8
    public int belongForceID;

    // Token: 0x40010E9
    public SkillTargetType targetType;

    // Token: 0x40010EA
    public string name;

    // Token: 0x40010EB
    public string describe;

    // Token: 0x40010EC
    public int type;

    // Token: 0x40010ED
    public int rareLv;

    // Token: 0x40010EE
    public float manaCost;

    // Token: 0x40010EF
    public float baseDamage;

    // Token: 0x40010F0
    public float expRatio;

    // Token: 0x40010F1
    public AttriNumData addDamageRatio;

    // Token: 0x40010F2
    public AttriNumData skillNeeds;

    // Token: 0x40010F3
    public HeroSpeAddData upgradeAddData;

    // Token: 0x40010F4
    public HeroSpeAddData equipAddData;

    // Token: 0x40010F5
    public HeroSpeAddData useAddData;

    // Token: 0x40010F6
    public List<SkillAttackRangeData> attackRangeData;

    // Token: 0x40010F7
    public SkillDamageRangeData damageRangeData;

    // Token: 0x40010F8
    public int summonID;

    // Token: 0x40010F9
    public int battleMaxUseTime;

    // Token: 0x40010FA
    public PartPostureData atkPartPosture;

    // Token: 0x40010FB
    public PartPostureData defPartPosture;

    // Token: 0x40010FC
    public string weaponName;

    // Token: 0x40010FD
    public string animationName;

    // Token: 0x40010FE
    public SkillBulletData skillBullet;

    // Token: 0x40010FF
    public List<SkillSpeEffectData> skillSpeEffects;

    // Token: 0x4001100
    public SkillDamageOrder skillDamageOrder;

    // Token: 0x4001101
    public bool autoHeroMove;

    // Token: 0x4001102
    public int trailID;

    // Token: 0x4001103
    public int maxAttackRange;

    // Token: 0x4001104
    public bool hide;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600125A
    // RVA   : 0xB7FA60   Offset: 0xB7E260   Length: 0x23
    public int GetDodgeRange()
    {
        int iVar1;
        iVar1 = Mathf.FloorToInt((float)this.rareLv * 0.5,0);
        return iVar1 + 2;
    }

    // Token : 0x600125B
    // RVA   : 0xB7F4B0   Offset: 0xB7DCB0   Length: 0x359
    public string GetAttackRangeDescribe()
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
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
          if ((lVar3 == null) || (lVar3 = FUN_180002f80(lVar3,iVar9,DAT_181d7afd8)) == null) break;
          if (lVar3._items == 4) {
            lVar3 = *(int64 *)(pStatics + 0x468);
            if (((this.attackRangeData == null) ||
                (lVar4 = FUN_180002f80(this.attackRangeData,iVar9,DAT_181d7afd8)) == null) ||
               (lVar3 == null)) break;
            uVar5 = FUN_180002f80(lVar3,lVar4._items,DAT_181d7c9c0);
          }
          else {
            lVar3 = *(int64 *)(pStatics + 0x468);
            if (((this.attackRangeData == null) ||
                (lVar4 = FUN_180002f80(this.attackRangeData,iVar9,DAT_181d7afd8)) == null) ||
               (lVar3 == null)) break;
            uVar5 = FUN_180002f80(lVar3,lVar4._items,DAT_181d7c9c0);
            if ((this.attackRangeData == null) ||
               (lVar3 = FUN_180002f80(this.attackRangeData,iVar9,DAT_181d7afd8)) == null)
            break;
            iVar1 = *(int *)(lVar3 + 20);
            if ((this.attackRangeData == null) ||
               (lVar3 = FUN_180002f80(this.attackRangeData,iVar9,DAT_181d7afd8),
               uVar2 = "{0}{1}格", lVar3 == null)) break;
            lVar4 = this.attackRangeData;
            if (iVar1 == lVar3.Count) {
              if ((lVar4 == null) || (lVar3 = FUN_180002f80(lVar4,iVar9,DAT_181d7afd8)) == null) break;
              uVar6 = Int32.ToString(lVar3 + 20,0);
            }
            else {
              if ((lVar4 == null) || (lVar3 = FUN_180002f80(lVar4,iVar9,DAT_181d7afd8)) == null) {
        LAB_180b7f804:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              local_res8[0] = *(uint32 *)(lVar3 + 20);
              uVar6 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
              if ((this.attackRangeData == null) ||
                 (lVar3 = FUN_180002f80(this.attackRangeData,iVar9,DAT_181d7afd8)) == null)
              goto LAB_180b7f804;
              local_res18[0] = lVar3.Count;
              uVar7 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
              uVar6 = String.Format("{0}~{1}",uVar6,uVar7,0);
            }
            uVar5 = String.Format(uVar2,uVar5,uVar6,0);
          }
          uVar8 = String.Concat(uVar8,uVar10,uVar5);
          iVar9 = iVar9 + 1;
          lVar3 = this.attackRangeData;
        }
    }

    // Token : 0x600125C
    // RVA   : 0xB7F830   Offset: 0xB7E030   Length: 0x228
    public string GetDamageRangeDescribe()
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
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
        if (lVar7 == null) goto LAB_180b7fa4d;
        if (lVar7.rangeType == 7) {
          if (((*(byte *)(DAT_181d4ef00 + 0x133) & 4) != 0) && (*(int *)(DAT_181d4ef00 + 224) == 0)) {
            il2cpp_runtime_class_init(DAT_181d4ef00);
            lVar7 = this.damageRangeData;
          }
          lVar3 = *(int64 *)(pStatics + 0x470);
          if ((lVar7 == null) || (lVar3 == null)) goto LAB_180b7fa4d;
          uVar1 = lVar7.rangeType;
          if (*(uint32 *)(lVar3 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar6 = lVar3[uVar1];
        }
        else {
          uVar8 = "";
          if (lVar7.maxRange != null) {
            if (((*(byte *)(DAT_181d4ef00 + 0x133) & 4) != 0) && (*(int *)(DAT_181d4ef00 + 224) == 0)) {
              il2cpp_runtime_class_init(DAT_181d4ef00);
              lVar7 = this.damageRangeData;
            }
            lVar3 = *(int64 *)(pStatics + 0x470);
            if ((lVar7 == null) || (lVar3 == null)) {
        LAB_180b7fa4d:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar1 = lVar7.rangeType;
            if (*(uint32 *)(lVar3 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              lVar7 = this.damageRangeData;
            }
            uVar8 = lVar3[uVar1];
            if (lVar7 == null) goto LAB_180b7fa4d;
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
            uVar4 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
            if (this.damageRangeData == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_res18[0] = this.damageRangeData.maxRange;
            uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
            uVar4 = String.Format("{0}~{1}",uVar4,uVar5,0);
          }
          uVar6 = String.Format(uVar6,uVar8,uVar4,0);
        }
        return uVar6;
    }

    // Token : 0x600125D
    // RVA   : 0xB7FB20   Offset: 0xB7E320   Length: 0x76
    public string GetSkillIcon()
    {
        ulong uVar1;
        uint[] local_res8 = new uint[8];
        if (this.summonSkill) {
          local_res8[0] = this.skillID;
          uVar1 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
          String.Format("summonskill{0}",uVar1,0);
          return;
        }
        Int32.ToString((uint32 *)(this + 20),0);
    }

    // Token : 0x600125E
    // RVA   : 0xB7F300   Offset: 0xB7DB00   Length: 0x26
    public float BadFame()
    {
        float fVar1;
        fVar1 = (float)FUN_1801f7f00(0x40000000);
        return fVar1 * 5.0;
    }

    // Token : 0x600125F
    // RVA   : 0xB7FCC0   Offset: 0xB7E4C0   Length: 0x8A
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

    // Token : 0x6001260
    // RVA   : 0xB7FD50   Offset: 0xB7E550   Length: 0x1F7
    public string TypeDescribe()
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        uint uVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        uVar4 = "江湖";
        if (this.belongForceID != -1) {
          lVar2 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
          if (((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 208)) == null) ||
             (lVar2 = FUN_1817cc780(lVar2,this.belongForceID,DAT_181d94178)) == null)
          throw; // [null/range check failed]
          uVar4 = *(uint64 *)(lVar2 + 24);
        }
        lVar2 = *(int64 *)(pStatics + 0x4f0);
        if (lVar2 != null) {
          uVar1 = this.rareLv;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar3 = lVar2[uVar1];
          lVar2 = *(int64 *)(pStatics + 0x498);
          if (lVar2 != null) {
            uVar1 = this.type;
            if (*(uint32 *)(lVar2 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar3 = String.Concat(uVar3,*(uint64 *)
                                          (*(int64 *)(lVar2 + 16) + 32 + (int64)(int)uVar1 * 8),
                                   0);
            uVar3 = GlobalData.GenerateRareLvColorText(uVar3,this.rareLv,0);
            String.Concat(uVar4,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x6001261
    // RVA   : 0xB7FB10   Offset: 0xB7E310   Length: 0x10
    public float GetRealUpgradeRatio(int targetLv)
    {
        float FUN_180b7fb10(uint64 this,int targetLv)
        {
        return (float)targetLv * 0.1;
    }

    // Token : 0x6001262
    // RVA   : 0xB7F810   Offset: 0xB7E010   Length: 0x1D
    public float GetBaseDamage(int targetLv)
    {
        float FUN_180b7f810(int64 this,int targetLv)
        {
        return ((float)targetLv * 0.1 + 1.0) * this.baseDamage;
    }

    // Token : 0x6001263
    // RVA   : 0xB7FA90   Offset: 0xB7E290   Length: 0x1D
    public float GetManaCost(int targetLv)
    {
        float FUN_180b7fa90(int64 this,int targetLv)
        {
        return ((float)targetLv * 0.1 + 1.0) * this.manaCost;
    }

    // Token : 0x6001264
    // RVA   : 0xB7FBA0   Offset: 0xB7E3A0   Length: 0x84
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

    // Token : 0x6001265
    // RVA   : 0xB7FC30   Offset: 0xB7E430   Length: 0x84
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

    // Token : 0x6001266
    // RVA   : 0xB7FAB0   Offset: 0xB7E2B0   Length: 0x5B
    public float GetMaxExp(int targetLv, int expType)
    {
        FUN_1801f7f00();
        Mathf.RoundToInt();
    }

    // Token : 0x6001267
    // RVA   : 0x21B010   Offset: 0x219810   Length: 0x8
    public PartPostureData GetAtkPartPosture(int targetLv)
    {
        uint64 FUN_18021b010(int64 this)
        {
        return this.atkPartPosture;
    }

    // Token : 0x6001268
    // RVA   : 0x21B0B0   Offset: 0x2198B0   Length: 0x8
    public PartPostureData GetDefPartPosture(int targetLv)
    {
        return this.defPartPosture;
    }

    // Token : 0x6001269
    // RVA   : 0xB7FF50   Offset: 0xB7E750   Length: 0xB7
    public void /*ctor*/()
    {
        ulong uVar1;
        this.summonID = 0xffffffff;
        ZhSegment.Initialize(this,0);
        this.addDamageRatio = new AttriNumData(0);
        uVar1 = il2cpp_internal(DAT_181d727b0);
        FUN_180f58a90(uVar1,DAT_181d7b2d8);
        this.skillSpeEffects = uVar1;
    }

    // Token : 0x600126A
    // RVA   : 0xB7F330   Offset: 0xB7DB30   Length: 0x175
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
