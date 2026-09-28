// ============================================================
// Type  : UIDragDropRoot
// Token : 0x200003F
// ============================================================

public class UIDragDropRoot
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400013F
    public static Transform root;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600012B
    // RVA   : 0x12B4C00   Offset: 0x12B4000   Length: 0x4D
    private void OnEnable()
    {
        ulong uVar2;
        uVar2 = Component.get_transform(this,0);
        puVar1 = *(uint64 **)(DAT_181daf8f8 + 184);
        *puVar1 = uVar2;
        il2cpp_internal(puVar1,uVar2);
    }

    // Token : 0x600012C
    // RVA   : 0x12B4B50   Offset: 0x12B3F50   Length: 0xAA
    private void OnDisable()
    {
        ulong uVar1;
        bool cVar3;
        ulong uVar4;
        uVar1 = **(uint64 **)(DAT_181daf8f8 + 184);
        uVar4 = Component.get_transform(this,0);
        cVar3 = Object.op_Equality(uVar1,uVar4,0);
        if (cVar3) {
          puVar2 = *(uint64 **)(DAT_181daf8f8 + 184);
          *puVar2 = 0;
          il2cpp_internal(puVar2,0);
        }
    }

    // Token : 0x600012D
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
