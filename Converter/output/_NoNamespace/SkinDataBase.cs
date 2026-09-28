// ============================================================
// Type  : SkinDataBase
// Token : 0x20001DA
// ============================================================

public class SkinDataBase
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000C9A
    public int skinID;

    // Token: 0x4000C9B
    public string skinName;

    // Token: 0x4000C9C
    public HeroSpeAddData skinSpeAdd;

    // Token: 0x4000C9D
    public int DLC;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000ECA
    // RVA   : 0x989210   Offset: 0x988610   Length: 0x34
    public HeroSpeAddData GetSkinSpeAdd(int lv)
    {
        ulong uVar1;
        uVar1 = this.skinSpeAdd;
        Mathf.Max(0x3f000000,lv,0);
        HeroSpeAddData.op_Multiply(uVar1);
    }

    // Token : 0x6000ECB
    // RVA   : 0x989250   Offset: 0x988650   Length: 0xE
    public void /*ctor*/()
    {
        this.DLC = 0xffffffff;
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6000ECC
    // RVA   : 0x988F30   Offset: 0x988330   Length: 0x2DF
    public string GetSkinFullName(int _skinLv, bool changeLine, bool changeColor)
    {
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        if (this.skinID < 0) {
          lVar1 = *(int64 *)(pStatics_3d40 + 0x408);
          if (lVar1 != null) {
            if (lVar1.cityAreaID <= _skinLv) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar3 = "";
            if (changeLine) {
              uVar3 = "\n";
            }
            uVar3 = String.Concat(*(uint64 *)
                                    (lVar1.chapter + 32 + (int64)(int)_skinLv * 8),
                                   uVar3,0);
            goto LAB_1809891aa;
          }
        }
        else {
          if ((GameController._instance != null) &&
             (lVar1 = GameController._instance.worldData) != null) {
            lVar1 = WorldData.GetForce(lVar1,this.skinID,0);
            if (lVar1 != null) {
              uVar2 = ForceData.GetForceName(lVar1,1,0);
              uVar3 = "";
              if (changeLine) {
                uVar3 = "\n";
              }
              if ((int)_skinLv < 5) {
                lVar1 = *(int64 *)(pStatics_3d40 + 0x3d8);
                if (lVar1 == null) throw; // [null/range check failed]
                if (lVar1.cityAreaID <= _skinLv) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                uVar3 = String.Concat(uVar2,uVar3,
                                       *(uint64 *)
                                        (lVar1.chapter + 32 + (int64)(int)_skinLv * 8),
                                       0);
              }
              else {
                lVar1 = *(int64 *)(pStatics_3d40 + 0x3d8);
                if (lVar1 == null) throw; // [null/range check failed]
                if (lVar1.cityAreaID < 7) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                uVar3 = String.Concat(uVar2,uVar3,*(uint64 *)(lVar1.chapter + 80),0);
              }
        LAB_1809891aa:
              uVar3 = String.Concat(uVar3,this.skinName,0);
              if (changeColor) {
                GlobalData.GenerateRareLvColorText(uVar3,_skinLv,0);
              }
              return;
            }
          }
        }
    }

}
