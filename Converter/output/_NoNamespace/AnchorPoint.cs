// ============================================================
// Type  : AnchorPoint
// Token : 0x20000A8
// ============================================================

public class AnchorPoint
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40003FB
    public Transform target;

    // Token: 0x40003FC
    public float relative;

    // Token: 0x40003FD
    public int absolute;

    // Token: 0x40003FE
    public UIRect rect;

    // Token: 0x40003FF
    public Camera targetCam;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000502
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
        this.relative = param_2;
    }

    // Token : 0x6000503
    // RVA   : 0xB05030   Offset: 0xB03830   Length: 0x28
    public void /*ctor*/(float relative)
    {
        ZhSegment.Initialize(this,0);
        this.relative = relative;
    }

    // Token : 0x6000504
    // RVA   : 0xB05000   Offset: 0xB03800   Length: 0x29
    public void Set(float relative, float absolute)
    {
        uint uVar1;
        this.target = relative;
        this.relative = absolute;
        uVar1 = Mathf.FloorToInt(param_4 + 0.5,0);
        this.absolute = uVar1;
    }

    // Token : 0x6000505
    // RVA   : 0xB04FB0   Offset: 0xB037B0   Length: 0x4F
    public void Set(Transform target, float relative, float absolute)
    {
        uint uVar1;
        this.target = target;
        this.relative = relative;
        uVar1 = Mathf.FloorToInt(absolute + 0.5,0);
        this.absolute = uVar1;
    }

    // Token : 0x6000506
    // RVA   : 0xB04D00   Offset: 0xB03500   Length: 0x7B
    public void SetToNearest(float abs0, float abs1, float abs2)
    {
        void AnchorPoint.SetToNearest
                     (int64 this,uint32 abs0,uint32 abs1,uint32 abs2,
                     float param_5,float param_6,float param_7)
        {
        uint32 uVar1;
        float fVar2;
        float fVar3;
        fVar2 = ABS(param_6);
        fVar3 = ABS(param_5);
        if ((((fVar2 <= fVar3) || (ABS(param_7) <= fVar3)) &&
            (abs0 = abs2, param_5 = param_7, fVar2 < fVar3)) && (fVar2 < ABS(param_7))) {
          abs0 = abs1;
          param_5 = param_6;
        }
        this.relative = abs0;
        uVar1 = Mathf.FloorToInt(param_5 + 0.5,0);
        this.absolute = uVar1;
    }

    // Token : 0x6000507
    // RVA   : 0xB04D80   Offset: 0xB03580   Length: 0x98
    public void SetToNearest(float rel0, float rel1, float rel2, float abs0, float abs1, float abs2)
    {
        void AnchorPoint.SetToNearest
                     (int64 this,uint32 rel0,uint32 rel1,uint32 rel2,
                     float abs0,float abs1,float abs2)
        {
        uint32 uVar1;
        float fVar2;
        float fVar3;
        fVar2 = ABS(abs1);
        fVar3 = ABS(abs0);
        if ((((fVar2 <= fVar3) || (ABS(abs2) <= fVar3)) &&
            (rel0 = rel2, abs0 = abs2, fVar2 < fVar3)) && (fVar2 < ABS(abs2))) {
          rel0 = rel1;
          abs0 = abs1;
        }
        this.relative = rel0;
        uVar1 = Mathf.FloorToInt(abs0 + 0.5,0);
        this.absolute = uVar1;
    }

    // Token : 0x6000508
    // RVA   : 0xB04B50   Offset: 0xB03350   Length: 0x1A0
    public void SetHorizontal(Transform parent, float localPos)
    {
        bool cVar2;
        uint uVar3;
        long lVar5;
        ulong uVar6;
        ulong local_58;
        ulong local_48;
        uint local_40;
        byte[] local_38 = new byte[48];
        uVar6 = this.rect;
        cVar2 = Object.op_Implicit(uVar6,0);
        if (!cVar2) {
          if (this.target != null) {
            puVar4 = (uint64 *)Transform.get_position(&local_48,this.target,0);
            local_58 = *puVar4;
            uVar3 = *(uint32 *)(puVar4 + 1);
            cVar2 = Object.op_Inequality(parent,0,0);
            if (cVar2) {
              if (parent == null) throw; // [null/range check failed]
              local_48 = local_58;
              local_40 = uVar3;
              puVar4 = (uint64 *)Transform.InverseTransformPoint(local_38,parent,&local_48,0);
              local_58 = *puVar4;
            }
        LAB_180b04c9a:
            uVar3 = Mathf.FloorToInt((localPos - (float)local_58) + 0.5,0);
            this.absolute = uVar3;
            return;
          }
        }
        else {
          plVar1 = this.rect;
          if (plVar1 != (int64 *)0) {
            lVar5 = (**(code **)(*plVar1 + 0x208))(plVar1,parent,*(uint64 *)(*plVar1 + 0x210));
            if (lVar5 != null) {
              if (*(uint32 *)(lVar5 + 24) == 0) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              if (*(uint32 *)(lVar5 + 24) < 3) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              local_58._0_4_ =
                   (float)Mathf.Lerp(*(uint32 *)(lVar5 + 32),*(uint32 *)(lVar5 + 56),
                                      this.relative,0);
              goto LAB_180b04c9a;
            }
          }
        }
    }

    // Token : 0x6000509
    // RVA   : 0xB04E20   Offset: 0xB03620   Length: 0x18A
    public void SetVertical(Transform parent, float localPos)
    {
        bool cVar2;
        uint uVar3;
        long lVar5;
        ulong uVar6;
        ulong local_58;
        ulong local_48;
        uint local_40;
        byte[] local_38 = new byte[48];
        uVar6 = this.rect;
        cVar2 = Object.op_Implicit(uVar6,0);
        if (!cVar2) {
          if (this.target != null) {
            puVar4 = (uint64 *)Transform.get_position(&local_48,this.target,0);
            local_58 = *puVar4;
            uVar3 = *(uint32 *)(puVar4 + 1);
            cVar2 = Object.op_Inequality(parent,0,0);
            if (cVar2) {
              if (parent == null) throw; // [null/range check failed]
              local_48 = local_58;
              local_40 = uVar3;
              puVar4 = (uint64 *)Transform.InverseTransformPoint(local_38,parent,&local_48,0);
              local_58 = *puVar4;
            }
        LAB_180b04f64:
            uVar3 = Mathf.FloorToInt((localPos - local_58._4_4_) + 0.5,0);
            this.absolute = uVar3;
            return;
          }
        }
        else {
          plVar1 = this.rect;
          if (plVar1 != (int64 *)0) {
            lVar5 = (**(code **)(*plVar1 + 0x208))(plVar1,parent,*(uint64 *)(*plVar1 + 0x210));
            if (lVar5 != null) {
              if (*(uint32 *)(lVar5 + 24) < 4) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              local_58._4_4_ =
                   (float)Mathf.Lerp(*(uint32 *)(lVar5 + 72),*(uint32 *)(lVar5 + 48),
                                      this.relative,0);
              goto LAB_180b04f64;
            }
          }
        }
    }

    // Token : 0x600050A
    // RVA   : 0xB049C0   Offset: 0xB031C0   Length: 0x180
    public Vector3[] GetSides(Transform relativeTo)
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = this.target;
        cVar2 = Object.op_Inequality(uVar3,0,0);
        if (!cVar2) {
          return 0;
        }
        uVar3 = this.rect;
        cVar2 = Object.op_Inequality(uVar3,0,0);
        if (!cVar2) {
          if (this.target != null) {
            uVar3 = Component.GetComponent(this.target,DAT_181d6afc0);
            cVar2 = Object.op_Inequality(uVar3,0,0);
            if (!cVar2) {
              return 0;
            }
            uVar3 = NGUITools.GetSides(uVar3,relativeTo,0);
            return uVar3;
          }
        }
        else {
          plVar1 = this.rect;
          if (plVar1 != (int64 *)0) {
                          // WARNING: Could not recover jumptable at 0x000180b04b22. Too many branches
                          // WARNING: Treating indirect jump as call
            uVar3 = (**(code **)(*plVar1 + 0x208))(plVar1,relativeTo,*(uint64 *)(*plVar1 + 0x210));
            return uVar3;
          }
        }
    }

}
