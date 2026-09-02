// ============================================================
// Type  : GridUnitController
// Token : 0x200017E
// ============================================================

public class GridUnitController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40009ED
    public GridUnitData gridData;

    // Token: 0x40009EE
    public GameObject obstacleObj;

    // Token: 0x40009EF
    public GameObject wallSprite;

    // Token: 0x40009F0
    public List<GameObject> decorations;

    // Token: 0x40009F1
    public GameObject speGridObj;

    // Token: 0x40009F2
    private GridRenderType gridRenderType;

    // Token: 0x40009F3
    public HighLightRenderType highLightRenderType;

    // Token: 0x40009F4
    private SpriteRenderer tileRenderer;

    // Token: 0x40009F5
    public SpriteRenderer backRenderer;

    // Token: 0x40009F6
    public SpriteRenderer lineRenderer;

    // Token: 0x40009F7
    public SpriteRenderer coverRenderer;

    // Token: 0x40009F8
    public SpriteRenderer highlightRenderer;

    // Token: 0x40009F9
    public static Color NearEnemyMoveRangeColor;

    // Token: 0x40009FA
    public static Color MoveRangeColor;

    // Token: 0x40009FB
    public static Color PathColor;

    // Token: 0x40009FC
    public static Color ObstacleBackColor;

    // Token: 0x40009FD
    public static Color AttackRangeColor;

    // Token: 0x40009FE
    public static Color AttackHitRangeColor;

    // Token: 0x40009FF
    public static Color CureRangeColor;

    // Token: 0x4000A00
    public static Color CureHitRangeColor;

    // Token: 0x4000A01
    public static Color HoverHighlightColor;

    // Token: 0x4000A02
    public static Color AttackChooseHighlightColor;

    // Token: 0x4000A03
    public static Color CureChooseHighlightColor;

    // Token: 0x4000A04
    public static List<Color> AttackDirectionColor;

    // Token: 0x4000A05
    private GameObject showAttackDirectionRange;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000C5C
    // RVA   : 0x874C50   Offset: 0x873450   Length: 0xA
    public void set_GridRenderType(GridRenderType value)
    {
        this.gridRenderType = value;
        GridUnitController.Refresh(this,0);
    }

    // Token : 0x6000C5D
    // RVA   : 0x362680   Offset: 0x360E80   Length: 0x4
    public GridRenderType get_GridRenderType()
    {
        uint32 FUN_180362680(int64 this)
        {
        return this.gridRenderType;
    }

    // Token : 0x6000C5E
    // RVA   : 0x8723C0   Offset: 0x870BC0   Length: 0x76E
    public void Refresh()
    {
        var pStatics = *(int64*)(DAT_181d4f980 + 184);
        int iVar1;
        ulong uVar2;
        bool cVar4;
        int iVar5;
        uint uVar6;
        long lVar7;
        long lVar8;
        long lVar9;
        uint uVar11;
        uint uVar12;
        uint uVar13;
        uint uVar14;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        iVar5 = this.gridRenderType;
        if (iVar5 == 4) {
          lVar8 = this.coverRenderer;
          lVar7 = pStatics;
          if (lVar8 == null) throw; // [null/range check failed]
          uVar11 = *(uint32 *)(lVar7 + 32);
          uVar12 = *(uint32 *)(lVar7 + 36);
          uVar13 = *(uint32 *)(lVar7 + 40);
          uVar14 = *(uint32 *)(lVar7 + 44);
        }
        else if (iVar5 == 5) {
        LAB_1808728b1:
          lVar8 = this.coverRenderer;
          puVar10 = (uint32 *)FUN_180d904c0(&local_28,0);
          if (lVar8 == null) throw; // [null/range check failed]
          uVar11 = *puVar10;
          uVar12 = puVar10[1];
          uVar13 = puVar10[2];
          uVar14 = puVar10[3];
        }
        else {
          if (iVar5 == 6) {
            bVar3 = false;
            iVar5 = 0;
            do {
              lVar8 = FUN_18046bb80(0);
              if (((lVar8 == null) || (lVar7 = this.gridData) == null) ||
                 (*(int64 *)(lVar8 + 24) == 0)) throw; // [null/range check failed]
              lVar8 = BattleMapData.GetGridDataByDir
                                (*(int64 *)(lVar8 + 24),*(uint32 *)(lVar7 + 36),
                                 *(uint32 *)(lVar7 + 40),iVar5,0);
              if (lVar8 != null) {
                lVar8 = FUN_18046bb80(0);
                if (((lVar8 == null) || (lVar7 = this.gridData) == null) ||
                   ((*(int64 *)(lVar8 + 24) == 0 ||
                    (lVar8 = BattleMapData.GetGridDataByDir
                                       (*(int64 *)(lVar8 + 24),*(uint32 *)(lVar7 + 36),
                                        *(uint32 *)(lVar7 + 40),iVar5,0), lVar8 == null))))
                throw; // [null/range check failed]
                uVar2 = *(uint64 *)(lVar8 + 24);
                cVar4 = Object.op_Inequality(uVar2,0,0);
                if (cVar4) {
                  lVar8 = FUN_18046bb80(0);
                  if ((((lVar8 == null) || (lVar7 = this.gridData) == null) ||
                      (*(int64 *)(lVar8 + 24) == 0)) ||
                     ((lVar8 = BattleMapData.GetGridDataByDir
                                         (*(int64 *)(lVar8 + 24),*(uint32 *)(lVar7 + 36),
                                          *(uint32 *)(lVar7 + 40),iVar5,0), lVar8 == null ||
                      (*(int64 *)(lVar8 + 24) == 0)))) throw; // [null/range check failed]
                  cVar4 = BattleUnit.get_IsAlive(*(int64 *)(lVar8 + 24),0);
                  if (cVar4) {
                    lVar8 = FUN_18046bb80(0);
                    if ((((lVar8 == null) || (lVar7 = this.gridData) == null) ||
                        (*(int64 *)(lVar8 + 24) == 0)) ||
                       (((lVar8 = BattleMapData.GetGridDataByDir
                                            (*(int64 *)(lVar8 + 24),*(uint32 *)(lVar7 + 36),
                                             *(uint32 *)(lVar7 + 40),iVar5,0), lVar8 == null ||
                         (*(int64 *)(lVar8 + 24) == 0)) ||
                        (lVar8 = *(int64 *)(*(int64 *)(lVar8 + 24) + 88)) == null)))
                    throw; // [null/range check failed]
                    iVar1 = *(int *)(lVar8 + 16);
                    lVar8 = FUN_18046bb80(0);
                    if (((lVar8 == null) || (*(int64 *)(lVar8 + 0x110) == 0)) ||
                       (lVar8 = *(int64 *)(*(int64 *)(lVar8 + 0x110) + 88)) == null)
                    throw; // [null/range check failed]
                    if (iVar1 != *(int *)(lVar8 + 16)) {
                      bVar3 = true;
                    }
                  }
                }
              }
              iVar5 = iVar5 + 1;
            } while (iVar5 < 4);
            lVar8 = this.coverRenderer;
            if (bVar3) {
              puVar10 = *(uint32 **)(DAT_181d4f980 + 184);
              uVar11 = *puVar10;
              uVar12 = puVar10[1];
              uVar13 = puVar10[2];
              uVar14 = puVar10[3];
            }
            else {
              lVar7 = pStatics;
              uVar11 = *(uint32 *)(lVar7 + 16);
              uVar12 = *(uint32 *)(lVar7 + 20);
              uVar13 = *(uint32 *)(lVar7 + 24);
              uVar14 = *(uint32 *)(lVar7 + 28);
            }
          }
          else if (iVar5 == 7) {
            lVar8 = this.coverRenderer;
            lVar7 = FUN_18046bb80(0);
            if ((lVar7 == null) || (*(int64 *)(lVar7 + 0x110) == 0)) throw; // [null/range check failed]
            iVar5 = BattleUnit.GetSkillTargetType(*(int64 *)(lVar7 + 0x110),0);
            if (iVar5 == 0) {
              lVar7 = pStatics;
              uVar11 = *(uint32 *)(lVar7 + 64);
              uVar12 = *(uint32 *)(lVar7 + 68);
              uVar13 = *(uint32 *)(lVar7 + 72);
              uVar14 = *(uint32 *)(lVar7 + 76);
            }
            else {
              lVar7 = pStatics;
              uVar11 = *(uint32 *)(lVar7 + 96);
              uVar12 = *(uint32 *)(lVar7 + 100);
              uVar13 = *(uint32 *)(lVar7 + 104);
              uVar14 = *(uint32 *)(lVar7 + 108);
            }
          }
          else {
            if (iVar5 != 8) goto LAB_1808728b1;
            lVar8 = this.coverRenderer;
            lVar7 = FUN_18046bb80(0);
            if ((lVar7 == null) || (*(int64 *)(lVar7 + 0x110) == 0)) throw; // [null/range check failed]
            iVar5 = BattleUnit.GetSkillTargetType(*(int64 *)(lVar7 + 0x110),0);
            if (iVar5 == 0) {
              lVar7 = pStatics;
              uVar11 = *(uint32 *)(lVar7 + 80);
              uVar12 = *(uint32 *)(lVar7 + 84);
              uVar13 = *(uint32 *)(lVar7 + 88);
              uVar14 = *(uint32 *)(lVar7 + 92);
            }
            else {
              lVar7 = pStatics;
              uVar11 = *(uint32 *)(lVar7 + 112);
              uVar12 = *(uint32 *)(lVar7 + 116);
              uVar13 = *(uint32 *)(lVar7 + 120);
              uVar14 = *(uint32 *)(lVar7 + 124);
            }
          }
          if (lVar8 == null) throw; // [null/range check failed]
        }
        uStack_1c = uVar14;
        uStack_20 = uVar13;
        uStack_24 = uVar12;
        local_28 = uVar11;
        SpriteRenderer.set_color(lVar8,&local_28,0);
        lVar8 = this.backRenderer;
        if (this.gridData == null) throw; // [null/range check failed]
        if (this.gridData.gridType == 2) {
          lVar7 = pStatics;
          uVar11 = *(uint32 *)(lVar7 + 48);
          uVar12 = *(uint32 *)(lVar7 + 52);
          uVar13 = *(uint32 *)(lVar7 + 56);
          uVar14 = *(uint32 *)(lVar7 + 60);
        }
        else {
          uVar2 = this.showAttackDirectionRange;
          cVar4 = Object.op_Equality(uVar2,0,0);
          if (!cVar4) {
            lVar7 = *(int64 *)(pStatics + 176);
            if ((((this.showAttackDirectionRange == null) ||
                 (lVar9 = GameObject.GetComponent(this.showAttackDirectionRange,DAT_181d9f7f0),
                 lVar9 == null)) || (*(int64 *)(lVar9 + 24) == 0)) ||
               (lVar9 = *(int64 *)(*(int64 *)(lVar9 + 24) + 24)) == null)
            throw; // [null/range check failed]
            uVar6 = BattleUnit.GetAttackDirectionType(lVar9,this.gridData,0);
            if (lVar7 == null) throw; // [null/range check failed]
            if (*(uint32 *)(lVar7 + 24) <= uVar6) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            puVar10 = (uint32 *)(*(int64 *)(lVar7 + 16) + ((int64)(int)uVar6 + 2) * 16);
            uVar11 = *puVar10;
            uVar12 = puVar10[1];
            uVar13 = puVar10[2];
            uVar14 = puVar10[3];
          }
          else {
            puVar10 = (uint32 *)FUN_180d904c0(&local_28,0);
            uVar11 = *puVar10;
            uVar12 = puVar10[1];
            uVar13 = puVar10[2];
            uVar14 = puVar10[3];
          }
        }
        if (lVar8 != null) {
          local_28 = uVar11;
          uStack_24 = uVar12;
          uStack_20 = uVar13;
          uStack_1c = uVar14;
          SpriteRenderer.set_color(lVar8,&local_28,0);
          lVar8 = this.tileRenderer;
          if (this.gridData != null) {
            if (this.gridData.gridType == 2) {
              puVar10 = (uint32 *)FUN_180d904c0();
            }
            else {
              puVar10 = (uint32 *)FUN_181098a50(&local_28,0);
            }
            if (lVar8 != null) {
              local_28 = *puVar10;
              uStack_24 = puVar10[1];
              uStack_20 = puVar10[2];
              uStack_1c = puVar10[3];
              SpriteRenderer.set_color(lVar8,&local_28,0);
              lVar8 = this.lineRenderer;
              if (this.gridData != null) {
                if (this.gridData.gridType == 2) {
                  puVar10 = (uint32 *)FUN_180d904c0();
                }
                else {
                  puVar10 = (uint32 *)Color.get_black(&local_28,0);
                }
                if (lVar8 != null) {
                  local_28 = *puVar10;
                  uStack_24 = puVar10[1];
                  uStack_20 = puVar10[2];
                  uStack_1c = puVar10[3];
                  SpriteRenderer.set_color(lVar8,&local_28,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000C5F
    // RVA   : 0x873880   Offset: 0x872080   Length: 0x48D
    public void TriggerSpeObj()
    {
        bool cVar1;
        ulong uVar2;
        long lVar4;
        ulong uVar5;
        uVar2 = this.speGridObj;
        cVar1 = Object.op_Inequality(uVar2,0,0);
        if (!cVar1) {
          return;
        }
        if ((this.gridData != null) &&
           (lVar4 = this.gridData.speGridObjData) != null) {
          lVar4 = lVar4.tempRef;
          if ((lVar4 != null) && (cVar1 = String.op_Inequality(lVar4,"",0), cVar1)) {
            if ((this.gridData == null) ||
               (lVar4 = this.gridData.speGridObjData) == null)
            throw; // [null/range check failed]
            uVar2 = String.Concat("Sound/SoundEffect/",lVar4.tempRef,0);
            plVar3 = (int64 *)Resources.Load(uVar2,0);
            plVar6 = (int64 *)0;
            if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d8a228)) {
              plVar6 = plVar3;
            }
            NGUITools.PlaySound(plVar6,0x3f000000,0);
          }
          if (((this.speGridObj != null) &&
              (lVar4 = GameObject.GetComponent(this.speGridObj,DAT_181da1330)) != null)
             && (*(int64 *)(lVar4 + 192) != 0)) {
            *(uint32 *)(*(int64 *)(lVar4 + 192) + 108) = 0x3f800000;
            if (((this.speGridObj != null) &&
                (lVar4 = GameObject.GetComponent(this.speGridObj,DAT_181da1330), lVar4 != null
                )) && ((lVar4.battleUnit != null &&
                       (lVar4 = SkeletonDataAsset.GetSkeletonData(lVar4.battleUnit,1,0),
                       lVar4 != null)))) {
              lVar4 = SkeletonData.FindAnimation(lVar4,"trigger",0);
              if (lVar4 != null) {
                if (this.speGridObj == null) throw; // [null/range check failed]
                uVar2 = GameObject.get_transform(this.speGridObj,0);
                uVar2 = ShortcutExtensions.DOScale(uVar2,0x3f3bbbbc,0x3e4ccccd,0);
                TweenSettingsExtensions.SetLoops(uVar2,2,1,DAT_181d98060);
                if (((this.speGridObj == null) ||
                    (lVar4 = GameObject.GetComponent(this.speGridObj,DAT_181da1330),
                    lVar4 == null)) || (lVar4 = SkeletonAnimation.get_AnimationState(lVar4,0)) == null)
                throw; // [null/range check failed]
                AnimationState.SetAnimation(lVar4,1,"trigger",0,0);
                if ((this.gridData == null) ||
                   (lVar4 = this.gridData.speGridObjData) == null)
                throw; // [null/range check failed]
                if (!lVar4.column) {
                  if (((this.speGridObj == null) ||
                      (lVar4 = GameObject.GetComponent(this.speGridObj,DAT_181da1330),
                      lVar4 == null)) || (lVar4 = SkeletonAnimation.get_AnimationState(lVar4,0)) == null
                     ) throw; // [null/range check failed]
                  AnimationState.AddEmptyAnimation(lVar4,1,0x3dcccccd,0,0);
                }
              }
              lVar4 = this.gridData;
              if ((lVar4 != null) && (lVar4.speGridObjData != null)) {
                if (*(char *)(lVar4.speGridObjData + 40) != false) {
                  uVar2 = new SpeGridObjData(0);
                  lVar4.speGridObjData = uVar2;
                  if (this.speGridObj == null) throw; // [null/range check failed]
                  uVar2 = GameObject.get_transform(this.speGridObj,0);
                  uVar2 = ShortcutExtensions.DOLocalMoveZ
                                    (uVar2,*(uint32 *)(*(int64 *)(DAT_181d8b128 + 184) + 24),
                                     0x3e4ccccd,0,0);
                  uVar2 = TweenSettingsExtensions.SetLoops(uVar2,2,1,DAT_181d98060);
                  uVar2 = TweenSettingsExtensions.SetEase(uVar2,27,DAT_181d97ca8);
                  uVar5 = new OnTooltipCB(this,DAT_181d4ee90,0);
                  TweenSettingsExtensions.OnComplete(uVar2,uVar5,DAT_181d96ee8);
                }
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000C60
    // RVA   : 0x871DA0   Offset: 0x8705A0   Length: 0x612
    public void RefreshSpeObj()
    {
        var pStatics = *(int64*)(DAT_181d8b128 + 184);
        uint uVar2;
        bool cVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar7;
        long lVar8;
        ulong uVar10;
        float fVar11;
        ulong uVar12;
        uint[] local_res8 = new uint[2];
        float local_58;
        float fStack_54;
        float local_50;
        ulong local_48;
        float local_40;
        ulong local_38;
        float local_30;
        lVar7 = this.speGridObj;
        cVar3 = Object.op_Inequality(lVar7,0,0);
        if (cVar3) {
          lVar7 = *plVar1;
          Object.Destroy(lVar7,0);
        }
        if ((this.gridData == null) ||
           (lVar7 = this.gridData.speGridObjData) == null) throw; // [null/range check failed]
        if (*(int *)(lVar7 + 16) == 0) {
          return;
        }
        uVar4 = Component.get_gameObject(this,0);
        if ((this.gridData == null) ||
           (lVar7 = this.gridData.speGridObjData) == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        local_res8[0] = *(uint32 *)(lVar7 + 16);
        uVar5 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
        uVar5 = String.Format("Skeleton/Battle/SpeObj/{0}/skeleton_SkeletonData",uVar5,0);
        puVar6 = (uint64 *)Vector3.get_one(&local_58,0);
        local_48 = *puVar6;
        local_40 = *(float *)(puVar6 + 1);
        fStack_54 = (float)(local_48 >> 32) / 1.5;
        local_58 = (float)local_48 / 1.5;
        local_50 = local_40 / 1.5;
        local_38 = local_48;
        local_30 = local_40;
        if (**(int **)(DAT_181d4ef00 + 184) == 2) {
          if ((this.gridData == null) ||
             (lVar7 = this.gridData.speGridObjData) == null)
          throw; // [null/range check failed]
          uVar10 = "idle_check";
          if (*(int *)(lVar7 + 16) == 10)
          {
            }
            else {
          }
          uVar10 = "idle";
        }
        local_48 = CONCAT44(fStack_54,local_58);
        local_40 = local_50;
        lVar7 = GlobalData.GenerateSkeletonAnimation(uVar4,uVar5,&local_48,uVar10,1,0,0);
        if (lVar7 != null) {
          lVar7 = Component.get_gameObject(lVar7,0);
          *plVar1 = lVar7;
          il2cpp_internal(plVar1,lVar7);
          if ((this.gridData != null) &&
             (lVar7 = this.gridData.speGridObjData) != null) {
            if (*(char *)(lVar7 + 72) != false) {
              if (*plVar1 == 0) throw; // [null/range check failed]
              lVar7 = GameObject.get_transform(*plVar1,0);
              if ((*plVar1 == 0) || (lVar8 = GameObject.get_transform(*plVar1,0)) == null)
              throw; // [null/range check failed]
              pfVar9 = (float *)Transform.get_localScale(&local_38,lVar8,0);
              fVar11 = *pfVar9;
              if ((*plVar1 == 0) || (lVar8 = GameObject.get_transform(*plVar1,0)) == null)
              throw; // [null/range check failed]
              puVar6 = (uint64 *)Transform.get_localScale(&local_38,lVar8,0);
              local_48 = *puVar6;
              if ((*plVar1 == 0) || (lVar8 = GameObject.get_transform(*plVar1,0)) == null)
              throw; // [null/range check failed]
              puVar6 = (uint64 *)Transform.get_localScale(&local_58,lVar8,0);
              local_58 = -fVar11;
              local_38 = *puVar6;
              local_50 = *(float *)(puVar6 + 1);
              fStack_54 = local_48._4_4_;
              local_30 = local_50;
              if (lVar7 == null) throw; // [null/range check failed]
              local_38 = CONCAT44(local_48._4_4_,fVar11) ^ 0x80000000;
              Transform.set_localScale(lVar7,&local_38,0);
            }
            if (*plVar1 != 0) {
              lVar7 = GameObject.get_transform(*plVar1,0);
              if ((this.gridData != null) &&
                 (lVar8 = this.gridData.speGridObjData) != null) {
                if (*(char *)(lVar8 + 60) == false) {
                  if (*(char *)(lVar8 + 61) == false) {
                    local_38 = *(uint64 *)(pStatics + 28);
                    fVar11 = *(float *)(pStatics + 36) + 0.0001;
                    uVar12 = CONCAT44((float)(local_38 >> 32) + 0.0,(float)local_38 + 0.0);
                    local_30 = fVar11;
                  }
                  else {
                    local_30 = -0.0001;
                    uVar12 = 0;
                    fVar11 = local_30;
                  }
                }
                else {
                  uVar12 = *(uint64 *)(pStatics + 16);
                  fVar11 = *(float *)(pStatics + 24);
                }
                if (lVar7 != null) {
                  local_38 = uVar12;
                  local_30 = fVar11;
                  Transform.set_localPosition(lVar7,&local_38,0);
                  if ((this.gridData != null) &&
                     (lVar7 = this.gridData.speGridObjData) != null) {
                    if (*(int *)(lVar7 + 48) == -1) {
                      return;
                    }
                    lVar7 = FUN_18046bb80(0);
                    if ((((lVar7 != null) && (this.gridData != null)) &&
                        (lVar8 = this.gridData.speGridObjData) != null) &&
                       (lVar7 = *(int64 *)(lVar7 + 112)) != null) {
                      uVar2 = *(uint32 *)(lVar8 + 48);
                      if (*(uint32 *)(lVar7 + 24) <= uVar2) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar7 = lVar7[uVar2]
                      ;
                      if (lVar7 != null) {
                        lVar8 = *plVar1;
                        if (*(char *)(lVar7 + 20) == false) {
                          if (((lVar8 != null) &&
                              (lVar7 = GameObject.GetComponent(lVar8,DAT_181da1330)) != null) &&
                             (*(int64 *)(lVar7 + 192) != 0)) {
                            *(uint32 *)(*(int64 *)(lVar7 + 192) + 108) = 0;
                            return;
                          }
                        }
                        else if (((lVar8 != null) &&
                                 (lVar7 = GameObject.GetComponent(lVar8,DAT_181da1330)) != null) &&
                                (*(int64 *)(lVar7 + 192) != 0)) {
                          *(uint32 *)(*(int64 *)(lVar7 + 192) + 108) = 0x3f000000;
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

    // Token : 0x6000C61
    // RVA   : 0x86F9C0   Offset: 0x86E1C0   Length: 0x93
    public void DestroyObstacle()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = this.obstacleObj;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          uVar1 = this.obstacleObj;
          Object.Destroy(uVar1,0);
        }
    }

    // Token : 0x6000C62
    // RVA   : 0x870EF0   Offset: 0x86F6F0   Length: 0x7D8
    public void InitObstacle()
    {
        var pStatics = *(int64*)(DAT_181d8b128 + 184);
        int iVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        ulong uVar5;
        ulong uVar6;
        ulong uVar7;
        long lVar9;
        ulong uVar10;
        ulong uVar11;
        uint uVar12;
        float fVar13;
        float fVar14;
        float fVar15;
        float fVar16;
        float fVar17;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[4];
        ulong local_88;
        ulong local_78;
        float local_70;
        ulong local_68;
        float local_60;
        byte[] local_58 = new byte[32];
        lVar9 = this.gridData;
        if (lVar9 != null) {
          if (lVar9.gridType != 2) {
            return;
          }
          if (lVar9.obstale != null) {
            lVar4 = ObstacleData.GetBaseGridUnitData(lVar9.obstale,0);
            lVar9 = this.gridData;
            if (lVar4 != lVar9) {
              return;
            }
            if ((lVar9 != null) && (lVar9.obstale != null)) {
              iVar1 = *(int *)(lVar9.obstale + 16);
              uVar12 = 0;
              if (iVar1 == 0) {
                uVar5 = Component.get_gameObject(this,0);
                if ((this.gridData == null) ||
                   (lVar9 = this.gridData.obstale) == null)
                throw; // [null/range check failed]
                uVar7 = lVar9.battleUnit;
                uVar6 = Int32.ToString(lVar9 + 32,0);
                uVar7 = String.Concat(uVar7,"_",uVar6,0);
                uVar7 = String.Format("Skeleton/Battle/Obstacle/{0}/skeleton_SkeletonData",uVar7,0);
                if ((this.gridData == null) ||
                   (lVar9 = this.gridData.obstale) == null)
                throw; // [null/range check failed]
                if (!lVar9.obstale) {
                  puVar8 = (uint64 *)Vector3.get_one(local_58,0);
                  local_70 = *(float *)(puVar8 + 1);
                  fVar15 = (float)*puVar8;
                  fVar16 = (float)((uint64)*puVar8 >> 32);
                  fVar14 = fVar16 / 1.9;
                  fVar17 = fVar15 / 1.9;
                  fVar13 = local_70 / 1.9;
                }
                else {
                  puVar8 = (uint64 *)Vector3.get_one(local_58,0);
                  local_70 = *(float *)(puVar8 + 1);
                  fVar15 = (float)*puVar8;
                  fVar16 = (float)((uint64)*puVar8 >> 32);
                  fVar14 = fVar16 * 0.7;
                  fVar17 = fVar15 * 0.7;
                  fVar13 = local_70 * 0.7;
                }
                local_68 = CONCAT44(fVar16,fVar15);
                local_78 = CONCAT44(fVar16,fVar15);
                local_60 = fVar13;
                local_78 = CONCAT44(fVar14,fVar17);
                local_70 = fVar13;
                lVar9 = GlobalData.GenerateSkeletonAnimation(uVar5,uVar7,&local_78,"idle",1,0,0);
                if (lVar9 == null) throw; // [null/range check failed]
                uVar5 = Component.get_gameObject(lVar9,0);
                this.obstacleObj = uVar5;
                if (this.obstacleObj == null) throw; // [null/range check failed]
                lVar9 = GameObject.get_transform(this.obstacleObj,0);
                if ((this.gridData == null) ||
                   (lVar4 = this.gridData.obstale) == null)
                throw; // [null/range check failed]
                if (*(char *)(lVar4 + 48) == false) {
                  puVar8 = (uint64 *)Vector3.get_zero(local_58,0);
                  local_88 = *puVar8;
                  fVar13 = *(float *)(puVar8 + 1);
                }
                else {
                  local_60 = 0.0;
                  fVar13 = 0.0;
                  local_88 = 0x3f0000003f000000;
                }
                local_68 = *(uint64 *)(pStatics + 28);
                local_60 = *(float *)(pStatics + 36);
                local_70 = fVar13 + local_60;
                local_78 = CONCAT44(local_88._4_4_ + (float)((uint64)local_68 >> 32),
                                    (float)local_88 + (float)local_68);
                if (lVar9 == null) throw; // [null/range check failed]
                local_68 = local_78;
                local_60 = local_70;
                Transform.set_localPosition(lVar9,&local_68,0);
              }
              else if (iVar1 == 1) {
                uVar5 = Component.get_gameObject(this,0);
                puVar8 = (uint64 *)Vector3.get_one(&local_78,0);
                local_68 = *puVar8;
                local_60 = *(float *)(puVar8 + 1);
                local_70 = local_60 / 1.5;
                local_78 = CONCAT44((float)((uint64)local_68 >> 32) / 1.5,(float)local_68 / 1.5);
                lVar9 = FUN_18046bb80(0);
                uVar3 = "Skeleton/Battle/Wall/skeleton_SkeletonData";
                uVar6 = "wall{0}_{1}";
                uVar7 = "idle";
                if (((lVar9 == null) || (lVar9.battleUnit == null)) ||
                   (lVar9 = *(int64 *)(lVar9.battleUnit + 24)) == null)
                throw; // [null/range check failed]
                if (lVar9.passes == null) {
                  local_res8[0] = 1;
                }
                else {
                  lVar9 = FUN_18046bb80(0);
                  if (((lVar9 == null) || (lVar9.battleUnit == null)) ||
                     ((lVar9 = *(int64 *)(lVar9.battleUnit + 24), lVar9 == null ||
                      (lVar9 = lVar9.passes) == null))) throw; // [null/range check failed]
                  local_res8[0] = *(uint32 *)(lVar9 + 72);
                }
                uVar10 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
                lVar9 = FUN_18046bb80(0);
                if ((lVar9 == null) || (lVar9.battleUnit == null)) {
        LAB_1808716c3:
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                fVar13 = (float)BattleMapData.GetAreaWallSkinLv(lVar9.battleUnit,0);
                local_res18[0] = Mathf.Clamp((int)(fVar13 / 3.0),0,3);
                uVar11 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
                uVar6 = String.Format(uVar6,uVar10,uVar11,0);
                local_68 = local_78;
                local_60 = local_70;
                lVar9 = GlobalData.GenerateSkeletonAnimation(uVar5,uVar3,&local_68,uVar7,1,uVar6,0);
                if (lVar9 == null) goto LAB_1808716c3;
                uVar5 = Component.get_gameObject(lVar9,0);
                this.obstacleObj = uVar5;
                if (this.obstacleObj == null) goto LAB_1808716c3;
                lVar9 = GameObject.get_transform(this.obstacleObj,0);
                fVar13 = *(float *)(pStatics + 36);
                uVar5 = *(uint64 *)(pStatics + 28);
                puVar8 = (uint64 *)Vector3.get_forward(&local_78,0);
                local_68 = *puVar8;
                local_60 = *(float *)(puVar8 + 1);
                local_78 = CONCAT44((float)((uint64)local_68 >> 32) * 0.0005 +
                                    (float)((uint64)uVar5 >> 32),
                                    (float)local_68 * 0.0005 + (float)uVar5);
                local_70 = local_60 * 0.0005 + fVar13;
                if (lVar9 == null) goto LAB_1808716c3;
                local_68 = local_78;
                local_60 = local_70;
                Transform.set_localPosition(lVar9,&local_68,0);
                GridUnitController.SetWallBroken(this,0);
              }
              lVar9 = this.gridData;
              if (lVar9 != null) {
                lVar4 = 32;
                while ((lVar9.obstale != null &&
                       (lVar2 = *(int64 *)(lVar9.obstale + 56)) != null)) {
                  if (*(int *)(lVar2 + 24) <= (int)uVar12) {
                    return;
                  }
                  if (((lVar9 == null) || (lVar9.obstale == null)) ||
                     (lVar9 = *(int64 *)(lVar9.obstale + 56)) == null) break;
                  if (lVar9.battleUnit <= uVar12) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar9 = *(int64 *)(lVar4 + lVar9.mapID);
                  if ((lVar9 == null) || (lVar9 = GridUnitData.get_GridObj(lVar9,0)) == null) break;
                  lVar9 = GameObject.GetComponent(lVar9,DAT_181d9f7f0);
                  if (lVar9 == null) break;
                  lVar9.passes = this.obstacleObj;
                  lVar9 = this.gridData;
                  uVar12 = uVar12 + 1;
                  lVar4 = lVar4 + 8;
                  if (lVar9 == null) break;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000C63
    // RVA   : 0x872B30   Offset: 0x871330   Length: 0x59F
    public void ReinitDecoration()
    {
        uint uVar1;
        int iVar2;
        ulong uVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar7;
        long lVar8;
        long lVar9;
        int iVar11;
        float fVar12;
        float fVar13;
        float fVar14;
        uint[] local_res8 = new uint[2];
        float local_1a8;
        float local_1a4;
        uint32 local_1a0;
        uint64 local_198;
        uint64 uStack_190;
        uint64 local_188;
        float local_178;
        uint64 local_168;
        float local_160;
        uint64 local_158;
        uint32 local_150;
        uint64 local_148;
        uint32 local_140;
        uint64 local_138;
        uint32 local_130;
        uint8 local_120 [16];
        uint8 local_110 [16];
        uint8 local_100 [16];
        uint8 local_f0 [16];
        uint8 local_e0 [16];
        uint8 local_d0 [168];
        uVar4 = this.decorations;
        local_198 = 0;
        uStack_190 = 0;
        local_188 = 0;
        GlobalData.DestroyAll(uVar4,0);
        if ((this.gridData != null) &&
           (lVar7 = this.gridData.speGridObjData) != null) {
          if (*(int *)(lVar7 + 16) == 0) {
            iVar2 = FUN_180d8cf10(0xfffffff5);
            iVar11 = 0;
            if (0 < iVar2) {
              do {
                uVar3 = Component.get_gameObject(this,0);
                local_res8[0] = FUN_180d8cf10(0,4);
                uVar4 = Int32.ToString(local_res8,0);
                uVar5 = String.Concat("Skeleton/Battle/Plane/装饰_",uVar4,"/skeleton_SkeletonData",0);
                puVar6 = (uint64 *)Vector3.get_one(local_120,0);
                local_178 = *(float *)(puVar6 + 1);
                uVar4 = *puVar6;
                fVar12 = (float)Random.Range(0x3f333333,0x3f99999a,0);
                fVar13 = local_178 * fVar12;
                local_168 = CONCAT44(((float)((uint64)uVar4 >> 32) * fVar12) / 1.9,
                                     ((float)uVar4 * fVar12) / 1.9);
                local_160 = fVar13 / 1.9;
                lVar7 = GlobalData.GenerateSkeletonAnimation(uVar3,uVar5,&local_168,"idle",1,0,0);
                if ((lVar7 == null) || (lVar7 = Component.get_gameObject(lVar7,0)) == null)
                throw; // [null/range check failed]
                lVar8 = GameObject.get_transform(lVar7,0);
                lVar9 = Component.GetComponent(this,DAT_181d6d540);
                if ((lVar9 == null) || (lVar9 = SpriteRenderer.get_sprite(lVar9,0)) == null)
                throw; // [null/range check failed]
                puVar6 = (uint64 *)Sprite.get_bounds(&local_138,lVar9,0);
                local_198 = *puVar6;
                uStack_190 = puVar6[1];
                local_188 = puVar6[2];
                pfVar10 = (float *)Bounds.get_size(local_110,&local_198,0);
                fVar12 = *pfVar10;
                fVar13 = (float)Random.Range(0xbf000000,0x3f000000,0);
                lVar9 = Component.GetComponent(this,DAT_181d6d540);
                if ((lVar9 == null) || (lVar9 = SpriteRenderer.get_sprite(lVar9,0)) == null)
                throw; // [null/range check failed]
                puVar6 = (uint64 *)Sprite.get_bounds(&local_138,lVar9,0);
                local_198 = *puVar6;
                uStack_190 = puVar6[1];
                local_188 = puVar6[2];
                puVar6 = (uint64 *)Bounds.get_size(local_100,&local_198,0);
                uVar4 = *puVar6;
                local_130 = *(uint32 *)(puVar6 + 1);
                fVar14 = (float)Random.Range(0xbf000000,0x3f000000,0);
                local_138 = uVar4;
                if (lVar8 == null) throw; // [null/range check failed]
                local_1a0 = 0;
                local_1a8 = fVar13 * fVar12;
                local_1a4 = fVar14 * (float)((uint64)uVar4 >> 32);
                Transform.set_localPosition(lVar8,&local_1a8,0);
                lVar8 = GameObject.get_transform(lVar7,0);
                lVar9 = GameObject.get_transform(lVar7,0);
                if (lVar9 == null) throw; // [null/range check failed]
                puVar6 = (uint64 *)Transform.get_localPosition(local_f0,lVar9,0);
                uVar4 = *puVar6;
                uVar1 = *(uint32 *)(puVar6 + 1);
                fVar12 = *(float *)(*(int64 *)(DAT_181d8b128 + 184) + 48);
                lVar7 = GameObject.get_transform(lVar7,0);
                if (lVar7 == null) throw; // [null/range check failed]
                puVar6 = (uint64 *)Transform.get_localPosition(local_e0,lVar7,0);
                local_138 = *puVar6;
                local_130 = *(uint32 *)(puVar6 + 1);
                local_158 = uVar4;
                local_150 = uVar1;
                puVar6 = (uint64 *)
                         GlobalData.SetZ(local_d0,&local_158,
                                          (float)((uint64)local_138 >> 32) * 0.001 + fVar12);
                if (lVar8 == null) throw; // [null/range check failed]
                local_148 = *puVar6;
                local_140 = *(uint32 *)(puVar6 + 1);
                Transform.set_localPosition(lVar8,&local_148,0);
                if (this.decorations == null) throw; // [null/range check failed]
                FUN_181827900();
                iVar11 = iVar11 + 1;
              } while (iVar11 < iVar2);
            }
          }
          return;
        }
    }

    // Token : 0x6000C64
    // RVA   : 0x871880   Offset: 0x870080   Length: 0x1E4
    public void OnHit(BattleUnit nowActiveUnit)
    {
        long lVar1;
        int iVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        float fVar6;
        if (this.gridData != null) {
          if (this.gridData.gridType != 2) {
        LAB_180871a3b:
            GridUnitController.PlaySpeObjHitAnim(this,0);
            return;
          }
          if (nowActiveUnit != null) {
            iVar2 = BattleUnit.GetSkillTargetType(nowActiveUnit,0);
            if (iVar2 != 0) goto LAB_180871a3b;
            if (((*(int64 *)(nowActiveUnit + 88) != 0) &&
                (lVar3 = this.gridData) != null) && (*(int64 *)(lVar3 + 48) != 0)
               ) {
              if (*(int *)(*(int64 *)(nowActiveUnit + 88) + 16) ==
                  *(int *)(*(int64 *)(lVar3 + 48) + 44)) goto LAB_180871a3b;
              lVar3 = GridUnitData.get_GridObj(lVar3,0);
              if (lVar3 != null) {
                lVar3 = GameObject.GetComponent(lVar3,DAT_181d9f7f0);
                lVar4 = FUN_18046bb80(0);
                lVar1 = *(int64 *)(nowActiveUnit + 64);
                if (lVar1 != null) {
                  iVar2 = *(int *)(lVar1 + 0x2a8);
                  if (iVar2 < 3) {
                    if (iVar2 == 0) {
                      uVar5 = *(uint64 *)(lVar1 + 0x270);
                    }
                    else if (iVar2 == 1) {
                      uVar5 = *(uint64 *)(lVar1 + 0x280);
                    }
                    else if (iVar2 == 2) {
                      uVar5 = *(uint64 *)(lVar1 + 0x290);
                    }
                    else {
                      uVar5 = 0;
                    }
                  }
                  else {
                    lVar1 = *(int64 *)(lVar1 + 0x2a0);
                    if (lVar1 == null) throw; // [null/range check failed]
                    if (*(uint32 *)(lVar1 + 24) <= iVar2 - 3U) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    uVar5 = *(uint64 *)(*(int64 *)(lVar1 + 16) + 8 + (int64)iVar2 * 8);
                  }
                  if (lVar4 != null) {
                    fVar6 = (float)BattleController.CountBaseDamage(lVar4,nowActiveUnit,uVar5,0,0,0);
                    if (lVar3 != null) {
                      GridUnitController.HitObstacle(lVar3,fVar6 * 0.5,0);
                      goto LAB_180871a3b;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000C65
    // RVA   : 0x871870   Offset: 0x870070   Length: 0x7
    public void OnEnter()
    {
        void FUN_180871870(uint64 this)
        {
        GridUnitController.PlaySpeObjHitAnim(this,0);
    }

    // Token : 0x6000C66
    // RVA   : 0x871870   Offset: 0x870070   Length: 0x7
    public void OnLeave()
    {
        void FUN_180871870(uint64 this)
        {
        GridUnitController.PlaySpeObjHitAnim(this,0);
    }

    // Token : 0x6000C67
    // RVA   : 0x871B30   Offset: 0x870330   Length: 0x265
    public void PlaySpeObjHitAnim()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uVar3 = this.speGridObj;
        cVar1 = Object.op_Inequality(uVar3,0,0);
        if (!cVar1) {
          return;
        }
        if ((((this.speGridObj != null) &&
             (lVar2 = GameObject.GetComponent(this.speGridObj,DAT_181da1330)) != null)
            && (*(int64 *)(lVar2 + 24) != 0)) &&
           (lVar2 = SkeletonDataAsset.GetSkeletonData(*(int64 *)(lVar2 + 24),1,0)) != null) {
          lVar2 = SkeletonData.FindAnimation(lVar2,"hit",0);
          if (lVar2 == null) {
            return;
          }
          if (((this.speGridObj != null) &&
              (lVar2 = GameObject.GetComponent(this.speGridObj,DAT_181da1330)) != null)
             && (lVar2 = SkeletonAnimation.get_AnimationState(lVar2,0)) != null) {
            AnimationState.SetAnimation(lVar2,1,"hit",0,0);
            if (((this.speGridObj != null) &&
                (lVar2 = GameObject.GetComponent(this.speGridObj,DAT_181da1330), lVar2 != null
                )) && (lVar2 = SkeletonAnimation.get_AnimationState(lVar2,0)) != null) {
              AnimationState.AddEmptyAnimation(lVar2,1,0x3dcccccd,0,0);
              if ((this.gridData != null) &&
                 (lVar2 = this.gridData.speGridObjData) != null) {
                lVar2 = *(int64 *)(lVar2 + 64);
                if ((lVar2 != null) && (cVar1 = String.op_Inequality(lVar2,"",0), cVar1))
                {
                  if ((this.gridData == null) ||
                     (lVar2 = this.gridData.speGridObjData) == null)
                  throw; // [null/range check failed]
                  uVar3 = String.Concat("Sound/SoundEffect/",*(uint64 *)(lVar2 + 64),0);
                  plVar4 = (int64 *)Resources.Load(uVar3,0);
                  plVar5 = (int64 *)0;
                  if ((plVar4 != (int64 *)0) && (*plVar4 == DAT_181d8a228)) {
                    plVar5 = plVar4;
                  }
                  NGUITools.PlaySound(plVar5,0x3ecccccd,0);
                }
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000C68
    // RVA   : 0x873640   Offset: 0x871E40   Length: 0x235
    public void SetWallBroken()
    {
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        ulong uVar4;
        float fVar5;
        uint[] local_res8 = new uint[2];
        uint[] local_res18 = new uint[2];
        if ((this.gridData != null) &&
           (lVar1 = this.gridData.obstale) != null) {
          fVar5 = *(float *)(lVar1 + 36) / *(float *)(lVar1 + 40);
          if ((0.8 < fVar5) || (fVar5 <= 0.0)) {
            uVar4 = 0;
          }
          else {
            lVar1 = FUN_18046bb80(0);
            uVar4 = "wall{0}_{1}";
            if (((lVar1 == null) || (*(int64 *)(lVar1 + 24) == 0)) ||
               (lVar1 = *(int64 *)(*(int64 *)(lVar1 + 24) + 24)) == null)
            throw; // [null/range check failed]
            if (*(int64 *)(lVar1 + 32) == 0) {
              local_res8[0] = 1;
            }
            else {
              lVar1 = FUN_18046bb80(0);
              if (((lVar1 == null) || (*(int64 *)(lVar1 + 24) == 0)) ||
                 ((lVar1 = *(int64 *)(*(int64 *)(lVar1 + 24) + 24), lVar1 == null ||
                  (lVar1 = *(int64 *)(lVar1 + 32)) == null))) throw; // [null/range check failed]
              local_res8[0] = *(uint32 *)(lVar1 + 72);
            }
            uVar2 = il2cpp_value_box(DAT_181d5b2f8,local_res8);
            if ((this.gridData == null) ||
               (lVar1 = this.gridData.obstale) == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            local_res18[0] =
                 Mathf.Clamp(~(int)((1.0 - *(float *)(lVar1 + 36) / *(float *)(lVar1 + 40)) * -5.0),0
                              ,3);
            uVar3 = il2cpp_value_box(DAT_181d5b2f8,local_res18);
            uVar4 = String.Format(uVar4,uVar2,uVar3,0);
          }
          if (this.obstacleObj != null) {
            lVar1 = GameObject.GetComponent(this.obstacleObj,DAT_181da1330);
            if ((lVar1 != null) && (*(int64 *)(lVar1 + 192) != 0)) {
              Skeleton.SetAttachment(*(int64 *)(lVar1 + 192),"broken",uVar4,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000C69
    // RVA   : 0x86FD00   Offset: 0x86E500   Length: 0x11E0
    public void HitObstacle(float damage)
    {
        var pStatics = *(int64*)(DAT_181d8b128 + 184);
        float fVar1;
        uint uVar2;
        bool cVar3;
        long lVar4;
        ulong uVar5;
        long lVar7;
        long lVar8;
        ulong uVar9;
        uint uVar11;
        long lVar14;
        long lVar15;
        float fVar16;
        int[] local_res8 = new int[2];
        ulong in_stack_ffffffffffffff58;
        ulong local_98;
        float local_90;
        ulong local_88;
        float local_80;
        byte[] local_78 = new byte[16];
        byte[] local_68 = new byte[64];
        plVar13 = (int64 *)0;
        local_res8[0] = 0;
        if ((this.gridData != null) &&
           (lVar4 = this.gridData.obstale) != null) {
          if (lVar4.row < 0.0) {
            return;
          }
          lVar4.row = lVar4.row - damage;
          if ((this.gridData != null) &&
             (lVar4 = this.gridData.obstale) != null) {
            if (lVar4.mapID == 1) {
              uVar5 = Component.get_gameObject(this,0);
              plVar6 = (int64 *)Resources.Load("SpeEffect/DirtSplash",0);
              uVar9 = *(uint64 *)(pStatics + 16);
              uVar2 = *(uint32 *)(pStatics + 24);
              plVar12 = plVar13;
              if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181d4e110)) {
                plVar12 = plVar6;
              }
              local_98 = uVar9;
              local_90 = (float)uVar2;
              GlobalData.AddChild(uVar5,plVar12,&local_98,0);
              GridUnitController.SetWallBroken(this,0);
            }
            else {
              lVar4 = ObstacleData.GetObstacleDataBase();
              if (lVar4 == null) throw; // [null/range check failed]
              if (lVar4.tempRef != null) {
                if (((this.gridData == null) ||
                    (lVar4 = this.gridData.obstale) == null) ||
                   (lVar4 = ObstacleData.GetObstacleDataBase(lVar4,0)) == null) throw; // [null/range check failed]
                cVar3 = String.op_Inequality(lVar4.tempRef,"",0);
                if (cVar3) {
                  if (((this.gridData == null) ||
                      (lVar4 = this.gridData.obstale) == null) ||
                     (lVar4 = ObstacleData.GetObstacleDataBase(lVar4,0)) == null) throw; // [null/range check failed]
                  uVar5 = String.Concat("Sound/SoundEffect/",lVar4.tempRef,0);
                  plVar6 = (int64 *)Resources.Load(uVar5,0);
                  plVar12 = plVar13;
                  if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181d8a228)) {
                    plVar12 = plVar6;
                  }
                  NGUITools.PlaySound(plVar12,0);
                }
              }
            }
            if ((this.gridData != null) &&
               (lVar4 = this.gridData.obstale) != null) {
              if (0.0 < lVar4.row) {
                if (this.obstacleObj != null) {
                  uVar5 = GameObject.GetComponent(this.obstacleObj,DAT_181da1330);
                  cVar3 = Object.op_Inequality(uVar5,0,0);
                  if (!cVar3) {
                    return;
                  }
                  if ((((this.obstacleObj != null) &&
                       (lVar4 = GameObject.GetComponent(this.obstacleObj,DAT_181da1330),
                       lVar4 != null)) && (lVar4.battleUnit != null)) &&
                     (lVar4 = SkeletonDataAsset.GetSkeletonData(lVar4.battleUnit,1,0),
                     lVar4 != null)) {
                    lVar4 = SkeletonData.FindAnimation(lVar4,"hit",0);
                    if (lVar4 == null) {
                      return;
                    }
                    if (((this.obstacleObj != null) &&
                        (lVar4 = GameObject.GetComponent(this.obstacleObj,DAT_181da1330),
                        lVar4 != null)) &&
                       (lVar4 = SkeletonAnimation.get_AnimationState(lVar4,0)) != null) {
                      AnimationState.SetAnimation(lVar4,1,"hit",0,0);
                      if (((this.obstacleObj != null) &&
                          (lVar4 = GameObject.GetComponent(this.obstacleObj,DAT_181da1330),
                          lVar4 != null)) &&
                         (lVar4 = SkeletonAnimation.get_AnimationState(lVar4,0)) != null) {
                        AnimationState.AddEmptyAnimation(lVar4,1,0x3e4ccccd,0,0);
                        return;
                      }
                    }
                  }
                }
              }
              else {
                lVar15 = 32;
                if (*(char *)(lVar4 + 66) != false) {
                  lVar4 = GridUnitController.GetAroundObstacleGrid(this,0);
                  if (lVar4 == null) throw; // [null/range check failed]
                  lVar14 = 32;
                  plVar6 = plVar13;
                  while( true ) {
                    uVar11 = (uint32)plVar6;
                    if ((int)lVar4.battleUnit <= (int)uVar11) break;
                    if (lVar4.battleUnit <= uVar11) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar7 = *(int64 *)(lVar14 + lVar4.mapID);
                    if (lVar7 == null) throw; // [null/range check failed]
                    uVar5 = *(uint64 *)(lVar7 + 24);
                    cVar3 = Object.op_Inequality(uVar5);
                    if (!cVar3) {
        LAB_1808703fb:
                      plVar6 = (int64 *)(uint64)(uVar11 + 1);
                      lVar14 = lVar14 + 8;
                    }
                    else {
                      lVar7 = FUN_180002f80(lVar4,plVar6,DAT_181d63bf8);
                      if (lVar7 == null) throw; // [null/range check failed]
                      lVar7 = *(int64 *)(lVar7 + 24);
                      if ((this.gridData == null) ||
                         (lVar8 = this.gridData.obstale) == null)
                      throw; // [null/range check failed]
                      fVar16 = (float)ObstacleData.GetExtraExplodeRate(lVar8,0);
                      if ((this.gridData == null) ||
                         ((lVar8 = this.gridData.obstale, lVar8 == null ||
                          (lVar8 = ObstacleData.GetObstacleDataBase(lVar8,0)) == null)))
                      throw; // [null/range check failed]
                      fVar1 = *(float *)(lVar8 + 88);
                      lVar8 = FUN_180002f80(lVar4,plVar6);
                      if ((lVar8 == null) ||
                         (((*(int64 *)(lVar8 + 24) == 0 ||
                           (lVar8 = *(int64 *)(*(int64 *)(lVar8 + 24) + 64)) == null) ||
                          (lVar7 == null)))) throw; // [null/range check failed]
                      in_stack_ffffffffffffff58 = in_stack_ffffffffffffff58 & 0xffffffffffffff00;
                      BattleUnit.ChangeHp
                                (lVar7,-fVar16 * fVar1 * *(float *)(lVar8 + 0x17c),0,1,
                                 in_stack_ffffffffffffff58,0);
                      if (((this.gridData == null) ||
                          (this.gridData.obstale == null)) ||
                         (lVar7 = ObstacleData.GetObstacleDataBase()) == null) throw; // [null/range check failed]
                      local_res8[0] = *(int *)(lVar7 + 92);
                      if (local_res8[0] == 0) {
                        lVar7 = FUN_180002f80(lVar4,plVar6,DAT_181d63bf8);
                        if (lVar7 != null) {
                          lVar7 = *(int64 *)(lVar7 + 24);
                          if ((this.gridData != null) &&
                             (this.gridData.obstale != null)) {
                            fVar16 = (float)ObstacleData.GetExtraExplodeRate();
                            if ((this.gridData != null) &&
                               (((this.gridData.obstale != null &&
                                 (lVar8 = ObstacleData.GetObstacleDataBase()) != null) &&
                                (lVar7 != null)))) {
                              in_stack_ffffffffffffff58 = 0;
                              BattleUnit.ChangeExternalInjury
                                        (lVar7,fVar16 * *(float *)(lVar8 + 96),1,0,0);
                              goto LAB_1808703fb;
                            }
                          }
                        }
                        throw; // [null/range check failed]
                      }
                      if (local_res8[0] == 1) {
                        lVar7 = FUN_180002f80(lVar4,plVar6,DAT_181d63bf8);
                        if (lVar7 == null) throw; // [null/range check failed]
                        lVar7 = *(int64 *)(lVar7 + 24);
                        if ((this.gridData == null) ||
                           (this.gridData.obstale == null)) throw; // [null/range check failed]
                        fVar16 = (float)ObstacleData.GetExtraExplodeRate();
                        if (((this.gridData == null) ||
                            ((this.gridData.obstale == null ||
                             (lVar8 = ObstacleData.GetObstacleDataBase()) == null))) || (lVar7 == null))
                        throw; // [null/range check failed]
                        in_stack_ffffffffffffff58 = 0;
                        BattleUnit.ChangeInternalInjury(lVar7,fVar16 * *(float *)(lVar8 + 96),1,0,0);
                        plVar6 = (int64 *)(uint64)(uVar11 + 1);
                        lVar14 = lVar14 + 8;
                      }
                      else {
                        if (local_res8[0] != 2) goto LAB_1808703fb;
                        lVar7 = FUN_180002f80(lVar4,plVar6,DAT_181d63bf8);
                        if (lVar7 == null) throw; // [null/range check failed]
                        lVar7 = *(int64 *)(lVar7 + 24);
                        if ((this.gridData == null) ||
                           (this.gridData.obstale == null)) throw; // [null/range check failed]
                        fVar16 = (float)ObstacleData.GetExtraExplodeRate();
                        if ((this.gridData == null) ||
                           (((this.gridData.obstale == null ||
                             (lVar8 = ObstacleData.GetObstacleDataBase()) == null) || (lVar7 == null))))
                        throw; // [null/range check failed]
                        in_stack_ffffffffffffff58 = 0;
                        BattleUnit.ChangePoisonInjury(lVar7,fVar16 * *(float *)(lVar8 + 96),1,0,0);
                        plVar6 = (int64 *)(uint64)(uVar11 + 1);
                        lVar14 = lVar14 + 8;
                      }
                    }
                  }
                }
                if ((this.gridData != null) &&
                   (lVar4 = this.gridData.obstale) != null) {
                  if (lVar4.mapID == 1) {
                    uVar5 = Component.get_gameObject(this,0);
                    plVar6 = (int64 *)Resources.Load("SpeEffect/DirtSplash",0);
                    uVar9 = *(uint64 *)(pStatics + 16);
                    uVar2 = *(uint32 *)(pStatics + 24);
                    puVar10 = (uint64 *)Vector3.get_one(local_68,0);
                    local_88 = *puVar10;
                    local_80 = *(float *)(puVar10 + 1);
                    local_90 = local_80 * 1.5;
                    local_98 = CONCAT44((float)((uint64)local_88 >> 32) * 1.5,(float)local_88 * 1.5);
                    local_88 = local_98;
                    local_80 = local_90;
                    plVar12 = plVar13;
                    if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181d4e110)) {
                      plVar12 = plVar6;
                    }
                    local_98 = uVar9;
                    local_90 = (float)uVar2;
                    GlobalData.AddChild(uVar5,plVar12,&local_98,&local_88,0);
                    plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/TearDown",0);
                    plVar12 = plVar13;
                    if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181d8a228)) {
                      plVar12 = plVar6;
                    }
                    NGUITools.PlaySound(plVar12,0);
                    GridUnitController.SetWallBroken(this,0);
                  }
                  else {
                    lVar4 = ObstacleData.GetObstacleDataBase();
                    if (lVar4 == null) throw; // [null/range check failed]
                    cVar3 = FUN_180d6ca90(*(uint64 *)(lVar4 + 80),0);
                    if (!cVar3) {
                      uVar5 = this.obstacleObj;
                      if (((this.gridData == null) ||
                          (lVar4 = this.gridData.obstale) == null) ||
                         (lVar4 = ObstacleData.GetObstacleDataBase(lVar4,0)) == null)
                      throw; // [null/range check failed]
                      uVar9 = String.Concat("SpeEffect/",*(uint64 *)(lVar4 + 80),0);
                      plVar6 = (int64 *)Resources.Load(uVar9,0);
                      puVar10 = (uint64 *)Vector3.get_back(local_78,0);
                      if ((this.gridData == null) ||
                         (lVar4 = this.gridData.obstale) == null)
                      throw; // [null/range check failed]
                      plVar12 = plVar13;
                      if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181d4e110)) {
                        plVar12 = plVar6;
                      }
                      if (!lVar4.obstale) {
                        fVar16 = 2.0;
                      }
                      else {
                        plVar12 = plVar13;
                        if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181d4e110)) {
                          plVar12 = plVar6;
                        }
                        fVar16 = 3.0;
                      }
                      uVar2 = *(uint32 *)(puVar10 + 1);
                      uVar9 = *puVar10;
                      puVar10 = (uint64 *)Vector3.get_one(local_68,0);
                      local_88 = *puVar10;
                      local_80 = *(float *)(puVar10 + 1);
                      local_90 = local_80 * fVar16;
                      local_98 = CONCAT44((float)((uint64)local_88 >> 32) * fVar16,
                                          (float)local_88 * fVar16);
                      local_88 = local_98;
                      local_80 = local_90;
                      local_98 = uVar9;
                      local_90 = (float)uVar2;
                      GlobalData.AddChild(uVar5,plVar12,&local_98,&local_88,0);
                    }
                    if (((this.gridData == null) ||
                        (lVar4 = this.gridData.obstale) == null) ||
                       (lVar4 = ObstacleData.GetObstacleDataBase(lVar4,0)) == null)
                    throw; // [null/range check failed]
                    if (*(int64 *)(lVar4 + 72) != 0) {
                      if (((this.gridData == null) ||
                          (lVar4 = this.gridData.obstale) == null) ||
                         (lVar4 = ObstacleData.GetObstacleDataBase(lVar4,0)) == null)
                      throw; // [null/range check failed]
                      cVar3 = String.op_Inequality(*(uint64 *)(lVar4 + 72),"",0);
                      if (cVar3) {
                        if (((this.gridData == null) ||
                            (lVar4 = this.gridData.obstale) == null) ||
                           (lVar4 = ObstacleData.GetObstacleDataBase(lVar4,0)) == null)
                        throw; // [null/range check failed]
                        uVar5 = String.Concat("Sound/SoundEffect/",*(uint64 *)(lVar4 + 72),0);
                        plVar6 = (int64 *)Resources.Load(uVar5,0);
                        plVar12 = plVar13;
                        if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181d8a228)) {
                          plVar12 = plVar6;
                        }
                        NGUITools.PlaySound(plVar12,0);
                      }
                    }
                  }
                  if (this.obstacleObj != null) {
                    uVar5 = GameObject.GetComponent(this.obstacleObj,DAT_181da1330);
                    cVar3 = Object.op_Inequality(uVar5,0,0);
                    plVar6 = plVar13;
                    if (cVar3) {
                      if ((((this.obstacleObj == null) ||
                           (lVar4 = GameObject.GetComponent(this.obstacleObj,DAT_181da1330),
                           lVar4 == null)) || (lVar4.battleUnit == null)) ||
                         (lVar4 = SkeletonDataAsset.GetSkeletonData(lVar4.battleUnit,1,0),
                         lVar4 == null)) throw; // [null/range check failed]
                      lVar4 = SkeletonData.FindAnimation(lVar4,"destroy0",0);
                      uVar5 = "destroy";
                      if (lVar4 == null) {
                        if (((this.obstacleObj == null) ||
                            (lVar4 = GameObject.GetComponent(this.obstacleObj,DAT_181da1330)
                            , lVar4 == null)) ||
                           ((lVar4.battleUnit == null ||
                            (lVar4 = SkeletonDataAsset.GetSkeletonData(lVar4.battleUnit,1,0),
                            lVar4 == null)))) throw; // [null/range check failed]
                        lVar4 = SkeletonData.FindAnimation(lVar4,"die",0);
                        if (lVar4 != null) {
                          plVar6 = "die";
                        }
                      }
                      else {
                        if ((this.gridData == null) ||
                           (lVar4 = this.gridData.obstale) == null)
                        throw; // [null/range check failed]
                        uVar9 = "0";
                        if (*(char *)(lVar4 + 66) == false) {
                          local_res8[0] = FUN_180d8cf10(0,4);
                          uVar9 = Int32.ToString(local_res8,0);
                        }
                        plVar6 = (int64 *)String.Concat(uVar5,uVar9,0);
                      }
                    }
                    lVar4 = this.obstacleObj;
                    if (plVar6 == (int64 *)0) {
                      Object.Destroy(lVar4,0);
                    }
                    else {
                      if (((lVar4 == null) ||
                          (lVar4 = GameObject.GetComponent(lVar4,DAT_181da1330)) == null) ||
                         (*(int64 *)(lVar4 + 192) == 0)) throw; // [null/range check failed]
                      *(uint32 *)(*(int64 *)(lVar4 + 192) + 108) = 0x3f800000;
                      if (((this.obstacleObj == null) ||
                          (lVar4 = GameObject.GetComponent(this.obstacleObj,DAT_181da1330),
                          lVar4 == null)) ||
                         (lVar4 = SkeletonAnimation.get_AnimationState(lVar4,0)) == null)
                      throw; // [null/range check failed]
                      AnimationState.SetAnimation(lVar4,0,plVar6,0,0);
                      if (((this.obstacleObj == null) ||
                          (lVar4 = GameObject.GetComponent(this.obstacleObj,DAT_181da1330),
                          lVar4 == null)) ||
                         ((lVar4.battleUnit == null ||
                          ((lVar4 = SkeletonDataAsset.GetSkeletonData(lVar4.battleUnit,1,0),
                           lVar4 == null || (lVar4 = SkeletonData.FindAnimation(lVar4,plVar6,0)) == null
                           ))))) throw; // [null/range check failed]
                      fVar16 = lVar4.column;
                      if (this.obstacleObj == null) throw; // [null/range check failed]
                      uVar5 = GameObject.get_transform(this.obstacleObj,0);
                      uVar5 = ShortcutExtensions.DOLocalMoveZ
                                        (uVar5,*(uint32 *)(pStatics + 48)
                                         ,fVar16 * 0.2,0,0);
                      uVar5 = TweenSettingsExtensions.SetEase(uVar5,17,DAT_181d97ca8);
                      TweenSettingsExtensions.SetDelay(uVar5,fVar16 * 0.8,DAT_181d97978);
                    }
                    lVar4 = this.gridData;
                    if (lVar4 != null) {
                      while ((lVar4.obstale != null &&
                             (lVar14 = *(int64 *)(lVar4.obstale + 56)) != null)) {
                        uVar11 = (uint32)plVar13;
                        if (*(int *)(lVar14 + 24) <= (int)uVar11) {
                          return;
                        }
                        if (((lVar4 == null) || (lVar4.obstale == null)) ||
                           (lVar4 = *(int64 *)(lVar4.obstale + 56)) == null) break;
                        if (lVar4.battleUnit <= uVar11) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        lVar4 = *(int64 *)(lVar4.mapID + lVar15);
                        if (lVar4 == null) break;
                        lVar4.gridType = 1;
                        lVar4.passes = 15;
                        lVar14 = *(int64 *)(pStatics + 80);
                        if (((lVar14 == null) || (lVar14 = *(int64 *)(lVar14 + 24)) == null) ||
                           (lVar14 = *(int64 *)(lVar14 + 72)) == null) break;
                        FUN_181801c10(lVar14,lVar4,DAT_181d638f8);
                        lVar14 = *(int64 *)(pStatics + 80);
                        if (((lVar14 == null) || (lVar14 = *(int64 *)(lVar14 + 24)) == null) ||
                           (lVar14 = *(int64 *)(lVar14 + 64)) == null) break;
                        FUN_181827900(lVar14,lVar4,DAT_181d63778);
                        lVar4 = GridUnitData.get_GridObj(lVar4,0);
                        if ((lVar4 == null) ||
                           (lVar4 = GameObject.GetComponent(lVar4,DAT_181d9f7f0)) == null) break;
                        GridUnitController.Refresh(lVar4,0);
                        lVar4 = this.gridData;
                        plVar13 = (int64 *)(uint64)(uVar11 + 1);
                        lVar15 = lVar15 + 8;
                        if (lVar4 == null) break;
                      }
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000C6A
    // RVA   : 0x86FA60   Offset: 0x86E260   Length: 0x294
    public List<GridUnitData> GetAroundObstacleGrid()
    {
        int iVar1;
        bool cVar2;
        long lVar3;
        long lVar4;
        long lVar5;
        int iVar6;
        int iVar7;
        int iVar8;
        lVar3 = il2cpp_internal(DAT_181d6e630);
        FUN_180f58a90(lVar3,DAT_181d63678);
        lVar4 = this.gridData;
        iVar7 = 0;
        if (lVar4 != null) {
          while ((lVar4.obstale != null &&
                 (lVar4 = *(int64 *)(lVar4.obstale + 56)) != null)) {
            if (lVar4.battleUnit <= iVar7) {
              return lVar3;
            }
            iVar8 = -1;
            do {
              iVar6 = -1;
              do {
                if ((iVar8 != 0) || (iVar6 != 0)) {
                  lVar4 = FUN_18046bb80(0);
                  if (lVar4 == null) throw; // [null/range check failed]
                  lVar4 = lVar4.battleUnit;
                  if ((((this.gridData == null) ||
                       (lVar5 = this.gridData.obstale) == null) ||
                      (lVar5 = *(int64 *)(lVar5 + 56)) == null) ||
                     (lVar5 = FUN_180002f80(lVar5,iVar7,DAT_181d63bf8)) == null) throw; // [null/range check failed]
                  iVar1 = *(int *)(lVar5 + 36);
                  if (((this.gridData == null) ||
                      (lVar5 = this.gridData.obstale) == null) ||
                     ((lVar5 = *(int64 *)(lVar5 + 56), lVar5 == null ||
                      ((lVar5 = FUN_180002f80(lVar5,iVar7,DAT_181d63bf8), lVar5 == null || (lVar4 == null))))))
                  throw; // [null/range check failed]
                  lVar4 = BattleMapData.GetGridData(lVar4,iVar1 + iVar6,*(int *)(lVar5 + 40) + iVar8,0)
                  ;
                  if (lVar4 != null) {
                    if (((this.gridData == null) ||
                        (lVar5 = this.gridData.obstale) == null) ||
                       (lVar5 = *(int64 *)(lVar5 + 56)) == null) throw; // [null/range check failed]
                    cVar2 = FUN_1818279a0(lVar5,lVar4,DAT_181d63878);
                    if (!cVar2) {
                      if (lVar3 == null) throw; // [null/range check failed]
                      cVar2 = FUN_1818279a0(lVar3,lVar4,DAT_181d63878);
                      if (!cVar2) {
                        FUN_181827900(lVar3,lVar4,DAT_181d63778);
                      }
                    }
                  }
                }
                iVar6 = iVar6 + 1;
              } while (iVar6 < 2);
              iVar8 = iVar8 + 1;
            } while (iVar8 < 2);
            lVar4 = this.gridData;
            iVar7 = iVar7 + 1;
            if (lVar4 == null) break;
          }
        }
    }

    // Token : 0x6000C6B
    // RVA   : 0x873480   Offset: 0x871C80   Length: 0x1B5
    public void SetObstacleDestroyed(GridUnitData targetGrid)
    {
        var pStatics = *(int64*)(DAT_181d8b128 + 184);
        long lVar1;
        if (targetGrid != null) {
          *(uint32 *)(targetGrid + 20) = 1;
          *(uint32 *)(targetGrid + 32) = 15;
          lVar1 = *(int64 *)(pStatics + 80);
          if (((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 24)) != null) &&
             (lVar1 = *(int64 *)(lVar1 + 72)) != null) {
            FUN_181801c10(lVar1,targetGrid,DAT_181d638f8);
            lVar1 = *(int64 *)(pStatics + 80);
            if (((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 24)) != null) &&
               (lVar1 = *(int64 *)(lVar1 + 64)) != null) {
              FUN_181827900(lVar1,targetGrid,DAT_181d63778);
              lVar1 = GridUnitData.get_GridObj(targetGrid,0);
              if (lVar1 != null) {
                lVar1 = GameObject.GetComponent(lVar1,DAT_181d9f7f0);
                if (lVar1 != null) {
                  GridUnitController.Refresh(lVar1,0);
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000C6C
    // RVA   : 0x873D10   Offset: 0x872510   Length: 0xAA9
    private void Update()
    {
        var pStatics = *(int64*)(DAT_181d8b128 + 184);
        uint uVar1;
        int iVar2;
        bool cVar3;
        bool cVar4;
        int iVar5;
        ulong uVar6;
        long lVar7;
        ulong uVar8;
        long lVar10;
        int iVar11;
        int iVar12;
        uint uVar13;
        ulong local_58;
        uint local_50;
        uint local_48;
        uint uStack_44;
        uint uStack_40;
        uint32 uStack_3c;
        cVar3 = FUN_1804625f0(0x130,0);
        if (!cVar3) {
        LAB_180873fbd:
          uVar6 = this.showAttackDirectionRange;
          cVar3 = Object.op_Inequality(uVar6,0,0);
          if (cVar3) {
            this.showAttackDirectionRange = 0;
            uVar6 = 0;
        LAB_180873ffa:
            il2cpp_internal(this + 112,uVar6);
            GridUnitController.Refresh(this,0);
          }
        }
        else {
          uVar6 = MouseController.get_hoveredObject(0);
          cVar3 = Object.op_Inequality(uVar6,0,0);
          if (!cVar3) goto LAB_180873fbd;
          lVar7 = MouseController.get_hoveredObject(0);
          if (lVar7 == null) throw; // [null/range check failed]
          uVar6 = GameObject.GetComponent(lVar7,DAT_181d9f7f0);
          cVar3 = Object.op_Inequality(uVar6,0,0);
          if (!cVar3) goto LAB_180873fbd;
          lVar7 = MouseController.get_hoveredObject(0);
          if (((lVar7 == null) || (lVar7 = GameObject.GetComponent(lVar7,DAT_181d9f7f0)) == null) ||
             (lVar7.battleUnit == null)) throw; // [null/range check failed]
          uVar6 = *(uint64 *)(lVar7.battleUnit + 24);
          cVar3 = Object.op_Inequality(uVar6,0,0);
          if (!cVar3) goto LAB_180873fbd;
          uVar6 = this.showAttackDirectionRange;
          uVar8 = MouseController.get_hoveredObject(0);
          cVar3 = Object.op_Inequality(uVar6,uVar8,0);
          if (cVar3) {
            uVar6 = MouseController.get_hoveredObject(0);
            this.showAttackDirectionRange = uVar6;
            goto LAB_180873ffa;
          }
        }
        lVar7 = *(int64 *)(pStatics + 80);
        if ((lVar7 == null) || (lVar7 = *(int64 *)(lVar7 + 0x1e0)) == null) throw; // [null/range check failed]
        cVar3 = FUN_1818279a0(lVar7,this.gridData,DAT_181d63878);
        if (!cVar3) {
          lVar7 = *(int64 *)(pStatics + 80);
          if (lVar7 == null) throw; // [null/range check failed]
          if (*(int *)(lVar7 + 0x124) == 10) {
            lVar7 = FUN_18046bb80(0);
            if (lVar7 == null) throw; // [null/range check failed]
            if (*(int64 *)(lVar7 + 0x208) != 0) {
              lVar7 = FUN_18046bb80(0);
              if ((lVar7 == null) || (*(int64 *)(lVar7 + 0x208) == 0)) throw; // [null/range check failed]
              cVar3 = FUN_1818279a0(*(int64 *)(lVar7 + 0x208),this.gridData,
                                    DAT_181d63878);
              if (cVar3) {
                lVar7 = FUN_18046bb80(0);
                if ((lVar7 == null) || (*(int64 *)(lVar7 + 0x110) == 0)) throw; // [null/range check failed]
                iVar5 = BattleUnit.GetSkillTargetType(*(int64 *)(lVar7 + 0x110),0);
                if (iVar5 == 0) {
                  GridUnitController.SetHighLightType(this,2,0);
                }
                else {
                  GridUnitController.SetHighLightType(this,3,0);
                }
                goto LAB_18087449a;
              }
            }
          }
          uVar6 = MouseController.get_hoveredObject(0);
          uVar8 = Component.get_gameObject(this,0);
          cVar3 = Object.op_Equality(uVar6,uVar8,0);
          if (!cVar3) {
            GridUnitController.SetHighLightType(this,0,0);
          }
          else {
            lVar7 = FUN_18046bb80(0);
            if (lVar7 == null) throw; // [null/range check failed]
            if (*(int *)(lVar7 + 0x124) == 4) {
              lVar7 = FUN_18046bb80(0);
              if (lVar7 == null) throw; // [null/range check failed]
              if (*(int64 *)(lVar7 + 0x208) == 0) goto LAB_18087436f;
              lVar7 = FUN_18046bb80(0);
              if ((lVar7 == null) || (*(int64 *)(lVar7 + 0x1f8) == 0)) throw; // [null/range check failed]
              cVar3 = FUN_1818279a0(*(int64 *)(lVar7 + 0x1f8),this.gridData,
                                    DAT_181d63878);
              uVar6 = 3;
              if (!cVar3) goto LAB_18087436f;
            }
            else {
        LAB_18087436f:
              uVar6 = 1;
            }
            GridUnitController.SetHighLightType(this,uVar6,0);
          }
        }
        else {
          if (this.highLightRenderType != 4) {
            this.highLightRenderType = 4;
            lVar7 = this.highlightRenderer;
            lVar10 = *(int64 *)(DAT_181d4f980 + 184);
            if (lVar7 == null) throw; // [null/range check failed]
            local_48 = *(uint32 *)(lVar10 + 32);
            uStack_44 = *(uint32 *)(lVar10 + 36);
            uStack_40 = *(uint32 *)(lVar10 + 40);
            uStack_3c = *(uint32 *)(lVar10 + 44);
            SpriteRenderer.set_color(lVar7,&local_48,0);
            if ((this.highlightRenderer == null) ||
               (lVar7 = Component.GetComponent(this.highlightRenderer,DAT_181d6dcc0)) == null)
            throw; // [null/range check failed]
            Behaviour.set_enabled(lVar7,0,0);
            if (this.highlightRenderer == null) throw; // [null/range check failed]
            lVar7 = Component.get_transform(this.highlightRenderer,0);
            puVar9 = (uint64 *)Vector3.get_one(&local_48,0);
            if (lVar7 == null) throw; // [null/range check failed]
            local_50 = *(uint32 *)(puVar9 + 1);
            local_58 = *puVar9;
            Transform.set_localScale(lVar7,&local_58,0);
          }
        }
        LAB_18087449a:
        lVar7 = this.gridData;
        if (lVar7 != null) {
          if (lVar7.gridType != 2) {
            return;
          }
          lVar7 = lVar7.obstale;
          if (lVar7 != null) {
            if (!lVar7.tempRef) {
              return;
            }
            lVar7.tempRef = 0;
            if ((this.gridData != null) &&
               (lVar7 = this.gridData.obstale) != null) {
              if (lVar7.mapID == 1) {
                return;
              }
              lVar7 = ObstacleData.GetObstacleDataBase(lVar7,0);
              if (lVar7 != null) {
                iVar5 = lVar7.obstale;
                if (iVar5 < 1) {
                  return;
                }
                lVar7 = this.gridData;
                cVar3 = false;
                iVar12 = 0;
                if (lVar7 != null) {
                  while( true ) {
                    if ((lVar7.obstale == null) ||
                       (lVar10 = *(int64 *)(lVar7.obstale + 56)) == null)
                    throw; // [null/range check failed]
                    if (*(int *)(lVar10 + 24) <= iVar12) break;
                    iVar11 = 1;
                    do {
                      lVar7 = FUN_18046bb80(0);
                      if (lVar7 == null) throw; // [null/range check failed]
                      lVar7 = lVar7.battleUnit;
                      if ((((this.gridData == null) ||
                           (lVar10 = this.gridData.obstale) == null) ||
                          (lVar10 = *(int64 *)(lVar10 + 56)) == null) ||
                         (lVar10 = FUN_180002f80(lVar10,iVar12,DAT_181d63bf8)) == null)
                      throw; // [null/range check failed]
                      iVar2 = *(int *)(lVar10 + 36);
                      if (((this.gridData == null) ||
                          (lVar10 = this.gridData.obstale) == null) ||
                         ((lVar10 = *(int64 *)(lVar10 + 56), lVar10 == null ||
                          ((lVar10 = FUN_180002f80(lVar10,iVar12,DAT_181d63bf8), lVar10 == null ||
                           (lVar7 == null)))))) throw; // [null/range check failed]
                      lVar7 = BattleMapData.GetGridData
                                        (lVar7,iVar2 + iVar11,*(uint32 *)(lVar10 + 40),0);
                      if (lVar7 != null) {
                        uVar6 = lVar7.battleUnit;
                        cVar4 = Object.op_Inequality(uVar6,0,0);
                        if (!cVar4) {
                          if (lVar7.speGridObjData == null) throw; // [null/range check failed]
                          if (*(int *)(lVar7.speGridObjData + 16) != 0)
                          {
                            }
                            cVar3 = true;
                            break;
                            }
                          }
                      iVar11 = iVar11 + 1;
                    } while (iVar11 <= iVar5);
                    lVar7 = this.gridData;
                    iVar12 = iVar12 + 1;
                    if (lVar7 == null) throw; // [null/range check failed]
                  }
                  if ((lVar7 = lVar7?.obstale) != null) {
                    if (*(char *)(lVar7 + 65) == cVar3) {
                      return;
                    }
                    if (!cVar3) {
                      uVar13 = 0x3f800000;
                    }
                    else {
                      uVar13 = 0x3ecccccd;
                    }
                    *(char *)(lVar7 + 65) = cVar3;
                    if (this.obstacleObj != null) {
                      uVar6 = GameObject.GetComponent(this.obstacleObj,DAT_181da1330);
                      if (((this.obstacleObj != null) &&
                          (lVar7 = GameObject.GetComponent(this.obstacleObj,DAT_181da1330),
                          lVar7 != null)) && (*(int64 *)(lVar7 + 192) != 0)) {
                        uVar1 = *(uint32 *)(*(int64 *)(lVar7 + 192) + 108);
                        GlobalData.DoTweenSkeletonAlpha(uVar6,uVar1,uVar13,0x3e99999a,0);
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

    // Token : 0x6000C6D
    // RVA   : 0x8730D0   Offset: 0x8718D0   Length: 0x3A3
    public void SetHighLightType(HighLightRenderType targetType)
    {
        var pStatics = *(int64*)(DAT_181d4f980 + 184);
        long lVar1;
        long lVar2;
        uint uVar4;
        uint uVar5;
        uint uVar6;
        uint uVar7;
        ulong local_38;
        uint local_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        uint64 local_18;
        uint64 uStack_10;
        if (this.highLightRenderType == targetType) {
          return;
        }
        this.highLightRenderType = targetType;
        if (targetType == null) {
          lVar2 = this.highlightRenderer;
          local_18 = 0;
          uStack_10 = 0;
          FUN_1809981e0(&local_18,0,0,0,0,0);
          if (lVar2 == null) {
        LAB_180873468:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          local_28 = (uint32)local_18;
          uStack_24 = local_18._4_4_;
          uStack_20 = (uint32)uStack_10;
          uStack_1c = uStack_10._4_4_;
          SpriteRenderer.set_color(lVar2,&local_28,0);
          if ((this.highlightRenderer == null) ||
             (lVar2 = Component.GetComponent(this.highlightRenderer,DAT_181d6dcc0)) == null)
          goto LAB_180873468;
          Behaviour.set_enabled(lVar2,0,0);
          if (this.highlightRenderer == null) goto LAB_180873468;
          lVar2 = Component.get_transform(this.highlightRenderer,0);
          puVar3 = (uint64 *)Vector3.get_one(&local_28,0);
          if (lVar2 == null) goto LAB_180873468;
          goto LAB_180873200;
        }
        if (targetType == 1) {
          lVar2 = this.highlightRenderer;
          lVar1 = pStatics;
          if (lVar2 == null) throw; // [null/range check failed]
          uVar4 = *(uint32 *)(lVar1 + 128);
          uVar5 = *(uint32 *)(lVar1 + 132);
          uVar6 = *(uint32 *)(lVar1 + 136);
          uVar7 = *(uint32 *)(lVar1 + 140);
        LAB_180873193:
          local_18 = CONCAT44(uVar5,uVar4);
          uStack_10 = CONCAT44(uVar7,uVar6);
          SpriteRenderer.set_color(lVar2,&local_18,0);
          if ((this.highlightRenderer != null) &&
             (lVar2 = Component.GetComponent(this.highlightRenderer,DAT_181d6dcc0)) != null) {
            Behaviour.set_enabled(lVar2,0,0);
            if (this.highlightRenderer != null) {
              lVar2 = Component.get_transform(this.highlightRenderer,0);
              puVar3 = (uint64 *)Vector3.get_one(&local_28,0);
              if (lVar2 != null) {
        LAB_180873200:
                local_30 = *(uint32 *)(puVar3 + 1);
                local_38 = *puVar3;
                Transform.set_localScale(lVar2,&local_38,0);
                return;
              }
            }
          }
        }
        else {
          if (targetType == 2) {
            if (this.highlightRenderer == null) throw; // [null/range check failed]
            lVar2 = Component.GetComponent(this.highlightRenderer,DAT_181d6d540);
            lVar1 = pStatics;
            if (lVar2 == null) throw; // [null/range check failed]
            uVar4 = *(uint32 *)(lVar1 + 144);
            uVar5 = *(uint32 *)(lVar1 + 148);
            uVar6 = *(uint32 *)(lVar1 + 152);
            uVar7 = *(uint32 *)(lVar1 + 156);
          }
          else {
            if (targetType != 3) {
              if (targetType != 4) {
                return;
              }
              lVar2 = this.highlightRenderer;
              lVar1 = pStatics;
              if (lVar2 == null) throw; // [null/range check failed]
              uVar4 = *(uint32 *)(lVar1 + 32);
              uVar5 = *(uint32 *)(lVar1 + 36);
              uVar6 = *(uint32 *)(lVar1 + 40);
              uVar7 = *(uint32 *)(lVar1 + 44);
              goto LAB_180873193;
            }
            if (this.highlightRenderer == null) throw; // [null/range check failed]
            lVar2 = Component.GetComponent(this.highlightRenderer,DAT_181d6d540);
            lVar1 = pStatics;
            if (lVar2 == null) throw; // [null/range check failed]
            uVar4 = *(uint32 *)(lVar1 + 160);
            uVar5 = *(uint32 *)(lVar1 + 164);
            uVar6 = *(uint32 *)(lVar1 + 168);
            uVar7 = *(uint32 *)(lVar1 + 172);
          }
          local_18 = CONCAT44(uVar5,uVar4);
          uStack_10 = CONCAT44(uVar7,uVar6);
          SpriteRenderer.set_color(lVar2,&local_18,0);
          if ((this.highlightRenderer != null) &&
             (lVar2 = Component.GetComponent(this.highlightRenderer,DAT_181d6dcc0)) != null) {
            Behaviour.set_enabled(lVar2,1,0);
            if ((this.highlightRenderer != null) &&
               (lVar2 = Component.GetComponent(this.highlightRenderer,DAT_181d6dcc0)) != null)
            {
              UITweener.PlayForward(lVar2,0);
              if ((this.highlightRenderer != null) &&
                 (lVar2 = Component.GetComponent(this.highlightRenderer,DAT_181d6dcc0), lVar2 != null
                 )) {
                UITweener.ResetToBeginning(lVar2,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000C6E
    // RVA   : 0x8716D0   Offset: 0x86FED0   Length: 0xCC
    public void OnClick()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d8b128 + 184) + 80);
        uVar2 = Component.get_gameObject(this,0);
        if (lVar1 != null) {
          BattleController.BattleGridClicked(lVar1,uVar2,0);
          return;
        }
    }

    // Token : 0x6000C6F
    // RVA   : 0x245810   Offset: 0x244010   Length: 0x3
    public void OnHover()
    {
    }

    // Token : 0x6000C70
    // RVA   : 0x8717A0   Offset: 0x86FFA0   Length: 0xC1
    public void OnDrag(Vector2 delta)
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d8b128 + 184) + 80);
        if (lVar1 != null) {
          BattleController.OnDrag(lVar1,delta,0);
          return;
        }
    }

    // Token : 0x6000C71
    // RVA   : 0x871A70   Offset: 0x870270   Length: 0xBD
    public void OnScroll(float delta)
    {
        long lVar1;
        lVar1 = *(int64 *)(*(int64 *)(DAT_181d8b128 + 184) + 80);
        if (lVar1 != null) {
          BattleController.OnScroll(lVar1,delta,0);
          return;
        }
    }

    // Token : 0x6000C72
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

    // Token : 0x6000C73
    // RVA   : 0x8747C0   Offset: 0x872FC0   Length: 0x48C
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181d4f980 + 184);
        long lVar1;
        uint local_138;
        uint uStack_134;
        uint uStack_130;
        uint32 uStack_12c;
        uint64 local_128;
        uint64 uStack_120;
        uint64 local_118;
        uint64 uStack_110;
        uint64 local_108;
        uint64 uStack_100;
        uint64 local_f8;
        uint64 uStack_f0;
        uint64 local_e8;
        uint64 uStack_e0;
        uint64 local_d8;
        uint64 uStack_d0;
        uint64 local_c8;
        uint64 uStack_c0;
        uint64 local_b8;
        uint64 uStack_b0;
        uint64 local_a8;
        uint64 uStack_a0;
        uint64 local_98;
        uint64 uStack_90;
        uint64 local_88;
        uint64 uStack_80;
        uint64 local_78;
        uint64 uStack_70;
        uint64 local_68;
        uint64 uStack_60;
        local_128 = 0;
        uStack_120 = 0;
        FUN_1809981e0(&local_128,0,0x3eb4b4b5,0x3eb4b4b5,0x3e99999a,0);
        puVar2 = *(uint32 **)(DAT_181d4f980 + 184);
        *puVar2 = (uint32)local_128;
        puVar2[1] = local_128._4_4_;
        puVar2[2] = (uint32)uStack_120;
        puVar2[3] = uStack_120._4_4_;
        local_118 = 0;
        uStack_110 = 0;
        FUN_1809981e0(&local_118,0,0x3f5ededf,0x3f800000,0x3e99999a,0);
        lVar1 = pStatics;
        *(uint32 *)(lVar1 + 16) = (uint32)local_118;
        *(uint32 *)(lVar1 + 20) = local_118._4_4_;
        *(uint32 *)(lVar1 + 24) = (uint32)uStack_110;
        *(uint32 *)(lVar1 + 28) = uStack_110._4_4_;
        local_108 = 0;
        uStack_100 = 0;
        FUN_1809981e0(&local_108,0,0x3f5ededf,0x3f800000,0x3f19999a,0);
        lVar1 = pStatics;
        *(uint64 *)(lVar1 + 32) = local_108;
        *(uint64 *)(lVar1 + 40) = uStack_100;
        local_f8 = 0;
        uStack_f0 = 0;
        FUN_1809981e0(&local_f8,0x3e4ccccd,0x3e4ccccd,0x3e4ccccd,0x3f000000,0);
        lVar1 = pStatics;
        *(uint32 *)(lVar1 + 48) = (uint32)local_f8;
        *(uint32 *)(lVar1 + 52) = local_f8._4_4_;
        *(uint32 *)(lVar1 + 56) = (uint32)uStack_f0;
        *(uint32 *)(lVar1 + 60) = uStack_f0._4_4_;
        local_e8 = 0;
        uStack_e0 = 0;
        FUN_1809981e0(&local_e8,0x3f2aaaab,0,0,0x3ecccccd,0);
        lVar1 = pStatics;
        *(uint32 *)(lVar1 + 64) = (uint32)local_e8;
        *(uint32 *)(lVar1 + 68) = local_e8._4_4_;
        *(uint32 *)(lVar1 + 72) = (uint32)uStack_e0;
        *(uint32 *)(lVar1 + 76) = uStack_e0._4_4_;
        local_d8 = 0;
        uStack_d0 = 0;
        FUN_1809981e0(&local_d8,0x3f2aaaab,0,0,0x3f19999a,0);
        lVar1 = pStatics;
        *(uint32 *)(lVar1 + 80) = (uint32)local_d8;
        *(uint32 *)(lVar1 + 84) = local_d8._4_4_;
        *(uint32 *)(lVar1 + 88) = (uint32)uStack_d0;
        *(uint32 *)(lVar1 + 92) = uStack_d0._4_4_;
        local_c8 = 0;
        uStack_c0 = 0;
        FUN_1809981e0(&local_c8,0,0x3f2aaaab,0,0x3ecccccd,0);
        lVar1 = pStatics;
        *(uint32 *)(lVar1 + 96) = (uint32)local_c8;
        *(uint32 *)(lVar1 + 100) = local_c8._4_4_;
        *(uint32 *)(lVar1 + 104) = (uint32)uStack_c0;
        *(uint32 *)(lVar1 + 108) = uStack_c0._4_4_;
        local_b8 = 0;
        uStack_b0 = 0;
        FUN_1809981e0(&local_b8,0,0x3f2aaaab,0,0x3f19999a,0);
        lVar1 = pStatics;
        *(uint32 *)(lVar1 + 112) = (uint32)local_b8;
        *(uint32 *)(lVar1 + 116) = local_b8._4_4_;
        *(uint32 *)(lVar1 + 120) = (uint32)uStack_b0;
        *(uint32 *)(lVar1 + 124) = uStack_b0._4_4_;
        local_a8 = 0;
        uStack_a0 = 0;
        FUN_1809981e0(&local_a8,0x3f64e4e5,0x3f800000,0x3f7afafb,0x3f800000,0);
        lVar1 = pStatics;
        *(uint32 *)(lVar1 + 128) = (uint32)local_a8;
        *(uint32 *)(lVar1 + 132) = local_a8._4_4_;
        *(uint32 *)(lVar1 + 136) = (uint32)uStack_a0;
        *(uint32 *)(lVar1 + 140) = uStack_a0._4_4_;
        local_98 = 0;
        uStack_90 = 0;
        FUN_1809981e0(&local_98,0x3f800000,0,0,0x3f800000,0);
        lVar1 = pStatics;
        *(uint32 *)(lVar1 + 144) = (uint32)local_98;
        *(uint32 *)(lVar1 + 148) = local_98._4_4_;
        *(uint32 *)(lVar1 + 152) = (uint32)uStack_90;
        *(uint32 *)(lVar1 + 156) = uStack_90._4_4_;
        local_88 = 0;
        uStack_80 = 0;
        FUN_1809981e0(&local_88,0,0x3f800000,0x3ed8d8d9,0x3f800000,0);
        lVar1 = pStatics;
        *(uint32 *)(lVar1 + 160) = (uint32)local_88;
        *(uint32 *)(lVar1 + 164) = local_88._4_4_;
        *(uint32 *)(lVar1 + 168) = (uint32)uStack_80;
        *(uint32 *)(lVar1 + 172) = uStack_80._4_4_;
        lVar1 = il2cpp_internal(DAT_181d6d130);
        FUN_180f58a90(lVar1,DAT_181d5b600);
        puVar2 = (uint32 *)FUN_180d904c0(&local_138,0);
        if (lVar1 != null) {
          local_138 = *puVar2;
          uStack_134 = puVar2[1];
          uStack_130 = puVar2[2];
          uStack_12c = puVar2[3];
          FUN_1818059b0(lVar1,&local_138,DAT_181d5b680);
          local_78 = 0;
          uStack_70 = 0;
          FUN_1809981e0(&local_78,0x3f800000,0x3f6b851f,0x3e23d70a,0x3e4ccccd,0);
          local_138 = (uint32)local_78;
          uStack_134 = local_78._4_4_;
          uStack_130 = (uint32)uStack_70;
          uStack_12c = uStack_70._4_4_;
          FUN_1818059b0(lVar1,&local_138,DAT_181d5b680);
          local_68 = 0;
          uStack_60 = 0;
          FUN_1809981e0(&local_68,0x3f800000,0,0,0x3e4ccccd,0);
          local_138 = (uint32)local_68;
          uStack_134 = local_68._4_4_;
          uStack_130 = (uint32)uStack_60;
          uStack_12c = uStack_60._4_4_;
          FUN_1818059b0(lVar1,&local_138,DAT_181d5b680);
          plVar3 = (int64 *)(pStatics + 176);
          *plVar3 = lVar1;
          il2cpp_internal(plVar3,lVar1);
          return;
        }
    }

}
