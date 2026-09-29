// ============================================================
// Type  : SpeEffectController
// Token : 0x2000363
// ============================================================

public class SpeEffectController
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600214F
    // RVA   : 0x98EDC0   Offset: 0x98E1C0   Length: 0xDB
    public void SmoothStart()
    {
        int iVar1;
        long lVar2;
        int iVar3;
        ulong[] local_res18 = new ulong[2];
        iVar3 = 0;
        local_res18[0] = 0;
        lVar2 = Component.get_transform(this,0);
        while (lVar2 != null) {
          iVar1 = Transform.get_childCount(lVar2,0);
          if (iVar1 <= iVar3) {
            return;
          }
          lVar2 = Component.get_transform(this,0);
          if (((lVar2 == null) || (lVar2 = Transform.GetChild(lVar2,iVar3,0)) == null) ||
             (lVar2 = Component.GetComponent(lVar2,DAT_181d94b78)) == null) break;
          local_res18[0] = FUN_1804651e0(lVar2,0);
          FUN_180464730(local_res18);
          iVar3 = iVar3 + 1;
          lVar2 = Component.get_transform(this);
        }
    }

    // Token : 0x6002150
    // RVA   : 0x98ECE0   Offset: 0x98E0E0   Length: 0xDB
    public void SmoothEnd()
    {
        int iVar1;
        long lVar2;
        int iVar3;
        ulong[] local_res18 = new ulong[2];
        iVar3 = 0;
        local_res18[0] = 0;
        lVar2 = Component.get_transform(this,0);
        while (lVar2 != null) {
          iVar1 = Transform.get_childCount(lVar2,0);
          if (iVar1 <= iVar3) {
            return;
          }
          lVar2 = Component.get_transform(this,0);
          if (((lVar2 == null) || (lVar2 = Transform.GetChild(lVar2,iVar3,0)) == null) ||
             (lVar2 = Component.GetComponent(lVar2)) == null) break;
          local_res18[0] = FUN_1804651e0(lVar2);
          FUN_180464730(local_res18);
          iVar3 = iVar3 + 1;
          lVar2 = Component.get_transform(this);
        }
    }

    // Token : 0x6002151
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
