// ============================================================
// Type  : ActionBarUnit
// Token : 0x2000139
// ============================================================

public class ActionBarUnit
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000794
    public BattleUnit targetBattleUnit;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000A09
    // RVA   : 0x7842F0   Offset: 0x7830F0   Length: 0x51E
    public void RefreshActionBarUnit(bool useAnim)
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        long lVar1;
        bool cVar2;
        ulong uVar3;
        long lVar4;
        ulong uVar7;
        float fVar8;
        float fVar9;
        float fVar10;
        float fVar11;
        float[] local_res10 = new float[2];
        float local_28;
        ulong uStack_24;
        float fStack_1c;
        uVar3 = Component.get_transform(this,0);
        if (!useAnim) {
          DOTween.Complete(uVar3,0,0);
          lVar4 = Component.get_transform(this,0);
          if (this.targetBattleUnit == null) throw; // [null/range check failed]
          fVar8 = this.targetBattleUnit.battleMove;
          fVar8 = (float)FUN_180f34e60(fVar8 / *(float *)(pStatics + 0x238),0,
                                       0x3f800000,0);
          if (lVar4 == null) throw; // [null/range check failed]
          uStack_24 = 0;
          local_28 = fVar8 * 1296.0;
          Transform.set_localPosition(lVar4,&local_28,0);
        }
        else {
          uVar3 = ShortcutExtensions.DOScale(uVar3,0x3fc00000,0x3e99999a,0);
          uVar3 = TweenSettingsExtensions.SetLoops(uVar3,2,1,DAT_181ea4f40);
          TweenSettingsExtensions.SetEase(uVar3,9,DAT_181ea4b88);
          uVar3 = Component.get_transform(this,0);
          if (this.targetBattleUnit == null) throw; // [null/range check failed]
          fVar8 = this.targetBattleUnit.battleMove;
          local_28 = (float)FUN_180f34e60(fVar8 / *(float *)(pStatics + 0x238),
                                          0,0x3f800000,0);
          local_28 = local_28 * 1296.0;
          uStack_24 = 0;
          uVar3 = ShortcutExtensions.DOLocalMove(uVar3,&local_28,0x3e99999a,0,0);
          TweenSettingsExtensions.SetUpdate(uVar3,1,DAT_181ea59e0);
        }
        lVar4 = Component.get_transform(this,0);
        if (lVar4 != null) {
          plVar5 = (int64 *)Component.GetComponent(lVar4,DAT_181e777b8);
          lVar4 = *(int64 *)(*(int64 *)(DAT_181e90420 + 184) + 80);
          if (lVar4 != null) {
            uVar3 = *(uint64 *)(lVar4 + 0x110);
            uVar7 = this.targetBattleUnit;
            cVar2 = Object.op_Equality(uVar3,uVar7,0);
            if (!cVar2) {
              pfVar6 = (float *)FUN_180f24b80(&local_28,0);
              fVar8 = *pfVar6;
              fVar9 = pfVar6[1];
              fVar10 = pfVar6[2];
              fVar11 = pfVar6[3];
            }
            else {
              lVar4 = pStatics;
              fVar8 = *(float *)(lVar4 + 0x350);
              fVar9 = *(float *)(lVar4 + 0x354);
              fVar10 = *(float *)(lVar4 + 0x358);
              fVar11 = *(float *)(lVar4 + 0x35c);
            }
            if (plVar5 != (int64 *)0) {
              uStack_24 = CONCAT44(fVar10,fVar9);
              local_28 = fVar8;
              fStack_1c = fVar11;
              (**(code **)(*plVar5 + 0x2a8))(plVar5,&local_28,*(uint64 *)(*plVar5 + 0x2b0));
              uVar3 = *(uint64 *)(*(int64 *)(DAT_181e6bb68 + 184) + 72);
              uVar7 = Component.get_gameObject(this,0);
              cVar2 = Object.op_Equality(uVar3,uVar7,0);
              if (!cVar2) {
                return;
              }
              lVar4 = Component.get_transform(this,0);
              if (lVar4 != null) {
                lVar4 = Component.GetComponent(lVar4,DAT_181e788b8);
                if (((this.targetBattleUnit != null) &&
                    (lVar1 = this.targetBattleUnit.heroData) != null) &&
                   (lVar1 = *(int64 *)(lVar1 + 0x2b8)) != null) {
                  local_res10[0] = (float)HeroSpeAddData.Get(lVar1,63);
                  local_res10[0] = local_res10[0] * 100.0;
                  uVar3 = Single.ToString(local_res10,0);
                  uVar3 = String.Concat("速度",uVar3,"%",0);
                  if (lVar4 != null) {
                    *(uint64 *)(lVar4 + 24) = uVar3;
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000A0A
    // RVA   : 0x784090   Offset: 0x782E90   Length: 0x251
    public void OnClick()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        lVar2 = PlotController.LaBaFestivelResultTalkText;
        if (lVar2 != null) {
          cVar1 = BattleController.HaveFocusTarget(lVar2,0);
          if (cVar1) {
            return;
          }
          lVar2 = PlotController.LaBaFestivelResultTalkText;
          if (lVar2 != null) {
            uVar3 = *(uint64 *)(lVar2 + 0x110);
            cVar1 = Object.op_Inequality(uVar3,0,0);
            if (!cVar1) {
              return;
            }
            lVar2 = FUN_1802101c0(0);
            if ((lVar2 != null) && (*(int64 *)(lVar2 + 0x110) != 0)) {
              if (*(char *)(*(int64 *)(lVar2 + 0x110) + 56) == false) {
                return;
              }
              lVar2 = FUN_1802101c0(0);
              if (lVar2 != null) {
                if (*(char *)(lVar2 + 0x128) != false) {
                  return;
                }
                lVar2 = FUN_1802101c0(0);
                if ((this.targetBattleUnit != null) &&
                   (uVar3 = Component.get_gameObject(this.targetBattleUnit,0), lVar2 != null)) {
                  BattleController.FocusOnTarget(lVar2,uVar3,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000A0B
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
