// ============================================================
// Type  : UIPlaySound
// Token : 0x2000051
// ============================================================

public class UIPlaySound
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40001C0
    public AudioClip audioClip;

    // Token: 0x40001C1
    public Trigger trigger;

    // Token: 0x40001C2
    public float volume;

    // Token: 0x40001C3
    public float pitch;

    // Token: 0x40001C4
    private bool mIsOver;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60001A8
    // RVA   : 0xF9D1B0   Offset: 0xF9BFB0   Length: 0xB3
    private bool get_canPlay()
    {
        bool cVar1;
        ulong uVar3;
        cVar1 = Behaviour.get_enabled(this,0);
        if (!cVar1) {
          return false;
        }
        plVar2 = (int64 *)Component.GetComponent(this,DAT_181e79b38);
        cVar1 = Object.op_Equality(plVar2,0,0);
        if (cVar1) {
          return true;
        }
        if (plVar2 != (int64 *)0) {
                          // WARNING: Could not recover jumptable at 0x000180f9d24f. Too many branches
                          // WARNING: Treating indirect jump as call
          uVar3 = (**(code **)(*plVar2 + 0x178))(plVar2,*(uint64 *)(*plVar2 + 0x180));
          return uVar3;
        }
    }

    // Token : 0x60001A9
    // RVA   : 0xF9CD10   Offset: 0xF9BB10   Length: 0x8C
    private void OnEnable()
    {
        uint uVar1;
        uint uVar2;
        ulong uVar3;
        if (this.trigger == 6) {
          uVar3 = this.audioClip;
          uVar1 = this.volume;
          uVar2 = this.pitch;
          NGUITools.PlaySound(uVar3,uVar1,uVar2,0);
        }
    }

    // Token : 0x60001AA
    // RVA   : 0xF9CC80   Offset: 0xF9BA80   Length: 0x8C
    private void OnDisable()
    {
        uint uVar1;
        uint uVar2;
        ulong uVar3;
        if (this.trigger == 7) {
          uVar3 = this.audioClip;
          uVar1 = this.volume;
          uVar2 = this.pitch;
          NGUITools.PlaySound(uVar3,uVar1,uVar2,0);
        }
    }

    // Token : 0x60001AB
    // RVA   : 0xF9CDA0   Offset: 0xF9BBA0   Length: 0xC7
    private void OnHover(bool isOver)
    {
        uint uVar1;
        uint uVar2;
        ulong uVar3;
        bool cVar4;
        if (this.trigger == 1) {
          if (this.mIsOver == isOver) {
            return;
          }
          this.mIsOver = isOver;
        }
        cVar4 = UIPlaySound.get_canPlay(this,0);
        if (cVar4) {
          if (!isOver) {
            if (this.trigger != 2) {
              return;
            }
          }
          else if (this.trigger != 1) {
            return;
          }
          uVar3 = this.audioClip;
          uVar1 = this.volume;
          uVar2 = this.pitch;
          NGUITools.PlaySound(uVar3,uVar1,uVar2,0);
        }
    }

    // Token : 0x60001AC
    // RVA   : 0xF9CE70   Offset: 0xF9BC70   Length: 0xC7
    private void OnPress(bool isPressed)
    {
        uint uVar1;
        uint uVar2;
        ulong uVar3;
        bool cVar4;
        if (this.trigger == 3) {
          if (this.mIsOver == isPressed) {
            return;
          }
          this.mIsOver = isPressed;
        }
        cVar4 = UIPlaySound.get_canPlay(this,0);
        if (cVar4) {
          if (!isPressed) {
            if (this.trigger != 4) {
              return;
            }
          }
          else if (this.trigger != 3) {
            return;
          }
          uVar3 = this.audioClip;
          uVar1 = this.volume;
          uVar2 = this.pitch;
          NGUITools.PlaySound(uVar3,uVar1,uVar2,0);
        }
    }

    // Token : 0x60001AD
    // RVA   : 0xF9CBE0   Offset: 0xF9B9E0   Length: 0x9A
    private void OnClick()
    {
        uint uVar1;
        uint uVar2;
        ulong uVar3;
        bool cVar4;
        cVar4 = UIPlaySound.get_canPlay(this,0);
        if ((cVar4) && (this.trigger == null)) {
          uVar3 = this.audioClip;
          uVar1 = this.volume;
          uVar2 = this.pitch;
          NGUITools.PlaySound(uVar3,uVar1,uVar2,0);
        }
    }

    // Token : 0x60001AE
    // RVA   : 0xF9CF40   Offset: 0xF9BD40   Length: 0x128
    private void OnSelect(bool isSelected)
    {
        uint uVar1;
        uint uVar2;
        ulong uVar3;
        bool cVar4;
        int iVar5;
        cVar4 = UIPlaySound.get_canPlay(this,0);
        if (cVar4) {
          if (isSelected) {
            iVar5 = UICamera.get_currentScheme(0);
            if (iVar5 != 2) {
              return;
            }
          }
          if (this.trigger == 1) {
            if (this.mIsOver == isSelected) {
              return;
            }
            this.mIsOver = isSelected;
          }
          cVar4 = UIPlaySound.get_canPlay(this,0);
          if (cVar4) {
            if (!isSelected) {
              if (this.trigger != 2) {
                return;
              }
            }
            else if (this.trigger != 1) {
              return;
            }
            uVar3 = this.audioClip;
            uVar1 = this.volume;
            uVar2 = this.pitch;
            NGUITools.PlaySound(uVar3,uVar1,uVar2,0);
          }
        }
    }

    // Token : 0x60001AF
    // RVA   : 0xF9D070   Offset: 0xF9BE70   Length: 0x84
    public void Play()
    {
        uint uVar1;
        uint uVar2;
        ulong uVar3;
        uVar3 = this.audioClip;
        uVar1 = this.volume;
        uVar2 = this.pitch;
        NGUITools.PlaySound(uVar3,uVar1,uVar2,0);
    }

    // Token : 0x60001B0
    // RVA   : 0xF9D100   Offset: 0xF9BF00   Length: 0x8D
    public void TogglePlay(bool isOn)
    {
        uint uVar1;
        uint uVar2;
        ulong uVar3;
        if (isOn) {
          uVar3 = this.audioClip;
          uVar1 = this.volume;
          uVar2 = this.pitch;
          NGUITools.PlaySound(uVar3,uVar1,uVar2,0);
        }
    }

    // Token : 0x60001B1
    // RVA   : 0xF9D190   Offset: 0xF9BF90   Length: 0x15
    public void /*ctor*/()
    {
        void FUN_180f9d190(int64 this)
        {
        this.volume = 0x3f800000;
        this.pitch = 0x3f800000;
        FUN_180ae8740(this,0);
    }

}
