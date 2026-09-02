// ============================================================
// Type  : SpePoisonData
// Token : 0x20001D7
// ============================================================

public class SpePoisonData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C19
    public List<ItemData> material;

    // Token: 0x4000C1A
    public int leftTime;

    // Token: 0x4000C1B
    public bool finished;

    // Token: 0x4000C1C
    public ItemData result;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E9B
    // RVA   : 0xC690C0   Offset: 0xC678C0   Length: 0xBF
    public void /*ctor*/()
    {
        long lVar1;
        ZhSegment.Initialize(this,0);
        lVar1 = il2cpp_internal(DAT_181d6f430);
        FUN_180f58a90(lVar1,DAT_181d691f0);
        if (lVar1 != null) {
          FUN_181827900(lVar1,0,DAT_181d692f0);
          FUN_181827900(lVar1,0,DAT_181d692f0);
          FUN_181827900(lVar1,0,DAT_181d692f0);
          this.material = lVar1;
          return;
        }
    }

    // Token : 0x6000E9C
    // RVA   : 0xC68FF0   Offset: 0xC677F0   Length: 0xCB
    public void Reset()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d6f430);
        FUN_180f58a90(lVar1,DAT_181d691f0);
        if (lVar1 != null) {
          FUN_181827900(lVar1,0,DAT_181d692f0);
          FUN_181827900(lVar1,0,DAT_181d692f0);
          FUN_181827900(lVar1,0,DAT_181d692f0);
          this.material = lVar1;
          this.leftTime = 0;
          this.finished = 0;
          this.result = 0;
          return;
        }
    }

    // Token : 0x6000E9D
    // RVA   : 0xC68EE0   Offset: 0xC676E0   Length: 0x10E
    public float GetTotalScore(int spePoisonType)
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        float fVar4;
        lVar1 = this.material;
        uVar3 = 0;
        fVar4 = 0.0;
        if (lVar1 != null) {
          lVar2 = 32;
          do {
            if (lVar1.Count <= (int)uVar3) {
              if (spePoisonType == null) {
                fVar4 = fVar4 * 0.5;
              }
              else {
                fVar4 = fVar4 * 1.0;
              }
              return fVar4;
            }
            if (lVar1 == null) break;
            if (lVar1.Count <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(int64 *)(lVar2 + lVar1._items) != 0) {
              if ((this.material == null) ||
                 (lVar1 = FUN_180002f80(this.material,uVar3,DAT_181d69770)) == null)
              break;
              fVar4 = fVar4 + (float)*(int *)(lVar1 + 56);
            }
            lVar1 = this.material;
            uVar3 = uVar3 + 1;
            lVar2 = lVar2 + 8;
          } while (lVar1 != null);
        }
    }

    // Token : 0x6000E9E
    // RVA   : 0xC68DA0   Offset: 0xC675A0   Length: 0x130
    public float GetScoreLv(int spePoisonType)
    {
        long lVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        float fVar5;
        float fVar6;
        lVar1 = this.material;
        uVar2 = 0;
        fVar6 = 0.0;
        if (lVar1 != null) {
          lVar3 = 32;
          do {
            if (lVar1.Count <= (int)uVar2) {
              if (spePoisonType == null) {
                fVar5 = 0.5;
              }
              else {
                fVar5 = 1.0;
              }
              uVar4 = Mathf.Max(uVar2,fVar5 * fVar6 * 0.05,0);
              Mathf.Log(uVar4,0x40000000,0);
              return;
            }
            if (lVar1 == null) break;
            if (lVar1.Count <= uVar2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(int64 *)(lVar3 + lVar1._items) != 0) {
              if ((this.material == null) ||
                 (lVar1 = FUN_180002f80(this.material,uVar2)) == null) break;
              fVar6 = fVar6 + (float)*(int *)(lVar1 + 56);
            }
            lVar1 = this.material;
            uVar2 = uVar2 + 1;
            lVar3 = lVar3 + 8;
          } while (lVar1 != null);
        }
    }

}
