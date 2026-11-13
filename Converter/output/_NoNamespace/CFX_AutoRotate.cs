// ============================================================
// Type  : CFX_AutoRotate
// Token : 0x20003CE
// ============================================================

public class CFX_AutoRotate
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001ED3
    public Vector3 rotation;

    // Token: 0x4001ED4
    public Space space;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002494
    // RVA   : 0x937A00   Offset: 0x936800   Length: 0xA5
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

    // Token : 0x6002495
    // RVA   : 0x937AB0   Offset: 0x9368B0   Length: 0xE
    public void /*ctor*/()
    {
        void FUN_180937ab0(int64 this)
        {
        this.space = 1;
        FUN_180ae8740(this,0);
    }

}
