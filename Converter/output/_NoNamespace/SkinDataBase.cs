// ============================================================
// Type  : SkinDataBase
// Token : 0x20001D4
// ============================================================

public class SkinDataBase
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C0D
    public int skinID;

    // Token: 0x4000C0E
    public string skinName;

    // Token: 0x4000C0F
    public HeroSpeAddData skinSpeAdd;

    // Token: 0x4000C10
    public int DLC;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E95
    // RVA   : 0x976580   Offset: 0x974D80   Length: 0x34
    public HeroSpeAddData GetSkinSpeAdd(int lv)
    {
        ulong uVar1;
        uVar1 = this.skinSpeAdd;
        Mathf.Max(0x3f000000,lv,0);
        HeroSpeAddData.op_Multiply(uVar1);
    }

    // Token : 0x6000E96
    // RVA   : 0x9765C0   Offset: 0x974DC0   Length: 0xE
    public void /*ctor*/()
    {
        this.DLC = 0xffffffff;
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6000E97
    // RVA   : 0x976290   Offset: 0x974A90   Length: 0x2E7
    public string GetSkinFullName(int _skinLv, bool changeLine, bool changeColor)
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        if (this.skinID < 0) {
          lVar1 = *(int64 *)(pStatics + 0x400);
          if (lVar1 != null) {
            if (*(uint32 *)(lVar1 + 24) <= _skinLv) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar2 = "";
            if (changeLine) {
              uVar2 = "\n";
            }
            uVar2 = String.Concat(*(uint64 *)
                                    (*(int64 *)(lVar1 + 16) + 32 + (int64)(int)_skinLv * 8),
                                   uVar2,0);
            goto LAB_180976512;
          }
        }
        else {
          lVar1 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
          if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 208)) != null) {
            lVar1 = FUN_1817cc780(lVar1,this.skinID,DAT_181d94178);
            if (lVar1 != null) {
              uVar2 = *(uint64 *)(lVar1 + 24);
              uVar3 = "";
              if (changeLine) {
                uVar3 = "\n";
              }
              if ((int)_skinLv < 5) {
                lVar1 = *(int64 *)(pStatics + 0x3d0);
                if (lVar1 == null) throw; // [null/range check failed]
                if (*(uint32 *)(lVar1 + 24) <= _skinLv) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                uVar2 = String.Concat(uVar2,uVar3,
                                       *(uint64 *)
                                        (*(int64 *)(lVar1 + 16) + 32 + (int64)(int)_skinLv * 8),
                                       0);
              }
              else {
                lVar1 = *(int64 *)(pStatics + 0x3d0);
                if (lVar1 == null) throw; // [null/range check failed]
                if (*(uint32 *)(lVar1 + 24) < 7) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                uVar2 = String.Concat(uVar2,uVar3,*(uint64 *)(*(int64 *)(lVar1 + 16) + 80),0);
              }
        LAB_180976512:
              uVar2 = String.Concat(uVar2,this.skinName,0);
              if (changeColor) {
                GlobalData.GenerateRareLvColorText(uVar2,_skinLv,0);
              }
              return;
            }
          }
        }
    }

}
