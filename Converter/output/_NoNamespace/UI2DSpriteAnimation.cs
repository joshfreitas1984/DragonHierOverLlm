// ============================================================
// Type  : UI2DSpriteAnimation
// Token : 0x20000D0
// ============================================================

public class UI2DSpriteAnimation
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40004E2
    public int frameIndex;

    // Token: 0x40004E3
    protected int framerate;

    // Token: 0x40004E4
    public bool ignoreTimeScale;

    // Token: 0x40004E5
    public bool loop;

    // Token: 0x40004E6
    public Sprite[] frames;

    // Token: 0x40004E7
    private SpriteRenderer mUnitySprite;

    // Token: 0x40004E8
    private UI2DSprite mNguiSprite;

    // Token: 0x40004E9
    private float mUpdate;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60006B0
    // RVA   : 0xA75790   Offset: 0xA73F90   Length: 0x7
    public bool get_isPlaying()
    {
        void FUN_180a75790(uint64 this)
        {
        Behaviour.get_enabled(this,0);
    }

    // Token : 0x60006B1
    // RVA   : 0x2E7E80   Offset: 0x2E6680   Length: 0x4
    public int get_framesPerSecond()
    {
        uint32 FUN_1802e7e80(int64 this)
        {
        return this.framerate;
    }

    // Token : 0x60006B2
    // RVA   : 0x2E7EB0   Offset: 0x2E66B0   Length: 0x4
    public void set_framesPerSecond(int value)
    {
        void FUN_1802e7eb0(int64 this,uint32 value)
        {
        this.framerate = value;
    }

    // Token : 0x60006B3
    // RVA   : 0xA75330   Offset: 0xA73B30   Length: 0x8E
    public void Play()
    {
        bool cVar1;
        int iVar2;
        if ((this.frames == null) ||
           (*(int64 *)(this.frames + 24) == 0)) {
          return;
        }
        cVar1 = Behaviour.get_enabled(this,0);
        if ((!cVar1) && (!this.loop)) {
          iVar2 = 1;
          if (this.framerate < 1) {
            iVar2 = -1;
          }
          iVar2 = iVar2 + this.frameIndex;
          if (-1 < iVar2) {
            if (this.frames != null)
            {
              if (iVar2 < *(int *)(this.frames + 24)) goto LAB_180a75397;
              }
              if (this.framerate < 0) {
              if (this.frames == null) {
            }
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            iVar2 = *(int *)(this.frames + 24) + -1;
          }
          else {
            iVar2 = 0;
          }
          this.frameIndex = iVar2;
        }
        LAB_180a75397:
        Behaviour.set_enabled(this,1,0);
        UI2DSpriteAnimation.UpdateSprite(this,0);
    }

    // Token : 0x60006B4
    // RVA   : 0xA75320   Offset: 0xA73B20   Length: 0xA
    public void Pause()
    {
        void FUN_180a75320(uint64 this)
        {
        Behaviour.set_enabled(this,0,0);
    }

    // Token : 0x60006B5
    // RVA   : 0xA753C0   Offset: 0xA73BC0   Length: 0x3B
    public void ResetToBeginning()
    {
        if (-1 < this.framerate) {
          this.frameIndex = 0;
          UI2DSpriteAnimation.UpdateSprite(this,0);
          return;
        }
        if (this.frames != null) {
          this.frameIndex = *(int *)(this.frames + 24) + -1;
          UI2DSpriteAnimation.UpdateSprite(this,0);
          return;
        }
    }

    // Token : 0x60006B6
    // RVA   : 0xA75330   Offset: 0xA73B30   Length: 0x8E
    private void Start()
    {
        bool cVar1;
        int iVar2;
        if ((this.frames == null) ||
           (*(int64 *)(this.frames + 24) == 0)) {
          return;
        }
        cVar1 = Behaviour.get_enabled(this,0);
        if ((!cVar1) && (!this.loop)) {
          iVar2 = 1;
          if (this.framerate < 1) {
            iVar2 = -1;
          }
          iVar2 = iVar2 + this.frameIndex;
          if (-1 < iVar2) {
            if (this.frames != null)
            {
              if (iVar2 < *(int *)(this.frames + 24)) goto LAB_180a75397;
              }
              if (this.framerate < 0) {
              if (this.frames == null) {
            }
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            iVar2 = *(int *)(this.frames + 24) + -1;
          }
          else {
            iVar2 = 0;
          }
          this.frameIndex = iVar2;
        }
        LAB_180a75397:
        Behaviour.set_enabled(this,1,0);
        UI2DSpriteAnimation.UpdateSprite(this,0);
    }

    // Token : 0x60006B7
    // RVA   : 0xA756C0   Offset: 0xA73EC0   Length: 0xAF
    private void Update()
    {
        uint uVar1;
        long lVar2;
        int iVar3;
        float fVar4;
        if ((this.frames == null) ||
           (*(int64 *)(this.frames + 24) == 0)) goto LAB_180a7572c;
        if (this.framerate != null) {
          if (!this.ignoreTimeScale) {
            fVar4 = (float)Time.get_time(0);
          }
          else {
            fVar4 = (float)RealTime.get_time(0);
          }
          if (this.mUpdate <= fVar4 && fVar4 != this.mUpdate) {
            this.mUpdate = fVar4;
            iVar3 = 1;
            if (this.framerate < 1) {
              iVar3 = -1;
            }
            iVar3 = iVar3 + this.frameIndex;
            if (!this.loop) {
              if (-1 < iVar3) {
                lVar2 = this.frames;
                if (lVar2 == null) goto LAB_180a7576a;
                if (iVar3 < *(int *)(lVar2 + 24)) goto LAB_180a7574d;
              }
        LAB_180a7572c:
              Behaviour.set_enabled(this,0,0);
              return;
            }
            lVar2 = this.frames;
            if (lVar2 != null) {
        LAB_180a7574d:
              uVar1 = NGUIMath.RepeatIndex(iVar3,*(uint32 *)(lVar2 + 24),0);
              this.frameIndex = uVar1;
              UI2DSpriteAnimation.UpdateSprite(this,0);
              return;
            }
        LAB_180a7576a:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x60006B8
    // RVA   : 0xA75400   Offset: 0xA73C00   Length: 0x2B2
    private void UpdateSprite()
    {
        long lVar2;
        bool cVar3;
        ulong uVar4;
        float fVar5;
        uVar4 = this.mUnitySprite;
        cVar3 = Object.op_Equality(uVar4,0,0);
        if (cVar3) {
          uVar4 = this.mNguiSprite;
          cVar3 = Object.op_Equality(uVar4,0,0);
          if (cVar3) {
            uVar4 = Component.GetComponent(this,DAT_181d6d540);
            this.mUnitySprite = uVar4;
            uVar4 = Component.GetComponent(this,DAT_181d6dd40);
            this.mNguiSprite = uVar4;
            uVar4 = this.mUnitySprite;
            cVar3 = Object.op_Equality(uVar4,0,0);
            if (cVar3) {
              uVar4 = this.mNguiSprite;
              cVar3 = Object.op_Equality(uVar4,0,0);
              if (cVar3) {
                Behaviour.set_enabled(this,0,0);
                return;
              }
            }
          }
        }
        if (!this.ignoreTimeScale) {
          fVar5 = (float)Time.get_time();
        }
        else {
          fVar5 = (float)RealTime.get_time();
        }
        if (this.framerate != null) {
          this.mUpdate = ABS(1.0 / (float)this.framerate) + fVar5;
        }
        uVar4 = this.mUnitySprite;
        cVar3 = Object.op_Inequality(uVar4,0,0);
        if (!cVar3) {
          uVar4 = this.mNguiSprite;
          cVar3 = Object.op_Inequality(uVar4,0,0);
          if (!cVar3) {
            return;
          }
          lVar2 = this.frames;
          if (lVar2 != null) {
            if (*(uint32 *)(lVar2 + 24) <= this.frameIndex) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            uVar4 = *(uint64 *)(lVar2 + 32 + (int64)(int)this.frameIndex * 8);
            if (this.mNguiSprite != null) {
              this.mNguiSprite.nextSprite = uVar4;
              return;
            }
          }
        }
        else {
          lVar2 = this.frames;
          if (lVar2 != null) {
            if (*(uint32 *)(lVar2 + 24) <= this.frameIndex) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            if (this.mUnitySprite != null) {
              SpriteRenderer.set_sprite
                        (this.mUnitySprite,
                         *(uint64 *)(lVar2 + 32 + (int64)(int)this.frameIndex * 8),0);
              return;
            }
          }
        }
    }

    // Token : 0x60006B9
    // RVA   : 0xA75770   Offset: 0xA73F70   Length: 0x14
    public void /*ctor*/()
    {
        void FUN_180a75770(int64 this)
        {
        this.framerate = 20;
        this.ignoreTimeScale = 0x101;
        FUN_18044ef50(this,0);
    }

}
