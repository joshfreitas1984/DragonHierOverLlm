// ============================================================
// Type  : <>c__DisplayClass9_0
// Token : 0x200047C
// ============================================================

public class <>c__DisplayClass9_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002037
    public Material target;

    // Token: 0x4002038
    public int propertyID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60026D7
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60026D8
    // RVA   : 0x8D8380   Offset: 0x8D6B80   Length: 0x24
    internal Vector2 <DOTiling>b__0()
    {
        if (this.target != null) {
          Material.GetTextureScale(this.target,this.propertyID,0);
          return;
        }
    }

    // Token : 0x60026D9
    // RVA   : 0x8D83B0   Offset: 0x8D6BB0   Length: 0x27
    internal void <DOTiling>b__1(Vector2 x)
    {
        if (this.target != null) {
          FUN_1810a78d0(this.target,this.propertyID,x,0);
          return;
        }
    }

}
