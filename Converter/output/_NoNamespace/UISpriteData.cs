// ============================================================
// Type  : UISpriteData
// Token : 0x2000114
// ============================================================

public class UISpriteData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40006BE
    public string name;

    // Token: 0x40006BF
    public int x;

    // Token: 0x40006C0
    public int y;

    // Token: 0x40006C1
    public int width;

    // Token: 0x40006C2
    public int height;

    // Token: 0x40006C3
    public int borderLeft;

    // Token: 0x40006C4
    public int borderRight;

    // Token: 0x40006C5
    public int borderTop;

    // Token: 0x40006C6
    public int borderBottom;

    // Token: 0x40006C7
    public int paddingLeft;

    // Token: 0x40006C8
    public int paddingRight;

    // Token: 0x40006C9
    public int paddingTop;

    // Token: 0x40006CA
    public int paddingBottom;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600094A
    // RVA   : 0x1691EE0   Offset: 0x16906E0   Length: 0x10
    public bool get_hasBorder()
    {
        uint uVar1;
        uVar1 = this.borderBottom | this.borderTop | this.borderRight |
                this.borderLeft;
        return CONCAT31((int3)(uVar1 >> 8),uVar1 != 0);
    }

    // Token : 0x600094B
    // RVA   : 0x1691EF0   Offset: 0x16906F0   Length: 0x10
    public bool get_hasPadding()
    {
        uint uVar1;
        uVar1 = this.paddingBottom | this.paddingTop | this.paddingRight |
                this.paddingLeft;
        return CONCAT31((int3)(uVar1 >> 8),uVar1 != 0);
    }

    // Token : 0x600094C
    // RVA   : 0x1691E70   Offset: 0x1690670   Length: 0x13
    public void SetRect(int x, int y, int width, int height)
    {
        void FUN_181691e70(int64 this,uint32 x,uint32 y,uint32 width,
                        uint32 height)
        {
        this.height = height;
        this.x = x;
        this.y = y;
        this.width = width;
    }

    // Token : 0x600094D
    // RVA   : 0x1691E50   Offset: 0x1690650   Length: 0x13
    public void SetPadding(int left, int bottom, int right, int top)
    {
        void FUN_181691e50(int64 this,uint32 left,uint32 bottom,uint32 right,
                        uint32 top)
        {
        this.paddingTop = top;
        this.paddingLeft = left;
        this.paddingBottom = bottom;
        this.paddingRight = right;
    }

    // Token : 0x600094E
    // RVA   : 0x1691E30   Offset: 0x1690630   Length: 0x13
    public void SetBorder(int left, int bottom, int right, int top)
    {
        void FUN_181691e30(int64 this,uint32 left,uint32 bottom,uint32 right,
                        uint32 top)
        {
        this.borderTop = top;
        this.borderLeft = left;
        this.borderBottom = bottom;
        this.borderRight = right;
    }

    // Token : 0x600094F
    // RVA   : 0x1691DB0   Offset: 0x16905B0   Length: 0x7D
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

    // Token : 0x6000950
    // RVA   : 0x1691D80   Offset: 0x1690580   Length: 0x2B
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

    // Token : 0x6000951
    // RVA   : 0x1691E90   Offset: 0x1690690   Length: 0x47
    public void /*ctor*/()
    {
        this.name = "Sprite";
        ZhSegment.Initialize(this,0);
    }

}
