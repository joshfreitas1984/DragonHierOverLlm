// ============================================================
// Type  : UIScrollView
// Token : 0x2000062
// ============================================================

public class UIScrollView
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000262
    public static BetterList<UIScrollView> list;

    // Token: 0x4000263
    public Movement movement;

    // Token: 0x4000264
    public DragEffect dragEffect;

    // Token: 0x4000265
    public bool restrictWithinPanel;

    // Token: 0x4000266
    public bool constrainOnDrag;

    // Token: 0x4000267
    public bool disableDragIfFits;

    // Token: 0x4000268
    public bool smoothDragStart;

    // Token: 0x4000269
    public bool iOSDragEmulation;

    // Token: 0x400026A
    public float scrollWheelFactor;

    // Token: 0x400026B
    public float momentumAmount;

    // Token: 0x400026C
    public float dampenStrength;

    // Token: 0x400026D
    public UIProgressBar horizontalScrollBar;

    // Token: 0x400026E
    public UIProgressBar verticalScrollBar;

    // Token: 0x400026F
    public ShowCondition showScrollBars;

    // Token: 0x4000270
    public Vector2 customMovement;

    // Token: 0x4000271
    public Pivot contentPivot;

    // Token: 0x4000272
    public OnDragNotification onDragStarted;

    // Token: 0x4000273
    public OnDragNotification onDragFinished;

    // Token: 0x4000274
    public OnDragNotification onMomentumMove;

    // Token: 0x4000275
    public OnDragNotification onStoppedMoving;

    // Token: 0x4000276
    private Vector3 scale;

    // Token: 0x4000277
    private Vector2 relativePositionOnReset;

    // Token: 0x4000278
    protected Transform mTrans;

    // Token: 0x4000279
    protected UIPanel mPanel;

    // Token: 0x400027A
    protected Plane mPlane;

    // Token: 0x400027B
    protected Vector3 mLastPos;

    // Token: 0x400027C
    protected bool mPressed;

    // Token: 0x400027D
    protected Vector3 mMomentum;

    // Token: 0x400027E
    protected float mScroll;

    // Token: 0x400027F
    protected Bounds mBounds;

    // Token: 0x4000280
    protected bool mCalculatedBounds;

    // Token: 0x4000281
    protected bool mShouldMove;

    // Token: 0x4000282
    protected bool mIgnoreCallbacks;

    // Token: 0x4000283
    protected int mDragID;

    // Token: 0x4000284
    protected Vector2 mDragStartOffset;

    // Token: 0x4000285
    protected bool mDragStarted;

    // Token: 0x4000286
    private bool mStarted;

    // Token: 0x4000287
    public UICenterOnChild centerOnChild;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600024F
    // RVA   : 0x27B020   Offset: 0x27A420   Length: 0x8
    public UIPanel get_panel()
    {
        uint64 FUN_18027b020(int64 this)
        {
        return this.mPanel;
    }

    // Token : 0x6000250
    // RVA   : 0x1705010   Offset: 0x1704410   Length: 0x14
    public bool get_isDragging()
    {
        ulong in_RAX;
        if (!this.mPressed) {
          return in_RAX & 0xffffffffffffff00;
        }
        return (uint64)this.mDragStarted;
    }

    // Token : 0x6000251
    // RVA   : 0x1704EF0   Offset: 0x17042F0   Length: 0x9D
    public virtual Bounds get_bounds()
    {
        ulong uVar1;
        ulong uVar2;
        byte[] local_28 = new byte[32];
        if (*(char *)(param_2 + 232) == false) {
          *(uint8 *)(param_2 + 232) = 1;
          uVar2 = Component.get_transform(param_2,0);
          *(uint64 *)(param_2 + 144) = uVar2;
          puVar3 = (uint64 *)
                   NGUIMath.CalculateRelativeWidgetBounds
                             (local_28,*(uint64 *)(param_2 + 144),*(uint64 *)(param_2 + 144),0);
          uVar2 = puVar3[1];
          *(uint64 *)(param_2 + 208) = *puVar3;
          *(uint64 *)(param_2 + 216) = uVar2;
          *(uint64 *)(param_2 + 224) = puVar3[2];
        }
        uVar1 = *(uint64 *)(param_2 + 216);
        uVar2 = *(uint64 *)(param_2 + 224);
        *this = *(uint64 *)(param_2 + 208);
        this[1] = uVar1;
        this[2] = uVar2;
        return this;
    }

    // Token : 0x6000252
    // RVA   : 0x1704F90   Offset: 0x1704390   Length: 0x24
    public bool get_canMoveHorizontally()
    {
        uint uVar1;
        uVar1 = this.movement;
        uVar2 = (uint7)(uint3)(uVar1 >> 8);
        if (((uVar1 & 0xfffffffd) != 0) && ((uVar1 != 3 || (this.customMovement == null.0)))) {
          return (uint64)uVar2 << 8;
        }
        return CONCAT71(uVar2,1);
    }

    // Token : 0x6000253
    // RVA   : 0x1704FC0   Offset: 0x17043C0   Length: 0x25
    public bool get_canMoveVertically()
    {
        uint uVar1;
        uVar1 = this.movement - 1;
        uVar2 = (uint7)(uint3)(uVar1 >> 8);
        if ((1 < uVar1) && ((this.movement != 3 || (*(float *)(this + 80) == 0.0)))) {
          return (uint64)uVar2 << 8;
        }
        return CONCAT71(uVar2,1);
    }

    // Token : 0x6000254
    // RVA   : 0x1705030   Offset: 0x1704430   Length: 0x9E
    public virtual bool get_shouldMoveHorizontally()
    {
        long lVar1;
        int iVar2;
        float fVar5;
        float fVar6;
        byte[] local_48 = new byte[24];
        uint local_30;
        uint32 uStack_2c;
        uint32 uStack_28;
        uint32 uStack_24;
        uint64 local_20;
        puVar3 = (uint32 *)
                 (**(code **)(*this + 0x178))(local_48,this,*(uint64 *)(*this + 0x180));
        local_30 = *puVar3;
        uStack_2c = puVar3[1];
        uStack_28 = puVar3[2];
        uStack_24 = puVar3[3];
        local_20 = *(uint64 *)(puVar3 + 4);
        pfVar4 = (float *)Bounds.get_size(local_48,&local_30,0);
        lVar1 = this[19];
        fVar6 = *pfVar4;
        if (lVar1 != null) {
          if (*(int *)(lVar1 + 0x134) == 3) {
            fVar6 = fVar6 + *(float *)(lVar1 + 0x148) + *(float *)(lVar1 + 0x148);
          }
          fVar5 = (float)UIPanel.get_width(lVar1,0);
          iVar2 = Mathf.RoundToInt(fVar6 - fVar5,0);
          return 0 < iVar2;
        }
    }

    // Token : 0x6000255
    // RVA   : 0x17050D0   Offset: 0x17044D0   Length: 0xAE
    public virtual bool get_shouldMoveVertically()
    {
        long lVar1;
        int iVar2;
        float fVar5;
        float fVar6;
        byte[] local_48 = new byte[24];
        uint local_30;
        uint32 uStack_2c;
        uint32 uStack_28;
        uint32 uStack_24;
        uint64 local_20;
        puVar3 = (uint32 *)
                 (**(code **)(*this + 0x178))(local_48,this,*(uint64 *)(*this + 0x180));
        local_30 = *puVar3;
        uStack_2c = puVar3[1];
        uStack_28 = puVar3[2];
        uStack_24 = puVar3[3];
        local_20 = *(uint64 *)(puVar3 + 4);
        puVar4 = (uint64 *)Bounds.get_size(local_48,&local_30,0);
        lVar1 = this[19];
        fVar6 = (float)((uint64)*puVar4 >> 32);
        if (lVar1 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (*(int *)(lVar1 + 0x134) == 3) {
          fVar6 = *(float *)(lVar1 + 0x14c) + *(float *)(lVar1 + 0x14c) + fVar6;
        }
        fVar5 = (float)UIPanel.get_height(lVar1,0);
        iVar2 = Mathf.RoundToInt(fVar6 - fVar5,0);
        return 0 < iVar2;
    }

    // Token : 0x6000256
    // RVA   : 0x1705180   Offset: 0x1704580   Length: 0x2C1
    protected virtual bool get_shouldMove()
    {
        float fVar1;
        bool cVar2;
        int iVar3;
        long lVar4;
        float fVar8;
        float fVar9;
        ulong local_98;
        uint local_90;
        float local_80;
        float fStack_7c;
        float fStack_78;
        float fStack_74;
        uint32 local_70;
        uint32 uStack_6c;
        uint32 uStack_68;
        uint32 uStack_64;
        uint64 local_60;
        if (*(char *)((int64)this + 34) != false) {
          lVar4 = this[19];
          cVar2 = Object.op_Equality(lVar4,0,0);
          if (cVar2) {
            lVar4 = Component.GetComponent(this,DAT_181d96b60);
            this[19] = lVar4;
            il2cpp_internal(this + 19,lVar4);
          }
          if (this[19] == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          pfVar5 = (float *)UIPanel.get_finalClipRegion(&local_80,this[19],0);
          local_80 = *pfVar5;
          fStack_7c = pfVar5[1];
          fVar9 = pfVar5[2];
          fStack_74 = pfVar5[3];
          fStack_78 = fVar9;
          puVar6 = (uint32 *)
                   (**(code **)(*this + 0x178))(&local_98,this,*(uint64 *)(*this + 0x180));
          local_70 = *puVar6;
          uStack_6c = puVar6[1];
          uStack_68 = puVar6[2];
          uStack_64 = puVar6[3];
          local_60 = *(uint64 *)(puVar6 + 4);
          if (fVar9 == 0.0) {
            iVar3 = Screen.get_width(0);
            fVar9 = (float)iVar3;
          }
          else {
            fVar9 = fVar9 * 0.5;
          }
          if (fStack_74 == 0.0) {
            iVar3 = Screen.get_height(0);
            fVar8 = (float)iVar3;
          }
          else {
            fVar8 = fStack_74 * 0.5;
          }
          if ((((*(uint32 *)(this + 3) & 0xfffffffd) != 0) &&
              ((*(uint32 *)(this + 3) != 3 || (*(float *)((int64)this + 76) == 0.0)))) ||
             ((pfVar5 = (float *)Bounds.get_min(&local_98,&local_70,0), fVar1 = local_80,
              local_80 - fVar9 <= *pfVar5 + 0.001 &&
              (pfVar5 = (float *)Bounds.get_max(&local_98,&local_70,0), *pfVar5 - 0.001 <= fVar1 + fVar9)
              ))) {
            if (((int)this[3] - 1U < 2) ||
               (((int)this[3] == 3 && (*(float *)(this + 10) != 0.0)))) {
              puVar7 = (uint64 *)Bounds.get_min(&local_98,&local_70,0);
              fVar9 = fStack_7c;
              local_98 = *puVar7;
              local_90 = *(uint32 *)(puVar7 + 1);
              if ((float)((uint64)local_98 >> 32) + 0.001 < fStack_7c - fVar8) {
                return true;
              }
              lVar4 = Bounds.get_max(&local_98,&local_70,0);
              if (fVar9 + fVar8 < *(float *)(lVar4 + 4) - 0.001) {
                return true;
              }
            }
            return false;
          }
        }
        return true;
    }

    // Token : 0x6000257
    // RVA   : 0x1704FF0   Offset: 0x17043F0   Length: 0x19
    public Vector3 get_currentMomentum()
    {
        uint64 * FUN_181704ff0(uint64 *this,int64 param_2)
        {
        uint32 uVar1;
        uVar1 = *(uint32 *)(param_2 + 200);
        *this = *(uint64 *)(param_2 + 192);
        *(uint32 *)(this + 1) = uVar1;
        return this;
    }

    // Token : 0x6000258
    // RVA   : 0x1705450   Offset: 0x1704850   Length: 0x1D
    public void set_currentMomentum(Vector3 value)
    {
        void FUN_181705450(int64 this,uint64 *value)
        {
        uint32 uVar1;
        uVar1 = *(uint32 *)(value + 1);
        this.mMomentum = *value;
        *(uint32 *)(this + 200) = uVar1;
        this.mShouldMove = 1;
    }

    // Token : 0x6000259
    // RVA   : 0x17017E0   Offset: 0x1700BE0   Length: 0x211
    private void Awake()
    {
        long lVar1;
        uint uVar2;
        ulong uVar3;
        float fVar5;
        float fVar6;
        float local_res8;
        float fStackX_c;
        uint8 local_48 [64];
        uVar3 = Component.get_transform(this,0);
        this.mTrans = uVar3;
        uVar3 = Component.GetComponent(this,DAT_181d96b60);
        this.mPanel = uVar3;
        lVar1 = this.mPanel;
        if (lVar1 != null) {
          if (lVar1.mClipping == null) {
            UIPanel.set_clipping(lVar1,4);
          }
          if ((this.movement != 3) &&
             (fVar5 = (float)Vector3.get_sqrMagnitude(this + 120,0), 0.001 < fVar5)) {
            fVar5 = this.scale;
            if ((fVar5 == 1.0) && (*(float *)(this + 124) == 0.0)) {
              this.movement = 0;
            }
            else if ((fVar5 == 0.0) && (*(float *)(this + 124) == 1.0)) {
              this.movement = 1;
            }
            else if ((fVar5 == 1.0) && (*(float *)(this + 124) == 1.0)) {
              this.movement = 2;
            }
            else {
              this.customMovement = fVar5;
              this.movement = 3;
              *(uint32 *)(this + 80) = *(uint32 *)(this + 124);
            }
            puVar4 = (uint64 *)Vector3.get_zero(local_48,0);
            this.scale = *puVar4;
            *(uint32 *)(this + 128) = *(uint32 *)(puVar4 + 1);
          }
          if (this.contentPivot == null) {
            fVar5 = this.relativePositionOnReset;
            fVar6 = *(float *)(this + 136);
            uVar3 = Vector2.get_zero(0);
            local_res8 = (float)uVar3;
            fVar5 = fVar5 - local_res8;
            fStackX_c = (float)((uint64)uVar3 >> 32);
            fVar6 = fVar6 - fStackX_c;
            if (9.9999994e-11 <= fVar6 * fVar6 + fVar5 * fVar5) {
              uVar2 = NGUIMath.GetPivot(CONCAT44(1.0 - *(float *)(this + 136),
                                                  this.relativePositionOnReset),0);
              this.contentPivot = uVar2;
              uVar3 = Vector2.get_zero(0);
              local_res8 = (float)uVar3;
              fStackX_c = (float)((uint64)uVar3 >> 32);
              this.relativePositionOnReset = local_res8;
              *(float *)(this + 136) = fStackX_c;
            }
          }
          return;
        }
    }

    // Token : 0x600025A
    // RVA   : 0x1703040   Offset: 0x1702440   Length: 0xA5
    private void OnEnable()
    {
        var pStatics = *(int64*)(DAT_181db0278 + 184);
        bool cVar1;
        if (*pStatics != 0) {
          FUN_181583c60(*pStatics,this,DAT_181da7138);
          if (this.mStarted) {
            cVar1 = Application.get_isPlaying(0);
            if (cVar1) {
              UIScrollView.CheckScrollbars(this,0);
              return;
            }
          }
          return;
        }
    }

    // Token : 0x600025B
    // RVA   : 0x1704340   Offset: 0x1703740   Length: 0x30
    private void Start()
    {
        bool cVar1;
        this.mStarted = 1;
        cVar1 = Application.get_isPlaying(0);
        if (cVar1) {
          UIScrollView.CheckScrollbars(this,0);
          return;
        }
    }

    // Token : 0x600025C
    // RVA   : 0x1701A00   Offset: 0x1700E00   Length: 0x26A
    private void CheckScrollbars()
    {
        long lVar1;
        ulong uVar2;
        bool cVar3;
        ulong uVar4;
        uint uVar5;
        uint uVar6;
        lVar1 = this[7];
        cVar3 = Object.op_Inequality(lVar1,0,0);
        uVar6 = 0;
        if (cVar3) {
          if (this[7] == 0) throw; // [null/range check failed]
          uVar2 = *(uint64 *)(this[7] + 104);
          uVar4 = new OnTooltipCB(this,DAT_181dc6448,0);
          EventDelegate.Add(uVar2,uVar4,0);
          if (this[7] == 0) throw; // [null/range check failed]
          Component.BroadcastMessage(this[7],"CacheDefaultColor",1);
          lVar1 = this[7];
          if (((int)this[9] == 0) ||
             (cVar3 = (**(code **)(*this + 0x188))(this,*(uint64 *)(*this + 400)),
             cVar3)) {
            uVar5 = 0x3f800000;
          }
          else {
            uVar5 = 0;
          }
          if (lVar1 == null) throw; // [null/range check failed]
          UIProgressBar.set_alpha(lVar1,uVar5,0);
        }
        lVar1 = this[8];
        cVar3 = Object.op_Inequality(lVar1,0,0);
        if (!cVar3) {
          return;
        }
        if (this[8] != 0) {
          uVar2 = *(uint64 *)(this[8] + 104);
          uVar4 = new OnTooltipCB(this,DAT_181dc6448,0);
          EventDelegate.Add(uVar2,uVar4,0);
          if (this[8] != 0) {
            Component.BroadcastMessage(this[8],"CacheDefaultColor",1);
            lVar1 = this[8];
            if (((int)this[9] == 0) ||
               (cVar3 = (**(code **)(*this + 0x198))(this,*(uint64 *)(*this + 0x1a0)),
               cVar3)) {
              uVar6 = 0x3f800000;
            }
            if (lVar1 != null) {
              UIProgressBar.set_alpha(lVar1,uVar6,0);
              return;
            }
          }
        }
    }

    // Token : 0x600025D
    // RVA   : 0x1702FB0   Offset: 0x17023B0   Length: 0x89
    private void OnDisable()
    {
        var pStatics = *(int64*)(DAT_181db0278 + 184);
        if (*pStatics != 0) {
          FUN_181585c70(*pStatics,this,DAT_181da71b8);
          this.mPressed = 0;
          return;
        }
    }

    // Token : 0x600025E
    // RVA   : 0x1703D80   Offset: 0x1703180   Length: 0x1E
    public bool RestrictWithinBounds(bool instant)
    {
        uint64
        UIScrollView.RestrictWithinBounds(int64 *this,char instant,char param_3,char param_4)
        {
        int64 lVar1;
        int64 *plVar2;
        uint64 uVar3;
        float fVar4;
        float fVar5;
        char cVar6;
        uint32 *puVar7;
        uint64 *puVar8;
        uint64 uVar9;
        float extraout_XMM0_Da;
        uint32 uVar10;
        uint64 local_a8;
        float local_a0;
        uint64 local_98;
        float local_90;
        float local_88;
        float fStack_84;
        float local_80;
        uint8 local_78 [16];
        uint32 local_68;
        uint32 uStack_64;
        uint32 uStack_60;
        uint32 uStack_5c;
        uint64 local_58;
        uint8 local_50 [56];
        lVar1 = this[19];
        cVar6 = Object.op_Equality(lVar1,0,0);
        if (cVar6) {
          return false;
        }
        puVar7 = (uint32 *)
                 (**(code **)(*this + 0x178))(local_50,this,*(uint64 *)(*this + 0x180));
        plVar2 = (int64 *)this[19];
        local_68 = *puVar7;
        uStack_64 = puVar7[1];
        uStack_60 = puVar7[2];
        uStack_5c = puVar7[3];
        local_58 = *(uint64 *)(puVar7 + 4);
        puVar8 = (uint64 *)Bounds.get_min(local_78,&local_68,0);
        local_a8 = *puVar8;
        local_a0 = *(float *)(puVar8 + 1);
        local_98 = local_a8;
        puVar8 = (uint64 *)Bounds.get_max(local_78,&local_68,0);
        local_a8 = *puVar8;
        local_a0 = *(float *)(puVar8 + 1);
        if (plVar2 != (int64 *)0) {
          puVar8 = (uint64 *)
                   (**(code **)(*plVar2 + 0x2a8))
                             (local_78,plVar2,local_98,local_a8,*(uint64 *)(*plVar2 + 0x2b0));
          local_98 = *puVar8;
          local_90 = *(float *)(puVar8 + 1);
          local_88 = (float)local_98;
          fStack_84 = (float)((uint64)local_98 >> 32);
          if (!param_3) {
            local_88 = 0.0;
          }
          if (!param_4) {
            fStack_84 = 0.0;
          }
          local_80 = local_90;
          Vector3.get_sqrMagnitude(&local_88,0);
          fVar5 = fStack_84;
          fVar4 = local_88;
          if (extraout_XMM0_Da <= 0.1) {
            return false;
          }
          if ((instant) || (*(int *)((int64)this + 28) != 2)) {
            local_a8 = CONCAT44(fStack_84,local_88);
            local_a0 = local_80;
            (**(code **)(*this + 0x1d8))(this,&local_a8,*(uint64 *)(*this + 0x1e0));
            if (0.01 < ABS(local_88)) {
              this.movement = 0;
            }
            if (0.01 < ABS(fStack_84)) {
              *(uint32 *)((int64)this + 196) = 0;
            }
            if (0.01 < ABS(local_80)) {
              *(uint32 *)(this + 25) = 0;
            }
            *(uint32 *)((int64)this + 204) = 0;
            return true;
          }
          if (this[18] != 0) {
            uVar9 = CONCAT44(fStack_84,local_88);
            local_a0 = local_80;
            puVar8 = (uint64 *)Transform.get_localPosition(local_50,this[18],0);
            local_98 = *puVar8;
            uVar3 = (uint64)local_98 >> 32;
            local_90 = *(float *)(puVar8 + 1) + local_a0;
            local_a8 = uVar9;
            uVar10 = FUN_18000d7c0(fVar4 + (float)local_98);
            local_98 = CONCAT44(local_98._4_4_,uVar10);
            uVar10 = FUN_18000d7c0((float)uVar3 + fVar5);
            local_98 = CONCAT44(uVar10,(uint32)local_98);
            if (this[19] != 0) {
              uVar9 = Component.get_gameObject(this[19],0);
              local_a0 = local_90;
              local_a8 = local_98;
              SpringPanel.Begin(uVar9,&local_a8,0x41000000,0);
              return true;
            }
          }
        }
    }

    // Token : 0x600025F
    // RVA   : 0x1703A40   Offset: 0x1702E40   Length: 0x33C
    public bool RestrictWithinBounds(bool instant, bool horizontal, bool vertical)
    {
        uint64
        UIScrollView.RestrictWithinBounds(int64 *this,char instant,char horizontal,char vertical)
        {
        int64 lVar1;
        int64 *plVar2;
        uint64 uVar3;
        float fVar4;
        float fVar5;
        char cVar6;
        uint32 *puVar7;
        uint64 *puVar8;
        uint64 uVar9;
        float extraout_XMM0_Da;
        uint32 uVar10;
        uint64 local_a8;
        float local_a0;
        uint64 local_98;
        float local_90;
        float local_88;
        float fStack_84;
        float local_80;
        uint8 local_78 [16];
        uint32 local_68;
        uint32 uStack_64;
        uint32 uStack_60;
        uint32 uStack_5c;
        uint64 local_58;
        uint8 local_50 [56];
        lVar1 = this[19];
        cVar6 = Object.op_Equality(lVar1,0,0);
        if (cVar6) {
          return false;
        }
        puVar7 = (uint32 *)
                 (**(code **)(*this + 0x178))(local_50,this,*(uint64 *)(*this + 0x180));
        plVar2 = (int64 *)this[19];
        local_68 = *puVar7;
        uStack_64 = puVar7[1];
        uStack_60 = puVar7[2];
        uStack_5c = puVar7[3];
        local_58 = *(uint64 *)(puVar7 + 4);
        puVar8 = (uint64 *)Bounds.get_min(local_78,&local_68,0);
        local_a8 = *puVar8;
        local_a0 = *(float *)(puVar8 + 1);
        local_98 = local_a8;
        puVar8 = (uint64 *)Bounds.get_max(local_78,&local_68,0);
        local_a8 = *puVar8;
        local_a0 = *(float *)(puVar8 + 1);
        if (plVar2 != (int64 *)0) {
          puVar8 = (uint64 *)
                   (**(code **)(*plVar2 + 0x2a8))
                             (local_78,plVar2,local_98,local_a8,*(uint64 *)(*plVar2 + 0x2b0));
          local_98 = *puVar8;
          local_90 = *(float *)(puVar8 + 1);
          local_88 = (float)local_98;
          fStack_84 = (float)((uint64)local_98 >> 32);
          if (!horizontal) {
            local_88 = 0.0;
          }
          if (!vertical) {
            fStack_84 = 0.0;
          }
          local_80 = local_90;
          Vector3.get_sqrMagnitude(&local_88,0);
          fVar5 = fStack_84;
          fVar4 = local_88;
          if (extraout_XMM0_Da <= 0.1) {
            return false;
          }
          if ((instant) || (*(int *)((int64)this + 28) != 2)) {
            local_a8 = CONCAT44(fStack_84,local_88);
            local_a0 = local_80;
            (**(code **)(*this + 0x1d8))(this,&local_a8,*(uint64 *)(*this + 0x1e0));
            if (0.01 < ABS(local_88)) {
              this.movement = 0;
            }
            if (0.01 < ABS(fStack_84)) {
              *(uint32 *)((int64)this + 196) = 0;
            }
            if (0.01 < ABS(local_80)) {
              *(uint32 *)(this + 25) = 0;
            }
            *(uint32 *)((int64)this + 204) = 0;
            return true;
          }
          if (this[18] != 0) {
            uVar9 = CONCAT44(fStack_84,local_88);
            local_a0 = local_80;
            puVar8 = (uint64 *)Transform.get_localPosition(local_50,this[18],0);
            local_98 = *puVar8;
            uVar3 = (uint64)local_98 >> 32;
            local_90 = *(float *)(puVar8 + 1) + local_a0;
            local_a8 = uVar9;
            uVar10 = FUN_18000d7c0(fVar4 + (float)local_98);
            local_98 = CONCAT44(local_98._4_4_,uVar10);
            uVar10 = FUN_18000d7c0((float)uVar3 + fVar5);
            local_98 = CONCAT44(uVar10,(uint32)local_98);
            if (this[19] != 0) {
              uVar9 = Component.get_gameObject(this[19],0);
              local_a0 = local_90;
              local_a8 = local_98;
              SpringPanel.Begin(uVar9,&local_a8,0x41000000,0);
              return true;
            }
          }
        }
    }

    // Token : 0x6000260
    // RVA   : 0x1701C70   Offset: 0x1701070   Length: 0x94
    public void DisableSpring()
    {
        long lVar1;
        bool cVar2;
        lVar1 = Component.GetComponent(this,DAT_181d95ce0);
        cVar2 = Object.op_Inequality(lVar1,0,0);
        if (cVar2) {
          if (lVar1 != null) {
            Behaviour.set_enabled(lVar1,0,0);
            return;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x6000261
    // RVA   : 0x125AA20   Offset: 0x1259E20   Length: 0x13
    public void UpdateScrollbars()
    {
        void UIScrollView.UpdateScrollbars
                     (int64 this,int64 *param_2,float param_3,float param_4,float param_5,
                     float param_6,char param_7)
        {
        uint64 uVar1;
        uint64 *puVar2;
        int64 lVar3;
        bool bVar4;
        char cVar5;
        int64 *plVar6;
        float fVar7;
        float fVar8;
        float fVar9;
        float fVar10;
        cVar5 = Object.op_Equality(param_2,0,0);
        if (!cVar5) {
          this.mIgnoreCallbacks = 1;
          if (param_6 < param_5) {
            fVar7 = (float)Mathf.Clamp01(param_3 / param_5,0);
            fVar10 = (float)Mathf.Clamp01(param_4 / param_5,0);
            fVar10 = fVar10 + fVar7;
            if (!param_7) {
              if (fVar10 <= 0.001) {
                fVar7 = 1.0;
              }
              else {
                fVar7 = fVar7 / fVar10;
              }
            }
            else if (fVar10 <= 0.001) {
              fVar7 = 0.0;
            }
            else {
              fVar7 = 1.0 - fVar7 / fVar10;
            }
            if (param_2 == (int64 *)0) goto LAB_181704d6e;
            UIProgressBar.Set(param_2,fVar7,1,0);
          }
          else {
            fVar7 = (float)Mathf.Clamp01(-param_3 / param_5,0);
            fVar8 = (float)Mathf.Clamp01(-param_4 / param_5,0);
            fVar10 = fVar7 + fVar8;
            if (!param_7) {
              if (fVar10 <= 0.001) {
                fVar9 = 1.0;
              }
              else {
                fVar9 = fVar7 / fVar10;
              }
            }
            else if (fVar10 <= 0.001) {
              fVar9 = 0.0;
            }
            else {
              fVar9 = 1.0 - fVar7 / fVar10;
            }
            if (param_2 == (int64 *)0) goto LAB_181704d6e;
            UIProgressBar.Set(param_2,fVar9,1,0);
            if (0.0 < param_5) {
              fVar7 = (float)Mathf.Clamp01(fVar7 / param_5,0);
              fVar10 = (float)Mathf.Clamp01(fVar8 / param_5,0);
              fVar10 = fVar10 + fVar7;
            }
          }
          plVar6 = param_2;
            fVar10 = (float)Mathf.Clamp01(1.0 - fVar10,0);
            if (*(float *)(plVar6 + 17) != fVar10) {
              *(float *)(plVar6 + 17) = fVar10;
              *(uint8 *)(plVar6 + 10) = 1;
              cVar5 = NGUITools.GetActive(plVar6,0);
              if (cVar5) {
                uVar1 = **(uint64 **)(DAT_181db0078 + 184);
                cVar5 = Object.op_Equality(uVar1,0,0);
                if ((cVar5) && (plVar6[13] != 0)) {
                  puVar2 = *(uint64 **)(DAT_181db0078 + 184);
                  *puVar2 = plVar6;
                  il2cpp_internal(puVar2,plVar6);
                  lVar3 = plVar6[13];
                  EventDelegate.Execute(lVar3,0);
                  puVar2 = *(uint64 **)(DAT_181db0078 + 184);
                  *puVar2 = 0;
                  il2cpp_internal(puVar2,0);
                }
                (**(code **)(*plVar6 + 0x1a8))(plVar6,*(uint64 *)(*plVar6 + 0x1b0));
              }
            }
          }
          this.mIgnoreCallbacks = 0;
        }
    }

    // Token : 0x6000262
    // RVA   : 0x1704580   Offset: 0x1703980   Length: 0x3BC
    public virtual void UpdateScrollbars(bool recalculateBounds)
    {
        void UIScrollView.UpdateScrollbars
                     (int64 this,int64 *recalculateBounds,float param_3,float param_4,float param_5,
                     float param_6,char param_7)
        {
        uint64 uVar1;
        uint64 *puVar2;
        int64 lVar3;
        bool bVar4;
        char cVar5;
        int64 *plVar6;
        float fVar7;
        float fVar8;
        float fVar9;
        float fVar10;
        cVar5 = Object.op_Equality(recalculateBounds,0,0);
        if (!cVar5) {
          this.mIgnoreCallbacks = 1;
          if (param_6 < param_5) {
            fVar7 = (float)Mathf.Clamp01(param_3 / param_5,0);
            fVar10 = (float)Mathf.Clamp01(param_4 / param_5,0);
            fVar10 = fVar10 + fVar7;
            if (!param_7) {
              if (fVar10 <= 0.001) {
                fVar7 = 1.0;
              }
              else {
                fVar7 = fVar7 / fVar10;
              }
            }
            else if (fVar10 <= 0.001) {
              fVar7 = 0.0;
            }
            else {
              fVar7 = 1.0 - fVar7 / fVar10;
            }
            if (recalculateBounds == (int64 *)0) goto LAB_181704d6e;
            UIProgressBar.Set(recalculateBounds,fVar7,1,0);
          }
          else {
            fVar7 = (float)Mathf.Clamp01(-param_3 / param_5,0);
            fVar8 = (float)Mathf.Clamp01(-param_4 / param_5,0);
            fVar10 = fVar7 + fVar8;
            if (!param_7) {
              if (fVar10 <= 0.001) {
                fVar9 = 1.0;
              }
              else {
                fVar9 = fVar7 / fVar10;
              }
            }
            else if (fVar10 <= 0.001) {
              fVar9 = 0.0;
            }
            else {
              fVar9 = 1.0 - fVar7 / fVar10;
            }
            if (recalculateBounds == (int64 *)0) goto LAB_181704d6e;
            UIProgressBar.Set(recalculateBounds,fVar9,1,0);
            if (0.0 < param_5) {
              fVar7 = (float)Mathf.Clamp01(fVar7 / param_5,0);
              fVar10 = (float)Mathf.Clamp01(fVar8 / param_5,0);
              fVar10 = fVar10 + fVar7;
            }
          }
          plVar6 = recalculateBounds;
            fVar10 = (float)Mathf.Clamp01(1.0 - fVar10,0);
            if (*(float *)(plVar6 + 17) != fVar10) {
              *(float *)(plVar6 + 17) = fVar10;
              *(uint8 *)(plVar6 + 10) = 1;
              cVar5 = NGUITools.GetActive(plVar6,0);
              if (cVar5) {
                uVar1 = **(uint64 **)(DAT_181db0078 + 184);
                cVar5 = Object.op_Equality(uVar1,0,0);
                if ((cVar5) && (plVar6[13] != 0)) {
                  puVar2 = *(uint64 **)(DAT_181db0078 + 184);
                  *puVar2 = plVar6;
                  il2cpp_internal(puVar2,plVar6);
                  lVar3 = plVar6[13];
                  EventDelegate.Execute(lVar3,0);
                  puVar2 = *(uint64 **)(DAT_181db0078 + 184);
                  *puVar2 = 0;
                  il2cpp_internal(puVar2,0);
                }
                (**(code **)(*plVar6 + 0x1a8))(plVar6,*(uint64 *)(*plVar6 + 0x1b0));
              }
            }
          }
          this.mIgnoreCallbacks = 0;
        }
    }

    // Token : 0x6000263
    // RVA   : 0x1704940   Offset: 0x1703D40   Length: 0x433
    protected void UpdateScrollbars(UIProgressBar slider, float contentMin, float contentMax, float contentSize, float viewSize, bool inverted)
    {
        void UIScrollView.UpdateScrollbars
                     (int64 this,int64 *slider,float contentMin,float contentMax,float contentSize,
                     float viewSize,char inverted)
        {
        uint64 uVar1;
        uint64 *puVar2;
        int64 lVar3;
        bool bVar4;
        char cVar5;
        int64 *plVar6;
        float fVar7;
        float fVar8;
        float fVar9;
        float fVar10;
        cVar5 = Object.op_Equality(slider,0,0);
        if (!cVar5) {
          this.mIgnoreCallbacks = 1;
          if (viewSize < contentSize) {
            fVar7 = (float)Mathf.Clamp01(contentMin / contentSize,0);
            fVar10 = (float)Mathf.Clamp01(contentMax / contentSize,0);
            fVar10 = fVar10 + fVar7;
            if (!inverted) {
              if (fVar10 <= 0.001) {
                fVar7 = 1.0;
              }
              else {
                fVar7 = fVar7 / fVar10;
              }
            }
            else if (fVar10 <= 0.001) {
              fVar7 = 0.0;
            }
            else {
              fVar7 = 1.0 - fVar7 / fVar10;
            }
            if (slider == (int64 *)0) goto LAB_181704d6e;
            UIProgressBar.Set(slider,fVar7,1,0);
          }
          else {
            fVar7 = (float)Mathf.Clamp01(-contentMin / contentSize,0);
            fVar8 = (float)Mathf.Clamp01(-contentMax / contentSize,0);
            fVar10 = fVar7 + fVar8;
            if (!inverted) {
              if (fVar10 <= 0.001) {
                fVar9 = 1.0;
              }
              else {
                fVar9 = fVar7 / fVar10;
              }
            }
            else if (fVar10 <= 0.001) {
              fVar9 = 0.0;
            }
            else {
              fVar9 = 1.0 - fVar7 / fVar10;
            }
            if (slider == (int64 *)0) goto LAB_181704d6e;
            UIProgressBar.Set(slider,fVar9,1,0);
            if (0.0 < contentSize) {
              fVar7 = (float)Mathf.Clamp01(fVar7 / contentSize,0);
              fVar10 = (float)Mathf.Clamp01(fVar8 / contentSize,0);
              fVar10 = fVar10 + fVar7;
            }
          }
          plVar6 = slider;
            fVar10 = (float)Mathf.Clamp01(1.0 - fVar10,0);
            if (*(float *)(plVar6 + 17) != fVar10) {
              *(float *)(plVar6 + 17) = fVar10;
              *(uint8 *)(plVar6 + 10) = 1;
              cVar5 = NGUITools.GetActive(plVar6,0);
              if (cVar5) {
                uVar1 = **(uint64 **)(DAT_181db0078 + 184);
                cVar5 = Object.op_Equality(uVar1,0,0);
                if ((cVar5) && (plVar6[13] != 0)) {
                  puVar2 = *(uint64 **)(DAT_181db0078 + 184);
                  *puVar2 = plVar6;
                  il2cpp_internal(puVar2,plVar6);
                  lVar3 = plVar6[13];
                  EventDelegate.Execute(lVar3,0);
                  puVar2 = *(uint64 **)(DAT_181db0078 + 184);
                  *puVar2 = 0;
                  il2cpp_internal(puVar2,0);
                }
                (**(code **)(*plVar6 + 0x1a8))(plVar6,*(uint64 *)(*plVar6 + 0x1b0));
              }
            }
          }
          this.mIgnoreCallbacks = 0;
        }
    }

    // Token : 0x6000264
    // RVA   : 0x1703ED0   Offset: 0x17032D0   Length: 0x46E
    public virtual void SetDragAmount(float x, float y, bool updateScrollbars)
    {
        void UIScrollView.SetDragAmount
                     (int64 *this,uint64 x,uint64 y,char updateScrollbars)
        {
        int64 *plVar1;
        uint64 uVar2;
        uint32 uVar3;
        char cVar4;
        int64 lVar5;
        uint32 *puVar6;
        float *pfVar7;
        uint64 *puVar8;
        float fVar9;
        float fVar10;
        float fVar11;
        float fVar12;
        float fVar13;
        uint64 local_b8;
        uint32 local_b0;
        float local_a8;
        float fStack_a4;
        float fStack_a0;
        float fStack_9c;
        uint32 local_90;
        uint32 uStack_8c;
        uint32 uStack_88;
        uint32 uStack_84;
        uint64 local_80;
        plVar1 = this + 19;
        lVar5 = *plVar1;
        cVar4 = Object.op_Equality(lVar5,0,0);
        if (cVar4) {
          lVar5 = Component.GetComponent(this,DAT_181d96b60);
          *plVar1 = lVar5;
          il2cpp_internal(plVar1,lVar5);
        }
        UIScrollView.DisableSpring(this,0);
        puVar6 = (uint32 *)
                 (**(code **)(*this + 0x178))(&local_a8,this,*(uint64 *)(*this + 0x180));
        local_90 = *puVar6;
        uStack_8c = puVar6[1];
        uStack_88 = puVar6[2];
        uStack_84 = puVar6[3];
        local_80 = *(uint64 *)(puVar6 + 4);
        pfVar7 = (float *)Bounds.get_min(&local_b8,&local_90,0);
        fVar9 = *pfVar7;
        pfVar7 = (float *)Bounds.get_max(&local_b8,&local_90,0);
        if (fVar9 == *pfVar7) {
          return;
        }
        puVar8 = (uint64 *)Bounds.get_min(&local_b8,&local_90,0);
        uVar2 = *puVar8;
        local_b0 = *(uint32 *)(puVar8 + 1);
        puVar8 = (uint64 *)Bounds.get_max(&local_b8,&local_90,0);
        local_b8 = *puVar8;
        local_b0 = *(uint32 *)(puVar8 + 1);
        if ((float)((uint64)uVar2 >> 32) == (float)((uint64)local_b8 >> 32)) {
          return;
        }
        if (*plVar1 == 0) throw; // [null/range check failed]
        pfVar7 = (float *)UIPanel.get_finalClipRegion(&local_a8,*plVar1,0);
        local_a8 = *pfVar7;
        fStack_a4 = pfVar7[1];
        fStack_a0 = pfVar7[2];
        fStack_9c = pfVar7[3];
        fVar10 = fStack_a0 * 0.5;
        fVar12 = fStack_9c * 0.5;
        pfVar7 = (float *)Bounds.get_min(&local_b8,&local_90,0);
        fVar13 = fVar10 + *pfVar7;
        pfVar7 = (float *)Bounds.get_max(&local_b8,&local_90,0);
        fVar10 = *pfVar7 - fVar10;
        puVar8 = (uint64 *)Bounds.get_min(&local_b8,&local_90,0);
        local_b8 = *puVar8;
        fVar9 = (float)((uint64)local_b8 >> 32);
        local_b0 = *(uint32 *)(puVar8 + 1);
        fVar11 = fVar9 + fVar12;
        puVar8 = (uint64 *)Bounds.get_max(&local_b8,&local_90,0);
        local_b8 = *puVar8;
        local_b0 = *(uint32 *)(puVar8 + 1);
        lVar5 = *plVar1;
        fVar12 = (float)((uint64)local_b8 >> 32) - fVar12;
        if (lVar5 == null) throw; // [null/range check failed]
        if (*(int *)(lVar5 + 0x134) == 3) {
          fVar13 = fVar13 - *(float *)(lVar5 + 0x148);
          fVar10 = fVar10 + *(float *)(lVar5 + 0x148);
          fVar11 = fVar11 - *(float *)(lVar5 + 0x14c);
          fVar12 = fVar12 + *(float *)(lVar5 + 0x14c);
        }
        fVar13 = (float)Mathf.Lerp(fVar13,fVar10,x,0);
        fVar11 = (float)Mathf.Lerp(fVar12,CONCAT44(fVar9,fVar11),y,0);
        fVar10 = fStack_a4;
        fVar9 = local_a8;
        if (!updateScrollbars) {
          if (this[18] == 0) throw; // [null/range check failed]
          puVar8 = (uint64 *)Transform.get_localPosition(&local_a8,this[18],0);
          uVar3 = *(uint32 *)(this + 3);
          local_b8 = *puVar8;
          if ((uVar3 & 0xfffffffd) == 0) {
        LAB_1817041f4:
            local_b8._4_4_ = (float)((uint64)local_b8 >> 32);
            local_b8 = CONCAT44(local_b8._4_4_,(fVar9 - fVar13) + (float)local_b8);
        LAB_181704206:
            if (uVar3 - 1 < 2) goto LAB_181704220;
            if (uVar3 != 3)
            {
              }
              else {
              if (uVar3 != 3) goto LAB_181704206;
              if (*(float *)((int64)this + 76) != 0.0) goto LAB_1817041f4;
            }
            if (*(float *)(this + 10) != 0.0) {
        LAB_181704220:
              local_b8 = CONCAT44((fVar10 - fVar11) + local_b8._4_4_,(float)local_b8);
            }
          }
          if (this[18] == 0) throw; // [null/range check failed]
          local_b0 = *(uint32 *)(puVar8 + 1);
          Transform.set_localPosition(this[18],&local_b8,0);
        }
        uVar3 = *(uint32 *)(this + 3);
        fVar12 = fVar13;
        if ((((uVar3 & 0xfffffffd) == 0) || (fVar12 = fVar9, uVar3 != 3)) ||
           (fVar12 = fVar13, *(float *)((int64)this + 76) != 0.0)) {
          if (uVar3 - 1 < 2) goto LAB_181704296;
          fVar9 = fVar12;
          if (uVar3 != 3)
          {
            }
            else {
          }
          fVar12 = fVar9;
          if (*(float *)(this + 10) != 0.0) {
        LAB_181704296:
            fVar10 = fVar11;
          }
        }
        lVar5 = *plVar1;
        if (lVar5 != null) {
          UIPanel.set_clipOffset
                    (lVar5,CONCAT44(fVar10 - *(float *)(lVar5 + 0x13c),fVar12 - *(float *)(lVar5 + 0x138))
                     ,0);
          if (updateScrollbars) {
            (**(code **)(*this + 0x1b8))
                      (this,*(int *)((int64)this + 236) == -10,*(uint64 *)(*this + 0x1c0)
                      );
          }
          return;
        }
    }

    // Token : 0x6000265
    // RVA   : 0x17026C0   Offset: 0x1701AC0   Length: 0x8
    public void InvalidateBounds()
    {
        this.mCalculatedBounds = 0;
    }

    // Token : 0x6000266
    // RVA   : 0x1703970   Offset: 0x1702D70   Length: 0xCD
    public void ResetPosition()
    {
        bool cVar1;
        ulong uVar2;
        uint local_res18;
        float fStackX_1c;
        cVar1 = NGUITools.GetActive(this,0);
        if (cVar1) {
          *(uint8 *)(this + 29) = 0;
          uVar2 = NGUIMath.GetPivotOffset(*(uint32 *)((int64)this + 84),0);
          fStackX_1c = (float)((uint64)uVar2 >> 32);
          local_res18 = (uint32)uVar2;
          (**(code **)(*this + 0x1c8))
                    (this,local_res18,1.0 - fStackX_1c,0,*(uint64 *)(*this + 0x1d0));
          (**(code **)(*this + 0x1c8))
                    (this,local_res18,1.0 - fStackX_1c,1,*(uint64 *)(*this + 0x1d0));
        }
    }

    // Token : 0x6000267
    // RVA   : 0x1704370   Offset: 0x1703770   Length: 0x20E
    public void UpdatePosition()
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        float local_res8;
        float fStackX_c;
        if (*(char *)((int64)this + 234) == false) {
          lVar1 = this[7];
          cVar2 = Object.op_Inequality(lVar1,0,0);
          if (!cVar2) {
            lVar1 = this[8];
            cVar2 = Object.op_Inequality(lVar1,0,0);
            if (!cVar2) {
              return;
            }
          }
          *(uint8 *)((int64)this + 234) = 1;
          *(uint8 *)(this + 29) = 0;
          uVar3 = NGUIMath.GetPivotOffset(*(uint32 *)((int64)this + 84),0);
          lVar1 = this[7];
          cVar2 = Object.op_Inequality(lVar1,0,0);
          if (!cVar2) {
            local_res8 = (float)uVar3;
          }
          else {
            lVar1 = this[7];
            if (lVar1 == null) goto LAB_181704579;
            local_res8 = *(float *)(lVar1 + 56);
            if (1 < *(int *)(lVar1 + 100)) {
              local_res8 = (float)FUN_18000d7c0((float)(*(int *)(lVar1 + 100) + -1) * local_res8);
              local_res8 = local_res8 / (float)(*(int *)(lVar1 + 100) + -1);
            }
          }
          lVar1 = this[8];
          cVar2 = Object.op_Inequality(lVar1,0,0);
          if (!cVar2) {
            fStackX_c = (float)((uint64)uVar3 >> 32);
            fStackX_c = 1.0 - fStackX_c;
          }
          else {
            lVar1 = this[8];
            if (lVar1 == null) {
        LAB_181704579:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            fStackX_c = *(float *)(lVar1 + 56);
            if (1 < *(int *)(lVar1 + 100)) {
              fStackX_c = (float)FUN_18000d7c0((float)(*(int *)(lVar1 + 100) + -1) * fStackX_c);
              fStackX_c = fStackX_c / (float)(*(int *)(lVar1 + 100) + -1);
            }
          }
          (**(code **)(*this + 0x1c8))
                    (this,local_res8,fStackX_c,0,*(uint64 *)(*this + 0x1d0));
          (**(code **)(*this + 0x1b8))(this,1,*(uint64 *)(*this + 0x1c0));
          *(uint8 *)((int64)this + 234) = 0;
        }
    }

    // Token : 0x6000268
    // RVA   : 0x17032B0   Offset: 0x17026B0   Length: 0x172
    public void OnScrollBar()
    {
        long lVar1;
        bool cVar2;
        float fVar3;
        float fVar4;
        if (*(char *)((int64)this + 234) == false) {
          *(uint8 *)((int64)this + 234) = 1;
          lVar1 = this[7];
          cVar2 = Object.op_Inequality(lVar1,0,0);
          fVar4 = 0.0;
          if (!cVar2) {
            fVar3 = 0.0;
          }
          else {
            lVar1 = this[7];
            if (lVar1 == null) goto LAB_18170341d;
            fVar3 = *(float *)(lVar1 + 56);
            if (1 < *(int *)(lVar1 + 100)) {
              fVar3 = (float)FUN_18000d7c0((float)(*(int *)(lVar1 + 100) + -1) * fVar3);
              fVar3 = fVar3 / (float)(*(int *)(lVar1 + 100) + -1);
            }
          }
          lVar1 = this[8];
          cVar2 = Object.op_Inequality(lVar1,0,0);
          if (cVar2) {
            lVar1 = this[8];
            if (lVar1 == null) {
        LAB_18170341d:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            fVar4 = *(float *)(lVar1 + 56);
            if (1 < *(int *)(lVar1 + 100)) {
              fVar4 = (float)FUN_18000d7c0((float)(*(int *)(lVar1 + 100) + -1) * fVar4);
              fVar4 = fVar4 / (float)(*(int *)(lVar1 + 100) + -1);
            }
          }
          (**(code **)(*this + 0x1c8))(this,fVar3,fVar4,0,*(uint64 *)(*this + 0x1d0));
          *(uint8 *)((int64)this + 234) = 0;
        }
    }

    // Token : 0x6000269
    // RVA   : 0x1702E90   Offset: 0x1702290   Length: 0x119
    public virtual void MoveRelative(Vector3 relative)
    {
        ulong uVar1;
        long lVar2;
        ulong local_38;
        float local_30;
        float local_20;
        lVar2 = this[18];
        if (lVar2 != null) {
          local_20 = relative[2];
          uVar1 = *(uint64 *)relative;
          puVar3 = (uint64 *)Transform.get_localPosition(&local_38,lVar2,0);
          local_30 = *(float *)(puVar3 + 1) + relative[2];
          local_38 = CONCAT44((float)((uint64)*puVar3 >> 32) + (float)((uint64)uVar1 >> 32),
                              (float)*puVar3 + (float)uVar1);
          local_20 = local_30;
          Transform.set_localPosition(lVar2,&local_38,0);
          lVar2 = this[19];
          if (lVar2 != null) {
            UIPanel.set_clipOffset
                      (lVar2,CONCAT44(*(float *)(lVar2 + 0x168) - relative[1],
                                      *(float *)(lVar2 + 0x164) - *relative),0);
                          // WARNING: Could not recover jumptable at 0x000181702f9d. Too many branches
                          // WARNING: Treating indirect jump as call
            (**(code **)(*this + 0x1b8))(this,0,*(uint64 *)(*this + 0x1c0));
            return;
          }
        }
    }

    // Token : 0x600026A
    // RVA   : 0x1702D80   Offset: 0x1702180   Length: 0x10E
    public void MoveAbsolute(Vector3 absolute)
    {
        long lVar1;
        ulong local_48;
        float local_40;
        ulong local_38;
        float local_30;
        byte[] local_28 = new byte[8];
        float local_20;
        byte[] local_18 = new byte[16];
        if (this[18] != 0) {
          local_48 = *absolute;
          local_40 = *(float *)(absolute + 1);
          puVar2 = (uint64 *)Transform.InverseTransformPoint(local_28,this[18],&local_48,0);
          lVar1 = this[18];
          local_48 = *puVar2;
          local_40 = *(float *)(puVar2 + 1);
          puVar2 = (uint64 *)Vector3.get_zero(local_28,0);
          if (lVar1 != null) {
            local_38 = *puVar2;
            local_30 = *(float *)(puVar2 + 1);
            puVar2 = (uint64 *)Transform.InverseTransformPoint(local_18,lVar1,&local_38,0);
            local_30 = local_40 - *(float *)(puVar2 + 1);
            local_38 = CONCAT44(local_48._4_4_ - (float)((uint64)*puVar2 >> 32),
                                (float)local_48 - (float)*puVar2);
            local_20 = local_30;
            (**(code **)(*this + 0x1d8))(this,&local_38,*(uint64 *)(*this + 0x1e0));
            return;
          }
        }
    }

    // Token : 0x600026B
    // RVA   : 0x1703430   Offset: 0x1702830   Length: 0x53C
    public void Press(bool pressed)
    {
        var pStatics = *(int64*)(DAT_181daf678 + 184);
        uint uVar1;
        long lVar2;
        bool cVar3;
        int iVar4;
        ulong uVar5;
        ulong uVar8;
        uint uVar9;
        uint uVar10;
        ulong local_res8;
        ulong local_68;
        uint local_60;
        long local_58;
        uint local_50;
        ulong local_48;
        ulong uStack_40;
        ulong local_38;
        ulong uStack_30;
        if (*(byte *)((int64)this + 188) == pressed) {
          return;
        }
        iVar4 = UICamera.get_currentScheme(0);
        if (iVar4 == 2) {
          return;
        }
        if ((*(byte *)((int64)this + 35) & pressed) != 0) {
          *(uint8 *)(this + 31) = 0;
          uVar5 = Vector2.get_zero(0);
          local_res8._0_4_ = (uint32)uVar5;
          local_res8._4_4_ = (uint32)((uint64)uVar5 >> 32);
          *(uint32 *)(this + 30) = (uint32)local_res8;
          *(uint32 *)((int64)this + 244) = local_res8._4_4_;
        }
        cVar3 = Behaviour.get_enabled(this,0);
        if (!cVar3) {
          return;
        }
        uVar5 = Component.get_gameObject(this,0);
        cVar3 = NGUITools.GetActive(uVar5,0);
        if (!cVar3) {
          return;
        }
        if (pressed == null) {
          iVar4 = *(int *)((int64)this + 236);
          if (iVar4 == UICamera.currentTouchID) {
            *(uint32 *)((int64)this + 236) = 0xfffffff6;
          }
        }
        *(uint8 *)(this + 29) = 0;
        cVar3 = (**(code **)(*this + 0x1a8))(this,*(uint64 *)(*this + 0x1b0));
        *(char *)((int64)this + 233) = cVar3;
        if (!cVar3) {
          return;
        }
        *(byte *)((int64)this + 188) = pressed;
        if (pressed != null) {
          plVar6 = (int64 *)Vector3.get_zero(&local_58,0);
          this[24] = *plVar6;
          *(int *)(this + 25) = (int)plVar6[1];
          *(uint32 *)((int64)this + 204) = 0;
          UIScrollView.DisableSpring(this,0);
          lVar2 = pStatics;
          this[22] = *(int64 *)(lVar2 + 100);
          *(uint32 *)(this + 23) = *(uint32 *)(lVar2 + 108);
          if (this[18] != 0) {
            puVar7 = (uint64 *)Transform.get_rotation(&local_38,this[18],0);
            uVar5 = *puVar7;
            uVar8 = puVar7[1];
            puVar7 = (uint64 *)Vector3.get_back(&local_58,0);
            local_68 = *puVar7;
            local_60 = *(uint32 *)(puVar7 + 1);
            local_38 = uVar5;
            uStack_30 = uVar8;
            plVar6 = (int64 *)Quaternion.op_Multiply(&local_58,&local_38,&local_68,0);
            local_68 = this[22];
            local_50 = (uint32)plVar6[1];
            local_58 = *plVar6;
            local_60 = (uint32)this[23];
            local_48 = 0;
            uStack_40 = 0;
            Plane.ctor(&local_48,&local_58,&local_68,0);
            lVar2 = this[19];
            *(uint32 *)(this + 20) = (uint32)local_48;
            *(uint32 *)((int64)this + 164) = local_48._4_4_;
            *(uint32 *)(this + 21) = (uint32)uStack_40;
            *(uint32 *)((int64)this + 172) = uStack_40._4_4_;
            if (lVar2 != null) {
              uVar10 = *(uint32 *)(lVar2 + 0x168);
              uVar9 = FUN_18000d7c0(*(uint32 *)(lVar2 + 0x164));
              uVar10 = FUN_18000d7c0(uVar10);
              local_res8 = CONCAT44(uVar10,uVar9);
              if (this[19] != 0) {
                UIPanel.set_clipOffset(this[19],local_res8,0);
                if (this[18] != 0) {
                  puVar7 = (uint64 *)Transform.get_localPosition(&local_58,this[18],0);
                  local_68 = *puVar7;
                  uVar10 = *(uint32 *)(puVar7 + 1);
                  uVar9 = FUN_18000d7c0((int)local_68);
                  local_68 = CONCAT44(local_68._4_4_,uVar9);
                  uVar9 = FUN_18000d7c0(local_68._4_4_);
                  local_68 = CONCAT44(uVar9,(uint32)local_68);
                  if (this[18] != 0) {
                    local_58 = local_68;
                    local_50 = uVar10;
                    Transform.set_localPosition(this[18],&local_58,0);
                    if (*(char *)((int64)this + 35) != false) {
                      return;
                    }
                    *(uint8 *)(this + 31) = 1;
                    uVar5 = Vector2.get_zero(0);
                    local_res8._0_4_ = (uint32)uVar5;
                    local_res8._4_4_ = (uint32)((uint64)uVar5 >> 32);
                    *(uint32 *)(this + 30) = (uint32)local_res8;
                    *(uint32 *)((int64)this + 244) = local_res8._4_4_;
                    if (this[11] == 0) {
                      return;
                    }
                    OnGeometryUpdated.Invoke(this[11],0);
                    return;
                  }
                }
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar2 = this[32];
        cVar3 = Object.op_Implicit(lVar2,0);
        if (cVar3) {
          if (((char)this[31] != false) && (this[12] != 0)) {
            OnGeometryUpdated.Invoke(this[12],0);
          }
          if (this[32] != 0) {
            UICenterOnChild.Recenter(this[32],0);
            return;
          }
        LAB_181703967:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if ((char)this[31] == false) goto LAB_1817036b9;
        if ((char)this[4] != false) {
          if (this[19] == 0) goto LAB_181703967;
          if (*(int *)(this[19] + 0x134) == 0) goto LAB_1817036a9;
          uVar1 = *(uint32 *)(this + 3);
          if ((uVar1 & 0xfffffffd) == 0) {
            uVar5 = 1;
        LAB_18170364c:
            if (uVar1 - 1 < 2) goto LAB_181703683;
            if (uVar1 == 3) goto LAB_181703672;
            uVar8 = 0;
          }
          else {
            if (uVar1 != 3) {
              uVar5 = 0;
              goto LAB_18170364c;
            }
            if (*(float *)((int64)this + 76) == 0.0) {
              uVar5 = 0;
            }
            else {
              uVar5 = 1;
            }
        LAB_181703672:
            if (*(float *)(this + 10) == 0.0) {
              uVar8 = 0;
            }
            else {
        LAB_181703683:
              uVar8 = 1;
            }
          }
          UIScrollView.RestrictWithinBounds
                    (this,*(int *)((int64)this + 28) == 0,uVar5,uVar8,0);
          if ((char)this[31] == false) goto LAB_1817036b9;
        }
        LAB_1817036a9:
        if (this[12] != 0) {
          OnGeometryUpdated.Invoke(this[12],0);
        }
        LAB_1817036b9:
        if ((*(char *)((int64)this + 233) == false) && (this[14] != 0)) {
          OnGeometryUpdated.Invoke(this[14],0);
        }
    }

    // Token : 0x600026C
    // RVA   : 0x1701D10   Offset: 0x1701110   Length: 0x9AD
    public void Drag()
    {
        uint uVar1;
        uint uVar2;
        long lVar3;
        bool cVar4;
        int iVar5;
        ulong uVar6;
        long lVar11;
        ulong uVar12;
        float fVar13;
        float fVar14;
        float fVar15;
        float fVar16;
        float fVar17;
        float fVar18;
        float fVar19;
        float fVar20;
        uint[] local_res8 = new uint[2];
        float local_138;
        float fStack_134;
        float local_130;
        long local_128;
        float local_120;
        float local_110;
        ulong local_108;
        uint local_100;
        uint local_f8;
        uint uStack_f4;
        uint uStack_f0;
        uint32 uStack_ec;
        uint64 local_e8;
        uint64 local_d8;
        uint64 uStack_d0;
        uint64 local_c8;
        uint32 local_c0;
        uint32 uStack_bc;
        uint32 uStack_b8;
        uint32 uStack_b4;
        uint64 local_b0;
        local_108 = 0;
        local_100 = 0;
        local_d8 = 0;
        uStack_d0 = 0;
        local_c8 = 0;
        if (*(char *)((int64)this + 188) == false) {
          return;
        }
        iVar5 = UICamera.get_currentScheme(0);
        if (iVar5 == 2) {
          return;
        }
        cVar4 = Behaviour.get_enabled(this,0);
        if (!cVar4) {
          return;
        }
        uVar6 = Component.get_gameObject(this,0);
        cVar4 = NGUITools.GetActive(uVar6,0);
        if (!cVar4) {
          return;
        }
        if (*(char *)((int64)this + 233) == false) {
          return;
        }
        if (*(int *)((int64)this + 236) == -10) {
          *(uint32 *)((int64)this + 236) =
               UICamera.currentTouchID;
        }
        lVar11 = UICamera.currentTouch;
        if (lVar11 == null) goto LAB_1817026b8;
        lVar11.clickNotification = 2;
        if (*(char *)((int64)this + 35) == false) {
        LAB_181701faf:
          lVar3 = UICamera.currentTouch;
          lVar11 = UICamera.currentCamera;
          if (lVar3 == null) goto LAB_1817026b8;
          fVar13 = lVar3.pos;
          fVar16 = *(float *)(lVar3 + 24);
        }
        else {
          if ((char)this[31] == false) {
            *(uint8 *)(this + 31) = 1;
            lVar11 = UICamera.currentTouch;
            if (lVar11 == null) goto LAB_1817026b8;
            uVar1 = *(uint32 *)(lVar11 + 48);
            *(uint32 *)(this + 30) = lVar11.totalDelta;
            *(uint32 *)((int64)this + 244) = uVar1;
            if (this[11] != 0) {
              OnGeometryUpdated.Invoke(this[11],0);
            }
          }
          if (*(char *)((int64)this + 35) == false) goto LAB_181701faf;
          lVar3 = UICamera.currentTouch;
          lVar11 = UICamera.currentCamera;
          if (lVar3 == null) goto LAB_1817026b8;
          fVar13 = lVar3.pos - *(float *)(this + 30);
          fVar16 = *(float *)(lVar3 + 24) - *(float *)((int64)this + 244);
        }
        if (lVar11 == null) goto LAB_1817026b8;
        local_128 = CONCAT44(fVar16,fVar13);
        local_120 = 0.0;
        puVar7 = (uint32 *)Camera.ScreenPointToRay(&local_f8,lVar11,&local_128,0);
        local_e8 = *(uint64 *)(puVar7 + 4);
        local_f8 = *puVar7;
        uStack_f4 = puVar7[1];
        uStack_f0 = puVar7[2];
        uStack_ec = puVar7[3];
        local_res8[0] = 0;
        local_c0 = local_f8;
        uStack_bc = uStack_f4;
        uStack_b8 = uStack_f0;
        uStack_b4 = uStack_ec;
        local_b0 = local_e8;
        cVar4 = Plane.Raycast(this + 20,&local_f8,local_res8,0);
        if (!cVar4) {
          return;
        }
        plVar8 = (int64 *)Ray.GetPoint(&local_f8,&local_c0,local_res8[0],0);
        local_120 = *(float *)(plVar8 + 1);
        local_128 = *plVar8;
        local_110 = *(float *)(this + 23);
        fVar16 = (float)local_128 - (float)this[22];
        fVar20 = (float)((uint64)local_128 >> 32) - *(float *)((int64)this + 180);
        fVar13 = local_120 - local_110;
        this[22] = local_128;
        *(int *)(this + 23) = (int)plVar8[1];
        if (((fVar16 != 0.0) || (fVar20 != 0.0)) || (fVar13 != 0.0)) {
          if (this[18] == 0) goto LAB_1817026b8;
          local_128 = CONCAT44(fVar20,fVar16);
          local_120 = fVar13;
          puVar9 = (uint64 *)
                   Transform.InverseTransformDirection(&local_f8,this[18],&local_128,0);
          iVar5 = (int)this[3];
          local_138 = (float)*puVar9;
          fStack_134 = (float)((uint64)*puVar9 >> 32);
          if (iVar5 == 0) {
            fStack_134 = 0.0;
            local_130 = 0.0;
          }
          else {
            if (iVar5 == 1) {
              local_138 = 0.0;
            }
            else if (iVar5 != 2) {
              local_138 = local_138 * *(float *)((int64)this + 76);
              fStack_134 = fStack_134 * *(float *)(this + 10);
              local_130 = *(float *)(puVar9 + 1) * 0.0;
              goto LAB_181702203;
            }
            local_130 = 0.0;
          }
        LAB_181702203:
          if (this[18] == 0) goto LAB_1817026b8;
          local_128 = CONCAT44(fStack_134,local_138);
          local_120 = local_130;
          puVar9 = (uint64 *)Transform.TransformDirection(&local_f8,this[18],&local_128,0);
          fVar16 = (float)*puVar9;
          fVar20 = (float)((uint64)*puVar9 >> 32);
          fVar13 = *(float *)(puVar9 + 1);
        }
        if (*(int *)((int64)this + 28) == 0) {
          plVar8 = (int64 *)Vector3.get_zero(&local_f8);
          lVar11 = plVar8[1];
          this[24] = *plVar8;
          *(int *)(this + 25) = (int)lVar11;
        }
        else {
          fVar19 = *(float *)((int64)this + 44) * 0.01;
          fVar15 = *(float *)(this + 25);
          local_128 = this[24];
          fVar17 = (float)local_128;
          fVar18 = (float)((uint64)local_128 >> 32);
          local_120 = fVar15;
          local_110 = fVar15;
          fVar14 = (float)Mathf.Clamp01(0x3f2b851f);
          local_110 = ((fVar13 * fVar19 + local_120) - fVar15) * fVar14 + fVar15;
          this[24] =
               CONCAT44(((fVar20 * fVar19 + fVar18) - fVar18) * fVar14 + fVar18,
                        ((fVar16 * fVar19 + fVar17) - fVar17) * fVar14 + fVar17);
          *(float *)(this + 25) = local_110;
        }
        if ((*(char *)((int64)this + 36) == false) || (*(int *)((int64)this + 28) != 2)) {
        LAB_1817025c4:
          local_128 = CONCAT44(fVar20,fVar16);
          local_120 = fVar13;
          UIScrollView.MoveAbsolute(this,&local_128,0);
        }
        else {
          plVar8 = (int64 *)this[19];
          puVar9 = (uint64 *)
                   (**(code **)(*this + 0x178))(&local_f8,this,*(uint64 *)(*this + 0x180));
          local_d8 = *puVar9;
          uStack_d0 = puVar9[1];
          local_c8 = puVar9[2];
          puVar9 = (uint64 *)Bounds.get_min(&local_f8,&local_d8,0);
          uVar6 = *puVar9;
          local_110 = *(float *)(puVar9 + 1);
          puVar9 = (uint64 *)
                   (**(code **)(*this + 0x178))(&local_f8,this,*(uint64 *)(*this + 0x180));
          local_d8 = *puVar9;
          uStack_d0 = puVar9[1];
          local_c8 = puVar9[2];
          puVar9 = (uint64 *)Bounds.get_max(&local_f8,&local_d8,0);
          local_110 = *(float *)(puVar9 + 1);
          if (plVar8 == (int64 *)0) goto LAB_1817026b8;
          puVar10 = (uint64 *)
                    (**(code **)(*plVar8 + 0x2a8))
                              (&local_f8,plVar8,uVar6,*puVar9,*(uint64 *)(*plVar8 + 0x2b0));
          local_108 = *puVar10;
          local_100 = (uint32)puVar10[1];
          iVar5 = (int)this[3];
          local_138 = (float)local_108;
          fStack_134 = (float)(local_108 >> 32);
          if (iVar5 == 0) {
            local_108 = local_108 & 0xffffffff;
          }
          else if (iVar5 == 1) {
            local_108 = (uint64)(uint32)fStack_134 << 32;
          }
          else if (iVar5 == 3) {
            local_108 = CONCAT44(fStack_134 * *(float *)(this + 10),
                                 local_138 * *(float *)((int64)this + 76));
          }
          fVar15 = (float)Vector3.get_magnitude(&local_108,0);
          if (fVar15 <= 1.0) goto LAB_1817025c4;
          local_120 = fVar13 * 0.5;
          local_128 = CONCAT44(fVar20 * 0.5,fVar16 * 0.5);
          local_110 = local_120;
          UIScrollView.MoveAbsolute(this,&local_128,0);
          local_120 = *(float *)(this + 25);
          local_110 = local_120 * 0.5;
          this[24] = CONCAT44(*(float *)((int64)this + 196) * 0.5,(float)this[24] * 0.5);
          *(float *)(this + 25) = local_110;
        }
        if (*(char *)((int64)this + 33) == false) {
          return;
        }
        if ((char)this[4] == false) {
          return;
        }
        if (this[19] == 0) {
        LAB_1817026b8:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (*(int *)(this[19] + 0x134) == 0) {
          return;
        }
        if (*(int *)((int64)this + 28) == 2) {
          return;
        }
        uVar2 = *(uint32 *)(this + 3);
        if ((uVar2 & 0xfffffffd) == 0) {
          uVar6 = 1;
        LAB_18170261f:
          if (uVar2 - 1 < 2) goto LAB_181702653;
          if (uVar2 == 3) goto LAB_181702646;
        }
        else {
          if (uVar2 != 3) {
            uVar6 = 0;
            goto LAB_18170261f;
          }
          if (*(float *)((int64)this + 76) == 0.0) {
            uVar6 = 0;
          }
          else {
            uVar6 = 1;
          }
        LAB_181702646:
          if (*(float *)(this + 10) != 0.0) {
        LAB_181702653:
            uVar12 = 1;
            goto LAB_181702656;
          }
        }
        uVar12 = 0;
        LAB_181702656:
        UIScrollView.RestrictWithinBounds(this,1,uVar6,uVar12,0);
    }

    // Token : 0x600026D
    // RVA   : 0x1703DA0   Offset: 0x17031A0   Length: 0x125
    public void Scroll(float delta)
    {
        bool cVar1;
        bool cVar2;
        ulong uVar3;
        float fVar4;
        float fVar5;
        float fVar6;
        cVar1 = Behaviour.get_enabled(this,0);
        if (cVar1) {
          uVar3 = Component.get_gameObject(this,0);
          cVar1 = NGUITools.GetActive(uVar3,0);
          if ((cVar1) && (fVar6 = 0.0, *(float *)(this + 5) != 0.0)) {
            UIScrollView.DisableSpring(this,0);
            cVar1 = *(char *)((int64)this + 233);
            cVar2 = (**(code **)(*this + 0x1a8))(this,*(uint64 *)(*this + 0x1b0));
            *(bool *)((int64)this + 233) = cVar2 || cVar1;
            fVar4 = (float)Mathf.Sign(*(uint32 *)((int64)this + 204),0);
            fVar5 = (float)Mathf.Sign(delta,0);
            if (fVar4 == fVar5) {
              fVar6 = *(float *)((int64)this + 204);
            }
            *(float *)((int64)this + 204) = delta * *(float *)(this + 5) + fVar6;
          }
        }
    }

    // Token : 0x600026E
    // RVA   : 0x17026D0   Offset: 0x1701AD0   Length: 0x6A9
    private void LateUpdate()
    {
        int iVar2;
        uint uVar3;
        long lVar4;
        bool cVar5;
        bool cVar6;
        bool cVar7;
        long lVar9;
        float fVar12;
        float fVar13;
        uint uVar14;
        ulong uVar15;
        float fVar16;
        float local_68;
        float fStack_64;
        float local_60;
        float local_58;
        float fStack_54;
        float local_50;
        byte[] local_48 = new byte[8];
        float local_40;
        byte[] local_38 = new byte[48];
        cVar5 = Application.get_isPlaying(0);
        if (!cVar5) {
          return;
        }
        fVar12 = (float)RealTime.get_deltaTime(0);
        if ((int)this[9] != 0) {
          lVar9 = this[8];
          cVar5 = Object.op_Implicit(lVar9,0);
          if (!cVar5) {
            lVar9 = this[7];
            cVar5 = Object.op_Implicit(lVar9,0);
            if (!cVar5) goto LAB_18170296a;
          }
          cVar5 = false;
          cVar6 = false;
          if ((((int)this[9] != 2) || (*(int *)((int64)this + 236) != -10)) ||
             (fVar13 = (float)Vector3.get_magnitude(this + 24,0), 0.01 < fVar13)) {
            cVar5 = (**(code **)(*this + 0x198))(this,*(uint64 *)(*this + 0x1a0));
            cVar6 = (**(code **)(*this + 0x188))(this,*(uint64 *)(*this + 400));
          }
          lVar9 = this[8];
          cVar7 = Object.op_Implicit(lVar9,0);
          if (cVar7) {
            if (this[8] == 0) goto LAB_181702d74;
            fVar13 = (float)UIProgressBar.get_alpha(this[8],0);
            if (!cVar5) {
              fVar16 = -fVar12 * 3.0;
            }
            else {
              fVar16 = fVar12 * 6.0;
            }
            uVar15 = Mathf.Clamp01(fVar13 + fVar16,0);
            if (this[8] == 0) goto LAB_181702d74;
            fVar13 = (float)UIProgressBar.get_alpha(this[8],0);
            if (fVar13 != (float)uVar15) {
              if (this[8] == 0) goto LAB_181702d74;
              UIProgressBar.set_alpha(this[8],uVar15,0);
            }
          }
          lVar9 = this[7];
          cVar5 = Object.op_Implicit(lVar9,0);
          if (cVar5) {
            if (this[7] == 0) goto LAB_181702d74;
            fVar13 = (float)UIProgressBar.get_alpha(this[7],0);
            if (!cVar6) {
              fVar16 = -fVar12 * 3.0;
            }
            else {
              fVar16 = fVar12 * 6.0;
            }
            uVar15 = Mathf.Clamp01(fVar13 + fVar16,0);
            if (this[7] == 0) goto LAB_181702d74;
            fVar13 = (float)UIProgressBar.get_alpha(this[7],0);
            if (fVar13 != (float)uVar15) {
              if (this[7] == 0) goto LAB_181702d74;
              UIProgressBar.set_alpha(this[7],uVar15,0);
            }
          }
        }
        LAB_18170296a:
        if (*(char *)((int64)this + 233) == false) {
          return;
        }
        plVar1 = this + 24;
        if (*(char *)((int64)this + 188) != false) {
          *(uint32 *)((int64)this + 204) = 0;
          NGUIMath.SpringDampen(local_48,plVar1,0x41100000,fVar12,0);
          return;
        }
        fVar13 = (float)Vector3.get_magnitude(plVar1,0);
        if ((fVar13 <= 0.0001) && (ABS(*(float *)((int64)this + 204)) <= 0.0001)) {
          *(uint32 *)((int64)this + 204) = 0;
          plVar8 = (int64 *)Vector3.get_zero(local_48,0);
          *plVar1 = *plVar8;
          *(int *)(this + 25) = (int)plVar8[1];
          lVar9 = Component.GetComponent(this,DAT_181d95ce0);
          cVar5 = Object.op_Inequality(lVar9,0,0);
          if (cVar5) {
            if (lVar9 == null) goto LAB_181702d74;
            cVar5 = Behaviour.get_enabled(lVar9,0);
            if (cVar5) {
              return;
            }
          }
          lVar9 = this[14];
          *(uint8 *)((int64)this + 233) = 0;
          goto LAB_181702d5f;
        }
        iVar2 = (int)this[3];
        lVar4 = this[18];
        fVar13 = *(float *)((int64)this + 204);
        lVar9 = *plVar1;
        if (iVar2 == 0) {
          local_60 = *(float *)(this + 25);
          if (lVar4 == null) goto LAB_181702d74;
          fStack_54 = 0.0;
          fVar16 = fStack_54;
        LAB_181702b72:
          fStack_54 = fVar16;
          fVar16 = fVar13 * 0.05;
          fVar13 = fStack_54;
        }
        else if (iVar2 == 1) {
          local_60 = *(float *)(this + 25);
          if (lVar4 == null) goto LAB_181702d74;
          local_58 = 0.0;
          fVar16 = local_58;
          fVar13 = fVar13 * 0.05;
        }
        else {
          local_60 = *(float *)(this + 25);
          if (iVar2 == 2) {
            fVar16 = fVar13 * 0.05;
            if (lVar4 == null) goto LAB_181702d74;
            goto LAB_181702b72;
          }
          fVar16 = fVar13 * *(float *)((int64)this + 76) * 0.05;
          fVar13 = fVar13 * *(float *)(this + 10) * 0.05;
          if (lVar4 == null) goto LAB_181702d74;
        }
        fStack_54 = fVar13;
        local_58 = fVar16;
        local_50 = 0.0;
        uVar15 = 0;
        puVar10 = (uint64 *)Transform.TransformDirection(local_38,lVar4,&local_58,0);
        local_68 = (float)lVar9;
        local_50 = *(float *)(puVar10 + 1);
        local_58 = (float)*puVar10;
        fStack_54 = (float)((uint64)*puVar10 >> 32);
        fStack_64 = (float)((uint64)lVar9 >> 32);
        local_40 = local_60 - local_50;
        *plVar1 = CONCAT44(fStack_64 - fStack_54,local_68 - local_58);
        *(float *)(this + 25) = local_40;
        uVar14 = NGUIMath.SpringLerp(*(uint32 *)((int64)this + 204),0,0x41a00000,fVar12,0);
        *(uint32 *)((int64)this + 204) = uVar14;
        puVar10 = (uint64 *)NGUIMath.SpringDampen(local_38,plVar1,(int)this[6],fVar12,0);
        local_50 = *(float *)(puVar10 + 1);
        local_58 = (float)*puVar10;
        fStack_54 = (float)((uint64)*puVar10 >> 32);
        UIScrollView.MoveAbsolute(this,&local_58,0);
        if ((char)this[4] == false) goto LAB_181702d5b;
        if (this[19] == 0) {
        LAB_181702d74:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (*(int *)(this[19] + 0x134) != 0) {
          lVar9 = this[32];
          cVar5 = NGUITools.GetActive(lVar9,0);
          if (!cVar5) {
            uVar3 = *(uint32 *)(this + 3);
            uVar11 = (uint7)((uint64)uVar15 >> 8);
            if ((uVar3 & 0xfffffffd) == 0) {
              uVar15 = 1;
        LAB_181702caf:
              if (1 < uVar3 - 1) {
                if (uVar3 != 3) {
                  UIScrollView.RestrictWithinBounds(this,0,uVar15,(uint64)uVar11 << 8,0);
                  goto LAB_181702d5b;
                }
                goto LAB_181702ce7;
              }
            }
            else {
              if (uVar3 != 3) {
                uVar15 = 0;
                goto LAB_181702caf;
              }
              if (*(float *)((int64)this + 76) == 0.0) {
                uVar15 = 0;
              }
              else {
                uVar15 = 1;
              }
        LAB_181702ce7:
              if (*(float *)(this + 10) == 0.0) {
                UIScrollView.RestrictWithinBounds(this,0,uVar15,(uint64)uVar11 << 8,0);
                goto LAB_181702d5b;
              }
            }
            UIScrollView.RestrictWithinBounds(this,0,uVar15,CONCAT71(uVar11,1),0);
          }
          else {
            lVar9 = this[32];
            if (lVar9 == null) goto LAB_181702d74;
            if (*(float *)(lVar9 + 28) == 0.0) {
              UICenterOnChild.Recenter(lVar9,0);
            }
            else {
              plVar8 = (int64 *)Vector3.get_zero(local_38,0);
              *plVar1 = *plVar8;
              *(int *)(this + 25) = (int)plVar8[1];
              *(uint32 *)((int64)this + 204) = 0;
            }
          }
        }
        LAB_181702d5b:
        lVar9 = this[13];
        LAB_181702d5f:
        if (lVar9 != null) {
          OnGeometryUpdated.Invoke(lVar9,0);
        }
    }

    // Token : 0x600026F
    // RVA   : 0x17030F0   Offset: 0x17024F0   Length: 0x1B2
    public void OnPan(Vector2 delta)
    {
        uint uVar1;
        ulong uVar2;
        bool cVar4;
        uint local_28;
        uint uStack_24;
        uVar2 = this.horizontalScrollBar;
        cVar4 = Object.op_Inequality(uVar2,0,0);
        if (cVar4) {
          plVar3 = this.horizontalScrollBar;
          if (plVar3 != (int64 *)0)
          {
            (**(code **)(*plVar3 + 0x1b8))(plVar3,delta,*(uint64 *)(*plVar3 + 0x1c0));
            }
            uVar2 = this.verticalScrollBar;
            cVar4 = Object.op_Inequality(uVar2,0,0);
            if (cVar4) {
            plVar3 = this.verticalScrollBar;
            if (plVar3 == (int64 *)0) {
          }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          (**(code **)(*plVar3 + 0x1b8))(plVar3,delta,*(uint64 *)(*plVar3 + 0x1c0));
        }
        uVar2 = this.horizontalScrollBar;
        cVar4 = Object.op_Equality(uVar2,0,0);
        if (!cVar4) {
          return;
        }
        uVar2 = this.verticalScrollBar;
        cVar4 = Object.op_Equality(uVar2,0,0);
        if (!cVar4) {
          return;
        }
        uVar1 = this.movement;
        if ((uVar1 & 0xfffffffd) != 0) {
          uStack_24 = (uint32)((uint64)delta >> 32);
          local_28 = uStack_24;
          if (uVar1 != 3) {
            if (uVar1 != 1) {
              return;
            }
            goto LAB_181703282;
          }
          if (this.customMovement == null.0) {
            if (*(float *)(this + 80) == 0.0) {
              return;
            }
            goto LAB_181703282;
          }
        }
        local_28 = (uint32)delta;
        LAB_181703282:
        UIScrollView.Scroll(this,local_28,0);
    }

    // Token : 0x6000270
    // RVA   : 0x1704E00   Offset: 0x1704200   Length: 0xED
    public void /*ctor*/()
    {
        ulong uVar1;
        uint local_res8;
        uint32 uStackX_c;
        uint8 local_18 [8];
        uint32 local_10;
        this.scale = 0x3f800000;
        this.dragEffect = 2;
        this.restrictWithinPanel = 1;
        this.smoothDragStart = 0x101;
        this.scrollWheelFactor = 0x3e800000;
        this.momentumAmount = 0x420c0000;
        this.dampenStrength = 0x41100000;
        this.showScrollBars = 1;
        this.customMovement = 0x3f800000;
        local_10 = 0;
        *(uint32 *)(this + 128) = 0;
        uVar1 = Vector2.get_zero(0);
        local_res8 = (uint32)uVar1;
        uStackX_c = (uint32)((uint64)uVar1 >> 32);
        this.relativePositionOnReset = local_res8;
        *(uint32 *)(this + 136) = uStackX_c;
        puVar2 = (uint64 *)Vector3.get_zero(local_18,0);
        this.mMomentum = *puVar2;
        *(uint32 *)(this + 200) = *(uint32 *)(puVar2 + 1);
        this.mDragID = 0xfffffff6;
        uVar1 = Vector2.get_zero(0);
        local_res8 = (uint32)uVar1;
        uStackX_c = (uint32)((uint64)uVar1 >> 32);
        this.mDragStartOffset = local_res8;
        *(uint32 *)(this + 244) = uStackX_c;
        FUN_18044ef50(this,0);
    }

    // Token : 0x6000271
    // RVA   : 0x1704D80   Offset: 0x1704180   Length: 0x76
    private static void /*cctor*/()
    {
        ulong uVar2;
        uVar2 = new BetterList_1(DAT_181da70b8);
        puVar1 = *(uint64 **)(DAT_181db0278 + 184);
        *puVar1 = uVar2;
        il2cpp_internal(puVar1,uVar2);
    }

}
