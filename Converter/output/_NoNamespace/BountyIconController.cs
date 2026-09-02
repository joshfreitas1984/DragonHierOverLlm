// ============================================================
// Type  : BountyIconController
// Token : 0x200019C
// ============================================================

public class BountyIconController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000AE7
    public MissionData bountyData;

    // Token: 0x4000AE8
    public bool inited;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000D40
    // RVA   : 0xCE4F20   Offset: 0xCE3720   Length: 0xB9D
    private void Update()
    {
        var pStatics = *(int64*)(DAT_181d4ef00 + 184);
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
          uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
          if (this.bountyData != null) {
            LTLocalization.SetText(uVar6,this.bountyData.name,0);
            lVar5 = Component.get_transform(this,0);
            if ((lVar5 != null) && (lVar5 = Transform.Find(lVar5,"Describe",0)) != null) {
              uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
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
        LAB_180ce5ab2:
                          // WARNING: Subroutine does not return
                        FUN_1800d6620();
                      }
                      uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
                      if ((this.bountyData == null) ||
                         (lVar5 = this.bountyData.missionTargetDatas) == null)
                      goto LAB_180ce5ab2;
                      if (lVar5.name == null) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar5 = *(int64 *)(lVar5.id + 32);
                      if (lVar5 == null) goto LAB_180ce5ab2;
                      uVar1 = lVar5.minForceLv;
                      uVar7 = GlobalData.GetRequireTypeText(uVar1,0);
                      if ((this.bountyData == null) ||
                         (lVar5 = this.bountyData.missionTargetDatas) == null)
                      goto LAB_180ce5ab2;
                      if (lVar5.name == null) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar5 = *(int64 *)(lVar5.id + 32);
                      if (lVar5 == null) goto LAB_180ce5ab2;
                      local_res8[0] = lVar5.missionSourceType;
                      uVar8 = il2cpp_value_box(DAT_181d7d0b8,local_res8);
                      lVar5 = FUN_18046c440(0);
                      if ((this.bountyData == null) ||
                         (lVar9 = this.bountyData.missionTargetDatas) == null)
                      goto LAB_180ce5ab2;
                      if (*(int *)(lVar9 + 24) == 0) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar9 = *(int64 *)(*(int64 *)(lVar9 + 16) + 32);
                      if (lVar9 == null) goto LAB_180ce5ab2;
                      uVar1 = *(uint32 *)(lVar9 + 72);
                      if ((this.bountyData == null) ||
                         (lVar9 = this.bountyData.missionTargetDatas) == null)
                      goto LAB_180ce5ab2;
                      if (*(int *)(lVar9 + 24) == 0) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar9 = *(int64 *)(*(int64 *)(lVar9 + 16) + 32);
                      if ((lVar9 == null) || (lVar5 == null)) goto LAB_180ce5ab2;
                      cVar4 = PlotController.CheckMeetRequire
                                        (lVar5,uVar1,*(uint32 *)(lVar9 + 76),0,0);
                      uVar10 = "\n需要:{2}{0}{1}</color>";
                      if (!cVar4) {
                        lVar5 = FUN_18046c440(0);
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
                          uVar12 = *(uint64 *)(pStatics + 0x2c8);
                        }
                        else {
                          uVar12 = *(uint64 *)(pStatics + 0x240);
                        }
                      }
                      else {
                        uVar12 = *(uint64 *)(pStatics + 0x260);
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
                            uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
                            if (this.bountyData == null) throw; // [null/range check failed]
                            uVar7 = MissionData.GetMissionTargetDescribe
                                              (this.bountyData,1,0);
                            uVar7 = String.Concat("\n\n目标:\n",uVar7,0);
                            LTLocalization.AddText(uVar6,uVar7,0);
                          }
                          lVar5 = Component.get_transform(this,0);
                          if ((lVar5 != null) && (lVar5 = Transform.Find(lVar5,"Difficulty",0)) != null
                             ) {
                            uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
                            if (this.bountyData != null) {
                              uVar1 = this.bountyData.difficulty;
                              uVar7 = GlobalData.GetDifficultyStarString(uVar1,0);
                              uVar7 = String.Format("难度:{0}",uVar7,0);
                              LTLocalization.SetText(uVar6,uVar7,0);
                              lVar5 = Component.get_transform(this,0);
                              if ((lVar5 != null) &&
                                 (lVar5 = Transform.Find(lVar5,"Money",0)) != null) {
                                uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
                                if (this.bountyData != null) {
                                  iVar2 = this.bountyData.missionMoneyReward;
                                  uVar7 = "";
                                  if (iVar2 != 0) {
                                    local_res8[0] = iVar2;
                                    uVar7 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
                                    uVar7 = String.Format("银两:{0}",uVar7,0);
                                  }
                                  LTLocalization.SetText(uVar6,uVar7,0);
                                  if (this.bountyData != null) {
                                    if (this.bountyData.missionFameReward == null.0) {
                                      lVar5 = Component.get_transform(this,0);
                                      if ((lVar5 == null) ||
                                         (lVar5 = Transform.Find(lVar5,"Fame",0)) == null)
                                      throw; // [null/range check failed]
                                      uVar7 = Component.GetComponent(lVar5,DAT_181d6d8c0);
                                      uVar6 = "";
                                    }
                                    else {
                                      lVar5 = Component.get_transform(this,0);
                                      if ((lVar5 == null) ||
                                         (lVar5 = Transform.Find(lVar5,"Fame",0)) == null)
                                      throw; // [null/range check failed]
                                      uVar7 = Component.GetComponent(lVar5,DAT_181d6d8c0);
                                      uVar6 = "{0}:{1}";
                                      lVar5 = this.bountyData;
                                      if (lVar5 == null) throw; // [null/range check failed]
                                      lVar9 = "声望";
                                      if (lVar5.missionSourceType == 3) {
                                        if (((*(byte *)(DAT_181d65770 + 0x133) & 4) != 0) &&
                                           (*(int *)(DAT_181d65770 + 224) == 0)) {
                                          il2cpp_runtime_class_init(DAT_181d65770);
                                          lVar5 = this.bountyData;
                                        }
                                        lVar9 = **(int64 **)(DAT_181d65770 + 184);
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
                                        lVar5 = FUN_18046c0a0(0);
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
                                      if (-1 < this.bountyData.sourceForceID) {
                                        lVar9 = FUN_18046c0a0(0);
                                        if (((lVar9 == null) || (this.bountyData == null)) ||
                                           ((*(int64 *)(lVar9 + 32) == 0 ||
                                            (lVar9 = WorldData.GetForce(*(int64 *)(lVar9 + 32),
                                                                         *(uint32 *)
                                                                          (this.bountyData +
                                                                          88),0), lVar9 == null))))
                                        throw; // [null/range check failed]
                                        uVar10 = *(uint64 *)(lVar9 + 24);
                                      }
                                      if (lVar5 == null) {
        LAB_180ce5aac:
                          // WARNING: Subroutine does not return
                                        FUN_1800d6620();
                                      }
                                      uVar8 = String.Replace(lVar5,uVar8,uVar10,0);
                                      if (this.bountyData == null) goto LAB_180ce5aac;
                                      local_res8[0] = this.bountyData.missionFameReward;
                                      uVar10 = il2cpp_value_box(DAT_181d7d0b8,local_res8);
                                      uVar6 = String.Format(uVar6,uVar8,uVar10,0);
                                    }
                                    LTLocalization.SetText(uVar7,uVar6,0);
                                    lVar5 = Component.get_transform(this,0);
                                    if ((lVar5 != null) &&
                                       (lVar5 = Transform.Find(lVar5,"Time",0)) != null) {
                                      uVar6 = Component.GetComponent(lVar5,DAT_181d6d8c0);
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

    // Token : 0x6000D41
    // RVA   : 0xCE4AE0   Offset: 0xCE32E0   Length: 0x43A
    public void OnClick()
    {
        var pStatics_def8 = *(int64*)(DAT_181d8def8 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        int iVar2;
        long lVar3;
        ulong uVar4;
        if ((*pStatics_df90 != 0) &&
           (lVar3 = *(int64 *)(*pStatics_df90 + 32)) != null) {
          lVar3 = WorldData.Player(lVar3,0);
          if (lVar3 != null) {
            iVar1 = HeroData.GetBountyMissionNum(lVar3,0);
            if ((*pStatics_df90 != 0) &&
               (lVar3 = *(int64 *)(*pStatics_df90 + 32)) != null) {
              lVar3 = WorldData.Player(lVar3,0);
              if (lVar3 != null) {
                iVar2 = HeroData.GetMaxBountyMissionNum(lVar3,0);
                if (iVar1 < iVar2) {
                  if (*pStatics_df90 != 0) {
                    GameController.GetFullMission
                              (*pStatics_df90,this.bountyData,0);
                    lVar3 = *(int64 *)(*(int64 *)(DAT_181d8ee60 + 184) + 8);
                    if (((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 24)) != null) &&
                       (lVar3 = *(int64 *)(lVar3 + 48)) != null) {
                      FUN_181801c10(lVar3,this.bountyData,DAT_181d6d2e8);
                      uVar4 = Component.get_gameObject(this,0);
                      Object.Destroy(uVar4,0);
                      if (*pStatics_def8 != 0) {
                        BountyUIController.FreshBountyNum(*pStatics_def8,0);
                        return;
                      }
                    }
                  }
                }
                else {
                  if (*pStatics_df90 != 0) {
                    GameController.ShowTextOnMouse(*pStatics_df90,"无法领取更多委托",0)
                    ;
                    plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
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
          }
        }
    }

    // Token : 0x6000D42
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
