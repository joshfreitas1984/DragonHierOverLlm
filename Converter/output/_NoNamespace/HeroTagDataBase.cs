// ============================================================
// Type  : HeroTagDataBase
// Token : 0x2000238
// ============================================================

public class HeroTagDataBase
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40011C1
    public int id;

    // Token: 0x40011C2
    public string name;

    // Token: 0x40011C3
    public int value;

    // Token: 0x40011C4
    public SkillTargetType effectTarget;

    // Token: 0x40011C5
    public string sameMeaning;

    // Token: 0x40011C6
    public string oppositeMeaning;

    // Token: 0x40011C7
    public bool canRandom;

    // Token: 0x40011C8
    public List<string> requirement;

    // Token: 0x40011C9
    public List<string> replaceTag;

    // Token: 0x40011CA
    public string category;

    // Token: 0x40011CB
    public HeroSpeAddData buffData;

    // Token: 0x40011CC
    public bool showRightLine;

    // Token: 0x40011CD
    public int order;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60012B6
    // RVA   : 0xAFE490   Offset: 0xAFD890   Length: 0xA3
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        uVar1 = il2cpp_internal(DAT_181d97768);
        FUN_181330100(uVar1,DAT_181da3bf0);
        this.requirement = uVar1;
        uVar1 = il2cpp_internal(DAT_181d97768);
        FUN_181330100(uVar1,DAT_181da3bf0);
        this.replaceTag = uVar1;
    }

    // Token : 0x60012B7
    // RVA   : 0xAFE360   Offset: 0xAFD760   Length: 0x125
    public string Name()
    {
        ulong uVar1;
        long lVar2;
        uint uVar3;
        uVar1 = this.name;
        uVar3 = Mathf.Abs(this.value,0);
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
        if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 56)) != null) {
          uVar3 = Mathf.Clamp(uVar3,0,*(int *)(lVar2 + 24) + -1,0);
          GlobalData.GenerateRareLvColorText(uVar1,uVar3,0);
          return;
        }
    }

    // Token : 0x60012B8
    // RVA   : 0xAFE260   Offset: 0xAFD660   Length: 0xF4
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

    // Token : 0x60012B9
    // RVA   : 0xAFE230   Offset: 0xAFD630   Length: 0x2D
    public float GetCostValue(bool startCost)
    {
        if (this.value < 0) {
          return;
        }
    }

    // Token : 0x60012BA
    // RVA   : 0xAFE1F0   Offset: 0xAFD5F0   Length: 0x3E
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

    // Token : 0x60012BB
    // RVA   : 0xAFE1A0   Offset: 0xAFD5A0   Length: 0x42
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

    // Token : 0x60012BC
    // RVA   : 0xAFE020   Offset: 0xAFD420   Length: 0x175
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
        plVar1 = (int64 *)il2cpp_internal(DAT_181d89228);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181db1748);
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
            FUN_180002970(0,DAT_181d78db8,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

}
