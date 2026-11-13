// ============================================================
// Type  : TreasureData
// Token : 0x2000245
// ============================================================

public class TreasureData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400122A
    public bool fullIdentified;

    // Token: 0x400122B
    public float identifyKnowledgeNeed;

    // Token: 0x400122C
    public List<int> treasureLv;

    // Token: 0x400122D
    public List<float> identifyDifficulty;

    // Token: 0x400122E
    public List<bool> identified;

    // Token: 0x400122F
    public List<List<int>> playerGuessTreasureLv;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001312
    // RVA   : 0x834D90   Offset: 0x833B90   Length: 0x534
    public void /*ctor*/()
    {
        long lVar1;
        long lVar2;
        ZhSegment.Initialize(this,0);
        lVar1 = il2cpp_internal(DAT_181e73cb8);
        FUN_1810f3480(lVar1,DAT_181e71270);
        if (lVar1 != null) {
          FUN_181769fe0(lVar1,0,DAT_181e713f0);
          FUN_181769fe0(lVar1,0,DAT_181e713f0);
          FUN_181769fe0(lVar1,0,DAT_181e713f0);
          FUN_181769fe0(lVar1,0,DAT_181e713f0);
          this.treasureLv = lVar1;
          lVar1 = il2cpp_internal(DAT_181e76ea8);
          FUN_1810f3480(lVar1,DAT_181e83230);
          if (lVar1 != null) {
            FUN_18175dba0(lVar1,0,DAT_181e83330);
            FUN_18175dba0(lVar1,0,DAT_181e83330);
            FUN_18175dba0(lVar1,0,DAT_181e83330);
            FUN_18175dba0(lVar1,0,DAT_181e83330);
            this.identifyDifficulty = lVar1;
            lVar1 = il2cpp_internal(DAT_181e71638);
            FUN_1810f3480(lVar1,DAT_181e624f8);
            if (lVar1 != null) {
              FUN_181660e60(lVar1,0,DAT_181e625f8);
              FUN_181660e60(lVar1,0,DAT_181e625f8);
              FUN_181660e60(lVar1,0,DAT_181e625f8);
              FUN_181660e60(lVar1,0,DAT_181e625f8);
              this.identified = lVar1;
              lVar1 = il2cpp_internal(DAT_181e6ffb8);
              FUN_1810f3480(lVar1,DAT_181e5a220);
              lVar2 = il2cpp_internal(DAT_181e73cb8);
              FUN_1810f3480(lVar2,DAT_181e71270);
              if (lVar2 != null) {
                FUN_181769fe0(lVar2,0,DAT_181e713f0);
                FUN_181769fe0(lVar2,1,DAT_181e713f0);
                FUN_181769fe0(lVar2,2,DAT_181e713f0);
                FUN_181769fe0(lVar2,3,DAT_181e713f0);
                FUN_181769fe0(lVar2,4,DAT_181e713f0);
                FUN_181769fe0(lVar2,5,DAT_181e713f0);
                if (lVar1 != null) {
                  FUN_18175de30(lVar1,lVar2,DAT_181e5a330);
                  lVar2 = il2cpp_internal(DAT_181e73cb8);
                  FUN_1810f3480(lVar2,DAT_181e71270);
                  if (lVar2 != null) {
                    FUN_181769fe0(lVar2,0,DAT_181e713f0);
                    FUN_181769fe0(lVar2,1,DAT_181e713f0);
                    FUN_181769fe0(lVar2,2,DAT_181e713f0);
                    FUN_181769fe0(lVar2,3,DAT_181e713f0);
                    FUN_181769fe0(lVar2,4,DAT_181e713f0);
                    FUN_181769fe0(lVar2,5,DAT_181e713f0);
                    FUN_18175de30(lVar1,lVar2,DAT_181e5a330);
                    lVar2 = il2cpp_internal(DAT_181e73cb8);
                    FUN_1810f3480(lVar2,DAT_181e71270);
                    if (lVar2 != null) {
                      FUN_181769fe0(lVar2,0,DAT_181e713f0);
                      FUN_181769fe0(lVar2,1,DAT_181e713f0);
                      FUN_181769fe0(lVar2,2,DAT_181e713f0);
                      FUN_181769fe0(lVar2,3,DAT_181e713f0);
                      FUN_181769fe0(lVar2,4,DAT_181e713f0);
                      FUN_181769fe0(lVar2,5,DAT_181e713f0);
                      FUN_18175de30(lVar1,lVar2,DAT_181e5a330);
                      lVar2 = il2cpp_internal(DAT_181e73cb8);
                      FUN_1810f3480(lVar2,DAT_181e71270);
                      if (lVar2 != null) {
                        FUN_181769fe0(lVar2,0,DAT_181e713f0);
                        FUN_181769fe0(lVar2,1,DAT_181e713f0);
                        FUN_181769fe0(lVar2,2,DAT_181e713f0);
                        FUN_181769fe0(lVar2,3,DAT_181e713f0);
                        FUN_181769fe0(lVar2,4,DAT_181e713f0);
                        FUN_181769fe0(lVar2,5,DAT_181e713f0);
                        FUN_18175de30(lVar1,lVar2,DAT_181e5a330);
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

    // Token : 0x6001313
    // RVA   : 0x834A90   Offset: 0x833890   Length: 0x2F2
    public virtual object Clone()
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        ulong uVar6;
        uint uVar7;
        long lVar8;
        lVar3 = new TreasureData(0);
        if (lVar3 != null) {
          *(uint8 *)(lVar3 + 16) = this.fullIdentified;
          *(uint32 *)(lVar3 + 20) = this.identifyKnowledgeNeed;
          lVar5 = this.treasureLv;
          if (lVar5 == null) {
            uVar4 = 0;
          }
          else {
            uVar4 = il2cpp_internal(DAT_181e73cb8);
            FUN_18177a7d0(uVar4,lVar5,DAT_181e712f0);
          }
          *(uint64 *)(lVar3 + 24) = uVar4;
          lVar5 = this.identifyDifficulty;
          if (lVar5 == null) {
            uVar4 = 0;
          }
          else {
            uVar4 = il2cpp_internal(DAT_181e76ea8);
            FUN_181768070(uVar4,lVar5,DAT_181e832b0);
          }
          *(uint64 *)(lVar3 + 32) = uVar4;
          lVar5 = this.identified;
          if (lVar5 == null) {
            uVar4 = 0;
          }
          else {
            uVar4 = il2cpp_internal(DAT_181e71638);
            FUN_18166a2f0(uVar4,lVar5,DAT_181e62578);
          }
          *(uint64 *)(lVar3 + 40) = uVar4;
          if (this.playerGuessTreasureLv == null) {
            *(uint64 *)(lVar3 + 48) = 0;
            return lVar3;
          }
          uVar1 = this.playerGuessTreasureLv.Count;
          uVar4 = new List_1(uVar1,DAT_181e5a2a8);
          *(uint64 *)(lVar3 + 48) = uVar4;
          lVar5 = this.playerGuessTreasureLv;
          uVar7 = 0;
          if (lVar5 != null) {
            lVar8 = 32;
            do {
              if (lVar5.Count <= (int)uVar7) {
                return lVar3;
              }
              lVar2 = *(int64 *)(lVar3 + 48);
              if (lVar5 == null) break;
              if (lVar5.Count <= uVar7) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (*(int64 *)(lVar8 + lVar5._items) == 0) {
                uVar6 = 0;
              }
              else {
                if (this.playerGuessTreasureLv == null) break;
                uVar4 = FUN_1800024b0(this.playerGuessTreasureLv,uVar7,DAT_181e5a4c8);
                uVar6 = il2cpp_internal(DAT_181e73cb8);
                FUN_18177a7d0(uVar6,uVar4,DAT_181e712f0);
              }
              if (lVar2 == null) break;
              FUN_18175de30(lVar2,uVar6,DAT_181e5a330);
              lVar5 = this.playerGuessTreasureLv;
              uVar7 = uVar7 + 1;
              lVar8 = lVar8 + 8;
            } while (lVar5 != null);
          }
        }
    }

}
