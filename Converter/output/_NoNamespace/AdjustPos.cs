// ============================================================
// Type  : AdjustPos
// Token : 0x200013A
// ============================================================

public class AdjustPos
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000799
    public bool stopped;

    // Token: 0x400079A
    public Vector3 speed;

    // Token: 0x400079B
    public GameObject followTarget;

    // Token: 0x400079C
    public float delay;

    // Token: 0x400079D
    private Vector3 xOffset;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000A0B
    // RVA   : 0xA0C8F0   Offset: 0xA0B0F0   Length: 0x40C
    private void Update()
    {
        ulong uVar1;
        ulong uVar2;
        bool cVar3;
        long lVar5;
        long lVar6;
        float fVar7;
        float fVar8;
        ulong local_78;
        float local_70;
        ulong local_68;
        float local_60;
        ulong local_58;
        float local_50;
        byte[] local_48 = new byte[16];
        byte[] local_38 = new byte[48];
        uVar2 = this.followTarget;
        cVar3 = Object.op_Inequality(uVar2,0,0);
        if (cVar3) {
          uVar2 = this.xOffset;
          fVar7 = *(float *)(this + 60);
          puVar4 = (uint64 *)Vector3.get_one(local_48,0);
          local_58 = *puVar4;
          local_60 = *(float *)(puVar4 + 1) * -9999.0;
          local_68 = CONCAT44((float)((uint64)local_58 >> 32) * -9999.0,(float)local_58 * -9999.0);
          local_78 = uVar2;
          local_70 = fVar7;
          local_50 = local_60;
          cVar3 = Vector3.op_Equality(&local_78,&local_68,0);
          if (cVar3) {
            lVar5 = Component.get_transform(this,0);
            if (lVar5 == null) goto LAB_180a0ccf7;
            puVar4 = (uint64 *)Transform.get_position(local_48,lVar5,0);
            local_78 = *puVar4;
            local_70 = *(float *)(puVar4 + 1);
            if ((this.followTarget == null) ||
               (lVar5 = GameObject.get_transform(this.followTarget,0)) == null)
            goto LAB_180a0ccf7;
            puVar4 = (uint64 *)Transform.get_position(local_48,lVar5,0);
            local_68 = *puVar4;
            local_60 = *(float *)(puVar4 + 1);
            local_50 = local_70 - local_60;
            this.xOffset =
                 CONCAT44(local_78._4_4_ - (float)((uint64)local_68 >> 32),
                          (float)local_78 - (float)local_68);
            *(float *)(this + 60) = local_50;
            local_58 = local_68;
          }
        }
        if (!this.stopped) {
          fVar7 = this.delay;
          if (fVar7 <= 0.0) {
            uVar2 = this.followTarget;
            cVar3 = Object.op_Inequality(uVar2,0,0);
            if (!cVar3) {
              lVar5 = Component.get_transform(this,0);
              if (lVar5 != null) {
                puVar4 = (uint64 *)Transform.get_position(local_48,lVar5,0);
                uVar2 = this.speed;
                local_70 = *(float *)(puVar4 + 1);
                uVar1 = *puVar4;
                local_60 = *(float *)(this + 36);
                fVar7 = (float)RealTime.get_deltaTime(0);
                local_60 = local_60 * fVar7 + local_70;
                local_68 = CONCAT44((float)((uint64)uVar2 >> 32) * fVar7 +
                                    (float)((uint64)uVar1 >> 32),(float)uVar2 * fVar7 + (float)uVar1)
                ;
                local_50 = local_60;
                Transform.set_position(lVar5,&local_68,0);
                return;
              }
            }
            else {
              local_70 = *(float *)(this + 60);
              uVar2 = this.xOffset;
              uVar1 = this.speed;
              local_60 = *(float *)(this + 36);
              fVar7 = (float)RealTime.get_deltaTime(0);
              local_50 = local_60 * fVar7 + local_70;
              this.xOffset =
                   CONCAT44((float)((uint64)uVar1 >> 32) * fVar7 + (float)((uint64)uVar2 >> 32),
                            (float)uVar1 * fVar7 + (float)uVar2);
              *(float *)(this + 60) = local_50;
              local_78 = uVar2;
              local_68 = uVar1;
              lVar5 = Component.get_transform(this,0);
              local_70 = *(float *)(this + 60);
              local_78 = this.xOffset;
              if ((this.followTarget != null) &&
                 (lVar6 = GameObject.get_transform(this.followTarget,0)) != null) {
                puVar4 = (uint64 *)Transform.get_position(local_38,lVar6,0);
                local_58 = *puVar4;
                local_50 = *(float *)(puVar4 + 1);
                local_60 = local_70 + local_50;
                local_68 = CONCAT44(local_78._4_4_ + (float)((uint64)local_58 >> 32),
                                    (float)local_78 + (float)local_58);
                if (lVar5 != null) {
                  local_58 = local_68;
                  local_50 = local_60;
                  Transform.set_position(lVar5,&local_58,0);
                  return;
                }
              }
            }
        LAB_180a0ccf7:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          fVar8 = (float)Time.get_deltaTime(0);
          this.delay = fVar7 - fVar8;
        }
    }

    // Token : 0x6000A0C
    // RVA   : 0xA0CD00   Offset: 0xA0B500   Length: 0x70
    public void /*ctor*/()
    {
        float fVar1;
        byte[] local_18 = new byte[16];
        puVar2 = (uint64 *)Vector3.get_one(local_18,0);
        fVar1 = *(float *)(puVar2 + 1);
        this.xOffset =
             CONCAT44((float)((uint64)*puVar2 >> 32) * -9999.0,(float)*puVar2 * -9999.0);
        *(float *)(this + 60) = fVar1 * -9999.0;
        FUN_18044ef50(this,0);
    }

}
