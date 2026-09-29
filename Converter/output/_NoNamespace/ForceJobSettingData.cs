// ============================================================
// Type  : ForceJobSettingData
// Token : 0x2000212
// ============================================================

public class ForceJobSettingData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000EEE
    public int emptyNum;

    // Token: 0x4000EEF
    public List<List<int>> ForceJobs;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001008
    // RVA   : 0x77B250   Offset: 0x77A650   Length: 0x2E9
    public void /*ctor*/()
    {
        long lVar1;
        long lVar2;
        ZhSegment.Initialize(this,0);
        this.emptyNum = 16;
        lVar1 = il2cpp_internal(DAT_181d90178);
        FUN_181330100(lVar1,DAT_181d787c0);
        lVar2 = il2cpp_internal(DAT_181d93ce8);
        FUN_181330100(lVar2,DAT_181d8f0b0);
        if (lVar2 != null) {
          FUN_18182a6c0(lVar2,0xffffffff,DAT_181d8f230);
          FUN_18182a6c0(lVar2,0xffffffff,DAT_181d8f230);
          if (lVar1 != null) {
            FUN_18181e6b0(lVar1,lVar2,DAT_181d78840);
            lVar2 = il2cpp_internal(DAT_181d93ce8);
            FUN_181330100(lVar2,DAT_181d8f0b0);
            if (lVar2 != null) {
              FUN_18182a6c0(lVar2,0xffffffff,DAT_181d8f230);
              FUN_18182a6c0(lVar2,0xffffffff,DAT_181d8f230);
              FUN_18182a6c0(lVar2,0xffffffff,DAT_181d8f230);
              FUN_18182a6c0(lVar2,0xffffffff,DAT_181d8f230);
              FUN_18181e6b0(lVar1,lVar2,DAT_181d78840);
              lVar2 = il2cpp_internal(DAT_181d93ce8);
              FUN_181330100(lVar2,DAT_181d8f0b0);
              if (lVar2 != null) {
                FUN_18182a6c0(lVar2,0xffffffff,DAT_181d8f230);
                FUN_18182a6c0(lVar2,0xffffffff,DAT_181d8f230);
                FUN_18182a6c0(lVar2,0xffffffff,DAT_181d8f230);
                FUN_18182a6c0(lVar2,0xffffffff,DAT_181d8f230);
                FUN_18182a6c0(lVar2,0xffffffff,DAT_181d8f230);
                FUN_18181e6b0(lVar1,lVar2,DAT_181d78840);
                lVar2 = il2cpp_internal(DAT_181d93ce8);
                FUN_181330100(lVar2,DAT_181d8f0b0);
                if (lVar2 != null) {
                  FUN_18182a6c0(lVar2,0xffffffff,DAT_181d8f230);
                  FUN_18182a6c0(lVar2,0xffffffff,DAT_181d8f230);
                  FUN_18182a6c0(lVar2,0xffffffff,DAT_181d8f230);
                  FUN_18182a6c0(lVar2,0xffffffff,DAT_181d8f230);
                  FUN_18182a6c0(lVar2,0xffffffff,DAT_181d8f230);
                  FUN_18181e6b0(lVar1,lVar2,DAT_181d78840);
                  this.ForceJobs = lVar1;
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6001009
    // RVA   : 0x77B170   Offset: 0x77A570   Length: 0xDE
    public bool HaveHero(HeroData targetHero)
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        uint uVar4;
        lVar2 = this.ForceJobs;
        uVar4 = 0;
        if (lVar2 != null) {
          lVar3 = 32;
          while( true ) {
            if (lVar2.Count <= (int)uVar4) {
              return false;
            }
            if (lVar2 == null) break;
            if (lVar2.Count <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if ((targetHero == null) || (lVar2 = *(int64 *)(lVar3 + lVar2._items)) == null
               ) break;
            cVar1 = FUN_18182a9b0(lVar2,*(uint32 *)(targetHero + 88),DAT_181d8f3b0);
            if (cVar1) {
              return true;
            }
            lVar2 = this.ForceJobs;
            uVar4 = uVar4 + 1;
            lVar3 = lVar3 + 8;
            if (lVar2 == null) break;
          }
        }
    }

}
