// ============================================================
// Type  : UIDragDropRoot
// Token : 0x200003E
// ============================================================

public class UIDragDropRoot
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400011F
    public static Transform root;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000112
    // RVA   : 0x113BFA0   Offset: 0x113ADA0   Length: 0x4D
    private void OnEnable()
    {
        ulong uVar2;
        uVar2 = Component.get_transform(this,0);
        puVar1 = *(uint64 **)(DAT_181e8fd50 + 184);
        *puVar1 = uVar2;
        il2cpp_internal(puVar1,uVar2);
    }

    // Token : 0x6000113
    // RVA   : 0x113BEF0   Offset: 0x113ACF0   Length: 0xAA
    private void OnDisable()
    {
        ulong uVar1;
        bool cVar3;
        ulong uVar4;
        uVar1 = **(uint64 **)(DAT_181e8fd50 + 184);
        uVar4 = Component.get_transform(this,0);
        cVar3 = Object.op_Equality(uVar1,uVar4,0);
        if (cVar3) {
          puVar2 = *(uint64 **)(DAT_181e8fd50 + 184);
          *puVar2 = 0;
          il2cpp_internal(puVar2,0);
        }
    }

    // Token : 0x6000114
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
