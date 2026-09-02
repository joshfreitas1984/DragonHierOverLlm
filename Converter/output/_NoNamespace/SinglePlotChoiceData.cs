// ============================================================
// Type  : SinglePlotChoiceData
// Token : 0x200031A
// ============================================================

public class SinglePlotChoiceData
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40018D4
    public string choiceText;

    // Token: 0x40018D5
    public string callFuc;

    // Token: 0x40018D6
    public string callParam;

    // Token: 0x40018D7
    public bool inited;

    // Token: 0x40018D8
    public bool inheritMissionRequirement;

    // Token: 0x40018D9
    public List<PlotChoiceRequirement> requirements;

    // Token: 0x40018DA
    public List<RelationRequirementType> relations;

    // Token: 0x40018DB
    public bool autoChangeCostByDifficulty;

    // Token: 0x40018DC
    public List<ResourceData> costResource;

    // Token: 0x40018DD
    public string describe;

    // Token: 0x40018DE
    public bool destroyEvent;

    // Token: 0x40018DF
    public PlayerInteractionTimeType playerInteractionTimeNeed;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001967
    // RVA   : 0x210B70   Offset: 0x20F370   Length: 0x7
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
        lVar5 = FUN_1800d60b0(DAT_181d7c118,1);
        if (lVar5 != null) {
          if (*(int *)(lVar5 + 24) == 0) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar6,0);
          }
          *(uint16 *)(lVar5 + 32) = 59;
          if (param_2 != 0) {
            lVar5 = String.Split(param_2,lVar5,0);
            if (lVar5 != null) {
              if (*(int *)(lVar5 + 24) == 0) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              this.choiceText = *(uint64 *)(lVar5 + 32);
              if (*(uint32 *)(lVar5 + 24) < 2) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              this.callFuc = *(uint64 *)(lVar5 + 40);
              if (2 < (int)*(uint32 *)(lVar5 + 24)) {
                if (*(uint32 *)(lVar5 + 24) < 3) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                this.callParam = *(uint64 *)(lVar5 + 48);
              }
              uVar6 = il2cpp_internal(DAT_181d70530);
              FUN_180f58a90(uVar6,DAT_181d6f768);
              this.requirements = uVar6;
              uVar6 = il2cpp_internal(DAT_181d71b30);
              FUN_180f58a90(uVar6,DAT_181d777d8);
              this.relations = uVar6;
              uVar6 = il2cpp_internal(DAT_181d71cb0);
              FUN_180f58a90(uVar6,DAT_181d77dd8);
              this.costResource = uVar6;
              if (3 < (int)*(uint32 *)(lVar5 + 24)) {
                if (*(uint32 *)(lVar5 + 24) < 4) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                cVar3 = String.op_Inequality(*(uint64 *)(lVar5 + 56),"",0);
                if (cVar3) {
                  if (*(uint32 *)(lVar5 + 24) < 4) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  lVar1 = *(int64 *)(lVar5 + 56);
                  lVar7 = FUN_1800d60b0(DAT_181d7c118,1);
                  if (lVar7 == null) throw; // [null/range check failed]
                  if (*(int *)(lVar7 + 24) == 0) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  *(uint16 *)(lVar7 + 32) = 47;
                  if (lVar1 == null) throw; // [null/range check failed]
                  lVar7 = String.Split(lVar1,lVar7,0);
                  lVar1 = this.costResource;
                  if (lVar7 == null) throw; // [null/range check failed]
                  if (*(int *)(lVar7 + 24) == 0) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  uVar4 = Int32.Parse(*(uint64 *)(lVar7 + 32),0);
                  if (*(uint32 *)(lVar7 + 24) < 2) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  Int32.Parse(*(uint64 *)(lVar7 + 40),0);
                  uVar6 = new PlotChoiceRequirement(uVar4);
                  if (lVar1 == null) throw; // [null/range check failed]
                  FUN_181827900(lVar1,uVar6,DAT_181d77e58);
                }
              }
              if (4 < (int)*(uint32 *)(lVar5 + 24)) {
                if (*(uint32 *)(lVar5 + 24) < 5) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                cVar3 = String.op_Inequality(*(uint64 *)(lVar5 + 64),"",0);
                if (cVar3) {
                  if (*(uint32 *)(lVar5 + 24) < 5) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  this.describe = *(uint64 *)(lVar5 + 64);
                }
              }
              if (5 < (int)*(uint32 *)(lVar5 + 24)) {
                if (*(uint32 *)(lVar5 + 24) < 6) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                cVar3 = String.op_Inequality(*(uint64 *)(lVar5 + 72),"",0);
                if (cVar3) {
                  if (*(uint32 *)(lVar5 + 24) < 6) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  lVar1 = *(int64 *)(lVar5 + 72);
                  lVar7 = FUN_1800d60b0(DAT_181d7c118,1);
                  if (lVar7 == null) throw; // [null/range check failed]
                  if (*(int *)(lVar7 + 24) == 0) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  *(uint16 *)(lVar7 + 32) = 47;
                  if (lVar1 == null) throw; // [null/range check failed]
                  lVar7 = String.Split(lVar1,lVar7,0);
                  uVar6 = DAT_181d90f98;
                  lVar1 = this.requirements;
                  uVar6 = Type.GetTypeFromHandle(uVar6,0);
                  if (lVar7 == null) throw; // [null/range check failed]
                  if (*(int *)(lVar7 + 24) == 0) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  uVar2 = *(uint64 *)(lVar7 + 32);
                  plVar8 = (int64 *)Enum.Parse(uVar6,uVar2,0);
                  if (*(uint32 *)(lVar7 + 24) < 2) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  Single.Parse(*(uint64 *)(lVar7 + 40),0);
                  uVar6 = il2cpp_internal(DAT_181d6c8e0);
                  if (plVar8 == (int64 *)0) throw; // [null/range check failed]
                  if (*(int64 *)(*plVar8 + 64) != *(int64 *)(DAT_181d922e8 + 64)) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6070(plVar8,DAT_181d922e8);
                  }
                  puVar9 = (uint32 *)il2cpp_object_unbox();
                  PlotChoiceRequirement.ctor(uVar6,*puVar9);
                  if (lVar1 == null) throw; // [null/range check failed]
                  FUN_181827900(lVar1,uVar6,DAT_181d6f7e8);
                }
              }
              if (6 < (int)*(uint32 *)(lVar5 + 24)) {
                if (*(uint32 *)(lVar5 + 24) < 7) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                cVar3 = String.op_Inequality(*(uint64 *)(lVar5 + 80),"",0);
                uVar6 = DAT_181d9a6a8;
                if (cVar3) {
                  uVar6 = Type.GetTypeFromHandle(uVar6,0);
                  if (*(uint32 *)(lVar5 + 24) < 7) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  uVar2 = *(uint64 *)(lVar5 + 80);
                  plVar8 = (int64 *)Enum.Parse(uVar6,uVar2,0);
                  if (plVar8 == (int64 *)0) throw; // [null/range check failed]
                  if (*(int64 *)(*plVar8 + 64) != *(int64 *)(DAT_181d6c4e0 + 64)) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6070(plVar8,DAT_181d6c4e0);
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

    // Token : 0x6001968
    // RVA   : 0x96FBC0   Offset: 0x96E3C0   Length: 0x736
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
        lVar5 = FUN_1800d60b0(DAT_181d7c118,1);
        if (lVar5 != null) {
          if (*(int *)(lVar5 + 24) == 0) {
            uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar6,0);
          }
          *(uint16 *)(lVar5 + 32) = 59;
          if (choiceDataText != null) {
            lVar5 = String.Split(choiceDataText,lVar5,0);
            if (lVar5 != null) {
              if (*(int *)(lVar5 + 24) == 0) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              this.choiceText = *(uint64 *)(lVar5 + 32);
              if (*(uint32 *)(lVar5 + 24) < 2) {
                uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar6,0);
              }
              this.callFuc = *(uint64 *)(lVar5 + 40);
              if (2 < (int)*(uint32 *)(lVar5 + 24)) {
                if (*(uint32 *)(lVar5 + 24) < 3) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                this.callParam = *(uint64 *)(lVar5 + 48);
              }
              uVar6 = il2cpp_internal(DAT_181d70530);
              FUN_180f58a90(uVar6,DAT_181d6f768);
              this.requirements = uVar6;
              uVar6 = il2cpp_internal(DAT_181d71b30);
              FUN_180f58a90(uVar6,DAT_181d777d8);
              this.relations = uVar6;
              uVar6 = il2cpp_internal(DAT_181d71cb0);
              FUN_180f58a90(uVar6,DAT_181d77dd8);
              this.costResource = uVar6;
              if (3 < (int)*(uint32 *)(lVar5 + 24)) {
                if (*(uint32 *)(lVar5 + 24) < 4) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                cVar3 = String.op_Inequality(*(uint64 *)(lVar5 + 56),"",0);
                if (cVar3) {
                  if (*(uint32 *)(lVar5 + 24) < 4) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  lVar1 = *(int64 *)(lVar5 + 56);
                  lVar7 = FUN_1800d60b0(DAT_181d7c118,1);
                  if (lVar7 == null) throw; // [null/range check failed]
                  if (*(int *)(lVar7 + 24) == 0) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  *(uint16 *)(lVar7 + 32) = 47;
                  if (lVar1 == null) throw; // [null/range check failed]
                  lVar7 = String.Split(lVar1,lVar7,0);
                  lVar1 = this.costResource;
                  if (lVar7 == null) throw; // [null/range check failed]
                  if (*(int *)(lVar7 + 24) == 0) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  uVar4 = Int32.Parse(*(uint64 *)(lVar7 + 32),0);
                  if (*(uint32 *)(lVar7 + 24) < 2) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  Int32.Parse(*(uint64 *)(lVar7 + 40),0);
                  uVar6 = new PlotChoiceRequirement(uVar4);
                  if (lVar1 == null) throw; // [null/range check failed]
                  FUN_181827900(lVar1,uVar6,DAT_181d77e58);
                }
              }
              if (4 < (int)*(uint32 *)(lVar5 + 24)) {
                if (*(uint32 *)(lVar5 + 24) < 5) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                cVar3 = String.op_Inequality(*(uint64 *)(lVar5 + 64),"",0);
                if (cVar3) {
                  if (*(uint32 *)(lVar5 + 24) < 5) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  this.describe = *(uint64 *)(lVar5 + 64);
                }
              }
              if (5 < (int)*(uint32 *)(lVar5 + 24)) {
                if (*(uint32 *)(lVar5 + 24) < 6) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                cVar3 = String.op_Inequality(*(uint64 *)(lVar5 + 72),"",0);
                if (cVar3) {
                  if (*(uint32 *)(lVar5 + 24) < 6) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  lVar1 = *(int64 *)(lVar5 + 72);
                  lVar7 = FUN_1800d60b0(DAT_181d7c118,1);
                  if (lVar7 == null) throw; // [null/range check failed]
                  if (*(int *)(lVar7 + 24) == 0) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  *(uint16 *)(lVar7 + 32) = 47;
                  if (lVar1 == null) throw; // [null/range check failed]
                  lVar7 = String.Split(lVar1,lVar7,0);
                  uVar6 = DAT_181d90f98;
                  lVar1 = this.requirements;
                  uVar6 = Type.GetTypeFromHandle(uVar6,0);
                  if (lVar7 == null) throw; // [null/range check failed]
                  if (*(int *)(lVar7 + 24) == 0) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  uVar2 = *(uint64 *)(lVar7 + 32);
                  plVar8 = (int64 *)Enum.Parse(uVar6,uVar2,0);
                  if (*(uint32 *)(lVar7 + 24) < 2) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  Single.Parse(*(uint64 *)(lVar7 + 40),0);
                  uVar6 = il2cpp_internal(DAT_181d6c8e0);
                  if (plVar8 == (int64 *)0) throw; // [null/range check failed]
                  if (*(int64 *)(*plVar8 + 64) != *(int64 *)(DAT_181d922e8 + 64)) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6070(plVar8,DAT_181d922e8);
                  }
                  puVar9 = (uint32 *)il2cpp_object_unbox();
                  PlotChoiceRequirement.ctor(uVar6,*puVar9);
                  if (lVar1 == null) throw; // [null/range check failed]
                  FUN_181827900(lVar1,uVar6,DAT_181d6f7e8);
                }
              }
              if (6 < (int)*(uint32 *)(lVar5 + 24)) {
                if (*(uint32 *)(lVar5 + 24) < 7) {
                  uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar6,0);
                }
                cVar3 = String.op_Inequality(*(uint64 *)(lVar5 + 80),"",0);
                uVar6 = DAT_181d9a6a8;
                if (cVar3) {
                  uVar6 = Type.GetTypeFromHandle(uVar6,0);
                  if (*(uint32 *)(lVar5 + 24) < 7) {
                    uVar6 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                    FUN_1800d65f0(uVar6,0);
                  }
                  uVar2 = *(uint64 *)(lVar5 + 80);
                  plVar8 = (int64 *)Enum.Parse(uVar6,uVar2,0);
                  if (plVar8 == (int64 *)0) throw; // [null/range check failed]
                  if (*(int64 *)(*plVar8 + 64) != *(int64 *)(DAT_181d6c4e0 + 64)) {
                          // WARNING: Subroutine does not return
                    FUN_1800d6070(plVar8,DAT_181d6c4e0);
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

}
