// ============================================================
// Type  : UIAnchor
// Token : 0x20000D2
// ============================================================

public class UIAnchor
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000506
    public Camera uiCamera;

    // Token: 0x4000507
    public GameObject container;

    // Token: 0x4000508
    public Side side;

    // Token: 0x4000509
    public bool runOnlyOnce;

    // Token: 0x400050A
    public Vector2 relativeOffset;

    // Token: 0x400050B
    public Vector2 pixelOffset;

    // Token: 0x400050C
    private UIWidget widgetContainer;

    // Token: 0x400050D
    private Transform mTrans;

    // Token: 0x400050E
    private Animation mAnim;

    // Token: 0x400050F
    private Rect mRect;

    // Token: 0x4000510
    private UIRoot mRoot;

    // Token: 0x4000511
    private bool mStarted;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60006D2
    // RVA   : 0xAF13B0   Offset: 0xAF07B0   Length: 0x13C
    private void OnEnable()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = Component.get_transform(this,0);
        this.mTrans = uVar1;
        uVar1 = Component.GetComponent(this,DAT_181d93178);
        this.mAnim = uVar1;
        uVar1 = UICamera.onScreenResize;
        uVar2 = new OnTooltipCB(this,DAT_181dc5be0,0);
        plVar3 = (int64 *)Delegate.Combine(uVar1,uVar2,0);
        plVar4 = (int64 *)0;
        if (plVar3 != (int64 *)0) {
          if (*plVar3 == DAT_181d8d750) {
            plVar4 = plVar3;
          }
          if (plVar4 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar3,DAT_181d8d750);
          }
        }
        UICamera.onScreenResize = plVar4;
    }

    // Token : 0x60006D3
    // RVA   : 0xAF12B0   Offset: 0xAF06B0   Length: 0xF9
    private void OnDisable()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = UICamera.onScreenResize;
        uVar2 = new OnTooltipCB(this,DAT_181dc5be0,0);
        plVar3 = (int64 *)Delegate.Remove(uVar1,uVar2,0);
        plVar4 = (int64 *)0;
        if (plVar3 != (int64 *)0) {
          if (*plVar3 == DAT_181d8d750) {
            plVar4 = plVar3;
          }
          if (plVar4 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar3,DAT_181d8d750);
          }
        }
        UICamera.onScreenResize = plVar4;
    }

    // Token : 0x60006D4
    // RVA   : 0xAF14F0   Offset: 0xAF08F0   Length: 0x14
    private void ScreenSizeChanged()
    {
        void FUN_180af14f0(int64 this)
        {
        if ((this.mStarted) && (this.runOnlyOnce)) {
          UIAnchor.Update(this,0);
          return;
        }
    }

    // Token : 0x60006D5
    // RVA   : 0xAF1510   Offset: 0xAF0910   Length: 0x1DE
    private void Start()
    {
        bool cVar1;
        uint uVar2;
        ulong uVar3;
        long lVar4;
        uVar3 = this.container;
        cVar1 = Object.op_Equality(uVar3,0,0);
        if (cVar1) {
          uVar3 = this.widgetContainer;
          cVar1 = Object.op_Inequality(uVar3,0,0);
          if (cVar1) {
            if (this.widgetContainer == null) goto LAB_180af16e9;
            uVar3 = Component.get_gameObject(this.widgetContainer,0);
            this.container = uVar3;
            this.widgetContainer = 0;
          }
        }
        uVar3 = Component.get_gameObject(this,0);
        uVar3 = NGUITools.FindInParents(uVar3,DAT_181d8f6b8);
        this.mRoot = uVar3;
        uVar3 = this.uiCamera;
        cVar1 = Object.op_Equality(uVar3,0,0);
        if (cVar1) {
          lVar4 = Component.get_gameObject(this,0);
          if (lVar4 == null) {
        LAB_180af16e9:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar2 = GameObject.get_layer(lVar4,0);
          uVar3 = NGUITools.FindCameraForLayer(uVar2,0);
          this.uiCamera = uVar3;
        }
        UIAnchor.Update(this,0);
        this.mStarted = 1;
    }

    // Token : 0x60006D6
    // RVA   : 0xAF16F0   Offset: 0xAF0AF0   Length: 0xC12
    private void Update()
    {
        uint uVar1;
        bool cVar3;
        int iVar4;
        int iVar5;
        long lVar6;
        long lVar8;
        ulong uVar9;
        uint8 (*pauVar10) [16];
        int64 lVar11;
        uint64 uVar12;
        uint32 uVar13;
        float fVar14;
        float fVar15;
        float fVar16;
        uint32 uVar17;
        uint8 auVar18 [16];
        float fVar19;
        uint64 local_d8;
        uint32 local_d0;
        uint64 local_c8;
        uint32 local_c0;
        uint8 local_b8 [24];
        uint64 local_a0;
        uint64 uStack_98;
        uint64 local_90;
        uint64 local_88;
        uint64 uStack_80;
        uint64 local_78;
        uVar12 = this.mAnim;
        lVar6 = 0;
        local_78 = 0;
        local_90 = 0;
        local_88 = 0;
        uStack_80 = 0;
        local_c8 = 0;
        local_a0 = 0;
        uStack_98 = 0;
        cVar3 = Object.op_Inequality(uVar12,0,0);
        if (cVar3) {
          uVar12 = local_d8;
          uVar17 = local_d0;
          if (this.mAnim == null) goto LAB_180af22fd;
          cVar3 = Behaviour.get_enabled(this.mAnim,0);
          if (cVar3) {
            uVar12 = local_d8;
            uVar17 = local_d0;
            if (this.mAnim == null) goto LAB_180af22fd;
            cVar3 = Animation.get_isPlaying(this.mAnim,0);
            if (cVar3) {
              return;
            }
          }
        }
        uVar12 = this.mTrans;
        cVar3 = Object.op_Equality(uVar12,0,0);
        if (cVar3) {
          return;
        }
        bVar2 = false;
        uVar12 = this.container;
        cVar3 = Object.op_Equality(uVar12,0,0);
        lVar8 = lVar6;
        if (!cVar3) {
          uVar12 = local_d8;
          uVar17 = local_d0;
          if (this.container == null) goto LAB_180af22fd;
          lVar8 = GameObject.GetComponent(this.container,DAT_181d74c30);
        }
        uVar12 = this.container;
        cVar3 = Object.op_Equality(uVar12,0,0);
        if (!cVar3) {
        LAB_180af18e5:
          uVar12 = local_d8;
          uVar17 = local_d0;
          if (this.container == null) goto LAB_180af22fd;
          lVar6 = GameObject.GetComponent(this.container,DAT_181d74b20);
        }
        else {
          cVar3 = Object.op_Equality(lVar8,0,0);
          if (!cVar3) goto LAB_180af18e5;
        }
        cVar3 = Object.op_Inequality(lVar8,0,0);
        if (!cVar3) {
          cVar3 = Object.op_Inequality(lVar6,0,0);
          if (cVar3) {
            uVar12 = local_d8;
            uVar17 = local_d0;
            if (lVar6 == null) goto LAB_180af22fd;
            if (*(int *)(lVar6 + 0x134) == 0) {
              uVar12 = this.mRoot;
              cVar3 = Object.op_Inequality(uVar12,0,0);
              if (!cVar3) {
                fVar14 = 0.5;
              }
              else {
                uVar12 = local_d8;
                uVar17 = local_d0;
                if (this.mRoot == null) goto LAB_180af22fd;
                iVar5 = UIRoot.get_activeHeight(this.mRoot,0);
                iVar4 = Screen.get_height(0);
                fVar14 = ((float)iVar5 / (float)iVar4) * 0.5;
              }
              iVar5 = Screen.get_width(0);
              lVar8 = this + 88;
              Rect.set_xMin(lVar8,(float)-iVar5 * fVar14,0);
              iVar5 = Screen.get_height(0);
              Rect.set_yMin(lVar8,(float)-iVar5 * fVar14,0);
              FUN_180d995d0(lVar8,0);
              Rect.set_xMax(lVar8);
              FUN_18044df60(lVar8,0);
              Rect.set_yMax(lVar8);
              goto LAB_180af1daa;
            }
            pauVar10 = (uint8 (*) [16])UIPanel.get_finalClipRegion(local_b8,lVar6,0);
            lVar8 = this + 88;
            auVar18 = *pauVar10;
            auVar18._0_4_ = auVar18._0_4_ - auVar18._8_4_ * 0.5;
            FUN_18044f4c0(lVar8,auVar18._0_8_,0);
            FUN_18044f4b0(lVar8);
            FUN_1809dd1c0(lVar8);
            goto LAB_180af1d9f;
          }
          uVar12 = this.container;
          cVar3 = Object.op_Inequality(uVar12,0,0);
          if (cVar3) {
            uVar12 = local_d8;
            uVar17 = local_d0;
            if ((this.container == null) ||
               (lVar8 = GameObject.get_transform(this.container,0), uVar12 = local_d8,
               uVar17 = local_d0, lVar8 == null)) goto LAB_180af22fd;
            uVar9 = FUN_180daa030(lVar8,0);
            cVar3 = Object.op_Inequality(uVar9,0,0);
            lVar8 = this.container;
            uVar12 = local_d8;
            uVar17 = local_d0;
            if (!cVar3) {
              if (lVar8 == null) goto LAB_180af22fd;
              uVar12 = GameObject.get_transform(lVar8,0);
              puVar7 = (uint64 *)NGUIMath.CalculateRelativeWidgetBounds(local_b8,uVar12,0);
            }
            else {
              if (lVar8 == null) goto LAB_180af22fd;
              uVar12 = GameObject.get_transform(lVar8,0);
              puVar7 = (uint64 *)NGUIMath.CalculateRelativeWidgetBounds(local_b8,uVar9,uVar12,0);
            }
            local_90 = puVar7[2];
            local_a0 = *puVar7;
            uStack_98 = puVar7[1];
            Bounds.get_min(&local_d8,&local_a0,0);
            lVar8 = this + 88;
            FUN_18044f4c0(lVar8);
            puVar7 = (uint64 *)Bounds.get_min(&local_d8,&local_a0,0);
            local_d8 = *puVar7;
            local_d0 = *(uint32 *)(puVar7 + 1);
            FUN_18044f4b0(lVar8);
            Bounds.get_size(&local_d8,&local_a0,0);
            FUN_1809dd1c0(lVar8);
            puVar7 = &local_a0;
            goto LAB_180af1d7a;
          }
          uVar12 = this.uiCamera;
          cVar3 = Object.op_Inequality(uVar12,0,0);
          if (!cVar3) {
            return;
          }
          bVar2 = true;
          uVar12 = local_d8;
          uVar17 = local_d0;
          if (this.uiCamera == null) goto LAB_180af22fd;
          puVar7 = (uint64 *)Camera.get_pixelRect(local_b8,this.uiCamera,0);
          uVar12 = puVar7[1];
          this.mRect = *puVar7;
          *(uint64 *)(this + 96) = uVar12;
        }
        else {
          uVar12 = local_d8;
          uVar17 = local_d0;
          if (((this.container == null) ||
              (lVar11 = GameObject.get_transform(this.container,0), uVar12 = local_d8,
              uVar17 = local_d0, lVar11 == null)) ||
             (uVar9 = FUN_180daa030(lVar11,0), uVar12 = local_d8, uVar17 = local_d0, lVar8 == null))
          goto LAB_180af22fd;
          puVar7 = (uint64 *)UIWidget.CalculateBounds(local_b8,lVar8,uVar9,0);
          local_88 = *puVar7;
          uStack_80 = puVar7[1];
          local_78 = puVar7[2];
          Bounds.get_min(&local_d8,&local_88,0);
          lVar8 = this + 88;
          FUN_18044f4c0(lVar8);
          puVar7 = (uint64 *)Bounds.get_min(&local_d8,&local_88,0);
          local_d8 = *puVar7;
          local_d0 = *(uint32 *)(puVar7 + 1);
          FUN_18044f4b0(lVar8);
          Bounds.get_size(&local_d8,&local_88,0);
          FUN_1809dd1c0(lVar8);
          puVar7 = &local_88;
        LAB_180af1d7a:
          puVar7 = (uint64 *)Bounds.get_size(&local_d8,puVar7,0);
          local_d8 = *puVar7;
          local_d0 = *(uint32 *)(puVar7 + 1);
        LAB_180af1d9f:
          FUN_1809dd1a0(this + 88);
        }
        LAB_180af1daa:
        lVar8 = this + 88;
        fVar14 = (float)FUN_180d995d0(lVar8,0);
        fVar15 = (float)Rect.get_xMax(lVar8,0);
        fVar19 = (fVar15 + fVar14) * 0.5;
        fVar14 = (float)FUN_18044df60(lVar8,0);
        fVar15 = (float)Rect.get_yMax(lVar8,0);
        iVar5 = this.side;
        local_c0 = 0;
        fVar14 = (fVar15 + fVar14) * 0.5;
        if (iVar5 != 8) {
          if (iVar5 - 4U < 3) {
            fVar19 = (float)Rect.get_xMax(lVar8,0);
          }
          else if ((iVar5 - 3U & 0xfffffffb) != 0) {
            fVar19 = (float)FUN_180d995d0(lVar8,0);
          }
          uVar1 = this.side;
          if (uVar1 - 2 < 3) {
            fVar14 = (float)Rect.get_yMax(lVar8,0);
          }
          else if ((8 < uVar1) || ((0x122U >> (uVar1 & 31) & 1) == 0)) {
            fVar14 = (float)FUN_18044df60(lVar8,0);
          }
        }
        fVar15 = (float)FUN_180d995b0(lVar8,0);
        fVar16 = (float)FUN_18044e2b0(lVar8,0);
        local_c8 = CONCAT44(fVar16 * *(float *)(this + 52) + *(float *)(this + 60) + fVar14,
                            fVar15 * this.relativeOffset + this.pixelOffset + fVar19);
        if (bVar2) {
          uVar12 = local_d8;
          uVar17 = local_d0;
          if (this.uiCamera == null) goto LAB_180af22fd;
          cVar3 = Camera.get_orthographic(this.uiCamera,0);
          if (cVar3) {
            uVar17 = FUN_18000d7c0();
            local_c8 = CONCAT44(local_c8._4_4_,uVar17);
            uVar17 = FUN_18000d7c0();
            local_c8 = CONCAT44(uVar17,(uint32)local_c8);
          }
          lVar6 = this.uiCamera;
          uVar12 = local_d8;
          uVar17 = local_d0;
          if ((this.mTrans == null) ||
             (puVar7 = (uint64 *)Transform.get_position(local_b8,this.mTrans,0),
             uVar12 = local_d8, uVar17 = local_d0, lVar6 == null)) goto LAB_180af22fd;
          local_d8 = *puVar7;
          local_d0 = *(uint32 *)(puVar7 + 1);
          puVar7 = (uint64 *)Camera.WorldToScreenPoint(local_b8,lVar6,&local_d8,0);
          local_d0 = *(uint32 *)(puVar7 + 1);
          uVar12 = *puVar7;
          uVar17 = local_d0;
          local_c0 = local_d0;
          if (this.uiCamera == null) goto LAB_180af22fd;
          local_d8 = local_c8;
          puVar7 = (uint64 *)
                   Camera.ScreenToWorldPoint(local_b8,this.uiCamera,&local_d8,0);
          uVar9 = *puVar7;
          uVar13 = *(uint32 *)(puVar7 + 1);
          uVar12 = local_d8;
          uVar17 = local_d0;
          if (this.uiCamera == null) goto LAB_180af22fd;
          cVar3 = Camera.get_orthographic(this.uiCamera,0);
          if (cVar3) {
            uVar12 = local_d8;
            uVar17 = local_d0;
            if (this.mTrans == null) goto LAB_180af22fd;
            uVar12 = FUN_180daa030(this.mTrans,0);
            cVar3 = Object.op_Inequality(uVar12,0,0);
            if (cVar3) {
              uVar12 = local_d8;
              uVar17 = local_d0;
              if ((this.mTrans == null) ||
                 (lVar6 = FUN_180daa030(this.mTrans,0), uVar12 = local_d8,
                 uVar17 = local_d0, lVar6 == null)) goto LAB_180af22fd;
              local_d8 = uVar9;
              local_d0 = uVar13;
              puVar7 = (uint64 *)Transform.InverseTransformPoint(local_b8,lVar6,&local_d8,0);
              local_c8 = *puVar7;
              uVar13 = *(uint32 *)(puVar7 + 1);
              iVar5 = Mathf.RoundToInt();
              local_c8 = CONCAT44(local_c8._4_4_,(float)iVar5);
              iVar5 = Mathf.RoundToInt();
              local_c8 = CONCAT44((float)iVar5,(uint32)local_c8);
              uVar9 = local_c8;
              uVar12 = local_d8;
              uVar17 = local_d0;
              if (this.mTrans == null) goto LAB_180af22fd;
              local_d8 = local_c8;
              local_d0 = uVar13;
              puVar7 = (uint64 *)
                       Transform.get_localPosition(local_b8,this.mTrans,0);
              local_c8 = *puVar7;
              local_c0 = *(uint32 *)(puVar7 + 1);
              cVar3 = Vector3.op_Inequality(&local_c8,&local_d8,0);
              if (cVar3) {
                uVar12 = local_d8;
                uVar17 = local_d0;
                if (this.mTrans == null) goto LAB_180af22fd;
                local_d8 = uVar9;
                local_d0 = uVar13;
                Transform.set_localPosition(this.mTrans,&local_d8,0);
              }
              goto LAB_180af2098;
            }
          }
        }
        else {
          uVar17 = FUN_18000d7c0();
          local_c8 = CONCAT44(local_c8._4_4_,uVar17);
          uVar17 = FUN_18000d7c0();
          local_c8 = CONCAT44(uVar17,(uint32)local_c8);
          cVar3 = Object.op_Inequality(lVar6,0,0);
          if (!cVar3) {
            uVar12 = this.container;
            cVar3 = Object.op_Inequality(uVar12,0,0);
            uVar9 = local_c8;
            if (cVar3) {
              uVar12 = local_d8;
              uVar17 = local_d0;
              if ((this.container == null) ||
                 (lVar6 = GameObject.get_transform(this.container,0), uVar12 = local_d8,
                 uVar17 = local_d0, lVar6 == null)) goto LAB_180af22fd;
              lVar6 = FUN_180daa030(lVar6,0);
              cVar3 = Object.op_Inequality(lVar6,0,0);
              uVar9 = local_c8;
              uVar12 = local_d8;
              uVar17 = local_d0;
              uVar13 = local_c0;
              if (cVar3) goto joined_r0x000180af1fcb;
            }
          }
          else {
            uVar12 = local_d8;
            uVar17 = local_d0;
            if (lVar6 == null) goto LAB_180af22fd;
            lVar6 = UIRect.get_cachedTransform(lVar6,0);
            uVar12 = local_d8;
            uVar17 = local_d0;
            uVar9 = local_c8;
            uVar13 = local_c0;
        joined_r0x000180af1fcb:
            local_d0 = uVar13;
            local_d8 = uVar9;
            local_c8 = local_d8;
            local_c0 = local_d0;
            if (lVar6 == null) goto LAB_180af22fd;
            puVar7 = (uint64 *)Transform.TransformPoint(local_b8,lVar6,&local_d8,0);
            local_c0 = *(uint32 *)(puVar7 + 1);
            uVar9 = *puVar7;
          }
          uVar12 = local_d8;
          uVar17 = local_d0;
          if (this.mTrans == null) goto LAB_180af22fd;
          puVar7 = (uint64 *)Transform.get_position(local_b8,this.mTrans,0);
          local_d8 = *puVar7;
          uVar13 = *(uint32 *)(puVar7 + 1);
          local_d0 = uVar13;
          local_c0 = uVar13;
        }
        uVar12 = local_d8;
        uVar17 = local_d0;
        if (this.mTrans != null) {
          local_d8 = uVar9;
          local_d0 = uVar13;
          puVar7 = (uint64 *)Transform.get_position(local_b8,this.mTrans,0);
          local_c8 = *puVar7;
          local_c0 = *(uint32 *)(puVar7 + 1);
          cVar3 = Vector3.op_Inequality(&local_c8,&local_d8,0);
          if (cVar3) {
            uVar12 = local_d8;
            uVar17 = local_d0;
            if (this.mTrans == null) goto LAB_180af22fd;
            local_d8 = uVar9;
            local_d0 = uVar13;
            Transform.set_position(this.mTrans,&local_d8,0);
          }
        LAB_180af2098:
          if ((this.runOnlyOnce) &&
             (cVar3 = Application.get_isPlaying(0), cVar3)) {
            Behaviour.set_enabled(this,0,0);
          }
          return;
        }
        LAB_180af22fd:
        local_d0 = uVar17;
        local_d8 = uVar12;
    }

    // Token : 0x60006D7
    // RVA   : 0xAF2310   Offset: 0xAF1710   Length: 0xA6
    public void /*ctor*/()
    {
        ulong uVar1;
        uint local_res8;
        uint32 uStackX_c;
        this.side = 8;
        this.runOnlyOnce = 1;
        uVar1 = Vector2.get_zero(0);
        local_res8 = (uint32)uVar1;
        uStackX_c = (uint32)((uint64)uVar1 >> 32);
        this.relativeOffset = local_res8;
        *(uint32 *)(this + 52) = uStackX_c;
        uVar1 = Vector2.get_zero(0);
        local_res8 = (uint32)uVar1;
        uStackX_c = (uint32)((uint64)uVar1 >> 32);
        this.pixelOffset = local_res8;
        *(uint32 *)(this + 60) = uStackX_c;
        FUN_18044ef50(this,0);
    }

}
