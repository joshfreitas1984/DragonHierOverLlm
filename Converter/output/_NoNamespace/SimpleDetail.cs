// ============================================================
// Type  : SimpleDetail
// Token : 0x2000350
// ============================================================

public class SimpleDetail
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001A87
    public GameObject Text;

    // Token: 0x4001A88
    public GameObject Back;

    // Token: 0x4001A89
    private GameObject nowShowObject;

    // Token: 0x4001A8A
    private string nowShowText;

    // Token: 0x4001A8B
    public GameObject canvasRoot;

    // Token: 0x4001A8C
    public float refreshTimeLeft;

    // Token: 0x4001A8D
    private static SimpleDetail _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002094
    // RVA   : 0x96FA40   Offset: 0x96E240   Length: 0x36
    public static SimpleDetail get_Instance()
    {
        return **(uint64 **)(DAT_181d7cfb8 + 184);
    }

    // Token : 0x6002095
    // RVA   : 0x96E000   Offset: 0x96C800   Length: 0xD7
    private void Awake()
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = **(uint64 **)(DAT_181d7cfb8 + 184);
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (!cVar2) {
          uVar3 = Component.get_gameObject(this,0);
          Object.Destroy(uVar3,0);
          return;
        }
        puVar1 = *(uint64 **)(DAT_181d7cfb8 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6002096
    // RVA   : 0x96EE90   Offset: 0x96D690   Length: 0x47
    private void Start()
    {
        ulong uVar1;
        uVar1 = GameObject.FindGameObjectWithTag("UICanvas",0);
        this.canvasRoot = uVar1;
    }

    // Token : 0x6002097
    // RVA   : 0x96EEE0   Offset: 0x96D6E0   Length: 0xB51
    private void Update()
    {
        var pStatics = *(int64*)(DAT_181d66570 + 184);
        bool cVar1;
        long lVar2;
        ulong uVar4;
        ulong uVar5;
        ulong uVar6;
        float fVar7;
        float fVar8;
        ulong local_38;
        uint local_30;
        byte[] local_28 = new byte[32];
        uVar4 = this.nowShowObject;
        cVar1 = Object.op_Inequality(uVar4,0,0);
        if (cVar1) {
          fVar8 = this.refreshTimeLeft;
          fVar7 = (float)RealTime.get_deltaTime(0);
          fVar8 = fVar8 - fVar7;
          this.refreshTimeLeft = fVar8;
          if (fVar8 <= 0.0) {
            this.refreshTimeLeft = fVar8 + 0.01;
            lVar2 = Component.get_transform(this,0);
            puVar3 = (uint64 *)Vector3.get_one(local_28,0);
            if (lVar2 == null) goto LAB_18096fa2c;
            local_30 = *(uint32 *)(puVar3 + 1);
            local_38 = *puVar3;
            Transform.set_localScale(lVar2,&local_38,0);
            SimpleDetail.RefreshPosition(this,0);
          }
        }
        uVar4 = *(uint64 *)(pStatics + 72);
        cVar1 = Object.op_Inequality(uVar4,0,0);
        if (!cVar1) {
          uVar4 = MouseController.get_hoveredObject(0);
          cVar1 = Object.op_Inequality(uVar4,0,0);
          if (!cVar1) {
            SimpleDetail.DisableDescribe(this,0);
            return;
          }
        }
        uVar4 = this.nowShowObject;
        uVar5 = *(uint64 *)(pStatics + 72);
        cVar1 = Object.op_Inequality(uVar5,0,0);
        if (!cVar1) {
        LAB_18096f2e9:
          uVar5 = *(uint64 *)(pStatics + 72);
          cVar1 = Object.op_Inequality(uVar5,0,0);
          if (!cVar1) {
        LAB_18096f4fc:
            uVar5 = MouseController.get_hoveredObject(0);
            cVar1 = Object.op_Inequality(uVar5,0,0);
            if (cVar1) {
              lVar2 = MouseController.get_hoveredObject(0);
              if (lVar2 == null) goto LAB_18096fa2c;
              uVar5 = GameObject.GetComponent(lVar2,DAT_181da12b0);
              cVar1 = Object.op_Inequality(uVar5,0,0);
              if (cVar1) {
                lVar2 = MouseController.get_hoveredObject(0);
                if ((lVar2 == null) || (lVar2 = GameObject.GetComponent(lVar2,DAT_181da12b0)) == null)
                goto LAB_18096fa2c;
                if (*(int64 *)(lVar2 + 24) != 0) {
                  lVar2 = MouseController.get_hoveredObject(0);
                  if ((lVar2 == null) || (lVar2 = GameObject.GetComponent(lVar2,DAT_181da12b0)) == null)
                  goto LAB_18096fa2c;
                  cVar1 = String.op_Inequality(*(uint64 *)(lVar2 + 24),"",0);
                  if (cVar1) {
                    uVar5 = MouseController.get_hoveredObject(0);
                    lVar2 = *(int64 *)(*(int64 *)(DAT_181d87338 + 184) + 16);
                    if (lVar2 == null) goto LAB_18096fa2c;
                    uVar6 = *(uint64 *)(lVar2 + 56);
                    cVar1 = Object.op_Inequality(uVar5,uVar6,0);
                    if (cVar1) {
                      uVar5 = MouseController.get_hoveredObject(0);
                      this.nowShowObject = uVar5;
                      goto LAB_18096f784;
                    }
                  }
                }
              }
            }
            uVar5 = 0;
            this.nowShowObject = 0;
          }
          else {
            lVar2 = *(int64 *)(pStatics + 72);
            if (lVar2 == null) goto LAB_18096fa2c;
            uVar5 = GameObject.GetComponent(lVar2,DAT_181da1fb0);
            cVar1 = Object.op_Inequality(uVar5,0,0);
            if (!cVar1) goto LAB_18096f4fc;
            lVar2 = *(int64 *)(pStatics + 72);
            if ((lVar2 == null) || (lVar2 = GameObject.GetComponent(lVar2,DAT_181da1fb0)) == null)
            goto LAB_18096fa2c;
            if (*(int64 *)(lVar2 + 24) == 0) goto LAB_18096f4fc;
            lVar2 = *(int64 *)(pStatics + 72);
            if ((lVar2 == null) || (lVar2 = GameObject.GetComponent(lVar2,DAT_181da1fb0)) == null)
            goto LAB_18096fa2c;
            cVar1 = String.op_Inequality(*(uint64 *)(lVar2 + 24),"",0);
            if (!cVar1) goto LAB_18096f4fc;
            this.nowShowObject = *(uint64 *)(pStatics + 72);
            if ((this.nowShowObject == null) ||
               (lVar2 = GameObject.GetComponent(this.nowShowObject,DAT_181da1fb0)) == null
               ) goto LAB_18096fa2c;
            uVar5 = *(uint64 *)(lVar2 + 32);
          }
        }
        else {
          lVar2 = *(int64 *)(pStatics + 72);
          if (lVar2 == null) goto LAB_18096fa2c;
          uVar5 = GameObject.GetComponent(lVar2,DAT_181da12b0);
          cVar1 = Object.op_Inequality(uVar5,0,0);
          if (!cVar1) goto LAB_18096f2e9;
          lVar2 = *(int64 *)(pStatics + 72);
          if ((lVar2 == null) || (lVar2 = GameObject.GetComponent(lVar2,DAT_181da12b0)) == null)
          goto LAB_18096fa2c;
          if (*(int64 *)(lVar2 + 24) == 0) goto LAB_18096f2e9;
          lVar2 = *(int64 *)(pStatics + 72);
          if ((lVar2 == null) || (lVar2 = GameObject.GetComponent(lVar2,DAT_181da12b0)) == null)
          goto LAB_18096fa2c;
          cVar1 = String.op_Inequality(*(uint64 *)(lVar2 + 24),"",0);
          if (!cVar1) goto LAB_18096f2e9;
          uVar5 = *(uint64 *)(pStatics + 72);
          this.nowShowObject = uVar5;
        LAB_18096f784:
          il2cpp_internal(this + 40,uVar5);
          if ((this.nowShowObject == null) ||
             (lVar2 = GameObject.GetComponent(this.nowShowObject,DAT_181da12b0)) == null)
          goto LAB_18096fa2c;
          uVar5 = *(uint64 *)(lVar2 + 24);
        }
        this.nowShowText = uVar5;
        uVar5 = this.nowShowObject;
        cVar1 = Object.op_Inequality(uVar5,0,0);
        if (!cVar1) {
          SimpleDetail.DisableDescribe(this,0);
        }
        else {
          lVar2 = this.nowShowText;
          if (this.nowShowObject == null) goto LAB_18096fa2c;
          uVar5 = GameObject.GetComponent(this.nowShowObject,DAT_181da12b0);
          cVar1 = Object.op_Inequality(uVar5,0,0);
          if (!cVar1) {
            if (this.nowShowObject == null) goto LAB_18096fa2c;
            uVar5 = GameObject.GetComponent(this.nowShowObject,DAT_181da1fb0);
            cVar1 = Object.op_Inequality(uVar5,0,0);
            if (!cVar1) goto LAB_18096f956;
          }
          if ((this.Text == null) ||
             (uVar5 = GameObject.GetComponent(this.Text,DAT_181da1eb0), lVar2 == null))
          goto LAB_18096fa2c;
          uVar6 = String.Replace(lVar2,"\\n","\n",0);
          LTLocalization.SetText(uVar5,uVar6,0);
        }
        LAB_18096f956:
        uVar5 = this.nowShowObject;
        cVar1 = Object.op_Inequality(uVar5,uVar4,0);
        if (cVar1) {
          uVar4 = this.nowShowObject;
          cVar1 = Object.op_Inequality(uVar4,0,0);
          if (cVar1) {
            lVar2 = FUN_18046c100(0);
            if (lVar2 == null) {
        LAB_18096fa2c:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            uVar4 = *(uint64 *)(lVar2 + 0x1f0);
            NGUITools.PlaySound(uVar4,0x3dcccccd,0);
          }
        }
    }

    // Token : 0x6002098
    // RVA   : 0x96E1A0   Offset: 0x96C9A0   Length: 0xB87
    private void RefreshPosition()
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        long lVar4;
        float fVar8;
        uint uVar9;
        float fVar10;
        float fVar11;
        ulong local_98;
        float local_90;
        ulong local_88;
        float local_80;
        byte[] local_78 = new byte[16];
        ulong local_68;
        ulong uStack_60;
        local_68 = 0;
        uStack_60 = 0;
        if (this.nowShowObject == null) throw; // [null/range check failed]
        uVar2 = GameObject.GetComponent(this.nowShowObject,DAT_181da12b0);
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (!cVar1) {
          lVar3 = Component.get_transform(this,0);
          if ((this.nowShowObject == null) ||
             (lVar4 = GameObject.get_transform(this.nowShowObject,0)) == null)
          throw; // [null/range check failed]
          puVar5 = (uint64 *)Transform.get_position(&local_88,lVar4,0);
          local_98 = *puVar5;
          local_90 = *(float *)(puVar5 + 1);
          if ((this.Back == null) ||
             (lVar4 = GameObject.GetComponent(this.Back,DAT_181da0b98)) == null)
          throw; // [null/range check failed]
          puVar5 = (uint64 *)RectTransform.get_rect(local_78,lVar4,0);
          local_68 = *puVar5;
          uStack_60 = puVar5[1];
          fVar8 = (float)FUN_18044e2b0(&local_68,0);
          lVar4 = Component.get_transform(this,0);
          if (lVar4 == null) throw; // [null/range check failed]
          pfVar6 = (float *)Transform.get_lossyScale(&local_88,lVar4,0);
          fVar10 = (float)local_98 + 0.0;
          fVar11 = local_90 + 0.0;
          fVar8 = fVar8 * *pfVar6 * 0.5 + local_98._4_4_;
          if ((this.nowShowObject == null) ||
             (lVar4 = GameObject.GetComponent(this.nowShowObject,DAT_181da1fb0)) == null)
          throw; // [null/range check failed]
          local_98 = CONCAT44(fVar8 + *(float *)(lVar4 + 44),fVar10 + *(float *)(lVar4 + 40));
        LAB_18096e9d8:
          local_90 = fVar11 + 0.0;
          if (lVar3 == null) throw; // [null/range check failed]
          puVar5 = &local_88;
          local_88 = local_98;
        }
        else {
          fVar11 = 0.0;
          if (this.nowShowObject == null) throw; // [null/range check failed]
          uVar2 = GameObject.GetComponent(this.nowShowObject,DAT_181da0b98);
          cVar1 = Object.op_Inequality(uVar2,0,0);
          lVar3 = this.nowShowObject;
          if (!cVar1) {
            if (lVar3 == null) throw; // [null/range check failed]
            uVar2 = GameObject.GetComponent(lVar3,DAT_181d9eaa8);
            cVar1 = Object.op_Inequality(uVar2,0,0);
            lVar3 = this.nowShowObject;
            if (!cVar1) {
              if (lVar3 == null) throw; // [null/range check failed]
              uVar2 = GameObject.GetComponent(lVar3,DAT_181da1830);
              cVar1 = Object.op_Inequality(uVar2,0,0);
              if (cVar1) {
                if ((this.nowShowObject == null) ||
                   (lVar3 = GameObject.GetComponent(this.nowShowObject,DAT_181da1830),
                   lVar3 == null)) throw; // [null/range check failed]
                fVar11 = (float)SphereCollider.get_radius(lVar3,0);
                if ((this.nowShowObject == null) ||
                   (lVar3 = GameObject.get_transform(this.nowShowObject,0)) == null)
                throw; // [null/range check failed]
                puVar5 = (uint64 *)Transform.get_lossyScale(&local_88,lVar3,0);
                local_88 = *puVar5;
                local_80 = *(float *)(puVar5 + 1);
                fVar11 = (float)((uint64)local_88 >> 32) * fVar11;
              }
            }
            else {
              if ((lVar3 == null) || (lVar3 = GameObject.GetComponent(lVar3,DAT_181d9eaa8)) == null)
              throw; // [null/range check failed]
              puVar5 = (uint64 *)BoxCollider.get_size(&local_98,lVar3,0);
              local_88 = *puVar5;
              local_80 = *(float *)(puVar5 + 1);
              if ((this.nowShowObject == null) ||
                 (lVar3 = GameObject.get_transform(this.nowShowObject,0)) == null)
              throw; // [null/range check failed]
              puVar5 = (uint64 *)Transform.get_lossyScale(&local_98,lVar3,0);
              local_98 = *puVar5;
              local_90 = *(float *)(puVar5 + 1);
              fVar11 = local_88._4_4_ * (float)((uint64)local_98 >> 32);
            }
          }
          else {
            if ((lVar3 == null) || (lVar3 = GameObject.GetComponent(lVar3,DAT_181da0b98)) == null)
            throw; // [null/range check failed]
            puVar5 = (uint64 *)RectTransform.get_rect(local_78,lVar3,0);
            local_68 = *puVar5;
            uStack_60 = puVar5[1];
            fVar11 = (float)FUN_18044e2b0(&local_68,0);
            if ((this.nowShowObject == null) ||
               (lVar3 = GameObject.get_transform(this.nowShowObject,0)) == null)
            throw; // [null/range check failed]
            puVar5 = (uint64 *)Transform.get_lossyScale(&local_88,lVar3,0);
            local_88 = *puVar5;
            local_80 = *(float *)(puVar5 + 1);
            fVar11 = (float)((uint64)local_88 >> 32) * fVar11;
          }
          if ((this.nowShowObject == null) ||
             (lVar3 = GameObject.GetComponent(this.nowShowObject,DAT_181da12b0)) == null)
          throw; // [null/range check failed]
          if (*(char *)(lVar3 + 32) == false) {
            fVar8 = 0.0;
          }
          else {
            if ((this.nowShowObject == null) ||
               (lVar3 = GameObject.get_transform(this.nowShowObject,0)) == null)
            throw; // [null/range check failed]
            pfVar6 = (float *)Transform.get_position(&local_88,lVar3,0);
            lVar3 = this.Back;
            if (*pfVar6 <= 0.0) {
              if ((lVar3 == null) || (lVar3 = GameObject.GetComponent(lVar3,DAT_181da0b98)) == null)
              throw; // [null/range check failed]
              puVar5 = (uint64 *)RectTransform.get_rect(local_78,lVar3,0);
              local_68 = *puVar5;
              uStack_60 = puVar5[1];
              fVar8 = (float)FUN_180d90480(&local_68,0);
              fVar8 = fVar8 * 0.5;
            }
            else {
              if ((lVar3 == null) || (lVar3 = GameObject.GetComponent(lVar3,DAT_181da0b98)) == null)
              throw; // [null/range check failed]
              puVar5 = (uint64 *)RectTransform.get_rect(local_78,lVar3,0);
              local_68 = *puVar5;
              uStack_60 = puVar5[1];
              fVar8 = (float)FUN_180d90480(&local_68,0);
              fVar8 = fVar8 * -0.5;
            }
            lVar3 = Component.get_transform(this,0);
            if (lVar3 == null) throw; // [null/range check failed]
            pfVar6 = (float *)Transform.get_lossyScale(&local_88,lVar3,0);
            fVar8 = fVar8 * *pfVar6;
          }
          if ((this.nowShowObject == null) ||
             (lVar3 = GameObject.get_transform(this.nowShowObject,0)) == null)
          throw; // [null/range check failed]
          puVar5 = (uint64 *)Transform.get_position(&local_88,lVar3,0);
          local_88 = *puVar5;
          local_80 = *(float *)(puVar5 + 1);
          if ((float)((uint64)local_88 >> 32) < 0.0) {
        LAB_18096e8ef:
            lVar3 = Component.get_transform(this,0);
            if ((this.nowShowObject == null) ||
               (lVar4 = GameObject.get_transform(this.nowShowObject,0)) == null)
            throw; // [null/range check failed]
            puVar5 = (uint64 *)Transform.get_position(local_78,lVar4,0);
            local_88 = *puVar5;
            local_80 = *(float *)(puVar5 + 1);
            if ((this.Back == null) ||
               (lVar4 = GameObject.GetComponent(this.Back,DAT_181da0b98)) == null
               ) throw; // [null/range check failed]
            puVar5 = (uint64 *)RectTransform.get_rect(local_78,lVar4,0);
            local_68 = *puVar5;
            uStack_60 = puVar5[1];
            fVar10 = (float)FUN_18044e2b0(&local_68,0);
            lVar4 = Component.get_transform(this,0);
            if (lVar4 == null) throw; // [null/range check failed]
            pfVar6 = (float *)Transform.get_lossyScale(local_78,lVar4,0);
            local_98 = CONCAT44((fVar10 * *pfVar6 + fVar11) * 0.5 + local_88._4_4_,(float)local_88 + fVar8
                               );
            fVar11 = local_80;
            goto LAB_18096e9d8;
          }
          if ((this.nowShowObject == null) ||
             (lVar3 = GameObject.GetComponent(this.nowShowObject,DAT_181da12b0)) == null)
          throw; // [null/range check failed]
          if (*(char *)(lVar3 + 40) != false) goto LAB_18096e8ef;
          lVar3 = Component.get_transform(this,0);
          if ((this.nowShowObject == null) ||
             (lVar4 = GameObject.get_transform(this.nowShowObject,0)) == null)
          throw; // [null/range check failed]
          puVar5 = (uint64 *)Transform.get_position(&local_88,lVar4,0);
          local_98 = *puVar5;
          local_90 = *(float *)(puVar5 + 1);
          if ((this.Back == null) ||
             (lVar4 = GameObject.GetComponent(this.Back,DAT_181da0b98)) == null)
          throw; // [null/range check failed]
          puVar5 = (uint64 *)RectTransform.get_rect(local_78,lVar4,0);
          local_68 = *puVar5;
          uStack_60 = puVar5[1];
          fVar10 = (float)FUN_18044e2b0(&local_68,0);
          lVar4 = Component.get_transform(this,0);
          if (lVar4 == null) throw; // [null/range check failed]
          pfVar6 = (float *)Transform.get_lossyScale(local_78,lVar4,0);
          local_80 = local_90 + 0.0;
          local_88 = CONCAT44((fVar10 * *pfVar6 + fVar11) * -0.5 + local_98._4_4_,(float)local_98 + fVar8)
          ;
          if (lVar3 == null) throw; // [null/range check failed]
          puVar5 = &local_98;
          local_90 = local_80;
        }
        local_98 = local_88;
        local_80 = local_90;
        Transform.set_position(lVar3,puVar5,0);
        if ((this.canvasRoot != null) &&
           (lVar3 = GameObject.GetComponent(this.canvasRoot,DAT_181da0b98)) != null) {
          puVar5 = (uint64 *)RectTransform.get_rect(local_78,lVar3,0);
          local_68 = *puVar5;
          uStack_60 = puVar5[1];
          fVar11 = (float)FUN_180d90480(&local_68,0);
          if ((this.canvasRoot != null) &&
             (lVar3 = GameObject.GetComponent(this.canvasRoot,DAT_181da0b98)) != null)
          {
            pfVar6 = (float *)Transform.get_lossyScale(local_78,lVar3,0);
            fVar8 = *pfVar6;
            if ((this.Back != null) &&
               (lVar3 = GameObject.GetComponent(this.Back,DAT_181da0b98)) != null
               ) {
              puVar5 = (uint64 *)RectTransform.get_rect(local_78,lVar3,0);
              local_68 = *puVar5;
              uStack_60 = puVar5[1];
              fVar10 = (float)FUN_180d90480(&local_68,0);
              lVar3 = Component.get_transform(this,0);
              if (lVar3 != null) {
                pfVar6 = (float *)Transform.get_lossyScale(local_78,lVar3,0);
                fVar11 = (fVar8 * fVar11 - fVar10 * *pfVar6) * 0.5;
                if ((this.canvasRoot != null) &&
                   (lVar3 = GameObject.GetComponent(this.canvasRoot,DAT_181da0b98),
                   lVar3 != null)) {
                  puVar5 = (uint64 *)RectTransform.get_rect(local_78,lVar3,0);
                  local_68 = *puVar5;
                  uStack_60 = puVar5[1];
                  fVar8 = (float)FUN_18044e2b0(&local_68,0);
                  if ((this.canvasRoot != null) &&
                     (lVar3 = GameObject.GetComponent(this.canvasRoot,DAT_181da0b98),
                     lVar3 != null)) {
                    puVar5 = (uint64 *)Transform.get_lossyScale(local_78,lVar3,0);
                    local_88 = *puVar5;
                    local_80 = *(float *)(puVar5 + 1);
                    if ((this.Back != null) &&
                       (lVar3 = GameObject.GetComponent(this.Back,DAT_181da0b98),
                       lVar3 != null)) {
                      puVar5 = (uint64 *)RectTransform.get_rect(local_78,lVar3,0);
                      local_68 = *puVar5;
                      uStack_60 = puVar5[1];
                      fVar10 = (float)FUN_18044e2b0(&local_68,0);
                      lVar3 = Component.get_transform(this,0);
                      if (lVar3 != null) {
                        puVar5 = (uint64 *)Transform.get_lossyScale(local_78,lVar3,0);
                        local_98 = *puVar5;
                        local_90 = *(float *)(puVar5 + 1);
                        fVar8 = (local_88._4_4_ * fVar8 - (float)((uint64)local_98 >> 32) * fVar10) *
                                0.5;
                        lVar3 = Component.get_transform(this,0);
                        lVar4 = Component.get_transform(this,0);
                        if (lVar4 != null) {
                          puVar7 = (uint32 *)Transform.get_position(local_78,lVar4,0);
                          uVar9 = FUN_1810a8ba0(*puVar7,-fVar11,fVar11,0);
                          lVar4 = Component.get_transform(this,0);
                          if (lVar4 != null) {
                            puVar5 = (uint64 *)Transform.get_position(local_78,lVar4,0);
                            local_88 = CONCAT44(local_88._4_4_,uVar9);
                            local_98 = *puVar5;
                            local_90 = *(float *)(puVar5 + 1);
                            uVar9 = FUN_1810a8ba0((int)((uint64)local_98 >> 32),-fVar8,fVar8,0);
                            local_88 = CONCAT44(uVar9,(float)local_88);
                            local_80 = 0.0;
                            if (lVar3 != null) {
                              local_98 = local_88;
                              local_90 = 0.0;
                              Transform.set_position(lVar3,&local_98,0);
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

    // Token : 0x6002099
    // RVA   : 0x96ED30   Offset: 0x96D530   Length: 0x15C
    private void ShowSimpleText(string text)
    {
        ulong uVar1;
        ulong uVar2;
        bool cVar3;
        if (this.nowShowObject != null) {
          uVar1 = GameObject.GetComponent(this.nowShowObject,DAT_181da12b0);
          cVar3 = Object.op_Inequality(uVar1,0,0);
          if (!cVar3) {
            if (this.nowShowObject == null) throw; // [null/range check failed]
            uVar1 = GameObject.GetComponent(this.nowShowObject,DAT_181da1fb0);
            cVar3 = Object.op_Inequality(uVar1,0,0);
            if (!cVar3) {
              return;
            }
          }
          if ((this.Text != null) &&
             (uVar1 = GameObject.GetComponent(this.Text,DAT_181da1eb0), text != null)
             ) {
            uVar2 = String.Replace(text,"\\n","\n",0);
            LTLocalization.SetText(uVar1,uVar2,0);
            return;
          }
        }
    }

    // Token : 0x600209A
    // RVA   : 0x96E0E0   Offset: 0x96C8E0   Length: 0xBC
    public void DisableDescribe()
    {
        long lVar1;
        ulong uVar3;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        this.nowShowObject = 0;
        lVar1 = Component.get_transform(this,0);
        puVar2 = (uint64 *)Vector3.get_zero(local_18,0);
        if (lVar1 != null) {
          local_20 = *(uint32 *)(puVar2 + 1);
          local_28 = *puVar2;
          Transform.set_localScale(lVar1,&local_28,0);
          if (this.Text != null) {
            uVar3 = GameObject.GetComponent(this.Text,DAT_181da1eb0);
            LTLocalization.SetText(uVar3,"",0);
            return;
          }
        }
    }

    // Token : 0x600209B
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
