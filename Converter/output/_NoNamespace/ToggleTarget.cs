// ============================================================
// Type  : ToggleTarget
// Token : 0x20003AF
// ============================================================

public class ToggleTarget
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001E1A
    public List<GameObject> activateTarget;

    // Token: 0x4001E1B
    public List<GameObject> disactivateTarget;

    // Token: 0x4001E1C
    public bool noSound;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60023A9
    // RVA   : 0x815380   Offset: 0x814180   Length: 0x1B6
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
            if (lVar1 != null) goto LAB_180815470;
            break;
          }
          if (lVar1 == null) break;
          lVar1 = FUN_1800024b0(lVar1,plVar2,DAT_181e6bc70);
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
          lVar1 = FUN_1800024b0(lVar1,plVar2,DAT_181e6bc70);
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
        LAB_180815470:
          if (lVar1.Count <= (int)plVar2) {
            if ((isOn) && (!this.noSound)) {
              plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
              if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181e8f4a0)) {
                plVar4 = plVar2;
              }
              NGUITools.PlaySound(plVar4,0);
            }
            return;
          }
          if (lVar1 == null) break;
        }
    }

    // Token : 0x60023AA
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
