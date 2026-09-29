// ============================================================
// Type  : SpePoisonData
// Token : 0x20001DD
// ============================================================

public class SpePoisonData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000CA6
    public List<ItemData> material;

    // Token: 0x4000CA7
    public int leftTime;

    // Token: 0x4000CA8
    public bool finished;

    // Token: 0x4000CA9
    public ItemData result;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000ED0
    // RVA   : 0xC58BD0   Offset: 0xC57FD0   Length: 0xBF
    public void /*ctor*/()
    {
        long lVar1;
        ZhSegment.Initialize(this,0);
        lVar1 = il2cpp_internal(DAT_181d940e8);
        FUN_181330100(lVar1,DAT_181d909b0);
        if (lVar1 != null) {
          FUN_18181e6b0(lVar1,0,DAT_181d90ab0);
          FUN_18181e6b0(lVar1,0,DAT_181d90ab0);
          FUN_18181e6b0(lVar1,0,DAT_181d90ab0);
          this.material = lVar1;
          return;
        }
    }

    // Token : 0x6000ED1
    // RVA   : 0xC58B00   Offset: 0xC57F00   Length: 0xCB
    public void Reset()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d940e8);
        FUN_181330100(lVar1,DAT_181d909b0);
        if (lVar1 != null) {
          FUN_18181e6b0(lVar1,0,DAT_181d90ab0);
          FUN_18181e6b0(lVar1,0,DAT_181d90ab0);
          FUN_18181e6b0(lVar1,0,DAT_181d90ab0);
          this.material = lVar1;
          this.leftTime = 0;
          this.finished = 0;
          this.result = 0;
          return;
        }
    }

    // Token : 0x6000ED2
    // RVA   : 0xC589F0   Offset: 0xC57DF0   Length: 0x10E
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
                 (lVar1 = FUN_180002f80(this.material,uVar3,DAT_181d90f30)) == null)
              break;
              fVar4 = fVar4 + (float)*(int *)(lVar1 + 56);
            }
            lVar1 = this.material;
            uVar3 = uVar3 + 1;
            lVar2 = lVar2 + 8;
          } while (lVar1 != null);
        }
    }

    // Token : 0x6000ED3
    // RVA   : 0xC589B0   Offset: 0xC57DB0   Length: 0x3B
    public float GetScoreLv(int spePoisonType)
    {
        float fVar1;
        uint uVar2;
        fVar1 = (float)SpePoisonData.GetTotalScore(this,spePoisonType,0);
        uVar2 = Mathf.Max(0x3f800000,fVar1 * 0.05,0);
        Mathf.Log(uVar2,0x40000000,0);
    }

}
