// ============================================================
// Type  : SkillRangeUIController
// Token : 0x2000358
// ============================================================

public class SkillRangeUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001AB3
    public GameObject SkillRangeOneGridPrefab;

    // Token: 0x4001AB4
    public KungfuSkillLvData targetSkill;

    // Token: 0x4001AB5
    private GameObject newObj;

    // Token: 0x4001AB6
    private List<List<int>> findGrid;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60020AE
    // RVA   : 0x9759B0   Offset: 0x9741B0   Length: 0x6FC
    public void RefreshSkillRange(KungfuSkillLvData _targetSkill)
    {
        long lVar1;
        long lVar2;
        ulong uVar3;
        int iVar4;
        uint[] local_res8 = new uint[2];
        this.targetSkill = _targetSkill;
        local_res8[0] = 0;
        lVar2 = Component.get_transform(this,0);
        uVar3 = Int32.ToString(local_res8,0);
        if (lVar2 == null) {
        LAB_18097609b:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar2 = Transform.Find(lVar2,uVar3,0);
        if (lVar2 == null) goto LAB_18097609b;
        lVar2 = Transform.Find(lVar2,"Grid",0);
        if (lVar2 == null) throw; // [null/range check failed]
        uVar3 = Component.get_gameObject(lVar2,0);
        GlobalData.DeleteAllChild(uVar3,0);
        local_res8[0] = 1;
        lVar2 = Component.get_transform(this,0);
        uVar3 = Int32.ToString(local_res8,0);
        if (lVar2 == null) {
        LAB_1809760a1:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        lVar2 = Transform.Find(lVar2,uVar3,0);
        if (lVar2 == null) goto LAB_1809760a1;
        lVar2 = Transform.Find(lVar2,"Grid",0);
        if (lVar2 == null) throw; // [null/range check failed]
        uVar3 = Component.get_gameObject(lVar2,0);
        GlobalData.DeleteAllChild(uVar3,0);
        if (this.targetSkill == null) throw; // [null/range check failed]
        lVar2 = KungfuSkillLvData.DataBase(this.targetSkill,0);
        if (lVar2 == null) throw; // [null/range check failed]
        if (*(int *)(lVar2 + 48) == 0) {
        LAB_180976004:
          lVar2 = Component.get_transform(this,0);
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2 = Transform.Find(lVar2,"0",0);
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2 = Component.get_gameObject(lVar2,0);
          if (lVar2 == null) throw; // [null/range check failed]
          GameObject.SetActive(lVar2,0,0);
        }
        else {
          if (this.targetSkill == null) throw; // [null/range check failed]
          lVar2 = KungfuSkillLvData.DataBase(this.targetSkill,0);
          if (lVar2 == null) throw; // [null/range check failed]
          if (*(int *)(lVar2 + 48) == 2) goto LAB_180976004;
          if (this.targetSkill == null) throw; // [null/range check failed]
          lVar2 = KungfuSkillLvData.DataBase(this.targetSkill,0);
          if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 112)) == null) throw; // [null/range check failed]
          if (*(int *)(lVar2 + 24) == 0) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = *(int64 *)(*(int64 *)(lVar2 + 16) + 32);
          if (lVar2 == null) throw; // [null/range check failed]
          if (*(int *)(lVar2 + 16) == 4) {
        LAB_180975e34:
            lVar2 = Component.get_transform(this,0);
            if (lVar2 != null) {
              lVar2 = Transform.Find(lVar2,"0",0);
              if (lVar2 != null) {
                lVar2 = Component.get_gameObject(lVar2,0);
                if (lVar2 != null) {
                  GameObject.SetActive(lVar2,1,0);
                  lVar2 = Component.get_transform(this,0);
                  if (lVar2 != null) {
                    lVar2 = Transform.Find(lVar2,"1",0);
                    if (lVar2 != null) {
                      lVar2 = Component.get_gameObject(lVar2,0);
                      if (lVar2 != null) {
                        GameObject.SetActive(lVar2,0,0);
                        lVar2 = Component.get_transform(this,0);
                        if (lVar2 != null) {
                          lVar2 = Transform.Find(lVar2,"0",0);
                          if (lVar2 != null) {
                            lVar2 = Transform.Find(lVar2,"Title",0);
                            if (lVar2 != null) {
                              uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
                              LTLocalization.SetText(uVar3,"作用范围",0);
                              if (this.targetSkill != null) {
                                lVar2 = KungfuSkillLvData.DataBase(this.targetSkill,0);
                                if ((lVar2 != null) && (*(int64 *)(lVar2 + 120) != 0)) {
                                  lVar1 = this.targetSkill;
                                  if (*(int *)(*(int64 *)(lVar2 + 120) + 16) == 7) {
                                    if (lVar1 != null) {
                                      lVar2 = KungfuSkillLvData.DataBase(lVar1,0);
                                      if ((lVar2 != null) &&
                                         (lVar2 = *(int64 *)(lVar2 + 112)) != null) {
                                        if (*(int *)(lVar2 + 24) == 0) {
                                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                        }
                                        lVar2 = *(int64 *)(*(int64 *)(lVar2 + 16) + 32);
                                        if (lVar2 != null) {
                                          uVar3 = 0;
                                          iVar4 = *(int *)(lVar2 + 24) * 2 + 1;
                                          goto LAB_180975e1d;
                                        }
                                      }
                                    }
                                  }
                                  else if (lVar1 != null) {
                                    lVar2 = KungfuSkillLvData.DataBase(lVar1,0);
                                    if ((lVar2 != null) && (*(int64 *)(lVar2 + 120) != 0)) {
                                      iVar4 = *(int *)(*(int64 *)(lVar2 + 120) + 24) * 2 + 1;
                                      uVar3 = 0;
        LAB_180975e1d:
                                      SkillRangeUIController.RefreshSkillRangeGrid(this,uVar3,iVar4,0)
                                      ;
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
            throw; // [null/range check failed]
          }
          if (this.targetSkill == null) throw; // [null/range check failed]
          lVar2 = KungfuSkillLvData.DataBase(this.targetSkill,0);
          if ((lVar2 == null) || (*(int64 *)(lVar2 + 120) == 0)) throw; // [null/range check failed]
          if (*(int *)(*(int64 *)(lVar2 + 120) + 16) == 7) goto LAB_180975e34;
          lVar2 = Component.get_transform(this,0);
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2 = Transform.Find(lVar2,"0",0);
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2 = Component.get_gameObject(lVar2,0);
          if (lVar2 == null) throw; // [null/range check failed]
          GameObject.SetActive(lVar2,1,0);
          lVar2 = Component.get_transform(this,0);
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2 = Transform.Find(lVar2,"0",0);
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2 = Transform.Find(lVar2,"Title",0);
          if (lVar2 == null) throw; // [null/range check failed]
          uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
          LTLocalization.SetText(uVar3,"释放范围",0);
          if (this.targetSkill == null) throw; // [null/range check failed]
          lVar2 = KungfuSkillLvData.DataBase(this.targetSkill,0);
          if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 112)) == null) throw; // [null/range check failed]
          if (*(int *)(lVar2 + 24) == 0) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = *(int64 *)(*(int64 *)(lVar2 + 16) + 32);
          if (lVar2 == null) throw; // [null/range check failed]
          SkillRangeUIController.RefreshSkillRangeGrid(this,0,*(int *)(lVar2 + 24) * 2 + 1,0);
          if (this.targetSkill == null) throw; // [null/range check failed]
          lVar2 = KungfuSkillLvData.DataBase(this.targetSkill,0);
          if (lVar2 == null) throw; // [null/range check failed]
          if (*(int *)(lVar2 + 48) != 1) {
            lVar2 = Component.get_transform(this,0);
            if (lVar2 == null) throw; // [null/range check failed]
            lVar2 = Transform.Find(lVar2,"1",0);
            if (lVar2 == null) throw; // [null/range check failed]
            lVar2 = Component.get_gameObject(lVar2,0);
            if (lVar2 == null) throw; // [null/range check failed]
            GameObject.SetActive(lVar2,1,0);
            if (this.targetSkill == null) throw; // [null/range check failed]
            lVar2 = KungfuSkillLvData.DataBase(this.targetSkill,0);
            if ((lVar2 == null) || (*(int64 *)(lVar2 + 120) == 0)) throw; // [null/range check failed]
            iVar4 = *(int *)(*(int64 *)(lVar2 + 120) + 24) * 2 + 1;
            uVar3 = 1;
            goto LAB_180975e1d;
          }
        }
        lVar2 = Component.get_transform(this,0);
        if (lVar2 != null) {
          lVar2 = Transform.Find(lVar2,"1",0);
          if (lVar2 != null) {
            lVar2 = Component.get_gameObject(lVar2,0);
            if (lVar2 != null) {
              GameObject.SetActive(lVar2,0,0);
              return;
            }
          }
        }
    }

    // Token : 0x60020AF
    // RVA   : 0x974F60   Offset: 0x973760   Length: 0x76
    public Transform GetGrid(int id)
    {
        long lVar1;
        ulong uVar2;
        uint[] local_res10 = new uint[6];
        local_res10[0] = id;
        lVar1 = Component.get_transform(this,0);
        uVar2 = Int32.ToString(local_res10,0);
        if (lVar1 != null) {
          lVar1 = Transform.Find(lVar1,uVar2,0);
          if (lVar1 != null) {
            Transform.Find(lVar1,"Grid",0);
            return;
          }
        }
    }

    // Token : 0x60020B0
    // RVA   : 0x974FE0   Offset: 0x9737E0   Length: 0x9C2
    public void RefreshSkillRangeGrid(int id, int gridLineNum)
    {
        long lVar1;
        int iVar2;
        int iVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        byte uVar9;
        int iVar10;
        int iVar11;
        float fVar12;
        uint uVar13;
        uint uVar14;
        uint uVar15;
        uint uVar16;
        uint uVar17;
        uint uVar18;
        uint uVar19;
        uint uVar20;
        ulong in_stack_ffffffffffffff18;
        int local_c8;
        int local_c4;
        int local_c0;
        ulong local_b8;
        ulong uStack_b0;
        ulong local_a8;
        ulong uStack_a0;
        byte[] local_98 = new byte[16];
        byte[] local_88 = new byte[80];
        uVar17 = (uint32)((uint64)in_stack_ffffffffffffff18 >> 32);
        local_c0 = Mathf.RoundToInt((float)(gridLineNum + -1) * 0.5,0);
        lVar4 = this.targetSkill;
        if (id == null) {
          if (((lVar4 == null) || (lVar4 = KungfuSkillLvData.DataBase(lVar4,0)) == null) ||
             (lVar4 = *(int64 *)(lVar4 + 112)) == null) throw; // [null/range check failed]
          if (lVar4.fightExp == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar4 = *(int64 *)(lVar4.skillID + 32);
          if (lVar4 == null) throw; // [null/range check failed]
          lVar1 = this.targetSkill;
          if (lVar4.skillID == 4) {
            if ((((lVar1 == null) || (lVar4 = KungfuSkillLvData.DataBase(lVar1,0)) == null) ||
                ((*(int64 *)(lVar4 + 120) == 0 ||
                 ((this.targetSkill == null ||
                  (lVar4 = KungfuSkillLvData.DataBase(this.targetSkill,0)) == null)))))
               || (*(int64 *)(lVar4 + 120) == 0)) throw; // [null/range check failed]
            iVar2 = *(int *)(*(int64 *)(lVar4 + 120) + 16);
            if (iVar2 == 4) {
        LAB_180975435:
              uVar18 = 2;
            }
            else if (iVar2 == 5) {
              uVar18 = 4;
            }
            else if (iVar2 == 6) {
              uVar18 = 3;
            }
            else {
              if ((iVar2 == 7) || (iVar2 != 8)) goto LAB_180975435;
              uVar18 = 5;
            }
            if (((this.targetSkill == null) ||
                (lVar4 = KungfuSkillLvData.DataBase(this.targetSkill,0)) == null) ||
               (*(int64 *)(lVar4 + 120) == 0)) throw; // [null/range check failed]
            uVar19 = *(uint32 *)(*(int64 *)(lVar4 + 120) + 20);
            if (((this.targetSkill == null) ||
                (lVar4 = KungfuSkillLvData.DataBase(this.targetSkill,0)) == null) ||
               (*(int64 *)(lVar4 + 120) == 0)) throw; // [null/range check failed]
            uVar20 = *(uint32 *)(*(int64 *)(lVar4 + 120) + 24);
            uVar9 = 1;
          }
          else {
            if (((lVar1 == null) || (lVar4 = KungfuSkillLvData.DataBase(lVar1,0)) == null) ||
               (lVar4 = *(int64 *)(lVar4 + 112)) == null) throw; // [null/range check failed]
            if (lVar4.fightExp == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if ((((*(int64 *)(lVar4.skillID + 32) == 0) ||
                 (this.targetSkill == null)) ||
                (lVar4 = KungfuSkillLvData.DataBase(this.targetSkill,0)) == null) ||
               (lVar4 = *(int64 *)(lVar4 + 112)) == null) throw; // [null/range check failed]
            if (lVar4.fightExp == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = *(int64 *)(lVar4.skillID + 32);
            if (lVar4 == null) throw; // [null/range check failed]
            uVar18 = lVar4.skillID;
            if (((this.targetSkill == null) ||
                (lVar4 = KungfuSkillLvData.DataBase(this.targetSkill,0)) == null) ||
               (lVar4 = *(int64 *)(lVar4 + 112)) == null) throw; // [null/range check failed]
            if (lVar4.fightExp == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = *(int64 *)(lVar4.skillID + 32);
            if (lVar4 == null) throw; // [null/range check failed]
            uVar19 = lVar4.lv;
            if (((this.targetSkill == null) ||
                (lVar4 = KungfuSkillLvData.DataBase(this.targetSkill,0)) == null) ||
               (lVar4 = *(int64 *)(lVar4 + 112)) == null) throw; // [null/range check failed]
            if (lVar4.fightExp == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar4 = *(int64 *)(lVar4.skillID + 32);
            if (lVar4 == null) throw; // [null/range check failed]
            uVar20 = lVar4.fightExp;
            uVar9 = 0;
          }
          uVar5 = SkillRangeUIController.FindRangeGrids
                            (this,uVar18,gridLineNum,uVar19,CONCAT44(uVar17,uVar20),uVar9,0);
          this.findGrid = uVar5;
          if ((this.targetSkill == null) ||
             (lVar4 = KungfuSkillLvData.DataBase(this.targetSkill,0)) == null)
          throw; // [null/range check failed]
          lVar1 = this.targetSkill;
          if (0.0 < *(float *)(lVar4 + 60)) {
            if (((lVar1 == null) || (lVar4 = KungfuSkillLvData.DataBase(lVar1,0)) == null) ||
               (*(int64 *)(lVar4 + 120) == 0)) throw; // [null/range check failed]
            if (*(int *)(*(int64 *)(lVar4 + 120) + 16) != 7) {
              puVar8 = (uint32 *)Color.get_red(&local_a8,0);
              goto LAB_1809755ae;
            }
            local_b8 = 0;
            uStack_b0 = 0;
            Color.ctor(&local_b8);
            uVar17 = (uint32)local_b8;
            uVar18 = local_b8._4_4_;
            uVar19 = (uint32)uStack_b0;
            uVar20 = uStack_b0._4_4_;
          }
          else {
            if (((lVar1 == null) || (lVar4 = KungfuSkillLvData.DataBase(lVar1,0)) == null) ||
               (*(int64 *)(lVar4 + 120) == 0)) throw; // [null/range check failed]
            if (*(int *)(*(int64 *)(lVar4 + 120) + 16) == 7) {
              local_b8 = 0;
              uStack_b0 = 0;
              Color.ctor(&local_b8);
              uVar17 = (uint32)local_b8;
              uVar18 = local_b8._4_4_;
              uVar19 = (uint32)uStack_b0;
              uVar20 = uStack_b0._4_4_;
            }
            else {
              puVar8 = (uint32 *)Color.get_green(&local_a8,0);
        LAB_1809755ae:
              uVar17 = *puVar8;
              uVar18 = puVar8[1];
              uVar19 = puVar8[2];
              uVar20 = puVar8[3];
            }
          }
        }
        else {
          if (((lVar4 == null) || (lVar4 = KungfuSkillLvData.DataBase(lVar4,0)) == null) ||
             ((*(int64 *)(lVar4 + 120) == 0 ||
              (((this.targetSkill == null ||
                (lVar4 = KungfuSkillLvData.DataBase(this.targetSkill,0)) == null) ||
               (*(int64 *)(lVar4 + 120) == 0)))))) throw; // [null/range check failed]
          uVar18 = *(uint32 *)(*(int64 *)(lVar4 + 120) + 16);
          if (((this.targetSkill == null) ||
              (lVar4 = KungfuSkillLvData.DataBase(this.targetSkill,0)) == null) ||
             (*(int64 *)(lVar4 + 120) == 0)) throw; // [null/range check failed]
          uVar19 = *(uint32 *)(*(int64 *)(lVar4 + 120) + 20);
          if (((this.targetSkill == null) ||
              (lVar4 = KungfuSkillLvData.DataBase(this.targetSkill,0)) == null) ||
             (*(int64 *)(lVar4 + 120) == 0)) throw; // [null/range check failed]
          uVar5 = SkillRangeUIController.FindRangeGrids
                            (this,uVar18,gridLineNum,uVar19,
                             CONCAT44(uVar17,*(uint32 *)(*(int64 *)(lVar4 + 120) + 24)),0,0);
          this.findGrid = uVar5;
          if ((this.targetSkill == null) ||
             (lVar4 = KungfuSkillLvData.DataBase(this.targetSkill,0)) == null)
          throw; // [null/range check failed]
          local_b8 = 0;
          uStack_b0 = 0;
          if (0.0 < *(float *)(lVar4 + 60)) {
            Color.ctor(&local_b8);
            uVar17 = (uint32)local_b8;
            uVar18 = local_b8._4_4_;
            uVar19 = (uint32)uStack_b0;
            uVar20 = uStack_b0._4_4_;
          }
          else {
            Color.ctor(&local_b8);
            uVar17 = (uint32)local_b8;
            uVar18 = local_b8._4_4_;
            uVar19 = (uint32)uStack_b0;
            uVar20 = uStack_b0._4_4_;
          }
        }
        iVar11 = 0;
        fVar12 = (float)Mathf.Min();
        iVar2 = Mathf.Min((int)(fVar12 / (float)gridLineNum),20);
        lVar4 = SkillRangeUIController.GetGrid(this,id,0);
        if ((lVar4 != null) && (lVar4 = Component.GetComponent(lVar4,DAT_181d6e0c0)) != null) {
          fVar12 = (float)iVar2;
          lVar4.speEquipData = fVar12;
          lVar4 = SkillRangeUIController.GetGrid(this,id,0);
          if ((lVar4 != null) && (lVar4 = Component.GetComponent(lVar4,DAT_181d6e0c0)) != null) {
            *(float *)(lVar4 + 44) = fVar12;
            lVar4 = SkillRangeUIController.GetGrid(this,id,0);
            if ((lVar4 != null) && (lVar4 = Component.GetComponent(lVar4,DAT_181d6e0c0)) != null) {
              lVar4.belongHeroID = gridLineNum;
              lVar4 = SkillRangeUIController.GetGrid(this,id,0);
              if ((lVar4 != null) && (lVar4 = Component.GetComponent(lVar4,DAT_181d6e0c0)) != null) {
                UIGrid.set_repositionNow(lVar4,1,0);
                iVar2 = iVar11;
                iVar10 = iVar11;
                if (0 < gridLineNum) {
                  do {
                    lVar4 = SkillRangeUIController.GetGrid(this,id,0);
                    if (lVar4 == null) {
        LAB_18097599d:
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    uVar6 = Component.get_gameObject(lVar4,0);
                    uVar5 = this.SkillRangeOneGridPrefab;
                    uVar5 = GlobalData.AddChild(uVar6,uVar5,0);
                    this.newObj = uVar5;
                    lVar4 = this.newObj;
                    local_c8 = iVar10;
                    uVar5 = il2cpp_value_box(DAT_181d5b2f8,&local_c8);
                    local_c4 = iVar2;
                    uVar6 = il2cpp_value_box(DAT_181d5b2f8,&local_c4);
                    uVar5 = String.Format("{0}_{1}",uVar5,uVar6,0);
                    if (lVar4 == null) goto LAB_18097599d;
                    Object.set_name(lVar4,uVar5,0);
                    if (this.newObj == null) goto LAB_18097599d;
                    lVar4 = GameObject.GetComponent(this.newObj,DAT_181da0b98);
                    local_b8 = CONCAT44(fVar12,fVar12);
                    if (lVar4 == null) goto LAB_18097599d;
                    RectTransform.set_sizeDelta(lVar4,local_b8,0);
                    if (this.newObj == null) goto LAB_18097599d;
                    plVar7 = (int64 *)
                             GameObject.GetComponent(this.newObj,DAT_181d9fe50);
                    if ((this.findGrid == null) ||
                       (lVar4 = FUN_180002f80(this.findGrid,iVar10,DAT_181d51688),
                       lVar4 == null)) goto LAB_18097599d;
                    iVar3 = FUN_1800d6750(lVar4,iVar2,DAT_181d68270);
                    if (iVar3 < 1) {
                      if ((iVar2 == local_c0) && (iVar10 == local_c0)) {
                        puVar8 = (uint32 *)FUN_1810988d0(local_98,0);
                      }
                      else {
                        puVar8 = (uint32 *)FUN_181098a50(local_88,0);
                      }
                      uVar13 = *puVar8;
                      uVar14 = puVar8[1];
                      uVar15 = puVar8[2];
                      uVar16 = puVar8[3];
                    }
                    else {
                      if ((this.findGrid == null) ||
                         (lVar4 = FUN_180002f80(this.findGrid,iVar10,DAT_181d51688),
                         lVar4 == null)) throw; // [null/range check failed]
                      iVar3 = FUN_1800d6750(lVar4,iVar2,DAT_181d68270);
                      uVar13 = uVar17;
                      uVar14 = uVar18;
                      uVar15 = uVar19;
                      uVar16 = uVar20;
                      if (1 < iVar3) {
                        if ((this.targetSkill == null) ||
                           (lVar4 = KungfuSkillLvData.DataBase(this.targetSkill,0),
                           lVar4 == null)) throw; // [null/range check failed]
                        local_a8 = 0;
                        uStack_a0 = 0;
                        if (0.0 < *(float *)(lVar4 + 60)) {
                          Color.ctor(&local_a8);
                          uVar13 = (uint32)local_a8;
                          uVar14 = local_a8._4_4_;
                          uVar15 = (uint32)uStack_a0;
                          uVar16 = uStack_a0._4_4_;
                        }
                        else {
                          Color.ctor(&local_a8);
                          uVar13 = (uint32)local_a8;
                          uVar14 = local_a8._4_4_;
                          uVar15 = (uint32)uStack_a0;
                          uVar16 = uStack_a0._4_4_;
                        }
                      }
                    }
                    if (plVar7 == (int64 *)0) throw; // [null/range check failed]
                    local_a8 = CONCAT44(uVar14,uVar13);
                    uStack_a0 = CONCAT44(uVar16,uVar15);
                    (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_a8);
                    iVar2 = iVar2 + 1;
                  } while ((iVar2 < gridLineNum) || (iVar10 = iVar10 + 1, iVar2 = iVar11, iVar10 < gridLineNum));
                }
                return;
              }
            }
          }
        }
    }

    // Token : 0x60020B1
    // RVA   : 0x974F30   Offset: 0x973730   Length: 0x2F
    public int GetDirectionDamageType(DamageRangeType damageRangeType)
    {
        uint32 FUN_180974f30(uint64 this,int damageRangeType)
        {
        if (damageRangeType != 4) {
          if (damageRangeType == 5) {
            return 4;
          }
          if (damageRangeType == 6) {
            return 3;
          }
          if ((damageRangeType != 7) && (damageRangeType == 8)) {
            return 5;
          }
        }
        return 2;
    }

    // Token : 0x60020B2
    // RVA   : 0x974700   Offset: 0x972F00   Length: 0x818
    public List<List<int>> FindRangeGrids(int type, int gridLineNum, int minRange, int maxRange, bool direction)
    {
        int64 SkillRangeUIController.FindRangeGrids
                         (uint64 this,uint32 type,int gridLineNum,int minRange,int maxRange,
                         byte direction)
        {
        uint32 uVar1;
        int iVar2;
        uint32 uVar3;
        uint32 uVar4;
        int64 lVar5;
        uint64 uVar6;
        int64 lVar7;
        int64 lVar8;
        int iVar9;
        int iVar10;
        int iVar11;
        uint32 uVar12;
        uint64 uVar13;
        uVar13 = (uint64)minRange;
        lVar5 = il2cpp_internal(DAT_181d6b5b0);
        FUN_180f58a90(lVar5,DAT_181d51488);
        iVar11 = 0;
        if (0 < gridLineNum) {
          do {
            uVar6 = il2cpp_internal(DAT_181d6f030);
            FUN_180f58a90(uVar6,DAT_181d678f8);
            if (lVar5 == null) goto LAB_180974f0f;
            FUN_181827900(lVar5,uVar6,DAT_181d51508);
            iVar9 = 0;
            do {
              lVar7 = FUN_180002f80(lVar5,*(int *)(lVar5 + 24) + -1,DAT_181d51688);
              if (lVar7 == null) goto LAB_180974f0f;
              FUN_181814fa0(lVar7,0,DAT_181d67a78);
              iVar9 = iVar9 + 1;
            } while (iVar9 < gridLineNum);
            iVar11 = iVar11 + 1;
          } while (iVar11 < gridLineNum);
        }
        uVar1 = Mathf.RoundToInt((float)(gridLineNum + -1) * 0.5,0);
        switch(type) {
        case 0:
          iVar11 = 0;
          if (0 < gridLineNum) {
            do {
              iVar9 = 0;
              do {
                iVar10 = Mathf.Abs(-uVar1 + iVar9,0);
                iVar2 = Mathf.Abs(-uVar1 + iVar11);
                if ((minRange <= iVar2 + iVar10) && (iVar2 + iVar10 <= maxRange)) {
                  if ((lVar5 == null) || (lVar7 = FUN_180002f80(lVar5,iVar11,DAT_181d51688)) == null)
                  goto LAB_180974f0f;
                  FUN_18181e970(lVar7,iVar9,1,DAT_181d68370);
                }
                iVar9 = iVar9 + 1;
              } while (iVar9 < gridLineNum);
              iVar11 = iVar11 + 1;
            } while (iVar11 < gridLineNum);
          }
          break;
        case 1:
          iVar11 = 0;
          if (0 < gridLineNum) {
            do {
              iVar9 = 0;
              do {
                uVar3 = Mathf.Abs(-uVar1 + iVar9,0);
                uVar4 = Mathf.Abs(-uVar1 + iVar11,0);
                iVar10 = Mathf.Max(uVar3,uVar4,0);
                if ((minRange <= iVar10) && (iVar10 <= maxRange)) {
                  if ((lVar5 == null) || (lVar7 = FUN_180002f80(lVar5,iVar11,DAT_181d51688)) == null)
                  goto LAB_180974f0f;
                  FUN_18181e970(lVar7,iVar9,1,DAT_181d68370);
                }
                iVar9 = iVar9 + 1;
              } while (iVar9 < gridLineNum);
              iVar11 = iVar11 + 1;
            } while (iVar11 < gridLineNum);
          }
          break;
        case 2:
          if (minRange <= maxRange) {
            minRange = uVar1 - minRange;
            do {
              if (lVar5 == null) {
        LAB_180974f0f:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if (*(uint32 *)(lVar5 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar7 = lVar5[uVar1];
              if (lVar7 == null) goto LAB_180974f0f;
              iVar11 = (int)uVar13;
              FUN_18181e970(lVar7,iVar11 + uVar1,direction + 1,DAT_181d68370);
              if (0 < iVar11) {
                lVar7 = FUN_180002f80(lVar5,iVar11 + uVar1,DAT_181d51688);
                if (lVar7 == null) goto LAB_180974f0f;
                FUN_18181e970(lVar7,uVar1,1,DAT_181d68370);
                lVar7 = FUN_180002f80(lVar5,minRange,DAT_181d51688);
                if (lVar7 == null) goto LAB_180974f0f;
                FUN_18181e970(lVar7,uVar1,1,DAT_181d68370);
                lVar7 = FUN_180002f80(lVar5,uVar1,DAT_181d51688);
                if (lVar7 == null) goto LAB_180974f0f;
                FUN_18181e970(lVar7,minRange,1,DAT_181d68370);
              }
              uVar13 = (uint64)(iVar11 + 1U);
              minRange = minRange + -1;
            } while ((int)(iVar11 + 1U) <= maxRange);
          }
          break;
        case 3:
          if (minRange <= maxRange) {
            iVar11 = uVar1 + minRange;
            uVar12 = uVar1 - minRange;
            lVar7 = ((int64)(int)uVar1 - uVar13) * 8 + 32;
            do {
              if (lVar5 == null) goto LAB_180974f0f;
              if (*(uint32 *)(lVar5 + 24) <= uVar12) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar8 = *(int64 *)(lVar7 + *(int64 *)(lVar5 + 16));
              if (lVar8 == null) goto LAB_180974f0f;
              FUN_18181e970(lVar8,iVar11,direction + 1,DAT_181d68370);
              if (0 < (int)(iVar11 + -uVar1)) {
                lVar8 = FUN_180002f80(lVar5,uVar12,DAT_181d51688);
                if (lVar8 == null) goto LAB_180974f0f;
                FUN_18181e970(lVar8,uVar12,1,DAT_181d68370);
                lVar8 = FUN_180002f80(lVar5,iVar11,DAT_181d51688);
                if (lVar8 == null) goto LAB_180974f0f;
                FUN_18181e970(lVar8,iVar11,1,DAT_181d68370);
                lVar8 = FUN_180002f80(lVar5,iVar11,DAT_181d51688);
                if (lVar8 == null) goto LAB_180974f0f;
                FUN_18181e970(lVar8,uVar12,1,DAT_181d68370);
              }
              iVar11 = iVar11 + 1;
              uVar12 = uVar12 - 1;
              lVar7 = lVar7 + -8;
            } while ((int)(iVar11 + -uVar1) <= maxRange);
          }
          break;
        case 4:
          if (minRange <= maxRange) {
            iVar11 = uVar1 + minRange;
            minRange = 1 - minRange;
            do {
              if (minRange <= (int)((-1 - uVar1) + iVar11)) {
                iVar10 = minRange + uVar1;
                iVar9 = minRange;
                do {
                  if ((lVar5 == null) || (lVar7 = FUN_180002f80(lVar5,iVar10,DAT_181d51688)) == null)
                  goto LAB_180974f0f;
                  FUN_18181e970(lVar7,iVar11,direction + 1,DAT_181d68370);
                  lVar7 = FUN_180002f80(lVar5,iVar10,DAT_181d51688);
                  if (lVar7 == null) goto LAB_180974f0f;
                  FUN_18181e970(lVar7,minRange + uVar1 + -1,1,DAT_181d68370);
                  lVar7 = FUN_180002f80(lVar5,iVar11,DAT_181d51688);
                  if (lVar7 == null) goto LAB_180974f0f;
                  FUN_18181e970(lVar7,iVar10,1,DAT_181d68370);
                  lVar7 = FUN_180002f80(lVar5,minRange + uVar1 + -1,DAT_181d51688);
                  if (lVar7 == null) goto LAB_180974f0f;
                  FUN_18181e970(lVar7,iVar10,1,DAT_181d68370);
                  iVar9 = iVar9 + 1;
                  iVar10 = iVar10 + 1;
                } while (iVar9 <= (int)((-1 - uVar1) + iVar11));
              }
              uVar12 = (int)uVar13 + 1;
              uVar13 = (uint64)uVar12;
              iVar11 = iVar11 + 1;
              minRange = minRange + -1;
            } while ((int)uVar12 <= maxRange);
          }
          break;
        case 5:
          if (minRange <= maxRange) {
            iVar11 = uVar1 + minRange;
            minRange = uVar1 - minRange;
            do {
              iVar9 = (int)uVar13;
              if ((iVar9 == 1) || (iVar9 == maxRange)) {
                if ((lVar5 == null) || (lVar7 = FUN_180002f80(lVar5,uVar1,DAT_181d51688)) == null)
                goto LAB_180974f0f;
                FUN_18181e970(lVar7,iVar11,direction + 1,DAT_181d68370);
                lVar7 = FUN_180002f80(lVar5,uVar1,DAT_181d51688);
                if (lVar7 == null) goto LAB_180974f0f;
                FUN_18181e970(lVar7,minRange,1,DAT_181d68370);
                lVar7 = FUN_180002f80(lVar5,iVar11,DAT_181d51688);
                if (lVar7 == null) goto LAB_180974f0f;
                FUN_18181e970(lVar7,uVar1,1,DAT_181d68370);
                lVar7 = FUN_180002f80(lVar5,minRange,DAT_181d51688);
                if (lVar7 == null) goto LAB_180974f0f;
                FUN_18181e970(lVar7,uVar1,1,DAT_181d68370);
              }
              else {
                iVar10 = uVar1 - 1;
                do {
                  if ((lVar5 == null) || (lVar7 = FUN_180002f80(lVar5,iVar10,DAT_181d51688)) == null)
                  goto LAB_180974f0f;
                  FUN_18181e970(lVar7,iVar11,direction + 1,DAT_181d68370);
                  lVar7 = FUN_180002f80(lVar5,iVar10,DAT_181d51688);
                  if (lVar7 == null) goto LAB_180974f0f;
                  FUN_18181e970(lVar7,minRange,1,DAT_181d68370);
                  lVar7 = FUN_180002f80(lVar5,iVar11,DAT_181d51688);
                  if (lVar7 == null) goto LAB_180974f0f;
                  FUN_18181e970(lVar7,iVar10,1,DAT_181d68370);
                  lVar7 = FUN_180002f80(lVar5,minRange,DAT_181d51688);
                  if (lVar7 == null) goto LAB_180974f0f;
                  FUN_18181e970(lVar7,iVar10,1,DAT_181d68370);
                  iVar10 = iVar10 + 1;
                } while ((int)(iVar10 - uVar1) < 2);
              }
              uVar13 = (uint64)(iVar9 + 1U);
              iVar11 = iVar11 + 1;
              minRange = minRange + -1;
            } while ((int)(iVar9 + 1U) <= maxRange);
          }
        }
        return lVar5;
    }

    // Token : 0x60020B3
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
