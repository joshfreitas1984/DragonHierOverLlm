// ============================================================
// Type  : IdentifyMatchController
// Token : 0x20002ED
// ============================================================

public class IdentifyMatchController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400182A
    public IdentifyMatchState identifyMatchState;

    // Token: 0x400182B
    public GameObject identifyMatchUIPanel;

    // Token: 0x400182C
    public GameObject selectedOutline;

    // Token: 0x400182D
    public GameObject sureButton;

    // Token: 0x400182E
    public GameObject playerIcon;

    // Token: 0x400182F
    public GameObject nowChooseTreasure;

    // Token: 0x4001830
    public List<GameObject> correctTreasure;

    // Token: 0x4001831
    public float difficulty;

    // Token: 0x4001832
    public string fightEndCallFuc;

    // Token: 0x4001833
    public List<bool> identifyResult;

    // Token: 0x4001834
    public int correctNum;

    // Token: 0x4001835
    private GameObject temp;

    // Token: 0x4001836
    private static IdentifyMatchController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60018C1
    // RVA   : 0xA18D90   Offset: 0xA17B90   Length: 0x36
    public static IdentifyMatchController get_Instance()
    {
        return **(uint64 **)(DAT_181e5f0f0 + 184);
    }

    // Token : 0x60018C2
    // RVA   : 0xA17D70   Offset: 0xA16B70   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181e5f0f0 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60018C3
    // RVA   : 0xA18520   Offset: 0xA17320   Length: 0x399
    public void ShowIdentifyMatchUI(float _difficulty, string _fightEndCallFuc)
    {
        var pStatics_2a90 = *(int64*)(DAT_181e52a90 + 184);
        void IdentifyMatchController.ShowIdentifyMatchUI
                     (int64 this,uint32 _difficulty,uint64 _fightEndCallFuc)
        {
        uint64 uVar1;
        int64 lVar2;
        char cVar3;
        int64 lVar4;
        uint64 uVar5;
        int64 *plVar6;
        int64 *plVar7;
        this.fightEndCallFuc = _fightEndCallFuc;
        this.difficulty = _difficulty;
        if (this.identifyMatchUIPanel == null) throw; // [null/range check failed]
        GameObject.SetActive(this.identifyMatchUIPanel,1,0);
        uVar5 = this.playerIcon;
        cVar3 = Object.op_Equality(uVar5,0,0);
        if (cVar3) {
          if (this.identifyMatchUIPanel == null) throw; // [null/range check failed]
          lVar4 = GameObject.get_transform(this.identifyMatchUIPanel,0);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar4 = Transform.Find(lVar4,"HeroIcon",0);
          if (lVar4 == null) throw; // [null/range check failed]
          uVar5 = Component.get_gameObject(lVar4,0);
          if (*pStatics_2a90 == 0) throw; // [null/range check failed]
          uVar1 = *(uint64 *)(*pStatics_2a90 + 144);
          uVar5 = GlobalData.AddChild(uVar5,uVar1,0);
          this.playerIcon = uVar5;
          if (this.playerIcon == null) throw; // [null/range check failed]
          lVar4 = GameObject.GetComponent(this.playerIcon,DAT_181e54c18);
          if ((GameController._instance == null) ||
             (lVar2 = GameController._instance.worldData) == null)
          throw; // [null/range check failed]
          uVar5 = WorldData.Player(lVar2,0);
          if (lVar4 == null) throw; // [null/range check failed]
          *(uint64 *)(lVar4 + 32) = uVar5;
          if (this.playerIcon == null) throw; // [null/range check failed]
          lVar4 = GameObject.GetComponent(this.playerIcon,DAT_181e54c18);
          if (lVar4 == null) throw; // [null/range check failed]
          *(uint32 *)(lVar4 + 24) = 0;
          if (this.playerIcon == null) throw; // [null/range check failed]
          lVar4 = GameObject.GetComponent(this.playerIcon,DAT_181e54c18);
          if (lVar4 == null) throw; // [null/range check failed]
          *(uint8 *)(lVar4 + 88) = 1;
        }
        if (this.identifyResult != null) {
          FUN_18115d8f0(this.identifyResult,DAT_181e62678);
          this.correctNum = 0;
          IdentifyMatchController.RefreshResult(this,0);
          this.identifyMatchState = 1;
          plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/紧张",0);
          plVar7 = (int64 *)0;
          if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181e8f4a0)) {
            plVar7 = plVar6;
          }
          NGUITools.PlaySound(plVar7,0x3f4ccccd,0);
          uVar5 = IdentifyMatchController.StartNewRound(this,0x3e4ccccd,0);
          FUN_180ae80b0(this,uVar5,0);
          return;
        }
    }

    // Token : 0x60018C4
    // RVA   : 0xA17DC0   Offset: 0xA16BC0   Length: 0x2D8
    public void HideIdentifyMatchUI()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        if ((GameController._instance != null) &&
           (lVar2 = GameController._instance.worldData) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if (lVar2 != null) {
            HeroData.ChangeLivingSkillExp
                      (lVar2,2,(this.difficulty * 0.5 + 1.0) * 100.0 *
                               (float)this.correctNum * 0.2,1,0);
            this.nowChooseTreasure = 0;
            if (this.selectedOutline != null) {
              GameObject.SetActive(this.selectedOutline,0,0);
              if (this.sureButton != null) {
                GameObject.SetActive(this.sureButton,0,0);
                if (this.identifyMatchUIPanel != null) {
                  GameObject.SetActive(this.identifyMatchUIPanel,0,0);
                  if (this.identifyMatchUIPanel != null) {
                    lVar2 = GameObject.get_transform(this.identifyMatchUIPanel,0);
                    if (lVar2 != null) {
                      lVar2 = Transform.Find(lVar2,"TreasureGrid",0);
                      if (lVar2 != null) {
                        uVar3 = Component.get_gameObject(lVar2,0);
                        GlobalData.DeleteAllChild(uVar3,0);
                        if (this.fightEndCallFuc != null) {
                          cVar1 = String.op_Inequality(this.fightEndCallFuc,"",0);
                          if (cVar1) {
                            uVar3 = this.fightEndCallFuc;
                            lVar2 = *(int64 *)(*(int64 *)(DAT_181e71f68 + 184) + 24);
                            uVar4 = Int32.ToString((int *)(this + 104),0);
                            if (lVar2 == null) throw; // [null/range check failed]
                            Component.SendMessage(lVar2,uVar3,uVar4,0);
                          }
                        }
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

    // Token : 0x60018C5
    // RVA   : 0xA188C0   Offset: 0xA176C0   Length: 0x7E
    public IEnumerator StartNewRound(float waitTime)
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 40) = this;
          *(uint32 *)(lVar1 + 32) = waitTime;
          return lVar1;
        }
    }

    // Token : 0x60018C6
    // RVA   : 0xA180A0   Offset: 0xA16EA0   Length: 0x365
    public void RefreshResult()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar6;
        int[] local_res18 = new int[4];
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        uint8 local_28 [16];
        uint8 local_18 [16];
        local_res18[0] = 0;
        do {
          if (this.identifyResult == null) goto LAB_180a18400;
          lVar2 = this.identifyMatchUIPanel;
          if (local_res18[0] < this.identifyResult.Count) {
            if (lVar2 == null) {
        LAB_180a18400:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar2 = GameObject.get_transform(lVar2,0);
            if (lVar2 == null) goto LAB_180a18400;
            lVar2 = Transform.Find(lVar2,"ResultGrid",0);
            uVar3 = Int32.ToString(local_res18,0);
            if (lVar2 == null) goto LAB_180a18400;
            lVar2 = Transform.Find(lVar2,uVar3,0);
            if (lVar2 == null) goto LAB_180a18400;
            lVar2 = Transform.Find(lVar2,"Text",0);
            if (lVar2 == null) goto LAB_180a18400;
            uVar3 = Component.GetComponent(lVar2,DAT_181e79538);
            if (this.identifyResult == null) goto LAB_180a18400;
            cVar1 = FUN_180060680(this.identifyResult,local_res18[0],DAT_181e62778);
            uVar6 = "误";
            if (cVar1) {
              uVar6 = "正";
            }
            LTLocalization.SetText(uVar3,uVar6,0);
            if (this.identifyMatchUIPanel == null) goto LAB_180a18400;
            lVar2 = GameObject.get_transform(this.identifyMatchUIPanel,0);
            if (lVar2 == null) goto LAB_180a18400;
            lVar2 = Transform.Find(lVar2,"ResultGrid",0);
            uVar3 = Int32.ToString(local_res18,0);
            if (lVar2 == null) goto LAB_180a18400;
            lVar2 = Transform.Find(lVar2,uVar3,0);
            if (lVar2 == null) goto LAB_180a18400;
            lVar2 = Transform.Find(lVar2,"Text",0);
            if (lVar2 == null) goto LAB_180a18400;
            plVar4 = (int64 *)Component.GetComponent(lVar2,DAT_181e79538);
            if (this.identifyResult == null) goto LAB_180a18400;
            cVar1 = FUN_180060680(this.identifyResult,local_res18[0],DAT_181e62778);
            if (!cVar1) {
              puVar5 = (uint32 *)Color.get_red(local_18,0);
            }
            else {
              puVar5 = (uint32 *)Color.get_green(local_28);
            }
            if (plVar4 == (int64 *)0) goto LAB_180a18400;
            local_38 = *puVar5;
            uStack_34 = puVar5[1];
            uStack_30 = puVar5[2];
            uStack_2c = puVar5[3];
            (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_38);
          }
          else {
            if (lVar2 == null) goto LAB_180a18400;
            lVar2 = GameObject.get_transform(lVar2,0);
            if (lVar2 == null) goto LAB_180a18400;
            lVar2 = Transform.Find(lVar2,"ResultGrid",0);
            uVar3 = Int32.ToString(local_res18,0);
            if (lVar2 == null) goto LAB_180a18400;
            lVar2 = Transform.Find(lVar2,uVar3,0);
            if (lVar2 == null) goto LAB_180a18400;
            lVar2 = Transform.Find(lVar2,"Text",0);
            if (lVar2 == null) goto LAB_180a18400;
            uVar3 = Component.GetComponent(lVar2,DAT_181e79538);
            LTLocalization.SetText(uVar3,"");
          }
          local_res18[0] = local_res18[0] + 1;
          if (4 < local_res18[0]) {
            return;
          }
        } while( true );
    }

    // Token : 0x60018C7
    // RVA   : 0xA18410   Offset: 0xA17210   Length: 0x101
    public void SetNowChooseTreasure(GameObject targetTreasure)
    {
        long lVar2;
        long lVar3;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        if (this.identifyMatchState != 2) {
          return;
        }
        this.nowChooseTreasure = targetTreasure;
        if ((this.sureButton != null) &&
           (lVar2 = GameObject.GetComponent(this.sureButton,DAT_181e53cb0)) != null) {
          Selectable.set_interactable(lVar2,1,0);
          if (this.selectedOutline != null) {
            GameObject.SetActive(this.selectedOutline,1,0);
            if (this.selectedOutline != null) {
              lVar2 = GameObject.get_transform(this.selectedOutline,0);
              if (((*plVar1 != 0) && (lVar3 = GameObject.get_transform(*plVar1,0)) != null) &&
                 (puVar4 = (uint64 *)Transform.get_position(local_18,lVar3,0), lVar2 != null)) {
                local_28 = *puVar4;
                local_20 = *(uint32 *)(puVar4 + 1);
                Transform.set_position(lVar2,&local_28,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60018C8
    // RVA   : 0xA18940   Offset: 0xA17740   Length: 0x417
    public void SureButtonClicked()
    {
        float fVar1;
        bool cVar2;
        long lVar3;
        ulong uVar5;
        int[] local_res8 = new int[2];
        ulong local_48;
        ulong local_38;
        float local_30;
        byte[] local_18 = new byte[16];
        fVar1 = local_30;
        if (this.sureButton != null) {
          lVar3 = GameObject.GetComponent(this.sureButton,DAT_181e53cb0);
          fVar1 = local_30;
          if (lVar3 != null) {
            Selectable.set_interactable(lVar3,0,0);
            fVar1 = local_30;
            if (this.sureButton != null) {
              GameObject.SetActive(this.sureButton,0,0);
              this.identifyMatchState = 1;
              fVar1 = local_30;
              if (this.correctTreasure != null) {
                cVar2 = FUN_18175e190(this.correctTreasure,this.nowChooseTreasure,
                                      DAT_181e6b7f8);
                lVar3 = this.identifyResult;
                fVar1 = local_30;
                if (!cVar2) {
                  if (lVar3 == null) goto LAB_180a18d52;
                  FUN_181660e60(lVar3,0,DAT_181e625f8);
                  plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/Fail",0);
                  plVar7 = (int64 *)0;
                  if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181e8f4a0)) {
                    plVar7 = plVar4;
                  }
                  NGUITools.PlaySound(plVar7,0);
                }
                else {
                  if (lVar3 == null) goto LAB_180a18d52;
                  FUN_181660e60(lVar3,1,DAT_181e625f8);
                  this.correctNum = this.correctNum + 1;
                  plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/Success",0);
                  plVar8 = (int64 *)0;
                  plVar7 = plVar8;
                  if ((plVar4 != (int64 *)0) && (plVar7 = (int64 *)0, *plVar4 == DAT_181e8f4a0))
                  {
                    plVar7 = plVar4;
                  }
                  NGUITools.PlaySound(plVar7,0);
                  plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/人群欢呼",0);
                  if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181e8f4a0)) {
                    plVar8 = plVar4;
                  }
                  NGUITools.PlaySound(plVar8,0x3e99999a,0);
                }
                IdentifyMatchController.RefreshResult(this,0);
                fVar1 = local_30;
                if (this.identifyMatchUIPanel != null) {
                  lVar3 = GameObject.get_transform(this.identifyMatchUIPanel,0);
                  fVar1 = local_30;
                  if (lVar3 != null) {
                    lVar3 = Transform.Find(lVar3,"ResultGrid",0);
                    fVar1 = local_30;
                    if (this.identifyResult != null) {
                      local_res8[0] = this.identifyResult.Count + -1;
                      uVar5 = Int32.ToString(local_res8,0);
                      fVar1 = local_30;
                      if (lVar3 != null) {
                        lVar3 = Transform.Find(lVar3,uVar5,0);
                        fVar1 = local_30;
                        if (lVar3 != null) {
                          lVar3 = Transform.Find(lVar3,"Text",0);
                          puVar6 = (uint64 *)Vector3.get_one(local_18,0);
                          local_38 = *puVar6;
                          local_30 = *(float *)(puVar6 + 1) * 30.0;
                          local_48 = CONCAT44((float)((uint64)local_38 >> 32) * 30.0,
                                              (float)local_38 * 30.0);
                          fVar1 = *(float *)(puVar6 + 1);
                          if (lVar3 != null) {
                            local_38 = local_48;
                            Transform.set_localScale(lVar3,&local_38,0);
                            fVar1 = local_30;
                            if (this.identifyMatchUIPanel != null) {
                              lVar3 = GameObject.get_transform(this.identifyMatchUIPanel,0);
                              fVar1 = local_30;
                              if (lVar3 != null) {
                                lVar3 = Transform.Find(lVar3,"ResultGrid",0);
                                fVar1 = local_30;
                                if (this.identifyResult != null) {
                                  local_res8[0] = this.identifyResult.Count + -1;
                                  uVar5 = Int32.ToString(local_res8,0);
                                  fVar1 = local_30;
                                  if (lVar3 != null) {
                                    lVar3 = Transform.Find(lVar3,uVar5,0);
                                    fVar1 = local_30;
                                    if (lVar3 != null) {
                                      uVar5 = Transform.Find(lVar3,"Text",0);
                                      ShortcutExtensions.DOScale(uVar5,0x3f800000,0x3e99999a,0);
                                      uVar5 = IdentifyMatchController.StartNewRound(this,0x3f800000,0)
                                      ;
                                      FUN_180ae80b0(this,uVar5,0);
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
        LAB_180a18d52:
        local_30 = fVar1;
    }

    // Token : 0x60018C9
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

    // Token : 0x60018CA
    // RVA   : 0xA18D60   Offset: 0xA17B60   Length: 0x27
    private void <StartNewRound>b__18_0()
    {
        this.identifyMatchState = 2;
        if (this.sureButton != null) {
          GameObject.SetActive(this.sureButton,1,0);
          return;
        }
    }

}
