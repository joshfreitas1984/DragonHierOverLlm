// ============================================================
// Type  : BattlePrepareSpellButtonController
// Token : 0x2000193
// ============================================================

public class BattlePrepareSpellButtonController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000AEE
    public BattlePrepareSpellData targetSpellData;

    // Token: 0x4000AEF
    public bool cancel;

    // Token: 0x4000AF0
    public HeroData targetHero;

    // Token: 0x4000AF1
    private static Color disableColor;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000CCF
    // RVA   : 0x5EA6D0   Offset: 0x5E94D0   Length: 0x795
    public void Init()
    {
        uint uVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar6;
        ulong uVar7;
        ulong uVar8;
        ulong uVar9;
        ushort[] local_res18 = new ushort[4];
        float[] local_res20 = new float[2];
        ulong in_stack_ffffffffffffff98;
        uint[] local_58 = new uint[4];
        uint local_48;
        uint uStack_44;
        uint uStack_40;
        uint32 uStack_3c;
        local_res20[0] = 0.0;
        lVar2 = Component.get_transform(this,0);
        if (lVar2 != null) {
          lVar2 = Transform.Find(lVar2,"Text",0);
          if (lVar2 != null) {
            uVar3 = Component.GetComponent(lVar2,DAT_181e79538);
            if ((this.targetSpellData != null) &&
               (lVar2 = this.targetSpellData.spellName) != null) {
              local_res18[0] = String.get_Chars(lVar2,0,0);
              uVar4 = Char.ToString(local_res18,0);
              LTLocalization.SetText(uVar3,uVar4,0);
              lVar2 = Component.get_transform(this,0);
              if (lVar2 != null) {
                lVar2 = Transform.Find(lVar2,"Text",0);
                if (lVar2 != null) {
                  plVar5 = (int64 *)Component.GetComponent(lVar2,DAT_181e79538);
                  lVar2 = GameController.ChangeAllAreaStateIDs;
                  if (lVar2 != null) {
                    lVar2 = *(int64 *)(lVar2 + 56);
                    lVar6 = GameController.ChangeAllAreaStateIDs;
                    if ((this.targetSpellData != null) && (lVar6 != null)) {
                      lVar6 = GameDataController.GetSkillDataBase
                                        (lVar6,this.targetSpellData.targetSkillID,0);
                      if ((lVar6 != null) && (lVar2 != null)) {
                        uVar1 = *(uint32 *)(lVar6 + 52);
                        if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar2 = *(int64 *)
                                 (*(int64 *)(lVar2 + 16) + 32 + (int64)(int)uVar1 * 8);
                        if ((lVar2 != null) && (plVar5 != (int64 *)0)) {
                          local_48 = *(uint32 *)(lVar2 + 24);
                          uStack_44 = *(uint32 *)(lVar2 + 28);
                          uStack_40 = *(uint32 *)(lVar2 + 32);
                          uStack_3c = *(uint32 *)(lVar2 + 36);
                          (**(code **)(*plVar5 + 0x2a8))
                                    (plVar5,&local_48,*(uint64 *)(*plVar5 + 0x2b0));
                          lVar2 = Component.get_transform(this,0);
                          if (lVar2 != null) {
                            lVar2 = Component.GetComponent(lVar2,DAT_181e788b8);
                            if (this.targetSpellData != null) {
                              uVar3 = this.targetSpellData.spellName;
                              if ((GameController._instance != null) &&
                                 (lVar6 = GameController._instance.worldData,
                                 lVar6 != null)) {
                                lVar6 = WorldData.Player(lVar6,0);
                                if ((this.targetSpellData != null) && (lVar6 != null)) {
                                  lVar6 = HeroData.FindSkill(lVar6,*(uint32 *)
                                                                     (this.targetSpellData + 32
                                                                     ),0);
                                  uVar4 = "{0}{1}";
                                  if (lVar6 == null) {
                                    lVar6 = GameController.ChangeAllAreaStateIDs;
                                    if ((this.targetSpellData == null) || (lVar6 == null))
                                    throw; // [null/range check failed]
                                    lVar6 = GameDataController.GetSkillDataBase
                                                      (lVar6,*(uint32 *)
                                                              (this.targetSpellData + 32),0);
                                    if (lVar6 == null) throw; // [null/range check failed]
                                    uVar7 = KungfuSkillData.Name(lVar6,1,0);
                                    uVar7 = String.Format("\n未解锁\n需修习 {0}",uVar7,0);
                                  }
                                  else {
                                    if (this.targetSpellData == null) {
        LAB_1805eae60:
                          // WARNING: Subroutine does not return
                                      FUN_1801e0300();
                                    }
                                    local_58[0] = this.targetSpellData.costSpellNum;
                                    uVar7 = il2cpp_value_box(DAT_181e60808,local_58);
                                    if ((this.targetSpellData == null) ||
                                       (lVar6 = this.targetSpellData.spellSpeAddData,
                                       lVar6 == null)) goto LAB_1805eae60;
                                    uVar8 = HeroSpeAddData.GetDescribe
                                                      (lVar6,1,1,1,
                                                       in_stack_ffffffffffffff98 & 0xffffffffffffff00,0);
                                    if ((((GameController._instance == null) ||
                                         (lVar6 = *(int64 *)
                                                   (GameController._instance + 32),
                                         lVar6 == null)) || (this.targetSpellData == null)) ||
                                       (lVar6 = lVar6.speSpellRate) == null)
                                    goto LAB_1805eae60;
                                    uVar1 = this.targetSpellData.id;
                                    if (lVar6.cityAreaID <= uVar1) {
                                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                    }
                                    local_res20[0] =
                                         *(float *)(lVar6.chapter + 32 +
                                                   (int64)(int)uVar1 * 4) * 100.0;
                                    uVar9 = Single.ToString(local_res20,"f0",0);
                                    uVar7 = String.Format("(熟练{2}%)\n符法点-{0}\n{1}",uVar7,uVar8,uVar9,0);
                                  }
                                  uVar3 = String.Format(uVar4,uVar3,uVar7,0);
                                  if (lVar2 != null) {
                                    *(uint64 *)(lVar2 + 24) = uVar3;
                                    lVar2 = Component.GetComponent(this,DAT_181e76ab8);
                                    if ((GameController._instance != null) &&
                                       (lVar6 = *(int64 *)
                                                 (GameController._instance + 32),
                                       lVar6 != null)) {
                                      lVar6 = WorldData.Player(lVar6,0);
                                      if ((this.targetSpellData != null) && (lVar6 != null)) {
                                        lVar6 = HeroData.FindSkill(lVar6,*(uint32 *)
                                                                           (this.targetSpellData
                                                                           + 32),0);
                                        if (lVar2 != null) {
                                          Selectable.set_interactable(lVar2,lVar6 != null,0);
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

    // Token : 0x6000CD0
    // RVA   : 0x5EB710   Offset: 0x5EA510   Length: 0x139
    public void Update()
    {
        var pStatics = *(int64*)(DAT_181e90820 + 184);
        long lVar1;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        lVar1 = Component.GetComponent(this,DAT_181e76ab8);
        if (lVar1 != null) {
          if ((*(char *)(lVar1 + 208) == false) || (this.cancel)) {
            return;
          }
          plVar2 = (int64 *)Component.GetComponent(this,DAT_181e777b8);
          if ((*pStatics != 0) && (this.targetSpellData != null)) {
            if (*(int *)(*pStatics + 48) <
                this.targetSpellData.costSpellNum) {
              puVar3 = *(uint32 **)(DAT_181e907a0 + 184);
            }
            else {
              puVar3 = (uint32 *)FUN_180f24d00(&local_18,0);
            }
            local_18 = *puVar3;
            uStack_14 = puVar3[1];
            uStack_10 = puVar3[2];
            uStack_c = puVar3[3];
            if (plVar2 != (int64 *)0) {
              (**(code **)(*plVar2 + 0x2a8))(plVar2,&local_18,*(uint64 *)(*plVar2 + 0x2b0));
              return;
            }
          }
        }
    }

    // Token : 0x6000CD1
    // RVA   : 0x5EA670   Offset: 0x5E9470   Length: 0x59
    public bool CanUse()
    {
        var pStatics = *(int64*)(DAT_181e90820 + 184);
        int iVar1;
        if ((*pStatics != 0) && (this.targetSpellData != null)) {
          iVar1 = this.targetSpellData.costSpellNum;
          return CONCAT31((int3)((uint32)iVar1 >> 8),
                          iVar1 <= *(int *)(*pStatics + 48));
        }
    }

    // Token : 0x6000CD2
    // RVA   : 0x5EAE70   Offset: 0x5E9C70   Length: 0x62B
    public void OnClick()
    {
        var pStatics = *(int64*)(DAT_181e90820 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        uint uVar6;
        int iVar8;
        if (!this.cancel) {
          if ((*pStatics != 0) && (this.targetSpellData != null)) {
            if (*(int *)(*pStatics + 48) <
                this.targetSpellData.costSpellNum) {
              lVar1 = FUN_1802106e0(0);
              if (lVar1 != null) {
                GameController.ShowTextOnMouse(lVar1,"符法点不足！",0);
                plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
                plVar7 = (int64 *)0;
                if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181e8f4a0)) {
                  plVar7 = plVar4;
                }
                NGUITools.PlaySound(plVar7,0);
                return;
              }
            }
            else {
              lVar1 = il2cpp_internal(DAT_181e73338);
              FUN_1810f3480(lVar1,DAT_181e6d6f0);
              if (this.targetSpellData != null) {
                iVar8 = 0;
                if (!this.targetSpellData.toEnemy) {
                  lVar2 = FUN_1802101c0(0);
                  if ((lVar2 == null) || (lVar2 = BattleController.GetPlayerTeam(lVar2,0)) == null)
                  throw; // [null/range check failed]
                  uVar6 = *(uint32 *)(lVar2 + 16);
                }
                else {
                  lVar2 = FUN_1802101c0(0);
                  if ((lVar2 == null) || (lVar2 = BattleController.GetPlayerTeam(lVar2,0)) == null)
                  throw; // [null/range check failed]
                  uVar6 = (uint32)(*(int *)(lVar2 + 16) == 0);
                }
                while( true ) {
                  lVar2 = *(int64 *)(*(int64 *)(DAT_181e90420 + 184) + 80);
                  if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 80)) == null)
                  throw; // [null/range check failed]
                  if (*(uint32 *)(lVar2 + 24) <= uVar6) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar2 = lVar2[uVar6];
                  if (lVar2 == null) throw; // [null/range check failed]
                  if (*(int *)(lVar2 + 24) <= iVar8) break;
                  lVar2 = FUN_1802101c0(0);
                  if ((((lVar2 == null) || (*(int64 *)(lVar2 + 80) == 0)) ||
                      (lVar2 = FUN_1800024b0(*(int64 *)(lVar2 + 80),uVar6,DAT_181e5b210)) == null
                      ) || ((lVar2 = FUN_1800024b0(lVar2,iVar8,DAT_181e88ef0), lVar2 == null ||
                            (*(int64 *)(lVar2 + 24) == 0)))) throw; // [null/range check failed]
                  if (*(int64 *)(*(int64 *)(lVar2 + 24) + 0x248) == 0) {
                    lVar2 = FUN_1802101c0(0);
                    if ((((lVar2 == null) || (*(int64 *)(lVar2 + 80) == 0)) ||
                        (lVar2 = FUN_1800024b0(*(int64 *)(lVar2 + 80),uVar6,DAT_181e5b210),
                        lVar2 == null)) ||
                       ((lVar2 = FUN_1800024b0(lVar2,iVar8,DAT_181e88ef0), lVar2 == null || (lVar1 == null))))
                    throw; // [null/range check failed]
                    FUN_18175de30(lVar1,*(uint64 *)(lVar2 + 24),DAT_181e6d770);
                  }
                  iVar8 = iVar8 + 1;
                }
                lVar2 = **(int64 **)(DAT_181e977e8 + 184);
                uVar3 = Component.get_gameObject(this,0);
                if (lVar2 != null) {
                  ChooseController.ShowChoosePanel(lVar2,2,lVar1,uVar3,"TargetHeroChoosen",0,0,0,0);
                  return;
                }
              }
            }
          }
        }
        else {
          if (((*pStatics != 0) && (this.targetSpellData != null)) &&
             (lVar1 = *(int64 *)(*pStatics + 56)) != null) {
            FUN_181665e90(lVar1,this.targetSpellData.id,DAT_181e717f0);
            lVar1 = *pStatics;
            if ((this.targetSpellData != null) && (lVar1 != null)) {
              *(int *)(lVar1 + 48) =
                   *(int *)(lVar1 + 48) + this.targetSpellData.costSpellNum;
              BattlePrepareSpellController.RefreshUI(lVar1,0);
              if (this.targetHero != null) {
                this.targetHero.battlePrepareSpellData = 0;
                if (this.targetHero != null) {
                  this.targetHero.heroDetailDirty = 1;
                  if (this.targetHero != null) {
                    HeroData.set_HeroIconDirty(this.targetHero,1,0);
                    uVar3 = Component.get_gameObject(this,0);
                    Object.Destroy(uVar3,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000CD3
    // RVA   : 0x5EB4A0   Offset: 0x5EA2A0   Length: 0x269
    public void TargetHeroChoosen()
    {
        var pStatics_0820 = *(int64*)(DAT_181e90820 + 184);
        var pStatics_77e8 = *(int64*)(DAT_181e977e8 + 184);
        ulong uVar1;
        long lVar3;
        if (this.targetSpellData != null) {
          uVar1 = "叹息";
          if (!this.targetSpellData.toEnemy) {
            uVar1 = "圣光";
          }
          uVar1 = String.Concat("Sound/SoundEffect/SpeEffect/",uVar1,0);
          plVar2 = (int64 *)Resources.Load(uVar1,0);
          plVar5 = (int64 *)0;
          plVar4 = plVar5;
          if ((plVar2 != (int64 *)0) && (plVar4 = (int64 *)0, *plVar2 == DAT_181e8f4a0)) {
            plVar4 = plVar2;
          }
          NGUITools.PlaySound(plVar4,0);
          plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/PencilWriting",0);
          if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181e8f4a0)) {
            plVar5 = plVar2;
          }
          NGUITools.PlaySound(plVar5,0);
          if (((*pStatics_0820 != 0) && (this.targetSpellData != null)) &&
             (lVar3 = *(int64 *)(*pStatics_0820 + 56)) != null) {
            FUN_181769fe0(lVar3,this.targetSpellData.id,DAT_181e713f0);
            lVar3 = *pStatics_0820;
            if ((this.targetSpellData != null) && (lVar3 != null)) {
              *(int *)(lVar3 + 48) =
                   *(int *)(lVar3 + 48) - this.targetSpellData.costSpellNum;
              BattlePrepareSpellController.RefreshUI(lVar3,0);
              if ((*pStatics_77e8 != 0) &&
                 (lVar3 = *(int64 *)(*pStatics_77e8 + 72)) != null) {
                lVar3 = GameObject.GetComponent(lVar3,DAT_181e54c18);
                if (lVar3 != null) {
                  lVar3 = *(int64 *)(lVar3 + 32);
                  if (lVar3 != null) {
                    *(uint64 *)(lVar3 + 0x248) = this.targetSpellData;
                    *(uint8 *)(lVar3 + 0x2d8) = 1;
                    HeroData.set_HeroIconDirty(lVar3,1,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000CD4
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

    // Token : 0x6000CD5
    // RVA   : 0x5EB850   Offset: 0x5EA650   Length: 0x69
    private static void /*cctor*/()
    {
        ulong local_18;
        ulong uStack_10;
        local_18 = 0;
        uStack_10 = 0;
        Color.ctor(&local_18,0x3f800000,0x3f4ccccd,0x3f4ccccd,0);
        puVar1 = *(uint64 **)(DAT_181e907a0 + 184);
        *puVar1 = local_18;
        puVar1[1] = uStack_10;
    }

}
