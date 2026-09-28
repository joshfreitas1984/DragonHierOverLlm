// ============================================================
// Type  : <>c__DisplayClass17_0
// Token : 0x2000468
// ============================================================

public class <>c__DisplayClass17_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400211B
    public RectTransform target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60026F8
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60026F9
    // RVA   : 0x937920   Offset: 0x936D20   Length: 0x3B
    internal Vector3 <DOAnchorPos3DX>b__0()
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

    // Token : 0x60026FA
    // RVA   : 0x937960   Offset: 0x936D60   Length: 0x35
    internal void <DOAnchorPos3DX>b__1(Vector3 x)
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
