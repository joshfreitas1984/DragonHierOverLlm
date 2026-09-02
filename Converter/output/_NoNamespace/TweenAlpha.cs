// ============================================================
// Type  : TweenAlpha
// Token : 0x20000B6
// ============================================================

public class TweenAlpha
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400044C
    public float from;

    // Token: 0x400044D
    public float to;

    // Token: 0x400044E
    public bool autoCleanup;

    // Token: 0x400044F
    public string colorProperty;

    // Token: 0x4000450
    private bool mCached;

    // Token: 0x4000451
    private UIRect mRect;

    // Token: 0x4000452
    private Material mShared;

    // Token: 0x4000453
    private Material mMat;

    // Token: 0x4000454
    private Light mLight;

    // Token: 0x4000455
    private SpriteRenderer mSr;

    // Token: 0x4000456
    private float mBaseIntensity;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000576
    // RVA   : 0xA6ED40   Offset: 0xA6D540   Length: 0x7
    public float get_alpha()
    {
        void FUN_180a6ed40(uint64 this)
        {
        TweenAlpha.get_value(this,0);
    }

    // Token : 0x6000577
    // RVA   : 0xA6EF20   Offset: 0xA6D720   Length: 0x8
    public void set_alpha(float value)
    {
        void FUN_180a6ef20(uint64 this,uint64 value)
        {
        TweenAlpha.set_value(this,value,0);
    }

    // Token : 0x6000578
    // RVA   : 0xA6EBA0   Offset: 0xA6D3A0   Length: 0xFB
    private void OnDestroy()
    {
        ulong uVar2;
        ulong uVar3;
        bool cVar4;
        if (this.autoCleanup) {
          uVar2 = this.mMat;
          cVar4 = Object.op_Inequality(uVar2,0,0);
          if (cVar4) {
            uVar2 = this.mShared;
            uVar3 = *puVar1;
            cVar4 = Object.op_Inequality(uVar2,uVar3,0);
            if (cVar4) {
              uVar2 = *puVar1;
              Object.Destroy(uVar2,0);
              *puVar1 = 0;
              il2cpp_internal(puVar1,0);
            }
          }
        }
    }

    // Token : 0x6000579
    // RVA   : 0xA6E8F0   Offset: 0xA6D0F0   Length: 0x2AA
    private void Cache()
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        uint uVar4;
        this.mCached = 1;
        uVar3 = Component.GetComponent(this,DAT_181d6e440);
        this.mRect = uVar3;
        uVar3 = Component.GetComponent(this,DAT_181d6d540);
        this.mSr = uVar3;
        uVar3 = this.mRect;
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (cVar2) {
          uVar3 = this.mSr;
          cVar2 = Object.op_Equality(uVar3,0,0);
          if (cVar2) {
            uVar3 = Component.GetComponent(this,DAT_181d6bfc0);
            this.mLight = uVar3;
            uVar3 = this.mLight;
            cVar2 = Object.op_Equality(uVar3,0,0);
            if (!cVar2) {
              if (this.mLight == null) {
        LAB_180a6eb95:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar4 = Light.get_intensity(this.mLight,0);
              this.mBaseIntensity = uVar4;
            }
            else {
              lVar1 = Component.GetComponent(this,DAT_181d6c7c0);
              cVar2 = Object.op_Inequality(lVar1,0,0);
              if (cVar2) {
                if (lVar1 == null) goto LAB_180a6eb95;
                uVar3 = FUN_180d94d10(lVar1,0);
                this.mShared = uVar3;
                uVar3 = FUN_180d94be0(lVar1,0);
                this.mMat = uVar3;
              }
              uVar3 = this.mMat;
              cVar2 = Object.op_Equality(uVar3,0,0);
              if (cVar2) {
                uVar3 = Component.GetComponentInChildren(this,DAT_181d6ee40);
                this.mRect = uVar3;
              }
            }
          }
        }
    }

    // Token : 0x600057A
    // RVA   : 0xA6ED50   Offset: 0xA6D550   Length: 0x1C0
    public float get_value()
    {
        bool cVar2;
        long lVar3;
        ulong uVar4;
        byte[] local_18 = new byte[16];
        if (!this.mCached) {
          TweenAlpha.Cache(this,0);
        }
        uVar4 = this.mRect;
        cVar2 = Object.op_Inequality(uVar4,0,0);
        if (!cVar2) {
          uVar4 = this.mSr;
          cVar2 = Object.op_Inequality(uVar4,0,0);
          if (!cVar2) {
            uVar4 = this.mMat;
            cVar2 = Object.op_Equality(uVar4,0,0);
            if (cVar2) {
              return 0x3f800000;
            }
            cVar2 = FUN_180d6ca90(this.colorProperty,0);
            lVar3 = this.mMat;
            if (!cVar2) {
              if (lVar3 != null) {
                lVar3 = Material.GetColor(local_18,lVar3,this.colorProperty,0);
                return CONCAT44(*(uint32 *)(lVar3 + 12),*(uint32 *)(lVar3 + 12));
              }
            }
            else if (lVar3 != null) {
              lVar3 = Material.get_color(local_18,lVar3,0);
              return CONCAT44(*(uint32 *)(lVar3 + 12),*(uint32 *)(lVar3 + 12));
            }
          }
          else if (this.mSr != null) {
            lVar3 = SpriteRenderer.get_color(local_18,this.mSr,0);
            return CONCAT44(*(uint32 *)(lVar3 + 12),*(uint32 *)(lVar3 + 12));
          }
        }
        else {
          plVar1 = this.mRect;
          if (plVar1 != (int64 *)0) {
                          // WARNING: Could not recover jumptable at 0x000180a6ef04. Too many branches
                          // WARNING: Treating indirect jump as call
            uVar4 = (**(code **)(*plVar1 + 0x1a8))(plVar1,*(uint64 *)(*plVar1 + 0x1b0));
            return uVar4;
          }
        }
    }

    // Token : 0x600057B
    // RVA   : 0xA6EF30   Offset: 0xA6D730   Length: 0x2C5
    public void set_value(float value)
    {
        ulong uVar1;
        long lVar2;
        bool cVar4;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        float fStack_1c;
        if (!this.mCached) {
          TweenAlpha.Cache(this,0);
        }
        uVar1 = this.mRect;
        cVar4 = Object.op_Inequality(uVar1,0,0);
        if (!cVar4) {
          uVar1 = this.mSr;
          cVar4 = Object.op_Inequality(uVar1,0,0);
          if (!cVar4) {
            uVar1 = this.mMat;
            cVar4 = Object.op_Inequality(uVar1,0,0);
            if (!cVar4) {
              uVar1 = this.mLight;
              cVar4 = Object.op_Inequality(uVar1,0,0);
              if (cVar4) {
                if (this.mLight == null) throw; // [null/range check failed]
                Light.set_intensity(this.mLight,value * this.mBaseIntensity,0)
                ;
              }
              return;
            }
            cVar4 = FUN_180d6ca90(this.colorProperty,0);
            lVar2 = this.mMat;
            if (!cVar4) {
              if (lVar2 != null) {
                puVar5 = (uint32 *)
                         Material.GetColor(&local_28,lVar2,this.colorProperty,0);
                local_28 = *puVar5;
                uStack_24 = puVar5[1];
                uStack_20 = puVar5[2];
                fStack_1c = value;
                if (this.mMat != null) {
                  Material.SetColor(this.mMat,this.colorProperty,
                                     &local_28,0);
                  return;
                }
              }
            }
            else if (lVar2 != null) {
              puVar5 = (uint32 *)Material.get_color(&local_28,lVar2,0);
              local_28 = *puVar5;
              uStack_24 = puVar5[1];
              uStack_20 = puVar5[2];
              fStack_1c = value;
              if (this.mMat != null) {
                Material.set_color(this.mMat,&local_28,0);
                return;
              }
            }
          }
          else if (this.mSr != null) {
            puVar5 = (uint32 *)SpriteRenderer.get_color(&local_28,this.mSr,0);
            local_28 = *puVar5;
            uStack_24 = puVar5[1];
            uStack_20 = puVar5[2];
            fStack_1c = value;
            if (this.mSr != null) {
              SpriteRenderer.set_color(this.mSr,&local_28,0);
              return;
            }
          }
        }
        else {
          plVar3 = this.mRect;
          if (plVar3 != (int64 *)0) {
                          // WARNING: Could not recover jumptable at 0x000180a6f1e9. Too many branches
                          // WARNING: Treating indirect jump as call
            (**(code **)(*plVar3 + 0x1b8))(plVar3,value,*(uint64 *)(*plVar3 + 0x1c0));
            return;
          }
        }
    }

    // Token : 0x600057C
    // RVA   : 0xA6ECA0   Offset: 0xA6D4A0   Length: 0x31
    protected override void OnUpdate(float factor, bool isFinished)
    {
        uint uVar1;
        uVar1 = Mathf.Lerp(this.from,this.to,factor,0);
        TweenAlpha.set_value(this,uVar1,0);
    }

    // Token : 0x600057D
    // RVA   : 0xA6E830   Offset: 0xA6D030   Length: 0xBA
    public static TweenAlpha Begin(GameObject go, float duration, float alpha, float delay)
    {
        long lVar1;
        uint uVar2;
        lVar1 = UITweener.Begin(go,duration,delay,DAT_181d9d7b8);
        if (lVar1 != null) {
          uVar2 = TweenAlpha.get_value(lVar1,0);
          *(uint32 *)(lVar1 + 120) = uVar2;
          *(uint32 *)(lVar1 + 124) = alpha;
          if (duration <= 0.0) {
            UITweener.Sample(lVar1,0x3f800000,1,0);
            Behaviour.set_enabled(lVar1,0,0);
          }
          return lVar1;
        }
    }

    // Token : 0x600057E
    // RVA   : 0xA6ED00   Offset: 0xA6D500   Length: 0x1B
    public override void SetStartToCurrentValue()
    {
        uint uVar1;
        uVar1 = TweenAlpha.get_value(this,0);
        this.from = uVar1;
    }

    // Token : 0x600057F
    // RVA   : 0xA6ECE0   Offset: 0xA6D4E0   Length: 0x1B
    public override void SetEndToCurrentValue()
    {
        uint uVar1;
        uVar1 = TweenAlpha.get_value(this,0);
        this.to = uVar1;
    }

    // Token : 0x6000580
    // RVA   : 0xA6ED20   Offset: 0xA6D520   Length: 0x1F
    public void /*ctor*/()
    {
        void FUN_180a6ed20(int64 this)
        {
        this.from = 0x3f800000;
        this.to = 0x3f800000;
        this.mBaseIntensity = 0x3f800000;
        UITweener.ctor(this,0);
    }

}
