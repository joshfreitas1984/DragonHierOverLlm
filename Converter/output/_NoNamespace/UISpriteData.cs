// ============================================================
// Type  : UISpriteData
// Token : 0x2000115
// ============================================================

public class UISpriteData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40006DA
    public string name;

    // Token: 0x40006DB
    public int x;

    // Token: 0x40006DC
    public int y;

    // Token: 0x40006DD
    public int width;

    // Token: 0x40006DE
    public int height;

    // Token: 0x40006DF
    public int borderLeft;

    // Token: 0x40006E0
    public int borderRight;

    // Token: 0x40006E1
    public int borderTop;

    // Token: 0x40006E2
    public int borderBottom;

    // Token: 0x40006E3
    public int paddingLeft;

    // Token: 0x40006E4
    public int paddingRight;

    // Token: 0x40006E5
    public int paddingTop;

    // Token: 0x40006E6
    public int paddingBottom;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000962
    // RVA   : 0x170A340   Offset: 0x1709740   Length: 0x10
    public bool get_hasBorder()
    {
        uint uVar1;
        uVar1 = this.borderBottom | this.borderTop | this.borderRight |
                this.borderLeft;
        return CONCAT31((int3)(uVar1 >> 8),uVar1 != 0);
    }

    // Token : 0x6000963
    // RVA   : 0x170A350   Offset: 0x1709750   Length: 0x10
    public bool get_hasPadding()
    {
        uint uVar1;
        uVar1 = this.paddingBottom | this.paddingTop | this.paddingRight |
                this.paddingLeft;
        return CONCAT31((int3)(uVar1 >> 8),uVar1 != 0);
    }

    // Token : 0x6000964
    // RVA   : 0x170A2D0   Offset: 0x17096D0   Length: 0x13
    public void SetRect(int x, int y, int width, int height)
    {
        void FUN_18170a2d0(int64 this,uint32 x,uint32 y,uint32 width,
                        uint32 height)
        {
        this.height = height;
        this.x = x;
        this.y = y;
        this.width = width;
    }

    // Token : 0x6000965
    // RVA   : 0x170A2B0   Offset: 0x17096B0   Length: 0x13
    public void SetPadding(int left, int bottom, int right, int top)
    {
        void FUN_18170a2b0(int64 this,uint32 left,uint32 bottom,uint32 right,
                        uint32 top)
        {
        this.paddingTop = top;
        this.paddingLeft = left;
        this.paddingBottom = bottom;
        this.paddingRight = right;
    }

    // Token : 0x6000966
    // RVA   : 0x170A290   Offset: 0x1709690   Length: 0x13
    public void SetBorder(int left, int bottom, int right, int top)
    {
        void FUN_18170a290(int64 this,uint32 left,uint32 bottom,uint32 right,
                        uint32 top)
        {
        this.borderTop = top;
        this.borderLeft = left;
        this.borderBottom = bottom;
        this.borderRight = right;
    }

    // Token : 0x6000967
    // RVA   : 0x170A210   Offset: 0x1709610   Length: 0x7D
    public void CopyFrom(UISpriteData sd)
    {
        if (sd != null) {
          this.name = *(uint64 *)(sd + 16);
          this.x = *(uint32 *)(sd + 24);
          this.y = *(uint32 *)(sd + 28);
          this.width = *(uint32 *)(sd + 32);
          this.height = *(uint32 *)(sd + 36);
          this.borderLeft = *(uint32 *)(sd + 40);
          this.borderRight = *(uint32 *)(sd + 44);
          this.borderTop = *(uint32 *)(sd + 48);
          this.borderBottom = *(uint32 *)(sd + 52);
          this.paddingLeft = *(uint32 *)(sd + 56);
          this.paddingRight = *(uint32 *)(sd + 60);
          this.paddingTop = *(uint32 *)(sd + 64);
          this.paddingBottom = *(uint32 *)(sd + 68);
          return;
        }
    }

    // Token : 0x6000968
    // RVA   : 0x170A1E0   Offset: 0x17095E0   Length: 0x2B
    public void CopyBorderFrom(UISpriteData sd)
    {
        if (sd != null) {
          this.borderLeft = *(uint32 *)(sd + 40);
          this.borderRight = *(uint32 *)(sd + 44);
          this.borderTop = *(uint32 *)(sd + 48);
          this.borderBottom = *(uint32 *)(sd + 52);
          return;
        }
    }

    // Token : 0x6000969
    // RVA   : 0x170A2F0   Offset: 0x17096F0   Length: 0x47
    public void /*ctor*/()
    {
        this.name = "Sprite";
        ZhSegment.Initialize(this,0);
    }

}
