// ============================================================
// Type  : InnData
// Token : 0x20001F8
// ============================================================

public class InnData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000E04
    public int id;

    // Token: 0x4000E05
    public string innName;

    // Token: 0x4000E06
    public string describe;

    // Token: 0x4000E07
    public ItemListData shopItemList;

    // Token: 0x4000E08
    public BigMapPos bigMapPos;

    // Token: 0x4000E09
    public List<int> nearAreaID;

    // Token: 0x4000E0A
    public bool haveSpeEvent;

    // Token: 0x4000E0B
    public int plotNumCount;

    // Token: 0x4000E0C
    public int missionNumCount;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000FA9
    // RVA   : 0xC9A2E0   Offset: 0xC996E0   Length: 0xFF
    public void /*ctor*/(int _id, string _innName)
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        this.innName = _innName;
        this.id = _id;
        this.shopItemList = new ItemListData(0);
        this.bigMapPos = new c.DisplayClass9_0(0);
        uVar1 = il2cpp_internal(DAT_181d93ce8);
        FUN_181330100(uVar1,DAT_181d8f0b0);
        this.nearAreaID = uVar1;
    }

    // Token : 0x6000FAA
    // RVA   : 0xC9A160   Offset: 0xC99560   Length: 0x175
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
