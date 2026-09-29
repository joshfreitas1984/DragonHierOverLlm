// ============================================================
// Type  : <>c__DisplayClass8_0
// Token : 0x2000482
// ============================================================

public class <>c__DisplayClass8_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002140
    public Material target;

    // Token: 0x4002141
    public int propertyID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002757
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6002758
    // RVA   : 0x93A880   Offset: 0x939C80   Length: 0x24
    internal Vector2 <DOOffset>b__0()
    {
        if (this.target != null) {
          Material.GetTextureOffset(this.target,this.propertyID,0);
          return;
        }
    }

    // Token : 0x6002759
    // RVA   : 0x93A8B0   Offset: 0x939CB0   Length: 0x27
    internal void <DOOffset>b__1(Vector2 x)
    {
        if (this.target != null) {
          FUN_1810e2900(this.target,this.propertyID,x,0);
          return;
        }
    }

}
