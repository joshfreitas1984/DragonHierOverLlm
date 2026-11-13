// ============================================================
// Type  : BookData
// Token : 0x2000244
// ============================================================

public class BookData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001229
    public int skillID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600130D
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x600130E
    // RVA   : 0x9EC850   Offset: 0x9EB650   Length: 0xB6
    public KungfuSkillData DataBase()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32);
        if (lVar1 != null) {
          GameDataController.GetSkillDataBase(lVar1,this.skillID,0);
          return;
        }
    }

    // Token : 0x600130F
    // RVA   : 0x9EC910   Offset: 0x9EB710   Length: 0xD5
    public int ReadDayCost()
    {
        int iVar1;
        long lVar2;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32);
        if (lVar2 != null) {
          lVar2 = GameDataController.GetSkillDataBase(lVar2,this.skillID,0);
          if (lVar2 != null) {
            iVar1 = Mathf.FloorToInt((float)*(int *)(lVar2 + 52) * 0.5,0);
            return iVar1 + 1;
          }
        }
    }

    // Token : 0x6001310
    // RVA   : 0x9EC9F0   Offset: 0x9EB7F0   Length: 0xDB
    public int ReadMoneyCost()
    {
        int iVar1;
        long lVar2;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32);
        if (lVar2 != null) {
          lVar2 = GameDataController.GetSkillDataBase(lVar2,this.skillID,0);
          if (lVar2 != null) {
            iVar1 = Mathf.FloorToInt((float)*(int *)(lVar2 + 52) * 0.5,0);
            return (iVar1 + 1) * 20;
          }
        }
    }

    // Token : 0x6001311
    // RVA   : 0x9EC7E0   Offset: 0x9EB5E0   Length: 0x60
    public virtual object Clone()
    {
        long lVar1;
        lVar1 = new ZhSegment(0);
        if (lVar1 != null) {
          *(uint32 *)(lVar1 + 16) = this.skillID;
          return lVar1;
        }
    }

}
