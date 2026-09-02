// ============================================================
// Type  : TankTranslator
// Token : 0x200012A
// ============================================================

public class TankTranslator
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400073F
    public float TranslateDistance;

    // Token: 0x4000740
    public bool TrailTranslationEnabled;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60009B0
    // RVA   : 0xABD830   Offset: 0xABC030   Length: 0x238
    private void Update()
    {
        long lVar1;
        bool cVar2;
        long lVar4;
        ulong uVar5;
        uint uVar6;
        float fVar7;
        float fVar8;
        float fVar9;
        ulong local_48;
        float local_40;
        ulong local_38;
        float local_30;
        byte[] local_28 = new byte[32];
        puVar3 = (uint64 *)Vector3.get_zero(&local_38,0);
        fVar9 = (float)*puVar3;
        fVar8 = (float)((uint64)*puVar3 >> 32);
        fVar7 = *(float *)(puVar3 + 1);
        cVar2 = FUN_1804625b0(97);
        if (!cVar2) {
          cVar2 = FUN_1804625b0(100);
          if (cVar2) {
            lVar4 = Component.get_transform(this,0);
            if (lVar4 == null) goto LAB_180abda63;
            puVar3 = (uint64 *)Transform.get_right(local_28,lVar4,0);
            local_48 = *puVar3;
            local_40 = *(float *)(puVar3 + 1);
            fVar7 = this.TranslateDistance;
            fVar9 = -(float)local_48 * fVar7;
            fVar8 = -(float)((uint64)local_48 >> 32) * fVar7;
            fVar7 = -local_40 * fVar7;
            local_38 = local_48;
            local_30 = fVar7;
          }
        }
        else {
          lVar4 = Component.get_transform(this);
          if (lVar4 == null) goto LAB_180abda63;
          fVar7 = this.TranslateDistance;
          puVar3 = (uint64 *)Transform.get_right(local_28,lVar4,0);
          local_48 = *puVar3;
          local_40 = *(float *)(puVar3 + 1);
          fVar8 = (float)((uint64)local_48 >> 32) * fVar7;
          fVar9 = (float)local_48 * fVar7;
          fVar7 = local_40 * fVar7;
          local_38 = local_48;
          local_30 = fVar7;
        }
        puVar3 = (uint64 *)Vector3.get_zero(local_28,0);
        local_38 = CONCAT44(fVar8,fVar9);
        local_48 = *puVar3;
        local_40 = *(float *)(puVar3 + 1);
        local_30 = fVar7;
        cVar2 = Vector3.op_Inequality(&local_38,&local_48,0);
        if (cVar2) {
          lVar4 = Component.get_transform(this,0);
          if (lVar4 == null) {
        LAB_180abda63:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          local_38 = CONCAT44(fVar8,fVar9);
          local_30 = fVar7;
          Transform.Translate(lVar4,&local_38,0);
          if (this.TrailTranslationEnabled) {
            lVar4 = FUN_180956bf0(this,DAT_181d6ffc0);
            uVar6 = 0;
            if (lVar4 == null) goto LAB_180abda63;
            for (; (int)uVar6 < (int)*(uint32 *)(lVar4 + 24); uVar6 = uVar6 + 1) {
              if (*(uint32 *)(lVar4 + 24) <= uVar6) {
                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar5,0);
              }
              lVar1 = lVar4[uVar6];
              if (lVar1 == null) goto LAB_180abda63;
              local_38 = CONCAT44(fVar8,fVar9);
              local_30 = fVar7;
              TrailRenderer_Base.Translate(lVar1,&local_38,0);
            }
          }
        }
    }

    // Token : 0x60009B1
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
