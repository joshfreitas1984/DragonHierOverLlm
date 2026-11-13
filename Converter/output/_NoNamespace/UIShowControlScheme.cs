// ============================================================
// Type  : UIShowControlScheme
// Token : 0x2000066
// ============================================================

public class UIShowControlScheme
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000275
    public GameObject target;

    // Token: 0x4000276
    public bool mouse;

    // Token: 0x4000277
    public bool touch;

    // Token: 0x4000278
    public bool controller;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600025D
    // RVA   : 0x1607EB0   Offset: 0x1606CB0   Length: 0x1D2
    private void OnEnable()
    {
        ulong uVar1;
        bool cVar2;
        int iVar3;
        ulong uVar4;
        long lVar7;
        byte uVar8;
        uVar1 = UICamera.onSchemeChange;
        uVar4 = new OnTooltipCB(this,DAT_181e52938,0);
        plVar5 = (int64 *)Delegate.Combine(uVar1,uVar4);
        plVar9 = (int64 *)0;
        if (plVar5 != (int64 *)0) {
          if (*plVar5 == DAT_181e6de90) {
            plVar9 = plVar5;
          }
          if (plVar9 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1801dfd50(plVar5);
          }
        }
        UICamera.onSchemeChange = plVar9;
        uVar1 = this.target;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          iVar3 = UICamera.get_currentScheme(0);
          if (iVar3 == 0) {
            lVar7 = this.target;
            if (lVar7 == null) goto LAB_18160807d;
            uVar8 = this.mouse;
          }
          else if (iVar3 == 1) {
            lVar7 = this.target;
            if (lVar7 == null) goto LAB_18160807d;
            uVar8 = this.touch;
          }
          else {
            if (iVar3 != 2) {
              return;
            }
            lVar7 = this.target;
            if (lVar7 == null) {
        LAB_18160807d:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            uVar8 = this.controller;
          }
          GameObject.SetActive(lVar7,uVar8,0);
        }
    }

    // Token : 0x600025E
    // RVA   : 0x1607DB0   Offset: 0x1606BB0   Length: 0xFF
    private void OnDisable()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = UICamera.onSchemeChange;
        uVar2 = new OnTooltipCB(this,DAT_181e52938,0);
        plVar3 = (int64 *)Delegate.Remove(uVar1,uVar2,0);
        plVar4 = (int64 *)0;
        if (plVar3 != (int64 *)0) {
          if (*plVar3 == DAT_181e6de90) {
            plVar4 = plVar3;
          }
          if (plVar4 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1801dfd50(plVar3,DAT_181e6de90);
          }
        }
        UICamera.onSchemeChange = plVar4;
    }

    // Token : 0x600025F
    // RVA   : 0x1608090   Offset: 0x1606E90   Length: 0xFE
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

    // Token : 0x6000260
    // RVA   : 0x1608190   Offset: 0x1606F90   Length: 0xB
    public void /*ctor*/()
    {
        void FUN_181608190(int64 this)
        {
        this.controller = 1;
        FUN_180ae8740(this,0);
    }

}
