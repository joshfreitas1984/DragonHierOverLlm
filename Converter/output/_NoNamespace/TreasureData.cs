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
    // RVA   : 0xADF950   Offset: 0xADED50   Length: 0x534
    public void /*ctor*/()
    {
        long lVar1;
        long lVar2;
        ZhSegment.Initialize(this,0);
        lVar1 = il2cpp_internal(DAT_181d93cd0);
        FUN_18132faf0(lVar1,DAT_181d8f098);
        if (lVar1 != null) {
          FUN_18182a0b0(lVar1,0,DAT_181d8f218);
          FUN_18182a0b0(lVar1,0,DAT_181d8f218);
          FUN_18182a0b0(lVar1,0,DAT_181d8f218);
          FUN_18182a0b0(lVar1,0,DAT_181d8f218);
          this.treasureLv = lVar1;
          lVar1 = il2cpp_internal(DAT_181d96ed0);
          FUN_18132faf0(lVar1,DAT_181da0cf8);
          if (lVar1 != null) {
            FUN_18181de10(lVar1,0,DAT_181da0df8);
            FUN_18181de10(lVar1,0,DAT_181da0df8);
            FUN_18181de10(lVar1,0,DAT_181da0df8);
            FUN_18181de10(lVar1,0,DAT_181da0df8);
            this.identifyDifficulty = lVar1;
            lVar1 = il2cpp_internal(DAT_181d917d8);
            FUN_18132faf0(lVar1,DAT_181d804a0);
            if (lVar1 != null) {
              FUN_1817e98e0(lVar1,0,DAT_181d80520);
              FUN_1817e98e0(lVar1,0,DAT_181d80520);
              FUN_1817e98e0(lVar1,0,DAT_181d80520);
              FUN_1817e98e0(lVar1,0,DAT_181d80520);
              this.identified = lVar1;
              lVar1 = il2cpp_internal(DAT_181d90160);
              FUN_18132faf0(lVar1,DAT_181d787a8);
              lVar2 = il2cpp_internal(DAT_181d93cd0);
              FUN_18132faf0(lVar2,DAT_181d8f098);
              if (lVar2 != null) {
                FUN_18182a0b0(lVar2,0,DAT_181d8f218);
                FUN_18182a0b0(lVar2,1,DAT_181d8f218);
                FUN_18182a0b0(lVar2,2,DAT_181d8f218);
                FUN_18182a0b0(lVar2,3,DAT_181d8f218);
                FUN_18182a0b0(lVar2,4,DAT_181d8f218);
                FUN_18182a0b0(lVar2,5,DAT_181d8f218);
                if (lVar1 != null) {
                  FUN_18181e0a0(lVar1,lVar2,DAT_181d78828);
                  lVar2 = il2cpp_internal(DAT_181d93cd0);
                  FUN_18132faf0(lVar2,DAT_181d8f098);
                  if (lVar2 != null) {
                    FUN_18182a0b0(lVar2,0,DAT_181d8f218);
                    FUN_18182a0b0(lVar2,1,DAT_181d8f218);
                    FUN_18182a0b0(lVar2,2,DAT_181d8f218);
                    FUN_18182a0b0(lVar2,3,DAT_181d8f218);
                    FUN_18182a0b0(lVar2,4,DAT_181d8f218);
                    FUN_18182a0b0(lVar2,5,DAT_181d8f218);
                    FUN_18181e0a0(lVar1,lVar2,DAT_181d78828);
                    lVar2 = il2cpp_internal(DAT_181d93cd0);
                    FUN_18132faf0(lVar2,DAT_181d8f098);
                    if (lVar2 != null) {
                      FUN_18182a0b0(lVar2,0,DAT_181d8f218);
                      FUN_18182a0b0(lVar2,1,DAT_181d8f218);
                      FUN_18182a0b0(lVar2,2,DAT_181d8f218);
                      FUN_18182a0b0(lVar2,3,DAT_181d8f218);
                      FUN_18182a0b0(lVar2,4,DAT_181d8f218);
                      FUN_18182a0b0(lVar2,5,DAT_181d8f218);
                      FUN_18181e0a0(lVar1,lVar2,DAT_181d78828);
                      lVar2 = il2cpp_internal(DAT_181d93cd0);
                      FUN_18132faf0(lVar2,DAT_181d8f098);
                      if (lVar2 != null) {
                        FUN_18182a0b0(lVar2,0,DAT_181d8f218);
                        FUN_18182a0b0(lVar2,1,DAT_181d8f218);
                        FUN_18182a0b0(lVar2,2,DAT_181d8f218);
                        FUN_18182a0b0(lVar2,3,DAT_181d8f218);
                        FUN_18182a0b0(lVar2,4,DAT_181d8f218);
                        FUN_18182a0b0(lVar2,5,DAT_181d8f218);
                        FUN_18181e0a0(lVar1,lVar2,DAT_181d78828);
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
