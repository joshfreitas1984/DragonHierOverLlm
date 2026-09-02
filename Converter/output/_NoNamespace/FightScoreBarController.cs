// ============================================================
// Type  : FightScoreBarController
// Token : 0x2000002
// ============================================================

public class FightScoreBarController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000001
    public GameObject greenBar;

    // Token: 0x4000002
    public GameObject icon;

    // Token: 0x4000003
    private float barWidth;

    // Token: 0x4000004
    private List<float> teamScore;

    // Token: 0x4000005
    private static FightScoreBarController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000001
    // RVA   : 0xBA61E0   Offset: 0xBA49E0   Length: 0x36
    public static FightScoreBarController get_Instance()
    {
        return **(uint64 **)(DAT_181da1d20 + 184);
    }

    // Token : 0x6000002
    // RVA   : 0xBA58D0   Offset: 0xBA40D0   Length: 0x11D
    private void Awake()
    {
        bool cVar2;
        uint uVar3;
        ulong uVar4;
        long lVar5;
        uVar4 = **(uint64 **)(DAT_181da1d20 + 184);
        cVar2 = Object.op_Equality(uVar4,0,0);
        if (!cVar2) {
          uVar4 = Component.get_gameObject(this,0);
          Object.Destroy(uVar4,0);
          return;
        }
        plVar1 = *(int64 **)(DAT_181da1d20 + 184);
        *plVar1 = this;
        il2cpp_internal(plVar1,this);
        if (this.greenBar != null) {
          lVar5 = GameObject.GetComponent(this.greenBar,DAT_181da0b98);
          if (lVar5 != null) {
            uVar3 = RectTransform.get_sizeDelta(lVar5,0);
            this.barWidth = uVar3;
            return;
          }
        }
    }

    // Token : 0x6000003
    // RVA   : 0xBA59F0   Offset: 0xBA41F0   Length: 0x7ED
    public void RefreshFightScoreBar(bool skipAnim)
    {
        float fVar1;
        float fVar2;
        bool cVar3;
        long lVar4;
        long lVar5;
        ulong uVar6;
        uint32 extraout_var;
        uint64 *puVar7;
        int iVar8;
        int iVar9;
        float fVar10;
        uint64 local_98;
        uint32 local_90;
        uint64 local_88;
        uint32 local_80;
        uint64 local_78;
        uint32 local_70;
        lVar4 = il2cpp_internal(DAT_181d721b0);
        FUN_180f58a90(lVar4,DAT_181d79358);
        if (lVar4 != null) {
          FUN_181805690(lVar4,0,DAT_181d79458);
          FUN_181805690(lVar4,0,DAT_181d79458);
          this.teamScore = lVar4;
          iVar9 = 0;
          do {
            iVar8 = 0;
            while( true ) {
              lVar4 = FUN_18046bb80(0);
              if ((((lVar4 == null) || (*(int64 *)(lVar4 + 112) == 0)) ||
                  (lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 112),iVar9,DAT_181d580a8)) == null) ||
                 (lVar4.Count == null)) throw; // [null/range check failed]
              if (*(int *)(lVar4.Count + 24) <= iVar8) break;
              lVar4 = FUN_18046bb80(0);
              if ((((lVar4 == null) || (*(int64 *)(lVar4 + 112) == 0)) ||
                  (lVar4 = FUN_180002f80(*(int64 *)(lVar4 + 112),iVar9,DAT_181d580a8)) == null) ||
                 ((lVar4.Count == null ||
                  (lVar4 = FUN_180002f80(lVar4.Count,iVar8,DAT_181d584a0)) == null)))
              throw; // [null/range check failed]
              cVar3 = BattleUnit.get_IsAlive(lVar4,0);
              if (cVar3) {
                lVar4 = this.teamScore;
                if (lVar4 == null) throw; // [null/range check failed]
                fVar10 = (float)FUN_1800d6780(lVar4,iVar9,DAT_181d796d8);
                lVar5 = FUN_18046bb80(0);
                if ((((lVar5 == null) || (*(int64 *)(lVar5 + 112) == 0)) ||
                    (lVar5 = FUN_180002f80(*(int64 *)(lVar5 + 112),iVar9,DAT_181d580a8)) == null)
                   || (((lVar5.Count == null ||
                        (lVar5 = FUN_180002f80(lVar5.Count,iVar8,DAT_181d584a0),
                        lVar5 == null)) || (*(int64 *)(lVar5 + 64) == 0)))) throw; // [null/range check failed]
                fVar1 = *(float *)(*(int64 *)(lVar5 + 64) + 0x38c);
                lVar5 = FUN_18046bb80(0);
                if (((lVar5 == null) || (*(int64 *)(lVar5 + 112) == 0)) ||
                   ((lVar5 = FUN_180002f80(*(int64 *)(lVar5 + 112),iVar9,DAT_181d580a8), lVar5 == null ||
                    (((lVar5.Count == null ||
                      (lVar5 = FUN_180002f80(lVar5.Count,iVar8,DAT_181d584a0)) == null
                      ) || (*(int64 *)(lVar5 + 64) == 0)))))) throw; // [null/range check failed]
                fVar2 = *(float *)(*(int64 *)(lVar5 + 64) + 0x178);
                lVar5 = FUN_18046bb80(0);
                if (((lVar5 == null) || (*(int64 *)(lVar5 + 112) == 0)) ||
                   ((lVar5 = FUN_180002f80(*(int64 *)(lVar5 + 112),iVar9,DAT_181d580a8), lVar5 == null ||
                    (((lVar5.Count == null ||
                      (lVar5 = FUN_180002f80(lVar5.Count,iVar8,DAT_181d584a0)) == null
                      ) || (*(int64 *)(lVar5 + 64) == 0)))))) throw; // [null/range check failed]
                FUN_181814d10(lVar4,iVar9,
                              (fVar2 * fVar1) / *(float *)(*(int64 *)(lVar5 + 64) + 0x180) + fVar10);
              }
              iVar8 = iVar8 + 1;
            }
            iVar9 = iVar9 + 1;
          } while (iVar9 < 2);
          lVar4 = this.teamScore;
          if (lVar4 != null) {
            lVar5 = lVar4;
            if (lVar4.Count == null) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              lVar5 = this.teamScore;
            }
            fVar10 = *(float *)(lVar4._items + 32);
            if (lVar5 != null) {
              if (lVar5.Count < 2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              fVar10 = fVar10 + *(float *)(lVar5._items + 36);
              if (fVar10 == 0.0) {
                fVar10 = 0.5;
              }
              else {
                lVar4 = this.teamScore;
                if (lVar4 == null) throw; // [null/range check failed]
                if (lVar4.Count == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                fVar10 = *(float *)(lVar4._items + 32) / fVar10;
              }
              lVar4 = this.greenBar;
              if (!skipAnim) {
                if (lVar4 != null) {
                  uVar6 = GameObject.GetComponent(lVar4,DAT_181da0b98);
                  fVar1 = this.barWidth;
                  if ((this.greenBar != null) &&
                     (lVar4 = GameObject.GetComponent(this.greenBar,DAT_181da0b98),
                     lVar4 != null)) {
                    RectTransform.get_sizeDelta(lVar4,0);
                    DOTweenModuleUI.DOSizeDelta
                              (uVar6,CONCAT44(extraout_var,fVar1 * fVar10),0x3e4ccccd,0,0);
                    if (this.icon != null) {
                      uVar6 = GameObject.get_transform(this.icon,0);
                      ShortcutExtensions.DOKill(uVar6,0,0);
                      if (this.icon != null) {
                        lVar4 = GameObject.get_transform(this.icon,0);
                        puVar7 = (uint64 *)Vector3.get_one(&local_78,0);
                        if (lVar4 != null) {
                          local_90 = *(uint32 *)(puVar7 + 1);
                          local_98 = *puVar7;
                          Transform.set_localScale(lVar4,&local_98,0);
                          if (this.icon != null) {
                            uVar6 = GameObject.get_transform(this.icon,0);
                            ShortcutExtensions.DOLocalMoveX
                                      (uVar6,(fVar10 - 0.5) * this.barWidth,0x3e4ccccd,0,0);
                            if (this.icon != null) {
                              uVar6 = GameObject.get_transform(this.icon,0);
                              uVar6 = ShortcutExtensions.DOScale(uVar6,0x3fc00000,0x3dcccccd,0);
                              TweenSettingsExtensions.SetLoops(uVar6,2,1,DAT_181d98060);
                              return;
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
              else if (lVar4 != null) {
                lVar4 = GameObject.GetComponent(lVar4,DAT_181da0b98);
                fVar1 = this.barWidth;
                if ((this.greenBar != null) &&
                   (lVar5 = GameObject.GetComponent(this.greenBar,DAT_181da0b98),
                   lVar5 != null)) {
                  local_98 = RectTransform.get_sizeDelta(lVar5,0);
                  if (lVar4 != null) {
                    RectTransform.set_sizeDelta(lVar4,fVar1 * fVar10,0);
                    if (this.icon != null) {
                      lVar4 = GameObject.get_transform(this.icon,0);
                      fVar1 = this.barWidth;
                      if ((this.icon != null) &&
                         (lVar5 = GameObject.get_transform(this.icon,0)) != null)
                      {
                        puVar7 = (uint64 *)Transform.get_localPosition(&local_78,lVar5,0);
                        local_88 = *puVar7;
                        local_80 = *(uint32 *)(puVar7 + 1);
                        if ((this.icon != null) &&
                           (lVar5 = GameObject.get_transform(this.icon,0), lVar5 != null
                           )) {
                          puVar7 = (uint64 *)Transform.get_localPosition(&local_98,lVar5,0);
                          local_78 = *puVar7;
                          local_90 = *(uint32 *)(puVar7 + 1);
                          local_98 = CONCAT44(local_88._4_4_,(fVar10 - 0.5) * fVar1);
                          local_70 = local_90;
                          if (lVar4 != null) {
                            local_78 = local_98;
                            Transform.set_localPosition(lVar4,&local_78,0);
                            if (this.icon != null) {
                              lVar4 = GameObject.get_transform(this.icon,0);
                              puVar7 = (uint64 *)Vector3.get_one(&local_88,0);
                              if (lVar4 != null) {
                                local_70 = *(uint32 *)(puVar7 + 1);
                                local_78 = *puVar7;
                                Transform.set_localScale(lVar4,&local_78,0);
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

    // Token : 0x6000004
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
