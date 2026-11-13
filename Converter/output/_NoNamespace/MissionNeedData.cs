// ============================================================
// Type  : MissionNeedData
// Token : 0x200024F
// ============================================================

public class MissionNeedData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400127B
    public MissionTargetType missionTargetType;

    // Token: 0x400127C
    public string missionTargetID;

    // Token: 0x400127D
    public int missionResourceNeed;

    // Token: 0x400127E
    public float missionNumCount;

    // Token: 0x400127F
    public float missionNumNeed;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600132C
    // RVA   : 0x847CB0   Offset: 0x846AB0   Length: 0x82
    public virtual object Clone()
    {
        long lVar1;
        lVar1 = new ZhSegment(0);
        if (lVar1 != null) {
          *(uint32 *)(lVar1 + 16) = this.missionTargetType;
          *(uint64 *)(lVar1 + 24) = this.missionTargetID;
          *(uint32 *)(lVar1 + 32) = this.missionResourceNeed;
          *(uint32 *)(lVar1 + 36) = this.missionNumCount;
          *(uint32 *)(lVar1 + 40) = this.missionNumNeed;
          return lVar1;
        }
    }

    // Token : 0x600132D
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

}
