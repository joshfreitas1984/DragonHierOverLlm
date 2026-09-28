// ============================================================
// Type  : <BattleEnd>d__274
// Token : 0x2000175
// ============================================================

public class <BattleEnd>d__274
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40009EC
    private int <>1__state;

    // Token: 0x40009ED
    private object <>2__current;

    // Token: 0x40009EE
    public BattleController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000C15
    // RVA   : 0x219070   Offset: 0x218470   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000C16
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000C17
    // RVA   : 0x9BEFF0   Offset: 0x9BE3F0   Length: 0x3183
    private virtual bool MoveNext()
    {
        var pStatics_01c8 = *(int64*)(DAT_181db01c8 + 184);
        var pStatics_2dd8 = *(int64*)(DAT_181d72dd8 + 184);
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
        bool cVar2;
        uint uVar3;
        long lVar4;
        ulong uVar5;
        long lVar7;
        ulong uVar9;
        ulong uVar10;
        long lVar11;
        int iVar13;
        int iVar14;
        uint uVar15;
        float fVar16;
        float fVar17;
        float fVar18;
        uint uVar19;
        byte[] auVar20 = new byte[16];
        byte[] auVar21 = new byte[16];
        byte[] auVar22 = new byte[16];
        byte[] auVar23 = new byte[16];
        float[] local_res8 = new float[4];
        int[] local_res18 = new int[2];
        uint[] local_res20 = new uint[2];
        uint local_d8;
        uint[] local_d4 = new uint[3];
        ulong local_c8;
        float local_c0;
        ulong local_b8;
        float local_b0;
        ulong local_98;
        ulong uStack_90;
        uint64 extraout_XMM0_Qb;
        uint64 extraout_XMM0_Qb_00;
        iVar13 = this.<>1__state;
        lVar11 = this.<>4__this;
        local_res8[0] = 0.0;
        if (iVar13 == 0) {
          this.<>1__state = 0xffffffff;
          if (lVar11 != null) {
            *(uint32 *)(lVar11 + 36) = 6;
            *(uint32 *)(lVar11 + 0x124) = 12;
            BattleController.ResetGridUnitsToNormal(lVar11,*(uint64 *)(lVar11 + 0x1d8),0);
            BattleController.ResetGridUnitsToNormal(lVar11,*(uint64 *)(lVar11 + 0x1f8),0);
            BattleController.ResetGridUnitsToNormal(lVar11,*(uint64 *)(lVar11 + 0x208),0);
            if (*(int64 *)(lVar11 + 0x1e0) != 0) {
              FUN_1812f9a10(*(int64 *)(lVar11 + 0x1e0),DAT_181d8af98);
              plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/终场锣",0);
              plVar12 = (int64 *)0;
              if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181daf348)) {
                plVar12 = plVar6;
              }
              NGUITools.PlaySound(plVar12);
              *(uint64 *)(lVar11 + 0x110) = 0;
              BattleController.SetPauseButtonInteractable(lVar11,0,0);
              uVar5 = new WaitForSecondsRealtime();
              this.<>2__current = uVar5;
              this.<>1__state = 1;
              return true;
            }
          }
        }
        else {
          if ((iVar13 != 1) && (iVar13 != 2)) {
            return false;
          }
          this.<>1__state = 0xffffffff;
          if ((lVar11 != null) && (*(int64 *)(lVar11 + 128) != 0)) {
            if (*(int *)(*(int64 *)(lVar11 + 128) + 24) < 1) {
              lVar4 = FUN_18046c400(0);
              if (lVar4 == null) goto LAB_1809c20e2;
              if (!lVar4.cityAreaID) {
                if ((*pStatics_2dd8 != 0) &&
                   (lVar4 = *(int64 *)(*pStatics_2dd8 + 24)) != null) {
                  cVar2 = GameObject.get_activeSelf(lVar4,0);
                  if (cVar2) {
                    lVar4 = FUN_18046c160(0);
                    if (lVar4 == null) goto LAB_1809c20e2;
                    GameMenuController.UnshowGameMenu(lVar4,0);
                  }
                  if ((*pStatics_01c8 != 0) &&
                     (lVar4 = *(int64 *)(*pStatics_01c8 + 24)) != null) {
                    cVar2 = GameObject.get_activeSelf(lVar4,0);
                    if (cVar2) {
                      lVar4 = FUN_1807e6430(0);
                      if (lVar4 == null) goto LAB_1809c20e2;
                      BattleAiMenuController.UnShowBattleAiMenu(lVar4,0);
                    }
                    if ((*(int64 *)(lVar11 + 0x180) != 0) &&
                       (lVar4 = GameObject.GetComponent(*(int64 *)(lVar11 + 0x180),DAT_181d743b0),
                       lVar4 != null)) {
                      Toggle.set_isOn(lVar4,0,0);
                      if (*(char *)(lVar11 + 0x1ac) == false) {
                        BattleController.BattleRealEnd(lVar11,0);
                        return false;
                      }
                      if ((*(int64 *)(lVar11 + 112) != 0) &&
                         (lVar4 = FUN_180002f80(*(int64 *)(lVar11 + 112),
                                                *(uint32 *)(lVar11 + 48),DAT_181d7f830), lVar4 != null)
                         ) {
                        uVar5 = "FightWin";
                        if (*(char *)(lVar4 + 20) == false) {
                          uVar5 = "FightLose";
                        }
                        uVar5 = String.Concat("Sound/SoundEffect/",uVar5,0);
                        plVar6 = (int64 *)Resources.Load(uVar5,0);
                        plVar12 = (int64 *)0;
                        if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181daf348)) {
                          plVar12 = plVar6;
                        }
                        NGUITools.PlaySound(plVar12,0);
                        iVar13 = 0;
                        while (*(int64 *)(lVar11 + 112) != 0) {
                          if (*(int *)(*(int64 *)(lVar11 + 112) + 24) <= iVar13) {
                            lVar4 = FUN_18046c1a0(0);
                            if ((((lVar4 == null) || (lVar4.Inns == null)) ||
                                (lVar4 = GameObject.get_transform(lVar4.Inns,0),
                                lVar4 == null)) ||
                               ((lVar4 = Transform.Find(lVar4,"BattleEndUI",0), lVar4 == null ||
                                (lVar4 = Component.get_gameObject(lVar4,0)) == null))) break;
                            GameObject.SetActive(lVar4,1,0);
                            lVar4 = FUN_18046c1a0(0);
                            if ((((lVar4 == null) ||
                                 ((lVar4.Inns == null ||
                                  (lVar4 = GameObject.get_transform(lVar4.Inns,0),
                                  lVar4 == null)))) ||
                                (lVar4 = Transform.Find(lVar4,"BattleEndUI",0)) == null) ||
                               (lVar4 = Component.GetComponent(lVar4,DAT_181d938e0)) == null) break;
                            CanvasGroup.set_alpha(lVar4);
                            lVar4 = FUN_18046c1a0(0);
                            if ((((lVar4 == null) || (lVar4.Inns == null)) ||
                                (lVar4 = GameObject.get_transform(lVar4.Inns,0),
                                lVar4 == null)) ||
                               (lVar4 = Transform.Find(lVar4,"BattleEndUI",0)) == null) break;
                            uVar5 = Component.GetComponent(lVar4,DAT_181d938e0);
                            DOTweenModuleUI.DOFade(uVar5);
                            lVar4 = FUN_18046c1a0(0);
                            if (((lVar4 == null) || (lVar4.Inns == null)) ||
                               ((lVar4 = GameObject.get_transform(lVar4.Inns,0),
                                lVar4 == null ||
                                ((lVar4 = Transform.Find(lVar4,"BattleEndUI",0), lVar4 == null ||
                                 (lVar4 = Transform.Find(lVar4,"Result",0)) == null))))) break;
                            lVar4 = Component.GetComponent(lVar4,DAT_181d94460);
                            if ((*(int64 *)(lVar11 + 112) == 0) ||
                               (lVar7 = FUN_180002f80(*(int64 *)(lVar11 + 112),
                                                      *(uint32 *)(lVar11 + 48),DAT_181d7f830),
                               lVar7 == null)) break;
                            if (*(char *)(lVar7 + 20) == false) {
                              uVar5 = *(uint64 *)(lVar11 + 0x278);
                            }
                            else {
                              uVar5 = *(uint64 *)(lVar11 + 0x270);
                            }
                            if (lVar4 == null) break;
                            Image.set_sprite(lVar4,uVar5,0);
                            lVar4 = FUN_18046c1a0(0);
                            if ((((lVar4 == null) || (lVar4.Inns == null)) ||
                                (lVar4 = GameObject.get_transform(lVar4.Inns,0),
                                lVar4 == null)) ||
                               (lVar4 = Transform.Find(lVar4,"BattleEndUI",0)) == null) break;
                            lVar4 = Transform.Find(lVar4,"Result",0);
                            puVar8 = (uint64 *)Vector3.get_one(&local_98,0);
                            local_b8 = *puVar8;
                            local_b0 = *(float *)(puVar8 + 1);
                            local_c0 = local_b0 * 10.0;
                            local_c8 = CONCAT44((float)((uint64)local_b8 >> 32) * 10.0,
                                                (float)local_b8 * 10.0);
                            if (lVar4 == null) break;
                            local_b8 = local_c8;
                            local_b0 = local_c0;
                            Transform.set_localScale(lVar4,&local_b8,0);
                            lVar4 = FUN_18046c1a0(0);
                            if (((lVar4 == null) || (lVar4.Inns == null)) ||
                               ((lVar4 = GameObject.get_transform(lVar4.Inns,0),
                                lVar4 == null || (lVar4 = Transform.Find(lVar4,"BattleEndUI",0)) == null
                                ))) break;
                            uVar5 = Transform.Find(lVar4,"Result",0);
                            uVar5 = ShortcutExtensions.DOScale(uVar5);
                            uVar5 = TweenSettingsExtensions.SetDelay(uVar5);
                            TweenSettingsExtensions.SetEase(uVar5,9,DAT_181dc0f80);
                            if ((*(int64 *)(lVar11 + 112) == 0) ||
                               (lVar4 = FUN_180002f80(*(int64 *)(lVar11 + 112),
                                                      *(uint32 *)(lVar11 + 48),DAT_181d7f830),
                               lVar4 == null)) break;
                            auVar20._0_8_ = BattleController.CountPlayerBattleScore(lVar11);
                            auVar20._8_8_ = extraout_XMM0_Qb;
                            auVar21._4_12_ = auVar20._4_12_;
                            auVar21._0_4_ = (float)auVar20._0_8_ / 20.0;
                            uVar3 = Mathf.RoundToInt(auVar21._0_8_,0);
                            lVar4 = FUN_18046c1a0(0);
                            if ((lVar4 == null) ||
                               ((((lVar4.Inns == null ||
                                  (lVar4 = GameObject.get_transform(lVar4.Inns,0),
                                  lVar4 == null)) ||
                                 (lVar4 = Transform.Find(lVar4,"BattleEndUI",0)) == null) ||
                                (lVar4 = Transform.Find(lVar4,"Rate",0)) == null))) break;
                            uVar5 = Component.GetComponent(lVar4,DAT_181d96160);
                            lVar4 = *(int64 *)(pStatics_3d40 + 0x5c0);
                            if (lVar4 == null) break;
                            uVar9 = FUN_180002f80(lVar4,uVar3,DAT_181da4358);
                            LTLocalization.SetText(uVar5,uVar9,0);
                            lVar4 = FUN_18046c1a0(0);
                            if ((((lVar4 == null) || (lVar4.Inns == null)) ||
                                (lVar4 = GameObject.get_transform(lVar4.Inns,0),
                                lVar4 == null)) ||
                               ((lVar4 = Transform.Find(lVar4,"BattleEndUI",0), lVar4 == null ||
                                (lVar4 = Transform.Find(lVar4,"Rate",0)) == null))) break;
                            plVar6 = (int64 *)Component.GetComponent(lVar4,DAT_181d96160);

                            if ((lVar4 = FUN_18046c100(0)?.Inns) == null) break;
                            if (lVar4.cityAreaID <= uVar3) {
                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                            }
                            lVar4 = *(int64 *)
                                     (lVar4.chapter + 32 + (int64)(int)uVar3 * 8);
                            if ((lVar4 == null) || (plVar6 == (int64 *)0)) break;
                            local_98 = lVar4.cityAreaID;
                            uStack_90 = lVar4.villageAreaID;
                            (**(code **)(*plVar6 + 0x2a8))
                                      (plVar6,&local_98,*(uint64 *)(*plVar6 + 0x2b0));
                            uVar5 = *(uint64 *)(lVar11 + 0x1b0);
                            cVar2 = Object.op_Inequality(uVar5,0,0);
                            if (!cVar2) {
                              lVar4 = FUN_18046c1a0(0);
                              if (((lVar4 == null) || (lVar4.Inns == null)) ||
                                 ((lVar4 = GameObject.get_transform(lVar4.Inns,0),
                                  lVar4 == null ||
                                  ((lVar4 = Transform.Find(lVar4,"BattleEndUI",0), lVar4 == null ||
                                   (lVar4 = Transform.Find(lVar4,"Info",0)) == null)))))
                              break;
                              uVar5 = Component.GetComponent(lVar4,DAT_181d96160);
                              LTLocalization.SetText(uVar5,"",0);
                            }
                            else {
                              lVar4 = FUN_18046c1a0(0);
                              if ((((lVar4 == null) || (lVar4.Inns == null)) ||
                                  (lVar4 = GameObject.get_transform(lVar4.Inns,0),
                                  lVar4 == null)) ||
                                 ((lVar4 = Transform.Find(lVar4,"BattleEndUI",0), lVar4 == null ||
                                  (lVar4 = Transform.Find(lVar4,"Info",0)) == null))) {
        LAB_1809c216e:
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              uVar5 = Component.GetComponent(lVar4,DAT_181d96160);
                              plVar6 = (int64 *)FUN_1800d60b0(DAT_181da4120,4);
                              local_res18[0] = (int)*(float *)(lVar11 + 0x1c8);
                              lVar4 = il2cpp_value_box(DAT_181d80418,local_res18);
                              if (plVar6 == (int64 *)0) goto LAB_1809c216e;
                              if ((lVar4 != null) &&
                                 (lVar7 = il2cpp_internal(lVar4,*(uint64 *)(*plVar6 + 64)),
                                 lVar7 == null)) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              if ((int)plVar6[3] == 0) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              plVar6[4] = lVar4;
                              il2cpp_internal(plVar6 + 4,lVar4);
                              if ((*(int64 *)(lVar11 + 0x1b0) == 0) ||
                                 (lVar4 = *(int64 *)(*(int64 *)(lVar11 + 0x1b0) + 168)) == null
                                 ) goto LAB_1809c216e;
                              local_res20[0] = lVar4.chapter;
                              lVar4 = il2cpp_value_box(DAT_181d80418,local_res20);
                              if ((lVar4 != null) &&
                                 (lVar7 = il2cpp_internal(lVar4,*(uint64 *)(*plVar6 + 64)),
                                 lVar7 == null)) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              if (*(uint32 *)(plVar6 + 3) < 2) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              plVar6[5] = lVar4;
                              il2cpp_internal(plVar6 + 5,lVar4);
                              if ((*(int64 *)(lVar11 + 0x1b0) == 0) ||
                                 (lVar4 = *(int64 *)(*(int64 *)(lVar11 + 0x1b0) + 168)) == null
                                 ) goto LAB_1809c216e;
                              local_d8 = Mathf.RoundToInt(lVar4,0);
                              lVar4 = il2cpp_value_box(DAT_181d80418,&local_d8);
                              if ((lVar4 != null) &&
                                 (lVar7 = il2cpp_internal(lVar4,*(uint64 *)(*plVar6 + 64)),
                                 lVar7 == null)) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              if (*(uint32 *)(plVar6 + 3) < 3) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              plVar6[6] = lVar4;
                              il2cpp_internal(plVar6 + 6,lVar4);
                              if ((*(int64 *)(lVar11 + 0x1b0) == 0) ||
                                 (lVar4 = *(int64 *)(*(int64 *)(lVar11 + 0x1b0) + 168)) == null
                                 ) goto LAB_1809c216e;
                              local_d4[0] = Mathf.RoundToInt(lVar4,0);
                              lVar4 = il2cpp_value_box(DAT_181d80418,local_d4);
                              if ((lVar4 != null) &&
                                 (lVar7 = il2cpp_internal(lVar4,*(uint64 *)(*plVar6 + 64)),
                                 lVar7 == null)) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              if (*(uint32 *)(plVar6 + 3) < 4) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              plVar6[7] = lVar4;
                              il2cpp_internal(plVar6 + 7,lVar4);
                              uVar9 = String.Format("战斗时长 {0}    击败敌人 {1}    造成伤害 {2}    承受伤害 {3}",plVar6,0);
                              LTLocalization.SetText(uVar5,uVar9,0);
                              lVar4 = FUN_18046c0a0(0);
                              if ((((lVar4 == null) || (lVar4.villageAreaID == null)) ||
                                  (*(int64 *)(lVar11 + 0x1b0) == 0)) ||
                                 (lVar7 = *(int64 *)(*(int64 *)(lVar11 + 0x1b0) + 168)) == null
                                 ) goto LAB_1809c216e;
                              piVar1 = (int *)(lVar4.villageAreaID + 0x194);
                              *piVar1 = *piVar1 + *(int *)(lVar7 + 16);
                              lVar4 = FUN_18046c100(0);
                              if (((*(int64 *)(lVar11 + 0x1b0) == 0) ||
                                  (*(int64 *)(*(int64 *)(lVar11 + 0x1b0) + 168) == 0)) ||
                                 (lVar4 == null)) goto LAB_1809c216e;
                              GameDataController.ChangeAchStats(lVar4,0);
                              if ((*(int64 *)(lVar11 + 0x1b0) == 0) ||
                                 (lVar4 = *(int64 *)(*(int64 *)(lVar11 + 0x1b0) + 168)) == null
                                 ) goto LAB_1809c216e;
                              if (9 < lVar4.chapter) {
                                lVar4 = FUN_18046c100(0);
                                if (lVar4 == null) break;
                                GameDataController.ChangeAchStats(lVar4,23);
                              }
                              lVar4 = FUN_18046c0a0(0);
                              if (((lVar4 == null) || (lVar4.villageAreaID == null)) ||
                                 (lVar4 = WorldData.Player(lVar4.villageAreaID,0)) == null)
                              break;
                              HeroData.AddTag(lVar4,0x163);
                            }
                            if ((*(int64 *)(lVar11 + 112) == 0) ||
                               (lVar4 = FUN_180002f80(*(int64 *)(lVar11 + 112),
                                                      *(uint32 *)(lVar11 + 48),DAT_181d7f830),
                               lVar4 == null)) break;
                            if (*(char *)(lVar4 + 20) != false) {
                              lVar4 = FUN_18046c0a0(0);
                              if ((lVar4 == null) || (lVar4.villageAreaID == null)) break;
                              piVar1 = (int *)(lVar4.villageAreaID + 400);
                              *piVar1 = *piVar1 + 1;
                              lVar4 = FUN_18046c100(0);
                              if (lVar4 == null) break;
                              GameDataController.ChangeAchStats(lVar4,1);
                            }
                            if ((*(int64 *)(lVar11 + 112) != 0) &&
                               (lVar4 = FUN_180002f80(*(int64 *)(lVar11 + 112),
                                                      *(uint32 *)(lVar11 + 48),DAT_181d7f830),
                               lVar4 != null)) {
                              if (*(char *)(lVar4 + 20) != false) {
                                iVar13 = 0;
                                goto LAB_1809c0390;
                              }
                              lVar4 = FUN_18046c0a0(0);
                              if (((lVar4 != null) && (lVar4.villageAreaID != null)) &&
                                 (lVar4 = WorldData.Player(lVar4.villageAreaID,0)) != null) {
                                fVar16 = (float)Mathf.Min(*(float *)(lVar4 + 0x1c4) * -0.01);
                                local_res8[0] = fVar16;
                                fVar17 = (float)Mathf.Max();
                                lVar4 = *(int64 *)(pStatics_3d40 + 0x6a8);
                                if (lVar4 != null) {
                                  fVar18 = (float)FUN_1800d6790(lVar4,*(uint32 *)(lVar11 + 32),
                                                                DAT_181da1078);
                                  goto LAB_1809c0543;
                                }
                              }
                            }
                            break;
                          }
                          iVar14 = 0;
                          while( true ) {
                            if (((*(int64 *)(lVar11 + 112) == 0) ||
                                (lVar4 = FUN_180002f80()) == null) ||
                               (lVar4.cityAreaID == null)) goto LAB_1809c20e2;
                            if (*(int *)(lVar4.cityAreaID + 24) <= iVar14) break;
                            if ((((*(int64 *)(lVar11 + 112) == 0) ||
                                 (lVar4 = FUN_180002f80(*(int64 *)(lVar11 + 112),iVar13,DAT_181d7f830)
                                 , lVar4 == null)) || (lVar4.cityAreaID == null)) ||
                               (lVar4 = FUN_180002f80(lVar4.cityAreaID,iVar14,DAT_181d7fc20),
                               lVar4 == null)) goto LAB_1809c20e2;
                            lVar4 = lVar4.ResourcePoints;
                            if (((*(int64 *)(lVar11 + 112) == 0) ||
                                (lVar7 = FUN_180002f80(*(int64 *)(lVar11 + 112),iVar13,DAT_181d7f830),
                                lVar7 == null)) || (*(int64 *)(lVar7 + 24) == 0)) goto LAB_1809c20e2;
                            uVar5 = FUN_180002f80(*(int64 *)(lVar7 + 24),iVar14,DAT_181d7fc20);
                            uVar15 = BattleController.CountHeroBattleContribution
                                               (lVar11,uVar5,iVar13 == *(int *)(lVar11 + 48));
                            if (lVar4 == null) goto LAB_1809c20e2;
                            lVar4.TimeDifficulty = uVar15;
                            if (((*(int64 *)(lVar11 + 112) == 0) ||
                                (lVar4 = FUN_180002f80(*(int64 *)(lVar11 + 112),iVar13,DAT_181d7f830),
                                lVar4 == null)) ||
                               ((*(char *)(lVar4 + 20) == false &&
                                ((((*(int64 *)(lVar11 + 112) == 0 ||
                                   (lVar4 = FUN_180002f80(*(int64 *)(lVar11 + 112),iVar13,
                                                          DAT_181d7f830), lVar4 == null)) ||
                                  (lVar4.cityAreaID == null)) ||
                                 ((lVar4 = FUN_180002f80(lVar4.cityAreaID,iVar14,DAT_181d7fc20)
                                  , lVar4 == null || (lVar4.ResourcePoints == null))))))))
                            goto LAB_1809c20e2;
                            iVar14 = iVar14 + 1;
                          }
                          iVar13 = iVar13 + 1;
                        }
                      }
                    }
                  }
                }
                goto LAB_1809c20e2;
              }
            }
            lVar4 = FUN_18046c400(0);
            if (lVar4 != null) {
              if (lVar4.cityAreaID) {
        LAB_1809c1f2c:
                uVar5 = new WaitForSecondsRealtime();
                this.<>2__current = uVar5;
                this.<>1__state = 2;
                return true;
              }
              lVar7 = FUN_18046c400(0);
              lVar4 = *(int64 *)(lVar11 + 128);
              if (lVar4 != null) {
                if (lVar4.cityAreaID == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar4 = *(int64 *)(lVar4.chapter + 32);
                if ((lVar4 != null) && (lVar7 != null)) {
                  PlotController.ChangePlotDataBase(lVar7,lVar4.villageAreaID,0);
                  if (*(int64 *)(lVar11 + 128) != 0) {
                    FUN_181823590(*(int64 *)(lVar11 + 128),0,DAT_181d7f3b0);
                    goto LAB_1809c1f2c;
                  }
                }
              }
            }
          }
        }
        LAB_1809c20e2:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_1809c0390:
        fVar16 = local_res8[0];
        if (*(int64 *)(lVar11 + 112) == 0) goto LAB_1809c20e2;
        if (*(int *)(*(int64 *)(lVar11 + 112) + 24) <= iVar13) {
          lVar4 = *(int64 *)(pStatics_3d40 + 0x6a8);
          if (lVar4 != null) {
            fVar18 = (float)FUN_1800d6790(lVar4,*(uint32 *)(lVar11 + 32),DAT_181da1078);
            fVar17 = (float)auVar20._0_8_ * 0.01;
        LAB_1809c0543:
            local_res8[0] = fVar18 * fVar17 * fVar16;
            lVar4 = FUN_18046c0a0(0);
            if (((lVar4 == null) || (lVar4.villageAreaID == null)) ||
               (lVar4 = WorldData.Player(lVar4.villageAreaID,0)) == null) goto LAB_1809c20e2;
            HeroData.ChangeFame(lVar4);
            lVar4 = FUN_18046c1a0(0);
            if (((lVar4 == null) || (lVar4.Inns == null)) ||
               ((lVar4 = GameObject.get_transform(lVar4.Inns,0), lVar4 == null ||
                ((lVar4 = Transform.Find(lVar4,"BattleEndUI",0), lVar4 == null ||
                 (lVar4 = Transform.Find(lVar4,"Fame",0)) == null))))) goto LAB_1809c20e2;
            uVar5 = Component.GetComponent(lVar4,DAT_181d96160);
            if (local_res8[0] < 0.0) {
              uVar9 = *(uint64 *)(pStatics_3d40 + 0x2d0);
            }
            else if (local_res8[0] == 0.0) {
              uVar9 = *(uint64 *)(pStatics_3d40 + 0x340);
            }
            else {
              uVar9 = *(uint64 *)(pStatics_3d40 + 0x268);
            }
            uVar10 = "+0.#;-0.#;0";
            if (1.0 <= ABS(local_res8[0])) {
              uVar10 = "+0;-0;0";
            }
            uVar10 = Single.ToString(local_res8,uVar10,0);
            uVar9 = String.Concat(uVar9,uVar10,"</color>",0);
            LTLocalization.SetText(uVar5,uVar9,0);
            lVar4 = FUN_18046c1a0(0);
            if ((((lVar4 == null) || (lVar4.Inns == null)) ||
                (lVar4 = GameObject.get_transform(lVar4.Inns,0)) == null) ||
               ((lVar4 = Transform.Find(lVar4,"BattleEndUI",0), lVar4 == null ||
                (lVar4 = Transform.Find(lVar4,"BaseSkillGrid",0)) == null))) goto LAB_1809c20e2;
            uVar5 = Component.get_gameObject(lVar4,0);
            GlobalData.DeleteAllChild(uVar5,0);
            lVar4 = FUN_18046c1a0(0);
            if (((lVar4 == null) || (lVar4.Inns == null)) ||
               ((lVar4 = GameObject.get_transform(lVar4.Inns,0), lVar4 == null ||
                ((lVar4 = Transform.Find(lVar4,"BattleEndUI",0), lVar4 == null ||
                 (lVar4 = Transform.Find(lVar4,"SkillGrid",0)) == null))))) goto LAB_1809c20e2;
            uVar5 = Component.get_gameObject(lVar4,0);
            GlobalData.DeleteAllChild(uVar5,0);
            lVar4 = FUN_18046c1a0(0);
            if ((lVar4 == null) ||
               ((((lVar4.Inns == null ||
                  (lVar4 = GameObject.get_transform(lVar4.Inns,0)) == null) ||
                 (lVar4 = Transform.Find(lVar4,"BattleEndUI",0)) == null) ||
                ((lVar4 = Transform.Find(lVar4,"SkillCountInfo",0), lVar4 == null ||
                 (lVar4 = Component.GetComponent(lVar4,DAT_181d95560)) == null)))))
            goto LAB_1809c20e2;
            puVar8 = (uint64 *)(lVar4 + 24);
            *puVar8 = "";
            il2cpp_internal(puVar8);
            lVar4 = FUN_18046c0a0(0);
            if (((lVar4 == null) || (lVar4.villageAreaID == null)) ||
               (lVar4 = WorldData.Player(lVar4.villageAreaID,0)) == null) goto LAB_1809c20e2;
            if (lVar4.herosDictLock != null) {
              lVar4 = FUN_18046c1a0(0);
              if ((((lVar4 == null) || (lVar4.Inns == null)) ||
                  (lVar4 = GameObject.get_transform(lVar4.Inns,0)) == null) ||
                 ((lVar4 = Transform.Find(lVar4,"BattleEndUI",0), lVar4 == null ||
                  (lVar4 = Transform.Find(lVar4,"BaseSkillGrid",0)) == null))) goto LAB_1809c20e2;
              uVar5 = Component.get_gameObject(lVar4,0);
              lVar4 = FUN_18046c1a0(0);
              if (lVar4 == null) goto LAB_1809c20e2;
              uVar9 = lVar4.forceMeetingStarted;
              uVar5 = GlobalData.AddChild(uVar5,uVar9,0);
              *(uint64 *)(lVar11 + 0x280) = uVar5;
              if (*(int64 *)(lVar11 + 0x280) == 0) goto LAB_1809c20e2;
              lVar4 = GameObject.GetComponent(*(int64 *)(lVar11 + 0x280),DAT_181d736f0);
              lVar7 = FUN_18046c0a0(0);
              if ((((lVar7 == null) || (*(int64 *)(lVar7 + 32) == 0)) ||
                  (lVar7 = WorldData.Player(*(int64 *)(lVar7 + 32),0)) == null) || (lVar4 == null))
              goto LAB_1809c20e2;
              lVar4.cityAreaID = *(uint64 *)(lVar7 + 0x270);
              lVar4 = FUN_18046c0a0(0);
              if (((lVar4 == null) || (lVar4.villageAreaID == null)) ||
                 ((lVar4 = WorldData.Player(lVar4.villageAreaID,0), lVar4 == null ||
                  (lVar4.herosDictLock == null)))) goto LAB_1809c20e2;
              if (0 < *(int *)(lVar4.herosDictLock + 92)) {
                uVar5 = *puVar8;
                cVar2 = FUN_180d755b0(uVar5,0);
                uVar9 = "\n";
                if (cVar2) {
                  uVar9 = "";
                }
                lVar4 = FUN_18046c0a0(0);
                if ((((lVar4 == null) || (lVar4.villageAreaID == null)) ||
                    (lVar4 = WorldData.Player(lVar4.villageAreaID,0)) == null) ||
                   (lVar4.herosDictLock == null)) goto LAB_1809c20e2;
                uVar10 = KungfuSkillLvData.GetSkillBattleCountDescribe(lVar4.herosDictLock,0);
                uVar5 = String.Concat(uVar5,uVar9,uVar10,0);
                *puVar8 = uVar5;
                il2cpp_internal(puVar8,uVar5);
              }
            }
            lVar4 = FUN_18046c0a0(0);
            if (((lVar4 == null) || (lVar4.villageAreaID == null)) ||
               (lVar4 = WorldData.Player(lVar4.villageAreaID,0)) == null) goto LAB_1809c20e2;
            if (lVar4.tempHerosDictLock != null) {
              lVar4 = FUN_18046c1a0(0);
              if ((((lVar4 == null) || (lVar4.Inns == null)) ||
                  (lVar4 = GameObject.get_transform(lVar4.Inns,0)) == null) ||
                 ((lVar4 = Transform.Find(lVar4,"BattleEndUI",0), lVar4 == null ||
                  (lVar4 = Transform.Find(lVar4,"BaseSkillGrid",0)) == null))) goto LAB_1809c20e2;
              uVar5 = Component.get_gameObject(lVar4,0);
              lVar4 = FUN_18046c1a0(0);
              if (lVar4 == null) goto LAB_1809c20e2;
              uVar9 = lVar4.forceMeetingStarted;
              uVar5 = GlobalData.AddChild(uVar5,uVar9,0);
              *(uint64 *)(lVar11 + 0x280) = uVar5;
              if (*(int64 *)(lVar11 + 0x280) == 0) goto LAB_1809c20e2;
              lVar4 = GameObject.GetComponent(*(int64 *)(lVar11 + 0x280),DAT_181d736f0);
              lVar7 = FUN_18046c0a0(0);
              if ((((lVar7 == null) || (*(int64 *)(lVar7 + 32) == 0)) ||
                  (lVar7 = WorldData.Player(*(int64 *)(lVar7 + 32),0)) == null) || (lVar4 == null))
              goto LAB_1809c20e2;
              lVar4.cityAreaID = *(uint64 *)(lVar7 + 0x280);
              lVar4 = FUN_18046c0a0(0);
              if (((lVar4 == null) || (lVar4.villageAreaID == null)) ||
                 ((lVar4 = WorldData.Player(lVar4.villageAreaID,0), lVar4 == null ||
                  (lVar4.tempHerosDictLock == null)))) goto LAB_1809c20e2;
              if (0 < *(int *)(lVar4.tempHerosDictLock + 92)) {
                uVar5 = *puVar8;
                cVar2 = FUN_180d755b0(uVar5,0);
                uVar9 = "\n";
                if (cVar2) {
                  uVar9 = "";
                }
                lVar4 = FUN_18046c0a0(0);
                if ((((lVar4 == null) || (lVar4.villageAreaID == null)) ||
                    (lVar4 = WorldData.Player(lVar4.villageAreaID,0)) == null) ||
                   (lVar4.tempHerosDictLock == null)) goto LAB_1809c20e2;
                uVar10 = KungfuSkillLvData.GetSkillBattleCountDescribe(lVar4.tempHerosDictLock,0);
                uVar5 = String.Concat(uVar5,uVar9,uVar10,0);
                *puVar8 = uVar5;
                il2cpp_internal(puVar8,uVar5);
              }
            }
            lVar4 = FUN_18046c0a0(0);
            if (((lVar4 == null) || (lVar4.villageAreaID == null)) ||
               (lVar4 = WorldData.Player(lVar4.villageAreaID,0)) == null) goto LAB_1809c20e2;
            if (lVar4.AreasDict != null) {
              lVar4 = FUN_18046c1a0(0);
              if ((((lVar4 == null) || (lVar4.Inns == null)) ||
                  (lVar4 = GameObject.get_transform(lVar4.Inns,0)) == null) ||
                 ((lVar4 = Transform.Find(lVar4,"BattleEndUI",0), lVar4 == null ||
                  (lVar4 = Transform.Find(lVar4,"BaseSkillGrid",0)) == null))) goto LAB_1809c20e2;
              uVar5 = Component.get_gameObject(lVar4,0);
              lVar4 = FUN_18046c1a0(0);
              if (lVar4 == null) goto LAB_1809c20e2;
              uVar9 = lVar4.forceMeetingStarted;
              uVar5 = GlobalData.AddChild(uVar5,uVar9,0);
              *(uint64 *)(lVar11 + 0x280) = uVar5;
              if (*(int64 *)(lVar11 + 0x280) == 0) goto LAB_1809c20e2;
              lVar4 = GameObject.GetComponent(*(int64 *)(lVar11 + 0x280),DAT_181d736f0);
              lVar7 = FUN_18046c0a0(0);
              if ((((lVar7 == null) || (*(int64 *)(lVar7 + 32) == 0)) ||
                  (lVar7 = WorldData.Player(*(int64 *)(lVar7 + 32),0)) == null) || (lVar4 == null))
              goto LAB_1809c20e2;
              lVar4.cityAreaID = *(uint64 *)(lVar7 + 0x290);
              lVar4 = FUN_18046c0a0(0);
              if (((lVar4 == null) || (lVar4.villageAreaID == null)) ||
                 ((lVar4 = WorldData.Player(lVar4.villageAreaID,0), lVar4 == null ||
                  (lVar4.AreasDict == null)))) goto LAB_1809c20e2;
              if (0 < *(int *)(lVar4.AreasDict + 92)) {
                uVar5 = *puVar8;
                cVar2 = FUN_180d755b0(uVar5,0);
                uVar9 = "\n";
                if (cVar2) {
                  uVar9 = "";
                }
                lVar4 = FUN_18046c0a0(0);
                if ((((lVar4 == null) || (lVar4.villageAreaID == null)) ||
                    (lVar4 = WorldData.Player(lVar4.villageAreaID,0)) == null) ||
                   (lVar4.AreasDict == null)) goto LAB_1809c20e2;
                uVar10 = KungfuSkillLvData.GetSkillBattleCountDescribe(lVar4.AreasDict,0);
                uVar5 = String.Concat(uVar5,uVar9,uVar10,0);
                *puVar8 = uVar5;
                il2cpp_internal(puVar8,uVar5);
              }
            }
            iVar13 = 0;
            while( true ) {
              if ((GameController._instance == null) ||
                 (lVar4 = GameController._instance.worldData) == null)
              goto LAB_1809c2168;
              lVar4 = lVar4.Heros;
              if (lVar4 == null) goto LAB_1809c2168;
              if (lVar4.cityAreaID == null) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar4 = *(int64 *)(lVar4.chapter + 32);
              if ((lVar4 = lVar4?.innDict) == null) goto LAB_1809c2168;
              if (lVar4.cityAreaID <= iVar13) break;
              lVar4 = FUN_18046c0a0(0);
              if ((((lVar4 == null) || (lVar4.villageAreaID == null)) ||
                  (lVar4 = WorldData.Player(lVar4.villageAreaID,0)) == null) ||
                 (lVar4.innDict == null)) goto LAB_1809c20e2;
              lVar4 = FUN_180002f80(lVar4.innDict,iVar13);
              if (lVar4 != null) {
                lVar4 = FUN_18046c1a0(0);
                if (((lVar4 == null) || (lVar4.Inns == null)) ||
                   ((lVar4 = GameObject.get_transform(lVar4.Inns,0), lVar4 == null ||
                    ((lVar4 = Transform.Find(lVar4,"BattleEndUI",0), lVar4 == null ||
                     (lVar4 = Transform.Find(lVar4,"SkillGrid",0)) == null))))) goto LAB_1809c20e2;
                uVar5 = Component.get_gameObject(lVar4,0);
                lVar4 = FUN_18046c1a0(0);
                if (lVar4 == null) goto LAB_1809c20e2;
                uVar9 = lVar4.forceMeetingStarted;
                uVar5 = GlobalData.AddChild(uVar5,uVar9,0);
                *(uint64 *)(lVar11 + 0x280) = uVar5;
                if (*(int64 *)(lVar11 + 0x280) == 0) goto LAB_1809c20e2;
                lVar4 = GameObject.GetComponent(*(int64 *)(lVar11 + 0x280),DAT_181d736f0);
                lVar7 = FUN_18046c0a0(0);
                if ((((lVar7 == null) || (*(int64 *)(lVar7 + 32) == 0)) ||
                    (lVar7 = WorldData.Player(*(int64 *)(lVar7 + 32),0)) == null) ||
                   ((*(int64 *)(lVar7 + 0x2a0) == 0 ||
                    (uVar5 = FUN_180002f80(*(int64 *)(lVar7 + 0x2a0),iVar13,DAT_181d92590), lVar4 == null)
                    ))) goto LAB_1809c2168;
                lVar4.cityAreaID = uVar5;
                lVar4 = FUN_18046c0a0(0);
                if ((((lVar4 == null) ||
                     ((lVar4.villageAreaID == null ||
                      (lVar4 = WorldData.Player(lVar4.villageAreaID,0)) == null))) ||
                    (lVar4.innDict == null)) ||
                   (lVar4 = FUN_180002f80(lVar4.innDict,iVar13)) == null)
                goto LAB_1809c2168;
                if (0 < *(int *)(lVar4 + 92)) {
                  uVar5 = *puVar8;
                  cVar2 = FUN_180d755b0(uVar5,0);
                  uVar9 = "\n";
                  if (cVar2) {
                    uVar9 = "";
                  }
                  lVar4 = FUN_18046c0a0(0);
                  if ((((lVar4 == null) || (lVar4.villageAreaID == null)) ||
                      (lVar4 = WorldData.Player(lVar4.villageAreaID,0)) == null) ||
                     ((lVar4.innDict == null ||
                      (lVar4 = FUN_180002f80(lVar4.innDict,iVar13,DAT_181d92590),
                      lVar4 == null)))) goto LAB_1809c2168;
                  KungfuSkillLvData.GetSkillBattleCountDescribe(lVar4,0);
                  uVar5 = String.Concat(uVar5,uVar9);
                  *puVar8 = uVar5;
                  il2cpp_internal(puVar8,uVar5);
                }
              }
              iVar13 = iVar13 + 1;
            }
            lVar4 = FUN_18046c1a0(0);
            if ((((lVar4 == null) || (lVar4.Inns == null)) ||
                (lVar4 = GameObject.get_transform(lVar4.Inns,0)) == null) ||
               (((lVar4 = Transform.Find(lVar4,"BattleEndUI",0), lVar4 == null ||
                 (lVar4 = Transform.Find(lVar4,"BaseSkillGrid",0)) == null) ||
                (lVar4 = Component.GetComponent(lVar4,DAT_181d96960)) == null))) goto LAB_1809c2168;
            UIGrid.set_repositionNow(lVar4,1,0);
            lVar4 = FUN_18046c1a0(0);
            if (((lVar4 == null) || (lVar4.Inns == null)) ||
               ((lVar4 = GameObject.get_transform(lVar4.Inns,0), lVar4 == null ||
                (((lVar4 = Transform.Find(lVar4,"BattleEndUI",0), lVar4 == null ||
                  (lVar4 = Transform.Find(lVar4,"SkillGrid",0)) == null) ||
                 (lVar4 = Component.GetComponent(lVar4,DAT_181d96960)) == null)))))
            goto LAB_1809c2168;
            UIGrid.set_repositionNow(lVar4,1,0);
            if ((*(int64 *)(lVar11 + 112) == 0) ||
               (lVar4 = FUN_180002f80(*(int64 *)(lVar11 + 112),*(uint32 *)(lVar11 + 48),
                                      DAT_181d7f830), lVar4 == null)) goto LAB_1809c2168;
            if (*(char *)(lVar4 + 20) == false) {
        LAB_1809c15c5:
              BattleController.ResetTrophyItemList(lVar11,0);
              lVar11 = FUN_18046c1a0(0);
              if ((((lVar11 != null) && (*(int64 *)(lVar11 + 56) != 0)) &&
                  (lVar11 = GameObject.get_transform(*(int64 *)(lVar11 + 56),0)) != null) &&
                 (((lVar11 = Transform.Find(lVar11,"BattleEndUI",0), lVar11 != null &&
                   (lVar11 = Transform.Find(lVar11,"Money",0)) != null) &&
                  (lVar11 = Transform.Find(lVar11,"Icon",0)) != null))) {
                plVar6 = (int64 *)Component.GetComponent(lVar11,DAT_181d94460);
                puVar8 = (uint64 *)FUN_180d98fe0(&local_98,0);
                if (plVar6 != (int64 *)0) {
                  local_98 = *puVar8;
                  uStack_90 = puVar8[1];
                  (**(code **)(*plVar6 + 0x2a8))(plVar6,&local_98,*(uint64 *)(*plVar6 + 0x2b0));
                  lVar11 = FUN_18046c1a0(0);
                  if (((lVar11 != null) && (*(int64 *)(lVar11 + 56) != 0)) &&
                     ((lVar11 = GameObject.get_transform(*(int64 *)(lVar11 + 56),0), lVar11 != null &&
                      ((lVar11 = Transform.Find(lVar11,"BattleEndUI",0), lVar11 != null &&
                       (lVar11 = Transform.Find(lVar11,"Money",0)) != null))))) {
                    uVar5 = Component.GetComponent(lVar11,DAT_181d96160);
                    LTLocalization.SetText(uVar5,"",0);
                    lVar11 = FUN_18046c1a0(0);
                    if (((((lVar11 != null) && (*(int64 *)(lVar11 + 56) != 0)) &&
                         (lVar11 = GameObject.get_transform(*(int64 *)(lVar11 + 56),0)) != null
                         ) && ((lVar11 = Transform.Find(lVar11,"BattleEndUI",0), lVar11 != null &&
                               (lVar11 = Transform.Find(lVar11,"ItemListScrollView",0)) != null))) &&
                       (lVar11 = Component.GetComponent(lVar11,DAT_181d94660)) != null) {
                      ItemListController.ClearAllItem(lVar11,0);
                      return false;
                    }
                  }
                }
              }
            }
            else {
              plVar6 = (int64 *)(lVar11 + 0x1c0);
              lVar4 = *plVar6;
              if ((lVar4 == null) || (lVar4.forceAreaID == null)) goto LAB_1809c2168;
              if ((*(int *)(lVar4.forceAreaID + 24) < 1) && (lVar4.cityAreaID < 1)) {
                if (*(char *)(lVar11 + 0x1b8) == false) goto LAB_1809c15c5;
                uVar3 = 0;
                fVar16 = 0.0;
                fVar17 = 0.0;
                lVar4 = 32;
                while( true ) {
                  lVar7 = *(int64 *)(lVar11 + 112);
                  if (lVar7 == null) goto LAB_1809c2168;
                  if ((int)*(uint32 *)(lVar7 + 24) <= (int)uVar3) break;
                  if (*(uint32 *)(lVar7 + 24) <= uVar3) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar7 = *(int64 *)(lVar4 + *(int64 *)(lVar7 + 16));
                  if (lVar7 == null) goto LAB_1809c2168;
                  if (*(char *)(lVar7 + 20) == false) {
                    iVar13 = 0;
                    while( true ) {
                      if (((*(int64 *)(lVar11 + 112) == 0) || (lVar7 = FUN_180002f80()) == null)
                         || (*(int64 *)(lVar7 + 24) == 0)) goto LAB_1809c2168;
                      if (*(int *)(*(int64 *)(lVar7 + 24) + 24) <= iVar13) break;
                      if ((((*(int64 *)(lVar11 + 112) == 0) ||
                           (lVar7 = FUN_180002f80(*(int64 *)(lVar11 + 112),uVar3,DAT_181d7f830),
                           lVar7 == null)) || (*(int64 *)(lVar7 + 24) == 0)) ||
                         ((lVar7 = FUN_180002f80(*(int64 *)(lVar7 + 24),iVar13,DAT_181d7fc20),
                          lVar7 == null || (*(int64 *)(lVar7 + 64) == 0)))) goto LAB_1809c2168;
                      if (*(char *)(*(int64 *)(lVar7 + 64) + 16) == false) {
                        if (((*(int64 *)(lVar11 + 112) == 0) ||
                            (lVar7 = FUN_180002f80(*(int64 *)(lVar11 + 112),uVar3,DAT_181d7f830),
                            lVar7 == null)) ||
                           ((*(int64 *)(lVar7 + 24) == 0 ||
                            ((lVar7 = FUN_180002f80(*(int64 *)(lVar7 + 24),iVar13,DAT_181d7fc20),
                             lVar7 == null || (*(int64 *)(lVar7 + 64) == 0)))))) goto LAB_1809c2168;
                        if (fVar17 < (float)*(int *)(*(int64 *)(lVar7 + 64) + 184)) {
                          if ((((*(int64 *)(lVar11 + 112) == 0) ||
                               (lVar7 = FUN_180002f80(*(int64 *)(lVar11 + 112),uVar3,DAT_181d7f830),
                               lVar7 == null)) || (*(int64 *)(lVar7 + 24) == 0)) ||
                             ((lVar7 = FUN_180002f80(*(int64 *)(lVar7 + 24),iVar13,DAT_181d7fc20),
                              lVar7 == null || (*(int64 *)(lVar7 + 64) == 0)))) goto LAB_1809c2168;
                          fVar17 = (float)*(int *)(*(int64 *)(lVar7 + 64) + 184);
                        }
                        if (((*(int64 *)(lVar11 + 112) == 0) ||
                            (lVar7 = FUN_180002f80(*(int64 *)(lVar11 + 112),uVar3,DAT_181d7f830),
                            lVar7 == null)) ||
                           ((*(int64 *)(lVar7 + 24) == 0 ||
                            ((lVar7 = FUN_180002f80(*(int64 *)(lVar7 + 24),iVar13,DAT_181d7fc20),
                             lVar7 == null || (*(int64 *)(lVar7 + 64) == 0)))))) goto LAB_1809c2168;
                        fVar18 = (float)FUN_1801f8ab0();
                        fVar16 = fVar16 + fVar18;
                      }
                      iVar13 = iVar13 + 1;
                    }
                  }
                  uVar3 = uVar3 + 1;
                  lVar4 = lVar4 + 8;
                }
                lVar11 = *plVar6;
                auVar22._0_8_ = Random.Range();
                auVar22._8_8_ = extraout_XMM0_Qb_00;
                auVar23._4_12_ = auVar22._4_12_;
                auVar23._0_4_ = (float)auVar22._0_8_ * fVar16;
                uVar15 = Mathf.RoundToInt(auVar23._0_8_,0);
                if (lVar11 == null) goto LAB_1809c2168;
                *(uint32 *)(lVar11 + 24) = uVar15;
                lVar11 = FUN_18046c1a0(0);
                if (((lVar11 == null) || (*(int64 *)(lVar11 + 56) == 0)) ||
                   ((lVar11 = GameObject.get_transform(*(int64 *)(lVar11 + 56),0), lVar11 == null ||
                    (((lVar11 = Transform.Find(lVar11,"BattleEndUI",0), lVar11 == null ||
                      (lVar11 = Transform.Find(lVar11,"Money",0)) == null) ||
                     (lVar11 = Transform.Find(lVar11,"Icon",0)) == null)))))
                goto LAB_1809c2168;
                plVar12 = (int64 *)Component.GetComponent(lVar11,DAT_181d94460);
                puVar8 = (uint64 *)FUN_1810d3570(&local_98,0);
                if (plVar12 == (int64 *)0) goto LAB_1809c2168;
                local_98 = *puVar8;
                uStack_90 = puVar8[1];
                (**(code **)(*plVar12 + 0x2a8))(plVar12,&local_98,*(uint64 *)(*plVar12 + 0x2b0));
                lVar11 = FUN_18046c1a0(0);
                if (((lVar11 == null) || (*(int64 *)(lVar11 + 56) == 0)) ||
                   ((lVar11 = GameObject.get_transform(*(int64 *)(lVar11 + 56),0), lVar11 == null ||
                    ((lVar11 = Transform.Find(lVar11,"BattleEndUI",0), lVar11 == null ||
                     (lVar11 = Transform.Find(lVar11,"Money",0)) == null)))))
                goto LAB_1809c2168;
                uVar5 = Component.GetComponent(lVar11,DAT_181d96160);
                if (*plVar6 == 0) goto LAB_1809c2168;
                uVar9 = Int32.ToString(*plVar6 + 24,"+0;-0;0",0);
                LTLocalization.SetText(uVar5,uVar9,0);
                lVar11 = new ItemListData(0);
                *plVar6 = lVar11;
                il2cpp_internal(plVar6,lVar11);
                lVar4 = FUN_18046c0a0(0);
                lVar11 = *plVar6;
                Random.Range();
                uVar15 = Mathf.RoundToInt();
                uVar15 = Mathf.Max(1,uVar15);
                uVar19 = Mathf.Max();
                if (lVar4 == null) goto LAB_1809c2168;
                GameController.GenerateRandomItem(lVar4,lVar11,uVar15,fVar17 * 1.7,uVar19,0,0,0);
              }
              else {
                lVar11 = FUN_18046c1a0(0);
                if ((((lVar11 == null) || (*(int64 *)(lVar11 + 56) == 0)) ||
                    (lVar11 = GameObject.get_transform(*(int64 *)(lVar11 + 56),0)) == null) ||
                   ((lVar11 = Transform.Find(lVar11,"BattleEndUI",0), lVar11 == null ||
                    (lVar11 = Transform.Find(lVar11,"Money",0)) == null))) goto LAB_1809c2168;
                uVar5 = Component.GetComponent(lVar11,DAT_181d96160);
                if (*plVar6 == 0) goto LAB_1809c2168;
                uVar9 = Int32.ToString(*plVar6 + 24,0);
                uVar9 = String.Concat("银钱 ",uVar9,0);
                LTLocalization.SetText(uVar5,uVar9,0);
              }
              lVar11 = FUN_18046c1a0(0);
              if (((((lVar11 != null) && (*(int64 *)(lVar11 + 56) != 0)) &&
                   (lVar11 = GameObject.get_transform(*(int64 *)(lVar11 + 56),0)) != null) &&
                  ((lVar11 = Transform.Find(lVar11,"BattleEndUI",0), lVar11 != null &&
                   (lVar11 = Transform.Find(lVar11,"ItemListScrollView",0)) != null))) &&
                 (lVar11 = Component.GetComponent(lVar11,DAT_181d94660)) != null) {
                ItemListController.RefreshItemList(lVar11,*plVar6,1,0);
                return false;
              }
            }
        LAB_1809c2168:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          goto LAB_1809c20e2;
        }
        if (*(int *)(lVar11 + 48) != iVar13) {
          iVar14 = 0;
          while( true ) {
            if (((*(int64 *)(lVar11 + 112) == 0) ||
                (lVar4 = FUN_180002f80(*(int64 *)(lVar11 + 112),iVar13,DAT_181d7f830),
                fVar16 = local_res8[0], lVar4 == null)) || (lVar4.cityAreaID == null))
            goto LAB_1809c20e2;
            if (*(int *)(lVar4.cityAreaID + 24) <= iVar14) break;
            if (((*(int64 *)(lVar11 + 112) == 0) ||
                (lVar4 = FUN_180002f80(*(int64 *)(lVar11 + 112),iVar13,DAT_181d7f830)) == null) ||
               ((lVar4.cityAreaID == null ||
                ((lVar4 = FUN_180002f80(lVar4.cityAreaID,iVar14,DAT_181d7fc20), lVar4 == null ||
                 (lVar4.ResourcePoints == null)))))) goto LAB_1809c20e2;
            if (*(char *)(lVar4.ResourcePoints + 16) == false) {
              if ((((*(int64 *)(lVar11 + 112) == 0) ||
                   (lVar4 = FUN_180002f80(*(int64 *)(lVar11 + 112),iVar13,DAT_181d7f830)) == null)
                  || (lVar4.cityAreaID == null)) ||
                 ((lVar4 = FUN_180002f80(lVar4.cityAreaID,iVar14,DAT_181d7fc20), lVar4 == null ||
                  (lVar4.ResourcePoints == null)))) goto LAB_1809c20e2;
              local_res8[0] = (float)Mathf.Max();
              local_res8[0] = fVar16 + local_res8[0];
              iVar14 = iVar14 + 1;
            }
            else {
              iVar14 = iVar14 + 1;
              local_res8[0] = fVar16 + 0.0;
            }
          }
        }
        iVar13 = iVar13 + 1;
        goto LAB_1809c0390;
    }

    // Token : 0x6000C18
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000C19
    // RVA   : 0x9C2180   Offset: 0x9C1580   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d8d510);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d974b8);
    }

    // Token : 0x6000C1A
    // RVA   : 0x20F140   Offset: 0x20E540   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
