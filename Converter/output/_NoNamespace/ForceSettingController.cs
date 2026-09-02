// ============================================================
// Type  : ForceSettingController
// Token : 0x200028A
// ============================================================

public class ForceSettingController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40013D9
    public GameObject forceSettingUIPanel;

    // Token: 0x40013DA
    public ForceData targetForce;

    // Token: 0x40013DB
    public GameObject forceJobSettingList;

    // Token: 0x40013DC
    public GameObject branchLeaderSettingList;

    // Token: 0x40013DD
    public GameObject branchLeaderSettingTabPrefab;

    // Token: 0x40013DE
    private GameObject temp;

    // Token: 0x40013DF
    private static ForceSettingController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600148A
    // RVA   : 0x7822A0   Offset: 0x780AA0   Length: 0x36
    public static ForceSettingController get_Instance()
    {
        return **(uint64 **)(DAT_181da2d20 + 184);
    }

    // Token : 0x600148B
    // RVA   : 0x77F490   Offset: 0x77DC90   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181da2d20 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x600148C
    // RVA   : 0x780F10   Offset: 0x77F710   Length: 0x3F
    public void HideForceSettingUI()
    {
        ForceSettingController.CLearAllJobs(this,0);
        this.targetForce = 0;
        if (this.forceSettingUIPanel != null) {
          GameObject.SetActive(this.forceSettingUIPanel,0,0);
          return;
        }
    }

    // Token : 0x600148D
    // RVA   : 0x7820B0   Offset: 0x7808B0   Length: 0x1E0
    public void ShowForceSettingUI(ForceData _targetForce)
    {
        long lVar1;
        this.targetForce = _targetForce;
        if (this.forceSettingUIPanel != null) {
          GameObject.SetActive(this.forceSettingUIPanel,1,0);
          lVar1 = this.targetForce;
          plVar4 = (int64 *)0;
          plVar2 = plVar4;
          if (lVar1 != null) {
            while ((lVar1.forceJobSettingData != null &&
                   (lVar1 = *(int64 *)(lVar1.forceJobSettingData + 24)) != null)) {
              plVar3 = plVar4;
              if (lVar1.forceName <= (int)plVar2) {
                ForceSettingController.RegenerateBranchSettings(this,0);
                plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/OpenBook",0);
                if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181d8a228)) {
                  plVar4 = plVar2;
                }
                NGUITools.PlaySound(plVar4,0);
                return;
              }
              while( true ) {
                if ((((this.targetForce == null) ||
                     (lVar1 = this.targetForce.forceJobSettingData) == null) ||
                    (lVar1 = lVar1.forceName) == null) ||
                   (lVar1 = FUN_180002f80(lVar1,plVar2,DAT_181d51688)) == null) throw; // [null/range check failed]
                if (lVar1.forceName <= (int)plVar3) break;
                ForceSettingController.RefreshForceJob(this,plVar2,plVar3,0);
                plVar3 = (int64 *)(uint64)((int)plVar3 + 1);
              }
              lVar1 = this.targetForce;
              plVar2 = (int64 *)(uint64)((int)plVar2 + 1);
              if (lVar1 == null) break;
            }
          }
        }
    }

    // Token : 0x600148E
    // RVA   : 0x781E20   Offset: 0x780620   Length: 0x28C
    public void RegenerateBranchSettings()
    {
        ulong uVar1;
        long lVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        int iVar8;
        uVar7 = this.branchLeaderSettingList;
        GlobalData.DeleteAllChild(uVar7,0);
        iVar8 = 0;
        lVar4 = this.targetForce;
        while (lVar4 != null) {
          if (lVar4.ownAreasID == null) break;
          if (*(int *)(lVar4.ownAreasID + 24) <= iVar8) {
            return;
          }
          lVar4 = FUN_18046c0a0(0);
          if (lVar4 == null) break;
          lVar4 = lVar4.defaultSkinID;
          if ((((this.targetForce == null) ||
               (lVar5 = this.targetForce.ownAreasID) == null) ||
              (uVar3 = FUN_1800d6750(lVar5,iVar8,DAT_181d68270), lVar4 == null)) ||
             (lVar4 = WorldData.GetArea(lVar4,uVar3,0)) == null) break;
          if (lVar4.startSkillBookID != 2) {
            uVar7 = this.branchLeaderSettingList;
            uVar1 = this.branchLeaderSettingTabPrefab;
            lVar4 = GlobalData.AddChild(uVar7,uVar1,0);
            if (lVar4 == null) break;
            lVar5 = GameObject.GetComponent(lVar4,DAT_181d9ebb8);
            lVar6 = FUN_18046c0a0(0);
            if (lVar6 == null) break;
            lVar6 = *(int64 *)(lVar6 + 32);
            if ((((this.targetForce == null) ||
                 (lVar2 = this.targetForce.ownAreasID) == null) ||
                (uVar3 = FUN_1800d6750(lVar2,iVar8,DAT_181d68270), lVar6 == null)) ||
               (uVar7 = WorldData.GetArea(lVar6,uVar3,0), lVar5 == null)) break;
            *(uint64 *)(lVar5 + 32) = uVar7;
            lVar5 = GameObject.GetComponent(lVar4,DAT_181d9ebb8);
            if (lVar5 == null) break;
            *(uint64 *)(lVar5 + 40) = this.targetForce;
            lVar4 = GameObject.GetComponent(lVar4,DAT_181d9ebb8);
            if (lVar4 == null) break;
            lVar4.forceName = 1;
          }
          iVar8 = iVar8 + 1;
          lVar4 = this.targetForce;
        }
    }

    // Token : 0x600148F
    // RVA   : 0x77F4E0   Offset: 0x77DCE0   Length: 0x1FD
    public void CLearAllJobs()
    {
        int iVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        int[] local_res8 = new int[2];
        int[] local_res18 = new int[4];
        lVar2 = this.targetForce;
        local_res18[0] = 0;
        local_res8[0] = 0;
        if (lVar2 != null) {
          while ((lVar2.forceJobSettingData != null &&
                 (lVar2 = *(int64 *)(lVar2.forceJobSettingData + 24)) != null)) {
            if (lVar2.forceName <= local_res18[0]) {
              return;
            }
            local_res8[0] = 0;
            while( true ) {
              iVar1 = local_res8[0];
              if ((((this.targetForce == null) ||
                   (lVar2 = this.targetForce.forceJobSettingData) == null) ||
                  (lVar2 = lVar2.forceName) == null) ||
                 (lVar2 = FUN_180002f80(lVar2,local_res18[0],DAT_181d51688)) == null)
              throw; // [null/range check failed]
              if (lVar2.forceName <= iVar1) break;
              if (this.forceJobSettingList == null) throw; // [null/range check failed]
              lVar2 = GameObject.get_transform(this.forceJobSettingList,0);
              uVar3 = Int32.ToString(local_res18,0);
              uVar4 = Int32.ToString(local_res8,0);
              uVar3 = String.Concat(uVar3,"_",uVar4,0);
              if (((lVar2 == null) || (lVar2 = Transform.Find(lVar2,uVar3,0)) == null) ||
                 (lVar2 = Transform.Find(lVar2,"HeroIcon",0)) == null) throw; // [null/range check failed]
              uVar3 = Component.get_gameObject(lVar2,0);
              GlobalData.DeleteAllChild(uVar3,0);
              local_res8[0] = local_res8[0] + 1;
            }
            lVar2 = this.targetForce;
            local_res18[0] = local_res18[0] + 1;
            if (lVar2 == null) break;
          }
        }
    }

    // Token : 0x6001490
    // RVA   : 0x780F50   Offset: 0x77F750   Length: 0xEE
    public void RefreshAllForceJobs()
    {
        long lVar1;
        int iVar2;
        int iVar3;
        lVar1 = this.targetForce;
        iVar3 = 0;
        if (lVar1 != null) {
          while ((lVar1.forceJobSettingData != null &&
                 (lVar1 = *(int64 *)(lVar1.forceJobSettingData + 24)) != null)) {
            if (lVar1.forceName <= iVar3) {
              return;
            }
            iVar2 = 0;
            while( true ) {
              if ((((this.targetForce == null) ||
                   (lVar1 = this.targetForce.forceJobSettingData) == null) ||
                  (lVar1 = lVar1.forceName) == null) ||
                 (lVar1 = FUN_180002f80(lVar1,iVar3,DAT_181d51688)) == null) throw; // [null/range check failed]
              if (lVar1.forceName <= iVar2) break;
              ForceSettingController.RefreshForceJob(this,iVar3,iVar2,0);
              iVar2 = iVar2 + 1;
            }
            lVar1 = this.targetForce;
            iVar3 = iVar3 + 1;
            if (lVar1 == null) break;
          }
        }
    }

    // Token : 0x6001491
    // RVA   : 0x781040   Offset: 0x77F840   Length: 0xDDD
    public void RefreshForceJob(int jobType, int jobID)
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_e188 = *(int64*)(DAT_181d4e188 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar6;
        long lVar7;
        uint[] local_res8 = new uint[2];
        uint[] local_res10 = new uint[2];
        uint[] local_res18 = new uint[4];
        ulong local_58;
        uint local_50;
        byte[] local_48 = new byte[16];
        local_res10[0] = jobType;
        local_res18[0] = jobID;
        if (this.forceJobSettingList != null) {
          lVar2 = GameObject.get_transform(this.forceJobSettingList,0);
          uVar3 = Int32.ToString(local_res10,0);
          uVar4 = Int32.ToString(local_res18,0);
          uVar3 = String.Concat(uVar3,"_",uVar4,0);
          if (((lVar2 != null) && (lVar2 = Transform.Find(lVar2,uVar3,0)) != null) &&
             (lVar2 = Transform.Find(lVar2,"Text",0)) != null) {
            uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
            lVar2 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 32);
            if (lVar2 != null) {
              lVar2 = *(int64 *)(lVar2 + 96);
              lVar6 = (int64)(int)local_res10[0];
              if (lVar2 != null) {
                if (*(uint32 *)(lVar2 + 24) <= local_res10[0]) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar2 = *(int64 *)(*(int64 *)(lVar2 + 16) + 32 + lVar6 * 8);
                if (lVar2 != null) {
                  lVar2 = *(int64 *)(lVar2 + 24);
                  lVar6 = (int64)(int)local_res18[0];
                  if (lVar2 != null) {
                    if (*(uint32 *)(lVar2 + 24) <= local_res18[0]) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar2 = *(int64 *)(*(int64 *)(lVar2 + 16) + 32 + lVar6 * 8);
                    if (lVar2 != null) {
                      LTLocalization.SetText(uVar3,*(uint64 *)(lVar2 + 16),0);
                      if (this.forceJobSettingList != null) {
                        lVar2 = GameObject.get_transform(this.forceJobSettingList,0);
                        uVar3 = Int32.ToString(local_res10,0);
                        uVar4 = Int32.ToString(local_res18,0);
                        uVar3 = String.Concat(uVar3,"_",uVar4,0);
                        if (((lVar2 != null) && (lVar2 = Transform.Find(lVar2,uVar3,0)) != null) &&
                           (lVar2 = Transform.Find(lVar2,"TextBack",0)) != null) {
                          lVar2 = Component.GetComponent(lVar2,DAT_181d6ccc0);
                          uVar3 = ForceSettingController.GetForceJobDescribe
                                            (this,local_res10[0],local_res18[0],0);
                          if (lVar2 != null) {
                            *(uint64 *)(lVar2 + 24) = uVar3;
                            if (this.forceJobSettingList != null) {
                              lVar2 = GameObject.get_transform(this.forceJobSettingList,0);
                              uVar3 = Int32.ToString(local_res10,0);
                              uVar4 = Int32.ToString(local_res18,0);
                              uVar3 = String.Concat(uVar3,"_",uVar4,0);
                              if (((lVar2 != null) && (lVar2 = Transform.Find(lVar2,uVar3,0)) != null)
                                 && (lVar2 = Transform.Find(lVar2,"HeroIcon",0)) != null) {
                                uVar3 = Component.get_gameObject(lVar2,0);
                                GlobalData.DeleteAllChild(uVar3,0);
                                if ((this.targetForce != null) &&
                                   (lVar2 = this.targetForce.forceJobSettingData,
                                   lVar2 != null)) {
                                  lVar2 = *(int64 *)(lVar2 + 24);
                                  lVar6 = (int64)(int)local_res10[0];
                                  if (lVar2 != null) {
                                    if (*(uint32 *)(lVar2 + 24) <= local_res10[0]) {
                                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                    }
                                    lVar2 = *(int64 *)(*(int64 *)(lVar2 + 16) + 32 + lVar6 * 8);
                                    lVar6 = (int64)(int)local_res18[0];
                                    if (lVar2 != null) {
                                      if (*(uint32 *)(lVar2 + 24) <= local_res18[0]) {
                                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                      }
                                      lVar1 = this.forceJobSettingList;
                                      if (*(int *)(*(int64 *)(lVar2 + 16) + 32 + lVar6 * 4) == -1)
                                      {
                                        if (lVar1 != null) {
                                          lVar2 = GameObject.get_transform(lVar1,0);
                                          uVar3 = Int32.ToString(local_res10,0);
                                          uVar4 = Int32.ToString(local_res18,0);
                                          uVar3 = String.Concat(uVar3,"_",uVar4,0);
                                          if ((((lVar2 != null) &&
                                               (lVar2 = Transform.Find(lVar2,uVar3,0)) != null) &&
                                              (lVar2 = Transform.Find(lVar2,"HeroBack",0)) != null
                                              ) && (lVar2 = Component.GetComponent(lVar2,DAT_181d6af40),
                                                   lVar2 != null)) {
                                            Selectable.set_interactable(lVar2,1,0);
                                            if (this.forceJobSettingList != null) {
                                              lVar2 = GameObject.get_transform
                                                                (this.forceJobSettingList,0);
                                              uVar3 = Int32.ToString(local_res10,0);
                                              uVar4 = Int32.ToString(local_res18,0);
                                              uVar3 = String.Concat(uVar3,"_",uVar4,0);
                                              if ((lVar2 != null) &&
                                                 (lVar2 = Transform.Find(lVar2,uVar3,0)) != null) {
                                                lVar2 = Transform.Find(lVar2,"ClearButton",0);
                                                puVar5 = (uint64 *)Vector3.get_zero(local_48,0);
                                                if (lVar2 != null) {
                                                  local_50 = *(uint32 *)(puVar5 + 1);
                                                  local_58 = *puVar5;
                                                  Transform.set_localScale(lVar2,&local_58,0);
                                                  return;
                                                }
                                              }
                                            }
                                          }
                                        }
                                      }
                                      else if (lVar1 != null) {
                                        lVar2 = GameObject.get_transform(lVar1,0);
                                        uVar3 = Int32.ToString(local_res10,0);
                                        uVar4 = Int32.ToString(local_res18,0);
                                        uVar3 = String.Concat(uVar3,"_",uVar4,0);
                                        if (((lVar2 != null) &&
                                            (lVar2 = Transform.Find(lVar2,uVar3,0)) != null) &&
                                           (lVar2 = Transform.Find(lVar2,"HeroIcon",0)) != null) {
                                          uVar3 = Component.get_gameObject(lVar2,0);
                                          if (*pStatics_e188 != 0) {
                                            uVar4 = *(uint64 *)
                                                     (*pStatics_e188 + 144);
                                            uVar3 = GlobalData.AddChild(uVar3,uVar4,0);
                                            this.temp = uVar3;
                                            if ((this.temp != null) &&
                                               (lVar2 = GameObject.GetComponent
                                                                  (this.temp,
                                                                   DAT_181d9fb20), lVar2 != null)) {
                                              *(uint8 *)(lVar2 + 88) = 1;
                                              if (this.temp != null) {
                                                lVar2 = GameObject.GetComponent
                                                                  (this.temp,
                                                                   DAT_181d9fb20);
                                                if (*pStatics_df90 != 0) {
                                                  lVar6 = *(int64 *)
                                                           (*pStatics_df90 + 32);
                                                  if ((this.targetForce != null) &&
                                                     (lVar1 = *(int64 *)
                                                               (this.targetForce + 0x160),
                                                     lVar1 != null)) {
                                                    lVar1 = *(int64 *)(lVar1 + 24);
                                                    lVar7 = (int64)(int)local_res10[0];
                                                    if (lVar1 != null) {
                                                      if (*(uint32 *)(lVar1 + 24) <= local_res10[0]) {
                                                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                                      }
                                                      lVar1 = *(int64 *)
                                                               (*(int64 *)(lVar1 + 16) + 32 +
                                                               lVar7 * 8);
                                                      lVar7 = (int64)(int)local_res18[0];
                                                      if (lVar1 != null) {
                                                        if (*(uint32 *)(lVar1 + 24) <= local_res18[0]) {
                                                          ThrowHelper.ThrowArgumentOutOfRangeException(0)
                                                          ;
                                                        }
                                                        if ((lVar6 != null) &&
                                                           (uVar3 = WorldData.GetHero(lVar6,*(uint32
                                                                                               *)(*(
                                                        int64 *)(lVar1 + 16) + 32 + lVar7 * 4),0),
                                                        lVar2 != null)) {
                                                          *(uint64 *)(lVar2 + 32) = uVar3;
                                                          il2cpp_internal((uint64 *)(lVar2 + 32)
                                                                              ,uVar3);
                                                          if ((this.temp != null) &&
                                                             (lVar2 = GameObject.GetComponent
                                                                                (*(int64 *)
                                                                                  (this + 64),
                                                                                 DAT_181d9fb20),
                                                             lVar2 != null)) {
                                                            *(uint32 *)(lVar2 + 24) = 0;
                                                            if (this.forceJobSettingList != null) {
                                                              lVar2 = GameObject.get_transform
                                                                                (*(int64 *)
                                                                                  (this + 40),0);
                                                              uVar3 = Int32.ToString(local_res10,0);
                                                              uVar4 = Int32.ToString(local_res18,0);
                                                              uVar3 = String.Concat(uVar3,"_",
                                                                                     uVar4,0);
                                                              if ((((lVar2 != null) &&
                                                                   (lVar2 = Transform.Find(lVar2,uVar3,0)
                                                                   , lVar2 != null)) &&
                                                                  (lVar2 = Transform.Find(lVar2,
                                                        "HeroBack",0), lVar2 != null)) &&
                                                        (lVar2 = Component.GetComponent
                                                                           (lVar2,DAT_181d6af40),
                                                        lVar2 != null)) {
                                                          Selectable.set_interactable(lVar2,0,0);
                                                          if (this.forceJobSettingList != null) {
                                                            lVar2 = GameObject.get_transform
                                                                              (*(int64 *)
                                                                                (this + 40),0);
                                                            uVar3 = Int32.ToString(local_res10,0);
                                                            uVar4 = Int32.ToString(local_res18,0);
                                                            uVar3 = String.Concat(uVar3,"_",
                                                                                   uVar4,0);
                                                            if ((lVar2 != null) &&
                                                               (lVar2 = Transform.Find(lVar2,uVar3,0),
                                                               lVar2 != null)) {
                                                              lVar2 = Transform.Find(lVar2,"ClearButton",
                                                                                      0);
                                                              puVar5 = (uint64 *)
                                                                       Vector3.get_one(local_48,0);
                                                              if (lVar2 != null) {
                                                                local_50 = *(uint32 *)(puVar5 + 1);
                                                                local_58 = *puVar5;
                                                                Transform.set_localScale
                                                                          (lVar2,&local_58,0);
                                                                if (this.forceJobSettingList != null) {
                                                                  lVar2 = GameObject.get_transform
                                                                                    (*(int64 *)
                                                                                      (this + 40),0);
                                                                  uVar3 = Int32.ToString(local_res10,0);
                                                                  uVar4 = Int32.ToString(local_res18,0);
                                                                  uVar3 = String.Concat(uVar3,
                                                        "_",uVar4,0);
                                                        if (((lVar2 != null) &&
                                                            (lVar2 = Transform.Find(lVar2,uVar3,0),
                                                            lVar2 != null)) &&
                                                           (lVar2 = Transform.Find(lVar2,"ClearButton",0)
                                                           , lVar2 != null)) {
                                                          lVar2 = Component.GetComponent
                                                                            (lVar2,DAT_181d6af40);
                                                          if (*pStatics_df90 != 0)
                                                          {
                                                            lVar6 = *(int64 *)
                                                                     (**(int64 **)
                                                                        (DAT_181d4df90 + 184) + 32);
                                                            if ((this.targetForce != null) &&
                                                               (lVar1 = *(int64 *)
                                                                         (this.targetForce +
                                                                         0x160), lVar1 != null)) {
                                                              lVar1 = *(int64 *)(lVar1 + 24);
                                                              lVar7 = (int64)(int)local_res10[0];
                                                              if (lVar1 != null) {
                                                                if (*(uint32 *)(lVar1 + 24) <=
                                                                    local_res10[0]) {

                                                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                                        }
                                                        lVar1 = *(int64 *)
                                                                 (*(int64 *)(lVar1 + 16) + 32 +
                                                                 lVar7 * 8);
                                                        lVar7 = (int64)(int)local_res18[0];
                                                        if (lVar1 != null) {
                                                          if (*(uint32 *)(lVar1 + 24) <= local_res18[0]) {
                                                            ThrowHelper.ThrowArgumentOutOfRangeException
                                                                      (0);
                                                          }
                                                          if (((lVar6 != null) &&
                                                              (lVar6 = WorldData.GetHero(lVar6,*(
                                                        uint32 *)
                                                        (*(int64 *)(lVar1 + 16) + 32 + lVar7 * 4),0
                                                        ), lVar6 != null)) && (lVar2 != null)) {
                                                          Selectable.set_interactable
                                                                    (lVar2,*(int *)(lVar6 + 152) < 1,0);
                                                          if (this.forceJobSettingList != null) {
                                                            lVar2 = GameObject.get_transform
                                                                              (*(int64 *)
                                                                                (this + 40),0);
                                                            uVar3 = Int32.ToString(local_res10,0);
                                                            uVar4 = Int32.ToString(local_res18,0);
                                                            uVar3 = String.Concat(uVar3,"_",
                                                                                   uVar4,0);
                                                            if (((lVar2 != null) &&
                                                                (lVar2 = Transform.Find(lVar2,uVar3,0),
                                                                lVar2 != null)) &&
                                                               (lVar2 = Transform.Find(lVar2,
                                                        "ClearButton",0), lVar2 != null)) {
                                                          lVar2 = Component.GetComponent
                                                                            (lVar2,DAT_181d6ccc0);
                                                          if (*pStatics_df90 != 0)
                                                          {
                                                            lVar6 = *(int64 *)
                                                                     (**(int64 **)
                                                                        (DAT_181d4df90 + 184) + 32);
                                                            if ((this.targetForce != null) &&
                                                               (lVar1 = *(int64 *)
                                                                         (this.targetForce +
                                                                         0x160), lVar1 != null)) {
                                                              lVar1 = *(int64 *)(lVar1 + 24);
                                                              lVar7 = (int64)(int)local_res10[0];
                                                              if (lVar1 != null) {
                                                                if (*(uint32 *)(lVar1 + 24) <=
                                                                    local_res10[0]) {

                                                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                                        }
                                                        lVar1 = *(int64 *)
                                                                 (*(int64 *)(lVar1 + 16) + 32 +
                                                                 lVar7 * 8);
                                                        lVar7 = (int64)(int)local_res18[0];
                                                        if (lVar1 != null) {
                                                          if (*(uint32 *)(lVar1 + 24) <= local_res18[0]) {
                                                            ThrowHelper.ThrowArgumentOutOfRangeException
                                                                      (0);
                                                          }
                                                          if ((lVar6 != null) &&
                                                             (lVar6 = WorldData.GetHero(lVar6,*(
                                                        uint32 *)
                                                        (*(int64 *)(lVar1 + 16) + 32 + lVar7 * 4),0
                                                        ), lVar6 != null)) {
                                                          uVar3 = "撤除职位";
                                                          if (0 < *(int *)(lVar6 + 152)) {
                                                            lVar6 = FUN_18046c0a0(0);
                                                            if (lVar6 == null) {
        LAB_180781e18:
                          // WARNING: Subroutine does not return
                                                              FUN_1800d6620();
                                                            }
                                                            lVar6 = *(int64 *)(lVar6 + 32);
                                                            if ((this.targetForce == null) ||
                                                               (lVar1 = *(int64 *)
                                                                         (this.targetForce +
                                                                         0x160), lVar1 == null))
                                                            goto LAB_180781e18;
                                                            lVar1 = *(int64 *)(lVar1 + 24);
                                                            lVar7 = (int64)(int)local_res10[0];
                                                            if (lVar1 == null) goto LAB_180781e18;
                                                            if (*(uint32 *)(lVar1 + 24) <= local_res10[0])
                                                            {

                                                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                                        }
                                                        lVar1 = *(int64 *)
                                                                 (*(int64 *)(lVar1 + 16) + 32 +
                                                                 lVar7 * 8);
                                                        lVar7 = (int64)(int)local_res18[0];
                                                        if (lVar1 == null) goto LAB_180781e18;
                                                        if (*(uint32 *)(lVar1 + 24) <= local_res18[0]) {
                                                          ThrowHelper.ThrowArgumentOutOfRangeException(0)
                                                          ;
                                                        }
                                                        if ((lVar6 == null) ||
                                                           (lVar6 = WorldData.GetHero(lVar6,*(uint32
                                                                                               *)(*(
                                                        int64 *)(lVar1 + 16) + 32 + lVar7 * 4),0),
                                                        lVar6 == null)) goto LAB_180781e18;
                                                        local_res8[0] = *(uint32 *)(lVar6 + 152);
                                                        uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res8)
                                                        ;
                                                        uVar3 = String.Format("撤除职位\n冷却{0}天",uVar3,0);
                                                        }
                                                        if (lVar2 != null) {
                                                          *(uint64 *)(lVar2 + 24) = uVar3;
                                                          il2cpp_internal((uint64 *)(lVar2 + 24)
                                                                              ,uVar3);
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
            }
          }
        }
    }

    // Token : 0x6001492
    // RVA   : 0x780500   Offset: 0x77ED00   Length: 0xA0E
    public string GetForceJobDescribe(int jobType, int jobID)
    {
        var pStatics_e010 = *(int64*)(DAT_181d4e010 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        uint uVar1;
        bool cVar2;
        uint uVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar6;
        long lVar7;
        int iVar8;
        long lVar9;
        uint local_38;
        float local_34;
        long local_30;
        lVar9 = (int64)(int)jobType;
        lVar6 = *(int64 *)(pStatics_e010 + 32);
        if ((lVar6 != null) && (lVar6 = *(int64 *)(lVar6 + 96)) != null) {
          if (*(uint32 *)(lVar6 + 24) <= jobType) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar6 = *(int64 *)(*(int64 *)(lVar6 + 16) + 32 + lVar9 * 8);
          if ((lVar6 != null) && (lVar6 = *(int64 *)(lVar6 + 24)) != null) {
            if (*(uint32 *)(lVar6 + 24) <= jobID) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar6 = lVar6[jobID];
            if (lVar6 != null) {
              lVar6 = *(int64 *)(lVar6 + 24);
              uVar5 = *(uint64 *)(pStatics_ef00 + 0x260);
              if (this.targetForce != null) {
                local_38 = ForceData.GetForceJobExtraAttriNum(this.targetForce,0);
                uVar4 = Int32.ToString(&local_38,0);
                uVar5 = String.Concat(uVar5,uVar4,"</color>",0);
                if (lVar6 != null) {
                  lVar6 = String.Replace(lVar6,"#ForceJobAttriNum#",uVar5,0);
                  uVar5 = *(uint64 *)(pStatics_ef00 + 0x260);
                  if (this.targetForce != null) {
                    local_34 = (float)ForceData.GetForceJobExtraExpRate(this.targetForce,0);
                    local_34 = local_34 * 100.0;
                    uVar4 = Single.ToString(&local_34,0);
                    uVar5 = String.Concat(uVar5,uVar4,"%</color>",0);
                    if (lVar6 != null) {
                      local_30 = String.Replace(lVar6,"#ForceJobExpRate#",uVar5,0);
                      lVar6 = *(int64 *)(pStatics_e010 + 32);
                      if ((lVar6 != null) && (lVar6 = *(int64 *)(lVar6 + 96)) != null) {
                        if (*(uint32 *)(lVar6 + 24) <= jobType) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar6 = *(int64 *)(*(int64 *)(lVar6 + 16) + 32 + lVar9 * 8);
                        if ((lVar6 != null) && (lVar6 = *(int64 *)(lVar6 + 24)) != null) {
                          if (*(uint32 *)(lVar6 + 24) <= jobID) {
                            ThrowHelper.ThrowArgumentOutOfRangeException(0);
                          }
                          lVar6 = *(int64 *)
                                   (*(int64 *)(lVar6 + 16) + 32 + (int64)(int)jobID * 8);
                          if (lVar6 != null) {
                            lVar7 = *(int64 *)(lVar6 + 32);
                            iVar8 = 0;
                            uVar5 = "";
                            if (lVar7 != null) {
                              while (iVar8 < *(int *)(lVar7 + 24)) {
                                cVar2 = FUN_1816fd990(uVar5,"",0);
                                uVar4 = "/";
                                if (cVar2) {
                                  uVar4 = "";
                                }
                                lVar7 = *(int64 *)(pStatics_ef00 + 0x4a8);
                                if ((*(int64 *)(lVar6 + 32) == 0) ||
                                   (uVar3 = FUN_1800d6750(*(int64 *)(lVar6 + 32),iVar8,DAT_181d6b9e8)
                                   , lVar7 == null)) throw; // [null/range check failed]
                                FUN_180002f80(lVar7,uVar3,DAT_181d7c9c0);
                                uVar5 = String.Concat(uVar5,uVar4);
                                iVar8 = iVar8 + 1;
                                lVar7 = *(int64 *)(lVar6 + 32);
                                if (lVar7 == null) throw; // [null/range check failed]
                              }
                              if (local_30 != 0) {
                                lVar6 = String.Replace(local_30,"#EffectSkill#",uVar5,0);
                                uVar5 = ForceSettingController.GetEffectForceSpeAddText
                                                  (this,jobType,jobID,0);
                                if (lVar6 != null) {
                                  uVar5 = String.Replace(lVar6,"#EffectForceSpeAdd#",uVar5,0);
                                  lVar6 = *(int64 *)(pStatics_e010 + 32);
                                  if ((lVar6 != null) && (lVar6 = *(int64 *)(lVar6 + 96)) != null) {
                                    if (*(uint32 *)(lVar6 + 24) <= jobType) {
                                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                    }
                                    lVar6 = *(int64 *)(*(int64 *)(lVar6 + 16) + 32 + lVar9 * 8);
                                    if (lVar6 != null) {
                                      if (*(int *)(lVar6 + 16) != -1) {
                                        lVar6 = *(int64 *)(pStatics_ef00 + 0x3d0)
                                        ;
                                        lVar7 = *(int64 *)(pStatics_e010 + 32);
                                        if ((lVar7 == null) ||
                                           (lVar7 = *(int64 *)(lVar7 + 96)) == null)
                                        throw; // [null/range check failed]
                                        if (*(uint32 *)(lVar7 + 24) <= jobType) {
                                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                        }
                                        lVar7 = *(int64 *)
                                                 (*(int64 *)(lVar7 + 16) + 32 + lVar9 * 8);
                                        if ((lVar7 == null) || (lVar6 == null)) throw; // [null/range check failed]
                                        uVar1 = *(uint32 *)(lVar7 + 16);
                                        if (*(uint32 *)(lVar6 + 24) <= uVar1) {
                                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                        }
                                        uVar4 = *(uint64 *)
                                                 (*(int64 *)(lVar6 + 16) + 32 +
                                                 (int64)(int)uVar1 * 8);
                                        lVar6 = *(int64 *)(pStatics_e010 + 32);
                                        if ((lVar6 == null) ||
                                           (lVar6 = *(int64 *)(lVar6 + 96)) == null)
                                        throw; // [null/range check failed]
                                        if (*(uint32 *)(lVar6 + 24) <= jobType) {
                                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                        }
                                        lVar6 = *(int64 *)
                                                 (*(int64 *)(lVar6 + 16) + 32 + lVar9 * 8);
                                        if (lVar6 == null) throw; // [null/range check failed]
                                        uVar4 = GlobalData.GenerateRareLvColorText
                                                          (uVar4,*(uint32 *)(lVar6 + 16),0);
                                        uVar4 = String.Format("\n\n需要{0}以上",uVar4,0);
                                        uVar5 = String.Concat(uVar5,uVar4,0);
                                      }
                                      lVar6 = *(int64 *)(pStatics_e010 + 32);
                                      if ((lVar6 != null) &&
                                         (lVar6 = *(int64 *)(lVar6 + 96)) != null) {
                                        if (*(uint32 *)(lVar6 + 24) <= jobType) {
                                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                        }
                                        lVar6 = *(int64 *)
                                                 (*(int64 *)(lVar6 + 16) + 32 + lVar9 * 8);
                                        if (lVar6 != null) {
                                          if (*(int *)(lVar6 + 20) == -1) {
                                            return uVar5;
                                          }
                                          lVar6 = *(int64 *)
                                                   (pStatics_ef00 + 0x3d0);
                                          lVar7 = *(int64 *)
                                                   (pStatics_e010 + 32);
                                          if ((lVar7 != null) &&
                                             (lVar7 = *(int64 *)(lVar7 + 96)) != null) {
                                            if (*(uint32 *)(lVar7 + 24) <= jobType) {
                                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                            }
                                            lVar7 = *(int64 *)
                                                     (*(int64 *)(lVar7 + 16) + 32 + lVar9 * 8);
                                            if ((lVar7 != null) && (lVar6 != null)) {
                                              uVar1 = *(uint32 *)(lVar7 + 20);
                                              if (*(uint32 *)(lVar6 + 24) <= uVar1) {
                                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                              }
                                              uVar4 = *(uint64 *)
                                                       (*(int64 *)(lVar6 + 16) + 32 +
                                                       (int64)(int)uVar1 * 8);
                                              lVar6 = *(int64 *)
                                                       (pStatics_e010 + 32);
                                              if ((lVar6 != null) &&
                                                 (lVar6 = *(int64 *)(lVar6 + 96)) != null) {
                                                if (*(uint32 *)(lVar6 + 24) <= jobType) {
                                                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                                }
                                                lVar9 = *(int64 *)
                                                         (*(int64 *)(lVar6 + 16) + 32 + lVar9 * 8);
                                                if (lVar9 != null) {
                                                  uVar4 = GlobalData.GenerateRareLvColorText
                                                                    (uVar4,*(uint32 *)(lVar9 + 20),0
                                                                    );
                                                  uVar4 = String.Format("\n\n需要{0}以下",uVar4,0);
                                                  uVar5 = String.Concat(uVar5,uVar4,0);
                                                  return uVar5;
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

    // Token : 0x6001493
    // RVA   : 0x77FEF0   Offset: 0x77E6F0   Length: 0x608
    public string GetEffectForceSpeAddText(int jobType, int jobID)
    {
        var pStatics = *(int64*)(DAT_181d4e010 + 184);
        uint64
        ForceSettingController.GetEffectForceSpeAddText(int64 this,uint32 jobType,uint32 jobID)
        {
        char cVar1;
        uint32 uVar2;
        int iVar3;
        uint32 uVar4;
        int64 lVar5;
        int64 lVar6;
        uint64 uVar7;
        uint64 uVar8;
        int iVar9;
        uint64 uVar10;
        float local_48;
        float local_44 [7];
        iVar9 = 0;
        local_48 = 0.0;
        local_44[0] = 0.0;
        uVar7 = "";
        while( true ) {
          lVar5 = *(int64 *)(pStatics + 32);
          if ((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 96)) == null) break;
          if (*(uint32 *)(lVar5 + 24) <= jobType) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar5 = lVar5[jobType];
          if ((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 24)) == null) break;
          if (*(uint32 *)(lVar5 + 24) <= jobID) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar5 = lVar5[jobID];
          if ((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 40)) == null) break;
          if (*(int *)(lVar5 + 24) <= iVar9) {
            return uVar7;
          }
          cVar1 = FUN_1816fd990(uVar7,"",0);
          uVar10 = "/";
          if (cVar1) {
            uVar10 = "";
          }
          lVar5 = FUN_18046c100(0);
          if (lVar5 == null) break;
          lVar5 = *(int64 *)(lVar5 + 152);
          lVar6 = FUN_18046c100(0);
          if ((lVar6 == null) || (*(int64 *)(lVar6 + 96) == 0)) break;
          lVar6 = FUN_180002f80(*(int64 *)(lVar6 + 96),jobType,DAT_181d60df8);
          if ((lVar6 == null) || (*(int64 *)(lVar6 + 24) == 0)) break;
          lVar6 = FUN_180002f80(*(int64 *)(lVar6 + 24),jobID,DAT_181d60e78);
          if ((lVar6 == null) || (*(int64 *)(lVar6 + 40) == 0)) break;
          uVar2 = FUN_1800d6750(*(int64 *)(lVar6 + 40),iVar9,DAT_181d611f8);
          if (lVar5 == null) break;
          lVar5 = FUN_180002f80(lVar5,uVar2,DAT_181d610f8);
          if (lVar5 == null) break;
          uVar7 = String.Concat(uVar7,uVar10,*(uint64 *)(lVar5 + 16),0);
          if (((this.targetForce == null) ||
              (lVar5 = this.targetForce.forceJobSettingData) == null) ||
             (lVar5 = *(int64 *)(lVar5 + 24)) == null) break;
          lVar5 = FUN_180002f80(lVar5,jobType,DAT_181d51688);
          if (lVar5 == null) break;
          iVar3 = FUN_1800d6750(lVar5,jobID);
          if (iVar3 != -1) {
            lVar5 = FUN_18046c100(0);
            if ((lVar5 == null) || (*(int64 *)(lVar5 + 96) == 0)) break;
            lVar5 = FUN_180002f80(*(int64 *)(lVar5 + 96),jobType,DAT_181d60df8);
            if ((lVar5 == null) || (*(int64 *)(lVar5 + 24) == 0)) break;
            lVar5 = FUN_180002f80(*(int64 *)(lVar5 + 24),jobID,DAT_181d60e78);
            if ((lVar5 == null) || (*(int64 *)(lVar5 + 40) == 0)) break;
            uVar2 = FUN_1800d6750(*(int64 *)(lVar5 + 40),iVar9,DAT_181d611f8);
            lVar5 = FUN_18046c0a0(0);
            if (lVar5 == null) break;
            lVar5 = *(int64 *)(lVar5 + 32);
            if (((this.targetForce == null) ||
                (lVar6 = this.targetForce.forceJobSettingData) == null) ||
               (lVar6 = *(int64 *)(lVar6 + 24)) == null) break;
            lVar6 = FUN_180002f80(lVar6,jobType,DAT_181d51688);
            if (lVar6 == null) break;
            uVar4 = FUN_1800d6750(lVar6,jobID,DAT_181d68270);
            if (lVar5 == null) break;
            lVar5 = WorldData.GetHero(lVar5,uVar4,0);
            if (lVar5 == null) break;
            local_48 = (float)HeroData.GetForceJobSpeAddResult(lVar5,uVar2,0);
            uVar10 = *(uint64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x260);
            lVar5 = *(int64 *)(pStatics + 32);
            if ((lVar5 == null) || (lVar5 = *(int64 *)(lVar5 + 152)) == null) break;
            lVar5 = FUN_180002f80(lVar5,uVar2);
            if (lVar5 == null) break;
            if (*(char *)(lVar5 + 32) == false) {
              uVar8 = Single.ToString(&local_48,"f0");
            }
            else {
              local_44[0] = local_48 * 100.0;
              uVar8 = Single.ToString(local_44,"f0");
              uVar8 = String.Concat(uVar8,"%",0);
            }
            uVar7 = String.Concat(uVar7,uVar10,uVar8,"</color>",0);
          }
          iVar9 = iVar9 + 1;
        }
    }

    // Token : 0x6001494
    // RVA   : 0x77F6E0   Offset: 0x77DEE0   Length: 0x401
    public void ForceJobButtonClicked(GameObject buttonClicked)
    {
        var pStatics = *(int64*)(DAT_181d4e010 + 184);
        uint uVar1;
        long lVar2;
        long lVar3;
        uint uVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        ulong uVar8;
        ulong uVar9;
        ulong in_stack_ffffffffffffffc0;
        uint in_stack_ffffffffffffffc8;
        ulong in_stack_ffffffffffffffd0;
        if (buttonClicked != null) {
          lVar5 = GameObject.get_transform(buttonClicked,0);
          if (lVar5 != null) {
            lVar5 = FUN_180da0f00(lVar5,0);
            if (lVar5 != null) {
              lVar5 = Object.get_name(lVar5,0);
              lVar6 = FUN_1800d60b0(DAT_181d7c118,1);
              if (lVar6 != null) {
                if (lVar6.forceName == null) {
                  uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar7,0);
                }
                lVar6.defaultSkinID = 95;
                if (lVar5 != null) {
                  lVar5 = String.Split(lVar5,lVar6,0);
                  lVar6 = this.targetForce;
                  lVar2 = **(int64 **)(DAT_181d92370 + 184);
                  lVar3 = *(int64 *)(pStatics + 32);
                  if ((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 96), lVar5 != null)) {
                    if (*(int *)(lVar5 + 24) == 0) {
                      uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar7,0);
                    }
                    uVar4 = Int32.Parse(*(uint64 *)(lVar5 + 32),0);
                    if (lVar3 != null) {
                      if (*(uint32 *)(lVar3 + 24) <= uVar4) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar3 = lVar3[uVar4]
                      ;
                      if (lVar3 != null) {
                        uVar1 = *(uint32 *)(lVar3 + 16);
                        lVar3 = *(int64 *)(pStatics + 32);
                        if (lVar3 != null) {
                          lVar3 = *(int64 *)(lVar3 + 96);
                          if (*(int *)(lVar5 + 24) == 0) {
                            uVar7 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar7,0);
                          }
                          uVar4 = Int32.Parse(*(uint64 *)(lVar5 + 32),0);
                          if (lVar3 != null) {
                            if (*(uint32 *)(lVar3 + 24) <= uVar4) {
                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                            }
                            lVar5 = *(int64 *)
                                     (*(int64 *)(lVar3 + 16) + 32 + (int64)(int)uVar4 * 8);
                            if ((lVar5 != null) && (lVar6 != null)) {
                              uVar7 = ForceData.FindAllHero
                                                (lVar6,uVar1,*(uint32 *)(lVar5 + 20),1,1,
                                                 in_stack_ffffffffffffffc0 & 0xffffffffffffff00,
                                                 in_stack_ffffffffffffffc8 & 0xffffff00,
                                                 in_stack_ffffffffffffffd0 & 0xffffffffffffff00,0);
                              uVar8 = Component.get_gameObject(this,0);
                              lVar5 = GameObject.get_transform(buttonClicked,0);
                              if (lVar5 != null) {
                                lVar5 = FUN_180da0f00(lVar5,0);
                                if (lVar5 != null) {
                                  uVar9 = Object.get_name(lVar5,0);
                                  if (lVar2 != null) {
                                    ChooseController.ShowChoosePanel
                                              (lVar2,2,uVar7,uVar8,"ForceJobHeroChoosen",uVar9,0,0,0);
                                    plVar10 = (int64 *)Resources.Load("Sound/SoundEffect/Paper",0);
                                    plVar11 = (int64 *)0;
                                    if ((plVar10 != (int64 *)0) && (*plVar10 == DAT_181d8a228)) {
                                      plVar11 = plVar10;
                                    }
                                    NGUITools.PlaySound(plVar11,0);
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

    // Token : 0x6001495
    // RVA   : 0x77FCD0   Offset: 0x77E4D0   Length: 0x212
    public void ForceJobHeroChoosen(string param)
    {
        var pStatics = *(int64*)(DAT_181d92370 + 184);
        uint uVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        ulong uVar6;
        lVar3 = FUN_1800d60b0(DAT_181d7c118,1);
        if (lVar3 != null) {
          if (lVar3.forceName == null) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar6,0);
          }
          lVar3.defaultSkinID = 95;
          if (param != null) {
            lVar3 = String.Split(param,lVar3,0);
            if (lVar3 != null) {
              if (lVar3.forceName == null) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              uVar1 = Int32.Parse(lVar3.defaultSkinID,0);
              if (lVar3.forceName < 2) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              uVar2 = Int32.Parse(lVar3.forceStyle,0);
              lVar3 = this.targetForce;
              if ((*pStatics != 0) &&
                 (lVar4 = *(int64 *)(*pStatics + 72)) != null) {
                lVar4 = GameObject.GetComponent(lVar4,DAT_181d9fb20);
                if ((lVar4 != null) && (lVar3 != null)) {
                  ForceData.SetForceJob(lVar3,uVar1,uVar2,*(uint64 *)(lVar4 + 32),0);
                  ForceSettingController.RefreshForceJob(this,uVar1,uVar2,0);
                  plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/Armor",0);
                  plVar7 = (int64 *)0;
                  if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181d8a228)) {
                    plVar7 = plVar5;
                  }
                  NGUITools.PlaySound(plVar7,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6001496
    // RVA   : 0x77FAF0   Offset: 0x77E2F0   Length: 0x1D9
    public void ForceJobClearButtonClicked(GameObject buttonClicked)
    {
        uint uVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        ulong uVar6;
        if (buttonClicked != null) {
          lVar3 = GameObject.get_transform(buttonClicked,0);
          if (lVar3 != null) {
            lVar3 = FUN_180da0f00(lVar3,0);
            if (lVar3 != null) {
              lVar3 = Object.get_name(lVar3,0);
              lVar4 = FUN_1800d60b0(DAT_181d7c118,1);
              if (lVar4 != null) {
                if (*(int *)(lVar4 + 24) == 0) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                *(uint16 *)(lVar4 + 32) = 95;
                if (lVar3 != null) {
                  lVar3 = String.Split(lVar3,lVar4,0);
                  if (lVar3 != null) {
                    if (*(int *)(lVar3 + 24) == 0) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar6,0);
                    }
                    uVar1 = Int32.Parse(*(uint64 *)(lVar3 + 32),0);
                    if (*(uint32 *)(lVar3 + 24) < 2) {
                      uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar6,0);
                    }
                    uVar2 = Int32.Parse(*(uint64 *)(lVar3 + 40),0);
                    if (this.targetForce != null) {
                      ForceData.SetForceJob(this.targetForce,uVar1,uVar2,0,0);
                      ForceSettingController.RefreshForceJob(this,uVar1,uVar2,0);
                      plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/Woosh",0);
                      plVar7 = (int64 *)0;
                      if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181d8a228)) {
                        plVar7 = plVar5;
                      }
                      NGUITools.PlaySound(plVar7,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6001497
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
