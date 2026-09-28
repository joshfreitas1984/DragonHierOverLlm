// ============================================================
// Type  : TextFit
// Token : 0x200039A
// ============================================================

public class TextFit
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001D6B
    private readonly string strRegex;

    // Token: 0x4001D6C
    private StringBuilder MExplainText;

    // Token: 0x4001D6D
    private IList<UILineInfo> MExpalinTextLine;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60022E6
    // RVA   : 0xA9EDC0   Offset: 0xA9E1C0   Length: 0xBC
    protected override void OnPopulateMesh(VertexHelper toFill)
    {
        ulong uVar1;
        long lVar2;
        Text.OnPopulateMesh(this,toFill,0);
        uVar1 = (**(code **)(*this + 0x5d8))(this,*(uint64 *)(*this + 0x5e0));
        lVar2 = new WarpText_d__8(0,0);
        if (lVar2 != null) {
          *(uint64 *)(lVar2 + 48) = this;
          *(uint64 *)(lVar2 + 32) = this;
          *(uint64 *)(lVar2 + 40) = uVar1;
          FUN_180d8c2e0(this,lVar2,0);
          return;
        }
    }

    // Token : 0x60022E7
    // RVA   : 0xA9ED10   Offset: 0xA9E110   Length: 0xA4
    private IEnumerator MClearUpExplainMode(Text _component, string _text)
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 48) = this;
          *(uint64 *)(lVar1 + 32) = _component;
          *(uint64 *)(lVar1 + 40) = _text;
          return lVar1;
        }
    }

    // Token : 0x60022E8
    // RVA   : 0xA9EE80   Offset: 0xA9E280   Length: 0x74
    public void /*ctor*/()
    {
        this.strRegex = "\\p{P}(?<![《“(])";
        Text.ctor(this,0);
    }

}
