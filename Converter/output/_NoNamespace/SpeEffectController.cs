// ============================================================
// Type  : SpeEffectController
// Token : 0x2000370
// ============================================================

public class SpeEffectController
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60021F9
    // RVA   : 0x6B6530   Offset: 0x6B5330   Length: 0xDB
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
             (lVar2 = Component.GetComponent(lVar2,DAT_181e77eb8)) == null) break;
          local_res18[0] = FUN_181040f40(lVar2,0);
          FUN_1818469b0(local_res18);
          iVar3 = iVar3 + 1;
          lVar2 = Component.get_transform(this);
        }
    }

    // Token : 0x60021FA
    // RVA   : 0x6B6450   Offset: 0x6B5250   Length: 0xDB
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
          local_res18[0] = FUN_181040f40(lVar2);
          FUN_1818469b0(local_res18);
          iVar3 = iVar3 + 1;
          lVar2 = Component.get_transform(this);
        }
    }

    // Token : 0x60021FB
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
