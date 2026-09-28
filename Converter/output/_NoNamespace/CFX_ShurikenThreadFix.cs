// ============================================================
// Type  : CFX_ShurikenThreadFix
// Token : 0x20003C4
// ============================================================

public class CFX_ShurikenThreadFix
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001E49
    private ParticleSystem[] systems;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60023F2
    // RVA   : 0xB80270   Offset: 0xB7F670   Length: 0xC4
    private void OnEnable()
    {
        long lVar1;
        ulong uVar2;
        uint uVar3;
        uVar2 = FUN_1809674e0(this,DAT_181d98660);
        this.systems = uVar2;
        lVar1 = this.systems;
        uVar3 = 0;
        if (lVar1 != null) {
          while( true ) {
            if ((int)*(uint32 *)(lVar1 + 24) <= (int)uVar3) {
              MonoBehaviour.StartCoroutine(this,"WaitFrame",0);
              return;
            }
            if (*(uint32 *)(lVar1 + 24) <= uVar3) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            if (lVar1[uVar3] == 0) break;
            ParticleSystem.set_enableEmission();
            uVar3 = uVar3 + 1;
          }
        }
    }

    // Token : 0x60023F3
    // RVA   : 0xB80340   Offset: 0xB7F740   Length: 0x6C
    private IEnumerator WaitFrame()
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          return lVar1;
        }
    }

    // Token : 0x60023F4
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
