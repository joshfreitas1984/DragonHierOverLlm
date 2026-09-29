// ============================================================
// Type  : ResearchUIController
// Token : 0x2000347
// ============================================================

public class ResearchUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B1D
    public ResearchUIType researchUIType;

    // Token: 0x4001B1E
    public GameObject researchUI;

    // Token: 0x4001B1F
    public GameObject researchTechPrefab;

    // Token: 0x4001B20
    public ForceData targetForce;

    // Token: 0x4001B21
    public List<GameObject> researchTechObj;

    // Token: 0x4001B22
    public GameObject nowResearchObj;

    // Token: 0x4001B23
    public GameObject researchTechListIconPrefab;

    // Token: 0x4001B24
    public GameObject researchTechListGrid;

    // Token: 0x4001B25
    public GameObject researchTechListNum;

    // Token: 0x4001B26
    public GameObject cancelNowResearchButton;

    // Token: 0x4001B27
    public static int ManageResearchMinForceLv;

    // Token: 0x4001B28
    private GameObject temp;

    // Token: 0x4001B29
    private static ResearchUIController _instance;

    // Token: 0x4001B2A
    private bool inited;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60020B1
    // RVA   : 0xD15DD0   Offset: 0xD151D0   Length: 0x58
    public static ResearchUIController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d9c598 + 184) + 8);
    }

    // Token : 0x60020B2
    // RVA   : 0xD141A0   Offset: 0xD135A0   Length: 0x68
    private void Awake()
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d9c598 + 184) + 8);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60020B3
    // RVA   : 0xD14410   Offset: 0xD13810   Length: 0x3B9
    public void Init()
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        uint local_40;
        uint32 uStack_3c;
        uint32 uStack_38;
        uint32 uStack_34;
        int64 local_30;
        uint32 local_28;
        uint32 uStack_24;
        uint32 uStack_20;
        uint32 uStack_1c;
        int64 local_18;
        this.inited = 1;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 32);
        if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 160)) != null) {
          lVar2 = FUN_1808ae5b0(lVar2,DAT_181db9b30);
          if (lVar2 != null) {
            ValueCollection.GetEnumerator(&local_28,lVar2,DAT_181d7e708);
            local_40 = local_28;
            uStack_3c = uStack_24;
            uStack_38 = uStack_20;
            uStack_34 = uStack_1c;
            local_30 = local_18;
            while( true ) {
              cVar1 = FUN_1811c4590(&local_40,DAT_181d98470);
              lVar2 = local_30;
              if (!cVar1) break;
              if (this.researchUI == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar3 = GameObject.get_transform(this.researchUI,0);
              if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar3 = Transform.Find(lVar3,"Tech",0);
              if (lVar2 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar4 = Int32.ToString(lVar2 + 40,0);
              if (lVar3 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar2 = Transform.Find(lVar3,uVar4,0);
              if (lVar2 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar2 = Transform.Find(lVar2,"Viewport",0);
              if (lVar2 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar2 = Transform.Find(lVar2,"Content",0);
              if (lVar2 == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              uVar5 = Component.get_gameObject(lVar2,0);
              uVar4 = this.researchTechPrefab;
              uVar4 = GlobalData.AddChild(uVar5,uVar4,0);
              this.temp = uVar4;
              if (this.researchTechObj == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              FUN_18181e6b0(this.researchTechObj,this.temp);
            }
            ZhSegment.Initialize(&local_40,DAT_181d983f0);
            if (this.researchUI != null) {
              lVar2 = GameObject.get_transform(this.researchUI,0);
              if (lVar2 != null) {
                lVar2 = Transform.Find(lVar2,"NowResearch",0);
                if (lVar2 != null) {
                  uVar5 = Component.get_gameObject(lVar2,0);
                  uVar4 = this.researchTechPrefab;
                  uVar4 = GlobalData.AddChild(uVar5,uVar4,0);
                  this.nowResearchObj = uVar4;
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x60020B4
    // RVA   : 0x8CBD70   Offset: 0x8CB170   Length: 0x20
    public void HideResearchUI()
    {
        if (this.researchUI != null) {
          GameObject.SetActive(this.researchUI,0,0);
          return;
        }
    }

    // Token : 0x60020B5
    // RVA   : 0xD15560   Offset: 0xD14960   Length: 0x66C
    public void ShowResearchUI(ResearchUIType _researchUIType, ForceData _targetForce)
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        uint uVar7;
        float fVar9;
        float[] local_res8 = new float[2];
        if (!this.inited) {
          ResearchUIController.Init(this,0);
        }
        if (this.researchUI == null) throw; // [null/range check failed]
        GameObject.SetActive(this.researchUI,1,0);
        this.researchUIType = _researchUIType;
        this.targetForce = _targetForce;
        if (((this.researchUI == null) ||
            (lVar2 = GameObject.get_transform(this.researchUI,0)) == null) ||
           (lVar2 = Transform.Find(lVar2,"ResearchSpeed",0)) == null) throw; // [null/range check failed]
        uVar3 = Component.GetComponent(lVar2,DAT_181d96178);
        if ((this.targetForce == null) ||
           (lVar2 = this.targetForce.forceSpeAddData) == null) throw; // [null/range check failed]
        fVar9 = (float)ForceSpeAddData.Get(lVar2,4);
        local_res8[0] = (fVar9 + 1.0) * 100.0;
        uVar4 = Single.ToString(local_res8,"f0",0);
        uVar4 = String.Format("研究速率 {0}%",uVar4,0);
        LTLocalization.SetText(uVar3,uVar4,0);
        if (((GameController._instance == null) ||
            (lVar2 = GameController._instance.worldData) == null) ||
           (lVar2 = WorldData.Player(lVar2,0)) == null) throw; // [null/range check failed]
        if (!lVar2.hour) {
        LAB_180d1598f:
          if (((this.researchUI == null) ||
              (lVar2 = GameObject.get_transform(this.researchUI,0)) == null) ||
             ((lVar2 = Transform.Find(lVar2,"AutoResearch",0), lVar2 == null ||
              (lVar2 = Component.get_gameObject(lVar2,0)) == null))) throw; // [null/range check failed]
          GameObject.SetActive(lVar2,0,0);
        }
        else {
          if ((((GameController._instance == null) ||
               (lVar2 = GameController._instance.worldData) == null) ||
              (lVar2 = WorldData.Player(lVar2,0)) == null) || (this.targetForce == null))
          throw; // [null/range check failed]
          if (lVar2.totalPopulation != this.targetForce.forceID)
          goto LAB_180d1598f;
          if (((this.researchUI == null) ||
              (lVar2 = GameObject.get_transform(this.researchUI,0)) == null) ||
             (lVar2 = Transform.Find(lVar2,"AutoResearch",0)) == null) throw; // [null/range check failed]
          lVar2 = Component.get_gameObject(lVar2,0);
          if (lVar2 == null) throw; // [null/range check failed]
          GameObject.SetActive(lVar2,1,0);
          if (((this.researchUI == null) ||
              (lVar2 = GameObject.get_transform(this.researchUI,0)) == null) ||
             (lVar2 = Transform.Find(lVar2,"AutoResearch",0)) == null) throw; // [null/range check failed]
          lVar2 = Component.GetComponent(lVar2,DAT_181d962f8);
          lVar5 = FUN_18046c0a0(0);
          if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) || (lVar2 == null)) throw; // [null/range check failed]
          Toggle.set_isOn(lVar2,*(uint8 *)(*(int64 *)(lVar5 + 32) + 0x240),0);
        }
        lVar2 = this.targetForce;
        plVar8 = (int64 *)0;
        if (lVar2 != null) {
          lVar5 = 32;
          plVar6 = plVar8;
          while (lVar2.techLvData != null) {
            uVar7 = (uint32)plVar6;
            if (*(int *)(lVar2.techLvData + 24) <= (int)uVar7) {
              ResearchUIController.RefreshNowResearch(this,0);
              ResearchUIController.RefreshResearchTechList(this,0);
              plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/OpenBook",0);
              if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181daf360)) {
                plVar8 = plVar6;
              }
              NGUITools.PlaySound(plVar8,0);
              return;
            }
            lVar2 = this.researchTechObj;
            if (lVar2 == null) break;
            if (lVar2.forceName <= uVar7) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = *(int64 *)(lVar5 + lVar2.forceID);
            if (lVar2 == null) break;
            lVar2 = GameObject.GetComponent(lVar2,DAT_181d72de8);
            if ((this.targetForce == null) ||
               (lVar1 = this.targetForce.techLvData) == null) break;
            if (*(uint32 *)(lVar1 + 24) <= uVar7) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar2 == null) break;
            lVar2.forceName = *(uint64 *)(lVar5 + *(int64 *)(lVar1 + 16));
            lVar2 = this.researchTechObj;
            if (lVar2 == null) break;
            if (lVar2.forceName <= uVar7) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = *(int64 *)(lVar5 + lVar2.forceID);
            if ((lVar2 == null) || (lVar2 = GameObject.GetComponent(lVar2,DAT_181d72de8)) == null)
            break;
            ResearchTechController.Refresh(lVar2,0);
            lVar2 = this.targetForce;
            plVar6 = (int64 *)(uint64)(uVar7 + 1);
            lVar5 = lVar5 + 8;
            if (lVar2 == null) break;
          }
        }
    }

    // Token : 0x60020B6
    // RVA   : 0xD14C40   Offset: 0xD14040   Length: 0x18D
    public void RefreshUI()
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        long lVar4;
        lVar2 = this.targetForce;
        uVar3 = 0;
        if (lVar2 != null) {
          lVar4 = 32;
          while (lVar2.techLvData != null) {
            if (*(int *)(lVar2.techLvData + 24) <= (int)uVar3) {
              ResearchUIController.RefreshNowResearch(this,0);
              ResearchUIController.RefreshResearchTechList(this,0);
              return;
            }
            lVar2 = this.researchTechObj;
            if (lVar2 == null) break;
            if (lVar2.forceName <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = *(int64 *)(lVar4 + lVar2.forceID);
            if (lVar2 == null) break;
            lVar2 = GameObject.GetComponent(lVar2,DAT_181d72de8);
            if ((this.targetForce == null) ||
               (lVar1 = this.targetForce.techLvData) == null) break;
            if (*(uint32 *)(lVar1 + 24) <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar2 == null) break;
            lVar2.forceName = *(uint64 *)(lVar4 + *(int64 *)(lVar1 + 16));
            lVar2 = this.researchTechObj;
            if (lVar2 == null) break;
            if (lVar2.forceName <= uVar3) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if ((*(int64 *)(lVar4 + lVar2.forceID) == 0) ||
               (lVar2 = GameObject.GetComponent()) == null) break;
            ResearchTechController.Refresh(lVar2);
            lVar2 = this.targetForce;
            uVar3 = uVar3 + 1;
            lVar4 = lVar4 + 8;
            if (lVar2 == null) break;
          }
        }
    }

    // Token : 0x60020B7
    // RVA   : 0xD147D0   Offset: 0xD13BD0   Length: 0xD8
    public void RefreshNowResearch()
    {
        long lVar1;
        ulong uVar2;
        long lVar3;
        if (this.nowResearchObj != null) {
          lVar1 = GameObject.GetComponent(this.nowResearchObj,DAT_181d72de8);
          if (this.targetForce != null) {
            uVar2 = ForceData.GetNowResearchTech(this.targetForce,0);
            if (lVar1 != null) {
              *(uint64 *)(lVar1 + 24) = uVar2;
              if (this.nowResearchObj != null) {
                lVar1 = GameObject.GetComponent(this.nowResearchObj,DAT_181d72de8);
                if (lVar1 != null) {
                  ResearchTechController.Refresh(lVar1,0);
                  lVar1 = this.cancelNowResearchButton;
                  if (this.researchUIType == 1) {
                    if (this.targetForce == null) throw; // [null/range check failed]
                    lVar3 = ForceData.GetNowResearchTech(this.targetForce,0);
                    bVar4 = lVar3 != null;
                  }
                  else {
                    bVar4 = false;
                  }
                  if (lVar1 != null) {
                    GameObject.SetActive(lVar1,bVar4,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60020B8
    // RVA   : 0xD14070   Offset: 0xD13470   Length: 0x122
    public void AutoResearchButtonClicked()
    {
        long lVar1;
        long lVar2;
        if (GameController._instance != null) {
          lVar1 = GameController._instance.worldData;
          if (this.researchUI != null) {
            lVar2 = GameObject.get_transform(this.researchUI,0);
            if (lVar2 != null) {
              lVar2 = Transform.Find(lVar2,"AutoResearch",0);
              if (lVar2 != null) {
                lVar2 = Component.GetComponent(lVar2,DAT_181d962f8);
                if ((lVar2 != null) && (lVar1 != null)) {
                  lVar1.autoResearch = *(uint8 *)(lVar2 + 0x118);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x60020B9
    // RVA   : 0xD148B0   Offset: 0xD13CB0   Length: 0x380
    public void RefreshResearchTechList()
    {
        ulong uVar1;
        long lVar2;
        uint uVar3;
        long lVar4;
        ulong uVar6;
        int iVar7;
        uint[] local_res8 = new uint[2];
        lVar4 = this.researchTechListNum;
        if (this.researchUIType != null) {
          if (((lVar4 != null) && (lVar4 = GameObject.get_transform(lVar4,0)) != null) &&
             ((lVar4 = FUN_180daa030(lVar4,0), lVar4 != null &&
              (lVar4 = Component.get_gameObject(lVar4,0)) != null))) {
            GameObject.SetActive(lVar4,1,0);
            if (this.researchTechListNum != null) {
              plVar5 = (int64 *)GameObject.GetComponent(this.researchTechListNum,DAT_181d74108);
              if ((this.targetForce != null) &&
                 (lVar4 = this.targetForce.reasearchTechList) != null) {
                local_res8[0] = lVar4.forceName;
                uVar6 = il2cpp_value_box(DAT_181d80430,local_res8);
                uVar6 = String.Format("研究队列 {0}/8",uVar6,0);
                if (plVar5 != (int64 *)0) {
                  (**(code **)(*plVar5 + 0x5e8))(plVar5,uVar6,*(uint64 *)(*plVar5 + 0x5f0));
                  uVar6 = this.researchTechListGrid;
                  GlobalData.DeleteAllChild(uVar6,0);
                  lVar4 = this.targetForce;
                  iVar7 = 0;
                  if (lVar4 != null) {
                    while (lVar4.reasearchTechList != null) {
                      if (*(int *)(lVar4.reasearchTechList + 24) <= iVar7) {
                        return;
                      }
                      uVar6 = this.researchTechListGrid;
                      uVar1 = this.researchTechListIconPrefab;
                      uVar6 = GlobalData.AddChild(uVar6,uVar1,0);
                      this.temp = uVar6;
                      if (((this.temp == null) ||
                          (lVar4 = GameObject.get_transform(this.temp,0)) == null
                          ) || (lVar4 = Transform.Find(lVar4,"Text",0)) == null) break;
                      plVar5 = (int64 *)Component.GetComponent(lVar4,DAT_181d96178);
                      lVar4 = this.targetForce;
                      if (lVar4 == null) break;
                      lVar2 = lVar4.techLvData;
                      if (((lVar4.reasearchTechList == null) ||
                          (uVar3 = FUN_1800d6760(lVar4.reasearchTechList,iVar7,DAT_181d8fa30),
                          lVar2 == null)) ||
                         ((lVar4 = FUN_180002f80(lVar2,uVar3,DAT_181d88bb0), lVar4 == null ||
                          ((lVar4 = ForceTechLvData.Database(lVar4,0), lVar4 == null ||
                           (plVar5 == (int64 *)0)))))) break;
                      (**(code **)(*plVar5 + 0x5e8))(plVar5,lVar4.forceName);
                      if ((this.temp == null) ||
                         (lVar4 = GameObject.GetComponent(this.temp,DAT_181d72e70),
                         lVar4 == null)) break;
                      lVar4.forceName = iVar7;
                      iVar7 = iVar7 + 1;
                      lVar4 = this.targetForce;
                      if (lVar4 == null) break;
                    }
                  }
                  throw; // [null/range check failed]
                }
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if ((((lVar4 != null) && (lVar4 = GameObject.get_transform(lVar4,0)) != null) &&
            (lVar4 = FUN_180daa030(lVar4,0)) != null) &&
           (lVar4 = Component.get_gameObject(lVar4,0)) != null) {
          GameObject.SetActive(lVar4,0,0);
          return;
        }
    }

    // Token : 0x60020BA
    // RVA   : 0xD14DD0   Offset: 0xD141D0   Length: 0xD6
    public void RemoveResearchList(int techListID)
    {
        long lVar1;
        if ((this.targetForce != null) &&
           (lVar1 = this.targetForce.reasearchTechList) != null) {
          FUN_1817ef380(lVar1,techListID,DAT_181d8f730);
          plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/PaperQuick",0);
          plVar3 = (int64 *)0;
          if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181daf360)) {
            plVar3 = plVar2;
          }
          NGUITools.PlaySound(plVar3,0);
          ResearchUIController.RefreshResearchTechList(this,0);
          return;
        }
    }

    // Token : 0x60020BB
    // RVA   : 0xD14EB0   Offset: 0xD142B0   Length: 0x319
    public void ResearchTechClicked(ForceTechLvData targetLvData)
    {
        int iVar1;
        int iVar2;
        long lVar3;
        ulong uVar6;
        uint uVar8;
        int iVar9;
        long lVar10;
        if (targetLvData == null) {
          return;
        }
        lVar3 = this.targetForce;
        if (lVar3 != null) {
          if (lVar3.nowResearchTech < 0) {
            ResearchUIController.SetNowReseach(this,targetLvData,0);
            return;
          }
          if (lVar3.reasearchTechList != null) {
            if (*(int *)(lVar3.reasearchTechList + 24) < 8) {
              if (!DAT_181e9e917) {
                il2cpp_runtime_class_init(&DAT_181d8f9b0);
                il2cpp_runtime_class_init(&DAT_181d8fa30);
                lVar3 = this.targetForce;
                DAT_181e9e917 = true;
              }
              if (lVar3 != null) {
                iVar9 = *(int *)(targetLvData + 16);
                uVar8 = 0;
                iVar1 = *(int *)(targetLvData + 20) + 1;
                if (lVar3.nowResearchTech != iVar9) {
                  iVar1 = *(int *)(targetLvData + 20);
                }
                lVar10 = 32;
                do {
                  if ((lVar3.reasearchTechList == null) || (lVar3 == null)) break;
                  if (*(int *)(lVar3.reasearchTechList + 24) <= (int)uVar8) {
                    if (iVar1 < lVar3.forceLv) {
                      if (lVar3.reasearchTechList == null) break;
                      FUN_18182a6c0(lVar3.reasearchTechList,iVar9,DAT_181d8f230);
                      ResearchUIController.RefreshResearchTechList(this,0);
                      uVar6 = "Sound/SoundEffect/PencilWriting";
                    }
                    else {
                      lVar3 = FUN_18046c0a0(0);
                      if (lVar3 == null) break;
                      GameController.ShowTextOnMouse(lVar3,"需要升级门派正厅！",0);
                      uVar6 = "Sound/SoundEffect/WrongClick";
                    }
                    plVar4 = (int64 *)Resources.Load(uVar6,0);
                    goto LAB_180d15114;
                  }
                  lVar3 = lVar3.reasearchTechList;
                  if (lVar3 == null) break;
                  if (lVar3.forceName <= uVar8) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  iVar9 = *(int *)(targetLvData + 16);
                  piVar5 = (int *)(lVar3.forceID + lVar10);
                  lVar3 = this.targetForce;
                  uVar8 = uVar8 + 1;
                  lVar10 = lVar10 + 4;
                  iVar2 = iVar1 + 1;
                  if (*piVar5 != iVar9) {
                    iVar2 = iVar1;
                  }
                  iVar1 = iVar2;
                } while (lVar3 != null);
              }
            }
            else {
              lVar3 = FUN_18046c0a0(0);
              if (lVar3 != null) {
                GameController.ShowTextOnMouse(lVar3,"研究队列已满！",0);
                plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
        LAB_180d15114:
                plVar7 = (int64 *)0;
                if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181daf360)) {
                  plVar7 = plVar4;
                }
                NGUITools.PlaySound(plVar7,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60020BC
    // RVA   : 0xD14310   Offset: 0xD13710   Length: 0xFD
    public int GetResearchTargetLv(ForceTechLvData targetLvData)
    {
        int iVar1;
        int iVar2;
        long lVar4;
        uint uVar5;
        long lVar6;
        if (targetLvData != null) {
          lVar4 = this.targetForce;
          if (lVar4 != null) {
            uVar5 = 0;
            iVar1 = *(int *)(targetLvData + 20) + 1;
            if (lVar4.nowResearchTech != *(int *)(targetLvData + 16)) {
              iVar1 = *(int *)(targetLvData + 20);
            }
            lVar6 = 32;
            while (lVar4.reasearchTechList != null) {
              if (*(int *)(lVar4.reasearchTechList + 24) <= (int)uVar5) {
                return iVar1;
              }
              if ((lVar4 = lVar4?.reasearchTechList) == null) break;
              if (lVar4.forceName <= uVar5) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              piVar3 = (int *)(lVar4.forceID + lVar6);
              uVar5 = uVar5 + 1;
              lVar4 = this.targetForce;
              lVar6 = lVar6 + 4;
              iVar2 = iVar1 + 1;
              if (*piVar3 != *(int *)(targetLvData + 16)) {
                iVar2 = iVar1;
              }
              iVar1 = iVar2;
              if (lVar4 == null) break;
            }
          }
        }
    }

    // Token : 0x60020BD
    // RVA   : 0xD151D0   Offset: 0xD145D0   Length: 0x38F
    public void SetNowReseach(ForceTechLvData targetLvData)
    {
        bool cVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        ulong uVar6;
        long lVar7;
        if ((targetLvData == null) || (lVar7 = this.targetForce) == null) throw; // [null/range check failed]
        if (*(int *)(targetLvData + 20) < *(int *)(lVar7 + 52)) {
          uVar2 = ForceTechLvData.GetResearchCostResource(targetLvData,0x3f800000,0);
          cVar1 = ForceData.HaveResource(lVar7,uVar2,0);
          if (cVar1) {
            lVar7 = **(int64 **)(DAT_181da8728 + 184);
            lVar3 = ForceTechLvData.Database(targetLvData,0);
            if (lVar3 != null) {
              uVar2 = *(uint64 *)(lVar3 + 24);
              lVar3 = ForceTechLvData.GetResearchCostResource(targetLvData,0x3f800000,0);
              if (lVar3 != null) {
                uVar4 = ResourceData.GetDescribe(lVar3,0);
                if (this.targetForce != null) {
                  lVar3 = ForceData.GetNowResearchTech(this.targetForce,0);
                  uVar6 = "确认研究[{0}]科技？\n将消耗门派{1}。{2}";
                  uVar5 = "";
                  if (lVar3 != null) {
                    if (((this.targetForce == null) ||
                        (lVar3 = ForceData.GetNowResearchTech(this.targetForce,0),
                        lVar3 == null)) || (lVar3 = ForceTechLvData.Database(lVar3,0)) == null)
                    throw; // [null/range check failed]
                    uVar5 = String.Format("\n(当前[{0}]研究将会中断，\n进度保留但消耗资源不返还！)",*(uint64 *)(lVar3 + 24),0);
                  }
                  uVar2 = String.Format(uVar6,uVar2,uVar4,uVar5,0);
                  uVar4 = Int32.ToString(targetLvData + 16,0);
                  uVar6 = Component.get_gameObject(this,0);
                  if (lVar7 != null) {
                    SureMenu.CallSureMenu(lVar7,uVar2,"SureSetNowResearch",uVar4,uVar6,1,0,0,0,0);
                    return;
                  }
                }
              }
            }
            throw; // [null/range check failed]
          }
          lVar7 = FUN_18046c0a0(0);
          uVar2 = "资源不足！";
        }
        else {
          lVar7 = GameController._instance;
          uVar2 = "需要升级门派正厅！";
        }
        if (lVar7 != null) {
          GameController.ShowTextOnMouse(lVar7,uVar2,0);
          plVar8 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
          plVar9 = (int64 *)0;
          if ((plVar8 != (int64 *)0) && (*plVar8 == DAT_181daf360)) {
            plVar9 = plVar8;
          }
          NGUITools.PlaySound(plVar9,0);
          return;
        }
    }

    // Token : 0x60020BE
    // RVA   : 0xD15C80   Offset: 0xD15080   Length: 0x100
    public void SureSetNowResearch(string param)
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        ulong uVar4;
        uVar3 = Int32.Parse(param,0);
        lVar1 = this.targetForce;
        if ((lVar1 != null) && (lVar2 = lVar1.techLvData) != null) {
          if (*(uint32 *)(lVar2 + 24) <= uVar3) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2[uVar3];
          if (lVar2 != null) {
            uVar4 = ForceTechLvData.GetResearchCostResource(lVar2,0x3f800000,0);
            ForceData.CostResource(lVar1,uVar4,0,0);
            lVar1 = this.targetForce;
            if ((lVar1 != null) && (lVar2 = lVar1.techLvData) != null) {
              if (*(uint32 *)(lVar2 + 24) <= uVar3) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              ForceData.SetNowResearch
                        (lVar1,*(uint64 *)
                                (*(int64 *)(lVar2 + 16) + 32 + (int64)(int)uVar3 * 8),1,0);
              ResearchUIController.RefreshNowResearch(this,0);
              return;
            }
          }
        }
    }

    // Token : 0x60020BF
    // RVA   : 0xD14210   Offset: 0xD13610   Length: 0xFD
    public void CancelNowResearch()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        lVar1 = **(int64 **)(DAT_181da8728 + 184);
        if (this.targetForce != null) {
          lVar2 = ForceData.GetNowResearchTech(this.targetForce,0);
          if (lVar2 != null) {
            lVar2 = ForceTechLvData.Database(lVar2,0);
            if (lVar2 != null) {
              uVar3 = String.Format("确认取消研究[{0}]？\n取消后进度保留，但消耗资源不返还！",*(uint64 *)(lVar2 + 24),0);
              uVar4 = Component.get_gameObject(this,0);
              if (lVar1 != null) {
                SureMenu.CallSureMenu(lVar1,uVar3,"SureCancelNowResearch",0,uVar4,1,0,0,0,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60020C0
    // RVA   : 0xD15BD0   Offset: 0xD14FD0   Length: 0xAF
    public void SureCancelNowResearch()
    {
        if (this.targetForce != null) {
          this.targetForce.nowResearchTech = 0xffffffff;
          ResearchUIController.RefreshNowResearch(this,0);
          plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/PaperQuick",0);
          plVar2 = (int64 *)0;
          if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181daf360)) {
            plVar2 = plVar1;
          }
          NGUITools.PlaySound(plVar2,0);
          return;
        }
    }

    // Token : 0x60020C1
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x60020C2
    // RVA   : 0xD15D90   Offset: 0xD15190   Length: 0x39
    private static void /*cctor*/()
    {
        **(uint32 **)(DAT_181d9c598 + 184) = 3;
    }

}
