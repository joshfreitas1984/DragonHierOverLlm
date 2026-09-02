// ============================================================
// Type  : WorkingUIController
// Token : 0x20003AF
// ============================================================

public class WorkingUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001CFE
    public GameObject workingUI;

    // Token: 0x4001CFF
    public string workName;

    // Token: 0x4001D00
    public string workingFuc;

    // Token: 0x4001D01
    public string workingFucParam;

    // Token: 0x4001D02
    public string finishFuc;

    // Token: 0x4001D03
    public string finishFucParam;

    // Token: 0x4001D04
    public bool working;

    // Token: 0x4001D05
    public int leftWorkingDay;

    // Token: 0x4001D06
    public int totalWorkingDay;

    // Token: 0x4001D07
    public float nextDayTime;

    // Token: 0x4001D08
    public float leftPauseTime;

    // Token: 0x4001D09
    private static float dayTime;

    // Token: 0x4001D0A
    private static float pauseTime;

    // Token: 0x4001D0B
    public float resourceNum;

    // Token: 0x4001D0C
    public bool workFinished;

    // Token: 0x4001D0D
    public bool noCancel;

    // Token: 0x4001D0E
    public bool skipping;

    // Token: 0x4001D0F
    public GameObject skipButton;

    // Token: 0x4001D10
    private GameObject newObj;

    // Token: 0x4001D11
    private static WorkingUIController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002320
    // RVA   : 0x9E8E10   Offset: 0x9E7610   Length: 0x58
    public static WorkingUIController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d90b30 + 184) + 8);
    }

    // Token : 0x6002321
    // RVA   : 0x9E7770   Offset: 0x9E5F70   Length: 0x68
    private void Awake()
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d90b30 + 184) + 8);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6002322
    // RVA   : 0x9E83B0   Offset: 0x9E6BB0   Length: 0xA0F
    private void Update()
    {
        var pStatics_0b30 = *(int64*)(DAT_181d90b30 + 184);
        var pStatics_1d80 = *(int64*)(DAT_181d51d80 + 184);
        var pStatics_c960 = *(int64*)(DAT_181d6c960 + 184);
        var pStatics_e010 = *(int64*)(DAT_181d4e010 + 184);
        var pStatics_f230 = *(int64*)(DAT_181d7f230 + 184);
        long lVar1;
        bool cVar2;
        int iVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        uint uVar9;
        float fVar10;
        float fVar11;
        float fVar12;
        int[] local_res8 = new int[2];
        if (!this.working) {
          return;
        }
        if (((this.workingUI != null) &&
            (lVar4 = GameObject.get_transform(this.workingUI,0)) != null) &&
           (lVar4 = Transform.Find(lVar4,"TimeLabel",0)) != null) {
          uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
          uVar6 = "完";
          if (this.leftWorkingDay != null) {
            local_res8[0] = this.leftWorkingDay;
            uVar6 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
            uVar6 = String.Format("{0}天",uVar6,0);
          }
          LTLocalization.SetText(uVar5,uVar6,0);
          if (((this.workingUI != null) &&
              (lVar4 = GameObject.get_transform(this.workingUI,0)) != null) &&
             (lVar4 = Transform.Find(lVar4,"WorkLabel",0)) != null) {
            uVar6 = Component.GetComponent(lVar4,DAT_181d6d8c0);
            uVar5 = String.Format("{0}中...",this.workName,0);
            LTLocalization.SetText(uVar6,uVar5,0);
            if (((this.workingUI != null) &&
                (lVar4 = GameObject.get_transform(this.workingUI,0)) != null) &&
               (lVar4 = Transform.Find(lVar4,"ResourceLabel",0)) != null) {
              uVar5 = Component.GetComponent(lVar4,DAT_181d6d8c0);
              uVar6 = "";
              if (0.0 < this.resourceNum) {
                uVar6 = Single.ToString((float *)(this + 92),"f0",0);
                uVar6 = String.Format("({0})",uVar6,0);
              }
              LTLocalization.SetText(uVar5,uVar6,0);
              if (*pStatics_c960 != 0) {
                if (*(char *)(*pStatics_c960 + 24) == false) {
                  if ((*pStatics_f230 == 0) ||
                     (lVar4 = *(int64 *)(*pStatics_f230 + 40)) == null)
                  throw; // [null/range check failed]
                  cVar2 = GameObject.get_activeSelf(lVar4,0);
                  if (!cVar2) {
                    if (*pStatics_1d80 == 0) throw; // [null/range check failed]
                    cVar2 = HudController.HudPanelActive(*pStatics_1d80,0);
                    if (!cVar2) {
                      if ((((this.workingUI != null) &&
                           (lVar4 = GameObject.get_transform(this.workingUI,0), lVar4 != null
                           )) && (lVar4 = Transform.Find(lVar4,"TimeAnim",0)) != null) &&
                         (lVar4 = Component.GetComponent(lVar4,DAT_181d6ce40)) != null) {
                        lVar4 = SkeletonGraphic.get_AnimationState(lVar4,0);
                        fVar12 = 1.0;
                        if (!this.skipping) {
                          uVar9 = 0x3f800000;
                        }
                        else {
                          lVar1 = *(int64 *)(pStatics_e010 + 8);
                          if ((lVar1 == null) || (lVar1 = *(int64 *)(lVar1 + 16)) == null)
                          throw; // [null/range check failed]
                          iVar3 = PlayerPrefDictionary.GetInt(lVar1,"TestMode",0);
                          if (iVar3 == 1) {
                            uVar9 = 0x40a00000;
                          }
                          else {
                            uVar9 = 0x40000000;
                          }
                        }
                        if (lVar4 != null) {
                          *(uint32 *)(lVar4 + 108) = uVar9;
                          fVar11 = this.leftPauseTime;
                          if (0.0 < fVar11) {
                            fVar12 = (float)RealTime.get_deltaTime(0);
                            fVar11 = fVar11 - fVar12;
                            this.leftPauseTime = fVar11;
                            if (0.0 < fVar11) {
                              return;
                            }
                            if (this.leftWorkingDay < 1) {
                              return;
                            }
                            if ((((this.workingUI != null) &&
                                 (lVar4 = GameObject.get_transform(this.workingUI,0),
                                 lVar4 != null)) &&
                                (lVar4 = Transform.Find(lVar4,"TimeAnim",0)) != null) &&
                               ((lVar4 = Component.GetComponent(lVar4,DAT_181d6ce40), lVar4 != null &&
                                (lVar4 = SkeletonGraphic.get_AnimationState(lVar4,0)) != null))) {
                              AnimationState.AddAnimation(lVar4,0,"rotate",0,0,0);
                              plVar7 = (int64 *)Resources.Load("Sound/SoundEffect/打更",0);
                              plVar8 = (int64 *)0;
                              if ((plVar7 != (int64 *)0) && (*plVar7 == DAT_181d8a228)) {
                                plVar8 = plVar7;
                              }
                              NGUITools.PlaySound(plVar8,0x3ecccccd,0);
                              return;
                            }
                          }
                          else if (this.leftWorkingDay < 1) {
                            this.workFinished = 1;
                            cVar2 = String.op_Inequality(this.finishFuc,"",0)
                            ;
                            if (cVar2) {
                              cVar2 = String.op_Inequality
                                                (this.finishFucParam,"",0);
                              if (!cVar2) {
                                lVar4 = FUN_18046c440(0);
                                if (lVar4 == null) throw; // [null/range check failed]
                                Component.SendMessage(lVar4,this.finishFuc,0);
                              }
                              else {
                                lVar4 = FUN_18046c440(0);
                                if (lVar4 == null) throw; // [null/range check failed]
                                Component.SendMessage
                                          (lVar4,this.finishFuc,
                                           this.finishFucParam,0);
                              }
                            }
                            this.working = 0;
                            if (this.workingUI != null) {
                              GameObject.SetActive(this.workingUI,0,0);
                              return;
                            }
                          }
                          else {
                            fVar11 = this.nextDayTime;
                            fVar10 = (float)RealTime.get_deltaTime(0);
                            fVar10 = fVar10 + fVar11;
                            this.nextDayTime = fVar10;
                            fVar11 = **(float **)(DAT_181d90b30 + 184);
                            if (this.skipping) {
                              lVar4 = *(int64 *)(pStatics_e010 + 8);
                              if ((lVar4 == null) || (lVar4 = *(int64 *)(lVar4 + 16)) == null)
                              throw; // [null/range check failed]
                              iVar3 = PlayerPrefDictionary.GetInt(lVar4,"TestMode",0);
                              if (iVar3 == 1) {
                                fVar12 = 0.2;
                              }
                              else {
                                fVar12 = 0.5;
                              }
                            }
                            if (fVar10 < fVar11 * fVar12) {
                              return;
                            }
                            if ((this.workingFuc != null) &&
                               (cVar2 = String.op_Inequality
                                                  (this.workingFuc,"",0),
                               cVar2)) {
                              if ((this.workingFucParam == null) ||
                                 (cVar2 = String.op_Inequality
                                                    (this.workingFucParam,"",0),
                                 !cVar2)) {
                                lVar4 = FUN_18046c440(0);
                                if (lVar4 == null) throw; // [null/range check failed]
                                Component.SendMessage(lVar4,this.workingFuc,0);
                              }
                              else {
                                lVar4 = FUN_18046c440(0);
                                if (lVar4 == null) throw; // [null/range check failed]
                                Component.SendMessage
                                          (lVar4,this.workingFuc,
                                           this.workingFucParam,0);
                              }
                            }
                            if (!this.working) {
                              return;
                            }
                            this.leftWorkingDay = this.leftWorkingDay + -1;
                            this.totalWorkingDay = this.totalWorkingDay + 1;
                            this.nextDayTime = 0;
                            lVar4 = FUN_18046c0a0(0);
                            if (lVar4 != null) {
                              GameController.ChangeHour(lVar4,0x41c00000,0);
                              if (this.leftWorkingDay < 1) {
                                fVar12 = *(float *)(pStatics_0b30 + 4);
                                fVar12 = fVar12 + fVar12;
                              }
                              else {
                                fVar12 = *(float *)(pStatics_0b30 + 4);
                              }
                              this.leftPauseTime = fVar12;
                              return;
                            }
                          }
                        }
                      }
                      throw; // [null/range check failed]
                    }
                  }
                }
                if ((((this.workingUI != null) &&
                     (lVar4 = GameObject.get_transform(this.workingUI,0)) != null) &&
                    (lVar4 = Transform.Find(lVar4,"TimeAnim",0)) != null) &&
                   ((lVar4 = Component.GetComponent(lVar4,DAT_181d6ce40), lVar4 != null &&
                    (lVar4 = SkeletonGraphic.get_AnimationState(lVar4,0)) != null))) {
                  *(uint32 *)(lVar4 + 108) = 0;
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6002323
    // RVA   : 0x9E8230   Offset: 0x9E6A30   Length: 0x176
    public void TryCancelWorking()
    {
        long lVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        if ((0 < this.leftWorkingDay) && (!this.noCancel)) {
          lVar1 = FUN_18046c440(0);
          uVar2 = String.Format("确定要中止{0}吗？",this.workName,0);
          lVar3 = il2cpp_internal(DAT_181d72a30);
          FUN_180f58a90(lVar3,DAT_181d7c250);
          if (lVar3 != null) {
            FUN_181827900(lVar3,"中止;MiddleStopWork",DAT_181d7c3d0);
            FUN_181827900(lVar3,"取消;HideInteractUI",DAT_181d7c3d0);
            uVar4 = new SinglePlotData(uVar2,lVar3,0);
            if (lVar1 != null) {
              PlotController.ChangePlot(lVar1,uVar4,0);
              return;
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x6002324
    // RVA   : 0x9E7D00   Offset: 0x9E6500   Length: 0x83
    public void StartWorking(int dayNum, string callFuc)
    {
        void WorkingUIController.StartWorking
                     (int64 this,uint64 dayNum,uint32 callFuc,uint64 param_4,
                     uint64 param_5,uint64 param_6,uint64 param_7,uint8 param_8)
        {
        int64 lVar1;
        if (this.workingUI != null) {
          GameObject.SetActive(this.workingUI,1,0);
          this.workName = dayNum;
          this.working = 1;
          this.leftWorkingDay = callFuc;
          this.totalWorkingDay = 0;
          this.leftPauseTime = *(uint32 *)(*(int64 *)(DAT_181d90b30 + 184) + 4);
          this.workingFuc = param_4;
          this.nextDayTime = 0;
          this.resourceNum = 0;
          this.workingFucParam = param_5;
          this.finishFuc = param_6;
          this.finishFucParam = param_7;
          this.noCancel = param_8;
          if (this.workingUI != null) {
            lVar1 = GameObject.get_transform(this.workingUI,0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"TimeAnim",0);
              if (lVar1 != null) {
                lVar1 = Component.GetComponent(lVar1,DAT_181d6ce40);
                if (lVar1 != null) {
                  lVar1 = SkeletonGraphic.get_AnimationState(lVar1,0);
                  if (lVar1 != null) {
                    AnimationState.SetEmptyAnimation(lVar1,0,0,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6002325
    // RVA   : 0x9E7C70   Offset: 0x9E6470   Length: 0x87
    public void StartWorking(int dayNum, string callFuc, string callFucParam, string finishCallFuc, string finishCallFucParam)
    {
        void WorkingUIController.StartWorking
                     (int64 this,uint64 dayNum,uint32 callFuc,uint64 callFucParam,
                     uint64 finishCallFuc,uint64 finishCallFucParam,uint64 param_7,uint8 param_8)
        {
        int64 lVar1;
        if (this.workingUI != null) {
          GameObject.SetActive(this.workingUI,1,0);
          this.workName = dayNum;
          this.working = 1;
          this.leftWorkingDay = callFuc;
          this.totalWorkingDay = 0;
          this.leftPauseTime = *(uint32 *)(*(int64 *)(DAT_181d90b30 + 184) + 4);
          this.workingFuc = callFucParam;
          this.nextDayTime = 0;
          this.resourceNum = 0;
          this.workingFucParam = finishCallFuc;
          this.finishFuc = finishCallFucParam;
          this.finishFucParam = param_7;
          this.noCancel = param_8;
          if (this.workingUI != null) {
            lVar1 = GameObject.get_transform(this.workingUI,0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"TimeAnim",0);
              if (lVar1 != null) {
                lVar1 = Component.GetComponent(lVar1,DAT_181d6ce40);
                if (lVar1 != null) {
                  lVar1 = SkeletonGraphic.get_AnimationState(lVar1,0);
                  if (lVar1 != null) {
                    AnimationState.SetEmptyAnimation(lVar1,0,0,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6002326
    // RVA   : 0x9E7F00   Offset: 0x9E6700   Length: 0x81
    public void StartWorking(string _workName, int dayNum, string callFuc)
    {
        void WorkingUIController.StartWorking
                     (int64 this,uint64 _workName,uint32 dayNum,uint64 callFuc,
                     uint64 param_5,uint64 param_6,uint64 param_7,uint8 param_8)
        {
        int64 lVar1;
        if (this.workingUI != null) {
          GameObject.SetActive(this.workingUI,1,0);
          this.workName = _workName;
          this.working = 1;
          this.leftWorkingDay = dayNum;
          this.totalWorkingDay = 0;
          this.leftPauseTime = *(uint32 *)(*(int64 *)(DAT_181d90b30 + 184) + 4);
          this.workingFuc = callFuc;
          this.nextDayTime = 0;
          this.resourceNum = 0;
          this.workingFucParam = param_5;
          this.finishFuc = param_6;
          this.finishFucParam = param_7;
          this.noCancel = param_8;
          if (this.workingUI != null) {
            lVar1 = GameObject.get_transform(this.workingUI,0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"TimeAnim",0);
              if (lVar1 != null) {
                lVar1 = Component.GetComponent(lVar1,DAT_181d6ce40);
                if (lVar1 != null) {
                  lVar1 = SkeletonGraphic.get_AnimationState(lVar1,0);
                  if (lVar1 != null) {
                    AnimationState.SetEmptyAnimation(lVar1,0,0,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6002327
    // RVA   : 0x9E7D90   Offset: 0x9E6590   Length: 0x16F
    public void StartWorking(List<string> paramList)
    {
        void WorkingUIController.StartWorking
                     (int64 this,uint64 paramList,uint32 param_3,uint64 param_4,
                     uint64 param_5,uint64 param_6,uint64 param_7,uint8 param_8)
        {
        int64 lVar1;
        if (this.workingUI != null) {
          GameObject.SetActive(this.workingUI,1,0);
          this.workName = paramList;
          this.working = 1;
          this.leftWorkingDay = param_3;
          this.totalWorkingDay = 0;
          this.leftPauseTime = *(uint32 *)(*(int64 *)(DAT_181d90b30 + 184) + 4);
          this.workingFuc = param_4;
          this.nextDayTime = 0;
          this.resourceNum = 0;
          this.workingFucParam = param_5;
          this.finishFuc = param_6;
          this.finishFucParam = param_7;
          this.noCancel = param_8;
          if (this.workingUI != null) {
            lVar1 = GameObject.get_transform(this.workingUI,0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"TimeAnim",0);
              if (lVar1 != null) {
                lVar1 = Component.GetComponent(lVar1,DAT_181d6ce40);
                if (lVar1 != null) {
                  lVar1 = SkeletonGraphic.get_AnimationState(lVar1,0);
                  if (lVar1 != null) {
                    AnimationState.SetEmptyAnimation(lVar1,0,0,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6002328
    // RVA   : 0x9E7AF0   Offset: 0x9E62F0   Length: 0x17E
    public void StartWorking(string _workName, int dayNum, string callFuc, string callFucParam, string finishCallFuc, string finishCallFucParam)
    {
        void WorkingUIController.StartWorking
                     (int64 this,uint64 _workName,uint32 dayNum,uint64 callFuc,
                     uint64 callFucParam,uint64 finishCallFuc,uint64 finishCallFucParam,uint8 param_8)
        {
        int64 lVar1;
        if (this.workingUI != null) {
          GameObject.SetActive(this.workingUI,1,0);
          this.workName = _workName;
          this.working = 1;
          this.leftWorkingDay = dayNum;
          this.totalWorkingDay = 0;
          this.leftPauseTime = *(uint32 *)(*(int64 *)(DAT_181d90b30 + 184) + 4);
          this.workingFuc = callFuc;
          this.nextDayTime = 0;
          this.resourceNum = 0;
          this.workingFucParam = callFucParam;
          this.finishFuc = finishCallFuc;
          this.finishFucParam = finishCallFucParam;
          this.noCancel = param_8;
          if (this.workingUI != null) {
            lVar1 = GameObject.get_transform(this.workingUI,0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"TimeAnim",0);
              if (lVar1 != null) {
                lVar1 = Component.GetComponent(lVar1,DAT_181d6ce40);
                if (lVar1 != null) {
                  lVar1 = SkeletonGraphic.get_AnimationState(lVar1,0);
                  if (lVar1 != null) {
                    AnimationState.SetEmptyAnimation(lVar1,0,0,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6002329
    // RVA   : 0x9E7F90   Offset: 0x9E6790   Length: 0x182
    public void StartWorking(string _workName, int dayNum, string callFuc, string callFucParam, string finishCallFuc, string finishCallFucParam, bool _noCancel)
    {
        void WorkingUIController.StartWorking
                     (int64 this,uint64 _workName,uint32 dayNum,uint64 callFuc,
                     uint64 callFucParam,uint64 finishCallFuc,uint64 finishCallFucParam,uint8 _noCancel)
        {
        int64 lVar1;
        if (this.workingUI != null) {
          GameObject.SetActive(this.workingUI,1,0);
          this.workName = _workName;
          this.working = 1;
          this.leftWorkingDay = dayNum;
          this.totalWorkingDay = 0;
          this.leftPauseTime = *(uint32 *)(*(int64 *)(DAT_181d90b30 + 184) + 4);
          this.workingFuc = callFuc;
          this.nextDayTime = 0;
          this.resourceNum = 0;
          this.workingFucParam = callFucParam;
          this.finishFuc = finishCallFuc;
          this.finishFucParam = finishCallFucParam;
          this.noCancel = _noCancel;
          if (this.workingUI != null) {
            lVar1 = GameObject.get_transform(this.workingUI,0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"TimeAnim",0);
              if (lVar1 != null) {
                lVar1 = Component.GetComponent(lVar1,DAT_181d6ce40);
                if (lVar1 != null) {
                  lVar1 = SkeletonGraphic.get_AnimationState(lVar1,0);
                  if (lVar1 != null) {
                    AnimationState.SetEmptyAnimation(lVar1,0,0,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600232A
    // RVA   : 0x9E8120   Offset: 0x9E6920   Length: 0x105
    public void StopWorking(bool finished)
    {
        bool cVar1;
        long lVar2;
        this.workFinished = finished;
        cVar1 = String.op_Inequality(this.finishFuc,"",0);
        if (cVar1) {
          cVar1 = String.op_Inequality(this.finishFucParam,"",0);
          if (!cVar1) {
            lVar2 = FUN_18046c440(0);
            if (lVar2 == null) throw; // [null/range check failed]
            Component.SendMessage(lVar2,this.finishFuc,0);
          }
          else {
            lVar2 = FUN_18046c440(0);
            if (lVar2 == null) throw; // [null/range check failed]
            Component.SendMessage
                      (lVar2,this.finishFuc,this.finishFucParam,0);
          }
        }
        this.working = 0;
        if (this.workingUI != null) {
          GameObject.SetActive(this.workingUI,0,0);
          return;
        }
    }

    // Token : 0x600232B
    // RVA   : 0x9E7480   Offset: 0x9E5C80   Length: 0x2EC
    public void AddResourceNum(int resourceID, float num, float iconNum, WorkResultType workResultType)
    {
        void WorkingUIController.AddResourceNum
                     (int64 this,uint64 resourceID,float num,uint64 iconNum,int workResultType)
        {
        uint64 uVar1;
        uint64 uVar2;
        int64 lVar3;
        uint64 *puVar4;
        uint32 *puVar5;
        int64 lVar6;
        float fVar7;
        float local_res18 [4];
        uint64 local_48;
        uint64 local_38;
        float local_30;
        uint32 local_18;
        uint32 uStack_14;
        uint32 uStack_10;
        uint32 uStack_c;
        local_res18[0] = num;
        this.resourceNum = local_res18[0] + this.resourceNum;
        uVar2 = "\n(会心)";
        if ((workResultType != 1) && (uVar2 = "", workResultType == 2)) {
          uVar2 = "\n(失手)";
        }
        lVar6 = **(int64 **)(DAT_181d4df90 + 184);
        uVar1 = Single.ToString(local_res18,"+0;-0;0",0);
        uVar2 = String.Concat(uVar1,uVar2,0);
        if (((this.workingUI != null) &&
            (lVar3 = GameObject.get_transform(this.workingUI,0)) != null) &&
           (lVar3 = Transform.Find(lVar3,"ResourceLabel",0)) != null) {
          puVar4 = (uint64 *)Transform.get_position(&local_18,lVar3,0);
          local_38 = *puVar4;
          local_30 = *(float *)(puVar4 + 1);
          local_48 = CONCAT44((float)((uint64)local_38 >> 32) + 0.0,(float)local_38 + 0.04);
          fVar7 = local_30 + 0.0;
          if (workResultType == 2) {
            puVar5 = (uint32 *)Color.get_magenta();
          }
          else {
            puVar5 = (uint32 *)Color.get_green(&local_18,0);
          }
          if (lVar6 != null) {
            local_38 = local_48;
            local_30 = fVar7;
            local_18 = *puVar5;
            uStack_14 = puVar5[1];
            uStack_10 = puVar5[2];
            uStack_c = puVar5[3];
            GameController.ShowTextAtPos(lVar6,uVar2,&local_38,30,&local_18,0);
            if ((this.workingUI != null) &&
               (lVar6 = GameObject.get_transform(this.workingUI,0)) != null) {
              uVar2 = Transform.Find(lVar6,"ResourceLabel",0);
              uVar2 = ShortcutExtensions.DOScale(uVar2,0x3fc00000,0x3e19999a,0);
              uVar2 = TweenSettingsExtensions.SetEase(uVar2,9,DAT_181d97ca8);
              TweenSettingsExtensions.SetLoops(uVar2,2,1,DAT_181d98060);
              return;
            }
          }
        }
    }

    // Token : 0x600232C
    // RVA   : 0x9E7960   Offset: 0x9E6160   Length: 0x181
    public void SkipButtonClicked()
    {
        bool cVar1;
        long lVar2;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        cVar1 = this.skipping;
        lVar2 = this.skipButton;
        this.skipping = !cVar1;
        if (!cVar1) {
          if (lVar2 != null) {
            lVar2 = GameObject.get_transform(lVar2,0);
            if (lVar2 != null) {
              lVar2 = Transform.Find(lVar2,"Icon",0);
              if (lVar2 != null) {
                plVar3 = (int64 *)Component.GetComponent(lVar2,DAT_181d6bc40);
                puVar4 = (uint32 *)Color.get_red(&local_18,0);
                if (plVar3 != (int64 *)0) {
                  local_18 = *puVar4;
                  uStack_14 = puVar4[1];
                  uStack_10 = puVar4[2];
                  uStack_c = puVar4[3];
                  (**(code **)(*plVar3 + 0x2a8))(plVar3,&local_18,*(uint64 *)(*plVar3 + 0x2b0));
                  return;
                }
              }
            }
          }
        }
        else if (lVar2 != null) {
          lVar2 = GameObject.get_transform(lVar2,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"Icon",0);
            if (lVar2 != null) {
              plVar3 = (int64 *)Component.GetComponent(lVar2,DAT_181d6bc40);
              lVar2 = *(int64 *)(DAT_181d4ef00 + 184);
              if (plVar3 != (int64 *)0) {
                local_18 = *(uint32 *)(lVar2 + 0x390);
                uStack_14 = *(uint32 *)(lVar2 + 0x394);
                uStack_10 = *(uint32 *)(lVar2 + 0x398);
                uStack_c = *(uint32 *)(lVar2 + 0x39c);
                (**(code **)(*plVar3 + 0x2a8))(plVar3,&local_18,*(uint64 *)(*plVar3 + 0x2b0));
                return;
              }
            }
          }
        }
    }

    // Token : 0x600232D
    // RVA   : 0x9E77E0   Offset: 0x9E5FE0   Length: 0x179
    public void SetSkippingState(bool state)
    {
        long lVar1;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        lVar1 = this.skipButton;
        this.skipping = state;
        if (!state) {
          if (lVar1 != null) {
            lVar1 = GameObject.get_transform(lVar1,0);
            if (lVar1 != null) {
              lVar1 = Transform.Find(lVar1,"Icon",0);
              if (lVar1 != null) {
                plVar2 = (int64 *)Component.GetComponent(lVar1,DAT_181d6bc40);
                lVar1 = *(int64 *)(DAT_181d4ef00 + 184);
                if (plVar2 != (int64 *)0) {
                  local_18 = *(uint32 *)(lVar1 + 0x390);
                  uStack_14 = *(uint32 *)(lVar1 + 0x394);
                  uStack_10 = *(uint32 *)(lVar1 + 0x398);
                  uStack_c = *(uint32 *)(lVar1 + 0x39c);
                  (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_18,*(uint64 *)(*plVar2 + 0x2b0));
                  return;
                }
              }
            }
          }
        }
        else if (lVar1 != null) {
          lVar1 = GameObject.get_transform(lVar1,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"Icon",0);
            if (lVar1 != null) {
              plVar2 = (int64 *)Component.GetComponent(lVar1,DAT_181d6bc40);
              puVar3 = (uint32 *)Color.get_red(&local_18,0);
              if (plVar2 != (int64 *)0) {
                local_18 = *puVar3;
                uStack_14 = puVar3[1];
                uStack_10 = puVar3[2];
                uStack_c = puVar3[3];
                (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_18,*(uint64 *)(*plVar2 + 0x2b0));
                return;
              }
            }
          }
        }
    }

    // Token : 0x600232E
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x600232F
    // RVA   : 0x9E8DC0   Offset: 0x9E75C0   Length: 0x4E
    private static void /*cctor*/()
    {
        **(uint32 **)(DAT_181d90b30 + 184) = 0x3f800000;
        *(uint32 *)(*(int64 *)(DAT_181d90b30 + 184) + 4) = 0x3e800000;
    }

}
