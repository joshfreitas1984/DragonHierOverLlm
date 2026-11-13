// ============================================================
// Type  : <>c__DisplayClass16_0
// Token : 0x2000474
// ============================================================

public class <>c__DisplayClass16_0
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40021AE
    public RectTransform target;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600279F
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x60027A0
    // RVA   : 0x67E8E0   Offset: 0x67D6E0   Length: 0x3B
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

    // Token : 0x60027A1
    // RVA   : 0x67E920   Offset: 0x67D720   Length: 0x35
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
