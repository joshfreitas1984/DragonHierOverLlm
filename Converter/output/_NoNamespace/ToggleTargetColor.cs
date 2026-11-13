// ============================================================
// Type  : ToggleTargetColor
// Token : 0x20003AC
// ============================================================

public class ToggleTargetColor
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001E12
    public GameObject target;

    // Token: 0x4001E13
    public Color onColor;

    // Token: 0x4001E14
    public Color offColor;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60023A5
    // RVA   : 0x815320   Offset: 0x814120   Length: 0x3E
    public void /*ctor*/()
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        byte[] local_18 = new byte[16];
        puVar4 = (uint32 *)FUN_180f24d00(local_18,0);
        uVar1 = puVar4[1];
        uVar2 = puVar4[2];
        uVar3 = puVar4[3];
        this.onColor = *puVar4;
        *(uint32 *)(this + 28) = uVar1;
        *(uint32 *)(this + 32) = uVar2;
        *(uint32 *)(this + 36) = uVar3;
        puVar4 = (uint32 *)FUN_180f24d00(local_18,0);
        uVar1 = puVar4[1];
        uVar2 = puVar4[2];
        uVar3 = puVar4[3];
        this.offColor = *puVar4;
        *(uint32 *)(this + 44) = uVar1;
        *(uint32 *)(this + 48) = uVar2;
        *(uint32 *)(this + 52) = uVar3;
        ZhSegment.Initialize(this,0);
    }

}
