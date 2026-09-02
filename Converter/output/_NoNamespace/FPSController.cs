// ============================================================
// Type  : FPSController
// Token : 0x2000120
// ============================================================

public class FPSController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000710
    public Animator CamAnimator;

    // Token: 0x4000711
    public Animator WeaponAnimator;

    // Token: 0x4000712
    public float moveSpeed;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000993
    // RVA   : 0xBA1070   Offset: 0xB9F870   Length: 0x1ED
    private void Update()
    {
        float fVar1;
        ulong uVar2;
        float fVar3;
        ulong uVar4;
        byte uVar5;
        bool cVar6;
        long lVar7;
        long lVar8;
        float fVar10;
        float fVar11;
        float local_88;
        float fStack_84;
        ulong local_78;
        ulong local_68;
        float local_60;
        byte[] local_58 = new byte[16];
        byte[] local_48 = new byte[64];
        lVar7 = this.CamAnimator;
        uVar5 = FUN_1804625f0(119);
        if (lVar7 != null) {
          FUN_18044e920(lVar7,"Running",uVar5,0);
          lVar7 = this.WeaponAnimator;
          uVar5 = FUN_1804625f0(32);
          if (lVar7 != null) {
            FUN_18044e920(lVar7,"Fire",uVar5,0);
            cVar6 = FUN_1804625f0(119);
            if (!cVar6) {
              return;
            }
            lVar7 = Component.get_transform(this,0);
            lVar8 = Component.get_transform(this,0);
            if (lVar8 != null) {
              puVar9 = (uint64 *)Transform.get_position(local_58,lVar8,0);
              uVar2 = *puVar9;
              fVar3 = *(float *)(puVar9 + 1);
              lVar8 = Component.get_transform(this,0);
              if (lVar8 != null) {
                fVar1 = this.moveSpeed;
                puVar9 = (uint64 *)Transform.get_forward(local_48,lVar8,0);
                local_60 = *(float *)(puVar9 + 1);
                local_68 = *puVar9;
                fVar11 = (float)local_68;
                uVar4 = (uint64)local_68 >> 32;
                fVar10 = (float)Time.get_deltaTime(0);
                local_88 = (float)uVar2;
                fStack_84 = (float)((uint64)uVar2 >> 32);
                local_78 = CONCAT44((float)uVar4 * fVar1 * fVar10 + fStack_84,
                                    fVar11 * fVar1 * fVar10 + local_88);
                if (lVar7 != null) {
                  local_68 = local_78;
                  local_60 = local_60 * fVar1 * fVar10 + fVar3;
                  Transform.set_position(lVar7,&local_68,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000994
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
