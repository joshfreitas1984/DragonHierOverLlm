// ============================================================
// Type  : UIShowControlScheme
// Token : 0x2000067
// ============================================================

public class UIShowControlScheme
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000295
    public GameObject target;

    // Token: 0x4000296
    public bool mouse;

    // Token: 0x4000297
    public bool touch;

    // Token: 0x4000298
    public bool controller;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000276
    // RVA   : 0x1705B80   Offset: 0x1704F80   Length: 0x1D2
    private void OnEnable()
    {
        ulong uVar1;
        bool cVar2;
        int iVar3;
        ulong uVar4;
        long lVar7;
        byte uVar8;
        uVar1 = UICamera.onSchemeChange;
        uVar4 = new OnTooltipCB(this,DAT_181dc6680,0);
        plVar5 = (int64 *)Delegate.Combine(uVar1,uVar4);
        plVar9 = (int64 *)0;
        if (plVar5 != (int64 *)0) {
          if (*plVar5 == DAT_181d8d6d0) {
            plVar9 = plVar5;
          }
          if (plVar9 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar5);
          }
        }
        UICamera.onSchemeChange = plVar9;
        uVar1 = this.target;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          iVar3 = UICamera.get_currentScheme(0);
          if (iVar3 == 0) {
            lVar7 = this.target;
            if (lVar7 == null) goto LAB_181705d4d;
            uVar8 = this.mouse;
          }
          else if (iVar3 == 1) {
            lVar7 = this.target;
            if (lVar7 == null) goto LAB_181705d4d;
            uVar8 = this.touch;
          }
          else {
            if (iVar3 != 2) {
              return;
            }
            lVar7 = this.target;
            if (lVar7 == null) {
        LAB_181705d4d:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar8 = this.controller;
          }
          GameObject.SetActive(lVar7,uVar8,0);
        }
    }

    // Token : 0x6000277
    // RVA   : 0x1705A80   Offset: 0x1704E80   Length: 0xFF
    private void OnDisable()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = UICamera.onSchemeChange;
        uVar2 = new OnTooltipCB(this,DAT_181dc6680,0);
        plVar3 = (int64 *)Delegate.Remove(uVar1,uVar2,0);
        plVar4 = (int64 *)0;
        if (plVar3 != (int64 *)0) {
          if (*plVar3 == DAT_181d8d6d0) {
            plVar4 = plVar3;
          }
          if (plVar4 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar3,DAT_181d8d6d0);
          }
        }
        UICamera.onSchemeChange = plVar4;
    }

    // Token : 0x6000278
    // RVA   : 0x1705D60   Offset: 0x1705160   Length: 0xFE
    private void OnScheme()
    {
        ulong uVar1;
        bool cVar2;
        int iVar3;
        uVar1 = this.target;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (!cVar2) {
          return;
        }
        iVar3 = UICamera.get_currentScheme(0);
        if (iVar3 == 0) {
          if (this.target != null) {
            GameObject.SetActive(this.target,this.mouse,0);
            return;
          }
        }
        else {
          if (iVar3 != 1) {
            if (iVar3 == 2) {
              if (this.target == null) throw; // [null/range check failed]
              GameObject.SetActive(this.target,this.controller,0);
            }
            return;
          }
          if (this.target != null) {
            GameObject.SetActive(this.target,this.touch,0);
            return;
          }
        }
    }

    // Token : 0x6000279
    // RVA   : 0x1705E60   Offset: 0x1705260   Length: 0xB
    public void /*ctor*/()
    {
        void FUN_181705e60(int64 this)
        {
        this.controller = 1;
        FUN_18044ef50(this,0);
    }

}
