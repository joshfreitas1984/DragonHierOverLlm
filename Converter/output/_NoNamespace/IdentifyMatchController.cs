// ============================================================
// Type  : IdentifyMatchController
// Token : 0x20002DE
// ============================================================

public class IdentifyMatchController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001721
    public IdentifyMatchState identifyMatchState;

    // Token: 0x4001722
    public GameObject identifyMatchUIPanel;

    // Token: 0x4001723
    public GameObject selectedOutline;

    // Token: 0x4001724
    public GameObject sureButton;

    // Token: 0x4001725
    public GameObject playerIcon;

    // Token: 0x4001726
    public GameObject nowChooseTreasure;

    // Token: 0x4001727
    public List<GameObject> correctTreasure;

    // Token: 0x4001728
    public float difficulty;

    // Token: 0x4001729
    public string fightEndCallFuc;

    // Token: 0x400172A
    public List<bool> identifyResult;

    // Token: 0x400172B
    public int correctNum;

    // Token: 0x400172C
    private GameObject temp;

    // Token: 0x400172D
    private static IdentifyMatchController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001801
    // RVA   : 0xB6CD40   Offset: 0xB6B540   Length: 0x36
    public static IdentifyMatchController get_Instance()
    {
        return **(uint64 **)(DAT_181d59c78 + 184);
    }

    // Token : 0x6001802
    // RVA   : 0xB6BDD0   Offset: 0xB6A5D0   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181d59c78 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6001803
    // RVA   : 0xB6C4D0   Offset: 0xB6ACD0   Length: 0x399
    public void ShowIdentifyMatchUI(float _difficulty, string _fightEndCallFuc)
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_e188 = *(int64*)(DAT_181d4e188 + 184);
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
          if (*pStatics_e188 == 0) throw; // [null/range check failed]
          uVar1 = *(uint64 *)(*pStatics_e188 + 144);
          uVar5 = GlobalData.AddChild(uVar5,uVar1,0);
          this.playerIcon = uVar5;
          if (this.playerIcon == null) throw; // [null/range check failed]
          lVar4 = GameObject.GetComponent(this.playerIcon,DAT_181d9fb20);
          if ((*pStatics_df90 == 0) ||
             (lVar2 = *(int64 *)(*pStatics_df90 + 32)) == null)
          throw; // [null/range check failed]
          uVar5 = WorldData.Player(lVar2,0);
          if (lVar4 == null) throw; // [null/range check failed]
          *(uint64 *)(lVar4 + 32) = uVar5;
          if (this.playerIcon == null) throw; // [null/range check failed]
          lVar4 = GameObject.GetComponent(this.playerIcon,DAT_181d9fb20);
          if (lVar4 == null) throw; // [null/range check failed]
          *(uint32 *)(lVar4 + 24) = 0;
          if (this.playerIcon == null) throw; // [null/range check failed]
          lVar4 = GameObject.GetComponent(this.playerIcon,DAT_181d9fb20);
          if (lVar4 == null) throw; // [null/range check failed]
          *(uint8 *)(lVar4 + 88) = 1;
        }
        if (this.identifyResult != null) {
          FUN_180f56130(this.identifyResult,DAT_181d58e10);
          this.correctNum = 0;
          IdentifyMatchController.RefreshResult(this,0);
          this.identifyMatchState = 1;
          plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/紧张",0);
          plVar7 = (int64 *)0;
          if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181d8a228)) {
            plVar7 = plVar6;
          }
          NGUITools.PlaySound(plVar7,0x3f4ccccd,0);
          uVar5 = IdentifyMatchController.StartNewRound(this,0x3e4ccccd,0);
          FUN_180d837c0(this,uVar5,0);
          return;
        }
    }

    // Token : 0x6001804
    // RVA   : 0xB6BE20   Offset: 0xB6A620   Length: 0x281
    public void HideIdentifyMatchUI()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        if ((*pStatics != 0) &&
           (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
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
                            lVar2 = FUN_18046c440(0);
                            uVar3 = this.fightEndCallFuc;
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

    // Token : 0x6001805
    // RVA   : 0xB6C870   Offset: 0xB6B070   Length: 0x7E
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

    // Token : 0x6001806
    // RVA   : 0xB6C0B0   Offset: 0xB6A8B0   Length: 0x30A
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
          if (this.identifyResult == null) goto LAB_180b6c3b5;
          lVar2 = this.identifyMatchUIPanel;
          if (local_res18[0] < this.identifyResult.Count) {
            if (lVar2 == null) {
        LAB_180b6c3b5:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar2 = GameObject.get_transform(lVar2,0);
            if (lVar2 == null) goto LAB_180b6c3b5;
            lVar2 = Transform.Find(lVar2,"ResultGrid",0);
            uVar3 = Int32.ToString(local_res18,0);
            if (lVar2 == null) goto LAB_180b6c3b5;
            lVar2 = Transform.Find(lVar2,uVar3,0);
            if (lVar2 == null) goto LAB_180b6c3b5;
            lVar2 = Transform.Find(lVar2,"Text",0);
            if (lVar2 == null) goto LAB_180b6c3b5;
            uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
            if (this.identifyResult == null) goto LAB_180b6c3b5;
            cVar1 = FUN_180132d10(this.identifyResult,local_res18[0],DAT_181d58f10);
            uVar6 = "误";
            if (cVar1) {
              uVar6 = "正";
            }
            LTLocalization.SetText(uVar3,uVar6,0);
            if (this.identifyMatchUIPanel == null) goto LAB_180b6c3b5;
            lVar2 = GameObject.get_transform(this.identifyMatchUIPanel,0);
            if (lVar2 == null) goto LAB_180b6c3b5;
            lVar2 = Transform.Find(lVar2,"ResultGrid",0);
            uVar3 = Int32.ToString(local_res18,0);
            if (lVar2 == null) goto LAB_180b6c3b5;
            lVar2 = Transform.Find(lVar2,uVar3,0);
            if (lVar2 == null) goto LAB_180b6c3b5;
            lVar2 = Transform.Find(lVar2,"Text",0);
            if (lVar2 == null) goto LAB_180b6c3b5;
            plVar4 = (int64 *)Component.GetComponent(lVar2,DAT_181d6d8c0);
            if (this.identifyResult == null) goto LAB_180b6c3b5;
            cVar1 = FUN_180132d10(this.identifyResult,local_res18[0],DAT_181d58f10);
            if (!cVar1) {
              puVar5 = (uint32 *)Color.get_red(local_18,0);
            }
            else {
              puVar5 = (uint32 *)Color.get_green(local_28);
            }
            if (plVar4 == (int64 *)0) goto LAB_180b6c3b5;
            local_38 = *puVar5;
            uStack_34 = puVar5[1];
            uStack_30 = puVar5[2];
            uStack_2c = puVar5[3];
            (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_38);
          }
          else {
            if (lVar2 == null) goto LAB_180b6c3b5;
            lVar2 = GameObject.get_transform(lVar2,0);
            if (lVar2 == null) goto LAB_180b6c3b5;
            lVar2 = Transform.Find(lVar2,"ResultGrid",0);
            uVar3 = Int32.ToString(local_res18,0);
            if (lVar2 == null) goto LAB_180b6c3b5;
            lVar2 = Transform.Find(lVar2,uVar3,0);
            if (lVar2 == null) goto LAB_180b6c3b5;
            lVar2 = Transform.Find(lVar2,"Text",0);
            if (lVar2 == null) goto LAB_180b6c3b5;
            uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
            LTLocalization.SetText(uVar3,"");
          }
          local_res18[0] = local_res18[0] + 1;
          if (4 < local_res18[0]) {
            return;
          }
        } while( true );
    }

    // Token : 0x6001807
    // RVA   : 0xB6C3C0   Offset: 0xB6ABC0   Length: 0x101
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
           (lVar2 = GameObject.GetComponent(this.sureButton,DAT_181d9ee60)) != null) {
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

    // Token : 0x6001808
    // RVA   : 0xB6C8F0   Offset: 0xB6B0F0   Length: 0x417
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
          lVar3 = GameObject.GetComponent(this.sureButton,DAT_181d9ee60);
          fVar1 = local_30;
          if (lVar3 != null) {
            Selectable.set_interactable(lVar3,0,0);
            fVar1 = local_30;
            if (this.sureButton != null) {
              GameObject.SetActive(this.sureButton,0,0);
              this.identifyMatchState = 1;
              fVar1 = local_30;
              if (this.correctTreasure != null) {
                cVar2 = FUN_1818279a0(this.correctTreasure,this.nowChooseTreasure,
                                      DAT_181d61cf8);
                lVar3 = this.identifyResult;
                fVar1 = local_30;
                if (!cVar2) {
                  if (lVar3 == null) goto LAB_180b6cd02;
                  FUN_181805880(lVar3,0,DAT_181d58d90);
                  plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/Fail",0);
                  plVar7 = (int64 *)0;
                  if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
                    plVar7 = plVar4;
                  }
                  NGUITools.PlaySound(plVar7,0);
                }
                else {
                  if (lVar3 == null) goto LAB_180b6cd02;
                  FUN_181805880(lVar3,1,DAT_181d58d90);
                  this.correctNum = this.correctNum + 1;
                  plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/Success",0);
                  plVar8 = (int64 *)0;
                  plVar7 = plVar8;
                  if ((plVar4 != (int64 *)0) && (plVar7 = (int64 *)0, *plVar4 == DAT_181d8a228))
                  {
                    plVar7 = plVar4;
                  }
                  NGUITools.PlaySound(plVar7,0);
                  plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/人群欢呼",0);
                  if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
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
                                      FUN_180d837c0(this,uVar5,0);
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
        LAB_180b6cd02:
        local_30 = fVar1;
    }

    // Token : 0x6001809
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x600180A
    // RVA   : 0xB6CD10   Offset: 0xB6B510   Length: 0x27
    private void <StartNewRound>b__18_0()
    {
        this.identifyMatchState = 2;
        if (this.sureButton != null) {
          GameObject.SetActive(this.sureButton,1,0);
          return;
        }
    }

}
