// ============================================================
// Type  : UIButtonActivate
// Token : 0x200002E
// ============================================================

public class UIButtonActivate
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40000C8
    public GameObject target;

    // Token: 0x40000C9
    public bool state;

    // Token: 0x40000CA
    public bool pingPong;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60000AA
    // RVA   : 0x141B8D0   Offset: 0x141A6D0   Length: 0xC3
    public void OnClick()
    {
        byte uVar1;
        ulong uVar2;
        bool cVar3;
        uVar2 = this.target;
        cVar3 = Object.op_Inequality(uVar2,0,0);
        if (cVar3) {
          uVar2 = this.target;
          uVar1 = this.state;
          NGUITools.SetActive(uVar2,uVar1,0);
        }
        if (this.pingPong) {
          this.state = !this.state;
        }
    }

    // Token : 0x60000AB
    // RVA   : 0x141B9A0   Offset: 0x141A7A0   Length: 0xB
    public void /*ctor*/()
    {
        void FUN_18141b9a0(int64 this)
        {
        this.state = 1;
        FUN_180ae8740(this,0);
    }

}
