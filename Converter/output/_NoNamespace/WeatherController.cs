// ============================================================
// Type  : WeatherController
// Token : 0x20003B3
// ============================================================

public class WeatherController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001DF0
    public GameObject weatherSpeObjRoot;

    // Token: 0x4001DF1
    public List<WeatherData> WeatherDataBase;

    // Token: 0x4001DF2
    public PostProcessVolume postProcessVolume;

    // Token: 0x4001DF3
    private float nextThunderTime;

    // Token: 0x4001DF4
    private float totalThunderTime;

    // Token: 0x4001DF5
    private float leftThunderTime;

    // Token: 0x4001DF6
    private readonly List<AudioSource> weatherSpeAudioSources;

    // Token: 0x4001DF7
    private readonly List<List<ParticleSystem>> weatherSpeParticleSystems;

    // Token: 0x4001DF8
    private ColorGrading colorGrading;

    // Token: 0x4001DF9
    private float currentExposure;

    // Token: 0x4001DFA
    private static readonly AudioClip[] thunderClips;

    // Token: 0x4001DFB
    private static WeatherController _instance;

    // Token: 0x4001DFC
    private bool totalFinish;

    // Token: 0x4001DFD
    private List<GameObject> needHideWeatherObj;

    // Token: 0x4001DFE
    private EmissionModule emission;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6002381
    // RVA   : 0xC18740   Offset: 0xC17B40   Length: 0x58
    public static WeatherController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181db4f18 + 184) + 8);
    }

    // Token : 0x6002382
    // RVA   : 0xC165C0   Offset: 0xC159C0   Length: 0xE0
    private void Awake()
    {
        ulong uVar1;
        bool cVar2;
        uVar1 = BattleController.AttackAreaTypeStartMovePower;
        cVar2 = Object.op_Equality(uVar1,0,0);
        if (cVar2) {
          BattleController.AttackAreaTypeStartMovePower = this;
        }
    }

    // Token : 0x6002383
    // RVA   : 0xC17560   Offset: 0xC16960   Length: 0x6D8
    private void Start()
    {
        bool cVar1;
        int iVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        long lVar7;
        uint uVar8;
        long lVar9;
        int iVar10;
        uint uVar11;
        ulong local_res18;
        local_res18 = 0;
        lVar3 = Camera.get_main(0);
        if (lVar3 != null) {
          uVar4 = Component.GetComponent(lVar3,DAT_181d94ce0);
          this.postProcessVolume = uVar4;
          if ((this.postProcessVolume != null) &&
             (lVar3 = PostProcessVolume.get_profile(this.postProcessVolume,0)) != null) {
            uVar4 = PostProcessProfile.GetSetting(lVar3,DAT_181d98490);
            this.colorGrading = uVar4;
            if ((this.colorGrading != null) &&
               (lVar3 = *(int64 *)(this.colorGrading + 176)) != null) {
              this.currentExposure = lVar3.Count;
              if (this.weatherSpeAudioSources != null) {
                FUN_1812f9a10(this.weatherSpeAudioSources,DAT_181d7ded0);
                if (this.weatherSpeParticleSystems != null) {
                  FUN_1812f9a10(this.weatherSpeParticleSystems,DAT_181d78f28);
                  lVar3 = this.WeatherDataBase;
                  uVar8 = 0;
                  if (lVar3 != null) {
                    lVar9 = 32;
                    do {
                      if (lVar3.Count <= (int)uVar8) {
                        return;
                      }
                      if (this.weatherSpeAudioSources == null) break;
                      FUN_18181e0a0(this.weatherSpeAudioSources,0,DAT_181d7de50);
                      if (this.weatherSpeParticleSystems == null) break;
                      FUN_18181e0a0(this.weatherSpeParticleSystems,0,DAT_181d78ea8);
                      lVar3 = this.WeatherDataBase;
                      if (lVar3 == null) break;
                      if (lVar3.Count <= uVar8) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar3 = *(int64 *)(lVar3._items + lVar9);
                      if (lVar3 == null) break;
                      uVar4 = *(uint64 *)(lVar3 + 40);
                      cVar1 = Object.op_Inequality(uVar4,0,0);
                      if (cVar1) {
                        if (((this.WeatherDataBase == null) ||
                            (lVar3 = FUN_180002f80(this.WeatherDataBase,uVar8,DAT_181dac888),
                            lVar3 == null)) || (*(int64 *)(lVar3 + 40) == 0)) break;
                        lVar3 = GameObject.GetComponent(*(int64 *)(lVar3 + 40),DAT_181dc72f8);
                        if (this.weatherSpeAudioSources == null) break;
                        FUN_181829cd0(this.weatherSpeAudioSources,uVar8,lVar3,DAT_181d7e050);
                        lVar5 = il2cpp_internal(DAT_181d95050);
                        FUN_18132faf0(lVar5,DAT_181d96808);
                        if (this.weatherSpeParticleSystems == null) break;
                        FUN_181829cd0(this.weatherSpeParticleSystems,uVar8,lVar5,DAT_181d79028);
                        if ((this.WeatherDataBase == null) ||
                           (lVar6 = FUN_180002f80(this.WeatherDataBase,uVar8,DAT_181dac888),
                           lVar6 == null)) break;
                        lVar6 = *(int64 *)(lVar6 + 48);
                        if ((this.WeatherDataBase == null) ||
                           ((lVar7 = FUN_180002f80(this.WeatherDataBase,uVar8,DAT_181dac888),
                            lVar7 == null || (lVar6 == null)))) break;
                        FUN_18181e0a0(lVar6,*(uint64 *)(lVar7 + 40),DAT_181d89398);
                        if ((this.WeatherDataBase == null) ||
                           (((lVar6 = FUN_180002f80(this.WeatherDataBase,uVar8,DAT_181dac888),
                             lVar6 == null || (*(int64 *)(lVar6 + 40) == 0)) ||
                            (lVar6 = GameObject.GetComponent(*(int64 *)(lVar6 + 40),DAT_181d72700),
                            lVar5 == null)))) break;
                        FUN_18181e0a0(lVar5,lVar6,DAT_181d96888);
                        if (((this.WeatherDataBase == null) ||
                            (lVar7 = FUN_180002f80(this.WeatherDataBase,uVar8,DAT_181dac888),
                            lVar7 == null)) || (lVar7 = *(int64 *)(lVar7 + 56), lVar6 == null)) break;
                        local_res18 = FUN_1804651e0(lVar6,0);
                        uVar11 = FUN_1804645a0(&local_res18,0);
                        if (lVar7 == null) break;
                        FUN_18181de10(lVar7,uVar11,DAT_181da0df8);
                        iVar10 = 0;
                        while( true ) {
                          if (((this.WeatherDataBase == null) ||
                              (lVar6 = FUN_180002f80(this.WeatherDataBase,uVar8,DAT_181dac888),
                              lVar6 == null)) ||
                             ((*(int64 *)(lVar6 + 40) == 0 ||
                              (lVar6 = GameObject.get_transform(*(int64 *)(lVar6 + 40),0),
                              lVar6 == null)))) throw; // [null/range check failed]
                          iVar2 = Transform.get_childCount(lVar6,0);
                          lVar6 = this.WeatherDataBase;
                          if (iVar2 <= iVar10) break;
                          if (((lVar6 == null) ||
                              (lVar6 = FUN_180002f80(lVar6,uVar8,DAT_181dac888)) == null) ||
                             ((*(int64 *)(lVar6 + 40) == 0 ||
                              ((lVar6 = GameObject.get_transform(*(int64 *)(lVar6 + 40),0),
                               lVar6 == null || (lVar6 = Transform.GetChild(lVar6,iVar10,0)) == null))))
                             ) throw; // [null/range check failed]
                          lVar6 = Component.get_gameObject(lVar6,0);
                          if ((this.WeatherDataBase == null) ||
                             (((lVar7 = FUN_180002f80(this.WeatherDataBase,uVar8,DAT_181dac888),
                               lVar7 == null || (*(int64 *)(lVar7 + 48) == 0)) ||
                              (FUN_18181e0a0(*(int64 *)(lVar7 + 48),lVar6,DAT_181d89398), lVar6 == null)
                              ))) throw; // [null/range check failed]
                          lVar6 = GameObject.GetComponent(lVar6,DAT_181d72700);
                          FUN_18181e0a0(lVar5,lVar6,DAT_181d96888);
                          if (((this.WeatherDataBase == null) ||
                              (lVar7 = FUN_180002f80(this.WeatherDataBase,uVar8,DAT_181dac888),
                              lVar7 == null)) || (lVar7 = *(int64 *)(lVar7 + 56), lVar6 == null))
                          throw; // [null/range check failed]
                          local_res18 = FUN_1804651e0(lVar6,0);
                          uVar11 = FUN_1804645a0(&local_res18,0);
                          if (lVar7 == null) throw; // [null/range check failed]
                          FUN_18181de10(lVar7,uVar11,DAT_181da0df8);
                          iVar10 = iVar10 + 1;
                        }
                        if (lVar6 == null) break;
                        uVar4 = FUN_180002f80(lVar6,uVar8,DAT_181dac888);
                        WeatherController.ResetSpeRateMultiplier(this,uVar4,0);
                        if (((this.WeatherDataBase == null) ||
                            (lVar5 = FUN_180002f80(this.WeatherDataBase,uVar8,DAT_181dac888),
                            lVar3 == null)) || (uVar11 = AudioSource.get_volume(lVar3,0), lVar5 == null))
                        break;
                        *(uint32 *)(lVar5 + 84) = uVar11;
                        if (this.WeatherDataBase == null) break;
                        lVar3 = FUN_180002f80(this.WeatherDataBase,uVar8,DAT_181dac888);
                        if ((lVar3 == null) || (*(int64 *)(lVar3 + 40) == 0)) break;
                        GameObject.SetActive(*(int64 *)(lVar3 + 40),1,0);
                      }
                      lVar3 = this.WeatherDataBase;
                      uVar8 = uVar8 + 1;
                      lVar9 = lVar9 + 8;
                    } while (lVar3 != null);
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6002384
    // RVA   : 0xC17C40   Offset: 0xC17040   Length: 0x99A
    private void Update()
    {
        long lVar1;
        bool cVar2;
        ulong uVar3;
        long lVar4;
        long lVar7;
        int iVar8;
        long lVar9;
        long lVar10;
        long lVar11;
        uint uVar12;
        float fVar13;
        float fVar14;
        float fVar15;
        uint uVar16;
        float fVar17;
        float fVar18;
        uint[] local_res18 = new uint[2];
        uint local_res20;
        local_res18[0] = 0;
        if ((GameController._instance != null) &&
           (lVar11 = GameController._instance.worldData) != null) {
          uVar12 = lVar11.nowWeather;
          lVar11 = (int64)(int)uVar12;
          local_res20 = uVar12;
          lVar1 = *(int64 *)(*(int64 *)(DAT_181db4008 + 184) + 8);
          if (lVar1 != null) {
            lVar7 = this.WeatherDataBase;
            lVar1 = *(int64 *)(lVar1 + 24);
            if (lVar7 != null) {
              if (lVar7.Count <= uVar12) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar7 = *(int64 *)(lVar7._items + 32 + lVar11 * 8);
              if (lVar7 != null) {
                fVar18 = *(float *)(lVar7 + 84);
                uVar12 = 0;
                fVar15 = *(float *)(*(int64 *)(DAT_181d72d50 + 184) + 16);
                fVar17 = **(float **)(DAT_181db4008 + 184);
                lVar7 = this.WeatherDataBase;
                if (lVar7 != null) {
                  lVar9 = 32;
                  lVar10 = 0;
                  do {
                    if (lVar7.Count <= (int)uVar12) {
                      if (lVar7.Count <= local_res20) {
                        ThrowHelper.ThrowArgumentOutOfRangeException(0);
                      }
                      lVar11 = *(int64 *)(lVar7._items + 32 + lVar11 * 8);
                      if (lVar11 == null) break;
                      if (lVar11.Heros) {
                        fVar18 = this.nextThunderTime;
                        fVar15 = (float)Time.get_deltaTime(0);
                        fVar18 = fVar18 - fVar15;
                        this.nextThunderTime = fVar18;
                        if (fVar18 <= 0.0) {
                          uVar16 = Random.Range(0x40800000,0x41500000,0);
                          this.nextThunderTime = uVar16;
                          uVar16 = Random.Range(0x3ee66666,0x3f0ccccd,0);
                          this.totalThunderTime = uVar16;
                          this.leftThunderTime = uVar16;
                          local_res18[0] = FUN_180d95a30(0,6);
                          lVar11 = BattleController.BattleMaxTime;
                          if (lVar11 == null) break;
                          if (lVar11.cityAreaID <= local_res18[0]) {
                            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar3,0);
                          }
                          uVar3 = *(uint64 *)(lVar11 + 32 + (int64)(int)local_res18[0] * 8);
                          cVar2 = Object.op_Equality(uVar3,0,0);
                          if (cVar2) {
                            uVar12 = local_res18[0];
                            lVar7 = (int64)(int)local_res18[0];
                            lVar11 = BattleController.BattleMaxTime;
                            uVar3 = Int32.ToString(local_res18,0);
                            String.Concat("Sound/SoundEffect/Thunder/",uVar3,0);
                            plVar5 = (int64 *)Resources.Load();
                            if (lVar11 == null) break;
                            if (plVar5 == (int64 *)0) {
                              plVar6 = (int64 *)0;
                            }
                            else {
                              plVar6 = (int64 *)0;
                              if (*plVar5 == DAT_181daf348) {
                                plVar6 = plVar5;
                              }
                              if ((plVar6 != (int64 *)0) &&
                                 (lVar9 = il2cpp_internal()) == null) {
                                uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1800d65f0(uVar3,0);
                              }
                              plVar6 = (int64 *)0;
                              if (*plVar5 == DAT_181daf348) {
                                plVar6 = plVar5;
                              }
                            }
                            if (lVar11.cityAreaID <= uVar12) {
                              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1800d65f0(uVar3,0);
                            }
                            *(int64 **)(lVar11 + (lVar7 + 4) * 8) = plVar6;
                          }
                          lVar11 = BattleController.BattleMaxTime;
                          if (lVar11 == null) break;
                          if (lVar11.cityAreaID <= local_res18[0]) {
                            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1800d65f0(uVar3,0);
                          }
                          uVar3 = *(uint64 *)(lVar11 + 32 + (int64)(int)local_res18[0] * 8);
                          if (lVar1 == null) {
                            fVar18 = 1.0;
                          }
                          else {
                            fVar18 = **(float **)(DAT_181db4008 + 184) +
                                     **(float **)(DAT_181db4008 + 184);
                          }
                          NGUITools.PlaySound(uVar3,fVar18 * 0.6,0);
                        }
                      }
                      fVar18 = this.leftThunderTime;
                      fVar15 = this.currentExposure;
                      if (0.0 < fVar18) {
                        fVar17 = (fVar18 * 150.0) / this.totalThunderTime;
                        if (fVar15 != fVar17) {
                          this.currentExposure = fVar17;
                          if ((this.colorGrading == null) ||
                             (lVar11 = *(int64 *)(this.colorGrading + 176)) == null)
                          break;
                          lVar11.cityAreaID = fVar17;
                          fVar18 = this.leftThunderTime;
                        }
                        fVar15 = (float)RealTime.get_deltaTime(0);
                        this.leftThunderTime = fVar18 - fVar15;
                        if (0.0 < fVar18 - fVar15) {
                          return;
                        }
                        fVar15 = this.currentExposure;
                        this.leftThunderTime = 0;
                      }
                      if (fVar15 != 0.0) {
                        this.currentExposure = 0;
                        if ((this.colorGrading == null) ||
                           (lVar11 = *(int64 *)(this.colorGrading + 176)) == null)
                        break;
                        lVar11.cityAreaID = 0;
                      }
                      return;
                    }
                    if (lVar7 == null) break;
                    if (lVar7.Count <= uVar12) {
                      ThrowHelper.ThrowArgumentOutOfRangeException(0);
                    }
                    lVar7 = *(int64 *)(lVar9 + lVar7._items);
                    if (lVar7 == null) break;
                    uVar3 = *(uint64 *)(lVar7 + 40);
                    cVar2 = Object.op_Equality(uVar3,0);
                    if (!cVar2) {
                      if (this.weatherSpeAudioSources == null) break;
                      uVar3 = FUN_180002f80(this.weatherSpeAudioSources,uVar12);
                      fVar13 = (float)RealTime.get_deltaTime(0);
                      if (lVar11 == lVar10) {
                        fVar14 = fVar15 * fVar18;
                        if (lVar1 != null) {
                          fVar14 = fVar15 * fVar17;
                        }
                      }
                      else {
                        fVar14 = 0.0;
                      }
                      WeatherController.ChangeParticleSystemAudioSourceVolumn
                                (this,uVar3,fVar13 * 0.2,fVar14,0);
                      if (*(int *)(lVar7 + 64) == 1) {
                        this.totalFinish = 1;
                        if (this.weatherSpeParticleSystems == null) break;
                        lVar4 = FUN_180002f80();
                        iVar8 = 0;
                        while( true ) {
                          if (lVar4 == null) throw; // [null/range check failed]
                          if (*(int *)(lVar4 + 24) <= iVar8) break;
                          if (*(int64 *)(lVar7 + 56) == 0) throw; // [null/range check failed]
                          fVar13 = (float)FUN_1800d6790(*(int64 *)(lVar7 + 56),iVar8,DAT_181da1078);
                          uVar3 = FUN_180002f80(lVar4,iVar8);
                          fVar14 = (float)RealTime.get_deltaTime(0);
                          cVar2 = WeatherController.ChangeParticleSystemRateOverTimeMultiplier
                                            (this,uVar3,fVar14 * 0.2 * fVar13,fVar13,0);
                          if (!cVar2) {
                            this.totalFinish = 0;
                          }
                          iVar8 = iVar8 + 1;
                        }
                      }
                      else {
                        if (*(int *)(lVar7 + 64) != 2) goto LAB_180c1818d;
                        this.totalFinish = 1;
                        if (this.weatherSpeParticleSystems == null) break;
                        lVar4 = FUN_180002f80();
                        iVar8 = 0;
                        while( true ) {
                          if (lVar4 == null) throw; // [null/range check failed]
                          if (*(int *)(lVar4 + 24) <= iVar8) break;
                          if (*(int64 *)(lVar7 + 56) == 0) throw; // [null/range check failed]
                          fVar13 = (float)FUN_1800d6790(*(int64 *)(lVar7 + 56),iVar8,DAT_181da1078);
                          uVar3 = FUN_180002f80(lVar4,iVar8);
                          fVar14 = (float)RealTime.get_deltaTime(0);
                          cVar2 = WeatherController.ChangeParticleSystemRateOverTimeMultiplier
                                            (this,uVar3,fVar14 * -0.2 * fVar13,fVar13,0);
                          if (!cVar2) {
                            this.totalFinish = 0;
                          }
                          iVar8 = iVar8 + 1;
                        }
                      }
                      if (this.totalFinish) {
                        *(uint32 *)(lVar7 + 64) = 0;
                      }
                    }
                    else {
                      *(uint32 *)(lVar7 + 64) = 0;
                    }
        LAB_180c1818d:
                    lVar7 = this.WeatherDataBase;
                    uVar12 = uVar12 + 1;
                    lVar10 = lVar10 + 1;
                    lVar9 = lVar9 + 8;
                  } while (lVar7 != null);
                }
              }
            }
          }
        }
    }

    // Token : 0x6002385
    // RVA   : 0xC174A0   Offset: 0xC168A0   Length: 0xB4
    public void SetWeatherSpeActive(bool active, GameObject targetObj)
    {
        long lVar1;
        lVar1 = this.needHideWeatherObj;
        if (!active) {
          if (lVar1 == null) throw; // [null/range check failed]
          FUN_18181e0a0(lVar1,targetObj,DAT_181d89398);
        }
        else {
          if (lVar1 == null) throw; // [null/range check failed]
          FUN_1817eee00(lVar1,targetObj,DAT_181d89618);
        }
        if ((this.needHideWeatherObj != null) && (this.weatherSpeObjRoot != null)) {
          GameObject.SetActive
                    (this.weatherSpeObjRoot,this.needHideWeatherObj.Count == null,0);
          return;
        }
    }

    // Token : 0x6002386
    // RVA   : 0xC166A0   Offset: 0xC15AA0   Length: 0x17E
    public void ChangeParticleSystemAudioSourceVolumn(AudioSource target, float deltaVolumn, float targetVolumn)
    {
        void WeatherController.ChangeParticleSystemAudioSourceVolumn
                     (uint64 this,int64 target,float deltaVolumn,float targetVolumn)
        {
        char cVar1;
        int64 lVar2;
        float fVar3;
        cVar1 = Object.op_Equality(target,0,0);
        if (!cVar1) {
          if ((target == null) || (lVar2 = Component.get_gameObject(target,0)) == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          cVar1 = GameObject.get_activeInHierarchy(lVar2,0);
          if (((cVar1) && (cVar1 = AudioSource.get_isPlaying(target,0), !cVar1)) &&
             (0.0 < targetVolumn)) {
            AudioSource.Play(target,0);
          }
          fVar3 = (float)AudioSource.get_volume(target,0);
          if (fVar3 < targetVolumn) {
            fVar3 = (float)AudioSource.get_volume(target,0);
            AudioSource.set_volume(target,fVar3 + deltaVolumn,0);
            fVar3 = (float)AudioSource.get_volume(target,0);
            if (targetVolumn <= fVar3) {
              AudioSource.set_volume(target,targetVolumn,0);
            }
          }
          else {
            fVar3 = (float)AudioSource.get_volume(target,0);
            if (targetVolumn < fVar3) {
              fVar3 = (float)AudioSource.get_volume(target,0);
              AudioSource.set_volume(target,fVar3 - deltaVolumn,0);
              fVar3 = (float)AudioSource.get_volume(target,0);
              if (fVar3 <= targetVolumn) {
                AudioSource.set_volume(target,targetVolumn,0);
                fVar3 = (float)AudioSource.get_volume(target,0);
                if (fVar3 == 0.0) {
                  AudioSource.Stop(target,0);
                }
              }
            }
          }
        }
    }

    // Token : 0x6002387
    // RVA   : 0xC16F50   Offset: 0xC16350   Length: 0xA0
    public float GetExposure()
    {
        ulong uVar1;
        long lVar2;
        bool cVar3;
        uVar1 = this.colorGrading;
        cVar3 = Object.op_Inequality(uVar1,0,0);
        if (cVar3) {
          if ((this.colorGrading != null) &&
             (lVar2 = *(int64 *)(this.colorGrading + 176)) != null) {
            return *(uint32 *)(lVar2 + 24);
          }
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        return 0;
    }

    // Token : 0x6002388
    // RVA   : 0xC17460   Offset: 0xC16860   Length: 0x39
    public void SetExposure(float exposure)
    {
        long lVar1;
        if (this.currentExposure != exposure) {
          this.currentExposure = exposure;
          if ((this.colorGrading == null) ||
             (lVar1 = *(int64 *)(this.colorGrading + 176)) == null) {
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          *(float *)(lVar1 + 24) = exposure;
        }
    }

    // Token : 0x6002389
    // RVA   : 0xC16820   Offset: 0xC15C20   Length: 0xCC
    public bool ChangeParticleSystemRateOverTimeMultiplier(ParticleSystem targetParticleSystem, float deltaRate, float maxRate)
    {
        uint64
        WeatherController.ChangeParticleSystemRateOverTimeMultiplier
                (int64 this,int64 targetParticleSystem,float deltaRate,float maxRate)
        {
        uint64 *puVar1;
        uint64 uVar2;
        float fVar3;
        float extraout_XMM0_Da;
        float extraout_XMM0_Da_00;
        if (targetParticleSystem == null) {
                          // WARNING: Subroutine does not return
          FUN_1800d6620();
        }
        puVar1 = &this.emission;
        uVar2 = FUN_1804651e0(targetParticleSystem,0);
        this.emission = uVar2;
        il2cpp_internal(puVar1,0);
        fVar3 = (float)FUN_1804645a0(puVar1,0);
        FUN_180464630(puVar1,fVar3 + deltaRate,0);
        if ((deltaRate <= 0.0) || (FUN_1804645a0(puVar1,0), extraout_XMM0_Da < maxRate)) {
          if ((0.0 <= deltaRate) || (FUN_1804645a0(puVar1,0), 0.0 < extraout_XMM0_Da_00)) {
            return false;
          }
          maxRate = 0.0;
        }
        FUN_180464630(puVar1,maxRate,0);
        return true;
    }

    // Token : 0x600238A
    // RVA   : 0xC17370   Offset: 0xC16770   Length: 0xEF
    public void ResetSpeRateMultiplier(WeatherData targetWeather)
    {
        long lVar1;
        ulong uVar2;
        long lVar3;
        uint uVar4;
        uVar4 = 0;
        if (targetWeather != null) {
          lVar3 = 32;
          while (lVar1 = *(int64 *)(targetWeather + 48)) != null {
            if ((int)*(uint32 *)(lVar1 + 24) <= (int)uVar4) {
              return;
            }
            if (*(uint32 *)(lVar1 + 24) <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar1 = *(int64 *)(lVar3 + *(int64 *)(lVar1 + 16));
            if (lVar1 == null) break;
            lVar1 = GameObject.GetComponent(lVar1,DAT_181d72700);
            if (lVar1 == null) break;
            uVar2 = FUN_1804651e0(lVar1,0);
            this.emission = uVar2;
            FUN_180464630(this + 104,0,0);
            uVar4 = uVar4 + 1;
            lVar3 = lVar3 + 8;
          }
        }
    }

    // Token : 0x600238B
    // RVA   : 0xC168F0   Offset: 0xC15CF0   Length: 0x14B
    public void ChangeWeatherLastTime(float deltaTime)
    {
        long lVar1;
        if ((GameController._instance != null) &&
           (lVar1 = GameController._instance.worldData) != null) {
          lVar1.weatherLastTime = deltaTime + lVar1.weatherLastTime;
          if ((GameController._instance != null) &&
             (lVar1 = GameController._instance.worldData) != null) {
            if (lVar1.weatherLastTime <= 0.0) {
              WeatherController.RandomChangeWeather(this,0);
            }
            return;
          }
        }
    }

    // Token : 0x600238C
    // RVA   : 0xC170F0   Offset: 0xC164F0   Length: 0x277
    public void RandomChangeWeather()
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        int iVar4;
        int iVar5;
        float fVar6;
        float fVar7;
        lVar3 = this.WeatherDataBase;
        iVar5 = 0;
        fVar7 = 0.0;
        iVar4 = 0;
        if (lVar3 != null) {
          while (iVar4 < lVar3.Count) {
            lVar2 = FUN_18046c0a0(0);
            if ((((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) || (lVar3 == null)) ||
               ((lVar3 = FUN_180002f80(lVar3,*(uint32 *)(*(int64 *)(lVar2 + 32) + 0x16c),
                                       DAT_181dac888), lVar3 == null || (*(int64 *)(lVar3 + 32) == 0))))
            throw; // [null/range check failed]
            cVar1 = FUN_18182a3a0(*(int64 *)(lVar3 + 32),iVar4);
            if (cVar1) {
              if ((this.WeatherDataBase == null) ||
                 (lVar3 = FUN_180002f80(this.WeatherDataBase,iVar4)) == null)
              throw; // [null/range check failed]
              fVar6 = (float)WeatherData.GetRandomRate(lVar3,0);
              fVar7 = fVar7 + fVar6;
            }
            lVar3 = this.WeatherDataBase;
            iVar4 = iVar4 + 1;
            if (lVar3 == null) throw; // [null/range check failed]
          }
          fVar7 = (float)Random.Range(0,fVar7,0);
          lVar3 = this.WeatherDataBase;
          if (lVar3 == null)
          {
            }
            throw; // [null/range check failed]
            while( true ) {
            lVar3 = this.WeatherDataBase;
            iVar5 = iVar5 + 1;
            if (lVar3 == null) break;
          }
          if (lVar3.Count <= iVar5) {
            return;
          }
          lVar2 = FUN_18046c0a0(0);
          if ((((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) || (lVar3 == null)) ||
             ((lVar3 = FUN_180002f80(lVar3,*(uint32 *)(*(int64 *)(lVar2 + 32) + 0x16c),
                                     DAT_181dac888), lVar3 == null || (*(int64 *)(lVar3 + 32) == 0))))
          break;
          cVar1 = FUN_18182a3a0(*(int64 *)(lVar3 + 32),iVar5,DAT_181d8f398);
          if (cVar1) {
            if ((this.WeatherDataBase == null) ||
               (lVar3 = FUN_180002f80(this.WeatherDataBase,iVar5,DAT_181dac888)) == null)
            break;
            fVar6 = (float)WeatherData.GetRandomRate(lVar3,0);
            fVar7 = fVar7 - fVar6;
            if (fVar7 <= 0.0) {
              WeatherController.ChangeWeather(this,iVar5,0);
              return;
            }
          }
        }
    }

    // Token : 0x600238D
    // RVA   : 0xC16A40   Offset: 0xC15E40   Length: 0xA3
    public void ChangeWeather(int targetWeatherID)
    {
        var pStatics_35d0 = *(int64*)(DAT_181da35d0 + 184);
        uint uVar1;
        long lVar2;
        long lVar3;
        if ((GameController._instance == null) ||
           (lVar2 = GameController._instance.worldData) == null)
        throw; // [null/range check failed]
        if (targetWeatherID != lVar2.nowWeather) {
          lVar2 = this.WeatherDataBase;
          if (((GameController._instance == null) ||
              (lVar3 = GameController._instance.worldData) == null) ||
             (lVar2 == null)) throw; // [null/range check failed]
          uVar1 = lVar3.nowWeather;
          if (lVar2.Count <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2._items[uVar1];
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2.ResourcePoints = 2;
          lVar2 = this.WeatherDataBase;
          if (lVar2 == null) throw; // [null/range check failed]
          if (lVar2.Count <= targetWeatherID) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2._items[targetWeatherID];
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2.ResourcePoints = 1;
        }
        if ((GameController._instance != null) &&
           (lVar2 = GameController._instance.worldData) != null) {
          lVar2.nowWeather = targetWeatherID;
          if ((GameController._instance != null) &&
             (lVar2 = GameController._instance.worldData) != null) {
            lVar2.weatherLastTime = param_3;
            if (*pStatics_35d0 != 0) {
              SkyController.RefreshCloud(*pStatics_35d0,1,0);
              return;
            }
          }
        }
    }

    // Token : 0x600238E
    // RVA   : 0xC16AF0   Offset: 0xC15EF0   Length: 0x310
    public void ChangeWeather(int targetWeatherID, float lastTime)
    {
        var pStatics_35d0 = *(int64*)(DAT_181da35d0 + 184);
        uint uVar1;
        long lVar2;
        long lVar3;
        if ((GameController._instance == null) ||
           (lVar2 = GameController._instance.worldData) == null)
        throw; // [null/range check failed]
        if (targetWeatherID != lVar2.nowWeather) {
          lVar2 = this.WeatherDataBase;
          if (((GameController._instance == null) ||
              (lVar3 = GameController._instance.worldData) == null) ||
             (lVar2 == null)) throw; // [null/range check failed]
          uVar1 = lVar3.nowWeather;
          if (lVar2.Count <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2._items[uVar1];
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2.ResourcePoints = 2;
          lVar2 = this.WeatherDataBase;
          if (lVar2 == null) throw; // [null/range check failed]
          if (lVar2.Count <= targetWeatherID) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2._items[targetWeatherID];
          if (lVar2 == null) throw; // [null/range check failed]
          lVar2.ResourcePoints = 1;
        }
        if ((GameController._instance != null) &&
           (lVar2 = GameController._instance.worldData) != null) {
          lVar2.nowWeather = targetWeatherID;
          if ((GameController._instance != null) &&
             (lVar2 = GameController._instance.worldData) != null) {
            lVar2.weatherLastTime = lastTime;
            if (*pStatics_35d0 != 0) {
              SkyController.RefreshCloud(*pStatics_35d0,1,0);
              return;
            }
          }
        }
    }

    // Token : 0x600238F
    // RVA   : 0xC16E10   Offset: 0xC16210   Length: 0x13A
    public void GameStartRefreshNowWeather()
    {
        var pStatics_35d0 = *(int64*)(DAT_181da35d0 + 184);
        uint uVar1;
        long lVar2;
        long lVar3;
        lVar2 = this.WeatherDataBase;
        if (((GameController._instance != null) &&
            (lVar3 = GameController._instance.worldData) != null) &&
           (lVar2 != null)) {
          uVar1 = lVar3.nowWeather;
          if (lVar2.Count <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2._items[uVar1];
          if (lVar2 != null) {
            *(uint32 *)(lVar2 + 64) = 1;
            if (*pStatics_35d0 != 0) {
              SkyController.RefreshCloud(*pStatics_35d0,1,0);
              return;
            }
          }
        }
    }

    // Token : 0x6002390
    // RVA   : 0xC17000   Offset: 0xC16400   Length: 0xEF
    public WeatherData GetNowWeather()
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        lVar2 = this.WeatherDataBase;
        if (((GameController._instance != null) &&
            (lVar3 = GameController._instance.worldData) != null) &&
           (lVar2 != null)) {
          uVar1 = lVar3.nowWeather;
          if (lVar2.Count <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          return lVar2._items[uVar1];
        }
    }

    // Token : 0x6002391
    // RVA   : 0xC18640   Offset: 0xC17A40   Length: 0x100
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d911e0);
        FUN_18132faf0(uVar1,DAT_181d7ddd0);
        this.weatherSpeAudioSources = uVar1;
        uVar1 = il2cpp_internal(DAT_181d902e0);
        FUN_18132faf0(uVar1,DAT_181d78e28);
        this.weatherSpeParticleSystems = uVar1;
        uVar1 = il2cpp_internal(DAT_181d92f58);
        FUN_18132faf0(uVar1,DAT_181d89298);
        this.needHideWeatherObj = uVar1;
        FUN_18044ef50(this,0);
    }

    // Token : 0x6002392
    // RVA   : 0xC185E0   Offset: 0xC179E0   Length: 0x5A
    private static void /*cctor*/()
    {
        ulong uVar2;
        uVar2 = FUN_1800d60b0(DAT_181da07c0,6);
        puVar1 = *(uint64 **)(DAT_181db4f18 + 184);
        *puVar1 = uVar2;
        il2cpp_internal(puVar1,uVar2);
    }

}
