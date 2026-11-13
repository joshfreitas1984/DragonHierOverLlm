// ============================================================
// Type  : ForceJobSettingData
// Token : 0x2000214
// ============================================================

public class ForceJobSettingData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000F02
    public int emptyNum;

    // Token: 0x4000F03
    public List<List<int>> ForceJobs;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001011
    // RVA   : 0x1850730   Offset: 0x184F530   Length: 0x2E9
    public void /*ctor*/()
    {
        long lVar1;
        long lVar2;
        ZhSegment.Initialize(this,0);
        this.emptyNum = 16;
        lVar1 = il2cpp_internal(DAT_181e6ffb8);
        FUN_1810f3480(lVar1,DAT_181e5a220);
        lVar2 = il2cpp_internal(DAT_181e73cb8);
        FUN_1810f3480(lVar2,DAT_181e71270);
        if (lVar2 != null) {
          FUN_181769fe0(lVar2,0xffffffff,DAT_181e713f0);
          FUN_181769fe0(lVar2,0xffffffff,DAT_181e713f0);
          if (lVar1 != null) {
            FUN_18175de30(lVar1,lVar2,DAT_181e5a330);
            lVar2 = il2cpp_internal(DAT_181e73cb8);
            FUN_1810f3480(lVar2,DAT_181e71270);
            if (lVar2 != null) {
              FUN_181769fe0(lVar2,0xffffffff,DAT_181e713f0);
              FUN_181769fe0(lVar2,0xffffffff,DAT_181e713f0);
              FUN_181769fe0(lVar2,0xffffffff,DAT_181e713f0);
              FUN_181769fe0(lVar2,0xffffffff,DAT_181e713f0);
              FUN_18175de30(lVar1,lVar2,DAT_181e5a330);
              lVar2 = il2cpp_internal(DAT_181e73cb8);
              FUN_1810f3480(lVar2,DAT_181e71270);
              if (lVar2 != null) {
                FUN_181769fe0(lVar2,0xffffffff,DAT_181e713f0);
                FUN_181769fe0(lVar2,0xffffffff,DAT_181e713f0);
                FUN_181769fe0(lVar2,0xffffffff,DAT_181e713f0);
                FUN_181769fe0(lVar2,0xffffffff,DAT_181e713f0);
                FUN_181769fe0(lVar2,0xffffffff,DAT_181e713f0);
                FUN_18175de30(lVar1,lVar2,DAT_181e5a330);
                lVar2 = il2cpp_internal(DAT_181e73cb8);
                FUN_1810f3480(lVar2,DAT_181e71270);
                if (lVar2 != null) {
                  FUN_181769fe0(lVar2,0xffffffff,DAT_181e713f0);
                  FUN_181769fe0(lVar2,0xffffffff,DAT_181e713f0);
                  FUN_181769fe0(lVar2,0xffffffff,DAT_181e713f0);
                  FUN_181769fe0(lVar2,0xffffffff,DAT_181e713f0);
                  FUN_181769fe0(lVar2,0xffffffff,DAT_181e713f0);
                  FUN_18175de30(lVar1,lVar2,DAT_181e5a330);
                  this.ForceJobs = lVar1;
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6001012
    // RVA   : 0x1850650   Offset: 0x184F450   Length: 0xDE
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
            cVar1 = FUN_18176a2d0(lVar2,*(uint32 *)(targetHero + 88),DAT_181e71570);
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
