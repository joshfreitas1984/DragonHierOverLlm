// ============================================================
// Type  : SpeGridObjData
// Token : 0x2000189
// ============================================================

public class SpeGridObjData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000AAE
    public SpeGridObjType speGridObjType;

    // Token: 0x4000AAF
    public string name;

    // Token: 0x4000AB0
    public string describe;

    // Token: 0x4000AB1
    public bool destroyAfterTrigger;

    // Token: 0x4000AB2
    public float valueRate;

    // Token: 0x4000AB3
    public int teamID;

    // Token: 0x4000AB4
    public float hp;

    // Token: 0x4000AB5
    public float maxHp;

    // Token: 0x4000AB6
    public bool abovePlayer;

    // Token: 0x4000AB7
    public bool onGround;

    // Token: 0x4000AB8
    public string soundEffect;

    // Token: 0x4000AB9
    public bool flipX;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000CA2
    // RVA   : 0x9FEE00   Offset: 0x9FDC00   Length: 0xE
    public void /*ctor*/()
    {
        this.teamID = 0xffffffff;
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6000CA3
    // RVA   : 0x9FEDF0   Offset: 0x9FDBF0   Length: 0x10
    public float GetValueRate()
    {
        if (this.teamID == -1) {
          return this.valueRate;
        }
        return 0;
    }

    // Token : 0x6000CA4
    // RVA   : 0x9FED20   Offset: 0x9FDB20   Length: 0xC1
    public virtual object Clone()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181e84728);
        *(uint32 *)(lVar1 + 48) = 0xffffffff;
        ZhSegment.Initialize(lVar1,0);
        *(uint32 *)(lVar1 + 16) = this.speGridObjType;
        *(uint64 *)(lVar1 + 24) = this.name;
        *(uint64 *)(lVar1 + 32) = this.describe;
        *(uint8 *)(lVar1 + 40) = this.destroyAfterTrigger;
        *(uint32 *)(lVar1 + 44) = this.valueRate;
        *(uint32 *)(lVar1 + 48) = this.teamID;
        *(uint32 *)(lVar1 + 52) = this.hp;
        *(uint32 *)(lVar1 + 56) = this.maxHp;
        *(uint8 *)(lVar1 + 60) = this.abovePlayer;
        *(uint8 *)(lVar1 + 61) = this.onGround;
        *(uint64 *)(lVar1 + 64) = this.soundEffect;
        *(uint8 *)(lVar1 + 72) = this.flipX;
        return lVar1;
    }

}
