// ============================================================
// Type  : AnimatedColor
// Token : 0x20000B2
// ============================================================

public class AnimatedColor
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400043A
    public Color color;

    // Token: 0x400043B
    private UIWidget mWidget;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000567
    // RVA   : 0xA0D160   Offset: 0xA0B960   Length: 0x77
    private void OnEnable()
    {
        ulong uVar1;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        uVar1 = Component.GetComponent(this,DAT_181d6e7c0);
        this.mWidget = uVar1;
        if (this.mWidget != null) {
          local_18 = this.color;
          uStack_14 = *(uint32 *)(this + 28);
          uStack_10 = *(uint32 *)(this + 32);
          uStack_c = *(uint32 *)(this + 36);
          UIWidget.set_color(this.mWidget,&local_18,0);
          return;
        }
    }

    // Token : 0x6000568
    // RVA   : 0xA0D120   Offset: 0xA0B920   Length: 0x30
    private void LateUpdate()
    {
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        if (this.mWidget != null) {
          local_18 = this.color;
          uStack_14 = *(uint32 *)(this + 28);
          uStack_10 = *(uint32 *)(this + 32);
          uStack_c = *(uint32 *)(this + 36);
          UIWidget.set_color(this.mWidget,&local_18,0);
          return;
        }
    }

    // Token : 0x6000569
    // RVA   : 0xA0D1E0   Offset: 0xA0B9E0   Length: 0x2B
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
        this.color = *puVar4;
        *(uint32 *)(this + 28) = uVar1;
        *(uint32 *)(this + 32) = uVar2;
        *(uint32 *)(this + 36) = uVar3;
        FUN_18044ef50(this,0);
    }

}
