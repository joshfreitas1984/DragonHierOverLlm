// ============================================================
// Type  : CustomSkillDamageRatioController
// Token : 0x2000262
// ============================================================

public class CustomSkillDamageRatioController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400131A
    public const int RatioIndexCount;

    // Token: 0x400131B
    public const int HpIndex;

    // Token: 0x400131C
    public const int ManaIndex;

    // Token: 0x400131D
    public int ratioIndex;

    // Token: 0x400131E
    private static readonly int[] AttriRatioMax;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60013D9
    // RVA   : 0x65B6F0   Offset: 0x65A4F0   Length: 0x135
    public int GetAttriRatioMax()
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        ulong uVar4;
        uint uVar5;
        if (CustomSkillCreateController._instance != null) {
          lVar1 = CustomSkillCreateController._instance.draftSkillData;
          lVar2 = **(int64 **)(DAT_181e9bb48 + 184);
          if (lVar1 == null) {
            uVar5 = 0;
          }
          else {
            uVar5 = lVar1.rareLv;
          }
          uVar3 = Mathf.Clamp(uVar5,0,5);
          if (lVar2 != null) {
            if (uVar3 < *(uint32 *)(lVar2 + 24)) {
              return lVar2[uVar3];
            }
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar4,0);
          }
        }
    }

    // Token : 0x60013DA
    // RVA   : 0x65BBB0   Offset: 0x65A9B0   Length: 0xA
    public void Init(int index)
    {
        void FUN_18065bbb0(int64 this,uint32 index)
        {
        this.ratioIndex = index;
        CustomSkillDamageRatioController.RefreshAttriRatioUI(this,0);
    }

    // Token : 0x60013DB
    // RVA   : 0x65B300   Offset: 0x65A100   Length: 0x3E4
    public void ChangeAttriRatioButtonClicked(GameObject buttonClicked)
    {
        void CustomSkillDamageRatioController.ChangeAttriRatioButtonClicked
                     (int64 this,int64 buttonClicked)
        {
        char cVar1;
        int iVar2;
        uint32 uVar3;
        int iVar4;
        uint64 uVar5;
        int64 *plVar6;
        int64 lVar7;
        int64 *plVar8;
        float fVar9;
        float fVar10;
        if ((CustomSkillCreateController._instance == null) ||
           (lVar7 = CustomSkillCreateController._instance.draftSkillData) == null)
        throw; // [null/range check failed]
        lVar7 = lVar7.addDamageRatio;
        uVar3 = this.ratioIndex;
        fVar9 = (float)CustomSkillDamageRatioController.GetRatioValue(lVar7,uVar3,0);
        fVar10 = 1.0;
        if ((this.ratioIndex - 0x18U & 0xfffffffd) == 0) {
          fVar10 = 0.1;
        }
        iVar2 = Mathf.RoundToInt(fVar9 / fVar10,0);
        if (buttonClicked == null) throw; // [null/range check failed]
        uVar5 = Object.get_name(buttonClicked,0);
        cVar1 = FUN_1816387f0(uVar5,"Right",0);
        iVar4 = -1;
        if (cVar1) {
          iVar4 = 1;
        }
        uVar3 = CustomSkillDamageRatioController.GetAttriRatioMax(this,0);
        iVar4 = Mathf.Clamp(iVar2 + iVar4,1,uVar3,0);
        iVar2 = this.ratioIndex;
        fVar10 = 0.1;
        if ((iVar2 - 0x18U & 0xfffffffd) != 0) {
          fVar10 = 1.0;
        }
        fVar10 = (float)iVar4 * fVar10;
        if (iVar2 < 6) {
          if ((lVar7 = lVar7?.summonSkill) == null) throw; // [null/range check failed]
        LAB_18065b5d6:
          FUN_181769c70(lVar7,iVar2,fVar10,DAT_181e835b0);
        }
        else {
          if (iVar2 < 15) {
            if ((lVar7 = lVar7?.belongForceID) == null) throw; // [null/range check failed]
            iVar2 = iVar2 + -6;
            goto LAB_18065b5d6;
          }
          if (iVar2 < 24) {
            if ((lVar7 = lVar7?.name) == null) throw; // [null/range check failed]
            iVar2 = iVar2 + -15;
            goto LAB_18065b5d6;
          }
          if (iVar2 == 24) {
            if (lVar7 == null) throw; // [null/range check failed]
            lVar7.describe = fVar10;
          }
          else if (iVar2 == 25) {
            if (lVar7 == null) throw; // [null/range check failed]
            *(float *)(lVar7 + 44) = fVar10;
          }
          else if (iVar2 == 26) {
            if (lVar7 == null) throw; // [null/range check failed]
            lVar7.type = fVar10;
          }
          else if (iVar2 == 27) {
            if (lVar7 == null) throw; // [null/range check failed]
            lVar7.rareLv = fVar10;
          }
        }
        CustomSkillDamageRatioController.RefreshAttriRatioUI(this,0);
        if (CustomSkillCreateController._instance != null) {
          CustomSkillCreateController.RefreshSkillPointText(CustomSkillCreateController._instance,0);
          plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
          plVar8 = (int64 *)0;
          if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181e8f4a0)) {
            plVar8 = plVar6;
          }
          NGUITools.PlaySound(plVar8,0);
          return;
        }
    }

    // Token : 0x60013DC
    // RVA   : 0x65BBC0   Offset: 0x65A9C0   Length: 0x4E2
    public void RefreshAttriRatioUI()
    {
        var pStatics_38e8 = *(int64*)(DAT_181e538e8 + 184);
        uint uVar1;
        long lVar2;
        uint uVar3;
        uint uVar4;
        long lVar5;
        ulong uVar7;
        ulong uVar8;
        float fVar9;
        float fVar10;
        if ((CustomSkillCreateController._instance != null) &&
           (lVar5 = CustomSkillCreateController._instance.draftSkillData) != null) {
          uVar8 = lVar5.addDamageRatio;
          uVar4 = this.ratioIndex;
          fVar9 = (float)CustomSkillDamageRatioController.GetRatioValue(uVar8,uVar4,0);
          if ((this.ratioIndex - 0x18U & 0xfffffffd) == 0) {
            fVar10 = 0.1;
          }
          else {
            fVar10 = 1.0;
          }
          uVar3 = Mathf.RoundToInt(fVar9 / fVar10,0);
          CustomSkillDamageRatioController.GetAttriRatioMax(this,0);
          lVar5 = Component.get_transform(this,0);
          if ((lVar5 != null) && (lVar5 = Transform.Find(lVar5,"Text",0)) != null) {
            plVar6 = (int64 *)Component.GetComponent(lVar5,DAT_181e79538);
            uVar1 = this.ratioIndex;
            lVar5 = (int64)(int)uVar1;
            if ((int)uVar1 < 6) {
              lVar2 = *(int64 *)(pStatics_38e8 + 0x4a0);
              if (lVar2 == null) throw; // [null/range check failed]
              if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar8 = *(uint64 *)(*(int64 *)(lVar2 + 16) + 32 + lVar5 * 8);
            }
            else if ((int)uVar1 < 15) {
              lVar2 = *(int64 *)(pStatics_38e8 + 0x4a8);
              if (lVar2 == null) throw; // [null/range check failed]
              if (*(uint32 *)(lVar2 + 24) <= uVar1 - 6) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar8 = *(uint64 *)(*(int64 *)(lVar2 + 16) + -16 + lVar5 * 8);
            }
            else if ((int)uVar1 < 24) {
              lVar2 = *(int64 *)(pStatics_38e8 + 0x4b8);
              if (lVar2 == null) throw; // [null/range check failed]
              if (*(uint32 *)(lVar2 + 24) <= uVar1 - 15) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar8 = *(uint64 *)(*(int64 *)(lVar2 + 16) + -88 + lVar5 * 8);
            }
            else {
              uVar8 = "生命";
              if ((((uVar1 != 24) && (uVar8 = "体力", uVar1 != 25)) &&
                  (uVar8 = "内力", uVar1 != 26)) && (uVar8 = "魅力", uVar1 != 27)) {
                uVar8 = "";
              }
            }
            lVar5 = *(int64 *)(pStatics_38e8 + 0x580);
            if (lVar5 != null) {
              if (lVar5.belongForceID <= uVar3) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar7 = lVar5.summonSkill[uVar3];

              if ((lVar5 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32)?.manaCost) != null) {
                uVar4 = Mathf.Min(uVar3,lVar5.belongForceID + -1,0);
                uVar7 = GlobalData.GenerateRareLvColorText(uVar7,uVar4,0);
                uVar8 = String.Format("{0}加成 {1}",uVar8,uVar7,0);
                if (plVar6 != (int64 *)0) {
                          // WARNING: Could not recover jumptable at 0x00018065c096. Too many branches
                          // WARNING: Treating indirect jump as call
                  (**(code **)(*plVar6 + 0x5e8))(plVar6,uVar8,*(uint64 *)(*plVar6 + 0x5f0));
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x60013DD
    // RVA   : 0x65BA70   Offset: 0x65A870   Length: 0x132
    public static float GetRatioValue(AttriNumData ratio, int index)
    {
        long lVar1;
        ulong uVar2;
        if (ratio == null) {
          return 0;
        }
        if ((int)index < 6) {
          lVar1 = *(int64 *)(ratio + 16);
          if (lVar1 != null) {
            if (*(uint32 *)(lVar1 + 24) <= index) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            return (uint64)lVar1[index];
          }
        }
        else if ((int)index < 15) {
          lVar1 = *(int64 *)(ratio + 24);
          if (lVar1 != null) {
            if (*(uint32 *)(lVar1 + 24) <= index - 6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            return (uint64)*(uint32 *)(*(int64 *)(lVar1 + 16) + 8 + (int64)(int)index * 4);
          }
        }
        else {
          if (23 < (int)index) {
            if (index == 24) {
              return (uint64)*(uint32 *)(ratio + 40);
            }
            if (index == 25) {
              return (uint64)*(uint32 *)(ratio + 44);
            }
            if (index == 26) {
              return (uint64)*(uint32 *)(ratio + 48);
            }
            if (index != 27) {
              return 0;
            }
            return (uint64)*(uint32 *)(ratio + 52);
          }
          if (*(int64 *)(ratio + 32) != 0) {
            uVar2 = FUN_1800024e0(*(int64 *)(ratio + 32),index - 15,DAT_181e83530);
            return uVar2;
          }
        }
    }

    // Token : 0x60013DE
    // RVA   : 0x65C0B0   Offset: 0x65AEB0   Length: 0x136
    public static void SetRatioValue(AttriNumData ratio, int index, float value)
    {
        void CustomSkillDamageRatioController.SetRatioValue
                     (int64 ratio,int index,uint32 value)
        {
        int64 lVar1;
        if (index < 6) {
          if ((ratio != null) && (lVar1 = *(int64 *)(ratio + 16)) != null) {
        LAB_18065c19d:
            FUN_181769c70(lVar1,index,value,DAT_181e835b0);
            return;
          }
        }
        else if (index < 15) {
          if ((ratio != null) && (lVar1 = *(int64 *)(ratio + 24)) != null) {
            index = index + -6;
            goto LAB_18065c19d;
          }
        }
        else if (index < 24) {
          if ((ratio != null) && (lVar1 = *(int64 *)(ratio + 32)) != null) {
            index = index + -15;
            goto LAB_18065c19d;
          }
        }
        else if (index == 24) {
          if (ratio != null) {
            *(uint32 *)(ratio + 40) = value;
            return;
          }
        }
        else if (index == 25) {
          if (ratio != null) {
            *(uint32 *)(ratio + 44) = value;
            return;
          }
        }
        else if (index == 26) {
          if (ratio != null) {
            *(uint32 *)(ratio + 48) = value;
            return;
          }
        }
        else {
          if (index != 27) {
            return;
          }
          if (ratio != null) {
            *(uint32 *)(ratio + 52) = value;
            return;
          }
        }
    }

    // Token : 0x60013DF
    // RVA   : 0x65BA50   Offset: 0x65A850   Length: 0x1C
    public static float GetRatioPointRate(int index)
    {
        uint64 FUN_18065ba50(int index)
        {
        if ((index - 0x18U & 0xfffffffd) == 0) {
          return 0x3dcccccd;
        }
        return 0x3f800000;
    }

    // Token : 0x60013E0
    // RVA   : 0x65B830   Offset: 0x65A630   Length: 0x217
    public static string GetRatioName(int index)
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        long lVar1;
        long lVar2;
        lVar2 = (int64)(int)index;
        if ((int)index < 6) {
          lVar1 = *(int64 *)(pStatics + 0x4a0);
          if (lVar1 != null) {
            if (*(uint32 *)(lVar1 + 24) <= index) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            return *(uint64 *)(*(int64 *)(lVar1 + 16) + 32 + lVar2 * 8);
          }
        }
        else if ((int)index < 15) {
          lVar1 = *(int64 *)(pStatics + 0x4a8);
          if (lVar1 != null) {
            if (*(uint32 *)(lVar1 + 24) <= index - 6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            return *(uint64 *)(*(int64 *)(lVar1 + 16) + -16 + lVar2 * 8);
          }
        }
        else {
          if (23 < (int)index) {
            if (index == 24) {
              return "生命";
            }
            if (index == 25) {
              return "体力";
            }
            if (index == 26) {
              return "内力";
            }
            if (index != 27) {
              return "";
            }
            return "魅力";
          }
          lVar1 = *(int64 *)(pStatics + 0x4b8);
          if (lVar1 != null) {
            if (*(uint32 *)(lVar1 + 24) <= index - 15) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            return *(uint64 *)(*(int64 *)(lVar1 + 16) + -88 + lVar2 * 8);
          }
        }
    }

    // Token : 0x60013E1
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

    // Token : 0x60013E2
    // RVA   : 0x65C1F0   Offset: 0x65AFF0   Length: 0x7E
    private static void /*cctor*/()
    {
        ulong uVar2;
        uVar2 = FUN_1801dfd90(DAT_181e836f8,6);
        RuntimeHelpers.InitializeArray(uVar2,DAT_181e9f350,0);
        puVar1 = *(uint64 **)(DAT_181e9bb48 + 184);
        *puVar1 = uVar2;
        il2cpp_internal(puVar1,uVar2);
    }

}
