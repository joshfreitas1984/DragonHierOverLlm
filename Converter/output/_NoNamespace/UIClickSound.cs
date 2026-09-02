// ============================================================
// Type  : UIClickSound
// Token : 0x20003A4
// ============================================================

public class UIClickSound
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001CCA
    public AudioClip audioClip;

    // Token: 0x4001CCB
    public float volume;

    // Token: 0x4001CCC
    public float pitch;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60022E0
    // RVA   : 0x13D3160   Offset: 0x13D1960   Length: 0x84
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

    // Token : 0x60022E1
    // RVA   : 0x13D31F0   Offset: 0x13D19F0   Length: 0x15
    public void /*ctor*/()
    {
        void FUN_1813d31f0(int64 this)
        {
        this.volume = 0x3f800000;
        this.pitch = 0x3f800000;
        FUN_18044ef50(this,0);
    }

}
