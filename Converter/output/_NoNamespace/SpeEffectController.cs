// ============================================================
// Type  : SpeEffectController
// Token : 0x200035C
// ============================================================

public class SpeEffectController
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60020CE
    // RVA   : 0x97B9E0   Offset: 0x97A1E0   Length: 0xDB
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
             (lVar2 = Component.GetComponent(lVar2,DAT_181d6c340)) == null) break;
          local_res18[0] = FUN_1804651e0(lVar2,0);
          FUN_180464730(local_res18);
          iVar3 = iVar3 + 1;
          lVar2 = Component.get_transform(this);
        }
    }

    // Token : 0x60020CF
    // RVA   : 0x97B900   Offset: 0x97A100   Length: 0xDB
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

    // Token : 0x60020D0
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
