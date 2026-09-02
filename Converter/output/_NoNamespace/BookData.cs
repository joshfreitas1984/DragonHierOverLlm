// ============================================================
// Type  : BookData
// Token : 0x200023A
// ============================================================

public class BookData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001168
    public int skillID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60012AC
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60012AD
    // RVA   : 0xCDD6F0   Offset: 0xCDBEF0   Length: 0xB6
    public KungfuSkillData DataBase()
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
        if (lVar1 != null) {
          GameDataController.GetSkillDataBase(lVar1,this.skillID,0);
          return;
        }
    }

    // Token : 0x60012AE
    // RVA   : 0xCDD7B0   Offset: 0xCDBFB0   Length: 0xD5
    public int ReadDayCost()
    {
        int iVar1;
        long lVar2;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
        if (lVar2 != null) {
          lVar2 = GameDataController.GetSkillDataBase(lVar2,this.skillID,0);
          if (lVar2 != null) {
            iVar1 = Mathf.FloorToInt((float)*(int *)(lVar2 + 52) * 0.5,0);
            return iVar1 + 1;
          }
        }
    }

    // Token : 0x60012AF
    // RVA   : 0xCDD890   Offset: 0xCDC090   Length: 0xDB
    public int ReadMoneyCost()
    {
        int iVar1;
        long lVar2;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
        if (lVar2 != null) {
          lVar2 = GameDataController.GetSkillDataBase(lVar2,this.skillID,0);
          if (lVar2 != null) {
            iVar1 = Mathf.FloorToInt((float)*(int *)(lVar2 + 52) * 0.5,0);
            return (iVar1 + 1) * 20;
          }
        }
    }

}
