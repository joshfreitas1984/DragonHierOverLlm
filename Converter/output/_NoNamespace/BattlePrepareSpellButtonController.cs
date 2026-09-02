// ============================================================
// Type  : BattlePrepareSpellButtonController
// Token : 0x200018B
// ============================================================

public class BattlePrepareSpellButtonController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000A5B
    public BattlePrepareSpellData targetSpellData;

    // Token: 0x4000A5C
    public bool cancel;

    // Token: 0x4000A5D
    public HeroData targetHero;

    // Token: 0x4000A5E
    private static Color disableColor;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000CA1
    // RVA   : 0x8DF830   Offset: 0x8DE030   Length: 0x768
    public void Init()
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_e010 = *(int64*)(DAT_181d4e010 + 184);
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
            uVar3 = Component.GetComponent(lVar2,DAT_181d6d8c0);
            if ((this.targetSpellData != null) &&
               (lVar2 = this.targetSpellData.spellName) != null) {
              local_res18[0] = String.get_Chars(lVar2,0,0);
              uVar4 = Char.ToString(local_res18,0);
              LTLocalization.SetText(uVar3,uVar4,0);
              lVar2 = Component.get_transform(this,0);
              if (lVar2 != null) {
                lVar2 = Transform.Find(lVar2,"Text",0);
                if (lVar2 != null) {
                  plVar5 = (int64 *)Component.GetComponent(lVar2,DAT_181d6d8c0);
                  lVar2 = *(int64 *)(pStatics_e010 + 32);
                  if (lVar2 != null) {
                    lVar2 = *(int64 *)(lVar2 + 56);
                    lVar6 = *(int64 *)(pStatics_e010 + 32);
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
                            lVar2 = Component.GetComponent(lVar2,DAT_181d6ccc0);
                            if (this.targetSpellData != null) {
                              uVar3 = this.targetSpellData.spellName;
                              if ((*pStatics_df90 != 0) &&
                                 (lVar6 = *(int64 *)(*pStatics_df90 + 32),
                                 lVar6 != null)) {
                                lVar6 = WorldData.Player(lVar6,0);
                                if ((this.targetSpellData != null) && (lVar6 != null)) {
                                  lVar6 = HeroData.FindSkill(lVar6,*(uint32 *)
                                                                     (this.targetSpellData + 32
                                                                     ),0);
                                  uVar4 = "{0}{1}";
                                  if (lVar6 == null) {
                                    lVar6 = *(int64 *)(pStatics_e010 + 32);
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
        LAB_1808dff93:
                          // WARNING: Subroutine does not return
                                      FUN_1800d6620();
                                    }
                                    local_58[0] = this.targetSpellData.costSpellNum;
                                    uVar7 = il2cpp_value_box(DAT_181d5b2f8,local_58);
                                    if ((this.targetSpellData == null) ||
                                       (lVar6 = this.targetSpellData.spellSpeAddData,
                                       lVar6 == null)) goto LAB_1808dff93;
                                    uVar8 = HeroSpeAddData.GetDescribe
                                                      (lVar6,1,1,1,
                                                       in_stack_ffffffffffffff98 & 0xffffffffffffff00,0);
                                    if ((((*pStatics_df90 == 0) ||
                                         (lVar6 = *(int64 *)
                                                   (*pStatics_df90 + 32),
                                         lVar6 == null)) || (this.targetSpellData == null)) ||
                                       (lVar6 = *(int64 *)(lVar6 + 0x238)) == null)
                                    goto LAB_1808dff93;
                                    uVar1 = this.targetSpellData.id;
                                    if (*(uint32 *)(lVar6 + 24) <= uVar1) {
                                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                    }
                                    local_res20[0] =
                                         *(float *)(*(int64 *)(lVar6 + 16) + 32 +
                                                   (int64)(int)uVar1 * 4) * 100.0;
                                    uVar9 = Single.ToString(local_res20,"f0",0);
                                    uVar7 = String.Format("(熟练{2}%)\n符法点-{0}\n{1}",uVar7,uVar8,uVar9,0);
                                  }
                                  uVar3 = String.Format(uVar4,uVar3,uVar7,0);
                                  if (lVar2 != null) {
                                    *(uint64 *)(lVar2 + 24) = uVar3;
                                    lVar2 = Component.GetComponent(this,DAT_181d6af40);
                                    if ((*pStatics_df90 != 0) &&
                                       (lVar6 = *(int64 *)
                                                 (*pStatics_df90 + 32),
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

    // Token : 0x6000CA2
    // RVA   : 0x8E0840   Offset: 0x8DF040   Length: 0x139
    public void Update()
    {
        var pStatics = *(int64*)(DAT_181d8b4a8 + 184);
        long lVar1;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        lVar1 = Component.GetComponent(this,DAT_181d6af40);
        if (lVar1 != null) {
          if ((*(char *)(lVar1 + 208) == false) || (this.cancel)) {
            return;
          }
          plVar2 = (int64 *)Component.GetComponent(this,DAT_181d6bc40);
          if ((*pStatics != 0) && (this.targetSpellData != null)) {
            if (*(int *)(*pStatics + 48) <
                this.targetSpellData.costSpellNum) {
              puVar3 = *(uint32 **)(DAT_181d8b428 + 184);
            }
            else {
              puVar3 = (uint32 *)FUN_181098a50(&local_18,0);
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

    // Token : 0x6000CA3
    // RVA   : 0x8DF7D0   Offset: 0x8DDFD0   Length: 0x59
    public bool CanUse()
    {
        var pStatics = *(int64*)(DAT_181d8b4a8 + 184);
        int iVar1;
        if ((*pStatics != 0) && (this.targetSpellData != null)) {
          iVar1 = this.targetSpellData.costSpellNum;
          return CONCAT31((int3)((uint32)iVar1 >> 8),
                          iVar1 <= *(int *)(*pStatics + 48));
        }
    }

    // Token : 0x6000CA4
    // RVA   : 0x8DFFA0   Offset: 0x8DE7A0   Length: 0x62B
    public void OnClick()
    {
        var pStatics = *(int64*)(DAT_181d8b4a8 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        uint uVar6;
        int iVar8;
        if (!this.cancel) {
          if ((*pStatics != 0) && (this.targetSpellData != null)) {
            if (*(int *)(*pStatics + 48) <
                this.targetSpellData.costSpellNum) {
              lVar1 = FUN_18046c0a0(0);
              if (lVar1 != null) {
                GameController.ShowTextOnMouse(lVar1,"符法点不足！",0);
                plVar4 = (int64 *)Resources.Load("Sound/SoundEffect/WrongClick",0);
                plVar7 = (int64 *)0;
                if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
                  plVar7 = plVar4;
                }
                NGUITools.PlaySound(plVar7,0);
                return;
              }
            }
            else {
              lVar1 = il2cpp_internal(DAT_181d6e6b0);
              FUN_180f58a90(lVar1,DAT_181d63c78);
              if (this.targetSpellData != null) {
                iVar8 = 0;
                if (!this.targetSpellData.toEnemy) {
                  lVar2 = FUN_18046bb80(0);
                  if ((lVar2 == null) || (lVar2 = BattleController.GetPlayerTeam(lVar2,0)) == null)
                  throw; // [null/range check failed]
                  uVar6 = *(uint32 *)(lVar2 + 16);
                }
                else {
                  lVar2 = FUN_18046bb80(0);
                  if ((lVar2 == null) || (lVar2 = BattleController.GetPlayerTeam(lVar2,0)) == null)
                  throw; // [null/range check failed]
                  uVar6 = (uint32)(*(int *)(lVar2 + 16) == 0);
                }
                while( true ) {
                  lVar2 = *(int64 *)(*(int64 *)(DAT_181d8b128 + 184) + 80);
                  if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 80)) == null)
                  throw; // [null/range check failed]
                  if (*(uint32 *)(lVar2 + 24) <= uVar6) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar2 = lVar2[uVar6];
                  if (lVar2 == null) throw; // [null/range check failed]
                  if (*(int *)(lVar2 + 24) <= iVar8) break;
                  lVar2 = FUN_18046bb80(0);
                  if ((((lVar2 == null) || (*(int64 *)(lVar2 + 80) == 0)) ||
                      (lVar2 = FUN_180002f80(*(int64 *)(lVar2 + 80),uVar6,DAT_181d52088)) == null
                      ) || ((lVar2 = FUN_180002f80(lVar2,iVar8,DAT_181d7ef38), lVar2 == null ||
                            (*(int64 *)(lVar2 + 24) == 0)))) throw; // [null/range check failed]
                  if (*(int64 *)(*(int64 *)(lVar2 + 24) + 0x248) == 0) {
                    lVar2 = FUN_18046bb80(0);
                    if ((((lVar2 == null) || (*(int64 *)(lVar2 + 80) == 0)) ||
                        (lVar2 = FUN_180002f80(*(int64 *)(lVar2 + 80),uVar6,DAT_181d52088),
                        lVar2 == null)) ||
                       ((lVar2 = FUN_180002f80(lVar2,iVar8,DAT_181d7ef38), lVar2 == null || (lVar1 == null))))
                    throw; // [null/range check failed]
                    FUN_181827900(lVar1,*(uint64 *)(lVar2 + 24),DAT_181d63d78);
                  }
                  iVar8 = iVar8 + 1;
                }
                lVar2 = **(int64 **)(DAT_181d92370 + 184);
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
            FUN_181801c10(lVar1,this.targetSpellData.id,DAT_181d67e70);
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

    // Token : 0x6000CA5
    // RVA   : 0x8E05D0   Offset: 0x8DEDD0   Length: 0x269
    public void TargetHeroChoosen()
    {
        var pStatics_2370 = *(int64*)(DAT_181d92370 + 184);
        var pStatics_b4a8 = *(int64*)(DAT_181d8b4a8 + 184);
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
          if ((plVar2 != (int64 *)0) && (plVar4 = (int64 *)0, *plVar2 == DAT_181d8a228)) {
            plVar4 = plVar2;
          }
          NGUITools.PlaySound(plVar4,0);
          plVar2 = (int64 *)Resources.Load("Sound/SoundEffect/PencilWriting",0);
          if ((plVar2 != (int64 *)0) && (*plVar2 == DAT_181d8a228)) {
            plVar5 = plVar2;
          }
          NGUITools.PlaySound(plVar5,0);
          if (((*pStatics_b4a8 != 0) && (this.targetSpellData != null)) &&
             (lVar3 = *(int64 *)(*pStatics_b4a8 + 56)) != null) {
            FUN_181814fa0(lVar3,this.targetSpellData.id,DAT_181d67a78);
            lVar3 = *pStatics_b4a8;
            if ((this.targetSpellData != null) && (lVar3 != null)) {
              *(int *)(lVar3 + 48) =
                   *(int *)(lVar3 + 48) - this.targetSpellData.costSpellNum;
              BattlePrepareSpellController.RefreshUI(lVar3,0);
              if ((*pStatics_2370 != 0) &&
                 (lVar3 = *(int64 *)(*pStatics_2370 + 72)) != null) {
                lVar3 = GameObject.GetComponent(lVar3,DAT_181d9fb20);
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

    // Token : 0x6000CA6
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6000CA7
    // RVA   : 0x8E0980   Offset: 0x8DF180   Length: 0x69
    private static void /*cctor*/()
    {
        ulong local_18;
        ulong uStack_10;
        local_18 = 0;
        uStack_10 = 0;
        Color.ctor(&local_18,0x3f800000,0x3f4ccccd,0x3f4ccccd,0);
        puVar1 = *(uint64 **)(DAT_181d8b428 + 184);
        *puVar1 = local_18;
        puVar1[1] = uStack_10;
    }

}
