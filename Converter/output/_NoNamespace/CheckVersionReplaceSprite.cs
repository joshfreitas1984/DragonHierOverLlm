// ============================================================
// Type  : CheckVersionReplaceSprite
// Token : 0x20001B2
// ============================================================

public class CheckVersionReplaceSprite
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000B52
    public Sprite replaceSprite;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E4E
    // RVA   : 0x9F3AD0   Offset: 0x9F22D0   Length: 0xC6
    private void Start()
    {
        long lVar1;
        if (**(int **)(DAT_181d4ef00 + 184) == 2) {
          lVar1 = Component.GetComponent(this,DAT_181d6bc40);
          if (lVar1 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          Image.set_sprite(lVar1,this.replaceSprite,0);
        }
        Object.Destroy(this,0);
    }

    // Token : 0x6000E4F
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
