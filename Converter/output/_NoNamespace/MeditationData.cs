// ============================================================
// Type  : MeditationData
// Token : 0x20001E0
// ============================================================

public class MeditationData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000CB4
    public int lv;

    // Token: 0x4000CB5
    public float exp;

    // Token: 0x4000CB6
    public int monthMeditationDay;

    // Token: 0x4000CB7
    public ItemData meditationTreasure;

    // Token: 0x4000CB8
    public HeroSpeAddData treasureAddData;

    // Token: 0x4000CB9
    public int treasureLeftTime;

    // Token: 0x4000CBA
    public ItemData meditationFood;

    // Token: 0x4000CBB
    public HeroSpeAddData foodAddData;

    // Token: 0x4000CBC
    public int foodLeftTime;

    // Token: 0x4000CBD
    public ItemData meditationMed;

    // Token: 0x4000CBE
    public HeroSpeAddData medAddData;

    // Token: 0x4000CBF
    public int medLeftTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000EDB
    // RVA   : 0xA8EB00   Offset: 0xA8DF00   Length: 0xB5
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        this.treasureAddData = new HeroSpeAddData(0);
        this.foodAddData = new HeroSpeAddData(0);
        this.medAddData = new HeroSpeAddData(0);
    }

    // Token : 0x6000EDC
    // RVA   : 0xA8EA00   Offset: 0xA8DE00   Length: 0xF1
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

    // Token : 0x6000EDD
    // RVA   : 0xA8E760   Offset: 0xA8DB60   Length: 0x1B
    public float GetMaxExp()
    {
        float FUN_180a8e760(int64 this)
        {
        return (float)((this.lv + 2) * (this.lv + 1)) * 50.0;
    }

    // Token : 0x6000EDE
    // RVA   : 0xA8E780   Offset: 0xA8DB80   Length: 0xEB
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

    // Token : 0x6000EDF
    // RVA   : 0xA8E870   Offset: 0xA8DC70   Length: 0x181
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

    // Token : 0x6000EE0
    // RVA   : 0xA8E6D0   Offset: 0xA8DAD0   Length: 0x29
    public float GetItemExpNum(ItemData targetItem)
    {
        uint64 FUN_180a8e6d0(uint64 this,int64 targetItem)
        {
        uint64 uVar1;
        if (targetItem == null) {
          return 0;
        }
        uVar1 = Mathf.Max(0x3f800000,(float)*(int *)(targetItem + 56) * 0.01,0);
        return uVar1;
    }

    // Token : 0x6000EE1
    // RVA   : 0xA8E700   Offset: 0xA8DB00   Length: 0x54
    public float GetItemExpRate(ItemData targetItem)
    {
        if (targetItem == null) {
          return;
        }
        Mathf.Log(((float)*(int *)(targetItem + 56) + (float)*(int *)(targetItem + 56)) * 0.01,0x40000000,0
                  );
        Mathf.Max();
    }

    // Token : 0x6000EE2
    // RVA   : 0xA8E1C0   Offset: 0xA8D5C0   Length: 0x50C
    public void ChangeExp(float _exp, bool showInfo)
    {
        var pStatics_f6c0 = *(int64*)(DAT_181d7f6c0 + 184);
        int iVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        float fVar6;
        float[] local_res10 = new float[2];
        uint[] local_res18 = new uint[4];
        ulong local_58;
        ulong uStack_50;
        local_res10[0] = _exp;
        fVar6 = local_res10[0] + this.exp;
        this.exp = fVar6;
        if (!showInfo) {
        LAB_180a8e472:
          iVar1 = this.lv;
          if ((float)((iVar1 + 2) * (iVar1 + 1)) * 50.0 <= fVar6) {
            do {
              this.lv = iVar1 + 1;
              this.exp = fVar6 - (float)((iVar1 + 2) * (iVar1 + 1)) * 50.0;
              lVar2 = *pStatics_f6c0;
              if (((GameController._instance == null) ||
                  (lVar3 = GameController._instance.worldData) == null) ||
                 (lVar3 = WorldData.Player(lVar3,0)) == null) {
        LAB_180a8e6c1:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar4 = HeroData.GetMeditationTopic(lVar3,0);
              local_res18[0] = this.lv;
              uVar5 = il2cpp_value_box(DAT_181d80430,local_res18);
              uVar4 = String.Format("{0}修行达到{1}级",uVar4,uVar5,0);
              lVar3 = FUN_18046c0a0(0);
              if (((lVar3 == null) || (lVar3.villageAreaID == null)) ||
                 ((lVar3 = WorldData.Player(lVar3.villageAreaID,0), lVar3 == null ||
                  ((lVar3 = HeroData.GetForce(lVar3,0,0), lVar3 == null ||
                   (uVar5 = ForceData.GetForceIconName(lVar3,0), lVar2 == null)))))) goto LAB_180a8e6c1;
              local_58 = 0;
              uStack_50 = 0;
              InfoController.AddInfoTab
                        (lVar2,uVar4,"UIAtlas",uVar5,"LevelUpShort",0x3f800000,0x40a00000,&local_58,0);
              iVar1 = this.lv;
              fVar6 = this.exp;
            } while ((float)((iVar1 + 2) * (iVar1 + 1)) * 50.0 <= fVar6);
          }
          return;
        }
        lVar2 = *pStatics_f6c0;
        if (((GameController._instance != null) &&
            (lVar3 = GameController._instance.worldData) != null) &&
           (lVar3 = WorldData.Player(lVar3,0)) != null) {
          uVar4 = HeroData.GetMeditationTopic(lVar3,0);
          uVar5 = Single.ToString(local_res10,"+0;-0;0",0);
          uVar4 = String.Format("{0}修行经验{1}",uVar4,uVar5,0);
          if (((GameController._instance != null) &&
              (lVar3 = GameController._instance.worldData) != null) &&
             ((lVar3 = WorldData.Player(lVar3,0), lVar3 != null &&
              ((lVar3 = HeroData.GetForce(lVar3,0,0), lVar3 != null &&
               (uVar5 = ForceData.GetForceIconName(lVar3,0), lVar2 != null)))))) {
            local_58 = 0;
            uStack_50 = 0;
            InfoController.AddInfoTab
                      (lVar2,uVar4,"UIAtlas",uVar5,"NoticeLittleLittle",0x3f800000,0x40a00000,&local_58,0);
            fVar6 = this.exp;
            goto LAB_180a8e472;
          }
        }
    }

}
