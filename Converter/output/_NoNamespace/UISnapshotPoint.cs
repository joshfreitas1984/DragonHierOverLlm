// ============================================================
// Type  : UISnapshotPoint
// Token : 0x20000AB
// ============================================================

public class UISnapshotPoint
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000420
    public bool isOrthographic;

    // Token: 0x4000421
    public float nearClip;

    // Token: 0x4000422
    public float farClip;

    // Token: 0x4000423
    public int fieldOfView;

    // Token: 0x4000424
    public float orthoSize;

    // Token: 0x4000425
    public Texture2D thumbnail;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000523
    // RVA   : 0x17069A0   Offset: 0x1705DA0   Length: 0x58
    private void Start()
    {
        bool cVar1;
        cVar1 = Component.CompareTag(this,"EditorOnly",0);
        if (!cVar1) {
          Component.set_tag(this,"EditorOnly",0);
          return;
        }
    }

    // Token : 0x6000524
    // RVA   : 0x1706A00   Offset: 0x1705E00   Length: 0x27
    public void /*ctor*/()
    {
        void FUN_181706a00(int64 this)
        {
        this.isOrthographic = 1;
        this.nearClip = 0xc2c80000;
        this.farClip = 0x42c80000;
        this.fieldOfView = 35;
        this.orthoSize = 0x41f00000;
        FUN_18044ef50(this,0);
    }

}
