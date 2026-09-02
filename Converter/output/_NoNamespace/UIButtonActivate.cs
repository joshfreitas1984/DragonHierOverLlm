// ============================================================
// Type  : UIButtonActivate
// Token : 0x200002E
// ============================================================

public class UIButtonActivate
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40000CC
    public GameObject target;

    // Token: 0x40000CD
    public bool state;

    // Token: 0x40000CE
    public bool pingPong;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60000AB
    // RVA   : 0x13BD7F0   Offset: 0x13BBFF0   Length: 0xC3
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

    // Token : 0x60000AC
    // RVA   : 0x13BD8C0   Offset: 0x13BC0C0   Length: 0xB
    public void /*ctor*/()
    {
        void FUN_1813bd8c0(int64 this)
        {
        this.state = 1;
        FUN_18044ef50(this,0);
    }

}
