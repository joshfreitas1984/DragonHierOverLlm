// ============================================================
// Type  : WeatherController
// Token : 0x20003C0
// ============================================================

public class WeatherController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001E83
    public GameObject weatherSpeObjRoot;

    // Token: 0x4001E84
    public List<WeatherData> WeatherDataBase;

    // Token: 0x4001E85
    public PostProcessVolume postProcessVolume;

    // Token: 0x4001E86
    private float nextThunderTime;

    // Token: 0x4001E87
    private float totalThunderTime;

    // Token: 0x4001E88
    private float leftThunderTime;

    // Token: 0x4001E89
    private readonly List<AudioSource> weatherSpeAudioSources;

    // Token: 0x4001E8A
    private readonly List<List<ParticleSystem>> weatherSpeParticleSystems;

    // Token: 0x4001E8B
    private ColorGrading colorGrading;

    // Token: 0x4001E8C
    private float currentExposure;

    // Token: 0x4001E8D
    private static readonly AudioClip[] thunderClips;

    // Token: 0x4001E8E
    private static WeatherController _instance;

    // Token: 0x4001E8F
    private bool totalFinish;

    // Token: 0x4001E90
    private List<GameObject> needHideWeatherObj;

    // Token: 0x4001E91
    private EmissionModule emission;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600242B
    // RVA   : 0x972060   Offset: 0x970E60   Length: 0x117
    public static WeatherController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181e95408 + 184) + 8);
    }

    // Token : 0x600242C
    // RVA   : 0x96FEE0   Offset: 0x96ECE0   Length: 0xE0
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

    // Token : 0x600242D
    // RVA   : 0x970E80   Offset: 0x96FC80   Length: 0x6D8
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
          uVar4 = Component.GetComponent(lVar3,DAT_181e78038);
          this.postProcessVolume = uVar4;
          if ((this.postProcessVolume != null) &&
             (lVar3 = PostProcessVolume.get_profile(this.postProcessVolume,0)) != null) {
            uVar4 = PostProcessProfile.GetSetting(lVar3,DAT_181e7b968);
            this.colorGrading = uVar4;
            if ((this.colorGrading != null) &&
               (lVar3 = *(int64 *)(this.colorGrading + 176)) != null) {
              this.currentExposure = lVar3.Count;
              if (this.weatherSpeAudioSources != null) {
                FUN_18115d8f0(this.weatherSpeAudioSources,DAT_181e5ff20);
                if (this.weatherSpeParticleSystems != null) {
                  FUN_18115d8f0(this.weatherSpeParticleSystems,DAT_181e5aaa0);
                  lVar3 = this.WeatherDataBase;
                  uVar8 = 0;
                  if (lVar3 != null) {
                    lVar9 = 32;
                    do {
                      if (lVar3.Count <= (int)uVar8) {
                        return;
                      }
                      if (this.weatherSpeAudioSources == null) break;
                      FUN_18175de30(this.weatherSpeAudioSources,0,DAT_181e5fea0);
                      if (this.weatherSpeParticleSystems == null) break;
                      FUN_18175de30(this.weatherSpeParticleSystems,0,DAT_181e5aa18);
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
                            (lVar3 = FUN_1800024b0(this.WeatherDataBase,uVar8,DAT_181e8eed8),
                            lVar3 == null)) || (*(int64 *)(lVar3 + 40) == 0)) break;
                        lVar3 = GameObject.GetComponent(*(int64 *)(lVar3 + 40),DAT_181e533a8);
                        if (this.weatherSpeAudioSources == null) break;
                        FUN_181769c00(this.weatherSpeAudioSources,uVar8,lVar3,DAT_181e600a0);
                        lVar5 = il2cpp_internal(DAT_181e75038);
                        FUN_1810f3480(lVar5,DAT_181e78b60);
                        if (this.weatherSpeParticleSystems == null) break;
                        FUN_181769c00(this.weatherSpeParticleSystems,uVar8,lVar5,DAT_181e5abb0);
                        if ((this.WeatherDataBase == null) ||
                           (lVar6 = FUN_1800024b0(this.WeatherDataBase,uVar8,DAT_181e8eed8),
                           lVar6 == null)) break;
                        lVar6 = *(int64 *)(lVar6 + 48);
                        if ((this.WeatherDataBase == null) ||
                           ((lVar7 = FUN_1800024b0(this.WeatherDataBase,uVar8,DAT_181e8eed8),
                            lVar7 == null || (lVar6 == null)))) break;
                        FUN_18175de30(lVar6,*(uint64 *)(lVar7 + 40),DAT_181e6b6f8);
                        if ((this.WeatherDataBase == null) ||
                           (((lVar6 = FUN_1800024b0(this.WeatherDataBase,uVar8,DAT_181e8eed8),
                             lVar6 == null || (*(int64 *)(lVar6 + 40) == 0)) ||
                            (lVar6 = GameObject.GetComponent(*(int64 *)(lVar6 + 40),DAT_181e557c8),
                            lVar5 == null)))) break;
                        FUN_18175de30(lVar5,lVar6,DAT_181e78be0);
                        if (((this.WeatherDataBase == null) ||
                            (lVar7 = FUN_1800024b0(this.WeatherDataBase,uVar8,DAT_181e8eed8),
                            lVar7 == null)) || (lVar7 = *(int64 *)(lVar7 + 56), lVar6 == null)) break;
                        local_res18 = FUN_181040f40(lVar6,0);
                        uVar11 = FUN_181846820(&local_res18,0);
                        if (lVar7 == null) break;
                        FUN_18175dba0(lVar7,uVar11,DAT_181e83330);
                        iVar10 = 0;
                        while( true ) {
                          if (((this.WeatherDataBase == null) ||
                              (lVar6 = FUN_1800024b0(this.WeatherDataBase,uVar8,DAT_181e8eed8),
                              lVar6 == null)) ||
                             ((*(int64 *)(lVar6 + 40) == 0 ||
                              (lVar6 = GameObject.get_transform(*(int64 *)(lVar6 + 40),0),
                              lVar6 == null)))) throw; // [null/range check failed]
                          iVar2 = Transform.get_childCount(lVar6,0);
                          lVar6 = this.WeatherDataBase;
                          if (iVar2 <= iVar10) break;
                          if (((lVar6 == null) ||
                              (lVar6 = FUN_1800024b0(lVar6,uVar8,DAT_181e8eed8)) == null) ||
                             ((*(int64 *)(lVar6 + 40) == 0 ||
                              ((lVar6 = GameObject.get_transform(*(int64 *)(lVar6 + 40),0),
                               lVar6 == null || (lVar6 = Transform.GetChild(lVar6,iVar10,0)) == null))))
                             ) throw; // [null/range check failed]
                          lVar6 = Component.get_gameObject(lVar6,0);
                          if ((this.WeatherDataBase == null) ||
                             (((lVar7 = FUN_1800024b0(this.WeatherDataBase,uVar8,DAT_181e8eed8),
                               lVar7 == null || (*(int64 *)(lVar7 + 48) == 0)) ||
                              (FUN_18175de30(*(int64 *)(lVar7 + 48),lVar6,DAT_181e6b6f8), lVar6 == null)
                              ))) throw; // [null/range check failed]
                          lVar6 = GameObject.GetComponent(lVar6,DAT_181e557c8);
                          FUN_18175de30(lVar5,lVar6,DAT_181e78be0);
                          if (((this.WeatherDataBase == null) ||
                              (lVar7 = FUN_1800024b0(this.WeatherDataBase,uVar8,DAT_181e8eed8),
                              lVar7 == null)) || (lVar7 = *(int64 *)(lVar7 + 56), lVar6 == null))
                          throw; // [null/range check failed]
                          local_res18 = FUN_181040f40(lVar6,0);
                          uVar11 = FUN_181846820(&local_res18,0);
                          if (lVar7 == null) throw; // [null/range check failed]
                          FUN_18175dba0(lVar7,uVar11,DAT_181e83330);
                          iVar10 = iVar10 + 1;
                        }
                        if (lVar6 == null) break;
                        uVar4 = FUN_1800024b0(lVar6,uVar8,DAT_181e8eed8);
                        WeatherController.ResetSpeRateMultiplier(this,uVar4,0);
                        if (((this.WeatherDataBase == null) ||
                            (lVar5 = FUN_1800024b0(this.WeatherDataBase,uVar8,DAT_181e8eed8),
                            lVar3 == null)) || (uVar11 = AudioSource.get_volume(lVar3,0), lVar5 == null))
                        break;
                        *(uint32 *)(lVar5 + 84) = uVar11;
                        if (this.WeatherDataBase == null) break;
                        lVar3 = FUN_1800024b0(this.WeatherDataBase,uVar8,DAT_181e8eed8);
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

    // Token : 0x600242E
    // RVA   : 0x971560   Offset: 0x970360   Length: 0x99A
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
          lVar1 = *(int64 *)(*(int64 *)(DAT_181e942d8 + 184) + 8);
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
                fVar15 = *(float *)(*(int64 *)(DAT_181e528f8 + 184) + 16);
                fVar17 = **(float **)(DAT_181e942d8 + 184);
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
                          local_res18[0] = FUN_180af1860(0,6);
                          lVar11 = BattleController.BattleMaxTime;
                          if (lVar11 == null) break;
                          if (lVar11.cityAreaID <= local_res18[0]) {
                            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1801e02d0(uVar3,0);
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
                              if (*plVar5 == DAT_181e8f4a0) {
                                plVar6 = plVar5;
                              }
                              if ((plVar6 != (int64 *)0) &&
                                 (lVar9 = il2cpp_internal()) == null) {
                                uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1801e02d0(uVar3,0);
                              }
                              plVar6 = (int64 *)0;
                              if (*plVar5 == DAT_181e8f4a0) {
                                plVar6 = plVar5;
                              }
                            }
                            if (lVar11.cityAreaID <= uVar12) {
                              uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                              FUN_1801e02d0(uVar3,0);
                            }
                            *(int64 **)(lVar11 + (lVar7 + 4) * 8) = plVar6;
                          }
                          lVar11 = BattleController.BattleMaxTime;
                          if (lVar11 == null) break;
                          if (lVar11.cityAreaID <= local_res18[0]) {
                            uVar3 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                            FUN_1801e02d0(uVar3,0);
                          }
                          uVar3 = *(uint64 *)(lVar11 + 32 + (int64)(int)local_res18[0] * 8);
                          if (lVar1 == null) {
                            fVar18 = 1.0;
                          }
                          else {
                            fVar18 = **(float **)(DAT_181e942d8 + 184) +
                                     **(float **)(DAT_181e942d8 + 184);
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
                      uVar3 = FUN_1800024b0(this.weatherSpeAudioSources,uVar12);
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
                        lVar4 = FUN_1800024b0();
                        iVar8 = 0;
                        while( true ) {
                          if (lVar4 == null) throw; // [null/range check failed]
                          if (*(int *)(lVar4 + 24) <= iVar8) break;
                          if (*(int64 *)(lVar7 + 56) == 0) throw; // [null/range check failed]
                          fVar13 = (float)FUN_1800024e0(*(int64 *)(lVar7 + 56),iVar8,DAT_181e83530);
                          uVar3 = FUN_1800024b0(lVar4,iVar8);
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
                        if (*(int *)(lVar7 + 64) != 2) goto LAB_180971aad;
                        this.totalFinish = 1;
                        if (this.weatherSpeParticleSystems == null) break;
                        lVar4 = FUN_1800024b0();
                        iVar8 = 0;
                        while( true ) {
                          if (lVar4 == null) throw; // [null/range check failed]
                          if (*(int *)(lVar4 + 24) <= iVar8) break;
                          if (*(int64 *)(lVar7 + 56) == 0) throw; // [null/range check failed]
                          fVar13 = (float)FUN_1800024e0(*(int64 *)(lVar7 + 56),iVar8,DAT_181e83530);
                          uVar3 = FUN_1800024b0(lVar4,iVar8);
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
        LAB_180971aad:
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

    // Token : 0x600242F
    // RVA   : 0x970DC0   Offset: 0x96FBC0   Length: 0xB4
    public void SetWeatherSpeActive(bool active, GameObject targetObj)
    {
        long lVar1;
        lVar1 = this.needHideWeatherObj;
        if (!active) {
          if (lVar1 == null) throw; // [null/range check failed]
          FUN_18175de30(lVar1,targetObj,DAT_181e6b6f8);
        }
        else {
          if (lVar1 == null) throw; // [null/range check failed]
          FUN_181665e90(lVar1,targetObj,DAT_181e6b978);
        }
        if ((this.needHideWeatherObj != null) && (this.weatherSpeObjRoot != null)) {
          GameObject.SetActive
                    (this.weatherSpeObjRoot,this.needHideWeatherObj.Count == null,0);
          return;
        }
    }

    // Token : 0x6002430
    // RVA   : 0x96FFC0   Offset: 0x96EDC0   Length: 0x17E
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
            FUN_1801e0300();
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

    // Token : 0x6002431
    // RVA   : 0x970870   Offset: 0x96F670   Length: 0xA0
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
          FUN_1801e0300();
        }
        return 0;
    }

    // Token : 0x6002432
    // RVA   : 0x970D80   Offset: 0x96FB80   Length: 0x39
    public void SetExposure(float exposure)
    {
        long lVar1;
        if (this.currentExposure != exposure) {
          this.currentExposure = exposure;
          if ((this.colorGrading == null) ||
             (lVar1 = *(int64 *)(this.colorGrading + 176)) == null) {
                          // WARNING: Subroutine does not return
            FUN_1801e0300();
          }
          *(float *)(lVar1 + 24) = exposure;
        }
    }

    // Token : 0x6002433
    // RVA   : 0x970140   Offset: 0x96EF40   Length: 0xCC
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
          FUN_1801e0300();
        }
        puVar1 = &this.emission;
        uVar2 = FUN_181040f40(targetParticleSystem,0);
        this.emission = uVar2;
        il2cpp_internal(puVar1,0);
        fVar3 = (float)FUN_181846820(puVar1,0);
        FUN_1818468b0(puVar1,fVar3 + deltaRate,0);
        if ((deltaRate <= 0.0) || (FUN_181846820(puVar1,0), extraout_XMM0_Da < maxRate)) {
          if ((0.0 <= deltaRate) || (FUN_181846820(puVar1,0), 0.0 < extraout_XMM0_Da_00)) {
            return false;
          }
          maxRate = 0.0;
        }
        FUN_1818468b0(puVar1,maxRate,0);
        return true;
    }

    // Token : 0x6002434
    // RVA   : 0x970C90   Offset: 0x96FA90   Length: 0xEF
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
            lVar1 = GameObject.GetComponent(lVar1,DAT_181e557c8);
            if (lVar1 == null) break;
            uVar2 = FUN_181040f40(lVar1,0);
            this.emission = uVar2;
            FUN_1818468b0(this + 104,0,0);
            uVar4 = uVar4 + 1;
            lVar3 = lVar3 + 8;
          }
        }
    }

    // Token : 0x6002435
    // RVA   : 0x970210   Offset: 0x96F010   Length: 0x14B
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

    // Token : 0x6002436
    // RVA   : 0x970A10   Offset: 0x96F810   Length: 0x277
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
            lVar2 = FUN_1802106e0(0);
            if ((((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) || (lVar3 == null)) ||
               ((lVar3 = FUN_1800024b0(lVar3,*(uint32 *)(*(int64 *)(lVar2 + 32) + 0x16c),
                                       DAT_181e8eed8), lVar3 == null || (*(int64 *)(lVar3 + 32) == 0))))
            throw; // [null/range check failed]
            cVar1 = FUN_18176a2d0(*(int64 *)(lVar3 + 32),iVar4);
            if (cVar1) {
              if ((this.WeatherDataBase == null) ||
                 (lVar3 = FUN_1800024b0(this.WeatherDataBase,iVar4)) == null)
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
          lVar2 = FUN_1802106e0(0);
          if ((((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) || (lVar3 == null)) ||
             ((lVar3 = FUN_1800024b0(lVar3,*(uint32 *)(*(int64 *)(lVar2 + 32) + 0x16c),
                                     DAT_181e8eed8), lVar3 == null || (*(int64 *)(lVar3 + 32) == 0))))
          break;
          cVar1 = FUN_18176a2d0(*(int64 *)(lVar3 + 32),iVar5,DAT_181e71570);
          if (cVar1) {
            if ((this.WeatherDataBase == null) ||
               (lVar3 = FUN_1800024b0(this.WeatherDataBase,iVar5,DAT_181e8eed8)) == null)
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

    // Token : 0x6002437
    // RVA   : 0x970360   Offset: 0x96F160   Length: 0xA3
    public void ChangeWeather(int targetWeatherID)
    {
        var pStatics_3a28 = *(int64*)(DAT_181e83a28 + 184);
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
            if (*pStatics_3a28 != 0) {
              SkyController.RefreshCloud(*pStatics_3a28,1,0);
              return;
            }
          }
        }
    }

    // Token : 0x6002438
    // RVA   : 0x970410   Offset: 0x96F210   Length: 0x310
    public void ChangeWeather(int targetWeatherID, float lastTime)
    {
        var pStatics_3a28 = *(int64*)(DAT_181e83a28 + 184);
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
            if (*pStatics_3a28 != 0) {
              SkyController.RefreshCloud(*pStatics_3a28,1,0);
              return;
            }
          }
        }
    }

    // Token : 0x6002439
    // RVA   : 0x970730   Offset: 0x96F530   Length: 0x13A
    public void GameStartRefreshNowWeather()
    {
        var pStatics_3a28 = *(int64*)(DAT_181e83a28 + 184);
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
            if (*pStatics_3a28 != 0) {
              SkyController.RefreshCloud(*pStatics_3a28,1,0);
              return;
            }
          }
        }
    }

    // Token : 0x600243A
    // RVA   : 0x970920   Offset: 0x96F720   Length: 0xEF
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

    // Token : 0x600243B
    // RVA   : 0x971F60   Offset: 0x970D60   Length: 0x100
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181e71038);
        FUN_1810f3480(uVar1,DAT_181e5fe20);
        this.weatherSpeAudioSources = uVar1;
        uVar1 = il2cpp_internal(DAT_181e70138);
        FUN_1810f3480(uVar1,DAT_181e5a990);
        this.weatherSpeParticleSystems = uVar1;
        uVar1 = il2cpp_internal(DAT_181e72f38);
        FUN_1810f3480(uVar1,DAT_181e6b5f8);
        this.needHideWeatherObj = uVar1;
        FUN_180ae8740(this,0);
    }

    // Token : 0x600243C
    // RVA   : 0x971F00   Offset: 0x970D00   Length: 0x5A
    private static void /*cctor*/()
    {
        ulong uVar2;
        uVar2 = FUN_1801dfd90(DAT_181e808a8,6);
        puVar1 = *(uint64 **)(DAT_181e95408 + 184);
        *puVar1 = uVar2;
        il2cpp_internal(puVar1,uVar2);
    }

}
