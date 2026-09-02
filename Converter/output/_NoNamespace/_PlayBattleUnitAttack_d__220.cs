// ============================================================
// Type  : <PlayBattleUnitAttack>d__220
// Token : 0x2000166
// ============================================================

public class <PlayBattleUnitAttack>d__220
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400094D
    private int <>1__state;

    // Token: 0x400094E
    private object <>2__current;

    // Token: 0x400094F
    public BattleController <>4__this;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000BB6
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000BB7
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000BB8
    // RVA   : 0xB23B10   Offset: 0xB22310   Length: 0x7EA
    private virtual bool MoveNext()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        ulong uVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        int iVar6;
        long lVar8;
        long lVar10;
        ulong uVar11;
        float fVar14;
        ulong local_58;
        uint local_50;
        uint local_48;
        uint uStack_44;
        uint uStack_40;
        uint32 uStack_3c;
        lVar3 = this.<>4__this;
        if (this.<>1__state != 0) {
          if (this.<>1__state == 1) {
            this.<>1__state = 0xffffffff;
          }
          return false;
        }
        this.<>1__state = 0xffffffff;
        if (lVar3 == null) throw; // [null/range check failed]
        *(uint8 *)(lVar3 + 0x128) = 1;
        *(uint32 *)(lVar3 + 0x2a4) = 0;
        *(uint8 *)(lVar3 + 0x2a0) = 1;
        puVar7 = (uint64 *)BattleController.GetAverageAttackPos(&local_48,lVar3,0);
        uVar1 = *puVar7;
        uVar4 = puVar7[1];
        local_58 = uVar1;
        if ((*(int64 *)(lVar3 + 0x110) == 0) ||
           (lVar8 = *(int64 *)(*(int64 *)(lVar3 + 0x110) + 96)) == null) throw; // [null/range check failed]
        lVar8 = GridUnitData.get_GridObj(lVar8,0);
        if (lVar8 == null) throw; // [null/range check failed]
        lVar8 = GameObject.get_transform(lVar8,0);
        if (lVar8 == null) throw; // [null/range check failed]
        pfVar9 = (float *)Transform.get_localPosition(&local_48,lVar8,0);
        uVar5 = local_58;
        fVar14 = (float)local_58;
        lVar8 = *(int64 *)(lVar3 + 0x110);
        if (*pfVar9 <= (float)local_58 && (float)local_58 != *pfVar9) {
          if (lVar8 == null) throw; // [null/range check failed]
          uVar11 = 1;
        LAB_180b23cfa:
          BattleUnit.ChangeFaceDirection(lVar8,uVar11,0,0);
        }
        else {
          if ((lVar8 == null) || (*(int64 *)(lVar8 + 96) == 0)) throw; // [null/range check failed]
          lVar8 = GridUnitData.get_GridObj(*(int64 *)(lVar8 + 96),0);
          if (lVar8 == null) throw; // [null/range check failed]
          lVar8 = GameObject.get_transform(lVar8,0);
          if (lVar8 == null) throw; // [null/range check failed]
          pfVar9 = (float *)Transform.get_localPosition(&local_48,lVar8,0);
          if (fVar14 < *pfVar9) {
            lVar8 = *(int64 *)(lVar3 + 0x110);
            if (lVar8 == null) throw; // [null/range check failed]
            uVar11 = 0;
            goto LAB_180b23cfa;
          }
        }
        lVar8 = *(int64 *)(lVar3 + 0x110);
        if ((lVar8 != null) && (*(int64 *)(lVar8 + 64) != 0)) {
          lVar10 = HeroData.GetNowActiveSkill(*(int64 *)(lVar8 + 64),0);
          if (lVar10 != null) {
            uVar11 = KungfuSkillLvData.Name(lVar10,1,0);
            puVar12 = (uint32 *)Color.get_yellow(&local_48,0);
            local_48 = *puVar12;
            uStack_44 = puVar12[1];
            uStack_40 = puVar12[2];
            uStack_3c = puVar12[3];
            BattleUnit.ShowTextOnHead(lVar8,uVar11,&local_48,18,24,"UIAtlas",0,0,0);
            if ((*(int64 *)(lVar3 + 0x110) != 0) && (*pStatics != 0)) {
              GameController.CountHeroData
                        (*pStatics,
                         *(uint64 *)(*(int64 *)(lVar3 + 0x110) + 64),0);
              lVar8 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 8);
              if ((lVar8 != null) && (lVar8 = *(int64 *)(lVar8 + 16)) != null) {
                iVar6 = PlayerPrefDictionary.GetInt(lVar8,"FightViewFollow",0);
                if (iVar6 == 1) {
                  if ((*(int64 *)(lVar3 + 0x110) == 0) ||
                     (lVar8 = *(int64 *)(*(int64 *)(lVar3 + 0x110) + 96)) == null)
                  throw; // [null/range check failed]
                  lVar8 = GridUnitData.get_GridObj(lVar8,0);
                  if (lVar8 == null) throw; // [null/range check failed]
                  lVar8 = GameObject.get_transform(lVar8,0);
                  if (lVar8 == null) throw; // [null/range check failed]
                  puVar7 = (uint64 *)Transform.get_localPosition(&local_48,lVar8,0);
                  local_58 = *puVar7;
                  local_50 = (uint32)puVar7[1];
                  fVar14 = (float)Vector2.Distance(uVar5 & 0xffffffff,local_58,0);
                  fVar14 = (float)Mathf.Max(0,fVar14 - 4.0,0);
                  uVar11 = Mathf.Max(0x3f000000,1.0 - fVar14 * 0.15,0);
                  local_58 = uVar1;
                  local_50 = (int)uVar4;
                  BattleController.FocusOnTarget(lVar3,&local_58,uVar11,0);
                }
                plVar13 = (int64 *)FUN_1800d60b0(DAT_181d7f180,4);
                if ((*(int64 *)(lVar3 + 0x110) != 0) &&
                   (lVar8 = *(int64 *)(*(int64 *)(lVar3 + 0x110) + 64)) != null) {
                  lVar8 = HeroData.Name(lVar8,1,0);
                  if (plVar13 != (int64 *)0) {
                    if (lVar8 != null) {
                      lVar10 = il2cpp_internal(lVar8,*(uint64 *)(*plVar13 + 64));
                      if (lVar10 == null) {
                        uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar11,0);
                      }
                    }
                    if ((int)plVar13[3] == 0) {
                      uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1800d65f0(uVar11,0);
                    }
                    plVar13[4] = lVar8;
                    il2cpp_internal(plVar13 + 4,lVar8);
                    lVar8 = *(int64 *)(*(int64 *)(DAT_181d4ef00 + 184) + 0x498);
                    if ((*(int64 *)(lVar3 + 0x110) != 0) &&
                       (lVar10 = *(int64 *)(*(int64 *)(lVar3 + 0x110) + 64)) != null) {
                      lVar10 = HeroData.GetNowActiveSkill(lVar10,0);
                      if (lVar10 != null) {
                        lVar10 = KungfuSkillLvData.DataBase(lVar10,0);
                        if ((lVar10 != null) && (lVar8 != null)) {
                          uVar2 = *(uint32 *)(lVar10 + 48);
                          if (*(uint32 *)(lVar8 + 24) <= uVar2) {
                            ThrowHelper.ThrowArgumentOutOfRangeException(0);
                          }
                          lVar8 = *(int64 *)
                                   (*(int64 *)(lVar8 + 16) + 32 + (int64)(int)uVar2 * 8);
                          if (lVar8 != null) {
                            lVar10 = il2cpp_internal(lVar8,*(uint64 *)(*plVar13 + 64));
                            if (lVar10 == null) {
                              uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar11,0);
                            }
                          }
                          if (*(uint32 *)(plVar13 + 3) < 2) {
                            uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar11,0);
                          }
                          plVar13[5] = lVar8;
                          il2cpp_internal(plVar13 + 5,lVar8);
                          if ((*(int64 *)(lVar3 + 0x110) != 0) &&
                             (lVar8 = *(int64 *)(*(int64 *)(lVar3 + 0x110) + 64)) != null) {
                            lVar8 = HeroData.GetNowActiveSkill(lVar8,0);
                            if (lVar8 != null) {
                              lVar8 = KungfuSkillLvData.Name(lVar8,1,0);
                              if (lVar8 != null) {
                                lVar10 = il2cpp_internal(lVar8,*(uint64 *)(*plVar13 + 64));
                                if (lVar10 == null) {
                                  uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                  FUN_1800d65f0(uVar11,0);
                                }
                              }
                              if (*(uint32 *)(plVar13 + 3) < 3) {
                                uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar11,0);
                              }
                              plVar13[6] = lVar8;
                              il2cpp_internal(plVar13 + 6,lVar8);
                              if ((*(int64 *)(lVar3 + 0x110) != 0) &&
                                 (lVar8 = *(int64 *)(*(int64 *)(lVar3 + 0x110) + 64)) != null)
                              {
                                lVar8 = HeroData.GetNowActiveSkill(lVar8,0);
                                if (lVar8 != null) {
                                  lVar8 = KungfuSkillLvData.DataBase(lVar8,0);
                                  uVar11 = "{0}{3}{1}{2}。";
                                  if (lVar8 != null) {
                                    lVar10 = "激活";
                                    if (2 < *(int *)(lVar8 + 48)) {
                                      lVar10 = "使用";
                                    }
                                    if (lVar10 != null) {
                                      lVar8 = il2cpp_internal(lVar10,*(uint64 *)(*plVar13 + 64))
                                      ;
                                      if (lVar8 == null) {
                                        uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                        FUN_1800d65f0(uVar11,0);
                                      }
                                    }
                                    if (3 < *(uint32 *)(plVar13 + 3)) {
                                      plVar13[7] = lVar10;
                                      il2cpp_internal(plVar13 + 7,lVar10);
                                      uVar11 = String.Format(uVar11,plVar13,0);
                                      BattleController.AddInfoText(lVar3,uVar11,1,0);
                                      uVar11 = BattleController.BattleUnitAttackStart(lVar3,0);
                                      FUN_180d837c0(lVar3,uVar11,0);
                                      this.<>2__current = 0;
                                      this.<>1__state = 1;
                                      return true;
                                    }
                                    uVar11 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar11,0);
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

    // Token : 0x6000BB9
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000BBA
    // RVA   : 0xB24300   Offset: 0xB22B00   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d6eb18);
    }

    // Token : 0x6000BBB
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
