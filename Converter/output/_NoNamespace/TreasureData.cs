// ============================================================
// Type  : TreasureData
// Token : 0x2000241
// ============================================================

public class TreasureData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400120C
    public bool fullIdentified;

    // Token: 0x400120D
    public float identifyKnowledgeNeed;

    // Token: 0x400120E
    public List<int> treasureLv;

    // Token: 0x400120F
    public List<float> identifyDifficulty;

    // Token: 0x4001210
    public List<bool> identified;

    // Token: 0x4001211
    public List<List<int>> playerGuessTreasureLv;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60012F1
    // RVA   : 0xAE0010   Offset: 0xADF410   Length: 0x534
    public void /*ctor*/()
    {
        long lVar1;
        long lVar2;
        ZhSegment.Initialize(this,0);
        lVar1 = il2cpp_internal(DAT_181d93ce8);
        FUN_181330100(lVar1,DAT_181d8f0b0);
        if (lVar1 != null) {
          FUN_18182a6c0(lVar1,0,DAT_181d8f230);
          FUN_18182a6c0(lVar1,0,DAT_181d8f230);
          FUN_18182a6c0(lVar1,0,DAT_181d8f230);
          FUN_18182a6c0(lVar1,0,DAT_181d8f230);
          this.treasureLv = lVar1;
          lVar1 = il2cpp_internal(DAT_181d96ee8);
          FUN_181330100(lVar1,DAT_181da0d10);
          if (lVar1 != null) {
            FUN_18181e420(lVar1,0,DAT_181da0e10);
            FUN_18181e420(lVar1,0,DAT_181da0e10);
            FUN_18181e420(lVar1,0,DAT_181da0e10);
            FUN_18181e420(lVar1,0,DAT_181da0e10);
            this.identifyDifficulty = lVar1;
            lVar1 = il2cpp_internal(DAT_181d917f0);
            FUN_181330100(lVar1,DAT_181d804b8);
            if (lVar1 != null) {
              FUN_1817e9ef0(lVar1,0,DAT_181d80538);
              FUN_1817e9ef0(lVar1,0,DAT_181d80538);
              FUN_1817e9ef0(lVar1,0,DAT_181d80538);
              FUN_1817e9ef0(lVar1,0,DAT_181d80538);
              this.identified = lVar1;
              lVar1 = il2cpp_internal(DAT_181d90178);
              FUN_181330100(lVar1,DAT_181d787c0);
              lVar2 = il2cpp_internal(DAT_181d93ce8);
              FUN_181330100(lVar2,DAT_181d8f0b0);
              if (lVar2 != null) {
                FUN_18182a6c0(lVar2,0,DAT_181d8f230);
                FUN_18182a6c0(lVar2,1,DAT_181d8f230);
                FUN_18182a6c0(lVar2,2,DAT_181d8f230);
                FUN_18182a6c0(lVar2,3,DAT_181d8f230);
                FUN_18182a6c0(lVar2,4,DAT_181d8f230);
                FUN_18182a6c0(lVar2,5,DAT_181d8f230);
                if (lVar1 != null) {
                  FUN_18181e6b0(lVar1,lVar2,DAT_181d78840);
                  lVar2 = il2cpp_internal(DAT_181d93ce8);
                  FUN_181330100(lVar2,DAT_181d8f0b0);
                  if (lVar2 != null) {
                    FUN_18182a6c0(lVar2,0,DAT_181d8f230);
                    FUN_18182a6c0(lVar2,1,DAT_181d8f230);
                    FUN_18182a6c0(lVar2,2,DAT_181d8f230);
                    FUN_18182a6c0(lVar2,3,DAT_181d8f230);
                    FUN_18182a6c0(lVar2,4,DAT_181d8f230);
                    FUN_18182a6c0(lVar2,5,DAT_181d8f230);
                    FUN_18181e6b0(lVar1,lVar2,DAT_181d78840);
                    lVar2 = il2cpp_internal(DAT_181d93ce8);
                    FUN_181330100(lVar2,DAT_181d8f0b0);
                    if (lVar2 != null) {
                      FUN_18182a6c0(lVar2,0,DAT_181d8f230);
                      FUN_18182a6c0(lVar2,1,DAT_181d8f230);
                      FUN_18182a6c0(lVar2,2,DAT_181d8f230);
                      FUN_18182a6c0(lVar2,3,DAT_181d8f230);
                      FUN_18182a6c0(lVar2,4,DAT_181d8f230);
                      FUN_18182a6c0(lVar2,5,DAT_181d8f230);
                      FUN_18181e6b0(lVar1,lVar2,DAT_181d78840);
                      lVar2 = il2cpp_internal(DAT_181d93ce8);
                      FUN_181330100(lVar2,DAT_181d8f0b0);
                      if (lVar2 != null) {
                        FUN_18182a6c0(lVar2,0,DAT_181d8f230);
                        FUN_18182a6c0(lVar2,1,DAT_181d8f230);
                        FUN_18182a6c0(lVar2,2,DAT_181d8f230);
                        FUN_18182a6c0(lVar2,3,DAT_181d8f230);
                        FUN_18182a6c0(lVar2,4,DAT_181d8f230);
                        FUN_18182a6c0(lVar2,5,DAT_181d8f230);
                        FUN_18181e6b0(lVar1,lVar2,DAT_181d78840);
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
