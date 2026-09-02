// ============================================================
// Type  : AlwaysForward
// Token : 0x200011D
// ============================================================

public class AlwaysForward
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400070C
    public float Speed;

    // Token: 0x400070D
    public float yRotation;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600098C
    // RVA   : 0xA0CD70   Offset: 0xA0B570   Length: 0x152
    private void Update()
    {
        long lVar1;
        long lVar2;
        float fVar4;
        ulong uVar5;
        float fVar6;
        ulong uVar7;
        ulong local_48;
        float local_40;
        byte[] local_38 = new byte[16];
        byte[] local_28 = new byte[32];
        lVar1 = Component.get_transform(this,0);
        lVar2 = Component.get_transform(this,0);
        if (lVar2 != null) {
          puVar3 = (uint64 *)Transform.get_position(local_38,lVar2,0);
          uVar5 = *puVar3;
          fVar6 = *(float *)(puVar3 + 1);
          lVar2 = Component.get_transform(this,0);
          if (lVar2 != null) {
            fVar4 = this.Speed;
            puVar3 = (uint64 *)Transform.get_forward(local_28,lVar2,0);
            local_40 = *(float *)(puVar3 + 1);
            local_48 = *puVar3;
            uVar7 = CONCAT44((float)((uint64)local_48 >> 32) * fVar4 +
                             (float)((uint64)uVar5 >> 32),(float)local_48 * fVar4 + (float)uVar5);
            fVar4 = local_40 * fVar4 + fVar6;
            if (lVar1 != null) {
              local_48 = uVar7;
              local_40 = fVar4;
              Transform.set_position(lVar1,&local_48,0);
              lVar1 = Component.get_transform(this,0);
              puVar3 = (uint64 *)Vector3.get_up(local_28,0);
              if (lVar1 != null) {
                local_40 = *(float *)(puVar3 + 1);
                local_48 = *puVar3;
                Transform.Rotate(lVar1,&local_48,this.yRotation,0,uVar5,fVar6,uVar7,
                                  fVar4);
                return;
              }
            }
          }
        }
    }

    // Token : 0x600098D
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
