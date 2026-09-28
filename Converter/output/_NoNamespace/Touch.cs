// ============================================================
// Type  : Touch
// Token : 0x20000EF
// ============================================================

public class Touch
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40005C1
    public int fingerId;

    // Token: 0x40005C2
    public TouchPhase phase;

    // Token: 0x40005C3
    public Vector2 position;

    // Token: 0x40005C4
    public int tapCount;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600077E
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

}
