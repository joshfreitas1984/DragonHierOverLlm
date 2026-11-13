// ============================================================
// Type  : ShakeCamStarter
// Token : 0x200035E
// ============================================================

public class ShakeCamStarter
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001BEA
    public ShakeStrengthType shakeStrength;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60021A7
    // RVA   : 0x6A5540   Offset: 0x6A4340   Length: 0x53
    private void Start()
    {
        var pStatics = *(int64*)(DAT_181e82048 + 184);
        if (*pStatics != 0) {
          ShakeCam.StartShake(*pStatics,this.shakeStrength,0,0);
          return;
        }
    }

    // Token : 0x60021A8
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
