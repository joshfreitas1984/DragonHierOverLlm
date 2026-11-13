// ============================================================
// Type  : WegameStatsAndAchievements
// Token : 0x20003C1
// ============================================================

public class WegameStatsAndAchievements
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001E92
    private IRailAchievementHelper achievement_helper_;

    // Token: 0x4001E93
    private IRailGlobalAchievement global_achievement_;

    // Token: 0x4001E94
    public IRailPlayerAchievement player_achievement_;

    // Token: 0x4001E95
    public IRailUtils rail_util_;

    // Token: 0x4001E96
    private static WegameStatsAndAchievements instance_;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600243D
    // RVA   : 0x714720   Offset: 0x713520   Length: 0xE8
    public static WegameStatsAndAchievements get_Instance()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uVar3 = **(uint64 **)(DAT_181e95c88 + 184);
        cVar1 = Object.op_Inequality(uVar3,0,0);
        if (cVar1) {
          return **(uint64 **)(DAT_181e95c88 + 184);
        }
        lVar2 = new GameObject("WegameStatsAndAchievements",0);
        if (lVar2 != null) {
          uVar3 = GameObject.AddComponent(lVar2,DAT_181e52dd0);
          return uVar3;
        }
    }

    // Token : 0x600243E
    // RVA   : 0x714130   Offset: 0x712F30   Length: 0x374
    private void Start()
    {
        bool cVar2;
        ulong uVar3;
        long lVar4;
        if (**(int **)(DAT_181e538e8 + 184) != 1) {
          uVar3 = Component.get_gameObject(this,0);
          Object.Destroy(uVar3,0);
          return;
        }
        uVar3 = **(uint64 **)(DAT_181e95c88 + 184);
        cVar2 = Object.op_Inequality(uVar3,0,0);
        if (!cVar2) {
          puVar1 = *(uint64 **)(DAT_181e95c88 + 184);
          *puVar1 = this;
          il2cpp_internal(puVar1,this);
          uVar3 = Component.get_gameObject(this,0);
          Object.DontDestroyOnLoad(uVar3,0);
          lVar4 = FUN_180210740(0);
          if (lVar4 != null) {
            GameDataController.ResetDlcState(lVar4,0);
            cVar2 = RailManager.get_Initialized(0);
            if (!cVar2) {
              Debug.LogError("Rail sdk is not initialized!",0);
              return;
            }
            lVar4 = RailCallBackHelper.get_Instance(0);
            uVar3 = new OnTooltipCB(this,DAT_181e5c8f0,0);
            if (lVar4 != null) {
              RailCallBackHelper.RegisterCallback(lVar4,0x835,uVar3,0);
              lVar4 = RailCallBackHelper.get_Instance(0);
              uVar3 = new OnTooltipCB(this,DAT_181e5c8f0,0);
              if (lVar4 != null) {
                RailCallBackHelper.RegisterCallback(lVar4,0x837,uVar3,0);
                lVar4 = RailCallBackHelper.get_Instance(0);
                uVar3 = new OnTooltipCB(this,DAT_181e5c8f0,0);
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
          FUN_1801e0300();
        }
        uVar3 = Component.get_gameObject(this,0);
        Object.Destroy(uVar3,0);
    }

    // Token : 0x600243F
    // RVA   : 0x712310   Offset: 0x711110   Length: 0x439
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
          if (lVar3 == null) goto LAB_180712744;
          if (*(int *)(lVar3 + 24) <= iVar2) {
            return;
          }
          lVar3 = rail_api.RailFactory(0);
          if (lVar3 == null) {
        LAB_180712660:
            uVar5 = Int32.ToString(local_res18,0);
            uVar5 = String.Concat("DLC",uVar5," 0",0);
            Debug.Log(uVar5,0);
            lVar3 = GameController.difficultyExtraPoint;
            if (lVar3 == null) goto LAB_180712744;
            lVar3 = *(int64 *)(lVar3 + 16);
            uVar5 = Int32.ToString(local_res18,0);
            uVar5 = String.Concat("DLC",uVar5,0);
            if (lVar3 == null) goto LAB_180712744;
            uVar6 = 0;
          }
          else {
            lVar3 = rail_api.RailFactory(0);
            if (lVar3 == null) {
        LAB_180712744:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar3 = FUN_180002280(19,DAT_181e5b750,lVar3);
            lVar4 = il2cpp_internal(DAT_181e75938);
            FUN_1810f3480(lVar4,DAT_181e7bd60);
            lVar1 = PlotController.LaBaFestivelResultTalkText;
            if (lVar1 == null) goto LAB_180712744;
            uVar5 = FUN_1800024b0(lVar1,local_res18[0],DAT_181e8de58);
            uVar6 = new RailDlcID(uVar5,0);
            if (lVar4 == null) goto LAB_180712744;
            FUN_18175de30(lVar4,uVar6,DAT_181e7bde0);
            if (lVar3 == null) goto LAB_180712744;
            iVar2 = FUN_180060560(0,DAT_181e5b5b8,lVar3,lVar4,"");
            if (iVar2 != 0) goto LAB_180712660;
            uVar5 = Int32.ToString(local_res18,0);
            uVar5 = String.Concat("DLC",uVar5," 1",0);
            Debug.Log(uVar5,0);
            lVar3 = GameController.difficultyExtraPoint;
            if (lVar3 == null) goto LAB_180712744;
            lVar3 = *(int64 *)(lVar3 + 16);
            uVar5 = Int32.ToString(local_res18,0);
            uVar5 = String.Concat("DLC",uVar5,0);
            if (lVar3 == null) goto LAB_180712744;
            uVar6 = 1;
          }
          PlayerPrefDictionary.SetKey(lVar3,uVar5,uVar6);
          local_res18[0] = local_res18[0] + 1;
        } while( true );
    }

    // Token : 0x6002440
    // RVA   : 0x713400   Offset: 0x712200   Length: 0x9D
    private void OnDestroy()
    {
        ulong uVar1;
        bool cVar3;
        uVar1 = **(uint64 **)(DAT_181e95c88 + 184);
        cVar3 = Object.op_Inequality(uVar1,this,0);
        if (!cVar3) {
          puVar2 = *(uint64 **)(DAT_181e95c88 + 184);
          *puVar2 = 0;
          il2cpp_internal(puVar2,0);
        }
    }

    // Token : 0x6002441
    // RVA   : 0x712BB0   Offset: 0x7119B0   Length: 0x13A
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
        plVar3 = (int64 *)FUN_180002280(0,DAT_181e5b750,lVar2);
        if (plVar3 == (int64 *)0) {
          return uVar1;
        }
        lVar2 = *plVar3;
        uVar5 = 0;
        if (*(uint16 *)(lVar2 + 0x12a) != 0) {
          do {
            if (*(int64 *)(*(int64 *)(lVar2 + 176) + (uint64)uVar5 * 16) == DAT_181e5c470) {
              puVar4 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar2 + 176) + 8 + (uint64)uVar5 * 16) *
                        16 + 0x148 + lVar2);
              goto LAB_180712ca8;
            }
            uVar5 = uVar5 + 1;
          } while (uVar5 < *(uint16 *)(lVar2 + 0x12a));
        }
        puVar4 = (uint64 *)FUN_18019b1f0(plVar3,DAT_181e5c470,1);
        LAB_180712ca8:
        uVar1 = (*(code *)*puVar4)(plVar3,puVar4[1]);
        return uVar1;
    }

    // Token : 0x6002442
    // RVA   : 0x7134A0   Offset: 0x7122A0   Length: 0x765
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
        plVar5 = (int64 *)il2cpp_value_box(DAT_181e744e8,local_res10);
        if (plVar5 != (int64 *)0) {
          uVar6 = (**(code **)(*plVar5 + 0x168))(plVar5,*(uint64 *)(*plVar5 + 0x170));
          piVar7 = (int *)il2cpp_object_unbox(plVar5);
          local_res10[0] = *piVar7;
          if ((data != (int64 *)0) &&
             (plVar5 = (int64 *)il2cpp_value_box(DAT_181e78758,data + 2), plVar5 != (int64 *)0)
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
                    lVar1 = GameController.ChangeAllAreaStateIDs;
                    if ((lVar1 == null) || (lVar1 = *(int64 *)(lVar1 + 0x1d0)) == null) break;
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
                            DAT_181e5c4f8) {
                          puVar10 = (uint64 *)
                                    ((int64)
                                     *(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar12 * 16)
                                     * 16 + 0x168 + lVar1);
                          goto LAB_18071382c;
                        }
                        uVar12 = uVar12 + 1;
                      } while (uVar12 < *(uint16 *)(lVar1 + 0x12a));
                    }
                    puVar10 = (uint64 *)FUN_18019b1f0(plVar5,DAT_181e5c4f8,3);
        LAB_18071382c:
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
                    cVar2 = FUN_1816387f0(uVar6,"1",0);
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
                uVar6 = il2cpp_value_box(DAT_181e90d70,&local_44);
                local_40[0] = *(uint32 *)((int64)data + 68);
                uVar8 = il2cpp_value_box(DAT_181e90d70,local_40);
                uVar6 = String.Format("achievement_name={0}, current_progress={1}, max_progress={2}",lVar1,uVar6,uVar8,0);
              }
              Debug.Log(uVar6,0);
            }
            return;
          }
        }
    }

    // Token : 0x6002443
    // RVA   : 0x712CF0   Offset: 0x711AF0   Length: 0x1DE
    public void InitGlobalAchivement()
    {
        int iVar1;
        long lVar2;
        ulong uVar3;
        Debug.Log("OnInitGlobalAchivementClicked...",0);
        lVar2 = rail_api.RailFactory(0);
        if (lVar2 != null) {
          uVar3 = FUN_180002280(13,DAT_181e5b750,lVar2);
          this.achievement_helper_ = uVar3;
          uVar3 = FUN_180002280(17,DAT_181e5b750,lVar2);
          this.rail_util_ = uVar3;
        }
        if (this.achievement_helper_ != null) {
          uVar3 = FUN_180002280(1,DAT_181e5b0f8);
          this.global_achievement_ = uVar3;
        }
        if (this.global_achievement_ != null) {
          iVar1 = FUN_180054130(0,DAT_181e5bb88,this.global_achievement_,"");
          if (iVar1 == 0) {
            Debug.Log("InitGlobalAchivement success!",0);
            return;
          }
        }
        Debug.Log("InitGlobalAchivement failed!",0);
    }

    // Token : 0x6002444
    // RVA   : 0x712ED0   Offset: 0x711CD0   Length: 0x374
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
          uVar4 = FUN_180002280(13,DAT_181e5b750,lVar3);
          this.achievement_helper_ = uVar4;
          uVar4 = FUN_180002280(17,DAT_181e5b750,lVar3);
          this.rail_util_ = uVar4;
        }
        plVar1 = this.achievement_helper_;
        if (plVar1 != (int64 *)0) {
          uVar4 = new RailID(0,0);
          lVar3 = rail_api.RailFactory(0);
          uVar8 = 0;
          if ((lVar3 != null) &&
             (plVar5 = (int64 *)FUN_180002280(0,DAT_181e5b750,lVar3), plVar5 != (int64 *)0)) {
            lVar3 = *plVar5;
            if (*(uint16 *)(lVar3 + 0x12a) != 0) {
              uVar7 = uVar8;
              do {
                if (*(int64 *)(*(int64 *)(lVar3 + 176) + (uint64)uVar7 * 16) == DAT_181e5c470)
                {
                  puVar6 = (uint64 *)
                           ((int64)*(int *)(*(int64 *)(lVar3 + 176) + 8 + (uint64)uVar7 * 16)
                            * 16 + 0x148 + lVar3);
                  goto LAB_18071310c;
                }
                uVar7 = uVar7 + 1;
              } while (uVar7 < *(uint16 *)(lVar3 + 0x12a));
            }
            puVar6 = (uint64 *)FUN_18019b1f0(plVar5,DAT_181e5c470,1);
        LAB_18071310c:
            uVar4 = (*(code *)*puVar6)(plVar5,puVar6[1]);
          }
          lVar3 = *plVar1;
          if (*(uint16 *)(lVar3 + 0x12a) != 0) {
            do {
              if (*(int64 *)(*(int64 *)(lVar3 + 176) + (uint64)uVar8 * 16) == DAT_181e5b0f8) {
                puVar6 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar3 + 176) + 8 + (uint64)uVar8 * 16) *
                          16 + 0x138 + lVar3);
                goto LAB_180713168;
              }
              uVar8 = uVar8 + 1;
            } while (uVar8 < *(uint16 *)(lVar3 + 0x12a));
          }
          puVar6 = (uint64 *)FUN_18019b1f0(plVar1,DAT_181e5b0f8,0);
        LAB_180713168:
          uVar4 = (*(code *)*puVar6)(plVar1,uVar4,puVar6[1]);
          this.player_achievement_ = uVar4;
          if ((this.player_achievement_ != null) &&
             (iVar2 = FUN_180054130(1,DAT_181e5c4f8,this.player_achievement_,""),
             iVar2 == 0)) {
            uVar4 = "InitPlayerAchivement success!";
            if (((*(byte *)(DAT_181ea01b8 + 0x133) & 4) != 0) && (*(int *)(DAT_181ea01b8 + 224) == 0)) {
              il2cpp_runtime_class_init();
              uVar4 = "InitPlayerAchivement success!";
            }
            goto LAB_18071322d;
          }
        }
        uVar4 = "InitPlayerAchivement failed!";
        if (((*(byte *)(DAT_181ea01b8 + 0x133) & 4) != 0) && (*(int *)(DAT_181ea01b8 + 224) == 0)) {
          il2cpp_runtime_class_init();
          uVar4 = "InitPlayerAchivement failed!";
        }
        LAB_18071322d:
        Debug.Log(uVar4,0);
    }

    // Token : 0x6002445
    // RVA   : 0x712900   Offset: 0x711700   Length: 0x2A5
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
        lVar2 = il2cpp_internal(DAT_181e77728);
        FUN_1810f3480(lVar2,DAT_181e861f0);
        plVar4 = this.player_achievement_;
        if (plVar4 != (int64 *)0) {
          lVar1 = *plVar4;
          iVar8 = 0;
          uVar7 = 0;
          if (*(uint16 *)(lVar1 + 0x12a) != 0) {
            do {
              if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar7 * 16) == DAT_181e5c4f8) {
                puVar3 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar7 * 16) *
                          16 + 0x1e8 + lVar1);
                goto LAB_180712a5c;
              }
              uVar7 = uVar7 + 1;
            } while (uVar7 < *(uint16 *)(lVar1 + 0x12a));
          }
          puVar3 = (uint64 *)FUN_18019b1f0(plVar4,DAT_181e5c4f8,11);
        LAB_180712a5c:
          local_res8[0] = (*(code *)*puVar3)(plVar4,lVar2,puVar3[1]);
          plVar4 = (int64 *)il2cpp_value_box(DAT_181e78758,local_res8);
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

    // Token : 0x6002446
    // RVA   : 0x713C10   Offset: 0x712A10   Length: 0x338
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
            if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar7 * 16) == DAT_181e5c4f8) {
              puVar3 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar7 * 16) *
                        16 + 0x158 + lVar1);
              goto LAB_180713d6e;
            }
            uVar7 = uVar7 + 1;
          } while (uVar7 < *(uint16 *)(lVar1 + 0x12a));
        }
        puVar3 = (uint64 *)FUN_18019b1f0(plVar4,DAT_181e5c4f8,2);
        LAB_180713d6e:
        local_res20[0] = (*(code *)*puVar3)(plVar4,uVar2,local_res8,puVar3[1]);
        if (local_res20[0] == 0) {
          lVar1 = this.player_achievement_;
          local_28[0] = "";
          uVar2 = Int32.ToString(local_res10,0);
          uVar2 = String.Concat("Ach",uVar2,0);
          if (lVar1 == null) {
        LAB_180713f43:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          local_res20[0] = FUN_180060560(3,DAT_181e5c4f8,lVar1,uVar2,local_28);
          if (local_res20[0] == 0) {
            uVar2 = Boolean.ToString(local_res8,0);
            uVar2 = String.Concat("QueryPlayerAchievement success!achieved=",uVar2," ,json_result=",local_28[0],0);
            goto LAB_180713eda;
          }
          plVar4 = (int64 *)il2cpp_value_box(DAT_181e78758,local_res20);
          if (plVar4 == (int64 *)0) goto LAB_180713f43;
          uVar5 = (**(code **)(*plVar4 + 0x168))(plVar4,*(uint64 *)(*plVar4 + 0x170));
          piVar6 = (int *)il2cpp_object_unbox(plVar4);
          local_res20[0] = *piVar6;
          uVar2 = "GetAchievementInfo failed!result=";
        }
        else {
          plVar4 = (int64 *)il2cpp_value_box(DAT_181e78758,local_res20);
          if (plVar4 == (int64 *)0) goto LAB_180713f43;
          uVar5 = (**(code **)(*plVar4 + 0x168))(plVar4,*(uint64 *)(*plVar4 + 0x170));
          piVar6 = (int *)il2cpp_object_unbox(plVar4);
          local_res20[0] = *piVar6;
          uVar2 = "HasAchieved failed!result=";
        }
        uVar2 = String.Concat(uVar2,uVar5,0);
        LAB_180713eda:
        Debug.Log(uVar2,0);
    }

    // Token : 0x6002447
    // RVA   : 0x7144B0   Offset: 0x7132B0   Length: 0x26B
    public void UnlockAchievement(int achID)
    {
        long lVar1;
        ulong uVar2;
        uint[] local_res10 = new uint[4];
        uint[] local_res20 = new uint[2];
        uint[] local_18 = new uint[4];
        local_res10[0] = achID;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 8);
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
              local_res20[0] = FUN_180054130(7,DAT_181e5c4f8,lVar1,uVar2);
              plVar3 = (int64 *)il2cpp_value_box(DAT_181e78758,local_res20);
              if (plVar3 != (int64 *)0) {
                uVar2 = (**(code **)(*plVar3 + 0x168))(plVar3,*(uint64 *)(*plVar3 + 0x170));
                puVar4 = (uint32 *)il2cpp_object_unbox(plVar3);
                local_res20[0] = *puVar4;
                uVar2 = String.Concat("LocalSetAchievement result=",uVar2,0);
                Debug.Log(uVar2,0);
                return;
              }
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            Debug.Log("Please initialize first",0);
            return;
          }
        }
    }

    // Token : 0x6002448
    // RVA   : 0x713250   Offset: 0x712050   Length: 0x1A8
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
          local_res8[0] = FUN_180054130(7,DAT_181e5c4f8,lVar1,uVar2);
          plVar4 = (int64 *)il2cpp_value_box(DAT_181e78758,local_res8);
          if (plVar4 != (int64 *)0) {
            uVar2 = (**(code **)(*plVar4 + 0x168))(plVar4,*(uint64 *)(*plVar4 + 0x170));
            puVar3 = (uint32 *)il2cpp_object_unbox(plVar4);
            local_res8[0] = *puVar3;
            uVar2 = String.Concat("LocalSetAchievement result=",uVar2,0);
            Debug.Log(uVar2,0);
            return;
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        Debug.Log("Please initialize first",0);
    }

    // Token : 0x6002449
    // RVA   : 0x712050   Offset: 0x710E50   Length: 0x2B2
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
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 8);
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
                if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar8 * 16) == DAT_181e5c4f8)
                {
                  puVar5 = (uint64 *)
                           ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar8 * 16)
                            * 16 + 0x198 + lVar1);
                  goto LAB_1807121fe;
                }
                uVar8 = uVar8 + 1;
              } while (uVar8 < *(uint16 *)(lVar1 + 0x12a));
            }
            puVar5 = (uint64 *)FUN_18019b1f0(plVar6,DAT_181e5c4f8,6);
        LAB_1807121fe:
            local_res8[0] = (*(code *)*puVar5)(plVar6,uVar3,uVar2,puVar5[1]);
            plVar6 = (int64 *)il2cpp_value_box(DAT_181e78758,local_res8);
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

    // Token : 0x600244A
    // RVA   : 0x713F50   Offset: 0x712D50   Length: 0x1D4
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
            if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar6 * 16) == DAT_181e5c4f8) {
              puVar2 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar6 * 16) *
                        16 + 0x1d8 + lVar1);
              goto LAB_18071403c;
            }
            uVar6 = uVar6 + 1;
          } while (uVar6 < *(uint16 *)(lVar1 + 0x12a));
        }
        puVar2 = (uint64 *)FUN_18019b1f0(plVar3,DAT_181e5c4f8,10);
        LAB_18071403c:
        local_res8[0] = (*(code *)*puVar2)(plVar3,puVar2[1]);
        plVar3 = (int64 *)il2cpp_value_box(DAT_181e78758,local_res8);
        if (plVar3 != (int64 *)0) {
          uVar4 = (**(code **)(*plVar3 + 0x168))(plVar3,*(uint64 *)(*plVar3 + 0x170));
          puVar5 = (uint32 *)il2cpp_object_unbox(plVar3);
          local_res8[0] = *puVar5;
          uVar4 = String.Concat("ClearPlayerAchievement result=",uVar4,0);
          Debug.Log(uVar4,0);
          return;
        }
    }

    // Token : 0x600244B
    // RVA   : 0x712750   Offset: 0x711550   Length: 0x1A8
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
          local_res8[0] = FUN_180054130(8,DAT_181e5c4f8,lVar1,uVar2);
          plVar4 = (int64 *)il2cpp_value_box(DAT_181e78758,local_res8);
          if (plVar4 != (int64 *)0) {
            uVar2 = (**(code **)(*plVar4 + 0x168))(plVar4,*(uint64 *)(*plVar4 + 0x170));
            puVar3 = (uint32 *)il2cpp_object_unbox(plVar4);
            local_res8[0] = *puVar3;
            uVar2 = String.Concat("ClearPlayerAchievement result=",uVar2,0);
            Debug.Log(uVar2,0);
            return;
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        Debug.Log("Please initialize first",0);
    }

    // Token : 0x600244C
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
