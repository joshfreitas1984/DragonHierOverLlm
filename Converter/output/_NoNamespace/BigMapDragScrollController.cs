// ============================================================
// Type  : BigMapDragScrollController
// Token : 0x2000195
// ============================================================

public class BigMapDragScrollController
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000D18
    // RVA   : 0x7EBBC0   Offset: 0x7EAFC0   Length: 0x5B
    public void OnDrag(Vector2 delta)
    {
        var pStatics = *(int64*)(DAT_181db0dc8 + 184);
        if (*pStatics != 0) {
          BigMapSpriteController.OnDrag(*pStatics,delta,0);
          return;
        }
    }

    // Token : 0x6000D19
    // RVA   : 0x7EBC20   Offset: 0x7EB020   Length: 0x57
    public void OnScroll(float delta)
    {
        var pStatics = *(int64*)(DAT_181db0dc8 + 184);
        if (*pStatics != 0) {
          BigMapSpriteController.OnScroll(*pStatics,delta,0);
          return;
        }
    }

    // Token : 0x6000D1A
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
