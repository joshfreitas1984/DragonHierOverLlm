// ============================================================
// Type  : CFX_AutodestructWhenNoChildren
// Token : 0x20003CF
// ============================================================

public class CFX_AutodestructWhenNoChildren
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002496
    // RVA   : 0x937AC0   Offset: 0x9368C0   Length: 0x87
    private void Update()
    {
        ulong uVar1;
        int iVar2;
        long lVar3;
        lVar3 = Component.get_transform(this,0);
        if (lVar3 != null) {
          iVar2 = Transform.get_childCount(lVar3,0);
          if (iVar2 == 0) {
            uVar1 = Component.get_gameObject(this,0);
            Object.Destroy(uVar1,0);
            return;
          }
          return;
        }
    }

    // Token : 0x6002497
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
