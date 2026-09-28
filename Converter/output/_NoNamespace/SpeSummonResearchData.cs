// ============================================================
// Type  : SpeSummonResearchData
// Token : 0x20001E1
// ============================================================

public class SpeSummonResearchData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000CC0
    public List<int> lv;

    // Token: 0x4000CC1
    public List<float> exp;

    // Token: 0x4000CC2
    public List<ItemData> researchItem;

    // Token: 0x4000CC3
    public List<HeroSpeAddData> researchAddData;

    // Token: 0x4000CC4
    public List<int> researchLeftTime;

    // Token: 0x4000CC5
    public static List<string> researchTypeName;

    // Token: 0x4000CC6
    public static List<string> researchAddTypeName;

    // Token: 0x4000CC7
    public static List<HeroSpeAddDataType> researchAddType;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000EE3
    // RVA   : 0xC5D370   Offset: 0xC5C770   Length: 0x33A
    public void /*ctor*/()
    {
        long lVar1;
        ulong uVar2;
        ZhSegment.Initialize(this,0);
        lVar1 = il2cpp_internal(DAT_181d93cd0);
        FUN_18132faf0(lVar1,DAT_181d8f098);
        if (lVar1 != null) {
          FUN_18182a0b0(lVar1,0,DAT_181d8f218);
          FUN_18182a0b0(lVar1,0,DAT_181d8f218);
          FUN_18182a0b0(lVar1,0,DAT_181d8f218);
          this.lv = lVar1;
          lVar1 = il2cpp_internal(DAT_181d96ed0);
          FUN_18132faf0(lVar1,DAT_181da0cf8);
          if (lVar1 != null) {
            FUN_18181de10(lVar1,0,DAT_181da0df8);
            FUN_18181de10(lVar1,0,DAT_181da0df8);
            FUN_18181de10(lVar1,0,DAT_181da0df8);
            this.exp = lVar1;
            lVar1 = il2cpp_internal(DAT_181d940d0);
            FUN_18132faf0(lVar1,DAT_181d90998);
            if (lVar1 != null) {
              FUN_18181e0a0(lVar1,0,DAT_181d90a98);
              FUN_18181e0a0(lVar1,0,DAT_181d90a98);
              FUN_18181e0a0(lVar1,0,DAT_181d90a98);
              this.researchItem = lVar1;
              lVar1 = il2cpp_internal(DAT_181d933d0);
              FUN_18132faf0(lVar1,DAT_181d8bc98);
              uVar2 = new HeroSpeAddData(0);
              if (lVar1 != null) {
                FUN_18181e0a0(lVar1,uVar2,DAT_181d8bd18);
                uVar2 = new HeroSpeAddData(0);
                FUN_18181e0a0(lVar1,uVar2,DAT_181d8bd18);
                uVar2 = new HeroSpeAddData(0);
                FUN_18181e0a0(lVar1,uVar2,DAT_181d8bd18);
                this.researchAddData = lVar1;
                lVar1 = il2cpp_internal(DAT_181d93cd0);
                FUN_18132faf0(lVar1,DAT_181d8f098);
                if (lVar1 != null) {
                  FUN_18182a0b0(lVar1,0,DAT_181d8f218);
                  FUN_18182a0b0(lVar1,0,DAT_181d8f218);
                  FUN_18182a0b0(lVar1,0,DAT_181d8f218);
                  this.researchLeftTime = lVar1;
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000EE4
    // RVA   : 0xC5CDE0   Offset: 0xC5C1E0   Length: 0x330
    public void Reset()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = il2cpp_internal(DAT_181d93cd0);
        FUN_18132faf0(lVar1,DAT_181d8f098);
        if (lVar1 != null) {
          FUN_18182a0b0(lVar1,0,DAT_181d8f218);
          FUN_18182a0b0(lVar1,0,DAT_181d8f218);
          FUN_18182a0b0(lVar1,0,DAT_181d8f218);
          this.lv = lVar1;
          lVar1 = il2cpp_internal(DAT_181d96ed0);
          FUN_18132faf0(lVar1,DAT_181da0cf8);
          if (lVar1 != null) {
            FUN_18181de10(lVar1,0,DAT_181da0df8);
            FUN_18181de10(lVar1,0,DAT_181da0df8);
            FUN_18181de10(lVar1,0,DAT_181da0df8);
            this.exp = lVar1;
            lVar1 = il2cpp_internal(DAT_181d940d0);
            FUN_18132faf0(lVar1,DAT_181d90998);
            if (lVar1 != null) {
              FUN_18181e0a0(lVar1,0,DAT_181d90a98);
              FUN_18181e0a0(lVar1,0,DAT_181d90a98);
              FUN_18181e0a0(lVar1,0,DAT_181d90a98);
              this.researchItem = lVar1;
              lVar1 = il2cpp_internal(DAT_181d933d0);
              FUN_18132faf0(lVar1,DAT_181d8bc98);
              uVar2 = new HeroSpeAddData(0);
              if (lVar1 != null) {
                FUN_18181e0a0(lVar1,uVar2,DAT_181d8bd18);
                uVar2 = new HeroSpeAddData(0);
                FUN_18181e0a0(lVar1,uVar2,DAT_181d8bd18);
                uVar2 = new HeroSpeAddData(0);
                FUN_18181e0a0(lVar1,uVar2,DAT_181d8bd18);
                this.researchAddData = lVar1;
                lVar1 = il2cpp_internal(DAT_181d93cd0);
                FUN_18132faf0(lVar1,DAT_181d8f098);
                if (lVar1 != null) {
                  FUN_18182a0b0(lVar1,0,DAT_181d8f218);
                  FUN_18182a0b0(lVar1,0,DAT_181d8f218);
                  FUN_18182a0b0(lVar1,0,DAT_181d8f218);
                  this.researchLeftTime = lVar1;
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000EE5
    // RVA   : 0xC5CD30   Offset: 0xC5C130   Length: 0xA4
    public float GetMaxExp(int id)
    {
        int iVar1;
        long lVar2;
        long lVar3;
        lVar2 = this.lv;
        if (lVar2 != null) {
          lVar3 = lVar2;
          if (lVar2.Count <= id) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
            lVar3 = this.lv;
          }
          iVar1 = lVar2._items[id];
          if (lVar3 != null) {
            if (lVar3.Count <= id) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            return (float)((lVar3._items[id] + 1)
                          * (iVar1 + 2)) * 50.0;
          }
        }
    }

    // Token : 0x6000EE6
    // RVA   : 0xC5CD00   Offset: 0xC5C100   Length: 0x29
    public float GetItemExpNum(ItemData targetItem)
    {
        uint64 FUN_180c5cd00(uint64 this,int64 targetItem)
        {
        uint64 uVar1;
        if (targetItem == null) {
          return 0;
        }
        uVar1 = Mathf.Max(0x3f800000,(float)*(int *)(targetItem + 56) * 0.5,0);
        return uVar1;
    }

    // Token : 0x6000EE7
    // RVA   : 0xC5C770   Offset: 0xC5BB70   Length: 0x58B
    public void ChangeExp(int id, float _exp, bool showInfo)
    {
        var pStatics_f6a8 = *(int64*)(DAT_181d7f6a8 + 184);
        float fVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        float fVar7;
        uint[] local_res10 = new uint[2];
        float[] local_res18 = new float[4];
        ulong local_68;
        ulong uStack_60;
        lVar6 = (int64)(int)id;
        local_res18[0] = _exp;
        lVar2 = this.exp;
        if (lVar2 == null) throw; // [null/range check failed]
        if (lVar2.Count <= id) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        FUN_181829d40(lVar2,id,
                      local_res18[0] + *(float *)(lVar2._items + 32 + lVar6 * 4),
                      DAT_181da10f8);
        if (showInfo) {
          lVar2 = *pStatics_f6a8;
          lVar5 = GameController._instance;
          if (lVar5 == null) throw; // [null/range check failed]
          if (lVar5.cityAreaID <= id) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar4 = *(uint64 *)(lVar5.chapter + 32 + lVar6 * 8);
          uVar3 = Single.ToString(local_res18,"+0;-0;0",0);
          uVar4 = String.Format("机关{0}经验{1}",uVar4,uVar3,0);
          if ((((GameController._instance == null) ||
               (lVar5 = GameController._instance.worldData) == null) ||
              (lVar5 = WorldData.Player(lVar5,0)) == null) ||
             ((lVar5 = HeroData.GetForce(lVar5,0,0), lVar5 == null ||
              (uVar3 = ForceData.GetForceIconName(lVar5,0), lVar2 == null)))) throw; // [null/range check failed]
          local_68 = 0;
          uStack_60 = 0;
          InfoController.AddInfoTab
                    (lVar2,uVar4,"UIAtlas",uVar3,"NoticeLittleLittle",0x3f800000,0x40a00000,&local_68,0);
        }
        lVar2 = this.exp;
        while (lVar2 != null) {
          if (lVar2.Count <= id) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          fVar1 = *(float *)(lVar2._items + 32 + lVar6 * 4);
          fVar7 = (float)SpeSummonResearchData.GetMaxExp(this,id,0);
          if (fVar1 < fVar7) {
            return;
          }
          lVar2 = this.exp;
          if (lVar2 == null) {
        LAB_180c5ccf6:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (lVar2.Count <= id) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          fVar1 = *(float *)(lVar2._items + 32 + lVar6 * 4);
          fVar7 = (float)SpeSummonResearchData.GetMaxExp(this,id,0);
          FUN_181829d40(lVar2,id,fVar1 - fVar7,DAT_181da10f8);
          lVar2 = this.lv;
          if (lVar2 == null) goto LAB_180c5ccf6;
          if (lVar2.Count <= id) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          FUN_181833d40(lVar2,id,*(int *)(lVar2._items + 32 + lVar6 * 4) + 1,
                        DAT_181d8fb18);
          lVar2 = *pStatics_f6a8;
          if (GameController._instance == null) goto LAB_180c5ccf6;
          uVar4 = FUN_180002f80(GameController._instance,id,DAT_181da4358);
          if (this.lv == null) goto LAB_180c5ccf6;
          local_res10[0] = FUN_1800d6760(this.lv,id,DAT_181d8fa18);
          uVar3 = il2cpp_value_box(DAT_181d80418,local_res10);
          uVar4 = String.Format("机关{0}达到{1}级",uVar4,uVar3,0);
          lVar5 = FUN_18046c0a0(0);
          if ((((lVar5 == null) || (lVar5.villageAreaID == null)) ||
              (lVar5 = WorldData.Player(lVar5.villageAreaID,0)) == null) ||
             ((lVar5 = HeroData.GetForce(lVar5,0,0), lVar5 == null ||
              (uVar3 = ForceData.GetForceIconName(lVar5,0), lVar2 == null)))) goto LAB_180c5ccf6;
          local_68 = 0;
          uStack_60 = 0;
          InfoController.AddInfoTab
                    (lVar2,uVar4,"UIAtlas",uVar3,"LevelUpShort",0x3f800000,0x40a00000,&local_68,0);
          lVar2 = this.exp;
        }
    }

    // Token : 0x6000EE8
    // RVA   : 0xC5D120   Offset: 0xC5C520   Length: 0x244
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181da4550 + 184);
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d97750);
        FUN_18132faf0(lVar1,DAT_181da3bd8);
        if (lVar1 != null) {
          FUN_18181e0a0(lVar1,"头部",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"装甲",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"腿足",DAT_181da3d58);
          plVar2 = pStatics;
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          lVar1 = il2cpp_internal(DAT_181d97750);
          FUN_18132faf0(lVar1,DAT_181da3bd8);
          if (lVar1 != null) {
            FUN_18181e0a0(lVar1,"机关伤害",DAT_181da3d58);
            FUN_18181e0a0(lVar1,"机关耐久",DAT_181da3d58);
            FUN_18181e0a0(lVar1,"机关速度",DAT_181da3d58);
            GameController.difficultyExtraPoint = lVar1;
            lVar1 = il2cpp_internal(DAT_181d93450);
            FUN_18132faf0(lVar1,DAT_181d8c098);
            if (lVar1 != null) {
              FUN_18182a0b0(lVar1,208,DAT_181d8c118);
              FUN_18182a0b0(lVar1,210,DAT_181d8c118);
              FUN_18182a0b0(lVar1,209,DAT_181d8c118);
              GameController.CheckShowSpeHero = lVar1;
              return;
            }
          }
        }
    }

}
