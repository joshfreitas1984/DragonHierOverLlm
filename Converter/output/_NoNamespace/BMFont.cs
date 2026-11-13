// ============================================================
// Type  : BMFont
// Token : 0x2000076
// ============================================================

public class BMFont
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40002C9
    private int mSize;

    // Token: 0x40002CA
    private int mBase;

    // Token: 0x40002CB
    private int mWidth;

    // Token: 0x40002CC
    private int mHeight;

    // Token: 0x40002CD
    private string mSpriteName;

    // Token: 0x40002CE
    private List<BMGlyph> mSaved;

    // Token: 0x40002CF
    private Dictionary<int, BMGlyph> mDict;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60002B2
    // RVA   : 0x528FB0   Offset: 0x527DB0   Length: 0x40
    public bool get_isValid()
    {
        long lVar1;
        lVar1 = this.mSaved;
        if (lVar1 != null) {
          return CONCAT71((int7)((uint64)lVar1 >> 8),0 < lVar1.Count);
        }
    }

    // Token : 0x60002B3
    // RVA   : 0x210C90   Offset: 0x20FA90   Length: 0x2A6
    public int get_charSize()
    {
        return this.mSize;
    }

    // Token : 0x60002B4
    // RVA   : 0x529040   Offset: 0x527E40   Length: 0x4
    public void set_charSize(int value)
    {
        this.mSize = value;
    }

    // Token : 0x60002B5
    // RVA   : 0x528F30   Offset: 0x527D30   Length: 0x4
    public int get_baseOffset()
    {
        return this.mBase;
    }

    // Token : 0x60002B6
    // RVA   : 0x529030   Offset: 0x527E30   Length: 0x4
    public void set_baseOffset(int value)
    {
        void FUN_180529030(int64 this,uint32 value)
        {
        this.mBase = value;
    }

    // Token : 0x60002B7
    // RVA   : 0x529020   Offset: 0x527E20   Length: 0x4
    public int get_texWidth()
    {
        uint32 FUN_180529020(int64 this)
        {
        return this.mWidth;
    }

    // Token : 0x60002B8
    // RVA   : 0x529070   Offset: 0x527E70   Length: 0x4
    public void set_texWidth(int value)
    {
        this.mWidth = value;
    }

    // Token : 0x60002B9
    // RVA   : 0x529010   Offset: 0x527E10   Length: 0x4
    public int get_texHeight()
    {
        uint32 FUN_180529010(int64 this)
        {
        return this.mHeight;
    }

    // Token : 0x60002BA
    // RVA   : 0x529060   Offset: 0x527E60   Length: 0x4
    public void set_texHeight(int value)
    {
        void FUN_180529060(int64 this,uint32 value)
        {
        this.mHeight = value;
    }

    // Token : 0x60002BB
    // RVA   : 0x528F40   Offset: 0x527D40   Length: 0x5F
    public int get_glyphCount()
    {
        int iVar1;
        int iVar2;
        if (this.mSaved != null) {
          iVar1 = this.mSaved.Count;
          iVar2 = 0;
          if (0 < iVar1) {
            iVar2 = iVar1;
          }
          return iVar2;
        }
    }

    // Token : 0x60002BC
    // RVA   : 0x529000   Offset: 0x527E00   Length: 0x5
    public string get_spriteName()
    {
        return this.mSpriteName;
    }

    // Token : 0x60002BD
    // RVA   : 0x529050   Offset: 0x527E50   Length: 0xC
    public void set_spriteName(string value)
    {
        void FUN_180529050(int64 this,uint64 value)
        {
        this.mSpriteName = value;
    }

    // Token : 0x60002BE
    // RVA   : 0x528FA0   Offset: 0x527DA0   Length: 0x5
    public List<BMGlyph> get_glyphs()
    {
        return this.mSaved;
    }

    // Token : 0x60002BF
    // RVA   : 0x528B20   Offset: 0x527920   Length: 0x1F2
    public BMGlyph GetGlyph(int index, bool createIfMissing)
    {
        BMFont.GetGlyph(this,index,0,0);
    }

    // Token : 0x60002C0
    // RVA   : 0x528D20   Offset: 0x527B20   Length: 0xB
    public BMGlyph GetGlyph(int index)
    {
        BMFont.GetGlyph(this,index,0,0);
    }

    // Token : 0x60002C1
    // RVA   : 0x528AB0   Offset: 0x5278B0   Length: 0x65
    public void Clear()
    {
        if (this.mDict != null) {
          Dictionary_2.Clear(this.mDict,DAT_181e990b8);
          if (this.mSaved != null) {
            FUN_18115d8f0(this.mSaved,DAT_181e60218);
            return;
          }
        }
    }

    // Token : 0x60002C2
    // RVA   : 0x528D30   Offset: 0x527B30   Length: 0x123
    public void Trim(int xMin, int yMin, int xMax, int yMax)
    {
                       uint32 yMax)
        {
        int iVar1;
        int64 lVar2;
        int64 lVar3;
        uint32 uVar4;
        int64 lVar5;
        if (this.mSaved != null) {
          iVar1 = this.mSaved.Count;
          if ((0 < iVar1) && (uVar4 = 0, 0 < iVar1)) {
            lVar5 = 32;
            lVar3 = 0;
            do {
              lVar2 = this.mSaved;
              if (lVar2 == null) throw; // [null/range check failed]
              if (lVar2.Count <= uVar4) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(lVar5 + lVar2._items);
              if (lVar2 != null) {
                BMGlyph.Trim(lVar2,xMin,yMin,xMax,yMax,0);
              }
              uVar4 = uVar4 + 1;
              lVar3 = lVar3 + 1;
              lVar5 = lVar5 + 8;
            } while (lVar3 < iVar1);
          }
          return;
        }
    }

    // Token : 0x60002C3
    // RVA   : 0x528E60   Offset: 0x527C60   Length: 0xC2
    public void /*ctor*/()
    {
        ulong uVar1;
        this.mSize = 16;
        uVar1 = il2cpp_internal(DAT_181e710b8);
        FUN_1810f3480(uVar1,DAT_181e60120);
        this.mSaved = uVar1;
        uVar1 = il2cpp_internal(DAT_181e60758);
        FUN_1806e5bc0(uVar1,DAT_181e98fa8);
        this.mDict = uVar1;
        ZhSegment.Initialize(this,0);
    }

}
