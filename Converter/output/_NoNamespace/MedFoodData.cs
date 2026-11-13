// ============================================================
// Type  : MedFoodData
// Token : 0x2000243
// ============================================================

public class MedFoodData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001225
    public int enhanceLv;

    // Token: 0x4001226
    public ChangeHeroStateData changeHeroState;

    // Token: 0x4001227
    public int randomSpeAddValue;

    // Token: 0x4001228
    public HeroSpeAddData extraAddData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600130A
    // RVA   : 0x7D2350   Offset: 0x7D1150   Length: 0x24
    public ChangeHeroStateData GetChangeHeroStateData()
    {
        ChangeHeroStateData.op_Multiply
                  (this.changeHeroState,(float)this.enhanceLv * 0.1 + 1.0,0);
    }

    // Token : 0x600130B
    // RVA   : 0x7D2380   Offset: 0x7D1180   Length: 0x99
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        this.changeHeroState = new ChangeHeroStateData(0);
        this.extraAddData = new HeroSpeAddData(0);
    }

    // Token : 0x600130C
    // RVA   : 0x7D2170   Offset: 0x7D0F70   Length: 0x1D9
    public virtual object Clone()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = new ZhSegment(0);
        uVar2 = new ChangeHeroStateData(0);
        *(uint64 *)(lVar1 + 24) = uVar2;
        uVar2 = new HeroSpeAddData(0);
        *(uint64 *)(lVar1 + 40) = uVar2;
        *(uint32 *)(lVar1 + 16) = this.enhanceLv;
        *(uint32 *)(lVar1 + 32) = this.randomSpeAddValue;
        if (this.changeHeroState == null) {
          plVar3 = (int64 *)0;
        }
        else {
          plVar3 = (int64 *)ChangeHeroStateData.Clone(this.changeHeroState,0);
        }
        *(int64 **)(lVar1 + 24) = plVar3;
        plVar3 = (int64 *)0;
        if ((this.extraAddData != null) &&
           (plVar4 = (int64 *)HeroSpeAddData.Clone(this.extraAddData,0),
           plVar4 != (int64 *)0)) {
        }
        *(int64 **)(lVar1 + 40) = plVar3;
        return lVar1;
    }

}
