// ============================================================
// Type  : BMSymbol
// Token : 0x2000078
// ============================================================

public class BMSymbol
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40002DA
    public string sequence;

    // Token: 0x40002DB
    public string spriteName;

    // Token: 0x40002DC
    private UISpriteData mSprite;

    // Token: 0x40002DD
    private bool mIsValid;

    // Token: 0x40002DE
    private int mLength;

    // Token: 0x40002DF
    private int mOffsetX;

    // Token: 0x40002E0
    private int mOffsetY;

    // Token: 0x40002E1
    private int mWidth;

    // Token: 0x40002E2
    private int mHeight;

    // Token: 0x40002E3
    private int mAdvance;

    // Token: 0x40002E4
    private Rect mUV;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60002C8
    // RVA   : 0x5296A0   Offset: 0x5284A0   Length: 0x24
    public int get_length()
    {
        if (this.mLength == null) {
          if (this.sequence == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          this.mLength = *(uint32 *)(this.sequence + 16);
        }
    }

    // Token : 0x60002C9
    // RVA   : 0x5296D0   Offset: 0x5284D0   Length: 0x4
    public int get_offsetX()
    {
        return this.mOffsetX;
    }

    // Token : 0x60002CA
    // RVA   : 0x5296E0   Offset: 0x5284E0   Length: 0x4
    public int get_offsetY()
    {
        return this.mOffsetY;
    }

    // Token : 0x60002CB
    // RVA   : 0x529700   Offset: 0x528500   Length: 0x4
    public int get_width()
    {
        uint32 FUN_180529700(int64 this)
        {
        return this.mWidth;
    }

    // Token : 0x60002CC
    // RVA   : 0x529690   Offset: 0x528490   Length: 0x4
    public int get_height()
    {
        uint32 FUN_180529690(int64 this)
        {
        return this.mHeight;
    }

    // Token : 0x60002CD
    // RVA   : 0x529680   Offset: 0x528480   Length: 0x4
    public int get_advance()
    {
        uint32 FUN_180529680(int64 this)
        {
        return this.mAdvance;
    }

    // Token : 0x60002CE
    // RVA   : 0x5296F0   Offset: 0x5284F0   Length: 0xB
    public Rect get_uvRect()
    {
        uint64 * FUN_1805296f0(uint64 *this,int64 param_2)
        {
        uint64 uVar1;
        uVar1 = *(uint64 *)(param_2 + 76);
        *this = *(uint64 *)(param_2 + 68);
        this[1] = uVar1;
        return this;
    }

    // Token : 0x60002CF
    // RVA   : 0x529370   Offset: 0x528170   Length: 0x5
    public void MarkAsChanged()
    {
        this.mIsValid = 0;
    }

    // Token : 0x60002D0
    // RVA   : 0x529380   Offset: 0x528180   Length: 0x2F6
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
        LAB_180529644:
          bVar13 = false;
        }
        else {
          if (!this.mIsValid) {
            cVar4 = FUN_180ad1200(this.spriteName,0);
            if (cVar4) goto LAB_180529644;
            lVar1 = *atlas;
            uVar8 = this.spriteName;
            uVar12 = 0;
            if (*(uint16 *)(lVar1 + 0x12a) != 0) {
              uVar11 = uVar12;
              do {
                if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar11 * 16) == DAT_181e5a658
                   ) {
                  puVar7 = (uint64 *)
                           ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar11 * 16)
                            * 16 + 0x1d8 + lVar1);
                  goto LAB_18052944f;
                }
                uVar11 = uVar11 + 1;
              } while (uVar11 < *(uint16 *)(lVar1 + 0x12a));
            }
            puVar7 = (uint64 *)FUN_18019b1f0(atlas,DAT_181e5a658,10);
        LAB_18052944f:
            uVar8 = (*(code *)*puVar7)(atlas,uVar8,puVar7[1]);
            this.mSprite = uVar8;
            lVar1 = *atlas;
            if (*(uint16 *)(lVar1 + 0x12a) != 0) {
              do {
                if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar12 * 16) == DAT_181e5a658
                   ) {
                  puVar7 = (uint64 *)
                           ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar12 * 16)
                            * 16 + 0x178 + lVar1);
                  goto LAB_1805294bc;
                }
                uVar12 = uVar12 + 1;
              } while (uVar12 < *(uint16 *)(lVar1 + 0x12a));
            }
            puVar7 = (uint64 *)FUN_18019b1f0(atlas,DAT_181e5a658,4);
        LAB_1805294bc:
            plVar9 = (int64 *)(*(code *)*puVar7)(atlas,puVar7[1]);
            if (this.mSprite != null) {
              cVar4 = Object.op_Equality(plVar9,0,0);
              if (!cVar4) {
                if (this.mSprite != null) {
                  uVar14 = 0;
                  local_48 = 0;
                  uStack_40 = 0;
                  FUN_1807282e0(&local_48);
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
                FUN_1801e0300();
              }
              this.mSprite = 0;
            }
          }
          bVar13 = this.mSprite != null;
        }
        return bVar13;
    }

    // Token : 0x60002D1
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        ZhSegment.Initialize(this,0);
    }

}
