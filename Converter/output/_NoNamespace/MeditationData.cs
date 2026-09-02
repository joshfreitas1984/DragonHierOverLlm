// ============================================================
// Type  : MeditationData
// Token : 0x20001DA
// ============================================================

public class MeditationData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C27
    public int lv;

    // Token: 0x4000C28
    public float exp;

    // Token: 0x4000C29
    public int monthMeditationDay;

    // Token: 0x4000C2A
    public ItemData meditationTreasure;

    // Token: 0x4000C2B
    public HeroSpeAddData treasureAddData;

    // Token: 0x4000C2C
    public int treasureLeftTime;

    // Token: 0x4000C2D
    public ItemData meditationFood;

    // Token: 0x4000C2E
    public HeroSpeAddData foodAddData;

    // Token: 0x4000C2F
    public int foodLeftTime;

    // Token: 0x4000C30
    public ItemData meditationMed;

    // Token: 0x4000C31
    public HeroSpeAddData medAddData;

    // Token: 0x4000C32
    public int medLeftTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000EA6
    // RVA   : 0xA8F460   Offset: 0xA8DC60   Length: 0xB5
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        this.treasureAddData = new HeroSpeAddData(0);
        this.foodAddData = new HeroSpeAddData(0);
        this.medAddData = new HeroSpeAddData(0);
    }

    // Token : 0x6000EA7
    // RVA   : 0xA8F360   Offset: 0xA8DB60   Length: 0xF1
    public void Reset()
    {
        ulong uVar1;
        this.lv = 0;
        this.monthMeditationDay = 0;
        this.treasureLeftTime = 0;
        this.meditationTreasure = 0;
        this.treasureAddData = new HeroSpeAddData(0);
        this.meditationFood = 0;
        this.foodLeftTime = 0;
        this.foodAddData = new HeroSpeAddData(0);
        this.meditationMed = 0;
        this.medLeftTime = 0;
        this.medAddData = new HeroSpeAddData(0);
    }

    // Token : 0x6000EA8
    // RVA   : 0xA8F0C0   Offset: 0xA8D8C0   Length: 0x1B
    public float GetMaxExp()
    {
        float FUN_180a8f0c0(int64 this)
        {
        return (float)((this.lv + 2) * (this.lv + 1)) * 50.0;
    }

    // Token : 0x6000EA9
    // RVA   : 0xA8F0E0   Offset: 0xA8D8E0   Length: 0xEB
    public float MeditationExpNum()
    {
        float fVar1;
        float fVar2;
        float fVar3;
        fVar2 = 0.0;
        if (this.treasureLeftTime < 1) {
          fVar3 = 0.0;
        }
        else if (this.meditationTreasure == null) {
          fVar3 = 0.0;
        }
        else {
          fVar3 = (float)Mathf.Max(0x3f800000,
                                    (float)this.meditationTreasure.value * 0.01,0);
        }
        if (this.foodLeftTime < 1) {
          fVar1 = 0.0;
        }
        else if (this.meditationFood == null) {
          fVar1 = 0.0;
        }
        else {
          fVar1 = (float)Mathf.Max(0x3f800000,
                                    (float)this.meditationFood.value * 0.01,0);
        }
        if ((0 < this.medLeftTime) && (this.meditationMed != null)) {
          fVar2 = (float)Mathf.Max(0x3f800000,
                                    (float)this.meditationMed.value * 0.01,0);
        }
        return fVar1 + fVar3 + fVar2;
    }

    // Token : 0x6000EAA
    // RVA   : 0xA8F1D0   Offset: 0xA8D9D0   Length: 0x181
    public float MeditationExpRate()
    {
        float fVar1;
        if ((0 < this.treasureLeftTime) && (this.meditationTreasure != null)) {
          fVar1 = (float)this.meditationTreasure.value;
          Mathf.Log((fVar1 + fVar1) * 0.01,0x40000000,0);
          Mathf.Max();
        }
        if ((0 < this.foodLeftTime) && (this.meditationFood != null)) {
          fVar1 = (float)this.meditationFood.value;
          Mathf.Log((fVar1 + fVar1) * 0.01,0x40000000,0);
          Mathf.Max();
        }
        if ((0 < this.medLeftTime) && (this.meditationMed != null)) {
          fVar1 = (float)this.meditationMed.value;
          Mathf.Log((fVar1 + fVar1) * 0.01,0x40000000,0);
          Mathf.Max();
        }
        Mathf.Max();
    }

    // Token : 0x6000EAB
    // RVA   : 0xA8F030   Offset: 0xA8D830   Length: 0x29
    public float GetItemExpNum(ItemData targetItem)
    {
        uint64 FUN_180a8f030(uint64 this,int64 targetItem)
        {
        uint64 uVar1;
        if (targetItem == null) {
          return 0;
        }
        uVar1 = Mathf.Max(0x3f800000,(float)*(int *)(targetItem + 56) * 0.01,0);
        return uVar1;
    }

    // Token : 0x6000EAC
    // RVA   : 0xA8F060   Offset: 0xA8D860   Length: 0x54
    public float GetItemExpRate(ItemData targetItem)
    {
        if (targetItem == null) {
          return;
        }
        Mathf.Log(((float)*(int *)(targetItem + 56) + (float)*(int *)(targetItem + 56)) * 0.01,0x40000000,0
                  );
        Mathf.Max();
    }

    // Token : 0x6000EAD
    // RVA   : 0xA8EAE0   Offset: 0xA8D2E0   Length: 0x544
    public void ChangeExp(float _exp, bool showInfo)
    {
        var pStatics_a578 = *(int64*)(DAT_181d5a578 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        uint uVar1;
        int iVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        float fVar7;
        float[] local_res10 = new float[2];
        uint[] local_res18 = new uint[2];
        ulong local_58;
        ulong uStack_50;
        local_res10[0] = _exp;
        fVar7 = local_res10[0] + this.exp;
        this.exp = fVar7;
        if (!showInfo) {
        LAB_180a8edb8:
          iVar2 = this.lv;
          if ((float)((iVar2 + 2) * (iVar2 + 1)) * 50.0 <= fVar7) {
            do {
              this.lv = iVar2 + 1;
              this.exp = fVar7 - (float)((iVar2 + 2) * (iVar2 + 1)) * 50.0;
              lVar3 = *pStatics_a578;
              if (((*pStatics_df90 == 0) ||
                  (lVar4 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
                 (lVar4 = WorldData.Player(lVar4,0)) == null) {
        LAB_180a8f019:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar5 = HeroData.GetMeditationTopic(lVar4,0);
              local_res18[0] = this.lv;
              uVar6 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
              uVar5 = String.Format("{0}修行达到{1}级",uVar5,uVar6,0);
              lVar4 = FUN_18046c0a0(0);
              if (((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) ||
                 (lVar4 = WorldData.Player(*(int64 *)(lVar4 + 32),0)) == null)
              goto LAB_180a8f019;
              uVar1 = *(uint32 *)(lVar4 + 132);
              uVar6 = GlobalData.GetForceIconName(uVar1,0);
              if (lVar3 == null) goto LAB_180a8f019;
              local_58 = 0;
              uStack_50 = 0;
              InfoController.AddInfoTab
                        (lVar3,uVar5,"UIAtlas",uVar6,"LevelUpShort",0x3f800000,0x40a00000,&local_58,0);
              iVar2 = this.lv;
              fVar7 = this.exp;
            } while ((float)((iVar2 + 2) * (iVar2 + 1)) * 50.0 <= fVar7);
          }
          return;
        }
        lVar3 = *pStatics_a578;
        if (((*pStatics_df90 != 0) &&
            (lVar4 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
           (lVar4 = WorldData.Player(lVar4,0)) != null) {
          uVar5 = HeroData.GetMeditationTopic(lVar4,0);
          uVar6 = Single.ToString(local_res10,"+0;-0;0",0);
          uVar5 = String.Format("{0}修行经验{1}",uVar5,uVar6,0);
          if (((*pStatics_df90 != 0) &&
              (lVar4 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
             (lVar4 = WorldData.Player(lVar4,0)) != null) {
            uVar1 = *(uint32 *)(lVar4 + 132);
            uVar6 = GlobalData.GetForceIconName(uVar1,0);
            if (lVar3 != null) {
              local_58 = 0;
              uStack_50 = 0;
              InfoController.AddInfoTab
                        (lVar3,uVar5,"UIAtlas",uVar6,"NoticeLittleLittle",0x3f800000,0x40a00000,&local_58,0);
              fVar7 = this.exp;
              goto LAB_180a8edb8;
            }
          }
        }
    }

}
