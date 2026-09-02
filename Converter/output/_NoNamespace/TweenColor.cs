// ============================================================
// Type  : TweenColor
// Token : 0x20000B7
// ============================================================

public class TweenColor
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000457
    public Color from;

    // Token: 0x4000458
    public Color to;

    // Token: 0x4000459
    private bool mCached;

    // Token: 0x400045A
    private UIWidget mWidget;

    // Token: 0x400045B
    private Material mMat;

    // Token: 0x400045C
    private Light mLight;

    // Token: 0x400045D
    private SpriteRenderer mSr;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000581
    // RVA   : 0xA6F2C0   Offset: 0xA6DAC0   Length: 0x227
    private void Cache()
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        this.mCached = 1;
        uVar3 = Component.GetComponent(this,DAT_181d6e7c0);
        this.mWidget = uVar3;
        uVar3 = this.mWidget;
        cVar2 = Object.op_Inequality(uVar3,0,0);
        if (!cVar2) {
          uVar3 = Component.GetComponent(this,DAT_181d6d540);
          this.mSr = uVar3;
          uVar3 = this.mSr;
          cVar2 = Object.op_Inequality(uVar3,0,0);
          if (!cVar2) {
            lVar1 = Component.GetComponent(this,DAT_181d6c7c0);
            cVar2 = Object.op_Inequality(lVar1,0,0);
            if (!cVar2) {
              uVar3 = Component.GetComponent(this,DAT_181d6bfc0);
              this.mLight = uVar3;
              uVar3 = this.mLight;
              cVar2 = Object.op_Equality(uVar3,0,0);
              if (!cVar2) {
                return;
              }
              uVar3 = Component.GetComponentInChildren(this,DAT_181d6ef40);
              this.mWidget = uVar3;
              puVar4 = &this.mWidget;
            }
            else {
              if (lVar1 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar3 = FUN_180d94be0(lVar1,0);
              this.mMat = uVar3;
            }
            il2cpp_internal(puVar4,uVar3);
          }
        }
    }

    // Token : 0x6000582
    // RVA   : 0xA6F650   Offset: 0xA6DE50   Length: 0x25
    public Color get_color()
    {
        ulong uVar1;
        byte[] local_18 = new byte[16];
        puVar2 = (uint64 *)TweenColor.get_value(local_18,param_2,0);
        uVar1 = puVar2[1];
        *this = *puVar2;
        this[1] = uVar1;
        return this;
    }

    // Token : 0x6000583
    // RVA   : 0xA6F840   Offset: 0xA6E040   Length: 0x1E
    public void set_color(Color value)
    {
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        local_18 = *value;
        uStack_14 = value[1];
        uStack_10 = value[2];
        uStack_c = value[3];
        TweenColor.set_value(local_18,&local_18,0);
    }

    // Token : 0x6000584
    // RVA   : 0xA6F680   Offset: 0xA6DE80   Length: 0x1B4
    public Color get_value()
    {
        var pparam_2 = *(int64*)(param_2 + 184);
        ulong uVar1;
        long lVar2;
        bool cVar3;
        uint uVar5;
        uint uVar6;
        uint uVar7;
        uint uVar8;
        byte[] local_18 = new byte[16];
        if (*(char *)(param_2 + 152) == false) {
          TweenColor.Cache(param_2,0);
        }
        uVar1 = *(uint64 *)(param_2 + 160);
        cVar3 = Object.op_Inequality(uVar1,0,0);
        if (!cVar3) {
          uVar1 = *(uint64 *)(param_2 + 168);
          cVar3 = Object.op_Inequality(uVar1,0,0);
          if (!cVar3) {
            uVar1 = *(uint64 *)(param_2 + 184);
            cVar3 = Object.op_Inequality(uVar1,0,0);
            if (!cVar3) {
              uVar1 = *(uint64 *)(param_2 + 176);
              cVar3 = Object.op_Inequality(uVar1,0,0);
              if (!cVar3) {
                puVar4 = (uint32 *)Color.get_black(local_18,0);
              }
              else {
                if (*(int64 *)(param_2 + 176) == 0) goto LAB_180a6f82f;
                puVar4 = (uint32 *)Light.get_color(local_18,*(int64 *)(param_2 + 176),0);
              }
            }
            else {
              if (pparam_2 == 0) goto LAB_180a6f82f;
              puVar4 = (uint32 *)SpriteRenderer.get_color(local_18,pparam_2,0);
            }
          }
          else {
            if (*(int64 *)(param_2 + 168) == 0) goto LAB_180a6f82f;
            puVar4 = (uint32 *)Material.get_color(local_18,*(int64 *)(param_2 + 168),0);
          }
          uVar5 = *puVar4;
          uVar6 = puVar4[1];
          uVar7 = puVar4[2];
          uVar8 = puVar4[3];
        }
        else {
          lVar2 = *(int64 *)(param_2 + 160);
          if (lVar2 == null) {
        LAB_180a6f82f:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar5 = *(uint32 *)(lVar2 + 144);
          uVar6 = *(uint32 *)(lVar2 + 148);
          uVar7 = *(uint32 *)(lVar2 + 152);
          uVar8 = *(uint32 *)(lVar2 + 156);
        }
        *this = uVar5;
        this[1] = uVar6;
        this[2] = uVar7;
        this[3] = uVar8;
        return this;
    }

    // Token : 0x6000585
    // RVA   : 0xA6F860   Offset: 0xA6E060   Length: 0x238
    public void set_value(Color value)
    {
        ulong uVar1;
        bool cVar2;
        float local_28;
        float fStack_24;
        float fStack_20;
        float fStack_1c;
        float local_18;
        float fStack_14;
        float fStack_10;
        float fStack_c;
        if (!this.mCached) {
          TweenColor.Cache(this,0);
        }
        uVar1 = this.mWidget;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (!cVar2) {
          uVar1 = this.mMat;
          cVar2 = Object.op_Inequality(uVar1,0,0);
          if (!cVar2) {
            uVar1 = this.mSr;
            cVar2 = Object.op_Inequality(uVar1,0,0);
            if (!cVar2) {
              uVar1 = this.mLight;
              cVar2 = Object.op_Inequality(uVar1,0,0);
              if (!cVar2) {
                return;
              }
              if (this.mLight != null) {
                local_28 = *value;
                fStack_24 = value[1];
                fStack_20 = value[2];
                fStack_1c = value[3];
                Light.set_color(this.mLight,&local_28,0);
                local_28 = *value;
                fStack_24 = value[1];
                fStack_20 = value[2];
                fStack_1c = value[3];
                local_18 = local_28;
                fStack_14 = fStack_24;
                fStack_10 = fStack_20;
                fStack_c = fStack_1c;
                if (this.mLight != null) {
                  Behaviour.set_enabled
                            (this.mLight,0.01 < fStack_24 + *value + fStack_20,0);
                  return;
                }
              }
            }
            else if (this.mSr != null) {
              local_18 = *value;
              fStack_14 = value[1];
              fStack_10 = value[2];
              fStack_c = value[3];
              SpriteRenderer.set_color(this.mSr,&local_18,0);
              return;
            }
          }
          else if (this.mMat != null) {
            local_18 = *value;
            fStack_14 = value[1];
            fStack_10 = value[2];
            fStack_c = value[3];
            Material.set_color(this.mMat,&local_18,0);
            return;
          }
        }
        else if (this.mWidget != null) {
          local_18 = *value;
          fStack_14 = value[1];
          fStack_10 = value[2];
          fStack_c = value[3];
          UIWidget.set_color(this.mWidget,&local_18,0);
          return;
        }
    }

    // Token : 0x6000586
    // RVA   : 0xA6F4F0   Offset: 0xA6DCF0   Length: 0x5C
    protected override void OnUpdate(float factor, bool isFinished)
    {
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        uint32 local_28;
        uint32 uStack_24;
        uint32 uStack_20;
        uint32 uStack_1c;
        uint8 local_18 [16];
        local_38 = this.to;
        uStack_34 = *(uint32 *)(this + 140);
        uStack_30 = *(uint32 *)(this + 144);
        uStack_2c = *(uint32 *)(this + 148);
        local_28 = this.from;
        uStack_24 = *(uint32 *)(this + 124);
        uStack_20 = *(uint32 *)(this + 128);
        uStack_1c = *(uint32 *)(this + 132);
        puVar1 = (uint32 *)Color.Lerp(local_18,&local_28,&local_38,factor,0);
        local_28 = *puVar1;
        uStack_24 = puVar1[1];
        uStack_20 = puVar1[2];
        uStack_1c = puVar1[3];
        TweenColor.set_value(this,&local_28,0);
    }

    // Token : 0x6000587
    // RVA   : 0xA6F200   Offset: 0xA6DA00   Length: 0xBF
    public static TweenColor Begin(GameObject go, float duration, Color color)
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        ulong uVar4;
        long lVar5;
        byte[] local_38 = new byte[48];
        lVar5 = UITweener.Begin(go,duration,0,DAT_181d9d840);
        if (lVar5 != null) {
          puVar6 = (uint64 *)TweenColor.get_value(local_38,lVar5,0);
          uVar4 = puVar6[1];
          *(uint64 *)(lVar5 + 120) = *puVar6;
          *(uint64 *)(lVar5 + 128) = uVar4;
          uVar1 = color[1];
          uVar2 = color[2];
          uVar3 = color[3];
          *(uint32 *)(lVar5 + 136) = *color;
          *(uint32 *)(lVar5 + 140) = uVar1;
          *(uint32 *)(lVar5 + 144) = uVar2;
          *(uint32 *)(lVar5 + 148) = uVar3;
          if (duration <= 0.0) {
            UITweener.Sample(lVar5,0x3f800000,1,0);
            Behaviour.set_enabled(lVar5,0,0);
          }
          return lVar5;
        }
    }

    // Token : 0x6000588
    // RVA   : 0xA6F5D0   Offset: 0xA6DDD0   Length: 0x26
    public override void SetStartToCurrentValue()
    {
        ulong uVar1;
        byte[] local_18 = new byte[16];
        puVar2 = (uint64 *)TweenColor.get_value(local_18,this,0);
        uVar1 = puVar2[1];
        this.from = *puVar2;
        *(uint64 *)(this + 128) = uVar1;
    }

    // Token : 0x6000589
    // RVA   : 0xA6F5A0   Offset: 0xA6DDA0   Length: 0x29
    public override void SetEndToCurrentValue()
    {
        ulong uVar1;
        byte[] local_18 = new byte[16];
        puVar2 = (uint64 *)TweenColor.get_value(local_18,this,0);
        uVar1 = puVar2[1];
        this.to = *puVar2;
        *(uint64 *)(this + 144) = uVar1;
    }

    // Token : 0x600058A
    // RVA   : 0xA6F580   Offset: 0xA6DD80   Length: 0x1F
    private void SetCurrentValueToStart()
    {
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        local_18 = this.from;
        uStack_14 = *(uint32 *)(this + 124);
        uStack_10 = *(uint32 *)(this + 128);
        uStack_c = *(uint32 *)(this + 132);
        TweenColor.set_value(local_18,&local_18,0);
    }

    // Token : 0x600058B
    // RVA   : 0xA6F550   Offset: 0xA6DD50   Length: 0x22
    private void SetCurrentValueToEnd()
    {
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        local_18 = this.to;
        uStack_14 = *(uint32 *)(this + 140);
        uStack_10 = *(uint32 *)(this + 144);
        uStack_c = *(uint32 *)(this + 148);
        TweenColor.set_value(local_18,&local_18,0);
    }

    // Token : 0x600058C
    // RVA   : 0xA6F600   Offset: 0xA6DE00   Length: 0x41
    public void /*ctor*/()
    {
        uint uVar1;
        uint uVar2;
        uint uVar3;
        byte[] local_18 = new byte[16];
        puVar4 = (uint32 *)FUN_181098a50(local_18,0);
        uVar1 = puVar4[1];
        uVar2 = puVar4[2];
        uVar3 = puVar4[3];
        this.from = *puVar4;
        *(uint32 *)(this + 124) = uVar1;
        *(uint32 *)(this + 128) = uVar2;
        *(uint32 *)(this + 132) = uVar3;
        puVar4 = (uint32 *)FUN_181098a50(local_18,0);
        uVar1 = puVar4[1];
        uVar2 = puVar4[2];
        uVar3 = puVar4[3];
        this.to = *puVar4;
        *(uint32 *)(this + 140) = uVar1;
        *(uint32 *)(this + 144) = uVar2;
        *(uint32 *)(this + 148) = uVar3;
        UITweener.ctor(this,0);
    }

}
