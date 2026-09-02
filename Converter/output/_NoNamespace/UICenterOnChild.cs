// ============================================================
// Type  : UICenterOnChild
// Token : 0x2000037
// ============================================================

public class UICenterOnChild
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000102
    public float springStrength;

    // Token: 0x4000103
    public float nextPageThreshold;

    // Token: 0x4000104
    public OnFinished onFinished;

    // Token: 0x4000105
    public OnCenterCallback onCenter;

    // Token: 0x4000106
    private UIScrollView mScrollView;

    // Token: 0x4000107
    private GameObject mCenteredObject;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60000E3
    // RVA   : 0x21B660   Offset: 0x219E60   Length: 0x5
    public GameObject get_centeredObject()
    {
        return this.mCenteredObject;
    }

    // Token : 0x60000E4
    // RVA   : 0x13D2CC0   Offset: 0x13D14C0   Length: 0x7
    private void Start()
    {
        void FUN_1813d2cc0(uint64 this)
        {
        UICenterOnChild.Recenter(this,0);
    }

    // Token : 0x60000E5
    // RVA   : 0x13D1D40   Offset: 0x13D0540   Length: 0x8E
    private void OnEnable()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.mScrollView;
        cVar2 = Object.op_Implicit(uVar1,0);
        if (cVar2) {
          if (this.mScrollView == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          this.mScrollView.centerOnChild = this;
          UICenterOnChild.Recenter(this,0);
        }
    }

    // Token : 0x60000E6
    // RVA   : 0x13D1C80   Offset: 0x13D0480   Length: 0x87
    private void OnDisable()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.mScrollView;
        cVar2 = Object.op_Implicit(uVar1,0);
        if (cVar2) {
          if (this.mScrollView == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          this.mScrollView.centerOnChild = 0;
        }
    }

    // Token : 0x60000E7
    // RVA   : 0x13D1D10   Offset: 0x13D0510   Length: 0x29
    private void OnDragFinished()
    {
        bool cVar1;
        cVar1 = Behaviour.get_enabled(this,0);
        if (cVar1) {
          UICenterOnChild.Recenter(this,0);
          return;
        }
    }

    // Token : 0x60000E8
    // RVA   : 0x13D1DD0   Offset: 0x13D05D0   Length: 0x12
    private void OnValidate()
    {
        void FUN_1813d1dd0(int64 this)
        {
        this.nextPageThreshold = this.nextPageThreshold & 0x7fffffff;
    }

    // Token : 0x60000E9
    // RVA   : 0x13D1DF0   Offset: 0x13D05F0   Length: 0xECF
    public void Recenter()
    {
        var pStatics = *(int64*)(DAT_181d8a458 + 184);
        ulong uVar1;
        bool cVar2;
        int iVar3;
        uint uVar4;
        int iVar5;
        ulong uVar6;
        ulong uVar7;
        long lVar9;
        long lVar10;
        uint uVar14;
        uint uVar16;
        float fVar19;
        float fVar20;
        ulong uVar21;
        float fVar22;
        float fVar23;
        float fVar24;
        float fVar25;
        float fVar26;
        long local_res20;
        ulong local_138;
        float local_130;
        ulong local_128;
        float local_120;
        ulong local_118;
        float local_110;
        long local_108;
        ulong local_100;
        float local_f8;
        ulong local_e8;
        float fStack_e0;
        uint32 uStack_dc;
        float local_d8;
        float fStack_d4;
        float local_d0;
        uint64 local_c8;
        float local_c0;
        uint8 local_b8 [128];
        uVar6 = this.mScrollView;
        local_118 = 0;
        local_110 = 0.0;
        cVar2 = Object.op_Equality(uVar6,0,0);
        plVar12 = (int64 *)0;
        iVar5 = 0;
        if (cVar2) {
          uVar6 = Component.get_gameObject(this,0);
          uVar6 = NGUITools.FindInParents(uVar6,DAT_181d66c00);
          this.mScrollView = uVar6;
          uVar6 = this.mScrollView;
          cVar2 = Object.op_Equality(uVar6,0,0);
          if (cVar2) {
            plVar8 = (int64 *)Object.GetType(this,0);
            plVar15 = plVar12;
            if (plVar8 != (int64 *)0) {
              plVar15 = (int64 *)
                        (**(code **)(*plVar8 + 0x168))(plVar8,*(uint64 *)(*plVar8 + 0x170));
            }
            uVar6 = DAT_181d9f590;
            plVar8 = (int64 *)Type.GetTypeFromHandle(uVar6,0);
            uVar6 = " requires ";
            if (plVar8 != (int64 *)0) {
              plVar12 = (int64 *)
                        (**(code **)(*plVar8 + 0x168))(plVar8,*(uint64 *)(*plVar8 + 0x170));
            }
            uVar6 = String.Concat(plVar15,uVar6,plVar12," on a parent object in order to work",0);
            Debug.LogWarning(uVar6,this,0);
            Behaviour.set_enabled(this,0,0);
            return;
          }
          uVar6 = this.mScrollView;
          cVar2 = Object.op_Implicit(uVar6,0);
          if (cVar2) {
            uVar21 = local_128;
            if (this.mScrollView == null) goto LAB_1813d2c9e;
            this.mScrollView.centerOnChild = this;
          }
          uVar21 = local_128;
          if (this.mScrollView == null) goto LAB_1813d2c9e;
          uVar6 = this.mScrollView.horizontalScrollBar;
          cVar2 = Object.op_Inequality(uVar6,0,0);
          if (cVar2) {
            uVar21 = local_128;
            if ((this.mScrollView == null) ||
               (lVar9 = this.mScrollView.horizontalScrollBar) == null)
            goto LAB_1813d2c9e;
            uVar6 = *(uint64 *)(lVar9 + 24);
            uVar7 = new OnTooltipCB(this,DAT_181d9c850,0);
            plVar8 = (int64 *)Delegate.Combine(uVar6,uVar7,0);
            plVar15 = plVar12;
            if (plVar8 != (int64 *)0) {
              if (*plVar8 == DAT_181d68910) {
                plVar15 = plVar8;
              }
              if (plVar15 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6070(plVar8,DAT_181d68910);
              }
            }
            *(int64 **)(lVar9 + 24) = plVar15;
          }
          uVar21 = local_128;
          if (this.mScrollView == null) goto LAB_1813d2c9e;
          uVar6 = this.mScrollView.verticalScrollBar;
          cVar2 = Object.op_Inequality(uVar6,0,0);
          if (cVar2) {
            uVar21 = local_128;
            if ((this.mScrollView == null) ||
               (lVar9 = this.mScrollView.verticalScrollBar) == null)
            goto LAB_1813d2c9e;
            uVar6 = *(uint64 *)(lVar9 + 24);
            uVar7 = new OnTooltipCB(this,DAT_181d9c850,0);
            plVar8 = (int64 *)Delegate.Combine(uVar6,uVar7,0);
            plVar15 = plVar12;
            if (plVar8 != (int64 *)0) {
              if (*plVar8 == DAT_181d68910) {
                plVar15 = plVar8;
              }
              if (plVar15 == (int64 *)0) {
                          // WARNING: Subroutine does not return
                FUN_1800d6070(plVar8,DAT_181d68910);
              }
            }
            *(int64 **)(lVar9 + 24) = plVar15;
          }
        }
        uVar21 = local_128;
        if (this.mScrollView == null) {
        LAB_1813d2c9e:
          local_128 = uVar21;
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        uVar6 = this.mScrollView.mPanel;
        cVar2 = Object.op_Equality(uVar6,0,0);
        if (cVar2) {
          return;
        }
        lVar9 = Component.get_transform(this,0);
        uVar21 = local_128;
        local_108 = lVar9;
        if (lVar9 == null) goto LAB_1813d2c9e;
        iVar3 = Transform.get_childCount(lVar9,0);
        if (iVar3 == 0) {
          return;
        }
        uVar21 = local_128;
        if (((this.mScrollView == null) ||
            (plVar15 = this.mScrollView.mPanel, plVar15 == (int64 *)0))
           || (lVar10 = (**(code **)(*plVar15 + 0x1e8))(plVar15,*(uint64 *)(*plVar15 + 0x1f0)),
              uVar21 = local_128, lVar10 == null)) goto LAB_1813d2c9e;
        if (lVar10.movement < 3) {
          uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
          FUN_1800d65f0(uVar6,0);
        }
        local_100 = lVar10.restrictWithinPanel;
        uVar21 = lVar10.horizontalScrollBar;
        local_130 = lVar10.scrollWheelFactor;
        local_120 = lVar10.verticalScrollBar;
        local_f8 = lVar10.scrollWheelFactor;
        fVar26 = (local_120 + local_f8) * 0.5;
        fVar25 = ((float)local_100 + (float)uVar21) * 0.5;
        fVar24 = ((float)(uVar21 >> 32) + (float)(local_100 >> 32)) * 0.5;
        lVar10 = this.mScrollView;
        local_138 = local_100;
        local_d8 = fVar25;
        fStack_d4 = fVar24;
        local_d0 = fVar26;
        if (lVar10 == null) goto LAB_1813d2c9e;
        local_138 = lVar10.mMomentum;
        fVar23 = lVar10.momentumAmount;
        local_120 = *(float *)(lVar10 + 200);
        local_130 = fVar23 * local_120;
        local_c8 = CONCAT44(fVar23 * (float)(local_138 >> 32),fVar23 * (float)local_138);
        local_128 = local_138;
        local_c0 = local_130;
        puVar11 = (uint64 *)NGUIMath.SpringDampen(&local_e8,&local_c8,0x41100000,0x40000000,0);
        local_130 = *(float *)(puVar11 + 1);
        local_138 = *puVar11;
        fVar24 = fVar24 - (float)(local_138 >> 32) * 0.01;
        fVar25 = fVar25 - (float)local_138 * 0.01;
        fVar26 = fVar26 - local_130 * 0.01;
        fVar23 = 3.4028235e+38;
        local_res8 = (int64 *)0;
        local_128 = local_138;
        local_120 = local_130;
        lVar10 = Component.GetComponent(this,DAT_181d6e0c0);
        cVar2 = Object.op_Inequality(lVar10,0,0);
        plVar15 = plVar12;
        plVar8 = plVar12;
        if (!cVar2) {
          iVar3 = Transform.get_childCount(lVar9,0);
          uVar14 = 0;
          plVar13 = plVar12;
          plVar17 = plVar12;
          plVar18 = plVar12;
          if (0 < iVar3) {
            do {
              plVar8 = (int64 *)Transform.GetChild(lVar9,plVar17,0);
              uVar21 = local_128;
              if ((plVar8 == (int64 *)0) ||
                 (lVar9 = Component.get_gameObject(plVar8,0), uVar21 = local_128) == null)
              goto LAB_1813d2c9e;
              cVar2 = GameObject.get_activeInHierarchy(lVar9,0);
              fVar19 = fVar23;
              if (cVar2) {
                puVar11 = (uint64 *)Transform.get_position(&local_e8,plVar8);
                local_138 = *puVar11;
                local_130 = *(float *)(puVar11 + 1);
                fVar20 = (float)local_138 - fVar25;
                fVar19 = local_130 - fVar26;
                fVar22 = (float)(local_138 >> 32) - fVar24;
                fVar20 = fVar22 * fVar22 + fVar20 * fVar20 + fVar19 * fVar19;
                uVar16 = uVar14;
                fVar19 = fVar20;
                if (fVar23 <= fVar20) {
                  uVar16 = (uint32)plVar18;
                  plVar8 = plVar15;
                  fVar19 = fVar23;
                }
                plVar15 = plVar8;
                uVar14 = uVar14 + 1;
                plVar18 = (int64 *)(uint64)uVar16;
                uVar16 = (uint32)plVar17;
                if (fVar23 <= fVar20) {
                  uVar16 = (uint32)local_res8;
                }
                local_res8 = (int64 *)(uint64)uVar16;
                local_128 = local_138;
                local_120 = local_130;
              }
              iVar5 = (int)plVar18;
              uVar16 = (uint32)plVar17 + 1;
              plVar8 = local_res8;
              plVar17 = (int64 *)(uint64)uVar16;
              lVar9 = local_108;
              fVar23 = fVar19;
            } while ((int)uVar16 < iVar3);
          }
        }
        else {
          uVar21 = local_128;
          if ((lVar10 == null) ||
             (plVar13 = (int64 *)UIGrid.GetChildList(lVar10,0), uVar21 = local_128,
             plVar13 == (int64 *)0)) goto LAB_1813d2c9e;
          uVar14 = 0;
          lVar9 = local_108;
          iVar5 = 0;
          if (0 < (int)plVar13[3]) {
            local_res20 = 32;
            local_100 = 0;
            plVar17 = plVar12;
            plVar18 = plVar12;
            local_128 = (int64)(int)plVar13[3];
            do {
              uVar16 = (uint32)plVar17;
              if (*(uint32 *)(plVar13 + 3) <= uVar16) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              plVar8 = *(int64 **)(local_res20 + plVar13[2]);
              uVar21 = local_128;
              if ((plVar8 == (int64 *)0) ||
                 (lVar9 = Component.get_gameObject(plVar8,0), uVar21 = local_128) == null)
              goto LAB_1813d2c9e;
              cVar2 = GameObject.get_activeInHierarchy(lVar9);
              uVar4 = (uint32)local_res8;
              if (cVar2) {
                puVar11 = (uint64 *)Transform.get_position(local_b8,plVar8,0);
                local_138 = *puVar11;
                local_130 = *(float *)(puVar11 + 1);
                fVar20 = (float)local_138 - fVar25;
                fVar19 = local_130 - fVar26;
                fVar22 = (float)(local_138 >> 32) - fVar24;
                fVar20 = fVar22 * fVar22 + fVar20 * fVar20 + fVar19 * fVar19;
                uVar4 = uVar14;
                fVar19 = fVar20;
                if (fVar23 <= fVar20) {
                  uVar4 = (uint32)plVar18;
                  fVar19 = fVar23;
                }
                uVar14 = uVar14 + 1;
                plVar18 = (int64 *)(uint64)uVar4;
                uVar4 = uVar16;
                if (fVar23 <= fVar20) {
                  uVar4 = (uint32)local_res8;
                  plVar8 = plVar15;
                }
                plVar15 = plVar8;
                local_res8 = (int64 *)(uint64)uVar4;
                fVar23 = fVar19;
                local_e8 = local_138;
                fStack_e0 = local_130;
              }
              iVar5 = (int)plVar18;
              plVar17 = (int64 *)(uint64)(uVar16 + 1);
              local_100 = local_100 + 1;
              local_res20 = local_res20 + 8;
              plVar8 = (int64 *)(uint64)uVar4;
              lVar9 = local_108;
            } while ((int64)local_100 < (int64)local_128);
          }
        }
        if (this.nextPageThreshold <= 0.0) goto LAB_1813d2c68;
        if (*(int64 *)(pStatics + 224) == 0) goto LAB_1813d2c68;
        uVar6 = this.mCenteredObject;
        cVar2 = Object.op_Inequality(uVar6,0,0);
        if (!cVar2) goto LAB_1813d2c68;
        uVar21 = local_128;
        if (this.mCenteredObject == null) goto LAB_1813d2c9e;
        uVar6 = GameObject.get_transform(this.mCenteredObject,0);
        if (plVar13 == (int64 *)0) {
          uVar7 = Transform.GetChild(lVar9,plVar8,0);
        }
        else {
          if (*(uint32 *)(plVar13 + 3) <= (uint32)plVar8) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar7 = *(uint64 *)(plVar13[2] + 32 + (int64)(int)(uint32)plVar8 * 8);
        }
        cVar2 = Object.op_Equality(uVar6,uVar7,0);
        if (!cVar2) goto LAB_1813d2c68;
        lVar10 = *(int64 *)(pStatics + 224);
        uVar21 = local_128;
        if (lVar10 == null) goto LAB_1813d2c9e;
        local_118 = lVar10.momentumAmount;
        local_110 = 0.0;
        lVar10 = Component.get_transform(this,0);
        uVar21 = local_128;
        if (lVar10 == null) goto LAB_1813d2c9e;
        local_130 = local_110;
        local_138 = local_118;
        puVar11 = (uint64 *)Transform.get_rotation(local_b8,lVar10,0);
        local_e8 = *puVar11;
        fStack_e0 = *(float *)(puVar11 + 1);
        uStack_dc = *(uint32 *)((int64)puVar11 + 12);
        puVar11 = (uint64 *)Quaternion.op_Multiply(local_b8,&local_e8,&local_138,0);
        local_118 = *puVar11;
        local_120 = *(float *)(puVar11 + 1);
        local_128._4_4_ = (uint32)(local_118 >> 32);
        uVar21 = local_118;
        local_110 = local_120;
        if (this.mScrollView == null) goto LAB_1813d2c9e;
        iVar3 = this.mScrollView.movement;
        uVar1 = local_118;
        if (iVar3 != 0) {
          if (iVar3 == 1) {
            uVar21 = (uint64)(local_128._4_4_ ^ 0x80000000);
          }
          else {
            local_128 = local_118;
            uVar14 = Vector3.get_magnitude(&local_118,0);
            uVar21 = (uint64)uVar14;
            uVar1 = local_128;
          }
        }
        local_128 = uVar1;
        fVar24 = this.nextPageThreshold;
        fVar25 = (float)uVar21;
        if (ABS(fVar25) <= fVar24) goto LAB_1813d2c68;
        if (fVar24 < fVar25) {
          if (plVar13 != (int64 *)0) {
            if (iVar5 < 1) {
              uVar6 = Component.GetComponent(this,DAT_181d6e840);
              cVar2 = Object.op_Equality(uVar6,0,0);
              if (cVar2) {
        LAB_1813d2c3b:
                if ((int)plVar13[3] == 0) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                plVar15 = *(int64 **)(plVar13[2] + 32);
                goto LAB_1813d2c68;
              }
        LAB_1813d2b79:
              iVar5 = (int)plVar13[3] + -1;
            }
            else {
              iVar5 = iVar5 + -1;
            }
        LAB_1813d2c56:
            plVar15 = (int64 *)FUN_180002f80(plVar13,iVar5,DAT_181d806f8);
            goto LAB_1813d2c68;
          }
          if (0 < iVar5) {
            plVar15 = (int64 *)Transform.GetChild(lVar9,iVar5 + -1,0);
            goto LAB_1813d2c68;
          }
          uVar6 = Component.GetComponent(this,DAT_181d6e840);
          cVar2 = Object.op_Equality(uVar6,0,0);
          if (!cVar2) {
        LAB_1813d2af5:
            iVar5 = Transform.get_childCount(lVar9,0);
            plVar12 = (int64 *)(uint64)(iVar5 - 1);
          }
        }
        else {
          if (-fVar24 <= fVar25) goto LAB_1813d2c68;
          if (plVar13 != (int64 *)0) {
            if ((int)plVar13[3] + -1 <= iVar5) {
              uVar6 = Component.GetComponent(this,DAT_181d6e840);
              cVar2 = Object.op_Equality(uVar6,0,0);
              if (!cVar2) goto LAB_1813d2c3b;
              goto LAB_1813d2b79;
            }
            iVar5 = iVar5 + 1;
            goto LAB_1813d2c56;
          }
          iVar3 = Transform.get_childCount(lVar9,0);
          if (iVar5 < iVar3 + -1) {
            plVar15 = (int64 *)Transform.GetChild(lVar9,iVar5 + 1,0);
            goto LAB_1813d2c68;
          }
          uVar6 = Component.GetComponent(this,DAT_181d6e840);
          cVar2 = Object.op_Equality(uVar6,0,0);
          if (cVar2) goto LAB_1813d2af5;
        }
        plVar15 = (int64 *)Transform.GetChild(lVar9,plVar12,0);
        LAB_1813d2c68:
        local_138 = CONCAT44(fStack_d4,local_d8);
        local_130 = local_d0;
        UICenterOnChild.CenterOn(this,plVar15,&local_138,0);
    }

    // Token : 0x60000EA
    // RVA   : 0x13D1910   Offset: 0x13D0110   Length: 0x36E
    private void CenterOn(Transform target, Vector3 panelCenter)
    {
        bool cVar2;
        long lVar3;
        ulong uVar4;
        ulong local_28;
        float local_20;
        float local_10;
        uVar4 = this.mScrollView;
        cVar2 = Object.op_Inequality(uVar4,0,0);
        if (!cVar2) {
          return;
        }
        if (this.mScrollView != null) {
          uVar4 = this.mScrollView.mPanel;
          cVar2 = Object.op_Inequality(uVar4,0,0);
          if (!cVar2) {
            return;
          }
          if (((this.mScrollView != null) &&
              (plVar1 = this.mScrollView.mPanel, plVar1 != (int64 *)0))
             && (lVar3 = (**(code **)(*plVar1 + 0x1e8))(plVar1,*(uint64 *)(*plVar1 + 0x1f0)),
                lVar3 != null)) {
            if (2 < *(uint32 *)(lVar3 + 24)) {
              local_20 = (*(float *)(lVar3 + 64) + *(float *)(lVar3 + 40)) * 0.5;
              local_28 = CONCAT44(((float)((uint64)*(uint64 *)(lVar3 + 56) >> 32) +
                                  (float)((uint64)*(uint64 *)(lVar3 + 32) >> 32)) * 0.5,
                                  ((float)*(uint64 *)(lVar3 + 32) +
                                  (float)*(uint64 *)(lVar3 + 56)) * 0.5);
              local_10 = local_20;
              UICenterOnChild.CenterOn(this,target,&local_28,0);
              return;
            }
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
        }
    }

    // Token : 0x60000EB
    // RVA   : 0x13D1750   Offset: 0x13CFF50   Length: 0x1B4
    public void CenterOn(Transform target)
    {
        bool cVar2;
        long lVar3;
        ulong uVar4;
        ulong local_28;
        float local_20;
        float local_10;
        uVar4 = this.mScrollView;
        cVar2 = Object.op_Inequality(uVar4,0,0);
        if (!cVar2) {
          return;
        }
        if (this.mScrollView != null) {
          uVar4 = this.mScrollView.mPanel;
          cVar2 = Object.op_Inequality(uVar4,0,0);
          if (!cVar2) {
            return;
          }
          if (((this.mScrollView != null) &&
              (plVar1 = this.mScrollView.mPanel, plVar1 != (int64 *)0))
             && (lVar3 = (**(code **)(*plVar1 + 0x1e8))(plVar1,*(uint64 *)(*plVar1 + 0x1f0)),
                lVar3 != null)) {
            if (2 < *(uint32 *)(lVar3 + 24)) {
              local_20 = (*(float *)(lVar3 + 64) + *(float *)(lVar3 + 40)) * 0.5;
              local_28 = CONCAT44(((float)((uint64)*(uint64 *)(lVar3 + 56) >> 32) +
                                  (float)((uint64)*(uint64 *)(lVar3 + 32) >> 32)) * 0.5,
                                  ((float)*(uint64 *)(lVar3 + 32) +
                                  (float)*(uint64 *)(lVar3 + 56)) * 0.5);
              local_10 = local_20;
              UICenterOnChild.CenterOn(this,target,&local_28,0);
              return;
            }
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
        }
    }

    // Token : 0x60000EC
    // RVA   : 0x13D2CD0   Offset: 0x13D14D0   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_1813d2cd0(int64 this)
        {
        this.springStrength = 0x41000000;
        FUN_18044ef50(this,0);
    }

}
