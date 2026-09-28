// ============================================================
// Type  : GridSetComparer
// Token : 0x2000184
// ============================================================

public class GridSetComparer
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000A8B
    public static readonly GridSetComparer Instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000C9F
    // RVA   : 0x92A3D0   Offset: 0x9297D0   Length: 0x32
    public virtual bool Equals(GridUnitData a, GridUnitData b)
    {
        uint64 FUN_18092a3d0(uint64 this,int64 *a,int64 *b)
        {
        uint64 uVar1;
        if (a == b) {
          return true;
        }
        if ((a != (int64 *)0) && (b != (int64 *)0)) {
                          // WARNING: Could not recover jumptable at 0x00018092a3f5. Too many branches
                          // WARNING: Treating indirect jump as call
          uVar1 = (**(code **)(*a + 0x138))(a,b,*(uint64 *)(*a + 0x140));
          return uVar1;
        }
        return false;
    }

    // Token : 0x6000CA0
    // RVA   : 0x92A410   Offset: 0x929810   Length: 0x20
    public virtual int GetHashCode(GridUnitData obj)
    {
        if (obj != null) {
          return (*(int *)(obj + 16) * 31 + *(int *)(obj + 36)) * 31 +
                 *(int *)(obj + 40);
        }
    }

    // Token : 0x6000CA1
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6000CA2
    // RVA   : 0x92A440   Offset: 0x929840   Length: 0x59
    private static void /*cctor*/()
    {
        ulong uVar2;
        uVar2 = new ZhSegment(0);
        puVar1 = *(uint64 **)(DAT_181d78d48 + 184);
        *puVar1 = uVar2;
        il2cpp_internal(puVar1,uVar2);
    }

}
