// ============================================================
// Type  : UIRect
// Token : 0x20000A8
// ============================================================

public class UIRect
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000403
    public AnchorPoint leftAnchor;

    // Token: 0x4000404
    public AnchorPoint rightAnchor;

    // Token: 0x4000405
    public AnchorPoint bottomAnchor;

    // Token: 0x4000406
    public AnchorPoint topAnchor;

    // Token: 0x4000407
    public AnchorUpdate updateAnchors;

    // Token: 0x4000408
    protected GameObject mGo;

    // Token: 0x4000409
    protected Transform mTrans;

    // Token: 0x400040A
    protected BetterList<UIRect> mChildren;

    // Token: 0x400040B
    protected bool mChanged;

    // Token: 0x400040C
    protected bool mParentFound;

    // Token: 0x400040D
    private bool mUpdateAnchors;

    // Token: 0x400040E
    private int mUpdateFrame;

    // Token: 0x400040F
    private bool mAnchorsCached;

    // Token: 0x4000410
    private UIRoot mRoot;

    // Token: 0x4000411
    private UIRect mParent;

    // Token: 0x4000412
    private bool mRootSet;

    // Token: 0x4000413
    protected Camera mCam;

    // Token: 0x4000414
    protected bool mStarted;

    // Token: 0x4000415
    public float finalAlpha;

    // Token: 0x4000416
    protected static Vector3[] mSides;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60004EE
    // RVA   : 0x16FEC60   Offset: 0x16FE060   Length: 0x8F
    public GameObject get_cachedGameObject()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = this.mGo;
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          uVar2 = Component.get_gameObject(this,0);
          this.mGo = uVar2;
        }
        return this.mGo;
    }

    // Token : 0x60004EF
    // RVA   : 0x16FECF0   Offset: 0x16FE0F0   Length: 0x8F
    public Transform get_cachedTransform()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = this.mTrans;
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          uVar2 = Component.get_transform(this,0);
          this.mTrans = uVar2;
        }
        return this.mTrans;
    }

    // Token : 0x60004F0
    // RVA   : 0x16FEBE0   Offset: 0x16FDFE0   Length: 0x7E
    public Camera get_anchorCamera()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.mCam;
        cVar2 = Object.op_Implicit(uVar1,0);
        if ((!cVar2) || (!this.mAnchorsCached)) {
          UIRect.ResetAnchors(this,0);
        }
        return this.mCam;
    }

    // Token : 0x60004F1
    // RVA   : 0x16FF300   Offset: 0x16FE700   Length: 0x132
    public bool get_isFullyAnchored()
    {
        ulong uVar1;
        ulong uVar2;
        if (this.leftAnchor != null) {
          uVar1 = this.leftAnchor.target;
          uVar2 = Object.op_Implicit(uVar1,0);
          if ((char)!uVar2) {
        LAB_1816ff420:
            return uVar2 & 0xffffffffffffff00;
          }
          if (this.rightAnchor != null) {
            uVar1 = this.rightAnchor.target;
            uVar2 = Object.op_Implicit(uVar1,0);
            if ((char)!uVar2) goto LAB_1816ff420;
            if (this.topAnchor != null) {
              uVar1 = this.topAnchor.target;
              uVar2 = Object.op_Implicit(uVar1,0);
              if ((char)!uVar2) goto LAB_1816ff420;
              if (this.bottomAnchor != null) {
                uVar1 = this.bottomAnchor.target;
                uVar2 = Object.op_Implicit(uVar1,0);
                return uVar2;
              }
            }
          }
        }
    }

    // Token : 0x60004F2
    // RVA   : 0x16FF040   Offset: 0x16FE440   Length: 0xAF
    public virtual bool get_isAnchoredHorizontally()
    {
        bool cVar1;
        ulong uVar2;
        if (this.leftAnchor != null) {
          uVar2 = this.leftAnchor.target;
          cVar1 = Object.op_Implicit(uVar2,0);
          if (cVar1) {
            return true;
          }
          if (this.rightAnchor != null) {
            uVar2 = this.rightAnchor.target;
            uVar2 = Object.op_Implicit(uVar2,0);
            return uVar2;
          }
        }
    }

    // Token : 0x60004F3
    // RVA   : 0x16FF0F0   Offset: 0x16FE4F0   Length: 0xAF
    public virtual bool get_isAnchoredVertically()
    {
        bool cVar1;
        ulong uVar2;
        if (this.bottomAnchor != null) {
          uVar2 = this.bottomAnchor.target;
          cVar1 = Object.op_Implicit(uVar2,0);
          if (cVar1) {
            return true;
          }
          if (this.topAnchor != null) {
            uVar2 = this.topAnchor.target;
            uVar2 = Object.op_Implicit(uVar2,0);
            return uVar2;
          }
        }
    }

    // Token : 0x60004F4
    // RVA   : 0x216180   Offset: 0x215580   Length: 0x3
    public virtual bool get_canBeAnchored()
    {
        return true;
    }

    // Token : 0x60004F5
    // RVA   : 0x16FF440   Offset: 0x16FE840   Length: 0xAC
    public UIRect get_parent()
    {
        long lVar1;
        ulong uVar2;
        if (!this.mParentFound) {
          this.mParentFound = 1;
          lVar1 = UIRect.get_cachedTransform(this,0);
          if (lVar1 == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar2 = FUN_180da9a20(lVar1,0);
          uVar2 = NGUITools.FindInParents(uVar2,DAT_181d8f7a0);
          this.mParent = uVar2;
        }
        return this.mParent;
    }

    // Token : 0x60004F6
    // RVA   : 0x16FF4F0   Offset: 0x16FE8F0   Length: 0xFD
    public UIRoot get_root()
    {
        uint64
        UIRect.get_root(int64 this,uint64 param_2,uint64 param_3,uint64 param_4)
        {
        char cVar1;
        uint64 uVar2;
        uint64 unaff_RDI;
        while( true ) {
          uVar2 = UIRect.get_parent(this,0);
          cVar1 = Object.op_Inequality(uVar2,0,0,param_4,unaff_RDI);
          if (!cVar1) break;
          this = this.mParent;
          if (this == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        if (!this.mRootSet) {
          this.mRootSet = 1;
          uVar2 = UIRect.get_cachedTransform(this,0);
          uVar2 = NGUITools.FindInParents(uVar2,DAT_181d8f8a0);
          this.mRoot = uVar2;
        }
        return this.mRoot;
    }

    // Token : 0x60004F7
    // RVA   : 0x16FF1A0   Offset: 0x16FE5A0   Length: 0x150
    public bool get_isAnchored()
    {
        ulong uVar1;
        bool cVar2;
        if (this[3] != 0) {
          uVar1 = *(uint64 *)(this[3] + 16);
          cVar2 = Object.op_Implicit(uVar1,0);
          if (!cVar2) {
            if (this[4] == 0) throw; // [null/range check failed]
            uVar1 = *(uint64 *)(this[4] + 16);
            cVar2 = Object.op_Implicit(uVar1,0);
            if (!cVar2) {
              if (this[6] == 0) throw; // [null/range check failed]
              uVar1 = *(uint64 *)(this[6] + 16);
              cVar2 = Object.op_Implicit(uVar1,0);
              if (!cVar2) {
                if (this[5] == 0) throw; // [null/range check failed]
                uVar1 = *(uint64 *)(this[5] + 16);
                cVar2 = Object.op_Implicit(uVar1,0);
                if (!cVar2) {
                  return;
                }
              }
            }
          }
                          // WARNING: Could not recover jumptable at 0x0001816ff2e4. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*this + 0x198))(this,*(uint64 *)(*this + 0x1a0));
          return;
        }
    }

    // Token : 0x60004F8
    // (no native address)
    public virtual float get_alpha()
    {
    }

    // Token : 0x60004F9
    // (no native address)
    public virtual void set_alpha(float value)
    {
    }

    // Token : 0x60004FA
    // (no native address)
    public virtual float CalculateFinalAlpha(int frameID)
    {
    }

    // Token : 0x60004FB
    // (no native address)
    public virtual Vector3[] get_localCorners()
    {
    }

    // Token : 0x60004FC
    // (no native address)
    public virtual Vector3[] get_worldCorners()
    {
    }

    // Token : 0x60004FD
    // RVA   : 0x16FED80   Offset: 0x16FE180   Length: 0x2B8
    protected float get_cameraRayDistance()
    {
        ulong uVar1;
        ulong uVar2;
        bool cVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        uint uVar8;
        uint uVar9;
        ulong uVar10;
        uint[] local_res18 = new uint[4];
        ulong local_a8;
        uint local_a0;
        ulong local_98;
        uint local_90;
        ulong local_88;
        ulong uStack_80;
        ulong local_78;
        ulong uStack_70;
        ulong local_68;
        ulong local_58;
        ulong uStack_50;
        ulong local_48;
        local_48 = 0;
        local_res18[0] = 0;
        local_88 = 0;
        uStack_80 = 0;
        local_58 = 0;
        uStack_50 = 0;
        uVar4 = UIRect.get_anchorCamera(this,0);
        cVar3 = Object.op_Equality(uVar4,0,0);
        if (cVar3) {
          return 0;
        }
        if (this.mCam == null) throw; // [null/range check failed]
        cVar3 = Camera.get_orthographic(this.mCam,0);
        if (!cVar3) {
          lVar5 = UIRect.get_cachedTransform(this,0);
          if ((this.mCam == null) ||
             (lVar6 = Component.get_transform(this.mCam,0), lVar5 == null))
          throw; // [null/range check failed]
          puVar7 = (uint64 *)Transform.get_rotation(&local_78,lVar5,0);
          uVar4 = *puVar7;
          uVar1 = puVar7[1];
          puVar7 = (uint64 *)Vector3.get_back(&local_98,0);
          local_a8 = *puVar7;
          local_a0 = *(uint32 *)(puVar7 + 1);
          local_78 = uVar4;
          uStack_70 = uVar1;
          puVar7 = (uint64 *)Quaternion.op_Multiply(&local_98,&local_78,&local_a8,0);
          uVar4 = *puVar7;
          uVar8 = *(uint32 *)(puVar7 + 1);
          puVar7 = (uint64 *)Transform.get_position(&local_98,lVar5,0);
          local_a8 = *puVar7;
          local_a0 = *(uint32 *)(puVar7 + 1);
          local_98 = uVar4;
          local_90 = uVar8;
          Plane.ctor(&local_88,&local_98,&local_a8,0);
          if (lVar6 == null) throw; // [null/range check failed]
          puVar7 = (uint64 *)Transform.get_position(&local_98,lVar6,0);
          uVar4 = *puVar7;
          uVar8 = *(uint32 *)(puVar7 + 1);
          puVar7 = (uint64 *)Transform.get_rotation(&local_78,lVar6,0);
          uVar1 = *puVar7;
          uVar2 = puVar7[1];
          puVar7 = (uint64 *)Vector3.get_forward(&local_a8,0);
          local_98 = *puVar7;
          local_90 = *(uint32 *)(puVar7 + 1);
          local_78 = uVar1;
          uStack_70 = uVar2;
          puVar7 = (uint64 *)Quaternion.op_Multiply(&local_a8,&local_78,&local_98,0);
          local_98 = *puVar7;
          local_90 = *(uint32 *)(puVar7 + 1);
          local_a8 = uVar4;
          local_a0 = uVar8;
          Ray.ctor(&local_58,&local_a8,&local_98,0);
          local_78 = local_58;
          uStack_70 = uStack_50;
          local_68 = local_48;
          cVar3 = Plane.Raycast(&local_88,&local_78,local_res18,0);
          if (cVar3) {
            return (uint64)local_res18[0];
          }
        }
        if (this.mCam != null) {
          uVar8 = Camera.get_nearClipPlane(this.mCam,0);
          if (this.mCam != null) {
            uVar9 = Camera.get_farClipPlane(this.mCam,0);
            uVar10 = Mathf.Lerp(uVar8,uVar9,0x3f000000,0);
            return uVar10;
          }
        }
    }

    // Token : 0x60004FE
    // RVA   : 0x16FD330   Offset: 0x16FC730   Length: 0x92
    public virtual void Invalidate(bool includeChildren)
    {
        long lVar1;
        long lVar2;
        ulong uVar4;
        uint uVar5;
        this.mChanged = 1;
        if (!includeChildren) {
          return;
        }
        uVar5 = 0;
        lVar1 = this.mChildren;
        while (lVar1 != null) {
          if (lVar1.size <= (int)uVar5) {
            return;
          }
          if ((lVar1 == null) || (lVar2 = lVar1.buffer) == null) break;
          if (*(uint32 *)(lVar2 + 24) <= uVar5) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          plVar3 = lVar2[uVar5];
          if (plVar3 == (int64 *)0) break;
          (**(code **)(*plVar3 + 0x1f8))
                    (plVar3,CONCAT71((int7)((uint64)lVar1 >> 8),1),*(uint64 *)(*plVar3 + 0x200));
          uVar5 = uVar5 + 1;
          lVar1 = this.mChildren;
        }
    }

    // Token : 0x60004FF
    // RVA   : 0x16FD060   Offset: 0x16FC460   Length: 0x2C3
    public virtual Vector3[] GetSides(Transform relativeTo)
    {
        var pStatics = *(int64*)(DAT_181db00f8 + 184);
        bool cVar1;
        ulong uVar2;
        long lVar3;
        long lVar5;
        uint uVar6;
        uint uVar7;
        uint uVar8;
        ulong local_38;
        uint local_30;
        byte[] local_28 = new byte[32];
        uVar2 = UIRect.get_anchorCamera(this,0);
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (!cVar1) {
          lVar3 = UIRect.get_cachedTransform();
          if (lVar3 == null) {
        LAB_1816fd31e:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          puVar4 = (uint64 *)Transform.get_position(&local_38,lVar3,0);
          uVar7 = 0;
          uVar6 = 0;
          uVar2 = *puVar4;
          uVar8 = *(uint32 *)(puVar4 + 1);
          do {
            lVar3 = *pStatics;
            if (lVar3 == null) goto LAB_1816fd31e;
            if (*(uint32 *)(lVar3 + 24) <= uVar6) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            lVar5 = (int64)(int)uVar6;
            uVar6 = uVar6 + 1;
            *(uint64 *)(lVar3 + 32 + lVar5 * 12) = uVar2;
            *(uint32 *)(lVar3 + 40 + lVar5 * 12) = uVar8;
          } while ((int)uVar6 < 4);
          cVar1 = Object.op_Inequality(relativeTo,0,0);
          if (cVar1) {
            do {
              lVar3 = *pStatics;
              if (lVar3 == null) goto LAB_1816fd31e;
              lVar5 = (int64)(int)uVar7;
              if (*(uint32 *)(lVar3 + 24) <= uVar7) {
                uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar2,0);
              }
              if (relativeTo == null) goto LAB_1816fd31e;
              local_38 = *(uint64 *)(lVar3 + 32 + lVar5 * 12);
              local_30 = *(uint32 *)(lVar3 + 40 + lVar5 * 12);
              puVar4 = (uint64 *)Transform.InverseTransformPoint(local_28,relativeTo,&local_38,0);
              if (*(uint32 *)(lVar3 + 24) <= uVar7) {
                uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar2,0);
              }
              uVar7 = uVar7 + 1;
              *(uint64 *)(lVar3 + 32 + lVar5 * 12) = *puVar4;
              *(uint32 *)(lVar3 + 40 + lVar5 * 12) = *(uint32 *)(puVar4 + 1);
            } while ((int)uVar7 < 4);
          }
          uVar2 = **(uint64 **)(DAT_181db00f8 + 184);
        }
        else {
          uVar2 = this.mCam;
          uVar8 = UIRect.get_cameraRayDistance(this,0);
          uVar2 = NGUITools.GetSides(uVar2,uVar8,relativeTo,0);
        }
        return uVar2;
    }

    // Token : 0x6000500
    // RVA   : 0x16FCD10   Offset: 0x16FC110   Length: 0x348
    protected Vector3 GetLocalPos(AnchorPoint ac, Transform trans)
    {
        uint64 *
        UIRect.GetLocalPos(uint64 *this,int64 ac,int64 trans,int64 param_4)
        {
        char cVar1;
        uint64 uVar2;
        uint32 *puVar3;
        uint64 *puVar4;
        int64 lVar5;
        uint32 uVar6;
        float fVar7;
        float fVar8;
        float fVar9;
        uint64 local_98;
        uint32 local_90;
        uint64 local_88;
        uint32 local_80;
        uint8 local_78 [16];
        uint32 local_68;
        uint32 uStack_64;
        uint32 uStack_60;
        uint32 uStack_5c;
        if (trans == null) throw; // [null/range check failed]
        uVar2 = *(uint64 *)(trans + 40);
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          UIRect.FindCameraFor(ac,trans,0);
        }
        uVar2 = UIRect.get_anchorCamera(ac,0);
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (!cVar1) {
          uVar2 = *(uint64 *)(trans + 40);
          cVar1 = Object.op_Equality(uVar2,0,0);
          if (!cVar1) {
            if (*(int64 *)(trans + 40) != 0) {
              puVar3 = (uint32 *)Camera.get_rect(local_78,*(int64 *)(trans + 40),0);
              lVar5 = *(int64 *)(trans + 40);
              local_68 = *puVar3;
              uStack_64 = puVar3[1];
              uStack_60 = puVar3[2];
              uStack_5c = puVar3[3];
              if ((*(int64 *)(trans + 16) != 0) &&
                 (puVar4 = (uint64 *)
                           Transform.get_position(&local_88,*(int64 *)(trans + 16),0), lVar5 != null)
                 ) {
                local_98 = *puVar4;
                local_90 = *(uint32 *)(puVar4 + 1);
                puVar4 = (uint64 *)Camera.WorldToViewportPoint(&local_88,lVar5,&local_98,0);
                uVar2 = *puVar4;
                local_80 = *(uint32 *)(puVar4 + 1);
                fVar7 = (float)FUN_180d98fa0(&local_68,0);
                fVar8 = (float)FUN_180d98fc0(&local_68,0);
                fVar9 = (float)FUN_18044e2b0(&local_68,0);
                local_98 = CONCAT44(local_98._4_4_,(float)uVar2 * fVar7 + fVar8);
                fVar7 = (float)FUN_18044df60(&local_68,0);
                local_98 = CONCAT44(fVar7 + (float)((uint64)uVar2 >> 32) * fVar9,(float)local_98);
                local_90 = local_80;
                local_88 = uVar2;
                if (*(int64 *)(ac + 128) != 0) {
                  local_88 = local_98;
                  puVar4 = (uint64 *)
                           Camera.ViewportToWorldPoint
                                     (local_78,*(int64 *)(ac + 128),&local_88,0);
                  uVar2 = *puVar4;
                  uVar6 = *(uint32 *)(puVar4 + 1);
                  local_98 = uVar2;
                  cVar1 = Object.op_Inequality(param_4,0,0);
                  if (cVar1) {
                    if (param_4 == 0) throw; // [null/range check failed]
                    local_88 = uVar2;
                    local_80 = uVar6;
                    puVar4 = (uint64 *)Transform.InverseTransformPoint(local_78,param_4,&local_88,0);
                    local_98 = *puVar4;
                    uVar6 = *(uint32 *)(puVar4 + 1);
                  }
                  fVar7 = floorf((float)local_98 + 0.5);
                  fVar8 = floorf(local_98._4_4_ + 0.5);
                  *this = CONCAT44(fVar8,fVar7);
                  *(uint32 *)(this + 1) = uVar6;
                  return this;
                }
              }
            }
            throw; // [null/range check failed]
          }
        }
        lVar5 = UIRect.get_cachedTransform(ac,0);
        if (lVar5 != null) {
          puVar4 = (uint64 *)Transform.get_localPosition(local_78,lVar5,0);
          uVar6 = *(uint32 *)(puVar4 + 1);
          *this = *puVar4;
          *(uint32 *)(this + 1) = uVar6;
          return this;
        }
    }

    // Token : 0x6000501
    // RVA   : 0x16FD4A0   Offset: 0x16FC8A0   Length: 0x51
    protected virtual void OnEnable()
    {
        *(uint32 *)((int64)this + 92) = 0xffffffff;
        if ((int)this[7] == 0) {
          *(uint8 *)(this + 12) = 0;
          *(uint8 *)((int64)this + 90) = 1;
        }
        if ((char)this[17] != false) {
          (**(code **)(*this + 0x228))(this,*(uint64 *)(*this + 0x230));
          *(uint32 *)((int64)this + 92) = 0xffffffff;
          return;
        }
        *(uint32 *)((int64)this + 92) = 0xffffffff;
    }

    // Token : 0x6000502
    // RVA   : 0x16FD500   Offset: 0x16FC900   Length: 0xAC
    protected virtual void OnInit()
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        this.mChanged = 1;
        this.mRootSet = 0;
        uVar3 = UIRect.get_parent(this,0);
        cVar2 = Object.op_Inequality(uVar3,0,0);
        if (cVar2) {
          if ((this.mParent == null) ||
             (lVar1 = this.mParent.mChildren) == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          FUN_181583c60(lVar1,this,DAT_181da6fb8);
        }
    }

    // Token : 0x6000503
    // RVA   : 0x16FD3D0   Offset: 0x16FC7D0   Length: 0xC7
    protected virtual void OnDisable()
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        uVar1 = this.mParent;
        cVar3 = Object.op_Implicit(uVar1,0);
        if (cVar3) {
          if ((this.mParent == null) ||
             (lVar2 = this.mParent.mChildren) == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          FUN_181585c70(lVar2,this,DAT_181da7038);
        }
        this.mParent = 0;
        this.mRoot = 0;
        this.mRootSet = 0;
        this.mParentFound = 0;
    }

    // Token : 0x6000504
    // RVA   : 0x16FCB30   Offset: 0x16FBF30   Length: 0xA1
    protected virtual void Awake()
    {
        ulong uVar1;
        uVar1 = Component.get_gameObject(this,0);
        ZhSegment.Initialize(uVar1,0);
        this.mStarted = 0;
        uVar1 = Component.get_gameObject(this,0);
        this.mGo = uVar1;
        uVar1 = Component.get_transform(this,0);
        this.mTrans = uVar1;
    }

    // Token : 0x6000505
    // RVA   : 0x16FE490   Offset: 0x16FD890   Length: 0x39
    protected void Start()
    {
        *(uint8 *)(this + 17) = 1;
        (**(code **)(*this + 0x228))(this,*(uint64 *)(*this + 0x230));
                          // WARNING: Could not recover jumptable at 0x0001816fe4c2. Too many branches
                          // WARNING: Treating indirect jump as call
        (**(code **)(*this + 0x288))(this,*(uint64 *)(*this + 0x290));
    }

    // Token : 0x6000506
    // RVA   : 0x16FE950   Offset: 0x16FDD50   Length: 0xCC
    public void Update()
    {
        long lVar1;
        bool cVar2;
        int iVar3;
        lVar1 = this[16];
        cVar2 = Object.op_Implicit(lVar1,0);
        if (!cVar2) {
          UIRect.ResetAnchors(this,0);
          UIRect.UpdateAnchors(this,0);
          *(uint32 *)((int64)this + 92) = 0xffffffff;
        }
        else if ((char)this[12] == false) {
          UIRect.ResetAnchors(this,0);
        }
        iVar3 = Time.get_frameCount(0);
        if (*(int *)((int64)this + 92) != iVar3) {
          if (((int)this[7] == 1) || (*(char *)((int64)this + 90) != false)) {
            UIRect.UpdateAnchorsInternal(this,iVar3,0);
          }
          (**(code **)(*this + 0x298))(this,*(uint64 *)(*this + 0x2a0));
        }
    }

    // Token : 0x6000507
    // RVA   : 0x16FE4D0   Offset: 0x16FD8D0   Length: 0x300
    protected void UpdateAnchorsInternal(int frame)
    {
        ulong uVar1;
        long lVar2;
        bool cVar4;
        bVar3 = false;
        *(int *)((int64)this + 92) = frame;
        *(uint8 *)((int64)this + 90) = 0;
        if (this[3] != 0) {
          uVar1 = *(uint64 *)(this[3] + 16);
          cVar4 = Object.op_Implicit(uVar1,0);
          if (cVar4) {
            bVar3 = true;
            if (this[3] == 0) throw; // [null/range check failed]
            uVar1 = *(uint64 *)(this[3] + 32);
            cVar4 = Object.op_Inequality(uVar1,0,0);
            if (cVar4) {
              if ((this[3] == 0) || (lVar2 = *(int64 *)(this[3] + 32)) == null)
              throw; // [null/range check failed]
              if (*(int *)(lVar2 + 92) != frame) {
                UIRect.Update(lVar2,0);
              }
            }
          }
          if (this[5] != 0) {
            uVar1 = *(uint64 *)(this[5] + 16);
            cVar4 = Object.op_Implicit(uVar1,0);
            if (cVar4) {
              bVar3 = true;
              if (this[5] == 0) throw; // [null/range check failed]
              uVar1 = *(uint64 *)(this[5] + 32);
              cVar4 = Object.op_Inequality(uVar1,0,0);
              if (cVar4) {
                if ((this[5] == 0) || (lVar2 = *(int64 *)(this[5] + 32)) == null)
                throw; // [null/range check failed]
                if (*(int *)(lVar2 + 92) != frame) {
                  UIRect.Update(lVar2,0);
                }
              }
            }
            if (this[4] != 0) {
              uVar1 = *(uint64 *)(this[4] + 16);
              cVar4 = Object.op_Implicit(uVar1,0);
              if (cVar4) {
                bVar3 = true;
                if (this[4] == 0) throw; // [null/range check failed]
                uVar1 = *(uint64 *)(this[4] + 32);
                cVar4 = Object.op_Inequality(uVar1,0,0);
                if (cVar4) {
                  if ((this[4] == 0) || (lVar2 = *(int64 *)(this[4] + 32)) == null)
                  throw; // [null/range check failed]
                  if (*(int *)(lVar2 + 92) != frame) {
                    UIRect.Update(lVar2,0);
                  }
                }
              }
              if (this[6] != 0) {
                uVar1 = *(uint64 *)(this[6] + 16);
                cVar4 = Object.op_Implicit(uVar1,0);
                if (!cVar4) {
                  if (!bVar3) {
                    return;
                  }
                }
                else {
                  if (this[6] == 0) throw; // [null/range check failed]
                  uVar1 = *(uint64 *)(this[6] + 32);
                  cVar4 = Object.op_Inequality(uVar1,0,0);
                  if (cVar4) {
                    if ((this[6] == 0) || (lVar2 = *(int64 *)(this[6] + 32)) == null)
                    throw; // [null/range check failed]
                    if (*(int *)(lVar2 + 92) != frame) {
                      UIRect.Update(lVar2,0);
                    }
                  }
                }
                (**(code **)(*this + 600))(this,*(uint64 *)(*this + 0x260));
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000508
    // RVA   : 0x16FE7E0   Offset: 0x16FDBE0   Length: 0x164
    public void UpdateAnchors()
    {
        ulong uVar1;
        bool cVar2;
        uint uVar3;
        if (this[3] != 0) {
          uVar1 = *(uint64 *)(this[3] + 16);
          cVar2 = Object.op_Implicit(uVar1,0);
          if (!cVar2) {
            if (this[4] == 0) throw; // [null/range check failed]
            uVar1 = *(uint64 *)(this[4] + 16);
            cVar2 = Object.op_Implicit(uVar1,0);
            if (!cVar2) {
              if (this[6] == 0) throw; // [null/range check failed]
              uVar1 = *(uint64 *)(this[6] + 16);
              cVar2 = Object.op_Implicit(uVar1,0);
              if (!cVar2) {
                if (this[5] == 0) throw; // [null/range check failed]
                uVar1 = *(uint64 *)(this[5] + 16);
                cVar2 = Object.op_Implicit(uVar1,0);
                if (!cVar2) {
                  return;
                }
              }
            }
          }
          cVar2 = (**(code **)(*this + 0x198))(this,*(uint64 *)(*this + 0x1a0));
          if (cVar2) {
            *(uint32 *)((int64)this + 92) = 0xffffffff;
            *(uint8 *)((int64)this + 90) = 1;
            uVar3 = Time.get_frameCount(0);
            UIRect.UpdateAnchorsInternal(this,uVar3,0);
          }
          return;
        }
    }

    // Token : 0x6000509
    // (no native address)
    protected virtual void OnAnchor()
    {
    }

    // Token : 0x600050A
    // RVA   : 0x16FE100   Offset: 0x16FD500   Length: 0x90
    public void SetAnchor(Transform t)
    {
                            uint32 param_5,uint32 param_6,uint32 param_7,uint32 param_8,
                            uint32 param_9)
        {
        int64 lVar1;
        uint64 uVar2;
        uint64 *puVar3;
        lVar1 = UIRect.get_cachedTransform(this,0);
        if (lVar1 != null) {
          uVar2 = FUN_180da9a20(lVar1,0);
          if (this.leftAnchor != null) {
            this.leftAnchor.target = uVar2;
            if (this.rightAnchor != null) {
              this.rightAnchor.target = uVar2;
              if (this.topAnchor != null) {
                this.topAnchor.target = uVar2;
                if (this.bottomAnchor != null) {
                  this.bottomAnchor.target = uVar2;
                  if (this.leftAnchor != null) {
                    this.leftAnchor.relative = t;
                    if (this.rightAnchor != null) {
                      this.rightAnchor.relative = param_6;
                      if (this.bottomAnchor != null) {
                        this.bottomAnchor.relative = param_4;
                        if (this.topAnchor != null) {
                          this.topAnchor.relative = param_8;
                          if (this.leftAnchor != null) {
                            this.leftAnchor.absolute = param_3;
                            if (this.rightAnchor != null) {
                              this.rightAnchor.absolute = param_7;
                              if (this.bottomAnchor != null) {
                                this.bottomAnchor.absolute = param_5;
                                if (this.topAnchor != null) {
                                  this.topAnchor.absolute = param_9;
                                  UIRect.ResetAnchors(this,0);
                                  UIRect.UpdateAnchors(this,0);
                                  return;
                                }
                              }
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600050B
    // RVA   : 0x16FDAE0   Offset: 0x16FCEE0   Length: 0xF8
    public void SetAnchor(GameObject go)
    {
                            uint32 param_5,uint32 param_6,uint32 param_7,uint32 param_8,
                            uint32 param_9)
        {
        int64 lVar1;
        uint64 uVar2;
        uint64 *puVar3;
        lVar1 = UIRect.get_cachedTransform(this,0);
        if (lVar1 != null) {
          uVar2 = FUN_180da9a20(lVar1,0);
          if (this.leftAnchor != null) {
            this.leftAnchor.target = uVar2;
            if (this.rightAnchor != null) {
              this.rightAnchor.target = uVar2;
              if (this.topAnchor != null) {
                this.topAnchor.target = uVar2;
                if (this.bottomAnchor != null) {
                  this.bottomAnchor.target = uVar2;
                  if (this.leftAnchor != null) {
                    this.leftAnchor.relative = go;
                    if (this.rightAnchor != null) {
                      this.rightAnchor.relative = param_6;
                      if (this.bottomAnchor != null) {
                        this.bottomAnchor.relative = param_4;
                        if (this.topAnchor != null) {
                          this.topAnchor.relative = param_8;
                          if (this.leftAnchor != null) {
                            this.leftAnchor.absolute = param_3;
                            if (this.rightAnchor != null) {
                              this.rightAnchor.absolute = param_7;
                              if (this.bottomAnchor != null) {
                                this.bottomAnchor.absolute = param_5;
                                if (this.topAnchor != null) {
                                  this.topAnchor.absolute = param_9;
                                  UIRect.ResetAnchors(this,0);
                                  UIRect.UpdateAnchors(this,0);
                                  return;
                                }
                              }
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600050C
    // RVA   : 0x16FDBE0   Offset: 0x16FCFE0   Length: 0x1A2
    public void SetAnchor(GameObject go, int left, int bottom, int right, int top)
    {
                            uint32 right,uint32 top,uint32 param_7,uint32 param_8,
                            uint32 param_9)
        {
        int64 lVar1;
        uint64 uVar2;
        uint64 *puVar3;
        lVar1 = UIRect.get_cachedTransform(this,0);
        if (lVar1 != null) {
          uVar2 = FUN_180da9a20(lVar1,0);
          if (this.leftAnchor != null) {
            this.leftAnchor.target = uVar2;
            if (this.rightAnchor != null) {
              this.rightAnchor.target = uVar2;
              if (this.topAnchor != null) {
                this.topAnchor.target = uVar2;
                if (this.bottomAnchor != null) {
                  this.bottomAnchor.target = uVar2;
                  if (this.leftAnchor != null) {
                    this.leftAnchor.relative = go;
                    if (this.rightAnchor != null) {
                      this.rightAnchor.relative = top;
                      if (this.bottomAnchor != null) {
                        this.bottomAnchor.relative = bottom;
                        if (this.topAnchor != null) {
                          this.topAnchor.relative = param_8;
                          if (this.leftAnchor != null) {
                            this.leftAnchor.absolute = left;
                            if (this.rightAnchor != null) {
                              this.rightAnchor.absolute = param_7;
                              if (this.bottomAnchor != null) {
                                this.bottomAnchor.absolute = right;
                                if (this.topAnchor != null) {
                                  this.topAnchor.absolute = param_9;
                                  UIRect.ResetAnchors(this,0);
                                  UIRect.UpdateAnchors(this,0);
                                  return;
                                }
                              }
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600050D
    // RVA   : 0x16FDF50   Offset: 0x16FD350   Length: 0x1AB
    public void SetAnchor(GameObject go, float left, float bottom, float right, float top)
    {
                            uint32 right,uint32 top,uint32 param_7,uint32 param_8,
                            uint32 param_9)
        {
        int64 lVar1;
        uint64 uVar2;
        uint64 *puVar3;
        lVar1 = UIRect.get_cachedTransform(this,0);
        if (lVar1 != null) {
          uVar2 = FUN_180da9a20(lVar1,0);
          if (this.leftAnchor != null) {
            this.leftAnchor.target = uVar2;
            if (this.rightAnchor != null) {
              this.rightAnchor.target = uVar2;
              if (this.topAnchor != null) {
                this.topAnchor.target = uVar2;
                if (this.bottomAnchor != null) {
                  this.bottomAnchor.target = uVar2;
                  if (this.leftAnchor != null) {
                    this.leftAnchor.relative = go;
                    if (this.rightAnchor != null) {
                      this.rightAnchor.relative = top;
                      if (this.bottomAnchor != null) {
                        this.bottomAnchor.relative = bottom;
                        if (this.topAnchor != null) {
                          this.topAnchor.relative = param_8;
                          if (this.leftAnchor != null) {
                            this.leftAnchor.absolute = left;
                            if (this.rightAnchor != null) {
                              this.rightAnchor.absolute = param_7;
                              if (this.bottomAnchor != null) {
                                this.bottomAnchor.absolute = right;
                                if (this.topAnchor != null) {
                                  this.topAnchor.absolute = param_9;
                                  UIRect.ResetAnchors(this,0);
                                  UIRect.UpdateAnchors(this,0);
                                  return;
                                }
                              }
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600050E
    // RVA   : 0x16FDD90   Offset: 0x16FD190   Length: 0x1BA
    public void SetAnchor(GameObject go, float left, int leftOffset, float bottom, int bottomOffset, float right, int rightOffset, float top, int topOffset)
    {
                            uint32 bottom,uint32 bottomOffset,uint32 right,uint32 rightOffset,
                            uint32 top)
        {
        int64 lVar1;
        uint64 uVar2;
        uint64 *puVar3;
        lVar1 = UIRect.get_cachedTransform(this,0);
        if (lVar1 != null) {
          uVar2 = FUN_180da9a20(lVar1,0);
          if (this.leftAnchor != null) {
            this.leftAnchor.target = uVar2;
            if (this.rightAnchor != null) {
              this.rightAnchor.target = uVar2;
              if (this.topAnchor != null) {
                this.topAnchor.target = uVar2;
                if (this.bottomAnchor != null) {
                  this.bottomAnchor.target = uVar2;
                  if (this.leftAnchor != null) {
                    this.leftAnchor.relative = go;
                    if (this.rightAnchor != null) {
                      this.rightAnchor.relative = bottomOffset;
                      if (this.bottomAnchor != null) {
                        this.bottomAnchor.relative = leftOffset;
                        if (this.topAnchor != null) {
                          this.topAnchor.relative = rightOffset;
                          if (this.leftAnchor != null) {
                            this.leftAnchor.absolute = left;
                            if (this.rightAnchor != null) {
                              this.rightAnchor.absolute = right;
                              if (this.bottomAnchor != null) {
                                this.bottomAnchor.absolute = bottom;
                                if (this.topAnchor != null) {
                                  this.topAnchor.absolute = top;
                                  UIRect.ResetAnchors(this,0);
                                  UIRect.UpdateAnchors(this,0);
                                  return;
                                }
                              }
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600050F
    // RVA   : 0x16FE1A0   Offset: 0x16FD5A0   Length: 0x179
    public void SetAnchor(float left, int leftOffset, float bottom, int bottomOffset, float right, int rightOffset, float top, int topOffset)
    {
                            uint32 bottomOffset,uint32 right,uint32 rightOffset,uint32 top,
                            uint32 topOffset)
        {
        int64 lVar1;
        uint64 uVar2;
        uint64 *puVar3;
        lVar1 = UIRect.get_cachedTransform(this,0);
        if (lVar1 != null) {
          uVar2 = FUN_180da9a20(lVar1,0);
          if (this.leftAnchor != null) {
            this.leftAnchor.target = uVar2;
            if (this.rightAnchor != null) {
              this.rightAnchor.target = uVar2;
              if (this.topAnchor != null) {
                this.topAnchor.target = uVar2;
                if (this.bottomAnchor != null) {
                  this.bottomAnchor.target = uVar2;
                  if (this.leftAnchor != null) {
                    this.leftAnchor.relative = left;
                    if (this.rightAnchor != null) {
                      this.rightAnchor.relative = right;
                      if (this.bottomAnchor != null) {
                        this.bottomAnchor.relative = bottom;
                        if (this.topAnchor != null) {
                          this.topAnchor.relative = top;
                          if (this.leftAnchor != null) {
                            this.leftAnchor.absolute = leftOffset;
                            if (this.rightAnchor != null) {
                              this.rightAnchor.absolute = rightOffset;
                              if (this.bottomAnchor != null) {
                                this.bottomAnchor.absolute = bottomOffset;
                                if (this.topAnchor != null) {
                                  this.topAnchor.absolute = topOffset;
                                  UIRect.ResetAnchors(this,0);
                                  UIRect.UpdateAnchors(this,0);
                                  return;
                                }
                              }
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000510
    // RVA   : 0x16FE320   Offset: 0x16FD720   Length: 0x16B
    public void SetScreenRect(int left, int top, int width, int height)
    {
        long lVar1;
        ulong uVar2;
        lVar1 = UIRect.get_cachedTransform(this,0);
        if (lVar1 != null) {
          uVar2 = FUN_180da9a20(lVar1,0);
          if (this.leftAnchor != null) {
            this.leftAnchor.target = uVar2;
            if (this.rightAnchor != null) {
              this.rightAnchor.target = uVar2;
              if (this.topAnchor != null) {
                this.topAnchor.target = uVar2;
                if (this.bottomAnchor != null) {
                  this.bottomAnchor.target = uVar2;
                  if (this.leftAnchor != null) {
                    this.leftAnchor.relative = 0;
                    if (this.rightAnchor != null) {
                      this.rightAnchor.relative = 0;
                      if (this.bottomAnchor != null) {
                        this.bottomAnchor.relative = 0x3f800000;
                        if (this.topAnchor != null) {
                          this.topAnchor.relative = 0x3f800000;
                          if (this.leftAnchor != null) {
                            this.leftAnchor.absolute = left;
                            if (this.rightAnchor != null) {
                              this.rightAnchor.absolute = left + width;
                              if (this.bottomAnchor != null) {
                                this.bottomAnchor.absolute = -(height + top);
                                if (this.topAnchor != null) {
                                  this.topAnchor.absolute = -top;
                                  UIRect.ResetAnchors(this,0);
                                  UIRect.UpdateAnchors(this,0);
                                  return;
                                }
                              }
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000511
    // RVA   : 0x16FD780   Offset: 0x16FCB80   Length: 0x33A
    public void ResetAnchors()
    {
        long lVar1;
        long lVar2;
        bool cVar3;
        uint uVar4;
        ulong uVar5;
        ulong uVar6;
        lVar1 = this.leftAnchor;
        this.mAnchorsCached = 1;
        if (lVar1 != null) {
          uVar5 = lVar1.target;
          cVar3 = Object.op_Implicit(uVar5,0);
          uVar6 = 0;
          uVar5 = uVar6;
          if (cVar3) {
            if ((this.leftAnchor == null) ||
               (lVar2 = this.leftAnchor.target) == null)
            throw; // [null/range check failed]
            uVar5 = Component.GetComponent(lVar2,DAT_181d96ce0);
          }
          lVar1.rect = uVar5;
          lVar1 = this.bottomAnchor;
          if (lVar1 != null) {
            uVar5 = lVar1.target;
            cVar3 = Object.op_Implicit(uVar5,0);
            uVar5 = uVar6;
            if (cVar3) {
              if ((this.bottomAnchor == null) ||
                 (lVar2 = this.bottomAnchor.target) == null)
              throw; // [null/range check failed]
              uVar5 = Component.GetComponent(lVar2,DAT_181d96ce0);
            }
            lVar1.rect = uVar5;
            lVar1 = this.rightAnchor;
            if (lVar1 != null) {
              uVar5 = lVar1.target;
              cVar3 = Object.op_Implicit(uVar5,0);
              uVar5 = uVar6;
              if (cVar3) {
                if ((this.rightAnchor == null) ||
                   (lVar2 = this.rightAnchor.target) == null)
                throw; // [null/range check failed]
                uVar5 = Component.GetComponent(lVar2,DAT_181d96ce0);
              }
              lVar1.rect = uVar5;
              lVar1 = this.topAnchor;
              if (lVar1 != null) {
                uVar5 = lVar1.target;
                cVar3 = Object.op_Implicit(uVar5,0);
                if (cVar3) {
                  if ((this.topAnchor == null) ||
                     (lVar2 = this.topAnchor.target) == null)
                  throw; // [null/range check failed]
                  uVar6 = Component.GetComponent(lVar2,DAT_181d96ce0);
                }
                lVar1.rect = uVar6;
                uVar5 = this.mGo;
                cVar3 = Object.op_Equality(uVar5,0,0);
                if (cVar3) {
                  uVar5 = Component.get_gameObject(this,0);
                  this.mGo = uVar5;
                }
                if (this.mGo != null) {
                  uVar4 = GameObject.get_layer(this.mGo,0);
                  uVar5 = NGUITools.FindCameraForLayer(uVar4,0);
                  this.mCam = uVar5;
                  UIRect.FindCameraFor(this,this.leftAnchor,0);
                  UIRect.FindCameraFor(this,this.bottomAnchor,0);
                  UIRect.FindCameraFor(this,this.rightAnchor,0);
                  UIRect.FindCameraFor(this,this.topAnchor,0);
                  this.mUpdateAnchors = 1;
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000512
    // RVA   : 0x16FDAC0   Offset: 0x16FCEC0   Length: 0x1F
    public void ResetAndUpdateAnchors()
    {
        UIRect.ResetAnchors(this,0);
        UIRect.UpdateAnchors(this,0);
    }

    // Token : 0x6000513
    // (no native address)
    public virtual void SetRect(float x, float y, float width, float height)
    {
    }

    // Token : 0x6000514
    // RVA   : 0x16FCBE0   Offset: 0x16FBFE0   Length: 0x12B
    private void FindCameraFor(AnchorPoint ap)
    {
        bool cVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        if (ap == null) {
        LAB_1816fcd06:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        uVar4 = *(uint64 *)(ap + 16);
        cVar1 = Object.op_Equality(uVar4,0,0);
        if (!cVar1) {
          uVar4 = *(uint64 *)(ap + 32);
          cVar1 = Object.op_Inequality(uVar4,0,0);
          if (!cVar1) {
            if (*(int64 *)(ap + 16) != 0) {
              lVar3 = Component.get_gameObject(*(int64 *)(ap + 16),0);
              if (lVar3 != null) {
                uVar2 = GameObject.get_layer(lVar3,0);
                uVar4 = NGUITools.FindCameraForLayer(uVar2,0);
                *(uint64 *)(ap + 40) = uVar4;
                return;
              }
            }
            goto LAB_1816fcd06;
          }
        }
        *(uint64 *)(ap + 40) = 0;
    }

    // Token : 0x6000515
    // RVA   : 0x16FD5B0   Offset: 0x16FC9B0   Length: 0x1C8
    public virtual void ParentHasChanged()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        this.mParentFound = 0;
        lVar2 = UIRect.get_cachedTransform(this,0);
        if (lVar2 != null) {
          uVar3 = FUN_180da9a20(lVar2,0);
          uVar4 = NGUITools.FindInParents(uVar3,DAT_181d8f7a0);
          uVar3 = this.mParent;
          cVar1 = Object.op_Inequality(uVar3,uVar4,0);
          if (cVar1) {
            uVar3 = this.mParent;
            cVar1 = Object.op_Implicit(uVar3,0);
            if (cVar1) {
              if ((this.mParent == null) ||
                 (lVar2 = this.mParent.mChildren) == null)
              throw; // [null/range check failed]
              FUN_181585c70(lVar2,this,DAT_181da7038);
            }
            this.mParent = uVar4;
            uVar3 = this.mParent;
            cVar1 = Object.op_Implicit(uVar3,0);
            if (cVar1) {
              if ((this.mParent == null) ||
                 (lVar2 = this.mParent.mChildren) == null)
              throw; // [null/range check failed]
              FUN_181583c60(lVar2,this,DAT_181da6fb8);
            }
            this.mRootSet = 0;
          }
          return;
        }
    }

    // Token : 0x6000516
    // (no native address)
    protected virtual void OnStart()
    {
    }

    // Token : 0x6000517
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    protected virtual void OnUpdate()
    {
    }

    // Token : 0x6000518
    // RVA   : 0x16FEA80   Offset: 0x16FDE80   Length: 0x154
    protected void /*ctor*/()
    {
        ulong uVar1;
        this.leftAnchor = new c.DisplayClass9_0(0);
        this.rightAnchor = new AnchorPoint(0x3f800000,0);
        this.bottomAnchor = new c.DisplayClass9_0(0);
        this.topAnchor = new AnchorPoint(0x3f800000,0);
        this.updateAnchors = 1;
        this.mChildren = new BetterList_1(DAT_181da6f38);
        this.mChanged = 1;
        this.mUpdateAnchors = 1;
        this.mUpdateFrame = 0xffffffff;
        this.finalAlpha = 0x3f800000;
        FUN_18044ef50(this,0);
    }

    // Token : 0x6000519
    // RVA   : 0x16FEA20   Offset: 0x16FDE20   Length: 0x5A
    private static void /*cctor*/()
    {
        ulong uVar2;
        uVar2 = FUN_1800d60b0(DAT_181da6d60,4);
        puVar1 = *(uint64 **)(DAT_181db00f8 + 184);
        *puVar1 = uVar2;
        il2cpp_internal(puVar1,uVar2);
    }

}
