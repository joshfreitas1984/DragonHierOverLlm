// ============================================================
// Type  : WeaponResearchData
// Token : 0x20001D9
// ============================================================

public class WeaponResearchData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C22
    public int lv;

    // Token: 0x4000C23
    public float exp;

    // Token: 0x4000C24
    public ItemData researchTarget;

    // Token: 0x4000C25
    public HeroSpeAddData researchTargetBuff;

    // Token: 0x4000C26
    public int leftTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000EA2
    // RVA   : 0x9DFE10   Offset: 0x9DE610   Length: 0x65
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        this.researchTargetBuff = new HeroSpeAddData(0);
    }

    // Token : 0x6000EA3
    // RVA   : 0x9DFD90   Offset: 0x9DE590   Length: 0x7D
    public void Reset()
    {
        ulong uVar1;
        this.lv = 0;
        this.researchTarget = 0;
        this.researchTargetBuff = new HeroSpeAddData(0);
        this.leftTime = 0;
    }

    // Token : 0x6000EA4
    // RVA   : 0x9DFD70   Offset: 0x9DE570   Length: 0x1B
    public float GetMaxExp()
    {
        float FUN_1809dfd70(int64 this)
        {
        return (float)((this.lv + 2) * (this.lv + 1)) * 0.5;
    }

    // Token : 0x6000EA5
    // RVA   : 0x9DF990   Offset: 0x9DE190   Length: 0x3DA
    public void ChangeExp(float _exp)
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        long lVar1;
        long lVar2;
        int iVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        uint[] local_res10 = new uint[2];
        ulong local_68;
        ulong uStack_60;
        iVar3 = this.lv;
        _exp = _exp + this.exp;
        this.exp = _exp;
        if ((float)((iVar3 + 2) * (iVar3 + 1)) * 0.5 <= _exp) {
          do {
            this.lv = iVar3 + 1;
            this.exp = _exp - (float)((iVar3 + 2) * (iVar3 + 1)) * 0.5;
            lVar1 = **(int64 **)(DAT_181d5a578 + 184);
            lVar2 = *(int64 *)(pStatics_ef00 + 0x498);
            if ((((*pStatics_df90 == 0) ||
                 (lVar4 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
                (lVar4 = WorldData.Player(lVar4,0)) == null) ||
               (iVar3 = HeroData.GetWeaponResearchWeaponType(lVar4,0), lVar2 == null)) {
        LAB_1809dfd65:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar5 = FUN_180002f80(lVar2,iVar3 + 3,DAT_181d7c9c0);
            local_res10[0] = this.lv;
            uVar6 = il2cpp_value_box(DAT_181d5b2f8,local_res10);
            uVar5 = String.Format("{0}兵器研究达到{1}级",uVar5,uVar6,0);
            lVar2 = *(int64 *)(pStatics_ef00 + 0x498);
            if (((*pStatics_df90 == 0) ||
                (lVar4 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
               ((lVar4 = WorldData.Player(lVar4,0), lVar4 == null ||
                ((iVar3 = HeroData.GetWeaponResearchWeaponType(lVar4,0), lVar2 == null ||
                 (uVar6 = FUN_180002f80(lVar2,iVar3 + 3,DAT_181d7c9c0), lVar1 == null))))))
            goto LAB_1809dfd65;
            local_68 = 0;
            uStack_60 = 0;
            InfoController.AddInfoTab
                      (lVar1,uVar5,"UIAtlas",uVar6,"LevelUpShort",0x3f800000,0x40a00000,&local_68,0);
            iVar3 = this.lv;
            _exp = this.exp;
          } while ((float)((iVar3 + 2) * (iVar3 + 1)) * 0.5 <= _exp);
        }
    }

}
