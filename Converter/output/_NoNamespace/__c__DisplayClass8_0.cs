// ============================================================
// Type  : <>c__DisplayClass8_0
// Token : 0x200047B
// ============================================================

public class <>c__DisplayClass8_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002035
    public Material target;

    // Token: 0x4002036
    public int propertyID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60026D4
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60026D5
    // RVA   : 0x8D7D00   Offset: 0x8D6500   Length: 0x24
    internal Vector2 <DOOffset>b__0()
    {
        if (this.target != null) {
          Material.GetTextureOffset(this.target,this.propertyID,0);
          return;
        }
    }

    // Token : 0x60026D6
    // RVA   : 0x8D7D30   Offset: 0x8D6530   Length: 0x27
    internal void <DOOffset>b__1(Vector2 x)
    {
        if (this.target != null) {
          FUN_1810a77d0(this.target,this.propertyID,x,0);
          return;
        }
    }

}
