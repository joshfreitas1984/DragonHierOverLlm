// ============================================================
// Type  : CFX_AutoDestructShuriken
// Token : 0x20003BF
// ============================================================

public class CFX_AutoDestructShuriken
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001E3D
    public bool OnlyDeactivate;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60023E1
    // RVA   : 0xB7E710   Offset: 0xB7DB10   Length: 0x3C
    private void OnEnable()
    {
        MonoBehaviour.StartCoroutine(this,"CheckIfAlive",0);
    }

    // Token : 0x60023E2
    // RVA   : 0xB7E6A0   Offset: 0xB7DAA0   Length: 0x6C
    private IEnumerator CheckIfAlive()
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          return lVar1;
        }
    }

    // Token : 0x60023E3
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
