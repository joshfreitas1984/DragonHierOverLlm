// ============================================================
// Type  : ExploreTileUnitController
// Token : 0x200027A
// ============================================================

public class ExploreTileUnitController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001401
    public ExploreTileData exploreTileData;

    // Token: 0x4001402
    public GameObject groundTypeSkeleton;

    // Token: 0x4001403
    private bool been;

    // Token: 0x4001404
    private bool finalTile;

    // Token: 0x4001405
    private SpriteRenderer tileRenderer;

    // Token: 0x4001406
    private bool needRefreshColor;

    // Token: 0x4001407
    private bool needFade;

    // Token: 0x4001408
    public bool needCheckFade;

    // Token: 0x4001409
    public static float fadeAlpha;

    // Token: 0x400140A
    private static Color WhiteCoverColor;

    // Token: 0x400140B
    private static Color BlackCoverColor;

    // Token: 0x400140C
    private static List<string> UseBlackCoverColorBackgroundType;

    // Token: 0x400140D
    private const float ObstacleColorRefreshInterval;

    // Token: 0x400140E
    private SpriteRenderer exploreEventRenderer;

    // Token: 0x400140F
    private float nextObstacleColorTime;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001445
    // RVA   : 0xB28E30   Offset: 0xB28230   Length: 0xD7
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
              uVar3 = Component.GetComponent(lVar2,DAT_181d95de0);
              this.exploreEventRenderer = uVar3;
              goto LAB_180b28eee;
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        LAB_180b28eee:
        return this.exploreEventRenderer;
    }

    // Token : 0x6001446
    // RVA   : 0xB28FA0   Offset: 0xB283A0   Length: 0x9BC
    public void set_Seen(bool value)
    {
        var pStatics_5e30 = *(int64*)(DAT_181dc5e30 + 184);
        var pStatics_60d8 = *(int64*)(DAT_181dc60d8 + 184);
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
          if (lVar6 == null) goto LAB_180b29951;
          lVar6 = Transform.Find(lVar6,"BlackCover",0);
          fVar4 = local_60;
          if (lVar6 == null) goto LAB_180b29951;
          lVar6 = Component.GetComponent(lVar6,DAT_181d95de0);
          lVar2 = *(int64 *)(pStatics_5e30 + 8);
          fVar4 = local_60;
          if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 120)) == null) goto LAB_180b29951;
          if (*(int *)(lVar2 + 16) == 1) {
        LAB_180b29193:
            lVar2 = pStatics_60d8;
            uVar12 = *(uint32 *)(lVar2 + 20);
            uVar9 = *(uint32 *)(lVar2 + 24);
            uVar10 = *(uint32 *)(lVar2 + 28);
            uVar11 = *(uint32 *)(lVar2 + 32);
          }
          else {
            lVar2 = *(int64 *)(pStatics_60d8 + 40);
            lVar3 = *(int64 *)(pStatics_5e30 + 8);
            fVar4 = local_60;
            if ((lVar3 == null) || (lVar2 == null)) goto LAB_180b29951;
            cVar5 = FUN_18181e400(lVar2,*(uint64 *)(lVar3 + 88),DAT_181da3e58);
            if (!cVar5) {
              lVar2 = pStatics_60d8;
              uVar12 = *(uint32 *)(lVar2 + 4);
              uVar9 = *(uint32 *)(lVar2 + 8);
              uVar10 = *(uint32 *)(lVar2 + 12);
              uVar11 = *(uint32 *)(lVar2 + 16);
            }
            else {
              if (((*(byte *)(DAT_181dc60d8 + 0x133) & 4) == 0) || (*(int *)(DAT_181dc60d8 + 224) != 0))
              goto LAB_180b29193;
              il2cpp_runtime_class_init(DAT_181dc60d8);
              lVar2 = pStatics_60d8;
              uVar12 = *(uint32 *)(lVar2 + 20);
              uVar9 = *(uint32 *)(lVar2 + 24);
              uVar10 = *(uint32 *)(lVar2 + 28);
              uVar11 = *(uint32 *)(lVar2 + 32);
            }
          }
          fVar4 = local_60;
          if (lVar6 == null) goto LAB_180b29951;
          local_48 = CONCAT44(uVar9,uVar12);
          uStack_40 = CONCAT44(uVar11,uVar10);
          SpriteRenderer.set_color(lVar6,&local_48,0);
          lVar6 = Component.get_transform(this,0);
          fVar4 = local_60;
          if (lVar6 == null) goto LAB_180b29951;
          lVar6 = Transform.Find(lVar6,"BlackCover",0);
          puVar7 = (uint64 *)Vector3.get_one(&local_48,0);
          local_68 = *puVar7;
          local_60 = *(float *)(puVar7 + 1) * 0.55;
          local_78 = CONCAT44((float)((uint64)local_68 >> 32) * 0.55,(float)local_68 * 0.55);
          fVar4 = *(float *)(puVar7 + 1);
          if (lVar6 == null) goto LAB_180b29951;
          local_68 = local_78;
          Transform.set_localScale(lVar6,&local_68,0);
          uVar8 = this.groundTypeSkeleton;
          cVar5 = Object.op_Inequality(uVar8,0,0);
          if (cVar5) {
            fVar4 = local_60;
            if (this.groundTypeSkeleton == null) goto LAB_180b29951;
            lVar6 = GameObject.GetComponent(this.groundTypeSkeleton,DAT_181d734d0);
            fVar4 = local_60;
            if (lVar6 == null) goto LAB_180b29951;
            lVar6 = SkeletonRenderer.get_Skeleton(lVar6,0);
            fVar4 = local_60;
            if (lVar6 == null) goto LAB_180b29951;
            *(uint32 *)(lVar6 + 108) = 0;
          }
        }
        else {
          fVar4 = local_60;
          if (this.exploreTileData == null) goto LAB_180b29951;
          if (!this.exploreTileData.seen) {
            ExploreTileUnitController.CheckNeedFade(this,0,0);
            fVar4 = local_60;
            if (this.exploreTileData == null) goto LAB_180b29951;
            if (0 < this.exploreTileData.row) {
              lVar6 = FUN_18046be80(0);
              fVar4 = local_60;
              if ((((lVar6 == null) || (*(int64 *)(lVar6 + 120) == 0)) ||
                  (lVar2 = this.exploreTileData) == null) ||
                 (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 120) + 40)) == null)
              goto LAB_180b29951;
              lVar6 = FUN_180127f90(lVar6,(int64)*(int *)(lVar2 + 36),
                                    (int64)*(int *)(lVar2 + 32) + -1);
              fVar4 = local_60;
              if (lVar6 == null) goto LAB_180b29951;
              if (*(char *)(lVar6 + 88) != false) {
                lVar6 = FUN_18046be80(0);
                fVar4 = local_60;
                if (((lVar6 == null) || (lVar2 = this.exploreTileData) == null) ||
                   (*(int64 *)(lVar6 + 128) == 0)) goto LAB_180b29951;
                lVar6 = FUN_180127f90(*(int64 *)(lVar6 + 128),(int64)*(int *)(lVar2 + 36),
                                      (int64)*(int *)(lVar2 + 32) + -1);
                fVar4 = local_60;
                if (lVar6 == null) goto LAB_180b29951;
                lVar6 = GameObject.GetComponent(lVar6,DAT_181d71578);
                fVar4 = local_60;
                if (lVar6 == null) goto LAB_180b29951;
                *(uint8 *)(lVar6 + 58) = 1;
              }
            }
            lVar6 = Component.get_transform(this,0);
            fVar4 = local_60;
            if (lVar6 == null) goto LAB_180b29951;
            lVar6 = Transform.Find(lVar6,"BlackCover",0);
            fVar4 = local_60;
            if (lVar6 == null) goto LAB_180b29951;
            uVar8 = Component.GetComponent(lVar6,DAT_181d95de0);
            uVar8 = DOTweenModuleSprite.DOFade(uVar8,0,0x3f000000,0);
            TweenSettingsExtensions.SetUpdate(uVar8,1,DAT_181dc1c20);
            lVar6 = Component.get_transform(this,0);
            fVar4 = local_60;
            if (lVar6 == null) goto LAB_180b29951;
            uVar8 = Transform.Find(lVar6,"BlackCover",0);
            uVar12 = 0x3f800000;
            uVar8 = ShortcutExtensions.DOScale(uVar8,0x3f800000,0x3f000000,0);
            TweenSettingsExtensions.SetUpdate(uVar8,1,DAT_181dc1db0);
            uVar8 = this.groundTypeSkeleton;
            cVar5 = Object.op_Inequality(uVar8,0,0);
            if (cVar5) {
              fVar4 = local_60;
              if (this.groundTypeSkeleton == null) goto LAB_180b29951;
              uVar8 = GameObject.GetComponent(this.groundTypeSkeleton,DAT_181d734d0);
              in_stack_ffffffffffffff78 = 0;
              GlobalData.DoTweenSkeletonAlpha(uVar8,0,0x3f800000,0x3f000000,0);
            }
            fVar4 = local_60;
            if (this.exploreTileData == null) goto LAB_180b29951;
            iVar1 = this.exploreTileData.wallType;
            if (iVar1 == 1) {
              lVar6 = Component.get_transform(this,0);
              if (lVar6 == null) {
        LAB_180b29957:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar6 = Transform.Find(lVar6,"Wall",0);
              if (lVar6 == null) goto LAB_180b29957;
              lVar6 = Component.GetComponent(lVar6,DAT_181d95de0);
              local_48 = 0;
              uStack_40 = 0;
              FUN_1809dc910(&local_48,0x3f800000,0x3f800000,0x3f800000,
                            in_stack_ffffffffffffff78 & 0xffffffff00000000,0);
              if (lVar6 == null) goto LAB_180b29957;
              local_58 = (uint32)local_48;
              uStack_54 = local_48._4_4_;
              uStack_50 = (uint32)uStack_40;
              uStack_4c = uStack_40._4_4_;
              SpriteRenderer.set_color(lVar6,&local_58,0);
              lVar6 = Component.get_transform(this,0);
              if (lVar6 == null) goto LAB_180b29957;
              lVar6 = Transform.Find(lVar6,"Wall",0);
              if (lVar6 == null) goto LAB_180b29957;
              uVar8 = Component.GetComponent(lVar6,DAT_181d95de0);
              if (this.needFade) {
                uVar12 = **(uint32 **)(DAT_181dc60d8 + 184);
              }
              uVar8 = DOTweenModuleSprite.DOFade(uVar8,uVar12,0x3f000000,0);
              TweenSettingsExtensions.SetUpdate(uVar8,1,DAT_181dc1c20);
            }
            else if (iVar1 == 2) {
              lVar6 = Component.get_transform(this,0);
              fVar4 = local_60;
              if (lVar6 == null) goto LAB_180b29951;
              lVar6 = Transform.Find(lVar6,"Door",0);
              fVar4 = local_60;
              if (lVar6 == null) goto LAB_180b29951;
              uVar8 = Component.GetComponent(lVar6,DAT_181d955e0);
              if (this.needFade) {
                uVar12 = **(uint32 **)(DAT_181dc60d8 + 184);
              }
              GlobalData.DoTweenSkeletonAlpha(uVar8,0,uVar12,0x3f000000,0);
            }
          }
        }
        fVar4 = local_60;
        if (this.exploreTileData != null) {
          this.exploreTileData.seen = value;
          this.needRefreshColor = 1;
          lVar6 = *(int64 *)(pStatics_5e30 + 8);
          fVar4 = local_60;
          if (lVar6 != null) {
            *(uint8 *)(lVar6 + 0x108) = 1;
            return;
          }
        }
        LAB_180b29951:
        local_60 = fVar4;
    }

    // Token : 0x6001447
    // RVA   : 0xB28F40   Offset: 0xB28340   Length: 0x1B
    public bool get_Seen()
    {
        if (this.exploreTileData != null) {
          return this.exploreTileData.seen;
        }
    }

    // Token : 0x6001448
    // RVA   : 0xB28F60   Offset: 0xB28360   Length: 0x8
    public void set_Been(bool value)
    {
        this.been = value;
        this.needRefreshColor = 1;
    }

    // Token : 0x6001449
    // RVA   : 0x23F610   Offset: 0x23EA10   Length: 0x5
    public bool get_Been()
    {
        uint8 FUN_18023f610(int64 this)
        {
        return this.been;
    }

    // Token : 0x600144A
    // RVA   : 0xB28F80   Offset: 0xB28380   Length: 0x1E
    public void set_MoveAble(bool value)
    {
        if (this.exploreTileData != null) {
          this.exploreTileData.moveAble = value;
          this.needRefreshColor = 1;
          return;
        }
    }

    // Token : 0x600144B
    // RVA   : 0xB28F20   Offset: 0xB28320   Length: 0x1B
    public bool get_MoveAble()
    {
        if (this.exploreTileData != null) {
          return this.exploreTileData.moveAble;
        }
    }

    // Token : 0x600144C
    // RVA   : 0xB28F70   Offset: 0xB28370   Length: 0x8
    public void set_FinalTile(bool value)
    {
        this.finalTile = value;
        this.needRefreshColor = 1;
    }

    // Token : 0x600144D
    // RVA   : 0xB28F10   Offset: 0xB28310   Length: 0x5
    public bool get_FinalTile()
    {
        uint8 FUN_180b28f10(int64 this)
        {
        return this.finalTile;
    }

    // Token : 0x600144E
    // RVA   : 0xB27510   Offset: 0xB26910   Length: 0x876
    public void CheckNeedFade(bool anim)
    {
        var pStatics = *(int64*)(DAT_181dc5e30 + 184);
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
        lVar7 = *(int64 *)(pStatics + 8);
        if ((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 120)) == null) throw; // [null/range check failed]
        if (iVar1 < *(int *)(lVar7 + 28) + -1) {
          lVar7 = *(int64 *)(pStatics + 8);
          if ((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 120)) == null) throw; // [null/range check failed]
          lVar7 = *(int64 *)(lVar7 + 40);
          lVar2 = this.exploreTileData;
          if ((lVar2 == null) || (lVar7 == null)) throw; // [null/range check failed]
          lVar9 = (int64)lVar2.row + 1;
          if (**(uint32 **)(lVar7 + 16) <= lVar2.column) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          lVar3 = *(int64 *)(*(uint32 **)(lVar7 + 16) + 4);
          if ((uint32)lVar3 <= (uint32)lVar9) {
            uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar8,0);
          }
          lVar7 = *(int64 *)(lVar7 + 32 + ((int)lVar2.column * lVar3 + lVar9) * 8);
          if (lVar7 == null) throw; // [null/range check failed]
          if (*(char *)(lVar7 + 88) != false) {
            lVar7 = FUN_18046be80(0);
            if ((lVar7 == null) || (*(int64 *)(lVar7 + 120) == 0)) throw; // [null/range check failed]
            lVar2 = this.exploreTileData;
            lVar7 = *(int64 *)(*(int64 *)(lVar7 + 120) + 40);
            if ((lVar2 == null) || (lVar7 == null)) throw; // [null/range check failed]
            lVar9 = (int64)lVar2.row + 1;
            if (**(uint32 **)(lVar7 + 16) <= lVar2.column) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            lVar3 = *(int64 *)(*(uint32 **)(lVar7 + 16) + 4);
            if ((uint32)lVar3 <= (uint32)lVar9) {
              uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar8,0);
            }
            lVar7 = *(int64 *)(lVar7 + 32 + ((int)lVar2.column * lVar3 + lVar9) * 8);
            if (lVar7 == null) throw; // [null/range check failed]
            if (*(int *)(lVar7 + 56) == 0) {
        LAB_180b27837:
              lVar7 = FUN_18046be80(0);
              if ((lVar7 == null) || (*(int64 *)(lVar7 + 120) == 0)) throw; // [null/range check failed]
              lVar2 = this.exploreTileData;
              lVar7 = *(int64 *)(*(int64 *)(lVar7 + 120) + 40);
              if ((lVar2 == null) || (lVar7 == null)) throw; // [null/range check failed]
              lVar9 = (int64)lVar2.row + 1;
              if (**(uint32 **)(lVar7 + 16) <= lVar2.column) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              lVar3 = *(int64 *)(*(uint32 **)(lVar7 + 16) + 4);
              if ((uint32)lVar3 <= (uint32)lVar9) {
                uVar8 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar8,0);
              }
              lVar7 = *(int64 *)(lVar7 + 32 + ((int)lVar2.column * lVar3 + lVar9) * 8);
              if (lVar7 == null) throw; // [null/range check failed]
              if (*(int64 *)(lVar7 + 80) == 0) {
                lVar7 = FUN_18046be80(0);
                if (lVar7 == null) throw; // [null/range check failed]
                lVar2 = this.exploreTileData;
                if ((lVar2 == null) || (*(int64 *)(lVar7 + 128) == 0)) throw; // [null/range check failed]
                uVar8 = FUN_180127f90(*(int64 *)(lVar7 + 128),(int64)lVar2.column,
                                      (int64)(lVar2.row + 1));
                lVar7 = FUN_18046be80(0);
                if (lVar7 == null) throw; // [null/range check failed]
                uVar4 = *(uint64 *)(lVar7 + 144);
                cVar5 = Object.op_Equality(uVar8,uVar4,0);
                goto LAB_180b2797d;
              }
            }
            else {
              lVar7 = FUN_18046be80(0);
              if ((lVar7 == null) || (*(int64 *)(lVar7 + 120) == 0)) throw; // [null/range check failed]
              lVar2 = this.exploreTileData;
              lVar7 = *(int64 *)(*(int64 *)(lVar7 + 120) + 40);
              if ((lVar2 == null) || (lVar7 == null)) throw; // [null/range check failed]
              lVar7 = FUN_180127f90(lVar7,(int64)lVar2.column,
                                    (int64)lVar2.row + 1);
              if (lVar7 == null) throw; // [null/range check failed]
              if (*(char *)(lVar7 + 53) != false) goto LAB_180b27837;
            }
            cVar5 = true;
          }
        }
        LAB_180b2797d:
        if ((!anim) || (cVar5 == this.needFade)) goto LAB_180b27d08;
        if (this.exploreTileData != null) {
          iVar1 = this.exploreTileData.wallType;
          if (iVar1 == 1) {
            lVar7 = Component.get_transform(this,0);
            if (lVar7 != null) {
              uVar8 = Transform.Find(lVar7,"Wall",0);
              cVar6 = Object.op_Inequality(uVar8,0,0);
              if (!cVar6) goto LAB_180b27d08;
              lVar7 = Component.get_transform(this,0);
              if (lVar7 != null) {
                lVar7 = Transform.Find(lVar7,"Wall",0);
                if (lVar7 != null) {
                  uVar8 = Component.GetComponent(lVar7,DAT_181d95de0);
                  if (!cVar5) {
                    uVar10 = 0x3f800000;
                  }
                  else {
                    uVar10 = **(uint32 **)(DAT_181dc60d8 + 184);
                  }
                  uVar8 = DOTweenModuleSprite.DOFade(uVar8,uVar10,0x3f000000,0);
                  TweenSettingsExtensions.SetUpdate(uVar8,1,DAT_181dc1c20);
                  goto LAB_180b27d08;
                }
              }
            }
          }
          else {
            if (iVar1 != 2) {
        LAB_180b27d08:
              this.needFade = cVar5;
              return;
            }
            lVar7 = Component.get_transform(this,0);
            if (lVar7 != null) {
              uVar8 = Transform.Find(lVar7,"Door",0);
              cVar6 = Object.op_Inequality(uVar8,0,0);
              if (!cVar6) goto LAB_180b27d08;
              lVar7 = Component.get_transform(this,0);
              if (lVar7 != null) {
                lVar7 = Transform.Find(lVar7,"Door",0);
                if (lVar7 != null) {
                  uVar8 = Component.GetComponent(lVar7,DAT_181d955e0);
                  cVar6 = Object.op_Inequality(uVar8,0,0);
                  if (!cVar6) goto LAB_180b27d08;
                  lVar7 = Component.get_transform(this,0);
                  if (lVar7 != null) {
                    lVar7 = Transform.Find(lVar7,"Door",0);
                    if (lVar7 != null) {
                      lVar7 = Component.GetComponent(lVar7,DAT_181d955e0);
                      if (lVar7 != null) {
                        if (*(int64 *)(lVar7 + 192) == 0) goto LAB_180b27d08;
                        lVar7 = Component.get_transform(this,0);
                        if (lVar7 != null) {
                          lVar7 = Transform.Find(lVar7,"Door",0);
                          if (lVar7 != null) {
                            uVar8 = Component.GetComponent(lVar7,DAT_181d955e0);
                            lVar7 = Component.get_transform(this,0);
                            if (lVar7 != null) {
                              lVar7 = Transform.Find(lVar7,"Door",0);
                              if (lVar7 != null) {
                                lVar7 = Component.GetComponent(lVar7,DAT_181d955e0);
                                if ((lVar7 != null) && (*(int64 *)(lVar7 + 192) != 0)) {
                                  uVar10 = *(uint32 *)(*(int64 *)(lVar7 + 192) + 108);
                                  if (!cVar5) {
                                    uVar11 = 0x3f800000;
                                  }
                                  else {
                                    uVar11 = **(uint32 **)(DAT_181dc60d8 + 184);
                                  }
                                  GlobalData.DoTweenSkeletonAlpha(uVar8,uVar10,uVar11,0x3f000000,0);
                                  goto LAB_180b27d08;
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

    // Token : 0x600144F
    // RVA   : 0xB28080   Offset: 0xB27480   Length: 0x8EF
    public void RefreshColor()
    {
        var pStatics = *(int64*)(DAT_181db0248 + 184);
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
        if (this.exploreTileData == null) goto LAB_180b2896a;
        if (!this.exploreTileData.eventHappen) {
          lVar6 = Component.get_transform(this,0);
          fVar5 = local_50;
          if (lVar6 == null) goto LAB_180b2896a;
          lVar6 = Transform.Find(lVar6,"ExploreEvent",0);
          puVar7 = (uint64 *)Vector3.get_one(&local_38,0);
          local_58 = *puVar7;
          local_50 = *(float *)(puVar7 + 1) * 0.6;
          local_68 = CONCAT44((float)((uint64)local_58 >> 32) * 0.6,(float)local_58 * 0.6);
          fVar5 = *(float *)(puVar7 + 1);
          if (lVar6 == null) goto LAB_180b2896a;
          local_58 = local_68;
          Transform.set_localScale(lVar6,&local_58,0);
          lVar6 = this.exploreTileData;
          fVar5 = local_50;
          if (lVar6 == null) goto LAB_180b2896a;
          if ((!lVar6.seen) ||
             ((lVar6.exploreTileEventType == null && (lVar6.exploreTileObstacleData == null)))) {
            lVar6 = Component.get_transform(this,0);
            fVar5 = local_50;
            if ((lVar6 == null) ||
               (lVar6 = Transform.Find(lVar6,"ExploreEvent",0), fVar5 = local_50) == null)
            goto LAB_180b2896a;
            lVar6 = Component.GetComponent(lVar6,DAT_181d95de0);
            puVar8 = (uint32 *)FUN_180d98fe0(&local_38,0);
            fVar5 = local_50;
            if (lVar6 == null) goto LAB_180b2896a;
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
        if (lVar6 == null) goto LAB_180b2896a;
        if (!lVar6.moveAble) {
          if ((!lVar6.seen) || (lVar6.eventHappen)) {
        LAB_180b2845f:
            lVar6 = Component.get_transform(this,0);
            fVar5 = local_50;
            if ((lVar6 == null) ||
               (lVar6 = Transform.Find(lVar6,"HighLight",0), fVar5 = local_50) == null)
            goto LAB_180b2896a;
            lVar6 = Component.GetComponent(lVar6,DAT_181d95de0);
            puVar8 = (uint32 *)FUN_180d98fe0(&local_38,0);
            goto LAB_180b284f2;
          }
          iVar4 = lVar6.exploreTileEventType;
          if (iVar4 == -1) {
            lVar6 = Component.get_transform(this,0);
            fVar5 = local_50;
            if ((lVar6 == null) ||
               (lVar6 = Transform.Find(lVar6,"HighLight",0), fVar5 = local_50) == null)
            goto LAB_180b2896a;
            lVar6 = Component.GetComponent(lVar6,DAT_181d95de0);
            puVar8 = (uint32 *)Color.get_red(&local_38,0);
            goto LAB_180b284f2;
          }
          if (iVar4 == 24) {
            lVar6 = Component.get_transform(this,0);
            fVar5 = local_50;
            if ((lVar6 == null) ||
               (lVar6 = Transform.Find(lVar6,"HighLight",0), fVar5 = local_50) == null)
            goto LAB_180b2896a;
            lVar6 = Component.GetComponent(lVar6,DAT_181d95de0);
            lVar9 = FUN_18046c100(0);
            fVar5 = local_50;
            if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) goto LAB_180b2896a;
            if (*(uint32 *)(lVar9 + 24) < 5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(*(int64 *)(lVar9 + 16) + 64);
          }
          else {
            if (iVar4 != 25) goto LAB_180b2845f;
            lVar6 = Component.get_transform(this,0);
            fVar5 = local_50;
            if ((lVar6 == null) ||
               (lVar6 = Transform.Find(lVar6,"HighLight",0), fVar5 = local_50) == null)
            goto LAB_180b2896a;
            lVar6 = Component.GetComponent(lVar6,DAT_181d95de0);
            lVar9 = FUN_18046c100(0);
            fVar5 = local_50;
            if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) goto LAB_180b2896a;
            if (*(uint32 *)(lVar9 + 24) < 4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(*(int64 *)(lVar9 + 16) + 56);
          }
          fVar5 = local_50;
          if ((lVar9 == null) || (lVar6 == null)) goto LAB_180b2896a;
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
          goto LAB_180b2896a;
          lVar6 = Component.GetComponent(lVar6,DAT_181d95de0);
          puVar8 = (uint32 *)Color.get_green(&local_38,0);
        LAB_180b284f2:
          fVar5 = local_50;
          if (lVar6 == null) goto LAB_180b2896a;
          local_38 = *puVar8;
          uStack_34 = puVar8[1];
          uStack_30 = puVar8[2];
          uStack_2c = puVar8[3];
        }
        SpriteRenderer.set_color(lVar6,&local_38,0);
        lVar6 = this.exploreTileData;
        fVar5 = local_50;
        if (lVar6 == null) goto LAB_180b2896a;
        if ((lVar6.wallType == null) || (!lVar6.seen)) {
          lVar6 = Component.get_transform(this,0);
          fVar5 = local_50;
          if ((lVar6 == null) ||
             ((lVar6 = Transform.Find(lVar6,"Wall",0), fVar5 = local_50, lVar6 == null ||
              (lVar6 = Component.get_gameObject(lVar6,0), fVar5 = local_50) == null)))
          goto LAB_180b2896a;
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
                            ) && ((lVar6 = Component.GetComponent(lVar6,DAT_181d955e0), fVar5 = local_50,
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
            goto LAB_180b2896a;
          }
          lVar6 = Component.get_transform(this,0);
          fVar5 = local_50;
          if (((lVar6 == null) ||
              (lVar6 = Transform.Find(lVar6,"Wall",0), fVar5 = local_50) == null) ||
             (lVar6 = Component.get_gameObject(lVar6,0), fVar5 = local_50) == null)
          goto LAB_180b2896a;
          GameObject.SetActive(lVar6,1,0);
          lVar6 = Component.get_transform(this,0);
          fVar5 = local_50;
          if (lVar6 == null) goto LAB_180b2896a;
          lVar6 = Transform.Find(lVar6,"Wall",0);
          lVar9 = Component.get_transform(this,0);
          fVar5 = local_50;
          if ((lVar9 == null) ||
             (lVar9 = Transform.Find(lVar9,"Wall",0), fVar5 = local_50) == null)
          goto LAB_180b2896a;
          puVar7 = (uint64 *)Transform.get_localPosition(&local_38,lVar9,0);
          uVar3 = *puVar7;
          fVar5 = *(float *)(puVar7 + 1);
          uVar2 = *(uint32 *)(pStatics + 36);
          local_58 = uVar3;
          local_50 = fVar5;
          puVar7 = (uint64 *)GlobalData.SetZ(&local_38,&local_58,uVar2,0);
          fVar5 = local_50;
          if (lVar6 == null) goto LAB_180b2896a;
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
        LAB_180b2896a:
        local_50 = fVar5;
    }

    // Token : 0x6001450
    // RVA   : 0xB28970   Offset: 0xB27D70   Length: 0x2A0
    public void SetObstacleColor()
    {
        var pStatics = *(int64*)(DAT_181dc5e30 + 184);
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
          uVar4 = Component.GetComponent(lVar3,DAT_181d95de0);
          this.exploreEventRenderer = uVar4;
        }
        lVar3 = this.exploreEventRenderer;
        lVar1 = *(int64 *)(pStatics + 8);
        if (lVar1 == null) throw; // [null/range check failed]
        cVar2 = ExploreController.PlayerCanPassObstacle(lVar1,this.exploreTileData,0,0);
        if (!cVar2) {
          lVar1 = *(int64 *)(pStatics + 8);
          if (lVar1 == null) throw; // [null/range check failed]
          cVar2 = ExploreController.PlayerCanPassObstacle(lVar1,this.exploreTileData,1,0);
          if (!cVar2) {
            puVar5 = (uint32 *)Color.get_red(&local_18,0);
            goto LAB_180b28bdd;
          }
          lVar1 = *(int64 *)(DAT_181d73d40 + 184);
          local_18 = *(uint32 *)(lVar1 + 800);
          uStack_14 = *(uint32 *)(lVar1 + 0x324);
          uStack_10 = *(uint32 *)(lVar1 + 0x328);
          uStack_c = *(uint32 *)(lVar1 + 0x32c);
        }
        else {
          puVar5 = (uint32 *)FUN_1810d3570(&local_18,0);
        LAB_180b28bdd:
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

    // Token : 0x6001451
    // RVA   : 0xB274D0   Offset: 0xB268D0   Length: 0x3B
    private void Awake()
    {
        float fVar1;
        float fVar2;
        fVar1 = (float)Time.get_unscaledTime(0);
        fVar2 = (float)Random.get_value(0);
        this.nextObstacleColorTime = fVar2 * 0.3 + fVar1;
    }

    // Token : 0x6001452
    // RVA   : 0xB28C20   Offset: 0xB28020   Length: 0x7E
    private void Update()
    {
        long lVar1;
        float fVar2;
        lVar1 = this.exploreTileData;
        if (lVar1 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
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

    // Token : 0x6001453
    // RVA   : 0xB27D90   Offset: 0xB27190   Length: 0xCC
    public void OnClick()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181dc5e30 + 184) + 8);
        uVar2 = Component.get_gameObject(this,0);
        if (lVar1 != null) {
          ExploreController.ExploreTileClicked(lVar1,uVar2,0);
          return;
        }
    }

    // Token : 0x6001454
    // RVA   : 0xB27F30   Offset: 0xB27330   Length: 0x82
    public void OnHover(bool isOver)
    {
        long lVar1;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        lVar1 = Component.GetComponent(this,DAT_181d95de0);
        if (!isOver) {
          puVar2 = (uint32 *)FUN_1810d3570();
        }
        else {
          puVar2 = (uint32 *)FUN_1810d33f0(&local_18,0);
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

    // Token : 0x6001455
    // RVA   : 0xB27E60   Offset: 0xB27260   Length: 0xC1
    public void OnDrag(Vector2 delta)
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181dc5e30 + 184) + 8);
        if (lVar1 != null) {
          ExploreController.OnDrag(lVar1,delta,0);
          return;
        }
    }

    // Token : 0x6001456
    // RVA   : 0xB27FC0   Offset: 0xB273C0   Length: 0xBD
    public void OnScroll(float delta)
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181dc5e30 + 184) + 8);
        if (lVar1 != null) {
          ExploreController.OnScroll(lVar1,delta,0);
          return;
        }
    }

    // Token : 0x6001457
    // RVA   : 0x3A17B0   Offset: 0x3A0BB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6001458
    // RVA   : 0xB28CA0   Offset: 0xB280A0   Length: 0x181
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181dc60d8 + 184);
        long lVar1;
        ulong local_38;
        ulong uStack_30;
        ulong local_28;
        ulong uStack_20;
        **(uint32 **)(DAT_181dc60d8 + 184) = 0x3f19999a;
        local_38 = 0;
        uStack_30 = 0;
        FUN_1809dc910(&local_38,0x3f800000,0x3f800000,0x3f800000,0x3f4ccccd,0);
        lVar1 = pStatics;
        *(uint32 *)(lVar1 + 4) = (uint32)local_38;
        *(uint32 *)(lVar1 + 8) = local_38._4_4_;
        *(uint32 *)(lVar1 + 12) = (uint32)uStack_30;
        *(uint32 *)(lVar1 + 16) = uStack_30._4_4_;
        local_28 = 0;
        uStack_20 = 0;
        FUN_1809dc910(&local_28,0x3e99999a,0x3e99999a,0x3e99999a,0x3f4ccccd,0);
        lVar1 = pStatics;
        *(uint32 *)(lVar1 + 20) = (uint32)local_28;
        *(uint32 *)(lVar1 + 24) = local_28._4_4_;
        *(uint32 *)(lVar1 + 28) = (uint32)uStack_20;
        *(uint32 *)(lVar1 + 32) = uStack_20._4_4_;
        lVar1 = il2cpp_internal(DAT_181d97750);
        FUN_18132faf0(lVar1,DAT_181da3bd8);
        if (lVar1 != null) {
          FUN_18181e0a0(lVar1,"2",DAT_181da3d58);
          FUN_18181e0a0(lVar1,"6",DAT_181da3d58);
          plVar2 = (int64 *)(pStatics + 40);
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          return;
        }
    }

}
