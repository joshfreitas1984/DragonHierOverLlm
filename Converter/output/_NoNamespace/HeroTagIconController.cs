// ============================================================
// Type  : HeroTagIconController
// Token : 0x20002DF
// ============================================================

public class HeroTagIconController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40017B2
    public TagIconType tagIconType;

    // Token: 0x40017B3
    public HeroTagData targetTag;

    // Token: 0x40017B4
    public bool hideValue;

    // Token: 0x40017B5
    private bool inited;

    // Token: 0x40017B6
    private static Color negativeTagColor;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001889
    // RVA   : 0x8A1FA0   Offset: 0x8A0DA0   Length: 0xE
    private void Update()
    {
        void FUN_1808a1fa0(int64 this)
        {
        if (!this.inited) {
          HeroTagIconController.Init(this,0);
          return;
        }
    }

    // Token : 0x600188A
    // RVA   : 0x8A1E40   Offset: 0x8A0C40   Length: 0x154
    public HeroData TargetHero()
    {
        var pStatics_6be8 = *(int64*)(DAT_181e86be8 + 184);
        ulong uVar1;
        bool cVar2;
        uVar1 = **(uint64 **)(DAT_181e86be8 + 184);
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (!cVar2) {
          if (ManageTagController._instance != null) {
            return ManageTagController._instance.targetHero;
          }
        }
        else {
          if (*pStatics_6be8 != 0) {
            return *(uint64 *)(*pStatics_6be8 + 24);
          }
        }
    }

    // Token : 0x600188B
    // RVA   : 0x8A1120   Offset: 0x89FF20   Length: 0x5BD
    public void Init()
    {
        int iVar1;
        uint uVar2;
        uint uVar3;
        long lVar4;
        ulong uVar6;
        long lVar7;
        ulong uVar8;
        float[] local_res8 = new float[2];
        ulong local_18;
        ulong uStack_10;
        local_res8[0] = 0.0;
        this.inited = 1;
        lVar4 = Component.get_transform(this,0);
        if (lVar4 == null) goto LAB_1808a16d8;
        plVar5 = (int64 *)Component.GetComponent(lVar4,DAT_181e777b8);
        if ((this.targetTag == null) ||
           (lVar4 = HeroTagData.DataBase(this.targetTag,0)) == null)
        goto LAB_1808a16d8;
        if (*(int *)(lVar4 + 32) < 0) {
          puVar9 = *(uint64 **)(DAT_181e56148 + 184);
        }
        else {
          puVar9 = (uint64 *)FUN_180f24d00(&local_18,0);
        }
        if (plVar5 == (int64 *)0) goto LAB_1808a16d8;
        local_18 = *puVar9;
        uStack_10 = puVar9[1];
        (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_18,*(uint64 *)(*plVar5 + 0x2b0));
        lVar4 = Component.get_transform(this,0);
        if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"Text",0)) == null)
        goto LAB_1808a16d8;
        uVar6 = Component.GetComponent(lVar4,DAT_181e79538);
        if ((this.targetTag == null) ||
           (lVar4 = HeroTagData.DataBase(this.targetTag,0)) == null)
        goto LAB_1808a16d8;
        uVar8 = *(uint64 *)(lVar4 + 24);
        LTLocalization.SetText(uVar6,uVar8,0);
        lVar4 = Component.get_transform(this,0);
        if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"ValueBack",0)) == null)
        goto LAB_1808a16d8;
        plVar5 = (int64 *)Component.GetComponent(lVar4,DAT_181e777b8);
        lVar4 = GameController.ChangeAllAreaStateIDs;
        if (lVar4 == null) goto LAB_1808a16d8;
        lVar4 = *(int64 *)(lVar4 + 56);
        if ((this.targetTag == null) ||
           (lVar7 = HeroTagData.DataBase(this.targetTag,0)) == null)
        goto LAB_1808a16d8;
        uVar2 = Mathf.Abs(*(uint32 *)(lVar7 + 32),0);
        lVar7 = GameController.ChangeAllAreaStateIDs;
        if ((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 56)) == null) goto LAB_1808a16d8;
        uVar3 = Mathf.Clamp(uVar2,0,*(int *)(lVar7 + 24) + -1,0);
        if (lVar4 == null) goto LAB_1808a16d8;
        if (*(uint32 *)(lVar4 + 24) <= uVar3) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar4 = lVar4[uVar3];
        if ((lVar4 == null) || (plVar5 == (int64 *)0)) goto LAB_1808a16d8;
        local_18 = *(uint64 *)(lVar4 + 24);
        uStack_10 = *(uint64 *)(lVar4 + 32);
        (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_18,*(uint64 *)(*plVar5 + 0x2b0));
        lVar4 = Component.get_transform(this,0);
        if ((lVar4 == null) ||
           ((lVar4 = Transform.Find(lVar4,"ValueBack",0), lVar4 == null ||
            (lVar4 = Transform.Find(lVar4,"Value",0)) == null))) goto LAB_1808a16d8;
        uVar8 = Component.GetComponent(lVar4,DAT_181e79538);
        uVar6 = "";
        if (!this.hideValue) {
          if (1 < this.tagIconType) {
            if ((this.targetTag == null) ||
               (lVar4 = HeroTagData.DataBase(this.targetTag,0)) == null)
            goto LAB_1808a16d8;
            uVar6 = "-";
            if (*(char *)(lVar4 + 56) == false) goto LAB_1808a1608;
          }
          if (this.targetTag == null) goto LAB_1808a16d8;
          lVar4 = HeroTagData.DataBase(this.targetTag,0);
          if (lVar4 == null) goto LAB_1808a16d8;
          iVar1 = *(int *)(lVar4 + 32);
          if (iVar1 < 0) {
            if (this.tagIconType != 2 && this.tagIconType != 3) {
              iVar1 = -iVar1;
            }
          }
          else {
            iVar1 = iVar1 * 4;
          }
          local_res8[0] = (float)iVar1;
          uVar6 = Single.ToString(local_res8,"f0",0);
        }
        LAB_1808a1608:
        LTLocalization.SetText(uVar8,uVar6,0);
        if (this.tagIconType - 1U < 2) {
          lVar4 = Component.get_transform(this,0);
          if (((lVar4 != null) &&
              (lVar4 = Transform.Find(lVar4,"RightLine",0), this.targetTag != null)) &&
             (lVar7 = HeroTagData.DataBase()) != null) {
            if (*(char *)(lVar7 + 96) == false) {
              puVar9 = (uint64 *)Vector3.get_zero(&local_18);
            }
            else {
              puVar9 = (uint64 *)Vector3.get_one();
            }
            if (lVar4 != null) {
              uStack_10 = CONCAT44(uStack_10._4_4_,*(uint32 *)(puVar9 + 1));
              local_18 = *puVar9;
              Transform.set_localScale(lVar4,&local_18,0);
              goto LAB_1808a16b9;
            }
          }
        LAB_1808a16d8:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        LAB_1808a16b9:
        HeroTagIconController.RefreshInfo(this,0);
    }

    // Token : 0x600188C
    // RVA   : 0x8A1B20   Offset: 0x8A0920   Length: 0x319
    public void RefreshInfo()
    {
        var pStatics_6be8 = *(int64*)(DAT_181e86be8 + 184);
        ulong uVar1;
        bool cVar2;
        long lVar3;
        long lVar7;
        uint uVar8;
        uint uVar9;
        uint uVar10;
        uint uVar11;
        ulong local_18;
        ulong uStack_10;
        if (this.tagIconType - 1U < 2) {
          lVar3 = Component.get_transform(this,0);
          if (lVar3 == null) throw; // [null/range check failed]
          lVar3 = Transform.Find(lVar3,"HaveTag",0);
          uVar1 = **(uint64 **)(DAT_181e86be8 + 184);
          cVar2 = Object.op_Inequality(uVar1,0,0);
          if (!cVar2) {
            if (ManageTagController._instance == null) throw; // [null/range check failed]
            lVar7 = ManageTagController._instance.targetHero;
          }
          else {
            if (*pStatics_6be8 == 0) throw; // [null/range check failed]
            lVar7 = *(int64 *)(*pStatics_6be8 + 24);
          }
          if ((this.targetTag == null) || (lVar7 == null)) throw; // [null/range check failed]
          cVar2 = HeroData.HaveTag(lVar7,this.targetTag.tagID,0);
          if (!cVar2) {
            puVar4 = (uint64 *)Vector3.get_zero(&local_18,0);
          }
          else {
            puVar4 = (uint64 *)Vector3.get_one();
          }
          if (lVar3 == null) throw; // [null/range check failed]
          uStack_10 = CONCAT44(uStack_10._4_4_,*(uint32 *)(puVar4 + 1));
          local_18 = *puVar4;
          Transform.set_localScale(lVar3,&local_18,0);
        }
        lVar3 = Component.get_transform(this,0);
        if (lVar3 == null) throw; // [null/range check failed]
        lVar3 = Transform.Find(lVar3,"Text",0);
        if (lVar3 == null) throw; // [null/range check failed]
        plVar5 = (int64 *)Component.GetComponent(lVar3,DAT_181e79538);
        if (this.targetTag == null) throw; // [null/range check failed]
        if (this.targetTag.sourceHero == null) {
          lVar3 = Component.GetComponent(this,DAT_181e76ab8);
          if (lVar3 == null) throw; // [null/range check failed]
          if (*(char *)(lVar3 + 208) != false)
          {
            puVar6 = (uint32 *)Color.get_black(&local_18,0);
            uVar8 = *puVar6;
            uVar9 = puVar6[1];
            uVar10 = puVar6[2];
            uVar11 = puVar6[3];
            }
            else {
          }
          local_18 = 0;
          uStack_10 = 0;
          Color.ctor(&local_18,0x3ecccccd,0x3ecccccd,0x3ecccccd,0);
          uVar8 = (uint32)local_18;
          uVar9 = local_18._4_4_;
          uVar10 = (uint32)uStack_10;
          uVar11 = uStack_10._4_4_;
        }
        if (plVar5 != (int64 *)0) {
          local_18 = CONCAT44(uVar9,uVar8);
          uStack_10 = CONCAT44(uVar11,uVar10);
          (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_18,*(uint64 *)(*plVar5 + 0x2b0));
          return;
        }
    }

    // Token : 0x600188D
    // RVA   : 0x8A10F0   Offset: 0x89FEF0   Length: 0x2D
    public string GetDescribe()
    {
        long lVar1;
        lVar1 = this.targetTag;
        if (lVar1 != null) {
          HeroTagData.GetDescribe
                    (lVar1,lVar1.sourceHero == null,this.tagIconType,0);
          return;
        }
    }

    // Token : 0x600188E
    // RVA   : 0x8A16E0   Offset: 0x8A04E0   Length: 0x433
    public void OnClick()
    {
        ulong uVar1;
        ulong uVar2;
        int iVar3;
        uint uVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        ulong uVar8;
        ulong uVar9;
        ulong uVar10;
        float[] local_res8 = new float[4];
        uint[] local_res18 = new uint[2];
        int[] local_res20 = new int[2];
        iVar3 = this.tagIconType;
        if (iVar3 == 1) {
          lVar5 = **(int64 **)(DAT_181e88b68 + 184);
          if ((this.targetTag != null) &&
             (lVar6 = HeroTagData.DataBase(this.targetTag,0)) != null) {
            uVar10 = *(uint64 *)(lVar6 + 24);
            if ((this.targetTag != null) &&
               (lVar6 = HeroTagData.DataBase(this.targetTag,0)) != null) {
              iVar3 = *(int *)(lVar6 + 32);
              if (iVar3 < 0) {
                iVar3 = -iVar3;
              }
              else {
                iVar3 = iVar3 * 4;
              }
              local_res8[0] = (float)iVar3;
              uVar7 = il2cpp_value_box(DAT_181e82730,local_res8);
              lVar6 = FUN_180210970(0);
              uVar2 = "消耗{1}天赋点领悟“{0}”吗？{2}";
              if ((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) {
                uVar8 = "";
                if (*(int *)(*(int64 *)(lVar6 + 32) + 88) == 0) {
                  if ((this.targetTag == null) ||
                     (lVar6 = HeroTagData.DataBase(this.targetTag,0)) == null) {
        LAB_1808a1b0e:
                          // WARNING: Subroutine does not return
                    FUN_1801e0300();
                  }
                  iVar3 = *(int *)(lVar6 + 32);
                  if (iVar3 < 0) {
                    iVar3 = -iVar3;
                  }
                  else {
                    iVar3 = iVar3 * 4;
                  }
                  uVar4 = Mathf.RoundToInt((float)iVar3 * 0.25,0);
                  local_res18[0] = Mathf.Max(1,uVar4);
                  uVar8 = il2cpp_value_box(DAT_181e60808,local_res18);
                  lVar6 = FUN_180210970(0);
                  uVar1 = "\n消耗{1}{0}天时间。";
                  if (lVar6 == null) goto LAB_1808a1b0e;
                  uVar9 = "";
                  if (*(char *)(lVar6 + 56) != false) {
                    if ((this.targetTag == null) ||
                       (lVar6 = HeroTagData.DataBase(this.targetTag,0)) == null) {
                          // WARNING: Subroutine does not return
                      FUN_1801e0300();
                    }
                    iVar3 = *(int *)(lVar6 + 32);
                    if (iVar3 < 0) {
                      iVar3 = -iVar3;
                    }
                    else {
                      iVar3 = iVar3 * 4;
                    }
                    uVar4 = Mathf.RoundToInt((float)iVar3 * 0.25,0);
                    local_res20[0] = Mathf.Max(1,uVar4);
                    local_res20[0] = local_res20[0] * 50;
                    uVar9 = il2cpp_value_box(DAT_181e60808,local_res20);
                    uVar9 = String.Format("{0}银钱和",uVar9,0);
                  }
                  uVar8 = String.Format(uVar1,uVar8,uVar9,0);
                }
                uVar10 = String.Format(uVar2,uVar10,uVar7,uVar8,0);
                if ((this.targetTag != null) &&
                   (uVar7 = Int32.ToString(this.targetTag + 16,0), lVar5 != null)) {
                  SureMenu.CallSureMenu(lVar5,uVar10,"SureUnderstandTag",uVar7,"UIController",0);
                  return;
                }
                goto LAB_1808a1b08;
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        if (iVar3 == 2) {
          lVar5 = FUN_1805186c0(0);
          if ((this.targetTag == null) || (lVar5 == null)) {
        LAB_1808a1b08:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          StartMenuController.StartChooseTagClicked
                    (lVar5,this.targetTag.tagID,0);
        }
        else if (iVar3 == 3) {
          lVar5 = FUN_1805186c0(0);
          if ((this.targetTag == null) || (lVar5 == null)) goto LAB_1808a1b08;
          StartMenuController.StartUnchooseTagClicked
                    (lVar5,this.targetTag.tagID,0);
        }
    }

    // Token : 0x600188F
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

    // Token : 0x6001890
    // RVA   : 0x8A1FB0   Offset: 0x8A0DB0   Length: 0x69
    private static void /*cctor*/()
    {
        ulong local_18;
        ulong uStack_10;
        local_18 = 0;
        uStack_10 = 0;
        Color.ctor(&local_18,0x3f800000,0x3f48c8c9,0x3f48c8c9,0);
        puVar1 = *(uint64 **)(DAT_181e56148 + 184);
        *puVar1 = local_18;
        puVar1[1] = uStack_10;
    }

}
