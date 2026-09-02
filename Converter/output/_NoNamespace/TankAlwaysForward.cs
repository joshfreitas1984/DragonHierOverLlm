// ============================================================
// Type  : TankAlwaysForward
// Token : 0x2000126
// ============================================================

public class TankAlwaysForward
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000729
    public Material TrailMaterial;

    // Token: 0x400072A
    public float Speed;

    // Token: 0x400072B
    public float TrailSpeed;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60009A4
    // RVA   : 0xABCD90   Offset: 0xABB590   Length: 0x17E
    private void FixedUpdate()
    {
        float fVar1;
        ulong uVar2;
        float fVar3;
        float fVar4;
        long lVar5;
        long lVar6;
        uint32 extraout_var;
        float local_68;
        float fStack_64;
        uint64 local_58;
        uint64 local_48;
        float local_40;
        uint8 local_38 [16];
        uint8 local_28 [32];
        lVar5 = Component.get_transform(this,0);
        lVar6 = Component.get_transform(this,0);
        fVar1 = local_40;
        if (lVar6 != null) {
          puVar7 = (uint64 *)Transform.get_position(local_38,lVar6,0);
          uVar2 = *puVar7;
          fVar3 = *(float *)(puVar7 + 1);
          lVar6 = Component.get_transform(this,0);
          fVar1 = local_40;
          if (lVar6 != null) {
            fVar1 = this.Speed;
            puVar7 = (uint64 *)Transform.get_forward(local_28,lVar6,0);
            local_48 = *puVar7;
            fStack_64 = (float)((uint64)uVar2 >> 32);
            local_68 = (float)uVar2;
            local_58 = CONCAT44((float)((uint64)local_48 >> 32) * fVar1 + fStack_64,
                                (float)local_48 * fVar1 + local_68);
            local_40 = *(float *)(puVar7 + 1) * fVar1 + fVar3;
            fVar1 = *(float *)(puVar7 + 1);
            if (lVar5 != null) {
              local_48 = local_58;
              Transform.set_position(lVar5,&local_48,0);
              lVar5 = this.TrailMaterial;
              fVar1 = local_40;
              if (lVar5 != null) {
                fVar4 = (float)Material.get_mainTextureOffset(lVar5,0);
                fVar3 = this.TrailSpeed;
                fVar1 = local_40;
                if (this.TrailMaterial != null) {
                  Material.get_mainTextureOffset(this.TrailMaterial,0);
                  Material.set_mainTextureOffset(lVar5,CONCAT44(extraout_var,fVar4 + fVar3),0);
                  return;
                }
              }
            }
          }
        }
        local_40 = fVar1;
    }

    // Token : 0x60009A5
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
