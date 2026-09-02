// ============================================================
// Type  : CFX_Demo_RandomDirectionTranslate
// Token : 0x20003B6
// ============================================================

public class CFX_Demo_RandomDirectionTranslate
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001D2A
    public float speed;

    // Token: 0x4001D2B
    public Vector3 baseDir;

    // Token: 0x4001D2C
    public Vector3 axis;

    // Token: 0x4001D2D
    public bool gravity;

    // Token: 0x4001D2E
    private Vector3 dir;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002358
    // RVA   : 0xBD4590   Offset: 0xBD2D90   Length: 0x137
    private void Start()
    {
        uint uVar2;
        uint uVar3;
        ulong local_58;
        uint local_50;
        uint local_40;
        byte[] local_38 = new byte[48];
        uVar2 = Random.Range(0,0x43b40000,0);
        uVar3 = Random.Range(0,0x43b40000,0);
        local_50 = Random.Range(0,0x43b40000,0);
        local_58 = CONCAT44(uVar3,uVar2);
        local_40 = local_50;
        puVar1 = (uint64 *)Vector3.get_normalized(local_38,&local_58,0);
        this.dir = *puVar1;
        *(uint32 *)(this + 64) = *(uint32 *)(puVar1 + 1);
        this.dir = (float)this.axis * this.dir;
        *(float *)(this + 60) = *(float *)(this + 44) * *(float *)(this + 60);
        *(float *)(this + 64) = *(float *)(this + 48) * *(float *)(this + 64);
        this.dir =
             CONCAT44((float)((uint64)this.dir >> 32) +
                      (float)((uint64)this.baseDir >> 32),
                      (float)this.baseDir + (float)this.dir);
        *(float *)(this + 64) = *(float *)(this + 64) + *(float *)(this + 36);
    }

    // Token : 0x6002359
    // RVA   : 0xBD46D0   Offset: 0xBD2ED0   Length: 0x16E
    private void Update()
    {
        ulong uVar1;
        long lVar2;
        float fVar4;
        float fVar5;
        ulong local_68;
        ulong local_58;
        float local_50;
        ulong local_48;
        float local_40;
        lVar2 = Component.get_transform(this,0);
        local_50 = *(float *)(this + 64);
        uVar1 = this.dir;
        fVar5 = this.speed;
        local_58 = uVar1;
        local_40 = local_50;
        fVar4 = (float)Time.get_deltaTime(0);
        local_68 = CONCAT44((float)((uint64)uVar1 >> 32) * fVar5 * fVar4,(float)uVar1 * fVar5 * fVar4
                           );
        local_48 = uVar1;
        if (lVar2 != null) {
          local_58 = local_68;
          local_50 = local_50 * fVar5 * fVar4;
          Transform.Translate(lVar2,&local_58,0);
          if (this.gravity) {
            lVar2 = Component.get_transform(this,0);
            puVar3 = (uint64 *)Physics.get_gravity(&local_48,0);
            local_50 = *(float *)(puVar3 + 1);
            uVar1 = *puVar3;
            fVar5 = (float)Time.get_deltaTime(0);
            local_68 = CONCAT44((float)((uint64)uVar1 >> 32) * fVar5,(float)uVar1 * fVar5);
            local_58 = uVar1;
            if (lVar2 == null) throw; // [null/range check failed]
            local_58 = local_68;
            local_50 = local_50 * fVar5;
            Transform.Translate(lVar2,&local_58,0);
          }
          return;
        }
    }

    // Token : 0x600235A
    // RVA   : 0xBD4840   Offset: 0xBD3040   Length: 0x55
    public void /*ctor*/()
    {
        byte[] local_18 = new byte[16];
        this.speed = 0x41f00000;
        puVar1 = (uint64 *)Vector3.get_zero(local_18,0);
        this.baseDir = *puVar1;
        *(uint32 *)(this + 36) = *(uint32 *)(puVar1 + 1);
        puVar1 = (uint64 *)Vector3.get_forward(local_18,0);
        this.axis = *puVar1;
        *(uint32 *)(this + 48) = *(uint32 *)(puVar1 + 1);
        FUN_18044ef50(this,0);
    }

}
