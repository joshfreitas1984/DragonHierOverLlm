// ============================================================
// Type  : BreakThroughController
// Token : 0x20001A2
// ============================================================

public class BreakThroughController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000B05
    public KungfuSkillLvData targetSkill;

    // Token: 0x4000B06
    public GameObject breakThroughPanel;

    // Token: 0x4000B07
    public GameObject breakThroughChoiceIconPrefab;

    // Token: 0x4000B08
    public GameObject targetSkillSlot;

    // Token: 0x4000B09
    public int breakThroughType;

    // Token: 0x4000B0A
    public bool useMoney;

    // Token: 0x4000B0B
    public float baseScore;

    // Token: 0x4000B0C
    public float medScore;

    // Token: 0x4000B0D
    public float foodScore;

    // Token: 0x4000B0E
    public float bookScore;

    // Token: 0x4000B0F
    public float baseScoreRate;

    // Token: 0x4000B10
    public GameObject medIcon;

    // Token: 0x4000B11
    public GameObject medCancel;

    // Token: 0x4000B12
    private ItemData medData;

    // Token: 0x4000B13
    public GameObject foodIcon;

    // Token: 0x4000B14
    public GameObject foodCancel;

    // Token: 0x4000B15
    private ItemData foodData;

    // Token: 0x4000B16
    public GameObject bookIcon;

    // Token: 0x4000B17
    public GameObject bookCancel;

    // Token: 0x4000B18
    private ItemData bookData;

    // Token: 0x4000B19
    public GameObject breakThroughPos;

    // Token: 0x4000B1A
    public static Dictionary<int, List<int>> BreakThroughChoiceListDictionary;

    // Token: 0x4000B1B
    private GameObject newObj;

    // Token: 0x4000B1C
    private static BreakThroughController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000D63
    // RVA   : 0xCEF650   Offset: 0xCEDE50   Length: 0x58
    public static BreakThroughController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d8e338 + 184) + 8);
    }

    // Token : 0x6000D64
    // RVA   : 0xCE9D30   Offset: 0xCE8530   Length: 0x68
    private void Awake()
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d8e338 + 184) + 8);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6000D65
    // RVA   : 0xCEF2C0   Offset: 0xCEDAC0   Length: 0x30F
    public void UnshowBreakThroughPanel()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        int[] local_res8 = new int[2];
        if ((((this.breakThroughPos != null) &&
             (lVar2 = GameObject.get_transform(this.breakThroughPos,0)) != null) &&
            (lVar2 = Transform.Find(lVar2,"Background",0)) != null) &&
           (lVar2 = Component.get_gameObject(lVar2,0)) != null) {
          cVar1 = GameObject.get_activeSelf(lVar2,0);
          if (cVar1) {
            return;
          }
          this.medData = 0;
          uVar3 = this.medIcon;
          GlobalData.DeleteAllChild(uVar3,0);
          this.medScore = 0;
          BreakThroughController.RefreshExtraRateInfo(this,0);
          if (this.medCancel != null) {
            GameObject.SetActive(this.medCancel,0,0);
            this.foodData = 0;
            uVar3 = this.foodIcon;
            GlobalData.DeleteAllChild(uVar3,0);
            this.foodScore = 0;
            BreakThroughController.RefreshExtraRateInfo(this,0);
            if (this.foodCancel != null) {
              GameObject.SetActive(this.foodCancel,0,0);
              this.bookData = 0;
              uVar3 = this.bookIcon;
              GlobalData.DeleteAllChild(uVar3,0);
              this.bookScore = 0;
              BreakThroughController.RefreshExtraRateInfo(this,0);
              if (this.bookCancel != null) {
                GameObject.SetActive(this.bookCancel,0,0);
                uVar3 = this.targetSkillSlot;
                GlobalData.DeleteAllChild(uVar3,0);
                local_res8[0] = 0;
                do {
                  if (this.breakThroughPos == null) throw; // [null/range check failed]
                  lVar2 = GameObject.get_transform(this.breakThroughPos,0);
                  uVar3 = Int32.ToString(local_res8,0);
                  if ((lVar2 == null) || (lVar2 = Transform.Find(lVar2,uVar3,0)) == null)
                  throw; // [null/range check failed]
                  uVar3 = Component.get_gameObject(lVar2);
                  GlobalData.DeleteAllChild(uVar3);
                  local_res8[0] = local_res8[0] + 1;
                } while (local_res8[0] < 4);
                this.targetSkill = 0;
                if (this.breakThroughPanel != null) {
                  GameObject.SetActive(this.breakThroughPanel,0,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000D66
    // RVA   : 0xCED850   Offset: 0xCEC050   Length: 0x831
    public void StartBreakThrough(KungfuSkillLvData _targetSkill, bool _useMoney)
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_e188 = *(int64*)(DAT_181d4e188 + 184);
        var pStatics_ee60 = *(int64*)(DAT_181d8ee60 + 184);
        void BreakThroughController.StartBreakThrough
                     (int64 this,uint64 _targetSkill,uint8 _useMoney)
        {
        float fVar1;
        float fVar2;
        uint32 uVar3;
        int64 *plVar4;
        int64 lVar5;
        uint64 uVar6;
        uint64 *puVar7;
        uint64 uVar8;
        int64 *plVar9;
        float fVar10;
        float local_res18 [4];
        uint64 local_78;
        uint64 local_68;
        float local_60;
        uint64 local_48;
        uint64 uStack_40;
        plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/Armor",0);
        plVar9 = (int64 *)0;
        if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
          plVar9 = plVar4;
        }
        NGUITools.PlaySound(plVar9,0);
        this.targetSkill = _targetSkill;
        this.useMoney = _useMoney;
        lVar5 = *(int64 *)(pStatics_ee60 + 8);
        fVar2 = local_60;
        if (lVar5 != null) {
          if (*(int64 *)(lVar5 + 24) == 0) {
            fVar10 = 0.0;
          }
          else {
            lVar5 = *(int64 *)(pStatics_ee60 + 8);
            fVar2 = local_60;
            if ((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 24)) == null) goto LAB_180cee07c;
            fVar10 = (float)*(int *)(lVar5 + 20) * 0.05;
          }
          fVar2 = local_60;
          if ((*pStatics_df90 != 0) &&
             (lVar5 = *(int64 *)(*pStatics_df90 + 32)) != null) {
            lVar5 = WorldData.Player(lVar5,0);
            fVar2 = local_60;
            if (lVar5 != null) {
              lVar5 = *(int64 *)(lVar5 + 0x150);
              if (this.targetSkill != null) {
                uVar3 = KungfuSkillLvData.Type(this.targetSkill,0);
                fVar2 = local_60;
                if (lVar5 != null) {
                  if (*(uint32 *)(lVar5 + 24) <= uVar3) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  fVar1 = lVar5[uVar3];
                  fVar2 = local_60;
                  if (this.targetSkill != null) {
                    lVar5 = KungfuSkillLvData.DataBase(this.targetSkill,0);
                    fVar2 = local_60;
                    if (lVar5 != null) {
                      this.baseScoreRate =
                           (fVar1 - (float)*(int *)(lVar5 + 52) * 20.0) * 0.01 + fVar10 + 1.0;
                      if (this.breakThroughPanel != null) {
                        GameObject.SetActive(this.breakThroughPanel,1,0);
                        BreakThroughController.RefreshExtraRateInfo(this,0);
                        uVar6 = this.targetSkillSlot;
                        fVar2 = local_60;
                        if (*pStatics_e188 != 0) {
                          uVar8 = *(uint64 *)(*pStatics_e188 + 168);
                          uVar6 = GlobalData.AddChild(uVar6,uVar8,0);
                          this.newObj = uVar6;
                          fVar2 = local_60;
                          if (this.newObj != null) {
                            lVar5 = GameObject.GetComponent(this.newObj,DAT_181da1630);
                            fVar2 = local_60;
                            if (lVar5 != null) {
                              *(uint64 *)(lVar5 + 32) = this.targetSkill;
                              fVar2 = local_60;
                              if (this.newObj != null) {
                                lVar5 = GameObject.GetComponent
                                                  (this.newObj,DAT_181da1630);
                                fVar2 = local_60;
                                if (lVar5 != null) {
                                  *(uint32 *)(lVar5 + 40) = 2;
                                  if (this.newObj != null) {
                                    lVar5 = GameObject.get_transform(this.newObj,0);
                                    puVar7 = (uint64 *)Vector3.get_one(&local_48,0);
                                    local_68 = *puVar7;
                                    local_60 = *(float *)(puVar7 + 1) * 1.2;
                                    local_78 = CONCAT44((float)((uint64)local_68 >> 32) * 1.2,
                                                        (float)local_68 * 1.2);
                                    fVar2 = *(float *)(puVar7 + 1);
                                    if (lVar5 != null) {
                                      local_68 = local_78;
                                      Transform.set_localScale(lVar5,&local_68,0);
                                      fVar2 = local_60;
                                      if (this.breakThroughPanel != null) {
                                        lVar5 = GameObject.get_transform(this.breakThroughPanel,0)
                                        ;
                                        fVar2 = local_60;
                                        if (lVar5 != null) {
                                          lVar5 = Transform.Find(lVar5,"StartButton",0);
                                          fVar2 = local_60;
                                          if (lVar5 != null) {
                                            lVar5 = Component.get_gameObject(lVar5,0);
                                            fVar2 = local_60;
                                            if (lVar5 != null) {
                                              GameObject.SetActive(lVar5,1,0);
                                              fVar2 = local_60;
                                              if (this.breakThroughPanel != null) {
                                                lVar5 = GameObject.get_transform
                                                                  (this.breakThroughPanel,0);
                                                fVar2 = local_60;
                                                if (lVar5 != null) {
                                                  lVar5 = Transform.Find(lVar5,"StartButton",0);
                                                  fVar2 = local_60;
                                                  if (lVar5 != null) {
                                                    lVar5 = Component.GetComponent(lVar5,DAT_181d6af40);
                                                    fVar2 = local_60;
                                                    if (lVar5 != null) {
                                                      Selectable.set_interactable(lVar5,0,0);
                                                      fVar2 = local_60;
                                                      if (this.breakThroughPanel != null) {
                                                        lVar5 = GameObject.get_transform
                                                                          (this.breakThroughPanel,0
                                                                          );
                                                        fVar2 = local_60;
                                                        if (lVar5 != null) {
                                                          lVar5 = Transform.Find(lVar5,"BlackBackground",0);
                                                          fVar2 = local_60;
                                                          if (lVar5 != null) {
                                                            lVar5 = Component.GetComponent
                                                                              (lVar5,DAT_181d6af40);
                                                            fVar2 = local_60;
                                                            if (lVar5 != null) {
                                                              Selectable.set_interactable(lVar5,1,0);
                                                              fVar2 = local_60;
                                                              if (this.breakThroughPanel != null) {
                                                                lVar5 = GameObject.get_transform
                                                                                  (*(int64 *)
                                                                                    (this + 32),0);
                                                                fVar2 = local_60;
                                                                if (lVar5 != null) {
                                                                  lVar5 = Transform.Find(lVar5,
                                                        "RateInfo",0);
                                                        fVar2 = local_60;
                                                        if (lVar5 != null) {
                                                          lVar5 = Component.get_gameObject(lVar5,0);
                                                          fVar2 = local_60;
                                                          if (lVar5 != null) {
                                                            GameObject.SetActive(lVar5,1,0);
                                                            fVar2 = local_60;
                                                            if (this.breakThroughPanel != null) {
                                                              lVar5 = GameObject.get_transform
                                                                                (*(int64 *)
                                                                                  (this + 32),0);
                                                              fVar2 = local_60;
                                                              if (lVar5 != null) {
                                                                lVar5 = Transform.Find(lVar5,
                                                        "RateInfo",0);
                                                        fVar2 = local_60;
                                                        if (lVar5 != null) {
                                                          lVar5 = Transform.Find(lVar5,"MinScore",0);
                                                          fVar2 = local_60;
                                                          if (lVar5 != null) {
                                                            uVar6 = Component.GetComponent
                                                                              (lVar5,DAT_181d6d8c0);
                                                            fVar2 = local_60;
                                                            if (this.targetSkill != null) {
                                                              lVar5 = KungfuSkillLvData.DataBase
                                                                                (*(int64 *)
                                                                                  (this + 24),0);
                                                              fVar2 = local_60;
                                                              if (lVar5 != null) {
                                                                local_res18[0] = (float)FUN_1801f7f00();
                                                                local_res18[0] = local_res18[0] * 50.0;
                                                                uVar8 = Single.ToString(local_res18,0);
                                                                uVar8 = String.Concat("最低要求 ",uVar8
                                                                                       ,0);
                                                                LTLocalization.SetText(uVar6,uVar8,0);
                                                                fVar2 = local_60;
                                                                if (this.breakThroughPanel != null) {
                                                                  lVar5 = GameObject.get_transform
                                                                                    (*(int64 *)
                                                                                      (this + 32),0);
                                                                  fVar2 = local_60;
                                                                  if (lVar5 != null) {
                                                                    lVar5 = Transform.Find(lVar5,
                                                        "RateInfo",0);
                                                        fVar2 = local_60;
                                                        if (lVar5 != null) {
                                                          lVar5 = Transform.Find(lVar5,"MinScore",0);
                                                          fVar2 = local_60;
                                                          if (lVar5 != null) {
                                                            plVar4 = (int64 *)
                                                                     Component.GetComponent
                                                                               (lVar5,DAT_181d6d8c0);
                                                            puVar7 = (uint64 *)
                                                                     Color.get_red(&local_48,0);
                                                            fVar2 = local_60;
                                                            if (plVar4 != (int64 *)0) {
                                                              local_48 = *puVar7;
                                                              uStack_40 = puVar7[1];
                                                              (**(code **)(*plVar4 + 0x2a8))
                                                                        (plVar4,&local_48,
                                                                         *(uint64 *)(*plVar4 + 0x2b0))
                                                              ;
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
        LAB_180cee07c:
        local_60 = fVar2;
    }

    // Token : 0x6000D67
    // RVA   : 0xCEA6C0   Offset: 0xCE8EC0   Length: 0x17F
    public void BreakMedChoose()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[4];
        if (this.medData != null) {
          return;
        }
        lVar1 = **(int64 **)(DAT_181d92370 + 184);
        lVar2 = il2cpp_internal(DAT_181d701b0);
        FUN_180f58a90(lVar2,DAT_181d6dfe8);
        local_res8[0] = 0;
        uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
        if (lVar2 != null) {
          FUN_181827900(lVar2,uVar3,DAT_181d6e0e8);
          local_res18[0] = 1;
          uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
          FUN_181827900(lVar2,uVar3,DAT_181d6e0e8);
          uVar3 = Component.get_gameObject(this,0);
          if (lVar1 != null) {
            ChooseController.ShowChoosePanel(lVar1,1,lVar2,uVar3,"BreakMedChoosen",0,25,0,0,0);
            return;
          }
        }
    }

    // Token : 0x6000D68
    // RVA   : 0xCEA840   Offset: 0xCE9040   Length: 0x1E6
    public void BreakMedChoosen()
    {
        var pStatics_2370 = *(int64*)(DAT_181d92370 + 184);
        var pStatics_e188 = *(int64*)(DAT_181d4e188 + 184);
        ulong uVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        if ((*pStatics_2370 != 0) &&
           (lVar2 = *(int64 *)(*pStatics_2370 + 72)) != null) {
          lVar2 = GameObject.GetComponent(lVar2,DAT_181da0070);
          if (lVar2 != null) {
            lVar2 = *(int64 *)(lVar2 + 32);
            this.medData = lVar2;
            uVar3 = this.medIcon;
            if (*pStatics_e188 != 0) {
              uVar1 = *(uint64 *)(*pStatics_e188 + 160);
              uVar3 = GlobalData.AddChild(uVar3,uVar1,0);
              this.newObj = uVar3;
              if (this.newObj != null) {
                lVar4 = GameObject.GetComponent(this.newObj,DAT_181da0070);
                if (lVar4 != null) {
                  *(int64 *)(lVar4 + 32) = lVar2;
                  if (this.newObj != null) {
                    lVar4 = GameObject.GetComponent(this.newObj,DAT_181da0070);
                    if ((lVar4 != null) && (*(uint32 *)(lVar4 + 40) = 1, lVar2 != null)) {
                      this.medScore = (float)*(int *)(lVar2 + 56);
                      BreakThroughController.RefreshExtraRateInfo(this,0);
                      if (this.medCancel != null) {
                        GameObject.SetActive(this.medCancel,1,0);
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

    // Token : 0x6000D69
    // RVA   : 0xCED330   Offset: 0xCEBB30   Length: 0x170
    public void SetBreakMed(ItemData targetMed)
    {
        var pStatics = *(int64*)(DAT_181d4e188 + 184);
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        this.medData = targetMed;
        uVar2 = this.medIcon;
        if (*pStatics != 0) {
          uVar1 = *(uint64 *)(*pStatics + 160);
          uVar2 = GlobalData.AddChild(uVar2,uVar1,0);
          this.newObj = uVar2;
          if (this.newObj != null) {
            lVar3 = GameObject.GetComponent(this.newObj,DAT_181da0070);
            if (lVar3 != null) {
              *(int64 *)(lVar3 + 32) = targetMed;
              if (this.newObj != null) {
                lVar3 = GameObject.GetComponent(this.newObj,DAT_181da0070);
                if ((lVar3 != null) && (*(uint32 *)(lVar3 + 40) = 1, targetMed != null)) {
                  this.medScore = (float)*(int *)(targetMed + 56);
                  BreakThroughController.RefreshExtraRateInfo(this,0);
                  if (this.medCancel != null) {
                    GameObject.SetActive(this.medCancel,1,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000D6A
    // RVA   : 0xCEA620   Offset: 0xCE8E20   Length: 0x9A
    public void BreakMedCancel()
    {
        ulong uVar1;
        this.medData = 0;
        uVar1 = this.medIcon;
        GlobalData.DeleteAllChild(uVar1,0);
        this.medScore = 0;
        BreakThroughController.RefreshExtraRateInfo(this,0);
        if (this.medCancel != null) {
          GameObject.SetActive(this.medCancel,0,0);
          return;
        }
    }

    // Token : 0x6000D6B
    // RVA   : 0xCEA290   Offset: 0xCE8A90   Length: 0x182
    public void BreakFoodChoose()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[4];
        if (this.foodData != null) {
          return;
        }
        lVar1 = **(int64 **)(DAT_181d92370 + 184);
        lVar2 = il2cpp_internal(DAT_181d701b0);
        FUN_180f58a90(lVar2,DAT_181d6dfe8);
        local_res8[0] = 0;
        uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
        if (lVar2 != null) {
          FUN_181827900(lVar2,uVar3,DAT_181d6e0e8);
          local_res18[0] = 2;
          uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
          FUN_181827900(lVar2,uVar3,DAT_181d6e0e8);
          uVar3 = Component.get_gameObject(this,0);
          if (lVar1 != null) {
            ChooseController.ShowChoosePanel(lVar1,1,lVar2,uVar3,"BreakFoodChoosen",0,25,0,0,0);
            return;
          }
        }
    }

    // Token : 0x6000D6C
    // RVA   : 0xCEA420   Offset: 0xCE8C20   Length: 0x1F8
    public void BreakFoodChoosen()
    {
        var pStatics_2370 = *(int64*)(DAT_181d92370 + 184);
        var pStatics_e188 = *(int64*)(DAT_181d4e188 + 184);
        ulong uVar1;
        long lVar2;
        ulong uVar3;
        if ((*pStatics_2370 != 0) &&
           (lVar2 = *(int64 *)(*pStatics_2370 + 72)) != null) {
          lVar2 = GameObject.GetComponent(lVar2,DAT_181da0070);
          if (lVar2 != null) {
            uVar3 = *(uint64 *)(lVar2 + 32);
            this.foodData = uVar3;
            uVar3 = this.foodIcon;
            if (*pStatics_e188 != 0) {
              uVar1 = *(uint64 *)(*pStatics_e188 + 160);
              uVar3 = GlobalData.AddChild(uVar3,uVar1,0);
              this.newObj = uVar3;
              if (this.newObj != null) {
                lVar2 = GameObject.GetComponent(this.newObj,DAT_181da0070);
                if (lVar2 != null) {
                  *(uint64 *)(lVar2 + 32) = this.foodData;
                  if (this.newObj != null) {
                    lVar2 = GameObject.GetComponent(this.newObj,DAT_181da0070);
                    if (lVar2 != null) {
                      *(uint32 *)(lVar2 + 40) = 1;
                      if (this.foodData != null) {
                        this.foodScore = (float)this.foodData.value
                        ;
                        BreakThroughController.RefreshExtraRateInfo(this,0);
                        if (this.foodCancel != null) {
                          GameObject.SetActive(this.foodCancel,1,0);
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

    // Token : 0x6000D6D
    // RVA   : 0xCED1A0   Offset: 0xCEB9A0   Length: 0x182
    public void SetBreakFood(ItemData targetFood)
    {
        var pStatics = *(int64*)(DAT_181d4e188 + 184);
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        this.foodData = targetFood;
        uVar2 = this.foodIcon;
        if (*pStatics != 0) {
          uVar1 = *(uint64 *)(*pStatics + 160);
          uVar2 = GlobalData.AddChild(uVar2,uVar1,0);
          this.newObj = uVar2;
          if (this.newObj != null) {
            lVar3 = GameObject.GetComponent(this.newObj,DAT_181da0070);
            if (lVar3 != null) {
              *(uint64 *)(lVar3 + 32) = this.foodData;
              if (this.newObj != null) {
                lVar3 = GameObject.GetComponent(this.newObj,DAT_181da0070);
                if (lVar3 != null) {
                  *(uint32 *)(lVar3 + 40) = 1;
                  if (this.foodData != null) {
                    this.foodScore = (float)this.foodData.value;
                    BreakThroughController.RefreshExtraRateInfo(this,0);
                    if (this.foodCancel != null) {
                      GameObject.SetActive(this.foodCancel,1,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000D6E
    // RVA   : 0xCEA1F0   Offset: 0xCE89F0   Length: 0x9D
    public void BreakFoodCancel()
    {
        ulong uVar1;
        this.foodData = 0;
        uVar1 = this.foodIcon;
        GlobalData.DeleteAllChild(uVar1,0);
        this.foodScore = 0;
        BreakThroughController.RefreshExtraRateInfo(this,0);
        if (this.foodCancel != null) {
          GameObject.SetActive(this.foodCancel,0,0);
          return;
        }
    }

    // Token : 0x6000D6F
    // RVA   : 0xCE9E50   Offset: 0xCE8650   Length: 0x182
    public void BreakBookChoose()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[4];
        if (this.bookData != null) {
          return;
        }
        lVar1 = **(int64 **)(DAT_181d92370 + 184);
        lVar2 = il2cpp_internal(DAT_181d701b0);
        FUN_180f58a90(lVar2,DAT_181d6dfe8);
        local_res8[0] = 0;
        uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
        if (lVar2 != null) {
          FUN_181827900(lVar2,uVar3,DAT_181d6e0e8);
          local_res18[0] = 3;
          uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
          FUN_181827900(lVar2,uVar3,DAT_181d6e0e8);
          uVar3 = Component.get_gameObject(this,0);
          if (lVar1 != null) {
            ChooseController.ShowChoosePanel(lVar1,1,lVar2,uVar3,"BreakBookChoosen",0,14,0,0,0);
            return;
          }
        }
    }

    // Token : 0x6000D70
    // RVA   : 0xCE9FE0   Offset: 0xCE87E0   Length: 0x20A
    public void BreakBookChoosen()
    {
        var pStatics_2370 = *(int64*)(DAT_181d92370 + 184);
        var pStatics_e188 = *(int64*)(DAT_181d4e188 + 184);
        ulong uVar1;
        long lVar2;
        ulong uVar3;
        if ((*pStatics_2370 != 0) &&
           (lVar2 = *(int64 *)(*pStatics_2370 + 72)) != null) {
          lVar2 = GameObject.GetComponent(lVar2,DAT_181da0070);
          if (lVar2 != null) {
            uVar3 = *(uint64 *)(lVar2 + 32);
            this.bookData = uVar3;
            uVar3 = this.bookIcon;
            if (*pStatics_e188 != 0) {
              uVar1 = *(uint64 *)(*pStatics_e188 + 160);
              uVar3 = GlobalData.AddChild(uVar3,uVar1,0);
              this.newObj = uVar3;
              if (this.newObj != null) {
                lVar2 = GameObject.GetComponent(this.newObj,DAT_181da0070);
                if (lVar2 != null) {
                  *(uint64 *)(lVar2 + 32) = this.bookData;
                  if (this.newObj != null) {
                    lVar2 = GameObject.GetComponent(this.newObj,DAT_181da0070);
                    if (lVar2 != null) {
                      *(uint32 *)(lVar2 + 40) = 1;
                      if (this.bookData != null) {
                        this.bookScore =
                             (float)this.bookData.value * 0.25;
                        BreakThroughController.RefreshExtraRateInfo(this,0);
                        if (this.bookCancel != null) {
                          GameObject.SetActive(this.bookCancel,1,0);
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

    // Token : 0x6000D71
    // RVA   : 0xCED000   Offset: 0xCEB800   Length: 0x194
    public void SetBreakBook(ItemData targetBook)
    {
        var pStatics = *(int64*)(DAT_181d4e188 + 184);
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        this.bookData = targetBook;
        uVar2 = this.bookIcon;
        if (*pStatics != 0) {
          uVar1 = *(uint64 *)(*pStatics + 160);
          uVar2 = GlobalData.AddChild(uVar2,uVar1,0);
          this.newObj = uVar2;
          if (this.newObj != null) {
            lVar3 = GameObject.GetComponent(this.newObj,DAT_181da0070);
            if (lVar3 != null) {
              *(uint64 *)(lVar3 + 32) = this.bookData;
              if (this.newObj != null) {
                lVar3 = GameObject.GetComponent(this.newObj,DAT_181da0070);
                if (lVar3 != null) {
                  *(uint32 *)(lVar3 + 40) = 1;
                  if (this.bookData != null) {
                    this.bookScore =
                         (float)this.bookData.value * 0.25;
                    BreakThroughController.RefreshExtraRateInfo(this,0);
                    if (this.bookCancel != null) {
                      GameObject.SetActive(this.bookCancel,1,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000D72
    // RVA   : 0xCE9DA0   Offset: 0xCE85A0   Length: 0xA3
    public void BreakBookCancel()
    {
        ulong uVar1;
        this.bookData = 0;
        uVar1 = this.bookIcon;
        GlobalData.DeleteAllChild(uVar1,0);
        this.bookScore = 0;
        BreakThroughController.RefreshExtraRateInfo(this,0);
        if (this.bookCancel != null) {
          GameObject.SetActive(this.bookCancel,0,0);
          return;
        }
    }

    // Token : 0x6000D73
    // RVA   : 0xCEC2D0   Offset: 0xCEAAD0   Length: 0x877
    public void RefreshExtraRateInfo()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        float fVar1;
        float fVar2;
        float fVar3;
        int iVar5;
        int iVar6;
        long lVar7;
        ulong uVar8;
        ulong uVar9;
        long lVar12;
        ulong uVar13;
        float fVar14;
        float fVar15;
        float fVar16;
        float[] local_res8 = new float[2];
        uint[] local_res18 = new uint[2];
        int[] local_res20 = new int[2];
        ulong local_78;
        ulong uStack_70;
        if ((((this.breakThroughPanel != null) &&
             (lVar7 = GameObject.get_transform(this.breakThroughPanel,0)) != null) &&
            (lVar7 = Transform.Find(lVar7,"RateInfo",0)) != null) &&
           (lVar7 = Transform.Find(lVar7,"ExtraRateInfo",0)) != null) {
          uVar8 = Component.GetComponent(lVar7,DAT_181d6d8c0);
          local_res8[0] = (float)BreakThroughController.GetScoreRate(this,0);
          local_res8[0] = local_res8[0] * 100.0;
          uVar9 = Single.ToString(local_res8,"f0",0);
          uVar9 = String.Format("突破效率<b>(x{0}%)</b>",uVar9,0);
          LTLocalization.SetText(uVar8,uVar9,0);
          if (((this.breakThroughPanel != null) &&
              (lVar7 = GameObject.get_transform(this.breakThroughPanel,0)) != null) &&
             ((lVar7 = Transform.Find(lVar7,"RateInfo",0), lVar7 != null &&
              (lVar7 = Transform.Find(lVar7,"Rate",0)) != null))) {
            uVar8 = Component.GetComponent(lVar7,DAT_181d6d8c0);
            fVar14 = this.baseScore;
            fVar1 = this.medScore;
            fVar2 = this.foodScore;
            fVar3 = this.bookScore;
            local_res8[0] = (float)BreakThroughController.GetScoreRate(this,0);
            local_res8[0] = local_res8[0] * (fVar1 + fVar14 + fVar2 + fVar3);
            uVar9 = Single.ToString(local_res8,"f0",0);
            fVar14 = (float)BreakThroughController.GetMaxRareLv(this,0);
            uVar9 = GlobalData.GenerateRareLvColorText(uVar9,(int)fVar14,0);
            LTLocalization.SetText(uVar8,uVar9,0);
            if ((((this.breakThroughPanel != null) &&
                 (lVar7 = GameObject.get_transform(this.breakThroughPanel,0)) != null) &&
                (lVar7 = Transform.Find(lVar7,"RateInfo",0)) != null) &&
               (lVar7 = Transform.Find(lVar7,"MinScore",0)) != null) {
              plVar10 = (int64 *)Component.GetComponent(lVar7,DAT_181d6d8c0);
              fVar14 = this.baseScore;
              fVar1 = this.medScore;
              fVar2 = this.foodScore;
              fVar3 = this.bookScore;
              fVar15 = (float)BreakThroughController.GetScoreRate(this,0);
              if ((this.targetSkill != null) &&
                 (lVar7 = KungfuSkillLvData.DataBase(this.targetSkill,0)) != null) {
                fVar16 = (float)FUN_1801f7f00();
                if ((fVar1 + fVar14 + fVar2 + fVar3) * fVar15 < fVar16 * 50.0) {
                  puVar11 = (uint64 *)Color.get_red(&local_78,0);
                }
                else {
                  puVar11 = (uint64 *)Color.get_black();
                }
                if (plVar10 != (int64 *)0) {
                  local_78 = *puVar11;
                  uStack_70 = puVar11[1];
                  (**(code **)(*plVar10 + 0x2a8))(plVar10,&local_78,*(uint64 *)(*plVar10 + 0x2b0));
                  if (((this.breakThroughPanel != null) &&
                      (lVar7 = GameObject.get_transform(this.breakThroughPanel,0)) != null) &&
                     (lVar7 = Transform.Find(lVar7,"StartButton",0)) != null) {
                    lVar7 = Component.GetComponent(lVar7,DAT_181d6af40);
                    fVar14 = this.baseScore;
                    fVar1 = this.medScore;
                    fVar2 = this.foodScore;
                    fVar3 = this.bookScore;
                    fVar15 = (float)BreakThroughController.GetScoreRate(this,0);
                    if ((this.targetSkill != null) &&
                       (lVar12 = KungfuSkillLvData.DataBase(this.targetSkill,0), lVar12 != null
                       )) {
                      fVar16 = (float)FUN_1801f7f00();
                      if (fVar16 * 50.0 <= (fVar1 + fVar14 + fVar2 + fVar3) * fVar15) {
                        if (!this.useMoney) {
                          bVar4 = true;
                        }
                        else {
                          lVar12 = FUN_18046c0a0(0);
                          if ((((lVar12 == null) || (*(int64 *)(lVar12 + 32) == 0)) ||
                              (lVar12 = WorldData.Player(*(int64 *)(lVar12 + 32),0)) == null)
                             || (*(int64 *)(lVar12 + 0x220) == 0)) throw; // [null/range check failed]
                          iVar5 = *(int *)(*(int64 *)(lVar12 + 0x220) + 24);
                          if (this.targetSkill == null) throw; // [null/range check failed]
                          iVar6 = KungfuSkillLvData.BreakThroughDayCost(this.targetSkill,0);
                          iVar6 = Mathf.RoundToInt(((float)this.breakThroughType * 0.5 + 1.0) *
                                                    (float)iVar6,0);
                          bVar4 = iVar6 * 50 <= iVar5;
                        }
                      }
                      else {
                        bVar4 = false;
                      }
                      if (lVar7 != null) {
                        Selectable.set_interactable(lVar7,bVar4,0);
                        if (((this.breakThroughPanel != null) &&
                            (lVar7 = GameObject.get_transform(this.breakThroughPanel,0),
                            lVar7 != null)) &&
                           ((lVar7 = Transform.Find(lVar7,"StartButton",0), lVar7 != null &&
                            (lVar7 = Transform.Find(lVar7,"CostTime",0)) != null))) {
                          uVar8 = Component.GetComponent(lVar7,DAT_181d6d8c0);
                          if (this.targetSkill != null) {
                            iVar5 = KungfuSkillLvData.BreakThroughDayCost
                                              (this.targetSkill,0);
                            local_res18[0] =
                                 Mathf.RoundToInt(((float)this.breakThroughType * 0.5 + 1.0) *
                                                   (float)iVar5,0);
                            uVar9 = Int32.ToString(local_res18,0);
                            uVar9 = String.Concat("消耗天数 ",uVar9,0);
                            LTLocalization.SetText(uVar8,uVar9,0);
                            if (!this.useMoney) {
                              return;
                            }
                            if (((this.breakThroughPanel != null) &&
                                (lVar7 = GameObject.get_transform(this.breakThroughPanel,0),
                                lVar7 != null)) &&
                               ((lVar7 = Transform.Find(lVar7,"StartButton",0), lVar7 != null &&
                                (lVar7 = Transform.Find(lVar7,"CostTime",0)) != null))) {
                              uVar8 = Component.GetComponent(lVar7,DAT_181d6d8c0);
                              if ((((*pStatics != 0) &&
                                   (lVar7 = *(int64 *)(*pStatics + 32),
                                   lVar7 != null)) && (lVar7 = WorldData.Player(lVar7,0)) != null) &&
                                 (*(int64 *)(lVar7 + 0x220) != 0)) {
                                iVar5 = *(int *)(*(int64 *)(lVar7 + 0x220) + 24);
                                if (this.targetSkill != null) {
                                  iVar6 = KungfuSkillLvData.BreakThroughDayCost
                                                    (this.targetSkill,0);
                                  iVar6 = Mathf.RoundToInt(((float)this.breakThroughType * 0.5 + 1.0)
                                                            * (float)iVar6,0);
                                  uVar9 = "\n<color=#B40000>消耗银钱 {0}</color>";
                                  if (iVar6 * 50 <= iVar5) {
                                    uVar9 = "\n消耗银钱 {0}";
                                  }
                                  if (this.targetSkill != null) {
                                    iVar5 = KungfuSkillLvData.BreakThroughDayCost
                                                      (this.targetSkill,0);
                                    local_res20[0] =
                                         Mathf.RoundToInt(((float)this.breakThroughType * 0.5 + 1.0) *
                                                           (float)iVar5,0);
                                    local_res20[0] = local_res20[0] * 50;
                                    uVar13 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
                                    uVar9 = String.Format(uVar9,uVar13,0);
                                    LTLocalization.AddText(uVar8,uVar9,0);
                                    return;
                                  }
                          // WARNING: Subroutine does not return
                                  FUN_1800d6620();
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

    // Token : 0x6000D74
    // RVA   : 0xCEB170   Offset: 0xCE9970   Length: 0x51
    public int GetCostMoney()
    {
        int iVar1;
        if (this.targetSkill != null) {
          iVar1 = KungfuSkillLvData.BreakThroughDayCost(this.targetSkill,0);
          iVar1 = Mathf.RoundToInt(((float)this.breakThroughType * 0.5 + 1.0) * (float)iVar1,0);
          return iVar1 * 50;
        }
    }

    // Token : 0x6000D75
    // RVA   : 0xCEB340   Offset: 0xCE9B40   Length: 0x116
    public float GetScoreRate()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        float fVar1;
        int iVar2;
        bool cVar3;
        long lVar4;
        float fVar5;
        fVar1 = this.baseScoreRate;
        iVar2 = this.breakThroughType;
        if ((*pStatics != 0) &&
           (lVar4 = *(int64 *)(*pStatics + 32)) != null) {
          lVar4 = WorldData.Player(lVar4,0);
          if (lVar4 != null) {
            cVar3 = HeroData.HaveForceFunction(lVar4,14);
            if (!cVar3) {
              fVar5 = 0.0;
            }
            else {
              fVar5 = 0.2;
            }
            return (float)iVar2 * 0.1 + fVar1 + fVar5;
          }
        }
    }

    // Token : 0x6000D76
    // RVA   : 0xCEB1D0   Offset: 0xCE99D0   Length: 0x4D
    public int GetCostTime()
    {
        int iVar1;
        if (this.targetSkill != null) {
          iVar1 = KungfuSkillLvData.BreakThroughDayCost(this.targetSkill,0);
          Mathf.RoundToInt(((float)this.breakThroughType * 0.5 + 1.0) * (float)iVar1,0);
          return;
        }
    }

    // Token : 0x6000D77
    // RVA   : 0xCEB460   Offset: 0xCE9C60   Length: 0x66
    public float GetTotalScore()
    {
        float fVar1;
        float fVar2;
        float fVar3;
        float fVar4;
        float fVar5;
        fVar1 = this.baseScore;
        fVar2 = this.foodScore;
        fVar3 = this.bookScore;
        fVar4 = this.medScore;
        fVar5 = (float)BreakThroughController.GetScoreRate(this,0);
        return fVar5 * (fVar4 + fVar1 + fVar2 + fVar3);
    }

    // Token : 0x6000D78
    // RVA   : 0xCEB2F0   Offset: 0xCE9AF0   Length: 0x40
    public float GetMinScore()
    {
        long lVar1;
        float fVar2;
        if (this.targetSkill != null) {
          lVar1 = KungfuSkillLvData.DataBase(this.targetSkill,0);
          if (lVar1 != null) {
            fVar2 = (float)FUN_1801f7f00(0x40000000);
            return fVar2 * 50.0;
          }
        }
    }

    // Token : 0x6000D79
    // RVA   : 0xCEB220   Offset: 0xCE9A20   Length: 0xCB
    public float GetMaxRareLv()
    {
        float fVar1;
        float fVar2;
        float fVar3;
        float fVar4;
        long lVar5;
        float fVar6;
        float fVar7;
        fVar1 = this.medScore;
        fVar2 = this.baseScore;
        fVar3 = this.foodScore;
        fVar4 = this.bookScore;
        fVar6 = (float)BreakThroughController.GetScoreRate(this,0);
        if (this.targetSkill != null) {
          lVar5 = KungfuSkillLvData.DataBase(this.targetSkill,0);
          if (lVar5 != null) {
            fVar7 = (float)FUN_1801f7f00(0x40000000,(float)*(int *)(lVar5 + 52));
            FUN_1810a8ba0(((fVar1 + fVar2 + fVar3 + fVar4) * fVar6 * 0.01) / fVar7,0,0x40a00000,0);
            return;
          }
        }
    }

    // Token : 0x6000D7A
    // RVA   : 0xCEAF90   Offset: 0xCE9790   Length: 0xF6
    public void BreakThroughTypeButtonClicked(GameObject buttonClicked)
    {
        uint uVar1;
        long lVar2;
        ulong uVar3;
        if (buttonClicked != null) {
          lVar2 = GameObject.GetComponent(buttonClicked,DAT_181da2130);
          if (lVar2 != null) {
            if (*(char *)(lVar2 + 0x118) != false) {
              uVar3 = Object.get_name(buttonClicked,0);
              uVar1 = Int32.Parse(uVar3,0);
              this.breakThroughType = uVar1;
              BreakThroughController.RefreshExtraRateInfo(this,0);
              plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/Button/TabButton",0);
              plVar5 = (int64 *)0;
              if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
                plVar5 = plVar4;
              }
              NGUITools.PlaySound(plVar5,0);
            }
            return;
          }
        }
    }

    // Token : 0x6000D7B
    // RVA   : 0xCED560   Offset: 0xCEBD60   Length: 0x2E6
    public void StartBreakThroughButtonClicked()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        if (this.useMoney) {
          if ((*pStatics == 0) ||
             (lVar3 = *(int64 *)(*pStatics + 32)) == null)
          throw; // [null/range check failed]
          lVar3 = WorldData.Player(lVar3,0);
          if (this.targetSkill == null) throw; // [null/range check failed]
          iVar1 = KungfuSkillLvData.BreakThroughDayCost(this.targetSkill,0);
          iVar1 = Mathf.RoundToInt(((float)this.breakThroughType * 0.5 + 1.0) * (float)iVar1,0);
          if (lVar3 == null) throw; // [null/range check failed]
          HeroData.ChangeMoney(lVar3,iVar1 * -50,1,0);
        }
        lVar3 = *(int64 *)(*(int64 *)(DAT_181d90b30 + 184) + 8);
        if (this.targetSkill != null) {
          uVar4 = KungfuSkillLvData.Name(this.targetSkill,1,0);
          uVar4 = String.Format("突破{0}",uVar4,0);
          if (this.targetSkill != null) {
            iVar1 = KungfuSkillLvData.BreakThroughDayCost(this.targetSkill,0);
            uVar2 = Mathf.RoundToInt(((float)this.breakThroughType * 0.5 + 1.0) * (float)iVar1,0);
            if (lVar3 != null) {
              WorkingUIController.StartWorking(lVar3,uVar4,uVar2,0,0,"RealStartBreakThrough",0,0);
              plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/Button/BigButton",0);
              plVar6 = (int64 *)0;
              if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181d8a228)) {
                plVar6 = plVar5;
              }
              NGUITools.PlaySound(plVar6,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000D7C
    // RVA   : 0xCEB4D0   Offset: 0xCE9CD0   Length: 0xDFB
    public void RealStartBreakThrough()
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_f230 = *(int64*)(DAT_181d7f230 + 184);
        bool cVar1;
        int iVar2;
        long lVar3;
        ulong uVar5;
        ulong uVar7;
        float fVar10;
        ulong in_stack_ffffffffffffff98;
        uint uVar12;
        ulong uVar11;
        ulong local_48;
        uint local_40;
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        uVar12 = (uint32)((uint64)in_stack_ffffffffffffff98 >> 32);
        if (this.breakThroughPanel != null) {
          lVar3 = GameObject.get_transform(this.breakThroughPanel,0);
          if (lVar3 != null) {
            lVar3 = Transform.Find(lVar3,"StartButton",0);
            if (lVar3 != null) {
              lVar3 = Component.get_gameObject(lVar3,0);
              if (lVar3 != null) {
                GameObject.SetActive(lVar3,0,0);
                if (this.breakThroughPanel != null) {
                  lVar3 = GameObject.get_transform(this.breakThroughPanel,0);
                  if (lVar3 != null) {
                    lVar3 = Transform.Find(lVar3,"RateInfo",0);
                    if (lVar3 != null) {
                      lVar3 = Component.get_gameObject(lVar3,0);
                      if (lVar3 != null) {
                        GameObject.SetActive(lVar3,0,0);
                        if (this.breakThroughPanel != null) {
                          lVar3 = GameObject.get_transform(this.breakThroughPanel,0);
                          if (lVar3 != null) {
                            lVar3 = Transform.Find(lVar3,"BlackBackground",0);
                            if (lVar3 != null) {
                              lVar3 = Component.GetComponent(lVar3,DAT_181d6af40);
                              if (lVar3 != null) {
                                Selectable.set_interactable(lVar3,0,0);
                                if ((*pStatics_df90 != 0) &&
                                   (lVar3 = *(int64 *)(*pStatics_df90 + 32),
                                   lVar3 != null)) {
                                  lVar3 = WorldData.Player(lVar3,0);
                                  if ((lVar3 != null) &&
                                     ((*(int64 *)(lVar3 + 0x220) != 0 &&
                                      (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 0x220) + 40),
                                      lVar3 != null)))) {
                                    cVar1 = FUN_1818279a0(lVar3,this.medData,
                                                          DAT_181d693f0);
                                    if (!cVar1) {
                                      if ((*pStatics_df90 == 0) ||
                                         (lVar3 = *(int64 *)
                                                   (*pStatics_df90 + 32),
                                         lVar3 == null)) throw; // [null/range check failed]
                                      lVar3 = WorldData.Player(lVar3,0);
                                      if ((lVar3 == null) || (*(int64 *)(lVar3 + 0x228) == 0))
                                      throw; // [null/range check failed]
                                      ItemListData.LoseItem
                                                (*(int64 *)(lVar3 + 0x228),
                                                 this.medData,1,0);
                                    }
                                    else {
                                      if ((*pStatics_df90 == 0) ||
                                         (lVar3 = *(int64 *)
                                                   (*pStatics_df90 + 32),
                                         lVar3 == null)) throw; // [null/range check failed]
                                      lVar3 = WorldData.Player(lVar3,0);
                                      if (lVar3 == null) throw; // [null/range check failed]
                                      HeroData.LoseItem(lVar3,this.medData,1,0);
                                    }
                                    if ((*pStatics_df90 != 0) &&
                                       (lVar3 = *(int64 *)
                                                 (*pStatics_df90 + 32),
                                       lVar3 != null)) {
                                      lVar3 = WorldData.Player(lVar3,0);
                                      if ((lVar3 != null) &&
                                         ((*(int64 *)(lVar3 + 0x220) != 0 &&
                                          (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 0x220) + 40),
                                          lVar3 != null)))) {
                                        cVar1 = FUN_1818279a0(lVar3,this.foodData,
                                                              DAT_181d693f0);
                                        if (!cVar1) {
                                          if ((*pStatics_df90 == 0) ||
                                             (lVar3 = *(int64 *)
                                                       (*pStatics_df90 + 32),
                                             lVar3 == null)) throw; // [null/range check failed]
                                          lVar3 = WorldData.Player(lVar3,0);
                                          if ((lVar3 == null) || (*(int64 *)(lVar3 + 0x228) == 0))
                                          throw; // [null/range check failed]
                                          ItemListData.LoseItem
                                                    (*(int64 *)(lVar3 + 0x228),
                                                     this.foodData,1,0);
                                        }
                                        else {
                                          if ((*pStatics_df90 == 0) ||
                                             (lVar3 = *(int64 *)
                                                       (*pStatics_df90 + 32),
                                             lVar3 == null)) throw; // [null/range check failed]
                                          lVar3 = WorldData.Player(lVar3,0);
                                          if (lVar3 == null) throw; // [null/range check failed]
                                          HeroData.LoseItem(lVar3,this.foodData,1,0);
                                        }
                                        if (this.medCancel != null) {
                                          GameObject.SetActive(this.medCancel,0,0);
                                          if (this.foodCancel != null) {
                                            GameObject.SetActive(this.foodCancel,0,0);
                                            if (this.bookCancel != null) {
                                              GameObject.SetActive(this.bookCancel,0,0);
                                              plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/BigSkill0",0);
                                              plVar9 = (int64 *)0;
                                              if ((plVar4 != (int64 *)0) &&
                                                 (plVar9 = (int64 *)0, *plVar4 == DAT_181d8a228)) {
                                                plVar9 = plVar4;
                                              }
                                              NGUITools.PlaySound(plVar9,0);
                                              if (this.medIcon != null) {
                                                lVar3 = GameObject.get_transform
                                                                  (this.medIcon,0);
                                                if (lVar3 != null) {
                                                  iVar2 = Transform.get_childCount(lVar3,0);
                                                  if (0 < iVar2) {
                                                    if (this.medIcon == null)
                                                    throw; // [null/range check failed]
                                                    lVar3 = GameObject.get_transform
                                                                      (this.medIcon,0);
                                                    if (lVar3 == null) throw; // [null/range check failed]
                                                    uVar5 = Transform.GetChild(lVar3,0,0);
                                                    if (this.targetSkillSlot == null)
                                                    throw; // [null/range check failed]
                                                    lVar3 = GameObject.get_transform
                                                                      (this.targetSkillSlot,0);
                                                    if (lVar3 == null) throw; // [null/range check failed]
                                                    puVar6 = (uint64 *)
                                                             Transform.get_position(&local_38,lVar3,0);
                                                    uVar12 = 0;
                                                    local_48 = *puVar6;
                                                    local_40 = *(uint32 *)(puVar6 + 1);
                                                    uVar5 = ShortcutExtensions.DOMove
                                                                      (uVar5,&local_48,0x3f800000,0,0);
                                                    TweenSettingsExtensions.SetEase
                                                              (uVar5,9,DAT_181d97ca8);
                                                    if (this.medIcon == null)
                                                    throw; // [null/range check failed]
                                                    lVar3 = GameObject.get_transform
                                                                      (this.medIcon,0);
                                                    if (lVar3 == null) throw; // [null/range check failed]
                                                    uVar5 = Transform.GetChild(lVar3,0,0);
                                                    uVar5 = ShortcutExtensions.DOScale
                                                                      (uVar5,0,0x3f000000,0);
                                                    uVar5 = TweenSettingsExtensions.SetDelay
                                                                      (uVar5,0x3f000000,DAT_181d97978);
                                                    TweenSettingsExtensions.SetEase
                                                              (uVar5,8,DAT_181d97ca8);
                                                  }
                                                  if (this.foodIcon != null) {
                                                    lVar3 = GameObject.get_transform
                                                                      (this.foodIcon,0);
                                                    if (lVar3 != null) {
                                                      iVar2 = Transform.get_childCount(lVar3,0);
                                                      if (0 < iVar2) {
                                                        if (this.foodIcon == null)
                                                        throw; // [null/range check failed]
                                                        lVar3 = GameObject.get_transform
                                                                          (this.foodIcon,0
                                                                          );
                                                        if (lVar3 == null) throw; // [null/range check failed]
                                                        uVar5 = Transform.GetChild(lVar3,0,0);
                                                        if (this.targetSkillSlot == null)
                                                        throw; // [null/range check failed]
                                                        lVar3 = GameObject.get_transform
                                                                          (this.targetSkillSlot,0
                                                                          );
                                                        if (lVar3 == null) throw; // [null/range check failed]
                                                        puVar6 = (uint64 *)
                                                                 Transform.get_position
                                                                           (&local_38,lVar3,0);
                                                        uVar12 = 0;
                                                        local_48 = *puVar6;
                                                        local_40 = *(uint32 *)(puVar6 + 1);
                                                        uVar5 = ShortcutExtensions.DOMove
                                                                          (uVar5,&local_48,0x3f800000,0,0)
                                                        ;
                                                        TweenSettingsExtensions.SetEase
                                                                  (uVar5,9,DAT_181d97ca8);
                                                        if (this.foodIcon == null)
                                                        throw; // [null/range check failed]
                                                        lVar3 = GameObject.get_transform
                                                                          (this.foodIcon,0
                                                                          );
                                                        if (lVar3 == null) throw; // [null/range check failed]
                                                        uVar5 = Transform.GetChild(lVar3,0,0);
                                                        uVar5 = ShortcutExtensions.DOScale
                                                                          (uVar5,0,0x3f000000,0);
                                                        uVar5 = TweenSettingsExtensions.SetDelay
                                                                          (uVar5,0x3f000000,DAT_181d97978)
                                                        ;
                                                        TweenSettingsExtensions.SetEase
                                                                  (uVar5,8,DAT_181d97ca8);
                                                      }
                                                      if (this.bookIcon != null) {
                                                        lVar3 = GameObject.get_transform
                                                                          (this.bookIcon,0
                                                                          );
                                                        if (lVar3 != null) {
                                                          iVar2 = Transform.get_childCount(lVar3,0);
                                                          if (0 < iVar2) {
                                                            if (this.bookIcon == null)
                                                            throw; // [null/range check failed]
                                                            lVar3 = GameObject.get_transform
                                                                              (*(int64 *)
                                                                                (this + 136),0);
                                                            if (lVar3 == null) throw; // [null/range check failed]
                                                            uVar5 = Transform.GetChild(lVar3,0,0);
                                                            if (this.targetSkillSlot == null)
                                                            throw; // [null/range check failed]
                                                            lVar3 = GameObject.get_transform
                                                                              (*(int64 *)
                                                                                (this + 48),0);
                                                            if (lVar3 == null) throw; // [null/range check failed]
                                                            puVar6 = (uint64 *)
                                                                     Transform.get_position
                                                                               (&local_38,lVar3,0);
                                                            uVar12 = 0;
                                                            local_48 = *puVar6;
                                                            local_40 = *(uint32 *)(puVar6 + 1);
                                                            uVar5 = ShortcutExtensions.DOMove
                                                                              (uVar5,&local_48,0x3f800000,
                                                                               0,0);
                                                            TweenSettingsExtensions.SetEase
                                                                      (uVar5,9,DAT_181d97ca8);
                                                            if (this.bookIcon == null)
                                                            throw; // [null/range check failed]
                                                            lVar3 = GameObject.get_transform
                                                                              (*(int64 *)
                                                                                (this + 136),0);
                                                            if (lVar3 == null) throw; // [null/range check failed]
                                                            uVar5 = Transform.GetChild(lVar3,0,0);
                                                            uVar5 = ShortcutExtensions.DOScale
                                                                              (uVar5,0,0x3f000000,0);
                                                            uVar5 = TweenSettingsExtensions.SetDelay
                                                                              (uVar5,0x3f000000,
                                                                               DAT_181d97978);
                                                            TweenSettingsExtensions.SetEase
                                                                      (uVar5,8,DAT_181d97ca8);
                                                          }
                                                          if (*pStatics_f230 != 0)
                                                          {
                                                            uVar5 = *(uint64 *)
                                                                     (**(int64 **)
                                                                        (DAT_181d7f230 + 184) + 152);
                                                            if (this.targetSkillSlot != null) {
                                                              lVar3 = GameObject.get_transform
                                                                                (*(int64 *)
                                                                                  (this + 48),0);
                                                              if (lVar3 != null) {
                                                                uVar7 = Component.get_gameObject(lVar3,0)
                                                                ;
                                                                fVar10 = (float)
                                                        BreakThroughController.GetMaxRareLv(this,0);
                                                        uVar11 = CONCAT44(uVar12,0x40000000);
                                                        uVar5 = BreakThroughController.ShowItemParticle
                                                                          (this,uVar5,uVar7,0x3f333333,
                                                                           uVar11,(int)fVar10,0);
                                                        uVar12 = (uint32)((uint64)uVar11 >> 32);
                                                        FUN_180d837c0(this,uVar5,0);
                                                        if (*pStatics_f230 != 0) {
                                                          uVar5 = *(uint64 *)
                                                                   (*pStatics_f230
                                                                   + 144);
                                                          if (this.targetSkillSlot != null) {
                                                            lVar3 = GameObject.get_transform
                                                                              (*(int64 *)
                                                                                (this + 48),0);
                                                            if (lVar3 != null) {
                                                              uVar7 = Component.get_gameObject(lVar3,0);
                                                              fVar10 = (float)
                                                        BreakThroughController.GetMaxRareLv(this,0);
                                                        uVar5 = BreakThroughController.ShowItemParticle
                                                                          (this,uVar5,uVar7,0x3f333333,
                                                                           CONCAT44(uVar12,0x3f800000),
                                                                           (int)fVar10,0);
                                                        FUN_180d837c0(this,uVar5,0);
                                                        if (this.breakThroughPos != null) {
                                                          lVar3 = GameObject.get_transform
                                                                            (this.breakThroughPos
                                                                             ,0);
                                                          if (lVar3 != null) {
                                                            lVar3 = Transform.Find(lVar3,"Background",0)
                                                            ;
                                                            if (lVar3 != null) {
                                                              lVar3 = Component.get_gameObject(lVar3,0);
                                                              if (lVar3 != null) {
                                                                GameObject.SetActive(lVar3,1,0);
                                                                if (this.breakThroughPos != null) {
                                                                  lVar3 = GameObject.get_transform
                                                                                    (*(int64 *)
                                                                                      (this + 160),0);
                                                                  if (lVar3 != null) {
                                                                    lVar3 = Transform.Find(lVar3,
                                                        "Background",0);
                                                        if (lVar3 != null) {
                                                          plVar4 = (int64 *)
                                                                   Component.GetComponent
                                                                             (lVar3,DAT_181d6bc40);
                                                          puVar8 = (uint32 *)
                                                                   FUN_180d904c0(&local_38,0);
                                                          if (plVar4 != (int64 *)0) {
                                                            local_38 = *puVar8;
                                                            uStack_34 = puVar8[1];
                                                            uStack_30 = puVar8[2];
                                                            uStack_2c = puVar8[3];
                                                            (**(code **)(*plVar4 + 0x2a8))
                                                                      (plVar4,&local_38,
                                                                       *(uint64 *)(*plVar4 + 0x2b0));
                                                            if (this.breakThroughPos != null) {
                                                              lVar3 = GameObject.get_transform
                                                                                (*(int64 *)
                                                                                  (this + 160),0);
                                                              if (lVar3 != null) {
                                                                lVar3 = Transform.Find(lVar3,
                                                        "Background",0);
                                                        if (lVar3 != null) {
                                                          uVar5 = Component.GetComponent
                                                                            (lVar3,DAT_181d6bc40);
                                                          uVar5 = DOTweenModuleUI.DOFade
                                                                            (uVar5,0x3f666666,0x3f800000,0
                                                                            );
                                                          TweenSettingsExtensions.SetDelay
                                                                    (uVar5,0x3f800000,DAT_181d977e0);
                                                          MonoBehaviour.Invoke
                                                                    (this,"StartShowBreakChoice",0x3f800000,0);
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

    // Token : 0x6000D7D
    // RVA   : 0xCEB090   Offset: 0xCE9890   Length: 0xD3
    public int ChoiceNum()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        bool cVar1;
        long lVar2;
        if ((*pStatics != 0) &&
           (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if (lVar2 != null) {
            cVar1 = HeroData.HaveForceFunction(lVar2,14);
            return (cVar1) + '\x03';
          }
        }
    }

    // Token : 0x6000D7E
    // RVA   : 0xCEE090   Offset: 0xCEC890   Length: 0x122F
    public void StartShowBreakChoice()
    {
        var pStatics = *(int64*)(DAT_181d9ec60 + 184);
        uint uVar1;
        int iVar2;
        uint uVar3;
        int iVar4;
        uint uVar5;
        long lVar7;
        long lVar8;
        ulong uVar9;
        long lVar10;
        ulong uVar11;
        long lVar12;
        float fVar15;
        int[] local_res8 = new int[2];
        ulong uVar16;
        uint uVar18;
        ulong uVar17;
        ulong local_e8;
        float local_e0;
        ulong local_d8;
        float fStack_d0;
        uint32 uStack_cc;
        uint8 local_c8 [144];
        plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/FameUp",0);
        plVar13 = (int64 *)0;
        if ((plVar6 != (int64 *)0) && (plVar13 = (int64 *)0, *plVar6 == DAT_181d8a228)) {
          plVar13 = plVar6;
        }
        NGUITools.PlaySound(plVar13);
        if (this.targetSkillSlot != null) {
          lVar7 = GameObject.get_transform(this.targetSkillSlot,0);
          if ((((this.breakThroughPanel != null) &&
               (lVar8 = GameObject.get_transform(this.breakThroughPanel,0)) != null) &&
              (lVar8 = Transform.Find(lVar8,"BreakThroughQuestion",0)) != null) &&
             (iVar2 = Transform.GetSiblingIndex(lVar8,0), lVar7 != null)) {
            Transform.SetSiblingIndex(lVar7,iVar2 + -1,0);
            if (this.targetSkillSlot != null) {
              uVar9 = GameObject.get_transform(this.targetSkillSlot,0);
              uVar16 = 0;
              uVar9 = ShortcutExtensions.DOLocalMoveY(uVar9);
              TweenSettingsExtensions.SetUpdate(uVar9,1,DAT_181d98af0);
              if (this.targetSkill != null) {
                lVar7 = KungfuSkillLvData.GetBreakThroughAvailableChoice(this.targetSkill,0)
                ;
                local_res8[0] = 0;
                iVar2 = BreakThroughController.ChoiceNum(this,0);
                if (0 < iVar2) {
                  do {
                    if (lVar7 == null) throw; // [null/range check failed]
                    if (*(int *)(lVar7 + 24) < 1) break;
                    lVar8 = new c.DisplayClass9_0(0);
                    fVar15 = (float)BreakThroughController.GetMaxRareLv(this,0);
                    iVar2 = (int)fVar15;
                    uVar3 = FUN_180d8cf10(0,*(uint32 *)(lVar7 + 24),0);
                    if (*(uint32 *)(lVar7 + 24) <= uVar3) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    if (lVar8 == null) throw; // [null/range check failed]
                    *(uint32 *)(lVar8 + 16) =
                         lVar7[uVar3];
                    uVar9 = new OnTooltipCB(lVar8,DAT_181d6f998,DAT_181d95e70);
                    FUN_181818fa0(lVar7,uVar9,DAT_181d67ef0);
                    if (this.breakThroughPos == null) throw; // [null/range check failed]
                    lVar10 = GameObject.get_transform(this.breakThroughPos,0);
                    uVar9 = Int32.ToString(local_res8,0);
                    if ((lVar10 == null) || (lVar10 = Transform.Find(lVar10,uVar9,0)) == null)
                    throw; // [null/range check failed]
                    uVar11 = Component.get_gameObject(lVar10,0);
                    uVar9 = this.breakThroughChoiceIconPrefab;
                    lVar10 = GlobalData.AddChild(uVar11,uVar9,0);
                    this.newObj = lVar10;
                    lVar10 = FUN_18046c100(0);
                    if (((lVar10 == null) || (*(int64 *)(lVar10 + 144) == 0)) ||
                       (lVar10 = FUN_180002f80(*(int64 *)(lVar10 + 144),*(uint32 *)(lVar8 + 16),
                                               DAT_181d64878), lVar10 == null)) throw; // [null/range check failed]
                    if (((*(char *)(lVar10 + 89) != false) || (*(uint32 *)(lVar8 + 16) < 15)) ||
                       (*(uint32 *)(lVar8 + 16) - 24 < 9)) {
                      if (*plVar6 == 0) throw; // [null/range check failed]
                      lVar10 = GameObject.GetComponent(*plVar6,DAT_181da12b0);
                      lVar12 = FUN_18046c100(0);
                      if ((((lVar12 == null) || (*(int64 *)(lVar12 + 144) == 0)) ||
                          (lVar12 = FUN_180002f80(*(int64 *)(lVar12 + 144),
                                                  *(uint32 *)(lVar8 + 16),DAT_181d64878),
                          lVar12 == null)) ||
                         (uVar9 = HeroSpeAddDataBase.GetDescribe(lVar12,0), lVar10 == null))
                      throw; // [null/range check failed]
                      *(uint64 *)(lVar10 + 24) = uVar9;
                    }
                    if ((*plVar6 == 0) ||
                       (lVar10 = GameObject.GetComponent(*plVar6,DAT_181d9ec40)) == null)
                    throw; // [null/range check failed]
                    *(int *)(lVar10 + 32) = iVar2;
                    if ((*plVar6 == 0) ||
                       (lVar10 = GameObject.GetComponent(*plVar6,DAT_181d9ec40)) == null)
                    throw; // [null/range check failed]
                    lVar10 = *(int64 *)(lVar10 + 40);
                    uVar5 = *(uint32 *)(lVar8 + 16);
                    lVar12 = FUN_18046c0a0(0);
                    if (((lVar12 == null) || (*(int64 *)(lVar12 + 32) == 0)) ||
                       (lVar12 = WorldData.Player(*(int64 *)(lVar12 + 32),0)) == null)
                    throw; // [null/range check failed]
                    HeroData.HaveForceFunction(lVar12,14);
                    Mathf.Max(0x3f000000);
                    lVar12 = FUN_18046c100(0);
                    if (((lVar12 == null) || (*(int64 *)(lVar12 + 144) == 0)) ||
                       ((lVar8 = FUN_180002f80(*(int64 *)(lVar12 + 144),*(uint32 *)(lVar8 + 16),
                                               DAT_181d64878), lVar8 == null || (lVar10 == null))))
                    throw; // [null/range check failed]
                    HeroSpeAddData.Set(lVar10,uVar5);
                    if (*plVar6 == 0) throw; // [null/range check failed]
                    lVar8 = GameObject.GetComponent(*plVar6,DAT_181d9ec40);
                    iVar4 = local_res8[0];
                    if (2 < local_res8[0]) {
                      iVar4 = GlobalData.RandomRange(0,3,0);
                    }
                    if (lVar8 == null) throw; // [null/range check failed]
                    *(int *)(lVar8 + 48) = iVar4;
                    if (*plVar6 == 0) throw; // [null/range check failed]
                    lVar8 = GameObject.GetComponent(*plVar6,DAT_181d9ec40);
                    if ((this.targetSkill == null) ||
                       (lVar10 = KungfuSkillLvData.DataBase(this.targetSkill,0), lVar10 == null
                       )) throw; // [null/range check failed]
                    iVar4 = *(int *)(lVar10 + 52);
                    fVar15 = (float)Random.Range(0x3f800000);
                    uVar5 = Mathf.RoundToInt(((float)iVar2 * 0.5 + fVar15) * ((float)iVar4 * 2.5 + 5.0) *
                                              ((float)this.breakThroughType * 0.2 + 1.0),0);
                    uVar5 = Mathf.Clamp(uVar5,0,100);
                    if (lVar8 == null) throw; // [null/range check failed]
                    *(uint32 *)(lVar8 + 52) = uVar5;
                    if (*plVar6 == 0) throw; // [null/range check failed]
                    plVar13 = (int64 *)GameObject.GetComponent(*plVar6,DAT_181d9fe50);
                    lVar8 = FUN_18046c100(0);
                    if ((((lVar8 == null) || (*(int64 *)(lVar8 + 56) == 0)) ||
                        (lVar8 = FUN_180002f80(*(int64 *)(lVar8 + 56),iVar2,DAT_181d76758),
                        lVar8 == null)) || (plVar13 == (int64 *)0)) throw; // [null/range check failed]
                    local_d8 = *(uint64 *)(lVar8 + 24);
                    fStack_d0 = *(float *)(lVar8 + 32);
                    uStack_cc = *(uint32 *)(lVar8 + 36);
                    (**(code **)(*plVar13 + 0x2a8))(plVar13,&local_d8,*(uint64 *)(*plVar13 + 0x2b0));
                    if (((*plVar6 == 0) || (lVar8 = GameObject.get_transform(*plVar6,0)) == null) ||
                       (lVar8 = Transform.Find(lVar8,"Text",0)) == null) throw; // [null/range check failed]
                    uVar9 = Component.GetComponent(lVar8,DAT_181d6d8c0);
                    if (((*plVar6 == 0) ||
                        (lVar8 = GameObject.GetComponent(*plVar6,DAT_181d9ec40)) == null) ||
                       (*(int64 *)(lVar8 + 40) == 0)) throw; // [null/range check failed]
                    uVar18 = 0;
                    uVar16 = uVar16 & 0xffffffffffffff00;
                    uVar11 = HeroSpeAddData.GetDescribe(*(int64 *)(lVar8 + 40),0,1,1,uVar16,0);
                    uVar5 = (uint32)(uVar16 >> 32);
                    LTLocalization.SetText(uVar9,uVar11,0);
                    if (((*plVar6 == 0) || (lVar8 = GameObject.get_transform(*plVar6,0)) == null) ||
                       (lVar8 = Transform.Find(lVar8,"Icon",0)) == null) throw; // [null/range check failed]
                    lVar8 = Component.GetComponent(lVar8,DAT_181d6bc40);
                    if ((*plVar6 == 0) ||
                       (lVar10 = GameObject.GetComponent(*plVar6,DAT_181d9ec40)) == null)
                    throw; // [null/range check failed]
                    lVar10 = *(int64 *)(lVar10 + 24);
                    if (((*plVar6 == 0) ||
                        ((lVar12 = GameObject.GetComponent(*plVar6,DAT_181d9ec40), lVar12 == null ||
                         (lVar10 == null)))) ||
                       (uVar9 = FUN_180002f80(lVar10,*(uint32 *)(lVar12 + 48),DAT_181d7c050),
                       lVar8 == null)) throw; // [null/range check failed]
                    Image.set_sprite(lVar8,uVar9,0);
                    if (((*plVar6 == 0) || (lVar8 = GameObject.get_transform(*plVar6,0)) == null) ||
                       (lVar8 = Transform.Find(lVar8,"CostIcon",0)) == null) throw; // [null/range check failed]
                    lVar8 = Component.GetComponent(lVar8,DAT_181d6bc40);
                    lVar10 = FUN_18046c6c0(0);
                    if ((*plVar6 == 0) ||
                       (lVar12 = GameObject.GetComponent(*plVar6,DAT_181d9ec40)) == null)
                    throw; // [null/range check failed]
                    uVar1 = *(uint32 *)(lVar12 + 48);
                    uVar9 = GlobalData.GetInjuryIconName(uVar1,0);
                    if ((lVar10 == null) ||
                       (uVar9 = TextureController.LoadAtlasSprite(lVar10,"UIAtlas",uVar9,0),
                       lVar8 == null)) throw; // [null/range check failed]
                    Image.set_sprite(lVar8,uVar9,0);
                    if ((*plVar6 == 0) ||
                       ((lVar8 = GameObject.get_transform(*plVar6,0), lVar8 == null ||
                        (lVar8 = Transform.Find(lVar8,"Cost",0)) == null)))
                    throw; // [null/range check failed]
                    uVar9 = Component.GetComponent(lVar8,DAT_181d6d8c0);
                    if ((*plVar6 == 0) ||
                       (lVar8 = GameObject.GetComponent(*plVar6,DAT_181d9ec40)) == null)
                    throw; // [null/range check failed]
                    uVar11 = Int32.ToString(lVar8 + 52,0);
                    LTLocalization.SetText(uVar9,uVar11,0);
                    if (((*plVar6 == 0) || (lVar8 = GameObject.get_transform(*plVar6,0)) == null) ||
                       (lVar8 = Transform.Find(lVar8,"Cost",0)) == null) throw; // [null/range check failed]
                    plVar13 = (int64 *)Component.GetComponent(lVar8,DAT_181d6d8c0);
                    lVar8 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x3b8);
                    if (((*plVar6 == 0) ||
                        (lVar10 = GameObject.GetComponent(*plVar6,DAT_181d9ec40)) == null) ||
                       (lVar8 == null)) throw; // [null/range check failed]
                    uVar3 = *(uint32 *)(lVar10 + 48);
                    if (*(uint32 *)(lVar8 + 24) <= uVar3) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    if (plVar13 == (int64 *)0) throw; // [null/range check failed]
                    puVar14 = (uint64 *)
                              (*(int64 *)(lVar8 + 16) + ((int64)(int)uVar3 + 2) * 16);
                    local_d8 = *puVar14;
                    fStack_d0 = *(float *)(puVar14 + 1);
                    uStack_cc = *(uint32 *)((int64)puVar14 + 12);
                    (**(code **)(*plVar13 + 0x2a8))(plVar13,&local_d8,*(uint64 *)(*plVar13 + 0x2b0));
                    if (*plVar6 == 0) throw; // [null/range check failed]
                    lVar8 = GameObject.get_transform(*plVar6,0);
                    puVar14 = (uint64 *)Vector3.get_one(local_c8,0);
                    local_d8 = *puVar14;
                    fStack_d0 = *(float *)(puVar14 + 1);
                    if (lVar8 == null) throw; // [null/range check failed]
                    local_e8 = CONCAT44((float)((uint64)local_d8 >> 32) * 5.0,(float)local_d8 * 5.0);
                    local_e0 = fStack_d0 * 5.0;
                    Transform.set_localScale(lVar8,&local_e8,0);
                    if (*plVar6 == 0) throw; // [null/range check failed]
                    uVar9 = GameObject.get_transform(*plVar6,0);
                    uVar9 = ShortcutExtensions.DOScale(uVar9);
                    uVar9 = TweenSettingsExtensions.SetDelay
                                      (uVar9,(float)local_res8[0] + 1.0,DAT_181d97978);
                    lVar8 = *(int64 *)(pStatics + 8);
                    if (lVar8 == null) {
                      uVar11 = **(uint64 **)(DAT_181d9ec60 + 184);
                      lVar8 = new OnTooltipCB(uVar11,DAT_181d6f898,0);
                      plVar13 = (int64 *)(pStatics + 8);
                      *plVar13 = lVar8;
                      il2cpp_internal(plVar13,lVar8);
                    }
                    uVar9 = TweenSettingsExtensions.OnStart(uVar9,lVar8,DAT_181d97210);
                    lVar8 = *(int64 *)(pStatics + 16);
                    if (lVar8 == null) {
                      uVar11 = **(uint64 **)(DAT_181d9ec60 + 184);
                      lVar8 = new OnTooltipCB(uVar11,DAT_181d6f918,0);
                      plVar13 = (int64 *)(pStatics + 16);
                      *plVar13 = lVar8;
                      il2cpp_internal(plVar13,lVar8);
                    }
                    TweenSettingsExtensions.OnComplete(uVar9,lVar8,DAT_181d96ee8);
                    if (((*plVar6 == 0) || (lVar8 = GameObject.get_transform(*plVar6,0)) == null) ||
                       (lVar8 = Component.GetComponent(lVar8,DAT_181d6b0c0)) == null)
                    throw; // [null/range check failed]
                    CanvasGroup.set_alpha(lVar8);
                    if ((*plVar6 == 0) || (lVar8 = GameObject.get_transform(*plVar6,0)) == null)
                    throw; // [null/range check failed]
                    uVar9 = Component.GetComponent(lVar8,DAT_181d6b0c0);
                    uVar9 = DOTweenModuleUI.DOFade(uVar9);
                    TweenSettingsExtensions.SetDelay(uVar9,(float)local_res8[0] + 1.0,DAT_181d97868);
                    if ((*plVar6 == 0) ||
                       (plVar13 = (int64 *)GameObject.GetComponent(*plVar6,DAT_181d9fe50),
                       plVar13 == (int64 *)0)) throw; // [null/range check failed]
                    (**(code **)(*plVar13 + 0x2c8))(plVar13,0,*(uint64 *)(*plVar13 + 0x2d0));
                    if ((*plVar6 == 0) ||
                       (lVar8 = GameObject.GetComponent(*plVar6,DAT_181d9ee60)) == null)
                    throw; // [null/range check failed]
                    Selectable.set_interactable(lVar8,0,0);
                    lVar8 = FUN_18046c600(0);
                    if (lVar8 == null) throw; // [null/range check failed]
                    uVar17 = CONCAT44(uVar18,0xffffffff);
                    uVar11 = CONCAT44(uVar5,0x3fc00000);
                    uVar9 = BreakThroughController.ShowItemParticle
                                      (this,*(uint64 *)(lVar8 + 128),*plVar6,
                                       (float)local_res8[0] + 1.0,uVar11,uVar17,0);
                    uVar5 = (uint32)((uint64)uVar11 >> 32);
                    uVar18 = (uint32)((uint64)uVar17 >> 32);
                    FUN_180d837c0(this,uVar9,0);
                    lVar8 = FUN_18046c600(0);
                    if (lVar8 == null) throw; // [null/range check failed]
                    uVar17 = CONCAT44(uVar18,0xffffffff);
                    uVar11 = CONCAT44(uVar5,0x3fc00000);
                    uVar9 = BreakThroughController.ShowItemParticle
                                      (this,*(uint64 *)(lVar8 + 136),*plVar6,
                                       (float)local_res8[0] + 1.0,uVar11,uVar17,0);
                    uVar5 = (uint32)((uint64)uVar11 >> 32);
                    uVar18 = (uint32)((uint64)uVar17 >> 32);
                    FUN_180d837c0(this,uVar9,0);
                    lVar8 = FUN_18046c600(0);
                    if (lVar8 == null) throw; // [null/range check failed]
                    uVar9 = CONCAT44(uVar18,0xffffffff);
                    uVar16 = CONCAT44(uVar5,0x3fc00000);
                    BreakThroughController.ShowItemParticle
                              (this,*(uint64 *)(lVar8 + 152),*plVar6,(float)local_res8[0] + 1.2,
                               uVar16,uVar9,0);
                    uVar5 = (uint32)((uint64)uVar9 >> 32);
                    FUN_180d837c0(this);
                    if (4 < iVar2) {
                      uVar18 = (uint32)(uVar16 >> 32);
                      lVar8 = FUN_18046c600(0);
                      if (lVar8 == null) throw; // [null/range check failed]
                      uVar16 = CONCAT44(uVar18,0x3fc00000);
                      BreakThroughController.ShowItemParticle
                                (this,*(uint64 *)(lVar8 + 144),*plVar6,(float)local_res8[0] + 1.0,
                                 uVar16,CONCAT44(uVar5,0xffffffff),0);
                      FUN_180d837c0(this);
                    }
                    iVar4 = local_res8[0] + 1;
                    local_res8[0] = iVar4;
                    iVar2 = BreakThroughController.ChoiceNum(this);
                  } while (iVar4 < iVar2);
                }
                iVar2 = BreakThroughController.ChoiceNum(this,0);
                MonoBehaviour.Invoke(this,"SetAllBreakChoiceAvailable",(float)iVar2 + 1.0,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000D7F
    // RVA   : 0xCECB50   Offset: 0xCEB350   Length: 0x4AB
    public void SetAllBreakChoiceAvailable()
    {
        int iVar1;
        uint uVar2;
        long lVar3;
        ulong uVar5;
        ulong uVar6;
        ulong uVar7;
        int iVar8;
        int[] local_res8 = new int[2];
        ulong local_48;
        ulong uStack_40;
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        if (((this.breakThroughPanel != null) &&
            (lVar3 = GameObject.get_transform(this.breakThroughPanel,0)) != null) &&
           (lVar3 = Transform.Find(lVar3,"BreakThroughQuestion",0)) != null) {
          lVar3 = Component.get_gameObject(lVar3,0);
          if (lVar3 != null) {
            GameObject.SetActive(lVar3,1,0);
            if (((this.breakThroughPanel != null) &&
                (lVar3 = GameObject.get_transform(this.breakThroughPanel,0)) != null) &&
               (lVar3 = Transform.Find(lVar3,"BreakThroughQuestion",0)) != null) {
              plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181d6d8c0);
              local_48 = 0;
              uStack_40 = 0;
              FUN_1809981e0(&local_48,0x3f800000,0x3f800000,0x3f800000,0,0);
              if (plVar4 != (int64 *)0) {
                local_38 = (uint32)local_48;
                uStack_34 = local_48._4_4_;
                uStack_30 = (uint32)uStack_40;
                uStack_2c = uStack_40._4_4_;
                (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_38,*(uint64 *)(*plVar4 + 0x2b0));
                if (((this.breakThroughPanel != null) &&
                    (lVar3 = GameObject.get_transform(this.breakThroughPanel,0)) != null) &&
                   (lVar3 = Transform.Find(lVar3,"BreakThroughQuestion",0)) != null) {
                  uVar5 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                  uVar5 = DOTweenModuleUI.DOFade(uVar5,0x3f800000,0x3e4ccccd,0);
                  TweenSettingsExtensions.SetUpdate(uVar5,1,DAT_181d98958);
                  if (((this.breakThroughPanel != null) &&
                      (lVar3 = GameObject.get_transform(this.breakThroughPanel,0)) != null) &&
                     (lVar3 = Transform.Find(lVar3,"BreakThroughQuestion",0)) != null) {
                    uVar5 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                    if (this.targetSkill != null) {
                      iVar1 = KungfuSkillLvData.Type(this.targetSkill,0);
                      uVar7 = "♦突破加成仅作用于该武学之上\n♦{0}";
                      uVar6 = "外功的突破加成仅在战斗中使用时生效";
                      if (2 < iVar1) {
        LAB_180cece5b:
                        uVar7 = String.Format(uVar7,uVar6,0);
                        LTLocalization.SetText(uVar5,uVar7,0);
                        local_res8[0] = 0;
                        iVar1 = BreakThroughController.ChoiceNum(this,0);
                        if (0 < iVar1) {
                          do {
                            if (this.breakThroughPos == null) goto LAB_180cecff6;
                            lVar3 = GameObject.get_transform(this.breakThroughPos,0);
                            uVar5 = Int32.ToString(local_res8,0);
                            if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,uVar5,0)) == null) ||
                               ((lVar3 = Transform.GetChild(lVar3,0,0), lVar3 == null ||
                                (plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181d6bc40),
                                plVar4 == (int64 *)0)))) goto LAB_180cecff6;
                            (**(code **)(*plVar4 + 0x2c8))(plVar4,1);
                            if (this.breakThroughPos == null) goto LAB_180cecff6;
                            lVar3 = GameObject.get_transform(this.breakThroughPos,0);
                            uVar5 = Int32.ToString(local_res8,0);
                            if ((((lVar3 == null) || (lVar3 = Transform.Find(lVar3,uVar5)) == null) ||
                                (lVar3 = Transform.GetChild(lVar3,0)) == null) ||
                               (lVar3 = Component.GetComponent(lVar3,DAT_181d6af40)) == null)
                            goto LAB_180cecff6;
                            Selectable.set_interactable(lVar3);
                            iVar8 = local_res8[0] + 1;
                            local_res8[0] = iVar8;
                            iVar1 = BreakThroughController.ChoiceNum(this);
                          } while (iVar8 < iVar1);
                        }
                        return;
                      }
                      lVar3 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x498);
                      if (this.targetSkill != null) {
                        uVar2 = KungfuSkillLvData.Type(this.targetSkill,0);
                        if (lVar3 != null) {
                          if (*(uint32 *)(lVar3 + 24) <= uVar2) {
                            ThrowHelper.ThrowArgumentOutOfRangeException(0);
                          }
                          uVar6 = String.Format("{0}的突破加成在装备后生效",
                                                 *(uint64 *)
                                                  (*(int64 *)(lVar3 + 16) + 32 +
                                                  (int64)(int)uVar2 * 8),0);
                          goto LAB_180cece5b;
                        }
                      }
        LAB_180cecff6:
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000D80
    // RVA   : 0xCED4B0   Offset: 0xCEBCB0   Length: 0xAC
    public IEnumerator ShowItemParticle(GameObject targetParticle, GameObject targetItemIcon, float delayTime, float scale, int rareLv)
    {
        int64 BreakThroughController.ShowItemParticle
                         (uint64 this,uint64 targetParticle,uint64 targetItemIcon,uint32 delayTime,
                         uint32 scale,uint32 rareLv)
        {
        int64 lVar1;
        var lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 48) = targetParticle;
          *(uint64 *)(lVar1 + 40) = targetItemIcon;
          *(uint32 *)(lVar1 + 60) = rareLv;
          *(uint32 *)(lVar1 + 32) = delayTime;
          *(uint32 *)(lVar1 + 56) = scale;
          return lVar1;
        }
    }

    // Token : 0x6000D81
    // RVA   : 0xCEAA30   Offset: 0xCE9230   Length: 0x55B
    public void BreakThroughChoiceClicked(BreakThroughChoiceController targetChoice)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        long lVar6;
        ulong uVar7;
        ulong uVar8;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        if (this.breakThroughPos != null) {
          lVar3 = GameObject.get_transform(this.breakThroughPos,0);
          if (lVar3 != null) {
            lVar3 = Transform.Find(lVar3,"Background",0);
            if (lVar3 != null) {
              lVar3 = Component.get_gameObject(lVar3,0);
              if (lVar3 != null) {
                GameObject.SetActive(lVar3,0,0);
                if (this.breakThroughPanel != null) {
                  lVar3 = GameObject.get_transform(this.breakThroughPanel,0);
                  if (lVar3 != null) {
                    lVar3 = Transform.Find(lVar3,"BreakThroughQuestion",0);
                    if (lVar3 != null) {
                      lVar3 = Component.get_gameObject(lVar3,0);
                      if (lVar3 != null) {
                        GameObject.SetActive(lVar3,0,0);
                        if (this.targetSkillSlot != null) {
                          lVar3 = GameObject.get_transform(this.targetSkillSlot,0);
                          if (this.breakThroughPanel != null) {
                            lVar4 = GameObject.get_transform(this.breakThroughPanel,0);
                            if (lVar4 != null) {
                              lVar4 = Transform.Find(lVar4,"Book",0);
                              if (lVar4 != null) {
                                uVar2 = Transform.GetSiblingIndex(lVar4,0);
                                if (lVar3 != null) {
                                  Transform.SetSiblingIndex(lVar3,uVar2,0);
                                  if (this.targetSkillSlot != null) {
                                    lVar3 = GameObject.get_transform(this.targetSkillSlot,0);
                                    puVar5 = (uint64 *)Vector3.get_zero(local_18,0);
                                    if (lVar3 != null) {
                                      local_20 = *(uint32 *)(puVar5 + 1);
                                      local_28 = *puVar5;
                                      Transform.set_localPosition(lVar3,&local_28,0);
                                      if (targetChoice != null) {
                                        iVar1 = *(int *)(targetChoice + 48);
                                        if (iVar1 == 0) {
                                          lVar3 = FUN_18046c0a0(0);
                                          if ((lVar3 == null) || (lVar3.equiped == null))
                                          throw; // [null/range check failed]
                                          lVar3 = WorldData.Player(lVar3.equiped,0);
                                          if (lVar3 == null) throw; // [null/range check failed]
                                          HeroData.ChangeExternalInjury(lVar3);
                                        }
                                        else if (iVar1 == 1) {
                                          lVar3 = FUN_18046c0a0(0);
                                          if ((lVar3 == null) || (lVar3.equiped == null))
                                          throw; // [null/range check failed]
                                          lVar3 = WorldData.Player(lVar3.equiped,0);
                                          if (lVar3 == null) throw; // [null/range check failed]
                                          HeroData.ChangeInternalInjury(lVar3);
                                        }
                                        else if (iVar1 == 2) {
                                          lVar3 = FUN_18046c0a0(0);
                                          if ((lVar3 == null) || (lVar3.equiped == null))
                                          throw; // [null/range check failed]
                                          lVar3 = WorldData.Player(lVar3.equiped,0);
                                          if (lVar3 == null) throw; // [null/range check failed]
                                          HeroData.ChangePoisonInjury(lVar3);
                                        }
                                        if (this.targetSkill != null) {
                                          KungfuSkillLvData.ChangeExtraAddData
                                                    (this.targetSkill,
                                                     *(uint64 *)(targetChoice + 40),1,0);
                                          if ((*pStatics != 0) &&
                                             (lVar3 = *(int64 *)
                                                       (*pStatics + 32),
                                             lVar3 != null)) {
                                            lVar3 = WorldData.Player(lVar3,0);
                                            if (lVar3 != null) {
                                              HeroData.UpgradeSkill
                                                        (lVar3,this.targetSkill,0);
                                              lVar3 = this.targetSkill;
                                              lVar4 = **(int64 **)(DAT_181d7f230 + 184);
                                              if (lVar3 != null) {
                                                lVar6 = KungfuSkillLvData.DataBase(lVar3,0);
                                                if (lVar6 != null) {
                                                  uVar7 = KungfuSkillData.Name(lVar6,0,0);
                                                  if (this.targetSkill != null) {
                                                    uVar2 = *(uint32 *)
                                                             (this.targetSkill + 20);
                                                    uVar8 = GlobalData.GetNumText(uVar2,0);
                                                    uVar7 = String.Format("{0}突破至第{1}重！",uVar7,uVar8,0);
                                                    if (lVar4 != null) {
                                                      SpeShowController.ShowGetSkill(lVar4,lVar3,uVar7,0)
                                                      ;
                                                      BreakThroughController.UnshowBreakThroughPanel
                                                                (this,0);
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
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000D82
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6000D83
    // RVA   : 0xCEF5D0   Offset: 0xCEDDD0   Length: 0x76
    private static void /*cctor*/()
    {
        ulong uVar2;
        uVar2 = il2cpp_internal(DAT_181d5bdc8);
        FUN_1808ae540(uVar2,DAT_181d91a40);
        puVar1 = *(uint64 **)(DAT_181d8e338 + 184);
        *puVar1 = uVar2;
        il2cpp_internal(puVar1,uVar2);
    }

}
