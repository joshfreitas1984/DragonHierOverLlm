// ============================================================
// Type  : StartGameSettingController
// Token : 0x2000369
// ============================================================

public class StartGameSettingController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001B0D
    public HeroData Player;

    // Token: 0x4001B0E
    public List<int> BirthSetting;

    // Token: 0x4001B0F
    public int gameDifficulty;

    // Token: 0x4001B10
    public int gameMode;

    // Token: 0x4001B11
    public int endingTag;

    // Token: 0x4001B12
    public AudioSource startBgm;

    // Token: 0x4001B13
    public CustomDifficultyData customDifficultyData;

    // Token: 0x4001B14
    private static StartGameSettingController _instance;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x600213B
    // RVA   : 0xC713E0   Offset: 0xC6FBE0   Length: 0x36
    public static StartGameSettingController get_Instance()
    {
        return **(uint64 **)(DAT_181d81570 + 184);
    }

    // Token : 0x600213C
    // RVA   : 0xC6FCD0   Offset: 0xC6E4D0   Length: 0x155
    private void Awake()
    {
        ulong uVar2;
        long lVar3;
        plVar1 = *(int64 **)(DAT_181d81570 + 184);
        *plVar1 = this;
        il2cpp_internal(plVar1,this);
        uVar2 = Component.get_gameObject(this,0);
        Object.DontDestroyOnLoad(uVar2,0);
        lVar3 = new HeroData(0);
        if (lVar3 != null) {
          *(uint32 *)(lVar3 + 212) = 18;
          *(uint32 *)(lVar3 + 132) = *(uint32 *)(*(int64 *)(DAT_181d4ef00 + 184) + 236);
          *(uint32 *)(lVar3 + 0x178) = 0x461c3c00;
          *(uint32 *)(lVar3 + 0x184) = 0x461c3c00;
          *(uint32 *)(lVar3 + 400) = 0x461c3c00;
          *(uint8 *)(lVar3 + 0x2d8) = 1;
          this.Player = lVar3;
          return;
        }
    }

    // Token : 0x600213D
    // RVA   : 0xC71230   Offset: 0xC6FA30   Length: 0xA2
    private void Update()
    {
        long lVar1;
        long lVar2;
        uint uVar3;
        lVar1 = this.startBgm;
        lVar2 = *(int64 *)(*(int64 *)(DAT_181d4e010 + 184) + 8);
        if ((lVar2 != null) && (lVar2 = *(int64 *)(lVar2 + 16)) != null) {
          uVar3 = PlayerPrefDictionary.GetFloat(lVar2,"BgmVolume",0);
          if (lVar1 != null) {
            AudioSource.set_volume(lVar1,uVar3,0);
            return;
          }
        }
    }

    // Token : 0x600213E
    // RVA   : 0xC71150   Offset: 0xC6F950   Length: 0xDF
    public void StartSettingPlayerData()
    {
        long lVar1;
        lVar1 = new HeroData(0);
        if (lVar1 != null) {
          *(uint32 *)(lVar1 + 212) = 18;
          *(uint32 *)(lVar1 + 132) = *(uint32 *)(*(int64 *)(DAT_181d4ef00 + 184) + 236);
          *(uint32 *)(lVar1 + 0x178) = 0x461c3c00;
          *(uint32 *)(lVar1 + 0x184) = 0x461c3c00;
          *(uint32 *)(lVar1 + 400) = 0x461c3c00;
          *(uint8 *)(lVar1 + 0x2d8) = 1;
          this.Player = lVar1;
          return;
        }
    }

    // Token : 0x600213F
    // RVA   : 0xC6FE30   Offset: 0xC6E630   Length: 0x12B0
    public void BirthSettingPlayerData()
    {
        var pStatics = *(int64*)(DAT_181d4df90 + 184);
        int iVar1;
        uint uVar2;
        uint uVar3;
        long lVar4;
        ulong uVar5;
        long lVar6;
        uint uVar7;
        uint uVar8;
        long lVar9;
        float fVar10;
        ulong in_stack_ffffffffffffffa8;
        ulong in_stack_ffffffffffffffb0;
        lVar4 = this.BirthSetting;
        if (lVar4 == null) goto LAB_180c710d9;
        if (lVar4.summonLv == null) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        uVar7 = 0;
        lVar9 = 32;
        switch(*(uint32 *)(lVar4.isSummon + 32)) {
        case 0:
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseFightSkill) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv < 4) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          FUN_181814d10(lVar4,3,*(float *)(lVar4.isSummon + 44) + 5.0,DAT_181d79758);
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseLivingSkill) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv < 6) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar5 = 5;
          fVar10 = *(float *)(lVar4.isSummon + 52);
          break;
        case 1:
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseFightSkill) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv < 9) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          FUN_181814d10(lVar4,8,*(float *)(lVar4.isSummon + 64) + 5.0,DAT_181d79758);
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseLivingSkill) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv < 4) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar5 = 3;
          fVar10 = *(float *)(lVar4.isSummon + 44);
          break;
        case 2:
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseFightSkill) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv < 3) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          FUN_181814d10(lVar4,2,*(float *)(lVar4.isSummon + 40) + 5.0,DAT_181d79758);
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseLivingSkill) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv < 7) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar5 = 6;
          fVar10 = *(float *)(lVar4.isSummon + 56);
          break;
        case 3:
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseFightSkill) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv < 7) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          FUN_181814d10(lVar4,6,*(float *)(lVar4.isSummon + 56) + 5.0,DAT_181d79758);
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseLivingSkill) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv < 5) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar5 = 4;
          fVar10 = *(float *)(lVar4.isSummon + 48);
          break;
        case 4:
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseFightSkill) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          FUN_181814d10(lVar4,0,*(float *)(lVar4.isSummon + 32) + 5.0,DAT_181d79758);
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseLivingSkill) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv < 3) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar5 = 2;
          fVar10 = *(float *)(lVar4.isSummon + 40);
          break;
        case 5:
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseFightSkill) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv < 5) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          FUN_181814d10(lVar4,4,*(float *)(lVar4.isSummon + 48) + 5.0,DAT_181d79758);
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseLivingSkill) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar5 = 0;
          fVar10 = *(float *)(lVar4.isSummon + 32);
          break;
        case 6:
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseFightSkill) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv < 6) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          FUN_181814d10(lVar4,5,*(float *)(lVar4.isSummon + 52) + 5.0,DAT_181d79758);
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseLivingSkill) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv < 9) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar5 = 8;
          fVar10 = *(float *)(lVar4.isSummon + 64);
          break;
        case 7:
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseFightSkill) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv < 2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          FUN_181814d10(lVar4,1,*(float *)(lVar4.isSummon + 36) + 5.0,DAT_181d79758);
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseLivingSkill) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv < 2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar5 = 1;
          fVar10 = *(float *)(lVar4.isSummon + 36);
          break;
        case 8:
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseFightSkill) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv < 8) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          FUN_181814d10(lVar4,7,*(float *)(lVar4.isSummon + 60) + 5.0,DAT_181d79758);
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseLivingSkill) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv < 8) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar5 = 7;
          fVar10 = *(float *)(lVar4.isSummon + 60);
          break;
        case 0xffffffff:
          lVar4 = this.Player;
          lVar6 = lVar9;
          uVar8 = uVar7;
          if (lVar4 != null) {
            while (lVar4.baseFightSkill != null) {
              if (*(int *)(lVar4.baseFightSkill + 24) <= (int)uVar8) {
                lVar6 = lVar9;
                uVar8 = uVar7;
                if (lVar4 != null) goto LAB_180c6ffc0;
                break;
              }
              if ((lVar4 = lVar4?.baseFightSkill) == null) break;
              if (lVar4.summonLv <= uVar8) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              FUN_181814d10(lVar4,uVar8,*(float *)(lVar4.isSummon + lVar6) + 1.0,
                            DAT_181d79758);
              lVar4 = this.Player;
              uVar8 = uVar8 + 1;
              lVar6 = lVar6 + 4;
              if (lVar4 == null) break;
            }
          }
          goto LAB_180c710d9;
        default:
          goto switchD_180c6ff0d_default;
        }
        FUN_181814d10(lVar4,uVar5,fVar10 + 5.0,DAT_181d79758);
        switchD_180c6ff0d_default:
        lVar4 = this.BirthSetting;
        lVar6 = this.Player;
        if (lVar4 == null) goto LAB_180c710d9;
        if (lVar4.summonLv == null) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        if (lVar6 == null) goto LAB_180c710d9;
        lVar6.defaultSkinID = -2 - *(int *)(lVar4.isSummon + 32);
        if (this.Player == null) goto LAB_180c710d9;
        lVar4 = this.BirthSetting;
        lVar6 = this.Player.baseAttri;
        if (lVar4 == null) goto LAB_180c710d9;
        if (lVar4.summonLv < 2) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        uVar8 = *(uint32 *)(lVar4.isSummon + 36);
        if (lVar6 == null) goto LAB_180c710d9;
        if (lVar6.summonLv <= uVar8) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        FUN_181814d10(lVar6,uVar8,
                      lVar6.isSummon[uVar8] + 5.0,
                      DAT_181d79758);
        lVar4 = this.BirthSetting;
        if (lVar4 == null) goto LAB_180c710d9;
        if (lVar4.summonLv < 3) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        switch(*(uint32 *)(lVar4.isSummon + 40)) {
        case 0:
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseAttri) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          FUN_181814d10(lVar4,0,*(float *)(lVar4.isSummon + 32) + 5.0,DAT_181d79758);
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseAttri) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv < 5) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar5 = 4;
          fVar10 = *(float *)(lVar4.isSummon + 48);
          break;
        case 1:
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseAttri) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          FUN_181814d10(lVar4,0,*(float *)(lVar4.isSummon + 32) + 5.0,DAT_181d79758);
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseAttri) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv < 2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar5 = 1;
          fVar10 = *(float *)(lVar4.isSummon + 36);
          break;
        case 2:
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseAttri) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv < 3) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar5 = 2;
          fVar10 = *(float *)(lVar4.isSummon + 40);
          goto LAB_180c70824;
        case 3:
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseAttri) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv < 3) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar5 = 2;
          fVar10 = *(float *)(lVar4.isSummon + 40);
          goto LAB_180c7075f;
        case 4:
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseAttri) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv < 5) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar5 = 4;
          fVar10 = *(float *)(lVar4.isSummon + 48);
        LAB_180c7075f:
          FUN_181814d10(lVar4,uVar5,fVar10 + 5.0,DAT_181d79758);
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseAttri) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv < 4) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar5 = 3;
          fVar10 = *(float *)(lVar4.isSummon + 44);
          break;
        case 5:
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseAttri) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv < 2) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar5 = 1;
          fVar10 = *(float *)(lVar4.isSummon + 36);
        LAB_180c70824:
          FUN_181814d10(lVar4,uVar5,fVar10 + 5.0,DAT_181d79758);
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseAttri) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv < 6) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar5 = 5;
          fVar10 = *(float *)(lVar4.isSummon + 52);
          break;
        default:
          goto switchD_180c705de_default;
        }
        FUN_181814d10(lVar4,uVar5,fVar10 + 5.0,DAT_181d79758);
        switchD_180c705de_default:
        if (this.Player == null) goto LAB_180c710d9;
        lVar4 = this.BirthSetting;
        lVar6 = this.Player.baseFightSkill;
        if (lVar4 == null) goto LAB_180c710d9;
        if (lVar4.summonLv < 4) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        iVar1 = *(int *)(lVar4.isSummon + 44);
        uVar8 = iVar1 + 3;
        if (lVar6 == null) goto LAB_180c710d9;
        if (lVar6.summonLv <= uVar8) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        FUN_181814d10(lVar6,uVar8,
                      *(float *)(lVar6.isSummon + 44 + (int64)iVar1 * 4) + 5.0,
                      DAT_181d79758);
        lVar4 = this.BirthSetting;
        if (lVar4 == null) goto LAB_180c710d9;
        if (lVar4.summonLv < 5) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        switch(*(uint32 *)(lVar4.isSummon + 48)) {
        case 0:
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseLivingSkill) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv == null) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          FUN_181814d10(lVar4,0,*(float *)(lVar4.isSummon + 32) + 10.0,DAT_181d79758);
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseLivingSkill) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv < 8) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar5 = 7;
          fVar10 = *(float *)(lVar4.isSummon + 60) + 10.0;
          break;
        case 1:
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseLivingSkill) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv < 3) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          FUN_181814d10(lVar4,2,*(float *)(lVar4.isSummon + 40) + 10.0,DAT_181d79758);
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseLivingSkill) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv < 4) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar5 = 3;
          fVar10 = *(float *)(lVar4.isSummon + 44) + 10.0;
          break;
        case 2:
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseLivingSkill) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv < 5) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          FUN_181814d10(lVar4,4,*(float *)(lVar4.isSummon + 48) + 10.0,DAT_181d79758);
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseLivingSkill) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv < 6) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar5 = 5;
          fVar10 = *(float *)(lVar4.isSummon + 52) + 10.0;
          break;
        case 3:
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseLivingSkill) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv < 7) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          FUN_181814d10(lVar4,6,*(float *)(lVar4.isSummon + 56) + 10.0,DAT_181d79758);
          if ((this.Player == null) ||
             (lVar4 = this.Player.baseLivingSkill) == null)
          goto LAB_180c710d9;
          if (lVar4.summonLv < 9) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar5 = 8;
          fVar10 = *(float *)(lVar4.isSummon + 64) + 10.0;
          break;
        case 4:
          lVar4 = this.Player;
          if (lVar4 != null) {
            while (lVar4.baseLivingSkill != null) {
              if (*(int *)(lVar4.baseLivingSkill + 24) <= (int)uVar7)
              goto switchD_180c70925_default;
              if ((lVar4 = lVar4?.baseLivingSkill) == null) break;
              if (lVar4.summonLv <= uVar7) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              FUN_181814d10(lVar4,uVar7,*(float *)(lVar4.isSummon + lVar9) + 3.0,
                            DAT_181d79758);
              lVar4 = this.Player;
              uVar7 = uVar7 + 1;
              lVar9 = lVar9 + 4;
              if (lVar4 == null) break;
            }
          }
          goto LAB_180c710d9;
        case 5:
          lVar4 = this.Player;
          if (lVar4 != null) {
            while (lVar4.baseLivingSkill != null) {
              if (*(int *)(lVar4.baseLivingSkill + 24) <= (int)uVar7)
              goto switchD_180c70925_default;
              if ((lVar4 = lVar4?.maxLivingSkill) == null) break;
              if (lVar4.summonLv <= uVar7) {
                ThrowHelper.ThrowArgumentOutOfRangeException(0);
              }
              FUN_181814d10(lVar4,uVar7,*(float *)(lVar4.isSummon + lVar9) + 1.0,
                            DAT_181d79758);
              lVar4 = this.Player;
              uVar7 = uVar7 + 1;
              lVar9 = lVar9 + 4;
              if (lVar4 == null) break;
            }
          }
          goto LAB_180c710d9;
        default:
          goto switchD_180c70925_default;
        }
        FUN_181814d10(lVar4,uVar5,fVar10,DAT_181d79758);
        switchD_180c70925_default:
        lVar4 = this.BirthSetting;
        if (lVar4 == null) goto LAB_180c710d9;
        if (lVar4.summonLv < 6) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        switch(*(uint32 *)(lVar4.isSummon + 52)) {
        case 0:
          lVar4 = this.Player;
          lVar9 = this.BirthSetting;
          lVar6 = *pStatics;
          if (lVar9 == null) goto LAB_180c710d9;
          if (lVar9.Count < 4) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar3 = *(uint32 *)(lVar9._items + 44);
          uVar2 = FUN_180d8cf10(0,6);
          if (lVar6 == null) goto LAB_180c710d9;
          in_stack_ffffffffffffffb0 = 0;
          in_stack_ffffffffffffffa8 = in_stack_ffffffffffffffa8 & 0xffffffff00000000;
          uVar5 = GameController.GenerateWeapon(lVar6,1,uVar3,uVar2,in_stack_ffffffffffffffa8,0,0);
          goto LAB_180c70dce;
        case 1:
          lVar4 = this.Player;
          lVar9 = *pStatics;
          uVar3 = FUN_180d8cf10(0,6);
          if (lVar9 == null) goto LAB_180c710d9;
          in_stack_ffffffffffffffb0 = 0;
          in_stack_ffffffffffffffa8 = 0;
          uVar5 = GameController.GenerateArmor(lVar9,1,uVar3,0,0,0);
          if (lVar4 == null) goto LAB_180c710d9;
          HeroData.GetItem(lVar4,uVar5,0,0);
          break;
        case 2:
          lVar4 = this.Player;
          lVar9 = this.BirthSetting;
          lVar6 = *pStatics;
          if (lVar9 == null) goto LAB_180c710d9;
          if (lVar9.Count < 4) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          if (lVar6 == null) goto LAB_180c710d9;
          in_stack_ffffffffffffffb0 = 0;
          in_stack_ffffffffffffffa8 = 0;
          uVar5 = GameController.GenerateBookSkillType
                            (lVar6,0,0,*(int *)(lVar9._items + 44) + 3,0,0);
        LAB_180c70dce:
          if (lVar4 == null) goto LAB_180c710d9;
          HeroData.GetItem(lVar4,uVar5,0,0);
          break;
        case 3:
          lVar4 = this.Player;
          if (*pStatics == 0) goto LAB_180c710d9;
          in_stack_ffffffffffffffa8 = 0;
          uVar5 = GameController.GenerateHorseData(*pStatics,1,1,0,0);
          if (lVar4 == null) goto LAB_180c710d9;
          HeroData.GetItem(lVar4,uVar5,0,0);
          break;
        case 4:
          if (this.Player == null) goto LAB_180c710d9;
          HeroData.ChangeMoney(this.Player,500,1,0);
          break;
        case 5:
          if (this.Player == null) goto LAB_180c710d9;
          HeroData.ChangeFame(this.Player,0x42480000,1,0);
        }
        if (0 < this.endingTag) {
          if (this.Player == null) {
        LAB_180c710d9:
                          // WARNING: Subroutine does not return
            FUN_1800d6620();
          }
          HeroData.AddTag(this.Player,this.endingTag + 0x17a,0xbf800000,0,
                           in_stack_ffffffffffffffa8 & 0xffffffffffffff00,
                           in_stack_ffffffffffffffb0 & 0xffffffffffffff00,0);
        }
        return;
        LAB_180c6ffc0:
        if (lVar4.baseLivingSkill == null) goto LAB_180c710d9;
        if (*(int *)(lVar4.baseLivingSkill + 24) <= (int)uVar8) goto switchD_180c6ff0d_default;
        if ((lVar4 = lVar4?.baseLivingSkill) == null) goto LAB_180c710d9;
        if (lVar4.summonLv <= uVar8) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        FUN_181814d10(lVar4,uVar8,*(float *)(lVar4.isSummon + lVar6) + 1.0,DAT_181d79758);
        lVar4 = this.Player;
        lVar6 = lVar6 + 4;
        uVar8 = uVar8 + 1;
        if (lVar4 == null) goto LAB_180c710d9;
        goto LAB_180c6ffc0;
    }

    // Token : 0x6002140
    // RVA   : 0xC712E0   Offset: 0xC6FAE0   Length: 0xF9
    public void /*ctor*/()
    {
        long lVar1;
        lVar1 = il2cpp_internal(DAT_181d6f030);
        FUN_180f58a90(lVar1,DAT_181d678f8);
        if (lVar1 != null) {
          FUN_181814fa0(lVar1,0xffffffff,DAT_181d67a78);
          FUN_181814fa0(lVar1,0,DAT_181d67a78);
          FUN_181814fa0(lVar1,0,DAT_181d67a78);
          FUN_181814fa0(lVar1,0,DAT_181d67a78);
          FUN_181814fa0(lVar1,0,DAT_181d67a78);
          FUN_181814fa0(lVar1,0,DAT_181d67a78);
          this.BirthSetting = lVar1;
          FUN_18044ef50(this,0);
          return;
        }
    }

}
