// ============================================================
// Type  : RailManager
// Token : 0x2000334
// ============================================================

public class RailManager
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001AA8
    private static RailManager instance_;

    // Token: 0x4001AA9
    private static bool ever_initialize_;

    // Token: 0x4001AAA
    private bool initialized_;

    // Token: 0x4001AAB
    public bool needQuitGame;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002047
    // RVA   : 0xD08BE0   Offset: 0xD07FE0   Length: 0xE8
    public static RailManager get_Instance()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uVar3 = **(uint64 **)(DAT_181d97798 + 184);
        cVar1 = Object.op_Equality(uVar3,0,0);
        if (!cVar1) {
          return **(uint64 **)(DAT_181d97798 + 184);
        }
        lVar2 = new GameObject("RailManager",0);
        if (lVar2 != null) {
          uVar3 = GameObject.AddComponent(lVar2,DAT_181dc5908);
          return uVar3;
        }
    }

    // Token : 0x6002048
    // RVA   : 0xD08AF0   Offset: 0xD07EF0   Length: 0xEE
    public static bool get_Initialized()
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        uVar1 = **(uint64 **)(DAT_181d97798 + 184);
        cVar2 = Object.op_Equality(uVar1,0,0);
        if (!cVar2) {
          lVar3 = RailManager.instance_;
        }
        else {
          lVar3 = new GameObject("RailManager",0);
          if (lVar3 == null) throw; // [null/range check failed]
          lVar3 = GameObject.AddComponent(lVar3,DAT_181dc5908);
        }
        if (lVar3 != null) {
          return lVar3.initialized_;
        }
    }

    // Token : 0x6002049
    // RVA   : 0xD075D0   Offset: 0xD069D0   Length: 0x4E4
    private void Awake()
    {
        var pStatics = *(int64*)(DAT_181d97798 + 184);
        bool cVar1;
        ulong uVar2;
        ulong uVar3;
        long lVar5;
        uVar2 = **(uint64 **)(DAT_181d97798 + 184);
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (!cVar1) {
          if (**(int **)(DAT_181d73d40 + 184) == 1) {
            plVar4 = pStatics;
            *plVar4 = this;
            il2cpp_internal(plVar4,this);
            if (RailManager.ever_initialize_) {
              Debug.LogError("Tried to Initialize the RailSDK twice in one session!",0);
              return;
            }
            uVar2 = Component.get_gameObject(this,0);
            Object.DontDestroyOnLoad(uVar2,0);
            uVar2 = *(uint64 *)(*(int64 *)(DAT_181d73d40 + 184) + 56);
            uVar3 = new RailGameID(uVar2,0);
            plVar4 = (int64 *)FUN_1800d60b0(DAT_181da5cf8,1);
            if (plVar4 == (int64 *)0) {
        LAB_180d07aaf:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (("" != 0) &&
               (lVar5 = il2cpp_internal("",*(uint64 *)(*plVar4 + 64))) == null) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            lVar5 = "";
            if ((int)plVar4[3] == 0) {
              uVar2 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar2,0);
            }
            plVar4[4] = "";
            il2cpp_internal(plVar4 + 4,lVar5);
            cVar1 = rail_api.RailNeedRestartAppForCheckingEnvironment(uVar3,1,plVar4);
            if (!cVar1) {
              cVar1 = rail_api.RailInitialize(0);
              this.initialized_ = cVar1;
              if (cVar1) {
                lVar5 = RailCallBackHelper.get_Instance(0);
                uVar2 = new OnTooltipCB(this,DAT_181d9ae28,0);
                if (lVar5 != null) {
                  RailCallBackHelper.RegisterCallback(lVar5,2,uVar2);
                  lVar5 = RailCallBackHelper.get_Instance(0);
                  uVar2 = new OnTooltipCB(this,DAT_181d9ada8,0);
                  if (lVar5 != null) {
                    RailCallBackHelper.RegisterCallback(lVar5,0x714a,uVar2,0);
                    RailManager.ever_initialize_ = 1;
                    Debug.Log("RailInitialize success!",0);
                    return;
                  }
                }
                goto LAB_180d07aaf;
              }
              uVar2 = "RailInitialize failed!";
              if (((*(byte *)(DAT_181dbfce0 + 0x133) & 4) != 0) && (*(int *)(DAT_181dbfce0 + 224) == 0))
              {
                il2cpp_runtime_class_init();
                uVar2 = "RailInitialize failed!";
              }
            }
            else {
              uVar2 = "RailNeedRestartAppForCheckingEnvironment return true!";
              if (((*(byte *)(DAT_181dbfce0 + 0x133) & 4) != 0) && (*(int *)(DAT_181dbfce0 + 224) == 0))
              {
                il2cpp_runtime_class_init();
                uVar2 = "RailNeedRestartAppForCheckingEnvironment return true!";
              }
            }
            Debug.LogError(uVar2,0);
            Application.Quit(0);
            return;
          }
        }
        uVar2 = Component.get_gameObject(this,0);
        Object.Destroy(uVar2,0);
    }

    // Token : 0x600204A
    // RVA   : 0xD08260   Offset: 0xD07660   Length: 0xF8
    public void OnRailEvent(RAILEventID id, EventBase data)
    {
        if (data != (int64 *)0) {
          if (((int)data[2] == 0) && (id == 2)) {
            if (((int)data[6] - 2U < 2) && (!this.needQuitGame)) {
              RailManager.ShowFCMSpeInfo(this,"Wegame已离线","Wegame客户端已离线，请检查您的网络并重新登录。","退出游戏",0,0,0);
              this.needQuitGame = 1;
            }
          }
          return;
        }
    }

    // Token : 0x600204B
    // RVA   : 0xD07B00   Offset: 0xD06F00   Length: 0x59B
    public void OnAntiAddictionEvent(RAILEventID id, EventBase data)
    {
        bool cVar1;
        int iVar2;
        ulong uVar4;
        long lVar6;
        ulong uVar7;
        ulong uVar8;
        int iVar9;
        uint uVar10;
        int[] local_res18 = new int[4];
        int local_38;
        int local_34;
        int[] local_30 = new int[2];
        if (data == (int64 *)0) {
        LAB_180d08096:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if (((int)data[2] == 0) && (id == 0x714a)) {
          lVar6 = data[6];
          plVar3 = (int64 *)JToken.Parse(lVar6,0);
          iVar9 = 0;
          if (plVar3 == (int64 *)0) goto LAB_180d08096;
          while( true ) {
            uVar4 = (**(code **)(*plVar3 + 0x218))(plVar3,"actions",*(uint64 *)(*plVar3 + 0x220));
            iVar2 = Enumerable.Count(uVar4,DAT_181db2c00);
            if (iVar2 <= iVar9) break;
            plVar5 = (int64 *)
                     (**(code **)(*plVar3 + 0x218))(plVar3,"actions",*(uint64 *)(*plVar3 + 0x220))
            ;
            local_res18[0] = iVar9;
            uVar4 = il2cpp_value_box(DAT_181d80430,local_res18);
            if ((((plVar5 == (int64 *)0) ||
                 (plVar5 = (int64 *)
                           (**(code **)(*plVar5 + 0x218))(plVar5,uVar4,*(uint64 *)(*plVar5 + 0x220)),
                 plVar5 == (int64 *)0)) ||
                (plVar5 = (int64 *)
                          (**(code **)(*plVar5 + 0x218))
                                    (plVar5,"action",*(uint64 *)(*plVar5 + 0x220)),
                plVar5 == (int64 *)0)) ||
               ((plVar5 = (int64 *)
                          (**(code **)(*plVar5 + 0x218))
                                    (plVar5,"type",*(uint64 *)(*plVar5 + 0x220)),
                plVar5 == (int64 *)0 ||
                (plVar5 = (int64 *)
                          (**(code **)(*plVar5 + 0x218))
                                    (plVar5,"id",*(uint64 *)(*plVar5 + 0x220)),
                plVar5 == (int64 *)0)))) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar6 = (**(code **)(*plVar5 + 0x168))(plVar5,*(uint64 *)(*plVar5 + 0x170));
            if (lVar6 == null) {
        LAB_180d08055:
              iVar9 = iVar9 + 1;
            }
            else {
              cVar1 = FUN_18171eb50(lVar6,"1",0);
              if (!cVar1) {
                cVar1 = FUN_18171eb50(lVar6,"2",0);
                if (cVar1) {
                  RailManager.SetFCMButton(this,"退出游戏",0,0,0);
                  this.needQuitGame = 1;
                }
                goto LAB_180d08055;
              }
              plVar5 = (int64 *)
                       (**(code **)(*plVar3 + 0x218))
                                 (plVar3,"actions",*(uint64 *)(*plVar3 + 0x220));
              local_38 = iVar9;
              uVar4 = il2cpp_value_box(DAT_181d80430,&local_38);
              if (((plVar5 == (int64 *)0) ||
                  (plVar5 = (int64 *)
                            (**(code **)(*plVar5 + 0x218))(plVar5,uVar4,*(uint64 *)(*plVar5 + 0x220)),
                  plVar5 == (int64 *)0)) ||
                 ((plVar5 = (int64 *)
                            (**(code **)(*plVar5 + 0x218))
                                      (plVar5,"action",*(uint64 *)(*plVar5 + 0x220)),
                  plVar5 == (int64 *)0 ||
                  (plVar5 = (int64 *)
                            (**(code **)(*plVar5 + 0x218))
                                      (plVar5,"title",*(uint64 *)(*plVar5 + 0x220)),
                  plVar5 == (int64 *)0)))) {
        LAB_180d08081:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar4 = (**(code **)(*plVar5 + 0x168))(plVar5,*(uint64 *)(*plVar5 + 0x170));
              plVar5 = (int64 *)
                       (**(code **)(*plVar3 + 0x218))
                                 (plVar3,"actions",*(uint64 *)(*plVar3 + 0x220));
              local_34 = iVar9;
              uVar7 = il2cpp_value_box(DAT_181d80430,&local_34);
              if ((((plVar5 == (int64 *)0) ||
                   (plVar5 = (int64 *)
                             (**(code **)(*plVar5 + 0x218))(plVar5,uVar7,*(uint64 *)(*plVar5 + 0x220))
                   , plVar5 == (int64 *)0)) ||
                  (plVar5 = (int64 *)
                            (**(code **)(*plVar5 + 0x218))
                                      (plVar5,"action",*(uint64 *)(*plVar5 + 0x220)),
                  plVar5 == (int64 *)0)) ||
                 (plVar5 = (int64 *)
                           (**(code **)(*plVar5 + 0x218))
                                     (plVar5,"content",*(uint64 *)(*plVar5 + 0x220)),
                 plVar5 == (int64 *)0)) goto LAB_180d08081;
              uVar7 = (**(code **)(*plVar5 + 0x168))(plVar5,*(uint64 *)(*plVar5 + 0x170));
              plVar5 = (int64 *)
                       (**(code **)(*plVar3 + 0x218))
                                 (plVar3,"actions",*(uint64 *)(*plVar3 + 0x220));
              local_30[0] = iVar9;
              uVar8 = il2cpp_value_box(DAT_181d80430,local_30);
              if (((plVar5 == (int64 *)0) ||
                  (plVar5 = (int64 *)
                            (**(code **)(*plVar5 + 0x218))(plVar5,uVar8,*(uint64 *)(*plVar5 + 0x220)),
                  plVar5 == (int64 *)0)) ||
                 ((plVar5 = (int64 *)
                            (**(code **)(*plVar5 + 0x218))
                                      (plVar5,"action",*(uint64 *)(*plVar5 + 0x220)),
                  plVar5 == (int64 *)0 ||
                  (plVar5 = (int64 *)
                            (**(code **)(*plVar5 + 0x218))
                                      (plVar5,"display_duration_seconds",*(uint64 *)(*plVar5 + 0x220)),
                  plVar5 == (int64 *)0)))) goto LAB_180d08081;
              uVar8 = (**(code **)(*plVar5 + 0x168))(plVar5,*(uint64 *)(*plVar5 + 0x170));
              uVar10 = Single.Parse(uVar8,0);
              RailManager.ShowFCMSpeInfo(this,uVar4,uVar7,"确认",1,uVar10,0);
              iVar9 = iVar9 + 1;
            }
          }
        }
    }

    // Token : 0x600204C
    // RVA   : 0xD08700   Offset: 0xD07B00   Length: 0x38E
    public void ShowFCMSpeInfo(string title, string info, string buttonText, bool clickCloseMenu, float autoClickTime)
    {
        void RailManager.ShowFCMSpeInfo
                     (uint64 this,uint64 title,uint64 info,uint64 buttonText,
                     uint8 clickCloseMenu,uint32 autoClickTime)
        {
        char cVar1;
        uint64 uVar2;
        int64 *plVar3;
        int64 lVar4;
        int64 *plVar5;
        uVar2 = GameObject.FindGameObjectWithTag("FCMSpeInfo",0);
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          uVar2 = GameObject.FindGameObjectWithTag("UICanvas",0);
          plVar3 = (int64 *)Resources.Load("Prefabs/FCMSpeInfo",0);
          plVar5 = (int64 *)0;
          if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d72e60)) {
            plVar5 = plVar3;
          }
          lVar4 = GlobalData.AddChild(uVar2,plVar5,0);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = GameObject.get_transform(lVar4,0);
          if (lVar4 == null) throw; // [null/range check failed]
          Transform.SetAsLastSibling(lVar4,0);
        }
        lVar4 = GameObject.FindGameObjectWithTag("FCMSpeInfo",0);
        if (lVar4 != null) {
          lVar4 = GameObject.get_transform(lVar4,0);
          if (lVar4 != null) {
            lVar4 = Transform.Find(lVar4,"GameStopBlack",0);
            if (lVar4 != null) {
              lVar4 = Component.get_gameObject(lVar4,0);
              if (lVar4 != null) {
                GameObject.SetActive(lVar4,1,0);
                lVar4 = GameObject.FindGameObjectWithTag("FCMSpeInfo",0);
                if (lVar4 != null) {
                  lVar4 = GameObject.get_transform(lVar4,0);
                  if (lVar4 != null) {
                    lVar4 = Transform.Find(lVar4,"GameStopBlack",0);
                    if (lVar4 != null) {
                      lVar4 = Transform.Find(lVar4,"Title",0);
                      if (lVar4 != null) {
                        plVar3 = (int64 *)Component.GetComponent(lVar4,DAT_181d96178);
                        if (plVar3 != (int64 *)0) {
                          (**(code **)(*plVar3 + 0x5e8))(plVar3,title,*(uint64 *)(*plVar3 + 0x5f0));
                          lVar4 = GameObject.FindGameObjectWithTag("FCMSpeInfo",0);
                          if (lVar4 != null) {
                            lVar4 = GameObject.get_transform(lVar4,0);
                            if (lVar4 != null) {
                              lVar4 = Transform.Find(lVar4,"GameStopBlack",0);
                              if (lVar4 != null) {
                                lVar4 = Transform.Find(lVar4,"Text",0);
                                if (lVar4 != null) {
                                  plVar3 = (int64 *)Component.GetComponent(lVar4,DAT_181d96178);
                                  if (plVar3 != (int64 *)0) {
                                    (**(code **)(*plVar3 + 0x5e8))
                                              (plVar3,info,*(uint64 *)(*plVar3 + 0x5f0));
                                    RailManager.SetFCMButton(this,buttonText,clickCloseMenu,autoClickTime);
                                    return;
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
    }

    // Token : 0x600204D
    // RVA   : 0xD08360   Offset: 0xD07760   Length: 0x39F
    public void SetFCMButton(string buttonText, bool clickCloseMenu, float autoClickTime)
    {
        void RailManager.SetFCMButton
                     (uint64 this,uint64 buttonText,uint8 clickCloseMenu,float autoClickTime)
        {
        char cVar1;
        uint64 uVar2;
        int64 *plVar3;
        int64 lVar4;
        int64 *plVar5;
        uVar2 = GameObject.FindGameObjectWithTag("FCMSpeInfo",0);
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          uVar2 = GameObject.FindGameObjectWithTag("UICanvas",0);
          plVar3 = (int64 *)Resources.Load("Prefabs/FCMSpeInfo",0);
          plVar5 = (int64 *)0;
          if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d72e60)) {
            plVar5 = plVar3;
          }
          lVar4 = GlobalData.AddChild(uVar2,plVar5,0);
          if ((lVar4 == null) || (lVar4 = GameObject.get_transform(lVar4,0)) == null)
          throw; // [null/range check failed]
          Transform.SetAsLastSibling(lVar4,0);
        }
        lVar4 = GameObject.FindGameObjectWithTag("FCMSpeInfo",0);
        if ((((lVar4 != null) && (lVar4 = GameObject.get_transform(lVar4,0)) != null) &&
            (lVar4 = Transform.Find(lVar4,"GameStopBlack",0)) != null) &&
           (((lVar4 = Transform.Find(lVar4,"QuitButton",0), lVar4 != null &&
             (lVar4 = Transform.Find(lVar4,"Text",0)) != null) &&
            (plVar3 = (int64 *)Component.GetComponent(lVar4,DAT_181d96178), plVar3 != (int64 *)0)
            ))) {
          (**(code **)(*plVar3 + 0x5e8))(plVar3,buttonText,*(uint64 *)(*plVar3 + 0x5f0));
          lVar4 = GameObject.FindGameObjectWithTag("FCMSpeInfo",0);
          if (((lVar4 != null) && (lVar4 = GameObject.get_transform(lVar4,0)) != null) &&
             ((lVar4 = Transform.Find(lVar4,"GameStopBlack",0), lVar4 != null &&
              ((lVar4 = Transform.Find(lVar4,"QuitButton",0), lVar4 != null &&
               (lVar4 = Component.GetComponent(lVar4,DAT_181d93f78)) != null))))) {
            *(uint8 *)(lVar4 + 24) = clickCloseMenu;
            if (autoClickTime <= 0.0) {
              return;
            }
            lVar4 = GameObject.FindGameObjectWithTag("FCMSpeInfo",0);
            if ((((lVar4 != null) && (lVar4 = GameObject.get_transform(lVar4,0)) != null) &&
                (lVar4 = Transform.Find(lVar4,"GameStopBlack",0)) != null) &&
               ((lVar4 = Transform.Find(lVar4,"QuitButton",0), lVar4 != null &&
                (lVar4 = Component.GetComponent(lVar4,DAT_181d93f78)) != null))) {
              *(float *)(lVar4 + 28) = autoClickTime;
              return;
            }
          }
        }
    }

    // Token : 0x600204E
    // RVA   : 0xD07AC0   Offset: 0xD06EC0   Length: 0x32
    public GameObject FindFCMSpeInfoRoot()
    {
        GameObject.FindGameObjectWithTag("FCMSpeInfo",0);
    }

    // Token : 0x600204F
    // RVA   : 0xD081C0   Offset: 0xD075C0   Length: 0x99
    private void OnEnable()
    {
        ulong uVar1;
        bool cVar3;
        uVar1 = **(uint64 **)(DAT_181d97798 + 184);
        cVar3 = Object.op_Equality(uVar1,0,0);
        if (cVar3) {
          puVar2 = *(uint64 **)(DAT_181d97798 + 184);
          *puVar2 = this;
          il2cpp_internal(puVar2,this);
        }
    }

    // Token : 0x6002050
    // RVA   : 0xD080A0   Offset: 0xD074A0   Length: 0x119
    private void OnDestroy()
    {
        ulong uVar1;
        bool cVar3;
        long lVar4;
        uVar1 = **(uint64 **)(DAT_181d97798 + 184);
        cVar3 = Object.op_Inequality(uVar1,this,0);
        if (!cVar3) {
          puVar2 = *(uint64 **)(DAT_181d97798 + 184);
          *puVar2 = 0;
          il2cpp_internal(puVar2,0);
          if (this.initialized_) {
            lVar4 = RailCallBackHelper.get_Instance(0);
            if (lVar4 == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            RailCallBackHelper.UnregisterAllCallback(lVar4,0);
            rail_api.RailFinalize(0);
          }
        }
    }

    // Token : 0x6002051
    // RVA   : 0xD08A90   Offset: 0xD07E90   Length: 0x5B
    private void Update()
    {
        if (this.initialized_) {
          rail_api.RailFireEvents(0);
          return;
        }
    }

    // Token : 0x6002052
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
