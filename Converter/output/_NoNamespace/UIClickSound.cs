// ============================================================
// Type  : UIClickSound
// Token : 0x20003B8
// ============================================================

public class UIClickSound
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001E62
    public AudioClip audioClip;

    // Token: 0x4001E63
    public float volume;

    // Token: 0x4001E64
    public float pitch;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600240C
    // RVA   : 0x1136860   Offset: 0x1135660   Length: 0x84
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

    // Token : 0x600240D
    // RVA   : 0x11368F0   Offset: 0x11356F0   Length: 0x15
    public void /*ctor*/()
    {
        void FUN_1811368f0(int64 this)
        {
        this.volume = 0x3f800000;
        this.pitch = 0x3f800000;
        FUN_180ae8740(this,0);
    }

}
