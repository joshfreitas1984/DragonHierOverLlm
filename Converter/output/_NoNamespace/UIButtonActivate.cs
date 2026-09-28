// ============================================================
// Type  : UIButtonActivate
// Token : 0x200002F
// ============================================================

public class UIButtonActivate
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40000E8
    public GameObject target;

    // Token: 0x40000E9
    public bool state;

    // Token: 0x40000EA
    public bool pingPong;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60000C3
    // RVA   : 0x152F200   Offset: 0x152E600   Length: 0xC3
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

    // Token : 0x60000C4
    // RVA   : 0x152F2D0   Offset: 0x152E6D0   Length: 0xB
    public void /*ctor*/()
    {
        void FUN_18152f2d0(int64 this)
        {
        this.state = 1;
        FUN_18044ef50(this,0);
    }

}
