// ============================================================
// Type  : MissionIconController
// Token : 0x2000311
// ============================================================

public class MissionIconController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001969
    public MissionData missionData;

    // Token: 0x400196A
    public bool inited;

    // Token: 0x400196B
    private float refreshTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60019BE
    // RVA   : 0x847890   Offset: 0x846690   Length: 0x41C
    private void Update()
    {
        uint uVar1;
        ulong uVar2;
        long lVar3;
        ulong uVar6;
        ulong uVar7;
        ulong uVar8;
        float fVar10;
        float fVar11;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        if (!this.inited) {
          this.inited = 1;
          lVar3 = Component.get_transform(this,0);
          if ((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"HighLight",0)) == null)
          throw; // [null/range check failed]
          plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181e777b8);
          lVar3 = *(int64 *)(*(int64 *)(DAT_181e538e8 + 184) + 0x470);
          if ((this.missionData == null) || (lVar3 == null)) throw; // [null/range check failed]
          uVar1 = this.missionData.missionSourceType;
          if (lVar3.name <= uVar1) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar6,0);
          }
          if (plVar4 == (int64 *)0) throw; // [null/range check failed]
          puVar5 = (uint32 *)(lVar3 + ((int64)(int)uVar1 + 2) * 16);
          local_28 = *puVar5;
          uStack_24 = puVar5[1];
          uStack_20 = puVar5[2];
          uStack_1c = puVar5[3];
          (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_28,*(uint64 *)(*plVar4 + 0x2b0));
          lVar3 = Component.get_transform(this,0);
          if ((lVar3 == null) || (lVar3 = Transform.Find(lVar3,"RareLv",0)) == null)
          throw; // [null/range check failed]
          plVar4 = (int64 *)Component.GetComponent(lVar3,DAT_181e777b8);
          if ((this.missionData == null) ||
             (puVar5 = (uint32 *)
                       GlobalData.GetDifficultyColor
                                 (&local_28,this.missionData.difficulty,0),
             plVar4 == (int64 *)0)) throw; // [null/range check failed]
          local_28 = *puVar5;
          uStack_24 = puVar5[1];
          uStack_20 = puVar5[2];
          uStack_1c = puVar5[3];
          (**(code **)(*plVar4 + 0x2a8))(plVar4,&local_28,*(uint64 *)(*plVar4 + 0x2b0));
        }
        fVar11 = this.refreshTime;
        fVar10 = (float)Time.get_deltaTime(0);
        fVar11 = fVar11 - fVar10;
        this.refreshTime = fVar11;
        if (0.0 < fVar11) {
          return;
        }
        this.refreshTime = 0x3dcccccd;
        lVar3 = Component.get_transform(this,0);
        if ((lVar3 != null) && (lVar3 = Transform.Find(lVar3,"Title",0)) != null) {
          uVar6 = Component.GetComponent(lVar3,DAT_181e79538);
          lVar3 = this.missionData;
          if (lVar3 != null) {
            uVar8 = lVar3.name;
            lVar3 = lVar3.missionTargetDatas;
            if (lVar3 != null) {
              if (lVar3.name == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar2 = "({0})";
              lVar3 = *(int64 *)(lVar3.id + 32);
              if (lVar3 != null) {
                uVar7 = "";
                if (lVar3.stageMinLeftTime != null) {
                  lVar3 = this.missionData;
                  if (lVar3 == null) throw; // [null/range check failed]
                  if (!lVar3.missionHideTargetPlace) {
                    uVar7 = MissionData.GetTriggerTargetDescribe(lVar3,0,0,0);
                  }
                  else {
                    uVar7 = lVar3.missionHideTargetPlaceString;
                  }
                  uVar7 = String.Format(uVar2,uVar7,0);
                }
                uVar8 = String.Concat(uVar8,uVar7,0);
                LTLocalization.SetText(uVar6,uVar8,0);
                lVar3 = Component.get_transform(this,0);
                if ((lVar3 != null) && (lVar3 = Transform.Find(lVar3,"LeftTime",0)) != null) {
                  uVar6 = Component.GetComponent(lVar3,DAT_181e79538);
                  if (this.missionData != null) {
                    piVar9 = &this.missionData.leftTime;
                    uVar8 = "";
                    if (0 < this.missionData.leftTime) {
                      uVar8 = Int32.ToString(piVar9,0);
                      uVar8 = String.Format("{0}天",uVar8,0);
                    }
                    LTLocalization.SetText(uVar6,uVar8,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60019BF
    // RVA   : 0x8474E0   Offset: 0x8462E0   Length: 0x3A7
    public void OnClick()
    {
        var pStatics_2a90 = *(int64*)(DAT_181e52a90 + 184);
        bool cVar1;
        int iVar2;
        uint uVar3;
        long lVar4;
        long lVar5;
        long lVar8;
        uint local_38;
        uint uStack_34;
        uint local_28;
        uint uStack_24;
        byte[] local_18 = new byte[16];
        if (GameController._instance != null) {
          cVar1 = GameController.HaveSpeUI(GameController._instance,1,0);
          if (cVar1) {
            return;
          }
          if ((*pStatics_2a90 != 0) &&
             (lVar4 = *(int64 *)(*pStatics_2a90 + 32)) != null) {
            cVar1 = GameObject.get_activeSelf(lVar4,0);
            if (!cVar1) {
              return;
            }
            lVar4 = this.missionData;
            if (lVar4 != null) {
              if (lVar4.missionHideTargetPlace) {
                return;
              }
              lVar4 = MissionData.GetTargetAreaID(lVar4,0);
              if (lVar4 != null) {
                if (lVar4.name < 1) {
                  if (this.missionData != null) {
                    iVar2 = MissionData.GetTargetInnID(this.missionData,0);
                    if (iVar2 < 0) {
                      return;
                    }
                    lVar4 = FUN_180210220(0);
                    lVar5 = FUN_180210220(0);
                    if (lVar5 != null) {
                      lVar5 = *(int64 *)(lVar5 + 120);
                      if (((this.missionData != null) &&
                          (uVar3 = MissionData.GetTargetInnID(this.missionData,0),
                          lVar5 != null)) &&
                         ((lVar5 = FUN_18171b450(lVar5,uVar3,DAT_181e9b4c0), lVar5 != null &&
                          (lVar5 = GameObject.get_transform(lVar5,0)) != null))) {
                        puVar6 = (uint64 *)Transform.get_localPosition(local_18,lVar5,0);
                        if (lVar4 != null) {
                          local_38 = (uint32)*puVar6;
                          uStack_24 = (uint32)((uint64)*puVar6 >> 32);
        LAB_18084774d:
                          *(uint32 *)(lVar4 + 168) = local_38;
                          *(uint32 *)(lVar4 + 172) = uStack_24;
                          plVar7 = (int64 *)Resources.Load("Sound/SoundEffect/Woosh",0);
                          plVar9 = (int64 *)0;
                          if ((plVar7 != (int64 *)0) && (*plVar7 == DAT_181e8f4a0)) {
                            plVar9 = plVar7;
                          }
                          NGUITools.PlaySound(plVar9,0);
                          return;
                        }
                      }
                    }
                  }
                }
                else {
                  lVar4 = FUN_180210220(0);
                  lVar5 = FUN_180210220(0);
                  if (lVar5 != null) {
                    lVar5 = *(int64 *)(lVar5 + 96);
                    if ((this.missionData != null) &&
                       (lVar8 = MissionData.GetTargetAreaID(this.missionData,0)) != null
                       ) {
                      if (*(int *)(lVar8 + 24) == 0) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      if (((lVar5 != null) &&
                          (lVar5 = FUN_18171b450(lVar5,*(uint32 *)(*(int64 *)(lVar8 + 16) + 32)
                                                 ,DAT_181e9b4c0), lVar5 != null)) &&
                         (lVar5 = GameObject.get_transform(lVar5,0)) != null) {
                        puVar6 = (uint64 *)Transform.get_localPosition(local_18,lVar5,0);
                        if (lVar4 != null) {
                          local_28 = (uint32)*puVar6;
                          uStack_34 = (uint32)((uint64)*puVar6 >> 32);
                          uStack_24 = uStack_34;
                          local_38 = local_28;
                          goto LAB_18084774d;
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

    // Token : 0x60019C0
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
