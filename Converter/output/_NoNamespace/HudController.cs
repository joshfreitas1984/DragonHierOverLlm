// ============================================================
// Type  : HudController
// Token : 0x20002EB
// ============================================================

public class HudController
{
    // ── Fields ───────────────────────────────────────────────────
    // Token: 0x4001806
    public GameObject heroFace;

    // Token: 0x4001807
    public Text timeLabel;

    // Token: 0x4001808
    public Image timeCircle;

    // Token: 0x4001809
    public Text nameLabel;

    // Token: 0x400180A
    public Text fightScoreLabel;

    // Token: 0x400180B
    public Image weatherIcon;

    // Token: 0x400180C
    public Image seasonIcon;

    // Token: 0x400180D
    public Text fameLabel;

    // Token: 0x400180E
    public Text badfameLabel;

    // Token: 0x400180F
    public GameObject badfameIcon;

    // Token: 0x4001810
    public RectTransform moneyLayout;

    // Token: 0x4001811
    public Text moneyLabel;

    // Token: 0x4001812
    public Text forceLabel;

    // Token: 0x4001813
    public GameObject nowResearch;

    // Token: 0x4001814
    public Text contributionLabel;

    // Token: 0x4001815
    public Text heroNumLabel;

    // Token: 0x4001816
    public Text areaNumLabel;

    // Token: 0x4001817
    public GameObject forceUI;

    // Token: 0x4001818
    public GameObject infoList;

    // Token: 0x4001819
    public GameObject settingButton;

    // Token: 0x400181A
    public GameObject externalInjury;

    // Token: 0x400181B
    public GameObject internalInjury;

    // Token: 0x400181C
    public GameObject poisonInjury;

    // Token: 0x400181D
    public GameObject quickMap;

    // Token: 0x400181E
    public GameObject forceDetail;

    // Token: 0x400181F
    public GameObject heroSearch;

    // Token: 0x4001820
    private List<HudResourceShowData> hudResourceShowDatas;

    // Token: 0x4001821
    public bool inited;

    // Token: 0x4001822
    private float refreshTime;

    // Token: 0x4001823
    private static HudController _instance;

    // Token: 0x4001824
    public bool needRefreshPlayerSkeleton;

    // Token: 0x4001825
    private bool showInfoList;

    // ── Methods ──────────────────────────────────────────────────
    // Token : 0x60018B6
    // RVA   : 0x8AEA80   Offset: 0x8AD880   Length: 0x36
    public static HudController get_Instance()
    {
        return **(uint64 **)(DAT_181e569c8 + 184);
    }

    // Token : 0x60018B7
    // RVA   : 0x8AA260   Offset: 0x8A9060   Length: 0xDD
    private void Awake()
    {
        long lVar2;
        ulong uVar3;
        plVar1 = *(int64 **)(DAT_181e569c8 + 184);
        *plVar1 = this;
        il2cpp_internal(plVar1,this);
        if (this.forceUI != null) {
          lVar2 = GameObject.get_transform(this.forceUI,0);
          if (lVar2 != null) {
            lVar2 = Transform.Find(lVar2,"ContributionFull",0);
            if (lVar2 != null) {
              uVar3 = Component.GetComponent(lVar2,DAT_181e777b8);
              uVar3 = DOTweenModuleUI.DOFade(uVar3,0x3e99999a,0x40000000,0);
              TweenSettingsExtensions.SetLoops(uVar3,0xffffffff,1,DAT_181ea4e30);
              return;
            }
          }
        }
    }

