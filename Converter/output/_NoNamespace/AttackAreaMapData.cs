// ============================================================
// Type  : AttackAreaMapData
// Token : 0x2000155
// ============================================================

public class AttackAreaMapData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000898
    public int mapWidth;

    // Token: 0x4000899
    public int mapHeight;

    // Token: 0x400089A
    public List<int> towerRow;

    // Token: 0x400089B
    public int maxHeroNum;

    // Token: 0x400089C
    public float extraHpRate;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000AD7
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

}
