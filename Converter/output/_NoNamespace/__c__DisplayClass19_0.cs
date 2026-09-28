// ============================================================
// Type  : <>c__DisplayClass19_0
// Token : 0x200046A
// ============================================================

public class <>c__DisplayClass19_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400211D
    public RectTransform target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60026FE
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60026FF
    // RVA   : 0x937920   Offset: 0x936D20   Length: 0x3B
    internal Vector3 <DOAnchorPos3DZ>b__0()
    {
        uint uVar1;
        byte[] local_18 = new byte[16];
        if (*(int64 *)(param_2 + 16) != 0) {
          puVar2 = (uint64 *)
                   RectTransform.get_anchoredPosition3D(local_18,*(int64 *)(param_2 + 16),0);
          uVar1 = *(uint32 *)(puVar2 + 1);
          *this = *puVar2;
          *(uint32 *)(this + 1) = uVar1;
          return this;
        }
    }

    // Token : 0x6002700
    // RVA   : 0x937960   Offset: 0x936D60   Length: 0x35
    internal void <DOAnchorPos3DZ>b__1(Vector3 x)
    {
        ulong local_18;
        uint local_10;
        if (this.target != null) {
          local_18 = *x;
          local_10 = *(uint32 *)(x + 1);
          RectTransform.set_anchoredPosition3D(this.target,&local_18,0);
          return;
        }
    }

}
