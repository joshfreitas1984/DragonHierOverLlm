// ============================================================
// Type  : DownloadTexture
// Token : 0x2000015
// ============================================================

public class DownloadTexture
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000068
    public string url;

    // Token: 0x4000069
    public bool pixelPerfect;

    // Token: 0x400006A
    private Texture2D mTex;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600004A
    // RVA   : 0x92BBB0   Offset: 0x92A3B0   Length: 0x6C
    private IEnumerator Start()
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          return lVar1;
        }
    }

    // Token : 0x600004B
    // RVA   : 0x92BB10   Offset: 0x92A310   Length: 0x93
    private void OnDestroy()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.mTex;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          uVar1 = this.mTex;
          Object.Destroy(uVar1,0);
        }
    }

    // Token : 0x600004C
    // RVA   : 0x92BC20   Offset: 0x92A420   Length: 0x4B
    public void /*ctor*/()
    {
        this.url = "http://www.yourwebsite.com/logo.png";
        this.pixelPerfect = 1;
        FUN_18044ef50(this,0);
    }

}
