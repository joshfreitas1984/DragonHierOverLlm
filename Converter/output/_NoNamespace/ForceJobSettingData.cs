// ============================================================
// Type  : ForceJobSettingData
// Token : 0x200020C
// ============================================================

public class ForceJobSettingData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000E5E
    public int emptyNum;

    // Token: 0x4000E5F
    public List<List<int>> ForceJobs;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000FD0
    // RVA   : 0x77E940   Offset: 0x77D140   Length: 0x2E9
    public void /*ctor*/()
    {
        long lVar1;
        long lVar2;
        ZhSegment.Initialize(this,0);
        this.emptyNum = 16;
        lVar1 = il2cpp_internal(DAT_181d6b5b0);
        FUN_180f58a90(lVar1,DAT_181d51488);
        lVar2 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(lVar2,DAT_181d678f8);
        if (lVar2 != null) {
          FUN_181814fa0(lVar2,0xffffffff,DAT_181d67a78);
          FUN_181814fa0(lVar2,0xffffffff,DAT_181d67a78);
          if (lVar1 != null) {
            FUN_181827900(lVar1,lVar2,DAT_181d51508);
            lVar2 = il2cpp_internal(DAT_181d6f030);
            FUN_180f58a90(lVar2,DAT_181d678f8);
            if (lVar2 != null) {
              FUN_181814fa0(lVar2,0xffffffff,DAT_181d67a78);
              FUN_181814fa0(lVar2,0xffffffff,DAT_181d67a78);
              FUN_181814fa0(lVar2,0xffffffff,DAT_181d67a78);
              FUN_181814fa0(lVar2,0xffffffff,DAT_181d67a78);
              FUN_181827900(lVar1,lVar2,DAT_181d51508);
              lVar2 = il2cpp_internal(DAT_181d6f030);
              FUN_180f58a90(lVar2,DAT_181d678f8);
              if (lVar2 != null) {
                FUN_181814fa0(lVar2,0xffffffff,DAT_181d67a78);
                FUN_181814fa0(lVar2,0xffffffff,DAT_181d67a78);
                FUN_181814fa0(lVar2,0xffffffff,DAT_181d67a78);
                FUN_181814fa0(lVar2,0xffffffff,DAT_181d67a78);
                FUN_181814fa0(lVar2,0xffffffff,DAT_181d67a78);
                FUN_181827900(lVar1,lVar2,DAT_181d51508);
                lVar2 = il2cpp_internal(DAT_181d6f030);
                FUN_180f58a90(lVar2,DAT_181d678f8);
                if (lVar2 != null) {
                  FUN_181814fa0(lVar2,0xffffffff,DAT_181d67a78);
                  FUN_181814fa0(lVar2,0xffffffff,DAT_181d67a78);
                  FUN_181814fa0(lVar2,0xffffffff,DAT_181d67a78);
                  FUN_181814fa0(lVar2,0xffffffff,DAT_181d67a78);
                  FUN_181814fa0(lVar2,0xffffffff,DAT_181d67a78);
                  FUN_181827900(lVar1,lVar2,DAT_181d51508);
                  this.ForceJobs = lVar1;
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000FD1
    // RVA   : 0x77E860   Offset: 0x77D060   Length: 0xDE
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
            cVar1 = FUN_181815240(lVar2,*(uint32 *)(targetHero + 88),DAT_181d67bf8);
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
