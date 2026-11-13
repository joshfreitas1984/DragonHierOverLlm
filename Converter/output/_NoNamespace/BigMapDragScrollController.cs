// ============================================================
// Type  : BigMapDragScrollController
// Token : 0x2000197
// ============================================================

public class BigMapDragScrollController
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000D18
    // RVA   : 0x51DF30   Offset: 0x51CD30   Length: 0x5B
    public void OnDrag(Vector2 delta)
    {
        var pStatics = *(int64*)(DAT_181e91070 + 184);
        if (*pStatics != 0) {
          BigMapSpriteController.OnDrag(*pStatics,delta,0);
          return;
        }
    }

    // Token : 0x6000D19
    // RVA   : 0x51DF90   Offset: 0x51CD90   Length: 0x57
    public void OnScroll(float delta)
    {
        var pStatics = *(int64*)(DAT_181e91070 + 184);
        if (*pStatics != 0) {
          BigMapSpriteController.OnScroll(*pStatics,delta,0);
          return;
        }
    }

    // Token : 0x6000D1A
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
