// ============================================================
// Type  : WegameStatsAndAchievements
// Token : 0x20003AD
// ============================================================

public class WegameStatsAndAchievements
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001CF5
    private IRailAchievementHelper achievement_helper_;

    // Token: 0x4001CF6
    private IRailGlobalAchievement global_achievement_;

    // Token: 0x4001CF7
    public IRailPlayerAchievement player_achievement_;

    // Token: 0x4001CF8
    public IRailUtils rail_util_;

    // Token: 0x4001CF9
    private static WegameStatsAndAchievements instance_;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002310
    // RVA   : 0x9E6FA0   Offset: 0x9E57A0   Length: 0xE8
    public static WegameStatsAndAchievements get_Instance()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uVar3 = **(uint64 **)(DAT_181d904e0 + 184);
        cVar1 = Object.op_Inequality(uVar3,0,0);
        if (cVar1) {
          return **(uint64 **)(DAT_181d904e0 + 184);
        }
        lVar2 = new GameObject("WegameStatsAndAchievements",0);
        if (lVar2 != null) {
          uVar3 = GameObject.AddComponent(lVar2,DAT_181d9df80);
          return uVar3;
        }
    }

    // Token : 0x6002311
    // RVA   : 0x9E69B0   Offset: 0x9E51B0   Length: 0x374
    private void Start()
    {
        bool cVar2;
        ulong uVar3;
        long lVar4;
        if (**(int **)(DAT_181d4ef00 + 184) != 1) {
          uVar3 = Component.get_gameObject(this,0);
          Object.Destroy(uVar3,0);
          return;
        }
        uVar3 = **(uint64 **)(DAT_181d904e0 + 184);
        cVar2 = Object.op_Inequality(uVar3,0,0);
        if (!cVar2) {
          puVar1 = *(uint64 **)(DAT_181d904e0 + 184);
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
            uVar3 = new OnTooltipCB(this,DAT_181d50538,0);
            if (lVar4 != null) {
              RailCallBackHelper.RegisterCallback(lVar4,0x835,uVar3,0);
              lVar4 = RailCallBackHelper.get_Instance(0);
              uVar3 = new OnTooltipCB(this,DAT_181d50538,0);
              if (lVar4 != null) {
                RailCallBackHelper.RegisterCallback(lVar4,0x837,uVar3,0);
                lVar4 = RailCallBackHelper.get_Instance(0);
                uVar3 = new OnTooltipCB(this,DAT_181d50538,0);
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

    // Token : 0x6002312
    // RVA   : 0x9E4B90   Offset: 0x9E3390   Length: 0x439
    private void CheckDLCState()
    {
        var pStatics_e010 = *(int64*)(DAT_181d4e010 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
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
          lVar3 = *(int64 *)(pStatics_ef00 + 80);
          if (lVar3 == null) goto LAB_1809e4fc4;
          if (*(int *)(lVar3 + 24) <= iVar2) {
            return;
          }
          lVar3 = rail_api.RailFactory(0);
          if (lVar3 == null) {
        LAB_1809e4ee0:
            uVar5 = Int32.ToString(local_res18,0);
            uVar5 = String.Concat("DLC",uVar5," 0",0);
            Debug.Log(uVar5,0);
            lVar3 = *(int64 *)(pStatics_e010 + 8);
            if (lVar3 == null) goto LAB_1809e4fc4;
            lVar3 = *(int64 *)(lVar3 + 16);
            uVar5 = Int32.ToString(local_res18,0);
            uVar5 = String.Concat("DLC",uVar5,0);
            if (lVar3 == null) goto LAB_1809e4fc4;
            uVar6 = 0;
          }
          else {
            lVar3 = rail_api.RailFactory(0);
            if (lVar3 == null) {
        LAB_1809e4fc4:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            lVar3 = FUN_180002970(19,DAT_181d56638,lVar3);
            lVar4 = il2cpp_internal(DAT_181d70c30);
            FUN_180f58a90(lVar4,DAT_181d71f68);
            lVar1 = *(int64 *)(pStatics_ef00 + 80);
            if (lVar1 == null) goto LAB_1809e4fc4;
            uVar5 = FUN_180002f80(lVar1,local_res18[0],DAT_181d83e78);
            uVar6 = new RailDlcID(uVar5,0);
            if (lVar4 == null) goto LAB_1809e4fc4;
            FUN_181827900(lVar4,uVar6,DAT_181d71fe8);
            if (lVar3 == null) goto LAB_1809e4fc4;
            iVar2 = FUN_180004c70(0,DAT_181d564b8,lVar3,lVar4,"");
            if (iVar2 != 0) goto LAB_1809e4ee0;
            uVar5 = Int32.ToString(local_res18,0);
            uVar5 = String.Concat("DLC",uVar5," 1",0);
            Debug.Log(uVar5,0);
            lVar3 = *(int64 *)(pStatics_e010 + 8);
            if (lVar3 == null) goto LAB_1809e4fc4;
            lVar3 = *(int64 *)(lVar3 + 16);
            uVar5 = Int32.ToString(local_res18,0);
            uVar5 = String.Concat("DLC",uVar5,0);
            if (lVar3 == null) goto LAB_1809e4fc4;
            uVar6 = 1;
          }
          PlayerPrefDictionary.SetKey(lVar3,uVar5,uVar6);
          local_res18[0] = local_res18[0] + 1;
        } while( true );
    }

    // Token : 0x6002313
    // RVA   : 0x9E5C80   Offset: 0x9E4480   Length: 0x9D
    private void OnDestroy()
    {
        ulong uVar1;
        bool cVar3;
        uVar1 = **(uint64 **)(DAT_181d904e0 + 184);
        cVar3 = Object.op_Inequality(uVar1,this,0);
        if (!cVar3) {
          puVar2 = *(uint64 **)(DAT_181d904e0 + 184);
          *puVar2 = 0;
          il2cpp_internal(puVar2,0);
        }
    }

    // Token : 0x6002314
    // RVA   : 0x9E5430   Offset: 0x9E3C30   Length: 0x13A
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
        plVar3 = (int64 *)FUN_180002970(0,DAT_181d56638,lVar2);
        if (plVar3 == (int64 *)0) {
          return uVar1;
        }
        lVar2 = *plVar3;
        uVar5 = 0;
        if (*(uint16 *)(lVar2 + 0x12a) != 0) {
          do {
            if (*(int64 *)(*(int64 *)(lVar2 + 176) + (uint64)uVar5 * 16) == DAT_181d572b8) {
              puVar4 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar2 + 176) + 8 + (uint64)uVar5 * 16) *
                        16 + 0x148 + lVar2);
              goto LAB_1809e5528;
            }
            uVar5 = uVar5 + 1;
          } while (uVar5 < *(uint16 *)(lVar2 + 0x12a));
        }
        puVar4 = (uint64 *)FUN_1800914f0(plVar3,DAT_181d572b8,1);
        LAB_1809e5528:
        uVar1 = (*(code *)*puVar4)(plVar3,puVar4[1]);
        return uVar1;
    }

    // Token : 0x6002315
    // RVA   : 0x9E5D20   Offset: 0x9E4520   Length: 0x765
    public void OnRailEvent(RAILEventID id, EventBase data)
    {
        var pStatics = *(int64*)(DAT_181d4e010 + 184);
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
        plVar5 = (int64 *)il2cpp_value_box(DAT_181d6eee0,local_res10);
        if (plVar5 != (int64 *)0) {
          uVar6 = (**(code **)(*plVar5 + 0x168))(plVar5,*(uint64 *)(*plVar5 + 0x170));
          piVar7 = (int *)il2cpp_object_unbox(plVar5);
          local_res10[0] = *piVar7;
          if ((data != (int64 *)0) &&
             (plVar5 = (int64 *)il2cpp_value_box(DAT_181d73160,data + 2), plVar5 != (int64 *)0)
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
                    lVar1 = *(int64 *)(pStatics + 32);
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
                            DAT_181d57338) {
                          puVar10 = (uint64 *)
                                    ((int64)
                                     *(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar12 * 16)
                                     * 16 + 0x168 + lVar1);
                          goto LAB_1809e60ac;
                        }
                        uVar12 = uVar12 + 1;
                      } while (uVar12 < *(uint16 *)(lVar1 + 0x12a));
                    }
                    puVar10 = (uint64 *)FUN_1800914f0(plVar5,DAT_181d57338,3);
        LAB_1809e60ac:
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
                    cVar2 = FUN_1816fd990(uVar6,"1",0);
                    if (cVar2) {
                      lVar1 = *(int64 *)(pStatics + 8);
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
                    lVar1 = *(int64 *)(pStatics + 8);
                    if (lVar1 == null) break;
                    lVar1 = *(int64 *)(lVar1 + 16);
                    uVar6 = Int32.ToString(&local_48,0);
                    String.Concat("AchData",uVar6,0);
                    if (lVar1 == null) break;
                    iVar4 = PlayerPrefDictionary.GetInt(lVar1);
                    if (iVar4 < iVar3) {
                      lVar1 = *(int64 *)(pStatics + 8);
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
                uVar6 = il2cpp_value_box(DAT_181d8b6d8,&local_44);
                local_40[0] = *(uint32 *)((int64)data + 68);
                uVar8 = il2cpp_value_box(DAT_181d8b6d8,local_40);
                uVar6 = String.Format("achievement_name={0}, current_progress={1}, max_progress={2}",lVar1,uVar6,uVar8,0);
              }
              Debug.Log(uVar6,0);
            }
            return;
          }
        }
    }

    // Token : 0x6002316
    // RVA   : 0x9E5570   Offset: 0x9E3D70   Length: 0x1DE
    public void InitGlobalAchivement()
    {
        int iVar1;
        long lVar2;
        ulong uVar3;
        Debug.Log("OnInitGlobalAchivementClicked...",0);
        lVar2 = rail_api.RailFactory(0);
        if (lVar2 != null) {
          uVar3 = FUN_180002970(13,DAT_181d56638,lVar2);
          this.achievement_helper_ = uVar3;
          uVar3 = FUN_180002970(17,DAT_181d56638,lVar2);
          this.rail_util_ = uVar3;
        }
        if (this.achievement_helper_ != null) {
          uVar3 = FUN_180002970(1,DAT_181d56040);
          this.global_achievement_ = uVar3;
        }
        if (this.global_achievement_ != null) {
          iVar1 = FUN_180002aa0(0,DAT_181d56a38,this.global_achievement_,"");
          if (iVar1 == 0) {
            Debug.Log("InitGlobalAchivement success!",0);
            return;
          }
        }
        Debug.Log("InitGlobalAchivement failed!",0);
    }

    // Token : 0x6002317
    // RVA   : 0x9E5750   Offset: 0x9E3F50   Length: 0x374
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
          uVar4 = FUN_180002970(13,DAT_181d56638,lVar3);
          this.achievement_helper_ = uVar4;
          uVar4 = FUN_180002970(17,DAT_181d56638,lVar3);
          this.rail_util_ = uVar4;
        }
        plVar1 = this.achievement_helper_;
        if (plVar1 != (int64 *)0) {
          uVar4 = new RailID(0,0);
          lVar3 = rail_api.RailFactory(0);
          uVar8 = 0;
          if ((lVar3 != null) &&
             (plVar5 = (int64 *)FUN_180002970(0,DAT_181d56638,lVar3), plVar5 != (int64 *)0)) {
            lVar3 = *plVar5;
            if (*(uint16 *)(lVar3 + 0x12a) != 0) {
              uVar7 = uVar8;
              do {
                if (*(int64 *)(*(int64 *)(lVar3 + 176) + (uint64)uVar7 * 16) == DAT_181d572b8)
                {
                  puVar6 = (uint64 *)
                           ((int64)*(int *)(*(int64 *)(lVar3 + 176) + 8 + (uint64)uVar7 * 16)
                            * 16 + 0x148 + lVar3);
                  goto LAB_1809e598c;
                }
                uVar7 = uVar7 + 1;
              } while (uVar7 < *(uint16 *)(lVar3 + 0x12a));
            }
            puVar6 = (uint64 *)FUN_1800914f0(plVar5,DAT_181d572b8,1);
        LAB_1809e598c:
            uVar4 = (*(code *)*puVar6)(plVar5,puVar6[1]);
          }
          lVar3 = *plVar1;
          if (*(uint16 *)(lVar3 + 0x12a) != 0) {
            do {
              if (*(int64 *)(*(int64 *)(lVar3 + 176) + (uint64)uVar8 * 16) == DAT_181d56040) {
                puVar6 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar3 + 176) + 8 + (uint64)uVar8 * 16) *
                          16 + 0x138 + lVar3);
                goto LAB_1809e59e8;
              }
              uVar8 = uVar8 + 1;
            } while (uVar8 < *(uint16 *)(lVar3 + 0x12a));
          }
          puVar6 = (uint64 *)FUN_1800914f0(plVar1,DAT_181d56040,0);
        LAB_1809e59e8:
          uVar4 = (*(code *)*puVar6)(plVar1,uVar4,puVar6[1]);
          this.player_achievement_ = uVar4;
          if ((this.player_achievement_ != null) &&
             (iVar2 = FUN_180002aa0(1,DAT_181d57338,this.player_achievement_,""),
             iVar2 == 0)) {
            uVar4 = "InitPlayerAchivement success!";
            if (((*(byte *)(DAT_181d9ab18 + 0x133) & 4) != 0) && (*(int *)(DAT_181d9ab18 + 224) == 0)) {
              il2cpp_runtime_class_init();
              uVar4 = "InitPlayerAchivement success!";
            }
            goto LAB_1809e5aad;
          }
        }
        uVar4 = "InitPlayerAchivement failed!";
        if (((*(byte *)(DAT_181d9ab18 + 0x133) & 4) != 0) && (*(int *)(DAT_181d9ab18 + 224) == 0)) {
          il2cpp_runtime_class_init();
          uVar4 = "InitPlayerAchivement failed!";
        }
        LAB_1809e5aad:
        Debug.Log(uVar4,0);
    }

    // Token : 0x6002318
    // RVA   : 0x9E5180   Offset: 0x9E3980   Length: 0x2A5
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
        lVar2 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar2,DAT_181d7c250);
        plVar4 = this.player_achievement_;
        if (plVar4 != (int64 *)0) {
          lVar1 = *plVar4;
          iVar8 = 0;
          uVar7 = 0;
          if (*(uint16 *)(lVar1 + 0x12a) != 0) {
            do {
              if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar7 * 16) == DAT_181d57338) {
                puVar3 = (uint64 *)
                         ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar7 * 16) *
                          16 + 0x1e8 + lVar1);
                goto LAB_1809e52dc;
              }
              uVar7 = uVar7 + 1;
            } while (uVar7 < *(uint16 *)(lVar1 + 0x12a));
          }
          puVar3 = (uint64 *)FUN_1800914f0(plVar4,DAT_181d57338,11);
        LAB_1809e52dc:
          local_res8[0] = (*(code *)*puVar3)(plVar4,lVar2,puVar3[1]);
          plVar4 = (int64 *)il2cpp_value_box(DAT_181d73160,local_res8);
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

    // Token : 0x6002319
    // RVA   : 0x9E6490   Offset: 0x9E4C90   Length: 0x338
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
            if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar7 * 16) == DAT_181d57338) {
              puVar3 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar7 * 16) *
                        16 + 0x158 + lVar1);
              goto LAB_1809e65ee;
            }
            uVar7 = uVar7 + 1;
          } while (uVar7 < *(uint16 *)(lVar1 + 0x12a));
        }
        puVar3 = (uint64 *)FUN_1800914f0(plVar4,DAT_181d57338,2);
        LAB_1809e65ee:
        local_res20[0] = (*(code *)*puVar3)(plVar4,uVar2,local_res8,puVar3[1]);
        if (local_res20[0] == 0) {
          lVar1 = this.player_achievement_;
          local_28[0] = "";
          uVar2 = Int32.ToString(local_res10,0);
          uVar2 = String.Concat("Ach",uVar2,0);
          if (lVar1 == null) {
        LAB_1809e67c3:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          local_res20[0] = FUN_180004c70(3,DAT_181d57338,lVar1,uVar2,local_28);
          if (local_res20[0] == 0) {
            uVar2 = Boolean.ToString(local_res8,0);
            uVar2 = String.Concat("QueryPlayerAchievement success!achieved=",uVar2," ,json_result=",local_28[0],0);
            goto LAB_1809e675a;
          }
          plVar4 = (int64 *)il2cpp_value_box(DAT_181d73160,local_res20);
          if (plVar4 == (int64 *)0) goto LAB_1809e67c3;
          uVar5 = (**(code **)(*plVar4 + 0x168))(plVar4,*(uint64 *)(*plVar4 + 0x170));
          piVar6 = (int *)il2cpp_object_unbox(plVar4);
          local_res20[0] = *piVar6;
          uVar2 = "GetAchievementInfo failed!result=";
        }
        else {
          plVar4 = (int64 *)il2cpp_value_box(DAT_181d73160,local_res20);
          if (plVar4 == (int64 *)0) goto LAB_1809e67c3;
          uVar5 = (**(code **)(*plVar4 + 0x168))(plVar4,*(uint64 *)(*plVar4 + 0x170));
          piVar6 = (int *)il2cpp_object_unbox(plVar4);
          local_res20[0] = *piVar6;
          uVar2 = "HasAchieved failed!result=";
        }
        uVar2 = String.Concat(uVar2,uVar5,0);
        LAB_1809e675a:
        Debug.Log(uVar2,0);
    }

    // Token : 0x600231A
    // RVA   : 0x9E6D30   Offset: 0x9E5530   Length: 0x26B
    public void UnlockAchievement(int achID)
    {
        long lVar1;
        ulong uVar2;
        uint[] local_res10 = new uint[4];
        uint[] local_res20 = new uint[2];
        uint[] local_18 = new uint[4];
        local_res10[0] = achID;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 8);
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
              local_res20[0] = FUN_180002aa0(7,DAT_181d57338,lVar1,uVar2);
              plVar3 = (int64 *)il2cpp_value_box(DAT_181d73160,local_res20);
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

    // Token : 0x600231B
    // RVA   : 0x9E5AD0   Offset: 0x9E42D0   Length: 0x1A8
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
          local_res8[0] = FUN_180002aa0(7,DAT_181d57338,lVar1,uVar2);
          plVar4 = (int64 *)il2cpp_value_box(DAT_181d73160,local_res8);
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

    // Token : 0x600231C
    // RVA   : 0x9E48D0   Offset: 0x9E30D0   Length: 0x2B2
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
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 8);
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
                if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar8 * 16) == DAT_181d57338)
                {
                  puVar5 = (uint64 *)
                           ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar8 * 16)
                            * 16 + 0x198 + lVar1);
                  goto LAB_1809e4a7e;
                }
                uVar8 = uVar8 + 1;
              } while (uVar8 < *(uint16 *)(lVar1 + 0x12a));
            }
            puVar5 = (uint64 *)FUN_1800914f0(plVar6,DAT_181d57338,6);
        LAB_1809e4a7e:
            local_res8[0] = (*(code *)*puVar5)(plVar6,uVar3,uVar2,puVar5[1]);
            plVar6 = (int64 *)il2cpp_value_box(DAT_181d73160,local_res8);
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

    // Token : 0x600231D
    // RVA   : 0x9E67D0   Offset: 0x9E4FD0   Length: 0x1D4
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
            if (*(int64 *)(*(int64 *)(lVar1 + 176) + (uint64)uVar6 * 16) == DAT_181d57338) {
              puVar2 = (uint64 *)
                       ((int64)*(int *)(*(int64 *)(lVar1 + 176) + 8 + (uint64)uVar6 * 16) *
                        16 + 0x1d8 + lVar1);
              goto LAB_1809e68bc;
            }
            uVar6 = uVar6 + 1;
          } while (uVar6 < *(uint16 *)(lVar1 + 0x12a));
        }
        puVar2 = (uint64 *)FUN_1800914f0(plVar3,DAT_181d57338,10);
        LAB_1809e68bc:
        local_res8[0] = (*(code *)*puVar2)(plVar3,puVar2[1]);
        plVar3 = (int64 *)il2cpp_value_box(DAT_181d73160,local_res8);
        if (plVar3 != (int64 *)0) {
          uVar4 = (**(code **)(*plVar3 + 0x168))(plVar3,*(uint64 *)(*plVar3 + 0x170));
          puVar5 = (uint32 *)il2cpp_object_unbox(plVar3);
          local_res8[0] = *puVar5;
          uVar4 = String.Concat("ClearPlayerAchievement result=",uVar4,0);
          Debug.Log(uVar4,0);
          return;
        }
    }

    // Token : 0x600231E
    // RVA   : 0x9E4FD0   Offset: 0x9E37D0   Length: 0x1A8
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
          local_res8[0] = FUN_180002aa0(8,DAT_181d57338,lVar1,uVar2);
          plVar4 = (int64 *)il2cpp_value_box(DAT_181d73160,local_res8);
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

    // Token : 0x600231F
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
