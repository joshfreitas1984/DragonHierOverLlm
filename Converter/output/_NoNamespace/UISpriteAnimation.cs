// ============================================================
// Type  : UISpriteAnimation
// Token : 0x200010C
// ============================================================

public class UISpriteAnimation
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400069C
    public int frameIndex;

    // Token: 0x400069D
    protected int mFPS;

    // Token: 0x400069E
    protected string mPrefix;

    // Token: 0x400069F
    protected bool mLoop;

    // Token: 0x40006A0
    protected bool mSnap;

    // Token: 0x40006A1
    protected UISprite mSprite;

    // Token: 0x40006A2
    protected float mDelta;

    // Token: 0x40006A3
    protected bool mActive;

    // Token: 0x40006A4
    protected List<string> mSpriteNames;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000904
    // RVA   : 0x1609B10   Offset: 0x1608910   Length: 0x3C
    public int get_frames()
    {
        if (this.mSpriteNames != null) {
          return this.mSpriteNames.Count;
        }
    }

    // Token : 0x6000905
    // RVA   : 0x529010   Offset: 0x527E10   Length: 0x4
    public int get_framesPerSecond()
    {
        uint32 FUN_180529010(int64 this)
        {
        return this.mFPS;
    }

    // Token : 0x6000906
    // RVA   : 0x529060   Offset: 0x527E60   Length: 0x4
    public void set_framesPerSecond(int value)
    {
        void FUN_180529060(int64 this,uint32 value)
        {
        this.mFPS = value;
    }

    // Token : 0x6000907
    // RVA   : 0x529000   Offset: 0x527E00   Length: 0x5
    public string get_namePrefix()
    {
        return this.mPrefix;
    }

    // Token : 0x6000908
    // RVA   : 0x1609B50   Offset: 0x1608950   Length: 0x4F
    public void set_namePrefix(string value)
    {
        bool cVar1;
        cVar1 = String.op_Inequality(this.mPrefix,value,0);
        if (cVar1) {
          this.mPrefix = value;
          UISpriteAnimation.RebuildSpriteList(this,0);
        }
    }

    // Token : 0x6000909
    // RVA   : 0x8EAEA0   Offset: 0x8E9CA0   Length: 0x5
    public bool get_loop()
    {
        uint8 FUN_1808eaea0(int64 this)
        {
        return this.mLoop;
    }

    // Token : 0x600090A
    // RVA   : 0xFACEE0   Offset: 0xFABCE0   Length: 0x4
    public void set_loop(bool value)
    {
        void FUN_180facee0(int64 this,uint8 value)
        {
        this.mLoop = value;
    }

    // Token : 0x600090B
    // RVA   : 0xAB6800   Offset: 0xAB5600   Length: 0x5
    public bool get_isPlaying()
    {
        uint8 FUN_180ab6800(int64 this)
        {
        return this.mActive;
    }

    // Token : 0x600090C
    // RVA   : 0x16098D0   Offset: 0x16086D0   Length: 0x7
    protected virtual void Start()
    {
        void FUN_1816098d0(uint64 this)
        {
        UISpriteAnimation.RebuildSpriteList(this,0);
    }

    // Token : 0x600090D
    // RVA   : 0x16098E0   Offset: 0x16086E0   Length: 0x176
    protected virtual void Update()
    {
        long lVar1;
        long lVar2;
        bool cVar4;
        ulong uVar5;
        int iVar6;
        float fVar7;
        float fVar8;
        if (this.mActive) {
          if (this.mSpriteNames == null) {
        LAB_181609a51:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          if (((1 < this.mSpriteNames.Count) &&
              (cVar4 = Application.get_isPlaying(0), cVar4)) && (0 < this.mFPS)) {
            fVar8 = this.mDelta;
            RealTime.get_deltaTime(0);
            fVar7 = (float)Mathf.Min(0x3f800000);
            fVar7 = fVar7 + fVar8;
            this.mDelta = fVar7;
            fVar8 = 1.0 / (float)this.mFPS;
            if (fVar8 < fVar7) {
              do {
                if (fVar8 <= 0.0) {
                  fVar7 = 0.0;
                }
                else {
                  fVar7 = fVar7 - fVar8;
                }
                this.mDelta = fVar7;
                lVar1 = this.mSpriteNames;
                iVar6 = this.frameIndex + 1;
                this.frameIndex = iVar6;
                if (lVar1 == null) goto LAB_181609a51;
                if (iVar6 < lVar1.Count) {
                  cVar4 = this.mActive;
                }
                else {
                  cVar4 = this.mLoop;
                  this.mActive = cVar4;
                  this.frameIndex = 0;
                  iVar6 = 0;
                }
                if (cVar4) {
                  lVar2 = this.mSprite;
                  uVar5 = FUN_1800024b0(lVar1,iVar6,DAT_181e86970);
                  if (lVar2 == null) goto LAB_181609a51;
                  UISprite.set_spriteName(lVar2,uVar5,0);
                  if (this.mSnap) {
                    plVar3 = this.mSprite;
                    if (plVar3 == (int64 *)0) goto LAB_181609a51;
                    (**(code **)(*plVar3 + 0x348))(plVar3,*(uint64 *)(*plVar3 + 0x350));
                  }
                }
                fVar7 = this.mDelta;
              } while (fVar8 < fVar7);
            }
          }
        }
    }

    // Token : 0x600090E
    // RVA   : 0x1609570   Offset: 0x1608370   Length: 0x254
    public void RebuildSpriteList()
    {
        int iVar1;
        long lVar2;
        bool cVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        uint uVar7;
        long lVar8;
        uVar4 = this.mSprite;
        cVar3 = Object.op_Equality(uVar4,0,0);
        if (cVar3) {
          uVar4 = Component.GetComponent(this,DAT_181e7a2b8);
          this.mSprite = uVar4;
        }
        if (this.mSpriteNames != null) {
          FUN_18115d8f0(this.mSpriteNames,DAT_181e863f0);
          uVar4 = this.mSprite;
          cVar3 = Object.op_Inequality(uVar4,0,0);
          if (!cVar3) {
            return;
          }
          lVar5 = this.mSprite;
          if (lVar5 != null) {
            lVar5 = il2cpp_internal(lVar5.mAtlas,DAT_181e5a658);
            if (lVar5 == null) {
              return;
            }
            lVar5 = FUN_180002280(2,DAT_181e5a658,lVar5);
            uVar7 = 0;
            if (lVar5 != null) {
              iVar1 = *(int *)(lVar5 + 24);
              if (0 < iVar1) {
                lVar8 = 32;
                lVar6 = 0;
                do {
                  if (*(uint32 *)(lVar5 + 24) <= uVar7) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar2 = *(int64 *)(lVar8 + *(int64 *)(lVar5 + 16));
                  cVar3 = FUN_180ad1200(this.mPrefix,0);
                  if (!cVar3) {
                    if ((lVar2 == null) || (*(int64 *)(lVar2 + 16) == 0)) throw; // [null/range check failed]
                    cVar3 = String.StartsWith(*(int64 *)(lVar2 + 16),this.mPrefix
                                               ,0);
                    if (!(cVar3))
                    {
                      }
                      else {
                    }
                    if ((lVar2 == null) || (this.mSpriteNames == null)) throw; // [null/range check failed]
                    FUN_18175de30();
                  }
                  uVar7 = uVar7 + 1;
                  lVar6 = lVar6 + 1;
                  lVar8 = lVar8 + 8;
                } while (lVar6 < iVar1);
              }
              if (this.mSpriteNames != null) {
                List_1.Sort(this.mSpriteNames,DAT_181e867f0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x600090F
    // RVA   : 0x1609560   Offset: 0x1608360   Length: 0x5
    public void Play()
    {
        void FUN_181609560(int64 this)
        {
        this.mActive = 1;
    }

    // Token : 0x6000910
    // RVA   : 0x1609550   Offset: 0x1608350   Length: 0x5
    public void Pause()
    {
        void FUN_181609550(int64 this)
        {
        this.mActive = 0;
    }

    // Token : 0x6000911
    // RVA   : 0x16097D0   Offset: 0x16085D0   Length: 0xFE
    public void ResetToBeginning()
    {
        uint uVar1;
        ulong uVar2;
        long lVar3;
        long lVar4;
        bool cVar6;
        uVar2 = this.mSprite;
        this.mActive = 1;
        this.frameIndex = 0;
        cVar6 = Object.op_Inequality(uVar2,0,0);
        if (cVar6) {
          lVar3 = this.mSpriteNames;
          if (lVar3 == null) {
        LAB_1816098c9:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          if (0 < (int)lVar3.Count) {
            uVar1 = this.frameIndex;
            lVar4 = this.mSprite;
            if (lVar3.Count <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar4 == null) goto LAB_1816098c9;
            UISprite.set_spriteName
                      (lVar4,*(uint64 *)
                              (lVar3._items + 32 + (int64)(int)uVar1 * 8),0);
            if (this.mSnap) {
              plVar5 = this.mSprite;
              if (plVar5 == (int64 *)0) goto LAB_1816098c9;
              (**(code **)(*plVar5 + 0x348))(plVar5,*(uint64 *)(*plVar5 + 0x350));
            }
          }
        }
    }

    // Token : 0x6000912
    // RVA   : 0x1609A60   Offset: 0x1608860   Length: 0xA6
    public void /*ctor*/()
    {
        ulong uVar1;
        this.mFPS = 30;
        this.mPrefix = "";
        this.mLoop = 0x101;
        this.mActive = 1;
        uVar1 = il2cpp_internal(DAT_181e77728);
        FUN_1810f3480(uVar1,DAT_181e861f0);
        this.mSpriteNames = uVar1;
        FUN_180ae8740(this,0);
    }

}
