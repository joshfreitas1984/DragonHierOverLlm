// ============================================================
// Type  : UISavedOption
// Token : 0x200005E
// ============================================================

public class UISavedOption
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000237
    public string keyName;

    // Token: 0x4000238
    private UIPopupList mList;

    // Token: 0x4000239
    private UIToggle mCheck;

    // Token: 0x400023A
    private UIProgressBar mSlider;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000225
    // RVA   : 0x16035C0   Offset: 0x16023C0   Length: 0x5F
    private string get_key()
    {
        bool cVar1;
        ulong uVar2;
        cVar1 = FUN_180ad1200(this.keyName,0);
        if (cVar1) {
          uVar2 = Object.get_name(this,0);
          uVar2 = String.Concat("NGUI State: ",uVar2,0);
          return uVar2;
        }
        return this.keyName;
    }

    // Token : 0x6000226
    // RVA   : 0x1602B90   Offset: 0x1601990   Length: 0x9C
    private void Awake()
    {
        ulong uVar1;
        uVar1 = Component.GetComponent(this,DAT_181e79fb8);
        this.mList = uVar1;
        uVar1 = Component.GetComponent(this,DAT_181e7a3b8);
        this.mCheck = uVar1;
        uVar1 = Component.GetComponent(this,DAT_181e7a038);
        this.mSlider = uVar1;
    }

    // Token : 0x6000227
    // RVA   : 0x1602EC0   Offset: 0x1601CC0   Length: 0x453
    private void OnEnable()
    {
        long lVar1;
        bool cVar3;
        int iVar4;
        ulong uVar5;
        long lVar6;
        ulong uVar7;
        uint uVar8;
        float fVar9;
        uint uVar10;
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
              lVar6 = FUN_180772540(this,1,DAT_181e7bfb8);
              uVar8 = 0;
              if (lVar6 != null) {
                iVar4 = lVar6.group;
                if (iVar4 < 1) {
                  return;
                }
                while( true ) {
                  if (lVar6.group <= uVar8) {
                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar5,0);
                  }
                  lVar1 = lVar6[uVar8];
                  if (lVar1 == null) break;
                  uVar7 = Object.get_name(lVar1,0);
                  FUN_1816387f0(uVar7,uVar5,0);
                  UIToggle.set_isChecked(lVar1);
                  uVar8 = uVar8 + 1;
                  if (iVar4 <= (int)uVar8) {
                    return;
                  }
                }
              }
            }
            else if (this.mSlider != null) {
              uVar5 = this.mSlider.onChange;
              uVar7 = new OnTooltipCB(this,DAT_181e52718,0);
              EventDelegate.Add(uVar5,uVar7,0);
              lVar6 = this.mSlider;
              uVar5 = UISavedOption.get_key(this,0);
              lVar1 = this.mSlider;
              if (lVar1 != null) {
                fVar9 = lVar1.mValue;
                if (1 < lVar1.numberOfSteps) {
                  fVar9 = (float)FUN_18007dbc0((float)(lVar1.numberOfSteps + -1) * fVar9);
                  fVar9 = fVar9 / (float)(lVar1.numberOfSteps + -1);
                }
                uVar10 = PlayerPrefs.GetFloat(uVar5,fVar9,0);
                if (lVar6 != null) {
                  UIProgressBar.Set(lVar6,uVar10,1,0);
                  return;
                }
              }
            }
          }
          else if (this.mCheck != null) {
            uVar5 = this.mCheck.onChange;
            uVar7 = new OnTooltipCB(this,DAT_181e52828,0);
            EventDelegate.Add(uVar5,uVar7,0);
            lVar6 = this.mCheck;
            uVar5 = UISavedOption.get_key(this,0);
            if (this.mCheck != null) {
              iVar4 = PlayerPrefs.GetInt(uVar5,this.mCheck.startsActive,0)
              ;
              if (lVar6 != null) {
                UIToggle.set_isChecked(lVar6,iVar4 != 0,0);
                return;
              }
            }
          }
        }
        else if (this.mList != null) {
          uVar5 = this.mList.onChange;
          uVar7 = new OnTooltipCB(this,DAT_181e527a0,0);
          EventDelegate.Add(uVar5,uVar7,0);
          cVar3 = FUN_180ad1200(this.keyName,0);
          if (!cVar3) {
            uVar5 = this.keyName;
          }
          else {
            uVar5 = Object.get_name(this,0);
            uVar5 = String.Concat("NGUI State: ",uVar5,0);
          }
          uVar5 = PlayerPrefs.GetString(uVar5,0);
          cVar3 = FUN_180ad1200(uVar5,0);
          if (!cVar3) {
            plVar2 = this.mList;
            if (plVar2 == (int64 *)0) throw; // [null/range check failed]
            (**(code **)(*plVar2 + 0x188))(plVar2,uVar5,*(uint64 *)(*plVar2 + 400));
          }
          return;
        }
    }

    // Token : 0x6000228
    // RVA   : 0x1602C30   Offset: 0x1601A30   Length: 0x282
    private void OnDisable()
    {
        int iVar1;
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
              lVar4 = FUN_180772540(this,1,DAT_181e7bfb8);
              uVar8 = 0;
              if (lVar4 != null) {
                iVar1 = *(int *)(lVar4 + 24);
                if (iVar1 < 1) {
                  return;
                }
                while( true ) {
                  if (*(uint32 *)(lVar4 + 24) <= uVar8) {
                    uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar5,0);
                  }
                  lVar2 = lVar4[uVar8];
                  if (lVar2 == null) break;
                  cVar3 = UIToggle.get_isChecked(lVar2);
                  if (cVar3) {
                    uVar5 = UISavedOption.get_key(this,0);
                    uVar6 = Object.get_name(lVar2,0);
                    PlayerPrefs.SetString(uVar5,uVar6,0);
                    return;
                  }
                  uVar8 = uVar8 + 1;
                  if (iVar1 <= (int)uVar8) {
                    return;
                  }
                }
              }
            }
            else if (this.mSlider != null) {
              uVar5 = this.mSlider.onChange;
              uVar7 = il2cpp_internal(DAT_181e55f58);
              uVar6 = DAT_181e52718;
              goto LAB_181602e5b;
            }
          }
          else if (this.mList != null) {
            uVar5 = this.mList.onChange;
            uVar7 = il2cpp_internal(DAT_181e55f58);
            uVar6 = DAT_181e527a0;
            goto LAB_181602e5b;
          }
        }
        else if (this.mCheck != null) {
          uVar5 = this.mCheck.onChange;
          uVar7 = il2cpp_internal(DAT_181e55f58);
          uVar6 = DAT_181e52828;
        LAB_181602e5b:
          OnTooltipCB.ctor(uVar7,this,uVar6,0);
          EventDelegate.Remove(uVar5,uVar7,0);
          return;
        }
    }

    // Token : 0x6000229
    // RVA   : 0x1603400   Offset: 0x1602200   Length: 0xD4
    public void SaveSelection()
    {
        bool cVar2;
        ulong uVar3;
        ulong uVar4;
        cVar2 = FUN_180ad1200(this.keyName,0);
        if (!cVar2) {
          uVar3 = this.keyName;
        }
        else {
          uVar3 = Object.get_name(this,0);
          uVar3 = String.Concat("NGUI State: ",uVar3,0);
        }
        plVar1 = (int64 *)UIPopupList.current;
        if (plVar1 != (int64 *)0) {
          uVar4 = (**(code **)(*plVar1 + 0x178))(plVar1,*(uint64 *)(*plVar1 + 0x180));
          PlayerPrefs.SetString(uVar3,uVar4,0);
          return;
        }
    }

    // Token : 0x600022A
    // RVA   : 0x16034E0   Offset: 0x16022E0   Length: 0xD0
    public void SaveState()
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        cVar2 = FUN_180ad1200(this.keyName,0);
        if (!cVar2) {
          uVar3 = this.keyName;
        }
        else {
          uVar3 = Object.get_name(this,0);
          uVar3 = String.Concat("NGUI State: ",uVar3,0);
        }
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e90950 + 184) + 8);
        if (lVar1 != null) {
          cVar2 = UIToggle.get_isChecked(lVar1,0);
          PlayerPrefs.SetInt(uVar3,cVar2,0);
          return;
        }
    }

    // Token : 0x600022B
    // RVA   : 0x1603320   Offset: 0x1602120   Length: 0xDC
    public void SaveProgress()
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        float fVar4;
        cVar2 = FUN_180ad1200(this.keyName,0);
        if (!cVar2) {
          uVar3 = this.keyName;
        }
        else {
          uVar3 = Object.get_name(this,0);
          uVar3 = String.Concat("NGUI State: ",uVar3,0);
        }
        lVar1 = **(int64 **)(DAT_181e904d0 + 184);
        if (lVar1 != null) {
          fVar4 = *(float *)(lVar1 + 56);
          if (1 < *(int *)(lVar1 + 100)) {
            fVar4 = (float)FUN_18007dbc0((float)(*(int *)(lVar1 + 100) + -1) * fVar4);
            fVar4 = fVar4 / (float)(*(int *)(lVar1 + 100) + -1);
          }
          PlayerPrefs.SetFloat(uVar3,fVar4,0);
          return;
        }
    }

    // Token : 0x600022C
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
