// ============================================================
// Type  : UIButtonMessage
// Token : 0x2000032
// ============================================================

public class UIButtonMessage
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40000E3
    public GameObject target;

    // Token: 0x40000E4
    public string functionName;

    // Token: 0x40000E5
    public Trigger trigger;

    // Token: 0x40000E6
    public bool includeChildren;

    // Token: 0x40000E7
    private bool mStarted;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60000C3
    // RVA   : 0x13BF1D0   Offset: 0x13BD9D0   Length: 0x5
    private void Start()
    {
        void FUN_1813bf1d0(int64 this)
        {
        this.mStarted = 1;
    }

    // Token : 0x60000C4
    // RVA   : 0x13BEE20   Offset: 0x13BD620   Length: 0xA7
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

    // Token : 0x60000C5
    // RVA   : 0x13BEED0   Offset: 0x13BD6D0   Length: 0x4C
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

    // Token : 0x60000C6
    // RVA   : 0x13BEF20   Offset: 0x13BD720   Length: 0x4C
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

    // Token : 0x60000C7
    // RVA   : 0x13BEF70   Offset: 0x13BD770   Length: 0xA8
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

    // Token : 0x60000C8
    // RVA   : 0x13BEDC0   Offset: 0x13BD5C0   Length: 0x2F
    private void OnClick()
    {
        bool cVar1;
        cVar1 = Behaviour.get_enabled(this,0);
        if ((cVar1) && (this.trigger == null)) {
          UIButtonMessage.Send(this,0);
          return;
        }
    }

    // Token : 0x60000C9
    // RVA   : 0x13BEDF0   Offset: 0x13BD5F0   Length: 0x2F
    private void OnDoubleClick()
    {
        bool cVar1;
        cVar1 = Behaviour.get_enabled(this,0);
        if ((cVar1) && (this.trigger == 5)) {
          UIButtonMessage.Send(this,0);
          return;
        }
    }

    // Token : 0x60000CA
    // RVA   : 0x13BF020   Offset: 0x13BD820   Length: 0x1A9
    private void Send()
    {
        int iVar1;
        bool cVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        uint uVar7;
        cVar2 = FUN_180d6ca90(this.functionName,0);
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
          lVar5 = FUN_180956bf0(lVar5,DAT_181da3030);
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

    // Token : 0x60000CB
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
