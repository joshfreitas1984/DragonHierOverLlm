// ============================================================
// Type  : BigmapNpcController
// Token : 0x200019C
// ============================================================

public class BigmapNpcController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000B2F
    public HeroData heroData;

    // Token: 0x4000B30
    public GameObject CircleObj;

    // Token: 0x4000B31
    public SpriteRenderer SafeSprite;

    // Token: 0x4000B32
    public GameObject heroFollowTarget;

    // Token: 0x4000B33
    public HeroFollowType heroFollowType;

    // Token: 0x4000B34
    public float heroChaseTime;

    // Token: 0x4000B35
    public float followRangeRate;

    // Token: 0x4000B36
    public float heroStopChaseTime;

    // Token: 0x4000B37
    public GameObject selfSkeleton;

    // Token: 0x4000B38
    public GameObject heroSimpleSprite;

    // Token: 0x4000B39
    public GameObject heroMissionTarget;

    // Token: 0x4000B3A
    public List<BigMapFollower> followers;

    // Token: 0x4000B3B
    public SinglePlotData plotData;

    // Token: 0x4000B3C
    public CapsuleCollider hoverRangeCollider;

    // Token: 0x4000B3D
    public CapsuleCollider interactRangeCollider;

    // Token: 0x4000B3E
    public SphereCollider seeRangeCollider;

    // Token: 0x4000B3F
    private float angle;

    // Token: 0x4000B40
    private float finalAngle;

    // Token: 0x4000B41
    private Quaternion finalRotation;

    // Token: 0x4000B42
    private GameObject newObj;

    // Token: 0x4000B43
    public bool needRefresh;

    // Token: 0x4000B44
    public static List<string> HeroFollowTypeText;

    // Token: 0x4000B45
    public GameObject areaSafeRangeBuffer;

    // Token: 0x4000B46
    public GameObject areaSafeRange;

    // Token: 0x4000B47
    public float areaSafeRangeRefreshTime;

    // Token: 0x4000B48
    public GameObject leavingAreaSafeRange;

    // Token: 0x4000B49
    public GameObject BigMapFightIcon;

    // Token: 0x4000B4A
    public GameObject BigMapFightIconPrefab;

    // Token: 0x4000B4B
    private float originSimpleSpriteScale;

    // Token: 0x4000B4C
    private float originCapsuleColliderRadius;

    // Token: 0x4000B4D
    private float originCapsuleColliderHeight;

    // Token: 0x4000B4E
    private Vector3 originCapsuleColliderCenter;

    // Token: 0x4000B4F
    public BigMapSpeEffectType inBigMapSpeEffectType;

    // Token: 0x4000B50
    public bool inBigMapSpeEffectBuff;

    // Token: 0x4000B51
    public bool inWaterBuff;

    // Token: 0x4000B52
    public bool inMountainBuff;

    // Token: 0x4000B53
    public bool inHillBuff;

    // Token: 0x4000B54
    public float checkBigMapColliderTime;

    // Token: 0x4000B55
    private Transform arrowTrans;

    // Token: 0x4000B56
    private TweenRotation circleTweenRotation;

    // Token: 0x4000B57
    private SpriteRenderer heroMissionRenderer;

    // Token: 0x4000B58
    private SkeletonAnimation selfSkeletonAnim;

    // Token: 0x4000B59
    private int missionState;

    // Token: 0x4000B5A
    private bool inited;

    // Token: 0x4000B5B
    private bool selfShowing;

    // Token: 0x4000B5C
    public bool selfDestroying;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000D2C
    // RVA   : 0xC82810   Offset: 0xC81C10   Length: 0xFC
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
                goto LAB_180c828f0;
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        LAB_180c828f0:
        return this.arrowTrans;
    }

    // Token : 0x6000D2D
    // RVA   : 0xC82910   Offset: 0xC81D10   Length: 0xEA
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
              FUN_1800d6620();
            }
            uVar2 = GameObject.GetComponent(this.CircleObj,DAT_181d74548);
            this.circleTweenRotation = uVar2;
          }
        }
        return this.circleTweenRotation;
    }

    // Token : 0x6000D2E
    // RVA   : 0xC82A00   Offset: 0xC81E00   Length: 0xEA
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
              FUN_1800d6620();
            }
            uVar2 = GameObject.GetComponent(this.heroMissionTarget,DAT_181d73bb8);
            this.heroMissionRenderer = uVar2;
          }
        }
        return this.heroMissionRenderer;
    }

    // Token : 0x6000D2F
    // RVA   : 0xC82AF0   Offset: 0xC81EF0   Length: 0xEA
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
              FUN_1800d6620();
            }
            uVar2 = GameObject.GetComponent(this.selfSkeleton,DAT_181d734d0);
            this.selfSkeletonAnim = uVar2;
          }
        }
        return this.selfSkeletonAnim;
    }

    // Token : 0x6000D30
    // RVA   : 0xC7EEA0   Offset: 0xC7E2A0   Length: 0x170
    private SkeletonAnimation GetSkeletonAnim(GameObject targetSkeleton)
    {
        bool cVar1;
        ulong uVar2;
        uVar2 = this.selfSkeleton;
        cVar1 = Object.op_Equality(targetSkeleton,uVar2,0);
        if (!cVar1) {
          if (targetSkeleton != null) {
            uVar2 = GameObject.GetComponent(targetSkeleton,DAT_181d734d0);
            return uVar2;
          }
        LAB_180c7f00b:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        uVar2 = this.selfSkeletonAnim;
        cVar1 = Object.op_Equality(uVar2,0,0);
        if (cVar1) {
          uVar2 = this.selfSkeleton;
          cVar1 = Object.op_Inequality(uVar2,0,0);
          if (cVar1) {
            if (this.selfSkeleton == null) goto LAB_180c7f00b;
            uVar2 = GameObject.GetComponent(this.selfSkeleton,DAT_181d734d0);
            this.selfSkeletonAnim = uVar2;
          }
        }
        return this.selfSkeletonAnim;
    }

    // Token : 0x6000D31
    // RVA   : 0xC82250   Offset: 0xC81650   Length: 0x1F6
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
                bVar6 = !DAT_181e9e5ea;
                this.originCapsuleColliderCenter = *puVar3;
                *(uint32 *)(this + 244) = *(uint32 *)(puVar3 + 1);
                if (bVar6) {
                  il2cpp_runtime_class_init(&DAT_181d93e60);
                  il2cpp_runtime_class_init(&DAT_181dc5290);
                  il2cpp_runtime_class_init(&DAT_181d734d0);
                  il2cpp_runtime_class_init(&DAT_181da0df8);
                  il2cpp_runtime_class_init(&DAT_181da0cf8);
                  il2cpp_runtime_class_init(&DAT_181d96ed0);
                  DAT_181e9e5ea = true;
                }
                if (*(char *)(this + 300) != false) {
                  return;
                }
                *(uint8 *)(this + 300) = 1;
                lVar1 = Component.get_gameObject(this,0);
                if (lVar1 != null) {
                  lVar1 = GameObject.AddComponent(lVar1,DAT_181dc5290);
                  if ((this.selfSkeleton != null) &&
                     (uVar4 = GameObject.GetComponent(this.selfSkeleton,DAT_181d734d0),
                     lVar1 != null)) {
                    FootStepController.Init(lVar1,uVar4,0);
                    if (this.heroData != null) {
                      if (this.heroData.heroID == null) {
                        return;
                      }
                      lVar1 = Component.GetComponent(this,DAT_181d93e60);
                      lVar5 = il2cpp_internal(DAT_181d96ed0);
                      FUN_18132faf0(lVar5,DAT_181da0cf8);
                      if (lVar5 != null) {
                        FUN_18181de10(lVar5,0,DAT_181da0df8);
                        FUN_18181de10(lVar5,0,DAT_181da0df8);
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

    // Token : 0x6000D32
    // RVA   : 0xC7F230   Offset: 0xC7E630   Length: 0x15B
    private void Init()
    {
        long lVar1;
        ulong uVar2;
        long lVar3;
        if (*(char *)(this + 300) == false) {
          *(uint8 *)(this + 300) = 1;
          lVar1 = Component.get_gameObject(this,0);
          if (lVar1 != null) {
            lVar1 = GameObject.AddComponent(lVar1,DAT_181dc5290);
            if ((this.selfSkeleton != null) &&
               (uVar2 = GameObject.GetComponent(this.selfSkeleton,DAT_181d734d0), lVar1 != null)
               ) {
              FootStepController.Init(lVar1,uVar2,0);
              if (this.heroData != null) {
                if (this.heroData.heroID == null) {
                  return;
                }
                lVar1 = Component.GetComponent(this,DAT_181d93e60);
                lVar3 = il2cpp_internal(DAT_181d96ed0);
                FUN_18132faf0(lVar3,DAT_181da0cf8);
                if (lVar3 != null) {
                  FUN_18181de10(lVar3,0,DAT_181da0df8);
                  FUN_18181de10(lVar3,0,DAT_181da0df8);
                  if (lVar1 != null) {
                    *(int64 *)(lVar1 + 32) = lVar3;
                    return;
                  }
                }
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x6000D33
    // RVA   : 0xC7D340   Offset: 0xC7C740   Length: 0x15DF
    private void FixedUpdate()
    {
        var pStatics = *(int64*)(DAT_181dab490 + 184);
        uint uVar2;
        uint uVar3;
        uint uVar4;
        ulong uVar5;
        bool cVar6;
        long lVar7;
        long lVar10;
        ulong uVar12;
        ulong uVar13;
        int iVar14;
        float fVar16;
        float fVar17;
        float fVar18;
        float fVar19;
        ulong local_e8;
        float local_e0;
        ulong local_d8;
        float local_d0;
        ulong local_c8;
        float fStack_c0;
        uint32 uStack_bc;
        uint64 local_b8;
        uint64 uStack_b0;
        uint64 local_a8;
        uint64 uStack_a0;
        local_a8 = 0;
        uStack_a0 = 0;
        if (this.heroData == null) throw; // [null/range check failed]
        if (!this.heroData.inTeam) {
          lVar7 = BigmapNpcController.GetHeroTargetPos(this,0);
          if (lVar7 == null) throw; // [null/range check failed]
          if ((lVar7.isSummon == null.0) && (lVar7.summonID == null.0)) goto LAB_180c7d845;
          lVar7 = Component.get_transform(this,0);
          if (lVar7 == null) throw; // [null/range check failed]
          puVar8 = (uint64 *)Transform.get_localPosition(&local_c8,lVar7,0);
          uVar12 = *puVar8;
          fVar16 = *(float *)(puVar8 + 1);
          lVar7 = BigmapNpcController.GetHeroTargetPos(this,0);
          if (lVar7 == null) throw; // [null/range check failed]
          local_e8 = CONCAT44(lVar7.summonID * 0.01,lVar7.isSummon * 0.01);
          local_e0 = 0.0;
          local_d8 = uVar12;
          local_d0 = fVar16;
          cVar6 = Vector3.op_Inequality(&local_d8,&local_e8,0);
          if (!cVar6) goto LAB_180c7d845;
          lVar7 = BigmapNpcController.get_ArrowTrans(this,0);
          puVar8 = (uint64 *)Vector3.get_one(&local_b8,0);
          local_c8 = *puVar8;
          fStack_c0 = *(float *)(puVar8 + 1);
          local_e0 = fStack_c0 * 4.0;
          local_e8 = CONCAT44((float)((uint64)local_c8 >> 32) * 4.0,(float)local_c8 * 4.0);
          local_d8 = local_c8;
          local_d0 = fStack_c0;
          if (lVar7 == null) throw; // [null/range check failed]
          local_d8 = local_e8;
          local_d0 = local_e0;
          Transform.set_localScale(lVar7,&local_d8,0);
          puVar8 = (uint64 *)Vector3.get_right(&local_b8,0);
          uVar12 = *puVar8;
          fVar16 = *(float *)(puVar8 + 1);
          lVar7 = BigmapNpcController.GetHeroTargetPos(this,0);
          if (lVar7 == null) throw; // [null/range check failed]
          fVar17 = lVar7.isSummon;
          fVar18 = lVar7.summonID;
          lVar7 = Component.get_transform(this,0);
          if (lVar7 == null) throw; // [null/range check failed]
          puVar8 = (uint64 *)Transform.get_localPosition(&local_b8,lVar7,0);
          local_c8 = *puVar8;
          local_d0 = 0.0 - *(float *)(puVar8 + 1);
          local_d8 = CONCAT44(fVar18 * 0.01 - (float)((uint64)local_c8 >> 32),
                              fVar17 * 0.01 - (float)local_c8);
          local_e8 = uVar12;
          local_e0 = fVar16;
          fStack_c0 = local_d0;
          puVar9 = (uint32 *)Quaternion.FromToRotation(&local_b8,&local_e8,&local_d8,0);
          uVar2 = puVar9[1];
          uVar3 = puVar9[2];
          uVar4 = puVar9[3];
          this.finalRotation = *puVar9;
          *(uint32 *)(this + 148) = uVar2;
          *(uint32 *)(this + 152) = uVar3;
          *(uint32 *)(this + 156) = uVar4;
          if ((this.CircleObj == null) ||
             (lVar7 = GameObject.get_transform(this.CircleObj,0)) == null)
          throw; // [null/range check failed]
          local_b8 = this.finalRotation;
          uStack_b0 = *(uint64 *)(this + 152);
          puVar8 = (uint64 *)Transform.get_localRotation(&local_c8,lVar7,0);
          local_c8 = *puVar8;
          fStack_c0 = *(float *)(puVar8 + 1);
          uStack_bc = *(uint32 *)((int64)puVar8 + 12);
          cVar6 = Quaternion.op_Inequality(&local_c8,&local_b8,0);
          if (cVar6) {
            lVar7 = BigmapNpcController.get_CircleTweenRotation(this,0);
            if (lVar7 == null) throw; // [null/range check failed]
            cVar6 = Behaviour.get_enabled(lVar7,0);
            if (!cVar6) {
              lVar7 = BigmapNpcController.get_CircleTweenRotation(this,0);
              if ((this.CircleObj == null) ||
                 (lVar10 = GameObject.get_transform(this.CircleObj,0)) == null)
              throw; // [null/range check failed]
              puVar8 = (uint64 *)Transform.get_localRotation(&local_b8,lVar10,0);
              local_a8 = *puVar8;
              uStack_a0 = puVar8[1];
              puVar8 = (uint64 *)Quaternion.get_eulerAngles(&local_b8,&local_a8,0);
              if (lVar7 == null) throw; // [null/range check failed]
              lVar7.heroNickName = *puVar8;
              lVar7.isFemale = *(uint32 *)(puVar8 + 1);
              lVar7 = BigmapNpcController.get_CircleTweenRotation(this,0);
              puVar8 = (uint64 *)Quaternion.get_eulerAngles(&local_b8,this + 144,0);
              if (lVar7 == null) throw; // [null/range check failed]
              lVar7.belongForceID = *puVar8;
              lVar7.outsideForce = *(uint32 *)(puVar8 + 1);
              lVar7 = BigmapNpcController.get_CircleTweenRotation(this,0);
              if (lVar7 == null) throw; // [null/range check failed]
              UITweener.ResetToBeginning(lVar7,0);
              lVar7 = BigmapNpcController.get_CircleTweenRotation(this,0);
              if (lVar7 == null) throw; // [null/range check failed]
              UITweener.PlayForward(lVar7,0);
            }
          }
        }
        else {
        LAB_180c7d845:
          lVar7 = BigmapNpcController.get_ArrowTrans(this,0);
          puVar8 = (uint64 *)Vector3.get_zero(&local_b8,0);
          if (lVar7 == null) throw; // [null/range check failed]
          local_d0 = *(float *)(puVar8 + 1);
          local_d8 = *puVar8;
          Transform.set_localScale(lVar7,&local_d8,0);
        }
        lVar7 = this.leavingAreaSafeRange;
        cVar6 = Object.op_Inequality(lVar7,0,0);
        if (cVar6) {
          lVar7 = Component.get_transform(this,0);
          if (lVar7 == null) throw; // [null/range check failed]
          puVar8 = (uint64 *)Transform.get_localPosition(&local_b8,lVar7,0);
          uVar12 = *puVar8;
          fStack_c0 = *(float *)(puVar8 + 1);
          local_c8 = uVar12;
          if (((*plVar1 == 0) || (lVar7 = GameObject.get_transform(*plVar1,0)) == null) ||
             (lVar7 = FUN_180da9a20(lVar7,0)) == null) throw; // [null/range check failed]
          puVar8 = (uint64 *)Transform.get_localPosition(&local_b8,lVar7,0);
          local_c8 = *puVar8;
          fStack_c0 = *(float *)(puVar8 + 1);
          fVar16 = (float)Vector2.Distance(uVar12,local_c8,0);
          if ((*plVar1 == 0) || (lVar7 = GameObject.GetComponent(*plVar1,DAT_181dc7f30)) == null)
          throw; // [null/range check failed]
          fVar17 = (float)CapsuleCollider.get_radius(lVar7,0);
          if ((*plVar1 == 0) || (lVar7 = GameObject.get_transform(*plVar1,0)) == null)
          throw; // [null/range check failed]
          pfVar11 = (float *)Transform.get_localScale(&local_b8,lVar7,0);
          if (fVar17 * *pfVar11 + 0.2 < fVar16) {
            *plVar1 = 0;
            il2cpp_internal(plVar1,0);
            if ((this.heroData == null) ||
               (lVar7 = this.heroData.heroAIData) == null)
            throw; // [null/range check failed]
            HeroAIData.WandererLoseTarget(lVar7,0);
          }
        }
        uVar12 = this.heroFollowTarget;
        cVar6 = Object.op_Inequality(uVar12,0,0);
        if (cVar6) {
          if (this.heroFollowTarget == null) throw; // [null/range check failed]
          uVar12 = GameObject.GetComponent(this.heroFollowTarget,DAT_181dc76b0);
          cVar6 = BigmapNpcController.HeroCanFollow
                            (this,uVar12,this.heroFollowType,
                             this.followRangeRate,0);
          if (!cVar6) {
            this.heroFollowTarget = 0;
            this.heroChaseTime = 0;
            if ((this.heroData == null) ||
               (lVar7 = this.heroData.heroAIData) == null)
            throw; // [null/range check failed]
            if (lVar7.interestingStar < 0) {
              HeroAIData.WandererLoseTarget(lVar7,0);
            }
          }
        }
        uVar12 = this.areaSafeRangeBuffer;
        cVar6 = Object.op_Inequality(uVar12,0,0);
        if (!cVar6) {
          uVar12 = this.areaSafeRange;
          cVar6 = Object.op_Inequality(uVar12,0,0);
          if (!(cVar6))
          {
            }
            else {
          }
          fVar16 = this.areaSafeRangeRefreshTime;
          fVar17 = (float)Time.get_deltaTime(0);
          fVar16 = fVar16 - fVar17;
          this.areaSafeRangeRefreshTime = fVar16;
          if (fVar16 <= 0.0) {
            uVar12 = this.areaSafeRangeBuffer;
            this.areaSafeRangeRefreshTime = 0x3dcccccd;
            cVar6 = Object.op_Inequality(uVar12,0,0);
            if (!cVar6) {
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
        cVar6 = Object.op_Equality(uVar12,0,0);
        if (!cVar6) {
          fVar16 = 0.4;
        }
        else {
          fVar16 = 0.0;
        }
        if (this.SafeSprite == null) throw; // [null/range check failed]
        lVar7 = SpriteRenderer.get_color(&local_b8,this.SafeSprite,0);
        if (*(float *)(lVar7 + 12) != fVar16) {
          lVar7 = this.SafeSprite;
          if (lVar7 == null) throw; // [null/range check failed]
          puVar8 = (uint64 *)SpriteRenderer.get_color(&local_b8,lVar7,0);
          uVar12 = *puVar8;
          uVar13 = puVar8[1];
          local_b8 = uVar12;
          uStack_b0 = uVar13;
          puVar8 = (uint64 *)GlobalData.SetColorAlpha(&local_c8,&local_b8,fVar16,0);
          local_b8 = *puVar8;
          uStack_b0 = puVar8[1];
          SpriteRenderer.set_color(lVar7,&local_b8,0);
        }
        fVar16 = this.checkBigMapColliderTime;
        fVar17 = (float)Time.get_deltaTime(0);
        fVar16 = fVar16 - fVar17;
        this.checkBigMapColliderTime = fVar16;
        if (fVar16 < 0.0) {
          this.checkBigMapColliderTime = 0x3dcccccd;
          if (!this.inBigMapSpeEffectBuff) {
            this.inBigMapSpeEffectType = 0xffffffff;
          }
          this.inBigMapSpeEffectBuff = 0;
          if (!this.inWaterBuff) {
            if (this.heroData == null) throw; // [null/range check failed]
            this.heroData.inWater = 0;
            uVar12 = Component.GetComponent(this,DAT_181d93e60);
            cVar6 = Object.op_Inequality(uVar12,0,0);
            if (cVar6) {
              lVar7 = Component.GetComponent(this,DAT_181d93e60);
              if (lVar7 == null) throw; // [null/range check failed]
              lVar7.summonSourceHero = 0;
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
        lVar7 = *(int64 *)(*(int64 *)(DAT_181da9de0 + 184) + 24);
        if (((this.heroData == null) ||
            (lVar10 = this.heroData.heroAIData) == null) || (lVar7 == null))
        throw; // [null/range check failed]
        cVar6 = FUN_18182a3a0(lVar7,*(uint32 *)(lVar10 + 16),DAT_181d7ae88);
        lVar7 = this.BigMapFightIcon;
        if (!cVar6) {
          cVar6 = Object.op_Inequality(lVar7,0,0);
          if (cVar6) {
            if (*plVar1 == 0) throw; // [null/range check failed]
            cVar6 = GameObject.get_activeSelf(*plVar1,0);
            if (cVar6) {
              if (*plVar1 == 0) throw; // [null/range check failed]
              GameObject.SetActive(*plVar1,0,0);
              if (*plVar1 == 0) throw; // [null/range check failed]
              uVar12 = GameObject.get_transform(*plVar1,0);
              ShortcutExtensions.DOKill(uVar12,0,0);
            }
          }
        }
        else {
          cVar6 = Object.op_Equality(lVar7,0,0);
          if (!cVar6) {
            if (*plVar1 == 0) throw; // [null/range check failed]
            cVar6 = GameObject.get_activeSelf(*plVar1,0);
            if (!cVar6) {
              if (*plVar1 == 0) throw; // [null/range check failed]
              GameObject.SetActive(*plVar1,1,0);
              goto LAB_180c7dfac;
            }
          }
          else {
            lVar7 = FUN_18046bbe0(0);
            if (lVar7 == null) throw; // [null/range check failed]
            uVar12 = lVar7.generation;
            uVar13 = this.BigMapFightIconPrefab;
            lVar7 = GlobalData.AddChild(uVar12,uVar13,0);
            *plVar1 = lVar7;
            il2cpp_internal(plVar1,lVar7);
        LAB_180c7dfac:
            if (*plVar1 == 0) throw; // [null/range check failed]
            uVar12 = GameObject.get_transform(*plVar1,0);
            uVar12 = ShortcutExtensions.DOScale(uVar12,0x3f99999a,0x3f000000,0);
            TweenSettingsExtensions.SetLoops(uVar12,0xffffffff,1,DAT_181dc1330);
          }
          if (*plVar1 == 0) throw; // [null/range check failed]
          lVar7 = GameObject.get_transform(*plVar1,0);
          lVar10 = Component.get_transform(this,0);
          if ((lVar10 == null) ||
             (puVar8 = (uint64 *)Transform.get_position(&local_b8,lVar10,0), lVar7 == null))
          throw; // [null/range check failed]
          local_d8 = *puVar8;
          local_d0 = *(float *)(puVar8 + 1);
          Transform.set_position(lVar7,&local_d8,0);
        }
        if (this.needRefresh) {
          BigmapNpcController.RefreshHeroSkeleton(this,0);
        }
        lVar7 = this.heroData;
        if ((lVar7 == null) || (lVar7.heroAIData == null)) throw; // [null/range check failed]
        iVar14 = *(int *)(lVar7.heroAIData + 16);
        if (iVar14 == 13) {
          uVar12 = this.selfSkeleton;
          uVar13 = HeroData.GetHeroWeaponAttackAnim(lVar7,0);
          BigmapNpcController.SetSkeletonAttackAnim(this,uVar12,uVar13,0);
        }
        else {
          if ((lVar7.heroID == null) || (iVar14 == 1)) {
            lVar7 = BigmapNpcController.GetHeroTargetPos(this,0);
            if (lVar7 == null) throw; // [null/range check failed]
            if ((lVar7.isSummon == null.0) && (lVar7.summonID == null.0)) {
              bVar15 = false;
            }
            else {
              bVar15 = true;
            }
            uVar12 = this.selfSkeleton;
            lVar7 = this.heroData;
            if (bVar15) {
              lVar10 = Component.get_transform(this,0);
              if (lVar10 == null) throw; // [null/range check failed]
              puVar8 = (uint64 *)Transform.get_localPosition(&local_b8,lVar10,0);
              uVar13 = *puVar8;
              fVar16 = *(float *)(puVar8 + 1);
              lVar10 = BigmapNpcController.GetHeroTargetPos(this,0);
              if (lVar10 == null) throw; // [null/range check failed]
              local_d8 = uVar13;
              local_d0 = fVar16;
              BigmapNpcController.SetSkeletonRunAnim
                        (this,uVar12,lVar7,&local_d8,
                         CONCAT44(*(float *)(lVar10 + 20) * 0.01,*(float *)(lVar10 + 16) * 0.01),0);
              goto LAB_180c7e190;
            }
          }
          else {
            uVar12 = this.selfSkeleton;
          }
          BigmapNpcController.SetSkeletonIdleAnim(this,uVar12,lVar7,0);
        }
        LAB_180c7e190:
        BigmapNpcController.ManageFollowerMove(this,0);
        lVar7 = *(int64 *)(*(int64 *)(DAT_181db0bc8 + 184) + 16);
        if (lVar7 == null) throw; // [null/range check failed]
        fVar16 = (float)BigMapController.BigMapNowScale(lVar7,0);
        if (fVar16 < **(float **)(DAT_181db0bc8 + 184)) {
          BigmapNpcController.SetAllSkeletonActive(this,0,0);
          if (this.heroSimpleSprite == null) throw; // [null/range check failed]
          cVar6 = GameObject.get_activeSelf(this.heroSimpleSprite,0);
          fVar16 = 1.0;
          if (!cVar6) {
            if (this.heroSimpleSprite == null) throw; // [null/range check failed]
            GameObject.SetActive(this.heroSimpleSprite,1,0);
            if (this.heroSimpleSprite == null) throw; // [null/range check failed]
            lVar7 = GameObject.GetComponent(this.heroSimpleSprite,DAT_181d73bb8);
            if ((this.heroSimpleSprite == null) ||
               (lVar10 = GameObject.GetComponent(this.heroSimpleSprite,DAT_181d73bb8),
               lVar10 == null)) throw; // [null/range check failed]
            puVar8 = (uint64 *)SpriteRenderer.get_color(&local_b8,lVar10,0);
            uVar12 = *puVar8;
            uVar13 = puVar8[1];
            local_b8 = uVar12;
            uStack_b0 = uVar13;
            puVar8 = (uint64 *)GlobalData.SetColorAlpha(&local_c8,&local_b8,0,0);
            if (lVar7 == null) throw; // [null/range check failed]
            local_b8 = *puVar8;
            uStack_b0 = puVar8[1];
            SpriteRenderer.set_color(lVar7,&local_b8,0);
            if (this.heroSimpleSprite == null) throw; // [null/range check failed]
            uVar12 = GameObject.GetComponent(this.heroSimpleSprite,DAT_181d73bb8);
            DOTweenModuleSprite.DOFade(uVar12,0x3f800000,0x3ecccccd,0);
          }
          if (this.heroSimpleSprite == null) throw; // [null/range check failed]
          lVar7 = GameObject.get_transform(this.heroSimpleSprite,0);
          puVar8 = (uint64 *)Vector3.get_one(&local_b8,0);
          if (this.heroData == null) throw; // [null/range check failed]
          if (this.heroData.heroID == null) {
            fVar16 = 1.5;
          }
          local_d8 = *puVar8;
          fVar19 = (float)local_d8;
          uVar5 = (uint64)local_d8 >> 32;
          local_d0 = *(float *)(puVar8 + 1);
          fVar17 = this.originSimpleSpriteScale;
          fVar18 = (float)BigmapNpcController.GetBigMapExtraScale(this,0x40000000,0);
          local_e0 = local_d0 * fVar16 * fVar17 * fVar18;
          local_e8 = CONCAT44((float)uVar5 * fVar16 * fVar17 * fVar18,fVar19 * fVar16 * fVar17 * fVar18);
          if (lVar7 == null) throw; // [null/range check failed]
          local_d8 = local_e8;
          local_d0 = local_e0;
          Transform.set_localScale(lVar7,&local_d8,0);
          lVar7 = this.hoverRangeCollider;
          fVar16 = this.originCapsuleColliderRadius;
          fVar17 = (float)BigmapNpcController.GetBigMapExtraScale(this,0x40000000,0);
          if (lVar7 == null) throw; // [null/range check failed]
          CapsuleCollider.set_radius(lVar7,fVar17 * fVar16,0);
          lVar7 = this.hoverRangeCollider;
          fVar16 = this.originCapsuleColliderHeight;
          fVar17 = (float)BigmapNpcController.GetBigMapExtraScale(this,0x40000000,0);
          if (lVar7 == null) throw; // [null/range check failed]
          CapsuleCollider.set_height(lVar7,fVar17 * fVar16,0);
          local_d0 = *(float *)(this + 244);
          lVar7 = this.hoverRangeCollider;
          uVar12 = this.originCapsuleColliderCenter;
          fVar17 = (float)BigmapNpcController.GetBigMapExtraScale(this,0x40000000,0);
          fVar18 = fVar17 * (float)uVar12;
          fVar16 = fVar17 * local_d0;
          fVar17 = fVar17 * (float)((uint64)uVar12 >> 32);
          local_e8 = CONCAT44(fVar17,fVar18);
          local_e0 = fVar16;
          local_d8 = uVar12;
          if (lVar7 == null) throw; // [null/range check failed]
        LAB_180c7e5bb:
          local_d8 = CONCAT44(fVar17,fVar18);
          local_d0 = fVar16;
          CapsuleCollider.set_center(lVar7,&local_d8,0);
        }
        else {
          BigmapNpcController.SetAllSkeletonActive(this,1);
          if (this.heroSimpleSprite == null) throw; // [null/range check failed]
          cVar6 = GameObject.get_activeSelf(this.heroSimpleSprite,0);
          if (cVar6) {
            if (this.heroSimpleSprite == null) throw; // [null/range check failed]
            GameObject.SetActive(this.heroSimpleSprite,0,0);
            if (this.hoverRangeCollider == null) throw; // [null/range check failed]
            CapsuleCollider.set_radius(this.hoverRangeCollider,this.originCapsuleColliderRadius,0);
            if (this.hoverRangeCollider == null) throw; // [null/range check failed]
            CapsuleCollider.set_height(this.hoverRangeCollider,this.originCapsuleColliderHeight,0);
            lVar7 = this.hoverRangeCollider;
            if (lVar7 == null) throw; // [null/range check failed]
            fVar18 = (float)this.originCapsuleColliderCenter;
            fVar17 = (float)((uint64)this.originCapsuleColliderCenter >> 32);
            fVar16 = *(float *)(this + 244);
            goto LAB_180c7e5bb;
          }
        }
        if (this.heroMissionTarget != null) {
          lVar7 = GameObject.get_transform(this.heroMissionTarget,0);
          puVar8 = (uint64 *)Vector3.get_one(&local_b8,0);
          local_d8 = *puVar8;
          fVar17 = (float)local_d8;
          uVar5 = (uint64)local_d8 >> 32;
          local_d0 = *(float *)(puVar8 + 1);
          fVar16 = (float)BigmapNpcController.GetBigMapExtraScale(this,0x40800000,0);
          local_e0 = local_d0 * 0.5 * fVar16;
          local_e8 = CONCAT44((float)uVar5 * 0.5 * fVar16,fVar17 * 0.5 * fVar16);
          if (lVar7 != null) {
            local_d8 = local_e8;
            local_d0 = local_e0;
            Transform.set_localScale(lVar7,&local_d8,0);
            lVar7 = this.heroData;
            if (lVar7 != null) {
              iVar14 = 1;
              if ((lVar7.plotNumCount < 1) && (iVar14 = 0, 0 < lVar7.missionNumCount)) {
                iVar14 = 2;
              }
              if (this.missionState != iVar14) {
                bVar15 = !DAT_181e9e5e7;
                this.missionState = iVar14;
                if (bVar15) {
                  il2cpp_runtime_class_init(&DAT_181d73bb8);
                  il2cpp_runtime_class_init(&DAT_181d8e210);
                  DAT_181e9e5e7 = true;
                }
                uVar12 = this.heroMissionRenderer;
                cVar6 = Object.op_Equality(uVar12,0,0);
                if (cVar6) {
                  uVar12 = this.heroMissionTarget;
                  cVar6 = Object.op_Inequality(uVar12,0,0);
                  if (cVar6) {
                    if (this.heroMissionTarget == null) throw; // [null/range check failed]
                    uVar12 = GameObject.GetComponent(this.heroMissionTarget,DAT_181d73bb8);
                    this.heroMissionRenderer = uVar12;
                  }
                }
                lVar7 = this.heroMissionRenderer;
                if (this.missionState == 1) {
                  if ((*pStatics == 0) ||
                     (uVar12 = TextureController.LoadAtlasSprite
                                         (*pStatics,"BigMapAtlas",
                                          "问号",0), lVar7 == null)) throw; // [null/range check failed]
                  SpriteRenderer.set_sprite(lVar7,uVar12,0);
                  puVar8 = (uint64 *)Color.get_yellow(&local_b8,0);
                }
                else if (this.missionState == 2) {
                  if ((*pStatics == 0) ||
                     (uVar12 = TextureController.LoadAtlasSprite
                                         (*pStatics,"BigMapAtlas",
                                          "任务目标",0), lVar7 == null)) throw; // [null/range check failed]
                  SpriteRenderer.set_sprite(lVar7,uVar12,0);
                  puVar8 = (uint64 *)FUN_1810d3570(&local_b8,0);
                }
                else {
                  puVar8 = (uint64 *)FUN_180d98fe0(&local_b8,0);
                  if (lVar7 == null) throw; // [null/range check failed]
                }
                local_b8 = *puVar8;
                uStack_b0 = puVar8[1];
                SpriteRenderer.set_color(lVar7,&local_b8,0);
              }
              return;
            }
          }
        }
    }

    // Token : 0x6000D34
    // RVA   : 0xC7FCC0   Offset: 0xC7F0C0   Length: 0x5C
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

    // Token : 0x6000D35
    // RVA   : 0xC813C0   Offset: 0xC807C0   Length: 0x167
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
        if ((lVar6 == null) || (lVar6.heroAIData == null)) goto LAB_180c81522;
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
        LAB_180c81522:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
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
              goto LAB_180c81522;
            }
          }
          BigmapNpcController.SetSkeletonIdleAnim
                    (this,this.selfSkeleton,this.heroData,0);
        }
    }

    // Token : 0x6000D36
    // RVA   : 0xC7E920   Offset: 0xC7DD20   Length: 0x176
    public float GetBigMapExtraScale(float extraScale)
    {
        float fVar1;
        float fVar2;
        long lVar3;
        float fVar4;
        fVar1 = **(float **)(DAT_181db0bc8 + 184);
        lVar3 = GameController.CheckShowSpeHero;
        if (lVar3 != null) {
          fVar4 = (float)BigMapController.BigMapNowScale(lVar3,0);
          fVar2 = **(float **)(DAT_181db0bc8 + 184);
          lVar3 = GameController.CheckShowSpeHero;
          if (lVar3 != null) {
            Mathf.Max(lVar3,((fVar1 - fVar4) * extraScale) / (fVar2 - *(float *)(lVar3 + 28)) + 1.0,0);
            return;
          }
        }
    }

    // Token : 0x6000D37
    // RVA   : 0xC819E0   Offset: 0xC80DE0   Length: 0x13A
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
                    (lVar2 = FUN_180002f80(this.followers,uVar3,DAT_181d7fea0)) == null
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

    // Token : 0x6000D38
    // RVA   : 0xC7F020   Offset: 0xC7E420   Length: 0x207
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
          goto LAB_180c7f222;
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
                    if (*(int64 *)(lVar3 + 64) == 0) goto LAB_180c7f222;
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
        LAB_180c7f222:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
            }
          }
        }
        return false;
    }

    // Token : 0x6000D39
    // RVA   : 0xC7EAE0   Offset: 0xC7DEE0   Length: 0x3B0
    public BigMapPos GetHeroTargetPos()
    {
        long lVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        float fVar9;
        float fVar10;
        byte[] local_28 = new byte[32];
        uVar4 = *(uint64 *)(this + 200);
        cVar2 = Object.op_Inequality(uVar4,0,0);
        if (cVar2) {
          if (this.heroData != null) {
            lVar5 = BigMapPos.op_Multiply
                              (this.heroData.bigMapPos,0x40000000,0);
            if (((*(int64 *)(this + 200) != 0) &&
                (lVar3 = GameObject.get_transform(*(int64 *)(this + 200),0)) != null) &&
               (lVar3 = FUN_180da9a20(lVar3,0)) != null) {
              puVar7 = (uint64 *)Transform.get_localPosition(local_28,lVar3,0);
              uVar4 = *puVar7;
              lVar3 = new ZhSegment(0);
              bVar8 = !DAT_181e9e5d8;
              *(float *)(lVar3 + 20) = (float)((uint64)uVar4 >> 32) * 100.0;
              *(float *)(lVar3 + 16) = (float)uVar4 * 100.0;
              if (bVar8) {
                il2cpp_runtime_class_init(&DAT_181db0cc8);
                DAT_181e9e5d8 = true;
              }
              if ((lVar5 != null) &&
                 (plVar6 = (int64 *)BigMapPos.Clone(lVar5,0), plVar6 != (int64 *)0)) {
                if ((*(byte *)(DAT_181db0cc8 + 300) <= *(byte *)(*plVar6 + 300)) &&
                   (*(int64 *)
                     (*(int64 *)(*plVar6 + 200) + -8 + (uint64)*(byte *)(DAT_181db0cc8 + 300) * 8)
                    == DAT_181db0cc8)) {
                  *(float *)(plVar6 + 2) = *(float *)(plVar6 + 2) - *(float *)(lVar3 + 16);
                  *(float *)((int64)plVar6 + 20) =
                       *(float *)((int64)plVar6 + 20) - *(float *)(lVar3 + 20);
                  return plVar6;
                }
                          // WARNING: Subroutine does not return
                FUN_1800d6070(plVar6,DAT_181db0cc8);
              }
            }
          }
          throw; // [null/range check failed]
        }
        uVar4 = this.heroFollowTarget;
        cVar2 = Object.op_Inequality(uVar4,0,0);
        if (!cVar2) {
          if (this.heroData == null) throw; // [null/range check failed]
          lVar5 = this.heroData.heroAIData;
        }
        else {
          if (this.heroFollowType == 1) {
            if (((this.heroFollowTarget != null) &&
                (lVar5 = GameObject.GetComponent(this.heroFollowTarget,DAT_181dc76b0), lVar5 != null
                )) && (*(int64 *)(lVar5 + 24) != 0)) {
              return *(int64 **)(*(int64 *)(lVar5 + 24) + 200);
            }
            throw; // [null/range check failed]
          }
          if (this.heroData == null) throw; // [null/range check failed]
          lVar5 = this.heroData.bigMapPos;
          if (((this.heroFollowTarget == null) ||
              (lVar3 = GameObject.GetComponent(this.heroFollowTarget,DAT_181dc76b0)) == null)
             || ((*(int64 *)(lVar3 + 24) == 0 ||
                 ((lVar5 == null || (lVar3 = *(int64 *)(*(int64 *)(lVar3 + 24) + 200)) == null)))
                )) throw; // [null/range check failed]
          lVar1 = this.heroData;
          fVar9 = (float)FUN_1801f8ab0(*(float *)(lVar3 + 20) - *(float *)(lVar5 + 20),0x40000000);
          fVar10 = (float)FUN_1801f8ab0(*(float *)(lVar3 + 16) - *(float *)(lVar5 + 16));
          fVar9 = fVar9 + fVar10;
          if (fVar9 < 0.0) {
            fVar9 = (float)FUN_1801f9ff4(fVar9);
          }
          else {
            fVar9 = SQRT(fVar9);
          }
          if (0.1 <= fVar9) {
            if (lVar1 != null) {
              uVar4 = BigMapPos.op_Multiply(lVar1.bigMapPos,0x40000000,0);
              if (((this.heroFollowTarget != null) &&
                  (lVar5 = GameObject.GetComponent(this.heroFollowTarget,DAT_181dc76b0),
                  lVar5 != null)) && (*(int64 *)(lVar5 + 24) != 0)) {
                plVar6 = (int64 *)
                         BigMapPos.op_Subtraction
                                   (uVar4,*(uint64 *)(*(int64 *)(lVar5 + 24) + 200),0);
                return plVar6;
              }
            }
            throw; // [null/range check failed]
          }
          if (lVar1 == null) throw; // [null/range check failed]
          lVar5 = lVar1.heroAIData;
        }
        if (lVar5 != null) {
          return *(int64 **)(lVar5 + 56);
        }
    }

    // Token : 0x6000D3A
    // RVA   : 0xC7D230   Offset: 0xC7C630   Length: 0x10B
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
          FUN_1800d6620();
        }
        return false;
    }

    // Token : 0x6000D3B
    // RVA   : 0xC7EAC0   Offset: 0xC7DEC0   Length: 0x1D
    public float GetBigMapTravelSpeed()
    {
        if (param_2 != 0) {
          HeroData.GetFinalTravelSpeed(param_2,0);
          return;
        }
    }

    // Token : 0x6000D3C
    // RVA   : 0xC7EAA0   Offset: 0xC7DEA0   Length: 0x1F
    public float GetBigMapTravelSpeed(HeroData targetHero)
    {
        if (targetHero != null) {
          HeroData.GetFinalTravelSpeed(targetHero,0);
          return;
        }
    }

    // Token : 0x6000D3D
    // RVA   : 0xC81E00   Offset: 0xC81200   Length: 0x2EE
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
        LAB_180c81f48:
          Transform.set_localRotation(lVar4,&local_38,0);
        }
        else if (nextPos < *originPos) {
          if (targetSkeleton == null) throw; // [null/range check failed]
          lVar4 = GameObject.get_transform(targetSkeleton,0);
          lVar1 = *(int64 *)(DAT_181d73d40 + 184);
          if (lVar4 == null) throw; // [null/range check failed]
          local_38 = *(uint32 *)(lVar1 + 0x690);
          uStack_34 = *(uint32 *)(lVar1 + 0x694);
          uStack_30 = *(uint32 *)(lVar1 + 0x698);
          uStack_2c = *(uint32 *)(lVar1 + 0x69c);
          goto LAB_180c81f48;
        }
        fVar8 = (float)HeroData.GetFinalTravelSpeed(targetHero,0);
        fVar9 = 1.0;
        if (fVar8 < 1.0) {
          fVar8 = fVar8 * 0.5 + 0.5;
        }
        lVar4 = FUN_18046bbe0(0);
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

    // Token : 0x6000D3E
    // RVA   : 0xC7FD20   Offset: 0xC7F120   Length: 0x9AF
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
                  (lVar5 = FUN_180002f80(this.followers,uVar12,DAT_181d7fea0)) == null)
                 || ((lVar5._items == null ||
                     (lVar5 = GameObject.get_transform(lVar5._items,0)) == null)))
              break;
              pfVar11 = (float *)Transform.get_localPosition(local_c8,lVar5,0);
              fVar15 = *pfVar11;
              if (((this.followers == null) ||
                  (lVar5 = FUN_180002f80(this.followers,uVar12,DAT_181d7fea0)) == null)
                 || ((lVar5._items == null ||
                     (lVar5 = GameObject.get_transform(lVar5._items,0)) == null)))
              break;
              lVar5 = Transform.get_localPosition(local_b8,lVar5,0);
              fVar2 = *(float *)(lVar5 + 4);
              local_1c8 = CONCAT44(fVar2,fVar15);
              if ((((this.followers == null) ||
                   (lVar5 = FUN_180002f80(this.followers,uVar12,DAT_181d7fea0)) == null
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
                 (lVar5 = FUN_180002f80(this.followers,uVar12,DAT_181d7fea0)) == null)
              break;
              fVar14 = fVar14 - lVar5.Count;
              fVar15 = (float)local_188 * fVar14 + (float)local_178;
              fVar14 = local_188._4_4_ * fVar14 + local_178._4_4_;
              if ((this.followers == null) ||
                 (lVar5 = FUN_180002f80(this.followers,uVar12,DAT_181d7fea0)) == null)
              break;
              uVar8 = lVar5._items;
              lVar5 = FUN_18046c0a0(0);
              if (lVar5 == null) break;
              lVar5 = *(int64 *)(lVar5 + 32);
              if (((this.followers == null) ||
                  (lVar7 = FUN_180002f80(this.followers,uVar12,DAT_181d7fea0)) == null)
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
                  (lVar5 = FUN_180002f80(this.followers,uVar12,DAT_181d7fea0)) == null)
                 || (lVar5._items == null)) break;
              lVar5 = GameObject.get_transform(lVar5._items,0);
              local_190 = 0;
              local_198 = fVar15;
              fStack_194 = fVar14;
              if (lVar5 == null) break;
              local_138 = CONCAT44(fVar14,fVar15);
              local_130 = 0;
              Transform.set_localPosition(lVar5,&local_138,0);
              lVar5 = FUN_18046bbe0(0);
              if ((((this.followers == null) ||
                   (lVar7 = FUN_180002f80(this.followers,uVar12)) == null) ||
                  (*(int64 *)(lVar7 + 16) == 0)) ||
                 (GameObject.get_transform(*(int64 *)(lVar7 + 16),0), lVar5 == null)) break;
              BigMapController.SetBigMapHeroZPos(lVar5);
            }
            else {
              if ((this.heroData == null) ||
                 (lVar5 = this.heroData.heroAIData) == null) break;
              if (lVar5._items == 13) {
                if ((this.followers == null) ||
                   (lVar5 = FUN_180002f80(this.followers,uVar12,DAT_181d7fea0)) == null
                   ) break;
                uVar8 = lVar5._items;
                lVar5 = FUN_18046c0a0(0);
                if (lVar5 == null) break;
                lVar5 = *(int64 *)(lVar5 + 32);
                if (((this.followers == null) ||
                    (lVar7 = FUN_180002f80(this.followers,uVar12,DAT_181d7fea0), lVar7 == null
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
                  if ((lVar5 == null) || (lVar5 = FUN_180002f80(lVar5,uVar12,DAT_181d7fea0)) == null)
                  break;
                  lVar5 = FUN_18046c0a0(0);
                  if (lVar5 == null) break;
                  lVar5 = *(int64 *)(lVar5 + 32);
                  if (((this.followers == null) ||
                      (lVar7 = FUN_180002f80(this.followers,uVar12,DAT_181d7fea0),
                      lVar7 == null)) || (*(int64 *)(lVar7 + 16) == 0)) break;
                  uVar8 = Object.get_name(*(int64 *)(lVar7 + 16),0);
                  uVar4 = Int32.Parse(uVar8,0);
                  if (lVar5 == null) break;
                  WorldData.GetHero(lVar5,uVar4,0);
                  BigmapNpcController.SetSkeletonIdleAnim(this);
                }
                else {
                  if ((lVar5 == null) || (lVar5 = FUN_180002f80(lVar5,uVar12,DAT_181d7fea0)) == null)
                  break;
                  uVar8 = lVar5._items;
                  lVar5 = FUN_18046c0a0(0);
                  if (lVar5 == null) break;
                  lVar5 = *(int64 *)(lVar5 + 32);
                  if (((this.followers == null) ||
                      (lVar7 = FUN_180002f80(this.followers,uVar12,DAT_181d7fea0),
                      lVar7 == null)) || (*(int64 *)(lVar7 + 16) == 0)) break;
                  uVar9 = Object.get_name(*(int64 *)(lVar7 + 16),0);
                  uVar4 = Int32.Parse(uVar9,0);
                  if (lVar5 == null) break;
                  uVar9 = WorldData.GetHero(lVar5,uVar4,0);
                  if (((this.followers == null) ||
                      (lVar5 = FUN_180002f80(this.followers,uVar12,DAT_181d7fea0),
                      lVar5 == null)) ||
                     ((lVar5._items == null ||
                      (lVar5 = GameObject.get_transform(lVar5._items,0)) == null)))
                  break;
                  puVar10 = (uint32 *)Transform.get_localPosition(local_f8,lVar5,0);
                  uVar4 = *puVar10;
                  if (((this.followers == null) ||
                      (lVar5 = FUN_180002f80(this.followers,uVar12,DAT_181d7fea0),
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

    // Token : 0x6000D3F
    // RVA   : 0xC81C80   Offset: 0xC81080   Length: 0x17E
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

    // Token : 0x6000D40
    // RVA   : 0xC81B20   Offset: 0xC80F20   Length: 0x157
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

    // Token : 0x6000D41
    // RVA   : 0xC80AE0   Offset: 0xC7FEE0   Length: 0x8D6
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
           (uVar5 = GameObject.GetComponent(this.selfSkeleton,DAT_181d734d0), lVar12 != null)) {
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
                cVar3 = FUN_18182a3a0(lVar2,uVar4,DAT_181d8f398);
                if (!cVar3) {
                  if ((this.followers == null) ||
                     (lVar6 = FUN_180002f80(this.followers,uVar9,DAT_181d7fea0), lVar6 == null
                     )) throw; // [null/range check failed]
                  uVar5 = lVar6._items;
                  Object.Destroy(uVar5,0);
                  if (this.followers == null) throw; // [null/range check failed]
                  FUN_181823590(this.followers,uVar9,DAT_181d7fda0);
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
                  if (lVar6.Count <= iVar10) goto LAB_180c80e88;
                  lVar6 = FUN_180002f80(lVar6,iVar10,DAT_181d7fea0);
                  if ((lVar6 == null) || (lVar6._items == null)) throw; // [null/range check failed]
                  uVar5 = Object.get_name(lVar6._items,0);
                  if ((this.heroData == null) ||
                     (lVar6 = this.heroData.teamMates) == null)
                  throw; // [null/range check failed]
                  local_res8[0] = FUN_1800d6760(lVar6,iVar11,DAT_181d8fa18);
                  uVar7 = Int32.ToString(local_res8,0);
                  cVar3 = FUN_18171e540(uVar5,uVar7,0);
                  if (cVar3) break;
                  iVar10 = iVar10 + 1;
                }
                if ((this.followers == null) ||
                   (lVar12 = FUN_180002f80(this.followers,iVar10,DAT_181d7fea0),
                   lVar12 == null)) break;
                lVar12 = lVar12.isSummon;
                if ((this.followers == null) ||
                   (lVar6 = FUN_180002f80(this.followers,iVar10,DAT_181d7fea0)) == null
                   ) break;
                lVar6.Count = fVar14;
        LAB_180c80e88:
                cVar3 = Object.op_Equality(lVar12,0,0);
                if (!cVar3) {
                  lVar6 = FUN_18046c0a0(0);
                  if (lVar6 == null) break;
                  lVar6 = *(int64 *)(lVar6 + 32);
                  if ((((this.heroData == null) ||
                       (lVar2 = this.heroData.teamMates) == null) ||
                      (uVar4 = FUN_1800d6760(lVar2,iVar11), lVar6 == null)) ||
                     ((lVar6 = WorldData.GetHero(lVar6,uVar4), lVar12 == null ||
                      (uVar5 = GameObject.GetComponent(lVar12,DAT_181d734d0), lVar6 == null)))) break;
                  HeroData.RefreshHeroSkeleton(lVar6,uVar5);
                }
                else {
                  lVar12 = FUN_18046c0a0(0);
                  if (lVar12 == null) break;
                  lVar12 = lVar12.summonControlable;
                  if (((this.heroData == null) ||
                      (lVar6 = this.heroData.teamMates) == null) ||
                     (uVar4 = FUN_1800d6760(lVar6,iVar11,DAT_181d8fa18), lVar12 == null)) break;
                  lVar12 = WorldData.GetHero(lVar12,uVar4,0);
                  lVar6 = Component.get_transform(this,0);
                  if ((lVar6 == null) || (lVar6 = FUN_180da9a20(lVar6,0)) == null) break;
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
                  lVar12 = GameObject.AddComponent(*plVar1,DAT_181dc5db8);
                  if ((*plVar1 == 0) ||
                     (uVar5 = GameObject.GetComponent(*plVar1,DAT_181d734d0), lVar12 == null)) break;
                  lVar12.summonLv = uVar5;
                  lVar12 = *plVar1;
                  if ((this.heroData == null) ||
                     (lVar6 = this.heroData.teamMates) == null) break;
                  local_res8[0] = FUN_1800d6760(lVar6,iVar11,DAT_181d8fa18);
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
                  lVar12 = FUN_18046bbe0(0);
                  if ((*plVar1 == 0) || (uVar5 = GameObject.get_transform(*plVar1,0), lVar12 == null))
                  break;
                  BigMapController.SetBigMapHeroZPos(lVar12,uVar5,0);
                  lVar12 = this.followers;
                  lVar6 = *plVar1;
                  uVar5 = new AreaBuildingRateChange(lVar6,fVar14);
                  if (lVar12 == null) break;
                  FUN_18181e0a0(lVar12,uVar5);
                }
                lVar12 = this.heroData;
                iVar11 = iVar11 + 1;
                if (lVar12 == null) break;
              }
            }
          }
        }
    }

    // Token : 0x6000D42
    // RVA   : 0xC80840   Offset: 0xC7FC40   Length: 0x141
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

    // Token : 0x6000D43
    // RVA   : 0xC80990   Offset: 0xC7FD90   Length: 0x14B
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
            FUN_1800d6620();
          }
          local_20 = *(uint32 *)(puVar2 + 1);
          local_28 = *puVar2;
          Transform.set_localScale(lVar1,&local_28,0);
          uVar3 = Component.get_transform(this,0);
          puVar2 = (uint64 *)Vector3.get_one(local_18,0);
          local_20 = *(uint32 *)(puVar2 + 1);
          local_28 = *puVar2;
          uVar3 = ShortcutExtensions.DOScale(uVar3,&local_28,0x3e99999a,0);
          uVar3 = TweenSettingsExtensions.SetUpdate(uVar3,1,DAT_181dc1db0);
          uVar4 = new OnTooltipCB(this,DAT_181d8a670,0);
          TweenSettingsExtensions.OnComplete(uVar3,uVar4,DAT_181dc01d0);
        }
    }

    // Token : 0x6000D44
    // RVA   : 0xC80990   Offset: 0xC7FD90   Length: 0x14B
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
            FUN_1800d6620();
          }
          local_20 = *(uint32 *)(puVar2 + 1);
          local_28 = *puVar2;
          Transform.set_localScale(lVar1,&local_28,0);
          uVar3 = Component.get_transform(this,0);
          puVar2 = (uint64 *)Vector3.get_one(local_18,0);
          local_20 = *(uint32 *)(puVar2 + 1);
          local_28 = *puVar2;
          uVar3 = ShortcutExtensions.DOScale(uVar3,&local_28,0x3e99999a,0);
          uVar3 = TweenSettingsExtensions.SetUpdate(uVar3,1,DAT_181dc1db0);
          uVar4 = new OnTooltipCB(this,DAT_181d8a670,0);
          TweenSettingsExtensions.OnComplete(uVar3,uVar4,DAT_181dc01d0);
        }
    }

    // Token : 0x6000D45
    // RVA   : 0xC820F0   Offset: 0xC814F0   Length: 0x15F
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
            uVar2 = TweenSettingsExtensions.SetUpdate(uVar2,1,DAT_181dc1db0);
            uVar4 = new OnTooltipCB(this,DAT_181d8a5f0,0);
            TweenSettingsExtensions.OnComplete(uVar2,uVar4,DAT_181dc01d0);
            return;
          }
        }
    }

    // Token : 0x6000D46
    // RVA   : 0xC806D0   Offset: 0xC7FAD0   Length: 0x16E
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

    // Token : 0x6000D47
    // RVA   : 0x7EBBC0   Offset: 0x7EAFC0   Length: 0x5B
    public void OnDrag(Vector2 delta)
    {
        var pStatics = *(int64*)(DAT_181db0dc8 + 184);
        if (*pStatics != 0) {
          BigMapSpriteController.OnDrag(*pStatics,delta,0);
          return;
        }
    }

    // Token : 0x6000D48
    // RVA   : 0x7EBC20   Offset: 0x7EB020   Length: 0x57
    public void OnScroll(float delta)
    {
        var pStatics = *(int64*)(DAT_181db0dc8 + 184);
        if (*pStatics != 0) {
          BigMapSpriteController.OnScroll(*pStatics,delta,0);
          return;
        }
    }

    // Token : 0x6000D49
    // RVA   : 0xC7F390   Offset: 0xC7E790   Length: 0x927
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
                          lVar3 = FUN_18046bbe0(0);
                          if (lVar3 != null) {
                            uVar8 = lVar3.thisMonthContribution;
                            lVar3 = GameObject.GetComponent(target,DAT_181d71bd8);
                            if ((lVar3 != null) && (lVar3.summonLv != null)) {
                              uVar4 = Component.get_gameObject(lVar3.summonLv,0);
                              cVar1 = Object.op_Equality(uVar8,uVar4,0);
                              if (!cVar1) {
                                return;
                              }
                              lVar3 = FUN_18046c400(0);
                              if (lVar3 != null) {
                                if (lVar3.summonLv) {
                                  return;
                                }
                                lVar3 = FUN_18046bbe0(0);
                                lVar5 = GameObject.GetComponent(target,DAT_181d71bd8);
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
                          lVar3 = GameObject.GetComponent(target,DAT_181d71bd8);
                          if (((lVar3 != null) && (lVar3.summonLv != null)) &&
                             (lVar3 = *(int64 *)(lVar3.summonLv + 24)) != null) {
                            uVar8 = this.heroFollowTarget;
                            if (lVar3.heroID == null) {
                              lVar3 = GameObject.GetComponent(target,DAT_181d71bd8);
                              if ((lVar3 != null) && (lVar3.summonLv != null)) {
                                uVar4 = Component.get_gameObject(lVar3.summonLv,0);
                                cVar1 = Object.op_Equality(uVar8,uVar4,0);
                                if (!cVar1) {
                                  return;
                                }
                                if (this.heroFollowType != 1) {
                                  return;
                                }
                                lVar3 = FUN_18046c400(0);
                                if (lVar3 != null) {
                                  if (lVar3.summonLv) {
                                    return;
                                  }
                                  lVar3 = FUN_18046c7c0(0);
                                  if (lVar3 != null) {
                                    if (lVar3.heroAIDataArriveTargetRecord) {
                                      return;
                                    }
                                    lVar3 = GameObject.GetComponent(target,DAT_181d71bd8);
                                    if (((lVar3 != null) && (lVar3.summonLv != null)) &&
                                       (lVar3 = *(int64 *)(lVar3.summonLv + 24),
                                       lVar3 != null)) {
                                      if (lVar3.inPrison) {
                                        return;
                                      }
                                      lVar3 = GameObject.GetComponent(target,DAT_181d71bd8);
                                      if (((lVar3 != null) && (lVar3.summonLv != null)) &&
                                         (lVar3 = *(int64 *)(lVar3.summonLv + 24),
                                         lVar3 != null)) {
                                        cVar1 = HeroData.HaveArea(lVar3,0);
                                        if (cVar1) {
                                          return;
                                        }
                                        lVar3 = FUN_18046bbe0(0);
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
                                  lVar3 = GameObject.GetComponent(target,DAT_181d71bd8);
                                  if ((((lVar3 != null) && (lVar3.summonLv != null)) &&
                                      (lVar3 = *(int64 *)(lVar3.summonLv + 24),
                                      lVar3 != null)) && (lVar3 = lVar3.heroAIData) != null) {
                                    if (lVar3.isSummon != 1) {
                                      return;
                                    }
                                    uVar8 = this.heroData;
                                    lVar3 = *(int64 *)(*(int64 *)(DAT_181da9de0 + 184) + 40);
                                    lVar5 = GameObject.GetComponent(target,DAT_181d71bd8);
                                    if (((lVar5 != null) && (lVar5.summonLv != null)) &&
                                       (lVar5 = *(int64 *)(lVar5.summonLv + 24),
                                       lVar5 != null)) {
                                      uVar4 = Int32.ToString(lVar5 + 88,0);
                                      lVar5 = this.heroData;
                                      lVar6 = GameObject.GetComponent(target,DAT_181d71bd8);
                                      if (((lVar6 != null) && (*(int64 *)(lVar6 + 24) != 0)) &&
                                         (lVar5 != null)) {
                                        uVar2 = HeroData.GetFightTime
                                                          (lVar5,*(uint64 *)
                                                                  (*(int64 *)(lVar6 + 24) + 24),0);
                                        uVar7 = new HeroAIData(13,uVar4,uVar2,0);
                                        if (lVar3 != null) {
                                          AIController.SetAIStuff(lVar3,uVar8,uVar7,0,0);
                                          this.heroFollowTarget = 0;
                                          goto LAB_180c7f813;
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
        LAB_180c7f813:
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
              uVar8 = Component.GetComponent(this,DAT_181d93e60);
              cVar1 = Object.op_Inequality(uVar8,0,0);
              if (cVar1) {
                lVar3 = Component.GetComponent(this,DAT_181d93e60);
                if (lVar3 == null) throw; // [null/range check failed]
                lVar3.summonSourceHero = 1;
              }
              this.inWaterBuff = 1;
              return;
            }
          }
          else {
            lVar3 = GameObject.GetComponent(target,DAT_181dc7628);
            if (lVar3 != null) {
              this.inBigMapSpeEffectType = lVar3.summonLv;
              this.inBigMapSpeEffectBuff = 1;
              return;
            }
          }
        }
    }

    // Token : 0x6000D4A
    // RVA   : 0xC7D200   Offset: 0xC7C600   Length: 0x29
    public void ClearHeroFollowTarget()
    {
        this.heroFollowTarget = 0;
        this.heroChaseTime = 0;
    }

    // Token : 0x6000D4B
    // RVA   : 0xC82450   Offset: 0xC81850   Length: 0x1AF
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
        if (fVar3 < *(float *)(*(int64 *)(DAT_181d73d40 + 184) + 300)) {
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

    // Token : 0x6000D4C
    // RVA   : 0xC81530   Offset: 0xC80930   Length: 0x4AF
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
              if ((((lVar2 != null) && (lVar2 = FUN_180da9a20(lVar2,0)) != null) &&
                  (lVar2 = Component.GetComponent(lVar2,DAT_181d93560)) != null) &&
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
                      lVar2 = GameObject.GetComponent(target,DAT_181d71bd8);
                      if (((lVar2 != null) && (lVar2.summonLv != null)) &&
                         (lVar2 = *(int64 *)(lVar2.summonLv + 24)) != null) {
                        if (cVar1 == lVar2.isRandomEnemy) {
                          if (this.heroData == null) throw; // [null/range check failed]
                          if (this.heroData.isRandomEnemy) {
                            return;
                          }
                          lVar2 = GameObject.GetComponent(target,DAT_181d71bd8);
                          if (((lVar2 == null) || (lVar2.summonLv == null)) ||
                             (lVar2 = *(int64 *)(lVar2.summonLv + 24)) == null)
                          throw; // [null/range check failed]
                          if (lVar2.isRandomEnemy) {
                            return;
                          }
                          lVar2 = GameObject.GetComponent(target,DAT_181d71bd8);
                          if ((lVar2 == null) || (lVar2.summonLv == null)) throw; // [null/range check failed]
                          cVar1 = BigmapNpcController.TargetHeroIsEnemy
                                            (this,*(uint64 *)(lVar2.summonLv + 24),0
                                            );
                          if (!cVar1) {
                            return;
                          }
                        }
                        lVar2 = GameObject.GetComponent(target,DAT_181d71bd8);
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
                          lVar2 = GameObject.GetComponent(target,DAT_181d71bd8);
                          if (lVar2 != null) {
                            cVar1 = BigmapNpcController.HeroCanFollow
                                              (this,lVar2.summonLv,iVar4,0x3f800000,0);
                            if (!cVar1) {
                              return;
                            }
                            if ((iVar4 != 2) && (0.0 < this.heroStopChaseTime)) {
                              return;
                            }
                            lVar2 = GameObject.GetComponent(target,DAT_181d71bd8);
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

    // Token : 0x6000D4D
    // RVA   : 0xC82770   Offset: 0xC81B70   Length: 0x94
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d91658);
        FUN_18132faf0(uVar1,DAT_181d7fca0);
        this.followers = uVar1;
        this.areaSafeRangeRefreshTime = 0x3e4ccccd;
        this.inBigMapSpeEffectType = 0xffffffff;
        this.missionState = 0xffffffff;
        FUN_18044ef50(this,0);
    }

    // Token : 0x6000D4E
    // RVA   : 0xC82670   Offset: 0xC81A70   Length: 0xF2
    private static void /*cctor*/()
    {
        long lVar2;
        lVar2 = il2cpp_internal(DAT_181d97750);
        FUN_18132faf0(lVar2,DAT_181da3bd8);
        if (lVar2 != null) {
          FUN_18181e0a0(lVar2,"",DAT_181da3d58);
          FUN_18181e0a0(lVar2,"追击",DAT_181da3d58);
          FUN_18181e0a0(lVar2,"逃离",DAT_181da3d58);
          plVar1 = *(int64 **)(DAT_181db0e48 + 184);
          *plVar1 = lVar2;
          il2cpp_internal(plVar1,lVar2);
          return;
        }
    }

    // Token : 0x6000D4F
    // RVA   : 0xC82660   Offset: 0xC81A60   Length: 0x8
    private void <StartSelfShow>b__73_0()
    {
        void FUN_180c82660(int64 this)
        {
        this.selfShowing = 0;
    }

    // Token : 0x6000D50
    // RVA   : 0xC82600   Offset: 0xC81A00   Length: 0x5F
    private void <StartSelfDestroy>b__75_0()
    {
        ulong uVar1;
        uVar1 = Component.get_gameObject(this,0);
        Object.Destroy(uVar1,0);
    }

}
