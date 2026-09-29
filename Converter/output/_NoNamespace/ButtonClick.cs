// ============================================================
// Type  : ButtonClick
// Token : 0x20001B2
// ============================================================

public class ButtonClick
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000BCA
    public UnityEvent leftClick;

    // Token: 0x4000BCB
    public UnityEvent middleClick;

    // Token: 0x4000BCC
    public UnityEvent rightClick;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E61
    // RVA   : 0xB7DBD0   Offset: 0xB7CFD0   Length: 0x47
    public virtual void OnPointerClick(PointerEventData eventData)
    {
        int iVar1;
        long lVar2;
        if (eventData != null) {
          iVar1 = *(int *)(eventData + 0x144);
          if (iVar1 == 0) {
            lVar2 = this.leftClick;
          }
          else if (iVar1 == 2) {
            lVar2 = this.middleClick;
          }
          else {
            if (iVar1 != 1) {
              return;
            }
            lVar2 = this.rightClick;
          }
          if (lVar2 != null) {
            UnityEvent.Invoke(lVar2,0);
            return;
          }
        }
    }

    // Token : 0x6000E62
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
