// ============================================================
// Type  : ShakeCamStarter
// Token : 0x200034A
// ============================================================

public class ShakeCamStarter
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001A6A
    public ShakeStrengthType shakeStrength;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600207E
    // RVA   : 0x96AF10   Offset: 0x969710   Length: 0x53
    private void Start()
    {
        var pStatics = *(int64*)(DAT_181d7c9b8 + 184);
        if (*pStatics != 0) {
          ShakeCam.StartShake(*pStatics,this.shakeStrength,0,0);
          return;
        }
    }

    // Token : 0x600207F
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
