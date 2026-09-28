// ============================================================
// Type  : UISavedOption
// Token : 0x200005F
// ============================================================

public class UISavedOption
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000257
    public string keyName;

    // Token: 0x4000258
    private UIPopupList mList;

    // Token: 0x4000259
    private UIToggle mCheck;

    // Token: 0x400025A
    private UIProgressBar mSlider;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600023E
    // RVA   : 0x1700C80   Offset: 0x1700080   Length: 0x5F
    private string get_key()
    {
        bool cVar1;
        ulong uVar2;
        cVar1 = FUN_180d755b0(this.keyName,0);
        if (cVar1) {
          uVar2 = Object.get_name(this,0);
          uVar2 = String.Concat("NGUI State: ",uVar2,0);
          return uVar2;
        }
        return this.keyName;
    }

    // Token : 0x600023F
    // RVA   : 0x1700250   Offset: 0x16FF650   Length: 0x9C
    private void Awake()
    {
        ulong uVar1;
        uVar1 = Component.GetComponent(this,DAT_181d96be0);
        this.mList = uVar1;
        uVar1 = Component.GetComponent(this,DAT_181d96fe0);
        this.mCheck = uVar1;
        uVar1 = Component.GetComponent(this,DAT_181d96c60);
        this.mSlider = uVar1;
    }

    // Token : 0x6000240
    // RVA   : 0x1700580   Offset: 0x16FF980   Length: 0x453
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
              lVar6 = FUN_180967490(this,1,DAT_181d98be0);
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
                    FUN_1800d65f0(uVar5,0);
                  }
                  lVar1 = lVar6[uVar8];
                  if (lVar1 == null) break;
                  uVar7 = Object.get_name(lVar1,0);
                  FUN_18171e540(uVar7,uVar5,0);
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
              uVar7 = new OnTooltipCB(this,DAT_181dc62b0,0);
              EventDelegate.Add(uVar5,uVar7,0);
              lVar6 = this.mSlider;
              uVar5 = UISavedOption.get_key(this,0);
              lVar1 = this.mSlider;
              if (lVar1 != null) {
                fVar9 = lVar1.mValue;
                if (1 < lVar1.numberOfSteps) {
                  fVar9 = (float)FUN_18000d7c0((float)(lVar1.numberOfSteps + -1) * fVar9);
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
            uVar7 = new OnTooltipCB(this,DAT_181dc63c0,0);
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
          uVar7 = new OnTooltipCB(this,DAT_181dc6338,0);
          EventDelegate.Add(uVar5,uVar7,0);
          cVar3 = FUN_180d755b0(this.keyName,0);
          if (!cVar3) {
            uVar5 = this.keyName;
          }
          else {
            uVar5 = Object.get_name(this,0);
            uVar5 = String.Concat("NGUI State: ",uVar5,0);
          }
          uVar5 = PlayerPrefs.GetString(uVar5,0);
          cVar3 = FUN_180d755b0(uVar5,0);
          if (!cVar3) {
            plVar2 = this.mList;
            if (plVar2 == (int64 *)0) throw; // [null/range check failed]
            (**(code **)(*plVar2 + 0x188))(plVar2,uVar5,*(uint64 *)(*plVar2 + 400));
          }
          return;
        }
    }

    // Token : 0x6000241
    // RVA   : 0x17002F0   Offset: 0x16FF6F0   Length: 0x282
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
              lVar4 = FUN_180967490(this,1,DAT_181d98be0);
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
                    FUN_1800d65f0(uVar5,0);
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
              uVar7 = il2cpp_internal(DAT_181d76190);
              uVar6 = DAT_181dc62b0;
              goto LAB_18170051b;
            }
          }
          else if (this.mList != null) {
            uVar5 = this.mList.onChange;
            uVar7 = il2cpp_internal(DAT_181d76190);
            uVar6 = DAT_181dc6338;
            goto LAB_18170051b;
          }
        }
        else if (this.mCheck != null) {
          uVar5 = this.mCheck.onChange;
          uVar7 = il2cpp_internal(DAT_181d76190);
          uVar6 = DAT_181dc63c0;
        LAB_18170051b:
          OnTooltipCB.ctor(uVar7,this,uVar6,0);
          EventDelegate.Remove(uVar5,uVar7,0);
          return;
        }
    }

    // Token : 0x6000242
    // RVA   : 0x1700AC0   Offset: 0x16FFEC0   Length: 0xD4
    public void SaveSelection()
    {
        bool cVar2;
        ulong uVar3;
        ulong uVar4;
        cVar2 = FUN_180d755b0(this.keyName,0);
        if (!cVar2) {
          uVar3 = this.keyName;
        }
        else {
          uVar3 = Object.get_name(this,0);
          uVar3 = String.Concat("NGUI State: ",uVar3,0);
        }
        plVar1 = (int64 *)**(int64 **)(DAT_181dafff8 + 184);
        if (plVar1 != (int64 *)0) {
          uVar4 = (**(code **)(*plVar1 + 0x178))(plVar1,*(uint64 *)(*plVar1 + 0x180));
          PlayerPrefs.SetString(uVar3,uVar4,0);
          return;
        }
    }

    // Token : 0x6000243
    // RVA   : 0x1700BA0   Offset: 0x16FFFA0   Length: 0xD0
    public void SaveState()
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        cVar2 = FUN_180d755b0(this.keyName,0);
        if (!cVar2) {
          uVar3 = this.keyName;
        }
        else {
          uVar3 = Object.get_name(this,0);
          uVar3 = String.Concat("NGUI State: ",uVar3,0);
        }
        lVar1 = *(int64 *)(*(int64 *)(DAT_181db04f8 + 184) + 8);
        if (lVar1 != null) {
          cVar2 = UIToggle.get_isChecked(lVar1,0);
          PlayerPrefs.SetInt(uVar3,cVar2,0);
          return;
        }
    }

    // Token : 0x6000244
    // RVA   : 0x17009E0   Offset: 0x16FFDE0   Length: 0xDC
    public void SaveProgress()
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        float fVar4;
        cVar2 = FUN_180d755b0(this.keyName,0);
        if (!cVar2) {
          uVar3 = this.keyName;
        }
        else {
          uVar3 = Object.get_name(this,0);
          uVar3 = String.Concat("NGUI State: ",uVar3,0);
        }
        lVar1 = **(int64 **)(DAT_181db0078 + 184);
        if (lVar1 != null) {
          fVar4 = *(float *)(lVar1 + 56);
          if (1 < *(int *)(lVar1 + 100)) {
            fVar4 = (float)FUN_18000d7c0((float)(*(int *)(lVar1 + 100) + -1) * fVar4);
            fVar4 = fVar4 / (float)(*(int *)(lVar1 + 100) + -1);
          }
          PlayerPrefs.SetFloat(uVar3,fVar4,0);
          return;
        }
    }

    // Token : 0x6000245
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
