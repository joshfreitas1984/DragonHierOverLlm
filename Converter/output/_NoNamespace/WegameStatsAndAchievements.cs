// ============================================================
// Type  : WegameStatsAndAchievements
// Token : 0x20003B4
// ============================================================

public class WegameStatsAndAchievements
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001DFF
    private IRailAchievementHelper achievement_helper_;

    // Token: 0x4001E00
    private IRailGlobalAchievement global_achievement_;

    // Token: 0x4001E01
    public IRailPlayerAchievement player_achievement_;

    // Token: 0x4001E02
    public IRailUtils rail_util_;

    // Token: 0x4001E03
    private static WegameStatsAndAchievements instance_;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002393
    // RVA   : 0x9C9580   Offset: 0x9C8980   Length: 0xE8
    public static WegameStatsAndAchievements get_Instance()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uVar3 = **(uint64 **)(DAT_181db5798 + 184);
        cVar1 = Object.op_Inequality(uVar3,0,0);
        if (cVar1) {
          return **(uint64 **)(DAT_181db5798 + 184);
        }
        lVar2 = new GameObject("WegameStatsAndAchievements",0);
        if (lVar2 != null) {
          uVar3 = GameObject.AddComponent(lVar2,DAT_181dc6d20);
          return uVar3;
        }
    }

    // Token : 0x6002394
    // RVA   : 0x9C8F90   Offset: 0x9C8390   Length: 0x374
    private void Start()
    {
        bool cVar2;
        ulong uVar3;
        long lVar4;
        if (**(int **)(DAT_181d73d40 + 184) != 1) {
          uVar3 = Component.get_gameObject(this,0);
          Object.Destroy(uVar3,0);
          return;
        }
        uVar3 = **(uint64 **)(DAT_181db5798 + 184);
        cVar2 = Object.op_Inequality(uVar3,0,0);
        if (!cVar2) {
          puVar1 = *(uint64 **)(DAT_181db5798 + 184);
          *puVar1 = this;
          il2cpp_internal(puVar1,this);
          uVar3 = Component.get_gameObject(this,0);
          Object.DontDestroyOnLoad(uVar3,0);
          lVar4 = FUN_18046c100(0);
          if (lVar4 != null) {
            GameDataController.ResetDlcState(lVar4,0);
            cVar2 = RailManager.get_Initialized(0);
            if (!cVar2) {
              Debug.LogError("Rail sdk is not initialized!",0);
              return;
            }
            lVar4 = RailCallBackHelper.get_Instance(0);
            uVar3 = new OnTooltipCB(this,DAT_181d793d8,0);
            if (lVar4 != null) {
              RailCallBackHelper.RegisterCallback(lVar4,0x835,uVar3,0);
              lVar4 = RailCallBackHelper.get_Instance(0);
              uVar3 = new OnTooltipCB(this,DAT_181d793d8,0);
              if (lVar4 != null) {
                RailCallBackHelper.RegisterCallback(lVar4,0x837,uVar3,0);
                lVar4 = RailCallBackHelper.get_Instance(0);
                uVar3 = new OnTooltipCB(this,DAT_181d793d8,0);
                if (lVar4 != null) {
                  RailCallBackHelper.RegisterCallback(lVar4,0x836,uVar3,0);
                  WegameStatsAndAchievements.InitPlayerAchivement(this,0);
                  WegameStatsAndAchievements.CheckDLCState(this,0);
                  return;
                }
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        uVar3 = Component.get_gameObject(this,0);
        Object.Destroy(uVar3,0);
    }

    // Token : 0x6002395
    // RVA   : 0x9C7170   Offset: 0x9C6570   Length: 0x439
    private void CheckDLCState()
    {
        long lVar1;
        int iVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        int[] local_res18 = new int[2];
        local_res18[0] = 0;
        do {
          iVar2 = local_res18[0];
          lVar3 = PlotController.LaBaFestivelResultTalkText;
          if (lVar3 == null) goto LAB_1809c75a4;
          if (*(int *)(lVar3 + 24) <= iVar2) {
            return;
          }
          lVar3 = rail_api.RailFactory(0);
          if (lVar3 == null) {
        LAB_1809c74c0:
            uVar5 = Int32.ToString(local_res18,0);
            uVar5 = String.Concat("DLC",uVar5," 0",0);
            Debug.Log(uVar5,0);
            lVar3 = GameController.difficultyExtraPoint;
            if (lVar3 == null) goto LAB_1809c75a4;
            lVar3 = *(int64 *)(lVar3 + 16);
            uVar5 = Int32.ToString(local_res18,0);
            uVar5 = String.Concat("DLC",uVar5,0);
            if (lVar3 == null) goto LAB_1809c75a4;
            uVar6 = 0;
          }
          else {
            lVar3 = rail_api.RailFactory(0);
            if (lVar3 == null) {
        LAB_1809c75a4:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar3 = FUN_180002970(19,DAT_181d7b780,lVar3);
            lVar4 = il2cpp_internal(DAT_181d95950);
            FUN_18132faf0(lVar4,DAT_181d99908);
            lVar1 = PlotController.LaBaFestivelResultTalkText;
            if (lVar1 == null) goto LAB_1809c75a4;
            uVar5 = FUN_180002f80(lVar1,local_res18[0],DAT_181dab818);
            uVar6 = new RailDlcID(uVar5,0);
            if (lVar4 == null) goto LAB_1809c75a4;
            FUN_18181e0a0(lVar4,uVar6,DAT_181d99988);
            if (lVar3 == null) goto LAB_1809c75a4;
            iVar2 = FUN_180004c70(0,DAT_181d7b600,lVar3,lVar4,"");
            if (iVar2 != 0) goto LAB_1809c74c0;
            uVar5 = Int32.ToString(local_res18,0);
            uVar5 = String.Concat("DLC",uVar5," 1",0);
            Debug.Log(uVar5,0);
            lVar3 = GameController.difficultyExtraPoint;
            if (lVar3 == null) goto LAB_1809c75a4;
            lVar3 = *(int64 *)(lVar3 + 16);
            uVar5 = Int32.ToString(local_res18,0);
            uVar5 = String.Concat("DLC",uVar5,0);
            if (lVar3 == null) goto LAB_1809c75a4;
            uVar6 = 1;
          }
          PlayerPrefDictionary.SetKey(lVar3,uVar5,uVar6);
          local_res18[0] = local_res18[0] + 1;
        } while( true );
    }

    // Token : 0x6002396
    // RVA   : 0x9C8260   Offset: 0x9C7660   Length: 0x9D
    private void OnDestroy()
    {
        ulong uVar1;
        bool cVar3;
        uVar1 = **(uint64 **)(DAT_181db5798 + 184);
        cVar3 = Object.op_Inequality(uVar1,this,0);
        if (!cVar3) {
          puVar2 = *(uint64 **)(DAT_181db5798 + 184);
          *puVar2 = 0;
          il2cpp_internal(puVar2,0);
        }
    }

    // Token : 0x6002397
    // RVA   : 0x9C7A10   Offset: 0x9C6E10   Length: 0x13A
    private RailID GetPlayerID()
    {
        ulong uVar1;
        long lVar2;
        ushort uVar5;
        uVar1 = new RailID(0,0);
        lVar2 = rail_api.RailFactory();
        if (lVar2 == null) {
          return uVar1;
        }
        plVar3 = (int64 *)FUN_180002970(0,DAT_181d7b780,lVar2);
        if (plVar3 == (int64 *)0) {
          return uVar1;
        }
        lVar2 = *plVar3;
        uVar5 = 0;
        if (*(uint16 *)(lVar2 + 0x12a) != 0) {
          do {
            if (*(int64 *)(*(int64 *)(lVar2 + 176) + (uint64)uVar5 * 16) == DAT_181d7c3e0) {
              puVar4 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar2 + 176) + 8 + (uint64)uVar5 * 16) *
                        16 + 0x148 + lVar2);
              goto LAB_1809c7b08;
            }
            uVar5 = uVar5 + 1;
          } while (uVar5 < *(uint16 *)(lVar2 + 0x12a));
        }
        puVar4 = (uint64 *)FUN_1800914f0(plVar3,DAT_181d7c3e0,1);
        LAB_1809c7b08:
        uVar1 = (*(code *)*puVar4)(plVar3,puVar4[1]);
        return uVar1;
    }

    // Token : 0x6002398
    // RVA   : 0x9C8300   Offset: 0x9C7700   Length: 0x765
    public void OnRailEvent(RAILEventID id, EventBase data)
    {
        long lVar1;
        bool cVar2;
        int iVar3;
        int iVar4;
        ulong uVar6;
        ulong uVar8;
        ushort uVar12;
        int[] local_res10 = new int[2];
        int local_48;
        uint local_44;
        uint[] local_40 = new uint[2];
        ulong[] local_38 = new ulong[2];
        local_res10[0] = id;
        local_38[0] = 0;
        plVar5 = (int64 *)il2cpp_value_box(DAT_181d94100,local_res10);
        if (plVar5 != (int64 *)0) {
          uVar6 = (**(code **)(*plVar5 + 0x168))(plVar5,*(uint64 *)(*plVar5 + 0x170));
          piVar7 = (int *)il2cpp_object_unbox(plVar5);
          local_res10[0] = *piVar7;
          if ((data != (int64 *)0) &&
             (plVar5 = (int64 *)il2cpp_value_box(DAT_181d98380,data + 2), plVar5 != (int64 *)0)
             ) {
            uVar8 = (**(code **)(*plVar5 + 0x168))(plVar5,*(uint64 *)(*plVar5 + 0x170));
            puVar9 = (uint32 *)il2cpp_object_unbox(plVar5);
            *(uint32 *)(data + 2) = *puVar9;
            uVar6 = String.Concat("OnRailEvent, id=",uVar6," , result=",uVar8,0);
            Debug.Log(uVar6,0);
            if ((int)data[2] == 0) {
              if (local_res10[0] == 0x837) {
                uVar6 = Int32.ToString(data + 6,0);
                uVar6 = String.Concat("global achievement count:",uVar6,0);
              }
              else {
                if (local_res10[0] != 0x836) {
                  if (local_res10[0] != 0x835) {
                    return;
                  }
                  WegameStatsAndAchievements.GetAllAchievement(this,0);
                  local_48 = 0;
                  while( true ) {
                    iVar3 = local_48;
                    lVar1 = GameController.lockObj;
                    if ((lVar1 == null) || (lVar1 = *(int64 *)(lVar1 + 0x1c0)) == null) break;
                    if (*(int *)(lVar1 + 24) <= iVar3) {
                      return;
                    }
                    plVar5 = this.player_achievement_;
                    uVar6 = Int32.ToString(&local_48,0);
                    uVar6 = String.Concat("Ach",uVar6,0);
                    if (plVar5 == (int64 *)0) break;
                    lVar1 = *plVar5;
                    uVar12 = 0;
                    if (*(uint16 *)(lVar1 + 0x12a) != 0) {
                      do {
                        if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar12 * 16) ==
                            DAT_181d7c458) {
                          puVar10 = (uint64 *)
                                    ((int64)
                                     *(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar12 * 16)
                                     * 16 + 0x168 + lVar1);
                          goto LAB_1809c868c;
                        }
                        uVar12 = uVar12 + 1;
                      } while (uVar12 < *(uint16 *)(lVar1 + 0x12a));
                    }
                    puVar10 = (uint64 *)FUN_1800914f0(plVar5,DAT_181d7c458,3);
        LAB_1809c868c:
                    (*(code *)*puVar10)(plVar5,uVar6,local_38,puVar10[1]);
                    uVar6 = String.Concat("json_result:",local_38[0],0);
                    Debug.Log(uVar6,0);
                    uVar6 = local_38[0];
                    plVar5 = (int64 *)JToken.Parse(uVar6,0);
                    if ((plVar5 == (int64 *)0) ||
                       (plVar11 = (int64 *)
                                  (**(code **)(*plVar5 + 0x218))
                                            (plVar5,"achieved",*(uint64 *)(*plVar5 + 0x220)),
                       plVar11 == (int64 *)0)) break;
                    uVar6 = (**(code **)(*plVar11 + 0x168))(plVar11,*(uint64 *)(*plVar11 + 0x170));
                    cVar2 = FUN_18171e540(uVar6,"1",0);
                    if (cVar2) {
                      lVar1 = GameController.difficultyExtraPoint;
                      if (lVar1 == null) break;
                      lVar1 = *(int64 *)(lVar1 + 16);
                      uVar6 = Int32.ToString(&local_48,0);
                      uVar6 = String.Concat("AchFinished",uVar6,0);
                      if (lVar1 == null) break;
                      PlayerPrefDictionary.SetKey(lVar1,uVar6,"true",0);
                    }
                    plVar5 = (int64 *)
                             (**(code **)(*plVar5 + 0x218))
                                       (plVar5,"cur_value",*(uint64 *)(*plVar5 + 0x220));
                    if (plVar5 == (int64 *)0) break;
                    uVar6 = (**(code **)(*plVar5 + 0x168))(plVar5,*(uint64 *)(*plVar5 + 0x170));
                    iVar3 = Int32.Parse(uVar6,0);
                    lVar1 = GameController.difficultyExtraPoint;
                    if (lVar1 == null) break;
                    lVar1 = *(int64 *)(lVar1 + 16);
                    uVar6 = Int32.ToString(&local_48,0);
                    String.Concat("AchData",uVar6,0);
                    if (lVar1 == null) break;
                    iVar4 = PlayerPrefDictionary.GetInt(lVar1);
                    if (iVar4 < iVar3) {
                      lVar1 = GameController.difficultyExtraPoint;
                      if (lVar1 == null) break;
                      lVar1 = *(int64 *)(lVar1 + 16);
                      uVar6 = Int32.ToString(&local_48,0);
                      uVar6 = String.Concat("AchData",uVar6,0);
                      if (lVar1 == null) break;
                      PlayerPrefDictionary.SetKey(lVar1,uVar6,iVar3,0);
                    }
                    local_48 = local_48 + 1;
                  }
                  throw; // [null/range check failed]
                }
                local_44 = (uint32)data[8];
                lVar1 = data[7];
                uVar6 = il2cpp_value_box(DAT_181db08f8,&local_44);
                local_40[0] = *(uint32 *)((int64)data + 68);
                uVar8 = il2cpp_value_box(DAT_181db08f8,local_40);
                uVar6 = String.Format("achievement_name={0}, current_progress={1}, max_progress={2}",lVar1,uVar6,uVar8,0);
              }
              Debug.Log(uVar6,0);
            }
            return;
          }
        }
    }

    // Token : 0x6002399
    // RVA   : 0x9C7B50   Offset: 0x9C6F50   Length: 0x1DE
    public void InitGlobalAchivement()
    {
        int iVar1;
        long lVar2;
        ulong uVar3;
        Debug.Log("OnInitGlobalAchivementClicked...",0);
        lVar2 = rail_api.RailFactory(0);
        if (lVar2 != null) {
          uVar3 = FUN_180002970(13,DAT_181d7b780,lVar2);
          this.achievement_helper_ = uVar3;
          uVar3 = FUN_180002970(17,DAT_181d7b780,lVar2);
          this.rail_util_ = uVar3;
        }
        if (this.achievement_helper_ != null) {
          uVar3 = FUN_180002970(1,DAT_181d7b180);
          this.global_achievement_ = uVar3;
        }
        if (this.global_achievement_ != null) {
          iVar1 = FUN_180002aa0(0,DAT_181d7bb68,this.global_achievement_,"");
          if (iVar1 == 0) {
            Debug.Log("InitGlobalAchivement success!",0);
            return;
          }
        }
        Debug.Log("InitGlobalAchivement failed!",0);
    }

    // Token : 0x600239A
    // RVA   : 0x9C7D30   Offset: 0x9C7130   Length: 0x374
    public void InitPlayerAchivement()
    {
        int iVar2;
        long lVar3;
        ulong uVar4;
        ushort uVar7;
        ushort uVar8;
        Debug.Log("OnInitPlayerAchivementClicked...",0);
        lVar3 = rail_api.RailFactory(0);
        if (lVar3 != null) {
          uVar4 = FUN_180002970(13,DAT_181d7b780,lVar3);
          this.achievement_helper_ = uVar4;
          uVar4 = FUN_180002970(17,DAT_181d7b780,lVar3);
          this.rail_util_ = uVar4;
        }
        plVar1 = this.achievement_helper_;
        if (plVar1 != (int64 *)0) {
          uVar4 = new RailID(0,0);
          lVar3 = rail_api.RailFactory(0);
          uVar8 = 0;
          if ((lVar3 != null) &&
             (plVar5 = (int64 *)FUN_180002970(0,DAT_181d7b780,lVar3), plVar5 != (int64 *)0)) {
            lVar3 = *plVar5;
            if (*(uint16 *)(lVar3 + 0x12a) != 0) {
              uVar7 = uVar8;
              do {
                if (*(int64 *)(*(int64 *)(lVar3 + 176) + (uint64)uVar7 * 16) == DAT_181d7c3e0)
                {
                  puVar6 = (uint64 *)
                           ((int64)*(int *)(*(int64 *)(lVar3 + 176) + 8 + (uint64)uVar7 * 16)
                            * 16 + 0x148 + lVar3);
                  goto LAB_1809c7f6c;
                }
                uVar7 = uVar7 + 1;
              } while (uVar7 < *(uint16 *)(lVar3 + 0x12a));
            }
            puVar6 = (uint64 *)FUN_1800914f0(plVar5,DAT_181d7c3e0,1);
        LAB_1809c7f6c:
            uVar4 = (*(code *)*puVar6)(plVar5,puVar6[1]);
          }
          lVar3 = *plVar1;
          if (*(uint16 *)(lVar3 + 0x12a) != 0) {
            do {
              if (*(int64 *)(*(int64 *)(lVar3 + 176) + (uint64)uVar8 * 16) == DAT_181d7b180) {
                puVar6 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar3 + 176) + 8 + (uint64)uVar8 * 16) *
                          16 + 0x138 + lVar3);
                goto LAB_1809c7fc8;
              }
              uVar8 = uVar8 + 1;
            } while (uVar8 < *(uint16 *)(lVar3 + 0x12a));
          }
          puVar6 = (uint64 *)FUN_1800914f0(plVar1,DAT_181d7b180,0);
        LAB_1809c7fc8:
          uVar4 = (*(code *)*puVar6)(plVar1,uVar4,puVar6[1]);
          this.player_achievement_ = uVar4;
          if ((this.player_achievement_ != null) &&
             (iVar2 = FUN_180002aa0(1,DAT_181d7c458,this.player_achievement_,""),
             iVar2 == 0)) {
            uVar4 = "InitPlayerAchivement success!";
            if (((*(byte *)(DAT_181dbfcc8 + 0x133) & 4) != 0) && (*(int *)(DAT_181dbfcc8 + 224) == 0)) {
              il2cpp_runtime_class_init();
              uVar4 = "InitPlayerAchivement success!";
            }
            goto LAB_1809c808d;
          }
        }
        uVar4 = "InitPlayerAchivement failed!";
        if (((*(byte *)(DAT_181dbfcc8 + 0x133) & 4) != 0) && (*(int *)(DAT_181dbfcc8 + 224) == 0)) {
          il2cpp_runtime_class_init();
          uVar4 = "InitPlayerAchivement failed!";
        }
        LAB_1809c808d:
        Debug.Log(uVar4,0);
    }

    // Token : 0x600239B
    // RVA   : 0x9C7760   Offset: 0x9C6B60   Length: 0x2A5
    public void GetAllAchievement()
    {
        long lVar1;
        long lVar2;
        ulong uVar5;
        ushort uVar7;
        int iVar8;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[2];
        Debug.Log("OnGetAllAchievementClicked...",0);
        if (this.player_achievement_ == null) {
          Debug.Log("Please initialize first",0);
          return;
        }
        lVar2 = il2cpp_internal(DAT_181d97750);
        FUN_18132faf0(lVar2,DAT_181da3bd8);
        plVar4 = this.player_achievement_;
        if (plVar4 != (int64 *)0) {
          lVar1 = *plVar4;
          iVar8 = 0;
          uVar7 = 0;
          if (*(uint16 *)(lVar1 + 0x12a) != 0) {
            do {
              if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar7 * 16) == DAT_181d7c458) {
                puVar3 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar7 * 16) *
                          16 + 0x1e8 + lVar1);
                goto LAB_1809c78bc;
              }
              uVar7 = uVar7 + 1;
            } while (uVar7 < *(uint16 *)(lVar1 + 0x12a));
          }
          puVar3 = (uint64 *)FUN_1800914f0(plVar4,DAT_181d7c458,11);
        LAB_1809c78bc:
          local_res8[0] = (*(code *)*puVar3)(plVar4,lVar2,puVar3[1]);
          plVar4 = (int64 *)il2cpp_value_box(DAT_181d98380,local_res8);
          if (plVar4 != (int64 *)0) {
            uVar5 = (**(code **)(*plVar4 + 0x168))(plVar4,*(uint64 *)(*plVar4 + 0x170));
            puVar6 = (uint32 *)il2cpp_object_unbox(plVar4);
            local_res8[0] = *puVar6;
            uVar5 = String.Concat("GetAllAchievement result=",uVar5,0);
            Debug.Log(uVar5,0);
            if (lVar2 != null) {
              local_res18[0] = *(uint32 *)(lVar2 + 24);
              uVar5 = Int32.ToString(local_res18,0);
              uVar5 = String.Concat("AchievementCount: ",uVar5,0);
              Debug.Log(uVar5,0);
              for (; iVar8 < *(int *)(lVar2 + 24); iVar8 = iVar8 + 1) {
                WegameStatsAndAchievements.QueryPlayerAchievement(this,iVar8,0);
              }
              return;
            }
          }
        }
    }

    // Token : 0x600239C
    // RVA   : 0x9C8A70   Offset: 0x9C7E70   Length: 0x338
    public void QueryPlayerAchievement(int achID)
    {
        long lVar1;
        ulong uVar2;
        ulong uVar5;
        ushort uVar7;
        byte[] local_res8 = new byte[8];
        uint[] local_res10 = new uint[2];
        int[] local_res20 = new int[2];
        ulong[] local_28 = new ulong[2];
        local_res10[0] = achID;
        Debug.Log("OnQueryPlayerAchievementClicked...",0);
        plVar4 = this.player_achievement_;
        if (plVar4 == (int64 *)0) {
          Debug.Log("Please initialize first",0);
          return;
        }
        local_res8[0] = 0;
        uVar2 = Int32.ToString(local_res10,0);
        uVar2 = String.Concat("Ach",uVar2,0);
        lVar1 = *plVar4;
        uVar7 = 0;
        if (*(uint16 *)(lVar1 + 0x12a) != 0) {
          do {
            if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar7 * 16) == DAT_181d7c458) {
              puVar3 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar7 * 16) *
                        16 + 0x158 + lVar1);
              goto LAB_1809c8bce;
            }
            uVar7 = uVar7 + 1;
          } while (uVar7 < *(uint16 *)(lVar1 + 0x12a));
        }
        puVar3 = (uint64 *)FUN_1800914f0(plVar4,DAT_181d7c458,2);
        LAB_1809c8bce:
        local_res20[0] = (*(code *)*puVar3)(plVar4,uVar2,local_res8,puVar3[1]);
        if (local_res20[0] == 0) {
          lVar1 = this.player_achievement_;
          local_28[0] = "";
          uVar2 = Int32.ToString(local_res10,0);
          uVar2 = String.Concat("Ach",uVar2,0);
          if (lVar1 == null) {
        LAB_1809c8da3:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          local_res20[0] = FUN_180004c70(3,DAT_181d7c458,lVar1,uVar2,local_28);
          if (local_res20[0] == 0) {
            uVar2 = Boolean.ToString(local_res8,0);
            uVar2 = String.Concat("QueryPlayerAchievement success!achieved=",uVar2," ,json_result=",local_28[0],0);
            goto LAB_1809c8d3a;
          }
          plVar4 = (int64 *)il2cpp_value_box(DAT_181d98380,local_res20);
          if (plVar4 == (int64 *)0) goto LAB_1809c8da3;
          uVar5 = (**(code **)(*plVar4 + 0x168))(plVar4,*(uint64 *)(*plVar4 + 0x170));
          piVar6 = (int *)il2cpp_object_unbox(plVar4);
          local_res20[0] = *piVar6;
          uVar2 = "GetAchievementInfo failed!result=";
        }
        else {
          plVar4 = (int64 *)il2cpp_value_box(DAT_181d98380,local_res20);
          if (plVar4 == (int64 *)0) goto LAB_1809c8da3;
          uVar5 = (**(code **)(*plVar4 + 0x168))(plVar4,*(uint64 *)(*plVar4 + 0x170));
          piVar6 = (int *)il2cpp_object_unbox(plVar4);
          local_res20[0] = *piVar6;
          uVar2 = "HasAchieved failed!result=";
        }
        uVar2 = String.Concat(uVar2,uVar5,0);
        LAB_1809c8d3a:
        Debug.Log(uVar2,0);
    }

    // Token : 0x600239D
    // RVA   : 0x9C9310   Offset: 0x9C8710   Length: 0x26B
    public void UnlockAchievement(int achID)
    {
        long lVar1;
        ulong uVar2;
        uint[] local_res10 = new uint[4];
        uint[] local_res20 = new uint[2];
        uint[] local_18 = new uint[4];
        local_res10[0] = achID;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 8);
        if (lVar1 != null) {
          lVar1 = *(int64 *)(lVar1 + 16);
          uVar2 = Int32.ToString(local_res10,0);
          uVar2 = String.Concat("AchFinished",uVar2,0);
          if (lVar1 != null) {
            PlayerPrefDictionary.SetKey(lVar1,uVar2,"true",0);
            local_18[0] = local_res10[0];
            Debug.Log("OnLocalSetAchievementClicked...",0);
            lVar1 = this.player_achievement_;
            if (lVar1 != null) {
              uVar2 = Int32.ToString(local_18,0);
              uVar2 = String.Concat("Ach",uVar2,0);
              local_res20[0] = FUN_180002aa0(7,DAT_181d7c458,lVar1,uVar2);
              plVar3 = (int64 *)il2cpp_value_box(DAT_181d98380,local_res20);
              if (plVar3 != (int64 *)0) {
                uVar2 = (**(code **)(*plVar3 + 0x168))(plVar3,*(uint64 *)(*plVar3 + 0x170));
                puVar4 = (uint32 *)il2cpp_object_unbox(plVar3);
                local_res20[0] = *puVar4;
                uVar2 = String.Concat("LocalSetAchievement result=",uVar2,0);
                Debug.Log(uVar2,0);
                return;
              }
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            Debug.Log("Please initialize first",0);
            return;
          }
        }
    }

    // Token : 0x600239E
    // RVA   : 0x9C80B0   Offset: 0x9C74B0   Length: 0x1A8
    public void MakeAchievement(int achID)
    {
        long lVar1;
        ulong uVar2;
        uint[] local_res8 = new uint[2];
        uint[] local_res10 = new uint[2];
        local_res10[0] = achID;
        Debug.Log("OnLocalSetAchievementClicked...",0);
        lVar1 = this.player_achievement_;
        if (lVar1 != null) {
          uVar2 = Int32.ToString(local_res10,0);
          uVar2 = String.Concat("Ach",uVar2,0);
          local_res8[0] = FUN_180002aa0(7,DAT_181d7c458,lVar1,uVar2);
          plVar4 = (int64 *)il2cpp_value_box(DAT_181d98380,local_res8);
          if (plVar4 != (int64 *)0) {
            uVar2 = (**(code **)(*plVar4 + 0x168))(plVar4,*(uint64 *)(*plVar4 + 0x170));
            puVar3 = (uint32 *)il2cpp_object_unbox(plVar4);
            local_res8[0] = *puVar3;
            uVar2 = String.Concat("LocalSetAchievement result=",uVar2,0);
            Debug.Log(uVar2,0);
            return;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        Debug.Log("Please initialize first",0);
    }

    // Token : 0x600239F
    // RVA   : 0x9C6EB0   Offset: 0x9C62B0   Length: 0x2B2
    public void AsyncTriggerAchievementProgress(int achID)
    {
        void WegameStatsAndAchievements.AsyncTriggerAchievementProgress
                     (int64 this,uint32 achID)
        {
        int64 lVar1;
        uint32 uVar2;
        uint64 uVar3;
        uint64 uVar4;
        uint64 *puVar5;
        int64 *plVar6;
        uint32 *puVar7;
        uint16 uVar8;
        uint32 local_res8 [2];
        uint32 local_res10 [2];
        local_res10[0] = achID;
        Debug.Log("OnAsyncStoreAchievementClicked...",0);
        plVar6 = this.player_achievement_;
        if (plVar6 == (int64 *)0) {
          Debug.Log("Please initialize first",0);
          return;
        }
        uVar3 = Int32.ToString(local_res10,0);
        uVar3 = String.Concat("Ach",uVar3,0);
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 8);
        if (lVar1 != null) {
          lVar1 = *(int64 *)(lVar1 + 16);
          uVar4 = Int32.ToString(local_res10,0);
          uVar4 = String.Concat("AchData",uVar4,0);
          if (lVar1 != null) {
            uVar2 = PlayerPrefDictionary.GetInt(lVar1,uVar4,0);
            lVar1 = *plVar6;
            uVar8 = 0;
            if (*(uint16 *)(lVar1 + 0x12a) != 0) {
              do {
                if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar8 * 16) == DAT_181d7c458)
                {
                  puVar5 = (uint64 *)
                           ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar8 * 16)
                            * 16 + 0x198 + lVar1);
                  goto LAB_1809c705e;
                }
                uVar8 = uVar8 + 1;
              } while (uVar8 < *(uint16 *)(lVar1 + 0x12a));
            }
            puVar5 = (uint64 *)FUN_1800914f0(plVar6,DAT_181d7c458,6);
        LAB_1809c705e:
            local_res8[0] = (*(code *)*puVar5)(plVar6,uVar3,uVar2,puVar5[1]);
            plVar6 = (int64 *)il2cpp_value_box(DAT_181d98380,local_res8);
            if (plVar6 != (int64 *)0) {
              uVar3 = (**(code **)(*plVar6 + 0x168))(plVar6,*(uint64 *)(*plVar6 + 0x170));
              puVar7 = (uint32 *)il2cpp_object_unbox(plVar6);
              local_res8[0] = *puVar7;
              uVar3 = String.Concat("AsyncStoreAchievement result=",uVar3,0);
              Debug.Log(uVar3,0);
              WegameStatsAndAchievements.QueryPlayerAchievement(this,local_res10[0],0);
              return;
            }
          }
        }
    }

    // Token : 0x60023A0
    // RVA   : 0x9C8DB0   Offset: 0x9C81B0   Length: 0x1D4
    public void ResetPlayerAchievement()
    {
        long lVar1;
        ulong uVar4;
        ushort uVar6;
        uint[] local_res8 = new uint[2];
        Debug.Log("OnResetPlayerAchievementClicked...",0);
        plVar3 = this.player_achievement_;
        if (plVar3 == (int64 *)0) {
          Debug.Log("Please initialize first",0);
          return;
        }
        lVar1 = *plVar3;
        uVar6 = 0;
        if (*(uint16 *)(lVar1 + 0x12a) != 0) {
          do {
            if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar6 * 16) == DAT_181d7c458) {
              puVar2 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar6 * 16) *
                        16 + 0x1d8 + lVar1);
              goto LAB_1809c8e9c;
            }
            uVar6 = uVar6 + 1;
          } while (uVar6 < *(uint16 *)(lVar1 + 0x12a));
        }
        puVar2 = (uint64 *)FUN_1800914f0(plVar3,DAT_181d7c458,10);
        LAB_1809c8e9c:
        local_res8[0] = (*(code *)*puVar2)(plVar3,puVar2[1]);
        plVar3 = (int64 *)il2cpp_value_box(DAT_181d98380,local_res8);
        if (plVar3 != (int64 *)0) {
          uVar4 = (**(code **)(*plVar3 + 0x168))(plVar3,*(uint64 *)(*plVar3 + 0x170));
          puVar5 = (uint32 *)il2cpp_object_unbox(plVar3);
          local_res8[0] = *puVar5;
          uVar4 = String.Concat("ClearPlayerAchievement result=",uVar4,0);
          Debug.Log(uVar4,0);
          return;
        }
    }

    // Token : 0x60023A1
    // RVA   : 0x9C75B0   Offset: 0x9C69B0   Length: 0x1A8
    public void ClearPlayerAchievement(int achID)
    {
        long lVar1;
        ulong uVar2;
        uint[] local_res8 = new uint[2];
        uint[] local_res10 = new uint[2];
        local_res10[0] = achID;
        Debug.Log("OnClearPlayerAchievementClicked...",0);
        lVar1 = this.player_achievement_;
        if (lVar1 != null) {
          uVar2 = Int32.ToString(local_res10,0);
          uVar2 = String.Concat("Ach",uVar2,0);
          local_res8[0] = FUN_180002aa0(8,DAT_181d7c458,lVar1,uVar2);
          plVar4 = (int64 *)il2cpp_value_box(DAT_181d98380,local_res8);
          if (plVar4 != (int64 *)0) {
            uVar2 = (**(code **)(*plVar4 + 0x168))(plVar4,*(uint64 *)(*plVar4 + 0x170));
            puVar3 = (uint32 *)il2cpp_object_unbox(plVar4);
            local_res8[0] = *puVar3;
            uVar2 = String.Concat("ClearPlayerAchievement result=",uVar2,0);
            Debug.Log(uVar2,0);
            return;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        Debug.Log("Please initialize first",0);
    }

    // Token : 0x60023A2
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
