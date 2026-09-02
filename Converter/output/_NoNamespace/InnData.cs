// ============================================================
// Type  : InnData
// Token : 0x20001F2
// ============================================================

public class InnData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000D76
    public int id;

    // Token: 0x4000D77
    public string innName;

    // Token: 0x4000D78
    public string describe;

    // Token: 0x4000D79
    public ItemListData shopItemList;

    // Token: 0x4000D7A
    public BigMapPos bigMapPos;

    // Token: 0x4000D7B
    public List<int> nearAreaID;

    // Token: 0x4000D7C
    public bool haveSpeEvent;

    // Token: 0x4000D7D
    public int plotNumCount;

    // Token: 0x4000D7E
    public int missionNumCount;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000F72
    // RVA   : 0xB6FEA0   Offset: 0xB6E6A0   Length: 0xFF
    public void /*ctor*/(int _id, string _innName)
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        this.innName = _innName;
        this.id = _id;
        this.shopItemList = new ItemListData(0);
        this.bigMapPos = new c.DisplayClass9_0(0);
        uVar1 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(uVar1,DAT_181d678f8);
        this.nearAreaID = uVar1;
    }

    // Token : 0x6000F73
    // RVA   : 0xB6FD20   Offset: 0xB6E520   Length: 0x175
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
        plVar1 = (int64 *)il2cpp_internal(DAT_181d63ff0);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181d8c5a8);
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
            FUN_180002970(0,DAT_181d53c70,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

}
