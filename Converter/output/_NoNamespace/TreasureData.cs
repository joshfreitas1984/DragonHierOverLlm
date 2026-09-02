// ============================================================
// Type  : TreasureData
// Token : 0x200023B
// ============================================================

public class TreasureData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001169
    public bool fullIdentified;

    // Token: 0x400116A
    public float identifyKnowledgeNeed;

    // Token: 0x400116B
    public List<int> treasureLv;

    // Token: 0x400116C
    public List<float> identifyDifficulty;

    // Token: 0x400116D
    public List<bool> identified;

    // Token: 0x400116E
    public List<List<int>> playerGuessTreasureLv;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60012B0
    // RVA   : 0xA65CF0   Offset: 0xA644F0   Length: 0x534
    public void /*ctor*/()
    {
        long lVar1;
        long lVar2;
        ZhSegment.Initialize(this,0);
        lVar1 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(lVar1,DAT_181d678f8);
        if (lVar1 != null) {
          FUN_181814fa0(lVar1,0,DAT_181d67a78);
          FUN_181814fa0(lVar1,0,DAT_181d67a78);
          FUN_181814fa0(lVar1,0,DAT_181d67a78);
          FUN_181814fa0(lVar1,0,DAT_181d67a78);
          this.treasureLv = lVar1;
          lVar1 = il2cpp_internal(DAT_181d721b0);
          FUN_180f58a90(lVar1,DAT_181d79358);
          if (lVar1 != null) {
            FUN_181805690(lVar1,0,DAT_181d79458);
            FUN_181805690(lVar1,0,DAT_181d79458);
            FUN_181805690(lVar1,0,DAT_181d79458);
            FUN_181805690(lVar1,0,DAT_181d79458);
            this.identifyDifficulty = lVar1;
            lVar1 = il2cpp_internal(DAT_181d6cb30);
            FUN_180f58a90(lVar1,DAT_181d58d10);
            if (lVar1 != null) {
              FUN_181805880(lVar1,0,DAT_181d58d90);
              FUN_181805880(lVar1,0,DAT_181d58d90);
              FUN_181805880(lVar1,0,DAT_181d58d90);
              FUN_181805880(lVar1,0,DAT_181d58d90);
              this.identified = lVar1;
              lVar1 = il2cpp_internal(DAT_181d6b5b0);
              FUN_180f58a90(lVar1,DAT_181d51488);
              lVar2 = il2cpp_internal(DAT_181d6f030);
              FUN_180f58a90(lVar2,DAT_181d678f8);
              if (lVar2 != null) {
                FUN_181814fa0(lVar2,0,DAT_181d67a78);
                FUN_181814fa0(lVar2,1,DAT_181d67a78);
                FUN_181814fa0(lVar2,2,DAT_181d67a78);
                FUN_181814fa0(lVar2,3,DAT_181d67a78);
                FUN_181814fa0(lVar2,4,DAT_181d67a78);
                FUN_181814fa0(lVar2,5,DAT_181d67a78);
                if (lVar1 != null) {
                  FUN_181827900(lVar1,lVar2,DAT_181d51508);
                  lVar2 = il2cpp_internal(DAT_181d6f030);
                  FUN_180f58a90(lVar2,DAT_181d678f8);
                  if (lVar2 != null) {
                    FUN_181814fa0(lVar2,0,DAT_181d67a78);
                    FUN_181814fa0(lVar2,1,DAT_181d67a78);
                    FUN_181814fa0(lVar2,2,DAT_181d67a78);
                    FUN_181814fa0(lVar2,3,DAT_181d67a78);
                    FUN_181814fa0(lVar2,4,DAT_181d67a78);
                    FUN_181814fa0(lVar2,5,DAT_181d67a78);
                    FUN_181827900(lVar1,lVar2,DAT_181d51508);
                    lVar2 = il2cpp_internal(DAT_181d6f030);
                    FUN_180f58a90(lVar2,DAT_181d678f8);
                    if (lVar2 != null) {
                      FUN_181814fa0(lVar2,0,DAT_181d67a78);
                      FUN_181814fa0(lVar2,1,DAT_181d67a78);
                      FUN_181814fa0(lVar2,2,DAT_181d67a78);
                      FUN_181814fa0(lVar2,3,DAT_181d67a78);
                      FUN_181814fa0(lVar2,4,DAT_181d67a78);
                      FUN_181814fa0(lVar2,5,DAT_181d67a78);
                      FUN_181827900(lVar1,lVar2,DAT_181d51508);
                      lVar2 = il2cpp_internal(DAT_181d6f030);
                      FUN_180f58a90(lVar2,DAT_181d678f8);
                      if (lVar2 != null) {
                        FUN_181814fa0(lVar2,0,DAT_181d67a78);
                        FUN_181814fa0(lVar2,1,DAT_181d67a78);
                        FUN_181814fa0(lVar2,2,DAT_181d67a78);
                        FUN_181814fa0(lVar2,3,DAT_181d67a78);
                        FUN_181814fa0(lVar2,4,DAT_181d67a78);
                        FUN_181814fa0(lVar2,5,DAT_181d67a78);
                        FUN_181827900(lVar1,lVar2,DAT_181d51508);
                        this.playerGuessTreasureLv = lVar1;
                        return;
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

}
