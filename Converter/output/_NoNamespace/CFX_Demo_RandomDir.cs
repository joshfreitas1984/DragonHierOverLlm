// ============================================================
// Type  : CFX_Demo_RandomDir
// Token : 0x20003B5
// ============================================================

public class CFX_Demo_RandomDir
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001D28
    public Vector3 min;

    // Token: 0x4001D29
    public Vector3 max;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002356
    // RVA   : 0xBD4490   Offset: 0xBD2C90   Length: 0xA5
    private void Awake()
    {
        void CFX_Demo_RandomDir.Awake
                     (int64 this,uint64 param_2,uint64 param_3,uint64 param_4)
        {
        int64 lVar1;
        uint32 uVar2;
        uint32 uVar3;
        uint64 local_28;
        uint32 local_20;
        lVar1 = Component.get_transform(this,0);
        uVar2 = Random.Range(this.min,this.max,0);
        uVar3 = Random.Range(*(uint32 *)(this + 28),*(uint32 *)(this + 40),0);
        local_20 = Random.Range(*(uint32 *)(this + 32),*(uint32 *)(this + 44),0,param_4
                                 ,uVar2);
        if (lVar1 != null) {
          local_28 = CONCAT44(uVar3,uVar2);
          Transform.set_eulerAngles(lVar1,&local_28,0);
          return;
        }
    }

    // Token : 0x6002357
    // RVA   : 0xBD4540   Offset: 0xBD2D40   Length: 0x4E
    public void /*ctor*/()
    {
        this.min = 0;
        *(uint32 *)(this + 32) = 0;
        this.max = 0x43b4000000000000;
        *(uint32 *)(this + 44) = 0;
        FUN_18044ef50(0,0);
    }

}
