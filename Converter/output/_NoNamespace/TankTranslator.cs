// ============================================================
// Type  : TankTranslator
// Token : 0x200012A
// ============================================================

public class TankTranslator
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400073B
    public float TranslateDistance;

    // Token: 0x400073C
    public bool TrailTranslationEnabled;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60009AF
    // RVA   : 0x80C820   Offset: 0x80B620   Length: 0x238
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
        cVar2 = FUN_181844860(97);
        if (!cVar2) {
          cVar2 = FUN_181844860(100);
          if (cVar2) {
            lVar4 = Component.get_transform(this,0);
            if (lVar4 == null) goto LAB_18080ca53;
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
          if (lVar4 == null) goto LAB_18080ca53;
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
        LAB_18080ca53:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          local_38 = CONCAT44(fVar8,fVar9);
          local_30 = fVar7;
          Transform.Translate(lVar4,&local_38,0);
          if (this.TrailTranslationEnabled) {
            lVar4 = FUN_180772590(this,DAT_181e7bcb8);
            uVar6 = 0;
            if (lVar4 == null) goto LAB_18080ca53;
            for (; (int)uVar6 < (int)*(uint32 *)(lVar4 + 24); uVar6 = uVar6 + 1) {
              if (*(uint32 *)(lVar4 + 24) <= uVar6) {
                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar5,0);
              }
              lVar1 = lVar4[uVar6];
              if (lVar1 == null) goto LAB_18080ca53;
              local_38 = CONCAT44(fVar8,fVar9);
              local_30 = fVar7;
              TrailRenderer_Base.Translate(lVar1,&local_38,0);
            }
          }
        }
    }

    // Token : 0x60009B0
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
