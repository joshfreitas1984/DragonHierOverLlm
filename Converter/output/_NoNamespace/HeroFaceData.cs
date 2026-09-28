// ============================================================
// Type  : HeroFaceData
// Token : 0x2000224
// ============================================================

public class HeroFaceData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400113D
    public List<int> faceID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001252
    // RVA   : 0xAF2730   Offset: 0xAF1B30   Length: 0x144
    public void /*ctor*/()
    {
        long lVar1;
        ZhSegment.Initialize(this,0);
        lVar1 = il2cpp_internal(DAT_181d93cd0);
        FUN_18132faf0(lVar1,DAT_181d8f098);
        if (lVar1 != null) {
          FUN_18182a0b0(lVar1,0xffffffff,DAT_181d8f218);
          FUN_18182a0b0(lVar1,0xffffffff,DAT_181d8f218);
          FUN_18182a0b0(lVar1,0xffffffff,DAT_181d8f218);
          FUN_18182a0b0(lVar1,0xffffffff,DAT_181d8f218);
          FUN_18182a0b0(lVar1,0xffffffff,DAT_181d8f218);
          FUN_18182a0b0(lVar1,0xffffffff,DAT_181d8f218);
          FUN_18182a0b0(lVar1,0xffffffff,DAT_181d8f218);
          FUN_18182a0b0(lVar1,0xffffffff,DAT_181d8f218);
          FUN_18182a0b0(lVar1,0xffffffff,DAT_181d8f218);
          this.faceID = lVar1;
          return;
        }
    }

    // Token : 0x6001253
    // RVA   : 0xAF2590   Offset: 0xAF1990   Length: 0xD8
    internal void OnDeserializedMethod(StreamingContext context)
    {
        int iVar1;
        long lVar2;
        lVar2 = this.faceID;
        while (lVar2 != null) {
          iVar1 = lVar2.Count;
          lVar2 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x1e8);
          if (lVar2 == null) break;
          if (lVar2.Count <= iVar1) {
            return;
          }
          if (this.faceID == null) break;
          FUN_18182a0b0(this.faceID,0xffffffff,DAT_181d8f218);
          lVar2 = this.faceID;
        }
    }

    // Token : 0x6001254
    // RVA   : 0xAF2670   Offset: 0xAF1A70   Length: 0xB4
    public void Reset()
    {
        long lVar1;
        int iVar2;
        lVar1 = this.faceID;
        iVar2 = 0;
        do {
          if (lVar1 == null) {
        LAB_180af271f:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (lVar1.Count <= iVar2) {
            FUN_181833d40(lVar1,7,0xffffffff,DAT_181d8fb18);
            if (this.faceID != null) {
              FUN_181833d40(this.faceID,8,0xffffffff,DAT_181d8fb18);
              return;
            }
            goto LAB_180af271f;
          }
          if (lVar1 == null) goto LAB_180af271f;
          FUN_181833d40(lVar1,iVar2,0,DAT_181d8fb18);
          lVar1 = this.faceID;
          iVar2 = iVar2 + 1;
        } while( true );
    }

}
