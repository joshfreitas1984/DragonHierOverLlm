// ============================================================
// Type  : GridSetComparer
// Token : 0x2000186
// ============================================================

public class GridSetComparer
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000A98
    public static readonly GridSetComparer Instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000C9E
    // RVA   : 0x670310   Offset: 0x66F110   Length: 0x32
    public virtual bool Equals(GridUnitData a, GridUnitData b)
    {
        uint64 FUN_180670310(uint64 this,int64 *a,int64 *b)
        {
        uint64 uVar1;
        if (a == b) {
          return true;
        }
        if ((a != (int64 *)0) && (b != (int64 *)0)) {
                          // WARNING: Could not recover jumptable at 0x000180670335. Too many branches
                          // WARNING: Treating indirect jump as call
          uVar1 = (**(code **)(*a + 0x138))(a,b,*(uint64 *)(*a + 0x140));
          return uVar1;
        }
        return false;
    }

    // Token : 0x6000C9F
    // RVA   : 0x670350   Offset: 0x66F150   Length: 0x20
    public virtual int GetHashCode(GridUnitData obj)
    {
        if (obj != null) {
          return (*(int *)(obj + 16) * 31 + *(int *)(obj + 36)) * 31 +
                 *(int *)(obj + 40);
        }
    }

    // Token : 0x6000CA0
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6000CA1
    // RVA   : 0x670380   Offset: 0x66F180   Length: 0x59
    private static void /*cctor*/()
    {
        ulong uVar2;
        uVar2 = new ZhSegment(0);
        puVar1 = *(uint64 **)(DAT_181e58d90 + 184);
        *puVar1 = uVar2;
        il2cpp_internal(puVar1,uVar2);
    }

}
