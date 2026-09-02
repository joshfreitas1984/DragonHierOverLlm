// ============================================================
// Type  : ZhSegment
// Token : 0x200042B
// ============================================================

public class ZhSegment
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001FB7
    public static Func<string, IEnumerable<string>> Segment;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60025A4
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    public static void Initialize(string jiebaResourceDirectory)
    {
    }

    // Token : 0x60025A5
    // RVA   : 0xB1A870   Offset: 0xB19070   Length: 0xA3
    private static IEnumerable<string> SegmentByJieba(string text)
    {
        long lVar2;
        ulong uVar3;
        plVar1 = (int64 *)FUN_1800d60b0(DAT_181d80cc0,1);
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

    // Token : 0x60025A6
    // RVA   : 0xB1A920   Offset: 0xB19120   Length: 0x8B
    private static void /*cctor*/()
    {
        ulong uVar2;
        uVar2 = new OnTooltipCB(0,DAT_181d90fb0,DAT_181d8bb30);
        puVar1 = *(uint64 **)(DAT_181d6c588 + 184);
        *puVar1 = uVar2;
        il2cpp_internal(puVar1,uVar2);
    }

}
