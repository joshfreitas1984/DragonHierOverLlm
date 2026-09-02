// ============================================================
// Type  : UIScrollBar
// Token : 0x200005F
// ============================================================

public class UIScrollBar
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400023F
    protected float mSize;

    // Token: 0x4000240
    private float mScroll;

    // Token: 0x4000241
    private Direction mDir;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600022E
    // RVA   : 0x1689B50   Offset: 0x1688350   Length: 0x7
    public float get_scrollValue()
    {
        void FUN_181689b50(uint64 this)
        {
        UIProgressBar.get_value(this,0);
    }

    // Token : 0x600022F
    // RVA   : 0x1689CE0   Offset: 0x16884E0   Length: 0x8
    public void set_scrollValue(float value)
    {
        void FUN_181689ce0(uint64 this,uint64 value)
        {
        UIProgressBar.set_value(this,value,0);
    }

    // Token : 0x6000230
    // RVA   : 0x15DE190   Offset: 0x15DC990   Length: 0x9
    public float get_barSize()
    {
        uint32 FUN_1815de190(int64 this)
        {
        return this.mSize;
    }

    // Token : 0x6000231
    // RVA   : 0x1689B60   Offset: 0x1688360   Length: 0x17A
    public void set_barSize(float value)
    {
        ulong uVar1;
        long lVar3;
        bool cVar4;
        float fVar5;
        fVar5 = (float)Mathf.Clamp01(value,0);
        if (*(float *)(this + 17) != fVar5) {
          *(float *)(this + 17) = fVar5;
          *(uint8 *)(this + 10) = 1;
          cVar4 = NGUITools.GetActive(this,0);
          if (cVar4) {
            uVar1 = **(uint64 **)(DAT_181d8ae58 + 184);
            cVar4 = Object.op_Equality(uVar1,0,0);
            if ((cVar4) && (this[13] != 0)) {
              puVar2 = *(uint64 **)(DAT_181d8ae58 + 184);
              *puVar2 = this;
              il2cpp_internal(puVar2,this);
              lVar3 = this[13];
              EventDelegate.Execute(lVar3,0);
              puVar2 = *(uint64 **)(DAT_181d8ae58 + 184);
              *puVar2 = 0;
              il2cpp_internal(puVar2,0);
            }
            (**(code **)(*this + 0x1a8))(this,*(uint64 *)(*this + 0x1b0));
          }
        }
    }

    // Token : 0x6000232
    // RVA   : 0x1689AD0   Offset: 0x16882D0   Length: 0x4C
    protected override void Upgrade()
    {
        void FUN_181689ad0(int64 this)
        {
        if (this.mDir != 2) {
          *(uint32 *)(this + 56) = this.mScroll;
          if (this.mDir != null) {
            *(uint32 *)(this + 60) = 3 - (uint32)(*(char *)(this + 128) != false);
            this.mDir = 2;
            return;
          }
          *(uint32 *)(this + 60) = (uint32)(*(char *)(this + 128) != false);
          this.mDir = 2;
        }
    }

    // Token : 0x6000233
    // RVA   : 0x16897E0   Offset: 0x1687FE0   Length: 0x2E8
    protected override void OnStart()
    {
        bool cVar1;
        ulong uVar2;
        ulong uVar3;
        long lVar4;
        UISlider.OnStart(this,0);
        uVar2 = *(uint64 *)(this + 48);
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (!cVar1) {
          return;
        }
        if (*(int64 *)(this + 48) != 0) {
          uVar2 = Component.get_gameObject(*(int64 *)(this + 48),0);
          uVar3 = Component.get_gameObject(this,0);
          cVar1 = Object.op_Inequality(uVar2,uVar3,0);
          if (!cVar1) {
            return;
          }
          if (*(int64 *)(this + 48) != 0) {
            uVar2 = Component.GetComponent(*(int64 *)(this + 48),DAT_181d6b340);
            cVar1 = Object.op_Inequality(uVar2,0,0);
            if (!cVar1) {
              if (*(int64 *)(this + 48) == 0) throw; // [null/range check failed]
              uVar2 = Component.GetComponent(*(int64 *)(this + 48),DAT_181d6b3c0);
              cVar1 = Object.op_Inequality(uVar2,0,0);
              if (!cVar1) {
                return;
              }
            }
            if (*(int64 *)(this + 48) != 0) {
              uVar2 = Component.get_gameObject(*(int64 *)(this + 48),0);
              lVar4 = UIEventListener.Get(uVar2,0);
              if (lVar4 != null) {
                uVar2 = *(uint64 *)(lVar4 + 64);
                uVar3 = new OnTooltipCB(this,DAT_181d9d400,0);
                plVar5 = (int64 *)Delegate.Combine(uVar2,uVar3,0);
                plVar7 = (int64 *)0;
                plVar6 = plVar7;
                if (plVar5 != (int64 *)0) {
                  if (*plVar5 == DAT_181d68590) {
                    plVar6 = plVar5;
                  }
                  if (plVar6 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6070(plVar5,DAT_181d68590);
                  }
                }
                *(int64 **)(lVar4 + 64) = plVar6;
                uVar2 = *(uint64 *)(lVar4 + 96);
                uVar3 = new OnTooltipCB(this,DAT_181d9d2f0,0);
                plVar6 = (int64 *)Delegate.Combine(uVar2,uVar3,0);
                if (plVar6 != (int64 *)0) {
                  if (*plVar6 == DAT_181d68610) {
                    plVar7 = plVar6;
                  }
                  if (plVar7 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6070(plVar6);
                  }
                }
                *(int64 **)(lVar4 + 96) = plVar7;
                if (*(int64 *)(this + 48) != 0) {
                  *(uint8 *)(*(int64 *)(this + 48) + 208) = 1;
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000234
    // RVA   : 0x1689520   Offset: 0x1687D20   Length: 0x2BA
    protected override float LocalToValue(Vector2 localPos)
    {
        uint uVar1;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        float fVar6;
        float fVar7;
        float fVar8;
        float local_48;
        float fStack_44;
        uVar5 = *(uint64 *)(this + 48);
        cVar3 = Object.op_Inequality(uVar5,0,0);
        if (!cVar3) {
          fVar6 = (float)UIProgressBar.LocalToValue(this,localPos,0);
          return fVar6;
        }
        fVar6 = (float)Mathf.Clamp01(this.mSize,0);
        plVar2 = *(int64 **)(this + 48);
        fVar6 = fVar6 * 0.5;
        if (plVar2 != (int64 *)0) {
          lVar4 = (**(code **)(*plVar2 + 0x1d8))(plVar2,*(uint64 *)(*plVar2 + 0x1e0));
          cVar3 = UIProgressBar.get_isHorizontal(this,0);
          if (lVar4 != null) {
            uVar1 = *(uint32 *)(lVar4 + 24);
            if (!cVar3) {
              if (uVar1 == 0) {
                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar5,0);
              }
              if (uVar1 < 2) {
                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar5,0);
              }
              fVar7 = (float)Mathf.Lerp(*(uint32 *)(lVar4 + 36),*(uint32 *)(lVar4 + 48),fVar6
                                         ,0);
              if (*(uint32 *)(lVar4 + 24) < 4) {
                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar5,0);
              }
              fVar6 = (float)Mathf.Lerp(*(uint32 *)(lVar4 + 72),*(uint32 *)(lVar4 + 60),
                                         1.0 - fVar6,0);
              fVar8 = fVar6 - fVar7;
              if (fVar8 == 0.0) {
        LAB_18168972b:
                fVar6 = (float)UIProgressBar.get_value(this,0);
                return fVar6;
              }
              cVar3 = UIProgressBar.get_isInverted(this,0);
              fStack_44 = (float)((uint64)localPos >> 32);
              local_48 = fStack_44;
              if (cVar3) {
                return (fVar6 - fStack_44) / fVar8;
              }
            }
            else {
              if (uVar1 == 0) {
                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar5,0);
              }
              if (uVar1 < 3) {
                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar5,0);
              }
              fVar7 = (float)Mathf.Lerp(*(uint32 *)(lVar4 + 32),*(uint32 *)(lVar4 + 56),fVar6
                                         ,0);
              if (*(uint32 *)(lVar4 + 24) == 0) {
                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar5,0);
              }
              if (*(uint32 *)(lVar4 + 24) < 3) {
                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar5,0);
              }
              fVar6 = (float)Mathf.Lerp(*(uint32 *)(lVar4 + 32),*(uint32 *)(lVar4 + 56),
                                         1.0 - fVar6,0);
              fVar8 = fVar6 - fVar7;
              if (fVar8 == 0.0) goto LAB_18168972b;
              cVar3 = UIProgressBar.get_isInverted(this,0);
              local_48 = (float)localPos;
              if (cVar3) {
                return (fVar6 - local_48) / fVar8;
              }
            }
            return (local_48 - fVar7) / fVar8;
          }
        }
    }

    // Token : 0x6000235
    // RVA   : 0x1689240   Offset: 0x1687A40   Length: 0x2DB
    public override void ForceUpdate()
    {
        ulong uVar1;
        uint uVar3;
        bool cVar4;
        long lVar6;
        float fVar8;
        uint uVar9;
        float fVar10;
        float fVar11;
        float fVar12;
        float fVar13;
        float fVar14;
        uint local_68;
        uint uStack_64;
        uint local_60;
        ulong local_58;
        ulong uStack_50;
        uVar1 = *(uint64 *)(this + 48);
        cVar4 = Object.op_Inequality(uVar1,0,0);
        if (!cVar4) {
          UIProgressBar.ForceUpdate(this);
          return;
        }
        *(uint8 *)(this + 80) = 0;
        fVar8 = (float)Mathf.Clamp01(this.mSize,0);
        fVar8 = fVar8 * 0.5;
        uVar9 = UIProgressBar.get_value(this,0);
        fVar10 = (float)Mathf.Lerp(fVar8,1.0 - fVar8,uVar9,0);
        fVar13 = fVar10 - fVar8;
        fVar10 = fVar10 + fVar8;
        cVar4 = UIProgressBar.get_isHorizontal(this,0);
        lVar6 = *(int64 *)(this + 48);
        if (!cVar4) {
          cVar4 = UIProgressBar.get_isInverted(this,0);
          fVar12 = 1.0;
          if (!cVar4) {
            fVar8 = 0.0;
            fVar11 = fVar13;
            fVar14 = fVar10;
          }
          else {
            fVar8 = 0.0;
            fVar11 = 1.0 - fVar10;
            fVar14 = 1.0 - fVar13;
          }
        }
        else {
          cVar4 = UIProgressBar.get_isInverted(this,0);
          fVar14 = 1.0;
          fVar11 = 0.0;
          fVar8 = fVar13;
          fVar12 = fVar10;
          if (cVar4) {
            fVar8 = 1.0 - fVar10;
            fVar12 = 1.0 - fVar13;
          }
        }
        uStack_50 = 0;
        local_58 = 0;
        FUN_1809981e0(&local_58,fVar8,fVar11,fVar12,fVar14,0);
        if (lVar6 != null) {
          UIWidget.set_drawRegion(lVar6,&local_58,0);
          uVar1 = *(uint64 *)(this + 32);
          cVar4 = Object.op_Inequality(uVar1,0,0);
          if (!cVar4) {
            return;
          }
          plVar2 = *(int64 **)(this + 48);
          if (plVar2 != (int64 *)0) {
            puVar5 = (uint32 *)
                     (**(code **)(*plVar2 + 0x2b8))(&local_58,plVar2,*(uint64 *)(*plVar2 + 0x2c0));
            uVar9 = puVar5[1];
            uVar3 = puVar5[3];
            local_68 = Mathf.Lerp(*puVar5,puVar5[2],0x3f000000,0);
            uStack_64 = Mathf.Lerp(uVar9,uVar3,0x3f000000,0);
            local_60 = 0;
            if ((*(int64 *)(this + 48) != 0) &&
               (lVar6 = UIRect.get_cachedTransform(*(int64 *)(this + 48),0)) != null) {
              local_58 = CONCAT44(uStack_64,local_68);
              uStack_50._0_4_ = local_60;
              puVar7 = (uint64 *)Transform.TransformPoint(&local_68,lVar6,&local_58,0);
              local_58 = *puVar7;
              uStack_50 = CONCAT44(uStack_50._4_4_,*(uint32 *)(puVar7 + 1));
              UIProgressBar.SetThumbPosition(this,&local_58,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000236
    // RVA   : 0x1689B20   Offset: 0x1688320   Length: 0x29
    public void /*ctor*/()
    {
        void FUN_181689b20(int64 this)
        {
        this.mSize = 0x3f800000;
        this.mDir = 2;
        *(uint32 *)(this + 120) = 0x3f800000;
        *(uint32 *)(this + 124) = 2;
        UIProgressBar.ctor(this,0);
    }

}
