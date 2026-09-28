// ============================================================
// Type  : UIPlaySound
// Token : 0x2000052
// ============================================================

public class UIPlaySound
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40001E0
    public AudioClip audioClip;

    // Token: 0x40001E1
    public Trigger trigger;

    // Token: 0x40001E2
    public float volume;

    // Token: 0x40001E3
    public float pitch;

    // Token: 0x40001E4
    private bool mIsOver;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60001C1
    // RVA   : 0x119F6E0   Offset: 0x119EAE0   Length: 0xB3
    private bool get_canPlay()
    {
        bool cVar1;
        ulong uVar3;
        cVar1 = Behaviour.get_enabled(this,0);
        if (!cVar1) {
          return false;
        }
        plVar2 = (int64 *)Component.GetComponent(this,DAT_181d96760);
        cVar1 = Object.op_Equality(plVar2,0,0);
        if (cVar1) {
          return true;
        }
        if (plVar2 != (int64 *)0) {
                          // WARNING: Could not recover jumptable at 0x00018119f77f. Too many branches
                          // WARNING: Treating indirect jump as call
          uVar3 = (**(code **)(*plVar2 + 0x178))(plVar2,*(uint64 *)(*plVar2 + 0x180));
          return uVar3;
        }
    }

    // Token : 0x60001C2
    // RVA   : 0x119F240   Offset: 0x119E640   Length: 0x8C
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

    // Token : 0x60001C3
    // RVA   : 0x119F1B0   Offset: 0x119E5B0   Length: 0x8C
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

    // Token : 0x60001C4
    // RVA   : 0x119F2D0   Offset: 0x119E6D0   Length: 0xC7
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

    // Token : 0x60001C5
    // RVA   : 0x119F3A0   Offset: 0x119E7A0   Length: 0xC7
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

    // Token : 0x60001C6
    // RVA   : 0x119F110   Offset: 0x119E510   Length: 0x9A
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

    // Token : 0x60001C7
    // RVA   : 0x119F470   Offset: 0x119E870   Length: 0x128
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

    // Token : 0x60001C8
    // RVA   : 0x119F5A0   Offset: 0x119E9A0   Length: 0x84
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

    // Token : 0x60001C9
    // RVA   : 0x119F630   Offset: 0x119EA30   Length: 0x8D
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

    // Token : 0x60001CA
    // RVA   : 0x119F6C0   Offset: 0x119EAC0   Length: 0x15
    public void /*ctor*/()
    {
        void FUN_18119f6c0(int64 this)
        {
        this.volume = 0x3f800000;
        this.pitch = 0x3f800000;
        FUN_18044ef50(this,0);
    }

}
