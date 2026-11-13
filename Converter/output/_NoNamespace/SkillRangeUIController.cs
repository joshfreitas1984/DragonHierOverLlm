// ============================================================
// Type  : SkillRangeUIController
// Token : 0x200036C
// ============================================================

public class SkillRangeUIController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001C47
    public GameObject SkillRangeOneGridPrefab;

    // Token: 0x4001C48
    public KungfuSkillData targetSkill;

    // Token: 0x4001C49
    private GameObject newObj;

    // Token: 0x4001C4A
    private List<List<int>> findGrid;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60021D9
    // RVA   : 0x6B04C0   Offset: 0x6AF2C0   Length: 0x666
    public void RefreshSkillRange(KungfuSkillData _targetSkill)
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
        LAB_1806b0b15:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        lVar2 = Transform.Find(lVar2,uVar3,0);
        if (lVar2 == null) goto LAB_1806b0b15;
        lVar2 = Transform.Find(lVar2,"Grid",0);
        if (lVar2 == null) throw; // [null/range check failed]
        uVar3 = Component.get_gameObject(lVar2,0);
        GlobalData.DeleteAllChild(uVar3,0);
        local_res8[0] = 1;
        lVar2 = Component.get_transform(this,0);
        uVar3 = Int32.ToString(local_res8,0);
        if (lVar2 == null) {
        LAB_1806b0b1b:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        lVar2 = Transform.Find(lVar2,uVar3,0);
        if (lVar2 == null) goto LAB_1806b0b1b;
        lVar2 = Transform.Find(lVar2,"Grid",0);
        if (lVar2 == null) throw; // [null/range check failed]
        uVar3 = Component.get_gameObject(lVar2,0);
        GlobalData.DeleteAllChild(uVar3,0);
        lVar2 = this.targetSkill;
        if (lVar2 == null) throw; // [null/range check failed]
        if ((lVar2.type & 0xfffffffd) == 0) {
          lVar2 = Component.get_transform(this,0);
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2 = Transform.Find(lVar2,"0",0);
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2 = Component.get_gameObject(lVar2,0);
          if (lVar2 == null) throw; // [null/range check failed]
          GameObject.SetActive(lVar2,0,0);
        LAB_1806b0ac9:
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
        else {
          lVar2 = lVar2.attackRangeData;
          if (lVar2 == null) throw; // [null/range check failed]
          if (lVar2.belongForceID == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = *(int64 *)(lVar2.summonSkill + 32);
          if (lVar2 == null) throw; // [null/range check failed]
          if (lVar2.summonSkill != 4) {
            if ((this.targetSkill == null) ||
               (lVar2 = this.targetSkill.damageRangeData) == null)
            throw; // [null/range check failed]
            if (lVar2.summonSkill != 7) {
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
              uVar3 = Component.GetComponent(lVar2,DAT_181e79538);
              LTLocalization.SetText(uVar3,"释放范围",0);
              if ((this.targetSkill == null) ||
                 (lVar2 = this.targetSkill.attackRangeData) == null)
              throw; // [null/range check failed]
              if (lVar2.belongForceID == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(lVar2.summonSkill + 32);
              if (lVar2 == null) throw; // [null/range check failed]
              SkillRangeUIController.RefreshSkillRangeGrid(this,0,lVar2.belongForceID * 2 + 1,0);
              if (this.targetSkill == null) throw; // [null/range check failed]
              if (this.targetSkill.type != 1) {
                lVar2 = Component.get_transform(this,0);
                if (lVar2 == null) throw; // [null/range check failed]
                lVar2 = Transform.Find(lVar2,"1",0);
                if (lVar2 == null) throw; // [null/range check failed]
                lVar2 = Component.get_gameObject(lVar2,0);
                if (lVar2 == null) throw; // [null/range check failed]
                GameObject.SetActive(lVar2,1,0);
                if ((this.targetSkill == null) ||
                   (lVar2 = this.targetSkill.damageRangeData) == null)
                throw; // [null/range check failed]
                iVar4 = lVar2.belongForceID * 2 + 1;
                uVar3 = 1;
                goto LAB_1806b08c9;
              }
              goto LAB_1806b0ac9;
            }
          }
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
                            uVar3 = Component.GetComponent(lVar2,DAT_181e79538);
                            LTLocalization.SetText(uVar3,"作用范围",0);
                            lVar2 = this.targetSkill;
                            if ((lVar2 != null) && (lVar1 = lVar2.damageRangeData) != null) {
                              if (*(int *)(lVar1 + 16) != 7) {
                                iVar4 = *(int *)(lVar1 + 24) * 2 + 1;
                                uVar3 = 0;
        LAB_1806b08c9:
                                SkillRangeUIController.RefreshSkillRangeGrid(this,uVar3,iVar4,0);
                                return;
                              }
                              lVar2 = lVar2.attackRangeData;
                              if (lVar2 != null) {
                                if (lVar2.belongForceID == null) {
                                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                }
                                lVar2 = *(int64 *)(lVar2.summonSkill + 32);
                                if (lVar2 != null) {
                                  uVar3 = 0;
                                  iVar4 = lVar2.belongForceID * 2 + 1;
                                  goto LAB_1806b08c9;
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

    // Token : 0x60021DA
    // RVA   : 0x6AFC70   Offset: 0x6AEA70   Length: 0x76
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

    // Token : 0x60021DB
    // RVA   : 0x6AFCF0   Offset: 0x6AEAF0   Length: 0x7CF
    public void RefreshSkillRangeGrid(int id, int gridLineNum)
    {
        long lVar1;
        byte uVar2;
        int iVar3;
        int iVar4;
        int iVar5;
        ulong uVar6;
        long lVar7;
        ulong uVar8;
        int iVar11;
        int iVar12;
        float fVar13;
        uint uVar14;
        uint uVar15;
        uint uVar16;
        uint uVar17;
        uint uVar18;
        uint uVar19;
        uint uVar20;
        uint uVar21;
        ulong in_stack_ffffffffffffff18;
        int local_c4;
        int[] local_c0 = new int[2];
        ulong local_b8;
        ulong uStack_b0;
        ulong local_a8;
        ulong uStack_a0;
        byte[] local_98 = new byte[16];
        byte[] local_88 = new byte[80];
        uVar18 = (uint32)((uint64)in_stack_ffffffffffffff18 >> 32);
        iVar3 = Mathf.RoundToInt((float)(gridLineNum + -1) * 0.5,0);
        lVar7 = this.targetSkill;
        if (id == null) {
          if ((lVar7 = lVar7?.attackRangeData) == null) throw; // [null/range check failed]
          if (lVar7.belongForceID == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar7 = *(int64 *)(lVar7.summonSkill + 32);
          if (lVar7 == null) throw; // [null/range check failed]
          lVar1 = this.targetSkill;
          if (lVar7.summonSkill == 4) {
            if ((lVar1 == null) || (lVar7 = lVar1.damageRangeData) == null) throw; // [null/range check failed]
            iVar4 = lVar7.summonSkill;
            uVar19 = lVar7.belongForceID;
            if (iVar4 == 4) {
        LAB_1806b000c:
              uVar20 = 2;
            }
            else if (iVar4 == 5) {
              uVar20 = 4;
            }
            else if (iVar4 == 6) {
              uVar20 = 3;
            }
            else {
              if ((iVar4 == 7) || (iVar4 != 8)) goto LAB_1806b000c;
              uVar20 = 5;
            }
            uVar21 = lVar7.skillID;
            uVar2 = 1;
          }
          else {
            if ((lVar1 == null) || (lVar7 = lVar1.attackRangeData) == null) throw; // [null/range check failed]
            if (lVar7.belongForceID == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (((*(int64 *)(lVar7.summonSkill + 32) == 0) ||
                (this.targetSkill == null)) ||
               (lVar7 = this.targetSkill.attackRangeData) == null)
            throw; // [null/range check failed]
            if (lVar7.belongForceID == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar7 = *(int64 *)(lVar7.summonSkill + 32);
            if (lVar7 == null) throw; // [null/range check failed]
            uVar20 = lVar7.summonSkill;
            if ((this.targetSkill == null) ||
               (lVar7 = this.targetSkill.attackRangeData) == null)
            throw; // [null/range check failed]
            if (lVar7.belongForceID == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar7 = *(int64 *)(lVar7.summonSkill + 32);
            if (lVar7 == null) throw; // [null/range check failed]
            uVar21 = lVar7.skillID;
            if ((this.targetSkill == null) ||
               (lVar7 = this.targetSkill.attackRangeData) == null)
            throw; // [null/range check failed]
            if (lVar7.belongForceID == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar7 = *(int64 *)(lVar7.summonSkill + 32);
            if (lVar7 == null) throw; // [null/range check failed]
            uVar19 = lVar7.belongForceID;
            uVar2 = 0;
          }
          uVar6 = SkillRangeUIController.FindRangeGrids
                            (this,uVar20,gridLineNum,uVar21,CONCAT44(uVar18,uVar19),uVar2,0);
          this.findGrid = uVar6;
          lVar7 = this.targetSkill;
          if (lVar7 == null) throw; // [null/range check failed]
          lVar1 = lVar7.damageRangeData;
          if (0.0 < lVar7.baseDamage) {
            if (lVar1 == null) throw; // [null/range check failed]
            if (lVar1.summonSkill != 7) {
              puVar10 = (uint32 *)Color.get_red(&local_a8,0);
              goto LAB_1806b00e5;
            }
            local_b8 = 0;
            uStack_b0 = 0;
            Color.ctor(&local_b8);
            uVar18 = (uint32)local_b8;
            uVar19 = local_b8._4_4_;
            uVar20 = (uint32)uStack_b0;
            uVar21 = uStack_b0._4_4_;
          }
          else {
            if (lVar1 == null) throw; // [null/range check failed]
            if (lVar1.summonSkill == 7) {
              local_b8 = 0;
              uStack_b0 = 0;
              Color.ctor(&local_b8);
              uVar18 = (uint32)local_b8;
              uVar19 = local_b8._4_4_;
              uVar20 = (uint32)uStack_b0;
              uVar21 = uStack_b0._4_4_;
            }
            else {
              puVar10 = (uint32 *)Color.get_green(&local_a8,0);
        LAB_1806b00e5:
              uVar18 = *puVar10;
              uVar19 = puVar10[1];
              uVar20 = puVar10[2];
              uVar21 = puVar10[3];
            }
          }
        }
        else {
          if ((lVar7 = lVar7?.damageRangeData) == null) throw; // [null/range check failed]
          uVar6 = SkillRangeUIController.FindRangeGrids
                            (this,lVar7.summonSkill,gridLineNum,lVar7.skillID,
                             CONCAT44(uVar18,lVar7.belongForceID),0,0);
          this.findGrid = uVar6;
          if (this.targetSkill == null) throw; // [null/range check failed]
          local_b8 = 0;
          uStack_b0 = 0;
          if (0.0 < this.targetSkill.baseDamage) {
            Color.ctor(&local_b8);
            uVar18 = (uint32)local_b8;
            uVar19 = local_b8._4_4_;
            uVar20 = (uint32)uStack_b0;
            uVar21 = uStack_b0._4_4_;
          }
          else {
            Color.ctor(&local_b8);
            uVar18 = (uint32)local_b8;
            uVar19 = local_b8._4_4_;
            uVar20 = (uint32)uStack_b0;
            uVar21 = uStack_b0._4_4_;
          }
        }
        iVar12 = 0;
        fVar13 = (float)Mathf.Min();
        iVar4 = Mathf.Min((int)(fVar13 / (float)gridLineNum),20);
        lVar7 = SkillRangeUIController.GetGrid(this,id,0);
        if ((lVar7 != null) && (lVar7 = Component.GetComponent(lVar7,DAT_181e79d38)) != null) {
          fVar13 = (float)iVar4;
          lVar7.describe = fVar13;
          lVar7 = SkillRangeUIController.GetGrid(this,id,0);
          if ((lVar7 != null) && (lVar7 = Component.GetComponent(lVar7,DAT_181e79d38)) != null) {
            *(float *)(lVar7 + 44) = fVar13;
            lVar7 = SkillRangeUIController.GetGrid(this,id,0);
            if ((lVar7 != null) && (lVar7 = Component.GetComponent(lVar7,DAT_181e79d38)) != null) {
              *(int *)(lVar7 + 36) = gridLineNum;
              lVar7 = SkillRangeUIController.GetGrid(this,id,0);
              if ((lVar7 != null) && (lVar7 = Component.GetComponent(lVar7,DAT_181e79d38)) != null) {
                UIGrid.set_repositionNow(lVar7,1,0);
                iVar4 = iVar12;
                iVar11 = iVar12;
                if (0 < gridLineNum) {
                  do {
                    lVar7 = SkillRangeUIController.GetGrid(this,id,0);
                    if (lVar7 == null) {
        LAB_1806b04ba:
                          // WARNING: Subroutine does not return
                      FUN_1801e0300();
                    }
                    uVar8 = Component.get_gameObject(lVar7,0);
                    uVar6 = this.SkillRangeOneGridPrefab;
                    uVar6 = GlobalData.AddChild(uVar8,uVar6,0);
                    this.newObj = uVar6;
                    lVar7 = this.newObj;
                    local_c4 = iVar11;
                    uVar6 = il2cpp_value_box(DAT_181e60808,&local_c4);
                    local_c0[0] = iVar4;
                    uVar8 = il2cpp_value_box(DAT_181e60808,local_c0);
                    uVar6 = String.Format("{0}_{1}",uVar6,uVar8,0);
                    if (lVar7 == null) goto LAB_1806b04ba;
                    Object.set_name(lVar7,uVar6,0);
                    if (this.newObj == null) goto LAB_1806b04ba;
                    lVar7 = GameObject.GetComponent(this.newObj,DAT_181e55c90);
                    local_b8 = CONCAT44(fVar13,fVar13);
                    if (lVar7 == null) goto LAB_1806b04ba;
                    RectTransform.set_sizeDelta(lVar7,local_b8,0);
                    if (this.newObj == null) goto LAB_1806b04ba;
                    plVar9 = (int64 *)
                             GameObject.GetComponent(this.newObj,DAT_181e54f48);
                    if ((this.findGrid == null) ||
                       (lVar7 = FUN_1800024b0(this.findGrid,iVar11,DAT_181e5a4c8),
                       lVar7 == null)) goto LAB_1806b04ba;
                    iVar5 = FUN_180002480(lVar7,iVar4,DAT_181e71bf0);
                    if (iVar5 < 1) {
                      if ((iVar4 == iVar3) && (iVar11 == iVar3)) {
                        puVar10 = (uint32 *)FUN_180f24b80(local_98,0);
                      }
                      else {
                        puVar10 = (uint32 *)FUN_180f24d00(local_88,0);
                      }
                      uVar14 = *puVar10;
                      uVar15 = puVar10[1];
                      uVar16 = puVar10[2];
                      uVar17 = puVar10[3];
                    }
                    else {
                      if ((this.findGrid == null) ||
                         (lVar7 = FUN_1800024b0(this.findGrid,iVar11,DAT_181e5a4c8),
                         lVar7 == null)) throw; // [null/range check failed]
                      iVar5 = FUN_180002480(lVar7,iVar4,DAT_181e71bf0);
                      uVar14 = uVar18;
                      uVar15 = uVar19;
                      uVar16 = uVar20;
                      uVar17 = uVar21;
                      if (1 < iVar5) {
                        if (this.targetSkill == null) throw; // [null/range check failed]
                        local_a8 = 0;
                        uStack_a0 = 0;
                        if (0.0 < this.targetSkill.baseDamage) {
                          Color.ctor(&local_a8);
                          uVar14 = (uint32)local_a8;
                          uVar15 = local_a8._4_4_;
                          uVar16 = (uint32)uStack_a0;
                          uVar17 = uStack_a0._4_4_;
                        }
                        else {
                          Color.ctor(&local_a8);
                          uVar14 = (uint32)local_a8;
                          uVar15 = local_a8._4_4_;
                          uVar16 = (uint32)uStack_a0;
                          uVar17 = uStack_a0._4_4_;
                        }
                      }
                    }
                    if (plVar9 == (int64 *)0) throw; // [null/range check failed]
                    local_a8 = CONCAT44(uVar15,uVar14);
                    uStack_a0 = CONCAT44(uVar17,uVar16);
                    (**(code **)(*plVar9 + 0x2a8))(plVar9,&local_a8);
                    iVar4 = iVar4 + 1;
                  } while ((iVar4 < gridLineNum) || (iVar11 = iVar11 + 1, iVar4 = iVar12, iVar11 < gridLineNum));
                }
                return;
              }
            }
          }
        }
    }

    // Token : 0x60021DC
    // RVA   : 0x6AFC40   Offset: 0x6AEA40   Length: 0x2F
    public int GetDirectionDamageType(DamageRangeType damageRangeType)
    {
        uint32 FUN_1806afc40(uint64 this,int damageRangeType)
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

    // Token : 0x60021DD
    // RVA   : 0x6AF410   Offset: 0x6AE210   Length: 0x818
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
        lVar5 = il2cpp_internal(DAT_181e6ffb8);
        FUN_1810f3480(lVar5,DAT_181e5a220);
        iVar11 = 0;
        if (0 < gridLineNum) {
          do {
            uVar6 = il2cpp_internal(DAT_181e73cb8);
            FUN_1810f3480(uVar6,DAT_181e71270);
            if (lVar5 == null) goto LAB_1806afc1f;
            FUN_18175de30(lVar5,uVar6,DAT_181e5a330);
            iVar9 = 0;
            do {
              lVar7 = FUN_1800024b0(lVar5,*(int *)(lVar5 + 24) + -1,DAT_181e5a4c8);
              if (lVar7 == null) goto LAB_1806afc1f;
              FUN_181769fe0(lVar7,0,DAT_181e713f0);
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
                  if ((lVar5 == null) || (lVar7 = FUN_1800024b0(lVar5,iVar11,DAT_181e5a4c8)) == null)
                  goto LAB_1806afc1f;
                  FUN_181774110(lVar7,iVar9,1,DAT_181e71cf0);
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
                  if ((lVar5 == null) || (lVar7 = FUN_1800024b0(lVar5,iVar11,DAT_181e5a4c8)) == null)
                  goto LAB_1806afc1f;
                  FUN_181774110(lVar7,iVar9,1,DAT_181e71cf0);
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
        LAB_1806afc1f:
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              if (*(uint32 *)(lVar5 + 24) <= uVar1) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar7 = lVar5[uVar1];
              if (lVar7 == null) goto LAB_1806afc1f;
              iVar11 = (int)uVar13;
              FUN_181774110(lVar7,iVar11 + uVar1,direction + 1,DAT_181e71cf0);
              if (0 < iVar11) {
                lVar7 = FUN_1800024b0(lVar5,iVar11 + uVar1,DAT_181e5a4c8);
                if (lVar7 == null) goto LAB_1806afc1f;
                FUN_181774110(lVar7,uVar1,1,DAT_181e71cf0);
                lVar7 = FUN_1800024b0(lVar5,minRange,DAT_181e5a4c8);
                if (lVar7 == null) goto LAB_1806afc1f;
                FUN_181774110(lVar7,uVar1,1,DAT_181e71cf0);
                lVar7 = FUN_1800024b0(lVar5,uVar1,DAT_181e5a4c8);
                if (lVar7 == null) goto LAB_1806afc1f;
                FUN_181774110(lVar7,minRange,1,DAT_181e71cf0);
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
              if (lVar5 == null) goto LAB_1806afc1f;
              if (*(uint32 *)(lVar5 + 24) <= uVar12) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar8 = *(int64 *)(lVar7 + *(int64 *)(lVar5 + 16));
              if (lVar8 == null) goto LAB_1806afc1f;
              FUN_181774110(lVar8,iVar11,direction + 1,DAT_181e71cf0);
              if (0 < (int)(iVar11 + -uVar1)) {
                lVar8 = FUN_1800024b0(lVar5,uVar12,DAT_181e5a4c8);
                if (lVar8 == null) goto LAB_1806afc1f;
                FUN_181774110(lVar8,uVar12,1,DAT_181e71cf0);
                lVar8 = FUN_1800024b0(lVar5,iVar11,DAT_181e5a4c8);
                if (lVar8 == null) goto LAB_1806afc1f;
                FUN_181774110(lVar8,iVar11,1,DAT_181e71cf0);
                lVar8 = FUN_1800024b0(lVar5,iVar11,DAT_181e5a4c8);
                if (lVar8 == null) goto LAB_1806afc1f;
                FUN_181774110(lVar8,uVar12,1,DAT_181e71cf0);
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
                  if ((lVar5 == null) || (lVar7 = FUN_1800024b0(lVar5,iVar10,DAT_181e5a4c8)) == null)
                  goto LAB_1806afc1f;
                  FUN_181774110(lVar7,iVar11,direction + 1,DAT_181e71cf0);
                  lVar7 = FUN_1800024b0(lVar5,iVar10,DAT_181e5a4c8);
                  if (lVar7 == null) goto LAB_1806afc1f;
                  FUN_181774110(lVar7,minRange + uVar1 + -1,1,DAT_181e71cf0);
                  lVar7 = FUN_1800024b0(lVar5,iVar11,DAT_181e5a4c8);
                  if (lVar7 == null) goto LAB_1806afc1f;
                  FUN_181774110(lVar7,iVar10,1,DAT_181e71cf0);
                  lVar7 = FUN_1800024b0(lVar5,minRange + uVar1 + -1,DAT_181e5a4c8);
                  if (lVar7 == null) goto LAB_1806afc1f;
                  FUN_181774110(lVar7,iVar10,1,DAT_181e71cf0);
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
                if ((lVar5 == null) || (lVar7 = FUN_1800024b0(lVar5,uVar1,DAT_181e5a4c8)) == null)
                goto LAB_1806afc1f;
                FUN_181774110(lVar7,iVar11,direction + 1,DAT_181e71cf0);
                lVar7 = FUN_1800024b0(lVar5,uVar1,DAT_181e5a4c8);
                if (lVar7 == null) goto LAB_1806afc1f;
                FUN_181774110(lVar7,minRange,1,DAT_181e71cf0);
                lVar7 = FUN_1800024b0(lVar5,iVar11,DAT_181e5a4c8);
                if (lVar7 == null) goto LAB_1806afc1f;
                FUN_181774110(lVar7,uVar1,1,DAT_181e71cf0);
                lVar7 = FUN_1800024b0(lVar5,minRange,DAT_181e5a4c8);
                if (lVar7 == null) goto LAB_1806afc1f;
                FUN_181774110(lVar7,uVar1,1,DAT_181e71cf0);
              }
              else {
                iVar10 = uVar1 - 1;
                do {
                  if ((lVar5 == null) || (lVar7 = FUN_1800024b0(lVar5,iVar10,DAT_181e5a4c8)) == null)
                  goto LAB_1806afc1f;
                  FUN_181774110(lVar7,iVar11,direction + 1,DAT_181e71cf0);
                  lVar7 = FUN_1800024b0(lVar5,iVar10,DAT_181e5a4c8);
                  if (lVar7 == null) goto LAB_1806afc1f;
                  FUN_181774110(lVar7,minRange,1,DAT_181e71cf0);
                  lVar7 = FUN_1800024b0(lVar5,iVar11,DAT_181e5a4c8);
                  if (lVar7 == null) goto LAB_1806afc1f;
                  FUN_181774110(lVar7,iVar10,1,DAT_181e71cf0);
                  lVar7 = FUN_1800024b0(lVar5,minRange,DAT_181e5a4c8);
                  if (lVar7 == null) goto LAB_1806afc1f;
                  FUN_181774110(lVar7,iVar10,1,DAT_181e71cf0);
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

    // Token : 0x60021DE
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
