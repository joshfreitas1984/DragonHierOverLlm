// ============================================================
// Type  : <PlayUseItem>d__210
// Token : 0x2000162
// ============================================================

public class <PlayUseItem>d__210
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400093F
    private int <>1__state;

    // Token: 0x4000940
    private object <>2__current;

    // Token: 0x4000941
    public BattleController <>4__this;

    // Token: 0x4000942
    public BattleUnit targetUnit;

    // Token: 0x4000943
    public ItemData targetItem;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000B9E
    // RVA   : 0x219070   Offset: 0x217870   Length: 0x24
    public void /*ctor*/(int <>1__state)
    {
        ZhSegment.Initialize(this,0);
        this.<>1__state = <>1__state;
    }

    // Token : 0x6000B9F
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    private virtual void System.IDisposable.Dispose()
    {
    }

    // Token : 0x6000BA0
    // RVA   : 0xB25500   Offset: 0xB23D00   Length: 0x838
    private virtual bool MoveNext()
    {
        ulong uVar1;
        ulong uVar2;
        bool cVar3;
        int iVar4;
        ulong uVar5;
        long lVar6;
        long lVar7;
        int iVar8;
        ulong uVar9;
        float fVar10;
        uint uVar11;
        float fVar12;
        ulong uVar13;
        ulong local_90;
        ulong uStack_88;
        ulong local_80;
        uint local_78;
        uint uStack_74;
        uint uStack_70;
        uint32 uStack_6c;
        uint64 local_68;
        local_90 = 0;
        uStack_88 = 0;
        local_80 = 0;
        iVar4 = this.<>1__state;
        lVar7 = this.<>4__this;
        if (iVar4 != 0) {
          if (iVar4 != 1) {
            if (iVar4 == 2) {
              this.<>1__state = 0xffffffff;
              return false;
            }
            return false;
          }
          this.<>1__state = 0xffffffff;
          if (lVar7 != null) {
            *(uint8 *)(lVar7 + 0x128) = 0;
            *(uint8 *)(lVar7 + 0x121) = 1;
            *(uint64 *)(lVar7 + 0x218) = 0;
            *(uint32 *)(lVar7 + 0x124) = 12;
            this.<>2__current = 0;
            this.<>1__state = 2;
            return true;
          }
          throw; // [null/range check failed]
        }
        this.<>1__state = 0xffffffff;
        if (lVar7 == null) throw; // [null/range check failed]
        *(uint8 *)(lVar7 + 0x128) = 1;

        if ((lVar6 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 8)?.itemID) == null) throw; // [null/range check failed]
        iVar4 = PlayerPrefDictionary.GetInt(lVar6,"FightViewFollow",0);
        if (iVar4 == 1) {
          if (this.targetUnit == null) throw; // [null/range check failed]
          uVar5 = Component.get_gameObject(this.targetUnit,0);
          BattleController.FocusOnTarget(lVar7,uVar5,0);
        }
        if ((this.targetUnit == null) ||
           (lVar6 = this.targetUnit.mapGrid) == null) throw; // [null/range check failed]
        iVar4 = lVar6.checkName;
        lVar6 = *(int64 *)(lVar7 + 0x110);
        if ((lVar6 == null) || (lVar6.equipmentData == null)) throw; // [null/range check failed]
        iVar8 = *(int *)(lVar6.equipmentData + 40);
        if (iVar8 < iVar4) {
          uVar5 = CONCAT71((uint7)(uint3)((uint32)iVar4 >> 8),1);
        LAB_180b2577b:
          BattleUnit.ChangeFaceDirection(lVar6,uVar5,0,0);
        }
        else if (iVar4 < iVar8) {
          uVar5 = 0;
          goto LAB_180b2577b;
        }
        if ((*(int64 *)(lVar7 + 0x110) != 0) &&
           (lVar6 = *(int64 *)(*(int64 *)(lVar7 + 0x110) + 24)) != null) {
          lVar6 = SkeletonAnimation.get_AnimationState(lVar6,0);
          uVar5 = this.targetUnit;
          uVar9 = *(uint64 *)(lVar7 + 0x110);
          cVar3 = Object.op_Equality(uVar5,uVar9,0);
          uVar5 = "givedrink";
          if (cVar3) {
            uVar5 = "drink";
          }
          if (lVar6 != null) {
            uVar9 = 0;
            AnimationState.SetAnimation(lVar6,1,uVar5,0,0);
            if (((*(int64 *)(lVar7 + 0x110) != 0) &&
                (lVar6 = *(int64 *)(*(int64 *)(lVar7 + 0x110) + 24)) != null) &&
               (lVar6 = SkeletonAnimation.get_AnimationState(lVar6,0)) != null) {
              uVar13 = 0;
              AnimationState.AddEmptyAnimation(lVar6,1);
              lVar6 = this.targetUnit;
              uVar5 = this.targetItem;
              uVar1 = *(uint64 *)(lVar7 + 0x110);
              cVar3 = Object.op_Inequality(lVar6,uVar1,0);
              if (cVar3) {
                if (*(int64 *)(lVar7 + 0x110) == 0) throw; // [null/range check failed]
                uVar9 = *(uint64 *)(*(int64 *)(lVar7 + 0x110) + 64);
              }
              if (lVar6 != null) {
                BattleUnit.UseMedFood(lVar6,uVar5,uVar9,0,uVar13);
                if ((this.targetUnit != null) &&
                   (lVar7 = this.targetUnit.heroData) != null) {
                  fVar12 = *(float *)(lVar7 + 0x240);
                  lVar6 = this.targetItem;
                  if (lVar6 != null) {
                    iVar4 = lVar6.itemLv;
                    iVar8 = 6;
                    if (lVar6.type != 1) {
                      iVar8 = 2;
                    }
                    if (*(int64 *)(lVar7 + 0x2b8) != 0) {
                      fVar10 = (float)HeroSpeAddData.Get(*(int64 *)(lVar7 + 0x2b8),206,0);
                      fVar10 = (float)Mathf.Max(0x3dcccccd,1.0 - fVar10,0);
                      uVar11 = Mathf.Min(0x3f800000,(float)(iVar4 + iVar8) * 0.05 * fVar10 + fVar12,0);
                      *(uint32 *)(lVar7 + 0x240) = uVar11;
                      if (((this.targetItem != null) &&
                          (lVar7 = this.targetItem.medFoodData) != null) &&
                         (lVar7 = lVar7.mouthPos) != null) {
                        cVar3 = HeroSpeAddData.isEmpty(lVar7,0);
                        if (!cVar3) {
                          if (((this.targetItem == null) ||
                              (lVar7 = this.targetItem.medFoodData) == null)
                             || ((lVar7 = lVar7.mouthPos, lVar7 == null ||
                                 ((lVar7 = *(int64 *)(lVar7 + 16), lVar7 == null ||
                                  (lVar7 = Dictionary_2.get_Keys(lVar7,DAT_181d98b10)) == null)))))
                          throw; // [null/range check failed]
                          FUN_180ed4d30(&local_78,lVar7,DAT_181d9c570);
                          local_90 = CONCAT44(uStack_74,local_78);
                          uStack_88 = CONCAT44(uStack_6c,uStack_70);
                          local_80 = local_68;
                          while (cVar3 = FUN_1811d8280(&local_90,DAT_181d74c38), uVar2 = local_80,
                                cVar3) {
                            lVar7 = FUN_18046c100(0);
                            if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                              FUN_1800d6620();
                            }
                            if (lVar7.smokePlume == null) {
                          // WARNING: Subroutine does not return
                              FUN_1800d6620();
                            }
                            lVar7 = FUN_180002f80(lVar7.smokePlume,uVar2 & 0xffffffff);
                            if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                              FUN_1800d6620();
                            }
                            if (*(int *)(lVar7 + 60) != 0) {
                              if (this.targetItem == null) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              lVar7 = this.targetItem.medFoodData;
                              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              lVar7 = lVar7.mouthPos;
                              if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                                FUN_1800d6620();
                              }
                              fVar12 = (float)HeroSpeAddData.Get(lVar7,uVar2 & 0xffffffff);
                              if (0.0 < fVar12) {
                                fVar12 = (float)Random.get_value(0);
                                if (this.targetItem == null) {
                          // WARNING: Subroutine does not return
                                  FUN_1800d6620();
                                }
                                lVar7 = this.targetItem.medFoodData;
                                if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                                  FUN_1800d6620();
                                }
                                lVar7 = lVar7.mouthPos;
                                if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                                  FUN_1800d6620();
                                }
                                fVar10 = (float)HeroSpeAddData.Get(lVar7,uVar2 & 0xffffffff);
                                if (fVar12 <= fVar10) {
                                  lVar7 = FUN_18046c100(0);
                                  if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                                    FUN_1800d6620();
                                  }
                                  if (lVar7.smokePlume == null) {
                          // WARNING: Subroutine does not return
                                    FUN_1800d6620();
                                  }
                                  lVar7 = FUN_180002f80(lVar7.smokePlume,uVar2 & 0xffffffff);
                                  if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                                    FUN_1800d6620();
                                  }
                                  if (*(int *)(lVar7 + 60) == -1) {
                                    Debug.LogError("错误！自身buff无法根据内力差值调整时间",0);
                                  }
                                  else {
                                    lVar7 = this.targetUnit;
                                    lVar6 = FUN_18046c100(0);
                                    if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                                      FUN_1800d6620();
                                    }
                                    if (*(int64 *)(lVar6 + 144) == 0) {
                          // WARNING: Subroutine does not return
                                      FUN_1800d6620();
                                    }
                                    lVar6 = FUN_180002f80(*(int64 *)(lVar6 + 144),uVar2 & 0xffffffff);
                                    if (lVar6 == null) {
                          // WARNING: Subroutine does not return
                                      FUN_1800d6620();
                                    }
                                    if (lVar7 == null) {
                          // WARNING: Subroutine does not return
                                      FUN_1800d6620();
                                    }
                                    BattleUnit.AddBuff(lVar7,uVar2 & 0xffffffff);
                                  }
                                }
                              }
                            }
                          }
                          ZhSegment.Initialize(&local_90,DAT_181d74bb8);
                        }
                        lVar7 = FUN_18046c0a0(0);
                        if ((lVar7 != null) && (lVar7.hipPos != null)) {
                          fVar12 = *(float *)(lVar7.hipPos + 0x1d8);
                          uVar5 = new WaitForSeconds(1.5 / fVar12,0);
                          this.<>2__current = uVar5;
                          this.<>1__state = 1;
                          return true;
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

    // Token : 0x6000BA1
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.Generic.IEnumerator<System.object>.get_Current()
    {
        return this.<>2__current;
    }

    // Token : 0x6000BA2
    // RVA   : 0xB25D40   Offset: 0xB24540   Length: 0x3E
    private virtual void System.Collections.IEnumerator.Reset()
    {
        ulong uVar1;
        ulong uVar2;
        uVar1 = il2cpp_runtime_class_init(&DAT_181d682e8);
        uVar1 = il2cpp_internal(uVar1);
        NotSupportedException.ctor(uVar1,0);
        uVar2 = il2cpp_runtime_class_init(&DAT_181d6ed98);
    }

    // Token : 0x6000BA3
    // RVA   : 0x20F140   Offset: 0x20D940   Length: 0x5
    private virtual object System.Collections.IEnumerator.get_Current()
    {
        return this.<>2__current;
    }

}
