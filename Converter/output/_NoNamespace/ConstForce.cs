// ============================================================
// Type  : ConstForce
// Token : 0x200011E
// ============================================================

public class ConstForce
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400070E
    public float speed;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600098E
    // RVA   : 0xA488A0   Offset: 0xA470A0   Length: 0x12D
    private void Update()
    {
        float fVar1;
        float fVar2;
        long lVar3;
        long lVar4;
        long lVar5;
        ulong uVar7;
        uint uVar8;
        byte[] local_28 = new byte[32];
        lVar4 = Component.GetComponents(this,DAT_181d6f740);
        uVar8 = 0;
        if (lVar4 != null) {
          while( true ) {
            if ((int)*(uint32 *)(lVar4 + 24) <= (int)uVar8) {
              return;
            }
            if (*(uint32 *)(lVar4 + 24) <= uVar8) {
              uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar7,0);
            }
            lVar3 = lVar4[uVar8];
            lVar5 = Component.get_transform(this,0);
            if (lVar5 == null) break;
            fVar1 = this.speed;
            puVar6 = (uint64 *)Transform.get_forward(local_28,lVar5,0);
            fVar2 = *(float *)(puVar6 + 1);
            if (lVar3 == null) break;
            uVar8 = uVar8 + 1;
            *(uint64 *)(lVar3 + 68) =
                 CONCAT44((float)((uint64)*puVar6 >> 32) * fVar1,(float)*puVar6 * fVar1);
            *(float *)(lVar3 + 76) = fVar2 * fVar1;
          }
        }
    }

    // Token : 0x600098F
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
