// ============================================================
// Type  : PoetryData
// Token : 0x2000252
// ============================================================

public class PoetryData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40012AB
    public string title;

    // Token: 0x40012AC
    public string author;

    // Token: 0x40012AD
    public List<PoetryParagraphData> paragraphs;

    // Token: 0x40012AE
    public List<int> availableParagraphLength;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001344
    // RVA   : 0x8B0850   Offset: 0x8AF650   Length: 0xBB
    public void /*ctor*/()
    {
        ulong uVar1;
        ZhSegment.Initialize(this,0);
        uVar1 = il2cpp_internal(DAT_181e75338);
        FUN_1810f3480(uVar1,DAT_181e79ce0);
        this.paragraphs = uVar1;
        uVar1 = il2cpp_internal(DAT_181e73cb8);
        FUN_1810f3480(uVar1,DAT_181e71270);
        this.availableParagraphLength = uVar1;
    }

    // Token : 0x6001345
    // RVA   : 0x8B06D0   Offset: 0x8AF4D0   Length: 0x175
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
