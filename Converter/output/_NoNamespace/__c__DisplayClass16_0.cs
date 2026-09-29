// ============================================================
// Type  : <>c__DisplayClass16_0
// Token : 0x2000467
// ============================================================

public class <>c__DisplayClass16_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400211B
    public RectTransform target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60026F5
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60026F6
    // RVA   : 0x937FB0   Offset: 0x9373B0   Length: 0x3B
    internal Vector3 <DOAnchorPos3D>b__0()
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

    // Token : 0x60026F7
    // RVA   : 0x937FF0   Offset: 0x9373F0   Length: 0x35
    internal void <DOAnchorPos3D>b__1(Vector3 x)
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
