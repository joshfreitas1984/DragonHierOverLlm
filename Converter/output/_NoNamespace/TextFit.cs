// ============================================================
// Type  : TextFit
// Token : 0x20003A7
// ============================================================

public class TextFit
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001DFE
    private readonly string strRegex;

    // Token: 0x4001DFF
    private StringBuilder MExplainText;

    // Token: 0x4001E00
    private IList<UILineInfo> MExpalinTextLine;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002390
    // RVA   : 0x80E7C0   Offset: 0x80D5C0   Length: 0xBC
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
          FUN_180ae80b0(this,lVar2,0);
          return;
        }
    }

    // Token : 0x6002391
    // RVA   : 0x80E710   Offset: 0x80D510   Length: 0xA4
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

    // Token : 0x6002392
    // RVA   : 0x80E880   Offset: 0x80D680   Length: 0x74
    public void /*ctor*/()
    {
        this.strRegex = "\\p{P}(?<![《“(])";
        Text.ctor(this,0);
    }

}
