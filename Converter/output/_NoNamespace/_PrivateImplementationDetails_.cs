// ============================================================
// Type  : <PrivateImplementationDetails>
// Token : 0x20004A0
// ============================================================

public class <PrivateImplementationDetails>
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40021FA
    internal static readonly __StaticArrayInitTypeSize=24 01ECDAFAF313F310442508A4BE564202DCF891C704A7BA92CA78C7536B945233;

    // Token: 0x40021FB
    internal static readonly __StaticArrayInitTypeSize=24 04C7759311506C17257EEADED4162AF2BD3357C28630AD376999B1C5DB6DCE5A;

    // Token: 0x40021FC
    internal static readonly __StaticArrayInitTypeSize=32 07F953EB3DB1131FBDB6AA2748FD8EC70F792C02BF125F3577B8988B69AF80B0;

    // Token: 0x40021FD
    internal static readonly __StaticArrayInitTypeSize=24 0A00F93AA4AC629A54923D8B3889842D76E5C2DB184540E79CBCDA1D96F08964;

    // Token: 0x40021FE
    internal static readonly __StaticArrayInitTypeSize=24 14F30D82AE199043229EABE2BA2B4743E697A47F34447A3B81C94828D489A29F;

    // Token: 0x40021FF
    internal static readonly __StaticArrayInitTypeSize=16 1FCEC3432661BB453A0CD8ABC61AD2F744BA7A1B7B51DF4BCD35EA2996737399;

    // Token: 0x4002200
    internal static readonly __StaticArrayInitTypeSize=10 2BB47FF64195EADBDFAF6D62F95A5190EF909363CCA70584BE479841A1C94165;

    // Token: 0x4002201
    internal static readonly __StaticArrayInitTypeSize=24 461D273C40E06A5517201796514FA7311479768EAD67D1F6FB533662501E0A24;

    // Token: 0x4002202
    internal static readonly __StaticArrayInitTypeSize=580 6383AD8D3ACB5400C9BB99B6431A223D7472A06120C1C15C09458B0FCB291E2B;

    // Token: 0x4002203
    internal static readonly __StaticArrayInitTypeSize=24 6887E77B33AA13BEE81EC4D7C5FA8CE120ED72B37520D1B1B6C90527419E7B4D;

    // Token: 0x4002204
    internal static readonly __StaticArrayInitTypeSize=24 71F718A51C3ABBEF6128120DBDDCE6F622575352CF8DB94B19ADDCA824107A2F;

    // Token: 0x4002205
    internal static readonly long A553BADB17A168A36B44DA9D26F99CB2EEC465BFD5E69C5D695D0F2F66629EF5;

    // Token: 0x4002206
    internal static readonly __StaticArrayInitTypeSize=24 AFB8756E3090AFA01C9A1A72EE5E6DF751ED7741BA9DCC10455CBDC95DB4CC4D;

    // Token: 0x4002207
    internal static readonly __StaticArrayInitTypeSize=24 B8FDE20F6605DE14621DE69A7A6F90971B59FED0D4A9151D0A5CB6A0AFE67CF5;

    // Token: 0x4002208
    internal static readonly __StaticArrayInitTypeSize=24 CECDBA31BB32BF620B1734F3A05E2087C85C7F8A76E7F297A5B0B85F4EF7EF57;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002825
    // RVA   : 0x9983C0   Offset: 0x9971C0   Length: 0x55
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
