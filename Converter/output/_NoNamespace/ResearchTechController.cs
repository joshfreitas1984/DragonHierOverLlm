// ============================================================
// Type  : ResearchTechController
// Token : 0x200033D
// ============================================================

public class ResearchTechController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001A20
    public ForceTechLvData targetLvData;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600202B
    // RVA   : 0xC621C0   Offset: 0xC609C0   Length: 0x1F1
    private void Update()
    {
        long lVar1;
        long lVar2;
        ulong local_28;
        ulong uStack_20;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        lVar2 = this.targetLvData;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d77350 + 184) + 8);
        if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 48)) != null) {
          lVar1 = ForceData.GetNowResearchTech(lVar1,0);
          if ((lVar2 == lVar1) && (this.targetLvData != null)) {
            lVar2 = Component.get_transform(this,0);
            if (lVar2 != null) {
              lVar2 = Transform.Find(lVar2,"DecorationBack",0);
              if (lVar2 != null) {
                plVar3 = (int64 *)Component.GetComponent(lVar2,DAT_181d6bc40);
                local_28 = 0;
                uStack_20 = 0;
                Color.ctor(&local_28,0x3f000000,0x3f800000,0x3f800000,0);
                if (plVar3 != (int64 *)0) {
                  local_18 = (uint32)local_28;
                  uStack_14 = local_28._4_4_;
                  uStack_10 = (uint32)uStack_20;
                  uStack_c = uStack_20._4_4_;
        LAB_180c6232f:
                  (**(code **)(*plVar3 + 0x2a8))(plVar3,&local_18,*(uint64 *)(*plVar3 + 0x2b0));
                  return;
                }
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar2 = Component.get_transform(this,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"DecorationBack",0);
            if (lVar2 != null) {
              plVar3 = (int64 *)Component.GetComponent(lVar2,DAT_181d6bc40);
              puVar4 = (uint32 *)FUN_181098a50(&local_18,0);
              if (plVar3 != (int64 *)0) {
                local_18 = *puVar4;
                uStack_14 = puVar4[1];
                uStack_10 = puVar4[2];
                uStack_c = puVar4[3];
                goto LAB_180c6232f;
              }
            }
          }
        }
    }

    // Token : 0x600202C
    // RVA   : 0xC61B50   Offset: 0xC60350   Length: 0x662
    public void Refresh()
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        float fVar8;
        float[] local_res8 = new float[2];
        uint[] local_res18 = new uint[4];
        local_res8[0] = 0.0;
        if (this.targetLvData == null) {
          lVar1 = Component.get_transform(this);
          if ((lVar1 != null) && (lVar1 = Transform.Find(lVar1,"Title",0)) != null) {
            uVar2 = Component.GetComponent(lVar1,DAT_181d6d8c0);
            LTLocalization.SetText(uVar2,"无",0);
            lVar1 = Component.get_transform(this,0);
            if ((lVar1 != null) && (lVar1 = Transform.Find(lVar1,"Lv",0)) != null) {
              uVar2 = Component.GetComponent(lVar1,DAT_181d6d8c0);
              LTLocalization.SetText(uVar2,"",0);
              lVar1 = Component.get_transform(this,0);
              if ((lVar1 != null) && (lVar1 = Transform.Find(lVar1,"Text",0)) != null) {
                uVar2 = Component.GetComponent(lVar1,DAT_181d6d8c0);
                LTLocalization.SetText(uVar2,"",0);
                lVar1 = Component.get_transform(this,0);
                if ((lVar1 != null) &&
                   ((lVar1 = Transform.Find(lVar1,"TimeBar",0), lVar1 != null &&
                    (lVar1 = Component.GetComponent(lVar1,DAT_181d6bc40)) != null))) {
                  Image.set_fillAmount(lVar1,0,0);
                  lVar1 = Component.get_transform(this,0);
                  if ((lVar1 != null) && (lVar1 = Transform.Find(lVar1,"TimeText",0)) != null) {
                    uVar2 = Component.GetComponent(lVar1,DAT_181d6d8c0);
                    LTLocalization.SetText(uVar2,"",0);
                    lVar1 = Component.GetComponent(this,DAT_181d6ccc0);
                    uVar2 = "";
                    if (lVar1 != null) {
                      lVar1.researchPercent = "";
        LAB_180c61fe2:
                      il2cpp_internal(puVar7,uVar2);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
        else {
          lVar1 = Component.get_transform(this);
          if ((lVar1 != null) && (lVar1 = Transform.Find(lVar1,"Title",0)) != null) {
            uVar2 = Component.GetComponent(lVar1,DAT_181d6d8c0);
            if ((this.targetLvData != null) &&
               (lVar1 = ForceTechLvData.Database(this.targetLvData,0)) != null) {
              LTLocalization.SetText(uVar2,lVar1.researchPercent,0);
              lVar1 = Component.get_transform(this,0);
              if ((lVar1 != null) && (lVar1 = Transform.Find(lVar1,"Lv",0)) != null) {
                uVar2 = Component.GetComponent(lVar1,DAT_181d6d8c0);
                if (this.targetLvData != null) {
                  uVar3 = Int32.ToString(this.targetLvData + 20,0);
                  uVar3 = String.Concat("等级",uVar3,0);
                  LTLocalization.SetText(uVar2,uVar3,0);
                  lVar1 = Component.get_transform(this,0);
                  if ((lVar1 != null) && (lVar1 = Transform.Find(lVar1,"Text",0)) != null) {
                    uVar2 = Component.GetComponent(lVar1,DAT_181d6d8c0);
                    if (this.targetLvData != null) {
                      uVar3 = ForceTechLvData.GetSpeDescribe(this.targetLvData,0);
                      LTLocalization.SetText(uVar2,uVar3,0);
                      lVar1 = Component.get_transform(this,0);
                      if ((lVar1 != null) && (lVar1 = Transform.Find(lVar1,"TimeBar",0)) != null) {
                        lVar1 = Component.GetComponent(lVar1,DAT_181d6bc40);
                        if ((this.targetLvData != null) && (lVar1 != null)) {
                          Image.set_fillAmount
                                    (lVar1,this.targetLvData.researchPercent,0);
                          lVar1 = Component.get_transform(this,0);
                          if ((lVar1 != null) && (lVar1 = Transform.Find(lVar1,"TimeText",0)) != null
                             ) {
                            uVar2 = Component.GetComponent(lVar1,DAT_181d6d8c0);
                            if (this.targetLvData != null) {
                              fVar8 = this.targetLvData.researchPercent;
                              uVar3 = "";
                              if (fVar8 != 0.0) {
                                local_res8[0] = fVar8 * 100.0;
                                uVar3 = Single.ToString(local_res8,"f0",0);
                                uVar3 = String.Concat(uVar3,"%",0);
                              }
                              LTLocalization.SetText(uVar2,uVar3,0);
                              lVar4 = Component.GetComponent(this,DAT_181d6ccc0);
                              lVar1 = this.targetLvData;
                              if (lVar1 != null) {
                                uVar2 = "登峰造极";
                                if (lVar1.lv < 10) {
                                  lVar1 = ForceTechLvData.GetResearchCostResource(lVar1,0x3f800000,0);
                                  if (lVar1 == null) {
        LAB_180c621ad:
                          // WARNING: Subroutine does not return
                                    FUN_1800d6620();
                                  }
                                  uVar2 = ResourceData.GetDescribe(lVar1,0);
                                  lVar1 = this.targetLvData;
                                  lVar5 = FUN_180bb4ed0(0);
                                  if ((((lVar5 == null) || (*(int64 *)(lVar5 + 48) == 0)) ||
                                      (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 48) + 0x148),
                                      lVar5 == null)) ||
                                     (fVar8 = (float)ForceSpeAddData.Get(lVar5,4), lVar1 == null))
                                  goto LAB_180c621ad;
                                  local_res18[0] =
                                       ForceTechLvData.GetResearchLeftDay(lVar1,fVar8 + 1.0,0);
                                  uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
                                  lVar1 = this.targetLvData;
                                  if (lVar1 == null) goto LAB_180c621ad;
                                  uVar6 = ForceTechLvData.GetSpeDescribe
                                                    (lVar1,lVar1.lv + 1,0);
                                  uVar2 = String.Format("下一等级 {2}\n消耗资源 {0}\n研究时间 {1}日",uVar2,uVar3,uVar6,0);
                                }
                                if (lVar4 != null) {
                                  puVar7 = (uint64 *)(lVar4 + 24);
                                  *puVar7 = uVar2;
                                  goto LAB_180c61fe2;
                                }
                              }
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600202D
    // RVA   : 0xC61860   Offset: 0xC60060   Length: 0x2E2
    public void OnClick()
    {
        int iVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        long lVar6;
        lVar6 = *(int64 *)(*(int64 *)(DAT_181d77350 + 184) + 8);
        if (lVar6 != null) {
          iVar1 = *(int *)(lVar6 + 24);
          if (iVar1 == 0) {
            lVar6 = **(int64 **)(DAT_181d4df90 + 184);
            lVar3 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x3d0);
            uVar2 = **(uint32 **)(DAT_181d77350 + 184);
            if (lVar3 != null) {
              if (*(uint32 *)(lVar3 + 24) <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar4 = String.Format("本门{0}方能设置",
                                     *(uint64 *)
                                      (*(int64 *)(lVar3 + 16) + 32 + (int64)(int)uVar2 * 8),0);
              if (lVar6 != null) {
                GameController.ShowTextOnMouse(lVar6,uVar4,0);
                plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
                plVar7 = (int64 *)0;
                if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181d8a228)) {
                  plVar7 = plVar5;
                }
                NGUITools.PlaySound(plVar7,0);
                return;
              }
            }
          }
          else {
            if (iVar1 != 1) {
              return;
            }
            lVar6 = FUN_180bb4ed0(0);
            if (lVar6 != null) {
              ResearchUIController.ResearchTechClicked(lVar6,this.targetLvData,0);
              return;
            }
          }
        }
    }

    // Token : 0x600202E
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
