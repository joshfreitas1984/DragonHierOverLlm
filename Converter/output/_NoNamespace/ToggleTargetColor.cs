// ============================================================
// Type  : ToggleTargetColor
// Token : 0x2000398
// ============================================================

public class ToggleTargetColor
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001C7A
    public GameObject target;

    // Token: 0x4001C7B
    public Color onColor;

    // Token: 0x4001C7C
    public Color offColor;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002279
    // RVA   : 0xAC63A0   Offset: 0xAC4BA0   Length: 0x3E
    public void /*ctor*/()
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        byte[] local_18 = new byte[16];
        puVar4 = (uint32 *)FUN_181098a50(local_18,0);
        uVar1 = puVar4[1];
        uVar2 = puVar4[2];
        uVar3 = puVar4[3];
        this.onColor = *puVar4;
        *(uint32 *)(this + 28) = uVar1;
        *(uint32 *)(this + 32) = uVar2;
        *(uint32 *)(this + 36) = uVar3;
        puVar4 = (uint32 *)FUN_181098a50(local_18,0);
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
