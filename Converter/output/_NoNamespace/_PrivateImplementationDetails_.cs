// ============================================================
// Type  : <PrivateImplementationDetails>
// Token : 0x200048C
// ============================================================

public class <PrivateImplementationDetails>
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400205C
    internal static readonly __StaticArrayInitTypeSize=32 07F953EB3DB1131FBDB6AA2748FD8EC70F792C02BF125F3577B8988B69AF80B0;

    // Token: 0x400205D
    internal static readonly __StaticArrayInitTypeSize=10 2BB47FF64195EADBDFAF6D62F95A5190EF909363CCA70584BE479841A1C94165;

    // Token: 0x400205E
    internal static readonly __StaticArrayInitTypeSize=580 6383AD8D3ACB5400C9BB99B6431A223D7472A06120C1C15C09458B0FCB291E2B;

    // Token: 0x400205F
    internal static readonly long A553BADB17A168A36B44DA9D26F99CB2EEC465BFD5E69C5D695D0F2F66629EF5;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60026F8
    // RVA   : 0x3FF9F0   Offset: 0x3FE1F0   Length: 0x55
    internal static uint ComputeStringHash(string s)
    {
        ushort uVar1;
        uint uVar2;
        uint uVar3;
        uVar2 = 0;
        uVar3 = uVar2;
        if (s != null) {
          uVar3 = 0x811c9dc5;
          for (; (int)uVar2 < *(int *)(s + 16); uVar2 = uVar2 + 1) {
            uVar1 = String.get_Chars(s,uVar2,0);
            uVar3 = (uVar1 ^ uVar3) * 0x1000193;
          }
        }
        return uVar3;
    }

}
