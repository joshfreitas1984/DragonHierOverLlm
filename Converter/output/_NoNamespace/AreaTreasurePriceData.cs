// ============================================================
// Type  : AreaTreasurePriceData
// Token : 0x20001F0
// ============================================================

public class AreaTreasurePriceData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000D72
    public int treasureType;

    // Token: 0x4000D73
    public bool expensive;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000F6B
    // RVA   : 0x7F0190   Offset: 0x7EE990   Length: 0x36
    public void /*ctor*/(int _treasureType, bool _expensive)
    {
        ZhSegment.Initialize(this,0);
        this.treasureType = _treasureType;
        this.expensive = _expensive;
    }

    // Token : 0x6000F6C
    // RVA   : 0x7EFF60   Offset: 0x7EE760   Length: 0x14B
    public string GetDescribe()
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        uint uVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        if (!this.expensive) {
          uVar3 = *(uint64 *)(pStatics + 0x260);
          uVar4 = "{0}▼</color>";
        }
        else {
          uVar3 = *(uint64 *)(pStatics + 0x2c8);
          uVar4 = "{0}▲</color>";
        }
        uVar3 = String.Concat(uVar3,uVar4,0);
        lVar2 = *(int64 *)(pStatics + 0x508);
        if (lVar2 != null) {
          uVar1 = this.treasureType;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          String.Format(uVar3,*(uint64 *)
                                (*(int64 *)(lVar2 + 16) + 32 + (int64)(int)uVar1 * 8),0);
          return;
        }
    }

    // Token : 0x6000F6D
    // RVA   : 0x7F00B0   Offset: 0x7EE8B0   Length: 0xD8
    public string GetFullDescribe()
    {
        uint uVar1;
        long lVar2;
        ulong uVar3;
        uVar3 = "{0}类珍宝\n买卖价格减半";
        if (this.expensive) {
          uVar3 = "{0}类珍宝\n买卖价格翻倍";
        }
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x508);
        if (lVar2 != null) {
          uVar1 = this.treasureType;
          if (*(uint32 *)(lVar2 + 24) <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          String.Format(uVar3,*(uint64 *)
                                (*(int64 *)(lVar2 + 16) + 32 + (int64)(int)uVar1 * 8),0);
          return;
        }
    }

    // Token : 0x6000F6E
    // RVA   : 0x7EFDE0   Offset: 0x7EE5E0   Length: 0x175
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
