// ============================================================
// Type  : ExploreTileUnitController
// Token : 0x2000281
// ============================================================

public class ExploreTileUnitController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400143F
    public ExploreTileData exploreTileData;

    // Token: 0x4001440
    public GameObject groundTypeSkeleton;

    // Token: 0x4001441
    private bool been;

    // Token: 0x4001442
    private bool finalTile;

    // Token: 0x4001443
    private SpriteRenderer tileRenderer;

    // Token: 0x4001444
    private bool needRefreshColor;

    // Token: 0x4001445
    private bool needFade;

    // Token: 0x4001446
    public bool needCheckFade;

    // Token: 0x4001447
    public static float fadeAlpha;

    // Token: 0x4001448
    private static Color WhiteCoverColor;

    // Token: 0x4001449
    private static Color BlackCoverColor;

    // Token: 0x400144A
    private static List<string> UseBlackCoverColorBackgroundType;

    // Token: 0x400144B
    private const float ObstacleColorRefreshInterval;

    // Token: 0x400144C
    private SpriteRenderer exploreEventRenderer;

    // Token: 0x400144D
    private float nextObstacleColorTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60014AD
    // RVA   : 0x8EAEB0   Offset: 0x8E9CB0   Length: 0xD7
    private SpriteRenderer get_ExploreEventRenderer()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uVar3 = this.exploreEventRenderer;
        cVar1 = Object.op_Equality(uVar3,0,0);
        if (cVar1) {
          lVar2 = Component.get_transform(this,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"ExploreEvent",0);
            if (lVar2 != null) {
              uVar3 = Component.GetComponent(lVar2,DAT_181e791b8);
              this.exploreEventRenderer = uVar3;
              goto LAB_1808eaf6e;
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        LAB_1808eaf6e:
        return this.exploreEventRenderer;
    }

    // Token : 0x60014AE
    // RVA   : 0x8EB020   Offset: 0x8E9E20   Length: 0x9BC
    public void set_Seen(bool value)
    {
        var pStatics_65d0 = *(int64*)(DAT_181ea65d0 + 184);
        int iVar1;
        long lVar2;
        long lVar3;
        float fVar4;
        bool cVar5;
        long lVar6;
        ulong uVar8;
        uint uVar9;
        uint uVar10;
        uint uVar11;
        uint uVar12;
        ulong in_stack_ffffffffffffff78;
        ulong local_78;
        ulong local_68;
        float local_60;
        uint local_58;
        uint uStack_54;
        uint uStack_50;
        uint32 uStack_4c;
        uint64 local_48;
        uint64 uStack_40;
        if (!value) {
          lVar6 = Component.get_transform(this,0);
          fVar4 = local_60;
          if (lVar6 == null) goto LAB_1808eb9d1;
          lVar6 = Transform.Find(lVar6,"BlackCover",0);
          fVar4 = local_60;
          if (lVar6 == null) goto LAB_1808eb9d1;
          lVar6 = Component.GetComponent(lVar6,DAT_181e791b8);
          lVar2 = BattleController.AttackAreaTypeStartMovePower;
          fVar4 = local_60;
          if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 120)) == null) goto LAB_1808eb9d1;
          if (*(int *)(lVar2 + 16) == 1) {
        LAB_1808eb213:
            lVar2 = pStatics_65d0;
            uVar12 = *(uint32 *)(lVar2 + 20);
            uVar9 = *(uint32 *)(lVar2 + 24);
            uVar10 = *(uint32 *)(lVar2 + 28);
            uVar11 = *(uint32 *)(lVar2 + 32);
          }
          else {
            lVar2 = ExploreTileUnitController.UseBlackCoverColorBackgroundType;
            lVar3 = BattleController.AttackAreaTypeStartMovePower;
            fVar4 = local_60;
            if ((lVar3 == null) || (lVar2 == null)) goto LAB_1808eb9d1;
            cVar5 = FUN_18175e190(lVar2,*(uint64 *)(lVar3 + 88),DAT_181e86470);
            if (!cVar5) {
              lVar2 = pStatics_65d0;
              uVar12 = *(uint32 *)(lVar2 + 4);
              uVar9 = *(uint32 *)(lVar2 + 8);
              uVar10 = *(uint32 *)(lVar2 + 12);
              uVar11 = *(uint32 *)(lVar2 + 16);
            }
            else {
              if (((*(byte *)(DAT_181ea65d0 + 0x133) & 4) == 0) || (*(int *)(DAT_181ea65d0 + 224) != 0))
              goto LAB_1808eb213;
              il2cpp_runtime_class_init(DAT_181ea65d0);
              lVar2 = pStatics_65d0;
              uVar12 = *(uint32 *)(lVar2 + 20);
              uVar9 = *(uint32 *)(lVar2 + 24);
              uVar10 = *(uint32 *)(lVar2 + 28);
              uVar11 = *(uint32 *)(lVar2 + 32);
            }
          }
          fVar4 = local_60;
          if (lVar6 == null) goto LAB_1808eb9d1;
          local_48 = CONCAT44(uVar9,uVar12);
          uStack_40 = CONCAT44(uVar11,uVar10);
          SpriteRenderer.set_color(lVar6,&local_48,0);
          lVar6 = Component.get_transform(this,0);
          fVar4 = local_60;
          if (lVar6 == null) goto LAB_1808eb9d1;
          lVar6 = Transform.Find(lVar6,"BlackCover",0);
          puVar7 = (uint64 *)Vector3.get_one(&local_48,0);
          local_68 = *puVar7;
          local_60 = *(float *)(puVar7 + 1) * 0.55;
          local_78 = CONCAT44((float)((uint64)local_68 >> 32) * 0.55,(float)local_68 * 0.55);
          fVar4 = *(float *)(puVar7 + 1);
          if (lVar6 == null) goto LAB_1808eb9d1;
          local_68 = local_78;
          Transform.set_localScale(lVar6,&local_68,0);
          uVar8 = this.groundTypeSkeleton;
          cVar5 = Object.op_Inequality(uVar8,0,0);
          if (cVar5) {
            fVar4 = local_60;
            if (this.groundTypeSkeleton == null) goto LAB_1808eb9d1;
            lVar6 = GameObject.GetComponent(this.groundTypeSkeleton,DAT_181e56598);
            fVar4 = local_60;
            if (lVar6 == null) goto LAB_1808eb9d1;
            lVar6 = SkeletonRenderer.get_Skeleton(lVar6,0);
            fVar4 = local_60;
            if (lVar6 == null) goto LAB_1808eb9d1;
            *(uint32 *)(lVar6 + 108) = 0;
          }
        }
        else {
          fVar4 = local_60;
          if (this.exploreTileData == null) goto LAB_1808eb9d1;
          if (!this.exploreTileData.seen) {
            ExploreTileUnitController.CheckNeedFade(this,0,0);
            fVar4 = local_60;
            if (this.exploreTileData == null) goto LAB_1808eb9d1;
            if (0 < this.exploreTileData.row) {
              lVar6 = FUN_1802104c0(0);
              fVar4 = local_60;
              if ((((lVar6 == null) || (*(int64 *)(lVar6 + 120) == 0)) ||
                  (lVar2 = this.exploreTileData) == null) ||
                 (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 120) + 40)) == null)
              goto LAB_1808eb9d1;
              lVar6 = FUN_1800540b0(lVar6,(int64)*(int *)(lVar2 + 36),
                                    (int64)*(int *)(lVar2 + 32) + -1);
              fVar4 = local_60;
              if (lVar6 == null) goto LAB_1808eb9d1;
              if (*(char *)(lVar6 + 88) != false) {
                lVar6 = FUN_1802104c0(0);
                fVar4 = local_60;
                if (((lVar6 == null) || (lVar2 = this.exploreTileData) == null) ||
                   (*(int64 *)(lVar6 + 128) == 0)) goto LAB_1808eb9d1;
                lVar6 = FUN_1800540b0(*(int64 *)(lVar6 + 128),(int64)*(int *)(lVar2 + 36),
                                      (int64)*(int *)(lVar2 + 32) + -1);
                fVar4 = local_60;
                if (lVar6 == null) goto LAB_1808eb9d1;
                lVar6 = GameObject.GetComponent(lVar6,DAT_181e54640);
                fVar4 = local_60;
                if (lVar6 == null) goto LAB_1808eb9d1;
                *(uint8 *)(lVar6 + 58) = 1;
              }
            }
            lVar6 = Component.get_transform(this,0);
            fVar4 = local_60;
            if (lVar6 == null) goto LAB_1808eb9d1;
            lVar6 = Transform.Find(lVar6,"BlackCover",0);
            fVar4 = local_60;
            if (lVar6 == null) goto LAB_1808eb9d1;
            uVar8 = Component.GetComponent(lVar6,DAT_181e791b8);
            uVar8 = DOTweenModuleSprite.DOFade(uVar8,0,0x3f000000,0);
            TweenSettingsExtensions.SetUpdate(uVar8,1,DAT_181ea5848);
            lVar6 = Component.get_transform(this,0);
            fVar4 = local_60;
            if (lVar6 == null) goto LAB_1808eb9d1;
            uVar8 = Transform.Find(lVar6,"BlackCover",0);
            uVar12 = 0x3f800000;
            uVar8 = ShortcutExtensions.DOScale(uVar8,0x3f800000,0x3f000000,0);
            TweenSettingsExtensions.SetUpdate(uVar8,1,DAT_181ea59e0);
            uVar8 = this.groundTypeSkeleton;
            cVar5 = Object.op_Inequality(uVar8,0,0);
            if (cVar5) {
              fVar4 = local_60;
              if (this.groundTypeSkeleton == null) goto LAB_1808eb9d1;
              uVar8 = GameObject.GetComponent(this.groundTypeSkeleton,DAT_181e56598);
              in_stack_ffffffffffffff78 = 0;
              GlobalData.DoTweenSkeletonAlpha(uVar8,0,0x3f800000,0x3f000000,0);
            }
            fVar4 = local_60;
            if (this.exploreTileData == null) goto LAB_1808eb9d1;
            iVar1 = this.exploreTileData.wallType;
            if (iVar1 == 1) {
              lVar6 = Component.get_transform(this,0);
              if (lVar6 == null) {
        LAB_1808eb9d7:
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
              lVar6 = Transform.Find(lVar6,"Wall",0);
              if (lVar6 == null) goto LAB_1808eb9d7;
              lVar6 = Component.GetComponent(lVar6,DAT_181e791b8);
              local_48 = 0;
              uStack_40 = 0;
              FUN_1807282e0(&local_48,0x3f800000,0x3f800000,0x3f800000,
                            in_stack_ffffffffffffff78 & 0xffffffff00000000,0);
              if (lVar6 == null) goto LAB_1808eb9d7;
              local_58 = (uint32)local_48;
              uStack_54 = local_48._4_4_;
              uStack_50 = (uint32)uStack_40;
              uStack_4c = uStack_40._4_4_;
              SpriteRenderer.set_color(lVar6,&local_58,0);
              lVar6 = Component.get_transform(this,0);
              if (lVar6 == null) goto LAB_1808eb9d7;
              lVar6 = Transform.Find(lVar6,"Wall",0);
              if (lVar6 == null) goto LAB_1808eb9d7;
              uVar8 = Component.GetComponent(lVar6,DAT_181e791b8);
              if (this.needFade) {
                uVar12 = **(uint32 **)(DAT_181ea65d0 + 184);
              }
              uVar8 = DOTweenModuleSprite.DOFade(uVar8,uVar12,0x3f000000,0);
              TweenSettingsExtensions.SetUpdate(uVar8,1,DAT_181ea5848);
            }
            else if (iVar1 == 2) {
              lVar6 = Component.get_transform(this,0);
              fVar4 = local_60;
              if (lVar6 == null) goto LAB_1808eb9d1;
              lVar6 = Transform.Find(lVar6,"Door",0);
              fVar4 = local_60;
              if (lVar6 == null) goto LAB_1808eb9d1;
              uVar8 = Component.GetComponent(lVar6,DAT_181e78938);
              if (this.needFade) {
                uVar12 = **(uint32 **)(DAT_181ea65d0 + 184);
              }
              GlobalData.DoTweenSkeletonAlpha(uVar8,0,uVar12,0x3f000000,0);
            }
          }
        }
        fVar4 = local_60;
        if (this.exploreTileData != null) {
          this.exploreTileData.seen = value;
          this.needRefreshColor = 1;
          lVar6 = BattleController.AttackAreaTypeStartMovePower;
          fVar4 = local_60;
          if (lVar6 != null) {
            *(uint8 *)(lVar6 + 0x108) = 1;
            return;
          }
        }
        LAB_1808eb9d1:
        local_60 = fVar4;
    }

    // Token : 0x60014AF
    // RVA   : 0x8EAFC0   Offset: 0x8E9DC0   Length: 0x1B
    public bool get_Seen()
    {
        if (this.exploreTileData != null) {
          return this.exploreTileData.seen;
        }
    }

    // Token : 0x60014B0
    // RVA   : 0x8EAFE0   Offset: 0x8E9DE0   Length: 0x8
    public void set_Been(bool value)
    {
        this.been = value;
        this.needRefreshColor = 1;
    }

    // Token : 0x60014B1
    // RVA   : 0x8EAEA0   Offset: 0x8E9CA0   Length: 0x5
    public bool get_Been()
    {
        uint8 FUN_1808eaea0(int64 this)
        {
        return this.been;
    }

    // Token : 0x60014B2
    // RVA   : 0x8EB000   Offset: 0x8E9E00   Length: 0x1E
    public void set_MoveAble(bool value)
    {
        if (this.exploreTileData != null) {
          this.exploreTileData.moveAble = value;
          this.needRefreshColor = 1;
          return;
        }
    }

    // Token : 0x60014B3
    // RVA   : 0x8EAFA0   Offset: 0x8E9DA0   Length: 0x1B
    public bool get_MoveAble()
    {
        if (this.exploreTileData != null) {
          return this.exploreTileData.moveAble;
        }
    }

    // Token : 0x60014B4
    // RVA   : 0x8EAFF0   Offset: 0x8E9DF0   Length: 0x8
    public void set_FinalTile(bool value)
    {
        this.finalTile = value;
        this.needRefreshColor = 1;
    }

    // Token : 0x60014B5
    // RVA   : 0x8EAF90   Offset: 0x8E9D90   Length: 0x5
    public bool get_FinalTile()
    {
        uint8 FUN_1808eaf90(int64 this)
        {
        return this.finalTile;
    }

    // Token : 0x60014B6
    // RVA   : 0x8E9580   Offset: 0x8E8380   Length: 0x876
    public void CheckNeedFade(bool anim)
    {
        int iVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        bool cVar5;
        bool cVar6;
        long lVar7;
        ulong uVar8;
        long lVar9;
        uint uVar10;
        uint uVar11;
        cVar5 = false;
        if (this.exploreTileData == null) throw; // [null/range check failed]
        iVar1 = this.exploreTileData.row;
        lVar7 = BattleController.AttackAreaTypeStartMovePower;
        if ((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 120)) == null) throw; // [null/range check failed]
        if (iVar1 < *(int *)(lVar7 + 28) + -1) {
          lVar7 = BattleController.AttackAreaTypeStartMovePower;
          if ((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 120)) == null) throw; // [null/range check failed]
          lVar7 = *(int64 *)(lVar7 + 40);
          lVar2 = this.exploreTileData;
          if ((lVar2 == null) || (lVar7 == null)) throw; // [null/range check failed]
          lVar9 = (int64)lVar2.row + 1;
          if (**(uint32 **)(lVar7 + 16) <= lVar2.column) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar8,0);
          }
          lVar3 = *(int64 *)(*(uint32 **)(lVar7 + 16) + 4);
          if ((uint32)lVar3 <= (uint32)lVar9) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1801e02d0(uVar8,0);
          }
          lVar7 = *(int64 *)(lVar7 + 32 + ((int)lVar2.column * lVar3 + lVar9) * 8);
          if (lVar7 == null) throw; // [null/range check failed]
          if (*(char *)(lVar7 + 88) != false) {
            lVar7 = FUN_1802104c0(0);
            if ((lVar7 == null) || (*(int64 *)(lVar7 + 120) == 0)) throw; // [null/range check failed]
            lVar2 = this.exploreTileData;
            lVar7 = *(int64 *)(*(int64 *)(lVar7 + 120) + 40);
            if ((lVar2 == null) || (lVar7 == null)) throw; // [null/range check failed]
            lVar9 = (int64)lVar2.row + 1;
            if (**(uint32 **)(lVar7 + 16) <= lVar2.column) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar8,0);
            }
            lVar3 = *(int64 *)(*(uint32 **)(lVar7 + 16) + 4);
            if ((uint32)lVar3 <= (uint32)lVar9) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar8,0);
            }
            lVar7 = *(int64 *)(lVar7 + 32 + ((int)lVar2.column * lVar3 + lVar9) * 8);
            if (lVar7 == null) throw; // [null/range check failed]
            if (*(int *)(lVar7 + 56) == 0) {
        LAB_1808e98a7:
              lVar7 = FUN_1802104c0(0);
              if ((lVar7 == null) || (*(int64 *)(lVar7 + 120) == 0)) throw; // [null/range check failed]
              lVar2 = this.exploreTileData;
              lVar7 = *(int64 *)(*(int64 *)(lVar7 + 120) + 40);
              if ((lVar2 == null) || (lVar7 == null)) throw; // [null/range check failed]
              lVar9 = (int64)lVar2.row + 1;
              if (**(uint32 **)(lVar7 + 16) <= lVar2.column) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar8,0);
              }
              lVar3 = *(int64 *)(*(uint32 **)(lVar7 + 16) + 4);
              if ((uint32)lVar3 <= (uint32)lVar9) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar8,0);
              }
              lVar7 = *(int64 *)(lVar7 + 32 + ((int)lVar2.column * lVar3 + lVar9) * 8);
              if (lVar7 == null) throw; // [null/range check failed]
              if (*(int64 *)(lVar7 + 80) == 0) {
                lVar7 = FUN_1802104c0(0);
                if (lVar7 == null) throw; // [null/range check failed]
                lVar2 = this.exploreTileData;
                if ((lVar2 == null) || (*(int64 *)(lVar7 + 128) == 0)) throw; // [null/range check failed]
                uVar8 = FUN_1800540b0(*(int64 *)(lVar7 + 128),(int64)lVar2.column,
                                      (int64)(lVar2.row + 1));
                lVar7 = FUN_1802104c0(0);
                if (lVar7 == null) throw; // [null/range check failed]
                uVar4 = *(uint64 *)(lVar7 + 144);
                cVar5 = Object.op_Equality(uVar8,uVar4,0);
                goto LAB_1808e99ed;
              }
            }
            else {
              lVar7 = FUN_1802104c0(0);
              if ((lVar7 == null) || (*(int64 *)(lVar7 + 120) == 0)) throw; // [null/range check failed]
              lVar2 = this.exploreTileData;
              lVar7 = *(int64 *)(*(int64 *)(lVar7 + 120) + 40);
              if ((lVar2 == null) || (lVar7 == null)) throw; // [null/range check failed]
              lVar7 = FUN_1800540b0(lVar7,(int64)lVar2.column,
                                    (int64)lVar2.row + 1);
              if (lVar7 == null) throw; // [null/range check failed]
              if (*(char *)(lVar7 + 53) != false) goto LAB_1808e98a7;
            }
            cVar5 = true;
          }
        }
        LAB_1808e99ed:
        if ((!anim) || (cVar5 == this.needFade)) goto LAB_1808e9d78;
        if (this.exploreTileData != null) {
          iVar1 = this.exploreTileData.wallType;
          if (iVar1 == 1) {
            lVar7 = Component.get_transform(this,0);
            if (lVar7 != null) {
              uVar8 = Transform.Find(lVar7,"Wall",0);
              cVar6 = Object.op_Inequality(uVar8,0,0);
              if (!cVar6) goto LAB_1808e9d78;
              lVar7 = Component.get_transform(this,0);
              if (lVar7 != null) {
                lVar7 = Transform.Find(lVar7,"Wall",0);
                if (lVar7 != null) {
                  uVar8 = Component.GetComponent(lVar7,DAT_181e791b8);
                  if (!cVar5) {
                    uVar10 = 0x3f800000;
                  }
                  else {
                    uVar10 = **(uint32 **)(DAT_181ea65d0 + 184);
                  }
                  uVar8 = DOTweenModuleSprite.DOFade(uVar8,uVar10,0x3f000000,0);
                  TweenSettingsExtensions.SetUpdate(uVar8,1,DAT_181ea5848);
                  goto LAB_1808e9d78;
                }
              }
            }
          }
          else {
            if (iVar1 != 2) {
        LAB_1808e9d78:
              this.needFade = cVar5;
              return;
            }
            lVar7 = Component.get_transform(this,0);
            if (lVar7 != null) {
              uVar8 = Transform.Find(lVar7,"Door",0);
              cVar6 = Object.op_Inequality(uVar8,0,0);
              if (!cVar6) goto LAB_1808e9d78;
              lVar7 = Component.get_transform(this,0);
              if (lVar7 != null) {
                lVar7 = Transform.Find(lVar7,"Door",0);
                if (lVar7 != null) {
                  uVar8 = Component.GetComponent(lVar7,DAT_181e78938);
                  cVar6 = Object.op_Inequality(uVar8,0,0);
                  if (!cVar6) goto LAB_1808e9d78;
                  lVar7 = Component.get_transform(this,0);
                  if (lVar7 != null) {
                    lVar7 = Transform.Find(lVar7,"Door",0);
                    if (lVar7 != null) {
                      lVar7 = Component.GetComponent(lVar7,DAT_181e78938);
                      if (lVar7 != null) {
                        if (*(int64 *)(lVar7 + 192) == 0) goto LAB_1808e9d78;
                        lVar7 = Component.get_transform(this,0);
                        if (lVar7 != null) {
                          lVar7 = Transform.Find(lVar7,"Door",0);
                          if (lVar7 != null) {
                            uVar8 = Component.GetComponent(lVar7,DAT_181e78938);
                            lVar7 = Component.get_transform(this,0);
                            if (lVar7 != null) {
                              lVar7 = Transform.Find(lVar7,"Door",0);
                              if (lVar7 != null) {
                                lVar7 = Component.GetComponent(lVar7,DAT_181e78938);
                                if ((lVar7 != null) && (*(int64 *)(lVar7 + 192) != 0)) {
                                  uVar10 = *(uint32 *)(*(int64 *)(lVar7 + 192) + 108);
                                  if (!cVar5) {
                                    uVar11 = 0x3f800000;
                                  }
                                  else {
                                    uVar11 = **(uint32 **)(DAT_181ea65d0 + 184);
                                  }
                                  GlobalData.DoTweenSkeletonAlpha(uVar8,uVar10,uVar11,0x3f000000,0);
                                  goto LAB_1808e9d78;
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

    // Token : 0x60014B7
    // RVA   : 0x8EA0F0   Offset: 0x8E8EF0   Length: 0x8EF
    public void RefreshColor()
    {
        var pStatics = *(int64*)(DAT_181e90420 + 184);
        float fVar1;
        uint uVar2;
        ulong uVar3;
        int iVar4;
        float fVar5;
        long lVar6;
        long lVar9;
        ulong local_68;
        ulong local_58;
        float local_50;
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        fVar5 = local_50;
        if (this.exploreTileData == null) goto LAB_1808ea9da;
        if (!this.exploreTileData.eventHappen) {
          lVar6 = Component.get_transform(this,0);
          fVar5 = local_50;
          if (lVar6 == null) goto LAB_1808ea9da;
          lVar6 = Transform.Find(lVar6,"ExploreEvent",0);
          puVar7 = (uint64 *)Vector3.get_one(&local_38,0);
          local_58 = *puVar7;
          local_50 = *(float *)(puVar7 + 1) * 0.6;
          local_68 = CONCAT44((float)((uint64)local_58 >> 32) * 0.6,(float)local_58 * 0.6);
          fVar5 = *(float *)(puVar7 + 1);
          if (lVar6 == null) goto LAB_1808ea9da;
          local_58 = local_68;
          Transform.set_localScale(lVar6,&local_58,0);
          lVar6 = this.exploreTileData;
          fVar5 = local_50;
          if (lVar6 == null) goto LAB_1808ea9da;
          if ((!lVar6.seen) ||
             ((lVar6.exploreTileEventType == null && (lVar6.exploreTileObstacleData == null)))) {
            lVar6 = Component.get_transform(this,0);
            fVar5 = local_50;
            if ((lVar6 == null) ||
               (lVar6 = Transform.Find(lVar6,"ExploreEvent",0), fVar5 = local_50) == null)
            goto LAB_1808ea9da;
            lVar6 = Component.GetComponent(lVar6,DAT_181e791b8);
            puVar8 = (uint32 *)FUN_180af4e90(&local_38,0);
            fVar5 = local_50;
            if (lVar6 == null) goto LAB_1808ea9da;
            local_38 = *puVar8;
            uStack_34 = puVar8[1];
            uStack_30 = puVar8[2];
            uStack_2c = puVar8[3];
            SpriteRenderer.set_color(lVar6,&local_38,0);
          }
          else {
            ExploreTileUnitController.SetObstacleColor(this,0);
          }
        }
        lVar6 = this.exploreTileData;
        fVar5 = local_50;
        if (lVar6 == null) goto LAB_1808ea9da;
        if (!lVar6.moveAble) {
          if ((!lVar6.seen) || (lVar6.eventHappen)) {
        LAB_1808ea4cf:
            lVar6 = Component.get_transform(this,0);
            fVar5 = local_50;
            if ((lVar6 == null) ||
               (lVar6 = Transform.Find(lVar6,"HighLight",0), fVar5 = local_50) == null)
            goto LAB_1808ea9da;
            lVar6 = Component.GetComponent(lVar6,DAT_181e791b8);
            puVar8 = (uint32 *)FUN_180af4e90(&local_38,0);
            goto LAB_1808ea562;
          }
          iVar4 = lVar6.exploreTileEventType;
          if (iVar4 == -1) {
            lVar6 = Component.get_transform(this,0);
            fVar5 = local_50;
            if ((lVar6 == null) ||
               (lVar6 = Transform.Find(lVar6,"HighLight",0), fVar5 = local_50) == null)
            goto LAB_1808ea9da;
            lVar6 = Component.GetComponent(lVar6,DAT_181e791b8);
            puVar8 = (uint32 *)Color.get_red(&local_38,0);
            goto LAB_1808ea562;
          }
          if (iVar4 == 24) {
            lVar6 = Component.get_transform(this,0);
            fVar5 = local_50;
            if ((lVar6 == null) ||
               (lVar6 = Transform.Find(lVar6,"HighLight",0), fVar5 = local_50) == null)
            goto LAB_1808ea9da;
            lVar6 = Component.GetComponent(lVar6,DAT_181e791b8);
            lVar9 = FUN_180210740(0);
            fVar5 = local_50;
            if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) goto LAB_1808ea9da;
            if (*(uint32 *)(lVar9 + 24) < 5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(*(int64 *)(lVar9 + 16) + 64);
          }
          else {
            if (iVar4 != 25) goto LAB_1808ea4cf;
            lVar6 = Component.get_transform(this,0);
            fVar5 = local_50;
            if ((lVar6 == null) ||
               (lVar6 = Transform.Find(lVar6,"HighLight",0), fVar5 = local_50) == null)
            goto LAB_1808ea9da;
            lVar6 = Component.GetComponent(lVar6,DAT_181e791b8);
            lVar9 = FUN_180210740(0);
            fVar5 = local_50;
            if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) goto LAB_1808ea9da;
            if (*(uint32 *)(lVar9 + 24) < 4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(*(int64 *)(lVar9 + 16) + 56);
          }
          fVar5 = local_50;
          if ((lVar9 == null) || (lVar6 == null)) goto LAB_1808ea9da;
          local_38 = *(uint32 *)(lVar9 + 24);
          uStack_34 = *(uint32 *)(lVar9 + 28);
          uStack_30 = *(uint32 *)(lVar9 + 32);
          uStack_2c = *(uint32 *)(lVar9 + 36);
        }
        else {
          lVar6 = Component.get_transform(this,0);
          fVar5 = local_50;
          if ((lVar6 == null) ||
             (lVar6 = Transform.Find(lVar6,"HighLight",0), fVar5 = local_50) == null)
          goto LAB_1808ea9da;
          lVar6 = Component.GetComponent(lVar6,DAT_181e791b8);
          puVar8 = (uint32 *)Color.get_green(&local_38,0);
        LAB_1808ea562:
          fVar5 = local_50;
          if (lVar6 == null) goto LAB_1808ea9da;
          local_38 = *puVar8;
          uStack_34 = puVar8[1];
          uStack_30 = puVar8[2];
          uStack_2c = puVar8[3];
        }
        SpriteRenderer.set_color(lVar6,&local_38,0);
        lVar6 = this.exploreTileData;
        fVar5 = local_50;
        if (lVar6 == null) goto LAB_1808ea9da;
        if ((lVar6.wallType == null) || (!lVar6.seen)) {
          lVar6 = Component.get_transform(this,0);
          fVar5 = local_50;
          if ((lVar6 == null) ||
             ((lVar6 = Transform.Find(lVar6,"Wall",0), fVar5 = local_50, lVar6 == null ||
              (lVar6 = Component.get_gameObject(lVar6,0), fVar5 = local_50) == null)))
          goto LAB_1808ea9da;
          GameObject.SetActive(lVar6,0,0);
        }
        else {
          if (lVar6.wallType != 1) {
            lVar6 = Component.get_transform(this,0);
            fVar5 = local_50;
            if (((lVar6 != null) &&
                (lVar6 = Transform.Find(lVar6,"Door",0), fVar5 = local_50) != null) &&
               (lVar6 = Component.get_gameObject(lVar6,0), fVar5 = local_50) != null) {
              GameObject.SetActive(lVar6,1,0);
              lVar6 = Component.get_transform(this,0);
              fVar5 = local_50;
              if (lVar6 != null) {
                lVar6 = Transform.Find(lVar6,"Door",0);
                lVar9 = Component.get_transform(this,0);
                fVar5 = local_50;
                if ((lVar9 != null) &&
                   (lVar9 = Transform.Find(lVar9,"Door",0), fVar5 = local_50) != null) {
                  puVar7 = (uint64 *)Transform.get_localPosition(&local_38,lVar9,0);
                  uVar3 = *puVar7;
                  fVar5 = *(float *)(puVar7 + 1);
                  fVar1 = *(float *)(pStatics + 36);
                  local_58 = uVar3;
                  local_50 = fVar5;
                  puVar7 = (uint64 *)GlobalData.SetZ(&local_38,&local_58,fVar1 + 0.001,0);
                  fVar5 = local_50;
                  if (lVar6 != null) {
                    local_58 = *puVar7;
                    local_50 = *(float *)(puVar7 + 1);
                    Transform.set_localPosition(lVar6,&local_58,0);
                    lVar6 = Component.get_transform(this,0);
                    fVar5 = local_50;
                    if (((lVar6 != null) &&
                        (lVar6 = Transform.Find(lVar6,"Wall",0), fVar5 = local_50) != null) &&
                       (lVar6 = Component.get_gameObject(lVar6,0), fVar5 = local_50) != null) {
                      GameObject.SetActive(lVar6,0,0);
                      fVar5 = local_50;
                      if (this.exploreTileData != null) {
                        if (this.exploreTileData.doorOpen) {
                          return;
                        }
                        lVar6 = Component.get_transform(this,0);
                        fVar5 = local_50;
                        if (((lVar6 != null) &&
                            (lVar6 = Transform.Find(lVar6,"Door",0), fVar5 = local_50) != null
                            ) && ((lVar6 = Component.GetComponent(lVar6,DAT_181e78938), fVar5 = local_50,
                                  lVar6 != null &&
                                  (lVar6 = SkeletonAnimation.get_AnimationState(lVar6,0),
                                  fVar5 = local_50, lVar6 != null)))) {
                          AnimationState.SetEmptyAnimation(lVar6,0,0,0);
                          return;
                        }
                      }
                    }
                  }
                }
              }
            }
            goto LAB_1808ea9da;
          }
          lVar6 = Component.get_transform(this,0);
          fVar5 = local_50;
          if (((lVar6 == null) ||
              (lVar6 = Transform.Find(lVar6,"Wall",0), fVar5 = local_50) == null) ||
             (lVar6 = Component.get_gameObject(lVar6,0), fVar5 = local_50) == null)
          goto LAB_1808ea9da;
          GameObject.SetActive(lVar6,1,0);
          lVar6 = Component.get_transform(this,0);
          fVar5 = local_50;
          if (lVar6 == null) goto LAB_1808ea9da;
          lVar6 = Transform.Find(lVar6,"Wall",0);
          lVar9 = Component.get_transform(this,0);
          fVar5 = local_50;
          if ((lVar9 == null) ||
             (lVar9 = Transform.Find(lVar9,"Wall",0), fVar5 = local_50) == null)
          goto LAB_1808ea9da;
          puVar7 = (uint64 *)Transform.get_localPosition(&local_38,lVar9,0);
          uVar3 = *puVar7;
          fVar5 = *(float *)(puVar7 + 1);
          uVar2 = *(uint32 *)(pStatics + 36);
          local_58 = uVar3;
          local_50 = fVar5;
          puVar7 = (uint64 *)GlobalData.SetZ(&local_38,&local_58,uVar2,0);
          fVar5 = local_50;
          if (lVar6 == null) goto LAB_1808ea9da;
          local_58 = *puVar7;
          local_50 = *(float *)(puVar7 + 1);
          Transform.set_localPosition(lVar6,&local_58,0);
        }
        lVar6 = Component.get_transform(this,0);
        fVar5 = local_50;
        if (((lVar6 != null) &&
            (lVar6 = Transform.Find(lVar6,"Door",0), fVar5 = local_50) != null) &&
           (lVar6 = Component.get_gameObject(lVar6,0), fVar5 = local_50) != null) {
          GameObject.SetActive(lVar6,0,0);
          return;
        }
        LAB_1808ea9da:
        local_50 = fVar5;
    }

    // Token : 0x60014B8
    // RVA   : 0x8EA9E0   Offset: 0x8E97E0   Length: 0x2A0
    public void SetObstacleColor()
    {
        long lVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        uVar4 = this.exploreEventRenderer;
        cVar2 = Object.op_Equality(uVar4,0,0);
        if (cVar2) {
          lVar3 = Component.get_transform(this,0);
          if (lVar3 == null) throw; // [null/range check failed]
          lVar3 = Transform.Find(lVar3,"ExploreEvent",0);
          if (lVar3 == null) throw; // [null/range check failed]
          uVar4 = Component.GetComponent(lVar3,DAT_181e791b8);
          this.exploreEventRenderer = uVar4;
        }
        lVar3 = this.exploreEventRenderer;
        lVar1 = BattleController.AttackAreaTypeStartMovePower;
        if (lVar1 == null) throw; // [null/range check failed]
        cVar2 = ExploreController.PlayerCanPassObstacle(lVar1,this.exploreTileData,0,0);
        if (!cVar2) {
          lVar1 = BattleController.AttackAreaTypeStartMovePower;
          if (lVar1 == null) throw; // [null/range check failed]
          cVar2 = ExploreController.PlayerCanPassObstacle(lVar1,this.exploreTileData,1,0);
          if (!cVar2) {
            puVar5 = (uint32 *)Color.get_red(&local_18,0);
            goto LAB_1808eac4d;
          }
          lVar1 = *(int64 *)(DAT_181e538e8 + 184);
          local_18 = *(uint32 *)(lVar1 + 0x328);
          uStack_14 = *(uint32 *)(lVar1 + 0x32c);
          uStack_10 = *(uint32 *)(lVar1 + 0x330);
          uStack_c = *(uint32 *)(lVar1 + 0x334);
        }
        else {
          puVar5 = (uint32 *)FUN_180f24d00(&local_18,0);
        LAB_1808eac4d:
          local_18 = *puVar5;
          uStack_14 = puVar5[1];
          uStack_10 = puVar5[2];
          uStack_c = puVar5[3];
        }
        if (lVar3 != null) {
          SpriteRenderer.set_color(lVar3,&local_18,0);
          return;
        }
    }

    // Token : 0x60014B9
    // RVA   : 0x8E9540   Offset: 0x8E8340   Length: 0x3B
    private void Awake()
    {
        float fVar1;
        float fVar2;
        fVar1 = (float)Time.get_unscaledTime(0);
        fVar2 = (float)Random.get_value(0);
        this.nextObstacleColorTime = fVar2 * 0.3 + fVar1;
    }

    // Token : 0x60014BA
    // RVA   : 0x8EAC90   Offset: 0x8E9A90   Length: 0x7E
    private void Update()
    {
        long lVar1;
        float fVar2;
        lVar1 = this.exploreTileData;
        if (lVar1 == null) {
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        if ((lVar1.seen) && (lVar1.exploreTileObstacleData != null)) {
          fVar2 = (float)Time.get_unscaledTime(0);
          if (this.nextObstacleColorTime <= fVar2) {
            this.nextObstacleColorTime = fVar2 + 0.3;
            ExploreTileUnitController.SetObstacleColor(this,0);
          }
        }
        if (this.needRefreshColor) {
          this.needRefreshColor = 0;
          ExploreTileUnitController.RefreshColor(this,0);
        }
        if (this.needCheckFade) {
          this.needCheckFade = 0;
          ExploreTileUnitController.CheckNeedFade(this,1,0);
          return;
        }
    }

    // Token : 0x60014BB
    // RVA   : 0x8E9E00   Offset: 0x8E8C00   Length: 0xCC
    public void OnClick()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181ea6328 + 184) + 8);
        uVar2 = Component.get_gameObject(this,0);
        if (lVar1 != null) {
          ExploreController.ExploreTileClicked(lVar1,uVar2,0);
          return;
        }
    }

    // Token : 0x60014BC
    // RVA   : 0x8E9FA0   Offset: 0x8E8DA0   Length: 0x82
    public void OnHover(bool isOver)
    {
        long lVar1;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        lVar1 = Component.GetComponent(this,DAT_181e791b8);
        if (!isOver) {
          puVar2 = (uint32 *)FUN_180f24d00();
        }
        else {
          puVar2 = (uint32 *)FUN_180f24b80(&local_18,0);
        }
        if (lVar1 != null) {
          local_18 = *puVar2;
          uStack_14 = puVar2[1];
          uStack_10 = puVar2[2];
          uStack_c = puVar2[3];
          SpriteRenderer.set_color(lVar1,&local_18,0);
          return;
        }
    }

    // Token : 0x60014BD
    // RVA   : 0x8E9ED0   Offset: 0x8E8CD0   Length: 0xC1
    public void OnDrag(Vector2 delta)
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181ea6328 + 184) + 8);
        if (lVar1 != null) {
          ExploreController.OnDrag(lVar1,delta,0);
          return;
        }
    }

    // Token : 0x60014BE
    // RVA   : 0x8EA030   Offset: 0x8E8E30   Length: 0xBD
    public void OnScroll(float delta)
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181ea6328 + 184) + 8);
        if (lVar1 != null) {
          ExploreController.OnScroll(lVar1,delta,0);
          return;
        }
    }

    // Token : 0x60014BF
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

    // Token : 0x60014C0
    // RVA   : 0x8EAD10   Offset: 0x8E9B10   Length: 0x181
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181ea65d0 + 184);
        long lVar1;
        ulong local_38;
        ulong uStack_30;
        ulong local_28;
        ulong uStack_20;
        **(uint32 **)(DAT_181ea65d0 + 184) = 0x3f19999a;
        local_38 = 0;
        uStack_30 = 0;
        FUN_1807282e0(&local_38,0x3f800000,0x3f800000,0x3f800000,0x3f4ccccd,0);
        lVar1 = pStatics;
        *(uint32 *)(lVar1 + 4) = (uint32)local_38;
        *(uint32 *)(lVar1 + 8) = local_38._4_4_;
        *(uint32 *)(lVar1 + 12) = (uint32)uStack_30;
        *(uint32 *)(lVar1 + 16) = uStack_30._4_4_;
        local_28 = 0;
        uStack_20 = 0;
        FUN_1807282e0(&local_28,0x3e99999a,0x3e99999a,0x3e99999a,0x3f4ccccd,0);
        lVar1 = pStatics;
        *(uint32 *)(lVar1 + 20) = (uint32)local_28;
        *(uint32 *)(lVar1 + 24) = local_28._4_4_;
        *(uint32 *)(lVar1 + 28) = (uint32)uStack_20;
        *(uint32 *)(lVar1 + 32) = uStack_20._4_4_;
        lVar1 = il2cpp_internal(DAT_181e77728);
        FUN_1810f3480(lVar1,DAT_181e861f0);
        if (lVar1 != null) {
          FUN_18175de30(lVar1,"2",DAT_181e86370);
          FUN_18175de30(lVar1,"6",DAT_181e86370);
          ExploreTileUnitController.UseBlackCoverColorBackgroundType = lVar1;
          return;
        }
    }

}
