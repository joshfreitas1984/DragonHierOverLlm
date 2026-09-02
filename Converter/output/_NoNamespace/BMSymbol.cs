// ============================================================
// Type  : BMSymbol
// Token : 0x2000078
// ============================================================

public class BMSymbol
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40002DE
    public string sequence;

    // Token: 0x40002DF
    public string spriteName;

    // Token: 0x40002E0
    private UISpriteData mSprite;

    // Token: 0x40002E1
    private bool mIsValid;

    // Token: 0x40002E2
    private int mLength;

    // Token: 0x40002E3
    private int mOffsetX;

    // Token: 0x40002E4
    private int mOffsetY;

    // Token: 0x40002E5
    private int mWidth;

    // Token: 0x40002E6
    private int mHeight;

    // Token: 0x40002E7
    private int mAdvance;

    // Token: 0x40002E8
    private Rect mUV;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60002C9
    // RVA   : 0x7F8DF0   Offset: 0x7F75F0   Length: 0x24
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

    // Token : 0x60002CA
    // RVA   : 0x20F160   Offset: 0x20D960   Length: 0x4
    public int get_offsetX()
    {
        return this.mOffsetX;
    }

    // Token : 0x60002CB
    // RVA   : 0x2BCA70   Offset: 0x2BB270   Length: 0x4
    public int get_offsetY()
    {
        return this.mOffsetY;
    }

    // Token : 0x60002CC
    // RVA   : 0x20F040   Offset: 0x20D840   Length: 0x4
    public int get_width()
    {
        uint32 FUN_18020f040(int64 this)
        {
        return this.mWidth;
    }

    // Token : 0x60002CD
    // RVA   : 0x362670   Offset: 0x360E70   Length: 0x4
    public int get_height()
    {
        uint32 FUN_180362670(int64 this)
        {
        return this.mHeight;
    }

    // Token : 0x60002CE
    // RVA   : 0x362680   Offset: 0x360E80   Length: 0x4
    public int get_advance()
    {
        uint32 FUN_180362680(int64 this)
        {
        return this.mAdvance;
    }

    // Token : 0x60002CF
    // RVA   : 0x7F8E20   Offset: 0x7F7620   Length: 0xB
    public Rect get_uvRect()
    {
        uint64 * FUN_1807f8e20(uint64 *this,int64 param_2)
        {
        uint64 uVar1;
        uVar1 = *(uint64 *)(param_2 + 76);
        *this = *(uint64 *)(param_2 + 68);
        this[1] = uVar1;
        return this;
    }

    // Token : 0x60002D0
    // RVA   : 0x7F8AE0   Offset: 0x7F72E0   Length: 0x5
    public void MarkAsChanged()
    {
        this.mIsValid = 0;
    }

    // Token : 0x60002D1
    // RVA   : 0x7F8AF0   Offset: 0x7F72F0   Length: 0x2F6
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
        LAB_1807f8db4:
          bVar13 = false;
        }
        else {
          if (!this.mIsValid) {
            cVar4 = FUN_180d6ca90(this.spriteName,0);
            if (cVar4) goto LAB_1807f8db4;
            lVar1 = *atlas;
            uVar8 = this.spriteName;
            uVar12 = 0;
            if (*(uint16 *)(lVar1 + 0x12a) != 0) {
              uVar11 = uVar12;
              do {
                if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar11 * 16) == DAT_181d55650
                   ) {
                  puVar7 = (uint64 *)
                           ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar11 * 16)
                            * 16 + 0x1d8 + lVar1);
                  goto LAB_1807f8bbf;
                }
                uVar11 = uVar11 + 1;
              } while (uVar11 < *(uint16 *)(lVar1 + 0x12a));
            }
            puVar7 = (uint64 *)FUN_1800914f0(atlas,DAT_181d55650,10);
        LAB_1807f8bbf:
            uVar8 = (*(code *)*puVar7)(atlas,uVar8,puVar7[1]);
            this.mSprite = uVar8;
            lVar1 = *atlas;
            if (*(uint16 *)(lVar1 + 0x12a) != 0) {
              do {
                if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar12 * 16) == DAT_181d55650
                   ) {
                  puVar7 = (uint64 *)
                           ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar12 * 16)
                            * 16 + 0x178 + lVar1);
                  goto LAB_1807f8c2c;
                }
                uVar12 = uVar12 + 1;
              } while (uVar12 < *(uint16 *)(lVar1 + 0x12a));
            }
            puVar7 = (uint64 *)FUN_1800914f0(atlas,DAT_181d55650,4);
        LAB_1807f8c2c:
            plVar9 = (int64 *)(*(code *)*puVar7)(atlas,puVar7[1]);
            if (this.mSprite != null) {
              cVar4 = Object.op_Equality(plVar9,0,0);
              if (!cVar4) {
                if (this.mSprite != null) {
                  uVar14 = 0;
                  local_48 = 0;
                  uStack_40 = 0;
                  FUN_1809981e0(&local_48);
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

    // Token : 0x60002D2
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

}
