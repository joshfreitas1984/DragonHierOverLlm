// ============================================================
// Type  : <>c__DisplayClass60_0
// Token : 0x2000241
// ============================================================

public class <>c__DisplayClass60_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001218
    public float[] stats;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001303
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6001304
    // RVA   : 0x617720   Offset: 0x616520   Length: 0x88
    internal int <BuildHorseArmorDisplayName>b__0(int a, int b)
    {
        void c__DisplayClass60_0.BuildHorseArmorDisplayName_b__0
                     (int64 this,uint32 a,uint32 b)
        {
        float fVar1;
        int64 lVar2;
        uint64 uVar3;
        uint32 local_res10 [6];
        lVar2 = this.stats;
        local_res10[0] = a;
        if (lVar2 == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        if (*(uint32 *)(lVar2 + 24) <= b) {
          uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar3,0);
        }
        if (*(uint32 *)(lVar2 + 24) <= a) {
          uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1801e02d0(uVar3,0);
        }
        fVar1 = lVar2[a];
        if (lVar2[b] != fVar1) {
          Single.CompareTo(lVar2 + (int64)(int)b * 4 + 32,fVar1,0);
          return;
        }
        Int32.CompareTo(local_res10,b,0);
    }

}
