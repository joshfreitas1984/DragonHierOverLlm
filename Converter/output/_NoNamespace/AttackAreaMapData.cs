// ============================================================
// Type  : AttackAreaMapData
// Token : 0x2000159
// ============================================================

public class AttackAreaMapData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40008B7
    public int mapWidth;

    // Token: 0x40008B8
    public int mapHeight;

    // Token: 0x40008B9
    public List<int> towerRow;

    // Token: 0x40008BA
    public int maxHeroNum;

    // Token: 0x40008BB
    public float extraHpRate;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000AF8
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

}
