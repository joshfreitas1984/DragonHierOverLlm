// ============================================================
// Type  : BMFont
// Token : 0x2000076
// ============================================================

public class BMFont
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40002CD
    private int mSize;

    // Token: 0x40002CE
    private int mBase;

    // Token: 0x40002CF
    private int mWidth;

    // Token: 0x40002D0
    private int mHeight;

    // Token: 0x40002D1
    private string mSpriteName;

    // Token: 0x40002D2
    private List<BMGlyph> mSaved;

    // Token: 0x40002D3
    private Dictionary<int, BMGlyph> mDict;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60002B3
    // RVA   : 0x7F87A0   Offset: 0x7F6FA0   Length: 0x40
    public bool get_isValid()
    {
        long lVar1;
        lVar1 = this.mSaved;
        if (lVar1 != null) {
          return CONCAT71((int7)((uint64)lVar1 >> 8),0 < lVar1.Count);
        }
    }

    // Token : 0x60002B4
    // RVA   : 0x20F070   Offset: 0x20D870   Length: 0xC8
    public int get_charSize()
    {
        return this.mSize;
    }

    // Token : 0x60002B5
    // RVA   : 0x2C03A0   Offset: 0x2BEBA0   Length: 0x4
    public void set_charSize(int value)
    {
        this.mSize = value;
    }

    // Token : 0x60002B6
    // RVA   : 0x2A3D60   Offset: 0x2A2560   Length: 0x4
    public int get_baseOffset()
    {
        return this.mBase;
    }

    // Token : 0x60002B7
    // RVA   : 0x319100   Offset: 0x317900   Length: 0x4
    public void set_baseOffset(int value)
    {
        void FUN_180319100(int64 this,uint32 value)
        {
        this.mBase = value;
    }

    // Token : 0x60002B8
    // RVA   : 0x256310   Offset: 0x254B10   Length: 0x4
    public int get_texWidth()
    {
        uint32 FUN_180256310(int64 this)
        {
        return this.mWidth;
    }

    // Token : 0x60002B9
    // RVA   : 0x2E7EC0   Offset: 0x2E66C0   Length: 0x4
    public void set_texWidth(int value)
    {
        this.mWidth = value;
    }

    // Token : 0x60002BA
    // RVA   : 0x2E7E80   Offset: 0x2E6680   Length: 0x4
    public int get_texHeight()
    {
        uint32 FUN_1802e7e80(int64 this)
        {
        return this.mHeight;
    }

    // Token : 0x60002BB
    // RVA   : 0x2E7EB0   Offset: 0x2E66B0   Length: 0x4
    public void set_texHeight(int value)
    {
        void FUN_1802e7eb0(int64 this,uint32 value)
        {
        this.mHeight = value;
    }

    // Token : 0x60002BC
    // RVA   : 0x7F8740   Offset: 0x7F6F40   Length: 0x5F
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

    // Token : 0x60002BD
    // RVA   : 0x246A60   Offset: 0x245260   Length: 0x5
    public string get_spriteName()
    {
        return this.mSpriteName;
    }

    // Token : 0x60002BE
    // RVA   : 0x22B3A0   Offset: 0x229BA0   Length: 0xC
    public void set_spriteName(string value)
    {
        void FUN_18022b3a0(int64 this,uint64 value)
        {
        this.mSpriteName = value;
    }

    // Token : 0x60002BF
    // RVA   : 0x268280   Offset: 0x266A80   Length: 0x5
    public List<BMGlyph> get_glyphs()
    {
        return this.mSaved;
    }

    // Token : 0x60002C0
    // RVA   : 0x7F8330   Offset: 0x7F6B30   Length: 0x1F2
    public BMGlyph GetGlyph(int index, bool createIfMissing)
    {
        BMFont.GetGlyph(this,index,0,0);
    }

    // Token : 0x60002C1
    // RVA   : 0x7F8530   Offset: 0x7F6D30   Length: 0xB
    public BMGlyph GetGlyph(int index)
    {
        BMFont.GetGlyph(this,index,0,0);
    }

    // Token : 0x60002C2
    // RVA   : 0x7F82C0   Offset: 0x7F6AC0   Length: 0x65
    public void Clear()
    {
        if (this.mDict != null) {
          Dictionary_2.Clear(this.mDict,DAT_181d92a30);
          if (this.mSaved != null) {
            FUN_180f56130(this.mSaved,DAT_181d56a40);
            return;
          }
        }
    }

    // Token : 0x60002C3
    // RVA   : 0x7F8540   Offset: 0x7F6D40   Length: 0x123
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

    // Token : 0x60002C4
    // RVA   : 0x7F8670   Offset: 0x7F6E70   Length: 0xC2
    public void /*ctor*/()
    {
        ulong uVar1;
        this.mSize = 16;
        uVar1 = il2cpp_internal(DAT_181d6c5b0);
        FUN_180f58a90(uVar1,DAT_181d56940);
        this.mSaved = uVar1;
        uVar1 = il2cpp_internal(DAT_181d5c148);
        FUN_1808ae540(uVar1,DAT_181d92920);
        this.mDict = uVar1;
        ZhSegment.Initialize(this,0);
    }

}
