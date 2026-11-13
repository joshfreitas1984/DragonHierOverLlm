// ============================================================
// Type  : HeroFaceData
// Token : 0x2000226
// ============================================================

public class HeroFaceData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001153
    public List<int> faceID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001260
    // RVA   : 0x894DD0   Offset: 0x893BD0   Length: 0x144
    public void /*ctor*/()
    {
        long lVar1;
        ZhSegment.Initialize(this,0);
        lVar1 = il2cpp_internal(DAT_181e73cb8);
        FUN_1810f3480(lVar1,DAT_181e71270);
        if (lVar1 != null) {
          FUN_181769fe0(lVar1,0xffffffff,DAT_181e713f0);
          FUN_181769fe0(lVar1,0xffffffff,DAT_181e713f0);
          FUN_181769fe0(lVar1,0xffffffff,DAT_181e713f0);
          FUN_181769fe0(lVar1,0xffffffff,DAT_181e713f0);
          FUN_181769fe0(lVar1,0xffffffff,DAT_181e713f0);
          FUN_181769fe0(lVar1,0xffffffff,DAT_181e713f0);
          FUN_181769fe0(lVar1,0xffffffff,DAT_181e713f0);
          FUN_181769fe0(lVar1,0xffffffff,DAT_181e713f0);
          FUN_181769fe0(lVar1,0xffffffff,DAT_181e713f0);
          this.faceID = lVar1;
          return;
        }
    }

    // Token : 0x6001261
    // RVA   : 0x894C30   Offset: 0x893A30   Length: 0xD8
    internal void OnDeserializedMethod(StreamingContext context)
    {
        int iVar1;
        long lVar2;
        lVar2 = this.faceID;
        while (lVar2 != null) {
          iVar1 = lVar2.Count;
          lVar2 = *(int64 *)(*(int64 *)(DAT_181e538e8 + 184) + 0x1f0);
          if (lVar2 == null) break;
          if (lVar2.Count <= iVar1) {
            return;
          }
          if (this.faceID == null) break;
          FUN_181769fe0(this.faceID,0xffffffff,DAT_181e713f0);
          lVar2 = this.faceID;
        }
    }

    // Token : 0x6001262
    // RVA   : 0x894D10   Offset: 0x893B10   Length: 0xB4
    public void Reset()
    {
        long lVar1;
        int iVar2;
        lVar1 = this.faceID;
        iVar2 = 0;
        do {
          if (lVar1 == null) {
        LAB_180894dbf:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          if (lVar1.Count <= iVar2) {
            FUN_181774110(lVar1,7,0xffffffff,DAT_181e71cf0);
            if (this.faceID != null) {
              FUN_181774110(this.faceID,8,0xffffffff,DAT_181e71cf0);
              return;
            }
            goto LAB_180894dbf;
          }
          if (lVar1 == null) goto LAB_180894dbf;
          FUN_181774110(lVar1,iVar2,0,DAT_181e71cf0);
          lVar1 = this.faceID;
          iVar2 = iVar2 + 1;
        } while( true );
    }

}
