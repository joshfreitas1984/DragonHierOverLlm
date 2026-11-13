// ============================================================
// Type  : ShieldActivate
// Token : 0x20003DF
// ============================================================

public class ShieldActivate
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001F3E
    public float ImpactLife;

    // Token: 0x4001F3F
    private Vector4[] points;

    // Token: 0x4001F40
    private Material m_material;

    // Token: 0x4001F41
    private List<Vector4> Hitpoints;

    // Token: 0x4001F42
    private MeshRenderer m_meshRenderer;

    // Token: 0x4001F43
    private float time;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60024D4
    // RVA   : 0x6A5C30   Offset: 0x6A4A30   Length: 0xF3
    private void Start()
    {
        ulong uVar1;
        uint uVar2;
        uVar2 = Time.get_time(0);
        this.time = uVar2;
        uVar1 = FUN_1801dfd90(DAT_181e86f38,30);
        this.points = uVar1;
        uVar1 = il2cpp_internal(DAT_181e78c28);
        FUN_1810f3480(uVar1,DAT_181e8e558);
        this.Hitpoints = uVar1;
        uVar1 = Component.GetComponent(this,DAT_181e77d38);
        this.m_meshRenderer = uVar1;
        if (this.m_meshRenderer != null) {
          uVar1 = FUN_180af95e0(this.m_meshRenderer,0);
          this.m_material = uVar1;
          return;
        }
    }

    // Token : 0x60024D5
    // RVA   : 0x6A5DC0   Offset: 0x6A4BC0   Length: 0x2DD
    private void Update()
    {
        var pStatics = *(int64*)(DAT_181e65318 + 184);
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
          uVar1 = new OnTooltipCB(this,DAT_181e8b378,DAT_181e95798);
          uVar2 = FUN_18077b910(uVar2,uVar1,DAT_181e97a18);
          lVar3 = *(int64 *)(pStatics + 8);
          if (lVar3 == null) {
            uVar1 = **(uint64 **)(DAT_181e65318 + 184);
            lVar3 = new OnTooltipCB(uVar1,DAT_181e90588,DAT_181e95710);
            plVar4 = (int64 *)(pStatics + 8);
            *plVar4 = lVar3;
            il2cpp_internal(plVar4,lVar3);
          }
          uVar2 = FUN_18077d9d0(uVar2,lVar3,DAT_181e99968);
          uVar2 = FUN_18077d060(uVar2,DAT_181e99200);
          this.Hitpoints = uVar2;
          fVar6 = (float)Time.get_time(0);
          if (this.time + 0.1 < fVar6) {
            uVar7 = Time.get_time(0);
            bVar5 = !DAT_181eb6cb1;
            this.time = uVar7;
            if (bVar5) {
              il2cpp_runtime_class_init(&DAT_181e8e5d8);
              DAT_181eb6cb1 = true;
            }
            lVar3 = this.Hitpoints;
            local_28 = 0;
            uStack_20 = 0;
            FUN_1807282e0(&local_28,0,0,0,0,0);
            if (lVar3 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            local_18 = (uint32)local_28;
            uStack_14 = local_28._4_4_;
            uStack_10 = (uint32)uStack_20;
            uStack_c = uStack_20._4_4_;
            FUN_181660f90(lVar3,&local_18,DAT_181e8e5d8);
          }
          if (this.Hitpoints != null) {
            lVar3 = FUN_181587570(this.Hitpoints,DAT_181e8e758);
            if (lVar3 != null) {
              Array.CopyTo(lVar3,this.points,0,0);
              return;
            }
          }
        }
    }

    // Token : 0x60024D6
    // RVA   : 0x6A5AC0   Offset: 0x6A48C0   Length: 0x169
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
          FUN_1807282e0(&local_18,*(uint32 *)position,fVar5,fVar2 * 0.5,0,0);
          if (lVar3 != null) {
            local_28 = (uint32)local_18;
            uStack_24 = local_18._4_4_;
            uStack_20 = (uint32)uStack_10;
            uStack_1c = uStack_10._4_4_;
            FUN_181660f90(lVar3,&local_28,DAT_181e8e5d8);
            return;
          }
        }
    }

    // Token : 0x60024D7
    // RVA   : 0x6A5A30   Offset: 0x6A4830   Length: 0x82
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
        FUN_1807282e0(&local_28,0,0,0,0,0);
        if (lVar1 != null) {
          local_18 = (uint32)local_28;
          uStack_14 = local_28._4_4_;
          uStack_10 = (uint32)uStack_20;
          uStack_c = uStack_20._4_4_;
          FUN_181660f90(lVar1,&local_18,DAT_181e8e5d8);
          return;
        }
    }

    // Token : 0x60024D8
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

    // Token : 0x60024D9
    // RVA   : 0x6A5D30   Offset: 0x6A4B30   Length: 0x8B
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
        FUN_1807282e0(this,*param_3,uVar3,uVar2,fVar5 / fVar1 + fVar4,0);
        return this;
    }

}
