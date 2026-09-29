// ============================================================
// Type  : ExploreMapData
// Token : 0x200026C
// ============================================================

public class ExploreMapData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001378
    public string exploreName;

    // Token: 0x4001379
    public string spriteName;

    // Token: 0x400137A
    public BigMapPos bigMapPos;

    // Token: 0x400137B
    public float exploreDifficulty;

    // Token: 0x400137C
    public List<ExplorePanelData> exploreMapData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60013FD
    // RVA   : 0xB25330   Offset: 0xB24730   Length: 0x76
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        uVar1 = il2cpp_internal(DAT_181d928f0);
        FUN_181330100(uVar1,DAT_181d86e38);
        this.exploreMapData = uVar1;
    }

    // Token : 0x60013FE
    // RVA   : 0xB251B0   Offset: 0xB245B0   Length: 0x175
    public virtual object Clone()
    {
        long lVar2;
        ulong uVar3;
        ulong local_38;
        ulong uStack_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        plVar1 = (int64 *)il2cpp_internal(DAT_181d89228);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181db1748);
        local_28 = (uint32)local_38;
        uStack_24 = local_38._4_4_;
        uStack_20 = (uint32)uStack_30;
        uStack_1c = uStack_30._4_4_;
        BinaryFormatter.ctor(lVar2,0,&local_28,0,plVar4);
        if (lVar2 != null) {
          BinaryFormatter.Serialize(lVar2,plVar1,this,0);
          if (plVar1 != (int64 *)0) {
            (**(code **)(*plVar1 + 0x2c8))(plVar1,0,0,*(uint64 *)(*plVar1 + 0x2d0));
            uVar3 = BinaryFormatter.Deserialize(lVar2,plVar1,0);
            (**(code **)(*plVar1 + 0x238))(plVar1,*(uint64 *)(*plVar1 + 0x240));
            FUN_180002970(0,DAT_181d78db8,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

}
