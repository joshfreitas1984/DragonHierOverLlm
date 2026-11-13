// ============================================================
// Type  : SteamStatsAndAchievements
// Token : 0x2000381
// ============================================================

public class SteamStatsAndAchievements
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001CDA
    public static SteamStatsAndAchievements s_instance;

    // Token: 0x4001CDB
    public float UpdateTime;

    // Token: 0x4001CDC
    private bool gameSetuped;

    // Token: 0x4001CDD
    public ulong userID;

    // Token: 0x4001CDE
    private CGameID m_GameID;

    // Token: 0x4001CDF
    private bool m_bRequestedStats;

    // Token: 0x4001CE0
    public bool m_bStatsValid;

    // Token: 0x4001CE1
    private bool m_bStoreStats;

    // Token: 0x4001CE2
    private float lastStoreTimeCount;

    // Token: 0x4001CE3
    protected Callback<UserStatsReceived_t> m_UserStatsReceived;

    // Token: 0x4001CE4
    protected Callback<UserStatsStored_t> m_UserStatsStored;

    // Token: 0x4001CE5
    protected Callback<UserAchievementStored_t> m_UserAchievementStored;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60022AB
    // RVA   : 0xA17C20   Offset: 0xA16A20   Length: 0x147
    public static SteamStatsAndAchievements get_Instance()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uVar3 = **(uint64 **)(DAT_181e87468 + 184);
        cVar1 = Object.op_Inequality(uVar3,0,0);
        if (cVar1) {
          return **(uint64 **)(DAT_181e87468 + 184);
        }
        lVar2 = new GameObject("SteamStatsAndAchievements",0);
        if (lVar2 != null) {
          uVar3 = GameObject.AddComponent(lVar2,DAT_181e52440);
          return uVar3;
        }
    }

    // Token : 0x60022AC
    // RVA   : 0xA17330   Offset: 0xA16130   Length: 0x374
    private void Start()
    {
        bool cVar2;
        uint uVar3;
        ulong uVar4;
        long lVar5;
        ulong[] local_res18 = new ulong[2];
        if (**(int **)(DAT_181e538e8 + 184) == 0) {
          uVar4 = **(uint64 **)(DAT_181e87468 + 184);
          cVar2 = Object.op_Inequality(uVar4,0,0);
          if (!cVar2) {
            plVar1 = *(int64 **)(DAT_181e87468 + 184);
            *plVar1 = this;
            il2cpp_internal(plVar1,this);
            uVar4 = Component.get_gameObject(this,0);
            Object.DontDestroyOnLoad(uVar4,0);
            this.lastStoreTimeCount = 0x40a00000;
            lVar5 = FUN_180210740(0);
            if (lVar5 == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            GameDataController.ResetDlcState(lVar5,0);
            cVar2 = SteamManager.get_Initialized(0);
            if (!cVar2) {
              return;
            }
            uVar3 = SteamUtils.GetAppID(0);
            local_res18[0] = 0;
            CGameID.ctor(local_res18,uVar3,0);
            this.m_GameID = local_res18[0];
            uVar4 = new OnTooltipCB(this,DAT_181e97250,DAT_181e61a48);
            uVar4 = Callback_1.Create(uVar4,DAT_181e89a10);
            this.m_UserStatsReceived = uVar4;
            uVar4 = new OnTooltipCB(this,DAT_181e972d8,DAT_181e61ac8);
            uVar4 = Callback_1.Create(uVar4,DAT_181e89b10);
            this.m_UserStatsStored = uVar4;
            uVar4 = new OnTooltipCB(this,DAT_181e971c8,DAT_181e619c8);
            uVar4 = Callback_1.Create(uVar4,DAT_181e89910);
            this.m_UserAchievementStored = uVar4;
            this.m_bRequestedStats = 0;
            return;
          }
        }
        uVar4 = Component.get_gameObject(this,0);
        Object.Destroy(uVar4,0);
    }

    // Token : 0x60022AD
    // RVA   : 0xA176B0   Offset: 0xA164B0   Length: 0x5E
    public bool SteamStatsReady()
    {
        ulong uVar1;
        uVar1 = SteamManager.get_Initialized(0);
        if ((char)!uVar1) {
          return uVar1;
        }
        return (uint64)this.m_bStatsValid;
    }

    // Token : 0x60022AE
    // RVA   : 0xA17820   Offset: 0xA16620   Length: 0x3F2
    private void Update()
    {
        bool cVar1;
        byte uVar2;
        ulong uVar3;
        long lVar4;
        ulong uVar5;
        int iVar6;
        float fVar7;
        uint uVar8;
        float fVar9;
        int[] local_res18 = new int[4];
        cVar1 = SteamManager.get_Initialized(0);
        if (cVar1) {
          if (!this.m_bRequestedStats) {
            cVar1 = SteamManager.get_Initialized(0);
            if (!cVar1) {
              this.m_bRequestedStats = 1;
              return;
            }
            uVar2 = SteamUserStats.RequestCurrentStats(0);
            this.m_bRequestedStats = uVar2;
          }
          if (this.m_bStatsValid) {
            fVar9 = this.lastStoreTimeCount;
            fVar7 = (float)RealTime.get_deltaTime(0);
            fVar9 = fVar9 - fVar7;
            this.lastStoreTimeCount = fVar9;
            if (0.0 <= fVar9) {
              if (!this.m_bStoreStats) {
                return;
              }
            }
            else {
              this.lastStoreTimeCount = this.UpdateTime;
              this.m_bStoreStats = 1;
            }
            iVar6 = 0;
            while( true ) {
              local_res18[0] = iVar6;
              lVar4 = GameController.ChangeAllAreaStateIDs;
              if ((lVar4 == null) || (lVar4 = *(int64 *)(lVar4 + 0x1d0)) == null) break;
              if (*(int *)(lVar4 + 24) <= iVar6) {
                cVar1 = SteamUserStats.StoreStats(0);
                this.m_bStoreStats = !cVar1;
                return;
              }
              lVar4 = GameController.difficultyExtraPoint;
              if (lVar4 == null) break;
              lVar4 = *(int64 *)(lVar4 + 16);
              uVar3 = Int32.ToString(local_res18,0);
              String.Concat("AchData",uVar3,0);
              if (lVar4 == null) break;
              cVar1 = PlayerPrefDictionary.ContainsKey(lVar4);
              if (!cVar1) {
        LAB_180a17be3:
                iVar6 = local_res18[0] + 1;
              }
              else {
                lVar4 = FUN_180210740(0);
                if (((lVar4 == null) || (*(int64 *)(lVar4 + 0x1d0) == 0)) ||
                   (lVar4 = FUN_1800024b0()) == null) break;
                if (*(int *)(lVar4 + 32) == 0) {
                  uVar3 = Int32.ToString(local_res18);
                  uVar3 = String.Concat("AchData",uVar3,0);
                  lVar4 = GameController.difficultyExtraPoint;
                  if (lVar4 != null) {
                    lVar4 = *(int64 *)(lVar4 + 16);
                    uVar5 = Int32.ToString(local_res18,0);
                    String.Concat("AchData",uVar5,0);
                    if (lVar4 != null) {
                      uVar8 = PlayerPrefDictionary.GetFloat(lVar4);
                      SteamUserStats.SetStat(uVar3,uVar8);
                      goto LAB_180a17be3;
                    }
                  }
                  break;
                }
                uVar3 = Int32.ToString(local_res18);
                uVar3 = String.Concat("AchData",uVar3,0);
                lVar4 = GameController.difficultyExtraPoint;
                if (lVar4 == null) break;
                lVar4 = *(int64 *)(lVar4 + 16);
                uVar5 = Int32.ToString(local_res18,0);
                uVar5 = String.Concat("AchData",uVar5,0);
                if (lVar4 == null) break;
                PlayerPrefDictionary.GetInt(lVar4,uVar5);
                SteamUserStats.SetStat(uVar3);
                iVar6 = local_res18[0] + 1;
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
        }
    }

    // Token : 0x60022AF
    // RVA   : 0xA16330   Offset: 0xA15130   Length: 0x2E7
    private void CheckDLCState()
    {
        bool cVar1;
        uint uVar2;
        ulong uVar3;
        int iVar4;
        long lVar5;
        ulong uVar6;
        int[] local_res18 = new int[4];
        iVar4 = 0;
        while( true ) {
          local_res18[0] = iVar4;
          lVar5 = PlotController.LaBaFestivelScoreLvTalkText;
          if (lVar5 == null) break;
          if (*(int *)(lVar5 + 24) <= iVar4) {
            return;
          }
          lVar5 = PlotController.LaBaFestivelScoreLvTalkText;
          if (lVar5 == null) break;
          uVar2 = FUN_1800024b0(lVar5,local_res18[0],DAT_181e8de58);
          uVar2 = FUN_18055d730(uVar2,0);
          cVar1 = SteamApps.BIsDlcInstalled(uVar2,0);
          if (!cVar1) {
            uVar3 = Int32.ToString(local_res18,0);
            uVar3 = String.Concat("DLC",uVar3," 0",0);
            Debug.Log(uVar3,0);
            lVar5 = GameController.difficultyExtraPoint;
            if (lVar5 == null) break;
            lVar5 = *(int64 *)(lVar5 + 16);
            uVar3 = Int32.ToString(local_res18,0);
            uVar3 = String.Concat("DLC",uVar3,0);
            if (lVar5 == null) break;
            uVar6 = 0;
          }
          else {
            uVar3 = Int32.ToString(local_res18,0);
            uVar3 = String.Concat("DLC",uVar3," 1",0);
            Debug.Log(uVar3,0);
            lVar5 = GameController.difficultyExtraPoint;
            if (lVar5 == null) break;
            lVar5 = *(int64 *)(lVar5 + 16);
            uVar3 = Int32.ToString(local_res18,0);
            uVar3 = String.Concat("DLC",uVar3,0);
            if (lVar5 == null) break;
            uVar6 = 1;
          }
          PlayerPrefDictionary.SetKey(lVar5,uVar3,uVar6);
          iVar4 = local_res18[0] + 1;
        }
    }

    // Token : 0x60022B0
    // RVA   : 0xA17710   Offset: 0xA16510   Length: 0x101
    public void UnlockAchievement(int achID)
    {
        long lVar1;
        ulong uVar2;
        uint[] local_res10 = new uint[6];
        local_res10[0] = achID;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181e528f8 + 184) + 8);
        if (lVar1 != null) {
          lVar1 = *(int64 *)(lVar1 + 16);
          uVar2 = Int32.ToString(local_res10,0);
          uVar2 = String.Concat("AchFinished",uVar2,0);
          if (lVar1 != null) {
            PlayerPrefDictionary.SetKey(lVar1,uVar2,"true",0);
            uVar2 = Int32.ToString(local_res10,0);
            uVar2 = String.Concat("Ach",uVar2,0);
            SteamUserStats.SetAchievement(uVar2,0);
            this.m_bStoreStats = 1;
            return;
          }
        }
    }

    // Token : 0x60022B1
    // RVA   : 0xA16A40   Offset: 0xA15840   Length: 0x74D
    private void OnUserStatsReceived(UserStatsReceived_t pCallback)
    {
        float fVar1;
        bool cVar2;
        int iVar3;
        ulong uVar5;
        long lVar7;
        int iVar8;
        float fVar9;
        int local_58;
        int local_54;
        int local_50;
        float local_4c [13];
        iVar8 = 0;
        local_4c[0] = 0.0;
        local_58 = 0;
        local_50 = 0;
        cVar2 = SteamManager.get_Initialized(0);
        if ((!cVar2) || (this.m_GameID != *pCallback)) {
          return;
        }
        if ((int)pCallback[1] != 1) {
          plVar4 = (int64 *)il2cpp_value_box(DAT_181ea3048,pCallback + 1);
          if (plVar4 != (int64 *)0) {
            uVar5 = (**(code **)(*plVar4 + 0x168))(plVar4,*(uint64 *)(*plVar4 + 0x170));
            puVar6 = (uint32 *)il2cpp_object_unbox(plVar4);
            *(uint32 *)(pCallback + 1) = *puVar6;
            uVar5 = String.Concat("RequestStats - failed, ",uVar5,0);
            Debug.Log(uVar5,0);
            return;
          }
        LAB_180a17188:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        Debug.Log("Received stats and achievements from Steam\n",0);
        this.m_bStatsValid = 1;
        uVar5 = SteamUser.GetSteamID(0);
        this.userID = uVar5;
        local_54 = 0;
        while( true ) {
          iVar3 = local_54;
          lVar7 = GameController.ChangeAllAreaStateIDs;
          if ((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 0x1d0)) == null) goto LAB_180a17188;
          if (*(int *)(lVar7 + 24) <= iVar3) break;
          uVar5 = Int32.ToString(&local_54,0);
          uVar5 = String.Concat("Ach",uVar5,0);
          cVar2 = SteamUserStats.GetAchievement(uVar5);
          if (!cVar2) {
            Int32.ToString(&local_54,0);
            uVar5 = String.Concat("SteamUserStats.GetAchievement failed for Achievement Ach");
            Debug.LogWarning(uVar5);
          }
          local_54 = local_54 + 1;
        }
        LAB_180a16e04:
        do {
          lVar7 = GameController.ChangeAllAreaStateIDs;
          if ((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 0x1d0)) == null) goto LAB_180a17188;
          if (*(int *)(lVar7 + 24) <= iVar8) {
            lVar7 = FUN_180210740(0);
            if (lVar7 != null) {
              GameDataController.CheckAllAch(lVar7,0);
              SteamStatsAndAchievements.CheckDLCState(this,0);
              return;
            }
            goto LAB_180a17188;
          }
          lVar7 = FUN_180210740(0);
          if (((lVar7 == null) || (*(int64 *)(lVar7 + 0x1d0) == 0)) ||
             (lVar7 = FUN_1800024b0(*(int64 *)(lVar7 + 0x1d0),local_58,DAT_181e5cf18)) == null)
          goto LAB_180a17188;
          if (*(int *)(lVar7 + 32) == 0) {
            uVar5 = Int32.ToString(&local_58);
            uVar5 = String.Concat("AchData",uVar5,0);
            SteamUserStats.GetStat(uVar5,local_4c,0);
            fVar1 = local_4c[0];
            lVar7 = GameController.difficultyExtraPoint;
            if (lVar7 == null) goto LAB_180a17188;
            lVar7 = *(int64 *)(lVar7 + 16);
            uVar5 = Int32.ToString(&local_58,0);
            uVar5 = String.Concat("AchData",uVar5,0);
            if (lVar7 == null) goto LAB_180a17188;
            fVar9 = (float)PlayerPrefDictionary.GetFloat(lVar7,uVar5,0);
            if (fVar9 < fVar1) {
              lVar7 = GameController.difficultyExtraPoint;
              if (lVar7 == null) goto LAB_180a17188;
              lVar7 = *(int64 *)(lVar7 + 16);
              uVar5 = Int32.ToString(&local_58,0);
              uVar5 = String.Concat("AchData",uVar5,0);
              if (lVar7 == null) goto LAB_180a17188;
              PlayerPrefDictionary.SetKey(lVar7,uVar5,local_4c[0],0);
            }
          }
          else {
            uVar5 = Int32.ToString(&local_58);
            uVar5 = String.Concat("AchData",uVar5,0);
            SteamUserStats.GetStat(uVar5,&local_50,0);
            iVar8 = local_50;
            lVar7 = GameController.difficultyExtraPoint;
            if (lVar7 == null) goto LAB_180a17188;
            lVar7 = *(int64 *)(lVar7 + 16);
            uVar5 = Int32.ToString(&local_58,0);
            uVar5 = String.Concat("AchData",uVar5,0);
            if (lVar7 == null) goto LAB_180a17188;
            iVar3 = PlayerPrefDictionary.GetInt(lVar7,uVar5,0);
            if (iVar3 < iVar8) {
              lVar7 = GameController.difficultyExtraPoint;
              if (lVar7 == null) goto LAB_180a17188;
              lVar7 = *(int64 *)(lVar7 + 16);
              uVar5 = Int32.ToString(&local_58,0);
              uVar5 = String.Concat("AchData",uVar5,0);
              if (lVar7 == null) goto LAB_180a17188;
              PlayerPrefDictionary.SetKey(lVar7,uVar5,local_50);
              iVar8 = local_58 + 1;
              local_58 = iVar8;
              goto LAB_180a16e04;
            }
          }
          iVar8 = local_58 + 1;
          local_58 = iVar8;
        } while( true );
    }

    // Token : 0x60022B2
    // RVA   : 0xA17190   Offset: 0xA15F90   Length: 0x199
    private void OnUserStatsStored(UserStatsStored_t pCallback)
    {
        ulong uVar2;
        ulong local_28;
        ulong uStack_20;
        ulong local_18;
        if ((this.m_GameID == *pCallback) && ((int)pCallback[1] != 1)) {
          if ((int)pCallback[1] == 8) {
            Debug.Log("StoreStats - some failed to validate",0);
            local_28 = this.m_GameID;
            local_18 = 0;
            uStack_20 = 1;
            SteamStatsAndAchievements.OnUserStatsReceived(this,&local_28,0);
            return;
          }
          plVar1 = (int64 *)il2cpp_value_box(DAT_181ea3048,pCallback + 1);
          if (plVar1 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          uVar2 = (**(code **)(*plVar1 + 0x168))(plVar1,*(uint64 *)(*plVar1 + 0x170));
          puVar3 = (uint32 *)il2cpp_object_unbox(plVar1);
          *(uint32 *)(pCallback + 1) = *puVar3;
          uVar2 = String.Concat("StoreStats - failed, ",uVar2,0);
          Debug.Log(uVar2,0);
        }
    }

    // Token : 0x60022B3
    // RVA   : 0xA16620   Offset: 0xA15420   Length: 0x41B
    private void OnAchievementStored(UserAchievementStored_t pCallback)
    {
        long lVar2;
        long lVar3;
        ulong uVar4;
        if (this.m_GameID == *pCallback) {
          if (SUB164(*(uint8 (*) [16])(pCallback + 2),12) == 0) {
            uVar4 = FUN_1809b03c0(pCallback,0);
            uVar4 = String.Concat("Achievement '",uVar4,"' unlocked!",0);
            Debug.Log(uVar4,0);
            return;
          }
          plVar1 = (int64 *)FUN_1801dfd90(DAT_181e85e38,7);
          if (plVar1 == (int64 *)0) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          if (("Achievement '" != 0) &&
             (lVar2 = il2cpp_internal("Achievement '",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar4,0);
          }
          lVar2 = "Achievement '";
          if ((int)plVar1[3] == 0) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar4,0);
          }
          plVar1[4] = "Achievement '";
          il2cpp_internal(plVar1 + 4,lVar2);
          lVar2 = FUN_1809b03c0(pCallback,0);
          if ((lVar2 != null) &&
             (lVar3 = il2cpp_internal(lVar2,*(uint64 *)(*plVar1 + 64))) == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar4,0);
          }
          if (*(uint32 *)(plVar1 + 3) < 2) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar4,0);
          }
          plVar1[5] = lVar2;
          il2cpp_internal(plVar1 + 5,lVar2);
          if (("' progress callback, (" != 0) &&
             (lVar2 = il2cpp_internal("' progress callback, (",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar4,0);
          }
          lVar2 = "' progress callback, (";
          if (*(uint32 *)(plVar1 + 3) < 3) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar4,0);
          }
          plVar1[6] = "' progress callback, (";
          il2cpp_internal(plVar1 + 6,lVar2);
          lVar2 = UInt32.ToString(pCallback + 3,0);
          if ((lVar2 != null) &&
             (lVar3 = il2cpp_internal(lVar2,*(uint64 *)(*plVar1 + 64))) == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar4,0);
          }
          if (*(uint32 *)(plVar1 + 3) < 4) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar4,0);
          }
          plVar1[7] = lVar2;
          il2cpp_internal(plVar1 + 7,lVar2);
          if (("," != 0) &&
             (lVar2 = il2cpp_internal(",",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar4,0);
          }
          lVar2 = ",";
          if (*(uint32 *)(plVar1 + 3) < 5) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar4,0);
          }
          plVar1[8] = ",";
          il2cpp_internal(plVar1 + 8,lVar2);
          lVar2 = UInt32.ToString((int64)pCallback + 28,0);
          if ((lVar2 != null) &&
             (lVar3 = il2cpp_internal(lVar2,*(uint64 *)(*plVar1 + 64))) == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar4,0);
          }
          if (*(uint32 *)(plVar1 + 3) < 6) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar4,0);
          }
          plVar1[9] = lVar2;
          il2cpp_internal(plVar1 + 9,lVar2);
          if ((")" != 0) &&
             (lVar2 = il2cpp_internal(")",*(uint64 *)(*plVar1 + 64))) == null) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar4,0);
          }
          lVar2 = ")";
          if (*(uint32 *)(plVar1 + 3) < 7) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar4,0);
          }
          plVar1[10] = ")";
          il2cpp_internal(plVar1 + 10,lVar2);
          uVar4 = String.Concat(plVar1,0);
          Debug.Log(uVar4,0);
        }
    }

    // Token : 0x60022B4
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
