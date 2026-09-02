// ============================================================
// Type  : TextFit
// Token : 0x2000393
// ============================================================

public class TextFit
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001C66
    private readonly string strRegex;

    // Token: 0x4001C67
    private StringBuilder MExplainText;

    // Token: 0x4001C68
    private IList<UILineInfo> MExpalinTextLine;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002264
    // RVA   : 0xABF6E0   Offset: 0xABDEE0   Length: 0xBC
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
          FUN_180d837c0(this,lVar2,0);
          return;
        }
    }

    // Token : 0x6002265
    // RVA   : 0xABF630   Offset: 0xABDE30   Length: 0xA4
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

    // Token : 0x6002266
    // RVA   : 0xABF7A0   Offset: 0xABDFA0   Length: 0x74
    public void /*ctor*/()
    {
        this.strRegex = "\\p{P}(?<![《“(])";
        Text.ctor(this,0);
    }

}
