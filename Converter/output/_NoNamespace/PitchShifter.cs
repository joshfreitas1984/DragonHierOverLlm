// ============================================================
// Type  : PitchShifter
// Token : 0x2000126
// ============================================================

public class PitchShifter
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000743
    public Range pitchRange;

    // Token: 0x4000744
    public AudioSource src;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60009BA
    // RVA   : 0x46C9D0   Offset: 0x46BDD0   Length: 0x42
    private void Start()
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        lVar1 = this.pitchRange;
        lVar2 = this.src;
        if (lVar1 != null) {
          uVar3 = Random.Range(*(uint32 *)(lVar1 + 16),*(uint32 *)(lVar1 + 20),0);
          if (lVar2 != null) {
            FUN_180467590(lVar2,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x60009BB
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
