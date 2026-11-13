// ============================================================
// Type  : UIButtonScale
// Token : 0x2000036
// ============================================================

public class UIButtonScale
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40000F8
    public Transform tweenTarget;

    // Token: 0x40000F9
    public Vector3 hover;

    // Token: 0x40000FA
    public Vector3 pressed;

    // Token: 0x40000FB
    public float duration;

    // Token: 0x40000FC
    private Vector3 mScale;

    // Token: 0x40000FD
    private bool mStarted;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60000DB
    // RVA   : 0x141E4C0   Offset: 0x141D2C0   Length: 0xC4
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
            FUN_1801e0300();
          }
          puVar3 = (uint64 *)Transform.get_localScale(local_18,this.tweenTarget,0);
          this.mScale = *puVar3;
          *(uint32 *)(this + 68) = *(uint32 *)(puVar3 + 1);
        }
    }

    // Token : 0x60000DC
    // RVA   : 0x141E0F0   Offset: 0x141CEF0   Length: 0x7E
    private void OnEnable()
    {
        ulong uVar1;
        byte uVar2;
        if (this.mStarted) {
          uVar1 = Component.get_gameObject(this,0);
          uVar2 = UICamera.IsHighlighted(uVar1,0);
          UIButtonScale.OnHover(this,uVar2,0);
        }
    }

    // Token : 0x60000DD
    // RVA   : 0x141DFF0   Offset: 0x141CDF0   Length: 0xFE
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
        LAB_18141e0e9:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar3 = Component.GetComponent(this.tweenTarget,DAT_181e79938);
            cVar2 = Object.op_Inequality(lVar3,0,0);
            if (cVar2) {
              if (lVar3 == null) goto LAB_18141e0e9;
              local_18 = this.mScale;
              local_10 = *(uint32 *)(this + 68);
              TweenScale.set_scale(lVar3,&local_18,0);
              Behaviour.set_enabled(lVar3,0,0);
            }
          }
        }
    }

    // Token : 0x60000DE
    // RVA   : 0x141E270   Offset: 0x141D070   Length: 0x1BB
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
        cVar2 = Behaviour.get_enabled(this,0);
        if (!cVar2) {
          return;
        }
        if (!this.mStarted) {
          UIButtonScale.Start(this,0);
        }
        if (this.tweenTarget == null) throw; // [null/range check failed]
        uVar3 = Component.get_gameObject(this.tweenTarget,0);
        uVar1 = this.duration;
        if (!isPressed) {
          uVar4 = Component.get_gameObject(this,0);
          cVar2 = UICamera.IsHighlighted(uVar4,0);
          if (cVar2) {
            uVar6 = this.mScale;
            uVar4 = this.hover;
            fVar7 = (float)((uint64)uVar6 >> 32) * (float)((uint64)uVar4 >> 32);
            local_30 = *(float *)(this + 68) * *(float *)(this + 40);
            goto LAB_18141e337;
          }
          local_38 = this.mScale;
          local_30 = *(float *)(this + 68);
        }
        else {
          uVar4 = this.pressed;
          uVar6 = this.mScale;
          fVar7 = (float)((uint64)uVar6 >> 32) * (float)((uint64)uVar4 >> 32);
          local_30 = *(float *)(this + 68) * *(float *)(this + 52);
        LAB_18141e337:
          local_38 = CONCAT44(fVar7,(float)uVar6 * (float)uVar4);
          local_20 = local_30;
        }
        lVar5 = TweenScale.Begin(uVar3,uVar1,&local_38,0);
        if (lVar5 != null) {
          *(uint32 *)(lVar5 + 24) = 3;
          return;
        }
    }

    // Token : 0x60000DF
    // RVA   : 0x141E170   Offset: 0x141CF70   Length: 0xF3
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
          UIButtonScale.Start(this,0);
        }
        if (this.tweenTarget != null) {
          uVar2 = Component.get_gameObject(this.tweenTarget,0);
          if (!isOver) {
            local_28 = this.mScale;
            local_20 = *(float *)(this + 68);
          }
          else {
            local_20 = *(float *)(this + 68) * *(float *)(this + 40);
            local_28 = CONCAT44((float)((uint64)this.mScale >> 32) *
                                (float)((uint64)this.hover >> 32),
                                (float)this.mScale *
                                (float)this.hover);
            local_10 = local_20;
          }
          lVar3 = TweenScale.Begin(uVar2,this.duration,&local_28,0);
          if (lVar3 != null) {
            *(uint32 *)(lVar3 + 24) = 3;
            return;
          }
        }
    }

    // Token : 0x60000E0
    // RVA   : 0x141E430   Offset: 0x141D230   Length: 0x81
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
          UIButtonScale.OnHover(this,isSelected,0);
        }
    }

    // Token : 0x60000E1
    // RVA   : 0x141E590   Offset: 0x141D390   Length: 0x5A
    public void /*ctor*/()
    {
        this.hover = 0x3f8ccccd3f8ccccd;
        *(uint32 *)(this + 40) = 0x3f8ccccd;
        this.pressed = 0x3f8666663f866666;
        *(uint32 *)(this + 52) = 0x3f866666;
        this.duration = 0x3e4ccccd;
        FUN_180ae8740(0x3f866666,0);
    }

}
