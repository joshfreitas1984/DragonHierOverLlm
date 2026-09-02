// ============================================================
// Type  : HeroTagDataBase
// Token : 0x2000232
// ============================================================

public class HeroTagDataBase
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400111E
    public int id;

    // Token: 0x400111F
    public string name;

    // Token: 0x4001120
    public int value;

    // Token: 0x4001121
    public SkillTargetType effectTarget;

    // Token: 0x4001122
    public string sameMeaning;

    // Token: 0x4001123
    public string oppositeMeaning;

    // Token: 0x4001124
    public bool canRandom;

    // Token: 0x4001125
    public List<string> requirement;

    // Token: 0x4001126
    public List<string> replaceTag;

    // Token: 0x4001127
    public string category;

    // Token: 0x4001128
    public HeroSpeAddData buffData;

    // Token: 0x4001129
    public bool showRightLine;

    // Token: 0x400112A
    public int order;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001275
    // RVA   : 0xB3CE70   Offset: 0xB3B670   Length: 0xA3
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        uVar1 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(uVar1,DAT_181d7c250);
        this.requirement = uVar1;
        uVar1 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(uVar1,DAT_181d7c250);
        this.replaceTag = uVar1;
    }

    // Token : 0x6001276
    // RVA   : 0xB3CD40   Offset: 0xB3B540   Length: 0x125
    public string Name()
    {
        ulong uVar1;
        long lVar2;
        uint uVar3;
        uVar1 = this.name;
        uVar3 = Mathf.Abs(this.value,0);
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
        if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 56)) != null) {
          uVar3 = Mathf.Clamp(uVar3,0,*(int *)(lVar2 + 24) + -1,0);
          GlobalData.GenerateRareLvColorText(uVar1,uVar3,0);
          return;
        }
    }

    // Token : 0x6001277
    // RVA   : 0xB3CC40   Offset: 0xB3B440   Length: 0xF4
    public string GetDescribe(bool showEffectTarget)
    {
        int iVar1;
        ulong uVar2;
        ulong uVar3;
        uVar2 = "";
        if ((showEffectTarget) &&
           (((iVar1 = this.effectTarget, uVar3 = "战时敌方全体:\n", iVar1 == 0 ||
             (uVar3 = "战时我方全体:\n", iVar1 == 1)) || ((iVar1 != 2 && (uVar3 = "战时我方队友:\n", iVar1 == 3)))
            ))) {
          uVar2 = String.Concat("",uVar3,0);
        }
        if (this.buffData == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        uVar3 = HeroSpeAddData.GetDescribe(this.buffData,0,999999,1,1,1,1,0);
        String.Concat(uVar2,uVar3,0);
    }

    // Token : 0x6001278
    // RVA   : 0xB3CC10   Offset: 0xB3B410   Length: 0x2D
    public float GetCostValue(bool startCost)
    {
        if (this.value < 0) {
          return;
        }
    }

    // Token : 0x6001279
    // RVA   : 0xB3CBD0   Offset: 0xB3B3D0   Length: 0x3E
    public int GetCostTime()
    {
        int iVar1;
        uint uVar2;
        iVar1 = this.value;
        if (iVar1 < 0) {
          iVar1 = -iVar1;
        }
        else {
          iVar1 = iVar1 * 4;
        }
        uVar2 = Mathf.RoundToInt((float)iVar1 * 0.25,0);
        Mathf.Max(1,uVar2);
    }

    // Token : 0x600127A
    // RVA   : 0xB3CB80   Offset: 0xB3B380   Length: 0x42
    public int GetCostMoney()
    {
        int iVar1;
        uint uVar2;
        iVar1 = this.value;
        if (iVar1 < 0) {
          iVar1 = -iVar1;
        }
        else {
          iVar1 = iVar1 * 4;
        }
        uVar2 = Mathf.RoundToInt((float)iVar1 * 0.25,0);
        iVar1 = Mathf.Max(1,uVar2);
        return iVar1 * 50;
    }

    // Token : 0x600127B
    // RVA   : 0xB3CA00   Offset: 0xB3B200   Length: 0x175
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
