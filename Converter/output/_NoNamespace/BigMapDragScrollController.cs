// ============================================================
// Type  : BigMapDragScrollController
// Token : 0x200018F
// ============================================================

public class BigMapDragScrollController
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000CE9
    // RVA   : 0x7ED860   Offset: 0x7EC060   Length: 0x5B
    public void OnDrag(Vector2 delta)
    {
        var pStatics = *(int64*)(DAT_181d8bca8 + 184);
        if (*pStatics != 0) {
          BigMapSpriteController.OnDrag(*pStatics,delta,0);
          return;
        }
    }

    // Token : 0x6000CEA
    // RVA   : 0x7ED8C0   Offset: 0x7EC0C0   Length: 0x57
    public void OnScroll(float delta)
    {
        var pStatics = *(int64*)(DAT_181d8bca8 + 184);
        if (*pStatics != 0) {
          BigMapSpriteController.OnScroll(*pStatics,delta,0);
          return;
        }
    }

    // Token : 0x6000CEB
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
