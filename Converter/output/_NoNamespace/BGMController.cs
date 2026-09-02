// ============================================================
// Type  : BGMController
// Token : 0x200014D
// ============================================================

public class BGMController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4000853
    public AudioSource gameBGM;

    // Token: 0x4000854
    public AudioSource environmentSound;

    // Token: 0x4000855
    public List<AudioClipPrefab> AllBGM;

    // Token: 0x4000856
    public List<AudioClipPrefab> bigMapBGM;

    // Token: 0x4000857
    public List<AudioClipPrefab> areaBGM;

    // Token: 0x4000858
    public List<AudioClipPrefab> fightBGM;

    // Token: 0x4000859
    public List<AudioClipPrefab> bossBGM;

    // Token: 0x400085A
    private bool fightBGMStarted;

    // Token: 0x400085B
    public AudioClipPrefab nowBgm;

    // Token: 0x400085C
    public AudioClipPrefab plotBgm;

    // Token: 0x400085D
    public bool noBgm;

    // Token: 0x400085E
    public AudioClip bigMapEnvironmentSoundClip;

    // Token: 0x400085F
    public AudioClip[] environmentSoundClips;

    // Token: 0x4000860
    private string MusicPath;

    // Token: 0x4000861
    public float quietTime;

    // Token: 0x4000862
    private bool inited;

    // Token: 0x4000863
    private static Dictionary<string, AudioClip> audioCache;

    // Token: 0x4000864
    private static BGMController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000ABE
    // RVA   : 0x7F6BC0   Offset: 0x7F53C0   Length: 0x155
    public static AudioClip LoadAudio(string path)
    {
        var pStatics = *(int64*)(DAT_181d8a9a8 + 184);
        bool cVar1;
        ulong uVar2;
        if (*pStatics != 0) {
          cVar1 = FUN_1808ab750(*pStatics,path,DAT_181da3178);
          if (!cVar1) {
            uVar2 = Resources.Load(path,DAT_181d770e0);
            if (*pStatics == 0) throw; // [null/range check failed]
            FUN_1808aec90(*pStatics,path,uVar2,DAT_181da3278);
          }
          if (*pStatics != 0) {
            FUN_1817897a0(*pStatics,path,DAT_181da31f8);
            return;
          }
        }
    }

    // Token : 0x6000ABF
    // RVA   : 0x7F8260   Offset: 0x7F6A60   Length: 0x58
    public static BGMController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181d8a9a8 + 184) + 8);
    }

    // Token : 0x6000AC0
    // RVA   : 0x7F6240   Offset: 0x7F4A40   Length: 0x26E
    private void Awake()
    {
        ulong uVar1;
        long lVar2;
        uint uVar4;
        long lVar5;
        plVar3 = (int64 *)(*(int64 *)(DAT_181d8a9a8 + 184) + 8);
        *plVar3 = this;
        il2cpp_internal(plVar3,this);
        lVar2 = this.AllBGM;
        uVar4 = 0;
        if (lVar2 != null) {
          lVar5 = 32;
          while( true ) {
            if (lVar2.Count <= (int)uVar4) {
              return;
            }
            if (lVar2 == null) break;
            if (lVar2.Count <= uVar4) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            lVar2 = *(int64 *)(lVar5 + lVar2._items);
            if (lVar2 == null) break;
            if (lVar2._version) {
              lVar2 = this.bigMapBGM;
              if ((this.AllBGM == null) ||
                 (uVar1 = FUN_180002f80(this.AllBGM,uVar4,DAT_181d567c0), lVar2 == null))
              break;
              FUN_181827900(lVar2,uVar1,DAT_181d56640);
            }
            if ((this.AllBGM == null) ||
               (lVar2 = FUN_180002f80(this.AllBGM,uVar4,DAT_181d567c0)) == null)
            break;
            if (*(char *)(lVar2 + 29) != false) {
              lVar2 = this.areaBGM;
              if ((this.AllBGM == null) ||
                 (uVar1 = FUN_180002f80(this.AllBGM,uVar4,DAT_181d567c0), lVar2 == null))
              break;
              FUN_181827900(lVar2,uVar1,DAT_181d56640);
            }
            if ((this.AllBGM == null) ||
               (lVar2 = FUN_180002f80(this.AllBGM,uVar4,DAT_181d567c0)) == null)
            break;
            if (*(char *)(lVar2 + 40) != false) {
              lVar2 = this.fightBGM;
              if ((this.AllBGM == null) ||
                 (uVar1 = FUN_180002f80(this.AllBGM,uVar4,DAT_181d567c0), lVar2 == null))
              break;
              FUN_181827900(lVar2,uVar1,DAT_181d56640);
            }
            if ((this.AllBGM == null) ||
               (lVar2 = FUN_180002f80(this.AllBGM,uVar4,DAT_181d567c0)) == null)
            break;
            if (*(char *)(lVar2 + 41) != false) {
              lVar2 = this.bossBGM;
              if ((this.AllBGM == null) ||
                 (uVar1 = FUN_180002f80(this.AllBGM,uVar4,DAT_181d567c0), lVar2 == null))
              break;
              FUN_181827900(lVar2,uVar1,DAT_181d56640);
            }
            lVar2 = this.AllBGM;
            uVar4 = uVar4 + 1;
            lVar5 = lVar5 + 8;
            if (lVar2 == null) break;
          }
        }
    }

    // Token : 0x6000AC1
    // RVA   : 0x7F69D0   Offset: 0x7F51D0   Length: 0x1EA
    private void Init()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        bool cVar1;
        long lVar2;
        ulong uVar3;
        if (this.plotBgm == null) {
        LAB_1807f6a26:
          this.plotBgm = 0;
          if ((*pStatics == 0) ||
             (lVar2 = *(int64 *)(*pStatics + 32)) == null)
          throw; // [null/range check failed]
          lVar2 = WorldData.Player(lVar2,0);
          if (lVar2 == null) throw; // [null/range check failed]
          if (*(int *)(lVar2 + 192) == -1) {
            uVar3 = this.bigMapBGM;
          }
          else {
            uVar3 = this.areaBGM;
          }
          uVar3 = BGMController.GetRandomBGM(this,uVar3,0);
          this.nowBgm = uVar3;
          lVar2 = this.gameBGM;
          if (this.nowBgm == null) throw; // [null/range check failed]
          uVar3 = String.Concat(this.MusicPath,
                                 this.nowBgm.audioClip,0);
          uVar3 = BGMController.LoadAudio(uVar3,0);
          if (lVar2 == null) throw; // [null/range check failed]
          AudioSource.set_clip(lVar2,uVar3,0);
          if (this.gameBGM == null) throw; // [null/range check failed]
          AudioSource.Play(this.gameBGM,0);
        }
        else {
          cVar1 = FUN_180d6ca90(this.plotBgm.audioClip,0);
          if (cVar1) goto LAB_1807f6a26;
        }
        lVar2 = this.environmentSound;
        uVar3 = BGMController.GetEnvironmentSoundClip(this,0);
        if (lVar2 != null) {
          AudioSource.set_clip(lVar2,uVar3,0);
          if (this.environmentSound != null) {
            AudioSource.Play(this.environmentSound,0);
            return;
          }
        }
    }

    // Token : 0x6000AC2
    // RVA   : 0x7F64B0   Offset: 0x7F4CB0   Length: 0x304
    private AudioClip GetEnvironmentSoundClip()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        uint uVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        if (((*pStatics != 0) &&
            (lVar2 = *(int64 *)(*pStatics + 32)) != null) &&
           (lVar2 = WorldData.Player(lVar2,0)) != null) {
          if (*(int *)(lVar2 + 192) == -1) {
            return this.bigMapEnvironmentSoundClip;
          }
          lVar2 = *(int64 *)(*(int64 *)(DAT_181d8ee60 + 184) + 8);
          if (lVar2 == null) throw; // [null/range check failed]
          if (*(int64 *)(lVar2 + 24) != 0) {
            lVar2 = FUN_18046bca0(0);
            if (((lVar2 == null) || (*(int64 *)(lVar2 + 24) == 0)) ||
               (lVar2 = AreaBuildingData.DataBase(*(int64 *)(lVar2 + 24),0)) == null)
            throw; // [null/range check failed]
            if (*(int *)(lVar2 + 144) != -1) {
              lVar2 = this.environmentSoundClips;
              lVar3 = FUN_18046bca0(0);
              if (((lVar3 == null) || (*(int64 *)(lVar3 + 24) == 0)) ||
                 ((lVar3 = AreaBuildingData.DataBase(*(int64 *)(lVar3 + 24),0), lVar3 == null ||
                  (lVar2 == null)))) throw; // [null/range check failed]
              uVar1 = *(uint32 *)(lVar3 + 144);
              if (*(uint32 *)(lVar2 + 24) <= uVar1) {
                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar4,0);
              }
              goto LAB_1807f66c4;
            }
          }
          lVar2 = this.environmentSoundClips;
          if ((((*pStatics != 0) &&
               (lVar3 = *(int64 *)(*pStatics + 32)) != null) &&
              (lVar3 = WorldData.Player(lVar3,0)) != null) &&
             ((lVar3 = HeroData.GetArea(lVar3,0), lVar3 != null && (lVar2 != null)))) {
            uVar1 = *(uint32 *)(lVar3 + 72);
            if (*(uint32 *)(lVar2 + 24) <= uVar1) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar4,0);
            }
        LAB_1807f66c4:
            return lVar2[uVar1];
          }
        }
    }

    // Token : 0x6000AC3
    // RVA   : 0x7F6DF0   Offset: 0x7F55F0   Length: 0x4A
    private void ResetEnvironmentSound()
    {
        long lVar1;
        ulong uVar2;
        lVar1 = this.environmentSound;
        uVar2 = BGMController.GetEnvironmentSoundClip(this,0);
        if (lVar1 != null) {
          AudioSource.set_clip(lVar1,uVar2,0);
          if (this.environmentSound != null) {
            AudioSource.Play(this.environmentSound,0);
            return;
          }
        }
    }

    // Token : 0x6000AC4
    // RVA   : 0x7F71E0   Offset: 0x7F59E0   Length: 0xFA3
    private void Update()
    {
        var pStatics_b128 = *(int64*)(DAT_181d8b128 + 184);
        var pStatics_df90 = *(int64*)(DAT_181d4df90 + 184);
        var pStatics_e010 = *(int64*)(DAT_181d4e010 + 184);
        bool cVar1;
        long lVar2;
        ulong uVar3;
        ulong uVar4;
        long lVar5;
        float fVar9;
        float fVar10;
        float fVar11;
        uint uVar12;
        if (!this.inited) {
          this.inited = 1;
          BGMController.Init(this,0);
        }
        bVar8 = false;
        uVar4 = *(uint64 *)(pStatics_b128 + 80);
        cVar1 = Object.op_Inequality(uVar4,0,0);
        if (cVar1) {
          lVar5 = *(int64 *)(pStatics_b128 + 80);
          if (lVar5 == null) throw; // [null/range check failed]
          bVar8 = false;
          if (*(int *)(lVar5 + 36) != 0) {
            bVar8 = true;
          }
        }
        if ((*pStatics_df90 == 0) ||
           (lVar5 = *(int64 *)(*pStatics_df90 + 32)) == null)
        throw; // [null/range check failed]
        lVar2 = WorldData.Player(lVar5,0);
        lVar5 = this.environmentSound;
        if (lVar2 == null) {
        LAB_1807f746e:
          if (lVar5 == null) throw; // [null/range check failed]
          fVar9 = (float)AudioSource.get_volume(lVar5,0);
          fVar10 = (float)RealTime.get_deltaTime(0);
          fVar9 = fVar9 - fVar10 * 0.5;
        LAB_1807f76db:
          AudioSource.set_volume(lVar5,fVar9,0);
        }
        else {
          if (lVar5 == null) throw; // [null/range check failed]
          uVar4 = AudioSource.get_clip(lVar5,0);
          uVar3 = BGMController.GetEnvironmentSoundClip(this,0);
          cVar1 = Object.op_Equality(uVar4,uVar3,0);
          if (cVar1) {
            lVar5 = FUN_18046bca0(0);
            if (lVar5 == null) throw; // [null/range check failed]
            if (lVar5.Count == null) {
        LAB_1807f7612:
              fVar9 = 1.0;
            }
            else {
              lVar5 = FUN_18046bca0(0);
              if (((lVar5 == null) || (lVar5.Count == null)) ||
                 (lVar5 = AreaBuildingData.DataBase(lVar5.Count,0)) == null)
              throw; // [null/range check failed]
              if (*(int *)(lVar5 + 144) != -1) goto LAB_1807f7612;
              fVar9 = **(float **)(DAT_181d8ee60 + 184);
            }
            fVar9 = fVar9 * *(float *)(pStatics_e010 + 16);
            if (this.environmentSound == null) throw; // [null/range check failed]
            fVar10 = (float)AudioSource.get_volume(this.environmentSound,0);
            lVar5 = this.environmentSound;
            if (fVar10 < fVar9 - 0.05) {
              if (lVar5 == null) throw; // [null/range check failed]
              fVar9 = (float)AudioSource.get_volume(lVar5,0);
              fVar10 = (float)RealTime.get_deltaTime(0);
              fVar9 = fVar10 * 0.5 + fVar9;
            }
            else {
              if (lVar5 == null) throw; // [null/range check failed]
              fVar10 = (float)AudioSource.get_volume(lVar5,0);
              lVar5 = this.environmentSound;
              if (fVar9 + 0.05 < fVar10) goto LAB_1807f746e;
              if (lVar5 == null) throw; // [null/range check failed]
            }
            goto LAB_1807f76db;
          }
          if (this.environmentSound == null) throw; // [null/range check failed]
          fVar9 = (float)AudioSource.get_volume(this.environmentSound,0);
          if (0.0 < fVar9) {
            lVar5 = this.environmentSound;
            if (lVar5 == null) throw; // [null/range check failed]
            fVar9 = (float)AudioSource.get_volume(lVar5,0);
            fVar10 = (float)RealTime.get_deltaTime(0);
            fVar9 = fVar9 - fVar10 * 0.5;
            goto LAB_1807f76db;
          }
          BGMController.ResetEnvironmentSound(this,0);
        }
        if (this.noBgm) {
          if (this.gameBGM == null) throw; // [null/range check failed]
          fVar9 = (float)AudioSource.get_volume(this.gameBGM,0);
          if (fVar9 <= 0.0) {
            return;
          }
          lVar5 = this.gameBGM;
          if (lVar5 == null) throw; // [null/range check failed]
          fVar9 = (float)AudioSource.get_volume(lVar5,0);
          fVar10 = (float)RealTime.get_deltaTime(0);
          fVar10 = fVar10 * 0.15;
          goto LAB_1807f8167;
        }
        if ((this.plotBgm != null) &&
           (cVar1 = FUN_180d6ca90(this.plotBgm.audioClip,0), !cVar1)
           ) {
          lVar5 = this.gameBGM;
          if (this.nowBgm == this.plotBgm) {
            if (lVar5 == null) throw; // [null/range check failed]
            fVar9 = (float)AudioSource.get_volume(lVar5,0);
            if (this.plotBgm == null) throw; // [null/range check failed]
            fVar10 = this.plotBgm.volume;

            if ((lVar5 = *(int64 *)(pStatics_e010 + 8)?._items) == null) throw; // [null/range check failed]
            fVar11 = (float)PlayerPrefDictionary.GetFloat(lVar5,"BgmVolume",0);
            lVar5 = this.gameBGM;
            if (fVar9 < fVar11 * fVar10) {
              if (lVar5 != null) {
                fVar9 = (float)AudioSource.get_volume(lVar5,0);
                fVar10 = (float)RealTime.get_deltaTime(0);
                AudioSource.set_volume(lVar5,fVar10 * 0.2 + fVar9,0);
                return;
              }
              throw; // [null/range check failed]
            }
            if (lVar5 == null) throw; // [null/range check failed]
            fVar9 = (float)AudioSource.get_volume(lVar5,0);
            if (this.plotBgm == null) throw; // [null/range check failed]
            fVar10 = this.plotBgm.volume;

            if ((lVar5 = *(int64 *)(pStatics_e010 + 8)?._items) == null) throw; // [null/range check failed]
            fVar11 = (float)PlayerPrefDictionary.GetFloat(lVar5,"BgmVolume",0);
            if (fVar9 <= fVar11 * (fVar10 + 0.01)) {
              return;
            }
          }
          else {
            if (lVar5 == null) throw; // [null/range check failed]
            fVar9 = (float)AudioSource.get_volume(lVar5,0);
            if (fVar9 <= 0.0) {
              this.nowBgm = this.plotBgm;
              lVar5 = this.gameBGM;
              if (this.nowBgm == null) throw; // [null/range check failed]
              uVar4 = String.Concat(this.MusicPath,
                                     this.nowBgm.audioClip,0);
              uVar4 = BGMController.LoadAudio(uVar4,0);
              if (lVar5 == null) throw; // [null/range check failed]
              AudioSource.set_clip(lVar5,uVar4,0);
              lVar5 = this.gameBGM;
              if (lVar5 == null) throw; // [null/range check failed]
              uVar4 = 1;
              goto LAB_1807f794e;
            }
          }
          lVar5 = this.gameBGM;
          if (lVar5 != null) {
            fVar9 = (float)AudioSource.get_volume(lVar5,0);
            fVar10 = (float)RealTime.get_deltaTime(0);
            fVar10 = fVar10 * 0.2;
        LAB_1807f8167:
            AudioSource.set_volume(lVar5,fVar9 - fVar10,0);
            return;
          }
          throw; // [null/range check failed]
        }
        lVar5 = this.fightBGM;
        if (!bVar8) {
          if (lVar5 == null) throw; // [null/range check failed]
          cVar1 = FUN_1818279a0(lVar5,this.nowBgm,DAT_181d566c0);
          if (!cVar1) {
            if (this.bossBGM == null) throw; // [null/range check failed]
            cVar1 = FUN_1818279a0(this.bossBGM,this.nowBgm,
                                  DAT_181d566c0);
            if (!cVar1) goto LAB_1807f7b28;
          }
          if (this.gameBGM == null) throw; // [null/range check failed]
          fVar9 = (float)AudioSource.get_volume(this.gameBGM,0);
          if (0.0 < fVar9) {
            lVar5 = this.gameBGM;
            if (lVar5 == null) throw; // [null/range check failed]
            fVar9 = (float)AudioSource.get_volume(lVar5,0);
            fVar10 = (float)RealTime.get_deltaTime(0);
            fVar10 = fVar10 * 0.1;
            goto LAB_1807f8167;
          }
          lVar5 = FUN_18046c0a0(0);
          if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
             (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null) throw; // [null/range check failed]
          if (*(int *)(lVar5 + 192) == -1) {
            uVar4 = this.bigMapBGM;
          }
          else {
            uVar4 = this.areaBGM;
          }
        LAB_1807f7a1c:
          plVar6 = &this.nowBgm;
          lVar5 = BGMController.GetRandomBGM(this,uVar4,0);
          *plVar6 = lVar5;
          il2cpp_internal(plVar6,lVar5);
          lVar5 = this.gameBGM;
          if (*plVar6 == 0) throw; // [null/range check failed]
          uVar4 = String.Concat(this.MusicPath,*(uint64 *)(*plVar6 + 16),0);
          uVar4 = BGMController.LoadAudio(uVar4,0);
          if (lVar5 == null) throw; // [null/range check failed]
          AudioSource.set_clip(lVar5,uVar4,0);
          lVar5 = this.gameBGM;
          if (lVar5 == null) throw; // [null/range check failed]
          uVar4 = 0;
        LAB_1807f794e:
          AudioSource.set_loop(lVar5,uVar4,0);
          if (this.gameBGM != null) {
            AudioSource.set_time(this.gameBGM,0,0);
            if (this.gameBGM != null) {
              AudioSource.Play(this.gameBGM,0);
              return;
            }
          }
          throw; // [null/range check failed]
        }
        if (lVar5 == null) throw; // [null/range check failed]
        cVar1 = FUN_1818279a0(lVar5,this.nowBgm,DAT_181d566c0);
        if (!cVar1) {
          if (this.bossBGM == null) throw; // [null/range check failed]
          cVar1 = FUN_1818279a0(this.bossBGM,this.nowBgm,
                                DAT_181d566c0);
          if (!cVar1) {
            if (this.gameBGM == null) throw; // [null/range check failed]
            fVar9 = (float)AudioSource.get_volume(this.gameBGM,0);
            if (0.0 < fVar9) {
              lVar5 = this.gameBGM;
              if (lVar5 != null) {
                fVar9 = (float)AudioSource.get_volume(lVar5,0);
                fVar10 = (float)RealTime.get_deltaTime(0);
                fVar10 = fVar10 * 0.3;
                goto LAB_1807f8167;
              }
              throw; // [null/range check failed]
            }
            uVar4 = this.fightBGM;
            goto LAB_1807f7a1c;
          }
        }
        LAB_1807f7b28:
        plVar6 = &this.nowBgm;
        if (this.gameBGM == null) throw; // [null/range check failed]
        fVar9 = (float)AudioSource.get_volume(this.gameBGM,0);
        if (this.nowBgm == null) throw; // [null/range check failed]
        fVar10 = this.nowBgm.volume;

        if ((lVar5 = *(int64 *)(pStatics_e010 + 8)?._items) == null) throw; // [null/range check failed]
        fVar11 = (float)PlayerPrefDictionary.GetFloat(lVar5,"BgmVolume",0);
        lVar5 = this.gameBGM;
        if (fVar9 < fVar11 * fVar10) {
          if (lVar5 == null) throw; // [null/range check failed]
          fVar9 = (float)AudioSource.get_volume(lVar5,0);
          fVar10 = (float)RealTime.get_deltaTime(0);
          lVar2 = *(int64 *)(pStatics_e010 + 8);
          if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 16)) == null) throw; // [null/range check failed]
          fVar11 = (float)PlayerPrefDictionary.GetFloat(lVar2,"BgmVolume",0);
          AudioSource.set_volume(lVar5,fVar10 * 0.15 * fVar11 + fVar9,0);
          if (this.gameBGM == null) throw; // [null/range check failed]
          fVar9 = (float)AudioSource.get_volume(this.gameBGM,0);
          if (this.nowBgm == null) throw; // [null/range check failed]
          fVar10 = this.nowBgm.volume;

          if ((lVar5 = *(int64 *)(pStatics_e010 + 8)?._items) == null) throw; // [null/range check failed]
          fVar11 = (float)PlayerPrefDictionary.GetFloat(lVar5,"BgmVolume",0);
          fVar11 = fVar11 * fVar10;
          bVar8 = fVar9 == fVar11;
          bVar7 = fVar9 < fVar11;
        LAB_1807f7eed:
          if (bVar7 || bVar8) {
            return;
          }
          lVar5 = this.gameBGM;
          if (this.nowBgm != null) {
            fVar9 = this.nowBgm.volume;
            lVar2 = *(int64 *)(pStatics_e010 + 8);
            if (((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 16)) != null) &&
               (fVar10 = (float)PlayerPrefDictionary.GetFloat(lVar2,"BgmVolume",0), lVar5 != null)) {
              AudioSource.set_volume(lVar5,fVar10 * fVar9,0);
              return;
            }
          }
          throw; // [null/range check failed]
        }
        if (lVar5 == null) throw; // [null/range check failed]
        fVar9 = (float)AudioSource.get_volume(lVar5,0);
        if (this.nowBgm == null) throw; // [null/range check failed]
        fVar10 = this.nowBgm.volume;

        if ((lVar5 = *(int64 *)(pStatics_e010 + 8)?._items) == null) throw; // [null/range check failed]
        fVar11 = (float)PlayerPrefDictionary.GetFloat(lVar5,"BgmVolume",0);
        lVar5 = this.gameBGM;
        if (fVar11 * fVar10 < fVar9) {
          if (lVar5 == null) throw; // [null/range check failed]
          fVar9 = (float)AudioSource.get_volume(lVar5,0);
          fVar10 = (float)RealTime.get_deltaTime(0);
          lVar2 = *(int64 *)(pStatics_e010 + 8);
          if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 16)) == null) throw; // [null/range check failed]
          fVar11 = (float)PlayerPrefDictionary.GetFloat(lVar2,"BgmVolume",0);
          AudioSource.set_volume(lVar5,fVar9 - fVar10 * 0.15 * fVar11,0);
          if (this.gameBGM == null) throw; // [null/range check failed]
          fVar9 = (float)AudioSource.get_volume(this.gameBGM,0);
          if (this.nowBgm == null) throw; // [null/range check failed]
          fVar10 = this.nowBgm.volume;

          if ((lVar5 = *(int64 *)(pStatics_e010 + 8)?._items) == null) throw; // [null/range check failed]
          fVar11 = (float)PlayerPrefDictionary.GetFloat(lVar5,"BgmVolume",0);
          fVar11 = fVar11 * fVar10;
          bVar8 = fVar11 == fVar9;
          bVar7 = fVar11 < fVar9;
          goto LAB_1807f7eed;
        }
        if (lVar5 == null) throw; // [null/range check failed]
        cVar1 = AudioSource.get_isPlaying(lVar5,0);
        if (cVar1) {
          return;
        }
        fVar9 = (float)Time.get_timeScale(0);
        if (fVar9 == 0.0) {
          return;
        }
        fVar9 = this.quietTime;
        if (fVar9 <= 0.0) {
          if (bVar8) goto LAB_1807f7d07;
          lVar5 = FUN_18046c0a0(0);
          if (((lVar5 == null) || (*(int64 *)(lVar5 + 32) == 0)) ||
             (lVar5 = WorldData.Player(*(int64 *)(lVar5 + 32),0)) == null) throw; // [null/range check failed]
          if (*(int *)(lVar5 + 192) == -1) {
            uVar4 = this.bigMapBGM;
          }
          else {
            uVar4 = this.areaBGM;
          }
        }
        else {
          if (!bVar8) {
            fVar10 = (float)RealTime.get_deltaTime(0);
            this.quietTime = fVar9 - fVar10;
            return;
          }
        LAB_1807f7d07:
          uVar4 = this.fightBGM;
        }
        lVar5 = BGMController.GetRandomBGM(this,uVar4,0);
        this.nowBgm = lVar5;
        il2cpp_internal(plVar6,lVar5);
        lVar5 = this.gameBGM;
        if (this.nowBgm != null) {
          uVar4 = String.Concat(this.MusicPath,this.nowBgm.audioClip,0);
          uVar4 = BGMController.LoadAudio(uVar4,0);
          if (lVar5 != null) {
            AudioSource.set_clip(lVar5,uVar4,0);
            if (this.gameBGM != null) {
              AudioSource.set_loop(this.gameBGM,0,0);
              if (this.gameBGM != null) {
                AudioSource.set_time(this.gameBGM,0,0);
                if (this.gameBGM != null) {
                  AudioSource.Play(this.gameBGM,0);
                  uVar12 = Random.Range(0x40a00000,0x41700000,0);
                  this.quietTime = uVar12;
                  return;
                }
              }
            }
          }
        }
    }

    // Token : 0x6000AC5
    // RVA   : 0x7F6E60   Offset: 0x7F5660   Length: 0x1D
    public void SetBgm(int id)
    {
        long lVar1;
        ulong uVar2;
        lVar1 = this.AllBGM;
        if (lVar1 != null) {
          if (lVar1.Count <= id) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          this.nowBgm =
               lVar1._items[id];
          il2cpp_internal(this + 88);
          lVar1 = this.gameBGM;
          if (this.nowBgm != null) {
            uVar2 = String.Concat(this.MusicPath,
                                   this.nowBgm.audioClip,0);
            uVar2 = BGMController.LoadAudio(uVar2,0);
            if (lVar1 != null) {
              AudioSource.set_clip(lVar1,uVar2,0);
              if (this.gameBGM != null) {
                AudioSource.set_loop(this.gameBGM,0,0);
                if (this.gameBGM != null) {
                  AudioSource.set_volume(this.gameBGM,param_4,0);
                  if (this.gameBGM != null) {
                    AudioSource.Play(this.gameBGM,0);
                    if (this.gameBGM != null) {
                      AudioSource.set_time(this.gameBGM,param_3,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000AC6
    // RVA   : 0x7F6E40   Offset: 0x7F5640   Length: 0x1A
    public void SetBgm(int id, float startTime)
    {
        long lVar1;
        ulong uVar2;
        lVar1 = this.AllBGM;
        if (lVar1 != null) {
          if (lVar1.Count <= id) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          this.nowBgm =
               lVar1._items[id];
          il2cpp_internal(this + 88);
          lVar1 = this.gameBGM;
          if (this.nowBgm != null) {
            uVar2 = String.Concat(this.MusicPath,
                                   this.nowBgm.audioClip,0);
            uVar2 = BGMController.LoadAudio(uVar2,0);
            if (lVar1 != null) {
              AudioSource.set_clip(lVar1,uVar2,0);
              if (this.gameBGM != null) {
                AudioSource.set_loop(this.gameBGM,0,0);
                if (this.gameBGM != null) {
                  AudioSource.set_volume(this.gameBGM,param_4,0);
                  if (this.gameBGM != null) {
                    AudioSource.Play(this.gameBGM,0);
                    if (this.gameBGM != null) {
                      AudioSource.set_time(this.gameBGM,startTime,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000AC7
    // RVA   : 0x7F6E80   Offset: 0x7F5680   Length: 0x147
    public void SetBgm(int id, float startTime, float startVolume)
    {
        long lVar1;
        ulong uVar2;
        lVar1 = this.AllBGM;
        if (lVar1 != null) {
          if (lVar1.Count <= id) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          this.nowBgm =
               lVar1._items[id];
          il2cpp_internal(this + 88);
          lVar1 = this.gameBGM;
          if (this.nowBgm != null) {
            uVar2 = String.Concat(this.MusicPath,
                                   this.nowBgm.audioClip,0);
            uVar2 = BGMController.LoadAudio(uVar2,0);
            if (lVar1 != null) {
              AudioSource.set_clip(lVar1,uVar2,0);
              if (this.gameBGM != null) {
                AudioSource.set_loop(this.gameBGM,0,0);
                if (this.gameBGM != null) {
                  AudioSource.set_volume(this.gameBGM,startVolume,0);
                  if (this.gameBGM != null) {
                    AudioSource.Play(this.gameBGM,0);
                    if (this.gameBGM != null) {
                      AudioSource.set_time(this.gameBGM,startTime,0);
                      return;
                    }
                  }
                }
              }
            }
          }
        }
    }

    // Token : 0x6000AC8
    // RVA   : 0x7F7080   Offset: 0x7F5880   Length: 0x137
    public void SetPlotBgm(string name)
    {
        long lVar1;
        if (name == 0xffffffff) {
          this.plotBgm = 0;
          if (this.gameBGM != null) {
            AudioSource.set_loop(this.gameBGM,0,0);
            return;
          }
        }
        else {
          lVar1 = this.AllBGM;
          if (lVar1 != null) {
            if (lVar1.Count <= name) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            this.plotBgm =
                 lVar1._items[name];
            il2cpp_internal();
            return;
          }
        }
    }

    // Token : 0x6000AC9
    // RVA   : 0x7F6FD0   Offset: 0x7F57D0   Length: 0xA8
    public void SetPlotBgm(int id)
    {
        long lVar1;
        if (id == 0xffffffff) {
          this.plotBgm = 0;
          if (this.gameBGM != null) {
            AudioSource.set_loop(this.gameBGM,0,0);
            return;
          }
        }
        else {
          lVar1 = this.AllBGM;
          if (lVar1 != null) {
            if (lVar1.Count <= id) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            this.plotBgm =
                 lVar1._items[id];
            il2cpp_internal();
            return;
          }
        }
    }

    // Token : 0x6000ACA
    // RVA   : 0x7F71C0   Offset: 0x7F59C0   Length: 0x1D
    public void StopNowBgm()
    {
        if (this.gameBGM != null) {
          AudioSource.Stop(this.gameBGM,0);
          return;
        }
    }

    // Token : 0x6000ACB
    // RVA   : 0x7F6D20   Offset: 0x7F5520   Length: 0xC8
    public void RefreshNowBgmVolumn()
    {
        float fVar1;
        long lVar2;
        long lVar3;
        float fVar4;
        lVar2 = this.gameBGM;
        if (this.nowBgm != null) {
          fVar1 = this.nowBgm.volume;
          lVar3 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 8);
          if ((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 16)) != null) {
            fVar4 = (float)PlayerPrefDictionary.GetFloat(lVar3,"BgmVolume",0);
            if (lVar2 != null) {
              AudioSource.set_volume(lVar2,fVar4 * fVar1,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000ACC
    // RVA   : 0x7F67C0   Offset: 0x7F4FC0   Length: 0x209
    public AudioClipPrefab GetRandomBGM(List<AudioClipPrefab> BGMList)
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        int iVar4;
        int iVar5;
        int iVar6;
        lVar2 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(lVar2,DAT_181d678f8);
        iVar5 = 0;
        if (BGMList != null) {
          for (; iVar5 < *(int *)(BGMList + 24); iVar5 = iVar5 + 1) {
            if (BGMList == this.areaBGM) {
              lVar3 = FUN_180002f80(BGMList,iVar5,DAT_181d567c0);
              if (lVar3 == null) throw; // [null/range check failed]
              if (*(int *)(lVar3 + 32) == -1) goto LAB_1807f693f;
              lVar3 = FUN_180002f80(BGMList,iVar5);
              if (lVar3 == null) throw; // [null/range check failed]
              iVar6 = *(int *)(lVar3 + 32);
              lVar3 = FUN_18046c0a0(0);
              if ((lVar3 == null) || (*(int64 *)(lVar3 + 32) == 0)) throw; // [null/range check failed]
              lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0);
              if (lVar3 == null) throw; // [null/range check failed]
              lVar3 = HeroData.GetArea(lVar3,0);
              if (lVar3 == null) throw; // [null/range check failed]
              if (iVar6 == *(int *)(lVar3 + 72)) {
                iVar6 = 3;
                goto LAB_1807f6944;
              }
            }
            else {
        LAB_1807f693f:
              iVar6 = 1;
        LAB_1807f6944:
              iVar4 = 0;
              do {
                if (lVar2 == null) throw; // [null/range check failed]
                FUN_181814fa0(lVar2,iVar5);
                iVar4 = iVar4 + 1;
              } while (iVar4 < iVar6);
            }
          }
          if (lVar2 != null) {
            uVar1 = FUN_180d8cf10(0,*(uint32 *)(lVar2 + 24),0);
            if (*(uint32 *)(lVar2 + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            uVar1 = lVar2[uVar1];
            if (*(uint32 *)(BGMList + 24) <= uVar1) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            return BGMList[uVar1];
          }
        }
    }

    // Token : 0x6000ACD
    // RVA   : 0x7F8210   Offset: 0x7F6A10   Length: 0x4A
    public void /*ctor*/()
    {
        this.MusicPath = "Sound/Music/";
        FUN_18044ef50(this,0);
    }

    // Token : 0x6000ACE
    // RVA   : 0x7F8190   Offset: 0x7F6990   Length: 0x76
    private static void /*cctor*/()
    {
        ulong uVar2;
        uVar2 = il2cpp_internal(DAT_181d5dfc8);
        FUN_1808ae540(uVar2,DAT_181da30f8);
        puVar1 = *(uint64 **)(DAT_181d8a9a8 + 184);
        *puVar1 = uVar2;
        il2cpp_internal(puVar1,uVar2);
    }

}
