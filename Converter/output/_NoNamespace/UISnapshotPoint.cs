// ============================================================
// Type  : UISnapshotPoint
// Token : 0x20000AA
// ============================================================

public class UISnapshotPoint
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000400
    public bool isOrthographic;

    // Token: 0x4000401
    public float nearClip;

    // Token: 0x4000402
    public float farClip;

    // Token: 0x4000403
    public int fieldOfView;

    // Token: 0x4000404
    public float orthoSize;

    // Token: 0x4000405
    public Texture2D thumbnail;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600050A
    // RVA   : 0x16092E0   Offset: 0x16080E0   Length: 0x58
    private void Start()
    {
        bool cVar1;
        cVar1 = Component.CompareTag(this,"EditorOnly",0);
        if (!cVar1) {
          Component.set_tag(this,"EditorOnly",0);
          return;
        }
    }

    // Token : 0x600050B
    // RVA   : 0x1609340   Offset: 0x1608140   Length: 0x27
    public void /*ctor*/()
    {
        void FUN_181609340(int64 this)
        {
        this.isOrthographic = 1;
        this.nearClip = 0xc2c80000;
        this.farClip = 0x42c80000;
        this.fieldOfView = 35;
        this.orthoSize = 0x41f00000;
        FUN_180ae8740(this,0);
    }

}
