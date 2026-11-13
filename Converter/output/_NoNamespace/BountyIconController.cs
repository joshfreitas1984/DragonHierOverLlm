// ============================================================
// Type  : BountyIconController
// Token : 0x20001A4
// ============================================================

public class BountyIconController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000B84
    public MissionData bountyData;

    // Token: 0x4000B85
    public bool inited;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000D77
    // RVA   : 0x9F41F0   Offset: 0x9F2FF0   Length: 0xCC8
    private void Update()
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        uint uVar1;
        int iVar2;
        uint uVar3;
        bool cVar4;
        long lVar5;
        ulong uVar6;
        ulong uVar7;
        ulong uVar8;
        long lVar9;
        ulong uVar10;
        ulong uVar12;
        int[] local_res8 = new int[2];
        if (this.inited) {
          return;
        }
        this.inited = 1;
        lVar5 = Component.get_transform(this,0);
        if ((lVar5 != null) && (lVar5 = Transform.Find(lVar5,"Title",0)) != null) {
          uVar6 = Component.GetComponent(lVar5,DAT_181e79538);
          if (this.bountyData != null) {
            uVar7 = this.bountyData.name;
            LTLocalization.SetText(uVar6,uVar7,0);
            lVar5 = Component.get_transform(this,0);
            if ((lVar5 != null) && (lVar5 = Transform.Find(lVar5,"Describe",0)) != null) {
              uVar6 = Component.GetComponent(lVar5,DAT_181e79538);
              if (this.bountyData != null) {
                uVar7 = MissionData.GetMissionBaseDescribe(this.bountyData,1,0);
                LTLocalization.SetText(uVar6,uVar7,0);
                if ((this.bountyData != null) &&
                   (lVar5 = this.bountyData.missionTargetDatas) != null) {
                  if (lVar5.name == null) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar5 = *(int64 *)(lVar5.id + 32);
                  if (lVar5 != null) {
                    if (0.0 < lVar5.missionSourceType) {
                      lVar5 = Component.get_transform(this,0);
                      if ((lVar5 == null) || (lVar5 = Transform.Find(lVar5,"Describe",0)) == null) {
        LAB_1809f4ead:
                          // WARNING: Subroutine does not return
                        FUN_1801e0300();
                      }
                      uVar6 = Component.GetComponent(lVar5,DAT_181e79538);
                      if ((this.bountyData == null) ||
                         (lVar5 = this.bountyData.missionTargetDatas) == null)
                      goto LAB_1809f4ead;
                      if (lVar5.name == null) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar5 = *(int64 *)(lVar5.id + 32);
                      if (lVar5 == null) goto LAB_1809f4ead;
                      uVar1 = lVar5.minForceLv;
                      uVar7 = GlobalData.GetRequireTypeText(uVar1,0);
                      if ((this.bountyData == null) ||
                         (lVar5 = this.bountyData.missionTargetDatas) == null)
                      goto LAB_1809f4ead;
                      if (lVar5.name == null) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar5 = *(int64 *)(lVar5.id + 32);
                      if (lVar5 == null) goto LAB_1809f4ead;
                      local_res8[0] = lVar5.missionSourceType;
                      uVar8 = il2cpp_value_box(DAT_181e82730,local_res8);
                      lVar5 = FUN_180210a70(0);
                      if ((this.bountyData == null) ||
                         (lVar9 = this.bountyData.missionTargetDatas) == null)
                      goto LAB_1809f4ead;
                      if (*(int *)(lVar9 + 24) == 0) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar9 = *(int64 *)(*(int64 *)(lVar9 + 16) + 32);
                      if (lVar9 == null) goto LAB_1809f4ead;
                      uVar1 = *(uint32 *)(lVar9 + 72);
                      if ((this.bountyData == null) ||
                         (lVar9 = this.bountyData.missionTargetDatas) == null)
                      goto LAB_1809f4ead;
                      if (*(int *)(lVar9 + 24) == 0) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar9 = *(int64 *)(*(int64 *)(lVar9 + 16) + 32);
                      if ((lVar9 == null) || (lVar5 == null)) goto LAB_1809f4ead;
                      cVar4 = PlotController.CheckMeetRequire
                                        (lVar5,uVar1,*(uint32 *)(lVar9 + 76),0,0);
                      uVar10 = "\n需要:{2}{0}{1}</color>";
                      if (!cVar4) {
                        lVar5 = FUN_180210a70(0);
                        if ((this.bountyData == null) ||
                           (lVar9 = this.bountyData.missionTargetDatas) == null)
                        throw; // [null/range check failed]
                        if (*(int *)(lVar9 + 24) == 0) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar9 = *(int64 *)(*(int64 *)(lVar9 + 16) + 32);
                        if (lVar9 == null) throw; // [null/range check failed]
                        uVar1 = *(uint32 *)(lVar9 + 72);
                        if ((this.bountyData == null) ||
                           (lVar9 = this.bountyData.missionTargetDatas) == null)
                        throw; // [null/range check failed]
                        if (*(int *)(lVar9 + 24) == 0) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar9 = *(int64 *)(*(int64 *)(lVar9 + 16) + 32);
                        if ((lVar9 == null) || (lVar5 == null)) throw; // [null/range check failed]
                        cVar4 = PlotController.CheckMeetRequire
                                          (lVar5,uVar1,*(uint32 *)(lVar9 + 76),1,0);
                        if (!cVar4) {
                          uVar12 = *(uint64 *)(pStatics + 0x2d8);
                        }
                        else {
                          uVar12 = *(uint64 *)(pStatics + 0x250);
                        }
                      }
                      else {
                        uVar12 = *(uint64 *)(pStatics + 0x270);
                      }
                      uVar7 = String.Format(uVar10,uVar7,uVar8,uVar12,0);
                      LTLocalization.AddText(uVar6,uVar7,0);
                    }
                    if ((this.bountyData != null) &&
                       (lVar5 = this.bountyData.missionTargetDatas) != null) {
                      if (lVar5.name == null) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar5 = *(int64 *)(lVar5.id + 32);
                      if ((lVar5 = lVar5?.treasureLv) != null) {
                        if (lVar5.name == null) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar5 = *(int64 *)(lVar5.id + 32);
                        if (lVar5 != null) {
                          if (lVar5.id != null) {
                            lVar5 = Component.get_transform(this,0);
                            if ((lVar5 == null) ||
                               (lVar5 = Transform.Find(lVar5,"Describe",0)) == null)
                            throw; // [null/range check failed]
                            uVar6 = Component.GetComponent(lVar5,DAT_181e79538);
                            if (this.bountyData == null) throw; // [null/range check failed]
                            uVar7 = MissionData.GetMissionTargetDescribe
                                              (this.bountyData,1,0);
                            uVar7 = String.Concat("\n\n目标:\n",uVar7,0);
                            LTLocalization.AddText(uVar6,uVar7,0);
                          }
                          lVar5 = Component.get_transform(this,0);
                          if ((lVar5 != null) && (lVar5 = Transform.Find(lVar5,"Difficulty",0)) != null
                             ) {
                            uVar6 = Component.GetComponent(lVar5,DAT_181e79538);
                            if (this.bountyData != null) {
                              uVar1 = this.bountyData.difficulty;
                              uVar7 = GlobalData.GetDifficultyStarString(uVar1,0);
                              uVar7 = String.Format("难度:{0}",uVar7,0);
                              LTLocalization.SetText(uVar6,uVar7,0);
                              lVar5 = Component.get_transform(this,0);
                              if ((lVar5 != null) &&
                                 (lVar5 = Transform.Find(lVar5,"Money",0)) != null) {
                                uVar6 = Component.GetComponent(lVar5,DAT_181e79538);
                                if (this.bountyData != null) {
                                  iVar2 = this.bountyData.missionMoneyReward;
                                  uVar7 = "";
                                  if (iVar2 != 0) {
                                    local_res8[0] = iVar2;
                                    uVar7 = il2cpp_value_box(DAT_181e60808,local_res8);
                                    uVar7 = String.Format("银两:{0}",uVar7,0);
                                  }
                                  LTLocalization.SetText(uVar6,uVar7,0);
                                  if (this.bountyData != null) {
                                    if (this.bountyData.missionFameReward == null.0) {
                                      lVar5 = Component.get_transform(this,0);
                                      if ((lVar5 == null) ||
                                         (lVar5 = Transform.Find(lVar5,"Fame",0)) == null)
                                      throw; // [null/range check failed]
                                      uVar7 = Component.GetComponent(lVar5,DAT_181e79538);
                                      uVar6 = "";
                                      if (((*(byte *)(DAT_181e64c70 + 0x133) & 4) != 0) &&
                                         (*(int *)(DAT_181e64c70 + 224) == 0)) {
                                        il2cpp_runtime_class_init();
                                        uVar6 = "";
                                      }
                                    }
                                    else {
                                      lVar5 = Component.get_transform(this,0);
                                      if ((lVar5 == null) ||
                                         (lVar5 = Transform.Find(lVar5,"Fame",0)) == null)
                                      throw; // [null/range check failed]
                                      uVar7 = Component.GetComponent(lVar5,DAT_181e79538);
                                      uVar6 = "{0}:{1}";
                                      lVar5 = this.bountyData;
                                      if (lVar5 == null) throw; // [null/range check failed]
                                      lVar9 = "声望";
                                      if (lVar5.missionSourceType == 3) {
                                        if (((*(byte *)(DAT_181e6ad70 + 0x133) & 4) != 0) &&
                                           (*(int *)(DAT_181e6ad70 + 224) == 0)) {
                                          il2cpp_runtime_class_init(DAT_181e6ad70);
                                          lVar5 = this.bountyData;
                                        }
                                        lVar9 = MissionData.MissionBountyTypeRewardType;
                                        if ((lVar5 == null) || (lVar9 == null)) throw; // [null/range check failed]
                                        uVar3 = lVar5.missionBountyType;
                                        if (*(uint32 *)(lVar9 + 24) <= uVar3) {
                                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                          lVar5 = this.bountyData;
                                        }
                                        lVar9 = *(int64 *)
                                                 (*(int64 *)(lVar9 + 16) + 32 +
                                                 (int64)(int)uVar3 * 8);
                                        if (lVar5 == null) throw; // [null/range check failed]
                                      }
                                      uVar8 = "#SourceHeroName#";
                                      uVar10 = "";
                                      if (0 < lVar5.sourceHeroID) {
                                        lVar5 = FUN_1802106e0(0);
                                        if ((((lVar5 == null) || (this.bountyData == null)) ||
                                            (lVar5.speMissionID == null)) ||
                                           (lVar5 = WorldData.GetHero(lVar5.speMissionID,
                                                                       *(uint32 *)
                                                                        (this.bountyData +
                                                                        84),0), lVar5 == null))
                                        throw; // [null/range check failed]
                                        uVar10 = lVar5.missionHideTargetPlaceString;
                                      }
                                      if (lVar9 == null) throw; // [null/range check failed]
                                      lVar5 = String.Replace(lVar9,uVar8,uVar10,0);
                                      uVar8 = "#SourceForceName#";
                                      if (this.bountyData == null) throw; // [null/range check failed]
                                      uVar10 = "本门";
                                      if (this.bountyData.sourceForceID != -1) {
                                        lVar9 = FUN_1802106e0(0);
                                        if (((lVar9 == null) || (this.bountyData == null)) ||
                                           ((*(int64 *)(lVar9 + 32) == 0 ||
                                            (lVar9 = WorldData.GetForce(*(int64 *)(lVar9 + 32),
                                                                         *(uint32 *)
                                                                          (this.bountyData +
                                                                          88),0), lVar9 == null))))
                                        throw; // [null/range check failed]
                                        uVar10 = ForceData.GetForceName(lVar9,1,0);
                                      }
                                      if (lVar5 == null) {
        LAB_1809f4ea7:
                          // WARNING: Subroutine does not return
                                        FUN_1801e0300();
                                      }
                                      uVar8 = String.Replace(lVar5,uVar8,uVar10,0);
                                      if (this.bountyData == null) goto LAB_1809f4ea7;
                                      local_res8[0] = this.bountyData.missionFameReward;
                                      uVar10 = il2cpp_value_box(DAT_181e82730,local_res8);
                                      uVar6 = String.Format(uVar6,uVar8,uVar10,0);
                                    }
                                    LTLocalization.SetText(uVar7,uVar6,0);
                                    lVar5 = Component.get_transform(this,0);
                                    if ((lVar5 != null) &&
                                       (lVar5 = Transform.Find(lVar5,"Time",0)) != null) {
                                      uVar6 = Component.GetComponent(lVar5,DAT_181e79538);
                                      if (this.bountyData != null) {
                                        piVar11 = &this.bountyData.leftTime;
                                        uVar7 = "";
                                        if (0 < this.bountyData.leftTime) {
                                          uVar7 = Int32.ToString(piVar11,0);
                                          uVar7 = String.Format("限时{0}天",uVar7,0);
                                        }
                                        LTLocalization.SetText(uVar6,uVar7,0);
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

    // Token : 0x6000D78
    // RVA   : 0x9F3DB0   Offset: 0x9F2BB0   Length: 0x43A
    public void OnClick()
    {
        var pStatics_3370 = *(int64*)(DAT_181e93370 + 184);
        int iVar1;
        int iVar2;
        long lVar3;
        ulong uVar4;
        if ((GameController._instance != null) &&
           (lVar3 = GameController._instance.worldData) != null) {
          lVar3 = WorldData.Player(lVar3,0);
          if (lVar3 != null) {
            iVar1 = HeroData.GetBountyMissionNum(lVar3,0);
            if ((GameController._instance != null) &&
               (lVar3 = GameController._instance.worldData) != null) {
              lVar3 = WorldData.Player(lVar3,0);
              if (lVar3 != null) {
                iVar2 = HeroData.GetMaxBountyMissionNum(lVar3,0);
                if (iVar1 < iVar2) {
                  if (GameController._instance != null) {
                    GameController.GetFullMission
                              (GameController._instance,this.bountyData,0);

                    if (((lVar3 = *(int64 *)(*(int64 *)(DAT_181e942d8 + 184) + 8)?.cityAreaID) != null) &&
                       (lVar3 = lVar3.Areas) != null) {
                      FUN_181665e90(lVar3,this.bountyData,DAT_181e76ce0);
                      uVar4 = Component.get_gameObject(this,0);
                      Object.Destroy(uVar4,0);
                      if (*pStatics_3370 != 0) {
                        BountyUIController.FreshBountyNum(*pStatics_3370,0);
                        return;
                      }
                    }
                  }
                }
                else {
                  if (GameController._instance != null) {
                    GameController.ShowTextOnMouse(GameController._instance,"无法领取更多委托",0)
                    ;
                    plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
                    plVar6 = (int64 *)0;
                    if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181e8f4a0)) {
                      plVar6 = plVar5;
                    }
                    NGUITools.PlaySound(plVar6,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000D79
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
