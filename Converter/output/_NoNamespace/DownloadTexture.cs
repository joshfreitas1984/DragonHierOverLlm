// ============================================================
// Type  : DownloadTexture
// Token : 0x2000016
// ============================================================

public class DownloadTexture
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000084
    public string url;

    // Token: 0x4000085
    public bool pixelPerfect;

    // Token: 0x4000086
    private Texture2D mTex;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000062
    // RVA   : 0x93BAE0   Offset: 0x93AEE0   Length: 0x6C
    private IEnumerator Start()
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          return lVar1;
        }
    }

    // Token : 0x6000063
    // RVA   : 0x93BA40   Offset: 0x93AE40   Length: 0x93
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

    // Token : 0x6000064
    // RVA   : 0x93BB50   Offset: 0x93AF50   Length: 0x4B
    public void /*ctor*/()
    {
        this.url = "http://www.yourwebsite.com/logo.png";
        this.pixelPerfect = 1;
        FUN_18044ef50(this,0);
    }

}
