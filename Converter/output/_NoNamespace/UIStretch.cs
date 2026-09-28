// ============================================================
// Type  : UIStretch
// Token : 0x2000116
// ============================================================

public class UIStretch
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40006E7
    public Camera uiCamera;

    // Token: 0x40006E8
    public GameObject container;

    // Token: 0x40006E9
    public Style style;

    // Token: 0x40006EA
    public bool runOnlyOnce;

    // Token: 0x40006EB
    public Vector2 relativeSize;

    // Token: 0x40006EC
    public Vector2 initialSize;

    // Token: 0x40006ED
    public Vector2 borderPadding;

    // Token: 0x40006EE
    private UIWidget widgetContainer;

    // Token: 0x40006EF
    private Transform mTrans;

    // Token: 0x40006F0
    private UIWidget mWidget;

    // Token: 0x40006F1
    private UISprite mSprite;

    // Token: 0x40006F2
    private UIPanel mPanel;

    // Token: 0x40006F3
    private UIRoot mRoot;

    // Token: 0x40006F4
    private Animation mAnim;

    // Token: 0x40006F5
    private Rect mRect;

    // Token: 0x40006F6
    private bool mStarted;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600096A
    // RVA   : 0x170BA70   Offset: 0x170AE70   Length: 0x1C4
    private void Awake()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = Component.GetComponent(this,DAT_181d93168);
        this.mAnim = uVar1;
        this.mRect = 0;
        *(uint64 *)(this + 136) = 0;
        uVar1 = Component.get_transform(this,0);
        this.mTrans = uVar1;
        uVar1 = Component.GetComponent(this,DAT_181d97060);
        this.mWidget = uVar1;
        uVar1 = Component.GetComponent(this,DAT_181d96ee0);
        this.mSprite = uVar1;
        uVar1 = Component.GetComponent(this,DAT_181d96b60);
        this.mPanel = uVar1;
        uVar1 = UICamera.onScreenResize;
        uVar2 = new OnTooltipCB(this,DAT_181dc6888,0);
        plVar3 = (int64 *)Delegate.Combine(uVar1,uVar2,0);
        plVar4 = (int64 *)0;
        if (plVar3 != (int64 *)0) {
          if (*plVar3 == DAT_181d8d738) {
            plVar4 = plVar3;
          }
          if (plVar4 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar3,DAT_181d8d738);
          }
        }
        UICamera.onScreenResize = plVar4;
    }

    // Token : 0x600096B
    // RVA   : 0x170BC40   Offset: 0x170B040   Length: 0xF9
    private void OnDestroy()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = UICamera.onScreenResize;
        uVar2 = new OnTooltipCB(this,DAT_181dc6888,0);
        plVar3 = (int64 *)Delegate.Remove(uVar1,uVar2,0);
        plVar4 = (int64 *)0;
        if (plVar3 != (int64 *)0) {
          if (*plVar3 == DAT_181d8d738) {
            plVar4 = plVar3;
          }
          if (plVar4 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6070(plVar3,DAT_181d8d738);
          }
        }
        UICamera.onScreenResize = plVar4;
    }

    // Token : 0x600096C
    // RVA   : 0x170BD40   Offset: 0x170B140   Length: 0x17
    private void ScreenSizeChanged()
    {
        void FUN_18170bd40(int64 this)
        {
        if ((this.mStarted) && (this.runOnlyOnce)) {
          UIStretch.Update(this,0);
          return;
        }
    }

    // Token : 0x600096D
    // RVA   : 0x170BD60   Offset: 0x170B160   Length: 0x1E5
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
            if (this.widgetContainer == null) goto LAB_18170bf40;
            uVar3 = Component.get_gameObject(this.widgetContainer,0);
            this.container = uVar3;
            this.widgetContainer = 0;
          }
        }
        uVar3 = this.uiCamera;
        cVar1 = Object.op_Equality(uVar3,0,0);
        if (cVar1) {
          lVar4 = Component.get_gameObject(this,0);
          if (lVar4 == null) {
        LAB_18170bf40:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar2 = GameObject.get_layer(lVar4,0);
          uVar3 = NGUITools.FindCameraForLayer(uVar2,0);
          this.uiCamera = uVar3;
        }
        uVar3 = Component.get_gameObject(this,0);
        uVar3 = NGUITools.FindInParents(uVar3,DAT_181d8f820);
        this.mRoot = uVar3;
        UIStretch.Update(this,0);
        this.mStarted = 1;
    }

    // Token : 0x600096E
    // RVA   : 0x170BF50   Offset: 0x170B350   Length: 0xBEB
    private void Update()
    {
        bool cVar2;
        int iVar3;
        int iVar4;
        uint uVar5;
        long lVar6;
        ulong uVar8;
        ulong uVar9;
        uint8 (*pauVar10) [16];
        int64 lVar11;
        uint64 *puVar12;
        bool bVar13;
        bool bVar14;
        float fVar15;
        float fVar16;
        uint8 auVar17 [16];
        uint64 uVar18;
        float fVar19;
        float fVar20;
        uint64 local_d8;
        uint32 local_d0;
        uint64 local_c8;
        uint32 local_c0;
        uint64 local_b8;
        uint64 uStack_b0;
        uint64 local_98;
        uint64 uStack_90;
        uint64 local_88;
        uint64 local_80;
        uint64 uStack_78;
        uint64 local_70;
        uVar8 = this.mAnim;
        local_70 = 0;
        local_80 = 0;
        uStack_78 = 0;
        local_88 = 0;
        local_98 = 0;
        uStack_90 = 0;
        cVar2 = Object.op_Inequality(uVar8,0,0);
        if (cVar2) {
          if (this.mAnim == null) goto LAB_18170cb36;
          cVar2 = Animation.get_isPlaying(this.mAnim,0);
          if (cVar2) {
            return;
          }
        }
        if (this.style == null) {
          return;
        }
        uVar8 = this.container;
        cVar2 = Object.op_Equality(uVar8,0,0);
        lVar6 = 0;
        lVar11 = lVar6;
        if (!cVar2) {
          if (this.container == null) goto LAB_18170cb36;
          lVar11 = GameObject.GetComponent(this.container,DAT_181d74c30);
        }
        uVar8 = this.container;
        cVar2 = Object.op_Equality(uVar8,0,0);
        if (!cVar2) {
        LAB_18170c10f:
          if (this.container == null) goto LAB_18170cb36;
          lVar6 = GameObject.GetComponent(this.container,DAT_181d74b20);
        }
        else {
          cVar2 = Object.op_Equality(lVar11,0,0);
          if (!cVar2) goto LAB_18170c10f;
        }
        fVar20 = 1.0;
        cVar2 = Object.op_Inequality(lVar11,0,0);
        if (!cVar2) {
          cVar2 = Object.op_Inequality(lVar6,0,0);
          if (cVar2) {
            if (lVar6 == null) goto LAB_18170cb36;
            if (*(int *)(lVar6 + 0x134) == 0) {
              uVar8 = this.mRoot;
              cVar2 = Object.op_Inequality(uVar8,0,0);
              if (!cVar2) {
                fVar15 = 0.5;
              }
              else {
                if (this.mRoot == null) goto LAB_18170cb36;
                iVar4 = UIRoot.get_activeHeight(this.mRoot,0);
                iVar3 = Screen.get_height(0);
                fVar15 = ((float)iVar4 / (float)iVar3) * 0.5;
              }
              iVar4 = Screen.get_width(0);
              lVar11 = this + 128;
              Rect.set_xMin(lVar11,(float)-iVar4 * fVar15,0);
              iVar4 = Screen.get_height(0);
              Rect.set_yMin(lVar11,(float)-iVar4 * fVar15,0);
              FUN_180d98fc0(lVar11,0);
              Rect.set_xMax(lVar11);
              FUN_18044df60(lVar11,0);
              Rect.set_yMax(lVar11);
              goto LAB_18170c63b;
            }
            pauVar10 = (uint8 (*) [16])UIPanel.get_finalClipRegion(&local_b8,lVar6,0);
            lVar11 = this + 128;
            auVar17 = *pauVar10;
            auVar17._0_4_ = auVar17._0_4_ - auVar17._8_4_ * 0.5;
            FUN_18044f4c0(lVar11,auVar17._0_8_,0);
            FUN_18044f4b0(lVar11);
            FUN_1809dcb30(lVar11);
            goto LAB_18170c630;
          }
          uVar8 = this.container;
          cVar2 = Object.op_Inequality(uVar8,0,0);
          if (cVar2) {
            lVar11 = Component.get_transform(this,0);
            if (lVar11 == null) goto LAB_18170cb36;
            uVar8 = FUN_180da9a20(lVar11,0);
            cVar2 = Object.op_Inequality(uVar8,0,0);
            lVar11 = this.container;
            if (!cVar2) {
              if (lVar11 == null) goto LAB_18170cb36;
              uVar8 = GameObject.get_transform(lVar11,0);
              puVar7 = (uint64 *)NGUIMath.CalculateRelativeWidgetBounds(&local_b8,uVar8,0);
            }
            else {
              if (lVar11 == null) goto LAB_18170cb36;
              uVar9 = GameObject.get_transform(lVar11,0);
              puVar7 = (uint64 *)NGUIMath.CalculateRelativeWidgetBounds(&local_b8,uVar8,uVar9,0);
            }
            local_88 = puVar7[2];
            local_98 = *puVar7;
            uStack_90 = puVar7[1];
            Bounds.get_min(&local_c8,&local_98,0);
            lVar11 = this + 128;
            FUN_18044f4c0(lVar11);
            puVar12 = (uint64 *)Bounds.get_min(&local_c8,&local_98,0);
            local_c8 = *puVar12;
            local_c0 = (uint32)puVar12[1];
            FUN_18044f4b0(lVar11);
            Bounds.get_size(&local_c8,&local_98,0);
            FUN_1809dcb30(lVar11);
            puVar7 = &local_98;
            goto LAB_18170c60b;
          }
          uVar8 = this.uiCamera;
          cVar2 = Object.op_Inequality(uVar8,0,0);
          if (!cVar2) {
            return;
          }
          if (this.uiCamera == null) goto LAB_18170cb36;
          puVar7 = (uint64 *)Camera.get_pixelRect(&local_b8,this.uiCamera,0);
          uVar8 = this.mRoot;
          uVar9 = puVar7[1];
          this.mRect = *puVar7;
          *(uint64 *)(this + 136) = uVar9;
          cVar2 = Object.op_Inequality(uVar8,0,0);
          if (cVar2) {
            if (this.mRoot == null) goto LAB_18170cb36;
            fVar20 = (float)UIRoot.get_pixelSizeAdjustment(this.mRoot,0);
          }
        }
        else {
          lVar6 = Component.get_transform(this,0);
          if ((lVar6 == null) || (uVar8 = FUN_180da9a20(lVar6,0), lVar11 == null)) goto LAB_18170cb36;
          puVar7 = (uint64 *)UIWidget.CalculateBounds(&local_b8,lVar11,uVar8,0);
          local_80 = *puVar7;
          uStack_78 = puVar7[1];
          local_70 = puVar7[2];
          Bounds.get_min(&local_c8,&local_80,0);
          lVar11 = this + 128;
          FUN_18044f4c0(lVar11);
          puVar12 = (uint64 *)Bounds.get_min(&local_c8,&local_80,0);
          local_c8 = *puVar12;
          local_c0 = (uint32)puVar12[1];
          FUN_18044f4b0(lVar11);
          Bounds.get_size(&local_c8,&local_80,0);
          FUN_1809dcb30(lVar11);
          puVar7 = &local_80;
        LAB_18170c60b:
          puVar12 = (uint64 *)Bounds.get_size(&local_c8,puVar7,0);
          local_c8 = *puVar12;
          local_c0 = (uint32)puVar12[1];
        LAB_18170c630:
          FUN_1809dcb10(this + 128);
        }
        LAB_18170c63b:
        fVar15 = (float)FUN_180d98fa0(this + 128,0);
        fVar16 = (float)FUN_18044e2b0(this + 128,0);
        if ((fVar20 != 1.0) && (1.0 < fVar16)) {
          if (this.mRoot == null) goto LAB_18170cb36;
          iVar4 = UIRoot.get_activeHeight(this.mRoot,0);
          fVar15 = fVar15 * ((float)iVar4 / fVar16);
          fVar16 = fVar16 * ((float)iVar4 / fVar16);
        }
        uVar8 = this.mWidget;
        cVar2 = Object.op_Inequality(uVar8,0,0);
        if (!cVar2) {
          if (this.mTrans == null) goto LAB_18170cb36;
          puVar7 = (uint64 *)Transform.get_localScale(&local_c8,this.mTrans,0);
          local_d0 = *(uint32 *)(puVar7 + 1);
          fVar20 = (float)((uint64)*puVar7 >> 32);
          local_d8._0_4_ = (float)*puVar7;
        }
        else {
          lVar11 = this.mWidget;
          if (lVar11 == null) goto LAB_18170cb36;
          local_d0 = 0;
          local_d8._0_4_ = (float)*(int *)(lVar11 + 164);
          fVar20 = (float)*(int *)(lVar11 + 168);
        }
        iVar4 = this.style;
        local_d8 = CONCAT44(fVar20,(float)local_d8);
        if (iVar4 == 4) {
          fVar19 = fVar16 * this.relativeSize;
          local_d8 = (uint64)(uint32)fVar19;
          goto LAB_18170c7e7;
        }
        if (iVar4 == 5) {
          fVar19 = this.initialSize;
          fVar20 = *(float *)(this + 60);
          bVar14 = fVar15 / fVar16 == fVar19 / fVar20;
          bVar13 = fVar15 / fVar16 < fVar19 / fVar20;
        LAB_18170c78a:
          if (bVar13 || bVar14) {
            fVar15 = (fVar16 / fVar20) * fVar19;
            fVar20 = fVar16;
            local_d8._0_4_ = fVar15;
          }
          else {
            fVar20 = (fVar15 / fVar19) * fVar20;
            local_d8._0_4_ = fVar15;
          }
        LAB_18170c7f0:
          local_d8 = CONCAT44(fVar20,(float)local_d8);
        }
        else {
          if (iVar4 == 6) {
            fVar19 = this.initialSize;
            fVar20 = *(float *)(this + 60);
            bVar14 = fVar19 / fVar20 == fVar15 / fVar16;
            bVar13 = fVar19 / fVar20 < fVar15 / fVar16;
            goto LAB_18170c78a;
          }
          fVar19 = (float)local_d8;
          if (iVar4 == 2) {
        LAB_18170c7e7:
            fVar20 = fVar16 * *(float *)(this + 52);
            fVar15 = fVar19;
            goto LAB_18170c7f0;
          }
          fVar19 = fVar15 * this.relativeSize;
          local_d8 = CONCAT44(fVar20,fVar19);
          fVar15 = fVar19;
          if (iVar4 != 1) goto LAB_18170c7e7;
        }
        uVar8 = this.mSprite;
        cVar2 = Object.op_Inequality(uVar8,0,0);
        if (!cVar2) {
          uVar8 = this.mWidget;
          cVar2 = Object.op_Inequality(uVar8,0,0);
          if (cVar2) {
            iVar4 = this.style;
            if (iVar4 != 2) {
              lVar11 = this.mWidget;
              uVar5 = Mathf.RoundToInt();
              if (lVar11 == null) goto LAB_18170cb36;
              UIWidget.set_width(lVar11,uVar5,0);
              iVar4 = this.style;
            }
            if (iVar4 != 1) {
              lVar11 = this.mWidget;
        LAB_18170ca30:
              uVar5 = Mathf.RoundToInt();
              if (lVar11 == null) goto LAB_18170cb36;
              UIWidget.set_height(lVar11,uVar5,0);
            }
            goto LAB_18170ca50;
          }
          uVar8 = this.mPanel;
          cVar2 = Object.op_Inequality(uVar8,0,0);
          if (cVar2) {
            lVar11 = this.mPanel;
            if (lVar11 == null) goto LAB_18170cb36;
            local_b8 = *(uint64 *)(lVar11 + 0x138);
            uStack_b0 = *(uint64 *)(lVar11 + 0x140);
            if (this.style == 2) {
        LAB_18170c90f:
              uStack_b0 = CONCAT44(fVar20 - *(float *)(this + 68),(uint32)uStack_b0);
            }
            else {
              uVar18 = (uint64)uStack_b0 >> 32;
              uStack_b0 = CONCAT44((int)uVar18,fVar15 - this.borderPadding);
              if (this.style != 1) goto LAB_18170c90f;
            }
            UIPanel.set_baseClipRegion(lVar11,&local_b8,0);
            goto LAB_18170ca50;
          }
          uVar5 = local_d0;
          if (this.style == 2) {
        LAB_18170c8ba:
            local_d8 = CONCAT44(fVar20 - *(float *)(this + 68),(int)local_d8);
            uVar18 = local_d8;
          }
          else {
            local_d8 = CONCAT44(local_d8._4_4_,fVar15 - this.borderPadding);
            uVar18 = local_d8;
            if (this.style != 1) goto LAB_18170c8ba;
          }
        }
        else {
          lVar11 = this.mSprite;
          if (lVar11 == null) goto LAB_18170cb36;
          lVar11 = il2cpp_internal(lVar11.mAtlas,DAT_181d7a788);
          if (lVar11 != null) {
            plVar1 = this.mSprite;
            if (plVar1 == (int64 *)0) goto LAB_18170cb36;
            (**(code **)(*plVar1 + 0x3d8))(plVar1,*(uint64 *)(*plVar1 + 0x3e0));
          }
          iVar4 = this.style;
          if (iVar4 != 2) {
            lVar11 = this.mSprite;
            uVar5 = Mathf.RoundToInt();
            if (lVar11 == null) goto LAB_18170cb36;
            UIWidget.set_width(lVar11,uVar5,0);
            iVar4 = this.style;
          }
          if (iVar4 != 1) {
            lVar11 = this.mSprite;
            goto LAB_18170ca30;
          }
        LAB_18170ca50:
          puVar12 = (uint64 *)Vector3.get_one(&local_c8,0);
          uVar5 = (int)puVar12[1];
          uVar18 = *puVar12;
        }
        if (this.mTrans == null) {
        LAB_18170cb36:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        local_d8 = uVar18;
        local_d0 = uVar5;
        puVar12 = (uint64 *)Transform.get_localScale(&local_b8,this.mTrans,0);
        local_c8 = *puVar12;
        local_c0 = (uint32)puVar12[1];
        cVar2 = Vector3.op_Inequality(&local_c8,&local_d8,0);
        if (cVar2) {
          if (this.mTrans == null) goto LAB_18170cb36;
          local_c8 = uVar18;
          local_c0 = uVar5;
          Transform.set_localScale(this.mTrans,&local_c8,0);
        }
        if ((this.runOnlyOnce) && (cVar2 = Application.get_isPlaying(0), cVar2))
        {
          Behaviour.set_enabled(this,0,0);
        }
    }

    // Token : 0x600096F
    // RVA   : 0x170CB40   Offset: 0x170BF40   Length: 0x82
    public void /*ctor*/()
    {
        ulong uVar1;
        uint local_res8;
        uint32 uStackX_c;
        this.runOnlyOnce = 1;
        uVar1 = Vector2.get_one(0);
        local_res8 = (uint32)uVar1;
        uStackX_c = (uint32)((uint64)uVar1 >> 32);
        this.relativeSize = local_res8;
        *(uint32 *)(this + 52) = uStackX_c;
        uVar1 = Vector2.get_one(0);
        local_res8 = (uint32)uVar1;
        uStackX_c = (uint32)((uint64)uVar1 >> 32);
        this.initialSize = local_res8;
        *(uint32 *)(this + 60) = uStackX_c;
        uVar1 = Vector2.get_zero(0);
        local_res8 = (uint32)uVar1;
        uStackX_c = (uint32)((uint64)uVar1 >> 32);
        this.borderPadding = local_res8;
        *(uint32 *)(this + 68) = uStackX_c;
        FUN_18044ef50(this,0);
    }

}
