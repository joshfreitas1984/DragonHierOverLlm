// ============================================================
// Type  : HeroTagIconController
// Token : 0x20002D0
// ============================================================

public class HeroTagIconController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40016A9
    public TagIconType tagIconType;

    // Token: 0x40016AA
    public HeroTagData targetTag;

    // Token: 0x40016AB
    public bool hideValue;

    // Token: 0x40016AC
    private bool inited;

    // Token: 0x40016AD
    private static Color negativeTagColor;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60017C9
    // RVA   : 0xB3E7C0   Offset: 0xB3CFC0   Length: 0xE
    private void Update()
    {
        void FUN_180b3e7c0(int64 this)
        {
        if (!this.inited) {
          HeroTagIconController.Init(this,0);
          return;
        }
    }

    // Token : 0x60017CA
    // RVA   : 0xB3E660   Offset: 0xB3CE60   Length: 0x154
    public HeroData TargetHero()
    {
        var pStatics_1570 = *(int64*)(DAT_181d81570 + 184);
        var pStatics_27f0 = *(int64*)(DAT_181d627f0 + 184);
        ulong uVar1;
        bool cVar2;
        uVar1 = **(uint64 **)(DAT_181d81570 + 184);
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (!cVar2) {
          if (*pStatics_27f0 != 0) {
            return *(uint64 *)(*pStatics_27f0 + 32);
          }
        }
        else {
          if (*pStatics_1570 != 0) {
            return *(uint64 *)(*pStatics_1570 + 24);
          }
        }
    }

    // Token : 0x60017CB
    // RVA   : 0xB3D990   Offset: 0xB3C190   Length: 0x56F
    public void Init()
    {
        var pStatics = *(int64*)(DAT_181d4e010 + 184);
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
        if (lVar4 == null) goto LAB_180b3defa;
        plVar5 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40);
        if ((this.targetTag == null) ||
           (lVar4 = HeroTagData.DataBase(this.targetTag,0)) == null)
        goto LAB_180b3defa;
        if (*(int *)(lVar4 + 32) < 0) {
          puVar9 = *(uint64 **)(DAT_181d51580 + 184);
        }
        else {
          puVar9 = (uint64 *)FUN_181098a50(&local_18,0);
        }
        if (plVar5 == (int64 *)0) goto LAB_180b3defa;
        local_18 = *puVar9;
        uStack_10 = puVar9[1];
        (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_18,*(uint64 *)(*plVar5 + 0x2b0));
        lVar4 = Component.get_transform(this,0);
        if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"Text",0)) == null)
        goto LAB_180b3defa;
        uVar6 = Component.GetComponent(lVar4,DAT_181d6d8c0);
        if ((this.targetTag == null) ||
           (lVar4 = HeroTagData.DataBase(this.targetTag,0)) == null)
        goto LAB_180b3defa;
        LTLocalization.SetText(uVar6,*(uint64 *)(lVar4 + 24),0);
        lVar4 = Component.get_transform(this,0);
        if ((lVar4 == null) || (lVar4 = Transform.Find(lVar4,"ValueBack",0)) == null)
        goto LAB_180b3defa;
        plVar5 = (int64 *)Component.GetComponent(lVar4,DAT_181d6bc40);
        lVar4 = *(int64 *)(pStatics + 32);
        if (lVar4 == null) goto LAB_180b3defa;
        lVar4 = *(int64 *)(lVar4 + 56);
        if ((this.targetTag == null) ||
           (lVar7 = HeroTagData.DataBase(this.targetTag,0)) == null)
        goto LAB_180b3defa;
        uVar2 = Mathf.Abs(*(uint32 *)(lVar7 + 32),0);
        lVar7 = *(int64 *)(pStatics + 32);
        if ((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 56)) == null) goto LAB_180b3defa;
        uVar3 = Mathf.Clamp(uVar2,0,*(int *)(lVar7 + 24) + -1,0);
        if (lVar4 == null) goto LAB_180b3defa;
        if (*(uint32 *)(lVar4 + 24) <= uVar3) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar4 = lVar4[uVar3];
        if ((lVar4 == null) || (plVar5 == (int64 *)0)) goto LAB_180b3defa;
        local_18 = *(uint64 *)(lVar4 + 24);
        uStack_10 = *(uint64 *)(lVar4 + 32);
        (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_18,*(uint64 *)(*plVar5 + 0x2b0));
        lVar4 = Component.get_transform(this,0);
        if ((lVar4 == null) ||
           ((lVar4 = Transform.Find(lVar4,"ValueBack",0), lVar4 == null ||
            (lVar4 = Transform.Find(lVar4,"Value",0)) == null))) goto LAB_180b3defa;
        uVar8 = Component.GetComponent(lVar4,DAT_181d6d8c0);
        uVar6 = "";
        if (!this.hideValue) {
          if (1 < this.tagIconType) {
            if ((this.targetTag == null) ||
               (lVar4 = HeroTagData.DataBase(this.targetTag,0)) == null)
            goto LAB_180b3defa;
            uVar6 = "-";
            if (*(char *)(lVar4 + 56) == false) goto LAB_180b3de48;
          }
          if (this.targetTag == null) goto LAB_180b3defa;
          lVar4 = HeroTagData.DataBase(this.targetTag,0);
          if (lVar4 == null) goto LAB_180b3defa;
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
        LAB_180b3de48:
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
              goto LAB_180b3dedb;
            }
          }
        LAB_180b3defa:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        LAB_180b3dedb:
        HeroTagIconController.RefreshInfo(this,0);
    }

    // Token : 0x60017CC
    // RVA   : 0xB3E340   Offset: 0xB3CB40   Length: 0x319
    public void RefreshInfo()
    {
        var pStatics_1570 = *(int64*)(DAT_181d81570 + 184);
        var pStatics_27f0 = *(int64*)(DAT_181d627f0 + 184);
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
          uVar1 = **(uint64 **)(DAT_181d81570 + 184);
          cVar2 = Object.op_Inequality(uVar1,0,0);
          if (!cVar2) {
            if (*pStatics_27f0 == 0) throw; // [null/range check failed]
            lVar7 = *(int64 *)(*pStatics_27f0 + 32);
          }
          else {
            if (*pStatics_1570 == 0) throw; // [null/range check failed]
            lVar7 = *(int64 *)(*pStatics_1570 + 24);
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
        plVar5 = (int64 *)Component.GetComponent(lVar3,DAT_181d6d8c0);
        if (this.targetTag == null) throw; // [null/range check failed]
        if (this.targetTag.sourceHero == null) {
          lVar3 = Component.GetComponent(this,DAT_181d6af40);
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

    // Token : 0x60017CD
    // RVA   : 0xB3D960   Offset: 0xB3C160   Length: 0x2D
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

    // Token : 0x60017CE
    // RVA   : 0xB3DF00   Offset: 0xB3C700   Length: 0x433
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
          lVar5 = **(int64 **)(DAT_181d834f0 + 184);
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
              uVar7 = il2cpp_value_box(DAT_181d7d0b8,local_res8);
              lVar6 = FUN_18046c340(0);
              uVar1 = "消耗{1}天赋点领悟“{0}”吗？{2}";
              if ((lVar6 != null) && (*(int64 *)(lVar6 + 32) != 0)) {
                uVar8 = "";
                if (*(int *)(*(int64 *)(lVar6 + 32) + 88) == 0) {
                  if ((this.targetTag == null) ||
                     (lVar6 = HeroTagData.DataBase(this.targetTag,0)) == null) {
        LAB_180b3e32e:
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
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
                  uVar8 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
                  lVar6 = FUN_18046c340(0);
                  uVar2 = "\n消耗{1}{0}天时间。";
                  if (lVar6 == null) goto LAB_180b3e32e;
                  uVar9 = "";
                  if (*(char *)(lVar6 + 56) != false) {
                    if ((this.targetTag == null) ||
                       (lVar6 = HeroTagData.DataBase(this.targetTag,0)) == null) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
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
                    uVar9 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
                    uVar9 = String.Format("{0}银钱和",uVar9,0);
                  }
                  uVar8 = String.Format(uVar2,uVar8,uVar9,0);
                }
                uVar10 = String.Format(uVar1,uVar10,uVar7,uVar8,0);
                if ((this.targetTag != null) &&
                   (uVar7 = Int32.ToString(this.targetTag + 16,0), lVar5 != null)) {
                  SureMenu.CallSureMenu(lVar5,uVar10,"SureUnderstandTag",uVar7,"UIController",0);
                  return;
                }
                goto LAB_180b3e328;
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (iVar3 == 2) {
          lVar5 = FUN_1807e86e0(0);
          if ((this.targetTag == null) || (lVar5 == null)) {
        LAB_180b3e328:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          StartMenuController.StartChooseTagClicked
                    (lVar5,this.targetTag.tagID,0);
        }
        else if (iVar3 == 3) {
          lVar5 = FUN_1807e86e0(0);
          if ((this.targetTag == null) || (lVar5 == null)) goto LAB_180b3e328;
          StartMenuController.StartUnchooseTagClicked
                    (lVar5,this.targetTag.tagID,0);
        }
    }

    // Token : 0x60017CF
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x60017D0
    // RVA   : 0xB3E7D0   Offset: 0xB3CFD0   Length: 0x69
    private static void /*cctor*/()
    {
        ulong local_18;
        ulong uStack_10;
        local_18 = 0;
        uStack_10 = 0;
        Color.ctor(&local_18,0x3f800000,0x3f48c8c9,0x3f48c8c9,0);
        puVar1 = *(uint64 **)(DAT_181d51580 + 184);
        *puVar1 = local_18;
        puVar1[1] = uStack_10;
    }

}
