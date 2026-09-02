// ============================================================
// Type  : CFX_AutoRotate
// Token : 0x20003BA
// ============================================================

public class CFX_AutoRotate
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001D36
    public Vector3 rotation;

    // Token: 0x4001D37
    public Space space;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002367
    // RVA   : 0xBD3800   Offset: 0xBD2000   Length: 0xA5
    private void Update()
    {
        ulong uVar1;
        long lVar2;
        float fVar3;
        ulong local_28;
        float local_20;
        lVar2 = Component.get_transform(this,0);
        local_20 = *(float *)(this + 32);
        uVar1 = this.rotation;
        fVar3 = (float)Time.get_deltaTime(0);
        if (lVar2 != null) {
          local_28 = CONCAT44((float)((uint64)uVar1 >> 32) * fVar3,(float)uVar1 * fVar3);
          local_20 = local_20 * fVar3;
          Transform.Rotate(lVar2,&local_28,this.space,0);
          return;
        }
        local_28 = uVar1;
    }

    // Token : 0x6002368
    // RVA   : 0xBD38B0   Offset: 0xBD20B0   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_180bd38b0(int64 this)
        {
        this.space = 1;
        FUN_18044ef50(this,0);
    }

}
