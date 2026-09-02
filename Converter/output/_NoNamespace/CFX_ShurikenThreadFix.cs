// ============================================================
// Type  : CFX_ShurikenThreadFix
// Token : 0x20003BD
// ============================================================

public class CFX_ShurikenThreadFix
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001D3F
    private ParticleSystem[] systems;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600236F
    // RVA   : 0xBD59E0   Offset: 0xBD41E0   Length: 0xC4
    private void OnEnable()
    {
        long lVar1;
        ulong uVar2;
        uint uVar3;
        uVar2 = FUN_180956bf0(this,DAT_181d6fd40);
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

    // Token : 0x6002370
    // RVA   : 0xBD5AB0   Offset: 0xBD42B0   Length: 0x6C
    private IEnumerator WaitFrame()
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          return lVar1;
        }
    }

    // Token : 0x6002371
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
