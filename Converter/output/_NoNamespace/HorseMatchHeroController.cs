// ============================================================
// Type  : HorseMatchHeroController
// Token : 0x20002E8
// ============================================================

public class HorseMatchHeroController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x40017F8
    public HeroData hero;

    // Token: 0x40017F9
    public SkeletonAnimation skeletonAnimation;

    // Token: 0x40017FA
    public bool finished;

    // Token: 0x40017FB
    public SpriteRenderer circleSprite;

    // Token: 0x40017FC
    public bool startMoving;

    // Token: 0x40017FD
    public float AISprintTimeStart;

    // Token: 0x40017FE
    public HorseMatchRoadType nowRoad;

    // Token: 0x40017FF
    public HorseMatchRoadType nowRoadBuffer;

    // Token: 0x4001800
    public float nowRoadRefreshTime;

    // Token: 0x4001801
    private GameObject newObj;

    // Token: 0x4001802
    private bool inited;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60018AD
    // RVA   : 0x8A99F0   Offset: 0x8A87F0   Length: 0x192
    private void Start()
    {
        long lVar1;
        ulong uVar2;
        long lVar3;
        uint uVar4;
        uVar4 = Random.Range(0,0x40800000,0);
        this.AISprintTimeStart = uVar4;
        if (this.skeletonAnimation != null) {
          lVar1 = SkeletonAnimation.get_AnimationState(this.skeletonAnimation,0);
          if ((this.hero != null) &&
             (uVar2 = HeroData.GetSkeletonHorseIdleAnim(this.hero,0), lVar1 != null)) {
            AnimationState.SetAnimation(lVar1,0,uVar2,1,0);
            if (this.inited) {
              return;
            }
            this.inited = 1;
            lVar1 = Component.get_gameObject(this,0);
            if ((lVar1 != null) && (lVar1 = GameObject.AddComponent(lVar1,DAT_181e51340)) != null) {
              FootStepController.Init(lVar1,this.skeletonAnimation,0);
              if (this.hero != null) {
                if (this.hero.heroID == null) {
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
        }
    }

    // Token : 0x60018AE
    // RVA   : 0x8A9430   Offset: 0x8A8230   Length: 0x12E
    private void Init()
    {
        long lVar1;
        long lVar2;
        if (!this.inited) {
          this.inited = 1;
          lVar1 = Component.get_gameObject(this,0);
          if ((lVar1 != null) && (lVar1 = GameObject.AddComponent(lVar1,DAT_181e51340)) != null) {
            FootStepController.Init(lVar1,this.skeletonAnimation,0);
            if (this.hero != null) {
              if (this.hero.heroID == null) {
                return;
              }
              lVar1 = Component.GetComponent(this,DAT_181e771b8);
              lVar2 = il2cpp_internal(DAT_181e76ea8);
              FUN_1810f3480(lVar2,DAT_181e83230);
              if (lVar2 != null) {
                FUN_18175dba0(lVar2,0,DAT_181e83330);
                FUN_18175dba0(lVar2,0,DAT_181e83330);
                if (lVar1 != null) {
                  *(int64 *)(lVar1 + 32) = lVar2;
                  return;
                }
              }
            }
          }
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
    }

    // Token : 0x60018AF
    // RVA   : 0x8A9360   Offset: 0x8A8160   Length: 0xC4
    public float GetFinalTravelSpeed()
    {
        long lVar1;
        float fVar2;
        float fVar3;
        float fVar4;
        float fVar5;
        if (this.hero != null) {
          fVar2 = (float)HeroData.GetTravelSpeed(this.hero,0);
          lVar1 = this.hero;
          if (lVar1 != null) {
            if ((lVar1.horse != null) && (this.nowRoad == 1)) {
              fVar2 = (float)HeroData.GetTravelSpeed(lVar1,1,1,0);
              lVar1 = this.hero;
              if (lVar1 == null) throw; // [null/range check failed]
            }
            fVar3 = (float)HeroData.GetWeighChangeTravelSpeed(lVar1,0);
            if (this.hero != null) {
              fVar4 = (float)HeroData.GetWeatherChangeTravelSpeed(this.hero,0);
              if (this.hero != null) {
                fVar5 = (float)HeroData.GetTerrainChangeTravelSpeed(this.hero,0);
                return fVar5 * fVar4 * fVar3 * fVar2;
              }
            }
          }
        }
    }

    // Token : 0x60018B0
    // RVA   : 0x8A9B90   Offset: 0x8A8990   Length: 0x62D
    private void Update()
    {
        bool cVar1;
        long lVar2;
        ulong uVar5;
        ulong uVar6;
        long lVar7;
        float fVar9;
        float fVar10;
        float fVar11;
        ulong local_88;
        float local_80;
        byte[] local_78 = new byte[8];
        float local_70;
        byte[] local_68 = new byte[96];
        if (!this.startMoving) {
          return;
        }
        lVar2 = Component.get_transform(this,0);
        if (lVar2 == null) throw; // [null/range check failed]
        pfVar3 = (float *)Transform.get_localPosition(local_78,lVar2,0);
        if (8.8 < *pfVar3) {
          this.startMoving = 0;
          if (this.skeletonAnimation != null) {
            lVar2 = SkeletonAnimation.get_AnimationState(this.skeletonAnimation,0);
            if ((this.hero != null) &&
               (uVar6 = HeroData.GetSkeletonHorseIdleAnim(this.hero,0), lVar2 != null))
            {
              AnimationState.SetAnimation(lVar2,0,uVar6,1,0);
              if (this.skeletonAnimation != null) {
                *(uint32 *)(this.skeletonAnimation + 300) = 0x3f800000;
                return;
              }
            }
          }
          throw; // [null/range check failed]
        }
        fVar9 = (float)HorseMatchHeroController.GetFinalTravelSpeed(this,0);
        lVar2 = Component.get_transform(this,0);
        if (lVar2 == null) throw; // [null/range check failed]
        puVar4 = (uint64 *)Transform.get_localPosition(local_78,lVar2,0);
        local_80 = *(float *)(puVar4 + 1);
        uVar6 = *puVar4;
        puVar4 = (uint64 *)Vector3.get_right(local_68,0);
        fVar11 = *(float *)(puVar4 + 1);
        uVar5 = *puVar4;
        local_70 = fVar11;
        fVar10 = (float)Time.get_deltaTime(0);
        local_80 = fVar11 * 0.5 * fVar10 * fVar9 + local_80;
        local_88 = CONCAT44((float)((uint64)uVar5 >> 32) * 0.5 * fVar10 * fVar9 +
                            (float)((uint64)uVar6 >> 32),
                            (float)uVar5 * 0.5 * fVar10 * fVar9 + (float)uVar6);
        local_70 = local_80;
        Transform.set_localPosition(lVar2,&local_88,0);
        if (this.skeletonAnimation == null) throw; // [null/range check failed]
        *(float *)(this.skeletonAnimation + 300) = fVar9;
        if ((this.skeletonAnimation == null) ||
           (lVar2 = SkeletonAnimation.get_AnimationState(this.skeletonAnimation,0)) == null)
        throw; // [null/range check failed]
        lVar2 = AnimationState.GetCurrent(lVar2,0,0);
        if (lVar2 == null) {
        LAB_1808a9e03:
          if (this.skeletonAnimation == null) throw; // [null/range check failed]
          lVar2 = SkeletonAnimation.get_AnimationState(this.skeletonAnimation,0);
          if ((this.hero == null) ||
             (uVar6 = HeroData.GetSkeletonHorseRunAnim(this.hero,0), lVar2 == null))
          throw; // [null/range check failed]
          AnimationState.SetAnimation(lVar2,0,uVar6,1,0);
        }
        else {
          if ((((this.skeletonAnimation == null) ||
               (lVar2 = SkeletonAnimation.get_AnimationState(this.skeletonAnimation,0), lVar2 == null
               )) || (lVar2 = AnimationState.GetCurrent(lVar2,0,0)) == null) ||
             (*(int64 *)(lVar2 + 16) == 0)) throw; // [null/range check failed]
          uVar6 = *(uint64 *)(*(int64 *)(lVar2 + 16) + 16);
          if (this.hero == null) throw; // [null/range check failed]
          uVar5 = HeroData.GetSkeletonHorseRunAnim(this.hero,0);
          cVar1 = String.op_Inequality(uVar6,uVar5,0);
          if (cVar1) goto LAB_1808a9e03;
        }
        if (!this.finished) {
          lVar2 = this.hero;
          fVar9 = (float)Time.get_deltaTime(0);
          if (lVar2 == null) throw; // [null/range check failed]
          HeroData.ManageHeroHorseMove(lVar2,fVar9 * 4.0,0,0);
          fVar9 = this.AISprintTimeStart;
          fVar11 = (float)Time.get_deltaTime(0);
          fVar9 = fVar9 - fVar11;
          this.AISprintTimeStart = fVar9;
          if (fVar9 <= 0.0) {
            lVar2 = this.hero;
            if (lVar2 == null) throw; // [null/range check failed]
            if (*(int *)(lVar2 + 88) != 0) {
              if ((*(int64 *)(lVar2 + 0x208) == 0) ||
                 (lVar2 = *(int64 *)(*(int64 *)(lVar2 + 0x208) + 136)) == null)
              throw; // [null/range check failed]
              fVar9 = *(float *)(lVar2 + 56);
              fVar11 = (float)HorseData.MaxPower(lVar2,0);
              if (0.5 <= fVar9 / fVar11) {
                if (((this.hero == null) || (lVar2 = *(int64 *)(this.hero + 0x208)) == null) ||
                   (lVar2 = *(int64 *)(lVar2 + 136)) == null) throw; // [null/range check failed]
                if (((*(float *)(lVar2 + 64) <= 0.0) && (*(float *)(lVar2 + 68) <= 0.0)) &&
                   (this.nowRoad == null)) {
                  HorseData.StartSprint(lVar2,0);
                  lVar2 = FUN_1802106e0(0);
                  lVar7 = Component.get_transform(this,0);
                  if ((lVar7 == null) ||
                     (puVar4 = (uint64 *)Transform.get_position(local_68,lVar7,0), lVar2 == null))
                  throw; // [null/range check failed]
                  local_88 = *puVar4;
                  local_80 = *(float *)(puVar4 + 1);
                  GameController.ShowTextAtPos(lVar2,"冲刺",&local_88,0);
                }
              }
            }
          }
        }
        lVar2 = Component.get_transform(this,0);
        if (lVar2 != null) {
          pfVar3 = (float *)Transform.get_localPosition(local_68,lVar2,0);
          fVar9 = *pfVar3;
          lVar2 = FUN_180210860(0);
          if (((lVar2 != null) && (*(int64 *)(lVar2 + 136) != 0)) &&
             (lVar2 = GameObject.get_transform(*(int64 *)(lVar2 + 136),0)) != null) {
            pfVar3 = (float *)Transform.get_localPosition(local_68,lVar2,0);
            if ((*pfVar3 <= fVar9) && (!this.finished)) {
              lVar2 = FUN_180210860(0);
              uVar6 = Component.get_gameObject(this,0);
              if (lVar2 == null) throw; // [null/range check failed]
              HorseMatchController.FinishMatch(lVar2,uVar6,0);
            }
            if ((this.nowRoadBuffer != null) || (this.nowRoad != null)) {
              fVar9 = this.nowRoadRefreshTime;
              fVar11 = (float)Time.get_deltaTime(0);
              fVar9 = fVar9 - fVar11;
              this.nowRoadRefreshTime = fVar9;
              if (fVar9 <= 0.0) {
                this.nowRoadRefreshTime = 0x3dcccccd;
                if (this.nowRoadBuffer == null) {
                  this.nowRoad = 0;
                  if (this.hero != null) {
                    *(uint8 *)(this.hero + 0x3d4) = 0;
                    lVar2 = Component.get_gameObject(this,0);
                    if ((lVar2 != null) &&
                       (lVar2 = GameObject.GetComponent(lVar2,DAT_181e54750)) != null) {
                      *(uint8 *)(lVar2 + 40) = 0;
                      return;
                    }
                  }
                  throw; // [null/range check failed]
                }
                this.nowRoadBuffer = 0;
              }
            }
            return;
          }
        }
    }

    // Token : 0x60018B1
    // RVA   : 0x8A9560   Offset: 0x8A8360   Length: 0x483
    public void InteractRangeObjStay(GameObject target)
    {
        uint uVar1;
        bool cVar2;
        int iVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        float fVar11;
        ulong local_38;
        uint local_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        if (target == null) {
        LAB_1808a99de:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        cVar2 = GameObject.CompareTag(target,"HorseMatchSpeObj",0);
        if (!cVar2) {
          return;
        }
        uVar4 = Object.get_name(target,0);
        iVar3 = Int32.Parse(uVar4,0);
        if (iVar3 == 0) {
          if (this.hero != null) {
            if ((this.hero.heroID == null) && (this.nowRoad != 1))
            {
              plVar9 = (int64 *)Resources.Load("Sound/SoundEffect/SpeEffect/加速旋转",0);
              plVar10 = (int64 *)0;
              if ((plVar9 != (int64 *)0) && (*plVar9 == DAT_181e8f4a0)) {
                plVar10 = plVar9;
              }
              NGUITools.PlaySound(plVar10,0);
            }
            this.nowRoad = 1;
            this.nowRoadBuffer = 1;
            return;
          }
          goto LAB_1808a99de;
        }
        if (iVar3 == 1) {
          this.nowRoad = 2;
          this.nowRoadBuffer = 2;
          if (this.hero != null) {
            this.hero.inWater = 1;
            lVar5 = Component.get_gameObject(this,0);
            if ((lVar5 != null) && (lVar5 = GameObject.GetComponent(lVar5,DAT_181e54750)) != null) {
              *(uint8 *)(lVar5 + 40) = 1;
              return;
            }
          }
          goto LAB_1808a99de;
        }
        if (iVar3 == 2) {
          if (this.hero == null) goto LAB_1808a99de;
          lVar5 = this.hero.horse;
          if (lVar5 == null) goto LAB_1808a98d4;
          lVar5 = *(int64 *)(lVar5 + 136);
          if (lVar5 == null) goto LAB_1808a99de;
          fVar11 = (float)HorseData.MaxPower(lVar5,0);
          HorseData.ChangeNowPower(lVar5,fVar11 * 0.3,0);
          if (this.hero == null) goto LAB_1808a99de;
          if (this.hero.heroID != null) goto LAB_1808a98d4;
          lVar5 = FUN_1802106e0(0);
          lVar6 = Component.get_transform(this,0);
          if (lVar6 == null) goto LAB_1808a99de;
          puVar7 = (uint64 *)Transform.get_position(&local_38,lVar6,0);
          uVar4 = *puVar7;
          uVar1 = *(uint32 *)(puVar7 + 1);
          puVar8 = (uint32 *)Color.get_green(&local_28,0);
          if (lVar5 == null) goto LAB_1808a99de;
          local_28 = *puVar8;
          uStack_24 = puVar8[1];
          uStack_20 = puVar8[2];
          uStack_1c = puVar8[3];
          local_38 = uVar4;
          local_30 = uVar1;
          GameController.ShowTextAtPos(lVar5,"耐力+30%",&local_38,20,&local_28,0);
          uVar4 = "Sound/SoundEffect/Eat";
        }
        else {
          if (iVar3 != 3) {
            return;
          }
          if (this.hero == null) goto LAB_1808a99de;
          lVar5 = this.hero.horse;
          if (lVar5 == null) goto LAB_1808a98d4;
          lVar5 = *(int64 *)(lVar5 + 136);
          if (lVar5 == null) goto LAB_1808a99de;
          fVar11 = (float)HorseData.MaxPower(lVar5,0);
          HorseData.ChangeNowPower(lVar5,fVar11 * -0.15,0);
          if (this.hero == null) goto LAB_1808a99de;
          if (this.hero.heroID != null) goto LAB_1808a98d4;
          lVar5 = FUN_1802106e0(0);
          lVar6 = Component.get_transform(this,0);
          if (lVar6 == null) goto LAB_1808a99de;
          puVar7 = (uint64 *)Transform.get_position(&local_38,lVar6,0);
          uVar4 = *puVar7;
          uVar1 = *(uint32 *)(puVar7 + 1);
          puVar8 = (uint32 *)Color.get_red(&local_28,0);
          if (lVar5 == null) goto LAB_1808a99de;
          local_28 = *puVar8;
          uStack_24 = puVar8[1];
          uStack_20 = puVar8[2];
          uStack_1c = puVar8[3];
          local_38 = uVar4;
          local_30 = uVar1;
          GameController.ShowTextAtPos(lVar5,"耐力-15%",&local_38,20,&local_28,0);
          uVar4 = "Sound/SoundEffect/AtkHit0";
        }
        plVar9 = (int64 *)Resources.Load(uVar4,0);
        plVar10 = (int64 *)0;
        if ((plVar9 != (int64 *)0) && (*plVar9 == DAT_181e8f4a0)) {
          plVar10 = plVar9;
        }
        NGUITools.PlaySound(plVar10,0);
        LAB_1808a98d4:
        Object.Destroy(target,0);
    }

    // Token : 0x60018B2
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
