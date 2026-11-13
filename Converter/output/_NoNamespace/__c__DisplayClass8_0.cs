// ============================================================
// Type  : <>c__DisplayClass8_0
// Token : 0x200048F
// ============================================================

public class <>c__DisplayClass8_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40021D3
    public Material target;

    // Token: 0x40021D4
    public int propertyID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002801
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6002802
    // RVA   : 0x680380   Offset: 0x67F180   Length: 0x24
    internal Vector2 <DOOffset>b__0()
    {
        if (this.target != null) {
          Material.GetTextureOffset(this.target,this.propertyID,0);
          return;
        }
    }

    // Token : 0x6002803
    // RVA   : 0x6803B0   Offset: 0x67F1B0   Length: 0x27
    internal void <DOOffset>b__1(Vector2 x)
    {
        if (this.target != null) {
          FUN_180f33a90(this.target,this.propertyID,x,0);
          return;
        }
    }

}
