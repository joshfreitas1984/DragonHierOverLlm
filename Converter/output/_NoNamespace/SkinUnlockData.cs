// ============================================================
// Type  : SkinUnlockData
// Token : 0x20001D3
// ============================================================

public class SkinUnlockData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C0B
    public int skinID;

    // Token: 0x4000C0C
    public List<bool> skinLvUnlocked;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E93
    // RVA   : 0x9766D0   Offset: 0x974ED0   Length: 0xF7
    public void /*ctor*/(int _skinID)
    {
        long lVar1;
        ZhSegment.Initialize(this,0);
        this.skinID = _skinID;
        lVar1 = il2cpp_internal(DAT_181d6cb30);
        FUN_180f58a90(lVar1,DAT_181d58d10);
        if (lVar1 != null) {
          FUN_181805880(lVar1,0,DAT_181d58d90);
          FUN_181805880(lVar1,0,DAT_181d58d90);
          FUN_181805880(lVar1,0,DAT_181d58d90);
          FUN_181805880(lVar1,0,DAT_181d58d90);
          FUN_181805880(lVar1,0,DAT_181d58d90);
          FUN_181805880(lVar1,0,DAT_181d58d90);
          this.skinLvUnlocked = lVar1;
          return;
        }
    }

    // Token : 0x6000E94
    // RVA   : 0x9765D0   Offset: 0x974DD0   Length: 0xFD
    public string GetSkinFullName(int _skinLv, bool changeLine, bool changeColor)
    {
        void SkinUnlockData.GetSkinFullName
                     (int64 this,uint32 _skinLv,uint8 changeLine,uint8 changeColor)
        {
        int64 lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
        if (lVar1 != null) {
          lVar1 = GameDataController.FindSkinDataBase(lVar1,this.skinID,0);
          if (lVar1 != null) {
            SkinDataBase.GetSkinFullName(lVar1,_skinLv,changeLine,changeColor);
            return;
          }
        }
    }

}
