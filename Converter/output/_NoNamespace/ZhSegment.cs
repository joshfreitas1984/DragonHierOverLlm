// ============================================================
// Type  : ZhSegment
// Token : 0x2000432
// ============================================================

public class ZhSegment
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40020C2
    public static Func<string, IEnumerable<string>> Segment;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002627
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    public static void Initialize(string jiebaResourceDirectory)
    {
    }

    // Token : 0x6002628
    // RVA   : 0x1846950   Offset: 0x1845D50   Length: 0xA3
    private static IEnumerable<string> SegmentByJieba(string text)
    {
        long lVar2;
        ulong uVar3;
        plVar1 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,1);
        if (plVar1 == (int64 *)0) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (text != null) {
          lVar2 = il2cpp_internal(text,*(uint64 *)(*plVar1 + 64));
          if (lVar2 == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar3,0);
          }
        }
        if ((int)plVar1[3] != 0) {
          plVar1[4] = text;
          il2cpp_internal(plVar1 + 4,text);
          return plVar1;
        }
        uVar3 = il2cpp_internal();
    }

    // Token : 0x6002629
    // RVA   : 0x1846A00   Offset: 0x1845E00   Length: 0x8B
    private static void /*cctor*/()
    {
        ulong uVar2;
        uVar2 = new OnTooltipCB(0,DAT_181dba4d0,DAT_181db28c8);
        puVar1 = *(uint64 **)(DAT_181d91948 + 184);
        *puVar1 = uVar2;
        il2cpp_internal(puVar1,uVar2);
    }

}
