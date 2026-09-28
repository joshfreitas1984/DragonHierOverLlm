// ============================================================
// Type  : BMGlyph
// Token : 0x2000078
// ============================================================

public class BMGlyph
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40002F0
    public int index;

    // Token: 0x40002F1
    public int x;

    // Token: 0x40002F2
    public int y;

    // Token: 0x40002F3
    public int width;

    // Token: 0x40002F4
    public int height;

    // Token: 0x40002F5
    public int offsetX;

    // Token: 0x40002F6
    public int offsetY;

    // Token: 0x40002F7
    public int advance;

    // Token: 0x40002F8
    public int channel;

    // Token: 0x40002F9
    public List<int> kerning;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60002DD
    // RVA   : 0x7F6C30   Offset: 0x7F6030   Length: 0xE2
    public int GetKerning(int previousChar)
    {
        long lVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        uint uVar5;
        ulong uVar6;
        long lVar7;
        if ((this.kerning != null) && (previousChar != null)) {
          lVar7 = (int64)this.kerning.Count;
          uVar4 = 0;
          if (0 < lVar7) {
            lVar3 = 32;
            uVar6 = uVar4;
            do {
              lVar1 = this.kerning;
              if (lVar1 == null) {
        LAB_1807f6d0d:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar5 = (uint32)uVar6;
              if (lVar1.Count <= uVar5) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (*(int *)(lVar1._items + lVar3) == previousChar) {
                if (this.kerning != null) {
                  uVar2 = FUN_1800d6760(this.kerning,uVar5 + 1,DAT_181d8fa18);
                  return uVar2;
                }
                goto LAB_1807f6d0d;
              }
              uVar6 = (uint64)(uVar5 + 2);
              uVar4 = uVar4 + 2;
              lVar3 = lVar3 + 8;
            } while ((int64)uVar4 < lVar7);
          }
        }
        return 0;
    }

    // Token : 0x60002DE
    // RVA   : 0x7F6D20   Offset: 0x7F6120   Length: 0x160
    public void SetKerning(int previousChar, int amount)
    {
        ulong uVar2;
        long lVar3;
        long lVar4;
        uint uVar5;
        lVar3 = this.kerning;
        if (lVar3 == null) {
          uVar2 = il2cpp_internal(DAT_181d93cd0);
          FUN_18132faf0(uVar2,DAT_181d8f098);
          this.kerning = uVar2;
          lVar3 = this.kerning;
        }
        uVar5 = 0;
        if (lVar3 != null) {
          lVar4 = 32;
          do {
            if (lVar3.Count <= (int)uVar5) {
              FUN_18182a0b0(lVar3,previousChar,DAT_181d8f218);
              if (this.kerning != null) {
                FUN_18182a0b0(this.kerning,amount,DAT_181d8f218);
                return;
              }
              break;
            }
            if (lVar3 == null) break;
            if (lVar3.Count <= uVar5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar3 = this.kerning;
            if (*(int *)(lVar4 + lVar3._items) == previousChar) {
              if (lVar3 != null) {
                FUN_181833d40(lVar3,uVar5 + 1,amount,DAT_181d8fb18);
                return;
              }
              break;
            }
            uVar5 = uVar5 + 2;
            lVar4 = lVar4 + 8;
          } while (lVar3 != null);
        }
    }

    // Token : 0x60002DF
    // RVA   : 0x7F6E90   Offset: 0x7F6290   Length: 0x90
    public void Trim(int xMin, int yMin, int xMax, int yMax)
    {
        int iVar1;
        int iVar2;
        int iVar3;
        int iVar4;
        int iVar5;
        int iVar6;
        iVar3 = this.x;
        iVar6 = this.width;
        iVar5 = this.height;
        iVar4 = this.y;
        iVar1 = iVar3 + iVar6;
        iVar2 = iVar4 + iVar5;
        if (iVar3 < xMin) {
          this.x = xMin;
          iVar6 = iVar6 - (xMin - iVar3);
          this.offsetX = this.offsetX + (xMin - iVar3);
          this.width = iVar6;
        }
        if (iVar4 < yMin) {
          this.y = yMin;
          iVar5 = iVar5 - (yMin - iVar4);
          this.offsetY = this.offsetY + (yMin - iVar4);
          this.height = iVar5;
        }
        if (xMax < iVar1) {
          this.width = (iVar6 - iVar1) + xMax;
        }
        if (yMax < iVar2) {
          this.height = (iVar5 - iVar2) + yMax;
        }
    }

    // Token : 0x60002E0
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

}
