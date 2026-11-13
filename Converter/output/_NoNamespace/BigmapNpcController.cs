// ============================================================
// Type  : BigmapNpcController
// Token : 0x200019E
// ============================================================

public class BigmapNpcController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000B40
    public HeroData heroData;

    // Token: 0x4000B41
    public GameObject CircleObj;

    // Token: 0x4000B42
    public SpriteRenderer SafeSprite;

    // Token: 0x4000B43
    public GameObject heroFollowTarget;

    // Token: 0x4000B44
    public HeroFollowType heroFollowType;

    // Token: 0x4000B45
    public float heroChaseTime;

    // Token: 0x4000B46
    public float followRangeRate;

    // Token: 0x4000B47
    public float heroStopChaseTime;

    // Token: 0x4000B48
    public GameObject selfSkeleton;

    // Token: 0x4000B49
    public GameObject heroSimpleSprite;

    // Token: 0x4000B4A
    public GameObject heroMissionTarget;

    // Token: 0x4000B4B
    public List<BigMapFollower> followers;

    // Token: 0x4000B4C
    public SinglePlotData plotData;

    // Token: 0x4000B4D
    public CapsuleCollider hoverRangeCollider;

    // Token: 0x4000B4E
    public CapsuleCollider interactRangeCollider;

    // Token: 0x4000B4F
    public SphereCollider seeRangeCollider;

    // Token: 0x4000B50
    private float angle;

    // Token: 0x4000B51
    private float finalAngle;

    // Token: 0x4000B52
    private Quaternion finalRotation;

    // Token: 0x4000B53
    private GameObject newObj;

    // Token: 0x4000B54
    public bool needRefresh;

    // Token: 0x4000B55
    public static List<string> HeroFollowTypeText;

    // Token: 0x4000B56
    public GameObject areaSafeRangeBuffer;

    // Token: 0x4000B57
    public GameObject areaSafeRange;

    // Token: 0x4000B58
    public float areaSafeRangeRefreshTime;

    // Token: 0x4000B59
    public GameObject leavingAreaSafeRange;

    // Token: 0x4000B5A
    public GameObject BigMapFightIcon;

    // Token: 0x4000B5B
    public GameObject BigMapFightIconPrefab;

    // Token: 0x4000B5C
    private float originSimpleSpriteScale;

    // Token: 0x4000B5D
    private float originCapsuleColliderRadius;

    // Token: 0x4000B5E
    private float originCapsuleColliderHeight;

    // Token: 0x4000B5F
    private Vector3 originCapsuleColliderCenter;

    // Token: 0x4000B60
    public BigMapSpeEffectType inBigMapSpeEffectType;

    // Token: 0x4000B61
    public bool inBigMapSpeEffectBuff;

    // Token: 0x4000B62
    public bool inWaterBuff;

    // Token: 0x4000B63
    public bool inMountainBuff;

    // Token: 0x4000B64
    public bool inHillBuff;

    // Token: 0x4000B65
    public float checkBigMapColliderTime;

    // Token: 0x4000B66
    private Transform arrowTrans;

    // Token: 0x4000B67
    private TweenRotation circleTweenRotation;

    // Token: 0x4000B68
    private SpriteRenderer heroMissionRenderer;

    // Token: 0x4000B69
    private SkeletonAnimation selfSkeletonAnim;

    // Token: 0x4000B6A
    private int missionState;

    // Token: 0x4000B6B
    private bool inited;

    // Token: 0x4000B6C
    private bool selfShowing;

    // Token: 0x4000B6D
    public bool selfDestroying;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000D2D
    // RVA   : 0x9EBA20   Offset: 0x9EA820   Length: 0xFC
    private Transform get_ArrowTrans()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        uVar3 = this.arrowTrans;
        cVar1 = Object.op_Equality(uVar3,0,0);
        if (cVar1) {
          uVar3 = this.CircleObj;
          cVar1 = Object.op_Inequality(uVar3,0,0);
          if (cVar1) {
            if (this.CircleObj != null) {
              lVar2 = GameObject.get_transform(this.CircleObj,0);
              if (lVar2 != null) {
                uVar3 = Transform.Find(lVar2,"Arrow",0);
                this.arrowTrans = uVar3;
                goto LAB_1809ebb00;
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
        }
        LAB_1809ebb00:
        return this.arrowTrans;
    }

    // Token : 0x6000D2E
    // RVA   : 0x9EBB20   Offset: 0x9EA920   Length: 0xEA
    private TweenRotation get_CircleTweenRotation()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = this.circleTweenRotation;
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          uVar2 = this.CircleObj;
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (cVar1) {
            if (this.CircleObj == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            uVar2 = GameObject.GetComponent(this.CircleObj,DAT_181e57610);
            this.circleTweenRotation = uVar2;
          }
        }
        return this.circleTweenRotation;
    }

    // Token : 0x6000D2F
    // RVA   : 0x9EBC10   Offset: 0x9EAA10   Length: 0xEA
    private SpriteRenderer get_HeroMissionRenderer()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = this.heroMissionRenderer;
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          uVar2 = this.heroMissionTarget;
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (cVar1) {
            if (this.heroMissionTarget == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            uVar2 = GameObject.GetComponent(this.heroMissionTarget,DAT_181e56c80);
            this.heroMissionRenderer = uVar2;
          }
        }
        return this.heroMissionRenderer;
    }

    // Token : 0x6000D30
    // RVA   : 0x9EBD00   Offset: 0x9EAB00   Length: 0xEA
    private SkeletonAnimation get_SelfSkeletonAnim()
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = this.selfSkeletonAnim;
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          uVar2 = this.selfSkeleton;
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (cVar1) {
            if (this.selfSkeleton == null) {
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            uVar2 = GameObject.GetComponent(this.selfSkeleton,DAT_181e56598);
            this.selfSkeletonAnim = uVar2;
          }
        }
        return this.selfSkeletonAnim;
    }

    // Token : 0x6000D31
    // RVA   : 0x9E7D10   Offset: 0x9E6B10   Length: 0x170
    private SkeletonAnimation GetSkeletonAnim(GameObject targetSkeleton)
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = this.selfSkeleton;
        cVar1 = Object.op_Equality(targetSkeleton,uVar2,0);
        if (!cVar1) {
          if (targetSkeleton != null) {
            uVar2 = GameObject.GetComponent(targetSkeleton,DAT_181e56598);
            return uVar2;
          }
        LAB_1809e7e7b:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        uVar2 = this.selfSkeletonAnim;
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          uVar2 = this.selfSkeleton;
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (cVar1) {
            if (this.selfSkeleton == null) goto LAB_1809e7e7b;
            uVar2 = GameObject.GetComponent(this.selfSkeleton,DAT_181e56598);
            this.selfSkeletonAnim = uVar2;
          }
        }
        return this.selfSkeletonAnim;
    }

    // Token : 0x6000D32
    // RVA   : 0x9EB460   Offset: 0x9EA260   Length: 0x1F6
    private void Start()
    {
        long lVar1;
        ulong uVar4;
        long lVar5;
        uint uVar7;
        byte[] local_18 = new byte[16];
        if ((this.heroSimpleSprite != null) &&
           (lVar1 = GameObject.get_transform(this.heroSimpleSprite,0)) != null) {
          puVar2 = (uint32 *)Transform.get_localScale(local_18,lVar1,0);
          this.originSimpleSpriteScale = *puVar2;
          if (this.hoverRangeCollider != null) {
            uVar7 = CapsuleCollider.get_radius(this.hoverRangeCollider,0);
            this.originCapsuleColliderRadius = uVar7;
            if (this.hoverRangeCollider != null) {
              uVar7 = CapsuleCollider.get_height(this.hoverRangeCollider,0);
              this.originCapsuleColliderHeight = uVar7;
              if (this.hoverRangeCollider != null) {
                puVar3 = (uint64 *)
                         CapsuleCollider.get_center(local_18,this.hoverRangeCollider,0);
                bVar6 = !DAT_181eb7df7;
                this.originCapsuleColliderCenter = *puVar3;
                *(uint32 *)(this + 244) = *(uint32 *)(puVar3 + 1);
                if (bVar6) {
                  il2cpp_runtime_class_init(&DAT_181e771b8);
                  il2cpp_runtime_class_init(&DAT_181e51340);
                  il2cpp_runtime_class_init(&DAT_181e56598);
                  il2cpp_runtime_class_init(&DAT_181e83330);
                  il2cpp_runtime_class_init(&DAT_181e83230);
                  il2cpp_runtime_class_init(&DAT_181e76ea8);
                  DAT_181eb7df7 = true;
                }
                if (*(char *)(this + 300) != false) {
                  return;
                }
                *(uint8 *)(this + 300) = 1;
                lVar1 = Component.get_gameObject(this,0);
                if (lVar1 != null) {
                  lVar1 = GameObject.AddComponent(lVar1,DAT_181e51340);
                  if ((this.selfSkeleton != null) &&
                     (uVar4 = GameObject.GetComponent(this.selfSkeleton,DAT_181e56598),
                     lVar1 != null)) {
                    FootStepController.Init(lVar1,uVar4,0);
                    if (this.heroData != null) {
                      if (this.heroData.heroID == null) {
                        return;
                      }
                      lVar1 = Component.GetComponent(this,DAT_181e771b8);
                      lVar5 = il2cpp_internal(DAT_181e76ea8);
                      FUN_1810f3480(lVar5,DAT_181e83230);
                      if (lVar5 != null) {
                        FUN_18175dba0(lVar5,0,DAT_181e83330);
                        FUN_18175dba0(lVar5,0,DAT_181e83330);
                        if (lVar1 != null) {
                          *(int64 *)(lVar1 + 32) = lVar5;
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

    // Token : 0x6000D33
    // RVA   : 0x9E80A0   Offset: 0x9E6EA0   Length: 0x15B
    private void Init()
    {
        long lVar1;
        ulong uVar2;
        long lVar3;
        if (*(char *)(this + 300) == false) {
          *(uint8 *)(this + 300) = 1;
          lVar1 = Component.get_gameObject(this,0);
          if (lVar1 != null) {
            lVar1 = GameObject.AddComponent(lVar1,DAT_181e51340);
            if ((this.selfSkeleton != null) &&
               (uVar2 = GameObject.GetComponent(this.selfSkeleton,DAT_181e56598), lVar1 != null)
               ) {
              FootStepController.Init(lVar1,uVar2,0);
              if (this.heroData != null) {
                if (this.heroData.heroID == null) {
                  return;
                }
                lVar1 = Component.GetComponent(this,DAT_181e771b8);
                lVar3 = il2cpp_internal(DAT_181e76ea8);
                FUN_1810f3480(lVar3,DAT_181e83230);
                if (lVar3 != null) {
                  FUN_18175dba0(lVar3,0,DAT_181e83330);
                  FUN_18175dba0(lVar3,0,DAT_181e83330);
                  if (lVar1 != null) {
                    *(int64 *)(lVar1 + 32) = lVar3;
                    return;
                  }
                }
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
    }

    // Token : 0x6000D34
    // RVA   : 0x9E8CA0   Offset: 0x9E7AA0   Length: 0x28B
    public void ManageFollowState()
    {
        ulong uVar2;
        bool cVar5;
        long lVar6;
        float fVar7;
        float fVar8;
        byte[] local_38 = new byte[48];
        lVar6 = this.leavingAreaSafeRange;
        cVar5 = Object.op_Inequality(lVar6,0,0);
        if (cVar5) {
          lVar6 = Component.get_transform(this,0);
          if (lVar6 == null) goto LAB_1809e8f26;
          puVar3 = (uint64 *)Transform.get_localPosition(local_38,lVar6,0);
          uVar2 = *puVar3;
          if (*plVar1 == 0) goto LAB_1809e8f26;
          lVar6 = GameObject.get_transform(*plVar1,0);
          if (lVar6 == null) goto LAB_1809e8f26;
          lVar6 = FUN_180b05920(lVar6,0);
          if (lVar6 == null) goto LAB_1809e8f26;
          puVar3 = (uint64 *)Transform.get_localPosition(local_38,lVar6,0);
          fVar7 = (float)Vector2.Distance(uVar2,*puVar3,0);
          if (*plVar1 == 0) goto LAB_1809e8f26;
          lVar6 = GameObject.GetComponent(*plVar1,DAT_181e53fe0);
          if (lVar6 == null) goto LAB_1809e8f26;
          fVar8 = (float)CapsuleCollider.get_radius(lVar6,0);
          if (*plVar1 == 0) goto LAB_1809e8f26;
          lVar6 = GameObject.get_transform(*plVar1,0);
          if (lVar6 == null) goto LAB_1809e8f26;
          pfVar4 = (float *)Transform.get_localScale(local_38,lVar6,0);
          if (fVar8 * *pfVar4 + 0.2 < fVar7) {
            *plVar1 = 0;
            il2cpp_internal(plVar1,0);
            if ((this.heroData == null) ||
               (lVar6 = this.heroData.heroAIData) == null)
            goto LAB_1809e8f26;
            HeroAIData.WandererLoseTarget(lVar6,0);
          }
        }
        uVar2 = this.heroFollowTarget;
        cVar5 = Object.op_Inequality(uVar2,0,0);
        if (cVar5) {
          if (this.heroFollowTarget == null) {
        LAB_1809e8f26:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          uVar2 = GameObject.GetComponent(this.heroFollowTarget,DAT_181e53760);
          cVar5 = BigmapNpcController.HeroCanFollow
                            (this,uVar2,this.heroFollowType,this.followRangeRate
                             ,0);
          if (!cVar5) {
            this.heroFollowTarget = 0;
            this.heroChaseTime = 0;
            if ((this.heroData == null) ||
               (lVar6 = this.heroData.heroAIData) == null)
            goto LAB_1809e8f26;
            if (*(int *)(lVar6 + 48) < 0) {
              HeroAIData.WandererLoseTarget(lVar6,0);
            }
          }
        }
    }

    // Token : 0x6000D35
    // RVA   : 0x9E64D0   Offset: 0x9E52D0   Length: 0x130B
    private void FixedUpdate()
    {
        var pStatics = *(int64*)(DAT_181e8b8e8 + 184);
        int iVar2;
        uint uVar3;
        uint uVar4;
        uint uVar5;
        ulong uVar6;
        bool cVar7;
        long lVar8;
        long lVar11;
        ulong uVar12;
        ulong uVar13;
        int iVar14;
        float fVar16;
        float fVar17;
        float fVar18;
        float fVar19;
        ulong local_d8;
        float local_d0;
        ulong local_c8;
        float local_c0;
        ulong local_b8;
        float fStack_b0;
        uint32 uStack_ac;
        uint64 local_a8;
        uint64 uStack_a0;
        uint64 local_98;
        uint64 uStack_90;
        local_98 = 0;
        uStack_90 = 0;
        if (this.heroData == null) throw; // [null/range check failed]
        if (!this.heroData.inTeam) {
          lVar8 = BigmapNpcController.GetHeroTargetPos(this,0);
          if (lVar8 == null) throw; // [null/range check failed]
          if ((lVar8.isSummon == null.0) && (lVar8.summonID == null.0)) goto LAB_1809e697f;
          lVar8 = Component.get_transform(this,0);
          if (lVar8 == null) throw; // [null/range check failed]
          puVar9 = (uint64 *)Transform.get_localPosition(&local_b8,lVar8,0);
          uVar12 = *puVar9;
          fVar18 = *(float *)(puVar9 + 1);
          lVar8 = BigmapNpcController.GetHeroTargetPos(this,0);
          if (lVar8 == null) throw; // [null/range check failed]
          local_d8 = CONCAT44(lVar8.summonID * 0.01,lVar8.isSummon * 0.01);
          local_d0 = 0.0;
          local_c8 = uVar12;
          local_c0 = fVar18;
          cVar7 = Vector3.op_Inequality(&local_c8,&local_d8,0);
          if (!cVar7) goto LAB_1809e697f;
          lVar8 = BigmapNpcController.get_ArrowTrans(this,0);
          puVar9 = (uint64 *)Vector3.get_one(&local_a8,0);
          local_b8 = *puVar9;
          fStack_b0 = *(float *)(puVar9 + 1);
          local_d0 = fStack_b0 * 4.0;
          local_d8 = CONCAT44((float)((uint64)local_b8 >> 32) * 4.0,(float)local_b8 * 4.0);
          local_c8 = local_b8;
          local_c0 = fStack_b0;
          if (lVar8 == null) throw; // [null/range check failed]
          local_c8 = local_d8;
          local_c0 = local_d0;
          Transform.set_localScale(lVar8,&local_c8,0);
          puVar9 = (uint64 *)Vector3.get_right(&local_a8,0);
          uVar12 = *puVar9;
          fVar18 = *(float *)(puVar9 + 1);
          lVar8 = BigmapNpcController.GetHeroTargetPos(this,0);
          if (lVar8 == null) throw; // [null/range check failed]
          fVar16 = lVar8.isSummon;
          fVar17 = lVar8.summonID;
          lVar8 = Component.get_transform(this,0);
          if (lVar8 == null) throw; // [null/range check failed]
          puVar9 = (uint64 *)Transform.get_localPosition(&local_a8,lVar8,0);
          local_b8 = *puVar9;
          local_c0 = 0.0 - *(float *)(puVar9 + 1);
          local_c8 = CONCAT44(fVar17 * 0.01 - (float)((uint64)local_b8 >> 32),
                              fVar16 * 0.01 - (float)local_b8);
          local_d8 = uVar12;
          local_d0 = fVar18;
          fStack_b0 = local_c0;
          puVar10 = (uint32 *)Quaternion.FromToRotation(&local_a8,&local_d8,&local_c8,0);
          uVar3 = puVar10[1];
          uVar4 = puVar10[2];
          uVar5 = puVar10[3];
          this.finalRotation = *puVar10;
          *(uint32 *)(this + 148) = uVar3;
          *(uint32 *)(this + 152) = uVar4;
          *(uint32 *)(this + 156) = uVar5;
          if ((this.CircleObj == null) ||
             (lVar8 = GameObject.get_transform(this.CircleObj,0)) == null)
          throw; // [null/range check failed]
          local_a8 = this.finalRotation;
          uStack_a0 = *(uint64 *)(this + 152);
          puVar9 = (uint64 *)Transform.get_localRotation(&local_b8,lVar8,0);
          local_b8 = *puVar9;
          fStack_b0 = *(float *)(puVar9 + 1);
          uStack_ac = *(uint32 *)((int64)puVar9 + 12);
          cVar7 = Quaternion.op_Inequality(&local_b8,&local_a8,0);
          if (cVar7) {
            lVar8 = BigmapNpcController.get_CircleTweenRotation(this);
            if (lVar8 == null) throw; // [null/range check failed]
            cVar7 = Behaviour.get_enabled(lVar8);
            if (!cVar7) {
              lVar8 = BigmapNpcController.get_CircleTweenRotation(this,0);
              if ((this.CircleObj == null) ||
                 (lVar11 = GameObject.get_transform(this.CircleObj,0)) == null)
              throw; // [null/range check failed]
              puVar9 = (uint64 *)Transform.get_localRotation(&local_a8,lVar11,0);
              local_98 = *puVar9;
              uStack_90 = puVar9[1];
              puVar9 = (uint64 *)Quaternion.get_eulerAngles(&local_a8,&local_98,0);
              if (lVar8 == null) throw; // [null/range check failed]
              lVar8.heroNickName = *puVar9;
              lVar8.isFemale = *(uint32 *)(puVar9 + 1);
              lVar8 = BigmapNpcController.get_CircleTweenRotation(this,0);
              puVar9 = (uint64 *)Quaternion.get_eulerAngles(&local_a8,this + 144,0);
              if (lVar8 == null) throw; // [null/range check failed]
              lVar8.belongForceID = *puVar9;
              lVar8.outsideForce = *(uint32 *)(puVar9 + 1);
              lVar8 = BigmapNpcController.get_CircleTweenRotation(this);
              if (lVar8 == null) throw; // [null/range check failed]
              UITweener.ResetToBeginning(lVar8);
              lVar8 = BigmapNpcController.get_CircleTweenRotation(this);
              if (lVar8 == null) throw; // [null/range check failed]
              UITweener.PlayForward(lVar8);
            }
          }
        }
        else {
        LAB_1809e697f:
          lVar8 = BigmapNpcController.get_ArrowTrans(this,0);
          puVar9 = (uint64 *)Vector3.get_zero(&local_a8,0);
          if (lVar8 == null) throw; // [null/range check failed]
          local_c0 = *(float *)(puVar9 + 1);
          local_c8 = *puVar9;
          Transform.set_localScale(lVar8,&local_c8,0);
        }
        BigmapNpcController.ManageFollowState(this);
        uVar12 = this.areaSafeRangeBuffer;
        cVar7 = Object.op_Inequality(uVar12,0,0);
        if (!cVar7) {
          uVar12 = this.areaSafeRange;
          cVar7 = Object.op_Inequality(uVar12,0,0);
          if (!(cVar7))
          {
            }
            else {
          }
          fVar18 = this.areaSafeRangeRefreshTime;
          fVar16 = (float)Time.get_deltaTime(0);
          fVar18 = fVar18 - fVar16;
          this.areaSafeRangeRefreshTime = fVar18;
          if (fVar18 <= 0.0) {
            uVar12 = this.areaSafeRangeBuffer;
            this.areaSafeRangeRefreshTime = 0x3dcccccd;
            cVar7 = Object.op_Inequality(uVar12,0,0);
            if (!cVar7) {
              this.areaSafeRange = 0;
              if (this.heroData == null) throw; // [null/range check failed]
              this.heroData.inSafeArea = 0;
            }
            else {
              this.areaSafeRangeBuffer = 0;
            }
          }
        }
        uVar12 = this.areaSafeRange;
        cVar7 = Object.op_Equality(uVar12,0,0);
        if (!cVar7) {
          fVar18 = 0.4;
        }
        else {
          fVar18 = 0.0;
        }
        if (this.SafeSprite == null) throw; // [null/range check failed]
        lVar8 = SpriteRenderer.get_color(&local_a8,this.SafeSprite,0);
        if (*(float *)(lVar8 + 12) != fVar18) {
          lVar8 = this.SafeSprite;
          if (lVar8 == null) throw; // [null/range check failed]
          puVar9 = (uint64 *)SpriteRenderer.get_color(&local_a8,lVar8,0);
          uVar12 = *puVar9;
          uVar13 = puVar9[1];
          local_a8 = uVar12;
          uStack_a0 = uVar13;
          puVar9 = (uint64 *)GlobalData.SetColorAlpha(&local_b8,&local_a8,fVar18,0);
          local_a8 = *puVar9;
          uStack_a0 = puVar9[1];
          SpriteRenderer.set_color(lVar8,&local_a8,0);
        }
        fVar18 = this.checkBigMapColliderTime;
        fVar16 = (float)Time.get_deltaTime(0);
        fVar18 = fVar18 - fVar16;
        this.checkBigMapColliderTime = fVar18;
        if (fVar18 < 0.0) {
          this.checkBigMapColliderTime = 0x3dcccccd;
          if (!this.inBigMapSpeEffectBuff) {
            this.inBigMapSpeEffectType = 0xffffffff;
          }
          this.inBigMapSpeEffectBuff = 0;
          if (!this.inWaterBuff) {
            if (this.heroData == null) throw; // [null/range check failed]
            this.heroData.inWater = 0;
            uVar12 = Component.GetComponent(this,DAT_181e771b8);
            cVar7 = Object.op_Inequality(uVar12,0,0);
            if (cVar7) {
              lVar8 = Component.GetComponent(this,DAT_181e771b8);
              if (lVar8 == null) throw; // [null/range check failed]
              lVar8.summonSourceHero = 0;
            }
          }
          this.inWaterBuff = 0;
          if (!this.inMountainBuff) {
            if (this.heroData == null) throw; // [null/range check failed]
            this.heroData.inMountain = 0;
          }
          this.inMountainBuff = 0;
          if (!this.inHillBuff) {
            if (this.heroData == null) throw; // [null/range check failed]
            this.heroData.inHill = 0;
          }
          this.inHillBuff = 0;
        }
        lVar8 = *(int64 *)(*(int64 *)(DAT_181e89f38 + 184) + 24);
        if (((this.heroData == null) ||
            (lVar11 = this.heroData.heroAIData) == null) || (lVar8 == null))
        throw; // [null/range check failed]
        cVar7 = FUN_18176a2d0(lVar8,*(uint32 *)(lVar11 + 16),DAT_181e5cbe8);
        lVar8 = this.BigMapFightIcon;
        iVar14 = 1;
        if (!cVar7) {
          cVar7 = Object.op_Inequality(lVar8,0,0);
          if (cVar7) {
            if (*plVar1 == 0) throw; // [null/range check failed]
            cVar7 = GameObject.get_activeSelf(*plVar1,0);
            if (cVar7) {
              if (*plVar1 == 0) throw; // [null/range check failed]
              GameObject.SetActive(*plVar1,0,0);
              if (*plVar1 == 0) throw; // [null/range check failed]
              uVar12 = GameObject.get_transform(*plVar1,0);
              ShortcutExtensions.DOKill(uVar12,0,0);
            }
          }
        }
        else {
          cVar7 = Object.op_Equality(lVar8,0,0);
          if (!cVar7) {
            if (*plVar1 == 0) throw; // [null/range check failed]
            cVar7 = GameObject.get_activeSelf(*plVar1,0);
            if (!cVar7) {
              if (*plVar1 == 0) throw; // [null/range check failed]
              GameObject.SetActive(*plVar1,1,0);
              goto LAB_1809e6e9e;
            }
          }
          else {
            lVar8 = FUN_180210220(0);
            if (lVar8 == null) throw; // [null/range check failed]
            uVar12 = lVar8.generation;
            uVar13 = this.BigMapFightIconPrefab;
            lVar8 = GlobalData.AddChild(uVar12,uVar13,0);
            *plVar1 = lVar8;
            il2cpp_internal(plVar1,lVar8);
        LAB_1809e6e9e:
            if (*plVar1 == 0) throw; // [null/range check failed]
            uVar12 = GameObject.get_transform(*plVar1,0);
            uVar12 = ShortcutExtensions.DOScale(uVar12,0x3f99999a,0x3f000000,0);
            TweenSettingsExtensions.SetLoops(uVar12,0xffffffff,1,DAT_181ea4f40);
          }
          if (*plVar1 == 0) throw; // [null/range check failed]
          lVar8 = GameObject.get_transform(*plVar1,0);
          lVar11 = Component.get_transform(this,0);
          if ((lVar11 == null) ||
             (puVar9 = (uint64 *)Transform.get_position(&local_a8,lVar11,0), lVar8 == null))
          throw; // [null/range check failed]
          local_c8 = *puVar9;
          local_c0 = *(float *)(puVar9 + 1);
          Transform.set_position(lVar8,&local_c8,0);
        }
        if (this.needRefresh) {
          BigmapNpcController.RefreshHeroSkeleton(this,0);
        }
        lVar8 = this.heroData;
        if ((lVar8 == null) || (lVar8.heroAIData == null)) throw; // [null/range check failed]
        iVar2 = *(int *)(lVar8.heroAIData + 16);
        if (iVar2 == 13) {
          uVar12 = this.selfSkeleton;
          uVar13 = HeroData.GetHeroWeaponAttackAnim(lVar8,0);
          BigmapNpcController.SetSkeletonAttackAnim(this,uVar12,uVar13,0);
        }
        else {
          if ((lVar8.heroID == null) || (iVar2 == 1)) {
            lVar8 = BigmapNpcController.GetHeroTargetPos(this,0);
            if (lVar8 == null) throw; // [null/range check failed]
            if ((lVar8.isSummon == null.0) && (lVar8.summonID == null.0)) {
              bVar15 = false;
            }
            else {
              bVar15 = true;
            }
            uVar12 = this.selfSkeleton;
            lVar8 = this.heroData;
            if (bVar15) {
              lVar11 = Component.get_transform(this,0);
              if (lVar11 == null) throw; // [null/range check failed]
              puVar9 = (uint64 *)Transform.get_localPosition(&local_a8,lVar11,0);
              uVar13 = *puVar9;
              fVar18 = *(float *)(puVar9 + 1);
              lVar11 = BigmapNpcController.GetHeroTargetPos(this,0);
              if (lVar11 == null) throw; // [null/range check failed]
              local_c8 = uVar13;
              local_c0 = fVar18;
              BigmapNpcController.SetSkeletonRunAnim
                        (this,uVar12,lVar8,&local_c8,
                         CONCAT44(*(float *)(lVar11 + 20) * 0.01,*(float *)(lVar11 + 16) * 0.01),0);
              goto LAB_1809e707e;
            }
          }
          else {
            uVar12 = this.selfSkeleton;
          }
          BigmapNpcController.SetSkeletonIdleAnim(this,uVar12,lVar8,0);
        }
        LAB_1809e707e:
        BigmapNpcController.ManageFollowerMove(this,0);
        lVar8 = *(int64 *)(*(int64 *)(DAT_181e90e50 + 184) + 16);
        if (lVar8 == null) throw; // [null/range check failed]
        fVar18 = (float)BigMapController.BigMapNowScale(lVar8,0);
        if (fVar18 < **(float **)(DAT_181e90e50 + 184)) {
          BigmapNpcController.SetAllSkeletonActive(this,0,0);
          if (this.heroSimpleSprite == null) throw; // [null/range check failed]
          cVar7 = GameObject.get_activeSelf(this.heroSimpleSprite,0);
          fVar18 = 1.0;
          if (!cVar7) {
            if (this.heroSimpleSprite == null) throw; // [null/range check failed]
            GameObject.SetActive(this.heroSimpleSprite,1,0);
            if (this.heroSimpleSprite == null) throw; // [null/range check failed]
            lVar8 = GameObject.GetComponent(this.heroSimpleSprite,DAT_181e56c80);
            if ((this.heroSimpleSprite == null) ||
               (lVar11 = GameObject.GetComponent(this.heroSimpleSprite,DAT_181e56c80),
               lVar11 == null)) throw; // [null/range check failed]
            puVar9 = (uint64 *)SpriteRenderer.get_color(&local_a8,lVar11,0);
            uVar12 = *puVar9;
            uVar13 = puVar9[1];
            local_a8 = uVar12;
            uStack_a0 = uVar13;
            puVar9 = (uint64 *)GlobalData.SetColorAlpha(&local_b8,&local_a8,0,0);
            if (lVar8 == null) throw; // [null/range check failed]
            local_a8 = *puVar9;
            uStack_a0 = puVar9[1];
            SpriteRenderer.set_color(lVar8,&local_a8,0);
            if (this.heroSimpleSprite == null) throw; // [null/range check failed]
            uVar12 = GameObject.GetComponent(this.heroSimpleSprite,DAT_181e56c80);
            DOTweenModuleSprite.DOFade(uVar12,0x3f800000,0x3ecccccd,0);
          }
          if (this.heroSimpleSprite == null) throw; // [null/range check failed]
          lVar8 = GameObject.get_transform(this.heroSimpleSprite,0);
          puVar9 = (uint64 *)Vector3.get_one(&local_a8,0);
          if (this.heroData == null) throw; // [null/range check failed]
          if (this.heroData.heroID == null) {
            fVar18 = 1.5;
          }
          local_c8 = *puVar9;
          fVar19 = (float)local_c8;
          uVar6 = (uint64)local_c8 >> 32;
          local_c0 = *(float *)(puVar9 + 1);
          fVar16 = this.originSimpleSpriteScale;
          fVar17 = (float)BigmapNpcController.GetBigMapExtraScale(this,0x40000000,0);
          local_d0 = local_c0 * fVar18 * fVar16 * fVar17;
          local_d8 = CONCAT44((float)uVar6 * fVar18 * fVar16 * fVar17,fVar19 * fVar18 * fVar16 * fVar17);
          if (lVar8 == null) throw; // [null/range check failed]
          local_c8 = local_d8;
          local_c0 = local_d0;
          Transform.set_localScale(lVar8,&local_c8,0);
          lVar8 = this.hoverRangeCollider;
          fVar18 = this.originCapsuleColliderRadius;
          fVar16 = (float)BigmapNpcController.GetBigMapExtraScale(this,0x40000000,0);
          if (lVar8 == null) throw; // [null/range check failed]
          CapsuleCollider.set_radius(lVar8,fVar16 * fVar18,0);
          lVar8 = this.hoverRangeCollider;
          fVar18 = this.originCapsuleColliderHeight;
          fVar16 = (float)BigmapNpcController.GetBigMapExtraScale(this,0x40000000,0);
          if (lVar8 == null) throw; // [null/range check failed]
          CapsuleCollider.set_height(lVar8,fVar16 * fVar18,0);
          local_c0 = *(float *)(this + 244);
          lVar8 = this.hoverRangeCollider;
          uVar12 = this.originCapsuleColliderCenter;
          fVar16 = (float)BigmapNpcController.GetBigMapExtraScale(this,0x40000000,0);
          fVar17 = fVar16 * (float)uVar12;
          fVar18 = fVar16 * local_c0;
          fVar16 = fVar16 * (float)((uint64)uVar12 >> 32);
          local_d8 = CONCAT44(fVar16,fVar17);
          local_d0 = fVar18;
          local_c8 = uVar12;
          if (lVar8 == null) throw; // [null/range check failed]
        LAB_1809e7493:
          local_c8 = CONCAT44(fVar16,fVar17);
          local_c0 = fVar18;
          CapsuleCollider.set_center(lVar8,&local_c8,0);
        }
        else {
          BigmapNpcController.SetAllSkeletonActive(this,1);
          if (this.heroSimpleSprite == null) throw; // [null/range check failed]
          cVar7 = GameObject.get_activeSelf(this.heroSimpleSprite,0);
          if (cVar7) {
            if (this.heroSimpleSprite == null) throw; // [null/range check failed]
            GameObject.SetActive(this.heroSimpleSprite,0,0);
            if (this.hoverRangeCollider == null) throw; // [null/range check failed]
            CapsuleCollider.set_radius(this.hoverRangeCollider,this.originCapsuleColliderRadius,0);
            if (this.hoverRangeCollider == null) throw; // [null/range check failed]
            CapsuleCollider.set_height(this.hoverRangeCollider,this.originCapsuleColliderHeight,0);
            lVar8 = this.hoverRangeCollider;
            if (lVar8 == null) throw; // [null/range check failed]
            fVar17 = (float)this.originCapsuleColliderCenter;
            fVar16 = (float)((uint64)this.originCapsuleColliderCenter >> 32);
            fVar18 = *(float *)(this + 244);
            goto LAB_1809e7493;
          }
        }
        if (this.heroMissionTarget != null) {
          lVar8 = GameObject.get_transform(this.heroMissionTarget,0);
          puVar9 = (uint64 *)Vector3.get_one(&local_a8,0);
          local_c8 = *puVar9;
          fVar16 = (float)local_c8;
          uVar6 = (uint64)local_c8 >> 32;
          local_c0 = *(float *)(puVar9 + 1);
          fVar18 = (float)BigmapNpcController.GetBigMapExtraScale(this,0x40800000,0);
          local_d0 = local_c0 * 0.5 * fVar18;
          local_d8 = CONCAT44((float)uVar6 * 0.5 * fVar18,fVar16 * 0.5 * fVar18);
          if (lVar8 != null) {
            local_c8 = local_d8;
            local_c0 = local_d0;
            Transform.set_localScale(lVar8,&local_c8,0);
            lVar8 = this.heroData;
            if (lVar8 != null) {
              if ((lVar8.plotNumCount < 1) && (iVar14 = 0, 0 < lVar8.missionNumCount)) {
                iVar14 = 2;
              }
              if (this.missionState != iVar14) {
                bVar15 = !DAT_181eb7df4;
                this.missionState = iVar14;
                if (bVar15) {
                  il2cpp_runtime_class_init(&DAT_181e56c80);
                  il2cpp_runtime_class_init(&DAT_181e6e5e8);
                  DAT_181eb7df4 = true;
                }
                uVar12 = this.heroMissionRenderer;
                cVar7 = Object.op_Equality(uVar12,0,0);
                if (cVar7) {
                  uVar12 = this.heroMissionTarget;
                  cVar7 = Object.op_Inequality(uVar12,0,0);
                  if (cVar7) {
                    if (this.heroMissionTarget == null) throw; // [null/range check failed]
                    uVar12 = GameObject.GetComponent(this.heroMissionTarget,DAT_181e56c80);
                    this.heroMissionRenderer = uVar12;
                  }
                }
                lVar8 = this.heroMissionRenderer;
                if (this.missionState == 1) {
                  if ((*pStatics == 0) ||
                     (uVar12 = TextureController.LoadAtlasSprite
                                         (*pStatics,"BigMapAtlas",
                                          "问号",0), lVar8 == null)) throw; // [null/range check failed]
                  SpriteRenderer.set_sprite(lVar8,uVar12,0);
                  puVar9 = (uint64 *)Color.get_yellow(&local_a8,0);
                }
                else if (this.missionState == 2) {
                  if ((*pStatics == 0) ||
                     (uVar12 = TextureController.LoadAtlasSprite
                                         (*pStatics,"BigMapAtlas",
                                          "任务目标",0), lVar8 == null)) throw; // [null/range check failed]
                  SpriteRenderer.set_sprite(lVar8,uVar12,0);
                  puVar9 = (uint64 *)FUN_180f24d00(&local_a8,0);
                }
                else {
                  puVar9 = (uint64 *)FUN_180af4e90(&local_a8,0);
                  if (lVar8 == null) throw; // [null/range check failed]
                }
                local_a8 = *puVar9;
                uStack_a0 = puVar9[1];
                SpriteRenderer.set_color(lVar8,&local_a8,0);
              }
              return;
            }
          }
        }
    }

    // Token : 0x6000D36
    // RVA   : 0x9E8B30   Offset: 0x9E7930   Length: 0x5C
    public bool IsMoving()
    {
        long lVar1;
        lVar1 = this.heroData;
        if (lVar1 != null) {
          if (lVar1.heroID != null) {
            if (lVar1.heroAIData == null) throw; // [null/range check failed]
            if (*(int *)(lVar1.heroAIData + 16) != 1) {
              return false;
            }
          }
          lVar1 = BigmapNpcController.GetHeroTargetPos(this,0);
          if (lVar1 != null) {
            if ((lVar1.isSummon == null.0) && (lVar1.summonID == null.0)) {
              return false;
            }
            return true;
          }
        }
    }

    // Token : 0x6000D37
    // RVA   : 0x9EA5D0   Offset: 0x9E93D0   Length: 0x167
    public void RefreshSkeletonAnim()
    {
        ulong uVar1;
        int iVar2;
        uint uVar3;
        ulong uVar4;
        long lVar6;
        ulong uVar8;
        ulong local_28;
        uint local_20;
        lVar6 = this.heroData;
        if ((lVar6 == null) || (lVar6.heroAIData == null)) goto LAB_1809ea732;
        iVar2 = *(int *)(lVar6.heroAIData + 16);
        if (iVar2 == 13) {
          uVar4 = this.selfSkeleton;
          uVar8 = HeroData.GetHeroWeaponAttackAnim(lVar6,0);
          BigmapNpcController.SetSkeletonAttackAnim(this,uVar4,uVar8,0);
        }
        else {
          if ((lVar6.heroID == null) || (iVar2 == 1)) {
            lVar6 = BigmapNpcController.GetHeroTargetPos(this,0);
            if (lVar6 == null) {
        LAB_1809ea732:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            if ((lVar6.isSummon == null.0) && (lVar6.summonID == null.0)) {
              bVar5 = false;
            }
            else {
              bVar5 = true;
            }
            if (bVar5) {
              uVar4 = this.selfSkeleton;
              uVar8 = this.heroData;
              lVar6 = Component.get_transform(this,0);
              if (lVar6 != null) {
                puVar7 = (uint64 *)Transform.get_localPosition(&local_28,lVar6,0);
                uVar1 = *puVar7;
                uVar3 = *(uint32 *)(puVar7 + 1);
                lVar6 = BigmapNpcController.GetHeroTargetPos(this,0);
                if (lVar6 != null) {
                  local_28 = uVar1;
                  local_20 = uVar3;
                  BigmapNpcController.SetSkeletonRunAnim
                            (this,uVar4,uVar8,&local_28,
                             CONCAT44(lVar6.summonID * 0.01,lVar6.isSummon * 0.01),0);
                  return;
                }
              }
              goto LAB_1809ea732;
            }
          }
          BigmapNpcController.SetSkeletonIdleAnim
                    (this,this.selfSkeleton,this.heroData,0);
        }
    }

    // Token : 0x6000D38
    // RVA   : 0x9E77E0   Offset: 0x9E65E0   Length: 0x176
    public float GetBigMapExtraScale(float extraScale)
    {
        float fVar1;
        float fVar2;
        long lVar3;
        float fVar4;
        fVar1 = **(float **)(DAT_181e90e50 + 184);
        lVar3 = GameController.CheckShowSpeHero;
        if (lVar3 != null) {
          fVar4 = (float)BigMapController.BigMapNowScale(lVar3,0);
          fVar2 = **(float **)(DAT_181e90e50 + 184);
          lVar3 = GameController.CheckShowSpeHero;
          if (lVar3 != null) {
            Mathf.Max(lVar3,((fVar1 - fVar4) * extraScale) / (fVar2 - *(float *)(lVar3 + 28)) + 1.0,0);
            return;
          }
        }
    }

    // Token : 0x6000D39
    // RVA   : 0x9EABF0   Offset: 0x9E99F0   Length: 0x13A
    public void SetAllSkeletonActive(bool isActive)
    {
        bool cVar1;
        long lVar2;
        uint uVar3;
        long lVar4;
        if (this.selfSkeleton != null) {
          cVar1 = GameObject.get_activeSelf(this.selfSkeleton,0);
          if (cVar1 != isActive) {
            if (this.selfSkeleton == null) throw; // [null/range check failed]
            GameObject.SetActive(this.selfSkeleton,isActive,0);
          }
          lVar2 = this.followers;
          uVar3 = 0;
          if (lVar2 != null) {
            lVar4 = 32;
            while( true ) {
              if (lVar2.Count <= (int)uVar3) {
                return;
              }
              if (lVar2 == null) break;
              if (lVar2.Count <= uVar3) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(lVar4 + lVar2._items);
              if ((lVar2 = lVar2?._items) == null) break;
              cVar1 = GameObject.get_activeSelf(lVar2,0);
              if (cVar1 != isActive) {
                if (((this.followers == null) ||
                    (lVar2 = FUN_1800024b0(this.followers,uVar3,DAT_181e61ef8)) == null
                    ) || (lVar2._items == null)) break;
                GameObject.SetActive(lVar2._items,isActive,0);
              }
              lVar2 = this.followers;
              uVar3 = uVar3 + 1;
              lVar4 = lVar4 + 8;
              if (lVar2 == null) break;
            }
          }
        }
    }

    // Token : 0x6000D3A
    // RVA   : 0x9E7E90   Offset: 0x9E6C90   Length: 0x207
    public bool HeroCanFollow(BigmapNpcController targetHero, HeroFollowType followType, float rangeRate)
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        float fVar5;
        float extraout_XMM0_Da;
        uint8 local_38 [48];
        cVar2 = Object.op_Inequality(targetHero,0,0);
        if (cVar2) {
          if ((targetHero == null) || (lVar3 = Component.get_gameObject(targetHero,0)) == null)
          goto LAB_1809e8092;
          cVar2 = GameObject.get_activeSelf(lVar3,0);
          if (cVar2) {
            cVar2 = Object.op_Inequality(targetHero,this,0);
            if (cVar2) {
              uVar1 = *(uint64 *)(targetHero + 184);
              cVar2 = Object.op_Equality(uVar1,0,0);
              if ((cVar2) || (followType != 1)) {
                lVar3 = *(int64 *)(targetHero + 24);
                if (lVar3 != null) {
                  if (*(int *)(lVar3 + 88) != 0) {
                    if (*(int64 *)(lVar3 + 64) == 0) goto LAB_1809e8092;
                    if (*(int *)(*(int64 *)(lVar3 + 64) + 16) != 1) {
                      return false;
                    }
                  }
                  lVar3 = Component.get_transform(this,0);
                  if (lVar3 != null) {
                    puVar4 = (uint64 *)Transform.get_localPosition(local_38,lVar3,0);
                    uVar1 = *puVar4;
                    lVar3 = Component.get_transform(targetHero,0);
                    if (lVar3 != null) {
                      puVar4 = (uint64 *)Transform.get_localPosition(local_38,lVar3,0);
                      fVar5 = (float)Vector2.Distance(uVar1,*puVar4,0);
                      if (this.seeRangeCollider != null) {
                        SphereCollider.get_radius(this.seeRangeCollider,0);
                        return fVar5 < extraout_XMM0_Da * rangeRate;
                      }
                    }
                  }
                }
        LAB_1809e8092:
                          // WARNING: Subroutine does not return
                FUN_1801e0300();
              }
            }
          }
        }
        return false;
    }

    // Token : 0x6000D3B
    // RVA   : 0x9E8B90   Offset: 0x9E7990   Length: 0x101
    public static BigMapPos LimitBigMapTargetPos(BigMapPos target)
    {
        var pStatics = *(int64*)(DAT_181e538e8 + 184);
        uint uVar1;
        long lVar2;
        uint uVar3;
        lVar2 = new ZhSegment(0);
        if (target != null) {
          uVar3 = *(uint32 *)(target + 16);
          uVar1 = *(uint32 *)(pStatics + 0x10c);
          uVar3 = FUN_180f34e60(uVar3,uVar1 ^ 0x80000000,uVar1,0);
          if (lVar2 != null) {
            *(uint32 *)(lVar2 + 16) = uVar3;
            uVar1 = *(uint32 *)(pStatics + 0x110);
            uVar3 = FUN_180f34e60(*(uint32 *)(target + 20),uVar1 ^ 0x80000000,uVar1,0);
            *(uint32 *)(lVar2 + 20) = uVar3;
            return lVar2;
          }
        }
    }

    // Token : 0x6000D3C
    // RVA   : 0x9E79A0   Offset: 0x9E67A0   Length: 0x36C
    public BigMapPos GetHeroTargetPos()
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        long lVar4;
        long lVar5;
        ulong uVar7;
        float fVar8;
        float fVar9;
        byte[] local_28 = new byte[32];
        uVar7 = *(uint64 *)(this + 200);
        cVar3 = Object.op_Inequality(uVar7,0,0);
        if (!cVar3) {
          uVar7 = this.heroFollowTarget;
          cVar3 = Object.op_Inequality(uVar7,0,0);
          if (!cVar3) {
            if ((this.heroData != null) &&
               (lVar5 = this.heroData.heroAIData) != null) {
              return *(uint64 *)(lVar5 + 56);
            }
        LAB_1809e7d07:
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          if (this.heroFollowType == 1) {
            if (((this.heroFollowTarget != null) &&
                (lVar5 = GameObject.GetComponent(this.heroFollowTarget,DAT_181e53760), lVar5 != null
                )) && (*(int64 *)(lVar5 + 24) != 0)) {
              return *(uint64 *)(*(int64 *)(lVar5 + 24) + 200);
            }
            goto LAB_1809e7d07;
          }
          if (this.heroData == null) goto LAB_1809e7d07;
          lVar5 = this.heroData.bigMapPos;
          if (((this.heroFollowTarget == null) ||
              (lVar4 = GameObject.GetComponent(this.heroFollowTarget,DAT_181e53760)) == null)
             || ((*(int64 *)(lVar4 + 24) == 0 ||
                 ((lVar5 == null || (lVar4 = *(int64 *)(*(int64 *)(lVar4 + 24) + 200)) == null)))
                )) goto LAB_1809e7d07;
          lVar2 = this.heroData;
          fVar8 = (float)FUN_1801e6830(*(float *)(lVar4 + 20) - *(float *)(lVar5 + 20),0x40000000);
          fVar9 = (float)FUN_1801e6830(*(float *)(lVar4 + 16) - *(float *)(lVar5 + 16));
          fVar8 = fVar8 + fVar9;
          if (fVar8 < 0.0) {
            fVar8 = (float)FUN_1801e8bb8(fVar8);
          }
          else {
            fVar8 = SQRT(fVar8);
          }
          if (fVar8 < 0.1) {
            if ((lVar2 == null) || (lVar2.heroAIData == null)) goto LAB_1809e7d07;
            uVar7 = *(uint64 *)(lVar2.heroAIData + 56);
            goto LAB_1809e7cda;
          }
          if (lVar2 == null) goto LAB_1809e7d07;
          uVar7 = BigMapPos.op_Multiply(lVar2.bigMapPos,0x40000000,0);
          if (((this.heroFollowTarget == null) ||
              (lVar5 = GameObject.GetComponent(this.heroFollowTarget,DAT_181e53760)) == null)
             || (*(int64 *)(lVar5 + 24) == 0)) goto LAB_1809e7d07;
          lVar5 = *(int64 *)(*(int64 *)(lVar5 + 24) + 200);
        }
        else {
          if (this.heroData == null) goto LAB_1809e7d07;
          uVar7 = BigMapPos.op_Multiply
                            (this.heroData.bigMapPos,0x40000000,0);
          if (((*(int64 *)(this + 200) == 0) ||
              (lVar5 = GameObject.get_transform(*(int64 *)(this + 200),0)) == null) ||
             (lVar5 = FUN_180b05920(lVar5,0)) == null) goto LAB_1809e7d07;
          puVar6 = (uint64 *)Transform.get_localPosition(local_28,lVar5,0);
          uVar1 = *puVar6;
          lVar5 = new ZhSegment(0);
          *(float *)(lVar5 + 16) = (float)uVar1 * 100.0;
          *(float *)(lVar5 + 20) = (float)((uint64)uVar1 >> 32) * 100.0;
        }
        uVar7 = BigMapPos.op_Subtraction(uVar7,lVar5,0);
        LAB_1809e7cda:
        uVar7 = BigmapNpcController.LimitBigMapTargetPos(uVar7,0);
        return uVar7;
    }

    // Token : 0x6000D3D
    // RVA   : 0x9E63C0   Offset: 0x9E51C0   Length: 0x10B
    public HeroFollowType ConsiderHeroFollowType(BigmapNpcController target)
    {
        bool cVar1;
        float fVar2;
        double dVar3;
        float fVar4;
        cVar1 = Object.op_Equality(target,0,0);
        if (!cVar1) {
          dVar3 = (double)GlobalData.RandomRangeDouble(0,0);
          if (target != null) {
            fVar2 = (float)GlobalData.CaculateWinRate
                                     (this.heroData,*(uint64 *)(target + 24),1,0)
            ;
            if (this.heroData != null) {
              if (!this.heroData.isRandomEnemy) {
                fVar4 = 1.5;
              }
              else {
                fVar4 = 2.5;
              }
              return ((double)(fVar2 * fVar4) <= dVar3) + true;
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        return false;
    }

    // Token : 0x6000D3E
    // RVA   : 0x9E7980   Offset: 0x9E6780   Length: 0x1D
    public float GetBigMapTravelSpeed()
    {
        if (param_2 != 0) {
          HeroData.GetFinalTravelSpeed(param_2,0);
          return;
        }
    }

    // Token : 0x6000D3F
    // RVA   : 0x9E7960   Offset: 0x9E6760   Length: 0x1F
    public float GetBigMapTravelSpeed(HeroData targetHero)
    {
        if (targetHero != null) {
          HeroData.GetFinalTravelSpeed(targetHero,0);
          return;
        }
    }

    // Token : 0x6000D40
    // RVA   : 0x9EB010   Offset: 0x9E9E10   Length: 0x2EE
    public void SetSkeletonRunAnim(GameObject targetSkeleton, HeroData targetHero, Vector3 originPos, Vector2 nextPos)
    {
        void BigmapNpcController.SetSkeletonRunAnim
                     (uint64 this,int64 targetSkeleton,int64 targetHero,float *originPos,float nextPos)
        {
        int64 lVar1;
        char cVar2;
        int64 lVar3;
        int64 lVar4;
        uint32 *puVar5;
        uint64 uVar6;
        uint64 uVar7;
        float fVar8;
        float fVar9;
        uint32 local_38;
        uint32 uStack_34;
        uint32 uStack_30;
        uint32 uStack_2c;
        cVar2 = Object.op_Equality(targetSkeleton,0,0);
        if (cVar2) {
          return;
        }
        if (targetHero == null) {
          return;
        }
        lVar3 = BigmapNpcController.GetSkeletonAnim(this,targetSkeleton,0);
        if (*originPos < nextPos) {
          if (targetSkeleton == null) throw; // [null/range check failed]
          lVar4 = GameObject.get_transform(targetSkeleton,0);
          puVar5 = (uint32 *)Quaternion.get_identity(&local_38,0);
          if (lVar4 == null) throw; // [null/range check failed]
          local_38 = *puVar5;
          uStack_34 = puVar5[1];
          uStack_30 = puVar5[2];
          uStack_2c = puVar5[3];
        LAB_1809eb158:
          Transform.set_localRotation(lVar4,&local_38,0);
        }
        else if (nextPos < *originPos) {
          if (targetSkeleton == null) throw; // [null/range check failed]
          lVar4 = GameObject.get_transform(targetSkeleton,0);
          lVar1 = *(int64 *)(DAT_181e538e8 + 184);
          if (lVar4 == null) throw; // [null/range check failed]
          local_38 = *(uint32 *)(lVar1 + 0x6b0);
          uStack_34 = *(uint32 *)(lVar1 + 0x6b4);
          uStack_30 = *(uint32 *)(lVar1 + 0x6b8);
          uStack_2c = *(uint32 *)(lVar1 + 0x6bc);
          goto LAB_1809eb158;
        }
        fVar8 = (float)HeroData.GetFinalTravelSpeed(targetHero,0);
        fVar9 = 1.0;
        if (fVar8 < 1.0) {
          fVar8 = fVar8 * 0.5 + 0.5;
        }
        lVar4 = FUN_180210220(0);
        if (lVar4 != null) {
          if (*(char *)(lVar4 + 233) != false) {
            fVar9 = 1.5;
          }
          if ((lVar3 != null) && (*(float *)(lVar3 + 300) = fVar9 * fVar8, targetSkeleton != null)) {
            cVar2 = GameObject.get_activeSelf(targetSkeleton,0);
            if ((cVar2) && (cVar2 = Behaviour.get_enabled(lVar3,0), cVar2)) {
              lVar4 = SkeletonAnimation.get_AnimationState(lVar3,0);
              if (lVar4 == null) throw; // [null/range check failed]
              lVar4 = AnimationState.GetCurrent(lVar4,0,0);
              if (lVar4 != null) {
                lVar4 = SkeletonAnimation.get_AnimationState(lVar3,0);
                if (((lVar4 == null) || (lVar4 = AnimationState.GetCurrent(lVar4,0,0)) == null) ||
                   (*(int64 *)(lVar4 + 16) == 0)) throw; // [null/range check failed]
                uVar7 = *(uint64 *)(*(int64 *)(lVar4 + 16) + 16);
                uVar6 = HeroData.GetSkeletonHorseRunAnim(targetHero,0);
                cVar2 = String.op_Inequality(uVar7,uVar6,0);
                if (!cVar2) {
                  return;
                }
              }
              uVar7 = HeroData.GetSkeletonHorseRunAnim(targetHero,0);
              GlobalData.SetSkeletonAnimationFromRandomStart(lVar3,0,uVar7,1,0);
            }
            return;
          }
        }
    }

    // Token : 0x6000D41
    // RVA   : 0x9E8F30   Offset: 0x9E7D30   Length: 0x9AF
    public void ManageFollowerMove()
    {
        uint uVar1;
        float fVar2;
        bool cVar3;
        uint uVar4;
        long lVar5;
        long lVar7;
        ulong uVar8;
        ulong uVar9;
        uint uVar12;
        long lVar13;
        float fVar14;
        float fVar15;
        uint64 local_1c8;
        uint64 local_1a8;
        float local_1a0;
        float local_198;
        float fStack_194;
        uint32 local_190;
        uint64 local_188;
        uint64 local_178;
        uint64 local_168;
        uint32 local_160;
        float local_150;
        uint64 local_148;
        uint32 local_140;
        uint64 local_138;
        uint32 local_130;
        float local_120;
        uint8 local_118 [16];
        uint8 local_108 [16];
        uint8 local_f8 [16];
        uint8 local_e8 [16];
        uint8 local_d8 [16];
        uint8 local_c8 [16];
        uint8 local_b8 [16];
        uint8 local_a8 [16];
        uint8 local_98 [16];
        uint8 local_88 [96];
        uVar12 = 0;
        local_1a8 = 0;
        local_1a0 = 0.0;
        lVar5 = this.followers;
        if (lVar5 != null) {
          lVar13 = 32;
          do {
            if (lVar5.Count <= (int)uVar12) {
              return;
            }
            Vector2.get_zero(0);
            lVar5 = Component.get_transform(this,0);
            if (lVar5 == null) break;
            puVar6 = (uint64 *)Transform.get_localPosition(local_118,lVar5,0);
            uVar8 = *puVar6;
            lVar5 = this.followers;
            if (lVar5 == null) break;
            if (lVar5.Count <= uVar12) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar13 + lVar5._items);
            if (((lVar5 = lVar5?._items) == null) ||
               (lVar5 = GameObject.get_transform(lVar5,0)) == null) break;
            puVar6 = (uint64 *)Transform.get_localPosition(local_108,lVar5,0);
            fVar14 = (float)Vector2.Distance(uVar8,*puVar6,0);
            lVar5 = this.followers;
            if (lVar5 == null) break;
            if (lVar5.Count <= uVar12) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar5 = *(int64 *)(lVar13 + lVar5._items);
            if (lVar5 == null) break;
            if (lVar5.Count + 0.0001 < fVar14) {
              if (((this.followers == null) ||
                  (lVar5 = FUN_1800024b0(this.followers,uVar12,DAT_181e61ef8)) == null)
                 || ((lVar5._items == null ||
                     (lVar5 = GameObject.get_transform(lVar5._items,0)) == null)))
              break;
              pfVar11 = (float *)Transform.get_localPosition(local_c8,lVar5,0);
              fVar15 = *pfVar11;
              if (((this.followers == null) ||
                  (lVar5 = FUN_1800024b0(this.followers,uVar12,DAT_181e61ef8)) == null)
                 || ((lVar5._items == null ||
                     (lVar5 = GameObject.get_transform(lVar5._items,0)) == null)))
              break;
              lVar5 = Transform.get_localPosition(local_b8,lVar5,0);
              fVar2 = *(float *)(lVar5 + 4);
              local_1c8 = CONCAT44(fVar2,fVar15);
              if ((((this.followers == null) ||
                   (lVar5 = FUN_1800024b0(this.followers,uVar12,DAT_181e61ef8)) == null
                   ) || (lVar5._items == null)) ||
                 (lVar5 = GameObject.get_transform(lVar5._items,0)) == null) break;
              puVar6 = (uint64 *)Transform.get_localPosition(local_a8,lVar5,0);
              local_178 = *puVar6;
              lVar5 = Component.get_transform(this,0);
              if (lVar5 == null) break;
              puVar6 = (uint64 *)Transform.get_localPosition(local_98,lVar5,0);
              local_150 = *(float *)(puVar6 + 1);
              local_1a0 = local_150 - 0.0;
              local_1a8 = CONCAT44((float)((uint64)*puVar6 >> 32) - fVar2,(float)*puVar6 - fVar15);
              local_120 = local_1a0;
              puVar6 = (uint64 *)Vector3.get_normalized(local_88,&local_1a8,0);
              local_188 = *puVar6;
              if ((this.followers == null) ||
                 (lVar5 = FUN_1800024b0(this.followers,uVar12,DAT_181e61ef8)) == null)
              break;
              fVar14 = fVar14 - lVar5.Count;
              fVar15 = (float)local_188 * fVar14 + (float)local_178;
              fVar14 = local_188._4_4_ * fVar14 + local_178._4_4_;
              if ((this.followers == null) ||
                 (lVar5 = FUN_1800024b0(this.followers,uVar12,DAT_181e61ef8)) == null)
              break;
              uVar8 = lVar5._items;
              lVar5 = FUN_1802106e0(0);
              if (lVar5 == null) break;
              lVar5 = *(int64 *)(lVar5 + 32);
              if (((this.followers == null) ||
                  (lVar7 = FUN_1800024b0(this.followers,uVar12,DAT_181e61ef8)) == null)
                 || (*(int64 *)(lVar7 + 16) == 0)) break;
              uVar9 = Object.get_name(*(int64 *)(lVar7 + 16),0);
              uVar4 = Int32.Parse(uVar9,0);
              if (lVar5 == null) break;
              uVar9 = WorldData.GetHero(lVar5,uVar4,0);
              local_148 = local_1c8;
              local_140 = 0;
              BigmapNpcController.SetSkeletonRunAnim
                        (this,uVar8,uVar9,&local_148,CONCAT44(fVar14,fVar15),0);
              if (((this.followers == null) ||
                  (lVar5 = FUN_1800024b0(this.followers,uVar12,DAT_181e61ef8)) == null)
                 || (lVar5._items == null)) break;
              lVar5 = GameObject.get_transform(lVar5._items,0);
              local_190 = 0;
              local_198 = fVar15;
              fStack_194 = fVar14;
              if (lVar5 == null) break;
              local_138 = CONCAT44(fVar14,fVar15);
              local_130 = 0;
              Transform.set_localPosition(lVar5,&local_138,0);
              lVar5 = FUN_180210220(0);
              if ((((this.followers == null) ||
                   (lVar7 = FUN_1800024b0(this.followers,uVar12)) == null) ||
                  (*(int64 *)(lVar7 + 16) == 0)) ||
                 (GameObject.get_transform(*(int64 *)(lVar7 + 16),0), lVar5 == null)) break;
              BigMapController.SetBigMapHeroZPos(lVar5);
            }
            else {
              if ((this.heroData == null) ||
                 (lVar5 = this.heroData.heroAIData) == null) break;
              if (lVar5._items == 13) {
                if ((this.followers == null) ||
                   (lVar5 = FUN_1800024b0(this.followers,uVar12,DAT_181e61ef8)) == null
                   ) break;
                uVar8 = lVar5._items;
                lVar5 = FUN_1802106e0(0);
                if (lVar5 == null) break;
                lVar5 = *(int64 *)(lVar5 + 32);
                if (((this.followers == null) ||
                    (lVar7 = FUN_1800024b0(this.followers,uVar12,DAT_181e61ef8), lVar7 == null
                    )) || (*(int64 *)(lVar7 + 16) == 0)) break;
                uVar9 = Object.get_name(*(int64 *)(lVar7 + 16),0);
                uVar4 = Int32.Parse(uVar9,0);
                if ((lVar5 == null) || (lVar5 = WorldData.GetHero(lVar5,uVar4,0)) == null) break;
                uVar9 = HeroData.GetHeroWeaponAttackAnim(lVar5,0);
                BigmapNpcController.SetSkeletonAttackAnim(this,uVar8,uVar9,0);
              }
              else {
                cVar3 = BigmapNpcController.IsMoving(this,0);
                lVar5 = this.followers;
                if (!cVar3) {
                  if ((lVar5 == null) || (lVar5 = FUN_1800024b0(lVar5,uVar12,DAT_181e61ef8)) == null)
                  break;
                  lVar5 = FUN_1802106e0(0);
                  if (lVar5 == null) break;
                  lVar5 = *(int64 *)(lVar5 + 32);
                  if (((this.followers == null) ||
                      (lVar7 = FUN_1800024b0(this.followers,uVar12,DAT_181e61ef8),
                      lVar7 == null)) || (*(int64 *)(lVar7 + 16) == 0)) break;
                  uVar8 = Object.get_name(*(int64 *)(lVar7 + 16),0);
                  uVar4 = Int32.Parse(uVar8,0);
                  if (lVar5 == null) break;
                  WorldData.GetHero(lVar5,uVar4,0);
                  BigmapNpcController.SetSkeletonIdleAnim(this);
                }
                else {
                  if ((lVar5 == null) || (lVar5 = FUN_1800024b0(lVar5,uVar12,DAT_181e61ef8)) == null)
                  break;
                  uVar8 = lVar5._items;
                  lVar5 = FUN_1802106e0(0);
                  if (lVar5 == null) break;
                  lVar5 = *(int64 *)(lVar5 + 32);
                  if (((this.followers == null) ||
                      (lVar7 = FUN_1800024b0(this.followers,uVar12,DAT_181e61ef8),
                      lVar7 == null)) || (*(int64 *)(lVar7 + 16) == 0)) break;
                  uVar9 = Object.get_name(*(int64 *)(lVar7 + 16),0);
                  uVar4 = Int32.Parse(uVar9,0);
                  if (lVar5 == null) break;
                  uVar9 = WorldData.GetHero(lVar5,uVar4,0);
                  if (((this.followers == null) ||
                      (lVar5 = FUN_1800024b0(this.followers,uVar12,DAT_181e61ef8),
                      lVar5 == null)) ||
                     ((lVar5._items == null ||
                      (lVar5 = GameObject.get_transform(lVar5._items,0)) == null)))
                  break;
                  puVar10 = (uint32 *)Transform.get_localPosition(local_f8,lVar5,0);
                  uVar4 = *puVar10;
                  if (((this.followers == null) ||
                      (lVar5 = FUN_1800024b0(this.followers,uVar12,DAT_181e61ef8),
                      lVar5 == null)) ||
                     ((lVar5._items == null ||
                      (lVar5 = GameObject.get_transform(lVar5._items,0)) == null)))
                  break;
                  lVar5 = Transform.get_localPosition(local_e8,lVar5,0);
                  uVar1 = *(uint32 *)(lVar5 + 4);
                  lVar5 = Component.get_transform(this,0);
                  if (lVar5 == null) break;
                  puVar6 = (uint64 *)Transform.get_localPosition(local_d8,lVar5,0);
                  local_168 = CONCAT44(uVar1,uVar4);
                  local_160 = 0;
                  BigmapNpcController.SetSkeletonRunAnim(this,uVar8,uVar9,&local_168,*puVar6,0);
                }
              }
            }
            lVar5 = this.followers;
            uVar12 = uVar12 + 1;
            lVar13 = lVar13 + 8;
          } while (lVar5 != null);
        }
    }

    // Token : 0x6000D42
    // RVA   : 0x9EAE90   Offset: 0x9E9C90   Length: 0x17E
    public void SetSkeletonIdleAnim(GameObject targetSkeleton, HeroData targetHero)
    {
        ulong uVar1;
        ulong uVar2;
        bool cVar3;
        long lVar4;
        long lVar5;
        cVar3 = Object.op_Equality(targetSkeleton,0,0);
        if (cVar3) {
          return;
        }
        if (targetHero == null) {
          return;
        }
        lVar4 = BigmapNpcController.GetSkeletonAnim(this,targetSkeleton,0);
        if ((lVar4 != null) && (*(uint32 *)(lVar4 + 300) = 0x3f800000, targetSkeleton != null)) {
          cVar3 = GameObject.get_activeSelf(targetSkeleton,0);
          if (!cVar3) {
            return;
          }
          cVar3 = Behaviour.get_enabled(lVar4,0);
          if (!cVar3) {
            return;
          }
          lVar5 = SkeletonAnimation.get_AnimationState(lVar4,0);
          if (lVar5 != null) {
            lVar5 = AnimationState.GetCurrent(lVar5,0,0);
            if (lVar5 != null) {
              lVar5 = SkeletonAnimation.get_AnimationState(lVar4,0);
              if (((lVar5 == null) || (lVar5 = AnimationState.GetCurrent(lVar5,0,0)) == null) ||
                 (*(int64 *)(lVar5 + 16) == 0)) throw; // [null/range check failed]
              uVar1 = *(uint64 *)(*(int64 *)(lVar5 + 16) + 16);
              uVar2 = HeroData.GetSkeletonHorseIdleAnim(targetHero,0);
              cVar3 = String.op_Inequality(uVar1,uVar2,0);
              if (!cVar3) {
                return;
              }
            }
            lVar4 = SkeletonAnimation.get_AnimationState(lVar4,0);
            uVar1 = HeroData.GetSkeletonHorseIdleAnim(targetHero,0);
            if (lVar4 != null) {
              AnimationState.SetAnimation(lVar4,0,uVar1,1,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000D43
    // RVA   : 0x9EAD30   Offset: 0x9E9B30   Length: 0x157
    public void SetSkeletonAttackAnim(GameObject targetSkeleton, string targetAnim)
    {
        void BigmapNpcController.SetSkeletonAttackAnim
                     (uint64 this,int64 targetSkeleton,uint64 targetAnim)
        {
        char cVar1;
        int64 lVar2;
        int64 lVar3;
        cVar1 = Object.op_Equality(targetSkeleton,0,0);
        if (cVar1) {
          return;
        }
        lVar2 = BigmapNpcController.GetSkeletonAnim(this,targetSkeleton,0);
        if ((lVar2 != null) && (*(uint32 *)(lVar2 + 300) = 0x3f800000, targetSkeleton != null)) {
          cVar1 = GameObject.get_activeSelf(targetSkeleton,0);
          if (!cVar1) {
            return;
          }
          cVar1 = Behaviour.get_enabled(lVar2,0);
          if (!cVar1) {
            return;
          }
          lVar3 = SkeletonAnimation.get_AnimationState(lVar2,0);
          if (lVar3 != null) {
            lVar3 = AnimationState.GetCurrent(lVar3,0,0);
            if (lVar3 != null) {
              lVar3 = SkeletonAnimation.get_AnimationState(lVar2,0);
              if (((lVar3 == null) || (lVar3 = AnimationState.GetCurrent(lVar3,0,0)) == null) ||
                 (*(int64 *)(lVar3 + 16) == 0)) throw; // [null/range check failed]
              cVar1 = String.op_Inequality(*(uint64 *)(*(int64 *)(lVar3 + 16) + 16),targetAnim,0)
              ;
              if (!cVar1) {
                return;
              }
            }
            lVar2 = SkeletonAnimation.get_AnimationState(lVar2,0);
            if (lVar2 != null) {
              AnimationState.SetAnimation(lVar2,0,targetAnim,1,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000D44
    // RVA   : 0x9E9CF0   Offset: 0x9E8AF0   Length: 0x8D6
    public void RefreshHeroSkeleton()
    {
        long lVar2;
        bool cVar3;
        uint uVar4;
        ulong uVar5;
        long lVar6;
        ulong uVar7;
        uint uVar9;
        int iVar10;
        int iVar11;
        long lVar12;
        float fVar13;
        float fVar14;
        uint[] local_res8 = new uint[2];
        ulong uVar15;
        ulong local_a8;
        float local_a0;
        ulong local_98;
        float local_90;
        byte[] local_78 = new byte[16];
        byte[] local_68 = new byte[64];
        lVar12 = this.heroData;
        local_res8[0] = 0;
        this.needRefresh = 0;
        if ((this.selfSkeleton != null) &&
           (uVar5 = GameObject.GetComponent(this.selfSkeleton,DAT_181e56598), lVar12 != null)) {
          HeroData.RefreshHeroSkeleton(lVar12,uVar5,0);
          if (this.followers != null) {
            uVar9 = this.followers.Count - 1;
            if (-1 < (int)uVar9) {
              lVar12 = (int64)(int)uVar9 * 8 + 32;
              do {
                if (this.heroData == null) throw; // [null/range check failed]
                lVar6 = this.followers;
                lVar2 = this.heroData.teamMates;
                if (lVar6 == null) throw; // [null/range check failed]
                if (lVar6.Count <= uVar9) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar6 = *(int64 *)(lVar12 + lVar6._items);
                if ((lVar6 = lVar6?._items) == null) throw; // [null/range check failed]
                uVar5 = Object.get_name(lVar6,0);
                uVar4 = Int32.Parse(uVar5,0);
                if (lVar2 == null) throw; // [null/range check failed]
                cVar3 = FUN_18176a2d0(lVar2,uVar4,DAT_181e71570);
                if (!cVar3) {
                  if ((this.followers == null) ||
                     (lVar6 = FUN_1800024b0(this.followers,uVar9,DAT_181e61ef8), lVar6 == null
                     )) throw; // [null/range check failed]
                  uVar5 = lVar6._items;
                  Object.Destroy(uVar5,0);
                  if (this.followers == null) throw; // [null/range check failed]
                  FUN_181763390(this.followers,uVar9,DAT_181e61df8);
                }
                lVar12 = lVar12 + -8;
                uVar9 = uVar9 - 1;
              } while (-1 < (int)uVar9);
            }
            lVar12 = this.heroData;
            iVar11 = 0;
            if (lVar12 != null) {
              while (lVar12.teamMates != null) {
                if (*(int *)(lVar12.teamMates + 24) <= iVar11) {
                  uVar5 = this.seeRangeCollider;
                  cVar3 = Object.op_Inequality(uVar5,0,0);
                  if (cVar3) {
                    lVar12 = this.seeRangeCollider;
                    if ((this.heroData == null) ||
                       (uVar5 = HeroData.GetSeeRange(this.heroData,0), lVar12 == null))
                    break;
                    SphereCollider.set_radius(lVar12,uVar5,0);
                    if ((this.seeRangeCollider == null) ||
                       (lVar12 = Component.get_transform(this.seeRangeCollider,0)) == null)
                    break;
                    lVar12 = Transform.Find(lVar12,"SeeRangeSprite",0);
                    puVar8 = (uint64 *)Vector3.get_one(local_68,0);
                    fVar14 = *(float *)(puVar8 + 1);
                    uVar5 = *puVar8;
                    if (this.seeRangeCollider == null) break;
                    fVar13 = (float)SphereCollider.get_radius(this.seeRangeCollider,0);
                    if (lVar12 == null) break;
                    local_98 = CONCAT44((float)((uint64)uVar5 >> 32) * fVar13,(float)uVar5 * fVar13);
                    local_90 = fVar14 * fVar13;
                    Transform.set_localScale(lVar12,&local_98,0);
                  }
                  return;
                }
                lVar12 = 0;
                iVar10 = 0;
                fVar14 = (float)(iVar11 + 1) * 0.15;
                while( true ) {
                  lVar6 = this.followers;
                  if (lVar6 == null) throw; // [null/range check failed]
                  if (lVar6.Count <= iVar10) goto LAB_1809ea098;
                  lVar6 = FUN_1800024b0(lVar6,iVar10,DAT_181e61ef8);
                  if ((lVar6 == null) || (lVar6._items == null)) throw; // [null/range check failed]
                  uVar5 = Object.get_name(lVar6._items,0);
                  if ((this.heroData == null) ||
                     (lVar6 = this.heroData.teamMates) == null)
                  throw; // [null/range check failed]
                  local_res8[0] = FUN_180002480(lVar6,iVar11,DAT_181e71bf0);
                  uVar7 = Int32.ToString(local_res8,0);
                  cVar3 = FUN_1816387f0(uVar5,uVar7,0);
                  if (cVar3) break;
                  iVar10 = iVar10 + 1;
                }
                if ((this.followers == null) ||
                   (lVar12 = FUN_1800024b0(this.followers,iVar10,DAT_181e61ef8),
                   lVar12 == null)) break;
                lVar12 = lVar12.isSummon;
                if ((this.followers == null) ||
                   (lVar6 = FUN_1800024b0(this.followers,iVar10,DAT_181e61ef8)) == null
                   ) break;
                lVar6.Count = fVar14;
        LAB_1809ea098:
                cVar3 = Object.op_Equality(lVar12,0,0);
                if (!cVar3) {
                  lVar6 = FUN_1802106e0(0);
                  if (lVar6 == null) break;
                  lVar6 = *(int64 *)(lVar6 + 32);
                  if ((((this.heroData == null) ||
                       (lVar2 = this.heroData.teamMates) == null) ||
                      (uVar4 = FUN_180002480(lVar2,iVar11), lVar6 == null)) ||
                     ((lVar6 = WorldData.GetHero(lVar6,uVar4), lVar12 == null ||
                      (uVar5 = GameObject.GetComponent(lVar12,DAT_181e56598), lVar6 == null)))) break;
                  HeroData.RefreshHeroSkeleton(lVar6,uVar5);
                }
                else {
                  lVar12 = FUN_1802106e0(0);
                  if (lVar12 == null) break;
                  lVar12 = lVar12.summonControlable;
                  if (((this.heroData == null) ||
                      (lVar6 = this.heroData.teamMates) == null) ||
                     (uVar4 = FUN_180002480(lVar6,iVar11,DAT_181e71bf0), lVar12 == null)) break;
                  lVar12 = WorldData.GetHero(lVar12,uVar4,0);
                  lVar6 = Component.get_transform(this,0);
                  if ((lVar6 == null) || (lVar6 = FUN_180b05920(lVar6,0)) == null) break;
                  uVar7 = Component.get_gameObject(lVar6,0);
                  puVar8 = (uint64 *)Vector3.get_one(local_78,0);
                  uVar5 = *puVar8;
                  uVar15 = CONCAT44((float)((uint64)uVar5 >> 32) * 0.2,(float)uVar5 * 0.2);
                  if ((lVar12 == null) ||
                     (local_a8 = uVar15, local_a0 = *(float *)(puVar8 + 1) * 0.2,
                     lVar12 = HeroData.GenerateHeroSkeleton
                                        (lVar12,uVar7,&local_a8,0,uVar15,*(float *)(puVar8 + 1) * 0.2,
                                         uVar5), lVar12 == null)) break;
                  lVar12 = Component.get_gameObject(lVar12,0);
                  this.newObj = lVar12;
                  if (*plVar1 == 0) break;
                  lVar12 = GameObject.AddComponent(*plVar1,DAT_181e51e68);
                  if ((*plVar1 == 0) ||
                     (uVar5 = GameObject.GetComponent(*plVar1,DAT_181e56598), lVar12 == null)) break;
                  lVar12.summonLv = uVar5;
                  lVar12 = *plVar1;
                  if ((this.heroData == null) ||
                     (lVar6 = this.heroData.teamMates) == null) break;
                  local_res8[0] = FUN_180002480(lVar6,iVar11,DAT_181e71bf0);
                  uVar5 = Int32.ToString(local_res8,0);
                  if (lVar12 == null) break;
                  Object.set_name(lVar12,uVar5,0);
                  if (*plVar1 == 0) break;
                  lVar12 = GameObject.get_transform(*plVar1,0);
                  lVar6 = Component.get_transform(this,0);
                  if ((lVar6 == null) ||
                     (puVar8 = (uint64 *)Transform.get_localPosition(local_68,lVar6,0), lVar12 == null))
                  break;
                  local_98 = *puVar8;
                  local_90 = *(float *)(puVar8 + 1);
                  Transform.set_localPosition(lVar12,&local_98,0);
                  lVar12 = FUN_180210220(0);
                  if ((*plVar1 == 0) || (uVar5 = GameObject.get_transform(*plVar1,0), lVar12 == null))
                  break;
                  BigMapController.SetBigMapHeroZPos(lVar12,uVar5,0);
                  lVar12 = this.followers;
                  lVar6 = *plVar1;
                  uVar5 = new AreaBuildingRateChange(lVar6,fVar14);
                  if (lVar12 == null) break;
                  FUN_18175de30(lVar12,uVar5);
                }
                lVar12 = this.heroData;
                iVar11 = iVar11 + 1;
                if (lVar12 == null) break;
              }
            }
          }
        }
    }

    // Token : 0x6000D45
    // RVA   : 0x9E9A50   Offset: 0x9E8850   Length: 0x141
    private void OnDestroy()
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        uint uVar4;
        long lVar5;
        uVar1 = this.BigMapFightIcon;
        cVar3 = Object.op_Inequality(uVar1,0,0);
        if (cVar3) {
          uVar1 = this.BigMapFightIcon;
          Object.Destroy(uVar1,0);
        }
        if (this.followers != null) {
          uVar4 = this.followers.Count - 1;
          if (-1 < (int)uVar4) {
            lVar5 = (int64)(int)uVar4 * 8 + 32;
            do {
              lVar2 = this.followers;
              if (lVar2 == null) throw; // [null/range check failed]
              if (lVar2.Count <= uVar4) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar2 = *(int64 *)(lVar5 + lVar2._items);
              if (lVar2 == null) throw; // [null/range check failed]
              uVar1 = lVar2._items;
              Object.Destroy(uVar1,0);
              lVar5 = lVar5 + -8;
              uVar4 = uVar4 - 1;
            } while (-1 < (int)uVar4);
          }
          return;
        }
    }

    // Token : 0x6000D46
    // RVA   : 0x9E9BA0   Offset: 0x9E89A0   Length: 0x14B
    private void OnEnable()
    {
        long lVar1;
        ulong uVar3;
        ulong uVar4;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        if (!this.selfShowing) {
          this.selfShowing = 1;
          lVar1 = Component.get_transform(this,0);
          puVar2 = (uint64 *)Vector3.get_zero(local_18,0);
          if (lVar1 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          local_20 = *(uint32 *)(puVar2 + 1);
          local_28 = *puVar2;
          Transform.set_localScale(lVar1,&local_28,0);
          uVar3 = Component.get_transform(this,0);
          puVar2 = (uint64 *)Vector3.get_one(local_18,0);
          local_20 = *(uint32 *)(puVar2 + 1);
          local_28 = *puVar2;
          uVar3 = ShortcutExtensions.DOScale(uVar3,&local_28,0x3e99999a,0);
          uVar3 = TweenSettingsExtensions.SetUpdate(uVar3,1,DAT_181ea59e0);
          uVar4 = new OnTooltipCB(this,DAT_181e6d9c8,0);
          TweenSettingsExtensions.OnComplete(uVar3,uVar4,DAT_181ea3dc0);
        }
    }

    // Token : 0x6000D47
    // RVA   : 0x9E9BA0   Offset: 0x9E89A0   Length: 0x14B
    public void StartSelfShow()
    {
        long lVar1;
        ulong uVar3;
        ulong uVar4;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        if (!this.selfShowing) {
          this.selfShowing = 1;
          lVar1 = Component.get_transform(this,0);
          puVar2 = (uint64 *)Vector3.get_zero(local_18,0);
          if (lVar1 == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          local_20 = *(uint32 *)(puVar2 + 1);
          local_28 = *puVar2;
          Transform.set_localScale(lVar1,&local_28,0);
          uVar3 = Component.get_transform(this,0);
          puVar2 = (uint64 *)Vector3.get_one(local_18,0);
          local_20 = *(uint32 *)(puVar2 + 1);
          local_28 = *puVar2;
          uVar3 = ShortcutExtensions.DOScale(uVar3,&local_28,0x3e99999a,0);
          uVar3 = TweenSettingsExtensions.SetUpdate(uVar3,1,DAT_181ea59e0);
          uVar4 = new OnTooltipCB(this,DAT_181e6d9c8,0);
          TweenSettingsExtensions.OnComplete(uVar3,uVar4,DAT_181ea3dc0);
        }
    }

    // Token : 0x6000D48
    // RVA   : 0x9EB300   Offset: 0x9EA100   Length: 0x15F
    public void StartSelfDestroy()
    {
        long lVar1;
        ulong uVar2;
        ulong uVar4;
        ulong local_28;
        uint local_20;
        byte[] local_18 = new byte[16];
        if (this.selfDestroying) {
          return;
        }
        this.selfDestroying = 1;
        if ((this.seeRangeCollider != null) &&
           (lVar1 = Component.get_gameObject(this.seeRangeCollider,0)) != null) {
          GameObject.SetActive(lVar1,0,0);
          if ((this.interactRangeCollider != null) &&
             (lVar1 = Component.get_gameObject(this.interactRangeCollider,0)) != null) {
            GameObject.SetActive(lVar1,0,0);
            uVar2 = Component.get_transform(this,0);
            puVar3 = (uint64 *)Vector3.get_zero(local_18,0);
            local_20 = *(uint32 *)(puVar3 + 1);
            local_28 = *puVar3;
            uVar2 = ShortcutExtensions.DOScale(uVar2,&local_28,0x3e99999a,0);
            uVar2 = TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181ea59e0);
            uVar4 = new OnTooltipCB(this,DAT_181e6d948,0);
            TweenSettingsExtensions.OnComplete(uVar2,uVar4,DAT_181ea3dc0);
            return;
          }
        }
    }

    // Token : 0x6000D49
    // RVA   : 0x9E98E0   Offset: 0x9E86E0   Length: 0x16E
    public void OnClick()
    {
        long lVar1;
        ulong uVar2;
        if (this.heroData != null) {
          if (this.heroData.heroID == null) {
            lVar1 = GameController.CheckShowSpeHero;
            if (lVar1 != null) {
              BigMapController.PlayerStopMove(lVar1,0);
              return;
            }
          }
          else {
            lVar1 = GameController.CheckShowSpeHero;
            uVar2 = Component.get_gameObject(this,0);
            if (lVar1 != null) {
              BigMapController.SetPlayerMoveTargetArea(lVar1,uVar2,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000D4A
    // RVA   : 0x51DF30   Offset: 0x51CD30   Length: 0x5B
    public void OnDrag(Vector2 delta)
    {
        var pStatics = *(int64*)(DAT_181e91070 + 184);
        if (*pStatics != 0) {
          BigMapSpriteController.OnDrag(*pStatics,delta,0);
          return;
        }
    }

    // Token : 0x6000D4B
    // RVA   : 0x51DF90   Offset: 0x51CD90   Length: 0x57
    public void OnScroll(float delta)
    {
        var pStatics = *(int64*)(DAT_181e91070 + 184);
        if (*pStatics != 0) {
          BigMapSpriteController.OnScroll(*pStatics,delta,0);
          return;
        }
    }

    // Token : 0x6000D4C
    // RVA   : 0x9E8200   Offset: 0x9E7000   Length: 0x927
    public void InteractRangeObjStay(GameObject target)
    {
        bool cVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        ulong uVar8;
        if (this.selfDestroying) {
          return;
        }
        if (target != null) {
          cVar1 = GameObject.CompareTag(target,"BigMapSpeEffectCollider",0);
          if (!cVar1) {
            cVar1 = GameObject.CompareTag(target,"BigmapWater",0);
            if (!cVar1) {
              cVar1 = GameObject.CompareTag(target,"BigmapMountain",0);
              if (!cVar1) {
                cVar1 = GameObject.CompareTag(target,"BigmapHill",0);
                if (!cVar1) {
                  cVar1 = GameObject.CompareTag(target,"AreaSafeRange",0);
                  if (!cVar1) {
                    cVar1 = GameObject.CompareTag(target,"HeroInteractRange",0);
                    if (!cVar1) {
                      cVar1 = GameObject.CompareTag(target,"BigMapBorder",0);
                      if (!cVar1) {
                        return;
                      }
                      lVar3 = this.heroData;
                      if (lVar3 != null) {
                        if (lVar3.isTempHero) {
                          HeroData.SetNeedRemove(lVar3,0);
                          return;
                        }
                        return;
                      }
                    }
                    else {
                      lVar3 = this.heroData;
                      if (lVar3 != null) {
                        if (lVar3.heroID == null) {
                          lVar3 = FUN_180210220(0);
                          if (lVar3 != null) {
                            uVar8 = lVar3.thisMonthContribution;
                            lVar3 = GameObject.GetComponent(target,DAT_181e54ca0);
                            if ((lVar3 != null) && (lVar3.summonLv != null)) {
                              uVar4 = Component.get_gameObject(lVar3.summonLv,0);
                              cVar1 = Object.op_Equality(uVar8,uVar4,0);
                              if (!cVar1) {
                                return;
                              }
                              lVar3 = FUN_180210a70(0);
                              if (lVar3 != null) {
                                if (lVar3.summonLv) {
                                  return;
                                }
                                lVar3 = FUN_180210220(0);
                                lVar5 = GameObject.GetComponent(target,DAT_181e54ca0);
                                if (((lVar5 != null) && (lVar5.summonLv != null)) &&
                                   (uVar8 = Component.get_gameObject(lVar5.summonLv,0),
                                   lVar3 != null)) {
                                  BigMapController.MeetBigMapNpc(lVar3,uVar8,0);
                                  return;
                                }
                              }
                            }
                          }
                        }
                        else if (lVar3.heroAIData != null) {
                          if (*(int *)(lVar3.heroAIData + 16) != 1) {
                            return;
                          }
                          lVar3 = GameObject.GetComponent(target,DAT_181e54ca0);
                          if (((lVar3 != null) && (lVar3.summonLv != null)) &&
                             (lVar3 = *(int64 *)(lVar3.summonLv + 24)) != null) {
                            uVar8 = this.heroFollowTarget;
                            if (lVar3.heroID == null) {
                              lVar3 = GameObject.GetComponent(target,DAT_181e54ca0);
                              if ((lVar3 != null) && (lVar3.summonLv != null)) {
                                uVar4 = Component.get_gameObject(lVar3.summonLv,0);
                                cVar1 = Object.op_Equality(uVar8,uVar4,0);
                                if (!cVar1) {
                                  return;
                                }
                                if (this.heroFollowType != 1) {
                                  return;
                                }
                                lVar3 = FUN_180210a70(0);
                                if (lVar3 != null) {
                                  if (lVar3.summonLv) {
                                    return;
                                  }
                                  lVar3 = FUN_180210e40(0);
                                  if (lVar3 != null) {
                                    if (lVar3.heroAIDataArriveTargetRecord) {
                                      return;
                                    }
                                    lVar3 = GameObject.GetComponent(target,DAT_181e54ca0);
                                    if (((lVar3 != null) && (lVar3.summonLv != null)) &&
                                       (lVar3 = *(int64 *)(lVar3.summonLv + 24),
                                       lVar3 != null)) {
                                      if (lVar3.inPrison) {
                                        return;
                                      }
                                      lVar3 = GameObject.GetComponent(target,DAT_181e54ca0);
                                      if (((lVar3 != null) && (lVar3.summonLv != null)) &&
                                         (lVar3 = *(int64 *)(lVar3.summonLv + 24),
                                         lVar3 != null)) {
                                        cVar1 = HeroData.HaveArea(lVar3,0);
                                        if (cVar1) {
                                          return;
                                        }
                                        lVar3 = FUN_180210220(0);
                                        uVar8 = Component.get_gameObject(this,0);
                                        if (lVar3 != null) {
                                          BigMapController.MeetBigMapNpc(lVar3,uVar8,0);
                                          return;
                                        }
                                      }
                                    }
                                  }
                                }
                              }
                            }
                            else {
                              lVar3 = GameObject.GetComponent(target);
                              if ((lVar3 != null) && (lVar3.summonLv != null)) {
                                uVar4 = Component.get_gameObject(lVar3.summonLv,0);
                                cVar1 = Object.op_Equality(uVar8,uVar4,0);
                                if (!cVar1) {
                                  return;
                                }
                                if (this.heroFollowType != 1) {
                                  return;
                                }
                                if ((this.heroData != null) &&
                                   (lVar3 = this.heroData.heroAIData,
                                   lVar3 != null)) {
                                  if (lVar3.isSummon != 1) {
                                    return;
                                  }
                                  lVar3 = GameObject.GetComponent(target,DAT_181e54ca0);
                                  if ((((lVar3 != null) && (lVar3.summonLv != null)) &&
                                      (lVar3 = *(int64 *)(lVar3.summonLv + 24),
                                      lVar3 != null)) && (lVar3 = lVar3.heroAIData) != null) {
                                    if (lVar3.isSummon != 1) {
                                      return;
                                    }
                                    uVar8 = this.heroData;
                                    lVar3 = *(int64 *)(*(int64 *)(DAT_181e89f38 + 184) + 40);
                                    lVar5 = GameObject.GetComponent(target,DAT_181e54ca0);
                                    if (((lVar5 != null) && (lVar5.summonLv != null)) &&
                                       (lVar5 = *(int64 *)(lVar5.summonLv + 24),
                                       lVar5 != null)) {
                                      uVar4 = Int32.ToString(lVar5 + 88,0);
                                      lVar5 = this.heroData;
                                      lVar6 = GameObject.GetComponent(target,DAT_181e54ca0);
                                      if (((lVar6 != null) && (*(int64 *)(lVar6 + 24) != 0)) &&
                                         (lVar5 != null)) {
                                        uVar2 = HeroData.GetFightTime
                                                          (lVar5,*(uint64 *)
                                                                  (*(int64 *)(lVar6 + 24) + 24),0);
                                        uVar7 = new HeroAIData(13,uVar4,uVar2,0);
                                        if (lVar3 != null) {
                                          AIController.SetAIStuff(lVar3,uVar8,uVar7,0,0);
                                          this.heroFollowTarget = 0;
                                          goto LAB_1809e8683;
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
                  else {
                    this.areaSafeRange = target;
                    if (this.heroData != null) {
                      this.heroData.inSafeArea = 1;
                      this.areaSafeRangeBuffer = target;
                      if (this.heroData != null) {
                        if (!this.heroData.isRandomEnemy) {
                          return;
                        }
                        uVar8 = *(uint64 *)(this + 200);
                        cVar1 = Object.op_Equality(uVar8,0,0);
                        if (!cVar1) {
                          return;
                        }
                        *(uint64 *)(this + 200) = this.areaSafeRange;
                        this.heroFollowTarget = 0;
        LAB_1809e8683:
                        il2cpp_internal(this + 48,0);
                        this.heroChaseTime = 0;
                        return;
                      }
                    }
                  }
                }
                else if (this.heroData != null) {
                  this.heroData.inHill = 1;
                  this.inHillBuff = 1;
                  return;
                }
              }
              else if (this.heroData != null) {
                this.heroData.inMountain = 1;
                this.inMountainBuff = 1;
                return;
              }
            }
            else if (this.heroData != null) {
              this.heroData.inWater = 1;
              uVar8 = Component.GetComponent(this,DAT_181e771b8);
              cVar1 = Object.op_Inequality(uVar8,0,0);
              if (cVar1) {
                lVar3 = Component.GetComponent(this,DAT_181e771b8);
                if (lVar3 == null) throw; // [null/range check failed]
                lVar3.summonSourceHero = 1;
              }
              this.inWaterBuff = 1;
              return;
            }
          }
          else {
            lVar3 = GameObject.GetComponent(target,DAT_181e536d8);
            if (lVar3 != null) {
              this.inBigMapSpeEffectType = lVar3.summonLv;
              this.inBigMapSpeEffectBuff = 1;
              return;
            }
          }
        }
    }

    // Token : 0x6000D4D
    // RVA   : 0x9E6390   Offset: 0x9E5190   Length: 0x29
    public void ClearHeroFollowTarget()
    {
        this.heroFollowTarget = 0;
        this.heroChaseTime = 0;
    }

    // Token : 0x6000D4E
    // RVA   : 0x9EB660   Offset: 0x9EA460   Length: 0x1AF
    public bool TargetHeroIsEnemy(HeroData targetHeroData)
    {
        bool cVar1;
        int iVar2;
        float fVar3;
        if ((targetHeroData == null) || (this.heroData == null)) throw; // [null/range check failed]
        cVar1 = HeroData.HaveHater(this.heroData,*(uint32 *)(targetHeroData + 88),0);
        if (cVar1) {
          return true;
        }
        fVar3 = *(float *)(targetHeroData + 0x1c8);
        if (fVar3 < *(float *)(*(int64 *)(DAT_181e538e8 + 184) + 0x130)) {
          return false;
        }
        if (*(int *)(targetHeroData + 88) == 0) {
          if (this.heroData == null) throw; // [null/range check failed]
          fVar3 = (float)HeroData.Favor(this.heroData,0,0);
          fVar3 = 1.0 - fVar3 * 0.01;
        }
        else {
          fVar3 = 1.0;
        }
        if (this.heroData == null) throw; // [null/range check failed]
        cVar1 = HeroData.SameForce(this.heroData,targetHeroData,0);
        if (!cVar1) {
          if (this.heroData == null) throw; // [null/range check failed]
          cVar1 = HeroData.HaveRelationBetterThanFriend
                            (this.heroData,*(uint32 *)(targetHeroData + 88),0,1,0);
          if (!(cVar1))
          {
            if (this.heroData == null) throw; // [null/range check failed]
            cVar1 = HeroData.HaveFriend(this.heroData,*(uint32 *)(targetHeroData + 88),0);
            if (cVar1) {
            fVar3 = fVar3 * 0.2;
            }
            }
            else {
          }
          fVar3 = fVar3 * 0.0;
        }
        iVar2 = HeroData.GetBountyPirce(targetHeroData,0);
        if (this.heroData != null) {
          return this.heroData.fame * 0.2 <= (float)iVar2 * fVar3;
        }
    }

    // Token : 0x6000D4F
    // RVA   : 0x9EA740   Offset: 0x9E9540   Length: 0x4AF
    public void SeeRangeObjStay(GameObject target)
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        int iVar4;
        float fVar5;
        uint uVar6;
        double dVar7;
        float fVar8;
        uint uVar9;
        lVar2 = this.heroData;
        if (lVar2 != null) {
          if (lVar2.heroID == null) {
            if (target != null) {
              cVar1 = GameObject.CompareTag(target,"BigMapSeeRange",0);
              if (!cVar1) {
                return;
              }
              lVar2 = GameObject.get_transform(target,0);
              if ((((lVar2 != null) && (lVar2 = FUN_180b05920(lVar2,0)) != null) &&
                  (lVar2 = Component.GetComponent(lVar2,DAT_181e768b8)) != null) &&
                 (lVar2.summonLv != null)) {
                *(uint8 *)(lVar2.summonLv + 96) = 1;
                return;
              }
            }
          }
          else if (lVar2.heroAIData != null) {
            if (*(int *)(lVar2.heroAIData + 16) != 1) {
              return;
            }
            if (target != null) {
              cVar1 = GameObject.CompareTag(target,"HeroInteractRange",0);
              if (!cVar1) {
                GameObject.CompareTag(target,"BigMapSeeRange",0);
              }
              else {
                uVar3 = this.heroFollowTarget;
                cVar1 = Object.op_Equality(uVar3,0,0);
                if (cVar1) {
                  uVar3 = *(uint64 *)(this + 200);
                  cVar1 = Object.op_Equality(uVar3,0,0);
                  if (cVar1) {
                    if (this.heroData != null) {
                      cVar1 = this.heroData.isRandomEnemy;
                      lVar2 = GameObject.GetComponent(target,DAT_181e54ca0);
                      if (((lVar2 != null) && (lVar2.summonLv != null)) &&
                         (lVar2 = *(int64 *)(lVar2.summonLv + 24)) != null) {
                        if (cVar1 == lVar2.isRandomEnemy) {
                          if (this.heroData == null) throw; // [null/range check failed]
                          if (this.heroData.isRandomEnemy) {
                            return;
                          }
                          lVar2 = GameObject.GetComponent(target,DAT_181e54ca0);
                          if (((lVar2 == null) || (lVar2.summonLv == null)) ||
                             (lVar2 = *(int64 *)(lVar2.summonLv + 24)) == null)
                          throw; // [null/range check failed]
                          if (lVar2.isRandomEnemy) {
                            return;
                          }
                          lVar2 = GameObject.GetComponent(target,DAT_181e54ca0);
                          if ((lVar2 == null) || (lVar2.summonLv == null)) throw; // [null/range check failed]
                          cVar1 = BigmapNpcController.TargetHeroIsEnemy
                                            (this,*(uint64 *)(lVar2.summonLv + 24),0
                                            );
                          if (!cVar1) {
                            return;
                          }
                        }
                        lVar2 = GameObject.GetComponent(target,DAT_181e54ca0);
                        if (lVar2 != null) {
                          lVar2 = lVar2.summonLv;
                          cVar1 = Object.op_Equality(lVar2,0,0);
                          if (!cVar1) {
                            dVar7 = (double)GlobalData.RandomRangeDouble(0,0);
                            if (lVar2 == null) throw; // [null/range check failed]
                            fVar5 = (float)GlobalData.CaculateWinRate
                                                     (this.heroData,
                                                      lVar2.summonLv,1,0);
                            if (this.heroData == null) throw; // [null/range check failed]
                            if (!this.heroData.isRandomEnemy) {
                              fVar8 = 1.5;
                            }
                            else {
                              fVar8 = 2.5;
                            }
                            iVar4 = ((double)(fVar5 * fVar8) <= dVar7) + 1;
                          }
                          else {
                            iVar4 = 0;
                          }
                          lVar2 = GameObject.GetComponent(target,DAT_181e54ca0);
                          if (lVar2 != null) {
                            cVar1 = BigmapNpcController.HeroCanFollow
                                              (this,lVar2.summonLv,iVar4,0x3f800000,0);
                            if (!cVar1) {
                              return;
                            }
                            if ((iVar4 != 2) && (0.0 < this.heroStopChaseTime)) {
                              return;
                            }
                            lVar2 = GameObject.GetComponent(target,DAT_181e54ca0);
                            if ((lVar2 != null) && (lVar2.summonLv != null)) {
                              uVar3 = Component.get_gameObject(lVar2.summonLv,0);
                              this.heroFollowTarget = uVar3;
                              this.heroFollowType = iVar4;
                              this.heroChaseTime = 0;
                              if (iVar4 == 2) {
                                uVar6 = 0x3f99999a;
                                uVar9 = 0x3fb33333;
                              }
                              else {
                                uVar6 = 0x3f8ccccd;
                                uVar9 = 0x3f99999a;
                              }
                              uVar6 = GlobalData.RandomRange(uVar6,uVar9,0,0);
                              this.followRangeRate = uVar6;
                              return;
                            }
                          }
                        }
                      }
                    }
                    throw; // [null/range check failed]
                  }
                }
              }
              return;
            }
          }
        }
    }

    // Token : 0x6000D50
    // RVA   : 0x9EB980   Offset: 0x9EA780   Length: 0x94
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181e714b8);
        FUN_1810f3480(uVar1,DAT_181e61cf8);
        this.followers = uVar1;
        this.areaSafeRangeRefreshTime = 0x3e4ccccd;
        this.inBigMapSpeEffectType = 0xffffffff;
        this.missionState = 0xffffffff;
        FUN_180ae8740(this,0);
    }

    // Token : 0x6000D51
    // RVA   : 0x9EB880   Offset: 0x9EA680   Length: 0xF2
    private static void /*cctor*/()
    {
        long lVar2;
        lVar2 = il2cpp_internal(DAT_181e77728);
        FUN_1810f3480(lVar2,DAT_181e861f0);
        if (lVar2 != null) {
          FUN_18175de30(lVar2,"",DAT_181e86370);
          FUN_18175de30(lVar2,"追击",DAT_181e86370);
          FUN_18175de30(lVar2,"逃离",DAT_181e86370);
          plVar1 = *(int64 **)(DAT_181e910f8 + 184);
          *plVar1 = lVar2;
          il2cpp_internal(plVar1,lVar2);
          return;
        }
    }

    // Token : 0x6000D52
    // RVA   : 0x9EB870   Offset: 0x9EA670   Length: 0x8
    private void <StartSelfShow>b__75_0()
    {
        void FUN_1809eb870(int64 this)
        {
        this.selfShowing = 0;
    }

    // Token : 0x6000D53
    // RVA   : 0x9EB810   Offset: 0x9EA610   Length: 0x5F
    private void <StartSelfDestroy>b__77_0()
    {
        ulong uVar1;
        uVar1 = Component.get_gameObject(this,0);
        Object.Destroy(uVar1,0);
    }

}
