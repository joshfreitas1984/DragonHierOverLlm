// ============================================================
// Type  : MeetingController
// Token : 0x2000304
// ============================================================

public class MeetingController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40018D0
    public ForceData targetForce;

    // Token: 0x40018D1
    public MeetingStep meetingStep;

    // Token: 0x40018D2
    public GameObject meetingPanel;

    // Token: 0x40018D3
    public GameObject mainGrid;

    // Token: 0x40018D4
    public GameObject heroGrid;

    // Token: 0x40018D5
    public GameObject mainObj;

    // Token: 0x40018D6
    public GameObject playerObj;

    // Token: 0x40018D7
    public GameObject talkPanel;

    // Token: 0x40018D8
    public int subMeetingStep;

    // Token: 0x40018D9
    public ForceFocusType playerAdviseFocusType;

    // Token: 0x40018DA
    public GameObject lastMonthContributionUIPrefab;

    // Token: 0x40018DB
    public List<GameObject> lastMonthContributionUIs;

    // Token: 0x40018DC
    public List<GameObject> lastMonthContributionHeroList;

    // Token: 0x40018DD
    public GameObject monthMissionPanel;

    // Token: 0x40018DE
    public GameObject monthMissionGrid;

    // Token: 0x40018DF
    public GameObject monthMissionButtonPrefab;

    // Token: 0x40018E0
    public List<MissionData> playerAvailableMissions;

    // Token: 0x40018E1
    public List<GameObject> monthMissionResultUIs;

    // Token: 0x40018E2
    public EventData AttackAreaForceMissionData;

    // Token: 0x40018E3
    private List<string> infoText;

    // Token: 0x40018E4
    private static List<string> ForceLvText;

    // Token: 0x40018E5
    private static List<string> MainFocusText;

    // Token: 0x40018E6
    private GameObject newObj;

    // Token: 0x40018E7
    public AreaData attackTargetArea;

    // Token: 0x40018E8
    public int attackAreaID;

    // Token: 0x40018E9
    public int adviseAttackAreaID;

    // Token: 0x40018EA
    public int hudSiblingIndex;

    // Token: 0x40018EB
    private static MeetingController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001909
    // RVA   : 0xE630D0   Offset: 0xE624D0   Length: 0x58
    public static MeetingController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d88a10 + 184) + 16);
    }

    // Token : 0x600190A
    // RVA   : 0xE57AD0   Offset: 0xE56ED0   Length: 0x11E
    private void Awake()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = MeetingController._instance;
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (!cVar1) {
          uVar2 = Component.get_gameObject(this,0);
          Object.Destroy(uVar2,0);
          return;
        }
        MeetingController._instance = this;
    }

    // Token : 0x600190B
    // RVA   : 0xE61A50   Offset: 0xE60E50   Length: 0x247
    public void SetMeetingEnd()
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong local_18;
        ulong uStack_10;
        if ((GameController._instance != null) &&
           (lVar1 = GameController._instance.worldData) != null) {
          lVar1.forceMeetingStarted = 0;
          lVar1 = **(int64 **)(DAT_181d7f6a8 + 184);
          if ((GameController._instance != null) &&
             (lVar2 = GameController._instance.worldData) != null) {
            lVar2 = WorldData.Player(lVar2,0);
            if (lVar2 != null) {
              lVar2 = HeroData.GetForce(lVar2,0,0);
              if (lVar2 != null) {
                uVar3 = ForceData.GetForceName(lVar2,1,0);
                uVar3 = String.Format("{0}门派会议已结束！",uVar3,0);
                puVar4 = (uint64 *)FUN_1810d33f0(&local_18,0);
                if (lVar1 != null) {
                  local_18 = *puVar4;
                  uStack_10 = puVar4[1];
                  InfoController.AddInfoTab
                            (lVar1,uVar3,"UIAtlas","门派会议","Woosh",0x3f800000,0x40a00000,
                             &local_18,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x600190C
    // RVA   : 0xE57BF0   Offset: 0xE56FF0   Length: 0x3F1
    public void EndMeeting()
    {
        var pStatics_61e8 = *(int64*)(DAT_181d761e8 + 184);
        var pStatics_6ea8 = *(int64*)(DAT_181d76ea8 + 184);
        ulong uVar1;
        bool cVar2;
        long lVar3;
        this.attackAreaID = 0xffffffffffffffff;
        this.meetingStep = 0;
        if (*pStatics_61e8 != 0) {
          HeroLittleTalkController.ClearAll(*pStatics_61e8,0);
          if ((*pStatics_6ea8 != 0) &&
             (lVar3 = Component.get_transform(*pStatics_6ea8,0)) != null) {
            Transform.SetSiblingIndex(lVar3,*(uint32 *)(this + 200),0);
            if (this.meetingPanel != null) {
              GameObject.SetActive(this.meetingPanel,0,0);
              uVar1 = this.mainGrid;
              GlobalData.DeleteAllChild(uVar1,0);
              GlobalData.DeleteAllChild(this.heroGrid,0);
              GlobalData.DestroyAll(this.monthMissionResultUIs,0);
              MeetingController.SetMeetingEnd(this,0);
              plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/终场锣",0);
              plVar5 = (int64 *)0;
              if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181daf348)) {
                plVar5 = plVar4;
              }
              NGUITools.PlaySound(plVar5,0);
              if (((GameController._instance != null) &&
                  (lVar3 = GameController._instance.worldData) != null) &&
                 (lVar3 = lVar3.worldTime) != null) {
                if (lVar3.chapter != 1) {
                  return;
                }
                if (((GameController._instance != null) &&
                    (lVar3 = GameController._instance.worldData) != null) &&
                   (lVar3 = WorldData.Player(lVar3,0)) != null) {
                  if (*(int64 *)(lVar3 + 0x2e0) != 0) {
                    lVar3 = FUN_18046c0a0(0);
                    if (((lVar3 == null) || (lVar3.villageAreaID == null)) ||
                       (lVar3 = *(int64 *)(lVar3.villageAreaID + 216)) == null)
                    throw; // [null/range check failed]
                    cVar2 = FUN_1808ab490(lVar3,47,DAT_181dbf7d8);
                    if (!cVar2) {
                      lVar3 = FUN_18046c0a0(0);
                      if ((lVar3 == null) || (lVar3.villageAreaID == null)) throw; // [null/range check failed]
                      if (*(int *)(lVar3.villageAreaID + 156) == 0) {
                        lVar3 = FUN_18046c400(0);
                        if (lVar3 == null) throw; // [null/range check failed]
                        PlotController.AddPlotDataBase(lVar3,47);
                      }
                    }
                  }
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x600190D
    // RVA   : 0xE624D0   Offset: 0xE618D0   Length: 0x970
    public void StartMeeting()
    {
        var pStatics_2ee8 = *(int64*)(DAT_181d72ee8 + 184);
        var pStatics_61e8 = *(int64*)(DAT_181d761e8 + 184);
        var pStatics_6ea8 = *(int64*)(DAT_181d76ea8 + 184);
        uint uVar1;
        int iVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        uint[] local_res18 = new uint[2];
        int[] local_res20 = new int[2];
        plVar8 = (int64 *)0;
        local_res20[0] = 0;
        if ((GameController._instance != null) &&
           (lVar3 = GameController._instance.worldData) != null) {
          lVar3.forceMeetingMissedTime = 0;
          if ((*pStatics_6ea8 != 0) &&
             (lVar3 = Component.get_transform(*pStatics_6ea8,0)) != null) {
            uVar1 = Transform.GetSiblingIndex(lVar3,0);
            *(uint32 *)(this + 200) = uVar1;
            if (*pStatics_6ea8 != 0) {
              lVar3 = Component.get_transform(*pStatics_6ea8,0);
              if (((this.meetingPanel != null) &&
                  (lVar4 = GameObject.get_transform(this.meetingPanel,0)) != null) &&
                 (uVar1 = Transform.GetSiblingIndex(lVar4,0), lVar3 != null)) {
                Transform.SetSiblingIndex(lVar3,uVar1,0);
                if (this.meetingPanel != null) {
                  GameObject.SetActive(this.meetingPanel,1,0);
                  lVar3 = il2cpp_internal(DAT_181d97750);
                  FUN_18132faf0(lVar3,DAT_181da3bd8);
                  if (lVar3 != null) {
                    FUN_18181e0a0(lVar3,"......",DAT_181da3d58);
                    FUN_18181e0a0(lVar3,"......",DAT_181da3d58);
                    FUN_18181e0a0(lVar3,"......",DAT_181da3d58);
                    this.infoText = lVar3;
                    MeetingController.SetInfoText(this,0);
                    this.meetingStep = 1;
                    this.subMeetingStep = 0;
                    if ((GameController._instance != null) &&
                       (lVar3 = GameController._instance.worldData) != null)
                    {
                      uVar5 = WorldData.GetHeroForce(lVar3,0,0);
                      this.targetForce = uVar5;
                      uVar5 = this.mainGrid;
                      if (*pStatics_2ee8 != 0) {
                        uVar6 = *(uint64 *)(*pStatics_2ee8 + 144);
                        lVar3 = GlobalData.AddChild(uVar5,uVar6,0);
                        this.newObj = lVar3;
                        if (*plVar7 != 0) {
                          lVar3 = GameObject.GetComponent(*plVar7,DAT_181d71b50);
                          if ((this.targetForce != null) &&
                             (uVar5 = ForceData.GetLeader(this.targetForce,0), lVar3 != null))
                          {
                            lVar3.defaultSkinID = uVar5;
                            if ((*plVar7 != 0) &&
                               (lVar3 = GameObject.GetComponent(*plVar7,DAT_181d71b50)) != null) {
                              lVar3.forceName = 0;
                              if ((*plVar7 != 0) &&
                                 (lVar3 = GameObject.GetComponent(*plVar7,DAT_181d71b50)) != null) {
                                lVar3.leader = 1;
                                this.mainObj = *plVar7;
                                lVar3 = this.targetForce;
                                local_res18[0] = 0;
                                plVar9 = plVar8;
                                if (lVar3 != null) {
                                  while (lVar3.ownHeros != null) {
                                    if (*(int *)(lVar3.ownHeros + 24) <= (int)plVar9) {
                                      uVar5 = this.heroGrid;
                                      GlobalData.SortChild(uVar5,0);
                                      if ((((this.meetingPanel != null) &&
                                           (lVar3 = GameObject.get_transform
                                                              (this.meetingPanel,0),
                                           lVar3 != null)) &&
                                          (lVar3 = Transform.Find(lVar3,"HeroGrid",0)) != null) &&
                                         (lVar3 = Component.GetComponent(lVar3,DAT_181d96960), lVar3 != null
                                         )) {
                                        UIGrid.set_repositionNow(lVar3,1,0);
                                        plVar7 = (int64 *)Resources.Load("Sound/SoundEffect/紧张",0);
                                        if ((plVar7 != (int64 *)0) && (*plVar7 == DAT_181daf348)) {
                                          plVar8 = plVar7;
                                        }
                                        NGUITools.PlaySound(plVar8,0);
                                        if (*pStatics_61e8 != 0) {
                                          HeroLittleTalkController.HeroTalk
                                                    (*pStatics_61e8,
                                                     this.mainObj,"各位弟子已经到齐了吗？\n那么本次会议正式开始！",
                                                     0xbf800000,this.talkPanel,2,0);
                                          return;
                                        }
                                      }
                                      break;
                                    }
                                    if ((lVar3 == null) ||
                                       (lVar3 = ForceData.GetOwnHero(lVar3,plVar9,0)) == null) break;
                                    if (!lVar3.hour) {
                                      if ((this.targetForce == null) ||
                                         (lVar3 = ForceData.GetOwnHero
                                                            (this.targetForce,local_res18[0],
                                                             0), lVar3 == null)) break;
                                      if (!lVar3.ownAreasID) {
                                        if ((this.targetForce == null) ||
                                           (lVar3 = ForceData.GetOwnHero
                                                              (this.targetForce,
                                                               local_res18[0],0), lVar3 == null)) break;
                                        if (*(char *)(lVar3 + 209) == false) {
                                          if (((this.meetingPanel == null) ||
                                              (lVar3 = GameObject.get_transform
                                                                 (this.meetingPanel,0),
                                              lVar3 == null)) ||
                                             (lVar3 = Transform.Find(lVar3,"HeroGrid",0)) == null)
                                          break;
                                          uVar5 = Component.get_gameObject(lVar3,0);
                                          lVar3 = FUN_18046c1a0(0);
                                          if (lVar3 == null) break;
                                          uVar6 = lVar3.resourceStoreMax;
                                          lVar3 = GlobalData.AddChild(uVar5,uVar6,0);
                                          *plVar7 = lVar3;
                                          il2cpp_internal(plVar7,lVar3);
                                          if (*plVar7 == 0) break;
                                          lVar3 = GameObject.GetComponent(*plVar7,DAT_181d71b50);
                                          if ((this.targetForce == null) ||
                                             (uVar5 = ForceData.GetOwnHero
                                                                (this.targetForce,
                                                                 local_res18[0],0), lVar3 == null)) break;
                                          lVar3.defaultSkinID = uVar5;
                                          if ((*plVar7 == 0) ||
                                             (lVar3 = GameObject.GetComponent(*plVar7,DAT_181d71b50),
                                             lVar3 == null)) break;
                                          lVar3.forceName = 0;
                                          if ((*plVar7 == 0) ||
                                             (lVar3 = GameObject.GetComponent(*plVar7,DAT_181d71b50),
                                             lVar3 == null)) break;
                                          lVar3.leader = 1;
                                          lVar3 = *plVar7;
                                          lVar4 = FUN_18046c100(0);
                                          if ((lVar4 == null) ||
                                             (lVar4 = *(int64 *)(lVar4 + 64)) == null) break;
                                          if (*(int *)(lVar4 + 24) == 0) {
                                            ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                          }
                                          lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 32);
                                          if ((lVar4 == null) ||
                                             (lVar4 = *(int64 *)(lVar4 + 16)) == null) break;
                                          iVar2 = *(int *)(lVar4 + 24);
                                          if ((this.targetForce == null) ||
                                             (lVar4 = ForceData.GetOwnHero
                                                                (this.targetForce,
                                                                 local_res18[0],0), lVar4 == null)) break;
                                          local_res20[0] = iVar2 - *(int *)(lVar4 + 184);
                                          uVar5 = Int32.ToString(local_res20,0);
                                          uVar6 = Int32.ToString(local_res18,"000",0);
                                          uVar5 = String.Concat(uVar5,uVar6,0);
                                          if (lVar3 == null) break;
                                          Object.set_name(lVar3,uVar5,0);
                                          if ((this.targetForce == null) ||
                                             (lVar3 = this.targetForce.ownHeros,
                                             lVar3 == null)) break;
                                          iVar2 = FUN_1800d6760(lVar3,local_res18[0],DAT_181d8fa18);
                                          if (iVar2 == 0) {
                                            this.playerObj = *plVar7;
                                          }
                                        }
                                      }
                                    }
                                    lVar3 = this.targetForce;
                                    local_res18[0] = local_res18[0] + 1;
                                    plVar9 = (int64 *)(uint64)local_res18[0];
                                    if (lVar3 == null) break;
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

    // Token : 0x600190E
    // RVA   : 0xE5DFD0   Offset: 0xE5D3D0   Length: 0x11
    public void NextBigStep()
    {
        this.meetingStep = this.meetingStep + 1;
        this.subMeetingStep = 0;
        MeetingController.NextStep(this,0);
    }

    // Token : 0x600190F
    // RVA   : 0xE618C0   Offset: 0xE60CC0   Length: 0x18C
    public void SetInfoText()
    {
        ulong uVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        if (this.meetingPanel != null) {
          lVar2 = GameObject.get_transform(this.meetingPanel,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"InfoText",0);
            if (lVar2 != null) {
              uVar3 = Component.GetComponent(lVar2,DAT_181d96160);
              lVar2 = this.infoText;
              if (lVar2 != null) {
                lVar5 = lVar2;
                if (lVar2.Count == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  lVar5 = this.infoText;
                }
                uVar4 = *(uint64 *)(lVar2._items + 32);
                if (lVar5 != null) {
                  lVar2 = lVar5;
                  if (lVar5.Count < 2) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    lVar2 = this.infoText;
                  }
                  uVar1 = *(uint64 *)(lVar5._items + 40);
                  if (lVar2 != null) {
                    if (lVar2.Count < 3) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    uVar4 = String.Format("门派实力 {0}\n发展纲要 {1}\n本月方针 {2}",uVar4,uVar1,
                                           *(uint64 *)(lVar2._items + 48),0);
                    LTLocalization.SetText(uVar3,uVar4,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001910
    // RVA   : 0xE61850   Offset: 0xE60C50   Length: 0x65
    public void SetInfoFocusText(string targetText)
    {
        if (this.infoText != null) {
          FUN_181829cd0(this.infoText,2,targetText,DAT_181da43d8);
          MeetingController.SetInfoText(this,0);
          return;
        }
    }

    // Token : 0x6001911
    // RVA   : 0xE58850   Offset: 0xE57C50   Length: 0xE4
    public bool ForceCanAttackArea()
    {
        long lVar1;
        bool cVar2;
        if ((GameController._instance != null) &&
           (lVar1 = GameController._instance.worldData) != null) {
          if (lVar1.openForceAttackArea) {
            if (this.targetForce == null) throw; // [null/range check failed]
            cVar2 = ForceData.AreaNotFull(this.targetForce,0);
            if (cVar2) {
              return this.attackTargetArea != null;
            }
          }
          return false;
        }
    }

    // Token : 0x6001912
    // RVA   : 0xE5DFF0   Offset: 0xE5D3F0   Length: 0x408
    public void NextStep()
    {
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
        long lVar3;
        bool cVar4;
        uint uVar5;
        int iVar6;
        uint uVar7;
        int iVar8;
        ulong uVar9;
        long lVar10;
        ulong uVar12;
        long lVar13;
        ulong uVar14;
        long lVar15;
        ulong uVar16;
        ulong uVar17;
        int iVar18;
        int iVar19;
        ulong uVar20;
        int iVar21;
        ulong uVar22;
        float fVar23;
        float fVar24;
        float fVar25;
        int[] local_res8 = new int[2];
        int[] local_res18 = new int[4];
        ulong in_stack_fffffffffffffe60;
        ulong in_stack_fffffffffffffe68;
        float local_178;
        float fStack_174;
        ulong local_158;
        ulong uStack_150;
        ulong local_148;
        ulong local_138;
        float local_130;
        ulong local_128;
        uint local_120;
        byte[] local_108 = new byte[16];
        byte[] local_f8 = new byte[16];
        byte[] local_e8 = new byte[16];
        byte[] local_d8 = new byte[16];
        byte[] local_c8 = new byte[16];
        byte[] local_b8 = new byte[128];
        uVar5 = (uint32)((uint64)in_stack_fffffffffffffe60 >> 32);
        uVar9 = 0;
        local_res8[0] = 0;
        local_158 = 0;
        uStack_150 = 0;
        switch(this.meetingStep) {
        case 1:
          lVar13 = FUN_18046c0a0(0);
          lVar15 = FUN_18046c0a0(0);
          if (((lVar15 != null) && (lVar15.defaultSkinID != null)) &&
             (lVar15 = WorldData.Player(lVar15.defaultSkinID,0)) != null) {
            iVar8 = lVar15.bookStorage;
            lVar15 = FUN_18046c0a0(0);
            if ((lVar15 != null) && (lVar15.defaultSkinID != null)) {
              if (*(char *)(lVar15.defaultSkinID + 0x10c) == false) {
                uVar9 = il2cpp_internal(DAT_181d93cd0);
                FUN_18132faf0(uVar9,DAT_181d8f098);
                if (uVar9 == 0) goto LAB_180e60968;
                FUN_18182a0b0(uVar9,0,DAT_181d8f218);
              }
              if (lVar13 != null) {
                uVar14 = GameController.GetRandomArea(lVar13,(4 < iVar8) + '\x05',uVar9,0);
                this.attackTargetArea = uVar14;
        LAB_180e5e57a:
                this.meetingStep = this.meetingStep + 1;
                this.subMeetingStep = 0;
                MeetingController.NextStep(this,0);
                return;
              }
            }
          }
          goto LAB_180e60968;
        case 2:
          iVar8 = this.subMeetingStep;
          if (iVar8 == 0) {
            lVar13 = FUN_1807789e0(0);
            if (lVar13 == null) goto LAB_180e60968;
            uVar17 = this.talkPanel;
            uVar14 = this.mainObj;
            uVar16 = "首先，来看看上个月各位的功绩情况吧！";
          }
          else {
            if (iVar8 == 1) {
              lVar13 = this.heroGrid;
              uVar22 = uVar9;
              if (lVar13 != null) {
                while (lVar13 = GameObject.get_transform(lVar13,0)) != null {
                  iVar8 = Transform.get_childCount(lVar13,0);
                  iVar6 = (int)uVar22;
                  if (iVar8 <= iVar6) goto LAB_180e5ffe8;
                  uVar14 = this.meetingPanel;
                  uVar16 = this.lastMonthContributionUIPrefab;
                  lVar13 = GlobalData.AddChild(uVar14,uVar16,0);
                  this.newObj = lVar13;
                  if (*plVar1 == 0) break;
                  lVar13 = GameObject.get_transform(*plVar1,0);
                  if (((this.heroGrid == null) ||
                      (lVar15 = GameObject.get_transform(this.heroGrid,0)) == null)
                     || (lVar15 = Transform.GetChild(lVar15,uVar22,0)) == null) break;
                  puVar11 = (uint64 *)Transform.get_position(local_108,lVar15,0);
                  uVar14 = *puVar11;
                  fVar23 = *(float *)(puVar11 + 1);
                  if (((this.heroGrid == null) ||
                      (lVar15 = GameObject.get_transform(this.heroGrid,0)) == null)
                     || ((lVar15 = Transform.GetChild(lVar15,uVar22,0), lVar15 == null ||
                         (lVar15 = Component.GetComponent(lVar15,DAT_181d94f60)) == null))) break;
                  puVar11 = (uint64 *)RectTransform.get_rect(local_c8,lVar15,0);
                  local_158 = *puVar11;
                  uStack_150 = puVar11[1];
                  fVar24 = (float)FUN_18044e2b0(&local_158,0);
                  if (((this.heroGrid == null) ||
                      (lVar15 = GameObject.get_transform(this.heroGrid,0)) == null)
                     || (lVar15 = Transform.GetChild(lVar15,uVar22,0)) == null) break;
                  puVar11 = (uint64 *)Transform.get_lossyScale(local_f8,lVar15,0);
                  local_148 = *puVar11;
                  if ((*plVar1 == 0) ||
                     (lVar15 = GameObject.GetComponent(*plVar1,DAT_181d72bc8)) == null) break;
                  puVar11 = (uint64 *)RectTransform.get_rect(local_b8,lVar15,0);
                  local_158 = *puVar11;
                  uStack_150 = puVar11[1];
                  fVar25 = (float)FUN_18044e2b0(&local_158,0);
                  if ((*plVar1 == 0) || (lVar15 = GameObject.get_transform(*plVar1,0)) == null)
                  break;
                  lVar15 = Transform.get_lossyScale(local_e8,lVar15,0);
                  fVar25 = fVar25 * *(float *)(lVar15 + 4) + fVar24 * local_148._4_4_;
                  fVar24 = fVar25 * 0.0;
                  local_178 = (float)uVar14;
                  fStack_174 = (float)((uint64)uVar14 >> 32);
                  if (lVar13 == null) break;
                  local_138 = CONCAT44(fVar25 * 0.5 + fStack_174,fVar24 + local_178);
                  local_130 = fVar24 + fVar23;
                  Transform.set_position(lVar13,&local_138,0);
                  if (((*plVar1 == 0) || (lVar13 = GameObject.get_transform(*plVar1,0)) == null) ||
                     (lVar13 = Transform.Find(lVar13,"Text",0)) == null) break;
                  uVar14 = Component.GetComponent(lVar13,DAT_181d96160);
                  if (((this.heroGrid == null) ||
                      (lVar13 = GameObject.get_transform(this.heroGrid,0)) == null)
                     || ((lVar13 = Transform.GetChild(lVar13,uVar22,0), lVar13 == null ||
                         ((lVar13 = Component.GetComponent(lVar13,DAT_181d940e0), lVar13 == null ||
                          (lVar13.defaultSkinID == null)))))) break;
                  local_res8[0] = (int)*(float *)(lVar13.defaultSkinID + 164);
                  uVar16 = Int32.ToString(local_res8,0);
                  uVar16 = String.Concat("功绩",uVar16,0);
                  LTLocalization.SetText(uVar14,uVar16,0);
                  if (*plVar1 == 0) break;
                  lVar13 = GameObject.get_transform(*plVar1,0);
                  puVar11 = (uint64 *)Vector3.get_zero(local_d8,0);
                  if (lVar13 == null) break;
                  local_120 = *(uint32 *)(puVar11 + 1);
                  local_128 = *puVar11;
                  Transform.set_localScale(lVar13,&local_128,0);
                  if (*plVar1 == 0) break;
                  uVar14 = GameObject.get_transform(*plVar1,0);
                  uVar14 = ShortcutExtensions.DOScale(uVar14);
                  uVar14 = TweenSettingsExtensions.SetEase(uVar14,27,DAT_181dc0f80);
                  TweenSettingsExtensions.SetDelay(uVar14,(float)iVar6 * 0.1,DAT_181dc0c60);
                  lVar13 = this.lastMonthContributionHeroList;
                  if (lVar13 == null) break;
                  uVar20 = uVar9;
                  if (lVar13.forceName < 1) {
                    if (((this.heroGrid == null) ||
                        (lVar15 = GameObject.get_transform(this.heroGrid,0)) == null
                        ) || (lVar15 = Transform.GetChild(lVar15,uVar22,0)) == null) break;
                    uVar14 = Component.get_gameObject(lVar15,0);
                    FUN_18181e0a0(lVar13,uVar14,DAT_181d89398);
                    lVar13 = this.lastMonthContributionHeroList;
                  }
                  while( true ) {
                    if (lVar13 == null) goto LAB_180e60968;
                    iVar8 = (int)uVar20;
                    if (lVar13.forceName <= iVar8) goto LAB_180e5ee90;
                    if (((this.heroGrid == null) ||
                        (lVar13 = GameObject.get_transform(this.heroGrid,0)) == null
                        ) || ((lVar13 = Transform.GetChild(lVar13,uVar22,0), lVar13 == null ||
                              ((lVar13 = Component.GetComponent(lVar13,DAT_181d940e0), lVar13 == null ||
                               (lVar13.defaultSkinID == null)))))) goto LAB_180e60968;
                    fVar23 = *(float *)(lVar13.defaultSkinID + 164);
                    if ((this.lastMonthContributionHeroList == null) ||
                       (((lVar13 = FUN_180002f80(this.lastMonthContributionHeroList,uVar20), lVar13 == null ||
                         (lVar13 = GameObject.GetComponent(lVar13)) == null) ||
                        (lVar13.defaultSkinID == null)))) goto LAB_180e60968;
                    pfVar2 = (float *)(lVar13.defaultSkinID + 164);
                    lVar13 = this.lastMonthContributionHeroList;
                    if (*pfVar2 <= fVar23 && fVar23 != *pfVar2) {
                      if (((this.heroGrid == null) ||
                          (lVar15 = GameObject.get_transform(this.heroGrid,0),
                          lVar15 == null)) ||
                         ((lVar15 = Transform.GetChild(lVar15,uVar22,0), lVar15 == null ||
                          (uVar14 = Component.get_gameObject(lVar15,0), lVar13 == null))))
                      goto LAB_180e60968;
                      FUN_181822520(lVar13,uVar20,uVar14);
                      goto LAB_180e5ee90;
                    }
                    if (lVar13 == null) goto LAB_180e60968;
                    if (iVar8 == lVar13.forceName + -1) break;
                    uVar20 = (uint64)(iVar8 + 1);
                  }
                  if (((this.heroGrid == null) ||
                      (lVar15 = GameObject.get_transform(this.heroGrid,0)) == null)
                     || (lVar15 = Transform.GetChild(lVar15,uVar22,0)) == null) break;
                  uVar14 = Component.get_gameObject(lVar15,0);
                  FUN_18181e0a0(lVar13,uVar14,DAT_181d89398);
        LAB_180e5ee90:
                  if (this.lastMonthContributionUIs == null) break;
                  FUN_18181e0a0();
                  lVar13 = this.heroGrid;
                  uVar22 = (uint64)(iVar6 + 1);
                  if (lVar13 == null) break;
                }
              }
              goto LAB_180e60968;
            }
            if (iVar8 != 2) {
              if (iVar8 != 3) {
                if (this.lastMonthContributionHeroList == null) goto LAB_180e60968;
                FUN_1812f9a10(this.lastMonthContributionHeroList,DAT_181d89418);
                uVar14 = this.lastMonthContributionUIs;
                GlobalData.DestroyAll(uVar14,0);
                goto LAB_180e5e57a;
              }
              lVar15 = FUN_1807789e0(0);
              lVar13 = this.lastMonthContributionHeroList;
              if (lVar13 == null) goto LAB_180e60968;
              if (lVar13.forceName == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              if (lVar15 == null) goto LAB_180e60968;
              HeroLittleTalkController.HeroTalk
                        (lVar15,*(uint64 *)(lVar13.forceID + 32),"多谢掌门！",
                         0xbf800000,this.talkPanel,CONCAT44(uVar5,2),0);
              lVar13 = FUN_18046c0a0(0);
              if (this.targetForce == null) goto LAB_180e60968;
              fVar23 = (float)this.targetForce.forceLv;
              uVar14 = Random.Range(fVar23 * 0.2,fVar23 * 0.4,0);
              uVar5 = Mathf.RoundToInt(uVar14,0);
              if (lVar13 == null) goto LAB_180e60968;
              uVar14 = GameController.GenerateTreasure(lVar13,uVar5);
              lVar13 = this.lastMonthContributionHeroList;
              if (lVar13 == null) goto LAB_180e60968;
              if (lVar13.forceName == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar13 = *(int64 *)(lVar13.forceID + 32);
              if (((lVar13 == null) || (lVar13 = GameObject.GetComponent(lVar13,DAT_181d71b50)) == null
                  ) || (lVar13.defaultSkinID == null)) goto LAB_180e60968;
              HeroData.GetItem(lVar13.defaultSkinID,uVar14,1,0);
              goto LAB_180e5ffe8;
            }
            lVar13 = FUN_1807789e0(0);
            lVar15 = this.lastMonthContributionHeroList;
            uVar14 = this.mainObj;
            if (lVar15 == null) goto LAB_180e60968;
            if (lVar15.forceName == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar15 = *(int64 *)(lVar15.forceID + 32);
            if (((lVar15 == null) || (lVar15 = GameObject.GetComponent(lVar15,DAT_181d71b50)) == null)
               || (lVar15.defaultSkinID == null)) goto LAB_180e60968;
            uVar16 = HeroData.HeroName(lVar15.defaultSkinID,0,0);
            lVar15 = FUN_18046c0a0(0);
            if (((this.mainObj == null) ||
                (lVar10 = GameObject.GetComponent(this.mainObj,DAT_181d71b50),
                lVar10 == null)) || (*(int64 *)(lVar10 + 32) == 0)) goto LAB_180e60968;
            lVar3 = this.lastMonthContributionHeroList;
            uVar5 = *(uint32 *)(*(int64 *)(lVar10 + 32) + 88);
            if (lVar3 == null) goto LAB_180e60968;
            if (lVar3.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar10 = *(int64 *)(lVar3._items + 32);
            if (((lVar10 == null) || (lVar10 = GameObject.GetComponent(lVar10,DAT_181d71b50)) == null)
               || ((*(int64 *)(lVar10 + 32) == 0 || (lVar15 == null)))) goto LAB_180e60968;
            uVar17 = GameController.GetHeroName
                               (lVar15,uVar5,*(uint32 *)(*(int64 *)(lVar10 + 32) + 88),0);
            uVar16 = String.Format("看来，上个月还是{0}的成果最为丰硕。\n{1}，你做的很好\n这个是奖励，收下吧。",uVar16,uVar17,0);
            if (lVar13 == null) goto LAB_180e60968;
            uVar17 = this.talkPanel;
          }
          goto LAB_180e5ffe3;
        case 3:
          if (this.subMeetingStep == null) {
            lVar13 = FUN_1807789e0(0);
            if (lVar13 == null) goto LAB_180e60968;
            HeroLittleTalkController.ClearAll(lVar13,0);
            lVar13 = FUN_1807789e0(0);
            if (lVar13 == null) goto LAB_180e60968;
            uVar17 = this.talkPanel;
            uVar14 = this.mainObj;
            uVar16 = "接下来，看看当今武林的局势......";
            goto LAB_180e5ffe3;
          }
          if (this.subMeetingStep != 1) goto switchD_180e5fd86_default;
          lVar13 = FUN_18046c4c0(0);
          if (lVar13 == null) goto LAB_180e60968;
          QuickTravelUIController.ShowQuickTravelUI(lVar13,0,0);
          goto LAB_180e5ffe8;
        case 4:
          break;
        case 5:
          lVar13 = this.targetForce;
          if (lVar13 == null) goto LAB_180e60968;
          iVar8 = this.subMeetingStep;
          if (lVar13.forceFocus != 3) {
            if (iVar8 == 0) {
              lVar13 = FUN_1807789e0(0);
              if (lVar13 == null) goto LAB_180e60968;
              HeroLittleTalkController.ClearAll(lVar13,0);
              lVar13 = FUN_1807789e0(0);
              if (lVar13 == null) goto LAB_180e60968;
              uVar17 = this.talkPanel;
              uVar14 = this.mainObj;
              uVar16 = "既然如此，大家就各自选择本月的门派任务吧。";
            }
            else {
              if (iVar8 == 1) {
                MeetingController.ShowForceMission(this,0);
                goto LAB_180e5ffe8;
              }
              if (iVar8 == 2) {
                return;
              }
              if (iVar8 == 3) {
                lVar13 = FUN_18046c0a0(0);
                if (((lVar13 == null) || (lVar13.defaultSkinID == null)) ||
                   (lVar13 = WorldData.Player(lVar13.defaultSkinID,0)) == null)
                goto LAB_180e60968;
                if (*(int64 *)(lVar13 + 0x2e0) != 0) {
                  lVar13 = this.targetForce;
                  lVar15 = FUN_18046c0a0(0);
                  if ((((lVar15 == null) || (lVar15.defaultSkinID == null)) ||
                      (lVar15 = WorldData.Player(lVar15.defaultSkinID,0)) == null) ||
                     ((*(int64 *)(lVar15 + 0x2e0) == 0 || (lVar13 == null)))) goto LAB_180e60968;
                  ForceData.ChangeResource(lVar13,0);
                  lVar13 = FUN_18046c0a0(0);
                  if ((lVar13 == null) || (lVar13.defaultSkinID == null)) goto LAB_180e60968;
                  lVar13 = WorldData.Player(lVar13.defaultSkinID,0);
                  lVar15 = FUN_18046c0a0(0);
                  if (((lVar15 == null) || (lVar15.defaultSkinID == null)) ||
                     ((lVar15 = WorldData.Player(lVar15.defaultSkinID,0), lVar15 == null ||
                      ((*(int64 *)(lVar15 + 0x2e0) == 0 || (lVar13 == null)))))) goto LAB_180e60968;
                  HeroData.ChangeMoney(lVar13,*(uint32 *)(*(int64 *)(lVar15 + 0x2e0) + 132),1,0);
                  lVar13 = FUN_1807789e0(0);
                  uVar14 = this.mainObj;
                  lVar15 = FUN_18046c0a0(0);
                  if ((lVar15 == null) ||
                     (((lVar15.defaultSkinID == null ||
                       (lVar15 = WorldData.Player(lVar15.defaultSkinID,0)) == null) ||
                      (*(int64 *)(lVar15 + 0x2e0) == 0)))) goto LAB_180e60968;
                  uVar16 = *(uint64 *)(*(int64 *)(lVar15 + 0x2e0) + 24);
                  lVar15 = FUN_18046c0a0(0);
                  if ((((lVar15 == null) || (lVar15.defaultSkinID == null)) ||
                      (lVar15 = WorldData.Player(lVar15.defaultSkinID,0), uVar17 = "#PlayerName#，<b>{0}</b>的任务{1}就交给你了，一定要妥善完成。",
                      lVar15 == null)) || (*(int64 *)(lVar15 + 0x2e0) == 0)) goto LAB_180e60968;
                  uVar12 = "";
                  if (0 < *(int *)(*(int64 *)(lVar15 + 0x2e0) + 132)) {
                    lVar15 = FUN_18046c0a0(0);
                    if ((((lVar15 == null) || (lVar15.defaultSkinID == null)) ||
                        (lVar15 = WorldData.Player(lVar15.defaultSkinID,0)) == null) ||
                       (*(int64 *)(lVar15 + 0x2e0) == 0)) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    local_res18[0] = *(int *)(*(int64 *)(lVar15 + 0x2e0) + 132);
                    uVar12 = il2cpp_value_box(DAT_181d80418,local_res18);
                    uVar12 = String.Format("和这{0}两经费",uVar12,0);
                  }
                  uVar16 = String.Format(uVar17,uVar16,uVar12,0);
                  goto joined_r0x000180e5fcb9;
                }
                lVar13 = FUN_1807789e0(0);
                if (lVar13 == null) goto LAB_180e60968;
                uVar17 = this.talkPanel;
                uVar14 = this.mainObj;
                uVar16 = "#PlayerName#这个月没有空闲吗？可不要借口偷懒哦。";
              }
              else {
                if (iVar8 != 4) goto switchD_180e5fd86_default;
                lVar13 = FUN_18046c0a0(0);
                if (((lVar13 == null) || (lVar13.defaultSkinID == null)) ||
                   (lVar13 = WorldData.Player(lVar13.defaultSkinID,0)) == null)
                goto LAB_180e60968;
                if (*(int64 *)(lVar13 + 0x2e0) == 0) {
                  lVar13 = FUN_1807789e0(0);
                  uVar16 = "万万不敢...(好险，差点被发现)";
                }
                else {
                  lVar13 = FUN_1807789e0(0);
                  uVar16 = "领命！";
                }
                if (lVar13 == null) goto LAB_180e60968;
                uVar17 = this.talkPanel;
                uVar14 = this.playerObj;
              }
            }
            goto LAB_180e5ffe3;
          }
          switch(iVar8) {
          case 0:
            if (this.attackTargetArea == null) {
              this.attackAreaID = 0xffffffff;
              goto switchD_180e5fd86_default;
            }
            this.attackAreaID = this.attackTargetArea.areaID;
            if (((*(byte *)(DAT_181d73d40 + 0x133) & 4) != 0) && (*(int *)(DAT_181d73d40 + 224) == 0)) {
              il2cpp_runtime_class_init(DAT_181d73d40);
              lVar13 = this.targetForce;
            }
            lVar15 = *(int64 *)(pStatics_3d40 + 0x5b8);
            if ((lVar13 == null) || (lVar15 == null)) goto LAB_180e60968;
            uVar14 = FUN_180002f80(lVar15,lVar13.forceFocus,DAT_181da4358);
            if (this.attackTargetArea == null) goto LAB_180e60968;
            uVar16 = AreaData.GetAreaName(this.attackTargetArea,0);
            uVar16 = String.Format("({0})",uVar16,0);
            uVar14 = String.Concat(uVar14,uVar16,0);
            MeetingController.SetInfoFocusText(this,uVar14,0);
            lVar13 = FUN_1807789e0(0);
            if (lVar13 == null) goto LAB_180e60968;
            HeroLittleTalkController.ClearAll(lVar13,0);
            lVar13 = FUN_1807789e0(0);
            uVar14 = this.mainObj;
            if ((this.attackTargetArea == null) ||
               (lVar15 = AreaData.GetForce(this.attackTargetArea,0)) == null)
            goto LAB_180e60968;
            uVar16 = ForceData.GetForceName(lVar15,1,0);
            if (this.attackTargetArea == null) goto LAB_180e60968;
            uVar17 = AreaData.GetAreaName(this.attackTargetArea,0);
            uVar16 = String.Format("本门养精蓄锐，秣马厉兵已久，是时候一展雄威，因此我决定，本月要向<b>{0}</b>所占据的<b>{1}</b>发起进攻！",uVar16,uVar17,0);
            goto joined_r0x000180e5fcb9;
          case 1:
            lVar13 = FUN_1807789e0(0);
            if (lVar13 == null) goto LAB_180e60968;
            uVar17 = this.talkPanel;
            uVar14 = this.playerObj;
            uVar16 = "(那么，是否要建议掌门转而攻击其他地点呢？)";
            break;
          case 2:
            lVar13 = FUN_180778ae0(0);
            if (lVar13 == null) goto LAB_180e60968;
            SureMenu.CallSureMenu
                      (lVar13,"是否要针对攻略地点提出建议？","GivingAttackAreaAdvise","true","MeetingController",1,
                       in_stack_fffffffffffffe68 & 0xffffffffffffff00,"GivingAttackAreaAdvise","false",0);
            goto LAB_180e5ffe8;
          case 3:
            lVar13 = FUN_1807789e0(0);
            if (lVar13 == null) goto LAB_180e60968;
            HeroLittleTalkController.ClearAll(lVar13,0);
            lVar13 = FUN_1807789e0(0);
            if (lVar13 == null) goto LAB_180e60968;
            uVar17 = this.talkPanel;
            uVar16 = "#PlayerName#你似乎有话想说？";
        LAB_180e5ffdc:
            uVar14 = this.mainObj;
            break;
          case 4:
            lVar13 = FUN_1807789e0(0);
            uVar14 = this.playerObj;
            lVar15 = FUN_18046c0a0(0);
            if (((lVar15 == null) || (lVar15.defaultSkinID == null)) ||
               (lVar15 = WorldData.GetArea(lVar15.defaultSkinID,this.adviseAttackAreaID,0
                                           ), lVar15 == null)) goto LAB_180e60968;
            uVar16 = AreaData.GetAreaName(lVar15,0);
            uVar16 = String.Format("弟子认为，如今之计，应当优先进攻战略要地<b>{0}</b>才是。",uVar16,0);
        joined_r0x000180e5fcb9:
            if (lVar13 == null) goto LAB_180e60968;
            uVar17 = this.talkPanel;
            break;
          case 5:
            lVar13 = FUN_18046c0a0(0);
            if (((lVar13 == null) || (lVar13.defaultSkinID == null)) ||
               (lVar13 = WorldData.GetArea(lVar13.defaultSkinID,this.adviseAttackAreaID,0
                                           ), lVar13 == null)) goto LAB_180e60968;
            if (lVar13.startSkillBookID == 2) {
              lVar13 = FUN_18046c0a0(0);
              if (((lVar13 == null) || (lVar13.defaultSkinID == null)) ||
                 (lVar13 = WorldData.Player(lVar13.defaultSkinID,0)) == null)
              goto LAB_180e60968;
              if (lVar13.bookStorage < 5) {
                lVar13 = FUN_1807789e0(0);
                uVar14 = this.mainObj;
                lVar15 = FUN_18046c0a0(0);
                if (((lVar15 == null) || (lVar15.defaultSkinID == null)) ||
                   (lVar15 = WorldData.GetArea(lVar15.defaultSkinID,
                                                this.adviseAttackAreaID,0), lVar15 == null))
                goto LAB_180e60968;
                uVar17 = AreaData.GetAreaName(lVar15,0);
                uVar16 = "<b>{0}</b>总舵防备严密，#PlayerName#升任副掌门前，还是不要贸然策划此等大计";
                goto LAB_180e604af;
              }
            }
            fVar23 = (float)Random.get_value(0);
            lVar13 = FUN_18046c0a0(0);
            if (((lVar13 == null) || (lVar13.defaultSkinID == null)) ||
               (lVar13 = WorldData.Player(lVar13.defaultSkinID,0)) == null)
            goto LAB_180e60968;
            iVar8 = lVar13.bookStorage;
            if (((this.mainObj == null) ||
                (lVar13 = GameObject.GetComponent(this.mainObj,DAT_181d71b50),
                lVar13 == null)) || (lVar13.defaultSkinID == null)) goto LAB_180e60968;
            fVar24 = (float)HeroData.Favor(lVar13.defaultSkinID,0,0);
            if (fVar23 <= (fVar24 + (float)iVar8 * 20.0) * 0.0045 + 0.1) {
              this.attackAreaID = this.adviseAttackAreaID;
              lVar13 = *(int64 *)(pStatics_3d40 + 0x5b8);
              if ((this.targetForce == null) || (lVar13 == null)) goto LAB_180e60968;
              uVar14 = FUN_180002f80(lVar13,this.targetForce.forceFocus,
                                     DAT_181da4358);
              lVar13 = FUN_18046c0a0(0);
              if (((lVar13 == null) || (lVar13.defaultSkinID == null)) ||
                 (lVar13 = WorldData.GetArea(lVar13.defaultSkinID,this.attackAreaID
                                              ,0), lVar13 == null)) goto LAB_180e60968;
              uVar16 = AreaData.GetAreaName(lVar13,0);
              uVar16 = String.Format("({0})",uVar16,0);
              uVar14 = String.Concat(uVar14,uVar16,0);
              MeetingController.SetInfoFocusText(this,uVar14,0);
              lVar13 = FUN_1807789e0(0);
              uVar14 = this.mainObj;
              lVar15 = FUN_18046c0a0(0);
              if (((lVar15 == null) || (lVar15.defaultSkinID == null)) ||
                 (lVar15 = WorldData.GetArea(lVar15.defaultSkinID,this.attackAreaID
                                              ,0), lVar15 == null)) goto LAB_180e60968;
              uVar17 = AreaData.GetAreaName(lVar15,0);
              uVar16 = "#PlayerName#所言确有道理。那就依你所言，本月转而进攻<b>{0}</b>吧";
            }
            else {
              lVar13 = FUN_1807789e0(0);
              uVar14 = this.mainObj;
              lVar15 = FUN_18046c0a0(0);
              if (((lVar15 == null) || (lVar15.defaultSkinID == null)) ||
                 (lVar15 = WorldData.GetArea(lVar15.defaultSkinID,this.attackAreaID
                                              ,0), lVar15 == null)) goto LAB_180e60968;
              uVar17 = AreaData.GetAreaName(lVar15,0);
              uVar16 = "#PlayerName#所言虽有几分道理，但终究难以服众。本月还是继续进攻<b>{0}</b>吧";
            }
            goto LAB_180e604af;
          default:
        switchD_180e5fd86_default:
            this.subMeetingStep = 0;
            this.meetingStep = this.meetingStep + 1;
            MeetingController.NextStep(this,0);
            return;
          }
          goto LAB_180e5ffe3;
        case 6:
          if (this.targetForce == null) goto LAB_180e60968;
          iVar8 = this.subMeetingStep;
          if (this.targetForce.forceFocus == 3) {
            if (iVar8 == 0) {
              iVar8 = this.attackAreaID;
              if (iVar8 == -1) {
                lVar13 = FUN_1807789e0(0);
                if (lVar13 == null) goto LAB_180e60968;
                HeroLittleTalkController.ClearAll(lVar13,0);
                lVar13 = FUN_1807789e0(0);
                uVar14 = this.mainObj;
                uVar16 = FUN_180004500(DAT_181d8b140);
                uVar16 = String.Format("可惜本门周边暂无可进攻区域，各位弟子就先自由行动好了",uVar16,0);
              }
              else {
                local_res18[0] = iVar8;
                lVar13 = new MissionData(0);
                if (((lVar13 == null) ||
                    (lVar13 = MissionData.SetForceMission(lVar13,"攻略地点",20,0x41200000,0),
                    lVar13 == null)) || (lVar15 = lVar13.heroLvNum) == null) {
        LAB_180e60974:
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (lVar15.forceName == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar15 = *(int64 *)(lVar15.forceID + 32);
                if ((lVar15 = lVar15?.mainAreaID) == null)
                goto LAB_180e60974;
                if (lVar15.forceName == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar15 = *(int64 *)(lVar15.forceID + 32);
                if (lVar15 == null) goto LAB_180e60974;
                lVar15.forceStyle = 0x3f800000;
                lVar15 = lVar13.heroLvNum;
                if (lVar15 == null) goto LAB_180e60974;
                if (lVar15.forceName == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar15 = *(int64 *)(lVar15.forceID + 32);
                if ((lVar15 = lVar15?.mainAreaID) == null)
                goto LAB_180e60974;
                if (lVar15.forceName == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar15 = *(int64 *)(lVar15.forceID + 32);
                uVar14 = Int32.ToString(local_res18,0);
                if (lVar15 == null) goto LAB_180e60974;
                lVar15.forceName = uVar14;
                MeetingController.PlayerReciveForceMission(this,lVar13,0);
                lVar13 = FUN_1807789e0(0);
                if (lVar13 == null) goto LAB_180e6097a;
                HeroLittleTalkController.ClearAll(lVar13,0);
                lVar13 = FUN_1807789e0(0);
                uVar14 = this.mainObj;
                lVar15 = FUN_18046c0a0(0);
                if (((lVar15 == null) || (lVar15.defaultSkinID == null)) ||
                   (lVar15 = WorldData.GetArea(lVar15.defaultSkinID,
                                                this.attackAreaID,0), lVar15 == null))
                goto LAB_180e6097a;
                uVar16 = AreaData.GetAreaName(lVar15,0);
                lVar15 = FUN_18046c0a0(0);
                if (((lVar15 == null) || (lVar15.defaultSkinID == null)) ||
                   ((lVar15 = WorldData.GetArea(lVar15.defaultSkinID,
                                                 this.attackAreaID,0), lVar15 == null ||
                    (lVar15 = AreaData.GetForce(lVar15,0)) == null))) goto LAB_180e6097a;
                uVar17 = ForceData.GetForceName(lVar15,1,0);
                uVar16 = String.Format("那就决定了，请各位弟子分头前往{0}，汇合后由我带领出击，定要一举从{1}手中夺下此地！",uVar16,uVar17,0);
              }
              if (lVar13 == null) goto LAB_180e6097a;
              uVar17 = this.talkPanel;
              goto LAB_180e5ffe3;
            }
            if (iVar8 == 1) {
              lVar13 = this.heroGrid;
              if (lVar13 != null) {
                while( true ) {
                  uVar5 = (uint32)((uint64)in_stack_fffffffffffffe60 >> 32);
                  lVar13 = GameObject.get_transform(lVar13,0);
                  if (lVar13 == null) break;
                  iVar8 = Transform.get_childCount(lVar13,0);
                  if (iVar8 <= (int)uVar9) goto LAB_180e5ffe8;
                  lVar13 = **(int64 **)(DAT_181d761e8 + 184);
                  if (((this.heroGrid == null) ||
                      (lVar15 = GameObject.get_transform(this.heroGrid,0)) == null)
                     || ((lVar15 = Transform.GetChild(lVar15,uVar9,0), lVar15 == null ||
                         (uVar14 = Component.get_gameObject(lVar15,0), lVar13 == null)))) break;
                  in_stack_fffffffffffffe60 = CONCAT44(uVar5,2);
                  HeroLittleTalkController.HeroTalk
                            (lVar13,uVar14,"遵命",0xbf800000,this.talkPanel,
                             in_stack_fffffffffffffe60,0);
                  lVar13 = this.heroGrid;
                  uVar9 = (uint64)((int)uVar9 + 1);
                  if (lVar13 == null) break;
                }
              }
              goto LAB_180e6097a;
            }
          }
          else if (iVar8 == 0) {
            lVar13 = FUN_1807789e0(0);
            if (lVar13 == null) {
        LAB_180e6097a:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            HeroLittleTalkController.ClearAll(lVar13,0);
            lVar13 = FUN_1807789e0(0);
            if (lVar13 == null) goto LAB_180e6097a;
            uVar17 = this.talkPanel;
            uVar16 = "看样子，每个人的门派任务都已交代完成。\n会议到此结束。诸位辛苦了！";
            goto LAB_180e5ffdc;
          }
          MeetingController.EndMeeting(this,0);
        default:
          goto switchD_180e5e3ff_default;
        }
        switch(this.subMeetingStep) {
        case 0:
          lVar13 = this.infoText;
          if (((this.targetForce == null) || (MeetingController.ForceLvText == null)) ||
             (uVar14 = FUN_180002f80(MeetingController.ForceLvText,
                                     (int)((float)this.targetForce.forceLv * 0.5),
                                     DAT_181da4358), lVar13 == null)) goto LAB_180e60968;
          FUN_181829cd0(lVar13,0,uVar14,DAT_181da43d8);
          lVar13 = this.infoText;
          lVar15 = MeetingController.MainFocusText;
          if (((this.targetForce == null) || (lVar15 == null)) ||
             (uVar14 = FUN_180002f80(lVar15,(int)((float)this.targetForce.forceLv *
                                                 0.5),DAT_181da4358), lVar13 == null)) goto LAB_180e60968;
          FUN_181829cd0(lVar13,1,uVar14,DAT_181da43d8);
          MeetingController.SetInfoText(this,0);
          lVar13 = FUN_1807789e0(0);
          lVar15 = this.infoText;
          uVar14 = this.mainObj;
          if (lVar15 == null) goto LAB_180e60968;
          lVar10 = lVar15;
          if (lVar15.forceName == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
            lVar10 = this.infoText;
          }
          uVar16 = *(uint64 *)(lVar15.forceID + 32);
          if (lVar10 == null) goto LAB_180e60968;
          if (lVar10.Count < 2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar16 = String.Format("如各位所见，\n本门的江湖地位为<b>{0}</b>。\n看来应进一步<b>{1}</b>才是。",uVar16,
                                  *(uint64 *)(lVar10._items + 40),0);
          if (lVar13 == null) goto LAB_180e60968;
          uVar17 = this.talkPanel;
          break;
        case 1:
          lVar13 = FUN_18046c0a0(0);
          if ((lVar13 == null) || (lVar13.defaultSkinID == null)) goto LAB_180e60968;
          if (*(int *)(lVar13.defaultSkinID + 156) == 0) {
            lVar13 = FUN_18046c0a0(0);
            if ((lVar13 == null) || (lVar13.defaultSkinID == null)) goto LAB_180e60968;
            if (0 >= *(int *)(lVar13.defaultSkinID + 0x188))
            {
              if (this.targetForce == null) goto LAB_180e60968;
              this.targetForce.forceFocus = 0;
              }
              else {
            }
            lVar13 = il2cpp_internal(DAT_181d92d58);
            FUN_18132faf0(lVar13,DAT_181d883a0);
            uVar14 = DAT_181db8b30;
            if (this.targetForce == null) goto LAB_180e60968;
            iVar8 = (int)((float)this.targetForce.forceLv * 0.5);
            uVar14 = Type.GetTypeFromHandle(uVar14,0);
            lVar15 = Enum.GetValues(uVar14,0);
            if (lVar15 == null) goto LAB_180e60968;
            iVar6 = FUN_1812fe680(lVar15,0);
            iVar21 = 0;
            if (0 < iVar6) {
              do {
                if ((iVar21 != 3) ||
                   (cVar4 = MeetingController.ForceCanAttackArea(this,0), cVar4)) {
                  iVar18 = (iVar6 - iVar21) * 2 + -2;
                  if (iVar21 == 0) {
                    iVar18 = iVar18 - iVar8;
                  }
                  else if (iVar21 == 1) {
                    iVar19 = Mathf.RoundToInt((float)iVar8 * 0.5);
                    iVar18 = iVar18 - iVar19;
                  }
                  else if (iVar21 == 2) {
                    iVar19 = Mathf.RoundToInt((float)iVar8 * 0.5);
                    iVar18 = iVar18 + iVar19;
                  }
                  else if (iVar21 == 3) {
                    iVar18 = iVar18 + iVar8;
                  }
                  iVar19 = 0;
                  if (0 < iVar18) {
                    do {
                      if (lVar13 == null) goto LAB_180e60968;
                      FUN_18182a0b0(lVar13,iVar21,DAT_181d88420);
                      iVar19 = iVar19 + 1;
                    } while (iVar19 < iVar18);
                  }
                }
                iVar21 = iVar21 + 1;
              } while (iVar21 < iVar6);
            }
            lVar15 = this.targetForce;
            if (lVar13 == null) goto LAB_180e60968;
            uVar7 = FUN_180d95a30(0,lVar13.forceName,0);
            if (lVar13.forceName <= uVar7) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar15 == null) goto LAB_180e60968;
            lVar15.forceFocus =
                 lVar13.forceID[uVar7];
          }
          lVar13 = *(int64 *)(pStatics_3d40 + 0x5b8);
          if ((this.targetForce == null) || (lVar13 == null)) goto LAB_180e60968;
          uVar14 = FUN_180002f80(lVar13,this.targetForce.forceFocus,
                                 DAT_181da4358);
          MeetingController.SetInfoFocusText(this,uVar14,0);
          lVar13 = FUN_1807789e0(0);
          uVar14 = this.mainObj;
          lVar15 = *(int64 *)(pStatics_3d40 + 0x5b8);
          if ((this.targetForce == null) || (lVar15 == null)) goto LAB_180e60968;
          uVar17 = FUN_180002f80(lVar15,this.targetForce.forceFocus,
                                 DAT_181da4358);
          uVar16 = "因此，本月将进行<b>{0}</b>。\n诸位弟子可有建议？";
          goto LAB_180e5f460;
        case 2:
          lVar13 = FUN_1807789e0(0);
          if (lVar13 == null) goto LAB_180e60968;
          uVar17 = this.talkPanel;
          uVar14 = this.playerObj;
          uVar16 = "(那么，接下来是否要提出建议呢？)";
          break;
        case 3:
          lVar13 = FUN_180778ae0(0);
          if (lVar13 == null) goto LAB_180e60968;
          SureMenu.CallSureMenu
                    (lVar13,"是否要针对本月方针提出建议？","GivingMeetingAdvise","true","MeetingController",1,
                     in_stack_fffffffffffffe68 & 0xffffffffffffff00,"GivingMeetingAdvise","false",0);
          goto LAB_180e5ffe8;
        case 4:
          lVar13 = FUN_1807789e0(0);
          if (lVar13 == null) goto LAB_180e60968;
          HeroLittleTalkController.ClearAll(lVar13,0);
          lVar13 = FUN_1807789e0(0);
          if (lVar13 == null) goto LAB_180e60968;
          uVar17 = this.talkPanel;
          uVar14 = this.mainObj;
          uVar16 = "#PlayerName#你似乎有话想说？";
          break;
        case 5:
          lVar13 = FUN_1807789e0(0);
          uVar14 = this.playerObj;
          lVar15 = *(int64 *)(pStatics_3d40 + 0x5b8);
          if (lVar15 == null) goto LAB_180e60968;
          uVar17 = FUN_180002f80(lVar15,this.playerAdviseFocusType,DAT_181da4358);
          uVar16 = "弟子认为，如今之计，应当优先<b>{0}</b>才是。";
        LAB_180e5f460:
          uVar16 = String.Format(uVar16,uVar17,0);
          if (lVar13 == null) {
        LAB_180e60968:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar17 = this.talkPanel;
          break;
        case 6:
          lVar13 = FUN_18046c0a0(0);
          if ((lVar13 == null) || (lVar13.defaultSkinID == null)) goto LAB_180e60968;
          if (*(int *)(lVar13.defaultSkinID + 156) == 0) {
            lVar13 = FUN_18046c0a0(0);
            if ((lVar13 == null) || (lVar13.defaultSkinID == null)) goto LAB_180e60968;
            if (*(int *)(lVar13.defaultSkinID + 0x188) < 1) {
              lVar13 = FUN_1807789e0(0);
              uVar14 = this.mainObj;
              lVar15 = *(int64 *)(pStatics_3d40 + 0x5b8);
              if ((this.targetForce == null) || (lVar15 == null)) goto LAB_180e60968;
              uVar17 = FUN_180002f80(lVar15,this.targetForce.forceFocus,
                                     DAT_181da4358);
              uVar16 = "#PlayerName#初次参会，还需多加学习。本月还是继续<b>{0}</b>吧";
              goto LAB_180e604af;
            }
          }
          fVar23 = (float)Random.get_value(0);
          lVar13 = FUN_18046c0a0(0);
          if (((lVar13 == null) || (lVar13.defaultSkinID == null)) ||
             (lVar13 = WorldData.Player(lVar13.defaultSkinID,0)) == null)
          goto LAB_180e60968;
          iVar8 = lVar13.bookStorage;
          if (((this.mainObj == null) ||
              (lVar13 = GameObject.GetComponent(this.mainObj,DAT_181d71b50), lVar13 == null
              )) || (lVar13.defaultSkinID == null)) goto LAB_180e60968;
          fVar24 = (float)HeroData.Favor(lVar13.defaultSkinID,0,0);
          if (fVar23 <= (fVar24 + (float)iVar8 * 20.0) * 0.0045 + 0.1) {
            if (this.targetForce == null) goto LAB_180e60968;
            this.targetForce.forceFocus = this.playerAdviseFocusType;
            lVar13 = *(int64 *)(pStatics_3d40 + 0x5b8);
            if ((this.targetForce == null) || (lVar13 == null)) goto LAB_180e60968;
            uVar14 = FUN_180002f80(lVar13,this.targetForce.forceFocus,
                                   DAT_181da4358);
            MeetingController.SetInfoFocusText(this,uVar14,0);
            lVar13 = FUN_1807789e0(0);
            uVar14 = this.mainObj;
            lVar15 = *(int64 *)(pStatics_3d40 + 0x5b8);
            if ((this.targetForce == null) || (lVar15 == null)) goto LAB_180e60968;
            uVar17 = FUN_180002f80(lVar15,this.targetForce.forceFocus,
                                   DAT_181da4358);
            uVar16 = "#PlayerName#所言确有道理。那就依你所言，本月转而进行<b>{0}</b>吧";
          }
          else {
            lVar13 = FUN_1807789e0(0);
            uVar14 = this.mainObj;
            lVar15 = *(int64 *)(pStatics_3d40 + 0x5b8);
            if ((this.targetForce == null) || (lVar15 == null)) goto LAB_180e60968;
            uVar17 = FUN_180002f80(lVar15,this.targetForce.forceFocus,
                                   DAT_181da4358);
            uVar16 = "#PlayerName#所言虽有几分道理，但终究难以服众。本月还是继续<b>{0}</b>吧";
          }
        LAB_180e604af:
          uVar16 = String.Format(uVar16,uVar17,0);
          if (lVar13 == null) goto LAB_180e60968;
          uVar17 = this.talkPanel;
          break;
        default:
          goto switchD_180e5fd86_default;
        }
        LAB_180e5ffe3:
        HeroLittleTalkController.HeroTalk(lVar13,uVar14,uVar16,0xbf800000,uVar17,2,0);
        LAB_180e5ffe8:
        this.subMeetingStep = this.subMeetingStep + 1;
        switchD_180e5e3ff_default:
    }

    // Token : 0x6001913
    // RVA   : 0xE609D0   Offset: 0xE5FDD0   Length: 0x18B
    public void PlayerGetAttackAreaMission(int targetAreaID)
    {
        long lVar2;
        long lVar3;
        ulong uVar4;
        uint[] local_res10 = new uint[2];
        local_res10[0] = targetAreaID;
        lVar3 = new MissionData(0);
        if (lVar3 != null) {
          lVar3 = MissionData.SetForceMission(lVar3,"攻略地点",20,0x41200000,0);
          if ((lVar3 != null) && (lVar2 = *(int64 *)(lVar3 + 120)) != null) {
            if (*(int *)(lVar2 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = *(int64 *)(*(int64 *)(lVar2 + 16) + 32);
            if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 56)) != null) {
              if (*(int *)(lVar2 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(*(int64 *)(lVar2 + 16) + 32);
              if (lVar2 != null) {
                *(uint32 *)(lVar2 + 40) = 0x3f800000;
                lVar2 = *(int64 *)(lVar3 + 120);
                if (lVar2 != null) {
                  if (*(int *)(lVar2 + 24) == 0) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar2 = *(int64 *)(*(int64 *)(lVar2 + 16) + 32);
                  if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 56)) != null) {
                    if (*(int *)(lVar2 + 24) == 0) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar2 = *(int64 *)(*(int64 *)(lVar2 + 16) + 32);
                    uVar4 = Int32.ToString(local_res10,0);
                    if (lVar2 != null) {
                      puVar1 = (uint64 *)(lVar2 + 24);
                      *puVar1 = uVar4;
                      il2cpp_internal(puVar1,uVar4);
                      MeetingController.PlayerReciveForceMission(this,lVar3,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001914
    // RVA   : 0xE61CA0   Offset: 0xE610A0   Length: 0x82D
    public void ShowForceMission()
    {
        var pStatics_4000 = *(int64*)(DAT_181d94000 + 184);
        ulong uVar1;
        int iVar2;
        long lVar3;
        ulong uVar5;
        ulong uVar6;
        uint uVar7;
        long lVar8;
        float[] local_res8 = new float[2];
        ulong local_68;
        float local_60;
        byte[] local_58 = new byte[8];
        float local_50;
        byte[] local_48 = new byte[32];
        local_res8[0] = 0.0;
        if (this.monthMissionPanel != null) {
          GameObject.SetActive(this.monthMissionPanel,1,0);
          if ((((*pStatics_4000 != 0) &&
               (lVar3 = *(int64 *)(*pStatics_4000 + 32)) != null) &&
              (lVar3 = GameObject.get_transform(lVar3,0)) != null) &&
             (lVar3 = Transform.Find(lVar3,"MapRoot",0)) != null) {
            puVar4 = (uint64 *)Transform.get_localPosition(local_58,lVar3,0);
            local_60 = *(float *)(puVar4 + 1);
            uVar5 = *puVar4;
            puVar4 = (uint64 *)Vector3.get_right(local_48,0);
            local_60 = *(float *)(puVar4 + 1) * 120.0 + local_60;
            local_68 = CONCAT44((float)((uint64)*puVar4 >> 32) * 120.0 +
                                (float)((uint64)uVar5 >> 32),(float)*puVar4 * 120.0 + (float)uVar5);
            local_50 = local_60;
            Transform.set_localPosition(lVar3,&local_68,0);
            if (*pStatics_4000 != 0) {
              QuickTravelUIController.ShowQuickTravelUI
                        (*pStatics_4000,0,0x3f800000,1,0);
              if ((GameController._instance != null) &&
                 (lVar3 = GameController._instance.worldData) != null) {
                uVar5 = WorldData.Player(lVar3,0);
                uVar5 = MeetingController.GetAvailableMissions(this,uVar5,0);
                this.playerAvailableMissions = uVar5;
                lVar3 = this.playerAvailableMissions;
                uVar7 = 0;
                if (lVar3 != null) {
                  lVar8 = 32;
                  while ((int)uVar7 < lVar3.Count) {
                    if (lVar3 == null) throw; // [null/range check failed]
                    if (lVar3.Count <= uVar7) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    uVar5 = *(uint64 *)(lVar8 + lVar3._items);
                    uVar6 = this.monthMissionGrid;
                    uVar1 = this.monthMissionButtonPrefab;
                    uVar6 = GlobalData.AddChild(uVar6,uVar1);
                    this.newObj = uVar6;
                    if ((this.newObj == null) ||
                       (lVar3 = GameObject.GetComponent(this.newObj,DAT_181d725f0),
                       lVar3 == null)) throw; // [null/range check failed]
                    lVar3.Count = uVar5;
                    lVar3 = this.playerAvailableMissions;
                    uVar7 = uVar7 + 1;
                    lVar8 = lVar8 + 8;
                    if (lVar3 == null) throw; // [null/range check failed]
                  }
                  if ((GameController._instance != null) &&
                     (lVar3 = GameController._instance.worldData) != null) {
                    if (lVar3.gameMode == null) {
                      if ((GameController._instance == null) ||
                         (lVar3 = GameController._instance.worldData) == null
                         ) throw; // [null/range check failed]
                      if (lVar3.finishForceMissionCount < 1) {
                        if ((((this.monthMissionPanel != null) &&
                             (lVar3 = GameObject.get_transform(this.monthMissionPanel,0),
                             lVar3 != null)) && (lVar3 = Transform.Find(lVar3,"RefuseMonthMissionButton",0)) != null)
                           && (lVar3 = Component.GetComponent(lVar3,DAT_181d93760)) != null) {
                          Selectable.set_interactable(lVar3,0,0);
                          if (((this.monthMissionPanel != null) &&
                              (lVar3 = GameObject.get_transform(this.monthMissionPanel,0),
                              lVar3 != null)) &&
                             ((lVar3 = Transform.Find(lVar3,"RefuseMonthMissionButton",0), lVar3 != null &&
                              (lVar3 = Component.GetComponent(lVar3,DAT_181d95560), uVar5 = "完成一次门派任务才能选择"
                              , lVar3 != null)))) {
                            lVar3.Count = "完成一次门派任务才能选择";
                            goto LAB_180e622ad;
                          }
                        }
                        throw; // [null/range check failed]
                      }
                    }
                    if (((this.monthMissionPanel != null) &&
                        (lVar3 = GameObject.get_transform(this.monthMissionPanel,0)) != null)
                       && ((lVar3 = Transform.Find(lVar3,"RefuseMonthMissionButton",0), lVar3 != null &&
                           (lVar3 = Component.GetComponent(lVar3,DAT_181d93760)) != null))) {
                      Selectable.set_interactable(lVar3,1,0);
                      if (((this.monthMissionPanel != null) &&
                          (lVar3 = GameObject.get_transform(this.monthMissionPanel,0)) != null
                          ) && (lVar3 = Transform.Find(lVar3,"RefuseMonthMissionButton",0)) != null) {
                        lVar3 = Component.GetComponent(lVar3,DAT_181d95560);
                        uVar5 = *(uint64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x2d0);
                        if (((GameController._instance != null) &&
                            (lVar8 = GameController._instance.worldData,
                            lVar8 != null)) && (lVar8 = WorldData.Player(lVar8,0)) != null) {
                          iVar2 = HeroData.GetMissMeetingReduceContribution(lVar8,0);
                          local_res8[0] = (float)iVar2 * 0.5;
                          uVar6 = Single.ToString(local_res8,"f0",0);
                          uVar5 = String.Concat(uVar5,"门派功绩",uVar6,"</color>",0);
                          if (lVar3 != null) {
                            lVar3.Count = uVar5;
        LAB_180e622ad:
                            il2cpp_internal(puVar4,uVar5);
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

    // Token : 0x6001915
    // RVA   : 0xE5D6A0   Offset: 0xE5CAA0   Length: 0x159
    public float GetMissionRandomDifficulty(HeroData targetHero)
    {
        int iVar1;
        int iVar2;
        float fVar3;
        if (GameController._instance != null) {
          fVar3 = (float)GameController.GetTimeRandomDifficulty();
          if (targetHero != null) {
            iVar1 = *(int *)(targetHero + 184);
            iVar2 = FUN_180d95a30(0xfffffffe);
            Mathf.Min(0x41200000,(float)*(int *)(targetHero + 184) + (float)*(int *)(targetHero + 184) + 3.0,
                       0);
            FUN_1810e36c0(((float)iVar1 + (float)iVar1 + fVar3) * 0.5 + (float)iVar2);
            return;
          }
        }
    }

    // Token : 0x6001916
    // RVA   : 0xE58940   Offset: 0xE57D40   Length: 0x4B6C
    public List<MissionData> GetAvailableMissions(HeroData targetHero)
    {
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
        bool cVar2;
        int iVar3;
        uint uVar4;
        int iVar5;
        long lVar6;
        long lVar7;
        long lVar8;
        long lVar9;
        long lVar10;
        long lVar11;
        long lVar12;
        ulong uVar13;
        ulong uVar14;
        long lVar15;
        uint uVar17;
        uint uVar18;
        uint uVar19;
        float fVar20;
        float fVar21;
        byte[] auVar22 = new byte[16];
        byte[] auVar23 = new byte[16];
        int[] local_res20 = new int[2];
        ulong in_stack_fffffffffffffea0;
        ulong uVar24;
        ulong local_100;
        ulong uStack_f8;
        long local_f0;
        long local_e8;
        long local_e0;
        long local_d8;
        ulong local_c8;
        ulong uStack_c0;
        long local_b8;
        uint64 extraout_XMM0_Qb;
        uVar17 = 0;
        local_res20[0] = 0;
        local_100 = 0;
        uStack_f8 = 0;
        local_f0 = 0;
        lVar6 = il2cpp_internal(DAT_181d94b50);
        FUN_18132faf0(lVar6,DAT_181d94888);
        local_e8 = lVar6;
        if (this.targetForce == null) throw; // [null/range check failed]
        iVar3 = this.targetForce.forceFocus;
        if (iVar3 == 0) {
          iVar3 = 2;
          uVar19 = uVar17;
          do {
            lVar8 = new MissionData(0);
            lVar7 = *(int64 *)(pStatics_3d40 + 0x438);
            if (lVar7 == null) throw; // [null/range check failed]
            uVar13 = FUN_180002f80(lVar7,uVar19,DAT_181da4358);
            uVar13 = String.Concat("获取",uVar13,0);
            if (uVar19 == 0) {
              lVar7 = FUN_18046c0a0(0);
              if ((lVar7 == null) || (*(int64 *)(lVar7 + 32) == 0)) throw; // [null/range check failed]
              if (*(int *)(*(int64 *)(lVar7 + 32) + 156) != 0) goto LAB_180e5c815;
              lVar7 = FUN_18046c0a0(0);
              if ((lVar7 == null) || (*(int64 *)(lVar7 + 32) == 0)) throw; // [null/range check failed]
              if (0 < *(int *)(*(int64 *)(lVar7 + 32) + 0x188)) goto LAB_180e5c815;
            }
            else {
        LAB_180e5c815:
              MeetingController.GetMissionRandomDifficulty(this,targetHero,0);
            }
            if (lVar8 == null) throw; // [null/range check failed]
            uVar24 = 0;
            lVar8 = MissionData.SetForceMission(lVar8,uVar13,2);
            if ((lVar8 == null) || (lVar7 = *(int64 *)(lVar8 + 120)) == null) throw; // [null/range check failed]
            if (*(int *)(lVar7 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
            if ((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 56)) == null) throw; // [null/range check failed]
            if (*(int *)(lVar7 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
            if (lVar7 == null) throw; // [null/range check failed]
            *(uint32 *)(lVar7 + 32) = uVar19;
            lVar7 = *(int64 *)(lVar8 + 120);
            if (lVar7 == null) throw; // [null/range check failed]
            if (*(int *)(lVar7 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
            if ((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 56)) == null) throw; // [null/range check failed]
            if (*(int *)(lVar7 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
            Random.Range();
            lVar9 = *(int64 *)(pStatics_3d40 + 0x448);
            if (lVar9 == null) throw; // [null/range check failed]
            FUN_1800d6790(lVar9,uVar19,DAT_181da1078);
            iVar5 = Mathf.RoundToInt();
            if ((lVar7 == null) || (*(float *)(lVar7 + 40) = (float)(iVar5 * 10), lVar6 == null))
            throw; // [null/range check failed]
            FUN_18181e0a0(lVar6,lVar8,DAT_181d94908);
            uVar19 = uVar19 + 1;
          } while ((int)uVar19 < 6);
          if (targetHero == null) throw; // [null/range check failed]
          if (*(int *)(targetHero + 88) == 0) {
            lVar8 = il2cpp_internal(DAT_181d952d0);
            FUN_18132faf0(lVar8,DAT_181d97508);
            uVar19 = uVar17;
            do {
              uVar13 = il2cpp_internal(DAT_181d91c88);
              uVar24 = uVar24 & 0xffffffff00000000;
              PlotRandomHeroData.ctor(uVar13,0,0,0,0,uVar24,1,0,1,0,0,0);
              if (lVar8 == null) throw; // [null/range check failed]
              FUN_18181e0a0(lVar8);
              uVar19 = uVar19 + 1;
            } while ((int)uVar19 < 2);
            lVar7 = FUN_18046c0a0(0);
            if (lVar7 == null) throw; // [null/range check failed]
            uVar13 = 0;
            lVar8 = GameController.GetRandomHero(lVar7,targetHero,lVar8,0,0,0);
            uVar19 = uVar17;
            if (lVar8 == null) throw; // [null/range check failed]
            for (; (int)uVar19 < (int)*(uint32 *)(lVar8 + 24); uVar19 = uVar19 + 1) {
              if (*(uint32 *)(lVar8 + 24) <= uVar19) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar4 = (uint32)((uint64)uVar13 >> 32);
              if (lVar8[uVar19] != 0) {
                lVar7 = new MissionData(0);
                lVar9 = FUN_180002f80(lVar8,uVar19,DAT_181d8bb98);
                if ((lVar9 == null) || (lVar7 == null)) throw; // [null/range check failed]
                uVar13 = CONCAT44(uVar4,1);
                lVar7 = MissionData.SetForceMission
                                  (lVar7,"增进关系",3,
                                   (float)*(int *)(lVar9 + 184) + (float)*(int *)(lVar9 + 184),uVar13,0)
                ;
                if ((lVar7 == null) || (lVar9 = *(int64 *)(lVar7 + 120)) == null) throw; // [null/range check failed]
                if (*(int *)(lVar9 + 24) == 0) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar9 = *(int64 *)(*(int64 *)(lVar9 + 16) + 32);
                if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) throw; // [null/range check failed]
                if (*(int *)(lVar9 + 24) == 0) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar9 = *(int64 *)(*(int64 *)(lVar9 + 16) + 32);
                iVar5 = Mathf.RoundToInt(*(float *)(lVar7 + 44) * 0.3 + 1.0,0);
                if (lVar9 == null) throw; // [null/range check failed]
                *(float *)(lVar9 + 40) = (float)iVar5;
                lVar7 = *(int64 *)(lVar7 + 120);
                if (lVar7 == null) throw; // [null/range check failed]
                if (*(int *)(lVar7 + 24) == 0) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
                if ((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 56)) == null) throw; // [null/range check failed]
                if (*(int *)(lVar7 + 24) == 0) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
                lVar9 = FUN_180002f80(lVar8,uVar19,DAT_181d8bb98);
                if ((lVar9 == null) || (uVar14 = Int32.ToString(lVar9 + 88,0), lVar7 == null))
                throw; // [null/range check failed]
                puVar1 = (uint64 *)(lVar7 + 24);
                *puVar1 = uVar14;
                il2cpp_internal(puVar1,uVar14);
                FUN_18181e0a0(lVar6);
              }
            }
          }
          if (GameController._instance == null) throw; // [null/range check failed]
          lVar8 = GameController.GetRandomArea(GameController._instance,1,0);
          if (lVar8 != null) {
            do {
              lVar8 = new MissionData(0);
              lVar7 = *(int64 *)(pStatics_3d40 + 0x608);
              if (lVar7 == null) throw; // [null/range check failed]
              uVar13 = FUN_180002f80(lVar7,uVar17,DAT_181da4358);
              uVar13 = String.Concat("提升",uVar13,0);
              MeetingController.GetMissionRandomDifficulty(this,targetHero,0);
              if (((lVar8 == null) || (lVar8 = MissionData.SetForceMission(lVar8,uVar13,4)) == null) ||
                 (lVar7 = *(int64 *)(lVar8 + 120)) == null) throw; // [null/range check failed]
              if (*(int *)(lVar7 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
              if ((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 56)) == null) throw; // [null/range check failed]
              if (*(int *)(lVar7 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
              if (lVar7 == null) throw; // [null/range check failed]
              *(uint32 *)(lVar7 + 32) = uVar17;
              lVar7 = *(int64 *)(lVar8 + 120);
              if (lVar7 == null) throw; // [null/range check failed]
              if (*(int *)(lVar7 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
              if ((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 56)) == null) throw; // [null/range check failed]
              if (*(int *)(lVar7 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
              Random.Range();
              iVar5 = Mathf.RoundToInt();
              if (lVar7 == null) throw; // [null/range check failed]
              *(float *)(lVar7 + 40) = (float)iVar5;
              lVar7 = *(int64 *)(lVar8 + 120);
              if (lVar7 == null) throw; // [null/range check failed]
              if (*(int *)(lVar7 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
              if ((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 56)) == null) throw; // [null/range check failed]
              if (*(int *)(lVar7 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
              lVar9 = FUN_18046c0a0(0);
              if (((lVar9 == null) || (lVar9 = GameController.GetRandomArea(lVar9,1,0)) == null) ||
                 (uVar13 = Int32.ToString(lVar9 + 16,0), lVar7 == null)) throw; // [null/range check failed]
              puVar1 = (uint64 *)(lVar7 + 24);
              *puVar1 = uVar13;
              il2cpp_internal(puVar1,uVar13);
              FUN_18181e0a0(lVar6,lVar8,DAT_181d94908);
              uVar17 = uVar17 + 1;
            } while ((int)uVar17 < 3);
          }
          do {
            lVar8 = new MissionData(0);
            lVar7 = *(int64 *)(pStatics_3d40 + 0x578);
            if (lVar7 == null) throw; // [null/range check failed]
            uVar13 = FUN_180002f80(lVar7,iVar3,DAT_181da4358);
            MeetingController.GetMissionRandomDifficulty(this,targetHero,0);
            if (((lVar8 == null) || (lVar8 = MissionData.SetForceMission(lVar8,uVar13,5)) == null) ||
               (lVar7 = *(int64 *)(lVar8 + 120)) == null) throw; // [null/range check failed]
            if (*(int *)(lVar7 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
            if ((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 56)) == null) throw; // [null/range check failed]
            if (*(int *)(lVar7 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
            if (lVar7 == null) throw; // [null/range check failed]
            *(int *)(lVar7 + 32) = iVar3;
            lVar7 = *(int64 *)(lVar8 + 120);
            if (lVar7 == null) throw; // [null/range check failed]
            if (*(int *)(lVar7 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
            if ((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 56)) == null) throw; // [null/range check failed]
            if (*(int *)(lVar7 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
            Random.Range();
            iVar5 = Mathf.RoundToInt();
            if (lVar7 == null) throw; // [null/range check failed]
            *(float *)(lVar7 + 40) = (float)(iVar5 * 20);
            FUN_18181e0a0(lVar6,lVar8,DAT_181d94908);
            iVar3 = iVar3 + -1;
          } while (-1 < iVar3);
          if (this.targetForce == null) throw; // [null/range check failed]
          cVar2 = ForceData.PopulationNotFull(this.targetForce,0);
          if (cVar2) {
            lVar8 = new MissionData(0);
            MeetingController.GetMissionRandomDifficulty(this,targetHero,0);
            if (((lVar8 == null) || (lVar8 = MissionData.SetForceMission(lVar8,"招募弟子",6)) == null
                ) || (lVar7 = *(int64 *)(lVar8 + 120)) == null) throw; // [null/range check failed]
            if (*(int *)(lVar7 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
            if ((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 56)) == null) throw; // [null/range check failed]
            if (*(int *)(lVar7 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
            uVar4 = Mathf.RoundToInt(*(float *)(lVar8 + 44) * 0.3,0);
            if (lVar7 == null) throw; // [null/range check failed]
            *(uint32 *)(lVar7 + 32) = uVar4;
            lVar7 = *(int64 *)(lVar8 + 120);
            if (lVar7 == null) throw; // [null/range check failed]
            if (*(int *)(lVar7 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
            if ((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 56)) == null) throw; // [null/range check failed]
            if (*(int *)(lVar7 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
            if (lVar7 == null) throw; // [null/range check failed]
            *(uint32 *)(lVar7 + 40) = 0x3f800000;
            lVar7 = *(int64 *)(lVar8 + 120);
            if (lVar7 == null) throw; // [null/range check failed]
            if (*(int *)(lVar7 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
            if ((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 56)) == null) throw; // [null/range check failed]
            if (*(int *)(lVar7 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(int64 *)(*(int64 *)(lVar7 + 16) + 32) == 0) throw; // [null/range check failed]
            auVar22._0_8_ = FUN_1801f8ab0();
            auVar22._8_8_ = extraout_XMM0_Qb;
            auVar23._4_12_ = auVar22._4_12_;
            auVar23._0_4_ = (float)auVar22._0_8_ * 500.0;
            uVar4 = Mathf.RoundToInt(auVar23._0_8_,0);
            *(uint32 *)(lVar8 + 132) = uVar4;
            goto LAB_180e5c6b4;
          }
        }
        else {
          if (iVar3 == 1) {
            lVar8 = new MissionData(0);
            MeetingController.GetMissionRandomDifficulty(this,targetHero,0);
            if (lVar8 != null) {
              uVar13 = 0;
              lVar8 = MissionData.SetForceMission(lVar8,"学习武功",7);
              if ((lVar8 != null) && (lVar7 = *(int64 *)(lVar8 + 120)) != null) {
                if (*(int *)(lVar7 + 24) == 0) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
                if ((lVar7 != null) && (lVar7 = *(int64 *)(lVar7 + 56)) != null) {
                  if (*(int *)(lVar7 + 24) == 0) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
                  uVar4 = Mathf.RoundToInt(*(float *)(lVar8 + 44) * 0.5,0);
                  if (lVar7 != null) {
                    *(uint32 *)(lVar7 + 32) = uVar4;
                    lVar7 = *(int64 *)(lVar8 + 120);
                    if (lVar7 != null) {
                      if (*(int *)(lVar7 + 24) == 0) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
                      if ((lVar7 != null) && (lVar7 = *(int64 *)(lVar7 + 56)) != null) {
                        if (*(int *)(lVar7 + 24) == 0) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
                        if ((lVar7 != null) && (*(uint32 *)(lVar7 + 40) = 0x3f800000, lVar6 != null)) {
                          FUN_18181e0a0(lVar6,lVar8,DAT_181d94908);
                          lVar8 = il2cpp_internal(DAT_181d93cd0);
                          FUN_18132faf0(lVar8,DAT_181d8f098);
                          lVar7 = il2cpp_internal(DAT_181d93cd0);
                          FUN_18132faf0(lVar7,DAT_181d8f098);
                          lVar9 = il2cpp_internal(DAT_181d93cd0);
                          FUN_18132faf0(lVar9,DAT_181d8f098);
                          lVar10 = il2cpp_internal(DAT_181d93cd0);
                          FUN_18132faf0(lVar10,DAT_181d8f098);
                          uVar19 = uVar17;
                          if (targetHero != null) {
                            while (lVar11 = *(int64 *)(targetHero + 0x260)) != null {
                              if ((int)*(uint32 *)(lVar11 + 24) <= (int)uVar19) {
                                if (lVar8 != null) {
                                  uVar19 = uVar17;
                                  if (*(int *)(lVar8 + 24) < 1) goto LAB_180e5aae0;
                                  goto LAB_180e5a760;
                                }
                                break;
                              }
                              if (*(uint32 *)(lVar11 + 24) <= uVar19) {
                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                              }
                              lVar11 = *(int64 *)
                                        (*(int64 *)(lVar11 + 16) + 32 + (int64)(int)uVar19 * 8);
                              if (lVar11 == null) break;
                              if (*(int *)(lVar11 + 20) < 10) {
                                if ((*(int64 *)(targetHero + 0x260) == 0) ||
                                   (lVar11 = FUN_180002f80(*(int64 *)(targetHero + 0x260),uVar19,
                                                           DAT_181d92590), lVar11 == null)) break;
                                local_res20[0] = KungfuSkillLvData.Type(lVar11,0);
                                lVar11 = *(int64 *)(targetHero + 0x260);
                                if (local_res20[0] == 0) {
                                  if (lVar11 == null) break;
                                  lVar12 = FUN_180002f80(lVar11,uVar19,DAT_181d92590);
                                  lVar11 = lVar7;
                                }
                                else if (local_res20[0] == 1) {
                                  if (lVar11 == null) break;
                                  lVar12 = FUN_180002f80(lVar11,uVar19,DAT_181d92590);
                                  lVar11 = lVar9;
                                }
                                else if (local_res20[0] == 2) {
                                  if (lVar11 == null) break;
                                  lVar12 = FUN_180002f80(lVar11,uVar19,DAT_181d92590);
                                  lVar11 = lVar10;
                                }
                                else {
                                  if (lVar11 == null) break;
                                  lVar12 = FUN_180002f80(lVar11,uVar19,DAT_181d92590);
                                  lVar11 = lVar8;
                                }
                                if ((lVar12 == null) || (lVar11 == null)) break;
                                FUN_18182a0b0(lVar11);
                              }
                              uVar19 = uVar19 + 1;
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
            throw; // [null/range check failed]
          }
          if (iVar3 == 2) {
            lVar7 = il2cpp_internal(DAT_181d93cd0);
            FUN_18132faf0(lVar7,DAT_181d8f098);
            local_e0 = lVar7;
            lVar8 = il2cpp_internal(DAT_181d93cd0);
            FUN_18132faf0(lVar8,DAT_181d8f098);
            local_d8 = lVar8;
            lVar9 = FUN_18046c0a0(0);
            if (((lVar9 != null) && (*(int64 *)(lVar9 + 32) != 0)) &&
               (lVar9 = *(int64 *)(*(int64 *)(lVar9 + 32) + 72)) != null) {
              FUN_1817eb420(&local_c8,lVar9,DAT_181d88020);
              local_100 = local_c8;
              uStack_f8 = uStack_c0;
              local_f0 = local_b8;
        LAB_180e58df0:
              do {
                cVar2 = FUN_180c74f00(&local_100,DAT_181d8c5e8);
                lVar9 = local_f0;
                if (!cVar2) goto LAB_180e58f26;
                if (local_f0 == 0) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (this.targetForce == null) {
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (*(int *)(local_f0 + 16) != this.targetForce.forceID) {
                  if (PlotController.fightSkillIndexCache == 1) {
                    lVar10 = PlotController.LeftFaceHideOffset;
                    if (lVar10 == null) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    cVar2 = FUN_18182a3a0(lVar10,*(uint32 *)(lVar9 + 16),DAT_181d8f398);
                    if (!cVar2) goto LAB_180e58df0;
                  }
                  if (this.targetForce == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  fVar20 = (float)ForceData.GetForceFavor
                                            (this.targetForce,*(uint32 *)(lVar9 + 16),0
                                            );
                  if (50.0 <= fVar20) {
                    if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    FUN_18182a0b0(lVar7,*(uint32 *)(lVar9 + 16));
                  }
                  if (this.targetForce == null) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6620();
                  }
                  fVar20 = (float)ForceData.GetForceFavor
                                            (this.targetForce,*(uint32 *)(lVar9 + 16),0
                                            );
                  if (fVar20 < 50.0) {
                    if (lVar8 == null) {
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    FUN_18182a0b0(lVar8,*(uint32 *)(lVar9 + 16));
                  }
                }
              } while( true );
            }
            throw; // [null/range check failed]
          }
        }
        goto LAB_180e5d385;
        while( true ) {
          lVar11 = new MissionData(0);
          MeetingController.GetMissionRandomDifficulty(this,targetHero,0);
          if (lVar11 == null) throw; // [null/range check failed]
          uVar13 = 0;
          lVar11 = MissionData.SetForceMission(lVar11,"提升外功",8);
          if (lVar11 == null) throw; // [null/range check failed]
          uVar4 = Mathf.RoundToInt(*(float *)(lVar11 + 44) * 0.4,0);
          lVar12 = MeetingController.GetSkillRarelv(this,lVar8,uVar4,0,uVar13);
          if ((lVar12 == null) || (lVar15 = *(int64 *)(lVar11 + 120)) == null) throw; // [null/range check failed]
          if (*(int *)(lVar12 + 24) < 1) {
            lVar12 = FUN_180002f80(lVar15,0,DAT_181d95108);
            if ((lVar12 == null) || (*(int64 *)(lVar12 + 56) == 0)) throw; // [null/range check failed]
            lVar12 = FUN_180002f80(*(int64 *)(lVar12 + 56),0,DAT_181d94e88);
            uVar4 = FUN_180d95a30(0,*(uint32 *)(lVar8 + 24),0);
            local_res20[0] = FUN_1800d6760(lVar8,uVar4,DAT_181d8fa18);
            uVar14 = Int32.ToString(local_res20,0);
            if (lVar12 == null) throw; // [null/range check failed]
            *(uint64 *)(lVar12 + 24) = uVar14;
            lVar12 = FUN_18046c100(0);
            if (((((*(int64 *)(lVar11 + 120) == 0) ||
                  (lVar15 = FUN_180002f80(*(int64 *)(lVar11 + 120),0,DAT_181d95108)) == null) ||
                 (*(int64 *)(lVar15 + 56) == 0)) ||
                ((lVar15 = FUN_180002f80(*(int64 *)(lVar15 + 56),0,DAT_181d94e88), lVar15 == null ||
                 (uVar4 = Int32.Parse(*(uint64 *)(lVar15 + 24),0), lVar12 == null)))) ||
               (lVar12 = GameDataController.GetSkillDataBase(lVar12,uVar4,0)) == null)
            throw; // [null/range check failed]
            GameController.GetGameMaxDifficulty(0);
            fVar20 = (float)FUN_1810e36c0();
            *(float *)(lVar11 + 44) = fVar20;
            *(float *)(lVar11 + 144) = (fVar20 * 0.2 + 1.0) * *(float *)(lVar11 + 140);
          }
          else {
            lVar15 = FUN_180002f80(lVar15,0,DAT_181d95108);
            if ((lVar15 == null) || (*(int64 *)(lVar15 + 56) == 0)) throw; // [null/range check failed]
            lVar15 = FUN_180002f80(*(int64 *)(lVar15 + 56),0,DAT_181d94e88);
            uVar4 = FUN_180d95a30(0,*(uint32 *)(lVar12 + 24),0);
            local_res20[0] = FUN_1800d6760(lVar12,uVar4,DAT_181d8fa18);
            uVar14 = Int32.ToString(local_res20,0);
            if (lVar15 == null) throw; // [null/range check failed]
            *(uint64 *)(lVar15 + 24) = uVar14;
          }
          if ((((*(int64 *)(lVar11 + 120) == 0) ||
               (lVar12 = FUN_180002f80(*(int64 *)(lVar11 + 120),0,DAT_181d95108)) == null) ||
              (*(int64 *)(lVar12 + 56) == 0)) ||
             (lVar12 = FUN_180002f80(*(int64 *)(lVar12 + 56),0,DAT_181d94e88)) == null)
          throw; // [null/range check failed]
          uVar4 = Int32.Parse(*(uint64 *)(lVar12 + 24),0);
          FUN_1817eee00(lVar8,uVar4,DAT_181d8f618);
          if (((*(int64 *)(lVar11 + 120) == 0) ||
              (lVar11 = FUN_180002f80(*(int64 *)(lVar11 + 120),0,DAT_181d95108)) == null) ||
             ((*(int64 *)(lVar11 + 56) == 0 ||
              (lVar11 = FUN_180002f80(*(int64 *)(lVar11 + 56),0,DAT_181d94e88)) == null)))
          throw; // [null/range check failed]
          *(uint32 *)(lVar11 + 40) = 0x3f800000;
          FUN_18181e0a0(lVar6);
          uVar19 = uVar19 + 1;
          if (1 < (int)uVar19) break;
        LAB_180e5a760:
          if (*(int *)(lVar8 + 24) < 1) break;
        }
        LAB_180e5aae0:
        uVar4 = (uint32)((uint64)uVar13 >> 32);
        if (lVar9 != null) {
          if (0 < *(int *)(lVar9 + 24)) {
            lVar11 = new MissionData(0);
            MeetingController.GetMissionRandomDifficulty(this,targetHero,0);
            if (lVar11 == null) throw; // [null/range check failed]
            in_stack_fffffffffffffea0 = 0;
            uVar13 = CONCAT44(uVar4,1);
            lVar11 = MissionData.SetForceMission(lVar11,"提升轻功",8);
            if (lVar11 == null) throw; // [null/range check failed]
            uVar4 = Mathf.RoundToInt(*(float *)(lVar11 + 44) * 0.4,0);
            lVar12 = MeetingController.GetSkillRarelv
                               (this,lVar9,uVar4,0,uVar13,in_stack_fffffffffffffea0);
            if (lVar12 == null) throw; // [null/range check failed]
            lVar15 = *(int64 *)(lVar11 + 120);
            if (*(int *)(lVar12 + 24) < 1) {
              if (lVar15 == null) throw; // [null/range check failed]
              if (*(int *)(lVar15 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar12 = *(int64 *)(*(int64 *)(lVar15 + 16) + 32);
              if ((lVar12 == null) || (lVar12 = *(int64 *)(lVar12 + 56)) == null)
              throw; // [null/range check failed]
              if (*(int *)(lVar12 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar12 = *(int64 *)(*(int64 *)(lVar12 + 16) + 32);
              uVar19 = FUN_180d95a30(0,*(uint32 *)(lVar9 + 24),0);
              if (*(uint32 *)(lVar9 + 24) <= uVar19) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              local_res20[0] = lVar9[uVar19];
              uVar14 = Int32.ToString(local_res20,0);
              if (lVar12 == null) throw; // [null/range check failed]
              puVar1 = (uint64 *)(lVar12 + 24);
              *puVar1 = uVar14;
              il2cpp_internal(puVar1,uVar14);
              lVar12 = FUN_18046c100(0);
              lVar9 = *(int64 *)(lVar11 + 120);
              if (lVar9 == null) throw; // [null/range check failed]
              if (*(int *)(lVar9 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar9 = *(int64 *)(*(int64 *)(lVar9 + 16) + 32);
              if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) throw; // [null/range check failed]
              if (*(int *)(lVar9 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar9 = *(int64 *)(*(int64 *)(lVar9 + 16) + 32);
              if (((lVar9 == null) || (uVar4 = Int32.Parse(*(uint64 *)(lVar9 + 24),0), lVar12 == null))
                 || (lVar9 = GameDataController.GetSkillDataBase(lVar12,uVar4,0)) == null)
              throw; // [null/range check failed]
              GameController.GetGameMaxDifficulty(0);
              fVar20 = (float)FUN_1810e36c0();
              *(float *)(lVar11 + 44) = fVar20;
              *(float *)(lVar11 + 144) = (fVar20 * 0.2 + 1.0) * *(float *)(lVar11 + 140);
            }
            else {
              if (lVar15 == null) throw; // [null/range check failed]
              if (*(int *)(lVar15 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar9 = *(int64 *)(*(int64 *)(lVar15 + 16) + 32);
              if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) throw; // [null/range check failed]
              if (*(int *)(lVar9 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar9 = *(int64 *)(*(int64 *)(lVar9 + 16) + 32);
              uVar19 = FUN_180d95a30(0,*(uint32 *)(lVar12 + 24),0);
              if (*(uint32 *)(lVar12 + 24) <= uVar19) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              local_res20[0] = lVar12[uVar19];
              uVar14 = Int32.ToString(local_res20,0);
              if (lVar9 == null) throw; // [null/range check failed]
              puVar1 = (uint64 *)(lVar9 + 24);
              *puVar1 = uVar14;
              il2cpp_internal(puVar1,uVar14);
            }
            lVar9 = *(int64 *)(lVar11 + 120);
            if (lVar9 == null) throw; // [null/range check failed]
            if (*(int *)(lVar9 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(*(int64 *)(lVar9 + 16) + 32);
            if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) throw; // [null/range check failed]
            if (*(int *)(lVar9 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(*(int64 *)(lVar9 + 16) + 32);
            if (lVar9 == null) throw; // [null/range check failed]
            *(uint32 *)(lVar9 + 40) = 0x3f800000;
            FUN_18181e0a0(lVar6,lVar11,DAT_181d94908);
          }
          uVar4 = (uint32)((uint64)uVar13 >> 32);
          if (lVar10 != null) {
            if (0 < *(int *)(lVar10 + 24)) {
              lVar9 = new MissionData(0);
              MeetingController.GetMissionRandomDifficulty(this,targetHero,0);
              if (lVar9 == null) throw; // [null/range check failed]
              in_stack_fffffffffffffea0 = 0;
              uVar13 = CONCAT44(uVar4,2);
              lVar9 = MissionData.SetForceMission(lVar9,"提升绝技",8);
              if (lVar9 == null) throw; // [null/range check failed]
              uVar4 = Mathf.RoundToInt(*(float *)(lVar9 + 44) * 0.4,0);
              lVar11 = MeetingController.GetSkillRarelv
                                 (this,lVar10,uVar4,0,uVar13,in_stack_fffffffffffffea0);
              if (lVar11 == null) throw; // [null/range check failed]
              lVar12 = *(int64 *)(lVar9 + 120);
              if (*(int *)(lVar11 + 24) < 1) {
                if (lVar12 == null) throw; // [null/range check failed]
                if (*(int *)(lVar12 + 24) == 0) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar11 = *(int64 *)(*(int64 *)(lVar12 + 16) + 32);
                if ((lVar11 == null) || (lVar11 = *(int64 *)(lVar11 + 56)) == null)
                throw; // [null/range check failed]
                if (*(int *)(lVar11 + 24) == 0) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar11 = *(int64 *)(*(int64 *)(lVar11 + 16) + 32);
                uVar19 = FUN_180d95a30(0,*(uint32 *)(lVar10 + 24),0);
                if (*(uint32 *)(lVar10 + 24) <= uVar19) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                local_res20[0] = lVar10[uVar19]
                ;
                uVar14 = Int32.ToString(local_res20,0);
                if (lVar11 == null) throw; // [null/range check failed]
                puVar1 = (uint64 *)(lVar11 + 24);
                *puVar1 = uVar14;
                il2cpp_internal(puVar1,uVar14);
                lVar11 = FUN_18046c100(0);
                lVar10 = *(int64 *)(lVar9 + 120);
                if (lVar10 == null) throw; // [null/range check failed]
                if (*(int *)(lVar10 + 24) == 0) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar10 = *(int64 *)(*(int64 *)(lVar10 + 16) + 32);
                if ((lVar10 == null) || (lVar10 = *(int64 *)(lVar10 + 56)) == null)
                throw; // [null/range check failed]
                if (*(int *)(lVar10 + 24) == 0) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar10 = *(int64 *)(*(int64 *)(lVar10 + 16) + 32);
                if (((lVar10 == null) ||
                    (uVar4 = Int32.Parse(*(uint64 *)(lVar10 + 24),0), lVar11 == null)) ||
                   (lVar10 = GameDataController.GetSkillDataBase(lVar11,uVar4,0)) == null)
                throw; // [null/range check failed]
                GameController.GetGameMaxDifficulty(0);
                fVar20 = (float)FUN_1810e36c0();
                *(float *)(lVar9 + 44) = fVar20;
                *(float *)(lVar9 + 144) = (fVar20 * 0.2 + 1.0) * *(float *)(lVar9 + 140);
              }
              else {
                if (lVar12 == null) throw; // [null/range check failed]
                if (*(int *)(lVar12 + 24) == 0) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar10 = *(int64 *)(*(int64 *)(lVar12 + 16) + 32);
                if ((lVar10 == null) || (lVar10 = *(int64 *)(lVar10 + 56)) == null)
                throw; // [null/range check failed]
                if (*(int *)(lVar10 + 24) == 0) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar10 = *(int64 *)(*(int64 *)(lVar10 + 16) + 32);
                uVar19 = FUN_180d95a30(0,*(uint32 *)(lVar11 + 24),0);
                if (*(uint32 *)(lVar11 + 24) <= uVar19) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                local_res20[0] = lVar11[uVar19]
                ;
                uVar14 = Int32.ToString(local_res20,0);
                if (lVar10 == null) throw; // [null/range check failed]
                puVar1 = (uint64 *)(lVar10 + 24);
                *puVar1 = uVar14;
                il2cpp_internal(puVar1,uVar14);
              }
              lVar10 = *(int64 *)(lVar9 + 120);
              if (lVar10 == null) throw; // [null/range check failed]
              if (*(int *)(lVar10 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar10 = *(int64 *)(*(int64 *)(lVar10 + 16) + 32);
              if ((lVar10 == null) || (lVar10 = *(int64 *)(lVar10 + 56)) == null)
              throw; // [null/range check failed]
              if (*(int *)(lVar10 + 24) == 0) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar10 = *(int64 *)(*(int64 *)(lVar10 + 16) + 32);
              if (lVar10 == null) throw; // [null/range check failed]
              *(uint32 *)(lVar10 + 40) = 0x3f800000;
              FUN_18181e0a0(lVar6,lVar9,DAT_181d94908);
            }
            uVar4 = (uint32)((uint64)uVar13 >> 32);
            if (lVar7 != null) {
              if (0 < *(int *)(lVar7 + 24)) {
                lVar9 = new MissionData(0);
                MeetingController.GetMissionRandomDifficulty(this,targetHero,0);
                if (lVar9 == null) throw; // [null/range check failed]
                in_stack_fffffffffffffea0 = 0;
                uVar13 = CONCAT44(uVar4,3);
                lVar9 = MissionData.SetForceMission(lVar9,"提升内功",8);
                if (lVar9 == null) throw; // [null/range check failed]
                uVar4 = Mathf.RoundToInt(*(float *)(lVar9 + 44) * 0.4,0);
                lVar10 = MeetingController.GetSkillRarelv
                                   (this,lVar7,uVar4,0,uVar13,in_stack_fffffffffffffea0);
                if (lVar10 == null) throw; // [null/range check failed]
                lVar11 = *(int64 *)(lVar9 + 120);
                if (*(int *)(lVar10 + 24) < 1) {
                  if (lVar11 == null) throw; // [null/range check failed]
                  if (*(int *)(lVar11 + 24) == 0) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar10 = *(int64 *)(*(int64 *)(lVar11 + 16) + 32);
                  if ((lVar10 == null) || (lVar10 = *(int64 *)(lVar10 + 56)) == null)
                  throw; // [null/range check failed]
                  if (*(int *)(lVar10 + 24) == 0) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar10 = *(int64 *)(*(int64 *)(lVar10 + 16) + 32);
                  uVar19 = FUN_180d95a30(0,*(uint32 *)(lVar7 + 24),0);
                  if (*(uint32 *)(lVar7 + 24) <= uVar19) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  local_res20[0] =
                       lVar7[uVar19];
                  uVar14 = Int32.ToString(local_res20,0);
                  if (lVar10 == null) throw; // [null/range check failed]
                  puVar1 = (uint64 *)(lVar10 + 24);
                  *puVar1 = uVar14;
                  il2cpp_internal(puVar1,uVar14);
                  lVar10 = FUN_18046c100(0);
                  lVar7 = *(int64 *)(lVar9 + 120);
                  if (lVar7 == null) throw; // [null/range check failed]
                  if (*(int *)(lVar7 + 24) == 0) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
                  if ((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 56)) == null)
                  throw; // [null/range check failed]
                  if (*(int *)(lVar7 + 24) == 0) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
                  if (((lVar7 == null) ||
                      (uVar4 = Int32.Parse(*(uint64 *)(lVar7 + 24),0), lVar10 == null)) ||
                     (lVar7 = GameDataController.GetSkillDataBase(lVar10,uVar4,0)) == null)
                  throw; // [null/range check failed]
                  GameController.GetGameMaxDifficulty(0);
                  fVar20 = (float)FUN_1810e36c0();
                  *(float *)(lVar9 + 44) = fVar20;
                  *(float *)(lVar9 + 144) = (fVar20 * 0.2 + 1.0) * *(float *)(lVar9 + 140);
                }
                else {
                  if (lVar11 == null) throw; // [null/range check failed]
                  if (*(int *)(lVar11 + 24) == 0) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar7 = *(int64 *)(*(int64 *)(lVar11 + 16) + 32);
                  if ((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 56)) == null)
                  throw; // [null/range check failed]
                  if (*(int *)(lVar7 + 24) == 0) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
                  uVar19 = FUN_180d95a30(0,*(uint32 *)(lVar10 + 24),0);
                  if (*(uint32 *)(lVar10 + 24) <= uVar19) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  local_res20[0] =
                       lVar10[uVar19];
                  uVar14 = Int32.ToString(local_res20,0);
                  if (lVar7 == null) throw; // [null/range check failed]
                  puVar1 = (uint64 *)(lVar7 + 24);
                  *puVar1 = uVar14;
                  il2cpp_internal(puVar1,uVar14);
                }
                lVar7 = *(int64 *)(lVar9 + 120);
                if (lVar7 == null) throw; // [null/range check failed]
                if (*(int *)(lVar7 + 24) == 0) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
                if ((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 56)) == null) throw; // [null/range check failed]
                if (*(int *)(lVar7 + 24) == 0) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
                if (lVar7 == null) throw; // [null/range check failed]
                *(uint32 *)(lVar7 + 40) = 0x3f800000;
                FUN_18181e0a0(lVar6,lVar9,DAT_181d94908);
              }
              FUN_1812f9a10(lVar8,DAT_181d8f318);
              uVar19 = uVar17;
              while (lVar7 = *(int64 *)(targetHero + 0x158)) != null {
                if ((int)*(uint32 *)(lVar7 + 24) <= (int)uVar19) {
                  uVar19 = uVar17;
                  if (*(int *)(lVar8 + 24) < 1) goto LAB_180e5baa9;
                  goto LAB_180e5b5e6;
                }
                if (*(uint32 *)(lVar7 + 24) <= uVar19) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                fVar20 = lVar7[uVar19];
                fVar21 = (float)HeroData.GetMaxLivingSkill(targetHero);
                if (fVar20 < fVar21) {
                  FUN_18182a0b0(lVar8);
                }
                uVar19 = uVar19 + 1;
              }
            }
          }
        }
        throw; // [null/range check failed]
        while( true ) {
          lVar7 = new MissionData(0);
          MeetingController.GetMissionRandomDifficulty(this,targetHero,0);
          if (lVar7 == null) throw; // [null/range check failed]
          in_stack_fffffffffffffea0 = 0;
          uVar13 = CONCAT44(uVar4,1);
          lVar7 = MissionData.SetForceMission(lVar7,"提升技艺",9);
          if (lVar7 == null) throw; // [null/range check failed]
          fVar20 = *(float *)(lVar7 + 44);
          lVar9 = il2cpp_internal(DAT_181d93cd0);
          FUN_18132faf0(lVar9,DAT_181d8f098);
          for (uVar18 = uVar17; (int)uVar18 < *(int *)(lVar8 + 24); uVar18 = uVar18 + 1) {
            lVar10 = FUN_18046c0a0(0);
            if (((lVar10 == null) || (*(int64 *)(lVar10 + 32) == 0)) ||
               (lVar10 = WorldData.Player(*(int64 *)(lVar10 + 32),0)) == null)
            throw; // [null/range check failed]
            lVar10 = *(int64 *)(lVar10 + 0x158);
            uVar4 = FUN_1800d6760(lVar8,uVar18,DAT_181d8fa18);
            if (lVar10 == null) throw; // [null/range check failed]
            fVar21 = (float)FUN_1800d6790(lVar10,uVar4,DAT_181da1078);
            if (ABS(fVar20 - fVar21 * 0.125) < 0.5) {
              uVar4 = FUN_1800d6760(lVar8,uVar18,DAT_181d8fa18);
              if (lVar9 == null) throw; // [null/range check failed]
              FUN_18182a0b0(lVar9,uVar4,DAT_181d8f218);
            }
          }
          if ((lVar9 == null) || (lVar10 = *(int64 *)(lVar7 + 120)) == null) throw; // [null/range check failed]
          if (*(int *)(lVar9 + 24) < 1) {
            lVar9 = FUN_180002f80(lVar10,0,DAT_181d95108);
            if ((lVar9 == null) || (*(int64 *)(lVar9 + 56) == 0)) throw; // [null/range check failed]
            lVar9 = FUN_180002f80(*(int64 *)(lVar9 + 56),0,DAT_181d94e88);
            uVar4 = FUN_180d95a30(0,*(uint32 *)(lVar8 + 24),0);
            local_res20[0] = FUN_1800d6760(lVar8,uVar4,DAT_181d8fa18);
            uVar14 = Int32.ToString(local_res20,0);
            if (lVar9 == null) throw; // [null/range check failed]
            *(uint64 *)(lVar9 + 24) = uVar14;
            lVar9 = FUN_18046c0a0(0);
            if (((lVar9 == null) || (*(int64 *)(lVar9 + 32) == 0)) ||
               (lVar9 = WorldData.Player(*(int64 *)(lVar9 + 32),0)) == null) throw; // [null/range check failed]
            lVar9 = *(int64 *)(lVar9 + 0x158);
            if (((*(int64 *)(lVar7 + 120) == 0) ||
                (lVar10 = FUN_180002f80(*(int64 *)(lVar7 + 120),0,DAT_181d95108)) == null) ||
               ((*(int64 *)(lVar10 + 56) == 0 ||
                ((lVar10 = FUN_180002f80(*(int64 *)(lVar10 + 56),0,DAT_181d94e88), lVar10 == null ||
                 (uVar4 = Int32.Parse(*(uint64 *)(lVar10 + 24),0), lVar9 == null))))))
            throw; // [null/range check failed]
            FUN_1800d6790(lVar9,uVar4,DAT_181da1078);
            GameController.GetGameMaxDifficulty(0);
            fVar20 = (float)FUN_1810e36c0();
            *(float *)(lVar7 + 44) = fVar20;
            *(float *)(lVar7 + 144) = (fVar20 * 0.2 + 1.0) * *(float *)(lVar7 + 140);
          }
          else {
            lVar10 = FUN_180002f80(lVar10,0,DAT_181d95108);
            if ((lVar10 == null) || (*(int64 *)(lVar10 + 56) == 0)) throw; // [null/range check failed]
            lVar10 = FUN_180002f80(*(int64 *)(lVar10 + 56),0,DAT_181d94e88);
            uVar4 = FUN_180d95a30(0,*(uint32 *)(lVar9 + 24),0);
            local_res20[0] = FUN_1800d6760(lVar9,uVar4,DAT_181d8fa18);
            uVar14 = Int32.ToString(local_res20,0);
            if (lVar10 == null) throw; // [null/range check failed]
            *(uint64 *)(lVar10 + 24) = uVar14;
          }
          if ((((*(int64 *)(lVar7 + 120) == 0) ||
               (lVar9 = FUN_180002f80(*(int64 *)(lVar7 + 120),0,DAT_181d95108)) == null) ||
              (*(int64 *)(lVar9 + 56) == 0)) ||
             (lVar9 = FUN_180002f80(*(int64 *)(lVar9 + 56),0,DAT_181d94e88)) == null)
          throw; // [null/range check failed]
          uVar4 = Int32.Parse(*(uint64 *)(lVar9 + 24),0);
          FUN_1817eee00(lVar8,uVar4,DAT_181d8f618);
          if (((*(int64 *)(lVar7 + 120) == 0) ||
              (lVar7 = FUN_180002f80(*(int64 *)(lVar7 + 120),0,DAT_181d95108)) == null) ||
             ((*(int64 *)(lVar7 + 56) == 0 ||
              (lVar7 = FUN_180002f80(*(int64 *)(lVar7 + 56),0,DAT_181d94e88)) == null)))
          throw; // [null/range check failed]
          *(uint32 *)(lVar7 + 40) = 0x3f800000;
          FUN_18181e0a0(lVar6);
          uVar19 = uVar19 + 1;
          if (1 < (int)uVar19) break;
        LAB_180e5b5e6:
          uVar4 = (uint32)((uint64)uVar13 >> 32);
          if (*(int *)(lVar8 + 24) < 1) break;
        }
        LAB_180e5baa9:
        FUN_1812f9a10(lVar8,DAT_181d8f318);
        uVar19 = uVar17;
        while (lVar7 = *(int64 *)(targetHero + 0x260)) != null {
          if ((int)*(uint32 *)(lVar7 + 24) <= (int)uVar19) {
            uVar19 = uVar17;
            if (*(int *)(lVar8 + 24) < 1) goto LAB_180e5bef1;
            goto LAB_180e5bb64;
          }
          if (*(uint32 *)(lVar7 + 24) <= uVar19) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if ((lVar7[uVar19] == 0) ||
             (lVar7 = KungfuSkillLvData.DataBase()) == null) break;
          if (*(int *)(lVar7 + 52) < 4) {
            if ((*(int64 *)(targetHero + 0x260) == 0) ||
               (lVar7 = FUN_180002f80(*(int64 *)(targetHero + 0x260),uVar19,DAT_181d92590)) == null)
            break;
            FUN_18182a0b0(lVar8);
          }
          uVar19 = uVar19 + 1;
        }
        throw; // [null/range check failed]
        while( true ) {
          lVar7 = new MissionData(0);
          MeetingController.GetMissionRandomDifficulty(this,targetHero,0);
          if (lVar7 == null) throw; // [null/range check failed]
          in_stack_fffffffffffffea0 = 0;
          uVar13 = CONCAT44(uVar4,3);
          lVar7 = MissionData.SetForceMission(lVar7,"编纂秘籍",10);
          if (lVar7 == null) throw; // [null/range check failed]
          uVar4 = Mathf.RoundToInt(*(float *)(lVar7 + 44) * 0.2,0);
          lVar9 = MeetingController.GetSkillRarelv
                            (this,lVar8,uVar4,0,uVar13,in_stack_fffffffffffffea0);
          if ((lVar9 == null) || (lVar10 = *(int64 *)(lVar7 + 120)) == null) throw; // [null/range check failed]
          if (*(int *)(lVar9 + 24) < 1) {
            lVar9 = FUN_180002f80(lVar10,0,DAT_181d95108);
            if ((lVar9 == null) || (*(int64 *)(lVar9 + 56) == 0)) throw; // [null/range check failed]
            lVar9 = FUN_180002f80(*(int64 *)(lVar9 + 56),0,DAT_181d94e88);
            uVar4 = FUN_180d95a30(0,*(uint32 *)(lVar8 + 24),0);
            local_res20[0] = FUN_1800d6760(lVar8,uVar4,DAT_181d8fa18);
            uVar14 = Int32.ToString(local_res20,0);
            if (lVar9 == null) throw; // [null/range check failed]
            *(uint64 *)(lVar9 + 24) = uVar14;
            lVar9 = FUN_18046c100(0);
            if ((((*(int64 *)(lVar7 + 120) == 0) ||
                 (lVar10 = FUN_180002f80(*(int64 *)(lVar7 + 120),0,DAT_181d95108)) == null) ||
                (*(int64 *)(lVar10 + 56) == 0)) ||
               (((lVar10 = FUN_180002f80(*(int64 *)(lVar10 + 56),0,DAT_181d94e88), lVar10 == null ||
                 (uVar4 = Int32.Parse(*(uint64 *)(lVar10 + 24),0), lVar9 == null)) ||
                (lVar9 = GameDataController.GetSkillDataBase(lVar9,uVar4,0)) == null)))
            throw; // [null/range check failed]
            GameController.GetGameMaxDifficulty(0);
            fVar20 = (float)FUN_1810e36c0();
            *(float *)(lVar7 + 44) = fVar20;
            *(float *)(lVar7 + 144) = (fVar20 * 0.2 + 1.0) * *(float *)(lVar7 + 140);
          }
          else {
            lVar10 = FUN_180002f80(lVar10,0,DAT_181d95108);
            if ((lVar10 == null) || (*(int64 *)(lVar10 + 56) == 0)) throw; // [null/range check failed]
            lVar10 = FUN_180002f80(*(int64 *)(lVar10 + 56),0,DAT_181d94e88);
            uVar4 = FUN_180d95a30(0,*(uint32 *)(lVar9 + 24),0);
            local_res20[0] = FUN_1800d6760(lVar9,uVar4,DAT_181d8fa18);
            uVar14 = Int32.ToString(local_res20,0);
            if (lVar10 == null) throw; // [null/range check failed]
            *(uint64 *)(lVar10 + 24) = uVar14;
          }
          if ((((*(int64 *)(lVar7 + 120) == 0) ||
               (lVar9 = FUN_180002f80(*(int64 *)(lVar7 + 120),0,DAT_181d95108)) == null) ||
              (*(int64 *)(lVar9 + 56) == 0)) ||
             (lVar9 = FUN_180002f80(*(int64 *)(lVar9 + 56),0,DAT_181d94e88)) == null)
          throw; // [null/range check failed]
          uVar4 = Int32.Parse(*(uint64 *)(lVar9 + 24),0);
          FUN_1817eee00(lVar8,uVar4,DAT_181d8f618);
          if (((*(int64 *)(lVar7 + 120) == 0) ||
              (lVar7 = FUN_180002f80(*(int64 *)(lVar7 + 120),0,DAT_181d95108)) == null) ||
             ((*(int64 *)(lVar7 + 56) == 0 ||
              (lVar7 = FUN_180002f80(*(int64 *)(lVar7 + 56),0,DAT_181d94e88)) == null)))
          throw; // [null/range check failed]
          *(uint32 *)(lVar7 + 40) = 0x3f800000;
          FUN_18181e0a0(lVar6);
          uVar19 = uVar19 + 1;
          if (1 < (int)uVar19) break;
        LAB_180e5bb64:
          uVar4 = (uint32)((uint64)uVar13 >> 32);
          if (*(int *)(lVar8 + 24) < 1) break;
        }
        LAB_180e5bef1:
        if (*(int *)(targetHero + 88) == 0) {
          lVar8 = il2cpp_internal(DAT_181d952d0);
          FUN_18132faf0(lVar8,DAT_181d97508);
          uVar19 = uVar17;
          do {
            uVar13 = il2cpp_internal(DAT_181d91c88);
            in_stack_fffffffffffffea0 = in_stack_fffffffffffffea0 & 0xffffffff00000000;
            PlotRandomHeroData.ctor(uVar13,0,0,0,0,in_stack_fffffffffffffea0,1,0,1,0,0,0);
            if (lVar8 == null) throw; // [null/range check failed]
            FUN_18181e0a0(lVar8);
            uVar19 = uVar19 + 1;
          } while ((int)uVar19 < 2);
          lVar7 = FUN_18046c0a0(0);
          if (lVar7 == null) throw; // [null/range check failed]
          uVar13 = 0;
          lVar7 = GameController.GetRandomHero(lVar7,targetHero,lVar8,0,0,0);
          uVar19 = uVar17;
          if (lVar7 == null) throw; // [null/range check failed]
          for (; (int)uVar19 < (int)*(uint32 *)(lVar7 + 24); uVar19 = uVar19 + 1) {
            if (*(uint32 *)(lVar7 + 24) <= uVar19) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar4 = (uint32)((uint64)uVar13 >> 32);
            if (lVar7[uVar19] != 0) {
              lVar9 = new MissionData(0);
              lVar10 = FUN_180002f80(lVar7,uVar19,DAT_181d8bb98);
              if ((lVar10 == null) || (lVar9 == null)) throw; // [null/range check failed]
              uVar13 = CONCAT44(uVar4,2);
              lVar9 = MissionData.SetForceMission
                                (lVar9,"同门切磋",11,
                                 (float)*(int *)(lVar10 + 184) + (float)*(int *)(lVar10 + 184),uVar13,0)
              ;
              if ((lVar9 == null) ||
                 ((((*(int64 *)(lVar9 + 120) == 0 ||
                    (lVar10 = FUN_180002f80(*(int64 *)(lVar9 + 120),0,DAT_181d95108)) == null) ||
                   (*(int64 *)(lVar10 + 56) == 0)) ||
                  (lVar10 = FUN_180002f80(*(int64 *)(lVar10 + 56),0,DAT_181d94e88)) == null)))
              throw; // [null/range check failed]
              *(uint32 *)(lVar10 + 40) = 0x3f800000;
              if (((*(int64 *)(lVar9 + 120) == 0) ||
                  (lVar10 = FUN_180002f80(*(int64 *)(lVar9 + 120),0,DAT_181d95108)) == null) ||
                 (*(int64 *)(lVar10 + 56) == 0)) throw; // [null/range check failed]
              lVar10 = FUN_180002f80(*(int64 *)(lVar10 + 56),0,DAT_181d94e88);
              lVar11 = FUN_180002f80(lVar7,uVar19,DAT_181d8bb98);
              if ((lVar11 == null) || (uVar14 = Int32.ToString(lVar11 + 88,0), lVar10 == null))
              throw; // [null/range check failed]
              *(uint64 *)(lVar10 + 24) = uVar14;
              FUN_18181e0a0(lVar6,lVar9,DAT_181d94908);
            }
          }
          lVar7 = FUN_18046c0a0(0);
          if (lVar7 == null) throw; // [null/range check failed]
          uVar13 = 0;
          lVar7 = GameController.GetRandomHero(lVar7,targetHero,lVar8,0,0,0);
          uVar19 = uVar17;
          if (lVar7 == null) throw; // [null/range check failed]
          for (; (int)uVar19 < (int)*(uint32 *)(lVar7 + 24); uVar19 = uVar19 + 1) {
            if (*(uint32 *)(lVar7 + 24) <= uVar19) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar4 = (uint32)((uint64)uVar13 >> 32);
            if (lVar7[uVar19] != 0) {
              lVar9 = new MissionData(0);
              lVar10 = FUN_180002f80(lVar7,uVar19,DAT_181d8bb98);
              if ((lVar10 == null) || (lVar9 == null)) throw; // [null/range check failed]
              uVar13 = CONCAT44(uVar4,3);
              lVar9 = MissionData.SetForceMission
                                (lVar9,"指点修行",23,
                                 (float)*(int *)(lVar10 + 184) + (float)*(int *)(lVar10 + 184),uVar13,0)
              ;
              if (((lVar9 == null) ||
                  (((*(int64 *)(lVar9 + 120) == 0 ||
                    (lVar10 = FUN_180002f80(*(int64 *)(lVar9 + 120),0,DAT_181d95108)) == null) ||
                   (*(int64 *)(lVar10 + 56) == 0)))) ||
                 (lVar10 = FUN_180002f80(*(int64 *)(lVar10 + 56),0,DAT_181d94e88)) == null)
              throw; // [null/range check failed]
              *(uint32 *)(lVar10 + 40) = 0x3f800000;
              if (((*(int64 *)(lVar9 + 120) == 0) ||
                  (lVar10 = FUN_180002f80(*(int64 *)(lVar9 + 120),0,DAT_181d95108)) == null) ||
                 (*(int64 *)(lVar10 + 56) == 0)) throw; // [null/range check failed]
              lVar10 = FUN_180002f80(*(int64 *)(lVar10 + 56),0,DAT_181d94e88);
              lVar11 = FUN_180002f80(lVar7,uVar19,DAT_181d8bb98);
              if ((lVar11 == null) || (uVar14 = Int32.ToString(lVar11 + 88,0), lVar10 == null))
              throw; // [null/range check failed]
              *(uint64 *)(lVar10 + 24) = uVar14;
              FUN_18181e0a0(lVar6,lVar9,DAT_181d94908);
            }
          }
          lVar7 = FUN_18046c0a0(0);
          if (lVar7 == null) throw; // [null/range check failed]
          uVar13 = 0;
          lVar8 = GameController.GetRandomHero(lVar7,targetHero,lVar8,0,0,0);
          if (lVar8 == null) throw; // [null/range check failed]
          for (; (int)uVar17 < (int)*(uint32 *)(lVar8 + 24); uVar17 = uVar17 + 1) {
            if (*(uint32 *)(lVar8 + 24) <= uVar17) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar4 = (uint32)((uint64)uVar13 >> 32);
            if (lVar8[uVar17] != 0) {
              lVar7 = new MissionData(0);
              lVar9 = FUN_180002f80(lVar8,uVar17,DAT_181d8bb98);
              if ((lVar9 == null) || (lVar7 == null)) throw; // [null/range check failed]
              uVar13 = CONCAT44(uVar4,4);
              lVar7 = MissionData.SetForceMission
                                (lVar7,"传授武功",12,
                                 (float)*(int *)(lVar9 + 184) + (float)*(int *)(lVar9 + 184),uVar13,0);
              if (((lVar7 == null) ||
                  (((*(int64 *)(lVar7 + 120) == 0 ||
                    (lVar9 = FUN_180002f80(*(int64 *)(lVar7 + 120),0,DAT_181d95108)) == null) ||
                   (*(int64 *)(lVar9 + 56) == 0)))) ||
                 (lVar9 = FUN_180002f80(*(int64 *)(lVar9 + 56),0,DAT_181d94e88)) == null)
              throw; // [null/range check failed]
              *(uint32 *)(lVar9 + 40) = 0x3f800000;
              if (((*(int64 *)(lVar7 + 120) == 0) ||
                  (lVar7 = FUN_180002f80(*(int64 *)(lVar7 + 120),0,DAT_181d95108)) == null) ||
                 (*(int64 *)(lVar7 + 56) == 0)) throw; // [null/range check failed]
              lVar7 = FUN_180002f80(*(int64 *)(lVar7 + 56),0,DAT_181d94e88);
              lVar9 = FUN_180002f80(lVar8,uVar17,DAT_181d8bb98);
              if ((lVar9 == null) || (uVar14 = Int32.ToString(lVar9 + 88,0), lVar7 == null))
              throw; // [null/range check failed]
              *(uint64 *)(lVar7 + 24) = uVar14;
              FUN_18181e0a0(lVar6);
            }
          }
        }
        lVar8 = new MissionData(0);
        MeetingController.GetMissionRandomDifficulty(this,targetHero,0);
        if (((lVar8 == null) || (lVar8 = MissionData.SetForceMission(lVar8,"搜集秘籍",13)) == null)
           || (lVar7 = *(int64 *)(lVar8 + 120)) == null) throw; // [null/range check failed]
        if (*(int *)(lVar7 + 24) == 0) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
        if ((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 56)) == null) throw; // [null/range check failed]
        if (*(int *)(lVar7 + 24) == 0) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
        uVar4 = Mathf.RoundToInt(*(float *)(lVar8 + 44) * 0.3,0);
        if (lVar7 == null) throw; // [null/range check failed]
        *(uint32 *)(lVar7 + 32) = uVar4;
        lVar7 = *(int64 *)(lVar8 + 120);
        if (lVar7 == null) throw; // [null/range check failed]
        if (*(int *)(lVar7 + 24) == 0) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
        if ((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 56)) == null) throw; // [null/range check failed]
        if (*(int *)(lVar7 + 24) == 0) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
        if (lVar7 == null) throw; // [null/range check failed]
        *(uint32 *)(lVar7 + 40) = 0x3f800000;
        uVar4 = Mathf.RoundToInt(*(float *)(lVar8 + 44) * 200.0,0);
        *(uint32 *)(lVar8 + 132) = uVar4;
        goto LAB_180e5c6b4;
        LAB_180e58f26:
        ZhSegment.Initialize(&local_100,DAT_181d8c568);
        lVar9 = il2cpp_internal(DAT_181d93cd0);
        FUN_18132faf0(lVar9,DAT_181d8f098);
        uVar19 = uVar17;
        do {
          lVar10 = FUN_18046c0a0(0);
          if (lVar10 == null) throw; // [null/range check failed]
          lVar10 = GameController.GetRandomArea(lVar10,1,lVar9);
          if (lVar10 != null) {
            if (lVar9 == null) throw; // [null/range check failed]
            FUN_18182a0b0(lVar9,*(uint32 *)(lVar10 + 16),DAT_181d8f218);
            lVar11 = new MissionData(0);
            MeetingController.GetMissionRandomDifficulty(this,targetHero,0);
            if (((lVar11 == null) ||
                (lVar11 = MissionData.SetForceMission(lVar11,"进行探索",1)) == null) ||
               ((*(int64 *)(lVar11 + 120) == 0 ||
                (((lVar12 = FUN_180002f80(*(int64 *)(lVar11 + 120),0,DAT_181d95108), lVar12 == null ||
                  (*(int64 *)(lVar12 + 56) == 0)) ||
                 (lVar12 = FUN_180002f80(*(int64 *)(lVar12 + 56),0,DAT_181d94e88)) == null)))))
            throw; // [null/range check failed]
            *(uint32 *)(lVar12 + 40) = 0x3f800000;
            if (((*(int64 *)(lVar11 + 120) == 0) ||
                (lVar12 = FUN_180002f80(*(int64 *)(lVar11 + 120),0,DAT_181d95108)) == null) ||
               (*(int64 *)(lVar12 + 56) == 0)) throw; // [null/range check failed]
            lVar12 = FUN_180002f80(*(int64 *)(lVar12 + 56),0,DAT_181d94e88);
            uVar13 = Int32.ToString((uint32 *)(lVar10 + 16),0);
            if (lVar12 == null) throw; // [null/range check failed]
            *(uint64 *)(lVar12 + 24) = uVar13;
            if (lVar6 == null) throw; // [null/range check failed]
            FUN_18181e0a0(lVar6,lVar11,DAT_181d94908);
          }
          uVar19 = uVar19 + 1;
        } while ((int)uVar19 < 2);
        if (lVar9 == null) throw; // [null/range check failed]
        FUN_1812f9a10(lVar9,DAT_181d8f318);
        uVar19 = uVar17;
        do {
          lVar10 = FUN_18046c0a0(0);
          if (lVar10 == null) throw; // [null/range check failed]
          lVar10 = GameController.GetRandomArea(lVar10,0,lVar9,0);
          if (lVar10 != null) {
            FUN_18182a0b0(lVar9,*(uint32 *)(lVar10 + 16),DAT_181d8f218);
            lVar11 = new MissionData(0);
            MeetingController.GetMissionRandomDifficulty(this,targetHero,0);
            if (((((lVar11 == null) ||
                  (lVar11 = MissionData.SetForceMission(lVar11,"岗哨巡查",21)) == null) ||
                 (*(int64 *)(lVar11 + 120) == 0)) ||
                ((lVar12 = FUN_180002f80(*(int64 *)(lVar11 + 120),0,DAT_181d95108), lVar12 == null ||
                 (*(int64 *)(lVar12 + 56) == 0)))) ||
               (lVar12 = FUN_180002f80(*(int64 *)(lVar12 + 56),0,DAT_181d94e88)) == null)
            throw; // [null/range check failed]
            *(uint32 *)(lVar12 + 40) = 0x3f800000;
            if (((*(int64 *)(lVar11 + 120) == 0) ||
                (lVar12 = FUN_180002f80(*(int64 *)(lVar11 + 120),0,DAT_181d95108)) == null) ||
               (*(int64 *)(lVar12 + 56) == 0)) throw; // [null/range check failed]
            lVar12 = FUN_180002f80(*(int64 *)(lVar12 + 56),0,DAT_181d94e88);
            uVar13 = Int32.ToString((uint32 *)(lVar10 + 16),0);
            if (lVar12 == null) throw; // [null/range check failed]
            *(uint64 *)(lVar12 + 24) = uVar13;
            if (lVar6 == null) throw; // [null/range check failed]
            FUN_18181e0a0(lVar6,lVar11,DAT_181d94908);
          }
          uVar19 = uVar19 + 1;
        } while ((int)uVar19 < 2);
        if (**(int **)(DAT_181d73d40 + 184) != 2) {
          lVar9 = il2cpp_internal(DAT_181d952d0);
          FUN_18132faf0(lVar9,DAT_181d97508);
          uVar19 = uVar17;
          do {
            uVar13 = il2cpp_internal(DAT_181d91c88);
            in_stack_fffffffffffffea0 = in_stack_fffffffffffffea0 & 0xffffffff00000000;
            PlotRandomHeroData.ctor(uVar13,0,0,0,0,in_stack_fffffffffffffea0,3,0,1,0,0,0);
            if (lVar9 == null) throw; // [null/range check failed]
            FUN_18181e0a0(lVar9);
            uVar19 = uVar19 + 1;
          } while ((int)uVar19 < 2);
          lVar10 = FUN_18046c0a0(0);
          if (lVar10 == null) throw; // [null/range check failed]
          uVar13 = 0;
          lVar9 = GameController.GetRandomHero(lVar10,targetHero,lVar9,0,0,0);
          uVar19 = uVar17;
          if (lVar9 == null) throw; // [null/range check failed]
          for (; (int)uVar19 < (int)*(uint32 *)(lVar9 + 24); uVar19 = uVar19 + 1) {
            if (*(uint32 *)(lVar9 + 24) <= uVar19) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar4 = (uint32)((uint64)uVar13 >> 32);
            if (lVar9[uVar19] != 0) {
              lVar10 = new MissionData(0);
              lVar11 = FUN_180002f80(lVar9,uVar19,DAT_181d8bb98);
              if ((lVar11 == null) || (lVar10 == null)) throw; // [null/range check failed]
              uVar13 = CONCAT44(uVar4,1);
              lVar10 = MissionData.SetForceMission
                                 (lVar10,"袭击要敌",16,
                                  (float)*(int *)(lVar11 + 184) + (float)*(int *)(lVar11 + 184),uVar13,0
                                 );
              uVar4 = (uint32)((uint64)uVar13 >> 32);
              if (((lVar10 == null) ||
                  (((*(int64 *)(lVar10 + 120) == 0 ||
                    (lVar11 = FUN_180002f80(*(int64 *)(lVar10 + 120),0,DAT_181d95108)) == null)
                   || (*(int64 *)(lVar11 + 56) == 0)))) ||
                 (lVar11 = FUN_180002f80(*(int64 *)(lVar11 + 56),0,DAT_181d94e88)) == null)
              throw; // [null/range check failed]
              *(uint32 *)(lVar11 + 40) = 0x3f800000;
              if (((*(int64 *)(lVar10 + 120) == 0) ||
                  (lVar11 = FUN_180002f80(*(int64 *)(lVar10 + 120),0,DAT_181d95108)) == null) ||
                 (*(int64 *)(lVar11 + 56) == 0)) throw; // [null/range check failed]
              lVar11 = FUN_180002f80(*(int64 *)(lVar11 + 56),0,DAT_181d94e88);
              lVar12 = FUN_180002f80(lVar9,uVar19,DAT_181d8bb98);
              if ((lVar12 == null) || (uVar13 = Int32.ToString(lVar12 + 88,0), lVar11 == null))
              throw; // [null/range check failed]
              *(uint64 *)(lVar11 + 24) = uVar13;
              if (lVar6 == null) throw; // [null/range check failed]
              FUN_18181e0a0(lVar6,lVar10,DAT_181d94908);
              lVar10 = new MissionData(0);
              lVar11 = FUN_180002f80(lVar9,uVar19,DAT_181d8bb98);
              if ((lVar11 == null) || (lVar10 == null)) throw; // [null/range check failed]
              uVar13 = CONCAT44(uVar4,1);
              lVar10 = MissionData.SetForceMission
                                 (lVar10,"下毒暗害",24,
                                  (float)*(int *)(lVar11 + 184) + (float)*(int *)(lVar11 + 184),uVar13,0
                                 );
              if ((lVar10 == null) ||
                 (((*(int64 *)(lVar10 + 120) == 0 ||
                   (lVar11 = FUN_180002f80(*(int64 *)(lVar10 + 120),0,DAT_181d95108)) == null) ||
                  (*(int64 *)(lVar11 + 56) == 0)))) throw; // [null/range check failed]
              lVar11 = FUN_180002f80(*(int64 *)(lVar11 + 56),0,DAT_181d94e88);
              Random.Range();
              iVar3 = Mathf.RoundToInt();
              if (lVar11 == null) throw; // [null/range check failed]
              *(float *)(lVar11 + 40) = (float)iVar3;
              if (((*(int64 *)(lVar10 + 120) == 0) ||
                  (lVar10 = FUN_180002f80(*(int64 *)(lVar10 + 120),0,DAT_181d95108)) == null) ||
                 (*(int64 *)(lVar10 + 56) == 0)) throw; // [null/range check failed]
              lVar10 = FUN_180002f80(*(int64 *)(lVar10 + 56),0,DAT_181d94e88);
              lVar11 = FUN_180002f80(lVar9,uVar19,DAT_181d8bb98);
              if ((lVar11 == null) || (uVar14 = Int32.ToString(lVar11 + 88,0), lVar10 == null))
              throw; // [null/range check failed]
              *(uint64 *)(lVar10 + 24) = uVar14;
              FUN_18181e0a0(lVar6);
            }
          }
        }
        lVar9 = FUN_18046c0a0(0);
        if (lVar9 == null) throw; // [null/range check failed]
        lVar9 = GameController.GetRandomArea(lVar9,3,0);
        uVar19 = uVar17;
        if (lVar9 != null) {
          do {
            lVar9 = new MissionData(0);
            lVar10 = *(int64 *)(pStatics_3d40 + 0x608);
            if (lVar10 == null) throw; // [null/range check failed]
            uVar13 = FUN_180002f80(lVar10,uVar19,DAT_181da4358);
            uVar13 = String.Concat("降低",uVar13,0);
            MeetingController.GetMissionRandomDifficulty(this,targetHero,0);
            if (((((lVar9 == null) || (lVar9 = MissionData.SetForceMission(lVar9,uVar13,17)) == null)
                 || (*(int64 *)(lVar9 + 120) == 0)) ||
                ((lVar10 = FUN_180002f80(*(int64 *)(lVar9 + 120),0,DAT_181d95108), lVar10 == null ||
                 (*(int64 *)(lVar10 + 56) == 0)))) ||
               (lVar10 = FUN_180002f80(*(int64 *)(lVar10 + 56),0,DAT_181d94e88)) == null)
            throw; // [null/range check failed]
            *(uint32 *)(lVar10 + 32) = uVar19;
            if (((*(int64 *)(lVar9 + 120) == 0) ||
                (lVar10 = FUN_180002f80(*(int64 *)(lVar9 + 120),0,DAT_181d95108)) == null) ||
               (*(int64 *)(lVar10 + 56) == 0)) throw; // [null/range check failed]
            lVar10 = FUN_180002f80(*(int64 *)(lVar10 + 56),0,DAT_181d94e88);
            Random.Range();
            iVar3 = Mathf.RoundToInt();
            if (lVar10 == null) throw; // [null/range check failed]
            *(float *)(lVar10 + 40) = (float)iVar3;
            if (((*(int64 *)(lVar9 + 120) == 0) ||
                (lVar10 = FUN_180002f80(*(int64 *)(lVar9 + 120),0,DAT_181d95108)) == null) ||
               (*(int64 *)(lVar10 + 56) == 0)) throw; // [null/range check failed]
            lVar10 = FUN_180002f80(*(int64 *)(lVar10 + 56),0,DAT_181d94e88);
            lVar11 = FUN_18046c0a0(0);
            if (((lVar11 == null) || (lVar11 = GameController.GetRandomArea(lVar11,3,0)) == null) ||
               (uVar13 = Int32.ToString(lVar11 + 16,0), lVar10 == null)) throw; // [null/range check failed]
            *(uint64 *)(lVar10 + 24) = uVar13;
            if (lVar6 == null) throw; // [null/range check failed]
            FUN_18181e0a0(lVar6,lVar9,DAT_181d94908);
            uVar19 = uVar19 + 1;
          } while ((int)uVar19 < 3);
        }
        lVar9 = new MissionData(0);
        MeetingController.GetMissionRandomDifficulty(this,targetHero,0);
        if (lVar9 == null) throw; // [null/range check failed]
        uVar24 = 0;
        lVar9 = MissionData.SetForceMission(lVar9,"搜集珍宝",22);
        if ((((lVar9 == null) || (*(int64 *)(lVar9 + 120) == 0)) ||
            (lVar10 = FUN_180002f80(*(int64 *)(lVar9 + 120),0,DAT_181d95108)) == null) ||
           (*(int64 *)(lVar10 + 56) == 0)) throw; // [null/range check failed]
        lVar10 = FUN_180002f80(*(int64 *)(lVar10 + 56),0,DAT_181d94e88);
        uVar4 = Mathf.RoundToInt(*(float *)(lVar9 + 44) * 0.5,0);
        if (lVar10 == null) throw; // [null/range check failed]
        *(uint32 *)(lVar10 + 32) = uVar4;
        if (((*(int64 *)(lVar9 + 120) == 0) ||
            (lVar10 = FUN_180002f80(*(int64 *)(lVar9 + 120),0,DAT_181d95108)) == null) ||
           ((*(int64 *)(lVar10 + 56) == 0 ||
            (lVar10 = FUN_180002f80(*(int64 *)(lVar10 + 56),0,DAT_181d94e88)) == null)))
        throw; // [null/range check failed]
        *(uint32 *)(lVar10 + 40) = 0x3f800000;
        uVar4 = Mathf.RoundToInt(*(float *)(lVar9 + 44) * 100.0,0);
        *(uint32 *)(lVar9 + 132) = uVar4;
        if (lVar6 == null) throw; // [null/range check failed]
        FUN_18181e0a0(lVar6,lVar9,DAT_181d94908);
        if (**(int **)(DAT_181d73d40 + 184) != 2) {
          if (lVar8 == null) throw; // [null/range check failed]
          if (0 < *(int *)(lVar8 + 24)) {
            lVar9 = new MissionData(0);
            MeetingController.GetMissionRandomDifficulty(this,targetHero,0);
            if (lVar9 == null) throw; // [null/range check failed]
            uVar24 = 0;
            lVar9 = MissionData.SetForceMission(lVar9,"窃取资源",18);
            if ((((lVar9 == null) || (*(int64 *)(lVar9 + 120) == 0)) ||
                (lVar10 = FUN_180002f80(*(int64 *)(lVar9 + 120),0,DAT_181d95108)) == null) ||
               (*(int64 *)(lVar10 + 56) == 0)) throw; // [null/range check failed]
            lVar10 = FUN_180002f80(*(int64 *)(lVar10 + 56),0,DAT_181d94e88);
            lVar11 = FUN_18046c0a0(0);
            if (lVar11 == null) throw; // [null/range check failed]
            lVar11 = *(int64 *)(lVar11 + 32);
            uVar4 = FUN_180d95a30(0,*(uint32 *)(lVar8 + 24),0);
            uVar4 = FUN_1800d6760(lVar8,uVar4,DAT_181d8fa18);
            if (((lVar11 == null) || (lVar11 = WorldData.GetForce(lVar11,uVar4,0)) == null) ||
               (uVar13 = Int32.ToString(lVar11 + 56,0), lVar10 == null)) throw; // [null/range check failed]
            *(uint64 *)(lVar10 + 24) = uVar13;
            if ((((*(int64 *)(lVar9 + 120) == 0) ||
                 (lVar10 = FUN_180002f80(*(int64 *)(lVar9 + 120),0,DAT_181d95108)) == null) ||
                (*(int64 *)(lVar10 + 56) == 0)) ||
               (lVar10 = FUN_180002f80(*(int64 *)(lVar10 + 56),0,DAT_181d94e88)) == null)
            throw; // [null/range check failed]
            *(uint32 *)(lVar10 + 40) = 0x3f800000;
            FUN_18181e0a0(lVar6,lVar9,DAT_181d94908);
          }
        }
        lVar9 = il2cpp_internal(DAT_181d952d0);
        FUN_18132faf0(lVar9,DAT_181d97508);
        uVar19 = uVar17;
        do {
          if (targetHero == null) throw; // [null/range check failed]
          iVar3 = Mathf.Clamp(*(uint32 *)(targetHero + 184),0,4);
          uVar13 = il2cpp_internal(DAT_181d91c88);
          uVar24 = uVar24 & 0xffffffff00000000;
          PlotRandomHeroData.ctor(uVar13,1,0,0,0,uVar24,3,0,3,(float)iVar3,0,0);
          if (lVar9 == null) throw; // [null/range check failed]
          FUN_18181e0a0(lVar9,uVar13,DAT_181d97588);
          uVar19 = uVar19 + 1;
        } while ((int)uVar19 < 2);
        lVar10 = FUN_18046c0a0(0);
        if (lVar10 == null) throw; // [null/range check failed]
        uVar13 = 0;
        lVar9 = GameController.GetRandomHero(lVar10,targetHero,lVar9,0,0,0);
        if (lVar9 == null) throw; // [null/range check failed]
        while( true ) {
          uVar4 = (uint32)((uint64)uVar13 >> 32);
          if ((int)*(uint32 *)(lVar9 + 24) <= (int)uVar17) break;
          if (*(uint32 *)(lVar9 + 24) <= uVar17) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar4 = (uint32)((uint64)uVar13 >> 32);
          if (lVar9[uVar17] != 0) {
            lVar10 = new MissionData(0);
            lVar11 = FUN_180002f80(lVar9,uVar17,DAT_181d8bb98);
            if ((lVar11 == null) || (lVar10 == null)) throw; // [null/range check failed]
            uVar13 = CONCAT44(uVar4,3);
            lVar10 = MissionData.SetForceMission
                               (lVar10,"挑拨离间",19,(float)*(int *)(lVar11 + 184) * 2.5,uVar13,0);
            if (((lVar10 == null) ||
                (((*(int64 *)(lVar10 + 120) == 0 ||
                  (lVar11 = FUN_180002f80(*(int64 *)(lVar10 + 120),0,DAT_181d95108)) == null) ||
                 (*(int64 *)(lVar11 + 56) == 0)))) ||
               (lVar11 = FUN_180002f80(*(int64 *)(lVar11 + 56),0,DAT_181d94e88)) == null)
            throw; // [null/range check failed]
            *(uint32 *)(lVar11 + 40) = 0x40400000;
            if (((*(int64 *)(lVar10 + 120) == 0) ||
                (lVar10 = FUN_180002f80(*(int64 *)(lVar10 + 120),0,DAT_181d95108)) == null) ||
               (*(int64 *)(lVar10 + 56) == 0)) throw; // [null/range check failed]
            lVar10 = FUN_180002f80(*(int64 *)(lVar10 + 56),0,DAT_181d94e88);
            lVar11 = FUN_180002f80(lVar9,uVar17,DAT_181d8bb98);
            if ((lVar11 == null) || (uVar14 = Int32.ToString(lVar11 + 88,0), lVar10 == null))
            throw; // [null/range check failed]
            *(uint64 *)(lVar10 + 24) = uVar14;
            FUN_18181e0a0(lVar6);
          }
          uVar17 = uVar17 + 1;
        }
        if (lVar8 == null) throw; // [null/range check failed]
        if (0 < *(int *)(lVar8 + 24)) {
          lVar9 = new MissionData(0);
          MeetingController.GetMissionRandomDifficulty(this,targetHero,0);
          if (lVar9 == null) throw; // [null/range check failed]
          uVar14 = 0;
          uVar13 = CONCAT44(uVar4,4);
          lVar9 = MissionData.SetForceMission(lVar9,"外交羞辱",15);
          if ((lVar9 == null) || (lVar10 = *(int64 *)(lVar9 + 120)) == null) throw; // [null/range check failed]
          if (*(int *)(lVar10 + 24) == 0) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar10 = *(int64 *)(*(int64 *)(lVar10 + 16) + 32);
          if ((lVar10 == null) || (lVar10 = *(int64 *)(lVar10 + 56)) == null) throw; // [null/range check failed]
          if (*(int *)(lVar10 + 24) == 0) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar10 = *(int64 *)(*(int64 *)(lVar10 + 16) + 32);
          local_res20[0] =
               MeetingController.GetRandomForceByMissionDifficulty
                         (this,lVar8,*(uint32 *)(lVar9 + 44),0,uVar13,uVar14);
          uVar4 = (uint32)((uint64)uVar13 >> 32);
          uVar13 = Int32.ToString(local_res20,0);
          if (lVar10 == null) throw; // [null/range check failed]
          puVar1 = (uint64 *)(lVar10 + 24);
          *puVar1 = uVar13;
          il2cpp_internal(puVar1,uVar13);
          lVar8 = *(int64 *)(lVar9 + 120);
          if (lVar8 == null) throw; // [null/range check failed]
          if (*(int *)(lVar8 + 24) == 0) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar8 = *(int64 *)(*(int64 *)(lVar8 + 16) + 32);
          if ((lVar8 == null) || (lVar8 = *(int64 *)(lVar8 + 56)) == null) throw; // [null/range check failed]
          if (*(int *)(lVar8 + 24) == 0) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar8 = *(int64 *)(*(int64 *)(lVar8 + 16) + 32);
          iVar3 = Mathf.RoundToInt((*(float *)(lVar9 + 44) * 0.4 + 1.0) * 5.0,0);
          if (lVar8 == null) throw; // [null/range check failed]
          *(float *)(lVar8 + 40) = (float)iVar3;
          FUN_18181e0a0(lVar6,lVar9,DAT_181d94908);
        }
        if (lVar7 == null) throw; // [null/range check failed]
        if (*(int *)(lVar7 + 24) < 1) goto LAB_180e5d385;
        lVar8 = new MissionData(0);
        MeetingController.GetMissionRandomDifficulty(this,targetHero,0);
        if (lVar8 == null) throw; // [null/range check failed]
        uVar14 = 0;
        uVar13 = CONCAT44(uVar4,4);
        lVar8 = MissionData.SetForceMission(lVar8,"外交亲善",14);
        if ((lVar8 == null) || (lVar9 = *(int64 *)(lVar8 + 120)) == null) throw; // [null/range check failed]
        if (*(int *)(lVar9 + 24) == 0) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar9 = *(int64 *)(*(int64 *)(lVar9 + 16) + 32);
        if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) throw; // [null/range check failed]
        if (*(int *)(lVar9 + 24) == 0) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar9 = *(int64 *)(*(int64 *)(lVar9 + 16) + 32);
        local_res20[0] =
             MeetingController.GetRandomForceByMissionDifficulty
                       (this,lVar7,*(uint32 *)(lVar8 + 44),0,uVar13,uVar14);
        uVar13 = Int32.ToString(local_res20,0);
        if (lVar9 == null) throw; // [null/range check failed]
        puVar1 = (uint64 *)(lVar9 + 24);
        *puVar1 = uVar13;
        il2cpp_internal(puVar1,uVar13);
        lVar7 = *(int64 *)(lVar8 + 120);
        if (lVar7 == null) throw; // [null/range check failed]
        if (*(int *)(lVar7 + 24) == 0) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
        if ((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 56)) == null) throw; // [null/range check failed]
        if (*(int *)(lVar7 + 24) == 0) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32);
        iVar3 = Mathf.RoundToInt(*(float *)(lVar8 + 44) * 0.4 + 1.0,0);
        if (lVar7 == null) throw; // [null/range check failed]
        *(float *)(lVar7 + 40) = (float)iVar3;
        *(uint32 *)(lVar8 + 132) = 0x640;
        LAB_180e5c6b4:
        FUN_18181e0a0(lVar6,lVar8,DAT_181d94908);
        LAB_180e5d385:
        lVar8 = MeetingController.MainFocusText;
        if (lVar8 == null) {
          uVar13 = **(uint64 **)(DAT_181d7d580 + 184);
          lVar8 = new OnTooltipCB(uVar13,DAT_181da7d48,DAT_181dab638);
          MeetingController.MainFocusText = lVar8;
        }
        if (lVar6 != null) {
          List_1.Sort(lVar6,lVar8,DAT_181d94b88);
          return lVar6;
        }
    }

    // Token : 0x6001917
    // RVA   : 0xE5D800   Offset: 0xE5CC00   Length: 0x247
    public int GetRandomForceByMissionDifficulty(List<int> availableForceID, float difficulty)
    {
        uint32
        MeetingController.GetRandomForceByMissionDifficulty
                (int64 this,int64 availableForceID,float difficulty)
        {
        uint32 uVar1;
        uint32 uVar2;
        int64 lVar3;
        int64 lVar4;
        int64 lVar5;
        int iVar6;
        float fVar7;
        lVar3 = il2cpp_internal(DAT_181d93cd0);
        FUN_18132faf0(lVar3,DAT_181d8f098);
        iVar6 = 0;
        if (availableForceID != null) {
          for (; iVar6 < *(int *)(availableForceID + 24); iVar6 = iVar6 + 1) {
            lVar4 = FUN_18046c0a0(0);
            if (lVar4 == null) throw; // [null/range check failed]
            lVar4 = *(int64 *)(lVar4 + 32);
            uVar1 = FUN_1800d6760(availableForceID,iVar6);
            if (((lVar4 == null) || (lVar4 = WorldData.GetForce(lVar4,uVar1)) == null) ||
               (lVar4 = ForceData.MainArea(lVar4,0)) == null) throw; // [null/range check failed]
            lVar4 = *(int64 *)(lVar4 + 64);
            if (((this.targetForce == null) ||
                (lVar5 = ForceData.MainArea(this.targetForce,0)) == null) ||
               (lVar4 == null)) throw; // [null/range check failed]
            fVar7 = (float)BigMapPos.Distance(lVar4,*(uint64 *)(lVar5 + 64));
            if (fVar7 <= difficulty * 250.0 + 1500.0) {
              uVar1 = FUN_1800d6760(availableForceID,iVar6,DAT_181d8fa18);
              if (lVar3 == null) throw; // [null/range check failed]
              FUN_18182a0b0(lVar3,uVar1);
            }
          }
          if (lVar3 != null) {
            if (*(int *)(lVar3 + 24) == 0) {
              uVar2 = FUN_180d95a30(0,*(int *)(availableForceID + 24),0);
              if (*(uint32 *)(availableForceID + 24) <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar3 = *(int64 *)(availableForceID + 16);
            }
            else {
              uVar2 = FUN_180d95a30(0,*(int *)(lVar3 + 24),0);
              if (*(uint32 *)(lVar3 + 24) <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar3 = *(int64 *)(lVar3 + 16);
            }
            return lVar3[uVar2];
          }
        }
    }

    // Token : 0x6001918
    // RVA   : 0xE5D4B0   Offset: 0xE5C8B0   Length: 0x1E1
    public List<int> GetLivingSkillDiffiCulty(List<int> originList, float difficulty)
    {
        int64 MeetingController.GetLivingSkillDiffiCulty
                         (uint64 this,int64 originList,float difficulty)
        {
        uint32 uVar1;
        int64 lVar2;
        int64 lVar3;
        int iVar4;
        float fVar5;
        lVar2 = il2cpp_internal(DAT_181d93cd0);
        FUN_18132faf0(lVar2,DAT_181d8f098);
        iVar4 = 0;
        if (originList != null) {
          while( true ) {
            if (*(int *)(originList + 24) <= iVar4) {
              return lVar2;
            }
            lVar3 = FUN_18046c0a0(0);
            if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
               (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) == null) break;
            lVar3 = *(int64 *)(lVar3 + 0x158);
            uVar1 = FUN_1800d6760(originList,iVar4,DAT_181d8fa18);
            if (lVar3 == null) break;
            fVar5 = (float)FUN_1800d6790(lVar3,uVar1,DAT_181da1078);
            if (ABS(difficulty - fVar5 * 0.125) < 0.5) {
              uVar1 = FUN_1800d6760(originList,iVar4,DAT_181d8fa18);
              if (lVar2 == null) break;
              FUN_18182a0b0(lVar2,uVar1,DAT_181d8f218);
            }
            iVar4 = iVar4 + 1;
          }
        }
    }

    // Token : 0x6001919
    // RVA   : 0xE5DA50   Offset: 0xE5CE50   Length: 0x155
    public List<int> GetSkillRarelv(List<int> originList, int targetRareLv)
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        int iVar4;
        lVar2 = il2cpp_internal(DAT_181d93cd0);
        FUN_18132faf0(lVar2,DAT_181d8f098);
        iVar4 = 0;
        if (originList != null) {
          while( true ) {
            if (*(int *)(originList + 24) <= iVar4) {
              return lVar2;
            }
            lVar3 = FUN_18046c100(0);
            uVar1 = FUN_1800d6760(originList,iVar4,DAT_181d8fa18);
            if (lVar3 == null) break;
            lVar3 = GameDataController.GetSkillDataBase(lVar3,uVar1,0);
            if (lVar3 == null) break;
            if (*(int *)(lVar3 + 52) == targetRareLv) {
              uVar1 = FUN_1800d6760(originList,iVar4,DAT_181d8fa18);
              if (lVar2 == null) break;
              FUN_18182a0b0(lVar2,uVar1,DAT_181d8f218);
            }
            iVar4 = iVar4 + 1;
          }
        }
    }

    // Token : 0x600191A
    // RVA   : 0xE57910   Offset: 0xE56D10   Length: 0xD7
    public void AddNewForceMissionButton(MissionData targetMission)
    {
        ulong uVar1;
        ulong uVar2;
        long lVar3;
        uVar2 = this.monthMissionGrid;
        uVar1 = this.monthMissionButtonPrefab;
        uVar2 = GlobalData.AddChild(uVar2,uVar1,0);
        this.newObj = uVar2;
        if (this.newObj != null) {
          lVar3 = GameObject.GetComponent(this.newObj,DAT_181d725f0);
          if (lVar3 != null) {
            *(uint64 *)(lVar3 + 24) = targetMission;
            return;
          }
        }
    }

    // Token : 0x600191B
    // RVA   : 0xE60B60   Offset: 0xE5FF60   Length: 0xB52
    public void PlayerReciveForceMission(MissionData targetMission)
    {
        int iVar1;
        ulong uVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        if (((GameController._instance != null) &&
            (lVar4 = GameController._instance.worldData) != null) &&
           (lVar4 = WorldData.Player(lVar4,0)) != null) {
          *(uint64 *)(lVar4 + 0x2e0) = targetMission;
          if (((GameController._instance != null) &&
              (lVar4 = GameController._instance.worldData) != null) &&
             (lVar4 = WorldData.Player(lVar4,0)) != null) {
            if (*(int64 *)(lVar4 + 0x2e0) == 0) {
              return;
            }
            if ((((GameController._instance != null) &&
                 (lVar4 = GameController._instance.worldData) != null) &&
                (lVar4 = WorldData.Player(lVar4,0)) != null) &&
               ((*(int64 *)(lVar4 + 0x2e0) != 0 &&
                (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 0x2e0) + 120)) != null))) {
              if (lVar4.TestBuildPlayer == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 32);
              if ((lVar4 = lVar4?.enterAreaBountyAttackHero) != null) {
                if (lVar4.TestBuildPlayer == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 32);
                if (lVar4 != null) {
                  iVar1 = *(int *)(lVar4 + 16);
                  if (iVar1 == 1) {
                    lVar4 = FUN_18046c0a0(0);
                    if (lVar4 == null) throw; // [null/range check failed]
                    lVar4 = lVar4.worldData;
                    lVar5 = FUN_18046c0a0(0);
                    if ((((lVar5 == null) || (lVar5.villageAreaID == null)) ||
                        (lVar5 = WorldData.Player(lVar5.villageAreaID,0)) == null) ||
                       ((*(int64 *)(lVar5 + 0x2e0) == 0 ||
                        (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 0x2e0) + 120)) == null)))
                    throw; // [null/range check failed]
                    if (lVar5.cityAreaID == null) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar5 = *(int64 *)(lVar5.chapter + 32);
                    if ((lVar5 = lVar5?.Inns) == null)
                    throw; // [null/range check failed]
                    if (lVar5.cityAreaID == null) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar5 = *(int64 *)(lVar5.chapter + 32);
                    if ((lVar5 == null) ||
                       (uVar3 = Int32.Parse(lVar5.cityAreaID,0), lVar4 == null))
                    throw; // [null/range check failed]
                    lVar4 = WorldData.GetArea(lVar4,uVar3,0);
                    if ((lVar4 == null) || (*(int64 *)(lVar4 + 0x100) == 0)) throw; // [null/range check failed]
                    *(uint32 *)(*(int64 *)(lVar4 + 0x100) + 16) = 1;
                  }
                  else if (iVar1 == 18) {
                    lVar4 = FUN_18046c0a0(0);
                    if (lVar4 == null) throw; // [null/range check failed]
                    lVar4 = lVar4.worldData;
                    lVar5 = FUN_18046c0a0(0);
                    if ((((lVar5 == null) || (lVar5.villageAreaID == null)) ||
                        (lVar5 = WorldData.Player(lVar5.villageAreaID,0)) == null) ||
                       ((*(int64 *)(lVar5 + 0x2e0) == 0 ||
                        (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 0x2e0) + 120)) == null)))
                    throw; // [null/range check failed]
                    if (lVar5.cityAreaID == null) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar5 = *(int64 *)(lVar5.chapter + 32);
                    if ((lVar5 = lVar5?.Inns) == null)
                    throw; // [null/range check failed]
                    if (lVar5.cityAreaID == null) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar5 = *(int64 *)(lVar5.chapter + 32);
                    if ((lVar5 == null) ||
                       (uVar3 = Int32.Parse(lVar5.cityAreaID,0), lVar4 == null))
                    throw; // [null/range check failed]
                    lVar4 = WorldData.GetArea(lVar4,uVar3,0);
                    if ((lVar4 == null) ||
                       ((lVar4 = AreaData.GetForce(lVar4,0), lVar4 == null ||
                        (*(int64 *)(lVar4 + 0x168) == 0)))) throw; // [null/range check failed]
                    *(uint32 *)(*(int64 *)(lVar4 + 0x168) + 24) = 1;
                  }
                  else if (iVar1 != 19) {
                    if (iVar1 == 20) {
                      lVar4 = FUN_18046c0a0(0);
                      if ((((lVar4 == null) || (lVar4.worldData == null)) ||
                          (lVar4 = WorldData.Player(lVar4.worldData,0)) == null) ||
                         ((*(int64 *)(lVar4 + 0x2e0) == 0 ||
                          (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 0x2e0) + 120)) == null)))
                      throw; // [null/range check failed]
                      if (lVar4.TestBuildPlayer == null) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 32);
                      if ((this.AttackAreaForceMissionData == null) ||
                         (plVar6 = (int64 *)EventData.Clone(this.AttackAreaForceMissionData,0),
                         lVar4 == null)) throw; // [null/range check failed]
                      if (plVar6 == (int64 *)0) {
                        lVar4.worldData = 0;
                      }
                      else {
                        lVar4.worldData = plVar6;
                      }
                    }
                    else if (iVar1 == 21) {
                      lVar4 = FUN_18046c0a0(0);
                      if (lVar4 == null) throw; // [null/range check failed]
                      lVar4 = lVar4.worldData;
                      lVar5 = FUN_18046c0a0(0);
                      if ((((lVar5 == null) || (lVar5.villageAreaID == null)) ||
                          (lVar5 = WorldData.Player(lVar5.villageAreaID,0)) == null) ||
                         ((*(int64 *)(lVar5 + 0x2e0) == 0 ||
                          (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 0x2e0) + 120)) == null)))
                      throw; // [null/range check failed]
                      if (lVar5.cityAreaID == null) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar5 = *(int64 *)(lVar5.chapter + 32);
                      if ((lVar5 = lVar5?.Inns) == null)
                      throw; // [null/range check failed]
                      if (lVar5.cityAreaID == null) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar5 = *(int64 *)(lVar5.chapter + 32);
                      if ((lVar5 == null) ||
                         (uVar3 = Int32.Parse(lVar5.cityAreaID,0), lVar4 == null))
                      throw; // [null/range check failed]
                      lVar4 = WorldData.GetArea(lVar4,uVar3,0);
                      if ((lVar4 == null) || (*(int64 *)(lVar4 + 0x100) == 0)) throw; // [null/range check failed]
                      *(uint32 *)(*(int64 *)(lVar4 + 0x100) + 20) = 1;
                    }
                  }
                  if ((((GameController._instance != null) &&
                       (lVar4 = GameController._instance.worldData) != null)
                      && (lVar4 = WorldData.Player(lVar4,0)) != null) &&
                     ((*(int64 *)(lVar4 + 0x2e0) != 0 &&
                      (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 0x2e0) + 120)) != null))) {
                    if (lVar4.TestBuildPlayer == null) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 32);
                    if (lVar4 != null) {
                      if (lVar4.worldData != null) {
                        lVar4 = FUN_18046c0a0(0);
                        if ((((lVar4 == null) || (lVar4.worldData == null)) ||
                            (lVar4 = WorldData.Player(lVar4.worldData,0)) == null) ||
                           ((*(int64 *)(lVar4 + 0x2e0) == 0 ||
                            (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 0x2e0) + 120)) == null)))
                        throw; // [null/range check failed]
                        if (lVar4.TestBuildPlayer == null) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 32);
                        if (lVar4 == null) throw; // [null/range check failed]
                        lVar4 = lVar4.worldData;
                        lVar5 = FUN_18046c0a0(0);
                        if (((lVar5 == null) || (lVar5.villageAreaID == null)) ||
                           ((lVar5 = WorldData.Player(lVar5.villageAreaID,0), lVar5 == null ||
                            ((*(int64 *)(lVar5 + 0x2e0) == 0 || (lVar4 == null)))))) throw; // [null/range check failed]
                        *(uint32 *)(lVar4 + 108) =
                             *(uint32 *)(*(int64 *)(lVar5 + 0x2e0) + 44);
                        lVar4 = FUN_18046c0a0(0);
                        if ((lVar4 == null) ||
                           ((((lVar4.worldData == null ||
                              (lVar4 = WorldData.Player(lVar4.worldData,0)) == null) ||
                             (*(int64 *)(lVar4 + 0x2e0) == 0)) ||
                            (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 0x2e0) + 120)) == null)))
                        throw; // [null/range check failed]
                        if (lVar4.TestBuildPlayer == null) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar4 = *(int64 *)(*(int64 *)(lVar4 + 16) + 32);
                        if ((lVar4 = lVar4?.worldData) == null)
                        throw; // [null/range check failed]
                        *(uint8 *)(lVar4 + 101) = 1;
                        lVar4 = FUN_18046c0a0(0);
                        lVar5 = FUN_18046c0a0(0);
                        if ((((lVar5 == null) ||
                             ((lVar5.villageAreaID == null ||
                              (lVar5 = WorldData.Player(lVar5.villageAreaID,0)) == null))) ||
                            (*(int64 *)(lVar5 + 0x2e0) == 0)) ||
                           (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 0x2e0) + 120)) == null)
                        throw; // [null/range check failed]
                        if (lVar5.cityAreaID == null) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar5 = *(int64 *)(lVar5.chapter + 32);
                        if (lVar5 == null) throw; // [null/range check failed]
                        uVar2 = lVar5.villageAreaID;
                        lVar5 = FUN_18046c0a0(0);
                        if ((((lVar5 == null) || (lVar5.villageAreaID == null)) ||
                            (lVar5 = WorldData.Player(lVar5.villageAreaID,0)) == null) ||
                           ((*(int64 *)(lVar5 + 0x2e0) == 0 ||
                            (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 0x2e0) + 120)) == null)))
                        throw; // [null/range check failed]
                        if (lVar5.cityAreaID == null) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar5 = *(int64 *)(lVar5.chapter + 32);
                        if ((lVar5 = lVar5?.Inns) == null)
                        throw; // [null/range check failed]
                        if (lVar5.cityAreaID == null) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar5 = *(int64 *)(lVar5.chapter + 32);
                        if ((lVar5 == null) ||
                           (uVar3 = Int32.Parse(lVar5.cityAreaID,0), lVar4 == null))
                        throw; // [null/range check failed]
                        GameController.CreateAreaMapRandomEvent(lVar4,uVar2,uVar3,0);
                      }
                      lVar4 = GameController._instance;
                      if ((((GameController._instance != null) &&
                           (lVar5 = GameController._instance.worldData,
                           lVar5 != null)) && (lVar5 = WorldData.Player(lVar5,0)) != null) &&
                         (lVar4 != null)) {
                        GameController.ChangeMissionTargetNumCount
                                  (lVar4,*(uint64 *)(lVar5 + 0x2e0),1,0);
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

    // Token : 0x600191C
    // RVA   : 0xE616C0   Offset: 0xE60AC0   Length: 0x186
    public void RefuseMonthMissionButtonClicked()
    {
        int iVar1;
        long lVar2;
        long lVar3;
        if ((GameController._instance != null) &&
           (lVar2 = GameController._instance.worldData) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if ((GameController._instance != null) &&
             (lVar3 = GameController._instance.worldData) != null) {
            lVar3 = WorldData.Player(lVar3,0);
            if (lVar3 != null) {
              iVar1 = HeroData.GetMissMeetingReduceContribution(lVar3,0);
              if (lVar2 != null) {
                HeroData.ChangeForceContribution(lVar2,(float)iVar1 * 0.5,1,0xffffffff,0);
                MeetingController.PlayerReciveForceMission(this,0,0);
                MeetingController.FinishMonthMission(this,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x600191D
    // RVA   : 0xE5DDD0   Offset: 0xE5D1D0   Length: 0x1F8
    public void MonthMissionButtonClicked(GameObject buttonClicked)
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        if (buttonClicked != null) {
          lVar2 = GameObject.GetComponent(buttonClicked,DAT_181d725f0);
          if (lVar2 != null) {
            if (lVar2.forceName != null) {
              lVar2 = GameObject.GetComponent(buttonClicked,DAT_181d725f0);
              if ((lVar2 == null) || (lVar2.forceName == null)) throw; // [null/range check failed]
              if (0 < *(int *)(lVar2.forceName + 132)) {
                lVar2 = this.targetForce;
                lVar3 = GameObject.GetComponent(buttonClicked,DAT_181d725f0);
                if (((lVar3 == null) || (*(int64 *)(lVar3 + 24) == 0)) || (lVar2 == null))
                throw; // [null/range check failed]
                cVar1 = ForceData.HaveResource(lVar2,0);
                if (!cVar1) {
                  lVar2 = FUN_18046c0a0(0);
                  if (lVar2 != null) {
                    GameController.ShowTextOnMouse(lVar2,"门派银钱不足！",0);
                    plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
                    plVar5 = (int64 *)0;
                    if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181daf348)) {
                      plVar5 = plVar4;
                    }
                    NGUITools.PlaySound(plVar5,0);
                    return;
                  }
                  throw; // [null/range check failed]
                }
              }
            }
            lVar2 = GameObject.GetComponent(buttonClicked,DAT_181d725f0);
            if (lVar2 != null) {
              MeetingController.PlayerReciveForceMission(this,lVar2.forceName,0);
              MeetingController.FinishMonthMission(this,0);
              return;
            }
          }
        }
    }

    // Token : 0x600191E
    // RVA   : 0xE57FF0   Offset: 0xE573F0   Length: 0x85A
    public void FinishMonthMission()
    {
        var pStatics = *(int64*)(DAT_181d94000 + 184);
        int iVar2;
        uint uVar3;
        long lVar4;
        ulong uVar6;
        long lVar7;
        long lVar8;
        ulong uVar9;
        int iVar11;
        float fVar12;
        float fVar13;
        ulong local_168;
        float local_160;
        ulong local_158;
        float local_150;
        ulong local_148;
        uint uStack_140;
        uint32 uStack_13c;
        uint64 local_138;
        uint64 uStack_130;
        uint64 local_128;
        uint64 local_118;
        float local_110;
        uint64 local_108;
        uint32 local_100;
        uint8 local_f8 [16];
        uint8 local_e8 [16];
        uint8 local_d8 [16];
        uint8 local_c8 [16];
        uint8 local_b8 [16];
        uint8 local_a8 [16];
        uint8 local_98 [128];
        local_138 = 0;
        uStack_130 = 0;
        if (this.monthMissionPanel != null) {
          GameObject.SetActive(this.monthMissionPanel,0,0);
          if (*pStatics != 0) {
            QuickTravelUIController.HideQuickTravelUI(*pStatics,0);
            if (((*pStatics != 0) &&
                (lVar4 = *(int64 *)(*pStatics + 32)) != null) &&
               (lVar4 = GameObject.get_transform(lVar4,0)) != null) {
              lVar4 = Transform.Find(lVar4,"MapRoot",0);
              puVar5 = (uint64 *)Vector3.get_zero(&local_148,0);
              if (lVar4 != null) {
                local_160 = *(float *)(puVar5 + 1);
                local_168 = *puVar5;
                Transform.set_localPosition(lVar4,&local_168,0);
                uVar6 = this.monthMissionGrid;
                GlobalData.DeleteAllChild(uVar6,0);
                uVar6 = il2cpp_internal(DAT_181d94b50);
                FUN_18132faf0(uVar6,DAT_181d94888);
                lVar4 = this.heroGrid;
                iVar11 = 0;
                if (lVar4 != null) {
                  while (lVar4 = GameObject.get_transform(lVar4,0)) != null {
                    iVar2 = Transform.get_childCount(lVar4,0);
                    if (iVar2 <= iVar11) {
                      this.subMeetingStep = this.subMeetingStep + 1;
                      MeetingController.NextStep(this,0);
                      return;
                    }
                    if (((this.heroGrid == null) ||
                        (lVar4 = GameObject.get_transform(this.heroGrid,0)) == null)
                       || ((lVar4 = Transform.GetChild(lVar4,iVar11,0), lVar4 == null ||
                           ((lVar4 = Component.GetComponent(lVar4,DAT_181d940e0), lVar4 == null ||
                            (lVar4 = *(int64 *)(lVar4 + 32)) == null))))) break;
                    if (*(int *)(lVar4 + 88) != 0) {
                      lVar7 = MeetingController.GetAvailableMissions(this,lVar4,0);
                      if (lVar7 == null) break;
                      uVar3 = FUN_180d95a30(0,*(uint32 *)(lVar7 + 24),0);
                      uVar6 = FUN_180002f80(lVar7,uVar3,DAT_181d94c88);
                      *(uint64 *)(lVar4 + 0x2e0) = uVar6;
                    }
                    uVar6 = this.meetingPanel;
                    uVar9 = this.lastMonthContributionUIPrefab;
                    lVar7 = GlobalData.AddChild(uVar6,uVar9,0);
                    this.newObj = lVar7;
                    if (*plVar1 == 0) break;
                    lVar7 = GameObject.get_transform(*plVar1,0);
                    if (((this.heroGrid == null) ||
                        (lVar8 = GameObject.get_transform(this.heroGrid,0)) == null)
                       || (lVar8 = Transform.GetChild(lVar8,iVar11,0)) == null) break;
                    puVar5 = (uint64 *)Transform.get_position(local_f8,lVar8,0);
                    local_158 = *puVar5;
                    local_150 = *(float *)(puVar5 + 1);
                    if (((this.heroGrid == null) ||
                        (lVar8 = GameObject.get_transform(this.heroGrid,0)) == null)
                       || ((lVar8 = Transform.GetChild(lVar8,iVar11,0), lVar8 == null ||
                           (lVar8 = Component.GetComponent(lVar8,DAT_181d94f60)) == null))) break;
                    puVar5 = (uint64 *)RectTransform.get_rect(local_b8,lVar8,0);
                    local_138 = *puVar5;
                    uStack_130 = puVar5[1];
                    fVar12 = (float)FUN_18044e2b0(&local_138,0);
                    if (((this.heroGrid == null) ||
                        (lVar8 = GameObject.get_transform(this.heroGrid,0)) == null)
                       || (lVar8 = Transform.GetChild(lVar8,iVar11,0)) == null) break;
                    puVar5 = (uint64 *)Transform.get_lossyScale(local_e8,lVar8,0);
                    local_128 = *puVar5;
                    if ((*plVar1 == 0) ||
                       (lVar8 = GameObject.GetComponent(*plVar1,DAT_181d72bc8)) == null) break;
                    puVar5 = (uint64 *)RectTransform.get_rect(local_a8,lVar8,0);
                    local_138 = *puVar5;
                    uStack_130 = puVar5[1];
                    fVar13 = (float)FUN_18044e2b0(&local_138,0);
                    if ((*plVar1 == 0) || (lVar8 = GameObject.get_transform(*plVar1,0)) == null)
                    break;
                    puVar5 = (uint64 *)Transform.get_lossyScale(local_d8,lVar8,0);
                    local_148 = *puVar5;
                    uStack_140 = *(uint32 *)(puVar5 + 1);
                    fVar13 = (float)((uint64)local_148 >> 32) * fVar13 + local_128._4_4_ * fVar12;
                    fVar12 = fVar13 * 0.0;
                    local_160 = local_150 + fVar12;
                    local_168 = CONCAT44(fVar13 * 0.5 + local_158._4_4_,(float)local_158 + fVar12);
                    if (lVar7 == null) break;
                    local_118 = local_168;
                    local_110 = local_160;
                    Transform.set_position(lVar7,&local_118,0);
                    if (((*plVar1 == 0) || (lVar7 = GameObject.get_transform(*plVar1,0)) == null) ||
                       (lVar7 = Transform.Find(lVar7,"Text",0)) == null) break;
                    uVar9 = Component.GetComponent(lVar7,DAT_181d96160);
                    uVar6 = "无任务";
                    if (*(int64 *)(lVar4 + 0x2e0) != 0) {
                      uVar6 = *(uint64 *)(*(int64 *)(lVar4 + 0x2e0) + 24);
                    }
                    LTLocalization.SetText(uVar9,uVar6,0);
                    if (((*plVar1 == 0) || (lVar4 = GameObject.get_transform(*plVar1,0)) == null) ||
                       (lVar4 = Transform.Find(lVar4,"Text",0)) == null) break;
                    plVar10 = (int64 *)Component.GetComponent(lVar4,DAT_181d96160);
                    puVar5 = (uint64 *)Color.get_black(local_98,0);
                    if (plVar10 == (int64 *)0) break;
                    local_148 = *puVar5;
                    uStack_140 = *(uint32 *)(puVar5 + 1);
                    uStack_13c = *(uint32 *)((int64)puVar5 + 12);
                    (**(code **)(*plVar10 + 0x2a8))(plVar10,&local_148,*(uint64 *)(*plVar10 + 0x2b0));
                    if (*plVar1 == 0) break;
                    lVar4 = GameObject.get_transform(*plVar1,0);
                    puVar5 = (uint64 *)Vector3.get_zero(local_c8,0);
                    if (lVar4 == null) break;
                    local_100 = *(uint32 *)(puVar5 + 1);
                    local_108 = *puVar5;
                    Transform.set_localScale(lVar4,&local_108,0);
                    if (*plVar1 == 0) break;
                    uVar6 = GameObject.get_transform(*plVar1,0);
                    uVar6 = ShortcutExtensions.DOScale(uVar6);
                    uVar6 = TweenSettingsExtensions.SetEase(uVar6,27,DAT_181dc0f80);
                    TweenSettingsExtensions.SetDelay(uVar6,(float)iVar11 * 0.1,DAT_181dc0c60);
                    if (this.monthMissionResultUIs == null) break;
                    FUN_18181e0a0();
                    lVar4 = this.heroGrid;
                    iVar11 = iVar11 + 1;
                    if (lVar4 == null) break;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x600191F
    // RVA   : 0xE579F0   Offset: 0xE56DF0   Length: 0xD2
    public void AttackAreaAdviseChoosen(int targetArea)
    {
        var pStatics = *(int64*)(DAT_181d94000 + 184);
        long lVar1;
        bool cVar2;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
          cVar2 = GameObject.get_activeSelf(lVar1,0);
          if (cVar2) {
            if (*pStatics == 0) throw; // [null/range check failed]
            QuickTravelUIController.HideQuickTravelUI(*pStatics,0);
          }
          if (targetArea != this.attackAreaID) {
            this.adviseAttackAreaID = targetArea;
            MeetingController.NextStep(this,0);
            return;
          }
          this.meetingStep = this.meetingStep + 1;
          this.subMeetingStep = 0;
          MeetingController.NextStep(this,0);
          return;
        }
    }

    // Token : 0x6001920
    // RVA   : 0xE5DBB0   Offset: 0xE5CFB0   Length: 0xE3
    public void GivingAttackAreaAdvise(string sure)
    {
        var pStatics = *(int64*)(DAT_181d94000 + 184);
        bool cVar1;
        cVar1 = FUN_18171e540(sure,"true",0);
        if (!cVar1) {
          cVar1 = FUN_18171e540(sure,"false",0);
          if (cVar1) {
            this.meetingStep = this.meetingStep + 1;
            this.subMeetingStep = 0;
            MeetingController.NextStep(this,0);
          }
          return;
        }
        if (*pStatics != 0) {
          QuickTravelUIController.ShowQuickTravelUI
                    (*pStatics,3,0x3f800000,1,0);
          return;
        }
    }

    // Token : 0x6001921
    // RVA   : 0xE5DCA0   Offset: 0xE5D0A0   Length: 0x121
    public void GivingMeetingAdvise(string sure)
    {
        long lVar1;
        bool cVar2;
        cVar2 = FUN_18171e540(sure,"true",0);
        if (!cVar2) {
          cVar2 = FUN_18171e540(sure,"false",0);
          if (cVar2) {
            this.meetingStep = this.meetingStep + 1;
            this.subMeetingStep = 0;
            MeetingController.NextStep(this,0);
          }
          return;
        }
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d91b88 + 184) + 24);
        if (lVar1 != null) {
          PlotController.GiveMeetingAdvise(lVar1,0);
          return;
        }
    }

    // Token : 0x6001922
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6001923
    // RVA   : 0xE62E50   Offset: 0xE62250   Length: 0x270
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d88a10 + 184);
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d97750);
        FUN_18132faf0(lVar1,DAT_181da3bd8);
        if (lVar1 != null) {
          FUN_18181e0a0(lVar1,"衰微",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"孱弱",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"中庸",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"强大",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"称霸",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"鼎盛",DAT_181da3d58);
          plVar2 = pStatics;
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          lVar1 = il2cpp_internal(DAT_181d97750);
          FUN_18132faf0(lVar1,DAT_181da3bd8);
          if (lVar1 != null) {
            FUN_18181e0a0(lVar1,"谋求发展",DAT_181da3d58);
            FUN_18181e0a0(lVar1,"巩固实力",DAT_181da3d58);
            FUN_18181e0a0(lVar1,"稳步防守",DAT_181da3d58);
            FUN_18181e0a0(lVar1,"转守为攻",DAT_181da3d58);
            FUN_18181e0a0(lVar1,"攻城略地",DAT_181da3d58);
            FUN_18181e0a0(lVar1,"一统武林",DAT_181da3d58);
            MeetingController.MainFocusText = lVar1;
            return;
          }
        }
    }

}
