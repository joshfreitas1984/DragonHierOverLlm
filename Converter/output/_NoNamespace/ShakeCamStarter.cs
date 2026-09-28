// ============================================================
// Type  : ShakeCamStarter
// Token : 0x2000351
// ============================================================

public class ShakeCamStarter
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B6B
    public ShakeStrengthType shakeStrength;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60020FF
    // RVA   : 0x97D8B0   Offset: 0x97CCB0   Length: 0x53
    private void Start()
    {
        var pStatics = *(int64*)(DAT_181da1be0 + 184);
        if (*pStatics != 0) {
          ShakeCam.StartShake(*pStatics,this.shakeStrength,0,0);
          return;
        }
    }

    // Token : 0x6002100
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
