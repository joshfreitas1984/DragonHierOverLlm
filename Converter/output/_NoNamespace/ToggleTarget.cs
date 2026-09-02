// ============================================================
// Type  : ToggleTarget
// Token : 0x200039B
// ============================================================

public class ToggleTarget
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001C82
    public List<GameObject> activateTarget;

    // Token: 0x4001C83
    public List<GameObject> disactivateTarget;

    // Token: 0x4001C84
    public bool noSound;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600227D
    // RVA   : 0xAC6400   Offset: 0xAC4C00   Length: 0x1B6
    public void OnValueChanged(bool isOn)
    {
        long lVar1;
        ulong uVar3;
        plVar4 = (int64 *)0;
        lVar1 = this.activateTarget;
        plVar2 = plVar4;
        while (lVar1 != null) {
          if (lVar1.Count <= (int)plVar2) {
            lVar1 = this.disactivateTarget;
            plVar2 = plVar4;
            if (lVar1 != null) goto LAB_180ac64f0;
            break;
          }
          if (lVar1 == null) break;
          lVar1 = FUN_180002f80(lVar1,plVar2,DAT_181d62178);
          if (!isOn) {
            if (lVar1 == null) break;
            uVar3 = 0;
          }
          else {
            if (lVar1 == null) break;
            uVar3 = 1;
          }
          GameObject.SetActive(lVar1,uVar3,0);
          plVar2 = (int64 *)(uint64)((int)plVar2 + 1);
          lVar1 = this.activateTarget;
        }
        throw; // [null/range check failed]
        while( true ) {
          lVar1 = FUN_180002f80(lVar1,plVar2,DAT_181d62178);
          if (!isOn) {
            if (lVar1 == null) break;
            uVar3 = 1;
          }
          else {
            if (lVar1 == null) break;
            uVar3 = 0;
          }
          GameObject.SetActive(lVar1,uVar3,0);
          lVar1 = this.disactivateTarget;
          plVar2 = (int64 *)(uint64)((int)plVar2 + 1);
          if (lVar1 == null) break;
        LAB_180ac64f0:
          if (lVar1.Count <= (int)plVar2) {
            if ((isOn) && (!this.noSound)) {
              plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
              if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181d8a228)) {
                plVar4 = plVar2;
              }
              NGUITools.PlaySound(plVar4,0);
            }
            return;
          }
          if (lVar1 == null) break;
        }
    }

    // Token : 0x600227E
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
