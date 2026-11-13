// ============================================================
// Type  : MaterialData
// Token : 0x2000246
// ============================================================

public class MaterialData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001230
    public HeroSpeAddData extraAddData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001314
    // RVA   : 0x7D2100   Offset: 0x7D0F00   Length: 0x65
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        this.extraAddData = new HeroSpeAddData(0);
    }

    // Token : 0x6001315
    // RVA   : 0x7D1FE0   Offset: 0x7D0DE0   Length: 0x111
    public virtual object Clone()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = new ZhSegment(0);
        uVar2 = new HeroSpeAddData(0);
        *(uint64 *)(lVar1 + 16) = uVar2;
        plVar3 = (int64 *)0;
        if (this.extraAddData != null) {
          plVar3 = (int64 *)HeroSpeAddData.Clone();
        }
        *(int64 **)(lVar1 + 16) = plVar3;
        return lVar1;
    }

}
