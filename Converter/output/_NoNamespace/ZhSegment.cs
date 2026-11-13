// ============================================================
// Type  : ZhSegment
// Token : 0x200043F
// ============================================================

public class ZhSegment
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4002155
    public static Func<string, IEnumerable<string>> Segment;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60026D1
    // RVA   : 0x51CF50   Offset: 0x51BD50   Length: 0x3
    public static void Initialize(string jiebaResourceDirectory)
    {
    }

    // Token : 0x60026D2
    // RVA   : 0x1787DB0   Offset: 0x1786BB0   Length: 0xA3
    private static IEnumerable<string> SegmentByJieba(string text)
    {
        long lVar2;
        ulong uVar3;
        plVar1 = (int64 *)FUN_1801dfd90(DAT_181e85e38,1);
        if (plVar1 == (int64 *)0) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        if (text != null) {
          lVar2 = il2cpp_internal(text,*(uint64 *)(*plVar1 + 64));
          if (lVar2 == null) {
            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar3,0);
          }
        }
        if ((int)plVar1[3] != 0) {
          plVar1[4] = text;
          il2cpp_internal(plVar1 + 4,text);
          return plVar1;
        }
        uVar3 = il2cpp_internal();
    }

    // Token : 0x60026D3
    // RVA   : 0x1787E60   Offset: 0x1786C60   Length: 0x8B
    private static void /*cctor*/()
    {
        ulong uVar2;
        uVar2 = new OnTooltipCB(0,DAT_181e9e250,DAT_181e949c8);
        puVar1 = *(uint64 **)(DAT_181e72110 + 184);
        *puVar1 = uVar2;
        il2cpp_internal(puVar1,uVar2);
    }

}
