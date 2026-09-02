// ============================================================
// Type  : <BattleEnd>d__248
// Token : 0x2000170
// ============================================================

public class <BattleEnd>d__248
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000971
    private int <>1__state;

    // Token: 0x4000972
    private object <>2__current;

    // Token: 0x4000973
    public BattleController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000BEB
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000BEC
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000BED
    // RVA   : 0xB1A9B0   Offset: 0xB191B0   Length: 0x3050
    private virtual bool MoveNext()
    {
        var pStatics_b0a8 = *(int64*)(DAT_181d8b0a8 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_e090 = *(int64*)(DAT_181d4e090 + 184);
        var pStatics_ef00 = *(int64*)(DAT_181d4ef00 + 184);
        bool cVar2;
        long lVar3;
        ulong uVar4;
        long lVar6;
        ulong uVar8;
        ulong uVar9;
        long lVar10;
        int iVar12;
        int iVar13;
        uint uVar14;
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
        iVar12 = this.<>1__state;
        lVar10 = this.<>4__this;
        local_res8[0] = 0.0;
        if (iVar12 == 0) {
          this.<>1__state = 0xffffffff;
          if (lVar10 != null) {
            *(uint32 *)(lVar10 + 36) = 6;
            *(uint32 *)(lVar10 + 0x124) = 12;
            BattleController.ResetGridUnitsToNormal(lVar10,*(uint64 *)(lVar10 + 0x1d8),0);
            BattleController.ResetGridUnitsToNormal(lVar10,*(uint64 *)(lVar10 + 0x1f8),0);
            BattleController.ResetGridUnitsToNormal(lVar10,*(uint64 *)(lVar10 + 0x208),0);
            if (*(int64 *)(lVar10 + 0x1e0) != 0) {
              FUN_180f56130(*(int64 *)(lVar10 + 0x1e0),DAT_181d637f8);
              plVar5 = (int64 *)Resources.Load("Sound/SoundEffect/终场锣",0);
              plVar11 = (int64 *)0;
              if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181d8a228)) {
                plVar11 = plVar5;
              }
              NGUITools.PlaySound(plVar11);
              *(uint64 *)(lVar10 + 0x110) = 0;
              BattleController.SetPauseButtonInteractable(lVar10,0,0);
              uVar4 = new WaitForSecondsRealtime();
              this.<>2__current = uVar4;
              this.<>1__state = 1;
              return true;
            }
          }
        }
        else {
          if ((iVar12 != 1) && (iVar12 != 2)) {
            return false;
          }
          this.<>1__state = 0xffffffff;
          if ((lVar10 != null) && (*(int64 *)(lVar10 + 128) != 0)) {
            if (*(int *)(*(int64 *)(lVar10 + 128) + 24) < 1) {
              lVar3 = FUN_18046c440(0);
              if (lVar3 == null) goto LAB_180b1d96f;
              if (*(char *)(lVar3 + 24) == false) {
                if ((*pStatics_e090 != 0) &&
                   (lVar3 = *(int64 *)(*pStatics_e090 + 24)) != null) {
                  cVar2 = GameObject.get_activeSelf(lVar3,0);
                  if (cVar2) {
                    lVar3 = FUN_18046c160(0);
                    if (lVar3 == null) goto LAB_180b1d96f;
                    GameMenuController.UnshowGameMenu(lVar3,0);
                  }
                  if ((*pStatics_b0a8 != 0) &&
                     (lVar3 = *(int64 *)(*pStatics_b0a8 + 24)) != null) {
                    cVar2 = GameObject.get_activeSelf(lVar3,0);
                    if (cVar2) {
                      lVar3 = FUN_1807e8640(0);
                      if (lVar3 == null) goto LAB_180b1d96f;
                      BattleAiMenuController.UnShowBattleAiMenu(lVar3,0);
                    }
                    if ((*(int64 *)(lVar10 + 0x180) != 0) &&
                       (lVar3 = GameObject.GetComponent(*(int64 *)(lVar10 + 0x180),DAT_181da2130),
                       lVar3 != null)) {
                      Toggle.set_isOn(lVar3,0,0);
                      if (*(char *)(lVar10 + 0x1ac) == false) {
                        BattleController.BattleRealEnd(lVar10,0);
                        return false;
                      }
                      if ((*(int64 *)(lVar10 + 112) != 0) &&
                         (lVar3 = FUN_180002f80(*(int64 *)(lVar10 + 112),
                                                *(uint32 *)(lVar10 + 48),DAT_181d580a8), lVar3 != null)
                         ) {
                        uVar4 = "FightWin";
                        if (*(char *)(lVar3 + 20) == false) {
                          uVar4 = "FightLose";
                        }
                        uVar4 = String.Concat("Sound/SoundEffect/",uVar4,0);
                        plVar5 = (int64 *)Resources.Load(uVar4,0);
                        plVar11 = (int64 *)0;
                        if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181d8a228)) {
                          plVar11 = plVar5;
                        }
                        NGUITools.PlaySound(plVar11,0);
                        iVar12 = 0;
                        while (*(int64 *)(lVar10 + 112) != 0) {
                          if (*(int *)(*(int64 *)(lVar10 + 112) + 24) <= iVar12) {
                            lVar3 = FUN_18046c1a0(0);
                            if ((((lVar3 == null) || (*(int64 *)(lVar3 + 56) == 0)) ||
                                (lVar3 = GameObject.get_transform(*(int64 *)(lVar3 + 56),0),
                                lVar3 == null)) ||
                               ((lVar3 = Transform.Find(lVar3,"BattleEndUI",0), lVar3 == null ||
                                (lVar3 = Component.get_gameObject(lVar3,0)) == null))) break;
                            GameObject.SetActive(lVar3,1,0);
                            lVar3 = FUN_18046c1a0(0);
                            if ((((lVar3 == null) ||
                                 ((*(int64 *)(lVar3 + 56) == 0 ||
                                  (lVar3 = GameObject.get_transform(*(int64 *)(lVar3 + 56),0),
                                  lVar3 == null)))) ||
                                (lVar3 = Transform.Find(lVar3,"BattleEndUI",0)) == null) ||
                               (lVar3 = Component.GetComponent(lVar3,DAT_181d6b0c0)) == null) break;
                            CanvasGroup.set_alpha(lVar3);
                            lVar3 = FUN_18046c1a0(0);
                            if ((((lVar3 == null) || (*(int64 *)(lVar3 + 56) == 0)) ||
                                (lVar3 = GameObject.get_transform(*(int64 *)(lVar3 + 56),0),
                                lVar3 == null)) ||
                               (lVar3 = Transform.Find(lVar3,"BattleEndUI",0)) == null) break;
                            uVar4 = Component.GetComponent(lVar3,DAT_181d6b0c0);
                            DOTweenModuleUI.DOFade(uVar4);
                            lVar3 = FUN_18046c1a0(0);
                            if (((lVar3 == null) || (*(int64 *)(lVar3 + 56) == 0)) ||
                               ((lVar3 = GameObject.get_transform(*(int64 *)(lVar3 + 56),0),
                                lVar3 == null ||
                                ((lVar3 = Transform.Find(lVar3,"BattleEndUI",0), lVar3 == null ||
                                 (lVar3 = Transform.Find(lVar3,"Result",0)) == null))))) break;
                            lVar3 = Component.GetComponent(lVar3,DAT_181d6bc40);
                            if ((*(int64 *)(lVar10 + 112) == 0) ||
                               (lVar6 = FUN_180002f80(*(int64 *)(lVar10 + 112),
                                                      *(uint32 *)(lVar10 + 48),DAT_181d580a8),
                               lVar6 == null)) break;
                            if (*(char *)(lVar6 + 20) == false) {
                              uVar4 = *(uint64 *)(lVar10 + 0x278);
                            }
                            else {
                              uVar4 = *(uint64 *)(lVar10 + 0x270);
                            }
                            if (lVar3 == null) break;
                            Image.set_sprite(lVar3,uVar4,0);
                            lVar3 = FUN_18046c1a0(0);
                            if ((((lVar3 == null) || (*(int64 *)(lVar3 + 56) == 0)) ||
                                (lVar3 = GameObject.get_transform(*(int64 *)(lVar3 + 56),0),
                                lVar3 == null)) ||
                               (lVar3 = Transform.Find(lVar3,"BattleEndUI",0)) == null) break;
                            lVar3 = Transform.Find(lVar3,"Result",0);
                            puVar7 = (uint64 *)Vector3.get_one(&local_98,0);
                            local_b8 = *puVar7;
                            local_b0 = *(float *)(puVar7 + 1);
                            local_c0 = local_b0 * 10.0;
                            local_c8 = CONCAT44((float)((uint64)local_b8 >> 32) * 10.0,
                                                (float)local_b8 * 10.0);
                            if (lVar3 == null) break;
                            local_b8 = local_c8;
                            local_b0 = local_c0;
                            Transform.set_localScale(lVar3,&local_b8,0);
                            lVar3 = FUN_18046c1a0(0);
                            if (((lVar3 == null) || (*(int64 *)(lVar3 + 56) == 0)) ||
                               ((lVar3 = GameObject.get_transform(*(int64 *)(lVar3 + 56),0),
                                lVar3 == null || (lVar3 = Transform.Find(lVar3,"BattleEndUI",0)) == null
                                ))) break;
                            uVar4 = Transform.Find(lVar3,"Result",0);
                            uVar4 = ShortcutExtensions.DOScale(uVar4);
                            uVar4 = TweenSettingsExtensions.SetDelay(uVar4);
                            TweenSettingsExtensions.SetEase(uVar4,9,DAT_181d97ca8);
                            if ((*(int64 *)(lVar10 + 112) == 0) ||
                               (lVar3 = FUN_180002f80(*(int64 *)(lVar10 + 112),
                                                      *(uint32 *)(lVar10 + 48),DAT_181d580a8),
                               lVar3 == null)) break;
                            auVar20._0_8_ = BattleController.CountPlayerBattleScore(lVar10);
                            auVar20._8_8_ = extraout_XMM0_Qb;
                            auVar21._4_12_ = auVar20._4_12_;
                            auVar21._0_4_ = (float)auVar20._0_8_ / 20.0;
                            uVar15 = Mathf.RoundToInt(auVar21._0_8_,0);
                            lVar3 = FUN_18046c1a0(0);
                            if ((lVar3 == null) ||
                               ((((*(int64 *)(lVar3 + 56) == 0 ||
                                  (lVar3 = GameObject.get_transform(*(int64 *)(lVar3 + 56),0),
                                  lVar3 == null)) ||
                                 (lVar3 = Transform.Find(lVar3,"BattleEndUI",0)) == null) ||
                                (lVar3 = Transform.Find(lVar3,"Rate",0)) == null))) break;
                            uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                            lVar3 = *(int64 *)(pStatics_ef00 + 0x5b8);
                            if (lVar3 == null) break;
                            uVar8 = FUN_180002f80(lVar3,uVar15,DAT_181d7c9c0);
                            LTLocalization.SetText(uVar4,uVar8,0);
                            lVar3 = FUN_18046c1a0(0);
                            if (((lVar3 == null) || (*(int64 *)(lVar3 + 56) == 0)) ||
                               ((lVar3 = GameObject.get_transform(*(int64 *)(lVar3 + 56),0),
                                lVar3 == null ||
                                ((lVar3 = Transform.Find(lVar3,"BattleEndUI",0), lVar3 == null ||
                                 (lVar3 = Transform.Find(lVar3,"Rate",0)) == null))))) break;
                            plVar5 = (int64 *)Component.GetComponent(lVar3,DAT_181d6d8c0);
                            lVar3 = FUN_18046c100(0);
                            if ((((lVar3 == null) || (*(int64 *)(lVar3 + 56) == 0)) ||
                                (lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 56),uVar15,DAT_181d76758),
                                lVar3 == null)) || (plVar5 == (int64 *)0)) break;
                            local_98 = *(uint64 *)(lVar3 + 24);
                            uStack_90 = *(uint64 *)(lVar3 + 32);
                            (**(code **)(*plVar5 + 0x2a8))
                                      (plVar5,&local_98,*(uint64 *)(*plVar5 + 0x2b0));
                            uVar4 = *(uint64 *)(lVar10 + 0x1b0);
                            cVar2 = Object.op_Inequality(uVar4,0,0);
                            if (!cVar2) {
                              lVar3 = FUN_18046c1a0(0);
                              if (((lVar3 == null) || (*(int64 *)(lVar3 + 56) == 0)) ||
                                 ((lVar3 = GameObject.get_transform(*(int64 *)(lVar3 + 56),0),
                                  lVar3 == null ||
                                  ((lVar3 = Transform.Find(lVar3,"BattleEndUI",0), lVar3 == null ||
                                   (lVar3 = Transform.Find(lVar3,"Info",0)) == null)))))
                              break;
                              uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                              LTLocalization.SetText(uVar4,"",0);
                            }
                            else {
                              lVar3 = FUN_18046c1a0(0);
                              if (((lVar3 == null) || (*(int64 *)(lVar3 + 56) == 0)) ||
                                 ((lVar3 = GameObject.get_transform(*(int64 *)(lVar3 + 56),0),
                                  lVar3 == null ||
                                  ((lVar3 = Transform.Find(lVar3,"BattleEndUI",0), lVar3 == null ||
                                   (lVar3 = Transform.Find(lVar3,"Info",0)) == null))))) {
        LAB_180b1d9fb:
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
                              plVar5 = (int64 *)FUN_1800d60b0(DAT_181d7f180,4);
                              local_res18[0] = (int)*(float *)(lVar10 + 0x1c8);
                              lVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
                              if (plVar5 == (int64 *)0) goto LAB_180b1d9fb;
                              if ((lVar3 != null) &&
                                 (lVar6 = il2cpp_internal(lVar3,*(uint64 *)(*plVar5 + 64)),
                                 lVar6 == null)) {
                                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar4,0);
                              }
                              if ((int)plVar5[3] == 0) {
                                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar4,0);
                              }
                              plVar5[4] = lVar3;
                              il2cpp_internal(plVar5 + 4,lVar3);
                              if ((*(int64 *)(lVar10 + 0x1b0) == 0) ||
                                 (lVar3 = *(int64 *)(*(int64 *)(lVar10 + 0x1b0) + 168)) == null
                                 ) goto LAB_180b1d9fb;
                              local_res20[0] = *(uint32 *)(lVar3 + 16);
                              lVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res20);
                              if ((lVar3 != null) &&
                                 (lVar6 = il2cpp_internal(lVar3,*(uint64 *)(*plVar5 + 64)),
                                 lVar6 == null)) {
                                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar4,0);
                              }
                              if (*(uint32 *)(plVar5 + 3) < 2) {
                                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar4,0);
                              }
                              plVar5[5] = lVar3;
                              il2cpp_internal(plVar5 + 5,lVar3);
                              if ((*(int64 *)(lVar10 + 0x1b0) == 0) ||
                                 (lVar3 = *(int64 *)(*(int64 *)(lVar10 + 0x1b0) + 168)) == null
                                 ) goto LAB_180b1d9fb;
                              local_d8 = Mathf.RoundToInt(lVar3,0);
                              lVar3 = il2cpp_value_box(DAT_181d5b2f8,&local_d8);
                              if ((lVar3 != null) &&
                                 (lVar6 = il2cpp_internal(lVar3,*(uint64 *)(*plVar5 + 64)),
                                 lVar6 == null)) {
                                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar4,0);
                              }
                              if (*(uint32 *)(plVar5 + 3) < 3) {
                                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar4,0);
                              }
                              plVar5[6] = lVar3;
                              il2cpp_internal(plVar5 + 6,lVar3);
                              if ((*(int64 *)(lVar10 + 0x1b0) == 0) ||
                                 (lVar3 = *(int64 *)(*(int64 *)(lVar10 + 0x1b0) + 168)) == null
                                 ) goto LAB_180b1d9fb;
                              local_d4[0] = Mathf.RoundToInt(lVar3,0);
                              lVar3 = il2cpp_value_box(DAT_181d5b2f8,local_d4);
                              if ((lVar3 != null) &&
                                 (lVar6 = il2cpp_internal(lVar3,*(uint64 *)(*plVar5 + 64)),
                                 lVar6 == null)) {
                                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar4,0);
                              }
                              if (*(uint32 *)(plVar5 + 3) < 4) {
                                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar4,0);
                              }
                              plVar5[7] = lVar3;
                              il2cpp_internal(plVar5 + 7,lVar3);
                              uVar8 = String.Format("战斗时长 {0}    击败敌人 {1}    造成伤害 {2}    承受伤害 {3}",plVar5,0);
                              LTLocalization.SetText(uVar4,uVar8,0);
                              lVar3 = FUN_18046c0a0(0);
                              if ((((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                                  (*(int64 *)(lVar10 + 0x1b0) == 0)) ||
                                 (lVar6 = *(int64 *)(*(int64 *)(lVar10 + 0x1b0) + 168)) == null
                                 ) goto LAB_180b1d9fb;
                              piVar1 = (int *)(*(int64 *)(lVar3 + 32) + 0x194);
                              *piVar1 = *piVar1 + *(int *)(lVar6 + 16);
                              lVar3 = FUN_18046c100(0);
                              if (((*(int64 *)(lVar10 + 0x1b0) == 0) ||
                                  (*(int64 *)(*(int64 *)(lVar10 + 0x1b0) + 168) == 0)) ||
                                 (lVar3 == null)) goto LAB_180b1d9fb;
                              GameDataController.ChangeAchStats(lVar3,0);
                              if ((*(int64 *)(lVar10 + 0x1b0) == 0) ||
                                 (lVar3 = *(int64 *)(*(int64 *)(lVar10 + 0x1b0) + 168)) == null
                                 ) goto LAB_180b1d9fb;
                              if (9 < *(int *)(lVar3 + 16)) {
                                lVar3 = FUN_18046c100(0);
                                if (lVar3 == null) break;
                                GameDataController.ChangeAchStats(lVar3,23);
                              }
                              lVar3 = FUN_18046c0a0(0);
                              if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                                 (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) == null)
                              break;
                              HeroData.AddTag(lVar3,0x163);
                            }
                            if ((*(int64 *)(lVar10 + 112) == 0) ||
                               (lVar3 = FUN_180002f80(*(int64 *)(lVar10 + 112),
                                                      *(uint32 *)(lVar10 + 48),DAT_181d580a8),
                               lVar3 == null)) break;
                            if (*(char *)(lVar3 + 20) != false) {
                              lVar3 = FUN_18046c0a0(0);
                              if ((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) break;
                              piVar1 = (int *)(*(int64 *)(lVar3 + 32) + 400);
                              *piVar1 = *piVar1 + 1;
                              lVar3 = FUN_18046c100(0);
                              if (lVar3 == null) break;
                              GameDataController.ChangeAchStats(lVar3,1);
                            }
                            if ((*(int64 *)(lVar10 + 112) != 0) &&
                               (lVar3 = FUN_180002f80(*(int64 *)(lVar10 + 112),
                                                      *(uint32 *)(lVar10 + 48),DAT_181d580a8),
                               lVar3 != null)) {
                              if (*(char *)(lVar3 + 20) != false) {
                                iVar12 = 0;
                                goto LAB_180b1bcd0;
                              }
                              lVar3 = FUN_18046c0a0(0);
                              if (((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
                                 (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) != null) {
                                fVar16 = (float)Mathf.Min(*(float *)(lVar3 + 0x1c4) * -0.01);
                                local_res8[0] = fVar16;
                                fVar17 = (float)Mathf.Max();
                                lVar3 = *(int64 *)(pStatics_ef00 + 0x6a0);
                                if (lVar3 != null) {
                                  fVar18 = (float)FUN_1800d6780(lVar3,*(uint32 *)(lVar10 + 32),
                                                                DAT_181d796d8);
                                  goto LAB_180b1be83;
                                }
                              }
                            }
                            break;
                          }
                          iVar13 = 0;
                          while( true ) {
                            if (((*(int64 *)(lVar10 + 112) == 0) ||
                                (lVar3 = FUN_180002f80()) == null) ||
                               (*(int64 *)(lVar3 + 24) == 0)) goto LAB_180b1d96f;
                            if (*(int *)(*(int64 *)(lVar3 + 24) + 24) <= iVar13) break;
                            if ((((*(int64 *)(lVar10 + 112) == 0) ||
                                 (lVar3 = FUN_180002f80(*(int64 *)(lVar10 + 112),iVar12,DAT_181d580a8)
                                 , lVar3 == null)) || (*(int64 *)(lVar3 + 24) == 0)) ||
                               (lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 24),iVar13,DAT_181d584a0),
                               lVar3 == null)) goto LAB_180b1d96f;
                            lVar3 = *(int64 *)(lVar3 + 64);
                            if (((*(int64 *)(lVar10 + 112) == 0) ||
                                (lVar6 = FUN_180002f80(*(int64 *)(lVar10 + 112),iVar12,DAT_181d580a8),
                                lVar6 == null)) || (*(int64 *)(lVar6 + 24) == 0)) goto LAB_180b1d96f;
                            uVar4 = FUN_180002f80(*(int64 *)(lVar6 + 24),iVar13,DAT_181d584a0);
                            uVar15 = BattleController.CountHeroBattleContribution
                                               (lVar10,uVar4,iVar12 == *(int *)(lVar10 + 48));
                            if (lVar3 == null) goto LAB_180b1d96f;
                            *(uint32 *)(lVar3 + 176) = uVar15;
                            if (((*(int64 *)(lVar10 + 112) == 0) ||
                                (lVar3 = FUN_180002f80(*(int64 *)(lVar10 + 112),iVar12,DAT_181d580a8),
                                lVar3 == null)) ||
                               ((*(char *)(lVar3 + 20) == false &&
                                ((((*(int64 *)(lVar10 + 112) == 0 ||
                                   (lVar3 = FUN_180002f80(*(int64 *)(lVar10 + 112),iVar12,
                                                          DAT_181d580a8), lVar3 == null)) ||
                                  (*(int64 *)(lVar3 + 24) == 0)) ||
                                 ((lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 24),iVar13,DAT_181d584a0)
                                  , lVar3 == null || (*(int64 *)(lVar3 + 64) == 0))))))))
                            goto LAB_180b1d96f;
                            iVar13 = iVar13 + 1;
                          }
                          iVar12 = iVar12 + 1;
                        }
                      }
                    }
                  }
                }
                goto LAB_180b1d96f;
              }
            }
            lVar3 = FUN_18046c440(0);
            if (lVar3 != null) {
              if (*(char *)(lVar3 + 24) != false) {
        LAB_180b1d7b9:
                uVar4 = new WaitForSecondsRealtime();
                this.<>2__current = uVar4;
                this.<>1__state = 2;
                return true;
              }
              lVar6 = FUN_18046c440(0);
              lVar3 = *(int64 *)(lVar10 + 128);
              if (lVar3 != null) {
                if (*(int *)(lVar3 + 24) == 0) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar3 = *(int64 *)(*(int64 *)(lVar3 + 16) + 32);
                if ((lVar3 != null) && (lVar6 != null)) {
                  PlotController.ChangePlotDataBase(lVar6,*(uint32 *)(lVar3 + 32),0);
                  if (*(int64 *)(lVar10 + 128) != 0) {
                    FUN_18182b220(*(int64 *)(lVar10 + 128),0,DAT_181d57c30);
                    goto LAB_180b1d7b9;
                  }
                }
              }
            }
          }
        }
        LAB_180b1d96f:
                          // WARNING: Subroutine does not return
        FUN_1800d6620();
        LAB_180b1bcd0:
        fVar16 = local_res8[0];
        if (*(int64 *)(lVar10 + 112) == 0) goto LAB_180b1d96f;
        if (*(int *)(*(int64 *)(lVar10 + 112) + 24) <= iVar12) {
          lVar3 = *(int64 *)(pStatics_ef00 + 0x6a0);
          if (lVar3 != null) {
            fVar18 = (float)FUN_1800d6780(lVar3,*(uint32 *)(lVar10 + 32),DAT_181d796d8);
            fVar17 = (float)auVar20._0_8_ * 0.01;
        LAB_180b1be83:
            local_res8[0] = fVar18 * fVar17 * fVar16;
            lVar3 = FUN_18046c0a0(0);
            if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
               (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) == null) goto LAB_180b1d96f;
            HeroData.ChangeFame(lVar3);
            lVar3 = FUN_18046c1a0(0);
            if (((lVar3 == null) || (*(int64 *)(lVar3 + 56) == 0)) ||
               ((lVar3 = GameObject.get_transform(*(int64 *)(lVar3 + 56),0), lVar3 == null ||
                ((lVar3 = Transform.Find(lVar3,"BattleEndUI",0), lVar3 == null ||
                 (lVar3 = Transform.Find(lVar3,"Fame",0)) == null))))) goto LAB_180b1d96f;
            uVar4 = Component.GetComponent(lVar3,DAT_181d6d8c0);
            if (local_res8[0] < 0.0) {
              uVar8 = *(uint64 *)(pStatics_ef00 + 0x2c8);
            }
            else if (local_res8[0] == 0.0) {
              uVar8 = *(uint64 *)(pStatics_ef00 + 0x338);
            }
            else {
              uVar8 = *(uint64 *)(pStatics_ef00 + 0x260);
            }
            uVar9 = "+0.#;-0.#;0";
            if (1.0 <= ABS(local_res8[0])) {
              uVar9 = "+0;-0;0";
            }
            uVar9 = Single.ToString(local_res8,uVar9,0);
            uVar8 = String.Concat(uVar8,uVar9,"</color>",0);
            LTLocalization.SetText(uVar4,uVar8,0);
            lVar3 = FUN_18046c1a0(0);
            if ((((lVar3 == null) || (*(int64 *)(lVar3 + 56) == 0)) ||
                (lVar3 = GameObject.get_transform(*(int64 *)(lVar3 + 56),0)) == null) ||
               ((lVar3 = Transform.Find(lVar3,"BattleEndUI",0), lVar3 == null ||
                (lVar3 = Transform.Find(lVar3,"BaseSkillGrid",0)) == null))) goto LAB_180b1d96f;
            uVar4 = Component.get_gameObject(lVar3,0);
            GlobalData.DeleteAllChild(uVar4,0);
            lVar3 = FUN_18046c1a0(0);
            if (((lVar3 == null) || (*(int64 *)(lVar3 + 56) == 0)) ||
               ((lVar3 = GameObject.get_transform(*(int64 *)(lVar3 + 56),0), lVar3 == null ||
                ((lVar3 = Transform.Find(lVar3,"BattleEndUI",0), lVar3 == null ||
                 (lVar3 = Transform.Find(lVar3,"SkillGrid",0)) == null))))) goto LAB_180b1d96f;
            uVar4 = Component.get_gameObject(lVar3,0);
            GlobalData.DeleteAllChild(uVar4,0);
            lVar3 = FUN_18046c1a0(0);
            if ((lVar3 == null) ||
               ((((*(int64 *)(lVar3 + 56) == 0 ||
                  (lVar3 = GameObject.get_transform(*(int64 *)(lVar3 + 56),0)) == null) ||
                 (lVar3 = Transform.Find(lVar3,"BattleEndUI",0)) == null) ||
                ((lVar3 = Transform.Find(lVar3,"SkillCountInfo",0), lVar3 == null ||
                 (lVar3 = Component.GetComponent(lVar3,DAT_181d6ccc0)) == null)))))
            goto LAB_180b1d96f;
            puVar7 = (uint64 *)(lVar3 + 24);
            *puVar7 = "";
            il2cpp_internal(puVar7);
            lVar3 = FUN_18046c0a0(0);
            if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
               (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) == null) goto LAB_180b1d96f;
            if (*(int64 *)(lVar3 + 0x270) != 0) {
              lVar3 = FUN_18046c1a0(0);
              if ((((lVar3 == null) || (*(int64 *)(lVar3 + 56) == 0)) ||
                  (lVar3 = GameObject.get_transform(*(int64 *)(lVar3 + 56),0)) == null) ||
                 ((lVar3 = Transform.Find(lVar3,"BattleEndUI",0), lVar3 == null ||
                  (lVar3 = Transform.Find(lVar3,"BaseSkillGrid",0)) == null))) goto LAB_180b1d96f;
              uVar4 = Component.get_gameObject(lVar3,0);
              lVar3 = FUN_18046c1a0(0);
              if (lVar3 == null) goto LAB_180b1d96f;
              uVar8 = *(uint64 *)(lVar3 + 184);
              uVar4 = GlobalData.AddChild(uVar4,uVar8,0);
              *(uint64 *)(lVar10 + 0x280) = uVar4;
              if (*(int64 *)(lVar10 + 0x280) == 0) goto LAB_180b1d96f;
              lVar3 = GameObject.GetComponent(*(int64 *)(lVar10 + 0x280),DAT_181da1530);
              lVar6 = FUN_18046c0a0(0);
              if ((((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                  (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) == null) || (lVar3 == null))
              goto LAB_180b1d96f;
              *(uint64 *)(lVar3 + 24) = *(uint64 *)(lVar6 + 0x270);
              lVar3 = FUN_18046c0a0(0);
              if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                 ((lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0), lVar3 == null ||
                  (*(int64 *)(lVar3 + 0x270) == 0)))) goto LAB_180b1d96f;
              if (0 < *(int *)(*(int64 *)(lVar3 + 0x270) + 92)) {
                uVar4 = *puVar7;
                cVar2 = FUN_180d6ca90(uVar4,0);
                uVar8 = "\n";
                if (cVar2) {
                  uVar8 = "";
                }
                lVar3 = FUN_18046c0a0(0);
                if ((((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                    (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) == null) ||
                   (*(int64 *)(lVar3 + 0x270) == 0)) goto LAB_180b1d96f;
                uVar9 = KungfuSkillLvData.GetSkillBattleCountDescribe(*(int64 *)(lVar3 + 0x270),0);
                uVar4 = String.Concat(uVar4,uVar8,uVar9,0);
                *puVar7 = uVar4;
                il2cpp_internal(puVar7,uVar4);
              }
            }
            lVar3 = FUN_18046c0a0(0);
            if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
               (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) == null) goto LAB_180b1d96f;
            if (*(int64 *)(lVar3 + 0x280) != 0) {
              lVar3 = FUN_18046c1a0(0);
              if ((((lVar3 == null) || (*(int64 *)(lVar3 + 56) == 0)) ||
                  (lVar3 = GameObject.get_transform(*(int64 *)(lVar3 + 56),0)) == null) ||
                 ((lVar3 = Transform.Find(lVar3,"BattleEndUI",0), lVar3 == null ||
                  (lVar3 = Transform.Find(lVar3,"BaseSkillGrid",0)) == null))) goto LAB_180b1d96f;
              uVar4 = Component.get_gameObject(lVar3,0);
              lVar3 = FUN_18046c1a0(0);
              if (lVar3 == null) goto LAB_180b1d96f;
              uVar8 = *(uint64 *)(lVar3 + 184);
              uVar4 = GlobalData.AddChild(uVar4,uVar8,0);
              *(uint64 *)(lVar10 + 0x280) = uVar4;
              if (*(int64 *)(lVar10 + 0x280) == 0) goto LAB_180b1d96f;
              lVar3 = GameObject.GetComponent(*(int64 *)(lVar10 + 0x280),DAT_181da1530);
              lVar6 = FUN_18046c0a0(0);
              if ((((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                  (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) == null) || (lVar3 == null))
              goto LAB_180b1d96f;
              *(uint64 *)(lVar3 + 24) = *(uint64 *)(lVar6 + 0x280);
              lVar3 = FUN_18046c0a0(0);
              if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                 ((lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0), lVar3 == null ||
                  (*(int64 *)(lVar3 + 0x280) == 0)))) goto LAB_180b1d96f;
              if (0 < *(int *)(*(int64 *)(lVar3 + 0x280) + 92)) {
                uVar4 = *puVar7;
                cVar2 = FUN_180d6ca90(uVar4,0);
                uVar8 = "\n";
                if (cVar2) {
                  uVar8 = "";
                }
                lVar3 = FUN_18046c0a0(0);
                if ((((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                    (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) == null) ||
                   (*(int64 *)(lVar3 + 0x280) == 0)) goto LAB_180b1d96f;
                uVar9 = KungfuSkillLvData.GetSkillBattleCountDescribe(*(int64 *)(lVar3 + 0x280),0);
                uVar4 = String.Concat(uVar4,uVar8,uVar9,0);
                *puVar7 = uVar4;
                il2cpp_internal(puVar7,uVar4);
              }
            }
            lVar3 = FUN_18046c0a0(0);
            if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
               (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) == null) goto LAB_180b1d96f;
            if (*(int64 *)(lVar3 + 0x290) != 0) {
              lVar3 = FUN_18046c1a0(0);
              if ((((lVar3 == null) || (*(int64 *)(lVar3 + 56) == 0)) ||
                  (lVar3 = GameObject.get_transform(*(int64 *)(lVar3 + 56),0)) == null) ||
                 ((lVar3 = Transform.Find(lVar3,"BattleEndUI",0), lVar3 == null ||
                  (lVar3 = Transform.Find(lVar3,"BaseSkillGrid",0)) == null))) goto LAB_180b1d96f;
              uVar4 = Component.get_gameObject(lVar3,0);
              lVar3 = FUN_18046c1a0(0);
              if (lVar3 == null) goto LAB_180b1d96f;
              uVar8 = *(uint64 *)(lVar3 + 184);
              uVar4 = GlobalData.AddChild(uVar4,uVar8,0);
              *(uint64 *)(lVar10 + 0x280) = uVar4;
              if (*(int64 *)(lVar10 + 0x280) == 0) goto LAB_180b1d96f;
              lVar3 = GameObject.GetComponent(*(int64 *)(lVar10 + 0x280),DAT_181da1530);
              lVar6 = FUN_18046c0a0(0);
              if ((((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                  (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) == null) || (lVar3 == null))
              goto LAB_180b1d96f;
              *(uint64 *)(lVar3 + 24) = *(uint64 *)(lVar6 + 0x290);
              lVar3 = FUN_18046c0a0(0);
              if (((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                 ((lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0), lVar3 == null ||
                  (*(int64 *)(lVar3 + 0x290) == 0)))) goto LAB_180b1d96f;
              if (0 < *(int *)(*(int64 *)(lVar3 + 0x290) + 92)) {
                uVar4 = *puVar7;
                cVar2 = FUN_180d6ca90(uVar4,0);
                uVar8 = "\n";
                if (cVar2) {
                  uVar8 = "";
                }
                lVar3 = FUN_18046c0a0(0);
                if ((((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                    (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) == null) ||
                   (*(int64 *)(lVar3 + 0x290) == 0)) goto LAB_180b1d96f;
                uVar9 = KungfuSkillLvData.GetSkillBattleCountDescribe(*(int64 *)(lVar3 + 0x290),0);
                uVar4 = String.Concat(uVar4,uVar8,uVar9,0);
                *puVar7 = uVar4;
                il2cpp_internal(puVar7,uVar4);
              }
            }
            iVar12 = 0;
            while( true ) {
              if ((((*pStatics_df90 == 0) ||
                   (lVar3 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
                  (lVar3 = WorldData.Player(lVar3,0)) == null) || (*(int64 *)(lVar3 + 0x2a0) == 0)
                 ) goto LAB_180b1d9f5;
              if (*(int *)(*(int64 *)(lVar3 + 0x2a0) + 24) <= iVar12) break;
              lVar3 = FUN_18046c0a0(0);
              if ((((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                  (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) == null) ||
                 (*(int64 *)(lVar3 + 0x2a0) == 0)) goto LAB_180b1d96f;
              lVar3 = FUN_180002f80();
              if (lVar3 != null) {
                lVar3 = FUN_18046c1a0(0);
                if (((lVar3 == null) || (*(int64 *)(lVar3 + 56) == 0)) ||
                   ((lVar3 = GameObject.get_transform(*(int64 *)(lVar3 + 56),0), lVar3 == null ||
                    ((lVar3 = Transform.Find(lVar3,"BattleEndUI",0), lVar3 == null ||
                     (lVar3 = Transform.Find(lVar3,"SkillGrid",0)) == null))))) goto LAB_180b1d96f;
                uVar4 = Component.get_gameObject(lVar3,0);
                lVar3 = FUN_18046c1a0(0);
                if (lVar3 == null) goto LAB_180b1d96f;
                uVar8 = *(uint64 *)(lVar3 + 184);
                uVar4 = GlobalData.AddChild(uVar4,uVar8,0);
                *(uint64 *)(lVar10 + 0x280) = uVar4;
                if (*(int64 *)(lVar10 + 0x280) == 0) goto LAB_180b1d96f;
                lVar3 = GameObject.GetComponent(*(int64 *)(lVar10 + 0x280),DAT_181da1530);
                lVar6 = FUN_18046c0a0(0);
                if ((((lVar6 == null) || (*(int64 *)(lVar6 + 32) == 0)) ||
                    (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) == null) ||
                   ((*(int64 *)(lVar6 + 0x2a0) == 0 ||
                    (uVar4 = FUN_180002f80(*(int64 *)(lVar6 + 0x2a0),iVar12,DAT_181d6ade8), lVar3 == null)
                    ))) goto LAB_180b1d9f5;
                *(uint64 *)(lVar3 + 24) = uVar4;
                lVar3 = FUN_18046c0a0(0);
                if ((((lVar3 == null) ||
                     ((*(int64 *)(lVar3 + 32) == 0 ||
                      (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) == null))) ||
                    (*(int64 *)(lVar3 + 0x2a0) == 0)) || (lVar3 = FUN_180002f80()) == null)
                goto LAB_180b1d9f5;
                if (0 < *(int *)(lVar3 + 92)) {
                  uVar4 = *puVar7;
                  cVar2 = FUN_180d6ca90(uVar4,0);
                  uVar8 = "\n";
                  if (cVar2) {
                    uVar8 = "";
                  }
                  lVar3 = FUN_18046c0a0(0);
                  if ((((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) ||
                      (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) == null) ||
                     ((*(int64 *)(lVar3 + 0x2a0) == 0 ||
                      (lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 0x2a0),iVar12,DAT_181d6ade8),
                      lVar3 == null)))) goto LAB_180b1d9f5;
                  KungfuSkillLvData.GetSkillBattleCountDescribe(lVar3,0);
                  uVar4 = String.Concat(uVar4,uVar8);
                  *puVar7 = uVar4;
                  il2cpp_internal(puVar7);
                }
              }
              iVar12 = iVar12 + 1;
            }
            lVar3 = FUN_18046c1a0(0);
            if ((((lVar3 == null) || (*(int64 *)(lVar3 + 56) == 0)) ||
                ((lVar3 = GameObject.get_transform(*(int64 *)(lVar3 + 56),0), lVar3 == null ||
                 ((lVar3 = Transform.Find(lVar3,"BattleEndUI",0), lVar3 == null ||
                  (lVar3 = Transform.Find(lVar3,"BaseSkillGrid",0)) == null))))) ||
               (lVar3 = Component.GetComponent(lVar3,DAT_181d6e0c0)) == null) goto LAB_180b1d9f5;
            UIGrid.set_repositionNow(lVar3,1,0);
            lVar3 = FUN_18046c1a0(0);
            if (((((lVar3 == null) || (*(int64 *)(lVar3 + 56) == 0)) ||
                 (lVar3 = GameObject.get_transform(*(int64 *)(lVar3 + 56),0)) == null) ||
                ((lVar3 = Transform.Find(lVar3,"BattleEndUI",0), lVar3 == null ||
                 (lVar3 = Transform.Find(lVar3,"SkillGrid",0)) == null))) ||
               (lVar3 = Component.GetComponent(lVar3,DAT_181d6e0c0)) == null) goto LAB_180b1d9f5;
            UIGrid.set_repositionNow(lVar3,1,0);
            if ((*(int64 *)(lVar10 + 112) == 0) ||
               (lVar3 = FUN_180002f80(*(int64 *)(lVar10 + 112),*(uint32 *)(lVar10 + 48),
                                      DAT_181d580a8), lVar3 == null)) goto LAB_180b1d9f5;
            if (*(char *)(lVar3 + 20) == false) {
        LAB_180b1cead:
              BattleController.ResetTrophyItemList(lVar10,0);
              lVar10 = FUN_18046c1a0(0);
              if (((lVar10 != null) && (*(int64 *)(lVar10 + 56) != 0)) &&
                 ((lVar10 = GameObject.get_transform(*(int64 *)(lVar10 + 56),0), lVar10 != null &&
                  (((lVar10 = Transform.Find(lVar10,"BattleEndUI",0), lVar10 != null &&
                    (lVar10 = Transform.Find(lVar10,"Money",0)) != null) &&
                   (lVar10 = Transform.Find(lVar10,"Icon",0)) != null))))) {
                plVar5 = (int64 *)Component.GetComponent(lVar10,DAT_181d6bc40);
                puVar7 = (uint64 *)FUN_180d904c0(&local_98,0);
                if (plVar5 != (int64 *)0) {
                  local_98 = *puVar7;
                  uStack_90 = puVar7[1];
                  (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_98,*(uint64 *)(*plVar5 + 0x2b0));
                  lVar10 = FUN_18046c1a0(0);
                  if (((lVar10 != null) && (*(int64 *)(lVar10 + 56) != 0)) &&
                     ((lVar10 = GameObject.get_transform(*(int64 *)(lVar10 + 56),0), lVar10 != null &&
                      ((lVar10 = Transform.Find(lVar10,"BattleEndUI",0), lVar10 != null &&
                       (lVar10 = Transform.Find(lVar10,"Money",0)) != null))))) {
                    uVar4 = Component.GetComponent(lVar10,DAT_181d6d8c0);
                    LTLocalization.SetText(uVar4,"",0);
                    lVar10 = FUN_18046c1a0(0);
                    if ((lVar10 != null) &&
                       ((((*(int64 *)(lVar10 + 56) != 0 &&
                          (lVar10 = GameObject.get_transform(*(int64 *)(lVar10 + 56),0), lVar10 != null
                          )) && (lVar10 = Transform.Find(lVar10,"BattleEndUI",0)) != null) &&
                        ((lVar10 = Transform.Find(lVar10,"ItemListScrollView",0), lVar10 != null &&
                         (lVar10 = Component.GetComponent(lVar10,DAT_181d6be40)) != null))))) {
                      ItemListController.ClearAllItem(lVar10,0);
                      return false;
                    }
                  }
                }
              }
            }
            else {
              plVar5 = (int64 *)(lVar10 + 0x1c0);
              lVar3 = *plVar5;
              if ((lVar3 == null) || (*(int64 *)(lVar3 + 40) == 0)) goto LAB_180b1d9f5;
              if ((*(int *)(*(int64 *)(lVar3 + 40) + 24) < 1) && (*(int *)(lVar3 + 24) < 1)) {
                if (*(char *)(lVar10 + 0x1b8) == false) goto LAB_180b1cead;
                uVar14 = 0;
                fVar16 = 0.0;
                fVar17 = 0.0;
                lVar3 = 32;
                while( true ) {
                  lVar6 = *(int64 *)(lVar10 + 112);
                  if (lVar6 == null) goto LAB_180b1d9f5;
                  if ((int)*(uint32 *)(lVar6 + 24) <= (int)uVar14) break;
                  if (*(uint32 *)(lVar6 + 24) <= uVar14) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar6 = *(int64 *)(lVar3 + *(int64 *)(lVar6 + 16));
                  if (lVar6 == null) goto LAB_180b1d9f5;
                  if (*(char *)(lVar6 + 20) == false) {
                    iVar12 = 0;
                    while( true ) {
                      if (((*(int64 *)(lVar10 + 112) == 0) || (lVar6 = FUN_180002f80()) == null)
                         || (*(int64 *)(lVar6 + 24) == 0)) goto LAB_180b1d9f5;
                      if (*(int *)(*(int64 *)(lVar6 + 24) + 24) <= iVar12) break;
                      if ((((*(int64 *)(lVar10 + 112) == 0) ||
                           (lVar6 = FUN_180002f80(*(int64 *)(lVar10 + 112),uVar14,DAT_181d580a8),
                           lVar6 == null)) || (*(int64 *)(lVar6 + 24) == 0)) ||
                         ((lVar6 = FUN_180002f80(*(int64 *)(lVar6 + 24),iVar12,DAT_181d584a0),
                          lVar6 == null || (*(int64 *)(lVar6 + 64) == 0)))) goto LAB_180b1d9f5;
                      if (*(char *)(*(int64 *)(lVar6 + 64) + 16) == false) {
                        if (((*(int64 *)(lVar10 + 112) == 0) ||
                            (lVar6 = FUN_180002f80(*(int64 *)(lVar10 + 112),uVar14,DAT_181d580a8),
                            lVar6 == null)) ||
                           ((*(int64 *)(lVar6 + 24) == 0 ||
                            ((lVar6 = FUN_180002f80(*(int64 *)(lVar6 + 24),iVar12,DAT_181d584a0),
                             lVar6 == null || (*(int64 *)(lVar6 + 64) == 0)))))) goto LAB_180b1d9f5;
                        if (fVar17 < (float)*(int *)(*(int64 *)(lVar6 + 64) + 184)) {
                          if ((((*(int64 *)(lVar10 + 112) == 0) ||
                               (lVar6 = FUN_180002f80(*(int64 *)(lVar10 + 112),uVar14,DAT_181d580a8),
                               lVar6 == null)) || (*(int64 *)(lVar6 + 24) == 0)) ||
                             ((lVar6 = FUN_180002f80(*(int64 *)(lVar6 + 24),iVar12,DAT_181d584a0),
                              lVar6 == null || (*(int64 *)(lVar6 + 64) == 0)))) goto LAB_180b1d9f5;
                          fVar17 = (float)*(int *)(*(int64 *)(lVar6 + 64) + 184);
                        }
                        if (((*(int64 *)(lVar10 + 112) == 0) ||
                            (lVar6 = FUN_180002f80(*(int64 *)(lVar10 + 112),uVar14,DAT_181d580a8),
                            lVar6 == null)) ||
                           ((*(int64 *)(lVar6 + 24) == 0 ||
                            ((lVar6 = FUN_180002f80(*(int64 *)(lVar6 + 24),iVar12,DAT_181d584a0),
                             lVar6 == null || (*(int64 *)(lVar6 + 64) == 0)))))) goto LAB_180b1d9f5;
                        fVar18 = (float)FUN_1801f7f00();
                        fVar16 = fVar16 + fVar18;
                      }
                      iVar12 = iVar12 + 1;
                    }
                  }
                  uVar14 = uVar14 + 1;
                  lVar3 = lVar3 + 8;
                }
                lVar10 = *plVar5;
                auVar22._0_8_ = Random.Range();
                auVar22._8_8_ = extraout_XMM0_Qb_00;
                auVar23._4_12_ = auVar22._4_12_;
                auVar23._0_4_ = (float)auVar22._0_8_ * fVar16;
                uVar15 = Mathf.RoundToInt(auVar23._0_8_,0);
                if (lVar10 == null) goto LAB_180b1d9f5;
                *(uint32 *)(lVar10 + 24) = uVar15;
                lVar10 = FUN_18046c1a0(0);
                if (((lVar10 == null) || (*(int64 *)(lVar10 + 56) == 0)) ||
                   ((lVar10 = GameObject.get_transform(*(int64 *)(lVar10 + 56),0), lVar10 == null ||
                    (((lVar10 = Transform.Find(lVar10,"BattleEndUI",0), lVar10 == null ||
                      (lVar10 = Transform.Find(lVar10,"Money",0)) == null) ||
                     (lVar10 = Transform.Find(lVar10,"Icon",0)) == null)))))
                goto LAB_180b1d9f5;
                plVar11 = (int64 *)Component.GetComponent(lVar10,DAT_181d6bc40);
                puVar7 = (uint64 *)FUN_181098a50(&local_98,0);
                if (plVar11 == (int64 *)0) goto LAB_180b1d9f5;
                local_98 = *puVar7;
                uStack_90 = puVar7[1];
                (**(code **)(*plVar11 + 0x2a8))(plVar11,&local_98,*(uint64 *)(*plVar11 + 0x2b0));
                lVar10 = FUN_18046c1a0(0);
                if (((lVar10 == null) || (*(int64 *)(lVar10 + 56) == 0)) ||
                   ((lVar10 = GameObject.get_transform(*(int64 *)(lVar10 + 56),0), lVar10 == null ||
                    ((lVar10 = Transform.Find(lVar10,"BattleEndUI",0), lVar10 == null ||
                     (lVar10 = Transform.Find(lVar10,"Money",0)) == null)))))
                goto LAB_180b1d9f5;
                uVar4 = Component.GetComponent(lVar10,DAT_181d6d8c0);
                if (*plVar5 == 0) goto LAB_180b1d9f5;
                uVar8 = Int32.ToString(*plVar5 + 24,"+0;-0;0",0);
                LTLocalization.SetText(uVar4,uVar8,0);
                lVar10 = new ItemListData(0);
                *plVar5 = lVar10;
                il2cpp_internal(plVar5,lVar10);
                lVar3 = FUN_18046c0a0(0);
                lVar10 = *plVar5;
                Random.Range();
                uVar15 = Mathf.RoundToInt();
                uVar15 = Mathf.Max(1,uVar15);
                uVar19 = Mathf.Max();
                if (lVar3 == null) goto LAB_180b1d9f5;
                GameController.GenerateRandomItem(lVar3,lVar10,uVar15,fVar17 * 1.7,uVar19,0,0,0);
              }
              else {
                lVar10 = FUN_18046c1a0(0);
                if ((((lVar10 == null) || (*(int64 *)(lVar10 + 56) == 0)) ||
                    (lVar10 = GameObject.get_transform(*(int64 *)(lVar10 + 56),0)) == null) ||
                   ((lVar10 = Transform.Find(lVar10,"BattleEndUI",0), lVar10 == null ||
                    (lVar10 = Transform.Find(lVar10,"Money",0)) == null))) goto LAB_180b1d9f5;
                uVar4 = Component.GetComponent(lVar10,DAT_181d6d8c0);
                if (*plVar5 == 0) goto LAB_180b1d9f5;
                uVar8 = Int32.ToString(*plVar5 + 24,0);
                uVar8 = String.Concat("银钱 ",uVar8,0);
                LTLocalization.SetText(uVar4,uVar8,0);
              }
              lVar10 = FUN_18046c1a0(0);
              if ((((lVar10 != null) && (*(int64 *)(lVar10 + 56) != 0)) &&
                  (lVar10 = GameObject.get_transform(*(int64 *)(lVar10 + 56),0)) != null) &&
                 (((lVar10 = Transform.Find(lVar10,"BattleEndUI",0), lVar10 != null &&
                   (lVar10 = Transform.Find(lVar10,"ItemListScrollView",0)) != null) &&
                  (lVar10 = Component.GetComponent(lVar10,DAT_181d6be40)) != null))) {
                ItemListController.RefreshItemList(lVar10,*plVar5,1,0);
                return false;
              }
            }
        LAB_180b1d9f5:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          goto LAB_180b1d96f;
        }
        if (*(int *)(lVar10 + 48) != iVar12) {
          iVar13 = 0;
          while( true ) {
            if (((*(int64 *)(lVar10 + 112) == 0) ||
                (lVar3 = FUN_180002f80(*(int64 *)(lVar10 + 112),iVar12,DAT_181d580a8),
                fVar16 = local_res8[0], lVar3 == null)) || (*(int64 *)(lVar3 + 24) == 0))
            goto LAB_180b1d96f;
            if (*(int *)(*(int64 *)(lVar3 + 24) + 24) <= iVar13) break;
            if (((*(int64 *)(lVar10 + 112) == 0) ||
                (lVar3 = FUN_180002f80(*(int64 *)(lVar10 + 112),iVar12,DAT_181d580a8)) == null) ||
               ((*(int64 *)(lVar3 + 24) == 0 ||
                ((lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 24),iVar13,DAT_181d584a0), lVar3 == null ||
                 (*(int64 *)(lVar3 + 64) == 0)))))) goto LAB_180b1d96f;
            if (*(char *)(*(int64 *)(lVar3 + 64) + 16) == false) {
              if ((((*(int64 *)(lVar10 + 112) == 0) ||
                   (lVar3 = FUN_180002f80(*(int64 *)(lVar10 + 112),iVar12,DAT_181d580a8)) == null)
                  || (*(int64 *)(lVar3 + 24) == 0)) ||
                 ((lVar3 = FUN_180002f80(*(int64 *)(lVar3 + 24),iVar13,DAT_181d584a0), lVar3 == null ||
                  (*(int64 *)(lVar3 + 64) == 0)))) goto LAB_180b1d96f;
              local_res8[0] = (float)Mathf.Max();
              local_res8[0] = fVar16 + local_res8[0];
              iVar13 = iVar13 + 1;
            }
            else {
              iVar13 = iVar13 + 1;
              local_res8[0] = fVar16 + 0.0;
            }
          }
        }
        iVar12 = iVar12 + 1;
        goto LAB_180b1bcd0;
    }

    // Token : 0x6000BEE
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000BEF
    // RVA   : 0xB1DA10   Offset: 0xB1C210   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d6e618);
    }

    // Token : 0x6000BF0
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
