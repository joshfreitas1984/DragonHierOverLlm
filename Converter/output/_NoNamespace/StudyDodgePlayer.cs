// ============================================================
// Type  : StudyDodgePlayer
// Token : 0x2000375
// ============================================================

public class StudyDodgePlayer
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B80
    public GameObject playerGrid;

    // Token: 0x4001B81
    public SkeletonAnimation playerSkeleton;

    // Token: 0x4001B82
    public GameObject hipPos;

    // Token: 0x4001B83
    public float shieldTime;

    // Token: 0x4001B84
    public GameObject shieldSpe;

    // Token: 0x4001B85
    public bool moving;

    // Token: 0x4001B86
    public GameObject moveTarget;

    // Token: 0x4001B87
    private GameObject newObj;

    // Token: 0x4001B88
    private static StudyDodgePlayer _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60021AD
    // RVA   : 0xB88D80   Offset: 0xB87580   Length: 0x36
    public static StudyDodgePlayer get_Instance()
    {
        return **(uint64 **)(DAT_181d82df0 + 184);
    }

    // Token : 0x60021AE
    // RVA   : 0xB869E0   Offset: 0xB851E0   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181d82df0 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60021AF
    // RVA   : 0xB888B0   Offset: 0xB870B0   Length: 0x52
    private void Start()
    {
        long lVar1;
        lVar1 = Component.GetComponent(this,DAT_181d6b640);
        if (lVar1 != null) {
          FootStepController.Init(lVar1,this.playerSkeleton,0);
          return;
        }
    }

    // Token : 0x60021B0
    // RVA   : 0xB88910   Offset: 0xB87110   Length: 0x46B
    private void Update()
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        int iVar4;
        int iVar5;
        float fVar6;
        float fVar7;
        lVar3 = *(int64 *)(*(int64 *)(DAT_181d82e70 + 184) + 8);
        if (lVar3 == null) goto LAB_180b88d76;
        if (*(char *)(lVar3 + 25) != false) {
          return;
        }
        fVar7 = this.shieldTime;
        if (0.0 < fVar7) {
          fVar6 = (float)Time.get_deltaTime(0);
          fVar7 = fVar7 - fVar6;
          this.shieldTime = fVar7;
          if (fVar7 <= 0.0) {
            StudyDodgePlayer.SetShieldTime(this,0,0);
          }
        }
        if (this.moving) {
          return;
        }
        uVar1 = this.playerGrid;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (!cVar2) {
          return;
        }
        cVar2 = GlobalData.GetKeyDown(119);
        if (cVar2) {
          if ((this.playerGrid == null) ||
             (lVar3 = GameObject.GetComponent(this.playerGrid,DAT_181da1bb0)) == null)
          goto LAB_180b88d76;
          iVar4 = *(int *)(lVar3 + 28);
          lVar3 = FUN_180b849e0(0);
          if (lVar3 == null) goto LAB_180b88d76;
          if (iVar4 < *(int *)(lVar3 + 68) + -1) {
            if ((this.playerGrid == null) ||
               (lVar3 = GameObject.GetComponent(this.playerGrid,DAT_181da1bb0)) == null
               ) goto LAB_180b88d76;
            iVar4 = *(int *)(lVar3 + 24);
            if ((this.playerGrid == null) ||
               (lVar3 = GameObject.GetComponent(this.playerGrid,DAT_181da1bb0)) == null
               ) goto LAB_180b88d76;
            iVar5 = *(int *)(lVar3 + 28) + 1;
            goto LAB_180b88c9d;
          }
        }
        cVar2 = GlobalData.GetKeyDown(115);
        if (cVar2) {
          if ((this.playerGrid == null) ||
             (lVar3 = GameObject.GetComponent(this.playerGrid,DAT_181da1bb0)) == null)
          goto LAB_180b88d76;
          if (0 < *(int *)(lVar3 + 28)) {
            if ((this.playerGrid == null) ||
               (lVar3 = GameObject.GetComponent(this.playerGrid,DAT_181da1bb0)) == null
               ) goto LAB_180b88d76;
            iVar4 = *(int *)(lVar3 + 24);
            if ((this.playerGrid == null) ||
               (lVar3 = GameObject.GetComponent(this.playerGrid,DAT_181da1bb0)) == null
               ) goto LAB_180b88d76;
            iVar5 = *(int *)(lVar3 + 28) + -1;
            goto LAB_180b88c9d;
          }
        }
        cVar2 = GlobalData.GetKeyDown(97);
        if (!cVar2) {
        LAB_180b88cb3:
          cVar2 = GlobalData.GetKeyDown(100);
          if (!cVar2) {
            return;
          }
          if ((this.playerGrid == null) ||
             (lVar3 = GameObject.GetComponent(this.playerGrid,DAT_181da1bb0)) == null)
          {
        LAB_180b88d76:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          iVar4 = *(int *)(lVar3 + 24);
          lVar3 = FUN_180b849e0(0);
          if (lVar3 == null) goto LAB_180b88d76;
          if (*(int *)(lVar3 + 64) + -1 <= iVar4) {
            return;
          }
          if ((this.playerGrid == null) ||
             (lVar3 = GameObject.GetComponent(this.playerGrid,DAT_181da1bb0)) == null)
          goto LAB_180b88d76;
          iVar4 = *(int *)(lVar3 + 24);
          if ((this.playerGrid == null) ||
             (lVar3 = GameObject.GetComponent(this.playerGrid,DAT_181da1bb0)) == null)
          goto LAB_180b88d76;
          iVar4 = iVar4 + 1;
        }
        else {
          if ((this.playerGrid == null) ||
             (lVar3 = GameObject.GetComponent(this.playerGrid,DAT_181da1bb0)) == null)
          goto LAB_180b88d76;
          if (*(int *)(lVar3 + 24) < 1) goto LAB_180b88cb3;
          if ((this.playerGrid == null) ||
             (lVar3 = GameObject.GetComponent(this.playerGrid,DAT_181da1bb0)) == null)
          goto LAB_180b88d76;
          iVar4 = *(int *)(lVar3 + 24);
          if ((this.playerGrid == null) ||
             (lVar3 = GameObject.GetComponent(this.playerGrid,DAT_181da1bb0)) == null)
          goto LAB_180b88d76;
          iVar4 = iVar4 + -1;
        }
        iVar5 = *(int *)(lVar3 + 28);
        LAB_180b88c9d:
        StudyDodgePlayer.PlayerEnterGrid(this,iVar4,iVar5,0);
    }

    // Token : 0x60021B1
    // RVA   : 0xB87DC0   Offset: 0xB865C0   Length: 0x764
    public void PlayerEnterGrid(int column, int row)
    {
        var pStatics_2f70 = *(int64*)(DAT_181d82f70 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        uint uVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar7;
        long lVar8;
        float fVar11;
        ulong local_48;
        uint local_40;
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        uVar4 = this.playerGrid;
        cVar2 = Object.op_Inequality(uVar4,0,0);
        if (cVar2) {
          if (this.playerGrid == null) throw; // [null/range check failed]
          lVar3 = GameObject.GetComponent(this.playerGrid,DAT_181da1bb0);
          if (lVar3 == null) throw; // [null/range check failed]
          if (*(int *)(lVar3 + 24) < (int)column) {
            if (this.playerSkeleton == null) throw; // [null/range check failed]
            lVar3 = Component.get_transform(this.playerSkeleton,0);
            puVar5 = (uint32 *)Quaternion.get_identity(&local_38,0);
            if (lVar3 == null) throw; // [null/range check failed]
            local_38 = *puVar5;
            uStack_34 = puVar5[1];
            uStack_30 = puVar5[2];
            uStack_2c = puVar5[3];
          }
          else {
            if (this.playerGrid == null) throw; // [null/range check failed]
            lVar3 = GameObject.GetComponent(this.playerGrid,DAT_181da1bb0);
            if (lVar3 == null) throw; // [null/range check failed]
            if (*(int *)(lVar3 + 24) <= (int)column) goto LAB_180b87fc9;
            if (this.playerSkeleton == null) throw; // [null/range check failed]
            lVar3 = Component.get_transform(this.playerSkeleton,0);
            lVar8 = *(int64 *)(DAT_181d4ef00 + 184);
            if (lVar3 == null) throw; // [null/range check failed]
            local_38 = *(uint32 *)(lVar8 + 0x688);
            uStack_34 = *(uint32 *)(lVar8 + 0x68c);
            uStack_30 = *(uint32 *)(lVar8 + 0x690);
            uStack_2c = *(uint32 *)(lVar8 + 0x694);
          }
          Transform.set_localRotation(lVar3,&local_38,0);
        }
        LAB_180b87fc9:
        lVar3 = *(int64 *)(*(int64 *)(DAT_181d82e70 + 184) + 8);
        if ((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 144)) != null) {
          if (**(uint32 **)(lVar3 + 16) <= column) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          lVar8 = *(int64 *)(*(uint32 **)(lVar3 + 16) + 4);
          if ((uint32)lVar8 <= row) {
            uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
            FUN_1800d65f0(uVar4,0);
          }
          this.moveTarget =
               *(uint64 *)(lVar3 + 32 + ((int)column * lVar8 + (int64)(int)row) * 8);
          il2cpp_internal(this + 72);
          if (*pStatics_2f70 != 0) {
            if (*(int64 *)(*pStatics_2f70 + 40) == 0) {
              fVar11 = 0.0;
            }
            else {
              if ((*pStatics_2f70 == 0) ||
                 (lVar3 = *(int64 *)(*pStatics_2f70 + 40)) == null)
              throw; // [null/range check failed]
              fVar11 = (float)*(int *)(lVar3 + 20) * 0.1;
            }
            if ((*pStatics_df90 != 0) &&
               (lVar3 = *(int64 *)(*pStatics_df90 + 32)) != null) {
              lVar3 = WorldData.Player(lVar3,0);
              if ((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 0x150)) != null) {
                if (*(uint32 *)(lVar3 + 24) < 2) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                fVar11 = 0.75 / (*(float *)(*(int64 *)(lVar3 + 16) + 36) * 0.02 + fVar11 + 1.0);
                lVar3 = new WarpText_d__8(0,0);
                if (lVar3 != null) {
                  *(int64 *)(lVar3 + 40) = this;
                  *(float *)(lVar3 + 32) = fVar11 * 0.5;
                  FUN_180d837c0(this,lVar3,0);
                  uVar4 = Component.get_transform(this,0);
                  if (this.moveTarget != null) {
                    lVar3 = GameObject.get_transform(this.moveTarget,0);
                    if (lVar3 != null) {
                      puVar5 = (uint32 *)Transform.get_localPosition(&local_38,lVar3,0);
                      uVar1 = *puVar5;
                      if (this.moveTarget != null) {
                        lVar3 = GameObject.get_transform(this.moveTarget,0);
                        if (lVar3 != null) {
                          puVar6 = (uint64 *)Transform.get_localPosition(&local_38,lVar3,0);
                          uStack_30 = 0xbe4ccccd;
                          local_48 = CONCAT44((int)((uint64)*puVar6 >> 32),uVar1);
                          local_40 = 0xbe4ccccd;
                          uVar4 = ShortcutExtensions.DOLocalMove(uVar4,&local_48,fVar11,0,0);
                          uVar7 = new OnTooltipCB(this,DAT_181d8dc08,0);
                          TweenSettingsExtensions.OnComplete(uVar4,uVar7,DAT_181d96ee8);
                          if (this.playerSkeleton != null) {
                            lVar3 = SkeletonAnimation.get_AnimationState(this.playerSkeleton,0)
                            ;
                            if (lVar3 != null) {
                              lVar3 = AnimationState.SetAnimation(lVar3,0,"jump_small",0,0);
                              if ((this.playerSkeleton != null) &&
                                 (lVar8 = *(int64 *)(this.playerSkeleton + 24)) != null
                                 ) {
                                lVar8 = SkeletonDataAsset.GetSkeletonData(lVar8,1,0);
                                if (lVar8 != null) {
                                  lVar8 = SkeletonData.FindAnimation(lVar8,"jump_small",0);
                                  if ((lVar8 != null) && (lVar3 != null)) {
                                    *(float *)(lVar3 + 160) = *(float *)(lVar8 + 40) / fVar11;
                                    this.moving = 1;
                                    plVar9 = (int64 *)Resources.Load("Sound/SoundEffect/Bag",0);
                                    plVar10 = (int64 *)0;
                                    if ((plVar9 != (int64 *)0) && (*plVar9 == DAT_181d8a228)) {
                                      plVar10 = plVar9;
                                    }
                                    NGUITools.PlaySound(plVar10,0x3e800000,0);
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
        }
    }

    // Token : 0x60021B2
    // RVA   : 0xB87D40   Offset: 0xB86540   Length: 0x7E
    public IEnumerator PlayerChangeToMoveGrid(float delta)
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 40) = this;
          *(uint32 *)(lVar1 + 32) = delta;
          return lVar1;
        }
    }

    // Token : 0x60021B3
    // RVA   : 0xB88530   Offset: 0xB86D30   Length: 0x78
    public void PlayerFinishMove()
    {
        long lVar1;
        this.moveTarget = 0;
        if (this.playerSkeleton != null) {
          lVar1 = SkeletonAnimation.get_AnimationState(this.playerSkeleton,0);
          if (lVar1 != null) {
            AnimationState.SetAnimation(lVar1,0,"idle",1,0);
            this.moving = 0;
            return;
          }
        }
    }

    // Token : 0x60021B4
    // RVA   : 0xB86A30   Offset: 0xB85230   Length: 0xB47
    public void OnHit(GameObject hitObj)
    {
        var pStatics_2e70 = *(int64*)(DAT_181d82e70 + 184);
        var pStatics_6c68 = *(int64*)(DAT_181d86c68 + 184);
        var pStatics_c9b8 = *(int64*)(DAT_181d7c9b8 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        ulong uVar2;
        uint uVar3;
        bool cVar4;
        ulong uVar5;
        long lVar7;
        long lVar9;
        float fVar12;
        ulong local_78;
        float local_70;
        ulong local_68;
        float local_60;
        byte[] local_58 = new byte[16];
        byte[] local_48 = new byte[64];
        if (0.0 < this.shieldTime) {
          StudyDodgePlayer.SetShieldTime(this,0,0);
          plVar6 = (int64 *)Resources.Load("Sound/SoundEffect/Break",0);
          plVar10 = (int64 *)0;
          if ((plVar6 != (int64 *)0) && (plVar10 = (int64 *)0, *plVar6 == DAT_181d8a228)) {
            plVar10 = plVar6;
          }
          NGUITools.PlaySound(plVar10,0);
        }
        else {
          if (this.playerSkeleton == null) throw; // [null/range check failed]
          uVar5 = Component.get_gameObject(this.playerSkeleton,0);
          plVar6 = (int64 *)Resources.Load("SpeEffect/劈砍",0);
          if ((hitObj == null) || (lVar7 = GameObject.get_transform(hitObj,0)) == null)
          throw; // [null/range check failed]
          puVar8 = (uint64 *)Transform.get_localPosition(local_58,lVar7,0);
          uVar2 = *puVar8;
          uVar3 = *(uint32 *)(puVar8 + 1);
          puVar8 = (uint64 *)Vector3.get_one(local_48,0);
          local_68 = *puVar8;
          local_60 = *(float *)(puVar8 + 1);
          local_70 = local_60 * 0.5;
          local_78 = CONCAT44((float)((uint64)local_68 >> 32) * 0.5,(float)local_68 * 0.5);
          plVar10 = (int64 *)0;
          local_68 = local_78;
          local_60 = local_70;
          plVar11 = plVar10;
          if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181d4e110)) {
            plVar11 = plVar6;
          }
          local_78 = uVar2;
          local_70 = (float)uVar3;
          uVar5 = GlobalData.AddChild(uVar5,plVar11,&local_78,&local_68,0);
          this.newObj = uVar5;
          if (this.newObj == null) throw; // [null/range check failed]
          uVar5 = GameObject.GetComponent(this.newObj,DAT_181d9e558);
          cVar4 = Object.op_Inequality(uVar5,0,0);
          if (cVar4) {
            if ((this.newObj == null) ||
               (lVar7 = GameObject.GetComponent(this.newObj,DAT_181d9e558)) == null
               ) throw; // [null/range check failed]
            fVar12 = (float)AudioSource.get_volume(lVar7,0);
            AudioSource.set_volume
                      (lVar7,fVar12 * *(float *)(*(int64 *)(DAT_181d4e010 + 184) + 16),0);
          }
          cVar4 = GlobalData.IsCheckVersion(1,0);
          if (!cVar4) {
            if (this.playerSkeleton == null) throw; // [null/range check failed]
            uVar5 = Component.get_gameObject(this.playerSkeleton,0);
            plVar6 = (int64 *)Resources.Load("SpeEffect/BloodSplash",0);
            local_78 = 0x3f80000000000000;
            local_70 = -0.1;
            if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181d4e110)) {
              plVar10 = plVar6;
            }
            GlobalData.AddChild(uVar5,plVar10,&local_78,0);
          }
          if ((*pStatics_df90 == 0) ||
             (lVar7 = *(int64 *)(*pStatics_df90 + 32)) == null)
          throw; // [null/range check failed]
          lVar7 = WorldData.Player(lVar7,0);
          if ((((*pStatics_df90 == 0) ||
               (lVar9 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
              (lVar9 = WorldData.Player(lVar9,0)) == null) || (lVar7 == null)) throw; // [null/range check failed]
          HeroData.ChangeHp(lVar7,*(float *)(lVar9 + 0x17c) * -0.1,1,0,1,0,0);
          lVar7 = *(int64 *)(pStatics_2e70 + 8);
          if (lVar7 == null) throw; // [null/range check failed]
          piVar1 = (int *)(lVar7 + 84);
          *piVar1 = *piVar1 + 1;
          lVar7 = *(int64 *)(pStatics_2e70 + 8);
          if (lVar7 == null) throw; // [null/range check failed]
          StudyDodgeSkillController.ResetCombo(lVar7,0);
        }
        if (*pStatics_6c68 != 0) {
          TimeScaleController.SetSlowTime(*pStatics_6c68,0x3f000000,0x3e4ccccd,0);
          if (*pStatics_c9b8 != 0) {
            ShakeCam.StartShake(*pStatics_c9b8,2,0);
            if (((*pStatics_df90 != 0) &&
                (lVar7 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
               (lVar7 = WorldData.Player(lVar7,0)) != null) {
              lVar9 = this.playerSkeleton;
              if (*(float *)(lVar7 + 0x178) <= 0.0) {
                if ((lVar9 != null) && (lVar7 = SkeletonAnimation.get_AnimationState(lVar9,0)) != null)
                {
                  AnimationState.SetAnimation(lVar7,1,"die",0,0);
                  if ((*pStatics_df90 != 0) &&
                     (lVar7 = *(int64 *)(*pStatics_df90 + 32)) != null) {
                    lVar7 = WorldData.Player(lVar7,0);
                    if ((((*pStatics_df90 != 0) &&
                         (lVar9 = *(int64 *)(*pStatics_df90 + 32)) != null
                         ) && (lVar9 = WorldData.Player(lVar9,0)) != null) &&
                       (uVar5 = HeroData.GetHeroDieSound(lVar9,0), lVar7 != null)) {
                      HeroData.PlayHeroSound(lVar7,uVar5,0x3f000000,0xbf800000,0);
                      lVar7 = *(int64 *)(pStatics_2e70 + 8);
                      if (lVar7 != null) {
                        uVar5 = StudyDodgeSkillController.FinishStudyDodgeSkill(lVar7,0,0);
                        FUN_180d837c0(this,uVar5,0);
                        return;
                      }
                    }
                  }
                }
              }
              else if ((lVar9 != null) &&
                      (lVar7 = SkeletonAnimation.get_AnimationState(lVar9,0)) != null) {
                AnimationState.SetAnimation(lVar7,1,"hit",0,0);
                if ((this.playerSkeleton != null) &&
                   (lVar7 = SkeletonAnimation.get_AnimationState(this.playerSkeleton,0),
                   lVar7 != null)) {
                  AnimationState.AddEmptyAnimation(lVar7,1,0x3dcccccd,0,0);
                  if ((*pStatics_df90 != 0) &&
                     (lVar7 = *(int64 *)(*pStatics_df90 + 32)) != null) {
                    lVar7 = WorldData.Player(lVar7,0);
                    if ((((*pStatics_df90 != 0) &&
                         (lVar9 = *(int64 *)(*pStatics_df90 + 32)) != null
                         ) && (lVar9 = WorldData.Player(lVar9,0)) != null) &&
                       (uVar5 = HeroData.GetHeroHurtSound(lVar9,0), lVar7 != null)) {
                      HeroData.PlayHeroSound(lVar7,uVar5,0x3f000000,0xbf800000,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x60021B5
    // RVA   : 0xB885B0   Offset: 0xB86DB0   Length: 0x2F2
    public void SetShieldTime(float targetTime)
    {
        bool cVar2;
        long lVar4;
        ulong uVar6;
        float fVar8;
        ulong local_38;
        float local_30;
        ulong local_28;
        float local_20;
        uVar6 = this.shieldSpe;
        plVar1 = &this.shieldSpe;
        if (0.0 < targetTime) {
          this.shieldTime = targetTime;
          cVar2 = Object.op_Equality(uVar6,0,0);
          if (cVar2) {
            uVar6 = this.hipPos;
            plVar3 = (int64 *)Resources.Load("SpeEffect/光圈持续",0);
            if ((this.playerSkeleton != null) &&
               (lVar4 = Component.get_transform(this.playerSkeleton,0)) != null) {
              pfVar5 = (float *)Transform.get_localScale(&local_28,lVar4,0);
              fVar8 = *pfVar5;
              local_30 = fVar8 + fVar8;
              local_38 = CONCAT44(local_30,fVar8 * 1.2);
              local_20 = local_30;
              local_28 = local_38;
              local_30 = -0.001;
              local_38 = 0;
              plVar7 = (int64 *)0;
              if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d4e110)) {
                plVar7 = plVar3;
              }
              lVar4 = GlobalData.AddChild(uVar6,plVar7,&local_38,&local_28,0);
              this.shieldSpe = lVar4;
              il2cpp_internal(plVar1,lVar4);
              if (this.shieldSpe != null) {
                uVar6 = GameObject.GetComponent(this.shieldSpe,DAT_181d9e558);
                cVar2 = Object.op_Inequality(uVar6,0,0);
                if (!cVar2) {
                  return;
                }
                if ((this.shieldSpe != null) &&
                   (lVar4 = GameObject.GetComponent(this.shieldSpe,DAT_181d9e558)) != null) {
                  fVar8 = (float)AudioSource.get_volume(lVar4,0);
                  AudioSource.set_volume
                            (lVar4,fVar8 * *(float *)(*(int64 *)(DAT_181d4e010 + 184) + 16),0);
                  return;
                }
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
        }
        else {
          this.shieldTime = 0;
          cVar2 = Object.op_Inequality(uVar6,0,0);
          if (cVar2) {
            lVar4 = this.shieldSpe;
            Object.Destroy(lVar4,0);
          }
        }
    }

    // Token : 0x60021B6
    // RVA   : 0xB87580   Offset: 0xB85D80   Length: 0x7BE
    private void OnTriggerEnter2D(Collider2D other)
    {
        int iVar2;
        uint uVar3;
        bool cVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        long lVar11;
        ulong uVar13;
        float fVar15;
        ulong in_stack_ffffffffffffffb0;
        ulong local_38;
        uint local_30;
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        lVar5 = new c.DisplayClass9_0(0);
        if (lVar5 != null) {
          plVar1 = (int64 *)(lVar5 + 16);
          *plVar1 = other;
          il2cpp_internal(plVar1,other);
          if (*plVar1 != 0) {
            cVar4 = Component.CompareTag(*plVar1,"StudyAttackBullet",0);
            lVar6 = *plVar1;
            if (!cVar4) {
              if (lVar6 == null) throw; // [null/range check failed]
              cVar4 = Component.CompareTag(lVar6,"StudySkillStar",0);
              if (!cVar4) {
                return;
              }
              if ((*plVar1 == 0) || (lVar6 = Component.GetComponent(*plVar1,DAT_181d6d6c0)) == null)
              throw; // [null/range check failed]
              iVar2 = *(int *)(lVar6 + 24);
              if (iVar2 == 0) {
                lVar6 = FUN_180b849e0(0);
                if (lVar6 != null) {
                  StudyDodgeSkillController.ChangeCombo(lVar6,3);
                  lVar6 = FUN_18046c0a0(0);
                  if ((*plVar1 != 0) && (lVar11 = Component.get_transform(*plVar1,0)) != null) {
                    puVar8 = (uint64 *)Transform.get_position(&local_38,lVar11,0);
                    uVar7 = *puVar8;
                    uVar3 = *(uint32 *)(puVar8 + 1);
                    puVar9 = (uint32 *)Color.get_green(&local_28,0);
                    if (lVar6 != null) {
                      local_28 = *puVar9;
                      uStack_24 = puVar9[1];
                      uStack_20 = puVar9[2];
                      uStack_1c = puVar9[3];
                      local_38 = uVar7;
                      local_30 = uVar3;
                      GameController.ShowTextAtPos(lVar6,"连击+3",&local_38,20,&local_28,0);
                      plVar12 = (int64 *)Resources.Load("Sound/SoundEffect/Success",0);
                      plVar10 = (int64 *)0;
                      if ((plVar12 != (int64 *)0) && (*plVar12 == DAT_181d8a228)) {
                        plVar10 = plVar12;
                      }
                      NGUITools.PlaySound(plVar10,0);
                      if (*plVar1 != 0) {
                        uVar7 = Component.get_transform(*plVar1,0);
                        ShortcutExtensions.DOKill(uVar7,0,0);
                        if ((*plVar1 != 0) &&
                           (lVar6 = Component.GetComponent(*plVar1,DAT_181d6b240)) != null) {
                          Behaviour.set_enabled(lVar6,0,0);
                          if (*plVar1 != 0) {
                            uVar7 = Component.get_transform(*plVar1,0);
                            lVar6 = FUN_18046c660(0);
                            if (((lVar6 != null) && (*(int64 *)(lVar6 + 88) != 0)) &&
                               (lVar6 = Component.get_transform(*(int64 *)(lVar6 + 88),0),
                               lVar6 != null)) {
                              puVar8 = (uint64 *)Transform.get_position(&local_28,lVar6,0);
                              local_38 = *puVar8;
                              local_30 = *(uint32 *)(puVar8 + 1);
                              uVar7 = ShortcutExtensions.DOMove(uVar7,&local_38,0x3f000000,0,0);
                              uVar13 = new OnTooltipCB(lVar5,DAT_181d8b610,0);
                              TweenSettingsExtensions.OnComplete(uVar7,uVar13,DAT_181d96ee8);
                              return;
                            }
                          }
                        }
                      }
                    }
                  }
                }
                throw; // [null/range check failed]
              }
              if (iVar2 == 1) {
                lVar5 = FUN_18046c0a0(0);
                if ((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) throw; // [null/range check failed]
                lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0);
                lVar6 = FUN_18046c0a0(0);
                if ((lVar6 == null) ||
                   (((*(int64 *)(lVar6 + 32) == 0 ||
                     (lVar6 = WorldData.Player(*(int64 *)(lVar6 + 32),0)) == null) ||
                    (lVar5 == null)))) throw; // [null/range check failed]
                plVar12 = (int64 *)0;
                HeroData.ChangeHp(lVar5,*(float *)(lVar6 + 0x17c) * 0.1,1,1,1,
                                   in_stack_ffffffffffffffb0 & 0xffffffffffffff00,0);
                lVar5 = FUN_18046c0a0(0);
                if ((*plVar1 == 0) || (lVar6 = Component.get_transform(*plVar1,0)) == null)
                throw; // [null/range check failed]
                puVar8 = (uint64 *)Transform.get_position(&local_38,lVar6,0);
                uVar7 = *puVar8;
                uVar3 = *(uint32 *)(puVar8 + 1);
                puVar9 = (uint32 *)Color.get_green(&local_28,0);
                if (lVar5 == null) throw; // [null/range check failed]
                local_28 = *puVar9;
                uStack_24 = puVar9[1];
                uStack_20 = puVar9[2];
                uStack_1c = puVar9[3];
                local_38 = uVar7;
                local_30 = uVar3;
                GameController.ShowTextAtPos(lVar5,"生命+10%",&local_38,20,&local_28,0);
                plVar10 = (int64 *)Resources.Load("Sound/SoundEffect/Eat",0);
                plVar14 = plVar12;
                if ((plVar10 != (int64 *)0) && (*plVar10 == DAT_181d8a228)) {
                  plVar14 = plVar10;
                }
                NGUITools.PlaySound(plVar14,0);
                if (this.playerSkeleton == null) throw; // [null/range check failed]
                uVar7 = Component.get_gameObject(this.playerSkeleton,0);
                plVar10 = (int64 *)Resources.Load("SpeEffect/治疗",0);
                if ((plVar10 != (int64 *)0) && (*plVar10 == DAT_181d4e110)) {
                  plVar12 = plVar10;
                }
                uVar7 = GlobalData.AddChild(uVar7,plVar12,0);
                this.newObj = uVar7;
                if (this.newObj == null) throw; // [null/range check failed]
                uVar7 = GameObject.GetComponent(this.newObj,DAT_181d9e558);
                cVar4 = Object.op_Inequality(uVar7,0,0);
                if (cVar4) {
                  if ((this.newObj == null) ||
                     (lVar5 = GameObject.GetComponent(this.newObj,DAT_181d9e558),
                     lVar5 == null)) throw; // [null/range check failed]
                  fVar15 = (float)AudioSource.get_volume(lVar5,0);
                  AudioSource.set_volume
                            (lVar5,fVar15 * *(float *)(*(int64 *)(DAT_181d4e010 + 184) + 16),0);
                }
              }
              else {
                if (iVar2 != 2) {
                  return;
                }
                StudyDodgePlayer.SetShieldTime(this,0x40a00000,0);
              }
            }
            else {
              if (lVar6 == null) throw; // [null/range check failed]
              uVar7 = Component.get_gameObject(lVar6,0);
              StudyDodgePlayer.OnHit(this,uVar7,0);
            }
            if (*plVar1 != 0) {
              uVar7 = Component.get_gameObject(*plVar1,0);
              Object.Destroy(uVar7,0);
              return;
            }
          }
        }
    }

    // Token : 0x60021B7
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
