// ============================================================
// Type  : HeroFaceData
// Token : 0x200021E
// ============================================================

public class HeroFaceData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400109A
    public List<int> faceID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001212
    // RVA   : 0xB31890   Offset: 0xB30090   Length: 0x144
    public void /*ctor*/()
    {
        long lVar1;
        ZhSegment.Initialize(this,0);
        lVar1 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(lVar1,DAT_181d678f8);
        if (lVar1 != null) {
          FUN_181814fa0(lVar1,0xffffffff,DAT_181d67a78);
          FUN_181814fa0(lVar1,0xffffffff,DAT_181d67a78);
          FUN_181814fa0(lVar1,0xffffffff,DAT_181d67a78);
          FUN_181814fa0(lVar1,0xffffffff,DAT_181d67a78);
          FUN_181814fa0(lVar1,0xffffffff,DAT_181d67a78);
          FUN_181814fa0(lVar1,0xffffffff,DAT_181d67a78);
          FUN_181814fa0(lVar1,0xffffffff,DAT_181d67a78);
          FUN_181814fa0(lVar1,0xffffffff,DAT_181d67a78);
          FUN_181814fa0(lVar1,0xffffffff,DAT_181d67a78);
          this.faceID = lVar1;
          return;
        }
    }

    // Token : 0x6001213
    // RVA   : 0xB316F0   Offset: 0xB2FEF0   Length: 0xD8
    internal void OnDeserializedMethod(StreamingContext context)
    {
        int iVar1;
        long lVar2;
        lVar2 = this.faceID;
        while (lVar2 != null) {
          iVar1 = lVar2.Count;
          lVar2 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x1e0);
          if (lVar2 == null) break;
          if (lVar2.Count <= iVar1) {
            return;
          }
          if (this.faceID == null) break;
          FUN_181814fa0(this.faceID,0xffffffff,DAT_181d67a78);
          lVar2 = this.faceID;
        }
    }

    // Token : 0x6001214
    // RVA   : 0xB317D0   Offset: 0xB2FFD0   Length: 0xB4
    public void Reset()
    {
        long lVar1;
        int iVar2;
        lVar1 = this.faceID;
        iVar2 = 0;
        do {
          if (lVar1 == null) {
        LAB_180b3187f:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (lVar1.Count <= iVar2) {
            FUN_18181e970(lVar1,7,0xffffffff,DAT_181d68370);
            if (this.faceID != null) {
              FUN_18181e970(this.faceID,8,0xffffffff,DAT_181d68370);
              return;
            }
            goto LAB_180b3187f;
          }
          if (lVar1 == null) goto LAB_180b3187f;
          FUN_18181e970(lVar1,iVar2,0,DAT_181d68370);
          lVar1 = this.faceID;
          iVar2 = iVar2 + 1;
        } while( true );
    }

}
