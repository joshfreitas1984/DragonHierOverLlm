// ============================================================
// Type  : UIDragDropContainer
// Token : 0x200003B
// ============================================================

public class UIDragDropContainer
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000105
    public Transform reparentTarget;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60000F7
    // RVA   : 0x1139480   Offset: 0x1138280   Length: 0x8B
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

    // Token : 0x60000F8
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
