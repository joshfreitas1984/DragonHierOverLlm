// ============================================================
// Type  : AlwaysForward
// Token : 0x200011E
// ============================================================

public class AlwaysForward
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000728
    public float Speed;

    // Token: 0x4000729
    public float yRotation;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60009A4
    // RVA   : 0xA1ECD0   Offset: 0xA1E0D0   Length: 0x152
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

    // Token : 0x60009A5
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
