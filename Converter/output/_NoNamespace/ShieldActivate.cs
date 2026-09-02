// ============================================================
// Type  : ShieldActivate
// Token : 0x20003CB
// ============================================================

public class ShieldActivate
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001DA1
    public float ImpactLife;

    // Token: 0x4001DA2
    private Vector4[] points;

    // Token: 0x4001DA3
    private Material m_material;

    // Token: 0x4001DA4
    private List<Vector4> Hitpoints;

    // Token: 0x4001DA5
    private MeshRenderer m_meshRenderer;

    // Token: 0x4001DA6
    private float time;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60023A7
    // RVA   : 0x96B600   Offset: 0x969E00   Length: 0xF3
    private void Start()
    {
        ulong uVar1;
        uint uVar2;
        uVar2 = Time.get_time(0);
        this.time = uVar2;
        uVar1 = FUN_1800d60b0(DAT_181d81cc0,30);
        this.points = uVar1;
        uVar1 = il2cpp_internal(DAT_181d73f30);
        FUN_180f58a90(uVar1,DAT_181d84578);
        this.Hitpoints = uVar1;
        uVar1 = Component.GetComponent(this,DAT_181d6c1c0);
        this.m_meshRenderer = uVar1;
        if (this.m_meshRenderer != null) {
          uVar1 = FUN_180d94be0(this.m_meshRenderer,0);
          this.m_material = uVar1;
          return;
        }
    }

    // Token : 0x60023A8
    // RVA   : 0x96B790   Offset: 0x969F90   Length: 0x2DD
    private void Update()
    {
        var pStatics = *(int64*)(DAT_181d5f818 + 184);
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        float fVar6;
        uint uVar7;
        ulong local_28;
        ulong uStack_20;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        if (this.m_material != null) {
          Material.SetVectorArray
                    (this.m_material,"_Points",this.points,0);
          uVar2 = this.Hitpoints;
          uVar1 = new OnTooltipCB(this,DAT_181d7edc0,DAT_181d8c838);
          uVar2 = FUN_18095ff20(uVar2,uVar1,DAT_181d8b5b8);
          lVar3 = *(int64 *)(pStatics + 8);
          if (lVar3 == null) {
            uVar1 = **(uint64 **)(DAT_181d5f818 + 184);
            lVar3 = new OnTooltipCB(uVar1,DAT_181d83b28,DAT_181d8c7b0);
            plVar4 = (int64 *)(pStatics + 8);
            *plVar4 = lVar3;
            il2cpp_internal(plVar4,lVar3);
          }
          uVar2 = FUN_180961fe0(uVar2,lVar3,DAT_181d8d3e0);
          uVar2 = FUN_180961670(uVar2,DAT_181d8cc78);
          this.Hitpoints = uVar2;
          fVar6 = (float)Time.get_time(0);
          if (this.time + 0.1 < fVar6) {
            uVar7 = Time.get_time(0);
            bVar5 = !DAT_181e7816e;
            this.time = uVar7;
            if (bVar5) {
              il2cpp_runtime_class_init(&DAT_181d845f8);
              DAT_181e7816e = true;
            }
            lVar3 = this.Hitpoints;
            local_28 = 0;
            uStack_20 = 0;
            FUN_1809981e0(&local_28,0,0,0,0,0);
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_18 = (uint32)local_28;
            uStack_14 = local_28._4_4_;
            uStack_10 = (uint32)uStack_20;
            uStack_c = uStack_20._4_4_;
            FUN_1818059b0(lVar3,&local_18,DAT_181d845f8);
          }
          if (this.Hitpoints != null) {
            lVar3 = FUN_180f582c0(this.Hitpoints,DAT_181d84778);
            if (lVar3 != null) {
              Array.CopyTo(lVar3,this.points,0,0);
              return;
            }
          }
        }
    }

    // Token : 0x60023A9
    // RVA   : 0x96B490   Offset: 0x969C90   Length: 0x169
    public void AddHitObject(Vector3 position)
    {
        ulong uVar1;
        float fVar2;
        long lVar3;
        float fVar5;
        float local_58;
        float fStack_54;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        uint64 local_18;
        uint64 uStack_10;
        uVar1 = *position;
        fVar2 = *(float *)(position + 1);
        lVar3 = Component.get_transform(this,0);
        if (lVar3 != null) {
          puVar4 = (uint64 *)Transform.get_position(&local_28,lVar3,0);
          local_58 = (float)uVar1;
          fVar5 = *(float *)(puVar4 + 1);
          fStack_54 = (float)((uint64)uVar1 >> 32);
          *position = CONCAT44(fStack_54 - (float)((uint64)*puVar4 >> 32),local_58 - (float)*puVar4);
          *(float *)(position + 1) = fVar2 - fVar5;
          puVar4 = (uint64 *)Vector3.get_normalized(&local_28,position,0);
          fVar2 = *(float *)(puVar4 + 1);
          fVar5 = (float)((uint64)*puVar4 >> 32) * 0.5;
          lVar3 = this.Hitpoints;
          *position = CONCAT44(fVar5,(float)*puVar4 * 0.5);
          *(float *)(position + 1) = fVar2 * 0.5;
          local_18 = 0;
          uStack_10 = 0;
          FUN_1809981e0(&local_18,*(uint32 *)position,fVar5,fVar2 * 0.5,0,0);
          if (lVar3 != null) {
            local_28 = (uint32)local_18;
            uStack_24 = local_18._4_4_;
            uStack_20 = (uint32)uStack_10;
            uStack_1c = uStack_10._4_4_;
            FUN_1818059b0(lVar3,&local_28,DAT_181d845f8);
            return;
          }
        }
    }

    // Token : 0x60023AA
    // RVA   : 0x96B400   Offset: 0x969C00   Length: 0x82
    public void AddEmpty()
    {
        long lVar1;
        ulong local_28;
        ulong uStack_20;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        lVar1 = this.Hitpoints;
        local_28 = 0;
        uStack_20 = 0;
        FUN_1809981e0(&local_28,0,0,0,0,0);
        if (lVar1 != null) {
          local_18 = (uint32)local_28;
          uStack_14 = local_28._4_4_;
          uStack_10 = (uint32)uStack_20;
          uStack_c = uStack_20._4_4_;
          FUN_1818059b0(lVar1,&local_18,DAT_181d845f8);
          return;
        }
    }

    // Token : 0x60023AB
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x60023AC
    // RVA   : 0x96B700   Offset: 0x969F00   Length: 0x8B
    private Vector4 <Update>b__7_0(Vector4 s)
    {
        float fVar1;
        uint uVar2;
        uint uVar3;
        float fVar4;
        float fVar5;
        fVar5 = (float)Time.get_deltaTime(0);
        fVar1 = *(float *)(s + 24);
        uVar2 = param_3[2];
        uVar3 = param_3[1];
        fVar4 = (float)param_3[3];
        *this = 0;
        this[1] = 0;
        FUN_1809981e0(this,*param_3,uVar3,uVar2,fVar5 / fVar1 + fVar4,0);
        return this;
    }

}
