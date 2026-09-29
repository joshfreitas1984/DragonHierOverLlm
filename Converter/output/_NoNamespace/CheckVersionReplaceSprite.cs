// ============================================================
// Type  : CheckVersionReplaceSprite
// Token : 0x20001B8
// ============================================================

public class CheckVersionReplaceSprite
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000BDE
    public Sprite replaceSprite;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E83
    // RVA   : 0x996890   Offset: 0x995C90   Length: 0xC6
    private void Start()
    {
        long lVar1;
        if (**(int **)(DAT_181d73d40 + 184) == 2) {
          lVar1 = Component.GetComponent(this,DAT_181d94478);
          if (lVar1 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          Image.set_sprite(lVar1,this.replaceSprite,0);
        }
        Object.Destroy(this,0);
    }

    // Token : 0x6000E84
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
