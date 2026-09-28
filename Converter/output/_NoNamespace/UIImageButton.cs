// ============================================================
// Type  : UIImageButton
// Token : 0x200004B
// ============================================================

public class UIImageButton
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40001A9
    public UISprite target;

    // Token: 0x40001AA
    public string normalSprite;

    // Token: 0x40001AB
    public string hoverSprite;

    // Token: 0x40001AC
    public string pressedSprite;

    // Token: 0x40001AD
    public string disabledSprite;

    // Token: 0x40001AE
    public bool pixelSnap;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000180
    // RVA   : 0x12C3DD0   Offset: 0x12C31D0   Length: 0x9D
    public bool get_isEnabled()
    {
        bool cVar1;
        long lVar2;
        lVar2 = Component.get_gameObject(this,0);
        if (lVar2 != null) {
          lVar2 = GameObject.GetComponent(lVar2,DAT_181dc80c8);
          cVar1 = Object.op_Implicit(lVar2,0);
          if (!cVar1) {
            return;
          }
          if (lVar2 != null) {
            Collider.get_enabled(lVar2,0);
            return;
          }
        }
    }

    // Token : 0x6000181
    // RVA   : 0x12C3E70   Offset: 0x12C3270   Length: 0xCC
    public void set_isEnabled(bool value)
    {
        bool cVar1;
        long lVar2;
        lVar2 = Component.get_gameObject(this,0);
        if (lVar2 != null) {
          lVar2 = GameObject.GetComponent(lVar2,DAT_181dc80c8);
          cVar1 = Object.op_Implicit(lVar2,0);
          if (cVar1) {
            if (lVar2 == null) throw; // [null/range check failed]
            cVar1 = Collider.get_enabled(lVar2,0);
            if (cVar1 != value) {
              Collider.set_enabled(lVar2,value,0);
              UIImageButton.UpdateImage(this,0);
            }
          }
          return;
        }
    }

    // Token : 0x6000182
    // RVA   : 0x12C3980   Offset: 0x12C2D80   Length: 0xA5
    private void OnEnable()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = this.target;
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          uVar2 = Component.GetComponentInChildren(this,DAT_181d97760);
          this.target = uVar2;
        }
        UIImageButton.UpdateImage(this,0);
    }

    // Token : 0x6000183
    // RVA   : 0x12C3AF0   Offset: 0x12C2EF0   Length: 0x124
    private void OnValidate()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.target;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          cVar2 = FUN_180d755b0(this.normalSprite,0);
          if (cVar2) {
            if (this.target == null) goto LAB_1812c3c0f;
            this.normalSprite = this.target.mSpriteName;
          }
          cVar2 = FUN_180d755b0(this.hoverSprite,0);
          if (cVar2) {
            if (this.target == null) goto LAB_1812c3c0f;
            this.hoverSprite = this.target.mSpriteName;
          }
          cVar2 = FUN_180d755b0(this.pressedSprite,0);
          if (cVar2) {
            if (this.target == null) goto LAB_1812c3c0f;
            this.pressedSprite = this.target.mSpriteName;
          }
          cVar2 = FUN_180d755b0(this.disabledSprite,0);
          if (cVar2) {
            if (this.target == null) {
        LAB_1812c3c0f:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            this.disabledSprite = this.target.mSpriteName;
          }
        }
    }

    // Token : 0x6000184
    // RVA   : 0x12C3CD0   Offset: 0x12C30D0   Length: 0xE5
    private void UpdateImage()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = this.target;
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (cVar1) {
          cVar1 = UIImageButton.get_isEnabled(this,0);
          if (!cVar1) {
            UIImageButton.SetSprite(this,this.disabledSprite,0);
            return;
          }
          uVar2 = Component.get_gameObject(this,0);
          cVar1 = UICamera.IsHighlighted(uVar2,0);
          if (!cVar1) {
            uVar2 = this.normalSprite;
          }
          else {
            uVar2 = this.hoverSprite;
          }
          UIImageButton.SetSprite(this,uVar2,0);
        }
    }

    // Token : 0x6000185
    // RVA   : 0x12C3A30   Offset: 0x12C2E30   Length: 0x9C
    private void OnHover(bool isOver)
    {
        bool cVar1;
        ulong uVar2;
        cVar1 = UIImageButton.get_isEnabled(this,0);
        if (cVar1) {
          uVar2 = this.target;
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (cVar1) {
            if (!isOver) {
              uVar2 = this.normalSprite;
            }
            else {
              uVar2 = this.hoverSprite;
            }
            UIImageButton.SetSprite(this,uVar2,0);
          }
        }
    }

    // Token : 0x6000186
    // RVA   : 0x12C3AD0   Offset: 0x12C2ED0   Length: 0x17
    private void OnPress(bool pressed)
    {
        void FUN_1812c3ad0(int64 this,char pressed)
        {
        if (!pressed) {
          UIImageButton.UpdateImage(this,0);
          return;
        }
        UIImageButton.SetSprite(this,this.pressedSprite,0);
    }

    // Token : 0x6000187
    // RVA   : 0x12C3C20   Offset: 0x12C3020   Length: 0xAE
    private void SetSprite(string sprite)
    {
        bool cVar2;
        long lVar3;
        cVar2 = FUN_180d755b0(sprite,0);
        if (!cVar2) {
          if (this.target == null) goto LAB_1812c3cc9;
          lVar3 = UISprite.get_atlas(this.target,0);
          if (lVar3 != null) {
            lVar3 = FUN_180002aa0(10,DAT_181d7a788,lVar3,sprite);
            if (lVar3 != null) {
              if (this.target == null) {
        LAB_1812c3cc9:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              UISprite.set_spriteName(this.target,sprite,0);
              if (this.pixelSnap) {
                plVar1 = this.target;
                if (plVar1 == (int64 *)0) goto LAB_1812c3cc9;
                (**(code **)(*plVar1 + 0x348))(plVar1,*(uint64 *)(*plVar1 + 0x350));
              }
            }
          }
        }
    }

    // Token : 0x6000188
    // RVA   : 0x12C3DC0   Offset: 0x12C31C0   Length: 0xB
    public void /*ctor*/()
    {
        void FUN_1812c3dc0(int64 this)
        {
        this.pixelSnap = 1;
        FUN_18044ef50(this,0);
    }

}
