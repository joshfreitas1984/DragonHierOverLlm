// ============================================================
// Type  : StudyUniquePlayer
// Token : 0x200038B
// ============================================================

public class StudyUniquePlayer
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001C2F
    public SkeletonAnimation playerSkeleton;

    // Token: 0x4001C30
    public GameObject hipPos;

    // Token: 0x4001C31
    public float shieldTime;

    // Token: 0x4001C32
    public GameObject shieldSpe;

    // Token: 0x4001C33
    private GameObject newObj;

    // Token: 0x4001C34
    private static StudyUniquePlayer _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600222E
    // RVA   : 0xB97800   Offset: 0xB96000   Length: 0x36
    public static StudyUniquePlayer get_Instance()
    {
        return **(uint64 **)(DAT_181d82ff0 + 184);
    }

    // Token : 0x600222F
    // RVA   : 0xB961E0   Offset: 0xB949E0   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181d82ff0 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x6002230
    // RVA   : 0xB97760   Offset: 0xB95F60   Length: 0x90
    private void Update()
    {
        var pStatics = *(int64*)(DAT_181d83070 + 184);
        float fVar1;
        float fVar2;
        if (*pStatics == 0) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        if ((*(char *)(*pStatics + 25) == false) &&
           (fVar2 = this.shieldTime, 0.0 < fVar2)) {
          fVar1 = (float)Time.get_deltaTime(0);
          fVar2 = fVar2 - fVar1;
          this.shieldTime = fVar2;
          if (fVar2 <= 0.0) {
            StudyUniquePlayer.SetShieldTime(this,0,0);
          }
        }
    }

    // Token : 0x6002231
    // RVA   : 0xB97460   Offset: 0xB95C60   Length: 0x2F2
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

    // Token : 0x6002232
    // RVA   : 0xB96230   Offset: 0xB94A30   Length: 0xE36
    private void OnTriggerEnter2D(Collider2D other)
    {
        var pStatics_3070 = *(int64*)(DAT_181d83070 + 184);
        var pStatics_6c68 = *(int64*)(DAT_181d86c68 + 184);
        var pStatics_c9b8 = *(int64*)(DAT_181d7c9b8 + 184);
        var pStatics_e010 = *(int64*)(DAT_181d4e010 + 184);
        float fVar3;
        float fVar4;
        int iVar5;
        uint uVar6;
        bool cVar7;
        long lVar8;
        long lVar9;
        ulong uVar10;
        ulong uVar15;
        float fVar17;
        float[] local_res10 = new float[2];
        ulong in_stack_ffffffffffffff40;
        ulong local_a8;
        float local_a0;
        ulong local_98;
        float local_90;
        byte[] local_88 = new byte[16];
        uint local_78;
        uint uStack_74;
        uint uStack_70;
        uint32 uStack_6c;
        fVar17 = 0.0;
        local_res10[0] = 0.0;
        lVar8 = new c.DisplayClass9_0(0);
        if (lVar8 != null) {
          plVar1 = (int64 *)(lVar8 + 16);
          *plVar1 = other;
          il2cpp_internal(plVar1,other);
          if (*plVar1 != 0) {
            cVar7 = Component.CompareTag(*plVar1,"StudyAttackBullet",0);
            if (!cVar7) {
              if (*plVar1 != 0) {
                cVar7 = Component.CompareTag(*plVar1,"StudySkillStar",0);
                if (!cVar7) {
                  return;
                }
                if ((*plVar1 != 0) && (lVar9 = Component.GetComponent(*plVar1,DAT_181d6d6c0)) != null
                   ) {
                  iVar5 = *(int *)(lVar9 + 24);
                  if (iVar5 == 0) {
                    lVar9 = FUN_180b84a40(0);
                    if (lVar9 != null) {
                      StudyUniqueSkillController.ChangeCombo(lVar9,3);
                      lVar9 = FUN_18046c0a0(0);
                      puVar11 = (uint64 *)Vector3.get_zero(local_88,0);
                      uVar10 = *puVar11;
                      uVar6 = *(uint32 *)(puVar11 + 1);
                      puVar12 = (uint32 *)Color.get_green(&local_78,0);
                      if (lVar9 != null) {
                        local_78 = *puVar12;
                        uStack_74 = puVar12[1];
                        uStack_70 = puVar12[2];
                        uStack_6c = puVar12[3];
                        local_a8 = uVar10;
                        local_a0 = (float)uVar6;
                        GameController.ShowTextAtPos(lVar9,"连击+3",&local_a8,20,&local_78,0);
                        plVar14 = (int64 *)Resources.Load("Sound/SoundEffect/Success",0);
                        plVar13 = (int64 *)0;
                        if ((plVar14 != (int64 *)0) && (*plVar14 == DAT_181d8a228)) {
                          plVar13 = plVar14;
                        }
                        NGUITools.PlaySound(plVar13,0);
                        if (*plVar1 != 0) {
                          uVar10 = Component.get_transform(*plVar1,0);
                          ShortcutExtensions.DOKill(uVar10,0,0);
                          if ((*plVar1 != 0) &&
                             (lVar9 = Component.GetComponent(*plVar1,DAT_181d6b240)) != null) {
                            Behaviour.set_enabled(lVar9,0,0);
                            if (*plVar1 != 0) {
                              uVar10 = Component.get_transform(*plVar1,0);
                              lVar9 = FUN_18046c660(0);
                              if (((lVar9 != null) && (*(int64 *)(lVar9 + 88) != 0)) &&
                                 (lVar9 = Component.get_transform(*(int64 *)(lVar9 + 88),0),
                                 lVar9 != null)) {
                                puVar11 = (uint64 *)Transform.get_position(local_88,lVar9,0);
                                local_a8 = *puVar11;
                                local_a0 = *(float *)(puVar11 + 1);
                                uVar10 = ShortcutExtensions.DOMove(uVar10,&local_a8,0x3f000000,0,0);
                                uVar15 = new OnTooltipCB(lVar8,DAT_181d8ba10,0);
                                TweenSettingsExtensions.OnComplete(uVar10,uVar15,DAT_181d96ee8);
                                return;
                              }
                            }
                          }
                        }
                      }
                    }
                  }
                  else {
                    if (iVar5 == 1) {
                      lVar8 = FUN_18046c0a0(0);
                      if ((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) throw; // [null/range check failed]
                      lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0);
                      lVar9 = FUN_18046c0a0(0);
                      if ((lVar9 == null) ||
                         (((*(int64 *)(lVar9 + 32) == 0 ||
                           (lVar9 = WorldData.Player(*(int64 *)(lVar9 + 32),0)) == null) ||
                          (lVar8 == null)))) throw; // [null/range check failed]
                      plVar14 = (int64 *)0;
                      HeroData.ChangeHp(lVar8,*(float *)(lVar9 + 0x17c) * 0.1,1,1,1,
                                         in_stack_ffffffffffffff40 & 0xffffffffffffff00,0);
                      lVar8 = FUN_18046c0a0(0);
                      puVar11 = (uint64 *)Vector3.get_zero(local_88,0);
                      uVar10 = *puVar11;
                      uVar6 = *(uint32 *)(puVar11 + 1);
                      puVar12 = (uint32 *)Color.get_green(&local_78,0);
                      if (lVar8 == null) throw; // [null/range check failed]
                      local_78 = *puVar12;
                      uStack_74 = puVar12[1];
                      uStack_70 = puVar12[2];
                      uStack_6c = puVar12[3];
                      local_a8 = uVar10;
                      local_a0 = (float)uVar6;
                      GameController.ShowTextAtPos(lVar8,"生命+10%",&local_a8,20,&local_78,0);
                      plVar13 = (int64 *)Resources.Load("Sound/SoundEffect/Eat",0);
                      plVar16 = plVar14;
                      if ((plVar13 != (int64 *)0) && (*plVar13 == DAT_181d8a228)) {
                        plVar16 = plVar13;
                      }
                      NGUITools.PlaySound(plVar16,0);
                      if (this.playerSkeleton == null) throw; // [null/range check failed]
                      uVar10 = Component.get_gameObject(this.playerSkeleton,0);
                      plVar13 = (int64 *)Resources.Load("SpeEffect/治疗",0);
                      if ((plVar13 != (int64 *)0) && (*plVar13 == DAT_181d4e110)) {
                        plVar14 = plVar13;
                      }
                      uVar10 = GlobalData.AddChild(uVar10,plVar14,0);
                      this.newObj = uVar10;
                      if (this.newObj == null) throw; // [null/range check failed]
                      uVar10 = GameObject.GetComponent(this.newObj,DAT_181d9e558);
                      cVar7 = Object.op_Inequality(uVar10,0,0);
                      if (cVar7) {
                        if ((this.newObj == null) ||
                           (lVar8 = GameObject.GetComponent(this.newObj,DAT_181d9e558),
                           lVar8 == null)) throw; // [null/range check failed]
                        fVar17 = (float)AudioSource.get_volume(lVar8,0);
                        AudioSource.set_volume
                                  (lVar8,fVar17 * *(float *)(pStatics_e010 + 16),0
                                  );
                      }
                    }
                    else {
                      if (iVar5 != 2) {
                        return;
                      }
                      StudyUniquePlayer.SetShieldTime(this,0x40a00000,0);
                    }
                    if (*plVar1 != 0) {
                      uVar10 = Component.get_gameObject(*plVar1,0);
                      Object.Destroy(uVar10,0);
                      return;
                    }
                  }
                }
              }
            }
            else {
              if (0.0 < this.shieldTime) {
                StudyUniquePlayer.SetShieldTime(this,0,0);
                plVar14 = (int64 *)Resources.Load("Sound/SoundEffect/Break",0);
                plVar13 = (int64 *)0;
                if ((plVar14 != (int64 *)0) && (plVar13 = (int64 *)0, *plVar14 == DAT_181d8a228)
                   ) {
                  plVar13 = plVar14;
                }
                NGUITools.PlaySound(plVar13,0);
              }
              else {
                cVar7 = GlobalData.IsCheckVersion(1,0);
                if (!cVar7) {
                  if (this.playerSkeleton == null) throw; // [null/range check failed]
                  uVar10 = Component.get_gameObject(this.playerSkeleton,0);
                  plVar14 = (int64 *)Resources.Load("SpeEffect/BloodSplash",0);
                  local_a0 = -0.1;
                  local_a8 = 0x3f80000000000000;
                  plVar13 = (int64 *)0;
                  if ((plVar14 != (int64 *)0) && (*plVar14 == DAT_181d4e110)) {
                    plVar13 = plVar14;
                  }
                  GlobalData.AddChild(uVar10,plVar13,&local_a8,0);
                }
                if ((*plVar1 == 0) || (lVar8 = Component.GetComponent(*plVar1,DAT_181d6d640)) == null
                   ) throw; // [null/range check failed]
                fVar3 = *(float *)(lVar8 + 24);
                if (*pStatics_3070 == 0) throw; // [null/range check failed]
                fVar4 = *(float *)(*pStatics_3070 + 48);
                lVar8 = FUN_18046c660(0);
                if (lVar8 == null) throw; // [null/range check failed]
                if (*(int64 *)(lVar8 + 40) != 0) {
                  lVar8 = FUN_18046c660(0);
                  if ((lVar8 == null) || (*(int64 *)(lVar8 + 40) == 0)) throw; // [null/range check failed]
                  fVar17 = (float)*(int *)(*(int64 *)(lVar8 + 40) + 20) * 0.02;
                }
                local_res10[0] = fVar4 * fVar3 * -20.0 * (1.0 - fVar17);
                lVar8 = FUN_18046c0a0(0);
                if (((lVar8 == null) || (*(int64 *)(lVar8 + 32) == 0)) ||
                   (lVar8 = WorldData.Player(*(int64 *)(lVar8 + 32),0)) == null)
                throw; // [null/range check failed]
                HeroData.ChangeHp(lVar8,local_res10[0],0,0,1,
                                   in_stack_ffffffffffffff40 & 0xffffffffffffff00,0);
                lVar8 = FUN_18046c0a0(0);
                uVar10 = Single.ToString(local_res10,"f0",0);
                if ((*plVar1 == 0) || (lVar9 = Component.get_transform(*plVar1,0)) == null)
                throw; // [null/range check failed]
                puVar11 = (uint64 *)Transform.get_position(local_88,lVar9,0);
                uVar15 = *puVar11;
                uVar6 = *(uint32 *)(puVar11 + 1);
                puVar12 = (uint32 *)Color.get_red(&local_78,0);
                if (lVar8 == null) throw; // [null/range check failed]
                local_78 = *puVar12;
                uStack_74 = puVar12[1];
                uStack_70 = puVar12[2];
                uStack_6c = puVar12[3];
                local_a8 = uVar15;
                local_a0 = (float)uVar6;
                GameController.ShowTextAtPos(lVar8,uVar10,&local_a8,22,&local_78,0);
                if (*pStatics_3070 == 0) throw; // [null/range check failed]
                piVar2 = (int *)(*pStatics_3070 + 36);
                *piVar2 = *piVar2 + 1;
                if (*pStatics_3070 == 0) throw; // [null/range check failed]
                StudyUniqueSkillController.ResetCombo(*pStatics_3070,0);
              }
              if (*pStatics_6c68 != 0) {
                TimeScaleController.SetSlowTime
                          (*pStatics_6c68,0x3f000000,0x3e4ccccd,0);
                if (*pStatics_c9b8 != 0) {
                  ShakeCam.StartShake(*pStatics_c9b8,2,0);
                  if (this.playerSkeleton != null) {
                    uVar10 = Component.get_gameObject(this.playerSkeleton,0);
                    if ((*plVar1 != 0) &&
                       (lVar8 = Component.GetComponent(*plVar1,DAT_181d6d640)) != null) {
                      uVar15 = String.Concat("SpeEffect/",*(uint64 *)(lVar8 + 40),0);
                      plVar14 = (int64 *)Resources.Load(uVar15,0);
                      if ((*plVar1 != 0) && (lVar8 = Component.get_transform(*plVar1,0)) != null) {
                        puVar11 = (uint64 *)Transform.get_localPosition(local_88,lVar8,0);
                        uVar15 = *puVar11;
                        uVar6 = *(uint32 *)(puVar11 + 1);
                        puVar11 = (uint64 *)Vector3.get_one(&local_78,0);
                        local_98 = *puVar11;
                        local_90 = *(float *)(puVar11 + 1);
                        local_a0 = local_90 * 0.5;
                        local_a8 = CONCAT44((float)((uint64)local_98 >> 32) * 0.5,
                                            (float)local_98 * 0.5);
                        local_98 = local_a8;
                        local_90 = local_a0;
                        plVar13 = (int64 *)0;
                        if ((plVar14 != (int64 *)0) && (*plVar14 == DAT_181d4e110)) {
                          plVar13 = plVar14;
                        }
                        local_a8 = uVar15;
                        local_a0 = (float)uVar6;
                        uVar10 = GlobalData.AddChild(uVar10,plVar13,&local_a8,&local_98,0);
                        this.newObj = uVar10;
                        if (this.newObj != null) {
                          uVar10 = GameObject.GetComponent(this.newObj,DAT_181d9e558);
                          cVar7 = Object.op_Inequality(uVar10,0,0);
                          if (cVar7) {
                            if ((this.newObj == null) ||
                               (lVar8 = GameObject.GetComponent
                                                  (this.newObj,DAT_181d9e558),
                               lVar8 == null)) throw; // [null/range check failed]
                            fVar17 = (float)AudioSource.get_volume(lVar8,0);
                            AudioSource.set_volume
                                      (lVar8,fVar17 * *(float *)(pStatics_e010 +
                                                                16),0);
                          }
                          if (*plVar1 != 0) {
                            uVar10 = Component.get_gameObject(*plVar1,0);
                            Object.Destroy(uVar10,0);
                            StudyUniquePlayer.PlayerOnHit(this,1,0);
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

    // Token : 0x6002233
    // RVA   : 0xB97070   Offset: 0xB95870   Length: 0x3EB
    public void PlayerOnHit(bool hit)
    {
        var pStatics_3070 = *(int64*)(DAT_181d83070 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        long lVar2;
        ulong uVar3;
        if (((*pStatics_df90 != 0) &&
            (lVar1 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
           (lVar1 = WorldData.Player(lVar1,0)) != null) {
          if (*(float *)(lVar1 + 0x178) <= 0.0) {
            if ((this.playerSkeleton != null) &&
               (lVar1 = SkeletonAnimation.get_AnimationState(this.playerSkeleton,0), lVar1 != null
               )) {
              AnimationState.SetAnimation(lVar1,1,"die",0,0);
              if ((*pStatics_df90 != 0) &&
                 (lVar1 = *(int64 *)(*pStatics_df90 + 32)) != null) {
                lVar1 = WorldData.Player(lVar1,0);
                if ((((*pStatics_df90 != 0) &&
                     (lVar2 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
                    (lVar2 = WorldData.Player(lVar2,0)) != null) &&
                   (uVar3 = HeroData.GetHeroDieSound(lVar2,0), lVar1 != null)) {
                  HeroData.PlayHeroSound(lVar1,uVar3,0x3f000000,0xbf800000,0);
                  if (*pStatics_3070 != 0) {
                    uVar3 = StudyUniqueSkillController.FinishStudyUniqueSkill
                                      (*pStatics_3070,0,0);
                    FUN_180d837c0(this,uVar3,0);
                    return;
                  }
                }
              }
            }
          }
          else {
            if (!hit) {
              return;
            }
            if ((this.playerSkeleton != null) &&
               (lVar1 = SkeletonAnimation.get_AnimationState(this.playerSkeleton,0), lVar1 != null
               )) {
              AnimationState.SetAnimation(lVar1,1,"hit",0,0);
              if ((this.playerSkeleton != null) &&
                 (lVar1 = SkeletonAnimation.get_AnimationState(this.playerSkeleton,0),
                 lVar1 != null)) {
                AnimationState.AddEmptyAnimation(lVar1,1,0x3dcccccd,0,0);
                lVar1 = FUN_18046c0a0(0);
                if ((lVar1 != null) && (*(int64 *)(lVar1 + 32) != 0)) {
                  lVar1 = WorldData.Player(*(int64 *)(lVar1 + 32),0);
                  lVar2 = FUN_18046c0a0(0);
                  if ((lVar2 != null) &&
                     (((*(int64 *)(lVar2 + 32) != 0 &&
                       (lVar2 = WorldData.Player(*(int64 *)(lVar2 + 32),0)) != null) &&
                      (uVar3 = HeroData.GetHeroHurtSound(lVar2,0), lVar1 != null)))) {
                    HeroData.PlayHeroSound(lVar1,uVar3,0x3f000000,0xbf800000,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6002234
    // RVA   : 0x3A17B0   Offset: 0x39FFB0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_18044ef50(this,0);
    }

}
