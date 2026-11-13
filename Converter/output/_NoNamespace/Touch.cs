// ============================================================
// Type  : Touch
// Token : 0x20000EE
// ============================================================

public class Touch
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40005A1
    public int fingerId;

    // Token: 0x40005A2
    public TouchPhase phase;

    // Token: 0x40005A3
    public Vector2 position;

    // Token: 0x40005A4
    public int tapCount;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000765
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

}
