// ============================================================
// Type  : Touch
// Token : 0x20000EE
// ============================================================

public class Touch
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40005A5
    public int fingerId;

    // Token: 0x40005A6
    public TouchPhase phase;

    // Token: 0x40005A7
    public Vector2 position;

    // Token: 0x40005A8
    public int tapCount;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000766
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

}
