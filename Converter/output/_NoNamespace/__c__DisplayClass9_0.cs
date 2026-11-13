// ============================================================
// Type  : <>c__DisplayClass9_0
// Token : 0x2000490
// ============================================================

public class <>c__DisplayClass9_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40021D5
    public Material target;

    // Token: 0x40021D6
    public int propertyID;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002804
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6002805
    // RVA   : 0x6804A0   Offset: 0x67F2A0   Length: 0x24
    internal Vector2 <DOTiling>b__0()
    {
        if (this.target != null) {
          Material.GetTextureScale(this.target,this.propertyID,0);
          return;
        }
    }

    // Token : 0x6002806
    // RVA   : 0x6804D0   Offset: 0x67F2D0   Length: 0x27
    internal void <DOTiling>b__1(Vector2 x)
    {
        if (this.target != null) {
          FUN_180f33b90(this.target,this.propertyID,x,0);
          return;
        }
    }

}
