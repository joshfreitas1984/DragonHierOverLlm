// ============================================================
// Type  : CFX_AutoDestructShuriken
// Token : 0x20003CC
// ============================================================

public class CFX_AutoDestructShuriken
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001ECF
    public bool OnlyDeactivate;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600248B
    // RVA   : 0x9379C0   Offset: 0x9367C0   Length: 0x3C
    private void OnEnable()
    {
        MonoBehaviour.StartCoroutine(this,"CheckIfAlive",0);
    }

    // Token : 0x600248C
    // RVA   : 0x937950   Offset: 0x936750   Length: 0x6C
    private IEnumerator CheckIfAlive()
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          return lVar1;
        }
    }

    // Token : 0x600248D
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
