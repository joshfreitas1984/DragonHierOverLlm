// ============================================================
// Type  : GameTitleController
// Token : 0x20002AA
// ============================================================

public class GameTitleController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40014F3
    public GameObject TitleImage;

    // Token: 0x40014F4
    public GameObject WishListButton;

    // Token: 0x40014F5
    public GameObject AccountMenu;

    // Token: 0x40014F6
    public GameObject StartInfoMenu;

    // Token: 0x40014F7
    public GameObject MainMenu;

    // Token: 0x40014F8
    public GameObject continueButton;

    // Token: 0x40014F9
    public GameObject startButton;

    // Token: 0x40014FA
    public GameObject loadButton;

    // Token: 0x40014FB
    public GameObject settingButton;

    // Token: 0x40014FC
    public GameObject quitButton;

    // Token: 0x40014FD
    public Text versionText;

    // Token: 0x40014FE
    public Text extraInfo;

    // Token: 0x40014FF
    public GameObject checkText;

    // Token: 0x4001500
    public GameObject checkPlayerAge;

    // Token: 0x4001501
    public SaveLoadMenuController saveLoadMenuController;

    // Token: 0x4001502
    public SettingMenuController settingMenuController;

    // Token: 0x4001503
    public List<Transform> pathPoints;

    // Token: 0x4001504
    public Vector3[] buttonPath;

    // Token: 0x4001505
    public List<DlcSprite> dlcSprites;

    // Token: 0x4001506
    public InfoMenuController infoMenuController;

    // Token: 0x4001507
    private static GameTitleController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600168B
    // RVA   : 0xA316E0   Offset: 0xA2FEE0   Length: 0x36
    public static GameTitleController get_Instance()
    {
        return **(uint64 **)(DAT_181d4e708 + 184);
    }

    // Token : 0x600168C
    // RVA   : 0xA2F930   Offset: 0xA2E130   Length: 0x51E
    private void Awake()
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
        int iVar1;
        long lVar3;
        bool cVar4;
        ulong uVar5;
        long lVar6;
        uint uVar8;
        long lVar9;
        byte[] local_28 = new byte[16];
        uVar5 = **(uint64 **)(DAT_181d4e708 + 184);
        cVar4 = Object.op_Equality(uVar5,0,0);
        if (cVar4) {
          plVar2 = *(int64 **)(DAT_181d4e708 + 184);
          *plVar2 = this;
          il2cpp_internal(plVar2,this);
        }
        if (**(int **)(DAT_181d4ef00 + 184) == 2) {
        LAB_180a2fb17:
          lVar6 = this.checkText;
          if (lVar6 == null) throw; // [null/range check failed]
          uVar5 = 1;
        }
        else {
          if (**(int **)(DAT_181d4ef00 + 184) == 4) goto LAB_180a2fb17;
          if (*(char *)(pStatics + 4) != false) goto LAB_180a2fb17;
          lVar6 = this.checkText;
          if (lVar6 == null) throw; // [null/range check failed]
          uVar5 = 0;
        }
        GameObject.SetActive(lVar6,uVar5,0);
        uVar8 = 0;
        if (**(int **)(DAT_181d4ef00 + 184) == 2) {
        LAB_180a2fcec:
          if ((this.versionText == null) ||
             (lVar6 = Component.get_gameObject(this.versionText,0)) == null)
          throw; // [null/range check failed]
          GameObject.SetActive(lVar6,0,0);
          if ((this.extraInfo == null) ||
             (lVar6 = Component.get_gameObject(this.extraInfo,0)) == null)
          throw; // [null/range check failed]
          GameObject.SetActive(lVar6,0,0);
        }
        else {
          if (**(int **)(DAT_181d4ef00 + 184) == 4) goto LAB_180a2fcec;
          plVar2 = this.versionText;
          iVar1 = *(int *)(pStatics + 8);
          uVar5 = "PlayTest ";
          if (((iVar1 != 1) && (uVar5 = "Demo ", iVar1 != 2)) && (uVar5 = "Expo ", iVar1 != 3)
             ) {
            uVar5 = "";
          }
          if (plVar2 == (int64 *)0) throw; // [null/range check failed]
          (**(code **)(*plVar2 + 0x5e8))(plVar2,uVar5,*(uint64 *)(*plVar2 + 0x5f0));
          plVar2 = this.versionText;
          if (plVar2 == (int64 *)0) throw; // [null/range check failed]
          uVar5 = (**(code **)(*plVar2 + 0x5d8))(plVar2,*(uint64 *)(*plVar2 + 0x5e0));
          uVar5 = String.Concat(uVar5,"V",
                                 *(uint64 *)(pStatics + 112),
                                 *(uint64 *)(pStatics + 120),0);
          (**(code **)(*plVar2 + 0x5e8))(plVar2,uVar5,*(uint64 *)(*plVar2 + 0x5f0));
        }
        if (this.pathPoints != null) {
          uVar5 = FUN_1800d60b0(DAT_181d81c40,this.pathPoints.Count + 1);
          this.buttonPath = uVar5;
          lVar6 = this.pathPoints;
          if (lVar6 != null) {
            lVar9 = 32;
            while( true ) {
              if (lVar6.Count <= (int)uVar8) {
                return;
              }
              lVar3 = this.buttonPath;
              if (lVar6 == null) break;
              if (lVar6.Count <= uVar8) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar6 = *(int64 *)(lVar9 + lVar6._items);
              if (((lVar6 == null) || (lVar6 = Component.get_transform(lVar6,0)) == null) ||
                 (puVar7 = (uint64 *)Transform.get_localPosition(local_28,lVar6,0), lVar3 == null))
              break;
              if (*(uint32 *)(lVar3 + 24) <= uVar8) {
                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar5,0);
              }
              lVar9 = lVar9 + 8;
              lVar6 = (int64)(int)uVar8;
              uVar8 = uVar8 + 1;
              *(uint64 *)(lVar3 + 32 + lVar6 * 12) = *puVar7;
              *(uint32 *)(lVar3 + 40 + lVar6 * 12) = *(uint32 *)(puVar7 + 1);
              lVar6 = this.pathPoints;
              if (lVar6 == null) break;
            }
          }
        }
    }

    // Token : 0x600168D
    // RVA   : 0xA30A70   Offset: 0xA2F270   Length: 0xBCA
    private void Start()
    {
        var pStatics_e010 = *(int64*)(DAT_181d4e010 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        var pStatics_ffe8 = *(int64*)(DAT_181d8ffe8 + 184);
        long lVar1;
        int iVar2;
        long lVar3;
        ulong uVar6;
        ulong uVar7;
        long lVar8;
        uint uVar10;
        uint uVar11;
        uint uVar12;
        uint uVar13;
        int[] local_res8 = new int[2];
        ulong local_68;
        uint local_60;
        ulong local_58;
        ulong uStack_50;
        if (this.continueButton == null) throw; // [null/range check failed]
        lVar3 = GameObject.GetComponent(this.continueButton,DAT_181d9ee60);
        if (this.saveLoadMenuController == null) throw; // [null/range check failed]
        iVar2 = SaveLoadMenuController.GetRecentSaveSlotID(this.saveLoadMenuController,0);
        if (lVar3 == null) throw; // [null/range check failed]
        Selectable.set_interactable(lVar3,iVar2 != -1,0);
        if (this.continueButton == null) throw; // [null/range check failed]
        lVar3 = GameObject.GetComponent(this.continueButton,DAT_181d9ee60);
        if (lVar3 == null) throw; // [null/range check failed]
        lVar8 = this.continueButton;
        if (*(char *)(lVar3 + 208) == false) {
          if (lVar8 == null) throw; // [null/range check failed]
          plVar4 = (int64 *)GameObject.GetComponent(lVar8,DAT_181d9fe50);
          puVar5 = (uint64 *)FUN_181098a50(&local_58,0);
          local_58 = *puVar5;
          uStack_50 = puVar5[1];
          puVar5 = (uint64 *)FUN_181098d60(&local_68,&local_58,0x3f000000,0);
          if (plVar4 == (int64 *)0) throw; // [null/range check failed]
          local_58 = *puVar5;
          uStack_50 = puVar5[1];
          (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_58,*(uint64 *)(*plVar4 + 0x2b0));
        }
        else {
          if (lVar8 == null) throw; // [null/range check failed]
          lVar3 = GameObject.GetComponent(lVar8,DAT_181da12b0);
          if (this.saveLoadMenuController == null) throw; // [null/range check failed]
          uVar6 = SaveLoadMenuController.GetRecentSaveSlotDescribe(this.saveLoadMenuController,0);
          if (lVar3 == null) throw; // [null/range check failed]
          *(uint64 *)(lVar3 + 24) = uVar6;
        }
        if (this.TitleImage == null) throw; // [null/range check failed]
        plVar4 = (int64 *)GameObject.GetComponent(this.TitleImage,DAT_181d9fe50);
        puVar5 = (uint64 *)FUN_180d904c0(&local_58,0);
        if (plVar4 == (int64 *)0) throw; // [null/range check failed]
        local_58 = *puVar5;
        uStack_50 = puVar5[1];
        (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_58,*(uint64 *)(*plVar4 + 0x2b0));
        if (this.TitleImage == null) throw; // [null/range check failed]
        uVar6 = GameObject.GetComponent(this.TitleImage,DAT_181d9fe50);
        puVar5 = (uint64 *)FUN_181098a50(&local_58,0);
        local_58 = *puVar5;
        uStack_50 = puVar5[1];
        DOTweenModuleUI.DOColor(uVar6,&local_58,0x3f800000,0);
        if (this.WishListButton == null) throw; // [null/range check failed]
        lVar3 = GameObject.get_transform(this.WishListButton,0);
        puVar5 = (uint64 *)Vector3.get_zero(&local_58,0);
        if (lVar3 == null) throw; // [null/range check failed]
        local_60 = *(uint32 *)(puVar5 + 1);
        local_68 = *puVar5;
        Transform.set_localScale(lVar3,&local_68,0);
        if (this.WishListButton == null) throw; // [null/range check failed]
        uVar6 = GameObject.get_transform(this.WishListButton,0);
        uVar6 = ShortcutExtensions.DOScale(uVar6,0x3f800000,0x3f000000,0);
        uVar6 = TweenSettingsExtensions.SetDelay(uVar6,0x3f800000,DAT_181d97978);
        uVar7 = new OnTooltipCB(this,DAT_181d4d320,0);
        TweenSettingsExtensions.OnComplete(uVar6,uVar7,DAT_181d96ee8);
        if (**(int **)(DAT_181d4ef00 + 184) == 2) {
        LAB_180a30ff5:
          if (this.checkPlayerAge == null) throw; // [null/range check failed]
          GameObject.SetActive(this.checkPlayerAge,1,0);
          if (*pStatics_ffe8 == 0) throw; // [null/range check failed]
          if (*(char *)(*pStatics_ffe8 + 24) != false) goto LAB_180a3107b;
          lVar3 = this.AccountMenu;
        LAB_180a3104f:
          if (lVar3 == null) throw; // [null/range check failed]
          GameObject.SetActive(lVar3,1,0);
          if (this.MainMenu == null) throw; // [null/range check failed]
          GameObject.SetActive(this.MainMenu,0,0);
        }
        else {
          if (**(int **)(DAT_181d4ef00 + 184) == 4) goto LAB_180a30ff5;
          if (*(int *)(pStatics_ef00 + 8) == 1) {
        LAB_180a30fef:
            lVar3 = this.StartInfoMenu;
            goto LAB_180a3104f;
          }
          lVar3 = *(int64 *)(pStatics_e010 + 8);
          if ((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 16)) == null) throw; // [null/range check failed]
          iVar2 = PlayerPrefDictionary.GetInt(lVar3,"WelcomeTextShowed",0);
          if (iVar2 < 1) {
            lVar3 = *(int64 *)(pStatics_e010 + 8);
            if ((lVar3 == null) || (lVar3 = *(int64 *)(lVar3 + 16)) == null) throw; // [null/range check failed]
            PlayerPrefDictionary.SetKey(lVar3,"WelcomeTextShowed",1);
            goto LAB_180a30fef;
          }
        LAB_180a3107b:
          GameTitleController.ShowMainMenu(this,0);
        }
        local_res8[0] = 0;
        while( true ) {
          iVar2 = local_res8[0];
          lVar3 = *(int64 *)(pStatics_ef00 + 64);
          if (lVar3 == null) break;
          if (*(int *)(lVar3 + 24) <= iVar2) {
            return;
          }
          if (this.MainMenu == null) break;
          lVar3 = GameObject.get_transform(this.MainMenu,0);
          if (lVar3 == null) break;
          lVar3 = Transform.Find(lVar3,"DlcList",0);
          uVar6 = Int32.ToString(local_res8,0);
          if (lVar3 == null) break;
          lVar3 = Transform.Find(lVar3,uVar6,0);
          if (lVar3 == null) break;
          lVar3 = Component.GetComponent(lVar3,DAT_181d6e8c0);
          if (**(int **)(DAT_181d4ef00 + 184) == 1) {
            lVar8 = *(int64 *)(pStatics_ef00 + 96);
          }
          else {
            lVar8 = *(int64 *)(pStatics_ef00 + 88);
          }
          if (lVar8 == null) break;
          uVar6 = FUN_180002f80(lVar8,local_res8[0],DAT_181d7c9c0);
          if (lVar3 == null) break;
          *(uint64 *)(lVar3 + 24) = uVar6;
          if (this.MainMenu == null) break;
          lVar3 = GameObject.get_transform(this.MainMenu,0);
          if (lVar3 == null) break;
          lVar3 = Transform.Find(lVar3,"DlcList",0);
          uVar6 = Int32.ToString(local_res8,0);
          if (lVar3 == null) break;
          lVar3 = Transform.Find(lVar3,uVar6,0);
          if (lVar3 == null) break;
          lVar3 = Transform.Find(lVar3,"Image",0);
          if (lVar3 == null) break;
          lVar3 = Component.GetComponent(lVar3,DAT_181d6bc40);
          if (this.dlcSprites == null) break;
          lVar8 = FUN_180002f80(this.dlcSprites,local_res8[0],DAT_181d5d500);
          if (lVar8 == null) break;
          lVar8 = *(int64 *)(lVar8 + 16);
          lVar1 = *(int64 *)(pStatics_e010 + 8);
          if (lVar1 == null) break;
          lVar1 = *(int64 *)(lVar1 + 16);
          uVar6 = Int32.ToString(local_res8,0);
          uVar6 = String.Concat("DLC",uVar6,0);
          if (lVar1 == null) break;
          iVar2 = PlayerPrefDictionary.GetInt(lVar1,uVar6,0);
          if (lVar8 == null) break;
          uVar6 = FUN_180002f80(lVar8,0 < iVar2,DAT_181d7c050);
          if (lVar3 == null) break;
          Image.set_sprite(lVar3,uVar6,0);
          if (this.MainMenu == null) break;
          lVar3 = GameObject.get_transform(this.MainMenu,0);
          if (lVar3 == null) break;
          lVar3 = Transform.Find(lVar3,"DlcList",0);
          uVar6 = Int32.ToString(local_res8,0);
          if (lVar3 == null) break;
          lVar3 = Transform.Find(lVar3,uVar6,0);
          if (lVar3 == null) break;
          lVar3 = Transform.Find(lVar3,"Text",0);
          if (lVar3 == null) break;
          plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181d6d8c0);
          lVar3 = *(int64 *)(pStatics_e010 + 8);
          if (lVar3 == null) break;
          lVar3 = *(int64 *)(lVar3 + 16);
          uVar6 = Int32.ToString(local_res8,0);
          uVar6 = String.Concat("DLC",uVar6,0);
          if (lVar3 == null) break;
          iVar2 = PlayerPrefDictionary.GetInt(lVar3,uVar6,0);
          uVar6 = "未获取";
          if (0 < iVar2) {
            uVar6 = "已获取";
          }
          if (plVar4 == (int64 *)0) break;
          (**(code **)(*plVar4 + 0x5e8))(plVar4,uVar6,*(uint64 *)(*plVar4 + 0x5f0));
          if (this.MainMenu == null) break;
          lVar3 = GameObject.get_transform(this.MainMenu,0);
          if (lVar3 == null) break;
          lVar3 = Transform.Find(lVar3,"DlcList",0);
          uVar6 = Int32.ToString(local_res8,0);
          if (lVar3 == null) break;
          lVar3 = Transform.Find(lVar3,uVar6,0);
          if (lVar3 == null) break;
          lVar3 = Transform.Find(lVar3,"Text",0);
          if (lVar3 == null) break;
          plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181d6d8c0);
          lVar3 = *(int64 *)(pStatics_e010 + 8);
          if (lVar3 == null) break;
          lVar3 = *(int64 *)(lVar3 + 16);
          uVar6 = Int32.ToString(local_res8,0);
          uVar6 = String.Concat("DLC",uVar6,0);
          if (lVar3 == null) break;
          iVar2 = PlayerPrefDictionary.GetInt(lVar3,uVar6,0);
          if (iVar2 < 1) {
            puVar9 = (uint32 *)FUN_181098a50(&local_68,0);
            uVar10 = *puVar9;
            uVar11 = puVar9[1];
            uVar12 = puVar9[2];
            uVar13 = puVar9[3];
          }
          else {
            local_58 = 0;
            uStack_50 = 0;
            Color.ctor(&local_58,0x3f800000,0x3f55d5d6,0x3f088889,0);
            uVar10 = (uint32)local_58;
            uVar11 = local_58._4_4_;
            uVar12 = (uint32)uStack_50;
            uVar13 = uStack_50._4_4_;
          }
          if (plVar4 == (int64 *)0) break;
          local_58 = CONCAT44(uVar11,uVar10);
          uStack_50 = CONCAT44(uVar13,uVar12);
          (**(code **)(*plVar4 + 0x2a8))(plVar4);
          local_res8[0] = local_res8[0] + 1;
        }
    }

    // Token : 0x600168E
    // RVA   : 0xA30980   Offset: 0xA2F180   Length: 0x39
    public void ShowStartInfoMenu()
    {
        if (this.StartInfoMenu != null) {
          GameObject.SetActive(this.StartInfoMenu,1,0);
          if (this.MainMenu != null) {
            GameObject.SetActive(this.MainMenu,0,0);
            return;
          }
        }
    }

    // Token : 0x600168F
    // RVA   : 0xA2FF90   Offset: 0xA2E790   Length: 0x39
    public void ShowAccountMenu()
    {
        if (this.AccountMenu != null) {
          GameObject.SetActive(this.AccountMenu,1,0);
          if (this.MainMenu != null) {
            GameObject.SetActive(this.MainMenu,0,0);
            return;
          }
        }
    }

    // Token : 0x6001690
    // RVA   : 0xA30000   Offset: 0xA2E800   Length: 0x970
    public void ShowMainMenu()
    {
        var pStatics_e010 = *(int64*)(DAT_181d4e010 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        long lVar1;
        float fVar2;
        bool cVar3;
        int iVar4;
        int iVar5;
        ulong uVar6;
        long lVar7;
        long lVar8;
        ulong uVar10;
        int iVar12;
        ulong in_stack_fffffffffffffe28;
        uint uVar13;
        ulong local_188;
        float local_180;
        ulong local_178;
        uint local_170;
        float local_160;
        float local_150;
        ulong local_148;
        float local_140;
        ulong local_138;
        ulong uStack_130;
        uint local_128;
        float local_110;
        float local_100;
        byte[] local_f8 = new byte[16];
        byte[] local_e8 = new byte[16];
        byte[] local_d8 = new byte[16];
        byte[] local_c8 = new byte[16];
        byte[] local_b8 = new byte[16];
        byte[] local_a8 = new byte[16];
        byte[] local_98 = new byte[112];
        local_128 = 0;
        local_138 = 0;
        uStack_130 = 0;
        if (this.AccountMenu != null) {
          GameObject.SetActive(this.AccountMenu,0,0);
          if (this.StartInfoMenu != null) {
            GameObject.SetActive(this.StartInfoMenu,0,0);
            if (this.MainMenu != null) {
              GameObject.SetActive(this.MainMenu,1,0);
              MonoBehaviour.Invoke(this,"PlayLeafSound",0x3f000000,0);
              if (**(int **)(DAT_181d4ef00 + 184) != 2) {
                if (**(int **)(DAT_181d4ef00 + 184) != 4) {
                  lVar7 = *(int64 *)(pStatics_e010 + 8);
                  if (lVar7 == null) throw; // [null/range check failed]
                  lVar7 = *(int64 *)(lVar7 + 16);
                  uVar6 = String.Concat(*(uint64 *)(pStatics_ef00 + 112),
                                         *(uint64 *)(pStatics_ef00 + 120),
                                         "LogShowed",0);
                  if (lVar7 == null) throw; // [null/range check failed]
                  iVar4 = PlayerPrefDictionary.GetInt(lVar7,uVar6,0);
                  if (iVar4 == 0) {
                    lVar7 = *(int64 *)(pStatics_e010 + 8);
                    if (lVar7 == null) throw; // [null/range check failed]
                    lVar7 = *(int64 *)(lVar7 + 16);
                    uVar6 = String.Concat(*(uint64 *)(pStatics_ef00 + 112),
                                           *(uint64 *)(pStatics_ef00 + 120),
                                           "LogShowed",0);
                    if (lVar7 == null) throw; // [null/range check failed]
                    PlayerPrefDictionary.SetKey(lVar7,uVar6,"1",0);
                    MonoBehaviour.Invoke(this,"ShowInfoMenu",0x3f000000,0);
                  }
                }
              }
              lVar7 = this.MainMenu;
              iVar4 = 0;
              if (lVar7 != null) {
                iVar12 = 5;
                while (lVar7 = GameObject.get_transform(lVar7,0)) != null {
                  iVar5 = Transform.get_childCount(lVar7,0);
                  if (iVar5 <= iVar4) {
                    return;
                  }
                  lVar7 = new c.DisplayClass9_0(0);
                  if (((this.MainMenu == null) ||
                      (lVar8 = GameObject.get_transform(this.MainMenu,0)) == null) ||
                     (uVar6 = Transform.GetChild(lVar8,iVar4,0), lVar7 == null)) break;
                  *(uint64 *)(lVar7 + 16) = uVar6;
                  if (*(int64 *)(lVar7 + 16) == 0) break;
                  uVar6 = Object.get_name(*(int64 *)(lVar7 + 16),0);
                  cVar3 = FUN_1816fd990(uVar6);
                  uVar13 = (uint32)((uint64)in_stack_fffffffffffffe28 >> 32);
                  if (!cVar3) {
                    if (iVar4 < 5) {
                      lVar8 = this.buttonPath;
                      if ((lVar8 == null) || (*(int64 *)(lVar7 + 16) == 0)) break;
                      puVar9 = (uint64 *)
                               Transform.get_localPosition(local_c8,*(int64 *)(lVar7 + 16),0);
                      lVar1 = (int64)(int)*(uint32 *)(lVar8 + 24) + -1;
                      if (*(uint32 *)(lVar8 + 24) <= (uint32)lVar1) {
                        uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar6,0);
                      }
                      *(uint64 *)(lVar8 + 32 + lVar1 * 12) = *puVar9;
                      *(uint32 *)(lVar8 + 40 + lVar1 * 12) = *(uint32 *)(puVar9 + 1);
                      lVar8 = this.buttonPath;
                      if (lVar8 == null) break;
                      if (*(int *)(lVar8 + 24) == 0) {
                        uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar6,0);
                      }
                      if (*(int64 *)(lVar7 + 16) == 0) break;
                      local_178 = *(uint64 *)(lVar8 + 32);
                      local_170 = *(uint32 *)(lVar8 + 40);
                      Transform.set_localPosition(*(int64 *)(lVar7 + 16),&local_178,0);
                      local_128 = 0;
                      local_138 = 0;
                      uStack_130 = 0;
                      in_stack_fffffffffffffe28 = CONCAT44(uVar13,3);
                      uVar6 = ShortcutExtensions.DOLocalPath
                                        (*(uint64 *)(lVar7 + 16),this.buttonPath,
                                         0x3fc00000,1,in_stack_fffffffffffffe28,10,&local_138,0);
                      uVar6 = TweenSettingsExtensions.SetEase(uVar6,10,DAT_181d97c20);
                      uVar6 = TweenSettingsExtensions.SetDelay(uVar6,(float)iVar4 * 0.1,DAT_181d978f0);
                      uVar10 = new OnTooltipCB(lVar7,DAT_181d7ba08);
                      uVar6 = TweenSettingsExtensions.OnStart(uVar6,uVar10,DAT_181d97188);
                      uVar10 = new OnTooltipCB(lVar7,DAT_181d7ba88);
                      TweenSettingsExtensions.OnComplete(uVar6);
                    }
                    else {
                      cVar3 = GlobalData.IsCheckVersion(1);
                      lVar8 = *(int64 *)(lVar7 + 16);
                      if (cVar3) {
                        if (lVar8 != null) goto LAB_180a308ab;
                        break;
                      }
                      if ((lVar8 == null) || (lVar8 = Component.get_gameObject()) == null) break;
                      cVar3 = GameObject.get_activeSelf(lVar8);
                      if (cVar3) {
                        lVar8 = *(int64 *)(lVar7 + 16);
                        if (lVar8 == null) break;
                        puVar9 = (uint64 *)Transform.get_localPosition(local_f8,lVar8,0);
                        uVar6 = *puVar9;
                        fVar2 = *(float *)(puVar9 + 1);
                        puVar9 = (uint64 *)Vector3.get_down(local_e8,0);
                        local_180 = *(float *)(puVar9 + 1) * 200.0 + fVar2;
                        local_188 = CONCAT44((float)((uint64)*puVar9 >> 32) * 200.0 +
                                             (float)((uint64)uVar6 >> 32),
                                             (float)*puVar9 * 200.0 + (float)uVar6);
                        local_110 = local_180;
                        Transform.set_localPosition(lVar8,&local_188,0);
                        lVar7 = *(int64 *)(lVar7 + 16);
                        if (lVar7 == null) break;
                        lVar8 = Transform.get_localPosition(local_d8,lVar7,0);
                        in_stack_fffffffffffffe28 = 0;
                        uVar6 = ShortcutExtensions.DOLocalMoveY
                                          (lVar7,*(float *)(lVar8 + 4) + 200.0,0x3e4ccccd,0,0);
                        TweenSettingsExtensions.SetDelay(uVar6,(float)iVar12 * 0.1 + 1.5);
                        iVar12 = iVar12 + 1;
                      }
                    }
                  }
                  else {
                    cVar3 = GlobalData.IsCheckVersion(1);
                    lVar8 = *(int64 *)(lVar7 + 16);
                    if (!cVar3) {
                      if (lVar8 == null) break;
                      puVar9 = (uint64 *)Transform.get_localPosition(local_b8,lVar8,0);
                      uVar6 = *puVar9;
                      local_150 = *(float *)(puVar9 + 1);
                      puVar9 = (uint64 *)Vector3.get_right(local_a8,0);
                      local_160 = *(float *)(puVar9 + 1);
                      local_140 = local_160 * 200.0 + local_150;
                      local_148 = CONCAT44((float)((uint64)*puVar9 >> 32) * 200.0 +
                                           (float)((uint64)uVar6 >> 32),
                                           (float)*puVar9 * 200.0 + (float)uVar6);
                      local_100 = local_140;
                      Transform.set_localPosition(lVar8,&local_148,0);
                      lVar7 = *(int64 *)(lVar7 + 16);
                      if (lVar7 == null) break;
                      pfVar11 = (float *)Transform.get_localPosition(local_98,lVar7,0);
                      in_stack_fffffffffffffe28 = 0;
                      uVar6 = ShortcutExtensions.DOLocalMoveX(lVar7,*pfVar11 - 200.0,0x3e4ccccd,0,0);
                      TweenSettingsExtensions.SetDelay(uVar6);
                    }
                    else {
                      if (lVar8 == null) break;
        LAB_180a308ab:
                      lVar7 = Component.get_gameObject(lVar8);
                      if (lVar7 == null) break;
                      GameObject.SetActive(lVar7);
                    }
                  }
                  lVar7 = this.MainMenu;
                  iVar4 = iVar4 + 1;
                  if (lVar7 == null) break;
                }
              }
            }
          }
        }
    }

    // Token : 0x6001691
    // RVA   : 0xA2FFD0   Offset: 0xA2E7D0   Length: 0x20
    public void ShowInfoMenu()
    {
        if (this.infoMenuController != null) {
          InfoMenuController.ShowInfoMenu(this.infoMenuController,0);
          return;
        }
    }

    // Token : 0x6001692
    // RVA   : 0xA2FEB0   Offset: 0xA2E6B0   Length: 0x93
    public void PlayLeafSound()
    {
        plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/SpeEffect/飞叶",0);
        plVar2 = (int64 *)0;
        if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181d8a228)) {
          plVar2 = plVar1;
        }
        NGUITools.PlaySound(plVar2,0x3e99999a,0);
    }

    // Token : 0x6001693
    // RVA   : 0xA2FE50   Offset: 0xA2E650   Length: 0x20
    public void ContinueButtonClicked()
    {
        if (this.saveLoadMenuController != null) {
          SaveLoadMenuController.LoadRecentGame(this.saveLoadMenuController,0);
          return;
        }
    }

    // Token : 0x6001694
    // RVA   : 0xA309C0   Offset: 0xA2F1C0   Length: 0xAB
    public void StartButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d815f0 + 184);
        if (*pStatics != 0) {
          StartMenuController.ShowStartMenu(*pStatics,0);
          return;
        }
    }

    // Token : 0x6001695
    // RVA   : 0xA2FE80   Offset: 0xA2E680   Length: 0x25
    public void LoadButtonClicked()
    {
        if (this.saveLoadMenuController != null) {
          SaveLoadMenuController.ShowLoadMenu(this.saveLoadMenuController,1);
          return;
        }
    }

    // Token : 0x6001696
    // RVA   : 0xA2FF60   Offset: 0xA2E760   Length: 0x20
    public void SettingButtonClicked()
    {
        if (this.settingMenuController != null) {
          SettingMenuController.ShowSettingMenu(this.settingMenuController,0);
          return;
        }
    }

    // Token : 0x6001697
    // RVA   : 0xA2FF50   Offset: 0xA2E750   Length: 0x7
    public void QuitButtonClicked()
    {
        void FUN_180a2ff50(void)
        {
        Application.Quit(0);
    }

    // Token : 0x6001698
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6001699
    // RVA   : 0xA31640   Offset: 0xA2FE40   Length: 0x92
    private void <Start>b__24_0()
    {
        ulong uVar1;
        if (this.WishListButton != null) {
          uVar1 = GameObject.get_transform(this.WishListButton,0);
          uVar1 = ShortcutExtensions.DOScale(uVar1,0x3f866666,0x40000000,0);
          uVar1 = TweenSettingsExtensions.SetLoops(uVar1,0xffffffff,1,DAT_181d98060);
          TweenSettingsExtensions.SetEase(uVar1,2,DAT_181d97ca8);
          return;
        }
    }

}
