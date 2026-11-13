// ============================================================
// Type  : WeaponResearchData
// Token : 0x20001E1
// ============================================================

public class WeaponResearchData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000CC2
    public int lv;

    // Token: 0x4000CC3
    public float exp;

    // Token: 0x4000CC4
    public ItemData researchTarget;

    // Token: 0x4000CC5
    public HeroSpeAddData researchTargetBuff;

    // Token: 0x4000CC6
    public int leftTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000EDD
    // RVA   : 0x96D6D0   Offset: 0x96C4D0   Length: 0x65
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        this.researchTargetBuff = new HeroSpeAddData(0);
    }

    // Token : 0x6000EDE
    // RVA   : 0x96D650   Offset: 0x96C450   Length: 0x7D
    public void Reset()
    {
        ulong uVar1;
        this.lv = 0;
        this.researchTarget = 0;
        this.researchTargetBuff = new HeroSpeAddData(0);
        this.leftTime = 0;
    }

    // Token : 0x6000EDF
    // RVA   : 0x96D630   Offset: 0x96C430   Length: 0x1B
    public float GetMaxExp()
    {
        float FUN_18096d630(int64 this)
        {
        return (float)((this.lv + 2) * (this.lv + 1)) * 0.5;
    }

    // Token : 0x6000EE0
    // RVA   : 0x96D250   Offset: 0x96C050   Length: 0x3DA
    public void ChangeExp(float _exp)
    {
        var pStatics_38e8 = *(int64*)(DAT_181e538e8 + 184);
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
            lVar1 = **(int64 **)(DAT_181e5fa68 + 184);
            lVar2 = *(int64 *)(pStatics_38e8 + 0x4a8);
            if ((((GameController._instance == null) ||
                 (lVar4 = GameController._instance.worldData) == null) ||
                (lVar4 = WorldData.Player(lVar4,0)) == null) ||
               (iVar3 = HeroData.GetWeaponResearchWeaponType(lVar4,0), lVar2 == null)) {
        LAB_18096d625:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            uVar5 = FUN_1800024b0(lVar2,iVar3 + 3,DAT_181e86970);
            local_res10[0] = this.lv;
            uVar6 = il2cpp_value_box(DAT_181e60808,local_res10);
            uVar5 = String.Format("{0}兵器研究达到{1}级",uVar5,uVar6,0);
            lVar2 = *(int64 *)(pStatics_38e8 + 0x4a8);
            if (((GameController._instance == null) ||
                (lVar4 = GameController._instance.worldData) == null) ||
               ((lVar4 = WorldData.Player(lVar4,0), lVar4 == null ||
                ((iVar3 = HeroData.GetWeaponResearchWeaponType(lVar4,0), lVar2 == null ||
                 (uVar6 = FUN_1800024b0(lVar2,iVar3 + 3,DAT_181e86970), lVar1 == null))))))
            goto LAB_18096d625;
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
