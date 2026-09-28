// ============================================================
// Type  : BGMController
// Token : 0x2000151
// ============================================================

public class BGMController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x400087A
    public AudioSource gameBGM;

    // Token: 0x400087B
    public AudioSource environmentSound;

    // Token: 0x400087C
    public List<AudioClipPrefab> AllBGM;

    // Token: 0x400087D
    public List<AudioClipPrefab> bigMapBGM;

    // Token: 0x400087E
    public List<AudioClipPrefab> areaBGM;

    // Token: 0x400087F
    public List<AudioClipPrefab> fightBGM;

    // Token: 0x4000880
    public List<AudioClipPrefab> bossBGM;

    // Token: 0x4000881
    private bool fightBGMStarted;

    // Token: 0x4000882
    public AudioClipPrefab nowBgm;

    // Token: 0x4000883
    public AudioClipPrefab plotBgm;

    // Token: 0x4000884
    public bool noBgm;

    // Token: 0x4000885
    public AudioClip bigMapEnvironmentSoundClip;

    // Token: 0x4000886
    public AudioClip[] environmentSoundClips;

    // Token: 0x4000887
    private string MusicPath;

    // Token: 0x4000888
    public float quietTime;

    // Token: 0x4000889
    private bool inited;

    // Token: 0x400088A
    private static Dictionary<string, AudioClip> audioCache;

    // Token: 0x400088B
    private static BGMController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x6000AE1
    // RVA   : 0x7F4FF0   Offset: 0x7F43F0   Length: 0x155
    public static AudioClip LoadAudio(string path)
    {
        bool cVar1;
        ulong uVar2;
        if (BGMController.audioCache != null) {
          cVar1 = FUN_1808ab490(BGMController.audioCache,path,DAT_181d728e8);
          if (!cVar1) {
            uVar2 = Resources.Load(path,DAT_181d9ff80);
            if (BGMController.audioCache == null) throw; // [null/range check failed]
            FUN_1808b2160(BGMController.audioCache,path,uVar2,DAT_181d729f8);
          }
          if (BGMController.audioCache != null) {
            FUN_1817c63a0(BGMController.audioCache,path,DAT_181d72970);
            return;
          }
        }
    }

    // Token : 0x6000AE2
    // RVA   : 0x7F66A0   Offset: 0x7F5AA0   Length: 0x58
    public static BGMController get_Instance()
    {
        return *(uint64 *)(*(int64 *)(DAT_181dafac8 + 184) + 8);
    }

    // Token : 0x6000AE3
    // RVA   : 0x7F4670   Offset: 0x7F3A70   Length: 0x26E
    private void Awake()
    {
        ulong uVar1;
        long lVar2;
        uint uVar4;
        long lVar5;
        plVar3 = (int64 *)(*(int64 *)(DAT_181dafac8 + 184) + 8);
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
                 (uVar1 = FUN_180002f80(this.AllBGM,uVar4,DAT_181d7dd50), lVar2 == null))
              break;
              FUN_18181e0a0(lVar2,uVar1,DAT_181d7dbd8);
            }
            if ((this.AllBGM == null) ||
               (lVar2 = FUN_180002f80(this.AllBGM,uVar4,DAT_181d7dd50)) == null)
            break;
            if (*(char *)(lVar2 + 29) != false) {
              lVar2 = this.areaBGM;
              if ((this.AllBGM == null) ||
                 (uVar1 = FUN_180002f80(this.AllBGM,uVar4,DAT_181d7dd50), lVar2 == null))
              break;
              FUN_18181e0a0(lVar2,uVar1,DAT_181d7dbd8);
            }
            if ((this.AllBGM == null) ||
               (lVar2 = FUN_180002f80(this.AllBGM,uVar4,DAT_181d7dd50)) == null)
            break;
            if (*(char *)(lVar2 + 40) != false) {
              lVar2 = this.fightBGM;
              if ((this.AllBGM == null) ||
                 (uVar1 = FUN_180002f80(this.AllBGM,uVar4,DAT_181d7dd50), lVar2 == null))
              break;
              FUN_18181e0a0(lVar2,uVar1,DAT_181d7dbd8);
            }
            if ((this.AllBGM == null) ||
               (lVar2 = FUN_180002f80(this.AllBGM,uVar4,DAT_181d7dd50)) == null)
            break;
            if (*(char *)(lVar2 + 41) != false) {
              lVar2 = this.bossBGM;
              if ((this.AllBGM == null) ||
                 (uVar1 = FUN_180002f80(this.AllBGM,uVar4,DAT_181d7dd50), lVar2 == null))
              break;
              FUN_18181e0a0(lVar2,uVar1,DAT_181d7dbd8);
            }
            lVar2 = this.AllBGM;
            uVar4 = uVar4 + 1;
            lVar5 = lVar5 + 8;
            if (lVar2 == null) break;
          }
        }
    }

    // Token : 0x6000AE4
    // RVA   : 0x7F4E00   Offset: 0x7F4200   Length: 0x1EF
    private void Init()
    {
        bool cVar1;
        long lVar2;
        ulong uVar3;
        if (this.plotBgm == null) {
        LAB_1807f4e56:
          this.plotBgm = 0;
          if ((GameController._instance == null) ||
             (lVar2 = GameController._instance.worldData) == null)
          throw; // [null/range check failed]
          lVar2 = WorldData.Player(lVar2,0);
          if (lVar2 == null) throw; // [null/range check failed]
          cVar1 = HeroData.HaveArea(lVar2,0);
          if (!cVar1) {
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
          cVar1 = FUN_180d755b0(this.plotBgm.audioClip,0);
          if (cVar1) goto LAB_1807f4e56;
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

    // Token : 0x6000AE5
    // RVA   : 0x7F48E0   Offset: 0x7F3CE0   Length: 0x309
    private AudioClip GetEnvironmentSoundClip()
    {
        uint uVar1;
        bool cVar2;
        long lVar3;
        long lVar4;
        ulong uVar5;
        if (((GameController._instance != null) &&
            (lVar3 = GameController._instance.worldData) != null) &&
           (lVar3 = WorldData.Player(lVar3,0)) != null) {
          cVar2 = HeroData.HaveArea(lVar3,0);
          if (!cVar2) {
            return this.bigMapEnvironmentSoundClip;
          }
          lVar3 = *(int64 *)(*(int64 *)(DAT_181db4008 + 184) + 8);
          if (lVar3 == null) throw; // [null/range check failed]
          if (lVar3.cityAreaID != null) {
            lVar3 = FUN_18046bca0(0);
            if (((lVar3 == null) || (lVar3.cityAreaID == null)) ||
               (lVar3 = AreaBuildingData.DataBase(lVar3.cityAreaID,0)) == null)
            throw; // [null/range check failed]
            if (lVar3.MailDatas != -1) {
              lVar3 = this.environmentSoundClips;
              lVar4 = FUN_18046bca0(0);
              if (((lVar4 == null) || (lVar4.cityAreaID == null)) ||
                 ((lVar4 = AreaBuildingData.DataBase(lVar4.cityAreaID,0), lVar4 == null ||
                  (lVar3 == null)))) throw; // [null/range check failed]
              uVar1 = lVar4.MailDatas;
              if (lVar3.cityAreaID <= uVar1) {
                uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                FUN_1800d65f0(uVar5,0);
              }
              goto LAB_1807f4af9;
            }
          }
          lVar3 = this.environmentSoundClips;
          if ((((GameController._instance != null) &&
               (lVar4 = GameController._instance.worldData) != null) &&
              (lVar4 = WorldData.Player(lVar4,0)) != null) &&
             ((lVar4 = HeroData.GetArea(lVar4,0), lVar4 != null && (lVar3 != null)))) {
            uVar1 = lVar4.Forces;
            if (lVar3.cityAreaID <= uVar1) {
              uVar5 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1800d65f0(uVar5,0);
            }
        LAB_1807f4af9:
            return lVar3[uVar1];
          }
        }
    }

    // Token : 0x6000AE6
    // RVA   : 0x7F5220   Offset: 0x7F4620   Length: 0x4A
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

    // Token : 0x6000AE7
    // RVA   : 0x7F5610   Offset: 0x7F4A10   Length: 0xFB1
    private void Update()
    {
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
        uVar4 = PlotController.LaBaFestivelResultTalkText;
        cVar1 = Object.op_Inequality(uVar4,0,0);
        if (cVar1) {
          lVar5 = PlotController.LaBaFestivelResultTalkText;
          if (lVar5 == null) throw; // [null/range check failed]
          bVar8 = false;
          if (*(int *)(lVar5 + 36) != 0) {
            bVar8 = true;
          }
        }
        if ((GameController._instance == null) ||
           (lVar5 = GameController._instance.worldData) == null)
        throw; // [null/range check failed]
        lVar2 = WorldData.Player(lVar5,0);
        lVar5 = this.environmentSound;
        if (lVar2 == null) {
        LAB_1807f589e:
          if (lVar5 == null) throw; // [null/range check failed]
          fVar9 = (float)AudioSource.get_volume(lVar5,0);
          fVar10 = (float)RealTime.get_deltaTime(0);
          fVar9 = fVar9 - fVar10 * 0.5;
        LAB_1807f5b0b:
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
        LAB_1807f5a42:
              fVar9 = 1.0;
            }
            else {
              lVar5 = FUN_18046bca0(0);
              if (((lVar5 == null) || (lVar5.Count == null)) ||
                 (lVar5 = AreaBuildingData.DataBase(lVar5.Count,0)) == null)
              throw; // [null/range check failed]
              if (lVar5.MailDatas != -1) goto LAB_1807f5a42;
              fVar9 = **(float **)(DAT_181db4008 + 184);
            }
            fVar9 = fVar9 * GameController.CheckShowSpeHero;
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
              if (fVar9 + 0.05 < fVar10) goto LAB_1807f589e;
              if (lVar5 == null) throw; // [null/range check failed]
            }
            goto LAB_1807f5b0b;
          }
          if (this.environmentSound == null) throw; // [null/range check failed]
          fVar9 = (float)AudioSource.get_volume(this.environmentSound,0);
          if (0.0 < fVar9) {
            lVar5 = this.environmentSound;
            if (lVar5 == null) throw; // [null/range check failed]
            fVar9 = (float)AudioSource.get_volume(lVar5,0);
            fVar10 = (float)RealTime.get_deltaTime(0);
            fVar9 = fVar9 - fVar10 * 0.5;
            goto LAB_1807f5b0b;
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
          goto LAB_1807f65a5;
        }
        if ((this.plotBgm != null) &&
           (cVar1 = FUN_180d755b0(this.plotBgm.audioClip,0), !cVar1)
           ) {
          lVar5 = this.gameBGM;
          if (this.nowBgm == this.plotBgm) {
            if (lVar5 == null) throw; // [null/range check failed]
            fVar9 = (float)AudioSource.get_volume(lVar5,0);
            if (this.plotBgm == null) throw; // [null/range check failed]
            fVar10 = this.plotBgm.volume;

            if ((lVar5 = GameController.difficultyExtraPoint?._items) == null) throw; // [null/range check failed]
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

            if ((lVar5 = GameController.difficultyExtraPoint?._items) == null) throw; // [null/range check failed]
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
              goto LAB_1807f5d7e;
            }
          }
          lVar5 = this.gameBGM;
          if (lVar5 != null) {
            fVar9 = (float)AudioSource.get_volume(lVar5,0);
            fVar10 = (float)RealTime.get_deltaTime(0);
            fVar10 = fVar10 * 0.2;
        LAB_1807f65a5:
            AudioSource.set_volume(lVar5,fVar9 - fVar10,0);
            return;
          }
          throw; // [null/range check failed]
        }
        lVar5 = this.fightBGM;
        if (!bVar8) {
          if (lVar5 == null) throw; // [null/range check failed]
          cVar1 = FUN_18181e400(lVar5,this.nowBgm,DAT_181d7dc50);
          if (!cVar1) {
            if (this.bossBGM == null) throw; // [null/range check failed]
            cVar1 = FUN_18181e400(this.bossBGM,this.nowBgm,
                                  DAT_181d7dc50);
            if (!cVar1) goto LAB_1807f5f58;
          }
          if (this.gameBGM == null) throw; // [null/range check failed]
          fVar9 = (float)AudioSource.get_volume(this.gameBGM,0);
          if (0.0 < fVar9) {
            lVar5 = this.gameBGM;
            if (lVar5 == null) throw; // [null/range check failed]
            fVar9 = (float)AudioSource.get_volume(lVar5,0);
            fVar10 = (float)RealTime.get_deltaTime(0);
            fVar10 = fVar10 * 0.1;
            goto LAB_1807f65a5;
          }
          lVar5 = FUN_18046c0a0(0);
          if (((lVar5 == null) || (lVar5.villageAreaID == null)) ||
             (lVar5 = WorldData.Player(lVar5.villageAreaID,0)) == null) throw; // [null/range check failed]
          cVar1 = HeroData.HaveArea(lVar5,0);
          if (!cVar1) {
            uVar4 = this.bigMapBGM;
          }
          else {
            uVar4 = this.areaBGM;
          }
        LAB_1807f5e4c:
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
        LAB_1807f5d7e:
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
        cVar1 = FUN_18181e400(lVar5,this.nowBgm,DAT_181d7dc50);
        if (!cVar1) {
          if (this.bossBGM == null) throw; // [null/range check failed]
          cVar1 = FUN_18181e400(this.bossBGM,this.nowBgm,
                                DAT_181d7dc50);
          if (!cVar1) {
            if (this.gameBGM == null) throw; // [null/range check failed]
            fVar9 = (float)AudioSource.get_volume(this.gameBGM,0);
            if (0.0 < fVar9) {
              lVar5 = this.gameBGM;
              if (lVar5 != null) {
                fVar9 = (float)AudioSource.get_volume(lVar5,0);
                fVar10 = (float)RealTime.get_deltaTime(0);
                fVar10 = fVar10 * 0.3;
                goto LAB_1807f65a5;
              }
              throw; // [null/range check failed]
            }
            uVar4 = this.fightBGM;
            goto LAB_1807f5e4c;
          }
        }
        LAB_1807f5f58:
        plVar6 = &this.nowBgm;
        if (this.gameBGM == null) throw; // [null/range check failed]
        fVar9 = (float)AudioSource.get_volume(this.gameBGM,0);
        if (this.nowBgm == null) throw; // [null/range check failed]
        fVar10 = this.nowBgm.volume;

        if ((lVar5 = GameController.difficultyExtraPoint?._items) == null) throw; // [null/range check failed]
        fVar11 = (float)PlayerPrefDictionary.GetFloat(lVar5,"BgmVolume",0);
        lVar5 = this.gameBGM;
        if (fVar9 < fVar11 * fVar10) {
          if (lVar5 == null) throw; // [null/range check failed]
          fVar9 = (float)AudioSource.get_volume(lVar5,0);
          fVar10 = (float)RealTime.get_deltaTime(0);
          lVar2 = GameController.difficultyExtraPoint;
          if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 16)) == null) throw; // [null/range check failed]
          fVar11 = (float)PlayerPrefDictionary.GetFloat(lVar2,"BgmVolume",0);
          AudioSource.set_volume(lVar5,fVar10 * 0.15 * fVar11 + fVar9,0);
          if (this.gameBGM == null) throw; // [null/range check failed]
          fVar9 = (float)AudioSource.get_volume(this.gameBGM,0);
          if (this.nowBgm == null) throw; // [null/range check failed]
          fVar10 = this.nowBgm.volume;

          if ((lVar5 = GameController.difficultyExtraPoint?._items) == null) throw; // [null/range check failed]
          fVar11 = (float)PlayerPrefDictionary.GetFloat(lVar5,"BgmVolume",0);
          fVar11 = fVar11 * fVar10;
          bVar8 = fVar9 == fVar11;
          bVar7 = fVar9 < fVar11;
        LAB_1807f6326:
          if (bVar7 || bVar8) {
            return;
          }
          lVar5 = this.gameBGM;
          if (this.nowBgm != null) {
            fVar9 = this.nowBgm.volume;
            lVar2 = GameController.difficultyExtraPoint;
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

        if ((lVar5 = GameController.difficultyExtraPoint?._items) == null) throw; // [null/range check failed]
        fVar11 = (float)PlayerPrefDictionary.GetFloat(lVar5,"BgmVolume",0);
        lVar5 = this.gameBGM;
        if (fVar11 * fVar10 < fVar9) {
          if (lVar5 == null) throw; // [null/range check failed]
          fVar9 = (float)AudioSource.get_volume(lVar5,0);
          fVar10 = (float)RealTime.get_deltaTime(0);
          lVar2 = GameController.difficultyExtraPoint;
          if ((lVar2 == null) || (lVar2 = *(int64 *)(lVar2 + 16)) == null) throw; // [null/range check failed]
          fVar11 = (float)PlayerPrefDictionary.GetFloat(lVar2,"BgmVolume",0);
          AudioSource.set_volume(lVar5,fVar9 - fVar10 * 0.15 * fVar11,0);
          if (this.gameBGM == null) throw; // [null/range check failed]
          fVar9 = (float)AudioSource.get_volume(this.gameBGM,0);
          if (this.nowBgm == null) throw; // [null/range check failed]
          fVar10 = this.nowBgm.volume;

          if ((lVar5 = GameController.difficultyExtraPoint?._items) == null) throw; // [null/range check failed]
          fVar11 = (float)PlayerPrefDictionary.GetFloat(lVar5,"BgmVolume",0);
          fVar11 = fVar11 * fVar10;
          bVar8 = fVar11 == fVar9;
          bVar7 = fVar11 < fVar9;
          goto LAB_1807f6326;
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
          if (bVar8) goto LAB_1807f6140;
          lVar5 = FUN_18046c0a0(0);
          if (((lVar5 == null) || (lVar5.villageAreaID == null)) ||
             (lVar5 = WorldData.Player(lVar5.villageAreaID,0)) == null) throw; // [null/range check failed]
          cVar1 = HeroData.HaveArea(lVar5,0);
          if (!cVar1) {
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
        LAB_1807f6140:
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

    // Token : 0x6000AE8
    // RVA   : 0x7F5290   Offset: 0x7F4690   Length: 0x1D
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

    // Token : 0x6000AE9
    // RVA   : 0x7F5270   Offset: 0x7F4670   Length: 0x1A
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

    // Token : 0x6000AEA
    // RVA   : 0x7F52B0   Offset: 0x7F46B0   Length: 0x147
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

    // Token : 0x6000AEB
    // RVA   : 0x7F54B0   Offset: 0x7F48B0   Length: 0x137
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

    // Token : 0x6000AEC
    // RVA   : 0x7F5400   Offset: 0x7F4800   Length: 0xA8
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

    // Token : 0x6000AED
    // RVA   : 0x7F55F0   Offset: 0x7F49F0   Length: 0x1D
    public void StopNowBgm()
    {
        if (this.gameBGM != null) {
          AudioSource.Stop(this.gameBGM,0);
          return;
        }
    }

    // Token : 0x6000AEE
    // RVA   : 0x7F5150   Offset: 0x7F4550   Length: 0xC8
    public void RefreshNowBgmVolumn()
    {
        float fVar1;
        long lVar2;
        long lVar3;
        float fVar4;
        lVar2 = this.gameBGM;
        if (this.nowBgm != null) {
          fVar1 = this.nowBgm.volume;
          lVar3 = *(int64 *)(*(int64 *)(DAT_181d72d50 + 184) + 8);
          if ((lVar3 != null) && (lVar3 = *(int64 *)(lVar3 + 16)) != null) {
            fVar4 = (float)PlayerPrefDictionary.GetFloat(lVar3,"BgmVolume",0);
            if (lVar2 != null) {
              AudioSource.set_volume(lVar2,fVar4 * fVar1,0);
              return;
            }
          }
        }
    }

    // Token : 0x6000AEF
    // RVA   : 0x7F4BF0   Offset: 0x7F3FF0   Length: 0x209
    public AudioClipPrefab GetRandomBGM(List<AudioClipPrefab> BGMList)
    {
        uint uVar1;
        long lVar2;
        long lVar3;
        int iVar4;
        int iVar5;
        int iVar6;
        lVar2 = il2cpp_internal(DAT_181d93cd0);
        FUN_18132faf0(lVar2,DAT_181d8f098);
        iVar5 = 0;
        if (BGMList != null) {
          for (; iVar5 < *(int *)(BGMList + 24); iVar5 = iVar5 + 1) {
            if (BGMList == this.areaBGM) {
              lVar3 = FUN_180002f80(BGMList,iVar5,DAT_181d7dd50);
              if (lVar3 == null) throw; // [null/range check failed]
              if (*(int *)(lVar3 + 32) == -1) goto LAB_1807f4d6f;
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
                goto LAB_1807f4d74;
              }
            }
            else {
        LAB_1807f4d6f:
              iVar6 = 1;
        LAB_1807f4d74:
              iVar4 = 0;
              do {
                if (lVar2 == null) throw; // [null/range check failed]
                FUN_18182a0b0(lVar2,iVar5);
                iVar4 = iVar4 + 1;
              } while (iVar4 < iVar6);
            }
          }
          if (lVar2 != null) {
            uVar1 = FUN_180d95a30(0,*(uint32 *)(lVar2 + 24),0);
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

    // Token : 0x6000AF0
    // RVA   : 0x7F6650   Offset: 0x7F5A50   Length: 0x4A
    public void /*ctor*/()
    {
        this.MusicPath = "Sound/Music/";
        FUN_18044ef50(this,0);
    }

    // Token : 0x6000AF1
    // RVA   : 0x7F65D0   Offset: 0x7F59D0   Length: 0x76
    private static void /*cctor*/()
    {
        ulong uVar2;
        uVar2 = il2cpp_internal(DAT_181d82a68);
        FUN_1808b1370(uVar2,DAT_181d72860);
        puVar1 = *(uint64 **)(DAT_181dafac8 + 184);
        *puVar1 = uVar2;
        il2cpp_internal(puVar1,uVar2);
    }

}
