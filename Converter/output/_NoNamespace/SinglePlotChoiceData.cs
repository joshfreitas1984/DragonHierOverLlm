// ============================================================
// Type  : SinglePlotChoiceData
// Token : 0x200032B
// ============================================================

public class SinglePlotChoiceData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001A40
    public string choiceText;

    // Token: 0x4001A41
    public string callFuc;

    // Token: 0x4001A42
    public string callParam;

    // Token: 0x4001A43
    public bool inited;

    // Token: 0x4001A44
    public bool inheritMissionRequirement;

    // Token: 0x4001A45
    public List<PlotChoiceRequirement> requirements;

    // Token: 0x4001A46
    public List<RelationRequirementType> relations;

    // Token: 0x4001A47
    public bool autoChangeCostByDifficulty;

    // Token: 0x4001A48
    public List<ResourceData> costResource;

    // Token: 0x4001A49
    public string describe;

    // Token: 0x4001A4A
    public bool destroyEvent;

    // Token: 0x4001A4B
    public PlayerInteractionTimeType playerInteractionTimeNeed;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001A5D
    // RVA   : 0x42F150   Offset: 0x42DF50   Length: 0x7
    public void /*ctor*/()
    {
        long lVar1;
        ulong uVar2;
        bool cVar3;
        uint uVar4;
        long lVar5;
        ulong uVar6;
        long lVar7;
        ZhSegment.Initialize(this,0);
        lVar5 = FUN_1801dfd90(DAT_181e81128,1);
        if (lVar5 != null) {
          if (*(int *)(lVar5 + 24) == 0) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar6,0);
          }
          *(uint16 *)(lVar5 + 32) = 59;
          if (param_2 != 0) {
            lVar5 = String.Split(param_2,lVar5,0);
            if (lVar5 != null) {
              if (*(int *)(lVar5 + 24) == 0) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar6,0);
              }
              this.choiceText = *(uint64 *)(lVar5 + 32);
              if (*(uint32 *)(lVar5 + 24) < 2) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar6,0);
              }
              this.callFuc = *(uint64 *)(lVar5 + 40);
              if (2 < (int)*(uint32 *)(lVar5 + 24)) {
                if (*(uint32 *)(lVar5 + 24) < 3) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar6,0);
                }
                this.callParam = *(uint64 *)(lVar5 + 48);
              }
              uVar6 = il2cpp_internal(DAT_181e75238);
              FUN_1810f3480(uVar6,DAT_181e79460);
              this.requirements = uVar6;
              uVar6 = il2cpp_internal(DAT_181e76828);
              FUN_1810f3480(uVar6,DAT_181e815e0);
              this.relations = uVar6;
              uVar6 = il2cpp_internal(DAT_181e769a8);
              FUN_1810f3480(uVar6,DAT_181e81c60);
              this.costResource = uVar6;
              if (3 < (int)*(uint32 *)(lVar5 + 24)) {
                if (*(uint32 *)(lVar5 + 24) < 4) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar6,0);
                }
                cVar3 = String.op_Inequality(*(uint64 *)(lVar5 + 56),"",0);
                if (cVar3) {
                  if (*(uint32 *)(lVar5 + 24) < 4) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  lVar1 = *(int64 *)(lVar5 + 56);
                  lVar7 = FUN_1801dfd90(DAT_181e81128,1);
                  if (lVar7 == null) throw; // [null/range check failed]
                  if (*(int *)(lVar7 + 24) == 0) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  *(uint16 *)(lVar7 + 32) = 47;
                  if (lVar1 == null) throw; // [null/range check failed]
                  lVar7 = String.Split(lVar1,lVar7,0);
                  lVar1 = this.costResource;
                  if (lVar7 == null) throw; // [null/range check failed]
                  if (*(int *)(lVar7 + 24) == 0) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  uVar4 = Int32.Parse(*(uint64 *)(lVar7 + 32),0);
                  if (*(uint32 *)(lVar7 + 24) < 2) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  Int32.Parse(*(uint64 *)(lVar7 + 40),0);
                  uVar6 = new PlotChoiceRequirement(uVar4);
                  if (lVar1 == null) throw; // [null/range check failed]
                  FUN_18175de30(lVar1,uVar6,DAT_181e81d58);
                }
              }
              if (4 < (int)*(uint32 *)(lVar5 + 24)) {
                if (*(uint32 *)(lVar5 + 24) < 5) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar6,0);
                }
                cVar3 = String.op_Inequality(*(uint64 *)(lVar5 + 64),"",0);
                if (cVar3) {
                  if (*(uint32 *)(lVar5 + 24) < 5) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  this.describe = *(uint64 *)(lVar5 + 64);
                }
              }
              if (5 < (int)*(uint32 *)(lVar5 + 24)) {
                if (*(uint32 *)(lVar5 + 24) < 6) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar6,0);
                }
                cVar3 = String.op_Inequality(*(uint64 *)(lVar5 + 72),"",0);
                if (cVar3) {
                  if (*(uint32 *)(lVar5 + 24) < 6) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  lVar1 = *(int64 *)(lVar5 + 72);
                  lVar7 = FUN_1801dfd90(DAT_181e81128,1);
                  if (lVar7 == null) throw; // [null/range check failed]
                  if (*(int *)(lVar7 + 24) == 0) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  *(uint16 *)(lVar7 + 32) = 47;
                  if (lVar1 == null) throw; // [null/range check failed]
                  lVar7 = String.Split(lVar1,lVar7,0);
                  uVar6 = DAT_181e95320;
                  lVar1 = this.requirements;
                  uVar6 = Type.GetTypeFromHandle(uVar6,0);
                  if (lVar7 == null) throw; // [null/range check failed]
                  if (*(int *)(lVar7 + 24) == 0) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  uVar2 = *(uint64 *)(lVar7 + 32);
                  plVar8 = (int64 *)Enum.Parse(uVar6,uVar2,0);
                  if (*(uint32 *)(lVar7 + 24) < 2) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  Single.Parse(*(uint64 *)(lVar7 + 40),0);
                  uVar6 = il2cpp_internal(DAT_181e71ee8);
                  if (plVar8 == (int64 *)0) throw; // [null/range check failed]
                  if (*(int64 *)(*plVar8 + 64) != *(int64 *)(DAT_181e97760 + 64)) {
                          // WARNING: Subroutine does not return
                    FUN_1801dfd50(plVar8,DAT_181e97760);
                  }
                  puVar9 = (uint32 *)il2cpp_object_unbox();
                  PlotChoiceRequirement.ctor(uVar6,*puVar9);
                  if (lVar1 == null) throw; // [null/range check failed]
                  FUN_18175de30(lVar1,uVar6,DAT_181e79560);
                }
              }
              if (6 < (int)*(uint32 *)(lVar5 + 24)) {
                if (*(uint32 *)(lVar5 + 24) < 7) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar6,0);
                }
                cVar3 = String.op_Inequality(*(uint64 *)(lVar5 + 80),"",0);
                uVar6 = DAT_181e9ea30;
                if (cVar3) {
                  uVar6 = Type.GetTypeFromHandle(uVar6,0);
                  if (*(uint32 *)(lVar5 + 24) < 7) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  uVar2 = *(uint64 *)(lVar5 + 80);
                  plVar8 = (int64 *)Enum.Parse(uVar6,uVar2,0);
                  if (plVar8 == (int64 *)0) throw; // [null/range check failed]
                  if (*(int64 *)(*plVar8 + 64) != *(int64 *)(DAT_181e71ae8 + 64)) {
                          // WARNING: Subroutine does not return
                    FUN_1801dfd50(plVar8,DAT_181e71ae8);
                  }
                  puVar9 = (uint32 *)il2cpp_object_unbox();
                  this.playerInteractionTimeNeed = *puVar9;
                }
              }
              return;
            }
          }
        }
    }

    // Token : 0x6001A5E
    // RVA   : 0x6AA7F0   Offset: 0x6A95F0   Length: 0x736
    public void /*ctor*/(string choiceDataText)
    {
        long lVar1;
        ulong uVar2;
        bool cVar3;
        uint uVar4;
        long lVar5;
        ulong uVar6;
        long lVar7;
        ZhSegment.Initialize(this,0);
        lVar5 = FUN_1801dfd90(DAT_181e81128,1);
        if (lVar5 != null) {
          if (*(int *)(lVar5 + 24) == 0) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar6,0);
          }
          *(uint16 *)(lVar5 + 32) = 59;
          if (choiceDataText != null) {
            lVar5 = String.Split(choiceDataText,lVar5,0);
            if (lVar5 != null) {
              if (*(int *)(lVar5 + 24) == 0) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar6,0);
              }
              this.choiceText = *(uint64 *)(lVar5 + 32);
              if (*(uint32 *)(lVar5 + 24) < 2) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar6,0);
              }
              this.callFuc = *(uint64 *)(lVar5 + 40);
              if (2 < (int)*(uint32 *)(lVar5 + 24)) {
                if (*(uint32 *)(lVar5 + 24) < 3) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar6,0);
                }
                this.callParam = *(uint64 *)(lVar5 + 48);
              }
              uVar6 = il2cpp_internal(DAT_181e75238);
              FUN_1810f3480(uVar6,DAT_181e79460);
              this.requirements = uVar6;
              uVar6 = il2cpp_internal(DAT_181e76828);
              FUN_1810f3480(uVar6,DAT_181e815e0);
              this.relations = uVar6;
              uVar6 = il2cpp_internal(DAT_181e769a8);
              FUN_1810f3480(uVar6,DAT_181e81c60);
              this.costResource = uVar6;
              if (3 < (int)*(uint32 *)(lVar5 + 24)) {
                if (*(uint32 *)(lVar5 + 24) < 4) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar6,0);
                }
                cVar3 = String.op_Inequality(*(uint64 *)(lVar5 + 56),"",0);
                if (cVar3) {
                  if (*(uint32 *)(lVar5 + 24) < 4) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  lVar1 = *(int64 *)(lVar5 + 56);
                  lVar7 = FUN_1801dfd90(DAT_181e81128,1);
                  if (lVar7 == null) throw; // [null/range check failed]
                  if (*(int *)(lVar7 + 24) == 0) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  *(uint16 *)(lVar7 + 32) = 47;
                  if (lVar1 == null) throw; // [null/range check failed]
                  lVar7 = String.Split(lVar1,lVar7,0);
                  lVar1 = this.costResource;
                  if (lVar7 == null) throw; // [null/range check failed]
                  if (*(int *)(lVar7 + 24) == 0) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  uVar4 = Int32.Parse(*(uint64 *)(lVar7 + 32),0);
                  if (*(uint32 *)(lVar7 + 24) < 2) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  Int32.Parse(*(uint64 *)(lVar7 + 40),0);
                  uVar6 = new PlotChoiceRequirement(uVar4);
                  if (lVar1 == null) throw; // [null/range check failed]
                  FUN_18175de30(lVar1,uVar6,DAT_181e81d58);
                }
              }
              if (4 < (int)*(uint32 *)(lVar5 + 24)) {
                if (*(uint32 *)(lVar5 + 24) < 5) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar6,0);
                }
                cVar3 = String.op_Inequality(*(uint64 *)(lVar5 + 64),"",0);
                if (cVar3) {
                  if (*(uint32 *)(lVar5 + 24) < 5) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  this.describe = *(uint64 *)(lVar5 + 64);
                }
              }
              if (5 < (int)*(uint32 *)(lVar5 + 24)) {
                if (*(uint32 *)(lVar5 + 24) < 6) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar6,0);
                }
                cVar3 = String.op_Inequality(*(uint64 *)(lVar5 + 72),"",0);
                if (cVar3) {
                  if (*(uint32 *)(lVar5 + 24) < 6) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  lVar1 = *(int64 *)(lVar5 + 72);
                  lVar7 = FUN_1801dfd90(DAT_181e81128,1);
                  if (lVar7 == null) throw; // [null/range check failed]
                  if (*(int *)(lVar7 + 24) == 0) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  *(uint16 *)(lVar7 + 32) = 47;
                  if (lVar1 == null) throw; // [null/range check failed]
                  lVar7 = String.Split(lVar1,lVar7,0);
                  uVar6 = DAT_181e95320;
                  lVar1 = this.requirements;
                  uVar6 = Type.GetTypeFromHandle(uVar6,0);
                  if (lVar7 == null) throw; // [null/range check failed]
                  if (*(int *)(lVar7 + 24) == 0) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  uVar2 = *(uint64 *)(lVar7 + 32);
                  plVar8 = (int64 *)Enum.Parse(uVar6,uVar2,0);
                  if (*(uint32 *)(lVar7 + 24) < 2) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  Single.Parse(*(uint64 *)(lVar7 + 40),0);
                  uVar6 = il2cpp_internal(DAT_181e71ee8);
                  if (plVar8 == (int64 *)0) throw; // [null/range check failed]
                  if (*(int64 *)(*plVar8 + 64) != *(int64 *)(DAT_181e97760 + 64)) {
                          // WARNING: Subroutine does not return
                    FUN_1801dfd50(plVar8,DAT_181e97760);
                  }
                  puVar9 = (uint32 *)il2cpp_object_unbox();
                  PlotChoiceRequirement.ctor(uVar6,*puVar9);
                  if (lVar1 == null) throw; // [null/range check failed]
                  FUN_18175de30(lVar1,uVar6,DAT_181e79560);
                }
              }
              if (6 < (int)*(uint32 *)(lVar5 + 24)) {
                if (*(uint32 *)(lVar5 + 24) < 7) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1801e02d0(uVar6,0);
                }
                cVar3 = String.op_Inequality(*(uint64 *)(lVar5 + 80),"",0);
                uVar6 = DAT_181e9ea30;
                if (cVar3) {
                  uVar6 = Type.GetTypeFromHandle(uVar6,0);
                  if (*(uint32 *)(lVar5 + 24) < 7) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1801e02d0(uVar6,0);
                  }
                  uVar2 = *(uint64 *)(lVar5 + 80);
                  plVar8 = (int64 *)Enum.Parse(uVar6,uVar2,0);
                  if (plVar8 == (int64 *)0) throw; // [null/range check failed]
                  if (*(int64 *)(*plVar8 + 64) != *(int64 *)(DAT_181e71ae8 + 64)) {
                          // WARNING: Subroutine does not return
                    FUN_1801dfd50(plVar8,DAT_181e71ae8);
                  }
                  puVar9 = (uint32 *)il2cpp_object_unbox();
                  this.playerInteractionTimeNeed = *puVar9;
                }
              }
              return;
            }
          }
        }
    }

    // Token : 0x6001A5F
    // RVA   : 0x6AA360   Offset: 0x6A9160   Length: 0x482
    public virtual object Clone()
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        uint uVar7;
        long lVar10;
        long local_res8;
        lVar3 = new ZhSegment(0);
        if (lVar3 != null) {
          *(uint64 *)(lVar3 + 16) = this.choiceText;
          *(uint64 *)(lVar3 + 24) = this.callFuc;
          *(uint64 *)(lVar3 + 32) = this.callParam;
          lVar10 = 32;
          *(uint8 *)(lVar3 + 40) = this.inited;
          *(uint8 *)(lVar3 + 41) = this.inheritMissionRequirement;
          local_res8 = 32;
          if (this.requirements == null) {
            *(uint64 *)(lVar3 + 48) = 0;
        LAB_1806aa5f8:
            plVar9 = (int64 *)0;
            lVar10 = this.relations;
            plVar6 = plVar9;
            if (lVar10 != null) {
              plVar6 = (int64 *)il2cpp_internal(DAT_181e76828);
              FUN_181779b60(plVar6,lVar10,DAT_181e81660);
            }
            *(uint64 *)(lVar3 + 56) = plVar6;
            *(uint8 *)(lVar3 + 64) = this.autoChangeCostByDifficulty;
            if (this.costResource == null) {
              *(uint64 *)(lVar3 + 72) = 0;
        LAB_1806aa783:
              *(uint64 *)(lVar3 + 80) = this.describe;
              *(uint8 *)(lVar3 + 88) = this.destroyEvent;
              *(uint32 *)(lVar3 + 92) = this.playerInteractionTimeNeed;
              return lVar3;
            }
            uVar1 = this.costResource.Count;
            uVar4 = new List_1(uVar1,DAT_181e81ce0);
            *(uint64 *)(lVar3 + 72) = uVar4;
            lVar10 = this.costResource;
            plVar6 = plVar9;
            if (lVar10 != null) {
              while( true ) {
                uVar7 = (uint32)plVar6;
                if (lVar10.Count <= (int)uVar7) goto LAB_1806aa783;
                lVar5 = *(int64 *)(lVar3 + 72);
                if (lVar10 == null) break;
                if (lVar10.Count <= uVar7) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                plVar8 = plVar9;
                if (*(int64 *)(local_res8 + lVar10._items) != 0) {
                  if ((this.costResource == null) ||
                     (lVar10 = FUN_1800024b0(this.costResource,plVar6,DAT_181e81e58),
                     lVar10 == null)) break;
                  plVar6 = (int64 *)ResourceData.Clone(lVar10,0);
                  if (plVar6 != (int64 *)0) {
                  }
                }
                if (lVar5 == null) break;
                FUN_18175de30(lVar5,plVar8,DAT_181e81d58);
                lVar10 = this.costResource;
                local_res8 = local_res8 + 8;
                plVar6 = (int64 *)(uint64)(uVar7 + 1);
                if (lVar10 == null) break;
              }
            }
          }
          else {
            uVar1 = this.requirements.Count;
            uVar4 = new List_1(uVar1,DAT_181e794e0);
            *(uint64 *)(lVar3 + 48) = uVar4;
            lVar5 = this.requirements;
            plVar9 = (int64 *)0;
            plVar6 = plVar9;
            if (lVar5 != null) {
              while( true ) {
                uVar7 = (uint32)plVar6;
                if (lVar5.Count <= (int)uVar7) goto LAB_1806aa5f8;
                lVar2 = *(int64 *)(lVar3 + 48);
                if (lVar5 == null) break;
                if (lVar5.Count <= uVar7) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                plVar8 = plVar9;
                if (*(int64 *)(lVar10 + lVar5._items) != 0) {
                  if ((this.requirements == null) ||
                     (lVar5 = FUN_1800024b0(this.requirements,plVar6,DAT_181e79660),
                     lVar5 == null)) break;
                  plVar6 = (int64 *)PlotChoiceRequirement.Clone(lVar5,0);
                  if (plVar6 != (int64 *)0) {
                  }
                }
                if (lVar2 == null) break;
                FUN_18175de30(lVar2,plVar8,DAT_181e79560);
                lVar5 = this.requirements;
                plVar6 = (int64 *)(uint64)(uVar7 + 1);
                lVar10 = lVar10 + 8;
                if (lVar5 == null) break;
              }
            }
          }
        }
    }

}
