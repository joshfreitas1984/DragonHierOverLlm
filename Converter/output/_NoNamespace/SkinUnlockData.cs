// ============================================================
// Type  : SkinUnlockData
// Token : 0x20001D9
// ============================================================

public class SkinUnlockData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C98
    public int skinID;

    // Token: 0x4000C99
    public List<bool> skinLvUnlocked;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000EC8
    // RVA   : 0x989360   Offset: 0x988760   Length: 0xF7
    public void /*ctor*/(int _skinID)
    {
        long lVar1;
        ZhSegment.Initialize(this,0);
        this.skinID = _skinID;
        lVar1 = il2cpp_internal(DAT_181d917d8);
        FUN_18132faf0(lVar1,DAT_181d804a0);
        if (lVar1 != null) {
          FUN_1817e98e0(lVar1,0,DAT_181d80520);
          FUN_1817e98e0(lVar1,0,DAT_181d80520);
          FUN_1817e98e0(lVar1,0,DAT_181d80520);
          FUN_1817e98e0(lVar1,0,DAT_181d80520);
          FUN_1817e98e0(lVar1,0,DAT_181d80520);
          FUN_1817e98e0(lVar1,0,DAT_181d80520);
          this.skinLvUnlocked = lVar1;
          return;
        }
    }

    // Token : 0x6000EC9
    // RVA   : 0x989260   Offset: 0x988660   Length: 0xFD
    public string GetSkinFullName(int _skinLv, bool changeLine, bool changeColor)
    {
        void SkinUnlockData.GetSkinFullName
                     (int64 this,uint32 _skinLv,uint8 changeLine,uint8 changeColor)
        {
        int64 lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
        if (lVar1 != null) {
          lVar1 = GameDataController.FindSkinDataBase(lVar1,this.skinID,0);
          if (lVar1 != null) {
            SkinDataBase.GetSkinFullName(lVar1,_skinLv,changeLine,changeColor);
            return;
          }
        }
    }

}
