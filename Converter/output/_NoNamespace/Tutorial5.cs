// ============================================================
// Type  : Tutorial5
// Token : 0x2000024
// ============================================================

public class Tutorial5
{
    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600007C
    // RVA   : 0xA66230   Offset: 0xA64A30   Length: 0xF3
    public void SetDurationToCurrentProgress()
    {
        var pStatics = *(int64*)(DAT_181d8ae58 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        uint uVar4;
        uint uVar5;
        lVar2 = FUN_180956bf0(this,DAT_181d700c0);
        uVar4 = 0;
        if (lVar2 != null) {
          while( true ) {
            if ((int)*(uint32 *)(lVar2 + 24) <= (int)uVar4) {
              return;
            }
            if (*(uint32 *)(lVar2 + 24) <= uVar4) {
              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar3,0);
            }
            lVar1 = lVar2[uVar4];
            if (*pStatics == 0) break;
            uVar5 = UIProgressBar.get_value(*pStatics,0);
            uVar5 = Mathf.Lerp(0x40000000,0x3f000000,uVar5,0);
            if (lVar1 == null) break;
            uVar4 = uVar4 + 1;
            *(uint32 *)(lVar1 + 48) = uVar5;
          }
        }
    }

    // Token : 0x600007D
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
