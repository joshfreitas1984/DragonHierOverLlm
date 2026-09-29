// ============================================================
// Type  : UIScrollBar
// Token : 0x2000060
// ============================================================

public class UIScrollBar
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400025B
    protected float mSize;

    // Token: 0x400025C
    private float mScroll;

    // Token: 0x400025D
    private Direction mDir;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000246
    // RVA   : 0x16FC590   Offset: 0x16FB990   Length: 0x47
    public float get_scrollValue()
    {
        byte[] auVar1 = new byte[16];
        byte[] auVar2 = new byte[16];
        uint64 extraout_XMM0_Qb;
        if (*(int *)(this + 100) < 2) {
          return (uint64)(uint32)*(float *)(this + 56);
        }
        auVar1._0_8_ = FUN_18000d7c0((float)(*(int *)(this + 100) + -1) * *(float *)(this + 56));
        auVar1._8_8_ = extraout_XMM0_Qb;
        auVar2._4_12_ = auVar1._4_12_;
        auVar2._0_4_ = (float)auVar1._0_8_ / (float)(*(int *)(this + 100) + -1);
        return auVar2._0_8_;
    }

    // Token : 0x6000247
    // RVA   : 0x16FCCA0   Offset: 0x16FC0A0   Length: 0xB
    public void set_scrollValue(float value)
    {
        UIProgressBar.Set(this,value,1,0);
    }

    // Token : 0x6000248
    // RVA   : 0x15EFAF0   Offset: 0x15EEEF0   Length: 0x9
    public float get_barSize()
    {
        uint32 FUN_1815efaf0(int64 this)
        {
        return this.mSize;
    }

    // Token : 0x6000249
    // RVA   : 0x1701C70   Offset: 0x1701070   Length: 0x17A
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
            uVar1 = **(uint64 **)(DAT_181db0090 + 184);
            cVar4 = Object.op_Equality(uVar1,0,0);
            if ((cVar4) && (this[13] != 0)) {
              puVar2 = *(uint64 **)(DAT_181db0090 + 184);
              *puVar2 = this;
              il2cpp_internal(puVar2,this);
              lVar3 = this[13];
              EventDelegate.Execute(lVar3,0);
              puVar2 = *(uint64 **)(DAT_181db0090 + 184);
              *puVar2 = 0;
              il2cpp_internal(puVar2,0);
            }
            (**(code **)(*this + 0x1a8))(this,*(uint64 *)(*this + 0x1b0));
          }
        }
    }

    // Token : 0x600024A
    // RVA   : 0x1701B80   Offset: 0x1700F80   Length: 0x4C
    protected override void Upgrade()
    {
        void FUN_181701b80(int64 this)
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

    // Token : 0x600024B
    // RVA   : 0x1701890   Offset: 0x1700C90   Length: 0x2E8
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
            uVar2 = Component.GetComponent(*(int64 *)(this + 48),DAT_181d93b78);
            cVar1 = Object.op_Inequality(uVar2,0,0);
            if (!cVar1) {
              if (*(int64 *)(this + 48) == 0) throw; // [null/range check failed]
              uVar2 = Component.GetComponent(*(int64 *)(this + 48),DAT_181d93bf8);
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
                uVar3 = new OnTooltipCB(this,DAT_181dc68a0,0);
                plVar5 = (int64 *)Delegate.Combine(uVar2,uVar3,0);
                plVar7 = (int64 *)0;
                plVar6 = plVar7;
                if (plVar5 != (int64 *)0) {
                  if (*plVar5 == DAT_181d8d950) {
                    plVar6 = plVar5;
                  }
                  if (plVar6 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6070(plVar5,DAT_181d8d950);
                  }
                }
                *(int64 **)(lVar4 + 64) = plVar6;
                uVar2 = *(uint64 *)(lVar4 + 96);
                uVar3 = new OnTooltipCB(this,DAT_181dc6790,0);
                plVar6 = (int64 *)Delegate.Combine(uVar2,uVar3,0);
                if (plVar6 != (int64 *)0) {
                  if (*plVar6 == DAT_181d8d9d0) {
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

    // Token : 0x600024C
    // RVA   : 0x17015C0   Offset: 0x17009C0   Length: 0x2CC
    protected override float LocalToValue(Vector2 localPos)
    {
        void UIScrollBar.LocalToValue
                     (int64 this,uint64 localPos,uint64 param_3,uint64 param_4)
        {
        int64 *plVar1;
        char cVar2;
        int64 lVar3;
        uint64 uVar4;
        float fVar5;
        float fVar6;
        uVar4 = *(uint64 *)(this + 48);
        cVar2 = Object.op_Inequality(uVar4,0,0);
        if (!cVar2) {
          UIProgressBar.LocalToValue(this,localPos,0);
          return;
        }
        Mathf.Clamp01();
        plVar1 = *(int64 **)(this + 48);
        if (plVar1 != (int64 *)0) {
          lVar3 = (**(code **)(*plVar1 + 0x1d8))(plVar1,*(uint64 *)(*plVar1 + 0x1e0));
          if ((*(int *)(this + 60) == 0) || (*(int *)(this + 60) == 1)) {
            if (lVar3 == null) throw; // [null/range check failed]
            if (*(uint32 *)(lVar3 + 24) == 0) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            if (*(uint32 *)(lVar3 + 24) < 3) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            fVar5 = (float)Mathf.Lerp();
            if (*(uint32 *)(lVar3 + 24) == 0) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            if (*(uint32 *)(lVar3 + 24) < 3) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            fVar6 = (float)Mathf.Lerp();
            fVar6 = fVar6 - fVar5;
          }
          else {
            if (lVar3 == null) throw; // [null/range check failed]
            if (*(uint32 *)(lVar3 + 24) == 0) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            if (*(uint32 *)(lVar3 + 24) < 2) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            fVar5 = (float)Mathf.Lerp();
            if (*(uint32 *)(lVar3 + 24) < 4) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
            fVar6 = (float)Mathf.Lerp();
            fVar6 = fVar6 - fVar5;
          }
          if (fVar6 == 0.0) {
            if (1 < *(int *)(this + 100)) {
              FUN_18000d7c0((float)(*(int *)(this + 100) + -1) * *(float *)(this + 56));
            }
          }
          return;
        }
    }

    // Token : 0x600024D
    // RVA   : 0x17012F0   Offset: 0x17006F0   Length: 0x2C3
    public override void ForceUpdate()
    {
        int iVar1;
        ulong uVar2;
        bool cVar4;
        long lVar5;
        float fVar7;
        float fVar8;
        float fVar9;
        float fVar10;
        float fVar11;
        uint local_48;
        uint uStack_44;
        uint local_40;
        ulong local_38;
        ulong uStack_30;
        uVar2 = *(uint64 *)(this + 48);
        cVar4 = Object.op_Inequality(uVar2,0,0);
        if (!cVar4) {
          UIProgressBar.ForceUpdate(this);
          return;
        }
        *(uint8 *)(this + 80) = 0;
        fVar7 = (float)Mathf.Clamp01();
        if (1 < *(int *)(this + 100)) {
          FUN_18000d7c0((float)(*(int *)(this + 100) + -1) * *(float *)(this + 56));
        }
        fVar8 = (float)Mathf.Lerp();
        iVar1 = *(int *)(this + 60);
        fVar11 = fVar8 + fVar7 * 0.5;
        fVar8 = fVar8 - fVar7 * 0.5;
        lVar5 = *(int64 *)(this + 48);
        fVar7 = fVar8;
        if (iVar1 != 0) {
          fVar10 = 1.0;
          if (iVar1 != 1) {
            if (iVar1 == 3) {
              fVar9 = 1.0 - fVar8;
              fVar8 = 1.0 - fVar11;
              fVar7 = 0.0;
              fVar11 = fVar9;
            }
            else {
              fVar7 = 0.0;
            }
            goto LAB_181701477;
          }
          fVar7 = 1.0 - fVar11;
          fVar11 = 1.0 - fVar8;
        }
        fVar8 = 0.0;
        fVar10 = fVar11;
        fVar11 = 1.0;
        LAB_181701477:
        uStack_30 = 0;
        local_38 = 0;
        FUN_1809dcfa0(&local_38,fVar7,fVar8,fVar10,fVar11,0);
        if (lVar5 != null) {
          UIWidget.set_drawRegion(lVar5,&local_38,0);
          uVar2 = *(uint64 *)(this + 32);
          cVar4 = Object.op_Inequality(uVar2,0,0);
          if (!cVar4) {
            return;
          }
          plVar3 = *(int64 **)(this + 48);
          if (plVar3 != (int64 *)0) {
            (**(code **)(*plVar3 + 0x2b8))(&local_38,plVar3,*(uint64 *)(*plVar3 + 0x2c0));
            local_48 = Mathf.Lerp();
            uStack_44 = Mathf.Lerp();
            local_40 = 0;
            if ((*(int64 *)(this + 48) != 0) &&
               (lVar5 = UIRect.get_cachedTransform(*(int64 *)(this + 48),0)) != null) {
              local_38 = CONCAT44(uStack_44,local_48);
              uStack_30._0_4_ = local_40;
              puVar6 = (uint64 *)Transform.TransformPoint(&local_48,lVar5,&local_38,0);
              local_38 = *puVar6;
              uStack_30 = CONCAT44(uStack_30._4_4_,*(uint32 *)(puVar6 + 1));
              UIProgressBar.SetThumbPosition(this,&local_38,0);
              return;
            }
          }
        }
    }

    // Token : 0x600024E
    // RVA   : 0x1701BD0   Offset: 0x1700FD0   Length: 0x9F
    public void /*ctor*/()
    {
        ulong uVar1;
        bVar2 = !DAT_181ea3d2a;
        this.mSize = 0x3f800000;
        this.mDir = 2;
        *(uint32 *)(this + 120) = 0x3f800000;
        *(uint32 *)(this + 124) = 2;
        if (bVar2) {
          il2cpp_runtime_class_init(&DAT_181d85eb8);
          il2cpp_runtime_class_init(&DAT_181d92670);
          DAT_181ea3d2a = true;
        }
        *(uint32 *)(this + 56) = 0x3f800000;
        uVar1 = il2cpp_internal(DAT_181d92670);
        FUN_181330100(uVar1,DAT_181d85eb8);
        *(uint64 *)(this + 104) = uVar1;
        TrailRenderer_Base.ctor(this,0);
    }

}
