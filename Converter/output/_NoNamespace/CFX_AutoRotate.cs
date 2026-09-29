// ============================================================
// Type  : CFX_AutoRotate
// Token : 0x20003C1
// ============================================================

public class CFX_AutoRotate
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001E41
    public Vector3 rotation;

    // Token: 0x4001E42
    public Space space;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60023EA
    // RVA   : 0xB7E750   Offset: 0xB7DB50   Length: 0xA5
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

    // Token : 0x60023EB
    // RVA   : 0xB7E800   Offset: 0xB7DC00   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_180b7e800(int64 this)
        {
        this.space = 1;
        FUN_18044ef50(this,0);
    }

}
