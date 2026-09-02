// ============================================================
// Type  : CISAuthSDKController
// Token : 0x20001AD
// ============================================================

public class CISAuthSDKController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000B41
    public bool loginFinished;

    // Token: 0x4000B42
    public GameObject FCMSpeInfoTextPrefab;

    // Token: 0x4000B43
    private static CISAuthSDKController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000E2E
    // RVA   : 0xBD7D70   Offset: 0xBD6570   Length: 0x36
    public static CISAuthSDKController get_Instance()
    {
        return **(uint64 **)(DAT_181d8ffe8 + 184);
    }

    // Token : 0x6000E2F
    // RVA   : 0xBD6BB0   Offset: 0xBD53B0   Length: 0x147
    private void Awake()
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = **(uint64 **)(DAT_181d8ffe8 + 184);
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (cVar2) {
          cVar2 = GlobalData.IsCheckVersion(1,0);
          if (cVar2) {
            puVar1 = *(uint64 **)(DAT_181d8ffe8 + 184);
            *puVar1 = this;
            il2cpp_internal(puVar1,this);
            uVar3 = Component.get_gameObject(this,0);
            Object.DontDestroyOnLoad(uVar3,0);
            return;
          }
        }
        uVar3 = Component.get_gameObject(this,0);
        Object.Destroy(uVar3,0);
    }

    // Token : 0x6000E30
    // RVA   : 0xBD76E0   Offset: 0xBD5EE0   Length: 0x457
    private void Start()
    {
        var pStatics = *(int64*)(DAT_181d9fa30 + 184);
        int iVar1;
        ulong uVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        ulong uVar7;
        ulong uVar8;
        Debug.Log("CISAuthLite init",0);
        uVar3 = DAT_181d90828;
        plVar2 = (int64 *)Type.GetTypeFromHandle(uVar3,0);
        if (plVar2 == (int64 *)0) throw; // [null/range check failed]
        plVar2 = (int64 *)(**(code **)(*plVar2 + 0x2b8))(plVar2,*(uint64 *)(*plVar2 + 0x2c0));
        if (plVar2 == (int64 *)0) throw; // [null/range check failed]
        uVar3 = (**(code **)(*plVar2 + 0x1c8))(plVar2,*(uint64 *)(*plVar2 + 0x1d0));
        Debug.Log(uVar3,0);
        lVar4 = *(int64 *)(pStatics + 8);
        if (lVar4 == null) {
          uVar3 = **(uint64 **)(DAT_181d9fa30 + 184);
          lVar4 = new OnTooltipCB(uVar3,DAT_181d70618,DAT_181d73008);
          plVar2 = (int64 *)(pStatics + 8);
          *plVar2 = lVar4;
          il2cpp_internal(plVar2,lVar4);
        }
        plVar2 = (int64 *)(*(int64 *)(DAT_181d8ff60 + 184) + 56);
        *plVar2 = lVar4;
        il2cpp_internal(plVar2,lVar4);
        iVar1 = Application.get_platform(0);
        if (iVar1 == 8) {
        LAB_180bd79aa:
          uVar3 = "1c38be24ce81431ab06699f8c8230dd0";
        }
        else {
          iVar1 = Application.get_platform(0);
          uVar3 = "11561f9df4f3414db4a40eec9258529a";
          if (iVar1 == 11) goto LAB_180bd79aa;
        }
        iVar1 = Application.get_platform(0);
        if (iVar1 == 8) {
        LAB_180bd79d0:
          uVar8 = "16648d47afc94b20811979495ff21763";
        }
        else {
          iVar1 = Application.get_platform(0);
          uVar8 = "a6e3c67025364481bd9daccd4ceb581b";
          if (iVar1 == 11) goto LAB_180bd79d0;
        }
        iVar1 = Application.get_platform(0);
        if (iVar1 == 8) {
        LAB_180bd79f6:
          uVar7 = "zpp_m_songshen";
        }
        else {
          iVar1 = Application.get_platform(0);
          uVar7 = "zpp_pc_songshen";
          if (iVar1 == 11) goto LAB_180bd79f6;
        }
        uVar5 = String.Format("AppInfo: {0} - {1} - {2}",uVar3,uVar8,uVar7,0);
        Debug.Log(uVar5,0);
        CISAuthSDK.Init(uVar3,uVar8,uVar7,0);
        lVar4 = il2cpp_internal(DAT_181d9fbc8);
        FUN_180fc8b20(lVar4,0);
        if (lVar4 != null) {
          *(uint8 *)(lVar4 + 18) = 1;
          lVar6 = CISFCMAPI.get_Instance(0);
          if (lVar6 != null) {
            CISFCMAPI.Init(lVar6,lVar4,0);
            lVar4 = CISFCMAPI.get_Instance(0);
            uVar3 = new OnTooltipCB(this,DAT_181d658d0,DAT_181d73588);
            if (lVar4 != null) {
              CISFCMAPI.add_EventOnFCMStateChange(lVar4,uVar3,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000E31
    // RVA   : 0xBD7BF0   Offset: 0xBD63F0   Length: 0x176
    private void Update()
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        cVar1 = FUN_1804625f0(0x132,0);
        if ((!cVar1) || (cVar1 = FUN_1804625b0(116), !cVar1)) {
          return;
        }
        lVar3 = CISFCMAPI.get_Instance(0);
        lVar2 = CISFCMAPI.get_Instance(0);
        if ((lVar2 != null) && (lVar3 != null)) {
          *(bool *)(lVar3 + 88) = *(char *)(lVar2 + 88) == false;
          lVar3 = CISFCMAPI.get_Instance(0);
          if (lVar3 != null) {
            uVar4 = "开";
            if (*(char *)(lVar3 + 88) == false) {
              uVar4 = "关";
            }
            uVar4 = String.Concat("未成年模拟:",uVar4,0);
            if (this != 0) {
              CISAuthSDKController.ShowSpeInfoText(this,uVar4,0);
              lVar3 = CISFCMAPI.get_Instance(0);
              if (lVar3 != null) {
                uVar4 = CISFCMAPI.CheckState(lVar3,0);
                CISAuthSDKController.ManageFCMState(this,uVar4,0,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000E32
    // RVA   : 0xBD6D00   Offset: 0xBD5500   Length: 0x81
    public FCMStateResponse CheckFCMState(bool firstCheck)
    {
        long lVar1;
        ulong uVar2;
        lVar1 = CISFCMAPI.get_Instance(0);
        if (lVar1 != null) {
          uVar2 = CISFCMAPI.CheckState(lVar1,0);
          CISAuthSDKController.ManageFCMState(this,uVar2,firstCheck,0);
          return;
        }
    }

    // Token : 0x6000E33
    // RVA   : 0xBD6ED0   Offset: 0xBD56D0   Length: 0x4A8
    public FCMStateResponse ManageFCMState(FCMStateResponse result, bool firstCheck)
    {
        int iVar1;
        bool cVar2;
        bool cVar3;
        long lVar4;
        ulong uVar6;
        lVar4 = CISFCMAPI.get_Instance(0);
        if ((lVar4 != null) && (lVar4 = CISFCMAPI.CheckState(lVar4,0)) != null) {
          plVar5 = (int64 *)il2cpp_value_box(DAT_181d9b750,(uint32 *)(lVar4 + 28));
          if (plVar5 != (int64 *)0) {
            uVar6 = (**(code **)(*plVar5 + 0x168))(plVar5,*(uint64 *)(*plVar5 + 0x170));
            puVar7 = (uint32 *)il2cpp_object_unbox(plVar5);
            *(uint32 *)(lVar4 + 28) = *puVar7;
            uVar6 = String.Concat("FCMCheckState: ",uVar6,0);
            Debug.Log(uVar6,0);
            if (this.loginFinished) {
              uVar6 = CISAuthSDKController.FindFCMSpeInfoRoot(this,0);
              cVar2 = Object.op_Equality(uVar6,0,0);
              uVar6 = "";
              if (!cVar2) {
                cVar2 = true;
                if (result != null) {
                  switch(*(uint32 *)(result + 28)) {
                  case 0:
                    iVar1 = *(int *)(result + 52);
                    cVar2 = false;
                    if (iVar1 == 1) {
                      CISAuthSDKController.ShowSpeInfoText(this,"游玩时间剩余5分钟",0);
                    }
                    else if (iVar1 == 2) {
                      CISAuthSDKController.ShowSpeInfoText(this,"游玩时间剩余2分钟",0);
                    }
                    else if (iVar1 == 3) {
                      CISAuthSDKController.ShowSpeInfoText(this,"游玩时间剩余1分钟",0);
                    }
                    break;
                  case 1:
                    uVar6 = "错误代码: notInit";
                    break;
                  case 2:
                    uVar6 = "错误代码: notRunning";
                    break;
                  case 3:
                    uVar6 = "网络连接失败。";
                    break;
                  case 4:
                    uVar6 = "登录状态无效，请重新启动游戏。";
                    break;
                  case 5:
                    if (!firstCheck) {
                      uVar6 = String.Concat("本游戏仅可在周五、周六、周日和法定节假日每日20时至21时向未成年人提供1小时网络游戏服务，其他时间均不得以任何形式向未成年人提供网络游戏服务。","\n\n检测到当前不在游戏时间内，已将您强制下线。",0);
                    }
                    else {
                      uVar6 = String.Concat("本游戏仅可在周五、周六、周日和法定节假日每日20时至21时向未成年人提供1小时网络游戏服务，其他时间均不得以任何形式向未成年人提供网络游戏服务。","\n\n检测到当前不在游戏时间内，无法登陆。",0);
                    }
                    break;
                  case 6:
                    uVar6 = "限制游戏时间已用完。";
                    break;
                  case 0xffffffff:
                    uVar6 = "错误代码: internalError";
                  }
                  lVar4 = CISAuthSDKController.FindFCMSpeInfoRoot(this,0);
                  if ((((lVar4 != null) && (lVar4 = GameObject.get_transform(lVar4,0)) != null) &&
                      (lVar4 = Transform.Find(lVar4,"GameStopBlack",0)) != null) &&
                     (lVar4 = Component.get_gameObject(lVar4,0)) != null) {
                    cVar3 = GameObject.get_activeSelf(lVar4,0);
                    if (cVar3 == cVar2) {
                      return result;
                    }
                    lVar4 = CISAuthSDKController.FindFCMSpeInfoRoot(this,0);
                    if (((lVar4 != null) && (lVar4 = GameObject.get_transform(lVar4,0)) != null) &&
                       ((lVar4 = Transform.Find(lVar4,"GameStopBlack",0), lVar4 != null &&
                        (lVar4 = Component.get_gameObject(lVar4,0)) != null))) {
                      GameObject.SetActive(lVar4,cVar2,0);
                      lVar4 = CISAuthSDKController.FindFCMSpeInfoRoot(this,0);
                      if (((lVar4 != null) && (lVar4 = GameObject.get_transform(lVar4,0)) != null) &&
                         ((lVar4 = Transform.Find(lVar4,"GameStopBlack",0), lVar4 != null &&
                          ((lVar4 = Transform.Find(lVar4,"Text",0), lVar4 != null &&
                           (plVar5 = (int64 *)Component.GetComponent(lVar4,DAT_181d6d8c0),
                           plVar5 != (int64 *)0)))))) {
                        (**(code **)(*plVar5 + 0x5e8))(plVar5,uVar6,*(uint64 *)(*plVar5 + 0x5f0));
                        return result;
                      }
                    }
                  }
                }
                throw; // [null/range check failed]
              }
            }
            return false;
          }
        }
    }

    // Token : 0x6000E34
    // RVA   : 0xBD6D90   Offset: 0xBD5590   Length: 0x13B
    public GameObject FindFCMSpeInfoRoot()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        long lVar5;
        lVar2 = GameObject.FindGameObjectWithTag("FCMSpeInfo",0);
        cVar1 = Object.op_Equality(lVar2,0,0);
        if (!cVar1) {
          return lVar2;
        }
        uVar3 = GameObject.FindGameObjectWithTag("UICanvas",0);
        plVar4 = (int64 *)Resources.Load("Prefabs/FCMSpeInfo",0);
        plVar6 = (int64 *)0;
        if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d4e110)) {
          plVar6 = plVar4;
        }
        lVar2 = GlobalData.AddChild(uVar3,plVar6,0);
        if ((lVar2 != null) && (lVar5 = GameObject.get_transform(lVar2,0)) != null) {
          Transform.SetAsLastSibling(lVar5,0);
          return lVar2;
        }
    }

    // Token : 0x6000E35
    // RVA   : 0xBD74A0   Offset: 0xBD5CA0   Length: 0x23A
    public void ShowSpeInfoText(string text)
    {
        ulong uVar1;
        ulong uVar2;
        bool cVar3;
        long lVar4;
        uVar1 = CISAuthSDKController.FindFCMSpeInfoRoot(this,0);
        cVar3 = Object.op_Inequality(uVar1,0,0);
        if (!cVar3) {
          return;
        }
        lVar4 = CISAuthSDKController.FindFCMSpeInfoRoot(this,0);
        if (((lVar4 != null) && (lVar4 = GameObject.get_transform(lVar4,0)) != null) &&
           (lVar4 = Transform.Find(lVar4,"SpeInfoRoot",0)) != null) {
          uVar2 = Component.get_gameObject(lVar4,0);
          uVar1 = this.FCMSpeInfoTextPrefab;
          lVar4 = GlobalData.AddChild(uVar2,uVar1,0);
          if (((lVar4 != null) && (lVar4 = GameObject.get_transform(lVar4,0)) != null) &&
             ((lVar4 = Transform.Find(lVar4,"Text",0), lVar4 != null &&
              (plVar5 = (int64 *)Component.GetComponent(lVar4,DAT_181d6d8c0),
              plVar5 != (int64 *)0)))) {
            (**(code **)(*plVar5 + 0x5e8))(plVar5,text,*(uint64 *)(*plVar5 + 0x5f0));
            lVar4 = CISAuthSDKController.FindFCMSpeInfoRoot(this,0);
            if ((((lVar4 != null) && (lVar4 = GameObject.get_transform(lVar4,0)) != null) &&
                (lVar4 = Transform.Find(lVar4,"SpeInfoRoot",0)) != null) &&
               (lVar4 = Component.GetComponent(lVar4,DAT_181d6e0c0)) != null) {
              UIGrid.set_repositionNow(lVar4,1,0);
              Debug.Log(text,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000E36
    // RVA   : 0xBD73A0   Offset: 0xBD5BA0   Length: 0x99
    private void OnApplicationPause(bool pauseStatus)
    {
        long lVar1;
        if (!pauseStatus) {
          lVar1 = CISFCMAPI.get_Instance(0);
          if (lVar1 != null) {
            CISFCMAPI.StartGame(lVar1,0);
            return;
          }
        }
        else {
          lVar1 = CISFCMAPI.get_Instance(0);
          if (lVar1 != null) {
            CISFCMAPI.EndGame(lVar1,0);
            return;
          }
        }
    }

    // Token : 0x6000E37
    // RVA   : 0xBD7440   Offset: 0xBD5C40   Length: 0x5D
    private void OnApplicationQuit()
    {
        long lVar1;
        lVar1 = CISFCMAPI.get_Instance(0);
        if (lVar1 != null) {
          CISFCMAPI.EndGame(lVar1,0);
          return;
        }
    }

    // Token : 0x6000E38
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6000E39
    // RVA   : 0xBD7B40   Offset: 0xBD6340   Length: 0xB0
    private void <Start>b__6_1(FCMStateResponse r)
    {
        ulong uVar1;
        uVar1 = JsonHelper.jsonEncode(r,0);
        Debug.Log(uVar1,0);
        CISAuthSDKController.ManageFCMState(this,r,0,0);
    }

}
