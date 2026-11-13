// ============================================================
// Type  : InnData
// Token : 0x20001FA
// ============================================================

public class InnData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000E18
    public int id;

    // Token: 0x4000E19
    public string innName;

    // Token: 0x4000E1A
    public string describe;

    // Token: 0x4000E1B
    public ItemListData shopItemList;

    // Token: 0x4000E1C
    public BigMapPos bigMapPos;

    // Token: 0x4000E1D
    public List<int> nearAreaID;

    // Token: 0x4000E1E
    public bool haveSpeEvent;

    // Token: 0x4000E1F
    public int plotNumCount;

    // Token: 0x4000E20
    public int missionNumCount;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000FB2
    // RVA   : 0xA1BF40   Offset: 0xA1AD40   Length: 0xFF
    public void /*ctor*/(int _id, string _innName)
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        this.innName = _innName;
        this.id = _id;
        this.shopItemList = new ItemListData(0);
        this.bigMapPos = new c.DisplayClass9_0(0);
        uVar1 = il2cpp_internal(DAT_181e73cb8);
        FUN_1810f3480(uVar1,DAT_181e71270);
        this.nearAreaID = uVar1;
    }

    // Token : 0x6000FB3
    // RVA   : 0xA1BDC0   Offset: 0xA1ABC0   Length: 0x175
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
        plVar1 = (int64 *)il2cpp_internal(DAT_181e695f0);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181e91a00);
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
            FUN_180002280(0,DAT_181e58ab8,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
    }

}
