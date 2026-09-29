// ============================================================
// Type  : <>c__DisplayClass9_0
// Token : 0x2000483
// ============================================================

public class <>c__DisplayClass9_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002142
    public Material target;

    // Token: 0x4002143
    public int propertyID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600275A
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x600275B
    // RVA   : 0x93AE20   Offset: 0x93A220   Length: 0x24
    internal Vector2 <DOTiling>b__0()
    {
        if (this.target != null) {
          Material.GetTextureScale(this.target,this.propertyID,0);
          return;
        }
    }

    // Token : 0x600275C
    // RVA   : 0x93AE50   Offset: 0x93A250   Length: 0x27
    internal void <DOTiling>b__1(Vector2 x)
    {
        if (this.target != null) {
          FUN_1810e2a00(this.target,this.propertyID,x,0);
          return;
        }
    }

}
