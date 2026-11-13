// ============================================================
// Type  : CustomSkillSpeAddDataController
// Token : 0x2000263
// ============================================================

public class CustomSkillSpeAddDataController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400131F
    public int speAddType;

    // Token: 0x4001320
    private static readonly float[] SpeAddMaxRate;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60013E3
    // RVA   : 0x65C9A0   Offset: 0x65B7A0   Length: 0x194
    public int GetSpeAddMax()
    {
        long lVar1;
        uint uVar2;
        uint uVar3;
        ulong uVar4;
        float fVar5;
        if (CustomSkillCreateController._instance != null) {
          lVar1 = CustomSkillCreateController._instance.draftSkillData;
          if (lVar1 == null) {
            return 0;
          }
          uVar2 = Mathf.Clamp(lVar1.rareLv,0,5);
          fVar5 = (float)CustomSkillCreateController.GetEffectBudget(lVar1,0);
          lVar1 = **(int64 **)(DAT_181e9bc58 + 184);
          if (lVar1 != null) {
            if (uVar2 < lVar1.belongForceID) {
              uVar3 = Mathf.RoundToInt(lVar1[uVar2] * fVar5,0);
              uVar4 = Mathf.Max(1,uVar3);
              return uVar4;
            }
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar4,0);
          }
        }
    }

    // Token : 0x60013E4
    // RVA   : 0x65CD40   Offset: 0x65BB40   Length: 0xA
    public void Init(int _speAddType)
    {
        void FUN_18065cd40(int64 this,uint32 _speAddType)
        {
        this.speAddType = _speAddType;
        CustomSkillSpeAddDataController.RefreshSpeAddUI(this,0);
    }

    // Token : 0x60013E5
    // RVA   : 0x65C270   Offset: 0x65B070   Length: 0x537
    public void ChangeSpeAddButtonClicked(GameObject buttonClicked)
    {
        long lVar1;
        bool cVar2;
        int iVar3;
        uint uVar4;
        long lVar5;
        ulong uVar6;
        uint uVar8;
        int iVar10;
        float fVar11;
        lVar5 = CustomSkillSpeAddDataController.GetTargetSpeAdd(this,0);
        if (lVar5 != null) {
          fVar11 = (float)HeroSpeAddData.Get(lVar5,this.speAddType,0);

          if ((lVar5 = GameController.ChangeAllAreaStateIDs?.defPartPosture) != null) {
            uVar4 = this.speAddType;
            if (lVar5.belongForceID <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = lVar5.summonSkill[uVar4];
            if ((lVar5 != null) &&
               (iVar3 = Mathf.RoundToInt(fVar11 / lVar5.name,0), buttonClicked != null)) {
              uVar6 = Object.get_name(buttonClicked,0);
              cVar2 = FUN_1816387f0(uVar6,"Right",0);
              iVar10 = -1;
              if (cVar2) {
                iVar10 = 1;
              }
              if (CustomSkillCreateController._instance != null) {
                lVar5 = CustomSkillCreateController._instance.draftSkillData;
                uVar8 = 0;
                if (lVar5 != null) {
                  uVar4 = Mathf.Clamp(lVar5.rareLv,0,5,0);
                  fVar11 = (float)CustomSkillCreateController.GetEffectBudget(lVar5,0);
                  lVar5 = **(int64 **)(DAT_181e9bc58 + 184);
                  if (lVar5 == null) throw; // [null/range check failed]
                  if (lVar5.belongForceID <= uVar4) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  uVar8 = Mathf.RoundToInt(lVar5[uVar4] * fVar11,0
                                           );
                  uVar8 = Mathf.Max(1,uVar8,0);
                }
                iVar3 = Mathf.Clamp(iVar10 + iVar3,1,uVar8,0);
                lVar5 = CustomSkillSpeAddDataController.GetTargetSpeAdd(this,0);
                uVar8 = this.speAddType;
                lVar1 = GameController.ChangeAllAreaStateIDs;
                if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 144)) != null) {
                  uVar4 = this.speAddType;
                  if (*(uint32 *)(lVar1 + 24) <= uVar4) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar1 = lVar1[uVar4];
                  if ((lVar1 != null) && (lVar5 != null)) {
                    HeroSpeAddData.Set(lVar5,uVar8,(float)iVar3 * *(float *)(lVar1 + 32),0);
                    CustomSkillSpeAddDataController.RefreshSpeAddUI(this,0);
                    if (CustomSkillCreateController._instance != null) {
                      CustomSkillCreateController.RefreshSkillPointText
                                (CustomSkillCreateController._instance,0);
                      plVar7 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
                      plVar9 = (int64 *)0;
                      if ((plVar7 != (int64 *)0) && (*plVar7 == DAT_181e8f4a0)) {
                        plVar9 = plVar7;
                      }
                      NGUITools.PlaySound(plVar9,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60013E6
    // RVA   : 0x65C7B0   Offset: 0x65B5B0   Length: 0x1E3
    public void DeleteButtonClicked()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = CustomSkillSpeAddDataController.GetTargetSpeAdd(this,0);
        if (lVar1 != null) {
          HeroSpeAddData.Set(lVar1,this.speAddType,0,0);
          if (CustomSkillCreateController._instance != null) {
            CustomSkillCreateController.RefreshSkillPointText(CustomSkillCreateController._instance,0);
            uVar2 = Component.get_gameObject(this,0);
            Object.Destroy(uVar2,0);
            if (CustomSkillCreateController._instance != null) {
              CustomSkillCreateController.RefreshSpeAddDataGrid(CustomSkillCreateController._instance,0);
              plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/PaperQuick",0);
              plVar4 = (int64 *)0;
              if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181e8f4a0)) {
                plVar4 = plVar3;
              }
              NGUITools.PlaySound(plVar4,0);
              return;
            }
          }
        }
    }

    // Token : 0x60013E7
    // RVA   : 0x65CB40   Offset: 0x65B940   Length: 0x128
    public int GetSpeAddPoint()
    {
        uint uVar1;
        long lVar2;
        float fVar3;
        lVar2 = CustomSkillSpeAddDataController.GetTargetSpeAdd(this,0);
        if (lVar2 != null) {
          fVar3 = (float)HeroSpeAddData.Get(lVar2,this.speAddType,0);
          lVar2 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 32);
          if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 144)) != null) {
            uVar1 = this.speAddType;
            if (*(uint32 *)(lVar2 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = lVar2[uVar1];
            if (lVar2 != null) {
              Mathf.RoundToInt(fVar3 / *(float *)(lVar2 + 32),0);
              return;
            }
          }
        }
    }

    // Token : 0x60013E8
    // RVA   : 0x65CC70   Offset: 0x65BA70   Length: 0xC1
    public HeroSpeAddData GetTargetSpeAdd()
    {
        long lVar1;
        if ((CustomSkillCreateController._instance != null) &&
           (lVar1 = CustomSkillCreateController._instance.draftSkillData) != null) {
          if (lVar1.type < 3) {
            return lVar1.equipAddData;
          }
          return lVar1.useAddData;
        }
    }

    // Token : 0x60013E9
    // RVA   : 0x65CD50   Offset: 0x65BB50   Length: 0x138
    public void RefreshSpeAddUI()
    {
        uint uVar1;
        long lVar2;
        long lVar4;
        ulong uVar5;
        uint uVar6;
        lVar2 = Component.get_transform(this,0);
        if (lVar2 != null) {
          lVar2 = Transform.Find(lVar2,"Text",0);
          if (lVar2 != null) {
            plVar3 = (int64 *)Component.GetComponent(lVar2,DAT_181e79538);
            lVar2 = new HeroSpeAddData(0);
            uVar1 = this.speAddType;
            lVar4 = CustomSkillSpeAddDataController.GetTargetSpeAdd(this,0);
            if (lVar4 != null) {
              uVar6 = HeroSpeAddData.Get(lVar4,this.speAddType,0);
              if (lVar2 != null) {
                lVar2 = HeroSpeAddData.Set(lVar2,uVar1,uVar6,0);
                if (lVar2 != null) {
                  uVar5 = HeroSpeAddData.GetDescribe(lVar2,1,1,1,0,0);
                  if (plVar3 != (int64 *)0) {
                          // WARNING: Could not recover jumptable at 0x00018065ce7c. Too many branches
                          // WARNING: Treating indirect jump as call
                    (**(code **)(*plVar3 + 0x5e8))(plVar3,uVar5,*(uint64 *)(*plVar3 + 0x5f0));
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60013EA
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

    // Token : 0x60013EB
    // RVA   : 0x65CE90   Offset: 0x65BC90   Length: 0x7E
    private static void /*cctor*/()
    {
        ulong uVar2;
        uVar2 = FUN_1801dfd90(DAT_181e854f8,6);
        RuntimeHelpers.InitializeArray(uVar2,DAT_181e9f240,0);
        puVar1 = *(uint64 **)(DAT_181e9bc58 + 184);
        *puVar1 = uVar2;
        il2cpp_internal(puVar1,uVar2);
    }

}
