// ============================================================
// Type  : BranchLeaderSettingTabController
// Token : 0x200019E
// ============================================================

public class BranchLeaderSettingTabController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000AEF
    public bool controlable;

    // Token: 0x4000AF0
    public AreaData targetArea;

    // Token: 0x4000AF1
    public ForceData targetForce;

    // Token: 0x4000AF2
    private bool inited;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000D4B
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private void Start()
    {
    }

    // Token : 0x6000D4C
    // RVA   : 0xCE7FA0   Offset: 0xCE67A0   Length: 0xE
    private void Update()
    {
        void FUN_180ce7fa0(int64 this)
        {
        if (!this.inited) {
          BranchLeaderSettingTabController.Init(this,0);
          return;
        }
    }

    // Token : 0x6000D4D
    // RVA   : 0xCE6C30   Offset: 0xCE5430   Length: 0x385
    public void Init()
    {
        var pStatics = *(int64*)(DAT_181d86270 + 184);
        float fVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar6;
        float extraout_var;
        this.inited = 1;
        lVar2 = Component.get_transform(this,0);
        if (lVar2 != null) {
          lVar2 = Transform.Find(lVar2,"AreaName",0);
          if (lVar2 != null) {
            uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
            if (this.targetArea != null) {
              uVar4 = String.Concat(this.targetArea.areaName,"分舵",0
                                    );
              LTLocalization.SetText(uVar3,uVar4,0);
              lVar2 = Component.get_transform(this,0);
              if (lVar2 != null) {
                lVar2 = Transform.Find(lVar2,"AreaIcon",0);
                if (lVar2 != null) {
                  lVar2 = Component.GetComponent(lVar2,DAT_181d6bc40);
                  if ((this.targetArea != null) && (*pStatics != 0)
                     ) {
                    uVar3 = TextureController.LoadAtlasSprite
                                      (*pStatics,"AreaIconAtlas",
                                       this.targetArea.spriteName,0);
                    if (lVar2 != null) {
                      Image.set_sprite(lVar2,uVar3,0);
                      lVar2 = Component.get_transform(this,0);
                      if (lVar2 != null) {
                        lVar2 = Transform.Find(lVar2,"AreaIcon",0);
                        if (lVar2 != null) {
                          plVar5 = (int64 *)Component.GetComponent(lVar2,DAT_181d6bc40);
                          if (plVar5 != (int64 *)0) {
                            (**(code **)(*plVar5 + 0x408))(plVar5,*(uint64 *)(*plVar5 + 0x410));
                            lVar2 = Component.get_transform(this,0);
                            if (lVar2 != null) {
                              lVar2 = Transform.Find(lVar2,"AreaIcon",0);
                              if (lVar2 != null) {
                                lVar2 = Component.GetComponent(lVar2,DAT_181d6c740);
                                lVar6 = Component.get_transform(this,0);
                                if (lVar6 != null) {
                                  lVar6 = Transform.Find(lVar6,"AreaIcon",0);
                                  if (lVar6 != null) {
                                    lVar6 = Component.GetComponent(lVar6,DAT_181d6c740);
                                    if (lVar6 != null) {
                                      RectTransform.get_sizeDelta(lVar6,0);
                                      lVar6 = Component.get_transform(this,0);
                                      if (lVar6 != null) {
                                        lVar6 = Transform.Find(lVar6,"AreaIcon",0);
                                        if (lVar6 != null) {
                                          lVar6 = Component.GetComponent(lVar6,DAT_181d6c740);
                                          if (lVar6 != null) {
                                            fVar1 = (float)RectTransform.get_sizeDelta(lVar6,0);
                                            if (lVar2 != null) {
                                              RectTransform.set_sizeDelta
                                                        (lVar2,CONCAT44((extraout_var * 70.0) / fVar1,
                                                                        0x428c0000),0);
                                              lVar2 = Component.get_transform(this,0);
                                              if (lVar2 != null) {
                                                lVar2 = Transform.Find(lVar2,"AreaIcon",0);
                                                if (lVar2 != null) {
                                                  lVar2 = Component.GetComponent(lVar2,DAT_181d6cb40);
                                                  if (lVar2 != null) {
                                                    *(uint64 *)(lVar2 + 24) =
                                                         this.targetArea;
                                                    il2cpp_internal();
                                                    BranchLeaderSettingTabController.RefreshHeroIcon
                                                              (this,0);
                                                    BranchLeaderSettingTabController.InitBuildSetting
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

    // Token : 0x6000D4E
    // RVA   : 0xCE6A90   Offset: 0xCE5290   Length: 0x194
    public void InitBuildSetting()
    {
        long lVar1;
        lVar1 = Component.get_transform(this,0);
        if (lVar1 != null) {
          lVar1 = Transform.Find(lVar1,"AutoBuildToggle",0);
          if (lVar1 != null) {
            lVar1 = Component.GetComponent(lVar1,DAT_181d6da40);
            if ((this.targetArea != null) && (lVar1 != null)) {
              Toggle.set_isOn(lVar1,this.targetArea.autoBuild,0);
              lVar1 = Component.get_transform(this,0);
              if (lVar1 != null) {
                lVar1 = Transform.Find(lVar1,"ResourceLimitDropdown",0);
                if (lVar1 != null) {
                  lVar1 = Component.GetComponent(lVar1,DAT_181d6b540);
                  if ((this.targetArea != null) && (lVar1 != null)) {
                    Dropdown.set_value(lVar1,(int)(this.targetArea.autoBuildResourceRateLimit /
                                                   0.2),0);
                    lVar1 = Component.get_transform(this,0);
                    if (lVar1 != null) {
                      lVar1 = Transform.Find(lVar1,"UpgradePriorityDropdown",0);
                      if (lVar1 != null) {
                        lVar1 = Component.GetComponent(lVar1,DAT_181d6b540);
                        if ((this.targetArea != null) && (lVar1 != null)) {
                          Dropdown.set_value(lVar1,this.targetArea.autoBuildPriority
                                              ,0);
                          BranchLeaderSettingTabController.RefreshBuildSetting(this,0);
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

    // Token : 0x6000D4F
    // RVA   : 0xCE66B0   Offset: 0xCE4EB0   Length: 0x9E
    public void AutoBuildToggleClicked()
    {
        long lVar1;
        long lVar2;
        lVar1 = this.targetArea;
        lVar2 = Component.get_transform(this,0);
        if (lVar2 != null) {
          lVar2 = Transform.Find(lVar2,"AutoBuildToggle",0);
          if (lVar2 != null) {
            lVar2 = Component.GetComponent(lVar2,DAT_181d6da40);
            if ((lVar2 != null) && (lVar1 != null)) {
              lVar1.autoBuild = *(uint8 *)(lVar2 + 0x118);
              BranchLeaderSettingTabController.RefreshBuildSetting(this,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000D50
    // RVA   : 0xCE7EF0   Offset: 0xCE66F0   Length: 0xA3
    public void ResourceLimitDropdownClicked()
    {
        long lVar1;
        long lVar2;
        lVar1 = this.targetArea;
        lVar2 = Component.get_transform(this,0);
        if (lVar2 != null) {
          lVar2 = Transform.Find(lVar2,"ResourceLimitDropdown",0);
          if (lVar2 != null) {
            lVar2 = Component.GetComponent(lVar2,DAT_181d6b540);
            if ((lVar2 != null) && (lVar1 != null)) {
              lVar1.autoBuildResourceRateLimit = (float)*(int *)(lVar2 + 0x120) * 0.2;
              return;
            }
          }
        }
    }

    // Token : 0x6000D51
    // RVA   : 0xCE7FB0   Offset: 0xCE67B0   Length: 0x94
    public void UpgradePriorityDropdownClicked()
    {
        long lVar1;
        long lVar2;
        lVar1 = this.targetArea;
        lVar2 = Component.get_transform(this,0);
        if (lVar2 != null) {
          lVar2 = Transform.Find(lVar2,"UpgradePriorityDropdown",0);
          if (lVar2 != null) {
            lVar2 = Component.GetComponent(lVar2,DAT_181d6b540);
            if ((lVar2 != null) && (lVar1 != null)) {
              lVar1.autoBuildPriority = *(uint32 *)(lVar2 + 0x120);
              return;
            }
          }
        }
    }

    // Token : 0x6000D52
    // RVA   : 0xCE6FC0   Offset: 0xCE57C0   Length: 0x193
    public void RefreshBuildSetting()
    {
        long lVar1;
        bool cVar2;
        bool cVar3;
        lVar1 = Component.get_transform(this,0);
        if (lVar1 != null) {
          lVar1 = Transform.Find(lVar1,"AutoBuildToggle",0);
          if (lVar1 != null) {
            lVar1 = Component.GetComponent(lVar1,DAT_181d6da40);
            if (lVar1 != null) {
              Selectable.set_interactable(lVar1,this.controlable,0);
              lVar1 = Component.get_transform(this,0);
              if (lVar1 != null) {
                lVar1 = Transform.Find(lVar1,"ResourceLimitDropdown",0);
                if (lVar1 != null) {
                  lVar1 = Component.GetComponent(lVar1,DAT_181d6b540);
                  cVar3 = false;
                  if (!this.controlable) {
                    cVar2 = false;
                  }
                  else {
                    if (this.targetArea == null) throw; // [null/range check failed]
                    cVar2 = this.targetArea.autoBuild;
                  }
                  if (lVar1 != null) {
                    Selectable.set_interactable(lVar1,cVar2,0);
                    lVar1 = Component.get_transform(this,0);
                    if (lVar1 != null) {
                      lVar1 = Transform.Find(lVar1,"UpgradePriorityDropdown",0);
                      if (lVar1 != null) {
                        lVar1 = Component.GetComponent(lVar1,DAT_181d6b540);
                        if (this.controlable) {
                          if (this.targetArea == null) throw; // [null/range check failed]
                          cVar3 = this.targetArea.autoBuild;
                        }
                        if (lVar1 != null) {
                          Selectable.set_interactable(lVar1,cVar3,0);
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

    // Token : 0x6000D53
    // RVA   : 0xCE7160   Offset: 0xCE5960   Length: 0xD86
    public void RefreshHeroIcon()
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_e188 = *(int64*)(DAT_181d4e188 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        ulong uVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        long lVar7;
        long lVar8;
        float fVar9;
        float[] local_res18 = new float[2];
        uint[] local_res20 = new uint[2];
        uint local_58;
        uint[] local_54 = new uint[3];
        ulong local_48;
        uint local_40;
        byte[] local_38 = new byte[32];
        lVar2 = Component.get_transform(this,0);
        if ((lVar2 != null) && (lVar2 = Transform.Find(lVar2,"HeroIcon",0)) != null) {
          uVar3 = Component.get_gameObject(lVar2);
          GlobalData.DeleteAllChild(uVar3);
          if (this.targetArea != null) {
            if (this.targetArea.branchLeaderID < 0) {
              lVar2 = Component.get_transform(this);
              if (((lVar2 != null) && (lVar2 = Transform.Find(lVar2,"HeroBack",0)) != null) &&
                 (lVar2 = Component.GetComponent(lVar2,DAT_181d6af40)) != null) {
                Selectable.set_interactable(lVar2,this.controlable,0);
                lVar2 = Component.get_transform(this,0);
                if (lVar2 != null) {
                  lVar2 = Transform.Find(lVar2,"ClearButton",0);
                  puVar5 = (uint64 *)Vector3.get_zero(local_38,0);
                  if (lVar2 != null) {
                    local_40 = *(uint32 *)(puVar5 + 1);
                    local_48 = *puVar5;
                    Transform.set_localScale(lVar2,&local_48,0);
                    lVar2 = Component.get_transform(this,0);
                    if (lVar2 != null) {
                      lVar2 = Transform.Find(lVar2,"Up",0);
                      puVar5 = (uint64 *)Vector3.get_zero(local_38,0);
                      if (lVar2 != null) {
                        local_40 = *(uint32 *)(puVar5 + 1);
                        local_48 = *puVar5;
                        Transform.set_localScale(lVar2,&local_48,0);
                        return;
                      }
                    }
                  }
                }
              }
            }
            else {
              lVar2 = Component.get_transform(this);
              if (((lVar2 != null) && (lVar2 = Transform.Find(lVar2,"HeroBack",0)) != null) &&
                 (lVar2 = Component.GetComponent(lVar2,DAT_181d6af40)) != null) {
                Selectable.set_interactable(lVar2,0,0);
                lVar2 = Component.get_transform(this,0);
                if ((lVar2 != null) && (lVar2 = Transform.Find(lVar2,"HeroIcon",0)) != null) {
                  uVar3 = Component.get_gameObject(lVar2,0);
                  if (*pStatics_e188 != 0) {
                    uVar1 = *(uint64 *)(*pStatics_e188 + 144);
                    lVar2 = GlobalData.AddChild(uVar3,uVar1,0);
                    if ((lVar2 != null) &&
                       (lVar4 = GameObject.GetComponent(lVar2,DAT_181d9fb20)) != null) {
                      *(uint8 *)(lVar4 + 88) = 1;
                      lVar4 = GameObject.GetComponent(lVar2,DAT_181d9fb20);
                      if ((((*pStatics_df90 != 0) &&
                           (this.targetArea != null)) &&
                          (lVar7 = *(int64 *)(*pStatics_df90 + 32), lVar7 != null
                          )) && (uVar3 = WorldData.GetHero(lVar7,*(uint32 *)
                                                                   (this.targetArea + 0x118)
                                                            ,0), lVar4 != null)) {
                        *(uint64 *)(lVar4 + 32) = uVar3;
                        lVar4 = GameObject.GetComponent(lVar2);
                        if (lVar4 != null) {
                          *(uint32 *)(lVar4 + 24) = 0;
                          if (!this.controlable) {
                            lVar4 = Component.get_transform(this);
                            if (lVar4 != null) {
                              lVar4 = Transform.Find(lVar4,"ClearButton",0);
                              puVar5 = (uint64 *)Vector3.get_zero(local_38,0);
                              if (lVar4 != null) {
                                local_40 = *(uint32 *)(puVar5 + 1);
                                local_48 = *puVar5;
                                Transform.set_localScale(lVar4,&local_48,0);
        LAB_180ce7796:
                                lVar4 = Component.get_transform(this,0);
                                if (lVar4 != null) {
                                  lVar4 = Transform.Find(lVar4,"Up",0);
                                  puVar5 = (uint64 *)Vector3.get_one(local_38,0);
                                  if (lVar4 != null) {
                                    local_40 = *(uint32 *)(puVar5 + 1);
                                    local_48 = *puVar5;
                                    Transform.set_localScale(lVar4,&local_48,0);
                                    lVar4 = Component.get_transform(this,0);
                                    if ((lVar4 != null) &&
                                       (lVar4 = Transform.Find(lVar4,"Up",0)) != null) {
                                      lVar4 = Component.GetComponent(lVar4,DAT_181d6ccc0);
                                      plVar6 = (int64 *)FUN_1800d60b0(DAT_181d7f180,7);
                                      lVar7 = GameObject.GetComponent(lVar2,DAT_181d9fb20);
                                      if ((lVar7 != null) && (*(int64 *)(lVar7 + 32) != 0)) {
                                        fVar9 = (float)HeroData.GetTotalAttir
                                                                 (*(int64 *)(lVar7 + 32),0);
                                        lVar7 = *(int64 *)(pStatics_ef00 + 0x490)
                                        ;
                                        if (lVar7 != null) {
                                          local_res18[0] =
                                               (fVar9 * 5.0) / ((float)*(int *)(lVar7 + 24) * 10.0);
                                          lVar7 = Single.ToString(local_res18,"+0;-0;0",0);
                                          if (plVar6 != (int64 *)0) {
                                            if ((lVar7 != null) &&
                                               (lVar8 = il2cpp_internal(lVar7,*(uint64 *)
                                                                                   (*plVar6 + 64)),
                                               lVar8 == null)) {
                                              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                              FUN_1800d65f0(uVar3,0);
                                            }
                                            if ((int)plVar6[3] == 0) {
                                              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                              FUN_1800d65f0(uVar3,0);
                                            }
                                            plVar6[4] = lVar7;
                                            il2cpp_internal(plVar6 + 4,lVar7);
                                            lVar7 = GameObject.GetComponent(lVar2,DAT_181d9fb20);
                                            if ((lVar7 != null) && (*(int64 *)(lVar7 + 32) != 0)) {
                                              fVar9 = (float)HeroData.GetTotalAttir
                                                                       (*(int64 *)(lVar7 + 32),0);
                                              lVar7 = *(int64 *)
                                                       (pStatics_ef00 + 0x490);
                                              if (lVar7 != null) {
                                                local_res18[0] =
                                                     fVar9 / ((float)*(int *)(lVar7 + 24) * 10.0);
                                                lVar7 = Single.ToString(local_res18,"+0;-0;0",0);
                                                if ((lVar7 != null) &&
                                                   (lVar8 = il2cpp_internal(lVar7,*(uint64 *)
                                                                                       (*plVar6 + 64)),
                                                   lVar8 == null)) {
                                                  uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                  FUN_1800d65f0(uVar3,0);
                                                }
                                                if (*(uint32 *)(plVar6 + 3) < 2) {
                                                  uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                  FUN_1800d65f0(uVar3,0);
                                                }
                                                plVar6[5] = lVar7;
                                                il2cpp_internal(plVar6 + 5,lVar7);
                                                lVar7 = GameObject.GetComponent(lVar2,DAT_181d9fb20);
                                                if ((lVar7 != null) && (*(int64 *)(lVar7 + 32) != 0)) {
                                                  fVar9 = (float)HeroData.GetTotalFightSkill
                                                                           (*(int64 *)(lVar7 + 32),0)
                                                  ;
                                                  lVar7 = *(int64 *)
                                                           (pStatics_ef00 + 0x498);
                                                  if (lVar7 != null) {
                                                    local_res18[0] =
                                                         fVar9 / ((float)*(int *)(lVar7 + 24) * 10.0);
                                                    lVar7 = Single.ToString(local_res18,"+0;-0;0",0);
                                                    if ((lVar7 != null) &&
                                                       (lVar8 = il2cpp_internal(lVar7,*(uint64 *)
                                                                                           (*plVar6 + 64
                                                                                           )), lVar8 == null)
                                                       ) {
                                                      uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                      FUN_1800d65f0(uVar3,0);
                                                    }
                                                    if (*(uint32 *)(plVar6 + 3) < 3) {
                                                      uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                      FUN_1800d65f0(uVar3,0);
                                                    }
                                                    plVar6[6] = lVar7;
                                                    il2cpp_internal(plVar6 + 6,lVar7);
                                                    lVar7 = GameObject.GetComponent(lVar2,DAT_181d9fb20);
                                                    if ((lVar7 != null) && (*(int64 *)(lVar7 + 32) != 0)
                                                       ) {
                                                      fVar9 = (float)HeroData.GetTotalLivingSkill
                                                                               (*(int64 *)
                                                                                 (lVar7 + 32),0);
                                                      lVar7 = *(int64 *)
                                                               (pStatics_ef00 +
                                                               0x4a8);
                                                      if (lVar7 != null) {
                                                        local_res18[0] =
                                                             (fVar9 * 0.25) /
                                                             (float)*(int *)(lVar7 + 24);
                                                        lVar7 = Single.ToString(local_res18,"+0;-0;0"
                                                                                 ,0);
                                                        if ((lVar7 != null) &&
                                                           (lVar8 = il2cpp_internal(lVar7,*(uint64
                                                                                                *)(*plVar6
                                                                                                  + 64))
                                                           , lVar8 == null)) {
                                                          uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar3,0);
                                                        }
                                                        if (*(uint32 *)(plVar6 + 3) < 4) {
                                                          uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar3,0);
                                                        }
                                                        plVar6[7] = lVar7;
                                                        il2cpp_internal(plVar6 + 7,lVar7);
                                                        lVar7 = GameObject.GetComponent
                                                                          (lVar2,DAT_181d9fb20);
                                                        if ((lVar7 != null) &&
                                                           (*(int64 *)(lVar7 + 32) != 0)) {
                                                          local_res20[0] =
                                                               HeroData.GetTotalAttir
                                                                         (*(int64 *)(lVar7 + 32),0);
                                                          lVar7 = il2cpp_value_box(DAT_181d7d0b8,
                                                                                   local_res20);
                                                          if ((lVar7 != null) &&
                                                             (lVar8 = il2cpp_internal(lVar7,*(
                                                        uint64 *)(*plVar6 + 64)), lVar8 == null)) {
                                                          uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar3,0);
                                                        }
                                                        if (*(uint32 *)(plVar6 + 3) < 5) {
                                                          uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar3,0);
                                                        }
                                                        plVar6[8] = lVar7;
                                                        il2cpp_internal(plVar6 + 8,lVar7);
                                                        lVar7 = GameObject.GetComponent
                                                                          (lVar2,DAT_181d9fb20);
                                                        if ((lVar7 != null) &&
                                                           (*(int64 *)(lVar7 + 32) != 0)) {
                                                          local_58 = HeroData.GetTotalFightSkill
                                                                               (*(int64 *)
                                                                                 (lVar7 + 32),0);
                                                          lVar7 = il2cpp_value_box(DAT_181d7d0b8,&local_58
                                                                                  );
                                                          if ((lVar7 != null) &&
                                                             (lVar8 = il2cpp_internal(lVar7,*(
                                                        uint64 *)(*plVar6 + 64)), lVar8 == null)) {
                                                          uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar3,0);
                                                        }
                                                        if (*(uint32 *)(plVar6 + 3) < 6) {
                                                          uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar3,0);
                                                        }
                                                        plVar6[9] = lVar7;
                                                        il2cpp_internal(plVar6 + 9,lVar7);
                                                        lVar2 = GameObject.GetComponent
                                                                          (lVar2,DAT_181d9fb20);
                                                        if ((lVar2 != null) &&
                                                           (*(int64 *)(lVar2 + 32) != 0)) {
                                                          local_54[0] = HeroData.GetTotalLivingSkill
                                                                                  (*(int64 *)
                                                                                    (lVar2 + 32),0);
                                                          lVar2 = il2cpp_value_box(DAT_181d7d0b8,local_54)
                                                          ;
                                                          if ((lVar2 != null) &&
                                                             (lVar7 = il2cpp_internal(lVar2,*(
                                                        uint64 *)(*plVar6 + 64)), lVar7 == null)) {
                                                          uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar3,0);
                                                        }
                                                        if (*(uint32 *)(plVar6 + 3) < 7) {
                                                          uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                          FUN_1800d65f0(uVar3,0);
                                                        }
                                                        plVar6[10] = lVar2;
                                                        il2cpp_internal(plVar6 + 10,lVar2);
                                                        uVar3 = String.Format("舵主属性总和{4}\n—每月人口{0}\n—每月民心{1}\n舵主武学总和{5}\n—每月治安{2}\n—每月防御{2}\n舵主技艺总和{6}\n—全城生产效率{3}%",plVar6,0);
                                                        if (lVar4 != null) {
                                                          *(uint64 *)(lVar4 + 24) = uVar3;
                                                          il2cpp_internal((uint64 *)(lVar4 + 24)
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
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                            }
                          }
                          else {
                            lVar4 = Component.get_transform(this);
                            if (lVar4 != null) {
                              lVar4 = Transform.Find(lVar4,"ClearButton",0);
                              puVar5 = (uint64 *)Vector3.get_one(local_38,0);
                              if (lVar4 != null) {
                                local_40 = *(uint32 *)(puVar5 + 1);
                                local_48 = *puVar5;
                                Transform.set_localScale(lVar4,&local_48,0);
                                lVar4 = Component.get_transform(this,0);
                                if ((lVar4 != null) &&
                                   (lVar4 = Transform.Find(lVar4,"ClearButton",0)) != null) {
                                  lVar4 = Component.GetComponent(lVar4,DAT_181d6af40);
                                  lVar7 = FUN_18046c0a0(0);
                                  if (((lVar7 != null) && (this.targetArea != null)) &&
                                     ((*(int64 *)(lVar7 + 32) != 0 &&
                                      ((lVar7 = WorldData.GetHero(*(int64 *)(lVar7 + 32),
                                                                   *(uint32 *)
                                                                    (this.targetArea + 0x118
                                                                    ),0), lVar7 != null && (lVar4 != null))))))
                                  {
                                    Selectable.set_interactable(lVar4,*(int *)(lVar7 + 152) < 1,0);
                                    lVar4 = Component.get_transform(this,0);
                                    if ((lVar4 != null) &&
                                       (lVar4 = Transform.Find(lVar4,"ClearButton",0)) != null) {
                                      lVar4 = Component.GetComponent(lVar4,DAT_181d6ccc0);
                                      lVar7 = FUN_18046c0a0(0);
                                      if ((((lVar7 != null) && (this.targetArea != null)) &&
                                          (*(int64 *)(lVar7 + 32) != 0)) &&
                                         (lVar7 = WorldData.GetHero(*(int64 *)(lVar7 + 32),
                                                                     *(uint32 *)
                                                                      (this.targetArea +
                                                                      0x118),0), lVar7 != null)) {
                                        uVar3 = "撤除职位";
                                        if (0 < *(int *)(lVar7 + 152)) {
                                          lVar7 = FUN_18046c0a0(0);
                                          if (((lVar7 == null) || (this.targetArea == null)) ||
                                             ((*(int64 *)(lVar7 + 32) == 0 ||
                                              (lVar7 = WorldData.GetHero(*(int64 *)(lVar7 + 32),
                                                                          *(uint32 *)
                                                                           (this.targetArea
                                                                           + 0x118),0), lVar7 == null)))) {
                          // WARNING: Subroutine does not return
                                            FUN_1800d6620();
                                          }
                                          local_res20[0] = *(uint32 *)(lVar7 + 152);
                                          uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
                                          uVar3 = String.Format("撤除职位\n冷却{0}天",uVar3,0);
                                        }
                                        if (lVar4 != null) {
                                          *(uint64 *)(lVar4 + 24) = uVar3;
                                          goto LAB_180ce7796;
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

    // Token : 0x6000D54
    // RVA   : 0xCE6870   Offset: 0xCE5070   Length: 0x163
    public void ChooseButtonClicked()
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        uint in_stack_ffffffffffffffd8;
        ulong in_stack_ffffffffffffffe0;
        lVar1 = **(int64 **)(DAT_181d92370 + 184);
        if (this.targetForce != null) {
          uVar2 = ForceData.FindAllHero
                            (this.targetForce,2,4,1,1,1,
                             in_stack_ffffffffffffffd8 & 0xffffff00,
                             in_stack_ffffffffffffffe0 & 0xffffffffffffff00,0);
          uVar3 = Component.get_gameObject(this,0);
          if (lVar1 != null) {
            ChooseController.ShowChoosePanel(lVar1,2,uVar2,uVar3,"BranchLeaderChoosen",0,0,0,0);
            plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/Paper",0);
            plVar5 = (int64 *)0;
            if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
              plVar5 = plVar4;
            }
            NGUITools.PlaySound(plVar5,0);
            return;
          }
        }
    }

    // Token : 0x6000D55
    // RVA   : 0xCE6750   Offset: 0xCE4F50   Length: 0x11D
    public void BranchLeaderChoosen()
    {
        var pStatics = *(int64*)(DAT_181d92370 + 184);
        long lVar1;
        long lVar2;
        lVar1 = this.targetArea;
        if ((*pStatics != 0) &&
           (lVar2 = *(int64 *)(*pStatics + 72)) != null) {
          lVar2 = GameObject.GetComponent(lVar2,DAT_181d9fb20);
          if ((lVar2 != null) && (lVar1 != null)) {
            AreaData.SetBranchLeader(lVar1,*(uint64 *)(lVar2 + 32),0);
            BranchLeaderSettingTabController.RefreshHeroIcon(this,0);
            plVar3 = (int64 *)Resources.Load("Sound/SoundEffect/Armor",0);
            plVar4 = (int64 *)0;
            if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d8a228)) {
              plVar4 = plVar3;
            }
            NGUITools.PlaySound(plVar4,0);
            return;
          }
        }
    }

    // Token : 0x6000D56
    // RVA   : 0xCE69E0   Offset: 0xCE51E0   Length: 0xAF
    public void ClearButtonClicked()
    {
        if (this.targetArea != null) {
          AreaData.SetBranchLeader(this.targetArea,0,0);
          BranchLeaderSettingTabController.RefreshHeroIcon(this,0);
          plVar1 = (int64 *)Resources.Load("Sound/SoundEffect/Woosh",0);
          plVar2 = (int64 *)0;
          if ((plVar1 != (int64 *)0) && (*plVar1 == DAT_181d8a228)) {
            plVar2 = plVar1;
          }
          NGUITools.PlaySound(plVar2,0);
          return;
        }
    }

    // Token : 0x6000D57
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
