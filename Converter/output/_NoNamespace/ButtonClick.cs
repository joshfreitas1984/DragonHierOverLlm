// ============================================================
// Type  : ButtonClick
// Token : 0x20001AC
// ============================================================

public class ButtonClick
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000B3E
    public UnityEvent leftClick;

    // Token: 0x4000B3F
    public UnityEvent middleClick;

    // Token: 0x4000B40
    public UnityEvent rightClick;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E2C
    // RVA   : 0xBD2C80   Offset: 0xBD1480   Length: 0x47
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

    // Token : 0x6000E2D
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
