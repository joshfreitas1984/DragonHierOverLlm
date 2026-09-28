// ============================================================
// Type  : MoveWithMouse
// Token : 0x200030E
// ============================================================

public class MoveWithMouse
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001935
    public float range;

    // Token: 0x4001936
    private Vector2 mRot;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600196A
    // RVA   : 0xDF40C0   Offset: 0xDF34C0   Length: 0x1F8
    private void Update()
    {
        float fVar1;
        float fVar2;
        ulong uVar3;
        int iVar4;
        long lVar6;
        float fVar7;
        float fVar8;
        float fVar9;
        float fVar10;
        ulong uVar11;
        uint uVar12;
        float fVar13;
        ulong local_88;
        uint local_80;
        uVar11 = RealTime.get_deltaTime(0);
        puVar5 = (uint64 *)Input.get_mousePosition(&local_88,0);
        uVar3 = *puVar5;
        uVar12 = (uint32)((uint64)uVar3 >> 32);
        local_80 = *(uint32 *)(puVar5 + 1);
        iVar4 = Screen.get_width(0);
        fVar13 = (float)iVar4 * 0.5;
        iVar4 = Screen.get_height(0);
        Screen.get_width(0);
        fVar7 = (float)FUN_1810e36c0(uVar3,0);
        fVar8 = (float)FUN_1810e36c0((fVar7 - fVar13) / fVar13,0xbf800000);
        Screen.get_height(0);
        local_88 = uVar3;
        fVar7 = (float)FUN_1810e36c0(CONCAT44(uVar12,uVar12),0);
        fVar9 = (float)FUN_1810e36c0((fVar7 - (float)iVar4 * 0.5) / fVar13,0xbf800000);
        fVar7 = this.range;
        fVar13 = this.mRot;
        fVar1 = *(float *)(this + 32);
        fVar2 = this.range;
        fVar10 = (float)Mathf.Clamp01(uVar11,0);
        this.mRot = (-fVar8 * fVar2 - fVar13) * fVar10 + fVar13;
        *(float *)(this + 32) = (-fVar9 * fVar7 - fVar1) * fVar10 + fVar1;
        lVar6 = Component.get_transform(this,0);
        if (lVar6 != null) {
          local_80 = 0;
          local_88 = this.mRot;
          Transform.set_localPosition(lVar6,&local_88,0);
          return;
        }
    }

    // Token : 0x600196B
    // RVA   : 0xDF42C0   Offset: 0xDF36C0   Length: 0x41
    public void /*ctor*/()
    {
        ulong uVar1;
        uint local_res8;
        uint32 uStackX_c;
        this.range = 0x3f800000;
        uVar1 = Vector2.get_zero(0);
        local_res8 = (uint32)uVar1;
        uStackX_c = (uint32)((uint64)uVar1 >> 32);
        this.mRot = local_res8;
        *(uint32 *)(this + 32) = uStackX_c;
        FUN_18044ef50(this,0);
    }

}
