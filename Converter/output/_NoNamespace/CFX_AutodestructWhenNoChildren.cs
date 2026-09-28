// ============================================================
// Type  : CFX_AutodestructWhenNoChildren
// Token : 0x20003C2
// ============================================================

public class CFX_AutodestructWhenNoChildren
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60023EC
    // RVA   : 0xB7E150   Offset: 0xB7D550   Length: 0x87
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

    // Token : 0x60023ED
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
