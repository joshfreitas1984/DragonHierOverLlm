// ============================================================
// Type  : HollowOutMask
// Token : 0x20002D3
// ============================================================

public class HollowOutMask
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40016B2
    public RectTransform _target;

    // Token: 0x40016B3
    private Vector3 _targetMin;

    // Token: 0x40016B4
    private Vector3 _targetMax;

    // Token: 0x40016B5
    private bool _canRefresh;

    // Token: 0x40016B6
    private Transform _cacheTrans;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60017D5
    // RVA   : 0xB3F310   Offset: 0xB3DB10   Length: 0x2E
    public void SetTarget(RectTransform target)
    {
        long lVar1;
        long lVar2;
        bool cVar3;
        long local_28;
        uint local_20;
        long local_18;
        uint local_10;
        local_28 = this[28];
        local_20 = (uint32)this[29];
        local_18 = *target;
        local_10 = (uint32)target[1];
        cVar3 = Vector3.op_Equality(&local_18,&local_28,0);
        if (cVar3) {
          local_18 = *(int64 *)((int64)this + 236);
          local_10 = *(uint32 *)((int64)this + 244);
          local_28 = *param_3;
          local_20 = (uint32)param_3[1];
          cVar3 = Vector3.op_Equality(&local_28,&local_18,0);
          if (cVar3) {
            return;
          }
        }
        lVar2 = target[1];
        this[28] = *target;
        lVar1 = *param_3;
        *(int *)(this + 29) = (int)lVar2;
        lVar2 = param_3[1];
        *(int64 *)((int64)this + 236) = lVar1;
        *(int *)((int64)this + 244) = (int)lVar2;
        (**(code **)(*this + 0x2d8))(this,*(uint64 *)(*this + 0x2e0));
    }

    // Token : 0x60017D6
    // RVA   : 0xB3F220   Offset: 0xB3DA20   Length: 0xE3
    private void SetTarget(Vector3 tarMin, Vector3 tarMax)
    {
        long lVar1;
        long lVar2;
        bool cVar3;
        long local_28;
        uint local_20;
        long local_18;
        uint local_10;
        local_28 = this[28];
        local_20 = (uint32)this[29];
        local_18 = *tarMin;
        local_10 = (uint32)tarMin[1];
        cVar3 = Vector3.op_Equality(&local_18,&local_28,0);
        if (cVar3) {
          local_18 = *(int64 *)((int64)this + 236);
          local_10 = *(uint32 *)((int64)this + 244);
          local_28 = *tarMax;
          local_20 = (uint32)tarMax[1];
          cVar3 = Vector3.op_Equality(&local_28,&local_18,0);
          if (cVar3) {
            return;
          }
        }
        lVar2 = tarMin[1];
        this[28] = *tarMin;
        lVar1 = *tarMax;
        *(int *)(this + 29) = (int)lVar2;
        lVar2 = tarMax[1];
        *(int64 *)((int64)this + 236) = lVar1;
        *(int *)((int64)this + 244) = (int)lVar2;
        (**(code **)(*this + 0x2d8))(this,*(uint64 *)(*this + 0x2e0));
    }

    // Token : 0x60017D7
    // RVA   : 0xB3F030   Offset: 0xB3D830   Length: 0x1E6
    private void RefreshView()
    {
        ulong uVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        bool cVar5;
        ulong local_58;
        uint local_50;
        ulong local_48;
        uint local_40;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        uint64 local_18;
        if ((char)this[31] != false) {
          lVar3 = this[27];
          *(uint8 *)(this + 31) = 0;
          cVar5 = Object.op_Equality(0,lVar3,0);
          if (!cVar5) {
            lVar3 = this[32];
            lVar4 = this[27];
            puVar6 = (uint32 *)
                     RectTransformUtility.CalculateRelativeRectTransformBounds(&local_48,lVar3,lVar4,0);
            local_28 = *puVar6;
            uStack_24 = puVar6[1];
            uStack_20 = puVar6[2];
            uStack_1c = puVar6[3];
            local_18 = *(uint64 *)(puVar6 + 4);
            puVar7 = (uint64 *)Bounds.get_min(&local_48,&local_28,0);
            uVar1 = *puVar7;
            uVar2 = *(uint32 *)(puVar7 + 1);
            puVar7 = (uint64 *)Bounds.get_max(&local_48,&local_28,0);
            local_58 = *puVar7;
            local_50 = *(uint32 *)(puVar7 + 1);
            local_48 = uVar1;
            local_40 = uVar2;
            HollowOutMask.SetTarget(this,&local_48,&local_58,0);
            return;
          }
          puVar7 = (uint64 *)Vector3.get_zero(&local_48,0);
          uVar1 = *puVar7;
          uVar2 = *(uint32 *)(puVar7 + 1);
          puVar7 = (uint64 *)Vector3.get_zero(&local_58,0);
          local_48 = *puVar7;
          local_40 = *(uint32 *)(puVar7 + 1);
          local_58 = uVar1;
          local_50 = uVar2;
          HollowOutMask.SetTarget(this,&local_58,&local_48,0);
          (**(code **)(*this + 0x2d8))(this,*(uint64 *)(*this + 0x2e0));
        }
    }

    // Token : 0x60017D8
    // RVA   : 0xB3E9C0   Offset: 0xB3D1C0   Length: 0x666
    protected override void OnPopulateMesh(VertexHelper vh)
    {
        ulong uVar1;
        uint uVar2;
        ulong uVar3;
        ulong uVar4;
        ulong uVar5;
        ulong uVar6;
        ulong uVar7;
        ulong uVar8;
        ulong uVar9;
        ulong uVar10;
        long lVar11;
        ulong uVar12;
        bool cVar13;
        uint uVar14;
        long lVar17;
        ulong uVar18;
        float fVar20;
        float fVar21;
        float fVar22;
        float fVar23;
        float local_res8;
        float fStackX_c;
        int64 local_1c8;
        uint32 uStack_1c0;
        uint32 uStack_1bc;
        float local_1b8;
        float fStack_1b4;
        uint32 uStack_1b0;
        uint32 uStack_1ac;
        uint64 local_1a8;
        uint64 uStack_1a0;
        uint64 local_198;
        uint64 uStack_190;
        uint64 local_188;
        uint64 uStack_180;
        uint64 local_178;
        uint64 uStack_170;
        uint64 local_168;
        uint64 uStack_160;
        uint64 local_158;
        uint32 local_150;
        uint64 local_148;
        uint32 local_140;
        uint32 local_138;
        uint32 uStack_134;
        uint32 uStack_130;
        uint32 uStack_12c;
        uint64 local_128;
        uint64 uStack_120;
        uint64 local_108;
        uint64 uStack_100;
        lVar17 = this[28];
        lVar11 = this[29];
        puVar15 = (uint64 *)Vector3.get_zero(&local_1c8,0);
        local_148 = *puVar15;
        local_140 = *(uint32 *)(puVar15 + 1);
        local_1c8 = lVar17;
        uStack_1c0 = (int)lVar11;
        cVar13 = Vector3.op_Equality(&local_1c8,&local_148,0);
        if (cVar13) {
          uVar1 = *(uint64 *)((int64)this + 236);
          uVar2 = *(uint32 *)((int64)this + 244);
          plVar16 = (int64 *)Vector3.get_zero(&local_148,0);
          local_1c8 = *plVar16;
          uStack_1c0 = (uint32)plVar16[1];
          local_148 = uVar1;
          local_140 = uVar2;
          cVar13 = Vector3.op_Equality(&local_148,&local_1c8,0);
          if (cVar13) {
            Graphic.OnPopulateMesh(this,vh,0);
            return;
          }
        }
        if (vh != null) {
          VertexHelper.Clear(vh,0);
          lVar17 = *(int64 *)(DAT_181d8b458 + 184);
          local_128 = *(uint64 *)(lVar17 + 20);
          uStack_120 = *(uint64 *)(lVar17 + 28);
          uVar2 = *(uint32 *)(lVar17 + 124);
          uVar3 = *(uint64 *)(lVar17 + 36);
          uVar4 = *(uint64 *)(lVar17 + 44);
          uVar5 = *(uint64 *)(lVar17 + 68);
          uVar6 = *(uint64 *)(lVar17 + 76);
          uVar7 = *(uint64 *)(lVar17 + 84);
          uVar8 = *(uint64 *)(lVar17 + 92);
          uVar9 = *(uint64 *)(lVar17 + 100);
          uVar10 = *(uint64 *)(lVar17 + 108);
          local_108 = *(uint64 *)(lVar17 + 52);
          uStack_100 = *(uint64 *)(lVar17 + 60);
          uVar1 = *(uint64 *)(lVar17 + 116);
          plVar16 = (int64 *)
                    (**(code **)(*this + 0x298))(&local_1c8,this,*(uint64 *)(*this + 0x2a0));
          local_1c8 = *plVar16;
          uStack_1c0 = (uint32)plVar16[1];
          uStack_1bc = *(uint32 *)((int64)plVar16 + 12);
          uVar14 = Color32.op_Implicit(&local_1c8,0);
          uStack_100 = CONCAT44(uStack_100._4_4_,uVar14);
          lVar17 = Graphic.get_rectTransform(this,0);
          if (lVar17 != null) {
            uVar18 = RectTransform.get_pivot(lVar17,0);
            lVar17 = Graphic.get_rectTransform(this,0);
            if (lVar17 != null) {
              puVar19 = (uint32 *)RectTransform.get_rect(&local_1c8,lVar17,0);
              local_138 = *puVar19;
              uStack_134 = puVar19[1];
              uStack_130 = puVar19[2];
              uStack_12c = puVar19[3];
              fVar20 = (float)FUN_180d90480(&local_138,0);
              local_res8 = (float)uVar18;
              fVar21 = (float)FUN_18044e2b0(&local_138,0);
              fStackX_c = (float)((uint64)uVar18 >> 32);
              fVar22 = (float)FUN_180d90480(&local_138,0);
              fVar22 = fVar22 * (1.0 - local_res8);
              fVar23 = (float)FUN_18044e2b0(&local_138,0);
              uVar12 = uStack_100;
              uVar18 = local_108;
              uVar14 = uStack_120._4_4_;
              fVar23 = fVar23 * (1.0 - fStackX_c);
              local_198 = local_108;
              uStack_190 = uStack_100;
              uStack_1b0 = 0;
              uStack_1ac = uStack_120._4_4_;
              local_1b8 = fVar20 * -local_res8;
              fStack_1b4 = fVar23;
              local_1a8 = uVar3;
              uStack_1a0 = uVar4;
              local_188 = uVar5;
              uStack_180 = uVar6;
              local_178 = uVar7;
              uStack_170 = uVar8;
              local_168 = uVar9;
              uStack_160 = uVar10;
              local_158 = uVar1;
              local_150 = uVar2;
              VertexHelper.AddVert(vh,&local_1b8,0);
              uStack_1b0 = 0;
              uStack_1ac = uVar14;
              local_198 = uVar18;
              uStack_190 = uVar12;
              local_1b8 = fVar22;
              fStack_1b4 = fVar23;
              local_1a8 = uVar3;
              uStack_1a0 = uVar4;
              local_188 = uVar5;
              uStack_180 = uVar6;
              local_178 = uVar7;
              uStack_170 = uVar8;
              local_168 = uVar9;
              uStack_160 = uVar10;
              local_158 = uVar1;
              local_150 = uVar2;
              VertexHelper.AddVert(vh,&local_1b8,0);
              uStack_1b0 = 0;
              uStack_1ac = uVar14;
              local_198 = uVar18;
              uStack_190 = uVar12;
              local_1b8 = fVar22;
              fStack_1b4 = fVar21 * -fStackX_c;
              local_1a8 = uVar3;
              uStack_1a0 = uVar4;
              local_188 = uVar5;
              uStack_180 = uVar6;
              local_178 = uVar7;
              uStack_170 = uVar8;
              local_168 = uVar9;
              uStack_160 = uVar10;
              local_158 = uVar1;
              local_150 = uVar2;
              VertexHelper.AddVert(vh,&local_1b8,0);
              uStack_1b0 = 0;
              uStack_1ac = uVar14;
              local_198 = uVar18;
              uStack_190 = uVar12;
              local_1b8 = fVar20 * -local_res8;
              fStack_1b4 = fVar21 * -fStackX_c;
              local_1a8 = uVar3;
              uStack_1a0 = uVar4;
              local_188 = uVar5;
              uStack_180 = uVar6;
              local_178 = uVar7;
              uStack_170 = uVar8;
              local_168 = uVar9;
              uStack_160 = uVar10;
              local_158 = uVar1;
              local_150 = uVar2;
              VertexHelper.AddVert(vh,&local_1b8,0);
              local_1b8 = *(float *)(this + 28);
              fStack_1b4 = (float)this[30];
              uStack_1b0 = 0;
              uStack_1ac = uVar14;
              local_198 = uVar18;
              uStack_190 = uVar12;
              local_1a8 = uVar3;
              uStack_1a0 = uVar4;
              local_188 = uVar5;
              uStack_180 = uVar6;
              local_178 = uVar7;
              uStack_170 = uVar8;
              local_168 = uVar9;
              uStack_160 = uVar10;
              local_158 = uVar1;
              local_150 = uVar2;
              VertexHelper.AddVert(vh,&local_1b8,0);
              local_1b8 = *(float *)((int64)this + 236);
              fStack_1b4 = (float)this[30];
              uStack_1b0 = 0;
              uStack_1ac = uVar14;
              local_198 = uVar18;
              uStack_190 = uVar12;
              local_1a8 = uVar3;
              uStack_1a0 = uVar4;
              local_188 = uVar5;
              uStack_180 = uVar6;
              local_178 = uVar7;
              uStack_170 = uVar8;
              local_168 = uVar9;
              uStack_160 = uVar10;
              local_158 = uVar1;
              local_150 = uVar2;
              VertexHelper.AddVert(vh,&local_1b8,0);
              local_1b8 = *(float *)((int64)this + 236);
              fStack_1b4 = *(float *)((int64)this + 228);
              uStack_1b0 = 0;
              uStack_1ac = uVar14;
              local_198 = uVar18;
              uStack_190 = uVar12;
              local_1a8 = uVar3;
              uStack_1a0 = uVar4;
              local_188 = uVar5;
              uStack_180 = uVar6;
              local_178 = uVar7;
              uStack_170 = uVar8;
              local_168 = uVar9;
              uStack_160 = uVar10;
              local_158 = uVar1;
              local_150 = uVar2;
              VertexHelper.AddVert(vh,&local_1b8,0);
              local_1b8 = *(float *)(this + 28);
              fStack_1b4 = *(float *)((int64)this + 228);
              uStack_1b0 = 0;
              uStack_1ac = uVar14;
              local_198 = uVar18;
              uStack_190 = uVar12;
              local_1a8 = uVar3;
              uStack_1a0 = uVar4;
              local_188 = uVar5;
              uStack_180 = uVar6;
              local_178 = uVar7;
              uStack_170 = uVar8;
              local_168 = uVar9;
              uStack_160 = uVar10;
              local_158 = uVar1;
              local_150 = uVar2;
              VertexHelper.AddVert(vh,&local_1b8,0);
              VertexHelper.AddTriangle(vh,4,0,1,0);
              VertexHelper.AddTriangle(vh,4,1,5,0);
              VertexHelper.AddTriangle(vh,5,1,2,0);
              VertexHelper.AddTriangle(vh,5,2,6,0);
              VertexHelper.AddTriangle(vh,6,2,3,0);
              VertexHelper.AddTriangle(vh,6,3,7,0);
              VertexHelper.AddTriangle(vh,7,3,0,0);
              VertexHelper.AddTriangle(vh,7,0,4,0);
              return;
            }
          }
        }
    }

    // Token : 0x60017D9
    // RVA   : 0xB3F340   Offset: 0xB3DB40   Length: 0xD3
    private virtual bool UnityEngine.ICanvasRaycastFilter.IsRaycastLocationValid(Vector2 screenPos, Camera eventCamera)
    {
        bool HollowOutMask.UnityEngine_ICanvasRaycastFilter_IsRaycastLocationValid
                     (int64 this,uint64 screenPos,uint64 eventCamera)
        {
        uint64 uVar1;
        char cVar2;
        bool bVar3;
        uVar1 = this._target;
        cVar2 = Object.op_Equality(0,uVar1,0);
        if (!cVar2) {
          uVar1 = this._target;
          cVar2 = RectTransformUtility.RectangleContainsScreenPoint(uVar1,screenPos,eventCamera,0);
          bVar3 = !cVar2;
        }
        else {
          bVar3 = true;
        }
        return bVar3;
    }

    // Token : 0x60017DA
    // RVA   : 0xB3E960   Offset: 0xB3D160   Length: 0x55
    protected override void Awake()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        uVar1 = Component.GetComponent(this,DAT_181d6c740);
        this._cacheTrans = uVar1;
    }

    // Token : 0x60017DB
    // RVA   : 0xB3F420   Offset: 0xB3DC20   Length: 0xE
    private void Update()
    {
        void FUN_180b3f420(int64 this)
        {
        this._canRefresh = 1;
        HollowOutMask.RefreshView(this,0);
    }

    // Token : 0x60017DC
    // RVA   : 0xB3F430   Offset: 0xB3DC30   Length: 0x61
    public void /*ctor*/()
    {
        byte[] local_18 = new byte[16];
        puVar1 = (uint64 *)Vector3.get_zero(local_18,0);
        this._targetMin = *puVar1;
        *(uint32 *)(this + 232) = *(uint32 *)(puVar1 + 1);
        puVar1 = (uint64 *)Vector3.get_zero(local_18,0);
        this._targetMax = *puVar1;
        *(uint32 *)(this + 244) = *(uint32 *)(puVar1 + 1);
        this._canRefresh = 1;
        MaskableGraphic.ctor(this,0);
    }

}
