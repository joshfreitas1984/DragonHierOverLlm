// ============================================================
// Type  : UIButtonRotation
// Token : 0x2000035
// ============================================================

public class UIButtonRotation
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40000F6
    public Transform tweenTarget;

    // Token: 0x40000F7
    public Vector3 hover;

    // Token: 0x40000F8
    public Vector3 pressed;

    // Token: 0x40000F9
    public float duration;

    // Token: 0x40000FA
    private Quaternion mRot;

    // Token: 0x40000FB
    private bool mStarted;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60000D5
    // RVA   : 0x13BFDF0   Offset: 0x13BE5F0   Length: 0xBC
    private void Start()
    {
        bool cVar2;
        ulong uVar3;
        byte[] local_18 = new byte[16];
        if (!this.mStarted) {
          this.mStarted = 1;
          uVar3 = this.tweenTarget;
          cVar2 = Object.op_Equality(uVar3,0,0);
          if (cVar2) {
            uVar3 = Component.get_transform(this,0);
            this.tweenTarget = uVar3;
          }
          if (this.tweenTarget == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          puVar1 = (uint64 *)Transform.get_localRotation(local_18,this.tweenTarget,0);
          uVar3 = puVar1[1];
          this.mRot = *puVar1;
          *(uint64 *)(this + 68) = uVar3;
        }
    }

    // Token : 0x60000D6
    // RVA   : 0x13BFA20   Offset: 0x13BE220   Length: 0x7E
    private void OnEnable()
    {
        ulong uVar1;
        byte uVar2;
        if (this.mStarted) {
          uVar1 = Component.get_gameObject(this,0);
          uVar2 = UICamera.IsHighlighted(uVar1,0);
          UIButtonRotation.OnHover(this,uVar2,0);
        }
    }

    // Token : 0x60000D7
    // RVA   : 0x13BF920   Offset: 0x13BE120   Length: 0xF5
    private void OnDisable()
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        if (this.mStarted) {
          uVar1 = this.tweenTarget;
          cVar3 = Object.op_Inequality(uVar1,0,0);
          if (cVar3) {
            if (this.tweenTarget == null) {
        LAB_1813bfa10:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar2 = Component.GetComponent(this.tweenTarget,DAT_181d6dc40);
            cVar3 = Object.op_Inequality(lVar2,0,0);
            if (cVar3) {
              if (lVar2 == null) goto LAB_1813bfa10;
              local_18 = this.mRot;
              uStack_14 = *(uint32 *)(this + 64);
              uStack_10 = *(uint32 *)(this + 68);
              uStack_c = *(uint32 *)(this + 72);
              TweenRotation.set_value(lVar2,&local_18,0);
              Behaviour.set_enabled(lVar2,0,0);
            }
          }
        }
    }

    // Token : 0x60000D8
    // RVA   : 0x13BFBB0   Offset: 0x13BE3B0   Length: 0x1AF
    private void OnPress(bool isPressed)
    {
        uint uVar1;
        ulong uVar2;
        bool cVar3;
        ulong uVar4;
        ulong uVar7;
        long lVar8;
        uint uVar9;
        uint uVar10;
        uint uVar11;
        uint uVar12;
        ulong local_58;
        ulong uStack_50;
        ulong local_48;
        ulong uStack_40;
        byte[] local_38 = new byte[48];
        cVar3 = Behaviour.get_enabled(this,0);
        if (!cVar3) {
          return;
        }
        if (!this.mStarted) {
          UIButtonRotation.Start(this,0);
        }
        if (this.tweenTarget != null) {
          uVar4 = Component.get_gameObject(this.tweenTarget,0);
          uVar1 = this.duration;
          if (!isPressed) {
            uVar7 = Component.get_gameObject(this,0);
            cVar3 = UICamera.IsHighlighted(uVar7,0);
            if (!cVar3) {
              uVar9 = this.mRot;
              uVar10 = *(uint32 *)(this + 64);
              uVar11 = *(uint32 *)(this + 68);
              uVar12 = *(uint32 *)(this + 72);
            }
            else {
              local_58 = this.hover;
              uVar7 = this.mRot;
              uVar2 = *(uint64 *)(this + 68);
              uStack_50 = CONCAT44(uStack_50._4_4_,*(uint32 *)(this + 40));
              puVar5 = (uint64 *)Quaternion.Euler(local_38,&local_58,0);
              local_48 = *puVar5;
              uStack_40 = puVar5[1];
              local_58 = uVar7;
              uStack_50 = uVar2;
              puVar6 = (uint32 *)Quaternion.op_Multiply(local_38,&local_58,&local_48,0);
              uVar9 = *puVar6;
              uVar10 = puVar6[1];
              uVar11 = puVar6[2];
              uVar12 = puVar6[3];
            }
          }
          else {
            local_58 = this.pressed;
            uVar7 = this.mRot;
            uVar2 = *(uint64 *)(this + 68);
            uStack_50 = CONCAT44(uStack_50._4_4_,*(uint32 *)(this + 52));
            puVar5 = (uint64 *)Quaternion.Euler(&local_48,&local_58,0);
            local_58 = *puVar5;
            uStack_50 = puVar5[1];
            local_48 = uVar7;
            uStack_40 = uVar2;
            puVar6 = (uint32 *)Quaternion.op_Multiply(local_38,&local_48,&local_58,0);
            uVar9 = *puVar6;
            uVar10 = puVar6[1];
            uVar11 = puVar6[2];
            uVar12 = puVar6[3];
          }
          local_48 = CONCAT44(uVar10,uVar9);
          uStack_40 = CONCAT44(uVar12,uVar11);
          lVar8 = TweenRotation.Begin(uVar4,uVar1,&local_48,0);
          if (lVar8 != null) {
            *(uint32 *)(lVar8 + 24) = 3;
            return;
          }
        }
    }

    // Token : 0x60000D9
    // RVA   : 0x13BFAA0   Offset: 0x13BE2A0   Length: 0x102
    private void OnHover(bool isOver)
    {
        uint uVar1;
        ulong uVar2;
        ulong uVar5;
        ulong uVar6;
        bool cVar7;
        long lVar8;
        uint uVar9;
        uint uVar10;
        uint uVar11;
        uint uVar12;
        ulong local_58;
        uint uStack_50;
        uint32 uStack_4c;
        uint64 local_48;
        uint64 uStack_40;
        uint8 local_38 [48];
        cVar7 = Behaviour.get_enabled(this,0);
        if (!cVar7) {
          return;
        }
        if (!this.mStarted) {
          UIButtonRotation.Start(this,0);
        }
        if (this.tweenTarget != null) {
          uVar2 = Component.get_gameObject(this.tweenTarget,0);
          uVar1 = this.duration;
          if (!isOver) {
            uVar9 = this.mRot;
            uVar10 = *(uint32 *)(this + 64);
            uVar11 = *(uint32 *)(this + 68);
            uVar12 = *(uint32 *)(this + 72);
          }
          else {
            uStack_50 = *(uint32 *)(this + 40);
            local_58 = this.hover;
            uVar5 = this.mRot;
            uVar6 = *(uint64 *)(this + 68);
            puVar3 = (uint64 *)Quaternion.Euler(&local_48,&local_58,0);
            local_58 = *puVar3;
            uStack_50 = *(uint32 *)(puVar3 + 1);
            uStack_4c = *(uint32 *)((int64)puVar3 + 12);
            local_48 = uVar5;
            uStack_40 = uVar6;
            puVar4 = (uint32 *)Quaternion.op_Multiply(local_38,&local_48,&local_58,0);
            uVar9 = *puVar4;
            uVar10 = puVar4[1];
            uVar11 = puVar4[2];
            uVar12 = puVar4[3];
          }
          local_48 = CONCAT44(uVar10,uVar9);
          uStack_40 = CONCAT44(uVar12,uVar11);
          lVar8 = TweenRotation.Begin(uVar2,uVar1,&local_48,0);
          if (lVar8 != null) {
            *(uint32 *)(lVar8 + 24) = 3;
            return;
          }
        }
    }

    // Token : 0x60000DA
    // RVA   : 0x13BFD60   Offset: 0x13BE560   Length: 0x81
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
          UIButtonRotation.OnHover(this,isSelected,0);
        }
    }

    // Token : 0x60000DB
    // RVA   : 0x13BFEB0   Offset: 0x13BE6B0   Length: 0x55
    public void /*ctor*/()
    {
        byte[] local_18 = new byte[16];
        puVar1 = (uint64 *)Vector3.get_zero(local_18,0);
        this.hover = *puVar1;
        *(uint32 *)(this + 40) = *(uint32 *)(puVar1 + 1);
        puVar1 = (uint64 *)Vector3.get_zero(local_18,0);
        this.pressed = *puVar1;
        *(uint32 *)(this + 52) = *(uint32 *)(puVar1 + 1);
        this.duration = 0x3e4ccccd;
        FUN_18044ef50(this,0);
    }

}
