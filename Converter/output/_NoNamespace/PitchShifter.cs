// ============================================================
// Type  : PitchShifter
// Token : 0x2000125
// ============================================================

public class PitchShifter
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000723
    public Range pitchRange;

    // Token: 0x4000724
    public AudioSource src;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60009A1
    // RVA   : 0x211050   Offset: 0x20FE50   Length: 0x42
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
            FUN_1818494f0(lVar2,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x60009A2
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
