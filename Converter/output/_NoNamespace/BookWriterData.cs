// ============================================================
// Type  : BookWriterData
// Token : 0x200020E
// ============================================================

public class BookWriterData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000EDE
    public int lv;

    // Token: 0x4000EDF
    public BookWriterType bookWriterType;

    // Token: 0x4000EE0
    public int bookWriterHeroID;

    // Token: 0x4000EE1
    public ItemData targetBookData;

    // Token: 0x4000EE2
    public ItemData combineBookData;

    // Token: 0x4000EE3
    public KungfuSkillLvData targetSkillData;

    // Token: 0x4000EE4
    public bool workStarted;

    // Token: 0x4000EE5
    public float workPercent;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000FF7
    // RVA   : 0xC85A40   Offset: 0xC84E40   Length: 0x63
    public void Reset()
    {
        long lVar1;
        if (this.bookWriterHeroID != -1) {
          lVar1 = BookWriterData.GetBookWriterHero(this,0);
          if (lVar1 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          *(uint8 *)(lVar1 + 0x370) = 0;
        }
        this.targetBookData = 0;
        this.bookWriterHeroID = 0xffffffff;
        this.targetSkillData = 0;
        this.workStarted = 0;
        this.workPercent = 0;
    }

    // Token : 0x6000FF8
    // RVA   : 0xC84F80   Offset: 0xC84380   Length: 0xBE
    public HeroData GetBookWriterHero()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        long lVar1;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
          WorldData.GetHero(lVar1,this.bookWriterHeroID,0);
          return;
        }
    }

    // Token : 0x6000FF9
    // RVA   : 0xC856C0   Offset: 0xC84AC0   Length: 0x144
    public ItemData GetWorkResult()
    {
        int iVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        iVar1 = this.bookWriterType;
        if (iVar1 == 0) {
          lVar4 = new ItemData(3);
          lVar2 = this.targetBookData;
          if (((lVar2 != null) && (lVar2.bookData != null)) && (lVar4 != null)) {
            uVar3 = ItemData.SetBookData
                              (lVar4,*(uint32 *)(lVar2.bookData + 16),
                               lVar2.rareLv + 1,0);
            return uVar3;
          }
        }
        else if (iVar1 == 1) {
          lVar2 = new ItemData(3);
          if (((this.targetBookData != null) &&
              (lVar4 = this.targetBookData.bookData) != null) && (lVar2 != null))
          {
            uVar3 = ItemData.SetBookData(lVar2,*(uint32 *)(lVar4 + 16),0,0);
            return uVar3;
          }
        }
        else {
          if (iVar1 != 2) {
            return 0;
          }
          lVar2 = new ItemData(3);
          if ((this.targetSkillData != null) && (lVar2 != null)) {
            uVar3 = ItemData.SetBookData(lVar2,this.targetSkillData.skillID,0,0)
            ;
            return uVar3;
          }
        }
    }

    // Token : 0x6000FFA
    // RVA   : 0xC84F20   Offset: 0xC84320   Length: 0x26
    public bool BookSelectFinished()
    {
        bool FUN_180c84f20(int64 this)
        {
        int iVar1;
        iVar1 = this.bookWriterType;
        if ((iVar1 != 0) && (iVar1 != 1)) {
          if (iVar1 != 2) {
            return false;
          }
          return this.targetSkillData != null;
        }
        return this.targetBookData != null;
    }

    // Token : 0x6000FFB
    // RVA   : 0xC84F50   Offset: 0xC84350   Length: 0x2F
    public bool CanStartWork()
    {
        uint8 FUN_180c84f50(int64 this)
        {
        int iVar1;
        int64 lVar2;
        uint8 uVar3;
        iVar1 = this.bookWriterType;
        if ((iVar1 == 0) || (iVar1 == 1)) {
          lVar2 = this.targetBookData;
        }
        else {
          if (iVar1 != 2) {
            return false;
          }
          lVar2 = this.targetSkillData;
        }
        if ((lVar2 != null) && (this.bookWriterHeroID != -1)) {
          uVar3 = BookWriterData.HaveMoney(this,0);
          return uVar3;
        }
        return false;
    }

    // Token : 0x6000FFC
    // RVA   : 0xC85950   Offset: 0xC84D50   Length: 0xE8
    public bool HaveMoney()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        int iVar1;
        int iVar2;
        long lVar3;
        if ((*pStatics != 0) &&
           (lVar3 = *(int64 *)(*pStatics + 32)) != null) {
          lVar3 = WorldData.Player(lVar3,0);
          if ((lVar3 != null) && (*(int64 *)(lVar3 + 0x220) != 0)) {
            iVar1 = *(int *)(*(int64 *)(lVar3 + 0x220) + 24);
            iVar2 = BookWriterData.GetMoneyCost(this,0);
            return iVar2 <= iVar1;
          }
        }
    }

    // Token : 0x6000FFD
    // RVA   : 0xC85300   Offset: 0xC84700   Length: 0x121
    public int GetMoneyCost()
    {
        int iVar1;
        long lVar2;
        int iVar3;
        float fVar4;
        iVar1 = this.bookWriterType;
        iVar3 = 0;
        if (iVar1 == 0) {
          lVar2 = this.targetBookData;
          if (lVar2 == null) goto LAB_180c8541c;
          iVar3 = (lVar2.itemLv + 1 + lVar2.rareLv) * 500;
        }
        else if (iVar1 == 1) {
          lVar2 = this.targetBookData;
          if (lVar2 == null) goto LAB_180c8541c;
          fVar4 = (float)FUN_1801f8ab0(0x40000000);
          iVar3 = Mathf.RoundToInt((1.0 - (float)lVar2.rareLv * 0.05) *
                                    (float)((int)fVar4 * 500),0);
        }
        else if (iVar1 == 2) {
          if (this.targetSkillData != null) {
            lVar2 = KungfuSkillLvData.DataBase(this.targetSkillData,0);
            if (lVar2 != null) {
              fVar4 = (float)FUN_1801f8ab0(0x40000000);
              iVar3 = (int)fVar4 * 500;
              goto LAB_180c853e0;
            }
          }
        LAB_180c8541c:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        LAB_180c853e0:
        BookWriterData.GetSkillChangeRate(this,0);
        fVar4 = (float)Mathf.Min(0x3fa00000);
        Mathf.RoundToInt((float)iVar3 / fVar4,0);
    }

    // Token : 0x6000FFE
    // RVA   : 0xC85690   Offset: 0xC84A90   Length: 0x25
    public int GetTotalTimeCost()
    {
        float fVar1;
        fVar1 = (float)BookWriterData.GetEachDayWorkPercent(this,0);
        Mathf.CeilToInt(1.0 / fVar1,0);
    }

    // Token : 0x6000FFF
    // RVA   : 0xC85640   Offset: 0xC84A40   Length: 0x43
    public int GetTargetSkillType()
    {
        long lVar1;
        ulong uVar2;
        if (this.targetBookData == null) {
          if (this.targetSkillData != null) {
            uVar2 = KungfuSkillLvData.Type(this.targetSkillData,0);
            return uVar2;
          }
        }
        else {
          lVar1 = this.targetBookData.bookData;
          if (lVar1 != null) {
            lVar1 = BookData.DataBase(lVar1,0);
            if (lVar1 != null) {
              return (uint64)*(uint32 *)(lVar1 + 48);
            }
          }
        }
    }

    // Token : 0x6001000
    // RVA   : 0xC85430   Offset: 0xC84830   Length: 0x209
    public float GetSkillChangeRate()
    {
        int iVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        float fVar5;
        float fVar6;
        fVar5 = 0.0;
        if (this.bookWriterHeroID == -1) {
          fVar6 = 0.0;
        }
        else {
          lVar3 = BookWriterData.GetBookWriterHero(this,0);
          if ((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 0x168)) == null) goto LAB_180c85634;
          if (*(uint32 *)(lVar3 + 24) < 3) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          fVar6 = *(float *)(*(int64 *)(lVar3 + 16) + 40);
        }
        iVar1 = BookWriterData.GetMinSkillLv(this,0);
        if ((float)iVar1 < fVar6) {
          BookWriterData.GetMinSkillLv(this,0);
        }
        else {
          BookWriterData.GetMinSkillLv(this,0);
        }
        if (this.bookWriterHeroID != -1) {
          lVar3 = BookWriterData.GetBookWriterHero(this,0);
          if (lVar3 == null) goto LAB_180c85634;
          lVar3 = *(int64 *)(lVar3 + 0x150);
          if (this.targetBookData == null) {
            if (this.targetSkillData == null) goto LAB_180c85634;
            uVar2 = KungfuSkillLvData.Type(this.targetSkillData,0);
          }
          else {
            lVar4 = this.targetBookData.bookData;
            if (lVar4 == null) goto LAB_180c85634;
            lVar4 = BookData.DataBase(lVar4,0);
            if (lVar4 == null) goto LAB_180c85634;
            uVar2 = *(uint32 *)(lVar4 + 48);
          }
          if (lVar3 == null) {
        LAB_180c85634:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(uint32 *)(lVar3 + 24) <= uVar2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          fVar5 = lVar3[uVar2];
        }
        iVar1 = BookWriterData.GetMinSkillLv(this,0);
        if ((float)iVar1 < fVar5) {
          BookWriterData.GetMinSkillLv(this,0);
        }
        else {
          BookWriterData.GetMinSkillLv(this,0);
        }
        Mathf.Max();
    }

    // Token : 0x6001001
    // RVA   : 0xC85040   Offset: 0xC84440   Length: 0x123
    public float GetEachDayWorkPercent()
    {
        int iVar1;
        long lVar2;
        byte[] auVar3 = new byte[16];
        byte[] auVar4 = new byte[16];
        float fVar5;
        uint64 extraout_XMM0_Qb;
        iVar1 = this.bookWriterType;
        fVar5 = 0.0;
        if (iVar1 == 0) {
          lVar2 = this.targetBookData;
          if (lVar2 == null) goto LAB_180c8515e;
          fVar5 = (float)(lVar2.itemLv + 1 + lVar2.rareLv);
          fVar5 = 1.0 / (fVar5 + fVar5);
        }
        else if (iVar1 == 1) {
          lVar2 = this.targetBookData;
          if (lVar2 == null) goto LAB_180c8515e;
          fVar5 = 1.0 / ((1.0 - (float)lVar2.rareLv * 0.1) *
                        (float)(lVar2.itemLv + 1) * 5.0);
        }
        else if (iVar1 == 2) {
          if (this.targetSkillData != null) {
            lVar2 = KungfuSkillLvData.DataBase(this.targetSkillData,0);
            if ((lVar2 != null) && (this.targetSkillData != null)) {
              fVar5 = 1.0 / ((1.0 - (float)this.targetSkillData.lv * 0.05) *
                            (float)(*(int *)(lVar2 + 52) + 1) * 10.0);
              goto LAB_180c85145;
            }
          }
        LAB_180c8515e:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        LAB_180c85145:
        auVar3._0_8_ = BookWriterData.GetSkillChangeRate(this,0);
        auVar3._8_8_ = extraout_XMM0_Qb;
        auVar4._4_12_ = auVar3._4_12_;
        auVar4._0_4_ = (float)auVar3._0_8_ * fVar5;
        return auVar4._0_8_;
    }

    // Token : 0x6001002
    // RVA   : 0xC85810   Offset: 0xC84C10   Length: 0x132
    public bool HaveEnoughSkill()
    {
        float fVar1;
        int iVar3;
        uint uVar4;
        long lVar5;
        long lVar6;
        if (this.bookWriterHeroID == -1) {
          return true;
        }
        lVar5 = BookWriterData.GetBookWriterHero(this,0);
        if ((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 0x168)) == null) goto LAB_180c8593d;
        if (*(uint32 *)(lVar5 + 24) < 3) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        fVar1 = *(float *)(*(int64 *)(lVar5 + 16) + 40);
        iVar3 = BookWriterData.GetMinSkillLv(this,0);
        if ((float)iVar3 <= fVar1) {
          lVar5 = BookWriterData.GetBookWriterHero(this,0);
          if (lVar5 == null) goto LAB_180c8593d;
          lVar5 = *(int64 *)(lVar5 + 0x150);
          if (this.targetBookData == null) {
            if (this.targetSkillData == null) goto LAB_180c8593d;
            uVar4 = KungfuSkillLvData.Type(this.targetSkillData,0);
          }
          else {
            lVar6 = this.targetBookData.bookData;
            if (lVar6 == null) goto LAB_180c8593d;
            lVar6 = BookData.DataBase(lVar6,0);
            if (lVar6 == null) goto LAB_180c8593d;
            uVar4 = *(uint32 *)(lVar6 + 48);
          }
          if (lVar5 == null) {
        LAB_180c8593d:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(uint32 *)(lVar5 + 24) <= uVar4) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          fVar1 = lVar5[uVar4];
          iVar3 = BookWriterData.GetMinSkillLv(this,0);
          bVar2 = (float)iVar3 <= fVar1;
        }
        else {
          bVar2 = false;
        }
        return bVar2;
    }

    // Token : 0x6001003
    // RVA   : 0xC85170   Offset: 0xC84570   Length: 0x181
    public int GetMinSkillLv()
    {
        var pStatics = *(int64*)(DAT_181d72cc8 + 184);
        int iVar1;
        bool cVar2;
        long lVar3;
        int iVar4;
        float fVar5;
        iVar1 = this.bookWriterType;
        iVar4 = 0;
        if (iVar1 == 0) {
          lVar3 = this.targetBookData;
          if (lVar3 == null) throw; // [null/range check failed]
          iVar4 = (lVar3.itemLv * 3 + lVar3.rareLv + 1) * 5;
        }
        else if (iVar1 == 1) {
          lVar3 = this.targetBookData;
          if (lVar3 == null) throw; // [null/range check failed]
          iVar4 = (lVar3.itemLv * 5 - lVar3.rareLv) * 3 + 10;
        }
        else if (iVar1 == 2) {
          if (this.targetSkillData == null) throw; // [null/range check failed]
          lVar3 = KungfuSkillLvData.DataBase(this.targetSkillData,0);
          if (lVar3 == null) throw; // [null/range check failed]
          iVar4 = (*(int *)(lVar3 + 52) + 1) * 15;
        }
        if ((*pStatics != 0) &&
           (lVar3 = *(int64 *)(*pStatics + 32)) != null) {
          lVar3 = WorldData.Player(lVar3,0);
          if (lVar3 != null) {
            cVar2 = HeroData.HaveForceFunction(lVar3,9);
            if (!cVar2) {
              fVar5 = 1.0;
            }
            else {
              fVar5 = 0.9;
            }
            Mathf.RoundToInt((float)iVar4 * fVar5,0);
            return;
          }
        }
    }

    // Token : 0x6001004
    // RVA   : 0xC85AB0   Offset: 0xC84EB0   Length: 0xE
    public void /*ctor*/()
    {
        this.bookWriterHeroID = 0xffffffff;
        ZhSegment.Initialize(this,0);
    }

}
