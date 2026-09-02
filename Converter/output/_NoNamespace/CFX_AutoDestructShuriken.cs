// ============================================================
// Type  : CFX_AutoDestructShuriken
// Token : 0x20003B8
// ============================================================

public class CFX_AutoDestructShuriken
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001D32
    public bool OnlyDeactivate;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600235E
    // RVA   : 0xBD37C0   Offset: 0xBD1FC0   Length: 0x3C
    private void OnEnable()
    {
        MonoBehaviour.StartCoroutine(this,"CheckIfAlive",0);
    }

    // Token : 0x600235F
    // RVA   : 0xBD3750   Offset: 0xBD1F50   Length: 0x6C
    private IEnumerator CheckIfAlive()
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          return lVar1;
        }
    }

    // Token : 0x6002360
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
