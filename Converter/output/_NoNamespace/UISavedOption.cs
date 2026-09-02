// ============================================================
// Type  : UISavedOption
// Token : 0x200005E
// ============================================================

public class UISavedOption
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400023B
    public string keyName;

    // Token: 0x400023C
    private UIPopupList mList;

    // Token: 0x400023D
    private UIToggle mCheck;

    // Token: 0x400023E
    private UIProgressBar mSlider;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000226
    // RVA   : 0x16891E0   Offset: 0x16879E0   Length: 0x5F
    private string get_key()
    {
        bool cVar1;
        ulong uVar2;
        cVar1 = FUN_180d6ca90(this.keyName,0);
        if (cVar1) {
          uVar2 = Object.get_name(this,0);
          uVar2 = String.Concat("NGUI State: ",uVar2,0);
          return uVar2;
        }
        return this.keyName;
    }

    // Token : 0x6000227
    // RVA   : 0x16887A0   Offset: 0x1686FA0   Length: 0x9C
    private void Awake()
    {
        ulong uVar1;
        uVar1 = Component.GetComponent(this,DAT_181d6e340);
        this.mList = uVar1;
        uVar1 = Component.GetComponent(this,DAT_181d6e740);
        this.mCheck = uVar1;
        uVar1 = Component.GetComponent(this,DAT_181d6e3c0);
        this.mSlider = uVar1;
    }

    // Token : 0x6000228
    // RVA   : 0x1688AD0   Offset: 0x16872D0   Length: 0x495
    private void OnEnable()
    {
        long lVar1;
        bool cVar3;
        int iVar4;
        ulong uVar5;
        long lVar6;
        ulong uVar7;
        bool cVar8;
        uint uVar9;
        uint uVar11;
        uVar5 = this.mList;
        cVar3 = Object.op_Inequality(uVar5,0,0);
        if (!cVar3) {
          uVar5 = this.mCheck;
          cVar3 = Object.op_Inequality(uVar5,0,0);
          if (!cVar3) {
            uVar5 = this.mSlider;
            cVar3 = Object.op_Inequality(uVar5,0,0);
            if (!cVar3) {
              uVar5 = UISavedOption.get_key(this,0);
              uVar5 = PlayerPrefs.GetString(uVar5,0);
              lVar6 = FUN_180956ba0(this,1,DAT_181d702c0);
              uVar9 = 0;
              if (lVar6 != null) {
                iVar4 = lVar6.group;
                if (iVar4 < 1) {
                  return;
                }
                while( true ) {
                  if (lVar6.group <= uVar9) {
                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar5,0);
                  }
                  lVar1 = lVar6[uVar9];
                  if (lVar1 == null) break;
                  uVar7 = Object.get_name(lVar1,0);
                  cVar3 = FUN_1816fd990(uVar7,uVar5,0);
                  if (*(char *)(lVar1 + 130) == false) {
                    *(char *)(lVar1 + 72) = cVar3;
                  }
                  else {
                    cVar8 = cVar3;
                    if (*(int *)(lVar1 + 24) == 0) {
                      cVar8 = true;
                    }
                    if ((cVar8) || (*(char *)(lVar1 + 74) != false)) {
                      UIToggle.Set(lVar1,cVar3,1,0);
                    }
                  }
                  uVar9 = uVar9 + 1;
                  if (iVar4 <= (int)uVar9) {
                    return;
                  }
                }
              }
            }
            else if (this.mSlider != null) {
              uVar5 = this.mSlider.onChange;
              uVar7 = new OnTooltipCB(this,DAT_181d9cfc0,0);
              EventDelegate.Add(uVar5,uVar7,0);
              lVar6 = this.mSlider;
              uVar5 = UISavedOption.get_key(this,0);
              if (this.mSlider != null) {
                uVar11 = UIProgressBar.get_value(this.mSlider,0);
                uVar11 = PlayerPrefs.GetFloat(uVar5,uVar11,0);
                if (lVar6 != null) {
                  UIProgressBar.set_value(lVar6,uVar11,0);
                  return;
                }
              }
            }
          }
          else if (this.mCheck != null) {
            uVar5 = this.mCheck.onChange;
            uVar7 = new OnTooltipCB(this,DAT_181d9d0d0,0);
            EventDelegate.Add(uVar5,uVar7,0);
            lVar6 = this.mCheck;
            uVar5 = UISavedOption.get_key(this,0);
            if ((this.mCheck != null) &&
               (iVar4 = PlayerPrefs.GetInt(uVar5,this.mCheck.startsActive,
                                            0), lVar6 != null)) {
              bVar10 = iVar4 != 0;
              if (!lVar6.mStarted) {
                lVar6.startsActive = bVar10;
                return;
              }
              if ((lVar6.group != null && !bVar10) && (!lVar6.optionCanBeNone)) {
                return;
              }
              UIToggle.Set(lVar6,bVar10,1,0);
              return;
            }
          }
        }
        else if (this.mList != null) {
          uVar5 = this.mList.onChange;
          uVar7 = new OnTooltipCB(this,DAT_181d9d048,0);
          EventDelegate.Add(uVar5,uVar7,0);
          cVar3 = FUN_180d6ca90(this.keyName,0);
          if (!cVar3) {
            uVar5 = this.keyName;
          }
          else {
            uVar5 = Object.get_name(this,0);
            uVar5 = String.Concat("NGUI State: ",uVar5,0);
          }
          uVar5 = PlayerPrefs.GetString(uVar5,0);
          cVar3 = FUN_180d6ca90(uVar5,0);
          if (!cVar3) {
            plVar2 = this.mList;
            if (plVar2 == (int64 *)0) throw; // [null/range check failed]
            (**(code **)(*plVar2 + 0x188))(plVar2,uVar5,*(uint64 *)(*plVar2 + 400));
          }
          return;
        }
    }

    // Token : 0x6000229
    // RVA   : 0x1688840   Offset: 0x1687040   Length: 0x28E
    private void OnDisable()
    {
        uint uVar1;
        long lVar2;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        ulong uVar7;
        uint uVar8;
        uVar5 = this.mCheck;
        cVar3 = Object.op_Inequality(uVar5,0,0);
        if (!cVar3) {
          uVar5 = this.mList;
          cVar3 = Object.op_Inequality(uVar5,0,0);
          if (!cVar3) {
            uVar5 = this.mSlider;
            cVar3 = Object.op_Inequality(uVar5,0,0);
            if (!cVar3) {
              lVar4 = FUN_180956ba0(this,1,DAT_181d702c0);
              if (lVar4 != null) {
                uVar1 = *(uint32 *)(lVar4 + 24);
                if (0 < (int)uVar1) {
                  uVar8 = 0;
                  do {
                    if (uVar1 <= uVar8) {
                      uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar5,0);
                    }
                    lVar2 = lVar4[uVar8];
                    if (lVar2 == null) throw; // [null/range check failed]
                    if (*(char *)(lVar2 + 130) == false) {
                      cVar3 = *(char *)(lVar2 + 72);
                    }
                    else {
                      cVar3 = *(char *)(lVar2 + 129);
                    }
                    if (cVar3) {
                      uVar5 = UISavedOption.get_key(this,0);
                      uVar6 = Object.get_name(lVar2,0);
                      PlayerPrefs.SetString(uVar5,uVar6,0);
                      return;
                    }
                    uVar8 = uVar8 + 1;
                  } while ((int)uVar8 < (int)uVar1);
                }
                return;
              }
            }
            else if (this.mSlider != null) {
              uVar5 = this.mSlider.onChange;
              uVar7 = il2cpp_internal(DAT_181d50fa8);
              uVar6 = DAT_181d9cfc0;
              goto LAB_181688a6d;
            }
          }
          else if (this.mList != null) {
            uVar5 = this.mList.onChange;
            uVar7 = il2cpp_internal(DAT_181d50fa8);
            uVar6 = DAT_181d9d048;
            goto LAB_181688a6d;
          }
        }
        else if (this.mCheck != null) {
          uVar5 = this.mCheck.onChange;
          uVar7 = il2cpp_internal(DAT_181d50fa8);
          uVar6 = DAT_181d9d0d0;
        LAB_181688a6d:
          OnTooltipCB.ctor(uVar7,this,uVar6,0);
          EventDelegate.Remove(uVar5,uVar7,0);
          return;
        }
    }

    // Token : 0x600022A
    // RVA   : 0x1689020   Offset: 0x1687820   Length: 0xD4
    public void SaveSelection()
    {
        bool cVar2;
        ulong uVar3;
        ulong uVar4;
        cVar2 = FUN_180d6ca90(this.keyName,0);
        if (!cVar2) {
          uVar3 = this.keyName;
        }
        else {
          uVar3 = Object.get_name(this,0);
          uVar3 = String.Concat("NGUI State: ",uVar3,0);
        }
        plVar1 = (int64 *)**(int64 **)(DAT_181d8add8 + 184);
        if (plVar1 != (int64 *)0) {
          uVar4 = (**(code **)(*plVar1 + 0x178))(plVar1,*(uint64 *)(*plVar1 + 0x180));
          PlayerPrefs.SetString(uVar3,uVar4,0);
          return;
        }
    }

    // Token : 0x600022B
    // RVA   : 0x1689100   Offset: 0x1687900   Length: 0xDF
    public void SaveState()
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        cVar2 = FUN_180d6ca90(this.keyName,0);
        if (!cVar2) {
          uVar3 = this.keyName;
        }
        else {
          uVar3 = Object.get_name(this,0);
          uVar3 = String.Concat("NGUI State: ",uVar3,0);
        }
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d8b2d8 + 184) + 8);
        if (lVar1 != null) {
          if (*(char *)(lVar1 + 130) == false) {
            cVar2 = *(char *)(lVar1 + 72);
          }
          else {
            cVar2 = *(char *)(lVar1 + 129);
          }
          PlayerPrefs.SetInt(uVar3,cVar2,0);
          return;
        }
    }

    // Token : 0x600022C
    // RVA   : 0x1688F70   Offset: 0x1687770   Length: 0xAA
    public void SaveProgress()
    {
        var pStatics = *(int64*)(DAT_181d8ae58 + 184);
        bool cVar1;
        ulong uVar2;
        uint uVar3;
        cVar1 = FUN_180d6ca90(this.keyName,0);
        if (!cVar1) {
          uVar2 = this.keyName;
        }
        else {
          uVar2 = Object.get_name(this,0);
          uVar2 = String.Concat("NGUI State: ",uVar2,0);
        }
        if (*pStatics != 0) {
          uVar3 = UIProgressBar.get_value(*pStatics,0);
          PlayerPrefs.SetFloat(uVar2,uVar3,0);
          return;
        }
    }

    // Token : 0x600022D
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
