// ============================================================
// Type  : UIClickSound
// Token : 0x20003AB
// ============================================================

public class UIClickSound
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001DCF
    public AudioClip audioClip;

    // Token: 0x4001DD0
    public float volume;

    // Token: 0x4001DD1
    public float pitch;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002362
    // RVA   : 0x12AF4C0   Offset: 0x12AE8C0   Length: 0x84
    public virtual void OnPointerClick(PointerEventData eventData)
    {
        uint uVar1;
        uint uVar2;
        ulong uVar3;
        uVar3 = this.audioClip;
        uVar1 = this.volume;
        uVar2 = this.pitch;
        NGUITools.PlaySound(uVar3,uVar1,uVar2,0);
    }

    // Token : 0x6002363
    // RVA   : 0x12AF550   Offset: 0x12AE950   Length: 0x15
    public void /*ctor*/()
    {
        void FUN_1812af550(int64 this)
        {
        this.volume = 0x3f800000;
        this.pitch = 0x3f800000;
        FUN_18044ef50(this,0);
    }

}
