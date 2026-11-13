// ============================================================
// Type  : SkinUnlockData
// Token : 0x20001DB
// ============================================================

public class SkinUnlockData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000CAB
    public int skinID;

    // Token: 0x4000CAC
    public List<bool> skinLvUnlocked;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000ECE
    // RVA   : 0x6B1140   Offset: 0x6AFF40   Length: 0xF7
    public void /*ctor*/(int _skinID)
    {
        long lVar1;
        ZhSegment.Initialize(this,0);
        this.skinID = _skinID;
        lVar1 = il2cpp_internal(DAT_181e71638);
        FUN_1810f3480(lVar1,DAT_181e624f8);
        if (lVar1 != null) {
          FUN_181660e60(lVar1,0,DAT_181e625f8);
          FUN_181660e60(lVar1,0,DAT_181e625f8);
          FUN_181660e60(lVar1,0,DAT_181e625f8);
          FUN_181660e60(lVar1,0,DAT_181e625f8);
          FUN_181660e60(lVar1,0,DAT_181e625f8);
          FUN_181660e60(lVar1,0,DAT_181e625f8);
          this.skinLvUnlocked = lVar1;
          return;
        }
    }

    // Token : 0x6000ECF
    // RVA   : 0x6B1040   Offset: 0x6AFE40   Length: 0xFD
    public string GetSkinFullName(int _skinLv, bool changeLine, bool changeColor)
    {
        void SkinUnlockData.GetSkinFullName
                     (int64 this,uint32 _skinLv,uint8 changeLine,uint8 changeColor)
        {
        int64 lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32);
        if (lVar1 != null) {
          lVar1 = GameDataController.FindSkinDataBase(lVar1,this.skinID,0);
          if (lVar1 != null) {
            SkinDataBase.GetSkinFullName(lVar1,_skinLv,changeLine,changeColor);
            return;
          }
        }
    }

}
