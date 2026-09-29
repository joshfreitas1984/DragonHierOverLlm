// ============================================================
// Type  : UIDragDropContainer
// Token : 0x200003C
// ============================================================

public class UIDragDropContainer
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000125
    public Transform reparentTarget;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000110
    // RVA   : 0x12B26F0   Offset: 0x12B1AF0   Length: 0x8B
    protected virtual void Start()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = this.reparentTarget;
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          uVar2 = Component.get_transform(this,0);
          this.reparentTarget = uVar2;
        }
    }

    // Token : 0x6000111
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
