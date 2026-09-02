// ============================================================
// Type  : UITooltip
// Token : 0x200011B
// ============================================================

public class UITooltip
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40006F9
    protected static UITooltip mInstance;

    // Token: 0x40006FA
    public Camera uiCamera;

    // Token: 0x40006FB
    public UILabel text;

    // Token: 0x40006FC
    public GameObject tooltipRoot;

    // Token: 0x40006FD
    public UISprite background;

    // Token: 0x40006FE
    public float appearSpeed;

    // Token: 0x40006FF
    public bool scalingTransitions;

    // Token: 0x4000700
    protected GameObject mTooltip;

    // Token: 0x4000701
    protected Transform mTrans;

    // Token: 0x4000702
    protected float mTarget;

    // Token: 0x4000703
    protected float mCurrent;

    // Token: 0x4000704
    protected Vector3 mPos;

    // Token: 0x4000705
    protected Vector3 mSize;

    // Token: 0x4000706
    protected UIWidget[] mWidgets;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600097E
    // RVA   : 0x169AF50   Offset: 0x1699750   Length: 0xA9
    public static bool get_isVisible()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = **(uint64 **)(DAT_181d8b358 + 184);
        uVar2 = Object.op_Inequality(uVar1,0,0);
        if ((char)uVar2) {
          uVar2 = **(uint64 **)(DAT_181d8b358 + 184);
          if (uVar2 == 0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (*(float *)(uVar2 + 80) == 1.0) {
            return CONCAT71((int7)(uVar2 >> 8),1);
          }
        }
        return uVar2 & 0xffffffffffffff00;
    }

    // Token : 0x600097F
    // RVA   : 0x169A080   Offset: 0x1698880   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181d8b358 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6000980
    // RVA   : 0x169A190   Offset: 0x1698990   Length: 0x40
    private void OnDestroy()
    {
        puVar1 = *(uint64 **)(DAT_181d8b358 + 184);
        *puVar1 = 0;
        il2cpp_internal(puVar1,0);
    }

    // Token : 0x6000981
    // RVA   : 0x169AA30   Offset: 0x1699230   Length: 0x157
    protected virtual void Start()
    {
        bool cVar1;
        uint uVar2;
        long lVar3;
        byte[] local_18 = new byte[16];
        lVar3 = Component.get_transform(this,0);
        this[9] = lVar3;
        il2cpp_internal(this + 9,lVar3);
        lVar3 = FUN_180956bf0(this,DAT_181d70140);
        this[14] = lVar3;
        il2cpp_internal(this + 14,lVar3);
        if (this[9] != 0) {
          plVar4 = (int64 *)Transform.get_localPosition(local_18,this[9],0);
          lVar3 = this[3];
          this[11] = *plVar4;
          *(int *)(this + 12) = (int)plVar4[1];
          cVar1 = Object.op_Equality(lVar3,0,0);
          if (cVar1) {
            lVar3 = Component.get_gameObject(this,0);
            if (lVar3 == null) throw; // [null/range check failed]
            uVar2 = GameObject.get_layer(lVar3,0);
            lVar3 = NGUITools.FindCameraForLayer(uVar2,0);
            this[3] = lVar3;
            il2cpp_internal(this + 3,lVar3);
          }
                          // WARNING: Could not recover jumptable at 0x00018169ab7b. Too many branches
                          // WARNING: Treating indirect jump as call
          (**(code **)(*this + 0x198))(this,0,*(uint64 *)(*this + 0x1a0));
          return;
        }
    }

    // Token : 0x6000982
    // RVA   : 0x169AB90   Offset: 0x1699390   Length: 0x370
    protected virtual void Update()
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        bool cVar4;
        float fVar6;
        float fVar7;
        float fVar8;
        float fVar9;
        float fVar10;
        float fVar11;
        float fVar12;
        long lVar13;
        long local_78;
        float local_70;
        byte[] local_58 = new byte[80];
        lVar1 = this[8];
        uVar2 = *(uint64 *)(*(int64 *)(DAT_181d8a458 + 184) + 0x1b0);
        cVar4 = Object.op_Inequality(lVar1,uVar2,0);
        if (!cVar4) {
          fVar8 = *(float *)(this + 10);
        }
        else {
          this[8] = 0;
          il2cpp_internal(this + 8,0);
          *(uint32 *)(this + 10) = 0;
          fVar8 = 0.0;
        }
        fVar7 = *(float *)((int64)this + 84);
        if (fVar7 != fVar8) {
          fVar6 = (float)RealTime.get_deltaTime(0);
          fVar7 = (float)Mathf.Lerp(fVar7,fVar8,*(float *)(this + 7) * fVar6,0);
          fVar8 = *(float *)(this + 10);
          *(float *)((int64)this + 84) = fVar7;
          if (ABS(fVar7 - fVar8) < 0.001) {
            *(float *)((int64)this + 84) = fVar8;
            fVar7 = fVar8;
          }
          (**(code **)(*this + 0x198))(this,fVar7 * fVar7,*(uint64 *)(*this + 0x1a0));
          if (*(char *)((int64)this + 60) != false) {
            local_78 = *(int64 *)((int64)this + 100);
            fVar9 = (float)local_78;
            uVar3 = (uint64)local_78 >> 32;
            local_70 = *(float *)((int64)this + 108);
            fVar8 = *(float *)((int64)this + 84);
            puVar5 = (uint64 *)Vector3.get_one(local_58,0);
            fVar6 = 1.5 - fVar8 * 0.5;
            fVar7 = *(float *)(puVar5 + 1) * fVar6;
            lVar13 = CONCAT44((float)((uint64)*puVar5 >> 32) * fVar6,(float)*puVar5 * fVar6);
            lVar1 = this[11];
            fVar12 = (float)((uint64)lVar1 >> 32);
            fVar8 = *(float *)(this + 12);
            fVar10 = fVar12 - -((float)uVar3 * 0.25);
            fVar11 = (float)lVar1 - fVar9 * 0.25;
            fVar9 = fVar8 - local_70 * 0.25;
            local_70 = fVar8;
            fVar8 = (float)Mathf.Clamp01(*(uint32 *)((int64)this + 84),0,lVar1,fVar6,lVar1,
                                          fVar8,lVar13,fVar7);
            local_78 = CONCAT44((fVar12 - fVar10) * fVar8 + fVar10,
                                ((float)lVar1 - fVar11) * fVar8 + fVar11);
            if (this[9] != 0) {
              local_70 = (local_70 - fVar9) * fVar8 + fVar9;
              Transform.set_localPosition(this[9],&local_78,0);
              lVar1 = local_78;
              if (this[9] != 0) {
                local_78 = lVar13;
                local_70 = fVar7;
                Transform.set_localScale(this[9],&local_78,0);
                return;
              }
            }
            local_78 = lVar1;
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
    }

    // Token : 0x6000983
    // RVA   : 0x169A1D0   Offset: 0x16989D0   Length: 0xA6
    protected virtual void SetAlpha(float val)
    {
        int iVar1;
        long lVar2;
        ulong uVar3;
        uint uVar4;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        uVar4 = 0;
        if (this.mWidgets != null) {
          iVar1 = *(int *)(this.mWidgets + 24);
          if (0 < iVar1) {
            do {
              lVar2 = this.mWidgets;
              if (lVar2 == null) throw; // [null/range check failed]
              if (*(uint32 *)(lVar2 + 24) <= uVar4) {
                uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar3,0);
              }
              lVar2 = lVar2[uVar4];
              if (lVar2 == null) throw; // [null/range check failed]
              local_28 = *(uint32 *)(lVar2 + 144);
              uStack_24 = *(uint32 *)(lVar2 + 148);
              uStack_20 = *(uint32 *)(lVar2 + 152);
              uStack_1c = val;
              UIWidget.set_color(lVar2,&local_28,0);
              uVar4 = uVar4 + 1;
            } while ((int)uVar4 < iVar1);
          }
          return;
        }
    }

    // Token : 0x6000984
    // RVA   : 0x169A280   Offset: 0x1698A80   Length: 0x64C
    protected virtual void SetText(string tooltipText)
    {
        float fVar1;
        bool cVar3;
        uint uVar4;
        int iVar5;
        ulong uVar6;
        long lVar7;
        ulong uVar9;
        float fVar11;
        float fVar12;
        float fVar13;
        float local_68;
        float fStack_64;
        ulong local_58;
        uint local_50;
        ulong local_48;
        uint local_40;
        uVar6 = this.text;
        cVar3 = Object.op_Inequality(uVar6,0,0);
        if ((!cVar3) || (cVar3 = FUN_180d6ca90(tooltipText,0), cVar3)) {
          this.mTooltip = 0;
          this.mTarget = 0;
          return;
        }
        this.mTarget = 0x3f800000;
        uVar6 = FUN_181688740(0);
        this.mTooltip = uVar6;
        if (this.text != null) {
          UILabel.set_text(this.text,tooltipText,0);
          uVar6 = UICamera.get_lastEventPosition(0);
          local_50 = 0;
          this.mPos = uVar6;
          *(uint32 *)(this + 96) = 0;
          if ((this.text != null) &&
             (lVar7 = Component.get_transform(this.text,0)) != null) {
            puVar8 = (uint64 *)Transform.get_localPosition(&local_48,lVar7,0);
            local_50 = *(uint32 *)(puVar8 + 1);
            local_58 = *puVar8;
            puVar8 = (uint64 *)Transform.get_localScale(&local_48,lVar7,0);
            uVar6 = *puVar8;
            if (this.text != null) {
              uVar9 = UILabel.get_printedSize(this.text,0);
              local_40 = 0;
              *(uint64 *)(this + 100) = uVar9;
              local_68 = (float)uVar6;
              *(uint32 *)(this + 108) = 0;
              *(float *)(this + 100) = local_68 * *(float *)(this + 100);
              fStack_64 = (float)((uint64)uVar6 >> 32);
              *(float *)(this + 104) = fStack_64 * *(float *)(this + 104);
              uVar6 = this.background;
              cVar3 = Object.op_Inequality(uVar6,0,0);
              if (cVar3) {
                plVar2 = this.background;
                if (plVar2 == (int64 *)0) throw; // [null/range check failed]
                pfVar10 = (float *)(**(code **)(*plVar2 + 0x378))
                                             (&local_48,plVar2,*(uint64 *)(*plVar2 + 0x380));
                fVar13 = pfVar10[1];
                fVar1 = pfVar10[3];
                fVar12 = (float)local_58 - *pfVar10;
                fVar11 = -local_58._4_4_ - fVar13;
                *(float *)(this + 100) =
                     fVar12 + fVar12 + pfVar10[2] + *pfVar10 + *(float *)(this + 100);
                *(float *)(this + 104) = fVar11 + fVar11 + fVar13 + fVar1 + *(float *)(this + 104)
                ;
                lVar7 = this.background;
                uVar4 = Mathf.RoundToInt();
                if (lVar7 == null) throw; // [null/range check failed]
                UIWidget.set_width(lVar7,uVar4,0);
                lVar7 = this.background;
                uVar4 = Mathf.RoundToInt();
                if (lVar7 == null) throw; // [null/range check failed]
                UIWidget.set_height(lVar7,uVar4,0);
              }
              uVar6 = this.uiCamera;
              cVar3 = Object.op_Inequality(uVar6,0,0);
              fVar13 = this.mPos;
              if (!cVar3) {
                fVar1 = *(float *)(this + 100);
                iVar5 = Screen.get_width();
                if ((float)iVar5 < fVar1 + fVar13) {
                  iVar5 = Screen.get_width(0);
                  this.mPos = (float)iVar5 - *(float *)(this + 100);
                }
                if (*(float *)(this + 92) - *(float *)(this + 104) < 0.0) {
                  *(float *)(this + 92) = *(float *)(this + 104);
                }
                fVar13 = this.mPos;
                iVar5 = Screen.get_width(0);
                this.mPos = fVar13 - (float)iVar5 * 0.5;
                fVar13 = *(float *)(this + 92);
                iVar5 = Screen.get_height(0);
                fVar13 = fVar13 - (float)iVar5 * 0.5;
              }
              else {
                Screen.get_width(0);
                uVar4 = Mathf.Clamp01();
                this.mPos = uVar4;
                Screen.get_height(0);
                uVar4 = Mathf.Clamp01();
                *(uint32 *)(this + 92) = uVar4;
                if (this.uiCamera == null) throw; // [null/range check failed]
                Camera.get_orthographicSize(this.uiCamera,0);
                if ((this.mTrans == null) ||
                   (lVar7 = FUN_180da0f00(this.mTrans,0)) == null)
                throw; // [null/range check failed]
                puVar8 = (uint64 *)Transform.get_lossyScale(&local_48,lVar7,0);
                uVar6 = *puVar8;
                local_40 = *(uint32 *)(puVar8 + 1);
                Screen.get_height(0);
                local_48 = uVar6;
                Screen.get_width(0);
                Screen.get_height(0);
                uVar4 = Mathf.Min();
                this.mPos = uVar4;
                uVar4 = Mathf.Max();
                *(uint32 *)(this + 92) = uVar4;
                lVar7 = this.mTrans;
                if (this.uiCamera == null) throw; // [null/range check failed]
                local_58 = this.mPos;
                local_50 = *(uint32 *)(this + 96);
                puVar8 = (uint64 *)
                         Camera.ViewportToWorldPoint(&local_48,this.uiCamera,&local_58,0)
                ;
                if (lVar7 == null) throw; // [null/range check failed]
                local_58 = *puVar8;
                local_50 = *(uint32 *)(puVar8 + 1);
                Transform.set_position(lVar7,&local_58,0);
                if (this.mTrans == null) throw; // [null/range check failed]
                puVar8 = (uint64 *)
                         Transform.get_localPosition(&local_48,this.mTrans,0);
                this.mPos = *puVar8;
                *(uint32 *)(this + 96) = *(uint32 *)(puVar8 + 1);
                uVar4 = FUN_18000d7c0();
                this.mPos = uVar4;
                fVar13 = (float)FUN_18000d7c0();
              }
              *(float *)(this + 92) = fVar13;
              if (this.mTrans != null) {
                local_58 = this.mPos;
                local_50 = *(uint32 *)(this + 96);
                Transform.set_localPosition(this.mTrans,&local_58,0);
                uVar6 = this.tooltipRoot;
                cVar3 = Object.op_Inequality(uVar6,0,0);
                if (!cVar3) {
                  if (this.text != null) {
                    Component.BroadcastMessage(this.text,"UpdateAnchors",0);
                    return;
                  }
                }
                else if (this.tooltipRoot != null) {
                  GameObject.BroadcastMessage(this.tooltipRoot,"UpdateAnchors",0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000985
    // RVA   : 0x169A8D0   Offset: 0x16990D0   Length: 0xAE
    public static void ShowText(string text)
    {
        ulong uVar1;
        bool cVar3;
        uVar1 = **(uint64 **)(DAT_181d8b358 + 184);
        cVar3 = Object.op_Inequality(uVar1,0,0);
        if (cVar3) {
          plVar2 = (int64 *)**(int64 **)(DAT_181d8b358 + 184);
          if (plVar2 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          (**(code **)(*plVar2 + 0x1a8))(plVar2,text,*(uint64 *)(*plVar2 + 0x1b0));
        }
    }

    // Token : 0x6000986
    // RVA   : 0x169A980   Offset: 0x1699180   Length: 0xAE
    public static void Show(string text)
    {
        ulong uVar1;
        bool cVar3;
        uVar1 = **(uint64 **)(DAT_181d8b358 + 184);
        cVar3 = Object.op_Inequality(uVar1,0,0);
        if (cVar3) {
          plVar2 = (int64 *)**(int64 **)(DAT_181d8b358 + 184);
          if (plVar2 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          (**(code **)(*plVar2 + 0x1a8))(plVar2,text,*(uint64 *)(*plVar2 + 0x1b0));
        }
    }

    // Token : 0x6000987
    // RVA   : 0x169A0D0   Offset: 0x16988D0   Length: 0xB8
    public static void Hide()
    {
        var pStatics = *(int64*)(DAT_181d8b358 + 184);
        ulong uVar1;
        bool cVar2;
        uVar1 = **(uint64 **)(DAT_181d8b358 + 184);
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (!cVar2) {
          return;
        }
        if (*pStatics != 0) {
          puVar3 = (uint64 *)(*pStatics + 64);
          *puVar3 = 0;
          il2cpp_internal(puVar3,0);
          if (*pStatics != 0) {
            *(uint32 *)(*pStatics + 80) = 0;
            return;
          }
        }
    }

    // Token : 0x6000988
    // RVA   : 0x169AF10   Offset: 0x1699710   Length: 0x3E
    public void /*ctor*/()
    {
        byte[] local_18 = new byte[16];
        this.appearSpeed = 0x41200000;
        this.scalingTransitions = 1;
        puVar1 = (uint64 *)Vector3.get_zero(local_18,0);
        *(uint64 *)(this + 100) = *puVar1;
        *(uint32 *)(this + 108) = *(uint32 *)(puVar1 + 1);
        FUN_18044ef50(this,0);
    }

}
