// ============================================================
// Type  : StudyDodgeSkillController
// Token : 0x2000378
// ============================================================

public class StudyDodgeSkillController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B8E
    public bool inStudy;

    // Token: 0x4001B8F
    public bool finishing;

    // Token: 0x4001B90
    public GameObject studyDodgeSkillRoot;

    // Token: 0x4001B91
    public GameObject studyDodgeSkillUIRoot;

    // Token: 0x4001B92
    public Button finishButton;

    // Token: 0x4001B93
    public KungfuSkillLvData targetSkill;

    // Token: 0x4001B94
    public int mapWidth;

    // Token: 0x4001B95
    public int mapHeight;

    // Token: 0x4001B96
    public float totalExp;

    // Token: 0x4001B97
    public int combo;

    // Token: 0x4001B98
    public float comboTime;

    // Token: 0x4001B99
    public int hit;

    // Token: 0x4001B9A
    public bool skillUsed;

    // Token: 0x4001B9B
    public float leftTime;

    // Token: 0x4001B9C
    public List<GameObject> availableGrids;

    // Token: 0x4001B9D
    public List<GameObject> attackingGrids;

    // Token: 0x4001B9E
    public List<GameObject> movingArrows;

    // Token: 0x4001B9F
    public GameObject studyDodgeGridRoot;

    // Token: 0x4001BA0
    public GameObject studyDodgeTilePrefab;

    // Token: 0x4001BA1
    public GameObject studyDodgeArrowPrefab;

    // Token: 0x4001BA2
    public GameObject[] gridUnits;

    // Token: 0x4001BA3
    private List<GameObject> gridPool;

    // Token: 0x4001BA4
    private GameObject newObj;

    // Token: 0x4001BA5
    private bool inited;

    // Token: 0x4001BA6
    public static List<List<int>> SkillLvMapSize;

    // Token: 0x4001BA7
    private static StudyDodgeSkillController _instance;

    // Token: 0x4001BA8
    private float generateSpikeTime;

    // Token: 0x4001BA9
    private float generateArrowTime;

    // Token: 0x4001BAA
    private float generateStarTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60021C0
    // RVA   : 0xB8BAC0   Offset: 0xB8A2C0   Length: 0x58
    public static StudyDodgeSkillController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d82e70 + 184) + 8);
    }

    // Token : 0x60021C1
    // RVA   : 0xB88DC0   Offset: 0xB875C0   Length: 0x68
    private void Awake()
    {
        puVar1 = (uint64 *)(*(int64 *)(DAT_181d82e70 + 184) + 8);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60021C2
    // RVA   : 0xB8B2C0   Offset: 0xB89AC0   Length: 0x3AD
    private void Update()
    {
        var pStatics_2f70 = *(int64*)(DAT_181d82f70 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        ulong uVar1;
        long lVar2;
        ulong uVar3;
        float fVar4;
        float fVar5;
        if (!this.inStudy) {
          lVar2 = this.finishButton;
        }
        else {
          if (*pStatics_2f70 == 0) throw; // [null/range check failed]
          uVar3 = *(uint64 *)(*pStatics_2f70 + 80);
          uVar1 = Single.ToString(this + 72,0);
          uVar1 = String.Concat("经验 ",uVar1,0);
          LTLocalization.SetText(uVar3,uVar1,0);
          if (*pStatics_2f70 == 0) throw; // [null/range check failed]
          uVar3 = *(uint64 *)(*pStatics_2f70 + 88);
          uVar1 = Int32.ToString(this + 76,0);
          LTLocalization.SetText(uVar3,uVar1,0);
          if ((*pStatics_df90 == 0) ||
             (lVar2 = *(int64 *)(*pStatics_df90 + 32)) == null)
          throw; // [null/range check failed]
          lVar2 = WorldData.Player(lVar2,0);
          if ((*pStatics_2f70 == 0) || (lVar2 == null)) throw; // [null/range check failed]
          HeroData.SetHpBar(lVar2,*(uint64 *)(*pStatics_2f70 + 96),0);
          lVar2 = this.finishButton;
          if (!this.finishing) {
            if (lVar2 != null) {
              Selectable.set_interactable(lVar2,1,0);
              fVar5 = this.leftTime;
              if (0.0 < fVar5) {
                fVar4 = (float)Time.get_deltaTime(0);
                this.leftTime = fVar5 - fVar4;
                StudyDodgeSkillController.ManageAttackGenerate(this,0);
                fVar5 = this.comboTime;
                fVar4 = (float)Time.get_deltaTime(0);
                fVar5 = fVar5 - fVar4;
                this.comboTime = fVar5;
                if (0.0 < fVar5) {
                  return;
                }
                fVar5 = (float)(this.combo + 1);
                this.totalExp = fVar5 + fVar5 + this.totalExp;
                StudyDodgeSkillController.ChangeCombo(this,1);
                this.comboTime = 0x3f800000;
                return;
              }
              if (this.attackingGrids != null) {
                if (0 < this.attackingGrids.Count) {
                  return;
                }
                if (this.movingArrows != null) {
                  if (0 < this.movingArrows.Count) {
                    return;
                  }
                  uVar3 = StudyDodgeSkillController.FinishStudyDodgeSkill(this,2);
                  FUN_180d837c0(this,uVar3,0);
                  return;
                }
              }
            }
            throw; // [null/range check failed]
          }
        }
        if (lVar2 != null) {
          Selectable.set_interactable(lVar2,0,0);
          return;
        }
    }

    // Token : 0x60021C3
    // RVA   : 0xB89C80   Offset: 0xB88480   Length: 0x11B1
    public void ManageAttackGenerate()
    {
        var pStatics = *(int64*)(DAT_181d82df0 + 184);
        bool cVar2;
        int iVar3;
        int iVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        long lVar8;
        uint uVar11;
        long lVar12;
        float fVar13;
        uint uVar14;
        ulong uVar15;
        float fVar16;
        uint local_238;
        uint uStack_234;
        uint local_230;
        ulong local_228;
        ulong uStack_220;
        ulong local_218;
        float local_210;
        ulong local_208;
        float local_200;
        uint64 local_1f8;
        float local_1f0;
        uint64 local_1e8;
        float local_1e0;
        uint64 local_1d8;
        float local_1d0;
        uint64 local_1c8;
        float local_1c0;
        uint8 local_1b8 [8];
        float local_1b0;
        uint64 local_1a8;
        float local_1a0;
        uint64 local_198;
        uint32 local_190;
        uint64 local_188;
        float local_180;
        float local_170;
        uint64 local_168;
        float local_160;
        float local_150;
        uint64 local_148;
        float local_140;
        uint8 local_138 [16];
        uint8 local_128 [16];
        uint8 local_118 [16];
        uint8 local_108 [16];
        uint8 local_f8 [16];
        uint8 local_e8 [16];
        uint8 local_d8 [16];
        uint8 local_c8 [16];
        uint8 local_b8 [16];
        uint8 local_a8 [128];
        fVar16 = this.generateStarTime;
        fVar13 = (float)Time.get_deltaTime(0);
        fVar16 = fVar16 - fVar13;
        this.generateStarTime = fVar16;
        if (fVar16 <= 0.0) {
          uVar14 = Random.Range();
          this.generateStarTime = uVar14;
          fVar16 = (float)(this.mapHeight * this.mapWidth);
          uVar15 = Random.Range(fVar16 * 0.01,fVar16 * 0.02,0);
          uVar14 = Mathf.RoundToInt(uVar15,0);
          iVar3 = Mathf.Max(1,uVar14);
          lVar5 = il2cpp_internal(DAT_181d6e2b0);
          FUN_180f58a90(lVar5);
          lVar8 = this.gridPool;
          uVar11 = 0;
          if (lVar8 != null) {
            lVar12 = 32;
            while( true ) {
              if (lVar8.Count <= (int)uVar11) goto joined_r0x000180b89f8c;
              if (lVar8 == null) break;
              if (lVar8.Count <= uVar11) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              uVar15 = *(uint64 *)(lVar12 + lVar8._items);
              if (*pStatics == 0) break;
              uVar7 = *(uint64 *)(*pStatics + 24);
              cVar2 = Object.op_Inequality(uVar15,uVar7);
              if (cVar2) {
                if ((this.gridPool == null) ||
                   (uVar15 = FUN_180002f80(this.gridPool,uVar11,DAT_181d62178), lVar5 == null
                   )) break;
                FUN_181827900(lVar5,uVar15);
              }
              lVar8 = this.gridPool;
              uVar11 = uVar11 + 1;
              lVar12 = lVar12 + 8;
              if (lVar8 == null) break;
            }
          }
        }
        else {
        LAB_180b8a28d:
          if (this.availableGrids == null) goto LAB_180b8adac;
          if (0 < this.availableGrids.Count) {
            fVar16 = this.generateSpikeTime;
            fVar13 = (float)Time.get_deltaTime(0);
            fVar16 = fVar16 - fVar13;
            this.generateSpikeTime = fVar16;
            if (fVar16 <= 0.0) {
              if ((this.targetSkill == null) ||
                 (lVar8 = KungfuSkillLvData.DataBase(this.targetSkill,0)) == null)
              goto LAB_180b8adac;
              iVar3 = *(int *)(lVar8 + 52);
              if ((this.targetSkill == null) ||
                 (lVar8 = KungfuSkillLvData.DataBase(this.targetSkill,0)) == null)
              goto LAB_180b8adac;
              fVar16 = (float)Random.Range(0.5 - (float)iVar3 * 0.05);
              fVar13 = (float)Mathf.Max();
              this.generateSpikeTime = fVar13 * fVar16;
              fVar16 = (float)(this.mapHeight * this.mapWidth);
              uVar15 = Random.Range(fVar16 * 0.02,fVar16 * 0.04,0);
              uVar14 = Mathf.RoundToInt(uVar15,0);
              for (iVar3 = Mathf.Max(1,uVar14); 0 < iVar3; iVar3 = iVar3 + -1) {
                lVar8 = this.availableGrids;
                if (lVar8 == null) goto LAB_180b8adac;
                if (lVar8.Count < 1) break;
                uVar11 = FUN_180d8cf10(0,lVar8.Count,0);
                if (lVar8.Count <= uVar11) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar8 = lVar8._items[uVar11];
                if ((lVar8 == null) || (lVar5 = GameObject.GetComponent(lVar8,DAT_181da1bb0)) == null)
                goto LAB_180b8adac;
                *(uint8 *)(lVar5 + 32) = 1;
                lVar5 = GameObject.GetComponent(lVar8,DAT_181da1bb0);
                if (lVar5 == null) goto LAB_180b8adac;
                *(uint32 *)(lVar5 + 36) = 0x3f800000;
                if (this.availableGrids == null) goto LAB_180b8adac;
                FUN_181801c10(this.availableGrids,lVar8,DAT_181d61e78);
                if (this.attackingGrids == null) goto LAB_180b8adac;
                FUN_181827900(this.attackingGrids,lVar8);
              }
            }
          }
          fVar16 = this.generateArrowTime;
          fVar13 = (float)Time.get_deltaTime(0);
          fVar16 = fVar16 - fVar13;
          this.generateArrowTime = fVar16;
          if (0.0 < fVar16) {
            return;
          }
          uVar14 = Mathf.Max();
          this.generateArrowTime = uVar14;
          fVar16 = (float)Random.Range();
          if ((this.targetSkill == null) ||
             (lVar8 = KungfuSkillLvData.DataBase(this.targetSkill,0)) == null)
          goto LAB_180b8adac;
          iVar3 = Mathf.RoundToInt((float)*(int *)(lVar8 + 52) * 0.5 + fVar16,0);
          iVar4 = FUN_180d8cf10(0,4);
          lVar8 = il2cpp_internal(DAT_181d6e2b0);
          FUN_180f58a90(lVar8,DAT_181d61af8);
          puVar9 = (uint64 *)Vector3.get_zero(&local_228,0);
          local_230 = *(uint32 *)(puVar9 + 1);
          local_238 = (uint32)*puVar9;
          uStack_234 = (uint32)((uint64)*puVar9 >> 32);
          if (iVar4 == 0) {
            uVar11 = 0;
            local_238 = 0x3f800000;
            uStack_234 = 0;
            local_230 = 0;
            if (0 < this.mapHeight) {
              do {
                lVar5 = this.gridUnits;
                if (lVar5 == null) goto LAB_180b8adac;
                if (**(int **)(lVar5 + 16) == 0) {
                  uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar15,0);
                }
                if ((uint32)(*(int **)(lVar5 + 16))[4] <= uVar11) {
                  uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar15,0);
                }
                if (lVar8 == null) goto LAB_180b8adac;
                FUN_181827900(lVar8,lVar5[uVar11],
                              DAT_181d61bf8);
                uVar11 = uVar11 + 1;
              } while ((int)uVar11 < this.mapHeight);
              goto LAB_180b8a7e0;
            }
          }
          else if (iVar4 == 1) {
            uVar11 = 0;
            local_238 = 0xbf800000;
            uStack_234 = 0;
            local_230 = 0;
            if (0 < this.mapHeight) {
              do {
                lVar5 = this.gridUnits;
                if (lVar5 == null) goto LAB_180b8adac;
                lVar12 = (int64)this.mapWidth + -1;
                if (**(uint32 **)(lVar5 + 16) <= (uint32)lVar12) {
                  uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar15,0);
                }
                lVar6 = *(int64 *)(*(uint32 **)(lVar5 + 16) + 4);
                if ((uint32)lVar6 <= uVar11) {
                  uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar15,0);
                }
                if (lVar8 == null) goto LAB_180b8adac;
                FUN_181827900(lVar8,*(uint64 *)
                                     (lVar5 + 32 + (lVar6 * lVar12 + (int64)(int)uVar11) * 8),
                              DAT_181d61bf8);
                uVar11 = uVar11 + 1;
              } while ((int)uVar11 < this.mapHeight);
              goto LAB_180b8a7e0;
            }
          }
          else if (iVar4 == 2) {
            uVar11 = 0;
            local_238 = 0;
            uStack_234 = 0x3f800000;
            local_230 = 0;
            if (0 < this.mapWidth) {
              do {
                lVar5 = this.gridUnits;
                if (lVar5 == null) goto LAB_180b8adac;
                if (**(uint32 **)(lVar5 + 16) <= uVar11) {
                  uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar15,0);
                }
                lVar12 = *(int64 *)(*(uint32 **)(lVar5 + 16) + 4);
                if ((int)lVar12 == null) {
                  uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar15,0);
                }
                if (lVar8 == null) goto LAB_180b8adac;
                FUN_181827900(lVar8,*(uint64 *)(lVar5 + 32 + (int)uVar11 * lVar12 * 8),DAT_181d61bf8
                             );
                uVar11 = uVar11 + 1;
              } while ((int)uVar11 < this.mapWidth);
              goto LAB_180b8a7e0;
            }
          }
          else if (iVar4 == 3) {
            uVar11 = 0;
            uStack_234 = 0xbf800000;
            local_238 = 0;
            local_230 = 0;
            if (0 < this.mapWidth) {
              do {
                lVar5 = this.gridUnits;
                if (lVar5 == null) goto LAB_180b8adac;
                lVar12 = (int64)this.mapHeight + -1;
                if (**(uint32 **)(lVar5 + 16) <= uVar11) {
                  uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar15,0);
                }
                lVar6 = *(int64 *)(*(uint32 **)(lVar5 + 16) + 4);
                if ((uint32)lVar6 <= (uint32)lVar12) {
                  uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar15,0);
                }
                if (lVar8 == null) goto LAB_180b8adac;
                FUN_181827900(lVar8,*(uint64 *)(lVar5 + 32 + ((int)uVar11 * lVar6 + lVar12) * 8),
                              DAT_181d61bf8);
                uVar11 = uVar11 + 1;
              } while ((int)uVar11 < this.mapWidth);
              goto LAB_180b8a7e0;
            }
          }
          if (lVar8 != null) {
        LAB_180b8a7e0:
            do {
              if ((lVar8.Count < 1) || (iVar3 < 1)) {
                return;
              }
              iVar3 = iVar3 + -1;
              uVar15 = this.studyDodgeGridRoot;
              uVar7 = this.studyDodgeArrowPrefab;
              lVar5 = GlobalData.AddChild(uVar15,uVar7,0);
              this.newObj = lVar5;
              uVar14 = FUN_180d8cf10(0,lVar8.Count,0);
              lVar5 = FUN_180002f80(lVar8,uVar14,DAT_181d62178);
              FUN_181801c10(lVar8,lVar5,DAT_181d61e78);
              if (iVar4 == 0) {
                if (((*plVar1 == 0) || (lVar12 = GameObject.get_transform(*plVar1,0), lVar5 == null)) ||
                   (lVar5 = GameObject.get_transform(lVar5,0)) == null) break;
                puVar9 = (uint64 *)Transform.get_localPosition(local_108,lVar5,0);
                local_228 = *puVar9;
                local_1b0 = *(float *)(puVar9 + 1);
                uStack_220 = CONCAT44((int)((uint64)uStack_220 >> 32),local_1b0);
                local_1e8 = CONCAT44((float)((uint64)local_228 >> 32) - 0.0,(float)local_228 - 1.0);
                local_1e0 = local_1b0 - 0.0;
                if (lVar12 == null) break;
                local_1a8 = local_1e8;
                local_1a0 = local_1e0;
                Transform.set_localPosition(lVar12,&local_1a8,0);
                if (*plVar1 == 0) break;
                lVar5 = GameObject.get_transform(*plVar1,0);
                puVar10 = local_a8;
        LAB_180b8abfb:
                puVar9 = (uint64 *)Quaternion.Euler(puVar10);
                if (lVar5 == null) break;
                local_228 = *puVar9;
                uStack_220 = puVar9[1];
                Transform.set_localRotation(lVar5,&local_228,0);
              }
              else {
                if (iVar4 == 1) {
                  if (((*plVar1 != 0) && (lVar12 = GameObject.get_transform(*plVar1,0), lVar5 != null)) &&
                     (lVar5 = GameObject.get_transform(lVar5,0)) != null) {
                    puVar9 = (uint64 *)Transform.get_localPosition(local_118,lVar5,0);
                    local_228 = *puVar9;
                    local_150 = *(float *)(puVar9 + 1);
                    uStack_220 = CONCAT44((int)((uint64)uStack_220 >> 32),local_150);
                    local_1f8 = CONCAT44((float)((uint64)local_228 >> 32) + 0.0,
                                         (float)local_228 + 1.0);
                    local_1f0 = local_150 + 0.0;
                    if (lVar12 != null) {
                      local_148 = local_1f8;
                      local_140 = local_1f0;
                      Transform.set_localPosition(lVar12,&local_148,0);
                      if (*plVar1 != 0) {
                        lVar5 = GameObject.get_transform(*plVar1,0);
                        puVar10 = local_b8;
                        goto LAB_180b8abfb;
                      }
                    }
                  }
                  break;
                }
                if (iVar4 == 2) {
                  if (((*plVar1 != 0) && (lVar12 = GameObject.get_transform(*plVar1,0), lVar5 != null)) &&
                     (lVar5 = GameObject.get_transform(lVar5,0)) != null) {
                    puVar9 = (uint64 *)Transform.get_localPosition(local_128,lVar5,0);
                    local_228 = *puVar9;
                    local_170 = *(float *)(puVar9 + 1);
                    uStack_220 = CONCAT44((int)((uint64)uStack_220 >> 32),local_170);
                    local_208 = CONCAT44((float)((uint64)local_228 >> 32) - 1.0,
                                         (float)local_228 - 0.0);
                    local_200 = local_170 - 0.0;
                    if (lVar12 != null) {
                      local_168 = local_208;
                      local_160 = local_200;
                      Transform.set_localPosition(lVar12,&local_168,0);
                      if (*plVar1 != 0) {
                        lVar5 = GameObject.get_transform(*plVar1,0);
                        puVar10 = local_c8;
                        goto LAB_180b8abfb;
                      }
                    }
                  }
                  break;
                }
                if (iVar4 == 3) {
                  if (((*plVar1 != 0) && (lVar12 = GameObject.get_transform(*plVar1,0), lVar5 != null)) &&
                     (lVar5 = GameObject.get_transform(lVar5,0)) != null) {
                    puVar9 = (uint64 *)Transform.get_localPosition(local_138,lVar5,0);
                    local_228 = *puVar9;
                    local_1c0 = *(float *)(puVar9 + 1);
                    uStack_220 = CONCAT44((int)((uint64)uStack_220 >> 32),local_1c0);
                    local_218 = CONCAT44((float)((uint64)local_228 >> 32) + 1.0,
                                         (float)local_228 + 0.0);
                    local_210 = local_1c0 + 0.0;
                    if (lVar12 != null) {
                      local_188 = local_218;
                      local_180 = local_210;
                      Transform.set_localPosition(lVar12,&local_188,0);
                      if (*plVar1 != 0) {
                        lVar5 = GameObject.get_transform(*plVar1,0);
                        puVar10 = local_d8;
                        goto LAB_180b8abfb;
                      }
                    }
                  }
                  break;
                }
              }
              if (*plVar1 == 0) break;
              lVar5 = GameObject.get_transform(*plVar1,0);
              if ((*plVar1 == 0) || (lVar12 = GameObject.get_transform(*plVar1,0)) == null) break;
              puVar9 = (uint64 *)Transform.get_localPosition(local_f8,lVar12,0);
              uVar15 = *puVar9;
              uVar14 = *(uint32 *)(puVar9 + 1);
              local_198 = uVar15;
              local_190 = uVar14;
              puVar9 = (uint64 *)GlobalData.SetZ(local_e8,&local_198,0xbdcccccd,0);
              if (lVar5 == null) break;
              local_1d8 = *puVar9;
              local_1d0 = *(float *)(puVar9 + 1);
              Transform.set_localPosition(lVar5,&local_1d8,0);
              if ((*plVar1 == 0) || (lVar5 = GameObject.GetComponent(*plVar1,DAT_181da1b30)) == null)
              break;
              *(uint64 *)(lVar5 + 40) = CONCAT44(uStack_234,local_238);
              *(uint32 *)(lVar5 + 48) = local_230;
              if (this.movingArrows == null) break;
              FUN_181827900(this.movingArrows,*plVar1);
            } while( true );
          }
        }
        LAB_180b8adac:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        joined_r0x000180b89f8c:
        if (iVar3 < 1) goto LAB_180b8a28d;
        if (lVar5 == null) goto LAB_180b8adac;
        if (*(int *)(lVar5 + 24) < 1) goto LAB_180b8a28d;
        lVar12 = new c.DisplayClass9_0(0);
        lVar8 = this.availableGrids;
        iVar3 = iVar3 + -1;
        if (lVar8 == null) goto LAB_180b8adac;
        uVar11 = FUN_180d8cf10(0,lVar8.Count,0);
        if (lVar8.Count <= uVar11) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (this.availableGrids == null) goto LAB_180b8adac;
        lVar8 = lVar8._items[uVar11];
        FUN_181801c10(this.availableGrids,lVar8,DAT_181d61e78);
        uVar15 = this.studyDodgeGridRoot;
        lVar6 = FUN_18046c660(0);
        if (lVar6 == null) goto LAB_180b8adac;
        uVar7 = StudySkillController.GetRandomStarPrefab(lVar6,0);
        uVar15 = GlobalData.AddChild(uVar15,uVar7,0);
        if (lVar12 == null) goto LAB_180b8adac;
        *(uint64 *)(lVar12 + 16) = uVar15;
        if (((*(int64 *)(lVar12 + 16) == 0) ||
            (lVar6 = GameObject.get_transform(*(int64 *)(lVar12 + 16),0), lVar8 == null)) ||
           (lVar8 = GameObject.get_transform(lVar8,0)) == null) goto LAB_180b8adac;
        puVar9 = (uint64 *)Transform.get_localPosition(&local_228,lVar8,0);
        local_1e8 = *puVar9;
        local_1e0 = *(float *)(puVar9 + 1);
        local_1d8 = local_1e8;
        local_1d0 = local_1e0;
        if (lVar6 == null) goto LAB_180b8adac;
        local_1f8 = CONCAT44((float)((uint64)local_1e8 >> 32) + 0.0,(float)local_1e8 + 0.0);
        local_1f0 = local_1e0 - 0.01;
        Transform.set_localPosition(lVar6,&local_1f8,0);
        if (*(int64 *)(lVar12 + 16) == 0) goto LAB_180b8adac;
        lVar8 = GameObject.get_transform(*(int64 *)(lVar12 + 16),0);
        puVar9 = (uint64 *)Vector3.get_zero(&local_198,0);
        if (lVar8 == null) goto LAB_180b8adac;
        local_200 = *(float *)(puVar9 + 1);
        local_208 = *puVar9;
        Transform.set_localScale(lVar8,&local_208,0);
        if (*(int64 *)(lVar12 + 16) == 0) goto LAB_180b8adac;
        uVar15 = GameObject.get_transform(*(int64 *)(lVar12 + 16),0);
        puVar9 = (uint64 *)Vector3.get_one(&local_1a8,0);
        local_210 = *(float *)(puVar9 + 1);
        local_218 = *puVar9;
        ShortcutExtensions.DOScale(uVar15,&local_218,0x3e4ccccd,0);
        if (*(int64 *)(lVar12 + 16) == 0) goto LAB_180b8adac;
        uVar15 = GameObject.get_transform(*(int64 *)(lVar12 + 16),0);
        puVar9 = (uint64 *)Vector3.get_zero(local_1b8,0);
        local_1c0 = *(float *)(puVar9 + 1);
        local_1c8 = *puVar9;
        uVar15 = ShortcutExtensions.DOScale(uVar15,&local_1c8,0x3e4ccccd,0);
        uVar15 = TweenSettingsExtensions.SetDelay(uVar15);
        uVar7 = new OnTooltipCB(lVar12,DAT_181d8b710);
        TweenSettingsExtensions.OnComplete(uVar15);
        goto joined_r0x000180b89f8c;
    }

    // Token : 0x60021C4
    // RVA   : 0xB89720   Offset: 0xB87F20   Length: 0x55E
    private void InitStudyDodgeGround()
    {
        var plVar2 = *(int64*)(lVar2 + 184);
        var pStatics = *(int64*)(DAT_181d82e70 + 184);
        long lVar2;
        ulong uVar3;
        ulong uVar5;
        int iVar6;
        long lVar7;
        long lVar8;
        int iVar9;
        int[] local_res18 = new int[2];
        int[] local_res20 = new int[2];
        float local_68;
        float local_64;
        uint local_60;
        ulong local_58;
        uint local_50;
        long local_48;
        long local_40;
        lVar2 = *pStatics;
        if (lVar2 != null) {
          if (*(uint32 *)(lVar2 + 24) < 6) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = *(int64 *)(*(int64 *)(lVar2 + 16) + 72);
          if (lVar2 != null) {
            if (*(int *)(lVar2 + 24) == 0) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            iVar9 = *(int *)(*(int64 *)(lVar2 + 16) + 32);
            lVar2 = *pStatics;
            if (lVar2 != null) {
              if (*(uint32 *)(lVar2 + 24) < 6) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(*(int64 *)(lVar2 + 16) + 72);
              if (lVar2 != null) {
                if (*(uint32 *)(lVar2 + 24) < 2) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                local_40 = (int64)*(int *)(*(int64 *)(lVar2 + 16) + 36);
                local_48 = (int64)iVar9;
                lVar2 = FUN_1800d6020(DAT_181d848c0,&local_48);
                this.gridUnits = lVar2;
                uVar3 = il2cpp_internal(DAT_181d6e2b0);
                FUN_180f58a90(uVar3,DAT_181d61af8);
                this.gridPool = uVar3;
                iVar9 = 0;
                lVar2 = DAT_181d82e70;
                while( true ) {
                  if (((*(byte *)(lVar2 + 0x133) & 4) != 0) && (*(int *)(lVar2 + 224) == 0)) {
                    il2cpp_runtime_class_init();
                    lVar2 = DAT_181d82e70;
                  }
                  lVar7 = *plVar2;
                  if (lVar7 == null) break;
                  if (*(uint32 *)(lVar7 + 24) < 6) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    lVar2 = DAT_181d82e70;
                  }
                  lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 72);
                  if (lVar7 == null) break;
                  if (*(uint32 *)(lVar7 + 24) < 2) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    lVar2 = DAT_181d82e70;
                  }
                  if (*(int *)(*(int64 *)(lVar7 + 16) + 36) <= iVar9) {
                    return;
                  }
                  iVar6 = 0;
                  while( true ) {
                    if (((*(byte *)(lVar2 + 0x133) & 4) != 0) && (*(int *)(lVar2 + 224) == 0)) {
                      il2cpp_runtime_class_init();
                      lVar2 = DAT_181d82e70;
                    }
                    lVar7 = *plVar2;
                    if (lVar7 == null) goto LAB_180b89c73;
                    if (*(uint32 *)(lVar7 + 24) < 6) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      lVar2 = DAT_181d82e70;
                    }
                    lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 72);
                    if (lVar7 == null) goto LAB_180b89c73;
                    if (*(int *)(lVar7 + 24) == 0) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      lVar2 = DAT_181d82e70;
                    }
                    if (*(int *)(*(int64 *)(lVar7 + 16) + 32) <= iVar6) break;
                    lVar2 = *plVar1;
                    uVar3 = this.studyDodgeGridRoot;
                    uVar5 = this.studyDodgeTilePrefab;
                    uVar3 = GlobalData.AddChild(uVar3,uVar5,0);
                    if (lVar2 == null) {
        LAB_180b89c6d:
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    lVar8 = (int64)iVar9;
                    lVar7 = (int64)iVar6;
                    FUN_180127fe0(lVar2,lVar7,lVar8,uVar3);
                    if (*plVar1 == 0) goto LAB_180b89c6d;
                    lVar2 = FUN_180127f50(*plVar1,lVar7,lVar8);
                    if (lVar2 == null) goto LAB_180b89c6d;
                    lVar2 = GameObject.get_transform(lVar2,0);
                    puVar4 = (uint64 *)Vector3.get_one(&local_48,0);
                    if (lVar2 == null) goto LAB_180b89c6d;
                    local_50 = *(uint32 *)(puVar4 + 1);
                    local_58 = *puVar4;
                    Transform.set_localScale(lVar2,&local_58,0);
                    if (*plVar1 == 0) goto LAB_180b89c6d;
                    lVar2 = FUN_180127f50(*plVar1,lVar7,lVar8);
                    if (lVar2 == null) goto LAB_180b89c6d;
                    lVar2 = GameObject.get_transform(lVar2,0);
                    if (lVar2 == null) goto LAB_180b89c6d;
                    local_60 = 0;
                    local_68 = (float)iVar6;
                    local_64 = (float)iVar9;
                    Transform.set_localPosition(lVar2,&local_68,0);
                    if (*plVar1 == 0) goto LAB_180b89c6d;
                    lVar2 = FUN_180127f50(*plVar1,lVar7,lVar8);
                    local_res18[0] = iVar9;
                    uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
                    local_res20[0] = iVar6;
                    uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
                    uVar3 = String.Format("{0}_{1}",uVar3,uVar5,0);
                    if (lVar2 == null) goto LAB_180b89c6d;
                    Object.set_name(lVar2,uVar3,0);
                    if (*plVar1 == 0) goto LAB_180b89c6d;
                    lVar2 = FUN_180127f50(*plVar1,lVar7,lVar8);
                    if (lVar2 == null) goto LAB_180b89c6d;
                    GameObject.SetActive(lVar2,0,0);
                    if (*plVar1 == 0) goto LAB_180b89c6d;
                    lVar2 = FUN_180127f50(*plVar1,lVar7,lVar8);
                    if (lVar2 == null) goto LAB_180b89c6d;
                    lVar2 = GameObject.GetComponent(lVar2,DAT_181da1bb0);
                    if (lVar2 == null) goto LAB_180b89c6d;
                    *(int *)(lVar2 + 24) = iVar6;
                    if (*plVar1 == 0) goto LAB_180b89c6d;
                    lVar2 = FUN_180127f50(*plVar1,lVar7);
                    if (lVar2 == null) goto LAB_180b89c6d;
                    lVar2 = GameObject.GetComponent(lVar2,DAT_181da1bb0);
                    if (lVar2 == null) goto LAB_180b89c6d;
                    *(int *)(lVar2 + 28) = iVar9;
                    iVar6 = iVar6 + 1;
                    lVar2 = DAT_181d82e70;
                  }
                  iVar9 = iVar9 + 1;
                }
        LAB_180b89c73:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
            }
          }
        }
    }

    // Token : 0x60021C5
    // RVA   : 0xB8AFC0   Offset: 0xB897C0   Length: 0x2FE
    public void StartStudyDodgeSkill(KungfuSkillLvData target)
    {
        var pStatics_2e70 = *(int64*)(DAT_181d82e70 + 184);
        var pStatics_2f70 = *(int64*)(DAT_181d82f70 + 184);
        uint uVar1;
        long lVar2;
        long lVar3;
        if (!this.inited) {
          StudyDodgeSkillController.InitStudyDodgeGround(this,0);
          this.inited = 1;
        }
        if (this.studyDodgeSkillRoot != null) {
          GameObject.SetActive(this.studyDodgeSkillRoot,1,0);
          if (this.studyDodgeSkillUIRoot != null) {
            GameObject.SetActive(this.studyDodgeSkillUIRoot,1,0);
            if ((*pStatics_2f70 != 0) &&
               (lVar2 = *(int64 *)(*pStatics_2f70 + 96)) != null) {
              GameObject.SetActive(lVar2,1,0);
              this.inStudy = 1;
              this.targetSkill = target;
              this.totalExp = 0;
              if (this.targetSkill != null) {
                lVar2 = KungfuSkillLvData.DataBase(this.targetSkill,0);
                if (lVar2 != null) {
                  this.leftTime = (float)*(int *)(lVar2 + 52) * 3.0 + 20.0;
                  StudyDodgeSkillController.ResetCombo(this,0);
                  this.comboTime = 0x3f800000;
                  this.skillUsed = 0;
                  lVar2 = *pStatics_2e70;
                  if (this.targetSkill != null) {
                    lVar3 = KungfuSkillLvData.DataBase(this.targetSkill,0);
                    if ((lVar3 != null) && (lVar2 != null)) {
                      uVar1 = *(uint32 *)(lVar3 + 52);
                      if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar2 = lVar2[uVar1]
                      ;
                      if (lVar2 != null) {
                        if (*(int *)(lVar2 + 24) == 0) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        this.mapWidth =
                             *(uint32 *)(*(int64 *)(lVar2 + 16) + 32);
                        lVar2 = *pStatics_2e70;
                        if (this.targetSkill != null) {
                          lVar3 = KungfuSkillLvData.DataBase(this.targetSkill,0);
                          if ((lVar3 != null) && (lVar2 != null)) {
                            uVar1 = *(uint32 *)(lVar3 + 52);
                            if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                            }
                            lVar2 = *(int64 *)
                                     (*(int64 *)(lVar2 + 16) + 32 + (int64)(int)uVar1 * 8);
                            if (lVar2 != null) {
                              if (*(uint32 *)(lVar2 + 24) < 2) {
                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                              }
                              this.mapHeight =
                                   *(uint32 *)(*(int64 *)(lVar2 + 16) + 36);
                              this.generateSpikeTime = 0x3fc00000;
                              this.generateArrowTime = 0x3fc00000;
                              StudyDodgeSkillController.GenerateStudyDodgePanel(this,0);
                              MonoBehaviour.Invoke(this,"StartDodgeTutorial",0x3f800000,0);
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

    // Token : 0x60021C6
    // RVA   : 0xB8AF50   Offset: 0xB89750   Length: 0x6A
    public void StartDodgeTutorial()
    {
        var pStatics = *(int64*)(DAT_181d88ad8 + 184);
        if (*pStatics != 0) {
          TutorialController.StartTutorial(*pStatics,"修炼轻功",0);
          return;
        }
    }

    // Token : 0x60021C7
    // RVA   : 0xB890C0   Offset: 0xB878C0   Length: 0x656
    public void GenerateStudyDodgePanel()
    {
        var pStatics_2df0 = *(int64*)(DAT_181d82df0 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        float fVar1;
        bool cVar2;
        long lVar3;
        long lVar4;
        ulong uVar6;
        int iVar8;
        int iVar9;
        ulong local_68;
        float local_60;
        ulong local_58;
        float local_50;
        byte[] local_48 = new byte[16];
        byte[] local_38 = new byte[48];
        if (this.availableGrids != null) {
          FUN_180f56130(this.availableGrids,DAT_181d61c78);
          if (this.attackingGrids != null) {
            FUN_180f56130(this.attackingGrids,DAT_181d61c78);
            if (this.movingArrows != null) {
              FUN_180f56130(this.movingArrows,DAT_181d61c78);
              if (this.studyDodgeGridRoot != null) {
                lVar3 = GameObject.get_transform(this.studyDodgeGridRoot,0);
                iVar9 = this.mapWidth;
                iVar8 = this.mapHeight;
                if ((this.studyDodgeGridRoot != null) &&
                   (lVar4 = GameObject.get_transform(this.studyDodgeGridRoot,0)) != null) {
                  pfVar5 = (float *)Transform.get_localScale(local_48,lVar4,0);
                  fVar1 = *pfVar5;
                  local_60 = fVar1 * 0.0;
                  local_68 = CONCAT44(fVar1 * (float)(iVar8 + -1) * -0.5,
                                      fVar1 * (float)(iVar9 + -1) * -0.5);
                  if (lVar3 != null) {
                    local_58 = local_68;
                    local_50 = local_60;
                    Transform.set_localPosition(lVar3,&local_58,0);
                    iVar9 = 0;
                    if (0 < this.mapHeight) {
                      do {
                        iVar8 = 0;
                        if (0 < this.mapWidth) {
                          do {
                            if (this.gridUnits == null) throw; // [null/range check failed]
                            lVar3 = FUN_180127f50(this.gridUnits,(int64)iVar8,
                                                  (int64)iVar9);
                            if (lVar3 == null) throw; // [null/range check failed]
                            GameObject.SetActive(lVar3,1,0);
                            if (this.gridPool == null) throw; // [null/range check failed]
                            FUN_181827900(this.gridPool,lVar3,DAT_181d61bf8);
                            if (this.availableGrids == null) throw; // [null/range check failed]
                            FUN_181827900(this.availableGrids,lVar3,DAT_181d61bf8);
                            iVar8 = iVar8 + 1;
                          } while (iVar8 < this.mapWidth);
                        }
                        iVar9 = iVar9 + 1;
                      } while (iVar9 < this.mapHeight);
                    }
                    if (*pStatics_2df0 != 0) {
                      uVar6 = *(uint64 *)(*pStatics_2df0 + 32);
                      cVar2 = Object.op_Equality(uVar6,0,0);
                      if (!cVar2) {
                        lVar3 = FUN_18046c0a0(0);
                        if ((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) throw; // [null/range check failed]
                        lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0);
                        if ((*pStatics_2df0 == 0) || (lVar3 == null))
                        throw; // [null/range check failed]
                        HeroData.RefreshHeroSkeleton
                                  (lVar3,*(uint64 *)(*pStatics_2df0 + 32),0);
                      }
                      else {
                        lVar3 = *pStatics_2df0;
                        if ((*pStatics_df90 == 0) ||
                           (lVar4 = *(int64 *)(*pStatics_df90 + 32),
                           lVar4 == null)) throw; // [null/range check failed]
                        lVar4 = WorldData.Player(lVar4,0);
                        if (*pStatics_2df0 == 0) throw; // [null/range check failed]
                        uVar6 = Component.get_gameObject(*pStatics_2df0,0);
                        puVar7 = (uint64 *)Vector3.get_one(local_38,0);
                        local_58 = *puVar7;
                        local_50 = *(float *)(puVar7 + 1);
                        local_60 = local_50 * 0.5;
                        local_68 = CONCAT44((float)((uint64)local_58 >> 32) * 0.5,
                                            (float)local_58 * 0.5);
                        if (lVar4 == null) throw; // [null/range check failed]
                        local_58 = local_68;
                        local_50 = local_60;
                        uVar6 = HeroData.GenerateHeroSkeleton(lVar4,uVar6,&local_58,0);
                        if (lVar3 == null) throw; // [null/range check failed]
                        puVar7 = (uint64 *)(lVar3 + 32);
                        *puVar7 = uVar6;
                        il2cpp_internal(puVar7,uVar6);
                        if (((*pStatics_2df0 == 0) ||
                            (lVar3 = *(int64 *)(*pStatics_2df0 + 32),
                            lVar3 == null)) || (lVar3 = Component.get_transform(lVar3,0)) == null)
                        throw; // [null/range check failed]
                        local_60 = -0.1;
                        local_68 = 0;
                        Transform.set_localPosition(lVar3,&local_68,0);
                      }
                      if (((*pStatics_2df0 != 0) &&
                          (lVar3 = *(int64 *)(*pStatics_2df0 + 32), lVar3 != null
                          )) && (lVar3 = SkeletonAnimation.get_AnimationState(lVar3,0)) != null) {
                        AnimationState.SetAnimation(lVar3,0,"idle",1,0);
                        if (*pStatics_2df0 != 0) {
                          StudyDodgePlayer.PlayerEnterGrid
                                    (*pStatics_2df0,
                                     (int)((float)(this.mapWidth + -1) * 0.5),
                                     (int)((float)(this.mapHeight + -1) * 0.5),0);
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

    // Token : 0x60021C8
    // RVA   : 0xB8B670   Offset: 0xB89E70   Length: 0x14F
    public void UseSlowTimeSkill()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        long lVar2;
        this.skillUsed = 1;
        lVar1 = **(int64 **)(DAT_181d86c68 + 184);
        if ((*pStatics != 0) &&
           (lVar2 = *(int64 *)(*pStatics + 32)) != null) {
          lVar2 = WorldData.Player(lVar2,0);
          if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 0x150)) != null) {
            if (*(uint32 *)(lVar2 + 24) < 2) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (lVar1 != null) {
              TimeScaleController.SetSlowTime
                        (lVar1,*(float *)(*(int64 *)(lVar2 + 16) + 36) * 0.04 + 1.0,0x3e4ccccd,0);
              return;
            }
          }
        }
    }

    // Token : 0x60021C9
    // RVA   : 0xB89010   Offset: 0xB87810   Length: 0x28
    public void FinishButtonClicked()
    {
        ulong uVar1;
        uVar1 = StudyDodgeSkillController.FinishStudyDodgeSkill(this,1);
        FUN_180d837c0(this,uVar1,0);
    }

    // Token : 0x60021CA
    // RVA   : 0xB89040   Offset: 0xB87840   Length: 0x7B
    public IEnumerator FinishStudyDodgeSkill(StudySkillResult studyDodgeResult)
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          *(uint32 *)(lVar1 + 40) = studyDodgeResult;
          return lVar1;
        }
    }

    // Token : 0x60021CB
    // RVA   : 0xB88E30   Offset: 0xB87630   Length: 0x1DB
    public void ChangeCombo(int num)
    {
        var pStatics = *(int64*)(DAT_181d82f70 + 184);
        long lVar1;
        ulong uVar3;
        uint uVar4;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        this.combo = this.combo + num;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 88)) != null) {
          lVar1 = Component.get_transform(lVar1,0);
          if (lVar1 != null) {
            lVar1 = FUN_180da0f00(lVar1,0);
            puVar2 = (uint64 *)Vector3.get_one(local_18,0);
            if (lVar1 != null) {
              local_20 = *(uint32 *)(puVar2 + 1);
              local_28 = *puVar2;
              Transform.set_localScale(lVar1,&local_28,0);
              if ((*pStatics != 0) &&
                 (lVar1 = *(int64 *)(*pStatics + 88)) != null) {
                lVar1 = Component.get_transform(lVar1,0);
                if (lVar1 != null) {
                  uVar3 = FUN_180da0f00(lVar1,0);
                  if (num < 1) {
                    uVar4 = 0x3f333333;
                  }
                  else {
                    uVar4 = 0x3fa66666;
                  }
                  uVar3 = ShortcutExtensions.DOScale(uVar3,uVar4,0x3dcccccd,0);
                  TweenSettingsExtensions.SetLoops(uVar3,2,1,DAT_181d98060);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x60021CC
    // RVA   : 0xB8AE40   Offset: 0xB89640   Length: 0x106
    public void ResetCombo()
    {
        var pStatics = *(int64*)(DAT_181d82f70 + 184);
        long lVar1;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        this.combo = 0;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 88)) != null) {
          lVar1 = Component.get_transform(lVar1,0);
          if (lVar1 != null) {
            lVar1 = FUN_180da0f00(lVar1,0);
            puVar2 = (uint64 *)Vector3.get_zero(local_18,0);
            if (lVar1 != null) {
              local_20 = *(uint32 *)(puVar2 + 1);
              local_28 = *puVar2;
              Transform.set_localScale(lVar1,&local_28,0);
              return;
            }
          }
        }
    }

    // Token : 0x60021CD
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x60021CE
    // RVA   : 0xB8B7C0   Offset: 0xB89FC0   Length: 0x2FF
    private static void /*cctor*/()
    {
        long lVar2;
        long lVar3;
        lVar2 = il2cpp_internal(DAT_181d6b5b0);
        FUN_180f58a90(lVar2,DAT_181d51488);
        lVar3 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(lVar3,DAT_181d678f8);
        if (lVar3 != null) {
          FUN_181814fa0(lVar3,5,DAT_181d67a78);
          FUN_181814fa0(lVar3,5,DAT_181d67a78);
          if (lVar2 != null) {
            FUN_181827900(lVar2,lVar3,DAT_181d51508);
            lVar3 = il2cpp_internal(DAT_181d6f030);
            FUN_180f58a90(lVar3,DAT_181d678f8);
            if (lVar3 != null) {
              FUN_181814fa0(lVar3,7,DAT_181d67a78);
              FUN_181814fa0(lVar3,5,DAT_181d67a78);
              FUN_181827900(lVar2,lVar3,DAT_181d51508);
              lVar3 = il2cpp_internal(DAT_181d6f030);
              FUN_180f58a90(lVar3,DAT_181d678f8);
              if (lVar3 != null) {
                FUN_181814fa0(lVar3,7,DAT_181d67a78);
                FUN_181814fa0(lVar3,7,DAT_181d67a78);
                FUN_181827900(lVar2,lVar3,DAT_181d51508);
                lVar3 = il2cpp_internal(DAT_181d6f030);
                FUN_180f58a90(lVar3,DAT_181d678f8);
                if (lVar3 != null) {
                  FUN_181814fa0(lVar3,9,DAT_181d67a78);
                  FUN_181814fa0(lVar3,7,DAT_181d67a78);
                  FUN_181827900(lVar2,lVar3,DAT_181d51508);
                  lVar3 = il2cpp_internal(DAT_181d6f030);
                  FUN_180f58a90(lVar3,DAT_181d678f8);
                  if (lVar3 != null) {
                    FUN_181814fa0(lVar3,9,DAT_181d67a78);
                    FUN_181814fa0(lVar3,9,DAT_181d67a78);
                    FUN_181827900(lVar2,lVar3,DAT_181d51508);
                    lVar3 = il2cpp_internal(DAT_181d6f030);
                    FUN_180f58a90(lVar3,DAT_181d678f8);
                    if (lVar3 != null) {
                      FUN_181814fa0(lVar3,11,DAT_181d67a78);
                      FUN_181814fa0(lVar3,9,DAT_181d67a78);
                      FUN_181827900(lVar2,lVar3,DAT_181d51508);
                      plVar1 = *(int64 **)(DAT_181d82e70 + 184);
                      *plVar1 = lVar2;
                      il2cpp_internal(plVar1,lVar2);
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
