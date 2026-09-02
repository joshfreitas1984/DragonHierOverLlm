// ============================================================
// Type  : UISnapshotPoint
// Token : 0x20000AA
// ============================================================

public class UISnapshotPoint
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000404
    public bool isOrthographic;

    // Token: 0x4000405
    public float nearClip;

    // Token: 0x4000406
    public float farClip;

    // Token: 0x4000407
    public int fieldOfView;

    // Token: 0x4000408
    public float orthoSize;

    // Token: 0x4000409
    public Texture2D thumbnail;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600050B
    // RVA   : 0x168EB80   Offset: 0x168D380   Length: 0x58
    private void Start()
    {
        bool cVar1;
        cVar1 = Component.CompareTag(this,"EditorOnly",0);
        if (!cVar1) {
          Component.set_tag(this,"EditorOnly",0);
          return;
        }
    }

    // Token : 0x600050C
    // RVA   : 0x168EBE0   Offset: 0x168D3E0   Length: 0x27
    public void /*ctor*/()
    {
        void FUN_18168ebe0(int64 this)
        {
        this.isOrthographic = 1;
        this.nearClip = 0xc2c80000;
        this.farClip = 0x42c80000;
        this.fieldOfView = 35;
        this.orthoSize = 0x41f00000;
        FUN_18044ef50(this,0);
    }

}
