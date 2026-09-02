// ============================================================
// Type  : UIButtonOffset
// Token : 0x2000034
// ============================================================

public class UIButtonOffset
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40000EF
    public Transform tweenTarget;

    // Token: 0x40000F0
    public Vector3 hover;

    // Token: 0x40000F1
    public Vector3 pressed;

    // Token: 0x40000F2
    public float duration;

    // Token: 0x40000F3
    private Vector3 mPos;

    // Token: 0x40000F4
    private bool mStarted;

    // Token: 0x40000F5
    private bool mPressed;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60000CC
    // RVA   : 0x13BF7E0   Offset: 0x13BDFE0   Length: 0xC4
    private void Start()
    {
        bool cVar1;
        ulong uVar2;
        byte[] local_18 = new byte[16];
        if (!this.mStarted) {
          this.mStarted = 1;
          uVar2 = this.tweenTarget;
          cVar1 = Object.op_Equality(uVar2,0,0);
          if (cVar1) {
            uVar2 = Component.get_transform(this,0);
            this.tweenTarget = uVar2;
          }
          if (this.tweenTarget == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          puVar3 = (uint64 *)Transform.get_localPosition(local_18,this.tweenTarget,0);
          this.mPos = *puVar3;
          *(uint32 *)(this + 68) = *(uint32 *)(puVar3 + 1);
        }
    }

    // Token : 0x60000CD
    // RVA   : 0x13BF410   Offset: 0x13BDC10   Length: 0x7E
    private void OnEnable()
    {
        ulong uVar1;
        byte uVar2;
        if (this.mStarted) {
          uVar1 = Component.get_gameObject(this,0);
          uVar2 = UICamera.IsHighlighted(uVar1,0);
          UIButtonOffset.OnHover(this,uVar2,0);
        }
    }

    // Token : 0x60000CE
    // RVA   : 0x13BF1E0   Offset: 0x13BD9E0   Length: 0xFE
    private void OnDisable()
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        ulong local_18;
        uint local_10;
        if (this.mStarted) {
          uVar1 = this.tweenTarget;
          cVar2 = Object.op_Inequality(uVar1,0,0);
          if (cVar2) {
            if (this.tweenTarget == null) {
        LAB_1813bf2d9:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar3 = Component.GetComponent(this.tweenTarget,DAT_181d6dbc0);
            cVar2 = Object.op_Inequality(lVar3,0,0);
            if (cVar2) {
              if (lVar3 == null) goto LAB_1813bf2d9;
              local_18 = this.mPos;
              local_10 = *(uint32 *)(this + 68);
              TweenPosition.set_value(lVar3,&local_18,0);
              Behaviour.set_enabled(lVar3,0,0);
            }
          }
        }
    }

    // Token : 0x60000CF
    // RVA   : 0x13BF590   Offset: 0x13BDD90   Length: 0x1BF
    private void OnPress(bool isPressed)
    {
        uint uVar1;
        bool cVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        ulong uVar6;
        float fVar7;
        ulong local_38;
        float local_30;
        float local_20;
        this.mPressed = isPressed;
        cVar2 = Behaviour.get_enabled(this,0);
        if (!cVar2) {
          return;
        }
        if (!this.mStarted) {
          UIButtonOffset.Start(this,0);
        }
        if (this.tweenTarget == null) throw; // [null/range check failed]
        uVar3 = Component.get_gameObject(this.tweenTarget,0);
        uVar1 = this.duration;
        if (!isPressed) {
          uVar4 = Component.get_gameObject(this,0);
          cVar2 = UICamera.IsHighlighted(uVar4,0);
          if (cVar2) {
            uVar6 = this.mPos;
            uVar4 = this.hover;
            fVar7 = (float)((uint64)uVar6 >> 32) + (float)((uint64)uVar4 >> 32);
            local_30 = *(float *)(this + 68) + *(float *)(this + 40);
            goto LAB_1813bf65b;
          }
          local_38 = this.mPos;
          local_30 = *(float *)(this + 68);
        }
        else {
          uVar4 = this.pressed;
          uVar6 = this.mPos;
          fVar7 = (float)((uint64)uVar6 >> 32) + (float)((uint64)uVar4 >> 32);
          local_30 = *(float *)(this + 68) + *(float *)(this + 52);
        LAB_1813bf65b:
          local_38 = CONCAT44(fVar7,(float)uVar6 + (float)uVar4);
          local_20 = local_30;
        }
        lVar5 = TweenPosition.Begin(uVar3,uVar1,&local_38,0);
        if (lVar5 != null) {
          *(uint32 *)(lVar5 + 24) = 3;
          return;
        }
    }

    // Token : 0x60000D0
    // RVA   : 0x13BF490   Offset: 0x13BDC90   Length: 0xF3
    private void OnHover(bool isOver)
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        ulong local_28;
        float local_20;
        float local_10;
        cVar1 = Behaviour.get_enabled(this,0);
        if (!cVar1) {
          return;
        }
        if (!this.mStarted) {
          UIButtonOffset.Start(this,0);
        }
        if (this.tweenTarget != null) {
          uVar2 = Component.get_gameObject(this.tweenTarget,0);
          if (!isOver) {
            local_28 = this.mPos;
            local_20 = *(float *)(this + 68);
          }
          else {
            local_20 = *(float *)(this + 68) + *(float *)(this + 40);
            local_28 = CONCAT44((float)((uint64)this.mPos >> 32) +
                                (float)((uint64)this.hover >> 32),
                                (float)this.mPos +
                                (float)this.hover);
            local_10 = local_20;
          }
          lVar3 = TweenPosition.Begin(uVar2,this.duration,&local_28,0);
          if (lVar3 != null) {
            *(uint32 *)(lVar3 + 24) = 3;
            return;
          }
        }
    }

    // Token : 0x60000D1
    // RVA   : 0x13BF340   Offset: 0x13BDB40   Length: 0xC6
    private void OnDragOver()
    {
        ulong uVar1;
        long lVar2;
        ulong local_28;
        float local_20;
        float local_10;
        if (!this.mPressed) {
          return;
        }
        if (this.tweenTarget != null) {
          uVar1 = Component.get_gameObject(this.tweenTarget,0);
          local_20 = *(float *)(this + 68) + *(float *)(this + 40);
          local_28 = CONCAT44((float)((uint64)this.mPos >> 32) +
                              (float)((uint64)this.hover >> 32),
                              (float)this.hover +
                              (float)this.mPos);
          local_10 = local_20;
          lVar2 = TweenPosition.Begin(uVar1,this.duration,&local_28,0);
          if (lVar2 != null) {
            *(uint32 *)(lVar2 + 24) = 3;
            return;
          }
        }
    }

    // Token : 0x60000D2
    // RVA   : 0x13BF2E0   Offset: 0x13BDAE0   Length: 0x5D
    private void OnDragOut()
    {
        ulong uVar1;
        long lVar2;
        ulong local_18;
        uint local_10;
        if (!this.mPressed) {
          return;
        }
        if (this.tweenTarget != null) {
          uVar1 = Component.get_gameObject(this.tweenTarget,0);
          local_10 = *(uint32 *)(this + 68);
          local_18 = this.mPos;
          lVar2 = TweenPosition.Begin(uVar1,this.duration,&local_18,0);
          if (lVar2 != null) {
            *(uint32 *)(lVar2 + 24) = 3;
            return;
          }
        }
    }

    // Token : 0x60000D3
    // RVA   : 0x13BF750   Offset: 0x13BDF50   Length: 0x81
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
          UIButtonOffset.OnHover(this,isSelected,0);
        }
    }

    // Token : 0x60000D4
    // RVA   : 0x13BF8B0   Offset: 0x13BE0B0   Length: 0x62
    public void /*ctor*/()
    {
        byte[] local_18 = new byte[8];
        uint local_10;
        puVar1 = (uint64 *)Vector3.get_zero(local_18,0);
        this.hover = *puVar1;
        local_10 = 0;
        *(uint32 *)(this + 40) = *(uint32 *)(puVar1 + 1);
        this.pressed = 0xc000000040000000;
        *(uint32 *)(this + 52) = 0;
        this.duration = 0x3e4ccccd;
        FUN_18044ef50(this,0);
    }

}
