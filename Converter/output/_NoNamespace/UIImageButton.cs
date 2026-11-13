// ============================================================
// Type  : UIImageButton
// Token : 0x200004A
// ============================================================

public class UIImageButton
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000189
    public UISprite target;

    // Token: 0x400018A
    public string normalSprite;

    // Token: 0x400018B
    public string hoverSprite;

    // Token: 0x400018C
    public string pressedSprite;

    // Token: 0x400018D
    public string disabledSprite;

    // Token: 0x400018E
    public bool pixelSnap;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000167
    // RVA   : 0x114B180   Offset: 0x1149F80   Length: 0x9D
    public bool get_isEnabled()
    {
        bool cVar1;
        long lVar2;
        lVar2 = Component.get_gameObject(this,0);
        if (lVar2 != null) {
          lVar2 = GameObject.GetComponent(lVar2,DAT_181e54178);
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

    // Token : 0x6000168
    // RVA   : 0x114B220   Offset: 0x114A020   Length: 0xCC
    public void set_isEnabled(bool value)
    {
        bool cVar1;
        long lVar2;
        lVar2 = Component.get_gameObject(this,0);
        if (lVar2 != null) {
          lVar2 = GameObject.GetComponent(lVar2,DAT_181e54178);
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

    // Token : 0x6000169
    // RVA   : 0x114AD30   Offset: 0x1149B30   Length: 0xA5
    private void OnEnable()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = this.target;
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          uVar2 = Component.GetComponentInChildren(this,DAT_181e7ab38);
          this.target = uVar2;
        }
        UIImageButton.UpdateImage(this,0);
    }

    // Token : 0x600016A
    // RVA   : 0x114AEA0   Offset: 0x1149CA0   Length: 0x124
    private void OnValidate()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.target;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          cVar2 = FUN_180ad1200(this.normalSprite,0);
          if (cVar2) {
            if (this.target == null) goto LAB_18114afbf;
            this.normalSprite = this.target.mSpriteName;
          }
          cVar2 = FUN_180ad1200(this.hoverSprite,0);
          if (cVar2) {
            if (this.target == null) goto LAB_18114afbf;
            this.hoverSprite = this.target.mSpriteName;
          }
          cVar2 = FUN_180ad1200(this.pressedSprite,0);
          if (cVar2) {
            if (this.target == null) goto LAB_18114afbf;
            this.pressedSprite = this.target.mSpriteName;
          }
          cVar2 = FUN_180ad1200(this.disabledSprite,0);
          if (cVar2) {
            if (this.target == null) {
        LAB_18114afbf:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            this.disabledSprite = this.target.mSpriteName;
          }
        }
    }

    // Token : 0x600016B
    // RVA   : 0x114B080   Offset: 0x1149E80   Length: 0xE5
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

    // Token : 0x600016C
    // RVA   : 0x114ADE0   Offset: 0x1149BE0   Length: 0x9C
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

    // Token : 0x600016D
    // RVA   : 0x114AE80   Offset: 0x1149C80   Length: 0x17
    private void OnPress(bool pressed)
    {
        void FUN_18114ae80(int64 this,char pressed)
        {
        if (!pressed) {
          UIImageButton.UpdateImage(this,0);
          return;
        }
        UIImageButton.SetSprite(this,this.pressedSprite,0);
    }

    // Token : 0x600016E
    // RVA   : 0x114AFD0   Offset: 0x1149DD0   Length: 0xAE
    private void SetSprite(string sprite)
    {
        bool cVar2;
        long lVar3;
        cVar2 = FUN_180ad1200(sprite,0);
        if (!cVar2) {
          if (this.target == null) goto LAB_18114b079;
          lVar3 = UISprite.get_atlas(this.target,0);
          if (lVar3 != null) {
            lVar3 = FUN_180054130(10,DAT_181e5a658,lVar3,sprite);
            if (lVar3 != null) {
              if (this.target == null) {
        LAB_18114b079:
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              UISprite.set_spriteName(this.target,sprite,0);
              if (this.pixelSnap) {
                plVar1 = this.target;
                if (plVar1 == (int64 *)0) goto LAB_18114b079;
                (**(code **)(*plVar1 + 0x348))(plVar1,*(uint64 *)(*plVar1 + 0x350));
              }
            }
          }
        }
    }

    // Token : 0x600016F
    // RVA   : 0x114B170   Offset: 0x1149F70   Length: 0xB
    public void /*ctor*/()
    {
        void FUN_18114b170(int64 this)
        {
        this.pixelSnap = 1;
        FUN_180ae8740(this,0);
    }

}
