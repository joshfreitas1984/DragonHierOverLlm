// ============================================================
// Type  : BattleUnit
// Token : 0x200017E
// ============================================================

public class BattleUnit
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000A20
    public SkeletonAnimation skeleton;

    // Token: 0x4000A21
    public GameObject hipPos;

    // Token: 0x4000A22
    public GameObject mouthPos;

    // Token: 0x4000A23
    public GameObject bulletPos;

    // Token: 0x4000A24
    public bool playerControl;

    // Token: 0x4000A25
    public HeroData heroData;

    // Token: 0x4000A26
    public BattleUnit summonSourceHero;

    // Token: 0x4000A27
    public KungfuSkillLvData summonSourceSkill;

    // Token: 0x4000A28
    public BattleTeam battleTeam;

    // Token: 0x4000A29
    public GridUnitData mapGrid;

    // Token: 0x4000A2A
    public GameObject followUI;

    // Token: 0x4000A2B
    public List<AudioSource> heroAudioSources;

    // Token: 0x4000A2C
    public List<float> heroAudioSouceVolumn;

    // Token: 0x4000A2D
    public Trail trail;

    // Token: 0x4000A2E
    public SmokeTrail smokeTrail;

    // Token: 0x4000A2F
    public SmokePlume smokePlume;

    // Token: 0x4000A30
    public ParticleSystem weaponLight;

    // Token: 0x4000A31
    public ActionBarUnit actionBarUnit;

    // Token: 0x4000A32
    public BattleInfoData battleInfo;

    // Token: 0x4000A33
    public bool autoFight;

    // Token: 0x4000A34
    public float battleMove;

    // Token: 0x4000A35
    public bool moved;

    // Token: 0x4000A36
    public bool attacked;

    // Token: 0x4000A37
    public bool reborn;

    // Token: 0x4000A38
    public int stepMoved;

    // Token: 0x4000A39
    public float originHp;

    // Token: 0x4000A3A
    public float originMp;

    // Token: 0x4000A3B
    public float originExternalInjury;

    // Token: 0x4000A3C
    public float originInternalInjury;

    // Token: 0x4000A3D
    public float originPoisonInjury;

    // Token: 0x4000A3E
    public static Vector3 headPos;

    // Token: 0x4000A3F
    public static Vector3 highLightScale;

    // Token: 0x4000A40
    public static float UnitMoveOneGridTime;

    // Token: 0x4000A41
    public static int damageBaseFontSize;

    // Token: 0x4000A42
    public bool inited;

    // Token: 0x4000A43
    public bool destroyed;

    // Token: 0x4000A44
    private KungfuSkillLvData nowOnAttackSkill;

    // Token: 0x4000A45
    private Image damageBarImage;

    // Token: 0x4000A46
    private RectTransform damageBarRect;

    // Token: 0x4000A47
    private GameObject protectIconObj;

    // Token: 0x4000A48
    private GameObject summonIconObj;

    // Token: 0x4000A49
    private bool damageBarShown;

    // Token: 0x4000A4A
    private static readonly List<Vector3> SummonFollowUIOffset;

    // Token: 0x4000A4B
    public bool killTalk;

    // Token: 0x4000A4C
    private GameObject invincibleEffect;

    // Token: 0x4000A4D
    public int OnceShowText;

    // Token: 0x4000A4E
    public static List<string> HeroKillTalk;

    // Token: 0x4000A4F
    public static List<string> HeroDeadTalk;

    // Token: 0x4000A50
    public static List<string> HeroLowHpTalk;

    // Token: 0x4000A51
    public static List<string> StudyFightStartTalk;

    // Token: 0x4000A52
    public static List<string> DeathFightStartTalk;

    // Token: 0x4000A53
    public static List<string> UseSkillTalk;

    // Token: 0x4000A54
    public static List<string> FriendDeadTalk;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000C44
    // RVA   : 0x8D6840   Offset: 0x8D5C40   Length: 0x38
    public bool get_IsAlive()
    {
        long lVar1;
        ulong in_RAX;
        if (this.destroyed) {
          return in_RAX & 0xffffffffffffff00;
        }
        lVar1 = this.heroData;
        if (lVar1 != null) {
          return CONCAT71((int7)((uint64)lVar1 >> 8),0.0 < lVar1.hp);
        }
    }

    // Token : 0x6000C45
    // RVA   : 0x8D5020   Offset: 0x8D4420   Length: 0x7
    private void Start()
    {
        void FUN_1808d5020(uint64 this)
        {
        BattleUnit.Init(this,0);
    }

    // Token : 0x6000C46
    // RVA   : 0x8CD450   Offset: 0x8CC850   Length: 0x139
    public bool AISettingControlable()
    {
        int iVar1;
        bool cVar2;
        long lVar3;
        long lVar4;
        if (this.heroData != null) {
          cVar2 = HeroData.AttackSelfTeam(this.heroData,0);
          if (cVar2) {
            return false;
          }
          lVar4 = this.battleTeam;
          if (lVar4 != null) {
            if (lVar4.havePlayer) {
              return true;
            }
            lVar3 = FUN_18046bb80(0);
            if (lVar3 != null) {
              lVar3 = BattleController.GetPlayerControlTeam(lVar3,0);
              if (lVar4 == lVar3) {
                return true;
              }
              lVar4 = FUN_18046bb80(0);
              if (lVar4 != null) {
                if (*(int *)(lVar4 + 140) < 0) {
                  return false;
                }
                if (this.battleTeam != null) {
                  iVar1 = this.battleTeam.ID;
                  lVar4 = FUN_18046bb80(0);
                  if (lVar4 != null) {
                    return iVar1 == *(int *)(lVar4 + 140);
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000C47
    // RVA   : 0x8CDF50   Offset: 0x8CD350   Length: 0x66
    public void ChangeAutoType()
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        if (!param_2) {
          this.autoFight = 0;
          this.playerControl = 1;
          return;
        }
        this.autoFight = 1;
        this.playerControl = 0;
        lVar3 = *(int64 *)(*(int64 *)(DAT_181db0260 + 184) + 80);
        if (lVar3 != null) {
          uVar1 = *(uint64 *)(lVar3 + 0x110);
          cVar2 = Object.op_Equality(uVar1,this,0);
          if (!cVar2) {
            return;
          }
          lVar3 = FUN_18046bb80(0);
          if (lVar3 != null) {
            if (*(int *)(lVar3 + 0x124) != 2) {
              lVar3 = FUN_18046bb80(0);
              if (lVar3 == null) throw; // [null/range check failed]
              if (*(int *)(lVar3 + 0x124) != 7) {
                lVar3 = FUN_18046bb80(0);
                if (lVar3 == null) throw; // [null/range check failed]
                if (*(int *)(lVar3 + 0x124) != 10) {
                  return;
                }
              }
            }
            lVar3 = FUN_18046bb80(0);
            if (lVar3 != null) {
              if (*(int *)(lVar3 + 0x124) == 7) {
                lVar3 = FUN_18046bb80(0);
                if (lVar3 == null) throw; // [null/range check failed]
                BattleController.CancelMove(lVar3,0);
              }
              else {
                lVar3 = FUN_18046bb80(0);
                if (lVar3 == null) throw; // [null/range check failed]
                if (*(int *)(lVar3 + 0x124) == 10) {
                  lVar3 = FUN_18046bb80(0);
                  if (lVar3 == null) throw; // [null/range check failed]
                  BattleController.CancelAttack(lVar3,0);
                }
              }
              lVar3 = FUN_18046bb80(0);
              if (lVar3 != null) {
                BattleController.ResetAllAIPlans(lVar3,0);
                lVar3 = FUN_18046bb80(0);
                if (lVar3 != null) {
                  *(uint32 *)(lVar3 + 0x124) = 1;
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000C48
    // RVA   : 0x8CDFC0   Offset: 0x8CD3C0   Length: 0x2F1
    public void ChangeAutoType(bool auto)
    {
        ulong uVar1;
        bool cVar2;
        long lVar3;
        if (!auto) {
          this.autoFight = 0;
          this.playerControl = 1;
          return;
        }
        this.autoFight = 1;
        this.playerControl = 0;
        lVar3 = *(int64 *)(*(int64 *)(DAT_181db0260 + 184) + 80);
        if (lVar3 != null) {
          uVar1 = *(uint64 *)(lVar3 + 0x110);
          cVar2 = Object.op_Equality(uVar1,this,0);
          if (!cVar2) {
            return;
          }
          lVar3 = FUN_18046bb80(0);
          if (lVar3 != null) {
            if (*(int *)(lVar3 + 0x124) != 2) {
              lVar3 = FUN_18046bb80(0);
              if (lVar3 == null) throw; // [null/range check failed]
              if (*(int *)(lVar3 + 0x124) != 7) {
                lVar3 = FUN_18046bb80(0);
                if (lVar3 == null) throw; // [null/range check failed]
                if (*(int *)(lVar3 + 0x124) != 10) {
                  return;
                }
              }
            }
            lVar3 = FUN_18046bb80(0);
            if (lVar3 != null) {
              if (*(int *)(lVar3 + 0x124) == 7) {
                lVar3 = FUN_18046bb80(0);
                if (lVar3 == null) throw; // [null/range check failed]
                BattleController.CancelMove(lVar3,0);
              }
              else {
                lVar3 = FUN_18046bb80(0);
                if (lVar3 == null) throw; // [null/range check failed]
                if (*(int *)(lVar3 + 0x124) == 10) {
                  lVar3 = FUN_18046bb80(0);
                  if (lVar3 == null) throw; // [null/range check failed]
                  BattleController.CancelAttack(lVar3,0);
                }
              }
              lVar3 = FUN_18046bb80(0);
              if (lVar3 != null) {
                BattleController.ResetAllAIPlans(lVar3,0);
                lVar3 = FUN_18046bb80(0);
                if (lVar3 != null) {
                  *(uint32 *)(lVar3 + 0x124) = 1;
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000C49
    // RVA   : 0x8D2390   Offset: 0x8D1790   Length: 0x81
    public BattleUnit GetSummonSource()
    {
        bool cVar1;
        while( true ) {
          this = this.summonSourceHero;
          cVar1 = Object.op_Inequality(this,0,0);
          if (!cVar1) break;
          if ((this == 0) || (this.heroData == null)) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (!this.heroData.isSummon) {
            return this;
          }
        }
        return this;
    }

    // Token : 0x6000C4A
    // RVA   : 0x8D22E0   Offset: 0x8D16E0   Length: 0xA0
    public KungfuSkillLvData GetSummonSourceSkill()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        lVar2 = this.summonSourceHero;
        uVar3 = this.summonSourceSkill;
        while( true ) {
          cVar1 = Object.op_Inequality(lVar2,0,0);
          if (!cVar1) break;
          if ((lVar2 == null) || (lVar2.heroData == null)) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (!lVar2.heroData.isSummon) {
            return uVar3;
          }
          uVar3 = lVar2.summonSourceSkill;
          lVar2 = lVar2.summonSourceHero;
        }
        return uVar3;
    }

    // Token : 0x6000C4B
    // RVA   : 0x8D1DE0   Offset: 0x8D11E0   Length: 0x123
    public AttackDirectionType GetAttackDirectionType(GridUnitData sourceMapGrid)
    {
        ulong uVar1;
        ulong uVar2;
        bool cVar3;
        int iVar4;
        int iVar5;
        long lVar6;
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        uint64 local_28;
        uint64 uStack_20;
        if (this.heroData != null) {
          if (this.heroData.isSummon) {
            return 0;
          }
          if (sourceMapGrid == null) {
            return 0;
          }
          if ((this.skeleton != null) &&
             (lVar6 = Component.get_transform(this.skeleton,0)) != null) {
            puVar7 = (uint64 *)Transform.get_localRotation(&local_28,lVar6,0);
            uVar1 = *puVar7;
            uVar2 = puVar7[1];
            puVar8 = (uint32 *)Quaternion.get_identity(&local_28,0);
            local_38 = *puVar8;
            uStack_34 = puVar8[1];
            uStack_30 = puVar8[2];
            uStack_2c = puVar8[3];
            local_28 = uVar1;
            uStack_20 = uVar2;
            cVar3 = Quaternion.op_Equality(&local_28,&local_38,0);
            lVar6 = this.mapGrid;
            if (!cVar3) {
              if (lVar6 == null) throw; // [null/range check failed]
              if (*(int *)(sourceMapGrid + 40) < lVar6.column) {
                return 0;
              }
            }
            else {
              if (lVar6 == null) throw; // [null/range check failed]
              if (lVar6.column < *(int *)(sourceMapGrid + 40)) {
                return 0;
              }
            }
            iVar4 = Mathf.Abs(*(int *)(sourceMapGrid + 36) - lVar6.row,0);
            if (this.mapGrid != null) {
              iVar5 = Mathf.Abs(*(int *)(sourceMapGrid + 40) - this.mapGrid.column
                                 ,0);
              if (iVar4 <= iVar5) {
                return 2;
              }
              return 1;
            }
          }
        }
    }

    // Token : 0x6000C4C
    // RVA   : 0x8D2790   Offset: 0x8D1B90   Length: 0x2B8
    private void Init()
    {
        long lVar1;
        float fVar2;
        ulong uVar3;
        long lVar5;
        uint uVar6;
        long lVar7;
        uint uVar8;
        ulong local_58;
        ulong local_48;
        float local_40;
        byte[] local_28 = new byte[16];
        if (this.inited) {
          return;
        }
        lVar5 = this.heroData;
        this.inited = 1;
        uVar3 = Component.get_gameObject(this,0);
        puVar4 = (uint64 *)Vector3.get_one(local_28,0);
        local_48 = *puVar4;
        local_40 = *(float *)(puVar4 + 1) * 0.66;
        local_58 = CONCAT44((float)((uint64)local_48 >> 32) * 0.66,(float)local_48 * 0.66);
        fVar2 = *(float *)(puVar4 + 1);
        if (lVar5 != null) {
          local_48 = local_58;
          uVar3 = HeroData.GenerateHeroSkeleton(lVar5,uVar3,&local_48,0);
          this.skeleton = uVar3;
          fVar2 = local_40;
          if (this.skeleton != null) {
            lVar5 = *(int64 *)(this.skeleton + 224);
            uVar3 = new OnTooltipCB(this,DAT_181d89408,0);
            fVar2 = local_40;
            if (lVar5 != null) {
              AnimationState.add_Event(lVar5,uVar3,0);
              lVar5 = Component.get_gameObject(this,0);
              fVar2 = local_40;
              if ((lVar5 != null) &&
                 (lVar5 = GameObject.AddComponent(lVar5,DAT_181dc52a8), fVar2 = local_40) != null) {
                FootStepController.Init(lVar5,this.skeleton,0);
                uVar3 = il2cpp_internal(DAT_181d96ee8);
                FUN_181330100(uVar3,DAT_181da0d10);
                this.heroAudioSouceVolumn = uVar3;
                lVar5 = this.heroAudioSources;
                uVar6 = 0;
                fVar2 = local_40;
                if (lVar5 != null) {
                  lVar7 = 32;
                  while( true ) {
                    if (lVar5.summonLv <= (int)uVar6) {
                      return;
                    }
                    lVar1 = this.heroAudioSouceVolumn;
                    fVar2 = local_40;
                    if (lVar5 == null) break;
                    if (lVar5.summonLv <= uVar6) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar5 = *(int64 *)(lVar7 + lVar5.isSummon);
                    fVar2 = local_40;
                    if ((lVar5 == null) ||
                       (uVar8 = AudioSource.get_volume(lVar5,0), fVar2 = local_40, lVar1 == null)) break;
                    FUN_18181e420(lVar1,uVar8,DAT_181da0e10);
                    lVar5 = this.heroAudioSources;
                    uVar6 = uVar6 + 1;
                    lVar7 = lVar7 + 8;
                    fVar2 = local_40;
                    if (lVar5 == null) break;
                  }
                }
              }
            }
          }
        }
        local_40 = fVar2;
    }

    // Token : 0x6000C4D
    // RVA   : 0x8D2420   Offset: 0x8D1820   Length: 0x360
    private void HandleEvent(TrackEntry trackEntry, Event e)
    {
        long lVar1;
        bool cVar2;
        int iVar3;
        long lVar4;
        ulong uVar5;
        uint uVar8;
        float fVar9;
        if ((e != null) && (*(int64 *)(e + 16) != 0)) {
          cVar2 = FUN_18171eb50(*(uint64 *)(*(int64 *)(e + 16) + 16),"skillshoot",0);
          if (!cVar2) {
            if (*(int64 *)(e + 16) != 0) {
              lVar1 = *(int64 *)(*(int64 *)(e + 16) + 16);
              lVar4 = FUN_1800d60b0(DAT_181da1058,1);
              if (lVar4 != null) {
                if (*(int *)(lVar4 + 24) == 0) {
                  uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                  FUN_1800d65f0(uVar5,0);
                }
                *(uint16 *)(lVar4 + 32) = 95;
                if (lVar1 != null) {
                  lVar4 = String.Split(lVar1,lVar4,0);
                  lVar1 = this.heroAudioSources;
                  if (lVar1 != null) {
                    if (lVar1.Count < 3) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar1 = *(int64 *)(lVar1._items + 48);
                    if (lVar4 != null) {
                      if ((int)*(uint32 *)(lVar4 + 24) < 2) {
                        fVar9 = 1.0;
                      }
                      else {
                        if (*(uint32 *)(lVar4 + 24) < 2) {
                          uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar5,0);
                        }
                        iVar3 = Int32.Parse(*(uint64 *)(lVar4 + 40),0);
                        fVar9 = (float)iVar3 * 0.2 + 0.4;
                      }
                      if (lVar1 != null) {
                        AudioSource.set_volume
                                  (lVar1,fVar9 * *(float *)(*(int64 *)(DAT_181d72d50 + 184) + 16),0)
                        ;
                        lVar1 = this.heroAudioSources;
                        if (lVar1 != null) {
                          if (lVar1.Count < 3) {
                            ThrowHelper.ThrowArgumentOutOfRangeException(0);
                          }
                          lVar1 = *(int64 *)(lVar1._items + 48);
                          uVar8 = Random.Range(0x3f4ccccd,0x3f99999a,0);
                          if (lVar1 != null) {
                            FUN_180467590(lVar1,uVar8,0);
                            lVar1 = this.heroAudioSources;
                            if (lVar1 != null) {
                              if (lVar1.Count < 3) {
                                ThrowHelper.ThrowArgumentOutOfRangeException(0);
                              }
                              lVar1 = *(int64 *)(lVar1._items + 48);
                              if (*(int *)(lVar4 + 24) == 0) {
                                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar5,0);
                              }
                              uVar5 = String.Concat("Sound/SoundEffect/Anim/",*(uint64 *)(lVar4 + 32),0);
                              plVar6 = (int64 *)Resources.Load(uVar5,0);
                              if (lVar1 != null) {
                                plVar7 = (int64 *)0;
                                if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181daf360)) {
                                  plVar7 = plVar6;
                                }
                                AudioSource.PlayOneShot(lVar1,plVar7,0);
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
          else {
            lVar1 = *(int64 *)(*(int64 *)(DAT_181db0260 + 184) + 80);
            if (lVar1 != null) {
              uVar5 = BattleController.BattleUnitAttackHappen(lVar1,0);
              FUN_180d8c8f0(this,uVar5,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000C4E
    // RVA   : 0x8CE2C0   Offset: 0x8CD6C0   Length: 0x14B
    public void ChangeBattleMove(float num, bool useMaxFightMovePower, bool useAnim)
    {
        float fVar1;
        ulong uVar2;
        bool cVar3;
        uint uVar4;
        fVar1 = this.battleMove;
        if (!useMaxFightMovePower) {
          uVar4 = 0x497423f0;
        }
        else {
          uVar4 = *(uint32 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x230);
        }
        uVar4 = FUN_1810e3cd0(fVar1 + num,0,uVar4,0);
        this.battleMove = uVar4;
        uVar2 = this.actionBarUnit;
        cVar3 = Object.op_Inequality(uVar2,0,0);
        if ((cVar3) && (!this.destroyed)) {
          if (this.heroData == null) {
        LAB_1808ce406:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          if (0.0 < this.heroData.hp) {
            if (this.actionBarUnit == null) goto LAB_1808ce406;
            ActionBarUnit.RefreshActionBarUnit(this.actionBarUnit,useAnim,0);
          }
        }
    }

    // Token : 0x6000C4F
    // RVA   : 0x8D49B0   Offset: 0x8D3DB0   Length: 0x93
    public void SetWeaponTrail(bool start, int trailType)
    {
        long lVar1;
        if (this.trail != null) {
          *(uint8 *)(this.trail + 32) = 0;
          if (this.smokeTrail != null) {
            *(uint8 *)(this.smokeTrail + 32) = 0;
            if (this.smokePlume != null) {
              *(uint8 *)(this.smokePlume + 32) = 0;
              if ((start) && (-1 < trailType)) {
                if (trailType == null) {
                  trailType = FUN_180d96040(1);
                }
                if (trailType == 1) {
                  lVar1 = this.trail;
                }
                else if (trailType == 2) {
                  lVar1 = this.smokeTrail;
                }
                else {
                  if (trailType != 3) {
                    return;
                  }
                  lVar1 = this.smokePlume;
                }
                if (lVar1 == null) throw; // [null/range check failed]
                *(uint8 *)(lVar1 + 32) = 1;
              }
              return;
            }
          }
        }
    }

    // Token : 0x6000C50
    // RVA   : 0x8D5170   Offset: 0x8D4570   Length: 0x189
    private void Update()
    {
        float fVar1;
        long lVar2;
        long lVar3;
        float fVar4;
        uint uVar5;
        this.OnceShowText = 0;
        BattleUnit.RefreshFollowUI(this,0);
        if (this.skeleton != null) {
          fVar1 = *(float *)(this.skeleton + 300);
          lVar2 = PlotController.LaBaFestivelResultTalkText;
          if (lVar2 != null) {
            fVar4 = (float)BattleController.GetHalfBattleTimeScale(lVar2,0);
            if (fVar1 != fVar4) {
              lVar2 = this.skeleton;
              lVar3 = PlotController.LaBaFestivelResultTalkText;
              if ((lVar3 == null) || (uVar5 = BattleController.GetHalfBattleTimeScale(lVar3,0), lVar2 == null))
              throw; // [null/range check failed]
              *(uint32 *)(lVar2 + 300) = uVar5;
            }
            return;
          }
        }
    }

    // Token : 0x6000C51
    // RVA   : 0x8D2D70   Offset: 0x8D2170   Length: 0x214
    public void PlayHeroSound(AudioClip targetAudioClip, HeroAudioTrack targetTrack, bool forcePlay, bool useVoicePitch)
    {
        void BattleUnit.PlayHeroSound
                     (int64 this,uint64 targetAudioClip,uint32 targetTrack,char forcePlay,char useVoicePitch)
        {
        float fVar1;
        int64 lVar2;
        int64 lVar3;
        char cVar4;
        int64 lVar5;
        uint32 uVar6;
        lVar5 = (int64)(int)targetTrack;
        if (!forcePlay) {
          lVar2 = this.heroAudioSources;
          if (lVar2 == null) throw; // [null/range check failed]
          if (lVar2.Count <= targetTrack) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = *(int64 *)(lVar2._items + 32 + lVar5 * 8);
          if (lVar2 == null) throw; // [null/range check failed]
          cVar4 = AudioSource.get_isPlaying(lVar2,0);
          if (cVar4) {
            return;
          }
        }
        lVar2 = this.heroAudioSources;
        if (lVar2 == null) throw; // [null/range check failed]
        if (lVar2.Count <= targetTrack) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar2 = *(int64 *)(lVar2._items + 32 + lVar5 * 8);
        if (lVar2 == null) throw; // [null/range check failed]
        AudioSource.set_clip(lVar2,targetAudioClip,0);
        lVar2 = this.heroAudioSources;
        if (lVar2 == null) throw; // [null/range check failed]
        if (lVar2.Count <= targetTrack) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar2 = *(int64 *)(lVar2._items + 32 + lVar5 * 8);
        if (!useVoicePitch) {
        LAB_1808d2e8a:
          uVar6 = 0x3f800000;
        }
        else {
          lVar3 = this.heroData;
          if (lVar3 == null) throw; // [null/range check failed]
          if (lVar3.isSummon) goto LAB_1808d2e8a;
          uVar6 = HeroData.GetHeroSoundVoiceAgePitch(lVar3,0);
        }
        if (lVar2 != null) {
          FUN_180467590(lVar2,uVar6,0);
          lVar2 = this.heroAudioSources;
          if (lVar2 != null) {
            if (lVar2.Count <= targetTrack) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar3 = this.heroAudioSouceVolumn;
            lVar2 = *(int64 *)(lVar2._items + 32 + lVar5 * 8);
            if (lVar3 != null) {
              if (lVar3.summonLv <= targetTrack) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              fVar1 = *(float *)(lVar3.isSummon + 32 + lVar5 * 4);
              if (lVar2 != null) {
                AudioSource.set_volume
                          (lVar2,fVar1 * *(float *)(*(int64 *)(DAT_181d72d50 + 184) + 16),0);
                lVar2 = this.heroAudioSources;
                if (lVar2 != null) {
                  if (lVar2.Count <= targetTrack) {
                    ThrowHelper.ThrowArgumentOutOfRangeException(0);
                  }
                  lVar5 = *(int64 *)(lVar2._items + 32 + lVar5 * 8);
                  if (lVar5 != null) {
                    AudioSource.Play(lVar5,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000C52
    // RVA   : 0x8D3210   Offset: 0x8D2610   Length: 0x1453
    public void RefreshFollowUI()
    {
        var pStatics_2ee8 = *(int64*)(DAT_181d72ee8 + 184);
        float fVar1;
        bool cVar2;
        uint uVar3;
        bool cVar4;
        long lVar5;
        ulong uVar6;
        long lVar9;
        ulong uVar11;
        float fVar13;
        float fVar14;
        float fVar15;
        uint uVar16;
        uint uVar17;
        uint uVar18;
        float fVar19;
        ulong local_b8;
        float local_b0;
        ulong local_a8;
        float local_a0;
        ulong local_98;
        ulong uStack_90;
        uint local_88;
        uint uStack_84;
        uint uStack_80;
        uint32 uStack_7c;
        uVar6 = this.followUI;
        cVar4 = Object.op_Equality(uVar6,0,0);
        if (cVar4) {
          if ((((*pStatics_2ee8 == 0) ||
               (lVar5 = *(int64 *)(*pStatics_2ee8 + 56)) == null) ||
              (lVar5 = GameObject.get_transform(lVar5,0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"HeroFollowUI",0)) == null) goto LAB_1808d465e;
          uVar6 = Component.get_gameObject(lVar5,0);
          lVar5 = PlotController.LaBaFestivelResultTalkText;
          if (lVar5 == null) goto LAB_1808d465e;
          uVar11 = *(uint64 *)(lVar5 + 0x160);
          uVar6 = GlobalData.AddChild(uVar6,uVar11,0);
          this.followUI = uVar6;
          if (((this.followUI == null) ||
              (lVar5 = GameObject.get_transform(this.followUI,0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"DamageBar",0)) == null) goto LAB_1808d465e;
          uVar6 = Component.GetComponent(lVar5,DAT_181d94478);
          this.damageBarImage = uVar6;
          uVar6 = Component.GetComponent(lVar5,DAT_181d94f78);
          this.damageBarRect = uVar6;
          if (((this.followUI == null) ||
              (lVar5 = GameObject.get_transform(this.followUI,0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"ProtectIcon",0)) == null) goto LAB_1808d465e;
          uVar6 = Component.get_gameObject(lVar5,0);
          this.protectIconObj = uVar6;
          if (((this.followUI == null) ||
              (lVar5 = GameObject.get_transform(this.followUI,0)) == null) ||
             (lVar5 = Transform.Find(lVar5,"SummonIcon",0)) == null) goto LAB_1808d465e;
          uVar6 = Component.get_gameObject(lVar5,0);
          this.summonIconObj = uVar6;
          if (this.battleTeam == null) goto LAB_1808d465e;
          lVar5 = this.protectIconObj;
          if (this.battleTeam.ID == null) {
            if (lVar5 == null) goto LAB_1808d465e;
            plVar7 = (int64 *)GameObject.GetComponent(lVar5,DAT_181d71e80);
            puVar8 = (uint64 *)Color.get_green(&local_98,0);
            if (plVar7 == (int64 *)0) goto LAB_1808d465e;
            local_98 = *puVar8;
            uStack_90 = puVar8[1];
            (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_98,*(uint64 *)(*plVar7 + 0x2b0));
            if (this.summonIconObj == null) goto LAB_1808d465e;
            plVar7 = (int64 *)GameObject.GetComponent(this.summonIconObj,DAT_181d71e80);
            puVar8 = (uint64 *)Color.get_green(&local_98,0);
            if (plVar7 == (int64 *)0) goto LAB_1808d465e;
            local_98 = *puVar8;
            uStack_90 = puVar8[1];
            (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_98,*(uint64 *)(*plVar7 + 0x2b0));
            if (((this.followUI == null) ||
                (lVar5 = GameObject.get_transform(this.followUI,0)) == null) ||
               (lVar5 = Transform.Find(lVar5,"HpBar",0)) == null) goto LAB_1808d465e;
            plVar7 = (int64 *)Component.GetComponent(lVar5,DAT_181d94478);
            puVar8 = (uint64 *)Color.get_green(&local_98,0);
          }
          else {
            if (lVar5 == null) goto LAB_1808d465e;
            plVar7 = (int64 *)GameObject.GetComponent(lVar5,DAT_181d71e80);
            puVar8 = (uint64 *)Color.get_red(&local_98,0);
            if (plVar7 == (int64 *)0) goto LAB_1808d465e;
            local_98 = *puVar8;
            uStack_90 = puVar8[1];
            (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_98,*(uint64 *)(*plVar7 + 0x2b0));
            if (this.summonIconObj == null) goto LAB_1808d465e;
            plVar7 = (int64 *)GameObject.GetComponent(this.summonIconObj,DAT_181d71e80);
            puVar8 = (uint64 *)Color.get_red(&local_98,0);
            if (plVar7 == (int64 *)0) goto LAB_1808d465e;
            local_98 = *puVar8;
            uStack_90 = puVar8[1];
            (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_98,*(uint64 *)(*plVar7 + 0x2b0));
            if (((this.followUI == null) ||
                (lVar5 = GameObject.get_transform(this.followUI,0)) == null) ||
               (lVar5 = Transform.Find(lVar5,"HpBar",0)) == null) goto LAB_1808d465e;
            plVar7 = (int64 *)Component.GetComponent(lVar5,DAT_181d94478);
            puVar8 = (uint64 *)Color.get_red(&local_98,0);
          }
          if (plVar7 == (int64 *)0) goto LAB_1808d465e;
          local_98 = *puVar8;
          uStack_90 = puVar8[1];
          (**(code **)(*plVar7 + 0x2a8))(plVar7,&local_98,*(uint64 *)(*plVar7 + 0x2b0));
        }
        if (this.followUI == null) goto LAB_1808d465e;
        lVar5 = GameObject.get_transform(this.followUI,0);
        if (((this.hipPos == null) ||
            (lVar9 = GameObject.get_transform(this.hipPos,0)) == null) ||
           (puVar8 = (uint64 *)Transform.get_position(&local_b8,lVar9,0), lVar5 == null))
        goto LAB_1808d465e;
        local_a8 = *puVar8;
        local_a0 = *(float *)(puVar8 + 1);
        Transform.set_position(lVar5,&local_a8,0);
        if (this.heroData == null) goto LAB_1808d465e;
        if (this.heroData.isSummon) {
          if ((this.followUI == null) ||
             (lVar5 = GameObject.get_transform(this.followUI,0)) == null)
          goto LAB_1808d465e;
          puVar8 = (uint64 *)Transform.get_localPosition(&local_b8,lVar5,0);
          local_a8 = *puVar8;
          local_a0 = *(float *)(puVar8 + 1);
          lVar9 = *(int64 *)(*(int64 *)(DAT_181db07e0 + 184) + 32);
          if ((this.heroData == null) || (lVar9 == null)) goto LAB_1808d465e;
          uVar3 = this.heroData.summonID;
          if (lVar9.summonLv <= uVar3) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          local_b8 = lVar9.isSummon[uVar3];
          local_b0 = *(float *)(lVar9.isSummon + 40 + (int64)(int)uVar3 * 12);

          if (((lVar9 = PlotController.LaBaFestivelResultTalkText?.atAreaID) == null) ||
             (lVar9 = GameObject.get_transform(lVar9,0)) == null) goto LAB_1808d465e;
          pfVar10 = (float *)Transform.get_localScale(&local_98,lVar9,0);
          fVar13 = *pfVar10;
          local_b0 = fVar13 * local_b0 + local_a0;
          local_a8 = CONCAT44(fVar13 * local_b8._4_4_ + local_a8._4_4_,
                              fVar13 * (float)local_b8 + (float)local_a8);
          local_a0 = local_b0;
          Transform.set_localPosition(lVar5,&local_a8,0);
        }
        if (this.followUI == null) goto LAB_1808d465e;
        lVar5 = GameObject.get_transform(this.followUI,0);

        if ((((lVar9 = PlotController.LaBaFestivelResultTalkText?.atAreaID) == null) ||
            (lVar9 = GameObject.get_transform(lVar9,0)) == null) ||
           (puVar8 = (uint64 *)Transform.get_localScale(&local_98,lVar9,0), lVar5 == null))
        goto LAB_1808d465e;
        local_a8 = *puVar8;
        local_a0 = *(float *)(puVar8 + 1);
        Transform.set_localScale(lVar5,&local_a8,0);
        if (this.heroData == null) goto LAB_1808d465e;
        HeroData.SetHpBar(this.heroData,this.followUI,0);
        if (this.heroData == null) goto LAB_1808d465e;
        HeroData.SetMpBar(this.heroData,this.followUI,0);
        if (this.protectIconObj == null) goto LAB_1808d465e;
        cVar4 = GameObject.get_activeSelf(this.protectIconObj,0);
        if (this.heroData == null) goto LAB_1808d465e;
        cVar2 = this.heroData.fightProtectTarget;
        if (cVar4 != cVar2) {
          if (this.protectIconObj == null) goto LAB_1808d465e;
          GameObject.SetActive(this.protectIconObj,cVar2,0);
        }
        if (this.summonIconObj == null) goto LAB_1808d465e;
        cVar4 = GameObject.get_activeSelf(this.summonIconObj,0);
        if (this.heroData == null) goto LAB_1808d465e;
        cVar2 = this.heroData.isSummon;
        if (cVar4 != cVar2) {
          if (this.summonIconObj == null) goto LAB_1808d465e;
          GameObject.SetActive(this.summonIconObj,cVar2,0);
        }
        lVar5 = PlotController.LaBaFestivelResultTalkText;
        if (lVar5 == null) goto LAB_1808d465e;
        if (lVar5.belongHeroID == 3) {
          lVar5 = PlotController.LaBaFestivelResultTalkText;
          if (lVar5 == null) goto LAB_1808d465e;
          if (*(int *)(lVar5 + 0x124) == 10) {
            lVar5 = FUN_18046bb80(0);
            if (lVar5 == null) goto LAB_1808d465e;
            uVar6 = *(uint64 *)(lVar5 + 0x110);
            cVar4 = Object.op_Inequality(uVar6,0,0);
            if (cVar4) {
              lVar5 = FUN_18046bb80(0);
              if ((lVar5 == null) || (*(int64 *)(lVar5 + 0x110) == 0)) goto LAB_1808d465e;
              if (*(char *)(*(int64 *)(lVar5 + 0x110) + 56) != false) {
                lVar5 = FUN_18046bb80(0);
                if (((lVar5 == null) || (*(int64 *)(lVar5 + 0x110) == 0)) ||
                   (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 0x110) + 64)) == null)
                goto LAB_1808d465e;
                lVar5 = HeroData.GetNowActiveSkill(lVar5,0);
                if (lVar5 != null) {
                  lVar5 = FUN_18046bb80(0);
                  if (((lVar5 == null) || (*(int64 *)(lVar5 + 0x110) == 0)) ||
                     ((lVar5 = *(int64 *)(*(int64 *)(lVar5 + 0x110) + 64), lVar5 == null ||
                      ((lVar5 = HeroData.GetNowActiveSkill(lVar5,0), lVar5 == null ||
                       (lVar5 = KungfuSkillLvData.DataBase(lVar5,0)) == null))))) goto LAB_1808d465e;
                  if (2 < lVar5.equipUseSpeAddValue) {
                    lVar5 = FUN_18046bb80(0);
                    if ((((lVar5 == null) || (*(int64 *)(lVar5 + 0x110) == 0)) ||
                        (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 0x110) + 64)) == null) ||
                       ((lVar5 = HeroData.GetNowActiveSkill(lVar5,0), lVar5 == null ||
                        (lVar5 = KungfuSkillLvData.DataBase(lVar5,0)) == null))) goto LAB_1808d465e;
                    if (lVar5.bookExp == null) {
                      lVar5 = FUN_18046bb80(0);
                      if ((lVar5 == null) || (*(int64 *)(lVar5 + 0x110) == 0)) goto LAB_1808d465e;
                      if (*(int64 *)(*(int64 *)(lVar5 + 0x110) + 88) ==
                          this.battleTeam) goto LAB_1808d3f26;
        LAB_1808d41f0:
                      lVar5 = FUN_18046bb80(0);
                      if ((lVar5 == null) || (*(int64 *)(lVar5 + 0x208) == 0)) goto LAB_1808d465e;
                      cVar4 = FUN_18181ea10(*(int64 *)(lVar5 + 0x208),this.mapGrid,
                                            DAT_181d8b030);
                      if (cVar4) {
                        lVar5 = this.nowOnAttackSkill;
                        lVar9 = FUN_18046bb80(0);
                        if (((lVar9 != null) && (lVar9.livingSkillFocus != null)) &&
                           (lVar9 = *(int64 *)(lVar9.livingSkillFocus + 64)) != null) {
                          lVar9 = HeroData.GetNowActiveSkill(lVar9,0);
                          if (lVar5 == lVar9) {
                            return;
                          }
                          lVar5 = FUN_18046bb80(0);
                          if (((lVar5 != null) && (*(int64 *)(lVar5 + 0x110) != 0)) &&
                             (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 0x110) + 64)) != null) {
                            uVar6 = HeroData.GetNowActiveSkill(lVar5,0);
                            this.nowOnAttackSkill = uVar6;
                            lVar5 = FUN_18046bb80(0);
                            lVar9 = FUN_18046bb80(0);
                            if (lVar9 != null) {
                              uVar6 = lVar9.livingSkillFocus;
                              lVar9 = FUN_18046bb80(0);
                              if ((((lVar9 != null) && (lVar9.livingSkillFocus != null)) &&
                                  (lVar9 = *(int64 *)(lVar9.livingSkillFocus + 64)) != null
                                  ) && (uVar11 = HeroData.GetNowActiveSkill(lVar9,0), lVar5 != null)) {
                                fVar13 = (float)BattleController.CountBaseDamage
                                                          (lVar5,uVar6,uVar11,this,1,0);
                                lVar5 = this.damageBarImage;
                                lVar9 = this.heroData;
                                if (fVar13 <= 0.0) {
                                  if (lVar9 == null) goto LAB_1808d465e;
                                  fVar15 = lVar9.realMaxHp - lVar9.hp;
                                  fVar14 = -fVar13;
                                }
                                else {
                                  if (lVar9 == null) goto LAB_1808d465e;
                                  fVar15 = lVar9.hp;
                                  fVar14 = fVar13;
                                }
                                fVar15 = (float)Mathf.Min(fVar14,fVar15,0);
                                if ((this.heroData != null) && (lVar5 != null)) {
                                  Image.set_fillAmount
                                            (lVar5,fVar15 / *(float *)(this.heroData +
                                                                      0x17c),0);
                                  lVar5 = this.damageBarRect;
                                  if (lVar5 != null) {
                                    puVar12 = (uint32 *)RectTransform.get_rect(&local_98,lVar5,0);
                                    local_88 = *puVar12;
                                    uStack_84 = puVar12[1];
                                    uStack_80 = puVar12[2];
                                    uStack_7c = puVar12[3];
                                    fVar15 = (float)FUN_180d995b0(&local_88,0);
                                    lVar9 = this.heroData;
                                    if (lVar9 != null) {
                                      fVar14 = lVar9.hp;
                                      fVar1 = lVar9.maxhp;
                                      if (fVar13 <= 0.0) {
                                        if (this.damageBarImage == null) goto LAB_1808d465e;
                                        fVar19 = *(float *)(this.damageBarImage + 244);
                                      }
                                      else {
                                        fVar19 = 0.0;
                                      }
                                      if (this.damageBarRect != null) {
                                        puVar8 = (uint64 *)
                                                 Transform.get_localPosition
                                                           (&local_98,this.damageBarRect,0);
                                        local_b0 = 0.0;
                                        local_a0 = 0.0;
                                        local_a8 = CONCAT44((int)((uint64)*puVar8 >> 32),
                                                            ((fVar14 / fVar1 - 0.5) + fVar19) * fVar15);
                                        Transform.set_localPosition(lVar5,&local_a8,0);
                                        plVar7 = this.damageBarImage;
                                        local_98 = 0;
                                        uStack_90 = 0;
                                        if (fVar13 <= 0.0) {
                                          uVar18 = 0;
                                          uVar17 = 0x3f000000;
                                          uVar16 = 0;
                                        }
                                        else {
                                          uVar16 = 0x3e4ccccd;
                                          uVar18 = 0x3e4ccccd;
                                          uVar17 = 0x3e4ccccd;
                                        }
                                        FUN_1809dcfa0(&local_98,uVar16,uVar17,uVar18,0,0);
                                        if (plVar7 != (int64 *)0) {
                                          (**(code **)(*plVar7 + 0x2a8))
                                                    (plVar7,&local_98,*(uint64 *)(*plVar7 + 0x2b0));
                                          uVar6 = DOTweenModuleUI.DOFade
                                                            (this.damageBarImage,0x3f4ccccd,
                                                             0x3f19999a,0);
                                          TweenSettingsExtensions.SetLoops
                                                    (uVar6,0xffffffff,1,DAT_181dc13d0);
                                          this.damageBarShown = 1;
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
                        goto LAB_1808d465e;
                      }
                    }
                    else {
        LAB_1808d3f26:
                      lVar5 = FUN_18046bb80(0);
                      if ((((lVar5 == null) || (*(int64 *)(lVar5 + 0x110) == 0)) ||
                          (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 0x110) + 64)) == null) ||
                         ((lVar5 = HeroData.GetNowActiveSkill(lVar5,0), lVar5 == null ||
                          (lVar5 = KungfuSkillLvData.DataBase(lVar5,0)) == null)))
                      goto LAB_1808d465e;
                      if (lVar5.bookExp == 1) {
                        lVar5 = FUN_18046bb80(0);
                        if ((lVar5 == null) || (*(int64 *)(lVar5 + 0x110) == 0)) goto LAB_1808d465e;
                        if (*(int64 *)(*(int64 *)(lVar5 + 0x110) + 88) ==
                            this.battleTeam) goto LAB_1808d41f0;
                      }
                      lVar5 = FUN_18046bb80(0);
                      if ((((lVar5 == null) || (*(int64 *)(lVar5 + 0x110) == 0)) ||
                          (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 0x110) + 64)) == null) ||
                         ((lVar5 = HeroData.GetNowActiveSkill(lVar5,0), lVar5 == null ||
                          (lVar5 = KungfuSkillLvData.DataBase(lVar5,0)) == null)))
                      goto LAB_1808d465e;
                      if (lVar5.bookExp == 2) {
                        lVar5 = FUN_18046bb80(0);
                        if (lVar5 == null) goto LAB_1808d465e;
                        uVar6 = *(uint64 *)(lVar5 + 0x110);
                        cVar4 = Object.op_Equality(uVar6,this,0);
                        if (cVar4) goto LAB_1808d41f0;
                      }
                      lVar5 = FUN_18046bb80(0);
                      if ((((lVar5 == null) || (*(int64 *)(lVar5 + 0x110) == 0)) ||
                          (lVar5 = *(int64 *)(*(int64 *)(lVar5 + 0x110) + 64)) == null) ||
                         ((lVar5 = HeroData.GetNowActiveSkill(lVar5,0), lVar5 == null ||
                          (lVar5 = KungfuSkillLvData.DataBase(lVar5,0)) == null)))
                      goto LAB_1808d465e;
                      if (lVar5.bookExp == 3) {
                        lVar5 = FUN_18046bb80(0);
                        if ((lVar5 == null) || (*(int64 *)(lVar5 + 0x110) == 0)) goto LAB_1808d465e;
                        if (*(int64 *)(*(int64 *)(lVar5 + 0x110) + 88) ==
                            this.battleTeam) {
                          lVar5 = FUN_18046bb80(0);
                          if (lVar5 == null) goto LAB_1808d465e;
                          uVar6 = *(uint64 *)(lVar5 + 0x110);
                          cVar4 = Object.op_Inequality(uVar6,this,0);
                          if (cVar4) goto LAB_1808d41f0;
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
        this.nowOnAttackSkill = 0;
        if (this.damageBarShown) {
          this.damageBarShown = 0;
          if (this.damageBarImage == null) {
        LAB_1808d465e:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          Image.set_fillAmount(this.damageBarImage,0,0);
          uVar6 = this.damageBarImage;
          DOTween.Kill(uVar6,0,0);
        }
    }

    // Token : 0x6000C53
    // RVA   : 0x8D5030   Offset: 0x8D4430   Length: 0x13F
    public void Talk(string _text, float _lifeTime)
    {
        uint uVar1;
        ulong uVar2;
        long lVar3;
        bool cVar4;
        long lVar5;
        if ((_text == null) || (cVar4 = FUN_18171eb50(_text,"",0), cVar4)) {
          return;
        }
        lVar5 = this.heroData;
        if (lVar5 != null) {
          if (lVar5.isSummon) {
            return;
          }
          if (!DAT_181e9acd9) {
            il2cpp_runtime_class_init(&DAT_181d761e8);
            DAT_181e9acd9 = true;
            lVar5 = this.heroData;
          }
          uVar2 = this.mouthPos;
          lVar3 = **(int64 **)(DAT_181d761e8 + 184);
          if (lVar5 != null) {
            uVar1 = lVar5.heroID;
            lVar5 = FUN_18046bb80(0);
            if ((lVar5 != null) && (lVar3 != null)) {
              HeroLittleTalkController.HeroTalk
                        (lVar3,uVar2,_text,_lifeTime,uVar1,lVar5.totalAttri,2,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000C54
    // RVA   : 0x8CE620   Offset: 0x8CDA20   Length: 0x161
    public void ChangeFaceDirection(bool right, bool forceBuilding)
    {
        long lVar1;
        long lVar2;
        uint local_18;
        uint uStack_14;
        uint uStack_10;
        uint32 uStack_c;
        if (!forceBuilding) {
          if (this.heroData == null) throw; // [null/range check failed]
          if (this.heroData.isSummon) {
            lVar2 = FUN_18046c100(0);
            if ((((lVar2 == null) || (this.heroData == null)) ||
                (*(int64 *)(lVar2 + 0x180) == 0)) ||
               (lVar2 = FUN_1817da420(*(int64 *)(lVar2 + 0x180),
                                      this.heroData.summonID,DAT_181dbea20)
               , lVar2 == null)) throw; // [null/range check failed]
            if (*(char *)(lVar2 + 64) != false) {
              return;
            }
          }
        }
        if (this.skeleton != null) {
          lVar2 = Component.get_transform(this.skeleton,0);
          if (!right) {
            lVar1 = *(int64 *)(DAT_181d73d40 + 184);
            local_18 = *(uint32 *)(lVar1 + 0x690);
            uStack_14 = *(uint32 *)(lVar1 + 0x694);
            uStack_10 = *(uint32 *)(lVar1 + 0x698);
            uStack_c = *(uint32 *)(lVar1 + 0x69c);
          }
          else {
            puVar3 = (uint32 *)Quaternion.get_identity(&local_18,0);
            local_18 = *puVar3;
            uStack_14 = puVar3[1];
            uStack_10 = puVar3[2];
            uStack_c = puVar3[3];
          }
          if (lVar2 != null) {
            Transform.set_localRotation(lVar2,&local_18,0);
            return;
          }
        }
    }

    // Token : 0x6000C55
    // RVA   : 0x8D0AA0   Offset: 0x8CFEA0   Length: 0x822
    public void EnterBattleField(GridUnitData bornGrid)
    {
        uint uVar1;
        ulong uVar2;
        int iVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        uint[] local_res10 = new uint[4];
        ulong local_res20;
        ulong local_f8;
        ulong local_e8;
        float local_e0;
        ulong local_d8;
        ulong uStack_d0;
        ulong local_c8;
        ulong uStack_c0;
        ulong local_b8;
        ulong uStack_b0;
        ulong local_a8;
        float local_90;
        ulong local_88;
        float local_80;
        local_res10[0] = 0;
        BattleUnit.Init(this,0);
        if (bornGrid != null) {
          iVar3 = *(int *)(bornGrid + 40);
          lVar4 = PlotController.LaBaFestivelResultTalkText;
          if ((lVar4 != null) && (lVar4 = *(int64 *)(lVar4 + 24)) != null) {
            BattleUnit.ChangeFaceDirection
                      (this,(float)iVar3 < (float)*(int *)(lVar4 + 32) * 0.5,1,0);
            if (this.skeleton != null) {
              lVar4 = SkeletonAnimation.get_AnimationState(this.skeleton,0);
              if (lVar4 != null) {
                AnimationState.SetAnimation(lVar4,0,"idle",1,0);
                if (this.heroData != null) {
                  if (!this.heroData.isSummon) {
                    if (this.skeleton == null) throw; // [null/range check failed]
                    lVar4 = SkeletonAnimation.get_AnimationState(this.skeleton,0);
                    local_res10[0] = FUN_180d96040(0,4);
                    uVar5 = Int32.ToString(local_res10,0);
                    uVar5 = String.Concat("entrance_",uVar5,0);
                    if (lVar4 == null) throw; // [null/range check failed]
                    AnimationState.SetAnimation(lVar4,1,uVar5,0,0);
                    if (this.skeleton == null) throw; // [null/range check failed]
                    lVar4 = SkeletonAnimation.get_AnimationState(this.skeleton,0);
                    if (lVar4 == null) throw; // [null/range check failed]
                    AnimationState.AddEmptyAnimation(lVar4,1,0x3e4ccccd,0,0);
                    lVar4 = Component.get_transform(this,0);
                    lVar6 = GridUnitData.get_GridObj(bornGrid,0);
                    if (lVar6 == null) throw; // [null/range check failed]
                    lVar6 = GameObject.get_transform(lVar6,0);
                    if (lVar6 == null) throw; // [null/range check failed]
                    puVar7 = (uint64 *)Transform.get_localPosition(&local_88,lVar6,0);
                    uVar5 = *puVar7;
                    local_e0 = *(float *)(puVar7 + 1);
                    puVar7 = (uint64 *)Vector3.get_up(&local_d8,0);
                    local_90 = *(float *)(puVar7 + 1);
                    local_88 = *puVar7;
                    local_f8 = CONCAT44((float)((uint64)local_88 >> 32) * 5.0 +
                                        (float)((uint64)uVar5 >> 32),
                                        (float)local_88 * 5.0 + (float)uVar5);
                    local_e8 = uVar5;
                    local_80 = local_90;
                    if (lVar4 == null) throw; // [null/range check failed]
                    local_e8 = local_f8;
                    local_e0 = local_90 * 5.0 + local_e0;
                    Transform.set_localPosition(lVar4,&local_e8,0);
                    BattleUnit.EnterGrid(this,bornGrid,0,0,0);
                    if (this.heroData == null) throw; // [null/range check failed]
                    iVar3 = this.heroData.heroForceLv;
                    lVar4 = GameController.lockObj;
                    if (((lVar4 == null) || (this.heroData == null)) ||
                       (lVar4 = *(int64 *)(lVar4 + 56)) == null) throw; // [null/range check failed]
                    uVar1 = this.heroData.heroForceLv;
                    if (*(uint32 *)(lVar4 + 24) <= uVar1) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar4 = lVar4[uVar1];
                    if (lVar4 == null) throw; // [null/range check failed]
                    uVar5 = *(uint64 *)(lVar4 + 24);
                    uVar2 = *(uint64 *)(lVar4 + 32);
                    if (this.weaponLight == null) {
        LAB_1808d12bd:
                          // WARNING: Subroutine does not return
                      FUN_1800d6620();
                    }
                    local_res20 = FUN_1804651e0(this.weaponLight,0);
                    puVar7 = (uint64 *)
                             MinMaxCurve.op_Implicit(&local_88,((float)iVar3 * 0.1 + 0.5) * 40.0,0);
                    local_d8 = *puVar7;
                    uStack_d0 = puVar7[1];
                    local_c8 = puVar7[2];
                    uStack_c0 = puVar7[3];
                    MainModule.set_startSizeX(&local_res20,&local_d8,0);
                    puVar7 = (uint64 *)MinMaxCurve.op_Implicit(&local_88);
                    local_d8 = *puVar7;
                    uStack_d0 = puVar7[1];
                    local_c8 = puVar7[2];
                    uStack_c0 = puVar7[3];
                    MainModule.set_startSizeY(&local_res20,&local_d8,0);
                    puVar7 = (uint64 *)MinMaxCurve.op_Implicit(&local_88);
                    local_d8 = *puVar7;
                    uStack_d0 = puVar7[1];
                    local_c8 = puVar7[2];
                    uStack_c0 = puVar7[3];
                    MainModule.set_startLifetime(&local_res20,&local_d8,0);
                    local_d8 = uVar5;
                    uStack_d0 = uVar2;
                    puVar7 = (uint64 *)MinMaxGradient.op_Implicit(&local_88,&local_d8,0);
                    local_d8 = *puVar7;
                    uStack_d0 = puVar7[1];
                    local_c8 = puVar7[2];
                    uStack_c0 = puVar7[3];
                    local_b8 = puVar7[4];
                    uStack_b0 = puVar7[5];
                    local_a8 = puVar7[6];
                    MainModule.set_startColor(&local_res20,&local_d8,0);
                    if (this.weaponLight == null) goto LAB_1808d12bd;
                    ParticleSystem.Play();
                  }
                  else {
                    BattleUnit.EnterGrid(this,bornGrid,0,1,0);
                  }
                  if (this.battleTeam != null) {
                    if (this.battleTeam.ID == null) {
                      lVar4 = Component.get_transform(this);
                      if (lVar4 == null) throw; // [null/range check failed]
                      lVar4 = Transform.Find(lVar4,"HighLight",0);
                      if (lVar4 == null) throw; // [null/range check failed]
                      lVar4 = Transform.Find(lVar4,"Sprite",0);
                      if (lVar4 == null) throw; // [null/range check failed]
                      lVar4 = Component.GetComponent(lVar4,DAT_181d95df8);
                      puVar7 = (uint64 *)Color.get_green(&local_d8,0);
                    }
                    else {
                      lVar4 = Component.get_transform(this);
                      if (lVar4 == null) throw; // [null/range check failed]
                      lVar4 = Transform.Find(lVar4,"HighLight",0);
                      if (lVar4 == null) throw; // [null/range check failed]
                      lVar4 = Transform.Find(lVar4,"Sprite",0);
                      if (lVar4 == null) throw; // [null/range check failed]
                      lVar4 = Component.GetComponent(lVar4,DAT_181d95df8);
                      puVar7 = (uint64 *)Color.get_red(&local_d8,0);
                    }
                    uVar5 = *puVar7;
                    uVar2 = puVar7[1];
                    local_d8 = uVar5;
                    uStack_d0 = uVar2;
                    puVar7 = (uint64 *)GlobalData.SetColorAlpha(&local_88,&local_d8,0x3f19999a,0);
                    if (lVar4 != null) {
                      local_d8 = *puVar7;
                      uStack_d0 = puVar7[1];
                      SpriteRenderer.set_color(lVar4,&local_d8,0);
                      lVar4 = GameController.difficultyExtraPoint;
                      if ((lVar4 != null) && (lVar4 = *(int64 *)(lVar4 + 16)) != null) {
                        iVar3 = PlayerPrefDictionary.GetInt(lVar4,"FightViewFollow",0);
                        if (iVar3 == 1) {
                          lVar4 = PlotController.LaBaFestivelResultTalkText;
                          uVar5 = GridUnitData.get_GridObj(bornGrid,0);
                          if (lVar4 == null) throw; // [null/range check failed]
                          BattleController.FocusOnTarget(lVar4,uVar5,0);
                        }
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

    // Token : 0x6000C56
    // RVA   : 0x8D47B0   Offset: 0x8D3BB0   Length: 0x1F8
    public void SetHighLightAnim(bool active)
    {
        long lVar1;
        ulong uVar2;
        ulong local_18;
        uint uStack_10;
        uint32 uStack_c;
        lVar1 = Component.get_transform(this,0);
        if (!active) {
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"HighLight",0);
            if (lVar1 != null) {
              uVar2 = Transform.Find(lVar1,"Sprite",0);
              DOTween.Kill(uVar2,0,0);
              lVar1 = Component.get_transform(this,0);
              if (lVar1 != null) {
                lVar1 = Transform.Find(lVar1,"HighLight",0);
                if (lVar1 != null) {
                  lVar1 = Transform.Find(lVar1,"Sprite",0);
                  puVar3 = (uint64 *)Quaternion.get_identity(&local_18,0);
                  if (lVar1 != null) {
                    local_18 = *puVar3;
                    uStack_10 = *(uint32 *)(puVar3 + 1);
                    uStack_c = *(uint32 *)((int64)puVar3 + 12);
                    Transform.set_localRotation(lVar1,&local_18,0);
                    return;
                  }
                }
              }
            }
          }
        }
        else if (lVar1 != null) {
          lVar1 = Transform.Find(lVar1,"HighLight",0);
          if (lVar1 != null) {
            uVar2 = Transform.Find(lVar1,"Sprite",0);
            uStack_10 = 0x43b40000;
            local_18 = 0;
            uVar2 = ShortcutExtensions.DOLocalRotate(uVar2,&local_18,0x3f800000,1,0);
            uVar2 = TweenSettingsExtensions.SetLoops(uVar2,0xffffffff,0,DAT_181dc1458);
            TweenSettingsExtensions.SetEase(uVar2,1,DAT_181dc0f10);
            return;
          }
        }
    }

    // Token : 0x6000C57
    // RVA   : 0x8D4A50   Offset: 0x8D3E50   Length: 0x1F0
    public void ShowFocusAnim()
    {
        var pStatics = *(int64*)(DAT_181db07e0 + 184);
        long lVar1;
        ulong uVar2;
        ulong uVar3;
        float fVar4;
        ulong local_28;
        float local_20;
        lVar1 = Component.get_transform(this,0);
        if (lVar1 != null) {
          uVar2 = Transform.Find(lVar1,"HighLight",0);
          DOTween.Kill(uVar2,0,0);
          lVar1 = Component.get_transform(this,0);
          if (lVar1 != null) {
            lVar1 = Transform.Find(lVar1,"HighLight",0);
            local_28 = BattleUnit.highLightScale;
            local_20 = *(float *)(pStatics + 20);
            fVar4 = local_20 * 2.0;
            uVar2 = CONCAT44((float)((uint64)local_28 >> 32) * 2.0,(float)local_28 * 2.0);
            if (lVar1 != null) {
              local_28 = uVar2;
              local_20 = fVar4;
              Transform.set_localScale(lVar1,&local_28,0);
              lVar1 = Component.get_transform(this,0);
              if (lVar1 != null) {
                uVar3 = Transform.Find(lVar1,"HighLight",0);
                local_20 = *(float *)(pStatics + 20);
                local_28 = BattleUnit.highLightScale;
                uVar2 = ShortcutExtensions.DOScale(uVar3,&local_28,0x3f000000,0,uVar2,fVar4);
                TweenSettingsExtensions.SetEase(uVar2,27,DAT_181dc1128);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000C58
    // RVA   : 0x8D4EC0   Offset: 0x8D42C0   Length: 0x15B
    public void ShowWeaponLight(float size, float time, Color color)
    {
        void BattleUnit.ShowWeaponLight
                     (int64 this,float size,uint32 time,uint32 *color)
        {
        uint32 *puVar1;
        uint64 *puVar2;
        uint64 local_res8;
        uint32 local_c8;
        uint32 uStack_c4;
        uint32 uStack_c0;
        uint32 uStack_bc;
        uint32 local_b8;
        uint32 uStack_b4;
        uint32 uStack_b0;
        uint32 uStack_ac;
        uint64 local_a8;
        uint64 uStack_a0;
        uint64 local_98;
        uint64 uStack_90;
        uint32 local_88;
        uint32 uStack_84;
        uint32 uStack_80;
        uint32 uStack_7c;
        uint64 local_78;
        uint8 local_68 [96];
        if (this.weaponLight != null) {
          local_res8 = FUN_1804651e0(this.weaponLight,0);
          puVar1 = (uint32 *)MinMaxCurve.op_Implicit(&local_a8,size * 40.0,0);
          local_c8 = *puVar1;
          uStack_c4 = puVar1[1];
          uStack_c0 = puVar1[2];
          uStack_bc = puVar1[3];
          local_b8 = puVar1[4];
          uStack_b4 = puVar1[5];
          uStack_b0 = puVar1[6];
          uStack_ac = puVar1[7];
          MainModule.set_startSizeX(&local_res8,&local_c8,0);
          puVar1 = (uint32 *)MinMaxCurve.op_Implicit(&local_a8,size + size,0);
          local_c8 = *puVar1;
          uStack_c4 = puVar1[1];
          uStack_c0 = puVar1[2];
          uStack_bc = puVar1[3];
          local_b8 = puVar1[4];
          uStack_b4 = puVar1[5];
          uStack_b0 = puVar1[6];
          uStack_ac = puVar1[7];
          MainModule.set_startSizeY(&local_res8,&local_c8,0);
          puVar1 = (uint32 *)MinMaxCurve.op_Implicit(&local_a8,time,0);
          local_c8 = *puVar1;
          uStack_c4 = puVar1[1];
          uStack_c0 = puVar1[2];
          uStack_bc = puVar1[3];
          local_b8 = puVar1[4];
          uStack_b4 = puVar1[5];
          uStack_b0 = puVar1[6];
          uStack_ac = puVar1[7];
          MainModule.set_startLifetime(&local_res8,&local_c8,0);
          local_c8 = *color;
          uStack_c4 = color[1];
          uStack_c0 = color[2];
          uStack_bc = color[3];
          puVar2 = (uint64 *)MinMaxGradient.op_Implicit(local_68,&local_c8,0);
          local_a8 = *puVar2;
          uStack_a0 = puVar2[1];
          local_98 = puVar2[2];
          uStack_90 = puVar2[3];
          local_88 = *(uint32 *)(puVar2 + 4);
          uStack_84 = *(uint32 *)((int64)puVar2 + 36);
          uStack_80 = *(uint32 *)(puVar2 + 5);
          uStack_7c = *(uint32 *)((int64)puVar2 + 44);
          local_78 = puVar2[6];
          MainModule.set_startColor(&local_res8,&local_a8,0);
          if (this.weaponLight != null) {
            ParticleSystem.Play(this.weaponLight,0);
            return;
          }
        }
    }

    // Token : 0x6000C59
    // RVA   : 0x8D2A50   Offset: 0x8D1E50   Length: 0x144
    public void LeaveBattleField()
    {
        ulong uVar1;
        bool cVar2;
        if (this.mapGrid != null) {
          BattleUnit.SetDownObstacleNeedRefresh(this,0);
          if (this.mapGrid == null) goto LAB_1808d2b8f;
          GridUnitData.OnLeave(this.mapGrid,0);
          this.mapGrid = 0;
        }
        uVar1 = this.followUI;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          uVar1 = this.followUI;
          Object.Destroy(uVar1,0);
        }
        uVar1 = this.actionBarUnit;
        cVar2 = Object.op_Inequality(uVar1,0,0);
        if (cVar2) {
          if (this.actionBarUnit == null) {
        LAB_1808d2b8f:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          uVar1 = Component.get_gameObject(this.actionBarUnit,0);
          Object.Destroy(uVar1,0);
        }
    }

    // Token : 0x6000C5A
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    private void UseSkill()
    {
    }

    // Token : 0x6000C5B
    // RVA   : 0x245810   Offset: 0x244C10   Length: 0x3
    private void AcceptSkillResult()
    {
    }

    // Token : 0x6000C5C
    // RVA   : 0x8D1F10   Offset: 0x8D1310   Length: 0x5B
    public SkillTargetType GetSkillTargetType()
    {
        long lVar1;
        if (this.heroData != null) {
          lVar1 = HeroData.GetNowActiveSkill(this.heroData,0);
          if (lVar1 == null) {
            return 1;
          }
          if (this.heroData != null) {
            lVar1 = HeroData.GetNowActiveSkill(this.heroData,0);
            if (lVar1 != null) {
              lVar1 = KungfuSkillLvData.DataBase(lVar1,0);
              if (lVar1 != null) {
                return *(uint32 *)(lVar1 + 28);
              }
            }
          }
        }
    }

    // Token : 0x6000C5D
    // RVA   : 0x8D5300   Offset: 0x8D4700   Length: 0x5FF
    public void UseMedFood(ItemData targetItem, HeroData sourceHero)
    {
        float fVar1;
        ulong uVar2;
        ulong uVar4;
        long lVar5;
        float[] local_res8 = new float[2];
        uint uVar7;
        ulong uVar6;
        uint local_48;
        uint uStack_44;
        uint uStack_40;
        uint32 uStack_3c;
        local_res8[0] = 0.0;
        if ((this.heroData != null) &&
           (HeroData.UseMedFood(this.heroData,targetItem,1,1,sourceHero,0),
           uVar7 = (uint32)((uint64)sourceHero >> 32), targetItem != null)) {
          uVar2 = ItemData.Name(targetItem,1,0);
          uVar2 = String.Concat("服用",uVar2,0);
          puVar3 = (uint32 *)Color.get_yellow(&local_48,0);
          local_48 = *puVar3;
          uStack_44 = puVar3[1];
          uStack_40 = puVar3[2];
          uStack_3c = puVar3[3];
          uVar4 = CONCAT44(uVar7,24);
          BattleUnit.ShowTextOnHead(this,uVar2,&local_48,18,uVar4,"UIAtlas",0,0,0);
          uVar7 = (uint32)((uint64)uVar4 >> 32);
          if (this.heroData != null) {
            uVar2 = HeroData.Name(this.heroData,1,0);
            uVar4 = ItemData.Name(targetItem,1,0);
            uVar2 = String.Format("{0}服用了{1}",uVar2,uVar4,0);
            if ((*(int64 *)(targetItem + 104) != 0) &&
               (lVar5 = MedFoodData.GetChangeHeroStateData(*(int64 *)(targetItem + 104),0)) != null)
            {
              if (*(float *)(lVar5 + 16) != 0.0) {
                if ((*(int64 *)(targetItem + 104) == 0) ||
                   (lVar5 = MedFoodData.GetChangeHeroStateData(*(int64 *)(targetItem + 104),0),
                   lVar5 == null)) throw; // [null/range check failed]
                fVar1 = *(float *)(lVar5 + 16);
                if (this.heroData == null) throw; // [null/range check failed]
                local_res8[0] = (float)HeroData.GetMedResist(this.heroData,0);
                local_res8[0] = local_res8[0] * fVar1;
                uVar4 = Single.ToString(local_res8,"+0;-0;0",0);
                uVar4 = String.Concat("生命",uVar4,0);
                if ((*(int64 *)(targetItem + 104) == 0) ||
                   (lVar5 = MedFoodData.GetChangeHeroStateData(*(int64 *)(targetItem + 104),0),
                   lVar5 == null)) throw; // [null/range check failed]
                if (*(float *)(lVar5 + 16) <= 0.0) {
                  puVar3 = (uint32 *)Color.get_red(&local_48,0);
                }
                else {
                  puVar3 = (uint32 *)Color.get_green();
                }
                local_48 = *puVar3;
                uStack_44 = puVar3[1];
                uStack_40 = puVar3[2];
                uStack_3c = puVar3[3];
                uVar6 = CONCAT44(uVar7,24);
                BattleUnit.ShowTextOnHead(this,uVar4,&local_48,18,uVar6,"UIAtlas",0,0,0);
                uVar7 = (uint32)((uint64)uVar6 >> 32);
                uVar2 = String.Concat(uVar2,"，",uVar4,0);
              }
              if ((*(int64 *)(targetItem + 104) != 0) &&
                 (lVar5 = MedFoodData.GetChangeHeroStateData(*(int64 *)(targetItem + 104),0), lVar5 != null
                 )) {
                if (*(float *)(lVar5 + 24) != 0.0) {
                  if ((*(int64 *)(targetItem + 104) == 0) ||
                     (lVar5 = MedFoodData.GetChangeHeroStateData(*(int64 *)(targetItem + 104),0),
                     lVar5 == null)) throw; // [null/range check failed]
                  fVar1 = *(float *)(lVar5 + 24);
                  if (this.heroData == null) throw; // [null/range check failed]
                  local_res8[0] = (float)HeroData.GetMedResist(this.heroData,0);
                  local_res8[0] = local_res8[0] * fVar1;
                  uVar4 = Single.ToString(local_res8,"+0;-0;0",0);
                  uVar4 = String.Concat("内力",uVar4,0);
                  if ((*(int64 *)(targetItem + 104) == 0) ||
                     (lVar5 = MedFoodData.GetChangeHeroStateData(*(int64 *)(targetItem + 104),0),
                     lVar5 == null)) throw; // [null/range check failed]
                  if (*(float *)(lVar5 + 24) <= 0.0) {
                    puVar3 = (uint32 *)Color.get_magenta(&local_48,0);
                  }
                  else {
                    puVar3 = (uint32 *)Color.get_blue();
                  }
                  local_48 = *puVar3;
                  uStack_44 = puVar3[1];
                  uStack_40 = puVar3[2];
                  uStack_3c = puVar3[3];
                  uVar6 = CONCAT44(uVar7,24);
                  BattleUnit.ShowTextOnHead(this,uVar4,&local_48,18,uVar6,"UIAtlas",0,0,0);
                  uVar7 = (uint32)((uint64)uVar6 >> 32);
                  uVar2 = String.Concat(uVar2,"，",uVar4,0);
                }
                if ((*(int64 *)(targetItem + 104) != 0) &&
                   (lVar5 = MedFoodData.GetChangeHeroStateData(*(int64 *)(targetItem + 104),0),
                   lVar5 != null)) {
                  if (*(float *)(lVar5 + 32) != 0.0) {
                    if ((*(int64 *)(targetItem + 104) == 0) ||
                       (lVar5 = MedFoodData.GetChangeHeroStateData(*(int64 *)(targetItem + 104),0),
                       lVar5 == null)) throw; // [null/range check failed]
                    fVar1 = *(float *)(lVar5 + 32);
                    if (this.heroData == null) throw; // [null/range check failed]
                    local_res8[0] = (float)HeroData.GetMedResist(this.heroData,0);
                    local_res8[0] = local_res8[0] * fVar1;
                    uVar4 = Single.ToString(local_res8,"+0;-0;0",0);
                    uVar4 = String.Concat("体力",uVar4,0);
                    if ((*(int64 *)(targetItem + 104) == 0) ||
                       (lVar5 = MedFoodData.GetChangeHeroStateData(*(int64 *)(targetItem + 104),0),
                       lVar5 == null)) throw; // [null/range check failed]
                    puVar3 = (uint32 *)Color.get_yellow(*(uint32 *)(lVar5 + 32),0);
                    local_48 = *puVar3;
                    uStack_44 = puVar3[1];
                    uStack_40 = puVar3[2];
                    uStack_3c = puVar3[3];
                    BattleUnit.ShowTextOnHead
                              (this,uVar4,&local_48,18,CONCAT44(uVar7,24),"UIAtlas",0,0,0);
                    uVar2 = String.Concat(uVar2,"，",uVar4,0);
                  }
                  lVar5 = *(int64 *)(*(int64 *)(DAT_181db0260 + 184) + 80);
                  uVar2 = String.Concat(uVar2,"。",0);
                  if (lVar5 != null) {
                    BattleController.AddInfoText(lVar5,uVar2,1,0);
                    return;
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000C5E
    // RVA   : 0x8D3050   Offset: 0x8D2450   Length: 0x1B0
    public void RecoverPartPosture(float recoverRate)
    {
        float fVar1;
        long lVar2;
        long lVar3;
        uint uVar4;
        long lVar5;
        float fVar6;
        uint uVar7;
        lVar3 = this.heroData;
        uVar4 = 0;
        if (lVar3 != null) {
          lVar5 = 32;
          while ((lVar3.partPosture != null &&
                 (lVar2 = *(int64 *)(lVar3.partPosture + 16)) != null)) {
            if (*(int *)(lVar2 + 24) <= (int)uVar4) {
              return;
            }
            if (((lVar3 == null) || (lVar3.partPosture == null)) ||
               (lVar2 = *(int64 *)(lVar3.partPosture + 16)) == null) break;
            if (*(uint32 *)(lVar2 + 24) <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
              lVar3 = this.heroData;
            }
            fVar1 = *(float *)(lVar5 + *(int64 *)(lVar2 + 16));
            if (((lVar3 == null) || (lVar3.partPosture == null)) ||
               (lVar3 = *(int64 *)(lVar3.partPosture + 16)) == null) break;
            if (lVar3.summonLv <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            fVar6 = (float)Mathf.Max(*(float *)(lVar5 + lVar3.isSummon) * recoverRate,0x3f800000
                                      ,0);
            uVar7 = Mathf.Max(0,fVar1 - fVar6);
            FUN_18182a350(lVar2,uVar4,uVar7,DAT_181da1110);
            lVar3 = this.heroData;
            uVar4 = uVar4 + 1;
            lVar5 = lVar5 + 4;
            if (lVar3 == null) break;
          }
        }
    }

    // Token : 0x6000C5F
    // RVA   : 0x8CF420   Offset: 0x8CE820   Length: 0x1ED
    public void ChangePower(float num, bool showText)
    {
        long lVar1;
        float fVar2;
        ulong uVar3;
        float[] local_res10 = new float[2];
        uint uVar5;
        float[] local_58 = new float[2];
        ulong local_50;
        ulong uStack_48;
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        local_res10[0] = num;
        fVar2 = local_res10[0];
        local_58[0] = 0.0;
        if (local_res10[0] != 0.0) {
          if (showText) {
            if (0.0 < local_res10[0]) {
              if ((this.heroData == null) ||
                 (lVar1 = this.heroData.totalAddData) == null) {
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              local_58[0] = (float)HeroSpeAddData.Get(lVar1,73);
              local_58[0] = local_58[0] * fVar2;
              pfVar4 = local_58;
            }
            else {
              pfVar4 = local_res10;
            }
            uVar3 = Single.ToString(pfVar4,"+0;-0;0",0);
            uVar3 = String.Concat("体力",uVar3,0);
            local_50 = 0;
            uStack_48 = 0;
            uVar5 = 0;
            Color.ctor(&local_50,0x3f800000,0x3f000000,0,0);
            local_38 = (uint32)local_50;
            uStack_34 = local_50._4_4_;
            uStack_30 = (uint32)uStack_48;
            uStack_2c = uStack_48._4_4_;
            BattleUnit.ShowTextOnHead
                      (this,uVar3,&local_38,*(int *)(*(int64 *)(DAT_181db07e0 + 184) + 28) + -4,
                       CONCAT44(uVar5,24),"UIAtlas",0,0,0);
          }
          if (this.heroData == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          HeroData.ChangePower(this.heroData,local_res10[0],0,0);
        }
    }

    // Token : 0x6000C60
    // RVA   : 0x8CEFE0   Offset: 0x8CE3E0   Length: 0x225
    public void ChangeMana(float num, bool showText, bool useRecoverRate)
    {
        long lVar1;
        float fVar2;
        ulong uVar3;
        uint uVar5;
        uint uVar6;
        uint uVar7;
        uint uVar8;
        float[] local_res10 = new float[2];
        uint in_stack_ffffffffffffff98;
        float[] local_38 = new float[4];
        uint local_28;
        uint uStack_24;
        uint uStack_20;
        uint32 uStack_1c;
        local_res10[0] = num;
        fVar2 = local_res10[0];
        local_38[0] = 0.0;
        if (local_res10[0] != 0.0) {
          if (showText) {
            if (0.0 < local_res10[0]) {
              if (!useRecoverRate) {
                local_38[0] = 1.0;
              }
              else {
                if ((this.heroData == null) ||
                   (lVar1 = this.heroData.totalAddData) == null)
                goto LAB_1808cf200;
                local_38[0] = (float)HeroSpeAddData.Get(lVar1,73);
              }
              local_38[0] = fVar2 * local_38[0];
              uVar3 = Single.ToString(local_38,"+0;-0;0",0);
              puVar4 = (uint32 *)Color.get_blue(&local_28,0);
              uVar5 = *puVar4;
              uVar6 = puVar4[1];
              uVar7 = puVar4[2];
              uVar8 = puVar4[3];
              if (this == 0) goto LAB_1808cf200;
            }
            else {
              uVar3 = Single.ToString(local_res10,"+0;-0;0",0);
              puVar4 = (uint32 *)Color.get_magenta(&local_28,0);
              uVar5 = *puVar4;
              uVar6 = puVar4[1];
              uVar7 = puVar4[2];
              uVar8 = puVar4[3];
            }
            in_stack_ffffffffffffff98 = 0;
            local_28 = uVar5;
            uStack_24 = uVar6;
            uStack_20 = uVar7;
            uStack_1c = uVar8;
            BattleUnit.ShowTextOnHead
                      (this,uVar3,&local_28,*(int *)(*(int64 *)(DAT_181db07e0 + 184) + 28) + -2,
                       24,"UIAtlas",0,0,0);
          }
          if (this.heroData == null) {
        LAB_1808cf200:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          HeroData.ChangeMana
                    (this.heroData,local_res10[0],useRecoverRate,1,
                     in_stack_ffffffffffffff98 & 0xffffff00,0);
        }
    }

    // Token : 0x6000C61
    // RVA   : 0x8CE790   Offset: 0x8CDB90   Length: 0x639
    public void ChangeHp(float num, bool isCrit, bool useRecoverRate, bool noDead)
    {
        void BattleUnit.ChangeHp
                     (int64 this,float num,char isCrit,char useRecoverRate,uint8 noDead)
        {
        char cVar1;
        uint32 uVar2;
        int64 lVar3;
        uint64 uVar4;
        uint32 *puVar5;
        int64 *plVar6;
        uint64 uVar7;
        int64 *plVar8;
        int iVar9;
        float fVar10;
        uint32 uVar11;
        uint32 uVar12;
        uint32 uVar13;
        uint32 uVar14;
        float local_res10 [2];
        uint64 in_stack_ffffffffffffff58;
        uint64 uVar15;
        float local_78 [4];
        uint32 local_68;
        uint32 uStack_64;
        uint32 uStack_60;
        uint32 uStack_5c;
        uVar2 = (uint32)((uint64)in_stack_ffffffffffffff58 >> 32);
        local_res10[0] = num;
        fVar10 = local_res10[0];
        local_78[0] = 0.0;
        if (0.0 < local_res10[0]) {
          if (!useRecoverRate) {
            local_78[0] = 1.0;
          }
          else {
            if ((this.heroData == null) ||
               (lVar3 = this.heroData.totalAddData) == null)
            throw; // [null/range check failed]
            local_78[0] = (float)HeroSpeAddData.Get(lVar3,73);
          }
          local_78[0] = fVar10 * local_78[0];
          uVar4 = Single.ToString(local_78,"+0;-0;0",0);
          puVar5 = (uint32 *)Color.get_green(&local_68,0);
          uVar11 = *puVar5;
          uVar12 = puVar5[1];
          uVar13 = puVar5[2];
          uVar14 = puVar5[3];
          if (this == 0) throw; // [null/range check failed]
        LAB_1808cebe5:
          uVar15 = "UIAtlas";
          local_68 = uVar11;
          uStack_64 = uVar12;
          uStack_60 = uVar13;
          uStack_5c = uVar14;
          BattleUnit.ShowTextOnHead
                    (this,uVar4,&local_68,BattleUnit.damageBaseFontSize,
                     CONCAT44(uVar2,24),"UIAtlas",0,0,0);
        }
        else {
          if ((this.skeleton == null) ||
             (lVar3 = SkeletonAnimation.get_AnimationState(this.skeleton,0)) == null)
          throw; // [null/range check failed]
          AnimationState.SetAnimation(lVar3,1,"hit",0,0);
          if ((this.skeleton == null) ||
             (lVar3 = SkeletonAnimation.get_AnimationState(this.skeleton,0)) == null)
          throw; // [null/range check failed]
          uVar2 = 0;
          AnimationState.AddEmptyAnimation(lVar3,1,0x3e4ccccd,0,0);
          if (this.heroData == null) throw; // [null/range check failed]
          cVar1 = HeroData.HaveBuff(this.heroData,95,0);
          if (cVar1) {
            puVar5 = (uint32 *)Color.get_yellow(&local_68,0);
            uVar11 = *puVar5;
            uVar12 = puVar5[1];
            uVar13 = puVar5[2];
            uVar14 = puVar5[3];
            uVar4 = "-0";
            if (((*(byte *)(DAT_181db07e0 + 0x133) & 4) != 0) && (*(int *)(DAT_181db07e0 + 224) == 0)) {
              il2cpp_runtime_class_init();
              uVar4 = "-0";
            }
            goto LAB_1808cebe5;
          }
          uVar4 = Single.ToString(local_res10,"+0;-0;0",0);
          if (!isCrit) {
            puVar5 = (uint32 *)Color.get_yellow(&local_68,0);
            local_68 = *puVar5;
            uStack_64 = puVar5[1];
            uStack_60 = puVar5[2];
            uStack_5c = puVar5[3];
            iVar9 = BattleUnit.damageBaseFontSize;
          }
          else {
            puVar5 = (uint32 *)Color.get_red();
            local_68 = *puVar5;
            uStack_64 = puVar5[1];
            uStack_60 = puVar5[2];
            uStack_5c = puVar5[3];
            iVar9 = BattleUnit.damageBaseFontSize + 3;
          }
          BattleUnit.ShowTextOnHead
                    (this,uVar4,&local_68,iVar9,CONCAT44(uVar2,24),"UIAtlas",0,0,0);
          uVar4 = this.hipPos;
          if (this.heroData == null) throw; // [null/range check failed]
          if (!this.heroData.isSummon) {
            if (**(int **)(DAT_181d73d40 + 184) == 2) goto LAB_1808cea88;
            uVar7 = "SpeEffect/BloodSplash";
            if (*(char *)(*(int64 *)(DAT_181d73d40 + 184) + 4) != false) goto LAB_1808cea88;
          }
          else {
        LAB_1808cea88:
            uVar7 = "SpeEffect/DirtSplash";
          }
          plVar6 = (int64 *)Resources.Load(uVar7,0);
          plVar8 = (int64 *)0;
          if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181d72e60)) {
            plVar8 = plVar6;
          }
          GlobalData.AddChild(uVar4,plVar8,1,0);
          if (this.heroData == null) throw; // [null/range check failed]
          uVar4 = HeroData.GetHeroHurtSound(this.heroData,0);
          uVar15 = 0;
          BattleUnit.PlayHeroSound(this,uVar4,1,0,1,0);
        }
        if (local_res10[0] <= 0.0) {
          if (this.heroData == null) throw; // [null/range check failed]
          cVar1 = HeroData.HaveBuff(this.heroData,95);
          if (cVar1) {
            return;
          }
        }
        lVar3 = this.heroData;
        if (lVar3 != null) {
          fVar10 = lVar3.hp;
          HeroData.ChangeHp(lVar3,local_res10[0],useRecoverRate,noDead,1,uVar15 & 0xffffffffffffff00,0);
          if (local_res10[0] < 0.0) {
            lVar3 = this.battleInfo;
            if (lVar3 == null) throw; // [null/range check failed]
            lVar3.summonMoveRange = ABS(local_res10[0]) + lVar3.summonMoveRange;
            if (!this.destroyed) {
              lVar3 = this.heroData;
              if (lVar3 == null) throw; // [null/range check failed]
              if ((((0.0 < lVar3.hp) && (0.2 <= fVar10 / lVar3.maxhp)) &&
                  (lVar3.hp / lVar3.maxhp < 0.2)) &&
                 (fVar10 = (float)Random.get_value(0), fVar10 <= 1.0)) {
                lVar3 = BattleUnit.HeroLowHpTalk;
                if (lVar3 == null) throw; // [null/range check failed]
                uVar2 = FUN_180d96040(0,lVar3.summonLv,0);
                uVar4 = FUN_180002f80(lVar3,uVar2,DAT_181da4370);
                BattleUnit.Talk(this,uVar4,0x40400000,0);
              }
            }
          }
          return;
        }
    }

    // Token : 0x6000C62
    // RVA   : 0x8D06E0   Offset: 0x8CFAE0   Length: 0x217
    public void CheckInvincibleEffect()
    {
        float fVar1;
        bool cVar2;
        long lVar4;
        ulong uVar6;
        ulong local_28;
        float local_20;
        ulong local_18;
        float local_10;
        if (this.heroData == null) {
        LAB_1808d08f2:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        cVar2 = HeroData.HaveBuff(this.heroData,95);
        uVar6 = this.invincibleEffect;
        if (!cVar2) {
          cVar2 = Object.op_Inequality(uVar6,0,0);
          if (cVar2) {
            uVar6 = this.invincibleEffect;
            Object.Destroy(uVar6,0);
          }
        }
        else {
          cVar2 = Object.op_Equality(uVar6,0,0);
          if (cVar2) {
            uVar6 = this.hipPos;
            plVar3 = (int64 *)Resources.Load("SpeEffect/光圈持续",0);
            if ((this.skeleton != null) &&
               (lVar4 = Component.get_transform(this.skeleton,0)) != null) {
              pfVar5 = (float *)Transform.get_localScale(&local_18,lVar4,0);
              fVar1 = *pfVar5;
              local_20 = fVar1 + fVar1;
              local_28 = CONCAT44(local_20,fVar1 * 1.2);
              local_10 = local_20;
              local_20 = -0.001;
              local_18 = local_28;
              local_28 = 0;
              plVar7 = (int64 *)0;
              if ((plVar3 != (int64 *)0) && (*plVar3 == DAT_181d72e60)) {
                plVar7 = plVar3;
              }
              uVar6 = GlobalData.AddChild(uVar6,plVar7,&local_28,&local_18,0);
              this.invincibleEffect = uVar6;
              return;
            }
            goto LAB_1808d08f2;
          }
        }
    }

    // Token : 0x6000C63
    // RVA   : 0x8D2F90   Offset: 0x8D2390   Length: 0x9A
    public void PlayHitAnim()
    {
        long lVar1;
        if (this.skeleton != null) {
          lVar1 = SkeletonAnimation.get_AnimationState(this.skeleton,0);
          if (lVar1 != null) {
            AnimationState.SetAnimation(lVar1,1,"hit",0,0);
            if (this.skeleton != null) {
              lVar1 = SkeletonAnimation.get_AnimationState(this.skeleton,0);
              if (lVar1 != null) {
                AnimationState.AddEmptyAnimation(lVar1,1,0x3e4ccccd,0,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x6000C64
    // RVA   : 0x8CF610   Offset: 0x8CEA10   Length: 0x2A7
    public void ChangeTrueHp(float num)
    {
        long lVar1;
        bool cVar2;
        uint uVar3;
        ulong uVar4;
        float fVar6;
        float[] local_res10 = new float[2];
        ulong in_stack_ffffffffffffffa0;
        ulong local_38;
        ulong uStack_30;
        local_res10[0] = num;
        if (0.0 <= local_res10[0]) {
          return;
        }
        if (this.heroData != null) {
          cVar2 = HeroData.HaveBuff(this.heroData,95);
          if (cVar2) {
            return;
          }
          lVar1 = this.heroData;
          if (lVar1 != null) {
            fVar6 = lVar1.hp;
            HeroData.ChangeHp(lVar1,local_res10[0],0,0,1,in_stack_ffffffffffffffa0 & 0xffffffffffffff00,0
                              );
            lVar1 = this.battleInfo;
            if (lVar1 != null) {
              lVar1.summonMoveRange = ABS(local_res10[0]) + lVar1.summonMoveRange;
              if (!this.destroyed) {
                lVar1 = this.heroData;
                if (lVar1 == null) throw; // [null/range check failed]
                if ((((0.0 < lVar1.hp) && (0.2 <= fVar6 / lVar1.maxhp)) &&
                    (lVar1.hp / lVar1.maxhp < 0.2)) &&
                   (fVar6 = (float)Random.get_value(0), fVar6 <= 1.0)) {
                  lVar1 = BattleUnit.HeroLowHpTalk;
                  if (lVar1 == null) throw; // [null/range check failed]
                  uVar3 = FUN_180d96040(0,lVar1.summonLv,0);
                  uVar4 = FUN_180002f80(lVar1,uVar3,DAT_181da4370);
                  BattleUnit.Talk(this,uVar4,0x40400000,0);
                }
              }
              uVar4 = Single.ToString(local_res10,"+0;-0;0",0);
              puVar5 = (uint64 *)FUN_1810d3b80(&local_38,0);
              local_38 = *puVar5;
              uStack_30 = puVar5[1];
              BattleUnit.ShowTextOnHead
                        (this,uVar4,&local_38,
                         BattleUnit.damageBaseFontSize,24,"UIAtlas",0,
                         0,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000C65
    // RVA   : 0x8CDE40   Offset: 0x8CD240   Length: 0x10B
    public void AutoCureInjuryUseMana(float num)
    {
        float fVar1;
        if (this.heroData == null) {
        LAB_1808cdf40:
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        fVar1 = (float)HeroData.GetTotalInjury(this.heroData,0);
        if (0.0 < fVar1) {
          if (this.heroData == null) goto LAB_1808cdf40;
          fVar1 = (float)Mathf.Min(this.heroData.mana * 0.1,num,0);
          if (fVar1 * -10.0 != null.0) {
            if (this.heroData == null) {
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            HeroData.ChangeMana(this.heroData,fVar1 * -10.0,0,1,0,0);
          }
          BattleUnit.FightCureSelfInjury(this,-fVar1,0);
        }
    }

    // Token : 0x6000C66
    // RVA   : 0x8D1850   Offset: 0x8D0C50   Length: 0x584
    public void FightCureSelfInjury(float num)
    {
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
        float fVar1;
        float fVar2;
        ulong uVar3;
        ulong uVar5;
        long lVar6;
        int iVar7;
        uint uVar8;
        uint uVar9;
        uint uVar10;
        uint uVar11;
        float[] local_res8 = new float[2];
        uint in_stack_ffffffffffffff98;
        uint local_38;
        uint uStack_34;
        uint uStack_30;
        uint32 uStack_2c;
        lVar6 = this.heroData;
        if (lVar6 == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        fVar1 = lVar6.externalInjury;
        if (((fVar1 != 0.0) || (lVar6.internalInjury != null.0)) || (lVar6.poisonInjury != null.0))
        {
          fVar2 = lVar6.poisonInjury;
          if ((fVar2 < lVar6.internalInjury) || (fVar2 < fVar1)) {
            if ((fVar1 < lVar6.internalInjury) || (fVar1 < fVar2)) {
              if (!DAT_181e9d142) {
                il2cpp_runtime_class_init(&DAT_181db07e0);
                il2cpp_runtime_class_init(&DAT_181d73d40);
                il2cpp_runtime_class_init(&DAT_181d82fb8);
                il2cpp_internal(&"+0;-0;0");
                il2cpp_internal(&"UIAtlas");
                lVar6 = this.heroData;
                DAT_181e9d142 = true;
                if (lVar6 == null) goto LAB_1808d1dcf;
              }
              if (lVar6.isSummon) {
                return;
              }
              local_res8[0] =
                   (float)HeroData.ChangeInternalInjury
                                    (lVar6,num,0,0,in_stack_ffffffffffffff98 & 0xffffff00,0);
              uVar3 = Single.ToString(local_res8,"+0;-0;0",0);
              if (local_res8[0] <= 0.0) {
                puVar4 = (uint32 *)Color.get_cyan(&local_38,0);
                uVar8 = *puVar4;
                uVar9 = puVar4[1];
                uVar10 = puVar4[2];
                uVar11 = puVar4[3];
              }
              else {
                lVar6 = *(int64 *)(pStatics_3d40 + 0x3c0);
                if (lVar6 == null) {
        LAB_1808d1dcf:
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (lVar6.summonLv < 2) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar6 = lVar6.isSummon;
                uVar8 = lVar6.interestingStar;
                uVar9 = lVar6.manageAiHour;
                uVar10 = lVar6.dailyAIManaged;
                uVar11 = *(uint32 *)(lVar6 + 60);
              }
              iVar7 = BattleUnit.damageBaseFontSize;
              uVar5 = 1;
            }
            else {
              if (!DAT_181e9d141) {
                il2cpp_runtime_class_init(&DAT_181db07e0);
                il2cpp_runtime_class_init(&DAT_181d73d40);
                il2cpp_runtime_class_init(&DAT_181d82fb8);
                il2cpp_internal(&"+0;-0;0");
                il2cpp_internal(&"UIAtlas");
                lVar6 = this.heroData;
                DAT_181e9d141 = true;
                if (lVar6 == null) goto LAB_1808d1dc9;
              }
              if (lVar6.isSummon) {
                return;
              }
              local_res8[0] =
                   (float)HeroData.ChangeExternalInjury
                                    (lVar6,num,0,0,in_stack_ffffffffffffff98 & 0xffffff00,0);
              uVar3 = Single.ToString(local_res8,"+0;-0;0",0);
              if (local_res8[0] <= 0.0) {
                puVar4 = (uint32 *)Color.get_cyan(&local_38,0);
                uVar8 = *puVar4;
                uVar9 = puVar4[1];
                uVar10 = puVar4[2];
                uVar11 = puVar4[3];
              }
              else {
                lVar6 = *(int64 *)(pStatics_3d40 + 0x3c0);
                if (lVar6 == null) {
        LAB_1808d1dc9:
                          // WARNING: Subroutine does not return
                  FUN_1800d6620();
                }
                if (lVar6.summonLv == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar6 = lVar6.isSummon;
                uVar8 = lVar6.summonControlable;
                uVar9 = *(uint32 *)(lVar6 + 36);
                uVar10 = lVar6.summonSourceHero;
                uVar11 = *(uint32 *)(lVar6 + 44);
              }
              iVar7 = BattleUnit.damageBaseFontSize;
              uVar5 = 0;
            }
          }
          else {
            if (!DAT_181e9d143) {
              il2cpp_runtime_class_init(&DAT_181db07e0);
              il2cpp_runtime_class_init(&DAT_181d73d40);
              il2cpp_runtime_class_init(&DAT_181d82fb8);
              il2cpp_internal(&"+0;-0;0");
              il2cpp_internal(&"UIAtlas");
              lVar6 = this.heroData;
              DAT_181e9d143 = true;
              if (lVar6 == null) goto LAB_1808d1dc3;
            }
            if (lVar6.isSummon) {
              return;
            }
            local_res8[0] =
                 (float)HeroData.ChangePoisonInjury
                                  (lVar6,num,0,0,in_stack_ffffffffffffff98 & 0xffffff00,0);
            uVar3 = Single.ToString(local_res8,"+0;-0;0",0);
            if (local_res8[0] <= 0.0) {
              puVar4 = (uint32 *)Color.get_cyan(&local_38,0);
              uVar8 = *puVar4;
              uVar9 = puVar4[1];
              uVar10 = puVar4[2];
              uVar11 = puVar4[3];
            }
            else {
              lVar6 = *(int64 *)(pStatics_3d40 + 0x3c0);
              if (lVar6 == null) {
        LAB_1808d1dc3:
                          // WARNING: Subroutine does not return
                FUN_1800d6620();
              }
              if (lVar6.summonLv < 3) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar6 = lVar6.isSummon;
              uVar8 = lVar6.heroAIData;
              uVar9 = *(uint32 *)(lVar6 + 68);
              uVar10 = lVar6.heroAIDataArriveTargetRecord;
              uVar11 = *(uint32 *)(lVar6 + 76);
            }
            iVar7 = BattleUnit.damageBaseFontSize;
            uVar5 = 2;
          }
          uVar5 = GlobalData.GetInjuryIconName(uVar5,0);
          local_38 = uVar8;
          uStack_34 = uVar9;
          uStack_30 = uVar10;
          uStack_2c = uVar11;
          BattleUnit.ShowTextOnHead(this,uVar3,&local_38,iVar7 + -2,24,"UIAtlas",uVar5,0,0);
        }
    }

    // Token : 0x6000C67
    // RVA   : 0x8CE410   Offset: 0x8CD810   Length: 0x207
    public void ChangeExternalInjury(float num, bool showInfo, bool extraResist)
    {
        void BattleUnit.ChangeExternalInjury
                     (int64 this,uint32 num,char showInfo,uint8 extraResist)
        {
        int iVar1;
        int64 lVar2;
        uint64 uVar3;
        uint32 *puVar4;
        uint64 uVar5;
        uint32 uVar6;
        uint32 uVar7;
        uint32 uVar8;
        uint32 uVar9;
        float local_res8 [2];
        uint32 local_28;
        uint32 uStack_24;
        uint32 uStack_20;
        uint32 uStack_1c;
        lVar2 = this.heroData;
        if (lVar2 != null) {
          if (!lVar2.isSummon) {
            local_res8[0] = (float)HeroData.ChangeExternalInjury(lVar2,num,0,0,extraResist,0);
            if (showInfo) {
              uVar3 = Single.ToString(local_res8,"+0;-0;0",0);
              if (local_res8[0] <= 0.0) {
                puVar4 = (uint32 *)Color.get_cyan(&local_28,0);
                uVar6 = *puVar4;
                uVar7 = puVar4[1];
                uVar8 = puVar4[2];
                uVar9 = puVar4[3];
              }
              else {
                lVar2 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x3c0);
                if (lVar2 == null) throw; // [null/range check failed]
                if (lVar2.summonLv == null) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar2 = lVar2.isSummon;
                uVar6 = lVar2.summonControlable;
                uVar7 = *(uint32 *)(lVar2 + 36);
                uVar8 = lVar2.summonSourceHero;
                uVar9 = *(uint32 *)(lVar2 + 44);
              }
              iVar1 = *(int *)(*(int64 *)(DAT_181db07e0 + 184) + 28);
              uVar5 = GlobalData.GetInjuryIconName(0,0);
              local_28 = uVar6;
              uStack_24 = uVar7;
              uStack_20 = uVar8;
              uStack_1c = uVar9;
              BattleUnit.ShowTextOnHead(this,uVar3,&local_28,iVar1 + -2,24,"UIAtlas",uVar5,0,0);
            }
          }
          return;
        }
    }

    // Token : 0x6000C68
    // RVA   : 0x8CEDD0   Offset: 0x8CE1D0   Length: 0x208
    public void ChangeInternalInjury(float num, bool showInfo, bool extraResist)
    {
        void BattleUnit.ChangeInternalInjury
                     (int64 this,uint32 num,char showInfo,uint8 extraResist)
        {
        int iVar1;
        int64 lVar2;
        uint64 uVar3;
        uint32 *puVar4;
        uint64 uVar5;
        uint32 uVar6;
        uint32 uVar7;
        uint32 uVar8;
        uint32 uVar9;
        float local_res8 [2];
        uint32 local_28;
        uint32 uStack_24;
        uint32 uStack_20;
        uint32 uStack_1c;
        lVar2 = this.heroData;
        if (lVar2 != null) {
          if (!lVar2.isSummon) {
            local_res8[0] = (float)HeroData.ChangeInternalInjury(lVar2,num,0,0,extraResist,0);
            if (showInfo) {
              uVar3 = Single.ToString(local_res8,"+0;-0;0",0);
              if (local_res8[0] <= 0.0) {
                puVar4 = (uint32 *)Color.get_cyan(&local_28,0);
                uVar6 = *puVar4;
                uVar7 = puVar4[1];
                uVar8 = puVar4[2];
                uVar9 = puVar4[3];
              }
              else {
                lVar2 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x3c0);
                if (lVar2 == null) throw; // [null/range check failed]
                if (lVar2.summonLv < 2) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar2 = lVar2.isSummon;
                uVar6 = lVar2.interestingStar;
                uVar7 = lVar2.manageAiHour;
                uVar8 = lVar2.dailyAIManaged;
                uVar9 = *(uint32 *)(lVar2 + 60);
              }
              iVar1 = *(int *)(*(int64 *)(DAT_181db07e0 + 184) + 28);
              uVar5 = GlobalData.GetInjuryIconName(1);
              local_28 = uVar6;
              uStack_24 = uVar7;
              uStack_20 = uVar8;
              uStack_1c = uVar9;
              BattleUnit.ShowTextOnHead(this,uVar3,&local_28,iVar1 + -2,24,"UIAtlas",uVar5,0,0);
            }
          }
          return;
        }
    }

    // Token : 0x6000C69
    // RVA   : 0x8CF210   Offset: 0x8CE610   Length: 0x208
    public void ChangePoisonInjury(float num, bool showInfo, bool extraResist)
    {
        void BattleUnit.ChangePoisonInjury
                     (int64 this,uint32 num,char showInfo,uint8 extraResist)
        {
        int iVar1;
        int64 lVar2;
        uint64 uVar3;
        uint32 *puVar4;
        uint64 uVar5;
        uint32 uVar6;
        uint32 uVar7;
        uint32 uVar8;
        uint32 uVar9;
        float local_res8 [2];
        uint32 local_28;
        uint32 uStack_24;
        uint32 uStack_20;
        uint32 uStack_1c;
        lVar2 = this.heroData;
        if (lVar2 != null) {
          if (!lVar2.isSummon) {
            local_res8[0] = (float)HeroData.ChangePoisonInjury(lVar2,num,0,0,extraResist,0);
            if (showInfo) {
              uVar3 = Single.ToString(local_res8,"+0;-0;0",0);
              if (local_res8[0] <= 0.0) {
                puVar4 = (uint32 *)Color.get_cyan(&local_28,0);
                uVar6 = *puVar4;
                uVar7 = puVar4[1];
                uVar8 = puVar4[2];
                uVar9 = puVar4[3];
              }
              else {
                lVar2 = *(int64 *)(*(int64 *)(DAT_181d73d40 + 184) + 0x3c0);
                if (lVar2 == null) throw; // [null/range check failed]
                if (lVar2.summonLv < 3) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar2 = lVar2.isSummon;
                uVar6 = lVar2.heroAIData;
                uVar7 = *(uint32 *)(lVar2 + 68);
                uVar8 = lVar2.heroAIDataArriveTargetRecord;
                uVar9 = *(uint32 *)(lVar2 + 76);
              }
              iVar1 = *(int *)(*(int64 *)(DAT_181db07e0 + 184) + 28);
              uVar5 = GlobalData.GetInjuryIconName(2);
              local_28 = uVar6;
              uStack_24 = uVar7;
              uStack_20 = uVar8;
              uStack_1c = uVar9;
              BattleUnit.ShowTextOnHead(this,uVar3,&local_28,iVar1 + -2,24,"UIAtlas",uVar5,0,0);
            }
          }
          return;
        }
    }

    // Token : 0x6000C6A
    // RVA   : 0x8CF8C0   Offset: 0x8CECC0   Length: 0xE1F
    public void CheckDead()
    {
        var pStatics = *(int64*)(DAT_181d73d40 + 184);
        float fVar1;
        bool cVar2;
        long lVar3;
        long lVar6;
        long lVar7;
        int iVar8;
        uint uVar9;
        ulong uVar10;
        float fVar12;
        float fVar13;
        uint uVar14;
        float[] local_res8 = new float[4];
        float[] local_res18 = new float[2];
        float[] local_res20 = new float[2];
        ulong in_stack_ffffffffffffff48;
        ulong uVar15;
        ulong uVar16;
        uint uVar17;
        ulong in_stack_ffffffffffffff50;
        ulong in_stack_ffffffffffffff58;
        float local_88;
        float[] local_84 = new float[3];
        ulong local_78;
        ulong uStack_70;
        local_res8[0] = 0.0;
        if (this.destroyed) {
          return;
        }
        lVar3 = this.heroData;
        if (lVar3 == null) throw; // [null/range check failed]
        if (0.0 < *(float *)(lVar3 + 0x178)) {
          return;
        }
        if (!this.reborn) {
          if (*(int64 *)(lVar3 + 0x2b8) == 0) throw; // [null/range check failed]
          fVar12 = (float)HeroSpeAddData.Get(*(int64 *)(lVar3 + 0x2b8),129,0);
          if (fVar12 != 0.0) {
            if ((this.skeleton != null) &&
               (lVar3 = SkeletonAnimation.get_AnimationState(this.skeleton,0), lVar3 != null
               )) {
              iVar8 = 0;
              AnimationState.SetAnimation(lVar3,1,"die",0,0);
              if ((this.skeleton != null) &&
                 (lVar3 = SkeletonAnimation.get_AnimationState(this.skeleton,0),
                 lVar3 != null)) {
                uVar15 = 0;
                AnimationState.AddEmptyAnimation(lVar3,1,0x3e4ccccd,0,0);
                lVar3 = this.heroData;
                if (lVar3 != null) {
                  fVar12 = *(float *)(lVar3 + 0x17c);
                  if (*(int64 *)(lVar3 + 0x2b8) != 0) {
                    local_res20[0] = (float)HeroSpeAddData.Get(*(int64 *)(lVar3 + 0x2b8),129,0);
                    local_res20[0] = local_res20[0] * fVar12;
                    if (this.heroData != null) {
                      uVar16 = CONCAT71((int7)((uint64)uVar15 >> 8),1);
                      HeroData.ChangeHp(this.heroData,local_res20[0],0,0,uVar16,
                                         in_stack_ffffffffffffff50 & 0xffffffffffffff00,0);
                      lVar3 = this.heroData;
                      if (lVar3 != null) {
                        fVar12 = *(float *)(lVar3 + 0x194);
                        if (*(int64 *)(lVar3 + 0x2b8) != 0) {
                          local_88 = (float)HeroSpeAddData.Get(*(int64 *)(lVar3 + 0x2b8),129,0);
                          local_88 = local_88 * fVar12;
                          if (this.heroData != null) {
                            uVar16 = uVar16 & 0xffffffffffffff00;
                            HeroData.ChangeMana(this.heroData,local_88,0,1,uVar16,0);
                            lVar3 = this.heroData;
                            if (lVar3 != null) {
                              fVar12 = *(float *)(lVar3 + 0x188);
                              if (*(int64 *)(lVar3 + 0x2b8) != 0) {
                                local_84[0] = (float)HeroSpeAddData.Get(*(int64 *)(lVar3 + 0x2b8),129
                                                                         ,0);
                                local_84[0] = local_84[0] * fVar12;
                                if (this.heroData != null) {
                                  HeroData.ChangePower(this.heroData,local_84[0],0,0);
                                  if ((this.heroData != null) &&
                                     (lVar3 = this.heroData.totalAddData,
                                     lVar3 != null)) {
                                    local_res18[0] = (float)HeroSpeAddData.Get(lVar3,129,0);
                                    local_res18[0] = local_res18[0] * 100.0;
                                    lVar3 = this.heroData;
                                    if (lVar3 != null) {
                                      while( true ) {
                                        uVar17 = (uint32)(uVar16 >> 32);
                                        if ((*(int64 *)(lVar3 + 0x230) == 0) ||
                                           (lVar6 = *(int64 *)(*(int64 *)(lVar3 + 0x230) + 16),
                                           lVar6 == null)) throw; // [null/range check failed]
                                        if (*(int *)(lVar6 + 24) <= iVar8) break;
                                        if ((lVar3 == null) || (*(int64 *)(lVar3 + 0x230) == 0))
                                        throw; // [null/range check failed]
                                        PartPostureData.ChangePosture
                                                  (*(int64 *)(lVar3 + 0x230),iVar8,-local_res18[0]);
                                        lVar3 = this.heroData;
                                        iVar8 = iVar8 + 1;
                                        if (lVar3 == null) throw; // [null/range check failed]
                                      }
                                      if (((*(byte *)(DAT_181d73d40 + 0x133) & 4) != 0) &&
                                         (*(int *)(DAT_181d73d40 + 224) == 0)) {
                                        il2cpp_runtime_class_init(DAT_181d73d40);
                                        lVar3 = this.heroData;
                                      }
                                      fVar12 = *(float *)(pStatics + 0x230);
                                      if ((lVar3 != null) && (*(int64 *)(lVar3 + 0x2b8) != 0)) {
                                        fVar13 = (float)HeroSpeAddData.Get(*(int64 *)(lVar3 + 0x2b8),
                                                                            129,0);
                                        fVar1 = this.battleMove;
                                        uVar14 = FUN_1810e3cd0(fVar1 + fVar13 * fVar12,0,
                                                               *(uint32 *)
                                                                (pStatics +
                                                                0x230),0);
                                        this.battleMove = uVar14;
                                        uVar15 = this.actionBarUnit;
                                        cVar2 = Object.op_Inequality(uVar15,0,0);
                                        if ((cVar2) && (!this.destroyed)) {
                                          if (this.heroData == null) throw; // [null/range check failed]
                                          if (0.0 < this.heroData.hp) {
                                            if (this.actionBarUnit == null) throw; // [null/range check failed]
                                            ActionBarUnit.RefreshActionBarUnit
                                                      (this.actionBarUnit,0,0);
                                          }
                                        }
                                        if ((this.heroData != null) &&
                                           (lVar3 = this.heroData.totalAddData,
                                           lVar3 != null)) {
                                          local_res8[0] = (float)HeroSpeAddData.Get(lVar3,129,0);
                                          local_res8[0] = local_res8[0] * 100.0;
                                          uVar15 = Single.ToString(local_res8,"f0",0);
                                          uVar15 = String.Format("复生+{0}%",uVar15,0);
                                          puVar4 = (uint64 *)Color.get_green(&local_78,0);
                                          local_78 = *puVar4;
                                          uStack_70 = puVar4[1];
                                          BattleUnit.ShowTextOnHead
                                                    (this,uVar15,&local_78,18,CONCAT44(uVar17,24),
                                                     "UIAtlas",0,0,0);
                                          if (this.heroData != null) {
                                            HeroData.RemoveAllDebuff(this.heroData,0);
                                            this.reborn = 1;
                                            lVar3 = *(int64 *)
                                                     (*(int64 *)(DAT_181db0260 + 184) + 80);
                                            plVar5 = (int64 *)FUN_1800d60b0(DAT_181da4138,5);
                                            if ((this.heroData != null) &&
                                               (lVar6 = HeroData.Name(this.heroData,1,0),
                                               plVar5 != (int64 *)0)) {
                                              if ((lVar6 != null) &&
                                                 (lVar7 = il2cpp_internal(lVar6,*(uint64 *)
                                                                                     (*plVar5 + 64)),
                                                 lVar7 == null)) {
                                                uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                FUN_1800d65f0(uVar15,0);
                                              }
                                              if ((int)plVar5[3] == 0) {
                                                uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                FUN_1800d65f0(uVar15,0);
                                              }
                                              plVar5[4] = lVar6;
                                              il2cpp_internal(plVar5 + 4,lVar6);
                                              lVar6 = Single.ToString(local_res20,"f0",0);
                                              if ((lVar6 != null) &&
                                                 (lVar7 = il2cpp_internal(lVar6,*(uint64 *)
                                                                                     (*plVar5 + 64)),
                                                 lVar7 == null)) {
                                                uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                FUN_1800d65f0(uVar15,0);
                                              }
                                              if (*(uint32 *)(plVar5 + 3) < 2) {
                                                uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                FUN_1800d65f0(uVar15,0);
                                              }
                                              plVar5[5] = lVar6;
                                              il2cpp_internal(plVar5 + 5,lVar6);
                                              lVar6 = Single.ToString(&local_88,"f0",0);
                                              if ((lVar6 != null) &&
                                                 (lVar7 = il2cpp_internal(lVar6,*(uint64 *)
                                                                                     (*plVar5 + 64)),
                                                 lVar7 == null)) {
                                                uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                FUN_1800d65f0(uVar15,0);
                                              }
                                              if (*(uint32 *)(plVar5 + 3) < 3) {
                                                uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                FUN_1800d65f0(uVar15,0);
                                              }
                                              plVar5[6] = lVar6;
                                              il2cpp_internal(plVar5 + 6,lVar6);
                                              lVar6 = Single.ToString(local_84,"f0",0);
                                              if ((lVar6 != null) &&
                                                 (lVar7 = il2cpp_internal(lVar6,*(uint64 *)
                                                                                     (*plVar5 + 64)),
                                                 lVar7 == null)) {
                                                uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                FUN_1800d65f0(uVar15,0);
                                              }
                                              if (*(uint32 *)(plVar5 + 3) < 4) {
                                                uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                FUN_1800d65f0(uVar15,0);
                                              }
                                              plVar5[7] = lVar6;
                                              il2cpp_internal(plVar5 + 7,lVar6);
                                              lVar6 = Single.ToString(local_res18,"f0",0);
                                              if ((lVar6 != null) &&
                                                 (lVar7 = il2cpp_internal(lVar6,*(uint64 *)
                                                                                     (*plVar5 + 64)),
                                                 lVar7 == null)) {
                                                uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                FUN_1800d65f0(uVar15,0);
                                              }
                                              if (*(uint32 *)(plVar5 + 3) < 5) {
                                                uVar15 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                                FUN_1800d65f0(uVar15,0);
                                              }
                                              plVar5[8] = lVar6;
                                              il2cpp_internal(plVar5 + 8,lVar6);
                                              uVar10 = 0;
                                              uVar15 = String.Format("{0}死而复生，恢复{1}生命/{2}内力/{3}体力/{4}全架势/{4}%行动力。",plVar5,0);
                                              if (lVar3 != null) {
                                                uVar11 = (undefined7)((uint64)uVar10 >> 8);
                                                goto LAB_1808d015d;
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
            throw; // [null/range check failed]
          }
        }
        lVar3 = this.battleTeam;
        uVar9 = 0;
        if (lVar3 != null) {
          lVar6 = 32;
          while( true ) {
            uVar17 = (uint32)((uint64)in_stack_ffffffffffffff58 >> 32);
            if (lVar3.battleUnits == null) break;
            if (*(int *)(lVar3.battleUnits + 24) <= (int)uVar9) {
              this.destroyed = 1;
              if ((this.skeleton == null) ||
                 (lVar3 = SkeletonAnimation.get_AnimationState(this.skeleton,0),
                 lVar3 == null)) break;
              AnimationState.SetAnimation(lVar3,1,"die",0,0);
              BattleUnit.LeaveBattleField(this,0);
              lVar3 = *(int64 *)(*(int64 *)(DAT_181db07e0 + 184) + 48);
              if (lVar3 == null) break;
              uVar9 = FUN_180d96040(0,lVar3.battleUnits,0);
              if (lVar3.battleUnits <= uVar9) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              BattleUnit.Talk(this,*(uint64 *)
                                        (lVar3.ID + 32 + (int64)(int)uVar9 * 8),
                               0x40400000,0);
              if (this.heroData == null) break;
              uVar15 = HeroData.GetHeroDieSound(this.heroData,0);
              uVar14 = 0;
              BattleUnit.PlayHeroSound(this,uVar15,1,1,1,0);
              if ((this.battleTeam == null) ||
                 (lVar3 = this.battleTeam.needProtectUnits) == null) break;
              cVar2 = FUN_18181ea10(lVar3,this,DAT_181d7fa40);
              if (cVar2) {
                if (this.battleTeam == null) break;
                this.battleTeam.needProtectUnitDestroyed = 1;
              }
              lVar3 = new WarpText_d__8(0,0);
              if (lVar3 != null) {
                lVar3.needProtectUnits = this;
                FUN_180d8c8f0(this,lVar3,0);
                lVar3 = **(int64 **)(DAT_181d7f6c0 + 184);
                if (this.heroData != null) {
                  uVar15 = HeroData.Name(this.heroData,1,0);
                  uVar15 = String.Format("{0}败退",uVar15,0);
                  puVar4 = (uint64 *)FUN_1810d3a00(&local_78,0);
                  if (lVar3 != null) {
                    local_78 = *puVar4;
                    uStack_70 = puVar4[1];
                    InfoController.AddInfoTab
                              (lVar3,uVar15,"UIAtlas","从事工作_战斗","Woosh",
                               CONCAT44(uVar14,0x3f800000),CONCAT44(uVar17,0x40a00000),&local_78,0);
                    lVar3 = FUN_18046bb80(0);
                    if (this.heroData != null) {
                      uVar15 = HeroData.Name(this.heroData,1,0);
                      uVar10 = 0;
                      uVar15 = String.Format("{0}败退。",uVar15,0);
                      if (lVar3 != null) {
                        uVar11 = (undefined7)((uint64)uVar10 >> 8);
        LAB_1808d015d:
                        BattleController.AddInfoText(lVar3,uVar15,CONCAT71(uVar11,1),0);
                        return;
                      }
                    }
                  }
                }
              }
              break;
            }
            if ((lVar3 = lVar3?.battleUnits) == null) break;
            if (lVar3.battleUnits <= uVar9) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar3 = *(int64 *)(lVar6 + lVar3.ID);
            if (lVar3 == null) break;
            uVar15 = *(uint64 *)(lVar3 + 72);
            cVar2 = Object.op_Equality(uVar15,this,0);
            if (cVar2) {
              if (((this.battleTeam == null) ||
                  (lVar3 = this.battleTeam.battleUnits) == null) ||
                 (lVar3 = FUN_180002f80(lVar3,uVar9)) == null) break;
              cVar2 = BattleUnit.get_IsAlive(lVar3,0);
              if (cVar2) {
                if ((this.battleTeam == null) ||
                   (lVar3 = this.battleTeam.battleUnits) == null) break;
                lVar3 = FUN_180002f80(lVar3,uVar9,DAT_181d7fc38);
                if ((((this.battleTeam == null) ||
                     ((lVar7 = this.battleTeam.battleUnits, lVar7 == null ||
                      (lVar7 = FUN_180002f80(lVar7,uVar9,DAT_181d7fc38)) == null))) ||
                    (*(int64 *)(lVar7 + 64) == 0)) || (lVar3 == null)) break;
                in_stack_ffffffffffffff48 = in_stack_ffffffffffffff48 & 0xffffffffffffff00;
                BattleUnit.ChangeHp
                          (lVar3,*(uint32 *)(*(int64 *)(lVar7 + 64) + 0x178) ^ 0x80000000,0,1,
                           in_stack_ffffffffffffff48,0);
                if (((this.battleTeam == null) ||
                    (lVar3 = this.battleTeam.battleUnits) == null) ||
                   (lVar3 = FUN_180002f80(lVar3,uVar9)) == null) break;
                BattleUnit.CheckDead(lVar3,0);
              }
            }
            lVar3 = this.battleTeam;
            uVar9 = uVar9 + 1;
            lVar6 = lVar6 + 8;
            if (lVar3 == null) break;
          }
        }
    }

    // Token : 0x6000C6B
    // RVA   : 0x8D0A30   Offset: 0x8CFE30   Length: 0x6C
    public IEnumerator Dying()
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 32) = this;
          return lVar1;
        }
    }

    // Token : 0x6000C6C
    // RVA   : 0x8D4C50   Offset: 0x8D4050   Length: 0x26A
    public void ShowTextOnHead(string text, Color color, int fontSize, Ease setEase, string atlasName, string spriteName, string font)
    {
        void BattleUnit.ShowTextOnHead
                     (int64 this,uint64 text,uint64 *color,uint32 fontSize,
                     uint32 setEase,uint64 atlasName,uint64 spriteName,uint64 font)
        {
        int64 lVar1;
        int64 lVar2;
        uint64 *puVar3;
        float fVar4;
        uint64 local_58;
        float local_50;
        uint64 local_48;
        float local_40;
        uint64 local_38;
        float local_30;
        uint64 local_28;
        float fStack_20;
        uint32 uStack_1c;
        lVar1 = GameController._instance;
        if (this.hipPos != null) {
          lVar2 = GameObject.get_transform(this.hipPos,0);
          if (lVar2 != null) {
            puVar3 = (uint64 *)Transform.get_position(&local_28,lVar2,0);
            local_58 = *puVar3;
            local_50 = *(float *)(puVar3 + 1);
            local_30 = *(float *)(*(uint64 **)(DAT_181db07e0 + 184) + 1);
            local_38 = **(uint64 **)(DAT_181db07e0 + 184);
            fVar4 = (float)this.OnceShowText * 0.0;
            local_40 = local_50 + local_30 + fVar4;
            local_48 = CONCAT44(local_58._4_4_ + (float)((uint64)local_38 >> 32) +
                                (float)this.OnceShowText * 0.044,
                                (float)local_58 + (float)local_38 + fVar4);
            local_28 = local_38;
            fStack_20 = local_30;
            if (lVar1 != null) {
              local_28 = *color;
              fStack_20 = *(float *)(color + 1);
              uStack_1c = *(uint32 *)((int64)color + 12);
              local_58 = 0x3dcccccd00000000;
              local_50 = 0.0;
              local_38 = local_48;
              local_30 = local_40;
              GameController.ShowTextAtPos
                        (lVar1,text,&local_38,fontSize,&local_28,&local_58,
                         this.hipPos,setEase,atlasName,spriteName,font,0);
              this.OnceShowText = this.OnceShowText + 1;
              return;
            }
          }
        }
    }

    // Token : 0x6000C6D
    // RVA   : 0x8D09A0   Offset: 0x8CFDA0   Length: 0x8A
    public void DisactiveSelf()
    {
        bool cVar1;
        long lVar2;
        BattleUnit.LeaveBattleField(this,0);
        cVar1 = Object.op_Inequality(this,0,0);
        if (cVar1) {
          lVar2 = Component.get_gameObject(this,0);
          if (lVar2 != null) {
            GameObject.SetActive(lVar2,0,0);
            return;
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
    }

    // Token : 0x6000C6E
    // RVA   : 0x8D0900   Offset: 0x8CFD00   Length: 0x9E
    public void DestroySelf()
    {
        ulong uVar1;
        bool cVar2;
        BattleUnit.LeaveBattleField(this,0);
        cVar2 = Object.op_Inequality(this,0,0);
        if (cVar2) {
          uVar1 = Component.get_gameObject(this,0);
          Object.Destroy(uVar1,0);
          return;
        }
    }

    // Token : 0x6000C6F
    // RVA   : 0x8D2BF0   Offset: 0x8D1FF0   Length: 0x98
    public IEnumerator MoveFromTarget(GridUnitData targetGrid, int num)
    {
        long lVar1;
        lVar1 = new WarpText_d__8(0,0);
        if (lVar1 != null) {
          *(uint64 *)(lVar1 + 40) = this;
          *(uint64 *)(lVar1 + 48) = targetGrid;
          *(uint32 *)(lVar1 + 32) = num;
          return lVar1;
        }
    }

    // Token : 0x6000C70
    // RVA   : 0x8CD590   Offset: 0x8CC990   Length: 0x8A6
    public void AddBuff(int id, float time)
    {
        var pStatics_3d40 = *(int64*)(DAT_181d73d40 + 184);
        long lVar1;
        float fVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar7;
        long lVar8;
        long lVar9;
        float fVar10;
        float[] local_res18 = new float[4];
        uint local_48;
        uint uStack_44;
        uint uStack_40;
        uint32 uStack_3c;
        lVar9 = (int64)(int)id;
        local_res18[0] = time;
        fVar2 = local_res18[0];
        if ((this.heroData == null) ||
           (lVar1 = this.heroData.heroBuff) == null) throw; // [null/range check failed]
        fVar10 = (float)HeroSpeAddData.Get(lVar1,id,0);
        if (fVar10 < fVar2) {
        LAB_1808cd75c:
          if (this.heroData == null) throw; // [null/range check failed]
          HeroData.AddBuff(this.heroData,id,local_res18[0],0);
        }
        else {
          lVar1 = GameController.lockObj;
          if ((lVar1 == null) || (lVar1 = *(int64 *)(lVar1 + 144)) == null) throw; // [null/range check failed]
          if (*(uint32 *)(lVar1 + 24) <= id) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar1 = *(int64 *)(*(int64 *)(lVar1 + 16) + 32 + lVar9 * 8);
          if (lVar1 == null) throw; // [null/range check failed]
          if (*(char *)(lVar1 + 90) != false) goto LAB_1808cd75c;
        }
        lVar1 = GameController.lockObj;
        if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 144)) != null) {
          if (*(uint32 *)(lVar1 + 24) <= id) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar1 = *(int64 *)(*(int64 *)(lVar1 + 16) + 32 + lVar9 * 8);
          if (lVar1 != null) {
            uVar4 = *(uint64 *)(lVar1 + 16);
            if (this.heroData != null) {
              uVar3 = HeroData.GetBuffLevelString(this.heroData,id,0);
              uVar4 = String.Concat(uVar4,uVar3,0);
              lVar1 = GameController.lockObj;
              if ((lVar1 != null) && (lVar1 = *(int64 *)(lVar1 + 144)) != null) {
                if (*(uint32 *)(lVar1 + 24) <= id) {
                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                }
                lVar1 = *(int64 *)(*(int64 *)(lVar1 + 16) + 32 + lVar9 * 8);
                if (lVar1 != null) {
                  if (*(char *)(lVar1 + 64) == false) {
                    puVar5 = (uint32 *)Color.get_red(&local_48);
                  }
                  else {
                    puVar5 = (uint32 *)Color.get_green();
                  }
                  local_48 = *puVar5;
                  uStack_44 = puVar5[1];
                  uStack_40 = puVar5[2];
                  uStack_3c = puVar5[3];
                  BattleUnit.ShowTextOnHead(this,uVar4,&local_48,18,24,"UIAtlas",0,0,0);
                  lVar1 = *(int64 *)(*(int64 *)(DAT_181db0260 + 184) + 80);
                  plVar6 = (int64 *)FUN_1800d60b0(DAT_181da4138,4);
                  if (this.heroData != null) {
                    lVar7 = HeroData.Name(this.heroData,1,0);
                    if (plVar6 != (int64 *)0) {
                      if (lVar7 != null) {
                        lVar8 = il2cpp_internal(lVar7,*(uint64 *)(*plVar6 + 64));
                        if (lVar8 == null) {
                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                          FUN_1800d65f0(uVar4,0);
                        }
                      }
                      if ((int)plVar6[3] == 0) {
                        uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                        FUN_1800d65f0(uVar4,0);
                      }
                      plVar6[4] = lVar7;
                      il2cpp_internal(plVar6 + 4,lVar7);
                      lVar7 = GameController.lockObj;
                      if ((lVar7 != null) && (lVar7 = *(int64 *)(lVar7 + 144)) != null) {
                        if (*(uint32 *)(lVar7 + 24) <= id) {
                          ThrowHelper.ThrowArgumentOutOfRangeException(0);
                        }
                        uVar4 = "({0}{1}{2}{3})";
                        lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32 + lVar9 * 8);
                        if (lVar7 != null) {
                          if (*(char *)(lVar7 + 64) == false) {
                            uVar3 = *(uint64 *)(pStatics_3d40 + 0x2d0);
                          }
                          else {
                            uVar3 = *(uint64 *)(pStatics_3d40 + 0x268);
                          }
                          lVar7 = GameController.lockObj;
                          if ((lVar7 != null) && (lVar7 = *(int64 *)(lVar7 + 144)) != null) {
                            if (*(uint32 *)(lVar7 + 24) <= id) {
                              ThrowHelper.ThrowArgumentOutOfRangeException(0);
                            }
                            lVar7 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32 + lVar9 * 8);
                            if (lVar7 != null) {
                              lVar7 = String.Concat(uVar3,*(uint64 *)(lVar7 + 16),"</color>",0);
                              if (lVar7 != null) {
                                lVar8 = il2cpp_internal(lVar7,*(uint64 *)(*plVar6 + 64));
                                if (lVar8 == null) {
                                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                  FUN_1800d65f0(uVar4,0);
                                }
                              }
                              if (*(uint32 *)(plVar6 + 3) < 2) {
                                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar4,0);
                              }
                              plVar6[5] = lVar7;
                              il2cpp_internal(plVar6 + 5,lVar7);
                              lVar7 = Single.ToString(local_res18,"0.#",0);
                              if (lVar7 != null) {
                                lVar8 = il2cpp_internal(lVar7,*(uint64 *)(*plVar6 + 64));
                                if (lVar8 == null) {
                                  uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                  FUN_1800d65f0(uVar4,0);
                                }
                              }
                              if (*(uint32 *)(plVar6 + 3) < 3) {
                                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar4,0);
                              }
                              plVar6[6] = lVar7;
                              il2cpp_internal(plVar6 + 6,lVar7);
                              lVar7 = GameController.lockObj;
                              if ((lVar7 != null) && (lVar7 = *(int64 *)(lVar7 + 144)) != null) {
                                if (*(uint32 *)(lVar7 + 24) <= id) {
                                  ThrowHelper.ThrowArgumentOutOfRangeException(0);
                                }
                                lVar9 = *(int64 *)(*(int64 *)(lVar7 + 16) + 32 + lVar9 * 8);
                                if (lVar9 != null) {
                                  lVar7 = "合";
                                  if (*(int *)(lVar9 + 60) == -1) {
                                    lVar7 = "秒";
                                  }
                                  if (lVar7 != null) {
                                    lVar9 = il2cpp_internal(lVar7,*(uint64 *)(*plVar6 + 64));
                                    if (lVar9 == null) {
                                      uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                      FUN_1800d65f0(uVar4,0);
                                    }
                                  }
                                  if (*(uint32 *)(plVar6 + 3) < 4) {
                                    uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1800d65f0(uVar4,0);
                                  }
                                  plVar6[7] = lVar7;
                                  il2cpp_internal(plVar6 + 7,lVar7);
                                  uVar4 = String.Format(uVar4,plVar6,0);
                                  if (lVar1 != null) {
                                    BattleController.AddInfoText(lVar1,uVar4,1,0);
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

    // Token : 0x6000C71
    // RVA   : 0x8D12D0   Offset: 0x8D06D0   Length: 0x571
    public void EnterGrid(GridUnitData grid, bool noTurnRotation, bool teleport)
    {
        var pStatics_0260 = *(int64*)(DAT_181db0260 + 184);
        float fVar2;
        float fVar3;
        long lVar4;
        long lVar5;
        ulong uVar7;
        int iVar8;
        float fVar9;
        ulong local_68;
        ulong local_58;
        ulong local_48;
        float local_40;
        byte[] local_38 = new byte[32];
        if (grid == null) {
          fVar3 = local_40;
          if (this.heroData != null) {
            uVar7 = String.Format("Battle unit {0} enter grid failed, grid is null.",this.heroData.heroName,0);
            Debug.LogError(uVar7,0);
            return;
          }
          goto LAB_1808d183c;
        }
        plVar1 = &this.mapGrid;
        if (this.mapGrid != null) {
          if ((!noTurnRotation) && (!teleport)) {
            iVar8 = this.mapGrid.column;
            if (iVar8 < *(int *)(grid + 40)) {
              uVar7 = 1;
            }
            else {
              if (iVar8 > *(int *)(grid + 40))
              {
                uVar7 = 0;
                }
                BattleUnit.ChangeFaceDirection(this,uVar7,0,0);
                }
              }
          if (this.mapGrid != null) {
            BattleUnit.SetDownObstacleNeedRefresh(this,0);
            fVar3 = local_40;
            if (this.mapGrid == null) goto LAB_1808d183c;
            GridUnitData.OnLeave(this.mapGrid,0);
            this.mapGrid = 0;
            il2cpp_internal(plVar1,0);
          }
        }
        this.mapGrid = grid;
        il2cpp_internal(plVar1,grid);
        lVar4 = Component.get_transform(this,0);
        lVar5 = this.mapGrid;
        fVar3 = local_40;
        if (!teleport) {
          if (((lVar5 != null) && (lVar5 = GridUnitData.get_GridObj(lVar5,0), fVar3 = local_40) != null)
             && (lVar5 = GameObject.get_transform(lVar5,0), fVar3 = local_40) != null) {
            puVar6 = (uint64 *)Transform.get_localPosition(local_38,lVar5,0);
            uVar7 = *puVar6;
            fVar9 = *(float *)(puVar6 + 1);
            local_68._0_4_ = (float)uVar7;
            local_68._4_4_ = (float)((uint64)uVar7 >> 32);
            local_48 = *(uint64 *)(pStatics_0260 + 28);
            local_40 = *(float *)(pStatics_0260 + 36);
            fVar9 = fVar9 + local_40;
            local_58 = CONCAT44(local_68._4_4_ + (float)((uint64)local_48 >> 32),
                                (float)local_68 + (float)local_48);
            fVar2 = *(float *)(*(int64 *)(DAT_181db07e0 + 184) + 24);
            fVar3 = local_40;
            if ((GameController._instance != null) &&
               (lVar5 = GameController._instance.worldData) != null) {
              local_48 = local_58;
              local_40 = fVar9;
              uVar7 = ShortcutExtensions.DOLocalMove
                                (lVar4,&local_48,fVar2 / lVar5.battleTimeScale,0,0);
              TweenSettingsExtensions.SetEase(uVar7,1,DAT_181dc1128);
        LAB_1808d169b:
              GridUnitData.OnEnter(grid,this,0);
              if (this.mapGrid != null) {
                iVar8 = -1;
                do {
                  fVar3 = local_40;
                  if (this.mapGrid == null) goto LAB_1808d183c;
                  if (this.mapGrid.row + iVar8 < 0) {
                    return;
                  }
                  lVar5 = FUN_18046bb80(0);
                  fVar3 = local_40;
                  if ((((lVar5 == null) || (lVar4 = this.mapGrid) == null) ||
                      (lVar5.cityAreaID == null)) ||
                     (lVar5 = BattleMapData.GetGridData
                                        (lVar5.cityAreaID,*(int *)(lVar4 + 36) + iVar8,
                                         *(uint32 *)(lVar4 + 40),0), fVar3 = local_40, lVar5 == null))
                  goto LAB_1808d183c;
                  if (*(int *)(lVar5 + 20) == 2) {
                    lVar5 = FUN_18046bb80(0);
                    fVar3 = local_40;
                    if (((lVar5 == null) || (lVar4 = this.mapGrid) == null) ||
                       ((lVar5.cityAreaID == null ||
                        ((lVar5 = BattleMapData.GetGridData
                                            (lVar5.cityAreaID,*(int *)(lVar4 + 36) + iVar8,
                                             *(uint32 *)(lVar4 + 40),0), fVar3 = local_40,
                         lVar5 == null || (lVar5.Areas == null)))))) goto LAB_1808d183c;
                    *(uint8 *)(lVar5.Areas + 64) = 1;
                  }
                  iVar8 = iVar8 + -1;
                } while (-4 < iVar8);
              }
              return;
            }
          }
        }
        else if (((lVar5 != null) &&
                 (lVar5 = GridUnitData.get_GridObj(lVar5,0), fVar3 = local_40) != null) &&
                (lVar5 = GameObject.get_transform(lVar5,0), fVar3 = local_40) != null) {
          puVar6 = (uint64 *)Transform.get_localPosition(local_38,lVar5,0);
          uVar7 = *puVar6;
          fVar9 = *(float *)(puVar6 + 1);
          local_58._0_4_ = (float)uVar7;
          local_58._4_4_ = (float)((uint64)uVar7 >> 32);
          local_48 = *(uint64 *)(pStatics_0260 + 28);
          fVar3 = *(float *)(pStatics_0260 + 36);
          local_40 = fVar9 + fVar3;
          local_68 = CONCAT44(local_58._4_4_ + (float)((uint64)local_48 >> 32),
                              (float)local_58 + (float)local_48);
          if (lVar4 != null) {
            local_48 = local_68;
            Transform.set_localPosition(lVar4,&local_48,0);
            goto LAB_1808d169b;
          }
        }
        LAB_1808d183c:
        local_40 = fVar3;
    }

    // Token : 0x6000C72
    // RVA   : 0x8D2BA0   Offset: 0x8D1FA0   Length: 0x48
    public void LeaveGrid()
    {
        plVar1 = &this.mapGrid;
        if (this.mapGrid == null) {
          return;
        }
        BattleUnit.SetDownObstacleNeedRefresh(this,0);
        if (this.mapGrid != null) {
          GridUnitData.OnLeave(this.mapGrid,0);
          this.mapGrid = 0;
          il2cpp_internal(plVar1,0);
          return;
        }
    }

    // Token : 0x6000C73
    // RVA   : 0x8D4670   Offset: 0x8D3A70   Length: 0x138
    public void SetDownObstacleNeedRefresh()
    {
        long lVar1;
        long lVar2;
        int iVar3;
        if (this.mapGrid != null) {
          iVar3 = -1;
          do {
            if (this.mapGrid == null) {
        LAB_1808d47a3:
                          // WARNING: Subroutine does not return
              FUN_1800d6620();
            }
            if (this.mapGrid.row + iVar3 < 0) {
              return;
            }
            lVar2 = FUN_18046bb80(0);
            if ((((lVar2 == null) || (lVar1 = this.mapGrid) == null) ||
                (*(int64 *)(lVar2 + 24) == 0)) ||
               (lVar2 = BattleMapData.GetGridData
                                  (*(int64 *)(lVar2 + 24),*(int *)(lVar1 + 36) + iVar3,
                                   *(uint32 *)(lVar1 + 40),0), lVar2 == null)) goto LAB_1808d47a3;
            if (*(int *)(lVar2 + 20) == 2) {
              lVar2 = FUN_18046bb80(0);
              if (((lVar2 == null) || (lVar1 = this.mapGrid) == null) ||
                 ((*(int64 *)(lVar2 + 24) == 0 ||
                  ((lVar2 = BattleMapData.GetGridData
                                      (*(int64 *)(lVar2 + 24),*(int *)(lVar1 + 36) + iVar3,
                                       *(uint32 *)(lVar1 + 40),0), lVar2 == null ||
                   (*(int64 *)(lVar2 + 48) == 0)))))) goto LAB_1808d47a3;
              *(uint8 *)(*(int64 *)(lVar2 + 48) + 64) = 1;
            }
            iVar3 = iVar3 + -1;
          } while (-4 < iVar3);
        }
    }

    // Token : 0x6000C74
    // RVA   : 0x272A00   Offset: 0x271E00   Length: 0xC
    public void JoinBattleTeam(BattleTeam team)
    {
        void FUN_180272a00(int64 this,uint64 team)
        {
        this.battleTeam = team;
    }

    // Token : 0x6000C75
    // RVA   : 0x8D3030   Offset: 0x8D2430   Length: 0x12
    public void QuitBattleTeam()
    {
        void FUN_1808d3030(int64 this)
        {
        this.battleTeam = 0;
    }

    // Token : 0x6000C76
    // RVA   : 0x8D1F70   Offset: 0x8D1370   Length: 0x36B
    public string GetStartFightTalk(bool isSupport)
    {
        long lVar1;
        uint uVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar6;
        ulong uVar7;
        ulong uVar8;
        uVar5 = "";
        if (!isSupport) {
          lVar3 = *(int64 *)(*(int64 *)(DAT_181db0260 + 184) + 80);
          if (lVar3 != null) {
            if (lVar3.needProtectUnits == null) {
              lVar3 = BattleUnit.StudyFightStartTalk;
            }
            else {
              if (**(int **)(DAT_181d73d40 + 184) == 2) {
                return uVar5;
              }
              lVar3 = BattleUnit.DeathFightStartTalk;
            }
            if (lVar3 != null) {
              uVar2 = FUN_180d96040(0,lVar3.battleUnits,0);
              if (lVar3.battleUnits <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              return lVar3.ID[uVar2];
            }
          }
        }
        else {
          lVar3 = this.battleTeam;
          uVar8 = 0;
          if (lVar3 != null) {
            lVar6 = 32;
            uVar7 = uVar8;
            while (lVar3.battleUnits != null) {
              uVar2 = (uint32)uVar7;
              if (*(int *)(lVar3.battleUnits + 24) <= (int)uVar2) {
        LAB_1808d2257:
                uVar5 = "{0}莫慌，\n我来助阵！";
                uVar4 = "";
                if (uVar8 != 0) {
                  lVar3 = FUN_18046c0a0(0);
                  if (lVar3 == null) break;
                  uVar4 = GameController.GetHeroName(lVar3,this.heroData,uVar8,0);
                }
                uVar5 = String.Format(uVar5,uVar4,0);
                return uVar5;
              }
              if ((lVar3 = lVar3?.battleUnits) == null) break;
              if (lVar3.battleUnits <= uVar2) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar3 = *(int64 *)(lVar6 + lVar3.ID);
              if ((lVar3 == null) || (lVar1 = *(int64 *)(lVar3 + 64)) == null) break;
              lVar3 = this.battleTeam;
              if (*(char *)(lVar1 + 16) == false) {
                if (((lVar3 != null) && (lVar3.battleUnits != null)) &&
                   (lVar3 = FUN_180002f80(lVar3.battleUnits,uVar7,DAT_181d7fc38)) != null) {
                  uVar8 = *(uint64 *)(lVar3 + 64);
                  goto LAB_1808d2257;
                }
                break;
              }
              uVar7 = (uint64)(uVar2 + 1);
              lVar6 = lVar6 + 8;
              if (lVar3 == null) break;
            }
          }
        }
    }

    // Token : 0x6000C77
    // RVA   : 0x8D2C90   Offset: 0x8D2090   Length: 0xD5
    private void OnDestroy()
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        uVar3 = this.skeleton;
        cVar2 = Object.op_Inequality(uVar3,0,0);
        if (cVar2) {
          if (this.skeleton == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          lVar1 = *(int64 *)(this.skeleton + 224);
          if (lVar1 != null) {
            uVar3 = new OnTooltipCB(this,DAT_181d89408,0);
            AnimationState.remove_Event(lVar1,uVar3,0);
          }
        }
    }

    // Token : 0x6000C78
    // RVA   : 0x8D67D0   Offset: 0x8D5BD0   Length: 0x68
    public void /*ctor*/()
    {
        ulong uVar1;
        this.battleInfo = new ZhSegment(0);
        FUN_18044ef50(this,0);
    }

    // Token : 0x6000C79
    // RVA   : 0x8D5900   Offset: 0x8D4D00   Length: 0xECE
    private static void /*cctor*/()
    {
        var pStatics = *(int64*)(DAT_181db07e0 + 184);
        long lVar2;
        ulong local_38;
        uint local_30;
        puVar1 = *(uint64 **)(DAT_181db07e0 + 184);
        *puVar1 = 0x3d99999a00000000;
        *(uint32 *)(puVar1 + 1) = 0;
        local_30 = 0x3f800000;
        lVar2 = pStatics;
        *(uint64 *)(lVar2 + 12) = 0x3e4ccccd3ecccccd;
        *(uint32 *)(lVar2 + 20) = 0x3f800000;
        BattleUnit.UnitMoveOneGridTime = 0x3e4ccccd;
        BattleUnit.damageBaseFontSize = 25;
        lVar2 = il2cpp_internal(DAT_181d98be8);
        FUN_181330100(lVar2,DAT_181dabbb0);
        if (lVar2 != null) {
          local_38 = 0x4120000000000000;
          local_30 = 0;
          FUN_181817190(lVar2,&local_38,DAT_181dabc30);
          local_38 = 0xc160000000000000;
          local_30 = 0;
          FUN_181817190(lVar2,&local_38,DAT_181dabc30);
          local_38 = 0x40a0000000000000;
          local_30 = 0;
          FUN_181817190(lVar2,&local_38,DAT_181dabc30);
          local_38 = 0x4120000000000000;
          local_30 = 0;
          FUN_181817190(lVar2,&local_38,DAT_181dabc30);
          local_38 = 0x4120000000000000;
          local_30 = 0;
          FUN_181817190(lVar2,&local_38,DAT_181dabc30);
          local_38 = 0;
          local_30 = 0;
          FUN_181817190(lVar2,&local_38,DAT_181dabc30);
          local_38 = 0x4120000000000000;
          local_30 = 0;
          FUN_181817190(lVar2,&local_38,DAT_181dabc30);
          local_38 = 0;
          local_30 = 0;
          FUN_181817190(lVar2,&local_38,DAT_181dabc30);
          local_38 = 0xc1a0000000000000;
          local_30 = 0;
          FUN_181817190(lVar2,&local_38,DAT_181dabc30);
          local_38 = 0x4120000000000000;
          local_30 = 0;
          FUN_181817190(lVar2,&local_38,DAT_181dabc30);
          BattleUnit.SummonFollowUIOffset = lVar2;
          lVar2 = il2cpp_internal(DAT_181d97768);
          FUN_181330100(lVar2,DAT_181da3bf0);
          if (lVar2 != null) {
            FUN_18181e6b0(lVar2,"不堪一击",DAT_181da3d70);
            FUN_18181e6b0(lVar2,"承让承让",DAT_181da3d70);
            FUN_18181e6b0(lVar2,"得罪了",DAT_181da3d70);
            FUN_18181e6b0(lVar2,"我还未出全力",DAT_181da3d70);
            FUN_18181e6b0(lVar2,"山外有山，人外有人",DAT_181da3d70);
            FUN_18181e6b0(lVar2,"破！",DAT_181da3d70);
            FUN_18181e6b0(lVar2,"着！",DAT_181da3d70);
            FUN_18181e6b0(lVar2,"得手了",DAT_181da3d70);
            FUN_18181e6b0(lVar2,"拿下一城",DAT_181da3d70);
            FUN_18181e6b0(lVar2,"中！",DAT_181da3d70);
            BattleUnit.HeroKillTalk = lVar2;
            lVar2 = il2cpp_internal(DAT_181d97768);
            FUN_181330100(lVar2,DAT_181da3bf0);
            if (lVar2 != null) {
              FUN_18181e6b0(lVar2,"唔！",DAT_181da3d70);
              FUN_18181e6b0(lVar2,"可恶...",DAT_181da3d70);
              FUN_18181e6b0(lVar2,"好功夫！",DAT_181da3d70);
              FUN_18181e6b0(lVar2,"甘拜下风",DAT_181da3d70);
              FUN_18181e6b0(lVar2,"愿赌服输",DAT_181da3d70);
              FUN_18181e6b0(lVar2,"技不如人",DAT_181da3d70);
              FUN_18181e6b0(lVar2,"唔啊",DAT_181da3d70);
              FUN_18181e6b0(lVar2,"败矣",DAT_181da3d70);
              FUN_18181e6b0(lVar2,"糟糕",DAT_181da3d70);
              FUN_18181e6b0(lVar2,"啊！",DAT_181da3d70);
              FUN_18181e6b0(lVar2,"不可能",DAT_181da3d70);
              FUN_18181e6b0(lVar2,"为之奈何...",DAT_181da3d70);
              FUN_18181e6b0(lVar2,"怎会如此...",DAT_181da3d70);
              FUN_18181e6b0(lVar2,"终究棋差一着",DAT_181da3d70);
              FUN_18181e6b0(lVar2,"竟败于你手",DAT_181da3d70);
              FUN_18181e6b0(lVar2,"我本有机会...",DAT_181da3d70);
              FUN_18181e6b0(lVar2,"无力再战了",DAT_181da3d70);
              BattleUnit.HeroDeadTalk = lVar2;
              lVar2 = il2cpp_internal(DAT_181d97768);
              FUN_181330100(lVar2,DAT_181da3bf0);
              if (lVar2 != null) {
                FUN_18181e6b0(lVar2,"唔！",DAT_181da3d70);
                FUN_18181e6b0(lVar2,"可恶...",DAT_181da3d70);
                FUN_18181e6b0(lVar2,"已经到极限了",DAT_181da3d70);
                FUN_18181e6b0(lVar2,"到此为止了吗？",DAT_181da3d70);
                FUN_18181e6b0(lVar2,"一点小伤而已",DAT_181da3d70);
                FUN_18181e6b0(lVar2,"还不可轻言失败",DAT_181da3d70);
                FUN_18181e6b0(lVar2,"糟糕",DAT_181da3d70);
                FUN_18181e6b0(lVar2,"情势不妙",DAT_181da3d70);
                FUN_18181e6b0(lVar2,"天旋地转",DAT_181da3d70);
                FUN_18181e6b0(lVar2,"为之奈何...",DAT_181da3d70);
                FUN_18181e6b0(lVar2,"怎会如此...",DAT_181da3d70);
                FUN_18181e6b0(lVar2,"眼冒金星",DAT_181da3d70);
                FUN_18181e6b0(lVar2,"鹿死谁手犹未可知",DAT_181da3d70);
                FUN_18181e6b0(lVar2,"该如何力挽狂澜",DAT_181da3d70);
                FUN_18181e6b0(lVar2,"渐处下风，得想想办法",DAT_181da3d70);
                FUN_18181e6b0(lVar2,"我竟会如此狼狈",DAT_181da3d70);
                BattleUnit.HeroLowHpTalk = lVar2;
                lVar2 = il2cpp_internal(DAT_181d97768);
                FUN_181330100(lVar2,DAT_181da3bf0);
                if (lVar2 != null) {
                  FUN_18181e6b0(lVar2,"得罪了",DAT_181da3d70);
                  FUN_18181e6b0(lVar2,"进招吧",DAT_181da3d70);
                  FUN_18181e6b0(lVar2,"点到为止",DAT_181da3d70);
                  FUN_18181e6b0(lVar2,"今日一战我期待已久",DAT_181da3d70);
                  FUN_18181e6b0(lVar2,"请指教",DAT_181da3d70);
                  FUN_18181e6b0(lVar2,"刀剑无眼，请多加小心",DAT_181da3d70);
                  FUN_18181e6b0(lVar2,"我已有三成把握",DAT_181da3d70);
                  BattleUnit.StudyFightStartTalk = lVar2;
                  lVar2 = il2cpp_internal(DAT_181d97768);
                  FUN_181330100(lVar2,DAT_181da3bf0);
                  if (lVar2 != null) {
                    FUN_18181e6b0(lVar2,"快刀斩乱麻吧",DAT_181da3d70);
                    FUN_18181e6b0(lVar2,"战端一起，恐怕难以善罢甘休",DAT_181da3d70);
                    FUN_18181e6b0(lVar2,"今日看来非得见血不可了",DAT_181da3d70);
                    FUN_18181e6b0(lVar2,"十步杀一人，千里不留行",DAT_181da3d70);
                    FUN_18181e6b0(lVar2,"此时若要后悔，恐怕也太迟了",DAT_181da3d70);
                    FUN_18181e6b0(lVar2,"既然你如此相逼，我也只好出手了",DAT_181da3d70);
                    FUN_18181e6b0(lVar2,"成王败寇，在此一战",DAT_181da3d70);
                    FUN_18181e6b0(lVar2,"今日你我，必有一人血溅当场",DAT_181da3d70);
                    FUN_18181e6b0(lVar2,"十年磨一剑，霜刃未曾试",DAT_181da3d70);
                    FUN_18181e6b0(lVar2,"是何人敢与我一战？",DAT_181da3d70);
                    FUN_18181e6b0(lVar2,"求死之人，神仙也难救",DAT_181da3d70);
                    FUN_18181e6b0(lVar2,"波澜已至，谁又能独善其身",DAT_181da3d70);
                    FUN_18181e6b0(lVar2,"自不量力",DAT_181da3d70);
                    BattleUnit.DeathFightStartTalk = lVar2;
                    lVar2 = il2cpp_internal(DAT_181d97768);
                    FUN_181330100(lVar2,DAT_181da3bf0);
                    if (lVar2 != null) {
                      FUN_18181e6b0(lVar2,"#SkillName#！",DAT_181da3d70);
                      FUN_18181e6b0(lVar2,"可识得此招#SkillName#？",DAT_181da3d70);
                      FUN_18181e6b0(lVar2,"尝尝这招#SkillName#",DAT_181da3d70);
                      FUN_18181e6b0(lVar2,"这#SkillName#你能否抵挡？",DAT_181da3d70);
                      FUN_18181e6b0(lVar2,"这#SkillName#乃我成名绝学",DAT_181da3d70);
                      BattleUnit.UseSkillTalk = lVar2;
                      lVar2 = il2cpp_internal(DAT_181d97768);
                      FUN_181330100(lVar2,DAT_181da3bf0);
                      if (lVar2 != null) {
                        FUN_18181e6b0(lVar2,"{0}！",DAT_181da3d70);
                        FUN_18181e6b0(lVar2,"竟敢伤我{0}！",DAT_181da3d70);
                        FUN_18181e6b0(lVar2,"{0}当心！",DAT_181da3d70);
                        FUN_18181e6b0(lVar2,"休要伤我{0}！",DAT_181da3d70);
                        FUN_18181e6b0(lVar2,"{0}你快退开，此处交给我便是！",DAT_181da3d70);
                        FUN_18181e6b0(lVar2,"竟然连{0}也...",DAT_181da3d70);
                        FUN_18181e6b0(lVar2,"{0}！你没事吧！",DAT_181da3d70);
                        BattleUnit.FriendDeadTalk = lVar2;
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
