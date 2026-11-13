// ============================================================
// Type  : SkinDataBase
// Token : 0x20001DC
// ============================================================

public class SkinDataBase
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000CAD
    public int skinID;

    // Token: 0x4000CAE
    public string skinName;

    // Token: 0x4000CAF
    public HeroSpeAddData skinSpeAdd;

    // Token: 0x4000CB0
    public int DLC;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000ED0
    // RVA   : 0x6B0FF0   Offset: 0x6AFDF0   Length: 0x34
    public HeroSpeAddData GetSkinSpeAdd(int lv)
    {
        ulong uVar1;
        uVar1 = this.skinSpeAdd;
        Mathf.Max(0x3f000000,lv,0);
        HeroSpeAddData.op_Multiply(uVar1);
    }

    // Token : 0x6000ED1
    // RVA   : 0x6B1030   Offset: 0x6AFE30   Length: 0xE
    public void /*ctor*/()
    {
        this.DLC = 0xffffffff;
        ZhSegment.Initialize(this,0);
    }

    // Token : 0x6000ED2
    // RVA   : 0x6B0D10   Offset: 0x6AFB10   Length: 0x2DF
    public string GetSkinFullName(int _skinLv, bool changeLine, bool changeColor)
    {
        var pStatics_38e8 = *(int64*)(DAT_181e538e8 + 184);
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        if (this.skinID < 0) {
          lVar1 = *(int64 *)(pStatics_38e8 + 0x410);
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
            goto LAB_1806b0f8a;
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
                lVar1 = *(int64 *)(pStatics_38e8 + 0x3e0);
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
                lVar1 = *(int64 *)(pStatics_38e8 + 0x3e0);
                if (lVar1 == null) throw; // [null/range check failed]
                if (lVar1.cityAreaID < 7) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                uVar3 = String.Concat(uVar2,uVar3,*(uint64 *)(lVar1.chapter + 80),0);
              }
        LAB_1806b0f8a:
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
