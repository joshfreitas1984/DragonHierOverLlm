// ============================================================
// Type  : EquipPoisonData
// Token : 0x200023D
// ============================================================

public class EquipPoisonData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40011F4
    public float poisonNum;

    // Token: 0x40011F5
    public HeroSpeAddData poisonBuffData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60012D6
    // RVA   : 0x68AA00   Offset: 0x689800   Length: 0x65
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        this.poisonBuffData = new HeroSpeAddData(0);
    }

    // Token : 0x60012D7
    // RVA   : 0x68A9A0   Offset: 0x6897A0   Length: 0x52
    public HeroSpeAddData GetPoisonBuffData()
    {
        bool cVar1;
        ulong uVar2;
        if ((this.poisonNum == null.0) &&
           ((this.poisonBuffData == null ||
            (cVar1 = HeroSpeAddData.isEmpty(this.poisonBuffData,0), cVar1)))) {
          return 0;
        }
        uVar2 = HeroSpeAddData.op_Multiply
                          (this.poisonBuffData,this.poisonNum / 100.0,0);
        return uVar2;
    }

    // Token : 0x60012D8
    // RVA   : 0x68A880   Offset: 0x689680   Length: 0x117
    public virtual object Clone()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = new ZhSegment(0);
        uVar2 = new HeroSpeAddData(0);
        *(uint64 *)(lVar1 + 24) = uVar2;
        *(uint32 *)(lVar1 + 16) = this.poisonNum;
        plVar3 = (int64 *)0;
        if (this.poisonBuffData != null) {
          plVar3 = (int64 *)HeroSpeAddData.Clone();
        }
        *(int64 **)(lVar1 + 24) = plVar3;
        return lVar1;
    }

}
