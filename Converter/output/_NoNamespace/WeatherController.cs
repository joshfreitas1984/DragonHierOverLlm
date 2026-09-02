// ============================================================
// Type  : WeatherController
// Token : 0x20003AC
// ============================================================

public class WeatherController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001CEB
    public GameObject weatherSpeObjRoot;

    // Token: 0x4001CEC
    public List<WeatherData> WeatherDataBase;

    // Token: 0x4001CED
    public PostProcessVolume postProcessVolume;

    // Token: 0x4001CEE
    private float nextThunderTime;

    // Token: 0x4001CEF
    private float totalThunderTime;

    // Token: 0x4001CF0
    private float leftThunderTime;

    // Token: 0x4001CF1
    private static WeatherController _instance;

    // Token: 0x4001CF2
    private bool totalFinish;

    // Token: 0x4001CF3
    private List<GameObject> needHideWeatherObj;

    // Token: 0x4001CF4
    private EmissionModule emission;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60022FF
    // RVA   : 0x9E4650   Offset: 0x9E2E50   Length: 0x36
    public static WeatherController get_Instance()
    {
        return **(uint64 **)(DAT_181d8fc60 + 184);
    }

    // Token : 0x6002300
    // RVA   : 0x9E2710   Offset: 0x9E0F10   Length: 0x99
    private void Awake()
    {
        ulong uVar1;
        bool cVar3;
        uVar1 = **(uint64 **)(DAT_181d8fc60 + 184);
        cVar3 = Object.op_Equality(uVar1,0,0);
        if (cVar3) {
          puVar2 = *(uint64 **)(DAT_181d8fc60 + 184);
          *puVar2 = this;
          il2cpp_internal(puVar2,this);
        }
    }

    // Token : 0x6002301
    // RVA   : 0x9E3680   Offset: 0x9E1E80   Length: 0x53B
    private void Start()
    {
        bool cVar1;
        int iVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        int iVar6;
        uint uVar7;
        long lVar8;
        uint uVar9;
        ulong[] local_res18 = new ulong[2];
        local_res18[0] = 0;
        lVar3 = Camera.get_main(0);
        if (lVar3 != null) {
          uVar4 = Component.GetComponent(lVar3,DAT_181d6c4c0);
          this.postProcessVolume = uVar4;
          lVar3 = this.WeatherDataBase;
          uVar7 = 0;
          if (lVar3 != null) {
            lVar8 = 32;
            do {
              if (lVar3.Count <= (int)uVar7) {
                return;
              }
              if (lVar3 == null) break;
              if (lVar3.Count <= uVar7) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              lVar3 = *(int64 *)(lVar8 + lVar3._items);
              if (lVar3 == null) break;
              uVar4 = *(uint64 *)(lVar3 + 40);
              cVar1 = Object.op_Inequality(uVar4,0,0);
              if (cVar1) {
                if ((this.WeatherDataBase == null) ||
                   (lVar3 = FUN_180002f80(this.WeatherDataBase,uVar7,DAT_181d84ef8)) == null)
                break;
                lVar3 = *(int64 *)(lVar3 + 48);
                if ((this.WeatherDataBase == null) ||
                   ((lVar5 = FUN_180002f80(this.WeatherDataBase,uVar7,DAT_181d84ef8), lVar5 == null
                    || (lVar3 == null)))) break;
                FUN_181827900(lVar3,*(uint64 *)(lVar5 + 40),DAT_181d61bf8);
                if ((this.WeatherDataBase == null) ||
                   (lVar3 = FUN_180002f80(this.WeatherDataBase,uVar7,DAT_181d84ef8)) == null)
                break;
                lVar3 = *(int64 *)(lVar3 + 56);
                if ((((this.WeatherDataBase == null) ||
                     (lVar5 = FUN_180002f80(this.WeatherDataBase,uVar7,DAT_181d84ef8), lVar5 == null
                     )) || (*(int64 *)(lVar5 + 40) == 0)) ||
                   (lVar5 = GameObject.GetComponent(*(int64 *)(lVar5 + 40),DAT_181da06d0),
                   lVar5 == null)) break;
                local_res18[0] = FUN_1804651e0(lVar5,0);
                uVar9 = FUN_1804645a0(local_res18,0);
                if (lVar3 == null) break;
                FUN_181805690(lVar3,uVar9,DAT_181d79458);
                iVar6 = 0;
                while( true ) {
                  if (((this.WeatherDataBase == null) ||
                      (lVar3 = FUN_180002f80(this.WeatherDataBase,uVar7,DAT_181d84ef8),
                      lVar3 == null)) ||
                     ((*(int64 *)(lVar3 + 40) == 0 ||
                      (lVar3 = GameObject.get_transform(*(int64 *)(lVar3 + 40),0)) == null)))
                  throw; // [null/range check failed]
                  iVar2 = Transform.get_childCount(lVar3,0);
                  lVar3 = this.WeatherDataBase;
                  if (iVar2 <= iVar6) break;
                  if ((lVar3 == null) || (lVar3 = FUN_180002f80(lVar3,uVar7,DAT_181d84ef8)) == null)
                  throw; // [null/range check failed]
                  lVar3 = *(int64 *)(lVar3 + 48);
                  if (((this.WeatherDataBase == null) ||
                      (((lVar5 = FUN_180002f80(this.WeatherDataBase,uVar7,DAT_181d84ef8),
                        lVar5 == null || (*(int64 *)(lVar5 + 40) == 0)) ||
                       (lVar5 = GameObject.get_transform(*(int64 *)(lVar5 + 40),0)) == null)))
                     || ((lVar5 = Transform.GetChild(lVar5,iVar6,0), lVar5 == null ||
                         (uVar4 = Component.get_gameObject(lVar5,0), lVar3 == null)))) throw; // [null/range check failed]
                  FUN_181827900(lVar3,uVar4,DAT_181d61bf8);
                  if ((this.WeatherDataBase == null) ||
                     (lVar3 = FUN_180002f80(this.WeatherDataBase,uVar7,DAT_181d84ef8), lVar3 == null
                     )) throw; // [null/range check failed]
                  lVar3 = *(int64 *)(lVar3 + 56);
                  if (((this.WeatherDataBase == null) ||
                      (lVar5 = FUN_180002f80(this.WeatherDataBase,uVar7,DAT_181d84ef8),
                      lVar5 == null)) ||
                     ((*(int64 *)(lVar5 + 40) == 0 ||
                      (((lVar5 = GameObject.get_transform(*(int64 *)(lVar5 + 40),0), lVar5 == null ||
                        (lVar5 = Transform.GetChild(lVar5,iVar6,0)) == null) ||
                       (lVar5 = Component.GetComponent(lVar5,DAT_181d6c340)) == null)))))
                  throw; // [null/range check failed]
                  local_res18[0] = FUN_1804651e0(lVar5,0);
                  uVar9 = FUN_1804645a0(local_res18,0);
                  if (lVar3 == null) throw; // [null/range check failed]
                  FUN_181805690(lVar3,uVar9,DAT_181d79458);
                  iVar6 = iVar6 + 1;
                }
                if (lVar3 == null) break;
                uVar4 = FUN_180002f80(lVar3,uVar7,DAT_181d84ef8);
                WeatherController.ResetSpeRateMultiplier(this,uVar4,0);
                if (this.WeatherDataBase == null) break;
                lVar3 = FUN_180002f80(this.WeatherDataBase,uVar7,DAT_181d84ef8);
                if (((this.WeatherDataBase == null) ||
                    (lVar5 = FUN_180002f80(this.WeatherDataBase,uVar7,DAT_181d84ef8)) == null
                    ) || ((*(int64 *)(lVar5 + 40) == 0 ||
                          ((lVar5 = GameObject.GetComponent(*(int64 *)(lVar5 + 40),DAT_181d9e558),
                           lVar5 == null || (uVar9 = AudioSource.get_volume(lVar5,0), lVar3 == null))))))
                break;
                *(uint32 *)(lVar3 + 84) = uVar9;
                if ((this.WeatherDataBase == null) ||
                   ((lVar3 = FUN_180002f80(this.WeatherDataBase,uVar7), lVar3 == null ||
                    (*(int64 *)(lVar3 + 40) == 0)))) break;
                GameObject.SetActive();
              }
              lVar3 = this.WeatherDataBase;
              uVar7 = uVar7 + 1;
              lVar8 = lVar8 + 8;
            } while (lVar3 != null);
          }
        }
    }

    // Token : 0x6002302
    // RVA   : 0x9E3BC0   Offset: 0x9E23C0   Length: 0xA07
    private void Update()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        bool cVar1;
        long lVar2;
        ulong uVar3;
        long lVar4;
        uint uVar7;
        long lVar9;
        float fVar11;
        uint uVar12;
        float fVar13;
        uint[] local_res8 = new uint[2];
        lVar2 = this.WeatherDataBase;
        plVar10 = (int64 *)0;
        local_res8[0] = 0;
        if (lVar2 != null) {
          lVar9 = 32;
          plVar6 = plVar10;
          while (uVar7 = (uint32)plVar6, (int)uVar7 < lVar2.Count) {
            if (lVar2 == null) throw; // [null/range check failed]
            if (lVar2.Count <= uVar7) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = *(int64 *)(lVar9 + lVar2._items);
            if (lVar2 == null) throw; // [null/range check failed]
            uVar3 = *(uint64 *)(lVar2 + 40);
            cVar1 = Object.op_Equality(uVar3,0,0);
            lVar2 = this.WeatherDataBase;
            if (!cVar1) {
              if (((lVar2 == null) || (lVar2 = FUN_180002f80(lVar2,plVar6,DAT_181d84ef8)) == null) ||
                 (*(int64 *)(lVar2 + 40) == 0)) throw; // [null/range check failed]
              uVar3 = GameObject.GetComponent(*(int64 *)(lVar2 + 40),DAT_181d9e558);
              fVar11 = (float)RealTime.get_deltaTime(0);
              lVar2 = FUN_18046c0a0(0);
              if ((lVar2 == null) || (*(int64 *)(lVar2 + 32) == 0)) throw; // [null/range check failed]
              if (*(uint32 *)(*(int64 *)(lVar2 + 32) + 0x16c) == uVar7) {
                lVar2 = FUN_18046bca0(0);
                if (lVar2 == null) throw; // [null/range check failed]
                if (lVar2.Count == null) {
                  lVar2 = this.WeatherDataBase;
                  lVar4 = FUN_18046c0a0(0);
                  if ((((lVar4 == null) || (*(int64 *)(lVar4 + 32) == 0)) || (lVar2 == null)) ||
                     (lVar2 = FUN_180002f80(lVar2,*(uint32 *)(*(int64 *)(lVar4 + 32) + 0x16c),
                                            DAT_181d84ef8), lVar2 == null)) throw; // [null/range check failed]
                  pfVar5 = (float *)(lVar2 + 84);
                }
                else {
                  pfVar5 = *(float **)(DAT_181d8ee60 + 184);
                }
                fVar13 = *pfVar5;
                fVar13 = fVar13 * *(float *)(*(int64 *)(DAT_181d4e010 + 184) + 16);
              }
              else {
                fVar13 = 0.0;
              }
              WeatherController.ChangeParticleSystemAudioSourceVolumn
                        (this,uVar3,fVar11 * 0.2,fVar13,0);
              if ((this.WeatherDataBase == null) ||
                 (lVar2 = FUN_180002f80(this.WeatherDataBase,plVar6,DAT_181d84ef8)) == null)
              throw; // [null/range check failed]
              if (*(int *)(lVar2 + 64) == 1) {
                this.totalFinish = 1;
                plVar8 = plVar10;
                while( true ) {
                  if (((this.WeatherDataBase == null) || (lVar2 = FUN_180002f80()) == null) ||
                     (*(int64 *)(lVar2 + 48) == 0)) throw; // [null/range check failed]
                  if (*(int *)(*(int64 *)(lVar2 + 48) + 24) <= (int)plVar8) break;
                  if (((this.WeatherDataBase == null) ||
                      (lVar2 = FUN_180002f80(this.WeatherDataBase,plVar6,DAT_181d84ef8),
                      lVar2 == null)) ||
                     ((*(int64 *)(lVar2 + 48) == 0 ||
                      (lVar2 = FUN_180002f80(*(int64 *)(lVar2 + 48),plVar8,DAT_181d62178), lVar2 == null
                      )))) throw; // [null/range check failed]
                  uVar3 = GameObject.GetComponent(lVar2,DAT_181da06d0);
                  fVar11 = (float)RealTime.get_deltaTime(0);
                  if (((this.WeatherDataBase == null) ||
                      (lVar2 = FUN_180002f80(this.WeatherDataBase,plVar6,DAT_181d84ef8),
                      lVar2 == null)) || (*(int64 *)(lVar2 + 56) == 0)) throw; // [null/range check failed]
                  fVar13 = (float)FUN_1800d6780(*(int64 *)(lVar2 + 56),plVar8,DAT_181d796d8);
                  if (((this.WeatherDataBase == null) ||
                      (lVar2 = FUN_180002f80(this.WeatherDataBase,plVar6,DAT_181d84ef8),
                      lVar2 == null)) || (*(int64 *)(lVar2 + 56) == 0)) throw; // [null/range check failed]
                  uVar12 = FUN_1800d6780(*(int64 *)(lVar2 + 56),plVar8,DAT_181d796d8);
                  cVar1 = WeatherController.ChangeParticleSystemRateOverTimeMultiplier
                                    (this,uVar3,fVar11 * 0.2 * fVar13,uVar12,0);
                  if (!cVar1) {
                    this.totalFinish = 0;
                  }
                  plVar8 = (int64 *)(uint64)((int)plVar8 + 1);
                }
        LAB_1809e422d:
                if (this.totalFinish) {
                  lVar2 = this.WeatherDataBase;
                  goto LAB_1809e4237;
                }
              }
              else {
                if ((this.WeatherDataBase == null) || (lVar2 = FUN_180002f80()) == null)
                throw; // [null/range check failed]
                if (*(int *)(lVar2 + 64) == 2) {
                  this.totalFinish = 1;
                  plVar8 = plVar10;
                  while( true ) {
                    if (((this.WeatherDataBase == null) || (lVar2 = FUN_180002f80()) == null) ||
                       (*(int64 *)(lVar2 + 48) == 0)) throw; // [null/range check failed]
                    if (*(int *)(*(int64 *)(lVar2 + 48) + 24) <= (int)plVar8) break;
                    if ((((this.WeatherDataBase == null) ||
                         (lVar2 = FUN_180002f80(this.WeatherDataBase,plVar6,DAT_181d84ef8),
                         lVar2 == null)) || (*(int64 *)(lVar2 + 48) == 0)) ||
                       (lVar2 = FUN_180002f80(*(int64 *)(lVar2 + 48),plVar8,DAT_181d62178),
                       lVar2 == null)) throw; // [null/range check failed]
                    uVar3 = GameObject.GetComponent(lVar2,DAT_181da06d0);
                    fVar11 = (float)RealTime.get_deltaTime(0);
                    if (((this.WeatherDataBase == null) ||
                        (lVar2 = FUN_180002f80(this.WeatherDataBase,plVar6,DAT_181d84ef8),
                        lVar2 == null)) || (*(int64 *)(lVar2 + 56) == 0)) throw; // [null/range check failed]
                    fVar13 = (float)FUN_1800d6780(*(int64 *)(lVar2 + 56),plVar8,DAT_181d796d8);
                    if (((this.WeatherDataBase == null) ||
                        (lVar2 = FUN_180002f80(this.WeatherDataBase,plVar6,DAT_181d84ef8),
                        lVar2 == null)) || (*(int64 *)(lVar2 + 56) == 0)) throw; // [null/range check failed]
                    uVar12 = FUN_1800d6780(*(int64 *)(lVar2 + 56),plVar8,DAT_181d796d8);
                    cVar1 = WeatherController.ChangeParticleSystemRateOverTimeMultiplier
                                      (this,uVar3,fVar11 * -0.2 * fVar13,uVar12,0);
                    if (!cVar1) {
                      this.totalFinish = 0;
                    }
                    plVar8 = (int64 *)(uint64)((int)plVar8 + 1);
                  }
                  goto LAB_1809e422d;
                }
              }
            }
            else {
        LAB_1809e4237:
              if ((lVar2 == null) || (lVar2 = FUN_180002f80()) == null) throw; // [null/range check failed]
              *(uint32 *)(lVar2 + 64) = 0;
            }
            lVar2 = this.WeatherDataBase;
            plVar6 = (int64 *)(uint64)(uVar7 + 1);
            lVar9 = lVar9 + 8;
            if (lVar2 == null) throw; // [null/range check failed]
          }
          if (((*pStatics != 0) &&
              (lVar9 = *(int64 *)(*pStatics + 32)) != null) &&
             (lVar2 != null)) {
            uVar7 = *(uint32 *)(lVar9 + 0x16c);
            if (lVar2.Count <= uVar7) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = lVar2._items[uVar7];
            if (lVar2 != null) {
              if (*(char *)(lVar2 + 80) != false) {
                fVar11 = this.nextThunderTime;
                fVar13 = (float)Time.get_deltaTime(0);
                fVar11 = fVar11 - fVar13;
                this.nextThunderTime = fVar11;
                if (fVar11 <= 0.0) {
                  uVar12 = Random.Range(0x40800000,0x41500000,0);
                  this.nextThunderTime = uVar12;
                  uVar12 = Random.Range(0x3ee66666,0x3f0ccccd,0);
                  this.totalThunderTime = uVar12;
                  this.leftThunderTime = uVar12;
                  local_res8[0] = FUN_180d8cf10(0,6);
                  uVar3 = Int32.ToString(local_res8,0);
                  uVar3 = String.Concat("Sound/SoundEffect/Thunder/",uVar3,0);
                  plVar6 = (int64 *)Resources.Load(uVar3,0);
                  lVar2 = FUN_18046bca0(0);
                  if (lVar2 == null) throw; // [null/range check failed]
                  plVar8 = plVar10;
                  if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181d8a228)) {
                    plVar8 = plVar6;
                  }
                  if (lVar2.Count == null) {
                    plVar8 = plVar10;
                    if ((plVar6 != (int64 *)0) && (*plVar6 == DAT_181d8a228)) {
                      plVar8 = plVar6;
                    }
                    fVar11 = 1.0;
                  }
                  else {
                    fVar11 = **(float **)(DAT_181d8ee60 + 184) + **(float **)(DAT_181d8ee60 + 184);
                  }
                  NGUITools.PlaySound(plVar8,fVar11 * 0.6,0);
                }
              }
              if (0.0 < this.leftThunderTime) {
                WeatherController.SetExposure
                          (this,(this.leftThunderTime * 150.0) / this.totalThunderTime,0);
                fVar11 = this.leftThunderTime;
                fVar13 = (float)RealTime.get_deltaTime(0);
                fVar11 = fVar11 - fVar13;
                this.leftThunderTime = fVar11;
                if (0.0 < fVar11) {
                  return;
                }
                this.leftThunderTime = 0;
              }
              else {
                if ((((this.postProcessVolume == null) ||
                     (lVar2 = PostProcessVolume.get_profile(this.postProcessVolume,0)) == null
                     ) || (lVar2 = PostProcessProfile.GetSetting(lVar2,DAT_181d6f5f0)) == null) ||
                   (*(int64 *)(lVar2 + 176) == 0)) throw; // [null/range check failed]
                if (*(float *)(*(int64 *)(lVar2 + 176) + 24) == 0.0) {
                  return;
                }
              }
              WeatherController.SetExposure(this,0,0);
              return;
            }
          }
        }
    }

    // Token : 0x6002303
    // RVA   : 0x9E35C0   Offset: 0x9E1DC0   Length: 0xB4
    public void SetWeatherSpeActive(bool active, GameObject targetObj)
    {
        long lVar1;
        lVar1 = this.needHideWeatherObj;
        if (!active) {
          if (lVar1 == null) throw; // [null/range check failed]
          FUN_181827900(lVar1,targetObj,DAT_181d61bf8);
        }
        else {
          if (lVar1 == null) throw; // [null/range check failed]
          FUN_181801c10(lVar1,targetObj,DAT_181d61e78);
        }
        if ((this.needHideWeatherObj != null) && (this.weatherSpeObjRoot != null)) {
          GameObject.SetActive
                    (this.weatherSpeObjRoot,this.needHideWeatherObj.Count == null,0);
          return;
        }
    }

    // Token : 0x6002304
    // RVA   : 0x9E27B0   Offset: 0x9E0FB0   Length: 0x17E
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

    // Token : 0x6002305
    // RVA   : 0x9E3060   Offset: 0x9E1860   Length: 0x76
    public float GetExposure()
    {
        long lVar1;
        if (this.postProcessVolume != null) {
          lVar1 = PostProcessVolume.get_profile(this.postProcessVolume,0);
          if (lVar1 != null) {
            lVar1 = PostProcessProfile.GetSetting(lVar1,DAT_181d6f5f0);
            if ((lVar1 != null) && (*(int64 *)(lVar1 + 176) != 0)) {
              return *(uint32 *)(*(int64 *)(lVar1 + 176) + 24);
            }
          }
        }
    }

    // Token : 0x6002306
    // RVA   : 0x9E3540   Offset: 0x9E1D40   Length: 0x77
    public void SetExposure(float exposure)
    {
        long lVar1;
        if (this.postProcessVolume != null) {
          lVar1 = PostProcessVolume.get_profile(this.postProcessVolume,0);
          if (lVar1 != null) {
            lVar1 = PostProcessProfile.GetSetting(lVar1,DAT_181d6f5f0);
            if ((lVar1 != null) && (*(int64 *)(lVar1 + 176) != 0)) {
              *(uint32 *)(*(int64 *)(lVar1 + 176) + 24) = exposure;
              return;
            }
          }
        }
    }

    // Token : 0x6002307
    // RVA   : 0x9E2930   Offset: 0x9E1130   Length: 0xCC
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

    // Token : 0x6002308
    // RVA   : 0x9E3450   Offset: 0x9E1C50   Length: 0xEF
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
            lVar1 = GameObject.GetComponent(lVar1,DAT_181da06d0);
            if (lVar1 == null) break;
            uVar2 = FUN_1804651e0(lVar1,0);
            this.emission = uVar2;
            FUN_180464630(this + 72,0,0);
            uVar4 = uVar4 + 1;
            lVar3 = lVar3 + 8;
          }
        }
    }

    // Token : 0x6002309
    // RVA   : 0x9E2A00   Offset: 0x9E1200   Length: 0x14B
    public void ChangeWeatherLastTime(float deltaTime)
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        long lVar1;
        if ((*pStatics != 0) &&
           (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
          *(float *)(lVar1 + 0x170) = deltaTime + *(float *)(lVar1 + 0x170);
          if ((*pStatics != 0) &&
             (lVar1 = *(int64 *)(*pStatics + 32)) != null) {
            if (*(float *)(lVar1 + 0x170) <= 0.0) {
              WeatherController.RandomChangeWeather(this,0);
            }
            return;
          }
        }
    }

    // Token : 0x600230A
    // RVA   : 0x9E31D0   Offset: 0x9E19D0   Length: 0x277
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
                                       DAT_181d84ef8), lVar3 == null || (*(int64 *)(lVar3 + 32) == 0))))
            throw; // [null/range check failed]
            cVar1 = FUN_181815240(*(int64 *)(lVar3 + 32),iVar4);
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
                                     DAT_181d84ef8), lVar3 == null || (*(int64 *)(lVar3 + 32) == 0))))
          break;
          cVar1 = FUN_181815240(*(int64 *)(lVar3 + 32),iVar5,DAT_181d67bf8);
          if (cVar1) {
            if ((this.WeatherDataBase == null) ||
               (lVar3 = FUN_180002f80(this.WeatherDataBase,iVar5,DAT_181d84ef8)) == null)
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

    // Token : 0x600230B
    // RVA   : 0x9E2B50   Offset: 0x9E1350   Length: 0xA3
    public void ChangeWeather(int targetWeatherID)
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_e3b0 = *(int64*)(DAT_181d7e3b0 + 184);
        uint uVar1;
        long lVar2;
        long lVar3;
        if ((*pStatics_df90 == 0) ||
           (lVar2 = *(int64 *)(*pStatics_df90 + 32)) == null)
        throw; // [null/range check failed]
        if (targetWeatherID != *(uint32 *)(lVar2 + 0x16c)) {
          lVar2 = this.WeatherDataBase;
          if (((*pStatics_df90 == 0) ||
              (lVar3 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
             (lVar2 == null)) throw; // [null/range check failed]
          uVar1 = *(uint32 *)(lVar3 + 0x16c);
          if (lVar2.Count <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2._items[uVar1];
          if (lVar2 == null) throw; // [null/range check failed]
          *(uint32 *)(lVar2 + 64) = 2;
          lVar2 = this.WeatherDataBase;
          if (lVar2 == null) throw; // [null/range check failed]
          if (lVar2.Count <= targetWeatherID) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2._items[targetWeatherID];
          if (lVar2 == null) throw; // [null/range check failed]
          *(uint32 *)(lVar2 + 64) = 1;
        }
        if ((*pStatics_df90 != 0) &&
           (lVar2 = *(int64 *)(*pStatics_df90 + 32)) != null) {
          *(uint32 *)(lVar2 + 0x16c) = targetWeatherID;
          if ((*pStatics_df90 != 0) &&
             (lVar2 = *(int64 *)(*pStatics_df90 + 32)) != null) {
            *(uint32 *)(lVar2 + 0x170) = param_3;
            if (*pStatics_e3b0 != 0) {
              SkyController.RefreshCloud(*pStatics_e3b0,1,0);
              return;
            }
          }
        }
    }

    // Token : 0x600230C
    // RVA   : 0x9E2C00   Offset: 0x9E1400   Length: 0x310
    public void ChangeWeather(int targetWeatherID, float lastTime)
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_e3b0 = *(int64*)(DAT_181d7e3b0 + 184);
        uint uVar1;
        long lVar2;
        long lVar3;
        if ((*pStatics_df90 == 0) ||
           (lVar2 = *(int64 *)(*pStatics_df90 + 32)) == null)
        throw; // [null/range check failed]
        if (targetWeatherID != *(uint32 *)(lVar2 + 0x16c)) {
          lVar2 = this.WeatherDataBase;
          if (((*pStatics_df90 == 0) ||
              (lVar3 = *(int64 *)(*pStatics_df90 + 32)) == null) ||
             (lVar2 == null)) throw; // [null/range check failed]
          uVar1 = *(uint32 *)(lVar3 + 0x16c);
          if (lVar2.Count <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2._items[uVar1];
          if (lVar2 == null) throw; // [null/range check failed]
          *(uint32 *)(lVar2 + 64) = 2;
          lVar2 = this.WeatherDataBase;
          if (lVar2 == null) throw; // [null/range check failed]
          if (lVar2.Count <= targetWeatherID) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2._items[targetWeatherID];
          if (lVar2 == null) throw; // [null/range check failed]
          *(uint32 *)(lVar2 + 64) = 1;
        }
        if ((*pStatics_df90 != 0) &&
           (lVar2 = *(int64 *)(*pStatics_df90 + 32)) != null) {
          *(uint32 *)(lVar2 + 0x16c) = targetWeatherID;
          if ((*pStatics_df90 != 0) &&
             (lVar2 = *(int64 *)(*pStatics_df90 + 32)) != null) {
            *(uint32 *)(lVar2 + 0x170) = lastTime;
            if (*pStatics_e3b0 != 0) {
              SkyController.RefreshCloud(*pStatics_e3b0,1,0);
              return;
            }
          }
        }
    }

    // Token : 0x600230D
    // RVA   : 0x9E2F20   Offset: 0x9E1720   Length: 0x13A
    public void GameStartRefreshNowWeather()
    {
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_e3b0 = *(int64*)(DAT_181d7e3b0 + 184);
        uint uVar1;
        long lVar2;
        long lVar3;
        lVar2 = this.WeatherDataBase;
        if (((*pStatics_df90 != 0) &&
            (lVar3 = *(int64 *)(*pStatics_df90 + 32)) != null) &&
           (lVar2 != null)) {
          uVar1 = *(uint32 *)(lVar3 + 0x16c);
          if (lVar2.Count <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          lVar2 = lVar2._items[uVar1];
          if (lVar2 != null) {
            *(uint32 *)(lVar2 + 64) = 1;
            if (*pStatics_e3b0 != 0) {
              SkyController.RefreshCloud(*pStatics_e3b0,1,0);
              return;
            }
          }
        }
    }

    // Token : 0x600230E
    // RVA   : 0x9E30E0   Offset: 0x9E18E0   Length: 0xEF
    public WeatherData GetNowWeather()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        uint uVar1;
        long lVar2;
        long lVar3;
        lVar2 = this.WeatherDataBase;
        if (((*pStatics != 0) &&
            (lVar3 = *(int64 *)(*pStatics + 32)) != null) &&
           (lVar2 != null)) {
          uVar1 = *(uint32 *)(lVar3 + 0x16c);
          if (lVar2.Count <= uVar1) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          return lVar2._items[uVar1];
        }
    }

    // Token : 0x600230F
    // RVA   : 0x9E45D0   Offset: 0x9E2DD0   Length: 0x76
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181d6e2b0);
        FUN_180f58a90(uVar1,DAT_181d61af8);
        this.needHideWeatherObj = uVar1;
        FUN_18044ef50(this,0);
    }

}
