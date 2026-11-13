// ============================================================
// Type  : StudyAttackPlayer
// Token : 0x2000383
// ============================================================

public class StudyAttackPlayer
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001CEB
    public SkeletonAnimation playerSkeleton;

    // Token: 0x4001CEC
    public GameObject hipPos;

    // Token: 0x4001CED
    public GameObject attackRange;

    // Token: 0x4001CEE
    public float cd;

    // Token: 0x4001CEF
    public float fullCd;

    // Token: 0x4001CF0
    public float shieldTime;

    // Token: 0x4001CF1
    public GameObject shieldSpe;

    // Token: 0x4001CF2
    public List<GameObject> bulletInAttackRange;

    // Token: 0x4001CF3
    private AudioSource weaponSoundAudioSource;

    // Token: 0x4001CF4
    private GameObject newObj;

    // Token: 0x4001CF5
    private static StudyAttackPlayer _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60022B6
    // RVA   : 0xDA46A0   Offset: 0xDA34A0   Length: 0x36
    public static StudyAttackPlayer get_Instance()
    {
        return **(uint64 **)(DAT_181e88368 + 184);
    }

    // Token : 0x60022B7
    // RVA   : 0xDA2120   Offset: 0xDA0F20   Length: 0x43
    private void Awake()
    {
        puVar1 = *(uint64 **)(DAT_181e88368 + 184);
        *puVar1 = this;
        il2cpp_internal(puVar1,this);
    }

    // Token : 0x60022B8
    // RVA   : 0xDA37A0   Offset: 0xDA25A0   Length: 0xCF
    private void Start()
    {
        ulong uVar1;
        long lVar2;
        if (this.playerSkeleton != null) {
          lVar2 = *(int64 *)(this.playerSkeleton + 224);
          uVar1 = new OnTooltipCB(this,DAT_181e9a978,0);
          if (lVar2 != null) {
            AnimationState.add_Event(lVar2,uVar1,0);
            lVar2 = Component.get_gameObject(this,0);
            if (lVar2 != null) {
              uVar1 = GameObject.AddComponent(lVar2,DAT_181e50d68);
              this.weaponSoundAudioSource = uVar1;
              return;
            }
          }
        }
    }

    // Token : 0x60022B9
    // RVA   : 0xDA23C0   Offset: 0xDA11C0   Length: 0xD5
    private void OnDestroy()
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        uVar3 = this.playerSkeleton;
        cVar2 = Object.op_Inequality(uVar3,0,0);
        if (cVar2) {
          if (this.playerSkeleton == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          lVar1 = *(int64 *)(this.playerSkeleton + 224);
          if (lVar1 != null) {
            uVar3 = new OnTooltipCB(this,DAT_181e9a978,0);
            AnimationState.remove_Event(lVar1,uVar3,0);
          }
        }
    }

    // Token : 0x60022BA
    // RVA   : 0xDA2170   Offset: 0xDA0F70   Length: 0x244
    private void HandleEvent(TrackEntry trackEntry, Event e)
    {
        long lVar1;
        bool cVar2;
        long lVar3;
        ulong uVar4;
        if ((e != null) && (*(int64 *)(e + 16) != 0)) {
          cVar2 = FUN_1816387f0(*(uint64 *)(*(int64 *)(e + 16) + 16),"skillshoot",0);
          if (cVar2) {
            return;
          }
          if (*(int64 *)(e + 16) != 0) {
            lVar1 = *(int64 *)(*(int64 *)(e + 16) + 16);
            lVar3 = FUN_1801dfd90(DAT_181e81128,1);
            if (lVar3 != null) {
              if (*(int *)(lVar3 + 24) == 0) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1801e02d0(uVar4,0);
              }
              *(uint16 *)(lVar3 + 32) = 95;
              if (lVar1 != null) {
                lVar3 = String.Split(lVar1,lVar3,0);
                lVar1 = this.weaponSoundAudioSource;
                if (lVar3 != null) {
                  if (1 < (int)*(uint32 *)(lVar3 + 24)) {
                    if (*(uint32 *)(lVar3 + 24) < 2) {
                      uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                      FUN_1801e02d0(uVar4,0);
                    }
                    Int32.Parse(*(uint64 *)(lVar3 + 40),0);
                  }
                  if (lVar1 != null) {
                    AudioSource.set_volume(lVar1);
                    lVar1 = this.weaponSoundAudioSource;
                    Random.Range(0x3f4ccccd);
                    if (lVar1 != null) {
                      FUN_1818494f0(lVar1);
                      lVar1 = this.weaponSoundAudioSource;
                      if (*(int *)(lVar3 + 24) == 0) {
                        uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1801e02d0(uVar4,0);
                      }
                      uVar4 = String.Concat("Sound/SoundEffect/Anim/",*(uint64 *)(lVar3 + 32),0);
                      plVar5 = (int64 *)Resources.Load(uVar4,0);
                      if (lVar1 != null) {
                        plVar6 = (int64 *)0;
                        if ((plVar5 != (int64 *)0) && (*plVar5 == DAT_181e8f4a0)) {
                          plVar6 = plVar5;
                        }
                        AudioSource.PlayOneShot
                                  (lVar1,plVar6,
                                   *(uint32 *)(*(int64 *)(DAT_181e528f8 + 184) + 16),0);
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

    // Token : 0x60022BB
    // RVA   : 0xDA3870   Offset: 0xDA2670   Length: 0xE28
    private void Update()
    {
        var pStatics_83e8 = *(int64*)(DAT_181e883e8 + 184);
        var pStatics_e150 = *(int64*)(DAT_181e8e150 + 184);
        bool cVar1;
        uint uVar2;
        long lVar3;
        long lVar4;
        ulong uVar7;
        long lVar8;
        ulong uVar9;
        uint uVar12;
        int iVar13;
        float fVar14;
        float fVar15;
        ulong local_f8;
        float local_f0;
        ulong local_e8;
        float local_e0;
        ulong local_d8;
        float local_d0;
        ulong local_c8;
        float local_c0;
        ulong local_b8;
        float local_b0;
        byte[] local_a8 = new byte[16];
        byte[] local_98 = new byte[16];
        byte[] local_88 = new byte[96];
        if (*pStatics_83e8 != 0) {
          if (*(char *)(*pStatics_83e8 + 25) != false) {
            return;
          }
          if (*pStatics_e150 != 0) {
            if (*(char *)(*pStatics_e150 + 56) != false) {
              return;
            }
            if (this.playerSkeleton != null) {
              lVar3 = Component.get_transform(this.playerSkeleton,0);
              lVar4 = Camera.get_main(0);
              puVar5 = (uint64 *)Input.get_mousePosition(local_a8,0);
              if (lVar4 != null) {
                local_f0 = *(float *)(puVar5 + 1);
                local_f8 = *puVar5;
                pfVar6 = (float *)Camera.ScreenToWorldPoint(local_a8,lVar4,&local_f8,0);
                local_f0 = 0.5;
                iVar13 = 1;
                if (*pfVar6 < 0.0) {
                  iVar13 = -1;
                }
                local_f8 = CONCAT44(0x3f000000,(float)iVar13 * 0.5);
                if (lVar3 != null) {
                  local_e8 = local_f8;
                  local_e0 = 0.5;
                  Transform.set_localScale(lVar3,&local_e8,0);
                  if (this.attackRange != null) {
                    lVar3 = GameObject.get_transform(this.attackRange,0);
                    lVar4 = Camera.get_main(0);
                    puVar5 = (uint64 *)Input.get_mousePosition(local_a8,0);
                    if (lVar4 != null) {
                      local_e0 = *(float *)(puVar5 + 1);
                      local_e8 = *puVar5;
                      puVar5 = (uint64 *)Camera.ScreenToWorldPoint(local_a8,lVar4,&local_e8,0);
                      local_f8 = *puVar5;
                      local_f0 = *(float *)(puVar5 + 1);
                      if ((this.attackRange != null) &&
                         (lVar4 = GameObject.get_transform(this.attackRange,0)) != null)
                      {
                        puVar5 = (uint64 *)Transform.get_position(local_a8,lVar4,0);
                        local_e8 = *puVar5;
                        local_e0 = *(float *)(puVar5 + 1);
                        local_d0 = local_f0 - local_e0;
                        local_d8 = CONCAT44(local_f8._4_4_ - (float)((uint64)local_e8 >> 32),
                                            (float)local_f8 - (float)local_e8);
                        local_b8 = local_e8;
                        local_b0 = local_d0;
                        puVar5 = (uint64 *)Vector3.get_normalized(local_a8,&local_d8,0);
                        if (lVar3 != null) {
                          local_e8 = *puVar5;
                          local_e0 = *(float *)(puVar5 + 1);
                          Transform.set_up(lVar3,&local_e8,0);
                          if (this.attackRange != null) {
                            lVar3 = GameObject.get_transform(this.attackRange,0);
                            if ((*pStatics_83e8 != 0) &&
                               (uVar7 = Int32.ToString(*pStatics_83e8 + 44,0),
                               lVar3 != null)) {
                              lVar3 = Transform.Find(lVar3,uVar7,0);
                              if (*pStatics_83e8 != 0) {
                                lVar4 = *(int64 *)(*pStatics_83e8 + 112);
                                if ((*pStatics_83e8 != 0) && (lVar4 != null)) {
                                  iVar13 = *(int *)(*pStatics_83e8 + 44);
                                  if (lVar4.Count <= iVar13 - 3U) {
                                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                  }
                                  if (lVar3 != null) {
                                    local_e8 = *(uint64 *)
                                                (lVar4._items + -4 + (int64)iVar13 * 12
                                                );
                                    local_e0 = *(float *)(lVar4._items + 4 +
                                                         (int64)iVar13 * 12);
                                    Transform.set_localPosition(lVar3,&local_e8,0);
                                    lVar3 = this.attackRange;
                                    if (0.0 < this.cd) {
                                      if (lVar3 == null) throw; // [null/range check failed]
                                      lVar3 = GameObject.get_transform(lVar3,0);
                                      fVar15 = this.cd;
                                      fVar14 = this.fullCd;
                                      puVar5 = (uint64 *)Vector3.get_one(local_a8,0);
                                      local_b0 = *(float *)(puVar5 + 1);
                                      local_b8 = *puVar5;
                                      fVar15 = 1.0 - fVar15 / fVar14;
                                      local_f0 = local_b0 * fVar15;
                                      local_f8 = CONCAT44((float)((uint64)local_b8 >> 32) * fVar15,
                                                          (float)local_b8 * fVar15);
                                      local_e8 = local_b8;
                                      local_e0 = local_b0;
                                      if (lVar3 == null) throw; // [null/range check failed]
                                      local_e8 = local_f8;
                                      local_e0 = local_f0;
                                      Transform.set_localScale(lVar3,&local_e8,0);
                                      fVar15 = this.cd;
                                      fVar14 = (float)Time.get_deltaTime(0);
                                      fVar15 = fVar15 - fVar14;
                                    }
                                    else {
                                      if (lVar3 == null) throw; // [null/range check failed]
                                      lVar3 = GameObject.get_transform(lVar3,0);
                                      puVar5 = (uint64 *)Vector3.get_one(local_a8,0);
                                      if (lVar3 == null) throw; // [null/range check failed]
                                      local_e0 = *(float *)(puVar5 + 1);
                                      local_e8 = *puVar5;
                                      Transform.set_localScale(lVar3,&local_e8,0);
                                      fVar15 = 0.0;
                                    }
                                    this.cd = fVar15;
                                    fVar15 = this.shieldTime;
                                    if (0.0 < fVar15) {
                                      fVar14 = (float)Time.get_deltaTime(0);
                                      fVar15 = fVar15 - fVar14;
                                      this.shieldTime = fVar15;
                                      if (fVar15 <= 0.0) {
                                        StudyAttackPlayer.SetShieldTime(this);
                                      }
                                    }
                                    cVar1 = Input.GetMouseButtonDown(0,0);
                                    if (!cVar1) {
                                      return;
                                    }
                                    lVar3 = FUN_180210ca0(0);
                                    if (lVar3 != null) {
                                      if (*(int64 *)(lVar3 + 40) == 0) {
                                        fVar15 = 0.0;
                                      }
                                      else {
                                        lVar3 = FUN_180210ca0(0);
                                        if ((lVar3 == null) || (*(int64 *)(lVar3 + 40) == 0))
                                        throw; // [null/range check failed]
                                        fVar15 = (float)*(int *)(*(int64 *)(lVar3 + 40) + 20) * 0.1
                                        ;
                                      }
                                      lVar3 = FUN_1802106e0(0);
                                      if (((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
                                         (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0),
                                         lVar3 != null)) {
                                        lVar3 = *(int64 *)(lVar3 + 0x150);
                                        if ((*pStatics_83e8 != 0) && (lVar3 != null))
                                        {
                                          uVar12 = *(uint32 *)(*pStatics_83e8 + 44)
                                          ;
                                          if (lVar3.Count <= uVar12) {
                                            ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                          }
                                          fVar15 = 1.0 / (*(float *)(lVar3._items + 32 +
                                                                    (int64)(int)uVar12 * 4) * 0.02 +
                                                         fVar15 + 1.0);
                                          this.fullCd = fVar15;
                                          this.cd = fVar15;
                                          if (this.playerSkeleton != null) {
                                            lVar3 = SkeletonAnimation.get_AnimationState
                                                              (this.playerSkeleton,0);
                                            if (((*pStatics_83e8 != 0) &&
                                                (lVar4 = *(int64 *)
                                                          (*pStatics_83e8 + 56),
                                                lVar4 != null)) &&
                                               ((lVar4 = KungfuSkillLvData.DataBase(lVar4,0), lVar4 != null
                                                && (lVar3 != null)))) {
                                              iVar13 = 0;
                                              lVar3 = AnimationState.SetAnimation
                                                                (lVar3,1,*(uint64 *)(lVar4 + 160),0,0
                                                                );
                                              if ((this.playerSkeleton != null) &&
                                                 (lVar4 = *(int64 *)
                                                           (this.playerSkeleton + 24),
                                                 lVar4 != null)) {
                                                lVar4 = SkeletonDataAsset.GetSkeletonData(lVar4,1,0);
                                                if (((((*pStatics_83e8 != 0) &&
                                                      (lVar8 = *(int64 *)
                                                                (*pStatics_83e8 +
                                                                56), lVar8 != null)) &&
                                                     (lVar8 = KungfuSkillLvData.DataBase(lVar8,0),
                                                     lVar8 != null)) &&
                                                    ((lVar4 != null &&
                                                     (lVar4 = SkeletonData.FindAnimation
                                                                        (lVar4,*(uint64 *)
                                                                                (lVar8 + 160),0),
                                                     lVar4 != null)))) && (lVar3 != null)) {
                                                  *(float *)(lVar3 + 160) =
                                                       *(float *)(lVar4 + 40) /
                                                       this.fullCd;
                                                  if ((this.playerSkeleton != null) &&
                                                     (lVar3 = SkeletonAnimation.get_AnimationState
                                                                        (this.playerSkeleton,0),
                                                     lVar3 != null)) {
                                                    AnimationState.AddEmptyAnimation
                                                              (lVar3,1,0x3dcccccd,0,0);
                                                    lVar3 = this.bulletInAttackRange;
                                                    if (lVar3 != null) {
                                                      if (0 < lVar3.Count) {
                                                        lVar3 = FUN_180210bf0(0);
                                                        if (lVar3 == null) throw; // [null/range check failed]
                                                        ShakeCam.StartShake(lVar3,1,0);
                                                        lVar3 = this.bulletInAttackRange;
                                                      }
                                                      if (lVar3 != null) {
                                                        uVar12 = lVar3.Count - 1;
                                                        if (-1 < (int)uVar12) {
                                                          lVar3 = (int64)(int)uVar12 * 8 + 32;
                                                          do {
                                                            lVar4 = this.bulletInAttackRange;
                                                            if (lVar4 == null) throw; // [null/range check failed]
                                                            if (lVar4.Count <= uVar12) {

                                                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                                        }
                                                        uVar7 = *(uint64 *)
                                                                 (lVar3 + lVar4._items);
                                                        cVar1 = Object.op_Equality(uVar7,0,0);
                                                        lVar4 = this.bulletInAttackRange;
                                                        if (!cVar1) {
                                                          if ((lVar4 == null) ||
                                                             (lVar4 = FUN_1800024b0(lVar4,uVar12,
                                                                                    DAT_181e6bc70),
                                                             lVar4 == null)) throw; // [null/range check failed]
                                                          cVar1 = GameObject.CompareTag
                                                                            (lVar4,"StudyAttackBullet",0);
                                                          if (!cVar1) {
                                                            if ((this.bulletInAttackRange == null) ||
                                                               (lVar4 = FUN_1800024b0(*(int64 *)
                                                                                       (this + 72),
                                                                                      uVar12), lVar4 == null)
                                                               ) throw; // [null/range check failed]
                                                            GameObject.CompareTag();
                                                          }
                                                          else {
                                                            iVar13 = iVar13 + 1;
                                                            lVar4 = FUN_180da2040(0);
                                                            if (lVar4 == null) throw; // [null/range check failed]
                                                            fVar15 = lVar4._version;
                                                            lVar8 = FUN_180da2040(0);
                                                            if (lVar8 == null) throw; // [null/range check failed]
                                                            fVar14 = (float)(*(int *)(lVar8 + 32) + 1);
                                                            lVar4._version =
                                                                 fVar14 + fVar14 + fVar15;
                                                            lVar4 = FUN_180da2040(0);
                                                            if (lVar4 == null) throw; // [null/range check failed]
                                                            StudyAttackSkillController.ChangeCombo
                                                                      (lVar4,1);
                                                            lVar4 = FUN_180da2040(0);
                                                            if (lVar4 == null) throw; // [null/range check failed]
                                                            uVar7 = *(uint64 *)(lVar4 + 72);
                                                            if (((this.bulletInAttackRange == null) ||
                                                                (lVar4 = FUN_1800024b0(*(int64 *)
                                                                                        (this + 72),
                                                                                       uVar12,
                                                        DAT_181e6bc70), lVar4 == null)) ||
                                                        (lVar4 = GameObject.GetComponent
                                                                           (lVar4,DAT_181e56d08),
                                                        lVar4 == null)) throw; // [null/range check failed]
                                                        uVar9 = String.Concat("SpeEffect/",
                                                                               *(uint64 *)
                                                                                (lVar4 + 40),0);
                                                        plVar10 = (int64 *)Resources.Load(uVar9,0);
                                                        if (((this.bulletInAttackRange == null) ||
                                                            (lVar4 = FUN_1800024b0(*(int64 *)
                                                                                    (this + 72),
                                                                                   uVar12,DAT_181e6bc70),
                                                            lVar4 == null)) ||
                                                           (lVar4 = GameObject.get_transform(lVar4,0),
                                                           lVar4 == null)) throw; // [null/range check failed]
                                                        puVar5 = (uint64 *)
                                                                 Transform.get_localPosition
                                                                           (local_98,lVar4,0);
                                                        uVar9 = *puVar5;
                                                        fVar15 = *(float *)(puVar5 + 1);
                                                        puVar5 = (uint64 *)
                                                                 Vector3.get_one(local_88,0);
                                                        local_e0 = *(float *)(puVar5 + 1);
                                                        local_f0 = local_e0 * 0.5;
                                                        local_f8 = CONCAT44((float)((uint64)*puVar5 >>
                                                                                   32) * 0.5,
                                                                            (float)*puVar5 * 0.5);
                                                        local_c8 = local_f8;
                                                        local_c0 = local_f0;
                                                        plVar11 = (int64 *)0;
                                                        if ((plVar10 != (int64 *)0) &&
                                                           (*plVar10 == DAT_181e52a08)) {
                                                          plVar11 = plVar10;
                                                        }
                                                        local_b8 = uVar9;
                                                        local_b0 = fVar15;
                                                        uVar7 = GlobalData.AddChild
                                                                          (uVar7,plVar11,&local_b8,
                                                                           &local_c8,0);
                                                        this.newObj = uVar7;
                                                        if (this.newObj == null)
                                                        throw; // [null/range check failed]
                                                        GameObject.GetComponent();
                                                        cVar1 = Object.op_Inequality();
                                                        if (cVar1) {
                                                          if ((this.newObj == null) ||
                                                             (lVar4 = GameObject.GetComponent(),
                                                             lVar4 == null)) throw; // [null/range check failed]
                                                          AudioSource.get_volume(lVar4);
                                                          AudioSource.set_volume();
                                                        }
                                                        }
                                                        }
                                                        else {
                                                          if (lVar4 == null) throw; // [null/range check failed]
                                                          FUN_1800024b0(lVar4,uVar12,DAT_181e6bc70);
                                                          FUN_181665e90();
                                                        }
                                                        lVar3 = lVar3 + -8;
                                                        uVar12 = uVar12 - 1;
                                                        } while (-1 < (int)uVar12);
                                                        if (1 < iVar13) {
                                                          lVar3 = FUN_180da2040(0);
                                                          uVar2 = Mathf.RoundToInt(((float)iVar13 - 1.0)
                                                                                    * (float)iVar13 * 0.5,
                                                                                    0);
                                                          if (lVar3 == null) throw; // [null/range check failed]
                                                          StudyAttackSkillController.ChangeCombo
                                                                    (lVar3,uVar2,0);
                                                        }
                                                        }
                                                        uVar7 = this.bulletInAttackRange;
                                                        GlobalData.DestroyAll(uVar7,0);
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

    // Token : 0x60022BC
    // RVA   : 0xDA34A0   Offset: 0xDA22A0   Length: 0x2F2
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
              if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181e52a08)) {
                plVar7 = plVar3;
              }
              lVar4 = GlobalData.AddChild(uVar6,plVar7,&local_38,&local_28,0);
              this.shieldSpe = lVar4;
              il2cpp_internal(plVar1,lVar4);
              if (this.shieldSpe != null) {
                uVar6 = GameObject.GetComponent(this.shieldSpe,DAT_181e533a8);
                cVar2 = Object.op_Inequality(uVar6,0,0);
                if (!cVar2) {
                  return;
                }
                if ((this.shieldSpe != null) &&
                   (lVar4 = GameObject.GetComponent(this.shieldSpe,DAT_181e533a8)) != null) {
                  fVar8 = (float)AudioSource.get_volume(lVar4,0);
                  AudioSource.set_volume
                            (lVar4,fVar8 * *(float *)(*(int64 *)(DAT_181e528f8 + 184) + 16),0);
                  return;
                }
              }
            }
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
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

    // Token : 0x60022BD
    // RVA   : 0xDA24A0   Offset: 0xDA12A0   Length: 0xFF5
    private void OnTriggerEnter2D(Collider2D other)
    {
        var pStatics_2048 = *(int64*)(DAT_181e82048 + 184);
        var pStatics_83e8 = *(int64*)(DAT_181e883e8 + 184);
        var pStatics_c2e8 = *(int64*)(DAT_181e8c2e8 + 184);
        int iVar3;
        uint uVar4;
        bool cVar5;
        long lVar6;
        long lVar7;
        ulong uVar8;
        ulong uVar13;
        float fVar15;
        ulong in_stack_ffffffffffffff60;
        ulong local_88;
        float local_80;
        ulong local_78;
        float local_70;
        byte[] local_68 = new byte[16];
        uint local_58;
        uint uStack_54;
        uint uStack_50;
        uint32 uStack_4c;
        lVar6 = new c.DisplayClass9_0(0);
        if (lVar6 != null) {
          plVar1 = (int64 *)(lVar6 + 16);
          *plVar1 = other;
          il2cpp_internal(plVar1,other);
          if (*plVar1 != 0) {
            cVar5 = Component.CompareTag(*plVar1,"StudyAttackBullet",0);
            if (!cVar5) {
              if (*plVar1 != 0) {
                cVar5 = Component.CompareTag(*plVar1,"StudySkillStar",0);
                if (!cVar5) {
                  return;
                }
                if ((*plVar1 != 0) && (lVar7 = Component.GetComponent(*plVar1,DAT_181e79338)) != null
                   ) {
                  iVar3 = *(int *)(lVar7 + 24);
                  if (iVar3 == 0) {
                    lVar7 = FUN_180da2040(0);
                    if (lVar7 != null) {
                      StudyAttackSkillController.ChangeCombo(lVar7,3);
                      lVar7 = FUN_1802106e0(0);
                      puVar9 = (uint64 *)Vector3.get_zero(local_68,0);
                      uVar8 = *puVar9;
                      uVar4 = *(uint32 *)(puVar9 + 1);
                      puVar10 = (uint32 *)Color.get_green(&local_58,0);
                      if (lVar7 != null) {
                        local_58 = *puVar10;
                        uStack_54 = puVar10[1];
                        uStack_50 = puVar10[2];
                        uStack_4c = puVar10[3];
                        local_88 = uVar8;
                        local_80 = (float)uVar4;
                        GameController.ShowTextAtPos(lVar7,"连击+3",&local_88,20,&local_58,0);
                        plVar12 = (int64 *)Resources.Load("Sound/SoundEffect/Success",0);
                        plVar11 = (int64 *)0;
                        if ((plVar12 != (int64 *)0) && (*plVar12 == DAT_181e8f4a0)) {
                          plVar11 = plVar12;
                        }
                        NGUITools.PlaySound(plVar11,0);
                        if (*plVar1 != 0) {
                          uVar8 = Component.get_transform(*plVar1,0);
                          ShortcutExtensions.DOKill(uVar8,0,0);
                          if ((*plVar1 != 0) &&
                             (lVar7 = Component.GetComponent(*plVar1,DAT_181e76db8)) != null) {
                            Behaviour.set_enabled(lVar7,0,0);
                            if (*plVar1 != 0) {
                              uVar8 = Component.get_transform(*plVar1,0);
                              lVar7 = FUN_180210ca0(0);
                              if (((lVar7 != null) && (*(int64 *)(lVar7 + 88) != 0)) &&
                                 (lVar7 = Component.get_transform(*(int64 *)(lVar7 + 88),0),
                                 lVar7 != null)) {
                                puVar9 = (uint64 *)Transform.get_position(local_68,lVar7,0);
                                local_88 = *puVar9;
                                local_80 = *(float *)(puVar9 + 1);
                                uVar8 = ShortcutExtensions.DOMove(uVar8,&local_88,0x3f000000,0,0);
                                uVar13 = new OnTooltipCB(lVar6,DAT_181e986b0,0);
                                TweenSettingsExtensions.OnComplete(uVar8,uVar13,DAT_181ea3dc0);
                                return;
                              }
                            }
                          }
                        }
                      }
                    }
                  }
                  else {
                    if (iVar3 == 1) {
                      lVar6 = FUN_1802106e0(0);
                      if ((lVar6 == null) || (lVar6.villageAreaID == null)) throw; // [null/range check failed]
                      lVar6 = WorldData.Player(lVar6.villageAreaID,0);
                      lVar7 = FUN_1802106e0(0);
                      if ((lVar7 == null) ||
                         (((*(int64 *)(lVar7 + 32) == 0 ||
                           (lVar7 = WorldData.Player(*(int64 *)(lVar7 + 32),0)) == null) ||
                          (lVar6 == null)))) throw; // [null/range check failed]
                      plVar12 = (int64 *)0;
                      HeroData.ChangeHp(lVar6,*(float *)(lVar7 + 0x17c) * 0.1,1,1,1,
                                         in_stack_ffffffffffffff60 & 0xffffffffffffff00,0);
                      lVar6 = FUN_1802106e0(0);
                      puVar9 = (uint64 *)Vector3.get_zero(local_68,0);
                      uVar8 = *puVar9;
                      uVar4 = *(uint32 *)(puVar9 + 1);
                      puVar10 = (uint32 *)Color.get_green(&local_58,0);
                      if (lVar6 == null) throw; // [null/range check failed]
                      local_58 = *puVar10;
                      uStack_54 = puVar10[1];
                      uStack_50 = puVar10[2];
                      uStack_4c = puVar10[3];
                      local_88 = uVar8;
                      local_80 = (float)uVar4;
                      GameController.ShowTextAtPos(lVar6,"生命+10%",&local_88,20,&local_58,0);
                      plVar11 = (int64 *)Resources.Load("Sound/SoundEffect/Eat",0);
                      plVar14 = plVar12;
                      if ((plVar11 != (int64 *)0) && (*plVar11 == DAT_181e8f4a0)) {
                        plVar14 = plVar11;
                      }
                      NGUITools.PlaySound(plVar14,0);
                      if (this.playerSkeleton == null) throw; // [null/range check failed]
                      uVar8 = Component.get_gameObject(this.playerSkeleton,0);
                      plVar11 = (int64 *)Resources.Load("SpeEffect/治疗",0);
                      if ((plVar11 != (int64 *)0) && (*plVar11 == DAT_181e52a08)) {
                        plVar12 = plVar11;
                      }
                      uVar8 = GlobalData.AddChild(uVar8,plVar12,0);
                      this.newObj = uVar8;
                      if (this.newObj == null) throw; // [null/range check failed]
                      uVar8 = GameObject.GetComponent(this.newObj,DAT_181e533a8);
                      cVar5 = Object.op_Inequality(uVar8,0,0);
                      if (cVar5) {
                        if ((this.newObj == null) ||
                           (lVar6 = GameObject.GetComponent(this.newObj,DAT_181e533a8),
                           lVar6 == null)) throw; // [null/range check failed]
                        fVar15 = (float)AudioSource.get_volume(lVar6,0);
                        AudioSource.set_volume
                                  (lVar6,fVar15 * GameController.CheckShowSpeHero,0
                                  );
                      }
                    }
                    else {
                      if (iVar3 != 2) {
                        return;
                      }
                      StudyAttackPlayer.SetShieldTime(this,0x40a00000,0);
                    }
                    if (*plVar1 != 0) {
                      uVar8 = Component.get_gameObject(*plVar1,0);
                      Object.Destroy(uVar8,0);
                      return;
                    }
                  }
                }
              }
            }
            else {
              if (0.0 < this.shieldTime) {
                StudyAttackPlayer.SetShieldTime(this,0,0);
                plVar12 = (int64 *)Resources.Load("Sound/SoundEffect/Break",0);
                plVar11 = (int64 *)0;
                if ((plVar12 != (int64 *)0) && (plVar11 = (int64 *)0, *plVar12 == DAT_181e8f4a0)
                   ) {
                  plVar11 = plVar12;
                }
                NGUITools.PlaySound(plVar11,0);
              }
              else {
                cVar5 = GlobalData.IsCheckVersion(1,0);
                if (!cVar5) {
                  if (this.playerSkeleton == null) throw; // [null/range check failed]
                  uVar8 = Component.get_gameObject(this.playerSkeleton,0);
                  plVar12 = (int64 *)Resources.Load("SpeEffect/BloodSplash",0);
                  local_80 = -0.1;
                  local_88 = 0x3f80000000000000;
                  plVar11 = (int64 *)0;
                  if ((plVar12 != (int64 *)0) && (*plVar12 == DAT_181e52a08)) {
                    plVar11 = plVar12;
                  }
                  GlobalData.AddChild(uVar8,plVar11,&local_88,0);
                }
                lVar6 = FUN_1802106e0(0);
                if ((lVar6 == null) || (lVar6.villageAreaID == null)) throw; // [null/range check failed]
                lVar6 = WorldData.Player(lVar6.villageAreaID,0);
                if ((*plVar1 == 0) || (lVar7 = Component.GetComponent(*plVar1,DAT_181e792b8)) == null
                   ) throw; // [null/range check failed]
                fVar15 = *(float *)(lVar7 + 24);
                lVar7 = FUN_1802106e0(0);
                if ((((lVar7 == null) || (*(int64 *)(lVar7 + 32) == 0)) ||
                    (lVar7 = WorldData.Player(*(int64 *)(lVar7 + 32),0)) == null) ||
                   (lVar6 == null)) throw; // [null/range check failed]
                HeroData.ChangeHp(lVar6,CONCAT44(0x80000000,-fVar15 * *(float *)(lVar7 + 0x17c)),0,0,1,
                                   in_stack_ffffffffffffff60 & 0xffffffffffffff00,0);
                if (*pStatics_83e8 == 0) throw; // [null/range check failed]
                piVar2 = (int *)(*pStatics_83e8 + 36);
                *piVar2 = *piVar2 + 1;
                if (*pStatics_83e8 == 0) throw; // [null/range check failed]
                StudyAttackSkillController.ResetCombo(*pStatics_83e8,0);
              }
              if (*pStatics_83e8 != 0) {
                uVar8 = *(uint64 *)(*pStatics_83e8 + 72);
                if ((*plVar1 != 0) && (lVar6 = Component.GetComponent(*plVar1,DAT_181e792b8)) != null
                   ) {
                  uVar13 = String.Concat("SpeEffect/",lVar6.forceAreaID,0);
                  plVar12 = (int64 *)Resources.Load(uVar13,0);
                  if ((*plVar1 != 0) && (lVar6 = Component.get_transform(*plVar1,0)) != null) {
                    puVar9 = (uint64 *)Transform.get_localPosition(local_68,lVar6,0);
                    uVar13 = *puVar9;
                    uVar4 = *(uint32 *)(puVar9 + 1);
                    puVar9 = (uint64 *)Vector3.get_one(&local_58,0);
                    local_78 = *puVar9;
                    local_70 = *(float *)(puVar9 + 1);
                    local_80 = local_70 * 0.5;
                    local_88 = CONCAT44((float)((uint64)local_78 >> 32) * 0.5,(float)local_78 * 0.5);
                    local_78 = local_88;
                    local_70 = local_80;
                    plVar11 = (int64 *)0;
                    if ((plVar12 != (int64 *)0) && (*plVar12 == DAT_181e52a08)) {
                      plVar11 = plVar12;
                    }
                    local_88 = uVar13;
                    local_80 = (float)uVar4;
                    uVar8 = GlobalData.AddChild(uVar8,plVar11,&local_88,&local_78,0);
                    this.newObj = uVar8;
                    if (this.newObj != null) {
                      uVar8 = GameObject.GetComponent(this.newObj,DAT_181e533a8);
                      cVar5 = Object.op_Inequality(uVar8,0,0);
                      if (cVar5) {
                        if ((this.newObj == null) ||
                           (lVar6 = GameObject.GetComponent(this.newObj,DAT_181e533a8),
                           lVar6 == null)) throw; // [null/range check failed]
                        fVar15 = (float)AudioSource.get_volume(lVar6,0);
                        AudioSource.set_volume
                                  (lVar6,fVar15 * GameController.CheckShowSpeHero,0
                                  );
                      }
                      if (*pStatics_c2e8 != 0) {
                        TimeScaleController.SetSlowTime
                                  (*pStatics_c2e8,0x3f000000,0x3e4ccccd,0);
                        if (*pStatics_2048 != 0) {
                          ShakeCam.StartShake(*pStatics_2048,2,0);
                          if (*plVar1 != 0) {
                            uVar8 = Component.get_gameObject(*plVar1,0);
                            Object.Destroy(uVar8,0);
                            if (((GameController._instance != null) &&
                                (lVar6 = GameController._instance.worldData,
                                lVar6 != null)) && (lVar6 = WorldData.Player(lVar6,0)) != null) {
                              lVar7 = this.playerSkeleton;
                              if (lVar6.skinUnlockData <= 0.0) {
                                if ((lVar7 != null) &&
                                   (lVar6 = SkeletonAnimation.get_AnimationState(lVar7,0)) != null) {
                                  AnimationState.SetAnimation(lVar6,1,"die",0,0);
                                  lVar6 = FUN_1802106e0(0);
                                  if ((lVar6 != null) && (lVar6.villageAreaID != null)) {
                                    lVar6 = WorldData.Player(lVar6.villageAreaID,0);
                                    lVar7 = FUN_1802106e0(0);
                                    if ((lVar7 != null) &&
                                       (((*(int64 *)(lVar7 + 32) != 0 &&
                                         (lVar7 = WorldData.Player(*(int64 *)(lVar7 + 32),0),
                                         lVar7 != null)) &&
                                        (uVar8 = HeroData.GetHeroDieSound(lVar7,0), lVar6 != null)))) {
                                      HeroData.PlayHeroSound(lVar6,uVar8,0x3f000000,0xbf800000,0);
                                      if (*pStatics_83e8 != 0) {
                                        uVar8 = StudyAttackSkillController.FinishStudyFightSkill
                                                          (*pStatics_83e8,0,0);
                                        FUN_180ae80b0(this,uVar8,0);
                                        return;
                                      }
                                    }
                                  }
                                }
                              }
                              else if ((lVar7 != null) &&
                                      (lVar6 = SkeletonAnimation.get_AnimationState(lVar7,0)) != null
                                      ) {
                                AnimationState.SetAnimation(lVar6,1,"hit",0,0);
                                if ((this.playerSkeleton != null) &&
                                   (lVar6 = SkeletonAnimation.get_AnimationState
                                                      (this.playerSkeleton,0), lVar6 != null)) {
                                  AnimationState.AddEmptyAnimation(lVar6,1,0x3dcccccd,0,0);
                                  lVar6 = FUN_1802106e0(0);
                                  if ((lVar6 != null) && (lVar6.villageAreaID != null)) {
                                    lVar6 = WorldData.Player(lVar6.villageAreaID,0);
                                    lVar7 = FUN_1802106e0(0);
                                    if ((lVar7 != null) &&
                                       (((*(int64 *)(lVar7 + 32) != 0 &&
                                         (lVar7 = WorldData.Player(*(int64 *)(lVar7 + 32),0),
                                         lVar7 != null)) &&
                                        (uVar8 = HeroData.GetHeroHurtSound(lVar7,0), lVar6 != null)))) {
                                      HeroData.PlayHeroSound(lVar6,uVar8,0x3f000000,0xbf800000,0);
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
    }

    // Token : 0x60022BE
    // RVA   : 0x2110A0   Offset: 0x20FEA0   Length: 0x7
    public void /*ctor*/()
    {
        FUN_180ae8740(this,0);
    }

}
