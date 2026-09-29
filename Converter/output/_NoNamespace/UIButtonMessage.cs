// ============================================================
// Type  : UIButtonMessage
// Token : 0x2000033
// ============================================================

public class UIButtonMessage
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40000FF
    public GameObject target;

    // Token: 0x4000100
    public string functionName;

    // Token: 0x4000101
    public Trigger trigger;

    // Token: 0x4000102
    public bool includeChildren;

    // Token: 0x4000103
    private bool mStarted;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60000DB
    // RVA   : 0x15311F0   Offset: 0x15305F0   Length: 0x5
    private void Start()
    {
        void FUN_1815311f0(int64 this)
        {
        this.mStarted = 1;
    }

    // Token : 0x60000DC
    // RVA   : 0x1530E40   Offset: 0x1530240   Length: 0xA7
    private void OnEnable()
    {
        ulong uVar1;
        bool cVar2;
        bool cVar3;
        if (this.mStarted) {
          uVar1 = Component.get_gameObject(this,0);
          cVar2 = UICamera.IsHighlighted(uVar1,0);
          cVar3 = Behaviour.get_enabled(this,0);
          if (cVar3) {
            if (!cVar2) {
              if (this.trigger != 2) {
                return;
              }
            }
            else if (this.trigger != 1) {
              return;
            }
            UIButtonMessage.Send(this,0);
          }
        }
    }

    // Token : 0x60000DD
    // RVA   : 0x1530EF0   Offset: 0x15302F0   Length: 0x4C
    private void OnHover(bool isOver)
    {
        bool cVar1;
        cVar1 = Behaviour.get_enabled(this,0);
        if (cVar1) {
          if (!isOver) {
            if (this.trigger != 2) {
              return;
            }
          }
          else if (this.trigger != 1) {
            return;
          }
          UIButtonMessage.Send(this,0);
        }
    }

    // Token : 0x60000DE
    // RVA   : 0x1530F40   Offset: 0x1530340   Length: 0x4C
    private void OnPress(bool isPressed)
    {
        bool cVar1;
        cVar1 = Behaviour.get_enabled(this,0);
        if (cVar1) {
          if (!isPressed) {
            if (this.trigger != 4) {
              return;
            }
          }
          else if (this.trigger != 3) {
            return;
          }
          UIButtonMessage.Send(this,0);
        }
    }

    // Token : 0x60000DF
    // RVA   : 0x1530F90   Offset: 0x1530390   Length: 0xA8
    private void OnSelect(bool isSelected)
    {
        bool cVar1;
        int iVar2;
        cVar1 = Behaviour.get_enabled(this,0);
        if (cVar1) {
          if (isSelected) {
            iVar2 = UICamera.get_currentScheme(0);
            if (iVar2 != 2) {
              return;
            }
          }
          cVar1 = Behaviour.get_enabled(this,0);
          if (cVar1) {
            if (!isSelected) {
              if (this.trigger != 2) {
                return;
              }
            }
            else if (this.trigger != 1) {
              return;
            }
            UIButtonMessage.Send(this,0);
          }
        }
    }

    // Token : 0x60000E0
    // RVA   : 0x1530DE0   Offset: 0x15301E0   Length: 0x2F
    private void OnClick()
    {
        bool cVar1;
        cVar1 = Behaviour.get_enabled(this,0);
        if ((cVar1) && (this.trigger == null)) {
          UIButtonMessage.Send(this,0);
          return;
        }
    }

    // Token : 0x60000E1
    // RVA   : 0x1530E10   Offset: 0x1530210   Length: 0x2F
    private void OnDoubleClick()
    {
        bool cVar1;
        cVar1 = Behaviour.get_enabled(this,0);
        if ((cVar1) && (this.trigger == 5)) {
          UIButtonMessage.Send(this,0);
          return;
        }
    }

    // Token : 0x60000E2
    // RVA   : 0x1531040   Offset: 0x1530440   Length: 0x1A9
    private void Send()
    {
        int iVar1;
        bool cVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        uint uVar7;
        cVar2 = FUN_180d75bc0(this.functionName,0);
        if (cVar2) {
          return;
        }
        uVar3 = this.target;
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (cVar2) {
          uVar3 = Component.get_gameObject(this,0);
          this.target = uVar3;
        }
        lVar5 = this.target;
        if (!this.includeChildren) {
          uVar3 = this.functionName;
          uVar4 = Component.get_gameObject(this,0);
          if (lVar5 != null) {
            GameObject.SendMessage(lVar5,uVar3,uVar4,1,0);
            return;
          }
        }
        else if (lVar5 != null) {
          lVar5 = FUN_180967b70(lVar5,DAT_181d753a0);
          uVar7 = 0;
          if (lVar5 != null) {
            iVar1 = *(int *)(lVar5 + 24);
            if (iVar1 < 1) {
              return;
            }
            while( true ) {
              if (*(uint32 *)(lVar5 + 24) <= uVar7) {
                uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar3,0);
              }
              lVar6 = lVar5[uVar7];
              if (lVar6 == null) break;
              lVar6 = Component.get_gameObject(lVar6,0);
              uVar3 = this.functionName;
              uVar4 = Component.get_gameObject(this,0);
              if (lVar6 == null) break;
              GameObject.SendMessage(lVar6,uVar3,uVar4,1,0);
              uVar7 = uVar7 + 1;
              if (iVar1 <= (int)uVar7) {
                return;
              }
            }
          }
        }
    }

    // Token : 0x60000E3
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
