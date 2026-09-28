// ============================================================
// Type  : Water2DScript
// Token : 0x20003DF
// ============================================================

public class Water2DScript
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001EF2
    public Vector2 speed;

    // Token: 0x4001EF3
    private Renderer rend;

    // Token: 0x4001EF4
    private Material mat;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600245F
    // RVA   : 0xC132D0   Offset: 0xC126D0   Length: 0x76
    private void Awake()
    {
        ulong uVar1;
        uVar1 = Component.GetComponent(this,DAT_181d94fe0);
        this.rend = uVar1;
        if (this.rend != null) {
          uVar1 = FUN_180d9d700(this.rend,0);
          this.mat = uVar1;
          return;
        }
    }

    // Token : 0x6002460
    // RVA   : 0xC13350   Offset: 0xC12750   Length: 0x7E
    private void LateUpdate()
    {
        float fVar1;
        float fVar2;
        long lVar3;
        ulong uVar4;
        float fVar5;
        uint local_res8;
        uint32 uStackX_c;
        fVar5 = (float)Time.get_deltaTime(0);
        fVar1 = this.speed;
        fVar2 = *(float *)(this + 28);
        lVar3 = this.mat;
        if (lVar3 != null) {
          uVar4 = Material.get_mainTextureOffset(lVar3,0);
          uStackX_c = (float)((uint64)uVar4 >> 32);
          local_res8 = (float)uVar4;
          Material.set_mainTextureOffset
                    (lVar3,CONCAT44(uStackX_c + fVar2 * fVar5,fVar1 * fVar5 + local_res8),0);
          return;
        }
    }

    // Token : 0x6002461
    // RVA   : 0xC133D0   Offset: 0xC127D0   Length: 0xF
    public void /*ctor*/()
    {
        void FUN_180c133d0(int64 this)
        {
        this.speed = 0x3c23d70a;
        FUN_18044ef50(this,0);
    }

}
