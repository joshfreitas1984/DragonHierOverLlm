// ============================================================
// Type  : BMSymbol
// Token : 0x2000079
// ============================================================

public class BMSymbol
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40002FA
    public string sequence;

    // Token: 0x40002FB
    public string spriteName;

    // Token: 0x40002FC
    private UISpriteData mSprite;

    // Token: 0x40002FD
    private bool mIsValid;

    // Token: 0x40002FE
    private int mLength;

    // Token: 0x40002FF
    private int mOffsetX;

    // Token: 0x4000300
    private int mOffsetY;

    // Token: 0x4000301
    private int mWidth;

    // Token: 0x4000302
    private int mHeight;

    // Token: 0x4000303
    private int mAdvance;

    // Token: 0x4000304
    private Rect mUV;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60002E1
    // RVA   : 0x7F7230   Offset: 0x7F6630   Length: 0x24
    public int get_length()
    {
        if (this.mLength == null) {
          if (this.sequence == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          this.mLength = *(uint32 *)(this.sequence + 16);
        }
    }

    // Token : 0x60002E2
    // RVA   : 0x20F160   Offset: 0x20E560   Length: 0x4
    public int get_offsetX()
    {
        return this.mOffsetX;
    }

    // Token : 0x60002E3
    // RVA   : 0x2BCA70   Offset: 0x2BBE70   Length: 0x4
    public int get_offsetY()
    {
        return this.mOffsetY;
    }

    // Token : 0x60002E4
    // RVA   : 0x20F040   Offset: 0x20E440   Length: 0x4
    public int get_width()
    {
        uint32 FUN_18020f040(int64 this)
        {
        return this.mWidth;
    }

    // Token : 0x60002E5
    // RVA   : 0x362670   Offset: 0x361A70   Length: 0x4
    public int get_height()
    {
        uint32 FUN_180362670(int64 this)
        {
        return this.mHeight;
    }

    // Token : 0x60002E6
    // RVA   : 0x362680   Offset: 0x361A80   Length: 0x4
    public int get_advance()
    {
        uint32 FUN_180362680(int64 this)
        {
        return this.mAdvance;
    }

    // Token : 0x60002E7
    // RVA   : 0x7F7260   Offset: 0x7F6660   Length: 0xB
    public Rect get_uvRect()
    {
        uint64 * FUN_1807f7260(uint64 *this,int64 param_2)
        {
        uint64 uVar1;
        uVar1 = *(uint64 *)(param_2 + 76);
        *this = *(uint64 *)(param_2 + 68);
        this[1] = uVar1;
        return this;
    }

    // Token : 0x60002E8
    // RVA   : 0x7F6F20   Offset: 0x7F6320   Length: 0x5
    public void MarkAsChanged()
    {
        this.mIsValid = 0;
    }

    // Token : 0x60002E9
    // RVA   : 0x7F6F30   Offset: 0x7F6330   Length: 0x2F6
    public bool Validate(INGUIAtlas atlas)
    {
        long lVar1;
        uint uVar2;
        ulong uVar3;
        bool cVar4;
        uint uVar5;
        uint uVar6;
        ulong uVar8;
        ushort uVar11;
        ushort uVar12;
        ulong uVar14;
        ulong local_48;
        ulong uStack_40;
        ulong local_38;
        ulong uStack_30;
        byte[] local_28 = new byte[32];
        if (atlas == (int64 *)0) {
        LAB_1807f71f4:
          bVar13 = false;
        }
        else {
          if (!this.mIsValid) {
            cVar4 = FUN_180d75bc0(this.spriteName,0);
            if (cVar4) goto LAB_1807f71f4;
            lVar1 = *atlas;
            uVar8 = this.spriteName;
            uVar12 = 0;
            if (*(uint16 *)(lVar1 + 0x12a) != 0) {
              uVar11 = uVar12;
              do {
                if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar11 * 16) == DAT_181d7a7a0
                   ) {
                  puVar7 = (uint64 *)
                           ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar11 * 16)
                            * 16 + 0x1d8 + lVar1);
                  goto LAB_1807f6fff;
                }
                uVar11 = uVar11 + 1;
              } while (uVar11 < *(uint16 *)(lVar1 + 0x12a));
            }
            puVar7 = (uint64 *)FUN_1800914f0(atlas,DAT_181d7a7a0,10);
        LAB_1807f6fff:
            uVar8 = (*(code *)*puVar7)(atlas,uVar8,puVar7[1]);
            this.mSprite = uVar8;
            lVar1 = *atlas;
            if (*(uint16 *)(lVar1 + 0x12a) != 0) {
              do {
                if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar12 * 16) == DAT_181d7a7a0
                   ) {
                  puVar7 = (uint64 *)
                           ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar12 * 16)
                            * 16 + 0x178 + lVar1);
                  goto LAB_1807f706c;
                }
                uVar12 = uVar12 + 1;
              } while (uVar12 < *(uint16 *)(lVar1 + 0x12a));
            }
            puVar7 = (uint64 *)FUN_1800914f0(atlas,DAT_181d7a7a0,4);
        LAB_1807f706c:
            plVar9 = (int64 *)(*(code *)*puVar7)(atlas,puVar7[1]);
            if (this.mSprite != null) {
              cVar4 = Object.op_Equality(plVar9,0,0);
              if (!cVar4) {
                if (this.mSprite != null) {
                  uVar14 = 0;
                  local_48 = 0;
                  uStack_40 = 0;
                  FUN_1809dcfa0(&local_48);
                  uVar3 = uStack_40;
                  uVar8 = local_48;
                  this.mUV = local_48;
                  *(uint64 *)(this + 76) = uStack_40;
                  if (plVar9 != (int64 *)0) {
                    uVar5 = (**(code **)(*plVar9 + 0x178))(plVar9,*(uint64 *)(*plVar9 + 0x180));
                    uVar6 = (**(code **)(*plVar9 + 0x198))(plVar9,*(uint64 *)(*plVar9 + 0x1a0));
                    local_38 = uVar8;
                    uStack_30 = uVar3;
                    puVar10 = (uint32 *)
                              NGUIMath.ConvertToTexCoords(local_28,&local_38,uVar5,uVar6,0,uVar14);
                    lVar1 = this.mSprite;
                    uVar5 = puVar10[1];
                    uVar6 = puVar10[2];
                    uVar2 = puVar10[3];
                    this.mUV = *puVar10;
                    *(uint32 *)(this + 72) = uVar5;
                    *(uint32 *)(this + 76) = uVar6;
                    *(uint32 *)(this + 80) = uVar2;
                    if (lVar1 != null) {
                      this.mOffsetX = lVar1.paddingLeft;
                      this.mOffsetY = lVar1.paddingTop;
                      this.mWidth = lVar1.width;
                      this.mHeight = lVar1.height;
                      this.mAdvance =
                           lVar1.paddingRight + lVar1.paddingLeft + lVar1.width;
                      this.mIsValid = 1;
                      return lVar1 != null;
                    }
                  }
                }
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              this.mSprite = 0;
            }
          }
          bVar13 = this.mSprite != null;
        }
        return bVar13;
    }

    // Token : 0x60002EA
    // RVA   : 0x210B70   Offset: 0x20FF70   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

}