    // Token : 0x60018B8
    // RVA   : 0x8AB1D0   Offset: 0x8A9FD0   Length: 0x3824
    private void Update()
    {
        var pStatics_0a28 = *(int64*)(DAT_181e50a28 + 184);
        var pStatics_2770 = *(int64*)(DAT_181e62770 + 184);
        var pStatics_38e8 = *(int64*)(DAT_181e538e8 + 184);
        var pStatics_43e8 = *(int64*)(DAT_181e743e8 + 184);
        var pStatics_5ae8 = *(int64*)(DAT_181e55ae8 + 184);
        var pStatics_b8e8 = *(int64*)(DAT_181e8b8e8 + 184);
        bool cVar1;
        int iVar2;
        long lVar3;
        ulong uVar4;
        long lVar5;
        long lVar6;
        ulong uVar7;
        ulong uVar9;
        ulong uVar10;
        uint uVar12;
        uint uVar13;
        long lVar14;
        float fVar15;
        float fVar16;
        int[] local_res8 = new int[2];
        int[] local_res18 = new int[2];
        float[] local_res20 = new float[2];
        float local_b8;
        float local_b4;
        int local_b0;
        uint32 local_ac;
        uint32 local_a8;
        uint32 local_a4;
        uint32 local_a0;
        uint64 local_98;
        uint32 local_90;
        uint8 local_88 [16];
        uint64 local_78;
        uint64 uStack_70;
        uVar13 = 0;
        local_res8[0] = 0;
        local_res18[0] = 0;
        local_res20[0] = 0.0;
        if (!this.inited) {
          this.inited = 1;
          if (this.heroFace == null) goto LAB_1808ae951;
          lVar3 = GameObject.GetComponent(this.heroFace,DAT_181e56400);
          if (((GameController._instance == null) ||
              (lVar14 = GameController._instance.worldData) == null) ||
             (uVar4 = WorldData.Player(lVar14,0), lVar3 == null)) goto LAB_1808ae951;
          lVar3.Count = uVar4;
          HudController.RefreshHeroSkeleton(this,0);
        }
        lVar3 = this.timeCircle;
        if (((GameController._instance == null) ||
            (lVar14 = GameController._instance.worldData) == null) ||
           (lVar3 == null)) goto LAB_1808ae951;
        Image.set_fillAmount(lVar3,lVar14.hour / 24.0,0);
        cVar1 = GlobalData.GetKeyDown(113);
        if (!cVar1) {
          cVar1 = GlobalData.GetKeyDown(105);
          if (!cVar1) {
            cVar1 = GlobalData.GetKeyDown(111);
            if (!cVar1) {
              cVar1 = GlobalData.GetKeyDown(112);
              if (cVar1) {
                if (this.heroSearch == null) goto LAB_1808ae951;
                cVar1 = GameObject.get_activeInHierarchy(this.heroSearch,0);
                if (cVar1) {
                  lVar3 = FUN_1802106e0(0);
                  if (lVar3 == null) goto LAB_1808ae951;
                  cVar1 = GameController.HaveSpeUI(lVar3,1,0);
                  if (!cVar1) {
                    lVar3 = FUN_180894360(0);
                    if (lVar3 == null) goto LAB_1808ae951;
                    HeroSearchController.OpenHeroSearch(lVar3,0);
                    goto LAB_1808abcd3;
                  }
                }
                lVar3 = FUN_180894360(0);
                if ((lVar3 == null) || (lVar3.Count == null)) goto LAB_1808ae951;
                cVar1 = GameObject.get_activeSelf(lVar3.Count,0);
                if (cVar1) {
                  lVar3 = FUN_180894360(0);
                  if (lVar3 == null) goto LAB_1808ae951;
                  if (((lVar3.Count == null) ||
                      (lVar14 = GameObject.get_transform(lVar3.Count,0)) == null) ||
                     (lVar14 = Transform.Find(lVar14,"BlackBackground",0)) == null) goto LAB_1808ae951;
                  uVar4 = Component.GetComponent(lVar14,DAT_181e777b8);
                  uVar4 = DOTweenModuleUI.DOFade(uVar4,0,0x3e4ccccd,0);
                  TweenSettingsExtensions.SetUpdate(uVar4,1,DAT_181ea5848);
                  if ((lVar3.Count == null) ||
                     (lVar14 = GameObject.get_transform(lVar3.Count,0)) == null)
                  goto LAB_1808ae951;
                  uVar4 = Transform.Find(lVar14,"HeroSearchRoot",0);
                  uVar4 = ShortcutExtensions.DOScaleX(uVar4,0,0x3e4ccccd,0);
                  uVar4 = TweenSettingsExtensions.SetUpdate(uVar4,1,DAT_181ea59e0);
                  uVar7 = new OnTooltipCB(lVar3,DAT_181e5c370,0);
                  TweenSettingsExtensions.OnComplete(uVar4,uVar7,DAT_181ea3dc0);
                }
              }
            }
            else {
              if (this.forceDetail == null) goto LAB_1808ae951;
              cVar1 = GameObject.get_activeInHierarchy(this.forceDetail,0);
              if (cVar1) {
                lVar3 = FUN_1802106e0(0);
                if (lVar3 == null) goto LAB_1808ae951;
                cVar1 = GameController.HaveSpeUI(lVar3,1,0);
                if (!cVar1) {
                  lVar3 = FUN_180894320(0);
                  if (lVar3 == null) goto LAB_1808ae951;
                  ForceDetailController.OpenForceDetail(lVar3,0);
                  goto LAB_1808abcd3;
                }
              }
              if ((*pStatics_0a28 == 0) ||
                 (lVar3 = *(int64 *)(*pStatics_0a28 + 24)) == null)
              goto LAB_1808ae951;
              cVar1 = GameObject.get_activeSelf(lVar3,0);
              if (cVar1) {
                lVar3 = FUN_180894320(0);
                if (lVar3 == null) goto LAB_1808ae951;
                ForceDetailController.HideForceDetail(lVar3,0);
              }
            }
          }
          else {
            if (this.quickMap == null) goto LAB_1808ae951;
            cVar1 = GameObject.get_activeInHierarchy(this.quickMap,0);
            if (cVar1) {
              lVar3 = FUN_1802106e0(0);
              if (lVar3 == null) goto LAB_1808ae951;
              cVar1 = GameController.HaveSpeUI(lVar3,1,0);
              if (!cVar1) {
                lVar3 = FUN_180210b30(0);
                if (lVar3 == null) goto LAB_1808ae951;
                QuickTravelUIController.ShowQuickTravelUIShowType(lVar3,0);
                goto LAB_1808abcd3;
              }
            }
            if ((*pStatics_43e8 == 0) ||
               (lVar3 = *(int64 *)(*pStatics_43e8 + 32)) == null)
            goto LAB_1808ae951;
            cVar1 = GameObject.get_activeSelf(lVar3,0);
            if (cVar1) {
              if (*pStatics_43e8 == 0) goto LAB_1808ae951;
              QuickTravelUIController.HideQuickTravelUI(*pStatics_43e8,0);
            }
          }
        }
        else {
          if (this.heroFace == null) goto LAB_1808ae951;
          cVar1 = GameObject.get_activeInHierarchy(this.heroFace,0);
          if (cVar1) {
            lVar3 = FUN_1802106e0(0);
            if (lVar3 == null) goto LAB_1808ae951;
            cVar1 = GameController.HaveSpeUI(lVar3,1,0);
            if (!cVar1) {
              if ((this.heroFace == null) ||
                 (lVar3 = GameObject.GetComponent(this.heroFace,DAT_181e56400),
                 lVar3 == null)) goto LAB_1808ae951;
              ShowHeroDetail.OnClick(lVar3,0);
              goto LAB_1808abcd3;
            }
          }
          if ((*pStatics_5ae8 == 0) ||
             (lVar3 = *(int64 *)(*pStatics_5ae8 + 32)) == null)
          goto LAB_1808ae951;
          cVar1 = GameObject.get_activeSelf(lVar3,0);
          if (cVar1) {

            if ((lVar3 = *(int64 *)(*(int64 *)(DAT_181e8d7d8 + 184) + 8)?.forceAreaID) == null) goto LAB_1808ae951;
            cVar1 = GameObject.get_activeSelf(lVar3,0);
            if (!cVar1) {
              if ((*pStatics_2770 == 0) ||
                 (lVar3 = *(int64 *)(*pStatics_2770 + 24)) == null)
              goto LAB_1808ae951;
              cVar1 = GameObject.get_activeSelf(lVar3,0);
              if (!cVar1) {
                lVar3 = FUN_180518680(0);
                if (lVar3 == null) goto LAB_1808ae951;
                HeroDetailController.UnshowHeroDetail(lVar3,0);
              }
            }
          }
        }
        LAB_1808abcd3:
        fVar16 = this.refreshTime;
        fVar15 = (float)RealTime.get_deltaTime(0);
        lVar3 = this.hudResourceShowDatas;
        fVar16 = fVar16 - fVar15;
        this.refreshTime = fVar16;
        if (lVar3 == null) {
        LAB_1808ae951:
                          // WARNING: Subroutine does not return
          FUN_1801e0300();
        }
        if (0 < lVar3.Count) {
          lVar14 = 32;
          do {
            if (lVar3.Count <= (int)uVar13) {
              FUN_18115d8f0(lVar3,DAT_181e6ecf0);
              fVar16 = this.refreshTime;
              goto LAB_1808abf6e;
            }
            if (lVar3 == null) break;
            if (lVar3.Count <= uVar13) {
              ThrowHelper.ThrowArgumentOutOfRangeException(0);
            }
            if (*(int64 *)(lVar14 + lVar3._items) != 0) {
              lVar3 = FUN_1802106e0(0);
              if ((this.hudResourceShowDatas == null) ||
                 (lVar5 = FUN_1800024b0(this.hudResourceShowDatas,uVar13,DAT_181e6edf0)) == null)
              break;
              uVar4 = Single.ToString(lVar5 + 20,"+0;-0;0",0);
              if (this.forceUI == null) break;
              lVar5 = GameObject.get_transform(this.forceUI,0);
              if ((((this.hudResourceShowDatas == null) ||
                   (lVar6 = FUN_1800024b0(this.hudResourceShowDatas,uVar13,DAT_181e6edf0)) == null
                   ) || (uVar7 = Int32.ToString(lVar6 + 16,0), lVar5 == null)) ||
                 (lVar5 = Transform.Find(lVar5,uVar7,0)) == null) break;
              puVar8 = (uint64 *)Transform.get_position(local_88,lVar5,0);
              uVar7 = *puVar8;
              uVar12 = *(uint32 *)(puVar8 + 1);
              if ((this.hudResourceShowDatas == null) ||
                 (lVar5 = FUN_1800024b0(this.hudResourceShowDatas,uVar13,DAT_181e6edf0)) == null)
              break;
              if (*(float *)(lVar5 + 20) <= 0.0) {
                uVar9 = *(uint64 *)(pStatics_38e8 + 0x2f8);
                uVar10 = *(uint64 *)(pStatics_38e8 + 0x300);
              }
              else {
                uVar9 = *(uint64 *)(pStatics_38e8 + 0x290);
                uVar10 = *(uint64 *)(pStatics_38e8 + 0x298);
              }
              if (lVar3 == null) break;
              local_a8 = 0;
              local_a4 = 0xbd23d70a;
              local_a0 = 0;
              local_98 = uVar7;
              local_90 = uVar12;
              local_78 = uVar9;
              uStack_70 = uVar10;
              GameController.ShowTextAtPos
                        (lVar3,uVar4,&local_98,18,&local_78,&local_a8,0,9,"UIAtlas",0,0,0);
            }
            lVar3 = this.hudResourceShowDatas;
            uVar13 = uVar13 + 1;
            lVar14 = lVar14 + 8;
          } while (lVar3 != null);
          goto LAB_1808ae951;
        }
        LAB_1808abf6e:
        if (0.0 < fVar16) {
          return;
        }
        uVar4 = this.timeLabel;
        this.refreshTime = 0x3e99999a;
        if (((GameController._instance == null) ||
            (lVar3 = GameController._instance.worldData) == null) ||
           (lVar3 = lVar3.worldTime) == null) goto LAB_1808ae951;
        uVar7 = Int32.ToString(lVar3 + 16,0);
        if (((GameController._instance == null) ||
            (lVar3 = GameController._instance.worldData) == null) ||
           (lVar3 = lVar3.worldTime) == null) goto LAB_1808ae951;
        uVar9 = Int32.ToString(lVar3 + 20,0);
        if (((GameController._instance == null) ||
            (lVar3 = GameController._instance.worldData) == null) ||
           (lVar3 = lVar3.worldTime) == null) goto LAB_1808ae951;
        uVar10 = Int32.ToString(lVar3 + 24,0);
        uVar7 = String.Format("{0}年{1}月{2}日",uVar7,uVar9,uVar10,0);
        LTLocalization.SetText(uVar4,uVar7,0);
        lVar3 = this.weatherIcon;
        lVar14 = *pStatics_b8e8;
        lVar5 = *(int64 *)(*(int64 *)(DAT_181e95408 + 184) + 8);
        if (lVar5 == null) goto LAB_1808ae951;
        lVar5 = lVar5.villageAreaID;
        if (((GameController._instance == null) ||
            (lVar6 = GameController._instance.worldData) == null) ||
           (lVar5 == null)) goto LAB_1808ae951;
        uVar13 = lVar6.nowWeather;
        if (lVar5.cityAreaID <= uVar13) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        lVar5 = lVar5.chapter[uVar13];
        if (((lVar5 == null) ||
            (uVar4 = String.Concat("天气_",lVar5.chapter,0), lVar14 == null)) ||
           (uVar4 = TextureController.LoadAtlasSprite(lVar14,"UIAtlas",uVar4,0), lVar3 == null))
        goto LAB_1808ae951;
        Image.set_sprite(lVar3,uVar4,0);
        lVar3 = this.seasonIcon;
        lVar14 = *pStatics_b8e8;
        lVar5 = *(int64 *)(pStatics_38e8 + 0x3d8);
        if ((((GameController._instance == null) ||
             (lVar6 = GameController._instance.worldData) == null) ||
            (lVar6 = lVar6.worldTime) == null) ||
           (iVar2 = Mathf.CeilToInt((float)*(int *)(lVar6 + 20) / 3.0,0), lVar5 == null))
        goto LAB_1808ae951;
        if (lVar5.cityAreaID <= iVar2 - 1U) {
          ThrowHelper.ThrowArgumentOutOfRangeException(0);
        }
        uVar4 = String.Concat("季节_",
                               *(uint64 *)
                                (lVar5.chapter + 32 + (int64)(int)(iVar2 - 1U) * 8),0);
        if ((lVar14 == null) ||
           (uVar4 = TextureController.LoadAtlasSprite(lVar14,"UIAtlas",uVar4,0), lVar3 == null))
        goto LAB_1808ae951;
        Image.set_sprite(lVar3,uVar4,0);
        uVar4 = this.nameLabel;
        if (((GameController._instance == null) ||
            (lVar3 = GameController._instance.worldData) == null) ||
           (lVar3 = WorldData.Player(lVar3,0)) == null) goto LAB_1808ae951;
        LTLocalization.SetText(uVar4,lVar3.AreaMapRandomEventDatas,0);
        uVar4 = this.fightScoreLabel;
        if (((GameController._instance == null) ||
            (lVar3 = GameController._instance.worldData) == null) ||
           (lVar3 = WorldData.Player(lVar3,0)) == null) goto LAB_1808ae951;
        uVar7 = Single.ToString(lVar3 + 0x388,"f0",0);
        LTLocalization.SetText(uVar4,uVar7,0);
        uVar4 = this.fameLabel;
        if (((GameController._instance == null) ||
            (lVar3 = GameController._instance.worldData) == null) ||
           (lVar3 = WorldData.Player(lVar3,0)) == null) goto LAB_1808ae951;
        uVar7 = Single.ToString(lVar3 + 0x1c4,"f0",0);
        LTLocalization.SetText(uVar4,uVar7,0);
        uVar4 = this.badfameLabel;
        if (((GameController._instance == null) ||
            (lVar3 = GameController._instance.worldData) == null) ||
           (lVar3 = WorldData.Player(lVar3,0)) == null) goto LAB_1808ae951;
        uVar7 = Single.ToString(lVar3 + 0x1c8,"f0",0);
        LTLocalization.SetText(uVar4,uVar7,0);
        plVar11 = this.badfameLabel;
        if (((GameController._instance == null) ||
            (lVar3 = GameController._instance.worldData) == null) ||
           (lVar3 = WorldData.Player(lVar3,0)) == null) goto LAB_1808ae951;
        if (lVar3.thisYearExploreSpeEventNum < *(float *)(pStatics_38e8 + 0x130)) {
          if (((GameController._instance == null) ||
              (lVar3 = GameController._instance.worldData) == null) ||
             (lVar3 = WorldData.Player(lVar3,0)) == null) goto LAB_1808ae951;
          if (lVar3.thisYearExploreSpeEventNum <= 0.0) {
            puVar8 = (uint64 *)FUN_180f24d00(&local_78,0);
          }
          else {
            puVar8 = (uint64 *)Color.get_yellow();
          }
        }
        else {
          puVar8 = (uint64 *)Color.get_red(&local_78,0);
        }
        if (plVar11 == (int64 *)0) goto LAB_1808ae951;
        local_78 = *puVar8;
        uStack_70 = puVar8[1];
        (**(code **)(*plVar11 + 0x2a8))(plVar11,&local_78,*(uint64 *)(*plVar11 + 0x2b0));
        if (this.badfameIcon == null) goto LAB_1808ae951;
        plVar11 = (int64 *)GameObject.GetComponent(this.badfameIcon,DAT_181e54f48);
        if (((GameController._instance == null) ||
            (lVar3 = GameController._instance.worldData) == null) ||
           (lVar3 = WorldData.Player(lVar3,0)) == null) goto LAB_1808ae951;
        cVar1 = HeroData.HaveArea(lVar3,0);
        if (!cVar1) {
          lVar3 = FUN_1802106e0(0);
          if (((lVar3 == null) || (lVar3.villageAreaID == null)) ||
             (lVar3 = WorldData.Player(lVar3.villageAreaID,0)) == null) goto LAB_1808ae951;
          if (!lVar3.infos) {
            puVar8 = (uint64 *)FUN_180f24d00(&local_78,0);
          }
          else {
            puVar8 = (uint64 *)Color.get_yellow();
          }
        }
        else {
          puVar8 = (uint64 *)Color.get_red(&local_78,0);
        }
        if (plVar11 == (int64 *)0) goto LAB_1808ae951;
        local_78 = *puVar8;
        uStack_70 = puVar8[1];
        (**(code **)(*plVar11 + 0x2a8))(plVar11,&local_78,*(uint64 *)(*plVar11 + 0x2b0));
        if (this.badfameIcon == null) goto LAB_1808ae951;
        lVar3 = GameObject.GetComponent(this.badfameIcon,DAT_181e56510);
        if (((GameController._instance == null) ||
            (lVar14 = GameController._instance.worldData) == null) ||
           (lVar14 = WorldData.Player(lVar14,0)) == null) goto LAB_1808ae951;
        cVar1 = HeroData.HaveArea(lVar14,0);
        uVar4 = "恶名\n城镇内x200%";
        if (!cVar1) {
          lVar14 = FUN_1802106e0(0);
          if (((lVar14 == null) || (lVar14.villageAreaID == null)) ||
             (lVar14 = WorldData.Player(lVar14.villageAreaID,0)) == null)
          goto LAB_1808ae951;
          uVar4 = "恶名\n野外x100%";
          if (lVar14.infos) {
            uVar4 = "恶名\n安全区内x150%";
          }
        }
        if (lVar3 == null) goto LAB_1808ae951;
        lVar3.Count = uVar4;
        uVar4 = this.moneyLabel;
        if ((((GameController._instance == null) ||
             (lVar3 = GameController._instance.worldData) == null) ||
            (lVar3 = WorldData.Player(lVar3,0)) == null) || (lVar3.speBookStorageSpeAdd == null))
        goto LAB_1808ae951;
        uVar7 = Int32.ToString(lVar3.speBookStorageSpeAdd + 24,0);
        LTLocalization.SetText(uVar4,uVar7,0);
        uVar4 = this.moneyLayout;
        LayoutRebuilder.ForceRebuildLayoutImmediate(uVar4,0);
        uVar4 = this.forceLabel;
        if (((GameController._instance == null) ||
            (lVar3 = GameController._instance.worldData) == null) ||
           (lVar3 = WorldData.Player(lVar3,0)) == null) goto LAB_1808ae951;
        uVar7 = HeroData.GetHeroForceLvDescribe(lVar3,1,0);
        LTLocalization.SetText(uVar4,uVar7,0);
        if (((GameController._instance == null) ||
            (lVar3 = GameController._instance.worldData) == null) ||
           (lVar3 = WorldData.Player(lVar3,0)) == null) goto LAB_1808ae951;
        cVar1 = HeroData.HaveForce(lVar3,0);
        if (!cVar1) {
          lVar3 = FUN_1802106e0(0);
          if (((lVar3 == null) || (lVar3.villageAreaID == null)) ||
             (lVar3 = WorldData.Player(lVar3.villageAreaID,0)) == null) goto LAB_1808ae951;
          cVar1 = HeroData.HaveServantForce(lVar3,0);
          lVar3 = this.forceLabel;
          if (!cVar1) {
            if (lVar3 == null) {
        LAB_1808ae95d:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar3 = Component.GetComponent(lVar3,DAT_181e788b8);
            lVar14 = FUN_1802106e0(0);
            if (((lVar14 == null) || (lVar14.villageAreaID == null)) ||
               (lVar14 = WorldData.Player(lVar14.villageAreaID,0)) == null)
            goto LAB_1808ae95d;
            local_b8 = (float)HeroData.OutsideForceExtraContributionRate(lVar14,0xffffffff);
            local_b8 = local_b8 * 100.0;
            uVar4 = il2cpp_value_box(DAT_181e82730,&local_b8);
            uVar4 = String.Format("官府/所有门派功绩+{0}%",uVar4,0);
            lVar14 = FUN_1802106e0(0);
            if (((lVar14 == null) || (lVar14.villageAreaID == null)) ||
               (lVar14 = WorldData.Player(lVar14.villageAreaID,0)) == null)
            goto LAB_1808ae95d;
            uVar7 = "\n<i><color=#696969>江湖地位由声望直接决定\n达到下一级别需声望{0}</color></i>";
            if (4 < lVar14.forceMeetingStarted) {
              uVar7 = "";
            }
            lVar14 = FUN_1802106e0(0);
            if (((lVar14 == null) || (lVar14.villageAreaID == null)) ||
               (lVar14 = WorldData.Player(lVar14.villageAreaID,0)) == null) {
        LAB_1808ae957:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            local_b4 = (float)HeroData.GetNextForceLvFame(lVar14,0);
            uVar9 = il2cpp_value_box(DAT_181e82730,&local_b4);
            uVar7 = String.Format(uVar7,uVar9,0);
            uVar4 = String.Concat(uVar4,uVar7,0);
            if (lVar3 == null) goto LAB_1808ae957;
            lVar3.Count = uVar4;
          }
          else {
            if (lVar3 == null) {
        LAB_1808ae9e9:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            lVar3 = Component.GetComponent(lVar3,DAT_181e788b8);
            plVar11 = (int64 *)FUN_1801dfd90(DAT_181e84278,4);
            lVar14 = FUN_1802106e0(0);
            if ((lVar14 == null) || (lVar14.villageAreaID == null)) goto LAB_1808ae9e9;
            lVar14 = WorldData.Player(lVar14.villageAreaID,0);
            lVar5 = FUN_1802106e0(0);
            if ((lVar5 == null) ||
               (((lVar5.villageAreaID == null ||
                 (lVar5 = WorldData.Player(lVar5.villageAreaID,0)) == null) || (lVar14 == null))
               )) goto LAB_1808ae9e9;
            local_b4 = (float)HeroData.OutsideForceExtraContributionRate
                                        (lVar14,*(uint32 *)(lVar5 + 0x380),0);
            local_b4 = local_b4 * 100.0;
            lVar14 = il2cpp_value_box(DAT_181e82730,&local_b4);
            if (plVar11 == (int64 *)0) goto LAB_1808ae9e9;
            if ((lVar14 != null) &&
               (lVar5 = il2cpp_internal(lVar14,*(uint64 *)(*plVar11 + 64))) == null) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar4,0);
            }
            if ((int)plVar11[3] == 0) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar4,0);
            }
            plVar11[4] = lVar14;
            il2cpp_internal(plVar11 + 4,lVar14);
            lVar14 = FUN_1802106e0(0);
            if (lVar14 == null) goto LAB_1808ae9e9;
            lVar14 = lVar14.villageAreaID;
            lVar5 = FUN_1802106e0(0);
            if (((lVar5 == null) || (lVar5.villageAreaID == null)) ||
               ((lVar5 = WorldData.Player(lVar5.villageAreaID,0), lVar5 == null ||
                ((lVar14 == null ||
                 (lVar14 = WorldData.GetForce(lVar14,*(uint32 *)(lVar5 + 0x380),0)) == null)))))
            goto LAB_1808ae9e9;
            lVar14 = ForceData.GetForceName(lVar14,1,0);
            if ((lVar14 != null) &&
               (lVar5 = il2cpp_internal(lVar14,*(uint64 *)(*plVar11 + 64))) == null) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar4,0);
            }
            if (*(uint32 *)(plVar11 + 3) < 2) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar4,0);
            }
            plVar11[5] = lVar14;
            il2cpp_internal(plVar11 + 5,lVar14);
            lVar14 = FUN_1802106e0(0);
            if (((lVar14 == null) || (lVar14.villageAreaID == null)) ||
               (lVar14 = WorldData.Player(lVar14.villageAreaID,0)) == null)
            goto LAB_1808ae9e9;
            local_b8 = (float)(int)lVar14.gameDifficulty;
            lVar14 = il2cpp_value_box(DAT_181e60808,&local_b8);
            if ((lVar14 != null) &&
               (lVar5 = il2cpp_internal(lVar14,*(uint64 *)(*plVar11 + 64))) == null) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar4,0);
            }
            if (*(uint32 *)(plVar11 + 3) < 3) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar4,0);
            }
            plVar11[6] = lVar14;
            il2cpp_internal(plVar11 + 6,lVar14);
            lVar14 = FUN_1802106e0(0);
            if ((lVar14 == null) || (lVar14.villageAreaID == null)) goto LAB_1808ae9e9;
            local_b0 = 1 - *(int *)(lVar14.villageAreaID + 0x150);
            lVar14 = il2cpp_value_box(DAT_181e60808,&local_b0);
            if ((lVar14 != null) &&
               (lVar5 = il2cpp_internal(lVar14,*(uint64 *)(*plVar11 + 64))) == null) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar4,0);
            }
            if (*(uint32 *)(plVar11 + 3) < 4) {
              uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
              FUN_1801e02d0(uVar4,0);
            }
            plVar11[7] = lVar14;
            il2cpp_internal(plVar11 + 7,lVar14);
            uVar4 = String.Format("{1}功绩+{0}%\n获得{0}%门派加成效果\n当月功绩可获月俸<b>{2}</b>\n每月刷新门派委托{3}/1次",plVar11,0);
            lVar14 = FUN_1802106e0(0);
            if (((lVar14 == null) || (lVar14.villageAreaID == null)) ||
               (lVar14 = WorldData.Player(lVar14.villageAreaID,0)) == null)
            goto LAB_1808ae9e9;
            uVar7 = "\n<i><color=#696969>门客地位由声望直接决定\n达到下一级别需声望{0}</color></i>";
            if (4 < lVar14.forceMeetingStarted) {
              uVar7 = "";
            }
            lVar14 = FUN_1802106e0(0);
            if (((lVar14 == null) || (lVar14.villageAreaID == null)) ||
               (lVar14 = WorldData.Player(lVar14.villageAreaID,0)) == null) {
        LAB_1808ae9e3:
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            local_ac = HeroData.GetNextForceLvFame(lVar14,0);
            uVar9 = il2cpp_value_box(DAT_181e82730,&local_ac);
            uVar7 = String.Format(uVar7,uVar9,0);
            uVar4 = String.Concat(uVar4,uVar7,0);
            if (lVar3 == null) goto LAB_1808ae9e3;
            lVar3.Count = uVar4;
          }
        }
        else {
          if (this.forceLabel == null) goto LAB_1808ae951;
          lVar3 = Component.GetComponent(this.forceLabel,DAT_181e788b8);
          lVar14 = *(int64 *)(pStatics_38e8 + 0x4c8);
          if (((GameController._instance == null) ||
              (lVar5 = GameController._instance.worldData) == null) ||
             (lVar5 = WorldData.Player(lVar5,0)) == null) goto LAB_1808ae951;
          if (!lVar5.hour) {
            lVar5 = FUN_1802106e0(0);
            if (((lVar5 == null) || (lVar5.villageAreaID == null)) ||
               (lVar5 = WorldData.Player(lVar5.villageAreaID,0)) == null) goto LAB_1808ae951;
            uVar13 = lVar5.forceMeetingStarted;
          }
          else {
            uVar13 = 6;
          }
          if (lVar14 == null) goto LAB_1808ae951;
          if (lVar14.cityAreaID <= uVar13) {
            ThrowHelper.ThrowArgumentOutOfRangeException(0);
          }
          uVar4 = lVar14.chapter[uVar13];
          if (lVar3 == null) goto LAB_1808ae951;
          lVar3.Count = uVar4;
        }
        il2cpp_internal(puVar8,uVar4);
        HudController.RefreshNowResearch(this,0);
        if ((GameController._instance == null) ||
           (lVar3 = GameController._instance.worldData) == null)
        goto LAB_1808ae951;
        lVar3 = WorldData.Player(lVar3,0);
        uVar4 = Component.get_gameObject(this,0);
        if (lVar3 == null) goto LAB_1808ae951;
        HeroData.SetHpBar(lVar3,uVar4,0,0);
        if ((GameController._instance == null) ||
           (lVar3 = GameController._instance.worldData) == null)
        goto LAB_1808ae951;
        lVar3 = WorldData.Player(lVar3,0);
        uVar4 = Component.get_gameObject(this,0);
        if (lVar3 == null) goto LAB_1808ae951;
        HeroData.SetMpBar(lVar3,uVar4,0,0);
        uVar4 = this.externalInjury;
        if (((GameController._instance == null) ||
            (lVar3 = GameController._instance.worldData) == null) ||
           (lVar3 = WorldData.Player(lVar3,0)) == null) goto LAB_1808ae951;
        HudController.FreshHudInjury(this,uVar4,lVar3.studyFightWithGreatHeroMultiWinNum,0);
        uVar4 = this.internalInjury;
        if (((GameController._instance == null) ||
            (lVar3 = GameController._instance.worldData) == null) ||
           (lVar3 = WorldData.Player(lVar3,0)) == null) goto LAB_1808ae951;
        HudController.FreshHudInjury(this,uVar4,lVar3.studyFightWithGreatHeroFinalWinNum,0);
        uVar4 = *(uint64 *)(this + 200);
        if (((GameController._instance == null) ||
            (lVar3 = GameController._instance.worldData) == null) ||
           (lVar3 = WorldData.Player(lVar3,0)) == null) goto LAB_1808ae951;
        HudController.FreshHudInjury(this,uVar4,lVar3.totalHeroMeet,0);
        if (((GameController._instance == null) ||
            (lVar3 = GameController._instance.worldData) == null) ||
           (lVar3 = WorldData.Player(lVar3,0)) == null) goto LAB_1808ae951;
        cVar1 = HeroData.HaveForce(lVar3,0);
        lVar3 = this.forceUI;
        if (!cVar1) {
          if (lVar3 != null) {
            cVar1 = GameObject.get_activeSelf(lVar3,0);
            if (cVar1) {
              if (this.forceUI == null) goto LAB_1808ae951;
              GameObject.SetActive(this.forceUI,0,0);
            }
        LAB_1808ae76d:
            lVar3 = FUN_180210740(0);
            if (lVar3 != null) {
              cVar1 = GameDataController.CanSaveLoad(lVar3,0);
              lVar3 = this.settingButton;
              if (!cVar1) {
                if ((((lVar3 != null) && (lVar3 = GameObject.get_transform(lVar3,0)) != null) &&
                    (lVar3 = Transform.Find(lVar3,"Saving",0)) != null) &&
                   (lVar3 = Component.get_gameObject(lVar3,0)) != null) {
                  cVar1 = GameObject.get_activeSelf(lVar3,0);
                  if (cVar1) {
                    return;
                  }
                  if (((this.settingButton != null) &&
                      (lVar3 = GameObject.get_transform(this.settingButton,0)) != null) &&
                     ((lVar3 = Transform.Find(lVar3,"Saving",0), lVar3 != null &&
                      (lVar3 = Component.get_gameObject(lVar3,0)) != null))) {
                    uVar4 = 1;
                    goto LAB_1808ae85c;
                  }
                }
              }
              else if (((lVar3 != null) && (lVar3 = GameObject.get_transform(lVar3,0)) != null) &&
                      ((lVar3 = Transform.Find(lVar3,"Saving",0), lVar3 != null &&
                       (lVar3 = Component.get_gameObject(lVar3,0)) != null))) {
                cVar1 = GameObject.get_activeSelf(lVar3,0);
                if (!cVar1) {
                  return;
                }
                if ((((this.settingButton != null) &&
                     (lVar3 = GameObject.get_transform(this.settingButton,0)) != null) &&
                    (lVar3 = Transform.Find(lVar3,"Saving",0)) != null) &&
                   (lVar3 = Component.get_gameObject(lVar3,0)) != null) {
                  uVar4 = 0;
        LAB_1808ae85c:
                  GameObject.SetActive(lVar3,uVar4,0);
                  return;
                }
              }
            }
            throw; // [null/range check failed]
          }
          goto LAB_1808ae951;
        }
        if (lVar3 == null) goto LAB_1808ae951;
        cVar1 = GameObject.get_activeSelf(lVar3,0);
        if (!cVar1) {
          if (this.forceUI == null) goto LAB_1808ae951;
          GameObject.SetActive(this.forceUI,1,0);
        }
        uVar4 = this.contributionLabel;
        lVar3 = FUN_1802106e0(0);
        if (((lVar3 == null) || (lVar3.villageAreaID == null)) ||
           (lVar3 = WorldData.Player(lVar3.villageAreaID,0)) == null) goto LAB_1808ae951;
        local_res8[0] = (int)lVar3.playerBookWriter;
        uVar7 = Int32.ToString(local_res8,0);
        lVar3 = FUN_1802106e0(0);
        if (((lVar3 == null) || (lVar3.villageAreaID == null)) ||
           (lVar3 = WorldData.Player(lVar3.villageAreaID,0)) == null) goto LAB_1808ae951;
        local_res8[0] = HeroData.GetUpgradeForceLvNeedContribution(lVar3,0x3f800000,0);
        uVar9 = Int32.ToString(local_res8,0);
        uVar7 = String.Concat(uVar7,"/",uVar9,0);
        LTLocalization.SetText(uVar4,uVar7,0);
        lVar3 = FUN_1802106e0(0);
        if (((lVar3 == null) || (lVar3.villageAreaID == null)) ||
           (lVar3 = WorldData.Player(lVar3.villageAreaID,0)) == null) goto LAB_1808ae951;
        lVar14 = this.forceUI;
        if (!lVar3.hour) {
          if ((lVar14 == null) || (lVar3 = GameObject.get_transform(lVar14,0)) == null)
          goto LAB_1808ae951;
          lVar3 = Transform.Find(lVar3,"ContributionBarBack",0);
          puVar8 = (uint64 *)Vector3.get_one(local_88,0);
          if (lVar3 == null) goto LAB_1808ae951;
          local_90 = *(uint32 *)(puVar8 + 1);
          local_98 = *puVar8;
          Transform.set_localScale(lVar3,&local_98,0);
          if (((this.forceUI == null) ||
              (lVar3 = GameObject.get_transform(this.forceUI,0)) == null) ||
             ((lVar3 = Transform.Find(lVar3,"ContributionBarBack",0), lVar3 == null ||
              (lVar3 = Transform.Find(lVar3,"ContributionBar",0)) == null))) goto LAB_1808ae951;
          lVar3 = Component.GetComponent(lVar3,DAT_181e777b8);
          lVar14 = FUN_1802106e0(0);
          if (((lVar14 == null) || (lVar14.villageAreaID == null)) ||
             (lVar14 = WorldData.Player(lVar14.villageAreaID,0)) == null)
          goto LAB_1808ae951;
          fVar16 = lVar14.playerBookWriter;
          lVar14 = FUN_1802106e0(0);
          if (((lVar14 == null) || (lVar14.villageAreaID == null)) ||
             ((lVar14 = WorldData.Player(lVar14.villageAreaID,0), lVar14 == null ||
              (iVar2 = HeroData.GetUpgradeForceLvNeedContribution(lVar14,0x3f800000,0), lVar3 == null))))
          goto LAB_1808ae951;
          Image.set_fillAmount(lVar3,fVar16 / (float)iVar2,0);
          if ((this.forceUI == null) ||
             (lVar3 = GameObject.get_transform(this.forceUI,0)) == null)
          goto LAB_1808ae951;
          lVar3 = Transform.Find(lVar3,"ContributionFull",0);
          lVar14 = FUN_1802106e0(0);
          if ((lVar14 == null) ||
             ((lVar14.villageAreaID == null ||
              (lVar14 = WorldData.Player(lVar14.villageAreaID,0)) == null)))
          goto LAB_1808ae951;
          fVar16 = lVar14.playerBookWriter;
          lVar14 = FUN_1802106e0(0);
          if ((lVar14 == null) ||
             ((lVar14.villageAreaID == null ||
              (lVar14 = WorldData.Player(lVar14.villageAreaID,0)) == null)))
          goto LAB_1808ae951;
          iVar2 = HeroData.GetUpgradeForceLvNeedContribution(lVar14,0x3f800000,0);
          if (fVar16 < (float)iVar2) {
            puVar8 = (uint64 *)Vector3.get_zero(local_88,0);
          }
          else {
            puVar8 = (uint64 *)Vector3.get_one();
          }
          uVar12 = *(uint32 *)(puVar8 + 1);
          uVar4 = *puVar8;
          if (lVar3 == null) goto LAB_1808ae951;
        }
        else {
          if ((lVar14 == null) || (lVar3 = GameObject.get_transform(lVar14,0)) == null)
          goto LAB_1808ae951;
          lVar3 = Transform.Find(lVar3,"ContributionBarBack",0);
          puVar8 = (uint64 *)Vector3.get_zero(local_88,0);
          if (lVar3 == null) throw; // [null/range check failed]
          local_90 = *(uint32 *)(puVar8 + 1);
          local_98 = *puVar8;
          Transform.set_localScale(lVar3,&local_98,0);
          if ((this.forceUI == null) ||
             (lVar3 = GameObject.get_transform(this.forceUI,0)) == null)
          throw; // [null/range check failed]
          lVar3 = Transform.Find(lVar3,"ContributionFull",0);
          puVar8 = (uint64 *)Vector3.get_zero(local_88,0);
          if (lVar3 == null) throw; // [null/range check failed]
          uVar4 = *puVar8;
          uVar12 = *(uint32 *)(puVar8 + 1);
        }
        local_98 = uVar4;
        local_90 = uVar12;
        Transform.set_localScale(lVar3,&local_98,0);
        uVar4 = this.heroNumLabel;
        lVar3 = FUN_1802106e0(0);
        if (((lVar3 != null) && (lVar3.villageAreaID != null)) &&
           (lVar3 = WorldData.GetHeroForce(lVar3.villageAreaID,0,0)) != null) {
          uVar7 = Int32.ToString(lVar3 + 132,0);
          lVar3 = FUN_1802106e0(0);
          if (((lVar3 != null) && (lVar3.villageAreaID != null)) &&
             (lVar3 = WorldData.GetHeroForce(lVar3.villageAreaID,0,0)) != null) {
            fVar16 = (float)ForceData.GetMaxHeroNum(lVar3,0);
            local_res8[0] = (int)fVar16;
            uVar9 = Int32.ToString(local_res8,0);
            uVar7 = String.Concat(uVar7,"/",uVar9,0);
            LTLocalization.SetText(uVar4,uVar7,0);
            uVar4 = this.areaNumLabel;
            lVar3 = FUN_1802106e0(0);
            if ((((lVar3 != null) && (lVar3.villageAreaID != null)) &&
                (lVar3 = WorldData.GetHeroForce(lVar3.villageAreaID,0,0)) != null) &&
               (lVar3.BigMapRandomEventDatas != null)) {
              local_res8[0] = *(int *)(lVar3.BigMapRandomEventDatas + 24);
              uVar7 = Int32.ToString(local_res8,0);
              lVar3 = FUN_1802106e0(0);
              if (((lVar3 != null) && (lVar3.villageAreaID != null)) &&
                 (lVar3 = WorldData.GetHeroForce(lVar3.villageAreaID,0,0)) != null) {
                fVar16 = (float)ForceData.GetMaxAreaNum(lVar3,0);
                local_res8[0] = (int)fVar16;
                uVar9 = Int32.ToString(local_res8,0);
                uVar7 = String.Concat(uVar7,"/",uVar9,0);
                LTLocalization.SetText(uVar4,uVar7,0);
                local_res18[0] = 0;
                do {
                  iVar2 = local_res18[0];
                  if ((((GameController._instance == null) ||
                       (lVar3 = GameController._instance.worldData) == null)
                      || (lVar3 = WorldData.GetHeroForce(lVar3,0,0)) == null) ||
                     (lVar3.WorldNewsDatas == null)) break;
                  if (*(int *)(lVar3.WorldNewsDatas + 24) <= iVar2) {
                    lVar3 = FUN_1802106e0(0);
                    if (((lVar3 == null) || (lVar3.villageAreaID == null)) ||
                       (lVar3 = WorldData.Player(lVar3.villageAreaID,0)) == null) break;
                    cVar1 = HeroData.HaveForceFunction(lVar3,6);
                    lVar3 = this.forceUI;
                    if (!cVar1) {
                      if ((lVar3 == null) || (lVar3 = GameObject.get_transform(lVar3,0)) == null) break;
                      lVar3 = Transform.Find(lVar3,"SpeResourceNum",0);
                      puVar8 = (uint64 *)Vector3.get_zero(local_88,0);
                      if (lVar3 == null) break;
                      local_90 = *(uint32 *)(puVar8 + 1);
                      local_98 = *puVar8;
                      Transform.set_localScale(lVar3,&local_98,0);
                    }
                    else {
                      if ((lVar3 == null) || (lVar3 = GameObject.get_transform(lVar3,0)) == null) break;
                      lVar3 = Transform.Find(lVar3,"SpeResourceNum",0);
                      puVar8 = (uint64 *)Vector3.get_one(local_88,0);
                      if (lVar3 == null) break;
                      local_90 = *(uint32 *)(puVar8 + 1);
                      local_98 = *puVar8;
                      Transform.set_localScale(lVar3,&local_98,0);
                      if (((this.forceUI == null) ||
                          (lVar3 = GameObject.get_transform(this.forceUI,0)) == null
                          ) || (lVar3 = Transform.Find(lVar3,"SpeResourceNum",0)) == null) break;
                      uVar4 = Component.GetComponent(lVar3,DAT_181e79538);
                      lVar3 = FUN_1802106e0(0);
                      if ((lVar3 == null) || (lVar3.villageAreaID == null)) break;
                      uVar7 = Int32.ToString(lVar3.villageAreaID + 0x230,0);
                      LTLocalization.SetText(uVar4,uVar7,0);
                    }
                    goto LAB_1808ae76d;
                  }
                  if (this.forceUI == null) break;
                  lVar3 = GameObject.get_transform(this.forceUI,0);
                  uVar4 = Int32.ToString(local_res18,0);
                  if ((lVar3 == null) || (lVar3 = Transform.Find(lVar3,uVar4,0)) == null) break;
                  uVar4 = Component.GetComponent(lVar3,DAT_181e79538);
                  lVar3 = FUN_1802106e0(0);
                  if ((((lVar3 == null) || (lVar3.villageAreaID == null)) ||
                      (lVar3 = WorldData.GetHeroForce(lVar3.villageAreaID,0,0)) == null) ||
                     (lVar3.WorldNewsDatas == null)) break;
                  fVar16 = (float)FUN_1800024e0(lVar3.WorldNewsDatas,local_res18[0],DAT_181e83530);
                  local_res8[0] = (int)fVar16;
                  uVar7 = Int32.ToString(local_res8,0);
                  lVar3 = FUN_1802106e0(0);
                  if (((lVar3 == null) || (lVar3.villageAreaID == null)) ||
                     ((lVar3 = WorldData.GetHeroForce(lVar3.villageAreaID,0,0), lVar3 == null ||
                      (lVar3.MailDatas == null)))) break;
                  fVar16 = (float)FUN_1800024e0(lVar3.MailDatas,local_res18[0],DAT_181e83530);
                  local_res8[0] = (int)fVar16;
                  uVar9 = Int32.ToString(local_res8,0);
                  uVar7 = String.Concat(uVar7,"/",uVar9,0);
                  LTLocalization.SetText(uVar4,uVar7,0);
                  lVar3 = FUN_1802106e0(0);
                  if ((((lVar3 == null) || (lVar3.villageAreaID == null)) ||
                      (lVar3 = WorldData.GetHeroForce(lVar3.villageAreaID,0,0)) == null) ||
                     (lVar3.cheating == null)) break;
                  fVar16 = (float)FUN_1800024e0(lVar3.cheating,local_res18[0]);
                  lVar3 = this.forceUI;
                  if (fVar16 == 0.0) {
                    if (lVar3 == null) break;
                    lVar3 = GameObject.get_transform(lVar3,0);
                    uVar4 = Int32.ToString(local_res18,0);
                    if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,uVar4)) == null) ||
                       (lVar3 = Transform.Find(lVar3,"Add")) == null) break;
                    uVar4 = Component.GetComponent(lVar3,DAT_181e79538);
                    LTLocalization.SetText(uVar4);
                  }
                  else {
                    if (lVar3 == null) break;
                    lVar3 = GameObject.get_transform(lVar3,0);
                    uVar4 = Int32.ToString(local_res18,0);
                    if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,uVar4,0)) == null) ||
                       (lVar3 = Transform.Find(lVar3,"Add",0)) == null) break;
                    uVar4 = Component.GetComponent(lVar3,DAT_181e79538);
                    lVar3 = FUN_1802106e0(0);
                    if ((((lVar3 == null) || (lVar3.villageAreaID == null)) ||
                        (lVar3 = WorldData.GetHeroForce(lVar3.villageAreaID,0,0)) == null) ||
                       (lVar3.cheating == null)) break;
                    local_res20[0] =
                         (float)FUN_1800024e0(lVar3.cheating,local_res18[0],DAT_181e83530);
                    uVar7 = Single.ToString(local_res20,"+0;-0;0",0);
                    LTLocalization.SetText(uVar4,uVar7,0);
                    if (this.forceUI == null) break;
                    lVar3 = GameObject.get_transform(this.forceUI,0);
                    uVar4 = Int32.ToString(local_res18,0);
                    if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,uVar4,0)) == null) ||
                       (lVar3 = Transform.Find(lVar3,"Add",0)) == null) break;
                    plVar11 = (int64 *)Component.GetComponent(lVar3,DAT_181e79538);
                    lVar3 = FUN_1802106e0(0);
                    if ((((lVar3 == null) || (lVar3.villageAreaID == null)) ||
                        (lVar3 = WorldData.GetHeroForce(lVar3.villageAreaID,0,0)) == null) ||
                       (lVar3.cheating == null)) break;
                    fVar16 = (float)FUN_1800024e0(lVar3.cheating,local_res18[0],DAT_181e83530
                                                 );
                    if (fVar16 <= 0.0) {
                      uVar4 = *(uint64 *)(pStatics_38e8 + 0x2f8);
                      uVar7 = *(uint64 *)(pStatics_38e8 + 0x300);
                    }
                    else {
                      uVar4 = *(uint64 *)(pStatics_38e8 + 0x290);
                      uVar7 = *(uint64 *)(pStatics_38e8 + 0x298);
                    }
                    if (plVar11 == (int64 *)0) break;
                    local_78 = uVar4;
                    uStack_70 = uVar7;
                    (**(code **)(*plVar11 + 0x2a8))(plVar11);
                  }
                  if (local_res18[0] == 0) {
                    if (this.forceUI == null) {
        LAB_1808ae9ef:
                          // WARNING: Subroutine does not return
                      FUN_1801e0300();
                    }
                    lVar3 = GameObject.get_transform(this.forceUI,0);
                    uVar4 = Int32.ToString(local_res18,0);
                    if (((lVar3 == null) || (lVar3 = Transform.Find(lVar3,uVar4,0)) == null) ||
                       (lVar3 = Transform.Find(lVar3,"Icon",0)) == null) goto LAB_1808ae9ef;
                    lVar3 = Component.GetComponent(lVar3,DAT_181e788b8);
                    lVar14 = FUN_1802106e0(0);
                    if (((lVar14 == null) || (lVar14.villageAreaID == null)) ||
                       (lVar14 = WorldData.GetHeroForce(lVar14.villageAreaID,0,0)) == null)
                    goto LAB_1808ae9ef;
                    local_ac = ForceData.GetRealSalaryCost(lVar14,0);
                    uVar4 = il2cpp_value_box(DAT_181e60808,&local_ac);
                    lVar14 = FUN_1802106e0(0);
                    if (((lVar14 == null) || (lVar14.villageAreaID == null)) ||
                       (lVar14 = WorldData.GetHeroForce(lVar14.villageAreaID,0,0)) == null)
                    goto LAB_1808ae9ef;
                    local_res20[0] = (float)ForceData.GetSalaryRate(lVar14,0);
                    local_res20[0] = local_res20[0] * 100.0;
                    Single.ToString(local_res20,"f0",0);
                    uVar4 = String.Format("门派银钱\n♦门派银钱消耗包含弟子月俸总计{0}两({1}%)\n♦若月底门派银钱告罄，会导致全派弟子忠诚-20",uVar4);
                    if (lVar3 == null) goto LAB_1808ae9ef;
                    lVar3.Count = uVar4;
                  }
                  local_res18[0] = local_res18[0] + 1;
                } while( true );
              }
            }
          }
        }
    }

    // Token : 0x60018B9
    // RVA   : 0x8AA860   Offset: 0x8A9660   Length: 0x969
    public void RefreshNowResearch()
    {
        bool cVar1;
        long lVar2;
        long lVar3;
        ulong uVar4;
        ulong uVar5;
        long lVar7;
        float fVar8;
        ushort[] local_res18 = new ushort[4];
        uint[] local_res20 = new uint[2];
        uint[] local_18 = new uint[4];
        if (((GameController._instance == null) ||
            (lVar2 = GameController._instance.worldData) == null) ||
           (lVar2 = WorldData.Player(lVar2,0)) == null) throw; // [null/range check failed]
        lVar2 = HeroData.GetForce(lVar2,0,0);
        if (lVar2 != null) {
          if ((((GameController._instance == null) ||
               (lVar2 = GameController._instance.worldData) == null) ||
              (lVar2 = WorldData.Player(lVar2,0)) == null) ||
             (lVar2 = HeroData.GetForce(lVar2,0,0)) == null) throw; // [null/range check failed]
          lVar2 = ForceData.GetNowResearchTech(lVar2,0);
          if (lVar2 != null) {
            if (this.nowResearch != null) {
              cVar1 = GameObject.get_activeSelf(this.nowResearch,0);
              if (!cVar1) {
                if (this.nowResearch == null) throw; // [null/range check failed]
                GameObject.SetActive(this.nowResearch,1,0);
              }
              if (((this.nowResearch != null) &&
                  (lVar2 = GameObject.get_transform(this.nowResearch,0)) != null) &&
                 (lVar2 = Transform.Find(lVar2,"Bar",0)) != null) {
                lVar2 = Component.GetComponent(lVar2,DAT_181e777b8);
                lVar3 = FUN_1802106e0(0);
                if (((((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
                     (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) != null) &&
                    ((lVar3 = HeroData.GetForce(lVar3,0,0), lVar3 != null &&
                     (lVar3 = ForceData.GetNowResearchTech(lVar3,0)) != null))) && (lVar2 != null)) {
                  Image.set_fillAmount(lVar2,*(uint32 *)(lVar3 + 24),0);
                  if (((this.nowResearch != null) &&
                      (lVar2 = GameObject.get_transform(this.nowResearch,0)) != null) &&
                     (lVar2 = Transform.Find(lVar2,"Text",0)) != null) {
                    uVar4 = Component.GetComponent(lVar2,DAT_181e79538);
                    lVar2 = FUN_1802106e0(0);
                    if ((((lVar2 != null) && (lVar2.villageAreaID != null)) &&
                        (lVar2 = WorldData.Player(lVar2.villageAreaID,0)) != null) &&
                       (((lVar2 = HeroData.GetForce(lVar2,0,0), lVar2 != null &&
                         (lVar2 = ForceData.GetNowResearchTech(lVar2,0)) != null) &&
                        ((lVar2 = ForceTechLvData.Database(lVar2,0), lVar2 != null &&
                         (lVar2.cityAreaID != null)))))) {
                      local_res18[0] = String.get_Chars(lVar2.cityAreaID,0,0);
                      uVar5 = Char.ToString(local_res18,0);
                      LTLocalization.SetText(uVar4,uVar5,0);
                      if (this.nowResearch != null) {
                        lVar2 = GameObject.GetComponent(this.nowResearch,DAT_181e56510);
                        plVar6 = (int64 *)FUN_1801dfd90(DAT_181e84278,4);
                        lVar3 = FUN_1802106e0(0);
                        if (((((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
                             (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) != null) &&
                            ((lVar3 = HeroData.GetForce(lVar3,0,0), lVar3 != null &&
                             (lVar3 = ForceData.GetNowResearchTech(lVar3,0)) != null))) &&
                           (lVar3 = ForceTechLvData.Database(lVar3,0)) != null) {
                          uVar4 = *(uint64 *)(lVar3 + 24);
                          lVar3 = FUN_1802106e0(0);
                          if (((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
                             ((lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0), lVar3 != null &&
                              ((lVar3 = HeroData.GetForce(lVar3,0,0), lVar3 != null &&
                               (lVar3 = ForceData.GetNowResearchTech(lVar3,0)) != null))))) {
                            uVar5 = Int32.ToString(lVar3 + 20,0);
                            lVar3 = String.Concat(uVar4,"等级",uVar5,0);
                            if (plVar6 != (int64 *)0) {
                              if ((lVar3 != null) &&
                                 (lVar7 = il2cpp_internal(lVar3,*(uint64 *)(*plVar6 + 64)),
                                 lVar7 == null)) {
                                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1801e02d0(uVar4,0);
                              }
                              if ((int)plVar6[3] == 0) {
                                uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                FUN_1801e02d0(uVar4,0);
                              }
                              plVar6[4] = lVar3;
                              il2cpp_internal(plVar6 + 4,lVar3);
                              lVar3 = FUN_1802106e0(0);
                              if ((((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
                                  (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0)) != null)
                                 && (lVar3 = HeroData.GetForce(lVar3,0,0)) != null) {
                                lVar3 = ForceData.GetNowResearchTech(lVar3,0);
                                lVar7 = FUN_1802106e0(0);
                                if ((((lVar7 != null) && (*(int64 *)(lVar7 + 32) != 0)) &&
                                    ((lVar7 = WorldData.Player(*(int64 *)(lVar7 + 32),0), lVar7 != null
                                     && ((lVar7 = HeroData.GetForce(lVar7,0,0), lVar7 != null &&
                                         (*(int64 *)(lVar7 + 0x148) != 0)))))) &&
                                   (fVar8 = (float)ForceSpeAddData.Get(*(int64 *)(lVar7 + 0x148),4),
                                   lVar3 != null)) {
                                  local_res20[0] =
                                       ForceTechLvData.GetResearchLeftDay(lVar3,fVar8 + 1.0,0);
                                  lVar3 = il2cpp_value_box(DAT_181e60808,local_res20);
                                  if ((lVar3 != null) &&
                                     (lVar7 = il2cpp_internal(lVar3,*(uint64 *)(*plVar6 + 64)),
                                     lVar7 == null)) {
                                    uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1801e02d0(uVar4,0);
                                  }
                                  if (*(uint32 *)(plVar6 + 3) < 2) {
                                    uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                    FUN_1801e02d0(uVar4,0);
                                  }
                                  plVar6[5] = lVar3;
                                  il2cpp_internal(plVar6 + 5,lVar3);
                                  lVar3 = FUN_1802106e0(0);
                                  if ((((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
                                      (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0),
                                      lVar3 != null)) && (lVar3 = HeroData.GetForce(lVar3,0,0)) != null)
                                  {
                                    lVar3 = ForceData.GetNowResearchTech(lVar3,0);
                                    lVar7 = FUN_1802106e0(0);
                                    if ((((lVar7 != null) && (*(int64 *)(lVar7 + 32) != 0)) &&
                                        ((lVar7 = WorldData.Player(*(int64 *)(lVar7 + 32),0),
                                         lVar7 != null &&
                                         ((lVar7 = HeroData.GetForce(lVar7,0,0), lVar7 != null &&
                                          (lVar7 = ForceData.GetNowResearchTech(lVar7,0)) != null))))
                                        ) && (lVar3 != null)) {
                                      lVar3 = ForceTechLvData.GetSpeDescribe
                                                        (lVar3,*(int *)(lVar7 + 20) + 1,0);
                                      if ((lVar3 != null) &&
                                         (lVar7 = il2cpp_internal(lVar3,*(uint64 *)
                                                                             (*plVar6 + 64)), lVar7 == null
                                         )) {
                                        uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                        FUN_1801e02d0(uVar4,0);
                                      }
                                      if (*(uint32 *)(plVar6 + 3) < 3) {
                                        uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                        FUN_1801e02d0(uVar4,0);
                                      }
                                      plVar6[6] = lVar3;
                                      il2cpp_internal(plVar6 + 6,lVar3);
                                      lVar3 = FUN_1802106e0(0);
                                      if ((((lVar3 != null) && (*(int64 *)(lVar3 + 32) != 0)) &&
                                          (lVar3 = WorldData.Player(*(int64 *)(lVar3 + 32),0),
                                          lVar3 != null)) &&
                                         ((lVar3 = HeroData.GetForce(lVar3,0,0), lVar3 != null &&
                                          (lVar3 = ForceData.GetNowResearchTech(lVar3,0)) != null)))
                                      {
                                        local_18[0] = Mathf.FloorToInt(*(float *)(lVar3 + 24) * 100.0,0
                                                                       );
                                        lVar3 = Int32.ToString(local_18,"f0",0);
                                        if ((lVar3 != null) &&
                                           (lVar7 = il2cpp_internal(lVar3,*(uint64 *)
                                                                               (*plVar6 + 64)),
                                           lVar7 == null)) {
                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                          FUN_1801e02d0(uVar4,0);
                                        }
                                        if (*(uint32 *)(plVar6 + 3) < 4) {
                                          uVar4 = il2cpp_internal();
                          // WARNING: Subroutine does not return
                                          FUN_1801e02d0(uVar4,0);
                                        }
                                        plVar6[7] = lVar3;
                                        il2cpp_internal(plVar6 + 7,lVar3);
                                        uVar4 = String.Format("正在研究 {0}\n下一等级 {2}\n剩余时间 {1}日({3}%)",plVar6,0);
                                        if (lVar2 != null) {
                                          lVar2.cityAreaID = uVar4;
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
                          // WARNING: Subroutine does not return
              FUN_1801e0300();
            }
            throw; // [null/range check failed]
          }
        }
        if (this.nowResearch != null) {
          cVar1 = GameObject.get_activeSelf(this.nowResearch,0);
          if (!cVar1) {
            return;
          }
          if (this.nowResearch != null) {
            GameObject.SetActive(this.nowResearch,0,0);
            return;
          }
        }
    }

    // Token : 0x60018BA
    // RVA   : 0x8AA340   Offset: 0x8A9140   Length: 0x290
    public void FreshHudInjury(GameObject targetObj, float targetNum)
    {
        ulong uVar1;
        ulong uVar2;
        bool cVar3;
        long lVar4;
        uint[] local_res18 = new uint[4];
        if (targetObj != null) {
          if (targetNum <= 0.0) {
            cVar3 = GameObject.get_activeSelf(targetObj);
            if (!cVar3) {
              return;
            }
            GameObject.SetActive(targetObj,0,0);
            return;
          }
          cVar3 = GameObject.get_activeSelf(targetObj,0);
          if (!cVar3) {
            GameObject.SetActive(targetObj,1,0);
          }
          lVar4 = GameObject.get_transform(targetObj,0);
          if (((lVar4 != null) && (lVar4 = Transform.Find(lVar4,"Text",0)) != null) &&
             (plVar5 = (int64 *)Component.GetComponent(lVar4,DAT_181e79538), plVar5 != (int64 *)0
             )) {
            uVar1 = (**(code **)(*plVar5 + 0x5d8))(plVar5,*(uint64 *)(*plVar5 + 0x5e0));
            local_res18[0] = Mathf.CeilToInt(targetNum,0);
            uVar2 = Int32.ToString(local_res18,"f0",0);
            cVar3 = String.op_Inequality(uVar1,uVar2,0);
            if (!cVar3) {
              return;
            }
            lVar4 = GameObject.get_transform(targetObj,0);
            if ((lVar4 != null) && (lVar4 = Transform.Find(lVar4,"Text",0)) != null) {
              uVar1 = Component.GetComponent(lVar4,DAT_181e79538);
              Mathf.CeilToInt(targetNum,0);
              GlobalData.DoTweenTextValue(uVar1);
              uVar1 = GameObject.get_transform(targetObj,0);
              cVar3 = DOTween.IsTweening(uVar1,1,0);
              if (cVar3) {
                return;
              }
              uVar1 = GameObject.get_transform(targetObj,0);
              uVar1 = ShortcutExtensions.DOScale(uVar1);
              uVar1 = TweenSettingsExtensions.SetUpdate(uVar1,1,DAT_181ea59e0);
              TweenSettingsExtensions.SetLoops(uVar1,2,1,DAT_181ea4f40);
              return;
            }
          }
        }
    }

    // Token : 0x60018BB
    // RVA   : 0x8AA200   Offset: 0x8A9000   Length: 0x56
    public void AddHudResourceShowData(HudResourceShowData newData)
    {
        if (this.hudResourceShowDatas != null) {
          FUN_18175de30(this.hudResourceShowDatas,newData,DAT_181e6ec70);
          return;
        }
    }

    // Token : 0x60018BC
    // RVA   : 0x8AA7D0   Offset: 0x8A95D0   Length: 0x8B
    public void RefreshHeroSkeleton()
    {
        long lVar1;
        ulong uVar2;
        if (this.heroFace != null) {
          lVar1 = GameObject.GetComponent(this.heroFace,DAT_181e56400);
          if (lVar1 != null) {
            lVar1 = *(int64 *)(lVar1 + 24);
            if (this.heroFace != null) {
              uVar2 = GameObject.get_transform(this.heroFace,0);
              if (lVar1 != null) {
                HeroData.SetSkeletonGraphic(lVar1,uVar2,0xffffff9d,0xffffffff,0);
                return;
              }
            }
          }
        }
    }

    // Token : 0x60018BD
    // RVA   : 0x8AA7A0   Offset: 0x8A95A0   Length: 0x26
    private void LateUpdate()
    {
        if (this.needRefreshPlayerSkeleton) {
          HudController.RefreshHeroSkeleton(this,0);
          this.needRefreshPlayerSkeleton = 0;
        }
    }

    // Token : 0x60018BE
    // RVA   : 0x8AA720   Offset: 0x8A9520   Length: 0x77
    public void InfoButtonClicked()
    {
        this.showInfoList = !this.showInfoList;
        if (this.infoList != null) {
          plVar1 = (int64 *)GameObject.GetComponent(this.infoList,DAT_181e57588);
          if (plVar1 != (int64 *)0) {
                          // WARNING: Could not recover jumptable at 0x0001808aa78b. Too many branches
                          // WARNING: Treating indirect jump as call
            (**(code **)(*plVar1 + 0x188))
                      (plVar1,this.showInfoList,*(uint64 *)(*plVar1 + 400));
            return;
          }
        }
    }

    // Token : 0x60018BF
    // RVA   : 0x8AA5E0   Offset: 0x8A93E0   Length: 0x13D
    public bool HudPanelActive()
    {
        var pStatics_0a28 = *(int64*)(DAT_181e50a28 + 184);
        var pStatics_2980 = *(int64*)(DAT_181e52980 + 184);
        var pStatics_43e8 = *(int64*)(DAT_181e743e8 + 184);
        var pStatics_5e18 = *(int64*)(DAT_181e55e18 + 184);
        long lVar1;
        bool cVar2;
        ulong uVar3;
        if ((*pStatics_43e8 != 0) &&
           (lVar1 = *(int64 *)(*pStatics_43e8 + 32)) != null) {
          cVar2 = GameObject.get_activeSelf(lVar1,0);
          if (cVar2) {
            return true;
          }
          if ((*pStatics_0a28 != 0) &&
             (lVar1 = *(int64 *)(*pStatics_0a28 + 24)) != null) {
            cVar2 = GameObject.get_activeSelf(lVar1,0);
            if (cVar2) {
              return true;
            }
            if ((*pStatics_5e18 != 0) &&
               (lVar1 = *(int64 *)(*pStatics_5e18 + 24)) != null) {
              cVar2 = GameObject.get_activeSelf(lVar1,0);
              if (cVar2) {
                return true;
              }
              if ((*pStatics_2980 != 0) &&
                 (lVar1 = *(int64 *)(*pStatics_2980 + 24)) != null) {
                uVar3 = GameObject.get_activeSelf(lVar1,0);
                return uVar3;
              }
            }
          }
        }
    }

    // Token : 0x60018C0
    // RVA   : 0x8AEA00   Offset: 0x8AD800   Length: 0x79
    public void /*ctor*/()
    {
        ulong uVar1;
        uVar1 = il2cpp_internal(DAT_181e73638);
        FUN_1810f3480(uVar1,DAT_181e6ebf0);
        this.hudResourceShowDatas = uVar1;
        FUN_180ae8740(this,0);
    }

}
