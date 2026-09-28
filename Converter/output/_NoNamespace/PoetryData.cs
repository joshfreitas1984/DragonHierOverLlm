// ============================================================
// Type  : PoetryData
// Token : 0x200024E
// ============================================================

public class PoetryData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400128D
    public string title;

    // Token: 0x400128E
    public string author;

    // Token: 0x400128F
    public List<PoetryParagraphData> paragraphs;

    // Token: 0x4001290
    public List<int> availableParagraphLength;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001320
    // RVA   : 0xB0DCE0   Offset: 0xB0D0E0   Length: 0xBB
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        uVar1 = il2cpp_internal(DAT_181d95350);
        FUN_18132faf0(uVar1,DAT_181d97888);
        this.paragraphs = uVar1;
        uVar1 = il2cpp_internal(DAT_181d93cd0);
        FUN_18132faf0(uVar1,DAT_181d8f098);
        this.availableParagraphLength = uVar1;
    }

    // Token : 0x6001321
    // RVA   : 0xB0DB60   Offset: 0xB0CF60   Length: 0x175
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
        plVar1 = (int64 *)il2cpp_internal(DAT_181d89210);
        plVar4 = plVar1;
        MemoryStream.ctor(plVar1,1000,0);
        local_38 = 0;
        uStack_30 = 0;
        StreamingContext.ctor(&local_38,64,0);
        lVar2 = il2cpp_internal(DAT_181db1730);
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
            FUN_180002970(0,DAT_181d78da0,plVar1);
            return uVar3;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

}
