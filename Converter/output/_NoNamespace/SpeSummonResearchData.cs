// ============================================================
// Type  : SpeSummonResearchData
// Token : 0x20001DB
// ============================================================

public class SpeSummonResearchData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C33
    public List<int> lv;

    // Token: 0x4000C34
    public List<float> exp;

    // Token: 0x4000C35
    public List<ItemData> researchItem;

    // Token: 0x4000C36
    public List<HeroSpeAddData> researchAddData;

    // Token: 0x4000C37
    public List<int> researchLeftTime;

    // Token: 0x4000C38
    public static List<string> researchTypeName;

    // Token: 0x4000C39
    public static List<string> researchAddTypeName;

    // Token: 0x4000C3A
    public static List<HeroSpeAddDataType> researchAddType;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000EAE
    // RVA   : 0xC6DD50   Offset: 0xC6C550   Length: 0x33A
    public void /*ctor*/()
    {
        long lVar1;
        ulong uVar2;
        ZhSegment.Initialize(this,0);
        lVar1 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(lVar1,DAT_181d678f8);
        if (lVar1 != null) {
          FUN_181814fa0(lVar1,0,DAT_181d67a78);
          FUN_181814fa0(lVar1,0,DAT_181d67a78);
          FUN_181814fa0(lVar1,0,DAT_181d67a78);
          this.lv = lVar1;
          lVar1 = il2cpp_internal(DAT_181d721b0);
          FUN_180f58a90(lVar1,DAT_181d79358);
          if (lVar1 != null) {
            FUN_181805690(lVar1,0,DAT_181d79458);
            FUN_181805690(lVar1,0,DAT_181d79458);
            FUN_181805690(lVar1,0,DAT_181d79458);
            this.exp = lVar1;
            lVar1 = il2cpp_internal(DAT_181d6f430);
            FUN_180f58a90(lVar1,DAT_181d691f0);
            if (lVar1 != null) {
              FUN_181827900(lVar1,0,DAT_181d692f0);
              FUN_181827900(lVar1,0,DAT_181d692f0);
              FUN_181827900(lVar1,0,DAT_181d692f0);
              this.researchItem = lVar1;
              lVar1 = il2cpp_internal(DAT_181d6e730);
              FUN_180f58a90(lVar1,DAT_181d644f8);
              uVar2 = new HeroSpeAddData(0);
              if (lVar1 != null) {
                FUN_181827900(lVar1,uVar2,DAT_181d64578);
                uVar2 = new HeroSpeAddData(0);
                FUN_181827900(lVar1,uVar2,DAT_181d64578);
                uVar2 = new HeroSpeAddData(0);
                FUN_181827900(lVar1,uVar2,DAT_181d64578);
                this.researchAddData = lVar1;
                lVar1 = il2cpp_internal(DAT_181d6f030);
                FUN_180f58a90(lVar1,DAT_181d678f8);
                if (lVar1 != null) {
                  FUN_181814fa0(lVar1,0,DAT_181d67a78);
                  FUN_181814fa0(lVar1,0,DAT_181d67a78);
                  FUN_181814fa0(lVar1,0,DAT_181d67a78);
                  this.researchLeftTime = lVar1;
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000EAF
    // RVA   : 0xC6D7C0   Offset: 0xC6BFC0   Length: 0x330
    public void Reset()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(lVar1,DAT_181d678f8);
        if (lVar1 != null) {
          FUN_181814fa0(lVar1,0,DAT_181d67a78);
          FUN_181814fa0(lVar1,0,DAT_181d67a78);
          FUN_181814fa0(lVar1,0,DAT_181d67a78);
          this.lv = lVar1;
          lVar1 = il2cpp_internal(DAT_181d721b0);
          FUN_180f58a90(lVar1,DAT_181d79358);
          if (lVar1 != null) {
            FUN_181805690(lVar1,0,DAT_181d79458);
            FUN_181805690(lVar1,0,DAT_181d79458);
            FUN_181805690(lVar1,0,DAT_181d79458);
            this.exp = lVar1;
            lVar1 = il2cpp_internal(DAT_181d6f430);
            FUN_180f58a90(lVar1,DAT_181d691f0);
            if (lVar1 != null) {
              FUN_181827900(lVar1,0,DAT_181d692f0);
              FUN_181827900(lVar1,0,DAT_181d692f0);
              FUN_181827900(lVar1,0,DAT_181d692f0);
              this.researchItem = lVar1;
              lVar1 = il2cpp_internal(DAT_181d6e730);
              FUN_180f58a90(lVar1,DAT_181d644f8);
              uVar2 = new HeroSpeAddData(0);
              if (lVar1 != null) {
                FUN_181827900(lVar1,uVar2,DAT_181d64578);
                uVar2 = new HeroSpeAddData(0);
                FUN_181827900(lVar1,uVar2,DAT_181d64578);
                uVar2 = new HeroSpeAddData(0);
                FUN_181827900(lVar1,uVar2,DAT_181d64578);
                this.researchAddData = lVar1;
                lVar1 = il2cpp_internal(DAT_181d6f030);
                FUN_180f58a90(lVar1,DAT_181d678f8);
                if (lVar1 != null) {
                  FUN_181814fa0(lVar1,0,DAT_181d67a78);
                  FUN_181814fa0(lVar1,0,DAT_181d67a78);
                  FUN_181814fa0(lVar1,0,DAT_181d67a78);
                  this.researchLeftTime = lVar1;
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000EB0
    // RVA   : 0xC6D710   Offset: 0xC6BF10   Length: 0xA4
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

    // Token : 0x6000EB1
    // RVA   : 0xC6D6E0   Offset: 0xC6BEE0   Length: 0x29
    public float GetItemExpNum(ItemData targetItem)
    {
        uint64 FUN_180c6d6e0(uint64 this,int64 targetItem)
        {
        uint64 uVar1;
        if (targetItem == null) {
          return 0;
        }
        uVar1 = Mathf.Max(0x3f800000,(float)*(int *)(targetItem + 56) * 0.5,0);
        return uVar1;
    }

    // Token : 0x6000EB2
    // RVA   : 0xC6D110   Offset: 0xC6B910   Length: 0x5C8
    public void ChangeExp(int id, float _exp, bool showInfo)
    {
        var pStatics_a578 = *(int64*)(DAT_181d5a578 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_f330 = *(int64*)(DAT_181d7f330 + 184);
        float fVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar6;
        long lVar7;
        float fVar8;
        uint[] local_res10 = new uint[2];
        float[] local_res18 = new float[2];
        ulong local_68;
        ulong uStack_60;
        lVar7 = (int64)(int)id;
        local_res18[0] = _exp;
        lVar3 = this.exp;
        if (lVar3 == null) throw; // [null/range check failed]
        if (lVar3.Count <= id) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        FUN_181814d10(lVar3,id,
                      local_res18[0] + *(float *)(lVar3._items + 32 + lVar7 * 4),
                      DAT_181d79758);
        if (showInfo) {
          lVar3 = *pStatics_a578;
          lVar6 = *pStatics_f330;
          if (lVar6 == null) throw; // [null/range check failed]
          if (*(uint32 *)(lVar6 + 24) <= id) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar5 = *(uint64 *)(*(int64 *)(lVar6 + 16) + 32 + lVar7 * 8);
          uVar4 = Single.ToString(local_res18,"+0;-0;0",0);
          uVar5 = String.Format("机关{0}经验{1}",uVar5,uVar4,0);
          if (((*pStatics_df90 == 0) ||
              (lVar6 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
             (lVar6 = WorldData.Player(lVar6,0)) == null) throw; // [null/range check failed]
          uVar2 = *(uint32 *)(lVar6 + 132);
          uVar4 = GlobalData.GetForceIconName(uVar2,0);
          if (lVar3 == null) throw; // [null/range check failed]
          local_68 = 0;
          uStack_60 = 0;
          InfoController.AddInfoTab
                    (lVar3,uVar5,"UIAtlas",uVar4,"NoticeLittleLittle",0x3f800000,0x40a00000,&local_68,0);
        }
        lVar3 = this.exp;
        while (lVar3 != null) {
          if (lVar3.Count <= id) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          fVar1 = *(float *)(lVar3._items + 32 + lVar7 * 4);
          fVar8 = (float)SpeSummonResearchData.GetMaxExp(this,id,0);
          if (fVar1 < fVar8) {
            return;
          }
          lVar3 = this.exp;
          if (lVar3 == null) {
        LAB_180c6d6d3:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (lVar3.Count <= id) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          fVar1 = *(float *)(lVar3._items + 32 + lVar7 * 4);
          fVar8 = (float)SpeSummonResearchData.GetMaxExp(this,id,0);
          FUN_181814d10(lVar3,id,fVar1 - fVar8,DAT_181d79758);
          lVar3 = this.lv;
          if (lVar3 == null) goto LAB_180c6d6d3;
          if (lVar3.Count <= id) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          FUN_18181e970(lVar3,id,*(int *)(lVar3._items + 32 + lVar7 * 4) + 1,
                        DAT_181d68370);
          lVar3 = *pStatics_a578;
          if (*pStatics_f330 == 0) goto LAB_180c6d6d3;
          uVar5 = FUN_180002f80(*pStatics_f330,id,DAT_181d7c9c0);
          if (this.lv == null) goto LAB_180c6d6d3;
          local_res10[0] = FUN_1800d6750(this.lv,id,DAT_181d68270);
          uVar4 = il2cpp_value_box(DAT_181d5b2f8,local_res10);
          uVar5 = String.Format("机关{0}达到{1}级",uVar5,uVar4,0);
          lVar6 = FUN_18046c0a0(0);
          if (((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
             (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) == null) goto LAB_180c6d6d3;
          uVar2 = *(uint32 *)(lVar6 + 132);
          uVar4 = GlobalData.GetForceIconName(uVar2,0);
          if (lVar3 == null) goto LAB_180c6d6d3;
          local_68 = 0;
          uStack_60 = 0;
          InfoController.AddInfoTab
                    (lVar3,uVar5,"UIAtlas",uVar4,"LevelUpShort",0x3f800000,0x40a00000,&local_68,0);
          lVar3 = this.exp;
        }
    }

    // Token : 0x6000EB3
    // RVA   : 0xC6DB00   Offset: 0xC6C300   Length: 0x244
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d7f330 + 184);
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar1,DAT_181d7c250);
        if (lVar1 != null) {
          FUN_181827900(lVar1,"头部",DAT_181d7c3d0);
          FUN_181827900(lVar1,"装甲",DAT_181d7c3d0);
          FUN_181827900(lVar1,"腿足",DAT_181d7c3d0);
          plVar2 = pStatics;
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          lVar1 = il2cpp_internal(DAT_181d72a30);
          FUN_180f58a90(lVar1,DAT_181d7c250);
          if (lVar1 != null) {
            FUN_181827900(lVar1,"机关伤害",DAT_181d7c3d0);
            FUN_181827900(lVar1,"机关耐久",DAT_181d7c3d0);
            FUN_181827900(lVar1,"机关速度",DAT_181d7c3d0);
            plVar2 = (int64 *)(pStatics + 8);
            *plVar2 = lVar1;
            il2cpp_internal(plVar2,lVar1);
            lVar1 = il2cpp_internal(DAT_181d6e7b0);
            FUN_180f58a90(lVar1,DAT_181d648f8);
            if (lVar1 != null) {
              FUN_181814fa0(lVar1,208,DAT_181d64978);
              FUN_181814fa0(lVar1,210,DAT_181d64978);
              FUN_181814fa0(lVar1,209,DAT_181d64978);
              plVar2 = (int64 *)(pStatics + 16);
              *plVar2 = lVar1;
              il2cpp_internal(plVar2,lVar1);
              return;
            }
          }
        }
    }

}
