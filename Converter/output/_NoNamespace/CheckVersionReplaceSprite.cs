// ============================================================
// Type  : CheckVersionReplaceSprite
// Token : 0x20001BA
// ============================================================

public class CheckVersionReplaceSprite
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000BEF
    public Sprite replaceSprite;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E87
    // RVA   : 0x6F5160   Offset: 0x6F3F60   Length: 0xC6
    private void Start()
    {
        long lVar1;
        if (**(int **)(DAT_181e538e8 + 184) == 2) {
          lVar1 = Component.GetComponent(this,DAT_181e777b8);
          if (lVar1 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          Image.set_sprite(lVar1,this.replaceSprite,0);
        }
        Object.Destroy(this,0);
    }

    // Token : 0x6000E88
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
