// ============================================================
// Type  : ExploreTileUnitController
// Token : 0x2000274
// ============================================================

public class ExploreTileUnitController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001353
    public ExploreTileData exploreTileData;

    // Token: 0x4001354
    public GameObject groundTypeSkeleton;

    // Token: 0x4001355
    private bool been;

    // Token: 0x4001356
    private bool finalTile;

    // Token: 0x4001357
    private SpriteRenderer tileRenderer;

    // Token: 0x4001358
    private bool needRefreshColor;

    // Token: 0x4001359
    private bool needFade;

    // Token: 0x400135A
    public bool needCheckFade;

    // Token: 0x400135B
    public static float fadeAlpha;

    // Token: 0x400135C
    private static Color WhiteCoverColor;

    // Token: 0x400135D
    private static Color BlackCoverColor;

    // Token: 0x400135E
    private static List<string> UseBlackCoverColorBackgroundType;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6001403
    // RVA   : 0xBA06B0   Offset: 0xB9EEB0   Length: 0x9BC
    public void set_Seen(bool value)
    {
        var pStatics_0c98 = *(int64*)(DAT_181da0c98 + 184);
        var pStatics_0f20 = *(int64*)(DAT_181da0f20 + 184);
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
          if (lVar6 == null) goto LAB_180ba1061;
          lVar6 = Transform.Find(lVar6,"BlackCover",0);
          fVar4 = local_60;
          if (lVar6 == null) goto LAB_180ba1061;
          lVar6 = Component.GetComponent(lVar6,DAT_181d6d540);
          lVar2 = *(int64 *)(pStatics_0c98 + 8);
          fVar4 = local_60;
          if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 120)) == null) goto LAB_180ba1061;
          if (*(int *)(lVar2 + 16) == 1) {
        LAB_180ba08a3:
            lVar2 = pStatics_0f20;
            uVar12 = *(uint32 *)(lVar2 + 20);
            uVar9 = *(uint32 *)(lVar2 + 24);
            uVar10 = *(uint32 *)(lVar2 + 28);
            uVar11 = *(uint32 *)(lVar2 + 32);
          }
          else {
            lVar2 = *(int64 *)(pStatics_0f20 + 40);
            lVar3 = *(int64 *)(pStatics_0c98 + 8);
            fVar4 = local_60;
            if ((lVar3 == null) || (lVar2 == null)) goto LAB_180ba1061;
            cVar5 = FUN_1818279a0(lVar2,*(uint64 *)(lVar3 + 88),DAT_181d7c4d0);
            if (!cVar5) {
              lVar2 = pStatics_0f20;
              uVar12 = *(uint32 *)(lVar2 + 4);
              uVar9 = *(uint32 *)(lVar2 + 8);
              uVar10 = *(uint32 *)(lVar2 + 12);
              uVar11 = *(uint32 *)(lVar2 + 16);
            }
            else {
              if (((*(byte *)(DAT_181da0f20 + 0x133) & 4) == 0) || (*(int *)(DAT_181da0f20 + 224) != 0))
              goto LAB_180ba08a3;
              il2cpp_runtime_class_init(DAT_181da0f20);
              lVar2 = pStatics_0f20;
              uVar12 = *(uint32 *)(lVar2 + 20);
              uVar9 = *(uint32 *)(lVar2 + 24);
              uVar10 = *(uint32 *)(lVar2 + 28);
              uVar11 = *(uint32 *)(lVar2 + 32);
            }
          }
          fVar4 = local_60;
          if (lVar6 == null) goto LAB_180ba1061;
          local_48 = CONCAT44(uVar9,uVar12);
          uStack_40 = CONCAT44(uVar11,uVar10);
          SpriteRenderer.set_color(lVar6,&local_48,0);
          lVar6 = Component.get_transform(this,0);
          fVar4 = local_60;
          if (lVar6 == null) goto LAB_180ba1061;
          lVar6 = Transform.Find(lVar6,"BlackCover",0);
          puVar7 = (uint64 *)Vector3.get_one(&local_48,0);
          local_68 = *puVar7;
          local_60 = *(float *)(puVar7 + 1) * 0.55;
          local_78 = CONCAT44((float)((uint64)local_68 >> 32) * 0.55,(float)local_68 * 0.55);
          fVar4 = *(float *)(puVar7 + 1);
          if (lVar6 == null) goto LAB_180ba1061;
          local_68 = local_78;
          Transform.set_localScale(lVar6,&local_68,0);
          uVar8 = this.groundTypeSkeleton;
          cVar5 = Object.op_Inequality(uVar8,0,0);
          if (cVar5) {
            fVar4 = local_60;
            if (this.groundTypeSkeleton == null) goto LAB_180ba1061;
            lVar6 = GameObject.GetComponent(this.groundTypeSkeleton,DAT_181da1330);
            fVar4 = local_60;
            if (lVar6 == null) goto LAB_180ba1061;
            lVar6 = SkeletonRenderer.get_Skeleton(lVar6,0);
            fVar4 = local_60;
            if (lVar6 == null) goto LAB_180ba1061;
            *(uint32 *)(lVar6 + 108) = 0;
          }
        }
        else {
          fVar4 = local_60;
          if (this.exploreTileData == null) goto LAB_180ba1061;
          if (!this.exploreTileData.seen) {
            ExploreTileUnitController.CheckNeedFade(this,0,0);
            fVar4 = local_60;
            if (this.exploreTileData == null) goto LAB_180ba1061;
            if (0 < this.exploreTileData.row) {
              lVar6 = FUN_18046be80(0);
              fVar4 = local_60;
              if ((((lVar6 == null) || (*(int64 *)(lVar6 + 120) == 0)) ||
                  (lVar2 = this.exploreTileData) == null) ||
                 (lVar6 = *(int64 *)(*(int64 *)(lVar6 + 120) + 40)) == null)
              goto LAB_180ba1061;
              lVar6 = FUN_180127f50(lVar6,(int64)*(int *)(lVar2 + 36),
                                    (int64)*(int *)(lVar2 + 32) + -1);
              fVar4 = local_60;
              if (lVar6 == null) goto LAB_180ba1061;
              if (*(char *)(lVar6 + 88) != false) {
                lVar6 = FUN_18046be80(0);
                fVar4 = local_60;
                if (((lVar6 == null) || (lVar2 = this.exploreTileData) == null) ||
                   (*(int64 *)(lVar6 + 128) == 0)) goto LAB_180ba1061;
                lVar6 = FUN_180127f50(*(int64 *)(lVar6 + 128),(int64)*(int *)(lVar2 + 36),
                                      (int64)*(int *)(lVar2 + 32) + -1);
                fVar4 = local_60;
                if (lVar6 == null) goto LAB_180ba1061;
                lVar6 = GameObject.GetComponent(lVar6,DAT_181d9f5d0);
                fVar4 = local_60;
                if (lVar6 == null) goto LAB_180ba1061;
                *(uint8 *)(lVar6 + 58) = 1;
              }
            }
            lVar6 = Component.get_transform(this,0);
            fVar4 = local_60;
            if (lVar6 == null) goto LAB_180ba1061;
            lVar6 = Transform.Find(lVar6,"BlackCover",0);
            fVar4 = local_60;
            if (lVar6 == null) goto LAB_180ba1061;
            uVar8 = Component.GetComponent(lVar6,DAT_181d6d540);
            uVar8 = DOTweenModuleSprite.DOFade(uVar8,0,0x3f000000,0);
            TweenSettingsExtensions.SetUpdate(uVar8,1,DAT_181d98958);
            lVar6 = Component.get_transform(this,0);
            fVar4 = local_60;
            if (lVar6 == null) goto LAB_180ba1061;
            uVar8 = Transform.Find(lVar6,"BlackCover",0);
            uVar12 = 0x3f800000;
            uVar8 = ShortcutExtensions.DOScale(uVar8,0x3f800000,0x3f000000,0);
            TweenSettingsExtensions.SetUpdate(uVar8,1,DAT_181d98af0);
            uVar8 = this.groundTypeSkeleton;
            cVar5 = Object.op_Inequality(uVar8,0,0);
            if (cVar5) {
              fVar4 = local_60;
              if (this.groundTypeSkeleton == null) goto LAB_180ba1061;
              uVar8 = GameObject.GetComponent(this.groundTypeSkeleton,DAT_181da1330);
              in_stack_ffffffffffffff78 = 0;
              GlobalData.DoTweenSkeletonAlpha(uVar8,0,0x3f800000,0x3f000000,0);
            }
            fVar4 = local_60;
            if (this.exploreTileData == null) goto LAB_180ba1061;
            iVar1 = this.exploreTileData.wallType;
            if (iVar1 == 1) {
              lVar6 = Component.get_transform(this,0);
              if (lVar6 == null) {
        LAB_180ba1067:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              lVar6 = Transform.Find(lVar6,"Wall",0);
              if (lVar6 == null) goto LAB_180ba1067;
              lVar6 = Component.GetComponent(lVar6,DAT_181d6d540);
              local_48 = 0;
              uStack_40 = 0;
              FUN_1809981e0(&local_48,0x3f800000,0x3f800000,0x3f800000,
                            in_stack_ffffffffffffff78 & 0xffffffff00000000,0);
              if (lVar6 == null) goto LAB_180ba1067;
              local_58 = (uint32)local_48;
              uStack_54 = local_48._4_4_;
              uStack_50 = (uint32)uStack_40;
              uStack_4c = uStack_40._4_4_;
              SpriteRenderer.set_color(lVar6,&local_58,0);
              lVar6 = Component.get_transform(this,0);
              if (lVar6 == null) goto LAB_180ba1067;
              lVar6 = Transform.Find(lVar6,"Wall",0);
              if (lVar6 == null) goto LAB_180ba1067;
              uVar8 = Component.GetComponent(lVar6,DAT_181d6d540);
              if (this.needFade) {
                uVar12 = **(uint32 **)(DAT_181da0f20 + 184);
              }
              uVar8 = DOTweenModuleSprite.DOFade(uVar8,uVar12,0x3f000000,0);
              TweenSettingsExtensions.SetUpdate(uVar8,1,DAT_181d98958);
            }
            else if (iVar1 == 2) {
              lVar6 = Component.get_transform(this,0);
              fVar4 = local_60;
              if (lVar6 == null) goto LAB_180ba1061;
              lVar6 = Transform.Find(lVar6,"Door",0);
              fVar4 = local_60;
              if (lVar6 == null) goto LAB_180ba1061;
              uVar8 = Component.GetComponent(lVar6,DAT_181d6cd40);
              if (this.needFade) {
                uVar12 = **(uint32 **)(DAT_181da0f20 + 184);
              }
              GlobalData.DoTweenSkeletonAlpha(uVar8,0,uVar12,0x3f000000,0);
            }
          }
        }
        fVar4 = local_60;
        if (this.exploreTileData != null) {
          this.exploreTileData.seen = value;
          this.needRefreshColor = 1;
          lVar6 = *(int64 *)(pStatics_0c98 + 8);
          fVar4 = local_60;
          if (lVar6 != null) {
            *(uint8 *)(lVar6 + 0x108) = 1;
            return;
          }
        }
        LAB_180ba1061:
        local_60 = fVar4;
    }

    // Token : 0x6001404
    // RVA   : 0xBA0650   Offset: 0xB9EE50   Length: 0x1B
    public bool get_Seen()
    {
        if (this.exploreTileData != null) {
          return this.exploreTileData.seen;
        }
    }

    // Token : 0x6001405
    // RVA   : 0xBA0670   Offset: 0xB9EE70   Length: 0x8
    public void set_Been(bool value)
    {
        this.been = value;
        this.needRefreshColor = 1;
    }

    // Token : 0x6001406
    // RVA   : 0x23F610   Offset: 0x23DE10   Length: 0x5
    public bool get_Been()
    {
        uint8 FUN_18023f610(int64 this)
        {
        return this.been;
    }

    // Token : 0x6001407
    // RVA   : 0xBA0690   Offset: 0xB9EE90   Length: 0x1E
    public void set_MoveAble(bool value)
    {
        if (this.exploreTileData != null) {
          this.exploreTileData.moveAble = value;
          this.needRefreshColor = 1;
          return;
        }
    }

    // Token : 0x6001408
    // RVA   : 0xBA0630   Offset: 0xB9EE30   Length: 0x1B
    public bool get_MoveAble()
    {
        if (this.exploreTileData != null) {
          return this.exploreTileData.moveAble;
        }
    }

    // Token : 0x6001409
    // RVA   : 0xBA0680   Offset: 0xB9EE80   Length: 0x8
    public void set_FinalTile(bool value)
    {
        this.finalTile = value;
        this.needRefreshColor = 1;
    }

    // Token : 0x600140A
    // RVA   : 0xBA0620   Offset: 0xB9EE20   Length: 0x5
    public bool get_FinalTile()
    {
        uint8 FUN_180ba0620(int64 this)
        {
        return this.finalTile;
    }

    // Token : 0x600140B
    // RVA   : 0xB9ED80   Offset: 0xB9D580   Length: 0x876
    public void CheckNeedFade(bool anim)
    {
        var pStatics = *(int64*)(DAT_181da0c98 + 184);
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
        LAB_180b9f0a7:
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
                uVar8 = FUN_180127f50(*(int64 *)(lVar7 + 128),(int64)lVar2.column,
                                      (int64)(lVar2.row + 1));
                lVar7 = FUN_18046be80(0);
                if (lVar7 == null) throw; // [null/range check failed]
                uVar4 = *(uint64 *)(lVar7 + 144);
                cVar5 = Object.op_Equality(uVar8,uVar4,0);
                goto LAB_180b9f1ed;
              }
            }
            else {
              lVar7 = FUN_18046be80(0);
              if ((lVar7 == null) || (*(int64 *)(lVar7 + 120) == 0)) throw; // [null/range check failed]
              lVar2 = this.exploreTileData;
              lVar7 = *(int64 *)(*(int64 *)(lVar7 + 120) + 40);
              if ((lVar2 == null) || (lVar7 == null)) throw; // [null/range check failed]
              lVar7 = FUN_180127f50(lVar7,(int64)lVar2.column,
                                    (int64)lVar2.row + 1);
              if (lVar7 == null) throw; // [null/range check failed]
              if (*(char *)(lVar7 + 53) != false) goto LAB_180b9f0a7;
            }
            cVar5 = true;
          }
        }
        LAB_180b9f1ed:
        if ((!anim) || (cVar5 == this.needFade)) goto LAB_180b9f578;
        if (this.exploreTileData != null) {
          iVar1 = this.exploreTileData.wallType;
          if (iVar1 == 1) {
            lVar7 = Component.get_transform(this,0);
            if (lVar7 != null) {
              uVar8 = Transform.Find(lVar7,"Wall",0);
              cVar6 = Object.op_Inequality(uVar8,0,0);
              if (!cVar6) goto LAB_180b9f578;
              lVar7 = Component.get_transform(this,0);
              if (lVar7 != null) {
                lVar7 = Transform.Find(lVar7,"Wall",0);
                if (lVar7 != null) {
                  uVar8 = Component.GetComponent(lVar7,DAT_181d6d540);
                  if (!cVar5) {
                    uVar10 = 0x3f800000;
                  }
                  else {
                    uVar10 = **(uint32 **)(DAT_181da0f20 + 184);
                  }
                  uVar8 = DOTweenModuleSprite.DOFade(uVar8,uVar10,0x3f000000,0);
                  TweenSettingsExtensions.SetUpdate(uVar8,1,DAT_181d98958);
                  goto LAB_180b9f578;
                }
              }
            }
          }
          else {
            if (iVar1 != 2) {
        LAB_180b9f578:
              this.needFade = cVar5;
              return;
            }
            lVar7 = Component.get_transform(this,0);
            if (lVar7 != null) {
              uVar8 = Transform.Find(lVar7,"Door",0);
              cVar6 = Object.op_Inequality(uVar8,0,0);
              if (!cVar6) goto LAB_180b9f578;
              lVar7 = Component.get_transform(this,0);
              if (lVar7 != null) {
                lVar7 = Transform.Find(lVar7,"Door",0);
                if (lVar7 != null) {
                  uVar8 = Component.GetComponent(lVar7,DAT_181d6cd40);
                  cVar6 = Object.op_Inequality(uVar8,0,0);
                  if (!cVar6) goto LAB_180b9f578;
                  lVar7 = Component.get_transform(this,0);
                  if (lVar7 != null) {
                    lVar7 = Transform.Find(lVar7,"Door",0);
                    if (lVar7 != null) {
                      lVar7 = Component.GetComponent(lVar7,DAT_181d6cd40);
                      if (lVar7 != null) {
                        if (*(int64 *)(lVar7 + 192) == 0) goto LAB_180b9f578;
                        lVar7 = Component.get_transform(this,0);
                        if (lVar7 != null) {
                          lVar7 = Transform.Find(lVar7,"Door",0);
                          if (lVar7 != null) {
                            uVar8 = Component.GetComponent(lVar7,DAT_181d6cd40);
                            lVar7 = Component.get_transform(this,0);
                            if (lVar7 != null) {
                              lVar7 = Transform.Find(lVar7,"Door",0);
                              if (lVar7 != null) {
                                lVar7 = Component.GetComponent(lVar7,DAT_181d6cd40);
                                if ((lVar7 != null) && (*(int64 *)(lVar7 + 192) != 0)) {
                                  uVar10 = *(uint32 *)(*(int64 *)(lVar7 + 192) + 108);
                                  if (!cVar5) {
                                    uVar11 = 0x3f800000;
                                  }
                                  else {
                                    uVar11 = **(uint32 **)(DAT_181da0f20 + 184);
                                  }
                                  GlobalData.DoTweenSkeletonAlpha(uVar8,uVar10,uVar11,0x3f000000,0);
                                  goto LAB_180b9f578;
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

    // Token : 0x600140C
    // RVA   : 0xB9F8F0   Offset: 0xB9E0F0   Length: 0x8EF
    public void RefreshColor()
    {
        var pStatics = *(int64*)(DAT_181d8b128 + 184);
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
        if (this.exploreTileData == null) goto LAB_180ba01da;
        if (!this.exploreTileData.eventHappen) {
          lVar6 = Component.get_transform(this,0);
          fVar5 = local_50;
          if (lVar6 == null) goto LAB_180ba01da;
          lVar6 = Transform.Find(lVar6,"ExploreEvent",0);
          puVar7 = (uint64 *)Vector3.get_one(&local_38,0);
          local_58 = *puVar7;
          local_50 = *(float *)(puVar7 + 1) * 0.6;
          local_68 = CONCAT44((float)((uint64)local_58 >> 32) * 0.6,(float)local_58 * 0.6);
          fVar5 = *(float *)(puVar7 + 1);
          if (lVar6 == null) goto LAB_180ba01da;
          local_58 = local_68;
          Transform.set_localScale(lVar6,&local_58,0);
          lVar6 = this.exploreTileData;
          fVar5 = local_50;
          if (lVar6 == null) goto LAB_180ba01da;
          if ((!lVar6.seen) ||
             ((lVar6.exploreTileEventType == null && (lVar6.exploreTileObstacleData == null)))) {
            lVar6 = Component.get_transform(this,0);
            fVar5 = local_50;
            if ((lVar6 == null) ||
               (lVar6 = Transform.Find(lVar6,"ExploreEvent",0), fVar5 = local_50) == null)
            goto LAB_180ba01da;
            lVar6 = Component.GetComponent(lVar6,DAT_181d6d540);
            puVar8 = (uint32 *)FUN_180d904c0(&local_38,0);
            fVar5 = local_50;
            if (lVar6 == null) goto LAB_180ba01da;
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
        if (lVar6 == null) goto LAB_180ba01da;
        if (!lVar6.moveAble) {
          if ((!lVar6.seen) || (lVar6.eventHappen)) {
        LAB_180b9fccf:
            lVar6 = Component.get_transform(this,0);
            fVar5 = local_50;
            if ((lVar6 == null) ||
               (lVar6 = Transform.Find(lVar6,"HighLight",0), fVar5 = local_50) == null)
            goto LAB_180ba01da;
            lVar6 = Component.GetComponent(lVar6,DAT_181d6d540);
            puVar8 = (uint32 *)FUN_180d904c0(&local_38,0);
            goto LAB_180b9fd62;
          }
          iVar4 = lVar6.exploreTileEventType;
          if (iVar4 == -1) {
            lVar6 = Component.get_transform(this,0);
            fVar5 = local_50;
            if ((lVar6 == null) ||
               (lVar6 = Transform.Find(lVar6,"HighLight",0), fVar5 = local_50) == null)
            goto LAB_180ba01da;
            lVar6 = Component.GetComponent(lVar6,DAT_181d6d540);
            puVar8 = (uint32 *)Color.get_red(&local_38,0);
            goto LAB_180b9fd62;
          }
          if (iVar4 == 24) {
            lVar6 = Component.get_transform(this,0);
            fVar5 = local_50;
            if ((lVar6 == null) ||
               (lVar6 = Transform.Find(lVar6,"HighLight",0), fVar5 = local_50) == null)
            goto LAB_180ba01da;
            lVar6 = Component.GetComponent(lVar6,DAT_181d6d540);
            lVar9 = FUN_18046c100(0);
            fVar5 = local_50;
            if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) goto LAB_180ba01da;
            if (*(uint32 *)(lVar9 + 24) < 5) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(*(int64 *)(lVar9 + 16) + 64);
          }
          else {
            if (iVar4 != 25) goto LAB_180b9fccf;
            lVar6 = Component.get_transform(this,0);
            fVar5 = local_50;
            if ((lVar6 == null) ||
               (lVar6 = Transform.Find(lVar6,"HighLight",0), fVar5 = local_50) == null)
            goto LAB_180ba01da;
            lVar6 = Component.GetComponent(lVar6,DAT_181d6d540);
            lVar9 = FUN_18046c100(0);
            fVar5 = local_50;
            if ((lVar9 == null) || (lVar9 = *(int64 *)(lVar9 + 56)) == null) goto LAB_180ba01da;
            if (*(uint32 *)(lVar9 + 24) < 4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar9 = *(int64 *)(*(int64 *)(lVar9 + 16) + 56);
          }
          fVar5 = local_50;
          if ((lVar9 == null) || (lVar6 == null)) goto LAB_180ba01da;
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
          goto LAB_180ba01da;
          lVar6 = Component.GetComponent(lVar6,DAT_181d6d540);
          puVar8 = (uint32 *)Color.get_green(&local_38,0);
        LAB_180b9fd62:
          fVar5 = local_50;
          if (lVar6 == null) goto LAB_180ba01da;
          local_38 = *puVar8;
          uStack_34 = puVar8[1];
          uStack_30 = puVar8[2];
          uStack_2c = puVar8[3];
        }
        SpriteRenderer.set_color(lVar6,&local_38,0);
        lVar6 = this.exploreTileData;
        fVar5 = local_50;
        if (lVar6 == null) goto LAB_180ba01da;
        if ((lVar6.wallType == null) || (!lVar6.seen)) {
          lVar6 = Component.get_transform(this,0);
          fVar5 = local_50;
          if ((lVar6 == null) ||
             ((lVar6 = Transform.Find(lVar6,"Wall",0), fVar5 = local_50, lVar6 == null ||
              (lVar6 = Component.get_gameObject(lVar6,0), fVar5 = local_50) == null)))
          goto LAB_180ba01da;
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
                            ) && ((lVar6 = Component.GetComponent(lVar6,DAT_181d6cd40), fVar5 = local_50,
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
            goto LAB_180ba01da;
          }
          lVar6 = Component.get_transform(this,0);
          fVar5 = local_50;
          if (((lVar6 == null) ||
              (lVar6 = Transform.Find(lVar6,"Wall",0), fVar5 = local_50) == null) ||
             (lVar6 = Component.get_gameObject(lVar6,0), fVar5 = local_50) == null)
          goto LAB_180ba01da;
          GameObject.SetActive(lVar6,1,0);
          lVar6 = Component.get_transform(this,0);
          fVar5 = local_50;
          if (lVar6 == null) goto LAB_180ba01da;
          lVar6 = Transform.Find(lVar6,"Wall",0);
          lVar9 = Component.get_transform(this,0);
          fVar5 = local_50;
          if ((lVar9 == null) ||
             (lVar9 = Transform.Find(lVar9,"Wall",0), fVar5 = local_50) == null)
          goto LAB_180ba01da;
          puVar7 = (uint64 *)Transform.get_localPosition(&local_38,lVar9,0);
          uVar3 = *puVar7;
          fVar5 = *(float *)(puVar7 + 1);
          uVar2 = *(uint32 *)(pStatics + 36);
          local_58 = uVar3;
          local_50 = fVar5;
          puVar7 = (uint64 *)GlobalData.SetZ(&local_38,&local_58,uVar2,0);
          fVar5 = local_50;
          if (lVar6 == null) goto LAB_180ba01da;
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
        LAB_180ba01da:
        local_50 = fVar5;
    }

    // Token : 0x600140D
    // RVA   : 0xBA01E0   Offset: 0xB9E9E0   Length: 0x237
    public void SetObstacleColor()
    {
        var pStatics = *(int64*)(DAT_181da0c98 + 184);
        long lVar1;
        bool cVar2;
        long lVar3;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        lVar3 = Component.get_transform(this,0);
        if (lVar3 == null) throw; // [null/range check failed]
        lVar3 = Transform.Find(lVar3,"ExploreEvent",0);
        if (lVar3 == null) throw; // [null/range check failed]
        lVar3 = Component.GetComponent(lVar3,DAT_181d6d540);
        lVar1 = *(int64 *)(pStatics + 8);
        if (lVar1 == null) throw; // [null/range check failed]
        cVar2 = ExploreController.PlayerCanPassObstacle(lVar1,this.exploreTileData,0,0);
        if (!cVar2) {
          lVar1 = *(int64 *)(pStatics + 8);
          if (lVar1 == null) throw; // [null/range check failed]
          cVar2 = ExploreController.PlayerCanPassObstacle(lVar1,this.exploreTileData,1,0);
          if (!cVar2) {
            puVar4 = (uint32 *)Color.get_red(&local_18,0);
            goto LAB_180ba03e9;
          }
          lVar1 = *(int64 *)(DAT_181d4ef00 + 184);
          local_18 = *(uint32 *)(lVar1 + 0x318);
          uStack_14 = *(uint32 *)(lVar1 + 0x31c);
          uStack_10 = *(uint32 *)(lVar1 + 800);
          uStack_c = *(uint32 *)(lVar1 + 0x324);
        }
        else {
          puVar4 = (uint32 *)FUN_181098a50(&local_18,0);
        LAB_180ba03e9:
          local_18 = *puVar4;
          uStack_14 = puVar4[1];
          uStack_10 = puVar4[2];
          uStack_c = puVar4[3];
        }
        if (lVar3 != null) {
          SpriteRenderer.set_color(lVar3,&local_18,0);
          return;
        }
    }

    // Token : 0x600140E
    // RVA   : 0xBA0420   Offset: 0xB9EC20   Length: 0x61
    private void Update()
    {
        long lVar1;
        lVar1 = this.exploreTileData;
        if (lVar1 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if ((lVar1.seen) && (lVar1.exploreTileObstacleData != null)) {
          ExploreTileUnitController.SetObstacleColor(this,0);
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

    // Token : 0x600140F
    // RVA   : 0xB9F600   Offset: 0xB9DE00   Length: 0xCC
    public void OnClick()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181da0c98 + 184) + 8);
        uVar2 = Component.get_gameObject(this,0);
        if (lVar1 != null) {
          ExploreController.ExploreTileClicked(lVar1,uVar2,0);
          return;
        }
    }

    // Token : 0x6001410
    // RVA   : 0xB9F7A0   Offset: 0xB9DFA0   Length: 0x82
    public void OnHover(bool isOver)
    {
        long lVar1;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        lVar1 = Component.GetComponent(this,DAT_181d6d540);
        if (!isOver) {
          puVar2 = (uint32 *)FUN_181098a50();
        }
        else {
          puVar2 = (uint32 *)FUN_1810988d0(&local_18,0);
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

    // Token : 0x6001411
    // RVA   : 0xB9F6D0   Offset: 0xB9DED0   Length: 0xC1
    public void OnDrag(Vector2 delta)
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181da0c98 + 184) + 8);
        if (lVar1 != null) {
          ExploreController.OnDrag(lVar1,delta,0);
          return;
        }
    }

    // Token : 0x6001412
    // RVA   : 0xB9F830   Offset: 0xB9E030   Length: 0xBD
    public void OnScroll(float delta)
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181da0c98 + 184) + 8);
        if (lVar1 != null) {
          ExploreController.OnScroll(lVar1,delta,0);
          return;
        }
    }

    // Token : 0x6001413
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6001414
    // RVA   : 0xBA0490   Offset: 0xB9EC90   Length: 0x181
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181da0f20 + 184);
        long lVar1;
        ulong local_38;
        ulong uStack_30;
        ulong local_28;
        ulong uStack_20;
        **(uint32 **)(DAT_181da0f20 + 184) = 0x3f19999a;
        local_38 = 0;
        uStack_30 = 0;
        FUN_1809981e0(&local_38,0x3f800000,0x3f800000,0x3f800000,0x3f4ccccd,0);
        lVar1 = pStatics;
        *(uint32 *)(lVar1 + 4) = (uint32)local_38;
        *(uint32 *)(lVar1 + 8) = local_38._4_4_;
        *(uint32 *)(lVar1 + 12) = (uint32)uStack_30;
        *(uint32 *)(lVar1 + 16) = uStack_30._4_4_;
        local_28 = 0;
        uStack_20 = 0;
        FUN_1809981e0(&local_28,0x3e99999a,0x3e99999a,0x3e99999a,0x3f4ccccd,0);
        lVar1 = pStatics;
        *(uint32 *)(lVar1 + 20) = (uint32)local_28;
        *(uint32 *)(lVar1 + 24) = local_28._4_4_;
        *(uint32 *)(lVar1 + 28) = (uint32)uStack_20;
        *(uint32 *)(lVar1 + 32) = uStack_20._4_4_;
        lVar1 = il2cpp_internal(DAT_181d72a30);
        FUN_180f58a90(lVar1,DAT_181d7c250);
        if (lVar1 != null) {
          FUN_181827900(lVar1,"2",DAT_181d7c3d0);
          FUN_181827900(lVar1,"6",DAT_181d7c3d0);
          plVar2 = (int64 *)(pStatics + 40);
          *plVar2 = lVar1;
          il2cpp_internal(plVar2,lVar1);
          return;
        }
    }

}
