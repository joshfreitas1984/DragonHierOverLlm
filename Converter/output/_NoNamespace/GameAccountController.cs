// ============================================================
// Type  : GameAccountController
// Token : 0x20002A2
// ============================================================

public class GameAccountController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400151E
    public GameObject LoginMenu;

    // Token: 0x400151F
    public GameObject VerifyIDMenu;

    // Token: 0x4001520
    public GameObject ChildInfoMenu;

    // Token: 0x4001521
    public GameObject CoverBlack;

    // Token: 0x4001522
    public InputField userNameRegisterInputField;

    // Token: 0x4001523
    public InputField passWordRegisterInputField;

    // Token: 0x4001524
    public InputField userNameInputField;

    // Token: 0x4001525
    public InputField passWordInputField;

    // Token: 0x4001526
    public Toggle loginToggle;

    // Token: 0x4001527
    public InputField verifyIDNameInputField;

    // Token: 0x4001528
    public InputField verifyIDCardInputField;

    // Token: 0x4001529
    private static GameAccountController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001592
    // RVA   : 0x18623E0   Offset: 0x18611E0   Length: 0x36
    public static GameAccountController get_Instance()
    {
        return **(uint64 **)(DAT_181e527e8 + 184);
    }

    // Token : 0x6001593
    // RVA   : 0x1860F50   Offset: 0x185FD50   Length: 0x10E
    private void Awake()
    {
        bool cVar2;
        ulong uVar3;
        uVar3 = **(uint64 **)(DAT_181e527e8 + 184);
        cVar2 = Object.op_Equality(uVar3,0,0);
        if (cVar2) {
          cVar2 = GlobalData.IsCheckVersion(1,0);
          if (cVar2) {
            puVar1 = *(uint64 **)(DAT_181e527e8 + 184);
            *puVar1 = this;
            il2cpp_internal(puVar1,this);
            return;
          }
        }
        uVar3 = Component.get_gameObject(this,0);
        Object.Destroy(uVar3,0);
    }

    // Token : 0x6001594
    // RVA   : 0x18614D0   Offset: 0x18602D0   Length: 0x130
    private void Start()
    {
        long lVar1;
        ulong uVar2;
        bool cVar3;
        cVar3 = PlayerPrefs.HasKey("cisauth.user",0);
        if (cVar3) {
          if (this.loginToggle == null) throw; // [null/range check failed]
          Toggle.set_isOn(this.loginToggle,1,0);
          lVar1 = this.userNameInputField;
          uVar2 = PlayerPrefs.GetString("cisauth.user",0);
          if (lVar1 == null) throw; // [null/range check failed]
          InputField.set_text(lVar1,uVar2,0);
        }
        cVar3 = PlayerPrefs.HasKey("cisauth.pwd",0);
        if (cVar3) {
          lVar1 = this.passWordInputField;
          uVar2 = PlayerPrefs.GetString("cisauth.pwd",0);
          if (lVar1 == null) throw; // [null/range check failed]
          InputField.set_text(lVar1,uVar2,0);
        }
        lVar1 = this.verifyIDNameInputField;
        uVar2 = PlayerPrefs.GetString("cisauth.idname",0);
        if (lVar1 != null) {
          InputField.set_text(lVar1,uVar2,0);
          lVar1 = this.verifyIDCardInputField;
          uVar2 = PlayerPrefs.GetString("cisauth.idcard",0);
          if (lVar1 != null) {
            InputField.set_text(lVar1,uVar2,0);
            return;
          }
        }
    }

    // Token : 0x6001595
    // RVA   : 0x1861660   Offset: 0x1860460   Length: 0x202
    public void SureRegisterButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181e95460 + 184);
        ulong uVar1;
        ulong uVar2;
        bool cVar3;
        ulong uVar4;
        if (this.userNameRegisterInputField == null) throw; // [null/range check failed]
        cVar3 = FUN_180ad1200(*(uint64 *)(this.userNameRegisterInputField + 0x170),0);
        if (!cVar3) {
          if (this.passWordRegisterInputField == null) throw; // [null/range check failed]
          cVar3 = FUN_180ad1200(*(uint64 *)(this.passWordRegisterInputField + 0x170),0);
          if (!cVar3) {
            if (this.CoverBlack != null) {
              GameObject.SetActive(this.CoverBlack,1,0);
              if (this.userNameRegisterInputField != null) {
                PlayerPrefs.SetString
                          ("cisauth.user",*(uint64 *)(this.userNameRegisterInputField + 0x170),0);
                if (this.passWordRegisterInputField != null) {
                  PlayerPrefs.SetString
                            ("cisauth.pwd",*(uint64 *)(this.passWordRegisterInputField + 0x170),0);
                  if (this.userNameRegisterInputField != null) {
                    uVar1 = *(uint64 *)(this.userNameRegisterInputField + 0x170);
                    if (this.passWordRegisterInputField != null) {
                      uVar2 = *(uint64 *)(this.passWordRegisterInputField + 0x170);
                      uVar4 = new OnTooltipCB(this,DAT_181e50710,DAT_181e77200);
                      CISAuthSDK.Account_Signup(uVar1,uVar2,uVar4,0);
                      return;
                    }
                  }
                }
              }
            }
            throw; // [null/range check failed]
          }
        }
        if (*pStatics != 0) {
          CISAuthSDKController.ShowSpeInfoText(*pStatics,"请填写用户名和密码",0);
          return;
        }
    }

    // Token : 0x6001596
    // RVA   : 0x1861870   Offset: 0x1860670   Length: 0x202
    public void SureSigninButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181e95460 + 184);
        ulong uVar1;
        ulong uVar2;
        bool cVar3;
        ulong uVar4;
        if (this.userNameInputField == null) throw; // [null/range check failed]
        cVar3 = FUN_180ad1200(*(uint64 *)(this.userNameInputField + 0x170),0);
        if (!cVar3) {
          if (this.passWordInputField == null) throw; // [null/range check failed]
          cVar3 = FUN_180ad1200(*(uint64 *)(this.passWordInputField + 0x170),0);
          if (!cVar3) {
            if (this.CoverBlack != null) {
              GameObject.SetActive(this.CoverBlack,1,0);
              if (this.userNameInputField != null) {
                PlayerPrefs.SetString
                          ("cisauth.user",*(uint64 *)(this.userNameInputField + 0x170),0);
                if (this.passWordInputField != null) {
                  PlayerPrefs.SetString
                            ("cisauth.pwd",*(uint64 *)(this.passWordInputField + 0x170),0);
                  if (this.userNameInputField != null) {
                    uVar1 = *(uint64 *)(this.userNameInputField + 0x170);
                    if (this.passWordInputField != null) {
                      uVar2 = *(uint64 *)(this.passWordInputField + 0x170);
                      uVar4 = new OnTooltipCB(this,DAT_181e50798,DAT_181e77100);
                      CISAuthSDK.Account_Signin(uVar1,uVar2,uVar4,0);
                      return;
                    }
                  }
                }
              }
            }
            throw; // [null/range check failed]
          }
        }
        if (*pStatics != 0) {
          CISAuthSDKController.ShowSpeInfoText(*pStatics,"请填写用户名和密码",0);
          return;
        }
    }

    // Token : 0x6001597
    // RVA   : 0x1861060   Offset: 0x185FE60   Length: 0xC0
    public void FastLoginButtonClicked()
    {
        ulong uVar1;
        if (this.CoverBlack != null) {
          GameObject.SetActive(this.CoverBlack,1,0);
          uVar1 = new OnTooltipCB(this,DAT_181ea7e50,DAT_181e77300);
          CISAuthSDK.Account_SigninFast(uVar1,0);
          return;
        }
    }

    // Token : 0x6001598
    // RVA   : 0x1861350   Offset: 0x1860150   Length: 0x176
    private void LoginSuccess()
    {
        var pStatics = *(int64*)(DAT_181e953d8 + 184);
        long lVar1;
        lVar1 = *(int64 *)(pStatics + 40);
        if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 16)) != null) {
          if (*(char *)(lVar1 + 16) != false) {
        LAB_1818614af:
            GameAccountController.LoginFinalFinish(this,0,0);
            return;
          }
          lVar1 = *(int64 *)(pStatics + 40);
          if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 16)) != null) {
            if (*(char *)(lVar1 + 17) == false) goto LAB_1818614af;
            if (this.LoginMenu != null) {
              GameObject.SetActive(this.LoginMenu,0,0);
              if (this.VerifyIDMenu != null) {
                GameObject.SetActive(this.VerifyIDMenu,1,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6001599
    // RVA   : 0x18622D0   Offset: 0x18610D0   Length: 0x103
    public void VerifyIDButtonClicked()
    {
        ulong uVar1;
        ulong uVar2;
        ulong uVar3;
        if (this.CoverBlack != null) {
          GameObject.SetActive(this.CoverBlack,1,0);
          if (this.verifyIDNameInputField != null) {
            uVar1 = *(uint64 *)(this.verifyIDNameInputField + 0x170);
            if (this.verifyIDCardInputField != null) {
              uVar2 = *(uint64 *)(this.verifyIDCardInputField + 0x170);
              uVar3 = new OnTooltipCB(this,DAT_181e50820,DAT_181e77580);
              CISAuthSDK.Account_VerifyUserIdentity(uVar1,uVar2,uVar3,0);
              return;
            }
          }
        }
    }

    // Token : 0x600159A
    // RVA   : 0x1861610   Offset: 0x1860410   Length: 0x46
    public void SureChildInfoButton()
    {
        var pStatics = *(int64*)(DAT_181e53068 + 184);
        if (*pStatics != 0) {
          GameTitleController.ShowMainMenu(*pStatics,0);
          return;
        }
    }

    // Token : 0x600159B
    // RVA   : 0x1861250   Offset: 0x1860050   Length: 0xF6
    public void LoginFinalFinish(bool firstVerify)
    {
        long lVar1;
        ulong uVar2;
        lVar1 = new c.DisplayClass9_0(0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 16) = this;
          *(uint8 *)(lVar1 + 24) = firstVerify;
          uVar2 = new OnTooltipCB(lVar1,DAT_181e879a0,DAT_181e77300);
          CISAuthSDK.Account_Refresh(uVar2,0);
          return;
        }
    }

    // Token : 0x600159C
    // RVA   : 0x1861130   Offset: 0x185FF30   Length: 0x118
    public void LoginFinalFinishReal(bool firstVerify)
    {
        var pStatics_3068 = *(int64*)(DAT_181e53068 + 184);
        var pStatics_5460 = *(int64*)(DAT_181e95460 + 184);
        long lVar1;
        if (*pStatics_5460 != 0) {
          *(uint8 *)(*pStatics_5460 + 24) = 1;
          if (*pStatics_5460 != 0) {
            lVar1 = CISAuthSDKController.CheckFCMState(*pStatics_5460,1,0);
            if (firstVerify) {
              if (lVar1 == null) throw; // [null/range check failed]
              if ((*(int *)(lVar1 + 28) == 0) && (*(int *)(lVar1 + 48) < 18)) {
                if (this.VerifyIDMenu != null) {
                  GameObject.SetActive(this.VerifyIDMenu,0,0);
                  if (this.ChildInfoMenu != null) {
                    GameObject.SetActive(this.ChildInfoMenu,1,0);
                    return;
                  }
                }
                throw; // [null/range check failed]
              }
            }
            if (*pStatics_3068 != 0) {
              GameTitleController.ShowMainMenu(*pStatics_3068,0);
              return;
            }
          }
        }
    }

    // Token : 0x600159D
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

    // Token : 0x600159E
    // RVA   : 0x1861BE0   Offset: 0x18609E0   Length: 0x23B
    private void <SureRegisterButtonClicked>b__16_0(APIResult<APISignupRespData> result)
    {
        var pStatics = *(int64*)(DAT_181e95460 + 184);
        long lVar1;
        ulong uVar2;
        if (result == null) throw; // [null/range check failed]
        if (*(char *)(result + 24) == false) {
          if (*(int64 *)(result + 16) == 0) throw; // [null/range check failed]
          lVar1 = *(int64 *)(*(int64 *)(result + 16) + 16);
          if (lVar1 == 0x3ee) {
            if (*pStatics == 0) throw; // [null/range check failed]
            CISAuthSDKController.ShowSpeInfoText(*pStatics,"注册失败，该用户名已被注册",0);
          }
          else if (lVar1 == 0x2077) {
            if (*pStatics == 0) throw; // [null/range check failed]
            CISAuthSDKController.ShowSpeInfoText(*pStatics,"注册失败，用户名不符合要求",0);
          }
          else if (lVar1 == 0x2079) {
            lVar1 = FUN_1806b85e0(0);
            if (lVar1 == null) throw; // [null/range check failed]
            CISAuthSDKController.ShowSpeInfoText(lVar1,"注册失败，密码不符合要求",0);
          }
          else {
            lVar1 = FUN_1806b85e0(0);
            if (*(int64 *)(result + 16) == 0) throw; // [null/range check failed]
            uVar2 = Int64.ToString(*(int64 *)(result + 16) + 16,0);
            if (*(int64 *)(result + 16) == 0) throw; // [null/range check failed]
            uVar2 = String.Concat("注册失败，错误代码：",uVar2,"\n",
                                   *(uint64 *)(*(int64 *)(result + 16) + 24),0);
            if (lVar1 == null) throw; // [null/range check failed]
            CISAuthSDKController.ShowSpeInfoText(lVar1,uVar2,0);
          }
        }
        else {
          if (*pStatics == 0) throw; // [null/range check failed]
          CISAuthSDKController.ShowSpeInfoText(*pStatics,"注册成功",0);
          GameAccountController.LoginSuccess(this,0);
        }
        if (this.CoverBlack != null) {
          GameObject.SetActive(this.CoverBlack,0,0);
          return;
        }
    }

    // Token : 0x600159F
    // RVA   : 0x1861E20   Offset: 0x1860C20   Length: 0x1C9
    private void <SureSigninButtonClicked>b__17_0(APIResult<APISigninRespData> result)
    {
        var pStatics = *(int64*)(DAT_181e95460 + 184);
        long lVar1;
        ulong uVar2;
        long lVar3;
        if (result == null) throw; // [null/range check failed]
        if (*(char *)(result + 24) == false) {
          lVar3 = *(int64 *)(result + 16);
          if (lVar3 == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar3 + 16) == 0x3f4) {
            if (*pStatics == 0) throw; // [null/range check failed]
            CISAuthSDKController.ShowSpeInfoText(*pStatics,"登录失败，用户名或密码错误",0);
          }
          else {
            if (!DAT_181eb6dbb) {
              il2cpp_runtime_class_init(&DAT_181e95460);
              DAT_181eb6dbb = true;
              lVar3 = *(int64 *)(result + 16);
            }
            lVar1 = *pStatics;
            if (lVar3 == null) throw; // [null/range check failed]
            uVar2 = Int64.ToString(lVar3 + 16,0);
            if (*(int64 *)(result + 16) == 0) throw; // [null/range check failed]
            uVar2 = String.Concat("登录失败，错误代码：",uVar2,"\n",
                                   *(uint64 *)(*(int64 *)(result + 16) + 24),0);
            if (lVar1 == null) throw; // [null/range check failed]
            CISAuthSDKController.ShowSpeInfoText(lVar1,uVar2,0);
          }
        }
        else {
          if (*pStatics == 0) throw; // [null/range check failed]
          CISAuthSDKController.ShowSpeInfoText(*pStatics,"登录成功",0);
          GameAccountController.LoginSuccess(this,0);
        }
        if (this.CoverBlack != null) {
          GameObject.SetActive(this.CoverBlack,0,0);
          return;
        }
    }

    // Token : 0x60015A0
    // RVA   : 0x1861A80   Offset: 0x1860880   Length: 0x158
    private void <FastLoginButtonClicked>b__18_0(APIResult<CISAccountData> result)
    {
        var pStatics = *(int64*)(DAT_181e95460 + 184);
        long lVar1;
        ulong uVar2;
        if (result == null) throw; // [null/range check failed]
        if (*(char *)(result + 24) == false) {
          lVar1 = *pStatics;
          if (*(int64 *)(result + 16) == 0) throw; // [null/range check failed]
          uVar2 = Int64.ToString(*(int64 *)(result + 16) + 16,0);
          if (*(int64 *)(result + 16) == 0) throw; // [null/range check failed]
          uVar2 = String.Concat("快速登录失败，错误代码：",uVar2,"\n",
                                 *(uint64 *)(*(int64 *)(result + 16) + 24),0);
          if (lVar1 == null) throw; // [null/range check failed]
          CISAuthSDKController.ShowSpeInfoText(lVar1,uVar2,0);
        }
        else {
          if (*pStatics == 0) throw; // [null/range check failed]
          CISAuthSDKController.ShowSpeInfoText(*pStatics,"快速登录成功",0);
          GameAccountController.LoginSuccess(this,0);
        }
        if (this.CoverBlack != null) {
          GameObject.SetActive(this.CoverBlack,0,0);
          return;
        }
    }

    // Token : 0x60015A1
    // RVA   : 0x1861FF0   Offset: 0x1860DF0   Length: 0x2D6
    private void <VerifyIDButtonClicked>b__20_0(APIResult<int> resp)
    {
        var pStatics = *(int64*)(DAT_181e95460 + 184);
        int iVar1;
        ulong uVar2;
        long lVar3;
        long lVar4;
        if (resp == null) throw; // [null/range check failed]
        if (*(char *)(resp + 24) == false) {
          lVar4 = *(int64 *)(resp + 16);
          if (lVar4 == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar4 + 16) == 0x3fd) {
            lVar3 = *pStatics;
            uVar2 = "实名认证失败，请填写真实姓名和身份证号";
          }
          else {
            if (!DAT_181eb6dbb) {
              il2cpp_runtime_class_init(&DAT_181e95460);
              DAT_181eb6dbb = true;
              lVar4 = *(int64 *)(resp + 16);
            }
            lVar3 = *pStatics;
            if (lVar4 == null) throw; // [null/range check failed]
            uVar2 = Int64.ToString(lVar4 + 16,0);
            uVar2 = String.Concat("实名认证失败，错误代码：",uVar2,0);
          }
        joined_r0x00018186223b:
          if (lVar3 == null) throw; // [null/range check failed]
          CISAuthSDKController.ShowSpeInfoText(lVar3,uVar2,0);
        }
        else {
          iVar1 = *(int *)(resp + 32);
          if (iVar1 != 0) {
            if (iVar1 == 0x215c) {
              lVar3 = *pStatics;
              uVar2 = "实名认证已经提交过不一致的身份证";
            }
            else if (iVar1 == 0x215d) {
              lVar3 = FUN_1806b85e0(0);
              uVar2 = "身份证信息无效";
            }
            else {
              lVar3 = FUN_1806b85e0(0);
              uVar2 = Int32.ToString(resp + 32,0);
              uVar2 = String.Concat("实名认证错误代码：",uVar2,0);
            }
            goto joined_r0x00018186223b;
          }
          if (*pStatics == 0) throw; // [null/range check failed]
          CISAuthSDKController.ShowSpeInfoText(*pStatics,"实名认证成功",0);
          GameAccountController.LoginFinalFinish(this,1,0);
        }
        uVar2 = APIResult.ToJson(resp,0);
        uVar2 = String.Concat("实名认证结果:",uVar2,0);
        Debug.Log(uVar2,0);
        if (this.CoverBlack != null) {
          GameObject.SetActive(this.CoverBlack,0,0);
          return;
        }
    }

}
